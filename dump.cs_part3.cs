	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6ABD30 Offset: 0x6AAF30 VA: 0x1806ABD30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimonSaysGame.<FlashButton>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1593
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int id; // 0x20
	public SimonSaysGame <>4__this; // 0x28
	public SpriteRenderer butt; // 0x30
	public float flashTime; // 0x38
	private Color <c>5__2; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6ABE10 Offset: 0x6AB010 VA: 0x1806ABE10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AC010 Offset: 0x6AB210 VA: 0x1806AC010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultMember("Item")]
public class SimonSaysGame : Minigame // TypeDefIndex: 1594
{
	// Fields
	private Queue<int> operations; // 0x88
	private const int FlashOp = 256;
	private const int AnimateOp = 128;
	private const int ReAnimateOp = 32;
	private const int FailOp = 64;
	private Color gray; // 0x90
	private Color blue; // 0xA0
	private Color red; // 0xB0
	private Color green; // 0xC0
	public SpriteRenderer[] LeftSide; // 0xD0
	public SpriteRenderer[] Buttons; // 0xD8
	public SpriteRenderer[] LeftLights; // 0xE0
	public SpriteRenderer[] RightLights; // 0xE8
	private float flashTime; // 0xF0
	private float userButtonFlashTime; // 0xF4
	public AudioClip ButtonPressSound; // 0xF8
	public AudioClip FailSound; // 0x100
	public Transform selectorHighlightObject; // 0x108
	public float diagonalRoundingWidth; // 0x110
	public float inputAngleIndex; // 0x114
	public int roundDownIndex; // 0x118
	public int roundUpIndex; // 0x11C
	private int[] orderedButtonIndices; // 0x120

	// Properties
	private int IndexCount { get; set; }
	private byte Item { get; set; }

	// Methods

	// RVA: 0x638370 Offset: 0x637570 VA: 0x180638370
	private int get_IndexCount() { }

	// RVA: 0x6383E0 Offset: 0x6375E0 VA: 0x1806383E0
	private void set_IndexCount(int value) { }

	// RVA: 0x6AA410 Offset: 0x6A9610 VA: 0x1806AA410
	private byte get_Item(int idx) { }

	// RVA: 0x6AA450 Offset: 0x6A9650 VA: 0x1806AA450
	private void set_Item(int idx, byte value) { }

	// RVA: 0x6A9960 Offset: 0x6A8B60 VA: 0x1806A9960 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6A9CA0 Offset: 0x6A8EA0 VA: 0x1806A9CA0
	public void HitButton(int bIdx) { }

	[IteratorStateMachine(typeof(SimonSaysGame.<CoRun>d__31))]
	// RVA: 0x6A9BB0 Offset: 0x6A8DB0 VA: 0x1806A9BB0
	private IEnumerator CoRun() { }

	// RVA: 0x6A98E0 Offset: 0x6A8AE0 VA: 0x1806A98E0
	private void AddIndex(int idxToAdd) { }

	[IteratorStateMachine(typeof(SimonSaysGame.<CoAnimateNewLeftSide>d__33))]
	// RVA: 0x6A9AF0 Offset: 0x6A8CF0 VA: 0x1806A9AF0
	private IEnumerator CoAnimateNewLeftSide() { }

	[IteratorStateMachine(typeof(SimonSaysGame.<CoAnimateOldLeftSide>d__34))]
	// RVA: 0x6A9B50 Offset: 0x6A8D50 VA: 0x1806A9B50
	private IEnumerator CoAnimateOldLeftSide() { }

	[IteratorStateMachine(typeof(SimonSaysGame.<FlashButton>d__35))]
	// RVA: 0x6A9C10 Offset: 0x6A8E10 VA: 0x1806A9C10
	private IEnumerator FlashButton(int id, SpriteRenderer butt, float flashTime) { }

	// RVA: 0x6AA120 Offset: 0x6A9320 VA: 0x1806AA120
	private void SetLights(SpriteRenderer[] lights, int num) { }

	// RVA: 0x6A9FB0 Offset: 0x6A91B0 VA: 0x1806A9FB0
	private void SetAllColor(Color color) { }

	// RVA: 0x6AA0D0 Offset: 0x6A92D0 VA: 0x1806AA0D0
	private void SetButtonColor(int i, Color color) { }

	// RVA: 0x6AA1C0 Offset: 0x6A93C0 VA: 0x1806AA1C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnlockManifoldsMinigame.<ResetAll>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1595
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UnlockManifoldsMinigame <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6AC2B0 Offset: 0x6AB4B0 VA: 0x1806AC2B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AC620 Offset: 0x6AB820 VA: 0x1806AC620 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class UnlockManifoldsMinigame : Minigame // TypeDefIndex: 1596
{
	// Fields
	public SpriteRenderer[] Buttons; // 0x88
	public byte SystemId; // 0x90
	private int buttonCounter; // 0x94
	private bool animating; // 0x98
	public AudioClip PressButtonSound; // 0xA0
	public AudioClip FailSound; // 0xA8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xB0
	public UiElement DefaultButtonSelected; // 0xB8
	public List<UiElement> ControllerSelectable; // 0xC0

	// Methods

	// RVA: 0x6AD340 Offset: 0x6AC540 VA: 0x1806AD340
	private void OnDisable() { }

	// RVA: 0x6ACE40 Offset: 0x6AC040 VA: 0x1806ACE40 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6AD120 Offset: 0x6AC320 VA: 0x1806AD120
	public void HitButton(int idx) { }

	[IteratorStateMachine(typeof(UnlockManifoldsMinigame.<ResetAll>d__12))]
	// RVA: 0x6AD3B0 Offset: 0x6AC5B0 VA: 0x1806AD3B0
	private IEnumerator ResetAll() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RedeemCosmeticPopup.<>c__DisplayClass3_0 // TypeDefIndex: 1597
{
	// Fields
	public RedeemCosmeticPopup <>4__this; // 0x10
	public AddressableAsset<NamePlateViewData> viewAsset; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC9D0 Offset: 0x6ABBD0 VA: 0x1806AC9D0
	internal void <SetRedeemablePopup>b__0() { }
}

// Namespace: 
public class RedeemCosmeticPopup : MonoBehaviour // TypeDefIndex: 1598
{
	// Fields
	public TextMeshPro cosmeticText; // 0x20
	public StoreMannequin storeMannequin; // 0x28
	public SpriteRenderer dummyNameplate; // 0x30

	// Methods

	// RVA: 0x6A6A90 Offset: 0x6A5C90 VA: 0x1806A6A90
	public void SetRedeemablePopup(CosmeticData cosmetic) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegionTextMonitor.<GetRegionText>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1599
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RegionTextMonitor <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6AC050 Offset: 0x6AB250 VA: 0x1806AC050 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AC270 Offset: 0x6AB470 VA: 0x1806AC270 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class RegionTextMonitor : MonoBehaviour // TypeDefIndex: 1600
{
	// Methods

	// RVA: 0x6A6DB0 Offset: 0x6A5FB0 VA: 0x1806A6DB0
	private void Start() { }

	[IteratorStateMachine(typeof(RegionTextMonitor.<GetRegionText>d__1))]
	// RVA: 0x6A6D50 Offset: 0x6A5F50 VA: 0x1806A6D50
	private IEnumerator GetRegionText() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ResSetter : MonoBehaviour // TypeDefIndex: 1601
{
	// Fields
	public int Width; // 0x20
	public int Height; // 0x24
	private int cnt; // 0x28

	// Methods

	// RVA: 0x6A6E60 Offset: 0x6A6060 VA: 0x1806A6E60
	public void Start() { }

	// RVA: 0x6A6E80 Offset: 0x6A6080 VA: 0x1806A6E80
	public void Update() { }

	// RVA: 0x6A6F20 Offset: 0x6A6120 VA: 0x1806A6F20
	public void .ctor() { }
}

// Namespace: 
public class DebugTest : MonoBehaviour // TypeDefIndex: 1602
{
	// Fields
	private GUIText _guiText; // 0x20
	private StringBuilder _sb; // 0x28
	private byte[] deviceIdBuffer; // 0x30

	// Methods

	// RVA: 0x699E60 Offset: 0x699060 VA: 0x180699E60
	private void Awake() { }

	// RVA: 0x69A810 Offset: 0x699A10 VA: 0x18069A810
	private void Update() { }

	// RVA: 0x69A040 Offset: 0x699240 VA: 0x18069A040
	private void Log(object text) { }

	// RVA: 0x69A770 Offset: 0x699970 VA: 0x18069A770
	private void Log(byte[] buffer) { }

	// RVA: 0x699FD0 Offset: 0x6991D0 VA: 0x180699FD0
	private void LogLine(object text) { }

	// RVA: 0x699F10 Offset: 0x699110 VA: 0x180699F10
	private void LogLine(string prefix, object text) { }

	// RVA: 0x69A070 Offset: 0x699270 VA: 0x18069A070
	private void Log(Joystick joy) { }

	// RVA: 0x69ABC0 Offset: 0x699DC0 VA: 0x18069ABC0
	public void .ctor() { }
}

// Namespace: 
public enum RoleEffectAnimation.SoundType // TypeDefIndex: 1603
{
	// Fields
	public int value__; // 0x0
	public const RoleEffectAnimation.SoundType None = 0;
	public const RoleEffectAnimation.SoundType Local = 1;
	public const RoleEffectAnimation.SoundType Global = 2;
}

// Namespace: 
public enum RoleEffectAnimation.EffectType // TypeDefIndex: 1604
{
	// Fields
	public int value__; // 0x0
	public const RoleEffectAnimation.EffectType Default = 0;
	public const RoleEffectAnimation.EffectType ProtectLoop = 1;
	public const RoleEffectAnimation.EffectType Shapeshift = 2;
	public const RoleEffectAnimation.EffectType Vanish_Charge = 3;
	public const RoleEffectAnimation.EffectType Vanish_Poof = 4;
	public const RoleEffectAnimation.EffectType Appear_Poof = 5;
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleEffectAnimation.<CoPlay>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1605
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoleEffectAnimation <>4__this; // 0x20
	public PlayerControl parent; // 0x28
	public bool parentTransform; // 0x30
	public bool flipX; // 0x31
	public float flipXOffset; // 0x34
	public RoleEffectAnimation.SoundType soundType; // 0x38
	public float duration; // 0x3C
	public Action onClipEnded; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6AAFA0 Offset: 0x6AA1A0 VA: 0x1806AAFA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AB440 Offset: 0x6AA640 VA: 0x1806AB440 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class RoleEffectAnimation : MonoBehaviour // TypeDefIndex: 1606
{
	// Fields
	public RoleEffectAnimation.EffectType effectType; // 0x20
	public AnimationClip Clip; // 0x28
	public SpriteAnim Animator; // 0x30
	public Action MidAnimCB; // 0x38
	public SpriteRenderer Renderer; // 0x40
	public AudioClip UseSound; // 0x48
	public AudioSource AudioSource; // 0x50
	private PlayerControl parent; // 0x58

	// Methods

	// RVA: 0x6A7780 Offset: 0x6A6980 VA: 0x1806A7780
	public void Play(PlayerControl parent, Action onClipEnded, bool flipX, RoleEffectAnimation.SoundType soundType, float duration = 0, bool parentTransform = True, float flipXOffset = 0) { }

	[IteratorStateMachine(typeof(RoleEffectAnimation.<CoPlay>d__11))]
	// RVA: 0x6A7590 Offset: 0x6A6790 VA: 0x1806A7590
	private IEnumerator CoPlay(PlayerControl parent, Action onClipEnded, bool flipX, RoleEffectAnimation.SoundType soundType, float duration = 0, bool parentTransform = True, float flipXOffset = 0) { }

	// RVA: 0x6A7650 Offset: 0x6A6850 VA: 0x1806A7650
	public void MidAnimationCallback() { }

	// RVA: 0x6A7840 Offset: 0x6A6A40 VA: 0x1806A7840
	public void SetMaskLayerBasedOnWhoShouldSee(bool shouldBeVisible) { }

	// RVA: 0x6A78A0 Offset: 0x6A6AA0 VA: 0x1806A78A0
	public void SetMaterialColor(int colorId) { }

	// RVA: 0x6A7680 Offset: 0x6A6880 VA: 0x1806A7680
	public void PlaySound() { }

	// RVA: 0x6A7BC0 Offset: 0x6A6DC0 VA: 0x1806A7BC0
	public void ToggleRenderer(bool on) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrewmateRole : RoleBehaviour // TypeDefIndex: 1607
{
	// Properties
	public override bool IsDead { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public override bool get_IsDead() { }

	// RVA: 0x699A50 Offset: 0x698C50 VA: 0x180699A50 Slot: 6
	public override bool CanUse(IUsable console) { }

	// RVA: 0x699C00 Offset: 0x698E00 VA: 0x180699C00 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x699C60 Offset: 0x698E60 VA: 0x180699C60
	public void .ctor() { }
}

// Namespace: 
public class DetectiveAbilityInfo : MonoBehaviour // TypeDefIndex: 1608
{
	// Fields
	[CompilerGenerated]
	private NetworkedPlayerInfo <PlayerInfo>k__BackingField; // 0x20
	[SerializeField]
	private PoolablePlayer PlayerIcon; // 0x28
	[SerializeField]
	private TextMeshPro ColorBlindName; // 0x30
	[SerializeField]
	private SpriteRenderer MaskingArea; // 0x38
	[SerializeField]
	private SpriteRenderer[] checkMarkBoxes; // 0x40
	[SerializeField]
	private SpriteRenderer[] checkMarks; // 0x48
	public int SuspectCount; // 0x50

	// Properties
	private NetworkedPlayerInfo PlayerInfo { get; set; }
	public NetworkedPlayerInfo CurrentPlayerInfo { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	private NetworkedPlayerInfo get_PlayerInfo() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_PlayerInfo(NetworkedPlayerInfo value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public NetworkedPlayerInfo get_CurrentPlayerInfo() { }

	// RVA: 0x69AD50 Offset: 0x699F50 VA: 0x18069AD50
	private void OnEnable() { }

	// RVA: 0x69AC90 Offset: 0x699E90 VA: 0x18069AC90
	private void OnDisable() { }

	// RVA: 0x69B1B0 Offset: 0x69A3B0 VA: 0x18069B1B0
	public void SetPlayerInfo(NetworkedPlayerInfo playerInfo, int suspectCount, bool isMeeting = False) { }

	// RVA: 0x69AC10 Offset: 0x699E10 VA: 0x18069AC10
	public void DisableCheckmarks() { }

	// RVA: 0x69AEC0 Offset: 0x69A0C0 VA: 0x18069AEC0
	public void SetDisabled() { }

	// RVA: 0x69B010 Offset: 0x69A210 VA: 0x18069B010
	public void SetEnabled() { }

	// RVA: 0x69AE10 Offset: 0x69A010 VA: 0x18069AE10
	private void SetColorBlindTag() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class DetectiveImpostorType : MonoBehaviour // TypeDefIndex: 1609
{
	// Fields
	[SerializeField]
	private SpriteRenderer impostorSpriteR; // 0x20
	[SerializeField]
	private TextMeshPro impostorText; // 0x28
	private RoleBehaviour myRole; // 0x30
	private DetectiveNotesMinigame miniGame; // 0x38

	// Methods

	// RVA: 0x69B890 Offset: 0x69AA90 VA: 0x18069B890
	public void Initialize(DetectiveNotesMinigame minigame, RoleBehaviour role) { }

	// RVA: 0x69B6B0 Offset: 0x69A8B0 VA: 0x18069B6B0
	public void Click() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class DetectiveLocationButton : MonoBehaviour // TypeDefIndex: 1610
{
	// Fields
	[SerializeField]
	private AudioClip[] scribbleSFXs; // 0x20
	private DetectiveNotesMinigame notesMinigame; // 0x28
	public string locationName; // 0x30

	// Methods

	// RVA: 0x69BB20 Offset: 0x69AD20 VA: 0x18069BB20
	public void SetInfo(DetectiveNotesMinigame _notesMinigame, string _locationName) { }

	// RVA: 0x69B980 Offset: 0x69AB80 VA: 0x18069B980
	public void OnClick() { }

	// RVA: 0x69BB30 Offset: 0x69AD30 VA: 0x18069BB30
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DetectiveNotesMinigame.<>c // TypeDefIndex: 1611
{
	// Fields
	public static readonly DetectiveNotesMinigame.<>c <>9; // 0x0
	public static Predicate<RoleBehaviour> <>9__44_0; // 0x8

	// Methods

	// RVA: 0x6ACA60 Offset: 0x6ABC60 VA: 0x1806ACA60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC660 Offset: 0x6AB860 VA: 0x1806AC660
	internal bool <OpenBodyPopup>b__44_0(RoleBehaviour r) { }
}

// Namespace: 
public class DetectiveNotesMinigame : Minigame // TypeDefIndex: 1612
{
	// Fields
	[SerializeField]
	private AudioClip[] scribbleSFXs; // 0x88
	[SerializeField]
	private Transform tabsParent; // 0x90
	[SerializeField]
	private GameObject tabPrefab; // 0x98
	[SerializeField]
	private TMP_Text victimName; // 0xA0
	[SerializeField]
	private TMP_Text victimColorBlindText; // 0xA8
	[SerializeField]
	private TMP_Text victimPreposition; // 0xB0
	[SerializeField]
	private TMP_Text victimLocation; // 0xB8
	[SerializeField]
	private DetectiveNotesSuspectContainer[] suspectContainers; // 0xC0
	[SerializeField]
	private GameObject InterrogationsParent; // 0xC8
	[SerializeField]
	private GameObject NoPagesParent; // 0xD0
	[SerializeField]
	private GameObject noSuspectsPostIt; // 0xD8
	[SerializeField]
	private SpriteRenderer bodyMaterial; // 0xE0
	[SerializeField]
	private GameObject prepositionPopup; // 0xE8
	[SerializeField]
	private GameObject impostorTypePopup; // 0xF0
	[SerializeField]
	private Transform impostorTypeParent; // 0xF8
	[SerializeField]
	private Sprite defaultBodySprite; // 0x100
	[SerializeField]
	private TMP_Text impostorTypeText; // 0x108
	[SerializeField]
	private GameObject impostorTypePrefab; // 0x110
	[SerializeField]
	private GameObject mapFadeBackground; // 0x118
	[SerializeField]
	private PassiveButton closeButton; // 0x120
	[SerializeField]
	[Header("Console Controller Navigation")]
	private List<UiElement> ControllerSelectable; // 0x128
	[SerializeField]
	private List<UiElement> PrepositionSelectable; // 0x130
	private List<UiElement> ImpostorIconControllerSelectables; // 0x138
	[SerializeField]
	private SpriteRenderer glyphL; // 0x140
	[SerializeField]
	private SpriteRenderer glyphR; // 0x148
	private readonly string MainOverlay; // 0x150
	private readonly string PrepositionOverlay; // 0x158
	private readonly string ImpostorOverlay; // 0x160
	private List<DetectiveNotesTab> tabs; // 0x168
	private int currentPageIndex; // 0x170
	private float suspectsWidth; // 0x174
	private DetectiveRole associatedDetective; // 0x178
	private DeadBody inspectedBody; // 0x180
	private List<GameObject> impostorButton; // 0x188
	public Dictionary<Color, Material> bodyColorMaterials; // 0x190
	private bool notesSetup; // 0x198

	// Methods

	// RVA: 0x69EB10 Offset: 0x69DD10 VA: 0x18069EB10
	private void Update() { }

	// RVA: 0x69BEB0 Offset: 0x69B0B0 VA: 0x18069BEB0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x69C2C0 Offset: 0x69B4C0 VA: 0x18069C2C0 Slot: 6
	public override void Close() { }

	// RVA: 0x69D740 Offset: 0x69C940 VA: 0x18069D740
	private void SetUpCurrentPage() { }

	// RVA: 0x69D2C0 Offset: 0x69C4C0 VA: 0x18069D2C0
	public void OpenVictimLocationMap() { }

	// RVA: 0x69C270 Offset: 0x69B470 VA: 0x18069C270
	public void CloseVictimLocationMap() { }

	// RVA: 0x69E2B0 Offset: 0x69D4B0 VA: 0x18069E2B0
	public void SetVictimLocation(string _locationName) { }

	// RVA: 0x69D590 Offset: 0x69C790 VA: 0x18069D590
	public void SetPrepositionPopup(bool active) { }

	// RVA: 0x69CBB0 Offset: 0x69BDB0 VA: 0x18069CBB0
	public void OpenBodyPopup(bool active) { }

	// RVA: 0x69D3D0 Offset: 0x69C5D0 VA: 0x18069D3D0
	public void SetImpostorType(string impostorString) { }

	// RVA: 0x69E360 Offset: 0x69D560 VA: 0x18069E360
	public void SetVictimPreposition(string _preposition) { }

	// RVA: 0x69C0A0 Offset: 0x69B2A0 VA: 0x18069C0A0
	public void ChangePage(int dir) { }

	// RVA: 0x69D540 Offset: 0x69C740 VA: 0x18069D540
	public void SetPage(int index) { }

	// RVA: 0x69C840 Offset: 0x69BA40 VA: 0x18069C840
	public void GenerateNewPage(DetectiveRole detective, NetworkedPlayerInfo victimPlayer) { }

	// RVA: 0x69D210 Offset: 0x69C410 VA: 0x18069D210
	public void OpenExistingPage(DetectiveRole detective, DetectiveNotesPageInfo pageInfo) { }

	// RVA: 0x69E690 Offset: 0x69D890 VA: 0x18069E690
	private void SetupTabs() { }

	// RVA: 0x69D3C0 Offset: 0x69C5C0 VA: 0x18069D3C0
	public void SetAssociatedDetective(DetectiveRole detective) { }

	// RVA: 0x69C150 Offset: 0x69B350 VA: 0x18069C150
	public void ClearTabHighlights() { }

	// RVA: 0x69C9F0 Offset: 0x69BBF0 VA: 0x18069C9F0
	public void MapClosed() { }

	// RVA: 0x69C5D0 Offset: 0x69B7D0 VA: 0x18069C5D0
	private void CreateBodyMaterials() { }

	// RVA: 0x69ED10 Offset: 0x69DF10 VA: 0x18069ED10
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class DetectiveNotesPageInfo // TypeDefIndex: 1613
{
	// Fields
	public bool locationSet; // 0x10
	public string locationName; // 0x18
	public bool prepositionSet; // 0x20
	public StringNames prepositionStringName; // 0x24
	public NetworkedPlayerInfo victimPlayer; // 0x28
	public List<DetectiveSuspect> suspects; // 0x30
	public bool impostorSet; // 0x38
	public string impostorString; // 0x40

	// Methods

	// RVA: 0x69F4C0 Offset: 0x69E6C0 VA: 0x18069F4C0
	public void .ctor(NetworkedPlayerInfo _victimPlayer) { }

	// RVA: 0x69EE50 Offset: 0x69E050 VA: 0x18069EE50
	public void AddSuspect(NetworkedPlayerInfo suspect) { }

	// RVA: 0x69F4B0 Offset: 0x69E6B0 VA: 0x18069F4B0
	public void SetPreposition(StringNames _prepositionString) { }

	// RVA: 0x69F4A0 Offset: 0x69E6A0 VA: 0x18069F4A0
	public void SetLocation(string _locationName) { }

	// RVA: 0x69F490 Offset: 0x69E690 VA: 0x18069F490
	public void SetImpostorType(string impString) { }
}

// Namespace: 
public class DetectiveNotesSuspectContainer : MonoBehaviour // TypeDefIndex: 1614
{
	// Fields
	[SerializeField]
	private int SuspectIndex; // 0x20
	[SerializeField]
	private TMP_Text SuspectPlaceholderText; // 0x28
	[SerializeField]
	private SpriteRenderer BGSprite; // 0x30
	[SerializeField]
	private GameObject SuspectPrefab; // 0x38
	[SerializeField]
	private DetectiveNotesSuspectInterface suspectInterface; // 0x40
	[SerializeField]
	private Sprite activeBGSprite; // 0x48
	[SerializeField]
	private Sprite inactiveBGSprite; // 0x50
	private int MaskLayer; // 0x58

	// Methods

	// RVA: 0x69F560 Offset: 0x69E760 VA: 0x18069F560
	public void Awake() { }

	// RVA: 0x69F8F0 Offset: 0x69EAF0 VA: 0x18069F8F0
	public void SetSuspect(DetectiveSuspect suspectPlayerInfo, NetworkedPlayerInfo victimPlayerInfo, bool wasDead, int index) { }

	// RVA: 0x69F670 Offset: 0x69E870 VA: 0x18069F670
	public void ClearSuspect() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Disable() { }

	// RVA: 0x69F740 Offset: 0x69E940 VA: 0x18069F740
	public void SetMaskLayer(int layer) { }

	// RVA: 0x69F9C0 Offset: 0x69EBC0 VA: 0x18069F9C0
	public void .ctor() { }
}

// Namespace: 
public class DetectiveNotesSuspectInterface : MonoBehaviour // TypeDefIndex: 1615
{
	// Fields
	[SerializeField]
	private GameObject container; // 0x20
	[SerializeField]
	private PoolablePlayer player; // 0x28
	[SerializeField]
	private GameObject deadImage; // 0x30
	[SerializeField]
	private TMP_Text playerName; // 0x38
	[SerializeField]
	private TMP_Text playerColor; // 0x40
	[SerializeField]
	private TMP_Text locationName; // 0x48
	[SerializeField]
	private TMP_Text numberedText; // 0x50

	// Methods

	// RVA: 0x69FA50 Offset: 0x69EC50 VA: 0x18069FA50
	public void SetPlayerInfo(DetectiveSuspect suspectPlayerInfo, NetworkedPlayerInfo victimPlayerInfo, int index, int maskLayer) { }

	// RVA: 0x69FA20 Offset: 0x69EC20 VA: 0x18069FA20
	public void DisplayDead() { }

	// RVA: 0x69F9E0 Offset: 0x69EBE0 VA: 0x18069F9E0
	public void Clear() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DetectiveNotesTab.<>c__DisplayClass18_0 // TypeDefIndex: 1616
{
	// Fields
	public DetectiveNotesMinigame notesMinigame; // 0x10
	public DetectiveNotesTab <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC690 Offset: 0x6AB890 VA: 0x1806AC690
	internal void <Setup>b__0() { }

	// RVA: 0x6AC700 Offset: 0x6AB900 VA: 0x1806AC700
	internal void <Setup>b__1() { }
}

// Namespace: 
public class DetectiveNotesTab : MonoBehaviour // TypeDefIndex: 1617
{
	// Fields
	private int tabIndex; // 0x20
	[SerializeField]
	private BoxCollider2D collider; // 0x28
	[SerializeField]
	private PoolablePlayer playerIcon; // 0x30
	[SerializeField]
	private List<SpriteRenderer> backgrounds; // 0x38
	[SerializeField]
	private SpriteRenderer playerColorBackground; // 0x40
	[SerializeField]
	private PassiveButton passiveButton; // 0x48
	[SerializeField]
	private SpriteRenderer tabBG; // 0x50
	[SerializeField]
	private SpriteRenderer dimBG; // 0x58
	[SerializeField]
	private Sprite largeBG; // 0x60
	[SerializeField]
	private Sprite smallBG; // 0x68
	[SerializeField]
	private TMP_Text colorblindText; // 0x70
	private float tabSpacing; // 0x78
	private float smallColliderSizeX; // 0x7C
	private float smallPlayerPosX; // 0x80
	private float smallPlayerScale; // 0x84
	private Vector2 smallBackgroundSize; // 0x88
	private Vector2 smallColorSize; // 0x90
	private int maskLayer; // 0x98

	// Methods

	// RVA: 0x69FFF0 Offset: 0x69F1F0 VA: 0x18069FFF0
	public void Setup(DetectiveNotesMinigame notesMinigame, int _tabIndex, NetworkedPlayerInfo player, int amountOfTabs) { }

	// RVA: 0x69FE90 Offset: 0x69F090 VA: 0x18069FE90
	public void SetHighlighted(DetectiveNotesMinigame minigame, bool highlighted) { }

	// RVA: 0x6A0670 Offset: 0x69F870 VA: 0x1806A0670
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DetectiveRole.<>c__DisplayClass23_0 // TypeDefIndex: 1618
{
	// Fields
	public NetworkedPlayerInfo playerInfo; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC7E0 Offset: 0x6AB9E0 VA: 0x1806AC7E0
	internal bool <AddVictimToNotes>b__0(DetectiveNotesPageInfo pageInfo) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DetectiveRole.<>c__DisplayClass24_0 // TypeDefIndex: 1619
{
	// Fields
	public NetworkedPlayerInfo victimPlayer; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC8A0 Offset: 0x6ABAA0 VA: 0x1806AC8A0
	internal bool <OpenNotes>b__0(DetectiveNotesPageInfo info) { }

	// RVA: 0x6AC910 Offset: 0x6ABB10 VA: 0x1806AC910
	internal bool <OpenNotes>b__1(DetectiveNotesPageInfo info) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DetectiveRole.<>c__DisplayClass39_0 // TypeDefIndex: 1620
{
	// Fields
	public byte victimID; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC9B0 Offset: 0x6ABBB0 VA: 0x1806AC9B0
	internal bool <GetPlayerLocation>b__0(DetectiveDeadBodyInfo info) { }

	// RVA: 0x6AC9B0 Offset: 0x6ABBB0 VA: 0x1806AC9B0
	internal bool <GetPlayerLocation>b__1(DetectiveDeadBodyInfo info) { }
}

// Namespace: 
public class DetectiveRole : CrewmateRole // TypeDefIndex: 1621
{
	// Fields
	[SerializeField]
	private GameObject notesPrefab; // 0xC0
	[SerializeField]
	private GameObject inspectionGraphic; // 0xC8
	[SerializeField]
	private GameObject abilityInfoPrefab; // 0xD0
	[SerializeField]
	private AudioClip interrogateSFX; // 0xD8
	private int currentNotesIndex; // 0xE0
	public List<DetectiveNotesPageInfo> notesPageInfos; // 0xE8
	private DetectiveNotesMinigame notesMinigame; // 0xF0
	private List<NetworkedPlayerInfo> deadPlayers; // 0xF8
	private DetectiveAbilityInfo abilityInfo; // 0x100
	private DetectiveAbilityInfo meetingAbilityInfo; // 0x108
	[SerializeField]
	private PlayerControl currentTarget; // 0x110
	[SerializeField]
	[Header("Ship Locations")]
	private GameObject skeldShipLocationsPrefab; // 0x118
	[SerializeField]
	private GameObject miraShipLocationsPrefab; // 0x120
	[SerializeField]
	private GameObject polusShipLocationsPrefab; // 0x128
	[SerializeField]
	private GameObject airshipShipLocationsPrefab; // 0x130
	[SerializeField]
	private GameObject fungleShipLocationsPrefab; // 0x138
	private float cooldownSecondsRemaining; // 0x140

	// Properties
	private bool IsCoolingDown { get; }

	// Methods

	// RVA: 0x6A3110 Offset: 0x6A2310 VA: 0x1806A3110
	private bool get_IsCoolingDown() { }

	// RVA: 0x6A14E0 Offset: 0x6A06E0 VA: 0x1806A14E0 Slot: 16
	public override void Initialize(PlayerControl player) { }

	// RVA: 0x6A2DC0 Offset: 0x6A1FC0 VA: 0x1806A2DC0 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6A2ED0 Offset: 0x6A20D0 VA: 0x1806A2ED0 Slot: 11
	public override void UseSecondaryAbility() { }

	// RVA: 0x6A18D0 Offset: 0x6A0AD0 VA: 0x1806A18D0
	private void Interrogate() { }

	// RVA: 0x6A06D0 Offset: 0x69F8D0 VA: 0x1806A06D0
	private void AddVictimToNotes(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x6A20F0 Offset: 0x6A12F0 VA: 0x1806A20F0
	private void OpenNotes(NetworkedPlayerInfo victimPlayer, bool openInterface = True) { }

	// RVA: 0x6A2940 Offset: 0x6A1B40 VA: 0x1806A2940 Slot: 18
	public override void SetPlayerTarget(PlayerControl target) { }

	// RVA: 0x6A0840 Offset: 0x69FA40 VA: 0x1806A0840
	private void ClearPlayerTarget() { }

	// RVA: 0x6A0DE0 Offset: 0x69FFE0 VA: 0x1806A0DE0 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x6A12B0 Offset: 0x6A04B0 VA: 0x1806A12B0 Slot: 23
	protected override float GetAbilityDistance() { }

	// RVA: 0x6A0ED0 Offset: 0x6A00D0 VA: 0x1806A0ED0
	private void FixedUpdate() { }

	// RVA: 0x6A1BD0 Offset: 0x6A0DD0 VA: 0x1806A1BD0 Slot: 12
	public override void OnMeetingStart() { }

	// RVA: 0x6A2680 Offset: 0x6A1880 VA: 0x1806A2680
	private void SetAbilityInfo(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x6A20E0 Offset: 0x6A12E0 VA: 0x1806A20E0 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6A2C20 Offset: 0x6A1E20 VA: 0x1806A2C20
	private void UpdateDeadPlayers() { }

	// RVA: 0x6A2620 Offset: 0x6A1820 VA: 0x1806A2620
	public bool PlayerWasDead(DetectiveSuspect playerInfo) { }

	// RVA: 0x6A07E0 Offset: 0x69F9E0 VA: 0x1806A07E0 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6A28B0 Offset: 0x6A1AB0 VA: 0x1806A28B0
	public void SetCurrentIndex(int _index) { }

	// RVA: 0x6A1A80 Offset: 0x6A0C80 VA: 0x1806A1A80 Slot: 27
	public override void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim) { }

	// RVA: 0x6A0BC0 Offset: 0x69FDC0 VA: 0x1806A0BC0
	private void CreatePlayerLocations(DetectiveDeadBodyInfo deadBodyInfo) { }

	// RVA: 0x6A12C0 Offset: 0x6A04C0 VA: 0x1806A12C0
	public string GetPlayerLocation(byte playerID, byte victimID) { }

	// RVA: 0x6A0910 Offset: 0x69FB10 VA: 0x1806A0910
	private void CreateMapLocations() { }

	// RVA: 0x6A1B40 Offset: 0x6A0D40 VA: 0x1806A1B40 Slot: 14
	public override void OnDeath(DeathReason reason) { }

	// RVA: 0x6A2070 Offset: 0x6A1270 VA: 0x1806A2070 Slot: 15
	public override void OnRoleSet() { }

	// RVA: 0x6A3030 Offset: 0x6A2230 VA: 0x1806A3030
	public void .ctor() { }
}

// Namespace: 
public class DetectiveDeadBodyInfo // TypeDefIndex: 1622
{
	// Fields
	public byte victimID; // 0x10
	public Dictionary<byte, string> PlayerLocationsAtDeath; // 0x18

	// Methods

	// RVA: 0x69B630 Offset: 0x69A830 VA: 0x18069B630
	public void .ctor(byte _victimID) { }

	// RVA: 0x69B5D0 Offset: 0x69A7D0 VA: 0x18069B5D0
	public string GetPlayerLocation(byte playerID) { }
}

// Namespace: 
[Serializable]
public struct DetectiveSuspect // TypeDefIndex: 1623
{
	// Fields
	public NetworkedPlayerInfo playerInfo; // 0x0
	public NetworkedPlayerInfo shapeshifterPlayerInfo; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(NetworkedPlayerInfo _playerInfo, NetworkedPlayerInfo _shapeshifterPlayerInfo) { }
}

// Namespace: 
public class DetectiveLocationsController : MonoBehaviour // TypeDefIndex: 1624
{
	// Fields
	public static DetectiveLocationsController Instance; // 0x0
	public List<DetectiveLocation> DetectiveLocations; // 0x20
	public List<DetectiveDeadBodyInfo> DeadBodyInfos; // 0x28
	public SystemTypes DefaultLocation; // 0x30

	// Methods

	// RVA: 0x69BC20 Offset: 0x69AE20 VA: 0x18069BC20
	private void Awake() { }

	// RVA: 0x69BCA0 Offset: 0x69AEA0 VA: 0x18069BCA0
	public DetectiveLocation GetPlayerLocation(NetworkedPlayerInfo player) { }

	// RVA: 0x69BB80 Offset: 0x69AD80 VA: 0x18069BB80
	public void AddBodyInfo(DetectiveDeadBodyInfo bodyInfo) { }

	// RVA: 0x69BE00 Offset: 0x69B000 VA: 0x18069BE00
	public void .ctor() { }
}

// Namespace: 
public class EngineerRole : RoleBehaviour // TypeDefIndex: 1625
{
	// Fields
	private Vent currentTarget; // 0xC0
	private float cooldownSecondsRemaining; // 0xC8
	private float inVentTimeRemaining; // 0xCC
	private int usesRemaining; // 0xD0
	private bool isExitVentQueued; // 0xD4

	// Properties
	public override bool IsDead { get; }
	private bool IsCoolingDown { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public override bool get_IsDead() { }

	// RVA: 0x6A3FE0 Offset: 0x6A31E0 VA: 0x1806A3FE0
	private bool get_IsCoolingDown() { }

	// RVA: 0x6A3720 Offset: 0x6A2920 VA: 0x1806A3720 Slot: 16
	public override void Initialize(PlayerControl player) { }

	// RVA: 0x6A3660 Offset: 0x6A2860 VA: 0x1806A3660
	private float GetCooldown() { }

	// RVA: 0x6A36C0 Offset: 0x6A28C0 VA: 0x1806A36C0
	private float GetVentTime() { }

	// RVA: 0x6A3130 Offset: 0x6A2330 VA: 0x1806A3130 Slot: 6
	public override bool CanUse(IUsable console) { }

	// RVA: 0x699C00 Offset: 0x698E00 VA: 0x180699C00 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x6A3B60 Offset: 0x6A2D60 VA: 0x1806A3B60 Slot: 17
	public override void SetUsableTarget(IUsable target) { }

	// RVA: 0x6A3C80 Offset: 0x6A2E80 VA: 0x1806A3C80 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6A3A30 Offset: 0x6A2C30 VA: 0x1806A3A30 Slot: 19
	public override void SetCooldown() { }

	// RVA: 0x6A38C0 Offset: 0x6A2AC0 VA: 0x1806A38C0 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6A3390 Offset: 0x6A2590 VA: 0x1806A3390
	private void FixedUpdate() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x6A3F80 Offset: 0x6A3180 VA: 0x1806A3F80
	public void .ctor() { }
}

// Namespace: 
public class CrewmateGhostRole : RoleBehaviour // TypeDefIndex: 1626
{
	// Fields
	public Minigame HauntMenu; // 0xC0

	// Properties
	public override bool IsDead { get; }
	public override bool IsAffectedByComms { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	public override bool get_IsDead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public override bool get_IsAffectedByComms() { }

	// RVA: 0x6B2960 Offset: 0x6B1B60 VA: 0x1806B2960 Slot: 6
	public override bool CanUse(IUsable console) { }

	// RVA: 0x699C00 Offset: 0x698E00 VA: 0x180699C00 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x6B2BA0 Offset: 0x6B1DA0 VA: 0x1806B2BA0 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6B29E0 Offset: 0x6B1BE0 VA: 0x1806B29E0 Slot: 9
	public override void SpawnTaskHeader(PlayerControl playerControl) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6B2DE0 Offset: 0x6B1FE0 VA: 0x1806B2DE0
	public void .ctor() { }
}

// Namespace: 
private enum HauntMenuMinigame.HauntFilters // TypeDefIndex: 1627
{
	// Fields
	public int value__; // 0x0
	public const HauntMenuMinigame.HauntFilters None = 0;
	public const HauntMenuMinigame.HauntFilters Impostor = 1;
	public const HauntMenuMinigame.HauntFilters Crewmate = 2;
	public const HauntMenuMinigame.HauntFilters Ghost = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HauntMenuMinigame.<>c // TypeDefIndex: 1628
{
	// Fields
	public static readonly HauntMenuMinigame.<>c <>9; // 0x0
	public static Func<PassiveButton, bool> <>9__16_0; // 0x8
	public static Func<PlayerControl, bool> <>9__17_0; // 0x10
	public static Func<PlayerControl, bool> <>9__21_0; // 0x18
	public static Func<PlayerControl, string> <>9__21_2; // 0x20

	// Methods

	// RVA: 0x6C9EE0 Offset: 0x6C90E0 VA: 0x1806C9EE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C93F0 Offset: 0x6C85F0 VA: 0x1806C93F0
	internal bool <Start>b__16_0(PassiveButton s) { }

	// RVA: 0x6C8FA0 Offset: 0x6C81A0 VA: 0x1806C8FA0
	internal bool <Begin>b__17_0(PlayerControl pc) { }

	// RVA: 0x6C8FA0 Offset: 0x6C81A0 VA: 0x1806C8FA0
	internal bool <ChangePick>b__21_0(PlayerControl pc) { }

	// RVA: 0x6C8FD0 Offset: 0x6C81D0 VA: 0x1806C8FD0
	internal string <ChangePick>b__21_2(PlayerControl pc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HauntMenuMinigame.<>c__DisplayClass17_0 // TypeDefIndex: 1629
{
	// Fields
	public Vector2 myPos; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9560 Offset: 0x6C8760 VA: 0x1806C9560
	internal float <Begin>b__1(PlayerControl pc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HauntMenuMinigame.<>c__DisplayClass21_0 // TypeDefIndex: 1630
{
	// Fields
	public HauntMenuMinigame <>4__this; // 0x10
	public PlayerControl[] players; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9660 Offset: 0x6C8860 VA: 0x1806C9660
	internal bool <ChangePick>b__1(PlayerControl pc) { }

	// RVA: 0x6C9680 Offset: 0x6C8880 VA: 0x1806C9680
	internal void <ChangePick>b__3(PassiveButton a) { }
}

// Namespace: 
public class HauntMenuMinigame : Minigame // TypeDefIndex: 1631
{
	// Fields
	private const float MinVelMultiplier = 0,75;
	private const float MaxVelMultiplier = 4;
	private const float MinDistance = 0,05;
	private const float MinOffset = 0,2;
	private const float MaxOffset = 0,5;
	private const float Damping = 0,7;
	private const float Easing = 0,2;
	[SerializeField]
	private TextMeshPro NameText; // 0x88
	[SerializeField]
	private TextMeshPro FilterText; // 0x90
	[SerializeField]
	private TextMeshPro HauntingText; // 0x98
	private HauntMenuMinigame.HauntFilters filterMode; // 0xA0
	[SerializeField]
	private PassiveButton[] FilterButtons; // 0xA8
	[SerializeField]
	private PassiveButton[] Arrows; // 0xB0
	private PlayerControl HauntTarget; // 0xB8
	private Vector2 Offset; // 0xC0

	// Methods

	// RVA: 0x6B94D0 Offset: 0x6B86D0 VA: 0x1806B94D0
	private void Start() { }

	// RVA: 0x6B82B0 Offset: 0x6B74B0 VA: 0x1806B82B0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6B8A50 Offset: 0x6B7C50 VA: 0x1806B8A50
	private void FixedUpdate() { }

	// RVA: 0x6B90A0 Offset: 0x6B82A0 VA: 0x1806B90A0
	public void SetFilter(int filterInt) { }

	// RVA: 0x6B8F30 Offset: 0x6B8130 VA: 0x1806B8F30
	private void SetFilterText() { }

	// RVA: 0x6B85F0 Offset: 0x6B77F0 VA: 0x1806B85F0
	public void ChangePick(int direction) { }

	// RVA: 0x6B8D90 Offset: 0x6B7F90 VA: 0x1806B8D90
	private bool MatchesFilter(PlayerControl pc) { }

	// RVA: 0x6B9210 Offset: 0x6B8410 VA: 0x1806B9210
	private void SetHauntTarget(PlayerControl target) { }

	// RVA: 0x6B89D0 Offset: 0x6B7BD0 VA: 0x1806B89D0 Slot: 6
	public override void Close() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
public class ImpostorGhostRole : RoleBehaviour // TypeDefIndex: 1632
{
	// Fields
	[CompilerGenerated]
	private bool <WasManuallyPicked>k__BackingField; // 0xC0
	public Minigame HauntMenu; // 0xC8

	// Properties
	public override bool IsDead { get; }
	public bool WasManuallyPicked { get; set; }
	public override bool IsAffectedByComms { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 4
	public override bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220
	public bool get_WasManuallyPicked() { }

	[CompilerGenerated]
	// RVA: 0x6BC540 Offset: 0x6BB740 VA: 0x1806BC540
	public void set_WasManuallyPicked(bool value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public override bool get_IsAffectedByComms() { }

	// RVA: 0x6BC030 Offset: 0x6BB230 VA: 0x1806BC030 Slot: 6
	public override bool CanUse(IUsable usable) { }

	// RVA: 0x6BC150 Offset: 0x6BB350 VA: 0x1806BC150 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x6BC270 Offset: 0x6BB470 VA: 0x1806BC270 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6BC1B0 Offset: 0x6BB3B0 VA: 0x1806BC1B0 Slot: 9
	public override void SpawnTaskHeader(PlayerControl playerControl) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BC4B0 Offset: 0x6BB6B0 VA: 0x1806BC4B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GuardianAngelRole.<>c // TypeDefIndex: 1633
{
	// Fields
	public static readonly GuardianAngelRole.<>c <>9; // 0x0
	public static Comparison<PlayerControl> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x6C9CA0 Offset: 0x6C8EA0 VA: 0x1806C9CA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9070 Offset: 0x6C8270 VA: 0x1806C9070
	internal int <FindClosestTarget>b__12_0(PlayerControl a, PlayerControl b) { }
}

// Namespace: 
public class GuardianAngelRole : CrewmateGhostRole // TypeDefIndex: 1634
{
	// Fields
	private PlayerControl currentTarget; // 0xC8
	private float cooldownSecondsRemaining; // 0xD0

	// Properties
	private bool IsCoolingDown { get; }
	public override bool IsAffectedByComms { get; }

	// Methods

	// RVA: 0x6B8290 Offset: 0x6B7490 VA: 0x1806B8290
	private bool get_IsCoolingDown() { }

	// RVA: 0x6B8280 Offset: 0x6B7480 VA: 0x1806B8280 Slot: 5
	public override bool get_IsAffectedByComms() { }

	// RVA: 0x6B8080 Offset: 0x6B7280 VA: 0x1806B8080 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6B7DC0 Offset: 0x6B6FC0 VA: 0x1806B7DC0 Slot: 18
	public override void SetPlayerTarget(PlayerControl target) { }

	// RVA: 0x6B7D00 Offset: 0x6B6F00 VA: 0x1806B7D00 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6B7D50 Offset: 0x6B6F50 VA: 0x1806B7D50 Slot: 19
	public override void SetCooldown() { }

	// RVA: 0x6B7C00 Offset: 0x6B6E00 VA: 0x1806B7C00
	private void FixedUpdate() { }

	// RVA: 0x6B7FC0 Offset: 0x6B71C0 VA: 0x1806B7FC0
	private void UpdateCooldown() { }

	// RVA: 0x6B7A40 Offset: 0x6B6C40 VA: 0x1806B7A40 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x6B79E0 Offset: 0x6B6BE0 VA: 0x1806B79E0 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6B2DE0 Offset: 0x6B1FE0 VA: 0x1806B2DE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ImpostorRole.<>c // TypeDefIndex: 1635
{
	// Fields
	public static readonly ImpostorRole.<>c <>9; // 0x0
	public static Func<PlayerTask, bool> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x6C9E80 Offset: 0x6C9080 VA: 0x1806C9E80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9010 Offset: 0x6C8210 VA: 0x1806C9010
	internal bool <Deinitialize>b__2_0(PlayerTask t) { }
}

// Namespace: 
public class ImpostorRole : RoleBehaviour // TypeDefIndex: 1636
{
	// Properties
	public override bool IsDead { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public override bool get_IsDead() { }

	// RVA: 0x6BC690 Offset: 0x6BB890 VA: 0x1806BC690 Slot: 8
	public override void Deinitialize(PlayerControl targetPlayer) { }

	// RVA: 0x6BCA80 Offset: 0x6BBC80 VA: 0x1806BCA80 Slot: 9
	public override void SpawnTaskHeader(PlayerControl playerControl) { }

	// RVA: 0x6BC550 Offset: 0x6BB750 VA: 0x1806BC550 Slot: 6
	public override bool CanUse(IUsable usable) { }

	// RVA: 0x6BC150 Offset: 0x6BB350 VA: 0x1806BC150 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x6BC910 Offset: 0x6BBB10 VA: 0x1806BC910 Slot: 20
	protected override bool IsValidTarget(NetworkedPlayerInfo target) { }

	// RVA: 0x6BC830 Offset: 0x6BBA30 VA: 0x1806BC830 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BCDB0 Offset: 0x6BBFB0 VA: 0x1806BCDB0
	public void .ctor() { }
}

// Namespace: 
public sealed class NoisemakerArrow.OnFadeTrigger : MulticastDelegate // TypeDefIndex: 1637
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
[CompilerGenerated]
private sealed class NoisemakerArrow.<WaitDisappear>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1638
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NoisemakerArrow <>4__this; // 0x20
	private bool <fadeTriggered>5__2; // 0x28
	private float <t>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C9F40 Offset: 0x6C9140 VA: 0x1806C9F40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6CA070 Offset: 0x6C9270 VA: 0x1806CA070 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class NoisemakerArrow : ArrowBehaviour // TypeDefIndex: 1639
{
	// Fields
	[CompilerGenerated]
	private NoisemakerArrow.OnFadeTrigger onFadeTrigger; // 0x58
	public const float FadeLength = 1;
	[SerializeField]
	private Transform pivot; // 0x60
	private float duration; // 0x68

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BD3D0 Offset: 0x6BC5D0 VA: 0x1806BD3D0
	public void add_onFadeTrigger(NoisemakerArrow.OnFadeTrigger value) { }

	[CompilerGenerated]
	// RVA: 0x6BD470 Offset: 0x6BC670 VA: 0x1806BD470
	public void remove_onFadeTrigger(NoisemakerArrow.OnFadeTrigger value) { }

	// RVA: 0x6BD090 Offset: 0x6BC290 VA: 0x1806BD090 Slot: 6
	public override void UpdatePosition() { }

	// RVA: 0x6BCE40 Offset: 0x6BC040 VA: 0x1806BCE40 Slot: 9
	protected override void DistancedBehaviour(Vector2 vpPoint, Vector2 del, float delLen, Camera cam) { }

	// RVA: 0x6BD020 Offset: 0x6BC220 VA: 0x1806BD020
	public void SetDuration(float _duration) { }

	[IteratorStateMachine(typeof(NoisemakerArrow.<WaitDisappear>d__10))]
	// RVA: 0x6BD370 Offset: 0x6BC570 VA: 0x1806BD370
	private IEnumerator WaitDisappear() { }

	// RVA: 0x571960 Offset: 0x570B60 VA: 0x180571960
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NoisemakerFade.<CoFade>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1640
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NoisemakerFade <>4__this; // 0x20
	private float <timeElapsed>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8DD0 Offset: 0x6C7FD0 VA: 0x1806C8DD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C8F00 Offset: 0x6C8100 VA: 0x1806C8F00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class NoisemakerFade : MonoBehaviour // TypeDefIndex: 1641
{
	// Fields
	[SerializeField]
	private NoisemakerArrow noisemakerArrow; // 0x20
	[SerializeField]
	private SpriteRenderer spriteRenderer; // 0x28

	// Methods

	// RVA: 0x6BD720 Offset: 0x6BC920 VA: 0x1806BD720
	private void OnEnable() { }

	// RVA: 0x6BD5E0 Offset: 0x6BC7E0 VA: 0x1806BD5E0
	private void OnDestroy() { }

	// RVA: 0x6BD570 Offset: 0x6BC770 VA: 0x1806BD570
	private void Fade() { }

	[IteratorStateMachine(typeof(NoisemakerFade.<CoFade>d__5))]
	// RVA: 0x6BD510 Offset: 0x6BC710 VA: 0x1806BD510
	private IEnumerator CoFade() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class NoisemakerRole : CrewmateRole // TypeDefIndex: 1642
{
	// Fields
	[SerializeField]
	private AudioClip deathSound; // 0xC0
	[SerializeField]
	private GameObject deathArrowPrefab; // 0xC8
	private const string SFX_ALERT_NAME = "NoisemakerAlert";
	private const float FALLOFF_START_DISTANCE = 7;
	private const float FALLOFF_MAX_DISTANCE = 50;
	private const float MIN_VOL_ALERT = 0,5;
	private const float VIBRATION_INTENSITY = 1;
	private const float VIBRATION_DURATION = 1,2;
	private NoisemakerArrow deathArrow; // 0xD0

	// Properties
	private bool impostorAlert { get; }
	private float alertDuration { get; }

	// Methods

	// RVA: 0x6BE040 Offset: 0x6BD240 VA: 0x1806BE040
	private bool get_impostorAlert() { }

	// RVA: 0x6BDFE0 Offset: 0x6BD1E0 VA: 0x1806BDFE0
	private float get_alertDuration() { }

	// RVA: 0x6BD8C0 Offset: 0x6BCAC0 VA: 0x1806BD8C0
	public void NotifyOfDeath() { }

	// RVA: 0x6BDE20 Offset: 0x6BD020 VA: 0x1806BDE20
	private void SoundDynamics(AudioSource source, float dt) { }

	// RVA: 0x6BDE10 Offset: 0x6BD010 VA: 0x1806BDE10 Slot: 14
	public override void OnDeath(DeathReason reason) { }

	// RVA: 0x6BD860 Offset: 0x6BCA60 VA: 0x1806BD860 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BDFD0 Offset: 0x6BD1D0 VA: 0x1806BDFD0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PhantomRole.<>c // TypeDefIndex: 1643
{
	// Fields
	public static readonly PhantomRole.<>c <>9; // 0x0
	public static Predicate<RoleEffectAnimation> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x6C9D00 Offset: 0x6C8F00 VA: 0x1806C9D00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C94D0 Offset: 0x6C86D0 VA: 0x1806C94D0
	internal bool <UseAbility>b__20_0(RoleEffectAnimation r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PhantomRole.<CoAppearClients>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1644
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action callback; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8B60 Offset: 0x6C7D60 VA: 0x1806C8B60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C8C10 Offset: 0x6C7E10 VA: 0x1806C8C10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PhantomRole : ImpostorRole // TypeDefIndex: 1645
{
	// Fields
	[SerializeField]
	private AudioClip appearSound; // 0xC0
	private const string SFX_VANISH_NAME = "PhantomVanish";
	private const string SFX_APPEAR_NAME = "PhantomAppear";
	private float cooldownSecondsRemaining; // 0xC8
	private float durationSecondsRemaining; // 0xCC
	private bool isInvisible; // 0xD0
	private bool fading; // 0xD1
	private bool serverApproved; // 0xD2

	// Properties
	public bool IsInvisible { get; }
	private bool IsCoolingDown { get; }
	private static float RoleCooldownValue { get; }
	public bool IsFading { get; }
	public bool ServerApproved { get; }

	// Methods

	// RVA: 0x6BF980 Offset: 0x6BEB80 VA: 0x1806BF980
	public bool get_IsInvisible() { }

	// RVA: 0x6A3FE0 Offset: 0x6A31E0 VA: 0x1806A3FE0
	private bool get_IsCoolingDown() { }

	// RVA: 0x6BF990 Offset: 0x6BEB90 VA: 0x1806BF990
	private static float get_RoleCooldownValue() { }

	// RVA: 0x6BF2C0 Offset: 0x6BE4C0 VA: 0x1806BF2C0
	public bool SetFading(bool isFading) { }

	// RVA: 0x6BF970 Offset: 0x6BEB70 VA: 0x1806BF970
	public bool get_IsFading() { }

	// RVA: 0x6BF2E0 Offset: 0x6BE4E0 VA: 0x1806BF2E0
	public bool SetServerApproval(bool approved) { }

	// RVA: 0x6BF9F0 Offset: 0x6BEBF0 VA: 0x1806BF9F0
	public bool get_ServerApproved() { }

	// RVA: 0x6BF600 Offset: 0x6BE800 VA: 0x1806BF600 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6BF2D0 Offset: 0x6BE4D0 VA: 0x1806BF2D0
	public void SetInvisible(bool invisibility) { }

	// RVA: 0x6BE0A0 Offset: 0x6BD2A0 VA: 0x1806BE0A0
	public void AppearClients(Action callback) { }

	[IteratorStateMachine(typeof(PhantomRole.<CoAppearClients>d__23))]
	// RVA: 0x6BE430 Offset: 0x6BD630 VA: 0x1806BE430
	private IEnumerator CoAppearClients(Action callback) { }

	// RVA: 0x6BEB10 Offset: 0x6BDD10 VA: 0x1806BEB10
	private void MakePlayerVisible(bool shouldAnimate = True, bool setCooldown = True) { }

	// RVA: 0x6BE980 Offset: 0x6BDB80 VA: 0x1806BE980 Slot: 20
	protected override bool IsValidTarget(NetworkedPlayerInfo target) { }

	// RVA: 0x6BF2F0 Offset: 0x6BE4F0 VA: 0x1806BF2F0
	private bool ShouldUpdateCancelTimer() { }

	// RVA: 0x6BEC50 Offset: 0x6BDE50 VA: 0x1806BEC50 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6BF210 Offset: 0x6BE410 VA: 0x1806BF210 Slot: 19
	public override void SetCooldown() { }

	// RVA: 0x6BF590 Offset: 0x6BE790 VA: 0x1806BF590
	public void StartDuration() { }

	// RVA: 0x6BE490 Offset: 0x6BD690 VA: 0x1806BE490
	private void FixedUpdate() { }

	// RVA: 0x6BE120 Offset: 0x6BD320 VA: 0x1806BE120 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BE180 Offset: 0x6BD380 VA: 0x1806BE180 Slot: 6
	public override bool CanUse(IUsable usable) { }

	// RVA: 0x6BF070 Offset: 0x6BE270 VA: 0x1806BF070
	public void PlayPhantomVanishSound() { }

	// RVA: 0x6BEE90 Offset: 0x6BE090 VA: 0x1806BEE90
	public void PlayPhantomAppearSound() { }

	// RVA: 0x6BF3E0 Offset: 0x6BE5E0 VA: 0x1806BF3E0
	private void SoundDynamics(AudioSource source, float dt) { }

	// RVA: 0x6BE8B0 Offset: 0x6BDAB0 VA: 0x1806BE8B0 Slot: 26
	public override void HandleRoleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x6BF960 Offset: 0x6BEB60 VA: 0x1806BF960
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleBehaviour.<>c__DisplayClass72_0 // TypeDefIndex: 1646
{
	// Fields
	public Vector2 myPos; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C96D0 Offset: 0x6C88D0 VA: 0x1806C96D0
	internal int <GetPlayersInAbilityRangeSorted>b__0(PlayerControl a, PlayerControl b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleBehaviour.<>c__DisplayClass76_0 // TypeDefIndex: 1647
{
	// Fields
	public Vector2 myPos; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9850 Offset: 0x6C8A50 VA: 0x1806C9850
	internal int <GetBodiesInAbilityRangeSorted>b__0(DeadBody a, DeadBody b) { }
}

// Namespace: 
public abstract class RoleBehaviour : MonoBehaviour // TypeDefIndex: 1648
{
	// Fields
	public RoleTypes Role; // 0x20
	public StringNames StringName; // 0x24
	public StringNames BlurbName; // 0x28
	public StringNames BlurbNameMed; // 0x2C
	public StringNames BlurbNameLong; // 0x30
	public Sprite RoleIconSolid; // 0x38
	public Sprite RoleIconWhite; // 0x40
	public Sprite RoleScreenshot; // 0x48
	public Color NameColor; // 0x50
	public bool TasksCountTowardProgress; // 0x60
	public bool CanUseKillButton; // 0x61
	public bool CanBeKilled; // 0x62
	public bool CanVent; // 0x63
	public bool AffectedByLightAffectors; // 0x64
	public int MaxCount; // 0x68
	public RoleTeamTypes TeamType; // 0x6C
	public AbilityButtonSettings Ability; // 0x70
	public AbilityButtonSettings SecondaryAbility; // 0x78
	public RoleTypes DefaultGhostRole; // 0x80
	public AudioClip UseSound; // 0x88
	public AudioClip IntroSound; // 0x90
	public List<BaseGameSetting> AllGameSettings; // 0x98
	public OverlayKillAnimation[] CustomKillAnimations; // 0xA0
	protected PlayerControl Player; // 0xA8
	protected AbilityButton buttonManager; // 0xB0
	protected SecondaryAbilityButton secondaryButtonManager; // 0xB8
	private static List<PlayerControl> tempPlayerList; // 0x0
	private static List<DeadBody> tempBodyList; // 0x8

	// Properties
	public bool IsImpostor { get; }
	public abstract bool IsDead { get; }
	public string NiceName { get; }
	public string Blurb { get; }
	public string BlurbMed { get; }
	public string BlurbLong { get; }
	public bool IsSimpleRole { get; }
	public Color TeamColor { get; }
	public virtual bool IsAffectedByComms { get; }
	protected bool CommsSabotaged { get; }

	// Methods

	// RVA: 0x6C12F0 Offset: 0x6C04F0 VA: 0x1806C12F0
	public bool get_IsImpostor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsDead();

	// RVA: 0x6C1320 Offset: 0x6C0520 VA: 0x1806C1320
	public string get_NiceName() { }

	// RVA: 0x6C1190 Offset: 0x6C0390 VA: 0x1806C1190
	public string get_Blurb() { }

	// RVA: 0x6C1110 Offset: 0x6C0310 VA: 0x1806C1110
	public string get_BlurbMed() { }

	// RVA: 0x6C1090 Offset: 0x6C0290 VA: 0x1806C1090
	public string get_BlurbLong() { }

	// RVA: 0x6C1300 Offset: 0x6C0500 VA: 0x1806C1300
	public bool get_IsSimpleRole() { }

	// RVA: 0x6C13A0 Offset: 0x6C05A0 VA: 0x1806C13A0
	public Color get_TeamColor() { }

	// RVA: 0x6C12A0 Offset: 0x6C04A0 VA: 0x1806C12A0 Slot: 5
	public virtual bool get_IsAffectedByComms() { }

	// RVA: 0x6C1210 Offset: 0x6C0410 VA: 0x1806C1210
	protected bool get_CommsSabotaged() { }

	// RVA: 0x6BFAB0 Offset: 0x6BECB0 VA: 0x1806BFAB0
	protected static void AppendTaskHint(RoleBehaviour role, StringBuilder taskStringBuilder) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public virtual bool CanUse(IUsable console) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public virtual bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void Deinitialize(PlayerControl targetPlayer) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public virtual void SpawnTaskHeader(PlayerControl playerControl) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public virtual void UseAbility() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	public virtual void UseSecondaryAbility() { }

	// RVA: 0x6C0F40 Offset: 0x6C0140 VA: 0x1806C0F40 Slot: 12
	public virtual void OnMeetingStart() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public virtual void OnVotingComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	public virtual void OnDeath(DeathReason reason) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void OnRoleSet() { }

	// RVA: 0x6C09C0 Offset: 0x6BFBC0 VA: 0x1806C09C0 Slot: 16
	public virtual void Initialize(PlayerControl player) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public virtual void SetUsableTarget(IUsable target) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	public virtual void SetPlayerTarget(PlayerControl target) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public virtual void SetCooldown() { }

	// RVA: 0x6C06D0 Offset: 0x6BF8D0 VA: 0x1806C06D0
	protected void InitializeMeetingAbilityButton() { }

	// RVA: 0x6C0560 Offset: 0x6BF760 VA: 0x1806C0560
	private void InitializeAbilityButton() { }

	// RVA: 0x6C08A0 Offset: 0x6BFAA0 VA: 0x1806C08A0
	private void InitializeSecondaryAbilityButton() { }

	// RVA: 0x6C0F50 Offset: 0x6C0150 VA: 0x1806C0F50
	private void SetAbilityUsesRemaining(int num) { }

	// RVA: 0x6C0DE0 Offset: 0x6BFFE0 VA: 0x1806C0DE0 Slot: 20
	protected virtual bool IsValidTarget(NetworkedPlayerInfo target) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 21
	public virtual PlayerControl FindClosestTarget() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 22
	public virtual DeadBody FindClosestBody() { }

	// RVA: 0x6BFC50 Offset: 0x6BEE50 VA: 0x1806BFC50 Slot: 23
	protected virtual float GetAbilityDistance() { }

	// RVA: 0x6C0510 Offset: 0x6BF710 VA: 0x1806C0510
	protected static List<PlayerControl> GetTempPlayerList() { }

	// RVA: 0x6C00B0 Offset: 0x6BF2B0 VA: 0x1806C00B0
	public List<PlayerControl> GetPlayersInAbilityRangeSorted(List<PlayerControl> outputList) { }

	// RVA: 0x6C00C0 Offset: 0x6BF2C0 VA: 0x1806C00C0
	protected List<PlayerControl> GetPlayersInAbilityRangeSorted(List<PlayerControl> outputList, bool ignoreColliders) { }

	// RVA: 0x6C04C0 Offset: 0x6BF6C0 VA: 0x1806C04C0
	protected static List<DeadBody> GetTempBodyList() { }

	// RVA: 0x6C00A0 Offset: 0x6BF2A0 VA: 0x1806C00A0
	public List<DeadBody> GetBodiesInAbilityRangeSorted(List<DeadBody> outputList) { }

	// RVA: 0x6BFCB0 Offset: 0x6BEEB0 VA: 0x1806BFCB0
	private List<DeadBody> GetBodiesInAbilityRangeSorted(List<DeadBody> outputList, bool ignoreColliders) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	public virtual void AdjustTasks(PlayerControl player) { }

	// RVA: 0x6BFA50 Offset: 0x6BEC50 VA: 0x1806BFA50 Slot: 25
	public virtual void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 26
	public virtual void HandleRoleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	public virtual void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim) { }

	// RVA: 0x6C1040 Offset: 0x6C0240 VA: 0x1806C1040
	protected void .ctor() { }

	// RVA: 0x6C0F80 Offset: 0x6C0180 VA: 0x1806C0F80
	private static void .cctor() { }
}

// Namespace: 
public class RoleManager.RoleAssignmentData // TypeDefIndex: 1649
{
	// Fields
	public RoleBehaviour Role; // 0x10
	public int Count; // 0x18
	public int Chance; // 0x1C

	// Methods

	// RVA: 0x6BFA00 Offset: 0x6BEC00 VA: 0x1806BFA00
	public void .ctor(RoleBehaviour role, int count, int chance) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RoleManager.<>c // TypeDefIndex: 1650
{
	// Fields
	public static readonly RoleManager.<>c <>9; // 0x0
	public static Func<ClientData, bool> <>9__11_0; // 0x8
	public static Func<ClientData, bool> <>9__11_1; // 0x10
	public static Func<ClientData, bool> <>9__11_2; // 0x18
	public static Func<ClientData, int> <>9__11_3; // 0x20
	public static Func<ClientData, NetworkedPlayerInfo> <>9__11_4; // 0x28
	public static Func<PlayerControl, bool> <>9__14_0; // 0x30
	public static Func<PlayerControl, bool> <>9__14_1; // 0x38

	// Methods

	// RVA: 0x6C9DC0 Offset: 0x6C8FC0 VA: 0x1806C9DC0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9270 Offset: 0x6C8470 VA: 0x1806C9270
	internal bool <SelectRoles>b__11_0(ClientData c) { }

	// RVA: 0x6C92D0 Offset: 0x6C84D0 VA: 0x1806C92D0
	internal bool <SelectRoles>b__11_1(ClientData c) { }

	// RVA: 0x6C9340 Offset: 0x6C8540 VA: 0x1806C9340
	internal bool <SelectRoles>b__11_2(ClientData c) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int <SelectRoles>b__11_3(ClientData c) { }

	// RVA: 0x6C93C0 Offset: 0x6C85C0 VA: 0x1806C93C0
	internal NetworkedPlayerInfo <SelectRoles>b__11_4(ClientData c) { }

	// RVA: 0x6C9410 Offset: 0x6C8610 VA: 0x1806C9410
	internal bool <TryAssignSpecialGhostRoles>b__14_0(PlayerControl pc) { }

	// RVA: 0x6C9470 Offset: 0x6C8670 VA: 0x1806C9470
	internal bool <TryAssignSpecialGhostRoles>b__14_1(PlayerControl pc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleManager.<>c__DisplayClass10_0 // TypeDefIndex: 1651
{
	// Fields
	public RoleTypes roleType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9510 Offset: 0x6C8710 VA: 0x1806C9510
	internal bool <SetRole>b__0(RoleBehaviour r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleManager.<>c__DisplayClass18_0 // TypeDefIndex: 1652
{
	// Fields
	public RoleTypes roleType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9510 Offset: 0x6C8710 VA: 0x1806C9510
	internal bool <IsImpostorRole>b__0(RoleBehaviour r) { }
}

// Namespace: 
public class RoleManager : DestroyableSingleton<RoleManager> // TypeDefIndex: 1653
{
	// Fields
	private static readonly HashSet<RoleTypes> GhostRoles; // 0x0
	public List<RoleBehaviour> AllRoles; // 0x28
	public RoleEffectAnimation shapeshiftAnim; // 0x30
	public RoleEffectAnimation protectAnim; // 0x38
	public RoleEffectAnimation protectLoopAnim; // 0x40
	public RoleEffectAnimation vanish_ChargeAnim; // 0x48
	public RoleEffectAnimation vanish_PoofAnim; // 0x50
	public RoleEffectAnimation appear_PoofAnim; // 0x58

	// Methods

	// RVA: 0x6C1610 Offset: 0x6C0810 VA: 0x1806C1610 Slot: 4
	public override void Awake() { }

	// RVA: 0x6C16B0 Offset: 0x6C08B0 VA: 0x1806C16B0
	public RoleBehaviour GetRole(RoleTypes roleType) { }

	// RVA: 0x6C2300 Offset: 0x6C1500 VA: 0x1806C2300
	public void SetRole(PlayerControl targetPlayer, RoleTypes roleType) { }

	// RVA: 0x6C19B0 Offset: 0x6C0BB0 VA: 0x1806C19B0
	public void SelectRoles() { }

	// RVA: 0x6C1450 Offset: 0x6C0650 VA: 0x1806C1450
	public void AssignRoleOnDeath(PlayerControl player, bool specialRolesAllowed) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void DebugRoleAssignments(List<NetworkedPlayerInfo> players, ref int numImpostors) { }

	// RVA: 0x6C27F0 Offset: 0x6C19F0 VA: 0x1806C27F0
	private static void TryAssignSpecialGhostRoles(PlayerControl player, bool impostorRoles) { }

	// RVA: 0x6C17F0 Offset: 0x6C09F0 VA: 0x1806C17F0
	public static bool IsGhostRole(RoleTypes role) { }

	// RVA: 0x6C26E0 Offset: 0x6C18E0 VA: 0x1806C26E0
	private static List<RoleTypes> SpecialCrewmateGhostRoles() { }

	// RVA: 0x6C2780 Offset: 0x6C1980 VA: 0x1806C2780
	private static List<RoleTypes> SpecialImpostorGhostRoles() { }

	// RVA: 0x6C1870 Offset: 0x6C0A70 VA: 0x1806C1870
	public static bool IsImpostorRole(RoleTypes roleType) { }

	// RVA: 0x6C2EB0 Offset: 0x6C20B0 VA: 0x1806C2EB0
	public void .ctor() { }

	// RVA: 0x6C2DE0 Offset: 0x6C1FE0 VA: 0x1806C2DE0
	private static void .cctor() { }
}

// Namespace: 
public enum RoleTeamTypes // TypeDefIndex: 1654
{
	// Fields
	public int value__; // 0x0
	public const RoleTeamTypes Crewmate = 0;
	public const RoleTeamTypes Impostor = 1;
}

// Namespace: 
public class ScientistRole : RoleBehaviour // TypeDefIndex: 1655
{
	// Fields
	public VitalsMinigame VitalsPrefab; // 0xC0
	private VitalsMinigame minigame; // 0xC8
	private float currentCharge; // 0xD0
	private float currentCooldown; // 0xD4

	// Properties
	public override bool IsDead { get; }
	private bool IsCoolingDown { get; }
	private float RoleCooldownValue { get; }
	private float RoleBatteryCharge { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public override bool get_IsDead() { }

	// RVA: 0x6C3920 Offset: 0x6C2B20 VA: 0x1806C3920
	private bool get_IsCoolingDown() { }

	// RVA: 0x6C39A0 Offset: 0x6C2BA0 VA: 0x1806C39A0
	private float get_RoleCooldownValue() { }

	// RVA: 0x6C3940 Offset: 0x6C2B40 VA: 0x1806C3940
	private float get_RoleBatteryCharge() { }

	// RVA: 0x6C3110 Offset: 0x6C2310 VA: 0x1806C3110 Slot: 16
	public override void Initialize(PlayerControl player) { }

	// RVA: 0x6C3130 Offset: 0x6C2330 VA: 0x1806C3130 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6C33A0 Offset: 0x6C25A0 VA: 0x1806C33A0
	private void Update() { }

	// RVA: 0x6C3250 Offset: 0x6C2450 VA: 0x1806C3250
	public bool Recharge() { }

	// RVA: 0x6C3610 Offset: 0x6C2810 VA: 0x1806C3610 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6C2F60 Offset: 0x6C2160 VA: 0x1806C2F60 Slot: 6
	public override bool CanUse(IUsable console) { }

	// RVA: 0x699C00 Offset: 0x698E00 VA: 0x180699C00 Slot: 7
	public override bool DidWin(GameOverReason gameOverReason) { }

	// RVA: 0x6C32F0 Offset: 0x6C24F0 VA: 0x1806C32F0
	private void RefreshAbilityButton() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x6C3890 Offset: 0x6C2A90 VA: 0x1806C3890
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShapeshifterMinigame.<>c__DisplayClass8_0 // TypeDefIndex: 1656
{
	// Fields
	public List<byte> bodies; // 0x10
	public ShapeshifterMinigame <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C99D0 Offset: 0x6C8BD0 VA: 0x1806C99D0
	internal void <Begin>b__0(DeadBody body) { }

	// RVA: 0x6C9A80 Offset: 0x6C8C80 VA: 0x1806C9A80
	internal bool <Begin>b__1(PlayerControl p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShapeshifterMinigame.<>c__DisplayClass8_1 // TypeDefIndex: 1657
{
	// Fields
	public PlayerControl player; // 0x10
	public ShapeshifterMinigame.<>c__DisplayClass8_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9BA0 Offset: 0x6C8DA0 VA: 0x1806C9BA0
	internal void <Begin>b__2() { }
}

// Namespace: 
public class ShapeshifterMinigame : Minigame // TypeDefIndex: 1658
{
	// Fields
	public ShapeshifterPanel PanelPrefab; // 0x88
	public float XStart; // 0x90
	public float YStart; // 0x94
	public float XOffset; // 0x98
	public float YOffset; // 0x9C
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xA0
	public UiElement DefaultButtonSelected; // 0xA8
	private List<ShapeshifterPanel> potentialVictims; // 0xB0

	// Methods

	// RVA: 0x6C4740 Offset: 0x6C3940 VA: 0x1806C4740 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6C4EB0 Offset: 0x6C40B0 VA: 0x1806C4EB0
	private void Shapeshift(PlayerControl target) { }

	// RVA: 0x6C4E40 Offset: 0x6C4040 VA: 0x1806C4E40
	private void OnDisable() { }

	// RVA: 0x6C5090 Offset: 0x6C4290 VA: 0x1806C5090
	public void .ctor() { }
}

// Namespace: 
public class ShapeshifterPanel : MonoBehaviour // TypeDefIndex: 1659
{
	// Fields
	public PoolablePlayer PlayerIcon; // 0x20
	public SpriteRenderer Background; // 0x28
	public TextMeshPro NameText; // 0x30
	public TextMeshPro LevelNumberText; // 0x38
	public PassiveButton Button; // 0x40
	private Action shapeshift; // 0x48
	public TextMeshPro ColorBlindName; // 0x50

	// Methods

	// RVA: 0x6C5230 Offset: 0x6C4430 VA: 0x1806C5230
	public void SetPlayer(int index, NetworkedPlayerInfo playerInfo, Action onShift) { }

	// RVA: 0x6C55E0 Offset: 0x6C47E0 VA: 0x1806C55E0
	public void ShapeShift() { }

	// RVA: 0x6C50C0 Offset: 0x6C42C0 VA: 0x1806C50C0
	private void OnDisable() { }

	// RVA: 0x6C5180 Offset: 0x6C4380 VA: 0x1806C5180
	private void SetColorblindText() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ShapeshifterRole.<>c // TypeDefIndex: 1660
{
	// Fields
	public static readonly ShapeshifterRole.<>c <>9; // 0x0
	public static Predicate<RoleEffectAnimation> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x6C9D60 Offset: 0x6C8F60 VA: 0x1806C9D60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C94F0 Offset: 0x6C86F0 VA: 0x1806C94F0
	internal bool <UseAbility>b__7_0(RoleEffectAnimation r) { }
}

// Namespace: 
public class ShapeshifterRole : ImpostorRole // TypeDefIndex: 1661
{
	// Fields
	public ShapeshifterEvidence EvidencePrefab; // 0xC0
	public Vector3 EvidenceOffset; // 0xC8
	public ShapeshifterMinigame ShapeshifterMenu; // 0xD8
	private float cooldownSecondsRemaining; // 0xE0
	private float durationSecondsRemaining; // 0xE4

	// Properties
	private bool IsCoolingDown { get; }

	// Methods

	// RVA: 0x6C64C0 Offset: 0x6C56C0 VA: 0x1806C64C0
	private bool get_IsCoolingDown() { }

	// RVA: 0x6C6140 Offset: 0x6C5340 VA: 0x1806C6140 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6C5CA0 Offset: 0x6C4EA0 VA: 0x1806C5CA0
	public void RevertPlayerToNormal(bool shouldAnimate = True, bool setCooldown = True) { }

	// RVA: 0x6C5B30 Offset: 0x6C4D30 VA: 0x1806C5B30 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6C5DE0 Offset: 0x6C4FE0 VA: 0x1806C5DE0 Slot: 19
	public override void SetCooldown() { }

	// RVA: 0x6C6050 Offset: 0x6C5250 VA: 0x1806C6050
	private bool ShouldUpdateUnshiftTimer() { }

	// RVA: 0x6C5670 Offset: 0x6C4870 VA: 0x1806C5670
	private void FixedUpdate() { }

	// RVA: 0x6C5E90 Offset: 0x6C5090 VA: 0x1806C5E90
	public void SetEvidence() { }

	// RVA: 0x6C5610 Offset: 0x6C4810 VA: 0x1806C5610 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BF960 Offset: 0x6BEB60 VA: 0x1806BF960
	public void .ctor() { }
}

// Namespace: 
public class TrackerRole : CrewmateRole // TypeDefIndex: 1662
{
	// Fields
	private PlayerControl currentTarget; // 0xC0
	private float cooldownSecondsRemaining; // 0xC8
	private float durationSecondsRemaining; // 0xCC
	private float delaySecondsRemaining; // 0xD0
	private bool pauseTrackingTime; // 0xD4
	[SerializeField]
	private AudioClip cancelSound; // 0xD8
	private bool isTrackingActive; // 0xE0
	private const float DelaySeconds = 1;

	// Properties
	private bool IsCoolingDown { get; }
	private bool IsDelayed { get; }

	// Methods

	// RVA: 0x6A3FE0 Offset: 0x6A31E0 VA: 0x1806A3FE0
	private bool get_IsCoolingDown() { }

	// RVA: 0x6B8290 Offset: 0x6B7490 VA: 0x1806B8290
	private bool get_IsDelayed() { }

	// RVA: 0x6C7F90 Offset: 0x6C7190 VA: 0x1806C7F90 Slot: 10
	public override void UseAbility() { }

	// RVA: 0x6C6FE0 Offset: 0x6C61E0 VA: 0x1806C6FE0
	private void CancelTracking(bool setCooldown = True) { }

	// RVA: 0x6C7C90 Offset: 0x6C6E90 VA: 0x1806C7C90 Slot: 18
	public override void SetPlayerTarget(PlayerControl target) { }

	// RVA: 0x6C7210 Offset: 0x6C6410 VA: 0x1806C7210
	private void ClearPlayerTarget() { }

	// RVA: 0x6C72E0 Offset: 0x6C64E0 VA: 0x1806C72E0 Slot: 21
	public override PlayerControl FindClosestTarget() { }

	// RVA: 0x6C7820 Offset: 0x6C6A20 VA: 0x1806C7820 Slot: 23
	protected override float GetAbilityDistance() { }

	// RVA: 0x6C7EC0 Offset: 0x6C70C0 VA: 0x1806C7EC0
	private bool ShouldUpdateCancelTimer() { }

	// RVA: 0x6C7980 Offset: 0x6C6B80 VA: 0x1806C7980 Slot: 12
	public override void OnMeetingStart() { }

	// RVA: 0x6C7160 Offset: 0x6C6360 VA: 0x1806C7160
	public void CheckCancelTracking(PlayerControl pc) { }

	// RVA: 0x6C79D0 Offset: 0x6C6BD0 VA: 0x1806C79D0 Slot: 13
	public override void OnVotingComplete() { }

	// RVA: 0x6C7B50 Offset: 0x6C6D50 VA: 0x1806C7B50 Slot: 19
	public override void SetCooldown() { }

	// RVA: 0x6C73D0 Offset: 0x6C65D0 VA: 0x1806C73D0
	private void FixedUpdate() { }

	// RVA: 0x6C7830 Offset: 0x6C6A30 VA: 0x1806C7830 Slot: 14
	public override void OnDeath(DeathReason reason) { }

	// RVA: 0x6C6F80 Offset: 0x6C6180 VA: 0x1806C6F80 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6C7930 Offset: 0x6C6B30 VA: 0x1806C7930
	private void OnDestroy() { }

	// RVA: 0x6BDFD0 Offset: 0x6BD1D0 VA: 0x1806BDFD0
	public void .ctor() { }
}

// Namespace: 
public class ViperDeadBody : DeadBody // TypeDefIndex: 1663
{
	// Fields
	[SerializeField]
	private AnimationClip[] dissolveAnims; // 0x40
	[SerializeField]
	private SpriteRenderer acidRenderer; // 0x48
	[SerializeField]
	private SpriteRenderer splashRenderer; // 0x50
	[SerializeField]
	private SpriteAnim spriteAnim; // 0x58
	[SerializeField]
	private AudioClip acidSplashSFX; // 0x60
	private float dissolveCurrentTime; // 0x68
	private float maxDissolveTime; // 0x6C
	private bool victimDissolving; // 0x70
	private int dissolveStage; // 0x74
	private PlayerControl myKiller; // 0x78
	private PlayerControl myController; // 0x80

	// Methods

	// RVA: 0x6CA320 Offset: 0x6C9520 VA: 0x1806CA320
	public void SetupViperInfo(float maxTime, PlayerControl killer, PlayerControl owner) { }

	// RVA: 0x6CA0B0 Offset: 0x6C92B0 VA: 0x1806CA0B0
	private void FixedUpdate() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public class ViperRole : ImpostorRole // TypeDefIndex: 1664
{
	// Fields
	[SerializeField]
	private Sprite killSprite; // 0xC0

	// Properties
	private float dissolveMaxTime { get; }

	// Methods

	// RVA: 0x6CA810 Offset: 0x6C9A10 VA: 0x1806CA810
	private float get_dissolveMaxTime() { }

	// RVA: 0x6CA5E0 Offset: 0x6C97E0 VA: 0x1806CA5E0 Slot: 16
	public override void Initialize(PlayerControl player) { }

	// RVA: 0x6CA690 Offset: 0x6C9890 VA: 0x1806CA690 Slot: 27
	public override void KillAnimSpecialSetup(DeadBody deadBody, PlayerControl killer, PlayerControl victim) { }

	// RVA: 0x6CA580 Offset: 0x6C9780 VA: 0x1806CA580 Slot: 25
	public override void AppendTaskHint(StringBuilder taskStringBuilder) { }

	// RVA: 0x6BF960 Offset: 0x6BEB60 VA: 0x1806BF960
	public void .ctor() { }
}

// Namespace: 
public class Rotater : MonoBehaviour // TypeDefIndex: 1665
{
	// Fields
	public float DegreesPerSecond; // 0x20

	// Methods

	// RVA: 0x6C2EF0 Offset: 0x6C20F0 VA: 0x1806C2EF0
	private void Update() { }

	// RVA: 0x6C2F50 Offset: 0x6C2150 VA: 0x1806C2F50
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(fileName = "BuildSettingsConsole", menuName = "BuildSettingsConsole")]
public class BuildSettingsConsole : ScriptableObject // TypeDefIndex: 1666
{
	// Fields
	[Header("Xbox Options")]
	public int XboxOneGameCoreStreamingInstallLaunchRange; // 0x18
	public int SeriesXGameCoreStreamingInstallLaunchRange; // 0x1C
	[Header("Switch Options")]
	public string SwitchDescFile; // 0x20
	public short SwitchReleaseVersion; // 0x28
	public string SwitchOriginalRomFile; // 0x30
	public string SwitchPreviousRomFile; // 0x38
	public bool SwitchCreateRomFile; // 0x40
	public bool SwitchEnableDebugNpad; // 0x41
	public bool SwitchEnableHeapInspector; // 0x42
	public bool SwitchNVNDrawValidation; // 0x43
	public bool SwitchNVNGraphicsDebugger; // 0x44
	public bool SwitchNVNShaderDebugging; // 0x45
	public bool SwitchRedirectWritesToHostMount; // 0x46
	[Header("PS4 Options")]
	public string PS4PronunciationXmlPath; // 0x48
	public string PS4PronunciationSigPath; // 0x50
	public string PS4BackgroundImagePath; // 0x58
	public string PS4StartupImagePath; // 0x60
	public string PS4TrophyPackPath; // 0x68
	public string PS4SonyPasscode; // 0x70
	public bool PS4CompressPackage; // 0x78
	[Header("PS4 SIEA Options")]
	public string PS4VersionSiea; // 0x80
	public string PS4PatchPkgPathSiea; // 0x88
	public string PS4PatchLatestPkgPathSiea; // 0x90
	public string PS4PatchChangeInfoPathSiea; // 0x98
	public string PS4ContentIdSiea; // 0xA0
	public string PS4TitleSecretSiea; // 0xA8
	public string PS4TitleDatPathSiea; // 0xB0
	public int PS4AgeRatingSiea; // 0xB8
	public string PS4ParamSfxPathSiea; // 0xC0
	[Header("PS4 SIEE Options")]
	public string PS4VersionSiee; // 0xC8
	public string PS4PatchPkgPathSiee; // 0xD0
	public string PS4PatchLatestPkgPathSiee; // 0xD8
	public string PS4PatchChangeInfoPathSiee; // 0xE0
	public string PS4ContentIdSiee; // 0xE8
	public string PS4TitleSecretSiee; // 0xF0
	public string PS4TitleDatPathSiee; // 0xF8
	public int PS4AgeRatingSiee; // 0x100
	public string PS4ParamSfxPathSiee; // 0x108
	[Header("PS4 SIEJ Options")]
	public string PS4VersionSiej; // 0x110
	public string PS4PatchPkgPathSiej; // 0x118
	public string PS4PatchLatestPkgPathSiej; // 0x120
	public string PS4PatchChangeInfoPathSiej; // 0x128
	public string PS4ContentIdSiej; // 0x130
	public string PS4TitleSecretSiej; // 0x138
	public string PS4TitleDatPathSiej; // 0x140
	public int PS4AgeRatingSiej; // 0x148
	public string PS4ParamSfxPathSiej; // 0x150
	[Header("PS4 SIEAsia Options")]
	public string PS4VersionSieAsia; // 0x158
	public string PS4PatchPkgPathSieAsia; // 0x160
	public string PS4PatchLatestPkgPathSieAsia; // 0x168
	public string PS4PatchChangeInfoPathSieAsia; // 0x170
	public string PS4ContentIdSieAsia; // 0x178
	public string PS4TitleSecretSieAsia; // 0x180
	public string PS4TitleDatPathSieAsia; // 0x188
	public int PS4AgeRatingSieAsia; // 0x190
	public string PS4ParamSfxPathSieAsia; // 0x198
	[Header("PS5 Options")]
	public string PS5BackgroundImagePath; // 0x1A0
	public string PS5StartupImagePath; // 0x1A8
	public string PS5StartupForegroundImagePath; // 0x1B0
	public string PS5StartupBackgroundImagePath; // 0x1B8
	public string PS5StartupImagesFolder; // 0x1C0
	public string PS5IconImagesFolder; // 0x1C8
	public string PS5BgmPath; // 0x1D0
	public string PS5SonyPasscode; // 0x1D8
	public bool PS5NeedSubmissionMaterials; // 0x1E0
	public string PS5UpdateReferencePackage; // 0x1E8

	// Methods

	// RVA: 0x6B0280 Offset: 0x6AF480 VA: 0x1806B0280
	public PS4Settings GetPS4Settings(PSRegion _psRegion) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public struct PS4Settings // TypeDefIndex: 1667
{
	// Fields
	public string ContentID; // 0x0
	public string NpTitleSecret; // 0x8
	public string NpTitleDatPath; // 0x10
	public int NpAgeRating; // 0x18
	public string PS4PatchPkgPath; // 0x20
	public string PS4PatchLatestPkgPath; // 0x28
	public string PS4PatchChangeInfoPath; // 0x30
	public string PS4ParamSfxPath; // 0x38
	public string PS4Version; // 0x40
}

// Namespace: 
public enum PSRegion // TypeDefIndex: 1668
{
	// Fields
	public int value__; // 0x0
	public const PSRegion SIEA = 0;
	public const PSRegion SIEE = 1;
	public const PSRegion SIEJ = 2;
	public const PSRegion SIEAsia = 3;
}

// Namespace: 
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour // TypeDefIndex: 1669
{
	// Properties
	public static bool Initialized { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_Initialized() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SecurityLogger.<>c__DisplayClass9_0 // TypeDefIndex: 1670
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9BD0 Offset: 0x6C8DD0 VA: 0x1806C9BD0
	internal bool <FixedUpdate>b__0(PlayerControl p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SecurityLogger.<BlinkSensor>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1671
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SecurityLogger <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C82A0 Offset: 0x6C74A0 VA: 0x1806C82A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C8410 Offset: 0x6C7610 VA: 0x1806C8410 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SecurityLogger : MonoBehaviour // TypeDefIndex: 1672
{
	// Fields
	private static Collider2D[] hits; // 0x0
	public SecurityLogBehaviour LogParent; // 0x20
	public SecurityLogBehaviour.SecurityLogLocations MyLocation; // 0x28
	public float Cooldown; // 0x2C
	public SpriteRenderer Image; // 0x30
	public BoxCollider2D Sensor; // 0x38
	private float[] Timers; // 0x40
	private ContactFilter2D filter; // 0x48

	// Methods

	// RVA: 0x6C4180 Offset: 0x6C3380 VA: 0x1806C4180
	private void Awake() { }

	// RVA: 0x6C4250 Offset: 0x6C3450 VA: 0x1806C4250
	public void FixedUpdate() { }

	[IteratorStateMachine(typeof(SecurityLogger.<BlinkSensor>d__10))]
	// RVA: 0x6C41F0 Offset: 0x6C33F0 VA: 0x1806C41F0
	private IEnumerator BlinkSensor() { }

	// RVA: 0x6C4660 Offset: 0x6C3860 VA: 0x1806C4660
	public void .ctor() { }

	// RVA: 0x6C4600 Offset: 0x6C3800 VA: 0x1806C4600
	private static void .cctor() { }
}

// Namespace: 
public class SecurityCameraSystemType : ISystemType // TypeDefIndex: 1673
{
	// Fields
	public const byte IncrementOp = 1;
	public const byte DecrementOp = 2;
	private HashSet<byte> PlayersUsing; // 0x10
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x18
	private HashSet<byte> ToRemove; // 0x20

	// Properties
	public bool InUse { get; }
	public bool IsDirty { get; set; }

	// Methods

	// RVA: 0x6C4130 Offset: 0x6C3330 VA: 0x1806C4130
	public bool get_InUse() { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void set_IsDirty(bool value) { }

	// RVA: 0x6C3AE0 Offset: 0x6C2CE0 VA: 0x1806C3AE0 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6C3FF0 Offset: 0x6C31F0 VA: 0x1806C3FF0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6C3EB0 Offset: 0x6C30B0 VA: 0x1806C3EB0
	private void UpdateCameras() { }

	// RVA: 0x6C3D60 Offset: 0x6C2F60 VA: 0x1806C3D60 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6C3D70 Offset: 0x6C2F70 VA: 0x1806C3D70 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6C3A00 Offset: 0x6C2C00 VA: 0x1806C3A00 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x6C40A0 Offset: 0x6C32A0 VA: 0x1806C40A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SurveillanceMinigame.<>c // TypeDefIndex: 1674
{
	// Fields
	public static readonly SurveillanceMinigame.<>c <>9; // 0x0
	public static Func<PlainShipRoom, bool> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x6C9E20 Offset: 0x6C9020 VA: 0x1806C9E20
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C8F40 Offset: 0x6C8140 VA: 0x1806C8F40
	internal bool <Begin>b__10_0(PlainShipRoom i) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SurveillanceMinigame.<CoAnimateClose>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1675
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SurveillanceMinigame <>4__this; // 0x20
	private float <timer>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8450 Offset: 0x6C7650 VA: 0x1806C8450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C86D0 Offset: 0x6C78D0 VA: 0x1806C86D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SurveillanceMinigame.<CoAnimateOpen>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1676
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SurveillanceMinigame <>4__this; // 0x20
	private float <timer>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8710 Offset: 0x6C7910 VA: 0x1806C8710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C8B20 Offset: 0x6C7D20 VA: 0x1806C8B20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SurveillanceMinigame.<CoDestroySelf>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1677
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SurveillanceMinigame <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8C50 Offset: 0x6C7E50 VA: 0x1806C8C50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6C8D90 Offset: 0x6C7F90 VA: 0x1806C8D90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SurveillanceMinigame : Minigame // TypeDefIndex: 1678
{
	// Fields
	public Camera CameraPrefab; // 0x88
	public GameObject Viewables; // 0x90
	public MeshRenderer[] ViewPorts; // 0x98
	public TextMeshPro[] SabText; // 0xA0
	private PlainShipRoom[] FilteredRooms; // 0xA8
	private RenderTexture[] textures; // 0xB0
	public MeshRenderer FillQuad; // 0xB8
	public Material DefaultMaterial; // 0xC0
	public Material StaticMaterial; // 0xC8
	private bool isStatic; // 0xD0

	// Methods

	// RVA: 0x6C64E0 Offset: 0x6C56E0 VA: 0x1806C64E0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6C6CC0 Offset: 0x6C5EC0 VA: 0x1806C6CC0
	public void Update() { }

	[IteratorStateMachine(typeof(SurveillanceMinigame.<CoAnimateOpen>d__12))]
	// RVA: 0x6C6B70 Offset: 0x6C5D70 VA: 0x1806C6B70 Slot: 7
	protected override IEnumerator CoAnimateOpen() { }

	[IteratorStateMachine(typeof(SurveillanceMinigame.<CoAnimateClose>d__13))]
	// RVA: 0x6C6B10 Offset: 0x6C5D10 VA: 0x1806C6B10
	private IEnumerator CoAnimateClose() { }

	[IteratorStateMachine(typeof(SurveillanceMinigame.<CoDestroySelf>d__14))]
	// RVA: 0x6C6BD0 Offset: 0x6C5DD0 VA: 0x1806C6BD0 Slot: 8
	protected override IEnumerator CoDestroySelf() { }

	// RVA: 0x6C6AB0 Offset: 0x6C5CB0 VA: 0x1806C6AB0 Slot: 6
	public override void Close() { }

	// RVA: 0x6C6C30 Offset: 0x6C5E30 VA: 0x1806C6C30
	public void OnDestroy() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
public class SetNameText : MonoBehaviour // TypeDefIndex: 1679
{
	// Fields
	[SerializeField]
	private TextMeshPro nameText; // 0x20

	// Methods

	// RVA: 0x6C46B0 Offset: 0x6C38B0 VA: 0x1806C46B0
	private void Start() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public interface IChatModeDisplay // TypeDefIndex: 1680
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UpdateDisplay();
}

// Namespace: 
public class ChatModeCycle : MonoBehaviour, IChatModeDisplay // TypeDefIndex: 1681
{
	// Fields
	public CycleButtonBehaviour chatMode; // 0x20
	public TextMeshPro chatModeText; // 0x28
	public SpriteRenderer backgroundSprite; // 0x30

	// Methods

	// RVA: 0x6B0440 Offset: 0x6AF640 VA: 0x1806B0440
	public void Awake() { }

	// RVA: 0x6B05E0 Offset: 0x6AF7E0 VA: 0x1806B05E0
	public void OnEnable() { }

	// RVA: 0x6B05F0 Offset: 0x6AF7F0 VA: 0x1806B05F0 Slot: 4
	public void UpdateDisplay() { }

	// RVA: 0x6B0490 Offset: 0x6AF690 VA: 0x1806B0490
	public void CycleChatMode() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ChatModeToggle : MonoBehaviour, IChatModeDisplay // TypeDefIndex: 1682
{
	// Fields
	public SpriteRenderer quickChatBackgroundSprite; // 0x20
	public SpriteRenderer freeChatBackgroundSprite; // 0x28
	public TextMeshPro infoText; // 0x30
	public TextMeshPro warningText; // 0x38
	private float warningTimer; // 0x40

	// Methods

	// RVA: 0x6B0940 Offset: 0x6AFB40 VA: 0x1806B0940
	public void Awake() { }

	// RVA: 0x6B0BE0 Offset: 0x6AFDE0 VA: 0x1806B0BE0
	public void OnEnable() { }

	// RVA: 0x6B0F50 Offset: 0x6B0150 VA: 0x1806B0F50
	private void Update() { }

	// RVA: 0x6B0B30 Offset: 0x6AFD30 VA: 0x1806B0B30
	public void ClickQuickChat() { }

	// RVA: 0x6B0990 Offset: 0x6AFB90 VA: 0x1806B0990
	public void ClickFreeChat() { }

	// RVA: 0x6B0BF0 Offset: 0x6AFDF0 VA: 0x1806B0BF0 Slot: 4
	public void UpdateDisplay() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum SettingsMode // TypeDefIndex: 1683
{
	// Fields
	public int value__; // 0x0
	public const SettingsMode Host = 0;
	public const SettingsMode Search = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateOptionsPicker.<>c__DisplayClass12_0 // TypeDefIndex: 1684
{
	// Fields
	public int numPlayers; // 0x10
	public CreateOptionsPicker <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6C9530 Offset: 0x6C8730 VA: 0x1806C9530
	internal void <Awake>b__0() { }
}

// Namespace: 
public class CreateOptionsPicker : MonoBehaviour // TypeDefIndex: 1685
{
	// Fields
	private const float MaxPlayerButtonWidth = 0,5;
	public SpriteRenderer MaxPlayerButtonPrefab; // 0x20
	private List<SpriteRenderer> MaxPlayerButtons; // 0x28
	public Transform MaxPlayersRoot; // 0x30
	public MapPickerMenu MapMenu; // 0x38
	public ImpostorsOptionButton[] ImpostorButtons; // 0x40
	public TextMeshPro LanguageButton; // 0x48
	public TextMeshPro GameModeText; // 0x50
	public TextMeshPro ImpostorText; // 0x58
	public SettingsMode mode; // 0x60
	public CrewVisualizer CrewArea; // 0x68
	public CreateGameOptions optionsMenu; // 0x70

	// Methods

	// RVA: 0x6B0FE0 Offset: 0x6B01E0 VA: 0x1806B0FE0
	public void Awake() { }

	// RVA: 0x6B2120 Offset: 0x6B1320 VA: 0x1806B2120
	public void Start() { }

	// RVA: 0x6B1480 Offset: 0x6B0680 VA: 0x1806B1480
	public void Refresh() { }

	// RVA: 0x6B1330 Offset: 0x6B0530 VA: 0x1806B1330
	public IGameOptions GetTargetOptions() { }

	// RVA: 0x6B2080 Offset: 0x6B1280 VA: 0x1806B2080
	private void SetTargetOptions(IGameOptions data) { }

	// RVA: 0x6B1EA0 Offset: 0x6B10A0 VA: 0x1806B1EA0
	public void SetMaxPlayersButtons(int maxPlayers) { }

	// RVA: 0x6B2490 Offset: 0x6B1690 VA: 0x1806B2490
	private void UpdateMaxPlayersButtons(IGameOptions opts) { }

	// RVA: 0x6B19F0 Offset: 0x6B0BF0 VA: 0x1806B19F0
	public void SetImpostorButtons(int numImpostors) { }

	// RVA: 0x6B2130 Offset: 0x6B1330 VA: 0x1806B2130
	private void UpdateImpostorsButtons(int numImpostors) { }

	// RVA: 0x6B1D40 Offset: 0x6B0F40 VA: 0x1806B1D40
	public void SetMap(int mapId) { }

	// RVA: 0x6B1C00 Offset: 0x6B0E00 VA: 0x1806B1C00
	public void SetLanguageFilter(uint keyword) { }

	// RVA: 0x6B23A0 Offset: 0x6B15A0 VA: 0x1806B23A0
	private void UpdateLanguageButton(uint flag) { }

	// RVA: 0x6B1830 Offset: 0x6B0A30 VA: 0x1806B1830
	public void SetGameMode(GameModes mode) { }

	// RVA: 0x6B28F0 Offset: 0x6B1AF0 VA: 0x1806B28F0
	public void .ctor() { }
}

// Namespace: 
public class GameModeCycle : MonoBehaviour // TypeDefIndex: 1686
{
	// Fields
	[SerializeField]
	private TextMeshPro GameModeText; // 0x20
	[SerializeField]
	private CreateOptionsPicker OptionsPicker; // 0x28

	// Methods

	// RVA: 0x6B2F20 Offset: 0x6B2120 VA: 0x1806B2F20
	public void CycleGameMode() { }

	// RVA: 0x6B2FA0 Offset: 0x6B21A0 VA: 0x1806B2FA0
	public void SetGameMode(GameModes mode) { }

	// RVA: 0x6B2E70 Offset: 0x6B2070 VA: 0x1806B2E70
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public static class GameModesHelpers // TypeDefIndex: 1687
{
	// Fields
	public static Dictionary<GameModes, StringNames> ModeToName; // 0x0

	// Methods

	// RVA: 0x6B3160 Offset: 0x6B2360 VA: 0x1806B3160
	private static void .cctor() { }
}

// Namespace: 
public class GameOptionsManager // TypeDefIndex: 1688
{
	// Fields
	[CompilerGenerated]
	private static GameOptionsManager <Instance>k__BackingField; // 0x0
	private readonly GameOptionsFactory gameOptionsFactory; // 0x10
	private readonly ILogger logger; // 0x18
	private GameModes currentGameMode; // 0x20
	private IGameOptions currentGameOptions; // 0x28
	private NormalGameOptionsV10 currentNormalGameOptions; // 0x30
	private HideNSeekGameOptionsV10 currentHideNSeekGameOptions; // 0x38
	private IGameOptions currentHostOptions; // 0x40
	private NormalGameOptionsV10 normalGameHostOptions; // 0x48
	private HideNSeekGameOptionsV10 hideNSeekGameHostOptions; // 0x50
	private IGameOptions currentSearchOptions; // 0x58
	private NormalGameOptionsV10 normalGameSearchOptions; // 0x60
	private HideNSeekGameOptionsV10 hideNSeekGameSearchOptions; // 0x68

	// Properties
	public static GameOptionsManager Instance { get; set; }
	public IGameOptions CurrentGameOptions { get; set; }
	public IGameOptions GameHostOptions { get; set; }
	public IGameOptions GameSearchOptions { get; set; }
	public bool HasOptions { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6B5290 Offset: 0x6B4490 VA: 0x1806B5290
	public static GameOptionsManager get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x6B5B30 Offset: 0x6B4D30 VA: 0x1806B5B30
	private static void set_Instance(GameOptionsManager value) { }

	// RVA: 0x6B33F0 Offset: 0x6B25F0 VA: 0x1806B33F0
	public Type GetGameOptions() { }

	// RVA: 0x6B5250 Offset: 0x6B4450 VA: 0x1806B5250
	public IGameOptions get_CurrentGameOptions() { }

	// RVA: 0x6B52D0 Offset: 0x6B44D0 VA: 0x1806B52D0
	public void set_CurrentGameOptions(IGameOptions value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public IGameOptions get_GameHostOptions() { }

	// RVA: 0x6B5590 Offset: 0x6B4790 VA: 0x1806B5590
	public void set_GameHostOptions(IGameOptions value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public IGameOptions get_GameSearchOptions() { }

	// RVA: 0x6B5860 Offset: 0x6B4A60 VA: 0x1806B5860
	public void set_GameSearchOptions(IGameOptions value) { }

	// RVA: 0x6B5280 Offset: 0x6B4480 VA: 0x1806B5280
	public bool get_HasOptions() { }

	// RVA: 0x6B5130 Offset: 0x6B4330 VA: 0x1806B5130
	public void .ctor(ILogger logger) { }

	// RVA: 0x6B3450 Offset: 0x6B2650 VA: 0x1806B3450
	public void Initialize() { }

	// RVA: 0x6B4D90 Offset: 0x6B3F90 VA: 0x1806B4D90
	public void SwitchGameMode(GameModes gameMode) { }

	// RVA: 0x6B38B0 Offset: 0x6B2AB0 VA: 0x1806B38B0
	private void LoadOrCreateNormalGameHostOptions() { }

	// RVA: 0x6B3490 Offset: 0x6B2690 VA: 0x1806B3490
	private void LoadOrCreateHideNSeekGameHostOptions() { }

	// RVA: 0x6B3B90 Offset: 0x6B2D90 VA: 0x1806B3B90
	private void LoadOrCreateNormalGameSearchOptions() { }

	// RVA: 0x6B36A0 Offset: 0x6B28A0 VA: 0x1806B36A0
	private void LoadOrCreateHideNSeekGameSearchOptions() { }

	// RVA: 0x6B4EC0 Offset: 0x6B40C0 VA: 0x1806B4EC0
	private bool TryLoadLegacyOptionsFile(string filename, out IGameOptions legacyGameOptions) { }

	// RVA: 0x6B4AB0 Offset: 0x6B3CB0 VA: 0x1806B4AB0
	private void SaveNormalHostOptions() { }

	// RVA: 0x6B4C20 Offset: 0x6B3E20 VA: 0x1806B4C20
	private void SaveNormalSearchOptions() { }

	// RVA: 0x6B47D0 Offset: 0x6B39D0 VA: 0x1806B47D0
	private void SaveHideNSeekHostOptions() { }

	// RVA: 0x6B4940 Offset: 0x6B3B40 VA: 0x1806B4940
	private void SaveHideNSeekSearchOptions() { }

	// RVA: 0x6B4320 Offset: 0x6B3520 VA: 0x1806B4320
	private NormalGameOptionsV10 MigrateNormalGameOptions(IGameOptions gameOptions) { }

	// RVA: 0x6B3E70 Offset: 0x6B3070 VA: 0x1806B3E70
	private HideNSeekGameOptionsV10 MigrateHideNSeekGameOptions(IGameOptions gameOptions) { }
}

// Namespace: 
public class GameOptionsManagerCreator : MonoBehaviour // TypeDefIndex: 1689
{
	// Methods

	// RVA: 0x6B3230 Offset: 0x6B2430 VA: 0x1806B3230
	private void Awake() { }

	// RVA: 0x6B3390 Offset: 0x6B2590 VA: 0x1806B3390
	private void Start() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum OptionTypes // TypeDefIndex: 1690
{
	// Fields
	public int value__; // 0x0
	public const OptionTypes Number = 0;
	public const OptionTypes Checkbox = 1;
	public const OptionTypes MultipleChoice = 2;
	public const OptionTypes String = 3;
	public const OptionTypes Float = 4;
	public const OptionTypes Int = 5;
	public const OptionTypes Player = 6;
	public const OptionTypes Map = 7;
}

// Namespace: 
[Serializable]
public struct RulesCategory // TypeDefIndex: 1691
{
	// Fields
	public StringNames CategoryName; // 0x0
	public List<BaseGameSetting> AllGameSettings; // 0x8
}

// Namespace: 
public class GameOptionsMenu : MonoBehaviour // TypeDefIndex: 1692
{
	// Fields
	private IGameOptions cachedData; // 0x20
	private List<OptionBehaviour> Children; // 0x28
	[SerializeField]
	private GameOptionsMapPicker MapPicker; // 0x30
	[SerializeField]
	private CategoryHeaderMasked categoryHeaderOrigin; // 0x38
	[SerializeField]
	private ToggleOption checkboxOrigin; // 0x40
	[SerializeField]
	private NumberOption numberOptionOrigin; // 0x48
	[SerializeField]
	private PlayerOption playerOptionOrigin; // 0x50
	[SerializeField]
	private StringOption stringOptionOrigin; // 0x58
	[SerializeField]
	private Transform settingsContainer; // 0x60
	[SerializeField]
	private Scroller scrollBar; // 0x68
	[SerializeField]
	private Transform[] HideForOnline; // 0x70
	[SerializeField]
	private RolesSettingsMenu RolesMenu; // 0x78
	[SerializeField]
	private Collider2D ButtonClickMask; // 0x80
	[SerializeField]
	private SpriteRenderer MaskBg; // 0x88
	[SerializeField]
	private SpriteRenderer MaskArea; // 0x90
	private const float START_POS_Y = 0,713;
	private const float START_POS_X = 0,952;
	private const float HEADER_HEIGHT = 0,63;
	private const float MAP_PICKER_HEIGHT = 1,65;
	private const float SPACING_Y = 0,45;
	private const float HEADER_X = -0,903;
	private const int MASK_LAYER = 20;
	private const float HEADER_SCALE = 0,63;
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x98
	public UiElement DefaultButtonSelected; // 0xA0
	public List<UiElement> ControllerSelectable; // 0xA8

	// Methods

	// RVA: 0x6B5B70 Offset: 0x6B4D70 VA: 0x1806B5B70
	private void Awake() { }

	// RVA: 0x6B61C0 Offset: 0x6B53C0 VA: 0x1806B61C0
	private void CreateSettings() { }

	// RVA: 0x6B7060 Offset: 0x6B6260 VA: 0x1806B7060
	private void Initialize() { }

	// RVA: 0x6B7530 Offset: 0x6B6730 VA: 0x1806B7530
	private void Update() { }

	// RVA: 0x6B7390 Offset: 0x6B6590 VA: 0x1806B7390
	private void OnEnable() { }

	// RVA: 0x6B6150 Offset: 0x6B5350 VA: 0x1806B6150
	private void OnDisable() { }

	// RVA: 0x6B73A0 Offset: 0x6B65A0 VA: 0x1806B73A0
	public void OpenMenu() { }

	// RVA: 0x6B6150 Offset: 0x6B5350 VA: 0x1806B6150
	public void CloseMenu() { }

	// RVA: 0x6B7480 Offset: 0x6B6680 VA: 0x1806B7480
	private void RefreshChildren() { }

	// RVA: 0x6B7610 Offset: 0x6B6810 VA: 0x1806B7610
	private void ValueChanged(OptionBehaviour option) { }

	// RVA: 0x6B6DD0 Offset: 0x6B5FD0 VA: 0x1806B6DD0
	private void InitializeControllerNavigation() { }

	// RVA: 0x6B5C40 Offset: 0x6B4E40 VA: 0x1806B5C40
	public void ClickPresetButton(RulesPresets preset) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IGameOptionsExtensions.<>c__DisplayClass20_0 // TypeDefIndex: 1693
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E1020 Offset: 0x6E0220 VA: 0x1806E1020
	internal bool <AppendImpostorPlayerSetting>b__0(NetworkedPlayerInfo p) { }
}

// Namespace: 
[Extension]
public static class IGameOptionsExtensions // TypeDefIndex: 1694
{
	// Fields
	private const byte SkeldBit = 1;
	private const byte MiraBit = 2;
	private const byte PolusBit = 4;
	private const byte AirshipBit = 16;
	private const byte FungleBit = 32;
	private const byte MapMask = 55;
	private static StringBuilder SettingsStringBuilder; // 0x0

	// Methods

	[Extension]
	// RVA: 0x6BA8E0 Offset: 0x6B9AE0 VA: 0x1806BA8E0
	public static void SetRecommendations(IGameOptions gameOptions, int numPlayers, NetworkModes modes) { }

	[Extension]
	// RVA: 0x6BA7E0 Offset: 0x6B99E0 VA: 0x1806BA7E0
	public static void SetRecommendations(IGameOptions gameOptions, int numPlayers, NetworkModes modes, RulesPresets rulesPresets) { }

	[Extension]
	// RVA: 0x6B9F70 Offset: 0x6B9170 VA: 0x1806B9F70
	public static int GetAdjustedNumImpostors(IGameOptions gameOptions, int playerCount) { }

	[Extension]
	// RVA: 0x6BBF30 Offset: 0x6BB130 VA: 0x1806BBF30
	public static void ToggleMapFilter(IGameOptions gameOptions, byte newId) { }

	[Extension]
	// RVA: 0x6B9EF0 Offset: 0x6B90F0 VA: 0x1806B9EF0
	public static bool FilterContainsMap(IGameOptions gameOptions, byte newId) { }

	[Extension]
	// RVA: 0x6BA1C0 Offset: 0x6B93C0 VA: 0x1806BA1C0
	public static float GetValue(IGameOptions gameOptions, BaseGameSetting data) { }

	[Extension]
	// RVA: 0x6BA970 Offset: 0x6B9B70 VA: 0x1806BA970
	public static string ToHudString(IGameOptions gameOptions, int numPlayers) { }

	// RVA: 0x6B9BE0 Offset: 0x6B8DE0 VA: 0x1806B9BE0
	private static void AppendItem(StringBuilder settings, StringNames stringName, bool value) { }

	// RVA: 0x6B9DD0 Offset: 0x6B8FD0 VA: 0x1806B9DD0
	private static void AppendItem(StringBuilder settings, StringNames stringName, float value, string secs) { }

	// RVA: 0x6B9AF0 Offset: 0x6B8CF0 VA: 0x1806B9AF0
	private static void AppendItem(StringBuilder settings, StringNames stringName, int value, string secs) { }

	// RVA: 0x6B9A20 Offset: 0x6B8C20 VA: 0x1806B9A20
	private static void AppendItem(StringBuilder settings, StringNames stringName, string value) { }

	// RVA: 0x6B9CF0 Offset: 0x6B8EF0 VA: 0x1806B9CF0
	private static void AppendItem(StringBuilder settings, StringNames stringName, int value) { }

	// RVA: 0x6B9EC0 Offset: 0x6B90C0 VA: 0x1806B9EC0
	private static void AppendItem(StringBuilder settings, string str) { }

	// RVA: 0x6B9790 Offset: 0x6B8990 VA: 0x1806B9790
	private static void AppendImpostorPlayerSetting(StringBuilder settings, IGameOptions options) { }

	[Extension]
	// RVA: 0x6BA0D0 Offset: 0x6B92D0 VA: 0x1806BA0D0
	public static StringNames GetRulesPresetTitle(IGameOptions gameOptions) { }

	// RVA: 0x6BBFC0 Offset: 0x6BB1C0 VA: 0x1806BBFC0
	private static void .cctor() { }
}

// Namespace: 
public class LanguageButton : MonoBehaviour // TypeDefIndex: 1695
{
	// Fields
	public TextMeshPro Title; // 0x20
	public PassiveButton Button; // 0x28
	[HideInInspector]
	public TranslatedImageSet Language; // 0x30

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LanguageSetter.<>c__DisplayClass10_0 // TypeDefIndex: 1696
{
	// Fields
	public LanguageButton button; // 0x10
	public LanguageSetter <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E0FF0 Offset: 0x6E01F0 VA: 0x1806E0FF0
	internal void <Start>b__0() { }
}

// Namespace: 
public class LanguageSetter : MonoBehaviour // TypeDefIndex: 1697
{
	// Fields
	public LanguageButton ButtonPrefab; // 0x20
	public Scroller ButtonParent; // 0x28
	public float ButtonStart; // 0x30
	public float ButtonHeight; // 0x34
	private LanguageButton[] AllButtons; // 0x38
	public TextMeshPro parentLangButton; // 0x40
	private List<UiElement> selectableButtons; // 0x48
	public UiElement backButton; // 0x50

	// Methods

	// RVA: 0x6CFA10 Offset: 0x6CEC10 VA: 0x1806CFA10
	private void OnEnable() { }

	// RVA: 0x6CF990 Offset: 0x6CEB90 VA: 0x1806CF990
	private void OnDisable() { }

	// RVA: 0x6CFD90 Offset: 0x6CEF90 VA: 0x1806CFD90
	public void Start() { }

	// RVA: 0x6CFBF0 Offset: 0x6CEDF0 VA: 0x1806CFBF0
	public void SetLanguage(LanguageButton selected) { }

	// RVA: 0x537E50 Offset: 0x537050 VA: 0x180537E50
	public void Open() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x6D0410 Offset: 0x6CF610 VA: 0x1806D0410
	public void .ctor() { }
}

// Namespace: 
public class MapFilterButton : MonoBehaviour // TypeDefIndex: 1698
{
	// Fields
	public MapNames MapId; // 0x20
	public PassiveButton Button; // 0x28
	[SerializeField]
	private SpriteRenderer Icon; // 0x30
	[SerializeField]
	private SpriteRenderer ButtonCheck; // 0x38
	[SerializeField]
	private SpriteRenderer ButtonOutline; // 0x40
	[SerializeField]
	private SpriteRenderer ButtonImage; // 0x48

	// Methods

	// RVA: 0x6D7D60 Offset: 0x6D6F60 VA: 0x1806D7D60
	public void Show() { }

	// RVA: 0x578380 Offset: 0x577580 VA: 0x180578380
	public void Hide() { }

	// RVA: 0x6D7B50 Offset: 0x6D6D50 VA: 0x1806D7B50
	public void SetFlipped(bool flipped) { }

	// RVA: 0x6D7BA0 Offset: 0x6D6DA0 VA: 0x1806D7BA0
	public void SetSelected(bool selected) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum MapNames // TypeDefIndex: 1699
{
	// Fields
	public int value__; // 0x0
	public const MapNames Skeld = 0;
	public const MapNames MiraHQ = 1;
	public const MapNames Polus = 2;
	public const MapNames Dleks = 3;
	public const MapNames Airship = 4;
	public const MapNames Fungle = 5;
}

// Namespace: 
public enum NumberSuffixes // TypeDefIndex: 1700
{
	// Fields
	public int value__; // 0x0
	public const NumberSuffixes None = 0;
	public const NumberSuffixes Multiplier = 1;
	public const NumberSuffixes Seconds = 2;
}

// Namespace: 
public class NumberOption : OptionBehaviour // TypeDefIndex: 1701
{
	// Fields
	public TextMeshPro TitleText; // 0x50
	public TextMeshPro ValueText; // 0x58
	public float Value; // 0x60
	private float oldValue; // 0x64
	public float Increment; // 0x68
	public FloatRange ValidRange; // 0x70
	public string FormatString; // 0x78
	public bool ZeroIsInfinity; // 0x80
	public NumberSuffixes SuffixType; // 0x84
	private FloatOptionNames floatOptionName; // 0x88
	private Int32OptionNames intOptionName; // 0x8C
	[SerializeField]
	private GameOptionButton PlusBtn; // 0x90
	[SerializeField]
	private GameOptionButton MinusBtn; // 0x98

	// Methods

	// RVA: 0x6D8170 Offset: 0x6D7370 VA: 0x1806D8170 Slot: 7
	public override void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	private void Start() { }

	// RVA: 0x6D8000 Offset: 0x6D7200 VA: 0x1806D8000 Slot: 8
	public override void Initialize() { }

	// RVA: 0x6D7EE0 Offset: 0x6D70E0 VA: 0x1806D7EE0
	private void FixedUpdate() { }

	// RVA: 0x6D7F80 Offset: 0x6D7180 VA: 0x1806D7F80
	public void Increase() { }

	// RVA: 0x6D7E60 Offset: 0x6D7060 VA: 0x1806D7E60
	public void Decrease() { }

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60 Slot: 4
	public override float GetFloat() { }

	// RVA: 0x6D7F70 Offset: 0x6D7170 VA: 0x1806D7F70 Slot: 5
	public override int GetInt() { }

	// RVA: 0x6D8610 Offset: 0x6D7810 VA: 0x1806D8610
	private void UpdateValue() { }

	// RVA: 0x6D7DC0 Offset: 0x6D6FC0 VA: 0x1806D7DC0
	private void AdjustButtonsActiveState() { }

	// RVA: 0x6D8870 Offset: 0x6D7A70 VA: 0x1806D8870
	public void .ctor() { }
}

// Namespace: 
public abstract class OptionBehaviour : MonoBehaviour // TypeDefIndex: 1702
{
	// Fields
	public SpriteRenderer LabelBackground; // 0x20
	public StringNames Title; // 0x28
	public Action<OptionBehaviour> OnValueChanged; // 0x30
	public RoleTypes AssociatedRole; // 0x38
	protected BaseGameSetting data; // 0x40
	private PassiveButton[] buttons; // 0x48

	// Properties
	public BaseGameSetting Data { get; }

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public BaseGameSetting get_Data() { }

	// RVA: 0x6D8B70 Offset: 0x6D7D70 VA: 0x1806D8B70 Slot: 4
	public virtual float GetFloat() { }

	// RVA: 0x6D8BB0 Offset: 0x6D7DB0 VA: 0x1806D8BB0 Slot: 5
	public virtual int GetInt() { }

	// RVA: 0x6D8B30 Offset: 0x6D7D30 VA: 0x1806D8B30 Slot: 6
	public virtual bool GetBool() { }

	// RVA: 0x6D8C20 Offset: 0x6D7E20 VA: 0x1806D8C20
	public void SetAsPlayer() { }

	// RVA: 0x6D8CF0 Offset: 0x6D7EF0 VA: 0x1806D8CF0
	public void SetClickMask(Collider2D clickMask) { }

	// RVA: 0x6D8DA0 Offset: 0x6D7FA0 VA: 0x1806D8DA0 Slot: 7
	public virtual void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void Initialize() { }

	// RVA: 0x6D8BF0 Offset: 0x6D7DF0 VA: 0x1806D8BF0
	public string GetValueString(float value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
public class OptionsMenuBehaviour : MonoBehaviour, ITranslatedText // TypeDefIndex: 1703
{
	// Fields
	public SpriteRenderer Background; // 0x20
	public SpriteRenderer JoystickButton; // 0x28
	public SpriteRenderer TouchButton; // 0x30
	public SlideBar JoystickSizeSlider; // 0x38
	public FloatRange JoystickSizes; // 0x40
	public SlideBar SoundSlider; // 0x48
	public SlideBar MusicSlider; // 0x50
	public ToggleButtonBehaviour CensorChatButton; // 0x58
	public ToggleButtonBehaviour DisableMouseMovement; // 0x60
	public ToggleButtonBehaviour EnableFriendInvitesButton; // 0x68
	public ToggleButtonBehaviour ColorBlindButton; // 0x70
	public GameObject KeyboardOptions; // 0x78
	public GameObject MouseAndKeyboardOptions; // 0x80
	public ToggleButtonBehaviour StreamerModeButton; // 0x88
	public GameObject TermsOfUsePlayStationPopup; // 0x90
	public TextMeshPro TermsOfUsePlayStationEULAText; // 0x98
	public BugReportPopup bugReportPopup; // 0xA0
	public bool Toggle; // 0xA8
	public TabGroup[] Tabs; // 0xB0
	public PassiveButton MenuButton; // 0xB8
	private bool grabbedControllerButtons; // 0xC0
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xC8
	public UiElement DefaultButtonSelected; // 0xD0
	public List<UiElement> ControllerSelectable; // 0xD8
	public List<UiElement> IgnoreControllerSelection; // 0xE0

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x5AB2A0 Offset: 0x5AA4A0 VA: 0x1805AB2A0
	public bool get_IsOpen() { }

	// RVA: 0x6D92E0 Offset: 0x6D84E0 VA: 0x1806D92E0
	public void OpenTabGroup(int index) { }

	// RVA: 0x6DA430 Offset: 0x6D9630 VA: 0x1806DA430
	private void Update() { }

	// RVA: 0x6D9A00 Offset: 0x6D8C00 VA: 0x1806D9A00
	public void Start() { }

	// RVA: 0x6D9000 Offset: 0x6D8200 VA: 0x1806D9000
	private void GrabControllerButtons() { }

	// RVA: 0x6D91C0 Offset: 0x6D83C0 VA: 0x1806D91C0
	private void OnDisable() { }

	// RVA: 0x6D9130 Offset: 0x6D8330 VA: 0x1806D9130
	public void OnDestroy() { }

	// RVA: 0x6D96D0 Offset: 0x6D88D0 VA: 0x1806D96D0 Slot: 4
	public void ResetText() { }

	// RVA: 0x6D93E0 Offset: 0x6D85E0 VA: 0x1806D93E0
	public void Open() { }

	// RVA: 0x6D9880 Offset: 0x6D8A80 VA: 0x1806D9880
	public void SetControlType(int i) { }

	// RVA: 0x6DA210 Offset: 0x6D9410 VA: 0x1806DA210
	public void UpdateJoystickSize() { }

	// RVA: 0x6DA3B0 Offset: 0x6D95B0 VA: 0x1806DA3B0
	public void UpdateSfxVolume() { }

	// RVA: 0x6DA330 Offset: 0x6D9530 VA: 0x1806DA330
	public void UpdateMusicVolume() { }

	// RVA: 0x6D9280 Offset: 0x6D8480 VA: 0x1806D9280
	public void OpenPrivacyPolicy() { }

	// RVA: 0x6D9380 Offset: 0x6D8580 VA: 0x1806D9380
	public void OpenTermsOfUse() { }

	// RVA: 0x6D9380 Offset: 0x6D8580 VA: 0x1806D9380
	public void ReallyOpenTermsOfUse() { }

	// RVA: 0x6D9D50 Offset: 0x6D8F50 VA: 0x1806D9D50
	public void TogglePersonalizedAd() { }

	// RVA: 0x6D9AD0 Offset: 0x6D8CD0 VA: 0x1806D9AD0
	public void ToggleCensorChat() { }

	// RVA: 0x6D9C10 Offset: 0x6D8E10 VA: 0x1806D9C10
	public void ToggleFriendsListInvites() { }

	// RVA: 0x6D9CB0 Offset: 0x6D8EB0 VA: 0x1806D9CB0
	public void ToggleMouseMovement() { }

	// RVA: 0x6D9DD0 Offset: 0x6D8FD0 VA: 0x1806D9DD0
	public void ToggleStreamerMode() { }

	// RVA: 0x6D9B70 Offset: 0x6D8D70 VA: 0x1806D9B70
	public void ToggleColorBlind() { }

	// RVA: 0x6D9240 Offset: 0x6D8440 VA: 0x1806D9240
	public void OpenBugReportPopup() { }

	// RVA: 0x6D9E70 Offset: 0x6D9070 VA: 0x1806D9E70
	public void UpdateButtons() { }

	// RVA: 0x6D8F80 Offset: 0x6D8180 VA: 0x1806D8F80
	public void Close() { }

	// RVA: 0x6DA600 Offset: 0x6D9800 VA: 0x1806DA600
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerOption.<>c // TypeDefIndex: 1704
{
	// Fields
	public static readonly PlayerOption.<>c <>9; // 0x0
	public static Comparison<NetworkedPlayerInfo> <>9__14_0; // 0x8
	public static Comparison<NetworkedPlayerInfo> <>9__16_0; // 0x10

	// Methods

	// RVA: 0x6E10A0 Offset: 0x6E02A0 VA: 0x1806E10A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E0F50 Offset: 0x6E0150 VA: 0x1806E0F50
	internal int <OnEnable>b__14_0(NetworkedPlayerInfo a, NetworkedPlayerInfo b) { }

	// RVA: 0x6E0F50 Offset: 0x6E0150 VA: 0x1806E0F50
	internal int <FixedUpdate>b__16_0(NetworkedPlayerInfo a, NetworkedPlayerInfo b) { }
}

// Namespace: 
public class PlayerOption : OptionBehaviour // TypeDefIndex: 1705
{
	// Fields
	public TextMeshPro TitleText; // 0x50
	public TextMeshPro ValueText; // 0x58
	[SerializeField]
	private TextMeshPro PlusTxt; // 0x60
	[SerializeField]
	private TextMeshPro MinusTxt; // 0x68
	[SerializeField]
	private TextMeshPro OptionUnavailableTxt; // 0x70
	[SerializeField]
	private GameOptionButton PlusBtn; // 0x78
	[SerializeField]
	private GameOptionButton MinusBtn; // 0x80
	[SerializeField]
	private GameObject ValueBox; // 0x88
	private List<NetworkedPlayerInfo> Values; // 0x90
	public int Value; // 0x98
	private int oldValue; // 0x9C
	private int playerIndex; // 0xA0
	private Int32OptionNames optionName; // 0xA4

	// Methods

	// RVA: 0x6DB720 Offset: 0x6DA920 VA: 0x1806DB720 Slot: 7
	public override void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x6DB3D0 Offset: 0x6DA5D0 VA: 0x1806DB3D0
	public void OnEnable() { }

	// RVA: 0x6DB800 Offset: 0x6DAA00 VA: 0x1806DB800
	private void SetValueText() { }

	// RVA: 0x6DB070 Offset: 0x6DA270 VA: 0x1806DB070
	private void FixedUpdate() { }

	// RVA: 0x6DB320 Offset: 0x6DA520 VA: 0x1806DB320
	public void Increase() { }

	// RVA: 0x6DAFC0 Offset: 0x6DA1C0 VA: 0x1806DAFC0
	public void Decrease() { }

	// RVA: 0x6DB2B0 Offset: 0x6DA4B0 VA: 0x1806DB2B0 Slot: 5
	public override int GetInt() { }

	// RVA: 0x6DBA40 Offset: 0x6DAC40 VA: 0x1806DBA40
	private void UpdatePlayerIndex(int index) { }

	// RVA: 0x6DAE50 Offset: 0x6DA050 VA: 0x1806DAE50
	private void CheckValueChanged() { }

	// RVA: 0x6DBAF0 Offset: 0x6DACF0 VA: 0x1806DBAF0
	private void UpdateValue() { }

	// RVA: 0x6DADA0 Offset: 0x6D9FA0 VA: 0x1806DADA0
	private void AdjustButtonsActiveState() { }

	// RVA: 0x6DBC40 Offset: 0x6DAE40 VA: 0x1806DBC40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6DBA10 Offset: 0x6DAC10 VA: 0x1806DBA10
	private bool <OnEnable>b__14_1(NetworkedPlayerInfo p) { }

	[CompilerGenerated]
	// RVA: 0x6DBA10 Offset: 0x6DAC10 VA: 0x1806DBA10
	private bool <FixedUpdate>b__16_1(NetworkedPlayerInfo p) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ResolutionSlider.<>c // TypeDefIndex: 1706
{
	// Fields
	public static readonly ResolutionSlider.<>c <>9; // 0x0
	public static Func<Resolution, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x6E1100 Offset: 0x6E0300 VA: 0x1806E1100
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E0F80 Offset: 0x6E0180 VA: 0x1806E0F80
	internal bool <OnEnable>b__9_0(Resolution r) { }
}

// Namespace: 
public class ResolutionSlider : MonoBehaviour // TypeDefIndex: 1707
{
	// Fields
	private int targetIdx; // 0x20
	private Resolution targetResolution; // 0x24
	private bool targetFullscreen; // 0x34
	private Resolution[] allResolutions; // 0x38
	public SlideBar slider; // 0x40
	public ToggleButtonBehaviour Fullscreen; // 0x48
	public ToggleButtonBehaviour VSync; // 0x50
	public TextMeshPro Display; // 0x58
	public ToggleButtonBehaviour Screenshake; // 0x60

	// Methods

	// RVA: 0x6DBC60 Offset: 0x6DAE60 VA: 0x1806DBC60
	public void OnEnable() { }

	// RVA: 0x6DC2A0 Offset: 0x6DB4A0 VA: 0x1806DC2A0
	public void ToggleScreenshake() { }

	// RVA: 0x6DC370 Offset: 0x6DB570 VA: 0x1806DC370
	public void ToggleVSync() { }

	// RVA: 0x6DC270 Offset: 0x6DB470 VA: 0x1806DC270
	public void ToggleFullscreen() { }

	// RVA: 0x6DBFF0 Offset: 0x6DB1F0 VA: 0x1806DBFF0
	public void OnResChange() { }

	// RVA: 0x6DC230 Offset: 0x6DB430 VA: 0x1806DC230
	public void SaveChange() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6DC480 Offset: 0x6DB680 VA: 0x1806DC480
	private bool <OnEnable>b__9_1(Resolution e) { }
}

// Namespace: 
public class RoleOptionSetting : OptionBehaviour // TypeDefIndex: 1708
{
	// Fields
	[SerializeField]
	private TextMeshPro titleText; // 0x50
	[SerializeField]
	private TextMeshPro countText; // 0x58
	[SerializeField]
	private TextMeshPro chanceText; // 0x60
	[SerializeField]
	private SpriteRenderer labelSprite; // 0x68
	[SerializeField]
	private List<PassiveButton> controllerSelectable; // 0x70
	[SerializeField]
	private GameOptionButton CountPlusBtn; // 0x78
	[SerializeField]
	private GameOptionButton CountMinusBtn; // 0x80
	[SerializeField]
	private GameOptionButton ChancePlusBtn; // 0x88
	[SerializeField]
	private GameOptionButton ChanceMinusBtn; // 0x90
	private RoleBehaviour role; // 0x98
	private int roleMaxCount; // 0xA0
	private int roleChance; // 0xA4

	// Properties
	public int RoleMaxCount { get; }
	public int RoleChance { get; }
	public RoleBehaviour Role { get; }
	public List<PassiveButton> ControllerSelectable { get; }
	private int RoleMax { get; }

	// Methods

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	public int get_RoleMaxCount() { }

	// RVA: 0x6DCF10 Offset: 0x6DC110 VA: 0x1806DCF10
	public int get_RoleChance() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public RoleBehaviour get_Role() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public List<PassiveButton> get_ControllerSelectable() { }

	// RVA: 0x6DCF20 Offset: 0x6DC120 VA: 0x1806DCF20
	private int get_RoleMax() { }

	// RVA: 0x6DC940 Offset: 0x6DBB40 VA: 0x1806DC940
	public void SetRole(IRoleOptionsCollection options, RoleBehaviour role, int maskLayer) { }

	// RVA: 0x6DCDF0 Offset: 0x6DBFF0 VA: 0x1806DCDF0
	public void UpdateValuesAndText(IRoleOptionsCollection options) { }

	// RVA: 0x6DC860 Offset: 0x6DBA60 VA: 0x1806DC860
	public void IncreaseCount() { }

	// RVA: 0x6DC6B0 Offset: 0x6DB8B0 VA: 0x1806DC6B0
	public void DecreaseCount() { }

	// RVA: 0x6DC770 Offset: 0x6DB970 VA: 0x1806DC770
	public void IncreaseChance() { }

	// RVA: 0x6DC610 Offset: 0x6DB810 VA: 0x1806DC610
	public void DecreaseChance() { }

	// RVA: 0x6DC570 Offset: 0x6DB770 VA: 0x1806DC570
	private void AdjustCountButtonsActiveState() { }

	// RVA: 0x6DC4F0 Offset: 0x6DB6F0 VA: 0x1806DC4F0
	private void AdjustChanceButtonsActiveState() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SettingsLanguageMenu : MonoBehaviour // TypeDefIndex: 1709
{
	// Fields
	public TextMeshPro selectedLangText; // 0x20

	// Methods

	// RVA: 0x6DCF60 Offset: 0x6DC160 VA: 0x1806DCF60
	public void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public abstract class GameOptionsDefinition // TypeDefIndex: 1710
{
	// Properties
	public abstract byte Version { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Version();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IGameOptionsMigrator GetMigrator(ILogger logger);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
public class StringOption : OptionBehaviour // TypeDefIndex: 1711
{
	// Fields
	public TextMeshPro TitleText; // 0x50
	public TextMeshPro ValueText; // 0x58
	public StringNames[] Values; // 0x60
	public int Value; // 0x68
	private int oldValue; // 0x6C
	private Int32OptionNames stringOptionName; // 0x70
	[SerializeField]
	private GameOptionButton PlusBtn; // 0x78
	[SerializeField]
	private GameOptionButton MinusBtn; // 0x80

	// Methods

	// RVA: 0x6DE1B0 Offset: 0x6DD3B0 VA: 0x1806DE1B0 Slot: 7
	public override void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	private void Start() { }

	// RVA: 0x6DE000 Offset: 0x6DD200 VA: 0x1806DE000 Slot: 8
	public override void Initialize() { }

	// RVA: 0x6DDEB0 Offset: 0x6DD0B0 VA: 0x1806DDEB0
	private void FixedUpdate() { }

	// RVA: 0x6DDF90 Offset: 0x6DD190 VA: 0x1806DDF90
	public void Increase() { }

	// RVA: 0x6DDE40 Offset: 0x6DD040 VA: 0x1806DDE40
	public void Decrease() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80 Slot: 5
	public override int GetInt() { }

	// RVA: 0x6DE2A0 Offset: 0x6DD4A0 VA: 0x1806DE2A0
	private void UpdateValue() { }

	// RVA: 0x6DDDB0 Offset: 0x6DCFB0 VA: 0x1806DDDB0
	private void AdjustButtonsActiveState() { }

	// RVA: 0x6DE3F0 Offset: 0x6DD5F0 VA: 0x1806DE3F0
	public void .ctor() { }
}

// Namespace: 
public class ToggleOption : OptionBehaviour // TypeDefIndex: 1712
{
	// Fields
	public TextMeshPro TitleText; // 0x50
	public SpriteRenderer CheckMark; // 0x58
	private bool oldValue; // 0x60
	private BoolOptionNames boolOptionName; // 0x64

	// Methods

	// RVA: 0x6DE5C0 Offset: 0x6DD7C0 VA: 0x1806DE5C0 Slot: 7
	public override void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	private void Start() { }

	// RVA: 0x6DE470 Offset: 0x6DD670 VA: 0x1806DE470 Slot: 8
	public override void Initialize() { }

	// RVA: 0x6DE400 Offset: 0x6DD600 VA: 0x1806DE400
	private void FixedUpdate() { }

	// RVA: 0x6DE6A0 Offset: 0x6DD8A0 VA: 0x1806DE6A0
	public void Toggle() { }

	// RVA: 0x6DE450 Offset: 0x6DD650 VA: 0x1806DE450 Slot: 6
	public override bool GetBool() { }

	// RVA: 0x6DE710 Offset: 0x6DD910 VA: 0x1806DE710
	private void UpdateValue() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShadowCollab.<Run>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1713
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ShadowCollab <>4__this; // 0x20
	private Camera <cam>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6E0D10 Offset: 0x6DFF10 VA: 0x1806E0D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6E0F10 Offset: 0x6E0110 VA: 0x1806E0F10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ShadowCollab : MonoBehaviour // TypeDefIndex: 1714
{
	// Fields
	public Camera ShadowCamera; // 0x20
	public MeshRenderer ShadowQuad; // 0x28
	private float oldAspect; // 0x30

	// Methods

	// RVA: 0x6DD100 Offset: 0x6DC300 VA: 0x1806DD100
	public void OnEnable() { }

	[IteratorStateMachine(typeof(ShadowCollab.<Run>d__4))]
	// RVA: 0x6DD170 Offset: 0x6DC370 VA: 0x1806DD170
	private IEnumerator Run() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class LightAffector : MonoBehaviour // TypeDefIndex: 1715
{
	// Fields
	public float Multiplier; // 0x20
	public Collider2D Hitbox; // 0x28

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class LightSource : MonoBehaviour // TypeDefIndex: 1716
{
	// Fields
	public const string FLASHLIGHT_KEYWORD = "FLASHLIGHT";
	private const float FLASHLIGHT_LERP_SPEED = 5;
	private const float FLASHLIGHT_LERP_SPEED_CONSOLE = 10;
	private const float DEFAULT_PLAYER_RADIUS = 0,5;
	public static Dictionary<GameObject, NoShadowBehaviour> NoShadows; // 0x0
	public static Dictionary<GameObject, OneWayShadows> OneWayShadows; // 0x8
	[SerializeField]
	private float viewDistance; // 0x20
	[SerializeField]
	private Material lightCutawayMaterial; // 0x28
	[SerializeField]
	private Mesh lightChildMesh; // 0x30
	[SerializeField]
	[Space(10)]
	private LightSourceRendererType rendererType; // 0x38
	[SerializeField]
	private bool useFlashlight; // 0x3C
	[SerializeField]
	[Header("GPU Settings")]
	private Material gpuShadowCasterMaterial; // 0x40
	[SerializeField]
	private int gpuShadowmapResolution; // 0x48
	[SerializeField]
	private RenderTextureFormat gpuPreferredRTFormat; // 0x4C
	[Header("Raycast Settings")]
	[SerializeField]
	private int raycastMinRayCount; // 0x50
	[SerializeField]
	private float raycastTolerance; // 0x54
	private LightSourceRenderer renderer; // 0x58
	private GameObject lightChild; // 0x60
	private MeshFilter lightChildMeshFilter; // 0x68
	private Controller controller; // 0x70
	private float flashlightSize; // 0x78
	private Vector2 lastFlashlightDirection; // 0x7C
	private Vector3 lightOffset; // 0x84
	private Transform touchFlashlightTarget; // 0x90

	// Properties
	public float ViewDistance { get; }
	public float PlayerRadius { get; }
	public Material LightCutawayMaterial { get; }
	public GameObject LightChild { get; }
	public Mesh LightChildMesh { get; }
	public MeshFilter LightChildMeshFilter { get; }
	public Vector3 LightOffset { get; }
	public float FlashlightSize { get; }
	public Material GpuShadowCasterMaterial { get; }
	public int GpuShadowmapResolution { get; }
	public RenderTextureFormat GpuPreferredRTFormat { get; }
	public int RaycastMinimumRayCount { get; }
	public float RaycastTolerance { get; }

	// Methods

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_ViewDistance() { }

	// RVA: 0x646070 Offset: 0x645270 VA: 0x180646070
	public float get_PlayerRadius() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Material get_LightCutawayMaterial() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public GameObject get_LightChild() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Mesh get_LightChildMesh() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public MeshFilter get_LightChildMeshFilter() { }

	// RVA: 0x6D7270 Offset: 0x6D6470 VA: 0x1806D7270
	public Vector3 get_LightOffset() { }

	// RVA: 0x6D59A0 Offset: 0x6D4BA0 VA: 0x1806D59A0
	public float get_FlashlightSize() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Material get_GpuShadowCasterMaterial() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public int get_GpuShadowmapResolution() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public RenderTextureFormat get_GpuPreferredRTFormat() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int get_RaycastMinimumRayCount() { }

	// RVA: 0x6D7290 Offset: 0x6D6490 VA: 0x1806D7290
	public float get_RaycastTolerance() { }

	// RVA: 0x6D5860 Offset: 0x6D4A60 VA: 0x1806D5860
	private void Awake() { }

	// RVA: 0x6D6DB0 Offset: 0x6D5FB0 VA: 0x1806D6DB0
	private void Update() { }

	// RVA: 0x6D68E0 Offset: 0x6D5AE0 VA: 0x1806D68E0
	public void Initialize(Vector3 lightOffset) { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void SetViewDistance(float distance) { }

	// RVA: 0x6D6B00 Offset: 0x6D5D00 VA: 0x1806D6B00
	public void SetupLightingForGameplay(bool enableFlashlight, float flashlightSize, Transform touchFlashlightTarget) { }

	// RVA: 0x6D59A0 Offset: 0x6D4BA0 VA: 0x1806D59A0
	private float CalculateFlashlightSize() { }

	// RVA: 0x6D6A90 Offset: 0x6D5C90 VA: 0x1806D6A90
	private void SetFlashlightEnabled(bool enabled) { }

	// RVA: 0x6D6C80 Offset: 0x6D5E80 VA: 0x1806D6C80
	private void UpdateShadowType() { }

	// RVA: 0x6D6B90 Offset: 0x6D5D90 VA: 0x1806D6B90
	private void UpdateFlashlightAngle() { }

	// RVA: 0x6D5E00 Offset: 0x6D5000 VA: 0x1806D5E00
	private float GetFlashlightAngle() { }

	// RVA: 0x6D6730 Offset: 0x6D5930 VA: 0x1806D6730
	private float GetVirtualJFAngle() { }

	// RVA: 0x6D61E0 Offset: 0x6D53E0 VA: 0x1806D61E0
	private float GetKeyboardMouseFAngle() { }

	// RVA: 0x6D5BF0 Offset: 0x6D4DF0 VA: 0x1806D5BF0
	private float GetControllerFAngle() { }

	// RVA: 0x6D62C0 Offset: 0x6D54C0 VA: 0x1806D62C0
	private float GetScreenFAngle() { }

	// RVA: 0x6D59E0 Offset: 0x6D4BE0 VA: 0x1806D59E0
	private float GetAngleDot() { }

	// RVA: 0x6D5AC0 Offset: 0x6D4CC0 VA: 0x1806D5AC0
	private float GetAngleMove() { }

	// RVA: 0x6D71E0 Offset: 0x6D63E0 VA: 0x1806D71E0
	public void .ctor() { }

	// RVA: 0x6D7120 Offset: 0x6D6320 VA: 0x1806D7120
	private static void .cctor() { }
}

// Namespace: 
public sealed class LightSourceGpuRenderer.AddEdgeDelegate : MulticastDelegate // TypeDefIndex: 1717
{
	// Methods

	// RVA: 0x6CAB00 Offset: 0x6C9D00 VA: 0x1806CAB00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CAAB0 Offset: 0x6C9CB0 VA: 0x1806CAAB0 Slot: 13
	public virtual void Invoke(Vector3 a, Vector3 b) { }

	// RVA: 0x6CAA10 Offset: 0x6C9C10 VA: 0x1806CAA10 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vector3 a, Vector3 b, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class LightSourceGpuRenderer : LightSourceRenderer // TypeDefIndex: 1718
{
	// Fields
	private const float TWO_PI = 6,2831855;
	private Mesh occluderMesh; // 0x18
	private List<Vector3> occVerts; // 0x20
	private List<Vector3> occNorms; // 0x28
	private List<Vector2> occUVs; // 0x30
	private List<int> occTris; // 0x38
	private Collider2D[] hits; // 0x40
	private Material shadowCasterMaterial; // 0x48
	private CommandBuffer cb; // 0x50
	private bool noGeomSupport; // 0x58
	private RenderTexture shadowTexture; // 0x60
	private LightSourceGpuRenderer.AddEdgeDelegate AddEdge; // 0x68

	// Properties
	public override LightSourceRendererType Type { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	public override LightSourceRendererType get_Type() { }

	// RVA: 0x6D37E0 Offset: 0x6D29E0 VA: 0x1806D37E0
	public void .ctor(LightSource lightSource) { }

	// RVA: 0x6D3200 Offset: 0x6D2400 VA: 0x1806D3200 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6D3720 Offset: 0x6D2920 VA: 0x1806D3720 Slot: 7
	public override void Render(Vector2 origin) { }

	// RVA: 0x6D1D60 Offset: 0x6D0F60 VA: 0x1806D1D60 Slot: 8
	public override void Dispose() { }

	// RVA: 0x6D30A0 Offset: 0x6D22A0 VA: 0x1806D30A0
	private void GenerateShadowmap() { }

	// RVA: 0x6D2200 Offset: 0x6D1400 VA: 0x1806D2200
	private void GPUShadows(Vector2 origin) { }

	// RVA: 0x6D1A80 Offset: 0x6D0C80 VA: 0x1806D1A80
	private void ClearEdges() { }

	// RVA: 0x6D3730 Offset: 0x6D2930 VA: 0x1806D3730
	private void UpdateOccMesh() { }

	// RVA: 0x6D1DE0 Offset: 0x6D0FE0 VA: 0x1806D1DE0
	private void DrawOcclusion(float effectiveRadius) { }

	// RVA: 0x6D1B20 Offset: 0x6D0D20 VA: 0x1806D1B20
	private void DebugDrawRadius(Vector2 center, float radius) { }

	// RVA: 0x6D1840 Offset: 0x6D0A40 VA: 0x1806D1840
	private void AddEdgeNoGeom(Vector3 a, Vector3 b) { }

	// RVA: 0x6D0E10 Offset: 0x6D0010 VA: 0x1806D0E10
	private void AddEdgeInternal(Vector3 a, Vector3 b, Vector2 uv) { }

	// RVA: 0x6D0490 Offset: 0x6CF690 VA: 0x1806D0490
	private void AddEdgeDefault(Vector3 a, Vector3 b) { }
}

// Namespace: 
private class LightSourceRaycastRenderer.VertInfo // TypeDefIndex: 1719
{
	// Fields
	public float Angle; // 0x10
	public Vector3 Position; // 0x14

	// Methods

	// RVA: 0x6E11C0 Offset: 0x6E03C0 VA: 0x1806E11C0
	internal void Complete(float x, float y) { }

	// RVA: 0x6E1220 Offset: 0x6E0420 VA: 0x1806E1220
	internal void Complete(Vector2 point) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class LightSourceRaycastRenderer.AngleComparer : IComparer<LightSourceRaycastRenderer.VertInfo> // TypeDefIndex: 1720
{
	// Fields
	public static readonly LightSourceRaycastRenderer.AngleComparer Instance; // 0x0

	// Methods

	// RVA: 0x6CABA0 Offset: 0x6C9DA0 VA: 0x1806CABA0 Slot: 4
	public int Compare(LightSourceRaycastRenderer.VertInfo x, LightSourceRaycastRenderer.VertInfo y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6CABE0 Offset: 0x6C9DE0 VA: 0x1806CABE0
	private static void .cctor() { }
}

// Namespace: 
private class LightSourceRaycastRenderer.HitDepthComparer : IComparer<RaycastHit2D> // TypeDefIndex: 1721
{
	// Fields
	public static readonly LightSourceRaycastRenderer.HitDepthComparer Instance; // 0x0

	// Methods

	// RVA: 0x6CF8F0 Offset: 0x6CEAF0 VA: 0x1806CF8F0 Slot: 4
	public int Compare(RaycastHit2D x, RaycastHit2D y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6CF930 Offset: 0x6CEB30 VA: 0x1806CF930
	private static void .cctor() { }
}

// Namespace: 
public class LightSourceRaycastRenderer : LightSourceRenderer // TypeDefIndex: 1722
{
	// Fields
	private Camera camera; // 0x18
	private List<LightSourceRaycastRenderer.VertInfo> verts; // 0x20
	private int vertCount; // 0x28
	private Vector3[] vec; // 0x30
	private Vector2[] uvs; // 0x38
	private int[] triangles; // 0x40
	private RaycastHit2D[] buffer; // 0x48
	private ContactFilter2D filter; // 0x50
	private Collider2D[] hits; // 0x70
	private Vector2[] requiredDels; // 0x78
	private Mesh myMesh; // 0x80
	private Vector2 del; // 0x88
	private Vector2 tan; // 0x90
	private Vector2 side; // 0x98
	private List<RaycastHit2D> lightHits; // 0xA0

	// Properties
	public override LightSourceRendererType Type { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override LightSourceRendererType get_Type() { }

	// RVA: 0x6D5120 Offset: 0x6D4320 VA: 0x1806D5120
	public void .ctor(LightSource lightSource) { }

	// RVA: 0x6D40F0 Offset: 0x6D32F0 VA: 0x1806D40F0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6D4FE0 Offset: 0x6D41E0 VA: 0x1806D4FE0 Slot: 7
	public override void Render(Vector2 origin) { }

	// RVA: 0x6D3EC0 Offset: 0x6D30C0 VA: 0x1806D3EC0 Slot: 8
	public override void Dispose() { }

	// RVA: 0x6D4030 Offset: 0x6D3230 VA: 0x1806D4030
	private float GetValidViewDistance() { }

	// RVA: 0x6D43F0 Offset: 0x6D35F0 VA: 0x1806D43F0
	private void RaycastShadows(Vector2 origin) { }

	// RVA: 0x6D4FF0 Offset: 0x6D41F0 VA: 0x1806D4FF0
	private void TestBothSides(Vector2 origin) { }

	// RVA: 0x6D3930 Offset: 0x6D2B30 VA: 0x1806D3930
	private void CreateVert(Vector2 origin, ref Vector2 del) { }

	// RVA: 0x6D3F00 Offset: 0x6D3100 VA: 0x1806D3F00
	private LightSourceRaycastRenderer.VertInfo GetEmptyVert() { }

	// RVA: 0x6D5250 Offset: 0x6D4450 VA: 0x1806D5250
	private static float length(float x, float y) { }

	// RVA: 0x6D4390 Offset: 0x6D3590 VA: 0x1806D4390
	public static float PseudoAngle(float dx, float dy) { }
}

// Namespace: 
public enum LightSourceRendererType // TypeDefIndex: 1723
{
	// Fields
	public int value__; // 0x0
	public const LightSourceRendererType Auto = 0;
	public const LightSourceRendererType Raycast = 1;
	public const LightSourceRendererType GPU = 2;
}

// Namespace: 
public abstract class LightSourceRenderer : IDisposable // TypeDefIndex: 1724
{
	// Fields
	protected readonly LightSource lightSource; // 0x10

	// Properties
	public abstract LightSourceRendererType Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract LightSourceRendererType get_Type();

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(LightSource lightSource) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Render(Vector2 origin);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Dispose();

	// RVA: 0x6D5270 Offset: 0x6D4470 VA: 0x1806D5270
	public static LightSourceRenderer Create(LightSourceRendererType type, LightSource lightSource) { }

	// RVA: 0x6D5810 Offset: 0x6D4A10 VA: 0x1806D5810
	public static LightSourceRendererType GetPlatformType() { }
}

// Namespace: 
public class OneWayShadows : MonoBehaviour // TypeDefIndex: 1725
{
	// Fields
	public Collider2D RoomCollider; // 0x20
	public bool IgnoreImpostor; // 0x28

	// Methods

	// RVA: 0x6D8A90 Offset: 0x6D7C90 VA: 0x1806D8A90
	public void OnEnable() { }

	// RVA: 0x6D8A00 Offset: 0x6D7C00 VA: 0x1806D8A00
	public void OnDisable() { }

	// RVA: 0x6D8910 Offset: 0x6D7B10 VA: 0x1806D8910
	public bool IsIgnored(LightSource lightSource) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ShadowCamera : MonoBehaviour // TypeDefIndex: 1726
{
	// Fields
	public Shader Shadozer; // 0x20

	// Methods

	// RVA: 0x6DD090 Offset: 0x6DC290 VA: 0x1806DD090
	public void OnEnable() { }

	// RVA: 0x6DD040 Offset: 0x6DC240 VA: 0x1806DD040
	public void OnDisable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ShapeshifterEvidence : MonoBehaviour // TypeDefIndex: 1727
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ShieldMinigame : Minigame // TypeDefIndex: 1728
{
	// Fields
	public Color OnColor; // 0x88
	public Color OffColor; // 0x98
	public SpriteRenderer[] Shields; // 0xA8
	public SpriteRenderer Gauge; // 0xB0
	private byte shields; // 0xB8
	public AudioClip ShieldOnSound; // 0xC0
	public AudioClip ShieldOffSound; // 0xC8
	public Transform selectedButtonHighlight; // 0xD0
	private Controller controller; // 0xD8
	private int oldSelectedIndex; // 0xE0

	// Methods

	// RVA: 0x6DD1D0 Offset: 0x6DC3D0 VA: 0x1806DD1D0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6DD240 Offset: 0x6DC440 VA: 0x1806DD240
	public void ToggleShield(int i) { }

	// RVA: 0x6DD670 Offset: 0x6DC870 VA: 0x1806DD670
	private void Update() { }

	// RVA: 0x6DD230 Offset: 0x6DC430 VA: 0x1806DD230
	public void FixedUpdate() { }

	// RVA: 0x6DD4B0 Offset: 0x6DC6B0 VA: 0x1806DD4B0
	private void UpdateButtons() { }

	// RVA: 0x6DDBB0 Offset: 0x6DCDB0 VA: 0x1806DDBB0
	public void .ctor() { }
}

// Namespace: 
public class AutoTaskConsole : Console // TypeDefIndex: 1729
{
	// Fields
	public AudioClip useSound; // 0x48

	// Methods

	// RVA: 0x6CB8F0 Offset: 0x6CAAF0 VA: 0x1806CB8F0
	private PlayerTask FindTask(PlayerControl pc) { }

	// RVA: 0x6CB9D0 Offset: 0x6CABD0 VA: 0x1806CB9D0 Slot: 10
	public override void Use() { }

	// RVA: 0x6CB790 Offset: 0x6CA990 VA: 0x1806CB790 Slot: 11
	protected virtual void AfterUse(NormalPlayerTask task) { }

	// RVA: 0x6CBC70 Offset: 0x6CAE70 VA: 0x1806CBC70
	public void .ctor() { }
}

// Namespace: 
public class ChainBehaviour : MonoBehaviour // TypeDefIndex: 1730
{
	// Fields
	public FloatRange SwingRange; // 0x20
	public float SwingPeriod; // 0x28
	public float swingTime; // 0x2C
	private Vector3 vec; // 0x30

	// Methods

	// RVA: 0x6CBC80 Offset: 0x6CAE80 VA: 0x1806CBC80
	public void Awake() { }

	// RVA: 0x6CBD00 Offset: 0x6CAF00 VA: 0x1806CBD00
	public void Update() { }

	// RVA: 0x6CBDB0 Offset: 0x6CAFB0 VA: 0x1806CBDB0
	public void .ctor() { }
}

// Namespace: 
public class Console : MonoBehaviour, IUsable // TypeDefIndex: 1731
{
	// Fields
	public float usableDistance; // 0x20
	public int ConsoleId; // 0x24
	public bool onlyFromBelow; // 0x28
	public bool onlySameRoom; // 0x29
	public bool checkWalls; // 0x2A
	public bool GhostsIgnored; // 0x2B
	public bool AllowImpostor; // 0x2C
	public SystemTypes Room; // 0x2D
	public TaskTypes[] TaskTypes; // 0x30
	public TaskSet[] ValidTasks; // 0x38
	public SpriteRenderer Image; // 0x40

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x6CC3D0 Offset: 0x6CB5D0 VA: 0x1806CC3D0 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6CBE20 Offset: 0x6CB020 VA: 0x1806CBE20 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6CC220 Offset: 0x6CB420 VA: 0x1806CC220
	private bool InRoom(Vector2 truePos) { }

	// RVA: 0x6CC140 Offset: 0x6CB340 VA: 0x1806CC140
	private PlayerTask FindTask(PlayerControl pc) { }

	// RVA: 0x6CC530 Offset: 0x6CB730 VA: 0x1806CC530 Slot: 10
	public virtual void Use() { }

	// RVA: 0x6CC330 Offset: 0x6CB530 VA: 0x1806CC330
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6CBC70 Offset: 0x6CAE70 VA: 0x1806CBC70
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CosmeticsCache.<>c // TypeDefIndex: 1732
{
	// Fields
	public static readonly CosmeticsCache.<>c <>9; // 0x0
	public static Predicate<string> <>9__7_0; // 0x8
	public static Predicate<string> <>9__7_1; // 0x10
	public static Predicate<string> <>9__7_2; // 0x18
	public static Predicate<string> <>9__7_3; // 0x20
	public static Predicate<string> <>9__7_4; // 0x28

	// Methods

	// RVA: 0x6E1040 Offset: 0x6E0240 VA: 0x1806E1040
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E0FA0 Offset: 0x6E01A0 VA: 0x1806E0FA0
	internal bool <PopulateFromPlayers>b__7_0(string x) { }

	// RVA: 0x6E0FA0 Offset: 0x6E01A0 VA: 0x1806E0FA0
	internal bool <PopulateFromPlayers>b__7_1(string x) { }

	// RVA: 0x6E0FA0 Offset: 0x6E01A0 VA: 0x1806E0FA0
	internal bool <PopulateFromPlayers>b__7_2(string x) { }

	// RVA: 0x6E0FA0 Offset: 0x6E01A0 VA: 0x1806E0FA0
	internal bool <PopulateFromPlayers>b__7_3(string x) { }

	// RVA: 0x6E0FA0 Offset: 0x6E01A0 VA: 0x1806E0FA0
	internal bool <PopulateFromPlayers>b__7_4(string x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoAddHat>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1733
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public string id; // 0x28
	private AddressableAsset<HatViewData> <asset>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DE8C0 Offset: 0x6DDAC0 VA: 0x1806DE8C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DEA60 Offset: 0x6DDC60 VA: 0x1806DEA60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoAddNameplate>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1734
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public string namePlateId; // 0x28
	private AddressableAsset<NamePlateViewData> <asset>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DEAA0 Offset: 0x6DDCA0 VA: 0x1806DEAA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DEC40 Offset: 0x6DDE40 VA: 0x1806DEC40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoAddPet>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1735
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public string petId; // 0x28
	private AddressableAsset<PetBehaviour> <asset>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DEC80 Offset: 0x6DDE80 VA: 0x1806DEC80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DEE20 Offset: 0x6DE020 VA: 0x1806DEE20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoAddSkin>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1736
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public string id; // 0x28
	private AddressableAsset<SkinViewData> <asset>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DEE60 Offset: 0x6DE060 VA: 0x1806DEE60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DF000 Offset: 0x6DE200 VA: 0x1806DF000 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoAddVisor>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1737
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public string visorId; // 0x28
	private AddressableAsset<VisorViewData> <asset>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DF040 Offset: 0x6DE240 VA: 0x1806DF040 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DF1E0 Offset: 0x6DE3E0 VA: 0x1806DF1E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<CoPopulateFromOutfit>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1738
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	public NetworkedPlayerInfo.PlayerOutfit outfit; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DF6C0 Offset: 0x6DE8C0 VA: 0x1806DF6C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DF840 Offset: 0x6DEA40 VA: 0x1806DF840 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CosmeticsCache.<PopulateFromPlayers>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1739
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CosmeticsCache <>4__this; // 0x20
	private HashSet<string> <skinIds>5__2; // 0x28
	private HashSet<string> <visorIds>5__3; // 0x30
	private HashSet<string> <namePlateIds>5__4; // 0x38
	private HashSet<string> <petIds>5__5; // 0x40
	private HashSet.Enumerator<string> <>7__wrap5; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x6E08F0 Offset: 0x6DFAF0 VA: 0x1806E08F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DF880 Offset: 0x6DEA80 VA: 0x1806DF880 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x6E0B80 Offset: 0x6DFD80 VA: 0x1806E0B80
	private void <>m__Finally1() { }

	// RVA: 0x6E0BD0 Offset: 0x6DFDD0 VA: 0x1806E0BD0
	private void <>m__Finally2() { }

	// RVA: 0x6E0C20 Offset: 0x6DFE20 VA: 0x1806E0C20
	private void <>m__Finally3() { }

	// RVA: 0x6E0C70 Offset: 0x6DFE70 VA: 0x1806E0C70
	private void <>m__Finally4() { }

	// RVA: 0x6E0CC0 Offset: 0x6DFEC0 VA: 0x1806E0CC0
	private void <>m__Finally5() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6E08B0 Offset: 0x6DFAB0 VA: 0x1806E08B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CosmeticsCache // TypeDefIndex: 1740
{
	// Fields
	private readonly AddressableAssetGroup allCachedAssets; // 0x10
	private Dictionary<string, AddressableAsset<HatViewData>> hats; // 0x18
	public bool initialized; // 0x20
	private Dictionary<string, AddressableAsset<NamePlateViewData>> nameplates; // 0x28
	private Dictionary<string, AddressableAsset<PetBehaviour>> pets; // 0x30
	private Dictionary<string, AddressableAsset<SkinViewData>> skins; // 0x38
	private Dictionary<string, AddressableAsset<VisorViewData>> visors; // 0x40

	// Methods

	[IteratorStateMachine(typeof(CosmeticsCache.<PopulateFromPlayers>d__7))]
	// RVA: 0x6CD860 Offset: 0x6CCA60 VA: 0x1806CD860
	public IEnumerator PopulateFromPlayers() { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoAddNameplate>d__8))]
	// RVA: 0x6CCF10 Offset: 0x6CC110 VA: 0x1806CCF10
	public IEnumerator CoAddNameplate(string namePlateId) { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoAddPet>d__9))]
	// RVA: 0x6CCF80 Offset: 0x6CC180 VA: 0x1806CCF80
	public IEnumerator CoAddPet(string petId) { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoAddVisor>d__10))]
	// RVA: 0x6CD060 Offset: 0x6CC260 VA: 0x1806CD060
	public IEnumerator CoAddVisor(string visorId) { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoAddSkin>d__11))]
	// RVA: 0x6CCFF0 Offset: 0x6CC1F0 VA: 0x1806CCFF0
	public IEnumerator CoAddSkin(string id) { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoAddHat>d__12))]
	// RVA: 0x6CCEA0 Offset: 0x6CC0A0 VA: 0x1806CCEA0
	public IEnumerator CoAddHat(string id) { }

	// RVA: 0x6CD590 Offset: 0x6CC790 VA: 0x1806CD590
	public SkinViewData GetSkin(string id) { }

	// RVA: 0x6CD230 Offset: 0x6CC430 VA: 0x1806CD230
	public HatViewData GetHat(string id) { }

	// RVA: 0x6CD470 Offset: 0x6CC670 VA: 0x1806CD470
	public PetBehaviour GetPet(string id) { }

	// RVA: 0x6CD7D0 Offset: 0x6CC9D0 VA: 0x1806CD7D0
	public bool HasVisor(string id) { }

	// RVA: 0x6CD6B0 Offset: 0x6CC8B0 VA: 0x1806CD6B0
	public VisorViewData GetVisor(string id) { }

	// RVA: 0x6CD350 Offset: 0x6CC550 VA: 0x1806CD350
	public NamePlateViewData GetNameplate(string id) { }

	// RVA: 0x6CD140 Offset: 0x6CC340 VA: 0x1806CD140
	public void Destroy() { }

	[IteratorStateMachine(typeof(CosmeticsCache.<CoPopulateFromOutfit>d__20))]
	// RVA: 0x6CD0D0 Offset: 0x6CC2D0 VA: 0x1806CD0D0
	public IEnumerator CoPopulateFromOutfit(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	// RVA: 0x6CC8A0 Offset: 0x6CBAA0 VA: 0x1806CC8A0
	public static void ClearUnusedCosmetics() { }

	// RVA: 0x6CD8C0 Offset: 0x6CCAC0 VA: 0x1806CD8C0
	public void .ctor() { }
}

// Namespace: 
public class CounterArea : MonoBehaviour // TypeDefIndex: 1741
{
	// Fields
	public SystemTypes RoomType; // 0x20
	public ObjectPoolBehavior pool; // 0x28
	private List<PoolableBehavior> myIcons; // 0x30
	public float XOffset; // 0x38
	public float YOffset; // 0x3C
	public int MaxWidth; // 0x40
	public int MaxColumns; // 0x44
	public bool DetectiveExclusiveLocation; // 0x48

	// Methods

	// RVA: 0x6CD920 Offset: 0x6CCB20 VA: 0x1806CD920
	public void UpdateCount(int cnt) { }

	// RVA: 0x6CDC90 Offset: 0x6CCE90 VA: 0x1806CDC90
	public void .ctor() { }
}

// Namespace: 
public interface IDoorMinigame // TypeDefIndex: 1742
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetDoor(OpenableDoor door);
}

// Namespace: 
public class DoorConsole : MonoBehaviour, IUsable // TypeDefIndex: 1743
{
	// Fields
	public Minigame MinigamePrefab; // 0x20
	private OpenableDoor MyDoor; // 0x28
	private SpriteRenderer Image; // 0x30

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x56EDD0 Offset: 0x56DFD0 VA: 0x18056EDD0 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x6CDD20 Offset: 0x6CCF20 VA: 0x1806CDD20
	public void Awake() { }

	// RVA: 0x6CDD80 Offset: 0x6CCF80 VA: 0x1806CDD80 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6CDEA0 Offset: 0x6CD0A0 VA: 0x1806CDEA0 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6CE000 Offset: 0x6CD200 VA: 0x1806CE000 Slot: 9
	public void Use() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class AutoCloseDoor : PlainDoor // TypeDefIndex: 1744
{
	// Fields
	private const float OpenDuration = 10;
	private float OpenTime; // 0x70

	// Methods

	// RVA: 0x6CAD00 Offset: 0x6C9F00 VA: 0x1806CAD00 Slot: 4
	public override void SetDoorway(bool open) { }

	// RVA: 0x6CAC40 Offset: 0x6C9E40 VA: 0x1806CAC40 Slot: 8
	public override bool DoUpdate(float dt) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AutoDoorsSystemType.<>c // TypeDefIndex: 1745
{
	// Fields
	public static readonly AutoDoorsSystemType.<>c <>9; // 0x0
	public static Func<OpenableDoor, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x6E1160 Offset: 0x6E0360 VA: 0x1806E1160
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E0FB0 Offset: 0x6E01B0 VA: 0x1806E0FB0
	internal bool <get_IsActive>b__3_0(OpenableDoor b) { }
}

// Namespace: 
public class AutoDoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem // TypeDefIndex: 1746
{
	// Fields
	private uint dirtyBits; // 0x10
	private float initialCooldown; // 0x14

	// Properties
	public bool IsActive { get; }
	public bool IsDirty { get; }

	// Methods

	// RVA: 0x6CB540 Offset: 0x6CA740 VA: 0x1806CB540 Slot: 10
	public bool get_IsActive() { }

	// RVA: 0x6CB670 Offset: 0x6CA870 VA: 0x1806CB670 Slot: 4
	public bool get_IsDirty() { }

	// RVA: 0x6CB000 Offset: 0x6CA200 VA: 0x1806CB000 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6CB260 Offset: 0x6CA460 VA: 0x1806CB260 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6CB270 Offset: 0x6CA470 VA: 0x1806CB270 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6CAE30 Offset: 0x6CA030 VA: 0x1806CAE30 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x6CB450 Offset: 0x6CA650 VA: 0x1806CB450
	public void SetDoor(AutoOpenDoor door, bool open) { }

	// RVA: 0x6CAD20 Offset: 0x6C9F20 VA: 0x1806CAD20 Slot: 12
	public void CloseDoorsOfType(SystemTypes room) { }

	// RVA: 0x6CB140 Offset: 0x6CA340 VA: 0x1806CB140 Slot: 11
	public float GetTimer(SystemTypes room) { }

	// RVA: 0x6CB530 Offset: 0x6CA730 VA: 0x1806CB530 Slot: 13
	public void SetInitialSabotageCooldown() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class AutoOpenDoor : PlainDoor // TypeDefIndex: 1747
{
	// Fields
	public const float CooldownDuration = 30;
	private const float ClosedDuration = 10;
	public float ClosedTimer; // 0x70
	public float CooldownTimer; // 0x74

	// Methods

	// RVA: 0x6CB770 Offset: 0x6CA970 VA: 0x1806CB770 Slot: 4
	public override void SetDoorway(bool open) { }

	// RVA: 0x6CB680 Offset: 0x6CA880 VA: 0x1806CB680 Slot: 8
	public override bool DoUpdate(float dt) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public interface IDoorSystem // TypeDefIndex: 1748
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseDoorsOfType(SystemTypes room);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetInitialSabotageCooldown();
}

// Namespace: 
[CompilerGenerated]
private sealed class DoorsSystemType.<>c__DisplayClass13_0 // TypeDefIndex: 1749
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F60 Offset: 0x698160 VA: 0x180698F60
	internal bool <UpdateSystem>b__0(OpenableDoor d) { }
}

// Namespace: 
public class DoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem // TypeDefIndex: 1750
{
	// Fields
	public const byte CloseDoors = 128;
	public const byte OpenDoor = 64;
	private const byte ActionMask = 192;
	private const byte IdMask = 31;
	private readonly Dictionary<SystemTypes, float> timers; // 0x10
	private float initialCooldown; // 0x18
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x1C

	// Properties
	public bool IsActive { get; }
	public bool IsDirty { get; set; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	private void set_IsDirty(bool value) { }

	// RVA: 0x6CE610 Offset: 0x6CD810 VA: 0x1806CE610 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6CEAD0 Offset: 0x6CDCD0 VA: 0x1806CEAD0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6CE870 Offset: 0x6CDA70 VA: 0x1806CE870 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6CE880 Offset: 0x6CDA80 VA: 0x1806CE880 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6CE4A0 Offset: 0x6CD6A0 VA: 0x1806CE4A0 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x6CE370 Offset: 0x6CD570 VA: 0x1806CE370 Slot: 12
	public void CloseDoorsOfType(SystemTypes room) { }

	// RVA: 0x6CE7B0 Offset: 0x6CD9B0 VA: 0x1806CE7B0 Slot: 11
	public float GetTimer(SystemTypes room) { }

	// RVA: 0x6CEAC0 Offset: 0x6CDCC0 VA: 0x1806CEAC0 Slot: 13
	public void SetInitialSabotageCooldown() { }

	// RVA: 0x6CECC0 Offset: 0x6CDEC0 VA: 0x1806CECC0
	public void .ctor() { }
}

// Namespace: 
public abstract class SomeKindaDoor : MonoBehaviour // TypeDefIndex: 1751
{
	// Fields
	public const float vibrationIntensity = 2,5;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetDoorway(bool open);

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ManualDoor.<CoCloseDoorway>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1752
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ManualDoor <>4__this; // 0x20
	public bool isHort; // 0x28
	private Vector2 <s>5__2; // 0x2C
	private float <i>5__3; // 0x34

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DF220 Offset: 0x6DE420 VA: 0x1806DF220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DF680 Offset: 0x6DE880 VA: 0x1806DF680 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ManualDoor : SomeKindaDoor // TypeDefIndex: 1753
{
	// Fields
	public bool Opening; // 0x20
	public BoxCollider2D myCollider; // 0x28
	public Collider2D shadowCollider; // 0x30
	public SpriteRenderer image; // 0x38
	private float size; // 0x40
	public float OpenDuration; // 0x44
	private float openTimer; // 0x48
	private float openValue; // 0x4C
	public AudioClip OpenSound; // 0x50
	public AudioClip CloseSound; // 0x58

	// Methods

	// RVA: 0x6D72A0 Offset: 0x6D64A0 VA: 0x1806D72A0
	private void Awake() { }

	// RVA: 0x6D7930 Offset: 0x6D6B30 VA: 0x1806D7930
	private void Update() { }

	// RVA: 0x6D75B0 Offset: 0x6D67B0 VA: 0x1806D75B0 Slot: 4
	public override void SetDoorway(bool open) { }

	// RVA: 0x6D73C0 Offset: 0x6D65C0 VA: 0x1806D73C0
	private void DoorDynamics(AudioSource source, float dt) { }

	[IteratorStateMachine(typeof(ManualDoor.<CoCloseDoorway>d__14))]
	// RVA: 0x6D7310 Offset: 0x6D6510 VA: 0x1806D7310
	private IEnumerator CoCloseDoorway(bool isHort) { }

	// RVA: 0x6D7580 Offset: 0x6D6780 VA: 0x1806D7580 Slot: 5
	public virtual void Serialize(MessageWriter writer) { }

	// RVA: 0x6D7380 Offset: 0x6D6580 VA: 0x1806D7380 Slot: 6
	public virtual void Deserialize(MessageReader reader) { }

	// RVA: 0x6D7B40 Offset: 0x6D6D40 VA: 0x1806D7B40
	public void .ctor() { }
}

// Namespace: 
public abstract class OpenableDoor : SomeKindaDoor // TypeDefIndex: 1754
{
	// Fields
	public int Id; // 0x20
	public SystemTypes Room; // 0x24

	// Properties
	public abstract bool IsOpen { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsOpen();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Serialize(MessageWriter writer);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Deserialize(MessageReader reader);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool DoUpdate(float deltaTime);

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlainDoor.<CoCloseDoorway>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1755
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlainDoor <>4__this; // 0x20
	public bool isHort; // 0x28
	private Vector2 <s>5__2; // 0x2C
	private float <i>5__3; // 0x34

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6DF430 Offset: 0x6DE630 VA: 0x1806DF430 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6DF640 Offset: 0x6DE840 VA: 0x1806DF640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlainDoor : OpenableDoor // TypeDefIndex: 1756
{
	// Fields
	public bool Open; // 0x28
	public BoxCollider2D myCollider; // 0x30
	public Collider2D shadowCollider; // 0x38
	public SpriteAnim animator; // 0x40
	public AnimationClip OpenDoorAnim; // 0x48
	public AnimationClip CloseDoorAnim; // 0x50
	public AudioClip OpenSound; // 0x58
	public AudioClip CloseSound; // 0x60
	private float size; // 0x68

	// Properties
	public override bool IsOpen { get; }

	// Methods

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 5
	public override bool get_IsOpen() { }

	// RVA: 0x6DAC90 Offset: 0x6D9E90 VA: 0x1806DAC90 Slot: 9
	protected virtual void Start() { }

	// RVA: 0x6DA8E0 Offset: 0x6D9AE0 VA: 0x1806DA8E0 Slot: 4
	public override void SetDoorway(bool open) { }

	// RVA: 0x6DAD20 Offset: 0x6D9F20 VA: 0x1806DAD20
	private void UpdateShadow() { }

	[IteratorStateMachine(typeof(PlainDoor.<CoCloseDoorway>d__14))]
	// RVA: 0x6DA680 Offset: 0x6D9880 VA: 0x1806DA680
	private IEnumerator CoCloseDoorway(bool isHort) { }

	// RVA: 0x6DA6F0 Offset: 0x6D98F0 VA: 0x1806DA6F0
	private void DoorDynamics(AudioSource source, float dt) { }

	// RVA: 0x6DA8B0 Offset: 0x6D9AB0 VA: 0x1806DA8B0 Slot: 6
	public override void Serialize(MessageWriter writer) { }

	// RVA: 0x6D7380 Offset: 0x6D6580 VA: 0x1806D7380 Slot: 7
	public override void Deserialize(MessageReader reader) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool DoUpdate(float dt) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class StaticDoor : MonoBehaviour // TypeDefIndex: 1757
{
	// Fields
	public Sprite OpenDoorImage; // 0x20
	public Sprite CloseDoorImage; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x30

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	private void set_IsOpen(bool value) { }

	// RVA: 0x6DDC40 Offset: 0x6DCE40 VA: 0x1806DDC40
	public void SetOpen(bool isOpen) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmergencyMinigame.<CoAnimateOpen>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1758
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EmergencyMinigame <>4__this; // 0x20
	private Vector3 <meetingPos>5__2; // 0x28
	private float <timer>5__3; // 0x34

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F4160 Offset: 0x6F3360 VA: 0x1806F4160 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F4400 Offset: 0x6F3600 VA: 0x1806F4400 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class EmergencyMinigame : Minigame // TypeDefIndex: 1759
{
	// Fields
	public SpriteRenderer ClosedLid; // 0x88
	public SpriteRenderer OpenLid; // 0x90
	public Transform meetingButton; // 0x98
	public TextMeshPro StatusText; // 0xA0
	public TextMeshPro NumberText; // 0xA8
	public bool ButtonActive; // 0xB0
	public AudioClip ButtonSound; // 0xB8
	private int state; // 0xC0
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xC8
	public UiElement DefaultButtonSelected; // 0xD0
	public const int MinEmergencyTime = 15;

	// Methods

	// RVA: 0x6CF110 Offset: 0x6CE310 VA: 0x1806CF110
	private void OnDisable() { }

	// RVA: 0x6CED30 Offset: 0x6CDF30 VA: 0x1806CED30 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6CF180 Offset: 0x6CE380 VA: 0x1806CF180
	public void Update() { }

	// RVA: 0x6CEDD0 Offset: 0x6CDFD0 VA: 0x1806CEDD0
	public void CallMeeting() { }

	// RVA: 0x6CF880 Offset: 0x6CEA80 VA: 0x1806CF880
	private float easeOutElastic(float t) { }

	[IteratorStateMachine(typeof(EmergencyMinigame.<CoAnimateOpen>d__16))]
	// RVA: 0x6CF0A0 Offset: 0x6CE2A0 VA: 0x1806CF0A0 Slot: 7
	protected override IEnumerator CoAnimateOpen() { }

	// RVA: 0x6CF870 Offset: 0x6CEA70 VA: 0x1806CF870
	public void .ctor() { }
}

// Namespace: 
internal class FootstepWatcher : MonoBehaviour, IStepWatcher // TypeDefIndex: 1760
{
	// Fields
	public int priority; // 0x20
	public Collider2D Area; // 0x28
	public SoundGroup Sounds; // 0x30

	// Properties
	public int Priority { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 4
	public int get_Priority() { }

	// RVA: 0x6E1C40 Offset: 0x6E0E40 VA: 0x1806E1C40 Slot: 5
	public SoundGroup MakeFootstep(PlayerControl player) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum HqHudSystemType.Tags // TypeDefIndex: 1761
{
	// Fields
	public int value__; // 0x0
	public const HqHudSystemType.Tags DamageBit = 128;
	public const HqHudSystemType.Tags ActiveBit = 64;
	public const HqHudSystemType.Tags DeactiveBit = 32;
	public const HqHudSystemType.Tags FixBit = 16;
}

// Namespace: 
[CompilerGenerated]
private sealed class HqHudSystemType.<>c__DisplayClass20_0 // TypeDefIndex: 1762
{
	// Fields
	public int consoleId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6C90 Offset: 0x6F5E90 VA: 0x1806F6C90
	internal bool <IsConsoleActive>b__0(Tuple<byte, byte> s) { }
}

// Namespace: 
internal class HqHudSystemType : ISystemType, IActivatable // TypeDefIndex: 1763
{
	// Fields
	public const byte TagMask = 240;
	public const byte IdMask = 15;
	private HashSet<Tuple<byte, byte>> ActiveConsoles; // 0x10
	private HashSet<byte> CompletedConsoles; // 0x18
	private const float ActiveTime = 10;
	private float Timer; // 0x20
	public int TargetNumber; // 0x24
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x28

	// Properties
	public bool IsActive { get; }
	public float NumComplete { get; }
	public float PercentActive { get; }
	public bool IsDirty { get; set; }

	// Methods

	// RVA: 0x6E2790 Offset: 0x6E1990 VA: 0x1806E2790 Slot: 10
	public bool get_IsActive() { }

	// RVA: 0x6E27E0 Offset: 0x6E19E0 VA: 0x1806E27E0
	public float get_NumComplete() { }

	// RVA: 0x6E2830 Offset: 0x6E1A30 VA: 0x1806E2830
	public float get_PercentActive() { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	private void set_IsDirty(bool value) { }

	// RVA: 0x6E26A0 Offset: 0x6E18A0 VA: 0x1806E26A0
	public void .ctor() { }

	// RVA: 0x6E1F90 Offset: 0x6E1190 VA: 0x1806E1F90 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6E20D0 Offset: 0x6E12D0 VA: 0x1806E20D0
	internal bool IsConsoleActive(int consoleId) { }

	// RVA: 0x6E21A0 Offset: 0x6E13A0 VA: 0x1806E21A0
	internal bool IsConsoleOkay(int consoleId) { }

	// RVA: 0x6E24B0 Offset: 0x6E16B0 VA: 0x1806E24B0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x538580 Offset: 0x537780 VA: 0x180538580 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6E2200 Offset: 0x6E1400 VA: 0x1806E2200 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6E1DE0 Offset: 0x6E0FE0 VA: 0x1806E1DE0 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }
}

// Namespace: 
public interface RunTimer // TypeDefIndex: 1764
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetTimer(SystemTypes system);
}

// Namespace: 
public interface IActivatable // TypeDefIndex: 1765
{
	// Properties
	public abstract bool IsActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsActive();
}

// Namespace: 
public interface ICriticalSabotage // TypeDefIndex: 1766
{
	// Properties
	public abstract bool IsActive { get; }
	public abstract float Countdown { get; }
	public abstract int UserCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_Countdown();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_UserCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ClearSabotage();
}

// Namespace: 
internal class HudOverrideSystemType : ISystemType, IActivatable // TypeDefIndex: 1767
{
	// Fields
	public const byte DamageBit = 128;
	public const byte TaskMask = 127;
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x11

	// Properties
	public bool IsActive { get; set; }
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 10
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	private void set_IsDirty(bool value) { }

	// RVA: 0x6E2870 Offset: 0x6E1A70 VA: 0x1806E2870 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6E2970 Offset: 0x6E1B70 VA: 0x1806E2970 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6E2930 Offset: 0x6E1B30 VA: 0x1806E2930 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6E2940 Offset: 0x6E1B40 VA: 0x1806E2940 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6E2840 Offset: 0x6E1A40 VA: 0x1806E2840 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public interface IReactorShipRoom // TypeDefIndex: 1768
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartMeltdown();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopMeltdown();
}

// Namespace: 
public interface IStepWatcher // TypeDefIndex: 1769
{
	// Properties
	public abstract int Priority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Priority();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract SoundGroup MakeFootstep(PlayerControl player);
}

// Namespace: 
public interface IUsable // TypeDefIndex: 1770
{
	// Properties
	public abstract float UsableDistance { get; }
	public abstract float PercentCool { get; }
	public abstract ImageNames UseIcon { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_UsableDistance();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_PercentCool();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ImageNames get_UseIcon();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetOutline(bool on, bool mainTarget);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Use();
}

// Namespace: 
public interface IUsableCoolDown : IUsable // TypeDefIndex: 1771
{
	// Properties
	public abstract float CoolDown { get; set; }
	public abstract float MaxCoolDown { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_CoolDown();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_CoolDown(float value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_MaxCoolDown();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsCoolingDown();
}

// Namespace: 
public class MapConsole : MonoBehaviour, IUsable // TypeDefIndex: 1772
{
	// Fields
	public ImageNames useIcon; // 0x20
	public float usableDistance; // 0x24
	public SpriteRenderer Image; // 0x28

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x6E5E50 Offset: 0x6E5050 VA: 0x1806E5E50 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6E5D50 Offset: 0x6E4F50 VA: 0x1806E5D50 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6E5FB0 Offset: 0x6E51B0 VA: 0x1806E5FB0 Slot: 9
	public void Use() { }

	// RVA: 0x6E6240 Offset: 0x6E5440 VA: 0x1806E6240
	public void .ctor() { }
}

// Namespace: 
public enum TransitionType // TypeDefIndex: 1773
{
	// Fields
	public int value__; // 0x0
	public const TransitionType SlideBottom = 0;
	public const TransitionType Alpha = 1;
	public const TransitionType None = 2;
}

// Namespace: 
protected enum Minigame.CloseState // TypeDefIndex: 1774
{
	// Fields
	public int value__; // 0x0
	public const Minigame.CloseState None = 0;
	public const Minigame.CloseState Waiting = 1;
	public const Minigame.CloseState Closing = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class Minigame.<CoAnimateOpen>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1775
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Minigame <>4__this; // 0x20
	private float <depth>5__2; // 0x28
	private SpriteRenderer[] <rends>5__3; // 0x30
	private float <timer>5__4; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F4440 Offset: 0x6F3640 VA: 0x1806F4440 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F4A00 Offset: 0x6F3C00 VA: 0x1806F4A00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Minigame.<CoDestroySelf>d__36 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1776
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Minigame <>4__this; // 0x20
	private SpriteRenderer[] <rends>5__2; // 0x28
	private float <timer>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F4A40 Offset: 0x6F3C40 VA: 0x1806F4A40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F4DE0 Offset: 0x6F3FE0 VA: 0x1806F4DE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Minigame.<CoStartClose>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1777
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Minigame <>4__this; // 0x20
	public float duration; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F4F60 Offset: 0x6F4160 VA: 0x1806F4F60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F5020 Offset: 0x6F4220 VA: 0x1806F5020 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public abstract class Minigame : MonoBehaviour // TypeDefIndex: 1778
{
	// Fields
	public static Minigame Instance; // 0x0
	public const float Depth = -50;
	public TransitionType TransType; // 0x20
	public Vector2 TargetPosition; // 0x24
	protected PlayerTask MyTask; // 0x30
	protected NormalPlayerTask MyNormTask; // 0x38
	[CompilerGenerated]
	private Console <Console>k__BackingField; // 0x40
	protected Minigame.CloseState amClosing; // 0x48
	protected bool amOpening; // 0x4C
	public AudioClip OpenSound; // 0x50
	public AudioClip CloseSound; // 0x58
	public SpecialInputHandler inputHandler; // 0x60
	private bool multistageMinigameChecked; // 0x68
	private MultistageMinigame multistageMinigameParent; // 0x70
	private readonly Logger logger; // 0x78
	private float timeOpened; // 0x80

	// Properties
	public TaskTypes TaskType { get; }
	public Console Console { get; set; }
	protected int ConsoleId { get; }
	public bool HasMultistageMinigameParent { get; }
	public MultistageMinigame MultistageMinigameParent { get; }
	public virtual bool SkipMultistageOverlayMenuSetup { get; }

	// Methods

	// RVA: 0x6E6F50 Offset: 0x6E6150 VA: 0x1806E6F50
	public TaskTypes get_TaskType() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Console get_Console() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Console(Console value) { }

	// RVA: 0x6E6E40 Offset: 0x6E6040 VA: 0x1806E6E40
	protected int get_ConsoleId() { }

	// RVA: 0x6E6EC0 Offset: 0x6E60C0 VA: 0x1806E6EC0
	public bool get_HasMultistageMinigameParent() { }

	// RVA: 0x6E6C00 Offset: 0x6E5E00 VA: 0x1806E6C00
	public MultistageMinigame get_MultistageMinigameParent() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public virtual bool get_SkipMultistageOverlayMenuSetup() { }

	// RVA: 0x6E6260 Offset: 0x6E5460 VA: 0x1806E6260 Slot: 5
	public virtual void Begin(PlayerTask task) { }

	[IteratorStateMachine(typeof(Minigame.<CoStartClose>d__31))]
	// RVA: 0x6E6B20 Offset: 0x6E5D20 VA: 0x1806E6B20
	protected IEnumerator CoStartClose(float duration = 0,75) { }

	[Obsolete("Don't use, I just don't want to reselect the close button event handlers", True)]
	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600
	public void Close(bool allowMovement) { }

	// RVA: 0x6E6B90 Offset: 0x6E5D90 VA: 0x1806E6B90
	public void ForceClose() { }

	// RVA: 0x6E6620 Offset: 0x6E5820 VA: 0x1806E6620 Slot: 6
	public virtual void Close() { }

	[IteratorStateMachine(typeof(Minigame.<CoAnimateOpen>d__35))]
	// RVA: 0x6E6A60 Offset: 0x6E5C60 VA: 0x1806E6A60 Slot: 7
	protected virtual IEnumerator CoAnimateOpen() { }

	[IteratorStateMachine(typeof(Minigame.<CoDestroySelf>d__36))]
	// RVA: 0x6E6AC0 Offset: 0x6E5CC0 VA: 0x1806E6AC0 Slot: 8
	protected virtual IEnumerator CoDestroySelf() { }

	// RVA: 0x6E6C50 Offset: 0x6E5E50 VA: 0x1806E6C50
	public void SetupInput(bool disableCursor, bool suppressInGamePlayerList = False) { }

	// RVA: 0x6E6C00 Offset: 0x6E5E00 VA: 0x1806E6C00
	private MultistageMinigame GetMultistageMinigameParentOnce() { }

	// RVA: 0x6E6D80 Offset: 0x6E5F80 VA: 0x1806E6D80
	protected void .ctor() { }
}

// Namespace: 
public class OpenDoorConsole : MonoBehaviour, IUsable // TypeDefIndex: 1779
{
	// Fields
	private ImageNames useIcon; // 0x20
	public float usableDisance; // 0x24
	private OpenableDoor myDoor; // 0x28
	private SpriteRenderer image; // 0x30

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x6E6FD0 Offset: 0x6E61D0 VA: 0x1806E6FD0
	public void Awake() { }

	// RVA: 0x6E7030 Offset: 0x6E6230 VA: 0x1806E7030 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6E7130 Offset: 0x6E6330 VA: 0x1806E7130 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6E7290 Offset: 0x6E6490 VA: 0x1806E7290 Slot: 9
	public void Use() { }

	// RVA: 0x6E7430 Offset: 0x6E6630 VA: 0x1806E7430
	public void .ctor() { }
}

// Namespace: 
public class PlainShipRoom : MonoBehaviour // TypeDefIndex: 1780
{
	// Fields
	public SystemTypes RoomId; // 0x20
	public SurvCamera survCamera; // 0x28
	public Collider2D roomArea; // 0x30

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class PlatformConsole : MonoBehaviour, IUsable // TypeDefIndex: 1781
{
	// Fields
	public float usableDistance; // 0x20
	public SpriteRenderer Image; // 0x28
	public MovingPlatformBehaviour Platform; // 0x30

	// Properties
	public float UsableDistance { get; }
	public float PercentCool { get; }
	public ImageNames UseIcon { get; }

	// Methods

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x6E7450 Offset: 0x6E6650 VA: 0x1806E7450 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6E7710 Offset: 0x6E6910 VA: 0x1806E7710 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6E7870 Offset: 0x6E6A70 VA: 0x1806E7870 Slot: 9
	public void Use() { }

	// RVA: 0x6E7920 Offset: 0x6E6B20 VA: 0x1806E7920
	public void .ctor() { }
}

// Namespace: 
public class ReactorRoomWire : MonoBehaviour // TypeDefIndex: 1782
{
	// Fields
	public Console myConsole; // 0x20
	public SpriteAnim Image; // 0x28
	public AnimationClip Normal; // 0x30
	public AnimationClip MeltdownNeed; // 0x38
	public AnimationClip MeltdownReady; // 0x40
	private ReactorSystemType reactor; // 0x48

	// Methods

	// RVA: 0x6E8030 Offset: 0x6E7230 VA: 0x1806E8030
	public void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ReactorShipRoom : SkeldShipRoom, IReactorShipRoom // TypeDefIndex: 1783
{
	// Fields
	public Sprite normalManifolds; // 0x68
	public Sprite meltdownManifolds; // 0x70
	public SpriteRenderer Manifolds; // 0x78
	public AnimationClip normalReactor; // 0x80
	public AnimationClip meltdownReactor; // 0x88
	public SpriteAnim Reactor; // 0x90
	public AnimationClip normalHighFloor; // 0x98
	public AnimationClip meltdownHighFloor; // 0xA0
	public SpriteAnim HighFloor; // 0xA8
	public AnimationClip normalMidFloor; // 0xB0
	public AnimationClip meltdownMidFloor; // 0xB8
	public SpriteAnim MidFloor1; // 0xC0
	public SpriteAnim MidFloor2; // 0xC8
	public AnimationClip normalLowFloor; // 0xD0
	public AnimationClip meltdownLowFloor; // 0xD8
	public SpriteAnim LowFloor; // 0xE0
	public AnimationClip[] normalPipes; // 0xE8
	public AnimationClip[] meltdownPipes; // 0xF0
	public SpriteAnim[] Pipes; // 0xF8
	public SupressorBehaviour[] Supressors; // 0x100
	public MeshRenderer Orb; // 0x108
	public Rotater OrbGlass; // 0x110
	public ChainBehaviour[] Arms; // 0x118

	// Methods

	// RVA: 0x6E82D0 Offset: 0x6E74D0 VA: 0x1806E82D0 Slot: 6
	public void StartMeltdown() { }

	// RVA: 0x6E8750 Offset: 0x6E7950 VA: 0x1806E8750 Slot: 7
	public void StopMeltdown() { }

	// RVA: 0x6E8BC0 Offset: 0x6E7DC0 VA: 0x1806E8BC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SabotageSystemType.<>c // TypeDefIndex: 1784
{
	// Fields
	public static readonly SabotageSystemType.<>c <>9; // 0x0
	public static Func<IActivatable, bool> <>9__8_0; // 0x8
	public static Predicate<IActivatable> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x6F6E50 Offset: 0x6F6050 VA: 0x1806F6E50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6C20 Offset: 0x6F5E20 VA: 0x1806F6C20
	internal bool <get_AnyActive>b__8_0(IActivatable s) { }

	// RVA: 0x6F6BE0 Offset: 0x6F5DE0 VA: 0x1806F6BE0
	internal bool <.ctor>b__15_0(IActivatable d) { }
}

// Namespace: 
public class SabotageSystemType : ISystemType // TypeDefIndex: 1785
{
	// Fields
	public const float SpecialSabDelay = 30;
	[CompilerGenerated]
	private float <Timer>k__BackingField; // 0x10
	private List<IActivatable> specials; // 0x18
	private bool initialCooldown; // 0x20
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x21

	// Properties
	public float Timer { get; set; }
	public float PercentCool { get; }
	public bool AnyActive { get; }
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_Timer() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	private void set_Timer(float value) { }

	// RVA: 0x6E92D0 Offset: 0x6E84D0 VA: 0x1806E92D0
	public float get_PercentCool() { }

	// RVA: 0x6E91D0 Offset: 0x6E83D0 VA: 0x1806E91D0
	public bool get_AnyActive() { }

	[CompilerGenerated]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	private void set_IsDirty(bool value) { }

	// RVA: 0x6E9080 Offset: 0x6E8280 VA: 0x1806E9080
	public void .ctor(IActivatable[] specials) { }

	// RVA: 0x6E8C50 Offset: 0x6E7E50 VA: 0x1806E8C50 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6E8DE0 Offset: 0x6E7FE0 VA: 0x1806E8DE0
	public void SetInitialSabotageCooldown() { }

	// RVA: 0x6E8DF0 Offset: 0x6E7FF0 VA: 0x1806E8DF0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6E8DA0 Offset: 0x6E7FA0 VA: 0x1806E8DA0 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6E8DB0 Offset: 0x6E7FB0 VA: 0x1806E8DB0 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6E8C20 Offset: 0x6E7E20 VA: 0x1806E8C20 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }
}

// Namespace: 
public enum SecurityLogBehaviour.SecurityLogLocations // TypeDefIndex: 1786
{
	// Fields
	public int value__; // 0x0
	public const SecurityLogBehaviour.SecurityLogLocations North = 0;
	public const SecurityLogBehaviour.SecurityLogLocations Southeast = 1;
	public const SecurityLogBehaviour.SecurityLogLocations Southwest = 2;
}

// Namespace: 
public struct SecurityLogBehaviour.SecurityLogEntry // TypeDefIndex: 1787
{
	// Fields
	public byte PlayerId; // 0x0
	public SecurityLogBehaviour.SecurityLogLocations Location; // 0x4

	// Methods

	// RVA: 0x6E9600 Offset: 0x6E8800 VA: 0x1806E9600
	public void .ctor(byte playerId, SecurityLogBehaviour.SecurityLogLocations location) { }
}

// Namespace: 
public class SecurityLogBehaviour : MonoBehaviour // TypeDefIndex: 1788
{
	// Fields
	public const byte ConsoleMask = 240;
	public const byte PlayerMask = 15;
	public Color[] BarColors; // 0x20
	public readonly List<SecurityLogBehaviour.SecurityLogEntry> LogEntries; // 0x28
	public bool HasNew; // 0x30

	// Methods

	// RVA: 0x6E92F0 Offset: 0x6E84F0 VA: 0x1806E92F0
	public void LogPlayer(PlayerControl player, SecurityLogBehaviour.SecurityLogLocations location) { }

	// RVA: 0x6E9400 Offset: 0x6E8600 VA: 0x1806E9400
	public void .ctor() { }
}

// Namespace: 
public enum ShipStatus.MapType // TypeDefIndex: 1789
{
	// Fields
	public int value__; // 0x0
	public const ShipStatus.MapType Ship = 0;
	public const ShipStatus.MapType Hq = 1;
	public const ShipStatus.MapType Pb = 2;
	public const ShipStatus.MapType Fungle = 3;
}

// Namespace: 
public class ShipStatus.SystemTypeComparer : IEqualityComparer<SystemTypes> // TypeDefIndex: 1790
{
	// Fields
	public static readonly ShipStatus.SystemTypeComparer Instance; // 0x0

	// Methods

	// RVA: 0x6F31F0 Offset: 0x6F23F0 VA: 0x1806F31F0 Slot: 4
	public bool Equals(SystemTypes x, SystemTypes y) { }

	// RVA: 0x6F3200 Offset: 0x6F2400 VA: 0x1806F3200 Slot: 5
	public int GetHashCode(SystemTypes obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F3210 Offset: 0x6F2410 VA: 0x1806F3210
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ShipStatus.<>c // TypeDefIndex: 1791
{
	// Fields
	public static readonly ShipStatus.<>c <>9; // 0x0
	public static Func<ISystemType, bool> <>9__74_0; // 0x8
	public static Func<IStepWatcher, int> <>9__76_0; // 0x10
	public static Func<PlainShipRoom, bool> <>9__76_1; // 0x18
	public static Func<PlainShipRoom, SystemTypes> <>9__76_2; // 0x20
	public static Action<NormalPlayerTask> <>9__95_0; // 0x28
	public static Action<NormalPlayerTask> <>9__95_1; // 0x30
	public static Action<NormalPlayerTask> <>9__95_2; // 0x38
	public static Func<byte, NetworkedPlayerInfo> <>9__102_0; // 0x40

	// Methods

	// RVA: 0x6F6D90 Offset: 0x6F5F90 VA: 0x1806F6D90
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6BA0 Offset: 0x6F5DA0 VA: 0x1806F6BA0
	internal bool <OnEnable>b__74_0(ISystemType i) { }

	// RVA: 0x6F6A00 Offset: 0x6F5C00 VA: 0x1806F6A00
	internal int <Awake>b__76_0(IStepWatcher s) { }

	// RVA: 0x6F6AC0 Offset: 0x6F5CC0 VA: 0x1806F6AC0
	internal bool <Awake>b__76_1(PlainShipRoom p) { }

	// RVA: 0x54BC30 Offset: 0x54AE30 VA: 0x18054BC30
	internal SystemTypes <Awake>b__76_2(PlainShipRoom d) { }

	// RVA: 0x6F6AE0 Offset: 0x6F5CE0 VA: 0x1806F6AE0
	internal void <Begin>b__95_0(NormalPlayerTask t) { }

	// RVA: 0x6F6B00 Offset: 0x6F5D00 VA: 0x1806F6B00
	internal void <Begin>b__95_1(NormalPlayerTask t) { }

	// RVA: 0x6F6B20 Offset: 0x6F5D20 VA: 0x1806F6B20
	internal void <Begin>b__95_2(NormalPlayerTask t) { }

	// RVA: 0x6F6B40 Offset: 0x6F5D40 VA: 0x1806F6B40
	internal NetworkedPlayerInfo <CoStartMeeting>b__102_0(byte b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShipStatus.<>c__DisplayClass101_0 // TypeDefIndex: 1792
{
	// Fields
	public TaskTypes taskTypeForSystem; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6C70 Offset: 0x6F5E70 VA: 0x1806F6C70
	internal bool <GetSabotageTask>b__0(PlayerTask task) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShipStatus.<>c__DisplayClass82_0 // TypeDefIndex: 1793
{
	// Fields
	public byte idx; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6D10 Offset: 0x6F5F10 VA: 0x1806F6D10
	internal bool <GetTaskById>b__0(NormalPlayerTask t) { }

	// RVA: 0x6F6D10 Offset: 0x6F5F10 VA: 0x1806F6D10
	internal bool <GetTaskById>b__1(NormalPlayerTask t) { }

	// RVA: 0x6F6D10 Offset: 0x6F5F10 VA: 0x1806F6D10
	internal bool <GetTaskById>b__2(NormalPlayerTask t) { }
}

// Namespace: 
[CompilerGenerated]
private struct ShipStatus.<>c__DisplayClass85_0 // TypeDefIndex: 1794
{
	// Fields
	public Type[] types; // 0x0
}

// Namespace: 
[CompilerGenerated]
private sealed class ShipStatus.<>c__DisplayClass97_0 // TypeDefIndex: 1795
{
	// Fields
	public HashSet<TaskTypes> usedTaskTypes; // 0x10
	public Func<NormalPlayerTask, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6D30 Offset: 0x6F5F30 VA: 0x1806F6D30
	internal bool <AddTasksFromList>b__0(NormalPlayerTask t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShipStatus.<CoStartMeeting>d__102 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1796
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl reporter; // 0x20
	public NetworkedPlayerInfo target; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F5060 Offset: 0x6F4260 VA: 0x1806F5060 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F5BF0 Offset: 0x6F4DF0 VA: 0x1806F5BF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShipStatus.<PrespawnStep>d__94 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1797
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F66D0 Offset: 0x6F58D0 VA: 0x1806F66D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F66E0 Offset: 0x6F58E0 VA: 0x1806F66E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ShipStatus : InnerNetObject // TypeDefIndex: 1798
{
	// Fields
	public static ShipStatus Instance; // 0x0
	public Color CameraColor; // 0x38
	public float MaxLightRadius; // 0x48
	public float MinLightRadius; // 0x4C
	public float MapScale; // 0x50
	public MapBehaviour MapPrefab; // 0x58
	public ExileController ExileCutscenePrefab; // 0x60
	public MeetingCalledAnimation EmergencyOverlay; // 0x68
	public MeetingCalledAnimation ReportOverlay; // 0x70
	public Sprite MeetingBackground; // 0x78
	public Sprite BrokenEmergencyButton; // 0x80
	public SystemConsole EmergencyButton; // 0x88
	public Vector2 InitialSpawnCenter; // 0x90
	public Vector2 MeetingSpawnCenter; // 0x98
	public Vector2 MeetingSpawnCenter2; // 0xA0
	public float SpawnRadius; // 0xA8
	public NormalPlayerTask[] CommonTasks; // 0xB0
	public NormalPlayerTask[] LongTasks; // 0xB8
	public NormalPlayerTask[] ShortTasks; // 0xC0
	public PlayerTask[] SpecialTasks; // 0xC8
	public Transform[] DummyLocations; // 0xD0
	public SurvCamera[] AllCameras; // 0xD8
	public OpenableDoor[] AllDoors; // 0xE0
	public Console[] AllConsoles; // 0xE8
	public Ladder[] Ladders; // 0xF0
	public Dictionary<SystemTypes, ISystemType> Systems; // 0xF8
	public StringNames[] SystemNames; // 0x100
	public StringNames[] ExtraTaskNames; // 0x108
	[CompilerGenerated]
	private IStepWatcher[] <AllStepWatchers>k__BackingField; // 0x110
	[CompilerGenerated]
	private PlainShipRoom[] <AllRooms>k__BackingField; // 0x118
	[CompilerGenerated]
	private Dictionary<SystemTypes, PlainShipRoom> <FastRooms>k__BackingField; // 0x120
	[CompilerGenerated]
	private Vent[] <AllVents>k__BackingField; // 0x128
	public AudioClip SabotageSound; // 0x130
	public AnimationClip[] WeaponFires; // 0x138
	public SpriteAnim WeaponsImage; // 0x140
	public AudioClip[] VentMoveSounds; // 0x148
	public AudioClip VentEnterSound; // 0x150
	public AudioClip VentExitSound; // 0x158
	public AnimationClip HatchActive; // 0x160
	public SpriteAnim Hatch; // 0x168
	public ParticleSystem HatchParticles; // 0x170
	public AnimationClip ShieldsActive; // 0x178
	public SpriteAnim[] ShieldsImages; // 0x180
	public SpriteRenderer ShieldBorder; // 0x188
	public Sprite ShieldBorderOn; // 0x190
	public MedScannerBehaviour MedScanner; // 0x198
	private int WeaponFireIdx; // 0x1A0
	public float Timer; // 0x1A4
	public float EmergencyCooldown; // 0x1A8
	public ShipStatus.MapType Type; // 0x1AC
	[CompilerGenerated]
	private float <HideCountdown>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private CosmeticsCache <CosmeticsCache>k__BackingField; // 0x1B8
	protected readonly Logger logger; // 0x1C0
	private int numScans; // 0x1C8

	// Properties
	public IStepWatcher[] AllStepWatchers { get; set; }
	public PlainShipRoom[] AllRooms { get; set; }
	public Dictionary<SystemTypes, PlainShipRoom> FastRooms { get; set; }
	public Vent[] AllVents { get; set; }
	public float HideCountdown { get; set; }
	public CosmeticsCache CosmeticsCache { get; set; }
	public override bool IsDirty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public IStepWatcher[] get_AllStepWatchers() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_AllStepWatchers(IStepWatcher[] value) { }

	[CompilerGenerated]
	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public PlainShipRoom[] get_AllRooms() { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_AllRooms(PlainShipRoom[] value) { }

	[CompilerGenerated]
	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	public Dictionary<SystemTypes, PlainShipRoom> get_FastRooms() { }

	[CompilerGenerated]
	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0
	private void set_FastRooms(Dictionary<SystemTypes, PlainShipRoom> value) { }

	[CompilerGenerated]
	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	public Vent[] get_AllVents() { }

	[CompilerGenerated]
	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	private void set_AllVents(Vent[] value) { }

	[CompilerGenerated]
	// RVA: 0x6ED550 Offset: 0x6EC750 VA: 0x1806ED550
	public float get_HideCountdown() { }

	[CompilerGenerated]
	// RVA: 0x6ED700 Offset: 0x6EC900 VA: 0x1806ED700
	public void set_HideCountdown(float value) { }

	[CompilerGenerated]
	// RVA: 0x6ED540 Offset: 0x6EC740 VA: 0x1806ED540
	public CosmeticsCache get_CosmeticsCache() { }

	[CompilerGenerated]
	// RVA: 0x6ED6E0 Offset: 0x6EC8E0 VA: 0x1806ED6E0
	public void set_CosmeticsCache(CosmeticsCache value) { }

	// RVA: 0x6ED560 Offset: 0x6EC760 VA: 0x1806ED560 Slot: 5
	public override bool get_IsDirty() { }

	// RVA: 0x6EB970 Offset: 0x6EAB70 VA: 0x1806EB970 Slot: 11
	protected virtual void OnEnable() { }

	// RVA: 0x6EC490 Offset: 0x6EB690 VA: 0x1806EC490 Slot: 12
	public virtual void RepairCriticalSabotages() { }

	// RVA: 0x6E9A50 Offset: 0x6E8C50 VA: 0x1806E9A50
	private void Awake() { }

	// RVA: 0x6ECE80 Offset: 0x6EC080 VA: 0x1806ECE80 Slot: 13
	protected virtual void Start() { }

	// RVA: 0x6EB890 Offset: 0x6EAA90 VA: 0x1806EB890 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x6ECBA0 Offset: 0x6EBDA0 VA: 0x1806ECBA0 Slot: 14
	public virtual void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn) { }

	// RVA: 0x6ECDC0 Offset: 0x6EBFC0 VA: 0x1806ECDC0
	public void StartShields() { }

	// RVA: 0x6EADE0 Offset: 0x6E9FE0 VA: 0x1806EADE0
	public void FireWeapon() { }

	// RVA: 0x6EB320 Offset: 0x6EA520 VA: 0x1806EB320
	public NormalPlayerTask GetTaskById(byte idx) { }

	// RVA: 0x6EB170 Offset: 0x6EA370 VA: 0x1806EB170
	public PlayerTask[] GetAllTasks() { }

	// RVA: -1 Offset: -1
	public bool HasTaskType<TTaskType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA70960 Offset: 0xA6FB60 VA: 0x180A70960
	|-ShipStatus.HasTaskType<object>
	*/

	// RVA: 0x6EB560 Offset: 0x6EA760 VA: 0x1806EB560
	public bool HasTaskTypes(Type[] types) { }

	// RVA: 0x6EB5C0 Offset: 0x6EA7C0 VA: 0x1806EB5C0
	private void InitializeExtraTaskNames() { }

	// RVA: 0x6EC380 Offset: 0x6EB580 VA: 0x1806EC380
	public void OpenHatch() { }

	// RVA: 0x6EAAE0 Offset: 0x6E9CE0 VA: 0x1806EAAE0
	public void CloseDoorsOfType(SystemTypes room) { }

	// RVA: 0x6ED0A0 Offset: 0x6EC2A0 VA: 0x1806ED0A0
	public void UpdateSystem(SystemTypes systemType, PlayerControl player, byte amount) { }

	// RVA: 0x6ED2D0 Offset: 0x6EC4D0 VA: 0x1806ED2D0
	public void UpdateSystem(SystemTypes systemType, PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6E9900 Offset: 0x6E8B00 VA: 0x1806E9900
	private void AssignTaskIndexes() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void OnMeetingCalled() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public virtual void StartSFX() { }

	[IteratorStateMachine(typeof(ShipStatus.<PrespawnStep>d__94))]
	// RVA: 0x6EC440 Offset: 0x6EB640 VA: 0x1806EC440 Slot: 17
	public virtual IEnumerator PrespawnStep() { }

	// RVA: 0x6E9E30 Offset: 0x6E9030 VA: 0x1806E9E30
	public void Begin() { }

	// RVA: 0x6E9610 Offset: 0x6E8810 VA: 0x1806E9610
	private void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks) { }

	// RVA: 0x6EAEC0 Offset: 0x6EA0C0 VA: 0x1806EAEC0
	public void FixedUpdate() { }

	// RVA: 0x6EA6E0 Offset: 0x6E98E0 VA: 0x1806EA6E0 Slot: 18
	public virtual float CalculateLightRadius(NetworkedPlayerInfo player) { }

	// RVA: 0x6ECD30 Offset: 0x6EBF30 VA: 0x1806ECD30
	public void StartMeeting(PlayerControl reporter, NetworkedPlayerInfo target) { }

	// RVA: 0x6EB1F0 Offset: 0x6EA3F0 VA: 0x1806EB1F0
	public PlayerTask GetSabotageTask(SystemTypes system) { }

	[IteratorStateMachine(typeof(ShipStatus.<CoStartMeeting>d__102))]
	// RVA: 0x6EAC90 Offset: 0x6E9E90 VA: 0x1806EAC90
	public IEnumerator CoStartMeeting(PlayerControl reporter, NetworkedPlayerInfo target) { }

	// RVA: 0x6EA690 Offset: 0x6E9890 VA: 0x1806EA690
	public void BreakEmergencyButton() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void ValidateAllTasksOnShip() { }

	// RVA: 0x6EC580 Offset: 0x6EB780 VA: 0x1806EC580
	public void RpcCloseDoorsOfType(SystemTypes type) { }

	// RVA: 0x6EC680 Offset: 0x6EB880 VA: 0x1806EC680
	public void RpcUpdateSystem(SystemTypes systemType, byte amount) { }

	// RVA: 0x6EC820 Offset: 0x6EBA20 VA: 0x1806EC820
	public void RpcUpdateSystem(SystemTypes systemType, MessageWriter msgWriter) { }

	// RVA: 0x6EA990 Offset: 0x6E9B90 VA: 0x1806EA990 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x6ECA00 Offset: 0x6EBC00 VA: 0x1806ECA00 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6EAD00 Offset: 0x6E9F00 VA: 0x1806EAD00 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x6EB4A0 Offset: 0x6EA6A0 VA: 0x1806EB4A0 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x6ED420 Offset: 0x6EC620 VA: 0x1806ED420
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6ECFC0 Offset: 0x6EC1C0 VA: 0x1806ECFC0
	internal static bool <HasTaskTypes>g__CheckTaskArray|85_0(PlayerTask[] tasks, ref ShipStatus.<>c__DisplayClass85_0 ) { }
}

// Namespace: 
public class SkeldShipRoom : PlainShipRoom, IStepWatcher // TypeDefIndex: 1799
{
	// Fields
	public AudioClip AmbientSound; // 0x38
	public float AmbientVolume; // 0x40
	public float AmbientMaxDist; // 0x44
	public Vector2 AmbientOffset; // 0x48
	[CompilerGenerated]
	private readonly int <Priority>k__BackingField; // 0x50
	public SoundGroup FootStepSounds; // 0x58
	private RaycastHit2D[] volumeBuffer; // 0x60

	// Properties
	public int Priority { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 4
	public int get_Priority() { }

	// RVA: 0x6EDBF0 Offset: 0x6ECDF0 VA: 0x1806EDBF0
	public void Start() { }

	// RVA: 0x6EDB10 Offset: 0x6ECD10 VA: 0x1806EDB10 Slot: 5
	public SoundGroup MakeFootstep(PlayerControl player) { }

	// RVA: 0x6ED830 Offset: 0x6ECA30 VA: 0x1806ED830
	private void GetAmbientSoundVolume(AudioSource player, float dt) { }

	// RVA: 0x6E8BC0 Offset: 0x6E7DC0 VA: 0x1806E8BC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6EDE00 Offset: 0x6ED000 VA: 0x1806EDE00
	private void <Start>b__8_0(AudioSource player, float dt) { }
}

// Namespace: 
public class SkeldShipStatus : ShipStatus // TypeDefIndex: 1800
{
	// Methods

	// RVA: 0x6ED420 Offset: 0x6EC620 VA: 0x1806ED420
	public void .ctor() { }
}

// Namespace: 
public class StoreArmsTaskConsole : Console // TypeDefIndex: 1801
{
	// Fields
	public AudioClip useSound; // 0x48
	public Sprite[] Images; // 0x50
	public int usesPerStep; // 0x58
	private int timesUsed; // 0x5C

	// Methods

	// RVA: 0x6F24D0 Offset: 0x6F16D0 VA: 0x1806F24D0
	private PlayerTask FindTask(PlayerControl pc) { }

	// RVA: 0x6F25B0 Offset: 0x6F17B0 VA: 0x1806F25B0 Slot: 10
	public override void Use() { }

	// RVA: 0x6F2380 Offset: 0x6F1580 VA: 0x1806F2380 Slot: 11
	protected virtual void AfterUse(NormalPlayerTask task) { }

	// RVA: 0x6F2850 Offset: 0x6F1A50 VA: 0x1806F2850
	public void .ctor() { }
}

// Namespace: 
public class SurvCamera : MonoBehaviour // TypeDefIndex: 1802
{
	// Fields
	public string CamName; // 0x20
	public StringNames NewName; // 0x28
	public SpriteAnim[] Images; // 0x30
	public float CamSize; // 0x38
	public float CamAspect; // 0x3C
	public Vector3 Offset; // 0x40
	public AnimationClip OnAnim; // 0x50
	public AnimationClip OffAnim; // 0x58
	public StringNames camNameString; // 0x60

	// Methods

	// RVA: 0x6F2860 Offset: 0x6F1A60 VA: 0x1806F2860
	public void Awake() { }

	// RVA: 0x6F28B0 Offset: 0x6F1AB0 VA: 0x1806F28B0 Slot: 4
	public virtual void SetAnimation(bool on) { }

	// RVA: 0x6F2940 Offset: 0x6F1B40 VA: 0x1806F2940
	public void .ctor() { }
}

// Namespace: 
public class SystemConsole : MonoBehaviour, IUsable // TypeDefIndex: 1803
{
	// Fields
	public ImageNames useIcon; // 0x20
	public Vector2 SafePositionLocal; // 0x24
	public float usableDistance; // 0x2C
	public bool FreeplayOnly; // 0x30
	public bool onlyFromBelow; // 0x31
	public SpriteRenderer Image; // 0x38
	public Minigame MinigamePrefab; // 0x40

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x6F2D40 Offset: 0x6F1F40 VA: 0x1806F2D40
	public void Start() { }

	// RVA: 0x6F2BE0 Offset: 0x6F1DE0 VA: 0x1806F2BE0 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6F2960 Offset: 0x6F1B60 VA: 0x1806F2960 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6F2DC0 Offset: 0x6F1FC0 VA: 0x1806F2DC0 Slot: 9
	public void Use() { }

	// RVA: 0x6F2B40 Offset: 0x6F1D40 VA: 0x1806F2B40
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6F31C0 Offset: 0x6F23C0 VA: 0x1806F31C0
	public void .ctor() { }
}

// Namespace: 
public interface ISystemType // TypeDefIndex: 1804
{
	// Properties
	public abstract bool IsDirty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsDirty();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deteriorate(float deltaTime);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateSystem(PlayerControl player, MessageReader msgReader);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void MarkClean();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Serialize(MessageWriter writer, bool initialState);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Deserialize(MessageReader reader, bool initialState);
}

// Namespace: 
public enum SystemTypes // TypeDefIndex: 1805
{
	// Fields
	public byte value__; // 0x0
	public const SystemTypes Hallway = 0;
	public const SystemTypes Storage = 1;
	public const SystemTypes Cafeteria = 2;
	public const SystemTypes Reactor = 3;
	public const SystemTypes UpperEngine = 4;
	public const SystemTypes Nav = 5;
	public const SystemTypes Admin = 6;
	public const SystemTypes Electrical = 7;
	public const SystemTypes LifeSupp = 8;
	public const SystemTypes Shields = 9;
	public const SystemTypes MedBay = 10;
	public const SystemTypes Security = 11;
	public const SystemTypes Weapons = 12;
	public const SystemTypes LowerEngine = 13;
	public const SystemTypes Comms = 14;
	public const SystemTypes ShipTasks = 15;
	public const SystemTypes Doors = 16;
	public const SystemTypes Sabotage = 17;
	public const SystemTypes Decontamination = 18;
	public const SystemTypes Launchpad = 19;
	public const SystemTypes LockerRoom = 20;
	public const SystemTypes Laboratory = 21;
	public const SystemTypes Balcony = 22;
	public const SystemTypes Office = 23;
	public const SystemTypes Greenhouse = 24;
	public const SystemTypes Dropship = 25;
	public const SystemTypes Decontamination2 = 26;
	public const SystemTypes Outside = 27;
	public const SystemTypes Specimens = 28;
	public const SystemTypes BoilerRoom = 29;
	public const SystemTypes VaultRoom = 30;
	public const SystemTypes Cockpit = 31;
	public const SystemTypes Armory = 32;
	public const SystemTypes Kitchen = 33;
	public const SystemTypes ViewingDeck = 34;
	public const SystemTypes HallOfPortraits = 35;
	public const SystemTypes CargoBay = 36;
	public const SystemTypes Ventilation = 37;
	public const SystemTypes Showers = 38;
	public const SystemTypes Engine = 39;
	public const SystemTypes Brig = 40;
	public const SystemTypes MeetingRoom = 41;
	public const SystemTypes Records = 42;
	public const SystemTypes Lounge = 43;
	public const SystemTypes GapRoom = 44;
	public const SystemTypes MainHall = 45;
	public const SystemTypes Medical = 46;
	public const SystemTypes Decontamination3 = 47;
	public const SystemTypes Zipline = 48;
	public const SystemTypes MiningPit = 49;
	public const SystemTypes FishingDock = 50;
	public const SystemTypes RecRoom = 51;
	public const SystemTypes Lookout = 52;
	public const SystemTypes Beach = 53;
	public const SystemTypes Highlands = 54;
	public const SystemTypes Jungle = 55;
	public const SystemTypes SleepingQuarters = 56;
	public const SystemTypes MushroomMixupSabotage = 57;
	public const SystemTypes HeliSabotage = 58;
}

// Namespace: 
public static class SystemTypeHelpers // TypeDefIndex: 1806
{
	// Fields
	public static readonly SystemTypes[] AllTypes; // 0x0

	// Methods

	// RVA: 0x6F3270 Offset: 0x6F2470 VA: 0x1806F3270
	private static void .cctor() { }
}

// Namespace: 
public class TowelTaskConsole : AutoTaskConsole // TypeDefIndex: 1807
{
	// Methods

	// RVA: 0x6F3700 Offset: 0x6F2900 VA: 0x1806F3700 Slot: 11
	protected override void AfterUse(NormalPlayerTask task) { }

	// RVA: 0x6F3900 Offset: 0x6F2B00 VA: 0x1806F3900
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6F38F0 Offset: 0x6F2AF0 VA: 0x1806F38F0
	private bool <AfterUse>b__0_0(byte b) { }
}

// Namespace: 
public class TumbleBoxBehaviour : MonoBehaviour // TypeDefIndex: 1808
{
	// Fields
	public FloatRange BoxHeight; // 0x20
	public FloatRange shadowScale; // 0x28
	public SpriteRenderer Shadow; // 0x30
	public SpriteRenderer Box; // 0x38

	// Methods

	// RVA: 0x6F3FF0 Offset: 0x6F31F0 VA: 0x1806F3FF0
	public void FixedUpdate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Vent.<ExitVent>d__40 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1809
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl pc; // 0x20
	public Vent <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F5C30 Offset: 0x6F4E30 VA: 0x1806F5C30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F6060 Offset: 0x6F5260 VA: 0x1806F6060 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class Vent : MonoBehaviour, IUsable // TypeDefIndex: 1810
{
	// Fields
	private const float VIBRATION_INTENSITY = 0,4;
	private const float VIBRATION_FALLOFF_DISTANCE = 3,5;
	private const float VIBRATION_DURATION = 0,2;
	public static Vent currentVent; // 0x0
	public int Id; // 0x20
	public Vent Left; // 0x28
	public Vent Right; // 0x30
	public Vent Center; // 0x38
	public ButtonBehavior[] Buttons; // 0x40
	public GameObject[] CleaningIndicators; // 0x48
	public AnimationClip EnterVentAnim; // 0x50
	public AnimationClip ExitVentAnim; // 0x58
	public Vector3 Offset; // 0x60
	public float spreadAmount; // 0x6C
	public float spreadShift; // 0x70
	[SerializeField]
	private SpriteRenderer myRend; // 0x78
	[SerializeField]
	private SpriteAnim myAnim; // 0x80
	[SerializeField]
	private int numFramesUntilPlayerDisappearsOnEnter; // 0x88
	[SerializeField]
	private int numFramesUntilPlayerReappearsOnExit; // 0x8C
	[SerializeField]
	private GameObject additionalExitAnimation; // 0x90

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }
	public int NumFramesUntilPlayerDisappears { get; }
	private Vent[] NearbyVents { get; }

	// Methods

	// RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x6F8DC0 Offset: 0x6F7FC0 VA: 0x1806F8DC0 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int get_NumFramesUntilPlayerDisappears() { }

	// RVA: 0x6F8CA0 Offset: 0x6F7EA0 VA: 0x1806F8CA0
	private Vent[] get_NearbyVents() { }

	// RVA: 0x6F8490 Offset: 0x6F7690 VA: 0x1806F8490
	private void Start() { }

	// RVA: 0x6F7AF0 Offset: 0x6F6CF0 VA: 0x1806F7AF0
	public void SetButtons(bool enabled) { }

	// RVA: 0x6F6EB0 Offset: 0x6F60B0 VA: 0x1806F6EB0 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x6F82B0 Offset: 0x6F74B0 VA: 0x1806F82B0 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x6F7460 Offset: 0x6F6660 VA: 0x1806F7460
	public void ClickRight() { }

	// RVA: 0x6F73A0 Offset: 0x6F65A0 VA: 0x1806F73A0
	public void ClickLeft() { }

	// RVA: 0x6F72E0 Offset: 0x6F64E0 VA: 0x1806F72E0
	public void ClickCenter() { }

	// RVA: 0x6F8B10 Offset: 0x6F7D10 VA: 0x1806F8B10 Slot: 9
	public void Use() { }

	// RVA: 0x6F8980 Offset: 0x6F7B80 VA: 0x1806F8980
	public void UpdateArrows(VentilationSystem ventSystem) { }

	// RVA: 0x6F7520 Offset: 0x6F6720 VA: 0x1806F7520
	internal void EnterVent(PlayerControl pc) { }

	[IteratorStateMachine(typeof(Vent.<ExitVent>d__40))]
	// RVA: 0x6F77F0 Offset: 0x6F69F0 VA: 0x1806F77F0
	internal IEnumerator ExitVent(PlayerControl pc) { }

	// RVA: 0x6F8610 Offset: 0x6F7810 VA: 0x1806F8610
	private bool TryMoveToVent(Vent otherVent, out string error) { }

	// RVA: 0x6F85C0 Offset: 0x6F77C0 VA: 0x1806F85C0
	private void ToggleNeighborVentBeingCleaned(bool ventBeingCleaned, ButtonBehavior b, GameObject c) { }

	// RVA: 0x6F7860 Offset: 0x6F6A60 VA: 0x1806F7860
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6F8C70 Offset: 0x6F7E70 VA: 0x1806F8C70
	public void .ctor() { }
}

// Namespace: 
public class ShopBanner : MonoBehaviour // TypeDefIndex: 1811
{
	// Fields
	public SpriteRenderer sRenderer; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum ShowAdsState // TypeDefIndex: 1812
{
	// Fields
	public byte value__; // 0x0
	public const ShowAdsState NotAccepted = 0;
	public const ShowAdsState Personalized = 1;
	public const ShowAdsState NonPersonalized = 2;
	public const ShowAdsState Purchased = 4;
}

// Namespace: 
public class SinglePopHelp : MonoBehaviour // TypeDefIndex: 1813
{
	// Fields
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x20
	public UiElement DefaultButtonSelected; // 0x28
	public List<UiElement> ControllerSelectable; // 0x30
	public bool GridNav; // 0x38

	// Methods

	// RVA: 0x6ED780 Offset: 0x6EC980 VA: 0x1806ED780
	public void OnEnable() { }

	// RVA: 0x6ED710 Offset: 0x6EC910 VA: 0x1806ED710
	public void OnDisable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SlicedAspectScaler.<>c__DisplayClass4_0 // TypeDefIndex: 1814
{
	// Fields
	public float aspectDiff; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6CE0 Offset: 0x6F5EE0 VA: 0x1806F6CE0
	internal void <Start>b__0(AspectScaledAsset ob) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SlicedAspectScaler.<>c__DisplayClass6_0 // TypeDefIndex: 1815
{
	// Fields
	public float aspectDiff; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6F6CE0 Offset: 0x6F5EE0 VA: 0x1806F6CE0
	internal void <Update>b__0(AspectScaledAsset ob) { }
}

// Namespace: 
public class SlicedAspectScaler : MonoBehaviour // TypeDefIndex: 1816
{
	// Fields
	private const float NORMAL_ASPECT = 1,777;
	[SerializeField]
	private List<AspectScaledAsset> objectsToScale; // 0x20
	[SerializeField]
	private bool updateAlways; // 0x28
	private Camera parentCam; // 0x30

	// Methods

	// RVA: 0x6EDE90 Offset: 0x6ED090 VA: 0x1806EDE90
	private void Start() { }

	// RVA: 0x6EDE10 Offset: 0x6ED010 VA: 0x1806EDE10
	private void SetParentCam() { }

	// RVA: 0x6EDF80 Offset: 0x6ED180 VA: 0x1806EDF80
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SlideBar : PassiveUiElement // TypeDefIndex: 1817
{
	// Fields
	[Space(20)]
	public TextMeshPro Title; // 0x70
	public SpriteRenderer Bar; // 0x78
	public SpriteRenderer Dot; // 0x80
	public FloatRange Range; // 0x88
	public bool Vertical; // 0x90
	public float Value; // 0x94
	public UnityEvent OnValueChange; // 0x98
	private float sliderSegmentIncrement; // 0xA0

	// Properties
	public override bool HandleDrag { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool get_HandleDrag() { }

	// RVA: 0x6EE380 Offset: 0x6ED580 VA: 0x1806EE380 Slot: 13
	protected override void OnEnable() { }

	// RVA: 0x6EE270 Offset: 0x6ED470 VA: 0x1806EE270 Slot: 16
	protected override void OnDisable() { }

	// RVA: 0x6EE4B0 Offset: 0x6ED6B0 VA: 0x1806EE4B0 Slot: 22
	public override void ReceiveClickDrag(Vector2 dragDelta) { }

	// RVA: 0x6EE840 Offset: 0x6EDA40 VA: 0x1806EE840
	public void UpdateValue() { }

	// RVA: 0x6EE810 Offset: 0x6EDA10 VA: 0x1806EE810
	public void SetValue(float newValue) { }

	// RVA: 0x6EE190 Offset: 0x6ED390 VA: 0x1806EE190
	public void ControllerIncrease() { }

	// RVA: 0x6EE0B0 Offset: 0x6ED2B0 VA: 0x1806EE0B0
	public void ControllerDecrease() { }

	// RVA: 0x6EE4A0 Offset: 0x6ED6A0 VA: 0x1806EE4A0
	private void OnValidate() { }

	// RVA: 0x6EE700 Offset: 0x6ED900 VA: 0x1806EE700
	public void SetEnabledColors() { }

	// RVA: 0x6EE5F0 Offset: 0x6ED7F0 VA: 0x1806EE5F0
	public void SetDisabledColors() { }

	// RVA: 0x6EE910 Offset: 0x6EDB10 VA: 0x1806EE910
	public void .ctor() { }
}

// Namespace: 
public class AmbientSoundPlayer : MonoBehaviour // TypeDefIndex: 1818
{
	// Fields
	public AudioClip AmbientSound; // 0x20
	public Collider2D[] HitAreas; // 0x28
	public float MaxVolume; // 0x30
	public float DistanceFallOff; // 0x34
	public float FallOffRate; // 0x38
	[SerializeField]
	private bool useMuffled; // 0x3C

	// Methods

	// RVA: 0x6E1680 Offset: 0x6E0880 VA: 0x1806E1680
	public void Start() { }

	// RVA: 0x6E1290 Offset: 0x6E0490 VA: 0x1806E1290
	private void Dynamics(AudioSource source, float dt) { }

	// RVA: 0x6E1520 Offset: 0x6E0720 VA: 0x1806E1520
	public void OnDestroy() { }

	// RVA: 0x6E15D0 Offset: 0x6E07D0 VA: 0x1806E15D0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x6E18F0 Offset: 0x6E0AF0 VA: 0x1806E18F0
	public void .ctor() { }
}

// Namespace: 
public class CrossFader : ISoundPlayer // TypeDefIndex: 1819
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	public float MaxVolume; // 0x18
	[CompilerGenerated]
	private AudioSource <Player>k__BackingField; // 0x20
	public AudioClip target; // 0x28
	public float Duration; // 0x30
	private float timer; // 0x34
	private bool didSwitch; // 0x38

	// Properties
	public string Name { get; set; }
	public AudioSource Player { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 5
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	public AudioSource get_Player() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 7
	public void set_Player(AudioSource value) { }

	// RVA: 0x6E1A20 Offset: 0x6E0C20 VA: 0x1806E1A20 Slot: 8
	public void Update(float dt) { }

	// RVA: 0x6E1910 Offset: 0x6E0B10 VA: 0x1806E1910
	public void SetTarget(AudioClip clip) { }

	// RVA: 0x6E1B60 Offset: 0x6E0D60 VA: 0x1806E1B60
	public void .ctor() { }
}

// Namespace: 
public interface ISoundPlayer // TypeDefIndex: 1820
{
	// Properties
	public abstract string Name { get; set; }
	public abstract AudioSource Player { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Name(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AudioSource get_Player();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Player(AudioSource value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(float dt);
}

// Namespace: 
public sealed class DynamicSound.GetDynamicsFunction : MulticastDelegate // TypeDefIndex: 1821
{
	// Methods

	// RVA: 0x6E1D30 Offset: 0x6E0F30 VA: 0x1806E1D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(AudioSource source, float dt) { }

	// RVA: 0x6E1CA0 Offset: 0x6E0EA0 VA: 0x1806E1CA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AudioSource source, float dt, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class DynamicSound : ISoundPlayer // TypeDefIndex: 1822
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private AudioSource <Player>k__BackingField; // 0x18
	public DynamicSound.GetDynamicsFunction volumeFunc; // 0x20

	// Properties
	public string Name { get; set; }
	public AudioSource Player { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 5
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	public AudioSource get_Player() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 7
	public void set_Player(AudioSource value) { }

	// RVA: 0x6E1BE0 Offset: 0x6E0DE0 VA: 0x1806E1BE0 Slot: 8
	public void Update(float dt) { }

	// RVA: 0x6E1B80 Offset: 0x6E0D80 VA: 0x1806E1B80
	public void SetTarget(AudioClip clip, DynamicSound.GetDynamicsFunction volumeFunc) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class RaycastAmbientSoundPlayer : MonoBehaviour // TypeDefIndex: 1823
{
	// Fields
	public AudioClip AmbientSound; // 0x20
	public float AmbientVolume; // 0x28
	public float AmbientMaxDist; // 0x2C
	public float HitModifier; // 0x30
	public bool ShouldVibrate; // 0x34
	public static List<RaycastAmbientSoundPlayer> players; // 0x0
	public float ambientVolume; // 0x38
	public float t; // 0x3C
	private RaycastHit2D[] volumeBuffer; // 0x40

	// Methods

	// RVA: 0x6E7CA0 Offset: 0x6E6EA0 VA: 0x1806E7CA0
	private void OnEnable() { }

	// RVA: 0x6E7C20 Offset: 0x6E6E20 VA: 0x1806E7C20
	private void OnDisable() { }

	// RVA: 0x6E7D60 Offset: 0x6E6F60 VA: 0x1806E7D60
	public void Start() { }

	// RVA: 0x6E7930 Offset: 0x6E6B30 VA: 0x1806E7930
	private void GetAmbientSoundVolume(AudioSource player, float dt) { }

	// RVA: 0x6E7FC0 Offset: 0x6E71C0 VA: 0x1806E7FC0
	public void .ctor() { }

	// RVA: 0x6E7F50 Offset: 0x6E7150 VA: 0x1806E7F50
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6E7F40 Offset: 0x6E7140 VA: 0x1806E7F40
	private void <Start>b__10_0(AudioSource player, float dt) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SoundManager.<>c // TypeDefIndex: 1824
{
	// Fields
	public static readonly SoundManager.<>c <>9; // 0x0
	public static DynamicSound.GetDynamicsFunction <>9__41_0; // 0x8
	public static DynamicSound.GetDynamicsFunction <>9__43_0; // 0x10

	// Methods

	// RVA: 0x6F6DF0 Offset: 0x6F5FF0 VA: 0x1806F6DF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <PlayNamedSound>b__41_0(AudioSource a, float b) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <GetNamedAudioSource>b__43_0(AudioSource a, float b) { }
}

// Namespace: 
public class SoundManager : MonoBehaviour // TypeDefIndex: 1825
{
	// Fields
	private static SoundManager instance; // 0x0
	[SerializeField]
	private AudioMixer mixer; // 0x20
	[SerializeField]
	private AudioMixerGroup musicMixer; // 0x28
	[SerializeField]
	private AudioMixerGroup ambienceMixer; // 0x30
	[SerializeField]
	private AudioMixerGroup ambienceHighPassMixer; // 0x38
	[SerializeField]
	private AudioMixerGroup sfxMixer; // 0x40
	private Dictionary<AudioClip, AudioSource> allSources; // 0x48
	private List<ISoundPlayer> soundPlayers; // 0x50
	private static float musicVolume; // 0x8
	private static float sfxVolume; // 0xC
	private static float ambienceVolume; // 0x10

	// Properties
	public static SoundManager Instance { get; }
	public static float MusicVolume { get; }
	public static float AmbienceVolume { get; }
	public static float SfxVolume { get; }
	public AudioMixerGroup MusicChannel { get; }
	public AudioMixerGroup AmbienceChannel { get; }
	public AudioMixerGroup SfxChannel { get; }
	public AudioMixerGroup AmbienceHighPassChannel { get; }

	// Methods

	// RVA: 0x6F0D10 Offset: 0x6EFF10 VA: 0x1806F0D10
	public static SoundManager get_Instance() { }

	// RVA: 0x6F0E80 Offset: 0x6F0080 VA: 0x1806F0E80
	public static float get_MusicVolume() { }

	// RVA: 0x6F0CC0 Offset: 0x6EFEC0 VA: 0x1806F0CC0
	public static float get_AmbienceVolume() { }

	// RVA: 0x6F0ED0 Offset: 0x6F00D0 VA: 0x1806F0ED0
	public static float get_SfxVolume() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public AudioMixerGroup get_MusicChannel() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public AudioMixerGroup get_AmbienceChannel() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public AudioMixerGroup get_SfxChannel() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public AudioMixerGroup get_AmbienceHighPassChannel() { }

	// RVA: 0x6EFFC0 Offset: 0x6EF1C0 VA: 0x1806EFFC0
	private void Start() { }

	// RVA: 0x6EF3F0 Offset: 0x6EE5F0 VA: 0x1806EF3F0
	private void OnDestroy() { }

	// RVA: 0x6F0A50 Offset: 0x6EFC50 VA: 0x1806F0A50
	private void Update() { }

	// RVA: 0x6EF3E0 Offset: 0x6EE5E0 VA: 0x1806EF3E0
	private void OnAudioSettingsChanged() { }

	// RVA: 0x6F0850 Offset: 0x6EFA50 VA: 0x1806F0850
	private void UpdateChannelVolumes() { }

	// RVA: 0x6EE9C0 Offset: 0x6EDBC0 VA: 0x1806EE9C0
	private void ChangeMusicVolume(float volume) { }

	// RVA: 0x6EE930 Offset: 0x6EDB30 VA: 0x1806EE930
	private void ChangeAmbienceVolume(float volume) { }

	// RVA: 0x6EEA50 Offset: 0x6EDC50 VA: 0x1806EEA50
	private void ChangeSfxVolume(float volume) { }

	// RVA: 0x6EFE80 Offset: 0x6EF080 VA: 0x1806EFE80
	private void SetChannelVolume(float volume, ref float value, string channelName) { }

	// RVA: 0x6EEE40 Offset: 0x6EE040 VA: 0x1806EEE40
	private static float GetCalculatedVolume(float volume) { }

	// RVA: 0x6EF280 Offset: 0x6EE480 VA: 0x1806EF280
	public bool HasNamedSound(string name) { }

	// RVA: 0x6F0500 Offset: 0x6EF700 VA: 0x1806F0500
	public void StopNamedSound(string name) { }

	// RVA: 0x6F0640 Offset: 0x6EF840 VA: 0x1806F0640
	public void StopSound(AudioClip clip) { }

	// RVA: 0x6F01D0 Offset: 0x6EF3D0 VA: 0x1806F01D0
	public void StopAllSound() { }

	// RVA: 0x6EF760 Offset: 0x6EE960 VA: 0x1806EF760
	public AudioSource PlayNamedSound(string name, AudioClip sound, bool loop, AudioMixerGroup channel) { }

	// RVA: 0x6EEFF0 Offset: 0x6EE1F0 VA: 0x1806EEFF0
	public AudioSource GetNamedSfxSource(string name) { }

	// RVA: 0x6EEE60 Offset: 0x6EE060 VA: 0x1806EEE60
	public AudioSource GetNamedAudioSource(string name, AudioMixerGroup channel) { }

	// RVA: 0x6EF4B0 Offset: 0x6EE6B0 VA: 0x1806EF4B0
	public AudioSource PlayDynamicSound(string name, AudioClip clip, bool loop, DynamicSound.GetDynamicsFunction volumeFunc, AudioMixerGroup channel) { }

	// RVA: 0x6EEAE0 Offset: 0x6EDCE0 VA: 0x1806EEAE0
	public void CrossFadeSound(string name, AudioClip clip, float maxVolume, float duration = 1,5) { }

	// RVA: 0x6EF910 Offset: 0x6EEB10 VA: 0x1806EF910
	public AudioSource PlaySoundImmediate(AudioClip clip, bool loop, float volume = 1, float pitch = 1, AudioMixerGroup audioMixer) { }

	// RVA: 0x6EFF30 Offset: 0x6EF130 VA: 0x1806EFF30
	public bool SoundIsPlaying(AudioClip clip) { }

	// RVA: 0x6EFBD0 Offset: 0x6EEDD0 VA: 0x1806EFBD0
	public AudioSource PlaySound(AudioClip clip, bool loop, float volume = 1, AudioMixerGroup audioMixer) { }

	// RVA: 0x6EF180 Offset: 0x6EE380 VA: 0x1806EF180
	public static float GetSoundVolume(Vector2 soundPosition, Vector2 listenerPosition, float falloffStartDistance = 2, float falloffEndDistance = 6, float minVolume = 0) { }

	// RVA: 0x6F0C10 Offset: 0x6EFE10 VA: 0x1806F0C10
	public void .ctor() { }

	// RVA: 0x6F0BA0 Offset: 0x6EFDA0 VA: 0x1806F0BA0
	private static void .cctor() { }
}

// Namespace: 
public class SoundStarter : MonoBehaviour // TypeDefIndex: 1826
{
	// Fields
	public string Name; // 0x20
	public AudioClip SoundToPlay; // 0x28
	public bool StopAll; // 0x30
	[Range(0, 1)]
	public float Volume; // 0x34

	// Methods

	// RVA: 0x6F0F20 Offset: 0x6F0120 VA: 0x1806F0F20
	public void Awake() { }

	// RVA: 0x6F0FD0 Offset: 0x6F01D0 VA: 0x1806F0FD0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TagAmbientSoundPlayer.<Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1827
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TagAmbientSoundPlayer <>4__this; // 0x20
	private ContactFilter2D <filter>5__2; // 0x28
	private Collider2D[] <buffer>5__3; // 0x48
	private WaitForSeconds <wait>5__4; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F6720 Offset: 0x6F5920 VA: 0x1806F6720 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F69C0 Offset: 0x6F5BC0 VA: 0x1806F69C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class TagAmbientSoundPlayer : MonoBehaviour // TypeDefIndex: 1828
{
	// Fields
	public AudioClip AmbientSound; // 0x20
	public float MaxVolume; // 0x28
	public string TargetTag; // 0x30
	private float targetVolume; // 0x38

	// Methods

	// RVA: 0x6F34E0 Offset: 0x6F26E0 VA: 0x1806F34E0
	public void Start() { }

	// RVA: 0x6F3350 Offset: 0x6F2550 VA: 0x1806F3350
	private void Dynamics(AudioSource source, float dt) { }

	// RVA: 0x6F33D0 Offset: 0x6F25D0 VA: 0x1806F33D0
	public void OnDestroy() { }

	[IteratorStateMachine(typeof(TagAmbientSoundPlayer.<Run>d__7))]
	// RVA: 0x6F3480 Offset: 0x6F2680 VA: 0x1806F3480
	private IEnumerator Run() { }

	// RVA: 0x6F36B0 Offset: 0x6F28B0 VA: 0x1806F36B0
	public void .ctor() { }
}

// Namespace: 
public class TriggeredSound : MonoBehaviour // TypeDefIndex: 1829
{
	// Fields
	public AudioClip[] SoundToPlay; // 0x20
	public FloatRange PitchRange; // 0x28
	private AudioSource Player; // 0x30
	public float MaxVolume; // 0x38
	public float MaxDist; // 0x3C
	public float HitModifier; // 0x40
	private RaycastHit2D[] volumeBuffer; // 0x48

	// Methods

	// RVA: 0x6F3D10 Offset: 0x6F2F10 VA: 0x1806F3D10
	public void Start() { }

	// RVA: 0x6F3BE0 Offset: 0x6F2DE0 VA: 0x1806F3BE0
	public void PlaySound() { }

	// RVA: 0x6F3910 Offset: 0x6F2B10 VA: 0x1806F3910
	private void GetAmbientSoundVolume(AudioSource player) { }

	// RVA: 0x6F3F50 Offset: 0x6F3150 VA: 0x1806F3F50
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private struct StarGen.Stars // TypeDefIndex: 1830
{
	// Fields
	public float Size; // 0x0
	public float Rate; // 0x4
	public float PositionX; // 0x8
	public float PositionY; // 0xC
}

// Namespace: 
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class StarGen : MonoBehaviour // TypeDefIndex: 1831
{
	// Fields
	public int NumStars; // 0x20
	public float Length; // 0x24
	public float Width; // 0x28
	public float MaxStarRadius; // 0x2C
	public Vector2 Direction; // 0x30
	private Vector2 NormDir; // 0x38
	private Vector2 Tangent; // 0x40
	private float tanLen; // 0x48
	public FloatRange Rates; // 0x50
	[HideInInspector]
	private StarGen.Stars[] stars; // 0x58
	[HideInInspector]
	private Vector3[] verts; // 0x60
	[HideInInspector]
	private Mesh mesh; // 0x68

	// Methods

	// RVA: 0x6F19D0 Offset: 0x6F0BD0 VA: 0x1806F19D0
	public void Start() { }

	// RVA: 0x6F1F50 Offset: 0x6F1150 VA: 0x1806F1F50
	private void Update() { }

	// RVA: 0x6F17E0 Offset: 0x6F09E0 VA: 0x1806F17E0
	public void SetDirection(Vector2 dir) { }

	// RVA: 0x6F16C0 Offset: 0x6F08C0 VA: 0x1806F16C0
	public void RegenPositions() { }

	// RVA: 0x6F16A0 Offset: 0x6F08A0 VA: 0x1806F16A0
	private float OrthoDistance(float pointx, float pointy) { }

	// RVA: 0x6F22D0 Offset: 0x6F14D0 VA: 0x1806F22D0
	public void .ctor() { }
}

// Namespace: 
private enum SpinAnimator.States // TypeDefIndex: 1832
{
	// Fields
	public int value__; // 0x0
	public const SpinAnimator.States Visible = 0;
	public const SpinAnimator.States Invisible = 1;
	public const SpinAnimator.States Spinning = 2;
	public const SpinAnimator.States Pulsing = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class SpinAnimator.<CoDisappear>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1833
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SpinAnimator <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F4E20 Offset: 0x6F4020 VA: 0x1806F4E20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F4F20 Offset: 0x6F4120 VA: 0x1806F4F20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SpinAnimator : MonoBehaviour // TypeDefIndex: 1834
{
	// Fields
	public float Speed; // 0x20
	public GameObject inputGlyph; // 0x28
	private SpinAnimator.States curState; // 0x30

	// Methods

	// RVA: 0x6F12C0 Offset: 0x6F04C0 VA: 0x1806F12C0
	private void Update() { }

	// RVA: 0x6F0FE0 Offset: 0x6F01E0 VA: 0x1806F0FE0
	public void Appear() { }

	// RVA: 0x6F1120 Offset: 0x6F0320 VA: 0x1806F1120
	public void Disappear() { }

	[IteratorStateMachine(typeof(SpinAnimator.<CoDisappear>d__7))]
	// RVA: 0x6F10C0 Offset: 0x6F02C0 VA: 0x1806F10C0
	private IEnumerator CoDisappear() { }

	// RVA: 0x6F11D0 Offset: 0x6F03D0 VA: 0x1806F11D0
	public void StartPulse() { }

	// RVA: 0x6F11A0 Offset: 0x6F03A0 VA: 0x1806F11A0
	internal void Play() { }

	// RVA: 0x6F1330 Offset: 0x6F0530 VA: 0x1806F1330
	public void .ctor() { }
}

// Namespace: 
public class LogoAnimFinish : MonoBehaviour // TypeDefIndex: 1835
{
	// Fields
	public Action FinishLogoAnim; // 0x20

	// Methods

	// RVA: 0x6E5D30 Offset: 0x6E4F30 VA: 0x1806E5D30
	public void FinishAnim() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SplashErrorPopup : MonoBehaviour // TypeDefIndex: 1836
{
	// Fields
	[SerializeField]
	private TextMeshPro TitleText; // 0x20
	[SerializeField]
	private TextMeshPro InfoText; // 0x28
	[SerializeField]
	private AudioSource ShowSFX; // 0x30

	// Properties
	public bool IsShowing { get; }

	// Methods

	// RVA: 0x5595B0 Offset: 0x5587B0 VA: 0x1805595B0
	public bool get_IsShowing() { }

	// RVA: 0x6F1380 Offset: 0x6F0580 VA: 0x1806F1380
	public void Show(string titleText, string infoText) { }

	// RVA: 0x6F1340 Offset: 0x6F0540 VA: 0x1806F1340
	public void OnButtonPressed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SplashManager.<InitializeRefdata>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1837
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SplashManager <>4__this; // 0x20
	private float <t>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6F60A0 Offset: 0x6F52A0 VA: 0x1806F60A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6F6690 Offset: 0x6F5890 VA: 0x1806F6690 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SplashManager : MonoBehaviour // TypeDefIndex: 1838
{
	// Fields
	[SerializeField]
	private SplashErrorPopup errorPopup; // 0x20
	[SerializeField]
	private SceneChanger sceneChanger; // 0x28
	[SerializeField]
	private float minimumSecondsBeforeSceneChange; // 0x30
	[SerializeField]
	private LogoAnimFinish logoAnimFinish; // 0x38
	[SerializeField]
	private GameObject loadingObject; // 0x40
	private bool doneLoadingRefdata; // 0x48
	private bool startedSceneLoad; // 0x49
	private float startTime; // 0x4C

	// Methods

	// RVA: 0x6F14F0 Offset: 0x6F06F0 VA: 0x1806F14F0
	private void Start() { }

	// RVA: 0x6F1570 Offset: 0x6F0770 VA: 0x1806F1570
	private void Update() { }

	[IteratorStateMachine(typeof(SplashManager.<InitializeRefdata>d__10))]
	// RVA: 0x6F1490 Offset: 0x6F0690 VA: 0x1806F1490
	private IEnumerator InitializeRefdata() { }

	// RVA: 0x6F1440 Offset: 0x6F0640 VA: 0x1806F1440
	private void CheckLoadingRefData() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SpriteScroller : MonoBehaviour // TypeDefIndex: 1839
{
	// Fields
	public Renderer rend; // 0x20
	public float XRate; // 0x28
	public float YRate; // 0x2C

	// Methods

	// RVA: 0x6F15C0 Offset: 0x6F07C0 VA: 0x1806F15C0
	private void Update() { }

	// RVA: 0x569F70 Offset: 0x569170 VA: 0x180569F70
	public void .ctor() { }
}

// Namespace: 
public class LegacyStatsManager.LegacyStats // TypeDefIndex: 1840
{
	// Fields
	public byte version; // 0x10
	public float FastestCrewmateWin_HideAndSeek; // 0x14
	public float FastestImpostorWin_HideAndSeek; // 0x18
	public readonly Dictionary<StringNames, uint> gameplayStats; // 0x20
	public readonly Dictionary<GameOverReason, uint> winReasons; // 0x28
	public readonly Dictionary<GameOverReason, uint> loseReasons; // 0x30
	public readonly Dictionary<GameOverReason, uint> drawReasons; // 0x38
	public readonly Dictionary<MapNames, uint> mapWins; // 0x40
	public readonly Dictionary<RoleTypes, uint> roleWins; // 0x48
	private static readonly List<StringNames> SimpleStats; // 0x0

	// Methods

	// RVA: 0x6E4DD0 Offset: 0x6E3FD0 VA: 0x1806E4DD0
	public void MigrateFromPlayerStats2ToPlayerStats3(BinaryReader reader) { }

	// RVA: 0x6E52C0 Offset: 0x6E44C0 VA: 0x1806E52C0
	public void Reset() { }

	// RVA: 0x6E4B20 Offset: 0x6E3D20 VA: 0x1806E4B20
	public void Deserialize(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void ReadEnumDict<T>(Dictionary<T, uint> enumDict, BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACE6A0 Offset: 0xACD8A0 VA: 0x180ACE6A0
	|-LegacyStatsManager.LegacyStats.ReadEnumDict<Int32Enum>
	|
	|-RVA: 0xACE950 Offset: 0xACDB50 VA: 0x180ACE950
	|-LegacyStatsManager.LegacyStats.ReadEnumDict<UInt16Enum>
	|
	|-RVA: 0xACE290 Offset: 0xACD490 VA: 0x180ACE290
	|-LegacyStatsManager.LegacyStats.ReadEnumDict<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x6E5380 Offset: 0x6E4580 VA: 0x1806E5380
	private void TryReadFloat(ref float value, BinaryReader reader) { }

	// RVA: 0x6E5BC0 Offset: 0x6E4DC0 VA: 0x1806E5BC0
	public void .ctor() { }

	// RVA: 0x6E5440 Offset: 0x6E4640 VA: 0x1806E5440
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct LegacyStatsManager.<>c__DisplayClass16_0 // TypeDefIndex: 1841
{
	// Fields
	public Dictionary<StatID, uint> statsToIngest; // 0x0
	public LegacyStatsManager <>4__this; // 0x8
}

// Namespace: 
public class LegacyStatsManager // TypeDefIndex: 1842
{
	// Fields
	public static LegacyStatsManager Instance; // 0x0
	public const string LEGACY_STATS_FILENAME = "playerStats3";
	public const string LEGACY_PREVIOUS_STATS_FILENAME = "playerStats2";
	private const byte FINAL_LEGACY_STATS_MANAGER_VERISON = 6;
	private const byte StatsVersion = 6;
	private static string playerStats2Path; // 0x8
	private static string playerStats3Path; // 0x10
	protected LegacyStatsManager.LegacyStats stats; // 0x10
	private bool loadedStats; // 0x18

	// Properties
	private LegacyStatsManager.LegacyStats TheStats { get; }

	// Methods

	// RVA: 0x6E4AF0 Offset: 0x6E3CF0 VA: 0x1806E4AF0
	private LegacyStatsManager.LegacyStats get_TheStats() { }

	// RVA: 0x6C3D60 Offset: 0x6C2F60 VA: 0x1806C3D60
	public void ForceLoadStats() { }

	// RVA: 0x6E29A0 Offset: 0x6E1BA0 VA: 0x1806E29A0
	public static bool Exists() { }

	// RVA: 0x6E2A20 Offset: 0x6E1C20 VA: 0x1806E2A20 Slot: 4
	protected virtual void LoadStats() { }

	// RVA: 0x6E4060 Offset: 0x6E3260 VA: 0x1806E4060
	private void ResetStatDisplay() { }

	// RVA: 0x6E30A0 Offset: 0x6E22A0 VA: 0x1806E30A0
	public void MigrateToPlayerStatsData(Dictionary<StatID, uint> statsToIngest) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6E49B0 Offset: 0x6E3BB0 VA: 0x1806E49B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6E4650 Offset: 0x6E3850 VA: 0x1806E4650
	private void <MigrateToPlayerStatsData>g__SetIngestValue|16_0(StatID stat, uint value, ref LegacyStatsManager.<>c__DisplayClass16_0 ) { }

	[CompilerGenerated]
	// RVA: 0x6E4140 Offset: 0x6E3340 VA: 0x1806E4140
	private void <MigrateToPlayerStatsData>g__MigrateStatToIngest|16_1(StringNames stringName, StatID stat, ref LegacyStatsManager.<>c__DisplayClass16_0 ) { }
}

// Namespace: 
public enum StatID // TypeDefIndex: 1843
{
	// Fields
	public int value__; // 0x0
	public const StatID Invalid = -1;
	public const StatID None = 0;
	public const StatID GamesStarted = 1;
	public const StatID GamesFinished = 2;
	public const StatID GamesAsImpostor = 3;
	public const StatID GamesAsCrewmate = 4;
	public const StatID BodiesReported = 5;
	public const StatID EmergenciesCalled = 6;
	public const StatID SabotagesFixed = 7;
	public const StatID TasksCompleted = 8;
	public const StatID AllTasksCompleted = 9;
	public const StatID CrewmateStreak = 10;
	public const StatID ImpostorKills = 11;
	public const StatID TimesMurdered = 12;
	public const StatID TimesEjected = 13;
	public const StatID TimesPettedPet = 14;
	public const StatID HideAndSeek_GamesCrewmateSurvived = 15;
	public const StatID HideAndSeek_TimesVented = 16;
	public const StatID HideAndSeek_ImpostorKills = 17;
	public const StatID HideAndSeek_FastestCrewmateWin = 18;
	public const StatID HideAndSeek_FastestImpostorWin = 19;
	public const StatID Map_Skeld_Wins = 20;
	public const StatID Map_Polus_Wins = 21;
	public const StatID Map_MiraHQ_Wins = 22;
	public const StatID Map_Airship_Wins = 23;
	public const StatID Map_Fungle_Wins = 24;
	public const StatID Role_Crewmate_Wins = 25;
	public const StatID Role_Impostor_Wins = 26;
	public const StatID Role_Engineer_Wins = 27;
	public const StatID Role_Engineer_Vents = 28;
	public const StatID Role_GuardianAngel_Wins = 29;
	public const StatID Role_GuardianAngel_CrewmatesProtected = 30;
	public const StatID Role_Scientist_Wins = 31;
	public const StatID Role_Scientist_ChargesGained = 32;
	public const StatID Role_Shapeshifter_Wins = 33;
	public const StatID Role_Shapeshifter_ShiftedKills = 34;
	public const StatID Role_Noisemaker_Wins = 35;
	public const StatID Role_Phantom_Wins = 36;
	public const StatID Role_Tracker_Wins = 37;
	public const StatID GameResult_CrewmatesByVote_Wins = 38;
	public const StatID GameResult_CrewmatesByVote_Losses = 39;
	public const StatID GameResult_CrewmatesByVote_Draws = 40;
	public const StatID GameResult_CrewmatesByTask_Wins = 41;
	public const StatID GameResult_CrewmatesByTask_Losses = 42;
	public const StatID GameResult_CrewmatesByTask_Draws = 43;
	public const StatID GameResult_ImpostorsByVote_Wins = 44;
	public const StatID GameResult_ImpostorsByVote_Losses = 45;
	public const StatID GameResult_ImpostorsByVote_Draws = 46;
	public const StatID GameResult_ImpostorsByKill_Wins = 47;
	public const StatID GameResult_ImpostorsByKill_Losses = 48;
	public const StatID GameResult_ImpostorsByKill_Draws = 49;
	public const StatID GameResult_ImpostorsBySabotage_Wins = 50;
	public const StatID GameResult_ImpostorsBySabotage_Losses = 51;
	public const StatID GameResult_ImpostorsBySabotage_Draws = 52;
	public const StatID GameResult_ImpostorDisconnect_Wins = 53;
	public const StatID GameResult_ImpostorDisconnect_Losses = 54;
	public const StatID GameResult_ImpostorDisconnect_Draws = 55;
	public const StatID GameResult_CrewmateDisconnect_Wins = 56;
	public const StatID GameResult_CrewmateDisconnect_Losses = 57;
	public const StatID GameResult_CrewmateDisconnect_Draws = 58;
	public const StatID GameResult_HideAndSeek_CrewmatesByTimer_Wins = 59;
	public const StatID GameResult_HideAndSeek_CrewmatesByTimer_Losses = 60;
	public const StatID GameResult_HideAndSeek_CrewmatesByTimer_Draws = 61;
	public const StatID GameResult_HideAndSeek_ImpostorsByKills_Wins = 62;
	public const StatID GameResult_HideAndSeek_ImpostorsByKills_Losses = 63;
	public const StatID GameResult_HideAndSeek_ImpostorsByKills_Draws = 64;
	public const StatID Role_Viper_BodiesDissolved = 80;
	public const StatID Role_Viper_Wins = 81;
	public const StatID Role_Detective_CrewmatesQuestioned = 90;
	public const StatID Role_Detective_CasesFilled = 91;
	public const StatID Role_Detective_Wins = 92;
}

// Namespace: 
public enum GameResultStat // TypeDefIndex: 1844
{
	// Fields
	public int value__; // 0x0
	public const GameResultStat Wins = 0;
	public const GameResultStat Losses = 1;
	public const GameResultStat Draws = 2;
}

// Namespace: 
public enum RoleStat // TypeDefIndex: 1845
{
	// Fields
	public int value__; // 0x0
	public const RoleStat Wins = 0;
}

// Namespace: 
public enum MapStat // TypeDefIndex: 1846
{
	// Fields
	public int value__; // 0x0
	public const MapStat Wins = 0;
}

// Namespace: 
public static class StatIDUtilities // TypeDefIndex: 1847
{
	// Fields
	private const string EOS_STAT_PREFIX = "PlayerStat_";

	// Methods

	// RVA: 0x700AC0 Offset: 0x6FFCC0 VA: 0x180700AC0
	public static bool TryGetStatID(out StatID stat, object[] search) { }

	// RVA: 0x700920 Offset: 0x6FFB20 VA: 0x180700920
	public static StatID GetStatID(object[] search) { }

	// RVA: 0x7003D0 Offset: 0x6FF5D0 VA: 0x1807003D0
	public static StatID GetMapStatID(MapNames map, MapStat stat) { }

	// RVA: 0x700550 Offset: 0x6FF750 VA: 0x180700550
	public static StatID GetRoleStatID(RoleTypes role, RoleStat stat) { }

	// RVA: 0x7006F0 Offset: 0x6FF8F0 VA: 0x1807006F0
	public static StatID GetRoleStatID(RoleTypes role, string stat) { }

	// RVA: 0x700250 Offset: 0x6FF450 VA: 0x180700250
	public static StatID GetGameResultStatID(GameOverReason reason, GameResultStat stat) { }

	// RVA: 0x700A50 Offset: 0x6FFC50 VA: 0x180700A50
	public static string GetStatNameForEOS(StatID stat) { }

	// RVA: 0x700850 Offset: 0x6FFA50 VA: 0x180700850
	public static StatID GetStatIDFromEOSStatName(string name) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StatsPopup.<>c // TypeDefIndex: 1848
{
	// Fields
	public static readonly StatsPopup.<>c <>9; // 0x0
	public static Func<UiElement, bool> <>9__6_0; // 0x8
	public static Func<UiElement, UiElement> <>9__6_1; // 0x10

	// Methods

	// RVA: 0x70EEF0 Offset: 0x70E0F0 VA: 0x18070EEF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E550 Offset: 0x70D750 VA: 0x18070E550
	internal bool <OnEnable>b__6_0(UiElement x) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	internal UiElement <OnEnable>b__6_1(UiElement x) { }
}

// Namespace: 
public class StatsPopup : MonoBehaviour // TypeDefIndex: 1849
{
	// Fields
	public TextMeshPro StatsText; // 0x20
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x28
	[SerializeField]
	private UiElement[] SelectableButtons; // 0x30
	private static readonly Dictionary<StatID, StringNames> BaseStatsToShow; // 0x0
	private static readonly Dictionary<StatID, StringNames> RoleSpecificStatsToShow; // 0x8

	// Methods

	// RVA: 0x701680 Offset: 0x700880 VA: 0x180701680
	private void OnDisable() { }

	// RVA: 0x7016F0 Offset: 0x7008F0 VA: 0x1807016F0
	private void OnEnable() { }

	// RVA: 0x700BF0 Offset: 0x6FFDF0 VA: 0x180700BF0
	private static void AppendStat(StringBuilder str, StringNames statName, object stat, object[] additionalTranslationParams) { }

	// RVA: 0x700D40 Offset: 0x6FFF40 VA: 0x180700D40
	public void DisplayGameStats() { }

	// RVA: 0x701110 Offset: 0x700310 VA: 0x180701110
	public void DisplayRoleStats() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x701970 Offset: 0x700B70 VA: 0x180701970
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EmptyGarbageMinigame.<>c // TypeDefIndex: 1850
{
	// Fields
	public static readonly EmptyGarbageMinigame.<>c <>9; // 0x0
	public static Func<SpriteRenderer, bool> <>9__27_0; // 0x8
	public static Func<SpriteRenderer, bool> <>9__27_1; // 0x10

	// Methods

	// RVA: 0x70EFB0 Offset: 0x70E1B0 VA: 0x18070EFB0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E850 Offset: 0x70DA50 VA: 0x18070E850
	internal bool <Update>b__27_0(SpriteRenderer o) { }

	// RVA: 0x70E8A0 Offset: 0x70DAA0 VA: 0x18070E8A0
	internal bool <Update>b__27_1(SpriteRenderer o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmptyGarbageMinigame.<AnimateObjects>d__29 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1851
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EmptyGarbageMinigame <>4__this; // 0x20
	private Vector3 <pos>5__2; // 0x28
	private float <t>5__3; // 0x34

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70CDA0 Offset: 0x70BFA0 VA: 0x18070CDA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70CFF0 Offset: 0x70C1F0 VA: 0x18070CFF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmptyGarbageMinigame.<PopObjects>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1852
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EmptyGarbageMinigame <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70E410 Offset: 0x70D610 VA: 0x18070E410 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70E4F0 Offset: 0x70D6F0 VA: 0x18070E4F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class EmptyGarbageMinigame : Minigame // TypeDefIndex: 1853
{
	// Fields
	private const float GrinderVolume = 0,8;
	public FloatRange HandleRange; // 0x88
	public Vector2Range SpawnRange; // 0x90
	public Collider2D Blocker; // 0xA0
	public AreaEffector2D Popper; // 0xA8
	public Collider2D Handle; // 0xB0
	public SpriteRenderer Bars; // 0xB8
	public Transform VibratePivot; // 0xC0
	private Controller controller; // 0xC8
	private bool finished; // 0xD0
	public int NumObjects; // 0xD4
	private SpriteRenderer[] Objects; // 0xD8
	public SpriteRenderer[] GarbagePrefabs; // 0xE0
	public SpriteRenderer[] LeafPrefabs; // 0xE8
	public SpriteRenderer[] SpecialObjectPrefabs; // 0xF0
	public AudioClip LeverDown; // 0xF8
	public AudioClip LeverUp; // 0x100
	public AudioClip GrinderStart; // 0x108
	public AudioClip GrinderLoop; // 0x110
	public AudioClip GrinderEnd; // 0x118
	private TouchpadBehavior touchpad; // 0x120
	private bool hadInput; // 0x128
	private float leverInput; // 0x12C
	private Coroutine popCoroutine; // 0x130
	private Coroutine animateCoroutine; // 0x138

	// Methods

	// RVA: 0x6FA340 Offset: 0x6F9540 VA: 0x1806FA340 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6FAAD0 Offset: 0x6F9CD0 VA: 0x1806FAAD0
	private void StopCoroutines() { }

	// RVA: 0x6FAB30 Offset: 0x6F9D30 VA: 0x1806FAB30
	public void Update() { }

	[IteratorStateMachine(typeof(EmptyGarbageMinigame.<PopObjects>d__28))]
	// RVA: 0x6FAA70 Offset: 0x6F9C70 VA: 0x1806FAA70
	private IEnumerator PopObjects() { }

	[IteratorStateMachine(typeof(EmptyGarbageMinigame.<AnimateObjects>d__29))]
	// RVA: 0x6FA2E0 Offset: 0x6F94E0 VA: 0x1806FA2E0
	private IEnumerator AnimateObjects() { }

	// RVA: 0x6FA8D0 Offset: 0x6F9AD0 VA: 0x1806FA8D0 Slot: 6
	public override void Close() { }

	// RVA: 0x6FB7E0 Offset: 0x6FA9E0 VA: 0x1806FB7E0
	public void .ctor() { }
}

// Namespace: 
public class GarbageBehaviour : MonoBehaviour // TypeDefIndex: 1854
{
	// Methods

	// RVA: 0x6FB890 Offset: 0x6FAA90 VA: 0x1806FB890
	public void FixedUpdate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WaterPlantsGame.<CoGrowPlant>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1855
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WaterPlantsGame <>4__this; // 0x20
	public int num; // 0x28
	private SpriteRenderer <plant>5__2; // 0x30
	private float <timer>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70D030 Offset: 0x70C230 VA: 0x18070D030 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70D5C0 Offset: 0x70C7C0 VA: 0x18070D5C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WaterPlantsGame.<CoPickWaterCan>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1856
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WaterPlantsGame <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70D600 Offset: 0x70C800 VA: 0x18070D600 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70DA80 Offset: 0x70CC80 VA: 0x18070DA80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class WaterPlantsGame : Minigame // TypeDefIndex: 1857
{
	// Fields
	public GameObject stage1; // 0x88
	public GameObject stage2; // 0x90
	public AudioClip CanGrabSound; // 0x98
	public PassiveButton WaterCan; // 0xA0
	public SpriteRenderer[] Plants; // 0xA8
	public AudioClip WaterPlantSound; // 0xB0
	public AudioClip[] PlantGrowSounds; // 0xB8
	public AudioClip[] PlantFinishedSounds; // 0xC0
	public TextMeshPro FloatText; // 0xC8
	public Transform[] Locations; // 0xD0
	public Transform selectorObject; // 0xD8
	public GameObject grabCanSubObject; // 0xE0
	public GameObject holdingCanSubObject; // 0xE8
	public GameObject waterPlantsSubObject; // 0xF0
	private Controller c; // 0xF8
	public SpriteRenderer[] playerHandObjects; // 0x100
	public ParticleSystem waterParticles; // 0x108
	public GameObject greenDot; // 0x110

	// Methods

	// RVA: 0x70FD70 Offset: 0x70EF70 VA: 0x18070FD70
	private bool Watered(int x) { }

	// RVA: 0x70FDB0 Offset: 0x70EFB0 VA: 0x18070FDB0
	private void Watered(int x, bool b) { }

	// RVA: 0x70F1C0 Offset: 0x70E3C0 VA: 0x18070F1C0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x70F930 Offset: 0x70EB30 VA: 0x18070F930
	private void Update() { }

	// RVA: 0x70F7C0 Offset: 0x70E9C0 VA: 0x18070F7C0
	public void PickWaterCan() { }

	[IteratorStateMachine(typeof(WaterPlantsGame.<CoPickWaterCan>d__23))]
	// RVA: 0x70F760 Offset: 0x70E960 VA: 0x18070F760
	private IEnumerator CoPickWaterCan() { }

	// RVA: 0x70FAF0 Offset: 0x70ECF0 VA: 0x18070FAF0
	public void WaterPlant(int num) { }

	[IteratorStateMachine(typeof(WaterPlantsGame.<CoGrowPlant>d__25))]
	// RVA: 0x70F6F0 Offset: 0x70E8F0 VA: 0x18070F6F0
	private IEnumerator CoGrowPlant(int num) { }

	// RVA: 0x70FDF0 Offset: 0x70EFF0 VA: 0x18070FDF0
	public void .ctor() { }
}

// Namespace: 
public class BoughtAdsBuyable : Object, IBuyable // TypeDefIndex: 1858
{
	// Properties
	public string ProdId { get; }
	public int BeanCost { get; }
	public int StarCost { get; }
	public string EpicId { get; }
	public bool PaidOnMobile { get; }
	public LimitedTimeStartEnd LimitedTimeAvailable { get; }

	// Methods

	// RVA: 0x6F8E80 Offset: 0x6F8080 VA: 0x1806F8E80 Slot: 4
	public string get_ProdId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public int get_BeanCost() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public int get_StarCost() { }

	// RVA: 0x6F8E30 Offset: 0x6F8030 VA: 0x1806F8E30
	public string get_EpicId() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public bool get_PaidOnMobile() { }

	// RVA: 0x6F8E60 Offset: 0x6F8060 VA: 0x1806F8E60 Slot: 8
	public LimitedTimeStartEnd get_LimitedTimeAvailable() { }

	// RVA: 0x6F8DE0 Offset: 0x6F7FE0 VA: 0x1806F8DE0
	public void .ctor() { }
}

// Namespace: 
public enum BundleSizes // TypeDefIndex: 1859
{
	// Fields
	public int value__; // 0x0
	public const BundleSizes Wide = 0;
	public const BundleSizes Large = 1;
}

// Namespace: 
public class BundleData : ScriptableObject, IBuyable // TypeDefIndex: 1860
{
	// Fields
	public const string TranslationPrefix = "Bundle.";
	public BundleSizes BundleSize; // 0x18
	public string productId; // 0x20
	public int beanCost; // 0x28
	public int starCost; // 0x2C
	public CosmeticData[] cosmetics; // 0x30
	public Sprite StoreImage; // 0x38
	public bool NotInStore; // 0x40
	public bool Free; // 0x41
	public bool paidOnMobile; // 0x42
	[SerializeField]
	private LimitedTimeStartEnd limitedTime; // 0x44

	// Properties
	public string ProdId { get; }
	public int BeanCost { get; }
	public int StarCost { get; }
	public bool PaidOnMobile { get; }
	public LimitedTimeStartEnd LimitedTimeAvailable { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public string get_ProdId() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 5
	public int get_BeanCost() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 6
	public int get_StarCost() { }

	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0 Slot: 7
	public bool get_PaidOnMobile() { }

	// RVA: 0x6F90A0 Offset: 0x6F82A0 VA: 0x1806F90A0 Slot: 8
	public LimitedTimeStartEnd get_LimitedTimeAvailable() { }

	// RVA: 0x6F8FF0 Offset: 0x6F81F0 VA: 0x1806F8FF0
	public string GetItemName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string GetPurchasingProductId() { }

	// RVA: 0x6F8EB0 Offset: 0x6F80B0 VA: 0x1806F8EB0
	public string[] GetCosmeticIDs() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EGSPurchasingModule.<>c__DisplayClass6_0 // TypeDefIndex: 1861
{
	// Fields
	public EGSPurchasingModule <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70EAA0 Offset: 0x70DCA0 VA: 0x18070EAA0
	internal void <Purchase>b__0(ref CheckoutCallbackInfo data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EGSPurchasingModule.<>c__DisplayClass8_0 // TypeDefIndex: 1862
{
	// Fields
	public EpicAccountId localUserID; // 0x10
	public EcomInterface ecom; // 0x18
	public List<ProductDescription> output; // 0x20
	public EGSPurchasingModule <>4__this; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70EB40 Offset: 0x70DD40 VA: 0x18070EB40
	internal void <RetrieveProducts>b__0(ref QueryOffersCallbackInfo data) { }
}

// Namespace: 
internal class EGSPurchasingModule : IPurchasingModule, IStore // TypeDefIndex: 1863
{
	// Fields
	public const string Name = "EGS";
	private IStoreCallback storeCallback; // 0x10
	private ReadOnlyCollection<ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x6F9520 Offset: 0x6F8720 VA: 0x1806F9520 Slot: 4
	public void Configure(IPurchasingBinder binder) { }

	// RVA: 0x6F9600 Offset: 0x6F8800 VA: 0x1806F9600 Slot: 8
	public void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x6F9660 Offset: 0x6F8860 VA: 0x1806F9660 Slot: 5
	public void Initialize(IStoreCallback callback) { }

	// RVA: 0x6F9910 Offset: 0x6F8B10 VA: 0x1806F9910 Slot: 7
	public void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x6F96D0 Offset: 0x6F88D0 VA: 0x1806F96D0
	private void OnPurchaseCallback(CheckoutCallbackInfo data, ProductDefinition product) { }

	// RVA: 0x6F9B90 Offset: 0x6F8D90 VA: 0x1806F9B90 Slot: 6
	public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productsDefinitions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class EpicPurchasingModule // TypeDefIndex: 1864
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RestorePurchases.<CoRestoreiOSPurchases>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1865
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RestorePurchases <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70DAC0 Offset: 0x70CCC0 VA: 0x18070DAC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70DDD0 Offset: 0x70CFD0 VA: 0x18070DDD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class RestorePurchases : MonoBehaviour // TypeDefIndex: 1866
{
	// Fields
	[SerializeField]
	private InfoTextBox errorDisplay; // 0x20
	private bool isRestoring; // 0x28

	// Methods

	// RVA: 0x700020 Offset: 0x6FF220 VA: 0x180700020
	public void RestoreiOSPurchases() { }

	[IteratorStateMachine(typeof(RestorePurchases.<CoRestoreiOSPurchases>d__3))]
	// RVA: 0x6FFFC0 Offset: 0x6FF1C0 VA: 0x1806FFFC0
	private IEnumerator CoRestoreiOSPurchases() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu]
public class StarBundle : ScriptableObject, IBuyable // TypeDefIndex: 1867
{
	// Fields
	public const string TranslationPrefix = "Bundle.";
	public string epicId; // 0x18
	public string productId; // 0x20
	public string SteamAppId; // 0x28
	public string SteamPrice; // 0x30
	public float price; // 0x38
	public int starAmount; // 0x3C
	public Sprite StoreImage; // 0x40
	public Sprite StoreBackImage; // 0x48

	// Properties
	public string ProdId { get; }
	public int BeanCost { get; }
	public int StarCost { get; }
	public string EpicId { get; }
	public bool PaidOnMobile { get; }
	public LimitedTimeStartEnd LimitedTimeAvailable { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public string get_ProdId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public int get_BeanCost() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public int get_StarCost() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_EpicId() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_PaidOnMobile() { }

	// RVA: 0x6F8E60 Offset: 0x6F8060 VA: 0x1806F8E60 Slot: 8
	public LimitedTimeStartEnd get_LimitedTimeAvailable() { }

	// RVA: 0x700090 Offset: 0x6FF290 VA: 0x180700090
	public string GetItemName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string GetPurchasingProductId() { }

	// RVA: 0x700210 Offset: 0x6FF410 VA: 0x180700210
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreManager.<>c__DisplayClass16_0 // TypeDefIndex: 1868
{
	// Fields
	public StarBundle starBundle; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70EA60 Offset: 0x70DC60 VA: 0x18070EA60
	internal bool <CoWaitForStarPurchaseValidation>b__0(Product x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreManager.<CoWaitForHeadlessStarPurchaseValidation>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1869
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CompletionToken<PurchaseStates> queryDone; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70DE10 Offset: 0x70D010 VA: 0x18070DE10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70DED0 Offset: 0x70D0D0 VA: 0x18070DED0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreManager.<CoWaitForStarPurchaseValidation>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1870
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CompletionToken<PurchaseStates> queryDone; // 0x20
	public PurchaseButton button; // 0x28
	public StoreManager <>4__this; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x70DF10 Offset: 0x70D110 VA: 0x18070DF10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x70E3D0 Offset: 0x70D5D0 VA: 0x18070E3D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class StoreManager : DestroyableSingleton<StoreManager>, IStoreListener // TypeDefIndex: 1871
{
	// Fields
	public CompletionToken<PurchaseStates> starPurchaseStateQuery; // 0x28
	private Product[] allProducts; // 0x30
	public bool FinishedInitializationFlow; // 0x38
	private readonly Logger logger; // 0x40
	private IStoreController controller; // 0x48
	private IExtensionProvider extensions; // 0x50
	private bool initialized; // 0x58

	// Methods

	// RVA: 0x702120 Offset: 0x701320 VA: 0x180702120
	public void Initialize() { }

	// RVA: 0x702B40 Offset: 0x701D40 VA: 0x180702B40 Slot: 9
	public void OnInitialized(IStoreController controller, IExtensionProvider extensions) { }

	// RVA: 0x7029D0 Offset: 0x701BD0 VA: 0x1807029D0 Slot: 10
	public void OnInitializeFailed(InitializationFailureReason error) { }

	// RVA: 0x702A70 Offset: 0x701C70 VA: 0x180702A70 Slot: 6
	public void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x702DA0 Offset: 0x701FA0 VA: 0x180702DA0
	public void ProcessOldReceiptsRestore() { }

	// RVA: 0x702EF0 Offset: 0x7020F0 VA: 0x180702EF0
	public void ProcessOldReceipts() { }

	// RVA: 0x702710 Offset: 0x701910 VA: 0x180702710
	public void InitiateStorePurchaseStar(PurchaseButton button) { }

	// RVA: 0x7025D0 Offset: 0x7017D0 VA: 0x1807025D0
	private void InitiateStoreHeadlessStarPurchase(PurchaseEventArgs purchaseEventArgs) { }

	// RVA: 0x7034D0 Offset: 0x7026D0 VA: 0x1807034D0 Slot: 7
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	[IteratorStateMachine(typeof(StoreManager.<CoWaitForStarPurchaseValidation>d__16))]
	// RVA: 0x7020A0 Offset: 0x7012A0 VA: 0x1807020A0
	private IEnumerator CoWaitForStarPurchaseValidation(CompletionToken<PurchaseStates> queryDone, PurchaseButton button) { }

	[IteratorStateMachine(typeof(StoreManager.<CoWaitForHeadlessStarPurchaseValidation>d__17))]
	// RVA: 0x702040 Offset: 0x701240 VA: 0x180702040
	private IEnumerator CoWaitForHeadlessStarPurchaseValidation(CompletionToken<PurchaseStates> queryDone) { }

	// RVA: 0x702C30 Offset: 0x701E30 VA: 0x180702C30 Slot: 8
	public void OnPurchaseFailed(Product i, PurchaseFailureReason error) { }

	// RVA: 0x7039C0 Offset: 0x702BC0 VA: 0x1807039C0
	public void .ctor() { }
}

// Namespace: 
public enum PurchaseStates // TypeDefIndex: 1872
{
	// Fields
	public int value__; // 0x0
	public const PurchaseStates NotStarted = 0;
	public const PurchaseStates Started = 1;
	public const PurchaseStates Success = 2;
	public const PurchaseStates Fail = 3;
}

// Namespace: 
public enum StoreTab // TypeDefIndex: 1873
{
	// Fields
	public int value__; // 0x0
	public const StoreTab Cubes = 0;
	public const StoreTab Bundles = 1;
	public const StoreTab Pets = 2;
	public const StoreTab Stars = 3;
	public const StoreTab Hats = 4;
	public const StoreTab Skins = 5;
	public const StoreTab Visors = 6;
	public const StoreTab Nameplates = 7;
	public const StoreTab Home = 8;
}

// Namespace: 
[Serializable]
public struct AmongUsProduct // TypeDefIndex: 1874
{
	// Fields
	public string ProductId; // 0x0
	public HatData HatData; // 0x8
}

// Namespace: 
[Serializable]
public class StoreTabButton : TabButton // TypeDefIndex: 1875
{
	// Fields
	public float ItemListStartY; // 0x28
	public FloatRange XRange; // 0x30
	public int NumPerRow; // 0x38
	public StoreTab storeTab; // 0x3C
	public GameObject NewItemIcon; // 0x40

	// Methods

	// RVA: 0x70C640 Offset: 0x70B840 VA: 0x18070C640
	public void .ctor() { }
}

// Namespace: 
public class RefreshTimer // TypeDefIndex: 1876
{
	// Fields
	public readonly DateTime time; // 0x10
	public readonly StoreTab[] tabs; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(DateTime time, StoreTab[] tabs) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StoreMenu.<>c // TypeDefIndex: 1877
{
	// Fields
	public static readonly StoreMenu.<>c <>9; // 0x0
	public static Action<ColorChip> <>9__110_0; // 0x8
	public static Func<CosmicubeData, bool> <>9__116_0; // 0x10
	public static Func<CosmicubeData, DateTime> <>9__116_1; // 0x18
	public static Func<StarBundle, float> <>9__116_2; // 0x20
	public static Func<BundleData, bool> <>9__116_3; // 0x28
	public static Func<CosmicubeData, bool> <>9__116_4; // 0x30
	public static Func<BundleData, bool> <>9__116_5; // 0x38
	public static Func<BundleData, bool> <>9__116_6; // 0x40
	public static Func<RefreshTimer, DateTime> <>9__117_0; // 0x48
	public static Action<TextMeshPro> <>9__128_0; // 0x50

	// Methods

	// RVA: 0x70EF50 Offset: 0x70E150 VA: 0x18070EF50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E530 Offset: 0x70D730 VA: 0x18070E530
	internal void <DeselectAllItems>b__110_0(ColorChip c) { }

	// RVA: 0x70E590 Offset: 0x70D790 VA: 0x18070E590
	internal bool <ReSortCosmeticTabs>b__116_0(CosmicubeData p) { }

	// RVA: 0x612100 Offset: 0x611300 VA: 0x180612100
	internal DateTime <ReSortCosmeticTabs>b__116_1(CosmicubeData p) { }

	// RVA: 0x70E620 Offset: 0x70D820 VA: 0x18070E620
	internal float <ReSortCosmeticTabs>b__116_2(StarBundle p) { }

	// RVA: 0x70E640 Offset: 0x70D840 VA: 0x18070E640
	internal bool <ReSortCosmeticTabs>b__116_3(BundleData h) { }

	// RVA: 0x70E6A0 Offset: 0x70D8A0 VA: 0x18070E6A0
	internal bool <ReSortCosmeticTabs>b__116_4(CosmicubeData x) { }

	// RVA: 0x70E700 Offset: 0x70D900 VA: 0x18070E700
	internal bool <ReSortCosmeticTabs>b__116_5(BundleData x) { }

	// RVA: 0x70E770 Offset: 0x70D970 VA: 0x18070E770
	internal bool <ReSortCosmeticTabs>b__116_6(BundleData x) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal DateTime <SetRefreshTimers>b__117_0(RefreshTimer x) { }

	// RVA: 0x70E7E0 Offset: 0x70D9E0 VA: 0x18070E7E0
	internal void <ShowTab>b__128_0(TextMeshPro t) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StoreMenu.<>c__127<T> // TypeDefIndex: 1878
{
	// Fields
	public static readonly StoreMenu.<>c__127<T> <>9; // 0x0
	public static Func<T, bool> <>9__127_0; // 0x0
	public static Func<T, bool> <>9__127_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-StoreMenu.<>c__127<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StoreMenu.<>c__127<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <GetSortedStoreCosmetics>b__127_0(T h) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08410 Offset: 0xB07610 VA: 0x180B08410
	|-StoreMenu.<>c__127<object>.<GetSortedStoreCosmetics>b__127_0
	*/

	// RVA: -1 Offset: -1
	internal bool <GetSortedStoreCosmetics>b__127_1(T p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB084C0 Offset: 0xB076C0 VA: 0x180B084C0
	|-StoreMenu.<>c__127<object>.<GetSortedStoreCosmetics>b__127_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreMenu.<>c__DisplayClass109_0 // TypeDefIndex: 1879
{
	// Fields
	public StoreChip chip; // 0x10
	public CosmeticData prod; // 0x18
	public StoreMenu <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E8F0 Offset: 0x70DAF0 VA: 0x18070E8F0
	internal void <SetProduct>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreMenu.<>c__DisplayClass109_1 // TypeDefIndex: 1880
{
	// Fields
	public StoreChip chip; // 0x10
	public CosmeticData cosmeticData; // 0x18
	public StoreMenu <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E920 Offset: 0x70DB20 VA: 0x18070E920
	internal void <SetProduct>b__1() { }
}

// Namespace: 
public class StoreMenu : DestroyableSingleton<StoreMenu> // TypeDefIndex: 1881
{
	// Fields
	public const string BoughtAdsProductId = "bought_ads";
	private const float MaxItemsPerRow = 4;
	private const float NumRowsVisible = 2;
	private const float DefaultAspectRatio = 1,7777778;
	private HatData[] allHats; // 0x28
	private SkinData[] allSkins; // 0x30
	private VisorData[] allVisors; // 0x38
	private NamePlateData[] allPlates; // 0x40
	private BundleData[] allBundles; // 0x48
	private CosmicubeData[] allCubes; // 0x50
	private PetData[] allPets; // 0x58
	private CosmeticData[] allFeaturedItems; // 0x60
	private CosmicubeData[] allFeaturedCubes; // 0x68
	private BundleData[] allLargeFeaturedBundles; // 0x70
	private BundleData[] allFeaturedBundles; // 0x78
	private StarBundle[] allStars; // 0x80
	private Product[] allProducts; // 0x88
	[Header("Store Menu")]
	public StoreTabButton[] Tabs; // 0x90
	public GameObject normalMenu; // 0x98
	public GameObject featuredMenu; // 0xA0
	public TextMeshPro LoadingText; // 0xA8
	public TextMeshPro RestorePurchasesButton; // 0xB0
	public GameObject RestorePurchasesObj; // 0xB8
	public UiElement OpenAllInEShopButton; // 0xC0
	public PurchaseButton PurchasablePrefab; // 0xC8
	public PurchaseButton PurchasableNameplatePrefab; // 0xD0
	public BundlePurchaseButton BundlePurchasablePrefab; // 0xD8
	public BundlePurchaseButton LargeBundlePurchasablePrefab; // 0xE0
	public TextMeshPro beanAmount; // 0xE8
	public TextMeshPro starAmount; // 0xF0
	public GameObject comingSoonText; // 0xF8
	public TextMeshPro tabHeader; // 0x100
	[Header("Confirm Menu")]
	public PurchasePopUp plsWaitModal; // 0x108
	public GameObject confirmMenu; // 0x110
	public CubeCellPurchaseButton priceButton; // 0x118
	public CubeCellPurchaseButton priceButtonCube; // 0x120
	public GameObject starConfirmMenu; // 0x128
	public TextMeshPro StarBundleName; // 0x130
	public TextMeshPro StarPriceText; // 0x138
	public PassiveButton starBuyButton; // 0x140
	public SpriteRenderer starPreviewImage; // 0x148
	public CosmicubeMenu cosmicubePreviewMenu; // 0x150
	public PoolablePlayer dressMeUp; // 0x158
	public PoolablePlayer dressMeUpCube; // 0x160
	public PlayerVoteArea NameplatePreviewArea; // 0x168
	public TextMeshPro ItemName; // 0x170
	public TextMeshPro ItemNameCube; // 0x178
	public TextMeshPro BundleName; // 0x180
	public TextMeshPro CosmicubeName; // 0x188
	public SpriteRenderer PurchaseBackground; // 0x190
	public TextMeshPro PriceText; // 0x198
	public TextMeshPro PriceTextCube; // 0x1A0
	public StoreChip PreviewPrefab; // 0x1A8
	public Scroller ConfirmMenuScroller; // 0x1B0
	public UpdateProductTimerDisplay itemLimitedTimeText; // 0x1B8
	public FloatRange BundleRange; // 0x1C0
	public FloatRange XRange; // 0x1C8
	public FloatRange CubesRange; // 0x1D0
	public float YStart; // 0x1D8
	public float YOffset; // 0x1DC
	public int NumPerRow; // 0x1E0
	public Vector3 ConfirmCosmeticPosition; // 0x1E4
	public Sprite starIcon; // 0x1F0
	public Sprite beanIcon; // 0x1F8
	[HideInInspector]
	public List<ColorChip> ColorChips; // 0x200
	private RefreshTimer[] refreshTimers; // 0x208
	private StoreTab selectedTab; // 0x210
	private StoreTabButton selectedTabObject; // 0x218
	[SerializeField]
	private AudioClip swapTabSound; // 0x220
	private const float NormalHeight = -1,95;
	private const float BoxHeight = -1,95;
	public TextMeshPro starDisclaimerText; // 0x228
	private List<TextMeshPro> BundleTitles; // 0x230
	private Logger logger; // 0x238
	public Action OnOpen; // 0x240
	public Action OnClose; // 0x248
	private StoreTab[] controllerSelectableTabs; // 0x250
	[CompilerGenerated]
	private PurchaseStates <PurchaseState>k__BackingField; // 0x258
	[Header("Store Menu")]
	public Scroller Scroller; // 0x260
	public Scroller FeatureTabScroller; // 0x268
	private MainMenuManager manager; // 0x270
	private PurchaseButton CurrentButton; // 0x278
	private List<GameObject> AllObjects; // 0x280
	[Header("Console Controller Navigation")]
	private ControllerNavMenu controllerNavMenu; // 0x288
	public GameObject glyphL; // 0x290
	public GameObject glyphR; // 0x298
	private bool initialized; // 0x2A0

	// Properties
	public PurchaseStates PurchaseState { get; set; }
	public bool Initialized { get; }

	// Methods

	// RVA: 0x705600 Offset: 0x704800 VA: 0x180705600
	public void CloseConfirm() { }

	// RVA: 0x7056D0 Offset: 0x7048D0 VA: 0x1807056D0
	public void CloseWaitModal() { }

	// RVA: 0x705C00 Offset: 0x704E00 VA: 0x180705C00
	public void DisplayFailed(string error) { }

	// RVA: 0x705C30 Offset: 0x704E30 VA: 0x180705C30
	public void DisplaySuccess() { }

	// RVA: 0x70C060 Offset: 0x70B260 VA: 0x18070C060
	public void UpdateStarDisplay() { }

	[CompilerGenerated]
	// RVA: 0x70C620 Offset: 0x70B820 VA: 0x18070C620
	public PurchaseStates get_PurchaseState() { }

	[CompilerGenerated]
	// RVA: 0x70C630 Offset: 0x70B830 VA: 0x18070C630
	private void set_PurchaseState(PurchaseStates value) { }

	// RVA: 0x70C610 Offset: 0x70B810 VA: 0x18070C610
	public bool get_Initialized() { }

	// RVA: 0x70BAD0 Offset: 0x70ACD0 VA: 0x18070BAD0
	public void Start() { }

	// RVA: 0x706E20 Offset: 0x706020 VA: 0x180706E20 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x706E90 Offset: 0x706090 VA: 0x180706E90
	public void OpenTab(StoreMenuTabButton Butt) { }

	// RVA: 0x706EB0 Offset: 0x7060B0 VA: 0x180706EB0
	public void OpenTab(StoreTab tab) { }

	// RVA: 0x709B70 Offset: 0x708D70 VA: 0x180709B70
	public void ShowConfirm(PurchaseButton butt) { }

	// RVA: 0x7056D0 Offset: 0x7048D0 VA: 0x1807056D0
	public void StarPurchaseFinished() { }

	// RVA: 0x706060 Offset: 0x705260 VA: 0x180706060
	public void Initialize() { }

	// RVA: 0x70C120 Offset: 0x70B320 VA: 0x18070C120
	public void Update() { }

	// RVA: 0x707340 Offset: 0x706540 VA: 0x180707340
	public void Open() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void OpenGeneralShop() { }

	// RVA: 0x705AA0 Offset: 0x704CA0 VA: 0x180705AA0
	private void DestroySliderObjects() { }

	// RVA: 0x7075D0 Offset: 0x7067D0 VA: 0x1807075D0
	public void PreviewItem(StoreChip storeChip, CosmeticData product) { }

	// RVA: 0x7080B0 Offset: 0x7072B0 VA: 0x1807080B0
	public void SetProduct(PurchaseButton button) { }

	// RVA: 0x705990 Offset: 0x704B90 VA: 0x180705990
	private void DeselectAllItems() { }

	// RVA: 0x705180 Offset: 0x704380 VA: 0x180705180
	public void BuyProduct() { }

	// RVA: 0x705710 Offset: 0x704910 VA: 0x180705710
	public void Close() { }

	// RVA: 0x705680 Offset: 0x704880 VA: 0x180705680
	public void CloseEntirely() { }

	// RVA: 0x706C10 Offset: 0x705E10 VA: 0x180706C10
	private void LoadCosmeticData() { }

	// RVA: 0x706E80 Offset: 0x706080 VA: 0x180706E80
	public void OnSaveDataChanged() { }

	// RVA: 0x7078B0 Offset: 0x706AB0 VA: 0x1807078B0
	private void ReSortCosmeticTabs() { }

	// RVA: 0x7094F0 Offset: 0x7086F0 VA: 0x1807094F0
	private void SetRefreshTimers() { }

	// RVA: 0x705C80 Offset: 0x704E80 VA: 0x180705C80
	private void HandleRefreshTimers() { }

	// RVA: 0x70BED0 Offset: 0x70B0D0 VA: 0x18070BED0
	private void UpdateRefreshTimers() { }

	// RVA: 0x704500 Offset: 0x703700 VA: 0x180704500
	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<CosmeticData> cosmetics, StoreTab[] tabs) { }

	// RVA: 0x704DF0 Offset: 0x703FF0 VA: 0x180704DF0
	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<CosmicubeData> cosmicubes, StoreTab[] tabs) { }

	// RVA: 0x704790 Offset: 0x703990 VA: 0x180704790
	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<BundleData> bundles, StoreTab[] tabs) { }

	// RVA: 0x704A20 Offset: 0x703C20 VA: 0x180704A20
	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, IEnumerable<FeaturedItemGroup> features) { }

	// RVA: 0x705070 Offset: 0x704270 VA: 0x180705070
	private void AddRefreshTimers(Dictionary<DateTime, List<StoreTab>> dictionary, DateTime start, DateTime end, StoreTab[] tabs) { }

	// RVA: 0x704320 Offset: 0x703520 VA: 0x180704320
	private void AddRefreshTimer(Dictionary<DateTime, List<StoreTab>> dictionary, DateTime time, StoreTab[] tabs) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void DebugRefreshTimers() { }

	// RVA: -1 Offset: -1
	private T[] GetSortedStoreCosmetics<T>(IEnumerable<T> all) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA79D40 Offset: 0xA78F40 VA: 0x180A79D40
	|-StoreMenu.GetSortedStoreCosmetics<object>
	*/

	// RVA: 0x70A090 Offset: 0x709290 VA: 0x18070A090
	private void ShowTab() { }

	// RVA: 0x704000 Offset: 0x703200 VA: 0x180704000
	private Vector3 AddProductFromList(Vector3 position, IBuyable[] products, List<PurchaseButton> allBtns, float yOffset, int numPerRow, FloatRange xRange, float spacingMultiplier = 1, bool centerRemainder = False) { }

	// RVA: 0x706240 Offset: 0x705440 VA: 0x180706240
	private PurchaseButton InsertProduct(Vector3 position, IBuyable item) { }

	// RVA: 0x705440 Offset: 0x704640 VA: 0x180705440
	public void BuyStars() { }

	// RVA: 0x7080A0 Offset: 0x7072A0 VA: 0x1807080A0
	public void ResetPurchaseState() { }

	// RVA: 0x70C3B0 Offset: 0x70B5B0 VA: 0x18070C3B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x70BD80 Offset: 0x70AF80 VA: 0x18070BD80
	private void <BuyProduct>b__111_0(ResponseState cb, Response<ResponsePurchase> response) { }
}

// Namespace: 
public class StoreMenuTabButton : MonoBehaviour // TypeDefIndex: 1882
{
	// Fields
	public StoreTab Tab; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class UpdateProductTimerDisplay : MonoBehaviour // TypeDefIndex: 1883
{
	// Fields
	private const float TimeBetweenRefresh = 1;
	public TextMeshPro Tmp; // 0x20
	private IBuyable currentProduct; // 0x28
	private float lastUpdate; // 0x30
	[SerializeField]
	private bool DisplayShort; // 0x34

	// Methods

	// RVA: 0x70F050 Offset: 0x70E250 VA: 0x18070F050
	private void OnEnable() { }

	// RVA: 0x70F010 Offset: 0x70E210 VA: 0x18070F010
	private void FixedUpdate() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void SetProduct(IBuyable product) { }

	// RVA: 0x70F0B0 Offset: 0x70E2B0 VA: 0x18070F0B0
	private void RefreshTimer() { }

	// RVA: 0x70F1B0 Offset: 0x70E3B0 VA: 0x18070F1B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StoreChip.<>c__DisplayClass7_0 // TypeDefIndex: 1884
{
	// Fields
	public StoreChip <>4__this; // 0x10
	public AddressableAsset<NamePlateViewData> viewAsset; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70EAE0 Offset: 0x70DCE0 VA: 0x18070EAE0
	internal void <SetData>b__0() { }
}

// Namespace: 
public class StoreChip : ColorChip // TypeDefIndex: 1885
{
	// Fields
	[CompilerGenerated]
	private StoreMenu <Parent>k__BackingField; // 0x68
	public CosmeticData product; // 0x70
	public StoreMannequin storeMannequin; // 0x78
	public SpriteRenderer NameplateConfirmPreview; // 0x80

	// Properties
	public StoreMenu Parent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public StoreMenu get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_Parent(StoreMenu value) { }

	// RVA: 0x701D60 Offset: 0x700F60 VA: 0x180701D60
	public void SetData(CosmeticData prod) { }

	// RVA: 0x61C7D0 Offset: 0x61B9D0 VA: 0x18061C7D0
	public void .ctor() { }
}

// Namespace: 
public class StoreMannequin : MonoBehaviour // TypeDefIndex: 1886
{
	// Fields
	[SerializeField]
	[Header("Cosmetic Slots")]
	private HatParent hat; // 0x20
	[SerializeField]
	private VisorLayer visor; // 0x28
	[SerializeField]
	private SpriteRenderer skin; // 0x30
	[SerializeField]
	private SpriteRenderer pet; // 0x38
	[Header("Materials")]
	[SerializeField]
	private Material defaultMaterial; // 0x40
	[SerializeField]
	private Material playerMaterial; // 0x48

	// Methods

	// RVA: 0x703A90 Offset: 0x702C90 VA: 0x180703A90
	public void WearThing(IBuyable product, PlayerMaterial.MaskType maskType, int outfitColorOverride = -1) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class TaskPanelBehaviour : MonoBehaviour // TypeDefIndex: 1887
{
	// Fields
	[SerializeField]
	private Vector3 openPosition; // 0x20
	[SerializeField]
	private Vector3 closedPosition; // 0x2C
	[SerializeField]
	private SpriteRenderer background; // 0x38
	[SerializeField]
	private SpriteRenderer tab; // 0x40
	[SerializeField]
	private TextMeshPro taskText; // 0x48
	[SerializeField]
	private float animationTimeSeconds; // 0x50
	private bool open; // 0x54
	private float timer; // 0x58

	// Methods

	// RVA: 0x70C6F0 Offset: 0x70B8F0 VA: 0x18070C6F0
	public void ToggleOpen() { }

	// RVA: 0x70C700 Offset: 0x70B900 VA: 0x18070C700
	private void Update() { }

	// RVA: 0x70C6C0 Offset: 0x70B8C0 VA: 0x18070C6C0
	public void SetTaskText(string str) { }

	// RVA: 0x70CD90 Offset: 0x70BF90 VA: 0x18070CD90
	public void .ctor() { }
}

// Namespace: 
public class DivertPowerTask : NormalPlayerTask // TypeDefIndex: 1888
{
	// Fields
	public SystemTypes TargetSystem; // 0x88

	// Methods

	// RVA: 0x6F9410 Offset: 0x6F8610 VA: 0x1806F9410 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6F90D0 Offset: 0x6F82D0 VA: 0x1806F90D0 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6F9510 Offset: 0x6F8710 VA: 0x1806F9510
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6F93E0 Offset: 0x6F85E0 VA: 0x1806F93E0
	private bool <ValidConsole>b__1_0(TaskSet set) { }
}

// Namespace: 
public class ElectricTask : SabotageTask // TypeDefIndex: 1889
{
	// Fields
	private bool isComplete; // 0x58
	private SwitchSystem system; // 0x60
	private bool even; // 0x68

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x6FA2D0 Offset: 0x6F94D0 VA: 0x1806FA2D0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FA130 Offset: 0x6F9330 VA: 0x1806FA130 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FA0E0 Offset: 0x6F92E0 VA: 0x1806FA0E0
	private void FixedUpdate() { }

	// RVA: 0x6FA270 Offset: 0x6F9470 VA: 0x1806FA270 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6F9FB0 Offset: 0x6F91B0 VA: 0x1806F9FB0 Slot: 9
	public override void Complete() { }

	// RVA: 0x6F9D60 Offset: 0x6F8F60 VA: 0x1806F9D60 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public class HeliCharlesTask : SabotageTask // TypeDefIndex: 1890
{
	// Fields
	private bool isComplete; // 0x58
	private ICriticalSabotage sabotage; // 0x60
	private bool even; // 0x68

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x6FBF40 Offset: 0x6FB140 VA: 0x1806FBF40 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FBED0 Offset: 0x6FB0D0 VA: 0x1806FBED0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FBC60 Offset: 0x6FAE60 VA: 0x1806FBC60
	public void Awake() { }

	// RVA: 0x6FBE60 Offset: 0x6FB060 VA: 0x1806FBE60
	private void FixedUpdate() { }

	// RVA: 0x6FBEE0 Offset: 0x6FB0E0 VA: 0x1806FBEE0 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6FBD70 Offset: 0x6FAF70 VA: 0x1806FBD70 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FB920 Offset: 0x6FAB20 VA: 0x1806FB920 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public interface IHudOverrideTask // TypeDefIndex: 1891
{}

// Namespace: 
public class HqHudOverrideTask : SabotageTask, IHudOverrideTask // TypeDefIndex: 1892
{
	// Fields
	private bool isComplete; // 0x58
	private HqHudSystemType system; // 0x60
	private bool even; // 0x68

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x6FA2D0 Offset: 0x6F94D0 VA: 0x1806FA2D0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FC400 Offset: 0x6FB600 VA: 0x1806FC400 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FC3B0 Offset: 0x6FB5B0 VA: 0x1806FC3B0
	private void FixedUpdate() { }

	// RVA: 0x6FC4D0 Offset: 0x6FB6D0 VA: 0x1806FC4D0 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6FC1D0 Offset: 0x6FB3D0 VA: 0x1806FC1D0 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FBF90 Offset: 0x6FB190 VA: 0x1806FBF90 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public class HudOverrideTask : SabotageTask, IHudOverrideTask // TypeDefIndex: 1893
{
	// Fields
	private bool isComplete; // 0x58
	private HudOverrideSystemType system; // 0x60
	private bool even; // 0x68

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x6FA2D0 Offset: 0x6F94D0 VA: 0x1806FA2D0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FC860 Offset: 0x6FBA60 VA: 0x1806FC860 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FC820 Offset: 0x6FBA20 VA: 0x1806FC820
	private void FixedUpdate() { }

	// RVA: 0x6FC930 Offset: 0x6FBB30 VA: 0x1806FC930 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6FC6F0 Offset: 0x6FB8F0 VA: 0x1806FC6F0 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FC520 Offset: 0x6FB720 VA: 0x1806FC520 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public class ImportantTextTask : PlayerTask // TypeDefIndex: 1894
{
	// Fields
	public string Text; // 0x48

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public override void Initialize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FC980 Offset: 0x6FBB80 VA: 0x1806FC980 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public class NoOxyTask : SabotageTask // TypeDefIndex: 1895
{
	// Fields
	private bool isComplete; // 0x58
	private LifeSuppSystemType reactor; // 0x60
	private bool even; // 0x68
	public int targetNumber; // 0x6C

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x6FD1D0 Offset: 0x6FC3D0 VA: 0x1806FD1D0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FCFD0 Offset: 0x6FC1D0 VA: 0x1806FCFD0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FCEE0 Offset: 0x6FC0E0 VA: 0x1806FCEE0
	private void FixedUpdate() { }

	// RVA: 0x6FD150 Offset: 0x6FC350 VA: 0x1806FD150 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public override void OnRemove() { }

	// RVA: 0x6FCDB0 Offset: 0x6FBFB0 VA: 0x1806FCDB0 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FCA00 Offset: 0x6FBC00 VA: 0x1806FCA00 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FA2C0 Offset: 0x6F94C0 VA: 0x1806FA2C0
	public void .ctor() { }
}

// Namespace: 
public enum NormalPlayerTask.TaskLength // TypeDefIndex: 1896
{
	// Fields
	public int value__; // 0x0
	public const NormalPlayerTask.TaskLength None = 0;
	public const NormalPlayerTask.TaskLength Common = 1;
	public const NormalPlayerTask.TaskLength Short = 2;
	public const NormalPlayerTask.TaskLength Long = 3;
}

// Namespace: 
public enum NormalPlayerTask.TimerState // TypeDefIndex: 1897
{
	// Fields
	public int value__; // 0x0
	public const NormalPlayerTask.TimerState NotStarted = 0;
	public const NormalPlayerTask.TimerState Started = 1;
	public const NormalPlayerTask.TimerState Finished = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NormalPlayerTask.<>c // TypeDefIndex: 1898
{
	// Fields
	public static readonly NormalPlayerTask.<>c <>9; // 0x0
	public static Func<Console, bool> <>9__20_1; // 0x8
	public static Func<Console, bool> <>9__22_0; // 0x10
	public static Func<Console, bool> <>9__22_1; // 0x18
	public static Predicate<Console> <>9__22_6; // 0x20
	public static Predicate<Console> <>9__22_7; // 0x28
	public static Func<Console, bool> <>9__22_2; // 0x30
	public static Predicate<byte> <>9__24_10; // 0x38
	public static Func<TaskTypes, bool> <>9__24_6; // 0x40
	public static Func<TaskTypes, bool> <>9__24_7; // 0x48

	// Methods

	// RVA: 0x721150 Offset: 0x720350 VA: 0x180721150
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720730 Offset: 0x71F930 VA: 0x180720730
	internal bool <Initialize>b__20_1(Console c) { }

	// RVA: 0x7208D0 Offset: 0x71FAD0 VA: 0x1807208D0
	internal bool <UpdateArrowAndLocation>b__22_0(Console c) { }

	// RVA: 0x720930 Offset: 0x71FB30 VA: 0x180720930
	internal bool <UpdateArrowAndLocation>b__22_1(Console console) { }

	// RVA: 0x720990 Offset: 0x71FB90 VA: 0x180720990
	internal bool <UpdateArrowAndLocation>b__22_6(Console c) { }

	// RVA: 0x7209B0 Offset: 0x71FBB0 VA: 0x1807209B0
	internal bool <UpdateArrowAndLocation>b__22_7(Console c) { }

	// RVA: 0x5CEAA0 Offset: 0x5CDCA0 VA: 0x1805CEAA0
	internal bool <UpdateArrowAndLocation>b__22_2(Console c) { }

	// RVA: 0x720A30 Offset: 0x71FC30 VA: 0x180720A30
	internal bool <ValidConsole>b__24_10(byte b) { }

	// RVA: 0x720A40 Offset: 0x71FC40 VA: 0x180720A40
	internal bool <ValidConsole>b__24_6(TaskTypes t) { }

	// RVA: 0x720A40 Offset: 0x71FC40 VA: 0x180720A40
	internal bool <ValidConsole>b__24_7(TaskTypes t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NormalPlayerTask.<>c__DisplayClass20_0 // TypeDefIndex: 1899
{
	// Fields
	public byte[] consoleIds; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720C60 Offset: 0x71FE60 VA: 0x180720C60
	internal bool <Initialize>b__2(Console v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NormalPlayerTask.<>c__DisplayClass28_0 // TypeDefIndex: 1900
{
	// Fields
	public TaskTypes taskType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720E40 Offset: 0x720040 VA: 0x180720E40
	internal bool <PickRandomConsoles>b__0(Console t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NormalPlayerTask.<>c__DisplayClass29_0 // TypeDefIndex: 1901
{
	// Fields
	public TaskTypes taskType; // 0x10
	public int taskStep; // 0x14
	public Func<TaskSet, bool> <>9__1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720EA0 Offset: 0x7200A0 VA: 0x180720EA0
	internal bool <PickRandomConsoles>b__0(Console t) { }

	// RVA: 0x720F80 Offset: 0x720180 VA: 0x180720F80
	internal bool <PickRandomConsoles>b__1(TaskSet x) { }
}

// Namespace: 
public class NormalPlayerTask : PlayerTask // TypeDefIndex: 1902
{
	// Fields
	public NormalPlayerTask.TaskLength Length; // 0x48
	public int taskStep; // 0x4C
	public int MaxStep; // 0x50
	public bool ShowTaskStep; // 0x54
	public bool ShowTaskTimer; // 0x55
	public NormalPlayerTask.TimerState TimerStarted; // 0x58
	public float TaskTimer; // 0x5C
	public byte[] Data; // 0x60
	public ArrowBehaviour Arrow; // 0x68
	[SerializeField]
	[Tooltip("To have multiple texts on multistage tasks")]
	private bool useMultipleText; // 0x70
	[Tooltip("For tasks that need a number of steps completed before stage 2")]
	[SerializeField]
	private int maxNumStepsStage1; // 0x74
	[Tooltip("Used only if useMultipleText is selected")]
	[SerializeField]
	private StringNames textStage1; // 0x78
	[SerializeField]
	[Tooltip("Used only if useMultipleText is selected")]
	private StringNames textStage2; // 0x7C
	protected bool arrowSuspended; // 0x80

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x6FFFB0 Offset: 0x6FF1B0 VA: 0x1806FFFB0 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FD7B0 Offset: 0x6FC9B0 VA: 0x1806FD7B0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x6FE330 Offset: 0x6FD530 VA: 0x1806FE330
	public void NextStep() { }

	// RVA: 0x6FEC90 Offset: 0x6FDE90 VA: 0x1806FEC90 Slot: 12
	public virtual void UpdateArrowAndLocation() { }

	// RVA: 0x6FD5C0 Offset: 0x6FC7C0 VA: 0x1806FD5C0 Slot: 13
	protected virtual void FixedUpdate() { }

	// RVA: 0x6FF5F0 Offset: 0x6FE7F0 VA: 0x1806FF5F0 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x6FD5B0 Offset: 0x6FC7B0 VA: 0x1806FD5B0 Slot: 9
	public override void Complete() { }

	// RVA: 0x6FD1F0 Offset: 0x6FC3F0 VA: 0x1806FD1F0 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x6FEA90 Offset: 0x6FDC90 VA: 0x1806FEA90
	private bool ShouldYellowText() { }

	// RVA: 0x6FE610 Offset: 0x6FD810 VA: 0x1806FE610
	private static List<Console> PickRandomConsoles(TaskTypes taskType, byte[] consoleIds) { }

	// RVA: 0x6FE930 Offset: 0x6FDB30 VA: 0x1806FE930
	private static List<Console> PickRandomConsoles(int taskStep, TaskTypes taskType) { }

	// RVA: 0x6F9510 Offset: 0x6F8710 VA: 0x1806F9510
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6FEAE0 Offset: 0x6FDCE0 VA: 0x1806FEAE0
	private bool <Initialize>b__20_0(Console v) { }

	[CompilerGenerated]
	// RVA: 0x6FEB20 Offset: 0x6FDD20 VA: 0x1806FEB20
	private bool <UpdateArrowAndLocation>b__22_3(Console c) { }

	[CompilerGenerated]
	// RVA: 0x6FEBB0 Offset: 0x6FDDB0 VA: 0x1806FEBB0
	private bool <UpdateArrowAndLocation>b__22_4(Console c) { }

	[CompilerGenerated]
	// RVA: 0x6FEAE0 Offset: 0x6FDCE0 VA: 0x1806FEAE0
	private bool <UpdateArrowAndLocation>b__22_5(Console c) { }

	[CompilerGenerated]
	// RVA: 0x63FBD0 Offset: 0x63EDD0 VA: 0x18063FBD0
	private bool <ValidConsole>b__24_0(TaskSet set) { }

	[CompilerGenerated]
	// RVA: 0x6FEBF0 Offset: 0x6FDDF0 VA: 0x1806FEBF0
	private bool <ValidConsole>b__24_1(TaskTypes t) { }

	[CompilerGenerated]
	// RVA: 0x6FEBF0 Offset: 0x6FDDF0 VA: 0x1806FEBF0
	private bool <ValidConsole>b__24_2(TaskTypes t) { }

	[CompilerGenerated]
	// RVA: 0x6FEC00 Offset: 0x6FDE00 VA: 0x1806FEC00
	private bool <ValidConsole>b__24_3(TaskSet set) { }

	[CompilerGenerated]
	// RVA: 0x6FEBF0 Offset: 0x6FDDF0 VA: 0x1806FEBF0
	private bool <ValidConsole>b__24_4(TaskTypes tt) { }

	[CompilerGenerated]
	// RVA: 0x6FEC50 Offset: 0x6FDE50 VA: 0x1806FEC50
	private bool <ValidConsole>b__24_5(TaskSet set) { }

	[CompilerGenerated]
	// RVA: 0x6FEBF0 Offset: 0x6FDDF0 VA: 0x1806FEBF0
	private bool <ValidConsole>b__24_8(TaskTypes tt) { }

	[CompilerGenerated]
	// RVA: 0x63FBD0 Offset: 0x63EDD0 VA: 0x18063FBD0
	private bool <ValidConsole>b__24_9(TaskSet set) { }
}

// Namespace: 
public abstract class PlayerTask : MonoBehaviour // TypeDefIndex: 1903
{
	// Fields
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private uint <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private PlayerControl <Owner>k__BackingField; // 0x28
	public SystemTypes StartAt; // 0x30
	public TaskTypes TaskType; // 0x34
	public Minigame MinigamePrefab; // 0x38
	public bool HasLocation; // 0x40
	public bool LocationDirty; // 0x41

	// Properties
	public int Index { get; set; }
	public uint Id { get; set; }
	public PlayerControl Owner { get; set; }
	public abstract int TaskStep { get; }
	public abstract bool IsComplete { get; }
	public List<Vector2> Locations { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public uint get_Id() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	internal void set_Id(uint value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PlayerControl get_Owner() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_Owner(PlayerControl value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_TaskStep();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsComplete();

	// RVA: 0x714690 Offset: 0x713890 VA: 0x180714690
	public List<Vector2> get_Locations() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Initialize();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public virtual void OnRemove() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ValidConsole(Console console);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Complete();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AppendTaskText(StringBuilder sb);

	// RVA: 0x7144D0 Offset: 0x7136D0 VA: 0x1807144D0
	internal static bool TaskIsEmergency(PlayerTask arg) { }

	// RVA: 0x714050 Offset: 0x713250 VA: 0x180714050
	protected List<Console> FindConsoles() { }

	// RVA: -1 Offset: -1
	public static T GetOrCreateTask<T>(PlayerControl localPlayer, int insertAt = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5A1A0 Offset: 0xA593A0 VA: 0x180A5A1A0
	|-PlayerTask.GetOrCreateTask<object>
	*/

	// RVA: -1 Offset: -1
	public static bool DestroyTasksOfType<T>(PlayerControl localPlayer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5A040 Offset: 0xA59240 VA: 0x180A5A040
	|-PlayerTask.DestroyTasksOfType<object>
	|-PlayerTask.DestroyTasksOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetTaskOfType<T>(PlayerControl localPlayer, out T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5A760 Offset: 0xA59960 VA: 0x180A5A760
	|-PlayerTask.TryGetTaskOfType<object>
	|
	|-RVA: 0xA5A470 Offset: 0xA59670 VA: 0x180A5A470
	|-PlayerTask.TryGetTaskOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool PlayerHasTaskOfType<T>(PlayerControl localPlayer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5A420 Offset: 0xA59620 VA: 0x180A5A420
	|-PlayerTask.PlayerHasTaskOfType<object>
	|
	|-RVA: 0xA5A390 Offset: 0xA59590 VA: 0x180A5A390
	|-PlayerTask.PlayerHasTaskOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x714360 Offset: 0x713560 VA: 0x180714360
	public List<Vector2> FindValidConsolesPositions() { }

	// RVA: 0x7142A0 Offset: 0x7134A0 VA: 0x1807142A0
	protected Console FindSpecialConsole(Func<Console, bool> func) { }

	// RVA: 0x714170 Offset: 0x713370 VA: 0x180714170
	protected Console FindObjectPos() { }

	// RVA: 0x713E40 Offset: 0x713040 VA: 0x180713E40
	protected List<Vector2> FindConsolesPos() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 11
	public virtual Minigame GetMinigamePrefab() { }

	// RVA: 0x713D30 Offset: 0x712F30 VA: 0x180713D30
	protected static bool AllTasksCompleted(PlayerControl player) { }

	// RVA: 0x714680 Offset: 0x713880 VA: 0x180714680
	protected void .ctor() { }
}

// Namespace: 
public class ReactorTask : SabotageTask // TypeDefIndex: 1904
{
	// Fields
	private bool isComplete; // 0x58
	private ICriticalSabotage reactor; // 0x60
	private bool even; // 0x68

	// Properties
	public override int TaskStep { get; }
	public override bool IsComplete { get; }

	// Methods

	// RVA: 0x715950 Offset: 0x714B50 VA: 0x180715950 Slot: 4
	public override int get_TaskStep() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public override bool get_IsComplete() { }

	// RVA: 0x6FBED0 Offset: 0x6FB0D0 VA: 0x1806FBED0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x7154D0 Offset: 0x7146D0 VA: 0x1807154D0
	public void Awake() { }

	// RVA: 0x715860 Offset: 0x714A60 VA: 0x180715860
	private void FixedUpdate() { }

	// RVA: 0x7158F0 Offset: 0x714AF0 VA: 0x1807158F0 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public override void OnRemove() { }

	// RVA: 0x7156A0 Offset: 0x7148A0 VA: 0x1807156A0 Slot: 9
	public override void Complete() { }

	// RVA: 0x715190 Offset: 0x714390 VA: 0x180715190 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x714680 Offset: 0x713880 VA: 0x180714680
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7158D0 Offset: 0x714AD0 VA: 0x1807158D0
	private bool <Awake>b__8_0(PlainShipRoom r) { }
}

// Namespace: 
public abstract class SabotageTask : PlayerTask // TypeDefIndex: 1905
{
	// Fields
	protected bool didContribute; // 0x48
	public ArrowBehaviour[] Arrows; // 0x50

	// Methods

	// RVA: 0x7159A0 Offset: 0x714BA0 VA: 0x1807159A0
	public void MarkContributed() { }

	// RVA: 0x7159B0 Offset: 0x714BB0 VA: 0x1807159B0
	protected void SetupArrows() { }

	// RVA: 0x714680 Offset: 0x713880 VA: 0x180714680
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class TaskSet // TypeDefIndex: 1906
{
	// Fields
	public TaskTypes taskType; // 0x10
	public IntRange taskStep; // 0x18

	// Methods

	// RVA: 0x718C60 Offset: 0x717E60 VA: 0x180718C60
	public bool Contains(PlayerTask t) { }

	// RVA: 0x718CC0 Offset: 0x717EC0 VA: 0x180718CC0
	public void .ctor() { }
}

// Namespace: 
public enum TaskTypes // TypeDefIndex: 1907
{
	// Fields
	public int value__; // 0x0
	public const TaskTypes SubmitScan = 0;
	public const TaskTypes PrimeShields = 1;
	public const TaskTypes FuelEngines = 2;
	public const TaskTypes ChartCourse = 3;
	public const TaskTypes StartReactor = 4;
	public const TaskTypes SwipeCard = 5;
	public const TaskTypes ClearAsteroids = 6;
	public const TaskTypes UploadData = 7;
	public const TaskTypes InspectSample = 8;
	public const TaskTypes EmptyChute = 9;
	public const TaskTypes EmptyGarbage = 10;
	public const TaskTypes AlignEngineOutput = 11;
	public const TaskTypes FixWiring = 12;
	public const TaskTypes CalibrateDistributor = 13;
	public const TaskTypes DivertPower = 14;
	public const TaskTypes UnlockManifolds = 15;
	public const TaskTypes ResetReactor = 16;
	public const TaskTypes FixLights = 17;
	public const TaskTypes CleanO2Filter = 18;
	public const TaskTypes FixComms = 19;
	public const TaskTypes RestoreOxy = 20;
	public const TaskTypes StabilizeSteering = 21;
	public const TaskTypes AssembleArtifact = 22;
	public const TaskTypes SortSamples = 23;
	public const TaskTypes MeasureWeather = 24;
	public const TaskTypes EnterIdCode = 25;
	public const TaskTypes BuyBeverage = 26;
	public const TaskTypes ProcessData = 27;
	public const TaskTypes RunDiagnostics = 28;
	public const TaskTypes WaterPlants = 29;
	public const TaskTypes MonitorOxygen = 30;
	public const TaskTypes StoreArtifacts = 31;
	public const TaskTypes FillCanisters = 32;
	public const TaskTypes FixWeatherNode = 33;
	public const TaskTypes InsertKeys = 34;
	public const TaskTypes ResetSeismic = 35;
	public const TaskTypes ScanBoardingPass = 36;
	public const TaskTypes OpenWaterways = 37;
	public const TaskTypes ReplaceWaterJug = 38;
	public const TaskTypes RepairDrill = 39;
	public const TaskTypes AlignTelescope = 40;
	public const TaskTypes RecordTemperature = 41;
	public const TaskTypes RebootWifi = 42;
	public const TaskTypes PolishRuby = 43;
	public const TaskTypes ResetBreakers = 44;
	public const TaskTypes Decontaminate = 45;
	public const TaskTypes MakeBurger = 46;
	public const TaskTypes UnlockSafe = 47;
	public const TaskTypes SortRecords = 48;
	public const TaskTypes PutAwayPistols = 49;
	public const TaskTypes FixShower = 50;
	public const TaskTypes CleanToilet = 51;
	public const TaskTypes DressMannequin = 52;
	public const TaskTypes PickUpTowels = 53;
	public const TaskTypes RewindTapes = 54;
	public const TaskTypes StartFans = 55;
	public const TaskTypes DevelopPhotos = 56;
	public const TaskTypes GetBiggolSword = 57;
	public const TaskTypes PutAwayRifles = 58;
	public const TaskTypes StopCharles = 59;
	public const TaskTypes VentCleaning = 60;
	public const TaskTypes None = 61;
	public const TaskTypes BuildSandcastle = 62;
	public const TaskTypes CatchFish = 63;
	public const TaskTypes CollectShells = 64;
	public const TaskTypes LiftWeights = 65;
	public const TaskTypes RoastMarshmallow = 66;
	public const TaskTypes TestFrisbee = 67;
	public const TaskTypes CollectSamples = 68;
	public const TaskTypes CollectVegetables = 69;
	public const TaskTypes HoistSupplies = 70;
	public const TaskTypes MineOres = 71;
	public const TaskTypes PolishGem = 72;
	public const TaskTypes ReplaceParts = 73;
	public const TaskTypes HelpCritter = 74;
	public const TaskTypes CrankGenerator = 75;
	public const TaskTypes FixAntenna = 76;
	public const TaskTypes TuneRadio = 77;
	public const TaskTypes MushroomMixupSabotage = 78;
	public const TaskTypes ExtractFuel = 79;
	public const TaskTypes MonitorMushroom = 80;
	public const TaskTypes PlayVideogame = 81;
}

// Namespace: 
public static class TaskTypesHelpers // TypeDefIndex: 1908
{
	// Fields
	public static readonly TaskTypes[] AllTypes; // 0x0

	// Methods

	// RVA: 0x718D20 Offset: 0x717F20 VA: 0x180718D20
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TowelTask.<>c // TypeDefIndex: 1909
{
	// Fields
	public static readonly TowelTask.<>c <>9; // 0x0
	public static Func<byte, bool> <>9__0_1; // 0x8
	public static Func<byte, bool> <>9__1_0; // 0x10

	// Methods

	// RVA: 0x721090 Offset: 0x720290 VA: 0x180721090
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7206E0 Offset: 0x71F8E0 VA: 0x1807206E0
	internal bool <ValidConsole>b__0_1(byte b) { }

	// RVA: 0x7206E0 Offset: 0x71F8E0 VA: 0x1807206E0
	internal bool <AppendTaskText>b__1_0(byte b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TowelTask.<>c__DisplayClass0_0 // TypeDefIndex: 1910
{
	// Fields
	public Console console; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720B90 Offset: 0x71FD90 VA: 0x180720B90
	internal bool <ValidConsole>b__0(byte b) { }
}

// Namespace: 
public class TowelTask : NormalPlayerTask // TypeDefIndex: 1911
{
	// Methods

	// RVA: 0x719490 Offset: 0x718690 VA: 0x180719490 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x7191C0 Offset: 0x7183C0 VA: 0x1807191C0 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x63FEF0 Offset: 0x63F0F0 VA: 0x18063FEF0
	public void .ctor() { }
}

// Namespace: 
public class UploadDataTask : NormalPlayerTask // TypeDefIndex: 1912
{
	// Fields
	public SystemTypes EndAt; // 0x88

	// Methods

	// RVA: 0x7215D0 Offset: 0x7207D0 VA: 0x1807215D0 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x7213F0 Offset: 0x7205F0 VA: 0x1807213F0 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x7216D0 Offset: 0x7208D0 VA: 0x1807216D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x63FBD0 Offset: 0x63EDD0 VA: 0x18063FBD0
	private bool <ValidConsole>b__1_0(TaskSet set) { }
}

// Namespace: 
public class WaterWayTask : NormalPlayerTask // TypeDefIndex: 1913
{
	// Methods

	// RVA: 0x7255B0 Offset: 0x7247B0 VA: 0x1807255B0 Slot: 6
	public override void Initialize() { }

	// RVA: 0x725600 Offset: 0x724800 VA: 0x180725600 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x63FEF0 Offset: 0x63F0F0 VA: 0x18063FEF0
	public void .ctor() { }
}

// Namespace: 
public class WeatherNodeTask : NormalPlayerTask // TypeDefIndex: 1914
{
	// Fields
	public int NodeId; // 0x88
	public Minigame Stage2Prefab; // 0x90

	// Methods

	// RVA: 0x726B90 Offset: 0x725D90 VA: 0x180726B90 Slot: 8
	public override bool ValidConsole(Console console) { }

	// RVA: 0x726B10 Offset: 0x725D10 VA: 0x180726B10 Slot: 11
	public override Minigame GetMinigamePrefab() { }

	// RVA: 0x726890 Offset: 0x725A90 VA: 0x180726890 Slot: 10
	public override void AppendTaskText(StringBuilder sb) { }

	// RVA: 0x63FEF0 Offset: 0x63F0F0 VA: 0x18063FEF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x726B30 Offset: 0x725D30 VA: 0x180726B30
	private bool <ValidConsole>b__2_0(TaskSet t) { }
}

// Namespace: 
public static class AmongUsDateTime // TypeDefIndex: 1915
{
	// Fields
	private static IAmongUsDateTimeRetriever defaultRetriever; // 0x0
	private static IAmongUsDateTimeRetriever overrideRetriever; // 0x8

	// Properties
	private static IAmongUsDateTimeRetriever Retriever { get; }
	public static DateTime Now { get; }
	public static DateTime UtcNow { get; }

	// Methods

	// RVA: 0x70FF20 Offset: 0x70F120 VA: 0x18070FF20
	private static IAmongUsDateTimeRetriever get_Retriever() { }

	// RVA: 0x70FEB0 Offset: 0x70F0B0 VA: 0x18070FEB0
	public static DateTime get_Now() { }

	// RVA: 0x70FFC0 Offset: 0x70F1C0 VA: 0x18070FFC0
	public static DateTime get_UtcNow() { }

	// RVA: 0x70FE50 Offset: 0x70F050 VA: 0x18070FE50
	private static void .cctor() { }
}

// Namespace: 
public enum ImageNames // TypeDefIndex: 1916
{
	// Fields
	public int value__; // 0x0
	public const ImageNames LocalButton = 0;
	public const ImageNames OnlineButton = 1;
	public const ImageNames HowToPlayButton = 2;
	public const ImageNames FreeplayButton = 3;
	public const ImageNames HostHeader = 4;
	public const ImageNames PublicHeader = 5;
	public const ImageNames PrivateHeader = 6;
	public const ImageNames KillButton = 7;
	public const ImageNames ReportButton = 8;
	public const ImageNames UseButton = 9;
	public const ImageNames SabotageButton = 10;
	public const ImageNames CamsButton = 11;
	public const ImageNames AdminMapButton = 12;
	public const ImageNames MIRAAdminButton = 13;
	public const ImageNames PolusAdminButton = 14;
	public const ImageNames DoorLogsButton = 15;
	public const ImageNames VentButton = 16;
	public const ImageNames VitalsButton = 17;
	public const ImageNames StartButton = 18;
	public const ImageNames PublicButton = 19;
	public const ImageNames PrivateButton = 20;
	public const ImageNames PlayAgainButton = 21;
	public const ImageNames ExitRoomButton = 22;
	public const ImageNames OptionsButton = 23;
	public const ImageNames DiscussHeader = 24;
	public const ImageNames ShhhHeader = 25;
	public const ImageNames IVotedBadge = 26;
	public const ImageNames SkipVoteButton = 27;
	public const ImageNames MiraTaskBeginButton = 28;
	public const ImageNames SkippedVoteTallyHeader = 29;
	public const ImageNames ShopSkinsBanner = 30;
	public const ImageNames ShopHatsBanner = 31;
	public const ImageNames ShopPetsBanner = 32;
	public const ImageNames EmergencyMeetingText = 33;
	public const ImageNames AnnouncementsText = 34;
	public const ImageNames DeadBodyReportedText = 35;
	public const ImageNames ProceedButton = 36;
	public const ImageNames AirshipAdminButton = 39;
	public const ImageNames WardrobeButton = 40;
	public const ImageNames PetButton = 41;
}

// Namespace: 
[RequireComponent(typeof(SpriteRenderer))]
public class ImageTranslator : MonoBehaviour, ITranslatedText // TypeDefIndex: 1917
{
	// Fields
	public ImageNames TargetImage; // 0x20

	// Methods

	// RVA: 0x7126F0 Offset: 0x7118F0 VA: 0x1807126F0 Slot: 4
	public void ResetText() { }

	// RVA: 0x712870 Offset: 0x711A70 VA: 0x180712870
	public void Start() { }

	// RVA: 0x712660 Offset: 0x711860 VA: 0x180712660
	public void OnDestroy() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class LanguageUnit // TypeDefIndex: 1918
{
	// Fields
	private static StringBuilder builder; // 0x0
	public bool IsEnglish; // 0x10
	public SupportedLangs languageID; // 0x14
	private Dictionary<string, string> AllStrings; // 0x18
	private Dictionary<ImageNames, Sprite> AllImages; // 0x20

	// Methods

	// RVA: 0x713550 Offset: 0x712750 VA: 0x180713550
	public void .ctor(TranslatedImageSet locSet) { }

	// RVA: 0x7131C0 Offset: 0x7123C0 VA: 0x1807131C0
	public static bool TryParseTsvLine(string line, out string key, out string text) { }

	// RVA: 0x712C20 Offset: 0x711E20 VA: 0x180712C20
	public static void ParseTSV(string tsvText, Dictionary<string, string> allStrings) { }

	// RVA: 0x713300 Offset: 0x712500 VA: 0x180713300
	public static string UnescapeCodes(string src, int startAt) { }

	// RVA: 0x712B10 Offset: 0x711D10 VA: 0x180712B10
	public string GetString(string idString, object[] parts) { }

	// RVA: 0x712AA0 Offset: 0x711CA0 VA: 0x180712AA0
	public Sprite GetImage(ImageNames id) { }

	// RVA: 0x7134E0 Offset: 0x7126E0 VA: 0x1807134E0
	private static void .cctor() { }
}

// Namespace: 
[RequireComponent(typeof(TextMeshPro))]
public class PlatformTextTranslationTMP : MonoBehaviour, ITranslatedText // TypeDefIndex: 1919
{
	// Fields
	public StringNames DefaultTargetText; // 0x20
	public StringNames SwitchTargetText; // 0x24
	public StringNames XboxTargetText; // 0x28
	public StringNames PlaystationTargetText; // 0x2C
	public StringNames MobileTargetText; // 0x30

	// Methods

	// RVA: 0x713AD0 Offset: 0x712CD0 VA: 0x180713AD0 Slot: 4
	public void ResetText() { }

	// RVA: 0x713BB0 Offset: 0x712DB0 VA: 0x180713BB0
	public void Start() { }

	// RVA: 0x713A40 Offset: 0x712C40 VA: 0x180713A40
	public void OnDestroy() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Obfuscation(Exclude = True)]
public enum StringNames // TypeDefIndex: 1920
{
	// Fields
	public int value__; // 0x0
	public const StringNames None = 0;
	public const StringNames BackButton = 1;
	public const StringNames AvailableGamesLabel = 2;
	public const StringNames CreateGameButton = 3;
	public const StringNames FindGameButton = 4;
	public const StringNames EnterCode = 5;
	public const StringNames GhostIgnoreTasks = 6;
	public const StringNames GhostDoTasks = 7;
	public const StringNames GhostImpostor = 8;
	public const StringNames ImpostorTask = 9;
	public const StringNames FakeTasks = 10;
	public const StringNames TaskComplete = 11;
	public const StringNames ExileTextSP = 12;
	public const StringNames ExileTextSN = 13;
	public const StringNames ExileTextPP = 14;
	public const StringNames ExileTextPN = 15;
	public const StringNames NoExileSkip = 16;
	public const StringNames NoExileTie = 17;
	public const StringNames ImpostorsRemainS = 18;
	public const StringNames ImpostorsRemainP = 19;
	public const StringNames Hallway = 20;
	public const StringNames Storage = 21;
	public const StringNames Cafeteria = 22;
	public const StringNames Reactor = 23;
	public const StringNames UpperEngine = 24;
	public const StringNames Nav = 25;
	public const StringNames Admin = 26;
	public const StringNames Electrical = 27;
	public const StringNames LifeSupp = 28;
	public const StringNames Shields = 29;
	public const StringNames MedBay = 30;
	public const StringNames Security = 31;
	public const StringNames Weapons = 32;
	public const StringNames LowerEngine = 33;
	public const StringNames Comms = 34;
	public const StringNames Decontamination = 35;
	public const StringNames Launchpad = 36;
	public const StringNames LockerRoom = 37;
	public const StringNames Laboratory = 38;
	public const StringNames Balcony = 39;
	public const StringNames Office = 40;
	public const StringNames Greenhouse = 41;
	public const StringNames DivertPowerTo = 42;
	public const StringNames AcceptDivertedPower = 43;
	public const StringNames SubmitScan = 44;
	public const StringNames PrimeShields = 45;
	public const StringNames FuelEngines = 46;
	public const StringNames ChartCourse = 47;
	public const StringNames StartReactor = 48;
	public const StringNames SwipeCard = 49;
	public const StringNames ClearAsteroids = 50;
	public const StringNames UploadData = 51;
	public const StringNames DownloadData = 52;
	public const StringNames InspectSample = 53;
	public const StringNames EmptyChute = 54;
	public const StringNames EmptyGarbage = 55;
	public const StringNames AlignEngineOutput = 56;
	public const StringNames FixWiring = 57;
	public const StringNames CalibrateDistributor = 58;
	public const StringNames UnlockManifolds = 59;
	public const StringNames ResetReactor = 60;
	public const StringNames FixLights = 61;
	public const StringNames FixComms = 62;
	public const StringNames RestoreOxy = 63;
	public const StringNames CleanO2Filter = 64;
	public const StringNames StabilizeSteering = 65;
	public const StringNames AssembleArtifact = 66;
	public const StringNames SortSamples = 67;
	public const StringNames MeasureWeather = 68;
	public const StringNames EnterIdCode = 69;
	public const StringNames HowToPlayText1 = 70;
	public const StringNames HowToPlayText2 = 71;
	public const StringNames HowToPlayText5 = 72;
	public const StringNames HowToPlayText6 = 73;
	public const StringNames HowToPlayText7 = 74;
	public const StringNames HowToPlayText81 = 75;
	public const StringNames HowToPlayText82 = 76;
	public const StringNames NumImpostorsS = 77;
	public const StringNames NumImpostorsP = 78;
	public const StringNames Crewmate = 79;
	public const StringNames Impostor = 80;
	public const StringNames Victory = 81;
	public const StringNames Defeat = 82;
	public const StringNames CrewmatesDisconnected = 83;
	public const StringNames ImpostorDisconnected = 84;
	public const StringNames HowToPlayText41 = 85;
	public const StringNames HowToPlayText42 = 86;
	public const StringNames HowToPlayText43 = 87;
	public const StringNames HowToPlayText44 = 88;
	public const StringNames HowToPlayTextMap = 89;
	public const StringNames HowToPlayTextCrew1 = 90;
	public const StringNames HowToPlayTextCrew2 = 91;
	public const StringNames HowToPlayTextCrew3 = 92;
	public const StringNames HowToPlayTextCrew4 = 93;
	public const StringNames HowToPlayTextCrew5 = 94;
	public const StringNames HowToPlayTextCrew6 = 95;
	public const StringNames HowToPlayTextImp1 = 96;
	public const StringNames HowToPlayTextImp2 = 97;
	public const StringNames HowToPlayTextImp3 = 98;
	public const StringNames HowToPlayTextImp4 = 99;
	public const StringNames HowToPlayTextImp5 = 100;
	public const StringNames HowToPlayTextImp6 = 101;
	public const StringNames HowToPlayTextImp7 = 102;
	public const StringNames SettingsGeneral = 103;
	public const StringNames SettingsControls = 104;
	public const StringNames SettingsSound = 105;
	public const StringNames SettingsGraphics = 106;
	public const StringNames SettingsData = 107;
	public const StringNames SettingsCensorChat = 108;
	public const StringNames SettingsMusic = 109;
	public const StringNames SettingsSFX = 110;
	public const StringNames SettingsOn = 111;
	public const StringNames SettingsOff = 112;
	public const StringNames SettingsSendTelemetry = 113;
	public const StringNames SettingsControlMode = 114;
	public const StringNames SettingsTouchMode = 115;
	public const StringNames SettingsJoystickMode = 116;
	public const StringNames SettingsKeyboardMode = 117;
	public const StringNames SettingsFullscreen = 118;
	public const StringNames SettingsResolution = 119;
	public const StringNames SettingsApply = 120;
	public const StringNames SettingsPersonalizeAds = 121;
	public const StringNames SettingsLanguage = 122;
	public const StringNames SettingsJoystickSize = 123;
	public const StringNames SettingsMouseMode = 124;
	public const StringNames PlayerColor = 125;
	public const StringNames PlayerHat = 126;
	public const StringNames PlayerSkin = 127;
	public const StringNames PlayerPet = 128;
	public const StringNames GameSettings = 129;
	public const StringNames GameRecommendedSettings = 130;
	public const StringNames GameCustomSettings = 131;
	public const StringNames GameMapName = 132;
	public const StringNames GameNumImpostors = 133;
	public const StringNames GameNumMeetings = 134;
	public const StringNames GameDiscussTime = 135;
	public const StringNames GameVotingTime = 136;
	public const StringNames GamePlayerSpeed = 137;
	public const StringNames GameCrewLight = 138;
	public const StringNames GameImpostorLight = 139;
	public const StringNames GameKillCooldown = 140;
	public const StringNames GameKillDistance = 141;
	public const StringNames GameCommonTasks = 142;
	public const StringNames GameLongTasks = 143;
	public const StringNames GameShortTasks = 144;
	public const StringNames MatchMapName = 145;
	public const StringNames MatchLanguage = 146;
	public const StringNames MatchImpostors = 147;
	public const StringNames MatchMaxPlayers = 148;
	public const StringNames Cancel = 149;
	public const StringNames Confirm = 150;
	public const StringNames Limit = 151;
	public const StringNames RoomCode = 152;
	public const StringNames LeaveGame = 153;
	public const StringNames ReturnToGame = 154;
	public const StringNames LocalHelp = 155;
	public const StringNames OnlineHelp = 156;
	public const StringNames SettingsVSync = 157;
	public const StringNames EmergencyCount = 158;
	public const StringNames EmergencyNotReady = 159;
	public const StringNames EmergencyDuringCrisis = 160;
	public const StringNames EmergencyRequested = 161;
	public const StringNames GameEmergencyCooldown = 162;
	public const StringNames BuyBeverage = 163;
	public const StringNames WeatherEta = 164;
	public const StringNames WeatherComplete = 165;
	public const StringNames ProcessData = 166;
	public const StringNames RunDiagnostics = 167;
	public const StringNames WaterPlants = 168;
	public const StringNames PickAnomaly = 169;
	public const StringNames WaterPlantsGetCan = 170;
	public const StringNames AuthOfficeOkay = 171;
	public const StringNames AuthCommsOkay = 172;
	public const StringNames AuthOfficeActive = 173;
	public const StringNames AuthCommsActive = 174;
	public const StringNames AuthOfficeNotActive = 175;
	public const StringNames AuthCommsNotActive = 176;
	public const StringNames SecLogEntry = 177;
	public const StringNames EnterName = 178;
	public const StringNames SwipeCardPleaseSwipe = 179;
	public const StringNames SwipeCardBadRead = 180;
	public const StringNames SwipeCardTooFast = 181;
	public const StringNames SwipeCardTooSlow = 182;
	public const StringNames SwipeCardAccepted = 183;
	public const StringNames ReactorHoldToStop = 184;
	public const StringNames ReactorWaiting = 185;
	public const StringNames ReactorNominal = 186;
	public const StringNames MeetingWhoIsTitle = 187;
	public const StringNames MeetingVotingBegins = 188;
	public const StringNames MeetingVotingEnds = 189;
	public const StringNames MeetingVotingResults = 190;
	public const StringNames MeetingProceeds = 191;
	public const StringNames MeetingHasVoted = 192;
	public const StringNames DataPolicyTitle = 193;
	public const StringNames DataPolicyText = 194;
	public const StringNames DataPolicyWhat = 195;
	public const StringNames AdPolicyTitle = 196;
	public const StringNames AdPolicyText = 197;
	public const StringNames Accept = 198;
	public const StringNames RemoveAds = 199;
	public const StringNames SwipeCardPleaseInsert = 200;
	public const StringNames LogNorth = 201;
	public const StringNames LogSouthEast = 202;
	public const StringNames LogSouthWest = 203;
	public const StringNames SettingShort = 204;
	public const StringNames SettingMedium = 205;
	public const StringNames SettingLong = 206;
	public const StringNames SamplesPress = 207;
	public const StringNames SamplesAdding = 208;
	public const StringNames SamplesSelect = 209;
	public const StringNames SamplesThanks = 210;
	public const StringNames SamplesComplete = 211;
	public const StringNames AstDestroyed = 212;
	public const StringNames TaskTestTitle = 213;
	public const StringNames BeginDiagnostics = 214;
	public const StringNames UserLeftGame = 215;
	public const StringNames GameStarting = 216;
	public const StringNames Tasks = 217;
	public const StringNames StatsTitle = 218;
	public const StringNames StatsBodiesReported = 219;
	public const StringNames StatsEmergenciesCalled = 220;
	public const StringNames StatsTasksCompleted = 221;
	public const StringNames StatsAllTasksCompleted = 222;
	public const StringNames StatsSabotagesFixed = 223;
	public const StringNames StatsImpostorKills = 224;
	public const StringNames StatsTimesMurdered = 225;
	public const StringNames StatsTimesEjected = 226;
	public const StringNames StatsCrewmateStreak = 227;
	public const StringNames StatsGamesImpostor = 228;
	public const StringNames StatsGamesCrewmate = 229;
	public const StringNames StatsGamesStarted = 230;
	public const StringNames StatsGamesFinished = 231;
	public const StringNames StatsImpostorVoteWins = 232;
	public const StringNames StatsImpostorKillsWins = 233;
	public const StringNames StatsImpostorSabotageWins = 234;
	public const StringNames StatsCrewmateVoteWins = 235;
	public const StringNames StatsCrewmateTaskWins = 236;
	public const StringNames MedscanRequested = 237;
	public const StringNames MedscanWaitingFor = 238;
	public const StringNames MedscanCompleted = 239;
	public const StringNames MedscanCompleteIn = 240;
	public const StringNames MonitorOxygen = 241;
	public const StringNames StoreArtifacts = 242;
	public const StringNames FillCanisters = 243;
	public const StringNames FixWeatherNode = 244;
	public const StringNames InsertKeys = 245;
	public const StringNames ResetSeismic = 246;
	public const StringNames SeismicHoldToStop = 247;
	public const StringNames SeismicNominal = 248;
	public const StringNames ScanBoardingPass = 249;
	public const StringNames OpenWaterways = 250;
	public const StringNames ReplaceWaterJug = 251;
	public const StringNames RepairDrill = 252;
	public const StringNames AlignTelescope = 253;
	public const StringNames RecordTemperature = 254;
	public const StringNames RebootWifi = 255;
	public const StringNames WifiRebootRequired = 256;
	public const StringNames WifiPleasePowerOn = 257;
	public const StringNames WifiPleaseWait = 258;
	public const StringNames WifiPleaseReturnIn = 259;
	public const StringNames WifiRebootComplete = 260;
	public const StringNames Outside = 261;
	public const StringNames GameSecondsAbbrev = 262;
	public const StringNames Engines = 263;
	public const StringNames Dropship = 264;
	public const StringNames Decontamination2 = 265;
	public const StringNames Specimens = 266;
	public const StringNames BoilerRoom = 267;
	public const StringNames GameOverImpostorDead = 268;
	public const StringNames GameOverImpostorKills = 269;
	public const StringNames GameOverTaskWin = 270;
	public const StringNames GameOverSabotage = 271;
	public const StringNames GameConfirmImpostor = 272;
	public const StringNames GameVisualTasks = 273;
	public const StringNames ExileTextNonConfirm = 274;
	public const StringNames GameAnonymousVotes = 275;
	public const StringNames GameTaskBarMode = 276;
	public const StringNames SettingNormalTaskMode = 277;
	public const StringNames SettingMeetingTaskMode = 278;
	public const StringNames SettingInvisibleTaskMode = 279;
	public const StringNames PlainYes = 280;
	public const StringNames PlainNo = 281;
	public const StringNames PrivacyPolicyTitle = 282;
	public const StringNames PrivacyPolicyText = 283;
	public const StringNames ManageDataButton = 284;
	public const StringNames UnderstandButton = 285;
	public const StringNames HowToPlayText2Switch = 286;
	public const StringNames ChatRateLimit = 287;
	public const StringNames TotalTasksCompleted = 288;
	public const StringNames ServerNA = 289;
	public const StringNames ServerEU = 290;
	public const StringNames ServerAS = 291;
	public const StringNames ServerSA = 292;
	public const StringNames LangEnglish = 293;
	public const StringNames LangFrench = 294;
	public const StringNames LangItalian = 295;
	public const StringNames LangGerman = 296;
	public const StringNames LangSpanish = 297;
	public const StringNames LangSpanishLATAM = 298;
	public const StringNames LangBrazPort = 299;
	public const StringNames LangPort = 300;
	public const StringNames LangRussian = 301;
	public const StringNames LangJapanese = 302;
	public const StringNames LangKorean = 303;
	public const StringNames LangDutch = 304;
	public const StringNames LangFilipino = 305;
	public const StringNames PlayerName = 306;
	public const StringNames MyTablet = 307;
	public const StringNames Download = 308;
	public const StringNames DownloadComplete = 309;
	public const StringNames DownloadTestEstTimeS = 310;
	public const StringNames DownloadTestEstTimeMS = 311;
	public const StringNames DownloadTestEstTimeHMS = 312;
	public const StringNames DownloadTestEstTimeDHMS = 313;
	public const StringNames Upload = 314;
	public const StringNames Headquarters = 315;
	public const StringNames GrabCoffee = 316;
	public const StringNames TakeBreak = 317;
	public const StringNames DontNeedWait = 318;
	public const StringNames DoSomethingElse = 319;
	public const StringNames NodeTB = 320;
	public const StringNames NodeIRO = 321;
	public const StringNames NodeGI = 322;
	public const StringNames NodePD = 323;
	public const StringNames NodeCA = 324;
	public const StringNames NodeMLG = 325;
	public const StringNames Vending = 326;
	public const StringNames OtherLanguage = 327;
	public const StringNames ImposterAmtAny = 328;
	public const StringNames VitalsORGN = 329;
	public const StringNames VitalsBLUE = 330;
	public const StringNames VitalsRED = 331;
	public const StringNames VitalsBRWN = 332;
	public const StringNames VitalsGRN = 333;
	public const StringNames VitalsPINK = 334;
	public const StringNames VitalsWHTE = 335;
	public const StringNames VitalsYLOW = 336;
	public const StringNames VitalsBLAK = 337;
	public const StringNames VitalsPURP = 338;
	public const StringNames VitalsCYAN = 339;
	public const StringNames VitalsLIME = 340;
	public const StringNames VitalsOK = 341;
	public const StringNames VitalsDEAD = 342;
	public const StringNames VitalsDC = 343;
	public const StringNames ColorOrange = 344;
	public const StringNames ColorBlue = 345;
	public const StringNames ColorRed = 346;
	public const StringNames ColorBrown = 347;
	public const StringNames ColorGreen = 348;
	public const StringNames ColorPink = 349;
	public const StringNames ColorWhite = 350;
	public const StringNames ColorYellow = 351;
	public const StringNames ColorBlack = 352;
	public const StringNames ColorPurple = 353;
	public const StringNames ColorCyan = 354;
	public const StringNames ColorLime = 355;
	public const StringNames MedID = 356;
	public const StringNames MedC = 357;
	public const StringNames MedHT = 358;
	public const StringNames MedBT = 359;
	public const StringNames MedWT = 360;
	public const StringNames MedETA = 361;
	public const StringNames MedHello = 362;
	public const StringNames PetFailFetchData = 363;
	public const StringNames BadResult = 364;
	public const StringNames More = 365;
	public const StringNames Processing = 366;
	public const StringNames ExitGame = 367;
	public const StringNames WaitingForHost = 368;
	public const StringNames LeftGameError = 369;
	public const StringNames PlayerWasBannedBy = 370;
	public const StringNames PlayerWasKickedBy = 371;
	public const StringNames CamEast = 372;
	public const StringNames CamCentral = 373;
	public const StringNames CamNortheast = 374;
	public const StringNames CamSouth = 375;
	public const StringNames CamSouthwest = 376;
	public const StringNames CamNorthwest = 377;
	public const StringNames LoadingFailed = 378;
	public const StringNames LobbySizeWarning = 379;
	public const StringNames Okay = 380;
	public const StringNames OkayDontShow = 381;
	public const StringNames Nevermind = 382;
	public const StringNames Dummy = 383;
	public const StringNames Bad = 384;
	public const StringNames Status = 385;
	public const StringNames Fine = 386;
	public const StringNames OK = 387;
	public const StringNames PetTryOn = 388;
	public const StringNames SecondsAbbv = 389;
	public const StringNames SecurityLogsSystem = 390;
	public const StringNames SecurityCamsSystem = 391;
	public const StringNames AdminMapSystem = 392;
	public const StringNames VitalsSystem = 393;
	public const StringNames BanButton = 394;
	public const StringNames KickButton = 395;
	public const StringNames ReportButton = 396;
	public const StringNames ReportConfirmation = 397;
	public const StringNames ReportBadName = 398;
	public const StringNames ReportBadChat = 399;
	public const StringNames ReportHacking = 400;
	public const StringNames ReportHarassment = 401;
	public const StringNames ReportWhy = 402;
	public const StringNames Visor = 403;
	public const StringNames NamePlate = 404;
	public const StringNames Visors = 405;
	public const StringNames NamePlates = 406;
	public const StringNames Cosmicube = 407;
	public const StringNames Cosmicubes = 408;
	public const StringNames Activate = 409;
	public const StringNames Deactivate = 410;
	public const StringNames Owned = 411;
	public const StringNames Purchase = 412;
	public const StringNames CosmicubeProgression = 413;
	public const StringNames ViewCube = 414;
	public const StringNames ConfirmPurchaseHeader = 415;
	public const StringNames ConfirmPurchaseText = 416;
	public const StringNames DeactivateCube = 417;
	public const StringNames ActivateCube = 418;
	public const StringNames Bundles = 419;
	public const StringNames Stars = 420;
	public const StringNames PurchasingLabel = 421;
	public const StringNames MouseMovement = 422;
	public const StringNames KeyboardOptions = 423;
	public const StringNames RemapBindings = 424;
	public const StringNames KeyboardBindingsHeader = 425;
	public const StringNames ExitButton = 426;
	public const StringNames PolishRuby = 500;
	public const StringNames ResetBreakers = 501;
	public const StringNames Decontaminate = 502;
	public const StringNames MakeBurger = 503;
	public const StringNames UnlockSafe = 504;
	public const StringNames SortRecords = 505;
	public const StringNames PutAwayPistols = 506;
	public const StringNames FixShower = 507;
	public const StringNames CleanToilet = 508;
	public const StringNames DressMannequin = 509;
	public const StringNames PickUpTowels = 510;
	public const StringNames RewindTapes = 511;
	public const StringNames StartFans = 512;
	public const StringNames DevelopPhotos = 513;
	public const StringNames GetBiggolSword = 514;
	public const StringNames PutAwayRifles = 515;
	public const StringNames StopCharles = 516;
	public const StringNames AuthLeftOkay = 517;
	public const StringNames AuthRightOkay = 518;
	public const StringNames AuthLeftActive = 519;
	public const StringNames AuthRightActive = 520;
	public const StringNames AuthLeftNotActive = 521;
	public const StringNames AuthRightNotActive = 522;
	public const StringNames LobbyTimerExpiringTitle = 523;
	public const StringNames LobbyTimerExpiringMsg = 524;
	public const StringNames LobbyTimerExpiringOk = 525;
	public const StringNames LobbyTimerExpiringNo = 526;
	public const StringNames LobbyTimerExpiringUnit = 527;
	public const StringNames LobbyTimerExpiringMsg2 = 528;
	public const StringNames LobbyTimerExpiringHud = 529;
	public const StringNames VaultRoom = 550;
	public const StringNames Cockpit = 551;
	public const StringNames Armory = 552;
	public const StringNames Kitchen = 553;
	public const StringNames ViewingDeck = 554;
	public const StringNames HallOfPortraits = 555;
	public const StringNames Medical = 556;
	public const StringNames CargoBay = 557;
	public const StringNames Ventilation = 558;
	public const StringNames Showers = 559;
	public const StringNames Engine = 560;
	public const StringNames Brig = 561;
	public const StringNames MeetingRoom = 562;
	public const StringNames Records = 563;
	public const StringNames Lounge = 564;
	public const StringNames GapRoom = 565;
	public const StringNames MainHall = 566;
	public const StringNames RevealCode = 567;
	public const StringNames DirtyHeader = 568;
	public const StringNames ErrorServerOverload = 700;
	public const StringNames ErrorIntentionalLeaving = 701;
	public const StringNames ErrorFocusLost = 702;
	public const StringNames ErrorBanned = 703;
	public const StringNames ErrorKicked = 704;
	public const StringNames ErrorBannedNoCode = 705;
	public const StringNames ErrorKickedNoCode = 706;
	public const StringNames ErrorHacking = 707;
	public const StringNames ErrorFullGame = 708;
	public const StringNames ErrorStartedGame = 709;
	public const StringNames ErrorNotFoundGame = 710;
	public const StringNames ErrorInactivity = 711;
	public const StringNames ErrorGenericOnlineDisconnect = 712;
	public const StringNames ErrorGenericLocalDisconnect = 713;
	public const StringNames ErrorInvalidName = 714;
	public const StringNames ErrorUnknown = 715;
	public const StringNames ErrorIncorrectVersion = 716;
	public const StringNames ErrorNotAuthenticated = 717;
	public const StringNames ErrorInternalServer = 718;
	public const StringNames ErrorPlatformLock = 719;
	public const StringNames ErrorLobbyInactivity = 720;
	public const StringNames ErrorMatchmakerInactivity = 721;
	public const StringNames ErrorInvalidGameOptions = 722;
	public const StringNames ErrorNoServersAvailable = 723;
	public const StringNames ErrorQuickmatchDisabled = 724;
	public const StringNames ErrorTooManyGames = 725;
	public const StringNames ErrorDuplicateConnection = 726;
	public const StringNames ErrorTooManyRequests = 727;
	public const StringNames ErrorSanction = 728;
	public const StringNames ErrorClientTimeout = 729;
	public const StringNames ErrorClientTimeoutConsole = 730;
	public const StringNames ErrorAuthNonceFailure = 731;
	public const StringNames VentDirection = 1000;
	public const StringNames VentMove = 1001;
	public const StringNames MenuNavigate = 1002;
	public const StringNames NoTranslation = 1003;
	public const StringNames NsoError = 1004;
	public const StringNames Roles = 1499;
	public const StringNames RolesSettings = 1500;
	public const StringNames ScientistRole = 1501;
	public const StringNames EngineerRole = 1502;
	public const StringNames GuardianAngelRole = 1503;
	public const StringNames ShapeshifterRole = 1504;
	public const StringNames ScientistBlurb = 1505;
	public const StringNames EngineerBlurb = 1506;
	public const StringNames GuardianAngelBlurb = 1507;
	public const StringNames ShapeshifterBlurb = 1508;
	public const StringNames CrewmateBlurb = 1509;
	public const StringNames ImpostorBlurb = 1510;
	public const StringNames YourRoleIs = 1511;
	public const StringNames ShapeshiftAbility = 1512;
	public const StringNames VentAbility = 1513;
	public const StringNames VitalsAbility = 1514;
	public const StringNames ProtectAbility = 1515;
	public const StringNames ShapeshiftAbilityUndo = 1516;
	public const StringNames RoleChanceAndQuantity = 1517;
	public const StringNames ProtectedRecently = 1518;
	public const StringNames ShapeshifterDuration = 1519;
	public const StringNames ShapeshifterCooldown = 1520;
	public const StringNames ShapeshifterLeaveSkin = 1521;
	public const StringNames ScientistCooldown = 1522;
	public const StringNames GuardianAngelCooldown = 1523;
	public const StringNames EngineerCooldown = 1524;
	public const StringNames ScientistBlurbMed = 1525;
	public const StringNames ScientistBlurbLong = 1526;
	public const StringNames EngineerBlurbMed = 1527;
	public const StringNames EngineerBlurbLong = 1528;
	public const StringNames GuardianAngelBlurbMed = 1529;
	public const StringNames GuardianAngelBlurbLong = 1530;
	public const StringNames ShapeshifterBlurbMed = 1531;
	public const StringNames ShapeshifterBlurbLong = 1532;
	public const StringNames RoleHint = 1533;
	public const StringNames EngineerInVentCooldown = 1534;
	public const StringNames ScientistBatteryCharge = 1535;
	public const StringNames GuardianAngelDuration = 1536;
	public const StringNames GuardianAngelImpostorSeeProtect = 1537;
	public const StringNames StatsRoleWins = 1538;
	public const StringNames StatsEngineerVents = 1539;
	public const StringNames StatsScientistChargesGained = 1540;
	public const StringNames StatsGuardianAngelCrewmatesProtected = 1541;
	public const StringNames StatsShapeshifterShiftedKills = 1542;
	public const StringNames CrewmateGhostRole = 1543;
	public const StringNames ImpostorGhostRole = 1544;
	public const StringNames HauntAbilityName = 1545;
	public const StringNames SeekButton = 1546;
	public const StringNames RolesHelp_CrewmateRole = 1547;
	public const StringNames RolesHelp_ImpostorRole = 1548;
	public const StringNames RolesHelpIntro_01 = 1549;
	public const StringNames RolesHelpIntro_02 = 1550;
	public const StringNames RolesHelp_Scientist_01 = 1560;
	public const StringNames RolesHelp_Scientist_02 = 1561;
	public const StringNames RolesHelp_Engineer_01 = 1562;
	public const StringNames RolesHelp_Engineer_02 = 1563;
	public const StringNames RolesHelp_GuardianAngel_01 = 1564;
	public const StringNames RolesHelp_GuardianAngel_02 = 1565;
	public const StringNames RolesHelp_Noisemaker_01 = 1566;
	public const StringNames RolesHelp_Noisemaker_02 = 1567;
	public const StringNames RolesHelp_Tracker_01 = 1568;
	public const StringNames RolesHelp_Tracker_02 = 1569;
	public const StringNames RolesHelp_Shapeshifter_01 = 1600;
	public const StringNames RolesHelp_Shapeshifter_02 = 1601;
	public const StringNames RolesHelp_Phantom_01 = 1602;
	public const StringNames RolesHelp_Phantom_02 = 1603;
	public const StringNames RolesHelpOutro_01 = 1650;
	public const StringNames RolesHelpOutro_02 = 1651;
	public const StringNames NoisemakerRole = 1660;
	public const StringNames NoisemakerBlurb = 1661;
	public const StringNames NoisemakerBlurbMed = 1662;
	public const StringNames NoisemakerBlurbLong = 1663;
	public const StringNames NoisemakerImpostorAlert = 1664;
	public const StringNames NoisemakerAlertDuration = 1665;
	public const StringNames PhantomAbility = 1670;
	public const StringNames PhantomRole = 1671;
	public const StringNames PhantomBlurb = 1672;
	public const StringNames PhantomBlurbMed = 1673;
	public const StringNames PhantomBlurbLong = 1674;
	public const StringNames PhantomCooldown = 1675;
	public const StringNames PhantomDuration = 1676;
	public const StringNames PhantomAbilityUndo = 1677;
	public const StringNames TrackerAbility = 1680;
	public const StringNames TrackerRole = 1681;
	public const StringNames TrackerBlurb = 1682;
	public const StringNames TrackerBlurbMed = 1683;
	public const StringNames TrackerBlurbLong = 1684;
	public const StringNames TrackerCooldown = 1685;
	public const StringNames TrackerDuration = 1686;
	public const StringNames TrackerAbilityUndo = 1687;
	public const StringNames TrackerDelay = 1688;
	public const StringNames SanctionDuration = 1700;
	public const StringNames SanctionPermanent = 1701;
	public const StringNames SanctionConduct = 1702;
	public const StringNames SanctionImpersonationCeleb = 1703;
	public const StringNames SanctionSpamming = 1704;
	public const StringNames SanctionInappropriateNameUnsportsmanlike = 1705;
	public const StringNames SanctionUnsportsmanlikeConduct = 1706;
	public const StringNames SanctionImpersonationDevelopers = 1707;
	public const StringNames SanctionInappropriateChatPersonalInfo = 1708;
	public const StringNames SanctionInappropriateNameDerogatory = 1709;
	public const StringNames SanctionInappropriateNameNsfw = 1710;
	public const StringNames SanctionBullying = 1711;
	public const StringNames SanctionCheatingHacking = 1712;
	public const StringNames SanctionInappropriateChatDating = 1713;
	public const StringNames SanctionWeaponizingRules = 1714;
	public const StringNames SanctionRepeatOffender3 = 1715;
	public const StringNames SanctionSexualMisconduct = 1716;
	public const StringNames SanctionDoxing = 1717;
	public const StringNames SanctionIllegalActivity = 1718;
	public const StringNames SanctionHarassment = 1719;
	public const StringNames SanctionSelfHarmPromotion = 1720;
	public const StringNames SanctionRepeatOffender10 = 1721;
	public const StringNames SanctionUnknown = 1722;
	public const StringNames ScreenShakeOption = 1900;
	public const StringNames FeaturedItems = 1901;
	public const StringNames FeaturedBundles = 1902;
	public const StringNames FeaturedCubes = 1903;
	public const StringNames BugReportPopUpAttachScreenshotDesc = 1904;
	public const StringNames UserIdTokenError = 1905;
	public const StringNames NewGameMode = 1906;
	public const StringNames NewModeInfo = 1907;
	public const StringNames HideSeekHowToPlayTitleOne = 1908;
	public const StringNames HideSeekHowToPlayCaptionOne = 1909;
	public const StringNames HideSeekHowToPlayCaptionTwo = 1910;
	public const StringNames HideSeekHowToPlayCaptionThree = 1911;
	public const StringNames HideSeekHowToPlayPageOne = 1912;
	public const StringNames HideSeekHowToPlayImpostorOne = 1913;
	public const StringNames HideSeekHowToPlaySubtextOne = 1914;
	public const StringNames HideSeekHowToPlayCrewmateInfoOne = 1915;
	public const StringNames HideSeekHowToPlayCrewmateInfoTwo = 1916;
	public const StringNames HideSeekHowToPlayImpostorInfoOne = 1917;
	public const StringNames HideSeekHowToPlayFlashlightDefault = 1918;
	public const StringNames HideSeekHowToPlayFinalHide = 1919;
	public const StringNames HideSeekHowToPlayFlashlightMobile = 1920;
	public const StringNames HideSeekHowToPlayFlashlightSwitch = 1921;
	public const StringNames HideSeekHowToPlayFlashlightConsoles = 1922;
	public const StringNames HideSeekHowToPlayFlashlightPlayStation = 1923;
	public const StringNames QCInputSelf = 1925;
	public const StringNames QCInputFavorite = 1926;
	public const StringNames QCCrewMyself = 1950;
	public const StringNames QCTagSelf = 1951;
	public const StringNames QCTagFavorites = 1952;
	public const StringNames QCBuilderHeader = 1953;
	public const StringNames QCRemarks = 1954;
	public const StringNames QCCrewDead = 1955;
	public const StringNames QCSelfVoted = 1956;
	public const StringNames QCSelfReportedBody = 1957;
	public const StringNames QCSelfCams = 1958;
	public const StringNames QCCrewReportedBody = 1959;
	public const StringNames QCCrewCams = 1960;
	public const StringNames QCSelfWasProtected = 1961;
	public const StringNames QCCrewWasProtected = 1962;
	public const StringNames QCSelfWasntMe = 1963;
	public const StringNames QCWhoWasAt = 1964;
	public const StringNames QCSelfDoingTask = 1965;
	public const StringNames QCWhoIsRole = 1966;
	public const StringNames QCSelfFixedSystem = 1967;
	public const StringNames QCCrewFixedSystem = 1968;
	public const StringNames QCSelfAccAtLocation = 1969;
	public const StringNames QCSelfDidTaskAtLocation = 1970;
	public const StringNames QCCrewDidTaskAtLocation = 1971;
	public const StringNames QCSelfSawCrewVentAtLocation = 1972;
	public const StringNames QCSelfDidntVent = 1973;
	public const StringNames QCFollowMe = 1974;
	public const StringNames QCItsNotMe = 1975;
	public const StringNames QCSelfDoneWithTasks = 1976;
	public const StringNames QCGhostsDoYourTasks = 1977;
	public const StringNames QCSelfNotTheImpostor = 1978;
	public const StringNames QCHello = 1979;
	public const StringNames QCThanks = 1980;
	public const StringNames QCSorry = 1981;
	public const StringNames QCGG = 1982;
	public const StringNames QCBye = 1983;
	public const StringNames QCWhereWasTheBody = 1984;
	public const StringNames QCSelfReady = 1985;
	public const StringNames QCSelfWasRole = 1986;
	public const StringNames QCWhoWasRole = 1987;
	public const StringNames QCCoolOutfitCrew = 1988;
	public const StringNames QCSelfWasUsingBinoculars = 1989;
	public const StringNames QCSelfSawThroughBinoculars = 1990;
	public const StringNames QCInTheSporeCloud = 1991;
	public const StringNames QCHiddenBySporeCloud = 1992;
	public const StringNames CQCrewKilledDeadInSporeCloud = 1993;
	public const StringNames QCSelfUsingZipline = 1994;
	public const StringNames QCSelfSawWhileUsingZipline = 1995;
	public const StringNames QCCrewWasUsingZipline = 1996;
	public const StringNames QCDuringMushroomMixup = 1997;
	public const StringNames QCLocationLaptop = 2000;
	public const StringNames QCSystemsStart = 2004;
	public const StringNames QCSystemsKick = 2005;
	public const StringNames QCCrewI = 2006;
	public const StringNames QCCrewMe = 2007;
	public const StringNames QCCrewNoOne = 2008;
	public const StringNames QCAccAKilledB = 2009;
	public const StringNames QCAccAKilledBNeg = 2010;
	public const StringNames QCAccAIsSuspicious = 2011;
	public const StringNames QCAccAIsSuspiciousNeg = 2012;
	public const StringNames QCAccASawBVent = 2013;
	public const StringNames QCAccASawBVentNeg = 2014;
	public const StringNames QCAccAWasChasingB = 2015;
	public const StringNames QCAccAWasChasingBNeg = 2016;
	public const StringNames QCAccAIsLying = 2017;
	public const StringNames QCAccAIsLyingNeg = 2018;
	public const StringNames QCAccVoteA = 2019;
	public const StringNames QCAccVoteANeg = 2020;
	public const StringNames QCAccADidntReport = 2021;
	public const StringNames QCResYes = 2022;
	public const StringNames QCResNo = 2023;
	public const StringNames QCResDontKnow = 2024;
	public const StringNames QCResDontKnowNeg = 2025;
	public const StringNames QCResAWas = 2026;
	public const StringNames QCResAWasNeg = 2027;
	public const StringNames QCResADid = 2028;
	public const StringNames QCResADidNeg = 2029;
	public const StringNames QCResVote = 2030;
	public const StringNames QCResVoteNeg = 2031;
	public const StringNames QCResAWasAtB = 2032;
	public const StringNames QCResAWasAtBNeg = 2033;
	public const StringNames QCResRip = 2034;
	public const StringNames QCResRipNeg = 2035;
	public const StringNames QCResLies = 2036;
	public const StringNames QCResLiesNeg = 2037;
	public const StringNames QCQstWhere = 2038;
	public const StringNames QCQstWho = 2039;
	public const StringNames QCQstWhoWasWith = 2040;
	public const StringNames QCQstWhatWasADoing = 2041;
	public const StringNames QCQstWhoDidTask = 2042;
	public const StringNames QCQstWhereWasA = 2043;
	public const StringNames QCQstBodyOrMeeting = 2044;
	public const StringNames QCStaASawB = 2045;
	public const StringNames QCStaAWasWithB = 2046;
	public const StringNames QCStaADidB = 2047;
	public const StringNames QCStaASelfReported = 2048;
	public const StringNames QCStaDoubleKill = 2049;
	public const StringNames QCStaWasSelfReport = 2050;
	public const StringNames QCStaPleaseDoTasks = 2051;
	public const StringNames QCStaBodyWasInA = 2052;
	public const StringNames QCStaACalledMeeting = 2053;
	public const StringNames QCLocation = 2054;
	public const StringNames QCSystems = 2055;
	public const StringNames QCCrew = 2056;
	public const StringNames QCAccusation = 2057;
	public const StringNames QCResponse = 2058;
	public const StringNames QCQuestion = 2059;
	public const StringNames QCStatements = 2060;
	public const StringNames ANY = 2061;
	public const StringNames ChatType = 2062;
	public const StringNames QuickChatOnly = 2063;
	public const StringNames FreeChatOnly = 2064;
	public const StringNames FreeOrQuickChat = 2065;
	public const StringNames DateOfBirth = 2066;
	public const StringNames DateOfBirthEnter = 2067;
	public const StringNames Month = 2068;
	public const StringNames Day = 2069;
	public const StringNames Year = 2070;
	public const StringNames January = 2071;
	public const StringNames February = 2072;
	public const StringNames March = 2073;
	public const StringNames April = 2074;
	public const StringNames May = 2075;
	public const StringNames June = 2076;
	public const StringNames July = 2077;
	public const StringNames August = 2078;
	public const StringNames September = 2079;
	public const StringNames October = 2080;
	public const StringNames November = 2081;
	public const StringNames December = 2082;
	public const StringNames Submit = 2083;
	public const StringNames QCMore = 2084;
	public const StringNames Success = 2085;
	public const StringNames Failed = 2086;
	public const StringNames ErrorCreate = 2087;
	public const StringNames SuccessCreate = 2088;
	public const StringNames Close = 2089;
	public const StringNames ErrorLogIn = 2090;
	public const StringNames SuccessLogIn = 2091;
	public const StringNames AccountInfo = 2092;
	public const StringNames Account = 2093;
	public const StringNames UserName = 2094;
	public const StringNames Height = 2095;
	public const StringNames Weight = 2096;
	public const StringNames SignIn = 2097;
	public const StringNames CreateAccount = 2098;
	public const StringNames RequestPermission = 2099;
	public const StringNames RandomizeName = 2100;
	public const StringNames AccountLinking = 2101;
	public const StringNames ChangeName = 2102;
	public const StringNames LogOut = 2103;
	public const StringNames GuardianWait = 2104;
	public const StringNames EmailEdit = 2105;
	public const StringNames EmailResend = 2106;
	public const StringNames GuestContinue = 2107;
	public const StringNames GuardianEmailSent = 2108;
	public const StringNames GuardianCheckEmail = 2109;
	public const StringNames EditName = 2110;
	public const StringNames Name = 2111;
	public const StringNames CreateAccountQuestion = 2112;
	public const StringNames DoYouWantCreate = 2113;
	public const StringNames PermissionRequired = 2114;
	public const StringNames NeedPermissionText = 2115;
	public const StringNames GuardianEmailTitle = 2116;
	public const StringNames Send = 2117;
	public const StringNames NewEmail = 2118;
	public const StringNames ConfirmEmail = 2119;
	public const StringNames EditEmail = 2120;
	public const StringNames Loading = 2121;
	public const StringNames Welcome = 2122;
	public const StringNames DLLNotFoundAccountError = 2123;
	public const StringNames ContinueOffline = 2124;
	public const StringNames CreateTryAgain = 2125;
	public const StringNames WantToLogIn = 2126;
	public const StringNames GoOffline = 2127;
	public const StringNames PlayAsGuest = 2128;
	public const StringNames LogInTitle = 2129;
	public const StringNames LogInInfoText = 2130;
	public const StringNames ShowAccountSupportID5 = 2131;
	public const StringNames ShowAccountSupportID4 = 2132;
	public const StringNames ShowAccountSupportID3 = 2133;
	public const StringNames ShowAccountSupportID2 = 2134;
	public const StringNames ShowAccountSupportID1 = 2135;
	public const StringNames YouAreNotOnline = 2136;
	public const StringNames SaveGameOutOfSpaceMessage = 2137;
	public const StringNames SaveGameOutOfSpaceConfirm = 2138;
	public const StringNames SaveGameOutOfSpaceCancel = 2139;
	public const StringNames EngagementScreen = 2140;
	public const StringNames EngagementScreenSignIn = 2141;
	public const StringNames FollowUs = 2142;
	public const StringNames ColorMaroon = 2143;
	public const StringNames ColorRose = 2144;
	public const StringNames ColorBanana = 2145;
	public const StringNames ColorGray = 2146;
	public const StringNames ColorTan = 2147;
	public const StringNames ColorSunset = 2148;
	public const StringNames QuickChatInstructionsStart = 2149;
	public const StringNames QuickChatInstructionsChild = 2150;
	public const StringNames QuickChatInstructionsGuest = 2151;
	public const StringNames QuickChatInstructionsFull = 2152;
	public const StringNames SwitchEShopBrowseAll = 2153;
	public const StringNames ColorCoral = 2154;
	public const StringNames GuardianEmail = 2155;
	public const StringNames LocalButton = 2156;
	public const StringNames OnlineButton = 2157;
	public const StringNames HowToPlayButton = 2158;
	public const StringNames FreePlayButton = 2159;
	public const StringNames PublicHeader = 2160;
	public const StringNames PrivateHeader = 2161;
	public const StringNames HostHeader = 2162;
	public const StringNames EmergencyMeeting = 2163;
	public const StringNames BodyReported = 2164;
	public const StringNames PlayAgain = 2165;
	public const StringNames QuitLabel = 2166;
	public const StringNames DownloadLabel = 2167;
	public const StringNames UploadLabel = 2168;
	public const StringNames TimeRemaining = 2169;
	public const StringNames AnnouncementLabel = 2170;
	public const StringNames StartLabel = 2171;
	public const StringNames UseLabel = 2172;
	public const StringNames KillLabel = 2173;
	public const StringNames SabotageLabel = 2174;
	public const StringNames VentLabel = 2175;
	public const StringNames OptionsLabel = 2176;
	public const StringNames ReportLabel = 2177;
	public const StringNames CO2Label = 2178;
	public const StringNames NutriLabel = 2179;
	public const StringNames RADLabel = 2180;
	public const StringNames WaterLabel = 2181;
	public const StringNames DiscussLabel = 2182;
	public const StringNames DeadLabel = 2183;
	public const StringNames SkippedVoting = 2184;
	public const StringNames ProceedLabel = 2185;
	public const StringNames HolidayHatLabel = 2186;
	public const StringNames HatLabel = 2187;
	public const StringNames PetLabel = 2188;
	public const StringNames SkinLabel = 2189;
	public const StringNames DoorlogLabel = 2190;
	public const StringNames VitalsLabel = 2191;
	public const StringNames InsufficientStorageError = 2192;
	public const StringNames NetworkError = 2193;
	public const StringNames OtherDownloadError = 2194;
	public const StringNames DownloadingLabel = 2195;
	public const StringNames DownloadSizeLabel = 2196;
	public const StringNames SkipVoteLabel = 2197;
	public const StringNames LogInInfoTextSwitch = 2198;
	public const StringNames WeatherDataDownload = 2199;
	public const StringNames BeginLabel = 2200;
	public const StringNames QuietLabel = 2201;
	public const StringNames LogLabel = 2202;
	public const StringNames ReadingLabel = 2203;
	public const StringNames UploadingLabel = 2204;
	public const StringNames ConnectionLabel = 2205;
	public const StringNames GoodLabel = 2206;
	public const StringNames PoorLabel = 2207;
	public const StringNames NoneLabel = 2208;
	public const StringNames ProgressLabel = 2209;
	public const StringNames PerfectLabel = 2210;
	public const StringNames NoDeadBodiesFound = 2211;
	public const StringNames AirshipBundle = 2212;
	public const StringNames PolusBundle = 2213;
	public const StringNames PolusSkinBundle = 2214;
	public const StringNames MiraBundle = 2215;
	public const StringNames MiraSkinBundle = 2216;
	public const StringNames PetAlien2 = 2217;
	public const StringNames PetAlien1 = 2218;
	public const StringNames PetAnimal = 2219;
	public const StringNames PetCrewmate = 2220;
	public const StringNames PetStickmin = 2221;
	public const StringNames PrisonerSkin = 2222;
	public const StringNames Cyborg_RHM = 2223;
	public const StringNames CCC_Officer = 2224;
	public const StringNames VentCleaning = 2225;
	public const StringNames CleanUp = 2226;
	public const StringNames ControllerDisconnectedMessage = 2227;
	public const StringNames TermsOfUseTitle = 2228;
	public const StringNames PPAndToUTitle = 2229;
	public const StringNames ComePlayDiscord = 2230;
	public const StringNames SupportEmail = 2231;
	public const StringNames SupportIDLabel = 2232;
	public const StringNames pk05_davehat = 2233;
	public const StringNames pk05_Ellie = 2234;
	public const StringNames pk05_Svenhat = 2235;
	public const StringNames pk05_Burthat = 2236;
	public const StringNames pk05_Ellryhat = 2237;
	public const StringNames pk05_monocles = 2238;
	public const StringNames pk05_cheesetoppat = 2239;
	public const StringNames pk05_Macbethhat = 2240;
	public const StringNames pk05_HenryToppat = 2241;
	public const StringNames pk05_EllieToppat = 2242;
	public const StringNames pk05_GeoffreyToppat = 2243;
	public const StringNames InviteFriends = 2244;
	public const StringNames Continue = 2245;
	public const StringNames GameComplete = 2246;
	public const StringNames XpGained = 2247;
	public const StringNames PodsEarned = 2248;
	public const StringNames CosmicubeNodeUnlocked = 2249;
	public const StringNames LevelShorthand = 2250;
	public const StringNames PrestigeLevelShorthand = 2251;
	public const StringNames MaxLevel = 2252;
	public const StringNames EquipLabel = 2253;
	public const StringNames XpGainedValue = 2254;
	public const StringNames PSNErrorSessionFailed = 2255;
	public const StringNames PSNErrorSessionJoinFailed = 2256;
	public const StringNames PSNErrorSessionGetInfoFailed = 2257;
	public const StringNames PSNErrorPSNConnectionLost = 2258;
	public const StringNames PSNErrorUserSignedOut = 2259;
	public const StringNames CrossPlayTitle = 2260;
	public const StringNames CrossPlayAllPlatforms = 2261;
	public const StringNames CrossPlaySamePlatform = 2262;
	public const StringNames QuickChat = 2263;
	public const StringNames TimeOutText = 2264;
	public const StringNames RetryText = 2265;
	public const StringNames PlayerLevel = 2266;
	public const StringNames PlayerXp = 2267;
	public const StringNames PlayerLevelExtremeShorthand = 2268;
	public const StringNames Max = 2269;
	public const StringNames Wardrobe = 2270;
	public const StringNames CopiedText = 2271;
	public const StringNames LinkAccount = 2272;
	public const StringNames CreateNewAccount = 2273;
	public const StringNames LinkExistingAccount = 2274;
	public const StringNames LinkAccountExplanation = 2275;
	public const StringNames LinkAccountCode = 2276;
	public const StringNames ErrorLink = 2277;
	public const StringNames UnlinkAccount = 2278;
	public const StringNames ConfirmUnlinkAccount = 2279;
	public const StringNames UnlinkAccountExplain = 2280;
	public const StringNames UnlinkAccountExplainConfirm = 2281;
	public const StringNames UnlinkError = 2282;
	public const StringNames UnlinkSuccess = 2283;
	public const StringNames ConfirmLinkExistingAccount = 2284;
	public const StringNames LinkExistingAccountExplain = 2285;
	public const StringNames LinkExistingAccountExplainConfirm = 2286;
	public const StringNames ResetAccount = 2287;
	public const StringNames CrossPlayEnabledWarning = 2288;
	public const StringNames StoreComingSoon = 2289;
	public const StringNames Locked = 2290;
	public const StringNames FailPurchase = 2291;
	public const StringNames FailPurchaseUnknown = 2292;
	public const StringNames FailPurchaseAlreadyOwn = 2293;
	public const StringNames FailPurchaseCurrency = 2294;
	public const StringNames FailPurchaseCubeOwn = 2295;
	public const StringNames ErrorPlatformParentalControlsBlock = 2296;
	public const StringNames Crewmates = 2297;
	public const StringNames Colors = 2298;
	public const StringNames Active = 2299;
	public const StringNames Equipped = 2300;
	public const StringNames XboxShopBrowseAll = 2302;
	public const StringNames PSShopBrowseAll = 2303;
	public const StringNames SteamNotInitialized = 2304;
	public const StringNames LoggedInErrorStarPurchase = 2305;
	public const StringNames StarDisclaimer = 2306;
	public const StringNames HowToPlayText_Consoles = 2307;
	public const StringNames ErrorQuickChatMode = 2308;
	public const StringNames ErrorLobbyUsersBlocked = 2309;
	public const StringNames ItchNoStars = 2310;
	public const StringNames CheckingPurchasesLabel = 2311;
	public const StringNames RedeemPurchasedItemsTitle = 2312;
	public const StringNames RedeemPurcahsedItemsExplain = 2313;
	public const StringNames RedeemProceed = 2314;
	public const StringNames RedeemNotYet = 2315;
	public const StringNames AccountIDDisplay = 2316;
	public const StringNames RedeemNever = 2317;
	public const StringNames AvailableFor = 2318;
	public const StringNames GuestProgressionWarning = 2319;
	public const StringNames ErrorSelfPlatformLock = 2320;
	public const StringNames ErrorCrossPlat = 2321;
	public const StringNames SettingsStreamerMode = 2322;
	public const StringNames RoomCodeInfo = 2323;
	public const StringNames AbbreviatedDay = 2324;
	public const StringNames AbbreviatedHour = 2325;
	public const StringNames AbbreviatedMinute = 2326;
	public const StringNames AbbreviatedSecond = 2327;
	public const StringNames StreamingTwitch = 2328;
	public const StringNames MapNameSkeld = 2600;
	public const StringNames MapNameMira = 2601;
	public const StringNames MapNamePolus = 2602;
	public const StringNames MapNameAirship = 2603;
	public const StringNames MapNameFungle = 2604;
	public const StringNames MaxVentUses = 2700;
	public const StringNames MaxTimeInVent = 2701;
	public const StringNames MinCrewmatesForVitals = 2702;
	public const StringNames EscapeTime = 2703;
	public const StringNames AllTasksComplete = 2704;
	public const StringNames EscapePrompt = 2705;
	public const StringNames CrewmateFlashlightSize = 2706;
	public const StringNames ImpostorFlashlightSize = 2707;
	public const StringNames CrewmateLeadTime = 2708;
	public const StringNames CrewmadeHideBlurb = 2709;
	public const StringNames ImpostorKillBlurb = 2710;
	public const StringNames HideCountdown = 2711;
	public const StringNames ScaryMusicDistance = 2712;
	public const StringNames ShortTaskTimeValue = 2713;
	public const StringNames LongTaskTimeValue = 2714;
	public const StringNames CommonTaskTimeValue = 2715;
	public const StringNames UseFlashlight = 2716;
	public const StringNames FinalEscapeTime = 2717;
	public const StringNames VeryScaryMusicDistance = 2718;
	public const StringNames SeekerFinalSpeed = 2719;
	public const StringNames SeekerFinalVents = 2720;
	public const StringNames SeekerFinalMap = 2721;
	public const StringNames CrewmateVentCooldown = 2722;
	public const StringNames SeekerPings = 2723;
	public const StringNames MaxPingTime = 2724;
	public const StringNames ShowPingTime = 2725;
	public const StringNames MinPingTime = 2726;
	public const StringNames ShowCrewmateNames = 2727;
	public const StringNames ShowImpostorNames = 2728;
	public const StringNames HideActionButton = 2729;
	public const StringNames RuleOneCrewmates = 2730;
	public const StringNames RuleTwoCrewmates = 2731;
	public const StringNames RuleThreeCrewmates = 2732;
	public const StringNames RuleOneImpostor = 2733;
	public const StringNames RuleTwoImpostor = 2734;
	public const StringNames RuleThreeImpostor = 2735;
	public const StringNames RuleOneCrewmatesTitle = 2736;
	public const StringNames RuleTwoCrewmatesTitle = 2737;
	public const StringNames RuleThreeCrewmatesTitle = 2738;
	public const StringNames RuleOneImpostorTitle = 2739;
	public const StringNames RuleTwoImpostorTitle = 2740;
	public const StringNames RoundRobin = 2741;
	public const StringNames OptionUnavailablePublicLobby = 2742;
	public const StringNames StatsHidenSeekGamesCrewmateSurvived = 2743;
	public const StringNames StatsHidenSeekTimesVented = 2744;
	public const StringNames StatsTimesPettedPet = 2745;
	public const StringNames StatsImpostorKills_HideAndSeek = 2746;
	public const StringNames StatsFastestCrewmateWin_HideAndSeek = 2747;
	public const StringNames StatsFastestImpostorWin_HideAndSeek = 2748;
	public const StringNames StatsHideAndSeekImpostorVictory = 2749;
	public const StringNames StatsHideAndSeekCrewmateVictory = 2750;
	public const StringNames AmongUsFriends = 2800;
	public const StringNames FriendsGuestWarning = 2801;
	public const StringNames PlatformFriends = 2802;
	public const StringNames BlockedPlayers = 2803;
	public const StringNames RecentPlayers = 2804;
	public const StringNames LobbyLabel = 2805;
	public const StringNames FriendCodeExplanation = 2806;
	public const StringNames FriendCodeSuccess = 2807;
	public const StringNames FriendRequestReceived = 2808;
	public const StringNames FriendRequestSent = 2809;
	public const StringNames GameLobbyInviteSent = 2810;
	public const StringNames GameLobbyInviteReceived = 2811;
	public const StringNames BlockPlayerConfirm = 2812;
	public const StringNames RemoveFriendConfirm = 2813;
	public const StringNames InviteToLobbyConfirm = 2814;
	public const StringNames FriendCodeLabel = 2815;
	public const StringNames FriendCodeCreationTitle = 2816;
	public const StringNames FriendRequestSentFailed = 2817;
	public const StringNames ErrorBadUsername = 2818;
	public const StringNames ErrorUserNotFound = 2819;
	public const StringNames ErrorThisIsYou = 2820;
	public const StringNames ErrorFriendRequestExists = 2821;
	public const StringNames ErrorAlreadyFriends = 2822;
	public const StringNames GameLobbyInviteSentFailed = 2823;
	public const StringNames BlockedPlayerFailed = 2824;
	public const StringNames BlockedPlayer = 2825;
	public const StringNames AlreadyBlocked = 2826;
	public const StringNames FriendList = 2827;
	public const StringNames NoNewRequests = 2828;
	public const StringNames AddFriendPrompt = 2829;
	public const StringNames NewRequests = 2830;
	public const StringNames Requests = 2831;
	public const StringNames AddFriend = 2832;
	public const StringNames StreamWarning = 2833;
	public const StringNames FriendsListPermissionsWarning = 2834;
	public const StringNames AddFriendConfirm = 2835;
	public const StringNames UnfriendConfirm = 2836;
	public const StringNames UnblockConfirm = 2837;
	public const StringNames SettingsEnableFriendInvites = 2838;
	public const StringNames ErrorCrossPlatformCommunication = 2839;
	public const StringNames ErrorPlatformFriends = 2840;
	public const StringNames ErrorPlayerBlockedYou = 2841;
	public const StringNames ErrorRecipientMaxFriendRequests = 2842;
	public const StringNames ErrorSenderMaxFriendRequests = 2843;
	public const StringNames ErrorMaxFriends = 2844;
	public const StringNames ErrorRecipientMaxFriends = 2845;
	public const StringNames ParentPortalButton = 2846;
	public const StringNames FriendsListEmailSent = 2847;
	public const StringNames AndroidAssetBundleWarning = 2848;
	public const StringNames FreeChatLinkWarning = 2849;
	public const StringNames FriendListUnavailable = 2850;
	public const StringNames SignInIssueTitle = 2851;
	public const StringNames SignInIssueText = 2852;
	public const StringNames Ghost = 2853;
	public const StringNames CurrentlyHaunting = 2854;
	public const StringNames RestorePurchases = 2855;
	public const StringNames QCAccIsRole = 3000;
	public const StringNames QCAccIsRoleNeg = 3001;
	public const StringNames QCAccShapeshited = 3002;
	public const StringNames QCStaShapeshifterSkin = 3003;
	public const StringNames QCResIsBeingFramed = 3004;
	public const StringNames QCResIsRoleMaybe = 3005;
	public const StringNames QCResCloseTo = 3006;
	public const StringNames QCResProtected = 3007;
	public const StringNames QCRoles = 3008;
	public const StringNames ErrorFailedToCreateGame = 3009;
	public const StringNames ErrorFailedToJoinCreatedGame = 3010;
	public const StringNames ErrorDisconnectBeforeJoining = 3011;
	public const StringNames ErrorDisconnectPacket = 3012;
	public const StringNames PSEULA_SIEA = 3013;
	public const StringNames PSEULA_SIEE = 3014;
	public const StringNames ShowAccountID = 3015;
	public const StringNames HideAccountID = 3016;
	public const StringNames HiddenAccountID = 3017;
	public const StringNames ErrorLobbyFailedGettingBlockedUsers = 3018;
	public const StringNames SteamOverlayDisabled = 3019;
	public const StringNames QCOnlyInfo = 3020;
	public const StringNames FreeChatInfo = 3021;
	public const StringNames FreeChatWarning = 3022;
	public const StringNames TryAgain = 3023;
	public const StringNames TempDisabled = 3024;
	public const StringNames TempDisabledLinkExplain = 3025;
	public const StringNames RedeemPopup = 3026;
	public const StringNames RedeemButton = 3027;
	public const StringNames Decontamination3 = 3028;
	public const StringNames MergeGuestAccountText = 3029;
	public const StringNames MergeGuestAccountTitle = 3030;
	public const StringNames ErrorCommunications = 3031;
	public const StringNames ManageAccountTitle = 3032;
	public const StringNames ManageAccountText = 3033;
	public const StringNames Email = 3034;
	public const StringNames BugReportPopUpSubmittedText = 3035;
	public const StringNames BugReportPopUpCategoryLabel = 3036;
	public const StringNames BugReportPopUpDescriptionLabel = 3037;
	public const StringNames BugReportPopUpTitle = 3038;
	public const StringNames BugReportCategoryServerIssues = 3039;
	public const StringNames BugReportCategoryGameplayIssue = 3040;
	public const StringNames BugReportCategoryAccountManagement = 3041;
	public const StringNames BugReportCategoryBilling = 3042;
	public const StringNames BugReportCategoryGeneral = 3043;
	public const StringNames BugReportIssueButton = 3044;
	public const StringNames BugReportPopUpSubmissionFailedText = 3045;
	public const StringNames BugReportPopUpAttachScreenshotLabel = 3046;
	public const StringNames QCQstWhy = 3050;
	public const StringNames QCTagAccuse = 3051;
	public const StringNames QCTagDefend = 3052;
	public const StringNames QCTagQuestion = 3053;
	public const StringNames QCTagLobby = 3054;
	public const StringNames QCTagImpostor = 3055;
	public const StringNames QCTagMeeting = 3056;
	public const StringNames QCTagHiding = 3057;
	public const StringNames QCTagFlashlight = 3058;
	public const StringNames QCTagRoles = 3059;
	public const StringNames QCInputRole = 3060;
	public const StringNames QCTagTasks = 3061;
	public const StringNames QCInputTask = 3062;
	public const StringNames QCTagSabotages = 3063;
	public const StringNames QCInputSabotages = 3064;
	public const StringNames QCTagRemarks = 3065;
	public const StringNames QCInputRemark = 3066;
	public const StringNames QCInputAccusation = 3067;
	public const StringNames QCInputDefense = 3068;
	public const StringNames QCTagQuestionSingular = 3069;
	public const StringNames QCResAgree = 3070;
	public const StringNames QCResDisagree = 3071;
	public const StringNames QCResNice = 3072;
	public const StringNames QCResUhOh = 3073;
	public const StringNames QCResOops = 3074;
	public const StringNames QCResExclamationMarks = 3075;
	public const StringNames QCResQuestionMarks = 3076;
	public const StringNames QCBuildingPlaceholder = 3077;
	public const StringNames QCTagQuickRemarks = 3078;
	public const StringNames FixWiringName = 3079;
	public const StringNames FixLightsName = 3080;
	public const StringNames DoorsName = 3081;
	public const StringNames Undo = 3095;
	public const StringNames Clear = 3096;
	public const StringNames DivertPower = 3097;
	public const StringNames ResetReactorName = 3098;
	public const StringNames RestoreOxyName = 3099;
	public const StringNames QCAccADidntReport_QCCrewMe = 3100;
	public const StringNames QCStaACalledMeeting_QCCrewMe = 3101;
	public const StringNames QCAccAIsLyingNeg_QCCrewMe = 3102;
	public const StringNames QCResADid_QCCrewMe = 3103;
	public const StringNames QCResADidNeg_QCCrewMe = 3104;
	public const StringNames QCResAWas_QCCrewMe = 3105;
	public const StringNames QCResAWasNeg_QCCrewMe = 3106;
	public const StringNames QCResIsBeingFramed_QCCrewMe = 3107;
	public const StringNames QCAccAKilledBNeg_QCCrewMe_ANY = 3108;
	public const StringNames QCStaAWasWithB_QCCrewMe_ANY = 3109;
	public const StringNames QCStaAWasWithB_ANY_QCCrewMe = 3110;
	public const StringNames QCResCloseTo_QCCrewMe_ANY = 3111;
	public const StringNames QCAccAWasChasingB_QCCrewMe_ANY = 3112;
	public const StringNames QCAccAWasChasingBNeg_QCCrewMe_ANY = 3113;
	public const StringNames QCAccAWasChasingB_ANY_QCCrewMe = 3114;
	public const StringNames QCAccAWasChasingBNeg_ANY_QCCrewMe = 3115;
	public const StringNames QCStaASawB_QCCrewMe_ANY = 3116;
	public const StringNames QCAccASawBVent_QCCrewMe_ANY = 3117;
	public const StringNames QCAccASawBVentNeg_QCCrewMe_ANY = 3118;
	public const StringNames QCAccASawBVentNeg_ANY_QCCrewMe = 3119;
	public const StringNames QCResAWasAtB_QCCrewMe_ANY = 3120;
	public const StringNames QCResAWasAtBNeg_QCCrewMe_ANY = 3121;
	public const StringNames QCStaADidB_QCCrewMe_ANY = 3122;
	public const StringNames QCAccIsRole_QCCrewMe_ANY = 3123;
	public const StringNames QCAccIsRoleNeg_QCCrewMe_ANY = 3124;
	public const StringNames QCResProtected_ANY_QCCrewMe = 3125;
	public const StringNames QCCrewSomeone = 3126;
	public const StringNames QCResUrWelcome = 3127;
	public const StringNames QCResNp = 3128;
	public const StringNames QCResYikes = 3129;
	public const StringNames QCResRipCrew = 3130;
	public const StringNames QCResYeetCrew = 3131;
	public const StringNames QCSelfWasOnVitals = 3132;
	public const StringNames QCSawDeadCrewOnVitals = 3133;
	public const StringNames QCSelfSawTwoCrew = 3134;
	public const StringNames QCCrewShapeshifted = 3135;
	public const StringNames QCSelfSawCrewDoVisualTask = 3136;
	public const StringNames QCSelfWasOnDoorlogs = 3137;
	public const StringNames QCSelfWasOnAdmin = 3138;
	public const StringNames QCSelfAmVotingCrew = 3139;
	public const StringNames QCCrewWasPretendingTasks = 3140;
	public const StringNames QCCrewWasPretendingSabotage = 3141;
	public const StringNames QCLobbyMoreImpostors = 3142;
	public const StringNames QCLobbyLessImpostors = 3143;
	public const StringNames QCLobbyConfirmEjects = 3144;
	public const StringNames QCLobbyMoreEmergencyMeetings = 3145;
	public const StringNames QCLobbyLessEmergencyMeetings = 3146;
	public const StringNames QCLobbyAnonymousVotes = 3147;
	public const StringNames QCLobbyMoreEmergencyCooldownTime = 3148;
	public const StringNames QCLobbyLessEmergencyCooldownTime = 3149;
	public const StringNames QCLobbyMoreDiscussionTime = 3150;
	public const StringNames QCLobbyLessDiscussionTime = 3151;
	public const StringNames QCLobbyMoreVotingTime = 3152;
	public const StringNames QCLobbyLessVotingTime = 3153;
	public const StringNames QCLobbyFasterPlayerSpeed = 3154;
	public const StringNames QCLobbySlowerPlayerSpeed = 3155;
	public const StringNames QCLobbyTaskBarUpdates = 3156;
	public const StringNames QCLobbyVisualTasks = 3157;
	public const StringNames QCLobbyMoreCrewmateVision = 3158;
	public const StringNames QCLobbyLessCrewmateVision = 3159;
	public const StringNames QCLobbyMoreImpostorVision = 3160;
	public const StringNames QCLobbyLessImpostorVision = 3161;
	public const StringNames QCLobbyMoreKillCooldownTime = 3162;
	public const StringNames QCLobbyLessKillCooldownTime = 3163;
	public const StringNames QCLobbyLongerKillDistance = 3164;
	public const StringNames QCLobbyShorderKillDistance = 3165;
	public const StringNames QCLobbyMoreCommonTasks = 3166;
	public const StringNames QCLobbyLessCommonTasks = 3167;
	public const StringNames QCLobbyMoreLongTasks = 3168;
	public const StringNames QCLobbyLessLongTasks = 3169;
	public const StringNames QCLobbyMoreShortTasks = 3170;
	public const StringNames QCLobbyLessShortTasks = 3171;
	public const StringNames QCLobbyRoleScientists = 3172;
	public const StringNames QCLobbyRoleGuardianAngels = 3173;
	public const StringNames QCLobbyRoleEngineers = 3174;
	public const StringNames QCLobbyRoleShapeshifters = 3175;
	public const StringNames QCLobbyRoleNone = 3176;
	public const StringNames QCResLess = 3177;
	public const StringNames QCResMore = 3178;
	public const StringNames QCResNone = 3179;
	public const StringNames QCLobbyHNSMoreHideTime = 3180;
	public const StringNames QCLobbyHNSLessHideTime = 3181;
	public const StringNames QCLobbyHNSMoreFinalHideTime = 3182;
	public const StringNames QCLobbyHNSLessFinalHideTime = 3183;
	public const StringNames QCLobbyHNSFlashlightMode = 3184;
	public const StringNames QCLobbyHNSMoreCrewmateFlashlightSize = 3185;
	public const StringNames QCLobbyHNSLessCrewmateFlashlightSize = 3186;
	public const StringNames QCLobbyHNSMoreImpostorFlashlightSize = 3187;
	public const StringNames QCLobbyHNSLessImpostorFlashlightSize = 3188;
	public const StringNames QCLobbyHNSShowNames = 3189;
	public const StringNames QCLobbyHNSMoreVents = 3190;
	public const StringNames QCLobbyHNSLessVents = 3191;
	public const StringNames QCLobbyHNSMoreTimeInVent = 3192;
	public const StringNames QCLobbyHNSLessTimeInVent = 3193;
	public const StringNames QCLobbyHNSMoreFinalHideImpostorSpeed = 3194;
	public const StringNames QCLobbyHNSLessFinalHideImpostorSpeed = 3195;
	public const StringNames QCLobbyHNSFinalHideSeekMap = 3196;
	public const StringNames QCLobbyHNSFinalHidePings = 3197;
	public const StringNames QCLobbyHNSMorePingInterval = 3198;
	public const StringNames QCLobbyHNSLessPingInterval = 3199;
	public const StringNames SettingsColorblind = 3200;
	public const StringNames SettingsHelp = 3201;
	public const StringNames SecLogEntryColorblind = 3202;
	public const StringNames DeleteAccount = 3203;
	public const StringNames DoNotDeleteAccount = 3204;
	public const StringNames AccountDeleteHelp = 3205;
	public const StringNames AccountUnDeleteHelp = 3206;
	public const StringNames ConfirmDelete = 3207;
	public const StringNames ConfirmDeleteAccounts = 3208;
	public const StringNames ConfirmDeleteAccountsEmpty = 3209;
	public const StringNames AccountRequestDelete = 3210;
	public const StringNames HasBeenKilled = 3211;
	public const StringNames RoomSettingsLabel = 3280;
	public const StringNames ViewLabel = 3281;
	public const StringNames RoomCodeLabel = 3282;
	public const StringNames ModeLabel = 3283;
	public const StringNames PrivacyLabel = 3284;
	public const StringNames CapacityLabel = 3285;
	public const StringNames GameSettingsLabel = 3286;
	public const StringNames RoleSettingsLabel = 3287;
	public const StringNames GamePresetsLabel = 3288;
	public const StringNames GamePresetsDescription = 3289;
	public const StringNames StandardRulesPresetDescription = 3290;
	public const StringNames GameModeStandard = 3291;
	public const StringNames GameModeStandardRoles = 3292;
	public const StringNames GameModeCustom = 3293;
	public const StringNames ReturnToLobby = 3294;
	public const StringNames GameModeFlashlight = 3295;
	public const StringNames HostNounLabel = 3296;
	public const StringNames RoleSettingsAll = 3297;
	public const StringNames ScrollList = 3300;
	public const StringNames ScrollNews = 3301;
	public const StringNames AmongUsAnnouncements = 3302;
	public const StringNames AnnouncementErrorSubtitle = 3303;
	public const StringNames AnnouncementErrorText = 3304;
	public const StringNames ReadMoreLabel = 3305;
	public const StringNames ReturnToList = 3306;
	public const StringNames NavigateLinks = 3307;
	public const StringNames AgeVerificationTitle = 3308;
	public const StringNames AgeVerificationInfoTitle = 3309;
	public const StringNames AgeVerificationInfo = 3310;
	public const StringNames AgeVerificationMoreInfo = 3311;
	public const StringNames EditLabel = 3312;
	public const StringNames VerifyAgeText = 3313;
	public const StringNames PlayLabel = 3314;
	public const StringNames SettingsLabel = 3315;
	public const StringNames NewsLabel = 3316;
	public const StringNames AccountLabel = 3317;
	public const StringNames CreditsLabel = 3318;
	public const StringNames ShopLabel = 3319;
	public const StringNames InventoryLabel = 3320;
	public const StringNames StatsLabel = 3321;
	public const StringNames FriendsLabel = 3322;
	public const StringNames ReportNotificationHeader = 3323;
	public const StringNames ReportNotificationBody = 3324;
	public const StringNames MissingGuardianEmailText = 3325;
	public const StringNames AprilFoolsModeToggle = 3326;
	public const StringNames LobbyChangeSettingNotification = 3327;
	public const StringNames LoadingBarLoading = 3328;
	public const StringNames LoadingBarGameStart = 3329;
	public const StringNames LoadingBarGameStartWaitingPlayers = 3330;
	public const StringNames ImpostorsCategory = 3350;
	public const StringNames RolesCategory = 3351;
	public const StringNames MeetingsCategory = 3352;
	public const StringNames PlayersCategory = 3353;
	public const StringNames TasksCategory = 3354;
	public const StringNames GameSettingsDescription = 3355;
	public const StringNames RoleSettingsDescription = 3356;
	public const StringNames InfoLabel = 3357;
	public const StringNames RoleQuotaLabel = 3358;
	public const StringNames OverviewCategory = 3359;
	public const StringNames CrewmateRolesHeader = 3360;
	public const StringNames ImpostorRolesHeader = 3361;
	public const StringNames ViewingLabel = 3362;
	public const StringNames LocalLobbyLabel = 3363;
	public const StringNames NumberRoleHeader = 3364;
	public const StringNames ChanceRoleHeader = 3365;
	public const StringNames WaitingForPlayers = 3366;
	public const StringNames HideAndSeekModeDescription = 3367;
	public const StringNames RolesRulesPresetDescription = 3368;
	public const StringNames FlashlightRulesPresetDescription = 3369;
	public const StringNames RoomCodeCopied = 3370;
	public const StringNames FinalHideCategory = 3371;
	public const StringNames LobbyChangeSettingNotificationRole = 3372;
	public const StringNames StandardRulesPresetDescriptionHideAndSeek = 3373;
	public const StringNames GameModeStandardSeek = 3374;
	public const StringNames HostYouLabel = 3375;
	public const StringNames GamePresetsPopupTitle = 3376;
	public const StringNames GamePresetsPopupText = 3377;
	public const StringNames GamePresetsPopupContinue = 3378;
	public const StringNames GamePresetsPopupBack = 3379;
	public const StringNames MiningPit = 3400;
	public const StringNames Jungle = 3401;
	public const StringNames BuildSandcastle = 3402;
	public const StringNames FishingDock = 3403;
	public const StringNames CatchFish = 3404;
	public const StringNames CollectShells = 3405;
	public const StringNames LiftWeights = 3406;
	public const StringNames RoastMarshmallow = 3407;
	public const StringNames TestFrisbee = 3408;
	public const StringNames CollectSamples = 3409;
	public const StringNames CollectVegetables = 3410;
	public const StringNames HoistSupplies = 3411;
	public const StringNames MineOres = 3412;
	public const StringNames PolishGem = 3413;
	public const StringNames ReplaceParts = 3414;
	public const StringNames HelpCritter = 3415;
	public const StringNames RecRoom = 3416;
	public const StringNames Lookout = 3417;
	public const StringNames Beach = 3418;
	public const StringNames Highlands = 3419;
	public const StringNames SleepingQuarters = 3420;
	public const StringNames CrankGenerator = 3421;
	public const StringNames FixAntenna = 3422;
	public const StringNames TuneRadio = 3423;
	public const StringNames MushroomMixupSabotage = 3424;
	public const StringNames MineOresMine = 3425;
	public const StringNames CollectStick = 3426;
	public const StringNames WipeSand = 3427;
	public const StringNames ExtractFuel = 3428;
	public const StringNames MonitorMushroom = 3429;
	public const StringNames PlayVideogame = 3430;
	public const StringNames CookFish = 3431;
	public const StringNames PrepVegetables = 3432;
	public const StringNames MushroomMixupName = 3433;
	public const StringNames EosAccountSilentMergeFail = 3434;
	public const StringNames AskForEosAccount = 3435;
	public const StringNames KwsCreateFail = 3436;
	public const StringNames GameType = 3500;
	public const StringNames GameTypeError = 3501;
	public const StringNames GameTypeClassic = 3502;
	public const StringNames GameTypeHideAndSeek = 3503;
	public const StringNames PetAction = 3504;
	public const StringNames CreateLabel = 3505;
	public const StringNames TagFiltersTitle = 3506;
	public const StringNames TagFiltersHelpFindGame = 3507;
	public const StringNames TagFiltersHelpCreate = 3508;
	public const StringNames TagsFilteredSingular = 3509;
	public const StringNames TagsFilteredPlural = 3510;
	public const StringNames TagsAppliedSingular = 3511;
	public const StringNames TagsAppliedPlural = 3512;
	public const StringNames DefaultFilterTag_FirstTime = 3513;
	public const StringNames DefaultFilterTag_Casual = 3514;
	public const StringNames DefaultFilterTag_Serious = 3515;
	public const StringNames DefaultFilterTag_Expert = 3516;
	public const StringNames HttpErrorContextNone = 3517;
	public const StringNames HttpErrorContextAuthenticate = 3518;
	public const StringNames HttpErrorContextRequestGameCode = 3519;
	public const StringNames HttpErrorContextFindHostServer = 3520;
	public const StringNames HttpErrorContextRequestGamesList = 3521;
	public const StringNames HttpErrorUnknown = 3522;
	public const StringNames HttpErrorBadRequest = 3523;
	public const StringNames HttpErrorUnauthorized = 3524;
	public const StringNames HttpErrorForbidden = 3525;
	public const StringNames HttpErrorNotFound = 3526;
	public const StringNames HttpErrorMethodNotAllowed = 3527;
	public const StringNames HttpErrorRequestTimeout = 3528;
	public const StringNames HttpErrorTooManyRequests = 3529;
	public const StringNames HttpErrorInternalServerError = 3530;
	public const StringNames HttpErrorBadGateway = 3531;
	public const StringNames HttpErrorServiceUnavailable = 3532;
	public const StringNames HttpErrorGatewayTimeout = 3533;
	public const StringNames UserVersionError = 3534;
	public const StringNames QCLobbyRoleNoisemakers = 3535;
	public const StringNames QCLobbyRoleTrackers = 3536;
	public const StringNames QCLobbyRolePhantoms = 3537;
	public const StringNames QCSelfWasTracking = 3538;
	public const StringNames QCSelfGoingToNoisemaker = 3539;
	public const StringNames QCSelfSawRoleInLocation = 3540;
	public const StringNames QCCoreSettings = 3541;
	public const StringNames QCRolesGalore = 3542;
	public const StringNames QCPitchDark = 3543;
	public const StringNames QCFlashlight = 3544;
	public const StringNames QCPleaseWait = 3545;
	public const StringNames QCWaitMinute = 3546;
	public const StringNames QCLobbyClosing = 3547;
	public const StringNames QCChangeCosmetics = 3548;
	public const StringNames QCWaitingPlayers = 3549;
	public const StringNames QCLetsWaitPlayers = 3550;
	public const StringNames ServerLabel = 3551;
	public const StringNames JoinLobby = 3552;
	public const StringNames ChatLabel = 3553;
	public const StringNames ToolTipDefault = 3554;
	public const StringNames LevelLabel = 3555;
	public const StringNames NoneLowercaseLabel = 3556;
	public const StringNames ToolTipClassic = 3557;
	public const StringNames ToolTipHide = 3558;
	public const StringNames ToolTipMap = 3559;
	public const StringNames ToolTipCapacity = 3560;
	public const StringNames ToolTipLevel = 3561;
	public const StringNames ToolTipServer = 3562;
	public const StringNames ToolTipCrossplay = 3563;
	public const StringNames ToolTipNoCrossplay = 3564;
	public const StringNames ToolTipLanguage = 3565;
	public const StringNames ConfirmSettings = 3566;
	public const StringNames ConfirmSettingsTooltip = 3567;
	public const StringNames EnterCodeElipsis = 3568;
	public const StringNames ToolTipChatTab = 3569;
	public const StringNames DropshipsLabel = 3570;
	public const StringNames FiltersActive = 3571;
	public const StringNames ClearFilters = 3572;
	public const StringNames MoreLabel = 3573;
	public const StringNames HostNounEmpty = 3574;
	public const StringNames ToolTipSkeld = 3575;
	public const StringNames ToolTipMIRA = 3576;
	public const StringNames ToolTipPolus = 3577;
	public const StringNames ToolTipAirship = 3578;
	public const StringNames ToolTipFungle = 3579;
	public const StringNames FilterLow = 3580;
	public const StringNames FilterMed = 3581;
	public const StringNames FilterHigh = 3582;
	public const StringNames FilterVeryHigh = 3583;
	public const StringNames FilterLong = 3584;
	public const StringNames FilterNone = 3585;
	public const StringNames FilterPlayerLevel = 3586;
	public const StringNames RefreshLabel = 3587;
	public const StringNames JoinGameLabel = 3588;
	public const StringNames FilterClearText = 3589;
	public const StringNames MatchesFoundLabel = 3590;
	public const StringNames FilterGameTooltip = 3591;
	public const StringNames FilterMapTooltip = 3592;
	public const StringNames FilterImpostorTooltip = 3593;
	public const StringNames FilterRoleTooltip = 3594;
	public const StringNames FilterSpeedTooltip = 3595;
	public const StringNames FilterKillCDTooltip = 3596;
	public const StringNames FilterVotingTooltip = 3597;
	public const StringNames FilterVisualTaskTooltip = 3598;
	public const StringNames FilterAnonVotesTooltip = 3599;
	public const StringNames FilterConfirmEjectTooltip = 3600;
	public const StringNames FilterLevelTooltip = 3601;
	public const StringNames FilterCrossplayTooltip = 3602;
	public const StringNames FilterDefaultTooltip = 3603;
	public const StringNames FilterFlashlightTooltip = 3604;
	public const StringNames FilterHidingTimeTooltip = 3605;
	public const StringNames FilterFinalTimeTooltip = 3606;
	public const StringNames FilterMaxVentTooltip = 3607;
	public const StringNames FilterBeginner = 3608;
	public const StringNames FilterIntermediate = 3609;
	public const StringNames FilterExpert = 3610;
	public const StringNames FilterTag = 3611;
	public const StringNames FilterTagTooltip = 3612;
	public const StringNames TooltipTag = 3613;
	public const StringNames SelectedLabel = 3614;
	public const StringNames TooltipSpeedInfo = 3615;
	public const StringNames TooltipKillCDInfo = 3616;
	public const StringNames TooltipVotingInfo = 3617;
	public const StringNames TooptipHidingTimeInfo = 3618;
	public const StringNames TooltipFinalTimeInfo = 3619;
	public const StringNames FilterNoMaps = 3620;
	public const StringNames MaxFilters = 3621;
	public const StringNames XboxCommsMultiplayerError = 3700;
	public const StringNames XboxCommsUGError = 3701;
	public const StringNames XboxCommsCreateGameError = 3702;
	public const StringNames XboxCommsSearchError = 3703;
	public const StringNames XboxCommsJoinError = 3704;
	public const StringNames DetectiveRole = 4000;
	public const StringNames DetectiveAbility = 4001;
	public const StringNames DetectiveAbilityNotes = 4002;
	public const StringNames DetectiveBlurb = 4003;
	public const StringNames DetectiveBlurbMed = 4004;
	public const StringNames DetectiveBlurbLong = 4005;
	public const StringNames DetectiveNotesEmpty = 4006;
	public const StringNames DetectiveNotesFoundDead = 4007;
	public const StringNames DetectiveNotesSuspectInfo = 4008;
	public const StringNames DetectiveNearLocation = 4009;
	public const StringNames DetectiveNotesKiller = 4010;
	public const StringNames StatsDetectiveQuestioned = 4011;
	public const StringNames StatsDetectiveCasesFilled = 4012;
	public const StringNames DetectiveSuspectLimit = 4013;
	public const StringNames RolesHelp_Detective_01 = 4014;
	public const StringNames RolesHelp_Detective_02 = 4015;
	public const StringNames ViperRole = 4037;
	public const StringNames ViperBlurb = 4038;
	public const StringNames ViperBlurbMed = 4039;
	public const StringNames ViperBlurbLong = 4040;
	public const StringNames ViperDissolveTime = 4041;
	public const StringNames ViperAbility = 4042;
	public const StringNames StatsViperBodiesDissolved = 4043;
	public const StringNames RolesHelp_Viper_01 = 4044;
	public const StringNames RolesHelp_Viper_02 = 4045;
	public const StringNames QCWhereWasDead = 4060;
	public const StringNames QCInterrogateCrew = 4061;
	public const StringNames QCInterrogated = 4062;
	public const StringNames QCBodyDissolved = 4063;
	public const StringNames QCBodyVeryDissolved = 4064;
	public const StringNames QCBodyAlmostDissolved = 4065;
	public const StringNames QCDetectives = 4066;
	public const StringNames QCVipers = 4067;
	public const StringNames DetectiveNotesTitleVictim = 4068;
	public const StringNames DetectiveNotesTitleFoundDead = 4069;
	public const StringNames DetectiveNotesTitleKiller = 4070;
	public const StringNames DetectiveNotesTitleSuspects = 4071;
	public const StringNames DetectiveNotesTitleLocationsAtTimeOfDeath = 4072;
	public const StringNames DetectiveNotesPromptPreposition = 4073;
	public const StringNames DetectiveNotesPromptLocation = 4074;
	public const StringNames DetectiveNotesPromptImpostor = 4075;
	public const StringNames DetectiveNotesPromptSuspect = 4076;
	public const StringNames DetectiveNotesPrepositionIn = 4077;
	public const StringNames DetectiveNotesPrepositionBy = 4078;
	public const StringNames DetectiveNotesPrepositionMaybe = 4079;
	public const StringNames DetectiveNotesTitlePostIt = 4080;
	public const StringNames DetectiveNotesPostIt = 4081;
	public const StringNames DetectiveNotesSuspectNumber = 4082;
}

// Namespace: 
public class TextTranslatorTMP : MonoBehaviour, ITranslatedText // TypeDefIndex: 1921
{
	// Fields
	public StringNames TargetText; // 0x20
	public string defaultStr; // 0x28
	public bool ToUpper; // 0x30
	public bool ResetOnlyWhenNoDefault; // 0x31
	public UnityEvent OnTranslate; // 0x38

	// Methods

	// RVA: 0x718E90 Offset: 0x718090 VA: 0x180718E90 Slot: 4
	public void ResetText() { }

	// RVA: 0x719100 Offset: 0x718300 VA: 0x180719100
	public void Start() { }

	// RVA: 0x718E00 Offset: 0x718000 VA: 0x180718E00
	public void OnDestroy() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu]
public class TranslatedImageSet : ScriptableObject // TypeDefIndex: 1922
{
	// Fields
	public string Name; // 0x18
	public SupportedLangs languageID; // 0x20
	public TextAsset Data; // 0x28
	public TextAsset CensorSet; // 0x30

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public enum SupportedLangs // TypeDefIndex: 1923
{
	// Fields
	public int value__; // 0x0
	public const SupportedLangs English = 0;
	public const SupportedLangs Latam = 1;
	public const SupportedLangs Brazilian = 2;
	public const SupportedLangs Portuguese = 3;
	public const SupportedLangs Korean = 4;
	public const SupportedLangs Russian = 5;
	public const SupportedLangs Dutch = 6;
	public const SupportedLangs Filipino = 7;
	public const SupportedLangs French = 8;
	public const SupportedLangs German = 9;
	public const SupportedLangs Italian = 10;
	public const SupportedLangs Japanese = 11;
	public const SupportedLangs Spanish = 12;
	public const SupportedLangs SChinese = 13;
	public const SupportedLangs TChinese = 14;
	public const SupportedLangs Irish = 15;
}

// Namespace: 
public interface ITranslatedText // TypeDefIndex: 1924
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ResetText();
}

// Namespace: 
[Serializable]
public class ImageData // TypeDefIndex: 1925
{
	// Fields
	public ImageNames Name; // 0x10
	public Sprite Sprite; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TranslationController.<>c // TypeDefIndex: 1926
{
	// Fields
	public static readonly TranslationController.<>c <>9; // 0x0
	public static Func<KeyValuePair<SupportedLangs, TranslatedImageSet>, bool> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x721210 Offset: 0x720410 VA: 0x180721210
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720A50 Offset: 0x71FC50 VA: 0x180720A50
	internal StringNames <.cctor>b__10_0(SystemTypes t) { }

	// RVA: 0x720AF0 Offset: 0x71FCF0 VA: 0x180720AF0
	internal StringNames <.cctor>b__10_1(TaskTypes t) { }

	// RVA: 0x7206F0 Offset: 0x71F8F0 VA: 0x1807206F0
	internal bool <Initialize>b__11_0(KeyValuePair<SupportedLangs, TranslatedImageSet> lang) { }
}

// Namespace: 
public class TranslationController : DestroyableSingleton<TranslationController> // TypeDefIndex: 1927
{
	// Fields
	private static readonly StringNames[] SystemTypesToStringNames; // 0x0
	private static readonly StringNames[] TaskTypesToStringNames; // 0x8
	public List<ITranslatedText> ActiveTexts; // 0x28
	public Dictionary<SupportedLangs, string> dateFormats; // 0x30
	private LanguageUnit currentLanguage; // 0x38
	private LanguageUnit fallbackLanguage; // 0x40
	[CompilerGenerated]
	private Dictionary<SupportedLangs, TranslatedImageSet> <Languages>k__BackingField; // 0x48

	// Properties
	public Dictionary<SupportedLangs, TranslatedImageSet> Languages { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Dictionary<SupportedLangs, TranslatedImageSet> get_Languages() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_Languages(Dictionary<SupportedLangs, TranslatedImageSet> value) { }

	// RVA: 0x71B750 Offset: 0x71A950 VA: 0x18071B750
	private static void .cctor() { }

	// RVA: 0x719E70 Offset: 0x719070 VA: 0x180719E70
	public void Initialize() { }

	// RVA: 0x71A400 Offset: 0x719600 VA: 0x18071A400
	public void SetLanguage(SupportedLangs language) { }

	// RVA: 0x7197D0 Offset: 0x7189D0 VA: 0x1807197D0
	public Sprite GetImage(ImageNames id) { }

	// RVA: 0x719B50 Offset: 0x718D50 VA: 0x180719B50
	public string GetString(StringNames id, object[] parts) { }

	// RVA: 0x7199E0 Offset: 0x718BE0 VA: 0x1807199E0
	public string GetString(string id, string defaultStr, object[] parts) { }

	// RVA: 0x719930 Offset: 0x718B30 VA: 0x180719930
	public string GetStringWithDefault(StringNames id, string defaultStr, object[] parts) { }

	// RVA: 0x719BF0 Offset: 0x718DF0 VA: 0x180719BF0
	public string GetString(SystemTypes room) { }

	// RVA: 0x719CC0 Offset: 0x718EC0 VA: 0x180719CC0
	public string GetString(TaskTypes task) { }

	// RVA: 0x7198B0 Offset: 0x718AB0 VA: 0x1807198B0
	public string GetMonthStringViaNumber(int monthNum) { }

	// RVA: 0x719DF0 Offset: 0x718FF0 VA: 0x180719DF0
	public StringNames GetTaskName(TaskTypes task) { }

	// RVA: 0x719D80 Offset: 0x718F80 VA: 0x180719D80
	public StringNames GetSystemName(SystemTypes room) { }

	// RVA: 0x71A310 Offset: 0x719510 VA: 0x18071A310
	internal static uint SelectDefaultLanguage() { }

	// RVA: 0x71A7C0 Offset: 0x7199C0 VA: 0x18071A7C0
	public static bool TryParseLanguage(string language, out SupportedLangs output) { }

	// RVA: 0x7196B0 Offset: 0x7188B0 VA: 0x1807196B0
	public static bool DoesLanguageSupportBold(SupportedLangs language) { }

	// RVA: 0x71B940 Offset: 0x71AB40 VA: 0x18071B940
	public void .ctor() { }
}

// Namespace: 
public class ArrowBehaviour : PoolableBehavior // TypeDefIndex: 1928
{
	// Fields
	public Vector3 target; // 0x30
	public float perc; // 0x3C
	public float MaxScale; // 0x40
	public bool alwaysMaxSize; // 0x44
	protected float minDistanceToShowArrow; // 0x48
	[HideInInspector]
	public SpriteRenderer image; // 0x50

	// Methods

	// RVA: 0x710030 Offset: 0x70F230 VA: 0x180710030 Slot: 5
	public virtual void Awake() { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600
	public void Update() { }

	// RVA: 0x7104E0 Offset: 0x70F6E0 VA: 0x1807104E0 Slot: 6
	public virtual void UpdatePosition() { }

	// RVA: 0x710450 Offset: 0x70F650 VA: 0x180710450 Slot: 7
	public virtual void SetImageEnabled(bool isOn) { }

	// RVA: 0x710070 Offset: 0x70F270 VA: 0x180710070
	protected bool Between(float value, float min, float max) { }

	// RVA: 0x710080 Offset: 0x70F280 VA: 0x180710080 Slot: 8
	protected virtual void CloseBehaviour(Vector2 del, float delLen) { }

	// RVA: 0x710270 Offset: 0x70F470 VA: 0x180710270 Slot: 9
	protected virtual void DistancedBehaviour(Vector2 vpPoint, Vector2 del, float delLen, Camera cam) { }

	// RVA: 0x710790 Offset: 0x70F990 VA: 0x180710790
	public void .ctor() { }
}

// Namespace: 
public class TaskAddButton : MonoBehaviour // TypeDefIndex: 1929
{
	// Fields
	public TextMeshPro Text; // 0x20
	public SpriteRenderer Overlay; // 0x28
	public SpriteRenderer FileImage; // 0x30
	public ButtonRolloverHandler RolloverHandler; // 0x38
	public Sprite CheckImage; // 0x40
	public Sprite ExImage; // 0x48
	public PlayerTask MyTask; // 0x50
	[CompilerGenerated]
	private Vector2 <SafePositionWorld>k__BackingField; // 0x58
	[HideInInspector]
	public PassiveButton Button; // 0x60
	private RoleBehaviour role; // 0x68

	// Properties
	public Vector2 SafePositionWorld { get; set; }
	public RoleBehaviour Role { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x716730 Offset: 0x715930 VA: 0x180716730
	public Vector2 get_SafePositionWorld() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_SafePositionWorld(Vector2 value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public RoleBehaviour get_Role() { }

	// RVA: 0x716750 Offset: 0x715950 VA: 0x180716750
	public void set_Role(RoleBehaviour value) { }

	// RVA: 0x716210 Offset: 0x715410 VA: 0x180716210
	private void Awake() { }

	// RVA: 0x7164B0 Offset: 0x7156B0 VA: 0x1807164B0
	public void Start() { }

	// RVA: 0x716650 Offset: 0x715850 VA: 0x180716650
	public void Update() { }

	// RVA: 0x715E80 Offset: 0x715080 VA: 0x180715E80
	public void AddTask() { }

	// RVA: 0x715CB0 Offset: 0x714EB0 VA: 0x180715CB0
	public static void AddTaskToPlayer(PlayerTask taskPrefab) { }

	// RVA: 0x716250 Offset: 0x715450 VA: 0x180716250
	private PlayerTask FindTaskByType() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private enum TaskAdderGame.FolderType // TypeDefIndex: 1930
{
	// Fields
	public int value__; // 0x0
	public const TaskAdderGame.FolderType Tasks = 0;
	public const TaskAdderGame.FolderType Roles = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TaskAdderGame.<>c // TypeDefIndex: 1931
{
	// Fields
	public static readonly TaskAdderGame.<>c <>9; // 0x0
	public static Func<TaskFolder, string> <>9__22_0; // 0x8
	public static Func<RoleBehaviour, string> <>9__23_0; // 0x10
	public static Func<RoleBehaviour, string> <>9__23_1; // 0x18
	public static Func<NormalPlayerTask, TaskTypes> <>9__27_0; // 0x20

	// Methods

	// RVA: 0x7211B0 Offset: 0x7203B0 VA: 0x1807211B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string <Begin>b__22_0(TaskFolder f) { }

	// RVA: 0x7207F0 Offset: 0x71F9F0 VA: 0x1807207F0
	internal string <PopulateRoot>b__23_0(RoleBehaviour r) { }

	// RVA: 0x720850 Offset: 0x71FA50 VA: 0x180720850
	internal string <PopulateRoot>b__23_1(RoleBehaviour r) { }

	// RVA: 0x7208B0 Offset: 0x71FAB0 VA: 0x1807208B0
	internal TaskTypes <ShowFolder>b__27_0(NormalPlayerTask t) { }
}

// Namespace: 
public class TaskAdderGame : Minigame // TypeDefIndex: 1932
{
	// Fields
	public TextMeshPro PathText; // 0x88
	public TaskFolder RootFolderPrefab; // 0x90
	public TaskAddButton TaskPrefab; // 0x98
	public Transform TaskParent; // 0xA0
	public List<TaskFolder> Hierarchy; // 0xA8
	public List<Transform> ActiveItems; // 0xB0
	public TaskAddButton RoleButton; // 0xB8
	[CompilerGenerated]
	private Vector2 <SafePositionWorld>k__BackingField; // 0xC0
	public float folderWidth; // 0xC8
	public float fileWidth; // 0xCC
	public float lineWidth; // 0xD0
	private TaskFolder Root; // 0xD8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xE0
	public UiElement FolderBackButton; // 0xE8
	public List<UiElement> ControllerSelectable; // 0xF0
	private string previouslySelectedFolderName; // 0xF8

	// Properties
	public Vector2 SafePositionWorld { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x718930 Offset: 0x717B30 VA: 0x180718930
	public Vector2 get_SafePositionWorld() { }

	[CompilerGenerated]
	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	public void set_SafePositionWorld(Vector2 value) { }

	// RVA: 0x716F30 Offset: 0x716130 VA: 0x180716F30
	private void OnEnable() { }

	// RVA: 0x716EE0 Offset: 0x7160E0 VA: 0x180716EE0
	private void OnDisable() { }

	// RVA: 0x716A80 Offset: 0x715C80 VA: 0x180716A80 Slot: 5
	public override void Begin(PlayerTask t) { }

	// RVA: 0x716FC0 Offset: 0x7161C0 VA: 0x180716FC0
	private void PopulateRoot(TaskAdderGame.FolderType folderType, TaskFolder rootFolder, Dictionary<string, TaskFolder> folders, NormalPlayerTask[] taskList) { }

	// RVA: 0x716D90 Offset: 0x715F90 VA: 0x180716D90
	public void GoToRoot() { }

	// RVA: 0x716E00 Offset: 0x716000 VA: 0x180716E00
	public void GoUpOne() { }

	// RVA: 0x717820 Offset: 0x716A20 VA: 0x180717820
	public void SetPreviousControllerSelection(string folderName) { }

	// RVA: 0x717970 Offset: 0x716B70 VA: 0x180717970
	public void ShowFolder(TaskFolder taskFolder) { }

	// RVA: 0x716850 Offset: 0x715A50 VA: 0x180716850
	private void AddFileAsChild(TaskFolder taskFolder, TaskAddButton item, ref float xCursor, ref float yCursor, ref float maxHeight) { }

	// RVA: 0x718860 Offset: 0x717A60 VA: 0x180718860
	public void .ctor() { }
}

// Namespace: 
public enum TaskFolder.FolderColor // TypeDefIndex: 1933
{
	// Fields
	public int value__; // 0x0
	public const TaskFolder.FolderColor Tan = 0;
	public const TaskFolder.FolderColor Red = 1;
	public const TaskFolder.FolderColor Blue = 2;
}

// Namespace: 
public class TaskFolder : MonoBehaviour // TypeDefIndex: 1934
{
	// Fields
	public string FolderName; // 0x20
	public TextMeshPro Text; // 0x28
	public TaskAdderGame Parent; // 0x30
	public List<TaskFolder> SubFolders; // 0x38
	public List<NormalPlayerTask> TaskChildren; // 0x40
	public List<RoleBehaviour> RoleChildren; // 0x48
	[HideInInspector]
	public PassiveButton Button; // 0x50
	[SerializeField]
	private ButtonRolloverHandler buttonRolloverHandler; // 0x58
	[SerializeField]
	private SpriteRenderer folderSpriteRenderer; // 0x60
	[SerializeField]
	private Color currentFolderColor; // 0x68

	// Methods

	// RVA: 0x718960 Offset: 0x717B60 VA: 0x180718960
	private void Awake() { }

	// RVA: 0x718B40 Offset: 0x717D40 VA: 0x180718B40
	public void Start() { }

	// RVA: 0x7189A0 Offset: 0x717BA0 VA: 0x1807189A0
	public void OnClick() { }

	// RVA: 0x718A10 Offset: 0x717C10 VA: 0x180718A10
	public void SetFolderColor(TaskFolder.FolderColor folderColor) { }

	// RVA: 0x7189D0 Offset: 0x717BD0 VA: 0x1807189D0
	internal List<TaskFolder> OrderBy() { }

	// RVA: 0x718B80 Offset: 0x717D80 VA: 0x180718B80
	public void .ctor() { }
}

// Namespace: 
public class TutorialDebugCommands : MonoBehaviour // TypeDefIndex: 1935
{
	// Fields
	private static bool AutoResetTask; // 0x0

	// Methods

	// RVA: 0x71BCD0 Offset: 0x71AED0 VA: 0x18071BCD0
	private void Update() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void AddCommands(GameObject parent) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RemoveCommands(GameObject parent) { }

	[DebugCommand("Game/Toggle Auto-Reset Task After Complete", "", True)]
	// RVA: 0x71BC10 Offset: 0x71AE10 VA: 0x18071BC10
	public static void GameToggleAutoResetTask() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TutorialManager.<RunTutorial>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1936
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TutorialManager <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71F7D0 Offset: 0x71E9D0 VA: 0x18071F7D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7201C0 Offset: 0x71F3C0 VA: 0x1807201C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class TutorialManager : DestroyableSingleton<TutorialManager> // TypeDefIndex: 1937
{
	// Fields
	public PlayerControl PlayerPrefab; // 0x28

	// Methods

	// RVA: 0x71BF40 Offset: 0x71B140 VA: 0x18071BF40 Slot: 4
	public override void Awake() { }

	// RVA: 0x71C060 Offset: 0x71B260 VA: 0x18071C060 Slot: 5
	public override void OnDestroy() { }

	[IteratorStateMachine(typeof(TutorialManager.<RunTutorial>d__3))]
	// RVA: 0x71C120 Offset: 0x71B320 VA: 0x18071C120
	private IEnumerator RunTutorial() { }

	// RVA: 0x71C180 Offset: 0x71B380 VA: 0x18071C180
	public void .ctor() { }
}

// Namespace: 
public class GenericPopup : MonoBehaviour // TypeDefIndex: 1938
{
	// Fields
	public TextMeshPro TextAreaTMP; // 0x20
	public bool destroyOnClose; // 0x28

	// Methods

	// RVA: 0x7125B0 Offset: 0x7117B0 VA: 0x1807125B0
	public void Show(string text = "") { }

	// RVA: 0x712530 Offset: 0x711730 VA: 0x180712530
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class TwitchDeepLink : MonoBehaviour // TypeDefIndex: 1939
{
	// Methods

	// RVA: 0x71C220 Offset: 0x71B420 VA: 0x18071C220
	private void OnEnable() { }

	// RVA: 0x71C1C0 Offset: 0x71B3C0 VA: 0x18071C1C0
	public void OnClick() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class Checkbox : MonoBehaviour // TypeDefIndex: 1940
{
	// Fields
	[SerializeField]
	private SpriteRenderer checkmark; // 0x20
	[SerializeField]
	private PassiveButton button; // 0x28
	private bool oldValue; // 0x30

	// Properties
	public bool IsChecked { get; set; }

	// Methods

	// RVA: 0x710FC0 Offset: 0x7101C0 VA: 0x180710FC0
	public bool get_IsChecked() { }

	// RVA: 0x710FE0 Offset: 0x7101E0 VA: 0x180710FE0
	public void set_IsChecked(bool value) { }

	// RVA: 0x710F80 Offset: 0x710180 VA: 0x180710F80
	public void Toggle() { }

	// RVA: 0x710ED0 Offset: 0x7100D0 VA: 0x180710ED0
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DropdownButton.<>c__DisplayClass20_0 // TypeDefIndex: 1941
{
	// Fields
	public int buttonIndex; // 0x10
	public DropdownButton <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720CA0 Offset: 0x71FEA0 VA: 0x180720CA0
	internal void <OpenDropdownOptions>b__0() { }
}

// Namespace: 
public class DropdownButton : MonoBehaviour // TypeDefIndex: 1942
{
	// Fields
	[SerializeField]
	private float buttonStartY; // 0x20
	[SerializeField]
	private float buttonHeight; // 0x24
	[SerializeField]
	private GameObject optionsScreen; // 0x28
	[SerializeField]
	private PassiveButton openOptionsButton; // 0x30
	[SerializeField]
	private PassiveButton closeButton; // 0x38
	[SerializeField]
	private TextMeshPro buttonText; // 0x40
	[SerializeField]
	private Collider2D clickMask; // 0x48
	[SerializeField]
	private ObjectPoolBehavior optionPool; // 0x50
	private List<string> options; // 0x58
	private Action<int> onOptionSelect; // 0x60
	[CompilerGenerated]
	private int <SelectedIndex>k__BackingField; // 0x68

	// Properties
	public int SelectedIndex { get; set; }
	private string DropdownName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_SelectedIndex() { }

	[CompilerGenerated]
	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	private void set_SelectedIndex(int value) { }

	// RVA: 0x711B20 Offset: 0x710D20 VA: 0x180711B20
	private string get_DropdownName() { }

	// RVA: 0x711000 Offset: 0x710200 VA: 0x180711000
	public void AddOption(string optionName) { }

	// RVA: 0x711920 Offset: 0x710B20 VA: 0x180711920
	public void SetSelectedIndex(int i) { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void SetOnOptionSelect(Action<int> onOptionSelect) { }

	// RVA: 0x7119C0 Offset: 0x710BC0 VA: 0x1807119C0
	private void Start() { }

	// RVA: 0x7111A0 Offset: 0x7103A0 VA: 0x1807111A0
	private void OpenDropdownOptions() { }

	// RVA: 0x7117C0 Offset: 0x7109C0 VA: 0x1807117C0
	private void SelectOption(int buttonIndex) { }

	// RVA: 0x7110E0 Offset: 0x7102E0 VA: 0x1807110E0
	private void Close() { }

	// RVA: 0x711AB0 Offset: 0x710CB0 VA: 0x180711AB0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DropdownOption.<>c__DisplayClass4_0 // TypeDefIndex: 1943
{
	// Fields
	public Action onClick; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <Initialize>b__0() { }
}

// Namespace: 
public class DropdownOption : PoolableBehavior // TypeDefIndex: 1944
{
	// Fields
	[SerializeField]
	private TextMeshPro optionText; // 0x30
	[SerializeField]
	private PassiveButton button; // 0x38

	// Properties
	public UiElement ButtonUiElement { get; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public UiElement get_ButtonUiElement() { }

	// RVA: 0x711B70 Offset: 0x710D70 VA: 0x180711B70
	public void Initialize(string text, Action onClick, Collider2D clickMask, Vector3 position) { }

	// RVA: 0x711CE0 Offset: 0x710EE0 VA: 0x180711CE0 Slot: 4
	public override void Reset() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnlockPopUp.<Show>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1945
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UnlockPopUp <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x720460 Offset: 0x71F660 VA: 0x180720460 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7206A0 Offset: 0x71F8A0 VA: 0x1807206A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class UnlockPopUp : MonoBehaviour // TypeDefIndex: 1946
{
	// Methods

	[IteratorStateMachine(typeof(UnlockPopUp.<Show>d__0))]
	// RVA: 0x721390 Offset: 0x720590 VA: 0x180721390
	public IEnumerator Show() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class VentCleaningConsole : Console // TypeDefIndex: 1947
{
	// Fields
	public AudioClip ImpostorDiscoveredSound; // 0x48

	// Methods

	// RVA: 0x7216E0 Offset: 0x7208E0 VA: 0x1807216E0 Slot: 10
	public override void Use() { }

	// RVA: 0x6F3900 Offset: 0x6F2B00 VA: 0x1806F3900
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VentCleaningMinigame.<>c // TypeDefIndex: 1948
{
	// Fields
	public static readonly VentCleaningMinigame.<>c <>9; // 0x0
	public static Action<SpriteRenderer> <>9__19_0; // 0x8
	public static Action<SpriteRenderer> <>9__19_1; // 0x10

	// Methods

	// RVA: 0x721030 Offset: 0x720230 VA: 0x180721030
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0270 Offset: 0x59F470 VA: 0x1805A0270
	internal void <Begin>b__19_0(SpriteRenderer s) { }

	// RVA: 0x5A0470 Offset: 0x59F670 VA: 0x1805A0470
	internal void <Begin>b__19_1(SpriteRenderer s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VentCleaningMinigame.<>c__DisplayClass26_0 // TypeDefIndex: 1949
{
	// Fields
	public VentCleaningMinigame <>4__this; // 0x10
	public VentDirt dirt; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720E10 Offset: 0x720010 VA: 0x180720E10
	internal void <SpawnDirt>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VentCleaningMinigame.<CoOpenVent>d__24 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1950
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VentCleaningMinigame <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71DA60 Offset: 0x71CC60 VA: 0x18071DA60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x71DBE0 Offset: 0x71CDE0 VA: 0x18071DBE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class VentCleaningMinigame : Minigame // TypeDefIndex: 1951
{
	// Fields
	public FloatRange XSpan; // 0x88
	public FloatRange YSpan; // 0x90
	public ObjectPoolBehavior dirtPool; // 0x98
	public GameObject ventLidClosed; // 0xA0
	public GameObject ventLidOpened; // 0xA8
	public UiElement backButton; // 0xB0
	public AudioClip VentOpenSound; // 0xB8
	public AudioClip ImpostorDiscoveredSound; // 0xC0
	public AudioClip CleanedSound; // 0xC8
	public SpriteRenderer[] SpiderWebs; // 0xD0
	public float cleaningDistanceThreshold; // 0xD8
	public Transform selectorObject; // 0xE0
	public SpriteRenderer selectorHand; // 0xE8
	private int numberOfDirts; // 0xF0
	private int numberOfDirtsCleanedUp; // 0xF4
	private bool ventOpen; // 0xF8
	private VentilationSystem ventSystem; // 0x100

	// Properties
	private int VentId { get; }

	// Methods

	// RVA: 0x722BE0 Offset: 0x721DE0 VA: 0x180722BE0
	private int get_VentId() { }

	// RVA: 0x721940 Offset: 0x720B40 VA: 0x180721940 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x7220E0 Offset: 0x7212E0 VA: 0x1807220E0 Slot: 6
	public override void Close() { }

	// RVA: 0x722760 Offset: 0x721960 VA: 0x180722760
	public void OpenVent() { }

	// RVA: 0x722180 Offset: 0x721380 VA: 0x180722180
	private void FixedUpdate() { }

	// RVA: 0x7223E0 Offset: 0x7215E0 VA: 0x1807223E0
	private void HandleJoystick() { }

	[IteratorStateMachine(typeof(VentCleaningMinigame.<CoOpenVent>d__24))]
	// RVA: 0x722120 Offset: 0x721320 VA: 0x180722120
	private IEnumerator CoOpenVent() { }

	// RVA: 0x721D80 Offset: 0x720F80 VA: 0x180721D80
	private void CleanUp(VentDirt ventDirt) { }

	// RVA: 0x7227D0 Offset: 0x7219D0 VA: 0x1807227D0
	private void SpawnDirt() { }

	// RVA: 0x722B40 Offset: 0x721D40 VA: 0x180722B40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7229E0 Offset: 0x721BE0 VA: 0x1807229E0
	private void <CoOpenVent>b__24_0(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VentDirt.<>c__DisplayClass4_0 // TypeDefIndex: 1952
{
	// Fields
	public SpriteRenderer rend; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720FC0 Offset: 0x7201C0 VA: 0x180720FC0
	internal void <CoDisappear>b__0(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VentDirt.<CoDisappear>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1953
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VentDirt <>4__this; // 0x20
	private VentDirt.<>c__DisplayClass4_0 <>8__1; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71D770 Offset: 0x71C970 VA: 0x18071D770 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x71DA20 Offset: 0x71CC20 VA: 0x18071DA20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class VentDirt : PoolableBehavior // TypeDefIndex: 1954
{
	// Fields
	public Sprite[] DirtImages; // 0x30
	public ParticleSystem CleanedEffect; // 0x38
	private int imgIdx; // 0x40

	// Methods

	// RVA: 0x722C50 Offset: 0x721E50 VA: 0x180722C50 Slot: 4
	public override void Reset() { }

	[IteratorStateMachine(typeof(VentDirt.<CoDisappear>d__4))]
	// RVA: 0x722BF0 Offset: 0x721DF0 VA: 0x180722BF0
	public IEnumerator CoDisappear() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public struct VentilationSystem.VentMoveInfo // TypeDefIndex: 1955
{
	// Fields
	public VentilationSystem.Operation Op; // 0x0
	public byte VentId; // 0x4
	public byte PlayerId; // 0x5
}

// Namespace: 
public enum VentilationSystem.Operation // TypeDefIndex: 1956
{
	// Fields
	public int value__; // 0x0
	public const VentilationSystem.Operation StartCleaning = 0;
	public const VentilationSystem.Operation StopCleaning = 1;
	public const VentilationSystem.Operation Enter = 2;
	public const VentilationSystem.Operation Exit = 3;
	public const VentilationSystem.Operation Move = 4;
	public const VentilationSystem.Operation BootImpostors = 5;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VentilationSystem.<>c // TypeDefIndex: 1957
{
	// Fields
	public static readonly VentilationSystem.<>c <>9; // 0x0
	public static Func<SequenceBuffer<VentilationSystem.VentMoveInfo>> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x7210F0 Offset: 0x7202F0 VA: 0x1807210F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7209D0 Offset: 0x71FBD0 VA: 0x1807209D0
	internal SequenceBuffer<VentilationSystem.VentMoveInfo> <Update>b__11_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VentilationSystem.<>c__DisplayClass15_0 // TypeDefIndex: 1958
{
	// Fields
	public ushort opId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720BC0 Offset: 0x71FDC0 VA: 0x180720BC0
	internal SequenceBuffer<VentilationSystem.VentMoveInfo> <UpdateSystem>b__0() { }
}

// Namespace: 
public class VentilationSystem : ISystemType // TypeDefIndex: 1959
{
	// Fields
	private const ushort OP_ID_START = 0;
	private readonly Dictionary<byte, SequenceBuffer<VentilationSystem.VentMoveInfo>> SeqBuffers; // 0x10
	private readonly Dictionary<byte, byte> PlayersCleaningVents; // 0x18
	private readonly Dictionary<byte, byte> PlayersInsideVents; // 0x20
	private readonly HashSet<byte> ToRemove; // 0x28
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x30

	// Properties
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	private void set_IsDirty(bool value) { }

	// RVA: 0x724570 Offset: 0x723770 VA: 0x180724570
	public static void Update(VentilationSystem.Operation op, int ventId) { }

	// RVA: 0x7231F0 Offset: 0x7223F0 VA: 0x1807231F0 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x7238F0 Offset: 0x722AF0 VA: 0x1807238F0
	public bool IsVentCurrentlyBeingCleaned(int id) { }

	// RVA: 0x7235A0 Offset: 0x7227A0 VA: 0x1807235A0
	public bool IsImpostorInsideVent(int ventId) { }

	// RVA: 0x723E90 Offset: 0x723090 VA: 0x180723E90 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x723A30 Offset: 0x722C30 VA: 0x180723A30
	private void PerformVentOp(byte playerId, VentilationSystem.Operation op, byte ventId, SequenceBuffer<VentilationSystem.VentMoveInfo> seqBuffer) { }

	// RVA: 0x723A20 Offset: 0x722C20 VA: 0x180723A20 Slot: 7
	public void MarkClean() { }

	// RVA: 0x723C00 Offset: 0x722E00 VA: 0x180723C00 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x723020 Offset: 0x722220 VA: 0x180723020 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x722F00 Offset: 0x722100 VA: 0x180722F00
	private void BootImpostorsFromVent(int ventId) { }

	// RVA: 0x7236F0 Offset: 0x7228F0 VA: 0x1807236F0
	private bool IsInvisiblePhantomOnVent(byte playerId) { }

	// RVA: 0x722D80 Offset: 0x721F80 VA: 0x180722D80
	private void BootImpostorFromVent(int ventId, byte playerId) { }

	// RVA: 0x7244C0 Offset: 0x7236C0 VA: 0x1807244C0
	private void UpdateVentArrows() { }

	// RVA: 0x724860 Offset: 0x723A60 VA: 0x180724860
	public void .ctor() { }
}

// Namespace: 
public class VirtualJoystickController // TypeDefIndex: 1960
{
	// Fields
	private Collider2D amTouching; // 0x10
	private int fingerId; // 0x18
	private Controller.TouchState MyTouch; // 0x20
	[CompilerGenerated]
	private Camera <mainCam>k__BackingField; // 0x28

	// Properties
	public Vector2 DragPosition { get; }
	public Vector2 DragStartPosition { get; }
	public Camera mainCam { get; set; }

	// Methods

	// RVA: 0x7252B0 Offset: 0x7244B0 VA: 0x1807252B0
	public Vector2 get_DragPosition() { }

	// RVA: 0x725320 Offset: 0x724520 VA: 0x180725320
	public Vector2 get_DragStartPosition() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Camera get_mainCam() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_mainCam(Camera value) { }

	// RVA: 0x7252A0 Offset: 0x7244A0 VA: 0x1807252A0
	public void .ctor() { }

	// RVA: 0x725230 Offset: 0x724430 VA: 0x180725230
	public void Update() { }

	// RVA: 0x724970 Offset: 0x723B70 VA: 0x180724970
	public DragState CheckDrag(Collider2D coll, Collider2D deadZone) { }
}

// Namespace: 
public class WaitForHostPopup : DestroyableSingleton<WaitForHostPopup> // TypeDefIndex: 1961
{
	// Fields
	public GameObject Content; // 0x28
	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected; // 0x30

	// Methods

	// RVA: 0x725480 Offset: 0x724680 VA: 0x180725480
	public void Show() { }

	// RVA: 0x725350 Offset: 0x724550 VA: 0x180725350
	public void ExitGame() { }

	// RVA: 0x725400 Offset: 0x724600 VA: 0x180725400
	public void Hide() { }

	// RVA: 0x725570 Offset: 0x724770 VA: 0x180725570
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Asteroid.<CoBreakApart>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1962
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Asteroid <>4__this; // 0x20
	private SpriteRenderer <rend>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71D180 Offset: 0x71C380 VA: 0x18071D180 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x71D520 Offset: 0x71C720 VA: 0x18071D520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class Asteroid : PoolableBehavior // TypeDefIndex: 1963
{
	// Fields
	public Sprite[] AsteroidImages; // 0x30
	public Sprite[] BrokenImages; // 0x38
	private int imgIdx; // 0x40
	public FloatRange MoveSpeed; // 0x48
	public FloatRange RotateSpeed; // 0x50
	[CompilerGenerated]
	private Vector3 <TargetPosition>k__BackingField; // 0x58
	public SpriteRenderer Explosion; // 0x68

	// Properties
	public Vector3 TargetPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x710EA0 Offset: 0x7100A0 VA: 0x180710EA0
	public Vector3 get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x710EC0 Offset: 0x7100C0 VA: 0x180710EC0
	internal void set_TargetPosition(Vector3 value) { }

	// RVA: 0x710810 Offset: 0x70FA10 VA: 0x180710810
	public void FixedUpdate() { }

	// RVA: 0x710B90 Offset: 0x70FD90 VA: 0x180710B90 Slot: 4
	public override void Reset() { }

	[IteratorStateMachine(typeof(Asteroid.<CoBreakApart>d__12))]
	// RVA: 0x7107B0 Offset: 0x70F9B0 VA: 0x1807107B0
	public IEnumerator CoBreakApart() { }

	// RVA: 0x710E00 Offset: 0x710000 VA: 0x180710E00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x710D30 Offset: 0x70FF30 VA: 0x180710D30
	private void <CoBreakApart>b__12_0(float t) { }

	[CompilerGenerated]
	// RVA: 0x710D90 Offset: 0x70FF90 VA: 0x180710D90
	private void <CoBreakApart>b__12_1(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeaponsMinigame.<>c__DisplayClass17_0 // TypeDefIndex: 1964
{
	// Fields
	public WeaponsMinigame <>4__this; // 0x10
	public Asteroid ast; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720C30 Offset: 0x71FE30 VA: 0x180720C30
	internal void <FixedUpdate>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeaponsMinigame.<CoAnimateOpen>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1965
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WeaponsMinigame <>4__this; // 0x20
	private float <timer>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71CF90 Offset: 0x71C190 VA: 0x18071CF90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x71D140 Offset: 0x71C340 VA: 0x18071D140 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeaponsMinigame.<CoDestroySelf>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WeaponsMinigame <>4__this; // 0x20
	private float <timer>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x71D560 Offset: 0x71C760 VA: 0x18071D560 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x71D730 Offset: 0x71C930 VA: 0x18071D730 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class WeaponsMinigame : Minigame // TypeDefIndex: 1967
{
	// Fields
	public FloatRange XSpan; // 0x88
	public FloatRange YSpan; // 0x90
	public FloatRange TimeToSpawn; // 0x98
	public ObjectPoolBehavior asteroidPool; // 0xA0
	public TextMeshPro ScoreText; // 0xA8
	public SpriteRenderer TargetReticle; // 0xB0
	public LineRenderer TargetLines; // 0xB8
	private Vector3 TargetCenter; // 0xC0
	public Collider2D BackgroundCol; // 0xD0
	public SpriteRenderer Background; // 0xD8
	public Controller myController; // 0xE0
	private float Timer; // 0xE8
	public AudioClip ShootSound; // 0xF0
	public AudioClip[] ExplodeSounds; // 0xF8

	// Methods

	// RVA: 0x725690 Offset: 0x724890 VA: 0x180725690 Slot: 5
	public override void Begin(PlayerTask task) { }

	[IteratorStateMachine(typeof(WeaponsMinigame.<CoAnimateOpen>d__15))]
	// RVA: 0x725D30 Offset: 0x724F30 VA: 0x180725D30 Slot: 7
	protected override IEnumerator CoAnimateOpen() { }

	[IteratorStateMachine(typeof(WeaponsMinigame.<CoDestroySelf>d__16))]
	// RVA: 0x725D90 Offset: 0x724F90 VA: 0x180725D90 Slot: 8
	protected override IEnumerator CoDestroySelf() { }

	// RVA: 0x725DF0 Offset: 0x724FF0 VA: 0x180725DF0
	public void FixedUpdate() { }

	// RVA: 0x725800 Offset: 0x724A00 VA: 0x180725800
	public void BreakApart(Asteroid ast) { }

	// RVA: 0x7267C0 Offset: 0x7259C0 VA: 0x1807267C0
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 1968
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 1969
{
	// Methods

	// RVA: 0x7212D0 Offset: 0x7204D0 VA: 0x1807212D0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Twitch
public class TwitchLinker : MonoBehaviour // TypeDefIndex: 1970
{
	// Methods

	// RVA: 0x71C290 Offset: 0x71B490 VA: 0x18071C290
	public void LaunchImplicitAuth() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private enum TwitchManager.UpdateState // TypeDefIndex: 1971
{
	// Fields
	public int value__; // 0x0
	public const TwitchManager.UpdateState NotStarted = 0;
	public const TwitchManager.UpdateState Started = 1;
	public const TwitchManager.UpdateState Success = 2;
	public const TwitchManager.UpdateState Failure = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TwitchManager.<>c // TypeDefIndex: 1972
{
	// Fields
	public static readonly TwitchManager.<>c <>9; // 0x0
	public static Func<string, bool> <>9__13_0; // 0x8
	public static Func<string, bool> <>9__13_1; // 0x10

	// Methods

	// RVA: 0x721270 Offset: 0x720470 VA: 0x180721270
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x720750 Offset: 0x71F950 VA: 0x180720750
	internal bool <Instance_LinkActivated>b__13_0(string a) { }

	// RVA: 0x7207A0 Offset: 0x71F9A0 VA: 0x1807207A0
	internal bool <Instance_LinkActivated>b__13_1(string a) { }
}

// Namespace: 
[CompilerGenerated]
private struct TwitchManager.<FetchEntitlements>d__19 : IAsyncStateMachine // TypeDefIndex: 1973
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpStatusCode> <>t__builder; // 0x8
	public TwitchManager <>4__this; // 0x20
	public string token; // 0x28
	private HttpClient <http>5__2; // 0x30
	private HttpRequestMessage <msg>5__3; // 0x38
	private HttpResponseMessage <res>5__4; // 0x40
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x48
	private TaskAwaiter<string> <>u__2; // 0x50

	// Methods

	// RVA: 0x71DC20 Offset: 0x71CE20 VA: 0x18071DC20 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71EBE0 Offset: 0x71DDE0 VA: 0x18071EBE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TwitchManager.<FetchNewToken>d__18 : IAsyncStateMachine // TypeDefIndex: 1974
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public TwitchManager <>4__this; // 0x20
	private string <tokenCache>5__2; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x71EC50 Offset: 0x71DE50 VA: 0x18071EC50 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F1C0 Offset: 0x71E3C0 VA: 0x18071F1C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct TwitchManager.<LaunchImplicitAuthAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 1975
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public TwitchManager <>4__this; // 0x28
	private TaskAwaiter<HttpStatusCode> <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x71F220 Offset: 0x71E420 VA: 0x18071F220 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x71F7C0 Offset: 0x71E9C0 VA: 0x18071F7C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TwitchManager.<ShakeGlitch>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1976
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TwitchManager <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x720200 Offset: 0x71F400 VA: 0x180720200 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x720420 Offset: 0x71F620 VA: 0x180720420 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Twitch
public class TwitchManager : DestroyableSingleton<TwitchManager> // TypeDefIndex: 1977
{
	// Fields
	private const string RedirectUri = "AmongUs://callback";
	private const string ClientId = "yioca4gf70qx0v05qodt6tnwlkerr3";
	private static readonly string[] Scopes; // 0x0
	private string verify; // 0x28
	public GenericPopup TwitchPopup; // 0x30
	private TwitchManager.UpdateState running; // 0x38
	private List<string> newItems; // 0x40
	[CompilerGenerated]
	private string <Token>k__BackingField; // 0x48

	// Properties
	public string Token { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Token() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Token(string value) { }

	// RVA: 0x71CD10 Offset: 0x71BF10 VA: 0x18071CD10
	private void Start() { }

	// RVA: 0x71C5B0 Offset: 0x71B7B0 VA: 0x18071C5B0
	private void Instance_LinkActivated(LinkActivation s) { }

	// RVA: 0x71CBA0 Offset: 0x71BDA0 VA: 0x18071CBA0 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x71CA90 Offset: 0x71BC90 VA: 0x18071CA90
	public void LaunchImplicitAuth(Transform target) { }

	[IteratorStateMachine(typeof(TwitchManager.<ShakeGlitch>d__16))]
	// RVA: 0x71CCB0 Offset: 0x71BEB0 VA: 0x18071CCB0
	private IEnumerator ShakeGlitch(Transform target) { }

	[AsyncStateMachine(typeof(TwitchManager.<LaunchImplicitAuthAsync>d__17))]
	// RVA: 0x71C9F0 Offset: 0x71BBF0 VA: 0x18071C9F0
	private void LaunchImplicitAuthAsync() { }

	[AsyncStateMachine(typeof(TwitchManager.<FetchNewToken>d__18))]
	// RVA: 0x71C4F0 Offset: 0x71B6F0 VA: 0x18071C4F0
	private Task FetchNewToken() { }

	[AsyncStateMachine(typeof(TwitchManager.<FetchEntitlements>d__19))]
	// RVA: 0x71C3E0 Offset: 0x71B5E0 VA: 0x18071C3E0
	public Task<HttpStatusCode> FetchEntitlements(string token) { }

	// RVA: 0x71CF10 Offset: 0x71C110 VA: 0x18071CF10
	public void .ctor() { }

	// RVA: 0x71CEC0 Offset: 0x71C0C0 VA: 0x18071CEC0
	private static void .cctor() { }
}

// Namespace: Rewired
public interface IGamepadTemplate : IControllerTemplate // TypeDefIndex: 1978
{
	// Properties
	public abstract IControllerTemplateButton actionBottomRow1 { get; }
	public abstract IControllerTemplateButton a { get; }
	public abstract IControllerTemplateButton actionBottomRow2 { get; }
	public abstract IControllerTemplateButton b { get; }
	public abstract IControllerTemplateButton actionBottomRow3 { get; }
	public abstract IControllerTemplateButton c { get; }
	public abstract IControllerTemplateButton actionTopRow1 { get; }
	public abstract IControllerTemplateButton x { get; }
	public abstract IControllerTemplateButton actionTopRow2 { get; }
	public abstract IControllerTemplateButton y { get; }
	public abstract IControllerTemplateButton actionTopRow3 { get; }
	public abstract IControllerTemplateButton z { get; }
	public abstract IControllerTemplateButton leftShoulder1 { get; }
	public abstract IControllerTemplateButton leftBumper { get; }
	public abstract IControllerTemplateAxis leftShoulder2 { get; }
	public abstract IControllerTemplateAxis leftTrigger { get; }
	public abstract IControllerTemplateButton rightShoulder1 { get; }
	public abstract IControllerTemplateButton rightBumper { get; }
	public abstract IControllerTemplateAxis rightShoulder2 { get; }
	public abstract IControllerTemplateAxis rightTrigger { get; }
	public abstract IControllerTemplateButton center1 { get; }
	public abstract IControllerTemplateButton back { get; }
	public abstract IControllerTemplateButton center2 { get; }
	public abstract IControllerTemplateButton start { get; }
	public abstract IControllerTemplateButton center3 { get; }
	public abstract IControllerTemplateButton guide { get; }
	public abstract IControllerTemplateThumbStick leftStick { get; }
	public abstract IControllerTemplateThumbStick rightStick { get; }
	public abstract IControllerTemplateDPad dPad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_actionBottomRow1();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_a();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_actionBottomRow2();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_b();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_actionBottomRow3();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_c();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_actionTopRow1();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_x();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_actionTopRow2();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_y();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_actionTopRow3();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_z();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_leftShoulder1();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_leftBumper();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateAxis get_leftShoulder2();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateAxis get_leftTrigger();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_rightShoulder1();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_rightBumper();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateAxis get_rightShoulder2();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateAxis get_rightTrigger();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_center1();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_back();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_center2();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_start();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_center3();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_guide();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateThumbStick get_leftStick();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateThumbStick get_rightStick();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateDPad get_dPad();
}

// Namespace: Rewired
public interface IRacingWheelTemplate : IControllerTemplate // TypeDefIndex: 1979
{
	// Properties
	public abstract IControllerTemplateAxis wheel { get; }
	public abstract IControllerTemplateAxis accelerator { get; }
	public abstract IControllerTemplateAxis brake { get; }
	public abstract IControllerTemplateAxis clutch { get; }
	public abstract IControllerTemplateButton shiftDown { get; }
	public abstract IControllerTemplateButton shiftUp { get; }
	public abstract IControllerTemplateButton wheelButton1 { get; }
	public abstract IControllerTemplateButton wheelButton2 { get; }
	public abstract IControllerTemplateButton wheelButton3 { get; }
	public abstract IControllerTemplateButton wheelButton4 { get; }
	public abstract IControllerTemplateButton wheelButton5 { get; }
	public abstract IControllerTemplateButton wheelButton6 { get; }
	public abstract IControllerTemplateButton wheelButton7 { get; }
	public abstract IControllerTemplateButton wheelButton8 { get; }
	public abstract IControllerTemplateButton wheelButton9 { get; }
	public abstract IControllerTemplateButton wheelButton10 { get; }
	public abstract IControllerTemplateButton consoleButton1 { get; }
	public abstract IControllerTemplateButton consoleButton2 { get; }
	public abstract IControllerTemplateButton consoleButton3 { get; }
	public abstract IControllerTemplateButton consoleButton4 { get; }
	public abstract IControllerTemplateButton consoleButton5 { get; }
	public abstract IControllerTemplateButton consoleButton6 { get; }
	public abstract IControllerTemplateButton consoleButton7 { get; }
	public abstract IControllerTemplateButton consoleButton8 { get; }
	public abstract IControllerTemplateButton consoleButton9 { get; }
	public abstract IControllerTemplateButton consoleButton10 { get; }
	public abstract IControllerTemplateButton shifter1 { get; }
	public abstract IControllerTemplateButton shifter2 { get; }
	public abstract IControllerTemplateButton shifter3 { get; }
	public abstract IControllerTemplateButton shifter4 { get; }
	public abstract IControllerTemplateButton shifter5 { get; }
	public abstract IControllerTemplateButton shifter6 { get; }
	public abstract IControllerTemplateButton shifter7 { get; }
	public abstract IControllerTemplateButton shifter8 { get; }
	public abstract IControllerTemplateButton shifter9 { get; }
	public abstract IControllerTemplateButton shifter10 { get; }
	public abstract IControllerTemplateButton reverseGear { get; }
	public abstract IControllerTemplateButton select { get; }
	public abstract IControllerTemplateButton start { get; }
	public abstract IControllerTemplateButton systemButton { get; }
	public abstract IControllerTemplateButton horn { get; }
	public abstract IControllerTemplateDPad dPad { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_wheel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_accelerator();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_brake();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_clutch();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_shiftDown();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_shiftUp();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_wheelButton1();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_wheelButton2();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_wheelButton3();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_wheelButton4();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_wheelButton5();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_wheelButton6();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_wheelButton7();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_wheelButton8();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_wheelButton9();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_wheelButton10();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_consoleButton1();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_consoleButton2();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_consoleButton3();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_consoleButton4();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_consoleButton5();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_consoleButton6();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_consoleButton7();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_consoleButton8();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_consoleButton9();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_consoleButton10();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_shifter1();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_shifter2();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_shifter3();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_shifter4();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_shifter5();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_shifter6();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_shifter7();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_shifter8();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_shifter9();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_shifter10();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_reverseGear();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_select();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_start();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_systemButton();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_horn();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateDPad get_dPad();
}

// Namespace: Rewired
public interface IHOTASTemplate : IControllerTemplate // TypeDefIndex: 1980
{
	// Properties
	public abstract IControllerTemplateButton stickTrigger { get; }
	public abstract IControllerTemplateButton stickTriggerStage2 { get; }
	public abstract IControllerTemplateButton stickPinkyButton { get; }
	public abstract IControllerTemplateButton stickPinkyTrigger { get; }
	public abstract IControllerTemplateButton stickButton1 { get; }
	public abstract IControllerTemplateButton stickButton2 { get; }
	public abstract IControllerTemplateButton stickButton3 { get; }
	public abstract IControllerTemplateButton stickButton4 { get; }
	public abstract IControllerTemplateButton stickButton5 { get; }
	public abstract IControllerTemplateButton stickButton6 { get; }
	public abstract IControllerTemplateButton stickButton7 { get; }
	public abstract IControllerTemplateButton stickButton8 { get; }
	public abstract IControllerTemplateButton stickButton9 { get; }
	public abstract IControllerTemplateButton stickButton10 { get; }
	public abstract IControllerTemplateButton stickBaseButton1 { get; }
	public abstract IControllerTemplateButton stickBaseButton2 { get; }
	public abstract IControllerTemplateButton stickBaseButton3 { get; }
	public abstract IControllerTemplateButton stickBaseButton4 { get; }
	public abstract IControllerTemplateButton stickBaseButton5 { get; }
	public abstract IControllerTemplateButton stickBaseButton6 { get; }
	public abstract IControllerTemplateButton stickBaseButton7 { get; }
	public abstract IControllerTemplateButton stickBaseButton8 { get; }
	public abstract IControllerTemplateButton stickBaseButton9 { get; }
	public abstract IControllerTemplateButton stickBaseButton10 { get; }
	public abstract IControllerTemplateButton stickBaseButton11 { get; }
	public abstract IControllerTemplateButton stickBaseButton12 { get; }
	public abstract IControllerTemplateButton mode1 { get; }
	public abstract IControllerTemplateButton mode2 { get; }
	public abstract IControllerTemplateButton mode3 { get; }
	public abstract IControllerTemplateButton throttleButton1 { get; }
	public abstract IControllerTemplateButton throttleButton2 { get; }
	public abstract IControllerTemplateButton throttleButton3 { get; }
	public abstract IControllerTemplateButton throttleButton4 { get; }
	public abstract IControllerTemplateButton throttleButton5 { get; }
	public abstract IControllerTemplateButton throttleButton6 { get; }
	public abstract IControllerTemplateButton throttleButton7 { get; }
	public abstract IControllerTemplateButton throttleButton8 { get; }
	public abstract IControllerTemplateButton throttleButton9 { get; }
	public abstract IControllerTemplateButton throttleButton10 { get; }
	public abstract IControllerTemplateButton throttleBaseButton1 { get; }
	public abstract IControllerTemplateButton throttleBaseButton2 { get; }
	public abstract IControllerTemplateButton throttleBaseButton3 { get; }
	public abstract IControllerTemplateButton throttleBaseButton4 { get; }
	public abstract IControllerTemplateButton throttleBaseButton5 { get; }
	public abstract IControllerTemplateButton throttleBaseButton6 { get; }
	public abstract IControllerTemplateButton throttleBaseButton7 { get; }
	public abstract IControllerTemplateButton throttleBaseButton8 { get; }
	public abstract IControllerTemplateButton throttleBaseButton9 { get; }
	public abstract IControllerTemplateButton throttleBaseButton10 { get; }
	public abstract IControllerTemplateButton throttleBaseButton11 { get; }
	public abstract IControllerTemplateButton throttleBaseButton12 { get; }
	public abstract IControllerTemplateButton throttleBaseButton13 { get; }
	public abstract IControllerTemplateButton throttleBaseButton14 { get; }
	public abstract IControllerTemplateButton throttleBaseButton15 { get; }
	public abstract IControllerTemplateAxis throttleSlider1 { get; }
	public abstract IControllerTemplateAxis throttleSlider2 { get; }
	public abstract IControllerTemplateAxis throttleSlider3 { get; }
	public abstract IControllerTemplateAxis throttleSlider4 { get; }
	public abstract IControllerTemplateAxis throttleDial1 { get; }
	public abstract IControllerTemplateAxis throttleDial2 { get; }
	public abstract IControllerTemplateAxis throttleDial3 { get; }
	public abstract IControllerTemplateAxis throttleDial4 { get; }
	public abstract IControllerTemplateButton throttleWheel1Forward { get; }
	public abstract IControllerTemplateButton throttleWheel1Back { get; }
	public abstract IControllerTemplateButton throttleWheel1Press { get; }
	public abstract IControllerTemplateButton throttleWheel2Forward { get; }
	public abstract IControllerTemplateButton throttleWheel2Back { get; }
	public abstract IControllerTemplateButton throttleWheel2Press { get; }
	public abstract IControllerTemplateButton throttleWheel3Forward { get; }
	public abstract IControllerTemplateButton throttleWheel3Back { get; }
	public abstract IControllerTemplateButton throttleWheel3Press { get; }
	public abstract IControllerTemplateAxis leftPedal { get; }
	public abstract IControllerTemplateAxis rightPedal { get; }
	public abstract IControllerTemplateAxis slidePedals { get; }
	public abstract IControllerTemplateStick stick { get; }
	public abstract IControllerTemplateThumbStick stickMiniStick1 { get; }
	public abstract IControllerTemplateThumbStick stickMiniStick2 { get; }
	public abstract IControllerTemplateHat stickHat1 { get; }
	public abstract IControllerTemplateHat stickHat2 { get; }
	public abstract IControllerTemplateHat stickHat3 { get; }
	public abstract IControllerTemplateHat stickHat4 { get; }
	public abstract IControllerTemplateThrottle throttle1 { get; }
	public abstract IControllerTemplateThrottle throttle2 { get; }
	public abstract IControllerTemplateThumbStick throttleMiniStick { get; }
	public abstract IControllerTemplateHat throttleHat1 { get; }
	public abstract IControllerTemplateHat throttleHat2 { get; }
	public abstract IControllerTemplateHat throttleHat3 { get; }
	public abstract IControllerTemplateHat throttleHat4 { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_stickTrigger();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_stickTriggerStage2();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_stickPinkyButton();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_stickPinkyTrigger();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_stickButton1();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_stickButton2();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_stickButton3();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_stickButton4();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_stickButton5();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_stickButton6();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_stickButton7();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_stickButton8();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_stickButton9();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_stickButton10();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_stickBaseButton1();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_stickBaseButton2();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_stickBaseButton3();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_stickBaseButton4();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_stickBaseButton5();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_stickBaseButton6();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_stickBaseButton7();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_stickBaseButton8();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_stickBaseButton9();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_stickBaseButton10();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_stickBaseButton11();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_stickBaseButton12();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_mode1();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_mode2();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_mode3();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_throttleButton1();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_throttleButton2();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_throttleButton3();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_throttleButton4();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_throttleButton5();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_throttleButton6();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_throttleButton7();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_throttleButton8();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_throttleButton9();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_throttleButton10();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_throttleBaseButton1();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_throttleBaseButton2();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateButton get_throttleBaseButton3();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IControllerTemplateButton get_throttleBaseButton4();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract IControllerTemplateButton get_throttleBaseButton5();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract IControllerTemplateButton get_throttleBaseButton6();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract IControllerTemplateButton get_throttleBaseButton7();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IControllerTemplateButton get_throttleBaseButton8();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract IControllerTemplateButton get_throttleBaseButton9();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract IControllerTemplateButton get_throttleBaseButton10();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract IControllerTemplateButton get_throttleBaseButton11();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract IControllerTemplateButton get_throttleBaseButton12();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract IControllerTemplateButton get_throttleBaseButton13();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract IControllerTemplateButton get_throttleBaseButton14();

	// RVA: -1 Offset: -1 Slot: 53
	public abstract IControllerTemplateButton get_throttleBaseButton15();

	// RVA: -1 Offset: -1 Slot: 54
	public abstract IControllerTemplateAxis get_throttleSlider1();

	// RVA: -1 Offset: -1 Slot: 55
	public abstract IControllerTemplateAxis get_throttleSlider2();

	// RVA: -1 Offset: -1 Slot: 56
	public abstract IControllerTemplateAxis get_throttleSlider3();

	// RVA: -1 Offset: -1 Slot: 57
	public abstract IControllerTemplateAxis get_throttleSlider4();

	// RVA: -1 Offset: -1 Slot: 58
	public abstract IControllerTemplateAxis get_throttleDial1();

	// RVA: -1 Offset: -1 Slot: 59
	public abstract IControllerTemplateAxis get_throttleDial2();

	// RVA: -1 Offset: -1 Slot: 60
	public abstract IControllerTemplateAxis get_throttleDial3();

	// RVA: -1 Offset: -1 Slot: 61
	public abstract IControllerTemplateAxis get_throttleDial4();

	// RVA: -1 Offset: -1 Slot: 62
	public abstract IControllerTemplateButton get_throttleWheel1Forward();

	// RVA: -1 Offset: -1 Slot: 63
	public abstract IControllerTemplateButton get_throttleWheel1Back();

	// RVA: -1 Offset: -1 Slot: 64
	public abstract IControllerTemplateButton get_throttleWheel1Press();

	// RVA: -1 Offset: -1 Slot: 65
	public abstract IControllerTemplateButton get_throttleWheel2Forward();

	// RVA: -1 Offset: -1 Slot: 66
	public abstract IControllerTemplateButton get_throttleWheel2Back();

	// RVA: -1 Offset: -1 Slot: 67
	public abstract IControllerTemplateButton get_throttleWheel2Press();

	// RVA: -1 Offset: -1 Slot: 68
	public abstract IControllerTemplateButton get_throttleWheel3Forward();

	// RVA: -1 Offset: -1 Slot: 69
	public abstract IControllerTemplateButton get_throttleWheel3Back();

	// RVA: -1 Offset: -1 Slot: 70
	public abstract IControllerTemplateButton get_throttleWheel3Press();

	// RVA: -1 Offset: -1 Slot: 71
	public abstract IControllerTemplateAxis get_leftPedal();

	// RVA: -1 Offset: -1 Slot: 72
	public abstract IControllerTemplateAxis get_rightPedal();

	// RVA: -1 Offset: -1 Slot: 73
	public abstract IControllerTemplateAxis get_slidePedals();

	// RVA: -1 Offset: -1 Slot: 74
	public abstract IControllerTemplateStick get_stick();

	// RVA: -1 Offset: -1 Slot: 75
	public abstract IControllerTemplateThumbStick get_stickMiniStick1();

	// RVA: -1 Offset: -1 Slot: 76
	public abstract IControllerTemplateThumbStick get_stickMiniStick2();

	// RVA: -1 Offset: -1 Slot: 77
	public abstract IControllerTemplateHat get_stickHat1();

	// RVA: -1 Offset: -1 Slot: 78
	public abstract IControllerTemplateHat get_stickHat2();

	// RVA: -1 Offset: -1 Slot: 79
	public abstract IControllerTemplateHat get_stickHat3();

	// RVA: -1 Offset: -1 Slot: 80
	public abstract IControllerTemplateHat get_stickHat4();

	// RVA: -1 Offset: -1 Slot: 81
	public abstract IControllerTemplateThrottle get_throttle1();

	// RVA: -1 Offset: -1 Slot: 82
	public abstract IControllerTemplateThrottle get_throttle2();

	// RVA: -1 Offset: -1 Slot: 83
	public abstract IControllerTemplateThumbStick get_throttleMiniStick();

	// RVA: -1 Offset: -1 Slot: 84
	public abstract IControllerTemplateHat get_throttleHat1();

	// RVA: -1 Offset: -1 Slot: 85
	public abstract IControllerTemplateHat get_throttleHat2();

	// RVA: -1 Offset: -1 Slot: 86
	public abstract IControllerTemplateHat get_throttleHat3();

	// RVA: -1 Offset: -1 Slot: 87
	public abstract IControllerTemplateHat get_throttleHat4();
}

// Namespace: Rewired
public interface IFlightYokeTemplate : IControllerTemplate // TypeDefIndex: 1981
{
	// Properties
	public abstract IControllerTemplateButton leftPaddle { get; }
	public abstract IControllerTemplateButton rightPaddle { get; }
	public abstract IControllerTemplateButton leftGripButton1 { get; }
	public abstract IControllerTemplateButton leftGripButton2 { get; }
	public abstract IControllerTemplateButton leftGripButton3 { get; }
	public abstract IControllerTemplateButton leftGripButton4 { get; }
	public abstract IControllerTemplateButton leftGripButton5 { get; }
	public abstract IControllerTemplateButton leftGripButton6 { get; }
	public abstract IControllerTemplateButton rightGripButton1 { get; }
	public abstract IControllerTemplateButton rightGripButton2 { get; }
	public abstract IControllerTemplateButton rightGripButton3 { get; }
	public abstract IControllerTemplateButton rightGripButton4 { get; }
	public abstract IControllerTemplateButton rightGripButton5 { get; }
	public abstract IControllerTemplateButton rightGripButton6 { get; }
	public abstract IControllerTemplateButton centerButton1 { get; }
	public abstract IControllerTemplateButton centerButton2 { get; }
	public abstract IControllerTemplateButton centerButton3 { get; }
	public abstract IControllerTemplateButton centerButton4 { get; }
	public abstract IControllerTemplateButton centerButton5 { get; }
	public abstract IControllerTemplateButton centerButton6 { get; }
	public abstract IControllerTemplateButton centerButton7 { get; }
	public abstract IControllerTemplateButton centerButton8 { get; }
	public abstract IControllerTemplateButton wheel1Up { get; }
	public abstract IControllerTemplateButton wheel1Down { get; }
	public abstract IControllerTemplateButton wheel1Press { get; }
	public abstract IControllerTemplateButton wheel2Up { get; }
	public abstract IControllerTemplateButton wheel2Down { get; }
	public abstract IControllerTemplateButton wheel2Press { get; }
	public abstract IControllerTemplateButton consoleButton1 { get; }
	public abstract IControllerTemplateButton consoleButton2 { get; }
	public abstract IControllerTemplateButton consoleButton3 { get; }
	public abstract IControllerTemplateButton consoleButton4 { get; }
	public abstract IControllerTemplateButton consoleButton5 { get; }
	public abstract IControllerTemplateButton consoleButton6 { get; }
	public abstract IControllerTemplateButton consoleButton7 { get; }
	public abstract IControllerTemplateButton consoleButton8 { get; }
	public abstract IControllerTemplateButton consoleButton9 { get; }
	public abstract IControllerTemplateButton consoleButton10 { get; }
	public abstract IControllerTemplateButton mode1 { get; }
	public abstract IControllerTemplateButton mode2 { get; }
	public abstract IControllerTemplateButton mode3 { get; }
	public abstract IControllerTemplateYoke yoke { get; }
	public abstract IControllerTemplateThrottle lever1 { get; }
	public abstract IControllerTemplateThrottle lever2 { get; }
	public abstract IControllerTemplateThrottle lever3 { get; }
	public abstract IControllerTemplateThrottle lever4 { get; }
	public abstract IControllerTemplateThrottle lever5 { get; }
	public abstract IControllerTemplateHat leftGripHat { get; }
	public abstract IControllerTemplateHat rightGripHat { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateButton get_leftPaddle();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateButton get_rightPaddle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateButton get_leftGripButton1();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateButton get_leftGripButton2();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_leftGripButton3();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_leftGripButton4();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_leftGripButton5();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_leftGripButton6();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_rightGripButton1();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_rightGripButton2();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_rightGripButton3();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_rightGripButton4();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_rightGripButton5();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_rightGripButton6();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_centerButton1();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_centerButton2();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_centerButton3();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_centerButton4();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_centerButton5();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_centerButton6();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_centerButton7();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_centerButton8();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_wheel1Up();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_wheel1Down();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_wheel1Press();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_wheel2Up();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_wheel2Down();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_wheel2Press();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_consoleButton1();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_consoleButton2();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_consoleButton3();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_consoleButton4();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_consoleButton5();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_consoleButton6();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_consoleButton7();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_consoleButton8();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateButton get_consoleButton9();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateButton get_consoleButton10();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateButton get_mode1();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateButton get_mode2();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateButton get_mode3();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract IControllerTemplateYoke get_yoke();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract IControllerTemplateThrottle get_lever1();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract IControllerTemplateThrottle get_lever2();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract IControllerTemplateThrottle get_lever3();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract IControllerTemplateThrottle get_lever4();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract IControllerTemplateThrottle get_lever5();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract IControllerTemplateHat get_leftGripHat();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract IControllerTemplateHat get_rightGripHat();
}

// Namespace: Rewired
public interface IFlightPedalsTemplate : IControllerTemplate // TypeDefIndex: 1982
{
	// Properties
	public abstract IControllerTemplateAxis leftPedal { get; }
	public abstract IControllerTemplateAxis rightPedal { get; }
	public abstract IControllerTemplateAxis slide { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_leftPedal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_rightPedal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_slide();
}

// Namespace: Rewired
public interface ISixDofControllerTemplate : IControllerTemplate // TypeDefIndex: 1983
{
	// Properties
	public abstract IControllerTemplateAxis extraAxis1 { get; }
	public abstract IControllerTemplateAxis extraAxis2 { get; }
	public abstract IControllerTemplateAxis extraAxis3 { get; }
	public abstract IControllerTemplateAxis extraAxis4 { get; }
	public abstract IControllerTemplateButton button1 { get; }
	public abstract IControllerTemplateButton button2 { get; }
	public abstract IControllerTemplateButton button3 { get; }
	public abstract IControllerTemplateButton button4 { get; }
	public abstract IControllerTemplateButton button5 { get; }
	public abstract IControllerTemplateButton button6 { get; }
	public abstract IControllerTemplateButton button7 { get; }
	public abstract IControllerTemplateButton button8 { get; }
	public abstract IControllerTemplateButton button9 { get; }
	public abstract IControllerTemplateButton button10 { get; }
	public abstract IControllerTemplateButton button11 { get; }
	public abstract IControllerTemplateButton button12 { get; }
	public abstract IControllerTemplateButton button13 { get; }
	public abstract IControllerTemplateButton button14 { get; }
	public abstract IControllerTemplateButton button15 { get; }
	public abstract IControllerTemplateButton button16 { get; }
	public abstract IControllerTemplateButton button17 { get; }
	public abstract IControllerTemplateButton button18 { get; }
	public abstract IControllerTemplateButton button19 { get; }
	public abstract IControllerTemplateButton button20 { get; }
	public abstract IControllerTemplateButton button21 { get; }
	public abstract IControllerTemplateButton button22 { get; }
	public abstract IControllerTemplateButton button23 { get; }
	public abstract IControllerTemplateButton button24 { get; }
	public abstract IControllerTemplateButton button25 { get; }
	public abstract IControllerTemplateButton button26 { get; }
	public abstract IControllerTemplateButton button27 { get; }
	public abstract IControllerTemplateButton button28 { get; }
	public abstract IControllerTemplateButton button29 { get; }
	public abstract IControllerTemplateButton button30 { get; }
	public abstract IControllerTemplateButton button31 { get; }
	public abstract IControllerTemplateButton button32 { get; }
	public abstract IControllerTemplateHat hat1 { get; }
	public abstract IControllerTemplateHat hat2 { get; }
	public abstract IControllerTemplateThrottle throttle1 { get; }
	public abstract IControllerTemplateThrottle throttle2 { get; }
	public abstract IControllerTemplateStick6D stick { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerTemplateAxis get_extraAxis1();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IControllerTemplateAxis get_extraAxis2();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IControllerTemplateAxis get_extraAxis3();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IControllerTemplateAxis get_extraAxis4();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateButton get_button1();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateButton get_button2();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateButton get_button3();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IControllerTemplateButton get_button4();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IControllerTemplateButton get_button5();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IControllerTemplateButton get_button6();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IControllerTemplateButton get_button7();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IControllerTemplateButton get_button8();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IControllerTemplateButton get_button9();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract IControllerTemplateButton get_button10();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IControllerTemplateButton get_button11();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IControllerTemplateButton get_button12();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IControllerTemplateButton get_button13();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract IControllerTemplateButton get_button14();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IControllerTemplateButton get_button15();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IControllerTemplateButton get_button16();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IControllerTemplateButton get_button17();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IControllerTemplateButton get_button18();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IControllerTemplateButton get_button19();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract IControllerTemplateButton get_button20();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract IControllerTemplateButton get_button21();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract IControllerTemplateButton get_button22();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplateButton get_button23();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract IControllerTemplateButton get_button24();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract IControllerTemplateButton get_button25();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract IControllerTemplateButton get_button26();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract IControllerTemplateButton get_button27();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IControllerTemplateButton get_button28();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IControllerTemplateButton get_button29();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract IControllerTemplateButton get_button30();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract IControllerTemplateButton get_button31();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract IControllerTemplateButton get_button32();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract IControllerTemplateHat get_hat1();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract IControllerTemplateHat get_hat2();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract IControllerTemplateThrottle get_throttle1();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract IControllerTemplateThrottle get_throttle2();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract IControllerTemplateStick6D get_stick();
}

// Namespace: Rewired
public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate // TypeDefIndex: 1984
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_leftStickX = 0;
	public const int elementId_leftStickY = 1;
	public const int elementId_rightStickX = 2;
	public const int elementId_rightStickY = 3;
	public const int elementId_actionBottomRow1 = 4;
	public const int elementId_a = 4;
	public const int elementId_actionBottomRow2 = 5;
	public const int elementId_b = 5;
	public const int elementId_actionBottomRow3 = 6;
	public const int elementId_c = 6;
	public const int elementId_actionTopRow1 = 7;
	public const int elementId_x = 7;
	public const int elementId_actionTopRow2 = 8;
	public const int elementId_y = 8;
	public const int elementId_actionTopRow3 = 9;
	public const int elementId_z = 9;
	public const int elementId_leftShoulder1 = 10;
	public const int elementId_leftBumper = 10;
	public const int elementId_leftShoulder2 = 11;
	public const int elementId_leftTrigger = 11;
	public const int elementId_rightShoulder1 = 12;
	public const int elementId_rightBumper = 12;
	public const int elementId_rightShoulder2 = 13;
	public const int elementId_rightTrigger = 13;
	public const int elementId_center1 = 14;
	public const int elementId_back = 14;
	public const int elementId_center2 = 15;
	public const int elementId_start = 15;
	public const int elementId_center3 = 16;
	public const int elementId_guide = 16;
	public const int elementId_leftStickButton = 17;
	public const int elementId_rightStickButton = 18;
	public const int elementId_dPadUp = 19;
	public const int elementId_dPadRight = 20;
	public const int elementId_dPadDown = 21;
	public const int elementId_dPadLeft = 22;
	public const int elementId_leftStick = 23;
	public const int elementId_rightStick = 24;
	public const int elementId_dPad = 25;

	// Properties
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.a { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.b { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.c { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.x { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.y { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.z { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2 { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2 { get; }
	private IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center1 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.back { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center2 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.start { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.center3 { get; }
	private IControllerTemplateButton Rewired.IGamepadTemplate.guide { get; }
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick { get; }
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick { get; }
	private IControllerTemplateDPad Rewired.IGamepadTemplate.dPad { get; }

	// Methods

	// RVA: 0x711DB0 Offset: 0x710FB0 VA: 0x180711DB0 Slot: 20
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow1() { }

	// RVA: 0x711D70 Offset: 0x710F70 VA: 0x180711D70 Slot: 21
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_a() { }

	// RVA: 0x711DF0 Offset: 0x710FF0 VA: 0x180711DF0 Slot: 22
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow2() { }

	// RVA: 0x711F30 Offset: 0x711130 VA: 0x180711F30 Slot: 23
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_b() { }

	// RVA: 0x711E30 Offset: 0x711030 VA: 0x180711E30 Slot: 24
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionBottomRow3() { }

	// RVA: 0x711FB0 Offset: 0x7111B0 VA: 0x180711FB0 Slot: 25
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_c() { }

	// RVA: 0x711E70 Offset: 0x711070 VA: 0x180711E70 Slot: 26
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow1() { }

	// RVA: 0x7123F0 Offset: 0x7115F0 VA: 0x1807123F0 Slot: 27
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_x() { }

	// RVA: 0x711EB0 Offset: 0x7110B0 VA: 0x180711EB0 Slot: 28
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow2() { }

	// RVA: 0x712430 Offset: 0x711630 VA: 0x180712430 Slot: 29
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_y() { }

	// RVA: 0x711EF0 Offset: 0x7110F0 VA: 0x180711EF0 Slot: 30
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_actionTopRow3() { }

	// RVA: 0x712470 Offset: 0x711670 VA: 0x180712470 Slot: 31
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_z() { }

	// RVA: 0x712170 Offset: 0x711370 VA: 0x180712170 Slot: 32
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_leftShoulder1() { }

	// RVA: 0x712130 Offset: 0x711330 VA: 0x180712130 Slot: 33
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_leftBumper() { }

	// RVA: 0x7121B0 Offset: 0x7113B0 VA: 0x1807121B0 Slot: 34
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftShoulder2() { }

	// RVA: 0x712230 Offset: 0x711430 VA: 0x180712230 Slot: 35
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_leftTrigger() { }

	// RVA: 0x7122B0 Offset: 0x7114B0 VA: 0x1807122B0 Slot: 36
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_rightShoulder1() { }

	// RVA: 0x712270 Offset: 0x711470 VA: 0x180712270 Slot: 37
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_rightBumper() { }

	// RVA: 0x7122F0 Offset: 0x7114F0 VA: 0x1807122F0 Slot: 38
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightShoulder2() { }

	// RVA: 0x712370 Offset: 0x711570 VA: 0x180712370 Slot: 39
	private IControllerTemplateAxis Rewired.IGamepadTemplate.get_rightTrigger() { }

	// RVA: 0x711FF0 Offset: 0x7111F0 VA: 0x180711FF0 Slot: 40
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center1() { }

	// RVA: 0x711F70 Offset: 0x711170 VA: 0x180711F70 Slot: 41
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_back() { }

	// RVA: 0x712030 Offset: 0x711230 VA: 0x180712030 Slot: 42
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center2() { }

	// RVA: 0x7123B0 Offset: 0x7115B0 VA: 0x1807123B0 Slot: 43
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_start() { }

	// RVA: 0x712070 Offset: 0x711270 VA: 0x180712070 Slot: 44
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_center3() { }

	// RVA: 0x7120F0 Offset: 0x7112F0 VA: 0x1807120F0 Slot: 45
	private IControllerTemplateButton Rewired.IGamepadTemplate.get_guide() { }

	// RVA: 0x7121F0 Offset: 0x7113F0 VA: 0x1807121F0 Slot: 46
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_leftStick() { }

	// RVA: 0x712330 Offset: 0x711530 VA: 0x180712330 Slot: 47
	private IControllerTemplateThumbStick Rewired.IGamepadTemplate.get_rightStick() { }

	// RVA: 0x7120B0 Offset: 0x7112B0 VA: 0x1807120B0 Slot: 48
	private IControllerTemplateDPad Rewired.IGamepadTemplate.get_dPad() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x7124B0 Offset: 0x7116B0 VA: 0x1807124B0
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate // TypeDefIndex: 1985
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_wheel = 0;
	public const int elementId_accelerator = 1;
	public const int elementId_brake = 2;
	public const int elementId_clutch = 3;
	public const int elementId_shiftDown = 4;
	public const int elementId_shiftUp = 5;
	public const int elementId_wheelButton1 = 6;
	public const int elementId_wheelButton2 = 7;
	public const int elementId_wheelButton3 = 8;
	public const int elementId_wheelButton4 = 9;
	public const int elementId_wheelButton5 = 10;
	public const int elementId_wheelButton6 = 11;
	public const int elementId_wheelButton7 = 12;
	public const int elementId_wheelButton8 = 13;
	public const int elementId_wheelButton9 = 14;
	public const int elementId_wheelButton10 = 15;
	public const int elementId_consoleButton1 = 16;
	public const int elementId_consoleButton2 = 17;
	public const int elementId_consoleButton3 = 18;
	public const int elementId_consoleButton4 = 19;
	public const int elementId_consoleButton5 = 20;
	public const int elementId_consoleButton6 = 21;
	public const int elementId_consoleButton7 = 22;
	public const int elementId_consoleButton8 = 23;
	public const int elementId_consoleButton9 = 24;
	public const int elementId_consoleButton10 = 25;
	public const int elementId_shifter1 = 26;
	public const int elementId_shifter2 = 27;
	public const int elementId_shifter3 = 28;
	public const int elementId_shifter4 = 29;
	public const int elementId_shifter5 = 30;
	public const int elementId_shifter6 = 31;
	public const int elementId_shifter7 = 32;
	public const int elementId_shifter8 = 33;
	public const int elementId_shifter9 = 34;
	public const int elementId_shifter10 = 35;
	public const int elementId_reverseGear = 44;
	public const int elementId_select = 36;
	public const int elementId_start = 37;
	public const int elementId_systemButton = 38;
	public const int elementId_horn = 43;
	public const int elementId_dPadUp = 39;
	public const int elementId_dPadRight = 40;
	public const int elementId_dPadDown = 41;
	public const int elementId_dPadLeft = 42;
	public const int elementId_dPad = 45;

	// Properties
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake { get; }
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10 { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.select { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.start { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton { get; }
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.horn { get; }
	private IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad { get; }

	// Methods

	// RVA: 0x7150E0 Offset: 0x7142E0 VA: 0x1807150E0 Slot: 20
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_wheel() { }

	// RVA: 0x7146A0 Offset: 0x7138A0 VA: 0x1807146A0 Slot: 21
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_accelerator() { }

	// RVA: 0x7146E0 Offset: 0x7138E0 VA: 0x1807146E0 Slot: 22
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_brake() { }

	// RVA: 0x714720 Offset: 0x713920 VA: 0x180714720 Slot: 23
	private IControllerTemplateAxis Rewired.IRacingWheelTemplate.get_clutch() { }

	// RVA: 0x714AE0 Offset: 0x713CE0 VA: 0x180714AE0 Slot: 24
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftDown() { }

	// RVA: 0x714B20 Offset: 0x713D20 VA: 0x180714B20 Slot: 25
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shiftUp() { }

	// RVA: 0x714EA0 Offset: 0x7140A0 VA: 0x180714EA0 Slot: 26
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton1() { }

	// RVA: 0x714EE0 Offset: 0x7140E0 VA: 0x180714EE0 Slot: 27
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton2() { }

	// RVA: 0x714F20 Offset: 0x714120 VA: 0x180714F20 Slot: 28
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton3() { }

	// RVA: 0x714F60 Offset: 0x714160 VA: 0x180714F60 Slot: 29
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton4() { }

	// RVA: 0x714FA0 Offset: 0x7141A0 VA: 0x180714FA0 Slot: 30
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton5() { }

	// RVA: 0x714FE0 Offset: 0x7141E0 VA: 0x180714FE0 Slot: 31
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton6() { }

	// RVA: 0x715020 Offset: 0x714220 VA: 0x180715020 Slot: 32
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton7() { }

	// RVA: 0x715060 Offset: 0x714260 VA: 0x180715060 Slot: 33
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton8() { }

	// RVA: 0x7150A0 Offset: 0x7142A0 VA: 0x1807150A0 Slot: 34
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton9() { }

	// RVA: 0x714E60 Offset: 0x714060 VA: 0x180714E60 Slot: 35
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_wheelButton10() { }

	// RVA: 0x7147A0 Offset: 0x7139A0 VA: 0x1807147A0 Slot: 36
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton1() { }

	// RVA: 0x7147E0 Offset: 0x7139E0 VA: 0x1807147E0 Slot: 37
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton2() { }

	// RVA: 0x714820 Offset: 0x713A20 VA: 0x180714820 Slot: 38
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton3() { }

	// RVA: 0x714860 Offset: 0x713A60 VA: 0x180714860 Slot: 39
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton4() { }

	// RVA: 0x7148A0 Offset: 0x713AA0 VA: 0x1807148A0 Slot: 40
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton5() { }

	// RVA: 0x7148E0 Offset: 0x713AE0 VA: 0x1807148E0 Slot: 41
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton6() { }

	// RVA: 0x714920 Offset: 0x713B20 VA: 0x180714920 Slot: 42
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton7() { }

	// RVA: 0x714960 Offset: 0x713B60 VA: 0x180714960 Slot: 43
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton8() { }

	// RVA: 0x7149A0 Offset: 0x713BA0 VA: 0x1807149A0 Slot: 44
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton9() { }

	// RVA: 0x714760 Offset: 0x713960 VA: 0x180714760 Slot: 45
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_consoleButton10() { }

	// RVA: 0x714BA0 Offset: 0x713DA0 VA: 0x180714BA0 Slot: 46
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter1() { }

	// RVA: 0x714BE0 Offset: 0x713DE0 VA: 0x180714BE0 Slot: 47
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter2() { }

	// RVA: 0x714C20 Offset: 0x713E20 VA: 0x180714C20 Slot: 48
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter3() { }

	// RVA: 0x714C60 Offset: 0x713E60 VA: 0x180714C60 Slot: 49
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter4() { }

	// RVA: 0x714CA0 Offset: 0x713EA0 VA: 0x180714CA0 Slot: 50
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter5() { }

	// RVA: 0x714CE0 Offset: 0x713EE0 VA: 0x180714CE0 Slot: 51
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter6() { }

	// RVA: 0x714D20 Offset: 0x713F20 VA: 0x180714D20 Slot: 52
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter7() { }

	// RVA: 0x714D60 Offset: 0x713F60 VA: 0x180714D60 Slot: 53
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter8() { }

	// RVA: 0x714DA0 Offset: 0x713FA0 VA: 0x180714DA0 Slot: 54
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter9() { }

	// RVA: 0x714B60 Offset: 0x713D60 VA: 0x180714B60 Slot: 55
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_shifter10() { }

	// RVA: 0x714A60 Offset: 0x713C60 VA: 0x180714A60 Slot: 56
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_reverseGear() { }

	// RVA: 0x714AA0 Offset: 0x713CA0 VA: 0x180714AA0 Slot: 57
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_select() { }

	// RVA: 0x714DE0 Offset: 0x713FE0 VA: 0x180714DE0 Slot: 58
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_start() { }

	// RVA: 0x714E20 Offset: 0x714020 VA: 0x180714E20 Slot: 59
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_systemButton() { }

	// RVA: 0x714A20 Offset: 0x713C20 VA: 0x180714A20 Slot: 60
	private IControllerTemplateButton Rewired.IRacingWheelTemplate.get_horn() { }

	// RVA: 0x7149E0 Offset: 0x713BE0 VA: 0x1807149E0 Slot: 61
	private IControllerTemplateDPad Rewired.IRacingWheelTemplate.get_dPad() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x715120 Offset: 0x714320 VA: 0x180715120
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate // TypeDefIndex: 1986
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_stickX = 0;
	public const int elementId_stickY = 1;
	public const int elementId_stickRotate = 2;
	public const int elementId_stickMiniStick1X = 78;
	public const int elementId_stickMiniStick1Y = 79;
	public const int elementId_stickMiniStick1Press = 80;
	public const int elementId_stickMiniStick2X = 81;
	public const int elementId_stickMiniStick2Y = 82;
	public const int elementId_stickMiniStick2Press = 83;
	public const int elementId_stickTrigger = 3;
	public const int elementId_stickTriggerStage2 = 4;
	public const int elementId_stickPinkyButton = 5;
	public const int elementId_stickPinkyTrigger = 154;
	public const int elementId_stickButton1 = 6;
	public const int elementId_stickButton2 = 7;
	public const int elementId_stickButton3 = 8;
	public const int elementId_stickButton4 = 9;
	public const int elementId_stickButton5 = 10;
	public const int elementId_stickButton6 = 11;
	public const int elementId_stickButton7 = 12;
	public const int elementId_stickButton8 = 13;
	public const int elementId_stickButton9 = 14;
	public const int elementId_stickButton10 = 15;
	public const int elementId_stickBaseButton1 = 18;
	public const int elementId_stickBaseButton2 = 19;
	public const int elementId_stickBaseButton3 = 20;
	public const int elementId_stickBaseButton4 = 21;
	public const int elementId_stickBaseButton5 = 22;
	public const int elementId_stickBaseButton6 = 23;
	public const int elementId_stickBaseButton7 = 24;
	public const int elementId_stickBaseButton8 = 25;
	public const int elementId_stickBaseButton9 = 26;
	public const int elementId_stickBaseButton10 = 27;
	public const int elementId_stickBaseButton11 = 161;
	public const int elementId_stickBaseButton12 = 162;
	public const int elementId_stickHat1Up = 28;
	public const int elementId_stickHat1UpRight = 29;
	public const int elementId_stickHat1Right = 30;
	public const int elementId_stickHat1DownRight = 31;
	public const int elementId_stickHat1Down = 32;
	public const int elementId_stickHat1DownLeft = 33;
	public const int elementId_stickHat1Left = 34;
	public const int elementId_stickHat1Up_Left = 35;
	public const int elementId_stickHat2Up = 36;
	public const int elementId_stickHat2Up_right = 37;
	public const int elementId_stickHat2Right = 38;
	public const int elementId_stickHat2Down_Right = 39;
	public const int elementId_stickHat2Down = 40;
	public const int elementId_stickHat2Down_Left = 41;
	public const int elementId_stickHat2Left = 42;
	public const int elementId_stickHat2Up_Left = 43;
	public const int elementId_stickHat3Up = 84;
	public const int elementId_stickHat3Up_Right = 85;
	public const int elementId_stickHat3Right = 86;
	public const int elementId_stickHat3Down_Right = 87;
	public const int elementId_stickHat3Down = 88;
	public const int elementId_stickHat3Down_Left = 89;
	public const int elementId_stickHat3Left = 90;
	public const int elementId_stickHat3Up_Left = 91;
	public const int elementId_stickHat4Up = 92;
	public const int elementId_stickHat4Up_Right = 93;
	public const int elementId_stickHat4Right = 94;
	public const int elementId_stickHat4Down_Right = 95;
	public const int elementId_stickHat4Down = 96;
	public const int elementId_stickHat4Down_Left = 97;
	public const int elementId_stickHat4Left = 98;
	public const int elementId_stickHat4Up_Left = 99;
	public const int elementId_mode1 = 44;
	public const int elementId_mode2 = 45;
	public const int elementId_mode3 = 46;
	public const int elementId_throttle1Axis = 49;
	public const int elementId_throttle2Axis = 155;
	public const int elementId_throttle1MinDetent = 166;
	public const int elementId_throttle2MinDetent = 167;
	public const int elementId_throttleButton1 = 50;
	public const int elementId_throttleButton2 = 51;
	public const int elementId_throttleButton3 = 52;
	public const int elementId_throttleButton4 = 53;
	public const int elementId_throttleButton5 = 54;
	public const int elementId_throttleButton6 = 55;
	public const int elementId_throttleButton7 = 56;
	public const int elementId_throttleButton8 = 57;
	public const int elementId_throttleButton9 = 58;
	public const int elementId_throttleButton10 = 59;
	public const int elementId_throttleBaseButton1 = 60;
	public const int elementId_throttleBaseButton2 = 61;
	public const int elementId_throttleBaseButton3 = 62;
	public const int elementId_throttleBaseButton4 = 63;
	public const int elementId_throttleBaseButton5 = 64;
	public const int elementId_throttleBaseButton6 = 65;
	public const int elementId_throttleBaseButton7 = 66;
	public const int elementId_throttleBaseButton8 = 67;
	public const int elementId_throttleBaseButton9 = 68;
	public const int elementId_throttleBaseButton10 = 69;
	public const int elementId_throttleBaseButton11 = 132;
	public const int elementId_throttleBaseButton12 = 133;
	public const int elementId_throttleBaseButton13 = 134;
	public const int elementId_throttleBaseButton14 = 135;
	public const int elementId_throttleBaseButton15 = 136;
	public const int elementId_throttleSlider1 = 70;
	public const int elementId_throttleSlider2 = 71;
	public const int elementId_throttleSlider3 = 72;
	public const int elementId_throttleSlider4 = 73;
	public const int elementId_throttleDial1 = 74;
	public const int elementId_throttleDial2 = 142;
	public const int elementId_throttleDial3 = 143;
	public const int elementId_throttleDial4 = 144;
	public const int elementId_throttleMiniStickX = 75;
	public const int elementId_throttleMiniStickY = 76;
	public const int elementId_throttleMiniStickPress = 77;
	public const int elementId_throttleWheel1Forward = 145;
	public const int elementId_throttleWheel1Back = 146;
	public const int elementId_throttleWheel1Press = 147;
	public const int elementId_throttleWheel2Forward = 148;
	public const int elementId_throttleWheel2Back = 149;
	public const int elementId_throttleWheel2Press = 150;
	public const int elementId_throttleWheel3Forward = 151;
	public const int elementId_throttleWheel3Back = 152;
	public const int elementId_throttleWheel3Press = 153;
	public const int elementId_throttleHat1Up = 100;
	public const int elementId_throttleHat1Up_Right = 101;
	public const int elementId_throttleHat1Right = 102;
	public const int elementId_throttleHat1Down_Right = 103;
	public const int elementId_throttleHat1Down = 104;
	public const int elementId_throttleHat1Down_Left = 105;
	public const int elementId_throttleHat1Left = 106;
	public const int elementId_throttleHat1Up_Left = 107;
	public const int elementId_throttleHat2Up = 108;
	public const int elementId_throttleHat2Up_Right = 109;
	public const int elementId_throttleHat2Right = 110;
	public const int elementId_throttleHat2Down_Right = 111;
	public const int elementId_throttleHat2Down = 112;
	public const int elementId_throttleHat2Down_Left = 113;
	public const int elementId_throttleHat2Left = 114;
	public const int elementId_throttleHat2Up_Left = 115;
	public const int elementId_throttleHat3Up = 116;
	public const int elementId_throttleHat3Up_Right = 117;
	public const int elementId_throttleHat3Right = 118;
	public const int elementId_throttleHat3Down_Right = 119;
	public const int elementId_throttleHat3Down = 120;
	public const int elementId_throttleHat3Down_Left = 121;
	public const int elementId_throttleHat3Left = 122;
	public const int elementId_throttleHat3Up_Left = 123;
	public const int elementId_throttleHat4Up = 124;
	public const int elementId_throttleHat4Up_Right = 125;
	public const int elementId_throttleHat4Right = 126;
	public const int elementId_throttleHat4Down_Right = 127;
	public const int elementId_throttleHat4Down = 128;
	public const int elementId_throttleHat4Down_Left = 129;
	public const int elementId_throttleHat4Left = 130;
	public const int elementId_throttleHat4Up_Left = 131;
	public const int elementId_leftPedal = 168;
	public const int elementId_rightPedal = 169;
	public const int elementId_slidePedals = 170;
	public const int elementId_stick = 171;
	public const int elementId_stickMiniStick1 = 172;
	public const int elementId_stickMiniStick2 = 173;
	public const int elementId_stickHat1 = 174;
	public const int elementId_stickHat2 = 175;
	public const int elementId_stickHat3 = 176;
	public const int elementId_stickHat4 = 177;
	public const int elementId_throttle1 = 178;
	public const int elementId_throttle2 = 179;
	public const int elementId_throttleMiniStick = 180;
	public const int elementId_throttleHat1 = 181;
	public const int elementId_throttleHat2 = 182;
	public const int elementId_throttleHat3 = 183;
	public const int elementId_throttleHat4 = 184;

	// Properties
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.mode3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3 { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4 { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back { get; }
	private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal { get; }
	private IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals { get; }
	private IControllerTemplateStick Rewired.IHOTASTemplate.stick { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1 { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4 { get; }
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1 { get; }
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2 { get; }
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3 { get; }
	private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4 { get; }

	// Methods

	// RVA: 0x72D160 Offset: 0x72C360 VA: 0x18072D160 Slot: 20
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTrigger() { }

	// RVA: 0x72D120 Offset: 0x72C320 VA: 0x18072D120 Slot: 21
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickTriggerStage2() { }

	// RVA: 0x72D0A0 Offset: 0x72C2A0 VA: 0x18072D0A0 Slot: 22
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyButton() { }

	// RVA: 0x72D0E0 Offset: 0x72C2E0 VA: 0x18072D0E0 Slot: 23
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickPinkyTrigger() { }

	// RVA: 0x72CCE0 Offset: 0x72BEE0 VA: 0x18072CCE0 Slot: 24
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton1() { }

	// RVA: 0x72CD20 Offset: 0x72BF20 VA: 0x18072CD20 Slot: 25
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton2() { }

	// RVA: 0x72CD60 Offset: 0x72BF60 VA: 0x18072CD60 Slot: 26
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton3() { }

	// RVA: 0x72CDA0 Offset: 0x72BFA0 VA: 0x18072CDA0 Slot: 27
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton4() { }

	// RVA: 0x72CDE0 Offset: 0x72BFE0 VA: 0x18072CDE0 Slot: 28
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton5() { }

	// RVA: 0x72CE20 Offset: 0x72C020 VA: 0x18072CE20 Slot: 29
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton6() { }

	// RVA: 0x72CE60 Offset: 0x72C060 VA: 0x18072CE60 Slot: 30
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton7() { }

	// RVA: 0x72CEA0 Offset: 0x72C0A0 VA: 0x18072CEA0 Slot: 31
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton8() { }

	// RVA: 0x72CEE0 Offset: 0x72C0E0 VA: 0x18072CEE0 Slot: 32
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton9() { }

	// RVA: 0x72CCA0 Offset: 0x72BEA0 VA: 0x18072CCA0 Slot: 33
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickButton10() { }

	// RVA: 0x72CA60 Offset: 0x72BC60 VA: 0x18072CA60 Slot: 34
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton1() { }

	// RVA: 0x72CAA0 Offset: 0x72BCA0 VA: 0x18072CAA0 Slot: 35
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton2() { }

	// RVA: 0x72CAE0 Offset: 0x72BCE0 VA: 0x18072CAE0 Slot: 36
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton3() { }

	// RVA: 0x72CB20 Offset: 0x72BD20 VA: 0x18072CB20 Slot: 37
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton4() { }

	// RVA: 0x72CB60 Offset: 0x72BD60 VA: 0x18072CB60 Slot: 38
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton5() { }

	// RVA: 0x72CBA0 Offset: 0x72BDA0 VA: 0x18072CBA0 Slot: 39
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton6() { }

	// RVA: 0x72CBE0 Offset: 0x72BDE0 VA: 0x18072CBE0 Slot: 40
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton7() { }

	// RVA: 0x72CC20 Offset: 0x72BE20 VA: 0x18072CC20 Slot: 41
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton8() { }

	// RVA: 0x72CC60 Offset: 0x72BE60 VA: 0x18072CC60 Slot: 42
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton9() { }

	// RVA: 0x72C9A0 Offset: 0x72BBA0 VA: 0x18072C9A0 Slot: 43
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton10() { }

	// RVA: 0x72C9E0 Offset: 0x72BBE0 VA: 0x18072C9E0 Slot: 44
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton11() { }

	// RVA: 0x72CA20 Offset: 0x72BC20 VA: 0x18072CA20 Slot: 45
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_stickBaseButton12() { }

	// RVA: 0x72C860 Offset: 0x72BA60 VA: 0x18072C860 Slot: 46
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode1() { }

	// RVA: 0x72C8A0 Offset: 0x72BAA0 VA: 0x18072C8A0 Slot: 47
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode2() { }

	// RVA: 0x72C8E0 Offset: 0x72BAE0 VA: 0x18072C8E0 Slot: 48
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_mode3() { }

	// RVA: 0x72D660 Offset: 0x72C860 VA: 0x18072D660 Slot: 49
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton1() { }

	// RVA: 0x72D6A0 Offset: 0x72C8A0 VA: 0x18072D6A0 Slot: 50
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton2() { }

	// RVA: 0x72D6E0 Offset: 0x72C8E0 VA: 0x18072D6E0 Slot: 51
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton3() { }

	// RVA: 0x72D720 Offset: 0x72C920 VA: 0x18072D720 Slot: 52
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton4() { }

	// RVA: 0x72D760 Offset: 0x72C960 VA: 0x18072D760 Slot: 53
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton5() { }

	// RVA: 0x72D7A0 Offset: 0x72C9A0 VA: 0x18072D7A0 Slot: 54
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton6() { }

	// RVA: 0x72D7E0 Offset: 0x72C9E0 VA: 0x18072D7E0 Slot: 55
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton7() { }

	// RVA: 0x72D820 Offset: 0x72CA20 VA: 0x18072D820 Slot: 56
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton8() { }

	// RVA: 0x72D860 Offset: 0x72CA60 VA: 0x18072D860 Slot: 57
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton9() { }

	// RVA: 0x72D620 Offset: 0x72C820 VA: 0x18072D620 Slot: 58
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleButton10() { }

	// RVA: 0x72D3E0 Offset: 0x72C5E0 VA: 0x18072D3E0 Slot: 59
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton1() { }

	// RVA: 0x72D420 Offset: 0x72C620 VA: 0x18072D420 Slot: 60
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton2() { }

	// RVA: 0x72D460 Offset: 0x72C660 VA: 0x18072D460 Slot: 61
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton3() { }

	// RVA: 0x72D4A0 Offset: 0x72C6A0 VA: 0x18072D4A0 Slot: 62
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton4() { }

	// RVA: 0x72D4E0 Offset: 0x72C6E0 VA: 0x18072D4E0 Slot: 63
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton5() { }

	// RVA: 0x72D520 Offset: 0x72C720 VA: 0x18072D520 Slot: 64
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton6() { }

	// RVA: 0x72D560 Offset: 0x72C760 VA: 0x18072D560 Slot: 65
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton7() { }

	// RVA: 0x72D5A0 Offset: 0x72C7A0 VA: 0x18072D5A0 Slot: 66
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton8() { }

	// RVA: 0x72D5E0 Offset: 0x72C7E0 VA: 0x18072D5E0 Slot: 67
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton9() { }

	// RVA: 0x72D260 Offset: 0x72C460 VA: 0x18072D260 Slot: 68
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton10() { }

	// RVA: 0x72D2A0 Offset: 0x72C4A0 VA: 0x18072D2A0 Slot: 69
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton11() { }

	// RVA: 0x72D2E0 Offset: 0x72C4E0 VA: 0x18072D2E0 Slot: 70
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton12() { }

	// RVA: 0x72D320 Offset: 0x72C520 VA: 0x18072D320 Slot: 71
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton13() { }

	// RVA: 0x72D360 Offset: 0x72C560 VA: 0x18072D360 Slot: 72
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton14() { }

	// RVA: 0x72D3A0 Offset: 0x72C5A0 VA: 0x18072D3A0 Slot: 73
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleBaseButton15() { }

	// RVA: 0x72DAE0 Offset: 0x72CCE0 VA: 0x18072DAE0 Slot: 74
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider1() { }

	// RVA: 0x72DB20 Offset: 0x72CD20 VA: 0x18072DB20 Slot: 75
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider2() { }

	// RVA: 0x72DB60 Offset: 0x72CD60 VA: 0x18072DB60 Slot: 76
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider3() { }

	// RVA: 0x72DBA0 Offset: 0x72CDA0 VA: 0x18072DBA0 Slot: 77
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleSlider4() { }

	// RVA: 0x72D8A0 Offset: 0x72CAA0 VA: 0x18072D8A0 Slot: 78
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial1() { }

	// RVA: 0x72D8E0 Offset: 0x72CAE0 VA: 0x18072D8E0 Slot: 79
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial2() { }

	// RVA: 0x72D920 Offset: 0x72CB20 VA: 0x18072D920 Slot: 80
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial3() { }

	// RVA: 0x72D960 Offset: 0x72CB60 VA: 0x18072D960 Slot: 81
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_throttleDial4() { }

	// RVA: 0x72DC20 Offset: 0x72CE20 VA: 0x18072DC20 Slot: 82
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Forward() { }

	// RVA: 0x72DBE0 Offset: 0x72CDE0 VA: 0x18072DBE0 Slot: 83
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Back() { }

	// RVA: 0x72DC60 Offset: 0x72CE60 VA: 0x18072DC60 Slot: 84
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel1Press() { }

	// RVA: 0x72DCE0 Offset: 0x72CEE0 VA: 0x18072DCE0 Slot: 85
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Forward() { }

	// RVA: 0x72DCA0 Offset: 0x72CEA0 VA: 0x18072DCA0 Slot: 86
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Back() { }

	// RVA: 0x72DD20 Offset: 0x72CF20 VA: 0x18072DD20 Slot: 87
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel2Press() { }

	// RVA: 0x72DDA0 Offset: 0x72CFA0 VA: 0x18072DDA0 Slot: 88
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Forward() { }

	// RVA: 0x72DD60 Offset: 0x72CF60 VA: 0x18072DD60 Slot: 89
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Back() { }

	// RVA: 0x72DDE0 Offset: 0x72CFE0 VA: 0x18072DDE0 Slot: 90
	private IControllerTemplateButton Rewired.IHOTASTemplate.get_throttleWheel3Press() { }

	// RVA: 0x72C820 Offset: 0x72BA20 VA: 0x18072C820 Slot: 91
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_leftPedal() { }

	// RVA: 0x72C920 Offset: 0x72BB20 VA: 0x18072C920 Slot: 92
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_rightPedal() { }

	// RVA: 0x72C960 Offset: 0x72BB60 VA: 0x18072C960 Slot: 93
	private IControllerTemplateAxis Rewired.IHOTASTemplate.get_slidePedals() { }

	// RVA: 0x72D1A0 Offset: 0x72C3A0 VA: 0x18072D1A0 Slot: 94
	private IControllerTemplateStick Rewired.IHOTASTemplate.get_stick() { }

	// RVA: 0x72D020 Offset: 0x72C220 VA: 0x18072D020 Slot: 95
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick1() { }

	// RVA: 0x72D060 Offset: 0x72C260 VA: 0x18072D060 Slot: 96
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_stickMiniStick2() { }

	// RVA: 0x72CF20 Offset: 0x72C120 VA: 0x18072CF20 Slot: 97
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat1() { }

	// RVA: 0x72CF60 Offset: 0x72C160 VA: 0x18072CF60 Slot: 98
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat2() { }

	// RVA: 0x72CFA0 Offset: 0x72C1A0 VA: 0x18072CFA0 Slot: 99
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat3() { }

	// RVA: 0x72CFE0 Offset: 0x72C1E0 VA: 0x18072CFE0 Slot: 100
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_stickHat4() { }

	// RVA: 0x72D1E0 Offset: 0x72C3E0 VA: 0x18072D1E0 Slot: 101
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle1() { }

	// RVA: 0x72D220 Offset: 0x72C420 VA: 0x18072D220 Slot: 102
	private IControllerTemplateThrottle Rewired.IHOTASTemplate.get_throttle2() { }

	// RVA: 0x72DAA0 Offset: 0x72CCA0 VA: 0x18072DAA0 Slot: 103
	private IControllerTemplateThumbStick Rewired.IHOTASTemplate.get_throttleMiniStick() { }

	// RVA: 0x72D9A0 Offset: 0x72CBA0 VA: 0x18072D9A0 Slot: 104
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat1() { }

	// RVA: 0x72D9E0 Offset: 0x72CBE0 VA: 0x18072D9E0 Slot: 105
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat2() { }

	// RVA: 0x72DA20 Offset: 0x72CC20 VA: 0x18072DA20 Slot: 106
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat3() { }

	// RVA: 0x72DA60 Offset: 0x72CC60 VA: 0x18072DA60 Slot: 107
	private IControllerTemplateHat Rewired.IHOTASTemplate.get_throttleHat4() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x72DE20 Offset: 0x72D020 VA: 0x18072DE20
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate // TypeDefIndex: 1987
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_rotateYoke = 0;
	public const int elementId_yokeZ = 1;
	public const int elementId_leftPaddle = 59;
	public const int elementId_rightPaddle = 60;
	public const int elementId_lever1Axis = 2;
	public const int elementId_lever1MinDetent = 64;
	public const int elementId_lever2Axis = 3;
	public const int elementId_lever2MinDetent = 65;
	public const int elementId_lever3Axis = 4;
	public const int elementId_lever3MinDetent = 66;
	public const int elementId_lever4Axis = 5;
	public const int elementId_lever4MinDetent = 67;
	public const int elementId_lever5Axis = 6;
	public const int elementId_lever5MinDetent = 68;
	public const int elementId_leftGripButton1 = 7;
	public const int elementId_leftGripButton2 = 8;
	public const int elementId_leftGripButton3 = 9;
	public const int elementId_leftGripButton4 = 10;
	public const int elementId_leftGripButton5 = 11;
	public const int elementId_leftGripButton6 = 12;
	public const int elementId_rightGripButton1 = 13;
	public const int elementId_rightGripButton2 = 14;
	public const int elementId_rightGripButton3 = 15;
	public const int elementId_rightGripButton4 = 16;
	public const int elementId_rightGripButton5 = 17;
	public const int elementId_rightGripButton6 = 18;
	public const int elementId_centerButton1 = 19;
	public const int elementId_centerButton2 = 20;
	public const int elementId_centerButton3 = 21;
	public const int elementId_centerButton4 = 22;
	public const int elementId_centerButton5 = 23;
	public const int elementId_centerButton6 = 24;
	public const int elementId_centerButton7 = 25;
	public const int elementId_centerButton8 = 26;
	public const int elementId_wheel1Up = 53;
	public const int elementId_wheel1Down = 54;
	public const int elementId_wheel1Press = 55;
	public const int elementId_wheel2Up = 56;
	public const int elementId_wheel2Down = 57;
	public const int elementId_wheel2Press = 58;
	public const int elementId_leftGripHatUp = 27;
	public const int elementId_leftGripHatUpRight = 28;
	public const int elementId_leftGripHatRight = 29;
	public const int elementId_leftGripHatDownRight = 30;
	public const int elementId_leftGripHatDown = 31;
	public const int elementId_leftGripHatDownLeft = 32;
	public const int elementId_leftGripHatLeft = 33;
	public const int elementId_leftGripHatUpLeft = 34;
	public const int elementId_rightGripHatUp = 35;
	public const int elementId_rightGripHatUpRight = 36;
	public const int elementId_rightGripHatRight = 37;
	public const int elementId_rightGripHatDownRight = 38;
	public const int elementId_rightGripHatDown = 39;
	public const int elementId_rightGripHatDownLeft = 40;
	public const int elementId_rightGripHatLeft = 41;
	public const int elementId_rightGripHatUpLeft = 42;
	public const int elementId_consoleButton1 = 43;
	public const int elementId_consoleButton2 = 44;
	public const int elementId_consoleButton3 = 45;
	public const int elementId_consoleButton4 = 46;
	public const int elementId_consoleButton5 = 47;
	public const int elementId_consoleButton6 = 48;
	public const int elementId_consoleButton7 = 49;
	public const int elementId_consoleButton8 = 50;
	public const int elementId_consoleButton9 = 51;
	public const int elementId_consoleButton10 = 52;
	public const int elementId_mode1 = 61;
	public const int elementId_mode2 = 62;
	public const int elementId_mode3 = 63;
	public const int elementId_yoke = 69;
	public const int elementId_lever1 = 70;
	public const int elementId_lever2 = 71;
	public const int elementId_lever3 = 72;
	public const int elementId_lever4 = 73;
	public const int elementId_lever5 = 74;
	public const int elementId_leftGripHat = 75;
	public const int elementId_rightGripHat = 76;

	// Properties
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2 { get; }
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3 { get; }
	private IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4 { get; }
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5 { get; }
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat { get; }
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat { get; }

	// Methods

	// RVA: 0x72A3A0 Offset: 0x7295A0 VA: 0x18072A3A0 Slot: 20
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftPaddle() { }

	// RVA: 0x72A7A0 Offset: 0x7299A0 VA: 0x18072A7A0 Slot: 21
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightPaddle() { }

	// RVA: 0x72A1E0 Offset: 0x7293E0 VA: 0x18072A1E0 Slot: 22
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton1() { }

	// RVA: 0x72A220 Offset: 0x729420 VA: 0x18072A220 Slot: 23
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton2() { }

	// RVA: 0x72A260 Offset: 0x729460 VA: 0x18072A260 Slot: 24
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton3() { }

	// RVA: 0x72A2A0 Offset: 0x7294A0 VA: 0x18072A2A0 Slot: 25
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton4() { }

	// RVA: 0x72A2E0 Offset: 0x7294E0 VA: 0x18072A2E0 Slot: 26
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton5() { }

	// RVA: 0x72A320 Offset: 0x729520 VA: 0x18072A320 Slot: 27
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_leftGripButton6() { }

	// RVA: 0x72A5E0 Offset: 0x7297E0 VA: 0x18072A5E0 Slot: 28
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton1() { }

	// RVA: 0x72A620 Offset: 0x729820 VA: 0x18072A620 Slot: 29
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton2() { }

	// RVA: 0x72A660 Offset: 0x729860 VA: 0x18072A660 Slot: 30
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton3() { }

	// RVA: 0x72A6A0 Offset: 0x7298A0 VA: 0x18072A6A0 Slot: 31
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton4() { }

	// RVA: 0x72A6E0 Offset: 0x7298E0 VA: 0x18072A6E0 Slot: 32
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton5() { }

	// RVA: 0x72A720 Offset: 0x729920 VA: 0x18072A720 Slot: 33
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_rightGripButton6() { }

	// RVA: 0x729D60 Offset: 0x728F60 VA: 0x180729D60 Slot: 34
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton1() { }

	// RVA: 0x729DA0 Offset: 0x728FA0 VA: 0x180729DA0 Slot: 35
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton2() { }

	// RVA: 0x729DE0 Offset: 0x728FE0 VA: 0x180729DE0 Slot: 36
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton3() { }

	// RVA: 0x729E20 Offset: 0x729020 VA: 0x180729E20 Slot: 37
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton4() { }

	// RVA: 0x729E60 Offset: 0x729060 VA: 0x180729E60 Slot: 38
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton5() { }

	// RVA: 0x729EA0 Offset: 0x7290A0 VA: 0x180729EA0 Slot: 39
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton6() { }

	// RVA: 0x729EE0 Offset: 0x7290E0 VA: 0x180729EE0 Slot: 40
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton7() { }

	// RVA: 0x729F20 Offset: 0x729120 VA: 0x180729F20 Slot: 41
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_centerButton8() { }

	// RVA: 0x72A860 Offset: 0x729A60 VA: 0x18072A860 Slot: 42
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Up() { }

	// RVA: 0x72A7E0 Offset: 0x7299E0 VA: 0x18072A7E0 Slot: 43
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Down() { }

	// RVA: 0x72A820 Offset: 0x729A20 VA: 0x18072A820 Slot: 44
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel1Press() { }

	// RVA: 0x72A920 Offset: 0x729B20 VA: 0x18072A920 Slot: 45
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Up() { }

	// RVA: 0x72A8A0 Offset: 0x729AA0 VA: 0x18072A8A0 Slot: 46
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Down() { }

	// RVA: 0x72A8E0 Offset: 0x729AE0 VA: 0x18072A8E0 Slot: 47
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_wheel2Press() { }

	// RVA: 0x729FA0 Offset: 0x7291A0 VA: 0x180729FA0 Slot: 48
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton1() { }

	// RVA: 0x729FE0 Offset: 0x7291E0 VA: 0x180729FE0 Slot: 49
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton2() { }

	// RVA: 0x72A020 Offset: 0x729220 VA: 0x18072A020 Slot: 50
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton3() { }

	// RVA: 0x72A060 Offset: 0x729260 VA: 0x18072A060 Slot: 51
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton4() { }

	// RVA: 0x72A0A0 Offset: 0x7292A0 VA: 0x18072A0A0 Slot: 52
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton5() { }

	// RVA: 0x72A0E0 Offset: 0x7292E0 VA: 0x18072A0E0 Slot: 53
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton6() { }

	// RVA: 0x72A120 Offset: 0x729320 VA: 0x18072A120 Slot: 54
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton7() { }

	// RVA: 0x72A160 Offset: 0x729360 VA: 0x18072A160 Slot: 55
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton8() { }

	// RVA: 0x72A1A0 Offset: 0x7293A0 VA: 0x18072A1A0 Slot: 56
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton9() { }

	// RVA: 0x729F60 Offset: 0x729160 VA: 0x180729F60 Slot: 57
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_consoleButton10() { }

	// RVA: 0x72A520 Offset: 0x729720 VA: 0x18072A520 Slot: 58
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode1() { }

	// RVA: 0x72A560 Offset: 0x729760 VA: 0x18072A560 Slot: 59
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode2() { }

	// RVA: 0x72A5A0 Offset: 0x7297A0 VA: 0x18072A5A0 Slot: 60
	private IControllerTemplateButton Rewired.IFlightYokeTemplate.get_mode3() { }

	// RVA: 0x72A960 Offset: 0x729B60 VA: 0x18072A960 Slot: 61
	private IControllerTemplateYoke Rewired.IFlightYokeTemplate.get_yoke() { }

	// RVA: 0x72A3E0 Offset: 0x7295E0 VA: 0x18072A3E0 Slot: 62
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever1() { }

	// RVA: 0x72A420 Offset: 0x729620 VA: 0x18072A420 Slot: 63
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever2() { }

	// RVA: 0x72A460 Offset: 0x729660 VA: 0x18072A460 Slot: 64
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever3() { }

	// RVA: 0x72A4A0 Offset: 0x7296A0 VA: 0x18072A4A0 Slot: 65
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever4() { }

	// RVA: 0x72A4E0 Offset: 0x7296E0 VA: 0x18072A4E0 Slot: 66
	private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.get_lever5() { }

	// RVA: 0x72A360 Offset: 0x729560 VA: 0x18072A360 Slot: 67
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.get_leftGripHat() { }

	// RVA: 0x72A760 Offset: 0x729960 VA: 0x18072A760 Slot: 68
	private IControllerTemplateHat Rewired.IFlightYokeTemplate.get_rightGripHat() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x72A9A0 Offset: 0x729BA0 VA: 0x18072A9A0
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate // TypeDefIndex: 1988
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_leftPedal = 0;
	public const int elementId_rightPedal = 1;
	public const int elementId_slide = 2;

	// Properties
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal { get; }
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal { get; }
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide { get; }

	// Methods

	// RVA: 0x729C30 Offset: 0x728E30 VA: 0x180729C30 Slot: 20
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_leftPedal() { }

	// RVA: 0x729C70 Offset: 0x728E70 VA: 0x180729C70 Slot: 21
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_rightPedal() { }

	// RVA: 0x729CB0 Offset: 0x728EB0 VA: 0x180729CB0 Slot: 22
	private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.get_slide() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x729CF0 Offset: 0x728EF0 VA: 0x180729CF0
	private static void .cctor() { }
}

// Namespace: Rewired
public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate // TypeDefIndex: 1989
{
	// Fields
	public static readonly Guid typeGuid; // 0x0
	public const int elementId_positionX = 1;
	public const int elementId_positionY = 2;
	public const int elementId_positionZ = 0;
	public const int elementId_rotationX = 3;
	public const int elementId_rotationY = 5;
	public const int elementId_rotationZ = 4;
	public const int elementId_throttle1Axis = 6;
	public const int elementId_throttle1MinDetent = 50;
	public const int elementId_throttle2Axis = 7;
	public const int elementId_throttle2MinDetent = 51;
	public const int elementId_extraAxis1 = 8;
	public const int elementId_extraAxis2 = 9;
	public const int elementId_extraAxis3 = 10;
	public const int elementId_extraAxis4 = 11;
	public const int elementId_button1 = 12;
	public const int elementId_button2 = 13;
	public const int elementId_button3 = 14;
	public const int elementId_button4 = 15;
	public const int elementId_button5 = 16;
	public const int elementId_button6 = 17;
	public const int elementId_button7 = 18;
	public const int elementId_button8 = 19;
	public const int elementId_button9 = 20;
	public const int elementId_button10 = 21;
	public const int elementId_button11 = 22;
	public const int elementId_button12 = 23;
	public const int elementId_button13 = 24;
	public const int elementId_button14 = 25;
	public const int elementId_button15 = 26;
	public const int elementId_button16 = 27;
	public const int elementId_button17 = 28;
	public const int elementId_button18 = 29;
	public const int elementId_button19 = 30;
	public const int elementId_button20 = 31;
	public const int elementId_button21 = 55;
	public const int elementId_button22 = 56;
	public const int elementId_button23 = 57;
	public const int elementId_button24 = 58;
	public const int elementId_button25 = 59;
	public const int elementId_button26 = 60;
	public const int elementId_button27 = 61;
	public const int elementId_button28 = 62;
	public const int elementId_button29 = 63;
	public const int elementId_button30 = 64;
	public const int elementId_button31 = 65;
	public const int elementId_button32 = 66;
	public const int elementId_hat1Up = 32;
	public const int elementId_hat1UpRight = 33;
	public const int elementId_hat1Right = 34;
	public const int elementId_hat1DownRight = 35;
	public const int elementId_hat1Down = 36;
	public const int elementId_hat1DownLeft = 37;
	public const int elementId_hat1Left = 38;
	public const int elementId_hat1UpLeft = 39;
	public const int elementId_hat2Up = 40;
	public const int elementId_hat2UpRight = 41;
	public const int elementId_hat2Right = 42;
	public const int elementId_hat2DownRight = 43;
	public const int elementId_hat2Down = 44;
	public const int elementId_hat2DownLeft = 45;
	public const int elementId_hat2Left = 46;
	public const int elementId_hat2UpLeft = 47;
	public const int elementId_hat1 = 48;
	public const int elementId_hat2 = 49;
	public const int elementId_throttle1 = 52;
	public const int elementId_throttle2 = 53;
	public const int elementId_stick = 54;

	// Properties
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3 { get; }
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31 { get; }
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32 { get; }
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1 { get; }
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2 { get; }
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1 { get; }
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2 { get; }
	private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick { get; }

	// Methods

	// RVA: 0x739660 Offset: 0x738860 VA: 0x180739660 Slot: 20
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis1() { }

	// RVA: 0x7396A0 Offset: 0x7388A0 VA: 0x1807396A0 Slot: 21
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis2() { }

	// RVA: 0x7396E0 Offset: 0x7388E0 VA: 0x1807396E0 Slot: 22
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis3() { }

	// RVA: 0x739720 Offset: 0x738920 VA: 0x180739720 Slot: 23
	private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.get_extraAxis4() { }

	// RVA: 0x7390E0 Offset: 0x7382E0 VA: 0x1807390E0 Slot: 24
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button1() { }

	// RVA: 0x7393A0 Offset: 0x7385A0 VA: 0x1807393A0 Slot: 25
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button2() { }

	// RVA: 0x7394A0 Offset: 0x7386A0 VA: 0x1807394A0 Slot: 26
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button3() { }

	// RVA: 0x7394E0 Offset: 0x7386E0 VA: 0x1807394E0 Slot: 27
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button4() { }

	// RVA: 0x739520 Offset: 0x738720 VA: 0x180739520 Slot: 28
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button5() { }

	// RVA: 0x739560 Offset: 0x738760 VA: 0x180739560 Slot: 29
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button6() { }

	// RVA: 0x7395A0 Offset: 0x7387A0 VA: 0x1807395A0 Slot: 30
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button7() { }

	// RVA: 0x7395E0 Offset: 0x7387E0 VA: 0x1807395E0 Slot: 31
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button8() { }

	// RVA: 0x739620 Offset: 0x738820 VA: 0x180739620 Slot: 32
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button9() { }

	// RVA: 0x738E60 Offset: 0x738060 VA: 0x180738E60 Slot: 33
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button10() { }

	// RVA: 0x738EA0 Offset: 0x7380A0 VA: 0x180738EA0 Slot: 34
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button11() { }

	// RVA: 0x738EE0 Offset: 0x7380E0 VA: 0x180738EE0 Slot: 35
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button12() { }

	// RVA: 0x738F20 Offset: 0x738120 VA: 0x180738F20 Slot: 36
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button13() { }

	// RVA: 0x738F60 Offset: 0x738160 VA: 0x180738F60 Slot: 37
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button14() { }

	// RVA: 0x738FA0 Offset: 0x7381A0 VA: 0x180738FA0 Slot: 38
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button15() { }

	// RVA: 0x738FE0 Offset: 0x7381E0 VA: 0x180738FE0 Slot: 39
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button16() { }

	// RVA: 0x739020 Offset: 0x738220 VA: 0x180739020 Slot: 40
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button17() { }

	// RVA: 0x739060 Offset: 0x738260 VA: 0x180739060 Slot: 41
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button18() { }

	// RVA: 0x7390A0 Offset: 0x7382A0 VA: 0x1807390A0 Slot: 42
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button19() { }

	// RVA: 0x739120 Offset: 0x738320 VA: 0x180739120 Slot: 43
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button20() { }

	// RVA: 0x739160 Offset: 0x738360 VA: 0x180739160 Slot: 44
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button21() { }

	// RVA: 0x7391A0 Offset: 0x7383A0 VA: 0x1807391A0 Slot: 45
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button22() { }

	// RVA: 0x7391E0 Offset: 0x7383E0 VA: 0x1807391E0 Slot: 46
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button23() { }

	// RVA: 0x739220 Offset: 0x738420 VA: 0x180739220 Slot: 47
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button24() { }

	// RVA: 0x739260 Offset: 0x738460 VA: 0x180739260 Slot: 48
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button25() { }

	// RVA: 0x7392A0 Offset: 0x7384A0 VA: 0x1807392A0 Slot: 49
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button26() { }

	// RVA: 0x7392E0 Offset: 0x7384E0 VA: 0x1807392E0 Slot: 50
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button27() { }

	// RVA: 0x739320 Offset: 0x738520 VA: 0x180739320 Slot: 51
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button28() { }

	// RVA: 0x739360 Offset: 0x738560 VA: 0x180739360 Slot: 52
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button29() { }

	// RVA: 0x7393E0 Offset: 0x7385E0 VA: 0x1807393E0 Slot: 53
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button30() { }

	// RVA: 0x739420 Offset: 0x738620 VA: 0x180739420 Slot: 54
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button31() { }

	// RVA: 0x739460 Offset: 0x738660 VA: 0x180739460 Slot: 55
	private IControllerTemplateButton Rewired.ISixDofControllerTemplate.get_button32() { }

	// RVA: 0x739760 Offset: 0x738960 VA: 0x180739760 Slot: 56
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat1() { }

	// RVA: 0x7397A0 Offset: 0x7389A0 VA: 0x1807397A0 Slot: 57
	private IControllerTemplateHat Rewired.ISixDofControllerTemplate.get_hat2() { }

	// RVA: 0x739820 Offset: 0x738A20 VA: 0x180739820 Slot: 58
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle1() { }

	// RVA: 0x739860 Offset: 0x738A60 VA: 0x180739860 Slot: 59
	private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.get_throttle2() { }

	// RVA: 0x7397E0 Offset: 0x7389E0 VA: 0x1807397E0 Slot: 60
	private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.get_stick() { }

	// RVA: 0x712520 Offset: 0x711720 VA: 0x180712520
	public void .ctor(object payload) { }

	// RVA: 0x7398A0 Offset: 0x738AA0 VA: 0x1807398A0
	private static void .cctor() { }
}

// Namespace: Rewired
[EditorBrowsable(1)]
[AddComponentMenu("Rewired/Input Manager")]
public sealed class InputManager : InputManager_Base // TypeDefIndex: 1990
{
	// Fields
	private bool ignoreRecompile; // 0x58

	// Methods

	// RVA: 0x72E000 Offset: 0x72D200 VA: 0x18072E000 Slot: 4
	protected override void OnInitialized() { }

	// RVA: 0x72DFF0 Offset: 0x72D1F0 VA: 0x18072DFF0 Slot: 5
	protected override void OnDeinitialized() { }

	// RVA: 0x72DF40 Offset: 0x72D140 VA: 0x18072DF40 Slot: 6
	protected override void DetectPlatform() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected override void CheckRecompile() { }

	// RVA: 0x72DFA0 Offset: 0x72D1A0 VA: 0x18072DFA0 Slot: 8
	protected override IExternalTools GetExternalTools() { }

	// RVA: 0x72DE90 Offset: 0x72D090 VA: 0x18072DE90
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) { }

	// RVA: 0x72E000 Offset: 0x72D200 VA: 0x18072E000
	private void SubscribeEvents() { }

	// RVA: 0x72E0B0 Offset: 0x72D2B0 VA: 0x18072E0B0
	private void UnsubscribeEvents() { }

	// RVA: 0x72E0A0 Offset: 0x72D2A0 VA: 0x18072E0A0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x72E140 Offset: 0x72D340 VA: 0x18072E140
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class NintendoSwitchInputManager.UserData : IKeyedData<int> // TypeDefIndex: 1991
{
	// Fields
	[SerializeField]
	private int _allowedNpadStyles; // 0x10
	[SerializeField]
	private int _joyConGripStyle; // 0x14
	[SerializeField]
	private bool _adjustIMUsForGripStyle; // 0x18
	[SerializeField]
	private int _handheldActivationMode; // 0x1C
	[SerializeField]
	private bool _assignJoysticksByNpadId; // 0x20
	[SerializeField]
	private bool _useVibrationThread; // 0x21
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo1; // 0x28
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo2; // 0x30
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo3; // 0x38
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo4; // 0x40
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo5; // 0x48
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo6; // 0x50
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo7; // 0x58
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadNo8; // 0x60
	[SerializeField]
	private NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld; // 0x68
	[SerializeField]
	private NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad; // 0x70
	private Dictionary<int, object[]> __delegates; // 0x78

	// Properties
	public int allowedNpadStyles { get; set; }
	public int joyConGripStyle { get; set; }
	public bool adjustIMUsForGripStyle { get; set; }
	public int handheldActivationMode { get; set; }
	public bool assignJoysticksByNpadId { get; set; }
	public bool useVibrationThread { get; set; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo1 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo2 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo3 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo4 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo5 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo6 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo7 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadNo8 { get; }
	private NintendoSwitchInputManager.NpadSettings_Internal npadHandheld { get; }
	public NintendoSwitchInputManager.DebugPadSettings_Internal debugPad { get; }
	private Dictionary<int, object[]> delegates { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_allowedNpadStyles() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_allowedNpadStyles(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_joyConGripStyle() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_joyConGripStyle(int value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_adjustIMUsForGripStyle() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_adjustIMUsForGripStyle(bool value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_handheldActivationMode() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_handheldActivationMode(int value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_assignJoysticksByNpadId() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_assignJoysticksByNpadId(bool value) { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_useVibrationThread() { }

	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	public void set_useVibrationThread(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo1() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo2() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo3() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo4() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo5() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo6() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo7() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadNo8() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	private NintendoSwitchInputManager.NpadSettings_Internal get_npadHandheld() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public NintendoSwitchInputManager.DebugPadSettings_Internal get_debugPad() { }

	// RVA: 0x742B20 Offset: 0x741D20 VA: 0x180742B20
	private Dictionary<int, object[]> get_delegates() { }

	// RVA: -1 Offset: -1 Slot: 4
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<T>(int key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5AD0 Offset: 0xAD4CD0 VA: 0x180AD5AD0
	|-NintendoSwitchInputManager.UserData.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<T>(int key, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5C50 Offset: 0xAD4E50 VA: 0x180AD5C50
	|-NintendoSwitchInputManager.UserData.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7428F0 Offset: 0x741AF0 VA: 0x1807428F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	private int <get_delegates>b__56_0() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void <get_delegates>b__56_1(int x) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private int <get_delegates>b__56_2() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void <get_delegates>b__56_3(int x) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	private bool <get_delegates>b__56_4() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void <get_delegates>b__56_5(bool x) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	private int <get_delegates>b__56_6() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	private void <get_delegates>b__56_7(int x) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	private bool <get_delegates>b__56_8() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	private void <get_delegates>b__56_9(bool x) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	private object <get_delegates>b__56_10() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	private object <get_delegates>b__56_11() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	private object <get_delegates>b__56_12() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	private object <get_delegates>b__56_13() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	private object <get_delegates>b__56_14() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	private object <get_delegates>b__56_15() { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	private object <get_delegates>b__56_16() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	private object <get_delegates>b__56_17() { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	private object <get_delegates>b__56_18() { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	private object <get_delegates>b__56_19() { }

	[CompilerGenerated]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	private bool <get_delegates>b__56_20() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	private void <get_delegates>b__56_21(bool x) { }
}

// Namespace: 
[Serializable]
private sealed class NintendoSwitchInputManager.NpadSettings_Internal : IKeyedData<int> // TypeDefIndex: 1992
{
	// Fields
	[Tooltip("Determines whether this Npad id is allowed to be used by the system.")]
	[SerializeField]
	private bool _isAllowed; // 0x10
	[SerializeField]
	[Tooltip("The Rewired Player Id assigned to this Npad id.")]
	private int _rewiredPlayerId; // 0x14
	[SerializeField]
	[Tooltip("Determines how Joy-Cons should be handled.

Unmodified: Joy-Con assignment mode will be left at the system default.
Dual: Joy-Cons pairs are handled as a single controller.
Single: Joy-Cons are handled as individual controllers.")]
	private int _joyConAssignmentMode; // 0x18
	private Dictionary<int, object[]> __delegates; // 0x20

	// Properties
	private bool isAllowed { get; set; }
	private int rewiredPlayerId { get; set; }
	private int joyConAssignmentMode { get; set; }
	private Dictionary<int, object[]> delegates { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	private bool get_isAllowed() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_isAllowed(bool value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private int get_rewiredPlayerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void set_rewiredPlayerId(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	private int get_joyConAssignmentMode() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_joyConAssignmentMode(int value) { }

	// RVA: 0x72EF40 Offset: 0x72E140 VA: 0x18072EF40
	internal void .ctor(int playerId) { }

	// RVA: 0x72EF70 Offset: 0x72E170 VA: 0x18072EF70
	private Dictionary<int, object[]> get_delegates() { }

	// RVA: -1 Offset: -1 Slot: 4
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<T>(int key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4DB0 Offset: 0xAD3FB0 VA: 0x180AD4DB0
	|-NintendoSwitchInputManager.NpadSettings_Internal.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<T>(int key, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD4F30 Offset: 0xAD4130 VA: 0x180AD4F30
	|-NintendoSwitchInputManager.NpadSettings_Internal.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	private bool <get_delegates>b__15_0() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void <get_delegates>b__15_1(bool x) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private int <get_delegates>b__15_2() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void <get_delegates>b__15_3(int x) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	private int <get_delegates>b__15_4() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void <get_delegates>b__15_5(int x) { }
}

// Namespace: 
[Serializable]
private sealed class NintendoSwitchInputManager.DebugPadSettings_Internal : IKeyedData<int> // TypeDefIndex: 1993
{
	// Fields
	[Tooltip("Determines whether the Debug Pad will be enabled.")]
	[SerializeField]
	private bool _enabled; // 0x10
	[SerializeField]
	[Tooltip("The Rewired Player Id to which the Debug Pad will be assigned.")]
	private int _rewiredPlayerId; // 0x14
	private Dictionary<int, object[]> __delegates; // 0x18

	// Properties
	private int rewiredPlayerId { get; set; }
	private bool enabled { get; set; }
	private Dictionary<int, object[]> delegates { get; }

	// Methods

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private int get_rewiredPlayerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void set_rewiredPlayerId(int value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	private bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_enabled(bool value) { }

	// RVA: 0x728EE0 Offset: 0x7280E0 VA: 0x180728EE0
	internal void .ctor(int playerId) { }

	// RVA: 0x728F10 Offset: 0x728110 VA: 0x180728F10
	private Dictionary<int, object[]> get_delegates() { }

	// RVA: -1 Offset: -1 Slot: 4
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<T>(int key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACC230 Offset: 0xACB430 VA: 0x180ACC230
	|-NintendoSwitchInputManager.DebugPadSettings_Internal.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<T>(int key, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACC3B0 Offset: 0xACB5B0 VA: 0x180ACC3B0
	|-NintendoSwitchInputManager.DebugPadSettings_Internal.Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	private bool <get_delegates>b__11_0() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void <get_delegates>b__11_1(bool x) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private int <get_delegates>b__11_2() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void <get_delegates>b__11_3(int x) { }
}

// Namespace: Rewired.Platforms.Switch
[AddComponentMenu("Rewired/Nintendo Switch Input Manager")]
[RequireComponent(typeof(InputManager))]
public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager // TypeDefIndex: 1994
{
	// Fields
	[SerializeField]
	private NintendoSwitchInputManager.UserData _userData; // 0x20

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	private object Rewired.Utils.Interfaces.IExternalInputManager.Initialize(Platform platform, object configVars) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void Rewired.Utils.Interfaces.IExternalInputManager.Deinitialize() { }

	// RVA: 0x72EEE0 Offset: 0x72E0E0 VA: 0x18072EEE0
	public void .ctor() { }
}

// Namespace: Rewired.Utils
[EditorBrowsable(1)]
public class ExternalTools : IExternalTools // TypeDefIndex: 1995
{
	// Fields
	private static Func<object> _getPlatformInitializerDelegate; // 0x0
	private bool _isEditorPaused; // 0x10
	private Action<bool> _EditorPausedStateChangedEvent; // 0x18
	[CompilerGenerated]
	private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20

	// Properties
	public static Func<object> getPlatformInitializerDelegate { get; set; }
	public bool isEditorPaused { get; }
	public bool UnityInput_IsTouchPressureSupported { get; }

	// Methods

	// RVA: 0x729A50 Offset: 0x728C50 VA: 0x180729A50
	public static Func<object> get_getPlatformInitializerDelegate() { }

	// RVA: 0x729BF0 Offset: 0x728DF0 VA: 0x180729BF0
	public static void set_getPlatformInitializerDelegate(Func<object> value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Destroy() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 4
	public bool get_isEditorPaused() { }

	// RVA: 0x7298E0 Offset: 0x728AE0 VA: 0x1807298E0 Slot: 5
	public void add_EditorPausedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x729A90 Offset: 0x728C90 VA: 0x180729A90 Slot: 6
	public void remove_EditorPausedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x729580 Offset: 0x728780 VA: 0x180729580 Slot: 8
	public object GetPlatformInitializer() { }

	// RVA: 0x729540 Offset: 0x728740 VA: 0x180729540 Slot: 9
	public string GetFocusedEditorWindowTitle() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public bool IsEditorSceneViewFocused() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool LinuxInput_IsJoystickPreconfigured(string name) { }

	[CompilerGenerated]
	// RVA: 0x729990 Offset: 0x728B90 VA: 0x180729990 Slot: 14
	public void add_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x729B40 Offset: 0x728D40 VA: 0x180729B40 Slot: 15
	public void remove_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public int XboxOneInput_GetUserIdForGamepad(uint id) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) { }

	// RVA: 0x7298A0 Offset: 0x728AA0 VA: 0x1807298A0 Slot: 17
	public string XboxOneInput_GetControllerType(ulong xboxControllerId) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 18
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public void XboxOne_Gamepad_UpdatePlugin() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 20
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) { }

	// RVA: 0x7294B0 Offset: 0x7286B0 VA: 0x1807294B0 Slot: 22
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids) { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380 Slot: 23
	public int GetAndroidAPILevel() { }

	// RVA: 0x729870 Offset: 0x728A70 VA: 0x180729870 Slot: 24
	public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize) { }

	// RVA: 0x7295B0 Offset: 0x7287B0 VA: 0x1807295B0 Slot: 25
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic) { }

	// RVA: 0x729710 Offset: 0x728910 VA: 0x180729710 Slot: 26
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) { }

	// RVA: 0x729A40 Offset: 0x728C40 VA: 0x180729A40 Slot: 27
	public bool get_UnityInput_IsTouchPressureSupported() { }

	// RVA: 0x7295A0 Offset: 0x7287A0 VA: 0x1807295A0 Slot: 28
	public float UnityInput_GetTouchPressure(ref Touch touch) { }

	// RVA: 0x729590 Offset: 0x728790 VA: 0x180729590 Slot: 29
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) { }

	// RVA: 0x729310 Offset: 0x728510 VA: 0x180729310 Slot: 30
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) { }

	// RVA: 0x729420 Offset: 0x728620 VA: 0x180729420 Slot: 31
	public Type[] GetControllerTemplateTypes() { }

	// RVA: 0x729390 Offset: 0x728590 VA: 0x180729390 Slot: 32
	public Type[] GetControllerTemplateInterfaceTypes() { }
}

// Namespace: 
public class UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo // TypeDefIndex: 1996
{
	// Fields
	public int id; // 0x10
	public bool hasKeyboard; // 0x14
	public bool hasMouse; // 0x15
	public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks; // 0x18

	// Properties
	public int joystickCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450
	public int get_joystickCount() { }

	// RVA: 0x72F3E0 Offset: 0x72E5E0 VA: 0x18072F3E0
	public int IndexOfJoystick(int joystickId) { }

	// RVA: 0x72F380 Offset: 0x72E580 VA: 0x18072F380
	public bool ContainsJoystick(int joystickId) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo // TypeDefIndex: 1997
{
	// Fields
	public Guid instanceGuid; // 0x10
	public string hardwareIdentifier; // 0x20
	public int id; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo // TypeDefIndex: 1998
{
	// Fields
	public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players; // 0x10

	// Properties
	public int playerCount { get; }

	// Methods

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230
	public int get_playerCount() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x727120 Offset: 0x726320 VA: 0x180727120
	public void .ctor(int playerCount) { }

	// RVA: 0x7270B0 Offset: 0x7262B0 VA: 0x1807270B0
	public int IndexOfPlayer(int playerId) { }

	// RVA: 0x727050 Offset: 0x726250 VA: 0x180727050
	public bool ContainsPlayer(int playerId) { }
}

// Namespace: 
private class UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo // TypeDefIndex: 1999
{
	// Fields
	public readonly Joystick joystick; // 0x10
	public readonly int oldJoystickId; // 0x18

	// Methods

	// RVA: 0x72E150 Offset: 0x72D350 VA: 0x18072E150
	public void .ctor(Joystick joystick, int oldJoystickId) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserDataStore_PlayerPrefs.<>c__DisplayClass78_0 // TypeDefIndex: 2000
{
	// Fields
	public Joystick joystick; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A270 Offset: 0x739470 VA: 0x18073A270
	internal bool <LoadJoystickAssignmentsNow>b__0(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserDataStore_PlayerPrefs.<>c__DisplayClass78_1 // TypeDefIndex: 2001
{
	// Fields
	public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A290 Offset: 0x739490 VA: 0x18073A290
	internal bool <LoadJoystickAssignmentsNow>b__1(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserDataStore_PlayerPrefs.<>c__DisplayClass78_2 // TypeDefIndex: 2002
{
	// Fields
	public Joystick match; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A270 Offset: 0x739470 VA: 0x18073A270
	internal bool <LoadJoystickAssignmentsNow>b__2(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserDataStore_PlayerPrefs.<LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2003
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UserDataStore_PlayerPrefs <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x73A100 Offset: 0x739300 VA: 0x18073A100 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x73A230 Offset: 0x739430 VA: 0x18073A230 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.Data
public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 2004
{
	// Fields
	private const string thisScriptName = "UserDataStore_PlayerPrefs";
	private const string logPrefix = "Rewired: ";
	private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";
	private const int controllerMapPPKeyVersion_original = 0;
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;
	private const int controllerMapPPKeyVersion = 2;
	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	[SerializeField]
	private bool isEnabled; // 0x20
	[Tooltip("Should saved data be loaded on start?")]
	[SerializeField]
	private bool loadDataOnStart; // 0x21
	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	[SerializeField]
	private bool loadJoystickAssignments; // 0x22
	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	[SerializeField]
	private bool loadKeyboardAssignments; // 0x23
	[SerializeField]
	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	private bool loadMouseAssignments; // 0x24
	[SerializeField]
	[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
	private string playerPrefsKeyPrefix; // 0x28
	private bool allowImpreciseJoystickAssignmentMatching; // 0x30
	private bool deferredJoystickAssignmentLoadPending; // 0x31
	private bool wasJoystickEverDetected; // 0x32
	private List<int> __allActionIds; // 0x38
	private string __allActionIdsString; // 0x40

	// Properties
	public bool IsEnabled { get; set; }
	public bool LoadDataOnStart { get; set; }
	public bool LoadJoystickAssignments { get; set; }
	public bool LoadKeyboardAssignments { get; set; }
	public bool LoadMouseAssignments { get; set; }
	public string PlayerPrefsKeyPrefix { get; set; }
	private string playerPrefsKey_controllerAssignments { get; }
	private bool loadControllerAssignments { get; }
	private List<int> allActionIds { get; }
	private string allActionIdsString { get; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsEnabled() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IsEnabled(bool value) { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_LoadDataOnStart() { }

	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	public void set_LoadDataOnStart(bool value) { }

	// RVA: 0x742460 Offset: 0x741660 VA: 0x180742460
	public bool get_LoadJoystickAssignments() { }

	// RVA: 0x7428C0 Offset: 0x741AC0 VA: 0x1807428C0
	public void set_LoadJoystickAssignments(bool value) { }

	// RVA: 0x742470 Offset: 0x741670 VA: 0x180742470
	public bool get_LoadKeyboardAssignments() { }

	// RVA: 0x7428D0 Offset: 0x741AD0 VA: 0x1807428D0
	public void set_LoadKeyboardAssignments(bool value) { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_LoadMouseAssignments() { }

	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	public void set_LoadMouseAssignments(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_PlayerPrefsKeyPrefix() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_PlayerPrefsKeyPrefix(string value) { }

	// RVA: 0x742870 Offset: 0x741A70 VA: 0x180742870
	private string get_playerPrefsKey_controllerAssignments() { }

	// RVA: 0x742850 Offset: 0x741A50 VA: 0x180742850
	private bool get_loadControllerAssignments() { }

	// RVA: 0x7425B0 Offset: 0x7417B0 VA: 0x1807425B0
	private List<int> get_allActionIds() { }

	// RVA: 0x742480 Offset: 0x741680 VA: 0x180742480
	private string get_allActionIdsString() { }

	// RVA: 0x7420F0 Offset: 0x7412F0 VA: 0x1807420F0 Slot: 21
	public override void Save() { }

	// RVA: 0x740E50 Offset: 0x740050 VA: 0x180740E50 Slot: 22
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x740F20 Offset: 0x740120 VA: 0x180740F20 Slot: 23
	public override void SaveControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x742010 Offset: 0x741210 VA: 0x180742010 Slot: 24
	public override void SavePlayerData(int playerId) { }

	// RVA: 0x741890 Offset: 0x740A90 VA: 0x180741890 Slot: 25
	public override void SaveInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x7401D0 Offset: 0x73F3D0 VA: 0x1807401D0 Slot: 16
	public override void Load() { }

	// RVA: 0x73DAE0 Offset: 0x73CCE0 VA: 0x18073DAE0 Slot: 17
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x73DA40 Offset: 0x73CC40 VA: 0x18073DA40 Slot: 18
	public override void LoadControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x7400F0 Offset: 0x73F2F0 VA: 0x1807400F0 Slot: 19
	public override void LoadPlayerData(int playerId) { }

	// RVA: 0x73E460 Offset: 0x73D660 VA: 0x18073E460 Slot: 20
	public override void LoadInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x740370 Offset: 0x73F570 VA: 0x180740370 Slot: 28
	protected override void OnInitialize() { }

	// RVA: 0x740250 Offset: 0x73F450 VA: 0x180740250 Slot: 29
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x740340 Offset: 0x73F540 VA: 0x180740340 Slot: 32
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x740320 Offset: 0x73F520 VA: 0x180740320 Slot: 30
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x741380 Offset: 0x740580 VA: 0x180741380 Slot: 26
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x73DBB0 Offset: 0x73CDB0 VA: 0x18073DBB0 Slot: 27
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x73D5F0 Offset: 0x73C7F0 VA: 0x18073D5F0
	private int LoadAll() { }

	// RVA: 0x740070 Offset: 0x73F270 VA: 0x180740070
	private int LoadPlayerDataNow(int playerId) { }

	// RVA: 0x73FDC0 Offset: 0x73EFC0 VA: 0x18073FDC0
	private int LoadPlayerDataNow(Player player) { }

	// RVA: 0x73D390 Offset: 0x73C590 VA: 0x18073D390
	private int LoadAllJoystickCalibrationData() { }

	// RVA: 0x73F740 Offset: 0x73E940 VA: 0x18073F740
	private int LoadJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x73F640 Offset: 0x73E840 VA: 0x18073F640
	private int LoadJoystickCalibrationData(int joystickId) { }

	// RVA: 0x73F7E0 Offset: 0x73E9E0 VA: 0x18073F7E0
	private int LoadJoystickData(int joystickId) { }

	// RVA: 0x73D9A0 Offset: 0x73CBA0 VA: 0x18073D9A0
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x73DA20 Offset: 0x73CC20 VA: 0x18073DA20
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x73DF40 Offset: 0x73D140 VA: 0x18073DF40
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x73DC80 Offset: 0x73CE80 VA: 0x18073DC80
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x73E5A0 Offset: 0x73D7A0 VA: 0x18073E5A0
	private int LoadInputBehaviors(int playerId) { }

	// RVA: 0x73E270 Offset: 0x73D470 VA: 0x18073E270
	private int LoadInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x73E350 Offset: 0x73D550 VA: 0x18073E350
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x73D930 Offset: 0x73CB30 VA: 0x18073D930
	private bool LoadControllerAssignmentsNow() { }

	// RVA: 0x73FA30 Offset: 0x73EC30 VA: 0x18073FA30
	private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x73E830 Offset: 0x73DA30 VA: 0x18073E830
	private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x73D7F0 Offset: 0x73C9F0 VA: 0x18073D7F0
	private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }

	[IteratorStateMachine(typeof(UserDataStore_PlayerPrefs.<LoadJoystickAssignmentsDeferred>d__80))]
	// RVA: 0x73E7D0 Offset: 0x73D9D0 VA: 0x18073E7D0
	private IEnumerator LoadJoystickAssignmentsDeferred() { }

	// RVA: 0x7406D0 Offset: 0x73F8D0 VA: 0x1807406D0
	private void SaveAll() { }

	// RVA: 0x741F90 Offset: 0x741190 VA: 0x180741F90
	private void SavePlayerDataNow(int playerId) { }

	// RVA: 0x741E30 Offset: 0x741030 VA: 0x180741E30
	private void SavePlayerDataNow(Player player) { }

	// RVA: 0x7404B0 Offset: 0x73F6B0 VA: 0x1807404B0
	private void SaveAllJoystickCalibrationData() { }

	// RVA: 0x741AC0 Offset: 0x740CC0 VA: 0x180741AC0
	private void SaveJoystickCalibrationData(int joystickId) { }

	// RVA: 0x741B80 Offset: 0x740D80 VA: 0x180741B80
	private void SaveJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x741C00 Offset: 0x740E00 VA: 0x180741C00
	private void SaveJoystickData(int joystickId) { }

	// RVA: 0x740DC0 Offset: 0x73FFC0 VA: 0x180740DC0
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x740E20 Offset: 0x740020 VA: 0x180740E20
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x741550 Offset: 0x740750 VA: 0x180741550
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x741420 Offset: 0x740620 VA: 0x180741420
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x740FD0 Offset: 0x7401D0 VA: 0x180740FD0
	private void SaveControllerMap(Player player, ControllerMap controllerMap) { }

	// RVA: 0x741A00 Offset: 0x740C00 VA: 0x180741A00
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x741790 Offset: 0x740990 VA: 0x180741790
	private void SaveInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x741740 Offset: 0x740940 VA: 0x180741740
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x7408D0 Offset: 0x73FAD0 VA: 0x1807408D0
	private bool SaveControllerAssignments() { }

	// RVA: 0x73BF90 Offset: 0x73B190 VA: 0x18073BF90
	private bool ControllerAssignmentSaveDataExists() { }

	// RVA: 0x73C1F0 Offset: 0x73B3F0 VA: 0x18073C1F0
	private string GetBasePlayerPrefsKey(Player player) { }

	// RVA: 0x73C930 Offset: 0x73BB30 VA: 0x18073C930
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x73C260 Offset: 0x73B460 VA: 0x18073C260
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x73C520 Offset: 0x73B720 VA: 0x18073C520
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x73D1D0 Offset: 0x73C3D0 VA: 0x18073D1D0
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) { }

	// RVA: 0x73D070 Offset: 0x73C270 VA: 0x18073D070
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) { }

	// RVA: 0x73CB80 Offset: 0x73BD80 VA: 0x18073CB80
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x73C370 Offset: 0x73B570 VA: 0x18073C370
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x73D310 Offset: 0x73C510 VA: 0x18073D310
	private string GetJoystickCalibrationMapXml(Joystick joystick) { }

	// RVA: 0x73D140 Offset: 0x73C340 VA: 0x18073D140
	private string GetInputBehaviorXml(Player player, int id) { }

	// RVA: 0x73BA20 Offset: 0x73AC20 VA: 0x18073BA20
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) { }

	// RVA: 0x73C060 Offset: 0x73B260 VA: 0x18073C060
	private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }

	// RVA: 0x742170 Offset: 0x741370 VA: 0x180742170
	private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches) { }

	// RVA: 0x73CC40 Offset: 0x73BE40 VA: 0x18073CC40
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) { }

	// RVA: 0x740420 Offset: 0x73F620 VA: 0x180740420
	private void RefreshLayoutManager(int playerId) { }

	// RVA: 0x73CA40 Offset: 0x73BC40 VA: 0x18073CA40
	private static Type GetControllerMapType(ControllerType controllerType) { }

	// RVA: 0x742410 Offset: 0x741610 VA: 0x180742410
	public void .ctor() { }
}

// Namespace: Rewired.Internal
public static class ControllerTemplateFactory // TypeDefIndex: 2005
{
	// Fields
	private static readonly Type[] _defaultTemplateTypes; // 0x0
	private static readonly Type[] _defaultTemplateInterfaceTypes; // 0x8

	// Properties
	public static Type[] templateTypes { get; }
	public static Type[] templateInterfaceTypes { get; }

	// Methods

	// RVA: 0x728E90 Offset: 0x728090 VA: 0x180728E90
	public static Type[] get_templateTypes() { }

	// RVA: 0x728E40 Offset: 0x728040 VA: 0x180728E40
	public static Type[] get_templateInterfaceTypes() { }

	// RVA: 0x728650 Offset: 0x727850 VA: 0x180728650
	public static IControllerTemplate Create(Guid typeGuid, object payload) { }

	// RVA: 0x728950 Offset: 0x727B50 VA: 0x180728950
	private static void .cctor() { }
}

// Namespace: Rewired.Integration.UnityUI
public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 2006
{
	// Fields
	[CompilerGenerated]
	private int <playerId>k__BackingField; // 0x180
	[CompilerGenerated]
	private int <inputSourceIndex>k__BackingField; // 0x184
	[CompilerGenerated]
	private IMouseInputSource <mouseSource>k__BackingField; // 0x188
	[CompilerGenerated]
	private ITouchInputSource <touchSource>k__BackingField; // 0x190
	[CompilerGenerated]
	private PointerEventType <sourceType>k__BackingField; // 0x198
	[CompilerGenerated]
	private int <buttonIndex>k__BackingField; // 0x19C

	// Properties
	public int playerId { get; set; }
	public int inputSourceIndex { get; set; }
	public IMouseInputSource mouseSource { get; set; }
	public ITouchInputSource touchSource { get; set; }
	public PointerEventType sourceType { get; set; }
	public int buttonIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x72F740 Offset: 0x72E940 VA: 0x18072F740
	public int get_playerId() { }

	[CompilerGenerated]
	// RVA: 0x72F7A0 Offset: 0x72E9A0 VA: 0x18072F7A0
	public void set_playerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x72F720 Offset: 0x72E920 VA: 0x18072F720
	public int get_inputSourceIndex() { }

	[CompilerGenerated]
	// RVA: 0x72F780 Offset: 0x72E980 VA: 0x18072F780
	public void set_inputSourceIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x72F730 Offset: 0x72E930 VA: 0x18072F730
	public IMouseInputSource get_mouseSource() { }

	[CompilerGenerated]
	// RVA: 0x72F790 Offset: 0x72E990 VA: 0x18072F790
	public void set_mouseSource(IMouseInputSource value) { }

	[CompilerGenerated]
	// RVA: 0x72F760 Offset: 0x72E960 VA: 0x18072F760
	public ITouchInputSource get_touchSource() { }

	[CompilerGenerated]
	// RVA: 0x72F7C0 Offset: 0x72E9C0 VA: 0x18072F7C0
	public void set_touchSource(ITouchInputSource value) { }

	[CompilerGenerated]
	// RVA: 0x72F750 Offset: 0x72E950 VA: 0x18072F750
	public PointerEventType get_sourceType() { }

	[CompilerGenerated]
	// RVA: 0x72F7B0 Offset: 0x72E9B0 VA: 0x18072F7B0
	public void set_sourceType(PointerEventType value) { }

	[CompilerGenerated]
	// RVA: 0x72F710 Offset: 0x72E910 VA: 0x18072F710
	public int get_buttonIndex() { }

	[CompilerGenerated]
	// RVA: 0x72F770 Offset: 0x72E970 VA: 0x18072F770
	public void set_buttonIndex(int value) { }

	// RVA: 0x72F6E0 Offset: 0x72E8E0 VA: 0x18072F6E0
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x72F470 Offset: 0x72E670 VA: 0x18072F470 Slot: 3
	public override string ToString() { }
}

// Namespace: Rewired.Integration.UnityUI
[AddComponentMenu("Rewired/Rewired Event System")]
public class RewiredEventSystem : EventSystem // TypeDefIndex: 2007
{
	// Fields
	[SerializeField]
	[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
	private bool _alwaysUpdate; // 0x60

	// Properties
	public bool alwaysUpdate { get; set; }

	// Methods

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_alwaysUpdate() { }

	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	public void set_alwaysUpdate(bool value) { }

	// RVA: 0x72FAD0 Offset: 0x72ECD0 VA: 0x18072FAD0 Slot: 18
	protected override void Update() { }

	// RVA: 0x72FBF0 Offset: 0x72EDF0 VA: 0x18072FBF0
	public void .ctor() { }
}

// Namespace: 
protected class RewiredPointerInputModule.MouseState // TypeDefIndex: 2008
{
	// Fields
	private List<RewiredPointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x72EB20 Offset: 0x72DD20 VA: 0x18072EB20
	public bool AnyPressesThisFrame() { }

	// RVA: 0x72EBD0 Offset: 0x72DDD0 VA: 0x18072EBD0
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x72EC80 Offset: 0x72DE80 VA: 0x18072EC80
	public RewiredPointerInputModule.ButtonState GetButtonState(int button) { }

	// RVA: 0x72EE20 Offset: 0x72E020 VA: 0x18072EE20
	public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data) { }

	// RVA: 0x72EE70 Offset: 0x72E070 VA: 0x18072EE70
	public void .ctor() { }
}

// Namespace: 
public class RewiredPointerInputModule.MouseButtonEventData // TypeDefIndex: 2009
{
	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PlayerPointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x72EAE0 Offset: 0x72DCE0 VA: 0x18072EAE0
	public bool PressedThisFrame() { }

	// RVA: 0x72EB00 Offset: 0x72DD00 VA: 0x18072EB00
	public bool ReleasedThisFrame() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
protected class RewiredPointerInputModule.ButtonState // TypeDefIndex: 2010
{
	// Fields
	private int m_Button; // 0x10
	private RewiredPointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public RewiredPointerInputModule.MouseButtonEventData eventData { get; set; }
	public int button { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public RewiredPointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_eventData(RewiredPointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_button() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_button(int value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class RewiredPointerInputModule.UnityInputSource : IMouseInputSource, ITouchInputSource // TypeDefIndex: 2011
{
	// Fields
	private Vector2 m_MousePosition; // 0x10
	private Vector2 m_MousePositionPrev; // 0x18
	private int m_LastUpdatedFrame; // 0x20

	// Properties
	private int Rewired.UI.IMouseInputSource.playerId { get; }
	private int Rewired.UI.ITouchInputSource.playerId { get; }
	private bool Rewired.UI.IMouseInputSource.enabled { get; }
	private bool Rewired.UI.IMouseInputSource.locked { get; }
	private int Rewired.UI.IMouseInputSource.buttonCount { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPosition { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta { get; }
	private Vector2 Rewired.UI.IMouseInputSource.wheelDelta { get; }
	private bool Rewired.UI.ITouchInputSource.touchSupported { get; }
	private int Rewired.UI.ITouchInputSource.touchCount { get; }

	// Methods

	// RVA: 0x73A530 Offset: 0x739730 VA: 0x18073A530 Slot: 4
	private int Rewired.UI.IMouseInputSource.get_playerId() { }

	// RVA: 0x73A530 Offset: 0x739730 VA: 0x18073A530 Slot: 14
	private int Rewired.UI.ITouchInputSource.get_playerId() { }

	// RVA: 0x73A470 Offset: 0x739670 VA: 0x18073A470 Slot: 5
	private bool Rewired.UI.IMouseInputSource.get_enabled() { }

	// RVA: 0x73A4D0 Offset: 0x7396D0 VA: 0x18073A4D0 Slot: 6
	private bool Rewired.UI.IMouseInputSource.get_locked() { }

	// RVA: 0x73A410 Offset: 0x739610 VA: 0x18073A410 Slot: 7
	private int Rewired.UI.IMouseInputSource.get_buttonCount() { }

	// RVA: 0x73A2C0 Offset: 0x7394C0 VA: 0x18073A2C0 Slot: 8
	private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	// RVA: 0x73A330 Offset: 0x739530 VA: 0x18073A330 Slot: 9
	private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	// RVA: 0x73A3A0 Offset: 0x7395A0 VA: 0x18073A3A0 Slot: 10
	private bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	// RVA: 0x73A600 Offset: 0x739800 VA: 0x18073A600 Slot: 11
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	// RVA: 0x73A590 Offset: 0x739790 VA: 0x18073A590 Slot: 12
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	// RVA: 0x73A680 Offset: 0x739880 VA: 0x18073A680 Slot: 13
	private Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	// RVA: 0x73A7F0 Offset: 0x7399F0 VA: 0x18073A7F0 Slot: 15
	private bool Rewired.UI.ITouchInputSource.get_touchSupported() { }

	// RVA: 0x73A790 Offset: 0x739990 VA: 0x18073A790 Slot: 16
	private int Rewired.UI.ITouchInputSource.get_touchCount() { }

	// RVA: 0x73A6E0 Offset: 0x7398E0 VA: 0x18073A6E0 Slot: 17
	private Touch Rewired.UI.ITouchInputSource.GetTouch(int index) { }

	// RVA: 0x73A850 Offset: 0x739A50 VA: 0x18073A850
	private void TryUpdate() { }

	// RVA: 0x73A8B0 Offset: 0x739AB0 VA: 0x18073A8B0
	public void .ctor() { }
}

// Namespace: Rewired.Integration.UnityUI
public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 2012
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	private const int customButtonsStartingId = -2147483520;
	private const int customButtonsMaxCount = 128;
	private const int customButtonsLastId = -2147483392;
	private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x58
	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x60
	private ITouchInputSource m_UserDefaultTouchInputSource; // 0x68
	private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource; // 0x70
	private readonly RewiredPointerInputModule.MouseState m_MouseState; // 0x78

	// Properties
	private RewiredPointerInputModule.UnityInputSource defaultInputSource { get; }
	private IMouseInputSource defaultMouseInputSource { get; }
	protected ITouchInputSource defaultTouchInputSource { get; }
	protected virtual bool isMouseSupported { get; }

	// Methods

	// RVA: 0x732B40 Offset: 0x731D40 VA: 0x180732B40
	private RewiredPointerInputModule.UnityInputSource get_defaultInputSource() { }

	// RVA: 0x732B40 Offset: 0x731D40 VA: 0x180732B40
	private IMouseInputSource get_defaultMouseInputSource() { }

	// RVA: 0x732B40 Offset: 0x731D40 VA: 0x180732B40
	protected ITouchInputSource get_defaultTouchInputSource() { }

	// RVA: 0x731BB0 Offset: 0x730DB0 VA: 0x180731BB0
	protected bool IsDefaultMouse(IMouseInputSource mouse) { }

	// RVA: 0x730800 Offset: 0x72FA00 VA: 0x180730800
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) { }

	// RVA: 0x732260 Offset: 0x731460 VA: 0x180732260
	public void RemoveMouseInputSource(IMouseInputSource source) { }

	// RVA: 0x72FC40 Offset: 0x72EE40 VA: 0x18072FC40
	public void AddMouseInputSource(IMouseInputSource source) { }

	// RVA: 0x7306B0 Offset: 0x72F8B0 VA: 0x1807306B0
	public int GetMouseInputSourceCount(int playerId) { }

	// RVA: 0x731850 Offset: 0x730A50 VA: 0x180731850
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) { }

	// RVA: 0x7323D0 Offset: 0x7315D0 VA: 0x1807323D0
	public void RemoveTouchInputSource(ITouchInputSource source) { }

	// RVA: 0x72FD70 Offset: 0x72EF70 VA: 0x18072FD70
	public void AddTouchInputSource(ITouchInputSource source) { }

	// RVA: 0x731820 Offset: 0x730A20 VA: 0x180731820
	public int GetTouchInputSourceCount(int playerId) { }

	// RVA: 0x72FE30 Offset: 0x72F030 VA: 0x18072FE30
	protected void ClearMouseInputSources() { }

	// RVA: 0x732BB0 Offset: 0x731DB0 VA: 0x180732BB0 Slot: 27
	protected virtual bool get_isMouseSupported() { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract bool IsDefaultPlayer(int playerId);

	// RVA: 0x7312F0 Offset: 0x7304F0 VA: 0x1807312F0
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) { }

	// RVA: 0x7302A0 Offset: 0x72F4A0 VA: 0x1807302A0
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) { }

	// RVA: 0x732310 Offset: 0x731510 VA: 0x180732310
	protected void RemovePointerData(PlayerPointerEventData data) { }

	// RVA: 0x7318E0 Offset: 0x730AE0 VA: 0x1807318E0
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) { }

	// RVA: 0x7309C0 Offset: 0x72FBC0 VA: 0x1807309C0 Slot: 29
	protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex) { }

	// RVA: 0x7304B0 Offset: 0x72F6B0 VA: 0x1807304B0
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) { }

	// RVA: 0x732440 Offset: 0x731640 VA: 0x180732440
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x732140 Offset: 0x731340 VA: 0x180732140 Slot: 30
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent) { }

	// RVA: 0x731E30 Offset: 0x731030 VA: 0x180731E30 Slot: 31
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent) { }

	// RVA: 0x731C30 Offset: 0x730E30 VA: 0x180731C30 Slot: 20
	public override bool IsPointerOverGameObject(int pointerTypeId) { }

	// RVA: 0x72FE90 Offset: 0x72F090 VA: 0x18072FE90
	protected void ClearSelection() { }

	// RVA: 0x732560 Offset: 0x731760 VA: 0x180732560 Slot: 3
	public override string ToString() { }

	// RVA: 0x7303D0 Offset: 0x72F5D0 VA: 0x1807303D0
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x7301D0 Offset: 0x72F3D0 VA: 0x1807301D0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x732490 Offset: 0x731690 VA: 0x180732490
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) { }

	// RVA: 0x732A10 Offset: 0x731C10 VA: 0x180732A10
	protected void .ctor() { }
}

// Namespace: Rewired.Integration.UnityUI
public enum PointerEventType // TypeDefIndex: 2013
{
	// Fields
	public int value__; // 0x0
	public const PointerEventType Mouse = 0;
	public const PointerEventType Touch = 1;
}

// Namespace: 
[Serializable]
public class RewiredStandaloneInputModule.PlayerSetting // TypeDefIndex: 2014
{
	// Fields
	public int playerId; // 0x10
	public List<PlayerMouse> playerMice; // 0x18

	// Methods

	// RVA: 0x72F830 Offset: 0x72EA30 VA: 0x18072F830
	public void .ctor() { }

	// RVA: 0x72F8A0 Offset: 0x72EAA0 VA: 0x18072F8A0
	private void .ctor(RewiredStandaloneInputModule.PlayerSetting other) { }

	// RVA: 0x72F7D0 Offset: 0x72E9D0 VA: 0x18072F7D0
	public RewiredStandaloneInputModule.PlayerSetting Clone() { }
}

// Namespace: Rewired.Integration.UnityUI
[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 2015
{
	// Fields
	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";
	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";
	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";
	private const string DEFAULT_ACTION_CANCEL = "UICancel";
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
	[SerializeField]
	private InputManager_Base rewiredInputManager; // 0x80
	[SerializeField]
	[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
	private bool useAllRewiredGamePlayers; // 0x88
	[Tooltip("Allow the Rewired System Player to control the UI.")]
	[SerializeField]
	private bool useRewiredSystemPlayer; // 0x89
	[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
	[SerializeField]
	private int[] rewiredPlayerIds; // 0x90
	[SerializeField]
	[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
	private bool usePlayingPlayersOnly; // 0x98
	[SerializeField]
	[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
	private List<PlayerMouse> playerMice; // 0xA0
	[SerializeField]
	[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
	private bool moveOneElementPerAxisPress; // 0xA8
	[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
	[SerializeField]
	private bool setActionsById; // 0xA9
	[SerializeField]
	[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
	private int horizontalActionId; // 0xAC
	[SerializeField]
	[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
	private int verticalActionId; // 0xB0
	[SerializeField]
	[Tooltip("Id of the Action used to submit.")]
	private int submitActionId; // 0xB4
	[SerializeField]
	[Tooltip("Id of the Action used to cancel.")]
	private int cancelActionId; // 0xB8
	[SerializeField]
	[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
	private string m_HorizontalAxis; // 0xC0
	[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
	[SerializeField]
	private string m_VerticalAxis; // 0xC8
	[SerializeField]
	[Tooltip("Name of the action used to submit.")]
	private string m_SubmitButton; // 0xD0
	[Tooltip("Name of the action used to cancel.")]
	[SerializeField]
	private string m_CancelButton; // 0xD8
	[SerializeField]
	[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
	private float m_InputActionsPerSecond; // 0xE0
	[SerializeField]
	[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
	private float m_RepeatDelay; // 0xE4
	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements.")]
	private bool m_allowMouseInput; // 0xE8
	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
	private bool m_allowMouseInputIfTouchSupported; // 0xE9
	[Tooltip("Allows touch input to be used to select elements.")]
	[SerializeField]
	private bool m_allowTouchInput; // 0xEA
	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
	private bool m_deselectIfBackgroundClicked; // 0xEB
	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
	private bool m_deselectBeforeSelecting; // 0xEC
	[SerializeField]
	[Tooltip("Forces the module to always be active.")]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	private bool m_ForceModuleActive; // 0xED
	private int[] playerIds; // 0xF0
	private bool recompiling; // 0xF8
	private bool isTouchSupported; // 0xF9
	private double m_PrevActionTime; // 0x100
	private Vector2 m_LastMoveVector; // 0x108
	private int m_ConsecutiveMoveCount; // 0x110
	private bool m_HasFocus; // 0x114

	// Properties
	public InputManager_Base RewiredInputManager { get; set; }
	public bool UseAllRewiredGamePlayers { get; set; }
	public bool UseRewiredSystemPlayer { get; set; }
	public int[] RewiredPlayerIds { get; set; }
	public bool UsePlayingPlayersOnly { get; set; }
	public List<PlayerMouse> PlayerMice { get; set; }
	public bool MoveOneElementPerAxisPress { get; set; }
	public bool allowMouseInput { get; set; }
	public bool allowMouseInputIfTouchSupported { get; set; }
	public bool allowTouchInput { get; set; }
	public bool deselectIfBackgroundClicked { get; set; }
	private bool deselectBeforeSelecting { get; set; }
	public bool SetActionsById { get; set; }
	public int HorizontalActionId { get; set; }
	public int VerticalActionId { get; set; }
	public int SubmitActionId { get; set; }
	public int CancelActionId { get; set; }
	protected override bool isMouseSupported { get; }
	private bool isTouchAllowed { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public InputManager_Base get_RewiredInputManager() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_RewiredInputManager(InputManager_Base value) { }

	// RVA: 0x5C3440 Offset: 0x5C2640 VA: 0x1805C3440
	public bool get_UseAllRewiredGamePlayers() { }

	// RVA: 0x738890 Offset: 0x737A90 VA: 0x180738890
	public void set_UseAllRewiredGamePlayers(bool value) { }

	// RVA: 0x5C3410 Offset: 0x5C2610 VA: 0x1805C3410
	public bool get_UseRewiredSystemPlayer() { }

	// RVA: 0x7388C0 Offset: 0x737AC0 VA: 0x1807388C0
	public void set_UseRewiredSystemPlayer(bool value) { }

	// RVA: 0x7380D0 Offset: 0x7372D0 VA: 0x1807380D0
	public int[] get_RewiredPlayerIds() { }

	// RVA: 0x738680 Offset: 0x737880 VA: 0x180738680
	public void set_RewiredPlayerIds(int[] value) { }

	// RVA: 0x738170 Offset: 0x737370 VA: 0x180738170
	public bool get_UsePlayingPlayersOnly() { }

	// RVA: 0x7388B0 Offset: 0x737AB0 VA: 0x1807388B0
	public void set_UsePlayingPlayersOnly(bool value) { }

	// RVA: 0x738060 Offset: 0x737260 VA: 0x180738060
	public List<PlayerMouse> get_PlayerMice() { }

	// RVA: 0x7385E0 Offset: 0x7377E0 VA: 0x1807385E0
	public void set_PlayerMice(List<PlayerMouse> value) { }

	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_MoveOneElementPerAxisPress() { }

	// RVA: 0x7385D0 Offset: 0x7377D0 VA: 0x1807385D0
	public void set_MoveOneElementPerAxisPress(bool value) { }

	// RVA: 0x7381B0 Offset: 0x7373B0 VA: 0x1807381B0
	public bool get_allowMouseInput() { }

	// RVA: 0x738A40 Offset: 0x737C40 VA: 0x180738A40
	public void set_allowMouseInput(bool value) { }

	// RVA: 0x7381A0 Offset: 0x7373A0 VA: 0x1807381A0
	public bool get_allowMouseInputIfTouchSupported() { }

	// RVA: 0x738A30 Offset: 0x737C30 VA: 0x180738A30
	public void set_allowMouseInputIfTouchSupported(bool value) { }

	// RVA: 0x7381C0 Offset: 0x7373C0 VA: 0x1807381C0
	public bool get_allowTouchInput() { }

	// RVA: 0x738A50 Offset: 0x737C50 VA: 0x180738A50
	public void set_allowTouchInput(bool value) { }

	// RVA: 0x7381E0 Offset: 0x7373E0 VA: 0x1807381E0
	public bool get_deselectIfBackgroundClicked() { }

	// RVA: 0x738B60 Offset: 0x737D60 VA: 0x180738B60
	public void set_deselectIfBackgroundClicked(bool value) { }

	// RVA: 0x7381D0 Offset: 0x7373D0 VA: 0x1807381D0
	private bool get_deselectBeforeSelecting() { }

	// RVA: 0x738B50 Offset: 0x737D50 VA: 0x180738B50
	private void set_deselectBeforeSelecting(bool value) { }

	// RVA: 0x738150 Offset: 0x737350 VA: 0x180738150
	public bool get_SetActionsById() { }

	// RVA: 0x738730 Offset: 0x737930 VA: 0x180738730
	public void set_SetActionsById(bool value) { }

	// RVA: 0x738040 Offset: 0x737240 VA: 0x180738040
	public int get_HorizontalActionId() { }

	// RVA: 0x738490 Offset: 0x737690 VA: 0x180738490
	public void set_HorizontalActionId(int value) { }

	// RVA: 0x738180 Offset: 0x737380 VA: 0x180738180
	public int get_VerticalActionId() { }

	// RVA: 0x7388E0 Offset: 0x737AE0 VA: 0x1807388E0
	public void set_VerticalActionId(int value) { }

	// RVA: 0x738160 Offset: 0x737360 VA: 0x180738160
	public int get_SubmitActionId() { }

	// RVA: 0x738750 Offset: 0x737950 VA: 0x180738750
	public void set_SubmitActionId(int value) { }

	// RVA: 0x526D40 Offset: 0x525F40 VA: 0x180526D40
	public int get_CancelActionId() { }

	// RVA: 0x738350 Offset: 0x737550 VA: 0x180738350
	public void set_CancelActionId(int value) { }

	// RVA: 0x738210 Offset: 0x737410 VA: 0x180738210 Slot: 27
	protected override bool get_isMouseSupported() { }

	// RVA: 0x7381C0 Offset: 0x7373C0 VA: 0x1807381C0
	private bool get_isTouchAllowed() { }

	// RVA: 0x738190 Offset: 0x737390 VA: 0x180738190
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x738A20 Offset: 0x737C20 VA: 0x180738A20
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x738190 Offset: 0x737390 VA: 0x180738190
	public bool get_forceModuleActive() { }

	// RVA: 0x738A20 Offset: 0x737C20 VA: 0x180738A20
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x738200 Offset: 0x737400 VA: 0x180738200
	public float get_inputActionsPerSecond() { }

	// RVA: 0x738C60 Offset: 0x737E60 VA: 0x180738C60
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x738330 Offset: 0x737530 VA: 0x180738330
	public float get_repeatDelay() { }

	// RVA: 0x738C70 Offset: 0x737E70 VA: 0x180738C70
	public void set_repeatDelay(float value) { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public string get_horizontalAxis() { }

	// RVA: 0x738B70 Offset: 0x737D70 VA: 0x180738B70
	public void set_horizontalAxis(string value) { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public string get_verticalAxis() { }

	// RVA: 0x738D70 Offset: 0x737F70 VA: 0x180738D70
	public void set_verticalAxis(string value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public string get_submitButton() { }

	// RVA: 0x738C80 Offset: 0x737E80 VA: 0x180738C80
	public void set_submitButton(string value) { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	public string get_cancelButton() { }

	// RVA: 0x738A60 Offset: 0x737C60 VA: 0x180738A60
	public void set_cancelButton(string value) { }

	// RVA: 0x737E00 Offset: 0x737000 VA: 0x180737E00
	private void .ctor() { }

	// RVA: 0x732D90 Offset: 0x731F90 VA: 0x180732D90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x737CC0 Offset: 0x736EC0 VA: 0x180737CC0 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x7373B0 Offset: 0x7365B0 VA: 0x1807373B0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x732CB0 Offset: 0x731EB0 VA: 0x180732CB0 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x7331A0 Offset: 0x7323A0 VA: 0x1807331A0 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x735DA0 Offset: 0x734FA0 VA: 0x180735DA0 Slot: 17
	public override void Process() { }

	// RVA: 0x734C90 Offset: 0x733E90 VA: 0x180734C90
	private bool ProcessTouchEvents() { }

	// RVA: 0x735660 Offset: 0x734860 VA: 0x180735660
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x7364E0 Offset: 0x7356E0 VA: 0x1807364E0
	private bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x733630 Offset: 0x732830 VA: 0x180733630
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x736150 Offset: 0x735350 VA: 0x180736150
	private bool SendMoveEventToSelectedObject() { }

	// RVA: 0x732EB0 Offset: 0x7320B0 VA: 0x180732EB0
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical) { }

	// RVA: 0x7344E0 Offset: 0x7336E0 VA: 0x1807344E0
	private void ProcessMouseEvents() { }

	// RVA: 0x7340E0 Offset: 0x7332E0 VA: 0x1807340E0
	private void ProcessMouseEvent(int playerId, int pointerIndex) { }

	// RVA: 0x736750 Offset: 0x735950 VA: 0x180736750
	private bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x734640 Offset: 0x733840 VA: 0x180734640
	private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x7339D0 Offset: 0x732BD0 VA: 0x1807339D0
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x733F90 Offset: 0x733190 VA: 0x180733F90
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x737C00 Offset: 0x736E00 VA: 0x180737C00
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x733FA0 Offset: 0x7331A0 VA: 0x180733FA0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x733DC0 Offset: 0x732FC0 VA: 0x180733DC0 Slot: 28
	protected override bool IsDefaultPlayer(int playerId) { }

	// RVA: 0x733BF0 Offset: 0x732DF0 VA: 0x180733BF0
	private void InitializeRewired() { }

	// RVA: 0x736D40 Offset: 0x735F40 VA: 0x180736D40
	private void SetupRewiredVars() { }

	// RVA: 0x736BA0 Offset: 0x735DA0 VA: 0x180736BA0
	private void SetUpRewiredPlayerMice() { }

	// RVA: 0x7368A0 Offset: 0x735AA0 VA: 0x1807368A0
	private void SetUpRewiredActions() { }

	// RVA: 0x7333E0 Offset: 0x7325E0 VA: 0x1807333E0
	private bool GetButton(Player player, int actionId) { }

	// RVA: 0x7333A0 Offset: 0x7325A0 VA: 0x1807333A0
	private bool GetButtonDown(Player player, int actionId) { }

	// RVA: 0x7335F0 Offset: 0x7327F0 VA: 0x1807335F0
	private bool GetNegativeButton(Player player, int actionId) { }

	// RVA: 0x7335B0 Offset: 0x7327B0 VA: 0x1807335B0
	private bool GetNegativeButtonDown(Player player, int actionId) { }

	// RVA: 0x733360 Offset: 0x732560 VA: 0x180733360
	private float GetAxis(Player player, int actionId) { }

	// RVA: 0x733060 Offset: 0x732260 VA: 0x180733060
	private void CheckEditorRecompile() { }

	// RVA: 0x7340B0 Offset: 0x7332B0 VA: 0x1807340B0
	private void OnEditorRecompile() { }

	// RVA: 0x733110 Offset: 0x732310 VA: 0x180733110
	private void ClearRewiredVars() { }

	// RVA: 0x7331C0 Offset: 0x7323C0 VA: 0x1807331C0
	private bool DidAnyMouseMove() { }

	// RVA: 0x733420 Offset: 0x732620 VA: 0x180733420
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) { }

	// RVA: 0x7340C0 Offset: 0x7332C0 VA: 0x1807340C0
	private void OnRewiredInitialized() { }

	// RVA: 0x7340D0 Offset: 0x7332D0 VA: 0x1807340D0
	private void OnRewiredShutDown() { }
}

// Namespace: Rewired.Localization
[AddComponentMenu("Rewired/Localization/Localized String Provider")]
public class LocalizedStringProvider : LocalizedStringProviderBase // TypeDefIndex: 2016
{
	// Fields
	[Tooltip("A JSON file containing localizied string key value pairs.")]
	[SerializeField]
	private TextAsset _localizedStringsFile; // 0x28
	private Dictionary<string, string> _dictionary; // 0x30
	private bool _initialized; // 0x38

	// Properties
	protected virtual Dictionary<string, string> dictionary { get; set; }
	public virtual TextAsset localizedStringsFile { get; set; }
	protected override bool initialized { get; }

	// Methods

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 15
	protected virtual Dictionary<string, string> get_dictionary() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 16
	protected virtual void set_dictionary(Dictionary<string, string> value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 17
	public virtual TextAsset get_localizedStringsFile() { }

	// RVA: 0x72EAC0 Offset: 0x72DCC0 VA: 0x18072EAC0 Slot: 18
	public virtual void set_localizedStringsFile(TextAsset value) { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700 Slot: 7
	protected override bool get_initialized() { }

	// RVA: 0x72E840 Offset: 0x72DA40 VA: 0x18072E840 Slot: 12
	protected override bool Initialize() { }

	// RVA: 0x72E900 Offset: 0x72DB00 VA: 0x18072E900 Slot: 19
	protected virtual bool TryLoadLocalizedStringData() { }

	// RVA: 0x72E870 Offset: 0x72DA70 VA: 0x18072E870 Slot: 14
	protected override bool TryGetLocalizedString(string key, out string result) { }

	// RVA: 0x72EA50 Offset: 0x72DC50 VA: 0x18072EA50
	public void .ctor() { }
}

// Namespace: Rewired.Localization
public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider // TypeDefIndex: 2017
{
	// Fields
	[SerializeField]
	[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
	private bool _prefetch; // 0x20

	// Properties
	public virtual bool prefetch { get; set; }
	protected abstract bool initialized { get; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 5
	public virtual bool get_prefetch() { }

	// RVA: 0x72E700 Offset: 0x72D900 VA: 0x18072E700 Slot: 6
	public virtual void set_prefetch(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool get_initialized();

	// RVA: 0x72E330 Offset: 0x72D530 VA: 0x18072E330 Slot: 8
	protected virtual void OnEnable() { }

	// RVA: 0x72E1E0 Offset: 0x72D3E0 VA: 0x18072E1E0 Slot: 9
	protected virtual void OnDisable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void Update() { }

	// RVA: 0x72E4F0 Offset: 0x72D6F0 VA: 0x18072E4F0 Slot: 11
	protected virtual void TrySetLocalizedStringProvider() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool Initialize();

	// RVA: 0x72E390 Offset: 0x72D590 VA: 0x18072E390 Slot: 13
	public virtual void Reload() { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool TryGetLocalizedString(string key, out string result);

	// RVA: 0x72E4D0 Offset: 0x72D6D0 VA: 0x18072E4D0 Slot: 4
	private bool Rewired.Interfaces.ILocalizedStringProvider.TryGetLocalizedString(string key, out string result) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class ControllerElementGlyph : ControllerElementGlyphBase // TypeDefIndex: 2018
{
	// Fields
	private ActionElementMap _actionElementMap; // 0x48
	private ControllerElementIdentifier _controllerElementIdentifier; // 0x50
	private AxisRange _axisRange; // 0x58

	// Properties
	public ActionElementMap actionElementMap { get; set; }
	public ControllerElementIdentifier controllerElementIdentifier { get; set; }
	public AxisRange axisRange { get; set; }

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ActionElementMap get_actionElementMap() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_actionElementMap(ActionElementMap value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public ControllerElementIdentifier get_controllerElementIdentifier() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_controllerElementIdentifier(ControllerElementIdentifier value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public AxisRange get_axisRange() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x728410 Offset: 0x727610 VA: 0x180728410 Slot: 13
	protected override void Update() { }

	// RVA: 0x728640 Offset: 0x727840 VA: 0x180728640
	protected void .ctor() { }
}

// Namespace: 
protected class ControllerElementGlyphBase.GlyphOrTextObject // TypeDefIndex: 2019
{
	// Fields
	private GlyphOrTextBase _glyphOrText; // 0x10
	private int _frame; // 0x18
	private bool _isVisible; // 0x1C

	// Properties
	public virtual bool isVisible { get; set; }
	public GlyphOrTextBase glyphOrText { get; set; }

	// Methods

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 4
	public virtual bool get_isVisible() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950 Slot: 5
	protected virtual void set_isVisible(bool value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public GlyphOrTextBase get_glyphOrText() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_glyphOrText(GlyphOrTextBase value) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(GlyphOrTextBase glyphOrText) { }

	// RVA: 0x72ABB0 Offset: 0x729DB0 VA: 0x18072ABB0 Slot: 6
	public virtual void ShowGlyph(object glyph) { }

	// RVA: 0x72AC50 Offset: 0x729E50 VA: 0x18072AC50 Slot: 7
	public virtual void ShowText(string text) { }

	// RVA: 0x72AB20 Offset: 0x729D20 VA: 0x18072AB20 Slot: 8
	public virtual void Hide() { }

	// RVA: 0x72AAE0 Offset: 0x729CE0 VA: 0x18072AAE0 Slot: 9
	public virtual void HideIfIdle() { }

	// RVA: 0x72AA30 Offset: 0x729C30 VA: 0x18072AA30 Slot: 10
	public virtual void Destroy() { }
}

// Namespace: 
public enum ControllerElementGlyphBase.AllowedTypes // TypeDefIndex: 2020
{
	// Fields
	public int value__; // 0x0
	public const ControllerElementGlyphBase.AllowedTypes All = 0;
	public const ControllerElementGlyphBase.AllowedTypes Glyphs = 1;
	public const ControllerElementGlyphBase.AllowedTypes Text = 2;
}

// Namespace: Rewired.Glyphs
public abstract class ControllerElementGlyphBase : MonoBehaviour // TypeDefIndex: 2021
{
	// Fields
	[Tooltip("If set, when glyph/text objects are created, they will be instantiated from this prefab. If left blank, the global default prefab will be used.")]
	[SerializeField]
	private GameObject _glyphOrTextPrefab; // 0x20
	[Tooltip("Determines what types of objects are allowed.")]
	[SerializeField]
	private ControllerElementGlyphBase.AllowedTypes _allowedTypes; // 0x28
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _entries; // 0x30
	private List<object> _tempGlyphs; // 0x38
	private GameObject _lastGlyphOrTextPrefab; // 0x40

	// Properties
	public virtual GameObject glyphOrTextPrefab { get; set; }
	public virtual ControllerElementGlyphBase.AllowedTypes allowedTypes { get; set; }
	protected List<ControllerElementGlyphBase.GlyphOrTextObject> entries { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public virtual GameObject get_glyphOrTextPrefab() { }

	// RVA: 0x728210 Offset: 0x727410 VA: 0x180728210 Slot: 5
	public virtual void set_glyphOrTextPrefab(GameObject value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 6
	public virtual ControllerElementGlyphBase.AllowedTypes get_allowedTypes() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200 Slot: 7
	public virtual void set_allowedTypes(ControllerElementGlyphBase.AllowedTypes value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	protected List<ControllerElementGlyphBase.GlyphOrTextObject> get_entries() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void Awake() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected virtual void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void OnDestroy() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	protected virtual void OnEnable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	protected virtual void OnDisable() { }

	// RVA: 0x728030 Offset: 0x727230 VA: 0x180728030 Slot: 13
	protected virtual void Update() { }

	// RVA: 0x727AE0 Offset: 0x726CE0 VA: 0x180727AE0 Slot: 14
	public virtual void RequireRebuild() { }

	// RVA: 0x727250 Offset: 0x726450 VA: 0x180727250 Slot: 15
	protected virtual void ClearObjects() { }

	// RVA: 0x727810 Offset: 0x726A10 VA: 0x180727810 Slot: 16
	protected virtual void EvaluateObjectVisibility() { }

	// RVA: 0x7278D0 Offset: 0x726AD0 VA: 0x1807278D0 Slot: 17
	protected virtual void EvaluateObjectVisibility(Transform transform) { }

	// RVA: 0x7276C0 Offset: 0x7268C0 VA: 0x1807276C0 Slot: 18
	protected virtual void EvaluateObjectVisibility(Transform transform, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x727B00 Offset: 0x726D00 VA: 0x180727B00 Slot: 19
	protected virtual int ShowGlyphsOrText(ActionElementMap actionElementMap, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x727DB0 Offset: 0x726FB0 VA: 0x180727DB0 Slot: 20
	protected virtual int ShowGlyphsOrText(ActionElementMap actionElementMap) { }

	// RVA: 0x727E00 Offset: 0x727000 VA: 0x180727E00 Slot: 21
	protected virtual int ShowGlyphsOrText(ControllerElementIdentifier elementIdentifier, AxisRange axisRange, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x727FD0 Offset: 0x7271D0 VA: 0x180727FD0 Slot: 22
	protected virtual int ShowGlyphsOrText(ControllerElementIdentifier elementIdentifier, AxisRange axisRange) { }

	// RVA: 0x727A10 Offset: 0x726C10 VA: 0x180727A10 Slot: 23
	protected virtual void Hide() { }

	// RVA: 0x7278F0 Offset: 0x726AF0 VA: 0x1807278F0 Slot: 24
	protected virtual GameObject GetGlyphOrTextPrefabOrDefault() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract GameObject GetDefaultGlyphOrTextPrefab();

	// RVA: 0x727360 Offset: 0x726560 VA: 0x180727360 Slot: 26
	protected virtual bool CreateObjectsAsNeeded(Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries, int count) { }

	// RVA: 0x727AD0 Offset: 0x726CD0 VA: 0x180727AD0 Slot: 27
	protected virtual bool IsAllowed(ControllerElementGlyphBase.AllowedTypes allowedType) { }

	// RVA: 0x727980 Offset: 0x726B80 VA: 0x180727980
	protected static int GetGlyphs(ActionElementMap actionElementMap, List<object> results) { }

	// RVA: 0x728160 Offset: 0x727360 VA: 0x180728160
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class ControllerElementGlyphSelectorOptions // TypeDefIndex: 2022
{
	// Fields
	[SerializeField]
	[Tooltip("Determines if the Player's last active controller is used for glyph selection.")]
	private bool _useLastActiveController; // 0x10
	[Tooltip("List of controller type priority. First in list corresponds to highest priority. This determines which controller types take precedence when displaying glyphs. If use last active controller is enabled, the active controller will always take priority, however, if there is no last active controller, selection will fall back based on this priority. In addition, keyboard and mouse are treated as a single controller for the purposes of glyph handling, so to prioritze keyboard over mouse or vice versa, the one that is lower in the list will take precedence.")]
	[SerializeField]
	private ControllerType[] _controllerTypeOrder; // 0x18
	private static ControllerElementGlyphSelectorOptions s_defaultOptions; // 0x0

	// Properties
	public bool useLastActiveController { get; set; }
	public ControllerType[] controllerTypeOrder { get; set; }
	public static ControllerElementGlyphSelectorOptions defaultOptions { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_useLastActiveController() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_useLastActiveController(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ControllerType[] get_controllerTypeOrder() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_controllerTypeOrder(ControllerType[] value) { }

	// RVA: 0x728230 Offset: 0x727430 VA: 0x180728230 Slot: 4
	public virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType) { }

	// RVA: 0x7282F0 Offset: 0x7274F0 VA: 0x1807282F0
	public static ControllerElementGlyphSelectorOptions get_defaultOptions() { }

	// RVA: 0x7283D0 Offset: 0x7275D0 VA: 0x1807283D0
	public static void set_defaultOptions(ControllerElementGlyphSelectorOptions value) { }

	// RVA: 0x728270 Offset: 0x727470 VA: 0x180728270
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class ControllerElementGlyphSelectorOptionsSO : ControllerElementGlyphSelectorOptionsSOBase // TypeDefIndex: 2023
{
	// Fields
	[SerializeField]
	private ControllerElementGlyphSelectorOptions _options; // 0x18

	// Properties
	public override ControllerElementGlyphSelectorOptions options { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public override ControllerElementGlyphSelectorOptions get_options() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public abstract class ControllerElementGlyphSelectorOptionsSOBase : ScriptableObject // TypeDefIndex: 2024
{
	// Properties
	public abstract ControllerElementGlyphSelectorOptions options { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ControllerElementGlyphSelectorOptions get_options();

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class DefaultControllerElementGlyphSettingsBase : MonoBehaviour // TypeDefIndex: 2025
{
	// Fields
	[Tooltip("The Controller element glyph options.")]
	[SerializeField]
	private ControllerElementGlyphSelectorOptions _options; // 0x20
	[SerializeField]
	[Tooltip("The prefab used for each glyph or text object.")]
	private GameObject _glyphOrTextPrefab; // 0x28

	// Properties
	public ControllerElementGlyphSelectorOptions options { get; set; }
	public GameObject glyphOrTextPrefab { get; set; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ControllerElementGlyphSelectorOptions get_options() { }

	// RVA: 0x7292B0 Offset: 0x7284B0 VA: 0x1807292B0
	public void set_options(ControllerElementGlyphSelectorOptions value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public GameObject get_glyphOrTextPrefab() { }

	// RVA: 0x729290 Offset: 0x728490 VA: 0x180729290
	public void set_glyphOrTextPrefab(GameObject value) { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x729250 Offset: 0x728450 VA: 0x180729250 Slot: 6
	protected virtual void SetDefaults() { }

	// RVA: 0x729210 Offset: 0x728410 VA: 0x180729210 Slot: 7
	protected virtual void SetDefaultOptions() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void SetDefaultGlyphOrTextPrefab();

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
[Flags]
protected enum GlyphOrTextBase.TypeFlags // TypeDefIndex: 2026
{
	// Fields
	public int value__; // 0x0
	public const GlyphOrTextBase.TypeFlags None = 0;
	public const GlyphOrTextBase.TypeFlags Glyph = 1;
	public const GlyphOrTextBase.TypeFlags Text = 2;
	public const GlyphOrTextBase.TypeFlags All = -1;
}

// Namespace: Rewired.Glyphs
public abstract class GlyphOrTextBase : MonoBehaviour // TypeDefIndex: 2027
{
	// Properties
	protected abstract string textString { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string get_textString();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_textString(string value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ShowText(string text);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ShowGlyph(object glyph);

	// RVA: 0x72AA10 Offset: 0x729C10 VA: 0x18072AA10 Slot: 8
	public virtual void Hide() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Hide(GlyphOrTextBase.TypeFlags flags);

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent> : GlyphOrTextBase // TypeDefIndex: 2028
{
	// Fields
	[SerializeField]
	private TTextComponent _textComponent; // 0x0
	[SerializeField]
	private TGlyphComponent _glyphComponent; // 0x0

	// Properties
	public TTextComponent textComponent { get; set; }
	public TGlyphComponent glyphComponent { get; set; }
	protected abstract TGlyphGraphic glyphGraphic { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TTextComponent get_textComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-GlyphOrTextBase<object, object, object>.get_textComponent
	*/

	// RVA: -1 Offset: -1
	public void set_textComponent(TTextComponent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	|-GlyphOrTextBase<object, object, object>.set_textComponent
	*/

	// RVA: -1 Offset: -1
	public TGlyphComponent get_glyphComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-GlyphOrTextBase<object, object, object>.get_glyphComponent
	*/

	// RVA: -1 Offset: -1
	public void set_glyphComponent(TGlyphComponent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	|-GlyphOrTextBase<object, object, object>.set_glyphComponent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract TGlyphGraphic get_glyphGraphic();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GlyphOrTextBase<object, object, object>.get_glyphGraphic
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void set_glyphGraphic(TGlyphGraphic value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GlyphOrTextBase<object, object, object>.set_glyphGraphic
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void ShowText(string text) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12131F0 Offset: 0x12123F0 VA: 0x1812131F0
	|-GlyphOrTextBase<object, object, object>.ShowText
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void ShowGlyph(object glyph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212EF0 Offset: 0x12120F0 VA: 0x181212EF0
	|-GlyphOrTextBase<object, object, object>.ShowGlyph
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void ShowGlyph(TGlyphGraphic glyph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12130A0 Offset: 0x12122A0 VA: 0x1812130A0
	|-GlyphOrTextBase<object, object, object>.ShowGlyph
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Hide(GlyphOrTextBase.TypeFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212CE0 Offset: 0x1211EE0 VA: 0x181212CE0
	|-GlyphOrTextBase<object, object, object>.Hide
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	|-GlyphOrTextBase<object, object, object>..ctor
	*/
}

// Namespace: Rewired.Glyphs
public class GlyphProvider : MonoBehaviour, IGlyphProvider // TypeDefIndex: 2029
{
	// Fields
	[SerializeField]
	[Tooltip("Determines if glyphs should be fetched immediately in bulk when available. If false, glyphs will be fetched when queried.")]
	private bool _prefetch; // 0x20
	[Tooltip("A list of glyph set collections. At least one collection must be assigned.")]
	[SerializeField]
	private List<GlyphSetCollection> _glyphSetCollections; // 0x28
	private readonly Dictionary<string, object> _glyphs; // 0x30
	private bool _initialized; // 0x38

	// Properties
	public bool prefetch { get; set; }
	public List<GlyphSetCollection> glyphSetCollections { get; set; }
	protected Dictionary<string, object> glyphs { get; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_prefetch() { }

	// RVA: 0x72B8F0 Offset: 0x72AAF0 VA: 0x18072B8F0
	public void set_prefetch(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<GlyphSetCollection> get_glyphSetCollections() { }

	// RVA: 0x72B7D0 Offset: 0x72A9D0 VA: 0x18072B7D0
	public void set_glyphSetCollections(List<GlyphSetCollection> value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	protected Dictionary<string, object> get_glyphs() { }

	// RVA: 0x72B360 Offset: 0x72A560 VA: 0x18072B360 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x72B210 Offset: 0x72A410 VA: 0x18072B210 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x72B550 Offset: 0x72A750 VA: 0x18072B550 Slot: 8
	protected virtual void TrySetGlyphProvider() { }

	// RVA: 0x72ACF0 Offset: 0x729EF0 VA: 0x18072ACF0 Slot: 9
	protected virtual bool Initialize() { }

	// RVA: 0x72B3A0 Offset: 0x72A5A0 VA: 0x18072B3A0
	public void Reload() { }

	// RVA: 0x72B4C0 Offset: 0x72A6C0 VA: 0x18072B4C0 Slot: 4
	private bool Rewired.Interfaces.IGlyphProvider.TryGetGlyph(string key, out object result) { }

	// RVA: 0x72B760 Offset: 0x72A960 VA: 0x18072B760
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public abstract class GlyphSet.EntryBase // TypeDefIndex: 2030
{
	// Fields
	[SerializeField]
	private string _key; // 0x10

	// Properties
	public string key { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_key() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_key(string value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetValue();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public abstract class GlyphSet.EntryBase<TValue> : GlyphSet.EntryBase // TypeDefIndex: 2031
{
	// Fields
	[SerializeField]
	private TValue _value; // 0x0

	// Properties
	public TValue value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TValue get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-GlyphSet.EntryBase<object>.get_value
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-GlyphSet.EntryBase<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1
	public void set_value(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	|-GlyphSet.EntryBase<object>.set_value
	|
	|-RVA: 0xCDEA80 Offset: 0xCDDC80 VA: 0x180CDEA80
	|-GlyphSet.EntryBase<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-GlyphSet.EntryBase<object>.GetValue
	|
	|-RVA: 0x10DDC10 Offset: 0x10DCE10 VA: 0x1810DDC10
	|-GlyphSet.EntryBase<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	|-GlyphSet.EntryBase<object>..ctor
	|-GlyphSet.EntryBase<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Rewired.Glyphs
[Serializable]
public abstract class GlyphSet : ScriptableObject // TypeDefIndex: 2032
{
	// Fields
	[SerializeField]
	[Tooltip("A list of base keys. Final keys will be composed of base key + glyph key. Setting multiple base keys allows one glyph set to apply to multiple controllers, for example.")]
	private string[] _baseKeys; // 0x18

	// Properties
	public string[] baseKeys { get; set; }
	public abstract int glyphCount { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string[] get_baseKeys() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_baseKeys(string[] value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_glyphCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract GlyphSet.EntryBase GetEntry(int index);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GlyphSetCollection.<IterateSetsRecursively>d__9 : IEnumerable<GlyphSet>, IEnumerable, IEnumerator<GlyphSet>, IEnumerator, IDisposable // TypeDefIndex: 2033
{
	// Fields
	private int <>1__state; // 0x10
	private GlyphSet <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private List<GlyphSetCollection> processedCollections; // 0x28
	public List<GlyphSetCollection> <>3__processedCollections; // 0x30
	public GlyphSetCollection <>4__this; // 0x38
	private int <setCount>5__2; // 0x40
	private int <collectionCount>5__3; // 0x44
	private int <i>5__4; // 0x48
	private IEnumerator<GlyphSet> <>7__wrap4; // 0x50

	// Properties
	private GlyphSet System.Collections.Generic.IEnumerator<Rewired.Glyphs.GlyphSet>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x73A020 Offset: 0x739220 VA: 0x18073A020 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x739A20 Offset: 0x738C20 VA: 0x180739A20 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x73A0B0 Offset: 0x7392B0 VA: 0x18073A0B0
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private GlyphSet System.Collections.Generic.IEnumerator<Rewired.Glyphs.GlyphSet>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x739FE0 Offset: 0x7391E0 VA: 0x180739FE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x739F40 Offset: 0x739140 VA: 0x180739F40 Slot: 4
	private IEnumerator<GlyphSet> System.Collections.Generic.IEnumerable<Rewired.Glyphs.GlyphSet>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x739F40 Offset: 0x739140 VA: 0x180739F40 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class GlyphSetCollection : ScriptableObject // TypeDefIndex: 2034
{
	// Fields
	[Tooltip("The list of glyph sets.")]
	[SerializeField]
	private List<GlyphSet> _sets; // 0x18
	[Tooltip("The list of glyph set collections.")]
	[SerializeField]
	private List<GlyphSetCollection> _collections; // 0x20

	// Properties
	public List<GlyphSet> sets { get; set; }
	public List<GlyphSetCollection> collections { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<GlyphSet> get_sets() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_sets(List<GlyphSet> value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<GlyphSetCollection> get_collections() { }

	// RVA: 0x72BBC0 Offset: 0x72ADC0 VA: 0x18072BBC0
	public void set_collections(List<GlyphSetCollection> value) { }

	// RVA: 0x72BA80 Offset: 0x72AC80 VA: 0x18072BA80 Slot: 4
	public virtual IEnumerable<GlyphSet> IterateSetsRecursively() { }

	[IteratorStateMachine(typeof(GlyphSetCollection.<IterateSetsRecursively>d__9))]
	// RVA: 0x72BA00 Offset: 0x72AC00 VA: 0x18072BA00 Slot: 5
	protected virtual IEnumerable<GlyphSet> IterateSetsRecursively(List<GlyphSetCollection> processedCollections) { }

	// RVA: 0x72BB60 Offset: 0x72AD60 VA: 0x18072BB60
	private static void LogCircularDependency() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
public static class GlyphTools // TypeDefIndex: 2035
{
	// Methods

	// RVA: 0x72C010 Offset: 0x72B210 VA: 0x18072C010
	public static bool TryGetActionElementMaps(int playerId, int actionId, AxisRange actionRange, ControllerElementGlyphSelectorOptions options, List<ActionElementMap> workingActionElementMaps, out ActionElementMap aemResult1, out ActionElementMap aemResult2) { }

	// RVA: 0x72C640 Offset: 0x72B840 VA: 0x18072C640
	public static bool TryGetActionElementMaps(InputAction action, AxisRange actionRange, List<ActionElementMap> tempAems, out ActionElementMap aemResult1, out ActionElementMap aemResult2) { }

	// RVA: 0x72BDF0 Offset: 0x72AFF0 VA: 0x18072BDF0
	public static ActionElementMap FindFirstFullAxisBinding(List<ActionElementMap> actionElementMaps) { }

	// RVA: 0x72BC70 Offset: 0x72AE70 VA: 0x18072BC70
	public static ActionElementMap FindFirstBinding(List<ActionElementMap> actionElementMaps, AxisRange actionRange) { }

	// RVA: 0x72BEA0 Offset: 0x72B0A0 VA: 0x18072BEA0
	public static bool FindFirstSplitAxisBindingPair(List<ActionElementMap> actionElementMaps, out ActionElementMap negativeAem, out ActionElementMap positiveAem) { }

	// RVA: 0x72BFA0 Offset: 0x72B1A0 VA: 0x18072BFA0
	public static bool IsMousePrioritizedOverKeyboard(ControllerElementGlyphSelectorOptions options) { }
}

// Namespace: 
[Serializable]
public class SpriteGlyphSet.Entry : GlyphSet.EntryBase<Sprite> // TypeDefIndex: 2036
{
	// Methods

	// RVA: 0x7292D0 Offset: 0x7284D0 VA: 0x1807292D0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class SpriteGlyphSet : GlyphSet // TypeDefIndex: 2037
{
	// Fields
	[SerializeField]
	[Tooltip("The list of glyphs.")]
	private List<SpriteGlyphSet.Entry> _glyphs; // 0x20

	// Properties
	public List<SpriteGlyphSet.Entry> glyphs { get; set; }
	public override int glyphCount { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<SpriteGlyphSet.Entry> get_glyphs() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_glyphs(List<SpriteGlyphSet.Entry> value) { }

	// RVA: 0x7399D0 Offset: 0x738BD0 VA: 0x1807399D0 Slot: 4
	public override int get_glyphCount() { }

	// RVA: 0x739910 Offset: 0x738B10 VA: 0x180739910 Slot: 5
	public override GlyphSet.EntryBase GetEntry(int index) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Controller Element Glyph")]
public class UnityUIControllerElementGlyph : ControllerElementGlyph // TypeDefIndex: 2038
{
	// Methods

	// RVA: 0x73AC60 Offset: 0x739E60 VA: 0x18073AC60 Slot: 25
	protected override GameObject GetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x728640 Offset: 0x727840 VA: 0x180728640
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public abstract class UnityUIControllerElementGlyphBase : ControllerElementGlyphBase // TypeDefIndex: 2039
{
	// Fields
	private static GameObject s_defaultGlyphOrTextPrefab; // 0x0
	private static Func<GameObject> s_defaultGlyphOrTextPrefabProvider; // 0x8

	// Properties
	public static GameObject defaultGlyphOrTextPrefab { get; set; }
	public static Func<GameObject> defaultGlyphOrTextPrefabProvider { get; set; }

	// Methods

	// RVA: 0x73AC60 Offset: 0x739E60 VA: 0x18073AC60 Slot: 25
	protected override GameObject GetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x73ACB0 Offset: 0x739EB0 VA: 0x18073ACB0
	public static GameObject get_defaultGlyphOrTextPrefab() { }

	// RVA: 0x73AD90 Offset: 0x739F90 VA: 0x18073AD90
	public static void set_defaultGlyphOrTextPrefab(GameObject value) { }

	// RVA: 0x73AC70 Offset: 0x739E70 VA: 0x18073AC70
	public static Func<GameObject> get_defaultGlyphOrTextPrefabProvider() { }

	// RVA: 0x73AD50 Offset: 0x739F50 VA: 0x18073AD50
	public static void set_defaultGlyphOrTextPrefabProvider(Func<GameObject> value) { }

	// RVA: 0x73A8C0 Offset: 0x739AC0 VA: 0x18073A8C0
	private static GameObject CreateDefaultGlyphOrTextPrefab() { }

	// RVA: 0x728640 Offset: 0x727840 VA: 0x180728640
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Default Controller Element Glyph Settings")]
public class UnityUIDefaultControllerElementGlyphSettings : DefaultControllerElementGlyphSettingsBase // TypeDefIndex: 2040
{
	// Methods

	// RVA: 0x73ADD0 Offset: 0x739FD0 VA: 0x18073ADD0 Slot: 8
	protected override void SetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
internal class UnityUIDefaultGlyphOrTextTMProPrefabProvider // TypeDefIndex: 2041
{
	// Methods

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x73B130 Offset: 0x73A330 VA: 0x18073B130
	private static void Initialize() { }

	// RVA: 0x73AE10 Offset: 0x73A010 VA: 0x18073AE10
	private static GameObject CreateDefaultGlyphOrTextPrefab() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public class UnityUIGlyphOrText : GlyphOrTextBase<Image, Sprite, Text> // TypeDefIndex: 2042
{
	// Properties
	protected override string textString { get; set; }
	protected override Sprite glyphGraphic { get; set; }

	// Methods

	// RVA: 0x73B570 Offset: 0x73A770 VA: 0x18073B570 Slot: 4
	protected override string get_textString() { }

	// RVA: 0x73B6D0 Offset: 0x73A8D0 VA: 0x18073B6D0 Slot: 5
	protected override void set_textString(string value) { }

	// RVA: 0x73B4E0 Offset: 0x73A6E0 VA: 0x18073B4E0 Slot: 10
	protected override Sprite get_glyphGraphic() { }

	// RVA: 0x73B630 Offset: 0x73A830 VA: 0x18073B630 Slot: 11
	protected override void set_glyphGraphic(Sprite value) { }

	// RVA: 0x73B4A0 Offset: 0x73A6A0 VA: 0x18073B4A0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public class UnityUIGlyphOrTextTMPro : GlyphOrTextBase<Image, Sprite, TMP_Text> // TypeDefIndex: 2043
{
	// Properties
	protected override string textString { get; set; }
	protected override Sprite glyphGraphic { get; set; }

	// Methods

	// RVA: 0x73B2A0 Offset: 0x73A4A0 VA: 0x18073B2A0 Slot: 4
	protected override string get_textString() { }

	// RVA: 0x73B400 Offset: 0x73A600 VA: 0x18073B400 Slot: 5
	protected override void set_textString(string value) { }

	// RVA: 0x73B210 Offset: 0x73A410 VA: 0x18073B210 Slot: 10
	protected override Sprite get_glyphGraphic() { }

	// RVA: 0x73B360 Offset: 0x73A560 VA: 0x18073B360 Slot: 11
	protected override void set_glyphGraphic(Sprite value) { }

	// RVA: 0x73B1D0 Offset: 0x73A3D0 VA: 0x18073B1D0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Player Controller Element Glyph")]
public class UnityUIPlayerControllerElementGlyph : UnityUIPlayerControllerElementGlyphBase // TypeDefIndex: 2044
{
	// Fields
	[SerializeField]
	[Tooltip("The Player id.")]
	private int _playerId; // 0x88
	[SerializeField]
	[Tooltip("The Action name.")]
	private string _actionName; // 0x90
	private int _actionId; // 0x98
	private bool _actionIdCached; // 0x9C

	// Properties
	public override int playerId { get; set; }
	public override int actionId { get; set; }
	public string actionName { get; set; }

	// Methods

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950 Slot: 30
	public override int get_playerId() { }

	// RVA: 0x73BA10 Offset: 0x73AC10 VA: 0x18073BA10 Slot: 31
	public override void set_playerId(int value) { }

	// RVA: 0x73B880 Offset: 0x73AA80 VA: 0x18073B880 Slot: 32
	public override int get_actionId() { }

	// RVA: 0x73B8C0 Offset: 0x73AAC0 VA: 0x18073B8C0 Slot: 33
	public override void set_actionId(int value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_actionName() { }

	// RVA: 0x73BA00 Offset: 0x73AC00 VA: 0x18073BA00
	public void set_actionName(string value) { }

	// RVA: 0x73B770 Offset: 0x73A970 VA: 0x18073B770
	private void CacheActionId() { }

	// RVA: 0x73B860 Offset: 0x73AA60 VA: 0x18073B860
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public abstract class UnityUIPlayerControllerElementGlyphBase : UnityUIControllerElementGlyphBase // TypeDefIndex: 2045
{
	// Fields
	[Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
	[SerializeField]
	private ControllerElementGlyphSelectorOptionsSOBase _options; // 0x48
	[SerializeField]
	[Tooltip("The range of the Action for which to show glyphs / text. This determines whether to show the glyph for an axis-type Action (ex: Move Horizontal), or the positive/negative pole of an Action (ex: Move Right). For button-type Actions, Full and Positive are equivalent.")]
	private AxisRange _actionRange; // 0x50
	[SerializeField]
	[Tooltip("Optional parent Transform of the first group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the negative pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under this transform. If blank, objects will be created as children of this object's Transform.")]
	private Transform _group1; // 0x58
	[Tooltip("Optional parent Transform of the second group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the positive pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under group1 instead. If blank, objects will be created as children of either group1 if set or the object's Transform.")]
	[SerializeField]
	private Transform _group2; // 0x60
	private List<ActionElementMap> _tempAems; // 0x68
	private List<ActionElementMap> _tempCombinedElementAems; // 0x70
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group1Objects; // 0x78
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group2Objects; // 0x80

	// Properties
	public virtual ControllerElementGlyphSelectorOptionsSOBase options { get; set; }
	public abstract int playerId { get; set; }
	public abstract int actionId { get; set; }
	public virtual AxisRange actionRange { get; set; }
	public virtual Transform group1 { get; set; }
	public virtual Transform group2 { get; set; }
	protected virtual bool isMousePrioritizedOverKeyboard { get; }

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 28
	public virtual ControllerElementGlyphSelectorOptionsSOBase get_options() { }

	// RVA: 0x779940 Offset: 0x778B40 VA: 0x180779940 Slot: 29
	public virtual void set_options(ControllerElementGlyphSelectorOptionsSOBase value) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int get_playerId();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void set_playerId(int value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int get_actionId();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void set_actionId(int value);

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 34
	public virtual AxisRange get_actionRange() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630 Slot: 35
	public virtual void set_actionRange(AxisRange value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 36
	public virtual Transform get_group1() { }

	// RVA: 0x779900 Offset: 0x778B00 VA: 0x180779900 Slot: 37
	public virtual void set_group1(Transform value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 38
	public virtual Transform get_group2() { }

	// RVA: 0x779920 Offset: 0x778B20 VA: 0x180779920 Slot: 39
	public virtual void set_group2(Transform value) { }

	// RVA: 0x779880 Offset: 0x778A80 VA: 0x180779880 Slot: 40
	protected virtual bool get_isMousePrioritizedOverKeyboard() { }

	// RVA: 0x779540 Offset: 0x778740 VA: 0x180779540 Slot: 41
	protected virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType) { }

	// RVA: 0x7795A0 Offset: 0x7787A0 VA: 0x1807795A0 Slot: 13
	protected override void Update() { }

	// RVA: 0x778AA0 Offset: 0x777CA0 VA: 0x180778AA0 Slot: 15
	protected override void ClearObjects() { }

	// RVA: 0x779100 Offset: 0x778300 VA: 0x180779100 Slot: 42
	protected virtual bool ShowBinding(ActionElementMap actionElementMap) { }

	// RVA: 0x779350 Offset: 0x778550 VA: 0x180779350 Slot: 43
	protected virtual bool ShowSplitAxisBindings(ActionElementMap negativeAem, ActionElementMap positiveAem) { }

	// RVA: 0x778B40 Offset: 0x777D40 VA: 0x180778B40 Slot: 16
	protected override void EvaluateObjectVisibility() { }

	// RVA: 0x779190 Offset: 0x778390 VA: 0x180779190 Slot: 44
	protected virtual int ShowGlyphsOrText(IList<ActionElementMap> bindings, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> objects) { }

	// RVA: 0x778FA0 Offset: 0x7781A0 VA: 0x180778FA0 Slot: 23
	protected override void Hide() { }

	// RVA: 0x778C50 Offset: 0x777E50 VA: 0x180778C50 Slot: 45
	protected virtual Transform GetObjectGroupTransform(int groupIndex) { }

	// RVA: 0x778DF0 Offset: 0x777FF0 VA: 0x180778DF0 Slot: 46
	protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() { }

	// RVA: 0x779790 Offset: 0x778990 VA: 0x180779790
	protected void .ctor() { }
}

// Namespace: 
private sealed class UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler : MulticastDelegate // TypeDefIndex: 2046
{
	// Methods

	// RVA: 0x7742B0 Offset: 0x7734B0 VA: 0x1807742B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual bool Invoke(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x774200 Offset: 0x773400 VA: 0x180774200 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int startIndex, int count, out string replacement, AsyncCallback callback, object object) { }

	// RVA: 0x459520 Offset: 0x458720 VA: 0x180459520 Slot: 15
	public virtual bool EndInvoke(out string replacement, IAsyncResult result) { }
}

// Namespace: 
public enum UnityUITextMeshProGlyphHelper.Tag.TagType // TypeDefIndex: 2047
{
	// Fields
	public int value__; // 0x0
	public const UnityUITextMeshProGlyphHelper.Tag.TagType ControllerElement = 0;
	public const UnityUITextMeshProGlyphHelper.Tag.TagType Action = 1;
	public const UnityUITextMeshProGlyphHelper.Tag.TagType Player = 2;
}

// Namespace: 
public abstract class UnityUITextMeshProGlyphHelper.Tag.Pool // TypeDefIndex: 2048
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Return(UnityUITextMeshProGlyphHelper.Tag obj);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
public sealed class UnityUITextMeshProGlyphHelper.Tag.Pool<T> : UnityUITextMeshProGlyphHelper.Tag.Pool // TypeDefIndex: 2049
{
	// Fields
	private readonly List<T> _list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB83650 Offset: 0xB82850 VA: 0x180B83650
	|-UnityUITextMeshProGlyphHelper.Tag.Pool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB83470 Offset: 0xB82670 VA: 0x180B83470
	|-UnityUITextMeshProGlyphHelper.Tag.Pool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override bool Return(UnityUITextMeshProGlyphHelper.Tag obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB83520 Offset: 0xB82720 VA: 0x180B83520
	|-UnityUITextMeshProGlyphHelper.Tag.Pool<object>.Return
	*/
}

// Namespace: 
private abstract class UnityUITextMeshProGlyphHelper.Tag // TypeDefIndex: 2050
{
	// Fields
	public readonly UnityUITextMeshProGlyphHelper.Tag.TagType tagType; // 0x10
	private UnityUITextMeshProGlyphHelper.Tag.Pool _pool; // 0x18

	// Properties
	protected UnityUITextMeshProGlyphHelper.Tag.Pool pool { get; set; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	protected void .ctor(UnityUITextMeshProGlyphHelper.Tag.TagType tagType) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	protected UnityUITextMeshProGlyphHelper.Tag.Pool get_pool() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	protected void set_pool(UnityUITextMeshProGlyphHelper.Tag.Pool value) { }

	// RVA: 0x778840 Offset: 0x777A40 VA: 0x180778840
	public void ReturnToPool() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Clear();

	// RVA: 0x778750 Offset: 0x777950 VA: 0x180778750
	public static void Clear(List<UnityUITextMeshProGlyphHelper.Tag> list) { }
}

// Namespace: 
private sealed class UnityUITextMeshProGlyphHelper.ControllerElementTag : UnityUITextMeshProGlyphHelper.Tag // TypeDefIndex: 2051
{
	// Fields
	public UnityUITextMeshProGlyphHelper.DisplayType type; // 0x20
	public int playerId; // 0x24
	public int actionId; // 0x28
	public AxisRange actionRange; // 0x2C
	private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrText; // 0x30

	// Properties
	public List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphsOrText { get; }

	// Methods

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<UnityUITextMeshProGlyphHelper.GlyphOrText> get_glyphsOrText() { }

	// RVA: 0x7731C0 Offset: 0x7723C0 VA: 0x1807731C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x773CC0 Offset: 0x772EC0 VA: 0x180773CC0
	public void .ctor() { }

	// RVA: 0x773150 Offset: 0x772350 VA: 0x180773150 Slot: 4
	protected override void Clear() { }

	// RVA: 0x7733C0 Offset: 0x7725C0 VA: 0x1807733C0
	public static bool TryParseString(string text, int startIndex, int count, StringBuilder sb1, StringBuilder sb2, Dictionary<string, string> workDictionary, UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> pool, out UnityUITextMeshProGlyphHelper.ControllerElementTag result) { }
}

// Namespace: 
private sealed class UnityUITextMeshProGlyphHelper.ActionTag : UnityUITextMeshProGlyphHelper.Tag // TypeDefIndex: 2052
{
	// Fields
	public int actionId; // 0x20
	public AxisRange actionRange; // 0x24
	private string _displayName; // 0x28

	// Properties
	public string displayName { get; set; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_displayName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_displayName(string value) { }

	// RVA: 0x758EF0 Offset: 0x7580F0 VA: 0x180758EF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x759660 Offset: 0x758860 VA: 0x180759660
	public void .ctor() { }

	// RVA: 0x758ED0 Offset: 0x7580D0 VA: 0x180758ED0 Slot: 4
	protected override void Clear() { }

	// RVA: 0x759080 Offset: 0x758280 VA: 0x180759080
	public static bool TryParseString(string text, int startIndex, int count, StringBuilder sb1, StringBuilder sb2, Dictionary<string, string> workDictionary, UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> pool, out UnityUITextMeshProGlyphHelper.ActionTag result) { }
}

// Namespace: 
private sealed class UnityUITextMeshProGlyphHelper.PlayerTag : UnityUITextMeshProGlyphHelper.Tag // TypeDefIndex: 2053
{
	// Fields
	public int playerId; // 0x20
	private string _displayName; // 0x28

	// Properties
	public string displayName { get; set; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_displayName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_displayName(string value) { }

	// RVA: 0x774370 Offset: 0x773570 VA: 0x180774370 Slot: 3
	public override string ToString() { }

	// RVA: 0x774900 Offset: 0x773B00 VA: 0x180774900
	public void .ctor() { }

	// RVA: 0x774360 Offset: 0x773560 VA: 0x180774360 Slot: 4
	protected override void Clear() { }

	// RVA: 0x7744A0 Offset: 0x7736A0 VA: 0x1807744A0
	public static bool TryParseString(string text, int startIndex, int count, StringBuilder sb1, StringBuilder sb2, Dictionary<string, string> workDictionary, UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> pool, out UnityUITextMeshProGlyphHelper.PlayerTag result) { }
}

// Namespace: 
private struct UnityUITextMeshProGlyphHelper.GlyphOrText : IEquatable<UnityUITextMeshProGlyphHelper.GlyphOrText> // TypeDefIndex: 2054
{
	// Fields
	public string glyphKey; // 0x0
	public Sprite sprite; // 0x8
	public string name; // 0x10

	// Methods

	// RVA: 0x773E30 Offset: 0x773030 VA: 0x180773E30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x773F40 Offset: 0x773140 VA: 0x180773F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x773D50 Offset: 0x772F50 VA: 0x180773D50 Slot: 4
	public bool Equals(UnityUITextMeshProGlyphHelper.GlyphOrText other) { }

	// RVA: 0x773FE0 Offset: 0x7731E0 VA: 0x180773FE0
	public static bool op_Equality(UnityUITextMeshProGlyphHelper.GlyphOrText a, UnityUITextMeshProGlyphHelper.GlyphOrText b) { }

	// RVA: 0x7740F0 Offset: 0x7732F0 VA: 0x1807740F0
	public static bool op_Inequality(UnityUITextMeshProGlyphHelper.GlyphOrText a, UnityUITextMeshProGlyphHelper.GlyphOrText b) { }
}

// Namespace: 
private class UnityUITextMeshProGlyphHelper.Asset // TypeDefIndex: 2055
{
	// Fields
	public readonly uint id; // 0x10
	private UnityUITextMeshProGlyphHelper.ITMProSpriteAsset _spriteAsset; // 0x18
	private Material _material; // 0x20
	private static uint s_idCounter; // 0x0
	private static Shader __tmProShader; // 0x8

	// Properties
	public UnityUITextMeshProGlyphHelper.ITMProSpriteAsset spriteAsset { get; }
	public Material material { get; }
	private static Shader tmProShader { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public UnityUITextMeshProGlyphHelper.ITMProSpriteAsset get_spriteAsset() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Material get_material() { }

	// RVA: 0x759990 Offset: 0x758B90 VA: 0x180759990
	public void .ctor(Material baseMaterial) { }

	// RVA: 0x7596A0 Offset: 0x7588A0 VA: 0x1807596A0
	public static Material CreateMaterial(Material baseMaterial, uint id) { }

	// RVA: 0x7598D0 Offset: 0x758AD0 VA: 0x1807598D0
	public void Destroy() { }

	// RVA: 0x759CF0 Offset: 0x758EF0 VA: 0x180759CF0
	private static Shader get_tmProShader() { }
}

// Namespace: 
[Serializable]
public struct UnityUITextMeshProGlyphHelper.TMProSpriteOptions : IEquatable<UnityUITextMeshProGlyphHelper.TMProSpriteOptions> // TypeDefIndex: 2056
{
	// Fields
	[Tooltip("Scale.")]
	[SerializeField]
	private float _scale; // 0x0
	[Tooltip("This value will be multiplied by the Sprite width and height and applied to offset.")]
	[SerializeField]
	private Vector2 _offsetSizeMultiplier; // 0x4
	[Tooltip("An extra offset that is cumulative with Offset Size Multiplier.")]
	[SerializeField]
	private Vector2 _extraOffset; // 0xC
	[Tooltip("This value will be multiplied by the Sprite width applied to X Advance.")]
	[SerializeField]
	private float _xAdvanceWidthMultiplier; // 0x14
	[Tooltip("An extra offset that is cumulative with X Advance Width Multiplier.")]
	[SerializeField]
	private float _extraXAdvance; // 0x18

	// Properties
	public float scale { get; set; }
	public Vector2 offsetSizeMultiplier { get; set; }
	public Vector2 extraOffset { get; set; }
	public float xAdvanceWidthMultiplier { get; set; }
	public float extraXAdvance { get; set; }
	public static UnityUITextMeshProGlyphHelper.TMProSpriteOptions Default { get; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_scale() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_scale(float value) { }

	// RVA: 0x774F90 Offset: 0x774190 VA: 0x180774F90
	public Vector2 get_offsetSizeMultiplier() { }

	// RVA: 0x775120 Offset: 0x774320 VA: 0x180775120
	public void set_offsetSizeMultiplier(Vector2 value) { }

	// RVA: 0x774F70 Offset: 0x774170 VA: 0x180774F70
	public Vector2 get_extraOffset() { }

	// RVA: 0x775110 Offset: 0x774310 VA: 0x180775110
	public void set_extraOffset(Vector2 value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_xAdvanceWidthMultiplier() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_xAdvanceWidthMultiplier(float value) { }

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_extraXAdvance() { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_extraXAdvance(float value) { }

	// RVA: 0x774F40 Offset: 0x774140 VA: 0x180774F40
	public static UnityUITextMeshProGlyphHelper.TMProSpriteOptions get_Default() { }

	// RVA: 0x774D00 Offset: 0x773F00 VA: 0x180774D00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x774E90 Offset: 0x774090 VA: 0x180774E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x774E00 Offset: 0x774000 VA: 0x180774E00 Slot: 4
	public bool Equals(UnityUITextMeshProGlyphHelper.TMProSpriteOptions other) { }

	// RVA: 0x774FB0 Offset: 0x7741B0 VA: 0x180774FB0
	public static bool op_Equality(UnityUITextMeshProGlyphHelper.TMProSpriteOptions a, UnityUITextMeshProGlyphHelper.TMProSpriteOptions b) { }

	// RVA: 0x775060 Offset: 0x774260 VA: 0x180775060
	public static bool op_Inequality(UnityUITextMeshProGlyphHelper.TMProSpriteOptions a, UnityUITextMeshProGlyphHelper.TMProSpriteOptions b) { }
}

// Namespace: 
[Serializable]
public struct UnityUITextMeshProGlyphHelper.SpriteMaterialProperties // TypeDefIndex: 2057
{
	// Fields
	[SerializeField]
	[Tooltip("Sprite material color.")]
	private Color _color; // 0x0

	// Properties
	public Color color { get; set; }
	public static UnityUITextMeshProGlyphHelper.SpriteMaterialProperties Default { get; }

	// Methods

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public Color get_color() { }

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_color(Color value) { }

	// RVA: 0x774940 Offset: 0x773B40 VA: 0x180774940
	public static UnityUITextMeshProGlyphHelper.SpriteMaterialProperties get_Default() { }
}

// Namespace: 
private interface UnityUITextMeshProGlyphHelper.ITMProSprite // TypeDefIndex: 2058
{
	// Properties
	public abstract uint id { get; set; }
	public abstract float width { get; set; }
	public abstract float height { get; set; }
	public abstract float xOffset { get; set; }
	public abstract float yOffset { get; set; }
	public abstract float xAdvance { get; set; }
	public abstract Vector2 position { get; set; }
	public abstract Vector2 pivot { get; set; }
	public abstract float scale { get; set; }
	public abstract string name { get; set; }
	public abstract uint unicode { get; set; }
	public abstract int hashCode { get; set; }
	public abstract Sprite sprite { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_id(uint value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_width();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_width(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_height();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_height(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_xOffset();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_xOffset(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_yOffset();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_yOffset(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_xAdvance();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_xAdvance(float value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector2 get_position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_position(Vector2 value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Vector2 get_pivot();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_pivot(Vector2 value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract float get_scale();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_scale(float value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_name(string value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract uint get_unicode();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_unicode(uint value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_hashCode();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_hashCode(int value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Sprite get_sprite();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_sprite(Sprite value);
}

// Namespace: 
private interface UnityUITextMeshProGlyphHelper.ITMProSpriteAsset // TypeDefIndex: 2059
{
	// Properties
	public abstract int spriteCount { get; }
	public abstract Texture spriteSheet { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_spriteCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Texture get_spriteSheet();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_spriteSheet(Texture value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TMP_SpriteAsset GetSpriteAsset();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Contains(string spriteName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UpdateLookupTables();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Destroy();
}

// Namespace: 
private static class UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper // TypeDefIndex: 2060
{
	// Fields
	private static bool _isVersionSupportedChecked; // 0x0

	// Methods

	// RVA: 0x774950 Offset: 0x773B50 VA: 0x180774950
	private static bool CheckVersionSupported() { }

	// RVA: 0x774B50 Offset: 0x773D50 VA: 0x180774B50
	public static UnityUITextMeshProGlyphHelper.ITMProSprite CreateSprite() { }

	// RVA: 0x7749A0 Offset: 0x773BA0 VA: 0x1807749A0
	public static UnityUITextMeshProGlyphHelper.ITMProSpriteAsset CreateSpriteAsset() { }
}

// Namespace: 
public class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset : UnityUITextMeshProGlyphHelper.ITMProSpriteAsset // TypeDefIndex: 2061
{
	// Fields
	private TMP_SpriteAsset _spriteAsset; // 0x10
	private readonly List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0> _sprites; // 0x18

	// Properties
	public int spriteCount { get; }
	public Texture spriteSheet { get; set; }

	// Methods

	// RVA: 0x7773F0 Offset: 0x7765F0 VA: 0x1807773F0 Slot: 4
	public int get_spriteCount() { }

	// RVA: 0x777430 Offset: 0x776630 VA: 0x180777430 Slot: 5
	public Texture get_spriteSheet() { }

	// RVA: 0x777490 Offset: 0x776690 VA: 0x180777490 Slot: 6
	public void set_spriteSheet(Texture value) { }

	// RVA: 0x7772A0 Offset: 0x7764A0 VA: 0x1807772A0
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x776D10 Offset: 0x775F10 VA: 0x180776D10 Slot: 8
	public UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index) { }

	// RVA: 0x776630 Offset: 0x775830 VA: 0x180776630 Slot: 9
	public void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite) { }

	// RVA: 0x7768D0 Offset: 0x775AD0 VA: 0x1807768D0 Slot: 11
	public void Clear() { }

	// RVA: 0x776AB0 Offset: 0x775CB0 VA: 0x180776AB0 Slot: 10
	public bool Contains(string spriteName) { }

	// RVA: 0x776DB0 Offset: 0x775FB0 VA: 0x180776DB0 Slot: 12
	public void UpdateLookupTables() { }

	// RVA: 0x776C00 Offset: 0x775E00 VA: 0x180776C00 Slot: 13
	public void Destroy() { }
}

// Namespace: 
private class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0 : UnityUITextMeshProGlyphHelper.ITMProSprite // TypeDefIndex: 2062
{
	// Fields
	public TMP_Sprite spriteInfo; // 0x10

	// Properties
	public uint id { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public float xOffset { get; set; }
	public float yOffset { get; set; }
	public float xAdvance { get; set; }
	public Vector2 position { get; set; }
	public Vector2 pivot { get; set; }
	public float scale { get; set; }
	public string name { get; set; }
	public uint unicode { get; set; }
	public int hashCode { get; set; }
	public Sprite sprite { get; set; }

	// Methods

	// RVA: 0x775130 Offset: 0x774330 VA: 0x180775130
	public void .ctor() { }

	// RVA: 0x7751D0 Offset: 0x7743D0 VA: 0x1807751D0 Slot: 4
	public uint get_id() { }

	// RVA: 0x775390 Offset: 0x774590 VA: 0x180775390 Slot: 5
	public void set_id(uint value) { }

	// RVA: 0x7752D0 Offset: 0x7744D0 VA: 0x1807752D0 Slot: 6
	public float get_width() { }

	// RVA: 0x7754B0 Offset: 0x7746B0 VA: 0x1807754B0 Slot: 7
	public void set_width(float value) { }

	// RVA: 0x7751B0 Offset: 0x7743B0 VA: 0x1807751B0 Slot: 8
	public float get_height() { }

	// RVA: 0x775370 Offset: 0x774570 VA: 0x180775370 Slot: 9
	public void set_height(float value) { }

	// RVA: 0x775310 Offset: 0x774510 VA: 0x180775310 Slot: 10
	public float get_xOffset() { }

	// RVA: 0x7754F0 Offset: 0x7746F0 VA: 0x1807754F0 Slot: 11
	public void set_xOffset(float value) { }

	// RVA: 0x775330 Offset: 0x774530 VA: 0x180775330 Slot: 12
	public float get_yOffset() { }

	// RVA: 0x775510 Offset: 0x774710 VA: 0x180775510 Slot: 13
	public void set_yOffset(float value) { }

	// RVA: 0x7752F0 Offset: 0x7744F0 VA: 0x1807752F0 Slot: 14
	public float get_xAdvance() { }

	// RVA: 0x7754D0 Offset: 0x7746D0 VA: 0x1807754D0 Slot: 15
	public void set_xAdvance(float value) { }

	// RVA: 0x775240 Offset: 0x774440 VA: 0x180775240 Slot: 16
	public Vector2 get_position() { }

	// RVA: 0x775410 Offset: 0x774610 VA: 0x180775410 Slot: 17
	public void set_position(Vector2 value) { }

	// RVA: 0x775210 Offset: 0x774410 VA: 0x180775210 Slot: 18
	public Vector2 get_pivot() { }

	// RVA: 0x7753D0 Offset: 0x7745D0 VA: 0x1807753D0 Slot: 19
	public void set_pivot(Vector2 value) { }

	// RVA: 0x775270 Offset: 0x774470 VA: 0x180775270 Slot: 20
	public float get_scale() { }

	// RVA: 0x775450 Offset: 0x774650 VA: 0x180775450 Slot: 21
	public void set_scale(float value) { }

	// RVA: 0x7751F0 Offset: 0x7743F0 VA: 0x1807751F0 Slot: 22
	public string get_name() { }

	// RVA: 0x7753B0 Offset: 0x7745B0 VA: 0x1807753B0 Slot: 23
	public void set_name(string value) { }

	// RVA: 0x7752B0 Offset: 0x7744B0 VA: 0x1807752B0 Slot: 24
	public uint get_unicode() { }

	// RVA: 0x775490 Offset: 0x774690 VA: 0x180775490 Slot: 25
	public void set_unicode(uint value) { }

	// RVA: 0x775190 Offset: 0x774390 VA: 0x180775190 Slot: 26
	public int get_hashCode() { }

	// RVA: 0x775350 Offset: 0x774550 VA: 0x180775350 Slot: 27
	public void set_hashCode(int value) { }

	// RVA: 0x775290 Offset: 0x774490 VA: 0x180775290 Slot: 28
	public Sprite get_sprite() { }

	// RVA: 0x775470 Offset: 0x774670 VA: 0x180775470 Slot: 29
	public void set_sprite(Sprite value) { }
}

// Namespace: 
public class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter // TypeDefIndex: 2063
{
	// Fields
	private const string typeFullName = "TMPro.TMP_SpriteCharacter";
	private readonly object _source; // 0x10
	private readonly PropertyInfo _glyph; // 0x18
	private readonly PropertyInfo _unicode; // 0x20
	private readonly PropertyInfo _name; // 0x28
	private readonly PropertyInfo _scale; // 0x30
	private readonly PropertyInfo _glyphIndex; // 0x38
	private static Type s_type; // 0x0

	// Properties
	public object source { get; }
	public Glyph glyph { get; set; }
	public uint unicode { get; set; }
	public string name { get; set; }
	public float scale { get; set; }
	public uint glyphIndex { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_source() { }

	// RVA: 0x777C50 Offset: 0x776E50 VA: 0x180777C50
	public Glyph get_glyph() { }

	// RVA: 0x777EE0 Offset: 0x7770E0 VA: 0x180777EE0
	public void set_glyph(Glyph value) { }

	// RVA: 0x777DE0 Offset: 0x776FE0 VA: 0x180777DE0
	public uint get_unicode() { }

	// RVA: 0x777FC0 Offset: 0x7771C0 VA: 0x180777FC0
	public void set_unicode(uint value) { }

	// RVA: 0x777CF0 Offset: 0x776EF0 VA: 0x180777CF0
	public string get_name() { }

	// RVA: 0x777F10 Offset: 0x777110 VA: 0x180777F10
	public void set_name(string value) { }

	// RVA: 0x777D60 Offset: 0x776F60 VA: 0x180777D60
	public float get_scale() { }

	// RVA: 0x777F40 Offset: 0x777140 VA: 0x180777F40
	public void set_scale(float value) { }

	// RVA: 0x777BD0 Offset: 0x776DD0 VA: 0x180777BD0
	public uint get_glyphIndex() { }

	// RVA: 0x777E60 Offset: 0x777060 VA: 0x180777E60
	public void set_glyphIndex(uint value) { }

	// RVA: 0x777680 Offset: 0x776880 VA: 0x180777680
	public void .ctor() { }

	// RVA: 0x7774B0 Offset: 0x7766B0 VA: 0x1807774B0
	private static Type GetReflectedType() { }
}

// Namespace: 
public class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph // TypeDefIndex: 2064
{
	// Fields
	private const string typeFullName = "TMPro.TMP_SpriteGlyph";
	private readonly Glyph _source; // 0x10
	private readonly FieldInfo _sprite; // 0x18
	private static Type s_type; // 0x0

	// Properties
	public Glyph source { get; }
	public Sprite sprite { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Glyph get_source() { }

	// RVA: 0x7786A0 Offset: 0x7778A0 VA: 0x1807786A0
	public Sprite get_sprite() { }

	// RVA: 0x778720 Offset: 0x777920 VA: 0x180778720
	public void set_sprite(Sprite value) { }

	// RVA: 0x778260 Offset: 0x777460 VA: 0x180778260
	public void .ctor() { }

	// RVA: 0x778050 Offset: 0x777250 VA: 0x180778050
	private static Type GetReflectedType() { }

	// RVA: 0x778220 Offset: 0x777420 VA: 0x180778220
	private static void Initialize(Glyph glyph) { }
}

// Namespace: 
public class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset : UnityUITextMeshProGlyphHelper.ITMProSpriteAsset // TypeDefIndex: 2065
{
	// Fields
	private readonly PropertyInfo _spriteCharacterTable; // 0x10
	private readonly PropertyInfo _spriteGlyphTable; // 0x18
	private readonly IList _spriteCharacterTableList; // 0x20
	private readonly IList _spriteGlyphTableList; // 0x28
	private readonly List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0> _sprites; // 0x30
	private TMP_SpriteAsset _spriteAsset; // 0x38

	// Properties
	public int spriteCount { get; }
	public Texture spriteSheet { get; set; }

	// Methods

	// RVA: 0x7773B0 Offset: 0x7765B0 VA: 0x1807773B0 Slot: 4
	public int get_spriteCount() { }

	// RVA: 0x777450 Offset: 0x776650 VA: 0x180777450 Slot: 5
	public Texture get_spriteSheet() { }

	// RVA: 0x777470 Offset: 0x776670 VA: 0x180777470 Slot: 6
	public void set_spriteSheet(Texture value) { }

	// RVA: 0x776DD0 Offset: 0x775FD0 VA: 0x180776DD0
	public void .ctor() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	public TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x776C90 Offset: 0x775E90 VA: 0x180776C90 Slot: 8
	public UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index) { }

	// RVA: 0x7763C0 Offset: 0x7755C0 VA: 0x1807763C0 Slot: 9
	public void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite) { }

	// RVA: 0x776830 Offset: 0x775A30 VA: 0x180776830 Slot: 11
	public void Clear() { }

	// RVA: 0x776980 Offset: 0x775B80 VA: 0x180776980 Slot: 10
	public bool Contains(string spriteName) { }

	// RVA: 0x776D90 Offset: 0x775F90 VA: 0x180776D90 Slot: 12
	public void UpdateLookupTables() { }

	// RVA: 0x776B70 Offset: 0x775D70 VA: 0x180776B70 Slot: 13
	public void Destroy() { }
}

// Namespace: 
private class UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0 : UnityUITextMeshProGlyphHelper.ITMProSprite // TypeDefIndex: 2066
{
	// Fields
	private readonly UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph _spriteGlyph; // 0x10
	private readonly UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter _spriteCharacter; // 0x18
	private static Nullable<bool> s_isVersionSupported; // 0x0

	// Properties
	public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph spriteGlyph { get; }
	public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter spriteCharacter { get; }
	public uint id { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public float xOffset { get; set; }
	public float yOffset { get; set; }
	public float xAdvance { get; set; }
	public Vector2 position { get; set; }
	public Vector2 pivot { get; set; }
	public float scale { get; set; }
	public string name { get; set; }
	public uint unicode { get; set; }
	public int hashCode { get; set; }
	public Sprite sprite { get; set; }

	// Methods

	// RVA: 0x7756A0 Offset: 0x7748A0 VA: 0x1807756A0
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph get_spriteGlyph() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter get_spriteCharacter() { }

	// RVA: 0x7757B0 Offset: 0x7749B0 VA: 0x1807757B0 Slot: 4
	public uint get_id() { }

	// RVA: 0x775D80 Offset: 0x774F80 VA: 0x180775D80 Slot: 5
	public void set_id(uint value) { }

	// RVA: 0x775AB0 Offset: 0x774CB0 VA: 0x180775AB0 Slot: 6
	public float get_width() { }

	// RVA: 0x776090 Offset: 0x775290 VA: 0x180776090 Slot: 7
	public void set_width(float value) { }

	// RVA: 0x775750 Offset: 0x774950 VA: 0x180775750 Slot: 8
	public float get_height() { }

	// RVA: 0x775C30 Offset: 0x774E30 VA: 0x180775C30 Slot: 9
	public void set_height(float value) { }

	// RVA: 0x775B70 Offset: 0x774D70 VA: 0x180775B70 Slot: 10
	public float get_xOffset() { }

	// RVA: 0x776280 Offset: 0x775480 VA: 0x180776280 Slot: 11
	public void set_xOffset(float value) { }

	// RVA: 0x775BD0 Offset: 0x774DD0 VA: 0x180775BD0 Slot: 12
	public float get_yOffset() { }

	// RVA: 0x776320 Offset: 0x775520 VA: 0x180776320 Slot: 13
	public void set_yOffset(float value) { }

	// RVA: 0x775B10 Offset: 0x774D10 VA: 0x180775B10 Slot: 14
	public float get_xAdvance() { }

	// RVA: 0x7761E0 Offset: 0x7753E0 VA: 0x1807761E0 Slot: 15
	public void set_xAdvance(float value) { }

	// RVA: 0x775870 Offset: 0x774A70 VA: 0x180775870 Slot: 16
	public Vector2 get_position() { }

	// RVA: 0x775E60 Offset: 0x775060 VA: 0x180775E60 Slot: 17
	public void set_position(Vector2 value) { }

	// RVA: 0x775860 Offset: 0x774A60 VA: 0x180775860 Slot: 18
	public Vector2 get_pivot() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public void set_pivot(Vector2 value) { }

	// RVA: 0x775930 Offset: 0x774B30 VA: 0x180775930 Slot: 20
	public float get_scale() { }

	// RVA: 0x775F40 Offset: 0x775140 VA: 0x180775F40 Slot: 21
	public void set_scale(float value) { }

	// RVA: 0x7757E0 Offset: 0x7749E0 VA: 0x1807757E0 Slot: 22
	public string get_name() { }

	// RVA: 0x775E30 Offset: 0x775030 VA: 0x180775E30 Slot: 23
	public void set_name(string value) { }

	// RVA: 0x775A30 Offset: 0x774C30 VA: 0x180775A30 Slot: 24
	public uint get_unicode() { }

	// RVA: 0x776000 Offset: 0x775200 VA: 0x180776000 Slot: 25
	public void set_unicode(uint value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 26
	public int get_hashCode() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	public void set_hashCode(int value) { }

	// RVA: 0x7759B0 Offset: 0x774BB0 VA: 0x1807759B0 Slot: 28
	public Sprite get_sprite() { }

	// RVA: 0x775FD0 Offset: 0x7751D0 VA: 0x180775FD0 Slot: 29
	public void set_sprite(Sprite value) { }

	// RVA: 0x775530 Offset: 0x774730 VA: 0x180775530
	public static bool CheckVersionSupported() { }
}

// Namespace: 
private enum UnityUITextMeshProGlyphHelper.DisplayType // TypeDefIndex: 2067
{
	// Fields
	public int value__; // 0x0
	public const UnityUITextMeshProGlyphHelper.DisplayType Glyph = 0;
	public const UnityUITextMeshProGlyphHelper.DisplayType Text = 1;
	public const UnityUITextMeshProGlyphHelper.DisplayType GlyphOrText = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityUITextMeshProGlyphHelper.<>c__DisplayClass48_0 // TypeDefIndex: 2068
{
	// Fields
	public Material sourceMaterial; // 0x10
	public UnityUITextMeshProGlyphHelper <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7788D0 Offset: 0x777AD0 VA: 0x1807788D0
	internal void <set_baseSpriteMaterial>b__0(UnityUITextMeshProGlyphHelper.Asset asset) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityUITextMeshProGlyphHelper.<>c__DisplayClass51_0 // TypeDefIndex: 2069
{
	// Fields
	public Material sourceMaterial; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x778A20 Offset: 0x777C20 VA: 0x180778A20
	internal void <set_overrideSpriteMaterialProperties>b__1(UnityUITextMeshProGlyphHelper.Asset asset) { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Text Mesh Pro Glyph Helper")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class UnityUITextMeshProGlyphHelper : MonoBehaviour // TypeDefIndex: 2070
{
	// Fields
	[Tooltip("Enter text into this field and not in the TMPro Text field directly. Text will be parsed for special tags, and the final result will be passed on to the Text Mesh Pro Text component. See the documentation for special tag format.")]
	[SerializeField]
	[TextArea(3, 10)]
	private string _text; // 0x20
	[SerializeField]
	[Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
	private ControllerElementGlyphSelectorOptionsSOBase _options; // 0x28
	[SerializeField]
	[Tooltip("Options that control how Text Mesh Pro displays Sprites.")]
	private UnityUITextMeshProGlyphHelper.TMProSpriteOptions _spriteOptions; // 0x30
	[Tooltip("Optional material for Sprites. If blank, the default material will be used.
Material is instantiated for each Sprite Asset, so making changes to values in the base material later will not affect Sprites. Changing the base material at runtime will copy only certain properties from the new material to Sprite materials.")]
	[SerializeField]
	private Material _baseSpriteMaterial; // 0x50
	[Tooltip("If enabled, local values such as Sprite color will be used instead of the value on the base material.")]
	[SerializeField]
	private bool _overrideSpriteMaterialProperties; // 0x58
	[SerializeField]
	[Tooltip("These properties will override the properties on the Sprite material if Override Sprite Material Properties is enabled.")]
	private UnityUITextMeshProGlyphHelper.SpriteMaterialProperties _spriteMaterialProperties; // 0x5C
	private TextMeshProUGUI _tmProText; // 0x70
	private string _textPrev; // 0x78
	private readonly StringBuilder _processTagSb; // 0x80
	private readonly StringBuilder _tempSb; // 0x88
	private readonly StringBuilder _tempSb2; // 0x90
	private UnityUITextMeshProGlyphHelper.Asset _primaryAsset; // 0x98
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assignedAssets; // 0xA0
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assetsPool; // 0xA8
	private readonly List<ActionElementMap> _tempAems; // 0xB0
	private readonly List<Sprite> _tempGlyphs; // 0xB8
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _dirtyAssets; // 0xC0
	private readonly List<string> _tempKeys; // 0xC8
	private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrTextTemp; // 0xD0
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _currentlyUsedAssets; // 0xD8
	private readonly List<UnityUITextMeshProGlyphHelper.Tag> _currentTags; // 0xE0
	private Dictionary<string, string> _tempStringDictionary; // 0xE8
	private bool _initialized; // 0xF0
	private bool _rebuildRequired; // 0xF1
	private Texture2D _stubTexture; // 0xF8
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> __controllerElementTagPool; // 0x100
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> __actionTagPool; // 0x108
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> __playerTagPool; // 0x110
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> __tagHandlers; // 0x118
	private static string[] __s_displayTypeNames; // 0x0
	private static UnityUITextMeshProGlyphHelper.DisplayType[] __s_displayTypeValues; // 0x8
	private static string[] __s_axisRangeNames; // 0x10
	private static AxisRange[] __s_axisRangeValues; // 0x18

	// Properties
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> controllerElementTagPool { get; }
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> actionTagPool { get; }
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> playerTagPool { get; }
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> tagHandlers { get; }
	public virtual string text { get; set; }
	public virtual ControllerElementGlyphSelectorOptionsSOBase options { get; set; }
	public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions spriteOptions { get; set; }
	public virtual Material baseSpriteMaterial { get; set; }
	public virtual bool overrideSpriteMaterialProperties { get; set; }
	public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties spriteMaterialProperties { get; set; }
	private static int shaderPropertyId_color { get; }
	private static string[] s_displayTypeNames { get; }
	private static UnityUITextMeshProGlyphHelper.DisplayType[] s_displayTypeValues { get; }
	private static string[] s_axisRangeNames { get; }
	private static AxisRange[] s_axisRangeValues { get; }

	// Methods

	// RVA: 0x77E720 Offset: 0x77D920 VA: 0x18077E720
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> get_controllerElementTagPool() { }

	// RVA: 0x77E6A0 Offset: 0x77D8A0 VA: 0x18077E6A0
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> get_actionTagPool() { }

	// RVA: 0x77E7A0 Offset: 0x77D9A0 VA: 0x18077E7A0
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> get_playerTagPool() { }

	// RVA: 0x77EC50 Offset: 0x77DE50 VA: 0x18077EC50
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> get_tagHandlers() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public virtual string get_text() { }

	// RVA: 0x77F530 Offset: 0x77E730 VA: 0x18077F530 Slot: 5
	public virtual void set_text(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	public virtual ControllerElementGlyphSelectorOptionsSOBase get_options() { }

	// RVA: 0x77F010 Offset: 0x77E210 VA: 0x18077F010 Slot: 7
	public virtual void set_options(ControllerElementGlyphSelectorOptionsSOBase value) { }

	// RVA: 0x77EC30 Offset: 0x77DE30 VA: 0x18077EC30 Slot: 8
	public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions get_spriteOptions() { }

	// RVA: 0x77F210 Offset: 0x77E410 VA: 0x18077F210 Slot: 9
	public virtual void set_spriteOptions(UnityUITextMeshProGlyphHelper.TMProSpriteOptions value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 10
	public virtual Material get_baseSpriteMaterial() { }

	// RVA: 0x77EF00 Offset: 0x77E100 VA: 0x18077EF00 Slot: 11
	public virtual void set_baseSpriteMaterial(Material value) { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 12
	public virtual bool get_overrideSpriteMaterialProperties() { }

	// RVA: 0x77F020 Offset: 0x77E220 VA: 0x18077F020 Slot: 13
	public virtual void set_overrideSpriteMaterialProperties(bool value) { }

	// RVA: 0x77EC20 Offset: 0x77DE20 VA: 0x18077EC20 Slot: 14
	public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties get_spriteMaterialProperties() { }

	// RVA: 0x77F180 Offset: 0x77E380 VA: 0x18077F180 Slot: 15
	public virtual void set_spriteMaterialProperties(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties value) { }

	// RVA: 0x77B410 Offset: 0x77A610 VA: 0x18077B410 Slot: 16
	protected virtual void OnEnable() { }

	// RVA: 0x77C9C0 Offset: 0x77BBC0 VA: 0x18077C9C0 Slot: 17
	protected virtual void Start() { }

	// RVA: 0x77E270 Offset: 0x77D470 VA: 0x18077E270 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x77B080 Offset: 0x77A280 VA: 0x18077B080 Slot: 19
	protected virtual void OnDestroy() { }

	// RVA: 0x779F80 Offset: 0x779180 VA: 0x180779F80 Slot: 20
	public virtual void ForceUpdate() { }

	// RVA: 0x77A030 Offset: 0x779230 VA: 0x18077A030 Slot: 21
	protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() { }

	// RVA: 0x77A770 Offset: 0x779970 VA: 0x18077A770
	private bool Initialize() { }

	// RVA: 0x77AB80 Offset: 0x779D80 VA: 0x18077AB80
	private void MainUpdate() { }

	// RVA: 0x77BA00 Offset: 0x77AC00 VA: 0x18077BA00
	private bool ParseText(string text, out string newText) { }

	// RVA: 0x77BBC0 Offset: 0x77ADC0 VA: 0x18077BBC0
	private bool ProcessNextTag(ref string text, StringBuilder sb) { }

	// RVA: 0x77C200 Offset: 0x77B400 VA: 0x18077C200
	private bool ProcessTag_ControllerElement(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x77BFC0 Offset: 0x77B1C0 VA: 0x18077BFC0
	private bool ProcessTag_Action(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x77C430 Offset: 0x77B630 VA: 0x18077C430
	private bool ProcessTag_Player(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x77D130 Offset: 0x77C330 VA: 0x18077D130
	private bool TryCreateTMProString(List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphs, out string result) { }

	// RVA: 0x77D3E0 Offset: 0x77C5E0 VA: 0x18077D3E0
	private bool TryGetControllerElementGlyphsOrText(UnityUITextMeshProGlyphHelper.ControllerElementTag tag, List<UnityUITextMeshProGlyphHelper.GlyphOrText> results) { }

	// RVA: 0x77D330 Offset: 0x77C530 VA: 0x18077D330
	private bool TryGetActionDisplayName(UnityUITextMeshProGlyphHelper.ActionTag tag, out string result) { }

	// RVA: 0x77DF90 Offset: 0x77D190 VA: 0x18077DF90
	private bool TryGetPlayerDisplayName(UnityUITextMeshProGlyphHelper.PlayerTag tag, out string result) { }

	// RVA: 0x77C9D0 Offset: 0x77BBD0 VA: 0x18077C9D0
	private bool TryAssignSprite(Sprite sprite, string key) { }

	// RVA: 0x77C8E0 Offset: 0x77BAE0 VA: 0x18077C8E0
	private void RequireRebuild() { }

	// RVA: 0x779D70 Offset: 0x778F70 VA: 0x180779D70
	private void CreatePrimaryAsset() { }

	// RVA: 0x77A1E0 Offset: 0x7793E0 VA: 0x18077A1E0
	private UnityUITextMeshProGlyphHelper.Asset GetOrCreateAsset(Sprite sprite) { }

	// RVA: 0x779C40 Offset: 0x778E40 VA: 0x180779C40
	private UnityUITextMeshProGlyphHelper.Asset CreateAsset() { }

	// RVA: 0x77C670 Offset: 0x77B870 VA: 0x18077C670
	private void RemoveUnusedAssets() { }

	// RVA: 0x77C8F0 Offset: 0x77BAF0 VA: 0x18077C8F0
	private void SetDirty(UnityUITextMeshProGlyphHelper.Asset asset) { }

	// RVA: 0x779E20 Offset: 0x779020 VA: 0x180779E20
	private void ForEachAsset(Action<UnityUITextMeshProGlyphHelper.Asset> callback) { }

	// RVA: 0x77EBE0 Offset: 0x77DDE0 VA: 0x18077EBE0
	private static int get_shaderPropertyId_color() { }

	// RVA: 0x77EA00 Offset: 0x77DC00 VA: 0x18077EA00
	private static string[] get_s_displayTypeNames() { }

	// RVA: 0x77EAD0 Offset: 0x77DCD0 VA: 0x18077EAD0
	private static UnityUITextMeshProGlyphHelper.DisplayType[] get_s_displayTypeValues() { }

	// RVA: 0x77E820 Offset: 0x77DA20 VA: 0x18077E820
	private static string[] get_s_axisRangeNames() { }

	// RVA: 0x77E8F0 Offset: 0x77DAF0 VA: 0x18077E8F0
	private static AxisRange[] get_s_axisRangeValues() { }

	// RVA: 0x77B540 Offset: 0x77A740 VA: 0x18077B540
	private static void ParseAttributes(string text, int startIndex, int count, StringBuilder sbKey, StringBuilder sbValue, Dictionary<string, string> results) { }

	// RVA: 0x77AA70 Offset: 0x779C70 VA: 0x18077AA70
	private static bool IsValidKeyChar(char c) { }

	// RVA: 0x77AB20 Offset: 0x779D20 VA: 0x18077AB20
	private static bool IsValidTagNameChar(char c) { }

	// RVA: 0x77AAD0 Offset: 0x779CD0 VA: 0x18077AAD0
	private static bool IsValidNonQuotedValueChar(char c) { }

	// RVA: 0x77A8B0 Offset: 0x779AB0 VA: 0x18077A8B0
	private static bool IsEqual(List<UnityUITextMeshProGlyphHelper.GlyphOrText> a, List<UnityUITextMeshProGlyphHelper.GlyphOrText> b) { }

	// RVA: 0x77E310 Offset: 0x77D510 VA: 0x18077E310
	private static void WriteSpriteKey(StringBuilder sb, string key) { }

	// RVA: 0x77DCB0 Offset: 0x77CEB0 VA: 0x18077DCB0
	private static bool TryGetGlyphsOrText(ActionElementMap aem, UnityUITextMeshProGlyphHelper.DisplayType displayType, List<Sprite> glyphs, List<string> keys, List<UnityUITextMeshProGlyphHelper.GlyphOrText> results) { }

	// RVA: 0x77AA50 Offset: 0x779C50 VA: 0x18077AA50
	private static bool IsGlyphAllowed(UnityUITextMeshProGlyphHelper.DisplayType displayType) { }

	// RVA: 0x77AA60 Offset: 0x779C60 VA: 0x18077AA60
	private static bool IsTextAllowed(UnityUITextMeshProGlyphHelper.DisplayType displayType) { }

	// RVA: 0x779960 Offset: 0x778B60 VA: 0x180779960
	private static void CopyMaterialProperties(Material source, Material destination) { }

	// RVA: 0x779B80 Offset: 0x778D80 VA: 0x180779B80
	private static void CopySpriteMaterialPropertiesToMaterial(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties properties, Material material) { }

	// RVA: 0x77E390 Offset: 0x77D590 VA: 0x18077E390
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x77E030 Offset: 0x77D230 VA: 0x18077E030
	private void <set_overrideSpriteMaterialProperties>b__51_0(UnityUITextMeshProGlyphHelper.Asset asset) { }

	[CompilerGenerated]
	// RVA: 0x77E150 Offset: 0x77D350 VA: 0x18077E150
	private void <set_spriteMaterialProperties>b__54_0(UnityUITextMeshProGlyphHelper.Asset asset) { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class ButtonInfo : UIElementInfo // TypeDefIndex: 2071
{
	// Methods

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public enum CalibrationWindow.ButtonIdentifier // TypeDefIndex: 2072
{
	// Fields
	public int value__; // 0x0
	public const CalibrationWindow.ButtonIdentifier Done = 0;
	public const CalibrationWindow.ButtonIdentifier Cancel = 1;
	public const CalibrationWindow.ButtonIdentifier Default = 2;
	public const CalibrationWindow.ButtonIdentifier Calibrate = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class CalibrationWindow.<>c__DisplayClass41_0 // TypeDefIndex: 2073
{
	// Fields
	public int index; // 0x10
	public Button button; // 0x18
	public CalibrationWindow <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x778870 Offset: 0x777A70 VA: 0x180778870
	internal void <SetJoystick>b__0() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class CalibrationWindow : Window // TypeDefIndex: 2074
{
	// Fields
	private const float minSensitivityOtherAxes = 0,1;
	private const float maxDeadzone = 0,8;
	[SerializeField]
	private RectTransform rightContentContainer; // 0x88
	[SerializeField]
	private RectTransform valueDisplayGroup; // 0x90
	[SerializeField]
	private RectTransform calibratedValueMarker; // 0x98
	[SerializeField]
	private RectTransform rawValueMarker; // 0xA0
	[SerializeField]
	private RectTransform calibratedZeroMarker; // 0xA8
	[SerializeField]
	private RectTransform deadzoneArea; // 0xB0
	[SerializeField]
	private Slider deadzoneSlider; // 0xB8
	[SerializeField]
	private Slider zeroSlider; // 0xC0
	[SerializeField]
	private Slider sensitivitySlider; // 0xC8
	[SerializeField]
	private Toggle invertToggle; // 0xD0
	[SerializeField]
	private RectTransform axisScrollAreaContent; // 0xD8
	[SerializeField]
	private Button doneButton; // 0xE0
	[SerializeField]
	private Button calibrateButton; // 0xE8
	[SerializeField]
	private TMP_Text doneButtonLabel; // 0xF0
	[SerializeField]
	private TMP_Text cancelButtonLabel; // 0xF8
	[SerializeField]
	private TMP_Text defaultButtonLabel; // 0x100
	[SerializeField]
	private TMP_Text deadzoneSliderLabel; // 0x108
	[SerializeField]
	private TMP_Text zeroSliderLabel; // 0x110
	[SerializeField]
	private TMP_Text sensitivitySliderLabel; // 0x118
	[SerializeField]
	private TMP_Text invertToggleLabel; // 0x120
	[SerializeField]
	private TMP_Text calibrateButtonLabel; // 0x128
	[SerializeField]
	private GameObject axisButtonPrefab; // 0x130
	private Joystick joystick; // 0x138
	private string origCalibrationData; // 0x140
	private int selectedAxis; // 0x148
	private AxisCalibrationData origSelectedAxisCalibrationData; // 0x150
	private float displayAreaWidth; // 0x188
	private List<Button> axisButtons; // 0x190
	private Dictionary<int, Action<int>> buttonCallbacks; // 0x198
	private int playerId; // 0x1A0
	private RewiredStandaloneInputModule rewiredStandaloneInputModule; // 0x1A8
	private int menuHorizActionId; // 0x1B0
	private int menuVertActionId; // 0x1B4
	private float minSensitivity; // 0x1B8

	// Properties
	private bool axisSelected { get; }
	private AxisCalibration axisCalibration { get; }

	// Methods

	// RVA: 0x75C700 Offset: 0x75B900 VA: 0x18075C700
	private bool get_axisSelected() { }

	// RVA: 0x75C670 Offset: 0x75B870 VA: 0x18075C670
	private AxisCalibration get_axisCalibration() { }

	// RVA: 0x759FB0 Offset: 0x7591B0 VA: 0x180759FB0 Slot: 5
	public override void Initialize(int id, Func<int, bool> isFocusedCallback) { }

	// RVA: 0x75BC90 Offset: 0x75AE90 VA: 0x18075BC90
	public void SetJoystick(int playerId, Joystick joystick) { }

	// RVA: 0x75BBC0 Offset: 0x75ADC0 VA: 0x18075BBC0
	public void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback) { }

	// RVA: 0x759DD0 Offset: 0x758FD0 VA: 0x180759DD0 Slot: 9
	public override void Cancel() { }

	// RVA: 0x75C620 Offset: 0x75B820 VA: 0x18075C620 Slot: 4
	protected override void Update() { }

	// RVA: 0x75ACC0 Offset: 0x759EC0 VA: 0x18075ACC0
	public void OnDone() { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00
	public void OnCancel() { }

	// RVA: 0x75ADC0 Offset: 0x759FC0 VA: 0x18075ADC0
	public void OnRestoreDefault() { }

	// RVA: 0x75AA70 Offset: 0x759C70 VA: 0x18075AA70
	public void OnCalibrate() { }

	// RVA: 0x75AD40 Offset: 0x759F40 VA: 0x18075AD40
	public void OnInvert(bool state) { }

	// RVA: 0x75B090 Offset: 0x75A290 VA: 0x18075B090
	public void OnZeroValueChange(float value) { }

	// RVA: 0x75B000 Offset: 0x75A200 VA: 0x18075B000
	public void OnZeroCancel() { }

	// RVA: 0x75ABC0 Offset: 0x759DC0 VA: 0x18075ABC0
	public void OnDeadzoneValueChange(float value) { }

	// RVA: 0x75AB20 Offset: 0x759D20 VA: 0x18075AB20
	public void OnDeadzoneCancel() { }

	// RVA: 0x75AEC0 Offset: 0x75A0C0 VA: 0x18075AEC0
	public void OnSensitivityValueChange(float value) { }

	// RVA: 0x75AE30 Offset: 0x75A030 VA: 0x18075AE30
	public void OnSensitivityCancel(float value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void OnAxisScrollRectScroll(Vector2 pos) { }

	// RVA: 0x75AA20 Offset: 0x759C20 VA: 0x18075AA20
	private void OnAxisSelected(int axisIndex, Button button) { }

	// RVA: 0x75C610 Offset: 0x75B810 VA: 0x18075C610
	private void UpdateDisplay() { }

	// RVA: 0x75B620 Offset: 0x75A820 VA: 0x18075B620
	private void Redraw() { }

	// RVA: 0x75B640 Offset: 0x75A840 VA: 0x18075B640
	private void RefreshControls() { }

	// RVA: 0x75B2C0 Offset: 0x75A4C0 VA: 0x18075B2C0
	private void RedrawDeadzone() { }

	// RVA: 0x75B1A0 Offset: 0x75A3A0 VA: 0x18075B1A0
	private void RedrawCalibratedZero() { }

	// RVA: 0x75B430 Offset: 0x75A630 VA: 0x18075B430
	private void RedrawValueMarkers() { }

	// RVA: 0x75B850 Offset: 0x75AA50 VA: 0x18075B850
	private void SelectAxis(int index) { }

	// RVA: 0x75C5C0 Offset: 0x75B7C0 VA: 0x18075C5C0 Slot: 6
	public override void TakeInputFocus() { }

	// RVA: 0x75C3B0 Offset: 0x75B5B0 VA: 0x18075C3B0
	private void SetMinSensitivity() { }

	// RVA: 0x75A790 Offset: 0x759990 VA: 0x18075A790
	private bool IsMenuAxis(int actionId, int axisIndex) { }

	// RVA: 0x759E90 Offset: 0x759090 VA: 0x180759E90
	private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value) { }

	// RVA: 0x759F60 Offset: 0x759160 VA: 0x180759F60
	private float GetSliderSensitivity(AxisCalibration axisCalibration) { }

	// RVA: 0x75C500 Offset: 0x75B700 VA: 0x18075C500
	public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue) { }

	// RVA: 0x75B120 Offset: 0x75A320 VA: 0x18075B120
	private static float ProcessPowerValue(float value, float minValue, float maxValue) { }

	// RVA: 0x75C650 Offset: 0x75B850 VA: 0x18075C650
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class CanvasScalerExt : CanvasScaler // TypeDefIndex: 2075
{
	// Methods

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760
	public void ForceRefresh() { }

	// RVA: 0x75C780 Offset: 0x75B980 VA: 0x18075C780
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class CanvasScalerFitter.BreakPoint // TypeDefIndex: 2076
{
	// Fields
	[SerializeField]
	public string name; // 0x10
	[SerializeField]
	public float screenAspectRatio; // 0x18
	[SerializeField]
	public Vector2 referenceResolution; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[RequireComponent(typeof(CanvasScalerExt))]
public class CanvasScalerFitter : MonoBehaviour // TypeDefIndex: 2077
{
	// Fields
	[SerializeField]
	private CanvasScalerFitter.BreakPoint[] breakPoints; // 0x20
	private CanvasScalerExt canvasScaler; // 0x28
	private int screenWidth; // 0x30
	private int screenHeight; // 0x34
	private Action ScreenSizeChanged; // 0x38

	// Methods

	// RVA: 0x75C790 Offset: 0x75B990 VA: 0x18075C790
	private void OnEnable() { }

	// RVA: 0x75C990 Offset: 0x75BB90 VA: 0x18075C990
	private void Update() { }

	// RVA: 0x75C800 Offset: 0x75BA00 VA: 0x18075C800
	private void UpdateSize() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private abstract class ControlMapper.GUIElement // TypeDefIndex: 2078
{
	// Fields
	public readonly GameObject gameObject; // 0x10
	protected readonly TMP_Text text; // 0x18
	public readonly Selectable selectable; // 0x20
	protected readonly UIElementInfo uiElementInfo; // 0x28
	protected bool permanentStateSet; // 0x30
	protected readonly List<ControlMapper.GUIElement> children; // 0x38
	[CompilerGenerated]
	private RectTransform <rectTransform>k__BackingField; // 0x40

	// Properties
	public RectTransform rectTransform { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_rectTransform(RectTransform value) { }

	// RVA: 0x78CC20 Offset: 0x78BE20 VA: 0x18078CC20
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x78CE30 Offset: 0x78C030 VA: 0x18078CE30
	public void .ctor(Selectable selectable, TMP_Text label) { }

	// RVA: 0x78C710 Offset: 0x78B910 VA: 0x18078C710 Slot: 4
	public virtual void SetInteractible(bool state, bool playTransition) { }

	// RVA: 0x78C740 Offset: 0x78B940 VA: 0x18078C740 Slot: 5
	public virtual void SetInteractible(bool state, bool playTransition, bool permanent) { }

	// RVA: 0x78CB00 Offset: 0x78BD00 VA: 0x18078CB00 Slot: 6
	public virtual void SetTextWidth(int value) { }

	// RVA: 0x78C580 Offset: 0x78B780 VA: 0x18078C580 Slot: 7
	public virtual void SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType type, int value) { }

	// RVA: 0x78CA70 Offset: 0x78BC70 VA: 0x18078CA70 Slot: 8
	public virtual void SetLabel(string label) { }

	// RVA: 0x78C180 Offset: 0x78B380 VA: 0x18078C180 Slot: 9
	public virtual string GetLabel() { }

	// RVA: 0x78C0E0 Offset: 0x78B2E0 VA: 0x18078C0E0 Slot: 10
	public virtual void AddChild(ControlMapper.GUIElement child) { }

	// RVA: 0x78C4E0 Offset: 0x78B6E0 VA: 0x18078C4E0
	public void SetElementInfoData(string identifier, int intData) { }

	// RVA: 0x78C450 Offset: 0x78B650 VA: 0x18078C450 Slot: 11
	public virtual void SetActive(bool state) { }

	// RVA: 0x78C230 Offset: 0x78B430 VA: 0x18078C230 Slot: 12
	protected virtual bool Init() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.GUIButton.<>c__DisplayClass7_0 // TypeDefIndex: 2079
{
	// Fields
	public Action<ButtonInfo> callback; // 0x10
	public ControlMapper.GUIButton <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799CB0 Offset: 0x798EB0 VA: 0x180799CB0
	internal void <SetOnClickCallback>b__0() { }
}

// Namespace: 
private class ControlMapper.GUIButton : ControlMapper.GUIElement // TypeDefIndex: 2080
{
	// Properties
	protected Button button { get; }
	public ButtonInfo buttonInfo { get; }

	// Methods

	// RVA: 0x78C060 Offset: 0x78B260 VA: 0x18078C060
	protected Button get_button() { }

	// RVA: 0x78BFE0 Offset: 0x78B1E0 VA: 0x18078BFE0
	public ButtonInfo get_buttonInfo() { }

	// RVA: 0x78BFB0 Offset: 0x78B1B0 VA: 0x18078BFB0
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x78BF80 Offset: 0x78B180 VA: 0x18078BF80
	public void .ctor(Button button, TMP_Text label) { }

	// RVA: 0x78BE50 Offset: 0x78B050 VA: 0x18078BE50
	public void SetButtonInfoData(string identifier, int intData) { }

	// RVA: 0x78BE60 Offset: 0x78B060 VA: 0x18078BE60
	public void SetOnClickCallback(Action<ButtonInfo> callback) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.GUIInputField.<>c__DisplayClass19_0 // TypeDefIndex: 2081
{
	// Fields
	public Action<InputFieldInfo> callback; // 0x10
	public ControlMapper.GUIInputField <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799870 Offset: 0x798A70 VA: 0x180799870
	internal void <SetOnClickCallback>b__0() { }
}

// Namespace: 
private class ControlMapper.GUIInputField : ControlMapper.GUIElement // TypeDefIndex: 2082
{
	// Fields
	[CompilerGenerated]
	private ControlMapper.GUIToggle <toggle>k__BackingField; // 0x48

	// Properties
	protected Button button { get; }
	public InputFieldInfo fieldInfo { get; }
	public bool hasToggle { get; }
	public ControlMapper.GUIToggle toggle { get; set; }
	public int actionElementMapId { get; set; }
	public int controllerId { get; set; }

	// Methods

	// RVA: 0x78D470 Offset: 0x78C670 VA: 0x18078D470
	protected Button get_button() { }

	// RVA: 0x78D580 Offset: 0x78C780 VA: 0x18078D580
	public InputFieldInfo get_fieldInfo() { }

	// RVA: 0x78D600 Offset: 0x78C800 VA: 0x18078D600
	public bool get_hasToggle() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public ControlMapper.GUIToggle get_toggle() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_toggle(ControlMapper.GUIToggle value) { }

	// RVA: 0x78D3E0 Offset: 0x78C5E0 VA: 0x18078D3E0
	public int get_actionElementMapId() { }

	// RVA: 0x78D610 Offset: 0x78C810 VA: 0x18078D610
	public void set_actionElementMapId(int value) { }

	// RVA: 0x78D4F0 Offset: 0x78C6F0 VA: 0x18078D4F0
	public int get_controllerId() { }

	// RVA: 0x78D6B0 Offset: 0x78C8B0 VA: 0x18078D6B0
	public void set_controllerId(int value) { }

	// RVA: 0x78D260 Offset: 0x78C460 VA: 0x18078D260
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x78D310 Offset: 0x78C510 VA: 0x18078D310
	public void .ctor(Button button, TMP_Text label) { }

	// RVA: 0x78CFB0 Offset: 0x78C1B0 VA: 0x18078CFB0
	public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData) { }

	// RVA: 0x78D140 Offset: 0x78C340 VA: 0x18078D140
	public void SetOnClickCallback(Action<InputFieldInfo> callback) { }

	// RVA: 0x78D0C0 Offset: 0x78C2C0 VA: 0x18078D0C0 Slot: 13
	public virtual void SetInteractable(bool state, bool playTransition, bool permanent) { }

	// RVA: 0x78CFA0 Offset: 0x78C1A0 VA: 0x18078CFA0
	public void AddToggle(ControlMapper.GUIToggle toggle) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.GUIToggle.<>c__DisplayClass10_0 // TypeDefIndex: 2083
{
	// Fields
	public Action<ToggleInfo, bool> callback; // 0x10
	public ControlMapper.GUIToggle <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799790 Offset: 0x798990 VA: 0x180799790
	internal void <SetOnSubmitCallback>b__0(BaseEventData data) { }
}

// Namespace: 
private class ControlMapper.GUIToggle : ControlMapper.GUIElement // TypeDefIndex: 2084
{
	// Properties
	protected Toggle toggle { get; }
	public ToggleInfo toggleInfo { get; }
	public int actionElementMapId { get; set; }

	// Methods

	// RVA: 0x78E400 Offset: 0x78D600 VA: 0x18078E400
	protected Toggle get_toggle() { }

	// RVA: 0x78E380 Offset: 0x78D580 VA: 0x18078E380
	public ToggleInfo get_toggleInfo() { }

	// RVA: 0x78E2F0 Offset: 0x78D4F0 VA: 0x18078E2F0
	public int get_actionElementMapId() { }

	// RVA: 0x78E480 Offset: 0x78D680 VA: 0x18078E480
	public void set_actionElementMapId(int value) { }

	// RVA: 0x78BFB0 Offset: 0x78B1B0 VA: 0x18078BFB0
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x78BF80 Offset: 0x78B180 VA: 0x18078BF80
	public void .ctor(Toggle toggle, TMP_Text label) { }

	// RVA: 0x78E140 Offset: 0x78D340 VA: 0x18078E140
	public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData) { }

	// RVA: 0x78DD80 Offset: 0x78CF80 VA: 0x18078DD80
	public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback) { }

	// RVA: 0x78E250 Offset: 0x78D450 VA: 0x18078E250
	public void SetToggleState(bool state) { }
}

// Namespace: 
private class ControlMapper.GUILabel // TypeDefIndex: 2085
{
	// Fields
	[CompilerGenerated]
	private GameObject <gameObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private TMP_Text <text>k__BackingField; // 0x18
	[CompilerGenerated]
	private RectTransform <rectTransform>k__BackingField; // 0x20

	// Properties
	public GameObject gameObject { get; set; }
	private TMP_Text text { get; set; }
	public RectTransform rectTransform { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public GameObject get_gameObject() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_gameObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	private TMP_Text get_text() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_text(TMP_Text value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_rectTransform(RectTransform value) { }

	// RVA: 0x78DC80 Offset: 0x78CE80 VA: 0x18078DC80
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x78DC50 Offset: 0x78CE50 VA: 0x18078DC50
	public void .ctor(TMP_Text label) { }

	// RVA: 0x78DA70 Offset: 0x78CC70 VA: 0x18078DA70
	public void SetSize(int width, int height) { }

	// RVA: 0x78DBC0 Offset: 0x78CDC0 VA: 0x18078DBC0
	public void SetWidth(int width) { }

	// RVA: 0x78D950 Offset: 0x78CB50 VA: 0x18078D950
	public void SetHeight(int height) { }

	// RVA: 0x78D9E0 Offset: 0x78CBE0 VA: 0x18078D9E0
	public void SetLabel(string label) { }

	// RVA: 0x78D8C0 Offset: 0x78CAC0 VA: 0x18078D8C0
	public void SetFontStyle(FontStyles style) { }

	// RVA: 0x78DB30 Offset: 0x78CD30 VA: 0x18078DB30
	public void SetTextAlignment(TextAlignmentOptions alignment) { }

	// RVA: 0x78D830 Offset: 0x78CA30 VA: 0x18078D830
	public void SetActive(bool state) { }

	// RVA: 0x78D740 Offset: 0x78C940 VA: 0x18078D740
	private bool Check() { }
}

// Namespace: 
public enum ControlMapper.MappingSet.ActionListMode // TypeDefIndex: 2086
{
	// Fields
	public int value__; // 0x0
	public const ControlMapper.MappingSet.ActionListMode ActionCategory = 0;
	public const ControlMapper.MappingSet.ActionListMode Action = 1;
}

// Namespace: 
[Serializable]
public class ControlMapper.MappingSet // TypeDefIndex: 2087
{
	// Fields
	[SerializeField]
	[Tooltip("The Map Category that will be displayed to the user for remapping.")]
	private int _mapCategoryId; // 0x10
	[Tooltip("Choose whether you want to list Actions to display for this Map Category by individual Action or by all the Actions in an Action Category.")]
	[SerializeField]
	private ControlMapper.MappingSet.ActionListMode _actionListMode; // 0x14
	[SerializeField]
	private int[] _actionCategoryIds; // 0x18
	[SerializeField]
	private int[] _actionIds; // 0x20
	private IList<int> _actionCategoryIdsReadOnly; // 0x28
	private IList<int> _actionIdsReadOnly; // 0x30

	// Properties
	public int mapCategoryId { get; }
	public ControlMapper.MappingSet.ActionListMode actionListMode { get; }
	public IList<int> actionCategoryIds { get; }
	public IList<int> actionIds { get; }
	public bool isValid { get; }
	public static ControlMapper.MappingSet Default { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_mapCategoryId() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ControlMapper.MappingSet.ActionListMode get_actionListMode() { }

	// RVA: 0x7956F0 Offset: 0x7948F0 VA: 0x1807956F0
	public IList<int> get_actionCategoryIds() { }

	// RVA: 0x795780 Offset: 0x794980 VA: 0x180795780
	public IList<int> get_actionIds() { }

	// RVA: 0x795810 Offset: 0x794A10 VA: 0x180795810
	public bool get_isValid() { }

	// RVA: 0x7955E0 Offset: 0x7947E0 VA: 0x1807955E0
	public void .ctor() { }

	// RVA: 0x795590 Offset: 0x794790 VA: 0x180795590
	private void .ctor(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds) { }

	// RVA: 0x795650 Offset: 0x794850 VA: 0x180795650
	public static ControlMapper.MappingSet get_Default() { }
}

// Namespace: 
[Serializable]
public class ControlMapper.InputBehaviorSettings // TypeDefIndex: 2088
{
	// Fields
	[SerializeField]
	[Tooltip("The Input Behavior that will be displayed to the user for modification.")]
	private int _inputBehaviorId; // 0x10
	[SerializeField]
	[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
	private bool _showJoystickAxisSensitivity; // 0x14
	[SerializeField]
	[Tooltip("If checked, a slider will be displayed so the user can change this value.")]
	private bool _showMouseXYAxisSensitivity; // 0x15
	[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed as the title for the Input Behavior control set. Otherwise, the name field of the InputBehavior will be used.")]
	[SerializeField]
	private string _labelLanguageKey; // 0x18
	[Tooltip("If set to a non-blank value, this name will be displayed above the individual slider control. Otherwise, no name will be displayed.")]
	[SerializeField]
	private string _joystickAxisSensitivityLabelLanguageKey; // 0x20
	[Tooltip("If set to a non-blank value, this key will be used to look up the name in Language to be displayed above the individual slider control. Otherwise, no name will be displayed.")]
	[SerializeField]
	private string _mouseXYAxisSensitivityLabelLanguageKey; // 0x28
	[SerializeField]
	[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
	private Sprite _joystickAxisSensitivityIcon; // 0x30
	[SerializeField]
	[Tooltip("The icon to display next to the slider. Set to none for no icon.")]
	private Sprite _mouseXYAxisSensitivityIcon; // 0x38
	[SerializeField]
	[Tooltip("Minimum value the user is allowed to set for this property.")]
	private float _joystickAxisSensitivityMin; // 0x40
	[SerializeField]
	[Tooltip("Maximum value the user is allowed to set for this property.")]
	private float _joystickAxisSensitivityMax; // 0x44
	[SerializeField]
	[Tooltip("Minimum value the user is allowed to set for this property.")]
	private float _mouseXYAxisSensitivityMin; // 0x48
	[SerializeField]
	[Tooltip("Maximum value the user is allowed to set for this property.")]
	private float _mouseXYAxisSensitivityMax; // 0x4C

	// Properties
	public int inputBehaviorId { get; }
	public bool showJoystickAxisSensitivity { get; }
	public bool showMouseXYAxisSensitivity { get; }
	public string labelLanguageKey { get; }
	public string joystickAxisSensitivityLabelLanguageKey { get; }
	public string mouseXYAxisSensitivityLabelLanguageKey { get; }
	public Sprite joystickAxisSensitivityIcon { get; }
	public Sprite mouseXYAxisSensitivityIcon { get; }
	public float joystickAxisSensitivityMin { get; }
	public float joystickAxisSensitivityMax { get; }
	public float mouseXYAxisSensitivityMin { get; }
	public float mouseXYAxisSensitivityMax { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_inputBehaviorId() { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_showJoystickAxisSensitivity() { }

	// RVA: 0x41AC40 Offset: 0x419E40 VA: 0x18041AC40
	public bool get_showMouseXYAxisSensitivity() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_labelLanguageKey() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_joystickAxisSensitivityLabelLanguageKey() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_mouseXYAxisSensitivityLabelLanguageKey() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Sprite get_joystickAxisSensitivityIcon() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Sprite get_mouseXYAxisSensitivityIcon() { }

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float get_joystickAxisSensitivityMin() { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float get_joystickAxisSensitivityMax() { }

	// RVA: 0x78EC20 Offset: 0x78DE20 VA: 0x18078EC20
	public float get_mouseXYAxisSensitivityMin() { }

	// RVA: 0x6459B0 Offset: 0x644BB0 VA: 0x1806459B0
	public float get_mouseXYAxisSensitivityMax() { }

	// RVA: 0x78EBE0 Offset: 0x78DDE0 VA: 0x18078EBE0
	public bool get_isValid() { }

	// RVA: 0x78EB50 Offset: 0x78DD50 VA: 0x18078EB50
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class ControlMapper.Prefabs // TypeDefIndex: 2089
{
	// Fields
	[SerializeField]
	private GameObject _button; // 0x10
	[SerializeField]
	private GameObject _fitButton; // 0x18
	[SerializeField]
	private GameObject _inputGridLabel; // 0x20
	[SerializeField]
	private GameObject _inputGridHeaderLabel; // 0x28
	[SerializeField]
	private GameObject _inputGridFieldButton; // 0x30
	[SerializeField]
	private GameObject _inputGridFieldInvertToggle; // 0x38
	[SerializeField]
	private GameObject _window; // 0x40
	[SerializeField]
	private GameObject _windowTitleText; // 0x48
	[SerializeField]
	private GameObject _windowContentText; // 0x50
	[SerializeField]
	private GameObject _fader; // 0x58
	[SerializeField]
	private GameObject _calibrationWindow; // 0x60
	[SerializeField]
	private GameObject _inputBehaviorsWindow; // 0x68
	[SerializeField]
	private GameObject _centerStickGraphic; // 0x70
	[SerializeField]
	private GameObject _moveStickGraphic; // 0x78

	// Properties
	public GameObject button { get; }
	public GameObject fitButton { get; }
	public GameObject inputGridLabel { get; }
	public GameObject inputGridHeaderLabel { get; }
	public GameObject inputGridFieldButton { get; }
	public GameObject inputGridFieldInvertToggle { get; }
	public GameObject window { get; }
	public GameObject windowTitleText { get; }
	public GameObject windowContentText { get; }
	public GameObject fader { get; }
	public GameObject calibrationWindow { get; }
	public GameObject inputBehaviorsWindow { get; }
	public GameObject centerStickGraphic { get; }
	public GameObject moveStickGraphic { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public GameObject get_button() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public GameObject get_fitButton() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public GameObject get_inputGridLabel() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public GameObject get_inputGridHeaderLabel() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public GameObject get_inputGridFieldButton() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public GameObject get_inputGridFieldInvertToggle() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public GameObject get_window() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public GameObject get_windowTitleText() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public GameObject get_windowContentText() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public GameObject get_fader() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public GameObject get_calibrationWindow() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public GameObject get_inputBehaviorsWindow() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public GameObject get_centerStickGraphic() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public GameObject get_moveStickGraphic() { }

	// RVA: 0x795930 Offset: 0x794B30 VA: 0x180795930
	public bool Check() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class ControlMapper.References // TypeDefIndex: 2090
{
	// Fields
	[SerializeField]
	private Canvas _canvas; // 0x10
	[SerializeField]
	private CanvasGroup _mainCanvasGroup; // 0x18
	[SerializeField]
	private Transform _mainContent; // 0x20
	[SerializeField]
	private Transform _mainContentInner; // 0x28
	[SerializeField]
	private UIGroup _playersGroup; // 0x30
	[SerializeField]
	private Transform _controllerGroup; // 0x38
	[SerializeField]
	private Transform _controllerGroupLabelGroup; // 0x40
	[SerializeField]
	private UIGroup _controllerSettingsGroup; // 0x48
	[SerializeField]
	private UIGroup _assignedControllersGroup; // 0x50
	[SerializeField]
	private Transform _settingsAndMapCategoriesGroup; // 0x58
	[SerializeField]
	private UIGroup _settingsGroup; // 0x60
	[SerializeField]
	private UIGroup _mapCategoriesGroup; // 0x68
	[SerializeField]
	private Transform _inputGridGroup; // 0x70
	[SerializeField]
	private Transform _inputGridContainer; // 0x78
	[SerializeField]
	private Transform _inputGridHeadersGroup; // 0x80
	[SerializeField]
	private Scrollbar _inputGridVScrollbar; // 0x88
	[SerializeField]
	private ScrollRect _inputGridScrollRect; // 0x90
	[SerializeField]
	private Transform _inputGridInnerGroup; // 0x98
	[SerializeField]
	private TMP_Text _controllerNameLabel; // 0xA0
	[SerializeField]
	private Button _removeControllerButton; // 0xA8
	[SerializeField]
	private Button _assignControllerButton; // 0xB0
	[SerializeField]
	private Button _calibrateControllerButton; // 0xB8
	[SerializeField]
	private Button _doneButton; // 0xC0
	[SerializeField]
	private Button _restoreDefaultsButton; // 0xC8
	[SerializeField]
	private Selectable _defaultSelection; // 0xD0
	[SerializeField]
	private GameObject[] _fixedSelectableUIElements; // 0xD8
	[SerializeField]
	private Image _mainBackgroundImage; // 0xE0
	[CompilerGenerated]
	private LayoutElement <inputGridLayoutElement>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Transform <inputGridActionColumn>k__BackingField; // 0xF0
	[CompilerGenerated]
	private Transform <inputGridKeyboardColumn>k__BackingField; // 0xF8
	[CompilerGenerated]
	private Transform <inputGridMouseColumn>k__BackingField; // 0x100
	[CompilerGenerated]
	private Transform <inputGridControllerColumn>k__BackingField; // 0x108
	[CompilerGenerated]
	private Transform <inputGridHeader1>k__BackingField; // 0x110
	[CompilerGenerated]
	private Transform <inputGridHeader2>k__BackingField; // 0x118
	[CompilerGenerated]
	private Transform <inputGridHeader3>k__BackingField; // 0x120
	[CompilerGenerated]
	private Transform <inputGridHeader4>k__BackingField; // 0x128

	// Properties
	public Canvas canvas { get; }
	public CanvasGroup mainCanvasGroup { get; }
	public Transform mainContent { get; }
	public Transform mainContentInner { get; }
	public UIGroup playersGroup { get; }
	public Transform controllerGroup { get; }
	public Transform controllerGroupLabelGroup { get; }
	public UIGroup controllerSettingsGroup { get; }
	public UIGroup assignedControllersGroup { get; }
	public Transform settingsAndMapCategoriesGroup { get; }
	public UIGroup settingsGroup { get; }
	public UIGroup mapCategoriesGroup { get; }
	public Transform inputGridGroup { get; }
	public Transform inputGridContainer { get; }
	public Transform inputGridHeadersGroup { get; }
	public Scrollbar inputGridVScrollbar { get; }
	public ScrollRect inputGridScrollRect { get; }
	public Transform inputGridInnerGroup { get; }
	public TMP_Text controllerNameLabel { get; }
	public Button removeControllerButton { get; }
	public Button assignControllerButton { get; }
	public Button calibrateControllerButton { get; }
	public Button doneButton { get; }
	public Button restoreDefaultsButton { get; }
	public Selectable defaultSelection { get; }
	public GameObject[] fixedSelectableUIElements { get; }
	public Image mainBackgroundImage { get; }
	public LayoutElement inputGridLayoutElement { get; set; }
	public Transform inputGridActionColumn { get; set; }
	public Transform inputGridKeyboardColumn { get; set; }
	public Transform inputGridMouseColumn { get; set; }
	public Transform inputGridControllerColumn { get; set; }
	public Transform inputGridHeader1 { get; set; }
	public Transform inputGridHeader2 { get; set; }
	public Transform inputGridHeader3 { get; set; }
	public Transform inputGridHeader4 { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Canvas get_canvas() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public CanvasGroup get_mainCanvasGroup() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Transform get_mainContent() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Transform get_mainContentInner() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public UIGroup get_playersGroup() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Transform get_controllerGroup() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Transform get_controllerGroupLabelGroup() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public UIGroup get_controllerSettingsGroup() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public UIGroup get_assignedControllersGroup() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Transform get_settingsAndMapCategoriesGroup() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public UIGroup get_settingsGroup() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public UIGroup get_mapCategoriesGroup() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public Transform get_inputGridGroup() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public Transform get_inputGridContainer() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public Transform get_inputGridHeadersGroup() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public Scrollbar get_inputGridVScrollbar() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public ScrollRect get_inputGridScrollRect() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public Transform get_inputGridInnerGroup() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public TMP_Text get_controllerNameLabel() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public Button get_removeControllerButton() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public Button get_assignControllerButton() { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public Button get_calibrateControllerButton() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public Button get_doneButton() { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public Button get_restoreDefaultsButton() { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public Selectable get_defaultSelection() { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	public GameObject[] get_fixedSelectableUIElements() { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public Image get_mainBackgroundImage() { }

	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	public LayoutElement get_inputGridLayoutElement() { }

	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	public void set_inputGridLayoutElement(LayoutElement value) { }

	[CompilerGenerated]
	// RVA: 0x794CF0 Offset: 0x793EF0 VA: 0x180794CF0
	public Transform get_inputGridActionColumn() { }

	[CompilerGenerated]
	// RVA: 0x7960C0 Offset: 0x7952C0 VA: 0x1807960C0
	public void set_inputGridActionColumn(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0
	public Transform get_inputGridKeyboardColumn() { }

	[CompilerGenerated]
	// RVA: 0x7960D0 Offset: 0x7952D0 VA: 0x1807960D0
	public void set_inputGridKeyboardColumn(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public Transform get_inputGridMouseColumn() { }

	[CompilerGenerated]
	// RVA: 0x7960F0 Offset: 0x7952F0 VA: 0x1807960F0
	public void set_inputGridMouseColumn(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	public Transform get_inputGridControllerColumn() { }

	[CompilerGenerated]
	// RVA: 0x789950 Offset: 0x788B50 VA: 0x180789950
	public void set_inputGridControllerColumn(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public Transform get_inputGridHeader1() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	public void set_inputGridHeader1(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public Transform get_inputGridHeader2() { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	public void set_inputGridHeader2(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	public Transform get_inputGridHeader3() { }

	[CompilerGenerated]
	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0
	public void set_inputGridHeader3(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	public Transform get_inputGridHeader4() { }

	[CompilerGenerated]
	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	public void set_inputGridHeader4(Transform value) { }

	// RVA: 0x795B90 Offset: 0x794D90 VA: 0x180795B90
	public bool Check() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class ControlMapper.InputActionSet // TypeDefIndex: 2091
{
	// Fields
	private int _actionId; // 0x10
	private AxisRange _axisRange; // 0x14

	// Properties
	public int actionId { get; }
	public AxisRange axisRange { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_actionId() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public AxisRange get_axisRange() { }

	// RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	public void .ctor(int actionId, AxisRange axisRange) { }
}

// Namespace: 
private class ControlMapper.InputMapping // TypeDefIndex: 2092
{
	// Fields
	[CompilerGenerated]
	private string <actionName>k__BackingField; // 0x10
	[CompilerGenerated]
	private InputFieldInfo <fieldInfo>k__BackingField; // 0x18
	[CompilerGenerated]
	private ControllerMap <map>k__BackingField; // 0x20
	[CompilerGenerated]
	private ActionElementMap <aem>k__BackingField; // 0x28
	[CompilerGenerated]
	private ControllerType <controllerType>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <controllerId>k__BackingField; // 0x34
	[CompilerGenerated]
	private ControllerPollingInfo <pollingInfo>k__BackingField; // 0x38
	[CompilerGenerated]
	private ModifierKeyFlags <modifierKeyFlags>k__BackingField; // 0x70

	// Properties
	public string actionName { get; set; }
	public InputFieldInfo fieldInfo { get; set; }
	public ControllerMap map { get; set; }
	public ActionElementMap aem { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }
	public ControllerPollingInfo pollingInfo { get; set; }
	public ModifierKeyFlags modifierKeyFlags { get; set; }
	public AxisRange axisRange { get; }
	public string elementName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_actionName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_actionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public InputFieldInfo get_fieldInfo() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_fieldInfo(InputFieldInfo value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ControllerMap get_map() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_map(ControllerMap value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ActionElementMap get_aem() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_aem(ActionElementMap value) { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public ControllerType get_controllerType() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void set_controllerType(ControllerType value) { }

	[CompilerGenerated]
	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_controllerId() { }

	[CompilerGenerated]
	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	private void set_controllerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x7934C0 Offset: 0x7926C0 VA: 0x1807934C0
	public ControllerPollingInfo get_pollingInfo() { }

	[CompilerGenerated]
	// RVA: 0x7934F0 Offset: 0x7926F0 VA: 0x1807934F0
	public void set_pollingInfo(ControllerPollingInfo value) { }

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public ModifierKeyFlags get_modifierKeyFlags() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	public void set_modifierKeyFlags(ModifierKeyFlags value) { }

	// RVA: 0x793310 Offset: 0x792510 VA: 0x180793310
	public AxisRange get_axisRange() { }

	// RVA: 0x793360 Offset: 0x792560 VA: 0x180793360
	public string get_elementName() { }

	// RVA: 0x7932B0 Offset: 0x7924B0 VA: 0x1807932B0
	public void .ctor(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId) { }

	// RVA: 0x793250 Offset: 0x792450 VA: 0x180793250
	public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo) { }

	// RVA: 0x7931F0 Offset: 0x7923F0 VA: 0x1807931F0
	public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x793060 Offset: 0x792260 VA: 0x180793060
	public ElementAssignment ToElementAssignment() { }
}

// Namespace: 
private class ControlMapper.AxisCalibrator // TypeDefIndex: 2093
{
	// Fields
	public AxisCalibrationData data; // 0x10
	public readonly Joystick joystick; // 0x48
	public readonly int axisIndex; // 0x50
	private Controller.Axis axis; // 0x58
	private bool firstRun; // 0x60

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x780880 Offset: 0x77FA80 VA: 0x180780880
	public bool get_isValid() { }

	// RVA: 0x7806F0 Offset: 0x77F8F0 VA: 0x1807806F0
	public void .ctor(Joystick joystick, int axisIndex) { }

	// RVA: 0x780670 Offset: 0x77F870 VA: 0x180780670
	public void RecordMinMax() { }

	// RVA: 0x7806C0 Offset: 0x77F8C0 VA: 0x1807806C0
	public void RecordZero() { }

	// RVA: 0x7805D0 Offset: 0x77F7D0 VA: 0x1807805D0
	public void Commit() { }
}

// Namespace: 
private class ControlMapper.IndexedDictionary.Entry<TKey, TValue> // TypeDefIndex: 2094
{
	// Fields
	public TKey key; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	|-ControlMapper.IndexedDictionary.Entry<int, object>..ctor
	|
	|-RVA: 0x10DDEA0 Offset: 0x10DD0A0 VA: 0x1810DDEA0
	|-ControlMapper.IndexedDictionary.Entry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[DefaultMember("Item")]
private class ControlMapper.IndexedDictionary<TKey, TValue> // TypeDefIndex: 2095
{
	// Fields
	private List<ControlMapper.IndexedDictionary.Entry<TKey, TValue>> list; // 0x0

	// Properties
	public int Count { get; }
	public TValue Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-ControlMapper.IndexedDictionary<int, object>.get_Count
	|
	|-RVA: 0xEE6720 Offset: 0xEE5920 VA: 0x180EE6720
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280DE0 Offset: 0x127FFE0 VA: 0x181280DE0
	|-ControlMapper.IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x1280890 Offset: 0x127FA90 VA: 0x181280890
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281130 Offset: 0x1280330 VA: 0x181281130
	|-ControlMapper.IndexedDictionary<int, object>.get_Item
	|
	|-RVA: 0x1280F20 Offset: 0x1280120 VA: 0x181280F20
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BDB0 Offset: 0x127AFB0 VA: 0x18127BDB0
	|-ControlMapper.IndexedDictionary<int, object>.Get
	|
	|-RVA: 0x127BE50 Offset: 0x127B050 VA: 0x18127BE50
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127FDB0 Offset: 0x127EFB0 VA: 0x18127FDB0
	|-ControlMapper.IndexedDictionary<int, object>.TryGet
	|
	|-RVA: 0x127FE40 Offset: 0x127F040 VA: 0x18127FE40
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGet
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AB00 Offset: 0x1279D00 VA: 0x18127AB00
	|-ControlMapper.IndexedDictionary<int, object>.Add
	|
	|-RVA: 0x127AD30 Offset: 0x1279F30 VA: 0x18127AD30
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C5F0 Offset: 0x127B7F0 VA: 0x18127C5F0
	|-ControlMapper.IndexedDictionary<int, object>.IndexOfKey
	|
	|-RVA: 0x127C1C0 Offset: 0x127B3C0 VA: 0x18127C1C0
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B5E0 Offset: 0x127A7E0 VA: 0x18127B5E0
	|-ControlMapper.IndexedDictionary<int, object>.ContainsKey
	|
	|-RVA: 0x127B3F0 Offset: 0x127A5F0 VA: 0x18127B3F0
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B2D0 Offset: 0x127A4D0 VA: 0x18127B2D0
	|-ControlMapper.IndexedDictionary<int, object>.Clear
	|
	|-RVA: 0x127B2A0 Offset: 0x127A4A0 VA: 0x18127B2A0
	|-ControlMapper.IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/
}

// Namespace: 
private enum ControlMapper.LayoutElementSizeType // TypeDefIndex: 2096
{
	// Fields
	public int value__; // 0x0
	public const ControlMapper.LayoutElementSizeType MinSize = 0;
	public const ControlMapper.LayoutElementSizeType PreferredSize = 1;
}

// Namespace: 
private enum ControlMapper.WindowType // TypeDefIndex: 2097
{
	// Fields
	public int value__; // 0x0
	public const ControlMapper.WindowType None = 0;
	public const ControlMapper.WindowType ChooseJoystick = 1;
	public const ControlMapper.WindowType JoystickAssignmentConflict = 2;
	public const ControlMapper.WindowType ElementAssignment = 3;
	public const ControlMapper.WindowType ElementAssignmentPrePolling = 4;
	public const ControlMapper.WindowType ElementAssignmentPolling = 5;
	public const ControlMapper.WindowType ElementAssignmentResult = 6;
	public const ControlMapper.WindowType ElementAssignmentConflict = 7;
	public const ControlMapper.WindowType Calibration = 8;
	public const ControlMapper.WindowType CalibrateStep1 = 9;
	public const ControlMapper.WindowType CalibrateStep2 = 10;
}

// Namespace: 
private class ControlMapper.InputGrid // TypeDefIndex: 2098
{
	// Fields
	private ControlMapper.InputGridEntryList list; // 0x10
	private List<GameObject> groups; // 0x18

	// Methods

	// RVA: 0x792F70 Offset: 0x792170 VA: 0x180792F70
	public void .ctor() { }

	// RVA: 0x792460 Offset: 0x791660 VA: 0x180792460
	public void AddMapCategory(int mapCategoryId) { }

	// RVA: 0x7920C0 Offset: 0x7912C0 VA: 0x1807920C0
	public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange) { }

	// RVA: 0x791EB0 Offset: 0x7910B0 VA: 0x180791EB0
	public void AddActionCategory(int mapCategoryId, int actionCategoryId) { }

	// RVA: 0x792210 Offset: 0x791410 VA: 0x180792210
	public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer) { }

	// RVA: 0x792350 Offset: 0x791550 VA: 0x180792350
	public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField) { }

	// RVA: 0x792170 Offset: 0x791370 VA: 0x180792170
	public void AddGroup(GameObject group) { }

	// RVA: 0x792010 Offset: 0x791210 VA: 0x180792010
	public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label) { }

	// RVA: 0x791DB0 Offset: 0x790FB0 VA: 0x180791DB0
	public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label) { }

	// RVA: 0x792840 Offset: 0x791A40 VA: 0x180792840
	public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x792A20 Offset: 0x791C20 VA: 0x180792A20
	public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x792910 Offset: 0x791B10 VA: 0x180792910
	public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId) { }

	// RVA: 0x792CC0 Offset: 0x791EC0 VA: 0x180792CC0
	public void SetColumnHeight(int mapCategoryId, float height) { }

	// RVA: 0x792990 Offset: 0x791B90 VA: 0x180792990
	public float GetColumnHeight(int mapCategoryId) { }

	// RVA: 0x792E90 Offset: 0x792090 VA: 0x180792E90
	public void SetFieldsActive(int mapCategoryId, bool state) { }

	// RVA: 0x792D50 Offset: 0x791F50 VA: 0x180792D50
	public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label) { }

	// RVA: 0x792C40 Offset: 0x791E40 VA: 0x180792C40
	public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

	// RVA: 0x792EB0 Offset: 0x7920B0 VA: 0x180792EB0
	public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId) { }

	// RVA: 0x792B60 Offset: 0x791D60 VA: 0x180792B60
	public void InitializeFields(int mapCategoryId) { }

	// RVA: 0x792EE0 Offset: 0x7920E0 VA: 0x180792EE0
	public void Show(int mapCategoryId) { }

	// RVA: 0x792B40 Offset: 0x791D40 VA: 0x180792B40
	public void HideAll() { }

	// RVA: 0x792820 Offset: 0x791A20 VA: 0x180792820
	public void ClearLabels(int mapCategoryId) { }

	// RVA: 0x792710 Offset: 0x791910 VA: 0x180792710
	private void ClearGroups() { }

	// RVA: 0x7925C0 Offset: 0x7917C0 VA: 0x1807925C0
	public void ClearAll() { }
}

// Namespace: 
private class ControlMapper.InputGridEntryList.MapCategoryEntry // TypeDefIndex: 2099
{
	// Fields
	private List<ControlMapper.InputGridEntryList.ActionEntry> _actionList; // 0x10
	private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> _actionCategoryList; // 0x18
	private float _columnHeight; // 0x20

	// Properties
	public List<ControlMapper.InputGridEntryList.ActionEntry> actionList { get; }
	public ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> actionCategoryList { get; }
	public float columnHeight { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<ControlMapper.InputGridEntryList.ActionEntry> get_actionList() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> get_actionCategoryList() { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_columnHeight() { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_columnHeight(float value) { }

	// RVA: 0x7954E0 Offset: 0x7946E0 VA: 0x1807954E0
	public void .ctor() { }

	// RVA: 0x7951B0 Offset: 0x7943B0 VA: 0x1807951B0
	public ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int actionId, AxisRange axisRange) { }

	// RVA: 0x795240 Offset: 0x794440 VA: 0x180795240
	public int IndexOfActionEntry(int actionId, AxisRange axisRange) { }

	// RVA: 0x795100 Offset: 0x794300 VA: 0x180795100
	public bool ContainsActionEntry(int actionId, AxisRange axisRange) { }

	// RVA: 0x794F30 Offset: 0x794130 VA: 0x180794F30
	public ControlMapper.InputGridEntryList.ActionEntry AddAction(InputAction action, AxisRange axisRange) { }

	// RVA: 0x795120 Offset: 0x794320 VA: 0x180795120
	public ControlMapper.InputGridEntryList.ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId) { }

	// RVA: 0x794E40 Offset: 0x794040 VA: 0x180794E40
	public ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategory(int actionCategoryId) { }

	// RVA: 0x795300 Offset: 0x794500 VA: 0x180795300
	public void SetAllActive(bool state) { }
}

// Namespace: 
private class ControlMapper.InputGridEntryList.ActionEntry // TypeDefIndex: 2100
{
	// Fields
	private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet> fieldSets; // 0x10
	public ControlMapper.GUILabel label; // 0x18
	public readonly InputAction action; // 0x20
	public readonly AxisRange axisRange; // 0x28
	public readonly ControlMapper.InputActionSet actionSet; // 0x30

	// Methods

	// RVA: 0x780500 Offset: 0x77F700 VA: 0x180780500
	public void .ctor(InputAction action, AxisRange axisRange) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void SetLabel(ControlMapper.GUILabel label) { }

	// RVA: 0x77FDC0 Offset: 0x77EFC0 VA: 0x18077FDC0
	public bool Matches(int actionId, AxisRange axisRange) { }

	// RVA: 0x77F690 Offset: 0x77E890 VA: 0x18077F690
	public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer) { }

	// RVA: 0x77F7B0 Offset: 0x77E9B0 VA: 0x18077F7B0
	public void AddInputField(ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField) { }

	// RVA: 0x77FAD0 Offset: 0x77ECD0 VA: 0x18077FAD0
	public ControlMapper.GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x77FA00 Offset: 0x77EC00 VA: 0x18077FA00
	public bool Contains(ControllerType controllerType, int fieldId) { }

	// RVA: 0x780080 Offset: 0x77F280 VA: 0x180780080
	public void SetFieldLabel(ControllerType controllerType, int index, string label) { }

	// RVA: 0x77FDF0 Offset: 0x77EFF0 VA: 0x18077FDF0
	public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

	// RVA: 0x780370 Offset: 0x77F570 VA: 0x180780370
	public void SetFixedFieldData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x77FBE0 Offset: 0x77EDE0 VA: 0x18077FBE0
	public void Initialize() { }

	// RVA: 0x77FFB0 Offset: 0x77F1B0 VA: 0x18077FFB0
	public void SetActive(bool state) { }

	// RVA: 0x77F8A0 Offset: 0x77EAA0 VA: 0x18077F8A0
	public void ClearLabels() { }

	// RVA: 0x7801B0 Offset: 0x77F3B0 VA: 0x1807801B0
	public void SetFieldsActive(bool state) { }
}

// Namespace: 
private class ControlMapper.InputGridEntryList.FieldSet // TypeDefIndex: 2101
{
	// Fields
	public readonly GameObject groupContainer; // 0x10
	public readonly ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField> fields; // 0x18

	// Methods

	// RVA: 0x78BDD0 Offset: 0x78AFD0 VA: 0x18078BDD0
	public void .ctor(GameObject groupContainer) { }
}

// Namespace: 
private class ControlMapper.InputGridEntryList.ActionCategoryEntry // TypeDefIndex: 2102
{
	// Fields
	public readonly int actionCategoryId; // 0x10
	public ControlMapper.GUILabel label; // 0x18

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int actionCategoryId) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void SetLabel(ControlMapper.GUILabel label) { }

	// RVA: 0x77F670 Offset: 0x77E870 VA: 0x18077F670
	public void SetActive(bool state) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.InputGridEntryList.<GetActionSets>d__18 : IEnumerable<ControlMapper.InputActionSet>, IEnumerable, IEnumerator<ControlMapper.InputActionSet>, IEnumerator, IDisposable // TypeDefIndex: 2103
{
	// Fields
	private int <>1__state; // 0x10
	private ControlMapper.InputActionSet <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ControlMapper.InputGridEntryList <>4__this; // 0x28
	private int mapCategoryId; // 0x30
	public int <>3__mapCategoryId; // 0x34
	private List<ControlMapper.InputGridEntryList.ActionEntry> <list>5__2; // 0x38
	private int <count>5__3; // 0x40
	private int <i>5__4; // 0x44

	// Properties
	private ControlMapper.InputActionSet System.Collections.Generic.IEnumerator<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x799270 Offset: 0x798470 VA: 0x180799270 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private ControlMapper.InputActionSet System.Collections.Generic.IEnumerator<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x799420 Offset: 0x798620 VA: 0x180799420 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x799380 Offset: 0x798580 VA: 0x180799380 Slot: 4
	private IEnumerator<ControlMapper.InputActionSet> System.Collections.Generic.IEnumerable<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x799380 Offset: 0x798580 VA: 0x180799380 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class ControlMapper.InputGridEntryList // TypeDefIndex: 2104
{
	// Fields
	private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry> entries; // 0x10

	// Methods

	// RVA: 0x791D40 Offset: 0x790F40 VA: 0x180791D40
	public void .ctor() { }

	// RVA: 0x790B70 Offset: 0x78FD70 VA: 0x180790B70
	public void AddMapCategory(int mapCategoryId) { }

	// RVA: 0x790880 Offset: 0x78FA80 VA: 0x180790880
	public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange) { }

	// RVA: 0x790730 Offset: 0x78F930 VA: 0x180790730
	private ControlMapper.InputGridEntryList.ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange) { }

	// RVA: 0x7907D0 Offset: 0x78F9D0 VA: 0x1807907D0
	public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label) { }

	// RVA: 0x7905E0 Offset: 0x78F7E0 VA: 0x1807905E0
	public void AddActionCategory(int mapCategoryId, int actionCategoryId) { }

	// RVA: 0x7903A0 Offset: 0x78F5A0 VA: 0x1807903A0
	private ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId) { }

	// RVA: 0x7904F0 Offset: 0x78F6F0 VA: 0x1807904F0
	public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label) { }

	// RVA: 0x790920 Offset: 0x78FB20 VA: 0x180790920
	public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer) { }

	// RVA: 0x790A60 Offset: 0x78FC60 VA: 0x180790A60
	public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField) { }

	// RVA: 0x790F40 Offset: 0x790140 VA: 0x180790F40
	public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange) { }

	// RVA: 0x790F60 Offset: 0x790160 VA: 0x180790F60
	public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x7916C0 Offset: 0x7908C0 VA: 0x1807916C0
	public void SetColumnHeight(int mapCategoryId, float height) { }

	// RVA: 0x791170 Offset: 0x790370 VA: 0x180791170
	public float GetColumnHeight(int mapCategoryId) { }

	// RVA: 0x791200 Offset: 0x790400 VA: 0x180791200
	public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x791030 Offset: 0x790230 VA: 0x180791030
	private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange) { }

	// RVA: 0x7910D0 Offset: 0x7902D0 VA: 0x1807910D0
	private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange) { }

	[IteratorStateMachine(typeof(ControlMapper.InputGridEntryList.<GetActionSets>d__18))]
	// RVA: 0x7910F0 Offset: 0x7902F0 VA: 0x1807910F0
	public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId) { }

	// RVA: 0x791750 Offset: 0x790950 VA: 0x180791750
	public void SetFieldsActive(int mapCategoryId, bool state) { }

	// RVA: 0x791B80 Offset: 0x790D80 VA: 0x180791B80
	public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label) { }

	// RVA: 0x791650 Offset: 0x790850 VA: 0x180791650
	public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

	// RVA: 0x7919D0 Offset: 0x790BD0 VA: 0x1807919D0
	public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId) { }

	// RVA: 0x791570 Offset: 0x790770 VA: 0x180791570
	public void InitializeFields(int mapCategoryId) { }

	// RVA: 0x791CC0 Offset: 0x790EC0 VA: 0x180791CC0
	public void Show(int mapCategoryId) { }

	// RVA: 0x791320 Offset: 0x790520 VA: 0x180791320
	public void HideAll() { }

	// RVA: 0x790CC0 Offset: 0x78FEC0 VA: 0x180790CC0
	public void ClearLabels(int mapCategoryId) { }

	// RVA: 0x790EF0 Offset: 0x7900F0 VA: 0x180790EF0
	public void Clear() { }
}

// Namespace: 
private class ControlMapper.WindowManager // TypeDefIndex: 2105
{
	// Fields
	private List<Window> windows; // 0x10
	private GameObject windowPrefab; // 0x18
	private Transform parent; // 0x20
	private GameObject fader; // 0x28
	private int idCounter; // 0x30

	// Properties
	public bool isWindowOpen { get; }
	public Window topWindow { get; }

	// Methods

	// RVA: 0x79D630 Offset: 0x79C830 VA: 0x18079D630
	public bool get_isWindowOpen() { }

	// RVA: 0x79D700 Offset: 0x79C900 VA: 0x18079D700
	public Window get_topWindow() { }

	// RVA: 0x79D490 Offset: 0x79C690 VA: 0x18079D490
	public void .ctor(GameObject windowPrefab, GameObject faderPrefab, Transform parent) { }

	// RVA: 0x79D200 Offset: 0x79C400 VA: 0x18079D200
	public Window OpenWindow(string name, int width, int height) { }

	// RVA: 0x79D240 Offset: 0x79C440 VA: 0x18079D240
	public Window OpenWindow(GameObject windowPrefab, string name) { }

	// RVA: 0x79C4A0 Offset: 0x79B6A0 VA: 0x18079C4A0
	public void CloseTop() { }

	// RVA: 0x79C5D0 Offset: 0x79B7D0 VA: 0x18079C5D0
	public void CloseWindow(int windowId) { }

	// RVA: 0x79C600 Offset: 0x79B800 VA: 0x18079C600
	public void CloseWindow(Window window) { }

	// RVA: 0x79C370 Offset: 0x79B570 VA: 0x18079C370
	public void CloseAll() { }

	// RVA: 0x79C1D0 Offset: 0x79B3D0 VA: 0x18079C1D0
	public void CancelAll() { }

	// RVA: 0x79CC70 Offset: 0x79BE70 VA: 0x18079CC70
	public Window GetWindow(int windowId) { }

	// RVA: 0x79D160 Offset: 0x79C360 VA: 0x18079D160
	public bool IsFocused(int windowId) { }

	// RVA: 0x79CA90 Offset: 0x79BC90 VA: 0x18079CA90
	public void Focus(int windowId) { }

	// RVA: 0x79CAC0 Offset: 0x79BCC0 VA: 0x18079CAC0
	public void Focus(Window window) { }

	// RVA: 0x79C830 Offset: 0x79BA30 VA: 0x18079C830
	private void DefocusOtherWindows(int focusedWindowId) { }

	// RVA: 0x79D340 Offset: 0x79C540 VA: 0x18079D340
	private void UpdateFader() { }

	// RVA: 0x79C9F0 Offset: 0x79BBF0 VA: 0x18079C9F0
	private void FocusTopWindow() { }

	// RVA: 0x79D320 Offset: 0x79C520 VA: 0x18079D320
	private void SetFaderActive(bool state) { }

	// RVA: 0x79CF60 Offset: 0x79C160 VA: 0x18079CF60
	private Window InstantiateWindow(string name, int width, int height) { }

	// RVA: 0x79CD80 Offset: 0x79BF80 VA: 0x18079CD80
	private Window InstantiateWindow(string name, GameObject windowPrefab) { }

	// RVA: 0x79C960 Offset: 0x79BB60 VA: 0x18079C960
	private void DestroyWindow(Window window) { }

	// RVA: 0x79CC60 Offset: 0x79BE60 VA: 0x18079CC60
	private int GetNewId() { }

	// RVA: 0x79C2E0 Offset: 0x79B4E0 VA: 0x18079C2E0
	public void ClearCompletely() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass350_0 // TypeDefIndex: 2106
{
	// Fields
	public ControlMapper <>4__this; // 0x10
	public Window window; // 0x18
	public int controllerId; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799920 Offset: 0x798B20 VA: 0x180799920
	internal void <ShowControllerAssignmentConflictWindow>b__0() { }

	// RVA: 0x799950 Offset: 0x798B50 VA: 0x180799950
	internal void <ShowControllerAssignmentConflictWindow>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass351_0 // TypeDefIndex: 2107
{
	// Fields
	public ControlMapper <>4__this; // 0x10
	public Window window; // 0x18
	public InputFieldInfo fieldInfo; // 0x20
	public ControllerMap map; // 0x28
	public ActionElementMap aem; // 0x30
	public string actionName; // 0x38

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799920 Offset: 0x798B20 VA: 0x180799920
	internal void <ShowBeginElementAssignmentReplacementWindow>b__0() { }

	// RVA: 0x7999C0 Offset: 0x798BC0 VA: 0x1807999C0
	internal void <ShowBeginElementAssignmentReplacementWindow>b__1() { }

	// RVA: 0x799A00 Offset: 0x798C00 VA: 0x180799A00
	internal void <ShowBeginElementAssignmentReplacementWindow>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass358_0 // TypeDefIndex: 2108
{
	// Fields
	public ControlMapper <>4__this; // 0x10
	public Window window; // 0x18
	public ElementAssignment assignment; // 0x20
	public bool skipOtherPlayers; // 0x44

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799920 Offset: 0x798B20 VA: 0x180799920
	internal void <ShowElementAssignmentConflictWindow>b__0() { }

	// RVA: 0x799A40 Offset: 0x798C40 VA: 0x180799A40
	internal void <ShowElementAssignmentConflictWindow>b__1() { }

	// RVA: 0x799AB0 Offset: 0x798CB0 VA: 0x180799AB0
	internal void <ShowElementAssignmentConflictWindow>b__2() { }

	// RVA: 0x799B10 Offset: 0x798D10 VA: 0x180799B10
	internal void <ShowElementAssignmentConflictWindow>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass359_0 // TypeDefIndex: 2109
{
	// Fields
	public ControlMapper <>4__this; // 0x10
	public Window window; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799920 Offset: 0x798B20 VA: 0x180799920
	internal void <ShowMouseAssignmentConflictWindow>b__0() { }

	// RVA: 0x799B80 Offset: 0x798D80 VA: 0x180799B80
	internal void <ShowMouseAssignmentConflictWindow>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass412_0 // TypeDefIndex: 2110
{
	// Fields
	public ControlMapper <>4__this; // 0x10
	public Window window; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799920 Offset: 0x798B20 VA: 0x180799920
	internal void <OpenModal>b__0() { }

	// RVA: 0x799BD0 Offset: 0x798DD0 VA: 0x180799BD0
	internal void <OpenModal>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<>c__DisplayClass465_0 // TypeDefIndex: 2111
{
	// Fields
	public ActionElementMap aem; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799C00 Offset: 0x798E00 VA: 0x180799C00
	internal bool <ShowSwapButton>b__0(ElementAssignmentConflictInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapper.<ElementAssignmentConflicts>d__420 : IEnumerable<ElementAssignmentConflictInfo>, IEnumerable, IEnumerator<ElementAssignmentConflictInfo>, IEnumerator, IDisposable // TypeDefIndex: 2112
{
	// Fields
	private int <>1__state; // 0x10
	private ElementAssignmentConflictInfo <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x40
	private Player player; // 0x48
	public Player <>3__player; // 0x50
	private ControlMapper.InputMapping mapping; // 0x58
	public ControlMapper.InputMapping <>3__mapping; // 0x60
	public ControlMapper <>4__this; // 0x68
	private ElementAssignment assignment; // 0x70
	public ElementAssignment <>3__assignment; // 0x94
	private bool skipOtherPlayers; // 0xB8
	public bool <>3__skipOtherPlayers; // 0xB9
	private ElementAssignmentConflictCheck <conflictCheck>5__2; // 0xBC
	private IEnumerator<ElementAssignmentConflictInfo> <>7__wrap2; // 0xF8

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x799240 Offset: 0x798440 VA: 0x180799240
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x799010 Offset: 0x798210 VA: 0x180799010 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7986E0 Offset: 0x7978E0 VA: 0x1807986E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x799120 Offset: 0x798320 VA: 0x180799120
	private void <>m__Finally1() { }

	// RVA: 0x799180 Offset: 0x798380 VA: 0x180799180
	private void <>m__Finally2() { }

	// RVA: 0x7991E0 Offset: 0x7983E0 VA: 0x1807991E0
	private void <>m__Finally3() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 6
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x798F70 Offset: 0x798170 VA: 0x180798F70 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x798FB0 Offset: 0x7981B0 VA: 0x180798FB0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x798E60 Offset: 0x798060 VA: 0x180798E60 Slot: 4
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x798E60 Offset: 0x798060 VA: 0x180798E60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class ControlMapper : MonoBehaviour // TypeDefIndex: 2113
{
	// Fields
	public const int versionMajor = 1;
	public const int versionMinor = 1;
	public const bool usesTMPro = True;
	private const float blockInputOnFocusTimeout = 0,1;
	private const string buttonIdentifier_playerSelection = "PlayerSelection";
	private const string buttonIdentifier_removeController = "RemoveController";
	private const string buttonIdentifier_assignController = "AssignController";
	private const string buttonIdentifier_calibrateController = "CalibrateController";
	private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";
	private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";
	private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";
	private const string buttonIdentifier_done = "Done";
	private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";
	[SerializeField]
	[Tooltip("Must be assigned a Rewired Input Manager scene object or prefab.")]
	private InputManager _rewiredInputManager; // 0x20
	[SerializeField]
	[Tooltip("Set to True to prevent the Game Object from being destroyed when a new scene is loaded.

NOTE: Changing this value from True to False at runtime will have no effect because Object.DontDestroyOnLoad cannot be undone once set.")]
	private bool _dontDestroyOnLoad; // 0x28
	[SerializeField]
	[Tooltip("Open the control mapping screen immediately on start. Mainly used for testing.")]
	private bool _openOnStart; // 0x29
	[SerializeField]
	[Tooltip("The Layout of the Keyboard Maps to be displayed.")]
	private int _keyboardMapDefaultLayout; // 0x2C
	[SerializeField]
	[Tooltip("The Layout of the Mouse Maps to be displayed.")]
	private int _mouseMapDefaultLayout; // 0x30
	[SerializeField]
	[Tooltip("The Layout of the Mouse Maps to be displayed.")]
	private int _joystickMapDefaultLayout; // 0x34
	[SerializeField]
	private ControlMapper.MappingSet[] _mappingSets; // 0x38
	[Tooltip("Display a selectable list of Players. If your game only supports 1 player, you can disable this.")]
	[SerializeField]
	private bool _showPlayers; // 0x40
	[Tooltip("Display the Controller column for input mapping.")]
	[SerializeField]
	private bool _showControllers; // 0x41
	[Tooltip("Display the Keyboard column for input mapping.")]
	[SerializeField]
	private bool _showKeyboard; // 0x42
	[Tooltip("Display the Mouse column for input mapping.")]
	[SerializeField]
	private bool _showMouse; // 0x43
	[SerializeField]
	[Tooltip("The maximum number of controllers allowed to be assigned to a Player. If set to any value other than 1, a selectable list of currently-assigned controller will be displayed to the user. [0 = infinite]")]
	private int _maxControllersPerPlayer; // 0x44
	[SerializeField]
	[Tooltip("Display section labels for each Action Category in the input field grid. Only applies if Action Categories are used to display the Action list.")]
	private bool _showActionCategoryLabels; // 0x48
	[SerializeField]
	[Tooltip("The number of input fields to display for the keyboard. If you want to support alternate mappings on the same device, set this to 2 or more.")]
	private int _keyboardInputFieldCount; // 0x4C
	[SerializeField]
	[Tooltip("The number of input fields to display for the mouse. If you want to support alternate mappings on the same device, set this to 2 or more.")]
	private int _mouseInputFieldCount; // 0x50
	[SerializeField]
	[Tooltip("The number of input fields to display for joysticks. If you want to support alternate mappings on the same device, set this to 2 or more.")]
	private int _controllerInputFieldCount; // 0x54
	[SerializeField]
	[Tooltip("Display a full-axis input assignment field for every axis-type Action in the input field grid. Also displays an invert toggle for the user  to invert the full-axis assignment direction.

*IMPORTANT*: This field is required if you have made any full-axis assignments in the Rewired Input Manager or in saved XML user data. Disabling this field when you have full-axis assignments will result in the inability for the user to view, remove, or modify these full-axis assignments. In addition, these assignments may cause conflicts when trying to remap the same axes to Actions.")]
	private bool _showFullAxisInputFields; // 0x58
	[Tooltip("Display a positive and negative input assignment field for every axis-type Action in the input field grid.

*IMPORTANT*: These fields are required to assign buttons, keyboard keys, and hat or D-Pad directions to axis-type Actions. If you have made any split-axis assignments or button/key/D-pad assignments to axis-type Actions in the Rewired Input Manager or in saved XML user data, disabling these fields will result in the inability for the user to view, remove, or modify these assignments. In addition, these assignments may cause conflicts when trying to remap the same elements to Actions.")]
	[SerializeField]
	private bool _showSplitAxisInputFields; // 0x59
	[Tooltip("Show glyphs if available. Glyph Provider must be configured for glyphs to be displayed. See Glyphs documentation for more information.")]
	[SerializeField]
	private bool _showGlyphs; // 0x5A
	[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to make the conflicting assignment anyway.")]
	[SerializeField]
	private bool _allowElementAssignmentConflicts; // 0x5B
	[SerializeField]
	[Tooltip("If enabled, when an element assignment conflict is found, an option will be displayed that allows the user to swap conflicting assignments. This only applies to the first conflicting assignment found. This option will not be displayed if allowElementAssignmentConflicts is true.")]
	private bool _allowElementAssignmentSwap; // 0x5C
	[Tooltip("The width in relative pixels of the Action label column.")]
	[SerializeField]
	private int _actionLabelWidth; // 0x60
	[SerializeField]
	[Tooltip("The width in relative pixels of the Keyboard column.")]
	private int _keyboardColMaxWidth; // 0x64
	[SerializeField]
	[Tooltip("The width in relative pixels of the Mouse column.")]
	private int _mouseColMaxWidth; // 0x68
	[SerializeField]
	[Tooltip("The width in relative pixels of the Controller column.")]
	private int _controllerColMaxWidth; // 0x6C
	[Tooltip("The height in relative pixels of the input grid button rows.")]
	[SerializeField]
	private int _inputRowHeight; // 0x70
	[SerializeField]
	[Tooltip("The padding of the input grid button rows.")]
	private RectOffset _inputRowPadding; // 0x78
	[Tooltip("The width in relative pixels of spacing between input fields in a single column.")]
	[SerializeField]
	private int _inputRowFieldSpacing; // 0x80
	[Tooltip("The width in relative pixels of spacing between columns.")]
	[SerializeField]
	private int _inputColumnSpacing; // 0x84
	[Tooltip("The height in relative pixels of the space between Action Category sections. Only applicable if Show Action Category Labels is checked.")]
	[SerializeField]
	private int _inputRowCategorySpacing; // 0x88
	[Tooltip("The width in relative pixels of the invert toggle buttons.")]
	[SerializeField]
	private int _invertToggleWidth; // 0x8C
	[Tooltip("The width in relative pixels of generated popup windows.")]
	[SerializeField]
	private int _defaultWindowWidth; // 0x90
	[Tooltip("The height in relative pixels of generated popup windows.")]
	[SerializeField]
	private int _defaultWindowHeight; // 0x94
	[Tooltip("The time in seconds the user has to press an element on a controller when assigning a controller to a Player. If this time elapses with no user input a controller, the assignment will be canceled.")]
	[SerializeField]
	private float _controllerAssignmentTimeout; // 0x98
	[Tooltip("The time in seconds the user has to press an element on a controller while waiting for axes to be centered before assigning input.")]
	[SerializeField]
	private float _preInputAssignmentTimeout; // 0x9C
	[SerializeField]
	[Tooltip("The time in seconds the user has to press an element on a controller when assigning input. If this time elapses with no user input on the target controller, the assignment will be canceled.")]
	private float _inputAssignmentTimeout; // 0xA0
	[SerializeField]
	[Tooltip("The time in seconds the user has to press an element on a controller during calibration.")]
	private float _axisCalibrationTimeout; // 0xA4
	[SerializeField]
	[Tooltip("If checked, mouse X-axis movement will always be ignored during input assignment. Check this if you don't want the horizontal mouse axis to be user-assignable to any Actions.")]
	private bool _ignoreMouseXAxisAssignment; // 0xA8
	[Tooltip("If checked, mouse Y-axis movement will always be ignored during input assignment. Check this if you don't want the vertical mouse axis to be user-assignable to any Actions.")]
	[SerializeField]
	private bool _ignoreMouseYAxisAssignment; // 0xA9
	[SerializeField]
	[Tooltip("An Action that when activated will alternately close or open the main screen as long as no popup windows are open.")]
	private int _screenToggleAction; // 0xAC
	[SerializeField]
	[Tooltip("An Action that when activated will open the main screen if it is closed.")]
	private int _screenOpenAction; // 0xB0
	[SerializeField]
	[Tooltip("An Action that when activated will close the main screen as long as no popup windows are open.")]
	private int _screenCloseAction; // 0xB4
	[Tooltip("An Action that when activated will cancel and close any open popup window. Use with care because the element assigned to this Action can never be mapped by the user (because it would just cancel his assignment).")]
	[SerializeField]
	private int _universalCancelAction; // 0xB8
	[Tooltip("If enabled, Universal Cancel will also close the main screen if pressed when no windows are open.")]
	[SerializeField]
	private bool _universalCancelClosesScreen; // 0xBC
	[SerializeField]
	[Tooltip("If checked, controls will be displayed which will allow the user to customize certain Input Behavior settings.")]
	private bool _showInputBehaviorSettings; // 0xBD
	[SerializeField]
	[Tooltip("Customizable settings for user-modifiable Input Behaviors. This can be used for settings like Mouse Look Sensitivity.")]
	private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings; // 0xC0
	[SerializeField]
	[Tooltip("If enabled, UI elements will be themed based on the settings in Theme Settings.")]
	private bool _useThemeSettings; // 0xC8
	[Tooltip("Must be assigned a ThemeSettings object. Used to theme UI elements.")]
	[SerializeField]
	private ThemeSettings _themeSettings; // 0xD0
	[SerializeField]
	[Tooltip("Must be assigned a LanguageData object. Used to retrieve language entries for UI elements.")]
	private LanguageDataBase _language; // 0xD8
	[SerializeField]
	[Tooltip("A list of prefabs. You should not have to modify this.")]
	private ControlMapper.Prefabs prefabs; // 0xE0
	[SerializeField]
	[Tooltip("A list of references to elements in the hierarchy. You should not have to modify this.")]
	private ControlMapper.References references; // 0xE8
	[SerializeField]
	[Tooltip("Show the label for the Players button group?")]
	private bool _showPlayersGroupLabel; // 0xF0
	[SerializeField]
	[Tooltip("Show the label for the Controller button group?")]
	private bool _showControllerGroupLabel; // 0xF1
	[SerializeField]
	[Tooltip("Show the label for the Assigned Controllers button group?")]
	private bool _showAssignedControllersGroupLabel; // 0xF2
	[SerializeField]
	[Tooltip("Show the label for the Settings button group?")]
	private bool _showSettingsGroupLabel; // 0xF3
	[SerializeField]
	[Tooltip("Show the label for the Map Categories button group?")]
	private bool _showMapCategoriesGroupLabel; // 0xF4
	[SerializeField]
	[Tooltip("Show the label for the current controller name?")]
	private bool _showControllerNameLabel; // 0xF5
	[SerializeField]
	[Tooltip("Show the Assigned Controllers group? If joystick auto-assignment is enabled in the Rewired Input Manager and the max joysticks per player is set to any value other than 1, the Assigned Controllers group will always be displayed.")]
	private bool _showAssignedControllers; // 0xF6
	private Action _ScreenClosedEvent; // 0xF8
	private Action _ScreenOpenedEvent; // 0x100
	private Action _PopupWindowOpenedEvent; // 0x108
	private Action _PopupWindowClosedEvent; // 0x110
	private Action _InputPollingStartedEvent; // 0x118
	private Action _InputPollingEndedEvent; // 0x120
	private Action _ThemeAppliedEvent; // 0x128
	[SerializeField]
	[Tooltip("Event sent when the UI is closed.")]
	private UnityEvent _onScreenClosed; // 0x130
	[SerializeField]
	[Tooltip("Event sent when the UI is opened.")]
	private UnityEvent _onScreenOpened; // 0x138
	[SerializeField]
	[Tooltip("Event sent when a popup window is closed.")]
	private UnityEvent _onPopupWindowClosed; // 0x140
	[SerializeField]
	[Tooltip("Event sent when a popup window is opened.")]
	private UnityEvent _onPopupWindowOpened; // 0x148
	[Tooltip("Event sent when polling for input has started.")]
	[SerializeField]
	private UnityEvent _onInputPollingStarted; // 0x150
	[Tooltip("Event sent when polling for input has ended.")]
	[SerializeField]
	private UnityEvent _onInputPollingEnded; // 0x158
	private static ControlMapper Instance; // 0x0
	private bool initialized; // 0x160
	private int playerCount; // 0x164
	private ControlMapper.InputGrid inputGrid; // 0x168
	private ControlMapper.WindowManager windowManager; // 0x170
	private int currentPlayerId; // 0x178
	private int currentMapCategoryId; // 0x17C
	private List<ControlMapper.GUIButton> playerButtons; // 0x180
	private List<ControlMapper.GUIButton> mapCategoryButtons; // 0x188
	private List<ControlMapper.GUIButton> assignedControllerButtons; // 0x190
	private ControlMapper.GUIButton assignedControllerButtonsPlaceholder; // 0x198
	private List<GameObject> miscInstantiatedObjects; // 0x1A0
	private GameObject canvas; // 0x1A8
	private GameObject lastUISelection; // 0x1B0
	private int currentJoystickId; // 0x1B8
	private float blockInputOnFocusEndTime; // 0x1BC
	private bool isPollingForInput; // 0x1C0
	private List<ThemedElement> themedElements; // 0x1C8
	private ControlMapper.InputMapping pendingInputMapping; // 0x1D0
	private ControlMapper.AxisCalibrator pendingAxisCalibration; // 0x1D8
	private Action<InputFieldInfo> inputFieldActivatedDelegate; // 0x1E0
	private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate; // 0x1E8
	private Action _restoreDefaultsDelegate; // 0x1F0

	// Properties
	public InputManager rewiredInputManager { get; set; }
	public bool dontDestroyOnLoad { get; set; }
	public int keyboardMapDefaultLayout { get; set; }
	public int mouseMapDefaultLayout { get; set; }
	public int joystickMapDefaultLayout { get; set; }
	public bool showPlayers { get; set; }
	public bool showControllers { get; set; }
	public bool showKeyboard { get; set; }
	public bool showMouse { get; set; }
	public int maxControllersPerPlayer { get; set; }
	public bool showActionCategoryLabels { get; set; }
	public int keyboardInputFieldCount { get; set; }
	public int mouseInputFieldCount { get; set; }
	public int controllerInputFieldCount { get; set; }
	public bool showFullAxisInputFields { get; set; }
	public bool showSplitAxisInputFields { get; set; }
	public bool showGlyphs { get; set; }
	public bool allowElementAssignmentConflicts { get; set; }
	public bool allowElementAssignmentSwap { get; set; }
	public int actionLabelWidth { get; set; }
	public int keyboardColMaxWidth { get; set; }
	public int mouseColMaxWidth { get; set; }
	public int controllerColMaxWidth { get; set; }
	public int inputRowHeight { get; set; }
	public int inputColumnSpacing { get; set; }
	public int inputRowCategorySpacing { get; set; }
	public int invertToggleWidth { get; set; }
	public int defaultWindowWidth { get; set; }
	public int defaultWindowHeight { get; set; }
	public float controllerAssignmentTimeout { get; set; }
	public float preInputAssignmentTimeout { get; set; }
	public float inputAssignmentTimeout { get; set; }
	public float axisCalibrationTimeout { get; set; }
	public bool ignoreMouseXAxisAssignment { get; set; }
	public bool ignoreMouseYAxisAssignment { get; set; }
	public bool universalCancelClosesScreen { get; set; }
	public bool showInputBehaviorSettings { get; set; }
	public bool useThemeSettings { get; set; }
	public ThemeSettings themeSettings { get; set; }
	public LanguageDataBase language { get; set; }
	public bool showPlayersGroupLabel { get; set; }
	public bool showControllerGroupLabel { get; set; }
	public bool showAssignedControllersGroupLabel { get; set; }
	public bool showSettingsGroupLabel { get; set; }
	public bool showMapCategoriesGroupLabel { get; set; }
	public bool showControllerNameLabel { get; set; }
	public bool showAssignedControllers { get; set; }
	public Action restoreDefaultsDelegate { get; set; }
	public bool isOpen { get; }
	private bool isFocused { get; }
	private bool inputAllowed { get; }
	private int inputGridColumnCount { get; }
	private int inputGridWidth { get; }
	private Player currentPlayer { get; }
	private InputCategory currentMapCategory { get; }
	private ControlMapper.MappingSet currentMappingSet { get; }
	private Joystick currentJoystick { get; }
	private bool isJoystickSelected { get; }
	private GameObject currentUISelection { get; }
	private bool showSettings { get; }
	private bool showMapCategories { get; }
	public static ControlMapper current { get; }

	// Methods

	// RVA: 0x771CC0 Offset: 0x770EC0 VA: 0x180771CC0
	public void add_ScreenClosedEvent(Action value) { }

	// RVA: 0x772890 Offset: 0x771A90 VA: 0x180772890
	public void remove_ScreenClosedEvent(Action value) { }

	// RVA: 0x771D60 Offset: 0x770F60 VA: 0x180771D60
	public void add_ScreenOpenedEvent(Action value) { }

	// RVA: 0x772930 Offset: 0x771B30 VA: 0x180772930
	public void remove_ScreenOpenedEvent(Action value) { }

	// RVA: 0x771B80 Offset: 0x770D80 VA: 0x180771B80
	public void add_PopupWindowClosedEvent(Action value) { }

	// RVA: 0x772750 Offset: 0x771950 VA: 0x180772750
	public void remove_PopupWindowClosedEvent(Action value) { }

	// RVA: 0x771C20 Offset: 0x770E20 VA: 0x180771C20
	public void add_PopupWindowOpenedEvent(Action value) { }

	// RVA: 0x7727F0 Offset: 0x7719F0 VA: 0x1807727F0
	public void remove_PopupWindowOpenedEvent(Action value) { }

	// RVA: 0x771AE0 Offset: 0x770CE0 VA: 0x180771AE0
	public void add_InputPollingStartedEvent(Action value) { }

	// RVA: 0x7726B0 Offset: 0x7718B0 VA: 0x1807726B0
	public void remove_InputPollingStartedEvent(Action value) { }

	// RVA: 0x771A40 Offset: 0x770C40 VA: 0x180771A40
	public void add_InputPollingEndedEvent(Action value) { }

	// RVA: 0x772610 Offset: 0x771810 VA: 0x180772610
	public void remove_InputPollingEndedEvent(Action value) { }

	// RVA: 0x771EC0 Offset: 0x7710C0 VA: 0x180771EC0
	public void add_onScreenClosed(UnityAction value) { }

	// RVA: 0x772A90 Offset: 0x771C90 VA: 0x180772A90
	public void remove_onScreenClosed(UnityAction value) { }

	// RVA: 0x771EF0 Offset: 0x7710F0 VA: 0x180771EF0
	public void add_onScreenOpened(UnityAction value) { }

	// RVA: 0x772AC0 Offset: 0x771CC0 VA: 0x180772AC0
	public void remove_onScreenOpened(UnityAction value) { }

	// RVA: 0x771E60 Offset: 0x771060 VA: 0x180771E60
	public void add_onPopupWindowClosed(UnityAction value) { }

	// RVA: 0x772A30 Offset: 0x771C30 VA: 0x180772A30
	public void remove_onPopupWindowClosed(UnityAction value) { }

	// RVA: 0x771E90 Offset: 0x771090 VA: 0x180771E90
	public void add_onPopupWindowOpened(UnityAction value) { }

	// RVA: 0x772A60 Offset: 0x771C60 VA: 0x180772A60
	public void remove_onPopupWindowOpened(UnityAction value) { }

	// RVA: 0x771E30 Offset: 0x771030 VA: 0x180771E30
	public void add_onInputPollingStarted(UnityAction value) { }

	// RVA: 0x772A00 Offset: 0x771C00 VA: 0x180772A00
	public void remove_onInputPollingStarted(UnityAction value) { }

	// RVA: 0x771E00 Offset: 0x771000 VA: 0x180771E00
	public void add_onInputPollingEnded(UnityAction value) { }

	// RVA: 0x7729D0 Offset: 0x771BD0 VA: 0x1807729D0
	public void remove_onInputPollingEnded(UnityAction value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public InputManager get_rewiredInputManager() { }

	// RVA: 0x772EB0 Offset: 0x7720B0 VA: 0x180772EB0
	public void set_rewiredInputManager(InputManager value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_dontDestroyOnLoad() { }

	// RVA: 0x772BC0 Offset: 0x771DC0 VA: 0x180772BC0
	public void set_dontDestroyOnLoad(bool value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_keyboardMapDefaultLayout() { }

	// RVA: 0x772D50 Offset: 0x771F50 VA: 0x180772D50
	public void set_keyboardMapDefaultLayout(int value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_mouseMapDefaultLayout() { }

	// RVA: 0x772E70 Offset: 0x772070 VA: 0x180772E70
	public void set_mouseMapDefaultLayout(int value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_joystickMapDefaultLayout() { }

	// RVA: 0x772CF0 Offset: 0x771EF0 VA: 0x180772CF0
	public void set_joystickMapDefaultLayout(int value) { }

	// RVA: 0x772520 Offset: 0x771720 VA: 0x180772520
	public bool get_showPlayers() { }

	// RVA: 0x773070 Offset: 0x772270 VA: 0x180773070
	public void set_showPlayers(bool value) { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_showControllers() { }

	// RVA: 0x772F70 Offset: 0x772170 VA: 0x180772F70
	public void set_showControllers(bool value) { }

	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0
	public bool get_showKeyboard() { }

	// RVA: 0x772FF0 Offset: 0x7721F0 VA: 0x180772FF0
	public void set_showKeyboard(bool value) { }

	// RVA: 0x772500 Offset: 0x771700 VA: 0x180772500
	public bool get_showMouse() { }

	// RVA: 0x773030 Offset: 0x772230 VA: 0x180773030
	public void set_showMouse(bool value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public int get_maxControllersPerPlayer() { }

	// RVA: 0x772E10 Offset: 0x772010 VA: 0x180772E10
	public void set_maxControllersPerPlayer(int value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_showActionCategoryLabels() { }

	// RVA: 0x772ED0 Offset: 0x7720D0 VA: 0x180772ED0
	public void set_showActionCategoryLabels(bool value) { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public int get_keyboardInputFieldCount() { }

	// RVA: 0x772D30 Offset: 0x771F30 VA: 0x180772D30
	public void set_keyboardInputFieldCount(int value) { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int get_mouseInputFieldCount() { }

	// RVA: 0x772E50 Offset: 0x772050 VA: 0x180772E50
	public void set_mouseInputFieldCount(int value) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_controllerInputFieldCount() { }

	// RVA: 0x772B60 Offset: 0x771D60 VA: 0x180772B60
	public void set_controllerInputFieldCount(int value) { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_showFullAxisInputFields() { }

	// RVA: 0x772F90 Offset: 0x772190 VA: 0x180772F90
	public void set_showFullAxisInputFields(bool value) { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	public bool get_showSplitAxisInputFields() { }

	// RVA: 0x7730B0 Offset: 0x7722B0 VA: 0x1807730B0
	public void set_showSplitAxisInputFields(bool value) { }

	// RVA: 0x7724B0 Offset: 0x7716B0 VA: 0x1807724B0
	public bool get_showGlyphs() { }

	// RVA: 0x772FB0 Offset: 0x7721B0 VA: 0x180772FB0
	public void set_showGlyphs(bool value) { }

	// RVA: 0x771F20 Offset: 0x771120 VA: 0x180771F20
	public bool get_allowElementAssignmentConflicts() { }

	// RVA: 0x772B10 Offset: 0x771D10 VA: 0x180772B10
	public void set_allowElementAssignmentConflicts(bool value) { }

	// RVA: 0x526D00 Offset: 0x525F00 VA: 0x180526D00
	public bool get_allowElementAssignmentSwap() { }

	// RVA: 0x526E00 Offset: 0x526000 VA: 0x180526E00
	public void set_allowElementAssignmentSwap(bool value) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_actionLabelWidth() { }

	// RVA: 0x772AF0 Offset: 0x771CF0 VA: 0x180772AF0
	public void set_actionLabelWidth(int value) { }

	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public int get_keyboardColMaxWidth() { }

	// RVA: 0x772D10 Offset: 0x771F10 VA: 0x180772D10
	public void set_keyboardColMaxWidth(int value) { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public int get_mouseColMaxWidth() { }

	// RVA: 0x772E30 Offset: 0x772030 VA: 0x180772E30
	public void set_mouseColMaxWidth(int value) { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public int get_controllerColMaxWidth() { }

	// RVA: 0x772B40 Offset: 0x771D40 VA: 0x180772B40
	public void set_controllerColMaxWidth(int value) { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_inputRowHeight() { }

	// RVA: 0x772CB0 Offset: 0x771EB0 VA: 0x180772CB0
	public void set_inputRowHeight(int value) { }

	// RVA: 0x772260 Offset: 0x771460 VA: 0x180772260
	public int get_inputColumnSpacing() { }

	// RVA: 0x772C70 Offset: 0x771E70 VA: 0x180772C70
	public void set_inputColumnSpacing(int value) { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int get_inputRowCategorySpacing() { }

	// RVA: 0x772C90 Offset: 0x771E90 VA: 0x180772C90
	public void set_inputRowCategorySpacing(int value) { }

	// RVA: 0x772310 Offset: 0x771510 VA: 0x180772310
	public int get_invertToggleWidth() { }

	// RVA: 0x772CD0 Offset: 0x771ED0 VA: 0x180772CD0
	public void set_invertToggleWidth(int value) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public int get_defaultWindowWidth() { }

	// RVA: 0x772BA0 Offset: 0x771DA0 VA: 0x180772BA0
	public void set_defaultWindowWidth(int value) { }

	// RVA: 0x772200 Offset: 0x771400 VA: 0x180772200
	public int get_defaultWindowHeight() { }

	// RVA: 0x772B80 Offset: 0x771D80 VA: 0x180772B80
	public void set_defaultWindowHeight(int value) { }

	// RVA: 0x771F40 Offset: 0x771140 VA: 0x180771F40
	public float get_controllerAssignmentTimeout() { }

	// RVA: 0x772B30 Offset: 0x771D30 VA: 0x180772B30
	public void set_controllerAssignmentTimeout(float value) { }

	// RVA: 0x772440 Offset: 0x771640 VA: 0x180772440
	public float get_preInputAssignmentTimeout() { }

	// RVA: 0x772E90 Offset: 0x772090 VA: 0x180772E90
	public void set_preInputAssignmentTimeout(float value) { }

	// RVA: 0x772250 Offset: 0x771450 VA: 0x180772250
	public float get_inputAssignmentTimeout() { }

	// RVA: 0x772C60 Offset: 0x771E60 VA: 0x180772C60
	public void set_inputAssignmentTimeout(float value) { }

	// RVA: 0x771F30 Offset: 0x771130 VA: 0x180771F30
	public float get_axisCalibrationTimeout() { }

	// RVA: 0x772B20 Offset: 0x771D20 VA: 0x180772B20
	public void set_axisCalibrationTimeout(float value) { }

	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_ignoreMouseXAxisAssignment() { }

	// RVA: 0x7385D0 Offset: 0x7377D0 VA: 0x1807385D0
	public void set_ignoreMouseXAxisAssignment(bool value) { }

	// RVA: 0x738150 Offset: 0x737350 VA: 0x180738150
	public bool get_ignoreMouseYAxisAssignment() { }

	// RVA: 0x772C50 Offset: 0x771E50 VA: 0x180772C50
	public void set_ignoreMouseYAxisAssignment(bool value) { }

	// RVA: 0x7725F0 Offset: 0x7717F0 VA: 0x1807725F0
	public bool get_universalCancelClosesScreen() { }

	// RVA: 0x773100 Offset: 0x772300 VA: 0x180773100
	public void set_universalCancelClosesScreen(bool value) { }

	// RVA: 0x7724C0 Offset: 0x7716C0 VA: 0x1807724C0
	public bool get_showInputBehaviorSettings() { }

	// RVA: 0x772FD0 Offset: 0x7721D0 VA: 0x180772FD0
	public void set_showInputBehaviorSettings(bool value) { }

	// RVA: 0x772600 Offset: 0x771800 VA: 0x180772600
	public bool get_useThemeSettings() { }

	// RVA: 0x773110 Offset: 0x772310 VA: 0x180773110
	public void set_useThemeSettings(bool value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public ThemeSettings get_themeSettings() { }

	// RVA: 0x7730D0 Offset: 0x7722D0 VA: 0x1807730D0
	public void set_themeSettings(ThemeSettings value) { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	public LanguageDataBase get_language() { }

	// RVA: 0x772D70 Offset: 0x771F70 VA: 0x180772D70
	public void set_language(LanguageDataBase value) { }

	// RVA: 0x772510 Offset: 0x771710 VA: 0x180772510
	public bool get_showPlayersGroupLabel() { }

	// RVA: 0x773050 Offset: 0x772250 VA: 0x180773050
	public void set_showPlayersGroupLabel(bool value) { }

	// RVA: 0x772480 Offset: 0x771680 VA: 0x180772480
	public bool get_showControllerGroupLabel() { }

	// RVA: 0x772F30 Offset: 0x772130 VA: 0x180772F30
	public void set_showControllerGroupLabel(bool value) { }

	// RVA: 0x772460 Offset: 0x771660 VA: 0x180772460
	public bool get_showAssignedControllersGroupLabel() { }

	// RVA: 0x772EF0 Offset: 0x7720F0 VA: 0x180772EF0
	public void set_showAssignedControllersGroupLabel(bool value) { }

	// RVA: 0x772590 Offset: 0x771790 VA: 0x180772590
	public bool get_showSettingsGroupLabel() { }

	// RVA: 0x773090 Offset: 0x772290 VA: 0x180773090
	public void set_showSettingsGroupLabel(bool value) { }

	// RVA: 0x7724D0 Offset: 0x7716D0 VA: 0x1807724D0
	public bool get_showMapCategoriesGroupLabel() { }

	// RVA: 0x773010 Offset: 0x772210 VA: 0x180773010
	public void set_showMapCategoriesGroupLabel(bool value) { }

	// RVA: 0x772490 Offset: 0x771690 VA: 0x180772490
	public bool get_showControllerNameLabel() { }

	// RVA: 0x772F50 Offset: 0x772150 VA: 0x180772F50
	public void set_showControllerNameLabel(bool value) { }

	// RVA: 0x772470 Offset: 0x771670 VA: 0x180772470
	public bool get_showAssignedControllers() { }

	// RVA: 0x772F10 Offset: 0x772110 VA: 0x180772F10
	public void set_showAssignedControllers(bool value) { }

	// RVA: 0x772450 Offset: 0x771650 VA: 0x180772450
	public Action get_restoreDefaultsDelegate() { }

	// RVA: 0x772EA0 Offset: 0x7720A0 VA: 0x180772EA0
	public void set_restoreDefaultsDelegate(Action value) { }

	// RVA: 0x772370 Offset: 0x771570 VA: 0x180772370
	public bool get_isOpen() { }

	// RVA: 0x772320 Offset: 0x771520 VA: 0x180772320
	private bool get_isFocused() { }

	// RVA: 0x772220 Offset: 0x771420 VA: 0x180772220
	private bool get_inputAllowed() { }

	// RVA: 0x772270 Offset: 0x771470 VA: 0x180772270
	private int get_inputGridColumnCount() { }

	// RVA: 0x7722A0 Offset: 0x7714A0 VA: 0x1807722A0
	private int get_inputGridWidth() { }

	// RVA: 0x7720A0 Offset: 0x7712A0 VA: 0x1807720A0
	private Player get_currentPlayer() { }

	// RVA: 0x771FC0 Offset: 0x7711C0 VA: 0x180771FC0
	private InputCategory get_currentMapCategory() { }

	// RVA: 0x772030 Offset: 0x771230 VA: 0x180772030
	private ControlMapper.MappingSet get_currentMappingSet() { }

	// RVA: 0x771F50 Offset: 0x771150 VA: 0x180771F50
	private Joystick get_currentJoystick() { }

	// RVA: 0x772360 Offset: 0x771560 VA: 0x180772360
	private bool get_isJoystickSelected() { }

	// RVA: 0x772110 Offset: 0x771310 VA: 0x180772110
	private GameObject get_currentUISelection() { }

	// RVA: 0x7725A0 Offset: 0x7717A0 VA: 0x1807725A0
	private bool get_showSettings() { }

	// RVA: 0x7724E0 Offset: 0x7716E0 VA: 0x1807724E0
	private bool get_showMapCategories() { }

	// RVA: 0x75D170 Offset: 0x75C370 VA: 0x18075D170
	private void Awake() { }

	// RVA: 0x770C70 Offset: 0x76FE70 VA: 0x180770C70
	private void Start() { }

	// RVA: 0x771760 Offset: 0x770960 VA: 0x180771760
	private void Update() { }

	// RVA: 0x7658A0 Offset: 0x764AA0 VA: 0x1807658A0
	private void OnDestroy() { }

	// RVA: 0x769B00 Offset: 0x768D00 VA: 0x180769B00
	private void PreInitialize() { }

	// RVA: 0x7638D0 Offset: 0x762AD0 VA: 0x1807638D0
	private void Initialize() { }

	// RVA: 0x766BB0 Offset: 0x765DB0 VA: 0x180766BB0
	private void OnJoystickConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x766BB0 Offset: 0x765DB0 VA: 0x180766BB0
	private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x765050 Offset: 0x764250 VA: 0x180765050
	public void OnButtonActivated(ButtonInfo buttonInfo) { }

	// RVA: 0x766760 Offset: 0x765960 VA: 0x180766760
	public void OnInputFieldActivated(InputFieldInfo fieldInfo) { }

	// RVA: 0x766A40 Offset: 0x765C40 VA: 0x180766A40
	public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState) { }

	// RVA: 0x767C60 Offset: 0x766E60 VA: 0x180767C60
	private void OnPlayerSelected(int playerId, bool redraw) { }

	// RVA: 0x765880 Offset: 0x764A80 VA: 0x180765880
	private void OnControllerSelected(int joystickId) { }

	// RVA: 0x767C90 Offset: 0x766E90 VA: 0x180767C90
	private void OnRemoveCurrentController() { }

	// RVA: 0x767490 Offset: 0x766690 VA: 0x180767490
	private void OnMapCategorySelected(int id, bool redraw) { }

	// RVA: 0x7680A0 Offset: 0x7672A0 VA: 0x1807680A0
	private void OnRestoreDefaults() { }

	// RVA: 0x768130 Offset: 0x767330 VA: 0x180768130
	private void OnScreenToggleActionPressed(InputActionEventData data) { }

	// RVA: 0x768120 Offset: 0x767320 VA: 0x180768120
	private void OnScreenOpenActionPressed(InputActionEventData data) { }

	// RVA: 0x7680C0 Offset: 0x7672C0 VA: 0x1807680C0
	private void OnScreenCloseActionPressed(InputActionEventData data) { }

	// RVA: 0x7681B0 Offset: 0x7673B0 VA: 0x1807681B0
	private void OnUniversalCancelActionPressed(InputActionEventData data) { }

	// RVA: 0x768240 Offset: 0x767440 VA: 0x180768240
	private void OnWindowCancel(int windowId) { }

	// RVA: 0x767D40 Offset: 0x766F40 VA: 0x180767D40
	private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem) { }

	// RVA: 0x764EF0 Offset: 0x7640F0 VA: 0x180764EF0
	private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName) { }

	// RVA: 0x765830 Offset: 0x764A30 VA: 0x180765830
	private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId) { }

	// RVA: 0x7674C0 Offset: 0x7666C0 VA: 0x1807674C0
	private void OnMouseAssignmentConfirmed(int windowId, Player player) { }

	// RVA: 0x765BE0 Offset: 0x764DE0 VA: 0x180765BE0
	private void OnElementAssignmentConflictReplaceConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap) { }

	// RVA: 0x765AE0 Offset: 0x764CE0 VA: 0x180765AE0
	private void OnElementAssignmentAddConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment) { }

	// RVA: 0x767DC0 Offset: 0x766FC0 VA: 0x180767DC0
	private void OnRestoreDefaultsConfirmed(int windowId) { }

	// RVA: 0x764C70 Offset: 0x763E70 VA: 0x180764C70
	private void OnAssignControllerWindowUpdate(int windowId) { }

	// RVA: 0x7664B0 Offset: 0x7656B0 VA: 0x1807664B0
	private void OnElementAssignmentPrePollingWindowUpdate(int windowId) { }

	// RVA: 0x766C20 Offset: 0x765E20 VA: 0x180766C20
	private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId) { }

	// RVA: 0x767090 Offset: 0x766290 VA: 0x180767090
	private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId) { }

	// RVA: 0x767720 Offset: 0x766920 VA: 0x180767720
	private void OnMouseElementAssignmentPollingWindowUpdate(int windowId) { }

	// RVA: 0x765430 Offset: 0x764630 VA: 0x180765430
	private void OnCalibrateAxisStep1WindowUpdate(int windowId) { }

	// RVA: 0x765620 Offset: 0x764820 VA: 0x180765620
	private void OnCalibrateAxisStep2WindowUpdate(int windowId) { }

	// RVA: 0x76C2F0 Offset: 0x76B4F0 VA: 0x18076C2F0
	private void ShowAssignControllerWindow() { }

	// RVA: 0x76D930 Offset: 0x76CB30 VA: 0x18076D930
	private void ShowControllerAssignmentConflictWindow(int controllerId) { }

	// RVA: 0x76C6A0 Offset: 0x76B8A0 VA: 0x18076C6A0
	private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName) { }

	// RVA: 0x76E030 Offset: 0x76D230 VA: 0x18076E030
	private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName) { }

	// RVA: 0x76EC70 Offset: 0x76DE70 VA: 0x18076EC70
	private void ShowElementAssignmentPrePollingWindow() { }

	// RVA: 0x76EBA0 Offset: 0x76DDA0 VA: 0x18076EBA0
	private void ShowElementAssignmentPollingWindow() { }

	// RVA: 0x76F010 Offset: 0x76E210 VA: 0x18076F010
	private void ShowJoystickElementAssignmentPollingWindow() { }

	// RVA: 0x76F370 Offset: 0x76E570 VA: 0x18076F370
	private void ShowKeyboardElementAssignmentPollingWindow() { }

	// RVA: 0x76FD60 Offset: 0x76EF60 VA: 0x18076FD60
	private void ShowMouseElementAssignmentPollingWindow() { }

	// RVA: 0x76E490 Offset: 0x76D690 VA: 0x18076E490
	private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers) { }

	// RVA: 0x76F700 Offset: 0x76E900 VA: 0x18076F700
	private void ShowMouseAssignmentConflictWindow() { }

	// RVA: 0x76D5C0 Offset: 0x76C7C0 VA: 0x18076D5C0
	private void ShowCalibrateControllerWindow() { }

	// RVA: 0x76CC80 Offset: 0x76BE80 VA: 0x18076CC80
	private void ShowCalibrateAxisStep1Window() { }

	// RVA: 0x76D120 Offset: 0x76C320 VA: 0x18076D120
	private void ShowCalibrateAxisStep2Window() { }

	// RVA: 0x76E1E0 Offset: 0x76D3E0 VA: 0x18076E1E0
	private void ShowEditInputBehaviorsWindow() { }

	// RVA: 0x7700C0 Offset: 0x76F2C0 VA: 0x1807700C0
	private void ShowRestoreDefaultsWindow() { }

	// RVA: 0x760520 Offset: 0x75F720 VA: 0x180760520
	private void CreateInputGrid() { }

	// RVA: 0x763050 Offset: 0x762250 VA: 0x180763050
	private void InitializeInputGrid() { }

	// RVA: 0x76B130 Offset: 0x76A330 VA: 0x18076B130
	private void RefreshInputGridStructure() { }

	// RVA: 0x75E330 Offset: 0x75D530 VA: 0x18075E330
	private void CreateHeaderLabels() { }

	// RVA: 0x75DF20 Offset: 0x75D120 VA: 0x18075DF20
	private void CreateActionLabelColumn() { }

	// RVA: 0x760820 Offset: 0x75FA20 VA: 0x180760820
	private void CreateKeyboardInputFieldColumn() { }

	// RVA: 0x760CC0 Offset: 0x75FEC0 VA: 0x180760CC0
	private void CreateMouseInputFieldColumn() { }

	// RVA: 0x75E1D0 Offset: 0x75D3D0 VA: 0x18075E1D0
	private void CreateControllerInputFieldColumn() { }

	// RVA: 0x75F510 Offset: 0x75E710 VA: 0x18075F510
	private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis) { }

	// RVA: 0x75E7D0 Offset: 0x75D9D0 VA: 0x18075E7D0
	private void CreateInputActionLabels() { }

	// RVA: 0x75FD00 Offset: 0x75EF00 VA: 0x18075FD00
	private void CreateInputFields() { }

	// RVA: 0x75FDE0 Offset: 0x75EFE0 VA: 0x18075FDE0
	private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis) { }

	// RVA: 0x75F600 Offset: 0x75E800 VA: 0x18075F600
	private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis) { }

	// RVA: 0x7696A0 Offset: 0x7688A0 VA: 0x1807696A0
	private void PopulateInputFields() { }

	// RVA: 0x769100 Offset: 0x768300 VA: 0x180769100
	private void PopulateInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields) { }

	// RVA: 0x761190 Offset: 0x760390 VA: 0x180761190
	private void DisableInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerType controllerType, int fieldCount) { }

	// RVA: 0x76B670 Offset: 0x76A870 VA: 0x18076B670
	private void ResetInputGridScrollBar() { }

	// RVA: 0x760A60 Offset: 0x75FC60 VA: 0x180760A60
	private void CreateLayout() { }

	// RVA: 0x7621B0 Offset: 0x7613B0 VA: 0x1807621B0
	private void Draw() { }

	// RVA: 0x761A40 Offset: 0x760C40 VA: 0x180761A40
	private void DrawPlayersGroup() { }

	// RVA: 0x761240 Offset: 0x760440 VA: 0x180761240
	private void DrawControllersGroup() { }

	// RVA: 0x761DB0 Offset: 0x760FB0 VA: 0x180761DB0
	private void DrawSettingsGroup() { }

	// RVA: 0x7616C0 Offset: 0x7608C0 VA: 0x1807616C0
	private void DrawMapCategoriesGroup() { }

	// RVA: 0x762080 Offset: 0x761280 VA: 0x180762080
	private void DrawWindowButtonsGroup() { }

	// RVA: 0x76AE50 Offset: 0x76A050 VA: 0x18076AE50
	private void Redraw(bool listsChanged, bool playTransitions) { }

	// RVA: 0x76AD20 Offset: 0x769F20 VA: 0x18076AD20
	private void RedrawPlayerGroup(bool playTransitions) { }

	// RVA: 0x769D10 Offset: 0x768F10 VA: 0x180769D10
	private void RedrawControllerGroup() { }

	// RVA: 0x76ABE0 Offset: 0x769DE0 VA: 0x18076ABE0
	private void RedrawMapCategoriesGroup(bool playTransitions) { }

	// RVA: 0x76AA30 Offset: 0x769C30 VA: 0x18076AA30
	private void RedrawInputGrid(bool listsChanged) { }

	// RVA: 0x762400 Offset: 0x761600 VA: 0x180762400
	private void ForceRefresh() { }

	// RVA: 0x75F460 Offset: 0x75E660 VA: 0x18075F460
	private void CreateInputCategoryRow(ref int rowCount, InputCategory category) { }

	// RVA: 0x7608B0 Offset: 0x75FAB0 VA: 0x1807608B0
	private ControlMapper.GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset) { }

	// RVA: 0x7608F0 Offset: 0x75FAF0 VA: 0x1807608F0
	private ControlMapper.GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset) { }

	// RVA: 0x75DFB0 Offset: 0x75D1B0 VA: 0x18075DFB0
	private ControlMapper.GUIButton CreateButton(string labelText, Transform parent, Vector2 offset) { }

	// RVA: 0x75E260 Offset: 0x75D460 VA: 0x18075E260
	private ControlMapper.GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset) { }

	// RVA: 0x75FAE0 Offset: 0x75ECE0 VA: 0x18075FAE0
	private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x75FA40 Offset: 0x75EC40 VA: 0x18075FA40
	private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset) { }

	// RVA: 0x761030 Offset: 0x760230 VA: 0x180761030
	private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	// RVA: 0x760F90 Offset: 0x760190 VA: 0x180760F90
	private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset) { }

	// RVA: 0x764590 Offset: 0x763790 VA: 0x180764590
	private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset) { }

	// RVA: 0x760EC0 Offset: 0x7600C0 VA: 0x180760EC0
	private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset) { }

	// RVA: 0x763720 Offset: 0x762920 VA: 0x180763720
	private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset) { }

	// RVA: 0x760D50 Offset: 0x75FF50 VA: 0x180760D50
	private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth) { }

	// RVA: 0x768730 Offset: 0x767930 VA: 0x180768730
	private Window OpenWindow(bool closeOthers) { }

	// RVA: 0x768910 Offset: 0x767B10 VA: 0x180768910
	private Window OpenWindow(string name, bool closeOthers) { }

	// RVA: 0x7686C0 Offset: 0x7678C0 VA: 0x1807686C0
	private Window OpenWindow(GameObject windowPrefab, bool closeOthers) { }

	// RVA: 0x768840 Offset: 0x767A40 VA: 0x180768840
	private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers) { }

	// RVA: 0x7682B0 Offset: 0x7674B0 VA: 0x1807682B0
	private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers) { }

	// RVA: 0x75DD20 Offset: 0x75CF20 VA: 0x18075DD20
	private void CloseWindow(int windowId) { }

	// RVA: 0x75DCD0 Offset: 0x75CED0 VA: 0x18075DCD0
	private void CloseTopWindow() { }

	// RVA: 0x75DC30 Offset: 0x75CE30 VA: 0x18075DC30
	private void CloseAllWindows() { }

	// RVA: 0x75D390 Offset: 0x75C590 VA: 0x18075D390
	private void ChildWindowOpened() { }

	// RVA: 0x75D2C0 Offset: 0x75C4C0 VA: 0x18075D2C0
	private void ChildWindowClosed() { }

	// RVA: 0x762E50 Offset: 0x762050 VA: 0x180762E50
	private bool HasElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	// RVA: 0x7646F0 Offset: 0x7638F0 VA: 0x1807646F0
	private bool IsBlockingAssignmentConflict(ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	[IteratorStateMachine(typeof(ControlMapper.<ElementAssignmentConflicts>d__420))]
	// RVA: 0x762300 Offset: 0x761500 VA: 0x180762300
	private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	// RVA: 0x75E080 Offset: 0x75D280 VA: 0x18075E080
	private bool CreateConflictCheck(ControlMapper.InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x768B60 Offset: 0x767D60 VA: 0x180768B60
	private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label) { }

	// RVA: 0x762A90 Offset: 0x761C90 VA: 0x180762A90
	private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers) { }

	// RVA: 0x762890 Offset: 0x761A90 VA: 0x180762890
	private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict) { }

	// RVA: 0x770B00 Offset: 0x76FD00 VA: 0x180770B00
	private void StartAxisCalibration(int axisIndex) { }

	// RVA: 0x7623C0 Offset: 0x7615C0 VA: 0x1807623C0
	private void EndAxisCalibration() { }

	// RVA: 0x76C230 Offset: 0x76B430 VA: 0x18076C230
	private void SetUISelection(GameObject selection) { }

	// RVA: 0x76BC10 Offset: 0x76AE10 VA: 0x18076BC10
	private void RestoreLastUISelection() { }

	// RVA: 0x76C0E0 Offset: 0x76B2E0 VA: 0x18076C0E0
	private void SetDefaultUISelection() { }

	// RVA: 0x76BCC0 Offset: 0x76AEC0 VA: 0x18076BCC0
	private void SelectDefaultMapCategory(bool redraw) { }

	// RVA: 0x75D220 Offset: 0x75C420 VA: 0x18075D220
	private void CheckUISelection() { }

	// RVA: 0x7681A0 Offset: 0x7673A0 VA: 0x1807681A0
	private void OnUIElementSelected(GameObject selectedObject) { }

	// RVA: 0x76C1B0 Offset: 0x76B3B0 VA: 0x18076C1B0
	private void SetIsFocused(bool state) { }

	// RVA: 0x771210 Offset: 0x770410 VA: 0x180771210
	public void Toggle() { }

	// RVA: 0x768120 Offset: 0x767320 VA: 0x180768120
	public void Open() { }

	// RVA: 0x7689F0 Offset: 0x767BF0 VA: 0x1807689F0
	private void Open(bool force) { }

	// RVA: 0x75DD80 Offset: 0x75CF80 VA: 0x18075DD80
	public void Close(bool save) { }

	// RVA: 0x75DBB0 Offset: 0x75CDB0 VA: 0x18075DBB0
	private void Clear() { }

	// RVA: 0x75D520 Offset: 0x75C720 VA: 0x18075D520
	private void ClearCompletely() { }

	// RVA: 0x75D640 Offset: 0x75C840 VA: 0x18075D640
	private void ClearSpawnedObjects() { }

	// RVA: 0x75DBA0 Offset: 0x75CDA0 VA: 0x18075DBA0
	private void ClearVarsOnPlayerChange() { }

	// RVA: 0x75DBA0 Offset: 0x75CDA0 VA: 0x18075DBA0
	private void ClearVarsOnJoystickChange() { }

	// RVA: 0x75D420 Offset: 0x75C620 VA: 0x18075D420
	private void ClearAllVars() { }

	// RVA: 0x76B780 Offset: 0x76A980 VA: 0x18076B780
	public void Reset() { }

	// RVA: 0x76BFB0 Offset: 0x76B1B0 VA: 0x18076BFB0
	private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId) { }

	// RVA: 0x762620 Offset: 0x761820 VA: 0x180762620
	private ControllerMap GetControllerMap(ControllerType type) { }

	// RVA: 0x7624C0 Offset: 0x7616C0 VA: 0x1807624C0
	private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId) { }

	// RVA: -1 Offset: -1
	private int CountIEnumerable<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F370 Offset: 0x94E570 VA: 0x18094F370
	|-ControlMapper.CountIEnumerable<object>
	|-ControlMapper.CountIEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x762780 Offset: 0x761980 VA: 0x180762780
	private int GetDefaultMapCategoryId() { }

	// RVA: 0x770C90 Offset: 0x76FE90 VA: 0x180770C90
	private void SubscribeFixedUISelectionEvents() { }

	// RVA: 0x770E00 Offset: 0x770000 VA: 0x180770E00
	private void SubscribeMenuControlInputEvents() { }

	// RVA: 0x771340 Offset: 0x770540 VA: 0x180771340
	private void UnsubscribeMenuControlInputEvents() { }

	// RVA: 0x770F60 Offset: 0x770160 VA: 0x180770F60
	private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback) { }

	// RVA: 0x7714A0 Offset: 0x7706A0 VA: 0x1807714A0
	private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback) { }

	// RVA: 0x762E00 Offset: 0x762000 VA: 0x180762E00
	private int GetMaxControllersPerPlayer() { }

	// RVA: 0x76C630 Offset: 0x76B830 VA: 0x18076C630
	private bool ShowAssignedControllers() { }

	// RVA: 0x764580 Offset: 0x763780 VA: 0x180764580
	private void InspectorPropertyChanged(bool reset = False) { }

	// RVA: 0x75CD10 Offset: 0x75BF10 VA: 0x18075CD10
	private void AssignController(Player player, int controllerId) { }

	// RVA: 0x76B420 Offset: 0x76A620 VA: 0x18076B420
	private void RemoveAllControllers(Player player) { }

	// RVA: 0x76B560 Offset: 0x76A760 VA: 0x18076B560
	private void RemoveController(Player player, int controllerId) { }

	// RVA: 0x7646A0 Offset: 0x7638A0 VA: 0x1807646A0
	private bool IsAllowedAssignment(ControlMapper.InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo) { }

	// RVA: 0x7644C0 Offset: 0x7636C0 VA: 0x1807644C0
	private void InputPollingStarted() { }

	// RVA: 0x764520 Offset: 0x763720 VA: 0x180764520
	private void InputPollingStopped() { }

	// RVA: 0x762450 Offset: 0x761650 VA: 0x180762450
	private int GetControllerInputFieldCount(ControllerType controllerType) { }

	// RVA: 0x7702C0 Offset: 0x76F4C0 VA: 0x1807702C0
	private bool ShowSwapButton(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	// RVA: 0x7711C0 Offset: 0x7703C0 VA: 0x1807711C0
	private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution) { }

	// RVA: 0x75CC70 Offset: 0x75BE70 VA: 0x18075CC70
	private void ApplyTheme() { }

	// RVA: 0x76B2A0 Offset: 0x76A4A0 VA: 0x18076B2A0
	public static void Register(ThemedElement themedElement) { }

	// RVA: 0x771250 Offset: 0x770450 VA: 0x180771250
	public static void Unregister(ThemedElement themedElement) { }

	// RVA: 0x75CB70 Offset: 0x75BD70 VA: 0x18075CB70
	public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo) { }

	// RVA: 0x762D60 Offset: 0x761F60 VA: 0x180762D60
	public static LanguageDataBase GetLanguage() { }

	// RVA: 0x7721C0 Offset: 0x7713C0 VA: 0x1807721C0
	public static ControlMapper get_current() { }

	// RVA: 0x771820 Offset: 0x770A20 VA: 0x180771820
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CustomButton.<OnFinishSubmit>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2114
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CustomButton <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x799620 Offset: 0x798820 VA: 0x180799620 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x799750 Offset: 0x798950 VA: 0x180799750 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class CustomButton : Button, ICustomSelectable, ICancelHandler, IEventSystemHandler // TypeDefIndex: 2115
{
	// Fields
	[SerializeField]
	private Sprite _disabledHighlightedSprite; // 0x108
	[SerializeField]
	private Color _disabledHighlightedColor; // 0x110
	[SerializeField]
	private string _disabledHighlightedTrigger; // 0x120
	[SerializeField]
	private bool _autoNavUp; // 0x128
	[SerializeField]
	private bool _autoNavDown; // 0x129
	[SerializeField]
	private bool _autoNavLeft; // 0x12A
	[SerializeField]
	private bool _autoNavRight; // 0x12B
	private bool isHighlightDisabled; // 0x12C
	[CompilerGenerated]
	private UnityAction _CancelEvent; // 0x130

	// Properties
	public Sprite disabledHighlightedSprite { get; set; }
	public Color disabledHighlightedColor { get; set; }
	public string disabledHighlightedTrigger { get; set; }
	public bool autoNavUp { get; set; }
	public bool autoNavDown { get; set; }
	public bool autoNavLeft { get; set; }
	public bool autoNavRight { get; set; }
	private bool isDisabled { get; }

	// Methods

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810 Slot: 43
	public Sprite get_disabledHighlightedSprite() { }

	// RVA: 0x789950 Offset: 0x788B50 VA: 0x180789950 Slot: 44
	public void set_disabledHighlightedSprite(Sprite value) { }

	// RVA: 0x789800 Offset: 0x788A00 VA: 0x180789800 Slot: 45
	public Color get_disabledHighlightedColor() { }

	// RVA: 0x789940 Offset: 0x788B40 VA: 0x180789940 Slot: 46
	public void set_disabledHighlightedColor(Color value) { }

	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70 Slot: 47
	public string get_disabledHighlightedTrigger() { }

	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0 Slot: 48
	public void set_disabledHighlightedTrigger(string value) { }

	// RVA: 0x7897F0 Offset: 0x7889F0 VA: 0x1807897F0 Slot: 49
	public bool get_autoNavUp() { }

	// RVA: 0x789930 Offset: 0x788B30 VA: 0x180789930 Slot: 50
	public void set_autoNavUp(bool value) { }

	// RVA: 0x7897C0 Offset: 0x7889C0 VA: 0x1807897C0 Slot: 51
	public bool get_autoNavDown() { }

	// RVA: 0x789900 Offset: 0x788B00 VA: 0x180789900 Slot: 52
	public void set_autoNavDown(bool value) { }

	// RVA: 0x7897D0 Offset: 0x7889D0 VA: 0x1807897D0 Slot: 53
	public bool get_autoNavLeft() { }

	// RVA: 0x789910 Offset: 0x788B10 VA: 0x180789910 Slot: 54
	public void set_autoNavLeft(bool value) { }

	// RVA: 0x7897E0 Offset: 0x7889E0 VA: 0x1807897E0 Slot: 55
	public bool get_autoNavRight() { }

	// RVA: 0x789920 Offset: 0x788B20 VA: 0x180789920 Slot: 56
	public void set_autoNavRight(bool value) { }

	// RVA: 0x789820 Offset: 0x788A20 VA: 0x180789820
	private bool get_isDisabled() { }

	[CompilerGenerated]
	// RVA: 0x789710 Offset: 0x788910 VA: 0x180789710
	private void add__CancelEvent(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x789850 Offset: 0x788A50 VA: 0x180789850
	private void remove__CancelEvent(UnityAction value) { }

	// RVA: 0x789710 Offset: 0x788910 VA: 0x180789710 Slot: 57
	public void add_CancelEvent(UnityAction value) { }

	// RVA: 0x789850 Offset: 0x788A50 VA: 0x180789850 Slot: 58
	public void remove_CancelEvent(UnityAction value) { }

	// RVA: 0x788CC0 Offset: 0x787EC0 VA: 0x180788CC0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x788DB0 Offset: 0x787FB0 VA: 0x180788DB0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x788EA0 Offset: 0x7880A0 VA: 0x180788EA0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x788BD0 Offset: 0x787DD0 VA: 0x180788BD0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x788FC0 Offset: 0x7881C0 VA: 0x180788FC0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x7886F0 Offset: 0x7878F0 VA: 0x1807886F0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x789480 Offset: 0x788680 VA: 0x180789480
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x788650 Offset: 0x787850 VA: 0x180788650
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x789590 Offset: 0x788790 VA: 0x180789590
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x789280 Offset: 0x788480 VA: 0x180789280 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x7890D0 Offset: 0x7882D0 VA: 0x1807890D0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x789420 Offset: 0x788620 VA: 0x180789420
	private void Press() { }

	// RVA: 0x7891B0 Offset: 0x7883B0 VA: 0x1807891B0 Slot: 41
	public override void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7892E0 Offset: 0x7884E0 VA: 0x1807892E0 Slot: 42
	public override void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(CustomButton.<OnFinishSubmit>d__51))]
	// RVA: 0x789150 Offset: 0x788350 VA: 0x180789150
	private IEnumerator OnFinishSubmit() { }

	// RVA: 0x788B10 Offset: 0x787D10 VA: 0x180788B10
	private void EvaluateHightlightDisabled(bool isSelected) { }

	// RVA: 0x788F90 Offset: 0x788190 VA: 0x180788F90 Slot: 59
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x7896F0 Offset: 0x7888F0 VA: 0x1807896F0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class CustomSlider : Slider, ICustomSelectable, ICancelHandler, IEventSystemHandler // TypeDefIndex: 2116
{
	// Fields
	[SerializeField]
	private Sprite _disabledHighlightedSprite; // 0x168
	[SerializeField]
	private Color _disabledHighlightedColor; // 0x170
	[SerializeField]
	private string _disabledHighlightedTrigger; // 0x180
	[SerializeField]
	private bool _autoNavUp; // 0x188
	[SerializeField]
	private bool _autoNavDown; // 0x189
	[SerializeField]
	private bool _autoNavLeft; // 0x18A
	[SerializeField]
	private bool _autoNavRight; // 0x18B
	private bool isHighlightDisabled; // 0x18C
	[CompilerGenerated]
	private UnityAction _CancelEvent; // 0x190

	// Properties
	public Sprite disabledHighlightedSprite { get; set; }
	public Color disabledHighlightedColor { get; set; }
	public string disabledHighlightedTrigger { get; set; }
	public bool autoNavUp { get; set; }
	public bool autoNavDown { get; set; }
	public bool autoNavLeft { get; set; }
	public bool autoNavRight { get; set; }
	private bool isDisabled { get; }

	// Methods

	// RVA: 0x78AC40 Offset: 0x789E40 VA: 0x18078AC40 Slot: 56
	public Sprite get_disabledHighlightedSprite() { }

	// RVA: 0x78AD60 Offset: 0x789F60 VA: 0x18078AD60 Slot: 57
	public void set_disabledHighlightedSprite(Sprite value) { }

	// RVA: 0x78AC30 Offset: 0x789E30 VA: 0x18078AC30 Slot: 58
	public Color get_disabledHighlightedColor() { }

	// RVA: 0x78AD50 Offset: 0x789F50 VA: 0x18078AD50 Slot: 59
	public void set_disabledHighlightedColor(Color value) { }

	// RVA: 0x78AC50 Offset: 0x789E50 VA: 0x18078AC50 Slot: 60
	public string get_disabledHighlightedTrigger() { }

	// RVA: 0x78AD70 Offset: 0x789F70 VA: 0x18078AD70 Slot: 61
	public void set_disabledHighlightedTrigger(string value) { }

	// RVA: 0x78AC20 Offset: 0x789E20 VA: 0x18078AC20 Slot: 62
	public bool get_autoNavUp() { }

	// RVA: 0x78AD40 Offset: 0x789F40 VA: 0x18078AD40 Slot: 63
	public void set_autoNavUp(bool value) { }

	// RVA: 0x78ABF0 Offset: 0x789DF0 VA: 0x18078ABF0 Slot: 64
	public bool get_autoNavDown() { }

	// RVA: 0x78AD10 Offset: 0x789F10 VA: 0x18078AD10 Slot: 65
	public void set_autoNavDown(bool value) { }

	// RVA: 0x78AC00 Offset: 0x789E00 VA: 0x18078AC00 Slot: 66
	public bool get_autoNavLeft() { }

	// RVA: 0x78AD20 Offset: 0x789F20 VA: 0x18078AD20 Slot: 67
	public void set_autoNavLeft(bool value) { }

	// RVA: 0x78AC10 Offset: 0x789E10 VA: 0x18078AC10 Slot: 68
	public bool get_autoNavRight() { }

	// RVA: 0x78AD30 Offset: 0x789F30 VA: 0x18078AD30 Slot: 69
	public void set_autoNavRight(bool value) { }

	// RVA: 0x789820 Offset: 0x788A20 VA: 0x180789820
	private bool get_isDisabled() { }

	[CompilerGenerated]
	// RVA: 0x78AB40 Offset: 0x789D40 VA: 0x18078AB40
	private void add__CancelEvent(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x78AC60 Offset: 0x789E60 VA: 0x18078AC60
	private void remove__CancelEvent(UnityAction value) { }

	// RVA: 0x78AB40 Offset: 0x789D40 VA: 0x18078AB40 Slot: 70
	public void add_CancelEvent(UnityAction value) { }

	// RVA: 0x78AC60 Offset: 0x789E60 VA: 0x18078AC60 Slot: 71
	public void remove_CancelEvent(UnityAction value) { }

	// RVA: 0x78A3C0 Offset: 0x7895C0 VA: 0x18078A3C0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x78A4B0 Offset: 0x7896B0 VA: 0x18078A4B0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x78A5A0 Offset: 0x7897A0 VA: 0x18078A5A0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x78A2D0 Offset: 0x7894D0 VA: 0x18078A2D0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x78A6C0 Offset: 0x7898C0 VA: 0x18078A6C0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x789DF0 Offset: 0x788FF0 VA: 0x180789DF0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x78A8B0 Offset: 0x789AB0 VA: 0x18078A8B0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x789D50 Offset: 0x788F50 VA: 0x180789D50
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x78A9C0 Offset: 0x789BC0 VA: 0x18078A9C0
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x78A850 Offset: 0x789A50 VA: 0x18078A850 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x78A7D0 Offset: 0x7899D0 VA: 0x18078A7D0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x78A210 Offset: 0x789410 VA: 0x18078A210
	private void EvaluateHightlightDisabled(bool isSelected) { }

	// RVA: 0x78A690 Offset: 0x789890 VA: 0x18078A690 Slot: 72
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x78AB20 Offset: 0x789D20 VA: 0x18078AB20
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class CustomToggle : Toggle, ICustomSelectable, ICancelHandler, IEventSystemHandler // TypeDefIndex: 2117
{
	// Fields
	[SerializeField]
	private Sprite _disabledHighlightedSprite; // 0x128
	[SerializeField]
	private Color _disabledHighlightedColor; // 0x130
	[SerializeField]
	private string _disabledHighlightedTrigger; // 0x140
	[SerializeField]
	private bool _autoNavUp; // 0x148
	[SerializeField]
	private bool _autoNavDown; // 0x149
	[SerializeField]
	private bool _autoNavLeft; // 0x14A
	[SerializeField]
	private bool _autoNavRight; // 0x14B
	private bool isHighlightDisabled; // 0x14C
	[CompilerGenerated]
	private UnityAction _CancelEvent; // 0x150

	// Properties
	public Sprite disabledHighlightedSprite { get; set; }
	public Color disabledHighlightedColor { get; set; }
	public string disabledHighlightedTrigger { get; set; }
	public bool autoNavUp { get; set; }
	public bool autoNavDown { get; set; }
	public bool autoNavLeft { get; set; }
	public bool autoNavRight { get; set; }
	private bool isDisabled { get; }

	// Methods

	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530 Slot: 51
	public Sprite get_disabledHighlightedSprite() { }

	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0 Slot: 52
	public void set_disabledHighlightedSprite(Sprite value) { }

	// RVA: 0x78BCA0 Offset: 0x78AEA0 VA: 0x18078BCA0 Slot: 53
	public Color get_disabledHighlightedColor() { }

	// RVA: 0x78BDB0 Offset: 0x78AFB0 VA: 0x18078BDB0 Slot: 54
	public void set_disabledHighlightedColor(Color value) { }

	// RVA: 0x78BCB0 Offset: 0x78AEB0 VA: 0x18078BCB0 Slot: 55
	public string get_disabledHighlightedTrigger() { }

	// RVA: 0x78BDC0 Offset: 0x78AFC0 VA: 0x18078BDC0 Slot: 56
	public void set_disabledHighlightedTrigger(string value) { }

	// RVA: 0x78BC90 Offset: 0x78AE90 VA: 0x18078BC90 Slot: 57
	public bool get_autoNavUp() { }

	// RVA: 0x78BDA0 Offset: 0x78AFA0 VA: 0x18078BDA0 Slot: 58
	public void set_autoNavUp(bool value) { }

	// RVA: 0x78BC60 Offset: 0x78AE60 VA: 0x18078BC60 Slot: 59
	public bool get_autoNavDown() { }

	// RVA: 0x78BD70 Offset: 0x78AF70 VA: 0x18078BD70 Slot: 60
	public void set_autoNavDown(bool value) { }

	// RVA: 0x78BC70 Offset: 0x78AE70 VA: 0x18078BC70 Slot: 61
	public bool get_autoNavLeft() { }

	// RVA: 0x78BD80 Offset: 0x78AF80 VA: 0x18078BD80 Slot: 62
	public void set_autoNavLeft(bool value) { }

	// RVA: 0x78BC80 Offset: 0x78AE80 VA: 0x18078BC80 Slot: 63
	public bool get_autoNavRight() { }

	// RVA: 0x78BD90 Offset: 0x78AF90 VA: 0x18078BD90 Slot: 64
	public void set_autoNavRight(bool value) { }

	// RVA: 0x789820 Offset: 0x788A20 VA: 0x180789820
	private bool get_isDisabled() { }

	[CompilerGenerated]
	// RVA: 0x78BBB0 Offset: 0x78ADB0 VA: 0x18078BBB0
	private void add__CancelEvent(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x78BCC0 Offset: 0x78AEC0 VA: 0x18078BCC0
	private void remove__CancelEvent(UnityAction value) { }

	// RVA: 0x78BBB0 Offset: 0x78ADB0 VA: 0x18078BBB0 Slot: 65
	public void add_CancelEvent(UnityAction value) { }

	// RVA: 0x78BCC0 Offset: 0x78AEC0 VA: 0x18078BCC0 Slot: 66
	public void remove_CancelEvent(UnityAction value) { }

	// RVA: 0x78B430 Offset: 0x78A630 VA: 0x18078B430 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x78B520 Offset: 0x78A720 VA: 0x18078B520 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x78B610 Offset: 0x78A810 VA: 0x18078B610 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x78B340 Offset: 0x78A540 VA: 0x18078B340 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x78B730 Offset: 0x78A930 VA: 0x18078B730 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x78AE60 Offset: 0x78A060 VA: 0x18078AE60 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x78B920 Offset: 0x78AB20 VA: 0x18078B920
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x78ADC0 Offset: 0x789FC0 VA: 0x18078ADC0
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x78BA30 Offset: 0x78AC30 VA: 0x18078BA30
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x78B8C0 Offset: 0x78AAC0 VA: 0x18078B8C0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x78B840 Offset: 0x78AA40 VA: 0x18078B840 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x78B280 Offset: 0x78A480 VA: 0x18078B280
	private void EvaluateHightlightDisabled(bool isSelected) { }

	// RVA: 0x78B700 Offset: 0x78A900 VA: 0x18078B700 Slot: 67
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x78BB90 Offset: 0x78AD90 VA: 0x18078BB90
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
public interface ICustomSelectable : ICancelHandler, IEventSystemHandler // TypeDefIndex: 2118
{
	// Properties
	public abstract Sprite disabledHighlightedSprite { get; set; }
	public abstract Color disabledHighlightedColor { get; set; }
	public abstract string disabledHighlightedTrigger { get; set; }
	public abstract bool autoNavUp { get; set; }
	public abstract bool autoNavDown { get; set; }
	public abstract bool autoNavLeft { get; set; }
	public abstract bool autoNavRight { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Sprite get_disabledHighlightedSprite();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_disabledHighlightedSprite(Sprite value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Color get_disabledHighlightedColor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_disabledHighlightedColor(Color value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_disabledHighlightedTrigger();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_disabledHighlightedTrigger(string value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_autoNavUp();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_autoNavUp(bool value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_autoNavDown();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_autoNavDown(bool value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_autoNavLeft();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_autoNavLeft(bool value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_autoNavRight();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_autoNavRight(bool value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void add_CancelEvent(UnityAction value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void remove_CancelEvent(UnityAction value);
}

// Namespace: 
private class InputBehaviorWindow.InputBehaviorInfo // TypeDefIndex: 2119
{
	// Fields
	private InputBehavior _inputBehavior; // 0x10
	private UIControlSet _controlSet; // 0x18
	private Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty; // 0x20
	private InputBehavior copyOfOriginal; // 0x28

	// Properties
	public InputBehavior inputBehavior { get; }
	public UIControlSet controlSet { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public InputBehavior get_inputBehavior() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public UIControlSet get_controlSet() { }

	// RVA: 0x78EAC0 Offset: 0x78DCC0 VA: 0x18078EAC0
	public void .ctor(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty) { }

	// RVA: 0x78EA90 Offset: 0x78DC90 VA: 0x18078EA90
	public void RestorePreviousData() { }

	// RVA: 0x78EA60 Offset: 0x78DC60 VA: 0x18078EA60
	public void RestoreDefaultData() { }

	// RVA: 0x78E930 Offset: 0x78DB30 VA: 0x18078E930
	public void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId) { }

	// RVA: 0x78E6D0 Offset: 0x78D8D0 VA: 0x18078E6D0
	public void RefreshControls() { }
}

// Namespace: 
public enum InputBehaviorWindow.ButtonIdentifier // TypeDefIndex: 2120
{
	// Fields
	public int value__; // 0x0
	public const InputBehaviorWindow.ButtonIdentifier Done = 0;
	public const InputBehaviorWindow.ButtonIdentifier Cancel = 1;
	public const InputBehaviorWindow.ButtonIdentifier Default = 2;
}

// Namespace: 
private enum InputBehaviorWindow.PropertyType // TypeDefIndex: 2121
{
	// Fields
	public int value__; // 0x0
	public const InputBehaviorWindow.PropertyType JoystickAxisSensitivity = 0;
	public const InputBehaviorWindow.PropertyType MouseXYAxisSensitivity = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class InputBehaviorWindow.<>c__DisplayClass26_0 // TypeDefIndex: 2122
{
	// Fields
	public Action<int, int, float> valueChangedCallback; // 0x10
	public int inputBehaviorId; // 0x18
	public Action<int, int> cancelCallback; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7998B0 Offset: 0x798AB0 VA: 0x1807998B0
	internal void <CreateSlider>b__0(int cId, float value) { }

	// RVA: 0x7998F0 Offset: 0x798AF0 VA: 0x1807998F0
	internal void <CreateSlider>b__1(int cId) { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class InputBehaviorWindow : Window // TypeDefIndex: 2123
{
	// Fields
	private const float minSensitivity = 0,1;
	[SerializeField]
	private RectTransform spawnTransform; // 0x88
	[SerializeField]
	private Button doneButton; // 0x90
	[SerializeField]
	private Button cancelButton; // 0x98
	[SerializeField]
	private Button defaultButton; // 0xA0
	[SerializeField]
	private TMP_Text doneButtonLabel; // 0xA8
	[SerializeField]
	private TMP_Text cancelButtonLabel; // 0xB0
	[SerializeField]
	private TMP_Text defaultButtonLabel; // 0xB8
	[SerializeField]
	private GameObject uiControlSetPrefab; // 0xC0
	[SerializeField]
	private GameObject uiSliderControlPrefab; // 0xC8
	private List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo; // 0xD0
	private Dictionary<int, Action<int>> buttonCallbacks; // 0xD8
	private int playerId; // 0xE0

	// Methods

	// RVA: 0x78F270 Offset: 0x78E470 VA: 0x18078F270 Slot: 5
	public override void Initialize(int id, Func<int, bool> isFocusedCallback) { }

	// RVA: 0x78FC00 Offset: 0x78EE00 VA: 0x18078FC00
	public void SetData(int playerId, ControlMapper.InputBehaviorSettings[] data) { }

	// RVA: 0x78FB30 Offset: 0x78ED30 VA: 0x18078FB30
	public void SetButtonCallback(InputBehaviorWindow.ButtonIdentifier buttonIdentifier, Action<int> callback) { }

	// RVA: 0x78EC30 Offset: 0x78DE30 VA: 0x18078EC30 Slot: 9
	public override void Cancel() { }

	// RVA: 0x78F980 Offset: 0x78EB80 VA: 0x18078F980
	public void OnDone() { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00
	public void OnCancel() { }

	// RVA: 0x78FA00 Offset: 0x78EC00 VA: 0x18078FA00
	public void OnRestoreDefault() { }

	// RVA: 0x78F800 Offset: 0x78EA00 VA: 0x18078F800
	private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value) { }

	// RVA: 0x78F940 Offset: 0x78EB40 VA: 0x18078F940
	private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value) { }

	// RVA: 0x78F700 Offset: 0x78E900 VA: 0x18078F700
	private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId) { }

	// RVA: 0x78F840 Offset: 0x78EA40 VA: 0x18078F840
	private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId) { }

	// RVA: 0x790170 Offset: 0x78F370 VA: 0x180790170 Slot: 6
	public override void TakeInputFocus() { }

	// RVA: 0x78EE00 Offset: 0x78E000 VA: 0x18078EE00
	private UIControlSet CreateControlSet() { }

	// RVA: 0x78EEC0 Offset: 0x78E0C0 VA: 0x18078EEC0
	private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback) { }

	// RVA: 0x78F200 Offset: 0x78E400 VA: 0x18078F200
	private InputBehavior GetInputBehavior(int id) { }

	// RVA: 0x78F130 Offset: 0x78E330 VA: 0x18078F130
	private InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId) { }

	// RVA: 0x790250 Offset: 0x78F450 VA: 0x180790250
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class InputFieldInfo : UIElementInfo // TypeDefIndex: 2124
{
	// Fields
	private int _actionElementMapId; // 0x40
	private AxisRange _axisRange; // 0x44
	[CompilerGenerated]
	private UnityUIControllerElementGlyph <glyphOrText>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <actionId>k__BackingField; // 0x50
	[CompilerGenerated]
	private ControllerType <controllerType>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <controllerId>k__BackingField; // 0x58

	// Properties
	public UnityUIControllerElementGlyph glyphOrText { get; set; }
	public int actionId { get; set; }
	public AxisRange axisRange { get; set; }
	public int actionElementMapId { get; set; }
	public ControllerType controllerType { get; set; }
	public int controllerId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public UnityUIControllerElementGlyph get_glyphOrText() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_glyphOrText(UnityUIControllerElementGlyph value) { }

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int get_actionId() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_actionId(int value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public AxisRange get_axisRange() { }

	// RVA: 0x790320 Offset: 0x78F520 VA: 0x180790320
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_actionElementMapId() { }

	// RVA: 0x790260 Offset: 0x78F460 VA: 0x180790260
	public void set_actionElementMapId(int value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public ControllerType get_controllerType() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_controllerType(ControllerType value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public int get_controllerId() { }

	[CompilerGenerated]
	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_controllerId(int value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class InputRow : MonoBehaviour // TypeDefIndex: 2125
{
	// Fields
	public TMP_Text label; // 0x20
	[CompilerGenerated]
	private ButtonInfo[] <buttons>k__BackingField; // 0x28
	private int rowIndex; // 0x30
	private Action<int, ButtonInfo> inputFieldActivatedCallback; // 0x38

	// Properties
	public ButtonInfo[] buttons { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ButtonInfo[] get_buttons() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_buttons(ButtonInfo[] value) { }

	// RVA: 0x793520 Offset: 0x792720 VA: 0x180793520
	public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback) { }

	// RVA: 0x7935C0 Offset: 0x7927C0 VA: 0x1807935C0
	public void OnButtonActivated(ButtonInfo buttonInfo) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
protected class LanguageData.CustomEntry // TypeDefIndex: 2126
{
	// Fields
	public string key; // 0x10
	public string value; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string key, string value) { }

	// RVA: 0x789B30 Offset: 0x788D30 VA: 0x180789B30
	public static Dictionary<string, string> ToDictionary(LanguageData.CustomEntry[] array) { }
}

// Namespace: 
[Serializable]
protected class LanguageData.ModifierKeys // TypeDefIndex: 2127
{
	// Fields
	public string control; // 0x10
	public string alt; // 0x18
	public string shift; // 0x20
	public string command; // 0x28
	public string separator; // 0x30

	// Methods

	// RVA: 0x795890 Offset: 0x794A90 VA: 0x180795890
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[Serializable]
public class LanguageData : LanguageDataBase // TypeDefIndex: 2128
{
	// Fields
	[SerializeField]
	private string _yes; // 0x18
	[SerializeField]
	private string _no; // 0x20
	[SerializeField]
	private string _add; // 0x28
	[SerializeField]
	private string _replace; // 0x30
	[SerializeField]
	private string _remove; // 0x38
	[SerializeField]
	private string _swap; // 0x40
	[SerializeField]
	private string _cancel; // 0x48
	[SerializeField]
	private string _none; // 0x50
	[SerializeField]
	private string _okay; // 0x58
	[SerializeField]
	private string _done; // 0x60
	[SerializeField]
	private string _default; // 0x68
	[SerializeField]
	private string _assignControllerWindowTitle; // 0x70
	[SerializeField]
	private string _assignControllerWindowMessage; // 0x78
	[SerializeField]
	private string _controllerAssignmentConflictWindowTitle; // 0x80
	[SerializeField]
	[Tooltip("{0} = Joystick Name
{1} = Other Player Name
{2} = This Player Name")]
	private string _controllerAssignmentConflictWindowMessage; // 0x88
	[SerializeField]
	private string _elementAssignmentPrePollingWindowMessage; // 0x90
	[SerializeField]
	[Tooltip("{0} = Action Name")]
	private string _joystickElementAssignmentPollingWindowMessage; // 0x98
	[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.
{0} = Action Name")]
	[SerializeField]
	private string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly; // 0xA0
	[SerializeField]
	[Tooltip("{0} = Action Name")]
	private string _keyboardElementAssignmentPollingWindowMessage; // 0xA8
	[SerializeField]
	[Tooltip("{0} = Action Name")]
	private string _mouseElementAssignmentPollingWindowMessage; // 0xB0
	[SerializeField]
	[Tooltip("This text is only displayed when split-axis fields have been disabled and the user clicks on the full-axis field. Button/key/D-pad input cannot be assigned to a full-axis field.
{0} = Action Name")]
	private string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly; // 0xB8
	[SerializeField]
	private string _elementAssignmentConflictWindowMessage; // 0xC0
	[Tooltip("{0} = Element Name")]
	[SerializeField]
	private string _elementAlreadyInUseBlocked; // 0xC8
	[SerializeField]
	[Tooltip("{0} = Element Name")]
	private string _elementAlreadyInUseCanReplace; // 0xD0
	[Tooltip("{0} = Element Name")]
	[SerializeField]
	private string _elementAlreadyInUseCanReplace_conflictAllowed; // 0xD8
	[SerializeField]
	private string _mouseAssignmentConflictWindowTitle; // 0xE0
	[SerializeField]
	[Tooltip("{0} = Other Player Name
{1} = This Player Name")]
	private string _mouseAssignmentConflictWindowMessage; // 0xE8
	[SerializeField]
	private string _calibrateControllerWindowTitle; // 0xF0
	[SerializeField]
	private string _calibrateAxisStep1WindowTitle; // 0xF8
	[SerializeField]
	[Tooltip("{0} = Axis Name")]
	private string _calibrateAxisStep1WindowMessage; // 0x100
	[SerializeField]
	private string _calibrateAxisStep2WindowTitle; // 0x108
	[SerializeField]
	[Tooltip("{0} = Axis Name")]
	private string _calibrateAxisStep2WindowMessage; // 0x110
	[SerializeField]
	private string _inputBehaviorSettingsWindowTitle; // 0x118
	[SerializeField]
	private string _restoreDefaultsWindowTitle; // 0x120
	[SerializeField]
	[Tooltip("Message for a single player game.")]
	private string _restoreDefaultsWindowMessage_onePlayer; // 0x128
	[SerializeField]
	[Tooltip("Message for a multi-player game.")]
	private string _restoreDefaultsWindowMessage_multiPlayer; // 0x130
	[SerializeField]
	private string _actionColumnLabel; // 0x138
	[SerializeField]
	private string _keyboardColumnLabel; // 0x140
	[SerializeField]
	private string _mouseColumnLabel; // 0x148
	[SerializeField]
	private string _controllerColumnLabel; // 0x150
	[SerializeField]
	private string _removeControllerButtonLabel; // 0x158
	[SerializeField]
	private string _calibrateControllerButtonLabel; // 0x160
	[SerializeField]
	private string _assignControllerButtonLabel; // 0x168
	[SerializeField]
	private string _inputBehaviorSettingsButtonLabel; // 0x170
	[SerializeField]
	private string _doneButtonLabel; // 0x178
	[SerializeField]
	private string _restoreDefaultsButtonLabel; // 0x180
	[SerializeField]
	private string _playersGroupLabel; // 0x188
	[SerializeField]
	private string _controllerSettingsGroupLabel; // 0x190
	[SerializeField]
	private string _assignedControllersGroupLabel; // 0x198
	[SerializeField]
	private string _settingsGroupLabel; // 0x1A0
	[SerializeField]
	private string _mapCategoriesGroupLabel; // 0x1A8
	[SerializeField]
	private string _calibrateWindow_deadZoneSliderLabel; // 0x1B0
	[SerializeField]
	private string _calibrateWindow_zeroSliderLabel; // 0x1B8
	[SerializeField]
	private string _calibrateWindow_sensitivitySliderLabel; // 0x1C0
	[SerializeField]
	private string _calibrateWindow_invertToggleLabel; // 0x1C8
	[SerializeField]
	private string _calibrateWindow_calibrateButtonLabel; // 0x1D0
	[SerializeField]
	private LanguageData.ModifierKeys _modifierKeys; // 0x1D8
	[SerializeField]
	private LanguageData.CustomEntry[] _customEntries; // 0x1E0
	private bool _initialized; // 0x1E8
	private Dictionary<string, string> customDict; // 0x1F0

	// Properties
	public override string yes { get; }
	public override string no { get; }
	public override string add { get; }
	public override string replace { get; }
	public override string remove { get; }
	public override string swap { get; }
	public override string cancel { get; }
	public override string none { get; }
	public override string okay { get; }
	public override string done { get; }
	public override string default_ { get; }
	public override string assignControllerWindowTitle { get; }
	public override string assignControllerWindowMessage { get; }
	public override string controllerAssignmentConflictWindowTitle { get; }
	public override string elementAssignmentPrePollingWindowMessage { get; }
	public override string elementAssignmentConflictWindowMessage { get; }
	public override string mouseAssignmentConflictWindowTitle { get; }
	public override string calibrateControllerWindowTitle { get; }
	public override string calibrateAxisStep1WindowTitle { get; }
	public override string calibrateAxisStep2WindowTitle { get; }
	public override string inputBehaviorSettingsWindowTitle { get; }
	public override string restoreDefaultsWindowTitle { get; }
	public override string actionColumnLabel { get; }
	public override string keyboardColumnLabel { get; }
	public override string mouseColumnLabel { get; }
	public override string controllerColumnLabel { get; }
	public override string removeControllerButtonLabel { get; }
	public override string calibrateControllerButtonLabel { get; }
	public override string assignControllerButtonLabel { get; }
	public override string inputBehaviorSettingsButtonLabel { get; }
	public override string doneButtonLabel { get; }
	public override string restoreDefaultsButtonLabel { get; }
	public override string controllerSettingsGroupLabel { get; }
	public override string playersGroupLabel { get; }
	public override string assignedControllersGroupLabel { get; }
	public override string settingsGroupLabel { get; }
	public override string mapCategoriesGroupLabel { get; }
	public override string restoreDefaultsWindowMessage { get; }
	public override string calibrateWindow_deadZoneSliderLabel { get; }
	public override string calibrateWindow_zeroSliderLabel { get; }
	public override string calibrateWindow_sensitivitySliderLabel { get; }
	public override string calibrateWindow_invertToggleLabel { get; }
	public override string calibrateWindow_calibrateButtonLabel { get; }

	// Methods

	// RVA: 0x794460 Offset: 0x793660 VA: 0x180794460 Slot: 4
	public override void Initialize() { }

	// RVA: 0x793BD0 Offset: 0x792DD0 VA: 0x180793BD0 Slot: 5
	public override string GetCustomEntry(string key) { }

	// RVA: 0x793650 Offset: 0x792850 VA: 0x180793650 Slot: 6
	public override bool ContainsCustomEntryKey(string key) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	public override string get_yes() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public override string get_no() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 9
	public override string get_add() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 10
	public override string get_replace() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 11
	public override string get_remove() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 12
	public override string get_swap() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 13
	public override string get_cancel() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 14
	public override string get_none() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 15
	public override string get_okay() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 16
	public override string get_done() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 17
	public override string get_default_() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 18
	public override string get_assignControllerWindowTitle() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 19
	public override string get_assignControllerWindowMessage() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 20
	public override string get_controllerAssignmentConflictWindowTitle() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 21
	public override string get_elementAssignmentPrePollingWindowMessage() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0 Slot: 22
	public override string get_elementAssignmentConflictWindowMessage() { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80 Slot: 23
	public override string get_mouseAssignmentConflictWindowTitle() { }

	// RVA: 0x794CF0 Offset: 0x793EF0 VA: 0x180794CF0 Slot: 24
	public override string get_calibrateControllerWindowTitle() { }

	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0 Slot: 25
	public override string get_calibrateAxisStep1WindowTitle() { }

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810 Slot: 26
	public override string get_calibrateAxisStep2WindowTitle() { }

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510 Slot: 27
	public override string get_inputBehaviorSettingsWindowTitle() { }

	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70 Slot: 28
	public override string get_restoreDefaultsWindowTitle() { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0 Slot: 29
	public override string get_actionColumnLabel() { }

	// RVA: 0x78BCB0 Offset: 0x78AEB0 VA: 0x18078BCB0 Slot: 30
	public override string get_keyboardColumnLabel() { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90 Slot: 31
	public override string get_mouseColumnLabel() { }

	// RVA: 0x794D40 Offset: 0x793F40 VA: 0x180794D40 Slot: 32
	public override string get_controllerColumnLabel() { }

	// RVA: 0x794DA0 Offset: 0x793FA0 VA: 0x180794DA0 Slot: 33
	public override string get_removeControllerButtonLabel() { }

	// RVA: 0x794CE0 Offset: 0x793EE0 VA: 0x180794CE0 Slot: 34
	public override string get_calibrateControllerButtonLabel() { }

	// RVA: 0x78AC40 Offset: 0x789E40 VA: 0x18078AC40 Slot: 35
	public override string get_assignControllerButtonLabel() { }

	// RVA: 0x794D60 Offset: 0x793F60 VA: 0x180794D60 Slot: 36
	public override string get_inputBehaviorSettingsButtonLabel() { }

	// RVA: 0x794D50 Offset: 0x793F50 VA: 0x180794D50 Slot: 37
	public override string get_doneButtonLabel() { }

	// RVA: 0x78AC50 Offset: 0x789E50 VA: 0x18078AC50 Slot: 38
	public override string get_restoreDefaultsButtonLabel() { }

	// RVA: 0x72F760 Offset: 0x72E960 VA: 0x18072F760 Slot: 39
	public override string get_controllerSettingsGroupLabel() { }

	// RVA: 0x72F730 Offset: 0x72E930 VA: 0x18072F730 Slot: 40
	public override string get_playersGroupLabel() { }

	// RVA: 0x794CC0 Offset: 0x793EC0 VA: 0x180794CC0 Slot: 41
	public override string get_assignedControllersGroupLabel() { }

	// RVA: 0x794E30 Offset: 0x794030 VA: 0x180794E30 Slot: 42
