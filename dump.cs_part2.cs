	// RVA: 0x565840 Offset: 0x564A40 VA: 0x180565840 Slot: 8
	public void HandleDisconnect() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void ShowInviteMenu() { }

	// RVA: 0x566710 Offset: 0x565910 VA: 0x180566710
	public void ToggleButtonGlyphs(bool enabled) { }

	// RVA: 0x566A90 Offset: 0x565C90 VA: 0x180566A90
	public void UpdateMapImage(MapNames map) { }

	// RVA: 0x566740 Offset: 0x565940 VA: 0x180566740
	public void ToggleViewPane() { }

	// RVA: 0x565EA0 Offset: 0x5650A0 VA: 0x180565EA0
	public void SelectViewButton(bool selected) { }

	// RVA: 0x566A50 Offset: 0x565C50 VA: 0x180566A50
	public void UpdateHostPanelImage(NetworkedPlayerInfo player) { }

	// RVA: 0x564DC0 Offset: 0x563FC0 VA: 0x180564DC0
	public void CloseGameOptionsMenus() { }

	// RVA: 0x567D10 Offset: 0x566F10 VA: 0x180567D10
	public void .ctor() { }
}

// Namespace: 
public class GaugeRandomizer : MonoBehaviour // TypeDefIndex: 744
{
	// Fields
	public FloatRange Range; // 0x20
	public SpriteRenderer Gauge; // 0x28
	public float Frequency; // 0x30
	public float Offset; // 0x34
	private float naturalY; // 0x38
	private float naturalSizeY; // 0x3C
	private Color goodLineColor; // 0x40

	// Methods

	// RVA: 0x567D60 Offset: 0x566F60 VA: 0x180567D60
	public void Start() { }

	// RVA: 0x567DC0 Offset: 0x566FC0 VA: 0x180567DC0
	private void Update() { }

	// RVA: 0x567F00 Offset: 0x567100 VA: 0x180567F00
	public void .ctor() { }
}

// Namespace: 
public class Win10Manager : DestroyableSingleton<Win10Manager> // TypeDefIndex: 745
{
	// Fields
	private Dictionary<string, ulong> puid2xuid; // 0x28
	private List<KeyValuePair<string, ulong>> xUIDsToCheckIfBlocked; // 0x30
	private HashSet<string> nonXuids; // 0x38

	// Methods

	// RVA: 0x576BE0 Offset: 0x575DE0 VA: 0x180576BE0
	public void .ctor() { }
}

// Namespace: 
private struct CloudGenerator.Cloud // TypeDefIndex: 746
{
	// Fields
	public int CloudIdx; // 0x0
	public float Rate; // 0x4
	public float Size; // 0x8
	public float FlipX; // 0xC
	public float PositionX; // 0x10
	public float PositionY; // 0x14
	public float PositionZ; // 0x18
}

// Namespace: 
public class CloudGenerator : MonoBehaviour // TypeDefIndex: 747
{
	// Fields
	public Sprite[] CloudImages; // 0x20
	public int NumClouds; // 0x28
	public float Length; // 0x2C
	public float Width; // 0x30
	public Vector2 Direction; // 0x34
	public FloatRange Rates; // 0x40
	public FloatRange Sizes; // 0x48
	public bool Depth; // 0x50
	public float MaxDepth; // 0x54
	public float ParallaxOffset; // 0x58
	public float ParallaxStrength; // 0x5C
	[HideInInspector]
	private CloudGenerator.Cloud[] clouds; // 0x60
	private Vector2[] ExtentCache; // 0x68
	[HideInInspector]
	private Mesh mesh; // 0x70
	private Vector2 NormDir; // 0x78
	private Vector2 Tangent; // 0x80
	private float tanLen; // 0x88
	[HideInInspector]
	private Vector3[] verts; // 0x90

	// Methods

	// RVA: 0x562110 Offset: 0x561310 VA: 0x180562110
	public void Start() { }

	// RVA: 0x561FD0 Offset: 0x5611D0 VA: 0x180561FD0
	public void SetDirection(Vector2 dir) { }

	// RVA: 0x562A90 Offset: 0x561C90 VA: 0x180562A90
	private void Update() { }

	// RVA: 0x561FB0 Offset: 0x5611B0 VA: 0x180561FB0
	private float OrthoDistance(float pointx, float pointy) { }

	// RVA: 0x562F30 Offset: 0x562130 VA: 0x180562F30
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AuthGame.<Animate>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 748
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AuthGame <>4__this; // 0x20
	private WaitForSeconds <wait>5__2; // 0x28

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

	// RVA: 0x572CD0 Offset: 0x571ED0 VA: 0x180572CD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x573470 Offset: 0x572670 VA: 0x180573470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class AuthGame : Minigame // TypeDefIndex: 749
{
	// Fields
	public TextMeshPro TargetText; // 0x88
	public TextMeshPro NumberText; // 0x90
	public TextMeshPro OtherStatusText; // 0x98
	public int number; // 0xA0
	public string numString; // 0xA8
	private bool animating; // 0xB0
	private HqHudSystemType system; // 0xB8
	public SpriteRenderer OurLight; // 0xC0
	public SpriteRenderer TheirLight; // 0xC8
	public SpriteRenderer TimeBar; // 0xD0
	public AudioClip ButtonSound; // 0xD8
	public AudioClip AcceptSound; // 0xE0
	public AudioClip RejectSound; // 0xE8
	private int OtherConsoleId; // 0xF0
	private bool evenColor; // 0xF4
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xF8
	public UiElement DefaultButtonSelected; // 0x100
	public List<UiElement> ControllerSelectable; // 0x108

	// Methods

	// RVA: 0x561A70 Offset: 0x560C70 VA: 0x180561A70
	private void OnDisable() { }

	// RVA: 0x561560 Offset: 0x560760 VA: 0x180561560 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x561980 Offset: 0x560B80 VA: 0x180561980 Slot: 6
	public override void Close() { }

	// RVA: 0x561AE0 Offset: 0x560CE0 VA: 0x180561AE0
	public void Update() { }

	// RVA: 0x561820 Offset: 0x560A20 VA: 0x180561820
	public void ClickNumber(int i) { }

	// RVA: 0x561700 Offset: 0x560900 VA: 0x180561700
	public void ClearEntry() { }

	// RVA: 0x561A00 Offset: 0x560C00 VA: 0x180561A00
	public void Enter() { }

	[IteratorStateMachine(typeof(AuthGame.<Animate>d__25))]
	// RVA: 0x561500 Offset: 0x560700 VA: 0x180561500
	private IEnumerator Animate() { }

	// RVA: 0x561F60 Offset: 0x561160 VA: 0x180561F60
	public void .ctor() { }
}

// Namespace: 
public class DeconControl : MonoBehaviour, IUsable // TypeDefIndex: 750
{
	// Fields
	public DeconSystem System; // 0x20
	public float usableDistance; // 0x28
	public SpriteRenderer Image; // 0x30
	public AudioClip UseSound; // 0x38
	public Button.ButtonClickedEvent OnUse; // 0x40
	private const float CooldownDuration = 6;
	private float cooldown; // 0x48

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x563530 Offset: 0x562730 VA: 0x180563530 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x563250 Offset: 0x562450 VA: 0x180563250 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x5633B0 Offset: 0x5625B0 VA: 0x1805633B0
	public void Update() { }

	// RVA: 0x563050 Offset: 0x562250 VA: 0x180563050 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x5633F0 Offset: 0x5625F0 VA: 0x1805633F0 Slot: 9
	public void Use() { }

	// RVA: 0x558AA0 Offset: 0x557CA0 VA: 0x180558AA0
	public void .ctor() { }
}

// Namespace: 
[Flags]
public enum DeconSystem.States // TypeDefIndex: 751
{
	// Fields
	public byte value__; // 0x0
	public const DeconSystem.States Idle = 0;
	public const DeconSystem.States Enter = 1;
	public const DeconSystem.States Closed = 2;
	public const DeconSystem.States Exit = 4;
	public const DeconSystem.States HeadingUp = 8;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DeconSystem.<>c // TypeDefIndex: 752
{
	// Fields
	public static readonly DeconSystem.<>c <>9; // 0x0
	public static Action<ParticleSystem> <>9__25_0; // 0x8

	// Methods

	// RVA: 0x575A10 Offset: 0x574C10 VA: 0x180575A10
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575650 Offset: 0x574850 VA: 0x180575650
	internal void <CoRunSprayers>b__25_0(ParticleSystem p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DeconSystem.<CoRunSprayers>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 753
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DeconSystem <>4__this; // 0x20

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

	// RVA: 0x574AB0 Offset: 0x573CB0 VA: 0x180574AB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x574D60 Offset: 0x573F60 VA: 0x180574D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class DeconSystem : MonoBehaviour, ISystemType // TypeDefIndex: 754
{
	// Fields
	private const byte HeadUpCmd = 1;
	private const byte HeadDownCmd = 2;
	private const byte HeadUpInsideCmd = 3;
	private const byte HeadDownInsideCmd = 4;
	public SomeKindaDoor UpperDoor; // 0x20
	public SomeKindaDoor LowerDoor; // 0x28
	public float DoorOpenTime; // 0x30
	public float DeconTime; // 0x34
	public AudioClip SpraySound; // 0x38
	public ParticleSystem[] Particles; // 0x40
	public SystemTypes TargetSystem; // 0x48
	[CompilerGenerated]
	private DeconSystem.States <CurState>k__BackingField; // 0x49
	private float timer; // 0x4C
	public Collider2D RoomArea; // 0x50
	public DecontamNumController FloorText; // 0x58
	private Coroutine sprayers; // 0x60
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x68

	// Properties
	public DeconSystem.States CurState { get; set; }
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	public DeconSystem.States get_CurState() { }

	[CompilerGenerated]
	// RVA: 0x563E50 Offset: 0x563050 VA: 0x180563E50
	private void set_CurState(DeconSystem.States value) { }

	[CompilerGenerated]
	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	private void set_IsDirty(bool value) { }

	// RVA: 0x563610 Offset: 0x562810 VA: 0x180563610 Slot: 5
	public void Deteriorate(float dt) { }

	[IteratorStateMachine(typeof(DeconSystem.<CoRunSprayers>d__25))]
	// RVA: 0x563550 Offset: 0x562750 VA: 0x180563550
	private IEnumerator CoRunSprayers() { }

	// RVA: 0x563900 Offset: 0x562B00 VA: 0x180563900
	private void SoundDynamics(AudioSource source, float dt) { }

	// RVA: 0x563790 Offset: 0x562990 VA: 0x180563790
	public void OpenDoor(bool upper) { }

	// RVA: 0x563800 Offset: 0x562A00 VA: 0x180563800
	public void OpenFromInside(bool upper) { }

	// RVA: 0x563DA0 Offset: 0x562FA0 VA: 0x180563DA0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x563780 Offset: 0x562980 VA: 0x180563780 Slot: 7
	public void MarkClean() { }

	// RVA: 0x563870 Offset: 0x562A70 VA: 0x180563870 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x5635B0 Offset: 0x5627B0 VA: 0x1805635B0 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x563AF0 Offset: 0x562CF0 VA: 0x180563AF0
	private void UpdateDoorsViaState() { }

	// RVA: 0x563E10 Offset: 0x563010 VA: 0x180563E10
	public void .ctor() { }
}

// Namespace: 
public class DecontamNumController : MonoBehaviour // TypeDefIndex: 755
{
	// Fields
	public SpriteRenderer[] Images; // 0x20
	public Sprite[] NumImages; // 0x28

	// Methods

	[ContextMenu("Space Evenly")]
	// RVA: 0x563FF0 Offset: 0x5631F0 VA: 0x180563FF0
	public void SpaceEvenly() { }

	// RVA: 0x563E70 Offset: 0x563070 VA: 0x180563E70
	internal void SetSecond(float curSecond, float maxSecond) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class MiraShipStatus : ShipStatus // TypeDefIndex: 756
{
	// Methods

	// RVA: 0x5528E0 Offset: 0x551AE0 VA: 0x1805528E0
	public void .ctor() { }
}

// Namespace: 
public class LogEntryBubble : PoolableBehavior // TypeDefIndex: 757
{
	// Fields
	[SerializeField]
	private SpriteRenderer background; // 0x30
	[SerializeField]
	private SpriteRenderer maskArea; // 0x38
	[SerializeField]
	private PoolablePlayer player; // 0x40
	[SerializeField]
	private TextMeshPro text; // 0x48

	// Methods

	// RVA: 0x56C040 Offset: 0x56B240 VA: 0x18056C040
	public void DecorateLog(SecurityLogBehaviour.SecurityLogEntry entry, Sprite backgroundSprite) { }

	// RVA: 0x56C250 Offset: 0x56B450 VA: 0x18056C250
	public void SetMaskLayer(int maskLayer) { }

	// RVA: 0x56C1D0 Offset: 0x56B3D0 VA: 0x18056C1D0
	private void SetBackground(Sprite backgroundSprite) { }

	// RVA: 0x56C1F0 Offset: 0x56B3F0 VA: 0x18056C1F0
	private void SetCosmetics(NetworkedPlayerInfo playerData) { }

	// RVA: 0x56C330 Offset: 0x56B530 VA: 0x18056C330
	private void SetText(SecurityLogBehaviour.SecurityLogEntry entry, NetworkedPlayerInfo playerData) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public class SecurityLogGame : Minigame // TypeDefIndex: 758
{
	// Fields
	public float EntryHeight; // 0x88
	public ObjectPoolBehavior EntryPool; // 0x90
	public Sprite[] LocationBgs; // 0x98
	public TextMeshPro SabText; // 0xA0
	public float ScreenHeight; // 0xA8
	public Scroller scroller; // 0xB0
	private SecurityLogBehaviour Logger; // 0xB8

	// Methods

	// RVA: 0x571F90 Offset: 0x571190 VA: 0x180571F90
	public void Update() { }

	// RVA: 0x571970 Offset: 0x570B70 VA: 0x180571970
	private void Awake() { }

	// RVA: 0x571A70 Offset: 0x570C70 VA: 0x180571A70
	private void RefreshScreen() { }

	// RVA: 0x5720D0 Offset: 0x5712D0 VA: 0x1805720D0
	public void .ctor() { }
}

// Namespace: 
public class SensorDoor : MonoBehaviour // TypeDefIndex: 759
{
	// Fields
	public SpriteRenderer LeftSide; // 0x20
	public SpriteRenderer RightSide; // 0x28
	public float ActivationDistance; // 0x30
	public bool Opening; // 0x34
	public float OpenDuration; // 0x38
	private float openTimer; // 0x3C
	public AudioClip OpenSound; // 0x40
	public AudioClip CloseSound; // 0x48
	private const float slideVibrationIntensity = 3;

	// Methods

	// RVA: 0x572540 Offset: 0x571740 VA: 0x180572540
	public void OnEnable() { }

	[ContextMenu("Set Right Uvs")]
	// RVA: 0x5725B0 Offset: 0x5717B0 VA: 0x1805725B0
	public void SetUvs() { }

	// RVA: 0x5725C0 Offset: 0x5717C0 VA: 0x1805725C0
	private void Update() { }

	// RVA: 0x5720F0 Offset: 0x5712F0 VA: 0x1805720F0
	private void CheckDoor() { }

	// RVA: 0x5727C0 Offset: 0x5719C0 VA: 0x1805727C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingMinigame.<Animate>d__29 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 760
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VendingMinigame <>4__this; // 0x20
	private int <slotId>5__2; // 0x28
	private WaitForSeconds <wait>5__3; // 0x30

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

	// RVA: 0x5734B0 Offset: 0x5726B0 VA: 0x1805734B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x573A80 Offset: 0x572C80 VA: 0x180573A80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingMinigame.<BlinkAccept>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 761
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VendingMinigame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x573D80 Offset: 0x572F80 VA: 0x180573D80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x573EB0 Offset: 0x5730B0 VA: 0x180573EB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingMinigame.<CoBlinkVend>d__30 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 762
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VendingMinigame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x5741F0 Offset: 0x5733F0 VA: 0x1805741F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5743D0 Offset: 0x5735D0 VA: 0x1805743D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class VendingMinigame : Minigame // TypeDefIndex: 763
{
	// Fields
	public static readonly string[] Letters; // 0x0
	public TextMeshPro NumberText; // 0x88
	public SpriteRenderer TargetImage; // 0x90
	public string enteredCode; // 0x98
	private bool animating; // 0xA0
	private bool done; // 0xA1
	private string targetCode; // 0xA8
	public SpriteRenderer AcceptButton; // 0xB0
	public VendingSlot[] Slots; // 0xB8
	public Sprite[] Drinks; // 0xC0
	public Sprite[] DrawnDrinks; // 0xC8
	public AudioClip Ambience; // 0xD0
	public AudioClip Button; // 0xD8
	public AudioClip Error; // 0xE0
	public AudioClip SliderOpen; // 0xE8
	public AudioClip DrinkShake; // 0xF0
	public AudioClip DrinkLand; // 0xF8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x100
	public UiElement DefaultButtonSelected; // 0x108
	public List<UiElement> ControllerSelectable; // 0x110

	// Methods

	// RVA: 0x576370 Offset: 0x575570 VA: 0x180576370
	private void OnDisable() { }

	// RVA: 0x575CF0 Offset: 0x574EF0 VA: 0x180575CF0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x576550 Offset: 0x575750 VA: 0x180576550
	private static int StringToSlotId(string code) { }

	// RVA: 0x5764A0 Offset: 0x5756A0 VA: 0x1805764A0
	private static string SlotIdToString(int slotId) { }

	// RVA: 0x5763E0 Offset: 0x5755E0 VA: 0x1805763E0
	private bool PickARandomSlot(Sprite drink, out int slotId) { }

	// RVA: 0x5761B0 Offset: 0x5753B0 VA: 0x1805761B0
	public void EnterDigit(string s) { }

	// RVA: 0x576010 Offset: 0x575210 VA: 0x180576010
	public void ClearDigits() { }

	// RVA: 0x575B30 Offset: 0x574D30 VA: 0x180575B30
	public void AcceptDigits() { }

	[IteratorStateMachine(typeof(VendingMinigame.<BlinkAccept>d__28))]
	// RVA: 0x575FB0 Offset: 0x5751B0 VA: 0x180575FB0
	private IEnumerator BlinkAccept() { }

	[IteratorStateMachine(typeof(VendingMinigame.<Animate>d__29))]
	// RVA: 0x575C90 Offset: 0x574E90 VA: 0x180575C90
	private IEnumerator Animate() { }

	[IteratorStateMachine(typeof(VendingMinigame.<CoBlinkVend>d__30))]
	// RVA: 0x576150 Offset: 0x575350 VA: 0x180576150
	private IEnumerator CoBlinkVend() { }

	// RVA: 0x576850 Offset: 0x575A50 VA: 0x180576850
	public void .ctor() { }

	// RVA: 0x576790 Offset: 0x575990 VA: 0x180576790
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingSlot.<CloseSlider>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 764
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AudioClip sliderOpen; // 0x20
	public VendingSlot <>4__this; // 0x28

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

	// RVA: 0x573FE0 Offset: 0x5731E0 VA: 0x180573FE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5741B0 Offset: 0x5733B0 VA: 0x1805741B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingSlot.<CoBuy>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 765
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AudioClip sliderOpen; // 0x20
	public VendingSlot <>4__this; // 0x28
	public AudioClip drinkShake; // 0x30
	public AudioClip drinkLand; // 0x38

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

	// RVA: 0x574410 Offset: 0x573610 VA: 0x180574410 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x574A70 Offset: 0x573C70 VA: 0x180574A70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VendingSlot.<PlayLand>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 766
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AudioClip drinkLand; // 0x20

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

	// RVA: 0x574DA0 Offset: 0x573FA0 VA: 0x180574DA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x574ED0 Offset: 0x5740D0 VA: 0x180574ED0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class VendingSlot : MonoBehaviour // TypeDefIndex: 767
{
	// Fields
	public SpriteRenderer DrinkImage; // 0x20
	public SpriteRenderer GlassImage; // 0x28
	private const float SlideDuration = 0,75;
	private const float SlideVibrateIntensity = 0,05;
	private const float DrunkThunkVibrateIntensity = 0,4;

	// Methods

	[IteratorStateMachine(typeof(VendingSlot.<CoBuy>d__5))]
	// RVA: 0x576910 Offset: 0x575B10 VA: 0x180576910
	public IEnumerator CoBuy(AudioClip sliderOpen, AudioClip drinkShake, AudioClip drinkLand) { }

	[IteratorStateMachine(typeof(VendingSlot.<CloseSlider>d__6))]
	// RVA: 0x5768A0 Offset: 0x575AA0 VA: 0x1805768A0
	public IEnumerator CloseSlider(AudioClip sliderOpen) { }

	[IteratorStateMachine(typeof(VendingSlot.<PlayLand>d__7))]
	// RVA: 0x5769A0 Offset: 0x575BA0 VA: 0x1805769A0
	private IEnumerator PlayLand(AudioClip drinkLand) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x576AF0 Offset: 0x575CF0 VA: 0x180576AF0
	private void <CoBuy>b__5_0(float v) { }

	[CompilerGenerated]
	// RVA: 0x576A00 Offset: 0x575C00 VA: 0x180576A00
	private void <CloseSlider>b__6_0(float v) { }
}

// Namespace: 
public class HoverAnimBehaviour : MonoBehaviour // TypeDefIndex: 768
{
	// Fields
	public FloatRange YMovement; // 0x20
	public float Speed; // 0x28
	public float Shift; // 0x2C
	private float offset; // 0x30

	// Methods

	// RVA: 0x569E80 Offset: 0x569080 VA: 0x180569E80
	private void Start() { }

	// RVA: 0x569EB0 Offset: 0x5690B0 VA: 0x180569EB0
	private void Update() { }

	// RVA: 0x569F70 Offset: 0x569170 VA: 0x180569F70
	public void .ctor() { }
}

// Namespace: 
public abstract class AbstractHowToPlayScenePage : MonoBehaviour // TypeDefIndex: 769
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConditionalHowToPlayScenePage : PEW.ConditionalValue<AbstractHowToPlayScenePage> // TypeDefIndex: 770
{
	// Methods

	// RVA: 0x563010 Offset: 0x562210 VA: 0x180563010
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HowToPlayRolePage // TypeDefIndex: 771
{
	// Fields
	public RoleTypes role; // 0x10
	public Sprite roleIcon; // 0x18
	public List<HowToPlayScenePage> rolePages; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum HowToPlayScene.HowToPlayCategory // TypeDefIndex: 772
{
	// Fields
	public int value__; // 0x0
	public const HowToPlayScene.HowToPlayCategory None = 0;
	public const HowToPlayScene.HowToPlayCategory GameMode_Classic = 100;
	public const HowToPlayScene.HowToPlayCategory GameMode_HideAndSeek = 101;
	public const HowToPlayScene.HowToPlayCategory Roles = 200;
	public const HowToPlayScene.HowToPlayCategory RolesSelection = 201;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HowToPlayScene.<>c // TypeDefIndex: 773
{
	// Fields
	public static readonly HowToPlayScene.<>c <>9; // 0x0
	public static Func<RoleBehaviour, string> <>9__27_0; // 0x8
	public static Action<AbstractHowToPlayScenePage> <>9__32_0; // 0x10
	public static Action<AbstractHowToPlayScenePage> <>9__32_1; // 0x18
	public static Action<HowToPlayRolePage> <>9__32_2; // 0x20

	// Methods

	// RVA: 0x58ACA0 Offset: 0x589EA0 VA: 0x18058ACA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A980 Offset: 0x589B80 VA: 0x18058A980
	internal string <OpenRolesSelectionMenu>b__27_0(RoleBehaviour role) { }

	// RVA: 0x58A8F0 Offset: 0x589AF0 VA: 0x18058A8F0
	internal void <DisableAllScenes>b__32_0(AbstractHowToPlayScenePage x) { }

	// RVA: 0x58A8F0 Offset: 0x589AF0 VA: 0x18058A8F0
	internal void <DisableAllScenes>b__32_1(AbstractHowToPlayScenePage x) { }

	// RVA: 0x58A930 Offset: 0x589B30 VA: 0x18058A930
	internal void <DisableAllScenes>b__32_2(HowToPlayRolePage x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlayScene.<>c__DisplayClass27_0 // TypeDefIndex: 774
{
	// Fields
	public RoleBehaviour role; // 0x10
	public HowToPlayScene <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58AA20 Offset: 0x589C20 VA: 0x18058AA20
	internal bool <OpenRolesSelectionMenu>b__1(HowToPlayRolePage r) { }

	// RVA: 0x58AA50 Offset: 0x589C50 VA: 0x18058AA50
	internal void <OpenRolesSelectionMenu>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlayScene.<>c__DisplayClass29_0 // TypeDefIndex: 775
{
	// Fields
	public RoleTypes roleType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58AA80 Offset: 0x589C80 VA: 0x18058AA80
	internal bool <OpenRolePage>b__0(HowToPlayRolePage r) { }
}

// Namespace: 
public class HowToPlayScene : MonoBehaviour // TypeDefIndex: 776
{
	// Fields
	public static string SceneOnClose; // 0x0
	[Header("UI")]
	[SerializeField]
	private GameObject startPage; // 0x20
	[Space(10)]
	[SerializeField]
	private GameObject arrows; // 0x28
	[SerializeField]
	private SpriteRenderer leftButton; // 0x30
	[SerializeField]
	private SpriteRenderer rightButton; // 0x38
	[Space(10)]
	[SerializeField]
	private UiElement closeButton; // 0x40
	[Space(10)]
	[SerializeField]
	private Transform dotParent; // 0x48
	[SerializeField]
	private Transform dotTemplate; // 0x50
	[SerializeField]
	[Header("Game Mode Scenes")]
	private AbstractHowToPlayScenePage[] classicScenes; // 0x58
	[SerializeField]
	private AbstractHowToPlayScenePage[] hideAndSeekScenes; // 0x60
	[SerializeField]
	[Space(10)]
	private ConditionalHowToPlayScenePage pcMove; // 0x68
	[Header("Misc Scenes")]
	[SerializeField]
	private GameObject roleSelectionScene; // 0x70
	[SerializeField]
	private Transform roleButtonsParent; // 0x78
	[SerializeField]
	private GameObject roleButtonPrefab; // 0x80
	[SerializeField]
	private PassiveButton roleRightArrowButton; // 0x88
	[SerializeField]
	private PassiveButton roleLeftArrowButton; // 0x90
	[SerializeField]
	private List<HowToPlayRolePage> rolesScenes; // 0x98
	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement defaultButtonSelected; // 0xA0
	[SerializeField]
	private List<UiElement> controllerSelectables; // 0xA8
	private int sceneIndex; // 0xB0
	private int rolePageIndex; // 0xB4
	private Transform[] dots; // 0xB8
	private HowToPlayScene.HowToPlayCategory category; // 0xC0

	// Methods

	// RVA: 0x56BF40 Offset: 0x56B140 VA: 0x18056BF40
	public void Start() { }

	// RVA: 0x56BD20 Offset: 0x56AF20 VA: 0x18056BD20
	public void StartClassic() { }

	// RVA: 0x56BE80 Offset: 0x56B080 VA: 0x18056BE80
	public void StartHideAndSeek() { }

	// RVA: 0x56B0F0 Offset: 0x56A2F0 VA: 0x18056B0F0
	public void OpenRolesSelectionMenu() { }

	// RVA: 0x56AF40 Offset: 0x56A140 VA: 0x18056AF40
	public void OpenRolesDescription() { }

	// RVA: 0x56AD90 Offset: 0x569F90 VA: 0x18056AD90
	public void OpenRolePage(RoleTypes roleType) { }

	// RVA: 0x56B7E0 Offset: 0x56A9E0 VA: 0x18056B7E0
	private void Reset() { }

	// RVA: 0x56C010 Offset: 0x56B210 VA: 0x18056C010
	public void Update() { }

	// RVA: 0x56AAC0 Offset: 0x569CC0 VA: 0x18056AAC0
	private void DisableAllScenes() { }

	// RVA: 0x56AD80 Offset: 0x569F80 VA: 0x18056AD80
	public void NextScene() { }

	// RVA: 0x56B7D0 Offset: 0x56A9D0 VA: 0x18056B7D0
	public void PreviousScene() { }

	// RVA: 0x569F90 Offset: 0x569190 VA: 0x180569F90
	public void AdjustRolePage(int dir) { }

	// RVA: 0x56A890 Offset: 0x569A90 VA: 0x18056A890
	public void Close() { }

	// RVA: 0x56A1B0 Offset: 0x5693B0 VA: 0x18056A1B0
	private void ChangeScene(int del) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	private bool CanClose() { }

	// RVA: 0x56B960 Offset: 0x56AB60 VA: 0x18056B960
	private void SetupDots(int count) { }

	// RVA: 0x56B850 Offset: 0x56AA50 VA: 0x18056B850
	private void SetActiveDot(int index) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPage.<DoUse>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 777
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HowToPlaySceneMovementPage <>4__this; // 0x20
	public int idx; // 0x28
	public int consoleid; // 0x2C
	private HowToPlaySceneMovementPagePlayerAnimator <myPlayer>5__2; // 0x30

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

	// RVA: 0x589960 Offset: 0x588B60 VA: 0x180589960 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x589DA0 Offset: 0x588FA0 VA: 0x180589DA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPage.<RunPlayer>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 778
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HowToPlaySceneMovementPage <>4__this; // 0x20
	public int idx; // 0x28
	private HowToPlaySceneMovementPagePlayerAnimator <myPlayer>5__2; // 0x30
	private int <i>5__3; // 0x38
	private bool <willInterrupt>5__4; // 0x3C

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

	// RVA: 0x58A3A0 Offset: 0x5895A0 VA: 0x18058A3A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58A5A0 Offset: 0x5897A0 VA: 0x18058A5A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPage.<WaitForSeconds>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 779
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float duration; // 0x20
	private float <time>5__2; // 0x24

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

	// RVA: 0x58AEA0 Offset: 0x58A0A0 VA: 0x18058AEA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58AF20 Offset: 0x58A120 VA: 0x18058AF20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HowToPlaySceneMovementPage : AbstractHowToPlayScenePage // TypeDefIndex: 780
{
	// Fields
	public HowToPlaySceneMovementPagePlayerAnimator[] players; // 0x20
	public HowToPlaySceneMovementPageDummyConsole[] Consoles; // 0x28
	public Vector2[] WayPoints; // 0x30
	public Camera backupCam; // 0x38

	// Methods

	// RVA: 0x586960 Offset: 0x585B60 VA: 0x180586960
	public void OnDrawGizmos() { }

	// RVA: 0x586A50 Offset: 0x585C50 VA: 0x180586A50
	public void OnEnable() { }

	// RVA: 0x5868D0 Offset: 0x585AD0 VA: 0x1805868D0
	public void OnDisable() { }

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPage.<RunPlayer>d__7))]
	// RVA: 0x586B40 Offset: 0x585D40 VA: 0x180586B40
	private IEnumerator RunPlayer(int idx) { }

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPage.<DoUse>d__8))]
	// RVA: 0x586850 Offset: 0x585A50 VA: 0x180586850
	private IEnumerator DoUse(int idx, int consoleid) { }

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPage.<WaitForSeconds>d__9))]
	// RVA: 0x586BB0 Offset: 0x585DB0 VA: 0x180586BB0
	public static IEnumerator WaitForSeconds(float duration) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public class HowToPlaySceneMovementPageDemoKeyboardStick : VirtualJoystick // TypeDefIndex: 781
{
	// Fields
	public SpriteRenderer UpKey; // 0x60
	public SpriteRenderer DownKey; // 0x68
	public SpriteRenderer LeftKey; // 0x70
	public SpriteRenderer RightKey; // 0x78

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected override void FixedUpdate() { }

	// RVA: 0x585C70 Offset: 0x584E70 VA: 0x180585C70 Slot: 8
	public override void UpdateJoystick(HowToPlaySceneMovementPageFingerBehaviour finger, Vector2 velocity, bool syncFinger) { }

	// RVA: 0x585D20 Offset: 0x584F20 VA: 0x180585D20
	public void .ctor() { }
}

// Namespace: 
public class HowToPlaySceneMovementPageDummyConsole : MonoBehaviour // TypeDefIndex: 782
{
	// Fields
	public int ConsoleId; // 0x20
	public HowToPlaySceneMovementPagePlayerAnimator[] Players; // 0x28
	public float UseDistance; // 0x30
	[HideInInspector]
	private SpriteRenderer rend; // 0x38

	// Methods

	// RVA: 0x586070 Offset: 0x585270 VA: 0x180586070
	public void Start() { }

	// RVA: 0x585D30 Offset: 0x584F30 VA: 0x180585D30
	public void FixedUpdate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public static class HowToPlaySceneMovementPageFingerBehaviour.Quadratic // TypeDefIndex: 783
{
	// Methods

	// RVA: 0x587810 Offset: 0x586A10 VA: 0x180587810
	public static float InOut(float k) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPageFingerBehaviour.<DoClick>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 784
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float duration; // 0x20
	public HowToPlaySceneMovementPageFingerBehaviour <>4__this; // 0x28
	private float <time>5__2; // 0x30

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

	// RVA: 0x589720 Offset: 0x588920 VA: 0x180589720 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x589920 Offset: 0x588B20 VA: 0x180589920 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPageFingerBehaviour.<MoveTo>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 785
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HowToPlaySceneMovementPageFingerBehaviour <>4__this; // 0x20
	public Vector2 target; // 0x28
	public float duration; // 0x30
	private Vector3 <startPos>5__2; // 0x34
	private Vector3 <targetPos>5__3; // 0x40
	private float <time>5__4; // 0x4C

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

	// RVA: 0x589DE0 Offset: 0x588FE0 VA: 0x180589DE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x589FB0 Offset: 0x5891B0 VA: 0x180589FB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HowToPlaySceneMovementPageFingerBehaviour : MonoBehaviour // TypeDefIndex: 786
{
	// Fields
	public SpriteRenderer Finger; // 0x20
	public SpriteRenderer Click; // 0x28
	public float liftedAngle; // 0x30

	// Methods

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPageFingerBehaviour.<DoClick>d__3))]
	// RVA: 0x586130 Offset: 0x585330 VA: 0x180586130
	public IEnumerator DoClick(float duration) { }

	// RVA: 0x586230 Offset: 0x585430 VA: 0x180586230
	private void SetFingerAngle(float angle) { }

	// RVA: 0x5860B0 Offset: 0x5852B0 VA: 0x1805860B0
	public void ClickOff() { }

	// RVA: 0x5860F0 Offset: 0x5852F0 VA: 0x1805860F0
	public void ClickOn() { }

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPageFingerBehaviour.<MoveTo>d__7))]
	// RVA: 0x5861A0 Offset: 0x5853A0 VA: 0x1805861A0
	public IEnumerator MoveTo(Vector2 target, float duration) { }

	// RVA: 0x5862B0 Offset: 0x5854B0 VA: 0x1805862B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlaySceneMovementPagePlayerAnimator.<WalkPlayerTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 787
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Vector2 worldPos; // 0x20
	public HowToPlaySceneMovementPagePlayerAnimator <>4__this; // 0x28
	public float tolerance; // 0x30
	public bool relax; // 0x34

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

	// RVA: 0x58AF60 Offset: 0x58A160 VA: 0x18058AF60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58B310 Offset: 0x58A510 VA: 0x18058B310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HowToPlaySceneMovementPagePlayerAnimator : MonoBehaviour // TypeDefIndex: 788
{
	// Fields
	public float Speed; // 0x20
	public VirtualJoystick joystick; // 0x28
	public SpriteRenderer UseButton; // 0x30
	public HowToPlaySceneMovementPageFingerBehaviour finger; // 0x38
	public AnimationClip RunAnim; // 0x40
	public AnimationClip IdleAnim; // 0x48
	private Vector2 velocity; // 0x50
	[HideInInspector]
	private SpriteAnim Animator; // 0x58
	[HideInInspector]
	private SpriteRenderer rend; // 0x60
	public int NearbyConsoles; // 0x68

	// Methods

	// RVA: 0x586490 Offset: 0x585690 VA: 0x180586490
	private void Start() { }

	// RVA: 0x5862C0 Offset: 0x5854C0 VA: 0x1805862C0
	public void FixedUpdate() { }

	// RVA: 0x586360 Offset: 0x585560 VA: 0x180586360
	public void LateUpdate() { }

	[IteratorStateMachine(typeof(HowToPlaySceneMovementPagePlayerAnimator.<WalkPlayerTo>d__13))]
	// RVA: 0x5867A0 Offset: 0x5859A0 VA: 0x1805867A0
	public IEnumerator WalkPlayerTo(Vector2 worldPos, bool relax, float tolerance = 0,01) { }

	// RVA: 0x586840 Offset: 0x585A40 VA: 0x180586840
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlayScenePage.<PopIn>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 789
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SpriteRenderer boy; // 0x20
	public HowToPlayScenePage <>4__this; // 0x28
	private float <timer>5__2; // 0x30

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

	// RVA: 0x589FF0 Offset: 0x5891F0 VA: 0x180589FF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58A180 Offset: 0x589380 VA: 0x18058A180 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlayScenePage.<PopOut>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 790
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SpriteRenderer boy; // 0x20
	public HowToPlayScenePage <>4__this; // 0x28
	private float <timer>5__2; // 0x30

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

	// RVA: 0x58A1C0 Offset: 0x5893C0 VA: 0x18058A1C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58A360 Offset: 0x589560 VA: 0x18058A360 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HowToPlayScenePage.<Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 791
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HowToPlayScenePage <>4__this; // 0x20
	private int <lastBoy>5__2; // 0x28
	private float <start>5__3; // 0x2C

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

	// RVA: 0x58A5E0 Offset: 0x5897E0 VA: 0x18058A5E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58A890 Offset: 0x589A90 VA: 0x18058A890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HowToPlayScenePage : AbstractHowToPlayScenePage // TypeDefIndex: 792
{
	// Fields
	public float Duration; // 0x20
	public SpriteRenderer[] ExtraBoys; // 0x28
	public AnimationCurve PopInCurve; // 0x30
	public AnimationCurve PopOutCurve; // 0x38
	public float OutDuration; // 0x40

	// Methods

	// RVA: 0x586C90 Offset: 0x585E90 VA: 0x180586C90
	public void OnEnable() { }

	// RVA: 0x586C10 Offset: 0x585E10 VA: 0x180586C10
	public void OnDisable() { }

	[IteratorStateMachine(typeof(HowToPlayScenePage.<Run>d__7))]
	// RVA: 0x586DE0 Offset: 0x585FE0 VA: 0x180586DE0
	private IEnumerator Run() { }

	[IteratorStateMachine(typeof(HowToPlayScenePage.<PopIn>d__8))]
	// RVA: 0x586D00 Offset: 0x585F00 VA: 0x180586D00
	private IEnumerator PopIn(SpriteRenderer boy) { }

	[IteratorStateMachine(typeof(HowToPlayScenePage.<PopOut>d__9))]
	// RVA: 0x586D70 Offset: 0x585F70 VA: 0x180586D70
	private IEnumerator PopOut(SpriteRenderer boy) { }

	// RVA: 0x586E40 Offset: 0x586040 VA: 0x180586E40
	public void .ctor() { }
}

// Namespace: 
public class HowToPlaySceneRoleTitle : MonoBehaviour // TypeDefIndex: 793
{
	// Fields
	[SerializeField]
	private TMP_Text text; // 0x20
	[SerializeField]
	private StringNames teamString; // 0x28
	[SerializeField]
	private StringNames roleName; // 0x2C
	[SerializeField]
	private Color roleColor; // 0x30

	// Methods

	// RVA: 0x586E60 Offset: 0x586060 VA: 0x180586E60
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class HowToPlayRoleButton : MonoBehaviour // TypeDefIndex: 794
{
	// Fields
	[SerializeField]
	private SpriteRenderer background; // 0x20
	[SerializeField]
	private SpriteRenderer border; // 0x28
	[SerializeField]
	private SpriteRenderer roleIcon; // 0x30
	[SerializeField]
	private TextMeshPro roleName; // 0x38
	[SerializeField]
	private PassiveButton passiveButton; // 0x40
	[SerializeField]
	private GameObject newRoleAlert; // 0x48
	[SerializeField]
	private int MaskLayer; // 0x50
	[SerializeField]
	private Collider2D collider; // 0x58
	private readonly float offscreenYPos; // 0x60

	// Methods

	// RVA: 0x585A00 Offset: 0x584C00 VA: 0x180585A00
	private void OnEnable() { }

	// RVA: 0x585B80 Offset: 0x584D80 VA: 0x180585B80
	public void SetRoleInfo(RoleBehaviour role, Sprite roleIcon) { }

	// RVA: 0x585B00 Offset: 0x584D00 VA: 0x180585B00
	public void SetButtonAction(Action action) { }

	// RVA: 0x585C00 Offset: 0x584E00 VA: 0x180585C00
	private void Update() { }

	// RVA: 0x585C60 Offset: 0x584E60 VA: 0x180585C60
	public void .ctor() { }
}

// Namespace: 
public class AmongUsLoadingBar : MonoBehaviour // TypeDefIndex: 795
{
	// Fields
	[SerializeField]
	private Image barFill; // 0x20
	[SerializeField]
	private TextMeshProUGUI percentText; // 0x28
	[SerializeField]
	private TextMeshProUGUI loadingText; // 0x30
	[SerializeField]
	private Transform crewmate; // 0x38

	// Methods

	// RVA: 0x5785C0 Offset: 0x5777C0 VA: 0x1805785C0
	private void OnEnable() { }

	// RVA: 0x578640 Offset: 0x577840 VA: 0x180578640
	public void SetLoadingPercent(float percent, StringNames loadText = 0) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum AspectPosition.EdgeAlignments // TypeDefIndex: 796
{
	// Fields
	public int value__; // 0x0
	public const AspectPosition.EdgeAlignments RightBottom = 6;
	public const AspectPosition.EdgeAlignments LeftBottom = 5;
	public const AspectPosition.EdgeAlignments RightTop = 10;
	public const AspectPosition.EdgeAlignments Left = 1;
	public const AspectPosition.EdgeAlignments Right = 2;
	public const AspectPosition.EdgeAlignments Top = 8;
	public const AspectPosition.EdgeAlignments Bottom = 4;
	public const AspectPosition.EdgeAlignments LeftTop = 9;
	public const AspectPosition.EdgeAlignments Center = 16;
}

// Namespace: 
public class AspectPosition : MonoBehaviour // TypeDefIndex: 797
{
	// Fields
	public Camera parentCam; // 0x20
	private const int LeftFlag = 1;
	private const int RightFlag = 2;
	private const int BottomFlag = 4;
	private const int TopFlag = 8;
	private const int CenterFlag = 16;
	public bool updateAlways; // 0x28
	[Tooltip("Screen Coordinates 0-1")]
	public Vector2 anchorPoint; // 0x2C
	public Vector3 DistanceFromEdge; // 0x34
	public AspectPosition.EdgeAlignments Alignment; // 0x40

	// Methods

	// RVA: 0x579620 Offset: 0x578820 VA: 0x180579620
	public void Update() { }

	// RVA: 0x5793F0 Offset: 0x5785F0 VA: 0x1805793F0
	private void OnEnable() { }

	// RVA: 0x5794C0 Offset: 0x5786C0 VA: 0x1805794C0
	internal void SetNormalizedX(float nx, float widthPadding) { }

	// RVA: 0x579380 Offset: 0x578580 VA: 0x180579380
	private void OnDisable() { }

	// RVA: 0x578A80 Offset: 0x577C80 VA: 0x180578A80
	public void AdjustPosition() { }

	// RVA: 0x5794B0 Offset: 0x5786B0 VA: 0x1805794B0
	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen) { }

	// RVA: 0x5788C0 Offset: 0x577AC0 VA: 0x1805788C0
	public void AdjustPosition(float aspect) { }

	// RVA: 0x579250 Offset: 0x578450 VA: 0x180579250
	public static Vector3 ComputeWorldPosition(Camera cam, AspectPosition.EdgeAlignments alignment, Vector3 relativePos) { }

	// RVA: 0x579160 Offset: 0x578360 VA: 0x180579160
	public static Vector3 ComputePosition(AspectPosition.EdgeAlignments alignment, Vector3 relativePos) { }

	// RVA: 0x579100 Offset: 0x578300 VA: 0x180579100
	public static Vector3 ComputePosition(AspectPosition.EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect) { }

	// RVA: 0x578D60 Offset: 0x577F60 VA: 0x180578D60
	public static Vector3 ComputePositionSafeArea(AspectPosition.EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect, Camera cam) { }

	// RVA: 0x578B40 Offset: 0x577D40 VA: 0x180578B40
	public Vector3 ComputePositionAnchor(Camera cam, Vector3 relativePos, Vector2 anchor, float aspect) { }

	// RVA: 0x579630 Offset: 0x578830 VA: 0x180579630
	public void .ctor() { }
}

// Namespace: 
public class AspectSize : MonoBehaviour // TypeDefIndex: 798
{
	// Fields
	public Sprite Background; // 0x20
	public SpriteRenderer Renderer; // 0x28
	private Vector2 lastScreenSize; // 0x30
	public float PercentWidth; // 0x38
	private Nullable<Vector3> originalScale; // 0x3C

	// Methods

	// RVA: 0x579CA0 Offset: 0x578EA0 VA: 0x180579CA0
	private void OnValidate() { }

	// RVA: 0x5797F0 Offset: 0x5789F0 VA: 0x1805797F0
	public static float CalculateSize(Vector3 parentPos, Sprite sprite, float percentWidth) { }

	// RVA: 0x579DE0 Offset: 0x578FE0 VA: 0x180579DE0
	private void Update() { }

	// RVA: 0x5798B0 Offset: 0x578AB0 VA: 0x1805798B0
	private void DoSetUp() { }

	// RVA: 0x579C80 Offset: 0x578E80 VA: 0x180579C80
	private void OnEnable() { }

	// RVA: 0x579C10 Offset: 0x578E10 VA: 0x180579C10
	private void OnDisable() { }

	// RVA: 0x579BA0 Offset: 0x578DA0 VA: 0x180579BA0
	private void OnDestroy() { }

	// RVA: 0x579C90 Offset: 0x578E90 VA: 0x180579C90
	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen) { }

	// RVA: 0x579650 Offset: 0x578850 VA: 0x180579650
	private void AdjustScale(float aspect) { }

	// RVA: 0x5799D0 Offset: 0x578BD0 VA: 0x1805799D0
	private float GetScale(float orthographicSize, float aspect) { }

	// RVA: 0x579E60 Offset: 0x579060 VA: 0x180579E60
	public void .ctor() { }
}

// Namespace: 
public class AspectSpacer : MonoBehaviour // TypeDefIndex: 799
{
	// Fields
	public float xSpacing; // 0x20
	public float defaultAspectRatio; // 0x24
	public bool spaceWiderAspectRatios; // 0x28

	// Methods

	// RVA: 0x579EC0 Offset: 0x5790C0 VA: 0x180579EC0
	public void OnEnable() { }

	// RVA: 0x57A240 Offset: 0x579440 VA: 0x18057A240
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BanButton.<CoSetVotes>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 800
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int oldNum; // 0x20
	public int newNum; // 0x24
	public BanButton <>4__this; // 0x28
	private float <end>5__2; // 0x30
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

	// RVA: 0x589550 Offset: 0x588750 VA: 0x180589550 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5896E0 Offset: 0x5888E0 VA: 0x1805896E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class BanButton : MonoBehaviour // TypeDefIndex: 801
{
	// Fields
	[CompilerGenerated]
	private BanMenu <Parent>k__BackingField; // 0x20
	public TextMeshPro NameText; // 0x28
	public SpriteRenderer Background; // 0x30
	public int TargetClientId; // 0x38
	public int numVotes; // 0x3C

	// Properties
	public BanMenu Parent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public BanMenu get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Parent(BanMenu value) { }

	// RVA: 0x57A450 Offset: 0x579650 VA: 0x18057A450
	public void Start() { }

	// RVA: 0x57A2D0 Offset: 0x5794D0 VA: 0x18057A2D0
	public void Select() { }

	// RVA: 0x57A460 Offset: 0x579660 VA: 0x18057A460
	public void Unselect() { }

	// RVA: 0x57A3C0 Offset: 0x5795C0 VA: 0x18057A3C0
	public void SetVotes(int newVotes) { }

	[IteratorStateMachine(typeof(BanButton.<CoSetVotes>d__12))]
	// RVA: 0x57A250 Offset: 0x579450 VA: 0x18057A250
	private IEnumerator CoSetVotes(int oldNum, int newNum) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BanMenu.<>c // TypeDefIndex: 802
{
	// Fields
	public static readonly BanMenu.<>c <>9; // 0x0
	public static Func<int, bool> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x58AD00 Offset: 0x589F00 VA: 0x18058AD00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A9E0 Offset: 0x589BE0 VA: 0x18058A9E0
	internal bool <Update>b__21_0(int c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BanMenu.<>c__DisplayClass21_0 // TypeDefIndex: 803
{
	// Fields
	public ClientData client; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A9F0 Offset: 0x589BF0 VA: 0x18058A9F0
	internal bool <Update>b__1(BanButton b) { }
}

// Namespace: 
public class BanMenu : MonoBehaviour // TypeDefIndex: 804
{
	// Fields
	public BanButton BanButtonPrefab; // 0x20
	public SpriteRenderer Background; // 0x28
	public PassiveButton MenuButton; // 0x30
	public SpriteRenderer BanButton; // 0x38
	public SpriteRenderer KickButton; // 0x40
	public SpriteRenderer ReportButton; // 0x48
	public GameObject ContentParent; // 0x50
	public ReportReasonScreen ReportReason; // 0x58
	public int selectedClientId; // 0x60
	public List<BanButton> allButtons; // 0x68
	private List<ClientData> recentClients; // 0x70
	[Header("Alignment Settings")]
	[SerializeField]
	private float backgroundTailWidth; // 0x78
	[SerializeField]
	private float backgroundBaseWidth; // 0x7C
	[SerializeField]
	private float backgroundBaseHeight; // 0x80
	[SerializeField]
	private float borderPadding; // 0x84
	[SerializeField]
	private float heightPerButton; // 0x88
	[SerializeField]
	private float widthPerCol; // 0x8C
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x90
	public UiElement DefaultButtonSelected; // 0x98
	public List<UiElement> ControllerSelectable; // 0xA0

	// Methods

	// RVA: 0x57B270 Offset: 0x57A470 VA: 0x18057B270
	public void SetVisible(bool show) { }

	// RVA: 0x57BAB0 Offset: 0x57ACB0 VA: 0x18057BAB0
	private void Update() { }

	// RVA: 0x57B500 Offset: 0x57A700 VA: 0x18057B500
	public void Show() { }

	[ContextMenu("AlignAllButtons")]
	// RVA: 0x57A4E0 Offset: 0x5796E0 VA: 0x18057A4E0
	private void AlignAllButtons() { }

	// RVA: 0x57AAD0 Offset: 0x579CD0 VA: 0x18057AAD0
	public void Hide() { }

	// RVA: 0x57AA70 Offset: 0x579C70 VA: 0x18057AA70
	public bool CanSelect(int clientId) { }

	// RVA: 0x57AFA0 Offset: 0x57A1A0 VA: 0x18057AFA0
	public void Select(int clientId) { }

	// RVA: 0x57AC90 Offset: 0x579E90 VA: 0x18057AC90
	public void Kick(bool ban) { }

	// RVA: 0x57AE50 Offset: 0x57A050 VA: 0x18057AE50
	public void PickReportReason() { }

	// RVA: 0x57AEF0 Offset: 0x57A0F0 VA: 0x18057AEF0
	public void ReportPlayer(ReportReasons reason) { }

	// RVA: 0x57BF10 Offset: 0x57B110 VA: 0x18057BF10
	public void .ctor() { }
}

// Namespace: 
public class ReportReason : MonoBehaviour // TypeDefIndex: 805
{
	// Fields
	public ReportReasons Reason; // 0x20
	public ButtonRolloverHandler button; // 0x28

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ReportReasonScreen : MonoBehaviour // TypeDefIndex: 806
{
	// Fields
	public BanMenu Parent; // 0x20
	public ButtonRolloverHandler[] Buttons; // 0x28
	public TextMeshPro NameText; // 0x30
	public SpriteRenderer PlayerIcon; // 0x38
	private Nullable<ReportReasons> currentReason; // 0x40
	public ReportNotification ConfirmScreen; // 0x48
	private string playerName; // 0x50
	private int colorId; // 0x58

	// Methods

	// RVA: 0x587C10 Offset: 0x586E10 VA: 0x180587C10
	public void Show(string playerName, int colorId) { }

	// RVA: 0x587A80 Offset: 0x586C80 VA: 0x180587A80
	public void SelectReason(ReportReason reason) { }

	// RVA: 0x587E70 Offset: 0x587070 VA: 0x180587E70
	public void Submit() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Hide() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class VoteBanSystem : InnerNetObject // TypeDefIndex: 807
{
	// Fields
	public static VoteBanSystem Instance; // 0x0
	public Dictionary<int, int[]> Votes; // 0x38

	// Methods

	// RVA: 0x58BB60 Offset: 0x58AD60 VA: 0x18058BB60
	public void Awake() { }

	// RVA: 0x58BBB0 Offset: 0x58ADB0 VA: 0x18058BBB0
	public void CmdAddVote(int clientIdToVoteBan) { }

	// RVA: 0x58B9E0 Offset: 0x58ABE0 VA: 0x18058B9E0
	private void AddVote(int srcClient, int clientId) { }

	// RVA: 0x58BE70 Offset: 0x58B070 VA: 0x18058BE70
	public bool HasMyVote(int clientId) { }

	// RVA: 0x58BE10 Offset: 0x58B010 VA: 0x18058BE10 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x58BBA0 Offset: 0x58ADA0 VA: 0x18058BBA0 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x58BF30 Offset: 0x58B130 VA: 0x18058BF30 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x58BCA0 Offset: 0x58AEA0 VA: 0x18058BCA0 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x58C100 Offset: 0x58B300 VA: 0x18058C100
	public void .ctor() { }
}

// Namespace: 
public class ButtonBehavior : UiElement // TypeDefIndex: 808
{
	// Fields
	public bool OnUp; // 0x58
	public bool OnDown; // 0x59
	public bool Repeat; // 0x5A
	public Button.ButtonClickedEvent OnClick; // 0x60
	private Controller myController; // 0x68
	private Collider2D[] colliders; // 0x70
	private float downTime; // 0x78
	public SpriteRenderer spriteRenderer; // 0x80
	private bool checkedClickEvent; // 0x88

	// Methods

	// RVA: 0x57C360 Offset: 0x57B560 VA: 0x18057C360
	public void OnEnable() { }

	// RVA: 0x57C580 Offset: 0x57B780 VA: 0x18057C580
	public void Update() { }

	// RVA: 0x57C560 Offset: 0x57B760 VA: 0x18057C560
	public void ReceiveClick() { }

	// RVA: 0x57C6B0 Offset: 0x57B8B0 VA: 0x18057C6B0
	public void .ctor() { }
}

// Namespace: 
public class AbilityButton : ActionButton // TypeDefIndex: 809
{
	// Fields
	[SerializeField]
	private GameObject commsDown; // 0x70

	// Methods

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20 Slot: 5
	public override void Hide() { }

	// RVA: 0x576FD0 Offset: 0x5761D0 VA: 0x180576FD0 Slot: 4
	public override void DoClick() { }

	// RVA: 0x5771B0 Offset: 0x5763B0 VA: 0x1805771B0
	public void Refresh(AbilityButtonSettings ability) { }

	// RVA: 0x577240 Offset: 0x576440 VA: 0x180577240
	public void SetFromSettings(AbilityButtonSettings settings) { }

	// RVA: 0x577390 Offset: 0x576590 VA: 0x180577390
	public void SetSecondImage(AbilityButtonSettings settings) { }

	// RVA: 0x5773D0 Offset: 0x5765D0 VA: 0x1805773D0
	private void Update() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public enum AbilityTypes // TypeDefIndex: 810
{
	// Fields
	public int value__; // 0x0
	public const AbilityTypes GameOnly = 0;
	public const AbilityTypes MeetingOnly = 1;
	public const AbilityTypes Both = 2;
}

// Namespace: 
[CreateAssetMenu]
public class AbilityButtonSettings : ScriptableObject // TypeDefIndex: 811
{
	// Fields
	public Sprite Image; // 0x18
	public Sprite SecondImage; // 0x20
	public StringNames Text; // 0x28
	public Material FontMaterial; // 0x30
	public AbilityTypes AbilityType; // 0x38

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public class SecondaryAbilityButton : ActionButton // TypeDefIndex: 812
{
	// Fields
	[SerializeField]
	private GameObject commsDown; // 0x70

	// Methods

	// RVA: 0x588440 Offset: 0x587640 VA: 0x180588440 Slot: 4
	public override void DoClick() { }

	// RVA: 0x588620 Offset: 0x587820 VA: 0x180588620
	public void Refresh(AbilityButtonSettings ability) { }

	// RVA: 0x5886B0 Offset: 0x5878B0 VA: 0x1805886B0
	public void SetFromSettings(AbilityButtonSettings settings) { }

	// RVA: 0x577390 Offset: 0x576590 VA: 0x180577390
	public void SetSecondImage(AbilityButtonSettings settings) { }

	// RVA: 0x588800 Offset: 0x587A00 VA: 0x180588800
	private void Update() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public abstract class ActionButton : MonoBehaviour // TypeDefIndex: 813
{
	// Fields
	[SerializeField]
	protected SpriteRenderer graphic; // 0x20
	[SerializeField]
	protected SpriteRenderer usesRemainingSprite; // 0x28
	[SerializeField]
	protected TextMeshPro usesRemainingText; // 0x30
	[SerializeField]
	protected TextMeshPro buttonLabelText; // 0x38
	[SerializeField]
	protected TextMeshPro cooldownTimerText; // 0x40
	[SerializeField]
	private ActionMapGlyphDisplay glyph; // 0x48
	protected bool isCoolingDown; // 0x50
	protected readonly Logger logger; // 0x58
	protected bool canInteract; // 0x60
	private Vector3 position; // 0x64

	// Properties
	public bool IsOnCooldown { get; }

	// Methods

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public bool get_IsOnCooldown() { }

	// RVA: 0x578480 Offset: 0x577680 VA: 0x180578480
	private void Start() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DoClick();

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool CanInteract() { }

	// RVA: 0x577CB0 Offset: 0x576EB0 VA: 0x180577CB0
	public void SetCoolDown(float timer, float maxTimer) { }

	// RVA: 0x5783E0 Offset: 0x5775E0 VA: 0x1805783E0
	public void SetUsesRemaining(int num) { }

	// RVA: 0x578380 Offset: 0x577580 VA: 0x180578380
	public void SetInfiniteUses() { }

	// RVA: 0x578100 Offset: 0x577300 VA: 0x180578100
	public void SetFillUp(float timer, float maxTimer) { }

	// RVA: 0x577FD0 Offset: 0x5771D0 VA: 0x180577FD0
	public void SetEnabled() { }

	// RVA: 0x577EA0 Offset: 0x5770A0 VA: 0x180577EA0
	public void SetDisabled() { }

	// RVA: 0x5784D0 Offset: 0x5776D0 VA: 0x1805784D0
	public void ToggleVisible(bool visible) { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20 Slot: 5
	public virtual void Hide() { }

	// RVA: 0x537E50 Offset: 0x537050 VA: 0x180537E50 Slot: 6
	public virtual void Show() { }

	// RVA: 0x577E30 Offset: 0x577030 VA: 0x180577E30
	public void SetCooldownFill(float percentCool) { }

	// RVA: 0x577BF0 Offset: 0x576DF0 VA: 0x180577BF0
	public void OverrideText(string text) { }

	// RVA: 0x577BC0 Offset: 0x576DC0 VA: 0x180577BC0
	public void OverrideColor(Color color) { }

	// RVA: 0x577C20 Offset: 0x576E20 VA: 0x180577C20
	protected void ResetCoolDown() { }

	// RVA: 0x578500 Offset: 0x577700 VA: 0x180578500
	protected void .ctor() { }
}

// Namespace: 
[Extension]
public static class CooldownHelpers // TypeDefIndex: 814
{
	// Methods

	[Extension]
	// RVA: 0x5821C0 Offset: 0x5813C0 VA: 0x1805821C0
	public static void SetCooldownNormalizedUvs(SpriteRenderer myRend) { }
}

// Namespace: 
public class KillButton : ActionButton // TypeDefIndex: 815
{
	// Fields
	private PlayerControl currentTarget; // 0x70
	[SerializeField]
	private TextTranslatorTMP textTranslator; // 0x78
	[SerializeField]
	private Sprite defaultKillSprite; // 0x80

	// Properties
	public PlayerControl Target { get; }

	// Methods

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public PlayerControl get_Target() { }

	// RVA: 0x5872A0 Offset: 0x5864A0 VA: 0x1805872A0 Slot: 4
	public override void DoClick() { }

	// RVA: 0x587090 Offset: 0x586290 VA: 0x180587090
	public void CheckClick(PlayerControl target) { }

	// RVA: 0x587460 Offset: 0x586660 VA: 0x180587460
	public void SetTarget(PlayerControl target) { }

	// RVA: 0x5876F0 Offset: 0x5868F0 VA: 0x1805876F0
	private void Start() { }

	// RVA: 0x587030 Offset: 0x586230 VA: 0x180587030
	public void ChangeButtonText(StringNames stringName) { }

	// RVA: 0x587060 Offset: 0x586260 VA: 0x180587060
	public void ChangeGraphic(Sprite newSprite) { }

	// RVA: 0x587400 Offset: 0x586600 VA: 0x180587400
	public void ResetKillButton() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public class PetButton : ActionButton // TypeDefIndex: 816
{
	// Methods

	// RVA: 0x587800 Offset: 0x586A00 VA: 0x180587800
	public void SetTarget() { }

	// RVA: 0x587720 Offset: 0x586920 VA: 0x180587720 Slot: 4
	public override void DoClick() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public class ReportButton : ActionButton // TypeDefIndex: 817
{
	// Methods

	// RVA: 0x587940 Offset: 0x586B40 VA: 0x180587940
	public void SetActive(bool isActive) { }

	// RVA: 0x587870 Offset: 0x586A70 VA: 0x180587870 Slot: 4
	public override void DoClick() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public class SabotageButton : ActionButton // TypeDefIndex: 818
{
	// Methods

	// RVA: 0x588010 Offset: 0x587210 VA: 0x180588010 Slot: 4
	public override void DoClick() { }

	// RVA: 0x5881A0 Offset: 0x5873A0 VA: 0x1805881A0
	public void Refresh() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UseButton.<>c // TypeDefIndex: 819
{
	// Fields
	public static readonly UseButton.<>c <>9; // 0x0
	public static Func<UseButtonSettings, ImageNames> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x58AD60 Offset: 0x589F60 VA: 0x18058AD60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A8D0 Offset: 0x589AD0 VA: 0x18058A8D0
	internal ImageNames <Awake>b__3_0(UseButtonSettings t) { }
}

// Namespace: 
public class UseButton : ActionButton // TypeDefIndex: 820
{
	// Fields
	public UseButtonSettings[] UseSettings; // 0x70
	private Dictionary<ImageNames, UseButtonSettings> fastUseSettings; // 0x78
	private IUsable currentTarget; // 0x80

	// Methods

	// RVA: 0x58B350 Offset: 0x58A550 VA: 0x18058B350
	public void Awake() { }

	// RVA: 0x58B550 Offset: 0x58A750 VA: 0x18058B550
	private void FixedUpdate() { }

	// RVA: 0x58B700 Offset: 0x58A900 VA: 0x18058B700
	public void SetTarget(IUsable target) { }

	// RVA: 0x58B460 Offset: 0x58A660 VA: 0x18058B460 Slot: 4
	public override void DoClick() { }

	// RVA: 0x58B5F0 Offset: 0x58A7F0 VA: 0x18058B5F0
	public void Refresh() { }

	// RVA: 0x58B600 Offset: 0x58A800 VA: 0x18058B600
	private void SetFromSettings(UseButtonSettings settings) { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu]
public class UseButtonSettings : ScriptableObject // TypeDefIndex: 821
{
	// Fields
	public ImageNames ButtonType; // 0x18
	public Sprite Image; // 0x20
	public StringNames Text; // 0x28
	public Material FontMaterial; // 0x30

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public class VentButton : ActionButton // TypeDefIndex: 822
{
	// Fields
	private Vent currentTarget; // 0x70

	// Methods

	// RVA: 0x58B960 Offset: 0x58AB60 VA: 0x18058B960
	public void SetTarget(Vent target) { }

	// RVA: 0x58B940 Offset: 0x58AB40 VA: 0x18058B940 Slot: 4
	public override void DoClick() { }

	// RVA: 0x551520 Offset: 0x550720 VA: 0x180551520
	public void .ctor() { }
}

// Namespace: 
public static class CameraSafeArea // TypeDefIndex: 823
{
	// Methods

	// RVA: 0x57C740 Offset: 0x57B940 VA: 0x18057C740
	public static float GetSafeOrthographicSize(Camera cam) { }
}

// Namespace: 
public abstract class AbstractChatInputField : MonoBehaviour // TypeDefIndex: 824
{
	// Fields
	protected const float BUTTON_MARGIN = 0,1;
	private const float TEXT_FIELD_MARGIN = 0,12;
	[SerializeField]
	private SpriteRenderer background; // 0x20
	[SerializeField]
	private ChatInputFieldButton submitButton; // 0x28
	private bool visible; // 0x30
	private bool canSubmit; // 0x31
	[CompilerGenerated]
	private Action OnSubmitEvent; // 0x38

	// Properties
	public SpriteRenderer Background { get; }
	public bool Visible { get; }
	public bool CanSubmit { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public SpriteRenderer get_Background() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_Visible() { }

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	public bool get_CanSubmit() { }

	[CompilerGenerated]
	// RVA: 0x577A70 Offset: 0x576C70 VA: 0x180577A70
	public void add_OnSubmitEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x577B20 Offset: 0x576D20 VA: 0x180577B20
	public void remove_OnSubmitEvent(Action value) { }

	// RVA: 0x577480 Offset: 0x576680 VA: 0x180577480 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x5777F0 Offset: 0x5769F0 VA: 0x1805777F0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	private void OnSubmitButtonPressed() { }

	// RVA: 0x577720 Offset: 0x576920 VA: 0x180577720
	private void OnSubmitButtonSizeChanged() { }

	// RVA: 0x577840 Offset: 0x576A40 VA: 0x180577840
	private void UpdateElements() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void OnTextFieldTransformChanged(Vector3 position, Vector2 size) { }

	// RVA: 0x577640 Offset: 0x576840 VA: 0x180577640
	protected Bounds GetBounds() { }

	// RVA: 0x5777B0 Offset: 0x5769B0 VA: 0x1805777B0 Slot: 7
	public virtual void SetVisible(bool visible) { }

	// RVA: 0x577760 Offset: 0x576960 VA: 0x180577760
	public void SetCanSubmit(bool canSubmit) { }

	// RVA: 0x577730 Offset: 0x576930 VA: 0x180577730 Slot: 8
	protected virtual void SetButtonsEnabled(bool enabled) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public virtual void Clear() { }

	// RVA: 0x577820 Offset: 0x576A20 VA: 0x180577820 Slot: 10
	protected virtual void Submit() { }

	// RVA: 0x577A60 Offset: 0x576C60 VA: 0x180577A60
	protected void .ctor() { }
}

// Namespace: 
internal class ChatBubble : PoolableBehavior // TypeDefIndex: 825
{
	// Fields
	private static readonly Vector3 PlayerMessageScale; // 0x0
	private static readonly Vector3 PlayerNotificationScale; // 0xC
	private static readonly Vector3 VotedAndDeadMarkerPosition; // 0x18
	private static readonly Vector3 VotedAndDeadMarkerPositionRight; // 0x24
	public PoolablePlayer Player; // 0x30
	public SpriteRenderer Xmark; // 0x38
	public SpriteRenderer votedMark; // 0x40
	public TextMeshPro NameText; // 0x48
	public TextMeshPro TextArea; // 0x50
	public SpriteRenderer Background; // 0x58
	public SpriteRenderer MaskArea; // 0x60
	public PlatformIdentifier PlatformIcon; // 0x68
	public TextMeshPro ColorBlindName; // 0x70
	private NetworkedPlayerInfo playerInfo; // 0x78
	private int maskLayer; // 0x80
	private float playerZ; // 0x84

	// Methods

	// RVA: 0x57CCF0 Offset: 0x57BEF0 VA: 0x18057CCF0
	public void SetLeft() { }

	// RVA: 0x57D450 Offset: 0x57C650 VA: 0x18057D450
	public void SetNotification() { }

	// RVA: 0x57DD30 Offset: 0x57CF30 VA: 0x18057DD30
	public void SetWarning(string text) { }

	// RVA: 0x57CC50 Offset: 0x57BE50 VA: 0x18057CC50
	public void SetCosmetics(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x57D830 Offset: 0x57CA30 VA: 0x18057D830
	public void SetRight() { }

	// RVA: 0x57D2E0 Offset: 0x57C4E0 VA: 0x18057D2E0
	public void SetName(string playerName, bool isDead, bool voted, Color color) { }

	// RVA: 0x57CAB0 Offset: 0x57BCB0 VA: 0x18057CAB0 Slot: 4
	public override void Reset() { }

	// RVA: 0x57C760 Offset: 0x57B960 VA: 0x18057C760
	public void AlignChildren() { }

	// RVA: 0x57DC20 Offset: 0x57CE20 VA: 0x18057DC20
	internal void SetText(string chatText) { }

	// RVA: 0x57C980 Offset: 0x57BB80 VA: 0x18057C980
	private void OnEnable() { }

	// RVA: 0x57C8C0 Offset: 0x57BAC0 VA: 0x18057C8C0
	private void OnDisable() { }

	// RVA: 0x57CBA0 Offset: 0x57BDA0 VA: 0x18057CBA0
	private void SetColorblindText() { }

	// RVA: 0x57D090 Offset: 0x57C290 VA: 0x18057D090
	private void SetMaskLayer() { }

	// RVA: 0x57DF80 Offset: 0x57D180 VA: 0x18057DF80
	public void .ctor() { }

	// RVA: 0x57DEB0 Offset: 0x57D0B0 VA: 0x18057DEB0
	private static void .cctor() { }
}

// Namespace: 
public enum ChatNoteTypes // TypeDefIndex: 826
{
	// Fields
	public int value__; // 0x0
	public const ChatNoteTypes DidVote = 0;
}

// Namespace: 
public enum ChatControllerState // TypeDefIndex: 827
{
	// Fields
	public int value__; // 0x0
	public const ChatControllerState Closed = 0;
	public const ChatControllerState Closing = 1;
	public const ChatControllerState Open = 2;
	public const ChatControllerState Opening = 3;
}

// Namespace: 
private sealed class ChatController.GetFormattedNameFunc : MulticastDelegate // TypeDefIndex: 828
{
	// Methods

	// RVA: 0x585960 Offset: 0x584B60 VA: 0x180585960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual string Invoke(string name) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual string EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<>c__DisplayClass61_0 // TypeDefIndex: 829
{
	// Fields
	public int rem; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58AAA0 Offset: 0x589CA0 VA: 0x18058AAA0
	internal string <AddChatNote>b__0(string returnedName) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<>c__DisplayClass64_0 // TypeDefIndex: 830
{
	// Fields
	public ChatController.GetFormattedNameFunc getFormattedNameFunc; // 0x10
	public NetworkedPlayerInfo playerInfo; // 0x18
	public ChatBubble bubble; // 0x20
	public bool isDead; // 0x28
	public bool didVote; // 0x29
	public Color nameColor; // 0x2C
	public ChatController <>4__this; // 0x40

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58ABE0 Offset: 0x589DE0 VA: 0x18058ABE0
	internal void <SetChatBubbleName>b__0(NetworkedPlayerInfo player) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<BounceDot>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 831
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ChatController <>4__this; // 0x20

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

	// RVA: 0x5888B0 Offset: 0x587AB0 VA: 0x1805888B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5889A0 Offset: 0x587BA0 VA: 0x1805889A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<CoClose>d__60 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 832
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ChatController <>4__this; // 0x20
	private float <duration>5__2; // 0x28
	private Vector3 <scale>5__3; // 0x2C
	private float <targetScale>5__4; // 0x38
	private float <timer>5__5; // 0x3C

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

	// RVA: 0x5889E0 Offset: 0x587BE0 VA: 0x1805889E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x588F00 Offset: 0x588100 VA: 0x180588F00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<CoOpen>d__59 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 833
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ChatController <>4__this; // 0x20
	private float <duration>5__2; // 0x28
	private Vector3 <scale>5__3; // 0x2C
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

	// RVA: 0x588F40 Offset: 0x588140 VA: 0x180588F40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x589510 Offset: 0x588710 VA: 0x180589510 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatController.<WaitForNameToExist>d__65 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 834
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NetworkedPlayerInfo player; // 0x20
	public Action<NetworkedPlayerInfo> onNameExistsCallback; // 0x28

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

	// RVA: 0x58ADC0 Offset: 0x589FC0 VA: 0x18058ADC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x58AE60 Offset: 0x58A060 VA: 0x18058AE60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ChatController : MonoBehaviour // TypeDefIndex: 835
{
	// Fields
	private const float SCREEN_SIZE_PERCENT = 0,8;
	private const float MAX_CHAT_SEND_RATE = 3;
	private const float X_DISTANCE_FROM_QUICKCHAT = -0,39;
	private static readonly Logger Logger; // 0x0
	[SerializeField]
	[Header("Buttons")]
	private PassiveButton chatButton; // 0x20
	[SerializeField]
	private AspectPosition chatButtonAspectPosition; // 0x28
	[SerializeField]
	[Space(10)]
	private BanMenu banButton; // 0x30
	[SerializeField]
	private GameObject openKeyboardButton; // 0x38
	[SerializeField]
	private PassiveButton quickChatButton; // 0x40
	[SerializeField]
	[Header("Chat Screen")]
	private GameObject chatScreen; // 0x48
	[SerializeField]
	private ObjectPoolBehavior chatBubblePool; // 0x50
	[SerializeField]
	private Scroller scroller; // 0x58
	[SerializeField]
	private SpriteRenderer backgroundImage; // 0x60
	[SerializeField]
	private SpriteRenderer chatNotifyDot; // 0x68
	[SerializeField]
	private TextMeshPro sendRateMessageText; // 0x70
	[SerializeField]
	private AspectPosition aspectPosition; // 0x78
	[Header("Free Chat")]
	[SerializeField]
	private FreeChatInputField freeChatField; // 0x80
	[Header("Quick Chat")]
	[SerializeField]
	private QuickChatMenu quickChatMenu; // 0x88
	[SerializeField]
	private QuickChatPreviewField quickChatField; // 0x90
	[Header("SFX")]
	[SerializeField]
	private AudioClip messageSound; // 0x98
	[SerializeField]
	private AudioClip warningSound; // 0xA0
	[Header("Animations")]
	[SerializeField]
	private AnimationCurve chatAnimationIn; // 0xA8
	[SerializeField]
	private AnimationCurve chatAnimationOut; // 0xB0
	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement backButton; // 0xB8
	[SerializeField]
	private UiElement defaultButtonSelected; // 0xC0
	[SerializeField]
	private List<UiElement> controllerSelectable; // 0xC8
	[SerializeField]
	private ChatNotification chatNotification; // 0xD0
	private ChatControllerState state; // 0xD8
	private Vector3 targetChatPosition; // 0xDC
	private float timeSinceLastMessage; // 0xE8
	private Coroutine notificationRoutine; // 0xF0
	private SpecialInputHandler specialInputHandler; // 0xF8
	private float targetScale; // 0x100

	// Properties
	public ChatControllerState State { get; }
	public bool IsOpenOrOpening { get; }
	public bool IsClosedOrClosing { get; }
	public bool IsAnimating { get; }

	// Methods

	// RVA: 0x581660 Offset: 0x580860 VA: 0x180581660
	public ChatControllerState get_State() { }

	// RVA: 0x5815F0 Offset: 0x5807F0 VA: 0x1805815F0
	public bool get_IsOpenOrOpening() { }

	// RVA: 0x581580 Offset: 0x580780 VA: 0x180581580
	public bool get_IsClosedOrClosing() { }

	// RVA: 0x581510 Offset: 0x580710 VA: 0x180581510
	public bool get_IsAnimating() { }

	// RVA: 0x57EEB0 Offset: 0x57E0B0 VA: 0x18057EEB0
	private void Awake() { }

	// RVA: 0x57F9E0 Offset: 0x57EBE0 VA: 0x18057F9E0
	private void OnEnable() { }

	// RVA: 0x57F8E0 Offset: 0x57EAE0 VA: 0x18057F8E0
	private void OnDisable() { }

	// RVA: 0x5811C0 Offset: 0x5803C0 VA: 0x1805811C0
	private void Update() { }

	// RVA: 0x57F780 Offset: 0x57E980 VA: 0x18057F780
	private void LateUpdate() { }

	// RVA: 0x5801B0 Offset: 0x57F3B0 VA: 0x1805801B0
	public void SendChat() { }

	// RVA: 0x57FBB0 Offset: 0x57EDB0 VA: 0x18057FBB0
	public void OnMeetingStart() { }

	// RVA: 0x581060 Offset: 0x580260 VA: 0x180581060
	private void UpdateChatMode() { }

	// RVA: 0x57F330 Offset: 0x57E530 VA: 0x18057F330
	private void CheckKeyboardButton() { }

	// RVA: 0x57F8D0 Offset: 0x57EAD0 VA: 0x18057F8D0
	private void OnChatModeSettingsChanged() { }

	// RVA: 0x57FF80 Offset: 0x57F180 VA: 0x18057FF80
	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen) { }

	// RVA: 0x580C30 Offset: 0x57FE30 VA: 0x180580C30
	public void SetVisible(bool visible) { }

	// RVA: 0x57F3D0 Offset: 0x57E5D0 VA: 0x18057F3D0
	public void Close() { }

	// RVA: 0x57F500 Offset: 0x57E700 VA: 0x18057F500
	public void ForceClosed() { }

	// RVA: 0x580D30 Offset: 0x57FF30 VA: 0x180580D30
	public void Toggle() { }

	// RVA: 0x57F760 Offset: 0x57E960 VA: 0x18057F760
	public void HideBanButton() { }

	// RVA: 0x581190 Offset: 0x580390 VA: 0x180581190
	public void UpdateVoteTimerText(StringNames key, int value) { }

	[IteratorStateMachine(typeof(ChatController.<CoOpen>d__59))]
	// RVA: 0x57F4A0 Offset: 0x57E6A0 VA: 0x18057F4A0
	private IEnumerator CoOpen() { }

	[IteratorStateMachine(typeof(ChatController.<CoClose>d__60))]
	// RVA: 0x57F440 Offset: 0x57E640 VA: 0x18057F440
	private IEnumerator CoClose() { }

	// RVA: 0x57DFA0 Offset: 0x57D1A0 VA: 0x18057DFA0
	public void AddChatNote(NetworkedPlayerInfo srcPlayer, ChatNoteTypes noteType) { }

	// RVA: 0x57E660 Offset: 0x57D860 VA: 0x18057E660
	public void AddChat(PlayerControl sourcePlayer, string chatText, bool censor = True) { }

	// RVA: 0x57E3D0 Offset: 0x57D5D0 VA: 0x18057E3D0
	public void AddChatWarning(string warningText) { }

	// RVA: 0x580A00 Offset: 0x57FC00 VA: 0x180580A00
	private void SetChatBubbleName(ChatBubble bubble, NetworkedPlayerInfo playerInfo, bool isDead, bool didVote, Color nameColor, ChatController.GetFormattedNameFunc getFormattedNameFunc) { }

	[IteratorStateMachine(typeof(ChatController.<WaitForNameToExist>d__65))]
	// RVA: 0x5813C0 Offset: 0x5805C0 VA: 0x1805813C0
	private IEnumerator WaitForNameToExist(NetworkedPlayerInfo player, Action<NetworkedPlayerInfo> onNameExistsCallback) { }

	// RVA: 0x57EC30 Offset: 0x57DE30 VA: 0x18057EC30
	private void AlignAllBubbles() { }

	[IteratorStateMachine(typeof(ChatController.<BounceDot>d__67))]
	// RVA: 0x57F2D0 Offset: 0x57E4D0 VA: 0x18057F2D0
	private IEnumerator BounceDot() { }

	// RVA: 0x57F6C0 Offset: 0x57E8C0 VA: 0x18057F6C0
	private ChatBubble GetPooledBubble() { }

	// RVA: 0x57FBA0 Offset: 0x57EDA0 VA: 0x18057FBA0
	private void OnFreeChatSubmit() { }

	// RVA: 0x57FB60 Offset: 0x57ED60 VA: 0x18057FB60
	private void OnFreeChatChanged() { }

	// RVA: 0x580610 Offset: 0x57F810 VA: 0x180580610
	private void SendFreeChat() { }

	// RVA: 0x580050 Offset: 0x57F250 VA: 0x180580050
	private void OpenQuickChat() { }

	// RVA: 0x57FE80 Offset: 0x57F080 VA: 0x18057FE80
	private void OnQuickChatOpened() { }

	// RVA: 0x57FE40 Offset: 0x57F040 VA: 0x18057FE40
	private void OnQuickChatClosed() { }

	// RVA: 0x57FF00 Offset: 0x57F100 VA: 0x18057FF00
	private void OnQuickChatSubmit() { }

	// RVA: 0x57FE10 Offset: 0x57F010 VA: 0x18057FE10
	private void OnQuickChatClearPressed() { }

	// RVA: 0x57FF50 Offset: 0x57F150 VA: 0x18057FF50
	private void OnQuickChatUndoPressed() { }

	// RVA: 0x57FBE0 Offset: 0x57EDE0 VA: 0x18057FBE0
	private void OnQuickChatBuilderChanged(QuickChatPhraseBuilder builder) { }

	// RVA: 0x57FC20 Offset: 0x57EE20 VA: 0x18057FC20
	private void OnQuickChatButtonClicked() { }

	// RVA: 0x580890 Offset: 0x57FA90 VA: 0x180580890
	private void SendQuickChat() { }

	// RVA: 0x5814F0 Offset: 0x5806F0 VA: 0x1805814F0
	public void .ctor() { }

	// RVA: 0x581430 Offset: 0x580630 VA: 0x180581430
	private static void .cctor() { }
}

// Namespace: 
public class ChatInputFieldButton : MonoBehaviour // TypeDefIndex: 836
{
	// Fields
	[SerializeField]
	private TextMeshPro text; // 0x20
	[SerializeField]
	private TextTranslatorTMP translator; // 0x28
	[SerializeField]
	private PassiveButton button; // 0x30
	[SerializeField]
	private BoxCollider2D collider; // 0x38
	[SerializeField]
	private Transform inputGlyph; // 0x40
	[SerializeField]
	private SpriteRenderer[] backgroundSprites; // 0x48
	[SerializeField]
	private SpriteRenderer[] iconSprites; // 0x50
	[CompilerGenerated]
	private Action OnPressed; // 0x58
	[CompilerGenerated]
	private Action OnSizeChanged; // 0x60

	// Properties
	public Vector2 Size { get; }

	// Methods

	// RVA: 0x581D70 Offset: 0x580F70 VA: 0x180581D70
	public Vector2 get_Size() { }

	[CompilerGenerated]
	// RVA: 0x581C30 Offset: 0x580E30 VA: 0x180581C30
	public void add_OnPressed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x581D90 Offset: 0x580F90 VA: 0x180581D90
	public void remove_OnPressed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x581CD0 Offset: 0x580ED0 VA: 0x180581CD0
	public void add_OnSizeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x581E30 Offset: 0x581030 VA: 0x180581E30
	public void remove_OnSizeChanged(Action value) { }

	// RVA: 0x5816A0 Offset: 0x5808A0 VA: 0x1805816A0
	private void Awake() { }

	// RVA: 0x5817D0 Offset: 0x5809D0 VA: 0x1805817D0
	public void SetButtonEnabled(bool enabled) { }

	// RVA: 0x5817A0 Offset: 0x5809A0 VA: 0x1805817A0
	private void OnButtonClicked() { }

	// RVA: 0x5817C0 Offset: 0x5809C0 VA: 0x1805817C0
	private void OnTextTranslationChanged() { }

	// RVA: 0x5817F0 Offset: 0x5809F0 VA: 0x1805817F0
	private void UpdateSize() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FreeChatInputField : AbstractChatInputField // TypeDefIndex: 837
{
	// Fields
	[Space(10)]
	[SerializeField]
	private TextBoxTMP textArea; // 0x40
	[SerializeField]
	private PassiveButton fieldButton; // 0x48
	[SerializeField]
	private TextMeshPro charCountText; // 0x50
	[CompilerGenerated]
	private Action OnChangedEvent; // 0x58

	// Properties
	public string Text { get; }

	// Methods

	// RVA: 0x584200 Offset: 0x583400 VA: 0x180584200
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x584160 Offset: 0x583360 VA: 0x180584160
	public void add_OnChangedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x584220 Offset: 0x583420 VA: 0x180584220
	public void remove_OnChangedEvent(Action value) { }

	// RVA: 0x583850 Offset: 0x582A50 VA: 0x180583850 Slot: 4
	protected override void Awake() { }

	// RVA: 0x583CB0 Offset: 0x582EB0 VA: 0x180583CB0 Slot: 7
	public override void SetVisible(bool visible) { }

	// RVA: 0x583A50 Offset: 0x582C50 VA: 0x180583A50 Slot: 9
	public override void Clear() { }

	// RVA: 0x583B70 Offset: 0x582D70 VA: 0x180583B70
	private void OnFieldChanged() { }

	// RVA: 0x583C10 Offset: 0x582E10 VA: 0x180583C10 Slot: 6
	protected override void OnTextFieldTransformChanged(Vector3 position, Vector2 size) { }

	// RVA: 0x583D10 Offset: 0x582F10 VA: 0x180583D10 Slot: 10
	protected override void Submit() { }

	// RVA: 0x583AD0 Offset: 0x582CD0 VA: 0x180583AD0
	public void Focus() { }

	// RVA: 0x583DA0 Offset: 0x582FA0 VA: 0x180583DA0
	public void Unfocus() { }

	// RVA: 0x583B50 Offset: 0x582D50 VA: 0x180583B50
	public void ForceKeyboardClose() { }

	// RVA: 0x583C00 Offset: 0x582E00 VA: 0x180583C00
	private void OnFieldPressed() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	private void OnFieldSubmit() { }

	// RVA: 0x583E20 Offset: 0x583020 VA: 0x180583E20
	public void UpdateCharCount() { }

	// RVA: 0x5840F0 Offset: 0x5832F0 VA: 0x1805840F0
	private void UpdateState() { }

	// RVA: 0x577A60 Offset: 0x576C60 VA: 0x180577A60
	public void .ctor() { }
}

// Namespace: 
[DefaultExecutionOrder(-10)]
public class ConsoleHUDObjectsShifter : MonoBehaviour // TypeDefIndex: 838
{
	// Fields
	private Camera cam; // 0x20
	private Vector2 screenBounds; // 0x28
	private static int instanceCount; // 0x0

	// Methods

	// RVA: 0x581FA0 Offset: 0x5811A0 VA: 0x180581FA0
	private void OnEnable() { }

	// RVA: 0x581ED0 Offset: 0x5810D0 VA: 0x180581ED0
	private void OnDisable() { }

	// RVA: 0x581FE0 Offset: 0x5811E0 VA: 0x180581FE0
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrossplayModeCycle : MonoBehaviour // TypeDefIndex: 839
{
	// Fields
	public TextMeshPro crossplayModeText; // 0x20
	public SpriteRenderer backgroundSprite; // 0x28

	// Methods

	// RVA: 0x582420 Offset: 0x581620 VA: 0x180582420
	public void OnEnable() { }

	// RVA: 0x582370 Offset: 0x581570 VA: 0x180582370
	public void CycleCrossplayMode() { }

	// RVA: 0x582430 Offset: 0x581630 VA: 0x180582430
	public void UpdateCrossplayButtonText() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrossplayModeToggle : MonoBehaviour // TypeDefIndex: 840
{
	// Fields
	[SerializeField]
	private TextMeshPro CrossplayModeText; // 0x20
	[SerializeField]
	private CreateOptionsPicker OptionsPicker; // 0x28

	// Methods

	// RVA: 0x582630 Offset: 0x581830 VA: 0x180582630
	public void OnEnable() { }

	// RVA: 0x582520 Offset: 0x581720 VA: 0x180582520
	public void CycleMode() { }

	// RVA: 0x582640 Offset: 0x581840 VA: 0x180582640
	public void UpdateDisplay() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CycleButtonBehaviour : MonoBehaviour, ITranslatedText // TypeDefIndex: 841
{
	// Fields
	public StringNames[] options; // 0x20
	public StringNames BaseText; // 0x28
	public TextMeshPro Text; // 0x30
	public SpriteRenderer Background; // 0x38
	public ButtonRolloverHandler Rollover; // 0x40
	public GameObject helpButton; // 0x48
	private int curSelection; // 0x50
	public TextMeshPro quickChatInstructions; // 0x58

	// Methods

	// RVA: 0x582940 Offset: 0x581B40 VA: 0x180582940
	public void Start() { }

	// RVA: 0x582750 Offset: 0x581950 VA: 0x180582750
	public void OnDestroy() { }

	// RVA: 0x5827E0 Offset: 0x5819E0 VA: 0x1805827E0 Slot: 4
	public void ResetText() { }

	// RVA: 0x5829F0 Offset: 0x581BF0 VA: 0x1805829F0
	public void UpdateText(int selection) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class DialogueBox : MonoBehaviour // TypeDefIndex: 842
{
	// Fields
	public TextMeshPro target; // 0x20
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x28

	// Methods

	// RVA: 0x582FC0 Offset: 0x5821C0 VA: 0x180582FC0
	private void OnEnable() { }

	// RVA: 0x582F50 Offset: 0x582150 VA: 0x180582F50
	private void OnDisable() { }

	// RVA: 0x583030 Offset: 0x582230 VA: 0x180583030
	public void Show(string dialogue) { }

	// RVA: 0x582E10 Offset: 0x582010 VA: 0x180582E10
	public void Hide() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class EmailTextBehaviour : MonoBehaviour // TypeDefIndex: 843
{
	// Fields
	public static readonly HashSet<char> SymbolChars; // 0x0
	public TextBoxTMP nameSource; // 0x20

	// Methods

	// RVA: 0x5831E0 Offset: 0x5823E0 VA: 0x1805831E0
	public string GetEmailValidEmail() { }

	// RVA: 0x583240 Offset: 0x582440 VA: 0x180583240
	public string GetEmailWithoutValidityCheck() { }

	// RVA: 0x583260 Offset: 0x582460 VA: 0x180583260
	private bool IsValidEmail(string text) { }

	// RVA: 0x583480 Offset: 0x582680 VA: 0x180583480
	public bool ShakeIfInvalid() { }

	// RVA: 0x5833C0 Offset: 0x5825C0 VA: 0x1805833C0
	public bool ShakeIfDoesntMatch(string email1, string email2) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x583650 Offset: 0x582850 VA: 0x180583650
	private static void .cctor() { }
}

// Namespace: 
public class BlockedPlayerBar : FriendsListBar // TypeDefIndex: 844
{
	// Methods

	// RVA: 0x57C000 Offset: 0x57B200 VA: 0x18057C000
	public void CheckUnblockPlayer() { }

	// RVA: 0x57C2A0 Offset: 0x57B4A0 VA: 0x18057C2A0
	public void UnblockPlayer() { }

	// RVA: 0x57C0D0 Offset: 0x57B2D0 VA: 0x18057C0D0
	private void Delete() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x57C1C0 Offset: 0x57B3C0 VA: 0x18057C1C0
	private void <UnblockPlayer>b__1_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x57C190 Offset: 0x57B390 VA: 0x18057C190
	private bool <Delete>b__2_0(ResponseBlockedPlayer notif) { }
}

// Namespace: 
public enum FriendListNotification.IconType // TypeDefIndex: 845
{
	// Fields
	public int value__; // 0x0
	public const FriendListNotification.IconType Friend = 0;
	public const FriendListNotification.IconType Block = 1;
	public const FriendListNotification.IconType LobbyInvite = 2;
	public const FriendListNotification.IconType Failed = 3;
	public const FriendListNotification.IconType Sent = 4;
}

// Namespace: 
[Serializable]
public class FriendListNotification.FriendNotificationIcon // TypeDefIndex: 846
{
	// Fields
	public FriendListNotification.IconType type; // 0x10
	public Sprite icon; // 0x18
	public float scale; // 0x20
	public Vector2 offset; // 0x24

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendListNotification.<>c__DisplayClass6_0 // TypeDefIndex: 847
{
	// Fields
	public FriendListNotification.IconType type; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <SetUp>b__0(FriendListNotification.FriendNotificationIcon i) { }
}

// Namespace: 
public class FriendListNotification : MonoBehaviour // TypeDefIndex: 848
{
	// Fields
	public List<FriendListNotification.FriendNotificationIcon> IconTypes; // 0x20
	public SpriteRenderer Icon; // 0x28
	public TextMeshPro Text; // 0x30
	private float timeOnScreen; // 0x38

	// Methods

	// RVA: 0x5842C0 Offset: 0x5834C0 VA: 0x1805842C0
	public void SetUp(string text, FriendListNotification.IconType type) { }

	// RVA: 0x584520 Offset: 0x583720 VA: 0x180584520
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FriendRequestBar : FriendsListBar // TypeDefIndex: 849
{
	// Methods

	// RVA: 0x5848B0 Offset: 0x583AB0 VA: 0x1805848B0
	public void PressAccept() { }

	// RVA: 0x5847D0 Offset: 0x5839D0 VA: 0x1805847D0
	public void DenyFriendRequest() { }

	// RVA: 0x584640 Offset: 0x583840 VA: 0x180584640
	public void CheckBlockPlayer() { }

	// RVA: 0x584580 Offset: 0x583780 VA: 0x180584580
	private void BlockPlayer() { }

	// RVA: 0x584710 Offset: 0x583910 VA: 0x180584710
	private void Delete() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x584D10 Offset: 0x583F10 VA: 0x180584D10
	private void <PressAccept>b__0_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x584C40 Offset: 0x583E40 VA: 0x180584C40
	private void <DenyFriendRequest>b__1_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x584990 Offset: 0x583B90 VA: 0x180584990
	private void <BlockPlayer>b__3_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x584BE0 Offset: 0x583DE0 VA: 0x180584BE0
	private bool <Delete>b__4_0(ResponseReceivedFriendRequest notif) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FriendsListBar.<>c // TypeDefIndex: 850
{
	// Fields
	public static readonly FriendsListBar.<>c <>9; // 0x0
	public static Action<PassiveButton> <>9__18_0; // 0x8
	public static Action<PassiveButton> <>9__19_0; // 0x10

	// Methods

	// RVA: 0x5A2F70 Offset: 0x5A2170 VA: 0x1805A2F70
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A02D0 Offset: 0x59F4D0 VA: 0x1805A02D0
	internal void <GoInactive>b__18_0(PassiveButton b) { }

	// RVA: 0x5A02A0 Offset: 0x59F4A0 VA: 0x1805A02A0
	internal void <GoActive>b__19_0(PassiveButton b) { }
}

// Namespace: 
public class FriendsListBar : MonoBehaviour // TypeDefIndex: 851
{
	// Fields
	public TextMeshPro SenderName; // 0x20
	public List<PassiveButton> ControllerSelectable; // 0x28
	public ClientData ClientData; // 0x30
	public List<PassiveButton> Buttons; // 0x38
	public SpriteRenderer InactiveSprite; // 0x40
	public PlatformIdentifier PlatformIdentifier; // 0x48
	public FriendsListManager.PlatformFriend PlatformFriendData; // 0x50
	public PassiveButton PlatformProfileButton; // 0x58
	protected float actionCooldown; // 0x60
	protected string puid; // 0x68
	protected string friendCode; // 0x70
	protected FriendsListUI parentUI; // 0x78

	// Methods

	// RVA: 0x5855E0 Offset: 0x5847E0 VA: 0x1805855E0
	private void Start() { }

	// RVA: 0x5854B0 Offset: 0x5846B0 VA: 0x1805854B0 Slot: 4
	public virtual void SetUp(string puid, FriendsListUI parentUI, string friendCode, string playerInGameName) { }

	// RVA: 0x585090 Offset: 0x584290 VA: 0x180585090
	public void GetAndSetPlatform() { }

	// RVA: 0x585460 Offset: 0x584660 VA: 0x180585460
	public void SetPlatform(Platforms p, string name) { }

	// RVA: 0x585920 Offset: 0x584B20 VA: 0x180585920
	private void Update() { }

	// RVA: 0x585080 Offset: 0x584280 VA: 0x180585080
	public bool CanUseApi() { }

	// RVA: 0x5852B0 Offset: 0x5844B0 VA: 0x1805852B0
	protected void GoInactive() { }

	// RVA: 0x585190 Offset: 0x584390 VA: 0x180585190
	protected void GoActive() { }

	// RVA: 0x5853D0 Offset: 0x5845D0 VA: 0x1805853D0
	public void PlatformViewProfile() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5856A0 Offset: 0x5848A0 VA: 0x1805856A0
	private void <GetAndSetPlatform>b__14_0(Nullable<ExternalAccountInfo> info) { }
}

// Namespace: 
public class FriendsListButton : MonoBehaviour // TypeDefIndex: 852
{
	// Fields
	public GameObject Button; // 0x20
	public TextMeshPro NotifCount; // 0x28
	public GameObject NotifCircle; // 0x30
	[SerializeField]
	private ActionMapGlyphDisplay gamepadButton; // 0x38
	private bool showInScene; // 0x40

	// Methods

	// RVA: 0x58CCA0 Offset: 0x58BEA0 VA: 0x18058CCA0
	private void Awake() { }

	// RVA: 0x58CE90 Offset: 0x58C090 VA: 0x18058CE90
	private void OnDestroy() { }

	// RVA: 0x58CF20 Offset: 0x58C120 VA: 0x18058CF20
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x58D230 Offset: 0x58C430 VA: 0x18058D230
	private void Update() { }

	// RVA: 0x58CD30 Offset: 0x58BF30 VA: 0x18058CD30
	public void CheckNotifCount() { }

	// RVA: 0x58D170 Offset: 0x58C370 VA: 0x18058D170
	public void SetGlyphColor(bool isGrayedOut) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private enum FriendsListConfirmMenu.ConfirmationStatus // TypeDefIndex: 853
{
	// Fields
	public int value__; // 0x0
	public const FriendsListConfirmMenu.ConfirmationStatus Waiting = 0;
	public const FriendsListConfirmMenu.ConfirmationStatus Yes = 1;
	public const FriendsListConfirmMenu.ConfirmationStatus No = 2;
}

// Namespace: 
public enum FriendsListConfirmMenu.ActionType // TypeDefIndex: 854
{
	// Fields
	public int value__; // 0x0
	public const FriendsListConfirmMenu.ActionType Friend = 0;
	public const FriendsListConfirmMenu.ActionType Block = 1;
	public const FriendsListConfirmMenu.ActionType Lobby = 2;
	public const FriendsListConfirmMenu.ActionType Unfriend = 3;
	public const FriendsListConfirmMenu.ActionType Unblock = 4;
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListConfirmMenu.<WaitForConfirm>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 855
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListConfirmMenu.ActionType type; // 0x20
	public FriendsListConfirmMenu <>4__this; // 0x28
	public string recipientFriendCode; // 0x30
	public Action cb; // 0x38

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

	// RVA: 0x5A3150 Offset: 0x5A2350 VA: 0x1805A3150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5A35E0 Offset: 0x5A27E0 VA: 0x1805A35E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FriendsListConfirmMenu : MonoBehaviour // TypeDefIndex: 856
{
	// Fields
	public TextMeshPro PopUpText; // 0x20
	private FriendsListConfirmMenu.ConfirmationStatus confirmStatus; // 0x28
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x30
	public UiElement DefaultButtonSelected; // 0x38
	public List<UiElement> ControllerSelectable; // 0x40

	// Methods

	[IteratorStateMachine(typeof(FriendsListConfirmMenu.<WaitForConfirm>d__7))]
	// RVA: 0x58D3B0 Offset: 0x58C5B0 VA: 0x18058D3B0
	public IEnumerator WaitForConfirm(Action cb, FriendsListConfirmMenu.ActionType type, string recipientFriendCode) { }

	// RVA: 0x58D330 Offset: 0x58C530 VA: 0x18058D330
	public void Confirm() { }

	// RVA: 0x58D320 Offset: 0x58C520 VA: 0x18058D320
	public void Cancel() { }

	// RVA: 0x58D340 Offset: 0x58C540 VA: 0x18058D340 Slot: 4
	public virtual void OnDisable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FriendsListGuestWarning : MonoBehaviour // TypeDefIndex: 857
{
	// Fields
	public TextMeshPro Text; // 0x20
	public GameObject EmailButton; // 0x28

	// Methods

	// RVA: 0x58D440 Offset: 0x58C640 VA: 0x18058D440
	public void SetUp() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FriendsListManager.PlatformFriend // TypeDefIndex: 858
{
	// Fields
	public string Username; // 0x10
	public ulong GUID; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string name, ulong id) { }
}

// Namespace: 
public class FriendsListManager.RecentPlayedWithPlayer // TypeDefIndex: 859
{
	// Fields
	public readonly string PlayerName; // 0x10
	public readonly string Puid; // 0x18
	public readonly string FriendCode; // 0x20

	// Methods

	// RVA: 0x59CCD0 Offset: 0x59BED0 VA: 0x18059CCD0
	public void .ctor(NetworkedPlayerInfo player) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FriendsListManager.<>c // TypeDefIndex: 860
{
	// Fields
	public static readonly FriendsListManager.<>c <>9; // 0x0
	public static Func<NestedResponseData<ResponseBlockedPlayer>, ResponseBlockedPlayer> <>9__35_2; // 0x8
	public static Func<NestedResponseData<ResponseBlockedBy>, ResponseBlockedBy> <>9__35_3; // 0x10
	public static Func<NestedResponseData<ResponseFriends>, ResponseFriends> <>9__35_4; // 0x18
	public static Func<ResponseFriends, string> <>9__35_5; // 0x20
	public static Func<ResponseError, string> <>9__47_1; // 0x28
	public static Func<ResponseError, string> <>9__48_1; // 0x30
	public static Func<NestedResponseData<ResponseReceivedFriendRequest>, ResponseReceivedFriendRequest> <>9__50_2; // 0x38
	public static Func<ResponseReceivedFriendRequest, string> <>9__50_4; // 0x40
	public static Func<ResponseReceivedFriendRequest, string> <>9__50_5; // 0x48
	public static Func<NestedResponseData<LobbyInvite>, LobbyInvite> <>9__50_6; // 0x50
	public static Func<LobbyInvite, string> <>9__50_8; // 0x58
	public static Func<LobbyInvite, string> <>9__50_9; // 0x60
	public static Func<ResponseError, string> <>9__51_1; // 0x68
	public static Func<ResponseError, string> <>9__52_1; // 0x70
	public static Func<ResponseError, string> <>9__53_1; // 0x78
	public static Func<ResponseError, string> <>9__54_1; // 0x80
	public static Func<ResponseError, string> <>9__55_1; // 0x88
	public static Func<ResponseError, string> <>9__56_1; // 0x90
	public static Func<ResponseError, string> <>9__57_1; // 0x98
	public static Func<ResponseError, string> <>9__58_1; // 0xA0
	public static Func<ResponseError, string> <>9__59_1; // 0xA8
	public static Func<ResponseError, string> <>9__60_1; // 0xB0
	public static Func<ResponseError, string> <>9__61_1; // 0xB8
	public static Func<ResponseError, string> <>9__62_1; // 0xC0

	// Methods

	// RVA: 0x5A3030 Offset: 0x5A2230 VA: 0x1805A3030
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal ResponseBlockedPlayer <RefreshFriendsList>b__35_2(NestedResponseData<ResponseBlockedPlayer> f) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal ResponseBlockedBy <RefreshFriendsList>b__35_3(NestedResponseData<ResponseBlockedBy> f) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal ResponseFriends <RefreshFriendsList>b__35_4(NestedResponseData<ResponseFriends> f) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string <RefreshFriendsList>b__35_5(ResponseFriends x) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <GetFriendCode>b__47_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <SetFriendCode>b__48_1(ResponseError s) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal ResponseReceivedFriendRequest <PollForRequests>b__50_2(NestedResponseData<ResponseReceivedFriendRequest> f) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string <PollForRequests>b__50_4(ResponseReceivedFriendRequest inv) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string <PollForRequests>b__50_5(ResponseReceivedFriendRequest inv) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal LobbyInvite <PollForRequests>b__50_6(NestedResponseData<LobbyInvite> f) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string <PollForRequests>b__50_8(LobbyInvite inv) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string <PollForRequests>b__50_9(LobbyInvite inv) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <GetFriends>b__51_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <GetReceivedFriendRequests>b__52_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <SendFriendRequest>b__53_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <SendFriendRequestByUsername>b__54_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <DenyFriendRequest>b__55_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <RemoveFriend>b__56_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <BlockPlayer>b__57_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <UnblockPlayer>b__58_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <GetBlockedPlayers>b__59_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <SendGameInvite>b__60_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <GetLobbyInvites>b__61_1(ResponseError s) { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <DenyLobbyInvite>b__62_1(ResponseError s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass30_0 // TypeDefIndex: 861
{
	// Fields
	public string friendcode; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0520 Offset: 0x59F720 VA: 0x1805A0520
	internal bool <HasPlayerBlockedMeUsername>b__0(ResponseBlockedBy p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass31_0 // TypeDefIndex: 862
{
	// Fields
	public string puid; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0550 Offset: 0x59F750 VA: 0x1805A0550
	internal bool <HasPlayerBlockedMe>b__0(ResponseBlockedBy p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass32_0 // TypeDefIndex: 863
{
	// Fields
	public string puid; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0550 Offset: 0x59F750 VA: 0x1805A0550
	internal bool <IsPlayerBlocked>b__0(ResponseBlockedPlayer p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass33_0 // TypeDefIndex: 864
{
	// Fields
	public string puid; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0550 Offset: 0x59F750 VA: 0x1805A0550
	internal bool <IsPlayerFriend>b__0(ResponseFriends p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass34_0 // TypeDefIndex: 865
{
	// Fields
	public string friendcode; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0520 Offset: 0x59F720 VA: 0x1805A0520
	internal bool <IsPlayerBlockedUsername>b__0(ResponseBlockedPlayer p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass35_0 // TypeDefIndex: 866
{
	// Fields
	public FriendsListManager <>4__this; // 0x10
	public bool gotBlocks; // 0x18
	public bool gotFriends; // 0x19

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0580 Offset: 0x59F780 VA: 0x1805A0580
	internal void <RefreshFriendsList>b__0(ResponseState cb, Response<ResponseBlockedWrapper> response) { }

	// RVA: 0x5A0850 Offset: 0x59FA50 VA: 0x1805A0850
	internal void <RefreshFriendsList>b__1(ResponseState cb, Response<ResponseFriendWrapper> response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass47_0 // TypeDefIndex: 867
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendCode>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0A90 Offset: 0x59FC90 VA: 0x1805A0A90
	internal void <GetFriendCode>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass48_0 // TypeDefIndex: 868
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendCode>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0CA0 Offset: 0x59FEA0 VA: 0x1805A0CA0
	internal void <SetFriendCode>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass50_0 // TypeDefIndex: 869
{
	// Fields
	public float pollingInterval; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0EB0 Offset: 0x5A00B0 VA: 0x1805A0EB0
	internal void <PollForRequests>b__1(ResponseState cb, Response<ResponseGameInvites> response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass51_0 // TypeDefIndex: 870
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendWrapper>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1420 Offset: 0x5A0620 VA: 0x1805A1420
	internal void <GetFriends>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass52_0 // TypeDefIndex: 871
{
	// Fields
	public Action<ResponseState, Response<ResponseReceivedFriendRequestWrapper>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1670 Offset: 0x5A0870 VA: 0x1805A1670
	internal void <GetReceivedFriendRequests>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass53_0 // TypeDefIndex: 872
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1880 Offset: 0x5A0A80 VA: 0x1805A1880
	internal void <SendFriendRequest>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass54_0 // TypeDefIndex: 873
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1AE0 Offset: 0x5A0CE0 VA: 0x1805A1AE0
	internal void <SendFriendRequestByUsername>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass55_0 // TypeDefIndex: 874
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1D40 Offset: 0x5A0F40 VA: 0x1805A1D40
	internal void <DenyFriendRequest>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass56_0 // TypeDefIndex: 875
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A1F60 Offset: 0x5A1160 VA: 0x1805A1F60
	internal void <RemoveFriend>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass57_0 // TypeDefIndex: 876
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A21C0 Offset: 0x5A13C0 VA: 0x1805A21C0
	internal void <BlockPlayer>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass58_0 // TypeDefIndex: 877
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2420 Offset: 0x5A1620 VA: 0x1805A2420
	internal void <UnblockPlayer>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass59_0 // TypeDefIndex: 878
{
	// Fields
	public Action<ResponseState, Response<ResponseBlockedWrapper>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2680 Offset: 0x5A1880 VA: 0x1805A2680
	internal void <GetBlockedPlayers>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass60_0 // TypeDefIndex: 879
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A28A0 Offset: 0x5A1AA0 VA: 0x1805A28A0
	internal void <SendGameInvite>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass61_0 // TypeDefIndex: 880
{
	// Fields
	public Action<ResponseState, Response<ResponseGameInvites>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2B00 Offset: 0x5A1D00 VA: 0x1805A2B00
	internal void <GetLobbyInvites>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<>c__DisplayClass62_0 // TypeDefIndex: 881
{
	// Fields
	public Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback; // 0x10
	public FriendsListManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2D20 Offset: 0x5A1F20 VA: 0x1805A2D20
	internal void <DenyLobbyInvite>b__0(ResponseState cb, string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<CheckFriendCodeOnLogin>d__46 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 882
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListManager <>4__this; // 0x20

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

	// RVA: 0x59CD20 Offset: 0x59BF20 VA: 0x18059CD20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59CF90 Offset: 0x59C190 VA: 0x18059CF90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<CoJoinGameViaFriendInvite>d__45 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 883
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListManager <>4__this; // 0x20
	public string roomCode; // 0x28

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

	// RVA: 0x59D6F0 Offset: 0x59C8F0 VA: 0x18059D6F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59D840 Offset: 0x59CA40 VA: 0x18059D840 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<Delete>d__64 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 884
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string endpoint; // 0x20
	public FriendsListManager <>4__this; // 0x28
	public Action<ResponseState, string> resultCallback; // 0x30
	private UnityWebRequest <request>5__2; // 0x38

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

	// RVA: 0x59E580 Offset: 0x59D780 VA: 0x18059E580 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59E7B0 Offset: 0x59D9B0 VA: 0x18059E7B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<Get>d__63 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 885
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string endpoint; // 0x20
	public FriendsListManager <>4__this; // 0x28
	public Action<ResponseState, string> resultCallback; // 0x30
	private UnityWebRequest <request>5__2; // 0x38

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

	// RVA: 0x59E990 Offset: 0x59DB90 VA: 0x18059E990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59EB60 Offset: 0x59DD60 VA: 0x18059EB60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<GetFriendCode>d__47 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 886
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<ResponseState, Response<ResponseFriendCode>> resultCallback; // 0x20
	public FriendsListManager <>4__this; // 0x28

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

	// RVA: 0x59E7F0 Offset: 0x59D9F0 VA: 0x18059E7F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59E950 Offset: 0x59DB50 VA: 0x18059E950 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<PollForRequests>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 887
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListManager <>4__this; // 0x20
	private FriendsListManager.<>c__DisplayClass50_0 <>8__1; // 0x28

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

	// RVA: 0x59EBA0 Offset: 0x59DDA0 VA: 0x18059EBA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59F290 Offset: 0x59E490 VA: 0x18059F290 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<PopulatePlatformFriendList>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 888
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListManager <>4__this; // 0x20

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

	// RVA: 0x59F2D0 Offset: 0x59E4D0 VA: 0x18059F2D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59F380 Offset: 0x59E580 VA: 0x18059F380 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<Post>d__65 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 889
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string endpoint; // 0x20
	public string jsonContent; // 0x28
	public FriendsListManager <>4__this; // 0x30
	public Action<ResponseState, string> resultCallback; // 0x38
	private UnityWebRequest <request>5__2; // 0x40

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

	// RVA: 0x59F3C0 Offset: 0x59E5C0 VA: 0x18059F3C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59F640 Offset: 0x59E840 VA: 0x18059F640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListManager.<RefreshFriendsList>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 890
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FriendsListManager <>4__this; // 0x20
	private FriendsListManager.<>c__DisplayClass35_0 <>8__1; // 0x28
	public Action cb; // 0x30

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

	// RVA: 0x59F680 Offset: 0x59E880 VA: 0x18059F680 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59FA70 Offset: 0x59EC70 VA: 0x18059FA70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FriendsListManager : DestroyableSingleton<FriendsListManager> // TypeDefIndex: 891
{
	// Fields
	public JoinGameButton joinGameButton; // 0x28
	public List<ResponseFriends> Friends; // 0x30
	public List<FriendsListManager.PlatformFriend> PlatformFriends; // 0x38
	public List<ResponseBlockedPlayer> BlockedPlayers; // 0x40
	public List<ResponseBlockedBy> BlockedByPlayers; // 0x48
	public List<ResponseReceivedFriendRequest> ReceivedRequests; // 0x50
	public List<LobbyInvite> ReceivedLobbyInvites; // 0x58
	public List<FriendsListManager.RecentPlayedWithPlayer> RecentlyPlayedWith; // 0x60
	public FriendListNotification FriendListNotification; // 0x68
	public FriendsListConfirmMenu ConfirmationScreen; // 0x70
	public FriendsListUI Ui; // 0x78
	public FriendsListButton FriendsListButton; // 0x80
	public SpriteRenderer LoadScreen; // 0x88
	public bool FriendCodeHidden; // 0x90
	public Sprite GlobalPlayerIcon; // 0x98
	[HideInInspector]
	public Dictionary<int, StringNames> ErrorCodes; // 0xA0
	private readonly Logger logger; // 0xA8
	private Coroutine pollingRoutine; // 0xB0
	private bool gotFriendRequests; // 0xB8
	private bool gotLobbyInvites; // 0xB9
	[SerializeField]
	private FriendsListConfirmMenu ConfirmationScreenPrefab; // 0xC0
	[SerializeField]
	private FriendsListUI UiPrefab; // 0xC8
	[SerializeField]
	private FriendsListButton FriendsListButtonPrefab; // 0xD0

	// Methods

	// RVA: 0x58D650 Offset: 0x58C850 VA: 0x18058D650 Slot: 4
	public override void Awake() { }

	// RVA: 0x58E7C0 Offset: 0x58D9C0 VA: 0x18058E7C0 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x58E720 Offset: 0x58D920 VA: 0x18058E720
	private void OnAllowFriendInvitesChanged() { }

	// RVA: 0x58F960 Offset: 0x58EB60 VA: 0x18058F960
	private bool SetRequestHeaders(UnityWebRequest request) { }

	// RVA: 0x58E8A0 Offset: 0x58DAA0 VA: 0x18058E8A0
	public void OnSignIn() { }

	// RVA: 0x58E240 Offset: 0x58D440 VA: 0x18058E240
	public bool HasPlayerBlockedMeUsername(string friendcode) { }

	// RVA: 0x58E320 Offset: 0x58D520 VA: 0x18058E320
	public bool HasPlayerBlockedMe(string puid) { }

	// RVA: 0x58E4E0 Offset: 0x58D6E0 VA: 0x18058E4E0
	public bool IsPlayerBlocked(string puid) { }

	// RVA: 0x58E5C0 Offset: 0x58D7C0 VA: 0x18058E5C0
	public bool IsPlayerFriend(string puid) { }

	// RVA: 0x58E400 Offset: 0x58D600 VA: 0x18058E400
	public bool IsPlayerBlockedUsername(string friendcode) { }

	[IteratorStateMachine(typeof(FriendsListManager.<RefreshFriendsList>d__35))]
	// RVA: 0x58EBC0 Offset: 0x58DDC0 VA: 0x18058EBC0
	public IEnumerator RefreshFriendsList(Action cb, bool checkPSNBlocked = True) { }

	// RVA: 0x58E960 Offset: 0x58DB60 VA: 0x18058E960
	public void OnSignOut() { }

	// RVA: 0x58FAC0 Offset: 0x58ECC0 VA: 0x18058FAC0
	private void StartPolling() { }

	// RVA: 0x58E960 Offset: 0x58DB60 VA: 0x18058E960
	private void StopPolling() { }

	// RVA: 0x58F720 Offset: 0x58E920 VA: 0x18058F720
	public void SetRecentlyPlayed(List<NetworkedPlayerInfo> players) { }

	// RVA: 0x590390 Offset: 0x58F590 VA: 0x180590390
	public void UpdateFriendsDataWithPlayers(List<NetworkedPlayerInfo> players) { }

	// RVA: 0x58ED40 Offset: 0x58DF40 VA: 0x18058ED40
	public void ReparentUI() { }

	// RVA: 0x58EA50 Offset: 0x58DC50 VA: 0x18058EA50
	public void OpenUi() { }

	// RVA: 0x58D970 Offset: 0x58CB70 VA: 0x18058D970
	public void CloseUI() { }

	// RVA: 0x58E6A0 Offset: 0x58D8A0 VA: 0x18058E6A0
	public void JoinGameViaFriendInvite(string roomCode) { }

	[IteratorStateMachine(typeof(FriendsListManager.<CoJoinGameViaFriendInvite>d__45))]
	// RVA: 0x58DA40 Offset: 0x58CC40 VA: 0x18058DA40
	private IEnumerator CoJoinGameViaFriendInvite(string roomCode) { }

	[IteratorStateMachine(typeof(FriendsListManager.<CheckFriendCodeOnLogin>d__46))]
	// RVA: 0x58D910 Offset: 0x58CB10 VA: 0x18058D910
	public IEnumerator CheckFriendCodeOnLogin() { }

	[IteratorStateMachine(typeof(FriendsListManager.<GetFriendCode>d__47))]
	// RVA: 0x58DE50 Offset: 0x58D050 VA: 0x18058DE50
	public IEnumerator GetFriendCode(Action<ResponseState, Response<ResponseFriendCode>> resultCallback) { }

	// RVA: 0x58F5C0 Offset: 0x58E7C0 VA: 0x18058F5C0
	public void SetFriendCode(string username, Action<ResponseState, Response<ResponseFriendCode>> resultCallback) { }

	// RVA: 0x58E9A0 Offset: 0x58DBA0 VA: 0x18058E9A0
	public void OpenConfirmationScreen(Action confirm, FriendsListConfirmMenu.ActionType type, string recipientFriendCode) { }

	[IteratorStateMachine(typeof(FriendsListManager.<PollForRequests>d__50))]
	// RVA: 0x58EA70 Offset: 0x58DC70 VA: 0x18058EA70
	private IEnumerator PollForRequests() { }

	// RVA: 0x58DEC0 Offset: 0x58D0C0 VA: 0x18058DEC0
	public void GetFriends(Action<ResponseState, Response<ResponseFriendWrapper>> resultCallback) { }

	// RVA: 0x58E0C0 Offset: 0x58D2C0 VA: 0x18058E0C0
	public void GetReceivedFriendRequests(Action<ResponseState, Response<ResponseReceivedFriendRequestWrapper>> resultCallback) { }

	// RVA: 0x58F160 Offset: 0x58E360 VA: 0x18058F160
	public void SendFriendRequest(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58F000 Offset: 0x58E200 VA: 0x18058F000
	public void SendFriendRequestByUsername(string username, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58DB30 Offset: 0x58CD30 VA: 0x18058DB30
	public void DenyFriendRequest(string puid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58EC30 Offset: 0x58DE30 VA: 0x18058EC30
	public void RemoveFriend(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58D7A0 Offset: 0x58C9A0 VA: 0x18058D7A0
	public void BlockPlayer(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x590280 Offset: 0x58F480 VA: 0x180590280
	public void UnblockPlayer(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58DD50 Offset: 0x58CF50 VA: 0x18058DD50
	public void GetBlockedPlayers(Action<ResponseState, Response<ResponseBlockedWrapper>> resultCallback) { }

	// RVA: 0x58F2D0 Offset: 0x58E4D0 VA: 0x18058F2D0
	public void SendGameInvite(string recipientPuid, string roomCode, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	// RVA: 0x58DFC0 Offset: 0x58D1C0 VA: 0x18058DFC0
	public void GetLobbyInvites(Action<ResponseState, Response<ResponseGameInvites>> resultCallback) { }

	// RVA: 0x58DC40 Offset: 0x58CE40 VA: 0x18058DC40
	public void DenyLobbyInvite(string recipientPuid, Action<ResponseState, Response<ResponseFriendsListRequest>> resultCallback) { }

	[IteratorStateMachine(typeof(FriendsListManager.<Get>d__63))]
	// RVA: 0x58E1C0 Offset: 0x58D3C0 VA: 0x18058E1C0
	private IEnumerator Get(string endpoint, Action<ResponseState, string> resultCallback) { }

	[IteratorStateMachine(typeof(FriendsListManager.<Delete>d__64))]
	// RVA: 0x58DAB0 Offset: 0x58CCB0 VA: 0x18058DAB0
	private IEnumerator Delete(string endpoint, Action<ResponseState, string> resultCallback) { }

	[IteratorStateMachine(typeof(FriendsListManager.<Post>d__65))]
	// RVA: 0x58EB30 Offset: 0x58DD30 VA: 0x18058EB30
	private IEnumerator Post(string endpoint, string jsonContent, Action<ResponseState, string> resultCallback) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnAwake() { }

	[IteratorStateMachine(typeof(FriendsListManager.<PopulatePlatformFriendList>d__67))]
	// RVA: 0x58EAD0 Offset: 0x58DCD0 VA: 0x18058EAD0
	public IEnumerator PopulatePlatformFriendList() { }

	// RVA: 0x58F4F0 Offset: 0x58E6F0 VA: 0x18058F4F0
	public void SetFriendButtonColor(bool isGrayedOut) { }

	// RVA: 0x590A10 Offset: 0x58FC10 VA: 0x180590A10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x58FB60 Offset: 0x58ED60 VA: 0x18058FB60
	private void <CheckFriendCodeOnLogin>b__46_0(ResponseState cb, Response<ResponseFriendCode> response) { }

	[CompilerGenerated]
	// RVA: 0x58FDA0 Offset: 0x58EFA0 VA: 0x18058FDA0
	private void <PollForRequests>b__50_0(ResponseState cb, Response<ResponseReceivedFriendRequestWrapper> response) { }

	[CompilerGenerated]
	// RVA: 0x590260 Offset: 0x58F460 VA: 0x180590260
	private bool <PollForRequests>b__50_3(ResponseReceivedFriendRequest f) { }

	[CompilerGenerated]
	// RVA: 0x590260 Offset: 0x58F460 VA: 0x180590260
	private bool <PollForRequests>b__50_7(LobbyInvite f) { }
}

// Namespace: 
[Serializable]
public class FriendsListUI.FriendsListTabButton // TypeDefIndex: 892
{
	// Fields
	public FriendsListUI.FriendsListTab tab; // 0x10
	public GameObject tabObject; // 0x18
	public List<SpriteRenderer> selectedSprites; // 0x20
	public bool selectable; // 0x28

	// Methods

	// RVA: 0x590DF0 Offset: 0x58FFF0 VA: 0x180590DF0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum FriendsListUI.FriendsListTab // TypeDefIndex: 893
{
	// Fields
	public int value__; // 0x0
	public const FriendsListUI.FriendsListTab LobbyPlayers = 0;
	public const FriendsListUI.FriendsListTab RecentPlayers = 1;
	public const FriendsListUI.FriendsListTab AmongUsFriends = 2;
	public const FriendsListUI.FriendsListTab Blocked = 3;
	public const FriendsListUI.FriendsListTab Notifications = 4;
	public const FriendsListUI.FriendsListTab AddFriend = 5;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FriendsListUI.<>c // TypeDefIndex: 894
{
	// Fields
	public static readonly FriendsListUI.<>c <>9; // 0x0
	public static Action<FriendsListGuestWarning> <>9__57_0; // 0x8
	public static Action<FriendsListGuestWarning> <>9__57_2; // 0x10
	public static Action<SpriteRenderer> <>9__58_1; // 0x18
	public static Action<SpriteRenderer> <>9__62_0; // 0x20
	public static Action<ResponseState, Response<ResponseFriendsListRequest>> <>9__63_0; // 0x28

	// Methods

	// RVA: 0x5A30F0 Offset: 0x5A22F0 VA: 0x1805A30F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A8F0 Offset: 0x589AF0 VA: 0x18058A8F0
	internal void <Open>b__57_0(FriendsListGuestWarning t) { }

	// RVA: 0x5A04A0 Offset: 0x59F6A0 VA: 0x1805A04A0
	internal void <Open>b__57_2(FriendsListGuestWarning g) { }

	// RVA: 0x5A0470 Offset: 0x59F670 VA: 0x1805A0470
	internal void <OpenTab>b__58_1(SpriteRenderer s) { }

	// RVA: 0x5A0270 Offset: 0x59F470 VA: 0x1805A0270
	internal void <CloseTab>b__62_0(SpriteRenderer s) { }

	// RVA: 0x59FFE0 Offset: 0x59F1E0 VA: 0x18059FFE0
	internal void <AddFriend>b__63_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListUI.<>c__DisplayClass58_0 // TypeDefIndex: 895
{
	// Fields
	public int tabType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <OpenTab>b__0(FriendsListUI.FriendsListTabButton t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendsListUI.<>c__DisplayClass69_0 // TypeDefIndex: 896
{
	// Fields
	public NetworkedPlayerInfo player; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2F40 Offset: 0x5A2140 VA: 0x1805A2F40
	internal bool <RefreshLobbyPlayers>b__1(PlayerControl pc) { }
}

// Namespace: 
public class FriendsListUI : MonoBehaviour // TypeDefIndex: 897
{
	// Fields
	public static FriendsListUI Instance; // 0x0
	public TextMeshPro FriendCodeText; // 0x20
	public SpriteRenderer FriendCodeHiddenIcon; // 0x28
	public GameObject FriendCodeHideToggleObject; // 0x30
	public FriendsListUI.FriendsListTabButton[] Tabs; // 0x38
	public GameObject NotifArea; // 0x40
	public GameObject BlockedArea; // 0x48
	public GameObject FriendArea; // 0x50
	public GameObject PlatformFriendArea; // 0x58
	public GameObject LobbyPlayerArea; // 0x60
	public GameObject RecentlyPlayedArea; // 0x68
	public GameObject LobbyPlayersTab; // 0x70
	public GameObject LobbyPlayersInactiveTab; // 0x78
	public GameObject PlatformFriendsButton; // 0x80
	public FriendRequestBar FriendRequestBar; // 0x88
	public BlockedPlayerBar BlockedPlayerBar; // 0x90
	public OnlineFriendBar OnlineFriendBar; // 0x98
	public OnlineFriendBar PlatformFriendBar; // 0xA0
	public LobbyPlayerBar LobbyPlayerBar; // 0xA8
	public LobbyInviteBar LobbyInviteBar; // 0xB0
	public Scroller FriendsScroller; // 0xB8
	public Scroller PlatformFriendsScroller; // 0xC0
	public Scroller BlockedScroller; // 0xC8
	public Scroller NotifScroller; // 0xD0
	public Scroller LobbyScroller; // 0xD8
	public Scroller RecentlyPlayedScroller; // 0xE0
	public SpriteRenderer InactiveAllFriends; // 0xE8
	public SpriteRenderer InactivePlatformFriends; // 0xF0
	public TextBoxTMP AddFriendArea; // 0xF8
	public List<FriendsListGuestWarning> guestAccountWarnings; // 0x100
	public float YStart; // 0x108
	public float YOffset; // 0x10C
	public SpriteRenderer ViewRequestsButton; // 0x110
	public TextMeshPro ViewRequestsText; // 0x118
	public Color NewRequestColor; // 0x120
	public Color NoRequestsColor; // 0x130
	public GameObject AddFriendObjects; // 0x140
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x148
	public UiElement DefaultButtonSelected; // 0x150
	public List<UiElement> ControllerSelectable; // 0x158
	public GameObject glyphL; // 0x160
	public GameObject glyphR; // 0x168
	private int selectedTab; // 0x170
	private List<FriendsListBar> lobbyBars; // 0x178
	private List<FriendsListBar> friendBars; // 0x180
	private List<FriendsListBar> platformFriendBars; // 0x188
	private List<FriendsListBar> notifBars; // 0x190
	private string friendCodeHiddenText; // 0x198
	private bool viewingAllFriends; // 0x1A0
	private string currentSceneName; // 0x1A8
	private float addFriendCooldown; // 0x1B0

	// Properties
	public FriendsListUI.FriendsListTab CurrentTab { get; }
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x595D10 Offset: 0x594F10 VA: 0x180595D10
	public FriendsListUI.FriendsListTab get_CurrentTab() { }

	// RVA: 0x5595B0 Offset: 0x5587B0 VA: 0x1805595B0
	public bool get_IsOpen() { }

	// RVA: 0x591880 Offset: 0x590A80 VA: 0x180591880
	public void Open() { }

	// RVA: 0x5915F0 Offset: 0x5907F0 VA: 0x1805915F0
	public void OpenTab(int tabType) { }

	// RVA: 0x591460 Offset: 0x590660 VA: 0x180591460
	public void Close(bool force = False) { }

	// RVA: 0x591580 Offset: 0x590780 VA: 0x180591580 Slot: 4
	public virtual void OnDisable() { }

	// RVA: 0x5955B0 Offset: 0x5947B0 VA: 0x1805955B0
	private void Update() { }

	// RVA: 0x5912C0 Offset: 0x5904C0 VA: 0x1805912C0
	private void CloseTab() { }

	// RVA: 0x590E00 Offset: 0x590000 VA: 0x180590E00
	public void AddFriend() { }

	// RVA: 0x592290 Offset: 0x591490 VA: 0x180592290
	public void RefreshFriends() { }

	// RVA: 0x593A90 Offset: 0x592C90 VA: 0x180593A90
	public void RefreshPlatformFriends() { }

	// RVA: 0x591F00 Offset: 0x591100 VA: 0x180591F00
	public void RefreshBlockedPlayers() { }

	// RVA: 0x590FC0 Offset: 0x5901C0 VA: 0x180590FC0
	private void ClearNotifs() { }

	// RVA: 0x593000 Offset: 0x592200 VA: 0x180593000
	public void RefreshNotifications() { }

	// RVA: 0x5928B0 Offset: 0x591AB0 VA: 0x1805928B0
	public void RefreshLobbyPlayers() { }

	// RVA: 0x594090 Offset: 0x593290 VA: 0x180594090
	public void RefreshRecentlyPlayed() { }

	// RVA: 0x595120 Offset: 0x594320 VA: 0x180595120
	public void UpdateFriendBars() { }

	// RVA: 0x591550 Offset: 0x590750 VA: 0x180591550
	public void GiveFocus() { }

	// RVA: 0x5945F0 Offset: 0x5937F0 VA: 0x1805945F0
	public void ToggleFriendCode() { }

	// RVA: 0x595430 Offset: 0x594630 VA: 0x180595430
	public void UpdateFriendCodeUI() { }

	// RVA: 0x5958A0 Offset: 0x594AA0 VA: 0x1805958A0
	public void ViewAllFriends() { }

	// RVA: 0x595AB0 Offset: 0x594CB0 VA: 0x180595AB0
	public void ViewPlatformFriends() { }

	// RVA: 0x594410 Offset: 0x593610 VA: 0x180594410
	public void ResendGuardianEmail() { }

	// RVA: 0x594460 Offset: 0x593660 VA: 0x180594460
	public void SortSamePlatformToTop(List<FriendsListBar> friendBars) { }

	// RVA: 0x595CC0 Offset: 0x594EC0 VA: 0x180595CC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5946B0 Offset: 0x5938B0 VA: 0x1805946B0
	private void <Open>b__57_1() { }

	[CompilerGenerated]
	// RVA: 0x594FA0 Offset: 0x5941A0 VA: 0x180594FA0
	private void <RefreshFriends>b__64_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x595060 Offset: 0x594260 VA: 0x180595060
	private void <RefreshPlatformFriends>b__65_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x594F60 Offset: 0x594160 VA: 0x180594F60
	private void <RefreshBlockedPlayers>b__66_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x595020 Offset: 0x594220 VA: 0x180595020
	private void <RefreshNotifications>b__68_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x595020 Offset: 0x594220 VA: 0x180595020
	private void <RefreshNotifications>b__68_1(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x594FE0 Offset: 0x5941E0 VA: 0x180594FE0
	private void <RefreshLobbyPlayers>b__69_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x5950A0 Offset: 0x5942A0 VA: 0x1805950A0
	private void <RefreshRecentlyPlayed>b__70_0(PassiveButton b) { }

	[CompilerGenerated]
	// RVA: 0x5950E0 Offset: 0x5942E0 VA: 0x1805950E0
	internal static int <SortSamePlatformToTop>g__ComparePreferSamePlatform|78_0(FriendsListBar a, FriendsListBar b) { }
}

// Namespace: 
public class LobbyPlayerBar : FriendsListBar // TypeDefIndex: 898
{
	// Fields
	public TextMeshPro InGameName; // 0x80
	public SpriteRenderer AddFriendButton; // 0x88
	public SpriteRenderer BlockButton; // 0x90
	public Sprite BlockedSprite; // 0x98
	public Sprite FriendSprite; // 0xA0
	public SpriteRenderer StatusSpriteRen; // 0xA8
	private bool IsFriend; // 0xB0
	private bool IsBlocked; // 0xB1
	public UiElement ViewProfileButton; // 0xB8
	public List<PassiveButton> ButtonsToDisableForSelf; // 0xC0

	// Methods

	// RVA: 0x59ADA0 Offset: 0x599FA0 VA: 0x18059ADA0 Slot: 4
	public override void SetUp(string puid, FriendsListUI parentUI, string friendCode, string playerInGameName) { }

	// RVA: 0x59A9D0 Offset: 0x599BD0 VA: 0x18059A9D0
	public void CheckAddFriend() { }

	// RVA: 0x59A6E0 Offset: 0x5998E0 VA: 0x18059A6E0
	public void AddFriend() { }

	// RVA: 0x59AAB0 Offset: 0x599CB0 VA: 0x18059AAB0
	public void CheckBlockPlayer() { }

	// RVA: 0x59A900 Offset: 0x599B00 VA: 0x18059A900
	public void BlockPlayer() { }

	// RVA: 0x59AB90 Offset: 0x599D90 VA: 0x18059AB90
	private void DisableButton(SpriteRenderer button) { }

	// RVA: 0x59B780 Offset: 0x59A980 VA: 0x18059B780
	private void UpdateStatus() { }

	// RVA: 0x59ACF0 Offset: 0x599EF0 VA: 0x18059ACF0
	public void SetInfoFromClient(ClientData clientData) { }

	// RVA: 0x59ABD0 Offset: 0x599DD0 VA: 0x18059ABD0
	public void DisableButtonsForLocalPlayer() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x59B000 Offset: 0x59A200 VA: 0x18059B000
	private bool <AddFriend>b__12_0(ResponseReceivedFriendRequest r) { }

	[CompilerGenerated]
	// RVA: 0x59B060 Offset: 0x59A260 VA: 0x18059B060
	private void <AddFriend>b__12_1(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x59B360 Offset: 0x59A560 VA: 0x18059B360
	private void <BlockPlayer>b__14_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x59B740 Offset: 0x59A940 VA: 0x18059B740
	private void <BlockPlayer>b__14_1(ResponseState cb, Response<ResponseFriendsListRequest> response) { }
}

// Namespace: 
public class OnlineFriendBar : FriendsListBar // TypeDefIndex: 899
{
	// Fields
	public PassiveButton LobbyInviteButton; // 0x80
	private bool canInvite; // 0x88

	// Methods

	// RVA: 0x59C130 Offset: 0x59B330 VA: 0x18059C130 Slot: 4
	public override void SetUp(string puid, FriendsListUI parentUI, string friendCode, string playerInGameName) { }

	// RVA: 0x59B870 Offset: 0x59AA70 VA: 0x18059B870
	private void Awake() { }

	// RVA: 0x59BDA0 Offset: 0x59AFA0 VA: 0x18059BDA0
	public void PlatformInviteToLobby() { }

	// RVA: 0x59BCD0 Offset: 0x59AED0 VA: 0x18059BCD0
	public void InviteToLobby() { }

	// RVA: 0x59BB40 Offset: 0x59AD40 VA: 0x18059BB40
	public void CheckRemoveFriend() { }

	// RVA: 0x59BF40 Offset: 0x59B140 VA: 0x18059BF40
	private void RemoveFriend() { }

	// RVA: 0x59BA70 Offset: 0x59AC70 VA: 0x18059BA70
	public void CheckBlockPlayer() { }

	// RVA: 0x59B9B0 Offset: 0x59ABB0 VA: 0x18059B9B0
	private void BlockPlayer() { }

	// RVA: 0x59BE80 Offset: 0x59B080 VA: 0x18059BE80
	private void PlatformSendGameInvite() { }

	// RVA: 0x59C000 Offset: 0x59B200 VA: 0x18059C000
	private void SendGameInvite() { }

	// RVA: 0x59BC10 Offset: 0x59AE10 VA: 0x18059BC10
	private void Delete() { }

	// RVA: 0x59C620 Offset: 0x59B820 VA: 0x18059C620
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x59C420 Offset: 0x59B620 VA: 0x18059C420
	private void <RemoveFriend>b__7_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x59C260 Offset: 0x59B460 VA: 0x18059C260
	private void <BlockPlayer>b__9_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x59C500 Offset: 0x59B700 VA: 0x18059C500
	private void <SendGameInvite>b__11_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }

	[CompilerGenerated]
	// RVA: 0x57C190 Offset: 0x57B390 VA: 0x18057C190
	private bool <Delete>b__12_0(ResponseFriends notif) { }
}

// Namespace: 
public enum GridArrange.StartAlign // TypeDefIndex: 900
{
	// Fields
	public int value__; // 0x0
	public const GridArrange.StartAlign Left = 0;
	public const GridArrange.StartAlign Right = 1;
}

// Namespace: 
public class GridArrange : MonoBehaviour // TypeDefIndex: 901
{
	// Fields
	public Vector2 CellSize; // 0x20
	public GridArrange.StartAlign Alignment; // 0x28
	public int MaxColumns; // 0x2C
	private List<Transform> cells; // 0x30
	private static List<Transform> currentChildren; // 0x0

	// Methods

	// RVA: 0x596620 Offset: 0x595820 VA: 0x180596620
	private void Start() { }

	// RVA: 0x5962C0 Offset: 0x5954C0 VA: 0x1805962C0
	private void FixedUpdate() { }

	// RVA: 0x595F00 Offset: 0x595100 VA: 0x180595F00
	private void CheckCurrentChildren() { }

	// RVA: 0x5962D0 Offset: 0x5954D0 VA: 0x1805962D0
	private void GetChildsActive() { }

	// RVA: 0x595D50 Offset: 0x594F50 VA: 0x180595D50
	private void ArrangeChilds() { }

	// RVA: 0x596710 Offset: 0x595910 VA: 0x180596710
	public void .ctor() { }

	// RVA: 0x5966A0 Offset: 0x5958A0 VA: 0x1805966A0
	private static void .cctor() { }
}

// Namespace: 
public class HideInLobbyAndChat : MonoBehaviour // TypeDefIndex: 902
{
	// Fields
	public GameObject ObjectToHide; // 0x20

	// Methods

	// RVA: 0x596720 Offset: 0x595920 VA: 0x180596720
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrewmateTrackerAnim : ScriptableObject // TypeDefIndex: 903
{
	// Fields
	public AnimationClip SlashAnim; // 0x18
	public AnimationClip CrewmateAnim; // 0x20
	public AudioClip Sfx; // 0x28

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CrewmatesKilledTracker.<>c // TypeDefIndex: 904
{
	// Fields
	public static readonly CrewmatesKilledTracker.<>c <>9; // 0x0
	public static Func<PlayerControl, bool> <>9__7_0; // 0x8
	public static Func<PlayerControl, bool> <>9__8_0; // 0x10

	// Methods

	// RVA: 0x5A3090 Offset: 0x5A2290 VA: 0x1805A3090
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A03B0 Offset: 0x59F5B0 VA: 0x1805A03B0
	internal bool <OnCrewmateKilled>b__7_0(PlayerControl pc) { }

	// RVA: 0x5A0300 Offset: 0x59F500 VA: 0x1805A0300
	internal bool <OnCrewmateDisconnect>b__8_0(PlayerControl pc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CrewmatesKilledTracker.<CoRefreshDelay>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 905
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CrewmatesKilledTracker <>4__this; // 0x20

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

	// RVA: 0x59DB10 Offset: 0x59CD10 VA: 0x18059DB10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59DBB0 Offset: 0x59CDB0 VA: 0x18059DBB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CrewmatesKilledTracker : MonoBehaviour // TypeDefIndex: 906
{
	// Fields
	[SerializeField]
	private MultiPrefabInstantiator crewmates; // 0x20
	[SerializeField]
	private float crewmateSpacing; // 0x28
	[SerializeField]
	private Vector3 crewmateScale; // 0x2C
	[SerializeField]
	private List<CrewmateTrackerAnim> slashAnimations; // 0x38
	private PseudoRandomList<CrewmateTrackerAnim> animList; // 0x40
	private List<CrewmateTrackerEntry> crewmateSprites; // 0x48

	// Methods

	// RVA: 0x58C310 Offset: 0x58B510 VA: 0x18058C310
	private void Awake() { }

	// RVA: 0x58C6B0 Offset: 0x58B8B0 VA: 0x18058C6B0
	public void OnCrewmateKilled() { }

	// RVA: 0x58C3C0 Offset: 0x58B5C0 VA: 0x18058C3C0
	public void OnCrewmateDisconnect() { }

	[IteratorStateMachine(typeof(CrewmatesKilledTracker.<CoRefreshDelay>d__9))]
	// RVA: 0x58C360 Offset: 0x58B560 VA: 0x18058C360
	private IEnumerator CoRefreshDelay() { }

	// RVA: 0x58C8D0 Offset: 0x58BAD0 VA: 0x18058C8D0
	private void Start() { }

	// RVA: 0x58CC30 Offset: 0x58BE30 VA: 0x18058CC30
	public void .ctor() { }
}

// Namespace: 
public class CrewmateTrackerEntry : MonoBehaviour // TypeDefIndex: 907
{
	// Fields
	[SerializeField]
	private SpriteAnim crewmateAnimator; // 0x20
	[SerializeField]
	private SpriteAnim slashAnimator; // 0x28
	[SerializeField]
	private AnimationClip aliveClip; // 0x30
	[CompilerGenerated]
	private bool <IsKilled>k__BackingField; // 0x38

	// Properties
	public bool IsKilled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IsKilled() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	private void set_IsKilled(bool value) { }

	// RVA: 0x58C1E0 Offset: 0x58B3E0 VA: 0x18058C1E0
	public void SetKilled(CrewmateTrackerAnim anim) { }

	// RVA: 0x58C170 Offset: 0x58B370 VA: 0x18058C170
	public void Reset() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class HorizontalGauge : MonoBehaviour // TypeDefIndex: 908
{
	// Fields
	public float Value; // 0x20
	public float MaxValue; // 0x24
	public float maskScale; // 0x28
	public SpriteMask Mask; // 0x30
	public SpriteRenderer MaskArea; // 0x38
	private float lastValue; // 0x40

	// Methods

	// RVA: 0x596800 Offset: 0x595A00 VA: 0x180596800
	public void Update() { }

	// RVA: 0x596B00 Offset: 0x595D00 VA: 0x180596B00
	public void .ctor() { }
}

// Namespace: 
public class HorizontalSpriteGauge : MonoBehaviour // TypeDefIndex: 909
{
	// Fields
	public float Value; // 0x20
	public float MaxValue; // 0x24
	public float maskScale; // 0x28
	public SpriteRenderer Mask; // 0x30
	private float lastValue; // 0x38

	// Methods

	// RVA: 0x596B30 Offset: 0x595D30 VA: 0x180596B30
	public void Update() { }

	// RVA: 0x596CE0 Offset: 0x595EE0 VA: 0x180596CE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HudManager.<>c // TypeDefIndex: 910
{
	// Fields
	public static readonly HudManager.<>c <>9; // 0x0
	public static Func<PlainShipRoom, bool> <>9__85_0; // 0x8

	// Methods

	// RVA: 0x5A2FD0 Offset: 0x5A21D0 VA: 0x1805A2FD0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A04E0 Offset: 0x59F6E0 VA: 0x1805A04E0
	internal bool <StopReactorFlash>b__85_0(PlainShipRoom r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<CoDelayedInitTouchType>d__101 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 911
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HudManager <>4__this; // 0x20

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

	// RVA: 0x59CFD0 Offset: 0x59C1D0 VA: 0x18059CFD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59D300 Offset: 0x59C500 VA: 0x18059D300 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<CoFadeFullScreen>d__87 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 912
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HudManager <>4__this; // 0x20
	public bool showLoader; // 0x28
	public Color target; // 0x2C
	public Color source; // 0x3C
	public float duration; // 0x4C
	private float <t>5__2; // 0x50

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

	// RVA: 0x59D340 Offset: 0x59C540 VA: 0x18059D340 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59D6B0 Offset: 0x59C8B0 VA: 0x18059D6B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<CoReactorFlash>d__88 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 913
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HudManager <>4__this; // 0x20
	private WaitForSeconds <wait>5__2; // 0x28
	private bool <light>5__3; // 0x30

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

	// RVA: 0x59D880 Offset: 0x59CA80 VA: 0x18059D880 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59DAD0 Offset: 0x59CCD0 VA: 0x18059DAD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<CoShowIntro>d__89 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 914
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HudManager <>4__this; // 0x20

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

	// RVA: 0x59DBF0 Offset: 0x59CDF0 VA: 0x18059DBF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59E200 Offset: 0x59D400 VA: 0x18059E200 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<CoTaskComplete>d__65 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 915
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HudManager <>4__this; // 0x20
	private float <time>5__2; // 0x28

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

	// RVA: 0x59E240 Offset: 0x59D440 VA: 0x18059E240 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59E540 Offset: 0x59D740 VA: 0x18059E540 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HudManager.<ShowEmblem>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 916
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool shhh; // 0x20
	public HudManager <>4__this; // 0x28

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

	// RVA: 0x59FAB0 Offset: 0x59ECB0 VA: 0x18059FAB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59FC00 Offset: 0x59EE00 VA: 0x18059FC00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HudManager : DestroyableSingleton<HudManager> // TypeDefIndex: 917
{
	// Fields
	public FollowerCamera PlayerCam; // 0x28
	public Camera UICamera; // 0x30
	public MeetingHud MeetingPrefab; // 0x38
	public KillButton KillButton; // 0x40
	public AdminButton AdminButton; // 0x48
	public SabotageButton SabotageButton; // 0x50
	public VentButton ImpostorVentButton; // 0x58
	public UseButton UseButton; // 0x60
	public PetButton PetButton; // 0x68
	public AbilityButton AbilityButton; // 0x70
	public SecondaryAbilityButton SecondaryAbilityButton; // 0x78
	public ReportButton ReportButton; // 0x80
	public GameObject TaskStuff; // 0x88
	public TaskPanelBehaviour TaskPanel; // 0x90
	public CrewmatesKilledTracker CrewmatesKilled; // 0x98
	public ChatController Chat; // 0xA0
	public DialogueBox Dialogue; // 0xA8
	public Transform TaskCompleteOverlay; // 0xB0
	private float taskDirtyTimer; // 0xB8
	public MeshRenderer ShadowQuad; // 0xC0
	public SpriteRenderer FullScreen; // 0xC8
	[CompilerGenerated]
	private Coroutine <ReactorFlash>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Coroutine <OxyFlash>k__BackingField; // 0xD8
	public PassiveButton MapButton; // 0xE0
	public GameObject MapButtonGlyph; // 0xE8
	public KillOverlay KillOverlay; // 0xF0
	public IVirtualJoystick joystick; // 0xF8
	public VirtualJoystick joystickR; // 0x100
	public MonoBehaviour[] Joysticks; // 0x108
	public MonoBehaviour RightVJoystick; // 0x110
	public Collider2D LeftStickDeadZone; // 0x118
	public Collider2D RightStickDeadZone; // 0x120
	public DiscussBehaviour discussEmblem; // 0x128
	public ShhhBehaviour shhhEmblem; // 0x130
	public IntroCutscene IntroPrefab; // 0x138
	public OptionsMenuBehaviour GameMenu; // 0x140
	public NotificationPopper Notifier; // 0x148
	public RoomTracker roomTracker; // 0x150
	public AudioClip TaskCompleteSound; // 0x158
	public AudioClip TaskUpdateSound; // 0x160
	public Transform consoleUIRoot; // 0x168
	public GameObject[] consoleUIObjects; // 0x170
	public GameObject menuNavigationPrompts; // 0x178
	public GameObject GameLoadAnimation; // 0x180
	public LobbyTimerExtensionUI LobbyTimerExtensionUI; // 0x188
	public float consoleUIHorizontalShift; // 0x190
	public GameObject playerListPrompt; // 0x198
	public AlertFlash AlertFlash; // 0x1A0
	public DangerMeter DangerMeter; // 0x1A8
	public GameObject SettingsButton; // 0x1B0
	private StringBuilder tasksString; // 0x1B8
	private DualshockLightManager.LightOverlayHandle lightFlashHandle; // 0x1C0
	[CompilerGenerated]
	private bool <IsIntroDisplayed>k__BackingField; // 0x1C8

	// Properties
	public Coroutine ReactorFlash { get; set; }
	public Coroutine OxyFlash { get; set; }
	public bool IsIntroDisplayed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public Coroutine get_ReactorFlash() { }

	[CompilerGenerated]
	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	public void set_ReactorFlash(Coroutine value) { }

	[CompilerGenerated]
	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	public Coroutine get_OxyFlash() { }

	[CompilerGenerated]
	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	public void set_OxyFlash(Coroutine value) { }

	[CompilerGenerated]
	// RVA: 0x599C30 Offset: 0x598E30 VA: 0x180599C30
	public bool get_IsIntroDisplayed() { }

	[CompilerGenerated]
	// RVA: 0x599C60 Offset: 0x598E60 VA: 0x180599C60
	private void set_IsIntroDisplayed(bool value) { }

	// RVA: 0x598B10 Offset: 0x597D10 VA: 0x180598B10
	public void Start() { }

	// RVA: 0x597230 Offset: 0x596430 VA: 0x180597230
	public void OnGameStart() { }

	// RVA: 0x5989A0 Offset: 0x597BA0 VA: 0x1805989A0
	public void ShowTaskComplete() { }

	[IteratorStateMachine(typeof(HudManager.<CoTaskComplete>d__65))]
	// RVA: 0x596ED0 Offset: 0x5960D0 VA: 0x180596ED0
	private IEnumerator CoTaskComplete() { }

	// RVA: 0x597CE0 Offset: 0x596EE0 VA: 0x180597CE0
	public void SetJoystickSize(float size) { }

	// RVA: 0x5987D0 Offset: 0x5979D0 VA: 0x1805987D0
	private void SetVirtualJoystickSize(VirtualJoystick jStick, float size, Vector2 dist) { }

	// RVA: 0x597FA0 Offset: 0x5971A0 VA: 0x180597FA0
	public void SetTouchType(ControlTypes type) { }

	// RVA: 0x597000 Offset: 0x596200 VA: 0x180597000
	public void InitMap() { }

	// RVA: 0x596FA0 Offset: 0x5961A0 VA: 0x180596FA0
	public void DeselectMapButton() { }

	// RVA: 0x598F60 Offset: 0x598160 VA: 0x180598F60
	public void ToggleMapVisible(MapOptions options) { }

	// RVA: 0x597630 Offset: 0x596830 VA: 0x180597630
	public void SetHudActive(PlayerControl localPlayer, RoleBehaviour role, bool isActive) { }

	// RVA: 0x599490 Offset: 0x598690 VA: 0x180599490
	public void UpdateVoteTimerText(StringNames key, int value) { }

	// RVA: 0x597590 Offset: 0x596790 VA: 0x180597590
	public void SetHudActive(bool isActive) { }

	// RVA: 0x5991F0 Offset: 0x5983F0 VA: 0x1805991F0
	public void ToggleRightJoystick(bool isActive) { }

	// RVA: 0x598F20 Offset: 0x598120 VA: 0x180598F20
	public void ToggleMapButton(bool isActive) { }

	// RVA: 0x598EF0 Offset: 0x5980F0 VA: 0x180598EF0
	public void ToggleMapButtonGlyph(bool isActive) { }

	// RVA: 0x597F10 Offset: 0x597110 VA: 0x180597F10
	public void SetMapButtonEnabled(bool enabled) { }

	// RVA: 0x599280 Offset: 0x598480 VA: 0x180599280
	public void ToggleSettingsButton(bool isActive) { }

	// RVA: 0x5994C0 Offset: 0x5986C0 VA: 0x1805994C0
	public void Update() { }

	[IteratorStateMachine(typeof(HudManager.<ShowEmblem>d__81))]
	// RVA: 0x5988A0 Offset: 0x597AA0 VA: 0x1805988A0
	public IEnumerator ShowEmblem(bool shhh) { }

	// RVA: 0x598A90 Offset: 0x597C90 VA: 0x180598A90
	public void StartReactorFlash() { }

	// RVA: 0x598A10 Offset: 0x597C10 VA: 0x180598A10
	public void StartOxyFlash() { }

	// RVA: 0x598970 Offset: 0x597B70 VA: 0x180598970
	public void ShowPopUp(string text) { }

	// RVA: 0x598CA0 Offset: 0x597EA0 VA: 0x180598CA0
	public void StopReactorFlash() { }

	// RVA: 0x598C10 Offset: 0x597E10 VA: 0x180598C10
	public void StopOxyFlash() { }

	[IteratorStateMachine(typeof(HudManager.<CoFadeFullScreen>d__87))]
	// RVA: 0x596D70 Offset: 0x595F70 VA: 0x180596D70
	public IEnumerator CoFadeFullScreen(Color source, Color target, float duration = 0,2, bool showLoader = False) { }

	[IteratorStateMachine(typeof(HudManager.<CoReactorFlash>d__88))]
	// RVA: 0x596E10 Offset: 0x596010 VA: 0x180596E10
	private IEnumerator CoReactorFlash() { }

	[IteratorStateMachine(typeof(HudManager.<CoShowIntro>d__89))]
	// RVA: 0x596E70 Offset: 0x596070 VA: 0x180596E70
	public IEnumerator CoShowIntro() { }

	// RVA: 0x596FD0 Offset: 0x5961D0 VA: 0x180596FD0
	public void HideGameLoader() { }

	// RVA: 0x597350 Offset: 0x596550 VA: 0x180597350
	public void OpenMeetingRoom(PlayerControl reporter) { }

	// RVA: 0x597560 Offset: 0x596760 VA: 0x180597560
	public void SetAlertOverlay(bool enabled) { }

	// RVA: 0x5971D0 Offset: 0x5963D0 VA: 0x1805971D0 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x597130 Offset: 0x596330 VA: 0x180597130
	public void NotifyOfDeath() { }

	// RVA: 0x597160 Offset: 0x596360 VA: 0x180597160
	public void NotifyOfDisconnect(PlayerControl pc) { }

	// RVA: 0x5992B0 Offset: 0x5984B0 VA: 0x1805992B0
	public void ToggleUseAndPetButton(IUsable useTarget, bool canPlayNormally, bool canPet) { }

	// RVA: 0x598940 Offset: 0x597B40 VA: 0x180598940
	public void ShowLobbyTimer(int timeRemainingSeconds) { }

	// RVA: 0x598910 Offset: 0x597B10 VA: 0x180598910
	public void ShowLobbyTimerPopup(int timeRemainingSeconds, int timeGrantedSeconds) { }

	// RVA: 0x597320 Offset: 0x596520 VA: 0x180597320
	public void OnLobbyTimerExtended() { }

	// RVA: 0x596F30 Offset: 0x596130 VA: 0x180596F30
	private void DelayedInitTouchType() { }

	[IteratorStateMachine(typeof(HudManager.<CoDelayedInitTouchType>d__101))]
	// RVA: 0x596D10 Offset: 0x595F10 VA: 0x180596D10
	private IEnumerator CoDelayedInitTouchType() { }

	// RVA: 0x599BC0 Offset: 0x598DC0 VA: 0x180599BC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x599420 Offset: 0x598620 VA: 0x180599420
	private void <Start>b__62_0() { }
}

// Namespace: 
public interface IFocusHolder // TypeDefIndex: 918
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GiveFocus();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LoseFocus();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CheckCollision(Vector2 pt);
}

// Namespace: 
private enum InGamePlayerList.ListState // TypeDefIndex: 919
{
	// Fields
	public int value__; // 0x0
	public const InGamePlayerList.ListState Closed = 0;
	public const InGamePlayerList.ListState Open = 1;
	public const InGamePlayerList.ListState Opening = 2;
	public const InGamePlayerList.ListState Closing = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class InGamePlayerList.<TransitionCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 920
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InGamePlayerList <>4__this; // 0x20
	public float targetValue; // 0x28
	private float <dir>5__2; // 0x2C

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

	// RVA: 0x59FC40 Offset: 0x59EE40 VA: 0x18059FC40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x59FFA0 Offset: 0x59F1A0 VA: 0x18059FFA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class InGamePlayerList : MonoBehaviour // TypeDefIndex: 921
{
	// Fields
	public Vector3 offsetFromEdge; // 0x20
	private float windowWidth; // 0x2C
	private Vector3 openPosition; // 0x30
	private Vector3 closedPosition; // 0x3C
	public float openTime; // 0x48
	public float buttonHeight; // 0x4C
	public ObjectPoolBehavior buttonPool; // 0x50
	public ControllerNavMenu controllerNavMenu; // 0x58
	public SpriteRenderer backgroundSprite; // 0x60
	public SpriteRenderer backgroundSpriteMask; // 0x68
	public GameObject ChatScreen; // 0x70
	public ControllerButtonBehavior OpenChatButton; // 0x78
	private InGamePlayerList.ListState currentState; // 0x80
	private float openLevel; // 0x84
	public static InGamePlayerList instance; // 0x0

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x599C90 Offset: 0x598E90 VA: 0x180599C90
	private void Awake() { }

	// RVA: 0x599E40 Offset: 0x599040 VA: 0x180599E40
	private void OnEnable() { }

	// RVA: 0x599E00 Offset: 0x599000 VA: 0x180599E00
	private void OnDestroy() { }

	// RVA: 0x59A280 Offset: 0x599480 VA: 0x18059A280
	private void RefreshMenu() { }

	// RVA: 0x59A6C0 Offset: 0x5998C0 VA: 0x18059A6C0
	public bool get_IsActive() { }

	// RVA: 0x59A4E0 Offset: 0x5996E0 VA: 0x18059A4E0
	public void ToggleActive() { }

	// RVA: 0x59A330 Offset: 0x599530 VA: 0x18059A330
	public void SetActive(bool active) { }

	[IteratorStateMachine(typeof(InGamePlayerList.<TransitionCoroutine>d__24))]
	// RVA: 0x59A630 Offset: 0x599830 VA: 0x18059A630
	private IEnumerator TransitionCoroutine(float targetValue) { }

	// RVA: 0x59A410 Offset: 0x599610 VA: 0x18059A410
	private void SetBackgroundMaskLayer(int maskLayer) { }

	// RVA: 0x599EB0 Offset: 0x5990B0 VA: 0x180599EB0
	private void PopulateButtons() { }

	// RVA: 0x59A6A0 Offset: 0x5998A0 VA: 0x18059A6A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerIdentifierButton.<>c__DisplayClass6_0 // TypeDefIndex: 922
{
	// Fields
	public byte targetId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5BA070 Offset: 0x5B9270 VA: 0x1805BA070
	internal bool <SetTargetPlayerId>b__0(PlayerControl pc) { }
}

// Namespace: 
public class PlayerIdentifierButton : PoolableBehavior // TypeDefIndex: 923
{
	// Fields
	[SerializeField]
	private TextMeshPro NameText; // 0x30
	[SerializeField]
	private PlatformIdentifier PlatformIdentifier; // 0x38
	[SerializeField]
	private PoolablePlayer PlayerPreview; // 0x40
	[SerializeField]
	private SpriteRenderer MaskArea; // 0x48
	private byte targetPlayerId; // 0x50

	// Methods

	// RVA: 0x59C770 Offset: 0x59B970 VA: 0x18059C770
	public void Populate(NetworkedPlayerInfo player) { }

	// RVA: 0x59C9C0 Offset: 0x59BBC0 VA: 0x18059C9C0
	private void SetTargetPlayerId(byte targetId) { }

	// RVA: 0x59C8B0 Offset: 0x59BAB0 VA: 0x18059C8B0
	private void SetMaskLayer(int maskLayer) { }

	// RVA: 0x59C630 Offset: 0x59B830 VA: 0x18059C630
	public void DisplayProfileInfo() { }

	// RVA: 0x59C830 Offset: 0x59BA30 VA: 0x18059C830 Slot: 4
	public override void Reset() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x59CCB0 Offset: 0x59BEB0 VA: 0x18059CCB0
	private bool <DisplayProfileInfo>b__8_0(PlayerControl pc) { }
}

// Namespace: 
public enum ControlTypes // TypeDefIndex: 924
{
	// Fields
	public int value__; // 0x0
	public const ControlTypes VirtualJoystick = 0;
	public const ControlTypes ScreenJoystick = 1;
	public const ControlTypes Keyboard = 2;
	public const ControlTypes Controller = 3;
}

// Namespace: 
public interface IVirtualJoystick // TypeDefIndex: 925
{
	// Properties
	public abstract Vector2 DeltaL { get; }
	public abstract Vector2 DeltaR { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_DeltaL();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_DeltaR();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ToggleVisuals(bool on);
}

// Namespace: 
public class KeyboardJoystick : MonoBehaviour, IVirtualJoystick // TypeDefIndex: 926
{
	// Fields
	private Vector2 del; // 0x20
	private static Player player; // 0x0
	private Controller myController; // 0x28
	private Collider2D[] hitBuffer; // 0x30
	private int touchId; // 0x38

	// Properties
	public Vector2 DeltaL { get; }
	public Vector2 DeltaR { get; }

	// Methods

	// RVA: 0x5A6760 Offset: 0x5A5960 VA: 0x1805A6760 Slot: 4
	public Vector2 get_DeltaL() { }

	// RVA: 0x54D140 Offset: 0x54C340 VA: 0x18054D140 Slot: 5
	public Vector2 get_DeltaR() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void ToggleVisuals(bool on) { }

	// RVA: 0x5A5E30 Offset: 0x5A5030 VA: 0x1805A5E30
	private void UpdateTouchMovement() { }

	// RVA: 0x5A6220 Offset: 0x5A5420 VA: 0x1805A6220
	private void Update() { }

	// RVA: 0x5A5920 Offset: 0x5A4B20 VA: 0x1805A5920
	private static void HandleHud() { }

	// RVA: 0x5A66D0 Offset: 0x5A58D0 VA: 0x1805A66D0
	public void .ctor() { }
}

// Namespace: 
public class ScreenJoystick : MonoBehaviour, IVirtualJoystick // TypeDefIndex: 927
{
	// Fields
	private Collider2D[] hitBuffer; // 0x20
	[CompilerGenerated]
	private Vector2 <DeltaL>k__BackingField; // 0x28
	private Controller myController; // 0x30
	private int touchId; // 0x38

	// Properties
	public Vector2 DeltaL { get; set; }
	public Vector2 DeltaR { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5B65C0 Offset: 0x5B57C0 VA: 0x1805B65C0 Slot: 4
	public Vector2 get_DeltaL() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_DeltaL(Vector2 value) { }

	// RVA: 0x54D140 Offset: 0x54C340 VA: 0x18054D140 Slot: 5
	public Vector2 get_DeltaR() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void ToggleVisuals(bool on) { }

	// RVA: 0x5B6140 Offset: 0x5B5340 VA: 0x1805B6140
	private void FixedUpdate() { }

	// RVA: 0x5B6530 Offset: 0x5B5730 VA: 0x1805B6530
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VirtualJoystick.<>c__DisplayClass16_0 // TypeDefIndex: 928
{
	// Fields
	public bool on; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9B30 Offset: 0x5B8D30 VA: 0x1805B9B30
	internal void <ToggleVisuals>b__0(SpriteRenderer s) { }
}

// Namespace: 
public class VirtualJoystick : MonoBehaviour, IVirtualJoystick // TypeDefIndex: 929
{
	// Fields
	public float InnerRadius; // 0x20
	public float OuterRadius; // 0x24
	public CircleCollider2D Outer; // 0x28
	public SpriteRenderer Inner; // 0x30
	public SpriteRenderer[] AllSprites; // 0x38
	public bool IsDragged; // 0x40
	public bool IsRightJoystick; // 0x41
	[CompilerGenerated]
	private Vector2 <DeltaL>k__BackingField; // 0x44
	[CompilerGenerated]
	private Vector2 <DeltaR>k__BackingField; // 0x4C
	private VirtualJoystickController myController; // 0x58

	// Properties
	public Vector2 DeltaL { get; set; }
	public Vector2 DeltaR { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5BAB90 Offset: 0x5B9D90 VA: 0x1805BAB90 Slot: 4
	public Vector2 get_DeltaL() { }

	[CompilerGenerated]
	// RVA: 0x5BABD0 Offset: 0x5B9DD0 VA: 0x1805BABD0
	private void set_DeltaL(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x5BABB0 Offset: 0x5B9DB0 VA: 0x1805BABB0 Slot: 5
	public Vector2 get_DeltaR() { }

	[CompilerGenerated]
	// RVA: 0x5BABE0 Offset: 0x5B9DE0 VA: 0x1805BABE0
	private void set_DeltaR(Vector2 value) { }

	// RVA: 0x5BA7A0 Offset: 0x5B99A0 VA: 0x1805BA7A0 Slot: 6
	public void ToggleVisuals(bool on) { }

	// RVA: 0x5BA2A0 Offset: 0x5B94A0 VA: 0x1805BA2A0 Slot: 7
	protected virtual void FixedUpdate() { }

	// RVA: 0x5BA890 Offset: 0x5B9A90 VA: 0x1805BA890 Slot: 8
	public virtual void UpdateJoystick(HowToPlaySceneMovementPageFingerBehaviour finger, Vector2 velocity, bool syncFinger) { }

	// RVA: 0x5BAB20 Offset: 0x5B9D20 VA: 0x1805BAB20
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlay.<>c__DisplayClass13_0 // TypeDefIndex: 930
{
	// Fields
	public OverlayKillAnimation killAnimation; // 0x10
	public KillOverlay <>4__this; // 0x18
	public KillOverlayInitData initData; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B97A0 Offset: 0x5B89A0 VA: 0x1805B97A0
	internal IEnumerator <ShowKillAnimation>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlay.<>c__DisplayClass14_0 // TypeDefIndex: 931
{
	// Fields
	public MeetingCalledAnimation prefab; // 0x10
	public KillOverlay <>4__this; // 0x18
	public NetworkedPlayerInfo.PlayerOutfit playerOutfit; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9930 Offset: 0x5B8B30 VA: 0x1805B9930
	internal IEnumerator <ShowMeeting>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlay.<CoShowOne>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 932
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public OverlayAnimation anim; // 0x20
	public KillOverlay <>4__this; // 0x28

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

	// RVA: 0x5B78A0 Offset: 0x5B6AA0 VA: 0x1805B78A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B7980 Offset: 0x5B6B80 VA: 0x1805B7980 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlay.<ShowAll>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 933
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KillOverlay <>4__this; // 0x20

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

	// RVA: 0x5B91F0 Offset: 0x5B83F0 VA: 0x1805B91F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B92D0 Offset: 0x5B84D0 VA: 0x1805B92D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlay.<WaitForFinish>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 934
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KillOverlay <>4__this; // 0x20

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

	// RVA: 0x5BA1E0 Offset: 0x5B93E0 VA: 0x1805BA1E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5BA260 Offset: 0x5B9460 VA: 0x1805BA260 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class KillOverlay : MonoBehaviour // TypeDefIndex: 935
{
	// Fields
	public SpriteRenderer background; // 0x20
	public GameObject flameParent; // 0x28
	public OverlayKillAnimation[] KillAnims; // 0x30
	public OverlayKillAnimation[] HorseWrangleAnims; // 0x38
	public OverlayKillAnimation[] CustomKillAnimations; // 0x40
	private Queue<Func<IEnumerator>> queue; // 0x48
	private Coroutine showAll; // 0x50
	private Coroutine showOne; // 0x58

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x5A7520 Offset: 0x5A6720 VA: 0x1805A7520
	public bool get_IsOpen() { }

	[IteratorStateMachine(typeof(KillOverlay.<WaitForFinish>d__10))]
	// RVA: 0x5A7450 Offset: 0x5A6650 VA: 0x1805A7450
	public IEnumerator WaitForFinish() { }

	// RVA: 0x5A6A70 Offset: 0x5A5C70 VA: 0x1805A6A70
	public void ShowKillAnimation(NetworkedPlayerInfo killer, NetworkedPlayerInfo victim) { }

	// RVA: 0x5A6EA0 Offset: 0x5A60A0 VA: 0x1805A6EA0
	public void ShowKillAnimation(OverlayKillAnimation killAnimation, NetworkedPlayerInfo killer, NetworkedPlayerInfo victim) { }

	// RVA: 0x5A71B0 Offset: 0x5A63B0 VA: 0x1805A71B0
	public void ShowKillAnimation(OverlayKillAnimation killAnimation, KillOverlayInitData initData) { }

	// RVA: 0x5A7300 Offset: 0x5A6500 VA: 0x1805A7300
	public void ShowMeeting(MeetingCalledAnimation prefab, NetworkedPlayerInfo.PlayerOutfit playerOutfit) { }

	[IteratorStateMachine(typeof(KillOverlay.<ShowAll>d__15))]
	// RVA: 0x5A6A10 Offset: 0x5A5C10 VA: 0x1805A6A10
	private IEnumerator ShowAll() { }

	[IteratorStateMachine(typeof(KillOverlay.<CoShowOne>d__16))]
	// RVA: 0x5A69A0 Offset: 0x5A5BA0 VA: 0x1805A69A0
	private IEnumerator CoShowOne(OverlayAnimation anim) { }

	// RVA: 0x5A74B0 Offset: 0x5A66B0 VA: 0x1805A74B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillOverlayInitData.<>c__DisplayClass5_0 // TypeDefIndex: 936
{
	// Fields
	public NetworkedPlayerInfo killer; // 0x10
	public NetworkedPlayerInfo victim; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A2F40 Offset: 0x5A2140 VA: 0x1805A2F40
	internal bool <.ctor>b__0(PlayerControl p) { }

	// RVA: 0x5B9EF0 Offset: 0x5B90F0 VA: 0x1805B9EF0
	internal bool <.ctor>b__1(PlayerControl p) { }
}

// Namespace: 
public class KillOverlayInitData // TypeDefIndex: 937
{
	// Fields
	public NetworkedPlayerInfo.PlayerOutfit killerOutfit; // 0x10
	public PlayerBodyTypes killerBodyType; // 0x18
	public NetworkedPlayerInfo.PlayerOutfit victimOutfit; // 0x20
	public PlayerBodyTypes victimBodyType; // 0x28

	// Methods

	// RVA: 0x5A6780 Offset: 0x5A5980 VA: 0x1805A6780
	public void .ctor(NetworkedPlayerInfo.PlayerOutfit killerOutfit, PlayerBodyTypes killerBodyType, NetworkedPlayerInfo.PlayerOutfit victimOutfit, PlayerBodyTypes victimBodyType) { }

	// RVA: 0x5A67D0 Offset: 0x5A59D0 VA: 0x1805A67D0
	public void .ctor(NetworkedPlayerInfo killer, NetworkedPlayerInfo victim) { }
}

// Namespace: 
public class LoadingBarManager : DestroyableSingleton<LoadingBarManager> // TypeDefIndex: 938
{
	// Fields
	[SerializeField]
	private AmongUsLoadingBar loadingBar; // 0x28

	// Methods

	// RVA: 0x5A8400 Offset: 0x5A7600 VA: 0x1805A8400
	public void ToggleLoadingBar(bool on) { }

	// RVA: 0x5A83E0 Offset: 0x5A75E0 VA: 0x1805A83E0
	public void SetLoadingPercent(float percent, StringNames loadText) { }

	// RVA: 0x5A8440 Offset: 0x5A7640 VA: 0x1805A8440
	public void .ctor() { }
}

// Namespace: 
public class LobbyNotificationMessage : MonoBehaviour // TypeDefIndex: 939
{
	// Fields
	[SerializeField]
	private SpriteRenderer Icon; // 0x20
	[SerializeField]
	private TextMeshPro Text; // 0x28
	private float alphaTimer; // 0x30
	private float showDuration; // 0x34
	private float fadeDuration; // 0x38
	private Action onDestroy; // 0x40
	private Color textColor; // 0x48
	private List<SupportedLangs> languagesToBold; // 0x58

	// Methods

	// RVA: 0x5A8690 Offset: 0x5A7890 VA: 0x1805A8690
	private void Update() { }

	// RVA: 0x5A8480 Offset: 0x5A7680 VA: 0x1805A8480
	private void OnDestroy() { }

	// RVA: 0x5A84A0 Offset: 0x5A76A0 VA: 0x1805A84A0
	public void SetUp(string item, Sprite icon, Color textColor, Action onDestroy) { }

	// RVA: 0x5A8610 Offset: 0x5A7810 VA: 0x1805A8610
	public void UpdateMessage(string item) { }

	// RVA: 0x5A87A0 Offset: 0x5A79A0 VA: 0x1805A87A0
	public void .ctor() { }
}

// Namespace: 
public class LobbyTimerExtensionUI : MonoBehaviour // TypeDefIndex: 940
{
	// Fields
	[SerializeField]
	private TimerTextTMP timerText; // 0x20
	[SerializeField]
	private InfoTextBox popup; // 0x28
	[SerializeField]
	private TimerTextTMP popupTimerText; // 0x30
	[SerializeField]
	private AudioClip lobbyTimerPopUpSound; // 0x38
	private string timerTextTemplate; // 0x40
	private string popupTitleText; // 0x48
	private string popupBodyTextTemplate; // 0x50

	// Methods

	// RVA: 0x5A89E0 Offset: 0x5A7BE0 VA: 0x1805A89E0
	private void Awake() { }

	// RVA: 0x5A8E30 Offset: 0x5A8030 VA: 0x1805A8E30
	public void HideAll() { }

	// RVA: 0x5A8FD0 Offset: 0x5A81D0 VA: 0x1805A8FD0
	public void ShowLobbyTimer(int timeRemainingSeconds) { }

	// RVA: 0x5A8EF0 Offset: 0x5A80F0 VA: 0x1805A8EF0
	public void ShowLobbyTimerPopup(int timeRemainingSeconds, int timeGrantedSeconds) { }

	// RVA: 0x5A8EA0 Offset: 0x5A80A0 VA: 0x1805A8EA0
	private void HideLobbyTimer() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5A90B0 Offset: 0x5A82B0 VA: 0x1805A90B0
	private void <Awake>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0x5A9120 Offset: 0x5A8320 VA: 0x1805A9120
	private void <Awake>b__7_1() { }
}

// Namespace: 
public class InfectedOverlay : MonoBehaviour // TypeDefIndex: 941
{
	// Fields
	public MapRoom[] rooms; // 0x20
	private IActivatable doors; // 0x28
	private SabotageSystemType sabSystem; // 0x30
	public ButtonBehavior[] allButtons; // 0x38
	public ButtonBehavior selectedButton; // 0x40
	private const float selectCooldown = 0,5;
	private float currentCooldown; // 0x48

	// Properties
	public bool CanUseDoors { get; }
	public bool CanUseSabotage { get; }
	private bool DoorsPreventingSabotage { get; }

	// Methods

	// RVA: 0x5A57C0 Offset: 0x5A49C0 VA: 0x1805A57C0
	public bool get_CanUseDoors() { }

	// RVA: 0x5A5830 Offset: 0x5A4A30 VA: 0x1805A5830
	public bool get_CanUseSabotage() { }

	// RVA: 0x5A58D0 Offset: 0x5A4AD0 VA: 0x1805A58D0
	private bool get_DoorsPreventingSabotage() { }

	// RVA: 0x5A4F50 Offset: 0x5A4150 VA: 0x1805A4F50
	public void Start() { }

	// RVA: 0x5A4680 Offset: 0x5A3880 VA: 0x1805A4680
	private void FixedUpdate() { }

	// RVA: 0x5A49F0 Offset: 0x5A3BF0 VA: 0x1805A49F0
	private void OnEnable() { }

	// RVA: 0x5A48D0 Offset: 0x5A3AD0 VA: 0x1805A48D0
	private void OnDisable() { }

	// RVA: 0x5A4820 Offset: 0x5A3A20 VA: 0x1805A4820
	public void OnControlTypeChanged() { }

	// RVA: 0x5A45B0 Offset: 0x5A37B0 VA: 0x1805A45B0
	private void DeselectCurrent() { }

	// RVA: 0x5A4E40 Offset: 0x5A4040 VA: 0x1805A4E40
	private void Select(ButtonBehavior newSelected) { }

	// RVA: 0x5A4C30 Offset: 0x5A3E30 VA: 0x1805A4C30
	private void SelectClosestButton(Vector2 anchorSpot) { }

	// RVA: 0x5A51C0 Offset: 0x5A43C0 VA: 0x1805A51C0
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapBehaviour.<>c // TypeDefIndex: 942
{
	// Fields
	public static readonly MapBehaviour.<>c <>9; // 0x0
	public static Action<CounterArea> <>9__25_0; // 0x8
	public static Action<MapRoom> <>9__25_1; // 0x10

	// Methods

	// RVA: 0x5BA120 Offset: 0x5B9320 VA: 0x1805BA120
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B94B0 Offset: 0x5B86B0 VA: 0x1805B94B0
	internal void <Validate>b__25_0(CounterArea area) { }

	// RVA: 0x5B9690 Offset: 0x5B8890 VA: 0x1805B9690
	internal void <Validate>b__25_1(MapRoom area) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapBehaviour.<>c__DisplayClass25_0 // TypeDefIndex: 943
{
	// Fields
	public CounterArea area; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9B60 Offset: 0x5B8D60 VA: 0x1805B9B60
	internal bool <Validate>b__2(PlainShipRoom r) { }
}

// Namespace: 
public class MapBehaviour : MonoBehaviour // TypeDefIndex: 944
{
	// Fields
	public static MapBehaviour Instance; // 0x0
	public AlphaPulse ColorControl; // 0x20
	public SpriteRenderer HerePoint; // 0x28
	public SpriteRenderer TrackedHerePoint; // 0x30
	public MapCountOverlay countOverlay; // 0x38
	public InfectedOverlay infectedOverlay; // 0x40
	public MapTaskOverlay taskOverlay; // 0x48
	[SerializeField]
	private GameObject fadedBackground; // 0x50
	[SerializeField]
	private GameObject detectiveMapButtonPrefab; // 0x58
	private bool detectiveMapOpen; // 0x60
	private SpecialInputHandler specialInputHandler; // 0x68
	private bool countOverlayAllowsMovement; // 0x70
	private Nullable<Vector3> preMeetingPosition; // 0x74
	private Nullable<Vector3> trackedPreMeetingPosition; // 0x84
	private int trackedColorID; // 0x94
	private float trackedPointDelayTime; // 0x98
	private List<UiElement> detectiveLocationControllerButtons; // 0xA0

	// Properties
	public bool IsOpen { get; }
	public bool IsOpenStopped { get; }

	// Methods

	// RVA: 0x5AB2A0 Offset: 0x5AA4A0 VA: 0x1805AB2A0
	public bool get_IsOpen() { }

	// RVA: 0x5AB250 Offset: 0x5AA450 VA: 0x1805AB250
	public bool get_IsOpenStopped() { }

	// RVA: 0x5A9BD0 Offset: 0x5A8DD0 VA: 0x1805A9BD0
	public void SetPreMeetingPosition(Vector3 preMeetingPosition, bool trackedPlayer = False) { }

	// RVA: 0x5AA620 Offset: 0x5A9820 VA: 0x1805AA620
	public void Show(MapOptions opts) { }

	// RVA: 0x5A9230 Offset: 0x5A8430 VA: 0x1805A9230
	public void Close() { }

	// RVA: 0x5A9470 Offset: 0x5A8670 VA: 0x1805A9470
	public void DisableTrackerOverlays() { }

	// RVA: 0x5AAFC0 Offset: 0x5AA1C0 VA: 0x1805AAFC0
	private void Validate() { }

	// RVA: 0x5AA400 Offset: 0x5A9600 VA: 0x1805AA400
	private void ShowSabotageMap() { }

	// RVA: 0x5AA100 Offset: 0x5A9300 VA: 0x1805AA100
	private void ShowNormalMap() { }

	// RVA: 0x5A9E60 Offset: 0x5A9060 VA: 0x1805A9E60
	private void ShowDetectiveMap() { }

	// RVA: 0x5A9CE0 Offset: 0x5A8EE0 VA: 0x1805A9CE0
	private void ShowCountOverlay(bool allowedToMove, bool showLivePlayerPosition, bool includeDeadBodies) { }

	// RVA: 0x5A9560 Offset: 0x5A8760 VA: 0x1805A9560
	private void FixedUpdate() { }

	// RVA: 0x5A91D0 Offset: 0x5A83D0 VA: 0x1805A91D0
	private void Awake() { }

	// RVA: 0x5A9890 Offset: 0x5A8A90 VA: 0x1805A9890
	private void GenericShow() { }

	// RVA: 0x5A9C70 Offset: 0x5A8E70 VA: 0x1805A9C70
	public void SetTrackedHerePointColor(int colorID) { }

	// RVA: 0x5AACB0 Offset: 0x5A9EB0 VA: 0x1805AACB0
	private void UpdateTrackedPosition() { }

	// RVA: 0x5AB1E0 Offset: 0x5AA3E0 VA: 0x1805AB1E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5AAA00 Offset: 0x5A9C00 VA: 0x1805AAA00
	private void <ShowDetectiveMap>b__28_0(CounterArea area) { }
}

// Namespace: 
public class MapCountOverlay : MonoBehaviour // TypeDefIndex: 945
{
	// Fields
	public AlphaPulse BackgroundColor; // 0x20
	public TextMeshPro SabotageText; // 0x28
	public CounterArea[] CountAreas; // 0x30
	private readonly Collider2D[] buffer; // 0x38
	private ContactFilter2D filter; // 0x40
	private float timer; // 0x5C
	private bool isSab; // 0x60
	private bool showLivePlayerPosition; // 0x61
	private bool includeDeadBodies; // 0x62

	// Methods

	// RVA: 0x5AB490 Offset: 0x5AA690 VA: 0x1805AB490
	public void SetOptions(bool showLivePlayerPosition, bool includeDeadBodies) { }

	// RVA: 0x5AB2B0 Offset: 0x5AA4B0 VA: 0x1805AB2B0
	private void Awake() { }

	// RVA: 0x5AB3A0 Offset: 0x5AA5A0 VA: 0x1805AB3A0
	private void OnEnable() { }

	// RVA: 0x5AB320 Offset: 0x5AA520 VA: 0x1805AB320
	private void OnDisable() { }

	// RVA: 0x5AB4A0 Offset: 0x5AA6A0 VA: 0x1805AB4A0
	private void Update() { }

	// RVA: 0x5ABBA0 Offset: 0x5AADA0 VA: 0x1805ABBA0
	public void .ctor() { }
}

// Namespace: 
public enum MapOptions.Modes // TypeDefIndex: 946
{
	// Fields
	public int value__; // 0x0
	public const MapOptions.Modes None = 0;
	public const MapOptions.Modes Normal = 1;
	public const MapOptions.Modes CountOverlay = 2;
	public const MapOptions.Modes Sabotage = 3;
	public const MapOptions.Modes Detective = 4;
}

// Namespace: 
public class MapOptions // TypeDefIndex: 947
{
	// Fields
	public MapOptions.Modes Mode; // 0x10
	public bool AllowMovementWhileMapOpen; // 0x14
	public bool ShowLivePlayerPosition; // 0x15
	public bool IncludeDeadBodies; // 0x16

	// Methods

	// RVA: 0x5ABBF0 Offset: 0x5AADF0 VA: 0x1805ABBF0
	public void .ctor() { }
}

// Namespace: 
public class MapRoom : MonoBehaviour // TypeDefIndex: 948
{
	// Fields
	[CompilerGenerated]
	private InfectedOverlay <Parent>k__BackingField; // 0x20
	public SystemTypes room; // 0x28
	public SpriteRenderer door; // 0x30
	public SpriteRenderer special; // 0x38

	// Properties
	public InfectedOverlay Parent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public InfectedOverlay get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Parent(InfectedOverlay value) { }

	// RVA: 0x5AC630 Offset: 0x5AB830 VA: 0x1805AC630
	public void Start() { }

	// RVA: 0x5ABC10 Offset: 0x5AAE10 VA: 0x1805ABC10
	public void DoorsUpdate() { }

	// RVA: 0x5AC580 Offset: 0x5AB780 VA: 0x1805AC580
	internal void SetSpecialActive(float perc) { }

	// RVA: 0x5AC3C0 Offset: 0x5AB5C0 VA: 0x1805AC3C0
	public void SabotageReactor() { }

	// RVA: 0x5AC0C0 Offset: 0x5AB2C0 VA: 0x1805AC0C0
	public void SabotageHeli() { }

	// RVA: 0x5ABDF0 Offset: 0x5AAFF0 VA: 0x1805ABDF0
	public void SabotageComms() { }

	// RVA: 0x5AC2E0 Offset: 0x5AB4E0 VA: 0x1805AC2E0
	public void SabotageOxygen() { }

	// RVA: 0x5AC160 Offset: 0x5AB360 VA: 0x1805AC160
	public void SabotageLights() { }

	// RVA: 0x5AC4A0 Offset: 0x5AB6A0 VA: 0x1805AC4A0
	public void SabotageSeismic() { }

	// RVA: 0x5AC240 Offset: 0x5AB440 VA: 0x1805AC240
	public void SabotageMushroomMixup() { }

	// RVA: 0x5ABED0 Offset: 0x5AB0D0 VA: 0x1805ABED0
	public void SabotageDoors() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class MapTaskOverlay : MonoBehaviour // TypeDefIndex: 949
{
	// Fields
	public ObjectPoolBehavior icons; // 0x20
	private Dictionary<string, PooledMapIcon> data; // 0x28

	// Methods

	// RVA: 0x5ACC90 Offset: 0x5ABE90 VA: 0x1805ACC90
	public void Show() { }

	// RVA: 0x5ACE20 Offset: 0x5AC020 VA: 0x1805ACE20
	public void Update() { }

	// RVA: 0x5AC870 Offset: 0x5ABA70 VA: 0x1805AC870
	private void SetIconLocation(PlayerTask task) { }

	// RVA: 0x5AC6D0 Offset: 0x5AB8D0 VA: 0x1805AC6D0
	public void Hide() { }

	// RVA: 0x5ACFA0 Offset: 0x5AC1A0 VA: 0x1805ACFA0
	public void .ctor() { }
}

// Namespace: 
public class PooledMapIcon : PoolableBehavior // TypeDefIndex: 950
{
	// Fields
	public float NormalSize; // 0x30
	public int lastMapTaskStep; // 0x34
	public SpriteRenderer rend; // 0x38
	public AlphaPulse alphaPulse; // 0x40

	// Methods

	// RVA: 0x5B6050 Offset: 0x5B5250 VA: 0x1805B6050
	public void Update() { }

	// RVA: 0x5B5FD0 Offset: 0x5B51D0 VA: 0x1805B5FD0 Slot: 4
	public override void Reset() { }

	// RVA: 0x5B6120 Offset: 0x5B5320 VA: 0x1805B6120
	public void .ctor() { }
}

// Namespace: 
private class BlockedWords.LengthCompare : IComparer<string> // TypeDefIndex: 951
{
	// Fields
	public static readonly BlockedWords.LengthCompare Instance; // 0x0

	// Methods

	// RVA: 0x5A7570 Offset: 0x5A6770 VA: 0x1805A7570 Slot: 4
	public int Compare(string x, string y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A75B0 Offset: 0x5A67B0 VA: 0x1805A75B0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BlockedWords.<CensorWordsCo>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 952
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string chatText; // 0x20
	public Action<string> onWordsCensoredCallback; // 0x28

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

	// RVA: 0x5B65E0 Offset: 0x5B57E0 VA: 0x1805B65E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B6760 Offset: 0x5B5960 VA: 0x1805B6760 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public static class BlockedWords // TypeDefIndex: 953
{
	// Fields
	public static readonly HashSet<char> SymbolChars; // 0x0
	private static LetterTree SkipList; // 0x8

	// Methods

	// RVA: 0x5A4180 Offset: 0x5A3380 VA: 0x1805A4180
	private static void .cctor() { }

	// RVA: 0x5A3E80 Offset: 0x5A3080 VA: 0x1805A3E80
	public static void SetLanguage(TranslatedImageSet newLang) { }

	// RVA: 0x5A3D20 Offset: 0x5A2F20 VA: 0x1805A3D20
	public static bool ContainsWord(string chatText) { }

	// RVA: 0x5A3C10 Offset: 0x5A2E10 VA: 0x1805A3C10
	public static string CensorWords(string chatText, bool skipConsoleAPI = False) { }

	// RVA: 0x5A3AC0 Offset: 0x5A2CC0 VA: 0x1805A3AC0
	public static void CensorWordsAsync(string chatText, Action<string> onWordsCensoredCallback) { }

	[IteratorStateMachine(typeof(BlockedWords.<CensorWordsCo>d__8))]
	// RVA: 0x5A3BA0 Offset: 0x5A2DA0 VA: 0x1805A3BA0
	public static IEnumerator CensorWordsCo(string chatText, Action<string> onWordsCensoredCallback) { }

	// RVA: 0x5A3DE0 Offset: 0x5A2FE0 VA: 0x1805A3DE0
	private static bool IsLetter(char letter) { }
}

// Namespace: 
private enum LetterTree.NodeTypes // TypeDefIndex: 954
{
	// Fields
	public byte value__; // 0x0
	public const LetterTree.NodeTypes NonTerm = 0;
	public const LetterTree.NodeTypes Terminal = 1;
	public const LetterTree.NodeTypes TerminalStrict = 2;
	public const LetterTree.NodeTypes TerminalExact = 3;
	public const LetterTree.NodeTypes TerminalUnbroken = 4;
}

// Namespace: 
private class LetterTree.LetterNode // TypeDefIndex: 955
{
	// Fields
	public char Letter; // 0x10
	public LetterTree.NodeTypes Terminal; // 0x12
	public LetterTree.LetterNode[] Children; // 0x18
	public LetterTree.LetterNode[] SpecialChildren; // 0x20

	// Methods

	// RVA: 0x5A7970 Offset: 0x5A6B70 VA: 0x1805A7970
	public void .ctor(char l) { }

	// RVA: 0x5A7610 Offset: 0x5A6810 VA: 0x1805A7610
	public LetterTree.LetterNode CreateChild(char l) { }

	// RVA: 0x5A78C0 Offset: 0x5A6AC0 VA: 0x1805A78C0
	public LetterTree.LetterNode FindChild(char l) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LetterTree.<GetWords>d__13 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 956
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public LetterTree <>4__this; // 0x28
	private StringBuilder <b>5__2; // 0x30
	private LetterTree.LetterNode[] <>7__wrap2; // 0x38
	private int <>7__wrap3; // 0x40
	private IEnumerator<string> <>7__wrap4; // 0x48

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x5B8540 Offset: 0x5B7740 VA: 0x1805B8540 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5B8010 Offset: 0x5B7210 VA: 0x1805B8010 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x5B8680 Offset: 0x5B7880 VA: 0x1805B8680
	private void <>m__Finally1() { }

	// RVA: 0x5B86D0 Offset: 0x5B78D0 VA: 0x1805B86D0
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B8500 Offset: 0x5B7700 VA: 0x1805B8500 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B8460 Offset: 0x5B7660 VA: 0x1805B8460 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x5B8460 Offset: 0x5B7660 VA: 0x1805B8460 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LetterTree.<GetWords>d__14 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 957
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private LetterTree.LetterNode node; // 0x28
	public LetterTree.LetterNode <>3__node; // 0x30
	private StringBuilder b; // 0x38
	public StringBuilder <>3__b; // 0x40
	private int i; // 0x48
	public int <>3__i; // 0x4C
	public LetterTree <>4__this; // 0x50
	private LetterTree.LetterNode[] <>7__wrap1; // 0x58
	private int <>7__wrap2; // 0x60
	private IEnumerator<string> <>7__wrap3; // 0x68

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x5B9030 Offset: 0x5B8230 VA: 0x1805B9030 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5B8750 Offset: 0x5B7950 VA: 0x1805B8750 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x5B9150 Offset: 0x5B8350 VA: 0x1805B9150
	private void <>m__Finally1() { }

	// RVA: 0x5B91A0 Offset: 0x5B83A0 VA: 0x1805B91A0
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B8FF0 Offset: 0x5B81F0 VA: 0x1805B8FF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B8F40 Offset: 0x5B8140 VA: 0x1805B8F40 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x5B8F40 Offset: 0x5B8140 VA: 0x1805B8F40 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
public class LetterTree // TypeDefIndex: 958
{
	// Fields
	private LetterTree.LetterNode root; // 0x10

	// Methods

	// RVA: 0x5A7AE0 Offset: 0x5A6CE0 VA: 0x1805A7AE0
	public void Clear() { }

	// RVA: 0x5A79D0 Offset: 0x5A6BD0 VA: 0x1805A79D0
	public void AddWord(string word) { }

	// RVA: 0x5A7CD0 Offset: 0x5A6ED0 VA: 0x1805A7CD0
	private bool IsTerminator(char l) { }

	// RVA: 0x5A7C80 Offset: 0x5A6E80 VA: 0x1805A7C80
	public static bool IsFiller(char l) { }

	// RVA: 0x5A7CB0 Offset: 0x5A6EB0 VA: 0x1805A7CB0
	public static bool IsFiller(char l, out bool isUnicode) { }

	// RVA: 0x5A8320 Offset: 0x5A7520 VA: 0x1805A8320
	public static int ToIndex(char c) { }

	// RVA: 0x5A8080 Offset: 0x5A7280 VA: 0x1805A8080
	public static int ToIndex(char c, out bool isUnicode) { }

	// RVA: 0x5A7CF0 Offset: 0x5A6EF0 VA: 0x1805A7CF0
	public int SearchTestOnly(string input, int start) { }

	// RVA: 0x5A7D40 Offset: 0x5A6F40 VA: 0x1805A7D40
	public int Search(char[] input, int start) { }

	// RVA: 0x5A7E20 Offset: 0x5A7020 VA: 0x1805A7E20
	private int SubSearchRec(char[] input, int start, LetterTree.LetterNode previous, bool postDupes, bool postBreak, bool exactStart) { }

	[IteratorStateMachine(typeof(LetterTree.<GetWords>d__13))]
	// RVA: 0x5A7C10 Offset: 0x5A6E10 VA: 0x1805A7C10
	public IEnumerable<string> GetWords() { }

	[IteratorStateMachine(typeof(LetterTree.<GetWords>d__14))]
	// RVA: 0x5A7B70 Offset: 0x5A6D70 VA: 0x1805A7B70
	private IEnumerable<string> GetWords(StringBuilder b, int i, LetterTree.LetterNode node) { }

	// RVA: 0x5A8340 Offset: 0x5A7540 VA: 0x1805A8340
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingCalledAnimation.<>c__DisplayClass6_0 // TypeDefIndex: 959
{
	// Fields
	public MeetingCalledAnimation <>4__this; // 0x10
	public AspectPosition playerTransform; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9FD0 Offset: 0x5B91D0 VA: 0x1805B9FD0
	internal void <CoShow>b__0(float t) { }

	// RVA: 0x5BA020 Offset: 0x5B9220 VA: 0x1805BA020
	internal void <CoShow>b__1(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingCalledAnimation.<CoShow>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 960
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MeetingCalledAnimation <>4__this; // 0x20

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

	// RVA: 0x5B79C0 Offset: 0x5B6BC0 VA: 0x1805B79C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B7CF0 Offset: 0x5B6EF0 VA: 0x1805B7CF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class MeetingCalledAnimation : OverlayAnimation // TypeDefIndex: 961
{
	// Fields
	public AspectPosition emergencyText; // 0x20
	public PoolablePlayer playerParts; // 0x28
	public AudioClip Stinger; // 0x30
	public float StingerVolume; // 0x38
	public AnimationCurve CrewmateSlide; // 0x40

	// Methods

	// RVA: 0x5AD070 Offset: 0x5AC270 VA: 0x1805AD070
	public void Initialize(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	[IteratorStateMachine(typeof(MeetingCalledAnimation.<CoShow>d__6))]
	// RVA: 0x5AD010 Offset: 0x5AC210 VA: 0x1805AD010 Slot: 4
	public override IEnumerator CoShow(KillOverlay parent) { }

	// RVA: 0x5AD0B0 Offset: 0x5AC2B0 VA: 0x1805AD0B0
	public void .ctor() { }
}

// Namespace: 
public struct MeetingHud.VoterState // TypeDefIndex: 962
{
	// Fields
	public byte VoterId; // 0x0
	public byte VotedForId; // 0x1

	// Properties
	public bool AmDead { get; }
	public bool SkippedVote { get; }

	// Methods

	// RVA: 0x5BB100 Offset: 0x5BA300 VA: 0x1805BB100
	public bool get_AmDead() { }

	// RVA: 0x5BB110 Offset: 0x5BA310 VA: 0x1805BB110
	public bool get_SkippedVote() { }

	// RVA: 0x5BB070 Offset: 0x5BA270 VA: 0x1805BB070
	public static MeetingHud.VoterState Deserialize(MessageReader reader) { }

	// RVA: 0x5BB0B0 Offset: 0x5BA2B0 VA: 0x1805BB0B0
	public void Serialize(MessageWriter writer) { }
}

// Namespace: 
public enum MeetingHud.VoteStates // TypeDefIndex: 963
{
	// Fields
	public int value__; // 0x0
	public const MeetingHud.VoteStates Animating = 0;
	public const MeetingHud.VoteStates Discussion = 1;
	public const MeetingHud.VoteStates NotVoted = 2;
	public const MeetingHud.VoteStates Voted = 3;
	public const MeetingHud.VoteStates Results = 4;
	public const MeetingHud.VoteStates Proceeding = 5;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MeetingHud.<>c // TypeDefIndex: 964
{
	// Fields
	public static readonly MeetingHud.<>c <>9; // 0x0
	public static Func<MeetingHud.VoterState, bool> <>9__57_0; // 0x8
	public static Func<PlayerVoteArea, bool> <>9__65_0; // 0x10
	public static Func<PlayerVoteArea, int> <>9__73_0; // 0x18
	public static Func<PlayerVoteArea, byte> <>9__73_1; // 0x20
	public static Func<PlayerVoteArea, bool> <>9__76_0; // 0x28

	// Methods

	// RVA: 0x5BA180 Offset: 0x5B9380 VA: 0x1805BA180
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9730 Offset: 0x5B8930 VA: 0x1805B9730
	internal bool <VotingComplete>b__57_0(MeetingHud.VoterState s) { }

	// RVA: 0x5B9310 Offset: 0x5B8510 VA: 0x1805B9310
	internal bool <CheckForEndVoting>b__65_0(PlayerVoteArea ps) { }

	// RVA: 0x5B9370 Offset: 0x5B8570 VA: 0x1805B9370
	internal int <SortButtons>b__73_0(PlayerVoteArea p) { }

	// RVA: 0x5B93A0 Offset: 0x5B85A0 VA: 0x1805B93A0
	internal byte <SortButtons>b__73_1(PlayerVoteArea p) { }

	// RVA: 0x5B9340 Offset: 0x5B8540 VA: 0x1805B9340
	internal bool <GetVotesRemaining>b__76_0(PlayerVoteArea ps) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<>c__DisplayClass60_0 // TypeDefIndex: 965
{
	// Fields
	public PlayerControl pc; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9F20 Offset: 0x5B9120 VA: 0x1805B9F20
	internal bool <HandleDisconnect>b__0(PlayerVoteArea pv) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<>c__DisplayClass63_0 // TypeDefIndex: 966
{
	// Fields
	public byte srcPlayerId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9F50 Offset: 0x5B9150 VA: 0x1805B9F50
	internal bool <CastVote>b__0(PlayerVoteArea pv) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<>c__DisplayClass65_0 // TypeDefIndex: 967
{
	// Fields
	public bool tie; // 0x10
	public KeyValuePair<byte, int> max; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9F70 Offset: 0x5B9170 VA: 0x1805B9F70
	internal bool <CheckForEndVoting>b__1(NetworkedPlayerInfo v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<>c__DisplayClass75_0 // TypeDefIndex: 968
{
	// Fields
	public byte playerId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9F50 Offset: 0x5B9150 VA: 0x1805B9F50
	internal bool <DidVote>b__0(PlayerVoteArea p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<>c__DisplayClass83_0 // TypeDefIndex: 969
{
	// Fields
	public MessageReader msg; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5BA090 Offset: 0x5B9290 VA: 0x1805BA090
	internal bool <Deserialize>b__0(PlayerVoteArea ps) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<CoIntro>d__53 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 970
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MeetingHud <>4__this; // 0x20
	public NetworkedPlayerInfo reportedBody; // 0x28
	public NetworkedPlayerInfo reporter; // 0x30
	public NetworkedPlayerInfo[] deadBodies; // 0x38

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

	// RVA: 0x5B6AF0 Offset: 0x5B5CF0 VA: 0x1805B6AF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B7220 Offset: 0x5B6420 VA: 0x1805B7220 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingHud.<CoStartCutscene>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 971
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MeetingHud <>4__this; // 0x20

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

	// RVA: 0x5B7D30 Offset: 0x5B6F30 VA: 0x1805B7D30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B7FD0 Offset: 0x5B71D0 VA: 0x1805B7FD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class MeetingHud : InnerNetObject, IDisconnectHandler // TypeDefIndex: 972
{
	// Fields
	private const int NumColumns = 3;
	private const float ResultsTime = 5;
	private const float Depth = 0;
	public static MeetingHud Instance; // 0x0
	public SpriteRenderer BlackBackground; // 0x38
	public SpriteRenderer[] OuterMasks; // 0x40
	public SpriteRenderer[] PlayerColoredParts; // 0x48
	public MeetingIntroAnimation MeetingIntro; // 0x50
	public Transform ButtonParent; // 0x58
	public TextMeshPro TitleText; // 0x60
	public Vector3 VoteOrigin; // 0x68
	public Vector3 VoteButtonOffsets; // 0x74
	public PlayerVoteArea SkipVoteButton; // 0x80
	private PlayerVoteArea[] playerStates; // 0x88
	public PlayerVoteArea PlayerButtonPrefab; // 0x90
	public SpriteRenderer PlayerVotePrefab; // 0x98
	public Sprite CrackedGlass; // 0xA0
	public SpriteRenderer Glass; // 0xA8
	public PassiveButton ProceedButton; // 0xB0
	public AbilityButton MeetingAbilityButton; // 0xB8
	public AudioClip VoteSound; // 0xC0
	public AudioClip VoteLockinSound; // 0xC8
	public AudioClip VoteEndingSound; // 0xD0
	[SerializeField]
	private Transform meetingContents; // 0xD8
	private MeetingHud.VoteStates state; // 0xE0
	public GameObject SkippedVoting; // 0xE8
	public SpriteRenderer HostIcon; // 0xF0
	private NetworkedPlayerInfo exiledPlayer; // 0xF8
	private bool wasTie; // 0x100
	public TextMeshPro TimerText; // 0x108
	public float discussionTimer; // 0x110
	private byte reporterId; // 0x114
	private bool amDead; // 0x115
	private float resultsStartedAt; // 0x118
	private int lastSecond; // 0x11C
	private readonly Logger logger; // 0x120
	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected; // 0x128
	public UiElement ProceedButtonUi; // 0x130
	public List<UiElement> ControllerSelectable; // 0x138

	// Properties
	public bool IsPersistent { get; }
	public MeetingHud.VoteStates CurrentState { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool get_IsPersistent() { }

	// RVA: 0x5B2110 Offset: 0x5B1310 VA: 0x1805B2110
	public MeetingHud.VoteStates get_CurrentState() { }

	// RVA: 0x5AF410 Offset: 0x5AE610 VA: 0x1805AF410
	private void OnDisable() { }

	// RVA: 0x5AD0C0 Offset: 0x5AC2C0 VA: 0x1805AD0C0
	private void Awake() { }

	// RVA: 0x5B08C0 Offset: 0x5AFAC0 VA: 0x1805B08C0
	private void Start() { }

	// RVA: 0x5AF390 Offset: 0x5AE590 VA: 0x1805AF390 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x5B02A0 Offset: 0x5AF4A0 VA: 0x1805B02A0
	private void SetForegroundForDead() { }

	// RVA: 0x5B1070 Offset: 0x5B0270 VA: 0x1805B1070
	public void Update() { }

	// RVA: 0x5B0EE0 Offset: 0x5B00E0 VA: 0x1805B0EE0
	private void UpdateTimerText(StringNames key, int value) { }

	// RVA: 0x5B0380 Offset: 0x5AF580 VA: 0x1805B0380
	private void SetMasksEnabled(bool enabled) { }

	[IteratorStateMachine(typeof(MeetingHud.<CoIntro>d__53))]
	// RVA: 0x5AE390 Offset: 0x5AD590 VA: 0x1805AE390
	public IEnumerator CoIntro(NetworkedPlayerInfo reporter, NetworkedPlayerInfo reportedBody, NetworkedPlayerInfo[] deadBodies) { }

	[IteratorStateMachine(typeof(MeetingHud.<CoStartCutscene>d__54))]
	// RVA: 0x5AE420 Offset: 0x5AD620 VA: 0x1805AE420
	private IEnumerator CoStartCutscene() { }

	// RVA: 0x5B0290 Offset: 0x5AF490 VA: 0x1805B0290
	public void ServerStart(byte reporter) { }

	// RVA: 0x5AE140 Offset: 0x5AD340 VA: 0x1805AE140
	public void Close() { }

	// RVA: 0x5B18E0 Offset: 0x5B0AE0 VA: 0x1805B18E0
	private void VotingComplete(MeetingHud.VoterState[] states, NetworkedPlayerInfo exiled, bool tie) { }

	// RVA: 0x5AFEC0 Offset: 0x5AF0C0 VA: 0x1805AFEC0
	public bool Select(int suspectStateIdx) { }

	// RVA: 0x5AE480 Offset: 0x5AD680 VA: 0x1805AE480
	public void Confirm(byte suspectStateIdx) { }

	// RVA: 0x5AECC0 Offset: 0x5ADEC0 VA: 0x1805AECC0 Slot: 12
	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public void HandleDisconnect() { }

	// RVA: 0x5AEB10 Offset: 0x5ADD10 VA: 0x1805AEB10
	private void ForceSkipAll() { }

	// RVA: 0x5AD770 Offset: 0x5AC970 VA: 0x1805AD770
	public void CastVote(byte srcPlayerId, byte suspectPlayerId) { }

	// RVA: 0x5AE080 Offset: 0x5AD280 VA: 0x1805AE080
	public void ClearVote() { }

	// RVA: 0x5ADB60 Offset: 0x5ACD60 VA: 0x1805ADB60
	private void CheckForEndVoting() { }

	// RVA: 0x5AD610 Offset: 0x5AC810 VA: 0x1805AD610
	private Dictionary<byte, int> CalculateVotes() { }

	// RVA: 0x5AF070 Offset: 0x5AE270 VA: 0x1805AF070
	public void HandleProceed() { }

	// RVA: 0x5B0400 Offset: 0x5AF600 VA: 0x1805B0400
	private void SetupProceedButton() { }

	// RVA: 0x5AF8F0 Offset: 0x5AEAF0 VA: 0x1805AF8F0
	private void PopulateResults(MeetingHud.VoterState[] states) { }

	// RVA: 0x5AD1D0 Offset: 0x5AC3D0 VA: 0x1805AD1D0
	private void BloopAVoteIcon(NetworkedPlayerInfo voterPlayer, int index, Transform parent) { }

	// RVA: 0x5B0CA0 Offset: 0x5AFEA0 VA: 0x1805B0CA0
	private void UpdateButtons() { }

	// RVA: 0x5AF480 Offset: 0x5AE680 VA: 0x1805AF480
	private void PopulateButtons(byte reporter) { }

	// RVA: 0x5B05C0 Offset: 0x5AF7C0 VA: 0x1805B05C0
	private void SortButtons() { }

	// RVA: 0x5AE760 Offset: 0x5AD960 VA: 0x1805AE760
	private PlayerVoteArea CreateButton(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x5AEA30 Offset: 0x5ADC30 VA: 0x1805AEA30
	public bool DidVote(byte playerId) { }

	// RVA: 0x5AEBC0 Offset: 0x5ADDC0 VA: 0x1805AEBC0
	public int GetVotesRemaining() { }

	// RVA: 0x5AFCC0 Offset: 0x5AEEC0 VA: 0x1805AFCC0
	public void RpcClose() { }

	// RVA: 0x5AE270 Offset: 0x5AD470 VA: 0x1805AE270
	public void CmdCastVote(byte playerId, byte suspectIdx) { }

	// RVA: 0x5AFD80 Offset: 0x5AEF80 VA: 0x1805AFD80
	private void RpcVotingComplete(MeetingHud.VoterState[] states, NetworkedPlayerInfo exiled, bool tie) { }

	// RVA: 0x5AFC10 Offset: 0x5AEE10 VA: 0x1805AFC10
	private void RpcClearVote(int clientId) { }

	// RVA: 0x58BBA0 Offset: 0x58ADA0 VA: 0x18058BBA0 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x5B0160 Offset: 0x5AF360 VA: 0x1805B0160 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x5AE890 Offset: 0x5ADA90 VA: 0x1805AE890 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x5AF1F0 Offset: 0x5AE3F0 VA: 0x1805AF1F0 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x5B1FE0 Offset: 0x5B11E0 VA: 0x1805B1FE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingIntroAnimation.<>c__DisplayClass16_0 // TypeDefIndex: 973
{
	// Fields
	public bool someoneWasProtected; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9A80 Offset: 0x5B8C80 VA: 0x1805B9A80
	internal void <Init>b__0(PlayerControl pc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MeetingIntroAnimation.<CoRun>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 974
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MeetingIntroAnimation <>4__this; // 0x20

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

	// RVA: 0x5B7260 Offset: 0x5B6460 VA: 0x1805B7260 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B7860 Offset: 0x5B6A60 VA: 0x1805B7860 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class MeetingIntroAnimation : MonoBehaviour // TypeDefIndex: 975
{
	// Fields
	public Transform VoteButtonParent; // 0x20
	public Transform OverlayParent; // 0x28
	public Transform DeadParent; // 0x30
	public GameObject ProtectedRecently; // 0x38
	public TextMeshPro DeadBodiesText; // 0x40
	public SpriteRenderer BloodSplat; // 0x48
	public Vector3 VoteButtonParentPos; // 0x50
	public Vector3 ReporterPos; // 0x5C
	public SpriteRenderer background; // 0x68
	public AnimationCurve SlamCurve; // 0x70
	public PlayerVoteArea VoteAreaPrefab; // 0x78
	public AudioClip PlayerDeadSound; // 0x80
	public AudioClip ProtectedRecentlySound; // 0x88
	private List<PlayerVoteArea> deadCards; // 0x90
	public SpriteRenderer[] OutsideMasks; // 0x98

	// Methods

	// RVA: 0x5B2860 Offset: 0x5B1A60 VA: 0x1805B2860
	public void Start() { }

	// RVA: 0x5B2180 Offset: 0x5B1380 VA: 0x1805B2180
	public void Init(NetworkedPlayerInfo reporter, NetworkedPlayerInfo[] deadBodies) { }

	[IteratorStateMachine(typeof(MeetingIntroAnimation.<CoRun>d__17))]
	// RVA: 0x5B2120 Offset: 0x5B1320 VA: 0x1805B2120
	public IEnumerator CoRun() { }

	// RVA: 0x5B2B30 Offset: 0x5B1D30 VA: 0x1805B2B30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5B2A40 Offset: 0x5B1C40 VA: 0x1805B2A40
	private void <CoRun>b__17_0(float t) { }
}

// Namespace: 
public class MeetingRoomManager : IDisconnectHandler // TypeDefIndex: 976
{
	// Fields
	public static readonly MeetingRoomManager Instance; // 0x0
	private PlayerControl reporter; // 0x10
	private NetworkedPlayerInfo target; // 0x18

	// Properties
	public bool IsPersistent { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public bool get_IsPersistent() { }

	// RVA: 0x5B2BC0 Offset: 0x5B1DC0 VA: 0x1805B2BC0
	public void AssignSelf(PlayerControl reporter, NetworkedPlayerInfo target) { }

	// RVA: 0x5B2CE0 Offset: 0x5B1EE0 VA: 0x1805B2CE0
	public void RemoveSelf() { }

	// RVA: 0x5B2C70 Offset: 0x5B1E70 VA: 0x1805B2C70 Slot: 5
	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason) { }

	// RVA: 0x5B2C70 Offset: 0x5B1E70 VA: 0x1805B2C70 Slot: 6
	public void HandleDisconnect() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B2D50 Offset: 0x5B1F50 VA: 0x1805B2D50
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerVoteArea.<>c__DisplayClass54_0 // TypeDefIndex: 977
{
	// Fields
	public PlayerVoteArea <>4__this; // 0x10
	public float startPos; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B9B90 Offset: 0x5B8D90 VA: 0x1805B9B90
	internal void <Select>b__0(float t) { }

	// RVA: 0x5B9D40 Offset: 0x5B8F40 VA: 0x1805B9D40
	internal void <Select>b__1(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerVoteArea.<CoAnimateOverlay>d__45 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 978
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerVoteArea <>4__this; // 0x20
	private float <duration>5__2; // 0x28
	private float <time>5__3; // 0x2C

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

	// RVA: 0x5B67A0 Offset: 0x5B59A0 VA: 0x1805B67A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5B6AB0 Offset: 0x5B5CB0 VA: 0x1805B6AB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlayerVoteArea : MonoBehaviour // TypeDefIndex: 979
{
	// Fields
	[CompilerGenerated]
	private MeetingHud <Parent>k__BackingField; // 0x20
	public byte TargetPlayerId; // 0x28
	public const byte HasNotVoted = 255;
	public const byte MissedVote = 254;
	public const byte SkippedVote = 253;
	public const byte DeadVote = 252;
	public GameObject Buttons; // 0x30
	public UiElement ConfirmButton; // 0x38
	public UiElement CancelButton; // 0x40
	public UiElement PlayerButton; // 0x48
	public SpriteRenderer Background; // 0x50
	public SpriteRenderer MaskArea; // 0x58
	public SpriteRenderer Flag; // 0x60
	public SpriteRenderer Megaphone; // 0x68
	public SpriteRenderer Overlay; // 0x70
	public SpriteRenderer XMark; // 0x78
	public SpriteRenderer GAIcon; // 0x80
	public SpriteRenderer ThumbsDown; // 0x88
	public SpriteRenderer HighlightedFX; // 0x90
	public TextMeshPro NameText; // 0x98
	public TextMeshPro LevelNumberText; // 0xA0
	public TextMeshPro ColorBlindName; // 0xA8
	public bool AnimateButtonsFromLeft; // 0xB0
	public bool AmDead; // 0xB1
	public bool DidReport; // 0xB2
	public byte VotedFor; // 0xB3
	public bool voteComplete; // 0xB4
	public bool resultsShowing; // 0xB5
	[SerializeField]
	private PoolablePlayer PlayerIcon; // 0xB8
	[CompilerGenerated]
	private int <MaskLayer>k__BackingField; // 0xC0

	// Properties
	public MeetingHud Parent { get; set; }
	public bool DidVote { get; }
	public int MaskLayer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public MeetingHud get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Parent(MeetingHud value) { }

	// RVA: 0x5B5FA0 Offset: 0x5B51A0 VA: 0x1805B5FA0
	public bool get_DidVote() { }

	[CompilerGenerated]
	// RVA: 0x5B5FB0 Offset: 0x5B51B0 VA: 0x1805B5FB0
	public int get_MaskLayer() { }

	[CompilerGenerated]
	// RVA: 0x5B5FC0 Offset: 0x5B51C0 VA: 0x1805B5FC0
	private void set_MaskLayer(int value) { }

	// RVA: 0x5B5B80 Offset: 0x5B4D80 VA: 0x1805B5B80
	private void Start() { }

	// RVA: 0x5B5AD0 Offset: 0x5B4CD0 VA: 0x1805B5AD0
	public void SetTargetPlayerId(byte targetId) { }

	// RVA: 0x5B59B0 Offset: 0x5B4BB0 VA: 0x1805B59B0
	public void SetMaskLayer(int maskLayer) { }

	// RVA: 0x5B5610 Offset: 0x5B4810 VA: 0x1805B5610
	public void SetDead(bool didReport, bool isDead, bool isGuardian = False) { }

	// RVA: 0x5B56D0 Offset: 0x5B48D0 VA: 0x1805B56D0
	public void SetDisabled() { }

	// RVA: 0x5B5790 Offset: 0x5B4990 VA: 0x1805B5790
	public void SetEnabled() { }

	// RVA: 0x5B5C50 Offset: 0x5B4E50 VA: 0x1805B5C50
	public void UpdateOverlay() { }

	[IteratorStateMachine(typeof(PlayerVoteArea.<CoAnimateOverlay>d__45))]
	// RVA: 0x5B4A00 Offset: 0x5B3C00 VA: 0x1805B4A00
	public IEnumerator CoAnimateOverlay() { }

	// RVA: 0x5B5BB0 Offset: 0x5B4DB0 VA: 0x1805B5BB0
	private static float TriangleWave(float t) { }

	// RVA: 0x5B5B50 Offset: 0x5B4D50 VA: 0x1805B5B50
	internal void SetVote(byte suspectIdx) { }

	// RVA: 0x5B5C20 Offset: 0x5B4E20 VA: 0x1805B5C20
	public void UnsetVote() { }

	// RVA: 0x5B49A0 Offset: 0x5B3BA0 VA: 0x1805B49A0
	public void ClearButtons() { }

	// RVA: 0x5B49D0 Offset: 0x5B3BD0 VA: 0x1805B49D0
	public void ClearForResults() { }

	// RVA: 0x5B5DC0 Offset: 0x5B4FC0 VA: 0x1805B5DC0
	public void VoteForMe() { }

	// RVA: 0x5B5EB0 Offset: 0x5B50B0 VA: 0x1805B5EB0
	private bool canBeHighlighted() { }

	// RVA: 0x5B5850 Offset: 0x5B4A50 VA: 0x1805B5850
	public void SetHighlighted(bool value) { }

	// RVA: 0x5B4E20 Offset: 0x5B4020 VA: 0x1805B4E20
	public void Select() { }

	// RVA: 0x5B4910 Offset: 0x5B3B10 VA: 0x1805B4910
	public void Cancel() { }

	// RVA: 0x5B51E0 Offset: 0x5B43E0 VA: 0x1805B51E0
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x5B4A60 Offset: 0x5B3C60 VA: 0x1805B4A60
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x5B52F0 Offset: 0x5B44F0 VA: 0x1805B52F0
	public void SetCosmetics(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x5B4C20 Offset: 0x5B3E20 VA: 0x1805B4C20
	public void PreviewNameplate(string plateID) { }

	// RVA: 0x5B4B10 Offset: 0x5B3D10 VA: 0x1805B4B10
	private void OnDestroy() { }

	// RVA: 0x5B5230 Offset: 0x5B4430 VA: 0x1805B5230
	private void SetColorblindText() { }

	// RVA: 0x5B5EA0 Offset: 0x5B50A0 VA: 0x1805B5EA0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5B5BF0 Offset: 0x5B4DF0 VA: 0x1805B5BF0
	private void <PreviewNameplate>b__59_0(NamePlateViewData viewData) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VoteSpreader.<>c // TypeDefIndex: 980
{
	// Fields
	public static readonly VoteSpreader.<>c <>9; // 0x0
	public static Func<SpriteRenderer, bool> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x5BA0C0 Offset: 0x5B92C0 VA: 0x1805BA0C0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B93C0 Offset: 0x5B85C0 VA: 0x1805B93C0
	internal bool <Update>b__5_0(SpriteRenderer v) { }
}

// Namespace: 
public class VoteSpreader : MonoBehaviour // TypeDefIndex: 981
{
	// Fields
	public List<SpriteRenderer> Votes; // 0x20
	public FloatRange VoteRange; // 0x28
	public int maxVotesBeforeSmoosh; // 0x30
	public float CounterY; // 0x34
	public float adjustRate; // 0x38

	// Methods

	// RVA: 0x5BACE0 Offset: 0x5B9EE0 VA: 0x1805BACE0
	private void Update() { }

	// RVA: 0x5BABF0 Offset: 0x5B9DF0 VA: 0x1805BABF0
	public void AddVote(SpriteRenderer newVote) { }

	// RVA: 0x5BAFB0 Offset: 0x5BA1B0 VA: 0x1805BAFB0
	public void .ctor() { }
}

// Namespace: 
public class NameTextBehaviour : MonoBehaviour // TypeDefIndex: 982
{
	// Fields
	public static readonly HashSet<char> SymbolChars; // 0x0
	public static NameTextBehaviour Instance; // 0x8
	public TextBoxTMP nameSource; // 0x20

	// Methods

	// RVA: 0x5B30F0 Offset: 0x5B22F0 VA: 0x1805B30F0
	public void Start() { }

	// RVA: 0x5B3250 Offset: 0x5B2450 VA: 0x1805B3250
	public void UpdateName() { }

	// RVA: 0x5B2DB0 Offset: 0x5B1FB0 VA: 0x1805B2DB0
	public static bool IsValidName(string text) { }

	// RVA: 0x5B3010 Offset: 0x5B2210 VA: 0x1805B3010
	public bool ShakeIfInvalid() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x5B33A0 Offset: 0x5B25A0 VA: 0x1805B33A0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPopper.<>c__DisplayClass14_0 // TypeDefIndex: 983
{
	// Fields
	public NotificationPopper <>4__this; // 0x10
	public LobbyNotificationMessage newMessage; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B98D0 Offset: 0x5B8AD0 VA: 0x1805B98D0
	internal void <AddDisconnectMessage>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPopper.<>c__DisplayClass17_0 // TypeDefIndex: 984
{
	// Fields
	public NotificationPopper <>4__this; // 0x10
	public LobbyNotificationMessage newMessage; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5B98D0 Offset: 0x5B8AD0 VA: 0x1805B98D0
	internal void <SettingsChangeMessageLogic>b__0() { }
}

// Namespace: 
public class NotificationPopper : MonoBehaviour // TypeDefIndex: 985
{
	// Fields
	[SerializeField]
	private LobbyNotificationMessage notificationMessageOrigin; // 0x20
	[SerializeField]
	private Sprite playerDisconnectSprite; // 0x28
	[SerializeField]
	private Sprite settingsChangeSprite; // 0x30
	[SerializeField]
	private AudioClip playerDisconnectSound; // 0x38
	[SerializeField]
	private AudioClip settingsChangeSound; // 0x40
	[SerializeField]
	private float spacingY; // 0x48
	[SerializeField]
	private int maxMessages; // 0x4C
	[SerializeField]
	private Color disconnectColor; // 0x50
	[SerializeField]
	private Color settingsChangeColor; // 0x60
	[SerializeField]
	private AspectPosition aspectPosition; // 0x70
	private List<LobbyNotificationMessage> activeMessages; // 0x78
	private int lastMessageKey; // 0x80

	// Methods

	// RVA: 0x5B42D0 Offset: 0x5B34D0 VA: 0x1805B42D0
	private void Awake() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x5B35C0 Offset: 0x5B27C0 VA: 0x1805B35C0
	public void AddDisconnectMessage(string item) { }

	// RVA: 0x5B3DD0 Offset: 0x5B2FD0 VA: 0x1805B3DD0
	public void AddSettingsChangeMessage(StringNames key, string value, bool playSound = True, RoleTypes associatedRole = 0) { }

	// RVA: 0x5B39E0 Offset: 0x5B2BE0 VA: 0x1805B39E0
	public void AddRoleSettingsChangeMessage(StringNames key, int roleCount, int roleChance, RoleTeamTypes teamType, bool playSound = True) { }

	// RVA: 0x5B43A0 Offset: 0x5B35A0 VA: 0x1805B43A0
	private void SettingsChangeMessageLogic(StringNames key, string item, bool playSound) { }

	// RVA: 0x5B3870 Offset: 0x5B2A70 VA: 0x1805B3870
	private void AddMessageToQueue(LobbyNotificationMessage newMessage) { }

	// RVA: 0x5B4750 Offset: 0x5B3950 VA: 0x1805B4750
	private void ShiftMessages() { }

	// RVA: 0x5B4340 Offset: 0x5B3540 VA: 0x1805B4340
	private void OnMessageDestroy(LobbyNotificationMessage m) { }

	// RVA: 0x5B48F0 Offset: 0x5B3AF0 VA: 0x1805B48F0
	public void .ctor() { }
}

// Namespace: 
public class ButtonAnimRolloverHandler : MonoBehaviour // TypeDefIndex: 986
{
	// Fields
	public Sprite StaticOutImage; // 0x20
	public AnimationClip RolloverAnim; // 0x28
	public AudioClip HoverSound; // 0x30
	private SpriteRenderer target; // 0x38
	private SpriteAnim animTarget; // 0x40

	// Methods

	// RVA: 0x5A4470 Offset: 0x5A3670 VA: 0x1805A4470
	public void Start() { }

	// RVA: 0x5A4390 Offset: 0x5A3590 VA: 0x1805A4390
	public void DoMouseOver() { }

	// RVA: 0x5A4350 Offset: 0x5A3550 VA: 0x1805A4350
	public void DoMouseOut() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ButtonDownHandler.<CoRunDown>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 987
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ButtonDownHandler <>4__this; // 0x20

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

	// RVA: 0x5CD0C0 Offset: 0x5CC2C0 VA: 0x1805CD0C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CD1B0 Offset: 0x5CC3B0 VA: 0x1805CD1B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ButtonDownHandler : MonoBehaviour // TypeDefIndex: 988
{
	// Fields
	private Coroutine downState; // 0x20
	public SpriteRenderer Target; // 0x28
	public Sprite UpSprite; // 0x30
	public Sprite DownSprite; // 0x38

	// Methods

	// RVA: 0x5BB4A0 Offset: 0x5BA6A0 VA: 0x1805BB4A0
	public void Start() { }

	// RVA: 0x5BB3D0 Offset: 0x5BA5D0 VA: 0x1805BB3D0
	public void OnDisable() { }

	// RVA: 0x5BB420 Offset: 0x5BA620 VA: 0x1805BB420
	private void StartDown() { }

	[IteratorStateMachine(typeof(ButtonDownHandler.<CoRunDown>d__7))]
	// RVA: 0x5BB370 Offset: 0x5BA570 VA: 0x1805BB370
	private IEnumerator CoRunDown() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ButtonRolloverHandler.<WaitChangeUnselect>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 989
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ButtonRolloverHandler <>4__this; // 0x20

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

	// RVA: 0x5CF270 Offset: 0x5CE470 VA: 0x1805CF270 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CF320 Offset: 0x5CE520 VA: 0x1805CF320 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ButtonRolloverHandler : MonoBehaviour // TypeDefIndex: 990
{
	// Fields
	public SpriteRenderer Target; // 0x20
	public SpriteRenderer Target2; // 0x28
	public TextMeshPro TargetText; // 0x30
	public MeshRenderer TargetMesh; // 0x38
	public Color OverColor; // 0x40
	public Color OutColor; // 0x50
	public Color UnselectedColor; // 0x60
	public bool UseObjectsOutColor; // 0x70
	public bool UseObjectSelected; // 0x71
	public AudioClip HoverSound; // 0x78

	// Methods

	// RVA: 0x5BB550 Offset: 0x5BA750 VA: 0x1805BB550
	public void Awake() { }

	// RVA: 0x5BB990 Offset: 0x5BAB90 VA: 0x1805BB990
	public void DoMouseClick() { }

	// RVA: 0x5BBC80 Offset: 0x5BAE80 VA: 0x1805BBC80
	public void DoMouseOver() { }

	// RVA: 0x5BBAE0 Offset: 0x5BACE0 VA: 0x1805BBAE0
	public void DoMouseOut() { }

	// RVA: 0x5BBE80 Offset: 0x5BB080 VA: 0x1805BBE80
	public void SetDisabledColors() { }

	// RVA: 0x5BBED0 Offset: 0x5BB0D0 VA: 0x1805BBED0
	public void SetEnabledColors() { }

	// RVA: 0x5BB980 Offset: 0x5BAB80 VA: 0x1805BB980
	public void ChangeOutColor(Color color) { }

	// RVA: 0x5BBF90 Offset: 0x5BB190 VA: 0x1805BBF90
	public void WaitClickUnselect() { }

	[IteratorStateMachine(typeof(ButtonRolloverHandler.<WaitChangeUnselect>d__18))]
	// RVA: 0x5BBF30 Offset: 0x5BB130 VA: 0x1805BBF30
	private IEnumerator WaitChangeUnselect() { }

	// RVA: 0x5BC000 Offset: 0x5BB200 VA: 0x1805BC000
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PassiveButton.<>c__DisplayClass51_0 // TypeDefIndex: 991
{
	// Fields
	public Action cbCopy; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <AddOnClickListeners>b__0() { }
}

// Namespace: 
public class PassiveButton : PassiveUiElement // TypeDefIndex: 992
{
	// Fields
	public Button.ButtonClickedEvent OnClick; // 0x70
	public AudioClip ClickSound; // 0x78
	public AudioClip HoverSound; // 0x80
	public bool OnUp; // 0x88
	public bool OnDown; // 0x89
	public bool OnRepeat; // 0x8A
	public bool OnUpGraphic; // 0x8B
	public bool OnDownGraphic; // 0x8C
	public float RepeatDuration; // 0x90
	[Header("Hold to Use")]
	public SpriteRenderer HeldButtonSprite; // 0x98
	public ActionButton TargetActionButton; // 0xA0
	public bool HoldToUse; // 0xA8
	private bool beingHeldDown; // 0xA9
	private float repeatTimer; // 0xAC
	private float totalHeldTime; // 0xB0
	private bool checkedClickEvent; // 0xB4
	private bool selected; // 0xB5
	[Header("States")]
	[SerializeField]
	private GameObject selectedSprites; // 0xB8
	[SerializeField]
	private GameObject activeSprites; // 0xC0
	[SerializeField]
	private GameObject inactiveSprites; // 0xC8
	[SerializeField]
	private GameObject disabledSprites; // 0xD0
	[SerializeField]
	private GameObject selectedInactiveSprites; // 0xD8
	[SerializeField]
	private GameObject onClickSprites; // 0xE0
	[SerializeField]
	private bool forceInactiveSpritesMobile; // 0xE8
	[Space(10)]
	[SerializeField]
	private TextMeshPro buttonText; // 0xF0
	[SerializeField]
	private Color selectedTextColor; // 0xF8
	[SerializeField]
	private Color activeTextColor; // 0x108
	[SerializeField]
	private Color inactiveTextColor; // 0x118
	[SerializeField]
	private Color disabledTextColor; // 0x128
	[SerializeField]
	private Color selectedInactiveTextColor; // 0x138
	private static readonly int STENCIL_COMP; // 0x0
	private static readonly int STENCIL; // 0x4

	// Properties
	public override bool HandleUp { get; }
	public override bool HandleDown { get; }
	public override bool HandleRepeat { get; }
	public override bool HandleUpClickGraphic { get; }
	public override bool HandleDownClickGraphic { get; }

	// Methods

	// RVA: 0x5C3440 Offset: 0x5C2640 VA: 0x1805C3440 Slot: 6
	public override bool get_HandleUp() { }

	// RVA: 0x5C3410 Offset: 0x5C2610 VA: 0x1805C3410 Slot: 7
	public override bool get_HandleDown() { }

	// RVA: 0x5C3420 Offset: 0x5C2620 VA: 0x1805C3420 Slot: 8
	public override bool get_HandleRepeat() { }

	// RVA: 0x5C3430 Offset: 0x5C2630 VA: 0x1805C3430 Slot: 9
	public override bool get_HandleUpClickGraphic() { }

	// RVA: 0x5C3400 Offset: 0x5C2600 VA: 0x1805C3400 Slot: 10
	public override bool get_HandleDownClickGraphic() { }

	// RVA: 0x5C1D80 Offset: 0x5C0F80 VA: 0x1805C1D80
	private void Awake() { }

	// RVA: 0x5C30D0 Offset: 0x5C22D0 VA: 0x1805C30D0 Slot: 14
	protected override void Start() { }

	// RVA: 0x5C31D0 Offset: 0x5C23D0 VA: 0x1805C31D0 Slot: 15
	protected override void Update() { }

	// RVA: 0x5C1D80 Offset: 0x5C0F80 VA: 0x1805C1D80
	private void OnDisable() { }

	// RVA: 0x5C1E40 Offset: 0x5C1040 VA: 0x1805C1E40 Slot: 13
	protected override void OnEnable() { }

	// RVA: 0x5C2000 Offset: 0x5C1200 VA: 0x1805C2000 Slot: 18
	public override void ReceiveClickDown() { }

	// RVA: 0x5C2270 Offset: 0x5C1470 VA: 0x1805C2270 Slot: 19
	public override void ReceiveRepeatDown() { }

	// RVA: 0x5C2100 Offset: 0x5C1300 VA: 0x1805C2100 Slot: 20
	public override void ReceiveClickUp() { }

	// RVA: 0x5C2650 Offset: 0x5C1850 VA: 0x1805C2650
	public void SetButtonEnableState(bool enabled) { }

	// RVA: 0x5C1C50 Offset: 0x5C0E50 VA: 0x1805C1C50
	public void AddOnClickListeners(Action[] callbacks) { }

	// RVA: 0x5C2410 Offset: 0x5C1610 VA: 0x1805C2410 Slot: 21
	public override void ReleaseButton() { }

	// RVA: 0x5C2140 Offset: 0x5C1340 VA: 0x1805C2140 Slot: 4
	public override void ReceiveMouseOut() { }

	// RVA: 0x5C2180 Offset: 0x5C1380 VA: 0x1805C2180 Slot: 5
	public override void ReceiveMouseOver() { }

	// RVA: 0x5C20F0 Offset: 0x5C12F0 VA: 0x1805C20F0 Slot: 23
	public override void ReceiveClickUpGraphic() { }

	// RVA: 0x5C1FF0 Offset: 0x5C11F0 VA: 0x1805C1FF0 Slot: 24
	public override void ReceiveClickDownGraphic() { }

	// RVA: 0x5C28E0 Offset: 0x5C1AE0 VA: 0x1805C28E0
	private void SetPassiveButtonClickState(bool clicked) { }

	// RVA: 0x5C2B80 Offset: 0x5C1D80 VA: 0x1805C2B80
	public void SetPassiveButtonHoverStateActive() { }

	// RVA: 0x5C2E10 Offset: 0x5C2010 VA: 0x1805C2E10
	public void SetPassiveButtonHoverStateInactive() { }

	// RVA: 0x5C2980 Offset: 0x5C1B80 VA: 0x1805C2980
	private void SetPassiveButtonDisabledState() { }

	// RVA: 0x5C2420 Offset: 0x5C1620 VA: 0x1805C2420
	public void SelectButton(bool isSelected) { }

	// RVA: 0x5C1D90 Offset: 0x5C0F90 VA: 0x1805C1D90
	public void ChangeButtonText(string s) { }

	// RVA: 0x5C1E30 Offset: 0x5C1030 VA: 0x1805C1E30
	public bool IsSelected() { }

	// RVA: 0x5C2790 Offset: 0x5C1990 VA: 0x1805C2790
	public void SetMaskLayer(int maskID) { }

	// RVA: 0x5C3360 Offset: 0x5C2560 VA: 0x1805C3360
	public void .ctor() { }

	// RVA: 0x5C32E0 Offset: 0x5C24E0 VA: 0x1805C32E0
	private static void .cctor() { }
}

// Namespace: 
private enum PassiveButtonManager.ButtonStates // TypeDefIndex: 993
{
	// Fields
	public int value__; // 0x0
	public const PassiveButtonManager.ButtonStates Up = 0;
	public const PassiveButtonManager.ButtonStates Down = 1;
	public const PassiveButtonManager.ButtonStates Drag = 2;
}

// Namespace: 
private class PassiveButtonManager.DepthComparer : IComparer<PassiveUiElement> // TypeDefIndex: 994
{
	// Fields
	public static readonly PassiveButtonManager.DepthComparer Instance; // 0x0

	// Methods

	// RVA: 0x5BF210 Offset: 0x5BE410 VA: 0x1805BF210 Slot: 4
	public int Compare(PassiveUiElement x, PassiveUiElement y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5BF2E0 Offset: 0x5BE4E0 VA: 0x1805BF2E0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PassiveButtonManager.<>c__DisplayClass11_0 // TypeDefIndex: 995
{
	// Fields
	public Collider2D col; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEBF0 Offset: 0x5CDDF0 VA: 0x1805CEBF0
	internal bool <Update>b__0(PassiveUiElement b2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PassiveButtonManager.<>c__DisplayClass12_0 // TypeDefIndex: 996
{
	// Fields
	public Vector2 pt; // 0x10
	public Func<Collider2D, bool> <>9__1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CECB0 Offset: 0x5CDEB0 VA: 0x1805CECB0
	internal bool <HandleFocus>b__1(Collider2D c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PassiveButtonManager.<>c__DisplayClass12_1 // TypeDefIndex: 997
{
	// Fields
	public float depth; // 0x10
	public PassiveButtonManager.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CECF0 Offset: 0x5CDEF0 VA: 0x1805CECF0
	internal bool <HandleFocus>b__0(PassiveUiElement top) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PassiveButtonManager.<>c__DisplayClass14_0 // TypeDefIndex: 998
{
	// Fields
	public Controller.TouchState pt; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEE10 Offset: 0x5CE010 VA: 0x1805CEE10
	internal bool <HandleMouseOut>b__0(Collider2D c) { }
}

// Namespace: 
public class PassiveButtonManager : DestroyableSingleton<PassiveButtonManager> // TypeDefIndex: 999
{
	// Fields
	public List<PassiveUiElement> Buttons; // 0x28
	private List<IFocusHolder> FocusHolders; // 0x30
	private PassiveUiElement currentOver; // 0x38
	public Controller controller; // 0x40
	private PassiveButtonManager.ButtonStates currentState; // 0x48
	private Collider2D[] results; // 0x50

	// Methods

	// RVA: 0x5C0E70 Offset: 0x5C0070 VA: 0x1805C0E70
	public void RegisterOne(PassiveUiElement button) { }

	// RVA: 0x5C0FB0 Offset: 0x5C01B0 VA: 0x1805C0FB0
	public void RemoveOne(PassiveUiElement passiveButton) { }

	// RVA: 0x5C0F10 Offset: 0x5C0110 VA: 0x1805C0F10
	public void RegisterOne(IFocusHolder focusHolder) { }

	// RVA: 0x5C1010 Offset: 0x5C0210 VA: 0x1805C1010
	public void RemoveOne(IFocusHolder focusHolder) { }

	// RVA: 0x5C1070 Offset: 0x5C0270 VA: 0x1805C1070
	public void Update() { }

	// RVA: 0x5C03D0 Offset: 0x5BF5D0 VA: 0x1805C03D0
	private void HandleFocus(Vector2 pt) { }

	// RVA: 0x5C0D40 Offset: 0x5BFF40 VA: 0x1805C0D40
	public void LoseFocusForAll() { }

	// RVA: 0x5C0850 Offset: 0x5BFA50 VA: 0x1805C0850
	private void HandleMouseOut() { }

	// RVA: 0x5C0A10 Offset: 0x5BFC10 VA: 0x1805C0A10
	private void HandleMouseOver(PassiveUiElement button, Collider2D col) { }

	// RVA: 0x5C02D0 Offset: 0x5BF4D0 VA: 0x1805C02D0
	private Vector2 GetTouch(bool getDownTouch) { }

	// RVA: 0x5C1B50 Offset: 0x5C0D50 VA: 0x1805C1B50
	public void .ctor() { }
}

// Namespace: 
public abstract class PassiveUiElement : UiElement // TypeDefIndex: 1000
{
	// Fields
	public Collider2D ClickMask; // 0x58
	public Collider2D[] Colliders; // 0x60
	[CompilerGenerated]
	private float <CachedZ>k__BackingField; // 0x68

	// Properties
	public virtual bool HandleUp { get; }
	public virtual bool HandleDown { get; }
	public virtual bool HandleRepeat { get; }
	public virtual bool HandleUpClickGraphic { get; }
	public virtual bool HandleDownClickGraphic { get; }
	public virtual bool HandleDrag { get; }
	public virtual bool HandleOverOut { get; }
	public float CachedZ { get; set; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public virtual bool get_HandleUp() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public virtual bool get_HandleDown() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public virtual bool get_HandleRepeat() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	public virtual bool get_HandleUpClickGraphic() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public virtual bool get_HandleDownClickGraphic() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public virtual bool get_HandleDrag() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 12
	public virtual bool get_HandleOverOut() { }

	[CompilerGenerated]
	// RVA: 0x526CE0 Offset: 0x525EE0 VA: 0x180526CE0
	public float get_CachedZ() { }

	[CompilerGenerated]
	// RVA: 0x526DE0 Offset: 0x525FE0 VA: 0x180526DE0
	public void set_CachedZ(float value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	protected virtual void OnEnable() { }

	// RVA: 0x5C30D0 Offset: 0x5C22D0 VA: 0x1805C30D0 Slot: 14
	protected virtual void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	protected virtual void Update() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	protected virtual void OnDisable() { }

	// RVA: 0x5C3450 Offset: 0x5C2650 VA: 0x1805C3450 Slot: 17
	protected virtual void OnDestroy() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	public virtual void ReceiveClickDown() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public virtual void ReceiveRepeatDown() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	public virtual void ReceiveClickUp() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public virtual void ReleaseButton() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public virtual void ReceiveClickDrag(Vector2 dragDelta) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	public virtual void ReceiveClickUpGraphic() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	public virtual void ReceiveClickDownGraphic() { }

	// RVA: 0x5C34F0 Offset: 0x5C26F0 VA: 0x1805C34F0
	protected void .ctor() { }
}

// Namespace: 
public class Scrollbar : PassiveUiElement // TypeDefIndex: 1001
{
	// Fields
	[SerializeField]
	private Scroller parent; // 0x70
	[SerializeField]
	private SpriteRenderer graphic; // 0x78
	[SerializeField]
	private SpriteRenderer trackGraphic; // 0x80
	[SerializeField]
	private bool horizontal; // 0x88
	[SerializeField]
	private float dragSpeed; // 0x8C
	private bool dragable; // 0x90

	// Properties
	public override bool HandleDrag { get; }

	// Methods

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0 Slot: 11
	public override bool get_HandleDrag() { }

	// RVA: 0x5C4CA0 Offset: 0x5C3EA0 VA: 0x1805C4CA0
	public void Toggle(bool on) { }

	// RVA: 0x5C4D50 Offset: 0x5C3F50 VA: 0x1805C4D50
	public void UpdatePosition(Vector3 position) { }

	// RVA: 0x5C4A30 Offset: 0x5C3C30 VA: 0x1805C4A30 Slot: 22
	public override void ReceiveClickDrag(Vector2 dragDelta) { }

	// RVA: 0x5C4DA0 Offset: 0x5C3FA0 VA: 0x1805C4DA0
	public void .ctor() { }
}

// Namespace: 
public sealed class Scroller.ScrollHandler : MulticastDelegate // TypeDefIndex: 1002
{
	// Methods

	// RVA: 0x5C4990 Offset: 0x5C3B90 VA: 0x1805C4990
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(float value) { }

	// RVA: 0x5C4910 Offset: 0x5C3B10 VA: 0x1805C4910 Slot: 14
	public virtual IAsyncResult BeginInvoke(float value, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class Scroller : PassiveUiElement // TypeDefIndex: 1003
{
	// Fields
	public Transform Inner; // 0x70
	public bool allowY; // 0x78
	public bool showY; // 0x79
	[FormerlySerializedAs("YBounds")]
	[SerializeField]
	private FloatRange ContentYBounds; // 0x80
	[FormerlySerializedAs("ScrollerYRange")]
	public FloatRange ScrollbarYBounds; // 0x88
	[FormerlySerializedAs("ScrollerY")]
	public Scrollbar ScrollbarY; // 0x90
	public bool allowX; // 0x98
	public bool showX; // 0x99
	[FormerlySerializedAs("XBounds")]
	[SerializeField]
	private FloatRange ContentXBounds; // 0xA0
	[FormerlySerializedAs("ScrollerXRange")]
	public FloatRange ScrollbarXBounds; // 0xA8
	[FormerlySerializedAs("ScrollerX")]
	public Scrollbar ScrollbarX; // 0xB0
	public float DragScrollSpeed; // 0xB8
	public float ScrollWheelSpeed; // 0xBC
	public bool MouseMustBeOverToScroll; // 0xC0
	private Vector2 velocity; // 0xC4
	private bool active; // 0xCC
	private bool mouseOver; // 0xCD
	public Scroller.ScrollHandler OnScrollXEvent; // 0xD0
	public Scroller.ScrollHandler OnScrollYEvent; // 0xD8

	// Properties
	public override bool HandleUp { get; }
	public override bool HandleDown { get; }
	public override bool HandleDrag { get; }
	public override bool HandleOverOut { get; }
	public bool AtTop { get; }
	public bool AtBottom { get; }
	public bool AtLeft { get; }
	public bool AtRight { get; }
	public Collider2D Hitbox { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public override bool get_HandleUp() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_HandleDown() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool get_HandleDrag() { }

	// RVA: 0x5C6220 Offset: 0x5C5420 VA: 0x1805C6220 Slot: 12
	public override bool get_HandleOverOut() { }

	// RVA: 0x5C61D0 Offset: 0x5C53D0 VA: 0x1805C61D0
	public bool get_AtTop() { }

	// RVA: 0x5C60E0 Offset: 0x5C52E0 VA: 0x1805C60E0
	public bool get_AtBottom() { }

	// RVA: 0x5C6130 Offset: 0x5C5330 VA: 0x1805C6130
	public bool get_AtLeft() { }

	// RVA: 0x5C6180 Offset: 0x5C5380 VA: 0x1805C6180
	public bool get_AtRight() { }

	// RVA: 0x5C6230 Offset: 0x5C5430 VA: 0x1805C6230
	public Collider2D get_Hitbox() { }

	// RVA: 0x5C5850 Offset: 0x5C4A50 VA: 0x1805C5850
	public void SetBounds(FloatRange yBounds, FloatRange xBounds) { }

	// RVA: 0x5C4DF0 Offset: 0x5C3FF0 VA: 0x1805C4DF0
	public void CalculateAndSetYBounds(float amount, float numPerRow, float numRowsVisible, float spacing) { }

	// RVA: 0x5C57D0 Offset: 0x5C49D0 VA: 0x1805C57D0
	public void SetBoundsMax(float yMax, float xMax) { }

	// RVA: 0x5C5870 Offset: 0x5C4A70 VA: 0x1805C5870
	public void SetYBoundsMax(float yMax) { }

	// RVA: 0x5C5810 Offset: 0x5C4A10 VA: 0x1805C5810
	public void SetBoundsMin(float yMin, float xMin) { }

	// RVA: 0x5C58A0 Offset: 0x5C4AA0 VA: 0x1805C58A0
	public void SetYBoundsMin(float yMin) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public FloatRange GetYBounds() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public FloatRange GetXBounds() { }

	// RVA: 0x5C5D90 Offset: 0x5C4F90 VA: 0x1805C5D90 Slot: 15
	protected override void Update() { }

	// RVA: 0x5C5060 Offset: 0x5C4260 VA: 0x1805C5060
	public void ScrollDown() { }

	// RVA: 0x5C5710 Offset: 0x5C4910 VA: 0x1805C5710
	public void ScrollUp() { }

	// RVA: 0x5C4F30 Offset: 0x5C4130 VA: 0x1805C4F30
	public float GetScrollPercY() { }

	// RVA: 0x5C4EA0 Offset: 0x5C40A0 VA: 0x1805C4EA0
	public float GetScrollPercX() { }

	// RVA: 0x5C51E0 Offset: 0x5C43E0 VA: 0x1805C51E0
	public void ScrollPercentY(float p) { }

	// RVA: 0x5C5120 Offset: 0x5C4320 VA: 0x1805C5120
	public void ScrollPercentX(float p) { }

	// RVA: 0x5C4FD0 Offset: 0x5C41D0 VA: 0x1805C4FD0 Slot: 18
	public override void ReceiveClickDown() { }

	// RVA: 0x5C5050 Offset: 0x5C4250 VA: 0x1805C5050 Slot: 20
	public override void ReceiveClickUp() { }

	// RVA: 0x5C4FE0 Offset: 0x5C41E0 VA: 0x1805C4FE0 Slot: 22
	public override void ReceiveClickDrag(Vector2 dragDelta) { }

	// RVA: 0x5C5510 Offset: 0x5C4710 VA: 0x1805C5510
	public void ScrollToScrollbarPositionY(Vector3 newScrollbarPosition) { }

	// RVA: 0x5C5410 Offset: 0x5C4610 VA: 0x1805C5410
	public void ScrollToScrollbarPositionX(Vector3 newScrollbarPosition) { }

	// RVA: 0x5C52A0 Offset: 0x5C44A0 VA: 0x1805C52A0
	public void ScrollRelative(Vector2 dragDelta) { }

	// RVA: 0x5C58D0 Offset: 0x5C4AD0 VA: 0x1805C58D0
	public void UpdateScrollBars() { }

	// RVA: 0x5C5620 Offset: 0x5C4820 VA: 0x1805C5620
	public void ScrollToTop() { }

	// RVA: 0x5C6000 Offset: 0x5C5200 VA: 0x1805C6000
	public void .ctor() { }
}

// Namespace: 
public class TextRolloverHandler : MonoBehaviour // TypeDefIndex: 1004
{
	// Fields
	public TextMeshPro Target; // 0x20
	public Color OverColor; // 0x28
	public Color OverOutlineColor; // 0x38
	public Color OutColor; // 0x48
	public Color OutOutlineColor; // 0x58

	// Methods

	// RVA: 0x5CB510 Offset: 0x5CA710 VA: 0x1805CB510
	public void Start() { }

	// RVA: 0x5CB490 Offset: 0x5CA690 VA: 0x1805CB490
	public void DoMouseOver() { }

	// RVA: 0x5CB410 Offset: 0x5CA610 VA: 0x1805CB410
	public void DoMouseOut() { }

	// RVA: 0x5CB620 Offset: 0x5CA820 VA: 0x1805CB620
	public void .ctor() { }
}

// Namespace: 
public abstract class UiElement : MonoBehaviour // TypeDefIndex: 1005
{
	// Fields
	public UnityEvent OnMouseOver; // 0x20
	public UnityEvent OnMouseOut; // 0x28
	public ControllerNavigation ControllerNav; // 0x30

	// Methods

	// RVA: 0x5CF460 Offset: 0x5CE660 VA: 0x1805CF460 Slot: 4
	public virtual void ReceiveMouseOut() { }

	// RVA: 0x5CF480 Offset: 0x5CE680 VA: 0x1805CF480 Slot: 5
	public virtual void ReceiveMouseOver() { }

	// RVA: 0x5C34F0 Offset: 0x5C26F0 VA: 0x1805C34F0
	protected void .ctor() { }
}

// Namespace: 
public class PauseTimeoutTimer : MonoBehaviour // TypeDefIndex: 1006
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum TaskBarMode // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const TaskBarMode Normal = 0;
	public const TaskBarMode MeetingOnly = 1;
	public const TaskBarMode Invisible = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProgressTracker.<>c // TypeDefIndex: 1008
{
	// Fields
	public static readonly ProgressTracker.<>c <>9; // 0x0
	public static Func<NetworkedPlayerInfo, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x5CF090 Offset: 0x5CE290 VA: 0x1805CF090
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEA00 Offset: 0x5CDC00 VA: 0x1805CEA00
	internal bool <FixedUpdate>b__3_0(NetworkedPlayerInfo p) { }
}

// Namespace: 
public class ProgressTracker : MonoBehaviour // TypeDefIndex: 1009
{
	// Fields
	public MeshRenderer TileParent; // 0x20
	private float curValue; // 0x28

	// Methods

	// RVA: 0x5C3AA0 Offset: 0x5C2CA0 VA: 0x1805C3AA0
	public void Start() { }

	// RVA: 0x5C3670 Offset: 0x5C2870 VA: 0x1805C3670
	public void FixedUpdate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ReportNotification : MonoBehaviour // TypeDefIndex: 1010
{
	// Fields
	private float timeOnScreen; // 0x20

	// Methods

	// RVA: 0x5C3BA0 Offset: 0x5C2DA0 VA: 0x1805C3BA0
	private void Awake() { }

	// RVA: 0x5C3C10 Offset: 0x5C2E10 VA: 0x1805C3C10
	private void Update() { }

	// RVA: 0x5C3BB0 Offset: 0x5C2DB0 VA: 0x1805C3BB0
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoomTracker.<CoSlideIn>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1011
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomTracker <>4__this; // 0x20
	public SystemTypes newRoom; // 0x28
	private Vector3 <tempPos>5__2; // 0x2C
	private Color <tempColor>5__3; // 0x38
	private float <timer>5__4; // 0x48

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

	// RVA: 0x5CD4E0 Offset: 0x5CC6E0 VA: 0x1805CD4E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CD770 Offset: 0x5CC970 VA: 0x1805CD770 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoomTracker.<SlideOut>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1012
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomTracker <>4__this; // 0x20
	private Vector3 <tempPos>5__2; // 0x28
	private Color <tempColor>5__3; // 0x34
	private float <timer>5__4; // 0x44

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

	// RVA: 0x5CE6F0 Offset: 0x5CD8F0 VA: 0x1805CE6F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CE900 Offset: 0x5CDB00 VA: 0x1805CE900 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class RoomTracker : MonoBehaviour // TypeDefIndex: 1013
{
	// Fields
	public static RoomTracker Instance; // 0x0
	public TextMeshPro text; // 0x20
	public float SourceY; // 0x28
	public float TargetY; // 0x2C
	private Collider2D playerCollider; // 0x30
	private ContactFilter2D filter; // 0x38
	private Collider2D[] buffer; // 0x58
	private Collider2D[] detectiveBuffer; // 0x60
	public PlainShipRoom LastRoom; // 0x68
	private Coroutine slideInRoutine; // 0x70

	// Methods

	// RVA: 0x5C3C90 Offset: 0x5C2E90 VA: 0x1805C3C90
	public void Awake() { }

	// RVA: 0x5C47A0 Offset: 0x5C39A0 VA: 0x1805C47A0
	public void OnDisable() { }

	// RVA: 0x5C3FA0 Offset: 0x5C31A0 VA: 0x1805C3FA0
	public void FixedUpdate() { }

	[IteratorStateMachine(typeof(RoomTracker.<CoSlideIn>d__13))]
	// RVA: 0x5C3F30 Offset: 0x5C3130 VA: 0x1805C3F30
	private IEnumerator CoSlideIn(SystemTypes newRoom) { }

	[IteratorStateMachine(typeof(RoomTracker.<SlideOut>d__14))]
	// RVA: 0x5C4840 Offset: 0x5C3A40 VA: 0x1805C4840
	private IEnumerator SlideOut() { }

	// RVA: 0x5C3D70 Offset: 0x5C2F70 VA: 0x1805C3D70
	private static bool CheckHitsForPlayer(Collider2D[] buffer, int hitCount, PlayerControl playerToCheck) { }

	// RVA: 0x5C43A0 Offset: 0x5C35A0 VA: 0x1805C43A0
	public string GetRoomForPlayer(NetworkedPlayerInfo player) { }

	// RVA: 0x5C48A0 Offset: 0x5C3AA0 VA: 0x1805C48A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscussBehaviour.<AnimateText>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1014
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DiscussBehaviour <>4__this; // 0x20
	private Vector3 <vec>5__2; // 0x28
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

	// RVA: 0x5CCBA0 Offset: 0x5CBDA0 VA: 0x1805CCBA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CCCD0 Offset: 0x5CBED0 VA: 0x1805CCCD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscussBehaviour.<PlayAnimation>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1015
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DiscussBehaviour <>4__this; // 0x20

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

	// RVA: 0x5CD7B0 Offset: 0x5CC9B0 VA: 0x1805CD7B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CD8E0 Offset: 0x5CCAE0 VA: 0x1805CD8E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class DiscussBehaviour : MonoBehaviour // TypeDefIndex: 1016
{
	// Fields
	public SpriteRenderer LeftPlayer; // 0x20
	public SpriteRenderer RightPlayer; // 0x28
	public TextMeshPro Text; // 0x30
	public FloatRange RotateRange; // 0x38
	public Vector2Range TextTarget; // 0x40
	public AnimationCurve TextEasing; // 0x50
	public float Delay; // 0x58
	public float TextDuration; // 0x5C
	public float HoldDuration; // 0x60
	private Vector3 vec; // 0x64

	// Methods

	[IteratorStateMachine(typeof(DiscussBehaviour.<PlayAnimation>d__10))]
	// RVA: 0x5BF3A0 Offset: 0x5BE5A0 VA: 0x1805BF3A0
	public IEnumerator PlayAnimation() { }

	// RVA: 0x5BF480 Offset: 0x5BE680 VA: 0x1805BF480
	public void Update() { }

	[IteratorStateMachine(typeof(DiscussBehaviour.<AnimateText>d__12))]
	// RVA: 0x5BF340 Offset: 0x5BE540 VA: 0x1805BF340
	private IEnumerator AnimateText() { }

	// RVA: 0x5BF400 Offset: 0x5BE600 VA: 0x1805BF400
	private void UpdateText(ref Vector3 vec, float p) { }

	// RVA: 0x5BF5B0 Offset: 0x5BE7B0 VA: 0x1805BF5B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShhhBehaviour.<AnimateHand>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1017
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ShhhBehaviour <>4__this; // 0x20
	private Vector3 <vec>5__2; // 0x28
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

	// RVA: 0x5CC630 Offset: 0x5CB830 VA: 0x1805CC630 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CC740 Offset: 0x5CB940 VA: 0x1805CC740 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShhhBehaviour.<AnimateText>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1018
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ShhhBehaviour <>4__this; // 0x20
	private Vector3 <vec>5__2; // 0x28
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

	// RVA: 0x5CCD10 Offset: 0x5CBF10 VA: 0x1805CCD10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CD080 Offset: 0x5CC280 VA: 0x1805CD080 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShhhBehaviour.<PlayAnimation>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1019
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ShhhBehaviour <>4__this; // 0x20

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

	// RVA: 0x5CD920 Offset: 0x5CCB20 VA: 0x1805CD920 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CDA60 Offset: 0x5CCC60 VA: 0x1805CDA60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ShhhBehaviour.<WaitWithInterrupt>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1020
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float duration; // 0x20
	private float <timer>5__2; // 0x24

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

	// RVA: 0x5CF3A0 Offset: 0x5CE5A0 VA: 0x1805CF3A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CF420 Offset: 0x5CE620 VA: 0x1805CF420 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ShhhBehaviour : MonoBehaviour // TypeDefIndex: 1021
{
	// Fields
	public SpriteRenderer Background; // 0x20
	public SpriteRenderer Body; // 0x28
	public SpriteRenderer Hand; // 0x30
	public TextMeshPro TextImage; // 0x38
	public float RotateSpeed; // 0x40
	public Vector2Range HandTarget; // 0x44
	public AnimationCurve PositionEasing; // 0x58
	public FloatRange HandRotate; // 0x60
	public AnimationCurve RotationEasing; // 0x68
	public Vector2Range TextTarget; // 0x70
	public AnimationCurve TextEasing; // 0x80
	public float Duration; // 0x88
	public float Delay; // 0x8C
	public float TextDuration; // 0x90
	public float PulseDuration; // 0x94
	public float PulseSize; // 0x98
	public float HoldDuration; // 0x9C
	public bool Autoplay; // 0xA0

	// Methods

	// RVA: 0x5C81E0 Offset: 0x5C73E0 VA: 0x1805C81E0
	public void OnEnable() { }

	[IteratorStateMachine(typeof(ShhhBehaviour.<PlayAnimation>d__19))]
	// RVA: 0x5C8310 Offset: 0x5C7510 VA: 0x1805C8310
	public IEnumerator PlayAnimation() { }

	// RVA: 0x5C8510 Offset: 0x5C7710 VA: 0x1805C8510
	public void Update() { }

	[IteratorStateMachine(typeof(ShhhBehaviour.<AnimateText>d__21))]
	// RVA: 0x5C8170 Offset: 0x5C7370 VA: 0x1805C8170
	private IEnumerator AnimateText() { }

	[IteratorStateMachine(typeof(ShhhBehaviour.<AnimateHand>d__22))]
	// RVA: 0x5C8110 Offset: 0x5C7310 VA: 0x1805C8110
	private IEnumerator AnimateHand() { }

	// RVA: 0x5C8370 Offset: 0x5C7570 VA: 0x1805C8370
	private void UpdateHand(ref Vector3 vec, float p) { }

	// RVA: 0x5C8490 Offset: 0x5C7690 VA: 0x1805C8490
	private void UpdateText(ref Vector3 vec, float p) { }

	[IteratorStateMachine(typeof(ShhhBehaviour.<WaitWithInterrupt>d__25))]
	// RVA: 0x5C8570 Offset: 0x5C7770 VA: 0x1805C8570
	public static IEnumerator WaitWithInterrupt(float duration) { }

	// RVA: 0x5C81D0 Offset: 0x5C73D0 VA: 0x1805C81D0
	public static bool CheckForInterrupt() { }

	// RVA: 0x5C85D0 Offset: 0x5C77D0 VA: 0x1805C85D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SlideOpen.<AnimateClose>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1022
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SlideOpen <>4__this; // 0x20
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

	// RVA: 0x5CC210 Offset: 0x5CB410 VA: 0x1805CC210 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CC410 Offset: 0x5CB610 VA: 0x1805CC410 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SlideOpen.<AnimateOpen>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1023
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SlideOpen <>4__this; // 0x20
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

	// RVA: 0x5CC780 Offset: 0x5CB980 VA: 0x1805CC780 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CC980 Offset: 0x5CBB80 VA: 0x1805CC980 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SlideOpen : MonoBehaviour // TypeDefIndex: 1024
{
	// Fields
	public float duration; // 0x20
	public Button.ButtonClickedEvent OnClose; // 0x28
	public Camera parentCam; // 0x30
	public Vector3 openPosition; // 0x38
	public Vector3 closedPosition; // 0x44
	public bool isOpen; // 0x50
	[SerializeField]
	private GameObject subMenu; // 0x58
	private Vector3 computedClosedPosition; // 0x60

	// Methods

	// RVA: 0x5C87F0 Offset: 0x5C79F0 VA: 0x1805C87F0
	public void Awake() { }

	// RVA: 0x5C8B10 Offset: 0x5C7D10 VA: 0x1805C8B10
	public void Toggle() { }

	// RVA: 0x5C88F0 Offset: 0x5C7AF0 VA: 0x1805C88F0
	public void Close() { }

	// RVA: 0x5C8A50 Offset: 0x5C7C50 VA: 0x1805C8A50
	public void Open() { }

	// RVA: 0x5C8620 Offset: 0x5C7820 VA: 0x1805C8620
	private void AdjustPosition(float aspect) { }

	[IteratorStateMachine(typeof(SlideOpen.<AnimateClose>d__13))]
	// RVA: 0x5C8730 Offset: 0x5C7930 VA: 0x1805C8730
	private IEnumerator AnimateClose() { }

	[IteratorStateMachine(typeof(SlideOpen.<AnimateOpen>d__14))]
	// RVA: 0x5C8790 Offset: 0x5C7990 VA: 0x1805C8790
	private IEnumerator AnimateOpen() { }

	// RVA: 0x5C8AC0 Offset: 0x5C7CC0 VA: 0x1805C8AC0
	private void SetPositionVector(Vector3 pos) { }

	// RVA: 0x5C89D0 Offset: 0x5C7BD0 VA: 0x1805C89D0
	private void OnEnable() { }

	// RVA: 0x5C8960 Offset: 0x5C7B60 VA: 0x1805C8960
	private void OnDisable() { }

	// RVA: 0x5C8A40 Offset: 0x5C7C40 VA: 0x1805C8A40
	private void OnResolutionChanged(float aspectRatio, int width, int height, bool fullscreen) { }

	// RVA: 0x5C8BB0 Offset: 0x5C7DB0 VA: 0x1805C8BB0
	public void .ctor() { }
}

// Namespace: 
public class TextBoxTMP : MonoBehaviour, IFocusHolder // TypeDefIndex: 1025
{
	// Fields
	public static readonly HashSet<char> SymbolChars; // 0x0
	public static readonly HashSet<char> EmailChars; // 0x8
	public const char HiddenChar = '\x2a';
	public bool allowAllCharacters; // 0x20
	public string text; // 0x28
	private string compoText; // 0x30
	public int characterLimit; // 0x38
	[SerializeField]
	public TextMeshPro outputText; // 0x40
	public SpriteRenderer Background; // 0x48
	public MeshRenderer Pipe; // 0x50
	[SerializeField]
	private TextMeshPro placeholderText; // 0x58
	private float pipeBlinkTimer; // 0x60
	public bool ClearOnFocus; // 0x64
	public bool ForceUppercase; // 0x65
	public Button.ButtonClickedEvent OnEnter; // 0x68
	public Button.ButtonClickedEvent OnChange; // 0x70
	public Button.ButtonClickedEvent OnFocusLost; // 0x78
	private TouchScreenKeyboard keyboard; // 0x80
	public bool AllowSymbols; // 0x88
	public bool AllowEmail; // 0x89
	public bool IpMode; // 0x8A
	public bool AllowPaste; // 0x8B
	public bool Hidden; // 0x8C
	private Collider2D[] colliders; // 0x90
	private bool hasFocus; // 0x98
	private int caretPos; // 0x9C
	private float caretRepeatTimer; // 0xA0
	public float caretYOffset; // 0xA4
	public Color colorBackground; // 0xA8
	private StringBuilder tempTxt; // 0xB8
	public SpriteRenderer sendButtonGlyph; // 0xC0
	public bool SendOnFullChars; // 0xC8

	// Properties
	public float TextHeight { get; }

	// Methods

	// RVA: 0x5CAB70 Offset: 0x5C9D70 VA: 0x1805CAB70
	public float get_TextHeight() { }

	// RVA: 0x5CA4C0 Offset: 0x5C96C0 VA: 0x1805CA4C0
	public void Start() { }

	// RVA: 0x5C9D60 Offset: 0x5C8F60 VA: 0x1805C9D60
	public void OnDestroy() { }

	// RVA: 0x5C9E30 Offset: 0x5C9030 VA: 0x1805C9E30
	public void ResetField() { }

	// RVA: 0x5C9530 Offset: 0x5C8730 VA: 0x1805C9530
	public void Clear() { }

	// RVA: 0x5CA5F0 Offset: 0x5C97F0 VA: 0x1805CA5F0
	public void Update() { }

	// RVA: 0x5C95D0 Offset: 0x5C87D0 VA: 0x1805C95D0 Slot: 4
	public void GiveFocus() { }

	// RVA: 0x5C9590 Offset: 0x5C8790 VA: 0x1805C9590
	public void ForceKeyboardClose() { }

	// RVA: 0x5C99C0 Offset: 0x5C8BC0 VA: 0x1805C99C0 Slot: 5
	public void LoseFocus() { }

	// RVA: 0x5C9490 Offset: 0x5C8690 VA: 0x1805C9490 Slot: 6
	public bool CheckCollision(Vector2 pt) { }

	// RVA: 0x5C9FE0 Offset: 0x5C91E0 VA: 0x1805C9FE0
	public void SetText(string input, string inputCompo = "") { }

	// RVA: 0x5C9840 Offset: 0x5C8A40 VA: 0x1805C9840
	public bool IsCharAllowed(char i) { }

	// RVA: 0x5C9B80 Offset: 0x5C8D80 VA: 0x1805C9B80
	private void MoveCaret() { }

	// RVA: 0x5C9470 Offset: 0x5C8670 VA: 0x1805C9470
	private void AdjustCaretPosition(int adjustment) { }

	// RVA: 0x5C9EF0 Offset: 0x5C90F0 VA: 0x1805C9EF0
	private void SetCaretPosition(int index) { }

	// RVA: 0x5C9F10 Offset: 0x5C9110 VA: 0x1805C9F10
	private void SetPipePosition() { }

	// RVA: 0x5CAAD0 Offset: 0x5C9CD0 VA: 0x1805CAAD0
	public void .ctor() { }

	// RVA: 0x5CA800 Offset: 0x5C9A00 VA: 0x1805CA800
	private static void .cctor() { }
}

// Namespace: 
public static class ClipboardHelper // TypeDefIndex: 1026
{
	// Fields
	private const uint CF_TEXT = 1;

	// Methods

	// RVA: 0x5BD0F0 Offset: 0x5BC2F0 VA: 0x1805BD0F0
	private static extern bool IsClipboardFormatAvailable(uint format) { }

	// RVA: 0x5BD180 Offset: 0x5BC380 VA: 0x1805BD180
	private static extern bool OpenClipboard(IntPtr hWndNewOwner) { }

	// RVA: 0x5BCB40 Offset: 0x5BBD40 VA: 0x1805BCB40
	private static extern bool CloseClipboard() { }

	// RVA: 0x5BCBB0 Offset: 0x5BBDB0 VA: 0x1805BCBB0
	private static extern IntPtr GetClipboardData(uint format) { }

	// RVA: 0x5BCF70 Offset: 0x5BC170 VA: 0x1805BCF70
	private static extern IntPtr GlobalLock(IntPtr hMem) { }

	// RVA: 0x5BD070 Offset: 0x5BC270 VA: 0x1805BD070
	private static extern bool GlobalUnlock(IntPtr hMem) { }

	// RVA: 0x5BCFF0 Offset: 0x5BC1F0 VA: 0x1805BCFF0
	private static extern int GlobalSize(IntPtr hMem) { }

	// RVA: 0x5BCC30 Offset: 0x5BBE30 VA: 0x1805BCC30
	public static string GetClipboardString() { }

	// RVA: 0x5BD200 Offset: 0x5BC400 VA: 0x1805BD200
	public static void PutClipboardString(string str) { }
}

// Namespace: 
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TextController : MonoBehaviour // TypeDefIndex: 1027
{
	// Fields
	public float Scale; // 0x20
	[Multiline]
	public string Text; // 0x28
	private string displaying; // 0x30
	[HideInInspector]
	private Texture2D texture; // 0x38
	[HideInInspector]
	private Texture2D colorTexture; // 0x40
	private MeshRenderer rend; // 0x48
	private float _scale; // 0x50
	public Color Color; // 0x54
	private Color lastColor; // 0x64
	public Vector3 Offset; // 0x74
	public bool topAligned; // 0x80

	// Methods

	// RVA: 0x5CAB80 Offset: 0x5C9D80 VA: 0x1805CAB80
	public void Update() { }

	// RVA: 0x5CB3E0 Offset: 0x5CA5E0 VA: 0x1805CB3E0
	public void .ctor() { }
}

// Namespace: 
public class TimerTextTMP : MonoBehaviour // TypeDefIndex: 1028
{
	// Fields
	[SerializeField]
	private TextMeshPro text; // 0x20
	private string format; // 0x28
	private float duration; // 0x30
	private float startTime; // 0x34
	private int seconds; // 0x38

	// Methods

	// RVA: 0x5CB750 Offset: 0x5CA950 VA: 0x1805CB750
	private void OnEnable() { }

	// RVA: 0x5CB7F0 Offset: 0x5CA9F0 VA: 0x1805CB7F0
	private void Update() { }

	// RVA: 0x5CB760 Offset: 0x5CA960 VA: 0x1805CB760
	public void SetTimer(float duration, string format) { }

	// RVA: 0x5CB650 Offset: 0x5CA850 VA: 0x1805CB650
	private int GetSecondsRemaining() { }

	// RVA: 0x5CB6E0 Offset: 0x5CA8E0 VA: 0x1805CB6E0
	private string GetTextString() { }

	// RVA: 0x5CB7F0 Offset: 0x5CA9F0 VA: 0x1805CB7F0
	private void Tick() { }

	// RVA: 0x5CB830 Offset: 0x5CAA30 VA: 0x1805CB830
	private void UpdateText() { }

	// RVA: 0x5CB8D0 Offset: 0x5CAAD0 VA: 0x1805CB8D0
	public void .ctor() { }
}

// Namespace: 
public class ToggleButtonBehaviour : MonoBehaviour, ITranslatedText // TypeDefIndex: 1029
{
	// Fields
	public StringNames BaseText; // 0x20
	public TextMeshPro Text; // 0x28
	public SpriteRenderer Background; // 0x30
	public ButtonRolloverHandler Rollover; // 0x38
	private bool onState; // 0x40

	// Methods

	// RVA: 0x5CBAC0 Offset: 0x5CACC0 VA: 0x1805CBAC0
	public void Start() { }

	// RVA: 0x5CB910 Offset: 0x5CAB10 VA: 0x1805CB910
	public void OnDestroy() { }

	// RVA: 0x5CB9A0 Offset: 0x5CABA0 VA: 0x1805CB9A0 Slot: 4
	public void ResetText() { }

	// RVA: 0x5CBB70 Offset: 0x5CAD70 VA: 0x1805CBB70
	public void UpdateText(bool on) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TransitionFade.<CoShow>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1030
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TransitionFade <>4__this; // 0x20
	public GameObject transitionFrom; // 0x28
	public GameObject transitionTo; // 0x30
	public Action callback; // 0x38

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

	// RVA: 0x5CD1F0 Offset: 0x5CC3F0 VA: 0x1805CD1F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CD4A0 Offset: 0x5CC6A0 VA: 0x1805CD4A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class TransitionFade : DestroyableSingleton<TransitionFade> // TypeDefIndex: 1031
{
	// Fields
	public SpriteRenderer overlay; // 0x28

	// Methods

	// RVA: 0x5CBE30 Offset: 0x5CB030 VA: 0x1805CBE30
	public void DoTransitionFade(GameObject transitionFrom, GameObject transitionTo, Action callback) { }

	[IteratorStateMachine(typeof(TransitionFade.<CoShow>d__2))]
	// RVA: 0x5CBDA0 Offset: 0x5CAFA0 VA: 0x1805CBDA0
	private IEnumerator CoShow(GameObject transitionFrom, GameObject transitionTo, Action callback) { }

	// RVA: 0x5CBEE0 Offset: 0x5CB0E0 VA: 0x1805CBEE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TransitionOpen.<AnimateClose>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1032
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TransitionOpen <>4__this; // 0x20
	private Vector3 <vec>5__2; // 0x28
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

	// RVA: 0x5CC450 Offset: 0x5CB650 VA: 0x1805CC450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CC5F0 Offset: 0x5CB7F0 VA: 0x1805CC5F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TransitionOpen.<AnimateOpen>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1033
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TransitionOpen <>4__this; // 0x20
	private Vector3 <vec>5__2; // 0x28
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

	// RVA: 0x5CC9C0 Offset: 0x5CBBC0 VA: 0x1805CC9C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CCB60 Offset: 0x5CBD60 VA: 0x1805CCB60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class TransitionOpen : MonoBehaviour // TypeDefIndex: 1034
{
	// Fields
	public float duration; // 0x20
	public Button.ButtonClickedEvent OnClose; // 0x28
	public Action OnFinishAnimOpen; // 0x30
	[SerializeField]
	private float targetSize; // 0x38

	// Methods

	// RVA: 0x5CC060 Offset: 0x5CB260 VA: 0x1805CC060
	public void OnEnable() { }

	// RVA: 0x5CC0D0 Offset: 0x5CB2D0 VA: 0x1805CC0D0
	public void Toggle() { }

	// RVA: 0x5CBFE0 Offset: 0x5CB1E0 VA: 0x1805CBFE0
	public void Close() { }

	[IteratorStateMachine(typeof(TransitionOpen.<AnimateClose>d__7))]
	// RVA: 0x5CBF20 Offset: 0x5CB120 VA: 0x1805CBF20
	private IEnumerator AnimateClose() { }

	[IteratorStateMachine(typeof(TransitionOpen.<AnimateOpen>d__8))]
	// RVA: 0x5CBF80 Offset: 0x5CB180 VA: 0x1805CBF80
	private IEnumerator AnimateOpen() { }

	// RVA: 0x5CC1A0 Offset: 0x5CB3A0 VA: 0x1805CC1A0
	public void .ctor() { }
}

// Namespace: 
public class VerticalGauge : MonoBehaviour // TypeDefIndex: 1035
{
	// Fields
	public float value; // 0x20
	public float MaxValue; // 0x24
	public float maskScale; // 0x28
	public SpriteMask Mask; // 0x30
	private float lastValue; // 0x38

	// Methods

	// RVA: 0x5CFE40 Offset: 0x5CF040 VA: 0x1805CFE40
	public void Update() { }

	// RVA: 0x596CE0 Offset: 0x595EE0 VA: 0x180596CE0
	public void .ctor() { }
}

// Namespace: 
public class VerticalSpriteGauge : MonoBehaviour // TypeDefIndex: 1036
{
	// Fields
	public float Value; // 0x20
	public float MaxValue; // 0x24
	public FloatRange YRange; // 0x28
	public SpriteRenderer Mask; // 0x30
	private float lastValue; // 0x38
	[CompilerGenerated]
	private float <TopY>k__BackingField; // 0x3C

	// Properties
	public float TopY { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5D01F0 Offset: 0x5CF3F0 VA: 0x1805D01F0
	public float get_TopY() { }

	[CompilerGenerated]
	// RVA: 0x5D0200 Offset: 0x5CF400 VA: 0x1805D0200
	private void set_TopY(float value) { }

	// RVA: 0x5CFFD0 Offset: 0x5CF1D0 VA: 0x1805CFFD0
	public void Update() { }

	// RVA: 0x5D01D0 Offset: 0x5CF3D0 VA: 0x1805D01D0
	public void .ctor() { }
}

// Namespace: 
public interface IDisconnectHandler // TypeDefIndex: 1037
{
	// Properties
	public abstract bool IsPersistent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsPersistent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void HandleDisconnect(PlayerControl pc, DisconnectReasons reason);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void HandleDisconnect();
}

// Namespace: 
internal interface ILocationActivate // TypeDefIndex: 1038
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LocationUse(PlayerControl pc);
}

// Namespace: 
public class ChatLanguageSet // TypeDefIndex: 1039
{
	// Fields
	public static readonly ChatLanguageSet Instance; // 0x0
	public readonly Dictionary<string, uint> Languages; // 0x10

	// Methods

	// RVA: 0x5BC7B0 Offset: 0x5BB9B0 VA: 0x1805BC7B0
	public void .ctor() { }

	// RVA: 0x5BC1A0 Offset: 0x5BB3A0 VA: 0x1805BC1A0
	public void Load() { }

	// RVA: 0x5BC3E0 Offset: 0x5BB5E0 VA: 0x1805BC3E0
	public void Save() { }

	// RVA: 0x5BC030 Offset: 0x5BB230 VA: 0x1805BC030
	public string GetString(uint flag) { }

	// RVA: 0x5BC750 Offset: 0x5BB950 VA: 0x1805BC750
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CompletionToken.<WaitForCompletion>d__11<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1040
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public CompletionToken<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>..ctor
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>.System.IDisposable.Dispose
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF53740 Offset: 0xF52940 VA: 0x180F53740
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>.MoveNext
	|
	|-RVA: 0xF536D0 Offset: 0xF528D0 VA: 0x180F536D0
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>.System.Collections.IEnumerator.Reset
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-CompletionToken.<WaitForCompletion>d__11<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-CompletionToken.<WaitForCompletion>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
public class CompletionToken<T> // TypeDefIndex: 1041
{
	// Fields
	[CompilerGenerated]
	private T <Value>k__BackingField; // 0x0
	private bool complete; // 0x0
	public string errorStr; // 0x0

	// Properties
	public static CompletionToken<T> Default { get; }
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static CompletionToken<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C8D0 Offset: 0xF7BAD0 VA: 0x180F7C8D0
	|-CompletionToken<Int32Enum>.get_Default
	|
	|-RVA: 0xF7C980 Offset: 0xF7BB80 VA: 0x180F7C980
	|-CompletionToken<__Il2CppFullySharedGenericType>.get_Default
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-CompletionToken<Int32Enum>.get_Value
	|
	|-RVA: 0xC6C0A0 Offset: 0xC6B2A0 VA: 0x180C6C0A0
	|-CompletionToken<__Il2CppFullySharedGenericType>.get_Value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	|-CompletionToken<Int32Enum>.set_Value
	|
	|-RVA: 0xF7CB10 Offset: 0xF7BD10 VA: 0x180F7CB10
	|-CompletionToken<__Il2CppFullySharedGenericType>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C880 Offset: 0xF7BA80 VA: 0x180F7C880
	|-CompletionToken<Int32Enum>..ctor
	|
	|-RVA: 0xF7C730 Offset: 0xF7B930 VA: 0x180F7C730
	|-CompletionToken<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void MarkComplete(T resultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C4D0 Offset: 0xF7B6D0 VA: 0x180F7C4D0
	|-CompletionToken<Int32Enum>.MarkComplete
	|
	|-RVA: 0xF7C3B0 Offset: 0xF7B5B0 VA: 0x180F7C3B0
	|-CompletionToken<__Il2CppFullySharedGenericType>.MarkComplete
	*/

	// RVA: -1 Offset: -1
	public void MarkComplete(T resultValue, string error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C4C0 Offset: 0xF7B6C0 VA: 0x180F7C4C0
	|-CompletionToken<Int32Enum>.MarkComplete
	|
	|-RVA: 0xF7C4E0 Offset: 0xF7B6E0 VA: 0x180F7C4E0
	|-CompletionToken<__Il2CppFullySharedGenericType>.MarkComplete
	*/

	[IteratorStateMachine(typeof(CompletionToken.<WaitForCompletion>d__11<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7C630 Offset: 0xF7B830 VA: 0x180F7C630
	|-CompletionToken<Int32Enum>.WaitForCompletion
	|
	|-RVA: 0xF7C6B0 Offset: 0xF7B8B0 VA: 0x180F7C6B0
	|-CompletionToken<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}

// Namespace: 
public enum CrossplayPrivilegeErrorType // TypeDefIndex: 1042
{
	// Fields
	public int value__; // 0x0
	public const CrossplayPrivilegeErrorType None = 0;
	public const CrossplayPrivilegeErrorType Crossplay = 1;
	public const CrossplayPrivilegeErrorType CrossplayCommunication = 2;
}

// Namespace: 
[DisallowMultipleComponent]
public class CustomNetworkTransform : InnerNetObject // TypeDefIndex: 1043
{
	// Fields
	private const float SEND_MOVEMENT_THRESHOLD = 0,0001;
	private const float REPLAY_POSITION_THRESHOLD = 0,003;
	private const float NEUTRAL_BAND_MODIFIER = 0,995;
	private const float SMOOTHING_BAND_MODIFIER = 0,5;
	private const float SMOOTHING_LERP_RATE = 3;
	private const int QUEUE_LENGTH_FOR_SNAPPING = 12;
	private const int QUEUE_LENGTH_FOR_SECOND_SNAP = 14;
	private const int QUEUE_THRESHOLD_FOR_SMOOTHING = 5;
	private const int SNAP_TO_SEQUENCE_ID_BUFFER = 2;
	private PlayerControl myPlayer; // 0x38
	private Rigidbody2D body; // 0x40
	private Queue<Vector2> sendQueue; // 0x48
	private Queue<Vector2> incomingPosQueue; // 0x50
	[SerializeField]
	private float rubberbandModifier; // 0x58
	[SerializeField]
	private float idealSpeed; // 0x5C
	private bool isPaused; // 0x60
	private ushort lastSequenceId; // 0x62
	private Vector2 lastPosition; // 0x64
	private Vector2 lastPosSent; // 0x6C
	private Nullable<Vector2> tempSnapPosition; // 0x74
	private ITransformGhost debugPopPositions; // 0x80
	private ITransformGhost debugTargetPositions; // 0x88
	private ITransformGhost debugTruePositions; // 0x90
	private INetTransformLogger debugNetLogger; // 0x98

	// Methods

	// RVA: 0x5BD250 Offset: 0x5BC450 VA: 0x1805BD250
	private void Awake() { }

	// RVA: 0x5BE380 Offset: 0x5BD580 VA: 0x1805BE380
	public void OnDrawGizmos() { }

	// RVA: 0x5BE6A0 Offset: 0x5BD8A0 VA: 0x1805BE6A0
	public void OnEnable() { }

	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	public void SetPaused(bool isPaused) { }

	// RVA: 0x5BDCC0 Offset: 0x5BCEC0 VA: 0x1805BDCC0
	public void Halt() { }

	// RVA: 0x5BE750 Offset: 0x5BD950 VA: 0x1805BE750
	public void RpcSnapTo(Vector2 position) { }

	// RVA: 0x5BF0C0 Offset: 0x5BE2C0 VA: 0x1805BF0C0
	public void SnapTo(Vector2 position) { }

	// RVA: 0x5BD370 Offset: 0x5BC570 VA: 0x1805BD370
	public void ClearPositionQueues() { }

	// RVA: 0x5BDEC0 Offset: 0x5BD0C0 VA: 0x1805BDEC0
	private bool IsInMiddleOfAnimationThatMakesPlayerInvisible() { }

	// RVA: 0x5BEE80 Offset: 0x5BE080 VA: 0x1805BEE80
	private void SnapTo(Vector2 position, ushort minSid) { }

	// RVA: 0x5BD880 Offset: 0x5BCA80 VA: 0x1805BD880
	private void FixedUpdate() { }

	// RVA: 0x5BDDE0 Offset: 0x5BCFE0 VA: 0x1805BDDE0
	private bool HasMoved() { }

	// RVA: 0x5BDD30 Offset: 0x5BCF30 VA: 0x1805BDD30 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x5BD360 Offset: 0x5BC560 VA: 0x1805BD360 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x5BE880 Offset: 0x5BDA80 VA: 0x1805BE880 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x5BD3D0 Offset: 0x5BC5D0 VA: 0x1805BD3D0 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x5BDF20 Offset: 0x5BD120 VA: 0x1805BDF20
	private void MoveTowardNextPoint() { }

	// RVA: 0x5BED00 Offset: 0x5BDF00 VA: 0x1805BED00
	private void SkipExcessiveFrames() { }

	// RVA: 0x5BEC10 Offset: 0x5BDE10 VA: 0x1805BEC10
	private bool ShouldExtendCurrentFrame(Vector2 nextPos, Vector2 currentPos) { }

	// RVA: 0x5BD7D0 Offset: 0x5BC9D0 VA: 0x1805BD7D0
	private bool DidPassPosition(Vector2 nextPos, Vector2 lastPos, Vector2 currentPos) { }

	// RVA: 0x5BEB60 Offset: 0x5BDD60 VA: 0x1805BEB60
	private void SetMovementSmoothingModifier() { }

	// RVA: 0x5BF0E0 Offset: 0x5BE2E0 VA: 0x1805BF0E0
	public void .ctor() { }
}

// Namespace: 
public enum DisconnectReasons // TypeDefIndex: 1044
{
	// Fields
	public int value__; // 0x0
	public const DisconnectReasons ExitGame = 0;
	public const DisconnectReasons GameFull = 1;
	public const DisconnectReasons GameStarted = 2;
	public const DisconnectReasons GameNotFound = 3;
	public const DisconnectReasons IncorrectVersion = 5;
	public const DisconnectReasons Banned = 6;
	public const DisconnectReasons Kicked = 7;
	public const DisconnectReasons Custom = 8;
	public const DisconnectReasons InvalidName = 9;
	public const DisconnectReasons Hacking = 10;
	public const DisconnectReasons NotAuthorized = 11;
	public const DisconnectReasons ConnectionLimit = 12;
	public const DisconnectReasons Destroy = 16;
	public const DisconnectReasons Error = 17;
	public const DisconnectReasons IncorrectGame = 18;
	public const DisconnectReasons ServerRequest = 19;
	public const DisconnectReasons ServerFull = 20;
	public const DisconnectReasons MismatchedVersion = 21;
	public const DisconnectReasons InternalPlayerMissing = 100;
	public const DisconnectReasons InternalNonceFailure = 101;
	public const DisconnectReasons InternalConnectionToken = 102;
	public const DisconnectReasons PlatformLock = 103;
	public const DisconnectReasons LobbyInactivity = 104;
	public const DisconnectReasons MatchmakerInactivity = 105;
	public const DisconnectReasons InvalidGameOptions = 106;
	public const DisconnectReasons NoServersAvailable = 107;
	public const DisconnectReasons QuickmatchDisabled = 108;
	public const DisconnectReasons TooManyGames = 109;
	public const DisconnectReasons QuickchatLock = 110;
	public const DisconnectReasons MatchmakerFull = 111;
	public const DisconnectReasons Sanctions = 112;
	public const DisconnectReasons ServerError = 113;
	public const DisconnectReasons SelfPlatformLock = 114;
	public const DisconnectReasons DuplicateConnectionDetected = 115;
	public const DisconnectReasons TooManyRequests = 116;
	public const DisconnectReasons IntentionalLeaving = 208;
	public const DisconnectReasons FocusLostBackground = 207;
	public const DisconnectReasons FocusLost = 209;
	public const DisconnectReasons NewConnection = 210;
	public const DisconnectReasons PlatformParentalControlsBlock = 211;
	public const DisconnectReasons PlatformUserBlock = 212;
	public const DisconnectReasons PlatformFailedToGetUserBlock = 213;
	public const DisconnectReasons ServerNotFound = 214;
	public const DisconnectReasons ClientTimeout = 215;
	public const DisconnectReasons ErrorAuthNonceFailure = 216;
	public const DisconnectReasons Unknown = 255;
}

// Namespace: 
public class DnsRegionInfo : IRegionInfo // TypeDefIndex: 1045
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly StringNames <TranslateName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <TargetServer>k__BackingField; // 0x20
	public readonly string Fqdn; // 0x28
	public readonly string DefaultIp; // 0x30
	public readonly ushort Port; // 0x38
	public readonly bool UseDtls; // 0x3A
	private ServerInfo[] cachedServers; // 0x40

	// Properties
	public string Name { get; }
	[JsonIgnore]
	public string PingServer { get; }
	[JsonIgnore]
	public ServerInfo[] Servers { get; }
	public StringNames TranslateName { get; }
	public string TargetServer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Name() { }

	// RVA: 0x5BFB60 Offset: 0x5BED60 VA: 0x1805BFB60 Slot: 5
	public string get_PingServer() { }

	// RVA: 0x5BFBE0 Offset: 0x5BEDE0 VA: 0x1805BFBE0 Slot: 6
	public ServerInfo[] get_Servers() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 7
	public StringNames get_TranslateName() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public string get_TargetServer() { }

	// RVA: 0x5BFA80 Offset: 0x5BEC80 VA: 0x1805BFA80
	public void .ctor(string fqdn, string name, StringNames translateName, string defaultIp, ushort port, bool useDtls = True) { }

	// RVA: 0x5BF790 Offset: 0x5BE990 VA: 0x1805BF790
	private void PopulateServers() { }

	// RVA: 0x5BFB00 Offset: 0x5BED00 VA: 0x1805BFB00
	private void .ctor(string fqdn, string name, StringNames translateName, ServerInfo[] servers) { }

	// RVA: 0x5BFA60 Offset: 0x5BEC60 VA: 0x1805BFA60 Slot: 10
	public bool Validate() { }

	// RVA: 0x5BF630 Offset: 0x5BE830 VA: 0x1805BF630 Slot: 9
	public IRegionInfo Duplicate() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5BF6E0 Offset: 0x5BE8E0 VA: 0x1805BF6E0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpUtils.<>c // TypeDefIndex: 1046
{
	// Fields
	public static readonly HttpUtils.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, object>, string> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x5CF1B0 Offset: 0x5CE3B0 VA: 0x1805CF1B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEB00 Offset: 0x5CDD00 VA: 0x1805CEB00
	internal string <ToUriQuery>b__1_0(KeyValuePair<string, object> kvp) { }
}

// Namespace: 
public static class HttpUtils // TypeDefIndex: 1047
{
	// Methods

	// RVA: 0x5BFC10 Offset: 0x5BEE10 VA: 0x1805BFC10
	public static bool IsSuccess(long httpStatusCode) { }

	// RVA: 0x5BFC30 Offset: 0x5BEE30 VA: 0x1805BFC30
	public static string ToUriQuery(Dictionary<string, object> uriParams) { }
}

// Namespace: 
public static class NetHelpers // TypeDefIndex: 1048
{
	// Fields
	private static readonly FloatRange XRange; // 0x0
	private static readonly FloatRange YRange; // 0x8

	// Methods

	// RVA: 0x5C00D0 Offset: 0x5BF2D0 VA: 0x1805C00D0
	public static bool SidGreaterThan(ushort newSid, ushort prevSid) { }

	// RVA: 0x5C0100 Offset: 0x5BF300 VA: 0x1805C0100
	public static bool SidGreaterThan(byte newSid, byte prevSid) { }

	// RVA: 0x5C0120 Offset: 0x5BF320 VA: 0x1805C0120
	public static void WriteVector2(Vector2 vec, MessageWriter writer) { }

	// RVA: 0x5BFFD0 Offset: 0x5BF1D0 VA: 0x1805BFFD0
	public static Vector2 ReadVector2(MessageReader reader) { }

	// RVA: 0x5C0220 Offset: 0x5BF420 VA: 0x1805C0220
	private static void .cctor() { }
}

// Namespace: 
public enum Platforms // TypeDefIndex: 1049
{
	// Fields
	public int value__; // 0x0
	public const Platforms Unknown = 0;
	public const Platforms StandaloneEpicPC = 1;
	public const Platforms StandaloneSteamPC = 2;
	public const Platforms StandaloneMac = 3;
	public const Platforms StandaloneWin10 = 4;
	public const Platforms StandaloneItch = 5;
	public const Platforms IPhone = 6;
	public const Platforms Android = 7;
	public const Platforms Switch = 8;
	public const Platforms Xbox = 9;
	public const Platforms Playstation = 10;
}

// Namespace: 
public class PlatformSpecificData // TypeDefIndex: 1050
{
	// Fields
	public Platforms Platform; // 0x10
	public string PlatformName; // 0x18
	public ulong XboxPlatformId; // 0x20
	public ulong PsnPlatformId; // 0x28

	// Methods

	// RVA: 0x5C3530 Offset: 0x5C2730 VA: 0x1805C3530
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x5C35B0 Offset: 0x5C27B0 VA: 0x1805C35B0
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x5C3630 Offset: 0x5C2830 VA: 0x1805C3630
	public void .ctor() { }
}

// Namespace: 
public enum RpcCalls // TypeDefIndex: 1051
{
	// Fields
	public byte value__; // 0x0
	public const RpcCalls PlayAnimation = 0;
	public const RpcCalls CompleteTask = 1;
	public const RpcCalls SyncSettings = 2;
	public const RpcCalls SetInfected = 3;
	public const RpcCalls Exiled = 4;
	public const RpcCalls CheckName = 5;
	public const RpcCalls SetName = 6;
	public const RpcCalls CheckColor = 7;
	public const RpcCalls SetColor = 8;
	public const RpcCalls SetHat_Deprecated = 9;
	public const RpcCalls SetSkin_Deprecated = 10;
	public const RpcCalls ReportDeadBody = 11;
	public const RpcCalls MurderPlayer = 12;
	public const RpcCalls SendChat = 13;
	public const RpcCalls StartMeeting = 14;
	public const RpcCalls SetScanner = 15;
	public const RpcCalls SendChatNote = 16;
	public const RpcCalls SetPet_Deprecated = 17;
	public const RpcCalls SetStartCounter = 18;
	public const RpcCalls EnterVent = 19;
	public const RpcCalls ExitVent = 20;
	public const RpcCalls SnapTo = 21;
	public const RpcCalls CloseMeeting = 22;
	public const RpcCalls VotingComplete = 23;
	public const RpcCalls CastVote = 24;
	public const RpcCalls ClearVote = 25;
	public const RpcCalls AddVote = 26;
	public const RpcCalls CloseDoorsOfType = 27;
	public const RpcCalls SetTasks = 29;
	public const RpcCalls ClimbLadder = 31;
	public const RpcCalls UsePlatform = 32;
	public const RpcCalls SendQuickChat = 33;
	public const RpcCalls BootFromVent = 34;
	public const RpcCalls UpdateSystem = 35;
	public const RpcCalls SetVisor_Deprecated = 36;
	public const RpcCalls SetNamePlate_Deprecated = 37;
	public const RpcCalls SetLevel = 38;
	public const RpcCalls SetHatStr = 39;
	public const RpcCalls SetSkinStr = 40;
	public const RpcCalls SetPetStr = 41;
	public const RpcCalls SetVisorStr = 42;
	public const RpcCalls SetNamePlateStr = 43;
	public const RpcCalls SetRole = 44;
	public const RpcCalls ProtectPlayer = 45;
	public const RpcCalls Shapeshift = 46;
	public const RpcCalls CheckMurder = 47;
	public const RpcCalls CheckProtect = 48;
	public const RpcCalls Pet = 49;
	public const RpcCalls CancelPet = 50;
	public const RpcCalls CheckZipline = 51;
	public const RpcCalls UseZipline = 52;
	public const RpcCalls TriggerSpores = 53;
	public const RpcCalls CheckSpore = 54;
	public const RpcCalls CheckShapeshift = 55;
	public const RpcCalls RejectShapeshift = 56;
	public const RpcCalls LobbyTimeExpiring = 60;
	public const RpcCalls ExtendLobbyTimer = 61;
	public const RpcCalls CheckVanish = 62;
	public const RpcCalls StartVanish = 63;
	public const RpcCalls CheckAppear = 64;
	public const RpcCalls StartAppear = 65;
}

// Namespace: 
public enum SanctionReasons // TypeDefIndex: 1052
{
	// Fields
	public int value__; // 0x0
	public const SanctionReasons None = 0;
	public const SanctionReasons ImpersonationCeleb = 1;
	public const SanctionReasons Spamming = 2;
	public const SanctionReasons InappropriateNameUnsportsmanlike = 3;
	public const SanctionReasons UnsportsmanlikeConduct = 4;
	public const SanctionReasons ImpersonationDevelopers = 5;
	public const SanctionReasons InappropriateChatPersonalInfo = 6;
	public const SanctionReasons InappropriateNameDerogatory = 7;
	public const SanctionReasons InappropriateNameNsfw = 8;
	public const SanctionReasons Bullying = 9;
	public const SanctionReasons CheatingHacking = 10;
	public const SanctionReasons InappropriateChatDating = 11;
	public const SanctionReasons WeaponizingRules = 12;
	public const SanctionReasons RepeatOffender3 = 13;
	public const SanctionReasons SexualMisconduct = 14;
	public const SanctionReasons Doxing = 15;
	public const SanctionReasons IllegalActivity = 16;
	public const SanctionReasons Harassment = 17;
	public const SanctionReasons SelfHarmPromotion = 18;
	public const SanctionReasons RepeatOffender10 = 19;
	public const SanctionReasons InvalidUser = 20;
}

// Namespace: 
private struct SequenceBuffer.SequencedData<T, T> : IComparable<SequenceBuffer.SequencedData<T, T>> // TypeDefIndex: 1053
{
	// Fields
	public readonly ushort Sid; // 0x0
	public readonly T Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ushort sid, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1B90 Offset: 0xBF0D90 VA: 0x180BF1B90
	|-SequenceBuffer.SequencedData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xBF1CE0 Offset: 0xBF0EE0 VA: 0x180BF1CE0
	|-SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int CompareTo(SequenceBuffer.SequencedData<T, T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1A50 Offset: 0xBF0C50 VA: 0x180BF1A50
	|-SequenceBuffer.SequencedData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	|
	|-RVA: 0xBF1B60 Offset: 0xBF0D60 VA: 0x180BF1B60
	|-SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>.CompareTo
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SequenceBuffer.<SubsequentObjs>d__11<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 1054
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public SequenceBuffer<T> <>4__this; // 0x0

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
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xB049E0 Offset: 0xB03BE0 VA: 0x180B049E0
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4E9B0 Offset: 0xF4DBB0 VA: 0x180F4E9B0
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0xF4E8A0 Offset: 0xF4DAA0 VA: 0x180F4E8A0
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E870 Offset: 0xB1DA70 VA: 0x180B1E870
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E920 Offset: 0xB1DB20 VA: 0x180B1E920
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF4EF50 Offset: 0xF4E150 VA: 0x180F4EF50
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4ED40 Offset: 0xF4DF40 VA: 0x180F4ED40
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xF4EC90 Offset: 0xF4DE90 VA: 0x180F4EC90
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB25440 Offset: 0xB24640 VA: 0x180B25440
	|-SequenceBuffer.<SubsequentObjs>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF4EEA0 Offset: 0xF4E0A0 VA: 0x180F4EEA0
	|-SequenceBuffer.<SubsequentObjs>d__11<VentilationSystem.VentMoveInfo>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
public class SequenceBuffer<T> // TypeDefIndex: 1055
{
	// Fields
	private readonly List<SequenceBuffer.SequencedData<T, T>> buffer; // 0x0
	[CompilerGenerated]
	private ushort <LastSid>k__BackingField; // 0x0

	// Properties
	public ushort LastSid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ushort get_LastSid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1A30 Offset: 0xBF0C30 VA: 0x180BF1A30
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.get_LastSid
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.get_LastSid
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_LastSid(ushort value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1A40 Offset: 0xBF0C40 VA: 0x180BF1A40
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.set_LastSid
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.set_LastSid
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ushort sidStart = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1990 Offset: 0xBF0B90 VA: 0x180BF1990
	|-SequenceBuffer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xBF1900 Offset: 0xBF0B00 VA: 0x180BF1900
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(ushort sid, T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0FF0 Offset: 0xBF01F0 VA: 0x180BF0FF0
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0xBF0F10 Offset: 0xBF0110 VA: 0x180BF0F10
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.Add
	*/

	// RVA: -1 Offset: -1
	public void BumpSid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1170 Offset: 0xBF0370 VA: 0x180BF1170
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.BumpSid
	|
	|-RVA: 0xBF11C0 Offset: 0xBF03C0 VA: 0x180BF11C0
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.BumpSid
	*/

	// RVA: -1 Offset: -1
	public bool IsInvalidSid(ushort sid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1290 Offset: 0xBF0490 VA: 0x180BF1290
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.IsInvalidSid
	|
	|-RVA: 0xBF1230 Offset: 0xBF0430 VA: 0x180BF1230
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.IsInvalidSid
	*/

	// RVA: -1 Offset: -1
	public bool IsNextSid(ushort sid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1320 Offset: 0xBF0520 VA: 0x180BF1320
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.IsNextSid
	|
	|-RVA: 0xBF1350 Offset: 0xBF0550 VA: 0x180BF1350
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.IsNextSid
	*/

	[IteratorStateMachine(typeof(SequenceBuffer.<SubsequentObjs>d__11<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> SubsequentObjs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF17D0 Offset: 0xBF09D0 VA: 0x180BF17D0
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.SubsequentObjs
	|
	|-RVA: 0xBF1880 Offset: 0xBF0A80 VA: 0x180BF1880
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.SubsequentObjs
	*/

	// RVA: -1 Offset: -1
	private void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF17A0 Offset: 0xBF09A0 VA: 0x180BF17A0
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0xBF1770 Offset: 0xBF0970 VA: 0x180BF1770
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.Sort
	*/

	// RVA: -1 Offset: -1
	private bool HasElements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF11D0 Offset: 0xBF03D0 VA: 0x180BF11D0
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.HasElements
	|
	|-RVA: 0xBF1210 Offset: 0xBF0410 VA: 0x180BF1210
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.HasElements
	*/

	// RVA: -1 Offset: -1
	private SequenceBuffer.SequencedData<T, T> Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1640 Offset: 0xBF0840 VA: 0x180BF1640
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.Pop
	|
	|-RVA: 0xBF1550 Offset: 0xBF0750 VA: 0x180BF1550
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.Pop
	*/

	// RVA: -1 Offset: -1
	private SequenceBuffer.SequencedData<T, T> Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1360 Offset: 0xBF0560 VA: 0x180BF1360
	|-SequenceBuffer<__Il2CppFullySharedGenericType>.Peek
	|
	|-RVA: 0xBF14A0 Offset: 0xBF06A0 VA: 0x180BF14A0
	|-SequenceBuffer<VentilationSystem.VentMoveInfo>.Peek
	*/
}

// Namespace: 
public enum UpdateState // TypeDefIndex: 1056
{
	// Fields
	public int value__; // 0x0
	public const UpdateState Connecting = 0;
	public const UpdateState Failed = 1;
	public const UpdateState Success = 2;
	public const UpdateState PartialSuccess = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServerManager.JsonServerData.<>c // TypeDefIndex: 1057
{
	// Fields
	public static readonly ServerManager.JsonServerData.<>c <>9; // 0x0
	public static Func<IRegionInfo, bool> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x5CF150 Offset: 0x5CE350 VA: 0x1805CF150
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CE940 Offset: 0x5CDB40 VA: 0x1805CE940
	internal bool <CleanAndMerge>b__2_0(IRegionInfo r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerManager.JsonServerData.<>c__DisplayClass2_0 // TypeDefIndex: 1058
{
	// Fields
	public IRegionInfo region; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEE50 Offset: 0x5CE050 VA: 0x1805CEE50
	internal bool <CleanAndMerge>b__1(IRegionInfo r) { }
}

// Namespace: 
[JsonObject]
private struct ServerManager.JsonServerData // TypeDefIndex: 1059
{
	// Fields
	public int CurrentRegionIdx; // 0x0
	public IRegionInfo[] Regions; // 0x8

	// Methods

	// RVA: 0x5BFD50 Offset: 0x5BEF50 VA: 0x1805BFD50
	internal void CleanAndMerge(IRegionInfo[] defaultRegions) { }
}

// Namespace: 
private struct ServerManager.PingWrapper // TypeDefIndex: 1060
{
	// Fields
	public IRegionInfo Region; // 0x0
	public Ping Ping; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(IRegionInfo region, Ping ping) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServerManager.<>c // TypeDefIndex: 1061
{
	// Fields
	public static readonly ServerManager.<>c <>9; // 0x0
	public static Func<ServerInfo, bool> <>9__32_0; // 0x8
	public static Func<ServerInfo, int> <>9__32_1; // 0x10
	public static Func<ServerInfo, int> <>9__32_2; // 0x18
	public static Func<Task<IPAddress[]>, bool> <>9__33_0; // 0x20
	public static Func<ServerManager.PingWrapper, bool> <>9__33_1; // 0x28
	public static Func<ServerInfo, int> <>9__38_1; // 0x30

	// Methods

	// RVA: 0x5CF210 Offset: 0x5CE410 VA: 0x1805CF210
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEAA0 Offset: 0x5CDCA0 VA: 0x1805CEAA0
	internal bool <ReselectServer>b__32_0(ServerInfo s) { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int <ReselectServer>b__32_1(ServerInfo s) { }

	// RVA: 0x5CEAE0 Offset: 0x5CDCE0 VA: 0x1805CEAE0
	internal int <ReselectServer>b__32_2(ServerInfo s) { }

	// RVA: 0x5CEA20 Offset: 0x5CDC20 VA: 0x1805CEA20
	internal bool <ReselectRegionFromDefaults>b__33_0(Task<IPAddress[]> task) { }

	// RVA: 0x5CEA50 Offset: 0x5CDC50 VA: 0x1805CEA50
	internal bool <ReselectRegionFromDefaults>b__33_1(ServerManager.PingWrapper p) { }

	// RVA: 0x5CEAE0 Offset: 0x5CDCE0 VA: 0x1805CEAE0
	internal int <TrackServerFailure>b__38_1(ServerInfo s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerManager.<>c__DisplayClass38_0 // TypeDefIndex: 1062
{
	// Fields
	public string networkAddress; // 0x10
	public ServerInfo srv; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0550 Offset: 0x59F750 VA: 0x1805A0550
	internal bool <TrackServerFailure>b__0(ServerInfo s) { }

	// RVA: 0x5CEEE0 Offset: 0x5CE0E0 VA: 0x1805CEEE0
	internal bool <TrackServerFailure>b__2(ServerInfo s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerManager.<>c__DisplayClass3_0 // TypeDefIndex: 1063
{
	// Fields
	public IRegionInfo newRegion; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEF10 Offset: 0x5CE110 VA: 0x1805CEF10
	internal bool <AddOrUpdateRegion>b__0(IRegionInfo r) { }

	// RVA: 0x5CEFA0 Offset: 0x5CE1A0 VA: 0x1805CEFA0
	internal bool <AddOrUpdateRegion>b__1(IRegionInfo r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerManager.<ReselectRegionFromDefaults>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1064
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ServerManager <>4__this; // 0x20
	private List<Task<IPAddress[]>> <dnsLookups>5__2; // 0x28
	private List<ServerManager.PingWrapper> <pings>5__3; // 0x30
	private float <timeElapsedSeconds>5__4; // 0x38

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

	// RVA: 0x5CDAA0 Offset: 0x5CCCA0 VA: 0x1805CDAA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CE6B0 Offset: 0x5CD8B0 VA: 0x1805CE6B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerManager.<WaitForServers>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1065
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ServerManager <>4__this; // 0x20

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

	// RVA: 0x560810 Offset: 0x55FA10 VA: 0x180560810 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5CF360 Offset: 0x5CE560 VA: 0x1805CF360 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ServerManager : DestroyableSingleton<ServerManager> // TypeDefIndex: 1066
{
	// Fields
	public static readonly IRegionInfo[] DefaultRegions; // 0x0
	private const bool useDtls = False;
	private const float PingTimeoutSeconds = 5;
	[CompilerGenerated]
	private IRegionInfo <CurrentRegion>k__BackingField; // 0x28
	[CompilerGenerated]
	private ServerInfo <CurrentUdpServer>k__BackingField; // 0x30
	[CompilerGenerated]
	private IRegionInfo[] <AvailableRegions>k__BackingField; // 0x38
	private string serverInfoFileJson; // 0x40
	private UpdateState state; // 0x48

	// Properties
	public IRegionInfo CurrentRegion { get; set; }
	public ServerInfo CurrentUdpServer { get; set; }
	public bool IsHttp { get; }
	public string TargetServer { get; }
	public IRegionInfo[] AvailableRegions { get; set; }
	private ServerInfo[] AvailableServers { get; }
	public string UdpNetAddress { get; }
	public ushort UdpNetPort { get; }
	public bool UdpUseDtls { get; }

	// Methods

	// RVA: 0x5C6680 Offset: 0x5C5880 VA: 0x1805C6680
	internal void AddOrUpdateRegion(IRegionInfo newRegion) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IRegionInfo get_CurrentRegion() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_CurrentRegion(IRegionInfo value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ServerInfo get_CurrentUdpServer() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_CurrentUdpServer(ServerInfo value) { }

	// RVA: 0x5C7FE0 Offset: 0x5C71E0 VA: 0x1805C7FE0
	public bool get_IsHttp() { }

	// RVA: 0x5C8060 Offset: 0x5C7260 VA: 0x1805C8060
	public string get_TargetServer() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IRegionInfo[] get_AvailableRegions() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_AvailableRegions(IRegionInfo[] value) { }

	// RVA: 0x5C7F90 Offset: 0x5C7190 VA: 0x1805C7F90
	private ServerInfo[] get_AvailableServers() { }

	// RVA: 0x5C80B0 Offset: 0x5C72B0 VA: 0x1805C80B0
	public string get_UdpNetAddress() { }

	// RVA: 0x5C80D0 Offset: 0x5C72D0 VA: 0x1805C80D0
	public ushort get_UdpNetPort() { }

	// RVA: 0x5C80F0 Offset: 0x5C72F0 VA: 0x1805C80F0
	public bool get_UdpUseDtls() { }

	// RVA: 0x5C69A0 Offset: 0x5C5BA0 VA: 0x1805C69A0 Slot: 4
	public override void Awake() { }

	// RVA: 0x5C6B00 Offset: 0x5C5D00 VA: 0x1805C6B00
	private void HandleUpnp() { }

	[ContextMenu("Reselect Server")]
	// RVA: 0x5C6FE0 Offset: 0x5C61E0 VA: 0x1805C6FE0
	internal void ReselectServer() { }

	[IteratorStateMachine(typeof(ServerManager.<ReselectRegionFromDefaults>d__33))]
	// RVA: 0x5C6F80 Offset: 0x5C6180 VA: 0x1805C6F80
	public IEnumerator ReselectRegionFromDefaults() { }

	[IteratorStateMachine(typeof(ServerManager.<WaitForServers>d__34))]
	// RVA: 0x5C79F0 Offset: 0x5C6BF0 VA: 0x1805C79F0
	public IEnumerator WaitForServers() { }

	// RVA: 0x5C7620 Offset: 0x5C6820 VA: 0x1805C7620
	internal void SetRegion(IRegionInfo region) { }

	// RVA: 0x5C7480 Offset: 0x5C6680 VA: 0x1805C7480
	public void SaveServers() { }

	// RVA: 0x5C6C50 Offset: 0x5C5E50 VA: 0x1805C6C50
	public void LoadServers() { }

	// RVA: 0x5C7650 Offset: 0x5C6850 VA: 0x1805C7650
	internal bool TrackServerFailure(string networkAddress) { }

	// RVA: 0x5C7F10 Offset: 0x5C7110 VA: 0x1805C7F10
	public void .ctor() { }

	// RVA: 0x5C7A50 Offset: 0x5C6C50 VA: 0x1805C7A50
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x5C7970 Offset: 0x5C6B70 VA: 0x1805C7970
	private bool <SaveServers>b__36_0(IRegionInfo r) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StaticHttpRegionInfo.<>c // TypeDefIndex: 1067
{
	// Fields
	public static readonly StaticHttpRegionInfo.<>c <>9; // 0x0
	public static Func<ServerInfo, bool> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x5CF0F0 Offset: 0x5CE2F0 VA: 0x1805CF0F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEBC0 Offset: 0x5CDDC0 VA: 0x1805CEBC0
	internal bool <Validate>b__17_0(ServerInfo s) { }
}

// Namespace: 
public class StaticHttpRegionInfo : IRegionInfo // TypeDefIndex: 1068
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <PingServer>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ServerInfo[] <Servers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <TargetServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly StringNames <TranslateName>k__BackingField; // 0x30

	// Properties
	public string Name { get; }
	public string PingServer { get; }
	public ServerInfo[] Servers { get; }
	public string TargetServer { get; }
	public StringNames TranslateName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public string get_PingServer() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	public ServerInfo[] get_Servers() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public string get_TargetServer() { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 7
	public StringNames get_TranslateName() { }

	// RVA: 0x5C9040 Offset: 0x5C8240 VA: 0x1805C9040
	public void .ctor(string name, StringNames translateName, string pingServer, ServerInfo[] servers, string targetServer) { }

	// RVA: 0x5C8CC0 Offset: 0x5C7EC0 VA: 0x1805C8CC0 Slot: 9
	public IRegionInfo Duplicate() { }

	// RVA: 0x5C8F30 Offset: 0x5C8130 VA: 0x1805C8F30 Slot: 10
	public bool Validate() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C8EB0 Offset: 0x5C80B0 VA: 0x1805C8EB0 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
public interface IRegionInfo // TypeDefIndex: 1069
{
	// Properties
	public abstract string Name { get; }
	public abstract string PingServer { get; }
	public abstract ServerInfo[] Servers { get; }
	public abstract StringNames TranslateName { get; }
	public abstract string TargetServer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_PingServer();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ServerInfo[] get_Servers();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract StringNames get_TranslateName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_TargetServer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IRegionInfo Duplicate();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Validate();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StaticRegionInfo.<>c // TypeDefIndex: 1070
{
	// Fields
	public static readonly StaticRegionInfo.<>c <>9; // 0x0
	public static Func<ServerInfo, bool> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x5CF030 Offset: 0x5CE230 VA: 0x1805CF030
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEBC0 Offset: 0x5CDDC0 VA: 0x1805CEBC0
	internal bool <Validate>b__17_0(ServerInfo s) { }
}

// Namespace: 
public class StaticRegionInfo : IRegionInfo // TypeDefIndex: 1071
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <PingServer>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ServerInfo[] <Servers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <TargetServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly StringNames <TranslateName>k__BackingField; // 0x30

	// Properties
	public string Name { get; }
	public string PingServer { get; }
	public ServerInfo[] Servers { get; }
	public string TargetServer { get; }
	public StringNames TranslateName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public string get_PingServer() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	public ServerInfo[] get_Servers() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public string get_TargetServer() { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 7
	public StringNames get_TranslateName() { }

	// RVA: 0x5C9420 Offset: 0x5C8620 VA: 0x1805C9420
	public void .ctor(string name, StringNames translateName, string pingServer, ServerInfo[] servers) { }

	// RVA: 0x5C90A0 Offset: 0x5C82A0 VA: 0x1805C90A0 Slot: 9
	public IRegionInfo Duplicate() { }

	// RVA: 0x5C9310 Offset: 0x5C8510 VA: 0x1805C9310 Slot: 10
	public bool Validate() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C9290 Offset: 0x5C8490 VA: 0x1805C9290 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
public class ServerInfo // TypeDefIndex: 1072
{
	// Fields
	public readonly string Name; // 0x10
	public readonly string Ip; // 0x18
	public readonly ushort Port; // 0x20
	public readonly bool UseDtls; // 0x22
	public int Players; // 0x24
	public int ConnectionFailures; // 0x28

	// Properties
	[JsonIgnore]
	public string HttpUrl { get; }

	// Methods

	// RVA: 0x5C65A0 Offset: 0x5C57A0 VA: 0x1805C65A0
	public string get_HttpUrl() { }

	// RVA: 0x5C6520 Offset: 0x5C5720 VA: 0x1805C6520
	public void .ctor(string name, string ip, ushort port, bool useDtls = True) { }

	// RVA: 0x5C6350 Offset: 0x5C5550 VA: 0x1805C6350 Slot: 3
	public override string ToString() { }

	// RVA: 0x5C6320 Offset: 0x5C5520 VA: 0x1805C6320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5C6260 Offset: 0x5C5460 VA: 0x1805C6260 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
public static class UrlFinder // TypeDefIndex: 1073
{
	// Fields
	private static readonly string[] Prefixes; // 0x0
	private static readonly string[] Suffixes; // 0x8

	// Methods

	// RVA: 0x5CFA50 Offset: 0x5CEC50 VA: 0x1805CFA50
	public static bool TryFindUrl(char[] sourceText, out int startCensor, out int endCensor) { }

	// RVA: 0x5CF4A0 Offset: 0x5CE6A0 VA: 0x1805CF4A0
	private static bool CheckPrefixes(char[] sourceText, out int startCensor, out int endCensor) { }

	// RVA: 0x5CF5E0 Offset: 0x5CE7E0 VA: 0x1805CF5E0
	private static bool CheckSuffixes(char[] sourceText, int startAt, out int startCensor, out int endCensor) { }

	// RVA: 0x5CF920 Offset: 0x5CEB20 VA: 0x1805CF920
	private static int FindWord(char[] sourceText, string word, int startAt = 0) { }

	// RVA: 0x5CF860 Offset: 0x5CEA60 VA: 0x1805CF860
	private static int FindWordStart(char[] sourceText, int startAt) { }

	// RVA: 0x5CF7B0 Offset: 0x5CE9B0 VA: 0x1805CF7B0
	private static int FindWordEnd(char[] sourceText, int startAt) { }

	// RVA: 0x5CFC00 Offset: 0x5CEE00 VA: 0x1805CFC00
	private static void .cctor() { }
}

// Namespace: 
public class MeshSequence : ScriptableObject // TypeDefIndex: 1074
{
	// Fields
	public Mesh[] Frames; // 0x18
	public Vector3[] Scales; // 0x20
	public Vector3[] Positions; // 0x28

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CrystalBehaviour.<Flash>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1075
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public CrystalBehaviour c; // 0x28
	private Color <col>5__2; // 0x30
	private float <time>5__3; // 0x40

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

	// RVA: 0x5E4040 Offset: 0x5E3240 VA: 0x1805E4040 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E42D0 Offset: 0x5E34D0 VA: 0x1805E42D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CrystalBehaviour : UiElement // TypeDefIndex: 1076
{
	// Fields
	public Transform TargetPosition; // 0x58
	public SpriteRenderer Renderer; // 0x60
	public BoxCollider2D Collider; // 0x68
	public bool CanMove; // 0x70
	public FloatRange Padding; // 0x78
	private const float Speed = 15;
	public float XFloatMag; // 0x80
	private const float FloatMag = 0,05;
	private const float FloatSpeed = 0,35;
	public float PieceIndex; // 0x84

	// Methods

	// RVA: 0x5D6C90 Offset: 0x5D5E90 VA: 0x1805D6C90
	private void Update() { }

	// RVA: 0x5D6BA0 Offset: 0x5D5DA0 VA: 0x1805D6BA0
	public void Flash(float delay = 0) { }

	[IteratorStateMachine(typeof(CrystalBehaviour.<Flash>d__12))]
	// RVA: 0x5D6C20 Offset: 0x5D5E20 VA: 0x1805D6C20
	private static IEnumerator Flash(CrystalBehaviour c, float delay) { }

	// RVA: 0x5D6FC0 Offset: 0x5D61C0 VA: 0x1805D6FC0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CrystalMinigame.<>c // TypeDefIndex: 1077
{
	// Fields
	public static readonly CrystalMinigame.<>c <>9; // 0x0
	public static Func<CrystalBehaviour, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x5E6980 Offset: 0x5E5B80 VA: 0x1805E6980
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E63F0 Offset: 0x5E55F0 VA: 0x1805E63F0
	internal bool <CheckSolution>b__14_0(CrystalBehaviour c) { }
}

// Namespace: 
public class CrystalMinigame : Minigame // TypeDefIndex: 1078
{
	// Fields
	public CrystalBehaviour[] CrystalPieces; // 0x88
	private CrystalBehaviour[] Shuffed; // 0x90
	public Transform[] CrystalSlots; // 0x98
	public FloatRange XRange; // 0xA0
	public float TrayY; // 0xA8
	public AudioClip[] PickUpSounds; // 0xB0
	public AudioClip AttachSound; // 0xB8
	private Controller myController; // 0xC0
	private bool prevHadStick; // 0xC8
	private bool prevHadButton; // 0xC9
	private int prevSelectedCrystal; // 0xCC
	private int selectedCrystal; // 0xD0

	// Methods

	// RVA: 0x5D75A0 Offset: 0x5D67A0 VA: 0x1805D75A0
	public void Start() { }

	// RVA: 0x5D7790 Offset: 0x5D6990 VA: 0x1805D7790
	public void Update() { }

	// RVA: 0x5D6FE0 Offset: 0x5D61E0 VA: 0x1805D6FE0
	private void CheckSolution(int startAt) { }

	// RVA: 0x5D84A0 Offset: 0x5D76A0 VA: 0x1805D84A0
	public void .ctor() { }
}

// Namespace: 
public enum SortGameObject.ObjType // TypeDefIndex: 1079
{
	// Fields
	public int value__; // 0x0
	public const SortGameObject.ObjType Plant = 0;
	public const SortGameObject.ObjType Mineral = 1;
	public const SortGameObject.ObjType Animal = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class SortGameObject.<CoShadowFall>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1080
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool inBox; // 0x20
	public SortGameObject <>4__this; // 0x28
	public AudioClip dropSound; // 0x30
	private float <timer>5__2; // 0x38

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

	// RVA: 0x5E3A10 Offset: 0x5E2C10 VA: 0x1805E3A10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E3D20 Offset: 0x5E2F20 VA: 0x1805E3D20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SortGameObject.<CoShadowRise>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1081
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SortGameObject <>4__this; // 0x20
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

	// RVA: 0x5E3D60 Offset: 0x5E2F60 VA: 0x1805E3D60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E3EF0 Offset: 0x5E30F0 VA: 0x1805E3EF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SortGameObject : MonoBehaviour // TypeDefIndex: 1082
{
	// Fields
	public SortGameObject.ObjType MyType; // 0x20
	public Collider2D Collider; // 0x28
	public SpriteRenderer Image; // 0x30
	public SpriteRenderer Shadow; // 0x38
	private const float ShadowTime = 0,15;

	// Methods

	[IteratorStateMachine(typeof(SortGameObject.<CoShadowRise>d__6))]
	// RVA: 0x5E1830 Offset: 0x5E0A30 VA: 0x1805E1830
	public IEnumerator CoShadowRise() { }

	[IteratorStateMachine(typeof(SortGameObject.<CoShadowFall>d__7))]
	// RVA: 0x5E17B0 Offset: 0x5E09B0 VA: 0x1805E17B0
	public IEnumerator CoShadowFall(bool inBox, AudioClip dropSound) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SortMinigame : Minigame // TypeDefIndex: 1083
{
	// Fields
	public SortGameObject[] Objects; // 0x88
	public BoxCollider2D AnimalBox; // 0x90
	public BoxCollider2D PlantBox; // 0x98
	public BoxCollider2D MineralBox; // 0xA0
	public AudioClip[] PickUpSounds; // 0xA8
	public AudioClip[] DropSounds; // 0xB0
	private Controller myController; // 0xB8
	public Transform selectorObject; // 0xC0
	public SpriteRenderer selectorHand; // 0xC8
	private bool prevHadButton; // 0xD0
	private int currentlyGrabbedObject; // 0xD4

	// Methods

	// RVA: 0x5E1A70 Offset: 0x5E0C70 VA: 0x1805E1A70
	public void Start() { }

	// RVA: 0x5E1D20 Offset: 0x5E0F20 VA: 0x1805E1D20
	public void Update() { }

	// RVA: 0x5E1890 Offset: 0x5E0A90 VA: 0x1805E1890
	private bool CheckBox(SortGameObject obj, bool dropped) { }

	// RVA: 0x5E2A10 Offset: 0x5E1C10 VA: 0x1805E2A10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DiagnosticGame.<>c // TypeDefIndex: 1084
{
	// Fields
	public static readonly DiagnosticGame.<>c <>9; // 0x0
	public static Action<SpriteRenderer> <>9__19_0; // 0x8
	public static Action<SpriteRenderer> <>9__19_1; // 0x10

	// Methods

	// RVA: 0x5E6A40 Offset: 0x5E5C40 VA: 0x1805E6A40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x58A8F0 Offset: 0x589AF0 VA: 0x18058A8F0
	internal void <Update>b__19_0(SpriteRenderer f) { }

	// RVA: 0x58A8F0 Offset: 0x589AF0 VA: 0x18058A8F0
	internal void <Update>b__19_1(SpriteRenderer f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiagnosticGame.<BlinkButton>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1085
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DiagnosticGame <>4__this; // 0x20

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

	// RVA: 0x5E38A0 Offset: 0x5E2AA0 VA: 0x1805E38A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E39D0 Offset: 0x5E2BD0 VA: 0x1805E39D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class DiagnosticGame : Minigame // TypeDefIndex: 1086
{
	// Fields
	public VerticalGauge Gauge; // 0x88
	public SpriteRenderer StartButton; // 0x90
	public float TimePerStep; // 0x98
	public TextMeshPro Text; // 0xA0
	private int TargetNum; // 0xA8
	public SpriteRenderer[] Targets; // 0xB0
	private Color goodBarColor; // 0xB8
	public AudioClip StartSound; // 0xC8
	public AudioClip CorrectSound; // 0xD0
	public AudioClip TickSound; // 0xD8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xE0
	public UiElement DefaultButtonSelected; // 0xE8
	public List<UiElement> ControllerSelectable; // 0xF0
	private int lastPercent; // 0xF8

	// Methods

	// RVA: 0x5D8710 Offset: 0x5D7910 VA: 0x1805D8710
	private void OnDisable() { }

	// RVA: 0x5D8520 Offset: 0x5D7720 VA: 0x1805D8520 Slot: 5
	public override void Begin(PlayerTask task) { }

	[IteratorStateMachine(typeof(DiagnosticGame.<BlinkButton>d__15))]
	// RVA: 0x5D86B0 Offset: 0x5D78B0 VA: 0x1805D86B0
	private IEnumerator BlinkButton() { }

	// RVA: 0x5D8780 Offset: 0x5D7980 VA: 0x1805D8780
	public void PickAnomaly(int num) { }

	// RVA: 0x5D88E0 Offset: 0x5D7AE0 VA: 0x1805D88E0
	public void StartDiagnostic() { }

	// RVA: 0x5D8A90 Offset: 0x5D7C90 VA: 0x1805D8A90
	public void Update() { }

	// RVA: 0x5D8FF0 Offset: 0x5D81F0 VA: 0x1805D8FF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5D8A30 Offset: 0x5D7C30 VA: 0x1805D8A30
	private void <Update>b__19_2(SpriteRenderer f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KeypadGame.<Animate>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1087
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KeypadGame <>4__this; // 0x20
	private WaitForSeconds <wait>5__2; // 0x28
	private string <okStr>5__3; // 0x30

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

	// RVA: 0x5E3230 Offset: 0x5E2430 VA: 0x1805E3230 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E3820 Offset: 0x5E2A20 VA: 0x1805E3820 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KeypadGame.<BlinkAccept>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1088
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KeypadGame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x573D80 Offset: 0x572F80 VA: 0x180573D80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E3860 Offset: 0x5E2A60 VA: 0x1805E3860 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class KeypadGame : Minigame // TypeDefIndex: 1089
{
	// Fields
	public TextMeshPro TargetText; // 0x88
	public TextMeshPro NumberText; // 0x90
	public int number; // 0x98
	public string numString; // 0xA0
	private bool animating; // 0xA8
	public SpriteRenderer AcceptButton; // 0xB0
	private LifeSuppSystemType system; // 0xB8
	private NoOxyTask oxyTask; // 0xC0
	private bool done; // 0xC8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xD0
	public UiElement DefaultButtonSelected; // 0xD8
	public List<UiElement> ControllerSelectable; // 0xE0

	// Methods

	// RVA: 0x5D9770 Offset: 0x5D8970 VA: 0x1805D9770
	private void OnDisable() { }

	// RVA: 0x5D9180 Offset: 0x5D8380 VA: 0x1805D9180 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x5D95D0 Offset: 0x5D87D0 VA: 0x1805D95D0
	public void ClickNumber(int i) { }

	[IteratorStateMachine(typeof(KeypadGame.<BlinkAccept>d__15))]
	// RVA: 0x5D94D0 Offset: 0x5D86D0 VA: 0x1805D94D0
	private IEnumerator BlinkAccept() { }

	// RVA: 0x5D9530 Offset: 0x5D8730 VA: 0x1805D9530
	public void ClearEntry() { }

	// RVA: 0x5D9700 Offset: 0x5D8900 VA: 0x1805D9700
	public void Enter() { }

	[IteratorStateMachine(typeof(KeypadGame.<Animate>d__18))]
	// RVA: 0x5D9120 Offset: 0x5D8320 VA: 0x1805D9120
	private IEnumerator Animate() { }

	// RVA: 0x5D97E0 Offset: 0x5D89E0 VA: 0x1805D97E0
	public void .ctor() { }
}

// Namespace: 
public class LeafBehaviour : MonoBehaviour // TypeDefIndex: 1090
{
	// Fields
	public Sprite[] Images; // 0x20
	public FloatRange SpinSpeed; // 0x28
	public Vector2Range StartVel; // 0x30
	public float AccelRate; // 0x40
	[HideInInspector]
	public LeafMinigame Parent; // 0x48
	public bool Held; // 0x50
	private static RandomFill<Sprite> ImageFiller; // 0x0
	[HideInInspector]
	public Rigidbody2D body; // 0x58

	// Methods

	// RVA: 0x5D9890 Offset: 0x5D8A90 VA: 0x1805D9890
	public void Start() { }

	// RVA: 0x5D9830 Offset: 0x5D8A30 VA: 0x1805D9830
	public void FixedUpdate() { }

	// RVA: 0x5D9B40 Offset: 0x5D8D40 VA: 0x1805D9B40
	public void .ctor() { }

	// RVA: 0x5D9AD0 Offset: 0x5D8CD0 VA: 0x1805D9AD0
	private static void .cctor() { }
}

// Namespace: 
public class LeafMinigame : Minigame // TypeDefIndex: 1091
{
	// Fields
	public LeafBehaviour LeafPrefab; // 0x88
	public Vector2Range ValidArea; // 0x90
	public SpriteAnim[] Arrows; // 0xA0
	public AnimationClip[] Inactive; // 0xA8
	public AnimationClip[] Active; // 0xB0
	public AnimationClip[] Complete; // 0xB8
	private Collider2D[] Leaves; // 0xC0
	public AudioClip[] LeaveSounds; // 0xC8
	public AudioClip[] SuckSounds; // 0xD0
	private Controller myController; // 0xD8
	public Transform interactionCursor; // 0xE0
	public Transform interactionCursorCenterDot; // 0xE8
	private Collider2D[] overlapResults; // 0xF0
	private bool prevHadOverlaps; // 0xF8
	private bool prevRightStickInput; // 0xF9

	// Methods

	// RVA: 0x5D9BC0 Offset: 0x5D8DC0 VA: 0x1805D9BC0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x5D9E20 Offset: 0x5D9020 VA: 0x1805D9E20
	public void FixedUpdate() { }

	// RVA: 0x5DAAE0 Offset: 0x5D9CE0 VA: 0x1805DAAE0
	public void LeafDone(LeafBehaviour leaf) { }

	// RVA: 0x5DAD90 Offset: 0x5D9F90 VA: 0x1805DAD90
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LobbyInviteBar.<>c // TypeDefIndex: 1092
{
	// Fields
	public static readonly LobbyInviteBar.<>c <>9; // 0x0
	public static Action<ResponseState, Response<ResponseFriendsListRequest>> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x5E6920 Offset: 0x5E5B20 VA: 0x1805E6920
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E6460 Offset: 0x5E5660 VA: 0x1805E6460
	internal void <DenyLobbyInvite>b__4_0(ResponseState cb, Response<ResponseFriendsListRequest> response) { }
}

// Namespace: 
public class LobbyInviteBar : FriendsListBar // TypeDefIndex: 1093
{
	// Fields
	private string roomCode; // 0x80
	private bool hasAccepted; // 0x88

	// Methods

	// RVA: 0x5DB160 Offset: 0x5DA360 VA: 0x1805DB160
	public void SetUp(string puid, FriendsListUI parentUI, string roomCode, string friendCode, string playerName) { }

	// RVA: 0x5DAF70 Offset: 0x5DA170 VA: 0x1805DAF70
	public void PressAccept() { }

	// RVA: 0x5DADF0 Offset: 0x5D9FF0 VA: 0x1805DADF0
	public void DenyLobbyInvite() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AdDataCollectScreen.<Show>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1094
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AdDataCollectScreen <>4__this; // 0x20

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

	// RVA: 0x5E5DA0 Offset: 0x5E4FA0 VA: 0x1805E5DA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E5EE0 Offset: 0x5E50E0 VA: 0x1805E5EE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class AdDataCollectScreen : MonoBehaviour // TypeDefIndex: 1095
{
	// Methods

	// RVA: 0x5D0600 Offset: 0x5CF800 VA: 0x1805D0600
	public void ForceShow() { }

	[IteratorStateMachine(typeof(AdDataCollectScreen.<Show>d__1))]
	// RVA: 0x5D0880 Offset: 0x5CFA80 VA: 0x1805D0880
	public IEnumerator Show() { }

	// RVA: 0x5D08E0 Offset: 0x5CFAE0 VA: 0x1805D08E0
	public void Update() { }

	// RVA: 0x5D05B0 Offset: 0x5CF7B0 VA: 0x1805D05B0
	public void Close() { }

	// RVA: 0x5D0790 Offset: 0x5CF990 VA: 0x1805D0790
	public void SetPersonalized() { }

	// RVA: 0x5D06A0 Offset: 0x5CF8A0 VA: 0x1805D06A0
	public void SetNonPersonalized() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AgeGateScreen.<Show>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1096
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AgeGateScreen <>4__this; // 0x20

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

	// RVA: 0x5E5F20 Offset: 0x5E5120 VA: 0x1805E5F20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E6240 Offset: 0x5E5440 VA: 0x1805E6240 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class AgeGateScreen : MonoBehaviour // TypeDefIndex: 1097
{
	// Fields
	[SerializeField]
	private GameObject EnterDateScreen; // 0x20
	[SerializeField]
	private GameObject MoreInfoScreen; // 0x28
	[SerializeField]
	private GameObject VerifyScreen; // 0x30
	[SerializeField]
	private Color DefaultColor; // 0x38
	[SerializeField]
	private Color FilledColor; // 0x48
	[SerializeField]
	private TextMeshPro privacyInfoText; // 0x58
	[SerializeField]
	private TextMeshPro monthText; // 0x60
	[SerializeField]
	private TextMeshPro dayText; // 0x68
	[SerializeField]
	private TextMeshPro yearText; // 0x70
	[SerializeField]
	private TextMeshPro fullDateText; // 0x78
	private List<SelectableHyperLink> selectableHyperLinks; // 0x80
	private string defaultMonthText; // 0x88
	private string defaultDayText; // 0x90
	private string defaultYearText; // 0x98
	public int Day; // 0xA0
	public int Month; // 0xA4
	public int Year; // 0xA8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xB0
	public UiElement DefaultSelection; // 0xB8
	public List<UiElement> selectableObjects; // 0xC0

	// Methods

	// RVA: 0x5D0DC0 Offset: 0x5CFFC0 VA: 0x1805D0DC0
	private void OnDisable() { }

	// RVA: 0x5D0E30 Offset: 0x5D0030 VA: 0x1805D0E30
	private void OnEnable() { }

	[IteratorStateMachine(typeof(AgeGateScreen.<Show>d__22))]
	// RVA: 0x5D1150 Offset: 0x5D0350 VA: 0x1805D1150
	public IEnumerator Show() { }

	// RVA: 0x5D0D30 Offset: 0x5CFF30 VA: 0x1805D0D30
	public bool IsDefaultDayText(string text) { }

	// RVA: 0x5D1390 Offset: 0x5D0590 VA: 0x1805D1390
	private void Update() { }

	// RVA: 0x5D09E0 Offset: 0x5CFBE0 VA: 0x1805D09E0
	public void Close() { }

	// RVA: 0x5D0B70 Offset: 0x5CFD70 VA: 0x1805D0B70
	public void GoToVerify() { }

	// RVA: 0x5D0B30 Offset: 0x5CFD30 VA: 0x1805D0B30
	public void GoBackToEdit() { }

	// RVA: 0x5D11B0 Offset: 0x5D03B0 VA: 0x1805D11B0
	public void ToggleMoreInfo() { }

	// RVA: 0x5D0EA0 Offset: 0x5D00A0 VA: 0x1805D0EA0
	public bool ShakeIfInvalid() { }

	// RVA: 0x5D0D50 Offset: 0x5CFF50 VA: 0x1805D0D50
	private void OnDestroy() { }

	// RVA: 0x5D14E0 Offset: 0x5D06E0 VA: 0x1805D14E0
	public void .ctor() { }
}

// Namespace: 
public class AnnouncementPanel : MonoBehaviour // TypeDefIndex: 1098
{
	// Fields
	public PassiveButton PassiveButton; // 0x20
	[SerializeField]
	private TextMeshPro TitleText; // 0x28
	[SerializeField]
	private TextMeshPro DateText; // 0x30
	[SerializeField]
	private SpriteRenderer Background; // 0x38
	[SerializeField]
	private SpriteRenderer RightBorder; // 0x40
	[SerializeField]
	private SpriteRenderer NewIcon; // 0x48
	private Announcement announcement; // 0x50
	private Color32 ReadColor; // 0x90
	private Color32 SelectedColor; // 0x94

	// Properties
	public int AnnouncementNumber { get; }

	// Methods

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public int get_AnnouncementNumber() { }

	// RVA: 0x5D48F0 Offset: 0x5D3AF0 VA: 0x1805D48F0
	public void SetUp(Announcement announcement) { }

	// RVA: 0x5D4690 Offset: 0x5D3890 VA: 0x1805D4690
	public void Select() { }

	// RVA: 0x5D4AA0 Offset: 0x5D3CA0 VA: 0x1805D4AA0
	public void UnSelect() { }

	// RVA: 0x5D45C0 Offset: 0x5D37C0 VA: 0x1805D45C0
	public void MarkAsRead() { }

	// RVA: 0x5D4AE0 Offset: 0x5D3CE0 VA: 0x1805D4AE0
	public void .ctor() { }
}

// Namespace: 
public enum AnnouncementPopUp.AnnounceState // TypeDefIndex: 1099
{
	// Fields
	public int value__; // 0x0
	public const AnnouncementPopUp.AnnounceState NotStarted = 0;
	public const AnnouncementPopUp.AnnounceState Fetching = 1;
	public const AnnouncementPopUp.AnnounceState Failed = 2;
	public const AnnouncementPopUp.AnnounceState Success = 3;
	public const AnnouncementPopUp.AnnounceState Cached = 4;
}

// Namespace: 
[CompilerGenerated]
private sealed class AnnouncementPopUp.<>c__DisplayClass50_0 // TypeDefIndex: 1100
{
	// Fields
	public Announcement a; // 0x10
	public AnnouncementPanel panel; // 0x50
	public AnnouncementPopUp <>4__this; // 0x58

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E6540 Offset: 0x5E5740 VA: 0x1805E6540
	internal void <CreateAnnouncementList>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnnouncementPopUp.<>c__DisplayClass52_0 // TypeDefIndex: 1101
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E6670 Offset: 0x5E5870 VA: 0x1805E6670
	internal bool <UpdateAnnouncementText>b__0(Announcement an) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnnouncementPopUp.<DelayedUpdateHyperlinkPositions>d__48 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1102
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnnouncementPopUp <>4__this; // 0x20

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

	// RVA: 0x5E3F30 Offset: 0x5E3130 VA: 0x1805E3F30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E4000 Offset: 0x5E3200 VA: 0x1805E4000 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnnouncementPopUp.<Init>d__46 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1103
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnnouncementPopUp <>4__this; // 0x20
	public bool forceOpen; // 0x28
	private string <uri>5__2; // 0x30
	private UnityWebRequest <request>5__3; // 0x38
	private int <attempts>5__4; // 0x40

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

	// RVA: 0x5E4480 Offset: 0x5E3680 VA: 0x1805E4480 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E4ED0 Offset: 0x5E40D0 VA: 0x1805E4ED0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnnouncementPopUp.<ShowIfNew>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1104
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnnouncementPopUp <>4__this; // 0x20
	public Action onDismissed; // 0x28

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

	// RVA: 0x5E5840 Offset: 0x5E4A40 VA: 0x1805E5840 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E5980 Offset: 0x5E4B80 VA: 0x1805E5980 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class AnnouncementPopUp : MonoBehaviour // TypeDefIndex: 1105
{
	// Fields
	[CompilerGenerated]
	private Action ActionOnDisable; // 0x20
	[CompilerGenerated]
	private Action ActionOnEnable; // 0x28
	private const float PANEL_HEIGHT = 0,8;
	private const float SCROLL_OFFSET = 2,512;
	private MainMenuManager mainMenuManager; // 0x30
	private static AnnouncementPopUp.AnnounceState UpdateState; // 0x0
	[SerializeField]
	private GameObject ConnectIcon; // 0x38
	[SerializeField]
	private AnnouncementPanel AnnouncementPanelPrefab; // 0x40
	[SerializeField]
	private TextMeshPro Title; // 0x48
	[SerializeField]
	private TextMeshPro SubTitle; // 0x50
	[SerializeField]
	private TextMeshPro DateString; // 0x58
	[SerializeField]
	private TextMeshPro AnnouncementBodyText; // 0x60
	[SerializeField]
	private GameObject AnnouncementListSlider; // 0x68
	[SerializeField]
	private Scroller TextScroller; // 0x70
	[SerializeField]
	private Scroller ListScroller; // 0x78
	[SerializeField]
	private ManualScrollHelper ManualScrollHelper; // 0x80
	[SerializeField]
	private AnnouncementPanel ErrorPanel; // 0x88
	[SerializeField]
	private GameObject ListStateHUD; // 0x90
	[SerializeField]
	private GameObject ReadingStateHUD; // 0x98
	[SerializeField]
	private NewsCountButton NewsCountButton; // 0xA0
	private const string READING_STATE_NAME = "Reading";
	private Vector3 panelStartPos; // 0xA8
	private int newestAnnouncement; // 0xB4
	private List<AnnouncementPanel> visibleAnnouncements; // 0xB8
	private AnnouncementPanel selectedPanel; // 0xC0
	private int selectedIndex; // 0xC8
	private Action OnDismissed; // 0xD0
	private readonly Logger logger; // 0xD8
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xE0
	public UiElement ReadingBackButton; // 0xE8
	private List<SelectableHyperLink> selectableHyperLinks; // 0xF0
	private bool readingAnnouncement; // 0xF8

	// Methods

	[CompilerGenerated]
	// RVA: 0x5D6920 Offset: 0x5D5B20 VA: 0x1805D6920
	public void add_ActionOnDisable(Action value) { }

	[CompilerGenerated]
	// RVA: 0x5D6A60 Offset: 0x5D5C60 VA: 0x1805D6A60
	public void remove_ActionOnDisable(Action value) { }

	[CompilerGenerated]
	// RVA: 0x5D69C0 Offset: 0x5D5BC0 VA: 0x1805D69C0
	public void add_ActionOnEnable(Action value) { }

	[CompilerGenerated]
	// RVA: 0x5D6B00 Offset: 0x5D5D00 VA: 0x1805D6B00
	public void remove_ActionOnEnable(Action value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void SetMainMenuManager(MainMenuManager mainMenu) { }

	// RVA: 0x5D5520 Offset: 0x5D4720 VA: 0x1805D5520
	private static bool IsSuccess(AnnouncementPopUp.AnnounceState state) { }

	// RVA: 0x5D5690 Offset: 0x5D4890 VA: 0x1805D5690
	private void OnEnable() { }

	// RVA: 0x5D55A0 Offset: 0x5D47A0 VA: 0x1805D55A0
	private void OnDisable() { }

	// RVA: 0x5D4B10 Offset: 0x5D3D10 VA: 0x1805D4B10
	public static void ClearAnnouncementCache() { }

	[IteratorStateMachine(typeof(AnnouncementPopUp.<ShowIfNew>d__42))]
	// RVA: 0x5D5B50 Offset: 0x5D4D50 VA: 0x1805D5B50
	public IEnumerator ShowIfNew(Action onDismissed) { }

	// RVA: 0x5D5BC0 Offset: 0x5D4DC0 VA: 0x1805D5BC0
	public void Show() { }

	// RVA: 0x5D5890 Offset: 0x5D4A90 VA: 0x1805D5890
	private void SetMenu() { }

	// RVA: 0x5D4CC0 Offset: 0x5D3EC0 VA: 0x1805D4CC0
	public void Close() { }

	[IteratorStateMachine(typeof(AnnouncementPopUp.<Init>d__46))]
	// RVA: 0x5D54B0 Offset: 0x5D46B0 VA: 0x1805D54B0
	private IEnumerator Init(bool forceOpen) { }

	// RVA: 0x5D57A0 Offset: 0x5D49A0 VA: 0x1805D57A0
	public void ReturnToList() { }

	[IteratorStateMachine(typeof(AnnouncementPopUp.<DelayedUpdateHyperlinkPositions>d__48))]
	// RVA: 0x5D5450 Offset: 0x5D4650 VA: 0x1805D5450
	private IEnumerator DelayedUpdateHyperlinkPositions() { }

	// RVA: 0x5D4B50 Offset: 0x5D3D50 VA: 0x1805D4B50
	private void ClearAnnouncements() { }

	// RVA: 0x5D4D60 Offset: 0x5D3F60 VA: 0x1805D4D60
	private void CreateAnnouncementList() { }

	// RVA: 0x5D5980 Offset: 0x5D4B80 VA: 0x1805D5980
	private void ShowError() { }

	// RVA: 0x5D5CB0 Offset: 0x5D4EB0 VA: 0x1805D5CB0
	private void UpdateAnnouncementText(int id, bool previewOnly = False) { }

	// RVA: 0x5D5530 Offset: 0x5D4730 VA: 0x1805D5530
	private void OnDestroy() { }

	// RVA: 0x5D65B0 Offset: 0x5D57B0 VA: 0x1805D65B0
	private void Update() { }

	// RVA: 0x5D67B0 Offset: 0x5D59B0 VA: 0x1805D67B0
	public void .ctor() { }
}

// Namespace: 
public class DoNotPressButton : MonoBehaviour // TypeDefIndex: 1106
{
	// Fields
	[SerializeField]
	private PlayerParticles particleManager; // 0x20
	[SerializeField]
	private AudioClip ejectSound; // 0x28
	[SerializeField]
	private SpriteRenderer pressedSprite; // 0x30
	[SerializeField]
	private SpriteRenderer unpressedSprite; // 0x38

	// Methods

	// RVA: 0x5D90A0 Offset: 0x5D82A0 VA: 0x1805D90A0
	public void EjectCrewmate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MainMenuManager.<>c // TypeDefIndex: 1107
{
	// Fields
	public static readonly MainMenuManager.<>c <>9; // 0x0
	public static Func<StoreTabButton, bool> <>9__66_0; // 0x8
	public static Action <>9__67_0; // 0x10
	public static UnityAction <>9__76_0; // 0x18

	// Methods

	// RVA: 0x5E69E0 Offset: 0x5E5BE0 VA: 0x1805E69E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E6280 Offset: 0x5E5480 VA: 0x1805E6280
	internal bool <CheckNewItems>b__66_0(StoreTabButton t) { }

	// RVA: 0x5E64F0 Offset: 0x5E56F0 VA: 0x1805E64F0
	internal void <RunStartUp>b__67_0() { }

	// RVA: 0x5E6410 Offset: 0x5E5610 VA: 0x1805E6410
	internal void <ConnectMainMenuScreenButtonEvents>b__76_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainMenuManager.<AnimateEnterCodeExitSlideCo>d__61 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1108
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MainMenuManager <>4__this; // 0x20
	private Vector2 <startPosOnline>5__2; // 0x28
	private Vector2 <endPosOnline>5__3; // 0x30

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

	// RVA: 0x5E2A80 Offset: 0x5E1C80 VA: 0x1805E2A80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E2E20 Offset: 0x5E2020 VA: 0x1805E2E20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainMenuManager.<AnimateEnterCodeSlideCo>d__59 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1109
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MainMenuManager <>4__this; // 0x20
	private Vector2 <startPosEnterCode>5__2; // 0x28
	private Vector2 <endPosEnterCode>5__3; // 0x30

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

	// RVA: 0x5E2E60 Offset: 0x5E2060 VA: 0x1805E2E60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E31F0 Offset: 0x5E23F0 VA: 0x1805E31F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainMenuManager.<GoBackCreateGameCo>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1110
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MainMenuManager <>4__this; // 0x20

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

	// RVA: 0x5E4310 Offset: 0x5E3510 VA: 0x1805E4310 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E4440 Offset: 0x5E3640 VA: 0x1805E4440 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainMenuManager.<RunStartUp>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1111
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MainMenuManager <>4__this; // 0x20

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

	// RVA: 0x5E4F10 Offset: 0x5E4110 VA: 0x1805E4F10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E5640 Offset: 0x5E4840 VA: 0x1805E5640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainMenuManager.<ShowCreateGameCo>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1112
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MainMenuManager <>4__this; // 0x20

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

	// RVA: 0x5E5680 Offset: 0x5E4880 VA: 0x1805E5680 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E5800 Offset: 0x5E4A00 VA: 0x1805E5800 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultExecutionOrder(-1)]
public class MainMenuManager : MonoBehaviour // TypeDefIndex: 1113
{
	// Fields
	public AdDataCollectScreen AdsPolicy; // 0x20
	public PassiveButton PlayOnlineButton; // 0x28
	public HatManager HatManagerRef; // 0x30
	public CosmicubeManager CosmicubeManagerRef; // 0x38
	public PlayerCustomizationMenu playerCustomizationPrefab; // 0x40
	[SerializeField]
	private AnnouncementPopUp announcementPopUp; // 0x48
	[SerializeField]
	private GameObject gameModeButtons; // 0x50
	[SerializeField]
	private GameObject accountButtons; // 0x58
	[SerializeField]
	private PassiveButton accountStatsButton; // 0x60
	[SerializeField]
	private GameObject onlineButtons; // 0x68
	[SerializeField]
	private PassiveButton backButtonOnline; // 0x70
	[SerializeField]
	private GameObject enterCodeButtons; // 0x78
	[SerializeField]
	private SpriteMask screenMask; // 0x80
	[SerializeField]
	private GameObject mainMenuUI; // 0x88
	[SerializeField]
	private GameObject rightPanelMask; // 0x90
	[SerializeField]
	private SpriteRenderer screenTint; // 0x98
	[SerializeField]
	private PassiveButton freePlayButton; // 0xA0
	[SerializeField]
	private PassiveButton entercodeField; // 0xA8
	[SerializeField]
	[Header("Left panel buttons")]
	private PassiveButton playButton; // 0xB0
	[SerializeField]
	private PassiveButton inventoryButton; // 0xB8
	[SerializeField]
	private PassiveButton shopButton; // 0xC0
	[SerializeField]
	private PassiveButton myAccountButton; // 0xC8
	[SerializeField]
	private PassiveButton newsButton; // 0xD0
	[SerializeField]
	private PassiveButton settingsButton; // 0xD8
	[SerializeField]
	private PassiveButton creditsButton; // 0xE0
	[SerializeField]
	private PassiveButton quitButton; // 0xE8
	[SerializeField]
	private FindGameButton findGameButton; // 0xF0
	[Header("Default right panel buttons")]
	[SerializeField]
	private PassiveButton playLocalButton; // 0xF8
	[SerializeField]
	private PassiveButton howToPlayButton; // 0x100
	[SerializeField]
	private PassiveButton accountCTAButton; // 0x108
	[SerializeField]
	private PassiveButton createGameButton; // 0x110
	private List<PassiveButton> mainButtons; // 0x118
	[SerializeField]
	private GameObject creditsScreen; // 0x120
	[SerializeField]
	private CreateGameOptions createGameScreen; // 0x128
	[SerializeField]
	private SpriteRenderer fullScreenSprite; // 0x130
	[Header("Animations")]
	[SerializeField]
	private Transform enterCodeContainer; // 0x138
	[SerializeField]
	private GameObject enterCodeHeader; // 0x140
	[SerializeField]
	private Transform onlineButtonsContainer; // 0x148
	[SerializeField]
	private GameObject onlineHeader; // 0x150
	private const float TIME_SLIDE = 0,3;
	private const float X_OFFSCREEN_LEFT = -8;
	private const float X_OFFSCREEN_RIGHT = 7;
	[Header("Console Controller Navigation")]
	public UiElement DefaultButtonSelected; // 0x158
	public List<UiElement> ControllerSelectable; // 0x160
	public List<PassiveButton> disableOnStartup; // 0x168
	[SerializeField]
	private GameObject NewStoreItemsIcon; // 0x170
	private CosmicubeManager cosmicubeManager; // 0x178
	private bool animating; // 0x180
	private bool finishStartup; // 0x181

	// Methods

	// RVA: 0x5DB2B0 Offset: 0x5DA4B0 VA: 0x1805DB2B0
	private void Awake() { }

	// RVA: 0x5DCC20 Offset: 0x5DBE20 VA: 0x1805DCC20
	public void Start() { }

	// RVA: 0x5DC720 Offset: 0x5DB920 VA: 0x1805DC720
	public void ResetScreen() { }

	// RVA: 0x5DC400 Offset: 0x5DB600 VA: 0x1805DC400
	public void OpenGameModeMenu() { }

	// RVA: 0x5DBF30 Offset: 0x5DB130 VA: 0x1805DBF30
	public void OpenCreateGame() { }

	[IteratorStateMachine(typeof(MainMenuManager.<ShowCreateGameCo>d__54))]
	// RVA: 0x5DCBC0 Offset: 0x5DBDC0 VA: 0x1805DCBC0
	private IEnumerator ShowCreateGameCo() { }

	// RVA: 0x5DBC60 Offset: 0x5DAE60 VA: 0x1805DBC60
	public void GoBackCreateGame() { }

	[IteratorStateMachine(typeof(MainMenuManager.<GoBackCreateGameCo>d__56))]
	// RVA: 0x5DBC00 Offset: 0x5DAE00 VA: 0x1805DBC00
	private IEnumerator GoBackCreateGameCo() { }

	// RVA: 0x5DC560 Offset: 0x5DB760 VA: 0x1805DC560
	public void OpenOnlineMenu() { }

	// RVA: 0x5DC140 Offset: 0x5DB340 VA: 0x1805DC140
	public void OpenEnterCodeMenu(bool animate) { }

	[IteratorStateMachine(typeof(MainMenuManager.<AnimateEnterCodeSlideCo>d__59))]
	// RVA: 0x5DB250 Offset: 0x5DA450 VA: 0x1805DB250
	private IEnumerator AnimateEnterCodeSlideCo() { }

	// RVA: 0x5DB940 Offset: 0x5DAB40 VA: 0x1805DB940
	public void ClickBackEnterCode() { }

	[IteratorStateMachine(typeof(MainMenuManager.<AnimateEnterCodeExitSlideCo>d__61))]
	// RVA: 0x5DB1F0 Offset: 0x5DA3F0 VA: 0x1805DB1F0
	private IEnumerator AnimateEnterCodeExitSlideCo() { }

	// RVA: 0x5DB9B0 Offset: 0x5DABB0 VA: 0x1805DB9B0
	public void ClickBackOnline() { }

	// RVA: 0x5DC3D0 Offset: 0x5DB5D0 VA: 0x1805DC3D0
	public void OpenFindGame() { }

	// RVA: 0x5DBE50 Offset: 0x5DB050 VA: 0x1805DBE50
	public void OpenAccountMenu() { }

	// RVA: 0x5DC0F0 Offset: 0x5DB2F0 VA: 0x1805DC0F0
	public void OpenCredits() { }

	// RVA: 0x5DB7F0 Offset: 0x5DA9F0 VA: 0x1805DB7F0
	public void CheckNewItems() { }

	[IteratorStateMachine(typeof(MainMenuManager.<RunStartUp>d__67))]
	// RVA: 0x5DC980 Offset: 0x5DBB80 VA: 0x1805DC980
	private IEnumerator RunStartUp() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void CheckAddOns() { }

	// RVA: 0x5DBD00 Offset: 0x5DAF00 VA: 0x1805DBD00
	private void LateUpdate() { }

	// RVA: 0x5DCEE0 Offset: 0x5DC0E0 VA: 0x1805DCEE0
	public void TransitionToInventory() { }

	// RVA: 0x5DD150 Offset: 0x5DC350 VA: 0x1805DD150
	public void TransitionToShop() { }

	// RVA: 0x5DBCD0 Offset: 0x5DAED0 VA: 0x1805DBCD0
	public bool IsMainMenuActive() { }

	// RVA: 0x5DB1C0 Offset: 0x5DA3C0 VA: 0x1805DB1C0
	private void ActivateMainMenuUI() { }

	// RVA: 0x5DBB00 Offset: 0x5DAD00 VA: 0x1805DBB00
	private void DeactivateMainMenuUI() { }

	// RVA: 0x5DC9E0 Offset: 0x5DBBE0 VA: 0x1805DC9E0
	private void SetUpControllerNav() { }

	// RVA: 0x5DB9D0 Offset: 0x5DABD0 VA: 0x1805DB9D0
	private void ConnectMainMenuScreenButtonEvents() { }

	// RVA: 0x5DD390 Offset: 0x5DC590 VA: 0x1805DD390
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5DD330 Offset: 0x5DC530 VA: 0x1805DD330
	private void <Start>b__50_0() { }

	[CompilerGenerated]
	// RVA: 0x5DD360 Offset: 0x5DC560 VA: 0x1805DD360
	private void <Start>b__50_1() { }
}

// Namespace: 
public class ModManager : DestroyableSingleton<ModManager> // TypeDefIndex: 1114
{
	// Fields
	public SpriteRenderer ModStamp; // 0x28
	public Camera localCamera; // 0x30

	// Methods

	// RVA: 0x5DD760 Offset: 0x5DC960 VA: 0x1805DD760
	public void ShowModStamp() { }

	// RVA: 0x5DD5D0 Offset: 0x5DC7D0 VA: 0x1805DD5D0
	private void LateUpdate() { }

	// RVA: 0x5DD790 Offset: 0x5DC990 VA: 0x1805DD790
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NewRequestBanner.<>c__DisplayClass5_0 // TypeDefIndex: 1115
{
	// Fields
	public int totalCount; // 0x10
	public NewRequestBanner <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E6680 Offset: 0x5E5880 VA: 0x1805E6680
	internal void <Update>b__0(TextMeshPro t) { }

	// RVA: 0x5E67A0 Offset: 0x5E59A0 VA: 0x1805E67A0
	internal void <Update>b__1(TextMeshPro t) { }
}

// Namespace: 
public class NewRequestBanner : MonoBehaviour // TypeDefIndex: 1116
{
	// Fields
	[SerializeField]
	private GameObject activeBanner; // 0x20
	[SerializeField]
	private GameObject inactiveBanner; // 0x28
	[SerializeField]
	private SpriteRenderer parentRenderer; // 0x30
	[SerializeField]
	private SpriteRenderer ourSprite; // 0x38
	[SerializeField]
	private TextMeshPro[] notifText; // 0x40

	// Methods

	// RVA: 0x5DD7D0 Offset: 0x5DC9D0 VA: 0x1805DD7D0
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class NewsCountButton : MonoBehaviour // TypeDefIndex: 1117
{
	// Fields
	[SerializeField]
	private TextMeshPro countText; // 0x20
	[SerializeField]
	private GameObject notifIcon; // 0x28

	// Methods

	// RVA: 0x5DDC20 Offset: 0x5DCE20 VA: 0x1805DDC20
	private void Start() { }

	// RVA: 0x5DDB60 Offset: 0x5DCD60 VA: 0x1805DDB60
	private void OnDestroy() { }

	// RVA: 0x5DDCF0 Offset: 0x5DCEF0 VA: 0x1805DDCF0
	public void UpdateCountText() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerParticleInfo // TypeDefIndex: 1118
{
	// Fields
	public Sprite image; // 0x10
	public FloatRange angularVel; // 0x18
	public bool alignToVel; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class PlayerParticles : MonoBehaviour // TypeDefIndex: 1119
{
	// Fields
	public PlayerParticleInfo[] Sprites; // 0x20
	public PlayerParticleInfo[] HorseSprites; // 0x28
	public FloatRange velocity; // 0x30
	public FloatRange scale; // 0x38
	public ObjectPoolBehavior pool; // 0x40
	public float StartRadius; // 0x48
	public PoolableBehavior HorsePrefab; // 0x50
	public Camera FollowCamera; // 0x58
	private RandomFill<PlayerParticleInfo> fill; // 0x60

	// Methods

	// RVA: 0x5DE500 Offset: 0x5DD700 VA: 0x1805DE500
	public void Start() { }

	// RVA: 0x5DE6B0 Offset: 0x5DD8B0 VA: 0x1805DE6B0
	public void Update() { }

	// RVA: 0x5DDF70 Offset: 0x5DD170 VA: 0x1805DDF70
	private void PlacePlayer(PlayerParticle part, bool initial) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class PlayOnlineButtonSprite : MonoBehaviour // TypeDefIndex: 1120
{
	// Fields
	[SerializeField]
	private Sprite Colored; // 0x20
	[SerializeField]
	private Sprite Greyscale; // 0x28
	[SerializeField]
	private SpriteRenderer Sprite; // 0x30

	// Methods

	// RVA: 0x5DDEF0 Offset: 0x5DD0F0 VA: 0x1805DDEF0
	public void Start() { }

	// RVA: 0x5DDEB0 Offset: 0x5DD0B0 VA: 0x1805DDEB0
	public void SetState(bool b) { }

	// RVA: 0x5DDE50 Offset: 0x5DD050 VA: 0x1805DDE50
	public void SetColored() { }

	// RVA: 0x5DDE80 Offset: 0x5DD080 VA: 0x1805DDE80
	public void SetGreyscale() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PrivacyPolicyScreen.<Show>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1121
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PrivacyPolicyScreen <>4__this; // 0x20

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

	// RVA: 0x5E59C0 Offset: 0x5E4BC0 VA: 0x1805E59C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5E5D60 Offset: 0x5E4F60 VA: 0x1805E5D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PrivacyPolicyScreen : MonoBehaviour // TypeDefIndex: 1122
{
	// Fields
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x20
	public UiElement ManageDataButton; // 0x28
	public UiElement AcceptButton; // 0x30
	public OpenHyperlinks DefaultHyperlinkText; // 0x38
	public OpenHyperlinks PlayStationHyperlinkText; // 0x40
	public TextMeshPro PlayStationEULAText; // 0x48
	private List<ITextPart> textConstituents; // 0x50
	private List<SelectableHyperLink> selectableHyperLinks; // 0x58

	// Properties
	public OpenHyperlinks HyperLinkText { get; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public OpenHyperlinks get_HyperLinkText() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Start() { }

	// RVA: 0x5DEB50 Offset: 0x5DDD50 VA: 0x1805DEB50
	private void OnDisable() { }

	[IteratorStateMachine(typeof(PrivacyPolicyScreen.<Show>d__12))]
	// RVA: 0x5DF2D0 Offset: 0x5DE4D0 VA: 0x1805DF2D0
	public IEnumerator Show() { }

	// RVA: 0x5DEAE0 Offset: 0x5DDCE0 VA: 0x1805DEAE0
	private void DestroyGOs(ControllerUiElementsState menu) { }

	// RVA: 0x5DE840 Offset: 0x5DDA40 VA: 0x1805DE840
	private void DecomposePrivacyPolicyText(string text) { }

	// RVA: 0x5DEC50 Offset: 0x5DDE50 VA: 0x1805DEC50
	private void OnNewSelection() { }

	// RVA: 0x5DECA0 Offset: 0x5DDEA0 VA: 0x1805DECA0
	public void RecomposePrivacyPolicyText() { }

	// RVA: 0x5DEC60 Offset: 0x5DDE60 VA: 0x1805DEC60
	public void OnTextUpdated() { }

	// RVA: 0x5DE760 Offset: 0x5DD960 VA: 0x1805DE760
	public void Close() { }

	// RVA: 0x5DF330 Offset: 0x5DE530 VA: 0x1805DF330
	public void .ctor() { }
}

// Namespace: 
internal class SelectableHyperLink : MonoBehaviour, ITextPart // TypeDefIndex: 1123
{
	// Fields
	public SelectableHyperLink parentHyperlink; // 0x20
	[SerializeField]
	private UiElement HyperLink; // 0x28
	[SerializeField]
	private string selectedColor; // 0x30
	[SerializeField]
	private string unselectedColor; // 0x38
	private Action onNewSelection; // 0x40
	private string hyperLinkText; // 0x48
	private string hyperLinkUrl; // 0x50
	private string fullHyperLinkText; // 0x58

	// Properties
	public string LinkText { get; set; }
	public string TaglessLinkText { get; }
	public UiElement SelectableObject { get; }

	// Methods

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void SetSelectionCallback(Action _onNewSelection) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_LinkText() { }

	// RVA: 0x5E1150 Offset: 0x5E0350 VA: 0x1805E1150
	public void set_LinkText(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_TaglessLinkText() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public UiElement get_SelectableObject() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 4
	public string GetText() { }

	// RVA: 0x5E10E0 Offset: 0x5E02E0 VA: 0x1805E10E0
	public void RemoveUiElement(ControllerUiElementsState menu) { }

	// RVA: 0x5E0E20 Offset: 0x5E0020 VA: 0x1805E0E20
	public void AddUiElement(ControllerUiElementsState menu) { }

	// RVA: 0x5E0F80 Offset: 0x5E0180 VA: 0x1805E0F80
	public void OnSelection() { }

	// RVA: 0x5E1030 Offset: 0x5E0230 VA: 0x1805E1030
	public void OnUnselection() { }

	// RVA: 0x5E0E90 Offset: 0x5E0090 VA: 0x1805E0E90
	public void Clicked() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public interface ITextPart // TypeDefIndex: 1124
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetText();
}

// Namespace: 
internal class TextPart : ITextPart // TypeDefIndex: 1125
{
	// Fields
	private string m_text; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string text) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string GetText() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SelectableHyperLinkHelper.<>c__DisplayClass8_0 // TypeDefIndex: 1126
{
	// Fields
	public TextMeshPro tmp; // 0x10
	public List<ITextPart> textConstituents; // 0x18
	public Action <>9__0; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5E68A0 Offset: 0x5E5AA0 VA: 0x1805E68A0
	internal void <DecomposeAnnouncementText>b__0() { }
}

// Namespace: 
internal class SelectableHyperLinkHelper : MonoBehaviour // TypeDefIndex: 1127
{
	// Fields
	private static readonly Regex linkReg; // 0x0

	// Methods

	// RVA: 0x5E0720 Offset: 0x5DF920 VA: 0x1805E0720
	public static void SanitizeLinkText(string fullText, out string result) { }

	// RVA: 0x5E0010 Offset: 0x5DF210 VA: 0x1805E0010
	public static void ExtractUrl(string fullText, out string url, out string visibleTextPart) { }

	// RVA: 0x5DFA00 Offset: 0x5DEC00 VA: 0x1805DFA00
	public static void DecomposeHyperlinkText(string textToDecompose, List<ITextPart> textConstituents, List<SelectableHyperLink> selectableHyperLinks) { }

	// RVA: 0x5E0340 Offset: 0x5DF540 VA: 0x1805E0340
	private static void GetFirstUrl(string textToDecompose, out string nonUrlPart, out string urlPart) { }

	// RVA: 0x5DF3E0 Offset: 0x5DE5E0 VA: 0x1805DF3E0
	public static void AddSelectableUiForHyperlinks(List<SelectableHyperLink> selectableHyperLinks, string menuName) { }

	// RVA: 0x5DFE30 Offset: 0x5DF030 VA: 0x1805DFE30
	public static void DestroyGOs(List<SelectableHyperLink> selectableHyperLinks, string menuName) { }

	// RVA: 0x5E0800 Offset: 0x5DFA00 VA: 0x1805E0800
	public static void UpdateHyperlinkPositions(TextMeshPro tmp, List<SelectableHyperLink> selectableHyperLinks, string menuName) { }

	// RVA: 0x5DF740 Offset: 0x5DE940 VA: 0x1805DF740
	public static string DecomposeAnnouncementText(TextMeshPro tmp, List<SelectableHyperLink> selectableHyperLinks, string menuName, string text) { }

	// RVA: 0x5E04E0 Offset: 0x5DF6E0 VA: 0x1805E04E0
	public static string RecomposeAnnouncementText(List<ITextPart> textConstituents) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x5E0DA0 Offset: 0x5DFFA0 VA: 0x1805E0DA0
	private static void .cctor() { }
}

// Namespace: 
public class SignInStatusComponent : MonoBehaviour // TypeDefIndex: 1128
{
	// Fields
	private const string FRIEND_CODE_HIDDEN_TEXT = "XXXXXXXXXX";
	[SerializeField]
	private SpriteRenderer statusSprite; // 0x20
	[SerializeField]
	private SpriteRenderer glowSprite; // 0x28
	[SerializeField]
	private TextMeshPro friendCodeText; // 0x30
	[SerializeField]
	private SpriteRenderer FriendCodeHiddenIcon; // 0x38
	[SerializeField]
	private GameObject friendCodeShowToggle; // 0x40
	[SerializeField]
	private GameObject friendsButton; // 0x48
	[Header("Lights")]
	[SerializeField]
	private Sprite onlineSprite; // 0x50
	[SerializeField]
	private Sprite pendingSprite; // 0x58
	[SerializeField]
	private Sprite guestSprite; // 0x60
	[SerializeField]
	private Sprite offlineSprite; // 0x68
	[SerializeField]
	[Header("Glows")]
	private Sprite onlineGlow; // 0x70
	[SerializeField]
	private Sprite pendingGlow; // 0x78
	[SerializeField]
	private Sprite guestGlow; // 0x80

	// Methods

	// RVA: 0x5E1400 Offset: 0x5E0600 VA: 0x1805E1400
	public void SetOnline() { }

	// RVA: 0x5E1460 Offset: 0x5E0660 VA: 0x1805E1460
	public void SetPending() { }

	// RVA: 0x5E1350 Offset: 0x5E0550 VA: 0x1805E1350
	public void SetGuest() { }

	// RVA: 0x5E13B0 Offset: 0x5E05B0 VA: 0x1805E13B0
	public void SetOffline() { }

	// RVA: 0x5E14C0 Offset: 0x5E06C0 VA: 0x1805E14C0
	public void ToggleFriendCode() { }

	// RVA: 0x5E1750 Offset: 0x5E0950 VA: 0x1805E1750
	private void Update() { }

	// RVA: 0x5E1570 Offset: 0x5E0770 VA: 0x1805E1570
	private void UpdateFriendCodeUI() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ManageDataCollectionButton : MonoBehaviour // TypeDefIndex: 1129
{
	// Fields
	public GenericPopup PopupPrefab; // 0x20

	// Methods

	// RVA: 0x5DD400 Offset: 0x5DC600 VA: 0x1805DD400
	public void ManageData() { }

	// RVA: 0x5DD4B0 Offset: 0x5DC6B0 VA: 0x1805DD4B0
	private void ShowPopup(string error) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum DiscoveryState // TypeDefIndex: 1130
{
	// Fields
	public int value__; // 0x0
	public const DiscoveryState Off = 0;
	public const DiscoveryState Broadcast = 1;
}

// Namespace: 
public enum AmongUsClient.MainMenuTarget // TypeDefIndex: 1131
{
	// Fields
	public int value__; // 0x0
	public const AmongUsClient.MainMenuTarget None = 0;
	public const AmongUsClient.MainMenuTarget OnlineMenu = 1;
	public const AmongUsClient.MainMenuTarget EnterCodeMenu = 2;
	public const AmongUsClient.MainMenuTarget FindGameMenu = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AmongUsClient.<>c // TypeDefIndex: 1132
{
	// Fields
	public static readonly AmongUsClient.<>c <>9; // 0x0
	public static Predicate<IDisconnectHandler> <>9__34_0; // 0x8
	public static Action<GameObject> <>9__41_0; // 0x10

	// Methods

	// RVA: 0x5FD9A0 Offset: 0x5FCBA0 VA: 0x1805FD9A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FCDC0 Offset: 0x5FBFC0 VA: 0x1805FCDC0
	internal bool <OnGameEnd>b__34_0(IDisconnectHandler handler) { }

	// RVA: 0x5FCC50 Offset: 0x5FBE50 VA: 0x1805FCC50
	internal void <DestroyPlayerInfoObjects>b__41_0(GameObject gameObject) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass43_0 // TypeDefIndex: 1133
{
	// Fields
	public ClientData clientData; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD730 Offset: 0x5FC930 VA: 0x1805FD730
	internal bool <CreatePlayer>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass48_0 // TypeDefIndex: 1134
{
	// Fields
	public HttpMatchmakerManager.HostServer hostServer; // 0x10
	public string matchmakerToken; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD790 Offset: 0x5FC990 VA: 0x1805FD790
	internal void <CoCreateOnlineGame>b__0(HttpMatchmakerManager.HostServer host, string mmToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass49_0 // TypeDefIndex: 1135
{
	// Fields
	public string matchmakerToken; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoJoinOnlinePublicGame>b__0(string token) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass51_0 // TypeDefIndex: 1136
{
	// Fields
	public HttpMatchmakerManager.HostServer hostServer; // 0x10
	public string matchmakerToken; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD790 Offset: 0x5FC990 VA: 0x1805FD790
	internal void <CoJoinOnlineGameFromCode>b__0(HttpMatchmakerManager.HostServer host, string mmToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass52_0 // TypeDefIndex: 1137
{
	// Fields
	public Action<HttpMatchmakerManager.FindGameByCodeResponse, string> callback; // 0x10
	public string matchmakerToken; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD7A0 Offset: 0x5FC9A0 VA: 0x1805FD7A0
	internal void <CoFindGameInfoFromCode>b__0(HttpMatchmakerManager.FindGameByCodeResponse response, string mmToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass53_0 // TypeDefIndex: 1138
{
	// Fields
	public AmongUsClient <>4__this; // 0x10
	public string matchmakerToken; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD7D0 Offset: 0x5FC9D0 VA: 0x1805FD7D0
	internal void <CoFindGameInfoFromCodeAndJoin>b__0(HttpMatchmakerManager.FindGameByCodeResponse response, string mmToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<>c__DisplayClass54_0 // TypeDefIndex: 1139
{
	// Fields
	public string matchmakerToken; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoFindGame>b__0(string token) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoBroadcastManager>d__44 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1140
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	private int <lastPlayerCount>5__2; // 0x28

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

	// RVA: 0x5F66F0 Offset: 0x5F58F0 VA: 0x1805F66F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F6970 Offset: 0x5F5B70 VA: 0x1805F6970 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoConnectToGameServer>d__55 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1141
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	public string ipAddress; // 0x28
	public ushort port; // 0x30
	public MatchMakerModes mode; // 0x34
	public string matchmakerToken; // 0x38

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

	// RVA: 0x5F69B0 Offset: 0x5F5BB0 VA: 0x1805F69B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F6B80 Offset: 0x5F5D80 VA: 0x1805F6B80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoCreateOnlineGame>d__48 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1142
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	private AmongUsClient.<>c__DisplayClass48_0 <>8__1; // 0x28

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

	// RVA: 0x5F6BC0 Offset: 0x5F5DC0 VA: 0x1805F6BC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F6EB0 Offset: 0x5F60B0 VA: 0x1805F6EB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoEndGame>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1143
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

	// RVA: 0x5F6EF0 Offset: 0x5F60F0 VA: 0x1805F6EF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F6FE0 Offset: 0x5F61E0 VA: 0x1805F6FE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoFindGame>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1144
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	private AmongUsClient.<>c__DisplayClass54_0 <>8__1; // 0x28

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

	// RVA: 0x5F7620 Offset: 0x5F6820 VA: 0x1805F7620 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F7950 Offset: 0x5F6B50 VA: 0x1805F7950 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoFindGameInfoFromCode>d__52 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1145
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<HttpMatchmakerManager.FindGameByCodeResponse, string> callback; // 0x20
	public AmongUsClient <>4__this; // 0x28
	public int gameId; // 0x30
	private AmongUsClient.<>c__DisplayClass52_0 <>8__1; // 0x38

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

	// RVA: 0x5F7320 Offset: 0x5F6520 VA: 0x1805F7320 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F75E0 Offset: 0x5F67E0 VA: 0x1805F75E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoFindGameInfoFromCodeAndJoin>d__53 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1146
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	public int gameId; // 0x28
	private AmongUsClient.<>c__DisplayClass53_0 <>8__1; // 0x30

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

	// RVA: 0x5F7020 Offset: 0x5F6220 VA: 0x1805F7020 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F72E0 Offset: 0x5F64E0 VA: 0x1805F72E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoJoinOnlineGameDirect>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1147
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	public int gameId; // 0x28
	public string ipAddress; // 0x30
	public ushort port; // 0x38
	public string matchmakerToken; // 0x40

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

	// RVA: 0x5F7B60 Offset: 0x5F6D60 VA: 0x1805F7B60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F7BE0 Offset: 0x5F6DE0 VA: 0x1805F7BE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoJoinOnlineGameFromCode>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1148
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	public int gameId; // 0x28
	private AmongUsClient.<>c__DisplayClass51_0 <>8__1; // 0x30
	public bool fromEnterCode; // 0x38

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

	// RVA: 0x5F7C20 Offset: 0x5F6E20 VA: 0x1805F7C20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F7FD0 Offset: 0x5F71D0 VA: 0x1805F7FD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoJoinOnlineGameFromListing>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1149
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	public GameListing game; // 0x28
	public string matchmakerToken; // 0x78

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

	// RVA: 0x5F8010 Offset: 0x5F7210 VA: 0x1805F8010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F8230 Offset: 0x5F7430 VA: 0x1805F8230 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoJoinOnlinePublicGame>d__49 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1150
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private AmongUsClient.<>c__DisplayClass49_0 <>8__1; // 0x20
	public AmongUsClient <>4__this; // 0x28
	public AmongUsClient.MainMenuTarget targetMenu; // 0x30
	public int gameId; // 0x34
	public string ipAddress; // 0x38
	public ushort port; // 0x40

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

	// RVA: 0x5F8270 Offset: 0x5F7470 VA: 0x1805F8270 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F8460 Offset: 0x5F7660 VA: 0x1805F8460 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoOnPlayerChangedScene>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1151
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ClientData client; // 0x20
	public AmongUsClient <>4__this; // 0x28
	public string currentScene; // 0x30

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

	// RVA: 0x5F84A0 Offset: 0x5F76A0 VA: 0x1805F84A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F89C0 Offset: 0x5F7BC0 VA: 0x1805F89C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoStartGame>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1152
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20

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

	// RVA: 0x5FA8D0 Offset: 0x5F9AD0 VA: 0x1805FA8D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FBAC0 Offset: 0x5FACC0 VA: 0x1805FBAC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoStartGameClient>d__30 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1153
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	private float <timer>5__2; // 0x28
	private DateTime <start>5__3; // 0x30
	private DateTime <persistentStart>5__4; // 0x38
	private float <timeOut>5__5; // 0x40
	private bool <stopWaiting>5__6; // 0x44

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

	// RVA: 0x5F9850 Offset: 0x5F8A50 VA: 0x1805F9850 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FA030 Offset: 0x5F9230 VA: 0x1805FA030 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoStartGameHost>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1154
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20
	private DateTime <start>5__2; // 0x28

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

	// RVA: 0x5FA070 Offset: 0x5F9270 VA: 0x1805FA070 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FA890 Offset: 0x5F9A90 VA: 0x1805FA890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CoWaitForDisconnect>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1155
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AmongUsClient <>4__this; // 0x20

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

	// RVA: 0x5FBB00 Offset: 0x5FAD00 VA: 0x1805FBB00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FBC50 Offset: 0x5FAE50 VA: 0x1805FBC50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AmongUsClient.<CreatePlayer>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1156
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ClientData clientData; // 0x20
	public AmongUsClient <>4__this; // 0x28
	private AmongUsClient.<>c__DisplayClass43_0 <>8__1; // 0x30
	private bool <isOwnerOfPlayerData>5__2; // 0x38
	private PlayerControl <pc>5__3; // 0x40

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

	// RVA: 0x5FBF00 Offset: 0x5FB100 VA: 0x1805FBF00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FC750 Offset: 0x5FB950 VA: 0x1805FC750 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class AmongUsClient : InnerNetClient // TypeDefIndex: 1157
{
	// Fields
	private const int MAX_CLIENT_WAIT_SECONDS = 10;
	private const float SPAWN_TESTER_WAIT_SECONDS = 0,11;
	public static AmongUsClient Instance; // 0x0
	public string OnlineScene; // 0x120
	public string MainMenuScene; // 0x128
	public GameData GameDataPrefab; // 0x130
	public VoteBanSystem VoteBanPrefab; // 0x138
	public PlayerControl PlayerPrefab; // 0x140
	public List<AssetReference> ShipPrefabs; // 0x148
	public int TutorialMapId; // 0x150
	public float SpawnRadius; // 0x154
	public DiscoveryState discoverState; // 0x158
	public List<IDisconnectHandler> DisconnectHandlers; // 0x160
	public List<IGameListHandler> GameListHandlers; // 0x168
	public CrossplayPrivilegeErrorType CrossplayPrivilegeError; // 0x170
	public AmongUsClient.MainMenuTarget MenuTarget; // 0x174
	private readonly Logger logger; // 0x178
	private AsyncOperationHandle<GameObject> ShipLoadingAsyncHandle; // 0x180

	// Methods

	// RVA: 0x5D1610 Offset: 0x5D0810 VA: 0x1805D1610
	public void Awake() { }

	// RVA: 0x5D4420 Offset: 0x5D3620 VA: 0x1805D4420
	public void StartGame() { }

	// RVA: 0x5D4440 Offset: 0x5D3640 VA: 0x1805D4440 Slot: 6
	public override void Update() { }

	// RVA: 0x5D2270 Offset: 0x5D1470 VA: 0x1805D2270
	public void ExitGame(DisconnectReasons reason) { }

	// RVA: 0x5D3A40 Offset: 0x5D2C40 VA: 0x1805D3A40 Slot: 20
	protected override void OnGetGameList(InnerNetClient.TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse gamesResponse) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	protected override void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected override void OnGameCreated(string gameIdString) { }

	// RVA: 0x5D4340 Offset: 0x5D3540 VA: 0x1805D4340 Slot: 10
	protected override void OnWaitForHost(string gameIdString) { }

	// RVA: 0x5D1550 Offset: 0x5D0750 VA: 0x1805D1550
	protected void AbortLoadingAssets() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoStartGameHost>d__28))]
	// RVA: 0x5D1F30 Offset: 0x5D1130 VA: 0x1805D1F30
	protected IEnumerator CoStartGameHost() { }

	// RVA: 0x5D2790 Offset: 0x5D1990 VA: 0x1805D2790
	public void KickNotJoinedPlayers() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoStartGameClient>d__30))]
	// RVA: 0x5D1EC0 Offset: 0x5D10C0 VA: 0x1805D1EC0
	protected IEnumerator CoStartGameClient() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoWaitForDisconnect>d__31))]
	// RVA: 0x5D2010 Offset: 0x5D1210 VA: 0x1805D2010
	private IEnumerator CoWaitForDisconnect() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoStartGame>d__32))]
	// RVA: 0x5D1FA0 Offset: 0x5D11A0 VA: 0x1805D1FA0 Slot: 11
	protected override IEnumerator CoStartGame() { }

	// RVA: 0x5D2AE0 Offset: 0x5D1CE0 VA: 0x1805D2AE0 Slot: 13
	protected override void OnBecomeHost() { }

	// RVA: 0x5D2D40 Offset: 0x5D1F40 VA: 0x1805D2D40 Slot: 12
	protected override void OnGameEnd(EndGameResult endGameResult) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoEndGame>d__35))]
	// RVA: 0x5D19E0 Offset: 0x5D0BE0 VA: 0x1805D19E0
	public IEnumerator CoEndGame() { }

	// RVA: 0x5D3BD0 Offset: 0x5D2DD0 VA: 0x1805D3BD0 Slot: 14
	protected override void OnPlayerJoined(ClientData data) { }

	// RVA: 0x5D3840 Offset: 0x5D2A40 VA: 0x1805D3840 Slot: 9
	protected override void OnGameJoined(string gameIdString) { }

	// RVA: 0x5D3C80 Offset: 0x5D2E80 VA: 0x1805D3C80 Slot: 16
	protected override void OnPlayerLeft(ClientData data, DisconnectReasons reason) { }

	// RVA: 0x5D4400 Offset: 0x5D3600 VA: 0x1805D4400 Slot: 19
	protected override void PreDisconnectInternal() { }

	// RVA: 0x5D2C90 Offset: 0x5D1E90 VA: 0x1805D2C90 Slot: 18
	protected override void OnDisconnected() { }

	// RVA: 0x5D2100 Offset: 0x5D1300 VA: 0x1805D2100
	private void DestroyPlayerInfoObjects() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoOnPlayerChangedScene>d__42))]
	// RVA: 0x5D1E30 Offset: 0x5D1030 VA: 0x1805D1E30 Slot: 15
	protected override IEnumerator CoOnPlayerChangedScene(ClientData client, string currentScene) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CreatePlayer>d__43))]
	// RVA: 0x5D2080 Offset: 0x5D1280 VA: 0x1805D2080
	private IEnumerator CreatePlayer(ClientData clientData) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoBroadcastManager>d__44))]
	// RVA: 0x5D1860 Offset: 0x5D0A60 VA: 0x1805D1860
	private IEnumerator CoBroadcastManager() { }

	// RVA: 0x5D1750 Offset: 0x5D0950 VA: 0x1805D1750
	public void CheckOnlinePermissions(Action success, Action failure, Action loadingCallback, bool checkOnline = True) { }

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x5D26A0 Offset: 0x5D18A0 VA: 0x1805D26A0
	private static void InitSceneChangeListener() { }

	// RVA: 0x5D2910 Offset: 0x5D1B10 VA: 0x1805D2910
	private static void OnActiveSceneChange(Scene from, Scene to) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoCreateOnlineGame>d__48))]
	// RVA: 0x5D1970 Offset: 0x5D0B70 VA: 0x1805D1970
	public IEnumerator CoCreateOnlineGame() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoJoinOnlinePublicGame>d__49))]
	// RVA: 0x5D1D90 Offset: 0x5D0F90 VA: 0x1805D1D90
	public IEnumerator CoJoinOnlinePublicGame(int gameId, string ipAddress, ushort port, AmongUsClient.MainMenuTarget targetMenu = 1) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoJoinOnlineGameFromListing>d__50))]
	// RVA: 0x5D1CE0 Offset: 0x5D0EE0 VA: 0x1805D1CE0
	public IEnumerator CoJoinOnlineGameFromListing(GameListing game, string matchmakerToken) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoJoinOnlineGameFromCode>d__51))]
	// RVA: 0x5D1C50 Offset: 0x5D0E50 VA: 0x1805D1C50
	public IEnumerator CoJoinOnlineGameFromCode(int gameId, bool fromEnterCode = False) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoFindGameInfoFromCode>d__52))]
	// RVA: 0x5D1AB0 Offset: 0x5D0CB0 VA: 0x1805D1AB0
	public IEnumerator CoFindGameInfoFromCode(int gameId, Action<HttpMatchmakerManager.FindGameByCodeResponse, string> callback) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoFindGameInfoFromCodeAndJoin>d__53))]
	// RVA: 0x5D1A30 Offset: 0x5D0C30 VA: 0x1805D1A30
	public IEnumerator CoFindGameInfoFromCodeAndJoin(int gameId) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoFindGame>d__54))]
	// RVA: 0x5D1B40 Offset: 0x5D0D40 VA: 0x1805D1B40
	public IEnumerator CoFindGame() { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoConnectToGameServer>d__55))]
	// RVA: 0x5D18D0 Offset: 0x5D0AD0 VA: 0x1805D18D0
	private IEnumerator CoConnectToGameServer(MatchMakerModes mode, string ipAddress, ushort port, string matchmakerToken) { }

	[IteratorStateMachine(typeof(AmongUsClient.<CoJoinOnlineGameDirect>d__56))]
	// RVA: 0x5D1BB0 Offset: 0x5D0DB0 VA: 0x1805D1BB0
	private IEnumerator CoJoinOnlineGameDirect(int gameId, string ipAddress, ushort port, string matchmakerToken) { }

	// RVA: 0x5D4450 Offset: 0x5D3650 VA: 0x1805D4450
	public void .ctor() { }
}

// Namespace: 
public class AprilFoolsModeToggleButton : MonoBehaviour // TypeDefIndex: 1158
{
	// Fields
	public ButtonRolloverHandler onButton; // 0x20
	public ButtonRolloverHandler offButton; // 0x28
	public SpriteRenderer onButtonSprite; // 0x30
	public SpriteRenderer offButtonSprite; // 0x38
	public TextMeshPro onText; // 0x40
	public TextMeshPro offText; // 0x48

	// Methods

	// RVA: 0x5E6B40 Offset: 0x5E5D40 VA: 0x1805E6B40
	public void ToggleAprilFoolsMode(bool modeOn) { }

	// RVA: 0x5E6B80 Offset: 0x5E5D80 VA: 0x1805E6B80
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ChatLanguageButton : PoolableBehavior // TypeDefIndex: 1159
{
	// Fields
	public TextMeshPro Text; // 0x30
	public PassiveButton Button; // 0x38
	[SerializeField]
	private SpriteRenderer Background; // 0x40
	[SerializeField]
	private SpriteRenderer Check; // 0x48

	// Methods

	// RVA: 0x5E6D40 Offset: 0x5E5F40 VA: 0x1805E6D40
	public void SetSelected(bool selected) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0 Slot: 4
	public override void Reset() { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatLanguageMenu.<>c__DisplayClass6_0 // TypeDefIndex: 1160
{
	// Fields
	public uint lang; // 0x10
	public ChatLanguageMenu <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD950 Offset: 0x5FCB50 VA: 0x1805FD950
	internal void <OnEnable>b__0() { }
}

// Namespace: 
public class ChatLanguageMenu : MonoBehaviour // TypeDefIndex: 1161
{
	// Fields
	public CreateOptionsPicker Parent; // 0x20
	public ObjectPoolBehavior ButtonPool; // 0x28
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x30
	private UiElement defaultButtonSelected; // 0x38
	private List<UiElement> controllerSelectable; // 0x40

	// Methods

	// RVA: 0x5E6F10 Offset: 0x5E6110 VA: 0x1805E6F10
	private void Awake() { }

	// RVA: 0x5E7050 Offset: 0x5E6250 VA: 0x1805E7050
	public void OnEnable() { }

	// RVA: 0x5E6FD0 Offset: 0x5E61D0 VA: 0x1805E6FD0
	public void OnDisable() { }

	// RVA: 0x537E50 Offset: 0x537050 VA: 0x180537E50
	public void Open() { }

	// RVA: 0x5E6F80 Offset: 0x5E6180 VA: 0x1805E6F80
	public void ChooseOption(uint language) { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ConfirmCreatePopUp : MonoBehaviour // TypeDefIndex: 1162
{
	// Fields
	[SerializeField]
	private CreateGameOptions createGameOptions; // 0x20
	[SerializeField]
	private TextMeshPro modeText; // 0x28
	[SerializeField]
	private TextMeshPro serverText; // 0x30
	[SerializeField]
	private TextMeshPro capacityText; // 0x38
	[SerializeField]
	private TextMeshPro chatText; // 0x40
	[SerializeField]
	private TextMeshPro tagText; // 0x48
	[SerializeField]
	private TextMeshPro langText; // 0x50
	[SerializeField]
	private Sprite[] mapBanners; // 0x58
	[SerializeField]
	private Sprite[] mapLogos; // 0x60
	[SerializeField]
	private SpriteRenderer mapBanner; // 0x68
	[SerializeField]
	private SpriteRenderer mapLogo; // 0x70

	// Methods

	// RVA: 0x5E78C0 Offset: 0x5E6AC0 VA: 0x1805E78C0
	private void OnEnable() { }

	// RVA: 0x5E78D0 Offset: 0x5E6AD0 VA: 0x1805E78D0
	private void SetupInfo() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameMapPicker.<>c__DisplayClass3_0 // TypeDefIndex: 1163
{
	// Fields
	public Action<int> action; // 0x10
	public UnityAction <>9__2; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD6C0 Offset: 0x5FC8C0 VA: 0x1805FD6C0
	internal void <SetupMouseOver>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameMapPicker.<>c__DisplayClass3_1 // TypeDefIndex: 1164
{
	// Fields
	public MapSelectButton mapButton; // 0x10
	public CreateGameMapPicker.<>c__DisplayClass3_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD6F0 Offset: 0x5FC8F0 VA: 0x1805FD6F0
	internal void <SetupMouseOver>b__0() { }

	// RVA: 0x5FD6F0 Offset: 0x5FC8F0 VA: 0x1805FD6F0
	internal void <SetupMouseOver>b__1() { }
}

// Namespace: 
public class CreateGameMapPicker : GameOptionsMapPicker // TypeDefIndex: 1165
{
	// Fields
	private Action<int> toolTipAction; // 0xB0

	// Methods

	// RVA: 0x5E7EE0 Offset: 0x5E70E0 VA: 0x1805E7EE0 Slot: 9
	public override void Initialize(int maskLayer) { }

	// RVA: 0x5E82A0 Offset: 0x5E74A0 VA: 0x1805E82A0 Slot: 10
	protected override void UpdateValue() { }

	// RVA: 0x5E7F80 Offset: 0x5E7180 VA: 0x1805E7F80
	public void SetupMouseOver(Action<int> action) { }

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	public int GetSelectedID() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public List<MapSelectButton> GetMapButtons() { }

	// RVA: 0x5E83A0 Offset: 0x5E75A0 VA: 0x1805E83A0
	public void .ctor() { }
}

// Namespace: 
public class LanguageOption : PoolableBehavior // TypeDefIndex: 1166
{
	// Fields
	public PassiveButton Button; // 0x30

	// Methods

	// RVA: 0x5F5280 Offset: 0x5F4480 VA: 0x1805F5280
	public void SetTextButton(string text) { }

	// RVA: 0x5F5260 Offset: 0x5F4460 VA: 0x1805F5260
	public void SetButtonSelected(bool selected) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LanguagePicker.<>c__DisplayClass14_0 // TypeDefIndex: 1167
{
	// Fields
	public LanguageOption button; // 0x10
	public uint lang; // 0x18
	public LanguagePicker <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD190 Offset: 0x5FC390 VA: 0x1805FD190
	internal void <SetupLanguageButtons>b__0() { }
}

// Namespace: 
public class LanguagePicker : MonoBehaviour // TypeDefIndex: 1168
{
	// Fields
	[SerializeField]
	private ObjectPoolBehavior ButtonPool; // 0x20
	[SerializeField]
	private TextMeshPro label; // 0x28
	public Action<bool> callbackTooltip; // 0x30
	public Action<uint> callbackLang; // 0x38
	private const float INITIAL_X_POS = 0;
	private const float INITIAL_Y_POS = 0;
	private const float XOFFSET = 2,1;
	private const float YOFFSET = -0,65;
	private const string OTHER_STRING = "Other";
	private const int NUM_COLUMNS = 3;
	private List<LanguageOption> langOptions; // 0x40
	private const int MASK_LAYER = 51;
	private static readonly int STENCIL_COMP; // 0x0
	private static readonly int STENCIL; // 0x4

	// Methods

	// RVA: 0x5F52C0 Offset: 0x5F44C0 VA: 0x1805F52C0
	public void SetupLanguageButtons(uint sel) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public List<LanguageOption> GetLangButtons() { }

	// RVA: 0x5F52A0 Offset: 0x5F44A0 VA: 0x1805F52A0
	private void ChooseOption(uint lang) { }

	// RVA: 0x5F5920 Offset: 0x5F4B20 VA: 0x1805F5920
	public void SetupMaskLayer() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x5F5B40 Offset: 0x5F4D40 VA: 0x1805F5B40
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x5F5B00 Offset: 0x5F4D00 VA: 0x1805F5B00
	private void <SetupLanguageButtons>b__14_1() { }

	[CompilerGenerated]
	// RVA: 0x5F5B20 Offset: 0x5F4D20 VA: 0x1805F5B20
	private void <SetupLanguageButtons>b__14_2() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServerDropdown.<>c // TypeDefIndex: 1169
{
	// Fields
	public static readonly ServerDropdown.<>c <>9; // 0x0
	public static Func<IRegionInfo, uint> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x5FDA00 Offset: 0x5FCC00 VA: 0x1805FDA00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FCCA0 Offset: 0x5FBEA0 VA: 0x1805FCCA0
	internal uint <FillServerOptions>b__17_0(IRegionInfo s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerDropdown.<>c__DisplayClass17_0 // TypeDefIndex: 1170
{
	// Fields
	public IRegionInfo s; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD3A0 Offset: 0x5FC5A0 VA: 0x1805FD3A0
	internal bool <FillServerOptions>b__1(IRegionInfo d) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServerDropdown.<>c__DisplayClass17_1 // TypeDefIndex: 1171
{
	// Fields
	public IRegionInfo region; // 0x10
	public ServerDropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD420 Offset: 0x5FC620 VA: 0x1805FD420
	internal void <FillServerOptions>b__2() { }
}

// Namespace: 
public class ServerDropdown : MonoBehaviour // TypeDefIndex: 1172
{
	// Fields
	[SerializeField]
	private SpriteRenderer background; // 0x20
	[SerializeField]
	private ObjectPoolBehavior ButtonPool; // 0x28
	[SerializeField]
	private PassiveButton firstOption; // 0x30
	[SerializeField]
	private float initialYPos; // 0x38
	[SerializeField]
	private float y_posButton; // 0x3C
	private const float INITIAL_HEIGHT = 1,2;
	private const float YOFFSET = -0,3;
	private const float HEIGHT_INCREASE = 0,6;
	private const float YOFFSET_BUTTON = -0,55;
	private Action<string> serverSetAction; // 0x40
	private Action closeAction; // 0x48
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x50
	private UiElement defaultButtonSelected; // 0x58
	private List<UiElement> controllerSelectable; // 0x60

	// Methods

	// RVA: 0x5F5BC0 Offset: 0x5F4DC0 VA: 0x1805F5BC0
	private void Awake() { }

	// RVA: 0x5F6640 Offset: 0x5F5840 VA: 0x1805F6640
	private void OnEnable() { }

	// RVA: 0x5F65B0 Offset: 0x5F57B0 VA: 0x1805F65B0
	public void Initialize(Action<string> setCallback, Action closeCallback) { }

	// RVA: 0x5F5DF0 Offset: 0x5F4FF0 VA: 0x1805F5DF0
	private void FillServerOptions() { }

	// RVA: 0x5F5C30 Offset: 0x5F4E30 VA: 0x1805F5C30
	private void ChooseOption(IRegionInfo region) { }

	// RVA: 0x5F65C0 Offset: 0x5F57C0 VA: 0x1805F65C0
	public void OnDisable() { }

	// RVA: 0x5F5DA0 Offset: 0x5F4FA0 VA: 0x1805F5DA0
	public void Close() { }

	// RVA: 0x5F66D0 Offset: 0x5F58D0 VA: 0x1805F66D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameOptions.<CoHide>d__96 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1173
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CreateGameOptions <>4__this; // 0x20

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

	// RVA: 0x5F7990 Offset: 0x5F6B90 VA: 0x1805F7990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F7B20 Offset: 0x5F6D20 VA: 0x1805F7B20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameOptions.<CoShow>d__62 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1174
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CreateGameOptions <>4__this; // 0x20

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

	// RVA: 0x5F8B70 Offset: 0x5F7D70 VA: 0x1805F8B70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F9810 Offset: 0x5F8A10 VA: 0x1805F9810 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameOptions.<ContinueCoStart>d__104 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1175
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CreateGameOptions <>4__this; // 0x20

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

	// RVA: 0x5FBC90 Offset: 0x5FAE90 VA: 0x1805FBC90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FBEC0 Offset: 0x5FB0C0 VA: 0x1805FBEC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameOptions.<OpenConfirmPopupCo>d__99 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1176
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CreateGameOptions <>4__this; // 0x20

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

	// RVA: 0x5FC790 Offset: 0x5FB990 VA: 0x1805FC790 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FC960 Offset: 0x5FBB60 VA: 0x1805FC960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CreateGameOptions.<SetTooltipCo>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1177
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CreateGameOptions <>4__this; // 0x20
	public int index; // 0x28

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

	// RVA: 0x5FCAC0 Offset: 0x5FBCC0 VA: 0x1805FCAC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FCC10 Offset: 0x5FBE10 VA: 0x1805FCC10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CreateGameOptions : MonoBehaviour, IConnectButton // TypeDefIndex: 1178
{
	// Fields
	[SerializeField]
	private GameObject AprilFoolsToggle; // 0x20
	[SerializeField]
	private MainMenuManager mainMenuManager; // 0x28
	[SerializeField]
	private GameObject content; // 0x30
	[SerializeField]
	private SpriteRenderer foreground; // 0x38
	[SerializeField]
	private TextMeshPro tooltip; // 0x40
	[SerializeField]
	private Transform crewmatesContainer; // 0x48
	[SerializeField]
	private GameObject[] skeldCrewSprites; // 0x50
	[SerializeField]
	private GameObject[] airshipCrewSprites; // 0x58
	[SerializeField]
	private Sprite[] bgCrewmates; // 0x60
	[SerializeField]
	private SpriteRenderer rendererBGCrewmates; // 0x68
	[SerializeField]
	private SpriteRenderer mapBanner; // 0x70
	[SerializeField]
	private Sprite[] mapBanners; // 0x78
	[SerializeField]
	private ServerDropdown serverDropdown; // 0x80
	[SerializeField]
	private TextMeshPro[] serverTexts; // 0x88
	[SerializeField]
	private GameObject serverButton; // 0x90
	[SerializeField]
	private IntGameSetting capacitySetting; // 0x98
	[SerializeField]
	private BaseGameSetting mapSetting; // 0xA0
	[SerializeField]
	private CreateGameMapPicker mapPicker; // 0xA8
	[SerializeField]
	private NumberOption capacityOption; // 0xB0
	[SerializeField]
	private StringNames[] tooltipStrings; // 0xB8
	[SerializeField]
	private StringNames[] mapTooltips; // 0xC0
	[SerializeField]
	private PassiveButton[] tabButtons; // 0xC8
	[SerializeField]
	private GameObject[] contentObjects; // 0xD0
	[SerializeField]
	private PassiveButton[] modeButtons; // 0xD8
	[SerializeField]
	private PassiveButton[] levelButtons; // 0xE0
	[SerializeField]
	private PassiveButton[] crossPlayButtons; // 0xE8
	[SerializeField]
	private PassiveButton[] aprilFoolButtons; // 0xF0
	[SerializeField]
	private PassiveButton[] chatTypeButtons; // 0xF8
	[SerializeField]
	private PassiveButton minusButtonCapacity; // 0x100
	[SerializeField]
	private PassiveButton plusButtonCapacity; // 0x108
	[SerializeField]
	private GameObject confirmPopUp; // 0x110
	[SerializeField]
	private Transform containerConfirm; // 0x118
	[SerializeField]
	private LanguagePicker langPicker; // 0x120
	[SerializeField]
	private TextMeshPro chatDescText; // 0x128
	[SerializeField]
	private TextMeshPro chatWarningText; // 0x130
	[SerializeField]
	private GameObject loadAnim; // 0x138
	[SerializeField]
	private FilterOptionUI chatOptionUI; // 0x140
	[SerializeField]
	private Scroller scrollBar; // 0x148
	private int currentTag; // 0x150
	private Coroutine changeTooltipCo; // 0x158
	private bool animating; // 0x160
	private int currentDefaultTooltip; // 0x164
	private const float Y_POS_LANGPICKER_NORMAL = 0,84;
	private const float Y_POS_LANGPICKER_WARNING = 0,14;
	private const float SCROLLER_HEIGHT = 3;
	private const float Y_POS_APRILFOOLS = -3,4;
	private const float WAIT_TOOLTIP_TIME = 0,3;
	private const float CREWMATE_SLIDE_TIME = 0,3;
	private const float POPUP_SLIDE_TIME = 0,3;
	private const float X_OFFSET_LEFT = -7;
	private const float X_CREWMATES_POS = 0;
	private const float Y_BOTTOM_POS = -14;
	private GameObject[] currentCrewSprites; // 0x168
	private static readonly int STENCIL_COMP; // 0x0
	private static readonly int STENCIL; // 0x4
	private const int MASK_LAYER = 51;
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x170
	public UiElement DefaultButtonSelected; // 0x178
	public List<UiElement> ControllerSelectable; // 0x180
	private readonly Logger logger; // 0x188

	// Methods

	// RVA: 0x5EB390 Offset: 0x5EA590 VA: 0x1805EB390
	private void Start() { }

	// RVA: 0x5EB1A0 Offset: 0x5EA3A0 VA: 0x1805EB1A0
	public void Show() { }

	[IteratorStateMachine(typeof(CreateGameOptions.<CoShow>d__62))]
	// RVA: 0x5E8960 Offset: 0x5E7B60 VA: 0x1805E8960
	private IEnumerator CoShow() { }

	// RVA: 0x5E9960 Offset: 0x5E8B60 VA: 0x1805E9960
	private void ResetHoverStateButtons() { }

	// RVA: 0x5EAE70 Offset: 0x5EA070 VA: 0x1805EAE70
	private void SetUpMapButtonsNav() { }

	// RVA: 0x5EABF0 Offset: 0x5E9DF0 VA: 0x1805EABF0
	private void SetUpLangButtonsNav() { }

	// RVA: 0x5E9390 Offset: 0x5E8590 VA: 0x1805E9390
	private void MapChanged(OptionBehaviour behaviour) { }

	// RVA: 0x5EB8E0 Offset: 0x5EAAE0 VA: 0x1805EB8E0
	private void TurnOffCrewmates(GameObject[] crewmates) { }

	// RVA: 0x5E96B0 Offset: 0x5E88B0 VA: 0x1805E96B0
	public void OpenTab(bool isGeneral) { }

	// RVA: 0x5EA640 Offset: 0x5E9840 VA: 0x1805EA640
	public void SetLanguage(uint lang) { }

	// RVA: 0x5EA370 Offset: 0x5E9570 VA: 0x1805EA370
	private void SetCurrentServer() { }

	// RVA: 0x5EA550 Offset: 0x5E9750 VA: 0x1805EA550
	private void SetLangTooltip(bool isActive) { }

	// RVA: 0x5E9130 Offset: 0x5E8330 VA: 0x1805E9130
	private void ForceTooltipChange(int index) { }

	// RVA: 0x5EAA70 Offset: 0x5E9C70 VA: 0x1805EAA70
	public void SetTooltip(int index) { }

	[IteratorStateMachine(typeof(CreateGameOptions.<SetTooltipCo>d__74))]
	// RVA: 0x5EAA00 Offset: 0x5E9C00 VA: 0x1805EAA00
	private IEnumerator SetTooltipCo(int index) { }

	// RVA: 0x5EA710 Offset: 0x5E9910 VA: 0x1805EA710
	private void SetMapTooltip(int index) { }

	// RVA: 0x5E9220 Offset: 0x5E8420 VA: 0x1805E9220
	public float GetCapacity() { }

	// RVA: 0x5EB950 Offset: 0x5EAB50 VA: 0x1805EB950
	private void UpdateServerText(string text) { }

	// RVA: 0x5E9660 Offset: 0x5E8860 VA: 0x1805E9660
	public void OpenServerDropdown() { }

	// RVA: 0x5E8860 Offset: 0x5E7A60 VA: 0x1805E8860
	public void CloseServerDropdown() { }

	// RVA: 0x5EB9E0 Offset: 0x5EABE0 VA: 0x1805EB9E0
	private void ValueChanged(OptionBehaviour option) { }

	// RVA: 0x5EA140 Offset: 0x5E9340 VA: 0x1805EA140
	private void SetCrewmateGraphic(float capacity) { }

	// RVA: 0x5EA230 Offset: 0x5E9430 VA: 0x1805EA230
	public void SetCrossPlay(bool crossplay) { }

	// RVA: 0x5E83B0 Offset: 0x5E75B0 VA: 0x1805E83B0
	private void CheckChatType() { }

	// RVA: 0x5E9E70 Offset: 0x5E9070 VA: 0x1805E9E70
	public void SetChatType(bool isFreeChat) { }

	// RVA: 0x5E9D80 Offset: 0x5E8F80 VA: 0x1805E9D80
	public void SetAprilFool(bool isOn) { }

	// RVA: 0x5EA820 Offset: 0x5E9A20 VA: 0x1805EA820
	public void SetModeButton(int i) { }

	// RVA: 0x5EA830 Offset: 0x5E9A30 VA: 0x1805EA830
	public void SetTag(int i) { }

	// RVA: 0x5E9240 Offset: 0x5E8440 VA: 0x1805E9240
	public string GetLevelString() { }

	// RVA: 0x5E9C60 Offset: 0x5E8E60 VA: 0x1805E9C60
	private void SelectMode(int i, bool saveSetting = True) { }

	// RVA: 0x5EB610 Offset: 0x5EA810 VA: 0x1805EB610
	private void SwitchOptions(GameModes gameMode) { }

	// RVA: 0x5EA4D0 Offset: 0x5E96D0 VA: 0x1805EA4D0
	private void SetGameMode(GameModes mode) { }

	// RVA: 0x5E9500 Offset: 0x5E8700 VA: 0x1805E9500
	private void OnDisable() { }

	// RVA: 0x5EB360 Offset: 0x5EA560 VA: 0x1805EB360 Slot: 4
	public void StartIcon() { }

	// RVA: 0x5EB5E0 Offset: 0x5EA7E0 VA: 0x1805EB5E0 Slot: 5
	public void StopIcon() { }

	// RVA: 0x5E8890 Offset: 0x5E7A90 VA: 0x1805E8890
	public void Close() { }

	[IteratorStateMachine(typeof(CreateGameOptions.<CoHide>d__96))]
	// RVA: 0x5E8900 Offset: 0x5E7B00 VA: 0x1805E8900
	private IEnumerator CoHide() { }

	// RVA: 0x5E95D0 Offset: 0x5E87D0 VA: 0x1805E95D0
	public void OpenConfirmPopup() { }

	// RVA: 0x5E8810 Offset: 0x5E7A10 VA: 0x1805E8810
	public void CloseConfirmPopup() { }

	[IteratorStateMachine(typeof(CreateGameOptions.<OpenConfirmPopupCo>d__99))]
	// RVA: 0x5E9570 Offset: 0x5E8770 VA: 0x1805E9570
	private IEnumerator OpenConfirmPopupCo() { }

	// RVA: 0x5E8AF0 Offset: 0x5E7CF0 VA: 0x1805E8AF0
	public void Confirm() { }

	// RVA: 0x5E89C0 Offset: 0x5E7BC0 VA: 0x1805E89C0
	private void CoStartGame() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void NotOnlinePermissions() { }

	// RVA: 0x5E90C0 Offset: 0x5E82C0 VA: 0x1805E90C0
	private void ContinueStart() { }

	[IteratorStateMachine(typeof(CreateGameOptions.<ContinueCoStart>d__104))]
	// RVA: 0x5E9060 Offset: 0x5E8260 VA: 0x1805E9060
	private IEnumerator ContinueCoStart() { }

	// RVA: 0x5EBBB0 Offset: 0x5EADB0 VA: 0x1805EBBB0
	public void .ctor() { }

	// RVA: 0x5EBB30 Offset: 0x5EAD30 VA: 0x1805EBB30
	private static void .cctor() { }
}

// Namespace: 
public class CreateStoreButton : MonoBehaviour // TypeDefIndex: 1179
{
	// Fields
	public GameObject ConnectIcon; // 0x20

	// Methods

	// RVA: 0x5EBC70 Offset: 0x5EAE70 VA: 0x1805EBC70
	public void Click() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrewVisualizer : MonoBehaviour // TypeDefIndex: 1180
{
	// Fields
	public ObjectPoolBehavior CrewPool; // 0x20
	public SpriteRenderer Background; // 0x28
	public Sprite[] MapBackgrounds; // 0x30
	public float yOffset; // 0x38
	public FloatRange BgWidth; // 0x40

	// Methods

	// RVA: 0x5EBD60 Offset: 0x5EAF60 VA: 0x1805EBD60
	public void SetCrewSize(int numPlayers, int numImpostors) { }

	// RVA: 0x5EC250 Offset: 0x5EB450 VA: 0x1805EC250
	public void SetMap(int mapid) { }

	// RVA: 0x5EC2A0 Offset: 0x5EB4A0 VA: 0x1805EC2A0
	public void .ctor() { }
}

// Namespace: 
public class EnterCodeManager : MonoBehaviour, IConnectButton // TypeDefIndex: 1181
{
	// Fields
	[SerializeField]
	private TextBoxTMP enterCodeField; // 0x20
	[SerializeField]
	private GameObject enterCodeCheckmark; // 0x28
	[SerializeField]
	private TextMeshPro hostText; // 0x30
	[SerializeField]
	private TextMeshPro capacityText; // 0x38
	[SerializeField]
	private GameObject crewmateIcon; // 0x40
	[SerializeField]
	private TextMeshPro serverText; // 0x48
	[SerializeField]
	private TextMeshPro chatText; // 0x50
	[SerializeField]
	private PassiveButton joinGamePassiveButton; // 0x58
	[SerializeField]
	private JoinGameButton joinGameButton; // 0x60
	[SerializeField]
	private GameObject loadingIcon; // 0x68
	[SerializeField]
	private Color availableColor; // 0x70
	[SerializeField]
	private Color fullCapacityColor; // 0x80
	[SerializeField]
	private AudioClip finishLoadSFX; // 0x90
	[SerializeField]
	private GameObject fieldsContainer; // 0x98
	private string matchmakerToken; // 0xA0
	private GameListing gameFound; // 0xA8
	private const float DEFAULT_CONTAINER_Y = 0;
	private const float PS_CONTAINER_Y = 0,28;
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xF8

	// Methods

	// RVA: 0x5ECD50 Offset: 0x5EBF50 VA: 0x1805ECD50
	private void OnEnable() { }

	// RVA: 0x5ECD00 Offset: 0x5EBF00 VA: 0x1805ECD00
	private void OnDisable() { }

	// RVA: 0x5EC2B0 Offset: 0x5EB4B0 VA: 0x1805EC2B0
	public void LookForGame() { }

	// RVA: 0x5EC4D0 Offset: 0x5EB6D0 VA: 0x1805EC4D0
	private void ContinueLookForGame() { }

	// RVA: 0x5EC2B0 Offset: 0x5EB4B0 VA: 0x1805EC2B0
	private void CheckPermissions() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void NotOnlinePermissions() { }

	// RVA: 0x5EC740 Offset: 0x5EB940 VA: 0x1805EC740
	private void FindGameResult(HttpMatchmakerManager.FindGameByCodeResponse response, string mmToken) { }

	// RVA: 0x5EC3E0 Offset: 0x5EB5E0 VA: 0x1805EC3E0
	public void ClickJoin() { }

	// RVA: 0x5ECED0 Offset: 0x5EC0D0 VA: 0x1805ECED0
	public void SetGameFields(bool active) { }

	// RVA: 0x5ECFD0 Offset: 0x5EC1D0 VA: 0x1805ECFD0 Slot: 4
	public void StartIcon() { }

	// RVA: 0x5ED050 Offset: 0x5EC250 VA: 0x1805ED050 Slot: 5
	public void StopIcon() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ExitGameButton : MonoBehaviour // TypeDefIndex: 1182
{
	// Methods

	// RVA: 0x5ED180 Offset: 0x5EC380 VA: 0x1805ED180
	public void Start() { }

	// RVA: 0x5ED0D0 Offset: 0x5EC2D0 VA: 0x1805ED0D0
	public void OnClick() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FilterTagManager : DestroyableSingleton<FilterTagManager> // TypeDefIndex: 1183
{
	// Fields
	private static TimeSpan FilterTagRefreshCooldown; // 0x0
	private Logger logger; // 0x28

	// Methods

	// RVA: 0x5EFA80 Offset: 0x5EEC80 VA: 0x1805EFA80
	public void RefreshTags() { }

	// RVA: 0x5EF910 Offset: 0x5EEB10 VA: 0x1805EF910
	private void HandleRefreshedTags(HashSet<string> tags) { }

	// RVA: 0x5EFD00 Offset: 0x5EEF00 VA: 0x1805EFD00
	public void .ctor() { }

	// RVA: 0x5EFC90 Offset: 0x5EEE90 VA: 0x1805EFC90
	private static void .cctor() { }
}

// Namespace: 
private class FindAGameManager.GameSorter : IComparer<GameListing> // TypeDefIndex: 1184
{
	// Fields
	public static readonly FindAGameManager.GameSorter Instance; // 0x0

	// Methods

	// RVA: 0x5F51E0 Offset: 0x5F43E0 VA: 0x1805F51E0 Slot: 4
	public int Compare(GameListing x, GameListing y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5F5200 Offset: 0x5F4400 VA: 0x1805F5200
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FindAGameManager.<>c__DisplayClass34_0 // TypeDefIndex: 1185
{
	// Fields
	public FindAGameManager <>4__this; // 0x10
	public Vector2 startPos; // 0x18
	public Vector2 endPos; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD590 Offset: 0x5FC790 VA: 0x1805FD590
	internal void <Start>b__0(PermittedFilters filters) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FindAGameManager.<CoShow>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1186
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FindAGameManager <>4__this; // 0x20
	public Vector3 startPos; // 0x28
	public Vector3 endPos; // 0x34

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

	// RVA: 0x5F8A00 Offset: 0x5F7C00 VA: 0x1805F8A00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5F8B30 Offset: 0x5F7D30 VA: 0x1805F8B30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FindAGameManager.<RefreshListCo>d__66 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1187
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FindAGameManager <>4__this; // 0x20

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

	// RVA: 0x5FC9A0 Offset: 0x5FBBA0 VA: 0x1805FC9A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x5FCA80 Offset: 0x5FBC80 VA: 0x1805FCA80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FindAGameManager : DestroyableSingleton<FindAGameManager>, IGameListHandler, IConnectButton // TypeDefIndex: 1188
{
	// Fields
	[SerializeField]
	private FilterPopUp filterPopUp; // 0x28
	[SerializeField]
	private ServerDropdown serverDropdown; // 0x30
	[SerializeField]
	private PassiveButton serverButton; // 0x38
	[SerializeField]
	private TextMeshPro[] serverTexts; // 0x40
	[SerializeField]
	private GameContainer[] gameContainers; // 0x48
	[SerializeField]
	private PassiveButton refreshButton; // 0x50
	[SerializeField]
	private GameObject animLoad; // 0x58
	[SerializeField]
	private FindGameMoreInfoPopup findGameMoreInfoPopUp; // 0x60
	[SerializeField]
	private GameObject clearFilterPop; // 0x68
	[SerializeField]
	private TextMeshPro[] filtersFoundNums; // 0x70
	[SerializeField]
	private TextMeshPro matchesFoundText; // 0x78
	[SerializeField]
	private AudioClip findGameSFX; // 0x80
	[SerializeField]
	private AudioClip foundGameSFX; // 0x88
	[SerializeField]
	private Transform container; // 0x90
	[SerializeField]
	private TextMeshPro modeText; // 0x98
	[SerializeField]
	private PassiveButton clearFilterButton; // 0xA0
	public TextMeshPro TotalText; // 0xA8
	private const float RefreshTimeSeconds = 1;
	private float timer; // 0xB0
	private Coroutine refreshFilterCoroutine; // 0xB8
	private bool animating; // 0xC0
	private GameFilterSet classicFilterSet; // 0xC8
	private GameFilterSet hnsFilterSet; // 0xD0
	private const string MAP_FILTER_NAME = "Map";
	private const string LANGUAGE_FILTER_NAME = "Language";
	private const string CHAT_FILTER_NAME = "Chat";
	private const string CROSSPLAY_FILTER_NAME = "Crossplay";
	private const float WAIT_FILTER_REFRESH = 1;
	private const float WAIT_SLIDE_INTRO = 0,3;
	private const float Y_POS_OFFSET = -9;
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0xD8
	public UiElement DefaultButtonSelected; // 0xE0
	public List<UiElement> ControllerSelectable; // 0xE8
	private readonly Logger logger; // 0xF0

	// Methods

	// RVA: 0x5F4310 Offset: 0x5F3510 VA: 0x1805F4310
	public void Start() { }

	[IteratorStateMachine(typeof(FindAGameManager.<CoShow>d__35))]
	// RVA: 0x5F16C0 Offset: 0x5F08C0 VA: 0x1805F16C0
	private IEnumerator CoShow(Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x5F2030 Offset: 0x5F1230 VA: 0x1805F2030
	public MapGameFilter GetMapFilter() { }

	// RVA: 0x5F3A90 Offset: 0x5F2C90 VA: 0x1805F3A90
	public void ResetTimer() { }

	// RVA: 0x5F3A10 Offset: 0x5F2C10 VA: 0x1805F3A10
	private void ResetContainers() { }

	// RVA: 0x5F3D60 Offset: 0x5F2F60 VA: 0x1805F3D60
	private void SetLanguage() { }

	// RVA: 0x5F3AE0 Offset: 0x5F2CE0 VA: 0x1805F3AE0
	private void SetChatRestriction() { }

	// RVA: 0x5F4D70 Offset: 0x5F3F70 VA: 0x1805F4D70
	public void UpdateFiltersTexts() { }

	// RVA: 0x5F21B0 Offset: 0x5F13B0 VA: 0x1805F21B0
	public int GetRealFilterCount() { }

	// RVA: 0x5F1A30 Offset: 0x5F0C30 VA: 0x1805F1A30
	private int GetFilterCount() { }

	// RVA: 0x5F4EB0 Offset: 0x5F40B0 VA: 0x1805F4EB0
	public void UpdateGameModeText() { }

	// RVA: 0x5F1DF0 Offset: 0x5F0FF0 VA: 0x1805F1DF0
	public GameModes GetGameMode() { }

	// RVA: 0x5F3B70 Offset: 0x5F2D70 VA: 0x1805F3B70
	private void SetCurrentServer() { }

	// RVA: 0x5F2AF0 Offset: 0x5F1CF0 VA: 0x1805F2AF0
	public void OpenServerDropdown() { }

	// RVA: 0x5F1690 Offset: 0x5F0890 VA: 0x1805F1690
	private void CloseServerDropdown() { }

	// RVA: 0x5F4FE0 Offset: 0x5F41E0 VA: 0x1805F4FE0
	private void UpdateServerText(string text) { }

	// RVA: 0x5F5070 Offset: 0x5F4270 VA: 0x1805F5070
	public void Update() { }

	// RVA: 0x5F4240 Offset: 0x5F3440 VA: 0x1805F4240
	private void SetRefresh(bool isActive) { }

	// RVA: 0x5F2A30 Offset: 0x5F1C30 VA: 0x1805F2A30
	public void OpenMorePopUp(GameListing gameL) { }

	// RVA: 0x5F3CD0 Offset: 0x5F2ED0 VA: 0x1805F3CD0
	public void SetFilterPopUp(bool isOn) { }

	// RVA: 0x5F29E0 Offset: 0x5F1BE0 VA: 0x1805F29E0
	public void OpenFilterClear() { }

	// RVA: 0x5F1520 Offset: 0x5F0720 VA: 0x1805F1520
	public void ClearAllFilters() { }

	// RVA: 0x5F2BA0 Offset: 0x5F1DA0 VA: 0x1805F2BA0
	public void RefreshList() { }

	// RVA: 0x5F1D70 Offset: 0x5F0F70 VA: 0x1805F1D70
	public GameFilterSet GetFilterSet() { }

	// RVA: 0x5F4CE0 Offset: 0x5F3EE0 VA: 0x1805F4CE0
	public void UpdateFilterSets() { }

	// RVA: 0x5F2900 Offset: 0x5F1B00 VA: 0x1805F2900 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x5F2260 Offset: 0x5F1460 VA: 0x1805F2260 Slot: 6
	public void HandleList(InnerNetClient.TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse response) { }

	// RVA: 0x5F1760 Offset: 0x5F0960 VA: 0x1805F1760
	public void ExitGame() { }

	// RVA: 0x5F4290 Offset: 0x5F3490 VA: 0x1805F4290 Slot: 7
	public void StartIcon() { }

	// RVA: 0x5F4C60 Offset: 0x5F3E60 VA: 0x1805F4C60 Slot: 8
	public void StopIcon() { }

	// RVA: 0x5F17C0 Offset: 0x5F09C0 VA: 0x1805F17C0
	public void FilterModified() { }

	[IteratorStateMachine(typeof(FindAGameManager.<RefreshListCo>d__66))]
	// RVA: 0x5F2B40 Offset: 0x5F1D40 VA: 0x1805F2B40
	private IEnumerator RefreshListCo() { }

	// RVA: 0x5EFDD0 Offset: 0x5EEFD0 VA: 0x1805EFDD0
	public void AddBoolFilterValue(bool value, string key, BoolOptionNames boolOptionNames) { }

	// RVA: 0x5F2EC0 Offset: 0x5F20C0 VA: 0x1805F2EC0
	public void RemoveBoolFilterValue(bool value, string key, BoolOptionNames boolOptionNames) { }

	// RVA: 0x5F0D60 Offset: 0x5EFF60 VA: 0x1805F0D60
	public void AddIntFilterValue(int value, string key, Int32OptionNames intOptionName) { }

	// RVA: 0x5F3440 Offset: 0x5F2640 VA: 0x1805F3440
	public void RemoveIntFilterValue(int value, string key, Int32OptionNames intOptionName) { }

	// RVA: 0x5F0150 Offset: 0x5EF350 VA: 0x1805F0150
	public void AddCatFilterValue(int value, string key, CategorizedOptionNames catFilterName) { }

	// RVA: 0x5F3180 Offset: 0x5F2380 VA: 0x1805F3180
	public void RemoveCatFilterValue(int value, string key, CategorizedOptionNames catFilterName) { }

	// RVA: 0x5F3E00 Offset: 0x5F3000 VA: 0x1805F3E00
	public void SetMapFilter(byte mapByte) { }

	// RVA: 0x5F3700 Offset: 0x5F2900 VA: 0x1805F3700
	public void RemoveMapFilter() { }

	// RVA: 0x5F10D0 Offset: 0x5F02D0 VA: 0x1805F10D0
	public void AddLangFilterValue(uint value, bool refreshList = True) { }

	// RVA: 0x5F1E50 Offset: 0x5F1050 VA: 0x1805F1E50
	public uint GetLangFilter() { }

	// RVA: 0x5F04C0 Offset: 0x5EF6C0 VA: 0x1805F04C0
	public void AddChatFilterValue(QuickChatModes mode, bool refreshList = True) { }

	// RVA: 0x5F0910 Offset: 0x5EFB10 VA: 0x1805F0910
	public void AddCrossplayFilterValue(uint mode, bool refreshList = True) { }

	// RVA: 0x5F1850 Offset: 0x5F0A50 VA: 0x1805F1850
	public int GetChatFilter() { }

	// RVA: 0x5F5100 Offset: 0x5F4300 VA: 0x1805F5100
	public void .ctor() { }
}

// Namespace: 
public class ClearFilterPopup : MonoBehaviour // TypeDefIndex: 1189
{
	// Fields
	[SerializeField]
	private TransitionOpen transitionOpen; // 0x20

	// Methods

	// RVA: 0x5E76E0 Offset: 0x5E68E0 VA: 0x1805E76E0
	public void ClearFilters() { }

	// RVA: 0x5E78A0 Offset: 0x5E6AA0 VA: 0x1805E78A0
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterMapPicker.<>c__DisplayClass12_0 // TypeDefIndex: 1190
{
	// Fields
	public FilterMapPicker <>4__this; // 0x10
	public Action checkFilterLimit; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterMapPicker.<>c__DisplayClass12_1 // TypeDefIndex: 1191
{
	// Fields
	public MapSelectButton mapButton; // 0x10
	public FilterMapPicker.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FCE10 Offset: 0x5FC010 VA: 0x1805FCE10
	internal void <SetupClickAction>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterMapPicker.<>c__DisplayClass14_0 // TypeDefIndex: 1192
{
	// Fields
	public Action<int> action; // 0x10
	public UnityAction <>9__0; // 0x18
	public UnityAction <>9__1; // 0x20
	public UnityAction <>9__2; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5FD340 Offset: 0x5FC540 VA: 0x1805FD340
	internal void <SetupMouseOver>b__0() { }

	// RVA: 0x5FD340 Offset: 0x5FC540 VA: 0x1805FD340
	internal void <SetupMouseOver>b__1() { }

	// RVA: 0x5FD370 Offset: 0x5FC570 VA: 0x1805FD370
	internal void <SetupMouseOver>b__2() { }
}

// Namespace: 
public class FilterMapPicker : GameOptionsMapPicker // TypeDefIndex: 1193
{
	// Fields
	[SerializeField]
	private StringNames[] mapStrings; // 0xB0
	[SerializeField]
	private TextMeshPro mapNames; // 0xB8
	private const string COMMA_SPACE_TEXT = ", ";
	private List<int> mapIDs; // 0xC0

	// Methods

	// RVA: 0x5ED350 Offset: 0x5EC550 VA: 0x1805ED350 Slot: 9
	public override void Initialize(int maskLayer) { }

	// RVA: 0x5EE2B0 Offset: 0x5ED4B0 VA: 0x1805EE2B0 Slot: 10
	protected override void UpdateValue() { }

	// RVA: 0x5ED590 Offset: 0x5EC790 VA: 0x1805ED590
	public bool IsFilterEnabled() { }

	// RVA: 0x5EE000 Offset: 0x5ED200 VA: 0x1805EE000
	public void SetupSelectedIcons(MapGameFilter gameFilter) { }

	// RVA: 0x5ED1F0 Offset: 0x5EC3F0 VA: 0x1805ED1F0
	private void AddMapName(int mapID) { }

	// RVA: 0x5ED6C0 Offset: 0x5EC8C0 VA: 0x1805ED6C0
	private void RemoveMapName(int mapID) { }

	// RVA: 0x5ED2C0 Offset: 0x5EC4C0 VA: 0x1805ED2C0
	private void ClearMapNames() { }

	// RVA: 0x5ED9A0 Offset: 0x5ECBA0 VA: 0x1805ED9A0
	private void SetupMapNameString() { }

	// RVA: 0x5ED750 Offset: 0x5EC950 VA: 0x1805ED750
	public void SetupClickAction(Action checkFilterLimit) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public List<MapSelectButton> GetMapButtons() { }

	// RVA: 0x5EDD30 Offset: 0x5ECF30 VA: 0x1805EDD30
	public void SetupMouseOver(Action<int> action) { }

	// RVA: 0x5E83A0 Offset: 0x5E75A0 VA: 0x1805E83A0
	public void .ctor() { }
}

// Namespace: 
public enum FilterOptionUI.ButtonSize // TypeDefIndex: 1194
{
	// Fields
	public int value__; // 0x0
	public const FilterOptionUI.ButtonSize Short = 0;
	public const FilterOptionUI.ButtonSize Med = 1;
	public const FilterOptionUI.ButtonSize Long = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterOptionUI.<>c__DisplayClass19_0 // TypeDefIndex: 1195
{
	// Fields
	public int index; // 0x10
	public PassiveButton filterB; // 0x18
	public FilterOptionUI <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6127B0 Offset: 0x6119B0 VA: 0x1806127B0
	internal void <SetupButtons>b__0() { }
}

// Namespace: 
public class FilterOptionUI : MonoBehaviour // TypeDefIndex: 1196
{
	// Fields
	public FilterPopUp.FilterInfoUI FilterInfo; // 0x20
	public Action<int, int, string> toolTipCallback; // 0x28
	public int HighlightIndex; // 0x30
	[SerializeField]
	private List<PassiveButton> currentButtons; // 0x38
	[SerializeField]
	private PassiveButton[] buttonPrefabs; // 0x40
	[SerializeField]
	private TextMeshPro label; // 0x48
	[SerializeField]
	private SpriteRenderer blackSquare; // 0x50
	private const int MASK_LAYER = 51;
	private const float SHORT_DISTANCE = 0,55;
	private const float X_START_SHORT = -0,65;
	private const float MED_DISTANCE = 1,05;
	private const float X_START_MED = 0;
	private const float LONG_DISTANCE = 2;
	private const float X_START_LONG = 0,11;
	private Action<bool, int, FilterPopUp.FilterInfoUI> onClickAction; // 0x58
	private GameFilter gameFilter; // 0x60
	private static readonly int STENCIL_COMP; // 0x0
	private static readonly int STENCIL; // 0x4

	// Methods

	// RVA: 0x5EE8D0 Offset: 0x5EDAD0 VA: 0x1805EE8D0
	public void SetupButtons(Action<bool, int, FilterPopUp.FilterInfoUI> clickAction, Collider2D clickMask) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public SpriteRenderer GetBlackSquare() { }

	// RVA: 0x5EE440 Offset: 0x5ED640 VA: 0x1805EE440
	public void ResetFilterSelection() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public List<PassiveButton> GetButtons() { }

	// RVA: 0x5EE700 Offset: 0x5ED900 VA: 0x1805EE700
	public void SetupButtonMaskLayer() { }

	// RVA: 0x5EF5B0 Offset: 0x5EE7B0 VA: 0x1805EF5B0
	private void SetupNav() { }

	// RVA: 0x5EE380 Offset: 0x5ED580 VA: 0x1805EE380
	private void HandleSelection(int index) { }

	// RVA: 0x5EE4D0 Offset: 0x5ED6D0 VA: 0x1805EE4D0
	public void SetInactiveButton(bool isEnabled) { }

	// RVA: 0x5EF7F0 Offset: 0x5EE9F0 VA: 0x1805EF7F0
	public bool isFilterActive() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x5EF770 Offset: 0x5EE970 VA: 0x1805EF770
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x5EF6C0 Offset: 0x5EE8C0 VA: 0x1805EF6C0
	private void <SetupButtons>b__19_1() { }

	[CompilerGenerated]
	// RVA: 0x5EF730 Offset: 0x5EE930 VA: 0x1805EF730
	private void <SetupButtons>b__19_2() { }
}

// Namespace: 
public enum FilterPopUp.FilterInfoUI.FilterName // TypeDefIndex: 1197
{
	// Fields
	public int value__; // 0x0
	public const FilterPopUp.FilterInfoUI.FilterName PlayerSpeed = 0;
	public const FilterPopUp.FilterInfoUI.FilterName KillCooldown = 1;
	public const FilterPopUp.FilterInfoUI.FilterName VotingTime = 2;
	public const FilterPopUp.FilterInfoUI.FilterName VisualTasks = 3;
	public const FilterPopUp.FilterInfoUI.FilterName AnonymousVotes = 4;
	public const FilterPopUp.FilterInfoUI.FilterName ConfirmEjects = 5;
	public const FilterPopUp.FilterInfoUI.FilterName Tag = 6;
	public const FilterPopUp.FilterInfoUI.FilterName CrossPlay = 7;
	public const FilterPopUp.FilterInfoUI.FilterName Roles = 8;
	public const FilterPopUp.FilterInfoUI.FilterName ImpostorNumber = 9;
	public const FilterPopUp.FilterInfoUI.FilterName FlashlightMode = 10;
	public const FilterPopUp.FilterInfoUI.FilterName HidingTime = 11;
	public const FilterPopUp.FilterInfoUI.FilterName FinalHideTime = 12;
	public const FilterPopUp.FilterInfoUI.FilterName MaxVentUses = 13;
}

// Namespace: 
public class FilterPopUp.FilterInfoUI // TypeDefIndex: 1198
{
	// Fields
	public FilterPopUp.FilterInfoUI.FilterName myFilterName; // 0x10
	public int ButtonCount; // 0x14
	public List<string> buttonTexts; // 0x18
	public FilterOptionUI.ButtonSize ButtonSize; // 0x20
	public StringNames stringName; // 0x24
	public BoolOptionNames BoolOptionN; // 0x28
	public Int32OptionNames Int32OptionN; // 0x2C
	public CategorizedOptionNames CatOptionName; // 0x30
	public int tooltipIndex; // 0x34
	public string ExtraInfoString; // 0x38

	// Methods

	// RVA: 0x600830 Offset: 0x5FFA30 VA: 0x180600830
	public string GetFilterType() { }

	// RVA: 0x600920 Offset: 0x5FFB20 VA: 0x180600920
	public void Init(FilterPopUp.FilterInfoUI.FilterName filterName) { }

	// RVA: 0x601AE0 Offset: 0x600CE0 VA: 0x180601AE0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterPopUp.<CloseCo>d__59 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1199
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FilterPopUp <>4__this; // 0x20

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

	// RVA: 0x60DFF0 Offset: 0x60D1F0 VA: 0x18060DFF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60E130 Offset: 0x60D330 VA: 0x18060E130 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterPopUp.<SetTooltipCo>d__64 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1200
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FilterPopUp <>4__this; // 0x20
	public int index; // 0x28
	public int highlightIndex; // 0x2C
	public string extraInfo; // 0x30

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

	// RVA: 0x611BA0 Offset: 0x610DA0 VA: 0x180611BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x611D90 Offset: 0x610F90 VA: 0x180611D90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FilterPopUp.<ShowCo>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1201
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FilterPopUp <>4__this; // 0x20

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

	// RVA: 0x611DD0 Offset: 0x610FD0 VA: 0x180611DD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x611FA0 Offset: 0x6111A0 VA: 0x180611FA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FilterPopUp : MonoBehaviour // TypeDefIndex: 1202
{
	// Fields
	[SerializeField]
	private FilterMapPicker mapPicker; // 0x20
	[SerializeField]
	private BaseGameSetting mapSetting; // 0x28
	[SerializeField]
	private Scroller scrollBar; // 0x30
	[SerializeField]
	private Scroller scrollBarChat; // 0x38
	[SerializeField]
	private FilterOptionUI filterButtonPrefab; // 0x40
	[SerializeField]
	private Transform container; // 0x48
	[SerializeField]
	private PassiveButton[] modeButtons; // 0x50
	[SerializeField]
	private PassiveButton[] crossPlayButtons; // 0x58
	[SerializeField]
	private PassiveButton[] tabButtons; // 0x60
	[SerializeField]
	private PassiveButton[] chatTypeButtons; // 0x68
	[SerializeField]
	private FilterOptionUI modeFilterOptionUI; // 0x70
	[SerializeField]
	private FilterOptionUI crossPlayOptionUI; // 0x78
	[SerializeField]
	private FilterOptionUI chatOptionUI; // 0x80
	[SerializeField]
	private GameObject generalContainer; // 0x88
	[SerializeField]
	private GameObject chatContainer; // 0x90
	[SerializeField]
	private LanguagePicker langPicker; // 0x98
	[SerializeField]
	private TextMeshPro tooltip; // 0xA0
	[SerializeField]
	private TextMeshPro tooltipExtraInfo; // 0xA8
	[SerializeField]
	private GameObject tooltipExtraBox; // 0xB0
	[SerializeField]
	private StringNames[] tooltipStrings; // 0xB8
	[SerializeField]
	private AspectPosition aspectPosition; // 0xC0
	[SerializeField]
	private TextMeshPro mapNames; // 0xC8
	[SerializeField]
	private TextMeshPro mapNameTitle; // 0xD0
	[SerializeField]
	private List<SpriteRenderer> blackSquares; // 0xD8
	[SerializeField]
	private Color boxColor; // 0xE0
	[SerializeField]
	private Color boxhighlightColor; // 0xF0
	[SerializeField]
	private TextMeshPro chatWarningText; // 0x100
	[SerializeField]
	private GameObject filtersActiveText; // 0x108
	[SerializeField]
	private GameObject maxFiltersText; // 0x110
	[SerializeField]
	private GameObject numFiltersText; // 0x118
	private List<FilterOptionUI> classicChildren; // 0x120
	private List<FilterOptionUI> hnsChildren; // 0x128
	private const float START_POS_Y = -0,1;
	private const float START_POS_X = 0,44;
	private const float SPACING_Y = 0,45;
	private const float HEADER_HEIGHT = 0,65;
	private const float WAIT_TOOLTIP_TIME = 0,3;
	private const float ANCHOR_POSX = 0,1;
	private const float ANCHOR_OFFSET_X = 0,89;
	private const float WAIT_TIME_SLIDE = 0,3;
	private float scrollerHeightClassic; // 0x130
	private float scrollerHeightHnS; // 0x134
	private List<FilterPopUp.FilterInfoUI> filtersClassic; // 0x138
	private List<FilterPopUp.FilterInfoUI> filtersHnS; // 0x140
	private Coroutine changeTooltipCo; // 0x148
	private bool animating; // 0x150
	private static readonly int STENCIL_COMP; // 0x0
	private static readonly int STENCIL; // 0x4
	private const int MASK_LAYER = 51;
	private const float Y_POS_LANGPICKER_NORMAL = 1,38;
	private const float Y_POS_LANGPICKER_WARNING = 0,58;
	private const int FILTER_LIMIT = 8;
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x158
	public UiElement DefaultButtonSelected; // 0x160
	public List<UiElement> ControllerSelectable; // 0x168

	// Methods

	// RVA: 0x607D30 Offset: 0x606F30 VA: 0x180607D30
	private void Start() { }

	// RVA: 0x604A90 Offset: 0x603C90 VA: 0x180604A90
	private void OnEnable() { }

	[IteratorStateMachine(typeof(FilterPopUp.<ShowCo>d__57))]
	// RVA: 0x607CD0 Offset: 0x606ED0 VA: 0x180607CD0
	private IEnumerator ShowCo() { }

	// RVA: 0x602D10 Offset: 0x601F10 VA: 0x180602D10
	public void CloseFilter() { }

	[IteratorStateMachine(typeof(FilterPopUp.<CloseCo>d__59))]
	// RVA: 0x602CB0 Offset: 0x601EB0 VA: 0x180602CB0
	private IEnumerator CloseCo() { }

	// RVA: 0x6051D0 Offset: 0x6043D0 VA: 0x1806051D0
	private void ResetHoverStateButtons() { }

	// RVA: 0x6049F0 Offset: 0x603BF0 VA: 0x1806049F0
	private void OnDisable() { }

	// RVA: 0x605F10 Offset: 0x605110 VA: 0x180605F10
	private void SetLanguage(uint lang) { }

	// RVA: 0x605DE0 Offset: 0x604FE0 VA: 0x180605DE0
	private void SetLangTooltip(bool isActive) { }

	[IteratorStateMachine(typeof(FilterPopUp.<SetTooltipCo>d__64))]
	// RVA: 0x6064C0 Offset: 0x6056C0 VA: 0x1806064C0
	private IEnumerator SetTooltipCo(int index, int highlightIndex, string extraInfo = "") { }

	// RVA: 0x603E30 Offset: 0x603030 VA: 0x180603E30
	private void ForceDefaultTooltip() { }

	// RVA: 0x606040 Offset: 0x605240 VA: 0x180606040
	private void SetMapTooltip(int index) { }

	// RVA: 0x606170 Offset: 0x605370 VA: 0x180606170
	public void SetModePublic(int i) { }

	// RVA: 0x6061E0 Offset: 0x6053E0 VA: 0x1806061E0
	private void SetMode(int i) { }

	// RVA: 0x6065B0 Offset: 0x6057B0 VA: 0x1806065B0
	public void SetTooltipModes(int index) { }

	// RVA: 0x606460 Offset: 0x605660 VA: 0x180606460
	public void SetTooltipChat(int index) { }

	// RVA: 0x606550 Offset: 0x605750 VA: 0x180606550
	public void SetTooltipCrossplay(int index) { }

	// RVA: 0x606610 Offset: 0x605810 VA: 0x180606610
	public void SetTooltip(int index, int highlightIndex, string extraInfo = "") { }

	// RVA: 0x603F30 Offset: 0x603130 VA: 0x180603F30
	public void HighlightBox(int index) { }

	// RVA: 0x605D80 Offset: 0x604F80 VA: 0x180605D80
	private void SetExtraInfoTooltip(string infoString) { }

	// RVA: 0x605790 Offset: 0x604990 VA: 0x180605790
	public void SelectTab(bool isGeneral) { }

	// RVA: 0x605BB0 Offset: 0x604DB0 VA: 0x180605BB0
	public void SetCrossplayFilter(bool allPlatforms) { }

	// RVA: 0x606AA0 Offset: 0x605CA0 VA: 0x180606AA0
	private void SetUpMapButtonsNav() { }

	// RVA: 0x606810 Offset: 0x605A10 VA: 0x180606810
	private void SetUpLangButtonsNav() { }

	// RVA: 0x601B30 Offset: 0x600D30 VA: 0x180601B30
	private void CheckChatType() { }

	// RVA: 0x6058C0 Offset: 0x604AC0 VA: 0x1806058C0
	public void SetChatType(bool isFreeChat) { }

	// RVA: 0x602D80 Offset: 0x601F80 VA: 0x180602D80
	private void CreateButtons(bool isClassic) { }

	// RVA: 0x604FF0 Offset: 0x6041F0 VA: 0x180604FF0
	public void ResetFilterSelection() { }

	// RVA: 0x6040D0 Offset: 0x6032D0 VA: 0x1806040D0
	private void InitializeControllerNavigation(bool isClassic) { }

	// RVA: 0x602890 Offset: 0x601A90 VA: 0x180602890
	private void ClickFilterOption(bool isSelected, int index, FilterPopUp.FilterInfoUI filterInfo) { }

	// RVA: 0x602320 Offset: 0x601520 VA: 0x180602320
	private void CheckFilterLimit() { }

	// RVA: 0x603CD0 Offset: 0x602ED0 VA: 0x180603CD0
	private UiElement FindNextFilterAvailable(GameModes gameMode) { }

	// RVA: 0x606D80 Offset: 0x605F80 VA: 0x180606D80
	public void SetupFilters(PermittedFilters filters) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x607FD0 Offset: 0x6071D0 VA: 0x180607FD0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FindGameMoreInfoPopup.<CoShow>d__36 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1203
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FindGameMoreInfoPopup <>4__this; // 0x20

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

	// RVA: 0x610BB0 Offset: 0x60FDB0 VA: 0x180610BB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x610D90 Offset: 0x60FF90 VA: 0x180610D90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FindGameMoreInfoPopup : MonoBehaviour, IConnectButton // TypeDefIndex: 1204
{
	// Fields
	[SerializeField]
	private TextMeshPro modeText; // 0x20
	[SerializeField]
	private SpriteRenderer mapBackground; // 0x28
	[SerializeField]
	private SpriteRenderer mapLogo; // 0x30
	[SerializeField]
	private Sprite[] mapBackgroundSprites; // 0x38
	[SerializeField]
	private Sprite[] mapLogoSprites; // 0x40
	[SerializeField]
	private TextMeshPro capacity; // 0x48
	[SerializeField]
	private GameObject classicFilters; // 0x50
	[SerializeField]
	private GameObject hnsFilters; // 0x58
	[SerializeField]
	private TextMeshPro impostorsText; // 0x60
	[SerializeField]
	private TextMeshPro rolesText; // 0x68
	[SerializeField]
	private TextMeshPro confirmEjectsText; // 0x70
	[SerializeField]
	private TextMeshPro visualTaskText; // 0x78
	[SerializeField]
	private TextMeshPro meetingTimeText; // 0x80
	[SerializeField]
	private TextMeshPro anonVotesText; // 0x88
	[SerializeField]
	private TextMeshPro killcooldownText; // 0x90
	[SerializeField]
	private TextMeshPro playerSpeedText; // 0x98
	[SerializeField]
	private TextMeshPro tagText; // 0xA0
	[SerializeField]
	private TextMeshPro flashlightText; // 0xA8
	[SerializeField]
	private TextMeshPro hidingTimeText; // 0xB0
	[SerializeField]
	private TextMeshPro finalHideText; // 0xB8
	[SerializeField]
	private TextMeshPro playerSpeedHnSText; // 0xC0
	[SerializeField]
	private TextMeshPro maxVentUsesText; // 0xC8
	[SerializeField]
	private TextMeshPro chatTypeText; // 0xD0
	[SerializeField]
	private TextMeshPro regionText; // 0xD8
	[SerializeField]
	private TextMeshPro languageText; // 0xE0
	private bool animating; // 0xE8
	private GameListing gameListing; // 0xF0
	private const float WAIT_SLIDE_INTRO = 0,3;
	private const float Y_POS_OFFSET = -9;
	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement BackButton; // 0x140
	[SerializeField]
	private UiElement defaultButtonSelected; // 0x148
	private List<UiElement> controllerSelectable; // 0x150

	// Methods

	// RVA: 0x608AB0 Offset: 0x607CB0 VA: 0x180608AB0
	public void SetupInfo(GameListing gameL) { }

	// RVA: 0x608540 Offset: 0x607740 VA: 0x180608540
	public string GetLevelString(int tag) { }

	// RVA: 0x608680 Offset: 0x607880 VA: 0x180608680
	private string GetStringSetting(bool value) { }

	// RVA: 0x6089D0 Offset: 0x607BD0 VA: 0x1806089D0
	private void OnEnable() { }

	[IteratorStateMachine(typeof(FindGameMoreInfoPopup.<CoShow>d__36))]
	// RVA: 0x6084E0 Offset: 0x6076E0 VA: 0x1806084E0
	private IEnumerator CoShow() { }

	// RVA: 0x608450 Offset: 0x607650 VA: 0x180608450
	public void Close() { }

	// RVA: 0x608720 Offset: 0x607920 VA: 0x180608720
	public void OnClick() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void StartIcon() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void StopIcon() { }

	// RVA: 0x60A130 Offset: 0x609330 VA: 0x18060A130
	public void .ctor() { }
}

// Namespace: 
public class GameContainer : MonoBehaviour, IConnectButton // TypeDefIndex: 1205
{
	// Fields
	[SerializeField]
	private TextMeshPro tag1; // 0x20
	[SerializeField]
	private TextMeshPro tag2; // 0x28
	[SerializeField]
	private SpriteRenderer mapBackground; // 0x30
	[SerializeField]
	private SpriteRenderer mapLogo; // 0x38
	[SerializeField]
	private Sprite[] mapBackgroundSprites; // 0x40
	[SerializeField]
	private Sprite[] mapLogoSprites; // 0x48
	[SerializeField]
	private TextMeshPro capacity; // 0x50
	public Action<GameListing> OnMoreAction; // 0x58
	private GameListing gameListing; // 0x60

	// Methods

	// RVA: 0x60A430 Offset: 0x609630 VA: 0x18060A430
	public void SetGameListing(GameListing gameL) { }

	// RVA: 0x60A470 Offset: 0x609670 VA: 0x18060A470
	public void SetupGameInfo() { }

	// RVA: 0x60A1A0 Offset: 0x6093A0 VA: 0x18060A1A0
	public void OnClick() { }

	// RVA: 0x60A140 Offset: 0x609340 VA: 0x18060A140
	public void ClickMore() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void StartIcon() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void StopIcon() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class FindGameButton : MonoBehaviour, IConnectButton // TypeDefIndex: 1206
{
	// Fields
	public GameObject loadAnim; // 0x20

	// Methods

	// RVA: 0x608300 Offset: 0x607500 VA: 0x180608300
	private void OnEnable() { }

	// RVA: 0x608180 Offset: 0x607380 VA: 0x180608180
	public void OnClick() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void NotOnlinePermissions() { }

	// RVA: 0x608050 Offset: 0x607250 VA: 0x180608050
	private void ContinueClick() { }

	// RVA: 0x6082B0 Offset: 0x6074B0 VA: 0x1806082B0
	private void OnDisable() { }

	// RVA: 0x608350 Offset: 0x607550 VA: 0x180608350 Slot: 4
	public void StartIcon() { }

	// RVA: 0x6083D0 Offset: 0x6075D0 VA: 0x1806083D0 Slot: 5
	public void StopIcon() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class GameDiscovery : MonoBehaviour // TypeDefIndex: 1207
{
	// Fields
	public JoinGameButton ButtonPrefab; // 0x20
	public Transform ItemLocation; // 0x28
	public float YStart; // 0x30
	public float YOffset; // 0x34
	public Scroller TargetArea; // 0x38
	private Dictionary<string, JoinGameButton> received; // 0x40

	// Methods

	// RVA: 0x60ADB0 Offset: 0x609FB0 VA: 0x18060ADB0
	public void Start() { }

	// RVA: 0x60AE60 Offset: 0x60A060 VA: 0x18060AE60
	public void Update() { }

	// RVA: 0x60AC80 Offset: 0x609E80 VA: 0x18060AC80
	private void Receive(BroadcastPacket packet) { }

	// RVA: 0x60A990 Offset: 0x609B90 VA: 0x18060A990
	private void CreateButtonForAddess(string fromAddress, string[] gameNameParts) { }

	// RVA: 0x60B0E0 Offset: 0x60A2E0 VA: 0x18060B0E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HostLocalGameButton.<CoStartGame>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1208
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HostLocalGameButton <>4__this; // 0x20
	private float <time>5__2; // 0x28

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

	// RVA: 0x610DD0 Offset: 0x60FFD0 VA: 0x180610DD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6115B0 Offset: 0x6107B0 VA: 0x1806115B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HostLocalGameButton : MonoBehaviour, IConnectButton // TypeDefIndex: 1209
{
	// Fields
	public AudioClip IntroMusic; // 0x20
	public SpriteRenderer FillScreen; // 0x28
	public SpriteAnim connectIcon; // 0x30
	public AnimationClip connectClip; // 0x38
	public NetworkModes NetworkMode; // 0x40

	// Methods

	// RVA: 0x60BD80 Offset: 0x60AF80 VA: 0x18060BD80
	public void Start() { }

	// RVA: 0x60BA10 Offset: 0x60AC10 VA: 0x18060BA10
	public void OnClick() { }

	// RVA: 0x60BD00 Offset: 0x60AF00 VA: 0x18060BD00 Slot: 4
	public void StartIcon() { }

	// RVA: 0x60BDF0 Offset: 0x60AFF0 VA: 0x18060BDF0 Slot: 5
	public void StopIcon() { }

	// RVA: 0x60B900 Offset: 0x60AB00 VA: 0x18060B900
	public void ClickHideNSeek() { }

	[IteratorStateMachine(typeof(HostLocalGameButton.<CoStartGame>d__10))]
	// RVA: 0x60B9B0 Offset: 0x60ABB0 VA: 0x18060B9B0
	private IEnumerator CoStartGame() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class HttpMatchmakerManager.MatchmakerResponse // TypeDefIndex: 1210
{
	// Fields
	public HttpMatchmakerManager.MatchmakerError[] Errors; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class HttpMatchmakerManager.MatchmakerError // TypeDefIndex: 1211
{
	// Fields
	public DisconnectReasons Reason; // 0x10
	public SanctionReasons SanctionReason; // 0x14
	public DateTimeOffset EndsAt; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class HttpMatchmakerManager.UserTokenRequestData // TypeDefIndex: 1212
{
	// Fields
	[CompilerGenerated]
	private string <Puid>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Username>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ClientVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private SupportedLangs <Language>k__BackingField; // 0x24

	// Properties
	public string Puid { get; set; }
	public string Username { get; set; }
	public int ClientVersion { get; set; }
	public SupportedLangs Language { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Puid() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Puid(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Username() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Username(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_ClientVersion() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ClientVersion(int value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public SupportedLangs get_Language() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_Language(SupportedLangs value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class HttpMatchmakerManager.HostServer // TypeDefIndex: 1213
{
	// Fields
	public readonly string Ip; // 0x10
	public readonly ushort Port; // 0x18

	// Methods

	// RVA: 0x60BEA0 Offset: 0x60B0A0 VA: 0x18060BEA0
	public void .ctor(long ip, ushort port) { }
}

// Namespace: 
public class HttpMatchmakerManager.MatchmakerFailure // TypeDefIndex: 1214
{
	// Fields
	[CompilerGenerated]
	private DisconnectReasons <Reason>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <CustomDisconnect>k__BackingField; // 0x18
	[CompilerGenerated]
	private HttpMatchmakerManager.MatchmakerError <MatchmakerError>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ShouldGoOffline>k__BackingField; // 0x28

	// Properties
	public DisconnectReasons Reason { get; set; }
	public string CustomDisconnect { get; set; }
	public HttpMatchmakerManager.MatchmakerError MatchmakerError { get; set; }
	public bool ShouldGoOffline { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public DisconnectReasons get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Reason(DisconnectReasons value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_CustomDisconnect() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CustomDisconnect(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public HttpMatchmakerManager.MatchmakerError get_MatchmakerError() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_MatchmakerError(HttpMatchmakerManager.MatchmakerError value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_ShouldGoOffline() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_ShouldGoOffline(bool value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HttpMatchmakerManager.Error // TypeDefIndex: 1215
{
	// Fields
	public DisconnectReasons Reason; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HttpMatchmakerManager.FindGameByCodeResponse // TypeDefIndex: 1216
{
	// Fields
	public List<HttpMatchmakerManager.Error> Errors; // 0x10
	public GameListing Game; // 0x18
	public StringNames Region; // 0x68
	public string UntranslatedRegion; // 0x70

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HttpMatchmakerManager.FindGamesListFilteredResponse // TypeDefIndex: 1217
{
	// Fields
	[JsonProperty("games")]
	public List<GameListing> Games; // 0x10
	[JsonProperty("metadata")]
	public HttpMatchmakerManager.GamesListMetadata Metadata; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HttpMatchmakerManager.GamesListMetadata // TypeDefIndex: 1218
{
	// Fields
	[JsonProperty("allGamesCount")]
	public int AllGamesCount; // 0x10
	[JsonProperty("matchingGamesCount")]
	public int MatchingGamesCount; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass16_0 // TypeDefIndex: 1219
{
	// Fields
	public HttpMatchmakerManager <>4__this; // 0x10
	public Action<string> onGetToken; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x612120 Offset: 0x611320 VA: 0x180612120
	internal void <CoRefreshTokenInternal>b__0(string encodedToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass17_0 // TypeDefIndex: 1220
{
	// Fields
	public string matchmakerToken; // 0x10
	public Action<HttpMatchmakerManager.HostServer, string> onGameHost; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoFindGameCode>b__0(string token) { }

	// RVA: 0x6121F0 Offset: 0x6113F0 VA: 0x1806121F0
	internal void <CoFindGameCode>b__1(string server) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass18_0 // TypeDefIndex: 1221
{
	// Fields
	public HttpMatchmakerManager <>4__this; // 0x10
	public Action<HttpMatchmakerManager.FindGameByCodeResponse, string> onGameInfo; // 0x18
	public bool foundGame; // 0x20
	public IRegionInfo initialRegion; // 0x28
	public Action<HttpMatchmakerManager.MatchmakerFailure> <>9__2; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x612340 Offset: 0x611540 VA: 0x180612340
	internal void <CoFindGameInfo>b__2(HttpMatchmakerManager.MatchmakerFailure failure) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass18_1 // TypeDefIndex: 1222
{
	// Fields
	public string matchmakerToken; // 0x10
	public IRegionInfo region; // 0x18
	public HttpMatchmakerManager.<>c__DisplayClass18_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoFindGameInfo>b__0(string token) { }

	// RVA: 0x6123F0 Offset: 0x6115F0 VA: 0x1806123F0
	internal void <CoFindGameInfo>b__1(string response) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass19_0 // TypeDefIndex: 1223
{
	// Fields
	public string matchmakerToken; // 0x10
	public Action<HttpMatchmakerManager.HostServer, string> onGameHost; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoFindHostServer>b__0(string token) { }

	// RVA: 0x612660 Offset: 0x611860 VA: 0x180612660
	internal void <CoFindHostServer>b__1(string server) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass20_0 // TypeDefIndex: 1224
{
	// Fields
	public string matchmakerToken; // 0x10
	public Action<InnerNetClient.TotalGameData, HttpMatchmakerManager.FindGamesListFilteredResponse> onGameList; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoRequestGameListFiltered>b__0(string token) { }

	// RVA: 0x612860 Offset: 0x611A60 VA: 0x180612860
	internal void <CoRequestGameListFiltered>b__1(string gamesResponse) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass21_0 // TypeDefIndex: 1225
{
	// Fields
	public string matchmakerToken; // 0x10
	public Action<HashSet<string>> onTags; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoRefreshTags>b__0(string token) { }

	// RVA: 0x612A00 Offset: 0x611C00 VA: 0x180612A00
	internal void <CoRefreshTags>b__1(string tags) { }

	// RVA: 0x612BC0 Offset: 0x611DC0 VA: 0x180612BC0
	internal void <CoRefreshTags>b__2(HttpMatchmakerManager.MatchmakerFailure failure) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass22_0 // TypeDefIndex: 1226
{
	// Fields
	public string matchmakerToken; // 0x10
	public Action<PermittedFilters> onRefreshFilters; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void <CoRefreshFilters>b__0(string token) { }

	// RVA: 0x612C20 Offset: 0x611E20 VA: 0x180612C20
	internal void <CoRefreshFilters>b__1(string filtersString) { }

	// RVA: 0x612D70 Offset: 0x611F70 VA: 0x180612D70
	internal void <CoRefreshFilters>b__2(HttpMatchmakerManager.MatchmakerFailure failure) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass24_0 // TypeDefIndex: 1227
{
	// Fields
	public string context; // 0x10
	public HttpMatchmakerManager <>4__this; // 0x18
	public RetryableWebRequest request; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x612DE0 Offset: 0x611FE0 VA: 0x180612DE0
	internal void <CoSendRequest>b__0(RetryableWebRequest r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<>c__DisplayClass24_1 // TypeDefIndex: 1228
{
	// Fields
	public bool didRefreshToken; // 0x10
	public HttpMatchmakerManager.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x613000 Offset: 0x612200 VA: 0x180613000
	internal void <CoSendRequest>b__1(string token) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoFindGameCode>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1229
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<HttpMatchmakerManager.HostServer, string> onGameHost; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	public int gameId; // 0x30
	private HttpMatchmakerManager.<>c__DisplayClass17_0 <>8__1; // 0x38
	private string <uri>5__2; // 0x40

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

	// RVA: 0x60E170 Offset: 0x60D370 VA: 0x18060E170 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60E4A0 Offset: 0x60D6A0 VA: 0x18060E4A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoFindGameInfo>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1230
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20
	public Action<HttpMatchmakerManager.FindGameByCodeResponse, string> onGameInfo; // 0x28
	private HttpMatchmakerManager.<>c__DisplayClass18_0 <>8__1; // 0x30
	public int gameId; // 0x38
	private HttpMatchmakerManager.<>c__DisplayClass18_1 <>8__2; // 0x40
	private List<IRegionInfo> <regions>5__2; // 0x48
	private int <i>5__3; // 0x50
	private string <uri>5__4; // 0x58

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

	// RVA: 0x60E4E0 Offset: 0x60D6E0 VA: 0x18060E4E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60ED70 Offset: 0x60DF70 VA: 0x18060ED70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoFindHostServer>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1231
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<HttpMatchmakerManager.HostServer, string> onGameHost; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	private HttpMatchmakerManager.<>c__DisplayClass19_0 <>8__1; // 0x30
	private string <uri>5__2; // 0x38

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

	// RVA: 0x60EDB0 Offset: 0x60DFB0 VA: 0x18060EDB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60F1E0 Offset: 0x60E3E0 VA: 0x18060F1E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoGetOrRefreshToken>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1232
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20
	public Action<string> onGetToken; // 0x28

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

	// RVA: 0x60F220 Offset: 0x60E420 VA: 0x18060F220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60F2F0 Offset: 0x60E4F0 VA: 0x18060F2F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoRefreshFilters>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1233
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<PermittedFilters> onRefreshFilters; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	private HttpMatchmakerManager.<>c__DisplayClass22_0 <>8__1; // 0x30

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

	// RVA: 0x60F330 Offset: 0x60E530 VA: 0x18060F330 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60F680 Offset: 0x60E880 VA: 0x18060F680 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoRefreshTags>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1234
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<HashSet<string>> onTags; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	private HttpMatchmakerManager.<>c__DisplayClass21_0 <>8__1; // 0x30

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

	// RVA: 0x60F6C0 Offset: 0x60E8C0 VA: 0x18060F6C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60FB10 Offset: 0x60ED10 VA: 0x18060FB10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoRefreshTokenInternal>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1235
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HttpMatchmakerManager <>4__this; // 0x20
	public Action<string> onGetToken; // 0x28

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

	// RVA: 0x60FB50 Offset: 0x60ED50 VA: 0x18060FB50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x60FFC0 Offset: 0x60F1C0 VA: 0x18060FFC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoRequestGameListFiltered>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1236
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action<InnerNetClient.TotalGameData, HttpMatchmakerManager.FindGamesListFilteredResponse> onGameList; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	public IGameOptions gameSearchOptions; // 0x30
	private HttpMatchmakerManager.<>c__DisplayClass20_0 <>8__1; // 0x38
	private string <uri>5__2; // 0x40

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

	// RVA: 0x610000 Offset: 0x60F200 VA: 0x180610000 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6105C0 Offset: 0x60F7C0 VA: 0x1806105C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpMatchmakerManager.<CoSendRequest>d__24 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1237
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string context; // 0x20
	public HttpMatchmakerManager <>4__this; // 0x28
	public RetryableWebRequest request; // 0x30
	private HttpMatchmakerManager.<>c__DisplayClass24_0 <>8__1; // 0x38
	public Action<HttpMatchmakerManager.MatchmakerFailure> onFailure; // 0x40
	private HttpMatchmakerManager.<>c__DisplayClass24_1 <>8__2; // 0x48
	public int maxRetries; // 0x50
	private float <retryIntervalSeconds>5__2; // 0x54
	private int <retryBackoffFactor>5__3; // 0x58
	private int <retries>5__4; // 0x5C

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

	// RVA: 0x610600 Offset: 0x60F800 VA: 0x180610600 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x610B70 Offset: 0x60FD70 VA: 0x180610B70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HttpMatchmakerManager : DestroyableSingleton<HttpMatchmakerManager> // TypeDefIndex: 1238
{
	// Fields
	private const string CONTEXT_AUTHENTICATE = "authenticate";
	private const string CONTEXT_REQUEST_GAME_CODE = "request gamecode server";
	private const string CONTEXT_FIND_HOST_SERVER = "find host server";
	private const string CONTEXT_REQUEST_GAMES_LIST = "request games list";
	private const string CONTEXT_GET_FILTER_TAGS = "get filter tags";
	private const string CONTEXT_GET_PERMITTED_FILTERS = "get permitted filters";
	private readonly Logger logger; // 0x28
	private readonly GameOptionsFactory optionsFactory; // 0x30
	private JsonSerializerSettings jsonSettings; // 0x38
	private static readonly Dictionary<string, StringNames> ContextMessages; // 0x0
	private static readonly Dictionary<long, StringNames> ErrorMessages; // 0x8
	private MatchmakerToken token; // 0x40
	private string base64Token; // 0x48

	// Methods

	// RVA: 0x60BF40 Offset: 0x60B140 VA: 0x18060BF40 Slot: 4
	public override void Awake() { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoGetOrRefreshToken>d__14))]
	// RVA: 0x60CC40 Offset: 0x60BE40 VA: 0x18060CC40
	public IEnumerator CoGetOrRefreshToken(Action<string> onGetToken) { }

	// RVA: 0x60D0E0 Offset: 0x60C2E0 VA: 0x18060D0E0
	private bool TryReadCachedToken(out string matchmakerToken) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoRefreshTokenInternal>d__16))]
	// RVA: 0x60CD90 Offset: 0x60BF90 VA: 0x18060CD90
	private IEnumerator CoRefreshTokenInternal(Action<string> onGetToken) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoFindGameCode>d__17))]
	// RVA: 0x60CAD0 Offset: 0x60BCD0 VA: 0x18060CAD0
	public IEnumerator CoFindGameCode(int gameId, Action<HttpMatchmakerManager.HostServer, string> onGameHost) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoFindGameInfo>d__18))]
	// RVA: 0x60CB50 Offset: 0x60BD50 VA: 0x18060CB50
	public IEnumerator CoFindGameInfo(int gameId, Action<HttpMatchmakerManager.FindGameByCodeResponse, string> onGameInfo) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoFindHostServer>d__19))]
	// RVA: 0x60CBD0 Offset: 0x60BDD0 VA: 0x18060CBD0
	public IEnumerator CoFindHostServer(Action<HttpMatchmakerManager.HostServer, string> onGameHost) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoRequestGameListFiltered>d__20))]
	// RVA: 0x60CE00 Offset: 0x60C000 VA: 0x18060CE00
	public IEnumerator CoRequestGameListFiltered(IGameOptions gameSearchOptions, GameFilterOptions filterOpts, Action<InnerNetClient.TotalGameData, HttpMatchmakerManager.FindGamesListFilteredResponse> onGameList) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoRefreshTags>d__21))]
	// RVA: 0x60CD20 Offset: 0x60BF20 VA: 0x18060CD20
	public IEnumerator CoRefreshTags(Action<HashSet<string>> onTags) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoRefreshFilters>d__22))]
	// RVA: 0x60CCB0 Offset: 0x60BEB0 VA: 0x18060CCB0
	public IEnumerator CoRefreshFilters(Action<PermittedFilters> onRefreshFilters) { }

	// RVA: 0x60CE80 Offset: 0x60C080 VA: 0x18060CE80
	private IEnumerator CoSendRequest(RetryableWebRequest request, string context) { }

	[IteratorStateMachine(typeof(HttpMatchmakerManager.<CoSendRequest>d__24))]
	// RVA: 0x60CF20 Offset: 0x60C120 VA: 0x18060CF20
	private IEnumerator CoSendRequest(RetryableWebRequest request, string context, int maxRetries, Action<HttpMatchmakerManager.MatchmakerFailure> onFailure) { }

	// RVA: 0x60C0A0 Offset: 0x60B2A0 VA: 0x18060C0A0
	private HttpMatchmakerManager.MatchmakerFailure BundleFailureInfo(RetryableWebRequest request, string context) { }

	// RVA: 0x60CFC0 Offset: 0x60C1C0 VA: 0x18060CFC0
	private void SetDisconnectInfoAndShowPopup(HttpMatchmakerManager.MatchmakerFailure failure) { }

	// RVA: 0x60D400 Offset: 0x60C600 VA: 0x18060D400
	public void .ctor() { }

	// RVA: 0x60D140 Offset: 0x60C340 VA: 0x18060D140
	private static void .cctor() { }
}

// Namespace: 
public interface IGameListHandler // TypeDefIndex: 1239
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void HandleList(InnerNetClient.TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse availableGames);
}

// Namespace: 
public class ImpostorsOptionButton : MonoBehaviour // TypeDefIndex: 1240
{
	// Fields
	[CompilerGenerated]
	private SpriteRenderer <SpriteRenderer>k__BackingField; // 0x20
	[CompilerGenerated]
	private TextMeshPro <TextMesh>k__BackingField; // 0x28
	[CompilerGenerated]
	private BoxCollider2D <BoxCollider>k__BackingField; // 0x30
	[CompilerGenerated]
	private PassiveButton <PassiveButton>k__BackingField; // 0x38
	[CompilerGenerated]
	private ButtonRolloverHandler <ButtonRollover>k__BackingField; // 0x40

	// Properties
	public SpriteRenderer SpriteRenderer { get; set; }
	public TextMeshPro TextMesh { get; set; }
	public BoxCollider2D BoxCollider { get; set; }
	public PassiveButton PassiveButton { get; set; }
	public ButtonRolloverHandler ButtonRollover { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public SpriteRenderer get_SpriteRenderer() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_SpriteRenderer(SpriteRenderer value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public TextMeshPro get_TextMesh() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_TextMesh(TextMeshPro value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public BoxCollider2D get_BoxCollider() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_BoxCollider(BoxCollider2D value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PassiveButton get_PassiveButton() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_PassiveButton(PassiveButton value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ButtonRolloverHandler get_ButtonRollover() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_ButtonRollover(ButtonRolloverHandler value) { }

	// RVA: 0x60D530 Offset: 0x60C730 VA: 0x18060D530
	private void Awake() { }

	// RVA: 0x60D640 Offset: 0x60C840 VA: 0x18060D640
	public void SetOptionEnabled(bool b) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JoinGameButton.<JoinLocalGame>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1241
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public JoinGameButton <>4__this; // 0x20
	private float <time>5__2; // 0x28

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

	// RVA: 0x6115F0 Offset: 0x6107F0 VA: 0x1806115F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x611B60 Offset: 0x610D60 VA: 0x180611B60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class JoinGameButton : MonoBehaviour, IConnectButton // TypeDefIndex: 1242
{
	// Fields
	public AudioClip IntroMusic; // 0x20
	public TextBoxTMP GameIdText; // 0x28
	public TextMeshPro gameNameText; // 0x30
	public float timeRecieved; // 0x38
	public SpriteRenderer FillScreen; // 0x40
	public SpriteAnim connectIcon; // 0x48
	public AnimationClip connectClip; // 0x50
	public NetworkModes NetworkMode; // 0x58
	public string netAddress; // 0x60

	// Methods

	// RVA: 0x60DE90 Offset: 0x60D090 VA: 0x18060DE90
	private void Start() { }

	// RVA: 0x60DB50 Offset: 0x60CD50 VA: 0x18060DB50
	public void OnClick() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void NotOnlinePermissions() { }

	// RVA: 0x60D780 Offset: 0x60C980 VA: 0x18060D780
	private void ContinueOnClick() { }

	[IteratorStateMachine(typeof(JoinGameButton.<JoinLocalGame>d__13))]
	// RVA: 0x60DAF0 Offset: 0x60CCF0 VA: 0x18060DAF0
	private IEnumerator JoinLocalGame() { }

	// RVA: 0x60DD40 Offset: 0x60CF40 VA: 0x18060DD40
	public void SetGameName(string[] gameNameParts) { }

	// RVA: 0x60DE10 Offset: 0x60D010 VA: 0x18060DE10 Slot: 4
	public void StartIcon() { }

	// RVA: 0x60DF40 Offset: 0x60D140 VA: 0x18060DF40 Slot: 5
	public void StopIcon() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class AdvancedRoleViewPanel : MonoBehaviour // TypeDefIndex: 1243
{
	// Fields
	[SerializeField]
	private CategoryHeaderRoleVariant header; // 0x20
	[SerializeField]
	private SpriteRenderer divider; // 0x28
	[SerializeField]
	private ViewSettingsInfoPanel infoPanelOrigin; // 0x30
	[SerializeField]
	private float xPosStart; // 0x38
	[SerializeField]
	private float yPosStart; // 0x3C
	private const float START_BODY_HEIGHT = 1,08;
	private const float BODY_SPACING = 0,8;

	// Methods

	// RVA: 0x5FDA60 Offset: 0x5FCC60 VA: 0x1805FDA60
	public float SetUp(RoleBehaviour role, float spacingY, int maskLayer) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ChatNotification : MonoBehaviour // TypeDefIndex: 1244
{
	// Fields
	[SerializeField]
	private PoolablePlayer player; // 0x20
	[SerializeField]
	private TextMeshPro chatText; // 0x28
	[SerializeField]
	private TextMeshPro playerNameText; // 0x30
	[SerializeField]
	private TextMeshPro playerColorText; // 0x38
	[SerializeField]
	private SpriteRenderer background; // 0x40
	[SerializeField]
	private SpriteRenderer maskArea; // 0x48
	private float timeOnScreen; // 0x50
	private const int maskLayer = 55;

	// Methods

	// RVA: 0x5FE910 Offset: 0x5FDB10 VA: 0x1805FE910
	private void Awake() { }

	// RVA: 0x5FEA70 Offset: 0x5FDC70 VA: 0x1805FEA70
	public void SetUp(PlayerControl sender, string text) { }

	// RVA: 0x5FE9F0 Offset: 0x5FDBF0 VA: 0x1805FE9F0
	public void SetCosmetics(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x5FE910 Offset: 0x5FDB10 VA: 0x1805FE910
	private void SetMaskLayer() { }

	// RVA: 0x5FEF00 Offset: 0x5FE100 VA: 0x1805FEF00
	private void Update() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ColorChip : MonoBehaviour // TypeDefIndex: 1245
{
	// Fields
	public HatParent Inner; // 0x20
	public GameObject PlayerEquippedForeground; // 0x28
	public GameObject InUseForeground; // 0x30
	public PassiveButton Button; // 0x38
	public SpriteRenderer SelectionHighlight; // 0x40
	public object Tag; // 0x48
	[CompilerGenerated]
	private string <ProductId>k__BackingField; // 0x50
	private readonly Color unavailableColor; // 0x58

	// Properties
	public string ProductId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_ProductId(string value) { }

	// RVA: 0x5FF110 Offset: 0x5FE310 VA: 0x1805FF110
	public void ShowSelected() { }

	// RVA: 0x5FF070 Offset: 0x5FE270 VA: 0x1805FF070
	public void Deselect() { }

	// RVA: 0x5FF0A0 Offset: 0x5FE2A0 VA: 0x1805FF0A0
	public void SetUnavailable() { }

	// RVA: 0x5FF140 Offset: 0x5FE340 VA: 0x1805FF140
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CubesTab.<>c // TypeDefIndex: 1246
{
	// Fields
	public static readonly CubesTab.<>c <>9; // 0x0
	public static Func<CosmicubeData, bool> <>9__9_0; // 0x8
	public static Func<CosmicubeData, bool> <>9__9_1; // 0x10
	public static Func<CosmicubeData, float> <>9__9_2; // 0x18
	public static Func<CosmicubeData, DateTime> <>9__9_3; // 0x20

	// Methods

	// RVA: 0x6130C0 Offset: 0x6122C0 VA: 0x1806130C0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x611FE0 Offset: 0x6111E0 VA: 0x180611FE0
	internal bool <OnEnable>b__9_0(CosmicubeData x) { }

	// RVA: 0x612060 Offset: 0x611260 VA: 0x180612060
	internal bool <OnEnable>b__9_1(CosmicubeData x) { }

	// RVA: 0x6120B0 Offset: 0x6112B0 VA: 0x1806120B0
	internal float <OnEnable>b__9_2(CosmicubeData x) { }

	// RVA: 0x612100 Offset: 0x611300 VA: 0x180612100
	internal DateTime <OnEnable>b__9_3(CosmicubeData x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CubesTab.<>c__DisplayClass9_0 // TypeDefIndex: 1247
{
	// Fields
	public ColorChip chip; // 0x10
	public CosmicubeData cube; // 0x18
	public CubesTab <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x613090 Offset: 0x612290 VA: 0x180613090
	internal void <OnEnable>b__4() { }
}

// Namespace: 
public class CubesTab : InventoryTab // TypeDefIndex: 1248
{
	// Fields
	public CosmicubeMenu cosmicubeMenu; // 0x68
	public GameObject viewButton; // 0x70
	public PassiveButton activateButton; // 0x78
	public TextMeshPro activateText; // 0x80
	public TextMeshPro itemName; // 0x88
	public SpriteRenderer podIcon; // 0x90
	public SpriteRenderer maskArea; // 0x98
	private CosmicubeData currentCube; // 0xA0

	// Methods

	// RVA: 0x5FF4B0 Offset: 0x5FE6B0 VA: 0x1805FF4B0
	private void Awake() { }

	// RVA: 0x5FF950 Offset: 0x5FEB50 VA: 0x1805FF950 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x600480 Offset: 0x5FF680 VA: 0x180600480
	private void Update() { }

	// RVA: 0x600150 Offset: 0x5FF350 VA: 0x180600150
	private void SelectCube(ColorChip chip, CosmicubeData cube) { }

	// RVA: 0x5FF8E0 Offset: 0x5FEAE0 VA: 0x1805FF8E0 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x6007C0 Offset: 0x5FF9C0 VA: 0x1806007C0
	public void ViewCube() { }

	// RVA: 0x5FF4C0 Offset: 0x5FE6C0 VA: 0x1805FF4C0 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x5FF160 Offset: 0x5FE360 VA: 0x1805FF160
	private void ActivateCube() { }

	// RVA: 0x5FF560 Offset: 0x5FE760 VA: 0x1805FF560
	private void DeactivateCube() { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x600450 Offset: 0x5FF650 VA: 0x180600450
	private void <SelectCube>b__11_0(Sprite sprite) { }
}

// Namespace: 
[Serializable]
public abstract class BaseGameSetting : ScriptableObject // TypeDefIndex: 1249
{
	// Fields
	public StringNames Title; // 0x18
	public OptionTypes Type; // 0x1C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetValueString(float value);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: 
public class CategoryHeaderMasked : MonoBehaviour // TypeDefIndex: 1250
{
	// Fields
	[SerializeField]
	protected TextMeshPro Title; // 0x20
	[SerializeField]
	protected SpriteRenderer Background; // 0x28
	[SerializeField]
	protected SpriteRenderer Divider; // 0x30

	// Methods

	// RVA: 0x5FE2C0 Offset: 0x5FD4C0 VA: 0x1805FE2C0 Slot: 4
	public virtual void SetHeader(StringNames name, int maskLayer) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CategoryHeaderRoleVariant : CategoryHeaderMasked // TypeDefIndex: 1251
{
	// Fields
	[SerializeField]
	private SpriteRenderer icon; // 0x38

	// Methods

	// RVA: 0x5FE4F0 Offset: 0x5FD6F0 VA: 0x1805FE4F0 Slot: 4
	public override void SetHeader(StringNames name, int maskLayer) { }

	// RVA: 0x5FE660 Offset: 0x5FD860 VA: 0x1805FE660
	public void SetHeader(StringNames roleName, int maskLayer, bool crewmate, Sprite roleIcon) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/CheckboxGameSetting")]
public class CheckboxGameSetting : BaseGameSetting // TypeDefIndex: 1252
{
	// Fields
	public BoolOptionNames OptionName; // 0x20

	// Methods

	// RVA: 0x5FEFD0 Offset: 0x5FE1D0 VA: 0x1805FEFD0 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public class CategoryHeaderEditRole : CategoryHeaderMasked // TypeDefIndex: 1253
{
	// Fields
	[SerializeField]
	private SpriteRenderer blankLabel; // 0x38
	[SerializeField]
	private SpriteRenderer chanceLabel; // 0x40
	[SerializeField]
	private SpriteRenderer countLabel; // 0x48

	// Methods

	// RVA: 0x5FDE60 Offset: 0x5FD060 VA: 0x1805FDE60 Slot: 4
	public override void SetHeader(StringNames name, int maskLayer) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameOptionButton.<DelayControllerClickUp>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1254
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameOptionButton <>4__this; // 0x20

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

	// RVA: 0x627820 Offset: 0x626A20 VA: 0x180627820 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x627940 Offset: 0x626B40 VA: 0x180627940 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class GameOptionButton : PassiveButton // TypeDefIndex: 1255
{
	// Fields
	private bool isInteractable; // 0x148
	[SerializeField]
	[Header("Game Option Button Stuff")]
	private SpriteRenderer buttonSprite; // 0x150
	[SerializeField]
	private Color interactableColor; // 0x158
	[SerializeField]
	private Color interactableHoveredColor; // 0x168
	[SerializeField]
	private Color interactableClickColor; // 0x178
	[SerializeField]
	private Color uninteractableColor; // 0x188
	[SerializeField]
	private Color uninteractableHoveredColor; // 0x198
	[SerializeField]
	private Color uninteractableClickColor; // 0x1A8

	// Methods

	// RVA: 0x60B840 Offset: 0x60AA40 VA: 0x18060B840
	public void SetInteractable(bool interactable) { }

	// RVA: 0x60B6D0 Offset: 0x60A8D0 VA: 0x18060B6D0 Slot: 5
	public override void ReceiveMouseOver() { }

	// RVA: 0x60B5E0 Offset: 0x60A7E0 VA: 0x18060B5E0 Slot: 4
	public override void ReceiveMouseOut() { }

	// RVA: 0x60B540 Offset: 0x60A740 VA: 0x18060B540 Slot: 20
	public override void ReceiveClickUp() { }

	// RVA: 0x60B350 Offset: 0x60A550 VA: 0x18060B350 Slot: 18
	public override void ReceiveClickDown() { }

	// RVA: 0x60B220 Offset: 0x60A420 VA: 0x18060B220
	private void AdjustHoverColors(bool isHovering) { }

	// RVA: 0x60B160 Offset: 0x60A360 VA: 0x18060B160
	private void AdjustClickedColors(bool clickDown) { }

	[IteratorStateMachine(typeof(GameOptionButton.<DelayControllerClickUp>d__15))]
	// RVA: 0x60B2E0 Offset: 0x60A4E0 VA: 0x18060B2E0
	private IEnumerator DelayControllerClickUp() { }

	// RVA: 0x60B8B0 Offset: 0x60AAB0 VA: 0x18060B8B0
	public void .ctor() { }
}

// Namespace: 
public class MapSelectButton : MonoBehaviour // TypeDefIndex: 1256
{
	// Fields
	public PassiveButton Button; // 0x20
	[SerializeField]
	private SpriteRenderer[] MapIcon; // 0x28
	[SerializeField]
	private SpriteRenderer[] allSprites; // 0x30
	[SerializeField]
	private BoxCollider2D boxCollider; // 0x38
	public int MapID; // 0x40

	// Methods

	// RVA: 0x61B9A0 Offset: 0x61ABA0 VA: 0x18061B9A0
	public void SetImage(Sprite mapSprite, int maskLayer) { }

	// RVA: 0x61BAF0 Offset: 0x61ACF0 VA: 0x18061BAF0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/FloatGameSetting")]
public class FloatGameSetting : BaseGameSetting // TypeDefIndex: 1257
{
	// Fields
	public FloatOptionNames OptionName; // 0x20
	public float Value; // 0x24
	public float Increment; // 0x28
	public FloatRange ValidRange; // 0x30
	public bool ZeroIsInfinity; // 0x38
	public NumberSuffixes SuffixType; // 0x3C
	public string FormatString; // 0x40

	// Methods

	// RVA: 0x613120 Offset: 0x612320 VA: 0x180613120 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameOptionsMapPicker.<>c__DisplayClass18_0 // TypeDefIndex: 1258
{
	// Fields
	public MapSelectButton mapButton; // 0x10
	public MapIconByName thisVal; // 0x18
	public GameOptionsMapPicker <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628110 Offset: 0x627310 VA: 0x180628110
	internal void <SetupMapButtons>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameOptionsMapPicker.<>c__DisplayClass21_0 // TypeDefIndex: 1259
{
	// Fields
	public int mapId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <SelectMap>b__0(MapIconByName m) { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <SelectMap>b__1(MapIconByName m) { }
}

// Namespace: 
public class GameOptionsMapPicker : OptionBehaviour // TypeDefIndex: 1260
{
	// Fields
	[SerializeField]
	protected List<MapIconByName> AllMapIcons; // 0x50
	[SerializeField]
	protected float StartPosX; // 0x58
	[SerializeField]
	protected float SpacingX; // 0x5C
	[SerializeField]
	protected float MapButtonY; // 0x60
	[SerializeField]
	private SpriteRenderer MapImage; // 0x68
	[SerializeField]
	private SpriteRenderer MapName; // 0x70
	[SerializeField]
	protected MapSelectButton MapButtonOrigin; // 0x78
	[SerializeField]
	protected Collider2D ButtonClickMask; // 0x80
	[SerializeField]
	protected TextMeshPro Labeltext; // 0x88
	protected List<MapSelectButton> mapButtons; // 0x90
	protected MapSelectButton selectedButton; // 0x98
	protected int selectedMapId; // 0xA0
	private int oldValue; // 0xA4
	protected ByteOptionNames optionName; // 0xA8

	// Properties
	public List<MapSelectButton> MapButtons { get; }

	// Methods

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public List<MapSelectButton> get_MapButtons() { }

	// RVA: 0x613AC0 Offset: 0x612CC0 VA: 0x180613AC0 Slot: 7
	public override void SetUpFromData(BaseGameSetting data, int maskLayer) { }

	// RVA: 0x613320 Offset: 0x612520 VA: 0x180613320 Slot: 9
	public virtual void Initialize(int maskLayer) { }

	// RVA: 0x613BA0 Offset: 0x612DA0 VA: 0x180613BA0
	protected void SetupMapButtons(int maskLayer) { }

	// RVA: 0x613870 Offset: 0x612A70 VA: 0x180613870
	public void SetInactiveButton(bool isEnabled) { }

	// RVA: 0x6132F0 Offset: 0x6124F0 VA: 0x1806132F0
	private void FixedUpdate() { }

	// RVA: 0x613520 Offset: 0x612720 VA: 0x180613520
	public void SelectMap(int mapId) { }

	// RVA: 0x613730 Offset: 0x612930 VA: 0x180613730
	public void SelectMap(MapIconByName mapInfo) { }

	// RVA: 0x613310 Offset: 0x612510 VA: 0x180613310 Slot: 4
	public override float GetFloat() { }

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0 Slot: 5
	public override int GetInt() { }

	// RVA: 0x614210 Offset: 0x613410 VA: 0x180614210 Slot: 10
	protected virtual void UpdateValue() { }

	// RVA: 0x614340 Offset: 0x613540 VA: 0x180614340
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GameSettingMenu.<CoSelectDefault>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1261
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameSettingMenu <>4__this; // 0x20

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

	// RVA: 0x627720 Offset: 0x626920 VA: 0x180627720 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6277E0 Offset: 0x6269E0 VA: 0x1806277E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class GameSettingMenu : MonoBehaviour // TypeDefIndex: 1262
{
	// Fields
	public static GameSettingMenu Instance; // 0x0
	[SerializeField]
	private PassiveButton GamePresetsButton; // 0x20
	[SerializeField]
	private PassiveButton GameSettingsButton; // 0x28
	[SerializeField]
	private PassiveButton RoleSettingsButton; // 0x30
	[SerializeField]
	private GamePresetsTab PresetsTab; // 0x38
	[SerializeField]
	private GameOptionsMenu GameSettingsTab; // 0x40
	[SerializeField]
	private RolesSettingsMenu RoleSettingsTab; // 0x48
	[SerializeField]
	private TextMeshPro MenuDescriptionText; // 0x50
	[SerializeField]
	private GameObject LeftSideDarkener; // 0x58
	[SerializeField]
	private GameObject RightSideDarkener; // 0x60
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x68
	public UiElement DefaultButtonSelected; // 0x70
	public List<UiElement> ControllerSelectable; // 0x78

	// Methods

	// RVA: 0x6158A0 Offset: 0x614AA0 VA: 0x1806158A0
	public void Close() { }

	// RVA: 0x615BA0 Offset: 0x614DA0 VA: 0x180615BA0
	private void Start() { }

	// RVA: 0x6160F0 Offset: 0x6152F0 VA: 0x1806160F0
	private void Update() { }

	// RVA: 0x6159F0 Offset: 0x614BF0 VA: 0x1806159F0
	private void OnEnable() { }

	// RVA: 0x615980 Offset: 0x614B80 VA: 0x180615980
	private void OnDisable() { }

	[IteratorStateMachine(typeof(GameSettingMenu.<CoSelectDefault>d__18))]
	// RVA: 0x615920 Offset: 0x614B20 VA: 0x180615920
	private IEnumerator CoSelectDefault() { }

	// RVA: 0x615420 Offset: 0x614620 VA: 0x180615420
	public void ChangeTab(int tabNum, bool previewOnly) { }

	// RVA: 0x615F30 Offset: 0x615130 VA: 0x180615F30
	private void ToggleLeftSideDarkener(bool on) { }

	// RVA: 0x615FE0 Offset: 0x6151E0 VA: 0x180615FE0
	private void ToggleRightSideDarkener(bool on) { }

	// RVA: 0x615870 Offset: 0x614A70 VA: 0x180615870
	public void CloseTab() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x616090 Offset: 0x615290 VA: 0x180616090
	private void <Start>b__14_0() { }

	[CompilerGenerated]
	// RVA: 0x6160A0 Offset: 0x6152A0 VA: 0x1806160A0
	private void <Start>b__14_1() { }

	[CompilerGenerated]
	// RVA: 0x6160B0 Offset: 0x6152B0 VA: 0x1806160B0
	private void <Start>b__14_2() { }

	[CompilerGenerated]
	// RVA: 0x6160C0 Offset: 0x6152C0 VA: 0x1806160C0
	private void <Start>b__14_3() { }

	[CompilerGenerated]
	// RVA: 0x6160D0 Offset: 0x6152D0 VA: 0x1806160D0
	private void <Start>b__14_4() { }

	[CompilerGenerated]
	// RVA: 0x6160E0 Offset: 0x6152E0 VA: 0x1806160E0
	private void <Start>b__14_5() { }
}

// Namespace: 
[CreateAssetMenu]
public class GameSettingsCategoryList : ScriptableObject // TypeDefIndex: 1263
{
	// Fields
	public StringNames GameModeName; // 0x18
	public Sprite StandardRulesImage; // 0x20
	public Sprite AlternateRulesImage; // 0x28
	public StringNames StandardRulesName; // 0x30
	public StringNames AlternateRulesName; // 0x34
	public StringNames StandardPresetDescription; // 0x38
	public StringNames AlternatePresetDescription; // 0x3C
	public RulesPresets AlternateRulesType; // 0x40
	public BaseGameSetting MapNameSetting; // 0x48
	public List<BaseGameSetting> OverviewSettings; // 0x50
	public List<RulesCategory> AllCategories; // 0x58

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/IntGameSetting")]
public class IntGameSetting : BaseGameSetting // TypeDefIndex: 1264
{
	// Fields
	public Int32OptionNames OptionName; // 0x20
	public int Value; // 0x24
	public int Increment; // 0x28
	public IntRange ValidRange; // 0x30
	public bool ZeroIsInfinity; // 0x38
	public NumberSuffixes SuffixType; // 0x3C
	public string FormatString; // 0x40

	// Methods

	// RVA: 0x617ED0 Offset: 0x6170D0 VA: 0x180617ED0 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/MapSelectionGameSetting")]
public class MapSelectionGameSetting : BaseGameSetting // TypeDefIndex: 1265
{
	// Fields
	public ByteOptionNames OptionName; // 0x20
	public StringNames[] Values; // 0x28

	// Methods

	// RVA: 0x61BBB0 Offset: 0x61ADB0 VA: 0x18061BBB0
	public void TryGetInt(IGameOptions gameOptions, out int value) { }

	// RVA: 0x61BB00 Offset: 0x61AD00 VA: 0x18061BB00 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelectionGameSetting.<>c__DisplayClass1_0 // TypeDefIndex: 1266
{
	// Fields
	public float value; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628330 Offset: 0x627530 VA: 0x180628330
	internal bool <GetValueString>b__0(NetworkedPlayerInfo info) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/PlayerSelectionGameSetting")]
public class PlayerSelectionGameSetting : BaseGameSetting // TypeDefIndex: 1267
{
	// Fields
	public Int32OptionNames OptionName; // 0x20

	// Methods

	// RVA: 0x621C80 Offset: 0x620E80 VA: 0x180621C80 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RoleSettingsTabButton.<>c__DisplayClass5_0 // TypeDefIndex: 1268
{
	// Fields
	public Action onClick; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <SetButton>b__0() { }
}

// Namespace: 
public class RoleSettingsTabButton : MonoBehaviour // TypeDefIndex: 1269
{
	// Fields
	[SerializeField]
	private SpriteRenderer background; // 0x20
	[SerializeField]
	private SpriteRenderer icon; // 0x28
	[SerializeField]
	private PassiveButton button; // 0x30

	// Properties
	public PassiveButton Button { get; }

	// Methods

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public PassiveButton get_Button() { }

	// RVA: 0x622BD0 Offset: 0x621DD0 VA: 0x180622BD0
	public void SetButton(RoleBehaviour role, Action onClick) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RolesSettingsMenu.<>c // TypeDefIndex: 1270
{
	// Fields
	public static readonly RolesSettingsMenu.<>c <>9; // 0x0
	public static Predicate<RoleBehaviour> <>9__60_0; // 0x8
	public static Predicate<RoleBehaviour> <>9__60_1; // 0x10

	// Methods

	// RVA: 0x628970 Offset: 0x627B70 VA: 0x180628970
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x627F70 Offset: 0x627170 VA: 0x180627F70
	internal bool <SetQuotaTab>b__60_0(RoleBehaviour r) { }

	// RVA: 0x627FA0 Offset: 0x6271A0 VA: 0x180627FA0
	internal bool <SetQuotaTab>b__60_1(RoleBehaviour r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RolesSettingsMenu.<>c__DisplayClass59_0 // TypeDefIndex: 1271
{
	// Fields
	public RolesSettingsMenu <>4__this; // 0x10
	public RoleBehaviour role; // 0x18
	public RoleSettingsTabButton tab; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628840 Offset: 0x627A40 VA: 0x180628840
	internal void <AddRoleTab>b__0() { }
}

// Namespace: 
public class RolesSettingsMenu : MonoBehaviour // TypeDefIndex: 1272
{
	// Fields
	[SerializeField]
	private SpriteRenderer MaskBg; // 0x20
	[SerializeField]
	private SpriteRenderer MaskArea; // 0x28
	[SerializeField]
	private CategoryHeaderMasked quotaHeader; // 0x30
	[SerializeField]
	private CategoryHeaderMasked advHeader; // 0x38
	[SerializeField]
	private RoleSettingsTabButton roleSettingsTabButtonOrigin; // 0x40
	[SerializeField]
	private RoleSettingsTabButton roleSettingsTabButtonOriginImpostor; // 0x48
	[SerializeField]
	private Transform roleSettingsTabParent; // 0x50
	[SerializeField]
	private Scroller roleSettingsTabScroller; // 0x58
	[SerializeField]
	private RoleOptionSetting roleOptionSettingOrigin; // 0x60
	[SerializeField]
	private GameObject RoleChancesSettings; // 0x68
	[SerializeField]
	private CategoryHeaderEditRole categoryHeaderEditRoleOrigin; // 0x70
	[SerializeField]
	private ToggleOption checkboxOrigin; // 0x78
	[SerializeField]
	private NumberOption numberOptionOrigin; // 0x80
	[SerializeField]
	private StringOption stringOptionOrigin; // 0x88
	[SerializeField]
	private TextMeshPro roleTitleText; // 0x90
	[SerializeField]
	private TextMeshPro roleDescriptionText; // 0x98
	[SerializeField]
	private GameObject AdvancedRolesSettings; // 0xA0
	[SerializeField]
	private SpriteRenderer roleScreenshot; // 0xA8
	[SerializeField]
	private SpriteRenderer roleHeaderSprite; // 0xB0
	[SerializeField]
	private TextMeshPro roleHeaderText; // 0xB8
	[SerializeField]
	private Scroller scrollBar; // 0xC0
	[SerializeField]
	private Collider2D ButtonClickMask; // 0xC8
	[SerializeField]
	private Scroller roleTabsScroller; // 0xD0
	[SerializeField]
	private GameObject roleTabsGradient; // 0xD8
	[SerializeField]
	private Transform roleTabsMinPos; // 0xE0
	[SerializeField]
	private Transform roleTabsMaxPos; // 0xE8
	private List<OptionBehaviour> advancedSettingChildren; // 0xF0
	private List<RoleOptionSetting> roleChances; // 0xF8
	private List<PassiveButton> roleTabs; // 0x100
	private int selectedRoleTab; // 0x108
	private readonly Color glyphUnavailableColor; // 0x10C
	private const float ROLE_HEADER_OFFSET = 0,522;
	private const float X_START_ROLE_HEADER = 4,986;
	private const float X_START_CHANCE = -0,15;
	private const float Y_START = 0,662;
	private const float Y_OFFSET = -0,43;
	private const float X_START = -1,928;
	private const float X_OFFSET = 0,762;
	private const float TAB_Y_START = 2,275;
	private const float Y_ADVANCED_START = -0,872;
	private const float Y_ADVANCED_OFFSET = -0,45;
	private const float X_ADVANCED_START = 2,17;
	private const int MASK_LAYER = 20;
	private IRoleOptionsCollection cachedData; // 0x120
	[Header("Console Controller Navigation")]
	[SerializeField]
	private UiElement BackButton; // 0x128
	[SerializeField]
	private UiElement DefaultButtonSelected; // 0x130
	[SerializeField]
	private PassiveButton AllButton; // 0x138
	[SerializeField]
	private List<UiElement> ControllerSelectable; // 0x140
	[SerializeField]
	private SpriteRenderer glyphL; // 0x148
	[SerializeField]
	private SpriteRenderer glyphR; // 0x150
	private List<UiElement> QuotaTabSelectables; // 0x158
	private PassiveButton currentTabButton; // 0x160

	// Methods

	// RVA: 0x623100 Offset: 0x622300 VA: 0x180623100
	private void Awake() { }

	// RVA: 0x624620 Offset: 0x623820 VA: 0x180624620
	private void InitialSetup() { }

	// RVA: 0x624990 Offset: 0x623B90 VA: 0x180624990
	private void OnEnable() { }

	// RVA: 0x6236C0 Offset: 0x6228C0 VA: 0x1806236C0
	private void OnDisable() { }

	// RVA: 0x624F10 Offset: 0x624110 VA: 0x180624F10
	public void OpenMenu(bool controllerSelected = True) { }

	// RVA: 0x6236C0 Offset: 0x6228C0 VA: 0x1806236C0
	public void CloseMenu() { }

	// RVA: 0x625910 Offset: 0x624B10 VA: 0x180625910
	private void Update() { }

	// RVA: 0x622CC0 Offset: 0x621EC0 VA: 0x180622CC0
	private void AddRoleTab(RoleBehaviour role, ref float tabXPos) { }

	// RVA: 0x625240 Offset: 0x624440 VA: 0x180625240
	public void SetQuotaTab() { }

	// RVA: 0x624140 Offset: 0x623340 VA: 0x180624140
	private void CreateQuotaOption(RoleBehaviour role, ref float yPos, int index) { }

	// RVA: 0x623220 Offset: 0x622420 VA: 0x180623220
	private void ChangeTab(RoleBehaviour role, PassiveButton button) { }

	// RVA: 0x624BD0 Offset: 0x623DD0 VA: 0x180624BD0
	public void OpenChancesTab(bool controllerSelected = True) { }

	// RVA: 0x624FF0 Offset: 0x6241F0 VA: 0x180624FF0
	public void RefreshChildren() { }

	// RVA: 0x625DE0 Offset: 0x624FE0 VA: 0x180625DE0
	private void ValueChanged(OptionBehaviour obj) { }

	// RVA: 0x6237B0 Offset: 0x6229B0 VA: 0x1806237B0
	private void CreateAdvancedSettings(RoleBehaviour role) { }

	// RVA: 0x624710 Offset: 0x623910 VA: 0x180624710
	private void InitializeControllerNavigation() { }

	// RVA: 0x6245D0 Offset: 0x6237D0 VA: 0x1806245D0
	private void EnableTabControllerGlyphs(bool _enabled) { }

	// RVA: 0x626420 Offset: 0x625620 VA: 0x180626420
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Game Setting/StringGameSetting")]
public class StringGameSetting : BaseGameSetting // TypeDefIndex: 1273
{
	// Fields
	public Int32OptionNames OptionName; // 0x20
	public StringNames[] Values; // 0x28
	public int Index; // 0x30

	// Methods

	// RVA: 0x6271C0 Offset: 0x6263C0 VA: 0x1806271C0 Slot: 4
	public override string GetValueString(float value) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
public class ViewSettingsInfoPanel : MonoBehaviour // TypeDefIndex: 1274
{
	// Fields
	[SerializeField]
	protected SpriteRenderer labelBackground; // 0x20
	[SerializeField]
	protected SpriteRenderer background; // 0x28
	[SerializeField]
	protected SpriteRenderer disabledBackground; // 0x30
	[SerializeField]
	protected SpriteRenderer checkMark; // 0x38
	[SerializeField]
	protected SpriteRenderer checkMarkOff; // 0x40
	[SerializeField]
	protected TextMeshPro titleText; // 0x48
	[SerializeField]
	protected TextMeshPro settingText; // 0x50

	// Methods

	// RVA: 0x629040 Offset: 0x628240 VA: 0x180629040
	public void SetInfo(StringNames title, string valueString, int maskLayer) { }

	// RVA: 0x628EA0 Offset: 0x6280A0 VA: 0x180628EA0
	public void SetInfoCheckbox(StringNames title, int maskLayer, bool isOn) { }

	// RVA: 0x629190 Offset: 0x628390 VA: 0x180629190 Slot: 4
	protected virtual void SetMaskLayer(int maskLayer) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ViewSettingsInfoPanelRoleVariant : ViewSettingsInfoPanel // TypeDefIndex: 1275
{
	// Fields
	[SerializeField]
	protected SpriteRenderer chanceBackground; // 0x58
	[SerializeField]
	protected SpriteRenderer iconSprite; // 0x60
	[SerializeField]
	protected TextMeshPro chanceText; // 0x68
	[SerializeField]
	protected TextMeshPro chanceTitle; // 0x70
	[SerializeField]
	protected Sprite disabledCube; // 0x78
	[SerializeField]
	protected Sprite crewmateCube; // 0x80
	[SerializeField]
	protected Sprite impostorCube; // 0x88

	// Methods

	// RVA: 0x6289D0 Offset: 0x627BD0 VA: 0x1806289D0
	public void SetInfo(string name, int count, int chance, int maskLayer, Color32 color, Sprite roleIcon, bool crewmateTeam, bool showDisabledBackground = False) { }

	// RVA: 0x628CD0 Offset: 0x627ED0 VA: 0x180628CD0 Slot: 4
	protected override void SetMaskLayer(int maskLayer) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GamePresetsTab.<>c // TypeDefIndex: 1276
{
	// Fields
	public static readonly GamePresetsTab.<>c <>9; // 0x0
	public static Action<SpriteRenderer> <>9__19_6; // 0x8
	public static Action<SpriteRenderer> <>9__19_7; // 0x10
	public static Action<SpriteRenderer> <>9__19_8; // 0x18
	public static Action<PassiveButton> <>9__21_0; // 0x20

	// Methods

	// RVA: 0x628910 Offset: 0x627B10 VA: 0x180628910
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x627FD0 Offset: 0x6271D0 VA: 0x180627FD0
	internal void <Start>b__19_6(SpriteRenderer s) { }

	// RVA: 0x628040 Offset: 0x627240 VA: 0x180628040
	internal void <Start>b__19_7(SpriteRenderer s) { }

	// RVA: 0x6280B0 Offset: 0x6272B0 VA: 0x1806280B0
	internal void <Start>b__19_8(SpriteRenderer s) { }

	// RVA: 0x627F20 Offset: 0x627120 VA: 0x180627F20
	internal void <ClickPresetButton>b__21_0(PassiveButton x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GamePresetsTab.<>c__DisplayClass21_0 // TypeDefIndex: 1277
{
	// Fields
	public GamePresetsTab <>4__this; // 0x10
	public RulesPresets preset; // 0x18
	public bool standardButtonSelected; // 0x19
	public UnityAction <>9__3; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628360 Offset: 0x627560 VA: 0x180628360
	internal void <ClickPresetButton>b__1() { }

	// RVA: 0x628480 Offset: 0x627680 VA: 0x180628480
	internal void <ClickPresetButton>b__2(PassiveButton x) { }

	// RVA: 0x628520 Offset: 0x627720 VA: 0x180628520
	internal void <ClickPresetButton>b__3() { }
}

// Namespace: 
public class GamePresetsTab : MonoBehaviour // TypeDefIndex: 1278
{
	// Fields
	[SerializeField]
	private List<SpriteRenderer> SpritesToDesaturate; // 0x20
	[SerializeField]
	private PassiveButton StandardPresetButton; // 0x28
	[SerializeField]
	private PassiveButton SecondPresetButton; // 0x30
	[SerializeField]
	private GameOptionsMenu GameOptionsMenu; // 0x38
	[SerializeField]
	private SpriteRenderer[] StandardRulesSprites; // 0x40
	[SerializeField]
	private SpriteRenderer[] AlternateRulesSprites; // 0x48
	[SerializeField]
	private TextMeshPro StandardRulesText; // 0x50
	[SerializeField]
	private TextMeshPro AlternateRulesText; // 0x58
	[SerializeField]
	private TextMeshPro PresetDescriptionText; // 0x60
	[SerializeField]
	private TransitionOpen ConfirmPresetPopUp; // 0x68
	[SerializeField]
	private PassiveButton PresetConfirmButton; // 0x70
	[SerializeField]
	private PassiveButton[] PresetCancelButtons; // 0x78
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x80
	public UiElement DefaultButtonSelected; // 0x88
	public List<UiElement> ControllerSelectable; // 0x90

	// Methods

	// RVA: 0x614720 Offset: 0x613920 VA: 0x180614720
	private void OnEnable() { }

	// RVA: 0x6146B0 Offset: 0x6138B0 VA: 0x1806146B0
	private void OnDisable() { }

	// RVA: 0x6148D0 Offset: 0x613AD0 VA: 0x1806148D0
	public void OpenMenu() { }

	// RVA: 0x6146B0 Offset: 0x6138B0 VA: 0x1806146B0
	public void CloseMenu() { }

	// RVA: 0x614BC0 Offset: 0x613DC0 VA: 0x180614BC0
	private void Start() { }

	// RVA: 0x614960 Offset: 0x613B60 VA: 0x180614960
	private void SetSelectedText() { }

	// RVA: 0x614360 Offset: 0x613560 VA: 0x180614360
	private void ClickPresetButton(RulesPresets preset, bool standardButtonSelected) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6151D0 Offset: 0x6143D0 VA: 0x1806151D0
	private void <Start>b__19_0() { }

	[CompilerGenerated]
	// RVA: 0x6151E0 Offset: 0x6143E0 VA: 0x1806151E0
	private void <Start>b__19_1() { }

	[CompilerGenerated]
	// RVA: 0x6152C0 Offset: 0x6144C0 VA: 0x1806152C0
	private void <Start>b__19_2() { }

	[CompilerGenerated]
	// RVA: 0x6152D0 Offset: 0x6144D0 VA: 0x1806152D0
	private void <Start>b__19_3() { }

	[CompilerGenerated]
	// RVA: 0x615340 Offset: 0x614540 VA: 0x180615340
	private void <Start>b__19_4() { }

	[CompilerGenerated]
	// RVA: 0x6152C0 Offset: 0x6144C0 VA: 0x1806152C0
	private void <Start>b__19_5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HatsTab.<>c__DisplayClass2_0 // TypeDefIndex: 1279
{
	// Fields
	public HatData hat; // 0x10
	public HatsTab <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6285B0 Offset: 0x6277B0 VA: 0x1806285B0
	internal void <OnEnable>b__0() { }

	// RVA: 0x6285B0 Offset: 0x6277B0 VA: 0x1806285B0
	internal void <OnEnable>b__3() { }
}

// Namespace: 
public class HatsTab : InventoryTab // TypeDefIndex: 1280
{
	// Fields
	private HatData currentHat; // 0x68
	private bool currentHatIsEquipped; // 0x70

	// Methods

	// RVA: 0x6167D0 Offset: 0x6159D0 VA: 0x1806167D0 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x617190 Offset: 0x616390 VA: 0x180617190
	public void Update() { }

	// RVA: 0x616EF0 Offset: 0x6160F0 VA: 0x180616EF0
	private void SelectHat(HatData hat) { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x6164E0 Offset: 0x6156E0 VA: 0x1806164E0 Slot: 9
	public override string GetCurrentProdID() { }

	// RVA: 0x616270 Offset: 0x615470 VA: 0x180616270 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x616580 Offset: 0x615780 VA: 0x180616580 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6170D0 Offset: 0x6162D0 VA: 0x1806170D0
	private void <OnEnable>b__2_1() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__2_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HostInfoPanel.<SetCosmetics>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1281
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HostInfoPanel <>4__this; // 0x20
	public NetworkedPlayerInfo playerInfo; // 0x28

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

	// RVA: 0x627DE0 Offset: 0x626FE0 VA: 0x180627DE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x627EE0 Offset: 0x6270E0 VA: 0x180627EE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HostInfoPanel : MonoBehaviour // TypeDefIndex: 1282
{
	// Fields
	[SerializeField]
	private GameObject content; // 0x20
	[SerializeField]
	private PoolablePlayer player; // 0x28
	[SerializeField]
	private GameObject playerHolder; // 0x30
	[SerializeField]
	private TextMeshPro playerName; // 0x38
	[SerializeField]
	private TextMeshPro hostLabel; // 0x40
	[SerializeField]
	private Transform hostLabelCenter; // 0x48
	private const float CREW_WIDTH = 0,43;
	private const float CONTENT_CENTER_X = -0,43;
	private float hostWidth; // 0x50
	private bool firstUpdate; // 0x54

	// Methods

	// RVA: 0x6174E0 Offset: 0x6166E0 VA: 0x1806174E0
	public void SetUp() { }

	[IteratorStateMachine(typeof(HostInfoPanel.<SetCosmetics>d__11))]
	// RVA: 0x617470 Offset: 0x616670 VA: 0x180617470
	public IEnumerator SetCosmetics(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x617440 Offset: 0x616640 VA: 0x180617440
	private void Awake() { }

	// RVA: 0x617EC0 Offset: 0x6170C0 VA: 0x180617EC0
	private void Update() { }

	// RVA: 0x617EA0 Offset: 0x6170A0 VA: 0x180617EA0
	private bool ShouldBoldenHostLabel(SupportedLangs language) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class InventoryTab : MonoBehaviour // TypeDefIndex: 1283
{
	// Fields
	public ColorChip ColorTabPrefab; // 0x20
	public PoolablePlayer PlayerPreview; // 0x28
	public FloatRange XRange; // 0x30
	public float YStart; // 0x38
	public float YOffset; // 0x3C
	public int NumPerRow; // 0x40
	public Scroller scroller; // 0x48
	protected int NumRowsVisible; // 0x50
	[HideInInspector]
	public List<ColorChip> ColorChips; // 0x58
	public bool ignoreLongMode; // 0x60

	// Methods

	// RVA: 0x618200 Offset: 0x617400 VA: 0x180618200
	protected bool HasLocalPlayer() { }

	// RVA: 0x618130 Offset: 0x617330 VA: 0x180618130
	protected int GetDisplayColor() { }

	// RVA: 0x618090 Offset: 0x617290 VA: 0x180618090
	public int CurrentColorId() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public virtual void ClickEquip() { }

	// RVA: 0x618380 Offset: 0x617580 VA: 0x180618380 Slot: 5
	public virtual void OnEnable() { }

	// RVA: 0x618280 Offset: 0x617480 VA: 0x180618280 Slot: 6
	public virtual void OnDisable() { }

	// RVA: 0x6180E0 Offset: 0x6172E0 VA: 0x1806180E0 Slot: 7
	public virtual ColorChip GetDefaultSelectable() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public virtual bool IsSelectedItemEquipped() { }

	// RVA: 0x6180A0 Offset: 0x6172A0 VA: 0x1806180A0 Slot: 9
	public virtual string GetCurrentProdID() { }

	// RVA: 0x618470 Offset: 0x617670 VA: 0x180618470
	protected void UpdateMaterials(SpriteRenderer spriteRenderer, CosmeticData data) { }

	// RVA: 0x6183F0 Offset: 0x6175F0 VA: 0x1806183F0
	protected void SetScrollerBounds() { }

	// RVA: 0x618530 Offset: 0x617730 VA: 0x180618530
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LobbyBehaviour.<DelayPlayDropshipAmbience>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1284
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LobbyBehaviour <>4__this; // 0x20

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

	// RVA: 0x627980 Offset: 0x626B80 VA: 0x180627980 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x627B50 Offset: 0x626D50 VA: 0x180627B50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class LobbyBehaviour : InnerNetObject // TypeDefIndex: 1285
{
	// Fields
	public static LobbyBehaviour Instance; // 0x0
	public AudioClip SpawnSound; // 0x38
	public AnimationClip SpawnInClip; // 0x40
	public Vector2[] SpawnPositions; // 0x48
	public AudioClip DropShipSound; // 0x50
	public AudioClip MapTheme; // 0x58
	private const string MAP_THEME_NAME = "MapTheme";
	public SkeldShipRoom[] AllRooms; // 0x60
	private readonly Logger logger; // 0x68
	private float lastFriendsCheckTime; // 0x70
	private float optionsTimer; // 0x74
	private int currentExtensionId; // 0x78

	// Methods

	// RVA: 0x618C50 Offset: 0x617E50 VA: 0x180618C50
	public void Start() { }

	// RVA: 0x6186B0 Offset: 0x6178B0 VA: 0x1806186B0
	private void Update() { }

	// RVA: 0x618B60 Offset: 0x617D60 VA: 0x180618B60
	public void RpcExtendLobbyTimer() { }

	[IteratorStateMachine(typeof(LobbyBehaviour.<DelayPlayDropshipAmbience>d__15))]
	// RVA: 0x618600 Offset: 0x617800 VA: 0x180618600
	private IEnumerator DelayPlayDropshipAmbience() { }

	// RVA: 0x618660 Offset: 0x617860 VA: 0x180618660
	public void FixedUpdate() { }

	// RVA: 0x618A90 Offset: 0x617C90 VA: 0x180618A90 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x618860 Offset: 0x617A60 VA: 0x180618860 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x6186B0 Offset: 0x6178B0 VA: 0x1806186B0
	private void HandleFriendsDataCaching() { }

	// RVA: 0x618810 Offset: 0x617A10 VA: 0x180618810
	private void HandleLobbyTimerExtensionRequest(int timeRemainingSeconds, bool isExtensionAvailable, int hostId, int extensionId, int extendedTimeSeconds) { }

	// RVA: 0x618A40 Offset: 0x617C40 VA: 0x180618A40
	private void LobbyTimerExtended() { }

	// RVA: 0x618D80 Offset: 0x617F80 VA: 0x180618D80
	public void .ctor() { }
}

// Namespace: 
public static class LobbyDebugCommands // TypeDefIndex: 1286
{
	// Fields
	private const string ASSIGN_ROLE_COMMAND = "Game/Roles/Assign Role";
	private const string UNASSIGN_ROLE_COMMAND = "Game/Roles/Un-assign Role";
	private const string PRINT_ROLES_COMMAND = "Game/Roles/Print Roles";

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void AddCommands() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RemoveCommands() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LobbyInfoPane.<CoCopyGameCode>d__24 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1287
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LobbyInfoPane <>4__this; // 0x20

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

	// RVA: 0x6274E0 Offset: 0x6266E0 VA: 0x1806274E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6275C0 Offset: 0x6267C0 VA: 0x1806275C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class LobbyInfoPane : DestroyableSingleton<LobbyInfoPane> // TypeDefIndex: 1288
{
	// Fields
	[SerializeField]
	private SpriteRenderer InfoPaneBackground; // 0x28
	[SerializeField]
	private Sprite InfoPaneInactive; // 0x30
	[SerializeField]
	private Sprite InfoPaneActive; // 0x38
	[SerializeField]
	private UiElement EditButton; // 0x40
	[SerializeField]
	private UiElement HostViewButton; // 0x48
	[SerializeField]
	private UiElement ClientViewButton; // 0x50
	[SerializeField]
	private UiElement CopyCodeButton; // 0x58
	[SerializeField]
	private UiElement ActivateButton; // 0x60
	[SerializeField]
	private UiElement BackButton; // 0x68
	[SerializeField]
	private List<UiElement> ControllerSelectable; // 0x70
	[SerializeField]
	private UiElement HostPrivateButton; // 0x78
	[SerializeField]
	private UiElement HostPublicButton; // 0x80
	[SerializeField]
	private LobbyViewSettingsPane LobbyViewSettingsPane; // 0x88
	[SerializeField]
	private GameObject CopyCodeText; // 0x90
	[SerializeField]
	private AudioClip CopyCodeSound; // 0x98
	private UiElement DefaultButtonSelected; // 0xA0
	private IEnumerator copyGameCodeCoroutine; // 0xA8
	private bool IsPaneActive; // 0xB0

	// Methods

	// RVA: 0x6194B0 Offset: 0x6186B0 VA: 0x1806194B0
	private void OnDisable() { }

	// RVA: 0x6195A0 Offset: 0x6187A0 VA: 0x1806195A0
	private void Update() { }

	// RVA: 0x618E50 Offset: 0x618050 VA: 0x180618E50
	public void ActivatePane() { }

	// RVA: 0x6193A0 Offset: 0x6185A0 VA: 0x1806193A0
	public void DeactivatePane() { }

	// RVA: 0x619540 Offset: 0x618740 VA: 0x180619540
	public void RefreshPane() { }

	// RVA: 0x6191E0 Offset: 0x6183E0 VA: 0x1806191E0
	public void CopyGameCode() { }

	[IteratorStateMachine(typeof(LobbyInfoPane.<CoCopyGameCode>d__24))]
	// RVA: 0x619180 Offset: 0x618380 VA: 0x180619180
	private IEnumerator CoCopyGameCode() { }

	// RVA: 0x619470 Offset: 0x618670 VA: 0x180619470
	private void DisableCopyCodeText() { }

	// RVA: 0x619700 Offset: 0x618900 VA: 0x180619700
	public void .ctor() { }
}

// Namespace: 
public class LobbyViewSettingsPane : MonoBehaviour // TypeDefIndex: 1289
{
	// Fields
	[SerializeField]
	private PassiveButton rolesTabButton; // 0x20
	[SerializeField]
	private PassiveButton taskTabButton; // 0x28
	[SerializeField]
	private ViewSettingsInfoPanel infoPanelOrigin; // 0x30
	[SerializeField]
	private Scroller scrollBar; // 0x38
	[SerializeField]
	private CategoryHeaderMasked categoryHeaderOrigin; // 0x40
	[SerializeField]
	private CategoryHeaderRoleVariant categoryHeaderRoleOrigin; // 0x48
	[SerializeField]
	private ViewSettingsInfoPanelRoleVariant infoPanelRoleOrigin; // 0x50
	[SerializeField]
	private AdvancedRoleViewPanel advancedRolePanelOrigin; // 0x58
	[SerializeField]
	private PassiveButton backButton; // 0x60
	[SerializeField]
	private Transform settingsContainer; // 0x68
	[SerializeField]
	private SpriteRenderer backgroundMask; // 0x70
	[SerializeField]
	private SpriteRenderer areaMask; // 0x78
	[SerializeField]
	private TextMeshPro gameModeText; // 0x80
	private const float START_POS_Y = 1,44;
	private const float START_POS_X = -8,95;
	private const float START_POS_X_ROLES = -6,53;
	private const float START_POS_Y_ROLES = 0,95;
	private const float START_POS_X_ROLES_ADVANCED = -5,8;
	private const float SPACING_X = 5,95;
	private const float SPACING_Y = 0,85;
	private const float SPACING_Y_ROLES = 0,664;
	private const float HEADER_SPACING_Y = 1,05;
	private const float HEADER_START_X = -9,77;
	private const float HEADER_SPACING_Y_ROLES = 0,696;
	private const int MASK_LAYER = 61;
	private List<GameObject> settingsInfo; // 0x88
	private StringNames currentTab; // 0x90
	[SerializeField]
	[Header("Console Controller Navigation")]
	private UiElement BackButton; // 0x98
	[SerializeField]
	private UiElement DefaultButtonSelected; // 0xA0
	[SerializeField]
	private List<UiElement> ControllerSelectable; // 0xA8

	// Methods

	// RVA: 0x619740 Offset: 0x618940 VA: 0x180619740
	private void Awake() { }

	// RVA: 0x61AFF0 Offset: 0x61A1F0 VA: 0x18061AFF0
	private void OnEnable() { }

	// RVA: 0x61AF80 Offset: 0x61A180 VA: 0x18061AF80
	private void OnDisable() { }

	// RVA: 0x61B2E0 Offset: 0x61A4E0 VA: 0x18061B2E0
	private void Update() { }

	// RVA: 0x619AC0 Offset: 0x618CC0 VA: 0x180619AC0
	public void ChangeTab(StringNames category) { }

	// RVA: 0x61B230 Offset: 0x61A430 VA: 0x18061B230
	public void SetTab() { }

	// RVA: 0x61B090 Offset: 0x61A290 VA: 0x18061B090
	public void RefreshTab() { }

	// RVA: 0x61A3C0 Offset: 0x6195C0 VA: 0x18061A3C0
	private void DrawRolesTab() { }

	// RVA: 0x619C60 Offset: 0x618E60 VA: 0x180619C60
	private void DrawNormalTab() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x61B2C0 Offset: 0x61A4C0 VA: 0x18061B2C0
	private void <Awake>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0x61B2D0 Offset: 0x61A4D0 VA: 0x18061B2D0
	private void <Awake>b__30_1() { }
}

// Namespace: 
public class NameplateChip : ColorChip // TypeDefIndex: 1290
{
	// Fields
	public SpriteRenderer image; // 0x68

	// Methods

	// RVA: 0x61C7D0 Offset: 0x61B9D0 VA: 0x18061C7D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NameplatesTab.<>c__DisplayClass4_0 // TypeDefIndex: 1291
{
	// Fields
	public NamePlateData plate; // 0x10
	public ColorChip chip; // 0x18
	public NameplatesTab <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628730 Offset: 0x627930 VA: 0x180628730
	internal void <OnEnable>b__0() { }

	// RVA: 0x628730 Offset: 0x627930 VA: 0x180628730
	internal void <OnEnable>b__3() { }

	// RVA: 0x628760 Offset: 0x627960 VA: 0x180628760
	internal void <OnEnable>b__4(NamePlateViewData viewData) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NameplatesTab.<CoLoadNameplatePreview>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1292
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NameplatesTab <>4__this; // 0x20

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

	// RVA: 0x627600 Offset: 0x626800 VA: 0x180627600 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6276E0 Offset: 0x6268E0 VA: 0x1806276E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class NameplatesTab : InventoryTab // TypeDefIndex: 1293
{
	// Fields
	public PlayerVoteArea previewArea; // 0x68
	private string plateId; // 0x70
	private bool currentNameplateIsEquipped; // 0x78

	// Methods

	// RVA: 0x61C7E0 Offset: 0x61B9E0 VA: 0x18061C7E0
	private void Awake() { }

	// RVA: 0x61CC50 Offset: 0x61BE50 VA: 0x18061CC50 Slot: 5
	public override void OnEnable() { }

	[IteratorStateMachine(typeof(NameplatesTab.<CoLoadNameplatePreview>d__5))]
	// RVA: 0x61C980 Offset: 0x61BB80 VA: 0x18061C980
	private IEnumerator CoLoadNameplatePreview() { }

	// RVA: 0x61D530 Offset: 0x61C730 VA: 0x18061D530
	public void Update() { }

	// RVA: 0x61C7F0 Offset: 0x61B9F0 VA: 0x18061C7F0 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x61D3A0 Offset: 0x61C5A0 VA: 0x18061D3A0
	private void SelectNameplate(NamePlateData plate) { }

	// RVA: 0x61C9E0 Offset: 0x61BBE0 VA: 0x18061C9E0 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x61D490 Offset: 0x61C690 VA: 0x18061D490
	private void <OnEnable>b__4_1() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__4_2() { }
}

// Namespace: 
public class OptionsConsole : MonoBehaviour, IUsable // TypeDefIndex: 1294
{
	// Fields
	public Vector3 CustomPosition; // 0x20
	public bool HostOnly; // 0x2C
	public GameObject MenuPrefab; // 0x30
	public SpriteRenderer Outline; // 0x38
	public ImageNames CustomUseIcon; // 0x40

	// Properties
	public ImageNames UseIcon { get; }
	public float UsableDistance { get; }
	public float PercentCool { get; }

	// Methods

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 6
	public ImageNames get_UseIcon() { }

	// RVA: 0x56EDD0 Offset: 0x56DFD0 VA: 0x18056EDD0 Slot: 4
	public float get_UsableDistance() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 5
	public float get_PercentCool() { }

	// RVA: 0x61D830 Offset: 0x61CA30 VA: 0x18061D830 Slot: 8
	public float CanUse(NetworkedPlayerInfo pc, out bool canUse, out bool couldUse) { }

	// RVA: 0x61D9E0 Offset: 0x61CBE0 VA: 0x18061D9E0 Slot: 7
	public void SetOutline(bool on, bool mainTarget) { }

	// RVA: 0x61DB40 Offset: 0x61CD40 VA: 0x18061DB40 Slot: 9
	public void Use() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PetsTab.<>c__DisplayClass3_0 // TypeDefIndex: 1295
{
	// Fields
	public ColorChip chip; // 0x10
	public PetData pet; // 0x18
	public PetsTab <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628640 Offset: 0x627840 VA: 0x180628640
	internal void <OnEnable>b__0() { }

	// RVA: 0x628670 Offset: 0x627870 VA: 0x180628670
	internal void <OnEnable>b__1() { }

	// RVA: 0x628640 Offset: 0x627840 VA: 0x180628640
	internal void <OnEnable>b__3() { }
}

// Namespace: 
public class PetsTab : InventoryTab // TypeDefIndex: 1296
{
	// Fields
	private string petId; // 0x68
	private bool currentPetIsEquipped; // 0x70
	private bool initialized; // 0x71

	// Methods

	// RVA: 0x61E1E0 Offset: 0x61D3E0 VA: 0x18061E1E0 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x61EA80 Offset: 0x61DC80 VA: 0x18061EA80
	public void Update() { }

	// RVA: 0x61E9C0 Offset: 0x61DBC0 VA: 0x18061E9C0
	private void SelectPet(ColorChip sender, PetData pet) { }

	// RVA: 0x61DE80 Offset: 0x61D080 VA: 0x18061DE80 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x61E010 Offset: 0x61D210 VA: 0x18061E010 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 9
	public override string GetCurrentProdID() { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__3_2() { }
}

// Namespace: 
[Serializable]
public class TabButton // TypeDefIndex: 1297
{
	// Fields
	public TextMeshPro tabText; // 0x10
	public SpriteRenderer Button; // 0x18
	public InventoryTab Tab; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class PlayerCustomizationMenu : MonoBehaviour // TypeDefIndex: 1298
{
	// Fields
	public static PlayerCustomizationMenu Instance; // 0x0
	public GameObject cosmicubeMenuTab; // 0x20
	public CubesTab cubesTab; // 0x28
	public TabButton[] Tabs; // 0x30
	private int selectedTab; // 0x38
	private bool cubeTabSelected; // 0x3C
	[SerializeField]
	private AudioClip swapTabSound; // 0x40
	public PoolablePlayer PreviewArea; // 0x48
	public GameObject equipButton; // 0x50
	public GameObject equippedText; // 0x58
	public GameObject nameplateMaskArea; // 0x60
	public GameObject cubeArea; // 0x68
	public GameObject cosmicubeMenu; // 0x70
	public TextMeshPro itemName; // 0x78
	public Action OnClose; // 0x80
	public Action OnOpen; // 0x88
	public GameObject AprilFoolText; // 0x90
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x98
	public UiElement DefaultButtonSelected; // 0xA0
	public List<UiElement> ControllerSelectable; // 0xA8
	public GameObject glyphL; // 0xB0
	public GameObject glyphR; // 0xB8
	private readonly Logger logger; // 0xC0

	// Methods

	// RVA: 0x61F380 Offset: 0x61E580 VA: 0x18061F380
	private void OnDisable() { }

	// RVA: 0x620070 Offset: 0x61F270 VA: 0x180620070
	public void Start() { }

	// RVA: 0x61F470 Offset: 0x61E670 VA: 0x18061F470
	public void OpenTab(InventoryTab tab) { }

	// RVA: 0x61EE00 Offset: 0x61E000 VA: 0x18061EE00
	private void CloseAllTabs() { }

	// RVA: 0x61F080 Offset: 0x61E280 VA: 0x18061F080
	private void HandleSelection(List<ColorChip> buttons, ColorChip selectedChip) { }

	// RVA: 0x61FF70 Offset: 0x61F170 VA: 0x18061FF70
	public void Open() { }

	// RVA: 0x61EE80 Offset: 0x61E080 VA: 0x18061EE80
	public void Close(bool canMove) { }

	// RVA: 0x61F000 Offset: 0x61E200 VA: 0x18061F000
	private void DestroyObj() { }

	// RVA: 0x6202E0 Offset: 0x61F4E0 VA: 0x1806202E0
	private void Update() { }

	// RVA: 0x6208B0 Offset: 0x61FAB0 VA: 0x1806208B0
	public void ViewCube() { }

	// RVA: 0x620040 Offset: 0x61F240 VA: 0x180620040
	public void SetItemName(string text) { }

	// RVA: 0x61ED60 Offset: 0x61DF60 VA: 0x18061ED60
	public void ClickEquip() { }

	// RVA: 0x61F2F0 Offset: 0x61E4F0 VA: 0x18061F2F0
	private void OnDestroy() { }

	// RVA: 0x620900 Offset: 0x61FB00 VA: 0x180620900
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x620290 Offset: 0x61F490 VA: 0x180620290
	private void <Open>b__28_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerTab.<>c__DisplayClass5_0 // TypeDefIndex: 1299
{
	// Fields
	public int j; // 0x10
	public PlayerTab <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628880 Offset: 0x627A80 VA: 0x180628880
	internal void <OnEnable>b__0() { }

	// RVA: 0x628880 Offset: 0x627A80 VA: 0x180628880
	internal void <OnEnable>b__3() { }
}

// Namespace: 
public class PlayerTab : InventoryTab // TypeDefIndex: 1300
{
	// Fields
	private const int Columns = 4;
	public Transform ColorTabArea; // 0x68
	private HashSet<int> AvailableColors; // 0x70
	private bool currentColorIsEquipped; // 0x78
	private int currentColor; // 0x7C

	// Methods

	// RVA: 0x6220A0 Offset: 0x6212A0 VA: 0x1806220A0 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x622A10 Offset: 0x621C10 VA: 0x180622A10
	public void Update() { }

	// RVA: 0x622690 Offset: 0x621890 VA: 0x180622690
	private void SelectColor(int colorId) { }

	// RVA: 0x621FC0 Offset: 0x6211C0 VA: 0x180621FC0 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x621E20 Offset: 0x621020 VA: 0x180621E20 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x622870 Offset: 0x621A70 VA: 0x180622870
	private void UpdateAvailableColors() { }

	// RVA: 0x622B60 Offset: 0x621D60 VA: 0x180622B60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x622840 Offset: 0x621A40 VA: 0x180622840
	private void <OnEnable>b__5_1() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__5_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SkinsTab.<>c__DisplayClass2_0 // TypeDefIndex: 1301
{
	// Fields
	public SkinData skin; // 0x10
	public SkinsTab <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x628610 Offset: 0x627810 VA: 0x180628610
	internal void <OnEnable>b__0() { }

	// RVA: 0x628610 Offset: 0x627810 VA: 0x180628610
	internal void <OnEnable>b__3() { }
}

// Namespace: 
public class SkinsTab : InventoryTab // TypeDefIndex: 1302
{
	// Fields
	private string skinId; // 0x68
	private bool currentSkinIsEquipped; // 0x70

	// Methods

	// RVA: 0x626770 Offset: 0x625970 VA: 0x180626770 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x626FD0 Offset: 0x6261D0 VA: 0x180626FD0
	public void Update() { }

	// RVA: 0x626440 Offset: 0x625640 VA: 0x180626440 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x626E60 Offset: 0x626060 VA: 0x180626E60
	private void SelectSkin(SkinData skin) { }

	// RVA: 0x6265D0 Offset: 0x6257D0 VA: 0x1806265D0 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 9
	public override string GetCurrentProdID() { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x626F30 Offset: 0x626130 VA: 0x180626F30
	private void <OnEnable>b__2_1() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__2_2() { }
}

// Namespace: 
public class TabGroup : MonoBehaviour // TypeDefIndex: 1303
{
	// Fields
	public SpriteRenderer Button; // 0x20
	public ButtonRolloverHandler Rollover; // 0x28
	public GameObject Content; // 0x30

	// Methods

	// RVA: 0x627270 Offset: 0x626470 VA: 0x180627270
	internal void Close() { }

	// RVA: 0x627330 Offset: 0x626530 VA: 0x180627330
	internal void Open() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ViewSettingsTabButton : MonoBehaviour // TypeDefIndex: 1304
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VisorsTab.<>c__DisplayClass2_0 // TypeDefIndex: 1305
{
	// Fields
	public VisorData visor; // 0x10
	public VisorsTab <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6285E0 Offset: 0x6277E0 VA: 0x1806285E0
	internal void <OnEnable>b__0() { }

	// RVA: 0x6285E0 Offset: 0x6277E0 VA: 0x1806285E0
	internal void <OnEnable>b__3() { }
}

// Namespace: 
public class VisorsTab : InventoryTab // TypeDefIndex: 1306
{
	// Fields
	private string visorId; // 0x68
	private bool currentVisorIsEquipped; // 0x70

	// Methods

	// RVA: 0x6298C0 Offset: 0x628AC0 VA: 0x1806298C0 Slot: 5
	public override void OnEnable() { }

	// RVA: 0x62A2B0 Offset: 0x6294B0 VA: 0x18062A2B0
	public void Update() { }

	// RVA: 0x629400 Offset: 0x628600 VA: 0x180629400 Slot: 4
	public override void ClickEquip() { }

	// RVA: 0x629700 Offset: 0x628900 VA: 0x180629700 Slot: 7
	public override ColorChip GetDefaultSelectable() { }

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 8
	public override bool IsSelectedItemEquipped() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 9
	public override string GetCurrentProdID() { }

	// RVA: 0x62A000 Offset: 0x629200 VA: 0x18062A000
	private void SelectVisor(VisorData visor) { }

	// RVA: 0x600820 Offset: 0x5FFA20 VA: 0x180600820
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x62A210 Offset: 0x629410 VA: 0x18062A210
	private void <OnEnable>b__2_1() { }

	[CompilerGenerated]
	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170
	private void <OnEnable>b__2_2() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapPickerMenu.<>c // TypeDefIndex: 1307
{
	// Fields
	public static readonly MapPickerMenu.<>c <>9; // 0x0
	public static Func<MapFilterButton, UiElement> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x6288B0 Offset: 0x627AB0 VA: 0x1806288B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x627F50 Offset: 0x627150 VA: 0x180627F50
	internal UiElement <Hack_FixDefaultSelection>b__4_0(MapFilterButton m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapPickerMenu.<Hack_FixDefaultSelection>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1308
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapPickerMenu <>4__this; // 0x20

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

	// RVA: 0x627B90 Offset: 0x626D90 VA: 0x180627B90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x627DA0 Offset: 0x626FA0 VA: 0x180627DA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class MapPickerMenu : MonoBehaviour // TypeDefIndex: 1309
{
	// Fields
	[SerializeField]
	private MapFilterButton[] MapButtons; // 0x20
	[SerializeField]
	private CreateOptionsPicker Parent; // 0x28
	[SerializeField]
	private UiElement BackButton; // 0x30

	// Methods

	// RVA: 0x61B6E0 Offset: 0x61A8E0 VA: 0x18061B6E0
	private void OnEnable() { }

	[IteratorStateMachine(typeof(MapPickerMenu.<Hack_FixDefaultSelection>d__4))]
	// RVA: 0x61B610 Offset: 0x61A810 VA: 0x18061B610
	private IEnumerator Hack_FixDefaultSelection() { }

	// RVA: 0x61B670 Offset: 0x61A870 VA: 0x18061B670
	private void OnDisable() { }

	// RVA: 0x61B7E0 Offset: 0x61A9E0 VA: 0x18061B7E0
	public void UpdateMapButtons(int mapid) { }

	// RVA: 0x61B780 Offset: 0x61A980 VA: 0x18061B780
	public void SetMap(int mapId) { }

	// RVA: 0x537E50 Offset: 0x537050 VA: 0x180537E50
	public void Open() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public interface IConnectButton // TypeDefIndex: 1310
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartIcon();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopIcon();
}

// Namespace: 
public class MatchMaker : DestroyableSingleton<MatchMaker> // TypeDefIndex: 1311
{
	// Fields
	public TextBoxTMP GameIdText; // 0x28
	private MonoBehaviour Connecter; // 0x30

	// Methods

	// RVA: 0x61C430 Offset: 0x61B630 VA: 0x18061C430
	public void Start() { }

	// RVA: -1 Offset: -1
	public bool Connecting<T>(T button) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA46F60 Offset: 0xA46160 VA: 0x180A46F60
	|-MatchMaker.Connecting<object>
	*/

	// RVA: 0x61C2D0 Offset: 0x61B4D0 VA: 0x18061C2D0
	public void NotConnecting() { }

	// RVA: 0x61C550 Offset: 0x61B750 VA: 0x18061C550
	public void .ctor() { }
}

// Namespace: 
public class MatchMakerGameButton : PoolableBehavior, IConnectButton // TypeDefIndex: 1312
{
	// Fields
	public TextMeshPro NameText; // 0x30
	public TextMeshPro SmallNameText; // 0x38
	public TextMeshPro PlayerCountText; // 0x40
	public TextMeshPro ImpostorCountText; // 0x48
	public SpriteRenderer MapIcon; // 0x50
	public PlatformIdentifier PlatformIdentifier; // 0x58
	public TextMeshPro LanguageText; // 0x60
	public Sprite[] MapIcons; // 0x68
	public SpriteAnim connectIcon; // 0x70
	public AnimationClip connectClip; // 0x78
	public GameListing myListing; // 0x80

	// Methods

	// RVA: 0x61BCA0 Offset: 0x61AEA0 VA: 0x18061BCA0
	public void OnClick() { }

	// RVA: 0x61C230 Offset: 0x61B430 VA: 0x18061C230 Slot: 5
	public void StartIcon() { }

	// RVA: 0x61C260 Offset: 0x61B460 VA: 0x18061C260 Slot: 6
	public void StopIcon() { }

	// RVA: 0x61BE70 Offset: 0x61B070 VA: 0x18061BE70
	public void SetGame(GameListing gameListing) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public class MatchmakerToken // TypeDefIndex: 1313
{
	// Fields
	public readonly MatchmakerTokenPayload Content; // 0x10
	public readonly string Hash; // 0x18

	// Properties
	[JsonIgnore]
	public bool IsValid { get; }

	// Methods

	// RVA: 0x61C710 Offset: 0x61B910 VA: 0x18061C710
	public bool get_IsValid() { }

	[JsonConstructor]
	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(MatchmakerTokenPayload content, string hash) { }

	// RVA: 0x61C5E0 Offset: 0x61B7E0 VA: 0x18061C5E0
	public static bool TryParse(string base64Json, out MatchmakerToken token) { }
}

// Namespace: 
public class MatchmakerTokenPayload // TypeDefIndex: 1314
{
	// Fields
	public readonly string Puid; // 0x10
	public readonly int ClientVersion; // 0x18
	public readonly DateTime ExpiresAt; // 0x20

	// Methods

	// RVA: 0x61C590 Offset: 0x61B790 VA: 0x18061C590
	public void .ctor(string puid, int clientVersion, DateTime expiresAt) { }
}

// Namespace: 
public class MMOnlineManager : DestroyableSingleton<MMOnlineManager> // TypeDefIndex: 1315
{
	// Fields
	public GameObject HelpMenu; // 0x28
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x30
	public UiElement DefaultButtonSelected; // 0x38
	public List<UiElement> ControllerSelectable; // 0x40
	public bool IsControllerManagerSceneInit; // 0x48

	// Methods

	// RVA: 0x61B330 Offset: 0x61A530 VA: 0x18061B330
	public void Start() { }

	// RVA: 0x61B580 Offset: 0x61A780 VA: 0x18061B580
	private void Update() { }

	// RVA: 0x61B5D0 Offset: 0x61A7D0 VA: 0x18061B5D0
	public void .ctor() { }
}

// Namespace: 
public enum NetworkModes // TypeDefIndex: 1316
{
	// Fields
	public int value__; // 0x0
	public const NetworkModes LocalGame = 0;
	public const NetworkModes OnlineGame = 1;
	public const NetworkModes FreePlay = 2;
}

// Namespace: 
public class PlayerCustomization // TypeDefIndex: 1317
{
	// Methods

	// RVA: 0x621340 Offset: 0x620540 VA: 0x180621340
	public static void Equip(CosmeticData cosmetic) { }

	// RVA: 0x620D50 Offset: 0x61FF50 VA: 0x180620D50
	public static void EquipPet(PetData pet) { }

	// RVA: 0x620EA0 Offset: 0x6200A0 VA: 0x180620EA0
	public static void EquipSkin(SkinData skin) { }

	// RVA: 0x6209C0 Offset: 0x61FBC0 VA: 0x1806209C0
	public static void EquipHat(HatData hat) { }

	// RVA: 0x620C00 Offset: 0x61FE00 VA: 0x180620C00
	public static void EquipNameplate(NamePlateData nameplate) { }

	// RVA: 0x620FF0 Offset: 0x6201F0 VA: 0x180620FF0
	public static void EquipVisor(VisorData visor) { }

	// RVA: 0x621970 Offset: 0x620B70 VA: 0x180621970
	public static bool IsEquipped(CosmeticData cosmetic) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TryUnlockAll() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class PlayerParticle : PoolableBehavior // TypeDefIndex: 1318
{
	// Fields
	public SpriteRenderer myRend; // 0x30
	public float maxDistance; // 0x38
	public Vector2 velocity; // 0x3C
	public float angularVelocity; // 0x44
	[CompilerGenerated]
	private Camera <FollowCamera>k__BackingField; // 0x48
	private Vector3 lastCamera; // 0x50

	// Properties
	public Camera FollowCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Camera get_FollowCamera() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_FollowCamera(Camera value) { }

	// RVA: 0x633150 Offset: 0x632350 VA: 0x180633150
	public void Update() { }

	// RVA: 0x633460 Offset: 0x632660 VA: 0x180633460
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchaseButton.<>c__DisplayClass34_0 // TypeDefIndex: 1319
{
	// Fields
	public HatData prod; // 0x10
	public PurchaseButton <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C6F0 Offset: 0x63B8F0 VA: 0x18063C6F0
	internal void <SetItem>b__0(HatViewData viewAsset) { }
}

// Namespace: 
public class PurchaseButton : MonoBehaviour // TypeDefIndex: 1320
{
	// Fields
	private const float normalSize = 1,75;
	[CompilerGenerated]
	private StoreMenu <Parent>k__BackingField; // 0x20
	[Header("Icons")]
	public SpriteRenderer PurchasedIcon; // 0x28
	public SpriteRenderer LimitedTimeIcon; // 0x30
	public UpdateProductTimerDisplay LimitedTimeText; // 0x38
	public SpriteRenderer CrewHeadImage; // 0x40
	public HatParent HatImage; // 0x48
	public VisorLayer VisorLayer; // 0x50
	public Sprite MannequinFrame; // 0x58
	public LoadingSpinner LoadingIndicator; // 0x60
	[Header("Background")]
	public SpriteRenderer Background; // 0x68
	public SpriteRenderer SelectionHighlight; // 0x70
	public SpriteRenderer GlassSprite; // 0x78
	public SpriteRenderer GlassMask; // 0x80
	public SpriteRenderer ImageMask; // 0x88
	public SpriteRenderer PurchasedOverlay; // 0x90
	[Header("Button")]
	public BoxCollider2D clickCollider; // 0x98
	public PassiveButton PassiveButton; // 0xA0
	[Header("Product Info")]
	public TextMeshPro NameText; // 0xA8
	public TextMeshPro PriceText; // 0xB0
	public bool Purchased; // 0xB8
	public string Name; // 0xC0
	public string Price; // 0xC8
	public string ProductId; // 0xD0
	public GameObject PriceLabel; // 0xD8
	[Header("Label")]
	public SpriteRenderer LabelMask; // 0xE0
	public SpriteRenderer LabelBackground; // 0xE8
	public SpriteRenderer LabelGlass; // 0xF0
	public IBuyable Product; // 0xF8
	private Action onDestroy; // 0x100

	// Properties
	public StoreMenu Parent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public StoreMenu get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Parent(StoreMenu value) { }

	// RVA: 0x635830 Offset: 0x634A30 VA: 0x180635830 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x634180 Offset: 0x633380 VA: 0x180634180 Slot: 5
	public virtual void SetItem(IBuyable product, string productId, string name, string price, bool purchased, CurrencyTypes currency) { }

	// RVA: 0x633BF0 Offset: 0x632DF0 VA: 0x180633BF0
	private void SetDoubleBig() { }

	// RVA: 0x6356D0 Offset: 0x6348D0 VA: 0x1806356D0
	private void SetSquare() { }

	// RVA: 0x633B80 Offset: 0x632D80 VA: 0x180633B80
	public void DoPurchase() { }

	// RVA: 0x633BB0 Offset: 0x632DB0 VA: 0x180633BB0
	private void OnDestroy() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x635C00 Offset: 0x634E00 VA: 0x180635C00
	private void <SetItem>b__34_1(NamePlateViewData viewAsset) { }

	[CompilerGenerated]
	// RVA: 0x635C80 Offset: 0x634E80 VA: 0x180635C80
	private void <SetItem>b__34_2(Sprite sprite) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RegionMenu.<>c // TypeDefIndex: 1321
{
	// Fields
	public static readonly RegionMenu.<>c <>9; // 0x0
	public static Func<IRegionInfo, uint> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x63CC40 Offset: 0x63BE40 VA: 0x18063CC40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C5C0 Offset: 0x63B7C0 VA: 0x18063C5C0
	internal uint <OnEnable>b__6_0(IRegionInfo s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegionMenu.<>c__DisplayClass6_0 // TypeDefIndex: 1322
{
	// Fields
	public IRegionInfo s; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C9A0 Offset: 0x63BBA0 VA: 0x18063C9A0
	internal bool <OnEnable>b__1(IRegionInfo d) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegionMenu.<>c__DisplayClass6_1 // TypeDefIndex: 1323
{
	// Fields
	public IRegionInfo region; // 0x10
	public RegionMenu <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63CA20 Offset: 0x63BC20 VA: 0x18063CA20
	internal void <OnEnable>b__2() { }
}

// Namespace: 
public class RegionMenu : MonoBehaviour // TypeDefIndex: 1324
{
	// Fields
	public ObjectPoolBehavior ButtonPool; // 0x20
	public TextMeshPro RegionText; // 0x28
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x30
	private UiElement defaultButtonSelected; // 0x38
	private List<UiElement> controllerSelectable; // 0x40

	// Methods

	// RVA: 0x635D80 Offset: 0x634F80 VA: 0x180635D80
	private void Awake() { }

	// RVA: 0x635FC0 Offset: 0x6351C0 VA: 0x180635FC0
	public void OnEnable() { }

	// RVA: 0x636AD0 Offset: 0x635CD0 VA: 0x180636AD0
	private void OpenCustomRegion() { }

	// RVA: 0x635F40 Offset: 0x635140 VA: 0x180635F40
	public void OnDisable() { }

	// RVA: 0x537E50 Offset: 0x537050 VA: 0x180537E50
	public void Open() { }

	// RVA: 0x635DF0 Offset: 0x634FF0 VA: 0x180635DF0
	public void ChooseOption(IRegionInfo region) { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ServerListButton : PoolableBehavior // TypeDefIndex: 1325
{
	// Fields
	public TextMeshPro Text; // 0x30
	public PassiveButton Button; // 0x38
	public SpriteRenderer Background; // 0x40
	public TextTranslatorTMP textTranslator; // 0x48

	// Methods

	// RVA: 0x638410 Offset: 0x637610 VA: 0x180638410
	public void SetSelected(bool selected) { }

	// RVA: 0x638530 Offset: 0x637730 VA: 0x180638530
	public void SetTextTranslationId(StringNames id, string defaultStr) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }
}

// Namespace: 
public class ShiftButtonsCrossplayEnabled : MonoBehaviour // TypeDefIndex: 1326
{
	// Fields
	[SerializeField]
	private GameObject crossplayObj; // 0x20
	[SerializeField]
	private GameObject chatTypeHelpMenu; // 0x28
	private const float shiftAmt = 1,11;

	// Methods

	// RVA: 0x638560 Offset: 0x637760 VA: 0x180638560
	private void Start() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private enum MedScanMinigame.PositionState // TypeDefIndex: 1327
{
	// Fields
	public int value__; // 0x0
	public const MedScanMinigame.PositionState None = 0;
	public const MedScanMinigame.PositionState WalkingToPad = 1;
	public const MedScanMinigame.PositionState WalkingToOffset = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class MedScanMinigame.<WalkToOffset>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1328
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MedScanMinigame <>4__this; // 0x20

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

	// RVA: 0x63CCA0 Offset: 0x63BEA0 VA: 0x18063CCA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63CFE0 Offset: 0x63C1E0 VA: 0x18063CFE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MedScanMinigame.<WalkToPad>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1329
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MedScanMinigame <>4__this; // 0x20

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

	// RVA: 0x63D020 Offset: 0x63C220 VA: 0x18063D020 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63D270 Offset: 0x63C470 VA: 0x18063D270 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class MedScanMinigame : Minigame // TypeDefIndex: 1330
{
	// Fields
	private const int SomeKindOfPrimeNumber = 7;
	private static readonly string[] BloodTypes; // 0x0
	public TextMeshPro text; // 0x88
	public TextMeshPro charStats; // 0x90
	public HorizontalGauge gauge; // 0x98
	private MedScanSystem medscan; // 0xA0
	public float ScanDuration; // 0xA8
	public float ScanTimer; // 0xAC
	private string completeString; // 0xB0
	public AudioClip ScanSound; // 0xB8
	public AudioClip TextSound; // 0xC0
	private Coroutine walking; // 0xC8
	private MedScanMinigame.PositionState state; // 0xD0

	// Methods

	// RVA: 0x62F700 Offset: 0x62E900 VA: 0x18062F700 Slot: 5
	public override void Begin(PlayerTask task) { }

	[IteratorStateMachine(typeof(MedScanMinigame.<WalkToOffset>d__15))]
	// RVA: 0x6306E0 Offset: 0x62F8E0 VA: 0x1806306E0
	private IEnumerator WalkToOffset() { }

	[IteratorStateMachine(typeof(MedScanMinigame.<WalkToPad>d__16))]
	// RVA: 0x630740 Offset: 0x62F940 VA: 0x180630740
	private IEnumerator WalkToPad() { }

	// RVA: 0x62FF50 Offset: 0x62F150 VA: 0x18062FF50
	private void FixedUpdate() { }

	// RVA: 0x62FDA0 Offset: 0x62EFA0 VA: 0x18062FDA0 Slot: 6
	public override void Close() { }

	// RVA: 0x630900 Offset: 0x62FB00 VA: 0x180630900
	public void .ctor() { }

	// RVA: 0x6307A0 Offset: 0x62F9A0 VA: 0x1806307A0
	private static void .cctor() { }
}

// Namespace: 
public class MedScannerBehaviour : MonoBehaviour // TypeDefIndex: 1331
{
	// Fields
	public Vector3 Offset; // 0x20

	// Properties
	public Vector3 Position { get; }

	// Methods

	// RVA: 0x630F60 Offset: 0x630160 VA: 0x180630F60
	public Vector3 get_Position() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MedScanSystem.<>c__DisplayClass14_0 // TypeDefIndex: 1332
{
	// Fields
	public byte playerId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C6E0 Offset: 0x63B8E0 VA: 0x18063C6E0
	internal bool <UpdateSystem>b__0(byte v) { }
}

// Namespace: 
public class MedScanSystem : ISystemType // TypeDefIndex: 1333
{
	// Fields
	public const byte Request = 128;
	public const byte Release = 64;
	public const byte NumMask = 31;
	public const byte NoPlayer = 255;
	public List<byte> UsersList; // 0x10
	[CompilerGenerated]
	private byte <CurrentUser>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x19

	// Properties
	public byte CurrentUser { get; set; }
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public byte get_CurrentUser() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void set_CurrentUser(byte value) { }

	[CompilerGenerated]
	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	private void set_IsDirty(bool value) { }

	// RVA: 0x630A30 Offset: 0x62FC30 VA: 0x180630A30 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x630CD0 Offset: 0x62FED0 VA: 0x180630CD0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x630BF0 Offset: 0x62FDF0 VA: 0x180630BF0 Slot: 7
	public void MarkClean() { }

	// RVA: 0x630C00 Offset: 0x62FE00 VA: 0x180630C00 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x630920 Offset: 0x62FB20 VA: 0x180630920 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x630ED0 Offset: 0x6300D0 VA: 0x180630ED0
	public void .ctor() { }
}

// Namespace: 
public enum SampleMinigame.States // TypeDefIndex: 1334
{
	// Fields
	public byte value__; // 0x0
	public const SampleMinigame.States PrepareSample = 0;
	public const SampleMinigame.States Complete = 16;
	public const SampleMinigame.States AwaitingStart = 32;
	public const SampleMinigame.States Selection = 64;
	public const SampleMinigame.States Processing = 128;
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<BringPanelDown>d__36 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1335
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SampleMinigame <>4__this; // 0x20
	private WaitForFixedUpdate <wait>5__2; // 0x28
	private Vector3 <pos>5__3; // 0x30
	private float <i>5__4; // 0x3C

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

	// RVA: 0x6389D0 Offset: 0x637BD0 VA: 0x1806389D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x638C60 Offset: 0x637E60 VA: 0x180638C60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<BringPanelUp>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1336
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SampleMinigame <>4__this; // 0x20
	public bool isBeginning; // 0x28
	private WaitForFixedUpdate <wait>5__2; // 0x30
	private Vector3 <pos>5__3; // 0x38
	private float <i>5__4; // 0x44

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

	// RVA: 0x638CA0 Offset: 0x637EA0 VA: 0x180638CA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x639060 Offset: 0x638260 VA: 0x180639060 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<CoSelectTube>d__39 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1337
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int selectedTube; // 0x20
	public int correctTube; // 0x24
	public SampleMinigame <>4__this; // 0x28

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

	// RVA: 0x639990 Offset: 0x638B90 VA: 0x180639990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63A250 Offset: 0x639450 VA: 0x18063A250 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<CoStartProcessing>d__41 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1338
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SampleMinigame <>4__this; // 0x20

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

	// RVA: 0x63A290 Offset: 0x639490 VA: 0x18063A290 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63A4A0 Offset: 0x6396A0 VA: 0x18063A4A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<DropLiquid>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1339
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SampleMinigame <>4__this; // 0x20
	private WaitForSeconds <dropWait>5__2; // 0x28
	private WaitForFixedUpdate <wait>5__3; // 0x30
	private Vector3 <pos>5__4; // 0x38
	private Vector2 <vPositionDelta>5__5; // 0x44
	private Vector2 <vPosition>5__6; // 0x4C
	private int <step>5__7; // 0x54
	private float <start>5__8; // 0x58
	private float <xTarg>5__9; // 0x5C
	private float <i>5__10; // 0x60

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

	// RVA: 0x63AB10 Offset: 0x639D10 VA: 0x18063AB10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63B170 Offset: 0x63A370 VA: 0x18063B170 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SampleMinigame.<DropTube>d__37 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1340
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SampleMinigame <>4__this; // 0x20
	public int id; // 0x28

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

	// RVA: 0x63B1B0 Offset: 0x63A3B0 VA: 0x18063B1B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63B310 Offset: 0x63A510 VA: 0x18063B310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SampleMinigame : Minigame // TypeDefIndex: 1341
{
	// Fields
	private static StringNames[] ProcessingStrings; // 0x0
	private const float PanelMoveDuration = 0,75;
	private const byte TubeMask = 15;
	public TextMeshPro UpperText; // 0x88
	public TextMeshPro LowerText; // 0x90
	public float TimePerStep; // 0x98
	public FloatRange platformY; // 0xA0
	public FloatRange dropperX; // 0xA8
	public SpriteRenderer CenterPanel; // 0xB0
	public SpriteRenderer Dropper; // 0xB8
	public SpriteRenderer[] Tubes; // 0xC0
	public SpriteRenderer[] Buttons; // 0xC8
	public SpriteRenderer[] LowerButtons; // 0xD0
	public AudioClip ButtonSound; // 0xD8
	public AudioClip PanelMoveSound; // 0xE0
	public AudioClip FailSound; // 0xE8
	public AudioClip[] DropSounds; // 0xF0
	private RandomFill<AudioClip> dropSounds; // 0xF8
	public Transform whichButtonSelector; // 0x100
	public int whichButtonSelected; // 0x108
	[SerializeField]
	private GameObject phase1_controllerGlyph; // 0x110
	private float selectMoveCooldown; // 0x118

	// Properties
	private SampleMinigame.States State { get; set; }
	private int AnomalyId { get; set; }

	// Methods

	// RVA: 0x638370 Offset: 0x637570 VA: 0x180638370
	private SampleMinigame.States get_State() { }

	// RVA: 0x6383E0 Offset: 0x6375E0 VA: 0x1806383E0
	private void set_State(SampleMinigame.States value) { }

	// RVA: 0x638330 Offset: 0x637530 VA: 0x180638330
	private int get_AnomalyId() { }

	// RVA: 0x6383B0 Offset: 0x6375B0 VA: 0x1806383B0
	private void set_AnomalyId(int value) { }

	// RVA: 0x636B10 Offset: 0x635D10 VA: 0x180636B10
	public void Awake() { }

	// RVA: 0x636C20 Offset: 0x635E20 VA: 0x180636C20 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x637C50 Offset: 0x636E50 VA: 0x180637C50
	private void SetPlatformBottom() { }

	// RVA: 0x637D00 Offset: 0x636F00 VA: 0x180637D00
	private void SetPlatformTop() { }

	// RVA: 0x637DB0 Offset: 0x636FB0 VA: 0x180637DB0
	public void Update() { }

	// RVA: 0x637390 Offset: 0x636590 VA: 0x180637390
	public void FixedUpdate() { }

	[IteratorStateMachine(typeof(SampleMinigame.<BringPanelUp>d__35))]
	// RVA: 0x637170 Offset: 0x636370 VA: 0x180637170
	public IEnumerator BringPanelUp(bool isBeginning) { }

	[IteratorStateMachine(typeof(SampleMinigame.<BringPanelDown>d__36))]
	// RVA: 0x637110 Offset: 0x636310 VA: 0x180637110
	public IEnumerator BringPanelDown() { }

	[IteratorStateMachine(typeof(SampleMinigame.<DropTube>d__37))]
	// RVA: 0x637320 Offset: 0x636520 VA: 0x180637320
	private IEnumerator DropTube(int id) { }

	// RVA: 0x637AE0 Offset: 0x636CE0 VA: 0x180637AE0
	public void SelectTube(int tubeId) { }

	[IteratorStateMachine(typeof(SampleMinigame.<CoSelectTube>d__39))]
	// RVA: 0x6371E0 Offset: 0x6363E0 VA: 0x1806371E0
	private IEnumerator CoSelectTube(int correctTube, int selectedTube) { }

	// RVA: 0x637900 Offset: 0x636B00 VA: 0x180637900
	public void NextStep() { }

	[IteratorStateMachine(typeof(SampleMinigame.<CoStartProcessing>d__41))]
	// RVA: 0x637260 Offset: 0x636460 VA: 0x180637260
	private IEnumerator CoStartProcessing() { }

	[IteratorStateMachine(typeof(SampleMinigame.<DropLiquid>d__42))]
	// RVA: 0x6372C0 Offset: 0x6364C0 VA: 0x1806372C0
	private IEnumerator DropLiquid() { }

	// RVA: 0x638270 Offset: 0x637470 VA: 0x180638270
	public void .ctor() { }

	// RVA: 0x6381F0 Offset: 0x6373F0 VA: 0x1806381F0
	private static void .cctor() { }
}

// Namespace: 
public class MeshAnimator : MonoBehaviour // TypeDefIndex: 1342
{
	// Fields
	private MeshFilter filter; // 0x20
	public Mesh[] Frames; // 0x28
	public float frameRate; // 0x30
	private float timer; // 0x34
	private int frameId; // 0x38
	private Vector3 originalPosition; // 0x3C
	private Vector3 originalScale; // 0x48
	public MeshSequence sequence; // 0x58

	// Methods

	// RVA: 0x630FE0 Offset: 0x6301E0 VA: 0x180630FE0
	private void Awake() { }

	// RVA: 0x631050 Offset: 0x630250 VA: 0x180631050
	private void Start() { }

	// RVA: 0x631090 Offset: 0x630290 VA: 0x180631090
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
private struct CourseMinigame.UIntFloat // TypeDefIndex: 1343
{
	// Fields
	public float FloatValue; // 0x0
	public int IntValue; // 0x0

	// Methods

	// RVA: 0x63D310 Offset: 0x63C510 VA: 0x18063D310
	public float GetFloat(byte[] bytes) { }

	// RVA: 0x63D2B0 Offset: 0x63C4B0 VA: 0x18063D2B0
	public void GetBytes(float value, byte[] bytes) { }
}

// Namespace: 
public class CourseMinigame : Minigame // TypeDefIndex: 1344
{
	// Fields
	public CourseStarBehaviour StarPrefab; // 0x88
	public CourseStarBehaviour[] Stars; // 0x90
	public SpriteRenderer DotPrefab; // 0x98
	public Sprite DotLight; // 0xA0
	public SpriteRenderer[] Dots; // 0xA8
	public Collider2D Ship; // 0xB0
	public CourseStarBehaviour Destination; // 0xB8
	public Vector3[] PathPoints; // 0xC0
	public int NumPoints; // 0xC8
	public FloatRange XRange; // 0xD0
	public FloatRange YRange; // 0xD8
	public LineRenderer Path; // 0xE0
	public Controller myController; // 0xE8
	public float lineTimer; // 0xF0
	private CourseMinigame.UIntFloat Converter; // 0xF4
	public AudioClip SetCourseSound; // 0xF8
	public AudioClip SetCourseLastSound; // 0x100
	private TouchpadBehavior touchpad; // 0x108
	private float initialCurVec; // 0x110
	private float targetCurVec; // 0x114

	// Methods

	// RVA: 0x62B890 Offset: 0x62AA90 VA: 0x18062B890 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x62BFB0 Offset: 0x62B1B0 VA: 0x18062BFB0
	public void FixedUpdate() { }

	// RVA: 0x62CF60 Offset: 0x62C160 VA: 0x18062CF60
	private void SetLineDivision(float curVec) { }

	// RVA: 0x62D1A0 Offset: 0x62C3A0 VA: 0x18062D1A0
	public void .ctor() { }
}

// Namespace: 
public class CourseStarBehaviour : MonoBehaviour // TypeDefIndex: 1345
{
	// Fields
	public SpriteRenderer Upper; // 0x20
	public SpriteRenderer Lower; // 0x28
	public float Speed; // 0x30

	// Methods

	// RVA: 0x62D200 Offset: 0x62C400 VA: 0x18062D200
	public void Update() { }

	// RVA: 0x62D2A0 Offset: 0x62C4A0 VA: 0x18062D2A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NavigationMinigame.<CompleteGame>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1346
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public NavigationMinigame <>4__this; // 0x20
	private WaitForSeconds <wait>5__2; // 0x28
	private Color <green>5__3; // 0x30
	private Color32 <yellow>5__4; // 0x40

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

	// RVA: 0x63A4E0 Offset: 0x6396E0 VA: 0x18063A4E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63AAD0 Offset: 0x639CD0 VA: 0x18063AAD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class NavigationMinigame : Minigame // TypeDefIndex: 1347
{
	// Fields
	public MeshRenderer TwoAxisImage; // 0x88
	public SpriteRenderer CrossHairImage; // 0x90
	public Collider2D hitbox; // 0x98
	private Controller myController; // 0xA0
	private Vector2 crossHair; // 0xA8
	private Vector2 half; // 0xB0
	private Vector2 initialPos; // 0xB8
	private TouchpadBehavior touchpad; // 0xC0
	private bool prevHadInput; // 0xC8

	// Methods

	// RVA: 0x631370 Offset: 0x630570 VA: 0x180631370 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x631640 Offset: 0x630840 VA: 0x180631640
	public void FixedUpdate() { }

	[IteratorStateMachine(typeof(NavigationMinigame.<CompleteGame>d__11))]
	// RVA: 0x6315E0 Offset: 0x6307E0 VA: 0x1806315E0
	private IEnumerator CompleteGame() { }

	// RVA: 0x6320A0 Offset: 0x6312A0 VA: 0x1806320A0
	public void .ctor() { }
}

// Namespace: 
public class RewiredControllerSupport : MonoBehaviour // TypeDefIndex: 1348
{
	// Fields
	public static Action onPostControllersAssigned; // 0x0

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class NoShadowBehaviour : MonoBehaviour // TypeDefIndex: 1349
{
	// Fields
	public Renderer rend; // 0x20
	public bool didHit; // 0x28
	public Renderer shadowChild; // 0x30
	public Collider2D hitOverride; // 0x38
	private BoxCollider2D bc; // 0x40
	private bool isBox; // 0x48
	private bool verticalBox; // 0x49
	private Vector2[] boxCheckPoints; // 0x50
	private const int edgePoints = 4;
	private const int totalPointsPerEdge = 6;

	// Methods

	// RVA: 0x632B40 Offset: 0x631D40 VA: 0x180632B40
	public void Start() { }

	// RVA: 0x632120 Offset: 0x631320 VA: 0x180632120
	private void CalculateBoxEdgeCheckPoints() { }

	// RVA: 0x6329D0 Offset: 0x631BD0 VA: 0x1806329D0
	public void OnDestroy() { }

	// RVA: 0x632A60 Offset: 0x631C60 VA: 0x180632A60
	private void SetMaskFunction(int func) { }

	// RVA: 0x632450 Offset: 0x631650 VA: 0x180632450
	internal void CheckHit(float lightRadius, Vector2 lightPosition) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(TMP_Text))]
public class OpenHyperlinks : MonoBehaviour // TypeDefIndex: 1350
{
	// Fields
	[SerializeField]
	private TextMeshPro pTextMeshPro; // 0x20
	[SerializeField]
	private Color linkColor; // 0x28

	// Properties
	public string Text { get; set; }
	public Color LinkColor { get; set; }

	// Methods

	// RVA: 0x632D20 Offset: 0x631F20 VA: 0x180632D20
	public string get_Text() { }

	// RVA: 0x632D50 Offset: 0x631F50 VA: 0x180632D50
	public void set_Text(string value) { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Color get_LinkColor() { }

	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_LinkColor(Color value) { }

	// RVA: 0x632CA0 Offset: 0x631EA0 VA: 0x180632CA0
	public bool GetWordPosition(string text, List<string> wordsPositioned, out Vector3 bottomLeft, out Vector3 topRight, out int lineBreakCount) { }

	// RVA: 0x632CC0 Offset: 0x631EC0 VA: 0x180632CC0
	public void UpdateTMPMesh() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ParallaxChild : MonoBehaviour // TypeDefIndex: 1351
{
	// Fields
	[HideInInspector]
	public Vector3 BasePosition; // 0x20

	// Methods

	// RVA: 0x632D80 Offset: 0x631F80 VA: 0x180632D80
	public void OnEnable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ParallaxController : MonoBehaviour // TypeDefIndex: 1352
{
	// Fields
	public ParallaxChild[] Children; // 0x20
	public float Scale; // 0x28

	// Methods

	// RVA: 0x632F20 Offset: 0x632120 VA: 0x180632F20
	public void Start() { }

	// RVA: 0x632DC0 Offset: 0x631FC0 VA: 0x180632DC0
	public void SetParallax(float x) { }

	// RVA: 0x558AA0 Offset: 0x557CA0 VA: 0x180558AA0
	public void .ctor() { }
}

// Namespace: 
public class PingTracker : MonoBehaviour // TypeDefIndex: 1353
{
	// Fields
	public TextMeshPro text; // 0x20
	[SerializeField]
	private AspectPosition aspectPosition; // 0x28
	private Vector3 lobbyPos; // 0x30
	private Vector3 gamePos; // 0x3C

	// Methods

	// RVA: 0x632F60 Offset: 0x632160 VA: 0x180632F60
	private void Update() { }

	// RVA: 0x633100 Offset: 0x632300 VA: 0x180633100
	public void .ctor() { }
}

// Namespace: 
public class AnimationOffsetter : MonoBehaviour // TypeDefIndex: 1354
{
	// Fields
	public Animator anim; // 0x20

	// Methods

	// RVA: 0x62A820 Offset: 0x629A20 VA: 0x18062A820
	private void Start() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PolusShipStatus.<>c // TypeDefIndex: 1355
{
	// Fields
	public static readonly PolusShipStatus.<>c <>9; // 0x0
	public static Func<ISystemType, bool> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x63CB80 Offset: 0x63BD80 VA: 0x18063CB80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C580 Offset: 0x63B780 VA: 0x18063C580
	internal bool <OnEnable>b__0_0(ISystemType i) { }
}

// Namespace: 
public class PolusShipStatus : ShipStatus // TypeDefIndex: 1356
{
	// Methods

	// RVA: 0x633470 Offset: 0x632670 VA: 0x180633470 Slot: 11
	protected override void OnEnable() { }

	// RVA: 0x6339F0 Offset: 0x632BF0 VA: 0x1806339F0 Slot: 14
	public override void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn) { }

	// RVA: 0x5528E0 Offset: 0x551AE0 VA: 0x1805528E0
	public void .ctor() { }
}

// Namespace: 
public class SnowAttacher : MonoBehaviour // TypeDefIndex: 1357
{
	// Fields
	public GameObject SnowPrefab; // 0x20

	// Methods

	// RVA: 0x638660 Offset: 0x637860 VA: 0x180638660
	public void Start() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SnowManager.<Run>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1358
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SnowManager <>4__this; // 0x20
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

	// RVA: 0x63C150 Offset: 0x63B350 VA: 0x18063C150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63C510 Offset: 0x63B710 VA: 0x18063C510 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SnowManager : MonoBehaviour // TypeDefIndex: 1359
{
	// Fields
	public ParticleSystem particles; // 0x20
	private ParticleSystemRenderer rend; // 0x28
	private float timer; // 0x30

	// Methods

	// RVA: 0x638850 Offset: 0x637A50 VA: 0x180638850
	private void Start() { }

	[IteratorStateMachine(typeof(SnowManager.<Run>d__4))]
	// RVA: 0x638750 Offset: 0x637950 VA: 0x180638750
	private IEnumerator Run() { }

	// RVA: 0x6387B0 Offset: 0x6379B0 VA: 0x1806387B0
	private void SetPartAlpha() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SupressorBehaviour : MonoBehaviour // TypeDefIndex: 1360
{
	// Fields
	public Sprite ActiveBase; // 0x20
	public Sprite InactiveBase; // 0x28
	public SpriteRenderer BaseImage; // 0x30
	public AnimationClip ElectricActive; // 0x38
	public AnimationClip ElectricInactive; // 0x40
	public SpriteAnim Electric; // 0x48
	public AnimationClip LightsActive; // 0x50
	public AnimationClip LightsInactive; // 0x58
	public SpriteAnim Lights; // 0x60

	// Methods

	// RVA: 0x6388F0 Offset: 0x637AF0 VA: 0x1806388F0
	public void Activate() { }

	// RVA: 0x638960 Offset: 0x637B60 VA: 0x180638960
	public void Deactivate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BoardPassGame.<CoFlipPass>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1361
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BoardPassGame <>4__this; // 0x20

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

	// RVA: 0x6390A0 Offset: 0x6382A0 VA: 0x1806390A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x639430 Offset: 0x638630 VA: 0x180639430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BoardPassGame.<CoPullPass>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1362
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BoardPassGame <>4__this; // 0x20

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

	// RVA: 0x639470 Offset: 0x638670 VA: 0x180639470 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x639650 Offset: 0x638850 VA: 0x180639650 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BoardPassGame.<CoRunBlinky>d__29 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1363
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BoardPassGame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x639690 Offset: 0x638890 VA: 0x180639690 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x639950 Offset: 0x638B50 VA: 0x180639950 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class BoardPassGame : Minigame // TypeDefIndex: 1364
{
	// Fields
	private static Color[] BgColors; // 0x0
	public SpriteRenderer renderer; // 0x88
	public SpriteRenderer pass; // 0x90
	public Sprite passBack; // 0x98
	public TextMeshPro NameText; // 0xA0
	public SpriteRenderer ImageBg; // 0xA8
	public SpriteRenderer Image; // 0xB0
	public Sprite[] Photos; // 0xB8
	public PassiveButton pullButton; // 0xC0
	public PassiveButton flipButton; // 0xC8
	public SpriteRenderer Scanner; // 0xD0
	public Sprite ScannerAccept; // 0xD8
	public Sprite ScannerScanning; // 0xE0
	public Sprite ScannerWaiting; // 0xE8
	public Collider2D Sensor; // 0xF0
	public Collider2D BarCode; // 0xF8
	public AudioClip slideinSound; // 0x100
	public AudioClip flipSound; // 0x108
	public AudioClip scanStartSound; // 0x110
	public AudioClip scanSound; // 0x118
	private Coroutine blinky; // 0x120
	private Controller controller; // 0x128
	private TouchpadBehavior touchpad; // 0x130
	private bool prevHadInput; // 0x138
	private float rotateAngle; // 0x13C
	private Vector2 prevStickDir; // 0x140
	private bool enableControllerPassMovement; // 0x148
	private bool grabbed; // 0x149

	// Methods

	// RVA: 0x62AAC0 Offset: 0x629CC0 VA: 0x18062AAC0
	public void Start() { }

	// RVA: 0x62AF30 Offset: 0x62A130 VA: 0x18062AF30
	public void Update() { }

	[IteratorStateMachine(typeof(BoardPassGame.<CoRunBlinky>d__29))]
	// RVA: 0x62A920 Offset: 0x629B20 VA: 0x18062A920
	private IEnumerator CoRunBlinky() { }

	// RVA: 0x62AA50 Offset: 0x629C50 VA: 0x18062AA50
	public void PullPass() { }

	[IteratorStateMachine(typeof(BoardPassGame.<CoPullPass>d__31))]
	// RVA: 0x62A8C0 Offset: 0x629AC0 VA: 0x18062A8C0
	private IEnumerator CoPullPass() { }

	// RVA: 0x62A9F0 Offset: 0x629BF0 VA: 0x18062A9F0
	public void Grab() { }

	// RVA: 0x62A980 Offset: 0x629B80 VA: 0x18062A980
	public void FlipPass() { }

	[IteratorStateMachine(typeof(BoardPassGame.<CoFlipPass>d__35))]
	// RVA: 0x62A860 Offset: 0x629A60 VA: 0x18062A860
	private IEnumerator CoFlipPass() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }

	// RVA: 0x62B600 Offset: 0x62A800 VA: 0x18062B600
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x62AE20 Offset: 0x62A020 VA: 0x18062AE20
	private void <CoFlipPass>b__35_0(float t) { }

	[CompilerGenerated]
	// RVA: 0x62AEA0 Offset: 0x62A0A0 VA: 0x18062AEA0
	private void <CoFlipPass>b__35_1(float t) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DoorBreakerGame.<>c // TypeDefIndex: 1365
{
	// Fields
	public static readonly DoorBreakerGame.<>c <>9; // 0x0
	public static Func<SpriteRenderer, bool> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x63CBE0 Offset: 0x63BDE0 VA: 0x18063CBE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x63C550 Offset: 0x63B750 VA: 0x18063C550
	internal bool <FlipSwitch>b__5_0(SpriteRenderer s) { }
}

// Namespace: 
public class DoorBreakerGame : Minigame, IDoorMinigame // TypeDefIndex: 1366
{
	// Fields
	public OpenableDoor MyDoor; // 0x88
	public SpriteRenderer[] Buttons; // 0x90
	public AudioClip FlipSound; // 0x98

	// Methods

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0 Slot: 9
	public void SetDoor(OpenableDoor door) { }

	// RVA: 0x62D530 Offset: 0x62C730 VA: 0x18062D530
	public void Start() { }

	// RVA: 0x62D2B0 Offset: 0x62C4B0 VA: 0x18062D2B0
	public void FlipSwitch(SpriteRenderer button) { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
public class DrillMinigame : Minigame // TypeDefIndex: 1367
{
	// Fields
	public SpriteRenderer CaseImage; // 0x88
	public TextMeshPro statusText; // 0x90
	public SpriteAnim[] Buttons; // 0x98
	public AnimationClip BadAnim; // 0xA0
	public AudioClip ButtonSound; // 0xA8
	private int MaxState; // 0xB0
	private int[] states; // 0xB8
	private SpriteAnim prevFixedButton; // 0xC0
	private float changeButtonDelay; // 0xC8
	private int[] drillButtonMaps; // 0xD0

	// Methods

	// RVA: 0x62DD70 Offset: 0x62CF70 VA: 0x18062DD70
	public void Start() { }

	// RVA: 0x62D700 Offset: 0x62C900 VA: 0x18062D700 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x62DDF0 Offset: 0x62CFF0 VA: 0x18062DDF0
	private void Update() { }

	// RVA: 0x62D970 Offset: 0x62CB70 VA: 0x18062D970
	public void FixButton(SpriteAnim button) { }

	// RVA: 0x62E040 Offset: 0x62D240 VA: 0x18062E040
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x62DDE0 Offset: 0x62CFE0 VA: 0x18062DDE0
	private bool <Begin>b__8_0(int s) { }

	[CompilerGenerated]
	// RVA: 0x62DDE0 Offset: 0x62CFE0 VA: 0x18062DDE0
	private bool <FixButton>b__13_0(int ss) { }
}

// Namespace: 
public class CanisterBehaviour : MonoBehaviour // TypeDefIndex: 1368
{
	// Fields
	public Collider2D Hitbox; // 0x20
	public HorizontalSpriteGauge Gauge; // 0x28

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FillCanistersGame.<Run>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1369
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FillCanistersGame <>4__this; // 0x20
	private AudioSource <fillSound>5__2; // 0x28
	private Player <player>5__3; // 0x30
	private float <stickInput>5__4; // 0x38
	private bool <hasNoRemoveInput>5__5; // 0x3C

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

	// RVA: 0x63B350 Offset: 0x63A550 VA: 0x18063B350 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x63C110 Offset: 0x63B310 VA: 0x18063C110 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FillCanistersGame : Minigame // TypeDefIndex: 1370
{
	// Fields
	private Vector3 CanisterAppearPosition; // 0x88
	private Vector3 CanisterStartPosition; // 0x94
	private Vector3 CanisterDragPosition; // 0xA0
	private Vector3 CanisterSnapPosition; // 0xAC
	private Vector3 CanisterAwayPosition; // 0xB8
	public float FillTime; // 0xC4
	public CanisterBehaviour Canister; // 0xC8
	private Controller controller; // 0xD0
	public AudioClip FillLoop; // 0xD8
	public AudioClip DropSound; // 0xE0
	public AudioClip GrabSound; // 0xE8
	public AudioClip PlugInSound; // 0xF0
	public AudioClip PlugOutSound; // 0xF8
	private TouchpadBehavior touchpad; // 0x100
	private bool prevHadInput; // 0x108

	// Methods

	// RVA: 0x62E1B0 Offset: 0x62D3B0 VA: 0x18062E1B0
	public void Start() { }

	// RVA: 0x62E0E0 Offset: 0x62D2E0 VA: 0x18062E0E0 Slot: 6
	public override void Close() { }

	[IteratorStateMachine(typeof(FillCanistersGame.<Run>d__17))]
	// RVA: 0x62E150 Offset: 0x62D350 VA: 0x18062E150
	private IEnumerator Run() { }

	// RVA: 0x62E290 Offset: 0x62D490 VA: 0x18062E290
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x62E260 Offset: 0x62D460 VA: 0x18062E260
	private void <Run>b__17_0(float t) { }
}

// Namespace: 
public class WaterStage : Minigame // TypeDefIndex: 1371
{
	// Fields
	public float RefuelDuration; // 0x88
	public SpriteRenderer waterButton; // 0x90
	public Sprite buttonDownSprite; // 0x98
	public Sprite buttonUpSprite; // 0xA0
	public VerticalGauge srcGauge; // 0xA8
	public VerticalGauge destGauge; // 0xB0
	public AudioClip RefuelSound; // 0xB8
	private float timer; // 0xC0
	private bool isDown; // 0xC4
	private bool complete; // 0xC5

	// Methods

	// RVA: 0x63D370 Offset: 0x63C570 VA: 0x18063D370 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x63D4B0 Offset: 0x63C6B0 VA: 0x18063D4B0
	public void FixedUpdate() { }

	// RVA: 0x63D910 Offset: 0x63CB10 VA: 0x18063D910
	public void Refuel() { }

	// RVA: 0x63D850 Offset: 0x63CA50 VA: 0x18063D850
	private void GetRefuelDynamics(AudioSource player, float dt) { }

	// RVA: 0x63D3D0 Offset: 0x63C5D0 VA: 0x18063D3D0 Slot: 6
	public override void Close() { }

	// RVA: 0x63DB30 Offset: 0x63CD30 VA: 0x18063DB30
	public void .ctor() { }
}

// Namespace: 
public class KeyMinigame : Minigame // TypeDefIndex: 1372
{
	// Fields
	public KeySlotBehaviour[] Slots; // 0x88
	private int keyState; // 0x90
	public SpriteRenderer KeyImage; // 0x98
	public Sprite normalImage; // 0xA0
	public Sprite insertImage; // 0xA8
	public BoxCollider2D key; // 0xB0
	private int targetSlotId; // 0xB8
	private Controller controller; // 0xC0
	public AudioClip KeyGrab; // 0xC8
	public AudioClip KeyInsert; // 0xD0
	public AudioClip KeyOpen; // 0xD8
	public AudioClip KeyTurn; // 0xE0
	private TouchpadBehavior touchpad; // 0xE8
	private Vector3 initialPos; // 0xF0
	private bool prevHadInput; // 0xFC
	private Vector2 prevInputDir; // 0x100
	private float currentAngle; // 0x108
	public GameObject moveKeyGlyph; // 0x110
	public GameObject turnKeyGlyph; // 0x118

	// Methods

	// RVA: 0x62E390 Offset: 0x62D590 VA: 0x18062E390
	public void Start() { }

	// RVA: 0x62E510 Offset: 0x62D710 VA: 0x18062E510
	public void Update() { }

	// RVA: 0x62F6A0 Offset: 0x62E8A0 VA: 0x18062F6A0
	public void .ctor() { }
}

// Namespace: 
public class KeySlotBehaviour : MonoBehaviour // TypeDefIndex: 1373
{
	// Fields
	public Sprite Highlit; // 0x20
	public Sprite Inserted; // 0x28
	public Sprite Finished; // 0x30
	public SpriteRenderer Image; // 0x38
	public BoxCollider2D Hitbox; // 0x40

	// Methods

	// RVA: 0x6539E0 Offset: 0x652BE0 VA: 0x1806539E0
	internal void SetFinished() { }

	// RVA: 0x653A80 Offset: 0x652C80 VA: 0x180653A80
	internal void SetInserted() { }

	// RVA: 0x653A50 Offset: 0x652C50 VA: 0x180653A50
	internal void SetHighlight() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MonitorOxyMinigame.<>c // TypeDefIndex: 1374
{
	// Fields
	public static readonly MonitorOxyMinigame.<>c <>9; // 0x0
	public static Func<BoxCollider2D, bool> <>9__16_0; // 0x8
	public static Func<BoxCollider2D, bool> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x660800 Offset: 0x65FA00 VA: 0x180660800
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660310 Offset: 0x65F510 VA: 0x180660310
	internal bool <Update>b__16_0(BoxCollider2D s) { }

	// RVA: 0x660310 Offset: 0x65F510 VA: 0x180660310
	internal bool <Update>b__16_1(BoxCollider2D s) { }
}

// Namespace: 
public class MonitorOxyMinigame : Minigame // TypeDefIndex: 1375
{
	// Fields
	public SpriteRenderer[] Targets; // 0x88
	public BoxCollider2D[] Sliders; // 0x90
	public VerticalSpriteGauge[] Fills; // 0x98
	public FloatRange YRange; // 0xA0
	public FloatRange[] RandomRanges; // 0xA8
	private Controller controller; // 0xB0
	public AudioClip[] DragSounds; // 0xB8
	private AudioSource ActiveSound; // 0xC0
	public Transform selectorObject; // 0xC8
	private TouchpadBehavior touchpad; // 0xD0
	private float initialY; // 0xD8
	private int selectedIndex; // 0xDC
	private bool prevHadInput; // 0xE0
	private float selectCooldown; // 0xE4
	private bool isTouchInput; // 0xE8

	// Methods

	// RVA: 0x656290 Offset: 0x655490 VA: 0x180656290 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x656500 Offset: 0x655700 VA: 0x180656500
	public void Update() { }

	// RVA: 0x656480 Offset: 0x655680 VA: 0x180656480 Slot: 6
	public override void Close() { }

	// RVA: 0x657350 Offset: 0x656550 VA: 0x180657350
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlanetSurveillanceMinigame.<CoAnimateClose>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1376
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlanetSurveillanceMinigame <>4__this; // 0x20
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

	// RVA: 0x65C8E0 Offset: 0x65BAE0 VA: 0x18065C8E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65CB60 Offset: 0x65BD60 VA: 0x18065CB60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlanetSurveillanceMinigame.<CoAnimateOpen>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1377
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlanetSurveillanceMinigame <>4__this; // 0x20
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

	// RVA: 0x65CBA0 Offset: 0x65BDA0 VA: 0x18065CBA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65CFB0 Offset: 0x65C1B0 VA: 0x18065CFB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlanetSurveillanceMinigame.<CoDestroySelf>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1378
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlanetSurveillanceMinigame <>4__this; // 0x20

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

	// RVA: 0x65D350 Offset: 0x65C550 VA: 0x18065D350 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65D490 Offset: 0x65C690 VA: 0x18065D490 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlanetSurveillanceMinigame.<PulseStatic>d__20 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1379
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlanetSurveillanceMinigame <>4__this; // 0x20

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

	// RVA: 0x65F420 Offset: 0x65E620 VA: 0x18065F420 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65F580 Offset: 0x65E780 VA: 0x18065F580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlanetSurveillanceMinigame : Minigame // TypeDefIndex: 1380
{
	// Fields
	public Camera Camera; // 0x88
	public GameObject Viewables; // 0x90
	public MeshRenderer ViewPort; // 0x98
	public TextMeshPro LocationName; // 0xA0
	public TextMeshPro SabText; // 0xA8
	private RenderTexture texture; // 0xB0
	public MeshRenderer FillQuad; // 0xB8
	public Material DefaultMaterial; // 0xC0
	public Material StaticMaterial; // 0xC8
	private bool isStatic; // 0xD0
	private SurvCamera[] survCameras; // 0xD8
	public Transform DotParent; // 0xE0
	private SpriteRenderer[] Dots; // 0xE8
	public Sprite DotEnabled; // 0xF0
	public Sprite DotDisabled; // 0xF8
	private int currentCamera; // 0x100
	public AudioClip ChangeSound; // 0x108

	// Methods

	// RVA: 0x6582D0 Offset: 0x6574D0 VA: 0x1806582D0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x658D40 Offset: 0x657F40 VA: 0x180658D40
	public void Update() { }

	// RVA: 0x658900 Offset: 0x657B00 VA: 0x180658900
	public void NextCamera(int direction) { }

	[IteratorStateMachine(typeof(PlanetSurveillanceMinigame.<PulseStatic>d__20))]
	// RVA: 0x658CE0 Offset: 0x657EE0 VA: 0x180658CE0
	private IEnumerator PulseStatic() { }

	[IteratorStateMachine(typeof(PlanetSurveillanceMinigame.<CoAnimateOpen>d__21))]
	// RVA: 0x658840 Offset: 0x657A40 VA: 0x180658840 Slot: 7
	protected override IEnumerator CoAnimateOpen() { }

	[IteratorStateMachine(typeof(PlanetSurveillanceMinigame.<CoAnimateClose>d__22))]
	// RVA: 0x6587E0 Offset: 0x6579E0 VA: 0x1806587E0
	private IEnumerator CoAnimateClose() { }

	[IteratorStateMachine(typeof(PlanetSurveillanceMinigame.<CoDestroySelf>d__23))]
	// RVA: 0x6588A0 Offset: 0x657AA0 VA: 0x1806588A0 Slot: 8
	protected override IEnumerator CoDestroySelf() { }

	// RVA: 0x658700 Offset: 0x657900 VA: 0x180658700 Slot: 6
	public override void Close() { }

	// RVA: 0x658CB0 Offset: 0x657EB0 VA: 0x180658CB0
	public void OnDestroy() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
public class SpecimenGame : Minigame // TypeDefIndex: 1381
{
	// Fields
	public Collider2D[] Specimens; // 0x88
	public Transform[] Slots; // 0x90
	private Controller cont; // 0x98
	public AudioClip[] PlaceSounds; // 0xA0
	private SpriteRenderer[] SpecimenSprites; // 0xA8
	public Color highlightColor; // 0xB0
	private bool completed; // 0xC0
	private bool prevHadStick; // 0xC1
	private bool prevHadButton; // 0xC2
	private int prevSelectedSpecimen; // 0xC4
	private int selectedSpecimen; // 0xC8

	// Methods

	// RVA: 0x65A8E0 Offset: 0x659AE0 VA: 0x18065A8E0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x65AC10 Offset: 0x659E10 VA: 0x18065AC10
	public void Update() { }

	// RVA: 0x65AA00 Offset: 0x659C00 VA: 0x18065AA00
	private void CheckForWin() { }

	// RVA: 0x65BB00 Offset: 0x65AD00 VA: 0x18065BB00
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TelescopeGame.<CoBlinky>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1382
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TelescopeGame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x65D150 Offset: 0x65C350 VA: 0x18065D150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65D310 Offset: 0x65C510 VA: 0x18065D310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TelescopeGame.<RunBlipSound>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1383
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TelescopeGame <>4__this; // 0x20
	private float <time>5__2; // 0x28

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

	// RVA: 0x65F5C0 Offset: 0x65E7C0 VA: 0x18065F5C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65F8F0 Offset: 0x65EAF0 VA: 0x18065F8F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class TelescopeGame : Minigame // TypeDefIndex: 1384
{
	// Fields
	private bool grabbed; // 0x88
	public Transform Background; // 0x90
	public SpriteRenderer ItemDisplay; // 0x98
	public BoxCollider2D[] Items; // 0xA0
	private BoxCollider2D TargetItem; // 0xA8
	public BoxCollider2D Reticle; // 0xB0
	public SpriteRenderer ReticleImage; // 0xB8
	private Coroutine blinky; // 0xC0
	public AudioClip BlipSound; // 0xC8
	public FloatRange BlipDelay; // 0xD0
	private TouchpadBehavior touchpad; // 0xD8
	private Vector3 initialPos; // 0xE0

	// Methods

	// RVA: 0x65BC50 Offset: 0x65AE50 VA: 0x18065BC50
	public void Start() { }

	[IteratorStateMachine(typeof(TelescopeGame.<RunBlipSound>d__13))]
	// RVA: 0x65BBF0 Offset: 0x65ADF0 VA: 0x18065BBF0
	private IEnumerator RunBlipSound() { }

	// RVA: 0x65BDA0 Offset: 0x65AFA0 VA: 0x18065BDA0
	public void Update() { }

	[IteratorStateMachine(typeof(TelescopeGame.<CoBlinky>d__15))]
	// RVA: 0x65BB70 Offset: 0x65AD70 VA: 0x18065BB70
	private IEnumerator CoBlinky() { }

	// RVA: 0x65BBD0 Offset: 0x65ADD0 VA: 0x18065BBD0
	public void Grab() { }

	// RVA: 0x65C340 Offset: 0x65B540 VA: 0x18065C340
	public void .ctor() { }
}

// Namespace: 
public class TempMinigame : Minigame // TypeDefIndex: 1385
{
	// Fields
	public TextMeshPro LogText; // 0x88
	public TextMeshPro ReadingText; // 0x90
	public IntRange LogRange; // 0x98
	public IntRange ReadingRange; // 0xA0
	private int logValue; // 0xA8
	private int readingValue; // 0xAC
	public AudioClip ButtonSound; // 0xB0
	private float deltaSinceLastChangeNumber; // 0xB8
	public const float CHANGE_NUMBER_UPDATE_THRESHOLD_MIN = 0,05;

	// Methods

	// RVA: 0x65C3B0 Offset: 0x65B5B0 VA: 0x18065C3B0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x65C460 Offset: 0x65B660 VA: 0x18065C460
	public void ChangeNumber(int dir) { }

	// RVA: 0x65C5C0 Offset: 0x65B7C0 VA: 0x18065C5C0
	private void Update() { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class VertLineBehaviour : MonoBehaviour // TypeDefIndex: 1386
{
	// Fields
	public int NumPoints; // 0x20
	public FloatRange Width; // 0x28
	public FloatRange Height; // 0x30
	private Mesh mesh; // 0x38
	private MeshRenderer rend; // 0x40
	private Vector3[] vecs; // 0x48
	public float Duration; // 0x50
	private float timer; // 0x54
	public int Offset; // 0x58
	public int beats; // 0x5C
	public int beatPadding; // 0x60

	// Properties
	public Color color { set; }

	// Methods

	// RVA: 0x661320 Offset: 0x660520 VA: 0x180661320
	public void set_color(Color value) { }

	// RVA: 0x660AE0 Offset: 0x65FCE0 VA: 0x180660AE0
	public void Awake() { }

	// RVA: 0x661240 Offset: 0x660440 VA: 0x180661240
	public void Update() { }

	// RVA: 0x660D70 Offset: 0x65FF70 VA: 0x180660D70
	public void SetAlive() { }

	// RVA: 0x6610A0 Offset: 0x6602A0 VA: 0x1806610A0
	public void SetDead() { }

	// RVA: 0x6612F0 Offset: 0x6604F0 VA: 0x1806612F0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VitalsMinigame.<>c__DisplayClass8_0 // TypeDefIndex: 1387
{
	// Fields
	public Dictionary<byte, bool> vitalDisconnected; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660660 Offset: 0x65F860 VA: 0x180660660
	internal int <Begin>b__0(NetworkedPlayerInfo a, NetworkedPlayerInfo b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VitalsMinigame.<>c__DisplayClass8_1 // TypeDefIndex: 1388
{
	// Fields
	public NetworkedPlayerInfo player; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660770 Offset: 0x65F970 VA: 0x180660770
	internal bool <Begin>b__1(DeadBody b) { }
}

// Namespace: 
public class VitalsMinigame : Minigame // TypeDefIndex: 1389
{
	// Fields
	public TextMeshPro BatteryText; // 0x88
	public VitalsPanel PanelPrefab; // 0x90
	public TextMeshPro SabText; // 0x98
	public float XStart; // 0xA0
	public float YStart; // 0xA4
	public float XOffset; // 0xA8
	public float YOffset; // 0xAC
	private VitalsPanel[] vitals; // 0xB0

	// Methods

	// RVA: 0x661610 Offset: 0x660810 VA: 0x180661610 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x661C10 Offset: 0x660E10 VA: 0x180661C10
	private void Update() { }

	// RVA: 0x661F20 Offset: 0x661120 VA: 0x180661F20
	public void .ctor() { }
}

// Namespace: 
public class VitalsPanel : MonoBehaviour // TypeDefIndex: 1390
{
	// Fields
	[CompilerGenerated]
	private NetworkedPlayerInfo <PlayerInfo>k__BackingField; // 0x20
	public PoolablePlayer PlayerIcon; // 0x28
	public SpriteRenderer MaskingArea; // 0x30
	public SpriteRenderer Background; // 0x38
	public VertLineBehaviour Cardio; // 0x40
	public Sprite VitalBgDead; // 0x48
	public Sprite VitalBgDiscon; // 0x50
	public IntRange BeatRange; // 0x58
	public bool IsDead; // 0x60
	public bool IsDiscon; // 0x61
	public TextMeshPro ColorBlindName; // 0x68

	// Properties
	public NetworkedPlayerInfo PlayerInfo { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public NetworkedPlayerInfo get_PlayerInfo() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_PlayerInfo(NetworkedPlayerInfo value) { }

	// RVA: 0x6621E0 Offset: 0x6613E0 VA: 0x1806621E0
	public void SetPlayer(int index, NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x662180 Offset: 0x661380 VA: 0x180662180
	public void SetDisconnected() { }

	// RVA: 0x661FC0 Offset: 0x6611C0 VA: 0x180661FC0
	public void SetDead() { }

	// RVA: 0x661F50 Offset: 0x661150 VA: 0x180661F50
	public void SetAlive() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class WaterWheelGame : Minigame // TypeDefIndex: 1391
{
	// Fields
	public SpriteRenderer Wheel; // 0x88
	public VerticalSpriteGauge WaterLevel; // 0x90
	public SpriteRenderer Watertop; // 0x98
	public int WheelScale; // 0xA0
	public AudioClip FillStart; // 0xA8
	public AudioClip FillLoop; // 0xB0
	public AudioClip WheelTurn; // 0xB8
	private TouchpadBehavior touchpad; // 0xC0
	private float Rate; // 0xC8
	private AudioSource fillSound; // 0xD0
	private Vector2 prevStickInput; // 0xD8
	private bool hadPrev; // 0xE0
	private bool grabbed; // 0xE1

	// Properties
	private float Water { get; set; }

	// Methods

	// RVA: 0x663030 Offset: 0x662230 VA: 0x180663030
	private float get_Water() { }

	// RVA: 0x663050 Offset: 0x662250 VA: 0x180663050
	private void set_Water(float value) { }

	// RVA: 0x662380 Offset: 0x661580 VA: 0x180662380 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x662580 Offset: 0x661780 VA: 0x180662580
	public void Update() { }

	// RVA: 0x662560 Offset: 0x661760 VA: 0x180662560
	public void Grab() { }

	// RVA: 0x6624E0 Offset: 0x6616E0 VA: 0x1806624E0 Slot: 6
	public override void Close() { }

	// RVA: 0x662FC0 Offset: 0x6621C0 VA: 0x180662FC0
	public void .ctor() { }
}

// Namespace: 
public class Tile2 // TypeDefIndex: 1392
{
	// Fields
	public int SpriteId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class Tilemap2 : MonoBehaviour // TypeDefIndex: 1393
{
	// Fields
	public Sprite[] sprites; // 0x20
	private Tile2[] tileData; // 0x28
	public int Width; // 0x30
	public int Height; // 0x34

	// Methods

	// RVA: 0x65C7B0 Offset: 0x65B9B0 VA: 0x18065C7B0
	internal void SetTile(Vector3Int vec, int tileId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void SetTransformMatrix(Vector3Int vec, Matrix4x4 rot90) { }

	// RVA: 0x65C770 Offset: 0x65B970 VA: 0x18065C770
	internal MonoBehaviour GetTile(Vector3Int touchCellPos) { }

	// RVA: 0x65C7F0 Offset: 0x65B9F0 VA: 0x18065C7F0
	internal Vector3Int WorldToCell(Vector2 worldPos) { }

	// RVA: 0x65C8C0 Offset: 0x65BAC0 VA: 0x18065C8C0
	public void .ctor() { }
}

// Namespace: 
public class Weather1Game : Minigame // TypeDefIndex: 1394
{
	// Fields
	private static int[] BarrierValidX; // 0x0
	private static int[] BarrierValidY; // 0x8
	private const int MinX = -10;
	private const int MaxX = 8;
	private const int MinY = -3;
	private const int MaxY = 3;
	public Tilemap BarrierMap; // 0x88
	public Tile fillTile; // 0x90
	public Tile controlTile; // 0x98
	public Tile barrierTile; // 0xA0
	public SpriteRenderer pulseCircle1; // 0xA8
	public SpriteRenderer pulseCircle2; // 0xB0
	public AudioClip NodeMove; // 0xB8
	private Controller control; // 0xC0
	private bool inControl; // 0xC8
	private Vector3Int controlTilePos; // 0xCC
	private static Vector3Int[] Directions; // 0x10
	private float moveCooldown; // 0xD8

	// Methods

	// RVA: 0x663820 Offset: 0x662A20 VA: 0x180663820
	public void Start() { }

	// RVA: 0x663530 Offset: 0x662730 VA: 0x180663530
	private bool SolveMaze(Vector3Int curPos, HashSet<Vector3Int> solution) { }

	// RVA: 0x663BE0 Offset: 0x662DE0 VA: 0x180663BE0
	public void Update() { }

	// RVA: 0x663360 Offset: 0x662560 VA: 0x180663360
	private void FillLine(Vector3Int controlTilePos, Vector3Int touchCellPos) { }

	// RVA: 0x6630F0 Offset: 0x6622F0 VA: 0x1806630F0
	private bool AnythingBetween(Vector3Int controlTilePos, Vector3Int touchCellPos) { }

	// RVA: 0x6634F0 Offset: 0x6626F0 VA: 0x1806634F0
	private bool PointIsValid(Vector3Int touchCellPos) { }

	// RVA: -1 Offset: -1
	private bool Contains<T>(T[] self, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA43A0 Offset: 0xAA35A0 VA: 0x180AA43A0
	|-Weather1Game.Contains<bool>
	|
	|-RVA: 0xAA4470 Offset: 0xAA3670 VA: 0x180AA4470
	|-Weather1Game.Contains<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x664B70 Offset: 0x663D70 VA: 0x180664B70
	public void .ctor() { }

	// RVA: 0x664950 Offset: 0x663B50 VA: 0x180664950
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeatherControl.<Run>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1395
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WeatherControl <>4__this; // 0x20

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

	// RVA: 0x6601A0 Offset: 0x65F3A0 VA: 0x1806601A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6602A0 Offset: 0x65F4A0 VA: 0x1806602A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class WeatherControl : MonoBehaviour // TypeDefIndex: 1396
{
	// Fields
	public Sprite backgroundLight; // 0x20
	public Sprite backgroundDark; // 0x28
	public Sprite lightOff; // 0x30
	public Sprite lightOn; // 0x38
	public SpriteRenderer Background; // 0x40
	public SpriteRenderer Switch; // 0x48
	public SpriteRenderer Light; // 0x50
	public TextMeshPro Label; // 0x58

	// Methods

	// RVA: 0x664D60 Offset: 0x663F60 VA: 0x180664D60
	internal void SetInactive() { }

	// RVA: 0x664C60 Offset: 0x663E60 VA: 0x180664C60
	public void SetActive() { }

	[IteratorStateMachine(typeof(WeatherControl.<Run>d__10))]
	// RVA: 0x664C00 Offset: 0x663E00 VA: 0x180664C00
	private IEnumerator Run() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class WeatherSwitchGame : Minigame // TypeDefIndex: 1397
{
	// Fields
	public static StringNames[] ControlNames; // 0x0
	public WeatherControl[] Controls; // 0x88
	private WeatherNodeTask WeatherTask; // 0x90
	public Transform buttonGlyph; // 0x98
	public Vector3 buttonGlyphOffset_Off; // 0xA0
	public Vector3 buttonGlyphOffset_On; // 0xAC
	public AudioClip SwitchSound; // 0xB8

	// Methods

	// RVA: 0x665590 Offset: 0x664790 VA: 0x180665590
	public void Start() { }

	// RVA: 0x664EA0 Offset: 0x6640A0 VA: 0x180664EA0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x665830 Offset: 0x664A30 VA: 0x180665830
	private void Update() { }

	// RVA: 0x665200 Offset: 0x664400 VA: 0x180665200
	public void FlipSwitch(int i) { }

	// RVA: 0x62B880 Offset: 0x62AA80 VA: 0x18062B880
	public void .ctor() { }

	// RVA: 0x6658D0 Offset: 0x664AD0 VA: 0x1806658D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WifiGame.<CoBlinkLight>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1398
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SpriteRenderer light; // 0x20
	public WifiGame <>4__this; // 0x28
	public float delay; // 0x30

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

	// RVA: 0x65CFF0 Offset: 0x65C1F0 VA: 0x18065CFF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65D110 Offset: 0x65C310 VA: 0x18065D110 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WifiGame.<RunLights>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1399
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool finishing; // 0x20
	public WifiGame <>4__this; // 0x28
	private float <timer>5__2; // 0x30

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

	// RVA: 0x65F930 Offset: 0x65EB30 VA: 0x18065F930 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x660160 Offset: 0x65F360 VA: 0x180660160 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class WifiGame : Minigame // TypeDefIndex: 1400
{
	// Fields
	private const int WaitDuration = 60;
	public SlideBar Slider; // 0x88
	public TextMeshPro StatusText; // 0x90
	public SpriteRenderer[] Lights; // 0x98
	public Sprite LightOn; // 0xA0
	public Sprite LightOff; // 0xA8
	public AudioClip SliderClick; // 0xB0
	private bool WifiOff; // 0xB8
	private TouchpadBehavior touchpad; // 0xC0
	private float initialSlider; // 0xC8
	private Controller controller; // 0xD0

	// Methods

	// RVA: 0x665CA0 Offset: 0x664EA0 VA: 0x180665CA0 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x666270 Offset: 0x665470 VA: 0x180666270
	public void Update() { }

	// RVA: 0x6660A0 Offset: 0x6652A0 VA: 0x1806660A0
	private void TurnOn(bool first = False) { }

	// RVA: 0x665E30 Offset: 0x665030 VA: 0x180665E30
	private void TurnOff(bool first = False) { }

	[IteratorStateMachine(typeof(WifiGame.<RunLights>d__15))]
	// RVA: 0x665DC0 Offset: 0x664FC0 VA: 0x180665DC0
	private IEnumerator RunLights(bool finishing) { }

	[IteratorStateMachine(typeof(WifiGame.<CoBlinkLight>d__16))]
	// RVA: 0x665D40 Offset: 0x664F40 VA: 0x180665D40
	private IEnumerator CoBlinkLight(SpriteRenderer light, float delay) { }

	// RVA: 0x666720 Offset: 0x665920 VA: 0x180666720
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x666240 Offset: 0x665440 VA: 0x180666240
	private void <TurnOff>b__14_0(SpriteRenderer s) { }

	[CompilerGenerated]
	// RVA: 0x666210 Offset: 0x665410 VA: 0x180666210
	private void <RunLights>b__15_0(SpriteRenderer s) { }

	[CompilerGenerated]
	// RVA: 0x666210 Offset: 0x665410 VA: 0x180666210
	private void <RunLights>b__15_1(SpriteRenderer s) { }
}

// Namespace: 
public class DeadBody : MonoBehaviour // TypeDefIndex: 1401
{
	// Fields
	public bool Reported; // 0x20
	public byte ParentId; // 0x21
	public Collider2D myCollider; // 0x28
	public SpriteRenderer bloodSplatter; // 0x30
	public SpriteRenderer[] bodyRenderers; // 0x38

	// Properties
	public Vector2 TruePosition { get; }

	// Methods

	// RVA: 0x6534D0 Offset: 0x6526D0 VA: 0x1806534D0
	public Vector2 get_TruePosition() { }

	// RVA: 0x653210 Offset: 0x652410 VA: 0x180653210
	public void OnClick() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DummyBehaviour.<DoVote>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1402
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DummyBehaviour <>4__this; // 0x20

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

	// RVA: 0x65F220 Offset: 0x65E420 VA: 0x18065F220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65F3E0 Offset: 0x65E5E0 VA: 0x18065F3E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class DummyBehaviour : MonoBehaviour // TypeDefIndex: 1403
{
	// Fields
	public int PlayerIdToVoteFor; // 0x20
	private PlayerControl myPlayer; // 0x28
	private FloatRange voteTime; // 0x30
	private bool voted; // 0x38

	// Properties
	public PlayerControl Player { get; }

	// Methods

	// RVA: 0x6537B0 Offset: 0x6529B0 VA: 0x1806537B0
	public PlayerControl get_Player() { }

	// RVA: 0x6535C0 Offset: 0x6527C0 VA: 0x1806535C0
	public void Start() { }

	// RVA: 0x653600 Offset: 0x652800 VA: 0x180653600
	public void Update() { }

	[IteratorStateMachine(typeof(DummyBehaviour.<DoVote>d__8))]
	// RVA: 0x653560 Offset: 0x652760 VA: 0x180653560
	private IEnumerator DoVote() { }

	// RVA: 0x653730 Offset: 0x652930 VA: 0x180653730
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillAnimation.<>c__DisplayClass2_0 // TypeDefIndex: 1404
{
	// Fields
	public PlayerControl target; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660640 Offset: 0x65F840 VA: 0x180660640
	internal void <CoPerformKill>b__0(SpriteRenderer b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KillAnimation.<CoPerformKill>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1405
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl target; // 0x20
	public PlayerControl source; // 0x28
	public KillAnimation <>4__this; // 0x30
	private KillAnimation.<>c__DisplayClass2_0 <>8__1; // 0x38
	private FollowerCamera <cam>5__2; // 0x40
	private bool <isParticipant>5__3; // 0x48
	private PlayerPhysics <sourcePhys>5__4; // 0x50
	private DeadBody <deadBody>5__5; // 0x58

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

	// RVA: 0x65D4D0 Offset: 0x65C6D0 VA: 0x18065D4D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E140 Offset: 0x65D340 VA: 0x18065E140 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class KillAnimation : MonoBehaviour // TypeDefIndex: 1406
{
	// Fields
	public AnimationClip BlurAnim; // 0x20
	public Vector3 BodyOffset; // 0x28

	// Methods

	[IteratorStateMachine(typeof(KillAnimation.<CoPerformKill>d__2))]
	// RVA: 0x653AB0 Offset: 0x652CB0 VA: 0x180653AB0
	public IEnumerator CoPerformKill(PlayerControl source, PlayerControl target) { }

	// RVA: 0x653B30 Offset: 0x652D30 VA: 0x180653B30
	public static void SetMovement(PlayerControl source, bool canMove) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HorseWrangleOverlay.<CoShow>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1407
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HorseWrangleOverlay <>4__this; // 0x20
	public KillOverlay parent; // 0x28

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

	// RVA: 0x65F000 Offset: 0x65E200 VA: 0x18065F000 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65F1E0 Offset: 0x65E3E0 VA: 0x18065F1E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class HorseWrangleOverlay : OverlayKillAnimation // TypeDefIndex: 1408
{
	// Fields
	[SerializeField]
	private SpriteRenderer impostorForeground; // 0x90
	[SerializeField]
	private SpriteRenderer impostorHand; // 0x98
	[SerializeField]
	private SpriteRenderer[] victimSprites; // 0xA0

	// Methods

	[IteratorStateMachine(typeof(HorseWrangleOverlay.<CoShow>d__3))]
	// RVA: 0x653840 Offset: 0x652A40 VA: 0x180653840 Slot: 4
	public override IEnumerator CoShow(KillOverlay parent) { }

	// RVA: 0x653990 Offset: 0x652B90 VA: 0x180653990
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6538B0 Offset: 0x652AB0 VA: 0x1806538B0
	private void <CoShow>b__3_0(SpriteRenderer b) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x653920 Offset: 0x652B20 VA: 0x180653920
	private IEnumerator <>n__0(KillOverlay parent) { }
}

// Namespace: 
public enum KillAnimType // TypeDefIndex: 1409
{
	// Fields
	public int value__; // 0x0
	public const KillAnimType Stab = 0;
	public const KillAnimType Tongue = 1;
	public const KillAnimType Shoot = 2;
	public const KillAnimType Neck = 3;
	public const KillAnimType RHM = 4;
	public const KillAnimType Werewolf_Slash = 5;
	public const KillAnimType ViperKill = 6;
	public const KillAnimType None = 9999;
}

// Namespace: 
public abstract class OverlayAnimation : MonoBehaviour // TypeDefIndex: 1410
{
	// Fields
	protected const float TwoFramesDelay = 0,083333336;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator CoShow(KillOverlay parent);

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OverlayKillAnimation.<>c__DisplayClass14_0 // TypeDefIndex: 1411
{
	// Fields
	public OverlayKillAnimation <>4__this; // 0x10
	public KillOverlayInitData initData; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660340 Offset: 0x65F540 VA: 0x180660340
	internal void <Initialize>b__0() { }

	// RVA: 0x660540 Offset: 0x65F740 VA: 0x180660540
	internal void <Initialize>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OverlayKillAnimation.<>c__DisplayClass18_0 // TypeDefIndex: 1412
{
	// Fields
	public KillOverlay parent; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6605D0 Offset: 0x65F7D0 VA: 0x1806605D0
	internal void <CoShow>b__0(float t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OverlayKillAnimation.<CoShow>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1413
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public KillOverlay parent; // 0x20
	public OverlayKillAnimation <>4__this; // 0x28
	private OverlayKillAnimation.<>c__DisplayClass18_0 <>8__1; // 0x30

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

	// RVA: 0x65E810 Offset: 0x65DA10 VA: 0x18065E810 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65EFC0 Offset: 0x65E1C0 VA: 0x18065EFC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OverlayKillAnimation.<WaitForFinish>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1414
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public OverlayKillAnimation <>4__this; // 0x20
	private SpriteAnim[] <anims>5__2; // 0x28

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

	// RVA: 0x6608C0 Offset: 0x65FAC0 VA: 0x1806608C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x660AA0 Offset: 0x65FCA0 VA: 0x180660AA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class OverlayKillAnimation : OverlayAnimation // TypeDefIndex: 1415
{
	// Fields
	[SerializeField]
	private KillAnimType KillType; // 0x20
	[SerializeField]
	protected PoolablePlayer killerParts; // 0x28
	[SerializeField]
	private Vector3 KillerPetPosition; // 0x30
	[SerializeField]
	protected PoolablePlayer victimParts; // 0x40
	[SerializeField]
	private Vector3 VictimPetPosition; // 0x48
	[SerializeField]
	private AudioClip Stinger; // 0x58
	[SerializeField]
	private AudioClip Sfx; // 0x60
	[SerializeField]
	private float StingerVolume; // 0x68
	protected KillOverlayInitData initData; // 0x70
	[SerializeField]
	private bool leftFacingVictim; // 0x78
	private string victimHat; // 0x80
	private HashSet<GameObject> petObjects; // 0x88

	// Properties
	public bool LeftFacingVictim { get; }

	// Methods

	// RVA: 0x61CC40 Offset: 0x61BE40 VA: 0x18061CC40
	public bool get_LeftFacingVictim() { }

	// RVA: 0x6573B0 Offset: 0x6565B0 VA: 0x1806573B0 Slot: 5
	public virtual void Initialize(KillOverlayInitData initData) { }

	// RVA: 0x658190 Offset: 0x657390 VA: 0x180658190
	public void SetHatFloor() { }

	// RVA: 0x658250 Offset: 0x657450 VA: 0x180658250
	public void SetVisorFloor() { }

	// RVA: 0x658020 Offset: 0x657220 VA: 0x180658020
	public void PlayKillSound() { }

	[IteratorStateMachine(typeof(OverlayKillAnimation.<CoShow>d__18))]
	// RVA: 0x653920 Offset: 0x652B20 VA: 0x180653920 Slot: 4
	public override IEnumerator CoShow(KillOverlay parent) { }

	[IteratorStateMachine(typeof(OverlayKillAnimation.<WaitForFinish>d__19))]
	// RVA: 0x658270 Offset: 0x657470 VA: 0x180658270
	private IEnumerator WaitForFinish() { }

	// RVA: 0x657DD0 Offset: 0x656FD0 VA: 0x180657DD0
	private void LoadVictimSkin(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	// RVA: 0x6578F0 Offset: 0x656AF0 VA: 0x1806578F0
	private void LoadKillerSkin(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	// RVA: 0x657690 Offset: 0x656890 VA: 0x180657690
	private void LoadKillerPet(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	// RVA: 0x657AD0 Offset: 0x656CD0 VA: 0x180657AD0
	private void LoadVictimPet(NetworkedPlayerInfo.PlayerOutfit outfit) { }

	// RVA: 0x658010 Offset: 0x657210 VA: 0x180658010
	private void OnDestroy() { }

	// RVA: 0x653990 Offset: 0x652B90 VA: 0x180653990
	public void .ctor() { }
}

// Namespace: 
public class Viper_KillAnim_Helper : MonoBehaviour // TypeDefIndex: 1416
{
	// Fields
	[SerializeField]
	private CosmeticsLayer victCosmetics; // 0x20
	[SerializeField]
	private AudioClip acidSplashSFX; // 0x28
	[SerializeField]
	private AudioClip thudSFX; // 0x30
	[SerializeField]
	private AudioClip acidSpitSFX; // 0x38

	// Methods

	// RVA: 0x6615C0 Offset: 0x6607C0 VA: 0x1806615C0
	private void AnimEvent_TurnOffCosmetics() { }

	// RVA: 0x6613A0 Offset: 0x6605A0 VA: 0x1806613A0
	private void AnimEvent_PlayAcidSplashSFX() { }

	// RVA: 0x661540 Offset: 0x660740 VA: 0x180661540
	private void AnimEvent_PlayThudSFX() { }

	// RVA: 0x6614C0 Offset: 0x6606C0 VA: 0x1806614C0
	private void AnimEvent_PlaySpitSFX() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class LongModeKillAnimation : OverlayKillAnimation // TypeDefIndex: 1417
{
	// Fields
	[SerializeField]
	private SpriteRenderer killerNeck; // 0x90
	[SerializeField]
	private SpriteRenderer killerHead; // 0x98
	[SerializeField]
	private HatParent sideHat; // 0xA0
	[SerializeField]
	private VisorLayer sideVisor; // 0xA8

	// Methods

	// RVA: 0x656150 Offset: 0x655350 VA: 0x180656150 Slot: 5
	public override void Initialize(KillOverlayInitData initData) { }

	// RVA: 0x653990 Offset: 0x652B90 VA: 0x180653990
	public void .ctor() { }
}

// Namespace: 
public class WerewolfKill_VicHelper : MonoBehaviour // TypeDefIndex: 1418
{
	// Fields
	[SerializeField]
	private SpriteRenderer bloodSplatter; // 0x20
	[SerializeField]
	private CosmeticsLayer victCosmetics; // 0x28

	// Methods

	// RVA: 0x6659A0 Offset: 0x664BA0 VA: 0x1806659A0
	private void Start() { }

	// RVA: 0x665950 Offset: 0x664B50 VA: 0x180665950
	private void AnimEvent_TurnOffCosmetics() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerAnimationGroup // TypeDefIndex: 1419
{
	// Fields
	[Header("Other")]
	public PlayerBodyTypes BodyType; // 0x10
	public SpriteAnim SpriteAnimator; // 0x18
	public List<SpriteAnimNodeSync> NodeSyncs; // 0x20
	public OverlayKillAnimation[] KillAnims; // 0x28
	[Header("Animation Clips")]
	public AnimationClip RunAnim; // 0x30
	public AnimationClip IdleAnim; // 0x38
	public AnimationClip GhostIdleAnim; // 0x40
	public AnimationClip EnterVentAnim; // 0x48
	public AnimationClip ExitVentAnim; // 0x50
	public AnimationClip SpawnAnim; // 0x58
	public AnimationClip SpawnGlowAnim; // 0x60
	public AnimationClip ClimbUpAnim; // 0x68
	public AnimationClip ClimbDownAnim; // 0x70
	public AnimationClip GhostGuardianAngelAnim; // 0x78
	[Header("Animation Settings")]
	public float RunAnimTime; // 0x80
	public float ShapeshiftScale; // 0x84
	public Vector3 defaultPlayerScale; // 0x88

	// Methods

	// RVA: 0x658EF0 Offset: 0x6580F0 VA: 0x180658EF0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerAnimations.<>c // TypeDefIndex: 1420
{
	// Fields
	public static readonly PlayerAnimations.<>c <>9; // 0x0
	public static Action<SpriteAnimNodeSync> <>9__15_1; // 0x8

	// Methods

	// RVA: 0x660860 Offset: 0x65FA60 VA: 0x180660860
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A02D0 Offset: 0x59F4D0 VA: 0x1805A02D0
	internal void <SetBodyType>b__15_1(SpriteAnimNodeSync n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<>c__DisplayClass15_0 // TypeDefIndex: 1421
{
	// Fields
	public Vector3 flippedCosmeticOffset; // 0x10
	public Vector3 normalCosmeticOffset; // 0x1C
	public Action<SpriteAnimNodeSync> <>9__0; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660570 Offset: 0x65F770 VA: 0x180660570
	internal void <SetBodyType>b__0(SpriteAnimNodeSync n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<>c__DisplayClass16_0 // TypeDefIndex: 1422
{
	// Fields
	public Vector3 flippedCosmeticOffset; // 0x10
	public Vector3 normalCosmeticOffset; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x660570 Offset: 0x65F770 VA: 0x180660570
	internal void <UpdateCosmeticOffset>b__0(SpriteAnimNodeSync n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<CoPlayCustomAnimation>d__35 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1423
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerAnimations <>4__this; // 0x20
	public AnimationClip customAnim; // 0x28

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

	// RVA: 0x65E180 Offset: 0x65D380 VA: 0x18065E180 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E250 Offset: 0x65D450 VA: 0x18065E250 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<CoPlayEnterVentAnimation>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1424
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerAnimations <>4__this; // 0x20
	public int numFramesUntilDisappearance; // 0x28

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

	// RVA: 0x65E290 Offset: 0x65D490 VA: 0x18065E290 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E3E0 Offset: 0x65D5E0 VA: 0x18065E3E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<CoPlayExitVentAnimation>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1425
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerAnimations <>4__this; // 0x20

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

	// RVA: 0x65E420 Offset: 0x65D620 VA: 0x18065E420 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E540 Offset: 0x65D740 VA: 0x18065E540 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<CoPlayJumpAnimation>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1426
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerAnimations <>4__this; // 0x20

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

	// RVA: 0x65E580 Offset: 0x65D780 VA: 0x18065E580 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E660 Offset: 0x65D860 VA: 0x18065E660 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerAnimations.<CoPlaySpawnAnimation>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1427
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerAnimations <>4__this; // 0x20
	public bool flipX; // 0x28

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

	// RVA: 0x65E6A0 Offset: 0x65D8A0 VA: 0x18065E6A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x65E7D0 Offset: 0x65D9D0 VA: 0x18065E7D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlayerAnimations : MonoBehaviour // TypeDefIndex: 1428
{
	// Fields
	[SerializeField]
	private SpriteAnim glowAnimator; // 0x20
	[SerializeField]
	private SpriteRenderer glowSpriteRenderer; // 0x28
	[SerializeField]
	private List<PlayerAnimationGroup> animationGroups; // 0x30
	[SerializeField]
	[Header("Med Scan")]
	private SpriteAnim[] scannerAnims; // 0x38
	[SerializeField]
	private SpriteRenderer[] scannersImages; // 0x40
	private PlayerAnimationGroup group; // 0x48
	private PlayerBodyTypes type; // 0x50

	// Properties
	public float Time { get; }
	public float ShapeshiftScale { get; }
	public Vector3 DefaultPlayerScale { get; }
	private SpriteAnim Animator { get; }

	// Methods

	// RVA: 0x65A270 Offset: 0x659470 VA: 0x18065A270
	public float get_Time() { }

	// RVA: 0x65A250 Offset: 0x659450 VA: 0x18065A250
	public float get_ShapeshiftScale() { }

	// RVA: 0x65A220 Offset: 0x659420 VA: 0x18065A220
	public Vector3 get_DefaultPlayerScale() { }

	// RVA: 0x65A1B0 Offset: 0x6593B0 VA: 0x18065A1B0
	private SpriteAnim get_Animator() { }

	// RVA: 0x659D80 Offset: 0x658F80 VA: 0x180659D80
	public void SetBodyType(PlayerBodyTypes bodyType, Vector3 flippedCosmeticOffset, Vector3 normalCosmeticOffset) { }

	// RVA: 0x65A0B0 Offset: 0x6592B0 VA: 0x18065A0B0
	public void UpdateCosmeticOffset(Vector3 flippedCosmeticOffset, Vector3 normalCosmeticOffset) { }

	// RVA: 0x659130 Offset: 0x658330 VA: 0x180659130
	public OverlayKillAnimation[] GetKillAnimations() { }

	// RVA: 0x659620 Offset: 0x658820 VA: 0x180659620
	public bool IsPlayingRunAnimation() { }

	// RVA: 0x6597B0 Offset: 0x6589B0 VA: 0x1806597B0
	public bool IsPlayingSpawnAnimation() { }

	// RVA: 0x659280 Offset: 0x658480 VA: 0x180659280
	public bool IsPlayingClimbAnimation() { }

	// RVA: 0x659550 Offset: 0x658750 VA: 0x180659550
	public bool IsPlayingGuardianAngelIdleAnimation() { }

	// RVA: 0x659480 Offset: 0x658680 VA: 0x180659480
	public bool IsPlayingGhostIdleAnimation() { }

	// RVA: 0x6593B0 Offset: 0x6585B0 VA: 0x1806593B0
	public bool IsPlayingEnterVentAnimation() { }

	// RVA: 0x659150 Offset: 0x658350 VA: 0x180659150
	public bool IsPlayingAnyLadderAnimation() { }

	// RVA: 0x6596F0 Offset: 0x6588F0 VA: 0x1806596F0
	public bool IsPlayingSomeAnimation() { }

	// RVA: 0x659B30 Offset: 0x658D30 VA: 0x180659B30
	public void PlayRunAnimation() { }

	// RVA: 0x659AA0 Offset: 0x658CA0 VA: 0x180659AA0
	public void PlayIdleAnimation() { }

	// RVA: 0x659880 Offset: 0x658A80 VA: 0x180659880
	public void PlayClimbAnimation(bool down) { }

	// RVA: 0x659A10 Offset: 0x658C10 VA: 0x180659A10
	public void PlayGuardianAngelIdleAnimation() { }

	// RVA: 0x659980 Offset: 0x658B80 VA: 0x180659980
	public void PlayGhostIdleAnimation() { }

	[IteratorStateMachine(typeof(PlayerAnimations.<CoPlaySpawnAnimation>d__31))]
	// RVA: 0x6590C0 Offset: 0x6582C0 VA: 0x1806590C0
	public IEnumerator CoPlaySpawnAnimation(bool flipX) { }

	[IteratorStateMachine(typeof(PlayerAnimations.<CoPlayEnterVentAnimation>d__32))]
	// RVA: 0x658F90 Offset: 0x658190 VA: 0x180658F90
	public IEnumerator CoPlayEnterVentAnimation(int numFramesUntilDisappearance) { }

	[IteratorStateMachine(typeof(PlayerAnimations.<CoPlayExitVentAnimation>d__33))]
	// RVA: 0x659000 Offset: 0x658200 VA: 0x180659000
	public IEnumerator CoPlayExitVentAnimation() { }

	[IteratorStateMachine(typeof(PlayerAnimations.<CoPlayJumpAnimation>d__34))]
	// RVA: 0x659060 Offset: 0x658260 VA: 0x180659060
	public IEnumerator CoPlayJumpAnimation() { }

	[IteratorStateMachine(typeof(PlayerAnimations.<CoPlayCustomAnimation>d__35))]
	// RVA: 0x658F20 Offset: 0x658120 VA: 0x180658F20
	public IEnumerator CoPlayCustomAnimation(AnimationClip customAnim) { }

	// RVA: 0x659C10 Offset: 0x658E10 VA: 0x180659C10
	public void PlayScanner(bool on, bool isDead, bool flipX) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LongBoiPlayerBody.<>c // TypeDefIndex: 1429
{
	// Fields
	public static readonly LongBoiPlayerBody.<>c <>9; // 0x0
	public static Predicate<PlayerControl> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x6607A0 Offset: 0x65F9A0 VA: 0x1806607A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6602E0 Offset: 0x65F4E0 VA: 0x1806602E0
	internal bool <HideAndSeekUpdate>b__33_0(PlayerControl p) { }
}

// Namespace: 
public class LongBoiPlayerBody : MonoBehaviour // TypeDefIndex: 1430
{
	// Fields
	[SerializeField]
	private SpriteRenderer neckSprite; // 0x20
	[SerializeField]
	private SpriteRenderer foregroundNeckSprite; // 0x28
	[SerializeField]
	private SpriteRenderer headSprite; // 0x30
	[SerializeField]
	private PlayerControl myPlayerControl; // 0x38
	[SerializeField]
	private PoolablePlayer myPoolablePlayer; // 0x40
	[SerializeField]
	private CosmeticsLayer cosmeticLayer; // 0x48
	[SerializeField]
	private float neckHeadZPos; // 0x50
	[SerializeField]
	private float cosmeticYOffset; // 0x54
	[SerializeField]
	private bool isPoolablePlayer; // 0x58
	[SerializeField]
	private bool isExiledPlayer; // 0x59
	[SerializeField]
	private float targetHeight; // 0x5C
	[SerializeField]
	private bool skipNeckAnim; // 0x60
	[SerializeField]
	private bool isSeekerHorse; // 0x61
	[SerializeField]
	private GameObject neckHeadParent; // 0x68
	[SerializeField]
	private bool hideCosmeticsQC; // 0x70
	[SerializeField]
	private float growSpeed; // 0x74
	private PlayerControl hideAndSeekImpostor; // 0x78
	private float calculatedNeckHeight; // 0x80
	private bool ShouldLongAround; // 0x84
	private float[] heightsPerColor; // 0x88
	private const float BASE_NECK_MAX_HEIGHT = 1,1;
	private const float GHOST_NECK_WIDTH = 3,17;
	private const float GHOST_NECK_YPOS = 0,531;
	private const float NAME_POS_Y = 0,45;
	public const float HAT_Y_OFFSET = 0,1;
	private const float Z_ROTATION_OFFSET = -17,75;

	// Methods

	// RVA: 0x653BC0 Offset: 0x652DC0 VA: 0x180653BC0
	private void Awake() { }

	// RVA: 0x655830 Offset: 0x654A30 VA: 0x180655830
	private void OnDestroy() { }

	// RVA: 0x655F00 Offset: 0x655100 VA: 0x180655F00
	private void Start() { }

	// RVA: 0x656050 Offset: 0x655250 VA: 0x180656050
	public bool ValidateSkin(string prodId, int colorID) { }

	// RVA: 0x655640 Offset: 0x654840 VA: 0x180655640
	private void OnCosmeticSet(string prodId, int colorID, CosmeticsLayer.CosmeticKind cosmeticType) { }

	// RVA: 0x655A60 Offset: 0x654C60 VA: 0x180655A60
	public void SetHeightFromColor(int colorIndex) { }

	// RVA: 0x655A10 Offset: 0x654C10 VA: 0x180655A10
	public void SetHeighFromDistanceHnS(float distance) { }

	// RVA: 0x653FA0 Offset: 0x6531A0 VA: 0x180653FA0
	private void HideAndSeekUpdate() { }

	// RVA: 0x655D20 Offset: 0x654F20 VA: 0x180655D20
	private void SetupNeckGrowth(bool snapNeck = False, bool resetNeck = True) { }

	// RVA: 0x6543E0 Offset: 0x6535E0 VA: 0x1806543E0
	private void LateUpdate() { }

	// RVA: 0x653D10 Offset: 0x652F10 VA: 0x180653D10
	private void GrowNeck() { }

	// RVA: 0x655980 Offset: 0x654B80 VA: 0x180655980
	private void ResetNeck() { }

	// RVA: 0x655C20 Offset: 0x654E20 VA: 0x180655C20
	public void SetPoolableGhost() { }

	// RVA: 0x6560B0 Offset: 0x6552B0 VA: 0x1806560B0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerBodySprite // TypeDefIndex: 1431
{
	// Fields
	public SpriteRenderer BodySprite; // 0x10
	[FormerlySerializedAs("extraParts")]
	public SpriteRenderer[] LongModeParts; // 0x18
	public PlayerPettingHand PettingHand; // 0x20
	public SpriteRenderer HandHat; // 0x28
	public Sprite GhostSprite; // 0x30
	public Sprite[] ExtraGhostSprites; // 0x38
	public PlayerBodyTypes Type; // 0x40
	public Vector3 flippedCosmeticOffset; // 0x44
	public Vector3 normalCosmeticOffset; // 0x50

	// Properties
	public bool Visible { get; set; }

	// Methods

	// RVA: 0x65A380 Offset: 0x659580 VA: 0x18065A380
	public bool get_Visible() { }

	// RVA: 0x65A3A0 Offset: 0x6595A0 VA: 0x18065A3A0
	public void set_Visible(bool value) { }

	// RVA: 0x65A2F0 Offset: 0x6594F0 VA: 0x18065A2F0
	public void SetFlipX(bool flipX) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum PlayerBodyTypes // TypeDefIndex: 1432
{
	// Fields
	public int value__; // 0x0
	public const PlayerBodyTypes Normal = 0;
	public const PlayerBodyTypes Horse = 1;
	public const PlayerBodyTypes Seeker = 2;
	public const PlayerBodyTypes Long = 3;
	public const PlayerBodyTypes LongSeeker = 4;
}

// Namespace: 
[Extension]
public static class PlayerBodyTypesExtensions // TypeDefIndex: 1433
{
	// Fields
	private static readonly Dictionary<PlayerBodyTypes, HatOptions> CustomHatOptions; // 0x0
	private static readonly Dictionary<PlayerBodyTypes, SkinOptions> CustomSkinOptions; // 0x8
	private static readonly Dictionary<PlayerBodyTypes, VisorOptions> CustomVisorOptions; // 0x10

	// Methods

	[Extension]
	// RVA: 0x65A430 Offset: 0x659630 VA: 0x18065A430
	public static HatOptions GetHatOptions(PlayerBodyTypes bodyTypes) { }

	[Extension]
	// RVA: 0x65A4B0 Offset: 0x6596B0 VA: 0x18065A4B0
	public static SkinOptions GetSkinOptions(PlayerBodyTypes bodyTypes) { }

	[Extension]
	// RVA: 0x65A530 Offset: 0x659730 VA: 0x18065A530
	public static VisorOptions GetVisorOptions(PlayerBodyTypes bodyTypes) { }

	// RVA: 0x65A5B0 Offset: 0x6597B0 VA: 0x18065A5B0
	private static void .cctor() { }
}

// Namespace: 
public enum DeathReason // TypeDefIndex: 1434
{
	// Fields
	public int value__; // 0x0
	public const DeathReason Exile = 0;
	public const DeathReason Kill = 1;
	public const DeathReason Disconnect = 2;
}

// Namespace: 
public enum PlayerOutfitType // TypeDefIndex: 1435
{
	// Fields
	public int value__; // 0x0
	public const PlayerOutfitType Default = 0;
	public const PlayerOutfitType Shapeshifted = 1;
	public const PlayerOutfitType HorseWrangler = 2;
	public const PlayerOutfitType MushroomMixup = 3;
}

// Namespace: 
[Flags]
public enum MurderResultFlags // TypeDefIndex: 1436
{
	// Fields
	public int value__; // 0x0
	public const MurderResultFlags NULL = 0;
	public const MurderResultFlags Succeeded = 1;
	public const MurderResultFlags FailedError = 2;
	public const MurderResultFlags FailedProtected = 4;
	public const MurderResultFlags DecisionByHost = 8;
}

// Namespace: 
public class PlayerControl.ColliderComparer : IEqualityComparer<Collider2D> // TypeDefIndex: 1437
{
	// Fields
	public static readonly PlayerControl.ColliderComparer Instance; // 0x0

	// Methods

	// RVA: 0x666810 Offset: 0x665A10 VA: 0x180666810 Slot: 4
	public bool Equals(Collider2D x, Collider2D y) { }

	// RVA: 0x666870 Offset: 0x665A70 VA: 0x180666870 Slot: 5
	public int GetHashCode(Collider2D obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x666890 Offset: 0x665A90 VA: 0x180666890
	private static void .cctor() { }
}

// Namespace: 
public class PlayerControl.UsableComparer : IEqualityComparer<IUsable> // TypeDefIndex: 1438
{
	// Fields
	public static readonly PlayerControl.UsableComparer Instance; // 0x0

	// Methods

	// RVA: 0x67F820 Offset: 0x67EA20 VA: 0x18067F820 Slot: 4
	public bool Equals(IUsable x, IUsable y) { }

	// RVA: 0x67F830 Offset: 0x67EA30 VA: 0x18067F830 Slot: 5
	public int GetHashCode(IUsable obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67F860 Offset: 0x67EA60 VA: 0x18067F860
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerControl.<>c // TypeDefIndex: 1439
{
	// Fields
	public static readonly PlayerControl.<>c <>9; // 0x0
	public static Action <>9__82_1; // 0x8
	public static Action <>9__82_3; // 0x10
	public static Action <>9__83_1; // 0x18
	public static Predicate<PlayerTask> <>9__114_0; // 0x20
	public static Func<PlayerControl, bool> <>9__116_0; // 0x28
	public static Action<PlayerControl> <>9__116_1; // 0x30
	public static Predicate<PlayerTask> <>9__145_0; // 0x38
	public static Predicate<PlayerTask> <>9__170_0; // 0x40

	// Methods

	// RVA: 0x67F5E0 Offset: 0x67E7E0 VA: 0x18067F5E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E470 Offset: 0x67D670 VA: 0x18067E470
	internal void <Start>b__82_1() { }

	// RVA: 0x67E4D0 Offset: 0x67D6D0 VA: 0x18067E4D0
	internal void <Start>b__82_3() { }

	// RVA: 0x67E2D0 Offset: 0x67D4D0 VA: 0x18067E2D0
	internal void <ClientInitialize>b__83_1() { }

	// RVA: 0x67E450 Offset: 0x67D650 VA: 0x18067E450
	internal bool <MustCleanVent>b__114_0(PlayerTask p) { }

	// RVA: 0x67E330 Offset: 0x67D530 VA: 0x18067E330
	internal bool <CoSetRole>b__116_0(PlayerControl pc) { }

	// RVA: 0x67E3D0 Offset: 0x67D5D0 VA: 0x18067E3D0
	internal void <CoSetRole>b__116_1(PlayerControl pc) { }

	// RVA: 0x67E2B0 Offset: 0x67D4B0 VA: 0x18067E2B0
	internal bool <AreCommsAffected>b__145_0(PlayerTask x) { }

	// RVA: 0x67E430 Offset: 0x67D630 VA: 0x18067E430
	internal bool <FixMixedUpOutfit>b__170_0(PlayerTask x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass112_0 // TypeDefIndex: 1440
{
	// Fields
	public uint idx; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E530 Offset: 0x67D730 VA: 0x18067E530
	internal bool <CompleteTask>b__0(PlayerTask p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass118_0 // TypeDefIndex: 1441
{
	// Fields
	public PlayerControl <>4__this; // 0x10
	public string playerName; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E550 Offset: 0x67D750 VA: 0x18067E550
	internal bool <CheckName>b__0(NetworkedPlayerInfo i) { }

	// RVA: 0x67E5B0 Offset: 0x67D7B0 VA: 0x18067E5B0
	internal void <CheckName>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass122_0 // TypeDefIndex: 1442
{
	// Fields
	public PlayerControl <>4__this; // 0x10
	public byte bodyColor; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E6D0 Offset: 0x67D8D0 VA: 0x18067E6D0
	internal bool <CheckColor>b__0(NetworkedPlayerInfo p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass136_0 // TypeDefIndex: 1443
{
	// Fields
	public SpriteRenderer target; // 0x10
	public int colorId; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E730 Offset: 0x67D930 VA: 0x18067E730
	internal void <SetSkinImageAsync>b__0(SkinViewData skinView) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass156_0 // TypeDefIndex: 1444
{
	// Fields
	public NetworkedPlayerInfo targetPlayerInfo; // 0x10
	public PlayerControl <>4__this; // 0x18
	public NetworkedPlayerInfo.PlayerOutfit newOutfit; // 0x20
	public PlayerControl targetPlayer; // 0x28
	public Action changeOutfit; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67E890 Offset: 0x67DA90 VA: 0x18067E890
	internal void <Shapeshift>b__0() { }

	// RVA: 0x67EBF0 Offset: 0x67DDF0 VA: 0x18067EBF0
	internal void <Shapeshift>b__1() { }

	// RVA: 0x67ED80 Offset: 0x67DF80 VA: 0x18067ED80
	internal void <Shapeshift>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass158_0 // TypeDefIndex: 1445
{
	// Fields
	public PhantomRole phantomRole; // 0x10
	public bool playFullAnimation; // 0x18
	public PlayerControl <>4__this; // 0x20
	public Action <>9__2; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67EDF0 Offset: 0x67DFF0 VA: 0x18067EDF0
	internal void <SetRoleInvisibility>b__0() { }

	// RVA: 0x67EE60 Offset: 0x67E060 VA: 0x18067EE60
	internal void <SetRoleInvisibility>b__1() { }

	// RVA: 0x67F070 Offset: 0x67E270 VA: 0x18067F070
	internal void <SetRoleInvisibility>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass159_0 // TypeDefIndex: 1446
{
	// Fields
	public PhantomRole phantomRole; // 0x10
	public PlayerControl <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67F0B0 Offset: 0x67E2B0 VA: 0x18067F0B0
	internal void <LoopChargeAnim>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass161_0 // TypeDefIndex: 1447
{
	// Fields
	public PhantomRole phantomRole; // 0x10
	public PlayerControl <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67F0F0 Offset: 0x67E2F0 VA: 0x18067F0F0
	internal void <AppearOtherClients>b__0() { }

	// RVA: 0x67F300 Offset: 0x67E500 VA: 0x18067F300
	internal void <AppearOtherClients>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass162_0 // TypeDefIndex: 1448
{
	// Fields
	public PlayerControl <>4__this; // 0x10
	public PhantomRole phantomRole; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67F340 Offset: 0x67E540 VA: 0x18067F340
	internal void <ContinueVanish>b__0() { }

	// RVA: 0x67F530 Offset: 0x67E730 VA: 0x18067F530
	internal void <ContinueVanish>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<>c__DisplayClass89_0 // TypeDefIndex: 1449
{
	// Fields
	public IUsable item; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x67F5D0 Offset: 0x67E7D0 VA: 0x18067F5D0
	internal bool <FixedUpdate>b__0(IUsable j) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<AssertWithTimeout>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1450
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Func<bool> assertion; // 0x20
	public float timeoutInSeconds; // 0x28
	public Action onTimeout; // 0x30
	private bool <failed>5__2; // 0x38
	private float <timer>5__3; // 0x3C

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

	// RVA: 0x67ADC0 Offset: 0x679FC0 VA: 0x18067ADC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67AE80 Offset: 0x67A080 VA: 0x18067AE80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<ClientInitialize>d__83 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1451
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20

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

	// RVA: 0x67AEC0 Offset: 0x67A0C0 VA: 0x18067AEC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67B1E0 Offset: 0x67A3E0 VA: 0x18067B1E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetColor>d__125 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1452
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public int bodyColor; // 0x28
	private int <attempts>5__2; // 0x2C

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

	// RVA: 0x67B220 Offset: 0x67A420 VA: 0x18067B220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67B3D0 Offset: 0x67A5D0 VA: 0x18067B3D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetCosmetic>d__188 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1453
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public RpcCalls rpc; // 0x28
	public byte sequenceId; // 0x29
	public string cosmeticId; // 0x30
	private int <attempts>5__2; // 0x38

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

	// RVA: 0x67B410 Offset: 0x67A610 VA: 0x18067B410 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67B8B0 Offset: 0x67AAB0 VA: 0x18067B8B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetLevel>d__129 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1454
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public uint level; // 0x28
	private int <attempts>5__2; // 0x2C

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

	// RVA: 0x67B8F0 Offset: 0x67AAF0 VA: 0x18067B8F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67BA90 Offset: 0x67AC90 VA: 0x18067BA90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetName>d__121 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1455
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public string playerName; // 0x28
	private int <attempts>5__2; // 0x30

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

	// RVA: 0x67BAD0 Offset: 0x67ACD0 VA: 0x18067BAD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67BCD0 Offset: 0x67AED0 VA: 0x18067BCD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetRole>d__116 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1456
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoleTypes role; // 0x20
	public PlayerControl <>4__this; // 0x28
	public bool canOverride; // 0x30
	private bool <ghostRole>5__2; // 0x31
	private int <attempts>5__3; // 0x34

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

	// RVA: 0x67BD10 Offset: 0x67AF10 VA: 0x18067BD10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67C660 Offset: 0x67B860 VA: 0x18067C660 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<CoSetTasks>d__103 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1457
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public List<NetworkedPlayerInfo.TaskInfo> tasks; // 0x28

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

	// RVA: 0x67C6A0 Offset: 0x67B8A0 VA: 0x18067C6A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67CB00 Offset: 0x67BD00 VA: 0x18067CB00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<EnableRightJoystick>d__187 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1458
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool enabled; // 0x20

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

	// RVA: 0x67CB40 Offset: 0x67BD40 VA: 0x18067CB40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67CC30 Offset: 0x67BE30 VA: 0x18067CC30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<ScalePlayer>d__168 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1459
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20
	public float targetScale; // 0x28
	public float duration; // 0x2C
	private float <elapsedTime>5__2; // 0x30

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

	// RVA: 0x67CC70 Offset: 0x67BE70 VA: 0x18067CC70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67CFB0 Offset: 0x67C1B0 VA: 0x18067CFB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerControl.<Start>d__82 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1460
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl <>4__this; // 0x20

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

	// RVA: 0x67CFF0 Offset: 0x67C1F0 VA: 0x18067CFF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67E270 Offset: 0x67D470 VA: 0x18067E270 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlayerControl : InnerNetObject // TypeDefIndex: 1461
{
	// Fields
	private const int MAX_NETOBJECT_INIT_ATTEMPTS = 60;
	private const float NETOBJECT_INIT_ATTEMPT_WAIT_SECONDS = 0,1;
	public byte PlayerId; // 0x38
	public string FriendCode; // 0x40
	public string Puid; // 0x48
	public float MaxReportDistance; // 0x50
	public bool moveable; // 0x54
	public CosmeticsLayer cosmetics; // 0x58
	[HideInInspector]
	public bool ForceKillTimerContinue; // 0x60
	[CompilerGenerated]
	private PlayerOutfitType <CurrentOutfitType>k__BackingField; // 0x64
	public bool inVent; // 0x68
	public bool walkingToVent; // 0x69
	public bool petting; // 0x6A
	public bool inMovingPlat; // 0x6B
	public bool onLadder; // 0x6C
	public bool protectedByGuardianThisRound; // 0x6D
	public bool shapeshifting; // 0x6E
	public bool waitingForShapeshiftResponse; // 0x6F
	public bool isKilling; // 0x70
	private float invisibilityAlpha; // 0x74
	private const float OFFSET_ANIM_CHARGE = -0,05;
	public static PlayerControl LocalPlayer; // 0x0
	private NetworkedPlayerInfo CachedPlayerData; // 0x78
	private int protectedByGuardianId; // 0x80
	private float flashlightAngle; // 0x84
	private int shapeshiftTargetPlayerId; // 0x88
	private bool shouldAppearInvisible; // 0x8C
	public bool isTrackingPlayer; // 0x8D
	public PlayerControl trackedPlayer; // 0x90
	public int trackedPlayerColorID; // 0x98
	public AudioSource FootSteps; // 0xA0
	public AudioClip KillSfx; // 0xA8
	public KillAnimation[] KillAnimations; // 0xB0
	[SerializeField]
	private float killTimer; // 0xB8
	public int RemainingEmergencies; // 0xBC
	public LightSource LightPrefab; // 0xC0
	private LightSource lightSource; // 0xC8
	[HideInInspector]
	public Collider2D Collider; // 0xD0
	[HideInInspector]
	public PlayerPhysics MyPhysics; // 0xD8
	[HideInInspector]
	public CustomNetworkTransform NetTransform; // 0xE0
	[SerializeField]
	private Collider2D clickKillCollider; // 0xE8
	public Vector3 defaultCosmeticsScale; // 0xF0
	public List<PlayerTask> myTasks; // 0x100
	public List<RoleEffectAnimation> currentRoleAnimations; // 0x108
	public GameObject TargetFlashlight; // 0x110
	public bool isDummy; // 0x118
	public bool notRealPlayer; // 0x119
	private readonly Logger logger; // 0x120
	private readonly List<IPlayerVisibleItem> visibilityItems; // 0x128
	private Collider2D[] hitBuffer; // 0x130
	private IUsable closest; // 0x138
	private bool isNew; // 0x140
	private bool hasBeenSerialized; // 0x141
	private Rigidbody2D rigidbody2D; // 0x148
	public static List<PlayerControl> AllPlayerControls; // 0x8
	private Dictionary<Collider2D, IUsable[]> cache; // 0x150
	private List<IUsable> itemsInRange; // 0x158
	private List<IUsable> newItemsInRange; // 0x160
	private byte scannerCount; // 0x168
	private bool roleAssigned; // 0x169
	private int LastStartCounter; // 0x16C

	// Properties
	public bool CanMove { get; }
	public bool IsKillTimerEnabled { get; }
	public NetworkedPlayerInfo.PlayerOutfit CurrentOutfit { get; }
	public PlayerOutfitType CurrentOutfitType { get; set; }
	public float CalculatedAlpha { get; }
	public float FlashlightAngle { get; set; }
	public bool PhantomFadeActive { get; }
	public NetworkedPlayerInfo Data { get; }
	public bool Visible { get; set; }
	public PlayerBodyTypes BodyType { get; }

	// Methods

	// RVA: 0x676F70 Offset: 0x676170 VA: 0x180676F70
	public bool get_CanMove() { }

	// RVA: 0x6774F0 Offset: 0x6766F0 VA: 0x1806774F0
	public bool get_IsKillTimerEnabled() { }

	// RVA: 0x677300 Offset: 0x676500 VA: 0x180677300
	public NetworkedPlayerInfo.PlayerOutfit get_CurrentOutfit() { }

	[CompilerGenerated]
	// RVA: 0x6772F0 Offset: 0x6764F0 VA: 0x1806772F0
	public PlayerOutfitType get_CurrentOutfitType() { }

	[CompilerGenerated]
	// RVA: 0x677720 Offset: 0x676920 VA: 0x180677720
	private void set_CurrentOutfitType(PlayerOutfitType value) { }

	// RVA: 0x676F60 Offset: 0x676160 VA: 0x180676F60
	public float get_CalculatedAlpha() { }

	// RVA: 0x6774E0 Offset: 0x6766E0 VA: 0x1806774E0
	public float get_FlashlightAngle() { }

	// RVA: 0x677730 Offset: 0x676930 VA: 0x180677730
	public void set_FlashlightAngle(float value) { }

	// RVA: 0x6776D0 Offset: 0x6768D0 VA: 0x1806776D0
	public bool get_PhantomFadeActive() { }

	// RVA: 0x677400 Offset: 0x676600 VA: 0x180677400
	public NetworkedPlayerInfo get_Data() { }

	// RVA: 0x674220 Offset: 0x673420 VA: 0x180674220
	public void SetKillTimer(float time) { }

	// RVA: 0x6776E0 Offset: 0x6768E0 VA: 0x1806776E0
	public bool get_Visible() { }

	// RVA: 0x677750 Offset: 0x676950 VA: 0x180677750
	public void set_Visible(bool value) { }

	// RVA: 0x676F00 Offset: 0x676100 VA: 0x180676F00
	public PlayerBodyTypes get_BodyType() { }

	// RVA: 0x667250 Offset: 0x666450 VA: 0x180667250
	private void Awake() { }

	// RVA: 0x66F510 Offset: 0x66E710 VA: 0x18066F510
	private void OnEnable() { }

	// RVA: 0x66F400 Offset: 0x66E600 VA: 0x18066F400
	private void OnDisable() { }

	[IteratorStateMachine(typeof(PlayerControl.<AssertWithTimeout>d__81))]
	// RVA: 0x6671D0 Offset: 0x6663D0 VA: 0x1806671D0
	private IEnumerator AssertWithTimeout(Func<bool> assertion, Action onTimeout, float timeoutInSeconds) { }

	[IteratorStateMachine(typeof(PlayerControl.<Start>d__82))]
	// RVA: 0x675F10 Offset: 0x675110 VA: 0x180675F10
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(PlayerControl.<ClientInitialize>d__83))]
	// RVA: 0x669300 Offset: 0x668500 VA: 0x180669300
	private IEnumerator ClientInitialize() { }

	// RVA: 0x66F370 Offset: 0x66E570 VA: 0x18066F370 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x66B6C0 Offset: 0x66A8C0 VA: 0x18066B6C0
	private void FixedUpdate() { }

	// RVA: 0x666E90 Offset: 0x666090 VA: 0x180666E90
	public void AnimateCustom(AnimationClip anim) { }

	// RVA: 0x66F660 Offset: 0x66E860 VA: 0x18066F660
	public void OnGameStart() { }

	// RVA: 0x66F630 Offset: 0x66E830 VA: 0x18066F630
	public void OnGameEnd() { }

	// RVA: 0x676AE0 Offset: 0x675CE0 VA: 0x180676AE0
	public void UseClosest() { }

	// RVA: 0x670370 Offset: 0x66F570 VA: 0x180670370
	public void RegisterVisibilityItem(IPlayerVisibleItem obj) { }

	// RVA: 0x676A80 Offset: 0x675C80 VA: 0x180676A80
	public void UnregisterVisibilityItem(IPlayerVisibleItem obj) { }

	// RVA: 0x6760B0 Offset: 0x6752B0 VA: 0x1806760B0
	public void TryPet() { }

	// RVA: 0x670820 Offset: 0x66FA20 VA: 0x180670820
	public void ReportClosest() { }

	// RVA: 0x66F850 Offset: 0x66EA50 VA: 0x18066F850
	public void PlayStepSound() { }

	// RVA: 0x674F00 Offset: 0x674100 VA: 0x180674F00
	private void SetScanner(bool on, byte cnt) { }

	// RVA: 0x66CDA0 Offset: 0x66BFA0 VA: 0x18066CDA0
	public Vector2 GetTruePosition() { }

	// RVA: 0x6750F0 Offset: 0x6742F0 VA: 0x1806750F0
	public void SetTasks(List<NetworkedPlayerInfo.TaskInfo> tasks) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetTasks>d__103))]
	// RVA: 0x66A2D0 Offset: 0x6694D0 VA: 0x18066A2D0
	private IEnumerator CoSetTasks(List<NetworkedPlayerInfo.TaskInfo> tasks) { }

	// RVA: 0x6668F0 Offset: 0x665AF0 VA: 0x1806668F0
	public PlayerTask AddSystemTask(SystemTypes system) { }

	// RVA: 0x670700 Offset: 0x66F900 VA: 0x180670700
	public void RemoveTask(PlayerTask task) { }

	// RVA: 0x6691C0 Offset: 0x6683C0 VA: 0x1806691C0
	public void ClearTasks() { }

	// RVA: 0x66AAE0 Offset: 0x669CE0 VA: 0x18066AAE0
	public void Die(DeathReason reason, bool assignGhostRole) { }

	// RVA: 0x671540 Offset: 0x670740 VA: 0x180671540
	public void Revive() { }

	// RVA: 0x66F240 Offset: 0x66E440 VA: 0x18066F240
	public void OnClick() { }

	// RVA: 0x6683C0 Offset: 0x6675C0 VA: 0x1806683C0
	public void CheckSeekerHand_AnimEvent() { }

	// RVA: 0x66F7A0 Offset: 0x66E9A0 VA: 0x18066F7A0
	public void PlayAnimation(byte animType) { }

	// RVA: 0x66A340 Offset: 0x669540 VA: 0x18066A340
	public void CompleteTask(uint idx) { }

	// RVA: 0x666D70 Offset: 0x665F70 VA: 0x180666D70
	public bool AllTasksCompleted() { }

	// RVA: 0x66F030 Offset: 0x66E230 VA: 0x18066F030
	public bool MustCleanVent(int ventId) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetRole>d__116))]
	// RVA: 0x66A250 Offset: 0x669450 VA: 0x18066A250
	private IEnumerator CoSetRole(RoleTypes role, bool canOverride) { }

	// RVA: 0x66B340 Offset: 0x66A540 VA: 0x18066B340
	public void Exiled() { }

	// RVA: 0x667CA0 Offset: 0x666EA0 VA: 0x180667CA0
	public void CheckName(string playerName) { }

	// RVA: 0x674350 Offset: 0x673550 VA: 0x180674350
	public void SetKinematic(bool b) { }

	// RVA: 0x674430 Offset: 0x673630 VA: 0x180674430
	public void SetName(string playerName) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetName>d__121))]
	// RVA: 0x66A1E0 Offset: 0x6693E0 VA: 0x18066A1E0
	private IEnumerator CoSetName(string playerName) { }

	// RVA: 0x667610 Offset: 0x666810 VA: 0x180667610
	public void CheckColor(byte bodyColor) { }

	// RVA: 0x673E50 Offset: 0x673050 VA: 0x180673E50
	public void SetHatAndVisorAlpha(float a) { }

	// RVA: 0x673BF0 Offset: 0x672DF0 VA: 0x180673BF0
	public void SetColor(int bodyColor) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetColor>d__125))]
	// RVA: 0x66A060 Offset: 0x669260 VA: 0x18066A060
	private IEnumerator CoSetColor(int bodyColor) { }

	// RVA: 0x674400 Offset: 0x673600 VA: 0x180674400
	public void SetNamePlate(string namePlateId) { }

	// RVA: 0x675170 Offset: 0x674370 VA: 0x180675170
	public void SetVisor(string visorId, int colorId) { }

	// RVA: 0x674380 Offset: 0x673580 VA: 0x180674380
	public void SetLevel(uint level) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetLevel>d__129))]
	// RVA: 0x66A170 Offset: 0x669370 VA: 0x18066A170
	private IEnumerator CoSetLevel(uint level) { }

	// RVA: 0x675090 Offset: 0x674290 VA: 0x180675090
	public void SetSkin(string skinId, int color) { }

	// RVA: 0x673ED0 Offset: 0x6730D0 VA: 0x180673ED0
	public void SetHat(string hatId, int colorId) { }

	// RVA: 0x674740 Offset: 0x673940 VA: 0x180674740
	public void SetPet(string petId) { }

	// RVA: 0x6746E0 Offset: 0x6738E0 VA: 0x1806746E0
	public void SetPet(string petId, int colorId) { }

	// RVA: 0x6746A0 Offset: 0x6738A0 VA: 0x1806746A0
	public void SetPetPosition(Vector3 newPosition) { }

	// RVA: 0x66CD80 Offset: 0x66BF80 VA: 0x18066CD80
	public PetBehaviour GetPet() { }

	// RVA: 0x674FA0 Offset: 0x6741A0 VA: 0x180674FA0
	public static void SetSkinImageAsync(SkinData skin, int colorId, SpriteRenderer target) { }

	// RVA: 0x670A60 Offset: 0x66FC60 VA: 0x180670A60
	private void ReportDeadBody(NetworkedPlayerInfo target) { }

	// RVA: 0x668C20 Offset: 0x667E20 VA: 0x180668C20
	private void CheckUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop) { }

	// RVA: 0x6689A0 Offset: 0x667BA0 VA: 0x1806689A0
	private void CheckSporeTrigger(Mushroom mushroom) { }

	// RVA: 0x675C90 Offset: 0x674E90 VA: 0x180675C90
	public void StartMeeting(NetworkedPlayerInfo target) { }

	// RVA: 0x670E60 Offset: 0x670060 VA: 0x180670E60
	public void ResetForMeeting() { }

	// RVA: 0x667880 Offset: 0x666A80 VA: 0x180667880
	public void CheckMurder(PlayerControl target) { }

	// RVA: 0x668440 Offset: 0x667640 VA: 0x180668440
	private void CheckShapeshift(PlayerControl target, bool shouldAnimate) { }

	// RVA: 0x66DEE0 Offset: 0x66D0E0 VA: 0x18066DEE0
	public bool IsMushroomMixupActive() { }

	// RVA: 0x667090 Offset: 0x666290 VA: 0x180667090
	public bool AreCommsAffected() { }

	// RVA: 0x66E490 Offset: 0x66D690 VA: 0x18066E490
	public void MurderPlayer(PlayerControl target, MurderResultFlags resultFlags) { }

	// RVA: 0x667FB0 Offset: 0x6671B0 VA: 0x180667FB0
	public void CheckProtect(PlayerControl target) { }

	// RVA: 0x66FC90 Offset: 0x66EE90 VA: 0x18066FC90
	public void ProtectPlayer(PlayerControl target, int colorId) { }

	// RVA: 0x674830 Offset: 0x673A30 VA: 0x180674830
	public void SetPlayerMaterialColors(Renderer rend) { }

	// RVA: 0x66DC00 Offset: 0x66CE00 VA: 0x18066DC00
	public static void HideCursorTemporarily() { }

	// RVA: 0x6736F0 Offset: 0x6728F0 VA: 0x1806736F0
	public void SetAppearanceFromSaveData() { }

	// RVA: 0x675F70 Offset: 0x675170 VA: 0x180675F70
	public void ToggleHighlight(bool active, RoleTeamTypes targeterTeam) { }

	// RVA: 0x6744B0 Offset: 0x6736B0 VA: 0x1806744B0
	public void SetOutfit(NetworkedPlayerInfo.PlayerOutfit newOutfit, PlayerOutfitType type) { }

	// RVA: 0x670010 Offset: 0x66F210 VA: 0x180670010
	public void RawSetOutfit(NetworkedPlayerInfo.PlayerOutfit newOutfit, PlayerOutfitType type) { }

	// RVA: 0x670570 Offset: 0x66F770 VA: 0x180670570
	public void RejectShapeshift() { }

	// RVA: 0x6751D0 Offset: 0x6743D0 VA: 0x1806751D0
	public void Shapeshift(PlayerControl targetPlayer, bool animate) { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int ShapeshiftedPlayerID() { }

	// RVA: 0x6748E0 Offset: 0x673AE0 VA: 0x1806748E0
	private void SetRoleInvisibility(bool isActive, bool shouldAnimate = True, bool playFullAnimation = False) { }

	// RVA: 0x66DFD0 Offset: 0x66D1D0 VA: 0x18066DFD0
	private void LoopChargeAnim(PhantomRole phantomRole) { }

	// RVA: 0x66CA90 Offset: 0x66BC90 VA: 0x18066CA90
	public void ForcePhantomVisible() { }

	// RVA: 0x666F30 Offset: 0x666130 VA: 0x180666F30
	private void AppearOtherClients() { }

	// RVA: 0x66A7E0 Offset: 0x6699E0 VA: 0x18066A7E0
	private void ContinueVanish() { }

	// RVA: 0x673F30 Offset: 0x673130 VA: 0x180673F30
	private void SetInvisibility(bool isActive) { }

	// RVA: 0x675EF0 Offset: 0x6750F0 VA: 0x180675EF0
	public void StartPlayerTracking(PlayerControl playerToTrack, int colorID) { }

	// RVA: 0x667480 Offset: 0x666680 VA: 0x180667480
	public void CancelPlayerTracking() { }

	// RVA: 0x66B130 Offset: 0x66A330 VA: 0x18066B130
	public void DisableCurrentTrackers() { }

	// RVA: 0x66E220 Offset: 0x66D420 VA: 0x18066E220
	public void MixUpOutfit(NetworkedPlayerInfo.PlayerOutfit playerOutfit) { }

	[IteratorStateMachine(typeof(PlayerControl.<ScalePlayer>d__168))]
	// RVA: 0x673610 Offset: 0x672810 VA: 0x180673610
	public IEnumerator ScalePlayer(float targetScale, float duration) { }

	// RVA: 0x669900 Offset: 0x668B00 VA: 0x180669900
	public void CmdCheckRevertShapeshift(bool shouldAnimate) { }

	// RVA: 0x66B3D0 Offset: 0x66A5D0 VA: 0x18066B3D0
	public void FixMixedUpOutfit() { }

	// RVA: 0x66FFA0 Offset: 0x66F1A0 VA: 0x18066FFA0
	private void RawSetName(string name) { }

	// RVA: 0x66FEF0 Offset: 0x66F0F0 VA: 0x18066FEF0
	private void RawSetColor(int bodyColor) { }

	// RVA: 0x670350 Offset: 0x66F550 VA: 0x180670350
	private void RawSetVisor(string visorId, int color) { }

	// RVA: 0x670280 Offset: 0x66F480 VA: 0x180670280
	private void RawSetSkin(string skinId, int color) { }

	// RVA: 0x66FF10 Offset: 0x66F110 VA: 0x18066FF10
	private void RawSetHat(string hatId, int colorId) { }

	// RVA: 0x6701C0 Offset: 0x66F3C0 VA: 0x1806701C0
	private void RawSetPet(string petId, int colorId) { }

	// RVA: 0x675B60 Offset: 0x674D60 VA: 0x180675B60
	private void ShowFailedMurder() { }

	// RVA: 0x670580 Offset: 0x66F780 VA: 0x180670580
	private void RemoveProtection() { }

	// RVA: 0x676420 Offset: 0x675620 VA: 0x180676420
	private void TurnOnProtection(bool visible, int colorId, int guardianPlayerId) { }

	// RVA: 0x673AE0 Offset: 0x672CE0 VA: 0x180673AE0
	private void SetColorBlindTag() { }

	// RVA: 0x6673F0 Offset: 0x6665F0 VA: 0x1806673F0
	public bool CanPet() { }

	// RVA: 0x666A70 Offset: 0x665C70 VA: 0x180666A70
	public void AdjustLighting() { }

	// RVA: 0x66DCC0 Offset: 0x66CEC0 VA: 0x18066DCC0
	private bool IsFlashlightEnabled() { }

	// RVA: 0x673C70 Offset: 0x672E70 VA: 0x180673C70
	private void SetFlashlightInputMethod() { }

	[IteratorStateMachine(typeof(PlayerControl.<EnableRightJoystick>d__187))]
	// RVA: 0x66B2E0 Offset: 0x66A4E0 VA: 0x18066B2E0
	private IEnumerator EnableRightJoystick(bool enabled) { }

	[IteratorStateMachine(typeof(PlayerControl.<CoSetCosmetic>d__188))]
	// RVA: 0x66A0D0 Offset: 0x6692D0 VA: 0x18066A0D0
	private IEnumerator CoSetCosmetic(RpcCalls rpc, string cosmeticId, byte sequenceId) { }

	// RVA: 0x675960 Offset: 0x674B60 VA: 0x180675960
	private bool ShouldProcessRpc(RpcCalls rpc, byte sequenceId) { }

	// RVA: 0x66CAA0 Offset: 0x66BCA0 VA: 0x18066CAA0
	private byte GetNextRpcSequenceId(RpcCalls rpc) { }

	// RVA: 0x672A30 Offset: 0x671C30 VA: 0x180672A30
	public void RpcSetScanner(bool value) { }

	// RVA: 0x673300 Offset: 0x672500 VA: 0x180673300
	public void RpcUsePlatform() { }

	// RVA: 0x669C40 Offset: 0x668E40 VA: 0x180669C40
	public void CmdCheckUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop) { }

	// RVA: 0x669B40 Offset: 0x668D40 VA: 0x180669B40
	public void CmdCheckSporeTrigger(Mushroom mushroom) { }

	// RVA: 0x671AC0 Offset: 0x670CC0 VA: 0x180671AC0
	public void RpcPlayAnimation(byte animType) { }

	// RVA: 0x672CF0 Offset: 0x671EF0 VA: 0x180672CF0
	public void RpcSetStartCounter(int secondsLeft) { }

	// RVA: 0x6718E0 Offset: 0x670AE0 VA: 0x1806718E0
	public void RpcCompleteTask(uint idx) { }

	// RVA: 0x672900 Offset: 0x671B00 VA: 0x180672900
	public void RpcSetRole(RoleTypes roleType, bool canOverrideRole = False) { }

	// RVA: 0x669720 Offset: 0x668920 VA: 0x180669720
	public void CmdCheckName(string name) { }

	// RVA: 0x672550 Offset: 0x671750 VA: 0x180672550
	public void RpcSetLevel(uint level) { }

	// RVA: 0x672DB0 Offset: 0x671FB0 VA: 0x180672DB0
	public void RpcSetVisor(string visorId) { }

	// RVA: 0x672620 Offset: 0x671820 VA: 0x180672620
	public void RpcSetNamePlate(string namePlateId) { }

	// RVA: 0x672B80 Offset: 0x671D80 VA: 0x180672B80
	public void RpcSetSkin(string skinId) { }

	// RVA: 0x6723E0 Offset: 0x6715E0 VA: 0x1806723E0
	public void RpcSetHat(string hatId) { }

	// RVA: 0x672810 Offset: 0x671A10 VA: 0x180672810
	public void RpcSetPet(string petId) { }

	// RVA: 0x672720 Offset: 0x671920 VA: 0x180672720
	public void RpcSetName(string name) { }

	// RVA: 0x669520 Offset: 0x668720 VA: 0x180669520
	public void CmdCheckColor(byte bodyColor) { }

	// RVA: 0x6722F0 Offset: 0x6714F0 VA: 0x1806722F0
	public void RpcSetColor(byte bodyColor) { }

	// RVA: 0x671ED0 Offset: 0x6710D0 VA: 0x180671ED0
	public bool RpcSendChat(string chatText) { }

	// RVA: 0x672100 Offset: 0x671300 VA: 0x180672100
	public bool RpcSendQuickChat(QuickChatPhraseBuilderResult data) { }

	// RVA: 0x671D90 Offset: 0x670F90 VA: 0x180671D90
	public void RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType) { }

	// RVA: 0x669F80 Offset: 0x669180 VA: 0x180669F80
	public void CmdReportDeadBody(NetworkedPlayerInfo target) { }

	// RVA: 0x673030 Offset: 0x672230 VA: 0x180673030
	public void RpcStartMeeting(NetworkedPlayerInfo info) { }

	// RVA: 0x669620 Offset: 0x668820 VA: 0x180669620
	public void CmdCheckMurder(PlayerControl target) { }

	// RVA: 0x669820 Offset: 0x668A20 VA: 0x180669820
	public void CmdCheckProtect(PlayerControl target) { }

	// RVA: 0x6719B0 Offset: 0x670BB0 VA: 0x1806719B0
	public void RpcMurderPlayer(PlayerControl target, bool didSucceed) { }

	// RVA: 0x673470 Offset: 0x672670 VA: 0x180673470
	public void RpcUseZipline(PlayerControl target, ZiplineBehaviour ziplineBehaviour, bool fromTop) { }

	// RVA: 0x673210 Offset: 0x672410 VA: 0x180673210
	public void RpcTriggerSpores(Mushroom mushroom) { }

	// RVA: 0x671BE0 Offset: 0x670DE0 VA: 0x180671BE0
	public void RpcProtectPlayer(PlayerControl target, int colorId) { }

	// RVA: 0x672F30 Offset: 0x672130 VA: 0x180672F30
	public void RpcShapeshift(PlayerControl target, bool shouldAnimate) { }

	// RVA: 0x669A20 Offset: 0x668C20 VA: 0x180669A20
	public void CmdCheckShapeshift(PlayerControl target, bool shouldAnimate) { }

	// RVA: 0x671CE0 Offset: 0x670EE0 VA: 0x180671CE0
	public void RpcRejectShapeshift() { }

	// RVA: 0x673120 Offset: 0x672320 VA: 0x180673120
	public void RpcSyncSettings(byte[] optionsByteArray) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x673690 Offset: 0x672890 VA: 0x180673690 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x66AA90 Offset: 0x669C90 VA: 0x18066AA90 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x66CE70 Offset: 0x66C070 VA: 0x18066CE70 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x66CE20 Offset: 0x66C020 VA: 0x18066CE20 Slot: 11
	public virtual void HandleRoleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x66DA80 Offset: 0x66CC80 VA: 0x18066DA80
	public void HandleServerVanish() { }

	// RVA: 0x66DA60 Offset: 0x66CC60 VA: 0x18066DA60
	public void HandleServerAppear(bool shouldAnimate) { }

	// RVA: 0x6690A0 Offset: 0x6682A0 VA: 0x1806690A0
	public void CheckVanish() { }

	// RVA: 0x673580 Offset: 0x672780 VA: 0x180673580
	public void RpcVanish() { }

	// RVA: 0x6674E0 Offset: 0x6666E0 VA: 0x1806674E0
	public void CheckAppear(bool shouldAnimate) { }

	// RVA: 0x671830 Offset: 0x670A30 VA: 0x180671830
	public void RpcAppear(bool shouldAnimate) { }

	// RVA: 0x669D80 Offset: 0x668F80 VA: 0x180669D80
	public void CmdCheckVanish(float maxDuration) { }

	// RVA: 0x669360 Offset: 0x668560 VA: 0x180669360
	public void CmdCheckAppear(bool shouldAnimate) { }

	// RVA: 0x676C60 Offset: 0x675E60 VA: 0x180676C60
	public void .ctor() { }

	// RVA: 0x676BF0 Offset: 0x675DF0 VA: 0x180676BF0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x676960 Offset: 0x675B60 VA: 0x180676960
	private bool <Start>b__82_0() { }

	[CompilerGenerated]
	// RVA: 0x676970 Offset: 0x675B70 VA: 0x180676970
	private bool <Start>b__82_2() { }

	[CompilerGenerated]
	// RVA: 0x6767B0 Offset: 0x6759B0 VA: 0x1806767B0
	private bool <ClientInitialize>b__83_0() { }

	[CompilerGenerated]
	// RVA: 0x676890 Offset: 0x675A90 VA: 0x180676890
	private void <CoSetName>b__121_0() { }

	[CompilerGenerated]
	// RVA: 0x676910 Offset: 0x675B10 VA: 0x180676910
	private void <RawSetPet>b__176_0() { }
}

// Namespace: 
public static class PlayerNameColor // TypeDefIndex: 1462
{
	// Methods

	// RVA: 0x677C70 Offset: 0x676E70 VA: 0x180677C70
	public static Color Get(NetworkedPlayerInfo pc) { }

	// RVA: 0x677DA0 Offset: 0x676FA0 VA: 0x180677DA0
	public static void Set(PlayerControl pc) { }

	// RVA: 0x677E00 Offset: 0x677000 VA: 0x180677E00
	public static void Set(NetworkedPlayerInfo playerInfo, TextMeshPro name) { }

	// RVA: 0x677CA0 Offset: 0x676EA0 VA: 0x180677CA0
	public static void SetForRoleDirectly(PlayerControl player, RoleBehaviour role) { }

	// RVA: 0x677A20 Offset: 0x676C20 VA: 0x180677A20
	private static Color Get(RoleBehaviour otherPlayerRole) { }

	// RVA: 0x677D50 Offset: 0x676F50 VA: 0x180677D50
	private static void Set(PlayerControl otherPlayer, RoleBehaviour otherPlayerRole) { }

	// RVA: 0x677D00 Offset: 0x676F00 VA: 0x180677D00
	private static void Set(TextMeshPro nameText, RoleBehaviour otherPlayerRole) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPettingHand.<WaitForPetAnimStart>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1463
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerPettingHand <>4__this; // 0x20
	public PetBehaviour pet; // 0x28

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

	// RVA: 0x67F640 Offset: 0x67E840 VA: 0x18067F640 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67F6B0 Offset: 0x67E8B0 VA: 0x18067F6B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPettingHand.<WaitUntilFinishedPetting>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1464
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerPettingHand <>4__this; // 0x20

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

	// RVA: 0x67F6F0 Offset: 0x67E8F0 VA: 0x18067F6F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x67F7E0 Offset: 0x67E9E0 VA: 0x18067F7E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlayerPettingHand : MonoBehaviour // TypeDefIndex: 1465
{
	// Fields
	public SpriteRenderer HandSprite; // 0x20
	public SpriteRenderer hearts; // 0x28
	public SpriteAnim HandSpriteAnim; // 0x30
	public AnimationClip PetClip; // 0x38
	private const int PET_ANIMATION_START_FRAME = 6;
	private const float ZPOS_PETTING = 1E-05;

	// Methods

	// RVA: 0x677F70 Offset: 0x677170 VA: 0x180677F70
	public void StartPet(PetBehaviour pet) { }

	[IteratorStateMachine(typeof(PlayerPettingHand.<WaitForPetAnimStart>d__7))]
	// RVA: 0x6780E0 Offset: 0x6772E0 VA: 0x1806780E0
	public IEnumerator WaitForPetAnimStart(PetBehaviour pet) { }

	[IteratorStateMachine(typeof(PlayerPettingHand.<WaitUntilFinishedPetting>d__8))]
	// RVA: 0x678150 Offset: 0x677350 VA: 0x180678150
	public IEnumerator WaitUntilFinishedPetting() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void StopPetting() { }

	// RVA: 0x677E60 Offset: 0x677060 VA: 0x180677E60
	public void SetAlpha(float alphaValue) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerPhysics.<>c // TypeDefIndex: 1466
{
	// Fields
	public static readonly PlayerPhysics.<>c <>9; // 0x0
	public static Action<RoleEffectAnimation> <>9__47_1; // 0x8
	public static Action<RoleEffectAnimation> <>9__48_1; // 0x10
	public static Action<Vent> <>9__53_0; // 0x18

	// Methods

	// RVA: 0x699180 Offset: 0x698380 VA: 0x180699180
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F00 Offset: 0x698100 VA: 0x180698F00
	internal void <CoEnterVent>b__47_1(RoleEffectAnimation an) { }

	// RVA: 0x698F30 Offset: 0x698130 VA: 0x180698F30
	internal void <CoExitVent>b__48_1(RoleEffectAnimation an) { }

	// RVA: 0x698E30 Offset: 0x698030 VA: 0x180698E30
	internal void <BootFromVent>b__53_0(Vent v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<>c__DisplayClass47_0 // TypeDefIndex: 1467
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F60 Offset: 0x698160 VA: 0x180698F60
	internal bool <CoEnterVent>b__0(Vent v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<>c__DisplayClass48_0 // TypeDefIndex: 1468
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F60 Offset: 0x698160 VA: 0x180698F60
	internal bool <CoExitVent>b__0(Vent v) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<>c__DisplayClass61_0 // TypeDefIndex: 1469
{
	// Fields
	public byte ladderId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F80 Offset: 0x698180 VA: 0x180698F80
	internal bool <HandleRpc>b__0(Ladder f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoAnimateCustom>d__41 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1470
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerPhysics <>4__this; // 0x20
	public AnimationClip anim; // 0x28

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

	// RVA: 0x6964B0 Offset: 0x6956B0 VA: 0x1806964B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x696600 Offset: 0x695800 VA: 0x180696600 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoClimbLadder>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1471
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerPhysics <>4__this; // 0x20
	public Ladder source; // 0x28
	private float <ladderTime>5__2; // 0x30
	private float <totalTime>5__3; // 0x34

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

	// RVA: 0x696640 Offset: 0x695840 VA: 0x180696640 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x696E90 Offset: 0x696090 VA: 0x180696E90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoEnterVent>d__47 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1472
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int id; // 0x20
	public PlayerPhysics <>4__this; // 0x28
	private PlayerPhysics.<>c__DisplayClass47_0 <>8__1; // 0x30
	private Vent <vent>5__2; // 0x38

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

	// RVA: 0x696ED0 Offset: 0x6960D0 VA: 0x180696ED0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x697520 Offset: 0x696720 VA: 0x180697520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoExitVent>d__48 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1473
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int id; // 0x20
	public PlayerPhysics <>4__this; // 0x28
	private PlayerPhysics.<>c__DisplayClass48_0 <>8__1; // 0x30

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

	// RVA: 0x697560 Offset: 0x696760 VA: 0x180697560 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x697AD0 Offset: 0x696CD0 VA: 0x180697AD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoPet>d__44 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1474
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerPhysics <>4__this; // 0x20
	public Vector2 petPos; // 0x28
	public Vector2 pos; // 0x30

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

	// RVA: 0x697B10 Offset: 0x696D10 VA: 0x180697B10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x697E30 Offset: 0x697030 VA: 0x180697E30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<CoSpawnPlayer>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1475
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LobbyBehaviour lobby; // 0x20
	public PlayerPhysics <>4__this; // 0x28
	private int <spawnSeatId>5__2; // 0x30
	private Vector3 <spawnPos>5__3; // 0x34
	private bool <amFlipped>5__4; // 0x40

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

	// RVA: 0x697E70 Offset: 0x697070 VA: 0x180697E70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x698420 Offset: 0x697620 VA: 0x180698420 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerPhysics.<WalkPlayerTo>d__49 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1476
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool ignoreColliderOffset; // 0x20
	public Vector2 worldPos; // 0x24
	public PlayerPhysics <>4__this; // 0x30
	public float speedMul; // 0x38
	public float tolerance; // 0x3C
	private Rigidbody2D <body>5__2; // 0x40
	private Vector2 <del>5__3; // 0x48

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

	// RVA: 0x6991E0 Offset: 0x6983E0 VA: 0x1806991E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x699490 Offset: 0x698690 VA: 0x180699490 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class PlayerPhysics : InnerNetObject // TypeDefIndex: 1477
{
	// Fields
	public AudioClip ImpostorDiscoveredSound; // 0x38
	public PlayerAnimations Animations; // 0x40
	public SpecialInputHandler inputHandler; // 0x48
	public float Speed; // 0x50
	public float GhostSpeed; // 0x54
	private const float ClimbPositionTolerance = 0,0005;
	private readonly Logger logger; // 0x58
	private Rigidbody2D body; // 0x60
	private PlayerControl myPlayer; // 0x68
	private PlayerBodyTypes bodyType; // 0x70
	private Coroutine petCoroutine; // 0x78
	[CompilerGenerated]
	private bool <DoingCustomAnimation>k__BackingField; // 0x80
	private byte lastClimbLadderSid; // 0x81

	// Properties
	public bool DoingCustomAnimation { get; set; }
	public float TrueSpeed { get; }
	public float SpeedMod { get; }
	private bool FlipX { get; set; }
	public Vector2 Velocity { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_DoingCustomAnimation() { }

	[CompilerGenerated]
	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	private void set_DoingCustomAnimation(bool value) { }

	// RVA: 0x67ABE0 Offset: 0x679DE0 VA: 0x18067ABE0
	public float get_TrueSpeed() { }

	// RVA: 0x67AA40 Offset: 0x679C40 VA: 0x18067AA40
	public float get_SpeedMod() { }

	// RVA: 0x67AA10 Offset: 0x679C10 VA: 0x18067AA10
	private bool get_FlipX() { }

	// RVA: 0x67AD90 Offset: 0x679F90 VA: 0x18067AD90
	private void set_FlipX(bool value) { }

	// RVA: 0x678240 Offset: 0x677440 VA: 0x180678240
	public void Awake() { }

	// RVA: 0x678D90 Offset: 0x677F90 VA: 0x180678D90
	public void EnableInterpolation() { }

	// RVA: 0x67A3E0 Offset: 0x6795E0 VA: 0x18067A3E0
	public void SetBodyType(PlayerBodyTypes bodyType) { }

	// RVA: 0x678EC0 Offset: 0x6780C0 VA: 0x180678EC0
	private void FixedUpdate() { }

	// RVA: 0x679090 Offset: 0x678290 VA: 0x180679090
	public Vector2 GetVelocity() { }

	// RVA: 0x67A4F0 Offset: 0x6796F0 VA: 0x18067A4F0
	public void SetNormalizedVelocity(Vector2 direction) { }

	// RVA: 0x679700 Offset: 0x678900 VA: 0x180679700
	private void LateUpdate() { }

	// RVA: 0x67A850 Offset: 0x679A50 VA: 0x18067A850
	public Vector3 Vec2ToPosition(Vector2 pos) { }

	// RVA: 0x67A540 Offset: 0x679740 VA: 0x18067A540
	public void SetSkin(string skinId, int color) { }

	// RVA: 0x67A600 Offset: 0x679800 VA: 0x18067A600
	public void StartClimb(bool down) { }

	// RVA: 0x678980 Offset: 0x677B80 VA: 0x180678980
	private void ClimbLadder(Ladder source, byte climbLadderSid) { }

	// RVA: 0x679790 Offset: 0x678990 VA: 0x180679790
	private void PetPet(Vector2 pos, Vector2 petPos) { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoClimbLadder>d__34))]
	// RVA: 0x678AF0 Offset: 0x677CF0 VA: 0x180678AF0
	private IEnumerator CoClimbLadder(Ladder source, byte climbLadderSid) { }

	// RVA: 0x679AF0 Offset: 0x678CF0 VA: 0x180679AF0
	public void ResetMoveState(bool stopCoroutines = True) { }

	// RVA: 0x6797C0 Offset: 0x6789C0 VA: 0x1806797C0
	public void ResetAnimState() { }

	// RVA: 0x679090 Offset: 0x678290 VA: 0x180679090
	public Vector2 get_Velocity() { }

	// RVA: 0x6790B0 Offset: 0x6782B0 VA: 0x1806790B0
	private void HandleAnimation(bool amDead) { }

	// RVA: 0x6781B0 Offset: 0x6773B0 VA: 0x1806781B0
	public void AnimateCustom(AnimationClip anim) { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoAnimateCustom>d__41))]
	// RVA: 0x678A70 Offset: 0x677C70 VA: 0x180678A70
	private IEnumerator CoAnimateCustom(AnimationClip anim) { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoSpawnPlayer>d__42))]
	// RVA: 0x678D10 Offset: 0x677F10 VA: 0x180678D10
	public IEnumerator CoSpawnPlayer(LobbyBehaviour lobby) { }

	// RVA: 0x678DC0 Offset: 0x677FC0 VA: 0x180678DC0
	public void ExitAllVents() { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoPet>d__44))]
	// RVA: 0x678C70 Offset: 0x677E70 VA: 0x180678C70
	private IEnumerator CoPet(Vector2 pos, Vector2 petPos) { }

	// RVA: 0x6786E0 Offset: 0x6778E0 VA: 0x1806786E0
	private void CheckCancelPetting() { }

	// RVA: 0x678590 Offset: 0x677790 VA: 0x180678590
	private void CancelPet() { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoEnterVent>d__47))]
	// RVA: 0x678B70 Offset: 0x677D70 VA: 0x180678B70
	private IEnumerator CoEnterVent(int id) { }

	[IteratorStateMachine(typeof(PlayerPhysics.<CoExitVent>d__48))]
	// RVA: 0x678BF0 Offset: 0x677DF0 VA: 0x180678BF0
	private IEnumerator CoExitVent(int id) { }

	[IteratorStateMachine(typeof(PlayerPhysics.<WalkPlayerTo>d__49))]
	// RVA: 0x67A880 Offset: 0x679A80 VA: 0x18067A880
	public IEnumerator WalkPlayerTo(Vector2 worldPos, float tolerance = 0,01, float speedMul = 1, bool ignoreColliderOffset = False) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void ClearOrDecrementDirt() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	public override bool Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public override void Deserialize(MessageReader reader, bool initialState) { }

	// RVA: 0x678370 Offset: 0x677570 VA: 0x180678370
	private void BootFromVent(int ventId) { }

	// RVA: 0x67A000 Offset: 0x679200 VA: 0x18067A000
	public void RpcClimbLadder(Ladder source) { }

	// RVA: 0x67A110 Offset: 0x679310 VA: 0x18067A110
	public void RpcEnterVent(int ventId) { }

	// RVA: 0x67A1F0 Offset: 0x6793F0 VA: 0x18067A1F0
	public void RpcExitVent(int ventId) { }

	// RVA: 0x679E70 Offset: 0x679070 VA: 0x180679E70
	public void RpcBootFromVent(int ventId) { }

	// RVA: 0x67A2D0 Offset: 0x6794D0 VA: 0x18067A2D0
	public void RpcPet(Vector2 pos, Vector2 petPos) { }

	// RVA: 0x679F40 Offset: 0x679140 VA: 0x180679F40
	public void RpcCancelPet() { }

	// RVA: 0x679490 Offset: 0x678690 VA: 0x180679490 Slot: 7
	public override void HandleRpc(byte callId, MessageReader reader) { }

	// RVA: 0x67A930 Offset: 0x679B30 VA: 0x18067A930
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x67A700 Offset: 0x679900 VA: 0x18067A700
	private void <SetSkin>b__30_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PoolablePlayer.<>c // TypeDefIndex: 1478
{
	// Fields
	public static readonly PoolablePlayer.<>c <>9; // 0x0
	public static Action<SpriteRenderer> <>9__64_0; // 0x8

	// Methods

	// RVA: 0x699120 Offset: 0x698320 VA: 0x180699120
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5A0270 Offset: 0x59F470 VA: 0x1805A0270
	internal void <Awake>b__64_0(SpriteRenderer h) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PoolablePlayer.<>c__DisplayClass63_0 // TypeDefIndex: 1479
{
	// Fields
	public PlayerMaterial.MaskType maskType; // 0x10
	public NetworkedPlayerInfo.PlayerOutfit outfit; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698FA0 Offset: 0x6981A0 VA: 0x180698FA0
	internal void <UpdateFromPlayerOutfit>b__0(SpriteRenderer b) { }

	// RVA: 0x699030 Offset: 0x698230 VA: 0x180699030
	internal void <UpdateFromPlayerOutfit>b__1(SpriteRenderer b) { }
}

// Namespace: 
public class PoolablePlayer : MonoBehaviour // TypeDefIndex: 1480
{
	// Fields
	public SpriteRenderer[] Hands; // 0x20
	public SpriteRenderer[] OtherBodySprites; // 0x28
	[SerializeField]
	private CosmeticsLayer cosmetics; // 0x30
	private PlayerBodyTypes bodyType; // 0x38
	[SerializeField]
	private bool ignoreLongMode; // 0x3C

	// Properties
	public CosmeticsLayer Cosmetics { get; }
	public string ColorBlindName { get; }
	public PlayerBodyTypes CurrentBodyType { get; }
	public int ColorId { get; }

	// Methods

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public CosmeticsLayer get_Cosmetics() { }

	// RVA: 0x692CB0 Offset: 0x691EB0 VA: 0x180692CB0
	public string get_ColorBlindName() { }

	// RVA: 0x692CF0 Offset: 0x691EF0 VA: 0x180692CF0
	public PlayerBodyTypes get_CurrentBodyType() { }

	// RVA: 0x692CD0 Offset: 0x691ED0 VA: 0x180692CD0
	public int get_ColorId() { }

	// RVA: 0x691760 Offset: 0x690960 VA: 0x180691760
	public bool GetIgnoreLongMode() { }

	// RVA: 0x691A80 Offset: 0x690C80 VA: 0x180691A80
	public void SetBodyCosmeticsVisible(bool b) { }

	// RVA: 0x692010 Offset: 0x691210 VA: 0x180692010
	public void ToggleHat(bool b) { }

	// RVA: 0x691B40 Offset: 0x690D40 VA: 0x180691B40
	public void SetCustomHatPosition(Vector3 pos) { }

	// RVA: 0x691B80 Offset: 0x690D80 VA: 0x180691B80
	public void SetCustomVisorPosition(Vector3 pos) { }

	// RVA: 0x6917B0 Offset: 0x6909B0 VA: 0x1806917B0
	public bool HasHat() { }

	// RVA: 0x691740 Offset: 0x690940 VA: 0x180691740
	public SpriteRenderer GetHandHat() { }

	// RVA: 0x691920 Offset: 0x690B20 VA: 0x180691920
	private void OnEnable() { }

	// RVA: 0x691860 Offset: 0x690A60 VA: 0x180691860
	private void OnDisable() { }

	// RVA: 0x691AC0 Offset: 0x690CC0 VA: 0x180691AC0
	private void SetColorBlindTag() { }

	// RVA: 0x691A20 Offset: 0x690C20 VA: 0x180691A20
	public void ResetCosmetics(string ignoreType = "") { }

	// RVA: 0x691770 Offset: 0x690970 VA: 0x180691770
	public SpriteAnim GetSkinSpriteAnim() { }

	// RVA: 0x691CA0 Offset: 0x690EA0 VA: 0x180691CA0
	public void SetMaskLayer(int layer) { }

	// RVA: 0x691C20 Offset: 0x690E20 VA: 0x180691C20
	public void SetHatLeftFacingVictim(bool leftFacingVictim) { }

	// RVA: 0x691720 Offset: 0x690920 VA: 0x180691720
	public void SetHatOnFloor() { }

	// RVA: 0x691FB0 Offset: 0x6911B0 VA: 0x180691FB0
	public void SetVisorOnFloor() { }

	// RVA: 0x691720 Offset: 0x690920 VA: 0x180691720
	public void FlipHatAndVisor() { }

	// RVA: 0x691C00 Offset: 0x690E00 VA: 0x180691C00
	public void SetHatAndVisorMaskType(PlayerMaterial.MaskType type) { }

	// RVA: 0x691FD0 Offset: 0x6911D0 VA: 0x180691FD0
	public void SetVisor(string visorId, int color) { }

	// RVA: 0x691FF0 Offset: 0x6911F0 VA: 0x180691FF0
	public void SetVisor(VisorData visorData, int color) { }

	// RVA: 0x691C40 Offset: 0x690E40 VA: 0x180691C40
	public void SetHatWithoutChangingColor(HatData hatData) { }

	// RVA: 0x691C60 Offset: 0x690E60 VA: 0x180691C60
	public void SetHat(string hatId, int color) { }

	// RVA: 0x691C80 Offset: 0x690E80 VA: 0x180691C80
	public void SetHat(HatData hatData, int color) { }

	// RVA: 0x691D30 Offset: 0x690F30 VA: 0x180691D30
	public void SetNameScale(Vector3 scale) { }

	// RVA: 0x691D90 Offset: 0x690F90 VA: 0x180691D90
	public void SetName(string nameStr, Vector3 scale, Color color, float zPosition) { }

	// RVA: 0x691D70 Offset: 0x690F70 VA: 0x180691D70
	public void SetName(string nameStr) { }

	// RVA: 0x691CC0 Offset: 0x690EC0 VA: 0x180691CC0
	public void SetNameColor(Color color) { }

	// RVA: 0x691CF0 Offset: 0x690EF0 VA: 0x180691CF0
	public void SetNamePosition(Vector3 newPos) { }

	// RVA: 0x691A40 Offset: 0x690C40 VA: 0x180691A40
	public void SetBodyAsGhost() { }

	// RVA: 0x691A60 Offset: 0x690C60 VA: 0x180691A60
	public void SetBodyColor(int color) { }

	// RVA: 0x691700 Offset: 0x690900 VA: 0x180691700
	public void FixSkinSprite(Sprite skinSprite) { }

	// RVA: 0x691F80 Offset: 0x691180 VA: 0x180691F80
	public void SetSkin(string skinId, int color) { }

	// RVA: 0x691F50 Offset: 0x691150 VA: 0x180691F50
	public void SetSkin(SkinData skin, int color) { }

	// RVA: 0x6919E0 Offset: 0x690BE0 VA: 0x1806919E0
	public void ReplacePetParent(Transform newParent, Vector3 newPosition) { }

	// RVA: 0x692030 Offset: 0x691230 VA: 0x180692030
	public void ToggleName(bool active) { }

	// RVA: 0x692050 Offset: 0x691250 VA: 0x180692050
	public void TogglePet(bool active) { }

	// RVA: 0x691DF0 Offset: 0x690FF0 VA: 0x180691DF0
	public void SetPetColor(int color) { }

	// RVA: 0x691E70 Offset: 0x691070 VA: 0x180691E70
	public void SetPetIdle(string petId, int colorId) { }

	// RVA: 0x691E40 Offset: 0x691040 VA: 0x180691E40
	public void SetPetIdle(PetData petData, int colorId) { }

	// RVA: 0x691F00 Offset: 0x691100 VA: 0x180691F00
	public void SetPetIdle(PetBehaviour petBehaviour, int colorId) { }

	// RVA: 0x691F30 Offset: 0x691130 VA: 0x180691F30
	public void SetPetScared(PetBehaviour petBehaviour, int colorId) { }

	// RVA: 0x691BE0 Offset: 0x690DE0 VA: 0x180691BE0
	public void SetFlipX(bool flipped) { }

	// RVA: 0x691BC0 Offset: 0x690DC0 VA: 0x180691BC0
	public void SetDeadFlipX(bool flipped) { }

	// RVA: 0x691E20 Offset: 0x691020 VA: 0x180691E20
	public void SetPetFlipX(bool flipped) { }

	// RVA: 0x691AA0 Offset: 0x690CA0 VA: 0x180691AA0
	public void SetBodyType(PlayerBodyTypes bodyType) { }

	// RVA: 0x692740 Offset: 0x691940 VA: 0x180692740
	public void UpdateFromLocalPlayer(PlayerMaterial.MaskType maskType) { }

	// RVA: 0x692070 Offset: 0x691270 VA: 0x180692070
	public void UpdateFromDataManager(PlayerMaterial.MaskType maskType) { }

	// RVA: 0x6923D0 Offset: 0x6915D0 VA: 0x1806923D0
	public void UpdateFromDataManager(PlayerMaterial.MaskType maskType, int colorId) { }

	// RVA: 0x692690 Offset: 0x691890 VA: 0x180692690
	public void UpdateFromEitherPlayerDataOrCache(NetworkedPlayerInfo pData, PlayerOutfitType outfitType, PlayerMaterial.MaskType maskType, bool includePet, Action OnSkinLoaded) { }

	// RVA: 0x692820 Offset: 0x691A20 VA: 0x180692820
	public void UpdateFromPlayerData(NetworkedPlayerInfo pData, PlayerOutfitType outfitType, PlayerMaterial.MaskType maskType, bool includePet, Action OnSkinLoaded, bool forceAlive = False) { }

	// RVA: 0x6928D0 Offset: 0x691AD0 VA: 0x1806928D0
	public void UpdateFromPlayerOutfit(NetworkedPlayerInfo.PlayerOutfit outfit, PlayerMaterial.MaskType maskType, bool isDead, bool includePet, Action OnSkinLoaded, bool forceAlive = False) { }

	// RVA: 0x691550 Offset: 0x690750 VA: 0x180691550
	private void Awake() { }

	// RVA: 0x691800 Offset: 0x690A00 VA: 0x180691800
	private void InitBody() { }

	// RVA: 0x6917D0 Offset: 0x6909D0 VA: 0x1806917D0
	public void HideHatAndVisor_AnimEvent() { }

	// RVA: 0x6916E0 Offset: 0x6908E0 VA: 0x1806916E0
	public void FadeBlackAll(float duration) { }

	// RVA: 0x691790 Offset: 0x690990 VA: 0x180691790
	public SkinViewData GetSkinView() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[DefaultMember("Item")]
public class RingBuffer<T> // TypeDefIndex: 1481
{
	// Fields
	private readonly T[] Data; // 0x0
	private int startIdx; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }
	public int Capacity { get; }
	public T Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE8CF0 Offset: 0xBE7EF0 VA: 0x180BE8CF0
	|-RingBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE8EF0 Offset: 0xBE80F0 VA: 0x180BE8EF0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE6030 Offset: 0xBE5230 VA: 0x180BE6030
	|-RingBuffer<__Il2CppFullySharedGenericType>.First
	*/

	// RVA: -1 Offset: -1
	public T Last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE64B0 Offset: 0xBE56B0 VA: 0x180BE64B0
	|-RingBuffer<__Il2CppFullySharedGenericType>.Last
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE5130 Offset: 0xBE4330 VA: 0x180BE5130
	|-RingBuffer<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE77C0 Offset: 0xBE69C0 VA: 0x180BE77C0
	|-RingBuffer<__Il2CppFullySharedGenericType>.RemoveFirst
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE52E0 Offset: 0xBE44E0 VA: 0x180BE52E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.Clear
	*/
}

// Namespace: 
public class ActionMapGlyphDisplay : MonoBehaviour // TypeDefIndex: 1482
{
	// Fields
	public RewiredConstsEnum.Action actionToDisplayMappedGlyphFor; // 0x20
	private SpriteRenderer spriteRenderer; // 0x28
	private Image uiImage; // 0x30

	// Methods

	// RVA: 0x67F8C0 Offset: 0x67EAC0 VA: 0x18067F8C0
	private void Awake() { }

	// RVA: 0x67FA20 Offset: 0x67EC20 VA: 0x18067FA20
	private void OnDestroy() { }

	// RVA: 0x67FCF0 Offset: 0x67EEF0 VA: 0x18067FCF0
	public void UpdateGlyphDisplay() { }

	// RVA: 0x67FB40 Offset: 0x67ED40 VA: 0x18067FB40
	public void SetColor(Color color) { }

	// RVA: 0x67FC20 Offset: 0x67EE20 VA: 0x18067FC20
	public void SetSpriteVisibility(bool visible) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum ActiveInputManager.InputType // TypeDefIndex: 1483
{
	// Fields
	public int value__; // 0x0
	public const ActiveInputManager.InputType Joystick = 0;
	public const ActiveInputManager.InputType Keyboard = 1;
	public const ActiveInputManager.InputType Touch = 2;
}

// Namespace: 
public class ActiveInputManager : DestroyableSingleton<ActiveInputManager> // TypeDefIndex: 1484
{
	// Fields
	public ActiveInputManager.InputType testCurrentControlType; // 0x28
	public static ActiveInputManager.InputType currentControlType; // 0x0
	public double kChangeTime; // 0x30
	public double mChangeTime; // 0x38
	public double jChangeTime; // 0x40
	public double tChangeTime; // 0x48
	private Vector2 lastMousePosition; // 0x50
	public static Action CurrentInputSourceChanged; // 0x8
	private Controller lastUsedController; // 0x58

	// Properties
	private static ActiveInputManager.InputType PlatformDefault { get; }
	public Controller CurrentController { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	private static ActiveInputManager.InputType get_PlatformDefault() { }

	// RVA: 0x6802D0 Offset: 0x67F4D0 VA: 0x1806802D0
	private void Start() { }

	// RVA: 0x680A70 Offset: 0x67FC70 VA: 0x180680A70
	private void Update() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Controller get_CurrentController() { }

	// RVA: 0x680010 Offset: 0x67F210 VA: 0x180680010
	private void OnLastActiveControllerChanged(Player player, Controller controller) { }

	// RVA: 0x6803A0 Offset: 0x67F5A0 VA: 0x1806803A0
	public void UpdateActiveControlType() { }

	// RVA: 0x6802B0 Offset: 0x67F4B0 VA: 0x1806802B0
	private bool ShouldEnableTouch() { }

	// RVA: 0x680AC0 Offset: 0x67FCC0 VA: 0x180680AC0
	public void .ctor() { }

	// RVA: 0x680A80 Offset: 0x67FC80 VA: 0x180680A80
	private static void .cctor() { }
}

// Namespace: 
public class BuildDefineConditionalObject : MonoBehaviour // TypeDefIndex: 1485
{
	// Fields
	public bool isDefined; // 0x20

	// Methods

	// RVA: 0x680B20 Offset: 0x67FD20 VA: 0x180680B20
	private void Awake() { }

	// RVA: 0x680B50 Offset: 0x67FD50 VA: 0x180680B50
	private void OnEnable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CloseButtonConsoleBehaviour : MonoBehaviour // TypeDefIndex: 1486
{
	// Fields
	public bool keepActiveOnConsoles; // 0x20

	// Methods

	// RVA: 0x680D90 Offset: 0x67FF90 VA: 0x180680D90
	private void Start() { }

	// RVA: 0x680D40 Offset: 0x67FF40 VA: 0x180680D40
	private void SetActive(bool active) { }

	// RVA: 0x680B90 Offset: 0x67FD90 VA: 0x180680B90
	private void OnDestroy() { }

	// RVA: 0x680CB0 Offset: 0x67FEB0 VA: 0x180680CB0
	private void OnInputMethodChanged() { }

	// RVA: 0x680F30 Offset: 0x680130 VA: 0x180680F30
	public void TryActivate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct ConditionalMove.MoveForPlatforms // TypeDefIndex: 1487
{
	// Fields
	public RuntimePlatform runtimePlatform; // 0x0
	public Vector3 offset; // 0x4
}

// Namespace: 
public class ConditionalMove : MonoBehaviour // TypeDefIndex: 1488
{
	// Fields
	public ConditionalMove.MoveForPlatforms[] moveForPlatforms; // 0x20

	// Methods

	// RVA: 0x681000 Offset: 0x680200 VA: 0x180681000
	private void Awake() { }

	// RVA: 0x681140 Offset: 0x680340 VA: 0x180681140
	public void .ctor() { }
}

// Namespace: 
public enum PEW.Hardware.HardwareType // TypeDefIndex: 1489
{
	// Fields
	public int value__; // 0x0
	public const PEW.Hardware.HardwareType PC = 0;
	public const PEW.Hardware.HardwareType Switch = 1;
	public const PEW.Hardware.HardwareType XboxOne = 2;
	public const PEW.Hardware.HardwareType XboxScarlett = 3;
	public const PEW.Hardware.HardwareType PS4 = 4;
	public const PEW.Hardware.HardwareType PS5 = 5;
	public const PEW.Hardware.HardwareType Stadia = 6;
	public const PEW.Hardware.HardwareType Unknown = 7;
}

// Namespace: 
public static class PEW.Hardware // TypeDefIndex: 1490
{
	// Fields
	private static PEW.Hardware.HardwareType type; // 0x0
	private static int tier; // 0x4

	// Properties
	public static PEW.Hardware.HardwareType hardwareType { get; set; }
	public static int hardwareTier { get; set; }

	// Methods

	// RVA: 0x68EFA0 Offset: 0x68E1A0 VA: 0x18068EFA0
	public static PEW.Hardware.HardwareType get_hardwareType() { }

	// RVA: 0x68F050 Offset: 0x68E250 VA: 0x18068F050
	private static void set_hardwareType(PEW.Hardware.HardwareType value) { }

	// RVA: 0x68EF50 Offset: 0x68E150 VA: 0x18068EF50
	public static int get_hardwareTier() { }

	// RVA: 0x68EFF0 Offset: 0x68E1F0 VA: 0x18068EFF0
	private static void set_hardwareTier(int value) { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0
	private static PEW.Hardware.HardwareType GetHardwareType() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0
	private static int GetHardwareTier() { }

	// RVA: 0x68EF00 Offset: 0x68E100 VA: 0x18068EF00
	private static void .cctor() { }
}

// Namespace: 
[Obsolete("
Don't reference this class directly, create a class that derives from it! Unity won't properly serialize classes with generics.

public class ConditionalWhatever : ConditionalValue<Whatever> { }; 

(Ignore if you're already doing that)")]
public class PEW.ConditionalValue<T> // TypeDefIndex: 1491
{
	// Fields
	public T PC; // 0x0
	public T Switch; // 0x0
	public T XboxOne; // 0x0
	public T XboxOneX; // 0x0
	public T PS4; // 0x0
	public T PS4Pro; // 0x0
	public T PS5; // 0x0
	public T Stadia; // 0x0
	public T Misc; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public T Select() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-PEW.ConditionalValue<bool>.Select
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-PEW.ConditionalValue<int>.Select
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-PEW.ConditionalValue<object>.Select
	|
	|-RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	|-PEW.ConditionalValue<float>.Select
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-PEW.ConditionalValue<__Il2CppFullySharedGenericType>.Select
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(PEW.ConditionalValue<T> input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5CE0 Offset: 0xFB4EE0 VA: 0x180FB5CE0
	|-PEW.ConditionalValue<bool>.op_Implicit
	|
	|-RVA: 0xFB5C80 Offset: 0xFB4E80 VA: 0x180FB5C80
	|-PEW.ConditionalValue<int>.op_Implicit
	|
	|-RVA: 0xFB5CB0 Offset: 0xFB4EB0 VA: 0x180FB5CB0
	|-PEW.ConditionalValue<object>.op_Implicit
	|
	|-RVA: 0xFB5D10 Offset: 0xFB4F10 VA: 0x180FB5D10
	|-PEW.ConditionalValue<float>.op_Implicit
	|
	|-RVA: 0xFB5D50 Offset: 0xFB4F50 VA: 0x180FB5D50
	|-PEW.ConditionalValue<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static PEW.ConditionalValue<T> op_Implicit(T input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5440 Offset: 0xFB4640 VA: 0x180FB5440
	|-PEW.ConditionalValue<bool>.op_Implicit
	|
	|-RVA: 0xFB5BD0 Offset: 0xFB4DD0 VA: 0x180FB5BD0
	|-PEW.ConditionalValue<int>.op_Implicit
	|
	|-RVA: 0xFB54F0 Offset: 0xFB46F0 VA: 0x180FB54F0
	|-PEW.ConditionalValue<object>.op_Implicit
	|
	|-RVA: 0xFB53A0 Offset: 0xFB45A0 VA: 0x180FB53A0
	|-PEW.ConditionalValue<float>.op_Implicit
	|
	|-RVA: 0xFB55A0 Offset: 0xFB47A0 VA: 0x180FB55A0
	|-PEW.ConditionalValue<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-PEW.ConditionalValue<bool>..ctor
	|-PEW.ConditionalValue<int>..ctor
	|-PEW.ConditionalValue<object>..ctor
	|-PEW.ConditionalValue<float>..ctor
	|-PEW.ConditionalValue<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public static class PEW // TypeDefIndex: 1492
{}

// Namespace: 
[Serializable]
public class ConditionalInt : PEW.ConditionalValue<int> // TypeDefIndex: 1493
{
	// Methods

	// RVA: 0x680FC0 Offset: 0x6801C0 VA: 0x180680FC0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConditionalFloat : PEW.ConditionalValue<float> // TypeDefIndex: 1494
{
	// Methods

	// RVA: 0x680F80 Offset: 0x680180 VA: 0x180680F80
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConditionalBool : PEW.ConditionalValue<bool> // TypeDefIndex: 1495
{
	// Methods

	// RVA: 0x680F40 Offset: 0x680140 VA: 0x180680F40
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConditionalRenderTexture : PEW.ConditionalValue<RenderTexture> // TypeDefIndex: 1496
{
	// Methods

	// RVA: 0x681190 Offset: 0x680390 VA: 0x180681190
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(SpriteRenderer))]
public class ConditionalSpriteSetter : MonoBehaviour // TypeDefIndex: 1497
{
	// Fields
	public bool ignoreIfNoSpriteForPlatform; // 0x20
	public ConditionalSprite sprite; // 0x28

	// Methods

	// RVA: 0x6811D0 Offset: 0x6803D0 VA: 0x1806811D0
	private void Start() { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConditionalSprite : PEW.ConditionalValue<Sprite> // TypeDefIndex: 1498
{
	// Methods

	// RVA: 0x6812F0 Offset: 0x6804F0 VA: 0x1806812F0
	public void .ctor() { }
}

// Namespace: 
public enum ConsoleJoystick.ConsoleInputState // TypeDefIndex: 1499
{
	// Fields
	public int value__; // 0x0
	public const ConsoleJoystick.ConsoleInputState Gameplay = 0;
	public const ConsoleJoystick.ConsoleInputState Menu = 1;
	public const ConsoleJoystick.ConsoleInputState Task = 2;
	public const ConsoleJoystick.ConsoleInputState Sabotage = 3;
	public const ConsoleJoystick.ConsoleInputState Vent = 4;
	public const ConsoleJoystick.ConsoleInputState QuickChat = 5;
	public const ConsoleJoystick.ConsoleInputState None = 6;
}

// Namespace: 
public class ConsoleJoystick : MonoBehaviour, IVirtualJoystick // TypeDefIndex: 1500
{
	// Fields
	private Vector2 delta; // 0x20
	private Vector2 deltaR; // 0x28
	private static Player player; // 0x0
	private static Controller controller; // 0x8
	private static Controller prevController; // 0x10
	public static ConsoleJoystick.ConsoleInputState inputState; // 0x18
	private static ConsoleJoystick.ConsoleInputState oldInputState; // 0x1C
	private static int highlightedVentIndex; // 0x20

	// Properties
	public Vector2 DeltaL { get; }
	public Vector2 DeltaR { get; }

	// Methods

	// RVA: 0x5A6760 Offset: 0x5A5960 VA: 0x1805A6760 Slot: 4
	public Vector2 get_DeltaL() { }

	// RVA: 0x5B65C0 Offset: 0x5B57C0 VA: 0x1805B65C0 Slot: 5
	public Vector2 get_DeltaR() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void ToggleVisuals(bool on) { }

	// RVA: 0x682AA0 Offset: 0x681CA0 VA: 0x180682AA0
	private void OnEnable() { }

	// RVA: 0x6829B0 Offset: 0x681BB0 VA: 0x1806829B0
	private void OnDisable() { }

	// RVA: 0x682DA0 Offset: 0x681FA0 VA: 0x180682DA0
	public static void ReapplyCurrentInputState() { }

	// RVA: 0x6833C0 Offset: 0x6825C0 VA: 0x1806833C0
	public static void SetMode_MenuAdditive() { }

	// RVA: 0x683000 Offset: 0x682200 VA: 0x180683000
	public static void SetMode_Gameplay() { }

	// RVA: 0x683660 Offset: 0x682860 VA: 0x180683660
	public static void SetMode_Menu() { }

	// RVA: 0x684570 Offset: 0x683770 VA: 0x180684570
	public static void SetMode_Task() { }

	// RVA: 0x684160 Offset: 0x683360 VA: 0x180684160
	public static void SetMode_Sabotage() { }

	// RVA: 0x684900 Offset: 0x683B00 VA: 0x180684900
	public static void SetMode_Vent() { }

	// RVA: 0x683DD0 Offset: 0x682FD0 VA: 0x180683DD0
	public static void SetMode_QuickChat() { }

	// RVA: 0x683AE0 Offset: 0x682CE0 VA: 0x180683AE0
	public static void SetMode_None() { }

	// RVA: 0x682F30 Offset: 0x682130 VA: 0x180682F30
	private static void SetMapEnabled(int rewiredCategoryIndex, bool enableMap) { }

	// RVA: 0x684CC0 Offset: 0x683EC0 VA: 0x180684CC0
	private void Update() { }

	// RVA: 0x681330 Offset: 0x680530 VA: 0x180681330
	private void HandleHUD() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x6852F0 Offset: 0x6844F0 VA: 0x1806852F0
	private static void .cctor() { }
}

// Namespace: 
public class ControllerButtonBehavior : MonoBehaviour // TypeDefIndex: 1501
{
	// Fields
	public RewiredConstsEnum.Action Action; // 0x20
	public GameObject requiredMenuObject; // 0x28
	public List<string> requiredMenuNames; // 0x30
	public List<string> restrictedMenuNames; // 0x38
	public UiElement requiredSelectedObject; // 0x40
	private Player player; // 0x48
	[CompilerGenerated]
	private Action OnPressedEvent; // 0x50

	// Methods

	[CompilerGenerated]
	// RVA: 0x685790 Offset: 0x684990 VA: 0x180685790
	public void add_OnPressedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x685830 Offset: 0x684A30 VA: 0x180685830
	public void remove_OnPressedEvent(Action value) { }

	// RVA: 0x685360 Offset: 0x684560 VA: 0x180685360
	private void Start() { }

	// RVA: 0x685480 Offset: 0x684680 VA: 0x180685480
	private void Update() { }

	// RVA: 0x685700 Offset: 0x684900 VA: 0x180685700
	public void .ctor() { }
}

// Namespace: 
public enum ControllerButtonBehaviourComplex.ActionTriggerType // TypeDefIndex: 1502
{
	// Fields
	public int value__; // 0x0
	public const ControllerButtonBehaviourComplex.ActionTriggerType Any = 0;
	public const ControllerButtonBehaviourComplex.ActionTriggerType All = 1;
}

// Namespace: 
public enum ControllerButtonBehaviourComplex.ActionTrigger.ActionType // TypeDefIndex: 1503
{
	// Fields
	public int value__; // 0x0
	public const ControllerButtonBehaviourComplex.ActionTrigger.ActionType Axis_GEqual = 0;
	public const ControllerButtonBehaviourComplex.ActionTrigger.ActionType Axis_LEqual = 1;
	public const ControllerButtonBehaviourComplex.ActionTrigger.ActionType Button_Down = 2;
}

// Namespace: 
[Serializable]
public struct ControllerButtonBehaviourComplex.ActionTrigger // TypeDefIndex: 1504
{
	// Fields
	public RewiredConstsEnum.Action action; // 0x0
	public ControllerButtonBehaviourComplex.ActionTrigger.ActionType actionType; // 0x4
	public float axisComparisonValue; // 0x8

	// Methods

	// RVA: 0x67FF80 Offset: 0x67F180 VA: 0x18067FF80
	public bool ConditionMet(Player player) { }
}

// Namespace: 
public class ControllerButtonBehaviourComplex : MonoBehaviour // TypeDefIndex: 1505
{
	// Fields
	public ControllerButtonBehaviourComplex.ActionTriggerType actionTriggerType; // 0x20
	public ControllerButtonBehaviourComplex.ActionTrigger[] actionTriggers; // 0x28
	public GameObject requiredMenuObject; // 0x30
	private Player player; // 0x38

	// Methods

	// RVA: 0x685A80 Offset: 0x684C80 VA: 0x180685A80
	private void Start() { }

	// RVA: 0x6858D0 Offset: 0x684AD0 VA: 0x1806858D0
	private bool ConditionMet() { }

	// RVA: 0x685AF0 Offset: 0x684CF0 VA: 0x180685AF0
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ControllerDisconnectHandler : MonoBehaviour // TypeDefIndex: 1506
{
	// Fields
	private bool isConnected; // 0x20
	public GameObject ContinueBackground; // 0x28
	public GameObject ContinueText; // 0x30
	public GameObject obj; // 0x38
	[Header("Console Controller Navigation")]
	public UiElement ContinueButton; // 0x40

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x685C70 Offset: 0x684E70 VA: 0x180685C70
	public void Close() { }

	// RVA: 0x685DE0 Offset: 0x684FE0 VA: 0x180685DE0
	private void OnDisable() { }

	// RVA: 0x685E50 Offset: 0x685050 VA: 0x180685E50
	private void OnStateChange(uint index, bool newIsConnected) { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: 
public class ControllerHeldButtonBehaviour : MonoBehaviour // TypeDefIndex: 1507
{
	// Fields
	public RewiredConstsEnum.Action Action; // 0x20
	public SpriteRenderer targetCooldownSprite; // 0x28
	public float holdDuration; // 0x30
	public ActionButton TargetActionButton; // 0x38
	private Player player; // 0x40
	private ButtonBehavior buttonBehavior; // 0x48
	private PassiveButton passiveButton; // 0x50
	private float holdTimer; // 0x58
	private bool alreadyPressed; // 0x5C

	// Methods

	// RVA: 0x686060 Offset: 0x685260 VA: 0x180686060
	private void Start() { }

	// RVA: 0x686110 Offset: 0x685310 VA: 0x180686110
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ControllerUiElementsState // TypeDefIndex: 1508
{
	// Fields
	public string MenuName; // 0x10
	public UiElement CurrentSelection; // 0x18
	public List<UiElement> SelectableUiElements; // 0x20
	public UiElement BackButton; // 0x28
	public bool EnforceGridNavigation; // 0x30
	public float zPos; // 0x34
	public bool IsScene; // 0x38

	// Methods

	// RVA: 0x68C4A0 Offset: 0x68B6A0 VA: 0x18068C4A0
	public void Reset() { }

	// RVA: 0x68C540 Offset: 0x68B740 VA: 0x18068C540
	public void .ctor() { }
}

// Namespace: 
public class SelectableUiElementCalculation // TypeDefIndex: 1509
{
	// Fields
	public float Angle; // 0x10
	public float Distance; // 0x14

	// Methods

	// RVA: 0x695D30 Offset: 0x694F30 VA: 0x180695D30
	public void .ctor() { }
}

// Namespace: 
public enum AxisDirection // TypeDefIndex: 1510
{
	// Fields
	public int value__; // 0x0
	public const AxisDirection None = 0;
	public const AxisDirection Up = 1;
	public const AxisDirection Down = 2;
	public const AxisDirection Left = 3;
	public const AxisDirection Right = 4;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ControllerManager.<>c // TypeDefIndex: 1511
{
	// Fields
	public static readonly ControllerManager.<>c <>9; // 0x0
	public static Predicate<UiElement> <>9__41_0; // 0x8
	public static Predicate<UiElement> <>9__42_0; // 0x10

	// Methods

	// RVA: 0x6990C0 Offset: 0x6982C0 VA: 0x1806990C0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698E60 Offset: 0x698060 VA: 0x180698E60
	internal bool <ClearDestroyedSelectableUiElements>b__41_0(UiElement item) { }

	// RVA: 0x698EB0 Offset: 0x6980B0 VA: 0x180698EB0
	internal bool <ClearDestroyedSelectableUiElements>b__42_0(UiElement item) { }
}

// Namespace: 
[DefaultExecutionOrder(-10)]
public class ControllerManager : MonoBehaviour // TypeDefIndex: 1512
{
	// Fields
	public static ControllerManager Instance; // 0x0
	[HideInInspector]
	[SerializeField]
	private int playerId; // 0x20
	[SerializeField]
	private Player player; // 0x28
	private const string DISCONNECT_POPUP_MENUNAME = "DisconnectPopup_Real";
	private const float DELTA_SINCE_LAST_BUTTON_HIGHLIGHT_THRESHOLD = 0,25;
	private const float DELTA_SINCE_LAST_SLIDER_MOVEMENT_THRESHOLD = 0,1;
	private bool inputDetectedLastFrame; // 0x30
	[SerializeField]
	private GameObject PrefabMouseCursorForConsole; // 0x38
	private GameObject ConsoleMouse; // 0x40
	[HideInInspector]
	public bool IsButtonHeld; // 0x48
	public ControllerUiElementsState CurrentUiState; // 0x50
	public List<ControllerUiElementsState> CurrentUiStateStack; // 0x58
	private float deltaSinceLastUiHighlight; // 0x60
	private bool disabledVirtualCursor; // 0x64
	private int frameDelaySinceInputChanged; // 0x68
	private Dictionary<Vector2, AxisDirection> directions; // 0x70
	private readonly Logger logger; // 0x78
	private string currentScene; // 0x80

	// Properties
	public bool IsUiControllerActive { get; }

	// Methods

	// RVA: 0x68BD60 Offset: 0x68AF60 VA: 0x18068BD60
	public bool get_IsUiControllerActive() { }

	// RVA: 0x6866C0 Offset: 0x6858C0 VA: 0x1806866C0
	private void Awake() { }

	// RVA: 0x68AA60 Offset: 0x689C60 VA: 0x18068AA60
	private void SceneManager_activeSceneChanged(Scene from, Scene to) { }

	// RVA: 0x68AA90 Offset: 0x689C90 VA: 0x18068AA90
	private void SceneManager_sceneUnloaded(Scene scene) { }

	// RVA: 0x68AD70 Offset: 0x689F70 VA: 0x18068AD70
	private void Start() { }

	// RVA: 0x688C60 Offset: 0x687E60 VA: 0x180688C60
	public bool IsMenuActiveAtAll(string menuName) { }

	// RVA: 0x689120 Offset: 0x688320 VA: 0x180689120
	private void OnInputTypeChanged() { }

	// RVA: 0x688DD0 Offset: 0x687FD0 VA: 0x180688DD0
	public void NewScene(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = False) { }

	// RVA: 0x689490 Offset: 0x688690 VA: 0x180689490
	public void OpenOverlayMenu(string menuName, UiElement backButton) { }

	// RVA: 0x6893E0 Offset: 0x6885E0 VA: 0x1806893E0
	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection) { }

	// RVA: 0x689530 Offset: 0x688730 VA: 0x180689530
	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = False) { }

	// RVA: 0x6886F0 Offset: 0x6878F0 VA: 0x1806886F0
	public ControllerUiElementsState GetMenu(string menuName) { }

	// RVA: 0x689B80 Offset: 0x688D80 VA: 0x180689B80
	public void OpenSpecificMenu(string menuNameToOpen) { }

	// RVA: 0x689CB0 Offset: 0x688EB0 VA: 0x180689CB0
	private void OpenTopmostMenu() { }

	// RVA: 0x68AC20 Offset: 0x689E20 VA: 0x18068AC20
	public void SetUpSelectables(ControllerUiElementsState state, UiElement defaultSelection, List<UiElement> selectables) { }

	// RVA: 0x68ABB0 Offset: 0x689DB0 VA: 0x18068ABB0
	public void SetDefaultSelection(UiElement defaultSelection, List<UiElement> selectableElements) { }

	// RVA: 0x68AB30 Offset: 0x689D30 VA: 0x18068AB30
	public void SetBackButton(UiElement backButton) { }

	// RVA: 0x68AF30 Offset: 0x68A130 VA: 0x18068AF30
	public void UnsetBackButton(UiElement backButton) { }

	// RVA: 0x686420 Offset: 0x685620 VA: 0x180686420
	public void AddSelectableUiElement(UiElement uiElement, bool forceSelect = False) { }

	// RVA: 0x68A7E0 Offset: 0x6899E0 VA: 0x18068A7E0
	public void RemoveSelectableUiElement(UiElement uiElement) { }

	// RVA: 0x686360 Offset: 0x685560 VA: 0x180686360
	public void AddSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu) { }

	// RVA: 0x68A710 Offset: 0x689910 VA: 0x18068A710
	public void RemoveSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu) { }

	// RVA: 0x686A80 Offset: 0x685C80 VA: 0x180686A80
	public void ClearDestroyedSelectableUiElements() { }

	// RVA: 0x686950 Offset: 0x685B50 VA: 0x180686950
	public void ClearDestroyedSelectableUiElements(ControllerUiElementsState state) { }

	// RVA: 0x686DD0 Offset: 0x685FD0 VA: 0x180686DD0
	public void CloseOverlayMenu(string menuName) { }

	// RVA: 0x686BB0 Offset: 0x685DB0 VA: 0x180686BB0
	public void CloseAndResetAll() { }

	// RVA: 0x68A8C0 Offset: 0x689AC0 VA: 0x18068A8C0
	public void ResetAll() { }

	// RVA: 0x68AFC0 Offset: 0x68A1C0 VA: 0x18068AFC0
	private void Update() { }

	// RVA: 0x687360 Offset: 0x686560 VA: 0x180687360
	private AxisDirection FindClosestDirection(Vector2 direction) { }

	// RVA: 0x686510 Offset: 0x685710 VA: 0x180686510
	private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2, Vector2 direction) { }

	// RVA: 0x6882E0 Offset: 0x6874E0 VA: 0x1806882E0
	private UiElement FindUiElementByRaycast(Vector2 origin, Vector2 direction, float radius) { }

	// RVA: 0x687C10 Offset: 0x686E10 VA: 0x180687C10
	private UiElement FindUiElementByExplicitNavigation(UiElement start, UiElement from, AxisDirection direction) { }

	// RVA: 0x687D60 Offset: 0x686F60 VA: 0x180687D60
	private UiElement FindUiElementByGridDirection(Vector2 origin, AxisDirection direction, float orthogonalOffsetThreshold) { }

	[Obsolete("FindUiElementByDistance is deprecated, please use FindUiElementByGridDirection instead.")]
	// RVA: 0x6874F0 Offset: 0x6866F0 VA: 0x1806874F0
	private UiElement FindUiElementByDistance(Vector2 origin, AxisDirection direction) { }

	// RVA: 0x688BF0 Offset: 0x687DF0 VA: 0x180688BF0
	private void VerticalAxisInputForSlideBar(float v, SlideBar slideBar, bool dpadDetected) { }

	// RVA: 0x688BF0 Offset: 0x687DF0 VA: 0x180688BF0
	private void HorizontalAxisInputForSlideBar(float h, SlideBar slideBar, bool dpadDetected) { }

	// RVA: 0x688810 Offset: 0x687A10 VA: 0x180688810
	private void HighlightSelection(UiElement selection) { }

	// RVA: 0x68ABA0 Offset: 0x689DA0 VA: 0x18068ABA0
	public void SetCurrentSelected(UiElement selection) { }

	// RVA: 0x68A4D0 Offset: 0x6896D0 VA: 0x18068A4D0
	public void PickTopSelectable() { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void PrintSelectableUiList() { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void ClearSelectableUiList() { }

	// RVA: 0x68BB10 Offset: 0x68AD10 VA: 0x18068BB10
	public void .ctor() { }
}

// Namespace: 
public enum ControllerNavigation.Mode // TypeDefIndex: 1513
{
	// Fields
	public int value__; // 0x0
	public const ControllerNavigation.Mode Automatic = 0;
	public const ControllerNavigation.Mode Explicit = 1;
}

// Namespace: 
[Serializable]
public struct ControllerNavigation // TypeDefIndex: 1514
{
	// Fields
	[CompilerGenerated]
	private static readonly ControllerNavigation <defaultNavigation>k__BackingField; // 0x0
	public ControllerNavigation.Mode mode; // 0x0
	public UiElement selectOnUp; // 0x8
	public UiElement selectOnDown; // 0x10
	public UiElement selectOnLeft; // 0x18
	public UiElement selectOnRight; // 0x20

	// Properties
	public static ControllerNavigation defaultNavigation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x68C440 Offset: 0x68B640 VA: 0x18068C440
	public static ControllerNavigation get_defaultNavigation() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerNavMenu.<OpenCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1515
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ControllerNavMenu <>4__this; // 0x20

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

	// RVA: 0x698DA0 Offset: 0x697FA0 VA: 0x180698DA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x698DF0 Offset: 0x697FF0 VA: 0x180698DF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ControllerNavMenu : MonoBehaviour // TypeDefIndex: 1516
{
	// Fields
	public bool openInOnEnable; // 0x20
	public bool gridNavigation; // 0x21
	public bool trySelectAny; // 0x22
	[Header("Console Controller Navigation")]
	public UiElement BackButton; // 0x28
	public UiElement DefaultButtonSelected; // 0x30
	public List<UiElement> ControllerSelectable; // 0x38
	private bool isOpen; // 0x40

	// Methods

	// RVA: 0x68C420 Offset: 0x68B620 VA: 0x18068C420
	private void Start() { }

	// RVA: 0x68BF50 Offset: 0x68B150 VA: 0x18068BF50
	private void OnEnable() { }

	[IteratorStateMachine(typeof(ControllerNavMenu.<OpenCoroutine>d__9))]
	// RVA: 0x68C120 Offset: 0x68B320 VA: 0x18068C120
	private IEnumerator OpenCoroutine() { }

	// RVA: 0x68BEC0 Offset: 0x68B0C0 VA: 0x18068BEC0
	private void OnDisable() { }

	// RVA: 0x68C180 Offset: 0x68B380 VA: 0x18068C180
	public void OpenMenu(bool force = False) { }

	// RVA: 0x68BE30 Offset: 0x68B030 VA: 0x18068BE30
	public void CloseMenu() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class CrossplayChangedEvent : MonoBehaviour // TypeDefIndex: 1517
{
	// Fields
	public bool onlyOnPlayStation; // 0x20
	public UnityEvent OnCrossplayChanged; // 0x28

	// Methods

	// RVA: 0x68C5D0 Offset: 0x68B7D0 VA: 0x18068C5D0
	private void Awake() { }

	// RVA: 0x68C690 Offset: 0x68B890 VA: 0x18068C690
	private void OnDestroy() { }

	// RVA: 0x5CF460 Offset: 0x5CE660 VA: 0x1805CF460
	private void InvokeSelfCrossplayChanged() { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: 
public enum CrossplayConditionalObject.CrossplayConditionalType // TypeDefIndex: 1518
{
	// Fields
	public int value__; // 0x0
	public const CrossplayConditionalObject.CrossplayConditionalType ShowIfCrossplayEnabled = 0;
	public const CrossplayConditionalObject.CrossplayConditionalType HideIfCrossplayEnabled = 1;
}

// Namespace: 
[DefaultExecutionOrder(-10)]
public class CrossplayConditionalObject : MonoBehaviour // TypeDefIndex: 1519
{
	// Fields
	public bool onlyOnPlayStation; // 0x20
	public CrossplayConditionalObject.CrossplayConditionalType crossplayConditionalType; // 0x24
	public static Action OnCrossplayChanged; // 0x0

	// Methods

	// RVA: 0x68C750 Offset: 0x68B950 VA: 0x18068C750
	private void Awake() { }

	// RVA: 0x68C8D0 Offset: 0x68BAD0 VA: 0x18068C8D0
	private void OnDestroy() { }

	// RVA: 0x68C990 Offset: 0x68BB90 VA: 0x18068C990
	private void UpdateEnabledState() { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: 
public class DelayedFunctionCall : MonoBehaviour // TypeDefIndex: 1520
{
	// Fields
	public UnityEvent onTimerElapsed; // 0x20
	public float delayDuration; // 0x28
	private float t; // 0x2C

	// Methods

	// RVA: 0x68CA60 Offset: 0x68BC60 VA: 0x18068CA60
	private void Update() { }

	// RVA: 0x558AA0 Offset: 0x557CA0 VA: 0x180558AA0
	public void .ctor() { }
}

// Namespace: 
public class DisableScriptsForJoystick : MonoBehaviour // TypeDefIndex: 1521
{
	// Fields
	public MonoBehaviour[] scripts; // 0x20

	// Methods

	// RVA: 0x68CCA0 Offset: 0x68BEA0 VA: 0x18068CCA0
	private void Start() { }

	// RVA: 0x68CAC0 Offset: 0x68BCC0 VA: 0x18068CAC0
	private void OnDestroy() { }

	// RVA: 0x68CBE0 Offset: 0x68BDE0 VA: 0x18068CBE0
	private void OnInputMethodChanged() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class DualshockLightManager.LightOverlayHandle // TypeDefIndex: 1522
{
	// Fields
	public Color color; // 0x10
	public float intensity; // 0x20

	// Methods

	// RVA: 0x68F770 Offset: 0x68E970 VA: 0x18068F770
	public void Dispose() { }

	// RVA: 0x68F7E0 Offset: 0x68E9E0 VA: 0x18068F7E0
	public void .ctor() { }
}

// Namespace: 
public class DualshockLightManager.LightOverlayFlash // TypeDefIndex: 1523
{
	// Fields
	public DualshockLightManager.LightOverlayHandle handle; // 0x10
	public AudioClip clip; // 0x18
	public float t; // 0x20
	public float duration; // 0x24
	private static float[] samples; // 0x0

	// Properties
	public bool Alive { get; }

	// Methods

	// RVA: 0x68F460 Offset: 0x68E660 VA: 0x18068F460
	public void Init() { }

	// RVA: 0x68F760 Offset: 0x68E960 VA: 0x18068F760
	public bool get_Alive() { }

	// RVA: 0x68F3D0 Offset: 0x68E5D0 VA: 0x18068F3D0
	public void Dispose() { }

	// RVA: 0x68F4F0 Offset: 0x68E6F0 VA: 0x18068F4F0
	public void Update(float deltaTime) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x68F700 Offset: 0x68E900 VA: 0x18068F700
	private static void .cctor() { }
}

// Namespace: 
public class DualshockLightManager : DestroyableSingleton<DualshockLightManager> // TypeDefIndex: 1524
{
	// Fields
	private const float lightIntensity = 0,5;
	private Color baseColor; // 0x28
	private Color oldColor; // 0x38
	private List<DualshockLightManager.LightOverlayHandle> overlays; // 0x48
	private List<DualshockLightManager.LightOverlayFlash> lightOverlayFlashes; // 0x50

	// Properties
	public Color BaseColor { get; set; }

	// Methods

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Color get_BaseColor() { }

	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_BaseColor(Color value) { }

	// RVA: 0x68CE50 Offset: 0x68C050 VA: 0x18068CE50
	public DualshockLightManager.LightOverlayHandle AllocateLight() { }

	// RVA: 0x68D180 Offset: 0x68C380 VA: 0x18068D180
	private float GetExternalBrightnessFromElectrical() { }

	// RVA: 0x68D380 Offset: 0x68C580 VA: 0x18068D380
	private void Update() { }

	// RVA: 0x68CF20 Offset: 0x68C120 VA: 0x18068CF20
	public static void Flash(Color c, float intensity, AudioClip clip) { }

	// RVA: 0x68DAF0 Offset: 0x68CCF0 VA: 0x18068DAF0
	public void .ctor() { }
}

// Namespace: 
public class EnableVSync : MonoBehaviour // TypeDefIndex: 1525
{
	// Methods

	// RVA: 0x68DBC0 Offset: 0x68CDC0 VA: 0x18068DBC0
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class GlyphCollection.GlyphMap // TypeDefIndex: 1526
{
	// Fields
	public string elementIdentifier; // 0x10
	public string alternateElementIdentifier; // 0x18
	public Sprite glyph; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum GlyphCollection.ErrorCode // TypeDefIndex: 1527
{
	// Fields
	public int value__; // 0x0
	public const GlyphCollection.ErrorCode None = 0;
	public const GlyphCollection.ErrorCode NoController = 1;
	public const GlyphCollection.ErrorCode NoGlyphFound = 2;
	public const GlyphCollection.ErrorCode NoElementsBoundToAction = 3;
}

// Namespace: 
[CreateAssetMenu(menuName = "PEW/GlyphCollection")]
public class GlyphCollection : ScriptableObject // TypeDefIndex: 1528
{
	// Fields
	public string controllerType; // 0x18
	public List<GlyphCollection.GlyphMap> glyphMaps; // 0x20
	public Dictionary<string, GlyphCollection.GlyphMap> glyphDict; // 0x28
	private static List<ActionElementMap> mapResults; // 0x0
	private static GlyphCollection defaultGlyphCollection; // 0x8
	private static Dictionary<string, GlyphCollection> otherGlyphCollections; // 0x10
	private static HashSet<string> controllersWithNoValidGlyphCollection; // 0x18

	// Properties
	private static string GlyphPath { get; }

	// Methods

	// RVA: 0x68E7A0 Offset: 0x68D9A0 VA: 0x18068E7A0
	public void Initialize() { }

	// RVA: 0x68EB10 Offset: 0x68DD10 VA: 0x18068EB10
	private static string get_GlyphPath() { }

	// RVA: 0x68DBD0 Offset: 0x68CDD0 VA: 0x18068DBD0
	public static Sprite FindGlyph(int actionName, out GlyphCollection.ErrorCode error) { }

	// RVA: 0x68EAA0 Offset: 0x68DCA0 VA: 0x18068EAA0
	public void .ctor() { }

	// RVA: 0x68E9A0 Offset: 0x68DBA0 VA: 0x18068E9A0
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class GlyphControllerMapCollection.GlyphControllerMap // TypeDefIndex: 1529
{
	// Fields
	public string controllerName; // 0x10
	public string glyphCollectionPath; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "PEW/GlyphControllerMapCollection")]
public class GlyphControllerMapCollection : ScriptableObject // TypeDefIndex: 1530
{
	// Fields
	public List<GlyphControllerMapCollection.GlyphControllerMap> nameToGlyphCollectionList; // 0x18
	private Dictionary<string, string> nameToGlyphCollectionDict; // 0x20
	private static GlyphControllerMapCollection _instance; // 0x0

	// Properties
	public static GlyphControllerMapCollection Instance { get; }

	// Methods

	// RVA: 0x68EB40 Offset: 0x68DD40 VA: 0x18068EB40
	public void Initialize() { }

	// RVA: 0x68EE00 Offset: 0x68E000 VA: 0x18068EE00
	public static GlyphControllerMapCollection get_Instance() { }

	// RVA: 0x68ECB0 Offset: 0x68DEB0 VA: 0x18068ECB0
	public GlyphCollection TryGetGlyphCollectionForController(string controllerName) { }

	// RVA: 0x68ED90 Offset: 0x68DF90 VA: 0x18068ED90
	public void .ctor() { }
}

// Namespace: 
public static class JoyconColorFunc // TypeDefIndex: 1531
{
	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static byte GetColorFromJoycons() { }
}

// Namespace: 
public class JoystickOnlyObject : MonoBehaviour // TypeDefIndex: 1532
{
	// Methods

	// RVA: 0x68F0B0 Offset: 0x68E2B0 VA: 0x18068F0B0
	private void Awake() { }

	// RVA: 0x68F230 Offset: 0x68E430 VA: 0x18068F230
	private void OnDestroy() { }

	// RVA: 0x68F350 Offset: 0x68E550 VA: 0x18068F350
	private void UpdateState() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(Scroller))]
public class ManualScrollHelper : MonoBehaviour // TypeDefIndex: 1533
{
	// Fields
	public bool doVertical; // 0x20
	public RewiredConstsEnum.Action verticalAxis; // 0x24
	public bool doHorizontal; // 0x28
	public RewiredConstsEnum.Action horizontalAxis; // 0x2C
	public float scrollSpeed; // 0x30
	private ScrollToSelection scrollToSelection; // 0x38
	private Scroller scroller; // 0x40

	// Methods

	// RVA: 0x68F930 Offset: 0x68EB30 VA: 0x18068F930
	private void Start() { }

	// RVA: 0x68FA20 Offset: 0x68EC20 VA: 0x18068FA20
	private void Update() { }

	// RVA: 0x68F7F0 Offset: 0x68E9F0 VA: 0x18068F7F0
	private void OnDisable() { }

	// RVA: 0x68F890 Offset: 0x68EA90 VA: 0x18068F890
	private void OnEnable() { }

	// RVA: 0x68FBC0 Offset: 0x68EDC0 VA: 0x18068FBC0
	public void .ctor() { }
}

// Namespace: 
public class MouseCursorForConsole : MonoBehaviour // TypeDefIndex: 1534
{
	// Fields
	public float speed; // 0x20
	public float acceleration; // 0x24
	public Vector2 screenBounds; // 0x28
	public Vector3 position; // 0x30
	public Camera cam; // 0x40
	public static Vector2 currentPosition; // 0x0
	public static bool buttonDown; // 0x8
	public static bool joystickMoved; // 0x9
	public static MouseCursorForConsole instance; // 0x10
	public static int horizontalAxis; // 0x18
	public static int verticalAxis; // 0x1C
	private int framesVisible; // 0x48
	private const int minFramesToAppear = 3;
	private SpriteRenderer sr; // 0x50

	// Properties
	public static bool CursorActive { get; }

	// Methods

	// RVA: 0x6902A0 Offset: 0x68F4A0 VA: 0x1806902A0
	public static bool get_CursorActive() { }

	// RVA: 0x68FBE0 Offset: 0x68EDE0 VA: 0x18068FBE0
	private void Awake() { }

	// RVA: 0x68FDE0 Offset: 0x68EFE0 VA: 0x18068FDE0
	private void OnEnable() { }

	// RVA: 0x68FD20 Offset: 0x68EF20 VA: 0x18068FD20
	private void OnDestroy() { }

	// RVA: 0x6900F0 Offset: 0x68F2F0 VA: 0x1806900F0
	private void Start() { }

	// RVA: 0x68FFA0 Offset: 0x68F1A0 VA: 0x18068FFA0
	public void SetScreenPosition(Vector2 screenPos) { }

	// RVA: 0x690200 Offset: 0x68F400 VA: 0x180690200
	private void Update() { }

	// RVA: 0x690280 Offset: 0x68F480 VA: 0x180690280
	public void .ctor() { }

	// RVA: 0x690230 Offset: 0x68F430 VA: 0x180690230
	private static void .cctor() { }
}

// Namespace: 
[RequireComponent(typeof(SpriteRenderer))]
public class PlatformIdentifier : MonoBehaviour // TypeDefIndex: 1535
{
	// Fields
	public SpriteRenderer iconRenderer; // 0x20
	public TextMeshPro platformIDText; // 0x28
	public bool isOnHUD; // 0x30
	public Sprite genericConsole; // 0x38
	public Sprite mobile; // 0x40
	public Sprite pc; // 0x48
	public Sprite nSwitch; // 0x50
	public Sprite ps4; // 0x58
	public Sprite xbox; // 0x60
	public bool Masked; // 0x68

	// Properties
	private bool Visible { set; }
	private bool UsernameVisible { set; }

	// Methods

	// RVA: 0x6910D0 Offset: 0x6902D0 VA: 0x1806910D0
	public static bool SupportsPlatformUsername(Platforms platformTypeID) { }

	// RVA: 0x6914A0 Offset: 0x6906A0 VA: 0x1806914A0
	private void set_Visible(bool value) { }

	// RVA: 0x5A8400 Offset: 0x5A7600 VA: 0x1805A8400
	private void set_UsernameVisible(bool value) { }

	// RVA: 0x690B60 Offset: 0x68FD60 VA: 0x180690B60
	public void Awake() { }

	// RVA: 0x690E00 Offset: 0x690000 VA: 0x180690E00
	public void SetInfo(ClientData clientData) { }

	// RVA: 0x690DF0 Offset: 0x68FFF0 VA: 0x180690DF0
	public void SetInfo(GameListing gameListingData) { }

	// RVA: 0x690E50 Offset: 0x690050 VA: 0x180690E50
	public void SetInfo(Platforms platform, string platformName) { }

	// RVA: 0x690C60 Offset: 0x68FE60 VA: 0x180690C60
	private void SetIcon(Platforms platform) { }

	[ContextMenu("Update pos")]
	// RVA: 0x6910E0 Offset: 0x6902E0 VA: 0x1806910E0
	public void UpdatePosition() { }

	// RVA: 0x690C20 Offset: 0x68FE20 VA: 0x180690C20
	private Sprite GetPrevalidationIcon(Platforms platform) { }

	// RVA: 0x6913D0 Offset: 0x6905D0 VA: 0x1806913D0
	private Sprite ValidateIcon(Sprite icon) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public static class PlatformPaths // TypeDefIndex: 1536
{
	// Properties
	public static string persistentDataPath { get; }
	public static string temporaryCachePath { get; }

	// Methods

	// RVA: 0x6914D0 Offset: 0x6906D0 VA: 0x1806914D0
	public static string get_persistentDataPath() { }

	// RVA: 0x691510 Offset: 0x690710 VA: 0x180691510
	public static string get_temporaryCachePath() { }
}

// Namespace: 
public class TouchpadBehavior : MonoBehaviour // TypeDefIndex: 1537
{
	// Fields
	private float aspect; // 0x20
	private bool touching; // 0x24
	private bool firstTouch; // 0x25
	private Vector2 toCenter; // 0x28
	private Vector2 firstTouchPos; // 0x30
	private Vector2 delta; // 0x38
	private Vector2 fromCenter; // 0x40
	private IDualShock4Extension ds4; // 0x48
	public float touchpadSensitivity; // 0x50

	// Methods

	// RVA: 0x696070 Offset: 0x695270 VA: 0x180696070
	private void Start() { }

	// RVA: 0x695F40 Offset: 0x695140 VA: 0x180695F40
	private void OnDestroy() { }

	// RVA: 0x695DC0 Offset: 0x694FC0 VA: 0x180695DC0
	private void GetExtension() { }

	// RVA: 0x696270 Offset: 0x695470 VA: 0x180696270
	private void Update() { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool IsTouching() { }

	// RVA: 0x695F20 Offset: 0x695120 VA: 0x180695F20
	public bool IsFirstTouch() { }

	// RVA: 0x696060 Offset: 0x695260 VA: 0x180696060
	public void ResetTouch() { }

	// RVA: 0x695EB0 Offset: 0x6950B0 VA: 0x180695EB0
	public Vector2 GetTouchVector() { }

	// RVA: 0x695D50 Offset: 0x694F50 VA: 0x180695D50
	public Vector2 GetCenterToTouch() { }

	// RVA: 0x696410 Offset: 0x695610 VA: 0x180696410
	public void .ctor() { }
}

// Namespace: 
public class TrophyManager : DestroyableSingleton<TrophyManager> // TypeDefIndex: 1538
{
	// Fields
	public static TrophyManager Instance; // 0x0
	private static int UserID; // 0x8

	// Methods

	// RVA: 0x696470 Offset: 0x695670 VA: 0x180696470
	public void .ctor() { }
}

// Namespace: 
public enum JoinSessionSource // TypeDefIndex: 1539
{
	// Fields
	public int value__; // 0x0
	public const JoinSessionSource Owner = 0;
	public const JoinSessionSource Lobby = 1;
	public const JoinSessionSource Invite = 2;
	public const JoinSessionSource LaunchActivity = 3;
	public const JoinSessionSource None = 4;
}

// Namespace: 
public class PSGameSessionManager // TypeDefIndex: 1540
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PSManager.<CreateGameCo>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1541
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PSManager <>4__this; // 0x20
	public GameModes gameMode; // 0x28

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

	// RVA: 0x698460 Offset: 0x697660 VA: 0x180698460 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x698890 Offset: 0x697A90 VA: 0x180698890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PSManager.<JoinGame>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1542
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int gameCode; // 0x20

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

	// RVA: 0x6988D0 Offset: 0x697AD0 VA: 0x1806988D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x698C40 Offset: 0x697E40 VA: 0x180698C40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PSManager.<KeepLoadBlockerActive>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1543
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PSManager <>4__this; // 0x20

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

	// RVA: 0x698C80 Offset: 0x697E80 VA: 0x180698C80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x698D60 Offset: 0x697F60 VA: 0x180698D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[DefaultExecutionOrder(-20000)]
public class PSManager : DestroyableSingleton<PSManager> // TypeDefIndex: 1544
{
	// Fields
	public Texture2D ps4SessionImage; // 0x28
	public byte[] ps4SessionImageAsPNG; // 0x30
	public JoinSessionSource joinSessionSource; // 0x38
	public bool gameplayStarted; // 0x3C
	private bool keepBlockerActive; // 0x3D

	// Methods

	// RVA: 0x690480 Offset: 0x68F680 VA: 0x180690480
	public string GetSessionName() { }

	// RVA: 0x690940 Offset: 0x68FB40 VA: 0x180690940
	public void JoinGameFromCode(string gameCode) { }

	// RVA: 0x6909F0 Offset: 0x68FBF0 VA: 0x1806909F0
	public void JoinGameFromCode(int gameCode) { }

	[IteratorStateMachine(typeof(PSManager.<JoinGame>d__7))]
	// RVA: 0x690A60 Offset: 0x68FC60 VA: 0x180690A60
	public IEnumerator JoinGame(int gameCode) { }

	// RVA: 0x690400 Offset: 0x68F600 VA: 0x180690400
	public void CreateGame(GameModes gameMode) { }

	[IteratorStateMachine(typeof(PSManager.<CreateGameCo>d__10))]
	// RVA: 0x690390 Offset: 0x68F590 VA: 0x180690390
	private IEnumerator CreateGameCo(GameModes gameMode) { }

	[IteratorStateMachine(typeof(PSManager.<KeepLoadBlockerActive>d__11))]
	// RVA: 0x690AC0 Offset: 0x68FCC0 VA: 0x180690AC0
	private IEnumerator KeepLoadBlockerActive() { }

	// RVA: 0x690B20 Offset: 0x68FD20 VA: 0x180690B20
	public void .ctor() { }
}

// Namespace: 
public class SaveDataInitialization : MonoBehaviour // TypeDefIndex: 1545
{
	// Fields
	public Texture2D ps4SaveImage; // 0x20
	public Texture2D ps5SaveImage; // 0x28

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Awake() { }

	// RVA: 0x695CD0 Offset: 0x694ED0 VA: 0x180695CD0
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class PopupDialog : MonoBehaviour // TypeDefIndex: 1546
{
	// Fields
	public TextMeshPro workingText; // 0x20
	public float secondsBetweenDots; // 0x28
	public int maxDots; // 0x2C
	public string currentProgressText; // 0x30
	private float textUpdateTimer; // 0x38
	private static PopupDialog instance; // 0x0

	// Methods

	// RVA: 0x692D10 Offset: 0x691F10 VA: 0x180692D10
	public static void Display() { }

	// RVA: 0x692E10 Offset: 0x692010 VA: 0x180692E10
	public static void Dispose() { }

	// RVA: 0x692F00 Offset: 0x692100 VA: 0x180692F00
	private void Start() { }

	// RVA: 0x692EB0 Offset: 0x6920B0 VA: 0x180692EB0
	private void OnDestroy() { }

	// RVA: 0x692F50 Offset: 0x692150 VA: 0x180692F50
	public void Update() { }

	// RVA: 0x693010 Offset: 0x692210 VA: 0x180693010
	public void .ctor() { }
}

// Namespace: 
public struct RadialMenu.CachedButtonObject // TypeDefIndex: 1547
{
	// Fields
	public TextMeshPro tr; // 0x0
	public Transform textHandle; // 0x8
	public RectTransform trRT; // 0x10
	public GameObject gameObject; // 0x18
	public PassiveButton button; // 0x20
	public ButtonRolloverHandler rolloverHandler; // 0x28
	public bool isNew; // 0x30
	public PolygonCollider2D buttonCollider; // 0x38
	public List<Vector2> colliderPoints; // 0x40
	public int buttonIndex; // 0x48
	public SpriteRenderer iconSR; // 0x50
	private Vector3 baseTextPos; // 0x58
	public Vector3 buttonDir; // 0x64

	// Methods

	// RVA: 0x699860 Offset: 0x698A60 VA: 0x180699860
	public void .ctor(GameObject go, int bIndex) { }

	// RVA: 0x699570 Offset: 0x698770 VA: 0x180699570
	public void AddIcon(Sprite iconSprite) { }

	// RVA: 0x699800 Offset: 0x698A00 VA: 0x180699800
	public void ResetIcon() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RadialMenu.<>c__DisplayClass28_0 // TypeDefIndex: 1548
{
	// Fields
	public int tempButtonCount; // 0x10
	public RadialMenu <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC980 Offset: 0x6ABB80 VA: 0x1806AC980
	internal void <CacheButtons>b__0() { }
}

// Namespace: 
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class RadialMenu : MonoBehaviour // TypeDefIndex: 1549
{
	// Fields
	public Mesh mesh; // 0x20
	public GameObject perButtonTemplateObject; // 0x28
	private MeshFilter mf; // 0x30
	private MeshRenderer mr; // 0x38
	private int radialDivisions; // 0x40
	public float sliceDegreesPerVert; // 0x44
	public float textPositionDistance; // 0x48
	public bool angleText; // 0x4C
	public int testRadialDivs; // 0x50
	private MaterialPropertyBlock mbp; // 0x58
	private Controller cont; // 0x60
	public Transform arrowRotateHandle; // 0x68
	public Transform arrowScaleHandle; // 0x70
	public Transform inputGlyph; // 0x78
	public List<RadialMenu.CachedButtonObject> cachedButtons; // 0x80
	public Vector3[] buttonCenters; // 0x88
	public Vector3[] buttonLeftEdges; // 0x90
	public Vector3[] buttonRightEdges; // 0x98
	private const float startOffset = -1,5707964;
	public static int instances; // 0x0
	[HideInInspector]
	public int prevSelectedButton; // 0xA0
	[HideInInspector]
	public int mouseSelectedButton; // 0xA4
	private const int cutoffLength = 12;
	public float horizontalSqueezedWidth; // 0xA8

	// Methods

	// RVA: 0x695490 Offset: 0x694690 VA: 0x180695490
	private void OnEnable() { }

	// RVA: 0x695450 Offset: 0x694650 VA: 0x180695450
	private void OnDisable() { }

	// RVA: 0x694A40 Offset: 0x693C40 VA: 0x180694A40
	public void ButtonMouseOver(int which) { }

	// RVA: 0x6949A0 Offset: 0x693BA0 VA: 0x1806949A0
	public void ButtonMouseExit() { }

	// RVA: 0x695540 Offset: 0x694740 VA: 0x180695540
	private void Update() { }

	// RVA: 0x694F00 Offset: 0x694100 VA: 0x180694F00
	public RadialMenu.CachedButtonObject[] CreateButtonsForStrings(string[] strings) { }

	// RVA: 0x694AE0 Offset: 0x693CE0 VA: 0x180694AE0
	private void CacheButtons(int numButtons) { }

	// RVA: 0x695060 Offset: 0x694260 VA: 0x180695060
	public float GetButtonMaxStringWidth(int whichButton, float scale) { }

	// RVA: 0x693060 Offset: 0x692260 VA: 0x180693060
	private void AlignTexts(string[] strings) { }

	// RVA: 0x693A10 Offset: 0x692C10 VA: 0x180693A10
	private void BuildMesh(int newRadialDivisions) { }

	// RVA: 0x695C10 Offset: 0x694E10 VA: 0x180695C10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6949A0 Offset: 0x693BA0 VA: 0x1806949A0
	private void <CacheButtons>b__28_1() { }
}

// Namespace: 
public class RadialMenuButton : MonoBehaviour // TypeDefIndex: 1550
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public static class ReleaseVersionNumber_Generated // TypeDefIndex: 1551
{
	// Fields
	public static int ReleaseVersion; // 0x0

	// Methods

	// RVA: 0x6A6E20 Offset: 0x6A6020 VA: 0x1806A6E20
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class RewiredCategoryEnabler.RewiredCategoryState // TypeDefIndex: 1552
{
	// Fields
	public string name; // 0x10
	public bool enabled; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewiredCategoryEnabler.<CoApplyDefaultMapState>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1553
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RewiredCategoryEnabler <>4__this; // 0x20

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

	// RVA: 0x6AAEC0 Offset: 0x6AA0C0 VA: 0x1806AAEC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AAF60 Offset: 0x6AA160 VA: 0x1806AAF60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class RewiredCategoryEnabler : MonoBehaviour // TypeDefIndex: 1554
{
	// Fields
	public bool applyDefaultMapState; // 0x20
	public RewiredCategoryEnabler.RewiredCategoryState[] defaultStates; // 0x28

	// Methods

	// RVA: 0x6A7490 Offset: 0x6A6690 VA: 0x1806A7490
	private void OnEnable() { }

	// RVA: 0x6A7400 Offset: 0x6A6600 VA: 0x1806A7400
	private void OnDisable() { }

	// RVA: 0x6A7520 Offset: 0x6A6720 VA: 0x1806A7520
	private void ReInput_ControllerConnectedEvent(ControllerStatusChangedEventArgs obj) { }

	[IteratorStateMachine(typeof(RewiredCategoryEnabler.<CoApplyDefaultMapState>d__5))]
	// RVA: 0x6A73A0 Offset: 0x6A65A0 VA: 0x1806A73A0
	private IEnumerator CoApplyDefaultMapState() { }

	// RVA: 0x6A6F40 Offset: 0x6A6140 VA: 0x1806A6F40
	public void ApplyDefaultMapState() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum RewiredConstsEnum.Action // TypeDefIndex: 1555
{
	// Fields
	public int value__; // 0x0
	public const RewiredConstsEnum.Action Pause = 1;
	public const RewiredConstsEnum.Action MoveHorizontal = 2;
	public const RewiredConstsEnum.Action MoveVertical = 3;
	public const RewiredConstsEnum.Action ToggleMap = 4;
	public const RewiredConstsEnum.Action ToggleTasks = 5;
	public const RewiredConstsEnum.Action ActionPrimary = 6;
	public const RewiredConstsEnum.Action ActionSecondary = 8;
	public const RewiredConstsEnum.Action ActionTertiary = 7;
	public const RewiredConstsEnum.Action MenuHorizontal = 9;
	public const RewiredConstsEnum.Action MenuVertical = 10;
	public const RewiredConstsEnum.Action MenuConfirm = 11;
	public const RewiredConstsEnum.Action MenuCancel = 12;
	public const RewiredConstsEnum.Action TaskLHorizontal = 13;
	public const RewiredConstsEnum.Action TaskLVertical = 14;
	public const RewiredConstsEnum.Action TaskRHorizontal = 16;
	public const RewiredConstsEnum.Action TaskRVertical = 17;
	public const RewiredConstsEnum.Action ButtonChat = 18;
	public const RewiredConstsEnum.Action ButtonStart = 19;
	public const RewiredConstsEnum.Action TaskLT = 24;
	public const RewiredConstsEnum.Action TaskLB = 20;
	public const RewiredConstsEnum.Action TaskRT = 21;
	public const RewiredConstsEnum.Action TaskRB = 22;
	public const RewiredConstsEnum.Action MenuUp = 25;
	public const RewiredConstsEnum.Action MenuDown = 26;
	public const RewiredConstsEnum.Action MenuRight = 27;
	public const RewiredConstsEnum.Action MenuLeft = 28;
	public const RewiredConstsEnum.Action TaskConfirmAlt = 29;
	public const RewiredConstsEnum.Action MenuHorizontalAlt = 30;
	public const RewiredConstsEnum.Action MenuVerticalAlt = 31;
	public const RewiredConstsEnum.Action TaskConfirmTertiary = 32;
	public const RewiredConstsEnum.Action ButtonKeyboard = 33;
	public const RewiredConstsEnum.Action MenuRT = 34;
	public const RewiredConstsEnum.Action MenuLT = 35;
	public const RewiredConstsEnum.Action ButtonBan = 36;
	public const RewiredConstsEnum.Action AccountPicker = 37;
	public const RewiredConstsEnum.Action TogglePlayerList = 38;
	public const RewiredConstsEnum.Action ActionQuaternary = 49;
	public const RewiredConstsEnum.Action UseVent = 50;
	public const RewiredConstsEnum.Action MenuLB = 52;
	public const RewiredConstsEnum.Action MenuRB = 53;
	public const RewiredConstsEnum.Action QuickChatFavorite = 69;
	public const RewiredConstsEnum.Action QuickChatClear = 70;
	public const RewiredConstsEnum.Action ChatSend = 71;
	public const RewiredConstsEnum.Action QuickChatOpen = 72;
	public const RewiredConstsEnum.Action DebugPageNext = 56;
	public const RewiredConstsEnum.Action DebugPagePrev = 57;
	public const RewiredConstsEnum.Action DebugSubpageNext = 58;
	public const RewiredConstsEnum.Action DebugSubpagePrev = 59;
	public const RewiredConstsEnum.Action DebugNavVertical = 63;
	public const RewiredConstsEnum.Action DebugNavHorizontal = 75;
	public const RewiredConstsEnum.Action DebugConfirm = 65;
	public const RewiredConstsEnum.Action DebugCancel = 66;
	public const RewiredConstsEnum.Action DebugToolStart = 60;
	public const RewiredConstsEnum.Action DebugToolCopy = 67;
	public const RewiredConstsEnum.Action DebugToolClear = 68;
}

// Namespace: 
public enum RewiredConstsEnum.DebugAction // TypeDefIndex: 1556
{
	// Fields
	public int value__; // 0x0
	public const RewiredConstsEnum.DebugAction DebugPageNext = 56;
	public const RewiredConstsEnum.DebugAction DebugPagePrev = 57;
	public const RewiredConstsEnum.DebugAction DebugSubpageNext = 58;
	public const RewiredConstsEnum.DebugAction DebugSubpagePrev = 59;
	public const RewiredConstsEnum.DebugAction DebugNavVertical = 63;
	public const RewiredConstsEnum.DebugAction DebugNavHorizontal = 75;
	public const RewiredConstsEnum.DebugAction DebugConfirm = 65;
	public const RewiredConstsEnum.DebugAction DebugCancel = 66;
	public const RewiredConstsEnum.DebugAction DebugToolStart = 60;
	public const RewiredConstsEnum.DebugAction DebugToolCopy = 67;
	public const RewiredConstsEnum.DebugAction DebugToolClear = 68;
}

// Namespace: 
public static class RewiredConstsEnum // TypeDefIndex: 1557
{}

// Namespace: 
[RequireComponent(typeof(Camera))]
public class SaveIconCamera : DestroyableSingleton<SaveIconCamera> // TypeDefIndex: 1558
{
	// Fields
	private Camera cam; // 0x28
	public ConditionalRenderTexture platformRenderTextures; // 0x30
	private RenderTexture targetTexture; // 0x38
	public PlayerControl saveIconDummy; // 0x40
	public LayerMask layerToRenderWith; // 0x48
	private int layerIndex; // 0x4C
	private static object lockObject; // 0x0
	private static bool needsRender; // 0x8
	private static byte[] renderedPNG; // 0x10

	// Methods

	// RVA: 0x6A7BE0 Offset: 0x6A6DE0 VA: 0x1806A7BE0
	private void Awake() { }

	// RVA: 0x6A8470 Offset: 0x6A7670 VA: 0x1806A8470
	private void Start() { }

	// RVA: 0x6A7C50 Offset: 0x6A6E50 VA: 0x1806A7C50
	private void LateUpdate() { }

	[ContextMenu("Test Render Icon")]
	// RVA: 0x6A8530 Offset: 0x6A7730 VA: 0x1806A8530
	private void TestIcon() { }

	// RVA: 0x6A82E0 Offset: 0x6A74E0 VA: 0x1806A82E0
	public static byte[] RenderSaveIcon() { }

	// RVA: 0x6A7DA0 Offset: 0x6A6FA0 VA: 0x1806A7DA0
	private byte[] RenderSaveIconLocal() { }

	// RVA: 0x6A85C0 Offset: 0x6A77C0 VA: 0x1806A85C0
	public void .ctor() { }

	// RVA: 0x6A8540 Offset: 0x6A7740 VA: 0x1806A8540
	private static void .cctor() { }
}

// Namespace: 
[RequireComponent(typeof(Scroller))]
public class ScrollToSelection : MonoBehaviour // TypeDefIndex: 1559
{
	// Fields
	[SerializeField]
	private float scrollOffset; // 0x20
	private Scroller scrollRect; // 0x28
	private bool manuallyScrolling; // 0x30
	private UIScrollbarHelper[] childElements; // 0x38
	public Vector2 wantedValue; // 0x40
	private GameObject lastSelectedObject; // 0x48
	public bool cursorEnabled; // 0x50
	public bool killScroll; // 0x51
	public bool onePage; // 0x52

	// Methods

	// RVA: 0x6A8600 Offset: 0x6A7800 VA: 0x1806A8600
	private void Awake() { }

	// RVA: 0x6A8C10 Offset: 0x6A7E10 VA: 0x1806A8C10
	private void OnEnable() { }

	// RVA: 0x6A9380 Offset: 0x6A8580 VA: 0x1806A9380
	private void Start() { }

	// RVA: 0x6A94D0 Offset: 0x6A86D0 VA: 0x1806A94D0
	public void Toggle(bool on) { }

	// RVA: 0x6A8640 Offset: 0x6A7840 VA: 0x1806A8640
	public void ClearSelections() { }

	// RVA: 0x6A8650 Offset: 0x6A7850 VA: 0x1806A8650
	private void LateUpdate() { }

	// RVA: 0x6A8DC0 Offset: 0x6A7FC0 VA: 0x1806A8DC0
	private void ScrollToRect(Transform targetRectTransform) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SetInputModeOnAwake : MonoBehaviour // TypeDefIndex: 1560
{
	// Fields
	public ConsoleJoystick.ConsoleInputState inputMode; // 0x20

	// Methods

	// RVA: 0x6A94E0 Offset: 0x6A86E0 VA: 0x1806A94E0
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SimpleSoundPlayer : MonoBehaviour // TypeDefIndex: 1561
{
	// Fields
	public AudioClip[] clips; // 0x20
	private AudioSource soundSource; // 0x28

	// Methods

	// RVA: 0x6AA490 Offset: 0x6A9690 VA: 0x1806AA490
	private void OnEnable() { }

	// RVA: 0x6AA4D0 Offset: 0x6A96D0 VA: 0x1806AA4D0
	public void PlaySound() { }

	// RVA: 0x6AA4F0 Offset: 0x6A96F0 VA: 0x1806AA4F0
	public void PlaySpecificSound(int index) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SpecialInputHandler : MonoBehaviour // TypeDefIndex: 1562
{
	// Fields
	public static int count; // 0x0
	public static int disableVirtualCursorCount; // 0x4
	public static int suppressInGamePlayerListCount; // 0x8
	[SerializeField]
	private bool _disableVirtualCursor; // 0x20
	[SerializeField]
	private bool _suppressInGamePlayerList; // 0x21

	// Properties
	public bool disableVirtualCursor { get; set; }
	public bool suppressInGamePlayerList { get; set; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_disableVirtualCursor() { }

	// RVA: 0x6AA650 Offset: 0x6A9850 VA: 0x1806AA650
	public void set_disableVirtualCursor(bool value) { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_suppressInGamePlayerList() { }

	// RVA: 0x6AA6D0 Offset: 0x6A98D0 VA: 0x1806AA6D0
	public void set_suppressInGamePlayerList(bool value) { }

	// RVA: 0x6AA5D0 Offset: 0x6A97D0 VA: 0x1806AA5D0
	private void OnEnable() { }

	// RVA: 0x6AA550 Offset: 0x6A9750 VA: 0x1806AA550
	private void OnDisable() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SplashLogoAnimator : MonoBehaviour // TypeDefIndex: 1563
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(ParticleSystem))]
public class SpriteParticleSystem : MonoBehaviour // TypeDefIndex: 1564
{
	// Fields
	public Sprite sprite; // 0x20
	public ParticleSystemRenderer ren; // 0x28
	private MaterialPropertyBlock block; // 0x30

	// Methods

	// RVA: 0x6AA750 Offset: 0x6A9950 VA: 0x1806AA750
	private void OnEnable() { }

	// RVA: 0x6AA800 Offset: 0x6A9A00 VA: 0x1806AA800
	private void SetPropertyBlock() { }

	// RVA: 0x6AA7F0 Offset: 0x6A99F0 VA: 0x1806AA7F0
	private void OnValidate() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[DefaultExecutionOrder(-20000)]
public class SwitchManager : MonoBehaviour // TypeDefIndex: 1565
{
	// Fields
	public BuildSettingsConsole buildSettingsConsole; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class SwitchVirtualKeyboardJob // TypeDefIndex: 1566
{
	// Fields
	public string text; // 0x10
	public bool active; // 0x18
	public TouchScreenKeyboard.Status status; // 0x1C

	// Methods

	// RVA: 0x6AA8D0 Offset: 0x6A9AD0 VA: 0x1806AA8D0
	public void .ctor() { }
}

// Namespace: 
public class TimeOutPopupHandler : MonoBehaviour // TypeDefIndex: 1567
{
	// Fields
	public UiElement BackButton; // 0x20
	public List<UiElement> Buttons; // 0x28

	// Methods

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Retry() { }

	// RVA: 0x6AA920 Offset: 0x6A9B20 VA: 0x1806AA920
	public void PlayOffline() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	public void Close() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class UIScrollbarHelper : MonoBehaviour // TypeDefIndex: 1568
{
	// Fields
	public int index; // 0x20
	public bool isDirectChild; // 0x24

	// Methods

	// RVA: 0x6ACAC0 Offset: 0x6ABCC0 VA: 0x1806ACAC0
	public Vector2 GetLocalPosition(Scroller scrollRect) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public static class UnicodeSupport // TypeDefIndex: 1569
{
	// Fields
	private static StringBuilder sb; // 0x0

	// Methods

	// RVA: 0x6ACB80 Offset: 0x6ABD80 VA: 0x1806ACB80
	public static string FilterUnsupportedCharacters(TextMeshPro tr, FontData data) { }

	// RVA: 0x6ACDE0 Offset: 0x6ABFE0 VA: 0x1806ACDE0
	private static void .cctor() { }
}

// Namespace: 
public static class IntUtility // TypeDefIndex: 1570
{
	// Methods

	// RVA: 0x6A4230 Offset: 0x6A3430 VA: 0x1806A4230
	public static byte[] IntToByteArray(int value) { }

	// RVA: 0x6A4000 Offset: 0x6A3200 VA: 0x1806A4000
	public static int ByteArrayToInt(byte[] data) { }

	// RVA: 0x6A4060 Offset: 0x6A3260 VA: 0x1806A4060
	public static ulong ConvertHexToUint64(string hexStr) { }
}

// Namespace: 
public enum VibrationManager.VibrationFalloff // TypeDefIndex: 1571
{
	// Fields
	public int value__; // 0x0
	public const VibrationManager.VibrationFalloff None = 0;
	public const VibrationManager.VibrationFalloff Linear = 1;
	public const VibrationManager.VibrationFalloff InverseLinear = 2;
}

// Namespace: 
private class VibrationManager.LocalVibration // TypeDefIndex: 1572
{
	// Fields
	public Vector2 intensity; // 0x10
	public float t; // 0x18
	public float duration; // 0x1C
	public VibrationManager.VibrationFalloff falloff; // 0x20
	public AudioClip clip; // 0x28
	public bool loopClip; // 0x30
	public string name; // 0x38

	// Properties
	public bool Alive { get; }

	// Methods

	// RVA: 0x6A48A0 Offset: 0x6A3AA0 VA: 0x1806A48A0
	public void Init() { }

	// RVA: 0x6A4BB0 Offset: 0x6A3DB0 VA: 0x1806A4BB0
	public bool get_Alive() { }

	// RVA: 0x6A4930 Offset: 0x6A3B30 VA: 0x1806A4930
	public Vector2 UpdateIntensity(float deltaTime) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class VibrationManager.WorldVibration // TypeDefIndex: 1573
{
	// Fields
	public float intensity; // 0x10
	public Vector2 location; // 0x14
	public float radius; // 0x1C
	public float t; // 0x20
	public float duration; // 0x24
	public VibrationManager.VibrationFalloff falloff; // 0x28
	public AudioClip clip; // 0x30
	public bool loopClip; // 0x38
	public string name; // 0x40

	// Properties
	public bool Alive { get; }

	// Methods

	// RVA: 0x6AFB60 Offset: 0x6AED60 VA: 0x1806AFB60
	public void Init() { }

	// RVA: 0x68F760 Offset: 0x68E960 VA: 0x18068F760
	public bool get_Alive() { }

	// RVA: 0x6AFBF0 Offset: 0x6AEDF0 VA: 0x1806AFBF0
	public Vector2 UpdateIntensity(Vector2 cameraPos, float deltaTime) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class VibrationManager : DestroyableSingleton<VibrationManager> // TypeDefIndex: 1574
{
	// Fields
	public const float SMALL_INTENSITY = 0,3;
	public const float MEDIUM_INTENSITY = 0,7;
	public const float FRAME_DURATION = 0,02;
	private List<VibrationManager.LocalVibration> currentLocalVibration; // 0x28
	private List<VibrationManager.WorldVibration> currentWorldVibration; // 0x30
	private Vector2 singleFrameVibration; // 0x38
	private bool hasFrameVibration; // 0x40
	private bool zeroNextFrame; // 0x41
	public int numVibrationsActive; // 0x44
	public Vector2 currentVibration; // 0x48
	private Camera cam; // 0x50
	private VibrationManager.WorldVibration tempSingleFrameWorldVibration; // 0x58
	private VibrationManager.WorldVibration tempAmbientSoundVibration; // 0x60
	private bool shouldVibrate; // 0x68
	private static float[] samples; // 0x0

	// Methods

	// RVA: 0x6ADBC0 Offset: 0x6ACDC0 VA: 0x1806ADBC0
	private void Start() { }

	// RVA: 0x6AD9E0 Offset: 0x6ACBE0 VA: 0x1806AD9E0
	private void OnEnable() { }

	// RVA: 0x6AD950 Offset: 0x6ACB50 VA: 0x1806AD950
	private void OnDisable() { }

	// RVA: 0x6ADA70 Offset: 0x6ACC70 VA: 0x1806ADA70
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x6AD830 Offset: 0x6ACA30 VA: 0x1806AD830
	public static void ClearAllVibration() { }

	// RVA: 0x6ADBE0 Offset: 0x6ACDE0 VA: 0x1806ADBE0
	private void Update() { }

	// RVA: 0x6AD600 Offset: 0x6AC800 VA: 0x1806AD600
	public static void CancelVibration(AudioClip clipToCancel) { }

	// RVA: 0x6AD410 Offset: 0x6AC610 VA: 0x1806AD410
	public static void CancelVibration(string name) { }

	// RVA: 0x6AE860 Offset: 0x6ADA60 VA: 0x1806AE860
	public static void Vibrate(float left, float right) { }

	// RVA: 0x6AE8E0 Offset: 0x6ADAE0 VA: 0x1806AE8E0
	public static void Vibrate(float left, float right, float duration, VibrationManager.VibrationFalloff falloffType = 0, AudioClip sourceClip, bool loopClip = False, string name = "") { }

	// RVA: 0x6AE680 Offset: 0x6AD880 VA: 0x1806AE680
	public static void Vibrate(float intensity, Vector2 worldPosition, float radius) { }

	// RVA: 0x6AE4C0 Offset: 0x6AD6C0 VA: 0x1806AE4C0
	public static void Vibrate(float intensity, Vector2 worldPosition, float radius, float duration, VibrationManager.VibrationFalloff falloffType = 0, AudioClip sourceClip, bool loopClip = False) { }

	// RVA: 0x6AEAF0 Offset: 0x6ADCF0 VA: 0x1806AEAF0
	public void .ctor() { }

	// RVA: 0x6AEA90 Offset: 0x6ADC90 VA: 0x1806AEA90
	private static void .cctor() { }
}

// Namespace: 
public class VirtualCursor : MonoBehaviour // TypeDefIndex: 1575
{
	// Fields
	public float speed; // 0x20
	private float currentSpeed; // 0x24
	public float acceleration; // 0x28
	public Vector2 screenBounds; // 0x2C
	public Vector3 position; // 0x34
	private const float deadzone = 0,03;
	private const float touchpadSensitivity = 4;
	public Camera cam; // 0x40
	public static Vector2 currentPosition; // 0x0
	public static bool buttonDown; // 0x8
	public static bool joystickMoved; // 0x9
	public static VirtualCursor instance; // 0x10
	public static int horizontalAxis; // 0x18
	public static int verticalAxis; // 0x1C
	private int framesVisible; // 0x48
	private const int minFramesToAppear = 3;
	private SpriteRenderer sr; // 0x50
	private Vector2 prevTouchPos; // 0x58
	private bool setTouchPos; // 0x60

	// Properties
	public static bool CursorActive { get; }

	// Methods

	// RVA: 0x6AFA70 Offset: 0x6AEC70 VA: 0x1806AFA70
	public static bool get_CursorActive() { }

	// RVA: 0x6AEC30 Offset: 0x6ADE30 VA: 0x1806AEC30
	private void Awake() { }

	// RVA: 0x6AEE30 Offset: 0x6AE030 VA: 0x1806AEE30
	private void OnEnable() { }

	// RVA: 0x6AED70 Offset: 0x6ADF70 VA: 0x1806AED70
	private void OnDestroy() { }

	// RVA: 0x6AF1A0 Offset: 0x6AE3A0 VA: 0x1806AF1A0
	private void Start() { }

	// RVA: 0x6AF050 Offset: 0x6AE250 VA: 0x1806AF050
	public void SetWorldPosition(Vector2 worldPos) { }

	// RVA: 0x6AEF00 Offset: 0x6AE100 VA: 0x1806AEF00
	public void SetScreenPosition(Vector2 screenPos) { }

	// RVA: 0x6AF2B0 Offset: 0x6AE4B0 VA: 0x1806AF2B0
	private void Update() { }

	// RVA: 0x6AFA50 Offset: 0x6AEC50 VA: 0x1806AFA50
	public void .ctor() { }

	// RVA: 0x6AFA00 Offset: 0x6AEC00 VA: 0x1806AFA00
	private static void .cctor() { }
}

// Namespace: 
public class ShowIfCrossplayEnabled : MonoBehaviour // TypeDefIndex: 1576
{
	// Fields
	public GameObject Target; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SignInUserOnButtonPress.<ContinueToNextScene>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1577
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SignInUserOnButtonPress <>4__this; // 0x20

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

	// RVA: 0x6ABD70 Offset: 0x6AAF70 VA: 0x1806ABD70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6ABDD0 Offset: 0x6AAFD0 VA: 0x1806ABDD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class SignInUserOnButtonPress : MonoBehaviour // TypeDefIndex: 1578
{
	// Fields
	public Action OnButtonPress; // 0x20
	public SceneChanger SceneChanger; // 0x28
	public TextTranslatorTMP Text; // 0x30
	private bool inviteReceived; // 0x38

	// Methods

	// RVA: 0x6A97C0 Offset: 0x6A89C0 VA: 0x1806A97C0
	private void OnEnable() { }

	// RVA: 0x6A96A0 Offset: 0x6A88A0 VA: 0x1806A96A0
	private void OnDisable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void AddUserWithUI() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void AddUserCompleted(UserManager.UserOpResult result) { }

	[IteratorStateMachine(typeof(SignInUserOnButtonPress.<ContinueToNextScene>d__9))]
	// RVA: 0x6A9610 Offset: 0x6A8810 VA: 0x1806A9610
	private IEnumerator ContinueToNextScene() { }

	// RVA: 0x6A9670 Offset: 0x6A8870 VA: 0x1806A9670
	public void HandleInvite(string connectionString) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class ProgressionManager.XpGrantResult // TypeDefIndex: 1579
{
	// Fields
	public readonly uint GrantedXp; // 0x10
	public readonly uint OldXpAmount; // 0x14
	public readonly uint XpRequiredToLevelUp; // 0x18
	public readonly uint XpRequiredToLevelUpNextLevel; // 0x1C
	public readonly uint OldLevel; // 0x20
	public readonly uint NewLevel; // 0x24
	public readonly uint MaxLevel; // 0x28
	public readonly bool LevelledUp; // 0x2C

	// Methods

	// RVA: 0x6B0210 Offset: 0x6AF410 VA: 0x1806B0210
	public void .ctor(uint grantedXp, uint oldXpAmount, uint xpRequiredToLevelUp, uint xpRequiredToLevelUpNextLevel, bool levelledUp, uint oldLevel, uint newLevel, uint maxLevel) { }

	// RVA: 0x6B00A0 Offset: 0x6AF2A0 VA: 0x1806B00A0
	public static ProgressionManager.XpGrantResult Default() { }
}

// Namespace: 
public class ProgressionManager.CurrencyGrantResult // TypeDefIndex: 1580
{
	// Fields
	public readonly string PodId; // 0x10
	public readonly uint OldPodAmount; // 0x18
	public readonly uint GrantedPodsWithMultiplierApplied; // 0x1C
	public readonly float Multiplier; // 0x20

	// Properties
	public uint GrantedPodsPreMultiplier { get; }

	// Methods

	// RVA: 0x699D30 Offset: 0x698F30 VA: 0x180699D30
	public void .ctor(string podId, uint oldPodAmount, uint grantedPodsWithMultiplierApplied, float multiplier) { }

	// RVA: 0x699D90 Offset: 0x698F90 VA: 0x180699D90
	public uint get_GrantedPodsPreMultiplier() { }

	// RVA: 0x699CB0 Offset: 0x698EB0 VA: 0x180699CB0
	public static ProgressionManager.CurrencyGrantResult Default() { }
}

// Namespace: 
public class ProgressionManager // TypeDefIndex: 1581
{
	// Fields
	public const int FirstLevel = 0;
	public static ProgressionManager Instance; // 0x0
	private const uint MaxLevel = 99;

	// Properties
	public string CurrentVisualLevel { get; }

	// Methods

	// RVA: 0x6A4C60 Offset: 0x6A3E60 VA: 0x1806A4C60
	public string get_CurrentVisualLevel() { }

	// RVA: 0x6A4BC0 Offset: 0x6A3DC0 VA: 0x1806A4BC0
	public static string FormatVisualLevel(uint playerLevel) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6A4C00 Offset: 0x6A3E00 VA: 0x1806A4C00
	private static void .cctor() { }
}

// Namespace: 
public class PS4ButtonSwapHide : MonoBehaviour // TypeDefIndex: 1582
{
	// Fields
	public bool showWhenSwapped; // 0x20

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Awake() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum PurchasePopUp.PurchasePopUpMode // TypeDefIndex: 1583
{
	// Fields
	public int value__; // 0x0
	public const PurchasePopUp.PurchasePopUpMode PurchaseItem = 0;
	public const PurchasePopUp.PurchasePopUpMode CheckingPurchases = 1;
}

// Namespace: 
public class PurchasePopUp : MonoBehaviour // TypeDefIndex: 1584
{
	// Fields
	public GameObject waitingText; // 0x20
	public TextMeshPro titleText; // 0x28
	public TextMeshPro infoText; // 0x30
	public GameObject closeButton; // 0x38
	public GameObject controllerFocusHolder; // 0x40

	// Methods

	// RVA: 0x6A5180 Offset: 0x6A4380 VA: 0x1806A5180
	public void Show(PurchasePopUp.PurchasePopUpMode mode = 0) { }

	// RVA: 0x6A4F20 Offset: 0x6A4120 VA: 0x1806A4F20
	public void SetResponse(ResponseState responseSate, ResponseError[] errors) { }

	// RVA: 0x6A4FD0 Offset: 0x6A41D0 VA: 0x1806A4FD0
	public void SetResponse(ResponseState responseSate, string error) { }

	// RVA: 0x6A4CD0 Offset: 0x6A3ED0 VA: 0x1806A4CD0
	private string GetErrorString(ResponseError error) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public class QuadGen : MonoBehaviour // TypeDefIndex: 1585
{
	// Fields
	public float Width; // 0x20
	public float Height; // 0x24
	public int WidthSubdivisions; // 0x28
	public int HeightSubdivisions; // 0x2C
	public float PerlinFreqX; // 0x30

	// Methods

	[ContextMenu("Generate")]
	// RVA: 0x6A53B0 Offset: 0x6A45B0 VA: 0x1806A53B0
	public void Generate() { }

	// RVA: 0x6A5810 Offset: 0x6A4A10 VA: 0x1806A5810
	public void .ctor() { }
}

// Namespace: 
public class LifeSuppSystemType : ISystemType, IActivatable // TypeDefIndex: 1586
{
	// Fields
	private const float SyncRate = 2;
	private float timer; // 0x10
	public const byte StartCountdown = 128;
	public const byte AddUserOp = 64;
	public const byte ClearCountdown = 16;
	public const float CountdownStopped = 10000;
	public readonly float LifeSuppDuration; // 0x14
	public const byte ConsoleIdMask = 3;
	public const byte RequiredUserCount = 2;
	public float Countdown; // 0x18
	private HashSet<int> CompletedConsoles; // 0x20
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x28

	// Properties
	public bool IsDirty { get; set; }
	public int UserCount { get; }
	public bool IsActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	private void set_IsDirty(bool value) { }

	// RVA: 0x6A47C0 Offset: 0x6A39C0 VA: 0x1806A47C0
	public void .ctor(float duration) { }

	// RVA: 0x6A4860 Offset: 0x6A3A60 VA: 0x1806A4860
	public int get_UserCount() { }

	// RVA: 0x6A4510 Offset: 0x6A3710 VA: 0x1806A4510
	public bool GetConsoleComplete(int consoleId) { }

	// RVA: 0x6A4850 Offset: 0x6A3A50 VA: 0x1806A4850 Slot: 10
	public bool get_IsActive() { }

	// RVA: 0x6A46C0 Offset: 0x6A38C0 VA: 0x1806A46C0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6A43A0 Offset: 0x6A35A0 VA: 0x1806A43A0 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x538580 Offset: 0x537780 VA: 0x180538580 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6A4570 Offset: 0x6A3770 VA: 0x1806A4570 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6A42C0 Offset: 0x6A34C0 VA: 0x1806A42C0 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }
}

// Namespace: 
public class ReactorMinigame : Minigame // TypeDefIndex: 1587
{
	// Fields
	private Color bad; // 0x88
	private Color good; // 0x98
	private ReactorSystemType reactor; // 0xA8
	public TextMeshPro statusText; // 0xB0
	public SpriteRenderer hand; // 0xB8
	private FloatRange YSweep; // 0xC0
	public SpriteRenderer sweeper; // 0xC8
	public AudioClip HandSound; // 0xD0
	private bool isButtonDown; // 0xD8

	// Methods

	// RVA: 0x6A5830 Offset: 0x6A4A30 VA: 0x1806A5830 Slot: 5
	public override void Begin(PlayerTask task) { }

	// RVA: 0x6A5960 Offset: 0x6A4B60 VA: 0x1806A5960
	public void ButtonDown() { }

	// RVA: 0x6A5D30 Offset: 0x6A4F30 VA: 0x1806A5D30
	public void FixedUpdate() { }

	// RVA: 0x6A5C10 Offset: 0x6A4E10 VA: 0x1806A5C10 Slot: 6
	public override void Close() { }

	// RVA: 0x6A6130 Offset: 0x6A5330 VA: 0x1806A6130
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReactorSystemType.<>c__DisplayClass23_0 // TypeDefIndex: 1588
{
	// Fields
	public int consoleId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x6AC850 Offset: 0x6ABA50 VA: 0x1806AC850
	internal bool <GetConsoleComplete>b__0(Tuple<byte, byte> kvp) { }
}

// Namespace: 
public class ReactorSystemType : ISystemType, IActivatable, ICriticalSabotage // TypeDefIndex: 1589
{
	// Fields
	private const float SyncRate = 2;
	private float timer; // 0x10
	public const byte StartCountdown = 128;
	public const byte AddUserOp = 64;
	public const byte RemoveUserOp = 32;
	public const byte ClearCountdown = 16;
	public const float CountdownStopped = 10000;
	public readonly float ReactorDuration; // 0x14
	public const byte ConsoleIdMask = 3;
	public const byte RequiredUserCount = 2;
	[CompilerGenerated]
	private float <Countdown>k__BackingField; // 0x18
	private HashSet<Tuple<byte, byte>> UserConsolePairs; // 0x20
	private SystemTypes system; // 0x28
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x29

	// Properties
	public float Countdown { get; set; }
	public bool IsDirty { get; set; }
	public int UserCount { get; }
	public bool IsActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420 Slot: 12
	public float get_Countdown() { }

	[CompilerGenerated]
	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	private void set_Countdown(float value) { }

	[CompilerGenerated]
	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0 Slot: 4
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	private void set_IsDirty(bool value) { }

	// RVA: 0x6A68B0 Offset: 0x6A5AB0 VA: 0x1806A68B0
	public void .ctor(float duration, SystemTypes system) { }

	// RVA: 0x6A6950 Offset: 0x6A5B50 VA: 0x1806A6950 Slot: 13
	public int get_UserCount() { }

	// RVA: 0x6A6440 Offset: 0x6A5640 VA: 0x1806A6440
	public bool GetConsoleComplete(int consoleId) { }

	// RVA: 0x6A61C0 Offset: 0x6A53C0 VA: 0x1806A61C0 Slot: 14
	public void ClearSabotage() { }

	// RVA: 0x6A4850 Offset: 0x6A3A50 VA: 0x1806A4850 Slot: 11
	public bool get_IsActive() { }

	// RVA: 0x6A66B0 Offset: 0x6A58B0 VA: 0x1806A66B0 Slot: 6
	public void UpdateSystem(PlayerControl player, MessageReader msgReader) { }

	// RVA: 0x6A6310 Offset: 0x6A5510 VA: 0x1806A6310 Slot: 5
	public void Deteriorate(float deltaTime) { }

	// RVA: 0x6A6510 Offset: 0x6A5710 VA: 0x1806A6510 Slot: 7
	public void MarkClean() { }

	// RVA: 0x6A6520 Offset: 0x6A5720 VA: 0x1806A6520 Slot: 8
	public void Serialize(MessageWriter writer, bool initialState) { }

	// RVA: 0x6A61D0 Offset: 0x6A53D0 VA: 0x1806A61D0 Slot: 9
	public void Deserialize(MessageReader reader, bool initialState) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimonSaysGame.<CoAnimateNewLeftSide>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1590
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimonSaysGame <>4__this; // 0x20

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

	// RVA: 0x6AA990 Offset: 0x6A9B90 VA: 0x1806AA990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AAC00 Offset: 0x6A9E00 VA: 0x1806AAC00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimonSaysGame.<CoAnimateOldLeftSide>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1591
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimonSaysGame <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0x6AAC40 Offset: 0x6A9E40 VA: 0x1806AAC40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x6AAE80 Offset: 0x6AA080 VA: 0x1806AAE80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimonSaysGame.<CoRun>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 1592
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimonSaysGame <>4__this; // 0x20

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

	// RVA: 0x6AB480 Offset: 0x6AA680 VA: 0x1806AB480 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
