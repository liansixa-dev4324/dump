	public override string get_settingsGroupLabel() { }

	// RVA: 0x794D70 Offset: 0x793F70 VA: 0x180794D70 Slot: 43
	public override string get_mapCategoriesGroupLabel() { }

	// RVA: 0x794DB0 Offset: 0x793FB0 VA: 0x180794DB0 Slot: 44
	public override string get_restoreDefaultsWindowMessage() { }

	// RVA: 0x794D10 Offset: 0x793F10 VA: 0x180794D10 Slot: 45
	public override string get_calibrateWindow_deadZoneSliderLabel() { }

	// RVA: 0x6ED540 Offset: 0x6EC740 VA: 0x1806ED540 Slot: 46
	public override string get_calibrateWindow_zeroSliderLabel() { }

	// RVA: 0x794D30 Offset: 0x793F30 VA: 0x180794D30 Slot: 47
	public override string get_calibrateWindow_sensitivitySliderLabel() { }

	// RVA: 0x794D20 Offset: 0x793F20 VA: 0x180794D20 Slot: 48
	public override string get_calibrateWindow_invertToggleLabel() { }

	// RVA: 0x794D00 Offset: 0x793F00 VA: 0x180794D00 Slot: 49
	public override string get_calibrateWindow_calibrateButtonLabel() { }

	// RVA: 0x793B40 Offset: 0x792D40 VA: 0x180793B40 Slot: 50
	public override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName) { }

	// RVA: 0x7940F0 Offset: 0x7932F0 VA: 0x1807940F0 Slot: 51
	public override string GetJoystickElementAssignmentPollingWindowMessage(string actionName) { }

	// RVA: 0x7940E0 Offset: 0x7932E0 VA: 0x1807940E0 Slot: 52
	public override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	// RVA: 0x794100 Offset: 0x793300 VA: 0x180794100 Slot: 53
	public override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName) { }

	// RVA: 0x794360 Offset: 0x793560 VA: 0x180794360 Slot: 54
	public override string GetMouseElementAssignmentPollingWindowMessage(string actionName) { }

	// RVA: 0x794350 Offset: 0x793550 VA: 0x180794350 Slot: 55
	public override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName) { }

	// RVA: 0x793C80 Offset: 0x792E80 VA: 0x180793C80 Slot: 56
	public override string GetElementAlreadyInUseBlocked(string elementName) { }

	// RVA: 0x793C90 Offset: 0x792E90 VA: 0x180793C90 Slot: 57
	public override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts) { }

	// RVA: 0x794340 Offset: 0x793540 VA: 0x180794340 Slot: 58
	public override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName) { }

	// RVA: 0x793B20 Offset: 0x792D20 VA: 0x180793B20 Slot: 59
	public override string GetCalibrateAxisStep1WindowMessage(string axisName) { }

	// RVA: 0x793B30 Offset: 0x792D30 VA: 0x180793B30 Slot: 60
	public override string GetCalibrateAxisStep2WindowMessage(string axisName) { }

	// RVA: 0x794370 Offset: 0x793570 VA: 0x180794370 Slot: 61
	public override string GetPlayerName(int playerId) { }

	// RVA: 0x793B60 Offset: 0x792D60 VA: 0x180793B60 Slot: 62
	public override string GetControllerName(Controller controller) { }

	// RVA: 0x793CC0 Offset: 0x792EC0 VA: 0x180793CC0 Slot: 63
	public override string GetElementIdentifierName(ActionElementMap actionElementMap) { }

	// RVA: 0x793E40 Offset: 0x793040 VA: 0x180793E40 Slot: 64
	public override string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange) { }

	// RVA: 0x793FC0 Offset: 0x7931C0 VA: 0x180793FC0 Slot: 65
	public override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x7937C0 Offset: 0x7929C0 VA: 0x1807937C0 Slot: 66
	public override string GetActionName(int actionId) { }

	// RVA: 0x7938B0 Offset: 0x792AB0 VA: 0x1807938B0 Slot: 67
	public override string GetActionName(int actionId, AxisRange axisRange) { }

	// RVA: 0x794250 Offset: 0x793450 VA: 0x180794250 Slot: 68
	public override string GetMapCategoryName(int id) { }

	// RVA: 0x7936D0 Offset: 0x7928D0 VA: 0x1807936D0 Slot: 69
	public override string GetActionCategoryName(int id) { }

	// RVA: 0x794110 Offset: 0x793310 VA: 0x180794110 Slot: 70
	public override string GetLayoutName(ControllerType controllerType, int id) { }

	// RVA: 0x7944A0 Offset: 0x7936A0 VA: 0x1807944A0 Slot: 71
	public override string ModifierKeyFlagsToString(ModifierKeyFlags flags) { }

	// RVA: 0x794710 Offset: 0x793910 VA: 0x180794710
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[Serializable]
public abstract class LanguageDataBase : ScriptableObject // TypeDefIndex: 2129
{
	// Properties
	public bool isLocalizationSystemEnabled { get; }
	public abstract string yes { get; }
	public abstract string no { get; }
	public abstract string add { get; }
	public abstract string replace { get; }
	public abstract string remove { get; }
	public abstract string swap { get; }
	public abstract string cancel { get; }
	public abstract string none { get; }
	public abstract string okay { get; }
	public abstract string done { get; }
	public abstract string default_ { get; }
	public abstract string assignControllerWindowTitle { get; }
	public abstract string assignControllerWindowMessage { get; }
	public abstract string controllerAssignmentConflictWindowTitle { get; }
	public abstract string elementAssignmentPrePollingWindowMessage { get; }
	public abstract string elementAssignmentConflictWindowMessage { get; }
	public abstract string mouseAssignmentConflictWindowTitle { get; }
	public abstract string calibrateControllerWindowTitle { get; }
	public abstract string calibrateAxisStep1WindowTitle { get; }
	public abstract string calibrateAxisStep2WindowTitle { get; }
	public abstract string inputBehaviorSettingsWindowTitle { get; }
	public abstract string restoreDefaultsWindowTitle { get; }
	public abstract string actionColumnLabel { get; }
	public abstract string keyboardColumnLabel { get; }
	public abstract string mouseColumnLabel { get; }
	public abstract string controllerColumnLabel { get; }
	public abstract string removeControllerButtonLabel { get; }
	public abstract string calibrateControllerButtonLabel { get; }
	public abstract string assignControllerButtonLabel { get; }
	public abstract string inputBehaviorSettingsButtonLabel { get; }
	public abstract string doneButtonLabel { get; }
	public abstract string restoreDefaultsButtonLabel { get; }
	public abstract string controllerSettingsGroupLabel { get; }
	public abstract string playersGroupLabel { get; }
	public abstract string assignedControllersGroupLabel { get; }
	public abstract string settingsGroupLabel { get; }
	public abstract string mapCategoriesGroupLabel { get; }
	public abstract string restoreDefaultsWindowMessage { get; }
	public abstract string calibrateWindow_deadZoneSliderLabel { get; }
	public abstract string calibrateWindow_zeroSliderLabel { get; }
	public abstract string calibrateWindow_sensitivitySliderLabel { get; }
	public abstract string calibrateWindow_invertToggleLabel { get; }
	public abstract string calibrateWindow_calibrateButtonLabel { get; }

	// Methods

	// RVA: 0x7935F0 Offset: 0x7927F0 VA: 0x1807935F0
	public bool get_isLocalizationSystemEnabled() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetCustomEntry(string key);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ContainsCustomEntryKey(string key);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_yes();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_no();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_add();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_replace();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_remove();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_swap();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_cancel();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string get_none();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string get_okay();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string get_done();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract string get_default_();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string get_assignControllerWindowTitle();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract string get_assignControllerWindowMessage();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract string get_controllerAssignmentConflictWindowTitle();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract string get_elementAssignmentPrePollingWindowMessage();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string get_elementAssignmentConflictWindowMessage();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string get_mouseAssignmentConflictWindowTitle();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string get_calibrateControllerWindowTitle();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_calibrateAxisStep1WindowTitle();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_calibrateAxisStep2WindowTitle();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_inputBehaviorSettingsWindowTitle();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_restoreDefaultsWindowTitle();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string get_actionColumnLabel();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string get_keyboardColumnLabel();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string get_mouseColumnLabel();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract string get_controllerColumnLabel();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract string get_removeControllerButtonLabel();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract string get_calibrateControllerButtonLabel();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract string get_assignControllerButtonLabel();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_inputBehaviorSettingsButtonLabel();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string get_doneButtonLabel();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract string get_restoreDefaultsButtonLabel();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract string get_controllerSettingsGroupLabel();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract string get_playersGroupLabel();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract string get_assignedControllersGroupLabel();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract string get_settingsGroupLabel();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string get_mapCategoriesGroupLabel();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string get_restoreDefaultsWindowMessage();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string get_calibrateWindow_deadZoneSliderLabel();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string get_calibrateWindow_zeroSliderLabel();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string get_calibrateWindow_sensitivitySliderLabel();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string get_calibrateWindow_invertToggleLabel();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string get_calibrateWindow_calibrateButtonLabel();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract string GetElementAlreadyInUseBlocked(string elementName);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract string GetCalibrateAxisStep1WindowMessage(string axisName);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract string GetCalibrateAxisStep2WindowMessage(string axisName);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract string GetPlayerName(int playerId);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract string GetControllerName(Controller controller);

	// RVA: -1 Offset: -1 Slot: 63
	public abstract string GetElementIdentifierName(ActionElementMap actionElementMap);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange);

	// RVA: -1 Offset: -1 Slot: 65
	public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract string GetActionName(int actionId);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract string GetActionName(int actionId, AxisRange axisRange);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract string GetMapCategoryName(int id);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract string GetActionCategoryName(int id);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract string GetLayoutName(ControllerType controllerType, int id);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class ScrollbarVisibilityHelper : MonoBehaviour // TypeDefIndex: 2130
{
	// Fields
	public ScrollRect scrollRect; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
[RequireComponent(typeof(Selectable))]
public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler // TypeDefIndex: 2131
{
	// Fields
	public bool useCustomEdgePadding; // 0x20
	public float customEdgePadding; // 0x24
	private ScrollRect parentScrollRect; // 0x28
	private Selectable _selectable; // 0x30

	// Properties
	private RectTransform parentScrollRectContentTransform { get; }
	private Selectable selectable { get; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x796620 Offset: 0x795820 VA: 0x180796620
	private RectTransform get_parentScrollRectContentTransform() { }

	// RVA: 0x7966A0 Offset: 0x7958A0 VA: 0x1807966A0
	private Selectable get_selectable() { }

	// RVA: 0x796640 Offset: 0x795840 VA: 0x180796640
	private RectTransform get_rectTransform() { }

	// RVA: 0x796530 Offset: 0x795730 VA: 0x180796530
	private void Start() { }

	// RVA: 0x796100 Offset: 0x795300 VA: 0x180796100 Slot: 4
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x796610 Offset: 0x795810 VA: 0x180796610
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ThemedElement.ElementInfo // TypeDefIndex: 2132
{
	// Fields
	[SerializeField]
	private string _themeClass; // 0x10
	[SerializeField]
	private Component _component; // 0x18

	// Properties
	public string themeClass { get; }
	public Component component { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_themeClass() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Component get_component() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class ThemedElement : MonoBehaviour // TypeDefIndex: 2133
{
	// Fields
	[SerializeField]
	private ThemedElement.ElementInfo[] _elements; // 0x20

	// Methods

	// RVA: 0x7985F0 Offset: 0x7977F0 VA: 0x1807985F0
	private void Start() { }

	// RVA: 0x798610 Offset: 0x797810 VA: 0x180798610
	private void OnEnable() { }

	// RVA: 0x798600 Offset: 0x797800 VA: 0x180798600
	private void OnDisable() { }

	// RVA: 0x7985F0 Offset: 0x7977F0 VA: 0x1807985F0
	public void ApplyTheme() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private abstract class ThemeSettings.SelectableSettings_Base // TypeDefIndex: 2134
{
	// Fields
	[SerializeField]
	protected Selectable.Transition _transition; // 0x10
	[SerializeField]
	protected ThemeSettings.CustomColorBlock _colors; // 0x14
	[SerializeField]
	protected ThemeSettings.CustomSpriteState _spriteState; // 0x80
	[SerializeField]
	protected ThemeSettings.CustomAnimationTriggers _animationTriggers; // 0xA8

	// Properties
	public Selectable.Transition transition { get; }
	public ThemeSettings.CustomColorBlock selectableColors { get; }
	public ThemeSettings.CustomSpriteState spriteState { get; }
	public ThemeSettings.CustomAnimationTriggers animationTriggers { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Selectable.Transition get_transition() { }

	// RVA: 0x7970C0 Offset: 0x7962C0 VA: 0x1807970C0
	public ThemeSettings.CustomColorBlock get_selectableColors() { }

	// RVA: 0x797100 Offset: 0x796300 VA: 0x180797100
	public ThemeSettings.CustomSpriteState get_spriteState() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public ThemeSettings.CustomAnimationTriggers get_animationTriggers() { }

	// RVA: 0x796B00 Offset: 0x795D00 VA: 0x180796B00 Slot: 4
	public virtual void Apply(Selectable item) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.SelectableSettings : ThemeSettings.SelectableSettings_Base // TypeDefIndex: 2135
{
	// Fields
	[SerializeField]
	private ThemeSettings.ImageSettings _imageSettings; // 0xB0

	// Properties
	public ThemeSettings.ImageSettings imageSettings { get; }

	// Methods

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public ThemeSettings.ImageSettings get_imageSettings() { }

	// RVA: 0x796A00 Offset: 0x795C00 VA: 0x180796A00 Slot: 4
	public override void Apply(Selectable item) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.SliderSettings : ThemeSettings.SelectableSettings_Base // TypeDefIndex: 2136
{
	// Fields
	[SerializeField]
	private ThemeSettings.ImageSettings _handleImageSettings; // 0xB0
	[SerializeField]
	private ThemeSettings.ImageSettings _fillImageSettings; // 0xB8
	[SerializeField]
	private ThemeSettings.ImageSettings _backgroundImageSettings; // 0xC0

	// Properties
	public ThemeSettings.ImageSettings handleImageSettings { get; }
	public ThemeSettings.ImageSettings fillImageSettings { get; }
	public ThemeSettings.ImageSettings backgroundImageSettings { get; }

	// Methods

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public ThemeSettings.ImageSettings get_handleImageSettings() { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public ThemeSettings.ImageSettings get_fillImageSettings() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	public ThemeSettings.ImageSettings get_backgroundImageSettings() { }

	// RVA: 0x7971C0 Offset: 0x7963C0 VA: 0x1807971C0
	private void Apply(Slider item) { }

	// RVA: 0x797130 Offset: 0x796330 VA: 0x180797130 Slot: 4
	public override void Apply(Selectable item) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.ScrollbarSettings : ThemeSettings.SelectableSettings_Base // TypeDefIndex: 2137
{
	// Fields
	[SerializeField]
	private ThemeSettings.ImageSettings _handleImageSettings; // 0xB0
	[SerializeField]
	private ThemeSettings.ImageSettings _backgroundImageSettings; // 0xB8

	// Properties
	public ThemeSettings.ImageSettings handle { get; }
	public ThemeSettings.ImageSettings background { get; }

	// Methods

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public ThemeSettings.ImageSettings get_handle() { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	public ThemeSettings.ImageSettings get_background() { }

	// RVA: 0x7966F0 Offset: 0x7958F0 VA: 0x1807966F0
	private void Apply(Scrollbar item) { }

	// RVA: 0x796830 Offset: 0x795A30 VA: 0x180796830 Slot: 4
	public override void Apply(Selectable item) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.ImageSettings // TypeDefIndex: 2138
{
	// Fields
	[SerializeField]
	private Color _color; // 0x10
	[SerializeField]
	private Sprite _sprite; // 0x20
	[SerializeField]
	private Material _materal; // 0x28
	[SerializeField]
	private Image.Type _type; // 0x30
	[SerializeField]
	private bool _preserveAspect; // 0x34
	[SerializeField]
	private bool _fillCenter; // 0x35
	[SerializeField]
	private Image.FillMethod _fillMethod; // 0x38
	[SerializeField]
	private float _fillAmout; // 0x3C
	[SerializeField]
	private bool _fillClockwise; // 0x40
	[SerializeField]
	private int _fillOrigin; // 0x44

	// Properties
	public Color color { get; }
	public Sprite sprite { get; }
	public Material materal { get; }
	public Image.Type type { get; }
	public bool preserveAspect { get; }
	public bool fillCenter { get; }
	public Image.FillMethod fillMethod { get; }
	public float fillAmout { get; }
	public bool fillClockwise { get; }
	public int fillOrigin { get; }

	// Methods

	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Color get_color() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Sprite get_sprite() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Material get_materal() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public Image.Type get_type() { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_preserveAspect() { }

	// RVA: 0x78E670 Offset: 0x78D870 VA: 0x18078E670
	public bool get_fillCenter() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x5D01F0 Offset: 0x5CF3F0 VA: 0x1805D01F0
	public float get_fillAmout() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_fillClockwise() { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public int get_fillOrigin() { }

	// RVA: 0x78E520 Offset: 0x78D720 VA: 0x18078E520 Slot: 4
	public virtual void CopyTo(Image image) { }

	// RVA: 0x78E650 Offset: 0x78D850 VA: 0x18078E650
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private struct ThemeSettings.CustomColorBlock // TypeDefIndex: 2139
{
	// Fields
	[SerializeField]
	private float m_ColorMultiplier; // 0x0
	[SerializeField]
	private Color m_DisabledColor; // 0x4
	[SerializeField]
	private float m_FadeDuration; // 0x14
	[SerializeField]
	private Color m_HighlightedColor; // 0x18
	[SerializeField]
	private Color m_NormalColor; // 0x28
	[SerializeField]
	private Color m_PressedColor; // 0x38
	[SerializeField]
	private Color m_SelectedColor; // 0x48
	[SerializeField]
	private Color m_DisabledHighlightedColor; // 0x58

	// Properties
	public float colorMultiplier { get; set; }
	public Color disabledColor { get; set; }
	public float fadeDuration { get; set; }
	public Color highlightedColor { get; set; }
	public Color normalColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledHighlightedColor { get; set; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_colorMultiplier() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_colorMultiplier(float value) { }

	// RVA: 0x789960 Offset: 0x788B60 VA: 0x180789960
	public Color get_disabledColor() { }

	// RVA: 0x789B10 Offset: 0x788D10 VA: 0x180789B10
	public void set_disabledColor(Color value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_fadeDuration() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_fadeDuration(float value) { }

	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Color get_highlightedColor() { }

	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_highlightedColor(Color value) { }

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Color get_normalColor() { }

	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_normalColor(Color value) { }

	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	public Color get_pressedColor() { }

	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	public void set_pressedColor(Color value) { }

	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0
	public Color get_selectedColor() { }

	// RVA: 0x528FF0 Offset: 0x5281F0 VA: 0x180528FF0
	public void set_selectedColor(Color value) { }

	// RVA: 0x789970 Offset: 0x788B70 VA: 0x180789970
	public Color get_disabledHighlightedColor() { }

	// RVA: 0x789B20 Offset: 0x788D20 VA: 0x180789B20
	public void set_disabledHighlightedColor(Color value) { }

	// RVA: 0x789980 Offset: 0x788B80 VA: 0x180789980
	public static ColorBlock op_Implicit(ThemeSettings.CustomColorBlock item) { }
}

// Namespace: 
[Serializable]
private struct ThemeSettings.CustomSpriteState // TypeDefIndex: 2140
{
	// Fields
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x0
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x8
	[SerializeField]
	private Sprite m_PressedSprite; // 0x10
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x18
	[SerializeField]
	private Sprite m_DisabledHighlightedSprite; // 0x20

	// Properties
	public Sprite disabledSprite { get; set; }
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledHighlightedSprite { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Sprite get_disabledSprite() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Sprite get_highlightedSprite() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Sprite get_pressedSprite() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Sprite get_selectedSprite() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Sprite get_disabledHighlightedSprite() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_disabledHighlightedSprite(Sprite value) { }

	// RVA: 0x78AD80 Offset: 0x789F80 VA: 0x18078AD80
	public static SpriteState op_Implicit(ThemeSettings.CustomSpriteState item) { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.CustomAnimationTriggers // TypeDefIndex: 2141
{
	// Fields
	[SerializeField]
	private string m_DisabledTrigger; // 0x10
	[SerializeField]
	private string m_HighlightedTrigger; // 0x18
	[SerializeField]
	private string m_NormalTrigger; // 0x20
	[SerializeField]
	private string m_PressedTrigger; // 0x28
	[SerializeField]
	private string m_SelectedTrigger; // 0x30
	[SerializeField]
	private string m_DisabledHighlightedTrigger; // 0x38

	// Properties
	public string disabledTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string normalTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledHighlightedTrigger { get; set; }

	// Methods

	// RVA: 0x788500 Offset: 0x787700 VA: 0x180788500
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_disabledTrigger() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_disabledTrigger(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_highlightedTrigger() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_normalTrigger() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_normalTrigger(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_pressedTrigger() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_pressedTrigger(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_selectedTrigger() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_selectedTrigger(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_disabledHighlightedTrigger() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_disabledHighlightedTrigger(string value) { }

	// RVA: 0x7885C0 Offset: 0x7877C0 VA: 0x1807885C0
	public static AnimationTriggers op_Implicit(ThemeSettings.CustomAnimationTriggers item) { }
}

// Namespace: 
[Serializable]
private class ThemeSettings.TextSettings // TypeDefIndex: 2142
{
	// Fields
	[SerializeField]
	private Color _color; // 0x10
	[SerializeField]
	private TMP_FontAsset _font; // 0x20
	[SerializeField]
	private ThemeSettings.FontStyleOverride _style; // 0x28
	[SerializeField]
	private float _sizeMultiplier; // 0x2C
	[SerializeField]
	private float _lineSpacing; // 0x30
	[SerializeField]
	private float _characterSpacing; // 0x34
	[SerializeField]
	private float _wordSpacing; // 0x38

	// Properties
	public Color color { get; }
	public TMP_FontAsset font { get; }
	public ThemeSettings.FontStyleOverride style { get; }
	public float sizeMultiplier { get; }
	public float lineSpacing { get; }
	public float chracterSpacing { get; }
	public float wordSpacing { get; }

	// Methods

	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Color get_color() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TMP_FontAsset get_font() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ThemeSettings.FontStyleOverride get_style() { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float get_sizeMultiplier() { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_lineSpacing() { }

	// RVA: 0x7974C0 Offset: 0x7966C0 VA: 0x1807974C0
	public float get_chracterSpacing() { }

	// RVA: 0x7974D0 Offset: 0x7966D0 VA: 0x1807974D0
	public float get_wordSpacing() { }

	// RVA: 0x797490 Offset: 0x796690 VA: 0x180797490
	public void .ctor() { }
}

// Namespace: 
private enum ThemeSettings.FontStyleOverride // TypeDefIndex: 2143
{
	// Fields
	public int value__; // 0x0
	public const ThemeSettings.FontStyleOverride Default = 0;
	public const ThemeSettings.FontStyleOverride Normal = 1;
	public const ThemeSettings.FontStyleOverride Bold = 2;
	public const ThemeSettings.FontStyleOverride Italic = 3;
	public const ThemeSettings.FontStyleOverride BoldAndItalic = 4;
}

// Namespace: Rewired.UI.ControlMapper
[Serializable]
public class ThemeSettings : ScriptableObject // TypeDefIndex: 2144
{
	// Fields
	[SerializeField]
	private ThemeSettings.ImageSettings _mainWindowBackground; // 0x18
	[SerializeField]
	private ThemeSettings.ImageSettings _popupWindowBackground; // 0x20
	[SerializeField]
	private ThemeSettings.ImageSettings _areaBackground; // 0x28
	[SerializeField]
	private ThemeSettings.SelectableSettings _selectableSettings; // 0x30
	[SerializeField]
	private ThemeSettings.SelectableSettings _buttonSettings; // 0x38
	[SerializeField]
	private ThemeSettings.SelectableSettings _inputGridFieldSettings; // 0x40
	[SerializeField]
	private ThemeSettings.ScrollbarSettings _scrollbarSettings; // 0x48
	[SerializeField]
	private ThemeSettings.SliderSettings _sliderSettings; // 0x50
	[SerializeField]
	private ThemeSettings.ImageSettings _invertToggle; // 0x58
	[SerializeField]
	private Color _invertToggleDisabledColor; // 0x60
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationBackground; // 0x70
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationValueMarker; // 0x78
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationRawValueMarker; // 0x80
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationZeroMarker; // 0x88
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker; // 0x90
	[SerializeField]
	private ThemeSettings.ImageSettings _calibrationDeadzone; // 0x98
	[SerializeField]
	private ThemeSettings.TextSettings _textSettings; // 0xA0
	[SerializeField]
	private ThemeSettings.TextSettings _buttonTextSettings; // 0xA8
	[SerializeField]
	private ThemeSettings.TextSettings _inputGridFieldTextSettings; // 0xB0

	// Methods

	// RVA: 0x797BB0 Offset: 0x796DB0 VA: 0x180797BB0
	public void Apply(ThemedElement.ElementInfo[] elementInfo) { }

	// RVA: 0x797680 Offset: 0x796880 VA: 0x180797680
	private void Apply(string themeClass, Component component) { }

	// RVA: 0x797E90 Offset: 0x797090 VA: 0x180797E90
	private void Apply(string themeClass, Selectable item) { }

	// RVA: 0x798170 Offset: 0x797370 VA: 0x180798170
	private void Apply(string themeClass, Image item) { }

	// RVA: 0x797C20 Offset: 0x796E20 VA: 0x180797C20
	private void Apply(string themeClass, TMP_Text item) { }

	// RVA: 0x7974E0 Offset: 0x7966E0 VA: 0x1807974E0
	private void Apply(string themeClass, UIImageHelper item) { }

	// RVA: 0x798560 Offset: 0x797760 VA: 0x180798560
	private static FontStyles GetFontStyle(ThemeSettings.FontStyleOverride style) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class ToggleInfo : InputFieldInfo // TypeDefIndex: 2145
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class UIControl : MonoBehaviour // TypeDefIndex: 2146
{
	// Fields
	public TMP_Text title; // 0x20
	private int _id; // 0x28
	private bool _showTitle; // 0x2C
	private static int _uidCounter; // 0x0

	// Properties
	public int id { get; }
	public bool showTitle { get; set; }

	// Methods

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_id() { }

	// RVA: 0x79A260 Offset: 0x799460 VA: 0x18079A260
	private void Awake() { }

	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_showTitle() { }

	// RVA: 0x79A320 Offset: 0x799520 VA: 0x18079A320
	public void set_showTitle(bool value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public virtual void SetCancelCallback(Action cancelCallback) { }

	// RVA: 0x79A2C0 Offset: 0x7994C0 VA: 0x18079A2C0
	private static int GetNextUid() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UIControlSet.<>c__DisplayClass6_0 // TypeDefIndex: 2147
{
	// Fields
	public Action<int, float> valueChangedCallback; // 0x10
	public UISliderControl control; // 0x18
	public Action<int> cancelCallback; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799C30 Offset: 0x798E30 VA: 0x180799C30
	internal void <CreateSlider>b__0(float value) { }

	// RVA: 0x799C70 Offset: 0x798E70 VA: 0x180799C70
	internal void <CreateSlider>b__1() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class UIControlSet : MonoBehaviour // TypeDefIndex: 2148
{
	// Fields
	[SerializeField]
	private TMP_Text title; // 0x20
	private Dictionary<int, UIControl> _controls; // 0x28

	// Properties
	private Dictionary<int, UIControl> controls { get; }

	// Methods

	// RVA: 0x79A1F0 Offset: 0x7993F0 VA: 0x18079A1F0
	private Dictionary<int, UIControl> get_controls() { }

	// RVA: 0x79A160 Offset: 0x799360 VA: 0x18079A160
	public void SetTitle(string text) { }

	// RVA: -1 Offset: -1
	public T GetControl<T>(int uniqueId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA970D0 Offset: 0xA962D0 VA: 0x180A970D0
	|-UIControlSet.GetControl<object>
	*/

	// RVA: 0x799D50 Offset: 0x798F50 VA: 0x180799D50
	public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler // TypeDefIndex: 2149
{
	// Fields
	public string identifier; // 0x20
	public int intData; // 0x28
	public TMP_Text text; // 0x30
	[CompilerGenerated]
	private Action<GameObject> OnSelectedEvent; // 0x38

	// Methods

	[CompilerGenerated]
	// RVA: 0x79A400 Offset: 0x799600 VA: 0x18079A400
	public void add_OnSelectedEvent(Action<GameObject> value) { }

	[CompilerGenerated]
	// RVA: 0x79A4B0 Offset: 0x7996B0 VA: 0x18079A4B0
	public void remove_OnSelectedEvent(Action<GameObject> value) { }

	// RVA: 0x79A3C0 Offset: 0x7995C0 VA: 0x18079A3C0 Slot: 4
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class UIGroup : MonoBehaviour // TypeDefIndex: 2150
{
	// Fields
	[SerializeField]
	private TMP_Text _label; // 0x20
	[SerializeField]
	private Transform _content; // 0x28

	// Properties
	public string labelText { get; set; }
	public Transform content { get; }

	// Methods

	// RVA: 0x79A600 Offset: 0x799800 VA: 0x18079A600
	public string get_labelText() { }

	// RVA: 0x79A6B0 Offset: 0x7998B0 VA: 0x18079A6B0
	public void set_labelText(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Transform get_content() { }

	// RVA: 0x79A560 Offset: 0x799760 VA: 0x18079A560
	public void SetLabelActive(bool state) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class UIImageHelper.State // TypeDefIndex: 2151
{
	// Fields
	[SerializeField]
	public Color color; // 0x10

	// Methods

	// RVA: 0x797400 Offset: 0x796600 VA: 0x180797400
	public void Set(Image image) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
[RequireComponent(typeof(Image))]
[AddComponentMenu("")]
public class UIImageHelper : MonoBehaviour // TypeDefIndex: 2152
{
	// Fields
	[SerializeField]
	private UIImageHelper.State enabledState; // 0x20
	[SerializeField]
	private UIImageHelper.State disabledState; // 0x28
	private bool currentState; // 0x30

	// Methods

	// RVA: 0x79A8A0 Offset: 0x799AA0 VA: 0x18079A8A0
	public void SetEnabledState(bool newState) { }

	// RVA: 0x79A880 Offset: 0x799A80 VA: 0x18079A880
	public void SetEnabledStateColor(Color color) { }

	// RVA: 0x79A860 Offset: 0x799A60 VA: 0x18079A860
	public void SetDisabledStateColor(Color color) { }

	// RVA: 0x79A740 Offset: 0x799940 VA: 0x18079A740
	public void Refresh() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
public static class UISelectionUtility // TypeDefIndex: 2153
{
	// Fields
	private static Selectable[] s_reusableAllSelectables; // 0x0

	// Methods

	// RVA: 0x79AA00 Offset: 0x799C00 VA: 0x18079AA00
	public static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction) { }

	// RVA: 0x79B3B0 Offset: 0x79A5B0 VA: 0x18079B3B0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UISliderControl.<>c__DisplayClass10_0 // TypeDefIndex: 2154
{
	// Fields
	public Action cancelCallback; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <SetCancelCallback>b__0() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <SetCancelCallback>b__1(BaseEventData data) { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
public class UISliderControl : UIControl // TypeDefIndex: 2155
{
	// Fields
	public Image iconImage; // 0x30
	public Slider slider; // 0x38
	private bool _showIcon; // 0x40
	private bool _showSlider; // 0x41

	// Properties
	public bool showIcon { get; set; }
	public bool showSlider { get; set; }

	// Methods

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_showIcon() { }

	// RVA: 0x79B7A0 Offset: 0x79A9A0 VA: 0x18079B7A0
	public void set_showIcon(bool value) { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_showSlider() { }

	// RVA: 0x79B840 Offset: 0x79AA40 VA: 0x18079B840
	public void set_showSlider(bool value) { }

	// RVA: 0x79B400 Offset: 0x79A600 VA: 0x18079B400 Slot: 4
	public override void SetCancelCallback(Action cancelCallback) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.UI.ControlMapper
public static class UITools // TypeDefIndex: 2156
{
	// Methods

	// RVA: -1 Offset: -1
	public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA978B0 Offset: 0xA96AB0 VA: 0x180A978B0
	|-UITools.InstantiateGUIObject<object>
	*/

	// RVA: -1 Offset: -1
	public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA97A50 Offset: 0xA96C50 VA: 0x180A97A50
	|-UITools.InstantiateGUIObject<object>
	*/

	// RVA: -1 Offset: -1
	private static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA97680 Offset: 0xA96880 VA: 0x180A97680
	|-UITools.InstantiateGUIObject_Pre<object>
	*/

	// RVA: 0x79B8E0 Offset: 0x79AAE0 VA: 0x18079B8E0
	public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir) { }

	// RVA: 0x79BAA0 Offset: 0x79ACA0 VA: 0x18079BAA0
	public static Rect GetWorldSpaceRect(RectTransform rt) { }

	// RVA: 0x79BEB0 Offset: 0x79B0B0 VA: 0x18079BEB0
	public static Rect TransformRectTo(Transform from, Transform to, Rect rect) { }

	// RVA: 0x79BC80 Offset: 0x79AE80 VA: 0x18079BC80
	public static Rect InvertY(Rect rect) { }

	// RVA: 0x79BCB0 Offset: 0x79AEB0 VA: 0x18079BCB0
	public static void SetInteractable(Selectable selectable, bool state, bool playTransition) { }
}

// Namespace: 
public class Window.Timer // TypeDefIndex: 2157
{
	// Fields
	private bool _started; // 0x10
	private float end; // 0x14

	// Properties
	public bool started { get; }
	public bool finished { get; }
	public float remaining { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_started() { }

	// RVA: 0x798660 Offset: 0x797860 VA: 0x180798660
	public bool get_finished() { }

	// RVA: 0x7986A0 Offset: 0x7978A0 VA: 0x1807986A0
	public float get_remaining() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x798620 Offset: 0x797820 VA: 0x180798620
	public void Start(float length) { }

	// RVA: 0x798650 Offset: 0x797850 VA: 0x180798650
	public void Stop() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Window.<OnEnableAsync>d__64 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2158
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Window <>4__this; // 0x20

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

	// RVA: 0x799460 Offset: 0x798660 VA: 0x180799460 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7995E0 Offset: 0x7987E0 VA: 0x1807995E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.UI.ControlMapper
[AddComponentMenu("")]
[RequireComponent(typeof(CanvasGroup))]
public class Window : MonoBehaviour // TypeDefIndex: 2159
{
	// Fields
	public Image backgroundImage; // 0x20
	public GameObject content; // 0x28
	private bool _initialized; // 0x30
	private int _id; // 0x34
	private RectTransform _rectTransform; // 0x38
	private TMP_Text _titleText; // 0x40
	private List<TMP_Text> _contentText; // 0x48
	private GameObject _defaultUIElement; // 0x50
	private Action<int> _updateCallback; // 0x58
	private Func<int, bool> _isFocusedCallback; // 0x60
	private Window.Timer _timer; // 0x68
	private CanvasGroup _canvasGroup; // 0x70
	public UnityAction cancelCallback; // 0x78
	private GameObject lastUISelection; // 0x80

	// Properties
	public bool hasFocus { get; }
	public int id { get; }
	public RectTransform rectTransform { get; }
	public TMP_Text titleText { get; }
	public List<TMP_Text> contentText { get; }
	public GameObject defaultUIElement { get; set; }
	public Action<int> updateCallback { get; set; }
	public Window.Timer timer { get; }
	public int width { get; set; }
	public int height { get; set; }
	protected bool initialized { get; }

	// Methods

	// RVA: 0x79F1D0 Offset: 0x79E3D0 VA: 0x18079F1D0
	public bool get_hasFocus() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int get_id() { }

	// RVA: 0x79F230 Offset: 0x79E430 VA: 0x18079F230
	public RectTransform get_rectTransform() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public TMP_Text get_titleText() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public List<TMP_Text> get_contentText() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public GameObject get_defaultUIElement() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_defaultUIElement(GameObject value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Action<int> get_updateCallback() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_updateCallback(Action<int> value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public Window.Timer get_timer() { }

	// RVA: 0x79F2D0 Offset: 0x79E4D0 VA: 0x18079F2D0
	public int get_width() { }

	// RVA: 0x79F370 Offset: 0x79E570 VA: 0x18079F370
	public void set_width(int value) { }

	// RVA: 0x79F200 Offset: 0x79E400 VA: 0x18079F200
	public int get_height() { }

	// RVA: 0x79F300 Offset: 0x79E500 VA: 0x18079F300
	public void set_height(int value) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	protected bool get_initialized() { }

	// RVA: 0x79EDC0 Offset: 0x79DFC0 VA: 0x18079EDC0
	private void OnEnable() { }

	// RVA: 0x79F160 Offset: 0x79E360 VA: 0x18079F160 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x79EC40 Offset: 0x79DE40 VA: 0x18079EC40 Slot: 5
	public virtual void Initialize(int id, Func<int, bool> isFocusedCallback) { }

	// RVA: 0x79EFC0 Offset: 0x79E1C0 VA: 0x18079EFC0
	public void SetSize(int width, int height) { }

	// RVA: 0x79E870 Offset: 0x79DA70 VA: 0x18079E870
	public void CreateTitleText(GameObject prefab, Vector2 offset) { }

	// RVA: 0x79E750 Offset: 0x79D950 VA: 0x18079E750
	public void CreateTitleText(GameObject prefab, Vector2 offset, string text) { }

	// RVA: 0x79DB80 Offset: 0x79CD80 VA: 0x18079DB80
	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	// RVA: 0x79D970 Offset: 0x79CB70 VA: 0x18079D970
	public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text) { }

	// RVA: 0x79D7F0 Offset: 0x79C9F0 VA: 0x18079D7F0
	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	// RVA: 0x79D7F0 Offset: 0x79C9F0 VA: 0x18079D7F0
	public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text) { }

	// RVA: 0x79DE90 Offset: 0x79D090 VA: 0x18079DE90
	public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault) { }

	// RVA: 0x79EB90 Offset: 0x79DD90 VA: 0x18079EB90
	public string GetTitleText(string text) { }

	// RVA: 0x79F010 Offset: 0x79E210 VA: 0x18079F010
	public void SetTitleText(string text) { }

	// RVA: 0x79EA80 Offset: 0x79DC80 VA: 0x18079EA80
	public string GetContentText(int index) { }

	// RVA: 0x79E980 Offset: 0x79DB80 VA: 0x18079E980
	public float GetContentTextHeight(int index) { }

	// RVA: 0x79EED0 Offset: 0x79E0D0 VA: 0x18079EED0
	public void SetContentText(string text, int index) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void SetUpdateCallback(Action<int> callback) { }

	// RVA: 0x790170 Offset: 0x78F370 VA: 0x180790170 Slot: 6
	public virtual void TakeInputFocus() { }

	// RVA: 0x79E950 Offset: 0x79DB50 VA: 0x18079E950 Slot: 7
	public virtual void Enable() { }

	// RVA: 0x79E920 Offset: 0x79DB20 VA: 0x18079E920 Slot: 8
	public virtual void Disable() { }

	// RVA: 0x79DC90 Offset: 0x79CE90 VA: 0x18079DC90 Slot: 9
	public virtual void Cancel() { }

	// RVA: 0x79E530 Offset: 0x79D730 VA: 0x18079E530
	private void CreateText(GameObject prefab, ref TMP_Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	// RVA: 0x79E3F0 Offset: 0x79D5F0 VA: 0x18079E3F0
	private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset) { }

	// RVA: 0x79E1A0 Offset: 0x79D3A0 VA: 0x18079E1A0
	private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo) { }

	[IteratorStateMachine(typeof(Window.<OnEnableAsync>d__64))]
	// RVA: 0x79ED60 Offset: 0x79DF60 VA: 0x18079ED60
	private IEnumerator OnEnableAsync() { }

	// RVA: 0x79DCC0 Offset: 0x79CEC0 VA: 0x18079DCC0
	private void CheckUISelection() { }

	// RVA: 0x79EE00 Offset: 0x79E000 VA: 0x18079EE00
	private void RestoreDefaultOrLastUISelection() { }

	// RVA: 0x79F0A0 Offset: 0x79E2A0 VA: 0x18079F0A0
	private void SetUISelection(GameObject selection) { }

	// RVA: 0x790250 Offset: 0x78F450 VA: 0x180790250
	public void .ctor() { }
}

// Namespace: 
private class ControlRemappingDemo1.ControllerSelection // TypeDefIndex: 2160
{
	// Fields
	private int _id; // 0x10
	private int _idPrev; // 0x14
	private ControllerType _type; // 0x18
	private ControllerType _typePrev; // 0x1C

	// Properties
	public int id { get; set; }
	public ControllerType type { get; set; }
	public int idPrev { get; }
	public ControllerType typePrev { get; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x79F9D0 Offset: 0x79EBD0 VA: 0x18079F9D0
	public void .ctor() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x79FA10 Offset: 0x79EC10 VA: 0x18079FA10
	public void set_id(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerType get_type() { }

	// RVA: 0x79FA20 Offset: 0x79EC20 VA: 0x18079FA20
	public void set_type(ControllerType value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_idPrev() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ControllerType get_typePrev() { }

	// RVA: 0x79FA00 Offset: 0x79EC00 VA: 0x18079FA00
	public bool get_hasSelection() { }

	// RVA: 0x79F9B0 Offset: 0x79EBB0 VA: 0x18079F9B0
	public void Set(int id, ControllerType type) { }

	// RVA: 0x79F990 Offset: 0x79EB90 VA: 0x18079F990
	public void Clear() { }
}

// Namespace: 
public enum ControlRemappingDemo1.DialogHelper.DialogType // TypeDefIndex: 2161
{
	// Fields
	public int value__; // 0x0
	public const ControlRemappingDemo1.DialogHelper.DialogType None = 0;
	public const ControlRemappingDemo1.DialogHelper.DialogType JoystickConflict = 1;
	public const ControlRemappingDemo1.DialogHelper.DialogType ElementConflict = 2;
	public const ControlRemappingDemo1.DialogHelper.DialogType KeyConflict = 3;
	public const ControlRemappingDemo1.DialogHelper.DialogType DeleteAssignmentConfirmation = 10;
	public const ControlRemappingDemo1.DialogHelper.DialogType AssignElement = 11;
}

// Namespace: 
private class ControlRemappingDemo1.DialogHelper // TypeDefIndex: 2162
{
	// Fields
	private const float openBusyDelay = 0,25;
	private const float closeBusyDelay = 0,1;
	private ControlRemappingDemo1.DialogHelper.DialogType _type; // 0x10
	private bool _enabled; // 0x14
	private float _busyTime; // 0x18
	private bool _busyTimerRunning; // 0x1C
	private Action<int> drawWindowDelegate; // 0x20
	private GUI.WindowFunction drawWindowFunction; // 0x28
	private ControlRemappingDemo1.WindowProperties windowProperties; // 0x30
	private int currentActionId; // 0x60
	private Action<int, ControlRemappingDemo1.UserResponse> resultCallback; // 0x68

	// Properties
	private float busyTimer { get; }
	public bool enabled { get; set; }
	public ControlRemappingDemo1.DialogHelper.DialogType type { get; set; }
	public bool busy { get; }

	// Methods

	// RVA: 0x7A3280 Offset: 0x7A2480 VA: 0x1807A3280
	private float get_busyTimer() { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_enabled() { }

	// RVA: 0x7A32D0 Offset: 0x7A24D0 VA: 0x1807A32D0
	public void set_enabled(bool value) { }

	// RVA: 0x7A32C0 Offset: 0x7A24C0 VA: 0x1807A32C0
	public ControlRemappingDemo1.DialogHelper.DialogType get_type() { }

	// RVA: 0x7A3330 Offset: 0x7A2530 VA: 0x1807A3330
	public void set_type(ControlRemappingDemo1.DialogHelper.DialogType value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_busy() { }

	// RVA: 0x7A31C0 Offset: 0x7A23C0 VA: 0x1807A31C0
	public void .ctor() { }

	// RVA: 0x7A2FA0 Offset: 0x7A21A0 VA: 0x1807A2FA0
	public void StartModal(int queueActionId, ControlRemappingDemo1.DialogHelper.DialogType type, ControlRemappingDemo1.WindowProperties windowProperties, Action<int, ControlRemappingDemo1.UserResponse> resultCallback) { }

	// RVA: 0x7A2EF0 Offset: 0x7A20F0 VA: 0x1807A2EF0
	public void StartModal(int queueActionId, ControlRemappingDemo1.DialogHelper.DialogType type, ControlRemappingDemo1.WindowProperties windowProperties, Action<int, ControlRemappingDemo1.UserResponse> resultCallback, float openBusyDelay) { }

	// RVA: 0x7A3060 Offset: 0x7A2260 VA: 0x1807A3060
	public void Update() { }

	// RVA: 0x7A2D40 Offset: 0x7A1F40 VA: 0x1807A2D40
	public void Draw() { }

	// RVA: 0x7A2A40 Offset: 0x7A1C40 VA: 0x1807A2A40
	public void DrawConfirmButton() { }

	// RVA: 0x7A28F0 Offset: 0x7A1AF0 VA: 0x1807A28F0
	public void DrawConfirmButton(string title) { }

	// RVA: 0x7A2780 Offset: 0x7A1980 VA: 0x1807A2780
	public void DrawConfirmButton(ControlRemappingDemo1.UserResponse response) { }

	// RVA: 0x7A2BB0 Offset: 0x7A1DB0 VA: 0x1807A2BB0
	public void DrawConfirmButton(ControlRemappingDemo1.UserResponse response, string title) { }

	// RVA: 0x7A2610 Offset: 0x7A1810 VA: 0x1807A2610
	public void DrawCancelButton() { }

	// RVA: 0x7A24C0 Offset: 0x7A16C0 VA: 0x1807A24C0
	public void DrawCancelButton(string title) { }

	// RVA: 0x7A2460 Offset: 0x7A1660 VA: 0x1807A2460
	public void Confirm() { }

	// RVA: 0x7A2400 Offset: 0x7A1600 VA: 0x1807A2400
	public void Confirm(ControlRemappingDemo1.UserResponse response) { }

	// RVA: 0x7A2350 Offset: 0x7A1550 VA: 0x1807A2350
	public void Cancel() { }

	// RVA: 0x7A2D00 Offset: 0x7A1F00 VA: 0x1807A2D00
	private void DrawWindow(int windowId) { }

	// RVA: 0x7A3020 Offset: 0x7A2220 VA: 0x1807A3020
	private void UpdateTimers() { }

	// RVA: 0x7A2EC0 Offset: 0x7A20C0 VA: 0x1807A2EC0
	private void StartBusyTimer(float time) { }

	// RVA: 0x7A23C0 Offset: 0x7A15C0 VA: 0x1807A23C0
	private void Close() { }

	// RVA: 0x7A2EC0 Offset: 0x7A20C0 VA: 0x1807A2EC0
	private void StateChanged(float delay) { }

	// RVA: 0x7A2EA0 Offset: 0x7A20A0 VA: 0x1807A2EA0
	private void Reset() { }

	// RVA: 0x6CE870 Offset: 0x6CDA70 VA: 0x1806CE870
	private void ResetTimers() { }

	// RVA: 0x7A2E80 Offset: 0x7A2080 VA: 0x1807A2E80
	public void FullReset() { }
}

// Namespace: 
public enum ControlRemappingDemo1.QueueEntry.State // TypeDefIndex: 2163
{
	// Fields
	public int value__; // 0x0
	public const ControlRemappingDemo1.QueueEntry.State Waiting = 0;
	public const ControlRemappingDemo1.QueueEntry.State Confirmed = 1;
	public const ControlRemappingDemo1.QueueEntry.State Canceled = 2;
}

// Namespace: 
private abstract class ControlRemappingDemo1.QueueEntry // TypeDefIndex: 2164
{
	// Fields
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x10
	[CompilerGenerated]
	private ControlRemappingDemo1.QueueActionType <queueActionType>k__BackingField; // 0x14
	[CompilerGenerated]
	private ControlRemappingDemo1.QueueEntry.State <state>k__BackingField; // 0x18
	[CompilerGenerated]
	private ControlRemappingDemo1.UserResponse <response>k__BackingField; // 0x1C
	private static int uidCounter; // 0x0

	// Properties
	public int id { get; set; }
	public ControlRemappingDemo1.QueueActionType queueActionType { get; set; }
	public ControlRemappingDemo1.QueueEntry.State state { get; set; }
	public ControlRemappingDemo1.UserResponse response { get; set; }
	protected static int nextId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	protected void set_id(int value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ControlRemappingDemo1.QueueActionType get_queueActionType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	protected void set_queueActionType(ControlRemappingDemo1.QueueActionType value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControlRemappingDemo1.QueueEntry.State get_state() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	protected void set_state(ControlRemappingDemo1.QueueEntry.State value) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ControlRemappingDemo1.UserResponse get_response() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	protected void set_response(ControlRemappingDemo1.UserResponse value) { }

	// RVA: 0x7B0F20 Offset: 0x7B0120 VA: 0x1807B0F20
	protected static int get_nextId() { }

	// RVA: 0x7B0EC0 Offset: 0x7B00C0 VA: 0x1807B0EC0
	public void .ctor(ControlRemappingDemo1.QueueActionType queueActionType) { }

	// RVA: 0x7B0EB0 Offset: 0x7B00B0 VA: 0x1807B0EB0
	public void Confirm(ControlRemappingDemo1.UserResponse response) { }

	// RVA: 0x7B0EA0 Offset: 0x7B00A0 VA: 0x1807B0EA0
	public void Cancel() { }
}

// Namespace: 
private class ControlRemappingDemo1.JoystickAssignmentChange : ControlRemappingDemo1.QueueEntry // TypeDefIndex: 2165
{
	// Fields
	[CompilerGenerated]
	private int <playerId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <joystickId>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <assign>k__BackingField; // 0x28

	// Properties
	public int playerId { get; set; }
	public int joystickId { get; set; }
	public bool assign { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_playerId() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void set_playerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_joystickId() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	private void set_joystickId(int value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_assign() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	private void set_assign(bool value) { }

	// RVA: 0x7AA830 Offset: 0x7A9A30 VA: 0x1807AA830
	public void .ctor(int newPlayerId, int joystickId, bool assign) { }
}

// Namespace: 
private class ControlRemappingDemo1.ElementAssignmentChange : ControlRemappingDemo1.QueueEntry // TypeDefIndex: 2166
{
	// Fields
	[CompilerGenerated]
	private ControlRemappingDemo1.ElementAssignmentChangeType <changeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private InputMapper.Context <context>k__BackingField; // 0x28

	// Properties
	public ControlRemappingDemo1.ElementAssignmentChangeType changeType { get; set; }
	public InputMapper.Context context { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ControlRemappingDemo1.ElementAssignmentChangeType get_changeType() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_changeType(ControlRemappingDemo1.ElementAssignmentChangeType value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public InputMapper.Context get_context() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_context(InputMapper.Context value) { }

	// RVA: 0x7A56B0 Offset: 0x7A48B0 VA: 0x1807A56B0
	public void .ctor(ControlRemappingDemo1.ElementAssignmentChangeType changeType, InputMapper.Context context) { }

	// RVA: 0x7A5610 Offset: 0x7A4810 VA: 0x1807A5610
	public void .ctor(ControlRemappingDemo1.ElementAssignmentChange other) { }
}

// Namespace: 
private class ControlRemappingDemo1.FallbackJoystickIdentification : ControlRemappingDemo1.QueueEntry // TypeDefIndex: 2167
{
	// Fields
	[CompilerGenerated]
	private int <joystickId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <joystickName>k__BackingField; // 0x28

	// Properties
	public int joystickId { get; set; }
	public string joystickName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_joystickId() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void set_joystickId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_joystickName() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_joystickName(string value) { }

	// RVA: 0x7A6170 Offset: 0x7A5370 VA: 0x1807A6170
	public void .ctor(int joystickId, string joystickName) { }
}

// Namespace: 
private class ControlRemappingDemo1.Calibration : ControlRemappingDemo1.QueueEntry // TypeDefIndex: 2168
{
	// Fields
	[CompilerGenerated]
	private Player <player>k__BackingField; // 0x20
	[CompilerGenerated]
	private ControllerType <controllerType>k__BackingField; // 0x28
	[CompilerGenerated]
	private Joystick <joystick>k__BackingField; // 0x30
	[CompilerGenerated]
	private CalibrationMap <calibrationMap>k__BackingField; // 0x38
	public int selectedElementIdentifierId; // 0x40
	public bool recording; // 0x44

	// Properties
	public Player player { get; set; }
	public ControllerType controllerType { get; set; }
	public Joystick joystick { get; set; }
	public CalibrationMap calibrationMap { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Player get_player() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_player(Player value) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ControllerType get_controllerType() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	private void set_controllerType(ControllerType value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Joystick get_joystick() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_joystick(Joystick value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public CalibrationMap get_calibrationMap() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_calibrationMap(CalibrationMap value) { }

	// RVA: 0x79F520 Offset: 0x79E720 VA: 0x18079F520
	public void .ctor(Player player, Joystick joystick, CalibrationMap calibrationMap) { }
}

// Namespace: 
private struct ControlRemappingDemo1.WindowProperties // TypeDefIndex: 2169
{
	// Fields
	public int windowId; // 0x0
	public Rect rect; // 0x4
	public Action<string, string> windowDrawDelegate; // 0x18
	public string title; // 0x20
	public string message; // 0x28
}

// Namespace: 
private enum ControlRemappingDemo1.QueueActionType // TypeDefIndex: 2170
{
	// Fields
	public int value__; // 0x0
	public const ControlRemappingDemo1.QueueActionType None = 0;
	public const ControlRemappingDemo1.QueueActionType JoystickAssignment = 1;
	public const ControlRemappingDemo1.QueueActionType ElementAssignment = 2;
	public const ControlRemappingDemo1.QueueActionType FallbackJoystickIdentification = 3;
	public const ControlRemappingDemo1.QueueActionType Calibrate = 4;
}

// Namespace: 
private enum ControlRemappingDemo1.ElementAssignmentChangeType // TypeDefIndex: 2171
{
	// Fields
	public int value__; // 0x0
	public const ControlRemappingDemo1.ElementAssignmentChangeType Add = 0;
	public const ControlRemappingDemo1.ElementAssignmentChangeType Replace = 1;
	public const ControlRemappingDemo1.ElementAssignmentChangeType Remove = 2;
	public const ControlRemappingDemo1.ElementAssignmentChangeType ReassignOrRemove = 3;
	public const ControlRemappingDemo1.ElementAssignmentChangeType ConflictCheck = 4;
}

// Namespace: 
public enum ControlRemappingDemo1.UserResponse // TypeDefIndex: 2172
{
	// Fields
	public int value__; // 0x0
	public const ControlRemappingDemo1.UserResponse Confirm = 0;
	public const ControlRemappingDemo1.UserResponse Cancel = 1;
	public const ControlRemappingDemo1.UserResponse Custom1 = 2;
	public const ControlRemappingDemo1.UserResponse Custom2 = 3;
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class ControlRemappingDemo1 : MonoBehaviour // TypeDefIndex: 2173
{
	// Fields
	private const float defaultModalWidth = 250;
	private const float defaultModalHeight = 200;
	private const float assignmentTimeout = 5;
	private ControlRemappingDemo1.DialogHelper dialog; // 0x20
	private InputMapper inputMapper; // 0x28
	private InputMapper.ConflictFoundEventData conflictFoundEventData; // 0x30
	private bool guiState; // 0x38
	private bool busy; // 0x39
	private bool pageGUIState; // 0x3A
	private Player selectedPlayer; // 0x40
	private int selectedMapCategoryId; // 0x48
	private ControlRemappingDemo1.ControllerSelection selectedController; // 0x50
	private ControllerMap selectedMap; // 0x58
	private bool showMenu; // 0x60
	private bool startListening; // 0x61
	private Vector2 actionScrollPos; // 0x64
	private Vector2 calibrateScrollPos; // 0x6C
	private Queue<ControlRemappingDemo1.QueueEntry> actionQueue; // 0x78
	private bool setupFinished; // 0x80
	private bool initialized; // 0x81
	private bool isCompiling; // 0x82
	private GUIStyle style_wordWrap; // 0x88
	private GUIStyle style_centeredBox; // 0x90

	// Methods

	// RVA: 0x780890 Offset: 0x77FA90 VA: 0x180780890
	private void Awake() { }

	// RVA: 0x786690 Offset: 0x785890 VA: 0x180786690
	private void OnEnable() { }

	// RVA: 0x786670 Offset: 0x785870 VA: 0x180786670
	private void OnDisable() { }

	// RVA: 0x785D10 Offset: 0x784F10 VA: 0x180785D10
	private void Initialize() { }

	// RVA: 0x788360 Offset: 0x787560 VA: 0x180788360
	private void Setup() { }

	// RVA: 0x786690 Offset: 0x785890 VA: 0x180786690
	private void Subscribe() { }

	// RVA: 0x786670 Offset: 0x785870 VA: 0x180786670
	private void Unsubscribe() { }

	// RVA: 0x786790 Offset: 0x785990 VA: 0x180786790
	public void OnGUI() { }

	// RVA: 0x785930 Offset: 0x784B30 VA: 0x180785930
	private void HandleMenuControl() { }

	// RVA: 0x780A10 Offset: 0x77FC10 VA: 0x180780A10
	private void Close() { }

	// RVA: 0x786CC0 Offset: 0x785EC0 VA: 0x180786CC0
	private void Open() { }

	// RVA: 0x783C70 Offset: 0x782E70 VA: 0x180783C70
	private void DrawInitialScreen() { }

	// RVA: 0x7850D0 Offset: 0x7842D0 VA: 0x1807850D0
	private void DrawPage() { }

	// RVA: 0x7852D0 Offset: 0x7844D0 VA: 0x1807852D0
	private void DrawPlayerSelector() { }

	// RVA: 0x784C70 Offset: 0x783E70 VA: 0x180784C70
	private void DrawMouseAssignment() { }

	// RVA: 0x783F50 Offset: 0x783150 VA: 0x180783F50
	private void DrawJoystickSelector() { }

	// RVA: 0x782DC0 Offset: 0x781FC0 VA: 0x180782DC0
	private void DrawControllerSelector() { }

	// RVA: 0x780F50 Offset: 0x780150 VA: 0x180780F50
	private void DrawCalibrateButton() { }

	// RVA: 0x7844D0 Offset: 0x7836D0 VA: 0x1807844D0
	private void DrawMapCategories() { }

	// RVA: 0x782020 Offset: 0x781220 VA: 0x180782020
	private void DrawCategoryActions() { }

	// RVA: 0x780B90 Offset: 0x77FD90 VA: 0x180780B90
	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x783E90 Offset: 0x783090 VA: 0x180783E90
	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x780D90 Offset: 0x77FF90 VA: 0x180780D90
	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControlRemappingDemo1.ControllerSelection controller, ControllerMap controllerMap) { }

	// RVA: 0x788480 Offset: 0x787680 VA: 0x180788480
	private void ShowDialog() { }

	// RVA: 0x784B80 Offset: 0x783D80 VA: 0x180784B80
	private void DrawModalWindow(string title, string message) { }

	// RVA: 0x784AA0 Offset: 0x783CA0 VA: 0x180784AA0
	private void DrawModalWindow_OkayOnly(string title, string message) { }

	// RVA: 0x7837D0 Offset: 0x7829D0 VA: 0x1807837D0
	private void DrawElementAssignmentWindow(string title, string message) { }

	// RVA: 0x783640 Offset: 0x782840 VA: 0x180783640
	private void DrawElementAssignmentProtectedConflictWindow(string title, string message) { }

	// RVA: 0x783480 Offset: 0x782680 VA: 0x180783480
	private void DrawElementAssignmentNormalConflictWindow(string title, string message) { }

	// RVA: 0x7856F0 Offset: 0x7848F0 VA: 0x1807856F0
	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message) { }

	// RVA: 0x783A30 Offset: 0x782C30 VA: 0x180783A30
	private void DrawFallbackJoystickIdentificationWindow(string title, string message) { }

	// RVA: 0x781280 Offset: 0x780480 VA: 0x180781280
	private void DrawCalibrationWindow(string title, string message) { }

	// RVA: 0x780A30 Offset: 0x77FC30 VA: 0x180780A30
	private void DialogResultCallback(int queueActionId, ControlRemappingDemo1.UserResponse response) { }

	// RVA: 0x785890 Offset: 0x784A90 VA: 0x180785890
	private Rect GetScreenCenteredRect(float width, float height) { }

	// RVA: 0x785800 Offset: 0x784A00 VA: 0x180785800
	private void EnqueueAction(ControlRemappingDemo1.QueueEntry entry) { }

	// RVA: 0x787BA0 Offset: 0x786DA0 VA: 0x180787BA0
	private void ProcessQueue() { }

	// RVA: 0x7878A0 Offset: 0x786AA0 VA: 0x1807878A0
	private bool ProcessJoystickAssignmentChange(ControlRemappingDemo1.JoystickAssignmentChange entry) { }

	// RVA: 0x7872A0 Offset: 0x7864A0 VA: 0x1807872A0
	private bool ProcessElementAssignmentChange(ControlRemappingDemo1.ElementAssignmentChange entry) { }

	// RVA: 0x787F70 Offset: 0x787170 VA: 0x180787F70
	private bool ProcessRemoveOrReassignElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry) { }

	// RVA: 0x787D40 Offset: 0x786F40 VA: 0x180787D40
	private bool ProcessRemoveElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry) { }

	// RVA: 0x786CD0 Offset: 0x785ED0 VA: 0x180786CD0
	private bool ProcessAddOrReplaceElementAssignment(ControlRemappingDemo1.ElementAssignmentChange entry) { }

	// RVA: 0x787350 Offset: 0x786550 VA: 0x180787350
	private bool ProcessElementAssignmentConflictCheck(ControlRemappingDemo1.ElementAssignmentChange entry) { }

	// RVA: 0x7876A0 Offset: 0x7868A0 VA: 0x1807876A0
	private bool ProcessFallbackJoystickIdentification(ControlRemappingDemo1.FallbackJoystickIdentification entry) { }

	// RVA: 0x787080 Offset: 0x786280 VA: 0x180787080
	private bool ProcessCalibration(ControlRemappingDemo1.Calibration entry) { }

	// RVA: 0x780910 Offset: 0x77FB10 VA: 0x180780910
	private void PlayerSelectionChanged() { }

	// RVA: 0x780950 Offset: 0x77FB50 VA: 0x180780950
	private void ControllerSelectionChanged() { }

	// RVA: 0x780910 Offset: 0x77FB10 VA: 0x180780910
	private void ClearControllerSelection() { }

	// RVA: 0x780950 Offset: 0x77FB50 VA: 0x180780950
	private void ClearMapSelection() { }

	// RVA: 0x7881F0 Offset: 0x7873F0 VA: 0x1807881F0
	private void ResetAll() { }

	// RVA: 0x780960 Offset: 0x77FB60 VA: 0x180780960
	private void ClearWorkingVars() { }

	// RVA: 0x7882A0 Offset: 0x7874A0 VA: 0x1807882A0
	private void SetGUIStateStart() { }

	// RVA: 0x788220 Offset: 0x787420 VA: 0x180788220
	private void SetGUIStateEnd() { }

	// RVA: 0x785F00 Offset: 0x785100 VA: 0x180785F00
	private void JoystickConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7862E0 Offset: 0x7854E0 VA: 0x1807862E0
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x786270 Offset: 0x785470 VA: 0x180786270
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void OnConflictFound(InputMapper.ConflictFoundEventData data) { }

	// RVA: 0x786CB0 Offset: 0x785EB0 VA: 0x180786CB0
	private void OnStopped(InputMapper.StoppedEventData data) { }

	// RVA: 0x785A50 Offset: 0x784C50 VA: 0x180785A50
	public void IdentifyAllJoysticks() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	protected void CheckRecompile() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void RecompileWindow(int windowId) { }

	// RVA: 0x7884A0 Offset: 0x7876A0 VA: 0x1807884A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class CustomControllersTiltDemo : MonoBehaviour // TypeDefIndex: 2174
{
	// Fields
	public Transform target; // 0x20
	public float speed; // 0x28
	private CustomController controller; // 0x30
	private Player player; // 0x38

	// Methods

	// RVA: 0x7A1760 Offset: 0x7A0960 VA: 0x1807A1760
	private void Awake() { }

	// RVA: 0x7A1940 Offset: 0x7A0B40 VA: 0x1807A1940
	private void Update() { }

	// RVA: 0x7A18B0 Offset: 0x7A0AB0 VA: 0x1807A18B0
	private void OnInputUpdate() { }

	// RVA: 0x7A1BA0 Offset: 0x7A0DA0 VA: 0x1807A1BA0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class CustomControllerDemo : MonoBehaviour // TypeDefIndex: 2175
{
	// Fields
	public int playerId; // 0x20
	public string controllerTag; // 0x28
	public bool useUpdateCallbacks; // 0x30
	private int buttonCount; // 0x34
	private int axisCount; // 0x38
	private float[] axisValues; // 0x40
	private bool[] buttonValues; // 0x48
	private TouchJoystickExample[] joysticks; // 0x50
	private TouchButtonExample[] buttons; // 0x58
	private CustomController controller; // 0x60
	private bool initialized; // 0x68

	// Methods

	// RVA: 0x7A0910 Offset: 0x79FB10 VA: 0x1807A0910
	private void Awake() { }

	// RVA: 0x7A0B10 Offset: 0x79FD10 VA: 0x1807A0B10
	private void Initialize() { }

	// RVA: 0x7A16C0 Offset: 0x7A08C0 VA: 0x1807A16C0
	private void Update() { }

	// RVA: 0x7A0E40 Offset: 0x7A0040 VA: 0x1807A0E40
	private void OnInputSourceUpdate() { }

	// RVA: 0x7A09D0 Offset: 0x79FBD0 VA: 0x1807A09D0
	private void GetSourceAxisValues() { }

	// RVA: 0x7A0A90 Offset: 0x79FC90 VA: 0x1807A0A90
	private void GetSourceButtonValues() { }

	// RVA: 0x7A15C0 Offset: 0x7A07C0 VA: 0x1807A15C0
	private void SetControllerAxisValues() { }

	// RVA: 0x7A1640 Offset: 0x7A0840 VA: 0x1807A1640
	private void SetControllerButtonValues() { }

	// RVA: 0x7A0950 Offset: 0x79FB50 VA: 0x1807A0950
	private float GetAxisValueCallback(int index) { }

	// RVA: 0x7A0990 Offset: 0x79FB90 VA: 0x1807A0990
	private bool GetButtonValueCallback(int index) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("")]
public class CustomControllerDemo_Player : MonoBehaviour // TypeDefIndex: 2176
{
	// Fields
	public int playerId; // 0x20
	public float speed; // 0x24
	public float bulletSpeed; // 0x28
	public GameObject bulletPrefab; // 0x30
	private Player _player; // 0x38
	private CharacterController cc; // 0x40

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7A1550 Offset: 0x7A0750 VA: 0x1807A1550
	private Player get_player() { }

	// RVA: 0x7A1090 Offset: 0x7A0290 VA: 0x1807A1090
	private void Awake() { }

	// RVA: 0x7A10D0 Offset: 0x7A02D0 VA: 0x1807A10D0
	private void Update() { }

	// RVA: 0x7A1530 Offset: 0x7A0730 VA: 0x1807A1530
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
[RequireComponent(typeof(Image))]
public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 2177
{
	// Fields
	public bool allowMouseControl; // 0x20
	[CompilerGenerated]
	private bool <isPressed>k__BackingField; // 0x21

	// Properties
	public bool isPressed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_isPressed() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	private void set_isPressed(bool value) { }

	// RVA: 0x7B7450 Offset: 0x7B6650 VA: 0x1807B7450
	private void Awake() { }

	// RVA: 0x6E8DA0 Offset: 0x6E7FA0 VA: 0x1806E8DA0
	private void Restart() { }

	// RVA: 0x7B7490 Offset: 0x7B6690 VA: 0x1807B7490 Slot: 4
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7B74D0 Offset: 0x7B66D0 VA: 0x1807B74D0 Slot: 5
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7B7470 Offset: 0x7B6670 VA: 0x1807B7470
	private static bool IsMousePointerId(int id) { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
[RequireComponent(typeof(Image))]
public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 2178
{
	// Fields
	public bool allowMouseControl; // 0x20
	public int radius; // 0x24
	private Vector2 origAnchoredPosition; // 0x28
	private Vector3 origWorldPosition; // 0x30
	private Vector2 origScreenResolution; // 0x3C
	private ScreenOrientation origScreenOrientation; // 0x44
	private bool hasFinger; // 0x48
	private int lastFingerId; // 0x4C
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x50

	// Properties
	public Vector2 position { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7B7A30 Offset: 0x7B6C30 VA: 0x1807B7A30
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_position(Vector2 value) { }

	// RVA: 0x7B75D0 Offset: 0x7B67D0 VA: 0x1807B75D0
	private void Start() { }

	// RVA: 0x7B79B0 Offset: 0x7B6BB0 VA: 0x1807B79B0
	private void Update() { }

	// RVA: 0x7B7510 Offset: 0x7B6710 VA: 0x1807B7510
	private void Restart() { }

	// RVA: 0x7B7600 Offset: 0x7B6800 VA: 0x1807B7600
	private void StoreOrigValues() { }

	// RVA: 0x7B7960 Offset: 0x7B6B60 VA: 0x1807B7960
	private void UpdateValue(Vector3 value) { }

	// RVA: 0x7B78C0 Offset: 0x7B6AC0 VA: 0x1807B78C0 Slot: 4
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7B7910 Offset: 0x7B6B10 VA: 0x1807B7910 Slot: 5
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7B76F0 Offset: 0x7B68F0 VA: 0x1807B76F0 Slot: 6
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x7B7470 Offset: 0x7B6670 VA: 0x1807B7470
	private static bool IsMousePointerId(int id) { }

	// RVA: 0x7B7A10 Offset: 0x7B6C10 VA: 0x1807B7A10
	public void .ctor() { }
}

// Namespace: 
private class DualShock4SpecialFeaturesExample.Touch // TypeDefIndex: 2179
{
	// Fields
	public GameObject go; // 0x10
	public int touchId; // 0x18

	// Methods

	// RVA: 0x7252A0 Offset: 0x7244A0 VA: 0x1807252A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DualShock4SpecialFeaturesExample.<>c__DisplayClass20_0 // TypeDefIndex: 2180
{
	// Fields
	public int touchId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B8340 Offset: 0x7B7540 VA: 0x1807B8340
	internal bool <HandleTouchpad>b__0(DualShock4SpecialFeaturesExample.Touch x) { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class DualShock4SpecialFeaturesExample : MonoBehaviour // TypeDefIndex: 2181
{
	// Fields
	private const int maxTouches = 2;
	public int playerId; // 0x20
	public Transform touchpadTransform; // 0x28
	public GameObject lightObject; // 0x30
	public Transform accelerometerTransform; // 0x38
	private List<DualShock4SpecialFeaturesExample.Touch> touches; // 0x40
	private Queue<DualShock4SpecialFeaturesExample.Touch> unusedTouches; // 0x48
	private bool isFlashing; // 0x50
	private GUIStyle textStyle; // 0x58

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7A4FF0 Offset: 0x7A41F0 VA: 0x1807A4FF0
	private Player get_player() { }

	// RVA: 0x7A3390 Offset: 0x7A2590 VA: 0x1807A3390
	private void Awake() { }

	// RVA: 0x7A4840 Offset: 0x7A3A40 VA: 0x1807A4840
	private void Update() { }

	// RVA: 0x7A3D20 Offset: 0x7A2F20 VA: 0x1807A3D20
	private void OnGUI() { }

	// RVA: 0x7A4400 Offset: 0x7A3600 VA: 0x1807A4400
	private void ResetOrientation() { }

	// RVA: 0x7A44B0 Offset: 0x7A36B0 VA: 0x1807A44B0
	private void SetRandomLightColor() { }

	// RVA: 0x7A46D0 Offset: 0x7A38D0 VA: 0x1807A46D0
	private void StartLightFlash() { }

	// RVA: 0x7A4790 Offset: 0x7A3990 VA: 0x1807A4790
	private void StopLightFlash() { }

	// RVA: 0x7A33A0 Offset: 0x7A25A0 VA: 0x1807A33A0
	private IDualShock4Extension GetFirstDS4(Player player) { }

	// RVA: 0x7A3AE0 Offset: 0x7A2CE0 VA: 0x1807A3AE0
	private void InitializeTouchObjects() { }

	// RVA: 0x7A35B0 Offset: 0x7A27B0 VA: 0x1807A35B0
	private void HandleTouchpad(IDualShock4Extension ds4) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("")]
public class EightPlayersExample_Player : MonoBehaviour // TypeDefIndex: 2182
{
	// Fields
	public int playerId; // 0x20
	public float moveSpeed; // 0x24
	public float bulletSpeed; // 0x28
	public GameObject bulletPrefab; // 0x30
	private Player player; // 0x38
	private CharacterController cc; // 0x40
	private Vector3 moveVector; // 0x48
	private bool fire; // 0x54
	private bool initialized; // 0x55

	// Methods

	// RVA: 0x7A5050 Offset: 0x7A4250 VA: 0x1807A5050
	private void Awake() { }

	// RVA: 0x7A5130 Offset: 0x7A4330 VA: 0x1807A5130
	private void Initialize() { }

	// RVA: 0x7A5460 Offset: 0x7A4660 VA: 0x1807A5460
	private void Update() { }

	// RVA: 0x7A5090 Offset: 0x7A4290 VA: 0x1807A5090
	private void GetInput() { }

	// RVA: 0x7A51A0 Offset: 0x7A43A0 VA: 0x1807A51A0
	private void ProcessInput() { }

	// RVA: 0x7A55F0 Offset: 0x7A47F0 VA: 0x1807A55F0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class FallbackJoystickIdentificationDemo : MonoBehaviour // TypeDefIndex: 2183
{
	// Fields
	private const float windowWidth = 250;
	private const float windowHeight = 250;
	private const float inputDelay = 1;
	private bool identifyRequired; // 0x20
	private Queue<Joystick> joysticksToIdentify; // 0x28
	private float nextInputAllowedTime; // 0x30
	private GUIStyle style; // 0x38

	// Methods

	// RVA: 0x7A5A90 Offset: 0x7A4C90 VA: 0x1807A5A90
	private void Awake() { }

	// RVA: 0x7A5EA0 Offset: 0x7A50A0 VA: 0x1807A5EA0
	private void JoystickConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7A5EA0 Offset: 0x7A50A0 VA: 0x1807A5EA0
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7A5D90 Offset: 0x7A4F90 VA: 0x1807A5D90
	public void IdentifyAllJoysticks() { }

	// RVA: 0x7A6140 Offset: 0x7A5340 VA: 0x1807A6140
	private void SetInputDelay() { }

	// RVA: 0x7A5EB0 Offset: 0x7A50B0 VA: 0x1807A5EB0
	private void OnGUI() { }

	// RVA: 0x7A5B90 Offset: 0x7A4D90 VA: 0x1807A5B90
	private void DrawDialogWindow(int windowId) { }

	// RVA: 0x7A6130 Offset: 0x7A5330 VA: 0x1807A6130
	private void Reset() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class PlayerMouseSpriteExample : MonoBehaviour // TypeDefIndex: 2184
{
	// Fields
	[Tooltip("The Player that will control the mouse")]
	public int playerId; // 0x20
	[Tooltip("The Rewired Action used for the mouse horizontal axis.")]
	public string horizontalAction; // 0x28
	[Tooltip("The Rewired Action used for the mouse vertical axis.")]
	public string verticalAction; // 0x30
	[Tooltip("The Rewired Action used for the mouse wheel axis.")]
	public string wheelAction; // 0x38
	[Tooltip("The Rewired Action used for the mouse left button.")]
	public string leftButtonAction; // 0x40
	[Tooltip("The Rewired Action used for the mouse right button.")]
	public string rightButtonAction; // 0x48
	[Tooltip("The Rewired Action used for the mouse middle button.")]
	public string middleButtonAction; // 0x50
	[Tooltip("The distance from the camera that the pointer will be drawn.")]
	public float distanceFromCamera; // 0x58
	[Tooltip("The scale of the sprite pointer.")]
	public float spriteScale; // 0x5C
	[Tooltip("The pointer prefab.")]
	public GameObject pointerPrefab; // 0x60
	[Tooltip("The click effect prefab.")]
	public GameObject clickEffectPrefab; // 0x68
	[Tooltip("Should the hardware pointer be hidden?")]
	public bool hideHardwarePointer; // 0x70
	private GameObject pointer; // 0x78
	private PlayerMouse mouse; // 0x80

	// Methods

	// RVA: 0x7AD840 Offset: 0x7ACA40 VA: 0x1807AD840
	private void Awake() { }

	// RVA: 0x7ADFA0 Offset: 0x7AD1A0 VA: 0x1807ADFA0
	private void Update() { }

	// RVA: 0x7ADDF0 Offset: 0x7ACFF0 VA: 0x1807ADDF0
	private void OnDestroy() { }

	// RVA: 0x7ADC20 Offset: 0x7ACE20 VA: 0x1807ADC20
	private void CreateClickEffect(Color color) { }

	// RVA: 0x7ADEF0 Offset: 0x7AD0F0 VA: 0x1807ADEF0
	private void OnScreenPositionChanged(Vector2 position) { }

	// RVA: 0x7AE1F0 Offset: 0x7AD3F0 VA: 0x1807AE1F0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 2185
{
	// Fields
	public Text text; // 0x20
	private const int logLength = 10;
	private List<string> log; // 0x28

	// Methods

	// RVA: 0x7AE3F0 Offset: 0x7AD5F0 VA: 0x1807AE3F0
	private void Log(string o) { }

	// RVA: 0x7AF720 Offset: 0x7AE920 VA: 0x1807AF720
	private void Update() { }

	// RVA: 0x7AEF60 Offset: 0x7AE160 VA: 0x1807AEF60 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7AF140 Offset: 0x7AE340 VA: 0x1807AF140 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x7AF320 Offset: 0x7AE520 VA: 0x1807AF320 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7AED40 Offset: 0x7ADF40 VA: 0x1807AED40 Slot: 7
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7AEB20 Offset: 0x7ADD20 VA: 0x1807AEB20 Slot: 8
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7AF540 Offset: 0x7AE740 VA: 0x1807AF540 Slot: 9
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x7AE4C0 Offset: 0x7AD6C0 VA: 0x1807AE4C0 Slot: 10
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7AE6E0 Offset: 0x7AD8E0 VA: 0x1807AE6E0 Slot: 11
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7AE900 Offset: 0x7ADB00 VA: 0x1807AE900 Slot: 12
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7AE2C0 Offset: 0x7AD4C0 VA: 0x1807AE2C0
	private static string GetSourceName(PlayerPointerEventData playerEventData) { }

	// RVA: 0x7AF900 Offset: 0x7AEB00 VA: 0x1807AF900
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
[RequireComponent(typeof(RectTransform))]
public sealed class UIPointer : UIBehaviour // TypeDefIndex: 2186
{
	// Fields
	[Tooltip("Should the hardware pointer be hidden?")]
	[SerializeField]
	private bool _hideHardwarePointer; // 0x20
	[Tooltip("Sets the pointer to the last sibling in the parent hierarchy. Do not enable this on multiple UIPointers under the same parent transform or they will constantly fight each other for dominance.")]
	[SerializeField]
	private bool _autoSort; // 0x21
	private Canvas _canvas; // 0x28

	// Properties
	public bool autoSort { get; set; }

	// Methods

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_autoSort() { }

	// RVA: 0x7B89B0 Offset: 0x7B7BB0 VA: 0x1807B89B0
	public void set_autoSort(bool value) { }

	// RVA: 0x7B8540 Offset: 0x7B7740 VA: 0x1807B8540 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7B8910 Offset: 0x7B7B10 VA: 0x1807B8910
	private void Update() { }

	// RVA: 0x7B86F0 Offset: 0x7B78F0 VA: 0x1807B86F0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x7B86F0 Offset: 0x7B78F0 VA: 0x1807B86F0 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x7B8760 Offset: 0x7B7960 VA: 0x1807B8760
	public void OnScreenPositionChanged(Vector2 screenPosition) { }

	// RVA: 0x7B8680 Offset: 0x7B7880 VA: 0x1807B8680
	private void GetDependencies() { }

	// RVA: 0x7B89A0 Offset: 0x7B7BA0 VA: 0x1807B89A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour // TypeDefIndex: 2187
{
	// Methods

	// RVA: 0x7AFC80 Offset: 0x7AEE80 VA: 0x1807AFC80
	private void Update() { }

	// RVA: 0x7AF970 Offset: 0x7AEB70 VA: 0x1807AF970
	private void AssignJoysticksToPlayers() { }

	// RVA: 0x7AFB60 Offset: 0x7AED60 VA: 0x1807AFB60
	private Player FindPlayerWithoutJoystick() { }

	// RVA: 0x7AFB40 Offset: 0x7AED40 VA: 0x1807AFB40
	private bool DoAllPlayersHaveJoysticks() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
[RequireComponent(typeof(CharacterController))]
public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour // TypeDefIndex: 2188
{
	// Fields
	public int playerId; // 0x20
	public float moveSpeed; // 0x24
	public float bulletSpeed; // 0x28
	public GameObject bulletPrefab; // 0x30
	private CharacterController cc; // 0x38
	private Vector3 moveVector; // 0x40
	private bool fire; // 0x4C

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7B0240 Offset: 0x7AF440 VA: 0x1807B0240
	private Player get_player() { }

	// RVA: 0x7AFDE0 Offset: 0x7AEFE0 VA: 0x1807AFDE0
	private void OnEnable() { }

	// RVA: 0x7B00E0 Offset: 0x7AF2E0 VA: 0x1807B00E0
	private void Update() { }

	// RVA: 0x7AFD20 Offset: 0x7AEF20 VA: 0x1807AFD20
	private void GetInput() { }

	// RVA: 0x7AFE20 Offset: 0x7AF020 VA: 0x1807AFE20
	private void ProcessInput() { }

	// RVA: 0x7A55F0 Offset: 0x7A47F0 VA: 0x1807A55F0
	public void .ctor() { }
}

// Namespace: 
private class PressStartToJoinExample_Assigner.PlayerMap // TypeDefIndex: 2189
{
	// Fields
	public int rewiredPlayerId; // 0x10
	public int gamePlayerId; // 0x14

	// Methods

	// RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	public void .ctor(int rewiredPlayerId, int gamePlayerId) { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class PressStartToJoinExample_Assigner : MonoBehaviour // TypeDefIndex: 2190
{
	// Fields
	private static PressStartToJoinExample_Assigner instance; // 0x0
	public int maxPlayers; // 0x20
	private List<PressStartToJoinExample_Assigner.PlayerMap> playerMap; // 0x28
	private int gamePlayerIdCounter; // 0x30

	// Methods

	// RVA: 0x7B0630 Offset: 0x7AF830 VA: 0x1807B0630
	public static Player GetRewiredPlayer(int gamePlayerId) { }

	// RVA: 0x7B05A0 Offset: 0x7AF7A0 VA: 0x1807B05A0
	private void Awake() { }

	// RVA: 0x7B0880 Offset: 0x7AFA80 VA: 0x1807B0880
	private void Update() { }

	// RVA: 0x7B0310 Offset: 0x7AF510 VA: 0x1807B0310
	private void AssignNextPlayer(int rewiredPlayerId) { }

	// RVA: 0x7B0620 Offset: 0x7AF820 VA: 0x1807B0620
	private int GetNextGamePlayerId() { }

	// RVA: 0x7B0960 Offset: 0x7AFB60 VA: 0x1807B0960
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
[RequireComponent(typeof(CharacterController))]
public class PressStartToJoinExample_GamePlayer : MonoBehaviour // TypeDefIndex: 2191
{
	// Fields
	public int gamePlayerId; // 0x20
	public float moveSpeed; // 0x24
	public float bulletSpeed; // 0x28
	public GameObject bulletPrefab; // 0x30
	private CharacterController cc; // 0x38
	private Vector3 moveVector; // 0x40
	private bool fire; // 0x4C

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7B0E90 Offset: 0x7B0090 VA: 0x1807B0E90
	private Player get_player() { }

	// RVA: 0x7B0A30 Offset: 0x7AFC30 VA: 0x1807B0A30
	private void OnEnable() { }

	// RVA: 0x7B0D30 Offset: 0x7AFF30 VA: 0x1807B0D30
	private void Update() { }

	// RVA: 0x7B0970 Offset: 0x7AFB70 VA: 0x1807B0970
	private void GetInput() { }

	// RVA: 0x7B0A70 Offset: 0x7AFC70 VA: 0x1807B0A70
	private void ProcessInput() { }

	// RVA: 0x7A55F0 Offset: 0x7A47F0 VA: 0x1807A55F0
	public void .ctor() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class Bullet : MonoBehaviour // TypeDefIndex: 2192
{
	// Fields
	public float lifeTime; // 0x20
	private bool die; // 0x24
	private float deathTime; // 0x28

	// Methods

	// RVA: 0x79F460 Offset: 0x79E660 VA: 0x18079F460
	private void Start() { }

	// RVA: 0x79F4A0 Offset: 0x79E6A0 VA: 0x18079F4A0
	private void Update() { }

	// RVA: 0x79F510 Offset: 0x79E710 VA: 0x18079F510
	public void .ctor() { }
}

// Namespace: 
private class SimpleCombinedKeyboardMouseRemapping.Row // TypeDefIndex: 2193
{
	// Fields
	public InputAction action; // 0x10
	public AxisRange actionRange; // 0x18
	public Button button; // 0x20
	public Text text; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct SimpleCombinedKeyboardMouseRemapping.TargetMapping // TypeDefIndex: 2194
{
	// Fields
	public ControllerMap controllerMap; // 0x0
	public int actionElementMapId; // 0x8
}

// Namespace: 
[CompilerGenerated]
private sealed class SimpleCombinedKeyboardMouseRemapping.<>c__DisplayClass17_0 // TypeDefIndex: 2195
{
	// Fields
	public int index; // 0x10
	public int actionElementMapId; // 0x14
	public SimpleCombinedKeyboardMouseRemapping <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B8310 Offset: 0x7B7510 VA: 0x1807B8310
	internal void <RedrawUI>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimpleCombinedKeyboardMouseRemapping.<StartListeningDelayed>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2196
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimpleCombinedKeyboardMouseRemapping <>4__this; // 0x20
	public int index; // 0x28
	public ControllerMap keyboardMap; // 0x30
	public int actionElementMapToReplaceId; // 0x38
	public ControllerMap mouseMap; // 0x40

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

	// RVA: 0x7B7AE0 Offset: 0x7B6CE0 VA: 0x1807B7AE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7B7E50 Offset: 0x7B7050 VA: 0x1807B7E50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour // TypeDefIndex: 2197
{
	// Fields
	private const string category = "Default";
	private const string layout = "Default";
	private const string uiCategory = "UI";
	private InputMapper inputMapper_keyboard; // 0x20
	private InputMapper inputMapper_mouse; // 0x28
	public GameObject buttonPrefab; // 0x30
	public GameObject textPrefab; // 0x38
	public RectTransform fieldGroupTransform; // 0x40
	public RectTransform actionGroupTransform; // 0x48
	public Text controllerNameUIText; // 0x50
	public Text statusUIText; // 0x58
	private List<SimpleCombinedKeyboardMouseRemapping.Row> rows; // 0x60
	private SimpleCombinedKeyboardMouseRemapping.TargetMapping _replaceTargetMapping; // 0x68

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7B2800 Offset: 0x7B1A00 VA: 0x1807B2800
	private Player get_player() { }

	// RVA: 0x7B1B90 Offset: 0x7B0D90 VA: 0x1807B1B90
	private void OnEnable() { }

	// RVA: 0x7B1B30 Offset: 0x7B0D30 VA: 0x1807B1B30
	private void OnDisable() { }

	// RVA: 0x7B2230 Offset: 0x7B1430 VA: 0x1807B2230
	private void RedrawUI() { }

	// RVA: 0x7B0F70 Offset: 0x7B0170 VA: 0x1807B0F70
	private void ClearUI() { }

	// RVA: 0x7B12C0 Offset: 0x7B04C0 VA: 0x1807B12C0
	private void InitializeUI() { }

	// RVA: 0x7B1060 Offset: 0x7B0260 VA: 0x1807B1060
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label) { }

	// RVA: 0x7B1E50 Offset: 0x7B1050 VA: 0x1807B1E50
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) { }

	[IteratorStateMachine(typeof(SimpleCombinedKeyboardMouseRemapping.<StartListeningDelayed>d__22))]
	// RVA: 0x7B26A0 Offset: 0x7B18A0 VA: 0x1807B26A0
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId) { }

	// RVA: 0x7B20C0 Offset: 0x7B12C0 VA: 0x1807B20C0
	private void OnInputMapped(InputMapper.InputMappedEventData data) { }

	// RVA: 0x7B2150 Offset: 0x7B1350 VA: 0x1807B2150
	private void OnStopped(InputMapper.StoppedEventData data) { }

	// RVA: 0x7B2740 Offset: 0x7B1940 VA: 0x1807B2740
	public void .ctor() { }
}

// Namespace: 
private class SimpleControlRemapping.Row // TypeDefIndex: 2198
{
	// Fields
	public InputAction action; // 0x10
	public AxisRange actionRange; // 0x18
	public Button button; // 0x20
	public Text text; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimpleControlRemapping.<>c__DisplayClass21_0 // TypeDefIndex: 2199
{
	// Fields
	public int index; // 0x10
	public int actionElementMapId; // 0x14
	public SimpleControlRemapping <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B8360 Offset: 0x7B7560 VA: 0x1807B8360
	internal void <RedrawUI>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SimpleControlRemapping.<StartListeningDelayed>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2200
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SimpleControlRemapping <>4__this; // 0x20
	public int index; // 0x28
	public int actionElementMapToReplaceId; // 0x2C

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

	// RVA: 0x7B7E90 Offset: 0x7B7090 VA: 0x1807B7E90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7B8120 Offset: 0x7B7320 VA: 0x1807B8120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class SimpleControlRemapping : MonoBehaviour // TypeDefIndex: 2201
{
	// Fields
	private const string category = "Default";
	private const string layout = "Default";
	private const string uiCategory = "UI";
	private InputMapper inputMapper; // 0x20
	public GameObject buttonPrefab; // 0x28
	public GameObject textPrefab; // 0x30
	public RectTransform fieldGroupTransform; // 0x38
	public RectTransform actionGroupTransform; // 0x40
	public Text controllerNameUIText; // 0x48
	public Text statusUIText; // 0x50
	private ControllerType selectedControllerType; // 0x58
	private int selectedControllerId; // 0x5C
	private List<SimpleControlRemapping.Row> rows; // 0x60

	// Properties
	private Player player { get; }
	private ControllerMap controllerMap { get; }
	private Controller controller { get; }

	// Methods

	// RVA: 0x7B42C0 Offset: 0x7B34C0 VA: 0x1807B42C0
	private Player get_player() { }

	// RVA: 0x7B4130 Offset: 0x7B3330 VA: 0x1807B4130
	private ControllerMap get_controllerMap() { }

	// RVA: 0x7B4240 Offset: 0x7B3440 VA: 0x1807B4240
	private Controller get_controller() { }

	// RVA: 0x7B3560 Offset: 0x7B2760 VA: 0x1807B3560
	private void OnEnable() { }

	// RVA: 0x7B3470 Offset: 0x7B2670 VA: 0x1807B3470
	private void OnDisable() { }

	// RVA: 0x7B3970 Offset: 0x7B2B70 VA: 0x1807B3970
	private void RedrawUI() { }

	// RVA: 0x7B2860 Offset: 0x7B1A60 VA: 0x1807B2860
	private void ClearUI() { }

	// RVA: 0x7B2BE0 Offset: 0x7B1DE0 VA: 0x1807B2BE0
	private void InitializeUI() { }

	// RVA: 0x7B2980 Offset: 0x7B1B80 VA: 0x1807B2980
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label) { }

	// RVA: 0x7B3E80 Offset: 0x7B3080 VA: 0x1807B3E80
	private void SetSelectedController(ControllerType controllerType) { }

	// RVA: 0x7B3460 Offset: 0x7B2660 VA: 0x1807B3460
	public void OnControllerSelected(int controllerType) { }

	// RVA: 0x7B37B0 Offset: 0x7B29B0 VA: 0x1807B37B0
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) { }

	[IteratorStateMachine(typeof(SimpleControlRemapping.<StartListeningDelayed>d__28))]
	// RVA: 0x7B4010 Offset: 0x7B3210 VA: 0x1807B4010
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId) { }

	// RVA: 0x7B3450 Offset: 0x7B2650 VA: 0x1807B3450
	private void OnControllerChanged(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7B3880 Offset: 0x7B2A80 VA: 0x1807B3880
	private void OnInputMapped(InputMapper.InputMappedEventData data) { }

	// RVA: 0x7B3890 Offset: 0x7B2A90 VA: 0x1807B3890
	private void OnStopped(InputMapper.StoppedEventData data) { }

	// RVA: 0x7B4090 Offset: 0x7B3290 VA: 0x1807B4090
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControlMapperDemoMessage.<SelectDefaultDeferred>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2202
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ControlMapperDemoMessage <>4__this; // 0x20

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

	// RVA: 0x7B7A50 Offset: 0x7B6C50 VA: 0x1807B7A50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7B7AA0 Offset: 0x7B6CA0 VA: 0x1807B7AA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.Demos
[AddComponentMenu("")]
public class ControlMapperDemoMessage : MonoBehaviour // TypeDefIndex: 2203
{
	// Fields
	public ControlMapper controlMapper; // 0x20
	public Selectable defaultSelectable; // 0x28

	// Methods

	// RVA: 0x79F680 Offset: 0x79E880 VA: 0x18079F680
	private void Awake() { }

	// RVA: 0x79F980 Offset: 0x79EB80 VA: 0x18079F980
	private void Start() { }

	// RVA: 0x79F790 Offset: 0x79E990 VA: 0x18079F790
	private void OnControlMapperClosed() { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	private void OnControlMapperOpened() { }

	// RVA: 0x79F880 Offset: 0x79EA80 VA: 0x18079F880
	private void SelectDefault() { }

	[IteratorStateMachine(typeof(ControlMapperDemoMessage.<SelectDefaultDeferred>d__7))]
	// RVA: 0x79F820 Offset: 0x79EA20 VA: 0x18079F820
	private IEnumerator SelectDefaultDeferred() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.GamepadTemplateUI
[RequireComponent(typeof(Image))]
public class ControllerUIEffect : MonoBehaviour // TypeDefIndex: 2204
{
	// Fields
	[SerializeField]
	private Color _highlightColor; // 0x20
	private Image _image; // 0x30
	private Color _color; // 0x38
	private Color _origColor; // 0x48
	private bool _isActive; // 0x58
	private float _highlightAmount; // 0x5C

	// Methods

	// RVA: 0x79FB70 Offset: 0x79ED70 VA: 0x18079FB70
	private void Awake() { }

	// RVA: 0x79FA30 Offset: 0x79EC30 VA: 0x18079FA30
	public void Activate(float amount) { }

	// RVA: 0x79FBE0 Offset: 0x79EDE0 VA: 0x18079FBE0
	public void Deactivate() { }

	// RVA: 0x79FC50 Offset: 0x79EE50 VA: 0x18079FC50
	private void RedrawImage() { }

	// RVA: 0x79FCB0 Offset: 0x79EEB0 VA: 0x18079FCB0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.GamepadTemplateUI
[RequireComponent(typeof(Image))]
public class ControllerUIElement : MonoBehaviour // TypeDefIndex: 2205
{
	// Fields
	[SerializeField]
	private Color _highlightColor; // 0x20
	[SerializeField]
	private ControllerUIEffect _positiveUIEffect; // 0x30
	[SerializeField]
	private ControllerUIEffect _negativeUIEffect; // 0x38
	[SerializeField]
	private Text _label; // 0x40
	[SerializeField]
	private Text _positiveLabel; // 0x48
	[SerializeField]
	private Text _negativeLabel; // 0x50
	[SerializeField]
	private ControllerUIElement[] _childElements; // 0x58
	private Image _image; // 0x60
	private Color _color; // 0x68
	private Color _origColor; // 0x78
	private bool _isActive; // 0x88
	private float _highlightAmount; // 0x8C

	// Properties
	private bool hasEffects { get; }

	// Methods

	// RVA: 0x7A0660 Offset: 0x79F860 VA: 0x1807A0660
	private bool get_hasEffects() { }

	// RVA: 0x7A0010 Offset: 0x79F210 VA: 0x1807A0010
	private void Awake() { }

	// RVA: 0x79FCD0 Offset: 0x79EED0 VA: 0x18079FCD0
	public void Activate(float amount) { }

	// RVA: 0x7A0290 Offset: 0x79F490 VA: 0x1807A0290
	public void Deactivate() { }

	// RVA: 0x7A0480 Offset: 0x79F680 VA: 0x1807A0480
	public void SetLabel(string text, AxisRange labelType) { }

	// RVA: 0x7A0090 Offset: 0x79F290 VA: 0x1807A0090
	public void ClearLabels() { }

	// RVA: 0x7A0440 Offset: 0x79F640 VA: 0x1807A0440
	private void RedrawImage() { }

	// RVA: 0x7A0600 Offset: 0x79F800 VA: 0x1807A0600
	public void .ctor() { }
}

// Namespace: 
private class GamepadTemplateUI.Stick // TypeDefIndex: 2206
{
	// Fields
	private RectTransform _transform; // 0x10
	private Vector2 _origPosition; // 0x18
	private int _xAxisElementId; // 0x20
	private int _yAxisElementId; // 0x24

	// Properties
	public Vector2 position { get; set; }

	// Methods

	// RVA: 0x7B72D0 Offset: 0x7B64D0 VA: 0x1807B72D0
	public Vector2 get_position() { }

	// RVA: 0x7B73B0 Offset: 0x7B65B0 VA: 0x1807B73B0
	public void set_position(Vector2 value) { }

	// RVA: 0x7B7200 Offset: 0x7B6400 VA: 0x1807B7200
	public void .ctor(RectTransform transform, int xAxisElementId, int yAxisElementId) { }

	// RVA: 0x7B6F90 Offset: 0x7B6190 VA: 0x1807B6F90
	public void Reset() { }

	// RVA: 0x7B6EF0 Offset: 0x7B60F0 VA: 0x1807B6EF0
	public bool ContainsElement(int elementId) { }

	// RVA: 0x7B7020 Offset: 0x7B6220 VA: 0x1807B7020
	public void SetAxisPosition(int elementId, float value) { }
}

// Namespace: 
private class GamepadTemplateUI.UIElement // TypeDefIndex: 2207
{
	// Fields
	public int id; // 0x10
	public ControllerUIElement element; // 0x18

	// Methods

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	public void .ctor(int id, ControllerUIElement element) { }
}

// Namespace: Rewired.Demos.GamepadTemplateUI
public class GamepadTemplateUI : MonoBehaviour // TypeDefIndex: 2208
{
	// Fields
	private const float stickRadius = 20;
	public int playerId; // 0x20
	[SerializeField]
	private RectTransform leftStick; // 0x28
	[SerializeField]
	private RectTransform rightStick; // 0x30
	[SerializeField]
	private ControllerUIElement leftStickX; // 0x38
	[SerializeField]
	private ControllerUIElement leftStickY; // 0x40
	[SerializeField]
	private ControllerUIElement leftStickButton; // 0x48
	[SerializeField]
	private ControllerUIElement rightStickX; // 0x50
	[SerializeField]
	private ControllerUIElement rightStickY; // 0x58
	[SerializeField]
	private ControllerUIElement rightStickButton; // 0x60
	[SerializeField]
	private ControllerUIElement actionBottomRow1; // 0x68
	[SerializeField]
	private ControllerUIElement actionBottomRow2; // 0x70
	[SerializeField]
	private ControllerUIElement actionBottomRow3; // 0x78
	[SerializeField]
	private ControllerUIElement actionTopRow1; // 0x80
	[SerializeField]
	private ControllerUIElement actionTopRow2; // 0x88
	[SerializeField]
	private ControllerUIElement actionTopRow3; // 0x90
	[SerializeField]
	private ControllerUIElement leftShoulder; // 0x98
	[SerializeField]
	private ControllerUIElement leftTrigger; // 0xA0
	[SerializeField]
	private ControllerUIElement rightShoulder; // 0xA8
	[SerializeField]
	private ControllerUIElement rightTrigger; // 0xB0
	[SerializeField]
	private ControllerUIElement center1; // 0xB8
	[SerializeField]
	private ControllerUIElement center2; // 0xC0
	[SerializeField]
	private ControllerUIElement center3; // 0xC8
	[SerializeField]
	private ControllerUIElement dPadUp; // 0xD0
	[SerializeField]
	private ControllerUIElement dPadRight; // 0xD8
	[SerializeField]
	private ControllerUIElement dPadDown; // 0xE0
	[SerializeField]
	private ControllerUIElement dPadLeft; // 0xE8
	private GamepadTemplateUI.UIElement[] _uiElementsArray; // 0xF0
	private Dictionary<int, ControllerUIElement> _uiElements; // 0xF8
	private IList<ControllerTemplateElementTarget> _tempTargetList; // 0x100
	private GamepadTemplateUI.Stick[] _sticks; // 0x108

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7A9750 Offset: 0x7A8950 VA: 0x1807A9750
	private Player get_player() { }

	// RVA: 0x7A7AD0 Offset: 0x7A6CD0 VA: 0x1807A7AD0
	private void Awake() { }

	// RVA: 0x7A9560 Offset: 0x7A8760 VA: 0x1807A9560
	private void Start() { }

	// RVA: 0x7A9490 Offset: 0x7A8690 VA: 0x1807A9490
	private void OnDestroy() { }

	// RVA: 0x7A9600 Offset: 0x7A8800 VA: 0x1807A9600
	private void Update() { }

	// RVA: 0x7A8730 Offset: 0x7A7930 VA: 0x1807A8730
	private void DrawActiveElements() { }

	// RVA: 0x7A7700 Offset: 0x7A6900 VA: 0x1807A7700
	private void ActivateElements(Player player, int actionId) { }

	// RVA: 0x7A90B0 Offset: 0x7A82B0 VA: 0x1807A90B0
	private void DrawLabels() { }

	// RVA: 0x7A8E60 Offset: 0x7A8060 VA: 0x1807A8E60
	private void DrawLabels(Player player, InputAction action) { }

	// RVA: 0x7A8AA0 Offset: 0x7A7CA0 VA: 0x1807A8AA0
	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element) { }

	// RVA: 0x7A9350 Offset: 0x7A8550 VA: 0x1807A9350
	private GamepadTemplateUI.Stick GetStick(int elementId) { }

	// RVA: 0x7A9480 Offset: 0x7A8680 VA: 0x1807A9480
	private void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7A9480 Offset: 0x7A8680 VA: 0x1807A9480
	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x7A96A0 Offset: 0x7A88A0 VA: 0x1807A96A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
[Serializable]
public class CustomPlatformHardwareJoystickMapPlatformDataSet : ScriptableObject // TypeDefIndex: 2209
{
	// Fields
	public List<HardwareJoystickMapCustomPlatformMapSO> platformMaps; // 0x18

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class CustomPlatformHardwareJoystickMapProvider.PlatformDataSet // TypeDefIndex: 2210
{
	// Fields
	public CustomPlatformType platformType; // 0x10
	public CustomPlatformHardwareJoystickMapPlatformDataSet dataSet; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
[Serializable]
public class CustomPlatformHardwareJoystickMapProvider : IHardwareJoystickMapCustomPlatformMapProvider // TypeDefIndex: 2211
{
	// Fields
	public List<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet> platformJoystickDataSets; // 0x10

	// Methods

	// RVA: 0x7A1C90 Offset: 0x7A0E90 VA: 0x1807A1C90 Slot: 4
	public HardwareJoystickMap.Platform GetPlatformMap(int customPlatformId, Guid hardwareTypeGuid) { }

	// RVA: 0x7A1BB0 Offset: 0x7A0DB0 VA: 0x1807A1BB0
	private CustomPlatformHardwareJoystickMapPlatformDataSet GetPlatformDataSet(int customPlatformId) { }

	// RVA: 0x7A1F30 Offset: 0x7A1130 VA: 0x1807A1F30
	private static HardwareJoystickMap.Platform GetPlatformMap(CustomPlatformHardwareJoystickMapPlatformDataSet platformDataSet, Guid hardwareTypeGuid) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public sealed class CustomPlatformManager : MonoBehaviour, ICustomPlatformInitializer // TypeDefIndex: 2212
{
	// Fields
	public CustomPlatformHardwareJoystickMapProvider mapProvider; // 0x20

	// Methods

	// RVA: 0x7A20D0 Offset: 0x7A12D0 VA: 0x1807A20D0 Slot: 4
	public CustomPlatformInitOptions GetCustomPlatformInitOptions() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public enum CustomPlatformType // TypeDefIndex: 2213
{
	// Fields
	public int value__; // 0x0
	public const CustomPlatformType MyPlatform = 0;
}

// Namespace: 
private class MyPlatformControllerExtension.Source : IControllerExtensionSource // TypeDefIndex: 2214
{
	// Fields
	public readonly MyPlatformInputSource.Joystick sourceJoystick; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(MyPlatformInputSource.Joystick sourceJoystick) { }
}

// Namespace: Rewired.Demos.CustomPlatform
public sealed class MyPlatformControllerExtension : CustomControllerExtension, IControllerVibrator // TypeDefIndex: 2215
{
	// Properties
	public int vibrationMotorCount { get; }

	// Methods

	// RVA: 0x7AC770 Offset: 0x7AB970 VA: 0x1807AC770
	public void .ctor(MyPlatformInputSource.Joystick sourceJoystick) { }

	// RVA: 0x7AC7E0 Offset: 0x7AB9E0 VA: 0x1807AC7E0
	private void .ctor(MyPlatformControllerExtension other) { }

	// RVA: 0x7AC5C0 Offset: 0x7AB7C0 VA: 0x1807AC5C0 Slot: 10
	public override Controller.Extension ShallowCopy() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 11
	public int get_vibrationMotorCount() { }

	// RVA: 0x7ABE30 Offset: 0x7AB030 VA: 0x1807ABE30 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x7AC070 Offset: 0x7AB270 VA: 0x1807AC070 Slot: 13
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x7AC300 Offset: 0x7AB500 VA: 0x1807AC300 Slot: 14
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x7ABD00 Offset: 0x7AAF00 VA: 0x1807ABD00 Slot: 15
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x7ABC10 Offset: 0x7AAE10 VA: 0x1807ABC10 Slot: 16
	public float GetVibration(int motorIndex) { }

	// RVA: 0x7AC620 Offset: 0x7AB820 VA: 0x1807AC620 Slot: 17
	public void StopVibration() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public struct MyPlatformControllerIdentifier // TypeDefIndex: 2216
{
	// Fields
	public ushort vendorId; // 0x0
	public ushort productId; // 0x2
}

// Namespace: 
[Serializable]
public class MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase : HardwareJoystickMapCustomPlatformMap<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria> // TypeDefIndex: 2217
{
	// Methods

	// RVA: 0x7AD720 Offset: 0x7AC920 VA: 0x1807AD720 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x7AD790 Offset: 0x7AC990 VA: 0x1807AD790
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class MyPlatformHardwareJoystickMapPlatformMap.PlatformMap : MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase // TypeDefIndex: 2218
{
	// Fields
	public MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x7AD7D0 Offset: 0x7AC9D0 VA: 0x1807AD7D0 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x7AD790 Offset: 0x7AC990 VA: 0x1807AD790
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria : HardwareJoystickMapCustomPlatformMap.MatchingCriteria // TypeDefIndex: 2219
{
	// Fields
	public uint vendorId; // 0x40
	public uint productId; // 0x44

	// Methods

	// RVA: 0x7ABB70 Offset: 0x7AAD70 VA: 0x1807ABB70 Slot: 13
	public override bool Matches(object customIdentifier) { }

	// RVA: 0x7ABAA0 Offset: 0x7AACA0 VA: 0x1807ABAA0 Slot: 14
	protected override object CreateInstance() { }

	// RVA: 0x7ABAF0 Offset: 0x7AACF0 VA: 0x1807ABAF0 Slot: 15
	protected override void DeepClone(object destination) { }

	// RVA: 0x7ABC00 Offset: 0x7AAE00 VA: 0x1807ABC00
	public void .ctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public sealed class MyPlatformHardwareJoystickMapPlatformMap : HardwareJoystickMapCustomPlatformMapSO // TypeDefIndex: 2220
{
	// Fields
	public MyPlatformHardwareJoystickMapPlatformMap.PlatformMap platformMap; // 0x20

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public override HardwareJoystickMap.Platform GetPlatformMap() { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
public sealed class MyPlatformInputSource.Joystick : CustomPlatformInputSource.Joystick, IControllerVibrator // TypeDefIndex: 2221
{
	// Fields
	private UnityInputJoystickSource.Joystick _sourceJoystick; // 0x90

	// Properties
	public UnityInputJoystickSource.Joystick sourceJoystick { get; }
	public int vibrationMotorCount { get; }

	// Methods

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public UnityInputJoystickSource.Joystick get_sourceJoystick() { }

	// RVA: 0x7AB9E0 Offset: 0x7AABE0 VA: 0x1807AB9E0
	public void .ctor(UnityInputJoystickSource.Joystick sourceJoystick) { }

	// RVA: 0x7AB7A0 Offset: 0x7AA9A0 VA: 0x1807AB7A0 Slot: 4
	public override void Update() { }

	// RVA: 0x7ABA80 Offset: 0x7AAC80 VA: 0x1807ABA80 Slot: 12
	public int get_vibrationMotorCount() { }

	// RVA: 0x7AAB50 Offset: 0x7A9D50 VA: 0x1807AAB50 Slot: 13
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x7AB360 Offset: 0x7AA560 VA: 0x1807AB360 Slot: 14
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x7AB4F0 Offset: 0x7AA6F0 VA: 0x1807AB4F0 Slot: 15
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x7AB160 Offset: 0x7AA360 VA: 0x1807AB160 Slot: 16
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x7AA9B0 Offset: 0x7A9BB0 VA: 0x1807AA9B0 Slot: 17
	public float GetVibration(int motorIndex) { }

	// RVA: 0x7AB6B0 Offset: 0x7AA8B0 VA: 0x1807AB6B0 Slot: 18
	public void StopVibration() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public sealed class MyPlatformInputSource : CustomPlatformInputSource // TypeDefIndex: 2222
{
	// Fields
	private UnityInputJoystickSource _joystickInputSource; // 0x68
	private bool _initialized; // 0x70
	private bool _disposed; // 0x71

	// Properties
	public override bool isReady { get; }

	// Methods

	// RVA: 0x6167C0 Offset: 0x6159C0 VA: 0x1806167C0 Slot: 12
	public override bool get_isReady() { }

	// RVA: 0x7ACF60 Offset: 0x7AC160 VA: 0x1807ACF60
	public void .ctor(CustomPlatformConfigVars configVars) { }

	// RVA: 0x7ACDF0 Offset: 0x7ABFF0 VA: 0x1807ACDF0 Slot: 6
	protected override void OnInitialize() { }

	// RVA: 0x7ACE20 Offset: 0x7AC020 VA: 0x1807ACE20 Slot: 13
	public override void Update() { }

	// RVA: 0x7AC990 Offset: 0x7ABB90 VA: 0x1807AC990
	private void MonitorDeviceChanges() { }

	// RVA: 0x7AC970 Offset: 0x7ABB70 VA: 0x1807AC970 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x7AC7F0 Offset: 0x7AB9F0 VA: 0x1807AC7F0
	private static bool ContainsJoystickBySystemId(IList<CustomInputSource.Joystick> joysticks, long systemId) { }

	// RVA: 0x7AC8C0 Offset: 0x7ABAC0 VA: 0x1807AC8C0
	private static bool ContainsSystemJoystickBySystemId(IList<UnityInputJoystickSource.Joystick> systemJoysticks, long systemId) { }
}

// Namespace: Rewired.Demos.CustomPlatform
public class MyPlatformUnifiedKeyboardSource : CustomPlatformUnifiedKeyboardSource // TypeDefIndex: 2223
{
	// Fields
	private static readonly KeyboardKeyCode[] keyCodes; // 0x0

	// Methods

	// RVA: 0x7AD120 Offset: 0x7AC320 VA: 0x1807AD120 Slot: 8
	protected override void OnInitialize() { }

	// RVA: 0x7AD2A0 Offset: 0x7AC4A0 VA: 0x1807AD2A0 Slot: 5
	protected override void Update() { }

	// RVA: 0x7AD4A0 Offset: 0x7AC6A0 VA: 0x1807AD4A0
	public void .ctor() { }

	// RVA: 0x7AD390 Offset: 0x7AC590 VA: 0x1807AD390
	private static void .cctor() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public class MyPlatformUnifiedMouseSource : CustomPlatformUnifiedMouseSource // TypeDefIndex: 2224
{
	// Properties
	public override Vector2 mousePosition { get; }

	// Methods

	// RVA: 0x7AD6B0 Offset: 0x7AC8B0 VA: 0x1807AD6B0 Slot: 11
	public override Vector2 get_mousePosition() { }

	// RVA: 0x7AD4B0 Offset: 0x7AC6B0 VA: 0x1807AD4B0 Slot: 5
	protected override void Update() { }

	// RVA: 0x7AD6A0 Offset: 0x7AC8A0 VA: 0x1807AD6A0
	public void .ctor() { }
}

// Namespace: 
public class UnityInputJoystickSource.Joystick : IControllerVibrator // TypeDefIndex: 2225
{
	// Fields
	private const int maxJoysticks = 8;
	private const int maxAxes = 10;
	private const int maxButtons = 20;
	public readonly long systemId; // 0x10
	public readonly string deviceName; // 0x18
	public Guid deviceInstanceGuid; // 0x20
	public readonly int axisCount; // 0x30
	public readonly int buttonCount; // 0x34
	public MyPlatformControllerIdentifier identifier; // 0x38
	public readonly bool[] buttonValues; // 0x40
	public readonly float[] axisValues; // 0x48
	public int unityIndex; // 0x50
	[CompilerGenerated]
	private int <vibrationMotorCount>k__BackingField; // 0x54

	// Properties
	public int vibrationMotorCount { get; set; }

	// Methods

	// RVA: 0x7AB940 Offset: 0x7AAB40 VA: 0x1807AB940
	public void .ctor(long systemId, string deviceName, int axisCount, int buttonCount) { }

	// RVA: 0x7AA980 Offset: 0x7A9B80 VA: 0x1807AA980
	public bool GetButtonValue(int index) { }

	// RVA: 0x7AA8C0 Offset: 0x7A9AC0 VA: 0x1807AA8C0
	public float GetAxisValue(int index) { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40 Slot: 4
	public int get_vibrationMotorCount() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_vibrationMotorCount(int value) { }

	// RVA: 0x7AACA0 Offset: 0x7A9EA0 VA: 0x1807AACA0 Slot: 5
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x7AA9D0 Offset: 0x7A9BD0 VA: 0x1807AA9D0 Slot: 6
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x7AADE0 Offset: 0x7A9FE0 VA: 0x1807AADE0 Slot: 7
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x7AAF80 Offset: 0x7AA180 VA: 0x1807AAF80 Slot: 8
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140 Slot: 9
	public float GetVibration(int motorIndex) { }

	// RVA: 0x7AB730 Offset: 0x7AA930 VA: 0x1807AB730 Slot: 10
	public void StopVibration() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public class UnityInputJoystickSource // TypeDefIndex: 2226
{
	// Fields
	private const float joystickCheckInterval = 1;
	private static int systemIdCounter; // 0x0
	private string[] _unityJoysticks; // 0x10
	private double _nextJoystickCheckTime; // 0x18
	private List<UnityInputJoystickSource.Joystick> _joysticks; // 0x20
	private ReadOnlyCollection<UnityInputJoystickSource.Joystick> _joysticks_readOnly; // 0x28

	// Methods

	// RVA: 0x7B91B0 Offset: 0x7B83B0 VA: 0x1807B91B0
	public void .ctor() { }

	// RVA: 0x7B89F0 Offset: 0x7B7BF0 VA: 0x1807B89F0
	public void Update() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IList<UnityInputJoystickSource.Joystick> GetJoysticks() { }

	// RVA: 0x7B89F0 Offset: 0x7B7BF0 VA: 0x1807B89F0
	private void CheckForJoystickChanges() { }

	// RVA: 0x7B8B30 Offset: 0x7B7D30 VA: 0x1807B8B30
	private bool DidJoysticksChange() { }

	// RVA: 0x7B8BE0 Offset: 0x7B7DE0 VA: 0x1807B8BE0
	private void RefreshJoysticks() { }
}

// Namespace: Rewired.Demos.CustomPlatform
public class VibrationTest : MonoBehaviour // TypeDefIndex: 2227
{
	// Fields
	public int playerId; // 0x20
	public float vibrationIncrement; // 0x24
	private float[] motors; // 0x28
	private static readonly string[] action_motors; // 0x0
	private static readonly string action_stop; // 0x8

	// Properties
	private Player player { get; }

	// Methods

	// RVA: 0x7B98E0 Offset: 0x7B8AE0 VA: 0x1807B98E0
	private Player get_player() { }

	// RVA: 0x7B9450 Offset: 0x7B8650 VA: 0x1807B9450
	private void Update() { }

	// RVA: 0x7B93C0 Offset: 0x7B85C0 VA: 0x1807B93C0
	private void StopVibration() { }

	// RVA: 0x7B9300 Offset: 0x7B8500 VA: 0x1807B9300
	private void SetVibration(int motorIndex, float value) { }

	// RVA: 0x7B9890 Offset: 0x7B8A90 VA: 0x1807B9890
	public void .ctor() { }

	// RVA: 0x7B97C0 Offset: 0x7B89C0 VA: 0x1807B97C0
	private static void .cctor() { }
}

// Namespace: PowerTools
[RequireComponent(typeof(Animator))]
[DisallowMultipleComponent]
public class SpriteAnim : SpriteAnimEventHandler // TypeDefIndex: 2228
{
	// Fields
	private static readonly string STATE_NAME; // 0x0
	private static readonly string CONTROLLER_PATH; // 0x8
	[SerializeField]
	private AnimationClip m_defaultAnim; // 0x30
	private static RuntimeAnimatorController m_sharedAnimatorController; // 0x10
	private Animator m_animator; // 0x38
	private AnimatorOverrideController m_controller; // 0x40
	private SpriteAnimNodes m_nodes; // 0x48
	private List<KeyValuePair<AnimationClip, AnimationClip>> m_clipPairList; // 0x50
	private AnimationClip m_currAnim; // 0x58
	private float m_speed; // 0x60
	private bool m_initialized; // 0x64

	// Properties
	public bool Playing { get; }
	public bool Paused { get; set; }
	public float Speed { get; set; }
	public int FrameTime { get; set; }
	public float Time { get; set; }
	public float NormalizedTime { get; set; }
	public AnimationClip Clip { get; }
	public string ClipName { get; }

	// Methods

	// RVA: 0x7B6E50 Offset: 0x7B6050 VA: 0x1807B6E50
	public bool get_Playing() { }

	// RVA: 0x7B6300 Offset: 0x7B5500 VA: 0x1807B6300
	public bool get_Paused() { }

	// RVA: 0x7B6EA0 Offset: 0x7B60A0 VA: 0x1807B6EA0
	public void set_Paused(bool value) { }

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	public float get_Speed() { }

	// RVA: 0x7B6B70 Offset: 0x7B5D70 VA: 0x1807B6B70
	public void set_Speed(float value) { }

	// RVA: 0x7B6E30 Offset: 0x7B6030 VA: 0x1807B6E30
	public int get_FrameTime() { }

	// RVA: 0x7B6E70 Offset: 0x7B6070 VA: 0x1807B6E70
	public void set_FrameTime(int value) { }

	// RVA: 0x7B6E60 Offset: 0x7B6060 VA: 0x1807B6E60
	public float get_Time() { }

	// RVA: 0x7B6EE0 Offset: 0x7B60E0 VA: 0x1807B6EE0
	public void set_Time(float value) { }

	// RVA: 0x7B5F70 Offset: 0x7B5170 VA: 0x1807B5F70
	public float get_NormalizedTime() { }

	// RVA: 0x7B6E90 Offset: 0x7B6090 VA: 0x1807B6E90
	public void set_NormalizedTime(float value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public AnimationClip get_Clip() { }

	// RVA: 0x7B6D90 Offset: 0x7B5F90 VA: 0x1807B6D90
	public string get_ClipName() { }

	// RVA: 0x7B65E0 Offset: 0x7B57E0 VA: 0x1807B65E0
	public void Play(AnimationClip anim, float speed = 1) { }

	// RVA: 0x7B6C50 Offset: 0x7B5E50 VA: 0x1807B6C50
	public void Stop() { }

	// RVA: 0x7B65B0 Offset: 0x7B57B0 VA: 0x1807B65B0
	public void Pause() { }

	// RVA: 0x7B6A20 Offset: 0x7B5C20 VA: 0x1807B6A20
	public void Resume() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public AnimationClip GetCurrentAnimation() { }

	// RVA: 0x7B64A0 Offset: 0x7B56A0 VA: 0x1807B64A0
	public bool IsPlaying(AnimationClip clip) { }

	// RVA: 0x7B6390 Offset: 0x7B5590 VA: 0x1807B6390
	public bool IsPlaying(string animName) { }

	// RVA: 0x7B6300 Offset: 0x7B5500 VA: 0x1807B6300
	public bool IsPaused() { }

	// RVA: 0x7B6B70 Offset: 0x7B5D70 VA: 0x1807B6B70
	public void SetSpeed(float speed) { }

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	public float GetSpeed() { }

	// RVA: 0x7B6040 Offset: 0x7B5240 VA: 0x1807B6040
	public float GetTime() { }

	// RVA: 0x7B6BA0 Offset: 0x7B5DA0 VA: 0x1807B6BA0
	public void SetTime(float time) { }

	// RVA: 0x7B5F70 Offset: 0x7B5170 VA: 0x1807B5F70
	public float GetNormalisedTime() { }

	// RVA: 0x7B6A50 Offset: 0x7B5C50 VA: 0x1807B6A50
	public void SetNormalizedTime(float ratio) { }

	// RVA: 0x7B6130 Offset: 0x7B5330 VA: 0x1807B6130
	public void Initialize() { }

	// RVA: 0x7B5D90 Offset: 0x7B4F90 VA: 0x1807B5D90
	private void Awake() { }

	// RVA: 0x7B68B0 Offset: 0x7B5AB0 VA: 0x1807B68B0
	private void Reset() { }

	// RVA: 0x7B6D10 Offset: 0x7B5F10 VA: 0x1807B6D10
	public void .ctor() { }

	// RVA: 0x7B6C80 Offset: 0x7B5E80 VA: 0x1807B6C80
	private static void .cctor() { }
}

// Namespace: 
public static class SpriteAnimEventHandler.EventParser // TypeDefIndex: 2229
{
	// Fields
	public static readonly char MESSAGE_DELIMITER; // 0x0
	public static readonly string MESSAGE_NOPARAM; // 0x8
	public static readonly string MESSAGE_INT; // 0x10
	public static readonly string MESSAGE_FLOAT; // 0x18
	public static readonly string MESSAGE_STRING; // 0x20
	public static readonly string MESSAGE_OBJECT_FUNCNAME; // 0x28
	public static readonly string MESSAGE_OBJECT_DATA; // 0x30

	// Methods

	// RVA: 0x7A57F0 Offset: 0x7A49F0 VA: 0x1807A57F0
	public static int ParseInt(ref string messageString) { }

	// RVA: 0x7A5720 Offset: 0x7A4920 VA: 0x1807A5720
	public static float ParseFloat(ref string messageString) { }

	// RVA: 0x7A58B0 Offset: 0x7A4AB0 VA: 0x1807A58B0
	public static string ParseString(ref string messageString) { }

	// RVA: 0x7A5970 Offset: 0x7A4B70 VA: 0x1807A5970
	private static void .cctor() { }
}

// Namespace: PowerTools
[DisallowMultipleComponent]
public class SpriteAnimEventHandler : MonoBehaviour // TypeDefIndex: 2230
{
	// Fields
	private string m_eventWithObjectMessage; // 0x20
	private object m_eventWithObjectData; // 0x28

	// Methods

	// RVA: 0x7B4810 Offset: 0x7B3A10 VA: 0x1807B4810
	private void _Anim(string function) { }

	// RVA: 0x7B4460 Offset: 0x7B3660 VA: 0x1807B4460
	private void _AnimInt(string messageString) { }

	// RVA: 0x7B4320 Offset: 0x7B3520 VA: 0x1807B4320
	private void _AnimFloat(string messageString) { }

	// RVA: 0x7B4710 Offset: 0x7B3910 VA: 0x1807B4710
	private void _AnimString(string messageString) { }

	// RVA: 0x7B4650 Offset: 0x7B3850 VA: 0x1807B4650
	private void _AnimObjectFunc(string funcName) { }

	// RVA: 0x7B4590 Offset: 0x7B3790 VA: 0x1807B4590
	private void _AnimObjectData(Object data) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: PowerTools
public class SpriteAnimNodes : MonoBehaviour // TypeDefIndex: 2231
{
	// Fields
	public static readonly int NUM_NODES; // 0x0
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node0; // 0x20
	[HideInInspector]
	[SerializeField]
	private Vector2 m_node1; // 0x28
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node2; // 0x30
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node3; // 0x38
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node4; // 0x40
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node5; // 0x48
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node6; // 0x50
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node7; // 0x58
	[SerializeField]
	[HideInInspector]
	private Vector2 m_node8; // 0x60
	[HideInInspector]
	[SerializeField]
	private Vector2 m_node9; // 0x68
	[SerializeField]
	[HideInInspector]
	private float m_ang0; // 0x70
	[HideInInspector]
	[SerializeField]
	private float m_ang1; // 0x74
	[SerializeField]
	[HideInInspector]
	private float m_ang2; // 0x78
	[SerializeField]
	[HideInInspector]
	private float m_ang3; // 0x7C
	[HideInInspector]
	[SerializeField]
	private float m_ang4; // 0x80
	[HideInInspector]
	[SerializeField]
	private float m_ang5; // 0x84
	[SerializeField]
	[HideInInspector]
	private float m_ang6; // 0x88
	[SerializeField]
	[HideInInspector]
	private float m_ang7; // 0x8C
	[HideInInspector]
	[SerializeField]
	private float m_ang8; // 0x90
	[HideInInspector]
	[SerializeField]
	private float m_ang9; // 0x94
	private SpriteRenderer m_spriteRenderer; // 0x98

	// Methods

	// RVA: 0x7B5580 Offset: 0x7B4780 VA: 0x1807B5580
	public Vector3 GetPosition(int nodeId, bool ignoredPivot = False) { }

	// RVA: 0x7B4FE0 Offset: 0x7B41E0 VA: 0x1807B4FE0
	public Vector3 GetLocalPosition(int nodeId, bool ignoredPivot = False) { }

	// RVA: 0x7B4E00 Offset: 0x7B4000 VA: 0x1807B4E00
	public float GetAngle(int nodeId) { }

	// RVA: 0x7B5400 Offset: 0x7B4600 VA: 0x1807B5400
	public Vector2 GetPositionRaw(int nodeId) { }

	// RVA: 0x7B4D60 Offset: 0x7B3F60 VA: 0x1807B4D60
	public float GetAngleRaw(int nodeId) { }

	// RVA: 0x7B5840 Offset: 0x7B4A40 VA: 0x1807B5840
	public void Reset() { }

	// RVA: 0x7B5B10 Offset: 0x7B4D10 VA: 0x1807B5B10
	public void .ctor() { }

	// RVA: 0x7B5AD0 Offset: 0x7B4CD0 VA: 0x1807B5AD0
	private static void .cctor() { }
}

// Namespace: PowerTools
[ExecuteInEditMode]
public class SpriteAnimNodeSync : MonoBehaviour // TypeDefIndex: 2232
{
	// Fields
	public int NodeId; // 0x20
	public SpriteAnimNodes Parent; // 0x28
	public SpriteRenderer ParentRenderer; // 0x30
	public SpriteRenderer Renderer; // 0x38
	[HideInInspector]
	public Vector3 flipOffset; // 0x40
	[HideInInspector]
	public Vector3 normalOffset; // 0x4C

	// Methods

	// RVA: 0x7B4820 Offset: 0x7B3A20 VA: 0x1807B4820
	public void LateUpdate() { }

	// RVA: 0x7B4CD0 Offset: 0x7B3ED0 VA: 0x1807B4CD0
	public void .ctor() { }
}

// Namespace: PowerTools
public class WaitForAnimationFinish : IEnumerator // TypeDefIndex: 2233
{
	// Fields
	private SpriteAnim animator; // 0x10
	private AnimationClip clip; // 0x18
	private bool first; // 0x20
	private int stopFrame; // 0x24

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x7B9A20 Offset: 0x7B8C20 VA: 0x1807B9A20
	public void .ctor(SpriteAnim animator, AnimationClip clip, bool restartIfAlreadyPlaying = True, int stopAtFrame = -1) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public object get_Current() { }

	// RVA: 0x7B9940 Offset: 0x7B8B40 VA: 0x1807B9940 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x7B99E0 Offset: 0x7B8BE0 VA: 0x1807B99E0 Slot: 6
	public void Reset() { }
}

// Namespace: xCloud
public struct GameInputTouchPoint // TypeDefIndex: 2234
{
	// Fields
	public float X; // 0x0
	public float Y; // 0x4
}

// Namespace: xCloud
public static class GameInput // TypeDefIndex: 2235
{}

// Namespace: xCloud
public static class Plugin // TypeDefIndex: 2236
{}

// Namespace: xCloud
public static class XGameStreaming // TypeDefIndex: 2237
{}

// Namespace: GameCore
public class AccountPicker : MonoBehaviour // TypeDefIndex: 2238
{
	// Fields
	public TextMeshPro text; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: GameCore
public class GameCoreLocalizationProvider : LocalizationProvider // TypeDefIndex: 2239
{
	// Methods

	// RVA: 0x7A6E00 Offset: 0x7A6000 VA: 0x1807A6E00 Slot: 4
	public override string GetLocalizedText(LocalizationKeys key) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: GameCore
public class GameCoreManager : MonoBehaviour // TypeDefIndex: 2240
{
	// Fields
	public LocalizationProvider LocalizationProvider; // 0x20
	[CompilerGenerated]
	private static GameCoreManager <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private UserManager <UserManager>k__BackingField; // 0x28
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x30
	[CompilerGenerated]
	private SaveManager <SaveManager>k__BackingField; // 0x38
	[CompilerGenerated]
	private StoreManager <StoreManager>k__BackingField; // 0x40
	public Action OnSuspend; // 0x48
	public Action<double> OnResume; // 0x50
	public Action<bool> OnResourceChange; // 0x58
	private Thread dispatchJob; // 0x60
	private bool stopExecution; // 0x68
	private Dictionary<string, ulong> puid2xuid; // 0x70
	private List<KeyValuePair<string, ulong>> xUIDsToCheckIfBlocked; // 0x78
	private HashSet<string> nonXuids; // 0x80
	private Dictionary<string, string> censoredTexts; // 0x88

	// Properties
	public static GameCoreManager Instance { get; set; }
	public UserManager UserManager { get; set; }
	public NetworkManager NetworkManager { get; set; }
	public SaveManager SaveManager { get; set; }
	public StoreManager StoreManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7A7120 Offset: 0x7A6320 VA: 0x1807A7120
	public static GameCoreManager get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x7A7160 Offset: 0x7A6360 VA: 0x1807A7160
	private static void set_Instance(GameCoreManager value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public UserManager get_UserManager() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_UserManager(UserManager value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_NetworkManager(NetworkManager value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public SaveManager get_SaveManager() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_SaveManager(SaveManager value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public StoreManager get_StoreManager() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_StoreManager(StoreManager value) { }

	// RVA: 0x7A6EB0 Offset: 0x7A60B0 VA: 0x1807A6EB0
	private void Awake() { }

	// RVA: 0x7A7000 Offset: 0x7A6200 VA: 0x1807A7000
	public void .ctor() { }
}

// Namespace: GameCore
public class HandleEvents : MonoBehaviour // TypeDefIndex: 2241
{
	// Fields
	[CompilerGenerated]
	private static HandleEvents <Instance>k__BackingField; // 0x0
	public SpriteRenderer FillScreen; // 0x20

	// Properties
	public static HandleEvents Instance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7A97B0 Offset: 0x7A89B0 VA: 0x1807A97B0
	public static HandleEvents get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x7A97F0 Offset: 0x7A89F0 VA: 0x1807A97F0
	private static void set_Instance(HandleEvents value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public enum HrErrorCode.ErrorCode // TypeDefIndex: 2242
{
	// Fields
	public uint value__; // 0x0
	public const HrErrorCode.ErrorCode E_GAME_MISSING_GAME_CONFIG = 2279931935;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_NOT_INITIALIZED = 2300838144;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_DLL_NOT_FOUND = 2300838145;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_VERSION_MISMATCH = 2300838146;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_WINDOW_NOT_FOREGROUND = 2300838147;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_SUSPENDED = 2300838148;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_UNINITIALIZE_ACTIVEOBJECTS = 2300838149;
	public const HrErrorCode.ErrorCode E_GAMERUNTIME_MULTIPLAYER_NOT_CONFIGURED = 2300838150;
	public const HrErrorCode.ErrorCode E_GAMEUSER_MAX_USERS_ADDED = 2300858624;
	public const HrErrorCode.ErrorCode E_GAMEUSER_SIGNED_OUT = 2300858625;
	public const HrErrorCode.ErrorCode E_GAMEUSER_RESOLVE_USER_ISSUE_REQUIRED = 2300858626;
	public const HrErrorCode.ErrorCode E_GAMEUSER_DEFERRAL_NOT_AVAILABLE = 2300858627;
	public const HrErrorCode.ErrorCode E_GAMEUSER_USER_NOT_FOUND = 2300858628;
	public const HrErrorCode.ErrorCode E_GAMEUSER_NO_TOKEN_REQUIRED = 2300858629;
	public const HrErrorCode.ErrorCode E_GAMEUSER_NO_DEFAULT_USER = 2300858630;
	public const HrErrorCode.ErrorCode E_GAMEUSER_FAILED_TO_RESOLVE = 2300858631;
	public const HrErrorCode.ErrorCode E_GAMEUSER_NO_TITLE_ID = 2300858632;
	public const HrErrorCode.ErrorCode E_GAMEUSER_UNKNOWN_GAME_IDENTITY = 2300858633;
	public const HrErrorCode.ErrorCode E_GAMEUSER_NO_PACKAGE_IDENTITY = 2300858640;
	public const HrErrorCode.ErrorCode E_GAMEUSER_FAILED_TO_GET_TOKEN = 2300858641;
	public const HrErrorCode.ErrorCode E_GAMEUSER_INVALID_APP_CONFIGURATION = 2300858642;
	public const HrErrorCode.ErrorCode E_GAMEUSER_MALFORMED_MSAAPPID = 2300858643;
	public const HrErrorCode.ErrorCode E_GAMEUSER_INCONSISTENT_MSAAPPID_AND_TITLEID = 2300858644;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_APP_NOT_PACKAGED = 2300858880;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_NO_INSTALLED_LANGUAGES = 2300858881;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_NO_STORE_ID = 2300858882;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_INVALID_SELECTOR = 2300858883;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_DOWNLOAD_REQUIRED = 2300858884;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_NO_TAG_CHANGE = 2300858885;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_DLC_NOT_SUPPORTED = 2300858886;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_DUPLICATE_ID_VALUES = 2300858887;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_NO_PACKAGE_IDENTIFIER = 2300858888;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_NO_ROOT_NODE = 2300858889;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_ZERO_VERSION = 2300858890;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_NO_MSAAPPID_NOTITLEID = 2300858891;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_DEPRECATED_PC_ENTRIES = 2300858892;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_SUM_REQUIRES_MSAAPPID = 2300858893;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_NO_CODE_CLOUD_SAVES_REQUIRES_MSAAPPID = 2300858894;
	public const HrErrorCode.ErrorCode E_GAMEPACKAGE_CONFIG_MSAAPPID_OR_TITLEID_IS_DEFAULT = 2300858895;
	public const HrErrorCode.ErrorCode E_GAMESTORE_LICENSE_ACTION_NOT_APPLICABLE_TO_PRODUCT = 2300859136;
	public const HrErrorCode.ErrorCode E_GAMESTORE_NETWORK_ERROR = 2300859137;
	public const HrErrorCode.ErrorCode E_GAMESTORE_SERVER_ERROR = 2300859138;
	public const HrErrorCode.ErrorCode E_GAMESTORE_INSUFFICIENT_QUANTITY = 2300859139;
	public const HrErrorCode.ErrorCode E_GAMESTORE_ALREADY_PURCHASED = 2300859140;
	public const HrErrorCode.ErrorCode E_GAMESTREAMING_NOT_INITIALIZED = 2300859392;
	public const HrErrorCode.ErrorCode E_GAMESTREAMING_CLIENT_NOT_CONNECTED = 2300859393;
	public const HrErrorCode.ErrorCode E_GAMESTREAMING_NO_DATA = 2300859394;
	public const HrErrorCode.ErrorCode E_GAMESTREAMING_NO_DATACENTER = 2300859395;
	public const HrErrorCode.ErrorCode E_GAMESTREAMING_NOT_STREAMING_CONTROLLER = 2300859396;
}

// Namespace: GameCore
public static class HrErrorCode // TypeDefIndex: 2243
{
	// Fields
	private static Dictionary<uint, string> ErrorMessages; // 0x0

	// Methods

	// RVA: 0x7A9830 Offset: 0x7A8A30 VA: 0x1807A9830
	public static string GetHrErrorCode(int hresult) { }

	// RVA: 0x7A9990 Offset: 0x7A8B90 VA: 0x1807A9990
	private static void .cctor() { }
}

// Namespace: GameCore
public enum LocalizationKeys // TypeDefIndex: 2244
{
	// Fields
	public int value__; // 0x0
	public const LocalizationKeys SaveGameOutOfSpaceMessage = 0;
	public const LocalizationKeys SaveGameOutOfSpaceConfirm = 1;
	public const LocalizationKeys SaveGameOutOfSpaceCancel = 2;
	public const LocalizationKeys ControllerDisconnectedMessage = 3;
}

// Namespace: GameCore
public abstract class LocalizationProvider : MonoBehaviour // TypeDefIndex: 2245
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetLocalizedText(LocalizationKeys key);

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
public sealed class NetworkManager.OnInvitedCallback : MulticastDelegate // TypeDefIndex: 2246
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string connectionString) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string connectionString, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: GameCore
public class NetworkManager // TypeDefIndex: 2247
{
	// Fields
	public NetworkManager.OnInvitedCallback OnInvited; // 0x10
	[CompilerGenerated]
	private bool <IsInviteHandled>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ConnectionString>k__BackingField; // 0x20
	[CompilerGenerated]
	private char <ConnectionStringDeliminator>k__BackingField; // 0x28

	// Properties
	public bool IsInviteHandled { get; set; }
	public string ConnectionString { get; set; }
	public char ConnectionStringDeliminator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsInviteHandled() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_IsInviteHandled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ConnectionString() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ConnectionString(string value) { }

	[CompilerGenerated]
	// RVA: 0x7AD700 Offset: 0x7AC900 VA: 0x1807AD700
	public char get_ConnectionStringDeliminator() { }

	[CompilerGenerated]
	// RVA: 0x7AD710 Offset: 0x7AC910 VA: 0x1807AD710
	private void set_ConnectionStringDeliminator(char value) { }

	// RVA: 0x7AD6E0 Offset: 0x7AC8E0 VA: 0x1807AD6E0
	public void .ctor() { }
}

// Namespace: GameCore
public class SaveManager // TypeDefIndex: 2248
{
	// Fields
	private const int E_GS_NO_ACCESS = -1994129152;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: GameCore
public class StoreManager // TypeDefIndex: 2249
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum UserManager.UserOpResult // TypeDefIndex: 2250
{
	// Fields
	public int value__; // 0x0
	public const UserManager.UserOpResult Success = 0;
	public const UserManager.UserOpResult NoDefaultUser = 1;
	public const UserManager.UserOpResult ResolveUserIssueRequired = 2;
	public const UserManager.UserOpResult UnclearedVetoes = 3;
	public const UserManager.UserOpResult UnknownError = 4;
}

// Namespace: 
private enum UserManager.State // TypeDefIndex: 2251
{
	// Fields
	public int value__; // 0x0
	public const UserManager.State Initializing = 0;
	public const UserManager.State GetContext = 1;
	public const UserManager.State WaitForAddingUser = 2;
	public const UserManager.State GetBasicInfo = 3;
	public const UserManager.State InitializeNetwork = 4;
	public const UserManager.State GrabAchievements = 5;
	public const UserManager.State UserDisplayImage = 6;
	public const UserManager.State ReturnMuteList = 7;
	public const UserManager.State ReturnAvoidList = 8;
	public const UserManager.State UserPermissionsCheck = 9;
	public const UserManager.State WaitForNextTask = 10;
	public const UserManager.State Error = 11;
	public const UserManager.State Idle = 12;
	public const UserManager.State End = 13;
}

// Namespace: 
public class UserManager.UserData // TypeDefIndex: 2252
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public sealed class UserManager.AddUserCompletedDelegate : MulticastDelegate // TypeDefIndex: 2253
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(UserManager.UserOpResult result) { }

	// RVA: 0x79F3E0 Offset: 0x79E5E0 VA: 0x18079F3E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UserManager.UserOpResult result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: GameCore
public class UserManager // TypeDefIndex: 2254
{
	// Fields
	private const int E_GAMEUSER_NO_DEFAULT_USER = -1994108666;
	public const bool isSingleUserGame = True;
	public List<UserManager.UserData> UserDataList; // 0x10
	private UserManager.UserData primaryUser; // 0x18

	// Properties
	public UserManager.UserData PrimaryUser { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public UserManager.UserData get_PrimaryUser() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void set_PrimaryUser(UserManager.UserData value) { }

	// RVA: 0x7B9290 Offset: 0x7B8490 VA: 0x1807B9290
	public void .ctor() { }
}

// Namespace: RewiredConsts
public static class Action // TypeDefIndex: 2255
{
	// Fields
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Pause the game")]
	public const int Pause = 1;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MoveHorizontal")]
	public const int MoveHorizontal = 2;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MoveHorizontalR")]
	public const int MoveHorizontalR = 54;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MoveVertical")]
	public const int MoveVertical = 3;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MoveVerticalR")]
	public const int MoveVerticalR = 55;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Map Toggle Sabotage")]
	public const int ToggleMap = 4;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Task Toggle")]
	public const int ToggleTasks = 5;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Use Vent as Impostor")]
	public const int UseVent = 50;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Interact Pet (Hold)")]
	public const int ActionPrimary = 6;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Kill")]
	public const int ActionSecondary = 8;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Report")]
	public const int ActionTertiary = 7;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Role Ability")]
	public const int ActionQuaternary = 49;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuHorizontal")]
	public const int MenuHorizontal = 9;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuVertical")]
	public const int MenuVertical = 10;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuConfirm")]
	public const int MenuConfirm = 11;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuCancel")]
	public const int MenuCancel = 12;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "TaskLHorizontal")]
	public const int TaskLHorizontal = 13;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "TaskLVertical")]
	public const int TaskLVertical = 14;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "TaskRHorizontal")]
	public const int TaskRHorizontal = 16;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "TaskRVertical")]
	public const int TaskRVertical = 17;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "ButtonChat")]
	public const int ButtonChat = 18;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "ButtonStart")]
	public const int ButtonStart = 19;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Task Left Trigger")]
	public const int TaskLT = 24;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Task Left Bumper")]
	public const int TaskLB = 20;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Task Right Trigger")]
	public const int TaskRT = 21;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Task Right Bumper")]
	public const int TaskRB = 22;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuUp")]
	public const int MenuUp = 25;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuDown")]
	public const int MenuDown = 26;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuRight")]
	public const int MenuRight = 27;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuLeft")]
	public const int MenuLeft = 28;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Other button used for tasks that isn t A (X on xbox controller)")]
	public const int TaskConfirmAlt = 29;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Secondary navigation using right stick")]
	public const int MenuHorizontalAlt = 30;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Secondary navigation using right stick")]
	public const int MenuVerticalAlt = 31;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Because we ve hit the point where we need all 4 face buttons when in a task")]
	public const int TaskConfirmTertiary = 32;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Open virtual keyboard")]
	public const int ButtonKeyboard = 33;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuRT")]
	public const int MenuRT = 34;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuLT")]
	public const int MenuLT = 35;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "chat ban button")]
	public const int ButtonBan = 36;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "AccountPicker")]
	public const int AccountPicker = 37;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "toggle in-game player list")]
	public const int TogglePlayerList = 38;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Move Left")]
	public const int KBLeft = 39;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Move Right")]
	public const int KBRight = 40;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Move Down")]
	public const int KBDown = 42;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Move Up")]
	public const int KBUp = 44;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Clicking in the right stick")]
	public const int TaskR3Click = 51;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuLB")]
	public const int MenuLB = 52;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "MenuRB")]
	public const int MenuRB = 53;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Debug Next Page")]
	public const int DebugPageNext = 56;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Debug Previous Page")]
	public const int DebugPagePrev = 57;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Debug Next Subpage")]
	public const int DebugSubpageNext = 58;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Debug Previous Subpage")]
	public const int DebugSubpagePrev = 59;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugNavVertical")]
	public const int DebugNavVertical = 63;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugNavHorizontal")]
	public const int DebugNavHorizontal = 75;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugConfirm")]
	public const int DebugConfirm = 65;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugCancel")]
	public const int DebugCancel = 66;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugToolStart")]
	public const int DebugToolStart = 60;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugToolCopy")]
	public const int DebugToolCopy = 67;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "DebugToolClear")]
	public const int DebugToolClear = 68;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Quick Chat Favorite")]
	public const int QuickChatFavorite = 69;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Quick Chat Clear")]
	public const int QuickChatClear = 70;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Quick Chat Open")]
	public const int QuickChatOpen = 72;
	[ActionIdFieldInfo(categoryName = "Default", friendlyName = "Chat Send")]
	public const int ChatSend = 71;
	[ActionIdFieldInfo(categoryName = "System", friendlyName = "Restricted")]
	public const int Restricted = 47;
	[ActionIdFieldInfo(categoryName = "System", friendlyName = "Restricted2")]
	public const int Restricted2 = 48;
}

// Namespace: RewiredConsts
public static class Category // TypeDefIndex: 2256
{
	// Fields
	public const int Default = 0;
	public const int Gameplay = 1;
	public const int Menu = 2;
	public const int Task = 3;
	public const int QuickChat = 4;
	public const int Protected_Keyboard_Controls = 5;
	public const int Debug = 6;
}

// Namespace: RewiredConsts
public static class Player // TypeDefIndex: 2257
{
	// Fields
	[PlayerIdFieldInfo(friendlyName = "System")]
	public const int System = 9999999;
	[PlayerIdFieldInfo(friendlyName = "Player0")]
	public const int Player0 = 0;
}

// Namespace: nn.profiler
internal class NxCpuProfiler // TypeDefIndex: 2258
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Update() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUsServer
public enum ExtensionFailureReasons // TypeDefIndex: 2259
{
	// Fields
	public byte value__; // 0x0
	public const ExtensionFailureReasons Invalid = 0;
	public const ExtensionFailureReasons WrongGameState = 1;
	public const ExtensionFailureReasons OutOfExtensionThreshold = 2;
	public const ExtensionFailureReasons NoExtensionAvailable = 3;
	public const ExtensionFailureReasons WrongExtensionId = 4;
	public const ExtensionFailureReasons ExtensionAlreadyRequested = 5;
}

// Namespace: InnerNet
[Serializable]
public class ClientData // TypeDefIndex: 2260
{
	// Fields
	public int Id; // 0x10
	public bool InScene; // 0x14
	public bool IsReady; // 0x15
	public bool HasBeenReported; // 0x16
	public bool IsBeingCreated; // 0x17
	public PlayerControl Character; // 0x18
	public readonly uint PlayerLevel; // 0x20
	public readonly PlatformSpecificData PlatformData; // 0x28
	public string PlayerName; // 0x30
	public string ProductUserId; // 0x38
	public string FriendCode; // 0x40
	public int ColorId; // 0x48

	// Methods

	// RVA: 0x79F5B0 Offset: 0x79E7B0 VA: 0x18079F5B0
	public void .ctor(int id, string playerName, PlatformSpecificData platformData, uint playerLevel, string productUserId, string friendCode) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void UpdatePlayerName(string playerName) { }
}

// Namespace: InnerNet
public static class CrossplayMode // TypeDefIndex: 2261
{
	// Methods

	// RVA: 0x7A06F0 Offset: 0x79F8F0 VA: 0x1807A06F0
	public static int GetCrossplayFlags() { }
}

// Namespace: InnerNet
public static class CryptoHelpers // TypeDefIndex: 2262
{
	// Methods

	// RVA: 0x7A0760 Offset: 0x79F960 VA: 0x1807A0760
	public static byte[] DecodePEM(string pemData) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GameCode.<>c // TypeDefIndex: 2263
{
	// Fields
	public static readonly GameCode.<>c <>9; // 0x0
	public static Func<char, bool> <>9__3_0; // 0x8
	public static Func<char, bool> <>9__4_0; // 0x10
	public static Func<char, bool> <>9__8_0; // 0x18
	public static Func<char, bool> <>9__9_0; // 0x20

	// Methods

	// RVA: 0x7B84A0 Offset: 0x7B76A0 VA: 0x1807B84A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B8180 Offset: 0x7B7380 VA: 0x1807B8180
	internal bool <IntToGameName>b__3_0(char c) { }

	// RVA: 0x7B8160 Offset: 0x7B7360 VA: 0x1807B8160
	internal bool <GameNameToInt>b__4_0(char c) { }

	// RVA: 0x7B8180 Offset: 0x7B7380 VA: 0x1807B8180
	internal bool <IntToGameNameV2>b__8_0(char c) { }

	// RVA: 0x7B8180 Offset: 0x7B7380 VA: 0x1807B8180
	internal bool <GameNameToIntV2>b__9_0(char c) { }

	// RVA: 0x7B82A0 Offset: 0x7B74A0 VA: 0x1807B82A0
	internal int <.cctor>b__10_0(int v) { }
}

// Namespace: InnerNet
public static class GameCode // TypeDefIndex: 2264
{
	// Fields
	public const int V2Flag = -2147483648;
	public const int MaxGameNumber = 676;
	public static readonly int GameCodeV2MinVersion; // 0x0
	private static readonly string V2; // 0x8
	private static readonly int[] V2Map; // 0x10

	// Methods

	// RVA: 0x7A6AA0 Offset: 0x7A5CA0 VA: 0x1807A6AA0
	public static string IntToGameName(int gameId) { }

	// RVA: 0x7A6520 Offset: 0x7A5720 VA: 0x1807A6520
	public static int GameNameToInt(string gameId) { }

	// RVA: 0x7A61E0 Offset: 0x7A53E0 VA: 0x1807A61E0
	public static int CreateGameId(int sn, int gn) { }

	// RVA: 0x7A6720 Offset: 0x7A5920 VA: 0x1807A6720
	private static string IntToGameNameV2(int gameId) { }

	// RVA: 0x7A6200 Offset: 0x7A5400 VA: 0x1807A6200
	private static int GameNameToIntV2(string gameId) { }

	// RVA: 0x7A6C80 Offset: 0x7A5E80 VA: 0x1807A6C80
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GameFilterOptions.<>c // TypeDefIndex: 2265
{
	// Fields
	public static readonly GameFilterOptions.<>c <>9; // 0x0
	public static Func<StringNames, bool> <>9__2_0; // 0x8
	public static Func<StringNames, string> <>9__2_1; // 0x10

	// Methods

	// RVA: 0x7B8440 Offset: 0x7B7640 VA: 0x1807B8440
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B81A0 Offset: 0x7B73A0 VA: 0x1807B81A0
	internal bool <ResetToDefaults>b__2_0(StringNames n) { }

	// RVA: 0x7B8220 Offset: 0x7B7420 VA: 0x1807B8220
	internal string <ResetToDefaults>b__2_1(StringNames n) { }
}

// Namespace: InnerNet
public class GameFilterOptions // TypeDefIndex: 2266
{
	// Fields
	public DateTime LastRefreshTime; // 0x10
	public HashSet<string> FilterTags; // 0x18

	// Methods

	// RVA: 0x7A7270 Offset: 0x7A6470 VA: 0x1807A7270
	public void ResetToDefaults(DateTime lastRefreshTime) { }

	// RVA: 0x7A7510 Offset: 0x7A6710 VA: 0x1807A7510
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7A71A0 Offset: 0x7A63A0 VA: 0x1807A71A0
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7A7650 Offset: 0x7A6850 VA: 0x1807A7650
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerDiscover.<RunClient>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2267
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerDiscover <>4__this; // 0x20

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

	// RVA: 0x7CF820 Offset: 0x7CEA20 VA: 0x1807CF820 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF910 Offset: 0x7CEB10 VA: 0x1807CF910 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerDiscover.<RunServer>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2268
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerDiscover <>4__this; // 0x20
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

	// RVA: 0x7CF950 Offset: 0x7CEB50 VA: 0x1807CF950 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CFA10 Offset: 0x7CEC10 VA: 0x1807CFA10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: InnerNet
public class InnerDiscover : DestroyableSingleton<InnerDiscover> // TypeDefIndex: 2269
{
	// Fields
	private UdpBroadcastListener listener; // 0x28
	private UdpBroadcaster sender; // 0x30
	public int Port; // 0x38
	public float Interval; // 0x3C
	[CompilerGenerated]
	private Action<BroadcastPacket> OnPacketGet; // 0x40

	// Methods

	[CompilerGenerated]
	// RVA: 0x7AA6D0 Offset: 0x7A98D0 VA: 0x1807AA6D0
	public void add_OnPacketGet(Action<BroadcastPacket> value) { }

	[CompilerGenerated]
	// RVA: 0x7AA780 Offset: 0x7A9980 VA: 0x1807AA780
	public void remove_OnPacketGet(Action<BroadcastPacket> value) { }

	// RVA: 0x7AA4E0 Offset: 0x7A96E0 VA: 0x1807AA4E0
	public void StartAsServer(string data) { }

	[IteratorStateMachine(typeof(InnerDiscover.<RunServer>d__8))]
	// RVA: 0x7AA280 Offset: 0x7A9480 VA: 0x1807AA280
	private IEnumerator RunServer() { }

	// RVA: 0x7AA650 Offset: 0x7A9850 VA: 0x1807AA650
	public void StopServer() { }

	// RVA: 0x7AA2F0 Offset: 0x7A94F0 VA: 0x1807AA2F0
	public void StartAsClient() { }

	[IteratorStateMachine(typeof(InnerDiscover.<RunClient>d__11))]
	// RVA: 0x7AA210 Offset: 0x7A9410 VA: 0x1807AA210
	private IEnumerator RunClient() { }

	// RVA: 0x7AA620 Offset: 0x7A9820 VA: 0x1807AA620
	public void StopClient() { }

	// RVA: 0x7AA1A0 Offset: 0x7A93A0 VA: 0x1807AA1A0 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x7AA680 Offset: 0x7A9880 VA: 0x1807AA680
	public void .ctor() { }
}

// Namespace: InnerNet
public enum MatchMakerModes // TypeDefIndex: 2270
{
	// Fields
	public int value__; // 0x0
	public const MatchMakerModes None = 0;
	public const MatchMakerModes Client = 1;
	public const MatchMakerModes HostAndClient = 2;
}

// Namespace: 
public enum InnerNetClient.GameStates // TypeDefIndex: 2271
{
	// Fields
	public int value__; // 0x0
	public const InnerNetClient.GameStates NotJoined = 0;
	public const InnerNetClient.GameStates Joined = 1;
	public const InnerNetClient.GameStates Started = 2;
	public const InnerNetClient.GameStates Ended = 3;
}

// Namespace: 
public class InnerNetClient.TotalGameData // TypeDefIndex: 2272
{
	// Fields
	public int[] PerMapTotals; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class InnerNetClient.RecentPlayerComparer : IComparer<ClientData> // TypeDefIndex: 2273
{
	// Fields
	public static readonly InnerNetClient.RecentPlayerComparer Instance; // 0x0

	// Methods

	// RVA: 0x7CB200 Offset: 0x7CA400 VA: 0x1807CB200 Slot: 4
	public int Compare(ClientData x, ClientData y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CB360 Offset: 0x7CA560 VA: 0x1807CB360
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InnerNetClient.<>c // TypeDefIndex: 2274
{
	// Fields
	public static readonly InnerNetClient.<>c <>9; // 0x0
	public static Func<byte, string> <>9__66_0; // 0x8
	public static Func<byte, string> <>9__67_0; // 0x10
	public static Action<GameObject> <>9__162_0; // 0x18

	// Methods

	// RVA: 0x7D02D0 Offset: 0x7CF4D0 VA: 0x1807D02D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFA50 Offset: 0x7CEC50 VA: 0x1807CFA50
	internal string <Connection_DataReceivedRaw>b__66_0(byte b) { }

	// RVA: 0x7CFA50 Offset: 0x7CEC50 VA: 0x1807CFA50
	internal string <Connection_DataSentRaw>b__67_0(byte b) { }

	// RVA: 0x7CFA70 Offset: 0x7CEC70 VA: 0x1807CFA70
	internal void <RemoveUnownedObjects>b__162_0(GameObject gameObject) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass102_0 // TypeDefIndex: 2275
{
	// Fields
	public int clientId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <GetRecentClient>b__0(ClientData c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass103_0 // TypeDefIndex: 2276
{
	// Fields
	public InnerNetClient <>4__this; // 0x10
	public ClientData client; // 0x18
	public DisconnectReasons reason; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFBC0 Offset: 0x7CEDC0 VA: 0x1807CFBC0
	internal void <RemovePlayer>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass166_0 // TypeDefIndex: 2277
{
	// Fields
	public uint spawnId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x698F60 Offset: 0x698160 VA: 0x180698F60
	internal bool <CoHandleSpawn>b__0(InnerNetObject f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass76_0 // TypeDefIndex: 2278
{
	// Fields
	public InnerNetClient <>4__this; // 0x10
	public DisconnectReasons reason; // 0x18
	public string stringReason; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFD90 Offset: 0x7CEF90 VA: 0x1807CFD90
	internal void <EnqueueDisconnect>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_0 // TypeDefIndex: 2279
{
	// Fields
	public ReportOutcome outcome; // 0x10
	public int clientId; // 0x14
	public string playerName; // 0x18
	public ReportReasons reason; // 0x20
	public InnerNetClient <>4__this; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFE80 Offset: 0x7CF080 VA: 0x1807CFE80
	internal void <HandleMessage>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_1 // TypeDefIndex: 2280
{
	// Fields
	public EndGameResult endGameResult; // 0x10
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFED0 Offset: 0x7CF0D0 VA: 0x1807CFED0
	internal void <HandleMessage>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_2 // TypeDefIndex: 2281
{
	// Fields
	public List<PlatformSpecificData> received; // 0x10
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFF10 Offset: 0x7CF110 VA: 0x1807CFF10
	internal void <HandleMessage>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_3 // TypeDefIndex: 2282
{
	// Fields
	public ClientData client; // 0x10
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFF40 Offset: 0x7CF140 VA: 0x1807CFF40
	internal void <HandleMessage>b__7() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_4 // TypeDefIndex: 2283
{
	// Fields
	public MessageReader subReader; // 0x10
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFF80 Offset: 0x7CF180 VA: 0x1807CFF80
	internal void <HandleMessage>b__9() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_5 // TypeDefIndex: 2284
{
	// Fields
	public MessageReader subReader; // 0x10
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFF80 Offset: 0x7CF180 VA: 0x1807CFF80
	internal void <HandleMessage>b__10() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_6 // TypeDefIndex: 2285
{
	// Fields
	public InnerNetClient.TotalGameData totals; // 0x10
	public HttpMatchmakerManager.FindGamesListFilteredResponse response; // 0x18
	public InnerNetClient <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFFB0 Offset: 0x7CF1B0 VA: 0x1807CFFB0
	internal void <HandleMessage>b__11() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass96_7 // TypeDefIndex: 2286
{
	// Fields
	public uint address; // 0x10
	public ushort port; // 0x14
	public InnerNetClient <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFFF0 Offset: 0x7CF1F0 VA: 0x1807CFFF0
	internal void <HandleMessage>b__13() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass98_0 // TypeDefIndex: 2287
{
	// Fields
	public ClientData client; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7D01F0 Offset: 0x7CF3F0 VA: 0x1807D01F0
	internal bool <GetOrCreateClient>b__0(ClientData c) { }

	// RVA: 0x7D01F0 Offset: 0x7CF3F0 VA: 0x1807D01F0
	internal bool <GetOrCreateClient>b__1(ClientData c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<>c__DisplayClass99_0 // TypeDefIndex: 2288
{
	// Fields
	public int clientId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x575670 Offset: 0x574870 VA: 0x180575670
	internal bool <GetClient>b__0(ClientData c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<CoConnect>d__65 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2289
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerNetClient <>4__this; // 0x20
	public string matchmakerToken; // 0x28
	private string <ipAddr>5__2; // 0x30

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

	// RVA: 0x7CC8A0 Offset: 0x7CBAA0 VA: 0x1807CC8A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CCED0 Offset: 0x7CC0D0 VA: 0x1807CCED0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<CoConnect>d__69 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2290
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerNetClient <>4__this; // 0x20
	public MatchMakerModes mode; // 0x28
	public string matchmakerToken; // 0x30

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

	// RVA: 0x7CCF10 Offset: 0x7CC110 VA: 0x1807CCF10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CD470 Offset: 0x7CC670 VA: 0x1807CD470 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<CoHandleSpawn>d__166 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2291
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MessageReader reader; // 0x20
	public InnerNetClient <>4__this; // 0x28
	private InnerNetClient.<>c__DisplayClass166_0 <>8__1; // 0x30
	private int <ownerId>5__2; // 0x38
	private ClientData <ownerClient>5__3; // 0x40
	private int <frames>5__4; // 0x48
	private AsyncOperationHandle<GameObject> <spawnPrefab>5__5; // 0x50

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

	// RVA: 0x7CD4B0 Offset: 0x7CC6B0 VA: 0x1807CD4B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CDEE0 Offset: 0x7CD0E0 VA: 0x1807CDEE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<CoSendSceneChange>d__156 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2292
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerNetClient <>4__this; // 0x20
	public string sceneName; // 0x28

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

	// RVA: 0x7CDF20 Offset: 0x7CD120 VA: 0x1807CDF20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CE290 Offset: 0x7CD490 VA: 0x1807CE290 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<HandleGameDataInner>d__165 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2293
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MessageReader reader; // 0x20
	public InnerNetClient <>4__this; // 0x28
	public int msgNum; // 0x30
	private int <cnt>5__2; // 0x34
	private InnerNetObjectCollection <>7__wrap2; // 0x38
	private bool <>7__wrap3; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7CF560 Offset: 0x7CE760 VA: 0x1807CF560 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7CE2D0 Offset: 0x7CD4D0 VA: 0x1807CE2D0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7CF7B0 Offset: 0x7CE9B0 VA: 0x1807CF7B0
	private void <>m__Finally1() { }

	// RVA: 0x7CF7E0 Offset: 0x7CE9E0 VA: 0x1807CF7E0
	private void <>m__Finally2() { }

	// RVA: 0x7CF7B0 Offset: 0x7CE9B0 VA: 0x1807CF7B0
	private void <>m__Finally3() { }

	// RVA: 0x7CF800 Offset: 0x7CEA00 VA: 0x1807CF800
	private void <>m__Finally4() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7CF520 Offset: 0x7CE720 VA: 0x1807CF520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<WaitForConnectionOrFail>d__70 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2294
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InnerNetClient <>4__this; // 0x20

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

	// RVA: 0x7D0450 Offset: 0x7CF650 VA: 0x1807D0450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D04F0 Offset: 0x7CF6F0 VA: 0x1807D04F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetClient.<WaitWithTimeout>d__71 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2295
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Func<bool> success; // 0x20
	public InnerNetClient <>4__this; // 0x28
	public int durationSeconds; // 0x30
	public string errorMessage; // 0x38
	private bool <failed>5__2; // 0x40
	private float <timer>5__3; // 0x44

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

	// RVA: 0x7D0530 Offset: 0x7CF730 VA: 0x1807D0530 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D0640 Offset: 0x7CF840 VA: 0x1807D0640 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: InnerNet
public abstract class InnerNetClient : MonoBehaviour // TypeDefIndex: 2296
{
	// Fields
	private static readonly HashSet<DisconnectReasons> DontBotherLoggingTheseDisconnectReasons; // 0x0
	public const int MaxRecentClients = 20;
	private const int DefaultSecondsSuspendedBeforeDisconnect = 30;
	public static int SecondsSuspendedBeforeDisconnect; // 0x8
	public const int NoClientId = -1;
	private readonly Logger serverLogger; // 0x20
	private string networkAddress; // 0x28
	private int networkPort; // 0x30
	private bool useDtls; // 0x34
	private UnityUdpClientConnection connection; // 0x38
	public MatchMakerModes mode; // 0x40
	public NetworkModes NetworkMode; // 0x44
	public int GameId; // 0x48
	public int HostId; // 0x4C
	public int ClientId; // 0x50
	protected List<ClientData> allClients; // 0x58
	protected CircleBuffer<ClientData> recentClients; // 0x60
	public DisconnectReasons LastDisconnectReason; // 0x68
	public string LastCustomDisconnect; // 0x70
	public byte LastServerChatMode; // 0x78
	public HttpMatchmakerManager.MatchmakerError LastMatchmakerError; // 0x80
	private readonly List<Action> PreSpawnDispatcher; // 0x88
	private readonly List<Action> Dispatcher; // 0x90
	private readonly List<SpawnGameDataMessage> sendInitialDataSpawnGameDataMessages; // 0x98
	private readonly GameOptionsFactory gameOptionsFactory; // 0xA0
	[CompilerGenerated]
	private bool <IsGamePublic>k__BackingField; // 0xA8
	public InnerNetClient.GameStates GameState; // 0xAC
	private bool isConnecting; // 0xB0
	private bool platformSpecificsChecked; // 0xB1
	private List<Action> TempQueue; // 0xB8
	private bool appPaused; // 0xC0
	public const int CurrentClient = -3;
	public const int HostInherit = -2;
	public const int ServerOwned = -4;
	public const int MinServerID = 100000;
	private const int MaxMessageSizeBytes = 500;
	public float MinSendInterval; // 0xC4
	private uint NetIdCnt; // 0xC8
	private float timer; // 0xCC
	public AssetReference[] SpawnableObjects; // 0xD0
	public InnerNetObject[] NonAddressableSpawnableObjects; // 0xD8
	protected InnerNetObjectCollection allObjects; // 0xE0
	private bool InOnlineScene; // 0xE8
	private HashSet<uint> DestroyedObjects; // 0xF0
	private Queue<IGameDataMessage> reliableMessageQueue; // 0xF8
	private Queue<IGameDataMessage> unreliableMessageQueue; // 0x100
	private int numberOfConsecutiveFramesWithReliableMessages; // 0x108
	private int numberOfConsecutiveFramesWithUnreliableMessages; // 0x10C
	private int indexForReliableStreamedUpdates; // 0x110
	private int indexForUnreliableStreamedUpdates; // 0x114
	private int msgNum; // 0x118

	// Properties
	public bool AmConnected { get; }
	public int Ping { get; }
	public int BytesSent { get; }
	public int BytesGot { get; }
	public int Resends { get; }
	public bool AmHost { get; }
	public bool AmLocalHost { get; }
	public bool AmModdedHost { get; }
	public bool AmClient { get; }
	public bool IsGamePublic { get; set; }
	public bool IsGameStarted { get; }
	public bool IsGameOver { get; }
	public bool IsInGame { get; }

	// Methods

	// RVA: 0x7C3D10 Offset: 0x7C2F10 VA: 0x1807C3D10
	public void SetEndpoint(string addr, ushort port, bool dtls) { }

	// RVA: 0x7C5010 Offset: 0x7C4210 VA: 0x1807C5010
	public bool get_AmConnected() { }

	// RVA: 0x7C51A0 Offset: 0x7C43A0 VA: 0x1807C51A0
	public int get_Ping() { }

	// RVA: 0x7C5140 Offset: 0x7C4340 VA: 0x1807C5140
	public int get_BytesSent() { }

	// RVA: 0x7C5110 Offset: 0x7C4310 VA: 0x1807C5110
	public int get_BytesGot() { }

	// RVA: 0x7C51E0 Offset: 0x7C43E0 VA: 0x1807C51E0
	public int get_Resends() { }

	// RVA: 0x7C5020 Offset: 0x7C4220 VA: 0x1807C5020
	public bool get_AmHost() { }

	// RVA: 0x7C5030 Offset: 0x7C4230 VA: 0x1807C5030
	public bool get_AmLocalHost() { }

	// RVA: 0x7C50B0 Offset: 0x7C42B0 VA: 0x1807C50B0
	public bool get_AmModdedHost() { }

	// RVA: 0x7C5000 Offset: 0x7C4200 VA: 0x1807C5000
	public bool get_AmClient() { }

	[CompilerGenerated]
	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_IsGamePublic() { }

	[CompilerGenerated]
	// RVA: 0x7385D0 Offset: 0x7377D0 VA: 0x1807385D0
	private void set_IsGamePublic(bool value) { }

	// RVA: 0x7C5180 Offset: 0x7C4380 VA: 0x1807C5180
	public bool get_IsGameStarted() { }

	// RVA: 0x7C5170 Offset: 0x7C4370 VA: 0x1807C5170
	public bool get_IsGameOver() { }

	// RVA: 0x7C5190 Offset: 0x7C4390 VA: 0x1807C5190
	public bool get_IsInGame() { }

	// RVA: 0x7C4070 Offset: 0x7C3270 VA: 0x1807C4070 Slot: 4
	public virtual void Start() { }

	// RVA: 0x7C38F0 Offset: 0x7C2AF0 VA: 0x1807C38F0
	private void SendOrDisconnect(MessageWriter msg) { }

	// RVA: 0x7BE4D0 Offset: 0x7BD6D0 VA: 0x1807BE4D0
	public ClientData GetHost() { }

	// RVA: 0x7BDD80 Offset: 0x7BCF80 VA: 0x1807BDD80
	public ClientData GetClientFromCharacter(PlayerControl character) { }

	// RVA: 0x7BDF20 Offset: 0x7BD120 VA: 0x1807BDF20
	public ClientData GetClientFromPlayerInfo(NetworkedPlayerInfo playerInfo) { }

	// RVA: 0x7BE0B0 Offset: 0x7BD2B0 VA: 0x1807BE0B0
	public int GetClientIdFromCharacter(PlayerControl character) { }

	// RVA: 0x7C1520 Offset: 0x7C0720 VA: 0x1807C1520 Slot: 5
	public virtual void OnDestroy() { }

	[IteratorStateMachine(typeof(InnerNetClient.<CoConnect>d__65))]
	// RVA: 0x7BC990 Offset: 0x7BBB90 VA: 0x1807BC990
	public IEnumerator CoConnect(string matchmakerToken) { }

	// RVA: 0x7BCBF0 Offset: 0x7BBDF0 VA: 0x1807BCBF0
	private void Connection_DataReceivedRaw(byte[] data) { }

	// RVA: 0x7BCD70 Offset: 0x7BBF70 VA: 0x1807BCD70
	private void Connection_DataSentRaw(byte[] data, int length) { }

	// RVA: 0x7BCB60 Offset: 0x7BBD60 VA: 0x1807BCB60
	public void Connect(MatchMakerModes mode, string matchmakerToken) { }

	[IteratorStateMachine(typeof(InnerNetClient.<CoConnect>d__69))]
	// RVA: 0x7BCA00 Offset: 0x7BBC00 VA: 0x1807BCA00
	private IEnumerator CoConnect(MatchMakerModes mode, string matchmakerToken) { }

	[IteratorStateMachine(typeof(InnerNetClient.<WaitForConnectionOrFail>d__70))]
	// RVA: 0x7C4910 Offset: 0x7C3B10 VA: 0x1807C4910
	public IEnumerator WaitForConnectionOrFail() { }

	[IteratorStateMachine(typeof(InnerNetClient.<WaitWithTimeout>d__71))]
	// RVA: 0x7C4A50 Offset: 0x7C3C50 VA: 0x1807C4A50
	private IEnumerator WaitWithTimeout(Func<bool> success, string errorMessage, int durationSeconds = 15) { }

	// RVA: 0x7C4470 Offset: 0x7C3670 VA: 0x1807C4470 Slot: 6
	public virtual void Update() { }

	// RVA: 0x7C1540 Offset: 0x7C0740 VA: 0x1807C1540
	private void OnDisconnect(object sender, DisconnectedEventArgs e) { }

	// RVA: 0x7BEC50 Offset: 0x7BDE50 VA: 0x1807BEC50
	public void HandleDisconnect(DisconnectReasons reason, string stringReason) { }

	// RVA: 0x7BD830 Offset: 0x7BCA30 VA: 0x1807BD830
	public void EnqueueDisconnect(DisconnectReasons reason, string stringReason) { }

	// RVA: 0x7BD230 Offset: 0x7BC430 VA: 0x1807BD230
	protected void DisconnectInternal(DisconnectReasons reason, string stringReason) { }

	// RVA: 0x7C0DC0 Offset: 0x7BFFC0 VA: 0x1807C0DC0
	public void HostGame(IGameOptions settings, GameFilterOptions filterOpts) { }

	// RVA: 0x7C2A30 Offset: 0x7C1C30 VA: 0x1807C2A30
	public void ReportPlayer(int clientId, ReportReasons reason) { }

	// RVA: 0x7C0F20 Offset: 0x7C0120 VA: 0x1807C0F20
	public void JoinGame() { }

	// RVA: 0x7BC870 Offset: 0x7BBA70 VA: 0x1807BC870
	public bool CanBan() { }

	// RVA: 0x7BC890 Offset: 0x7BBA90 VA: 0x1807BC890
	public bool CanKick() { }

	// RVA: 0x7C1220 Offset: 0x7C0420 VA: 0x1807C1220
	public void KickPlayer(int clientId, bool ban) { }

	// RVA: 0x7C3E50 Offset: 0x7C3050 VA: 0x1807C3E50
	public MessageWriter StartEndGame() { }

	// RVA: 0x7BDB50 Offset: 0x7BCD50 VA: 0x1807BDB50
	public void FinishEndGame(MessageWriter msg) { }

	// RVA: 0x7C3810 Offset: 0x7C2A10 VA: 0x1807C3810
	protected void SendLateRejection(int targetId, DisconnectReasons reason) { }

	// RVA: 0x7C2F50 Offset: 0x7C2150 VA: 0x1807C2F50
	protected void SendClientReady() { }

	// RVA: 0x7C3B50 Offset: 0x7C2D50 VA: 0x1807C3B50
	protected void SendStartGame() { }

	// RVA: 0x7C2B20 Offset: 0x7C1D20 VA: 0x1807C2B20
	public void RequestGameList(IGameOptions settings, GameFilterOptions filterOpts) { }

	// RVA: 0x7BC8B0 Offset: 0x7BBAB0 VA: 0x1807BC8B0
	public void ChangeGamePublic(bool isPublic) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetGameSession(string session) { }

	// RVA: 0x7C3C50 Offset: 0x7C2E50 VA: 0x1807C3C50
	public void SetActivePodType(string podType) { }

	// RVA: 0x7C2170 Offset: 0x7C1370 VA: 0x1807C2170
	public void QueryPlatformIds() { }

	// RVA: 0x7C1930 Offset: 0x7C0B30 VA: 0x1807C1930
	private void OnQueryPlatformData(List<PlatformSpecificData> playerData) { }

	// RVA: 0x7C17F0 Offset: 0x7C09F0 VA: 0x1807C17F0
	private void OnMessageReceived(DataReceivedEventArgs e) { }

	// RVA: 0x7BEEC0 Offset: 0x7BE0C0 VA: 0x1807BEEC0
	private void HandleMessage(MessageReader reader, SendOption sendOption) { }

	// RVA: 0x7BC690 Offset: 0x7BB890 VA: 0x1807BC690
	public static string AddressToString(uint address) { }

	// RVA: 0x7BE650 Offset: 0x7BD850 VA: 0x1807BE650
	private ClientData GetOrCreateClient(ClientData client) { }

	// RVA: 0x7BE0E0 Offset: 0x7BD2E0 VA: 0x1807BE0E0
	public ClientData GetClient(int clientId) { }

	// RVA: 0x7BDC80 Offset: 0x7BCE80 VA: 0x1807BDC80
	public void GetAllClients(List<ClientData> buffer) { }

	// RVA: 0x7BEB30 Offset: 0x7BDD30 VA: 0x1807BEB30
	public void GetRecentClients(List<ClientData> buffer) { }

	// RVA: 0x7BE9D0 Offset: 0x7BDBD0 VA: 0x1807BE9D0
	public ClientData GetRecentClient(int clientId) { }

	// RVA: 0x7C23F0 Offset: 0x7C15F0 VA: 0x1807C23F0
	private void RemovePlayer(int playerIdThatLeft, DisconnectReasons reason) { }

	// RVA: 0x7C13C0 Offset: 0x7C05C0 VA: 0x1807C13C0 Slot: 7
	protected virtual void OnApplicationPause(bool pause) { }

	// RVA: 0x7C4970 Offset: 0x7C3B70 VA: 0x1807C4970
	private void WaitToDisconnect(object state) { }

	// RVA: 0x7C31E0 Offset: 0x7C23E0 VA: 0x1807C31E0
	protected void SendInitialData(int clientId) { }

	// RVA: 0x7C3060 Offset: 0x7C2260 VA: 0x1807C3060
	private void SendGameManager(int clientId, GameManager gameManager) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnGameCreated(string gameIdString);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnGameJoined(string gameIdString);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnWaitForHost(string gameIdString);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract IEnumerator CoStartGame();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnGameEnd(EndGameResult endGameResult);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBecomeHost();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPlayerJoined(ClientData client);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract IEnumerator CoOnPlayerChangedScene(ClientData client, string targetScene);

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnPlayerLeft(ClientData client, DisconnectReasons reason);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnDisconnected();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void PreDisconnectInternal();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnSetPSNSessionId(string sessionId) { }

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnGetGameList(InnerNetClient.TotalGameData totalGames, HttpMatchmakerManager.FindGamesListFilteredResponse gamesResponse);

	// RVA: 0x7BE240 Offset: 0x7BD440 VA: 0x1807BE240
	private byte[] GetConnectionData(bool useDtlsLayout, string matchmakerToken) { }

	// RVA: 0x7BD9E0 Offset: 0x7BCBE0 VA: 0x1807BD9E0
	protected ClientData FindClientById(int id) { }

	// RVA: 0x7BDC00 Offset: 0x7BCE00 VA: 0x1807BDC00
	private void FixedUpdate() { }

	// RVA: 0x7C4410 Offset: 0x7C3610 VA: 0x1807C4410
	protected void UpdateCachedClients(ClientData clientData, PlayerControl character) { }

	// RVA: 0x7C2CA0 Offset: 0x7C1EA0 VA: 0x1807C2CA0
	private void SendAllStreamedObjects() { }

	// RVA: -1 Offset: -1
	public T FindObjectByNetId<T>(uint netId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24630 Offset: 0xA23830 VA: 0x180A24630
	|-InnerNetClient.FindObjectByNetId<object>
	*/

	// RVA: 0x7C3ED0 Offset: 0x7C30D0 VA: 0x1807C3ED0
	public MessageWriter StartRpcImmediately(uint targetNetId, byte callId, SendOption option, int targetClientId = -1) { }

	// RVA: 0x7BDBA0 Offset: 0x7BCDA0 VA: 0x1807BDBA0
	public void FinishRpcImmediately(MessageWriter msg) { }

	// RVA: 0x7C3BF0 Offset: 0x7C2DF0 VA: 0x1807C3BF0
	public void SendXuidToAll() { }

	// RVA: 0x7C1300 Offset: 0x7C0500 VA: 0x1807C1300
	public void LateBroadcastReliableMessage(IGameDataMessage rpcMessage) { }

	// RVA: 0x7C1360 Offset: 0x7C0560 VA: 0x1807C1360
	public void LateBroadcastUnreliableMessage(IGameDataMessage rpcMessage) { }

	// RVA: 0x7C3A20 Offset: 0x7C2C20 VA: 0x1807C3A20
	private void SendSceneChange(string sceneName) { }

	[IteratorStateMachine(typeof(InnerNetClient.<CoSendSceneChange>d__156))]
	// RVA: 0x7BCAF0 Offset: 0x7BBCF0 VA: 0x1807BCAF0
	private IEnumerator CoSendSceneChange(string sceneName) { }

	// RVA: 0x7C3D20 Offset: 0x7C2F20 VA: 0x1807C3D20
	public void Spawn(InnerNetObject netObjParent, int ownerId = -2, SpawnFlags flags = 0) { }

	// RVA: 0x7BCF10 Offset: 0x7BC110 VA: 0x1807BCF10
	private SpawnGameDataMessage CreateSpawnMessage(InnerNetObject netObjParent, int ownerId, SpawnFlags flags) { }

	// RVA: 0x7BD110 Offset: 0x7BC310 VA: 0x1807BD110
	public void Despawn(InnerNetObject objToDespawn) { }

	// RVA: 0x7BC5A0 Offset: 0x7BB7A0 VA: 0x1807BC5A0
	private bool AddNetObject(InnerNetObject obj) { }

	// RVA: 0x7C2210 Offset: 0x7C1410 VA: 0x1807C2210
	public void RemoveNetObject(InnerNetObject obj) { }

	// RVA: 0x7C26C0 Offset: 0x7C18C0 VA: 0x1807C26C0
	public void RemoveUnownedObjects() { }

	// RVA: 0x7BED90 Offset: 0x7BDF90 VA: 0x1807BED90
	private void HandleGameData(MessageReader parentReader) { }

	[IteratorStateMachine(typeof(InnerNetClient.<HandleGameDataInner>d__165))]
	// RVA: 0x7BED10 Offset: 0x7BDF10 VA: 0x1807BED10
	private IEnumerator HandleGameDataInner(MessageReader reader, int msgNum) { }

	[IteratorStateMachine(typeof(InnerNetClient.<CoHandleSpawn>d__166))]
	// RVA: 0x7BCA80 Offset: 0x7BBC80 VA: 0x1807BCA80
	private IEnumerator CoHandleSpawn(MessageReader reader) { }

	// RVA: 0x7C1DA0 Offset: 0x7C0FA0 VA: 0x1807C1DA0
	private void PackAndSendQueuedMessages(Queue<IGameDataMessage> queue, SendOption sendOption, out bool thereAreQueuedMessagesLeft) { }

	// RVA: 0x7C1940 Offset: 0x7C0B40 VA: 0x1807C1940
	private void PackAndSendDirtyStreamedObjects(IReadOnlyList<InnerNetObject> streamCollection, SendOption sendOption, ref int trackingIndex) { }

	// RVA: 0x7C3FD0 Offset: 0x7C31D0 VA: 0x1807C3FD0
	private void StartStreamedObjectMessage(ref MessageWriter writer, SendOption option) { }

	// RVA: 0x7BE600 Offset: 0x7BD800 VA: 0x1807BE600
	private int GetMaxMessagePackingLimit() { }

	// RVA: 0x7C4C00 Offset: 0x7C3E00 VA: 0x1807C4C00
	protected void .ctor() { }

	// RVA: 0x7C4AE0 Offset: 0x7C3CE0 VA: 0x1807C4AE0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7C42D0 Offset: 0x7C34D0 VA: 0x1807C42D0
	private void <Start>b__58_0(Scene oldScene, Scene scene) { }

	[CompilerGenerated]
	// RVA: 0x7C4110 Offset: 0x7C3310 VA: 0x1807C4110
	private bool <CoConnect>b__69_0() { }

	[CompilerGenerated]
	// RVA: 0x7C4120 Offset: 0x7C3320 VA: 0x1807C4120
	private bool <CoConnect>b__69_1() { }

	[CompilerGenerated]
	// RVA: 0x7C4110 Offset: 0x7C3310 VA: 0x1807C4110
	private bool <CoConnect>b__69_2() { }

	[CompilerGenerated]
	// RVA: 0x7C4160 Offset: 0x7C3360 VA: 0x1807C4160
	private void <HandleMessage>b__96_1() { }

	[CompilerGenerated]
	// RVA: 0x7C41D0 Offset: 0x7C33D0 VA: 0x1807C41D0
	private void <HandleMessage>b__96_2() { }

	[CompilerGenerated]
	// RVA: 0x7C41F0 Offset: 0x7C33F0 VA: 0x1807C41F0
	private void <HandleMessage>b__96_5() { }

	[CompilerGenerated]
	// RVA: 0x7C4260 Offset: 0x7C3460 VA: 0x1807C4260
	private void <HandleMessage>b__96_6() { }

	[CompilerGenerated]
	// RVA: 0x7C41D0 Offset: 0x7C33D0 VA: 0x1807C41D0
	private void <HandleMessage>b__96_8() { }

	[CompilerGenerated]
	// RVA: 0x7C4130 Offset: 0x7C3330 VA: 0x1807C4130
	private void <HandleMessage>b__96_12() { }
}

// Namespace: InnerNet
[Serializable]
public struct GameListing // TypeDefIndex: 2297
{
	// Fields
	public uint IP; // 0x0
	public ushort Port; // 0x4
	public int GameId; // 0x8
	public byte PlayerCount; // 0xC
	public string HostName; // 0x10
	public string TrueHostName; // 0x18
	public string HostPlatformName; // 0x20
	public QuickChatModes QuickChat; // 0x28
	public Platforms Platform; // 0x2C
	public int Age; // 0x30
	public int MaxPlayers; // 0x34
	public int NumImpostors; // 0x38
	public byte MapId; // 0x3C
	public uint Language; // 0x40
	public IGameOptions Options; // 0x48

	// Properties
	public string IPString { get; }

	// Methods

	// RVA: 0x7BA750 Offset: 0x7B9950 VA: 0x1807BA750
	public string get_IPString() { }

	// RVA: 0x7BA660 Offset: 0x7B9860 VA: 0x1807BA660
	public static GameListing DeserializeV2(MessageReader reader) { }
}

// Namespace: InnerNet
[Flags]
public enum SpawnFlags // TypeDefIndex: 2298
{
	// Fields
	public byte value__; // 0x0
	public const SpawnFlags None = 0;
	public const SpawnFlags IsClientCharacter = 1;
}

// Namespace: InnerNet
public abstract class InnerNetObject : MonoBehaviour, IComparable<InnerNetObject> // TypeDefIndex: 2299
{
	// Fields
	public uint SpawnId; // 0x20
	public uint NetId; // 0x24
	protected uint DirtyBits; // 0x28
	public SpawnFlags SpawnFlags; // 0x2C
	public SendOption sendMode; // 0x2D
	public int OwnerId; // 0x30
	protected bool DespawnOnDestroy; // 0x34

	// Properties
	public virtual bool IsDirty { get; }
	public bool AmOwner { get; }

	// Methods

	// RVA: 0x7C5FB0 Offset: 0x7C51B0 VA: 0x1807C5FB0 Slot: 5
	public virtual bool get_IsDirty() { }

	// RVA: 0x7C5F60 Offset: 0x7C5160 VA: 0x1807C5F60
	public bool get_AmOwner() { }

	// RVA: 0x7C5D80 Offset: 0x7C4F80 VA: 0x1807C5D80
	public void Despawn() { }

	// RVA: 0x7C5E30 Offset: 0x7C5030 VA: 0x1807C5E30 Slot: 6
	public virtual void OnDestroy() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void HandleRpc(byte callId, MessageReader reader);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ClearOrDecrementDirt();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Serialize(MessageWriter writer, bool initialState);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Deserialize(MessageReader reader, bool initialState);

	// RVA: 0x7C5D50 Offset: 0x7C4F50 VA: 0x1807C5D50 Slot: 4
	public int CompareTo(InnerNetObject other) { }

	// RVA: 0x7C5E10 Offset: 0x7C5010 VA: 0x1807C5E10
	protected bool IsDirtyBitSet(int idx) { }

	// RVA: 0x7C5D40 Offset: 0x7C4F40 VA: 0x1807C5D40
	protected void ClearDirtyBits() { }

	// RVA: 0x7C5F40 Offset: 0x7C5140 VA: 0x1807C5F40
	protected void UnsetDirtyBit(uint val) { }

	// RVA: 0x7C5F30 Offset: 0x7C5130 VA: 0x1807C5F30
	protected void SetDirtyBit(uint val) { }

	// RVA: 0x7C5F50 Offset: 0x7C5150 VA: 0x1807C5F50
	protected void .ctor() { }
}

// Namespace: InnerNet
public class InnerNetObjectCollection // TypeDefIndex: 2300
{
	// Fields
	private readonly List<InnerNetObject> allObjects; // 0x10
	private readonly List<InnerNetObject> allReliableObjects; // 0x18
	private readonly List<InnerNetObject> allUnreliableObjects; // 0x20
	private readonly Dictionary<uint, InnerNetObject> allObjectsFast; // 0x28
	private readonly Logger logger; // 0x30

	// Properties
	public IReadOnlyList<InnerNetObject> AllObjects { get; }
	public IReadOnlyList<InnerNetObject> AllReliableObjects { get; }
	public IReadOnlyList<InnerNetObject> AllUnreliableObjects { get; }
	public IReadOnlyDictionary<uint, InnerNetObject> AllObjectsFast { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IReadOnlyList<InnerNetObject> get_AllObjects() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IReadOnlyList<InnerNetObject> get_AllReliableObjects() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IReadOnlyList<InnerNetObject> get_AllUnreliableObjects() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IReadOnlyDictionary<uint, InnerNetObject> get_AllObjectsFast() { }

	// RVA: 0x7C5210 Offset: 0x7C4410 VA: 0x1807C5210
	public void Clear() { }

	// RVA: 0x7C59F0 Offset: 0x7C4BF0 VA: 0x1807C59F0
	public bool TryAddNetObject(InnerNetObject obj) { }

	// RVA: 0x7C5500 Offset: 0x7C4700 VA: 0x1807C5500
	public void RemoveNetObject(InnerNetObject obj) { }

	// RVA: 0x7C5620 Offset: 0x7C4820 VA: 0x1807C5620
	public void RemoveNullObjects() { }

	// RVA: 0x7C5800 Offset: 0x7C4A00 VA: 0x1807C5800
	public void RemoveUnownedObjects(HashSet<int> clientIds, int ownerClientId, Action<GameObject> removalAction) { }

	// RVA: 0x7C52F0 Offset: 0x7C44F0 VA: 0x1807C52F0
	public void DestroyPlayerInfoObjects(Action<GameObject> destroyAction) { }

	// RVA: 0x7C5C20 Offset: 0x7C4E20 VA: 0x1807C5C20
	public void .ctor() { }
}

// Namespace: InnerNet
public enum JoinFailureReasons // TypeDefIndex: 2301
{
	// Fields
	public byte value__; // 0x0
	public const JoinFailureReasons TooManyPlayers = 1;
	public const JoinFailureReasons GameStarted = 2;
	public const JoinFailureReasons GameNotFound = 3;
	public const JoinFailureReasons HostNotReady = 4;
	public const JoinFailureReasons IncorrectVersion = 5;
	public const JoinFailureReasons Banned = 6;
	public const JoinFailureReasons Kicked = 7;
}

// Namespace: InnerNet
public enum GameStates // TypeDefIndex: 2302
{
	// Fields
	public byte value__; // 0x0
	public const GameStates NotStarted = 0;
	public const GameStates Started = 1;
	public const GameStates Ended = 2;
	public const GameStates Destroyed = 3;
}

// Namespace: InnerNet
public enum LimboStates // TypeDefIndex: 2303
{
	// Fields
	public int value__; // 0x0
	public const LimboStates PreSpawn = 0;
	public const LimboStates NotLimbo = 1;
	public const LimboStates WaitingForHost = 2;
}

// Namespace: InnerNet
public class UnityLogger : ILogger // TypeDefIndex: 2304
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void WriteVerbose(string msg) { }

	// RVA: 0x7D0720 Offset: 0x7CF920 VA: 0x1807D0720 Slot: 5
	public void WriteWarning(string msg) { }

	// RVA: 0x7D0680 Offset: 0x7CF880 VA: 0x1807D0680 Slot: 4
	public void WriteError(string msg) { }

	// RVA: 0x7D06D0 Offset: 0x7CF8D0 VA: 0x1807D06D0 Slot: 6
	public void WriteInfo(string msg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
protected class InnerNetServer.Player // TypeDefIndex: 2305
{
	// Fields
	private static int IdCount; // 0x0
	public int Id; // 0x10
	public Connection Connection; // 0x18
	public string PlayerName; // 0x20
	public PlatformSpecificData PlatformData; // 0x28
	public LimboStates LimboState; // 0x30

	// Methods

	// RVA: 0x7CB160 Offset: 0x7CA360 VA: 0x1807CB160
	public void .ctor(Connection connection, string playerName, PlatformSpecificData platformData) { }

	// RVA: 0x7CB120 Offset: 0x7CA320 VA: 0x1807CB120
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InnerNetServer.<>c // TypeDefIndex: 2306
{
	// Fields
	public static readonly InnerNetServer.<>c <>9; // 0x0
	public static Func<byte, string> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x7D0330 Offset: 0x7CF530 VA: 0x1807D0330
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFA50 Offset: 0x7CEC50 VA: 0x1807CFA50
	internal string <Connection_DataRecievedRaw>b__19_0(byte b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InnerNetServer.<>c__DisplayClass17_0 // TypeDefIndex: 2307
{
	// Fields
	public InnerNetServer <>4__this; // 0x10
	public InnerNetServer.Player client; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFD20 Offset: 0x7CEF20 VA: 0x1807CFD20
	internal void <OnServerConnect>b__0(DataReceivedEventArgs e) { }

	// RVA: 0x7CFD60 Offset: 0x7CEF60 VA: 0x1807CFD60
	internal void <OnServerConnect>b__1(object o, DisconnectedEventArgs e) { }
}

// Namespace: InnerNet
public class InnerNetServer : DestroyableSingleton<InnerNetServer> // TypeDefIndex: 2308
{
	// Fields
	public const int LocalGameId = 32;
	private const int InvalidHost = -1;
	private int HostId; // 0x28
	public PlatformSpecificData PlatformData; // 0x30
	public HashSet<string> ipBans; // 0x38
	public int Port; // 0x40
	[SerializeField]
	private GameStates GameState; // 0x44
	private UdpConnectionListener listener; // 0x48
	private List<InnerNetServer.Player> Clients; // 0x50

	// Methods

	// RVA: 0x7C7F40 Offset: 0x7C7140 VA: 0x1807C7F40 Slot: 5
	public override void OnDestroy() { }

	// RVA: 0x7C89B0 Offset: 0x7C7BB0 VA: 0x1807C89B0
	public void StartAsServer() { }

	// RVA: 0x7C7F90 Offset: 0x7C7190 VA: 0x1807C7F90
	private void OnInternalError(HazelInternalErrors errorType) { }

	// RVA: 0x7C8820 Offset: 0x7C7A20 VA: 0x1807C8820
	public void StartAsLocalServer() { }

	// RVA: 0x7C6630 Offset: 0x7C5830 VA: 0x1807C6630
	private void DebugString(string obj) { }

	// RVA: 0x7C8C30 Offset: 0x7C7E30 VA: 0x1807C8C30
	public void StopServer() { }

	// RVA: 0x7C76B0 Offset: 0x7C68B0 VA: 0x1807C76B0
	public static bool IsCompatibleVersion(int version) { }

	// RVA: 0x7C80A0 Offset: 0x7C72A0 VA: 0x1807C80A0
	private void OnServerConnect(NewConnectionEventArgs evt) { }

	// RVA: 0x7C8590 Offset: 0x7C7790 VA: 0x1807C8590
	private static void SendIncorrectVersion(Connection connection) { }

	// RVA: 0x7C6490 Offset: 0x7C5690 VA: 0x1807C6490
	private void Connection_DataRecievedRaw(byte[] data, int length) { }

	// RVA: 0x7C7DD0 Offset: 0x7C6FD0 VA: 0x1807C7DD0
	private void OnDataReceived(InnerNetServer.Player client, DataReceivedEventArgs evt) { }

	// RVA: 0x7C6870 Offset: 0x7C5A70 VA: 0x1807C6870
	private void HandleMessage(InnerNetServer.Player client, MessageReader reader, SendOption sendOption) { }

	// RVA: 0x7C7AB0 Offset: 0x7C6CB0 VA: 0x1807C7AB0
	private void KickPlayer(int targetId, bool ban) { }

	// RVA: 0x7C7720 Offset: 0x7C6920 VA: 0x1807C7720
	protected void JoinGame(InnerNetServer.Player client) { }

	// RVA: 0x7C71F0 Offset: 0x7C63F0 VA: 0x1807C71F0
	private void HandleRejoin(InnerNetServer.Player client) { }

	// RVA: 0x7C6D70 Offset: 0x7C5F70 VA: 0x1807C6D70
	private void HandleNewGameJoin(InnerNetServer.Player client) { }

	// RVA: 0x7C6690 Offset: 0x7C5890 VA: 0x1807C6690
	private void EndGame(MessageReader message, InnerNetServer.Player source) { }

	// RVA: 0x7C8B90 Offset: 0x7C7D90 VA: 0x1807C8B90
	private void StartGame(MessageReader message, InnerNetServer.Player source) { }

	// RVA: 0x7C6240 Offset: 0x7C5440 VA: 0x1807C6240
	private void ClientDisconnect(InnerNetServer.Player client) { }

	// RVA: 0x7C8640 Offset: 0x7C7840 VA: 0x1807C8640
	protected void SendTo(MessageWriter msg, int targetId) { }

	// RVA: 0x7C60F0 Offset: 0x7C52F0 VA: 0x1807C60F0
	protected void Broadcast(MessageWriter msg, InnerNetServer.Player source) { }

	// RVA: 0x7C5FC0 Offset: 0x7C51C0 VA: 0x1807C5FC0
	private void BroadcastJoinMessage(InnerNetServer.Player client, MessageWriter msg) { }

	// RVA: 0x7C8D30 Offset: 0x7C7F30 VA: 0x1807C8D30
	private void WriteJoinedMessage(InnerNetServer.Player client, MessageWriter msg, bool clear) { }

	// RVA: 0x7C8F10 Offset: 0x7C8110 VA: 0x1807C8F10
	public void .ctor() { }
}

// Namespace: InnerNet
[Extension]
public static class MessageExtensions // TypeDefIndex: 2309
{
	// Methods

	[Extension]
	// RVA: 0x7C9810 Offset: 0x7C8A10 VA: 0x1807C9810
	public static void WriteNetObject(MessageWriter self, InnerNetObject obj) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T ReadNetObject<T>(MessageReader self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA51200 Offset: 0xA50400 VA: 0x180A51200
	|-MessageExtensions.ReadNetObject<object>
	*/
}

// Namespace: InnerNet
public enum QuickChatModes // TypeDefIndex: 2310
{
	// Fields
	public int value__; // 0x0
	public const QuickChatModes FreeChatOrQuickChat = 1;
	public const QuickChatModes QuickChatOnly = 2;
}

// Namespace: InnerNet
public enum ReportReasons // TypeDefIndex: 2311
{
	// Fields
	public int value__; // 0x0
	public const ReportReasons None = -1;
	public const ReportReasons InappropriateName = 0;
	public const ReportReasons InappropriateChat = 1;
	public const ReportReasons Cheating_Hacking = 2;
	public const ReportReasons Harassment_Misconduct = 3;
}

// Namespace: InnerNet
public enum ReportOutcome // TypeDefIndex: 2312
{
	// Fields
	public int value__; // 0x0
	public const ReportOutcome NotReportedUnknown = 0;
	public const ReportOutcome NotReportedNoAccount = 1;
	public const ReportOutcome NotReportedNotFound = 2;
	public const ReportOutcome NotReportedRateLimit = 3;
	public const ReportOutcome Reported = 4;
}

// Namespace: InnerNet
public static class Tags // TypeDefIndex: 2313
{
	// Fields
	public const byte HostGame = 0;
	public const byte JoinGame = 1;
	public const byte StartGame = 2;
	public const byte RemoveGame = 3;
	public const byte RemovePlayer = 4;
	public const byte GameData = 5;
	public const byte GameDataTo = 6;
	public const byte JoinedGame = 7;
	public const byte EndGame = 8;
	public const byte AlterGame = 10;
	public const byte KickPlayer = 11;
	public const byte WaitForHost = 12;
	public const byte Redirect = 13;
	public const byte ReselectServer = 14;
	public const byte GetGameListV2 = 16;
	public const byte ReportPlayer = 17;
	public const byte QuickMatch = 18;
	public const byte QuickMatchHost = 19;
	public const byte SetGameSession = 20;
	public const byte SetActivePodType = 21;
	public const byte QueryPlatformIds = 22;
	public const byte QueryLobbyInfo = 23;
	public const byte EndGameHostMigration = 24;
	public const byte ServerDebugAlert = 255;
}

// Namespace: InnerNet
public static class AlterGameTags // TypeDefIndex: 2314
{
	// Fields
	public const byte ChangePrivacy = 1;
}

// Namespace: InnerNet.GizmoHelpers
public interface INetTransformLogger // TypeDefIndex: 2315
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetQueueLength(int i);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Render(Vector3 pos2, float mod);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetSlowbandingLog(bool isSlowbanding);
}

// Namespace: InnerNet.GizmoHelpers
public class NullNetLogger : INetTransformLogger // TypeDefIndex: 2316
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void SetQueueLength(int i) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Render(Vector3 pos2, float mod) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void SetSlowbandingLog(bool isSlowbanding) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: InnerNet.GizmoHelpers
public class NetTransformLogger : INetTransformLogger // TypeDefIndex: 2317
{
	// Fields
	private List<int> queue; // 0x10
	private List<bool> slowbandLog; // 0x18
	private Vector3 pos; // 0x20

	// Methods

	// RVA: 0x7C9DC0 Offset: 0x7C8FC0 VA: 0x1807C9DC0
	public void .ctor() { }

	// RVA: 0x7C9C00 Offset: 0x7C8E00 VA: 0x1807C9C00 Slot: 4
	public void SetQueueLength(int i) { }

	// RVA: 0x7C9CE0 Offset: 0x7C8EE0 VA: 0x1807C9CE0 Slot: 6
	public void SetSlowbandingLog(bool isSlowbanding) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Render(Vector3 pos2, float rubberBandMod) { }
}

// Namespace: InnerNet.GizmoHelpers
public interface ITransformGhost // TypeDefIndex: 2318
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddPt(Vector2 pt);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Render(Color c, bool crosses);
}

// Namespace: InnerNet.GizmoHelpers
public class NullTransformGhost : ITransformGhost // TypeDefIndex: 2319
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void AddPt(Vector2 pt) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Render(Color c, bool crosses) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: InnerNet.GizmoHelpers
public class TransformGhost : ITransformGhost // TypeDefIndex: 2320
{
	// Fields
	private const int MaxCount = 30;
	private const float HalfSize = 0,05;
	private List<Vector2> positions; // 0x10

	// Methods

	// RVA: 0x7CC310 Offset: 0x7CB510 VA: 0x1807CC310 Slot: 4
	public void AddPt(Vector2 pt) { }

	// RVA: 0x7CC400 Offset: 0x7CB600 VA: 0x1807CC400 Slot: 5
	public void Render(Color c, bool crosses) { }

	// RVA: 0x7CC830 Offset: 0x7CBA30 VA: 0x1807CC830
	public void .ctor() { }
}

// Namespace: GooglePlayGames
public class PluginVersion // TypeDefIndex: 2321
{
	// Fields
	public const int VersionInt = 4116;
	public const string VersionString = "0.10.14";
	public const string VersionKey = "01014";

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Logger.<>c // TypeDefIndex: 2322
{
	// Fields
	public static readonly Logger.<>c <>9; // 0x0
	public static Action <>9__12_0; // 0x8

	// Methods

	// RVA: 0x7D0390 Offset: 0x7CF590 VA: 0x1807D0390
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFAC0 Offset: 0x7CECC0 VA: 0x1807CFAC0
	internal void <ToLogMessage>b__12_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Logger.<>c__DisplayClass10_0 // TypeDefIndex: 2323
{
	// Fields
	public string msg; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFC70 Offset: 0x7CEE70 VA: 0x1807CFC70
	internal void <e>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Logger.<>c__DisplayClass8_0 // TypeDefIndex: 2324
{
	// Fields
	public string msg; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFDC0 Offset: 0x7CEFC0 VA: 0x1807CFDC0
	internal void <d>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Logger.<>c__DisplayClass9_0 // TypeDefIndex: 2325
{
	// Fields
	public string msg; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7D0220 Offset: 0x7CF420 VA: 0x1807D0220
	internal void <w>b__0() { }
}

// Namespace: GooglePlayGames.OurUtils
public class Logger // TypeDefIndex: 2326
{
	// Fields
	private static bool debugLogEnabled; // 0x0
	private static bool warningLogEnabled; // 0x1

	// Properties
	public static bool DebugLogEnabled { get; set; }
	public static bool WarningLogEnabled { get; set; }

	// Methods

	// RVA: 0x7C95B0 Offset: 0x7C87B0 VA: 0x1807C95B0
	public static bool get_DebugLogEnabled() { }

	// RVA: 0x7C9650 Offset: 0x7C8850 VA: 0x1807C9650
	public static void set_DebugLogEnabled(bool value) { }

	// RVA: 0x7C9600 Offset: 0x7C8800 VA: 0x1807C9600
	public static bool get_WarningLogEnabled() { }

	// RVA: 0x7C96B0 Offset: 0x7C88B0 VA: 0x1807C96B0
	public static void set_WarningLogEnabled(bool value) { }

	// RVA: 0x7C9320 Offset: 0x7C8520 VA: 0x1807C9320
	public static void d(string msg) { }

	// RVA: 0x7C9710 Offset: 0x7C8910 VA: 0x1807C9710
	public static void w(string msg) { }

	// RVA: 0x7C94B0 Offset: 0x7C86B0 VA: 0x1807C94B0
	public static void e(string msg) { }

	// RVA: 0x7C9420 Offset: 0x7C8620 VA: 0x1807C9420
	public static string describe(byte[] b) { }

	// RVA: 0x7C8FE0 Offset: 0x7C81E0 VA: 0x1807C8FE0
	private static string ToLogMessage(string prefix, string logType, string msg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7C92D0 Offset: 0x7C84D0 VA: 0x1807C92D0
	private static void .cctor() { }
}

// Namespace: GooglePlayGames.OurUtils
public static class Misc // TypeDefIndex: 2327
{
	// Methods

	// RVA: 0x7C98B0 Offset: 0x7C8AB0 VA: 0x1807C98B0
	public static bool BuffersAreIdentical(byte[] a, byte[] b) { }

	// RVA: 0x7C9920 Offset: 0x7C8B20 VA: 0x1807C9920
	public static byte[] GetSubsetBytes(byte[] array, int offset, int length) { }

	// RVA: -1 Offset: -1
	public static T CheckNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA53420 Offset: 0xA52620 VA: 0x180A53420
	|-Misc.CheckNotNull<object>
	|
	|-RVA: 0xA53310 Offset: 0xA52510 VA: 0x180A53310
	|-Misc.CheckNotNull<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T CheckNotNull<T>(T value, string paramName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA53200 Offset: 0xA52400 VA: 0x180A53200
	|-Misc.CheckNotNull<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7C9AC0 Offset: 0x7C8CC0 VA: 0x1807C9AC0
	public static bool IsApiException(AndroidJavaObject exception) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayGamesHelperObject.<>c__DisplayClass10_0 // TypeDefIndex: 2328
{
	// Fields
	public IEnumerator action; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFC00 Offset: 0x7CEE00 VA: 0x1807CFC00
	internal void <RunCoroutine>b__0() { }
}

// Namespace: GooglePlayGames.OurUtils
public class PlayGamesHelperObject : MonoBehaviour // TypeDefIndex: 2329
{
	// Fields
	private static PlayGamesHelperObject instance; // 0x0
	private static bool sIsDummy; // 0x8
	private static List<Action> sQueue; // 0x10
	private List<Action> localQueue; // 0x20
	private static bool sQueueEmpty; // 0x18
	private static List<Action<bool>> sPauseCallbackList; // 0x20
	private static List<Action<bool>> sFocusCallbackList; // 0x28

	// Methods

	// RVA: 0x7CA1D0 Offset: 0x7C93D0 VA: 0x1807CA1D0
	public static void CreateObject() { }

	// RVA: 0x7CA170 Offset: 0x7C9370 VA: 0x1807CA170
	public void Awake() { }

	// RVA: 0x7CA860 Offset: 0x7C9A60 VA: 0x1807CA860
	public void OnDisable() { }

	// RVA: 0x7CAA20 Offset: 0x7C9C20 VA: 0x1807CAA20
	public static void RunCoroutine(IEnumerator action) { }

	// RVA: 0x7CAB50 Offset: 0x7C9D50 VA: 0x1807CAB50
	public static void RunOnGameThread(Action action) { }

	// RVA: 0x7CAD00 Offset: 0x7C9F00 VA: 0x1807CAD00
	public void Update() { }

	// RVA: 0x7CA3E0 Offset: 0x7C95E0 VA: 0x1807CA3E0
	public void OnApplicationFocus(bool focused) { }

	// RVA: 0x7CA620 Offset: 0x7C9820 VA: 0x1807CA620
	public void OnApplicationPause(bool paused) { }

	// RVA: 0x7C9F30 Offset: 0x7C9130 VA: 0x1807C9F30
	public static void AddFocusCallback(Action<bool> callback) { }

	// RVA: 0x7CA920 Offset: 0x7C9B20 VA: 0x1807CA920
	public static bool RemoveFocusCallback(Action<bool> callback) { }

	// RVA: 0x7CA050 Offset: 0x7C9250 VA: 0x1807CA050
	public static void AddPauseCallback(Action<bool> callback) { }

	// RVA: 0x7CA9A0 Offset: 0x7C9BA0 VA: 0x1807CA9A0
	public static bool RemovePauseCallback(Action<bool> callback) { }

	// RVA: 0x7CB0B0 Offset: 0x7CA2B0 VA: 0x1807CB0B0
	public void .ctor() { }

	// RVA: 0x7CAF80 Offset: 0x7CA180 VA: 0x1807CAF80
	private static void .cctor() { }
}

// Namespace: GooglePlayGames.BasicApi
public enum DataSource // TypeDefIndex: 2330
{
	// Fields
	public int value__; // 0x0
	public const DataSource ReadCacheOrNetwork = 0;
	public const DataSource ReadNetworkOnly = 1;
}

// Namespace: GooglePlayGames.BasicApi
public enum ResponseStatus // TypeDefIndex: 2331
{
	// Fields
	public int value__; // 0x0
	public const ResponseStatus Success = 1;
	public const ResponseStatus SuccessWithStale = 2;
	public const ResponseStatus LicenseCheckFailed = -1;
	public const ResponseStatus InternalError = -2;
	public const ResponseStatus NotAuthorized = -3;
	public const ResponseStatus VersionUpdateRequired = -4;
	public const ResponseStatus Timeout = -5;
	public const ResponseStatus ResolutionRequired = -6;
}

// Namespace: GooglePlayGames.BasicApi
public enum UIStatus // TypeDefIndex: 2332
{
	// Fields
	public int value__; // 0x0
	public const UIStatus Valid = 1;
	public const UIStatus InternalError = -2;
	public const UIStatus NotAuthorized = -3;
	public const UIStatus VersionUpdateRequired = -4;
	public const UIStatus Timeout = -5;
	public const UIStatus UserClosedUI = -6;
	public const UIStatus UiBusy = -12;
	public const UIStatus NetworkError = -20;
}

// Namespace: GooglePlayGames.BasicApi
public enum LeaderboardStart // TypeDefIndex: 2333
{
	// Fields
	public int value__; // 0x0
	public const LeaderboardStart TopScores = 1;
	public const LeaderboardStart PlayerCentered = 2;
}

// Namespace: GooglePlayGames.BasicApi
public enum LeaderboardTimeSpan // TypeDefIndex: 2334
{
	// Fields
	public int value__; // 0x0
	public const LeaderboardTimeSpan Daily = 1;
	public const LeaderboardTimeSpan Weekly = 2;
	public const LeaderboardTimeSpan AllTime = 3;
}

// Namespace: GooglePlayGames.BasicApi
public enum LeaderboardCollection // TypeDefIndex: 2335
{
	// Fields
	public int value__; // 0x0
	public const LeaderboardCollection Public = 1;
	public const LeaderboardCollection Social = 2;
}

// Namespace: GooglePlayGames.BasicApi
public enum FriendsListVisibilityStatus // TypeDefIndex: 2336
{
	// Fields
	public int value__; // 0x0
	public const FriendsListVisibilityStatus Unknown = 0;
	public const FriendsListVisibilityStatus Visible = 1;
	public const FriendsListVisibilityStatus ResolutionRequired = 2;
	public const FriendsListVisibilityStatus Unavailable = 3;
	public const FriendsListVisibilityStatus NetworkError = -4;
	public const FriendsListVisibilityStatus NotAuthorized = -5;
}

// Namespace: GooglePlayGames.BasicApi
public enum LoadFriendsStatus // TypeDefIndex: 2337
{
	// Fields
	public int value__; // 0x0
	public const LoadFriendsStatus Unknown = 0;
	public const LoadFriendsStatus Completed = 1;
	public const LoadFriendsStatus LoadMore = 2;
	public const LoadFriendsStatus ResolutionRequired = -3;
	public const LoadFriendsStatus InternalError = -4;
	public const LoadFriendsStatus NotAuthorized = -5;
	public const LoadFriendsStatus NetworkError = -6;
}

// Namespace: GooglePlayGames.BasicApi
public enum VideoCaptureMode // TypeDefIndex: 2338
{
	// Fields
	public int value__; // 0x0
	public const VideoCaptureMode Unknown = -1;
	public const VideoCaptureMode File = 0;
	public const VideoCaptureMode Stream = 1;
}

// Namespace: GooglePlayGames.BasicApi
public enum VideoQualityLevel // TypeDefIndex: 2339
{
	// Fields
	public int value__; // 0x0
	public const VideoQualityLevel Unknown = -1;
	public const VideoQualityLevel SD = 0;
	public const VideoQualityLevel HD = 1;
	public const VideoQualityLevel XHD = 2;
	public const VideoQualityLevel FullHD = 3;
}

// Namespace: GooglePlayGames.BasicApi
public enum VideoCaptureOverlayState // TypeDefIndex: 2340
{
	// Fields
	public int value__; // 0x0
	public const VideoCaptureOverlayState Unknown = -1;
	public const VideoCaptureOverlayState Shown = 1;
	public const VideoCaptureOverlayState Started = 2;
	public const VideoCaptureOverlayState Stopped = 3;
	public const VideoCaptureOverlayState Dismissed = 4;
}

// Namespace: GooglePlayGames.BasicApi
public enum Gravity // TypeDefIndex: 2341
{
	// Fields
	public int value__; // 0x0
	public const Gravity TOP = 48;
	public const Gravity BOTTOM = 80;
	public const Gravity LEFT = 3;
	public const Gravity RIGHT = 5;
	public const Gravity CENTER_HORIZONTAL = 1;
}

// Namespace: GooglePlayGames.BasicApi
public class CommonTypesUtil // TypeDefIndex: 2342
{
	// Methods

	// RVA: 0x7B9D20 Offset: 0x7B8F20 VA: 0x1807B9D20
	public static bool StatusIsSuccess(ResponseStatus status) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: GooglePlayGames.BasicApi
public class SignInHelper // TypeDefIndex: 2343
{
	// Fields
	private static int True; // 0x0
	private static int False; // 0x4
	private const string PromptSignInKey = "prompt_sign_in";

	// Methods

	// RVA: 0x7CC0E0 Offset: 0x7CB2E0 VA: 0x1807CC0E0
	public static SignInStatus ToSignInStatus(int code) { }

	// RVA: 0x7CBFB0 Offset: 0x7CB1B0 VA: 0x1807CBFB0
	public static void SetPromptUiSignIn(bool value) { }

	// RVA: 0x7CC060 Offset: 0x7CB260 VA: 0x1807CC060
	public static bool ShouldPromptUiSignIn() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CC2C0 Offset: 0x7CB4C0 VA: 0x1807CC2C0
	private static void .cctor() { }
}

// Namespace: GooglePlayGames.BasicApi
public enum SignInInteractivity // TypeDefIndex: 2344
{
	// Fields
	public int value__; // 0x0
	public const SignInInteractivity NoPrompt = 0;
	public const SignInInteractivity CanPromptAlways = 1;
	public const SignInInteractivity CanPromptOnce = 2;
}

// Namespace: GooglePlayGames.BasicApi
public enum SignInStatus // TypeDefIndex: 2345
{
	// Fields
	public int value__; // 0x0
	public const SignInStatus Success = 0;
	public const SignInStatus UiSignInRequired = 1;
	public const SignInStatus DeveloperError = 2;
	public const SignInStatus NetworkError = 3;
	public const SignInStatus InternalError = 4;
	public const SignInStatus Canceled = 5;
	public const SignInStatus AlreadyInProgress = 6;
	public const SignInStatus Failed = 7;
	public const SignInStatus NotAuthenticated = 8;
}

// Namespace: GooglePlayGames.BasicApi.Video
public interface CaptureOverlayStateListener // TypeDefIndex: 2346
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCaptureOverlayStateChanged(VideoCaptureOverlayState overlayState);
}

// Namespace: GooglePlayGames.BasicApi.Video
public interface IVideoClient // TypeDefIndex: 2347
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ShowCaptureOverlay();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsCaptureSupported();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterCaptureOverlayStateChangedListener();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VideoCapabilities.<>c // TypeDefIndex: 2348
{
	// Fields
	public static readonly VideoCapabilities.<>c <>9; // 0x0
	public static Func<bool, string> <>9__14_0; // 0x8
	public static Func<bool, string> <>9__14_1; // 0x10

	// Methods

	// RVA: 0x7D03F0 Offset: 0x7CF5F0 VA: 0x1807D03F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7CFB20 Offset: 0x7CED20 VA: 0x1807CFB20
	internal string <ToString>b__14_0(bool p) { }

	// RVA: 0x7CFB70 Offset: 0x7CED70 VA: 0x1807CFB70
	internal string <ToString>b__14_1(bool p) { }
}

// Namespace: GooglePlayGames.BasicApi.Video
public class VideoCapabilities // TypeDefIndex: 2349
{
	// Fields
	private bool mIsCameraSupported; // 0x10
	private bool mIsMicSupported; // 0x11
	private bool mIsWriteStorageSupported; // 0x12
	private bool[] mCaptureModesSupported; // 0x18
	private bool[] mQualityLevelsSupported; // 0x20

	// Properties
	public bool IsCameraSupported { get; }
	public bool IsMicSupported { get; }
	public bool IsWriteStorageSupported { get; }

	// Methods

	// RVA: 0x7D0CB0 Offset: 0x7CFEB0 VA: 0x1807D0CB0
	internal void .ctor(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsCameraSupported() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_IsMicSupported() { }

	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	public bool get_IsWriteStorageSupported() { }

	// RVA: 0x7D0770 Offset: 0x7CF970 VA: 0x1807D0770
	public bool SupportsCaptureMode(VideoCaptureMode captureMode) { }

	// RVA: 0x7D0810 Offset: 0x7CFA10 VA: 0x1807D0810
	public bool SupportsQualityLevel(VideoQualityLevel qualityLevel) { }

	// RVA: 0x7D08B0 Offset: 0x7CFAB0 VA: 0x1807D08B0 Slot: 3
	public override string ToString() { }
}

// Namespace: GooglePlayGames.BasicApi.Video
public class VideoCaptureState // TypeDefIndex: 2350
{
	// Fields
	private bool mIsCapturing; // 0x10
	private VideoCaptureMode mCaptureMode; // 0x14
	private VideoQualityLevel mQualityLevel; // 0x18
	private bool mIsOverlayVisible; // 0x1C
	private bool mIsPaused; // 0x1D

	// Properties
	public bool IsCapturing { get; }
	public VideoCaptureMode CaptureMode { get; }
	public VideoQualityLevel QualityLevel { get; }
	public bool IsOverlayVisible { get; }
	public bool IsPaused { get; }

	// Methods

	// RVA: 0x7D0F90 Offset: 0x7D0190 VA: 0x1807D0F90
	internal void .ctor(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsCapturing() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public VideoCaptureMode get_CaptureMode() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public VideoQualityLevel get_QualityLevel() { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_IsOverlayVisible() { }

	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0
	public bool get_IsPaused() { }

	// RVA: 0x7D0D20 Offset: 0x7CFF20 VA: 0x1807D0D20 Slot: 3
	public override string ToString() { }
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public enum ConflictResolutionStrategy // TypeDefIndex: 2351
{
	// Fields
	public int value__; // 0x0
	public const ConflictResolutionStrategy UseLongestPlaytime = 0;
	public const ConflictResolutionStrategy UseOriginal = 1;
	public const ConflictResolutionStrategy UseUnmerged = 2;
	public const ConflictResolutionStrategy UseManual = 3;
	public const ConflictResolutionStrategy UseLastKnownGood = 4;
	public const ConflictResolutionStrategy UseMostRecentlySaved = 5;
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public enum SavedGameRequestStatus // TypeDefIndex: 2352
{
	// Fields
	public int value__; // 0x0
	public const SavedGameRequestStatus Success = 1;
	public const SavedGameRequestStatus TimeoutError = -1;
	public const SavedGameRequestStatus InternalError = -2;
	public const SavedGameRequestStatus AuthenticationError = -3;
	public const SavedGameRequestStatus BadInputError = -4;
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public enum SelectUIStatus // TypeDefIndex: 2353
{
	// Fields
	public int value__; // 0x0
	public const SelectUIStatus SavedGameSelected = 1;
	public const SelectUIStatus UserClosedUI = 2;
	public const SelectUIStatus InternalError = -1;
	public const SelectUIStatus TimeoutError = -2;
	public const SelectUIStatus AuthenticationError = -3;
	public const SelectUIStatus BadInputError = -4;
	public const SelectUIStatus UiBusy = -5;
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public sealed class ConflictCallback : MulticastDelegate // TypeDefIndex: 2354
{
	// Methods

	// RVA: 0x7B9D90 Offset: 0x7B8F90 VA: 0x1807B9D90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData) { }

	// RVA: 0x7B9D30 Offset: 0x7B8F30 VA: 0x1807B9D30 Slot: 14
	public virtual IAsyncResult BeginInvoke(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface ISavedGameClient // TypeDefIndex: 2355
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Delete(ISavedGameMetadata metadata);
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface IConflictResolver // TypeDefIndex: 2356
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ChooseMetadata(ISavedGameMetadata chosenMetadata);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface ISavedGameMetadata // TypeDefIndex: 2357
{
	// Properties
	public abstract bool IsOpen { get; }
	public abstract string Filename { get; }
	public abstract string Description { get; }
	public abstract string CoverImageURL { get; }
	public abstract TimeSpan TotalTimePlayed { get; }
	public abstract DateTime LastModifiedTimestamp { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsOpen();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Filename();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_CoverImageURL();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeSpan get_TotalTimePlayed();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DateTime get_LastModifiedTimestamp();
}

// Namespace: 
public struct SavedGameMetadataUpdate.Builder // TypeDefIndex: 2358
{
	// Fields
	internal bool mDescriptionUpdated; // 0x0
	internal string mNewDescription; // 0x8
	internal bool mCoverImageUpdated; // 0x10
	internal byte[] mNewPngCoverImage; // 0x18
	internal Nullable<TimeSpan> mNewPlayedTime; // 0x20

	// Methods

	// RVA: 0x7B9B70 Offset: 0x7B8D70 VA: 0x1807B9B70
	public SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description) { }

	// RVA: 0x7B9CF0 Offset: 0x7B8EF0 VA: 0x1807B9CF0
	public SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage) { }

	// RVA: 0x7B9BF0 Offset: 0x7B8DF0 VA: 0x1807B9BF0
	public SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime) { }

	// RVA: 0x7B9B30 Offset: 0x7B8D30 VA: 0x1807B9B30
	public SavedGameMetadataUpdate Build() { }
}

// Namespace: GooglePlayGames.BasicApi.SavedGame
public struct SavedGameMetadataUpdate // TypeDefIndex: 2359
{
	// Fields
	private readonly bool mDescriptionUpdated; // 0x0
	private readonly string mNewDescription; // 0x8
	private readonly bool mCoverImageUpdated; // 0x10
	private readonly byte[] mNewPngCoverImage; // 0x18
	private readonly Nullable<TimeSpan> mNewPlayedTime; // 0x20

	// Properties
	public bool IsDescriptionUpdated { get; }
	public string UpdatedDescription { get; }
	public bool IsCoverImageUpdated { get; }
	public byte[] UpdatedPngCoverImage { get; }
	public bool IsPlayedTimeUpdated { get; }
	public Nullable<TimeSpan> UpdatedPlayedTime { get; }

	// Methods

	// RVA: 0x7CBF40 Offset: 0x7CB140 VA: 0x1807CBF40
	private void .ctor(SavedGameMetadataUpdate.Builder builder) { }

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_IsDescriptionUpdated() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_UpdatedDescription() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsCoverImageUpdated() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public byte[] get_UpdatedPngCoverImage() { }

	// RVA: 0x7CBF70 Offset: 0x7CB170 VA: 0x1807CBF70
	public bool get_IsPlayedTimeUpdated() { }

	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Nullable<TimeSpan> get_UpdatedPlayedTime() { }
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public struct AdvertisingResult // TypeDefIndex: 2360
{
	// Fields
	private readonly ResponseStatus mStatus; // 0x0
	private readonly string mLocalEndpointName; // 0x8

	// Properties
	public bool Succeeded { get; }
	public ResponseStatus Status { get; }
	public string LocalEndpointName { get; }

	// Methods

	// RVA: 0x7B9AC0 Offset: 0x7B8CC0 VA: 0x1807B9AC0
	public void .ctor(ResponseStatus status, string localEndpointName) { }

	// RVA: 0x7B9B20 Offset: 0x7B8D20 VA: 0x1807B9B20
	public bool get_Succeeded() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public ResponseStatus get_Status() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_LocalEndpointName() { }
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public struct ConnectionRequest // TypeDefIndex: 2361
{
	// Fields
	private readonly EndpointDetails mRemoteEndpoint; // 0x0
	private readonly byte[] mPayload; // 0x18

	// Properties
	public EndpointDetails RemoteEndpoint { get; }
	public byte[] Payload { get; }

	// Methods

	// RVA: 0x7B9EB0 Offset: 0x7B90B0 VA: 0x1807B9EB0
	public void .ctor(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload) { }

	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public EndpointDetails get_RemoteEndpoint() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public byte[] get_Payload() { }
}

// Namespace: 
public enum ConnectionResponse.Status // TypeDefIndex: 2362
{
	// Fields
	public int value__; // 0x0
	public const ConnectionResponse.Status Accepted = 0;
	public const ConnectionResponse.Status Rejected = 1;
	public const ConnectionResponse.Status ErrorInternal = 2;
	public const ConnectionResponse.Status ErrorNetworkNotConnected = 3;
	public const ConnectionResponse.Status ErrorEndpointNotConnected = 4;
	public const ConnectionResponse.Status ErrorAlreadyConnected = 5;
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public struct ConnectionResponse // TypeDefIndex: 2363
{
	// Fields
	private static readonly byte[] EmptyPayload; // 0x0
	private readonly long mLocalClientId; // 0x0
	private readonly string mRemoteEndpointId; // 0x8
	private readonly ConnectionResponse.Status mResponseStatus; // 0x10
	private readonly byte[] mPayload; // 0x18

	// Properties
	public long LocalClientId { get; }
	public string RemoteEndpointId { get; }
	public ConnectionResponse.Status ResponseStatus { get; }
	public byte[] Payload { get; }

	// Methods

	// RVA: 0x7BA460 Offset: 0x7B9660 VA: 0x1807BA460
	private void .ctor(long localClientId, string remoteEndpointId, ConnectionResponse.Status code, byte[] payload) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long get_LocalClientId() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_RemoteEndpointId() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ConnectionResponse.Status get_ResponseStatus() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public byte[] get_Payload() { }

	// RVA: 0x7BA370 Offset: 0x7B9570 VA: 0x1807BA370
	public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x7BA2D0 Offset: 0x7B94D0 VA: 0x1807BA2D0
	public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x7BA230 Offset: 0x7B9430 VA: 0x1807BA230
	public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId) { }

	// RVA: 0x7BA190 Offset: 0x7B9390 VA: 0x1807BA190
	public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x7BA0B0 Offset: 0x7B92B0 VA: 0x1807BA0B0
	public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload) { }

	// RVA: 0x7BA0F0 Offset: 0x7B92F0 VA: 0x1807BA0F0
	public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x7BA410 Offset: 0x7B9610 VA: 0x1807BA410
	private static void .cctor() { }
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public struct EndpointDetails // TypeDefIndex: 2364
{
	// Fields
	private readonly string mEndpointId; // 0x0
	private readonly string mName; // 0x8
	private readonly string mServiceId; // 0x10

	// Properties
	public string EndpointId { get; }
	public string Name { get; }
	public string ServiceId { get; }

	// Methods

	// RVA: 0x7BA4F0 Offset: 0x7B96F0 VA: 0x1807BA4F0
	public void .ctor(string endpointId, string name, string serviceId) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_EndpointId() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_Name() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ServiceId() { }
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public interface IMessageListener // TypeDefIndex: 2365
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRemoteEndpointDisconnected(string remoteEndpointId);
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public interface IDiscoveryListener // TypeDefIndex: 2366
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndpointFound(EndpointDetails discoveredEndpoint);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndpointLost(string lostEndpointId);
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public enum InitializationStatus // TypeDefIndex: 2367
{
	// Fields
	public int value__; // 0x0
	public const InitializationStatus Success = 0;
	public const InitializationStatus VersionUpdateRequired = 1;
	public const InitializationStatus InternalError = 2;
}

// Namespace: GooglePlayGames.BasicApi.Nearby
public struct NearbyConnectionConfiguration // TypeDefIndex: 2368
{
	// Fields
	public const int MaxUnreliableMessagePayloadLength = 1168;
	public const int MaxReliableMessagePayloadLength = 4096;
	private readonly Action<InitializationStatus> mInitializationCallback; // 0x0
	private readonly long mLocalClientId; // 0x8

	// Properties
	public long LocalClientId { get; }
	public Action<InitializationStatus> InitializationCallback { get; }

	// Methods

	// RVA: 0x7C9BA0 Offset: 0x7C8DA0 VA: 0x1807C9BA0
	public void .ctor(Action<InitializationStatus> callback, long localClientId) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public long get_LocalClientId() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Action<InitializationStatus> get_InitializationCallback() { }
}

// Namespace: GooglePlayGames.BasicApi.Events
internal class Event : IEvent // TypeDefIndex: 2369
{
	// Fields
	private string mId; // 0x10
	private string mName; // 0x18
	private string mDescription; // 0x20
	private string mImageUrl; // 0x28
	private ulong mCurrentCount; // 0x30
	private EventVisibility mVisibility; // 0x38

	// Properties
	public string Id { get; }
	public string Name { get; }
	public string Description { get; }
	public string ImageUrl { get; }
	public ulong CurrentCount { get; }
	public EventVisibility Visibility { get; }

	// Methods

	// RVA: 0x7BA5F0 Offset: 0x7B97F0 VA: 0x1807BA5F0
	internal void .ctor(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_Id() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public string get_Name() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	public string get_Description() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 7
	public string get_ImageUrl() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 8
	public ulong get_CurrentCount() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 9
	public EventVisibility get_Visibility() { }
}

// Namespace: GooglePlayGames.BasicApi.Events
public enum EventVisibility // TypeDefIndex: 2370
{
	// Fields
	public int value__; // 0x0
	public const EventVisibility Hidden = 1;
	public const EventVisibility Revealed = 2;
}

// Namespace: GooglePlayGames.BasicApi.Events
public interface IEvent // TypeDefIndex: 2371
{
	// Properties
	public abstract string Id { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string ImageUrl { get; }
	public abstract ulong CurrentCount { get; }
	public abstract EventVisibility Visibility { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_ImageUrl();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ulong get_CurrentCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EventVisibility get_Visibility();
}

// Namespace: Microsoft.Xbox
internal class HR // TypeDefIndex: 2372
{
	// Methods

	// RVA: 0x7BA810 Offset: 0x7B9A10 VA: 0x1807BA810
	internal static bool SUCCEEDED(int hr) { }

	// RVA: 0x7BA800 Offset: 0x7B9A00 VA: 0x1807BA800
	internal static bool FAILED(int hr) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Microsoft.Xbox
public class ErrorEventArgs : EventArgs // TypeDefIndex: 2373
{
	// Fields
	[CompilerGenerated]
	private string <ErrorCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; // 0x18

	// Properties
	public string ErrorCode { get; set; }
	public string ErrorMessage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_ErrorCode(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_ErrorMessage(string value) { }

	// RVA: 0x7BA580 Offset: 0x7B9780 VA: 0x1807BA580
	public void .ctor(string errorCode, string errorMessage) { }
}

// Namespace: Microsoft.Xbox
public class GameSaveLoadedArgs : EventArgs // TypeDefIndex: 2374
{
	// Fields
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x10

	// Properties
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Data(byte[] value) { }

	// RVA: 0x7BA7A0 Offset: 0x7B99A0 VA: 0x1807BA7A0
	public void .ctor(byte[] data) { }
}

// Namespace: 
public sealed class XboxSdk.OnGameSaveLoadedHandler : MulticastDelegate // TypeDefIndex: 2375
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, GameSaveLoadedArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, GameSaveLoadedArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class XboxSdk.OnErrorHandler : MulticastDelegate // TypeDefIndex: 2376
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ErrorEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ErrorEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Microsoft.Xbox
public class XboxSdk : MonoBehaviour // TypeDefIndex: 2377
{
	// Fields
	public Text dlcOutputTextBox; // 0x20
	[Header("You can find the value of the scid in your MicrosoftGame.config")]
	public string scid; // 0x28
	public Text gamertagLabel; // 0x30
	public bool signInOnStart; // 0x38
	private static XboxSdk _xboxHelpers; // 0x0
	private static bool _initialized; // 0x8
	private const string _GAME_SAVE_CONTAINER_NAME = "x_game_save_default_container";
	private const string _GAME_SAVE_BLOB_NAME = "x_game_save_default_blob";
	[CompilerGenerated]
	private XboxSdk.OnGameSaveLoadedHandler OnGameSaveLoaded; // 0x40
	[CompilerGenerated]
	private XboxSdk.OnErrorHandler OnError; // 0x48

	// Properties
	public static XboxSdk Helpers { get; }

	// Methods

	// RVA: 0x7D13F0 Offset: 0x7D05F0 VA: 0x1807D13F0
	public static XboxSdk get_Helpers() { }

	[CompilerGenerated]
	// RVA: 0x7D1350 Offset: 0x7D0550 VA: 0x1807D1350
	public void add_OnGameSaveLoaded(XboxSdk.OnGameSaveLoadedHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7D15E0 Offset: 0x7D07E0 VA: 0x1807D15E0
	public void remove_OnGameSaveLoaded(XboxSdk.OnGameSaveLoadedHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7D12B0 Offset: 0x7D04B0 VA: 0x1807D12B0
	public void add_OnError(XboxSdk.OnErrorHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7D1540 Offset: 0x7D0740 VA: 0x1807D1540
	public void remove_OnError(XboxSdk.OnErrorHandler value) { }

	// RVA: 0x7D1000 Offset: 0x7D0200 VA: 0x1807D1000
	private void Start() { }

	// RVA: 0x7D11D0 Offset: 0x7D03D0 VA: 0x1807D11D0
	private void _Initialize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SignIn() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Save(byte[] data) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void LoadSaveData() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void UnlockAchievement(string achievementId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void Update() { }

	// RVA: 0x7D1010 Offset: 0x7D0210 VA: 0x1807D1010
	protected static bool Succeeded(int hresult, string operationFriendlyName) { }

	// RVA: 0x7D1250 Offset: 0x7D0450 VA: 0x1807D1250
	private static void _LogError(string message) { }

	// RVA: 0x7D12A0 Offset: 0x7D04A0 VA: 0x1807D12A0
	public void .ctor() { }
}

// Namespace: Microsoft.Xbox
public class XGameSaveWrapper // TypeDefIndex: 2378
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Amongus.GameModes.HideAndSeek
public class HideAndSeekMusicCollection : ScriptableObject // TypeDefIndex: 2379
{
	// Fields
	[Header("Crewmate Music")]
	public AudioClip NormalMusic; // 0x18
	public AudioClip TaskMusic; // 0x20
	public AudioClip DangerLevel1Music; // 0x28
	public AudioClip DangerLevel2Music; // 0x30
	[Header("Impostor Music")]
	public AudioClip ImpostorShortMusic; // 0x38
	public AudioClip ImpostorLongMusic; // 0x40
	public AudioClip ImpostorRanchMusic; // 0x48

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: PolyAndCode.UI
public interface ICell // TypeDefIndex: 2380
{}

// Namespace: PolyAndCode.UI
public interface IRecyclableScrollRectDataSource // TypeDefIndex: 2381
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetItemCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetCell(ICell cell, int index);
}

// Namespace: 
public enum RecyclableScrollRect.DirectionType // TypeDefIndex: 2382
{
	// Fields
	public int value__; // 0x0
	public const RecyclableScrollRect.DirectionType Vertical = 0;
	public const RecyclableScrollRect.DirectionType Horizontal = 1;
}

// Namespace: PolyAndCode.UI
public class RecyclableScrollRect : ScrollRect // TypeDefIndex: 2383
{
	// Fields
	[HideInInspector]
	public IRecyclableScrollRectDataSource DataSource; // 0x130
	public bool IsGrid; // 0x138
	public RectTransform PrototypeCell; // 0x140
	public bool SelfInitialize; // 0x148
	public RecyclableScrollRect.DirectionType Direction; // 0x14C
	[SerializeField]
	private int _segments; // 0x150
	private RecyclingSystem _recyclingSystem; // 0x158
	private Vector2 _prevAnchoredPos; // 0x160

	// Properties
	public int Segments { get; set; }

	// Methods

	// RVA: 0x7CBEE0 Offset: 0x7CB0E0 VA: 0x1807CBEE0
	public void set_Segments(int value) { }

	// RVA: 0x7CBED0 Offset: 0x7CB0D0 VA: 0x1807CBED0
	public int get_Segments() { }

	// RVA: 0x7CB3C0 Offset: 0x7CA5C0 VA: 0x1807CB3C0
	public IEnumerator<ICell> GetCells() { }

	// RVA: 0x7CBD10 Offset: 0x7CAF10 VA: 0x1807CBD10 Slot: 6
	protected override void Start() { }

	// RVA: 0x7CB400 Offset: 0x7CA600 VA: 0x1807CB400
	private void Initialize() { }

	// RVA: 0x7CB3F0 Offset: 0x7CA5F0 VA: 0x1807CB3F0
	public void Initialize(IRecyclableScrollRectDataSource dataSource) { }

	// RVA: 0x7CB730 Offset: 0x7CA930 VA: 0x1807CB730
	public void OnValueChangedListener(Vector2 normalizedPos) { }

	// RVA: 0x7CB820 Offset: 0x7CAA20 VA: 0x1807CB820
	public void ReloadData() { }

	// RVA: 0x7CB9B0 Offset: 0x7CABB0 VA: 0x1807CB9B0
	public void ReloadData(IRecyclableScrollRectDataSource dataSource) { }

	// RVA: 0x7CBB40 Offset: 0x7CAD40 VA: 0x1807CBB40
	public void ScrollToBottom() { }

	// RVA: 0x7CBEC0 Offset: 0x7CB0C0 VA: 0x1807CBEC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7CBD80 Offset: 0x7CAF80 VA: 0x1807CBD80
	private void <Initialize>b__14_0() { }

	[CompilerGenerated]
	// RVA: 0x7CBE20 Offset: 0x7CB020 VA: 0x1807CBE20
	private void <ReloadData>b__18_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HorizontalRecyclingSystem.<>c // TypeDefIndex: 2384
{
	// Fields
	public static readonly HorizontalRecyclingSystem.<>c <>9; // 0x0
	public static Action<RectTransform> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x7E25D0 Offset: 0x7E17D0 VA: 0x1807E25D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E1FF0 Offset: 0x7E11F0 VA: 0x1807E1FF0
	internal void <CreateCellPool>b__17_0(RectTransform item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HorizontalRecyclingSystem.<>c__DisplayClass19_0 // TypeDefIndex: 2385
{
	// Fields
	public int n; // 0x10
	public HorizontalRecyclingSystem <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E20D0 Offset: 0x7E12D0 VA: 0x1807E20D0
	internal void <RecycleLeftToRight>b__0(RectTransform cell) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HorizontalRecyclingSystem.<>c__DisplayClass20_0 // TypeDefIndex: 2386
{
	// Fields
	public int n; // 0x10
	public HorizontalRecyclingSystem <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E2200 Offset: 0x7E1400 VA: 0x1807E2200
	internal void <RecycleRightToleft>b__0(RectTransform cell) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HorizontalRecyclingSystem.<GetCells>d__21 : IEnumerator<ICell>, IEnumerator, IDisposable // TypeDefIndex: 2387
{
	// Fields
	private int <>1__state; // 0x10
	private ICell <>2__current; // 0x18
	public HorizontalRecyclingSystem <>4__this; // 0x20
	private List.Enumerator<ICell> <>7__wrap1; // 0x28

	// Properties
	private ICell System.Collections.Generic.IEnumerator<PolyAndCode.UI.ICell>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7E17E0 Offset: 0x7E09E0 VA: 0x1807E17E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7E1610 Offset: 0x7E0810 VA: 0x1807E1610 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7E1870 Offset: 0x7E0A70 VA: 0x1807E1870
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private ICell System.Collections.Generic.IEnumerator<PolyAndCode.UI.ICell>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7E17A0 Offset: 0x7E09A0 VA: 0x1807E17A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HorizontalRecyclingSystem.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2388
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public HorizontalRecyclingSystem <>4__this; // 0x20
	public Action onInitialized; // 0x28

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

	// RVA: 0x7E1B70 Offset: 0x7E0D70 VA: 0x1807E1B70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7E1F70 Offset: 0x7E1170 VA: 0x1807E1F70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: PolyAndCode.UI
public class HorizontalRecyclingSystem : RecyclingSystem // TypeDefIndex: 2389
{
	// Fields
	private readonly int _rows; // 0x40
	private float _cellWidth; // 0x44
	private float _cellHeight; // 0x48
	private List<RectTransform> _cellPool; // 0x50
	private List<ICell> _cachedCells; // 0x58
	private Bounds _recyclableViewBounds; // 0x60
	private readonly Vector3[] _corners; // 0x78
	private bool _recycling; // 0x80
	private int currentItemCount; // 0x84
	private int leftMostCellIndex; // 0x88
	private int rightMostCellIndex; // 0x8C
	private int _leftMostCellRow; // 0x90
	private int _RightMostCellRow; // 0x94
	private Vector2 zeroVector; // 0x98

	// Methods

	// RVA: 0x7BC4B0 Offset: 0x7BB6B0 VA: 0x1807BC4B0
	public void .ctor(RectTransform prototypeCell, RectTransform viewport, RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int rows) { }

	[IteratorStateMachine(typeof(HorizontalRecyclingSystem.<InitCoroutine>d__15))]
	// RVA: 0x7BB0C0 Offset: 0x7BA2C0 VA: 0x1807BB0C0 Slot: 4
	public override IEnumerator InitCoroutine(Action onInitialized) { }

	// RVA: 0x7BC310 Offset: 0x7BB510 VA: 0x1807BC310
	private void SetRecyclingBounds() { }

	// RVA: 0x7BA820 Offset: 0x7B9A20 VA: 0x1807BA820
	private void CreateCellPool() { }

	// RVA: 0x7BB320 Offset: 0x7BA520 VA: 0x1807BB320 Slot: 5
	public override Vector2 OnValueChangedListener(Vector2 direction) { }

	// RVA: 0x7BB4A0 Offset: 0x7BA6A0 VA: 0x1807BB4A0
	private Vector2 RecycleLeftToRight() { }

	// RVA: 0x7BBBB0 Offset: 0x7BADB0 VA: 0x1807BBBB0
	private Vector2 RecycleRightToleft() { }

	[IteratorStateMachine(typeof(HorizontalRecyclingSystem.<GetCells>d__21))]
	// RVA: 0x7BB050 Offset: 0x7BA250 VA: 0x1807BB050 Slot: 6
	public override IEnumerator<ICell> GetCells() { }

	// RVA: 0x7BC230 Offset: 0x7BB430 VA: 0x1807BC230
	private void SetLeftAnchor(RectTransform rectTransform) { }

	// RVA: 0x7BB140 Offset: 0x7BA340 VA: 0x1807BB140
	public void OnDrawGizmos() { }
}

// Namespace: PolyAndCode.UI
public abstract class RecyclingSystem // TypeDefIndex: 2390
{
	// Fields
	public IRecyclableScrollRectDataSource DataSource; // 0x10
	protected RectTransform Viewport; // 0x18
	protected RectTransform Content; // 0x20
	protected RectTransform PrototypeCell; // 0x28
	protected bool IsGrid; // 0x30
	protected float MinPoolCoverage; // 0x34
	protected int MinPoolSize; // 0x38
	protected float RecyclingThreshold; // 0x3C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator InitCoroutine(Action onInitialized);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector2 OnValueChangedListener(Vector2 direction);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IEnumerator<ICell> GetCells();

	// RVA: 0x7E0980 Offset: 0x7DFB80 VA: 0x1807E0980
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VerticalRecyclingSystem.<>c // TypeDefIndex: 2391
{
	// Fields
	public static readonly VerticalRecyclingSystem.<>c <>9; // 0x0
	public static Action<RectTransform> <>9__18_0; // 0x8

	// Methods

	// RVA: 0x7E2570 Offset: 0x7E1770 VA: 0x1807E2570
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E2060 Offset: 0x7E1260 VA: 0x1807E2060
	internal void <CreateCellPool>b__18_0(RectTransform item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VerticalRecyclingSystem.<>c__DisplayClass20_0 // TypeDefIndex: 2392
{
	// Fields
	public int n; // 0x10
	public VerticalRecyclingSystem <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E2320 Offset: 0x7E1520 VA: 0x1807E2320
	internal void <RecycleTopToBottom>b__0(RectTransform cell) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VerticalRecyclingSystem.<>c__DisplayClass21_0 // TypeDefIndex: 2393
{
	// Fields
	public int n; // 0x10
	public VerticalRecyclingSystem <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7E2440 Offset: 0x7E1640 VA: 0x1807E2440
	internal void <RecycleBottomToTop>b__0(RectTransform cell) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VerticalRecyclingSystem.<GetCells>d__22 : IEnumerator<ICell>, IEnumerator, IDisposable // TypeDefIndex: 2394
{
	// Fields
	private int <>1__state; // 0x10
	private ICell <>2__current; // 0x18
	public VerticalRecyclingSystem <>4__this; // 0x20
	private List.Enumerator<ICell> <>7__wrap1; // 0x28

	// Properties
	private ICell System.Collections.Generic.IEnumerator<PolyAndCode.UI.ICell>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7E1A90 Offset: 0x7E0C90 VA: 0x1807E1A90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7E18C0 Offset: 0x7E0AC0 VA: 0x1807E18C0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7E1B20 Offset: 0x7E0D20 VA: 0x1807E1B20
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private ICell System.Collections.Generic.IEnumerator<PolyAndCode.UI.ICell>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7E1A50 Offset: 0x7E0C50 VA: 0x1807E1A50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VerticalRecyclingSystem.<InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2395
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VerticalRecyclingSystem <>4__this; // 0x20
	public Action onInitialized; // 0x28

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

	// RVA: 0x7E1D90 Offset: 0x7E0F90 VA: 0x1807E1D90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7E1FB0 Offset: 0x7E11B0 VA: 0x1807E1FB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: PolyAndCode.UI
public class VerticalRecyclingSystem : RecyclingSystem // TypeDefIndex: 2396
{
	// Fields
	private readonly int _coloumns; // 0x40
	private float _cellWidth; // 0x44
	private float _cellHeight; // 0x48
	private List<RectTransform> _cellPool; // 0x50
	private List<ICell> _cachedCells; // 0x58
	private Bounds _recyclableViewBounds; // 0x60
	private readonly Vector3[] _corners; // 0x78
	private bool _recycling; // 0x80
	private int currentItemCount; // 0x84
	private int topMostCellIndex; // 0x88
	private int bottomMostCellIndex; // 0x8C
	private int _topMostCellColoumn; // 0x90
	private int _bottomMostCellColoumn; // 0x94
	private Vector2 zeroVector; // 0x98

	// Methods

	// RVA: 0x7E4500 Offset: 0x7E3700 VA: 0x1807E4500
	public void .ctor(RectTransform prototypeCell, RectTransform viewport, RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int coloumns) { }

	[IteratorStateMachine(typeof(VerticalRecyclingSystem.<InitCoroutine>d__15))]
	// RVA: 0x7E2EB0 Offset: 0x7E20B0 VA: 0x1807E2EB0 Slot: 4
	public override IEnumerator InitCoroutine(Action onInitialized) { }

	// RVA: 0x7E3F80 Offset: 0x7E3180 VA: 0x1807E3F80
	public void ScrollToEnd() { }

	// RVA: 0x7E41B0 Offset: 0x7E33B0 VA: 0x1807E41B0
	private void SetRecyclingBounds() { }

	// RVA: 0x7E2630 Offset: 0x7E1830 VA: 0x1807E2630
	private void CreateCellPool() { }

	// RVA: 0x7E3100 Offset: 0x7E2300 VA: 0x1807E3100 Slot: 5
	public override Vector2 OnValueChangedListener(Vector2 direction) { }

	// RVA: 0x7E38A0 Offset: 0x7E2AA0 VA: 0x1807E38A0
	private Vector2 RecycleTopToBottom() { }

	// RVA: 0x7E3280 Offset: 0x7E2480 VA: 0x1807E3280
	private Vector2 RecycleBottomToTop() { }

	[IteratorStateMachine(typeof(VerticalRecyclingSystem.<GetCells>d__22))]
	// RVA: 0x7E2E50 Offset: 0x7E2050 VA: 0x1807E2E50 Slot: 6
	public override IEnumerator<ICell> GetCells() { }

	// RVA: 0x7E4350 Offset: 0x7E3550 VA: 0x1807E4350
	private void SetTopAnchor(RectTransform rectTransform) { }

	// RVA: 0x7E4430 Offset: 0x7E3630 VA: 0x1807E4430
	private void SetTopLeftAnchor(RectTransform rectTransform) { }

	// RVA: 0x7E2F20 Offset: 0x7E2120 VA: 0x1807E2F20
	public void OnDrawGizmos() { }
}

// Namespace: AmongUs
public class AmongUsDefaultDateTime : IAmongUsDateTimeRetriever // TypeDefIndex: 2397
{
	// Methods

	// RVA: 0x7D1740 Offset: 0x7D0940 VA: 0x1807D1740 Slot: 4
	public DateTime Now() { }

	// RVA: 0x7D1780 Offset: 0x7D0980 VA: 0x1807D1780 Slot: 5
	public DateTime UtcNow() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs
public interface IAmongUsDateTimeRetriever // TypeDefIndex: 2398
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTime Now();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DateTime UtcNow();
}

// Namespace: AmongUs.GameOptions
[JsonConverter(typeof(StringEnumConverter))]
[Flags]
public enum GameKeywords // TypeDefIndex: 2399
{
	// Fields
	public uint value__; // 0x0
	public const GameKeywords All = 0;
	public const GameKeywords English = 256;
	public const GameKeywords SpanishLA = 2;
	public const GameKeywords Brazilian = 2048;
	public const GameKeywords Portuguese = 16;
	public const GameKeywords Korean = 4;
	public const GameKeywords Russian = 8;
	public const GameKeywords Dutch = 4096;
	public const GameKeywords Filipino = 64;
	public const GameKeywords French = 8192;
	public const GameKeywords German = 16384;
	public const GameKeywords Italian = 32768;
	public const GameKeywords Japanese = 512;
	public const GameKeywords SpanishEU = 1024;
	public const GameKeywords Arabic = 32;
	public const GameKeywords Polish = 128;
	public const GameKeywords SChinese = 65536;
	public const GameKeywords TChinese = 131072;
	public const GameKeywords Irish = 262144;
	public const GameKeywords Other = 1;
}

// Namespace: AmongUs.GameOptions
public enum GameModes // TypeDefIndex: 2400
{
	// Fields
	public byte value__; // 0x0
	public const GameModes None = 0;
	public const GameModes Normal = 1;
	public const GameModes HideNSeek = 2;
	public const GameModes NormalFools = 3;
	public const GameModes SeekFools = 4;
}

// Namespace: AmongUs.GameOptions
public class GameOptionsFactory // TypeDefIndex: 2401
{
	// Fields
	public const byte FIRST_MODULAR_OPTIONS_DATA_VERSION = 7;
	public static readonly int LatestVersion; // 0x0
	private static readonly Dictionary<int, GameOptionsDefinition> cachedVersionDefinitions; // 0x8
	private readonly ILogger logger; // 0x10
	private readonly Dictionary<byte, IGameOptionsMigrator> migrators; // 0x18

	// Methods

	// RVA: 0x7D3090 Offset: 0x7D2290 VA: 0x1807D3090
	private static void .cctor() { }

	// RVA: 0x7D33D0 Offset: 0x7D25D0 VA: 0x1807D33D0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D2A10 Offset: 0x7D1C10 VA: 0x1807D2A10
	public byte[] ToBytes(IGameOptions data, bool forceAprilFoolsMode) { }

	// RVA: 0x7D2FE0 Offset: 0x7D21E0 VA: 0x1807D2FE0
	public void ToNetworkMessageWithSize(MessageWriter writer, IGameOptions data) { }

	// RVA: 0x7D28A0 Offset: 0x7D1AA0 VA: 0x1807D28A0
	public IGameOptions FromBytes(byte[] rawBytes) { }

	// RVA: 0x7D2980 Offset: 0x7D1B80 VA: 0x1807D2980
	public IGameOptions FromNetworkMessageWithSize(MessageReader reader) { }

	// RVA: 0x7D3020 Offset: 0x7D2220 VA: 0x1807D3020
	public bool TryGetMigrator(byte version, out IGameOptionsMigrator migrator) { }

	// RVA: 0x7D20C0 Offset: 0x7D12C0 VA: 0x1807D20C0
	private IGameOptions DeserializeByVersion(MessageReader reader, byte version) { }

	// RVA: 0x7D22E0 Offset: 0x7D14E0 VA: 0x1807D22E0
	private IGameOptions DeserializeModularByVersion(MessageReader reader, byte version) { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsJsonConverter : JsonConverter<IGameOptions> // TypeDefIndex: 2402
{
	// Fields
	private readonly GameOptionsFactory optionsFactory; // 0x10

	// Properties
	public override bool CanWrite { get; }
	public override bool CanRead { get; }

	// Methods

	// RVA: 0x7D3A40 Offset: 0x7D2C40 VA: 0x1807D3A40
	public void .ctor(GameOptionsFactory factory) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x7D3990 Offset: 0x7D2B90 VA: 0x1807D3990 Slot: 9
	public override void WriteJson(JsonWriter writer, IGameOptions value, JsonSerializer serializer) { }

	// RVA: 0x7D37C0 Offset: 0x7D29C0 VA: 0x1807D37C0 Slot: 10
	public override IGameOptions ReadJson(JsonReader reader, Type objectType, IGameOptions existingValue, bool hasExistingValue, JsonSerializer serializer) { }
}

// Namespace: AmongUs.GameOptions
public interface IGameOptions // TypeDefIndex: 2403
{
	// Properties
	public abstract byte Version { get; }
	public abstract GameModes GameMode { get; }
	public abstract SpecialGameModes SpecialMode { get; }
	public abstract GameModes AprilFoolsOnMode { get; }
	public abstract GameModes AprilFoolsOffMode { get; }
	public abstract RulesPresets RulesPreset { get; }
	public abstract int MaxPlayers { get; }
	public abstract GameKeywords Keywords { get; }
	public abstract byte MapId { get; }
	public abstract int NumImpostors { get; }
	public abstract int TotalTaskCount { get; }
	public abstract bool IsDefaults { get; }
	public abstract IRoleOptionsCollection RoleOptions { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract GameModes get_GameMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract SpecialGameModes get_SpecialMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract GameModes get_AprilFoolsOnMode();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GameModes get_AprilFoolsOffMode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract RulesPresets get_RulesPreset();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MaxPlayers();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract GameKeywords get_Keywords();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte get_MapId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_NumImpostors();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_TotalTaskCount();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsDefaults();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IRoleOptionsCollection get_RoleOptions();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool AreInvalid(int maxExpectedPlayers);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetRecommendations(int numPlayers, bool isOnlineGame);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetRecommendations(int numPlayers, bool isOnlineGame, RulesPresets rulesPreset);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetByte(ByteOptionNames optionName, byte value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetFloat(FloatOptionNames optionName, float value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetBool(BoolOptionNames optionName, bool value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetInt(Int32OptionNames optionName, int value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetUInt(UInt32OptionNames optionName, uint value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool TryClearAprilFoolsMode();

	[Obsolete("Prefer usage of TryGetByte")]
	// RVA: -1 Offset: -1 Slot: 22
	public abstract byte GetByte(ByteOptionNames optionName);

	[Obsolete("Prefer usage of TryGetFloat")]
	// RVA: -1 Offset: -1 Slot: 23
	public abstract float GetFloat(FloatOptionNames optionName);

	[Obsolete("Prefer usage of TryGetBool")]
	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool GetBool(BoolOptionNames optionName);

	[Obsolete("Prefer usage of TryGetInt")]
	// RVA: -1 Offset: -1 Slot: 25
	public abstract int GetInt(Int32OptionNames optionName);

	[Obsolete("Prefer usage of TryGetIntArray")]
	// RVA: -1 Offset: -1 Slot: 26
	public abstract int[] GetIntArray(Int32ArrayOptionNames optionName);

	[Obsolete("Prefer usage of TryGetFloatArray")]
	// RVA: -1 Offset: -1 Slot: 27
	public abstract float[] GetFloatArray(FloatArrayOptionNames optionName);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool TryGetByte(ByteOptionNames optionName, out byte value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool TryGetFloat(FloatOptionNames optionName, out float value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool TryGetBool(BoolOptionNames optionName, out bool value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool TryGetInt(Int32OptionNames optionName, out int value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value);
}

// Namespace: AmongUs.GameOptions
public interface IGameOptionsMigrator // TypeDefIndex: 2404
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryMigrate(IGameOptions previousVerison, out IGameOptions updatedVersion);
}

// Namespace: AmongUs.GameOptions
public interface IRoleOptions // TypeDefIndex: 2405
{
	// Properties
	public abstract RoleTypes Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RoleTypes get_Type();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Serialize(MessageWriter writer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Deserialize(MessageReader reader);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetRecommended();
}

// Namespace: AmongUs.GameOptions
public interface IRoleOptionsCollection // TypeDefIndex: 2406
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetNumPerGame(RoleTypes role);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetChancePerGame(RoleTypes role);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetRoleRate(RoleTypes role, int maxCount, int chance);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetRoleRecommended(RoleTypes role);
}

// Namespace: AmongUs.GameOptions
public enum FloatOptionNames // TypeDefIndex: 2407
{
	// Fields
	public int value__; // 0x0
	public const FloatOptionNames Invalid = 0;
	public const FloatOptionNames KillCooldown = 1;
	public const FloatOptionNames PlayerSpeedMod = 2;
	public const FloatOptionNames ImpostorLightMod = 3;
	public const FloatOptionNames CrewLightMod = 4;
	public const FloatOptionNames CrewmateTimeInVent = 100;
	public const FloatOptionNames FinalEscapeTime = 101;
	public const FloatOptionNames EscapeTime = 102;
	public const FloatOptionNames SeekerFinalSpeed = 103;
	public const FloatOptionNames MaxPingTime = 104;
	public const FloatOptionNames CrewmateFlashlightSize = 105;
	public const FloatOptionNames ImpostorFlashlightSize = 106;
	public const FloatOptionNames ShapeshifterCooldown = 1000;
	public const FloatOptionNames ShapeshifterDuration = 1001;
	public const FloatOptionNames ProtectionDurationSeconds = 1100;
	public const FloatOptionNames GuardianAngelCooldown = 1101;
	public const FloatOptionNames ScientistCooldown = 1200;
	public const FloatOptionNames ScientistBatteryCharge = 1201;
	public const FloatOptionNames EngineerCooldown = 1300;
	public const FloatOptionNames EngineerInVentMaxTime = 1301;
	public const FloatOptionNames PhantomCooldown = 1500;
	public const FloatOptionNames PhantomDuration = 1501;
	public const FloatOptionNames TrackerCooldown = 1550;
	public const FloatOptionNames TrackerDuration = 1551;
	public const FloatOptionNames TrackerDelay = 1552;
	public const FloatOptionNames NoisemakerAlertDuration = 1600;
	public const FloatOptionNames ViperDissolveTime = 1601;
	public const FloatOptionNames DetectiveSuspectLimit = 1602;
}

// Namespace: AmongUs.GameOptions
public enum ByteOptionNames // TypeDefIndex: 2408
{
	// Fields
	public int value__; // 0x0
	public const ByteOptionNames Invalid = 0;
	public const ByteOptionNames MapId = 1;
}

// Namespace: AmongUs.GameOptions
public enum BoolOptionNames // TypeDefIndex: 2409
{
	// Fields
	public int value__; // 0x0
	public const BoolOptionNames Invalid = 0;
	public const BoolOptionNames VisualTasks = 1;
	public const BoolOptionNames GhostsDoTasks = 2;
	public const BoolOptionNames ConfirmImpostor = 3;
	public const BoolOptionNames AnonymousVotes = 4;
	public const BoolOptionNames IsDefaults = 5;
	public const BoolOptionNames UseFlashlight = 6;
	public const BoolOptionNames SeekerFinalVents = 7;
	public const BoolOptionNames SeekerFinalMap = 8;
	public const BoolOptionNames SeekerPings = 9;
	public const BoolOptionNames ShowCrewmateNames = 10;
	public const BoolOptionNames Roles = 11;
	public const BoolOptionNames ShapeshifterLeaveSkin = 1000;
	public const BoolOptionNames ImpostorsCanSeeProtect = 1100;
	public const BoolOptionNames NoisemakerImpostorAlert = 1300;
}

// Namespace: AmongUs.GameOptions
public enum Int32OptionNames // TypeDefIndex: 2410
{
	// Fields
	public int value__; // 0x0
	public const Int32OptionNames Invalid = 0;
	public const Int32OptionNames NumImpostors = 1;
	public const Int32OptionNames KillDistance = 2;
	public const Int32OptionNames NumEmergencyMeetings = 3;
	public const Int32OptionNames EmergencyCooldown = 4;
	public const Int32OptionNames DiscussionTime = 5;
	public const Int32OptionNames VotingTime = 6;
	public const Int32OptionNames MaxImpostors = 7;
	public const Int32OptionNames MinPlayers = 8;
	public const Int32OptionNames MaxPlayers = 9;
	public const Int32OptionNames NumCommonTasks = 10;
	public const Int32OptionNames NumShortTasks = 11;
	public const Int32OptionNames NumLongTasks = 12;
	public const Int32OptionNames TaskBarMode = 13;
	public const Int32OptionNames Tag = 14;
	public const Int32OptionNames CrewmatesRemainingForVitals = 100;
	public const Int32OptionNames CrewmateVentUses = 101;
	public const Int32OptionNames ImpostorPlayerID = 102;
	public const Int32OptionNames RulePreset = 200;
}

// Namespace: AmongUs.GameOptions
public enum UInt32OptionNames // TypeDefIndex: 2411
{
	// Fields
	public int value__; // 0x0
	public const UInt32OptionNames Invalid = 0;
	public const UInt32OptionNames Keywords = 1;
}

// Namespace: AmongUs.GameOptions
public enum Int32ArrayOptionNames // TypeDefIndex: 2412
{
	// Fields
	public int value__; // 0x0
	public const Int32ArrayOptionNames Invalid = 0;
	public const Int32ArrayOptionNames MaxImpostors = 1;
	public const Int32ArrayOptionNames MinPlayers = 2;
}

// Namespace: AmongUs.GameOptions
public enum FloatArrayOptionNames // TypeDefIndex: 2413
{
	// Fields
	public int value__; // 0x0
	public const FloatArrayOptionNames Invalid = 0;
	public const FloatArrayOptionNames KillDistances = 1;
}

// Namespace: AmongUs.GameOptions
public struct RoleRate // TypeDefIndex: 2414
{
	// Fields
	public int MaxCount; // 0x0
	public int Chance; // 0x4
}

// Namespace: AmongUs.GameOptions
public enum RoleTypes // TypeDefIndex: 2415
{
	// Fields
	public ushort value__; // 0x0
	public const RoleTypes Crewmate = 0;
	public const RoleTypes Impostor = 1;
	public const RoleTypes Scientist = 2;
	public const RoleTypes Engineer = 3;
	public const RoleTypes GuardianAngel = 4;
	public const RoleTypes Shapeshifter = 5;
	public const RoleTypes CrewmateGhost = 6;
	public const RoleTypes ImpostorGhost = 7;
	public const RoleTypes Noisemaker = 8;
	public const RoleTypes Phantom = 9;
	public const RoleTypes Tracker = 10;
	public const RoleTypes Detective = 12;
	public const RoleTypes Viper = 18;
}

// Namespace: AmongUs.GameOptions
public enum RulesPresets // TypeDefIndex: 2416
{
	// Fields
	public byte value__; // 0x0
	public const RulesPresets Standard = 0;
	public const RulesPresets StandardRoles = 1;
	public const RulesPresets Flashlight = 2;
	public const RulesPresets Custom = 100;
}

// Namespace: AmongUs.GameOptions
[Flags]
public enum SpecialGameModes // TypeDefIndex: 2417
{
	// Fields
	public byte value__; // 0x0
	public const SpecialGameModes None = 0;
	public const SpecialGameModes AprilFools = 1;
}

// Namespace: AmongUs.GameOptions
public enum TaskBarMode // TypeDefIndex: 2418
{
	// Fields
	public int value__; // 0x0
	public const TaskBarMode Normal = 0;
	public const TaskBarMode MeetingOnly = 1;
	public const TaskBarMode Invisible = 2;
}

// Namespace: AmongUs.GameOptions
public class LegacyGameOptions : IGameOptions // TypeDefIndex: 2419
{
	// Fields
	private static readonly int[] RecommendedKillCooldown; // 0x0
	private static readonly int[] RecommendedImpostors; // 0x8
	private static readonly int[] MaxImpostors; // 0x10
	private static readonly float[] KillDistances; // 0x18
	private static readonly string[] KillDistanceStrings; // 0x20
	private static readonly int[] MinPlayers; // 0x28
	[CompilerGenerated]
	private byte <Version>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	private const byte EmergencyCooldownSupportVersion = 1;
	private const byte VisualTaskOptionsSupportVersion = 2;
	private const byte ExtraVotingOptionsSupportVersion = 3;
	private const byte RolesSupportVersion = 4;
	public const byte ServerVersion = 2;
	public const byte NewestVersion = 5;
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	public float PlayerSpeedMod; // 0x20
	public float CrewLightMod; // 0x24
	public float ImpostorLightMod; // 0x28
	public float KillCooldown; // 0x2C
	public int NumCommonTasks; // 0x30
	public int NumLongTasks; // 0x34
	public int NumShortTasks; // 0x38
	public int NumEmergencyMeetings; // 0x3C
	public int EmergencyCooldown; // 0x40
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x44
	public bool GhostsDoTasks; // 0x48
	public int KillDistance; // 0x4C
	public int DiscussionTime; // 0x50
	public int VotingTime; // 0x54
	public bool ConfirmImpostor; // 0x58
	public bool VisualTasks; // 0x59
	public bool AnonymousVotes; // 0x5A
	public TaskBarMode TaskBarMode; // 0x5C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x60
	private readonly ILogger logger; // 0x68
	private LegacyRoleOptionsCollection roleOptions; // 0x70

	// Properties
	public byte Version { get; set; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public bool IsDefaults { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_Version(byte value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	private void set_GameMode(GameModes value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	// RVA: 0x7DA320 Offset: 0x7D9520 VA: 0x1807DA320 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	private void set_MapId(byte value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	private void set_NumImpostors(int value) { }

	[CompilerGenerated]
	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	private void set_IsDefaults(bool value) { }

	// RVA: 0x7DA330 Offset: 0x7D9530 VA: 0x1807DA330 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7DA230 Offset: 0x7D9430 VA: 0x1807DA230
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D8600 Offset: 0x7D7800 VA: 0x1807D8600
	public static void Serialize(BinaryWriter writer, LegacyGameOptions gameOptionsData) { }

	// RVA: 0x7D7A80 Offset: 0x7D6C80 VA: 0x1807D7A80
	public static LegacyGameOptions Deserialize(BinaryReader reader, byte version, ILogger logger) { }

	// RVA: 0x7D7A40 Offset: 0x7D6C40 VA: 0x1807D7A40 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7D9110 Offset: 0x7D8310 VA: 0x1807D9110 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7D9F40 Offset: 0x7D9140 VA: 0x1807D9F40
	public bool Validate(int numPlayers) { }

	// RVA: 0x7D8A80 Offset: 0x7D7C80 VA: 0x1807D8A80 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7D8BB0 Offset: 0x7D7DB0 VA: 0x1807D8BB0 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7D88A0 Offset: 0x7D7AA0 VA: 0x1807D88A0 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7D8ED0 Offset: 0x7D80D0 VA: 0x1807D8ED0 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7D9300 Offset: 0x7D8500 VA: 0x1807D9300 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D8020 Offset: 0x7D7220 VA: 0x1807D8020 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7D8290 Offset: 0x7D7490 VA: 0x1807D8290 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7D7E40 Offset: 0x7D7040 VA: 0x1807D7E40 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7D8440 Offset: 0x7D7640 VA: 0x1807D8440 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7D82C0 Offset: 0x7D74C0 VA: 0x1807D82C0 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7D8140 Offset: 0x7D7340 VA: 0x1807D8140 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D9650 Offset: 0x7D8850 VA: 0x1807D9650 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7D98E0 Offset: 0x7D8AE0 VA: 0x1807D98E0 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7D9440 Offset: 0x7D8640 VA: 0x1807D9440 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7D9D40 Offset: 0x7D8F40 VA: 0x1807D9D40 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7D9BA0 Offset: 0x7D8DA0 VA: 0x1807D9BA0 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7D9780 Offset: 0x7D8980 VA: 0x1807D9780 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7D9430 Offset: 0x7D8630 VA: 0x1807D9430 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7D9FF0 Offset: 0x7D91F0 VA: 0x1807D9FF0
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class LegacyRoleOptionsCollection : IRoleOptionsCollection // TypeDefIndex: 2420
{
	// Fields
	public bool ShapeshifterLeaveSkin; // 0x10
	public float ShapeshifterCooldown; // 0x14
	public float ShapeshifterDuration; // 0x18
	public float ScientistCooldown; // 0x1C
	public float ScientistBatteryCharge; // 0x20
	public float GuardianAngelCooldown; // 0x24
	public float ProtectionDurationSeconds; // 0x28
	public bool ImpostorsCanSeeProtect; // 0x2C
	public float EngineerCooldown; // 0x30
	public float EngineerInVentMaxTime; // 0x34
	private Dictionary<RoleTypes, RoleRate> roleRates; // 0x38

	// Methods

	// RVA: 0x7DA340 Offset: 0x7D9540 VA: 0x1807DA340
	public static LegacyRoleOptionsCollection Deserialize(BinaryReader reader) { }

	// RVA: 0x7DA5E0 Offset: 0x7D97E0 VA: 0x1807DA5E0
	public static LegacyRoleOptionsCollection Deserialize(MessageReader reader) { }

	// RVA: 0x7DA8C0 Offset: 0x7D9AC0 VA: 0x1807DA8C0
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7DAB70 Offset: 0x7D9D70 VA: 0x1807DAB70
	public static void Serialize(BinaryWriter writer, LegacyRoleOptionsCollection roleOptions) { }

	// RVA: 0x7DA840 Offset: 0x7D9A40 VA: 0x1807DA840 Slot: 4
	public int GetNumPerGame(RoleTypes role) { }

	// RVA: 0x7DA7C0 Offset: 0x7D99C0 VA: 0x1807DA7C0 Slot: 5
	public int GetChancePerGame(RoleTypes role) { }

	// RVA: 0x7DAED0 Offset: 0x7DA0D0 VA: 0x1807DAED0 Slot: 6
	public void SetRoleRate(RoleTypes role, int maxCount, int chance) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void SetRoleRecommended(RoleTypes roleTYpe) { }

	// RVA: 0x7DAF50 Offset: 0x7DA150 VA: 0x1807DAF50
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class EngineerRoleOptionsV07 : IRoleOptions // TypeDefIndex: 2421
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float EngineerCooldown; // 0x14
	public float EngineerInVentMaxTime; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D1890 Offset: 0x7D0A90 VA: 0x1807D1890 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D18A0 Offset: 0x7D0AA0 VA: 0x1807D18A0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsDefinitionV07 : GameOptionsDefinition // TypeDefIndex: 2422
{
	// Properties
	public override byte Version { get; }

	// Methods

	// RVA: 0x7D1E20 Offset: 0x7D1020 VA: 0x1807D1E20 Slot: 4
	public override byte get_Version() { }

	// RVA: 0x7D18C0 Offset: 0x7D0AC0 VA: 0x1807D18C0 Slot: 5
	public override IGameOptionsMigrator GetMigrator(ILogger logger) { }

	// RVA: 0x7D1C20 Offset: 0x7D0E20 VA: 0x1807D1C20 Slot: 6
	public override void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7D1BB0 Offset: 0x7D0DB0 VA: 0x1807D1BB0 Slot: 7
	public override IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D1990 Offset: 0x7D0B90 VA: 0x1807D1990 Slot: 8
	public override void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7D1920 Offset: 0x7D0B20 VA: 0x1807D1920 Slot: 9
	public override IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsMigratorV06toV07 : IGameOptionsMigrator // TypeDefIndex: 2423
{
	// Fields
	private readonly ILogger logger; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D3AE0 Offset: 0x7D2CE0 VA: 0x1807D3AE0 Slot: 4
	public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion) { }
}

// Namespace: AmongUs.GameOptions
public class GuardianAngelRoleOptionsV07 : IRoleOptions // TypeDefIndex: 2424
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float GuardianAngelCooldown; // 0x14
	public float ProtectionDurationSeconds; // 0x18
	public bool ImpostorsCanSeeProtect; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D4FC0 Offset: 0x7D41C0 VA: 0x1807D4FC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D4F50 Offset: 0x7D4150 VA: 0x1807D4F50 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D5040 Offset: 0x7D4240 VA: 0x1807D5040 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D5060 Offset: 0x7D4260 VA: 0x1807D5060
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class HideNSeekGameOptionsV07 : IGameOptions // TypeDefIndex: 2425
{
	// Fields
	public static readonly float[] KillDistances; // 0x0
	private static readonly int[] MaxImpostors; // 0x8
	private static readonly int[] MinPlayers; // 0x10
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x11
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public int ImpostorPlayerID; // 0x20
	public float PlayerSpeedMod; // 0x24
	public float CrewLightMod; // 0x28
	public float ImpostorLightMod; // 0x2C
	public float KillCooldown; // 0x30
	public int NumCommonTasks; // 0x34
	public int NumLongTasks; // 0x38
	public int NumShortTasks; // 0x3C
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x40
	public bool GhostsDoTasks; // 0x44
	public int KillDistance; // 0x48
	public const float ImpostorSpeedDifference = 0,25;
	public int CrewmateVentUses; // 0x4C
	public float CrewmateTimeInVent; // 0x50
	public float EscapeTime; // 0x54
	public float FinalCountdownTime; // 0x58
	public float CrewmateFlashlightSize; // 0x5C
	public float ImpostorFlashlightSize; // 0x60
	public bool useFlashlight; // 0x64
	public bool SeekerFinalMap; // 0x65
	public float SeekerFinalSpeed; // 0x68
	public bool ShowCrewmateNames; // 0x6C
	public float MaxPingTime; // 0x70
	public bool SeekerPings; // 0x74
	public const int CrewmateLeadTime = 10;
	public const float ScaryMusicDistance = 55;
	public const float VeryScaryMusicDistance = 15;
	public const float CrewmateVentCooldown = 1;
	public const float ShowPingTime = 2;
	private readonly ILogger logger; // 0x78
	private RoleOptionsCollectionV07 roleOptions; // 0x80

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7D1E20 Offset: 0x7D1020 VA: 0x1807D1E20 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	// RVA: 0x7D6680 Offset: 0x7D5880 VA: 0x1807D6680 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x7D6670 Offset: 0x7D5870 VA: 0x1807D6670 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	private void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	private void set_IsDefaults(bool value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_NumImpostors(int value) { }

	// RVA: 0x7D6690 Offset: 0x7D5890 VA: 0x1807D6690 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7D6510 Offset: 0x7D5710 VA: 0x1807D6510
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D5640 Offset: 0x7D4840 VA: 0x1807D5640
	public static void Serialize(MessageWriter writer, HideNSeekGameOptionsV07 gameOptions) { }

	// RVA: 0x7D50A0 Offset: 0x7D42A0 VA: 0x1807D50A0
	public static HideNSeekGameOptionsV07 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D5080 Offset: 0x7D4280 VA: 0x1807D5080 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7D5EF0 Offset: 0x7D50F0 VA: 0x1807D5EF0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7D5980 Offset: 0x7D4B80 VA: 0x1807D5980 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7D5AB0 Offset: 0x7D4CB0 VA: 0x1807D5AB0 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7D57D0 Offset: 0x7D49D0 VA: 0x1807D57D0 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7D5D10 Offset: 0x7D4F10 VA: 0x1807D5D10 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7D5F70 Offset: 0x7D5170 VA: 0x1807D5F70 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7D54A0 Offset: 0x7D46A0 VA: 0x1807D54A0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7D53C0 Offset: 0x7D45C0 VA: 0x1807D53C0 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7D55F0 Offset: 0x7D47F0 VA: 0x1807D55F0 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7D5550 Offset: 0x7D4750 VA: 0x1807D5550 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7D5440 Offset: 0x7D4640 VA: 0x1807D5440 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7D61E0 Offset: 0x7D53E0 VA: 0x1807D61E0 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7D60B0 Offset: 0x7D52B0 VA: 0x1807D60B0 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7D6380 Offset: 0x7D5580 VA: 0x1807D6380 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7D62C0 Offset: 0x7D54C0 VA: 0x1807D62C0 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7D6160 Offset: 0x7D5360 VA: 0x1807D6160 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7D60A0 Offset: 0x7D52A0 VA: 0x1807D60A0 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7D6400 Offset: 0x7D5600 VA: 0x1807D6400
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class NormalGameOptionsV07 : IGameOptions // TypeDefIndex: 2426
{
	// Fields
	private static readonly int[] RecommendedKillCooldown; // 0x0
	private static readonly int[] RecommendedImpostors; // 0x8
	private static readonly int[] MaxImpostors; // 0x10
	private static readonly float[] KillDistances; // 0x18
	private static readonly string[] KillDistanceStrings; // 0x20
	private static readonly int[] MinPlayers; // 0x28
	private static readonly RoleTypes[] NonStandardRoles; // 0x30
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x11
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public float PlayerSpeedMod; // 0x20
	public float CrewLightMod; // 0x24
	public float ImpostorLightMod; // 0x28
	public float KillCooldown; // 0x2C
	public int NumCommonTasks; // 0x30
	public int NumLongTasks; // 0x34
	public int NumShortTasks; // 0x38
	public int NumEmergencyMeetings; // 0x3C
	public int EmergencyCooldown; // 0x40
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x44
	public bool GhostsDoTasks; // 0x48
	public int KillDistance; // 0x4C
	public int DiscussionTime; // 0x50
	public int VotingTime; // 0x54
	public bool ConfirmImpostor; // 0x58
	public bool VisualTasks; // 0x59
	public bool AnonymousVotes; // 0x5A
	public TaskBarMode TaskBarMode; // 0x5C
	private readonly ILogger logger; // 0x60
	private RoleOptionsCollectionV07 roleOptions; // 0x68

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7D1E20 Offset: 0x7D1020 VA: 0x1807D1E20 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	// RVA: 0x7DA320 Offset: 0x7D9520 VA: 0x1807DA320 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_NumImpostors(int value) { }

	// RVA: 0x7DA330 Offset: 0x7D9530 VA: 0x1807DA330 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7DD480 Offset: 0x7DC680 VA: 0x1807DD480
	public void .ctor(ILogger logger) { }

	// RVA: 0x7DB780 Offset: 0x7DA980 VA: 0x1807DB780
	public static void Serialize(MessageWriter writer, NormalGameOptionsV07 gameOptions) { }

	// RVA: 0x7DB0D0 Offset: 0x7DA2D0 VA: 0x1807DB0D0
	public static NormalGameOptionsV07 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D7A40 Offset: 0x7D6C40 VA: 0x1807D7A40 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7DC810 Offset: 0x7DBA10 VA: 0x1807DC810 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7DBC40 Offset: 0x7DAE40 VA: 0x1807DBC40 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7DBD70 Offset: 0x7DAF70 VA: 0x1807DBD70 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7DB900 Offset: 0x7DAB00 VA: 0x1807DB900 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7DC5D0 Offset: 0x7DB7D0 VA: 0x1807DC5D0 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7DCA30 Offset: 0x7DBC30 VA: 0x1807DCA30 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7DB620 Offset: 0x7DA820 VA: 0x1807DB620 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7DB440 Offset: 0x7DA640 VA: 0x1807DB440 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7DB6F0 Offset: 0x7DA8F0 VA: 0x1807DB6F0 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7DB650 Offset: 0x7DA850 VA: 0x1807DB650 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7DB5B0 Offset: 0x7DA7B0 VA: 0x1807DB5B0 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7DCD30 Offset: 0x7DBF30 VA: 0x1807DCD30 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7DCB70 Offset: 0x7DBD70 VA: 0x1807DCB70 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7DD120 Offset: 0x7DC320 VA: 0x1807DD120 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7DD060 Offset: 0x7DC260 VA: 0x1807DD060 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7DCCB0 Offset: 0x7DBEB0 VA: 0x1807DCCB0 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7DCB60 Offset: 0x7DBD60 VA: 0x1807DCB60 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7DD1E0 Offset: 0x7DC3E0 VA: 0x1807DD1E0
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class RoleDataV07 // TypeDefIndex: 2427
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IRoleOptions <RoleOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private RoleRate <Rate>k__BackingField; // 0x20

	// Properties
	public RoleTypes Type { get; }
	public IRoleOptions RoleOptions { get; }
	public RoleRate Rate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	public RoleTypes get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IRoleOptions get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RoleRate get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Rate(RoleRate value) { }

	// RVA: 0x7E09A0 Offset: 0x7DFBA0 VA: 0x1807E09A0
	public void .ctor(IRoleOptions roleOptions, RoleRate rate) { }

	// RVA: 0x7E0A80 Offset: 0x7DFC80 VA: 0x1807E0A80
	public void .ctor(RoleTypes type) { }
}

// Namespace: AmongUs.GameOptions
public class RoleOptionsCollectionV07 : IRoleOptionsCollection // TypeDefIndex: 2428
{
	// Fields
	private readonly Dictionary<RoleTypes, RoleDataV07> roles; // 0x10

	// Methods

	// RVA: 0x7E0C40 Offset: 0x7DFE40 VA: 0x1807E0C40
	public static RoleOptionsCollectionV07 Deserialize(MessageReader reader) { }

	// RVA: 0x7E0F70 Offset: 0x7E0170 VA: 0x1807E0F70
	public static void Serialize(MessageWriter writer, RoleOptionsCollectionV07 options) { }

	// RVA: 0x7E0E80 Offset: 0x7E0080 VA: 0x1807E0E80 Slot: 4
	public int GetNumPerGame(RoleTypes role) { }

	// RVA: 0x7E0DF0 Offset: 0x7DFFF0 VA: 0x1807E0DF0 Slot: 5
	public int GetChancePerGame(RoleTypes role) { }

	// RVA: 0x7E1200 Offset: 0x7E0400 VA: 0x1807E1200 Slot: 6
	public void SetRoleRate(RoleTypes role, int maxCount, int chance) { }

	// RVA: 0x7E12D0 Offset: 0x7E04D0 VA: 0x1807E12D0 Slot: 7
	public void SetRoleRecommended(RoleTypes role) { }

	// RVA: -1 Offset: -1
	public bool TryGetRoleOptions<T>(RoleTypes type, out T roleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA697B0 Offset: 0xA689B0 VA: 0x180A697B0
	|-RoleOptionsCollectionV07.TryGetRoleOptions<object>
	*/

	// RVA: 0x7E13A0 Offset: 0x7E05A0 VA: 0x1807E13A0
	public bool TryGetRoleRates(RoleTypes type, out RoleRate roleRates) { }

	// RVA: 0x7E0BA0 Offset: 0x7DFDA0 VA: 0x1807E0BA0
	public void AddOrUpdateRole(RoleDataV07 role) { }

	// RVA: 0x7E0F10 Offset: 0x7E0110 VA: 0x1807E0F10
	public void RemoveRole(RoleTypes roleType) { }

	// RVA: 0x7E1440 Offset: 0x7E0640 VA: 0x1807E1440
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ScientistRoleOptionsV07 : IRoleOptions // TypeDefIndex: 2429
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float ScientistCooldown; // 0x14
	public float ScientistBatteryCharge; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E14B0 Offset: 0x7E06B0 VA: 0x1807E14B0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E14C0 Offset: 0x7E06C0 VA: 0x1807E14C0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ShapeshifterRoleOptionsV07 : IRoleOptions // TypeDefIndex: 2430
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool ShapeshifterLeaveSkin; // 0x12
	public float ShapeshifterCooldown; // 0x14
	public float ShapeshifterDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E1550 Offset: 0x7E0750 VA: 0x1807E1550 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E14E0 Offset: 0x7E06E0 VA: 0x1807E14E0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E15D0 Offset: 0x7E07D0 VA: 0x1807E15D0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E15F0 Offset: 0x7E07F0 VA: 0x1807E15F0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class EngineerRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2431
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float EngineerCooldown; // 0x14
	public float EngineerInVentMaxTime; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D1890 Offset: 0x7D0A90 VA: 0x1807D1890 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D18A0 Offset: 0x7D0AA0 VA: 0x1807D18A0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsDefinitionV08 : GameOptionsDefinition // TypeDefIndex: 2432
{
	// Properties
	public override byte Version { get; }

	// Methods

	// RVA: 0x7D20B0 Offset: 0x7D12B0 VA: 0x1807D20B0 Slot: 4
	public override byte get_Version() { }

	// RVA: 0x7D1E30 Offset: 0x7D1030 VA: 0x1807D1E30 Slot: 5
	public override IGameOptionsMigrator GetMigrator(ILogger logger) { }

	// RVA: 0x7D2010 Offset: 0x7D1210 VA: 0x1807D2010 Slot: 6
	public override void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7D1FA0 Offset: 0x7D11A0 VA: 0x1807D1FA0 Slot: 7
	public override IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D1F00 Offset: 0x7D1100 VA: 0x1807D1F00 Slot: 8
	public override void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7D1E90 Offset: 0x7D1090 VA: 0x1807D1E90 Slot: 9
	public override IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsMigratorV07toV08 : IGameOptionsMigrator // TypeDefIndex: 2433
{
	// Fields
	private readonly ILogger logger; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D4DC0 Offset: 0x7D3FC0 VA: 0x1807D4DC0 Slot: 4
	public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7D44C0 Offset: 0x7D36C0 VA: 0x1807D44C0
	private bool TryMigrateNormal(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7D4230 Offset: 0x7D3430 VA: 0x1807D4230
	private bool TryMigrateHideAndSeek(IGameOptions previousVersion, out IGameOptions updatedVersion) { }
}

// Namespace: AmongUs.GameOptions
public class GuardianAngelRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2434
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float GuardianAngelCooldown; // 0x14
	public float ProtectionDurationSeconds; // 0x18
	public bool ImpostorsCanSeeProtect; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D4FC0 Offset: 0x7D41C0 VA: 0x1807D4FC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D4F50 Offset: 0x7D4150 VA: 0x1807D4F50 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D5040 Offset: 0x7D4240 VA: 0x1807D5040 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D5060 Offset: 0x7D4260 VA: 0x1807D5060
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class HideNSeekGameOptionsV08 : IGameOptions // TypeDefIndex: 2435
{
	// Fields
	public static readonly float[] KillDistances; // 0x0
	private static readonly int[] MaxImpostors; // 0x8
	private static readonly int[] MinPlayers; // 0x10
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public int ImpostorPlayerID; // 0x20
	public float PlayerSpeedMod; // 0x24
	public float CrewLightMod; // 0x28
	public float ImpostorLightMod; // 0x2C
	public float KillCooldown; // 0x30
	public int NumCommonTasks; // 0x34
	public int NumLongTasks; // 0x38
	public int NumShortTasks; // 0x3C
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x40
	public bool GhostsDoTasks; // 0x44
	public int KillDistance; // 0x48
	public const float ImpostorSpeedDifference = 0,25;
	public int CrewmateVentUses; // 0x4C
	public float CrewmateTimeInVent; // 0x50
	public float EscapeTime; // 0x54
	public float FinalCountdownTime; // 0x58
	public float CrewmateFlashlightSize; // 0x5C
	public float ImpostorFlashlightSize; // 0x60
	public bool useFlashlight; // 0x64
	public bool SeekerFinalMap; // 0x65
	public float SeekerFinalSpeed; // 0x68
	public bool ShowCrewmateNames; // 0x6C
	public float MaxPingTime; // 0x70
	public bool SeekerPings; // 0x74
	public const int CrewmateLeadTime = 10;
	public const float ScaryMusicDistance = 55;
	public const float VeryScaryMusicDistance = 15;
	public const float CrewmateVentCooldown = 1;
	public const float ShowPingTime = 2;
	private readonly ILogger logger; // 0x78
	private RoleOptionsCollectionV08 roleOptions; // 0x80

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7D20B0 Offset: 0x7D12B0 VA: 0x1807D20B0 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7D6680 Offset: 0x7D5880 VA: 0x1807D6680 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x7D6670 Offset: 0x7D5870 VA: 0x1807D6670 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_NumImpostors(int value) { }

	// RVA: 0x7D6690 Offset: 0x7D5890 VA: 0x1807D6690 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7D7920 Offset: 0x7D6B20 VA: 0x1807D7920
	public void .ctor(ILogger logger) { }

	// RVA: 0x7D6AD0 Offset: 0x7D5CD0 VA: 0x1807D6AD0
	public static void Serialize(MessageWriter writer, HideNSeekGameOptionsV08 gameOptions) { }

	// RVA: 0x7D66B0 Offset: 0x7D58B0 VA: 0x1807D66B0
	public static HideNSeekGameOptionsV08 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D5080 Offset: 0x7D4280 VA: 0x1807D5080 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7D7490 Offset: 0x7D6690 VA: 0x1807D7490 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7D73C0 Offset: 0x7D65C0 VA: 0x1807D73C0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7D6E30 Offset: 0x7D6030 VA: 0x1807D6E30 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7D6F60 Offset: 0x7D6160 VA: 0x1807D6F60 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7D6C80 Offset: 0x7D5E80 VA: 0x1807D6C80 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7D71C0 Offset: 0x7D63C0 VA: 0x1807D71C0 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7D7510 Offset: 0x7D6710 VA: 0x1807D7510 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7D54A0 Offset: 0x7D46A0 VA: 0x1807D54A0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7D53C0 Offset: 0x7D45C0 VA: 0x1807D53C0 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7D6A70 Offset: 0x7D5C70 VA: 0x1807D6A70 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7D69D0 Offset: 0x7D5BD0 VA: 0x1807D69D0 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7D6970 Offset: 0x7D5B70 VA: 0x1807D6970 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7D61E0 Offset: 0x7D53E0 VA: 0x1807D61E0 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7D60B0 Offset: 0x7D52B0 VA: 0x1807D60B0 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7D7780 Offset: 0x7D6980 VA: 0x1807D7780 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7D76C0 Offset: 0x7D68C0 VA: 0x1807D76C0 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7D7640 Offset: 0x7D6840 VA: 0x1807D7640 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7D60A0 Offset: 0x7D52A0 VA: 0x1807D60A0 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7D7810 Offset: 0x7D6A10 VA: 0x1807D7810
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class NoisemakerRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2436
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool NoisemakerImpostorAlert; // 0x12
	public float NoisemakerAlertDuration; // 0x14

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7DB050 Offset: 0x7DA250 VA: 0x1807DB050 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7DB000 Offset: 0x7DA200 VA: 0x1807DB000 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7DB0A0 Offset: 0x7DA2A0 VA: 0x1807DB0A0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7DB0B0 Offset: 0x7DA2B0 VA: 0x1807DB0B0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class NormalGameOptionsV08 : IGameOptions // TypeDefIndex: 2437
{
	// Fields
	private static readonly int[] RecommendedKillCooldown; // 0x0
	private static readonly int[] RecommendedImpostors; // 0x8
	private static readonly int[] MaxImpostors; // 0x10
	private static readonly float[] KillDistances; // 0x18
	private static readonly string[] KillDistanceStrings; // 0x20
	private static readonly int[] MinPlayers; // 0x28
	private static readonly RoleTypes[] NonStandardRoles; // 0x30
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public float PlayerSpeedMod; // 0x20
	public float CrewLightMod; // 0x24
	public float ImpostorLightMod; // 0x28
	public float KillCooldown; // 0x2C
	public int NumCommonTasks; // 0x30
	public int NumLongTasks; // 0x34
	public int NumShortTasks; // 0x38
	public int NumEmergencyMeetings; // 0x3C
	public int EmergencyCooldown; // 0x40
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x44
	public bool GhostsDoTasks; // 0x48
	public int KillDistance; // 0x4C
	public int DiscussionTime; // 0x50
	public int VotingTime; // 0x54
	public bool ConfirmImpostor; // 0x58
	public bool VisualTasks; // 0x59
	public bool AnonymousVotes; // 0x5A
	public TaskBarMode TaskBarMode; // 0x5C
	private readonly ILogger logger; // 0x60
	private RoleOptionsCollectionV08 roleOptions; // 0x68

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7D20B0 Offset: 0x7D12B0 VA: 0x1807D20B0 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7DA320 Offset: 0x7D9520 VA: 0x1807DA320 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_NumImpostors(int value) { }

	// RVA: 0x7DA330 Offset: 0x7D9530 VA: 0x1807DA330 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7E06F0 Offset: 0x7DF8F0 VA: 0x1807E06F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7DDD50 Offset: 0x7DCF50 VA: 0x1807DDD50
	public static void Serialize(MessageWriter writer, NormalGameOptionsV08 gameOptions) { }

	// RVA: 0x7DD880 Offset: 0x7DCA80 VA: 0x1807DD880
	public static NormalGameOptionsV08 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D7A40 Offset: 0x7D6C40 VA: 0x1807D7A40 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7DF7F0 Offset: 0x7DE9F0 VA: 0x1807DF7F0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7DF3F0 Offset: 0x7DE5F0 VA: 0x1807DF3F0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7DE320 Offset: 0x7DD520 VA: 0x1807DE320 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7DE450 Offset: 0x7DD650 VA: 0x1807DE450 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7DDEF0 Offset: 0x7DD0F0 VA: 0x1807DDEF0 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7DF190 Offset: 0x7DE390 VA: 0x1807DF190 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7DF810 Offset: 0x7DEA10 VA: 0x1807DF810 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7DDBF0 Offset: 0x7DCDF0 VA: 0x1807DDBF0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7DDB50 Offset: 0x7DCD50 VA: 0x1807DDB50 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7DDCC0 Offset: 0x7DCEC0 VA: 0x1807DDCC0 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7DDC20 Offset: 0x7DCE20 VA: 0x1807DDC20 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7DDB80 Offset: 0x7DCD80 VA: 0x1807DDB80 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7DFC40 Offset: 0x7DEE40 VA: 0x1807DFC40 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7DF940 Offset: 0x7DEB40 VA: 0x1807DF940 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7E0380 Offset: 0x7DF580 VA: 0x1807E0380 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7E02C0 Offset: 0x7DF4C0 VA: 0x1807E02C0 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7DFBC0 Offset: 0x7DEDC0 VA: 0x1807DFBC0 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7DCB60 Offset: 0x7DBD60 VA: 0x1807DCB60 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7E0450 Offset: 0x7DF650 VA: 0x1807E0450
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class PhantomRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2438
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float PhantomCooldown; // 0x14
	public float PhantomDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F0470 Offset: 0x7EF670 VA: 0x1807F0470 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F0480 Offset: 0x7EF680 VA: 0x1807F0480
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class RoleDataV08 // TypeDefIndex: 2439
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IRoleOptions <RoleOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private RoleRate <Rate>k__BackingField; // 0x20

	// Properties
	public RoleTypes Type { get; }
	public IRoleOptions RoleOptions { get; }
	public RoleRate Rate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	public RoleTypes get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IRoleOptions get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RoleRate get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Rate(RoleRate value) { }

	// RVA: 0x7F3460 Offset: 0x7F2660 VA: 0x1807F3460
	public void .ctor(IRoleOptions roleOptions, RoleRate rate) { }

	// RVA: 0x7F3280 Offset: 0x7F2480 VA: 0x1807F3280
	public void .ctor(RoleTypes type) { }
}

// Namespace: AmongUs.GameOptions
public class RoleOptionsCollectionV08 : IRoleOptionsCollection // TypeDefIndex: 2440
{
	// Fields
	private readonly Dictionary<RoleTypes, RoleDataV08> roles; // 0x10

	// Methods

	// RVA: 0x7F3A90 Offset: 0x7F2C90 VA: 0x1807F3A90
	public static RoleOptionsCollectionV08 Deserialize(MessageReader reader) { }

	// RVA: 0x7F3DC0 Offset: 0x7F2FC0 VA: 0x1807F3DC0
	public static void Serialize(MessageWriter writer, RoleOptionsCollectionV08 options) { }

	// RVA: 0x7F3CD0 Offset: 0x7F2ED0 VA: 0x1807F3CD0 Slot: 4
	public int GetNumPerGame(RoleTypes role) { }

	// RVA: 0x7F3C40 Offset: 0x7F2E40 VA: 0x1807F3C40 Slot: 5
	public int GetChancePerGame(RoleTypes role) { }

	// RVA: 0x7F3FC0 Offset: 0x7F31C0 VA: 0x1807F3FC0 Slot: 6
	public void SetRoleRate(RoleTypes role, int maxCount, int chance) { }

	// RVA: 0x7F4090 Offset: 0x7F3290 VA: 0x1807F4090 Slot: 7
	public void SetRoleRecommended(RoleTypes role) { }

	// RVA: -1 Offset: -1
	public bool TryGetRoleOptions<T>(RoleTypes type, out T roleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69940 Offset: 0xA68B40 VA: 0x180A69940
	|-RoleOptionsCollectionV08.TryGetRoleOptions<object>
	*/

	// RVA: 0x7F4160 Offset: 0x7F3360 VA: 0x1807F4160
	public bool TryGetRoleRates(RoleTypes type, out RoleRate roleRates) { }

	// RVA: 0x7F39F0 Offset: 0x7F2BF0 VA: 0x1807F39F0
	public void AddOrUpdateRole(RoleDataV08 role) { }

	// RVA: 0x7F4200 Offset: 0x7F3400 VA: 0x1807F4200
	public void UpdateFrom(RoleOptionsCollectionV08 roleOptionsCollectionV08) { }

	// RVA: 0x7F3D60 Offset: 0x7F2F60 VA: 0x1807F3D60
	public void RemoveRole(RoleTypes roleType) { }

	// RVA: 0x7F43D0 Offset: 0x7F35D0 VA: 0x1807F43D0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ScientistRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2441
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float ScientistCooldown; // 0x14
	public float ScientistBatteryCharge; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E14B0 Offset: 0x7E06B0 VA: 0x1807E14B0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E14C0 Offset: 0x7E06C0 VA: 0x1807E14C0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ShapeshifterRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2442
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool ShapeshifterLeaveSkin; // 0x12
	public float ShapeshifterCooldown; // 0x14
	public float ShapeshifterDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E1550 Offset: 0x7E0750 VA: 0x1807E1550 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E14E0 Offset: 0x7E06E0 VA: 0x1807E14E0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E15D0 Offset: 0x7E07D0 VA: 0x1807E15D0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E15F0 Offset: 0x7E07F0 VA: 0x1807E15F0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class TrackerRoleOptionsV08 : IRoleOptions // TypeDefIndex: 2443
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float TrackerCooldown; // 0x14
	public float TrackerDuration; // 0x18
	public float TrackerDelay; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7F5CC0 Offset: 0x7F4EC0 VA: 0x1807F5CC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7F5C40 Offset: 0x7F4E40 VA: 0x1807F5C40 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F5D40 Offset: 0x7F4F40 VA: 0x1807F5D40 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F5D60 Offset: 0x7F4F60 VA: 0x1807F5D60
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class EngineerRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2444
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float EngineerCooldown; // 0x14
	public float EngineerInVentMaxTime; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D1890 Offset: 0x7D0A90 VA: 0x1807D1890 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D18A0 Offset: 0x7D0AA0 VA: 0x1807D18A0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsDefinitionV09 : GameOptionsDefinition // TypeDefIndex: 2445
{
	// Properties
	public override byte Version { get; }

	// Methods

	// RVA: 0x7E4930 Offset: 0x7E3B30 VA: 0x1807E4930 Slot: 4
	public override byte get_Version() { }

	// RVA: 0x7E46B0 Offset: 0x7E38B0 VA: 0x1807E46B0 Slot: 5
	public override IGameOptionsMigrator GetMigrator(ILogger logger) { }

	// RVA: 0x7E4890 Offset: 0x7E3A90 VA: 0x1807E4890 Slot: 6
	public override void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7E4820 Offset: 0x7E3A20 VA: 0x1807E4820 Slot: 7
	public override IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7E4780 Offset: 0x7E3980 VA: 0x1807E4780 Slot: 8
	public override void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7E4710 Offset: 0x7E3910 VA: 0x1807E4710 Slot: 9
	public override IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsMigratorV08toV09 : IGameOptionsMigrator // TypeDefIndex: 2446
{
	// Fields
	private readonly ILogger logger; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7E59F0 Offset: 0x7E4BF0 VA: 0x1807E59F0 Slot: 4
	public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E5020 Offset: 0x7E4220 VA: 0x1807E5020
	private bool TryMigrateNormal(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E4D80 Offset: 0x7E3F80 VA: 0x1807E4D80
	private bool TryMigrateHideAndSeek(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E4C60 Offset: 0x7E3E60 VA: 0x1807E4C60
	private void CopyFloat(IGameOptions newVersion, IGameOptions oldVersion, FloatOptionNames option) { }

	// RVA: 0x7E4BD0 Offset: 0x7E3DD0 VA: 0x1807E4BD0
	private void CopyBool(IGameOptions newVersion, IGameOptions oldVersion, BoolOptionNames option) { }

	// RVA: 0x7E4CF0 Offset: 0x7E3EF0 VA: 0x1807E4CF0
	private void CopyInt32(IGameOptions newVersion, IGameOptions oldVersion, Int32OptionNames option) { }
}

// Namespace: AmongUs.GameOptions
public class GuardianAngelRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2447
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float GuardianAngelCooldown; // 0x14
	public float ProtectionDurationSeconds; // 0x18
	public bool ImpostorsCanSeeProtect; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D4FC0 Offset: 0x7D41C0 VA: 0x1807D4FC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D4F50 Offset: 0x7D4150 VA: 0x1807D4F50 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D5040 Offset: 0x7D4240 VA: 0x1807D5040 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D5060 Offset: 0x7D4260 VA: 0x1807D5060
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class HideNSeekGameOptionsV09 : IGameOptions // TypeDefIndex: 2448
{
	// Fields
	public static readonly float[] KillDistances; // 0x0
	private static readonly int[] MaxImpostors; // 0x8
	private static readonly int[] MinPlayers; // 0x10
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public int ImpostorPlayerID; // 0x20
	public float PlayerSpeedMod; // 0x24
	public float CrewLightMod; // 0x28
	public float ImpostorLightMod; // 0x2C
	public float KillCooldown; // 0x30
	public int NumCommonTasks; // 0x34
	public int NumLongTasks; // 0x38
	public int NumShortTasks; // 0x3C
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x40
	public bool GhostsDoTasks; // 0x44
	public int KillDistance; // 0x48
	public int Tag; // 0x4C
	public const float ImpostorSpeedDifference = 0,25;
	public int CrewmateVentUses; // 0x50
	public float CrewmateTimeInVent; // 0x54
	public float EscapeTime; // 0x58
	public float FinalCountdownTime; // 0x5C
	public float CrewmateFlashlightSize; // 0x60
	public float ImpostorFlashlightSize; // 0x64
	public bool useFlashlight; // 0x68
	public bool SeekerFinalMap; // 0x69
	public float SeekerFinalSpeed; // 0x6C
	public bool ShowCrewmateNames; // 0x70
	public float MaxPingTime; // 0x74
	public bool SeekerPings; // 0x78
	public const int CrewmateLeadTime = 10;
	public const float ScaryMusicDistance = 55;
	public const float VeryScaryMusicDistance = 15;
	public const float CrewmateVentCooldown = 1;
	public const float ShowPingTime = 2;
	private readonly ILogger logger; // 0x80
	private RoleOptionsCollectionV09 roleOptions; // 0x88

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7E4930 Offset: 0x7E3B30 VA: 0x1807E4930 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7D6680 Offset: 0x7D5880 VA: 0x1807D6680 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x7D6670 Offset: 0x7D5870 VA: 0x1807D6670 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_NumImpostors(int value) { }

	// RVA: 0x7D6690 Offset: 0x7D5890 VA: 0x1807D6690 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7E84C0 Offset: 0x7E76C0 VA: 0x1807E84C0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7E7490 Offset: 0x7E6690 VA: 0x1807E7490
	public static void Serialize(MessageWriter writer, HideNSeekGameOptionsV09 gameOptions) { }

	// RVA: 0x7E6F20 Offset: 0x7E6120 VA: 0x1807E6F20
	public static HideNSeekGameOptionsV09 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D5080 Offset: 0x7D4280 VA: 0x1807D5080 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7E7EA0 Offset: 0x7E70A0 VA: 0x1807E7EA0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7E7DD0 Offset: 0x7E6FD0 VA: 0x1807E7DD0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7E7800 Offset: 0x7E6A00 VA: 0x1807E7800 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7E7930 Offset: 0x7E6B30 VA: 0x1807E7930 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7E7650 Offset: 0x7E6850 VA: 0x1807E7650 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7E7BA0 Offset: 0x7E6DA0 VA: 0x1807E7BA0 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7E7F20 Offset: 0x7E7120 VA: 0x1807E7F20 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7E72C0 Offset: 0x7E64C0 VA: 0x1807E72C0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7E71F0 Offset: 0x7E63F0 VA: 0x1807E71F0 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7E7410 Offset: 0x7E6610 VA: 0x1807E7410 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7E7370 Offset: 0x7E6570 VA: 0x1807E7370 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7E7260 Offset: 0x7E6460 VA: 0x1807E7260 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7E8160 Offset: 0x7E7360 VA: 0x1807E8160 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7E8050 Offset: 0x7E7250 VA: 0x1807E8050 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7E8300 Offset: 0x7E7500 VA: 0x1807E8300 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7E8240 Offset: 0x7E7440 VA: 0x1807E8240 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7E80E0 Offset: 0x7E72E0 VA: 0x1807E80E0 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7D60A0 Offset: 0x7D52A0 VA: 0x1807D60A0 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7E83B0 Offset: 0x7E75B0 VA: 0x1807E83B0
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class NoisemakerRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2449
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool NoisemakerImpostorAlert; // 0x12
	public float NoisemakerAlertDuration; // 0x14

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7DB050 Offset: 0x7DA250 VA: 0x1807DB050 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7DB000 Offset: 0x7DA200 VA: 0x1807DB000 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7DB0A0 Offset: 0x7DA2A0 VA: 0x1807DB0A0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7DB0B0 Offset: 0x7DA2B0 VA: 0x1807DB0B0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class NormalGameOptionsV09 : IGameOptions // TypeDefIndex: 2450
{
	// Fields
	private static readonly int[] RecommendedKillCooldown; // 0x0
	private static readonly int[] RecommendedImpostors; // 0x8
	private static readonly int[] MaxImpostors; // 0x10
	private static readonly float[] KillDistances; // 0x18
	private static readonly string[] KillDistanceStrings; // 0x20
	private static readonly int[] MinPlayers; // 0x28
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public float PlayerSpeedMod; // 0x20
	public float CrewLightMod; // 0x24
	public float ImpostorLightMod; // 0x28
	public float KillCooldown; // 0x2C
	public int NumCommonTasks; // 0x30
	public int NumLongTasks; // 0x34
	public int NumShortTasks; // 0x38
	public int NumEmergencyMeetings; // 0x3C
	public int EmergencyCooldown; // 0x40
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x44
	public bool GhostsDoTasks; // 0x48
	public int KillDistance; // 0x4C
	public int DiscussionTime; // 0x50
	public int VotingTime; // 0x54
	public bool ConfirmImpostor; // 0x58
	public bool VisualTasks; // 0x59
	public bool AnonymousVotes; // 0x5A
	public TaskBarMode TaskBarMode; // 0x5C
	public int Tag; // 0x60
	private readonly ILogger logger; // 0x68
	private RoleOptionsCollectionV09 roleOptions; // 0x70

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7E4930 Offset: 0x7E3B30 VA: 0x1807E4930 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7DA320 Offset: 0x7D9520 VA: 0x1807DA320 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_NumImpostors(int value) { }

	// RVA: 0x7DA330 Offset: 0x7D9530 VA: 0x1807DA330 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7EC650 Offset: 0x7EB850 VA: 0x1807EC650
	public void .ctor(ILogger logger) { }

	// RVA: 0x7E9D00 Offset: 0x7E8F00 VA: 0x1807E9D00
	public static void Serialize(MessageWriter writer, NormalGameOptionsV09 gameOptions) { }

	// RVA: 0x7E9670 Offset: 0x7E8870 VA: 0x1807E9670
	public static NormalGameOptionsV09 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D7A40 Offset: 0x7D6C40 VA: 0x1807D7A40 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7EB3C0 Offset: 0x7EA5C0 VA: 0x1807EB3C0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7EB3E0 Offset: 0x7EA5E0 VA: 0x1807EB3E0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7EA2E0 Offset: 0x7E94E0 VA: 0x1807EA2E0 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7EA410 Offset: 0x7E9610 VA: 0x1807EA410 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7E9EB0 Offset: 0x7E90B0 VA: 0x1807E9EB0 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7EB150 Offset: 0x7EA350 VA: 0x1807EB150 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7EB7E0 Offset: 0x7EA9E0 VA: 0x1807EB7E0 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7E9BA0 Offset: 0x7E8DA0 VA: 0x1807E9BA0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7E9B00 Offset: 0x7E8D00 VA: 0x1807E9B00 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7E9C70 Offset: 0x7E8E70 VA: 0x1807E9C70 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7E9BD0 Offset: 0x7E8DD0 VA: 0x1807E9BD0 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7E9B30 Offset: 0x7E8D30 VA: 0x1807E9B30 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7EBBF0 Offset: 0x7EADF0 VA: 0x1807EBBF0 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7EB910 Offset: 0x7EAB10 VA: 0x1807EB910 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7EC330 Offset: 0x7EB530 VA: 0x1807EC330 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7EC270 Offset: 0x7EB470 VA: 0x1807EC270 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7EBB70 Offset: 0x7EAD70 VA: 0x1807EBB70 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7DCB60 Offset: 0x7DBD60 VA: 0x1807DCB60 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7EC410 Offset: 0x7EB610 VA: 0x1807EC410
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class PhantomRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2451
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float PhantomCooldown; // 0x14
	public float PhantomDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F0470 Offset: 0x7EF670 VA: 0x1807F0470 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F0480 Offset: 0x7EF680 VA: 0x1807F0480
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class RoleDataV09 // TypeDefIndex: 2452
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IRoleOptions <RoleOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private RoleRate <Rate>k__BackingField; // 0x20

	// Properties
	public RoleTypes Type { get; }
	public IRoleOptions RoleOptions { get; }
	public RoleRate Rate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	public RoleTypes get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IRoleOptions get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RoleRate get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Rate(RoleRate value) { }

	// RVA: 0x7F34E0 Offset: 0x7F26E0 VA: 0x1807F34E0
	public void .ctor(IRoleOptions roleOptions, RoleRate rate) { }

	// RVA: 0x7F3560 Offset: 0x7F2760 VA: 0x1807F3560
	public void .ctor(RoleTypes type) { }
}

// Namespace: AmongUs.GameOptions
public class RoleOptionsCollectionV09 : IRoleOptionsCollection // TypeDefIndex: 2453
{
	// Fields
	private readonly Dictionary<RoleTypes, RoleDataV09> roles; // 0x10

	// Methods

	// RVA: 0x7F4690 Offset: 0x7F3890 VA: 0x1807F4690
	public static RoleOptionsCollectionV09 Deserialize(MessageReader reader) { }

	// RVA: 0x7F49C0 Offset: 0x7F3BC0 VA: 0x1807F49C0
	public static void Serialize(MessageWriter writer, RoleOptionsCollectionV09 options) { }

	// RVA: 0x7F48D0 Offset: 0x7F3AD0 VA: 0x1807F48D0 Slot: 4
	public int GetNumPerGame(RoleTypes role) { }

	// RVA: 0x7F4840 Offset: 0x7F3A40 VA: 0x1807F4840 Slot: 5
	public int GetChancePerGame(RoleTypes role) { }

	// RVA: 0x7F4BC0 Offset: 0x7F3DC0 VA: 0x1807F4BC0 Slot: 6
	public void SetRoleRate(RoleTypes role, int maxCount, int chance) { }

	// RVA: 0x7F4C90 Offset: 0x7F3E90 VA: 0x1807F4C90 Slot: 7
	public void SetRoleRecommended(RoleTypes role) { }

	// RVA: -1 Offset: -1
	public bool TryGetRoleOptions<T>(RoleTypes type, out T roleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69AD0 Offset: 0xA68CD0 VA: 0x180A69AD0
	|-RoleOptionsCollectionV09.TryGetRoleOptions<object>
	*/

	// RVA: 0x7F4D60 Offset: 0x7F3F60 VA: 0x1807F4D60
	public bool TryGetRoleRates(RoleTypes type, out RoleRate roleRates) { }

	// RVA: 0x7F44E0 Offset: 0x7F36E0 VA: 0x1807F44E0
	public bool AnyRolesEnabled() { }

	// RVA: 0x7F4440 Offset: 0x7F3640 VA: 0x1807F4440
	public void AddOrUpdateRole(RoleDataV09 role) { }

	// RVA: 0x7F4E00 Offset: 0x7F4000 VA: 0x1807F4E00
	public void UpdateFrom(RoleOptionsCollectionV09 roleOptionsCollectionV09) { }

	// RVA: 0x7F4960 Offset: 0x7F3B60 VA: 0x1807F4960
	public void RemoveRole(RoleTypes roleType) { }

	// RVA: 0x7F4FD0 Offset: 0x7F41D0 VA: 0x1807F4FD0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ScientistRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2454
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float ScientistCooldown; // 0x14
	public float ScientistBatteryCharge; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E14B0 Offset: 0x7E06B0 VA: 0x1807E14B0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E14C0 Offset: 0x7E06C0 VA: 0x1807E14C0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ShapeshifterRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2455
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool ShapeshifterLeaveSkin; // 0x12
	public float ShapeshifterCooldown; // 0x14
	public float ShapeshifterDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E1550 Offset: 0x7E0750 VA: 0x1807E1550 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E14E0 Offset: 0x7E06E0 VA: 0x1807E14E0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E15D0 Offset: 0x7E07D0 VA: 0x1807E15D0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E15F0 Offset: 0x7E07F0 VA: 0x1807E15F0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class TrackerRoleOptionsV09 : IRoleOptions // TypeDefIndex: 2456
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float TrackerCooldown; // 0x14
	public float TrackerDuration; // 0x18
	public float TrackerDelay; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7F5CC0 Offset: 0x7F4EC0 VA: 0x1807F5CC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7F5C40 Offset: 0x7F4E40 VA: 0x1807F5C40 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F5D40 Offset: 0x7F4F40 VA: 0x1807F5D40 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F5D60 Offset: 0x7F4F60 VA: 0x1807F5D60
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class DetectiveRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2457
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float DetectiveSuspectLimit; // 0x14

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E4650 Offset: 0x7E3850 VA: 0x1807E4650 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E4610 Offset: 0x7E3810 VA: 0x1807E4610 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E4680 Offset: 0x7E3880 VA: 0x1807E4680 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E4690 Offset: 0x7E3890 VA: 0x1807E4690
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class EngineerRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2458
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float EngineerCooldown; // 0x14
	public float EngineerInVentMaxTime; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D1890 Offset: 0x7D0A90 VA: 0x1807D1890 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D18A0 Offset: 0x7D0AA0 VA: 0x1807D18A0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsDefinitionV10 : GameOptionsDefinition // TypeDefIndex: 2459
{
	// Properties
	public override byte Version { get; }

	// Methods

	// RVA: 0x7E4BC0 Offset: 0x7E3DC0 VA: 0x1807E4BC0 Slot: 4
	public override byte get_Version() { }

	// RVA: 0x7E4940 Offset: 0x7E3B40 VA: 0x1807E4940 Slot: 5
	public override IGameOptionsMigrator GetMigrator(ILogger logger) { }

	// RVA: 0x7E4B20 Offset: 0x7E3D20 VA: 0x1807E4B20 Slot: 6
	public override void NormalModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7E4AB0 Offset: 0x7E3CB0 VA: 0x1807E4AB0 Slot: 7
	public override IGameOptions NormalModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7E4A10 Offset: 0x7E3C10 VA: 0x1807E4A10 Slot: 8
	public override void HideAndSeekModeSerialize(MessageWriter writer, IGameOptions optionsData) { }

	// RVA: 0x7E49A0 Offset: 0x7E3BA0 VA: 0x1807E49A0 Slot: 9
	public override IGameOptions HideAndSeekModeDeserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class GameOptionsMigratorV09toV10 : IGameOptionsMigrator // TypeDefIndex: 2460
{
	// Fields
	private readonly ILogger logger; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ILogger logger) { }

	// RVA: 0x7E6D90 Offset: 0x7E5F90 VA: 0x1807E6D90 Slot: 4
	public bool TryMigrate(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E5FD0 Offset: 0x7E51D0 VA: 0x1807E5FD0
	private bool TryMigrateNormal(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E5D30 Offset: 0x7E4F30 VA: 0x1807E5D30
	private bool TryMigrateHideAndSeek(IGameOptions previousVersion, out IGameOptions updatedVersion) { }

	// RVA: 0x7E5C10 Offset: 0x7E4E10 VA: 0x1807E5C10
	private void CopyFloat(IGameOptions newVersion, IGameOptions oldVersion, FloatOptionNames option) { }

	// RVA: 0x7E5B80 Offset: 0x7E4D80 VA: 0x1807E5B80
	private void CopyBool(IGameOptions newVersion, IGameOptions oldVersion, BoolOptionNames option) { }

	// RVA: 0x7E5CA0 Offset: 0x7E4EA0 VA: 0x1807E5CA0
	private void CopyInt32(IGameOptions newVersion, IGameOptions oldVersion, Int32OptionNames option) { }
}

// Namespace: AmongUs.GameOptions
public class GuardianAngelRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2461
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float GuardianAngelCooldown; // 0x14
	public float ProtectionDurationSeconds; // 0x18
	public bool ImpostorsCanSeeProtect; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D4FC0 Offset: 0x7D41C0 VA: 0x1807D4FC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D4F50 Offset: 0x7D4150 VA: 0x1807D4F50 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7D5040 Offset: 0x7D4240 VA: 0x1807D5040 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7D5060 Offset: 0x7D4260 VA: 0x1807D5060
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class HideNSeekGameOptionsV10 : IGameOptions // TypeDefIndex: 2462
{
	// Fields
	public static readonly float[] KillDistances; // 0x0
	private static readonly int[] MaxImpostors; // 0x8
	private static readonly int[] MinPlayers; // 0x10
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public int ImpostorPlayerID; // 0x20
	public float PlayerSpeedMod; // 0x24
	public float CrewLightMod; // 0x28
	public float ImpostorLightMod; // 0x2C
	public float KillCooldown; // 0x30
	public int NumCommonTasks; // 0x34
	public int NumLongTasks; // 0x38
	public int NumShortTasks; // 0x3C
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x40
	public bool GhostsDoTasks; // 0x44
	public int KillDistance; // 0x48
	public int Tag; // 0x4C
	public const float ImpostorSpeedDifference = 0,25;
	public int CrewmateVentUses; // 0x50
	public float CrewmateTimeInVent; // 0x54
	public float EscapeTime; // 0x58
	public float FinalCountdownTime; // 0x5C
	public float CrewmateFlashlightSize; // 0x60
	public float ImpostorFlashlightSize; // 0x64
	public bool useFlashlight; // 0x68
	public bool SeekerFinalMap; // 0x69
	public float SeekerFinalSpeed; // 0x6C
	public bool ShowCrewmateNames; // 0x70
	public float MaxPingTime; // 0x74
	public bool SeekerPings; // 0x78
	public const int CrewmateLeadTime = 10;
	public const float ScaryMusicDistance = 55;
	public const float VeryScaryMusicDistance = 15;
	public const float CrewmateVentCooldown = 1;
	public const float ShowPingTime = 2;
	private readonly ILogger logger; // 0x80
	private RoleOptionsCollectionV10 roleOptions; // 0x88

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7E4BC0 Offset: 0x7E3DC0 VA: 0x1807E4BC0 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7D6680 Offset: 0x7D5880 VA: 0x1807D6680 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x7D6670 Offset: 0x7D5870 VA: 0x1807D6670 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void set_NumImpostors(int value) { }

	// RVA: 0x7D6690 Offset: 0x7D5890 VA: 0x1807D6690 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7E9500 Offset: 0x7E8700 VA: 0x1807E9500
	public void .ctor(ILogger logger) { }

	// RVA: 0x7E7490 Offset: 0x7E6690 VA: 0x1807E7490
	public static void Serialize(MessageWriter writer, HideNSeekGameOptionsV10 gameOptions) { }

	// RVA: 0x7E8630 Offset: 0x7E7830 VA: 0x1807E8630
	public static HideNSeekGameOptionsV10 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D5080 Offset: 0x7D4280 VA: 0x1807D5080 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7E7EA0 Offset: 0x7E70A0 VA: 0x1807E7EA0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7E7DD0 Offset: 0x7E6FD0 VA: 0x1807E7DD0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7E8BB0 Offset: 0x7E7DB0 VA: 0x1807E8BB0 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7E8CE0 Offset: 0x7E7EE0 VA: 0x1807E8CE0 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7E8A00 Offset: 0x7E7C00 VA: 0x1807E8A00 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7E8F50 Offset: 0x7E8150 VA: 0x1807E8F50 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7E9180 Offset: 0x7E8380 VA: 0x1807E9180 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7E72C0 Offset: 0x7E64C0 VA: 0x1807E72C0 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7E71F0 Offset: 0x7E63F0 VA: 0x1807E71F0 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7E7410 Offset: 0x7E6610 VA: 0x1807E7410 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7E8960 Offset: 0x7E7B60 VA: 0x1807E8960 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7E8900 Offset: 0x7E7B00 VA: 0x1807E8900 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7E8160 Offset: 0x7E7360 VA: 0x1807E8160 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7E8050 Offset: 0x7E7250 VA: 0x1807E8050 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7E8300 Offset: 0x7E7500 VA: 0x1807E8300 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7E9330 Offset: 0x7E8530 VA: 0x1807E9330 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7E92B0 Offset: 0x7E84B0 VA: 0x1807E92B0 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7D60A0 Offset: 0x7D52A0 VA: 0x1807D60A0 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7E93F0 Offset: 0x7E85F0 VA: 0x1807E93F0
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class NoisemakerRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2463
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool NoisemakerImpostorAlert; // 0x12
	public float NoisemakerAlertDuration; // 0x14

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7DB050 Offset: 0x7DA250 VA: 0x1807DB050 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7DB000 Offset: 0x7DA200 VA: 0x1807DB000 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7DB0A0 Offset: 0x7DA2A0 VA: 0x1807DB0A0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7DB0B0 Offset: 0x7DA2B0 VA: 0x1807DB0B0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class NormalGameOptionsV10 : IGameOptions // TypeDefIndex: 2464
{
	// Fields
	private static readonly int[] RecommendedKillCooldown; // 0x0
	private static readonly int[] RecommendedImpostors; // 0x8
	private static readonly int[] MaxImpostors; // 0x10
	private static readonly float[] KillDistances; // 0x18
	private static readonly string[] KillDistanceStrings; // 0x20
	private static readonly int[] MinPlayers; // 0x28
	[CompilerGenerated]
	private GameModes <GameMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private SpecialGameModes <SpecialMode>k__BackingField; // 0x11
	[CompilerGenerated]
	private RulesPresets <RulesPreset>k__BackingField; // 0x12
	[CompilerGenerated]
	private int <MaxPlayers>k__BackingField; // 0x14
	[CompilerGenerated]
	private GameKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <MapId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDefaults>k__BackingField; // 0x1D
	public float PlayerSpeedMod; // 0x20
	public float CrewLightMod; // 0x24
	public float ImpostorLightMod; // 0x28
	public float KillCooldown; // 0x2C
	public int NumCommonTasks; // 0x30
	public int NumLongTasks; // 0x34
	public int NumShortTasks; // 0x38
	public int NumEmergencyMeetings; // 0x3C
	public int EmergencyCooldown; // 0x40
	[CompilerGenerated]
	private int <NumImpostors>k__BackingField; // 0x44
	public bool GhostsDoTasks; // 0x48
	public int KillDistance; // 0x4C
	public int DiscussionTime; // 0x50
	public int VotingTime; // 0x54
	public bool ConfirmImpostor; // 0x58
	public bool VisualTasks; // 0x59
	public bool AnonymousVotes; // 0x5A
	public TaskBarMode TaskBarMode; // 0x5C
	public int Tag; // 0x60
	private readonly ILogger logger; // 0x68
	private RoleOptionsCollectionV10 roleOptions; // 0x70

	// Properties
	public byte Version { get; }
	public GameModes GameMode { get; set; }
	public SpecialGameModes SpecialMode { get; set; }
	public GameModes AprilFoolsOnMode { get; }
	public GameModes AprilFoolsOffMode { get; }
	public RulesPresets RulesPreset { get; set; }
	public int MaxPlayers { get; set; }
	public GameKeywords Keywords { get; set; }
	public byte MapId { get; set; }
	public bool IsDefaults { get; set; }
	public IRoleOptionsCollection RoleOptions { get; }
	public int NumImpostors { get; set; }
	public int TotalTaskCount { get; }

	// Methods

	// RVA: 0x7E4BC0 Offset: 0x7E3DC0 VA: 0x1807E4BC0 Slot: 4
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public GameModes get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_GameMode(GameModes value) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0 Slot: 6
	public SpecialGameModes get_SpecialMode() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_SpecialMode(SpecialGameModes value) { }

	// RVA: 0x7DA320 Offset: 0x7D9520 VA: 0x1807DA320 Slot: 7
	public GameModes get_AprilFoolsOnMode() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public GameModes get_AprilFoolsOffMode() { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10 Slot: 9
	public RulesPresets get_RulesPreset() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_RulesPreset(RulesPresets value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public int get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MaxPlayers(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 11
	public GameKeywords get_Keywords() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Keywords(GameKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930 Slot: 12
	public byte get_MapId() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_MapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0 Slot: 15
	public bool get_IsDefaults() { }

	[CompilerGenerated]
	// RVA: 0x7D66A0 Offset: 0x7D58A0 VA: 0x1807D66A0
	public void set_IsDefaults(bool value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 16
	public IRoleOptionsCollection get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0 Slot: 13
	public int get_NumImpostors() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_NumImpostors(int value) { }

	// RVA: 0x7DA330 Offset: 0x7D9530 VA: 0x1807DA330 Slot: 14
	public int get_TotalTaskCount() { }

	// RVA: 0x7EFD10 Offset: 0x7EEF10 VA: 0x1807EFD10
	public void .ctor(ILogger logger) { }

	// RVA: 0x7ED250 Offset: 0x7EC450 VA: 0x1807ED250
	public static void Serialize(MessageWriter writer, NormalGameOptionsV10 gameOptions) { }

	// RVA: 0x7ECC50 Offset: 0x7EBE50 VA: 0x1807ECC50
	public static NormalGameOptionsV10 Deserialize(MessageReader reader, bool isAprilFoolsMode, ILogger logger) { }

	// RVA: 0x7D7A40 Offset: 0x7D6C40 VA: 0x1807D7A40 Slot: 17
	public bool AreInvalid(int maxExpectedPlayers) { }

	// RVA: 0x7EEEB0 Offset: 0x7EE0B0 VA: 0x1807EEEB0 Slot: 18
	public void SetRecommendations(int numPlayers, bool isOnline) { }

	// RVA: 0x7EEAC0 Offset: 0x7EDCC0 VA: 0x1807EEAC0 Slot: 19
	public void SetRecommendations(int numPlayers, bool isOnline, RulesPresets rulesPresets) { }

	// RVA: 0x7ED830 Offset: 0x7ECA30 VA: 0x1807ED830 Slot: 20
	public void SetByte(ByteOptionNames optionName, byte value) { }

	// RVA: 0x7ED960 Offset: 0x7ECB60 VA: 0x1807ED960 Slot: 21
	public void SetFloat(FloatOptionNames optionName, float value) { }

	// RVA: 0x7ED400 Offset: 0x7EC600 VA: 0x1807ED400 Slot: 22
	public void SetBool(BoolOptionNames optionName, bool value) { }

	// RVA: 0x7EE850 Offset: 0x7EDA50 VA: 0x1807EE850 Slot: 23
	public void SetInt(Int32OptionNames optionName, int value) { }

	// RVA: 0x7EEED0 Offset: 0x7EE0D0 VA: 0x1807EEED0 Slot: 24
	public void SetUInt(UInt32OptionNames optionName, uint value) { }

	// RVA: 0x7D5430 Offset: 0x7D4630 VA: 0x1807D5430 Slot: 26
	public byte GetByte(ByteOptionNames optionName) { }

	// RVA: 0x7ED180 Offset: 0x7EC380 VA: 0x1807ED180 Slot: 27
	public float GetFloat(FloatOptionNames optionName) { }

	// RVA: 0x7ED0E0 Offset: 0x7EC2E0 VA: 0x1807ED0E0 Slot: 28
	public bool GetBool(BoolOptionNames optionName) { }

	// RVA: 0x7E9C70 Offset: 0x7E8E70 VA: 0x1807E9C70 Slot: 29
	public int GetInt(Int32OptionNames optionName) { }

	// RVA: 0x7ED1B0 Offset: 0x7EC3B0 VA: 0x1807ED1B0 Slot: 30
	public int[] GetIntArray(Int32ArrayOptionNames optionName) { }

	// RVA: 0x7ED110 Offset: 0x7EC310 VA: 0x1807ED110 Slot: 31
	public float[] GetFloatArray(FloatArrayOptionNames optionName) { }

	// RVA: 0x7D6140 Offset: 0x7D5340 VA: 0x1807D6140 Slot: 32
	public bool TryGetByte(ByteOptionNames optionName, out byte value) { }

	// RVA: 0x7EF2E0 Offset: 0x7EE4E0 VA: 0x1807EF2E0 Slot: 33
	public bool TryGetFloat(FloatOptionNames optionName, out float value) { }

	// RVA: 0x7EF000 Offset: 0x7EE200 VA: 0x1807EF000 Slot: 34
	public bool TryGetBool(BoolOptionNames optionName, out bool value) { }

	// RVA: 0x7EC330 Offset: 0x7EB530 VA: 0x1807EC330 Slot: 35
	public bool TryGetInt(Int32OptionNames optionName, out int value) { }

	// RVA: 0x7EFA10 Offset: 0x7EEC10 VA: 0x1807EFA10 Slot: 36
	public bool TryGetIntArray(Int32ArrayOptionNames optionName, out int[] value) { }

	// RVA: 0x7EF260 Offset: 0x7EE460 VA: 0x1807EF260 Slot: 37
	public bool TryGetFloatArray(FloatArrayOptionNames optionName, out float[] value) { }

	// RVA: 0x7DCB60 Offset: 0x7DBD60 VA: 0x1807DCB60 Slot: 25
	public bool TryClearAprilFoolsMode() { }

	// RVA: 0x7EFAD0 Offset: 0x7EECD0 VA: 0x1807EFAD0
	private static void .cctor() { }
}

// Namespace: AmongUs.GameOptions
public class PhantomRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2465
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float PhantomCooldown; // 0x14
	public float PhantomDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F0470 Offset: 0x7EF670 VA: 0x1807F0470 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F0480 Offset: 0x7EF680 VA: 0x1807F0480
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class RoleDataV10 // TypeDefIndex: 2466
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IRoleOptions <RoleOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private RoleRate <Rate>k__BackingField; // 0x20

	// Properties
	public RoleTypes Type { get; }
	public IRoleOptions RoleOptions { get; }
	public RoleRate Rate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020
	public RoleTypes get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IRoleOptions get_RoleOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public RoleRate get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Rate(RoleRate value) { }

	// RVA: 0x7F3730 Offset: 0x7F2930 VA: 0x1807F3730
	public void .ctor(IRoleOptions roleOptions, RoleRate rate) { }

	// RVA: 0x7F37B0 Offset: 0x7F29B0 VA: 0x1807F37B0
	public void .ctor(RoleTypes type) { }
}

// Namespace: AmongUs.GameOptions
public class RoleOptionsCollectionV10 : IRoleOptionsCollection // TypeDefIndex: 2467
{
	// Fields
	private readonly Dictionary<RoleTypes, RoleDataV10> roles; // 0x10

	// Methods

	// RVA: 0x7F5290 Offset: 0x7F4490 VA: 0x1807F5290
	public static RoleOptionsCollectionV10 Deserialize(MessageReader reader) { }

	// RVA: 0x7F55C0 Offset: 0x7F47C0 VA: 0x1807F55C0
	public static void Serialize(MessageWriter writer, RoleOptionsCollectionV10 options) { }

	// RVA: 0x7F54D0 Offset: 0x7F46D0 VA: 0x1807F54D0 Slot: 4
	public int GetNumPerGame(RoleTypes role) { }

	// RVA: 0x7F5440 Offset: 0x7F4640 VA: 0x1807F5440 Slot: 5
	public int GetChancePerGame(RoleTypes role) { }

	// RVA: 0x7F57C0 Offset: 0x7F49C0 VA: 0x1807F57C0 Slot: 6
	public void SetRoleRate(RoleTypes role, int maxCount, int chance) { }

	// RVA: 0x7F5890 Offset: 0x7F4A90 VA: 0x1807F5890 Slot: 7
	public void SetRoleRecommended(RoleTypes role) { }

	// RVA: -1 Offset: -1
	public bool TryGetRoleOptions<T>(RoleTypes type, out T roleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69C60 Offset: 0xA68E60 VA: 0x180A69C60
	|-RoleOptionsCollectionV10.TryGetRoleOptions<object>
	*/

	// RVA: 0x7F5960 Offset: 0x7F4B60 VA: 0x1807F5960
	public bool TryGetRoleRates(RoleTypes type, out RoleRate roleRates) { }

	// RVA: 0x7F50E0 Offset: 0x7F42E0 VA: 0x1807F50E0
	public bool AnyRolesEnabled() { }

	// RVA: 0x7F5040 Offset: 0x7F4240 VA: 0x1807F5040
	public void AddOrUpdateRole(RoleDataV10 role) { }

	// RVA: 0x7F5A00 Offset: 0x7F4C00 VA: 0x1807F5A00
	public void UpdateFrom(RoleOptionsCollectionV10 roleOptionsCollectionV10) { }

	// RVA: 0x7F5560 Offset: 0x7F4760 VA: 0x1807F5560
	public void RemoveRole(RoleTypes roleType) { }

	// RVA: 0x7F5BD0 Offset: 0x7F4DD0 VA: 0x1807F5BD0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ScientistRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2468
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float ScientistCooldown; // 0x14
	public float ScientistBatteryCharge; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7D1820 Offset: 0x7D0A20 VA: 0x1807D1820 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7D17C0 Offset: 0x7D09C0 VA: 0x1807D17C0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E14B0 Offset: 0x7E06B0 VA: 0x1807E14B0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E14C0 Offset: 0x7E06C0 VA: 0x1807E14C0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ShapeshifterRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2469
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public bool ShapeshifterLeaveSkin; // 0x12
	public float ShapeshifterCooldown; // 0x14
	public float ShapeshifterDuration; // 0x18

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E1550 Offset: 0x7E0750 VA: 0x1807E1550 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E14E0 Offset: 0x7E06E0 VA: 0x1807E14E0 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7E15D0 Offset: 0x7E07D0 VA: 0x1807E15D0 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7E15F0 Offset: 0x7E07F0 VA: 0x1807E15F0
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class TrackerRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2470
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float TrackerCooldown; // 0x14
	public float TrackerDuration; // 0x18
	public float TrackerDelay; // 0x1C

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7F5CC0 Offset: 0x7F4EC0 VA: 0x1807F5CC0 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7F5C40 Offset: 0x7F4E40 VA: 0x1807F5C40 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F5D40 Offset: 0x7F4F40 VA: 0x1807F5D40 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F5D60 Offset: 0x7F4F60 VA: 0x1807F5D60
	public void .ctor() { }
}

// Namespace: AmongUs.GameOptions
public class ViperRoleOptionsV10 : IRoleOptions // TypeDefIndex: 2471
{
	// Fields
	[CompilerGenerated]
	private readonly RoleTypes <Type>k__BackingField; // 0x10
	public float viperDissolveTime; // 0x14

	// Properties
	public RoleTypes Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9020 Offset: 0x3D8220 VA: 0x1803D9020 Slot: 4
	public RoleTypes get_Type() { }

	// RVA: 0x7E4650 Offset: 0x7E3850 VA: 0x1807E4650 Slot: 5
	public void Serialize(MessageWriter writer) { }

	// RVA: 0x7E4610 Offset: 0x7E3810 VA: 0x1807E4610 Slot: 6
	public void Deserialize(MessageReader reader) { }

	// RVA: 0x7F5E10 Offset: 0x7F5010 VA: 0x1807F5E10 Slot: 7
	public void SetRecommended() { }

	// RVA: 0x7F5E20 Offset: 0x7F5020 VA: 0x1807F5E20
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public interface IQuickChatPhraseCollector // TypeDefIndex: 2472
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Collect(QuickChatContext context, List<QuickChatPhrase> output);
}

// Namespace: AmongUs.QuickChat
public class QuickChatCrewPhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2473
{
	// Methods

	// RVA: 0x7F04A0 Offset: 0x7EF6A0 VA: 0x1807F04A0 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatDeadPhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2474
{
	// Methods

	// RVA: 0x7F0610 Offset: 0x7EF810 VA: 0x1807F0610 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatFavoritePhraseCollector.<>c__DisplayClass0_0 // TypeDefIndex: 2475
{
	// Fields
	public QuickChatContext context; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7F5D90 Offset: 0x7F4F90 VA: 0x1807F5D90
	internal bool <Collect>b__0(QuickChatTag x) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatFavoritePhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2476
{
	// Methods

	// RVA: 0x7F0780 Offset: 0x7EF980 VA: 0x1807F0780 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatLocationPhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2477
{
	// Methods

	// RVA: 0x7F0990 Offset: 0x7EFB90 VA: 0x1807F0990 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatRolePhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2478
{
	// Methods

	// RVA: 0x7F2E30 Offset: 0x7F2030 VA: 0x1807F2E30 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatSystemPhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2479
{
	// Methods

	// RVA: 0x7F2FA0 Offset: 0x7F21A0 VA: 0x1807F2FA0 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatTaskPhraseCollector : IQuickChatPhraseCollector // TypeDefIndex: 2480
{
	// Methods

	// RVA: 0x7F3110 Offset: 0x7F2310 VA: 0x1807F3110 Slot: 4
	public void Collect(QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public static class QuickChatNetData // TypeDefIndex: 2481
{
	// Methods

	// RVA: 0x7F13E0 Offset: 0x7F05E0 VA: 0x1807F13E0
	public static void Serialize(QuickChatPhraseBuilderResult data, MessageWriter writer) { }

	// RVA: 0x7F0E90 Offset: 0x7F0090 VA: 0x1807F0E90
	public static QuickChatPhraseBuilderResult Deserialize(MessageReader reader) { }

	// RVA: 0x7F1380 Offset: 0x7F0580 VA: 0x1807F1380
	private static void SerializePlayerID(byte playerID, MessageWriter writer) { }

	// RVA: 0x7F0E50 Offset: 0x7F0050 VA: 0x1807F0E50
	private static byte DeserializePlayerID(MessageReader reader) { }

	// RVA: 0x7F13B0 Offset: 0x7F05B0 VA: 0x1807F13B0
	private static void SerializeSimplePhrase(StringNames phraseKey, MessageWriter writer) { }

	// RVA: 0x7F0E70 Offset: 0x7F0070 VA: 0x1807F0E70
	private static StringNames DeserializeSimplePhrase(MessageReader reader) { }

	// RVA: 0x7F10D0 Offset: 0x7F02D0 VA: 0x1807F10D0
	private static void SerializeComplexPhrase(QuickChatPhraseBuilderResult data, MessageWriter writer) { }

	// RVA: 0x7F0B00 Offset: 0x7EFD00 VA: 0x1807F0B00
	private static QuickChatPhraseBuilderResult DeserializeComplexPhrase(MessageReader reader) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatPhrase.<>c__DisplayClass38_0 // TypeDefIndex: 2482
{
	// Fields
	public bool useColor; // 0x10
	public Func<QuickChatTag, string> <>9__0; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8119D0 Offset: 0x810BD0 VA: 0x1808119D0
	internal string <ToComplexPreviewText>b__0(QuickChatTag x) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatPhrase // TypeDefIndex: 2483
{
	// Fields
	private QuickChatPhraseType type; // 0x10
	private bool isInput; // 0x11
	private bool isNegative; // 0x12
	private byte playerId; // 0x13
	private StringNames phraseKey; // 0x14
	private QuickChatPhraseInput[] phraseInputs; // 0x18

	// Properties
	public bool IsInput { get; }
	public bool IsNegative { get; }
	public QuickChatPhraseType Type { get; }
	public byte PlayerId { get; }
	public StringNames PhraseKey { get; }
	public QuickChatPhraseInput[] PhraseInputs { get; }
	public int ExpectedInputCount { get; }

	// Methods

	// RVA: 0x7F2E10 Offset: 0x7F2010 VA: 0x1807F2E10
	public bool get_IsInput() { }

	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	public bool get_IsNegative() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public QuickChatPhraseType get_Type() { }

	// RVA: 0x7F2E20 Offset: 0x7F2020 VA: 0x1807F2E20
	public byte get_PlayerId() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public StringNames get_PhraseKey() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public QuickChatPhraseInput[] get_PhraseInputs() { }

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450
	public int get_ExpectedInputCount() { }

	// RVA: 0x7F1810 Offset: 0x7F0A10 VA: 0x1807F1810
	public static QuickChatPhrase NewPlayerId(byte playerID) { }

	// RVA: 0x7F1880 Offset: 0x7F0A80 VA: 0x1807F1880
	public static QuickChatPhrase NewSimplePhrase(StringNames localizationKey, bool isInput, bool isNegative) { }

	// RVA: 0x7F1780 Offset: 0x7F0980 VA: 0x1807F1780
	public static QuickChatPhrase NewComplexPhrase(StringNames localizationKey, QuickChatPhraseInput[] inputs, bool isNegative) { }

	// RVA: 0x7F2A50 Offset: 0x7F1C50 VA: 0x1807F2A50
	public string ToPreviewText(QuickChatPhrase[] inputs) { }

	// RVA: 0x7F1910 Offset: 0x7F0B10 VA: 0x1807F1910
	public string ToButtonText() { }

	// RVA: 0x7F1C00 Offset: 0x7F0E00 VA: 0x1807F1C00
	public string ToComplexInputPreviewText() { }

	// RVA: 0x7F2300 Offset: 0x7F1500 VA: 0x1807F2300
	public string ToLogString() { }

	// RVA: 0x7F2960 Offset: 0x7F1B60 VA: 0x1807F2960
	private string ToPlayerNameText(bool boldPlayerName) { }

	// RVA: 0x7F2690 Offset: 0x7F1890 VA: 0x1807F2690
	private string ToPlayerColorText() { }

	// RVA: 0x7F28E0 Offset: 0x7F1AE0 VA: 0x1807F28E0
	private string ToPlayerNamePreviewText() { }

	// RVA: 0x7F2800 Offset: 0x7F1A00 VA: 0x1807F2800
	private string ToPlayerNameButtonText() { }

	// RVA: 0x7F2860 Offset: 0x7F1A60 VA: 0x1807F2860
	private string ToPlayerNameInputPreviewText() { }

	// RVA: 0x7F2760 Offset: 0x7F1960 VA: 0x1807F2760
	public Color ToPlayerColor() { }

	// RVA: 0x7F25F0 Offset: 0x7F17F0 VA: 0x1807F25F0
	public Color ToPlayerBackgroundColor() { }

	// RVA: 0x7F2D90 Offset: 0x7F1F90 VA: 0x1807F2D90
	private string ToSimplePhraseText() { }

	// RVA: 0x7F2D60 Offset: 0x7F1F60 VA: 0x1807F2D60
	private string ToSimplePhrasePreviewText() { }

	// RVA: 0x7F2D60 Offset: 0x7F1F60 VA: 0x1807F2D60
	private string ToSimplePhraseButtonText() { }

	// RVA: 0x7F2D70 Offset: 0x7F1F70 VA: 0x1807F2D70
	private string ToSimplePhraseInputPreviewText() { }

	// RVA: 0x7F1FA0 Offset: 0x7F11A0 VA: 0x1807F1FA0
	private string ToComplexPreviewText(QuickChatPhrase[] inputs, bool useColor) { }

	// RVA: 0x7F16C0 Offset: 0x7F08C0 VA: 0x1807F16C0
	private static string GetConditionallyColoredString(string input, bool useColor, Color color) { }

	// RVA: 0x7F15F0 Offset: 0x7F07F0 VA: 0x1807F15F0
	private static string AddBoldTagsIfSupported(string input) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
[CreateAssetMenu]
public class QuickChatPhraseAsset : ScriptableObject // TypeDefIndex: 2484
{
	// Fields
	[SerializeField]
	[Header("Phrase Properties")]
	private string text; // 0x18
	[SerializeField]
	private StringNames key; // 0x20
	[SerializeField]
	private Sprite icon; // 0x28
	[SerializeField]
	private int order; // 0x30
	[SerializeField]
	[Header("Usage")]
	private bool isInput; // 0x34
	[SerializeField]
	private bool isNegative; // 0x35
	[SerializeField]
	[Space(10)]
	private QuickChatTag[] tags; // 0x38
	[SerializeField]
	private QuickChatPhraseInput[] inputs; // 0x40
	[SerializeField]
	[Header("Inclusion Rules")]
	private QuickChatClassicPhraseRules classicRules; // 0x48
	[SerializeField]
	private QuickChatHideAndSeekPhraseRules hideAndSeekRules; // 0x50
	private QuickChatPhrase cachedPhrase; // 0x58

	// Properties
	public string Text { get; }
	public StringNames Key { get; }
	public Sprite Icon { get; }
	public int Order { get; }
	public bool IsInput { get; }
	public bool IsNegative { get; }
	public QuickChatTag[] Tags { get; }
	public QuickChatPhraseInput[] Inputs { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Text() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public StringNames get_Key() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Sprite get_Icon() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_Order() { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_IsInput() { }

	// RVA: 0x78E670 Offset: 0x78D870 VA: 0x18078E670
	public bool get_IsNegative() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public QuickChatTag[] get_Tags() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public QuickChatPhraseInput[] get_Inputs() { }

	// RVA: 0x8035E0 Offset: 0x8027E0 VA: 0x1808035E0
	public bool EvaluateContext(QuickChatContext context) { }

	// RVA: 0x803890 Offset: 0x802A90 VA: 0x180803890
	public QuickChatPhrase ToPhrase() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatPhraseAssets : ScriptableObject // TypeDefIndex: 2485
{
	// Fields
	[SerializeField]
	private QuickChatPhraseAsset[] phraseAssets; // 0x18

	// Methods

	// RVA: 0x803A80 Offset: 0x802C80 VA: 0x180803A80
	public void GetAssetPhrases(QuickChatTag tag, QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x8039E0 Offset: 0x802BE0 VA: 0x1808039E0
	public QuickChatPhraseAsset GetAssetByName(string name) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatPhraseInput // TypeDefIndex: 2486
{
	// Fields
	[SerializeField]
	private QuickChatTag[] tags; // 0x10

	// Properties
	public QuickChatTag[] Tags { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public QuickChatTag[] get_Tags() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(QuickChatTag[] tags) { }
}

// Namespace: AmongUs.QuickChat
public enum QuickChatPhraseType // TypeDefIndex: 2487
{
	// Fields
	public byte value__; // 0x0
	public const QuickChatPhraseType Empty = 0;
	public const QuickChatPhraseType PlayerId = 1;
	public const QuickChatPhraseType SimplePhrase = 2;
	public const QuickChatPhraseType ComplexPhrase = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QuickChatData.<>c // TypeDefIndex: 2488
{
	// Fields
	public static readonly QuickChatData.<>c <>9; // 0x0
	public static Func<QuickChatPhrase, int> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x811BC0 Offset: 0x810DC0 VA: 0x180811BC0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x811690 Offset: 0x810890 VA: 0x180811690
	internal int <GetPhrases>b__8_0(QuickChatPhrase x) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatData : ScriptableObject // TypeDefIndex: 2489
{
	// Fields
	[SerializeField]
	private QuickChatTagAssets tags; // 0x18
	[SerializeField]
	private QuickChatPhraseAssets phrases; // 0x20
	private Dictionary<QuickChatTag, IQuickChatPhraseCollector> phraseCollectors; // 0x28

	// Properties
	public QuickChatTagAssets Tags { get; }
	public QuickChatPhraseAssets Phrases { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public QuickChatTagAssets get_Tags() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public QuickChatPhraseAssets get_Phrases() { }

	// RVA: 0x7FA780 Offset: 0x7F9980 VA: 0x1807FA780
	public QuickChatTag[] GetVisibleTags() { }

	// RVA: 0x7FA5C0 Offset: 0x7F97C0 VA: 0x1807FA5C0
	public QuickChatPhrase[] GetPhrases(QuickChatContext context, QuickChatTag[] tags) { }

	// RVA: 0x7FA9C0 Offset: 0x7F9BC0 VA: 0x1807FA9C0
	private void RegisterCollectorMethods() { }

	// RVA: 0x7FA390 Offset: 0x7F9590 VA: 0x1807FA390
	private void CollectPhrasesFromTag(QuickChatTag tag, QuickChatContext context, List<QuickChatPhrase> output) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
public sealed class QuickChatPhraseBuilder.ChangeHandler : MulticastDelegate // TypeDefIndex: 2490
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(QuickChatPhraseBuilder builder) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(QuickChatPhraseBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatPhraseBuilder // TypeDefIndex: 2491
{
	// Fields
	private QuickChatPhrase rootPhrase; // 0x10
	private List<QuickChatPhrase> subPhrases; // 0x18
	[CompilerGenerated]
	private QuickChatPhraseBuilder.ChangeHandler OnChangedEvent; // 0x20

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x805870 Offset: 0x804A70 VA: 0x180805870
	public bool get_IsEmpty() { }

	[CompilerGenerated]
	// RVA: 0x8057D0 Offset: 0x8049D0 VA: 0x1808057D0
	public void add_OnChangedEvent(QuickChatPhraseBuilder.ChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x805880 Offset: 0x804A80 VA: 0x180805880
	public void remove_OnChangedEvent(QuickChatPhraseBuilder.ChangeHandler value) { }

	// RVA: 0x8057B0 Offset: 0x8049B0 VA: 0x1808057B0
	public void .ctor() { }

	// RVA: 0x805280 Offset: 0x804480 VA: 0x180805280
	public void Reset() { }

	// RVA: 0x805300 Offset: 0x804500 VA: 0x180805300
	public void Start(QuickChatPhrase rootPhrase) { }

	// RVA: 0x804BF0 Offset: 0x803DF0 VA: 0x180804BF0
	public bool CanAddAsNextPhrase(QuickChatPhrase phrase) { }

	// RVA: 0x804720 Offset: 0x803920 VA: 0x180804720
	public void AddNextPhrase(QuickChatPhrase phrase) { }

	// RVA: 0x805730 Offset: 0x804930 VA: 0x180805730
	public void Undo() { }

	// RVA: 0x804CD0 Offset: 0x803ED0 VA: 0x180804CD0
	public QuickChatTag[] GetNextExpectedInput() { }

	// RVA: 0x805050 Offset: 0x804250 VA: 0x180805050
	private void NotifyChange() { }

	// RVA: 0x804D60 Offset: 0x803F60 VA: 0x180804D60
	public bool IsComplete() { }

	// RVA: 0x804CB0 Offset: 0x803EB0 VA: 0x180804CB0
	private bool CheckSimplePhraseComplete() { }

	// RVA: 0x804C50 Offset: 0x803E50 VA: 0x180804C50
	private bool CheckComplexPhraseComplete() { }

	// RVA: 0x804A10 Offset: 0x803C10 VA: 0x180804A10
	public QuickChatPhraseBuilderResult Build() { }

	// RVA: 0x8053B0 Offset: 0x8045B0 VA: 0x1808053B0
	public void ToLogString(StringBuilder output) { }

	// RVA: 0x805610 Offset: 0x804810 VA: 0x180805610
	public QuickChatPhrase[] ToPreviewData() { }
}

// Namespace: 
public class QuickChatPhraseBuilderResult.Phrase // TypeDefIndex: 2492
{
	// Fields
	public readonly QuickChatPhraseType Type; // 0x10
	public readonly StringNames PhraseKey; // 0x14
	public readonly byte PlayerID; // 0x18

	// Methods

	// RVA: 0x7F8E80 Offset: 0x7F8080 VA: 0x1807F8E80
	public void .ctor(QuickChatPhrase phrase) { }

	// RVA: 0x7F8FD0 Offset: 0x7F81D0 VA: 0x1807F8FD0
	public void .ctor(QuickChatPhraseType type, StringNames key, byte playerID) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatPhraseBuilderResult // TypeDefIndex: 2493
{
	// Fields
	public readonly QuickChatPhraseBuilderResult.Phrase RootPhrase; // 0x10
	public readonly QuickChatPhraseBuilderResult.Phrase[] SubPhrases; // 0x18

	// Methods

	// RVA: 0x804670 Offset: 0x803870 VA: 0x180804670
	public void .ctor(QuickChatPhraseType type, StringNames rootPhrase, byte playerID, QuickChatPhrase[] subPhrases) { }

	// RVA: 0x8045B0 Offset: 0x8037B0 VA: 0x1808045B0
	public void .ctor(QuickChatPhrase rootPhrase, QuickChatPhrase[] subPhrases) { }

	// RVA: 0x803DA0 Offset: 0x802FA0 VA: 0x180803DA0
	public bool IsValid() { }

	// RVA: 0x803E00 Offset: 0x803000 VA: 0x180803E00
	public string ToChatText() { }

	// RVA: 0x804240 Offset: 0x803440 VA: 0x180804240
	private static string ToPlayerNameChatText(byte playerID) { }

	// RVA: 0x804530 Offset: 0x803730 VA: 0x180804530
	private static string ToSimpleChatText(StringNames key) { }

	// RVA: 0x803F60 Offset: 0x803160 VA: 0x180803F60
	private string ToComplexChatText() { }

	// RVA: 0x803B90 Offset: 0x802D90 VA: 0x180803B90
	private static QuickChatPhraseBuilderResult.Phrase[] ConvertSubPhrases(QuickChatPhrase[] input) { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public abstract class AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2494
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Evaluate(QuickChatContext context);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatMapRules : AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2495
{
	// Fields
	[SerializeField]
	private MapNames[] maps; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(MapNames[] maps) { }

	// RVA: 0x7FB100 Offset: 0x7FA300 VA: 0x1807FB100 Slot: 4
	public override bool Evaluate(QuickChatContext context) { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatPhaseRules : AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2496
{
	// Fields
	[SerializeField]
	private bool inLobby; // 0x10
	[SerializeField]
	private bool inGame; // 0x11

	// Methods

	// RVA: 0x8035A0 Offset: 0x8027A0 VA: 0x1808035A0
	public void .ctor(bool inLobby, bool inGame) { }

	// RVA: 0x803470 Offset: 0x802670 VA: 0x180803470 Slot: 4
	public override bool Evaluate(QuickChatContext context) { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatRoleRules : AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2497
{
	// Fields
	[SerializeField]
	private RoleTypes[] requiredRoles; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(RoleTypes[] roles) { }

	// RVA: 0x806850 Offset: 0x805A50 VA: 0x180806850 Slot: 4
	public override bool Evaluate(QuickChatContext context) { }
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatClassicPhraseRules : AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2498
{
	// Fields
	[SerializeField]
	private int minDeadCrew; // 0x10
	[SerializeField]
	private int minMeetingCount; // 0x14
	[SerializeField]
	private QuickChatPhaseRules phases; // 0x18
	[SerializeField]
	private QuickChatMapRules maps; // 0x20
	[SerializeField]
	private QuickChatRoleRules roles; // 0x28

	// Methods

	// RVA: 0x7F9140 Offset: 0x7F8340 VA: 0x1807F9140
	public void .ctor(QuickChatPhaseRules phase, QuickChatMapRules map, QuickChatRoleRules roles, int deadCrewCount, int meetingCount) { }

	// RVA: 0x7F9060 Offset: 0x7F8260 VA: 0x1807F9060 Slot: 4
	public override bool Evaluate(QuickChatContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QuickChatContext.<>c // TypeDefIndex: 2499
{
	// Fields
	public static readonly QuickChatContext.<>c <>9; // 0x0
	public static Func<PlayerControl, bool> <>9__38_1; // 0x8
	public static Func<RoleBehaviour, bool> <>9__39_0; // 0x10
	public static Func<RoleBehaviour, StringNames> <>9__39_1; // 0x18
	public static Func<PlainShipRoom, StringNames> <>9__40_0; // 0x20
	public static Func<RoleBehaviour, bool> <>9__40_1; // 0x28
	public static Func<RoleBehaviour, StringNames> <>9__40_2; // 0x30
	public static Func<PlayerTask, StringNames> <>9__40_3; // 0x38
	public static Func<StringNames, bool> <>9__40_4; // 0x40

	// Methods

	// RVA: 0x811B60 Offset: 0x810D60 VA: 0x180811B60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x811720 Offset: 0x810920 VA: 0x180811720
	internal bool <UpdateToCurrent>b__38_1(PlayerControl p) { }

	// RVA: 0x811750 Offset: 0x810950 VA: 0x180811750
	internal bool <UpdateWithCurrentLobby>b__39_0(RoleBehaviour role) { }

	// RVA: 0x5CEAE0 Offset: 0x5CDCE0 VA: 0x1805CEAE0
	internal StringNames <UpdateWithCurrentLobby>b__39_1(RoleBehaviour role) { }

	// RVA: 0x8117D0 Offset: 0x8109D0 VA: 0x1808117D0
	internal StringNames <UpdateWithCurrentMap>b__40_0(PlainShipRoom room) { }

	// RVA: 0x811830 Offset: 0x810A30 VA: 0x180811830
	internal bool <UpdateWithCurrentMap>b__40_1(RoleBehaviour role) { }

	// RVA: 0x5CEAE0 Offset: 0x5CDCE0 VA: 0x1805CEAE0
	internal StringNames <UpdateWithCurrentMap>b__40_2(RoleBehaviour role) { }

	// RVA: 0x8118B0 Offset: 0x810AB0 VA: 0x1808118B0
	internal StringNames <UpdateWithCurrentMap>b__40_3(PlayerTask task) { }

	// RVA: 0x811910 Offset: 0x810B10 VA: 0x180811910
	internal bool <UpdateWithCurrentMap>b__40_4(StringNames stringName) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatContext // TypeDefIndex: 2500
{
	// Fields
	private static readonly StringNames[] TASKS_TO_IGNORE; // 0x0
	private static readonly RoleTypes[] ROLES_TO_IGNORE; // 0x8
	private QuickChatData data; // 0x10
	private PlayerControl localPlayer; // 0x18
	private PlayerControl[] players; // 0x20
	private PlayerControl[] deadPlayers; // 0x28
	private StringNames[] locations; // 0x30
	private StringNames[] roles; // 0x38
	private StringNames[] systems; // 0x40
	private StringNames[] tasks; // 0x48
	private QuickChatContextPhase phase; // 0x50
	private GameModes gameMode; // 0x54
	private MapNames map; // 0x58
	private int meetingCount; // 0x5C

	// Properties
	public QuickChatData Data { get; }
	public PlayerControl[] Players { get; }
	public PlayerControl[] DeadPlayers { get; }
	public StringNames[] Locations { get; }
	public StringNames[] Roles { get; }
	public StringNames[] Systems { get; }
	public StringNames[] Tasks { get; }
	public QuickChatContextPhase Phase { get; }
	public GameModes GameMode { get; }
	public MapNames Map { get; }
	public int MeetingCount { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public QuickChatData get_Data() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PlayerControl[] get_Players() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PlayerControl[] get_DeadPlayers() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public StringNames[] get_Locations() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public StringNames[] get_Roles() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public StringNames[] get_Systems() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public StringNames[] get_Tasks() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public QuickChatContextPhase get_Phase() { }

	// RVA: 0x645A10 Offset: 0x644C10 VA: 0x180645A10
	public GameModes get_GameMode() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public MapNames get_Map() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public int get_MeetingCount() { }

	// RVA: 0x7F91A0 Offset: 0x7F83A0 VA: 0x1807F91A0
	public static QuickChatContext Current(QuickChatData data) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(QuickChatData data) { }

	// RVA: 0x7F9730 Offset: 0x7F8930 VA: 0x1807F9730
	private void UpdateToCurrent() { }

	// RVA: 0x7F9A70 Offset: 0x7F8C70 VA: 0x1807F9A70
	private void UpdateWithCurrentLobby() { }

	// RVA: 0x7F9D30 Offset: 0x7F8F30 VA: 0x1807F9D30
	private void UpdateWithCurrentMap() { }

	// RVA: 0x7F9200 Offset: 0x7F8400 VA: 0x1807F9200
	private MapNames GetCurrentMapID(ShipStatus ship) { }

	// RVA: 0x7F95D0 Offset: 0x7F87D0 VA: 0x1807F95D0
	public bool HasPlayersWithRole(RoleTypes role) { }

	// RVA: 0x7FA2D0 Offset: 0x7F94D0 VA: 0x1807FA2D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7F96C0 Offset: 0x7F88C0 VA: 0x1807F96C0
	private int <UpdateToCurrent>b__38_0(PlayerControl x) { }
}

// Namespace: AmongUs.QuickChat
public enum QuickChatContextPhase // TypeDefIndex: 2501
{
	// Fields
	public int value__; // 0x0
	public const QuickChatContextPhase None = 0;
	public const QuickChatContextPhase Lobby = 1;
	public const QuickChatContextPhase Game = 2;
}

// Namespace: AmongUs.QuickChat
[Serializable]
public class QuickChatHideAndSeekPhraseRules : AbstractQuickChatPhraseRuleGroup // TypeDefIndex: 2502
{
	// Fields
	[SerializeField]
	private QuickChatPhaseRules phases; // 0x10
	[SerializeField]
	private QuickChatMapRules maps; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(QuickChatPhaseRules phase, QuickChatMapRules map) { }

	// RVA: 0x7FB080 Offset: 0x7FA280 VA: 0x1807FB080 Slot: 4
	public override bool Evaluate(QuickChatContext context) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatTag : ScriptableObject // TypeDefIndex: 2503
{
	// Fields
	[SerializeField]
	private StringNames tagKey; // 0x18
	[SerializeField]
	private StringNames inputKey; // 0x1C
	[SerializeField]
	[ColorUsage(False)]
	private Color color; // 0x20
	[SerializeField]
	private string[] parsingKeys; // 0x30

	// Properties
	public StringNames TagNameKey { get; }
	public StringNames InputNameKey { get; }
	public string LocalizedTagName { get; }
	public string LocalizedInputName { get; }
	public Color Color { get; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public StringNames get_TagNameKey() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public StringNames get_InputNameKey() { }

	// RVA: 0x806D60 Offset: 0x805F60 VA: 0x180806D60
	public string get_LocalizedTagName() { }

	// RVA: 0x806CE0 Offset: 0x805EE0 VA: 0x180806CE0
	public string get_LocalizedInputName() { }

	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Color get_Color() { }

	// RVA: 0x806C20 Offset: 0x805E20 VA: 0x180806C20
	public bool ContainsParsingKey(string key) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatTagAssets : ScriptableObject // TypeDefIndex: 2504
{
	// Fields
	[SerializeField]
	[Header("Tags")]
	private QuickChatTag accusation; // 0x18
	[SerializeField]
	private QuickChatTag crew; // 0x20
	[SerializeField]
	private QuickChatTag deadCrew; // 0x28
	[SerializeField]
	private QuickChatTag defense; // 0x30
	[SerializeField]
	private QuickChatTag favorite; // 0x38
	[SerializeField]
	private QuickChatTag location; // 0x40
	[SerializeField]
	private QuickChatTag question; // 0x48
	[SerializeField]
	private QuickChatTag remark; // 0x50
	[SerializeField]
	private QuickChatTag role; // 0x58
	[SerializeField]
	private QuickChatTag self; // 0x60
	[SerializeField]
	private QuickChatTag system; // 0x68
	[SerializeField]
	private QuickChatTag task; // 0x70
	[SerializeField]
	[Header("Lobby Tags")]
	private QuickChatTag lobbyImpostor; // 0x78
	[SerializeField]
	private QuickChatTag lobbyMeeting; // 0x80
	[SerializeField]
	private QuickChatTag lobbyHiding; // 0x88
	[SerializeField]
	private QuickChatTag lobbyFlashlight; // 0x90
	[Header("Collections")]
	[SerializeField]
	private QuickChatTag[] visibleInClassicLobby; // 0x98
	[SerializeField]
	private QuickChatTag[] visibleInHideAndSeekLobby; // 0xA0
	[SerializeField]
	private QuickChatTag[] visibleInGame; // 0xA8
	[SerializeField]
	private QuickChatTag[] all; // 0xB0

	// Properties
	public QuickChatTag Accusation { get; }
	public QuickChatTag Crew { get; }
	public QuickChatTag DeadCrew { get; }
	public QuickChatTag Defense { get; }
	public QuickChatTag Favorite { get; }
	public QuickChatTag Location { get; }
	public QuickChatTag Question { get; }
	public QuickChatTag Remark { get; }
	public QuickChatTag Role { get; }
	public QuickChatTag Self { get; }
	public QuickChatTag System { get; }
	public QuickChatTag Task { get; }
	public QuickChatTag LobbyImpostor { get; }
	public QuickChatTag LobbyMeeting { get; }
	public QuickChatTag LobbyHiding { get; }
	public QuickChatTag LobbyFlashlight { get; }
	public QuickChatTag[] VisibleInClassicLobby { get; }
	public QuickChatTag[] VisibleInHideAndSeekLobby { get; }
	public QuickChatTag[] VisibleInGame { get; }
	public QuickChatTag[] All { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public QuickChatTag get_Accusation() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public QuickChatTag get_Crew() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public QuickChatTag get_DeadCrew() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public QuickChatTag get_Defense() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public QuickChatTag get_Favorite() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public QuickChatTag get_Location() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public QuickChatTag get_Question() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public QuickChatTag get_Remark() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public QuickChatTag get_Role() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public QuickChatTag get_Self() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public QuickChatTag get_System() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public QuickChatTag get_Task() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public QuickChatTag get_LobbyImpostor() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public QuickChatTag get_LobbyMeeting() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public QuickChatTag get_LobbyHiding() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public QuickChatTag get_LobbyFlashlight() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public QuickChatTag[] get_VisibleInClassicLobby() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public QuickChatTag[] get_VisibleInHideAndSeekLobby() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public QuickChatTag[] get_VisibleInGame() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public QuickChatTag[] get_All() { }

	// RVA: 0x806990 Offset: 0x805B90 VA: 0x180806990
	public QuickChatTag GetTagByName(string name) { }

	// RVA: 0x806A80 Offset: 0x805C80 VA: 0x180806A80
	public QuickChatTag[] GetTagsByParsingKeys(string[] parsingKeys) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public abstract class AbstractQuickChatMenuPage : MonoBehaviour // TypeDefIndex: 2505
{
	// Fields
	private QuickChatMenu menu; // 0x20
	private float width; // 0x28
	private float height; // 0x2C

	// Properties
	public QuickChatMenu Menu { get; }
	public float Width { get; }
	public float Height { get; }
	public virtual PassiveButton DefaultSelection { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public QuickChatMenu get_Menu() { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_Width() { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float get_Height() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public virtual PassiveButton get_DefaultSelection() { }

	// RVA: 0x7F5E90 Offset: 0x7F5090 VA: 0x1807F5E90 Slot: 5
	public virtual void Initialize(QuickChatMenu menu, float width) { }

	// RVA: 0x7F5EA0 Offset: 0x7F50A0 VA: 0x1807F5EA0 Slot: 6
	public virtual void Show(float height) { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20 Slot: 7
	public virtual void Hide() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: 
public sealed class AbstractQuickChatMenuPhrasesPageButton.ButtonClickedHandler : MulticastDelegate // TypeDefIndex: 2506
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(AbstractQuickChatMenuPhrasesPageButton button) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(AbstractQuickChatMenuPhrasesPageButton button, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: AmongUs.QuickChat
public abstract class AbstractQuickChatMenuPhrasesPageButton : MonoBehaviour // TypeDefIndex: 2507
{
	// Fields
	private const int MASK_LAYER_INDEX_START = 145;
	[SerializeField]
	private PassiveButton button; // 0x20
	[SerializeField]
	private BoxCollider2D collider; // 0x28
	[SerializeField]
	private UIScrollbarHelper scrollHelper; // 0x30
	[Space(10)]
	[SerializeField]
	private TextMeshPro text; // 0x38
	[SerializeField]
	private RectTransform textRect; // 0x40
	[Space(10)]
	[SerializeField]
	private SpriteRenderer arrow; // 0x48
	[SerializeField]
	private SpriteRenderer[] backgroundSprites; // 0x50
	private QuickChatPhrase phrase; // 0x58
	private int index; // 0x60
	private int buttonCount; // 0x64
	private float width; // 0x68
	private Material textMaterial; // 0x70
	[CompilerGenerated]
	private AbstractQuickChatMenuPhrasesPageButton.ButtonClickedHandler OnSelectedEvent; // 0x78

	// Properties
	public QuickChatPhrase Phrase { get; }
	public PassiveButton Button { get; }
	public UIScrollbarHelper ScrollHelper { get; }
	public float Width { get; }
	public float Height { get; }
	public int MaskLayer { get; }
	protected TextMeshPro Text { get; }
	protected Material TextMaterial { get; }
	protected RectTransform TextRect { get; }
	protected BoxCollider2D Collider { get; }
	protected SpriteRenderer Arrow { get; }
	protected SpriteRenderer[] BackgroundSprites { get; }
	public abstract string ButtonType { get; }

	// Methods

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public QuickChatPhrase get_Phrase() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PassiveButton get_Button() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public UIScrollbarHelper get_ScrollHelper() { }

	// RVA: 0x526CE0 Offset: 0x525EE0 VA: 0x180526CE0
	public float get_Width() { }

	// RVA: 0x7F6600 Offset: 0x7F5800 VA: 0x1807F6600
	public float get_Height() { }

	// RVA: 0x7F6630 Offset: 0x7F5830 VA: 0x1807F6630
	public int get_MaskLayer() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	protected TextMeshPro get_Text() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	protected Material get_TextMaterial() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	protected RectTransform get_TextRect() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected BoxCollider2D get_Collider() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	protected SpriteRenderer get_Arrow() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	protected SpriteRenderer[] get_BackgroundSprites() { }

	[CompilerGenerated]
	// RVA: 0x7F6560 Offset: 0x7F5760 VA: 0x1807F6560
	public void add_OnSelectedEvent(AbstractQuickChatMenuPhrasesPageButton.ButtonClickedHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7F6640 Offset: 0x7F5840 VA: 0x1807F6640
	public void remove_OnSelectedEvent(AbstractQuickChatMenuPhrasesPageButton.ButtonClickedHandler value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ButtonType();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Awake() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnSetup();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetInitialWidth();

	// RVA: 0x7F62D0 Offset: 0x7F54D0 VA: 0x1807F62D0
	public void Setup(int index, int buttonCount, float width, QuickChatPhrase phrase, Material textMaterial) { }

	// RVA: 0x7F5FC0 Offset: 0x7F51C0 VA: 0x1807F5FC0
	public void SetWidth(float width) { }

	// RVA: 0x7F5FA0 Offset: 0x7F51A0 VA: 0x1807F5FA0 Slot: 8
	public virtual void SetEnabled(bool enabled) { }

	// RVA: 0x7F5ED0 Offset: 0x7F50D0 VA: 0x1807F5ED0
	private void OnButtonPressed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatFavoriteIcon : MonoBehaviour // TypeDefIndex: 2508
{
	// Fields
	private const string STATE_ACTIVE_IDLE = "ActiveIdle";
	private const string STATE_INACTIVE_IDLE = "InactiveIdle";
	[SerializeField]
	private Animator animator; // 0x20
	[SerializeField]
	private BoxCollider2D collider; // 0x28
	[SerializeField]
	private PassiveButton button; // 0x30
	[CompilerGenerated]
	private Action OnPressEvent; // 0x38

	// Properties
	public Vector2 Size { get; }

	// Methods

	// RVA: 0x7FAFC0 Offset: 0x7FA1C0 VA: 0x1807FAFC0
	public Vector2 get_Size() { }

	[CompilerGenerated]
	// RVA: 0x7FAF20 Offset: 0x7FA120 VA: 0x1807FAF20
	public void add_OnPressEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7FAFE0 Offset: 0x7FA1E0 VA: 0x1807FAFE0
	public void remove_OnPressEvent(Action value) { }

	// RVA: 0x7FAC70 Offset: 0x7F9E70 VA: 0x1807FAC70
	private void Awake() { }

	// RVA: 0x7FAE70 Offset: 0x7FA070 VA: 0x1807FAE70
	public void Setup(bool active) { }

	// RVA: 0x7FAD40 Offset: 0x7F9F40 VA: 0x1807FAD40
	public void SetFavorite(bool isFavorite) { }

	// RVA: 0x7FADA0 Offset: 0x7F9FA0 VA: 0x1807FADA0
	public void SetHeight(float height) { }

	// RVA: 0x577820 Offset: 0x576A20 VA: 0x180577820
	private void OnButtonPressed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatMenu.<CoAnimate>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2509
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickChatMenu <>4__this; // 0x20
	public AnimationCurve animation; // 0x28
	public float from; // 0x30
	public float to; // 0x34
	public Action onCompleteCallback; // 0x38
	private float <duration>5__2; // 0x40
	private float <t>5__3; // 0x44

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

	// RVA: 0x810B10 Offset: 0x80FD10 VA: 0x180810B10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x810CD0 Offset: 0x80FED0 VA: 0x180810CD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenu : MonoBehaviour // TypeDefIndex: 2510
{
	// Fields
	public const float WIDTH_DEFAULT = 3,5;
	public const float WIDTH_MIN = 2,5;
	public const float PADDING_X = 0,2;
	public static readonly Logger Logger; // 0x0
	[SerializeField]
	private QuickChatData data; // 0x20
	[SerializeField]
	private Transform container; // 0x28
	[SerializeField]
	private SpriteRenderer frame; // 0x30
	[Space(10)]
	[SerializeField]
	private Transform topContentBlocker; // 0x38
	[SerializeField]
	private Transform bottomContentBlocker; // 0x40
	[Space(10)]
	[SerializeField]
	private PassiveButton closeButton; // 0x48
	[SerializeField]
	private GameObject closeButtonGlyph; // 0x50
	[Header("Animations")]
	[SerializeField]
	private AnimationCurve animationIn; // 0x58
	[SerializeField]
	private AnimationCurve animationOut; // 0x60
	[SerializeField]
	[Header("Pages")]
	private Transform pagesContainer; // 0x68
	[SerializeField]
	private QuickChatMenuLandingPage landingPage; // 0x70
	[SerializeField]
	private QuickChatMenuPhrasesPage phrasesPage; // 0x78
	[Header("Header")]
	[SerializeField]
	private QuickChatMenuHeader header; // 0x80
	[SerializeField]
	private QuickChatMenuVoteTimer timer; // 0x88
	private QuickChatPhraseBuilder builder; // 0x90
	private List<QuickChatBreadcrumb> breadcrumbs; // 0x98
	private IEnumerator animationCoroutine; // 0xA0
	private bool isOpen; // 0xA8
	private float height; // 0xAC
	private float width; // 0xB0
	private float targetXPos; // 0xB4
	[CompilerGenerated]
	private Action OnOpenEvent; // 0xB8
	[CompilerGenerated]
	private Action OnCloseEvent; // 0xC0
	[CompilerGenerated]
	private QuickChatPhraseBuilder.ChangeHandler OnBuilderChangedEvent; // 0xC8

	// Properties
	public QuickChatData Data { get; }
	public bool IsOpen { get; }
	public bool IsAnimating { get; }
	public bool IsEmpty { get; }
	public bool CanSend { get; }
	public Vector3 WorldPosition { get; }
	private bool IsTimerVisible { get; }
	private float TargetXClosed { get; }
	private float TargetXOpen { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public QuickChatData get_Data() { }

	// RVA: 0x738050 Offset: 0x737250 VA: 0x180738050
	public bool get_IsOpen() { }

	// RVA: 0x803160 Offset: 0x802360 VA: 0x180803160
	public bool get_IsAnimating() { }

	// RVA: 0x803170 Offset: 0x802370 VA: 0x180803170
	public bool get_IsEmpty() { }

	// RVA: 0x803130 Offset: 0x802330 VA: 0x180803130
	public bool get_CanSend() { }

	// RVA: 0x803220 Offset: 0x802420 VA: 0x180803220
	public Vector3 get_WorldPosition() { }

	// RVA: 0x8031A0 Offset: 0x8023A0 VA: 0x1808031A0
	private bool get_IsTimerVisible() { }

	// RVA: 0x564140 Offset: 0x563340 VA: 0x180564140
	private float get_TargetXClosed() { }

	// RVA: 0x803210 Offset: 0x802410 VA: 0x180803210
	private float get_TargetXOpen() { }

	[CompilerGenerated]
	// RVA: 0x803080 Offset: 0x802280 VA: 0x180803080
	public void add_OnOpenEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8033C0 Offset: 0x8025C0 VA: 0x1808033C0
	public void remove_OnOpenEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x802FD0 Offset: 0x8021D0 VA: 0x180802FD0
	public void add_OnCloseEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x803310 Offset: 0x802510 VA: 0x180803310
	public void remove_OnCloseEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x802F20 Offset: 0x802120 VA: 0x180802F20
	public void add_OnBuilderChangedEvent(QuickChatPhraseBuilder.ChangeHandler value) { }

	[CompilerGenerated]
	// RVA: 0x803260 Offset: 0x802460 VA: 0x180803260
	public void remove_OnBuilderChangedEvent(QuickChatPhraseBuilder.ChangeHandler value) { }

	// RVA: 0x800BC0 Offset: 0x7FFDC0 VA: 0x180800BC0
	private void Awake() { }

	// RVA: 0x802A70 Offset: 0x801C70 VA: 0x180802A70
	private void Update() { }

	// RVA: 0x801280 Offset: 0x800480 VA: 0x180801280
	public void Clear() { }

	// RVA: 0x802890 Offset: 0x801A90 VA: 0x180802890
	public void Undo() { }

	// RVA: 0x802D80 Offset: 0x801F80 VA: 0x180802D80
	public void UpdateVoteTimerText(StringNames key, int value) { }

	// RVA: 0x801720 Offset: 0x800920 VA: 0x180801720
	private void InitializeChildren() { }

	// RVA: 0x801450 Offset: 0x800650 VA: 0x180801450
	private void OnCloseButtonPressed() { }

	// RVA: 0x8011B0 Offset: 0x8003B0 VA: 0x1808011B0
	public QuickChatPhraseBuilderResult BuildMessageData() { }

	// RVA: 0x8011E0 Offset: 0x8003E0 VA: 0x1808011E0
	public void BuildMessageLog(StringBuilder log) { }

	// RVA: 0x801210 Offset: 0x800410 VA: 0x180801210
	public bool CanAddPhraseToBuilder(QuickChatPhrase p) { }

	// RVA: 0x801CB0 Offset: 0x800EB0 VA: 0x180801CB0
	private void OnBuilderChanged(QuickChatPhraseBuilder builder) { }

	// RVA: 0x8024C0 Offset: 0x8016C0 VA: 0x1808024C0
	public void Open(float width) { }

	// RVA: 0x801450 Offset: 0x800650 VA: 0x180801450
	public void Close() { }

	// RVA: 0x8012C0 Offset: 0x8004C0 VA: 0x1808012C0
	public void CloseImmediately() { }

	// RVA: 0x801CD0 Offset: 0x800ED0 VA: 0x180801CD0
	private void OnCloseComplete() { }

	// RVA: 0x802850 Offset: 0x801A50 VA: 0x180802850
	private void StopAnimationCoroutine() { }

	[IteratorStateMachine(typeof(QuickChatMenu.<CoAnimate>d__68))]
	// RVA: 0x8015C0 Offset: 0x8007C0 VA: 0x1808015C0
	private IEnumerator CoAnimate(float from, float to, AnimationCurve animation, Action onCompleteCallback) { }

	// RVA: 0x802660 Offset: 0x801860 VA: 0x180802660
	private void SetAnimationParameters(float value) { }

	// RVA: 0x802A70 Offset: 0x801C70 VA: 0x180802A70
	private void UpdateContainerTransform() { }

	// RVA: 0x801660 Offset: 0x800860 VA: 0x180801660
	private float GetPageHeight() { }

	// RVA: 0x802CD0 Offset: 0x801ED0 VA: 0x180802CD0
	private void UpdatePagePosition() { }

	// RVA: 0x802AE0 Offset: 0x801CE0 VA: 0x180802AE0
	private void UpdatePageBlockers() { }

	// RVA: 0x802670 Offset: 0x801870 VA: 0x180802670
	private void ShowLandingPage() { }

	// RVA: 0x801D70 Offset: 0x800F70 VA: 0x180801D70
	private void OnLandingPageTagButtonPressed(QuickChatMenuLandingPageButton button) { }

	// RVA: 0x8027A0 Offset: 0x8019A0 VA: 0x1808027A0
	private void ShowPhrasePage(QuickChatTag[] tags) { }

	// RVA: 0x801FC0 Offset: 0x8011C0 VA: 0x180801FC0
	private void OnPhraseSelected(QuickChatPhrase phrase) { }

	// RVA: 0x801D60 Offset: 0x800F60 VA: 0x180801D60
	private void OnHeaderBackButtonPressed() { }

	// RVA: 0x802480 Offset: 0x801680 VA: 0x180802480
	private void OnPhrasesTopMenuButtonPressed() { }

	// RVA: 0x802E70 Offset: 0x802070 VA: 0x180802E70
	public void .ctor() { }

	// RVA: 0x802DB0 Offset: 0x801FB0 VA: 0x180802DB0
	private static void .cctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatBreadcrumb // TypeDefIndex: 2511
{
	// Fields
	public readonly QuickChatBreadcrumbType Type; // 0x10
	public readonly QuickChatTag[] Tags; // 0x18

	// Methods

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	public void .ctor(QuickChatBreadcrumbType type, QuickChatTag[] tags) { }
}

// Namespace: AmongUs.QuickChat
public enum QuickChatBreadcrumbType // TypeDefIndex: 2512
{
	// Fields
	public int value__; // 0x0
	public const QuickChatBreadcrumbType Tag = 0;
	public const QuickChatBreadcrumbType Inputs = 1;
	public const QuickChatBreadcrumbType End = 2;
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuHeader : MonoBehaviour // TypeDefIndex: 2513
{
	// Fields
	private const float PADDING = 0,2;
	private const float TEXT_LINE_HEIGHT = 0,5;
	private const float DIVIDER_OFFSET = -0,11;
	private const StringNames DEFAULT_HEADER = 1953;
	[SerializeField]
	private Transform content; // 0x20
	[Space(10)]
	[SerializeField]
	private TextMeshPro text; // 0x28
	[SerializeField]
	private Transform textMask; // 0x30
	[SerializeField]
	private Transform textGradient; // 0x38
	[Space(10)]
	[SerializeField]
	private PassiveButton backButton; // 0x40
	[SerializeField]
	private BoxCollider2D backButtonCollider; // 0x48
	[Space(10)]
	[SerializeField]
	private Transform divider; // 0x50
	[Space(10)]
	[SerializeField]
	private GameObject favoriteBox; // 0x58
	[SerializeField]
	private GameObject favoriteBoxContainer; // 0x60
	[SerializeField]
	private GameObject favoriteBoxGlyph; // 0x68
	[SerializeField]
	private SpriteRenderer favoriteBoxBackground; // 0x70
	private float width; // 0x78
	private float height; // 0x7C
	private float defaultFontSize; // 0x80
	[CompilerGenerated]
	private Action OnBackPressedEvent; // 0x88

	// Properties
	public float Height { get; }

	// Methods

	// RVA: 0x7FBDF0 Offset: 0x7FAFF0 VA: 0x1807FBDF0
	public float get_Height() { }

	[CompilerGenerated]
	// RVA: 0x7FBD40 Offset: 0x7FAF40 VA: 0x1807FBD40
	public void add_OnBackPressedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7FBE00 Offset: 0x7FB000 VA: 0x1807FBE00
	public void remove_OnBackPressedEvent(Action value) { }

	// RVA: 0x7FB170 Offset: 0x7FA370 VA: 0x1807FB170
	private void Awake() { }

	// RVA: 0x7FBCD0 Offset: 0x7FAED0 VA: 0x1807FBCD0
	private void Update() { }

	// RVA: 0x7FB320 Offset: 0x7FA520 VA: 0x1807FB320
	public void Initialize(float width) { }

	// RVA: 0x7FB560 Offset: 0x7FA760 VA: 0x1807FB560
	public void ShowLandingPage() { }

	// RVA: 0x7FB7A0 Offset: 0x7FA9A0 VA: 0x1807FB7A0
	public void ShowPhrasesPage(List<QuickChatBreadcrumb> breadcrumbs) { }

	// RVA: 0x7FBAC0 Offset: 0x7FACC0 VA: 0x1807FBAC0
	private void UpdateSize() { }

	// RVA: 0x7FB450 Offset: 0x7FA650 VA: 0x1807FB450
	private void SetFavoriteGlyphBox(bool enabled) { }

	// RVA: 0x7FB250 Offset: 0x7FA450 VA: 0x1807FB250
	private string ClampTextToBounds(string input) { }

	// RVA: 0x7FB430 Offset: 0x7FA630 VA: 0x1807FB430
	private void OnBackPressed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public sealed class QuickChatMenuLandingPage.OnButtonPressedHandler : MulticastDelegate // TypeDefIndex: 2514
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(QuickChatMenuLandingPageButton button) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(QuickChatMenuLandingPageButton button, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatMenuLandingPage.<>c__DisplayClass16_0 // TypeDefIndex: 2515
{
	// Fields
	public QuickChatMenuLandingPageButton button; // 0x10
	public QuickChatMenuLandingPage <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x811990 Offset: 0x810B90 VA: 0x180811990
	internal void <SetupContent>b__0() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuLandingPage : AbstractQuickChatMenuPage // TypeDefIndex: 2516
{
	// Fields
	[SerializeField]
	private QuickChatMenuLandingPageButton favoritesButton; // 0x30
	[SerializeField]
	private QuickChatMenuLandingPageButton remarksButton; // 0x38
	[SerializeField]
	private Transform contentBlocker; // 0x40
	[Header("List")]
	[SerializeField]
	private Transform listContainer; // 0x48
	[SerializeField]
	private QuickChatMenuScroller scroller; // 0x50
	[SerializeField]
	private QuickChatMenuLandingPageButton buttonTemplate; // 0x58
	private QuickChatMenuLandingPageButton[] dynamicButtons; // 0x60
	[CompilerGenerated]
	private QuickChatMenuLandingPage.OnButtonPressedHandler OnButtonPressed; // 0x68

	// Properties
	public override PassiveButton DefaultSelection { get; }

	// Methods

	// RVA: 0x7FD640 Offset: 0x7FC840 VA: 0x1807FD640 Slot: 4
	public override PassiveButton get_DefaultSelection() { }

	[CompilerGenerated]
	// RVA: 0x7FD5A0 Offset: 0x7FC7A0 VA: 0x1807FD5A0
	public void add_OnButtonPressed(QuickChatMenuLandingPage.OnButtonPressedHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7FD660 Offset: 0x7FC860 VA: 0x1807FD660
	public void remove_OnButtonPressed(QuickChatMenuLandingPage.OnButtonPressedHandler value) { }

	// RVA: 0x7FC760 Offset: 0x7FB960 VA: 0x1807FC760 Slot: 5
	public override void Initialize(QuickChatMenu menu, float width) { }

	// RVA: 0x7FD410 Offset: 0x7FC610 VA: 0x1807FD410 Slot: 6
	public override void Show(float height) { }

	// RVA: 0x7FC640 Offset: 0x7FB840 VA: 0x1807FC640 Slot: 7
	public override void Hide() { }

	// RVA: 0x7FC940 Offset: 0x7FBB40 VA: 0x1807FC940
	private void SetupContent() { }

	// RVA: 0x7FC540 Offset: 0x7FB740 VA: 0x1807FC540
	private QuickChatMenuLandingPageButton CreateDynamicButton() { }

	// RVA: 0x7FC920 Offset: 0x7FBB20 VA: 0x1807FC920
	private void OnRemarksButtonClicked() { }

	// RVA: 0x7FC900 Offset: 0x7FBB00 VA: 0x1807FC900
	private void OnFavoritesButtonClicked() { }

	// RVA: 0x7FC8E0 Offset: 0x7FBAE0 VA: 0x1807FC8E0
	private void OnDynamicButtonClicked(QuickChatMenuLandingPageButton button) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuLandingPageButton : MonoBehaviour // TypeDefIndex: 2517
{
	// Fields
	[SerializeField]
	private PassiveButton button; // 0x20
	[SerializeField]
	private BoxCollider2D collider; // 0x28
	[SerializeField]
	private UIScrollbarHelper scrollHelper; // 0x30
	[SerializeField]
	[Space(10)]
	private TMP_Text text; // 0x38
	[SerializeField]
	private RectTransform textRect; // 0x40
	[SerializeField]
	private TextTranslatorTMP translator; // 0x48
	[Space(10)]
	[SerializeField]
	private SpriteRenderer[] backgroundSprites; // 0x50
	[SerializeField]
	private SpriteRenderer[] shineSprites; // 0x58
	private QuickChatTag tag; // 0x60

	// Properties
	public QuickChatTag Tag { get; }
	public PassiveButton Button { get; }
	public UIScrollbarHelper ScrollHelper { get; }
	public float Width { get; }
	public float Height { get; }
	public StringNames TranslationKey { get; }

	// Methods

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public QuickChatTag get_Tag() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PassiveButton get_Button() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public UIScrollbarHelper get_ScrollHelper() { }

	// RVA: 0x7FC510 Offset: 0x7FB710 VA: 0x1807FC510
	public float get_Width() { }

	// RVA: 0x7F6600 Offset: 0x7F5800 VA: 0x1807F6600
	public float get_Height() { }

	// RVA: 0x7FC4F0 Offset: 0x7FB6F0 VA: 0x1807FC4F0
	public StringNames get_TranslationKey() { }

	// RVA: 0x7FC3B0 Offset: 0x7FB5B0 VA: 0x1807FC3B0 Slot: 4
	public virtual void Setup(int index, QuickChatTag tag) { }

	// RVA: 0x7FBEB0 Offset: 0x7FB0B0 VA: 0x1807FBEB0
	public void SetStringName(StringNames key) { }

	// RVA: 0x7FBEE0 Offset: 0x7FB0E0 VA: 0x1807FBEE0
	public void SetWidth(float width) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
public sealed class QuickChatMenuPhrasesPage.PhraseSelectedHandler : MulticastDelegate // TypeDefIndex: 2518
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(QuickChatPhrase phrase) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(QuickChatPhrase phrase, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatMenuPhrasesPage.<CoDelayedSelectFirstButton>d__30 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2519
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickChatMenuPhrasesPage <>4__this; // 0x20

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

	// RVA: 0x810D10 Offset: 0x80FF10 VA: 0x180810D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x810E20 Offset: 0x810020 VA: 0x180810E20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuPhrasesPage : AbstractQuickChatMenuPage // TypeDefIndex: 2520
{
	// Fields
	private const float BOTTOM_PADDING = 0,1;
	private static readonly Color32 TEXT_COLOR_ENABLED; // 0x0
	private static readonly Color32 TEXT_COLOR_DISABLED; // 0x4
	[Header("UI")]
	[SerializeField]
	private QuickChatMenuScroller scroller; // 0x30
	[Header("Button Templates")]
	[SerializeField]
	private QuickChatMenuPhrasesPagePhraseButton phraseButtonTemplate; // 0x38
	[SerializeField]
	private QuickChatMenuPhrasesPageCrewmateButton crewmateButtonTemplate; // 0x40
	[SerializeField]
	private Material defaultButtonTextMaterial; // 0x48
	[Header("Input")]
	[SerializeField]
	private ControllerButtonBehavior favoriteButton; // 0x50
	private AbstractQuickChatMenuPhrasesPageButton[] dynamicButtons; // 0x58
	private QuickChatTag[] tags; // 0x60
	private QuickChatPhrase[] phrases; // 0x68
	private Material buttonTextMaterial; // 0x70
	[CompilerGenerated]
	private QuickChatMenuPhrasesPage.PhraseSelectedHandler OnPhraseSelectedEvent; // 0x78

	// Properties
	public QuickChatTag[] Tags { get; }
	public QuickChatPhrase[] Phrases { get; }

	// Methods

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public QuickChatTag[] get_Tags() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public QuickChatPhrase[] get_Phrases() { }

	[CompilerGenerated]
	// RVA: 0x7FFD00 Offset: 0x7FEF00 VA: 0x1807FFD00
	public void add_OnPhraseSelectedEvent(QuickChatMenuPhrasesPage.PhraseSelectedHandler value) { }

	[CompilerGenerated]
	// RVA: 0x7FFDA0 Offset: 0x7FEFA0 VA: 0x1807FFDA0
	public void remove_OnPhraseSelectedEvent(QuickChatMenuPhrasesPage.PhraseSelectedHandler value) { }

	// RVA: 0x7FEAE0 Offset: 0x7FDCE0 VA: 0x1807FEAE0
	private void Awake() { }

	// RVA: 0x7FF980 Offset: 0x7FEB80 VA: 0x1807FF980
	public void ShowTagPage(float height, QuickChatTag[] tags) { }

	// RVA: 0x7FEF00 Offset: 0x7FE100 VA: 0x1807FEF00 Slot: 7
	public override void Hide() { }

	// RVA: 0x7FF1A0 Offset: 0x7FE3A0 VA: 0x1807FF1A0
	public void SetPhrasesEnableState(bool enabled) { }

	// RVA: 0x7FF330 Offset: 0x7FE530 VA: 0x1807FF330
	private void SetupContent() { }

	// RVA: 0x7FEF60 Offset: 0x7FE160 VA: 0x1807FEF60
	private void OnButtonSelected(AbstractQuickChatMenuPhrasesPageButton button) { }

	// RVA: 0x7FEBC0 Offset: 0x7FDDC0 VA: 0x1807FEBC0
	private void ClearDynamicButtons() { }

	// RVA: 0x7FEE10 Offset: 0x7FE010 VA: 0x1807FEE10
	private AbstractQuickChatMenuPhrasesPageButton CreatePhraseButton(int index, int buttonCount, float width, QuickChatPhrase phrase) { }

	// RVA: -1 Offset: -1
	private T CreatePhraseButtonOfType<T>(T template) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5D230 Offset: 0xA5C430 VA: 0x180A5D230
	|-QuickChatMenuPhrasesPage.CreatePhraseButtonOfType<object>
	*/

	// RVA: 0x7FF040 Offset: 0x7FE240 VA: 0x1807FF040
	private void OnFavoriteButtonPressed() { }

	[IteratorStateMachine(typeof(QuickChatMenuPhrasesPage.<CoDelayedSelectFirstButton>d__30))]
	// RVA: 0x7FEDB0 Offset: 0x7FDFB0 VA: 0x1807FEDB0
	private IEnumerator CoDelayedSelectFirstButton() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x7FFC90 Offset: 0x7FEE90 VA: 0x1807FFC90
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7FFC10 Offset: 0x7FEE10 VA: 0x1807FFC10
	private bool <ShowTagPage>b__21_0(QuickChatPhrase p) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QuickChatMenuPhrasesPageCrewmateButton.<>c // TypeDefIndex: 2521
{
	// Fields
	public static readonly QuickChatMenuPhrasesPageCrewmateButton.<>c <>9; // 0x0
	public static Action<SpriteRenderer> <>9__11_1; // 0x8
	public static Action<SpriteRenderer> <>9__11_3; // 0x10

	// Methods

	// RVA: 0x811AA0 Offset: 0x810CA0 VA: 0x180811AA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x811450 Offset: 0x810650 VA: 0x180811450
	internal void <CoSetPlayerRendererIndexes>b__11_1(SpriteRenderer x) { }

	// RVA: 0x8114D0 Offset: 0x8106D0 VA: 0x1808114D0
	internal void <CoSetPlayerRendererIndexes>b__11_3(SpriteRenderer x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatMenuPhrasesPageCrewmateButton.<CoSetPlayerRendererIndexes>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2522
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickChatMenuPhrasesPageCrewmateButton <>4__this; // 0x20

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

	// RVA: 0x811110 Offset: 0x810310 VA: 0x180811110 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x811410 Offset: 0x810610 VA: 0x180811410 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuPhrasesPageCrewmateButton : AbstractQuickChatMenuPhrasesPageButton // TypeDefIndex: 2523
{
	// Fields
	[Header("Crewmate Button")]
	[SerializeField]
	private PoolablePlayer player; // 0x80
	[SerializeField]
	private SpriteRenderer playerMask; // 0x88
	[SerializeField]
	private Material playerMaterial; // 0x90
	[SerializeField]
	private SpriteRenderer[] playerMaterialRenderers; // 0x98
	[SerializeField]
	private SpriteRenderer[] playerUnmaskedRenderers; // 0xA0
	[SerializeField]
	private SpriteRenderer[] playerColorBackgrounds; // 0xA8

	// Properties
	public override string ButtonType { get; }

	// Methods

	// RVA: 0x7FDF60 Offset: 0x7FD160 VA: 0x1807FDF60 Slot: 4
	public override string get_ButtonType() { }

	// RVA: 0x7FD700 Offset: 0x7FC900 VA: 0x1807FD700 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7FC510 Offset: 0x7FB710 VA: 0x1807FC510 Slot: 7
	protected override float GetInitialWidth() { }

	// RVA: 0x7FD960 Offset: 0x7FCB60 VA: 0x1807FD960 Slot: 6
	protected override void OnSetup() { }

	[IteratorStateMachine(typeof(QuickChatMenuPhrasesPageCrewmateButton.<CoSetPlayerRendererIndexes>d__11))]
	// RVA: 0x7FD7F0 Offset: 0x7FC9F0 VA: 0x1807FD7F0
	private IEnumerator CoSetPlayerRendererIndexes() { }

	// RVA: 0x7FD8C0 Offset: 0x7FCAC0 VA: 0x1807FD8C0
	private void OnButtonMouseOver() { }

	// RVA: 0x7FD850 Offset: 0x7FCA50 VA: 0x1807FD850
	private void OnButtonMouseOut() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7FDEE0 Offset: 0x7FD0E0 VA: 0x1807FDEE0
	private bool <OnSetup>b__10_0(PlayerControl p) { }

	[CompilerGenerated]
	// RVA: 0x7FDF10 Offset: 0x7FD110 VA: 0x1807FDF10
	private void <OnSetup>b__10_1(SpriteRenderer x) { }

	[CompilerGenerated]
	// RVA: 0x7FDDA0 Offset: 0x7FCFA0 VA: 0x1807FDDA0
	private void <CoSetPlayerRendererIndexes>b__11_0(SpriteRenderer x) { }

	[CompilerGenerated]
	// RVA: 0x7FDE40 Offset: 0x7FD040 VA: 0x1807FDE40
	private void <CoSetPlayerRendererIndexes>b__11_2(SpriteRenderer x) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuPhrasesPagePhraseButton : AbstractQuickChatMenuPhrasesPageButton // TypeDefIndex: 2524
{
	// Fields
	[SerializeField]
	[Header("Phrase Button")]
	private QuickChatFavoriteIcon favoriteIcon; // 0x80

	// Properties
	public override string ButtonType { get; }

	// Methods

	// RVA: 0x7FEAB0 Offset: 0x7FDCB0 VA: 0x1807FEAB0 Slot: 4
	public override string get_ButtonType() { }

	// RVA: 0x7FDF90 Offset: 0x7FD190 VA: 0x1807FDF90 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7FE090 Offset: 0x7FD290 VA: 0x1807FE090 Slot: 7
	protected override float GetInitialWidth() { }

	// RVA: 0x7FE100 Offset: 0x7FD300 VA: 0x1807FE100 Slot: 6
	protected override void OnSetup() { }

	// RVA: 0x7FE720 Offset: 0x7FD920 VA: 0x1807FE720 Slot: 8
	public override void SetEnabled(bool enabled) { }

	// RVA: 0x7FE780 Offset: 0x7FD980 VA: 0x1807FE780
	public void ToggleFavorite() { }

	// RVA: 0x7FE0F0 Offset: 0x7FD2F0 VA: 0x1807FE0F0
	private void OnFavoritePressed() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuScroller : MonoBehaviour // TypeDefIndex: 2525
{
	// Fields
	public const float SCROLLBAR_WIDTH = 0,2;
	[SerializeField]
	private Scroller scroller; // 0x20
	[SerializeField]
	private Scrollbar scrollBar; // 0x28
	[SerializeField]
	private SpriteRenderer track; // 0x30
	[SerializeField]
	private BoxCollider2D collider; // 0x38
	[SerializeField]
	private ScrollToSelection scrollToSelection; // 0x40
	[Header("Gradients")]
	[SerializeField]
	private SpriteRenderer topGradient; // 0x48
	[SerializeField]
	private Transform topGradientContainer; // 0x50
	[Space(10)]
	[SerializeField]
	private SpriteRenderer bottomGradient; // 0x58
	[SerializeField]
	private Transform bottomGradientContainer; // 0x60
	private float width; // 0x68
	private float height; // 0x6C
	private Color topGradientColor; // 0x70
	private Color bottomGradientColor; // 0x80

	// Properties
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x8008F0 Offset: 0x7FFAF0 VA: 0x1808008F0
	public bool get_IsVisible() { }

	// RVA: 0x7FFE40 Offset: 0x7FF040 VA: 0x1807FFE40
	private void Awake() { }

	// RVA: 0x800410 Offset: 0x7FF610 VA: 0x180800410
	public void SetSize(float width, float height) { }

	// RVA: 0x8002F0 Offset: 0x7FF4F0 VA: 0x1808002F0
	public void SetContentHeight(float contentHeight) { }

	// RVA: 0x7FFF60 Offset: 0x7FF160 VA: 0x1807FFF60
	private void InitializeGradient() { }

	// RVA: 0x800770 Offset: 0x7FF970 VA: 0x180800770
	private void UpdateGradientAlpha(float value) { }

	// RVA: 0x7FFF30 Offset: 0x7FF130 VA: 0x1807FFF30
	private static float GetPercentage(float min, float max, float input) { }

	// RVA: 0x8002E0 Offset: 0x7FF4E0 VA: 0x1808002E0
	private void OnScroll(float value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatMenuVoteTimer : MonoBehaviour // TypeDefIndex: 2526
{
	// Fields
	private const float HEIGHT = 0,4;
	[SerializeField]
	private TextMeshPro text; // 0x20
	[SerializeField]
	private RectTransform textRect; // 0x28
	[SerializeField]
	private SpriteRenderer[] backgrounds; // 0x30

	// Properties
	public float Height { get; }

	// Methods

	// RVA: 0x800BB0 Offset: 0x7FFDB0 VA: 0x180800BB0
	public float get_Height() { }

	// RVA: 0x800920 Offset: 0x7FFB20 VA: 0x180800920
	public void SetText(StringNames key, int value) { }

	// RVA: 0x800A30 Offset: 0x7FFC30 VA: 0x180800A30
	public void SetWidth(float width) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuickChatPreviewField.<>c__DisplayClass13_0 // TypeDefIndex: 2527
{
	// Fields
	public QuickChatPhrase rootPhrase; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x811980 Offset: 0x810B80 VA: 0x180811980
	internal bool <UpdatePreview>b__0(QuickChatPhrase x) { }
}

// Namespace: AmongUs.QuickChat
public class QuickChatPreviewField : AbstractChatInputField // TypeDefIndex: 2528
{
	// Fields
	[SerializeField]
	[Space(10)]
	private ChatInputFieldButton clearButton; // 0x40
	[SerializeField]
	private ChatInputFieldButton undoButton; // 0x48
	[SerializeField]
	private TextMeshPro warningText; // 0x50
	[SerializeField]
	private TextMeshPro text; // 0x58
	[SerializeField]
	private TextMeshPro placeholderText; // 0x60
	[CompilerGenerated]
	private Action OnClearPressedEvent; // 0x68
	[CompilerGenerated]
	private Action OnUndoPressedEvent; // 0x70

	// Methods

	[CompilerGenerated]
	// RVA: 0x8065D0 Offset: 0x8057D0 VA: 0x1808065D0
	public void add_OnClearPressedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x806710 Offset: 0x805910 VA: 0x180806710
	public void remove_OnClearPressedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x806670 Offset: 0x805870 VA: 0x180806670
	public void add_OnUndoPressedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8067B0 Offset: 0x8059B0 VA: 0x1808067B0
	public void remove_OnUndoPressedEvent(Action value) { }

	// RVA: 0x805980 Offset: 0x804B80 VA: 0x180805980 Slot: 4
	protected override void Awake() { }

	// RVA: 0x805B30 Offset: 0x804D30 VA: 0x180805B30 Slot: 9
	public override void Clear() { }

	// RVA: 0x8060F0 Offset: 0x8052F0 VA: 0x1808060F0
	public void UpdatePreview(QuickChatPhraseBuilder builder) { }

	// RVA: 0x805920 Offset: 0x804B20 VA: 0x180805920
	public void AnimateInvalidSend() { }

	// RVA: 0x805D60 Offset: 0x804F60 VA: 0x180805D60 Slot: 6
	protected override void OnTextFieldTransformChanged(Vector3 position, Vector2 size) { }

	// RVA: 0x805D30 Offset: 0x804F30 VA: 0x180805D30
	private void OnClearButtonPressed() { }

	// RVA: 0x805D50 Offset: 0x804F50 VA: 0x180805D50
	private void OnClearButtonSizeChanged() { }

	// RVA: 0x805FC0 Offset: 0x8051C0 VA: 0x180805FC0
	private void UpdateClearButtonTransform() { }

	// RVA: 0x805E80 Offset: 0x805080 VA: 0x180805E80
	private void OnUndoButtonPressed() { }

	// RVA: 0x805EA0 Offset: 0x8050A0 VA: 0x180805EA0
	private void OnUndoButtonSizeChanged() { }

	// RVA: 0x805EA0 Offset: 0x8050A0 VA: 0x180805EA0
	private void UpdateUndoButtonTransform() { }

	// RVA: 0x805B60 Offset: 0x804D60 VA: 0x180805B60
	private string GetQuickChatChatWarningStr() { }

	// RVA: 0x8065C0 Offset: 0x8057C0 VA: 0x1808065C0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedOptionNames // TypeDefIndex: 2529
{
	// Fields
	public int value__; // 0x0
	public const CategorizedOptionNames KillCooldown = 0;
	public const CategorizedOptionNames PlayerSpeed = 1;
	public const CategorizedOptionNames EmergencyMeetingCount = 2;
	public const CategorizedOptionNames EmergencyMeetingCooldown = 3;
	public const CategorizedOptionNames DiscussionTime = 4;
	public const CategorizedOptionNames VotingTime = 5;
	public const CategorizedOptionNames CrewmateVision = 6;
	public const CategorizedOptionNames HidingTime = 7;
	public const CategorizedOptionNames MaxTimeInVent = 8;
	public const CategorizedOptionNames ImposterVision = 9;
	public const CategorizedOptionNames FinalHideTime = 10;
	public const CategorizedOptionNames FinalHideImposterSpeed = 11;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedKillCooldown // TypeDefIndex: 2530
{
	// Fields
	public int value__; // 0x0
	public const CategorizedKillCooldown Low = 0;
	public const CategorizedKillCooldown Medium = 1;
	public const CategorizedKillCooldown High = 2;
	public const CategorizedKillCooldown VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedPlayerSpeed // TypeDefIndex: 2531
{
	// Fields
	public int value__; // 0x0
	public const CategorizedPlayerSpeed Low = 0;
	public const CategorizedPlayerSpeed Medium = 1;
	public const CategorizedPlayerSpeed High = 2;
	public const CategorizedPlayerSpeed VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedEmergencyMeetingCount // TypeDefIndex: 2532
{
	// Fields
	public int value__; // 0x0
	public const CategorizedEmergencyMeetingCount Low = 0;
	public const CategorizedEmergencyMeetingCount Medium = 1;
	public const CategorizedEmergencyMeetingCount High = 2;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedEmergencyMeetingCooldown // TypeDefIndex: 2533
{
	// Fields
	public int value__; // 0x0
	public const CategorizedEmergencyMeetingCooldown Low = 0;
	public const CategorizedEmergencyMeetingCooldown Medium = 1;
	public const CategorizedEmergencyMeetingCooldown High = 2;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedDiscussionTime // TypeDefIndex: 2534
{
	// Fields
	public int value__; // 0x0
	public const CategorizedDiscussionTime Low = 0;
	public const CategorizedDiscussionTime Medium = 1;
	public const CategorizedDiscussionTime High = 2;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedVotingTime // TypeDefIndex: 2535
{
	// Fields
	public int value__; // 0x0
	public const CategorizedVotingTime Low = 0;
	public const CategorizedVotingTime Medium = 1;
	public const CategorizedVotingTime High = 2;
	public const CategorizedVotingTime VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedCrewmateVision // TypeDefIndex: 2536
{
	// Fields
	public int value__; // 0x0
	public const CategorizedCrewmateVision Low = 0;
	public const CategorizedCrewmateVision Medium = 1;
	public const CategorizedCrewmateVision High = 2;
	public const CategorizedCrewmateVision VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedHidingTime // TypeDefIndex: 2537
{
	// Fields
	public int value__; // 0x0
	public const CategorizedHidingTime Low = 0;
	public const CategorizedHidingTime Medium = 1;
	public const CategorizedHidingTime High = 2;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedMaxTimeInVent // TypeDefIndex: 2538
{
	// Fields
	public int value__; // 0x0
	public const CategorizedMaxTimeInVent Low = 0;
	public const CategorizedMaxTimeInVent Medium = 1;
	public const CategorizedMaxTimeInVent High = 2;
	public const CategorizedMaxTimeInVent VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedImposterVision // TypeDefIndex: 2539
{
	// Fields
	public int value__; // 0x0
	public const CategorizedImposterVision Low = 0;
	public const CategorizedImposterVision Medium = 1;
	public const CategorizedImposterVision High = 2;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedFinalHideTime // TypeDefIndex: 2540
{
	// Fields
	public int value__; // 0x0
	public const CategorizedFinalHideTime Low = 0;
	public const CategorizedFinalHideTime Medium = 1;
	public const CategorizedFinalHideTime High = 2;
	public const CategorizedFinalHideTime VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
public enum CategorizedFinalImposterSpeed // TypeDefIndex: 2541
{
	// Fields
	public int value__; // 0x0
	public const CategorizedFinalImposterSpeed Low = 0;
	public const CategorizedFinalImposterSpeed Medium = 1;
	public const CategorizedFinalImposterSpeed High = 2;
	public const CategorizedFinalImposterSpeed VeryHigh = 3;
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class GameFiltersList // TypeDefIndex: 2542
{
	// Fields
	public List<GameFilterSet> FilterSets; // 0x10

	// Methods

	// RVA: 0x7F8C60 Offset: 0x7F7E60 VA: 0x1807F8C60
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class GameFilterSet // TypeDefIndex: 2543
{
	// Fields
	public GameModes GameMode; // 0x10
	public List<GameFilter> Filters; // 0x18

	// Methods

	// RVA: 0x7F8740 Offset: 0x7F7940 VA: 0x1807F8740
	public void .ctor(GameModes mode) { }

	// RVA: 0x7F86D0 Offset: 0x7F78D0 VA: 0x1807F86D0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class GameFilter // TypeDefIndex: 2544
{
	// Fields
	public const string FILTER_TYPE_BOOL = "bool";
	public const string FILTER_TYPE_INT = "int";
	public const string FILTER_TYPE_CATEGORIZED = "cat";
	public const string FILTER_TYPE_MAP = "map";
	public const string FILTER_TYPE_PLATFORM = "platform";
	public const string FILTER_TYPE_CHAT = "chat";
	public const string FILTER_TYPE_LANG = "languages";
	public string OptionType; // 0x10
	public string Key; // 0x18
	public string SubFilterString; // 0x20
	[CompilerGenerated]
	private ISubFilter <SubFilter>k__BackingField; // 0x28

	// Properties
	[JsonIgnore]
	public ISubFilter SubFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ISubFilter get_SubFilter() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_SubFilter(ISubFilter value) { }

	// RVA: 0x7F8B80 Offset: 0x7F7D80 VA: 0x1807F8B80
	public void .ctor(string key, ISubFilter subFilter) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void ModifySubFilter(ISubFilter subFilter) { }

	[JsonConstructor]
	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	private void .ctor(string optionType, string key, string subFilterString) { }

	[OnSerializing]
	// RVA: 0x7F87F0 Offset: 0x7F79F0 VA: 0x1807F87F0
	internal void OnSerializing(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x7F87C0 Offset: 0x7F79C0 VA: 0x1807F87C0
	internal void OnDeserialized(StreamingContext context) { }

	// RVA: 0x7F8850 Offset: 0x7F7A50 VA: 0x1807F8850
	private ISubFilter ResolveSubFilter(string type, string filterString) { }
}

// Namespace: AmongUs.Matchmaking
public interface ISubFilter // TypeDefIndex: 2545
{
	// Properties
	public abstract string FilterType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_FilterType();
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class BoolGameFilter : ISubFilter // TypeDefIndex: 2546
{
	// Fields
	public List<bool> AcceptedValues; // 0x10
	public BoolOptionNames OptionEnum; // 0x18
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x20

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F8050 Offset: 0x7F7250 VA: 0x1807F8050
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class IntGameFilter : ISubFilter // TypeDefIndex: 2547
{
	// Fields
	public List<int> AcceptedValues; // 0x10
	public Int32OptionNames OptionEnum; // 0x18
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x20

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F8DC0 Offset: 0x7F7FC0 VA: 0x1807F8DC0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class CategorizedGameFilter : ISubFilter // TypeDefIndex: 2548
{
	// Fields
	public List<int> AcceptedValues; // 0x10
	public CategorizedOptionNames OptionEnum; // 0x18
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x20

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F81B0 Offset: 0x7F73B0 VA: 0x1807F81B0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class MapGameFilter : ISubFilter // TypeDefIndex: 2549
{
	// Fields
	public byte AcceptedValues; // 0x10
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x18

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F8E40 Offset: 0x7F8040 VA: 0x1807F8E40
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class PlatformGameFilter : ISubFilter // TypeDefIndex: 2550
{
	// Fields
	public uint AcceptedValues; // 0x10
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x18

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F9020 Offset: 0x7F8220 VA: 0x1807F9020
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class ChatModeGameFilter : ISubFilter // TypeDefIndex: 2551
{
	// Fields
	public byte AcceptedValues; // 0x10
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x18

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F81F0 Offset: 0x7F73F0 VA: 0x1807F81F0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class LanguageFilter : ISubFilter // TypeDefIndex: 2552
{
	// Fields
	public uint AcceptedValues; // 0x10
	[CompilerGenerated]
	private readonly string <FilterType>k__BackingField; // 0x18

	// Properties
	public string FilterType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public string get_FilterType() { }

	// RVA: 0x7F8E00 Offset: 0x7F8000 VA: 0x1807F8E00
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
[Serializable]
public class PermittedFilters // TypeDefIndex: 2553
{
	// Fields
	[JsonProperty("filters")]
	public List<Filters> Filters; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: AmongUs.Matchmaking
public enum Filters // TypeDefIndex: 2554
{
	// Fields
	public int value__; // 0x0
	public const Filters Tags = 0;
	public const Filters PlayerSpeed = 1;
	public const Filters Roles = 2;
	public const Filters KillCooldown = 3;
	public const Filters VotingTime = 4;
	public const Filters NumImposters = 5;
	public const Filters VisualTasks = 6;
	public const Filters AnonymousVotes = 7;
	public const Filters ConfirmEjects = 8;
	public const Filters DiscussionTime = 9;
	public const Filters EmergencyCooldown = 10;
	public const Filters NumEmergencyMeetings = 11;
	public const Filters NumCommonTasks = 12;
	public const Filters NumShortTasks = 13;
	public const Filters NumLongTasks = 14;
	public const Filters KillDistance = 15;
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public abstract class BaseGameDataMessage : IGameDataMessage // TypeDefIndex: 2555
{
	// Properties
	public abstract GameDataTypes GameDataType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract GameDataTypes get_GameDataType();

	// RVA: 0x7F7F30 Offset: 0x7F7130 VA: 0x1807F7F30 Slot: 5
	public void Serialize(MessageWriter msg) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void SerializeValues(MessageWriter msg);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public abstract class BaseRpcMessage : BaseGameDataMessage // TypeDefIndex: 2556
{
	// Fields
	[CompilerGenerated]
	private readonly GameDataTypes <GameDataType>k__BackingField; // 0x10
	private readonly uint rpcObjectNetId; // 0x14

	// Properties
	public sealed override GameDataTypes GameDataType { get; }
	public abstract RpcCalls RpcType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 6
	public sealed override GameDataTypes get_GameDataType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract RpcCalls get_RpcType();

	// RVA: 0x7F8020 Offset: 0x7F7220 VA: 0x1807F8020
	public void .ctor(uint rpcObjectNetId) { }

	// RVA: 0x7F7FA0 Offset: 0x7F71A0 VA: 0x1807F7FA0 Slot: 7
	protected sealed override void SerializeValues(MessageWriter msg) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void SerializeRpcValues(MessageWriter msg);
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class DespawnGameDataMessage : BaseGameDataMessage // TypeDefIndex: 2557
{
	// Fields
	[CompilerGenerated]
	private readonly GameDataTypes <GameDataType>k__BackingField; // 0x10
	private readonly uint objToDespawnNetId; // 0x14

	// Properties
	public override GameDataTypes GameDataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 6
	public override GameDataTypes get_GameDataType() { }

	// RVA: 0x7F86A0 Offset: 0x7F78A0 VA: 0x1807F86A0
	public void .ctor(uint objToDespawnNetId) { }

	// RVA: 0x7F8670 Offset: 0x7F7870 VA: 0x1807F8670 Slot: 7
	protected override void SerializeValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public enum GameDataTypes // TypeDefIndex: 2558
{
	// Fields
	public byte value__; // 0x0
	public const GameDataTypes Invalid = 0;
	public const GameDataTypes DataFlag = 1;
	public const GameDataTypes RpcFlag = 2;
	public const GameDataTypes SpawnFlag = 4;
	public const GameDataTypes DespawnFlag = 5;
	public const GameDataTypes SceneChangeFlag = 6;
	public const GameDataTypes ReadyFlag = 7;
	public const GameDataTypes ChangeSettingsFlag_Deprecated = 8;
	public const GameDataTypes XboxDeclareXuid = 207;
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public interface IGameDataMessage // TypeDefIndex: 2559
{
	// Properties
	public abstract GameDataTypes GameDataType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameDataTypes get_GameDataType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Serialize(MessageWriter writer);
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcAddVoteBanMessage : BaseRpcMessage // TypeDefIndex: 2560
{
	// Fields
	private readonly int sourceClientId; // 0x18
	private readonly int clientIdToVoteBan; // 0x1C

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FDD0 Offset: 0x80EFD0 VA: 0x18080FDD0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FD80 Offset: 0x80EF80 VA: 0x18080FD80
	public void .ctor(uint rpcObjectNetId, int sourceClientId, int clientIdToVoteBan) { }

	// RVA: 0x80FD30 Offset: 0x80EF30 VA: 0x18080FD30 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcBootFromVentMessage : BaseRpcMessage // TypeDefIndex: 2561
{
	// Fields
	private readonly int ventId; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FE50 Offset: 0x80F050 VA: 0x18080FE50 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FE10 Offset: 0x80F010 VA: 0x18080FE10
	public void .ctor(uint rpcObjectNetId, int ventId) { }

	// RVA: 0x80FDE0 Offset: 0x80EFE0 VA: 0x18080FDE0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcCancelPetMessage : BaseRpcMessage // TypeDefIndex: 2562
{
	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FE60 Offset: 0x80F060 VA: 0x18080FE60 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x7F8020 Offset: 0x7F7220 VA: 0x1807F8020
	public void .ctor(uint rpcObjectNetId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcClimbLadderMessage : BaseRpcMessage // TypeDefIndex: 2563
{
	// Fields
	private readonly byte ladderId; // 0x18
	private readonly byte lastClimbLadderSid; // 0x19

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FF10 Offset: 0x80F110 VA: 0x18080FF10 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FEC0 Offset: 0x80F0C0 VA: 0x18080FEC0
	public void .ctor(uint rpcObjectNetId, byte ladderId, byte lastClimbLadderSid) { }

	// RVA: 0x80FE70 Offset: 0x80F070 VA: 0x18080FE70 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcCloseMeetingMessage : BaseRpcMessage // TypeDefIndex: 2564
{
	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FF20 Offset: 0x80F120 VA: 0x18080FF20 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x7F8020 Offset: 0x7F7220 VA: 0x1807F8020
	public void .ctor(uint rpcObjectNetId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcCompleteTaskMessage : BaseRpcMessage // TypeDefIndex: 2565
{
	// Fields
	private readonly uint idx; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FE10 Offset: 0x80F010 VA: 0x18080FE10
	public void .ctor(uint rpcObjectNetId, uint idx) { }

	// RVA: 0x80FDE0 Offset: 0x80EFE0 VA: 0x18080FDE0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcEnterVentMessage : BaseRpcMessage // TypeDefIndex: 2566
{
	// Fields
	private readonly int ventId; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FF30 Offset: 0x80F130 VA: 0x18080FF30 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FE10 Offset: 0x80F010 VA: 0x18080FE10
	public void .ctor(uint rpcObjectNetId, int ventId) { }

	// RVA: 0x80FDE0 Offset: 0x80EFE0 VA: 0x18080FDE0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcExitVentMessage : BaseRpcMessage // TypeDefIndex: 2567
{
	// Fields
	private readonly int ventId; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x80FF40 Offset: 0x80F140 VA: 0x18080FF40 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FE10 Offset: 0x80F010 VA: 0x18080FE10
	public void .ctor(uint rpcObjectNetId, int ventId) { }

	// RVA: 0x80FDE0 Offset: 0x80EFE0 VA: 0x18080FDE0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcPetMessage : BaseRpcMessage // TypeDefIndex: 2568
{
	// Fields
	private readonly Vector2 pos; // 0x18
	private readonly Vector2 petPos; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810040 Offset: 0x80F240 VA: 0x180810040 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FFF0 Offset: 0x80F1F0 VA: 0x18080FFF0
	public void .ctor(uint rpcObjectNetId, Vector2 pos, Vector2 petPos) { }

	// RVA: 0x80FF50 Offset: 0x80F150 VA: 0x18080FF50 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcPlayAnimationMessage : BaseRpcMessage // TypeDefIndex: 2569
{
	// Fields
	private readonly byte animType; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810080 Offset: 0x80F280 VA: 0x180810080
	public void .ctor(uint rpcObjectNetId, byte animType) { }

	// RVA: 0x810050 Offset: 0x80F250 VA: 0x180810050 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcReportDeadBodyMessage : BaseRpcMessage // TypeDefIndex: 2570
{
	// Fields
	private readonly byte targetPlayerId; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x8100C0 Offset: 0x80F2C0 VA: 0x1808100C0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810080 Offset: 0x80F280 VA: 0x180810080
	public void .ctor(uint rpcObjectNetId, byte targetPlayerId) { }

	// RVA: 0x810050 Offset: 0x80F250 VA: 0x180810050 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSendChatMessage : BaseRpcMessage // TypeDefIndex: 2571
{
	// Fields
	private readonly string chatText; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810140 Offset: 0x80F340 VA: 0x180810140 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810100 Offset: 0x80F300 VA: 0x180810100
	public void .ctor(uint rpcObjectNetId, string chatText) { }

	// RVA: 0x8100D0 Offset: 0x80F2D0 VA: 0x1808100D0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSendChatNoteMessage : BaseRpcMessage // TypeDefIndex: 2572
{
	// Fields
	private readonly byte srcPlayerId; // 0x18
	private readonly ChatNoteTypes noteType; // 0x1C

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x8101F0 Offset: 0x80F3F0 VA: 0x1808101F0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x8101A0 Offset: 0x80F3A0 VA: 0x1808101A0
	public void .ctor(uint rpcObjectNetId, byte srcPlayerId, ChatNoteTypes noteType) { }

	// RVA: 0x810150 Offset: 0x80F350 VA: 0x180810150 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSendQuickChatMessage : BaseRpcMessage // TypeDefIndex: 2573
{
	// Fields
	private readonly QuickChatPhraseBuilderResult quickChatData; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810210 Offset: 0x80F410 VA: 0x180810210 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810100 Offset: 0x80F300 VA: 0x180810100
	public void .ctor(uint rpcObjectNetId, QuickChatPhraseBuilderResult quickChatData) { }

	// RVA: 0x810200 Offset: 0x80F400 VA: 0x180810200 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetColorMessage : BaseRpcMessage // TypeDefIndex: 2574
{
	// Fields
	private readonly uint netIdToColor; // 0x18
	private readonly byte bodyColor; // 0x1C

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x7D20B0 Offset: 0x7D12B0 VA: 0x1807D20B0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810270 Offset: 0x80F470 VA: 0x180810270
	public void .ctor(uint rpcObjectNetId, uint netIdToColor, byte bodyColor) { }

	// RVA: 0x810220 Offset: 0x80F420 VA: 0x180810220 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetHatStrMessage : BaseRpcMessage // TypeDefIndex: 2575
{
	// Fields
	private readonly string hatId; // 0x18
	private readonly byte rpcSequenceId; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810360 Offset: 0x80F560 VA: 0x180810360 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810310 Offset: 0x80F510 VA: 0x180810310
	public void .ctor(uint rpcObjectNetId, string hatId, byte rpcSequenceId) { }

	// RVA: 0x8102C0 Offset: 0x80F4C0 VA: 0x1808102C0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetLevelMessage : BaseRpcMessage // TypeDefIndex: 2576
{
	// Fields
	private readonly uint level; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810370 Offset: 0x80F570 VA: 0x180810370 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FE10 Offset: 0x80F010 VA: 0x18080FE10
	public void .ctor(uint rpcObjectNetId, uint level) { }

	// RVA: 0x80FDE0 Offset: 0x80EFE0 VA: 0x18080FDE0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetNameMessage : BaseRpcMessage // TypeDefIndex: 2577
{
	// Fields
	private readonly uint netIdOfNamed; // 0x18
	private readonly string name; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810420 Offset: 0x80F620 VA: 0x180810420 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x8103D0 Offset: 0x80F5D0 VA: 0x1808103D0
	public void .ctor(uint rpcObjectNetId, uint netIdOfNamed, string name) { }

	// RVA: 0x810380 Offset: 0x80F580 VA: 0x180810380 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetNamePlateStrMessage : BaseRpcMessage // TypeDefIndex: 2578
{
	// Fields
	private readonly string namePlateId; // 0x18
	private readonly byte rpcSequenceId; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810430 Offset: 0x80F630 VA: 0x180810430 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810310 Offset: 0x80F510 VA: 0x180810310
	public void .ctor(uint rpcObjectNetId, string namePlateId, byte rpcSequenceId) { }

	// RVA: 0x8102C0 Offset: 0x80F4C0 VA: 0x1808102C0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetPetStrMessage : BaseRpcMessage // TypeDefIndex: 2579
{
	// Fields
	private readonly string petId; // 0x18
	private readonly byte rpcSequenceId; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810440 Offset: 0x80F640 VA: 0x180810440 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810310 Offset: 0x80F510 VA: 0x180810310
	public void .ctor(uint rpcObjectNetId, string petId, byte rpcSequenceId) { }

	// RVA: 0x8102C0 Offset: 0x80F4C0 VA: 0x1808102C0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetRoleMessage : BaseRpcMessage // TypeDefIndex: 2580
{
	// Fields
	private readonly RoleTypes roleType; // 0x18
	private readonly bool canOverrideRole; // 0x1A

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x8104F0 Offset: 0x80F6F0 VA: 0x1808104F0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x8104A0 Offset: 0x80F6A0 VA: 0x1808104A0
	public void .ctor(uint rpcObjectNetId, RoleTypes roleType, bool canOverrideRole) { }

	// RVA: 0x810450 Offset: 0x80F650 VA: 0x180810450 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetScannerMessage : BaseRpcMessage // TypeDefIndex: 2581
{
	// Fields
	private readonly bool value; // 0x18
	private readonly byte count; // 0x19

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810550 Offset: 0x80F750 VA: 0x180810550 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x80FEC0 Offset: 0x80F0C0 VA: 0x18080FEC0
	public void .ctor(uint rpcObjectNetId, bool value, byte count) { }

	// RVA: 0x810500 Offset: 0x80F700 VA: 0x180810500 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetSkinStrMessage : BaseRpcMessage // TypeDefIndex: 2582
{
	// Fields
	private readonly string skinId; // 0x18
	private readonly byte rpcSequenceId; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810560 Offset: 0x80F760 VA: 0x180810560 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810310 Offset: 0x80F510 VA: 0x180810310
	public void .ctor(uint rpcObjectNetId, string skinId, byte rpcSequenceId) { }

	// RVA: 0x8102C0 Offset: 0x80F4C0 VA: 0x1808102C0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetStartCounterMessage : BaseRpcMessage // TypeDefIndex: 2583
{
	// Fields
	private readonly int counterId; // 0x18
	private readonly sbyte secondsLeft; // 0x1C

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x8105C0 Offset: 0x80F7C0 VA: 0x1808105C0 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810270 Offset: 0x80F470 VA: 0x180810270
	public void .ctor(uint rpcObjectNetId, int counterId, sbyte secondsLeft) { }

	// RVA: 0x810570 Offset: 0x80F770 VA: 0x180810570 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetTasksMessage : BaseRpcMessage // TypeDefIndex: 2584
{
	// Fields
	private readonly byte[] taskTypeIds; // 0x18

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810600 Offset: 0x80F800 VA: 0x180810600 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810100 Offset: 0x80F300 VA: 0x180810100
	public void .ctor(uint rpcObjectNetId, byte[] taskTypeIds) { }

	// RVA: 0x8105D0 Offset: 0x80F7D0 VA: 0x1808105D0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcSetVisorStrMessage : BaseRpcMessage // TypeDefIndex: 2585
{
	// Fields
	private readonly string visorId; // 0x18
	private readonly byte rpcSequenceId; // 0x20

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810610 Offset: 0x80F810 VA: 0x180810610 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x810310 Offset: 0x80F510 VA: 0x180810310
	public void .ctor(uint rpcObjectNetId, string visorId, byte rpcSequenceId) { }

	// RVA: 0x8102C0 Offset: 0x80F4C0 VA: 0x1808102C0 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcUsePlatformMessage : BaseRpcMessage // TypeDefIndex: 2586
{
	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810620 Offset: 0x80F820 VA: 0x180810620 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x7F8020 Offset: 0x7F7220 VA: 0x1807F8020
	public void .ctor(uint rpcObjectNetId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class RpcVotingCompleteMessage : BaseRpcMessage // TypeDefIndex: 2587
{
	// Fields
	private readonly MeetingHud.VoterState[] voterStates; // 0x18
	private readonly byte exiledPlayerId; // 0x20
	private readonly bool tie; // 0x21

	// Properties
	public override RpcCalls RpcType { get; }

	// Methods

	// RVA: 0x810750 Offset: 0x80F950 VA: 0x180810750 Slot: 8
	public override RpcCalls get_RpcType() { }

	// RVA: 0x8106F0 Offset: 0x80F8F0 VA: 0x1808106F0
	public void .ctor(uint rpcObjectNetId, MeetingHud.VoterState[] voterStates, byte exiledPlayerId, bool tie) { }

	// RVA: 0x810630 Offset: 0x80F830 VA: 0x180810630 Slot: 9
	protected override void SerializeRpcValues(MessageWriter msg) { }
}

// Namespace: AmongUs.InnerNet.GameDataMessages
public class SpawnGameDataMessage : BaseGameDataMessage // TypeDefIndex: 2588
{
	// Fields
	[CompilerGenerated]
	private readonly GameDataTypes <GameDataType>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <NetObjectType>k__BackingField; // 0x18
	private readonly uint spawnTypeId; // 0x20
	private readonly int ownerId; // 0x24
	private readonly SpawnFlags flags; // 0x28
	private readonly InnerNetObject[] childNetObjects; // 0x30

	// Properties
	public override GameDataTypes GameDataType { get; }
	public Type NetObjectType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 6
	public override GameDataTypes get_GameDataType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_NetObjectType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_NetObjectType(Type value) { }

	// RVA: 0x810AA0 Offset: 0x80FCA0 VA: 0x180810AA0
	public void .ctor(InnerNetObject parentNetObject, int ownerId, SpawnFlags flags, InnerNetObject[] childNetObjects) { }

	// RVA: 0x810760 Offset: 0x80F960 VA: 0x180810760
	public void ClearOrDecrementChildObjectDirt() { }

	// RVA: 0x810800 Offset: 0x80FA00 VA: 0x180810800 Slot: 7
	protected override void SerializeValues(MessageWriter msg) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RetryableWebRequest.<CoSend>d__43 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2589
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RetryableWebRequest <>4__this; // 0x20
	public Logger logger; // 0x28
	private UnityWebRequest <request>5__2; // 0x30

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

	// RVA: 0x810E60 Offset: 0x810060 VA: 0x180810E60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8110D0 Offset: 0x8102D0 VA: 0x1808110D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.HTTP
public class RetryableWebRequest // TypeDefIndex: 2590
{
	// Fields
	private readonly Dictionary<string, string> requestHeaders; // 0x10
	private readonly byte[] body; // 0x18
	private Action<string> successCallback; // 0x20
	private Action<RetryableWebRequest> errorCallback; // 0x28
	[CompilerGenerated]
	private string <Url>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Method>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <ResponseCode>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <ResponseText>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x50

	// Properties
	public string Url { get; set; }
	public string Method { get; set; }
	public long ResponseCode { get; set; }
	public string ResponseText { get; set; }
	public string Error { get; set; }
	public bool IsSuccess { get; }
	public bool IsFailure { get; }
	public bool IsAuthError { get; }
	public bool IsTransientError { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Url() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	private void set_Url(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_Method(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public long get_ResponseCode() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	private void set_ResponseCode(long value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_ResponseText() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_ResponseText(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	private void set_Error(string value) { }

	// RVA: 0x8075A0 Offset: 0x8067A0 VA: 0x1808075A0
	public bool get_IsSuccess() { }

	// RVA: 0x807580 Offset: 0x806780 VA: 0x180807580
	public bool get_IsFailure() { }

	// RVA: 0x807570 Offset: 0x806770 VA: 0x180807570
	public bool get_IsAuthError() { }

	// RVA: 0x8075C0 Offset: 0x8067C0 VA: 0x1808075C0
	public bool get_IsTransientError() { }

	// RVA: 0x8074C0 Offset: 0x8066C0 VA: 0x1808074C0
	private void .ctor(string url, string method, byte[] body) { }

	// RVA: 0x807180 Offset: 0x806380 VA: 0x180807180
	public static RetryableWebRequest Head(string url) { }

	// RVA: 0x807110 Offset: 0x806310 VA: 0x180807110
	public static RetryableWebRequest Get(string url) { }

	// RVA: 0x8071F0 Offset: 0x8063F0 VA: 0x1808071F0
	public static RetryableWebRequest Post(string url, string body) { }

	// RVA: 0x8072A0 Offset: 0x8064A0 VA: 0x1808072A0
	public static RetryableWebRequest Post(string url, byte[] body) { }

	// RVA: 0x807320 Offset: 0x806520 VA: 0x180807320
	public static RetryableWebRequest Put(string url, string body) { }

	// RVA: 0x8073D0 Offset: 0x8065D0 VA: 0x1808073D0
	public static RetryableWebRequest Put(string url, byte[] body) { }

	// RVA: 0x8070A0 Offset: 0x8062A0 VA: 0x1808070A0
	public static RetryableWebRequest Delete(string url) { }

	// RVA: 0x807450 Offset: 0x806650 VA: 0x180807450
	public void SetOrReplaceRequestHeader(string name, string value) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void SetOrReplaceSuccessCallback(Action<string> callback) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void SetOrReplaceErrorCallback(Action<RetryableWebRequest> callback) { }

	[IteratorStateMachine(typeof(RetryableWebRequest.<CoSend>d__43))]
	// RVA: 0x807030 Offset: 0x806230 VA: 0x180807030
	public IEnumerator CoSend(Logger logger) { }

	// RVA: 0x806DE0 Offset: 0x805FE0 VA: 0x180806DE0
	private UnityWebRequest BuildRequest() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AbstractSaveData.<>c // TypeDefIndex: 2591
{
	// Fields
	public static readonly AbstractSaveData.<>c <>9; // 0x0
	public static Action<ISaveDataGroupControl> <>9__20_0; // 0x8
	public static Action<ISaveDataGroupControl> <>9__20_1; // 0x10
	public static Action<ISaveDataGroupControl> <>9__22_0; // 0x18
	public static Action<ISaveDataGroupControl> <>9__22_1; // 0x20

	// Methods

	// RVA: 0x811B00 Offset: 0x810D00 VA: 0x180811B00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8115F0 Offset: 0x8107F0 VA: 0x1808115F0
	internal void <ForceSave>b__20_0(ISaveDataGroupControl group) { }

	// RVA: 0x811640 Offset: 0x810840 VA: 0x180811640
	internal void <ForceSave>b__20_1(ISaveDataGroupControl group) { }

	// RVA: 0x811550 Offset: 0x810750 VA: 0x180811550
	internal void <ForceLoad>b__22_0(ISaveDataGroupControl group) { }

	// RVA: 0x8115A0 Offset: 0x8107A0 VA: 0x1808115A0
	internal void <ForceLoad>b__22_1(ISaveDataGroupControl group) { }
}

// Namespace: AmongUs.Data
public abstract class AbstractSaveData : AbstractSaveDataGroup // TypeDefIndex: 2592
{
	// Fields
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action OnSavedEvent; // 0x20
	[CompilerGenerated]
	private Action OnLoadedEvent; // 0x28
	[JsonProperty("dataVersion")]
	protected int dataVersion; // 0x30
	private const byte XOR_KEY = 212;

	// Properties
	public bool IsDirty { get; set; }
	protected abstract AbstractSaveDataGroup[] Groups { get; }
	protected virtual int CurrentVersion { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void set_IsDirty(bool value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract AbstractSaveDataGroup[] get_Groups();

	[CompilerGenerated]
	// RVA: 0x7F7730 Offset: 0x7F6930 VA: 0x1807F7730
	public void add_OnSavedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7F7870 Offset: 0x7F6A70 VA: 0x1807F7870
	public void remove_OnSavedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7F7690 Offset: 0x7F6890 VA: 0x1807F7690
	public void add_OnLoadedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7F77D0 Offset: 0x7F69D0 VA: 0x1807F77D0
	public void remove_OnLoadedEvent(Action value) { }

	// RVA: 0x7F74F0 Offset: 0x7F66F0 VA: 0x1807F74F0
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void HandleSave();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HandleLoad();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HandleDelete();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract bool HandleDoesFileExist();

	// RVA: 0x7F6D90 Offset: 0x7F5F90 VA: 0x1807F6D90 Slot: 9
	protected override void HandleChange() { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0
	public bool DoesFileExist() { }

	// RVA: 0x7F6DC0 Offset: 0x7F5FC0 VA: 0x1807F6DC0
	public void Save() { }

	// RVA: 0x7F6BA0 Offset: 0x7F5DA0 VA: 0x1807F6BA0
	public void ForceSave() { }

	// RVA: 0x7F6DB0 Offset: 0x7F5FB0 VA: 0x1807F6DB0
	public void Load() { }

	// RVA: 0x7F6980 Offset: 0x7F5B80 VA: 0x1807F6980
	public void ForceLoad() { }

	// RVA: 0x7F68F0 Offset: 0x7F5AF0 VA: 0x1807F68F0
	private void ForEachGroup(Action<ISaveDataGroupControl> action) { }

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760
	public void Delete() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 19
	protected virtual int get_CurrentVersion() { }

	// RVA: 0x7F6880 Offset: 0x7F5A80 VA: 0x1807F6880
	private void CheckVersionMigration() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	protected virtual void HandleVersionMigration(int version) { }

	// RVA: 0x7F6DD0 Offset: 0x7F5FD0 VA: 0x1807F6DD0
	protected static bool TrySaveToJsonFile(object value, string filename) { }

	// RVA: -1 Offset: -1
	protected static bool TryLoadFromJsonFile<T>(string filename, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E41D0 Offset: 0x8E33D0 VA: 0x1808E41D0
	|-AbstractSaveData.TryLoadFromJsonFile<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected static bool TryLoadAndOverwriteFromJsonFile<T>(T target, string filename) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3E60 Offset: 0x8E3060 VA: 0x1808E3E60
	|-AbstractSaveData.TryLoadAndOverwriteFromJsonFile<object>
	|
	|-RVA: 0x8E3A50 Offset: 0x8E2C50 VA: 0x1808E3A50
	|-AbstractSaveData.TryLoadAndOverwriteFromJsonFile<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F6FF0 Offset: 0x7F61F0 VA: 0x1807F6FF0
	protected bool TrySerializeAndEncrypt(object target, out byte[] output) { }

	// RVA: -1 Offset: -1
	protected bool TryDecryptAndDeserialize<T>(ref T target, byte[] encryptedBytes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E33E0 Offset: 0x8E25E0 VA: 0x1808E33E0
	|-AbstractSaveData.TryDecryptAndDeserialize<object>
	|
	|-RVA: 0x8E2D30 Offset: 0x8E1F30 VA: 0x1808E2D30
	|-AbstractSaveData.TryDecryptAndDeserialize<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: AmongUs.Data
public abstract class AbstractSaveDataGroup : ISaveDataGroupControl // TypeDefIndex: 2593
{
	// Fields
	[CompilerGenerated]
	private Action OnChangedEvent; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void SetValue<T>(ref T field, T value, Action onChangedCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E24C0 Offset: 0x8E16C0 VA: 0x1808E24C0
	|-AbstractSaveDataGroup.SetValue<bool>
	|
	|-RVA: 0x8E2680 Offset: 0x8E1880 VA: 0x1808E2680
	|-AbstractSaveDataGroup.SetValue<byte>
	|
	|-RVA: 0x8E25A0 Offset: 0x8E17A0 VA: 0x1808E25A0
	|-AbstractSaveDataGroup.SetValue<ByteEnum>
	|
	|-RVA: 0x8E2720 Offset: 0x8E1920 VA: 0x1808E2720
	|-AbstractSaveDataGroup.SetValue<DateTime>
	|
	|-RVA: 0x8E2AA0 Offset: 0x8E1CA0 VA: 0x1808E2AA0
	|-AbstractSaveDataGroup.SetValue<int>
	|
	|-RVA: 0x8E29C0 Offset: 0x8E1BC0 VA: 0x1808E29C0
	|-AbstractSaveDataGroup.SetValue<Int32Enum>
	|
	|-RVA: 0x8E2B40 Offset: 0x8E1D40 VA: 0x1808E2B40
	|-AbstractSaveDataGroup.SetValue<long>
	|
	|-RVA: 0x8E2BF0 Offset: 0x8E1DF0 VA: 0x1808E2BF0
	|-AbstractSaveDataGroup.SetValue<object>
	|
	|-RVA: 0x8E2C80 Offset: 0x8E1E80 VA: 0x1808E2C80
	|-AbstractSaveDataGroup.SetValue<float>
	|
	|-RVA: 0x8E2800 Offset: 0x8E1A00 VA: 0x1808E2800
	|-AbstractSaveDataGroup.SetValue<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x7F6740 Offset: 0x7F5940 VA: 0x1807F6740
	public void add_OnChangedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7F67E0 Offset: 0x7F59E0 VA: 0x1807F67E0
	public void remove_OnChangedEvent(Action value) { }

	// RVA: 0x7F6720 Offset: 0x7F5920 VA: 0x1807F6720 Slot: 9
	protected virtual void HandleChange() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	protected virtual void OnSaveStart() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	protected virtual void OnSaveComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	protected virtual void OnLoadStart() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	protected virtual void OnLoadComplete() { }

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700 Slot: 4
	private void AmongUs.Data.ISaveDataGroupControl.SaveStart() { }

	// RVA: 0x7F6700 Offset: 0x7F5900 VA: 0x1807F6700 Slot: 5
	private void AmongUs.Data.ISaveDataGroupControl.SaveComplete() { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 6
	private void AmongUs.Data.ISaveDataGroupControl.LoadStart() { }

	// RVA: 0x7C41D0 Offset: 0x7C33D0 VA: 0x1807C41D0 Slot: 7
	private void AmongUs.Data.ISaveDataGroupControl.LoadComplete() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: AmongUs.Data
public interface ISaveDataGroupControl // TypeDefIndex: 2594
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SaveStart();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SaveComplete();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LoadStart();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void LoadComplete();
}

// Namespace: AmongUs.Data
public abstract class AbstractUserSaveData : AbstractSaveData // TypeDefIndex: 2595
{
	// Properties
	protected abstract string FileName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract string get_FileName();

	// RVA: 0x7F7E00 Offset: 0x7F7000 VA: 0x1807F7E00 Slot: 15
	protected override void HandleSave() { }

	// RVA: 0x7F7AB0 Offset: 0x7F6CB0 VA: 0x1807F7AB0 Slot: 16
	protected override void HandleLoad() { }

	// RVA: 0x7F7930 Offset: 0x7F6B30 VA: 0x1807F7930 Slot: 17
	protected override void HandleDelete() { }

	// RVA: 0x7F7A00 Offset: 0x7F6C00 VA: 0x1807F7A00 Slot: 18
	protected override bool HandleDoesFileExist() { }

	// RVA: 0x7F7910 Offset: 0x7F6B10 VA: 0x1807F7910
	private string GetFileName() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private bool ShouldIncludeUserIdInPath() { }

	// RVA: 0x7F74F0 Offset: 0x7F66F0 VA: 0x1807F74F0
	protected void .ctor() { }
}

// Namespace: AmongUs.Data
public static class DataManager // TypeDefIndex: 2596
{
	// Fields
	private static PlayerData player; // 0x0
	private static SettingsData settings; // 0x8
	private static readonly Logger logger; // 0x10

	// Properties
	public static bool IsPlayerLoaded { get; }
	public static bool IsSettingsLoaded { get; }
	public static PlayerData Player { get; }
	public static SettingsData Settings { get; }
	public static Logger Logger { get; }

	// Methods

	// RVA: 0x7F8380 Offset: 0x7F7580 VA: 0x1807F8380
	public static bool get_IsPlayerLoaded() { }

	// RVA: 0x7F83E0 Offset: 0x7F75E0 VA: 0x1807F83E0
	public static bool get_IsSettingsLoaded() { }

	// RVA: 0x7F8490 Offset: 0x7F7690 VA: 0x1807F8490
	public static PlayerData get_Player() { }

	// RVA: 0x7F8580 Offset: 0x7F7780 VA: 0x1807F8580
	public static SettingsData get_Settings() { }

	// RVA: 0x7F8230 Offset: 0x7F7430 VA: 0x1807F8230
	public static void DeleteAll() { }

	// RVA: 0x7F8440 Offset: 0x7F7640 VA: 0x1807F8440
	public static Logger get_Logger() { }

	// RVA: 0x7F82C0 Offset: 0x7F74C0 VA: 0x1807F82C0
	private static void .cctor() { }
}

// Namespace: 
public class RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.PlayerInfo // TypeDefIndex: 2597
{
	// Fields
	public int id; // 0x10
	public bool hasKeyboard; // 0x14
	public bool hasMouse; // 0x15
	public RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks; // 0x18

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
public class RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.JoystickInfo // TypeDefIndex: 2598
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
private class RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo // TypeDefIndex: 2599
{
	// Fields
	public RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.PlayerInfo[] players; // 0x10

	// Properties
	public int playerCount { get; }

	// Methods

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230
	public int get_playerCount() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x818020 Offset: 0x817220 VA: 0x180818020
	public void .ctor(int playerCount) { }

	// RVA: 0x7270B0 Offset: 0x7262B0 VA: 0x1807270B0
	public int IndexOfPlayer(int playerId) { }

	// RVA: 0x727050 Offset: 0x726250 VA: 0x180727050
	public bool ContainsPlayer(int playerId) { }
}

// Namespace: 
private class RewiredUserDataStore_PlayerData.JoystickAssignmentHistoryInfo // TypeDefIndex: 2600
{
	// Fields
	public readonly Joystick joystick; // 0x10
	public readonly int oldJoystickId; // 0x18

	// Methods

	// RVA: 0x819260 Offset: 0x818460 VA: 0x180819260
	public void .ctor(Joystick joystick, int oldJoystickId) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewiredUserDataStore_PlayerData.<>c__DisplayClass60_0 // TypeDefIndex: 2601
{
	// Fields
	public Joystick joystick; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A270 Offset: 0x739470 VA: 0x18073A270
	internal bool <LoadJoystickAssignmentsNow>b__0(RewiredUserDataStore_PlayerData.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewiredUserDataStore_PlayerData.<>c__DisplayClass60_1 // TypeDefIndex: 2602
{
	// Fields
	public RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A290 Offset: 0x739490 VA: 0x18073A290
	internal bool <LoadJoystickAssignmentsNow>b__1(RewiredUserDataStore_PlayerData.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewiredUserDataStore_PlayerData.<>c__DisplayClass60_2 // TypeDefIndex: 2603
{
	// Fields
	public Joystick match; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x73A270 Offset: 0x739470 VA: 0x18073A270
	internal bool <LoadJoystickAssignmentsNow>b__2(RewiredUserDataStore_PlayerData.JoystickAssignmentHistoryInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RewiredUserDataStore_PlayerData.<LoadJoystickAssignmentsDeferred>d__62 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2604
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RewiredUserDataStore_PlayerData <>4__this; // 0x20

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

	// RVA: 0x82C720 Offset: 0x82B920 VA: 0x18082C720 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82C8A0 Offset: 0x82BAA0 VA: 0x18082C8A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.Data.Settings
public class RewiredUserDataStore_PlayerData : UserDataStore // TypeDefIndex: 2605
{
	// Fields
	private const string LEGACY_PLAYER_PREFS_KEY_PREFIX = "RewiredSaveData5";
	private const string logPrefix = "[RewiredUserDataStore_PlayerData]";
	private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";
	private const int controllerMapPPKeyVersion_original = 0;
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;
	private const int controllerMapPPKeyVersion = 2;
	private static readonly Logger logger; // 0x0
	[SerializeField]
	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	private bool isEnabled; // 0x20
	[SerializeField]
	[Tooltip("Should saved data be loaded on start?")]
	private bool loadDataOnStart; // 0x21
	[SerializeField]
	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	private bool loadKeyboardAssignments; // 0x22
	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	private bool loadJoystickAssignments; // 0x23
	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	private bool loadMouseAssignments; // 0x24
	private bool allowImpreciseJoystickAssignmentMatching; // 0x25
	private bool deferredJoystickAssignmentLoadPending; // 0x26
	private bool wasJoystickEverDetected; // 0x27
	private List<int> cachedAllActionIds; // 0x28
	private string cachedAllActionIdsString; // 0x30

	// Properties
	private string PlayerPrefsKey_ControllerAssignments { get; }
	private bool ShouldLoadControllerAssignments { get; }
	private List<int> AllActionIds { get; }
	private string AllActionIdsString { get; }

	// Methods

	// RVA: 0x80FCB0 Offset: 0x80EEB0 VA: 0x18080FCB0
	private string get_PlayerPrefsKey_ControllerAssignments() { }

	// RVA: 0x80FD10 Offset: 0x80EF10 VA: 0x18080FD10
	private bool get_ShouldLoadControllerAssignments() { }

	// RVA: 0x80FA10 Offset: 0x80EC10 VA: 0x18080FA10
	private List<int> get_AllActionIds() { }

	// RVA: 0x80F8E0 Offset: 0x80EAE0 VA: 0x18080F8E0
	private string get_AllActionIdsString() { }

	// RVA: 0x80F4C0 Offset: 0x80E6C0 VA: 0x18080F4C0 Slot: 21
	public override void Save() { }

	// RVA: 0x80DBE0 Offset: 0x80CDE0 VA: 0x18080DBE0 Slot: 22
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x80DEC0 Offset: 0x80D0C0 VA: 0x18080DEC0 Slot: 23
	public override void SaveControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x80F2E0 Offset: 0x80E4E0 VA: 0x18080F2E0 Slot: 24
	public override void SavePlayerData(int playerId) { }

	// RVA: 0x80E930 Offset: 0x80DB30 VA: 0x18080E930 Slot: 25
	public override void SaveInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x80C9B0 Offset: 0x80BBB0 VA: 0x18080C9B0 Slot: 16
	public override void Load() { }

	// RVA: 0x809EE0 Offset: 0x8090E0 VA: 0x180809EE0 Slot: 17
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x809C00 Offset: 0x808E00 VA: 0x180809C00 Slot: 18
	public override void LoadControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x80C800 Offset: 0x80BA00 VA: 0x18080C800 Slot: 19
	public override void LoadPlayerData(int playerId) { }

	// RVA: 0x80AAA0 Offset: 0x809CA0 VA: 0x18080AAA0 Slot: 20
	public override void LoadInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x80CF70 Offset: 0x80C170 VA: 0x18080CF70 Slot: 28
	protected override void OnInitialize() { }

	// RVA: 0x80CAA0 Offset: 0x80BCA0 VA: 0x18080CAA0 Slot: 29
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x80CE00 Offset: 0x80C000 VA: 0x18080CE00 Slot: 32
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x80CDE0 Offset: 0x80BFE0 VA: 0x18080CDE0 Slot: 30
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x80E050 Offset: 0x80D250 VA: 0x18080E050 Slot: 26
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x80A430 Offset: 0x809630 VA: 0x18080A430 Slot: 27
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x8094F0 Offset: 0x8086F0 VA: 0x1808094F0
	private int LoadAll() { }

	// RVA: 0x80C4D0 Offset: 0x80B6D0 VA: 0x18080C4D0
	private int LoadPlayerDataNow(int playerId) { }

	// RVA: 0x80C550 Offset: 0x80B750 VA: 0x18080C550
	private int LoadPlayerDataNow(Player player) { }

	// RVA: 0x809310 Offset: 0x808510 VA: 0x180809310
	private int LoadAllJoystickCalibrationData() { }

	// RVA: 0x80BD40 Offset: 0x80AF40 VA: 0x18080BD40
	private int LoadJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x80BCC0 Offset: 0x80AEC0 VA: 0x18080BCC0
	private int LoadJoystickCalibrationData(int joystickId) { }

	// RVA: 0x80BE50 Offset: 0x80B050 VA: 0x18080BE50
	private int LoadJoystickData(int joystickId) { }

	// RVA: 0x809B80 Offset: 0x808D80 VA: 0x180809B80
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x809B60 Offset: 0x808D60 VA: 0x180809B60
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x80A500 Offset: 0x809700 VA: 0x18080A500
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x80A240 Offset: 0x809440 VA: 0x18080A240
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x80ACB0 Offset: 0x809EB0 VA: 0x18080ACB0
	private int LoadInputBehaviors(int playerId) { }

	// RVA: 0x80A830 Offset: 0x809A30 VA: 0x18080A830
	private int LoadInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x80A910 Offset: 0x809B10 VA: 0x18080A910
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x8099B0 Offset: 0x808BB0 VA: 0x1808099B0
	private bool LoadControllerAssignmentsNow() { }

	// RVA: 0x80C0F0 Offset: 0x80B2F0 VA: 0x18080C0F0
	private bool LoadKeyboardAndMouseAssignmentsNow(RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x80AF50 Offset: 0x80A150 VA: 0x18080AF50
	private bool LoadJoystickAssignmentsNow(RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x8096F0 Offset: 0x8088F0 VA: 0x1808096F0
	private RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }

	[IteratorStateMachine(typeof(RewiredUserDataStore_PlayerData.<LoadJoystickAssignmentsDeferred>d__62))]
	// RVA: 0x80AEE0 Offset: 0x80A0E0 VA: 0x18080AEE0
	private IEnumerator LoadJoystickAssignmentsDeferred() { }

	// RVA: 0x80D330 Offset: 0x80C530 VA: 0x18080D330
	private void SaveAll() { }

	// RVA: 0x80F260 Offset: 0x80E460 VA: 0x18080F260
	private void SavePlayerDataNow(int playerId) { }

	// RVA: 0x80F0A0 Offset: 0x80E2A0 VA: 0x18080F0A0
	private void SavePlayerDataNow(Player player) { }

	// RVA: 0x80D0B0 Offset: 0x80C2B0 VA: 0x18080D0B0
	private void SaveAllJoystickCalibrationData() { }

	// RVA: 0x80EDB0 Offset: 0x80DFB0 VA: 0x18080EDB0
	private void SaveJoystickCalibrationData(int joystickId) { }

	// RVA: 0x80ECF0 Offset: 0x80DEF0 VA: 0x18080ECF0
	private void SaveJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x80EE30 Offset: 0x80E030 VA: 0x18080EE30
	private void SaveJoystickData(int joystickId) { }

	// RVA: 0x80DB70 Offset: 0x80CD70 VA: 0x18080DB70
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x80DBC0 Offset: 0x80CDC0 VA: 0x18080DBC0
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x80E540 Offset: 0x80D740 VA: 0x18080E540
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x80E410 Offset: 0x80D610 VA: 0x18080E410
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x80E0F0 Offset: 0x80D2F0 VA: 0x18080E0F0
	private void SaveControllerMap(Player player, ControllerMap controllerMap) { }

	// RVA: 0x80EBD0 Offset: 0x80DDD0 VA: 0x18080EBD0
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x80E730 Offset: 0x80D930 VA: 0x18080E730
	private void SaveInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x80E880 Offset: 0x80DA80 VA: 0x18080E880
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x80D5C0 Offset: 0x80C7C0 VA: 0x18080D5C0
	private bool SaveControllerAssignments() { }

	// RVA: 0x807E70 Offset: 0x807070 VA: 0x180807E70
	private string GetBasePlayerPrefsKey(Player player) { }

	// RVA: 0x8086D0 Offset: 0x8078D0 VA: 0x1808086D0
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x807EE0 Offset: 0x8070E0 VA: 0x180807EE0
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x808250 Offset: 0x807450 VA: 0x180808250
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x8090D0 Offset: 0x8082D0 VA: 0x1808090D0
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) { }

	// RVA: 0x808F00 Offset: 0x808100 VA: 0x180808F00
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) { }

	// RVA: 0x808990 Offset: 0x807B90 VA: 0x180808990
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x808020 Offset: 0x807220 VA: 0x180808020
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x809220 Offset: 0x808420 VA: 0x180809220
	private string GetJoystickCalibrationMapXml(Joystick joystick) { }

	// RVA: 0x808FD0 Offset: 0x8081D0 VA: 0x180808FD0
	private string GetInputBehaviorXml(Player player, int id) { }

	// RVA: 0x8075F0 Offset: 0x8067F0 VA: 0x1808075F0
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) { }

	// RVA: 0x807B60 Offset: 0x806D60 VA: 0x180807B60
	private bool ControllerAssignmentSaveDataExists() { }

	// RVA: 0x807CE0 Offset: 0x806EE0 VA: 0x180807CE0
	private Joystick FindJoystickPrecise(RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }

	// RVA: 0x80F560 Offset: 0x80E760 VA: 0x18080F560
	private bool TryFindJoysticksImprecise(RewiredUserDataStore_PlayerData.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches) { }

	// RVA: 0x808AD0 Offset: 0x807CD0 VA: 0x180808AD0
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) { }

	// RVA: 0x80D020 Offset: 0x80C220 VA: 0x18080D020
	private void RefreshLayoutManager(int playerId) { }

	// RVA: 0x808810 Offset: 0x807A10 VA: 0x180808810
	private static Type GetControllerMapType(ControllerType controllerType) { }

	// RVA: 0x80F8C0 Offset: 0x80EAC0 VA: 0x18080F8C0
	public void .ctor() { }

	// RVA: 0x80F800 Offset: 0x80EA00 VA: 0x18080F800
	private static void .cctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class AccessibilitySettingsData : AbstractSaveDataGroup // TypeDefIndex: 2606
{
	// Fields
	public const bool DEFAULT_COLOR_BLIND_MODE = False;
	[JsonProperty("colorBlindMode")]
	private bool colorBlindMode; // 0x18
	[CompilerGenerated]
	private Action OnColorBlindModeChanged; // 0x20

	// Properties
	public bool ColorBlindMode { get; set; }

	// Methods

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_ColorBlindMode() { }

	// RVA: 0x811F70 Offset: 0x811170 VA: 0x180811F70
	public void set_ColorBlindMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0x811E30 Offset: 0x811030 VA: 0x180811E30
	public void add_OnColorBlindModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x811ED0 Offset: 0x8110D0 VA: 0x180811ED0
	public void remove_OnColorBlindModeChanged(Action value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class AudioSettingsData : AbstractSaveDataGroup // TypeDefIndex: 2607
{
	// Fields
	public const float DEFAULT_MUSIC_VOLUME = 0,6;
	public const float DEFAULT_AMBIENCE_VOLUME = 0,6;
	public const float DEFAULT_SFX_VOLUME = 0,6;
	[JsonProperty("musicVolume")]
	private float musicVolume; // 0x18
	[JsonProperty("ambienceVolume")]
	private float ambienceVolume; // 0x1C
	[JsonProperty("sfxVolume")]
	private float sfxVolume; // 0x20
	[CompilerGenerated]
	private Action OnMusicVolumeChanged; // 0x28
	[CompilerGenerated]
	private Action OnAmbienceVolumeChanged; // 0x30
	[CompilerGenerated]
	private Action OnSfxVolumeChanged; // 0x38

	// Properties
	public float MusicVolume { get; set; }
	public float AmbienceVolume { get; set; }
	public float SfxVolume { get; set; }

	// Methods

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_MusicVolume() { }

	// RVA: 0x817F20 Offset: 0x817120 VA: 0x180817F20
	public void set_MusicVolume(float value) { }

	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_AmbienceVolume() { }

	// RVA: 0x817EA0 Offset: 0x8170A0 VA: 0x180817EA0
	public void set_AmbienceVolume(float value) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_SfxVolume() { }

	// RVA: 0x817FA0 Offset: 0x8171A0 VA: 0x180817FA0
	public void set_SfxVolume(float value) { }

	[CompilerGenerated]
	// RVA: 0x817B80 Offset: 0x816D80 VA: 0x180817B80
	public void add_OnMusicVolumeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x817D60 Offset: 0x816F60 VA: 0x180817D60
	public void remove_OnMusicVolumeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x817AE0 Offset: 0x816CE0 VA: 0x180817AE0
	public void add_OnAmbienceVolumeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x817CC0 Offset: 0x816EC0 VA: 0x180817CC0
	public void remove_OnAmbienceVolumeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x817C20 Offset: 0x816E20 VA: 0x180817C20
	public void add_OnSfxVolumeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x817E00 Offset: 0x817000 VA: 0x180817E00
	public void remove_OnSfxVolumeChanged(Action value) { }

	// RVA: 0x817AC0 Offset: 0x816CC0 VA: 0x180817AC0
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class GameplaySettingsData : AbstractSaveDataGroup // TypeDefIndex: 2608
{
	// Fields
	public const bool DEFAULT_SCREEN_SHAKE = True;
	public const bool DEFAULT_STREAMER_MODE = False;
	[JsonProperty("screenShake")]
	private bool screenShake; // 0x18
	[JsonProperty("streamerMode")]
	private bool streamerMode; // 0x19
	[CompilerGenerated]
	private Action OnScreenShakeChanged; // 0x20
	[CompilerGenerated]
	private Action OnStreamerModeChanged; // 0x28

	// Properties
	public bool ScreenShake { get; set; }
	public bool StreamerMode { get; set; }

	// Methods

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_ScreenShake() { }

	// RVA: 0x818520 Offset: 0x817720 VA: 0x180818520
	public void set_ScreenShake(bool value) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_StreamerMode() { }

	// RVA: 0x8185A0 Offset: 0x8177A0 VA: 0x1808185A0
	public void set_StreamerMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8182A0 Offset: 0x8174A0 VA: 0x1808182A0
	public void add_OnScreenShakeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8183E0 Offset: 0x8175E0 VA: 0x1808183E0
	public void remove_OnScreenShakeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818340 Offset: 0x817540 VA: 0x180818340
	public void add_OnStreamerModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818480 Offset: 0x817680 VA: 0x180818480
	public void remove_OnStreamerModeChanged(Action value) { }

	// RVA: 0x818290 Offset: 0x817490 VA: 0x180818290
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class InputSettingsData : AbstractSaveDataGroup // TypeDefIndex: 2609
{
	// Fields
	public const ControlTypes DEFAULT_INPUT_MODE = 2;
	public const bool DEFAULT_MOUSE_MOVEMENT_ENABLED = False;
	public const float DEFAULT_TOUCH_JOYSTICK_SIZE = 1;
	private const string INIT_KEY = "initialization";
	private const string INIT_VALUE_DEFAULT = "uninitialized";
	private const string INIT_VALUE_INITIALIZED = "initialized";
	[JsonProperty("inputMode")]
	private ControlTypes inputMode; // 0x18
	[JsonProperty("mouseMovementEnabled")]
	private bool mouseMovementEnabled; // 0x1C
	[JsonProperty("touchJoystickSize")]
	private float touchJoystickSize; // 0x20
	[JsonProperty("inputData")]
	private Dictionary<string, string> inputData; // 0x28
	[CompilerGenerated]
	private Action OnInputModeChanged; // 0x30
	[CompilerGenerated]
	private Action OnMouseMovementEnabledChanged; // 0x38
	[CompilerGenerated]
	private Action OnTouchJoystickSizeChanged; // 0x40
	[CompilerGenerated]
	private Action OnInputDataChanged; // 0x48

	// Properties
	public ControlTypes InputMode { get; set; }
	public bool MouseMovementEnabled { get; set; }
	public float TouchJoystickSize { get; set; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControlTypes get_InputMode() { }

	// RVA: 0x8190D0 Offset: 0x8182D0 VA: 0x1808190D0
	public void set_InputMode(ControlTypes value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_MouseMovementEnabled() { }

	// RVA: 0x819160 Offset: 0x818360 VA: 0x180819160
	public void set_MouseMovementEnabled(bool value) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_TouchJoystickSize() { }

	// RVA: 0x8191E0 Offset: 0x8183E0 VA: 0x1808191E0
	public void set_TouchJoystickSize(float value) { }

	[CompilerGenerated]
	// RVA: 0x818C70 Offset: 0x817E70 VA: 0x180818C70
	public void add_OnInputModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818EF0 Offset: 0x8180F0 VA: 0x180818EF0
	public void remove_OnInputModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818D10 Offset: 0x817F10 VA: 0x180818D10
	public void add_OnMouseMovementEnabledChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818F90 Offset: 0x818190 VA: 0x180818F90
	public void remove_OnMouseMovementEnabledChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818DB0 Offset: 0x817FB0 VA: 0x180818DB0
	public void add_OnTouchJoystickSizeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x819030 Offset: 0x818230 VA: 0x180819030
	public void remove_OnTouchJoystickSizeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818BD0 Offset: 0x817DD0 VA: 0x180818BD0
	public void add_OnInputDataChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x818E50 Offset: 0x818050 VA: 0x180818E50
	public void remove_OnInputDataChanged(Action value) { }

	// RVA: 0x818780 Offset: 0x817980 VA: 0x180818780 Slot: 13
	protected override void OnLoadComplete() { }

	// RVA: 0x8188F0 Offset: 0x817AF0 VA: 0x1808188F0 Slot: 10
	protected override void OnSaveStart() { }

	// RVA: 0x8187A0 Offset: 0x8179A0 VA: 0x1808187A0 Slot: 11
	protected override void OnSaveComplete() { }

	// RVA: 0x818A70 Offset: 0x817C70 VA: 0x180818A70
	private static ControlTypes ValidateInputMode(ControlTypes mode) { }

	// RVA: 0x818710 Offset: 0x817910 VA: 0x180818710
	public bool HasInputDataValue(string key) { }

	// RVA: 0x818620 Offset: 0x817820 VA: 0x180818620
	public string GetInputDataValue(string key) { }

	// RVA: 0x8189D0 Offset: 0x817BD0 VA: 0x1808189D0
	public void SetInputDataValue(string key, string value) { }

	// RVA: 0x818B00 Offset: 0x817D00 VA: 0x180818B00
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class LanguageSettingsData : AbstractSaveDataGroup // TypeDefIndex: 2610
{
	// Fields
	public const string DEFAULT_LANGUAGE = "none";
	public const SupportedLangs DEFAULT_CACHED_LANGUAGE = -1;
	[JsonProperty("currentLanguage")]
	private string language; // 0x18
	private SupportedLangs cachedLanguage; // 0x20
	[CompilerGenerated]
	private Action OnLanguageChanged; // 0x28

	// Properties
	public SupportedLangs CurrentLanguage { get; set; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public SupportedLangs get_CurrentLanguage() { }

	// RVA: 0x819710 Offset: 0x818910 VA: 0x180819710
	public void set_CurrentLanguage(SupportedLangs value) { }

	[CompilerGenerated]
	// RVA: 0x8195D0 Offset: 0x8187D0 VA: 0x1808195D0
	public void add_OnLanguageChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x819670 Offset: 0x818870 VA: 0x180819670
	public void remove_OnLanguageChanged(Action value) { }

	// RVA: 0x819470 Offset: 0x818670 VA: 0x180819470 Slot: 10
	protected override void OnSaveStart() { }

	// RVA: 0x8192F0 Offset: 0x8184F0 VA: 0x1808192F0 Slot: 13
	protected override void OnLoadComplete() { }

	// RVA: 0x819580 Offset: 0x818780 VA: 0x180819580
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MultiplayerSettingsData.<>c__DisplayClass123_0 // TypeDefIndex: 2611
{
	// Fields
	public StringNames key; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x651FA0 Offset: 0x6511A0 VA: 0x180651FA0
	internal bool <RemoveQuickChatFavorite>b__0(StringNames x) { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class MultiplayerSettingsData : AbstractSaveDataGroup // TypeDefIndex: 2612
{
	// Fields
	public const bool DEFAULT_CROSS_PLAY = True;
	public const bool DEFAULT_ALLOW_FRIEND_INVITES = True;
	public const bool DEFAULT_CENSOR_CHAT = True;
	public const QuickChatModes DEFAULT_CHAT_MODE = 1;
	public const GameModes DEFAULT_LAST_PLAYED_GAMEMODE = 1;
	public static readonly StringNames[] DEFAULT_QUICK_CHAT_FAVORITES; // 0x0
	public static readonly byte[] DEFAULT_RAW_GAME_OPTIONS; // 0x8
	public static readonly DateTime DEFAULT_FILTER_DATE; // 0x10
	public static readonly string[] DEFAULT_FILTER_TAGS; // 0x18
	public static readonly GameFilterOptions DEFAULT_VALID_GAME_FILTER_OPTIONS; // 0x20
	public static readonly GameFilterOptions DEFAULT_HOST_GAME_FILTER_OPTIONS; // 0x28
	public static readonly GameFilterOptions DEFAULT_SEARCH_GAME_FILTER_OPTIONS; // 0x30
	public static readonly Dictionary<string, string> DEFAULT_FILTER_DICTIONARY; // 0x38
	public static readonly GameFilterSet DEFAULT_GAMEFILTER_SET; // 0x40
	public static readonly GameFilterSet DEFAULT_HNSFILTER_SET; // 0x48
	[JsonProperty("crossPlay")]
	private bool crossPlay; // 0x18
	[JsonProperty("allowFriendInvites")]
	private bool allowFriendInvites; // 0x19
	[JsonProperty("censorChat")]
	private bool censorChat; // 0x1A
	[JsonProperty("chatMode")]
	private QuickChatModes chatMode; // 0x1C
	[JsonProperty("quickChatFavs")]
	private List<StringNames> quickChatFavorites; // 0x20
	[JsonProperty("lastPlayedGameMode")]
	private GameModes lastPlayedGameMode; // 0x28
	[JsonProperty("normalHostOptions")]
	private byte[] rawNormalHostOptions; // 0x30
	[JsonProperty("normalSearchOptions")]
	private byte[] rawNormalSearchOptions; // 0x38
	[JsonProperty("hideNSeekHostOptions")]
	private byte[] rawHideNSeekHostOptions; // 0x40
	[JsonProperty("hideNSeekSearchOptions")]
	private byte[] rawHideNSeekSearchOptions; // 0x48
	[JsonProperty("gameFilterRefreshDate")]
	private DateTime validGameFilterLastRefreshDate; // 0x50
	[JsonProperty("gameFilterTags")]
	private string[] validGameFilterTags; // 0x58
	[JsonProperty("hostFilterTags")]
	private string[] hostGameFilterTags; // 0x60
	[JsonProperty("searchFilterTags")]
	private string[] searchGameFilterTags; // 0x68
	[JsonProperty("filterDictionary")]
	private Dictionary<string, string> filterDictionary; // 0x70
	[JsonProperty("classicFilterSet")]
	private GameFilterSet classicFilterSet; // 0x78
	[JsonProperty("hnsFilterSet")]
	private GameFilterSet hnsFilterSet; // 0x80
	private GameFilterOptions validGameFilterOptions; // 0x88
	private GameFilterOptions hostGameFilterOptions; // 0x90
	private GameFilterOptions searchGameFilterOptions; // 0x98
	[CompilerGenerated]
	private Action OnCrossPlayChanged; // 0xA0
	[CompilerGenerated]
	private Action OnAllowFriendInvitesChanged; // 0xA8
	[CompilerGenerated]
	private Action OnCensorChatChanged; // 0xB0
	[CompilerGenerated]
	private Action OnChatModeChanged; // 0xB8
	[CompilerGenerated]
	private Action OnQuickChatFavoritesChanged; // 0xC0
	[CompilerGenerated]
	private Action OnLastPlayedGameModeChanged; // 0xC8
	[CompilerGenerated]
	private Action OnNormalHostOptionsChanged; // 0xD0
	[CompilerGenerated]
	private Action OnNormalSearchOptionsChanged; // 0xD8
	[CompilerGenerated]
	private Action OnHideNSeekHostOptionsChanged; // 0xE0
	[CompilerGenerated]
	private Action OnHideNSeekSearchOptionsChanged; // 0xE8
	[CompilerGenerated]
	private Action OnValidGameFilterOptionsChanged; // 0xF0
	[CompilerGenerated]
	private Action OnHostGameFilterOptionsChanged; // 0xF8
	[CompilerGenerated]
	private Action OnSearchGameFilterOptionsChanged; // 0x100
	[CompilerGenerated]
	private Action OnGameFilterChanged; // 0x108

	// Properties
	public bool CrossPlay { get; set; }
	public bool AllowFriendInvites { get; set; }
	public bool CensorChat { get; set; }
	public QuickChatModes ChatMode { get; set; }
	public GameModes LastPlayedGameMode { get; set; }
	public byte[] RawNormalHostOptions { get; set; }
	public byte[] RawNormalSearchOptions { get; set; }
	public byte[] RawHideNSeekHostOptions { get; set; }
	public byte[] RawHideNSeekSearchOptions { get; set; }
	public GameFilterOptions ValidGameFilterOptions { get; set; }
	public GameFilterOptions HostGameFilterOptions { get; set; }
	public GameFilterOptions SearchGameFilterOptions { get; set; }
	public GameFilterSet ClassicFilterSet { get; set; }
	public GameFilterSet HnSFilterSet { get; set; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_CrossPlay() { }

	// RVA: 0x81FC60 Offset: 0x81EE60 VA: 0x18081FC60
	public void set_CrossPlay(bool value) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_AllowFriendInvites() { }

	// RVA: 0x81FAC0 Offset: 0x81ECC0 VA: 0x18081FAC0
	public void set_AllowFriendInvites(bool value) { }

	// RVA: 0x81F0F0 Offset: 0x81E2F0 VA: 0x18081F0F0
	public bool get_CensorChat() { }

	// RVA: 0x81FB40 Offset: 0x81ED40 VA: 0x18081FB40
	public void set_CensorChat(bool value) { }

	// RVA: 0x81F100 Offset: 0x81E300 VA: 0x18081F100
	public QuickChatModes get_ChatMode() { }

	// RVA: 0x81FBC0 Offset: 0x81EDC0 VA: 0x18081FBC0
	public void set_ChatMode(QuickChatModes value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public GameModes get_LastPlayedGameMode() { }

	// RVA: 0x81FD90 Offset: 0x81EF90 VA: 0x18081FD90
	public void set_LastPlayedGameMode(GameModes value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public byte[] get_RawNormalHostOptions() { }

	// RVA: 0x81FF10 Offset: 0x81F110 VA: 0x18081FF10
	public void set_RawNormalHostOptions(byte[] value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public byte[] get_RawNormalSearchOptions() { }

	// RVA: 0x81FF90 Offset: 0x81F190 VA: 0x18081FF90
	public void set_RawNormalSearchOptions(byte[] value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public byte[] get_RawHideNSeekHostOptions() { }

	// RVA: 0x81FE10 Offset: 0x81F010 VA: 0x18081FE10
	public void set_RawHideNSeekHostOptions(byte[] value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public byte[] get_RawHideNSeekSearchOptions() { }

	// RVA: 0x81FE90 Offset: 0x81F090 VA: 0x18081FE90
	public void set_RawHideNSeekSearchOptions(byte[] value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public GameFilterOptions get_ValidGameFilterOptions() { }

	// RVA: 0x8200A0 Offset: 0x81F2A0 VA: 0x1808200A0
	public void set_ValidGameFilterOptions(GameFilterOptions value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public GameFilterOptions get_HostGameFilterOptions() { }

	// RVA: 0x81FD00 Offset: 0x81EF00 VA: 0x18081FD00
	public void set_HostGameFilterOptions(GameFilterOptions value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public GameFilterOptions get_SearchGameFilterOptions() { }

	// RVA: 0x820010 Offset: 0x81F210 VA: 0x180820010
	public void set_SearchGameFilterOptions(GameFilterOptions value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public GameFilterSet get_ClassicFilterSet() { }

	// RVA: 0x81FC40 Offset: 0x81EE40 VA: 0x18081FC40
	public void set_ClassicFilterSet(GameFilterSet value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public GameFilterSet get_HnSFilterSet() { }

	// RVA: 0x81FCE0 Offset: 0x81EEE0 VA: 0x18081FCE0
	public void set_HnSFilterSet(GameFilterSet value) { }

	[CompilerGenerated]
	// RVA: 0x81E960 Offset: 0x81DB60 VA: 0x18081E960
	public void add_OnCrossPlayChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F330 Offset: 0x81E530 VA: 0x18081F330
	public void remove_OnCrossPlayChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81E750 Offset: 0x81D950 VA: 0x18081E750
	public void add_OnAllowFriendInvitesChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F120 Offset: 0x81E320 VA: 0x18081F120
	public void remove_OnAllowFriendInvitesChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81E800 Offset: 0x81DA00 VA: 0x18081E800
	public void add_OnCensorChatChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F1D0 Offset: 0x81E3D0 VA: 0x18081F1D0
	public void remove_OnCensorChatChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81E8B0 Offset: 0x81DAB0 VA: 0x18081E8B0
	public void add_OnChatModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F280 Offset: 0x81E480 VA: 0x18081F280
	public void remove_OnChatModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EEE0 Offset: 0x81E0E0 VA: 0x18081EEE0
	public void add_OnQuickChatFavoritesChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F8B0 Offset: 0x81EAB0 VA: 0x18081F8B0
	public void remove_OnQuickChatFavoritesChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81ECD0 Offset: 0x81DED0 VA: 0x18081ECD0
	public void add_OnLastPlayedGameModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F6A0 Offset: 0x81E8A0 VA: 0x18081F6A0
	public void remove_OnLastPlayedGameModeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81ED80 Offset: 0x81DF80 VA: 0x18081ED80
	public void add_OnNormalHostOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F750 Offset: 0x81E950 VA: 0x18081F750
	public void remove_OnNormalHostOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EE30 Offset: 0x81E030 VA: 0x18081EE30
	public void add_OnNormalSearchOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F800 Offset: 0x81EA00 VA: 0x18081F800
	public void remove_OnNormalSearchOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EAC0 Offset: 0x81DCC0 VA: 0x18081EAC0
	public void add_OnHideNSeekHostOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F490 Offset: 0x81E690 VA: 0x18081F490
	public void remove_OnHideNSeekHostOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EB70 Offset: 0x81DD70 VA: 0x18081EB70
	public void add_OnHideNSeekSearchOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F540 Offset: 0x81E740 VA: 0x18081F540
	public void remove_OnHideNSeekSearchOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F040 Offset: 0x81E240 VA: 0x18081F040
	public void add_OnValidGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81FA10 Offset: 0x81EC10 VA: 0x18081FA10
	public void remove_OnValidGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EC20 Offset: 0x81DE20 VA: 0x18081EC20
	public void add_OnHostGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F5F0 Offset: 0x81E7F0 VA: 0x18081F5F0
	public void remove_OnHostGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81E190 VA: 0x18081EF90
	public void add_OnSearchGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F960 Offset: 0x81EB60 VA: 0x18081F960
	public void remove_OnSearchGameFilterOptionsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81EA10 Offset: 0x81DC10 VA: 0x18081EA10
	public void add_OnGameFilterChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x81F3E0 Offset: 0x81E5E0 VA: 0x18081F3E0
	public void remove_OnGameFilterChanged(Action value) { }

	// RVA: 0x81DCC0 Offset: 0x81CEC0 VA: 0x18081DCC0 Slot: 10
	protected override void OnSaveStart() { }

	// RVA: 0x81DBA0 Offset: 0x81CDA0 VA: 0x18081DBA0 Slot: 13
	protected override void OnLoadComplete() { }

	// RVA: 0x81DB30 Offset: 0x81CD30 VA: 0x18081DB30
	public bool HasQuickChatFavorite(StringNames key) { }

	// RVA: 0x81DA30 Offset: 0x81CC30 VA: 0x18081DA30
	public void AddQuickChatFavorite(StringNames key) { }

	// RVA: 0x81DD80 Offset: 0x81CF80 VA: 0x18081DD80
	public void RemoveQuickChatFavorite(StringNames key) { }

	// RVA: 0x81DEC0 Offset: 0x81D0C0 VA: 0x18081DEC0
	public void ValidateFilterTags() { }

	// RVA: 0x81E540 Offset: 0x81D740 VA: 0x18081E540
	public void .ctor() { }

	// RVA: 0x81E310 Offset: 0x81D510 VA: 0x18081E310
	private static void .cctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class SettingsData : AbstractUserSaveData // TypeDefIndex: 2613
{
	// Fields
	[JsonProperty("gameplay")]
	private GameplaySettingsData gameplay; // 0x38
	[JsonProperty("accessibility")]
	private AccessibilitySettingsData accessibility; // 0x40
	[JsonProperty("audio")]
	private AudioSettingsData audio; // 0x48
	[JsonProperty("video")]
	private VideoSettingsData video; // 0x50
	[JsonProperty("language")]
	private LanguageSettingsData language; // 0x58
	[JsonProperty("input")]
	private InputSettingsData input; // 0x60
	[JsonProperty("multiplayer")]
	private MultiplayerSettingsData multiplayer; // 0x68

	// Properties
	protected override int CurrentVersion { get; }
	public GameplaySettingsData Gameplay { get; }
	public AccessibilitySettingsData Accessibility { get; }
	public AudioSettingsData Audio { get; }
	public VideoSettingsData Video { get; }
	public InputSettingsData Input { get; }
	public LanguageSettingsData Language { get; }
	public MultiplayerSettingsData Multiplayer { get; }
	protected override string FileName { get; }
	protected override AbstractSaveDataGroup[] Groups { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 19
	protected override int get_CurrentVersion() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public GameplaySettingsData get_Gameplay() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public AccessibilitySettingsData get_Accessibility() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public AudioSettingsData get_Audio() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public VideoSettingsData get_Video() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public InputSettingsData get_Input() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public LanguageSettingsData get_Language() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public MultiplayerSettingsData get_Multiplayer() { }

	// RVA: 0x82ACF0 Offset: 0x829EF0 VA: 0x18082ACF0 Slot: 21
	protected override string get_FileName() { }

	// RVA: 0x82AD20 Offset: 0x829F20 VA: 0x18082AD20 Slot: 14
	protected override AbstractSaveDataGroup[] get_Groups() { }

	// RVA: 0x829D00 Offset: 0x828F00 VA: 0x180829D00 Slot: 20
	protected override void HandleVersionMigration(int version) { }

	// RVA: 0x82A8C0 Offset: 0x829AC0 VA: 0x18082A8C0
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Settings
[JsonObject(1)]
public class VideoSettingsData : AbstractSaveDataGroup // TypeDefIndex: 2614
{
	// Fields
	public const bool DEFAULT_VSYNC = False;
	[JsonProperty("vsync")]
	private bool vsync; // 0x18
	[CompilerGenerated]
	private Action OnVSyncChanged; // 0x20

	// Properties
	public bool VSync { get; set; }

	// Methods

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_VSync() { }

	// RVA: 0x82D220 Offset: 0x82C420 VA: 0x18082D220
	public void set_VSync(bool value) { }

	[CompilerGenerated]
	// RVA: 0x82D0E0 Offset: 0x82C2E0 VA: 0x18082D0E0
	public void add_OnVSyncChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x82D180 Offset: 0x82C380 VA: 0x18082D180
	public void remove_OnVSyncChanged(Action value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LegacySaveManager.<>c // TypeDefIndex: 2615
{
	// Fields
	public static readonly LegacySaveManager.<>c <>9; // 0x0
	public static Action<BinaryReader> <>9__148_0; // 0x8

	// Methods

	// RVA: 0x82D080 Offset: 0x82C280 VA: 0x18082D080
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82C8E0 Offset: 0x82BAE0 VA: 0x18082C8E0
	internal void <LoadSecureData>b__148_0(BinaryReader reader) { }
}

// Namespace: AmongUs.Data.Legacy
public static class LegacySaveManager // TypeDefIndex: 2616
{
	// Fields
	private const int schemaVersion = 1;
	private static int lastSchemaVersion; // 0x0
	private static bool loaded; // 0x4
	private static bool loadedStats; // 0x5
	private static bool loadedAnnounce; // 0x6
	private static bool loadedQCFavorites; // 0x7
	private static bool loadedStoreTabViewDates; // 0x8
	private static bool loadedCachedPurchases; // 0x9
	private static int accountLoginStatus; // 0xC
	private static string guardianEmail; // 0x10
	private static bool deleteDeviceIDFailed; // 0x18
	private static bool hasLoggedIn; // 0x19
	private static bool isGuest; // 0x1A
	private static string epicAccountId; // 0x20
	private static string lastPlayerName; // 0x28
	private static uint colorConfig; // 0x30
	private static string lastPet; // 0x38
	private static string lastHat; // 0x40
	private static string lastSkin; // 0x48
	private static string lastVisor; // 0x50
	private static string lastNamePlate; // 0x58
	private static uint playerLevel; // 0x60
	private static uint playerXp; // 0x64
	private static uint playerXpRequiredForNextLevel; // 0x68
	private static int privacyPolicyVersion; // 0x6C
	private static Announcement lastAnnounce; // 0x70
	private static bool showOnlineHelp; // 0xB0
	private static bool askRedeemDLC; // 0xB1
	private static bool warnedAboutGuestModeProgression; // 0xB2
	private static bool showMinPlayerWarning; // 0xB3
	private static string dobInfo; // 0xB8
	private static string birthDateSetDate; // 0xC0
	private static int birthDateDay; // 0xC8
	private static int birthDateMonth; // 0xCC
	private static int birthDateYear; // 0xD0
	private static string lastCosmicube; // 0xD8
	private static string storeBundlesViewDate; // 0xE0
	private static string storeHatsViewDate; // 0xE8
	private static string storeOutfitsViewDate; // 0xF0
	private static string storeVisorsViewDate; // 0xF8
	private static string storePetsViewDate; // 0x100
	private static string storeNameplatesViewDate; // 0x108
	private static string storeCosmicubeViewDate; // 0x110
	private static byte showAdsScreen; // 0x118
	private static bool screenshake; // 0x119
	private static bool streamerMode; // 0x11A
	private static bool colorblindMode; // 0x11B
	private static byte sfxVolume; // 0x11C
	private static byte musicVolume; // 0x11D
	private static bool vsync; // 0x11E
	private static uint lastLanguage; // 0x120
	private static ControlTypes touchConfig; // 0x124
	private static bool enableMouseMovement; // 0x128
	private static float joyStickSize; // 0x12C
	private static bool crossplayAllPlatforms; // 0x130
	private static bool enableFriendsListInvites; // 0x131
	private static bool censorChat; // 0x132
	private static int chatModeType; // 0x134
	private static string[] quickChatFavorites; // 0x138
	private static LegacySecureDataFile purchaseFile; // 0x140
	private static HashSet<string> purchases; // 0x148

	// Properties
	public static EOSManager.AccountLoginStatus AccountLoginStatus { get; }
	public static bool DeleteDeviceIDFailed { get; }
	public static string GuardianEmail { get; }
	public static string PlayerName { get; }
	public static byte BodyColor { get; }
	public static string LastPet { get; }
	public static string LastHat { get; }
	public static string LastSkin { get; }
	public static string LastVisor { get; }
	public static string LastNamePlate { get; }
	public static uint PlayerLevel { get; }
	public static uint PlayerXp { get; }
	public static uint XpRequiredForNextLevel { get; }
	public static int AcceptedPrivacyPolicy { get; }
	public static bool ShowOnlineHelp { get; }
	public static bool ShowMinPlayerWarning { get; }
	public static Announcement LastAnnouncement { get; }
	public static string LastCosmicube { get; }
	public static string BirthDateSetDate { get; }
	public static bool BoughtNoAds { get; }
	public static ShowAdsState ShowAdsScreen { get; }
	public static bool Screenshake { get; }
	public static bool StreamerMode { get; }
	public static bool ColorBlindMode { get; }
	public static float MusicVolume { get; }
	public static float SfxVolume { get; }
	public static bool VSync { get; }
	public static uint LastLanguage { get; }
	public static ControlTypes ControlMode { get; }
	public static bool EnableMouseMovement { get; }
	public static float JoystickSize { get; }
	public static bool CrossplayAllPlatforms { get; }
	public static bool EnableFriendsListInvites { get; }
	public static bool CensorChat { get; }
	public static QuickChatModes ChatModeType { get; }
	public static string[] QuickChatFavorites { get; }

	// Methods

	// RVA: 0x81C7E0 Offset: 0x81B9E0 VA: 0x18081C7E0
	public static EOSManager.AccountLoginStatus get_AccountLoginStatus() { }

	// RVA: 0x81CB30 Offset: 0x81BD30 VA: 0x18081CB30
	public static bool get_DeleteDeviceIDFailed() { }

	// RVA: 0x81CC50 Offset: 0x81BE50 VA: 0x18081CC50
	public static string get_GuardianEmail() { }

	// RVA: 0x81D1A0 Offset: 0x81C3A0 VA: 0x18081D1A0
	public static string get_PlayerName() { }

	// RVA: 0x81C8A0 Offset: 0x81BAA0 VA: 0x18081C8A0
	public static byte get_BodyColor() { }

	// RVA: 0x81CFB0 Offset: 0x81C1B0 VA: 0x18081CFB0
	public static string get_LastPet() { }

	// RVA: 0x81CDF0 Offset: 0x81BFF0 VA: 0x18081CDF0
	public static string get_LastHat() { }

	// RVA: 0x81D010 Offset: 0x81C210 VA: 0x18081D010
	public static string get_LastSkin() { }

	// RVA: 0x81D070 Offset: 0x81C270 VA: 0x18081D070
	public static string get_LastVisor() { }

	// RVA: 0x81CF50 Offset: 0x81C150 VA: 0x18081CF50
	public static string get_LastNamePlate() { }

	// RVA: 0x81D140 Offset: 0x81C340 VA: 0x18081D140
	public static uint get_PlayerLevel() { }

	// RVA: 0x81D200 Offset: 0x81C400 VA: 0x18081D200
	public static uint get_PlayerXp() { }

	// RVA: 0x81D570 Offset: 0x81C770 VA: 0x18081D570
	public static uint get_XpRequiredForNextLevel() { }

	// RVA: 0x81C780 Offset: 0x81B980 VA: 0x18081C780
	public static int get_AcceptedPrivacyPolicy() { }

	// RVA: 0x81D450 Offset: 0x81C650 VA: 0x18081D450
	public static bool get_ShowOnlineHelp() { }

	// RVA: 0x81D3F0 Offset: 0x81C5F0 VA: 0x18081D3F0
	public static bool get_ShowMinPlayerWarning() { }

	// RVA: 0x81CD10 Offset: 0x81BF10 VA: 0x18081CD10
	public static Announcement get_LastAnnouncement() { }

	// RVA: 0x81CD90 Offset: 0x81BF90 VA: 0x18081CD90
	public static string get_LastCosmicube() { }

	// RVA: 0x81C840 Offset: 0x81BA40 VA: 0x18081C840
	public static string get_BirthDateSetDate() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool get_BoughtNoAds() { }

	// RVA: 0x81D390 Offset: 0x81C590 VA: 0x18081D390
	public static ShowAdsState get_ShowAdsScreen() { }

	// RVA: 0x81D2C0 Offset: 0x81C4C0 VA: 0x18081D2C0
	public static bool get_Screenshake() { }

	// RVA: 0x81D4B0 Offset: 0x81C6B0 VA: 0x18081D4B0
	public static bool get_StreamerMode() { }

	// RVA: 0x81CA20 Offset: 0x81BC20 VA: 0x18081CA20
	public static bool get_ColorBlindMode() { }

	// RVA: 0x81D0D0 Offset: 0x81C2D0 VA: 0x18081D0D0
	public static float get_MusicVolume() { }

	// RVA: 0x81D320 Offset: 0x81C520 VA: 0x18081D320
	public static float get_SfxVolume() { }

	// RVA: 0x81D510 Offset: 0x81C710 VA: 0x18081D510
	public static bool get_VSync() { }

	// RVA: 0x81CE50 Offset: 0x81C050 VA: 0x18081CE50
	public static uint get_LastLanguage() { }

	// RVA: 0x81CA80 Offset: 0x81BC80 VA: 0x18081CA80
	public static ControlTypes get_ControlMode() { }

	// RVA: 0x81CBF0 Offset: 0x81BDF0 VA: 0x18081CBF0
	public static bool get_EnableMouseMovement() { }

	// RVA: 0x81CCB0 Offset: 0x81BEB0 VA: 0x18081CCB0
	public static float get_JoystickSize() { }

	// RVA: 0x81CAE0 Offset: 0x81BCE0 VA: 0x18081CAE0
	public static bool get_CrossplayAllPlatforms() { }

	// RVA: 0x81CB90 Offset: 0x81BD90 VA: 0x18081CB90
	public static bool get_EnableFriendsListInvites() { }

	// RVA: 0x81C900 Offset: 0x81BB00 VA: 0x18081C900
	public static bool get_CensorChat() { }

	// RVA: 0x81C960 Offset: 0x81BB60 VA: 0x18081C960
	public static QuickChatModes get_ChatModeType() { }

	// RVA: 0x81D260 Offset: 0x81C460 VA: 0x18081D260
	public static string[] get_QuickChatFavorites() { }

	// RVA: 0x81B870 Offset: 0x81AA70 VA: 0x18081B870
	public static bool PlayerPrefsExists() { }

	// RVA: 0x819F40 Offset: 0x819140 VA: 0x180819F40
	public static void LoadPlayerPrefs(bool overrideLoad = False) { }

	// RVA: 0x8197D0 Offset: 0x8189D0 VA: 0x1808197D0
	public static void DeleteAll() { }

	// RVA: 0x819920 Offset: 0x818B20 VA: 0x180819920
	private static string GetPrefsName() { }

	// RVA: 0x81BA80 Offset: 0x81AC80 VA: 0x18081BA80
	private static void TryGetBool(string[] parts, int index, out bool value, bool default = False) { }

	// RVA: 0x81BB30 Offset: 0x81AD30 VA: 0x18081BB30
	private static void TryGetByte(string[] parts, int index, out byte value) { }

	// RVA: 0x81BC50 Offset: 0x81AE50 VA: 0x18081BC50
	private static void TryGetFloat(string[] parts, int index, out float value, float default = 0) { }

	// RVA: 0x81BB80 Offset: 0x81AD80 VA: 0x18081BB80
	private static void TryGetDateTime(string[] parts, int index, out DateTime value) { }

	// RVA: 0x81BD00 Offset: 0x81AF00 VA: 0x18081BD00
	private static void TryGetInt(string[] parts, int index, out int value) { }

	// RVA: 0x81C1C0 Offset: 0x81B3C0 VA: 0x18081C1C0
	private static void TryGetUint(string[] parts, int index, out uint value, uint default = 0) { }

	// RVA: 0x81C210 Offset: 0x81B410 VA: 0x18081C210
	private static void TryGetUlong(string[] parts, int index, out ulong value, ulong default = 0) { }

	// RVA: 0x81C190 Offset: 0x81B390 VA: 0x18081C190
	private static void TryGetString(string[] parts, int index, out string value, string default = "") { }

	// RVA: 0x81AEF0 Offset: 0x81A0F0 VA: 0x18081AEF0
	public static void LoadQuickChatFavorites() { }

	// RVA: 0x819A10 Offset: 0x818C10 VA: 0x180819A10
	public static bool GetPurchase(string itemKey, string bundleKey) { }

	// RVA: 0x819D60 Offset: 0x818F60 VA: 0x180819D60
	public static int[] LoadLocalDoB() { }

	// RVA: 0x81B1A0 Offset: 0x81A3A0 VA: 0x18081B1A0
	private static void LoadSecureData() { }

	// RVA: 0x819B30 Offset: 0x818D30 VA: 0x180819B30
	private static void LoadAnnouncement() { }

	// RVA: 0x81B9E0 Offset: 0x81ABE0 VA: 0x18081B9E0
	public static bool StoreTabViewDatesFileExists() { }

	// RVA: 0x81B3E0 Offset: 0x81A5E0 VA: 0x18081B3E0
	public static void LoadStoreTabViewDates() { }

	// RVA: 0x81BD50 Offset: 0x81AF50 VA: 0x18081BD50
	public static bool TryGetStoreTabViewDate(StoreTab tab, out string output) { }

	// RVA: 0x81B930 Offset: 0x81AB30 VA: 0x18081B930
	private static bool RunMigrations() { }

	// RVA: 0x81C260 Offset: 0x81B460 VA: 0x18081C260
	private static void .cctor() { }
}

// Namespace: AmongUs.Data.Legacy
public class LegacySecureDataFile // TypeDefIndex: 2617
{
	// Fields
	[CompilerGenerated]
	private bool <Loaded>k__BackingField; // 0x10
	private string filePath; // 0x18

	// Properties
	public bool Loaded { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Loaded() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_Loaded(bool value) { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(string filePath) { }

	// RVA: 0x81D630 Offset: 0x81C830 VA: 0x18081D630
	public void LoadData(Action<BinaryReader> performRead) { }

	// RVA: 0x81D5D0 Offset: 0x81C7D0 VA: 0x18081D5D0
	public void Delete() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerAnnouncementData : AbstractSaveDataGroup // TypeDefIndex: 2618
{
	// Fields
	[JsonProperty("announcementsRead")]
	private List<int> ids; // 0x18
	[JsonProperty("latestAnnouncementNumber")]
	private int latestAnnouncementNumber; // 0x20
	private List<Announcement> allAnnouncements; // 0x28
	[CompilerGenerated]
	private Action OnReadAnnouncement; // 0x30
	[CompilerGenerated]
	private Action OnNewAnnouncement; // 0x38
	[CompilerGenerated]
	private Action OnAddAnnouncement; // 0x40

	// Properties
	public List<int> AnnouncementsRead { get; set; }
	public int LatestAnnouncementNumber { get; set; }
	public List<Announcement> AllAnnouncements { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<int> get_AnnouncementsRead() { }

	// RVA: 0x8214F0 Offset: 0x8206F0 VA: 0x1808214F0
	public void set_AnnouncementsRead(List<int> value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_LatestAnnouncementNumber() { }

	// RVA: 0x821570 Offset: 0x820770 VA: 0x180821570
	public void set_LatestAnnouncementNumber(int value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<Announcement> get_AllAnnouncements() { }

	// RVA: 0x820EC0 Offset: 0x8200C0 VA: 0x180820EC0
	public void AddAnnouncement(Announcement a) { }

	// RVA: 0x820FE0 Offset: 0x8201E0 VA: 0x180820FE0
	public void SetAnnouncements(Announcement[] aRange) { }

	[CompilerGenerated]
	// RVA: 0x821270 Offset: 0x820470 VA: 0x180821270
	public void add_OnReadAnnouncement(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821450 Offset: 0x820650 VA: 0x180821450
	public void remove_OnReadAnnouncement(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8211D0 Offset: 0x8203D0 VA: 0x1808211D0
	public void add_OnNewAnnouncement(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8213B0 Offset: 0x8205B0 VA: 0x1808213B0
	public void remove_OnNewAnnouncement(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821130 Offset: 0x820330 VA: 0x180821130
	public void add_OnAddAnnouncement(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821310 Offset: 0x820510 VA: 0x180821310
	public void remove_OnAddAnnouncement(Action value) { }

	// RVA: 0x821080 Offset: 0x820280 VA: 0x180821080
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerAccountData : AbstractSaveDataGroup // TypeDefIndex: 2619
{
	// Fields
	public const EOSManager.AccountLoginStatus DEFAULT_LOGIN_STATUS = 0;
	public const string DEFAULT_GUARDIAN_EMAIL = "";
	public const bool DEFAULT_DELETE_DEVICE_ID_FAILED = False;
	[JsonProperty("loginStatus")]
	private EOSManager.AccountLoginStatus loginStatus; // 0x18
	[JsonProperty("guardianEmail")]
	private string guardianEmail; // 0x20
	[JsonProperty("deleteDeviceIDFailed")]
	private bool deleteDeviceIDFailed; // 0x28
	[CompilerGenerated]
	private Action OnLoginStatusChanged; // 0x30
	[CompilerGenerated]
	private Action OnGuardianEmailChanged; // 0x38
	[CompilerGenerated]
	private Action OnDeleteDeviceIDFailedChanged; // 0x40

	// Properties
	public EOSManager.AccountLoginStatus LoginStatus { get; set; }
	public string GuardianEmail { get; set; }
	public bool DeleteDeviceIDFailed { get; set; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public EOSManager.AccountLoginStatus get_LoginStatus() { }

	// RVA: 0x820630 Offset: 0x81F830 VA: 0x180820630
	public void set_LoginStatus(EOSManager.AccountLoginStatus value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_GuardianEmail() { }

	// RVA: 0x8205B0 Offset: 0x81F7B0 VA: 0x1808205B0
	public void set_GuardianEmail(string value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_DeleteDeviceIDFailed() { }

	// RVA: 0x820530 Offset: 0x81F730 VA: 0x180820530
	public void set_DeleteDeviceIDFailed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8202B0 Offset: 0x81F4B0 VA: 0x1808202B0
	public void add_OnLoginStatusChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820490 Offset: 0x81F690 VA: 0x180820490
	public void remove_OnLoginStatusChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820210 Offset: 0x81F410 VA: 0x180820210
	public void add_OnGuardianEmailChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8203F0 Offset: 0x81F5F0 VA: 0x1808203F0
	public void remove_OnGuardianEmailChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820170 Offset: 0x81F370 VA: 0x180820170
	public void add_OnDeleteDeviceIDFailedChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820350 Offset: 0x81F550 VA: 0x180820350
	public void remove_OnDeleteDeviceIDFailedChanged(Action value) { }

	// RVA: 0x820130 Offset: 0x81F330 VA: 0x180820130
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerAdsData : AbstractSaveDataGroup // TypeDefIndex: 2620
{
	// Fields
	public const ShowAdsState DEFAULT_ADS_STATE = 0;
	public const bool DEFAULT_HAS_PURCHASED_AD_REMOVAL = False;
	[JsonProperty("adsState")]
	private ShowAdsState adsState; // 0x18
	[JsonProperty("hasPurchasedAdRemoval")]
	private bool hasPurchasedAdRemoval; // 0x19
	[CompilerGenerated]
	private Action OnShowAdsStateChanged; // 0x20
	[CompilerGenerated]
	private Action OnHasPurchasedAdRemovalChanged; // 0x28

	// Properties
	public ShowAdsState AdsState { get; set; }
	public bool HasPurchasedAdRemoval { get; set; }

	// Methods

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public ShowAdsState get_AdsState() { }

	// RVA: 0x820930 Offset: 0x81FB30 VA: 0x180820930
	public void set_AdsState(ShowAdsState value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_HasPurchasedAdRemoval() { }

	// RVA: 0x8209B0 Offset: 0x81FBB0 VA: 0x1808209B0
	public void set_HasPurchasedAdRemoval(bool value) { }

	[CompilerGenerated]
	// RVA: 0x820750 Offset: 0x81F950 VA: 0x180820750
	public void add_OnShowAdsStateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820890 Offset: 0x81FA90 VA: 0x180820890
	public void remove_OnShowAdsStateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8206B0 Offset: 0x81F8B0 VA: 0x1808206B0
	public void add_OnHasPurchasedAdRemovalChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8207F0 Offset: 0x81F9F0 VA: 0x1808207F0
	public void remove_OnHasPurchasedAdRemovalChanged(Action value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerAgeData : AbstractSaveDataGroup // TypeDefIndex: 2621
{
	// Fields
	public static readonly DateTime DEFAULT_DATE_OF_BIRTH; // 0x0
	public static readonly DateTime DEFAULT_LATEST_SET_DATE; // 0x8
	[JsonProperty("dateOfBirth")]
	private DateTime dateOfBirth; // 0x18
	[JsonProperty("latestSetDate")]
	private DateTime latestSetDate; // 0x20
	[CompilerGenerated]
	private Action OnDateOfBirthChanged; // 0x28
	[CompilerGenerated]
	private Action OnLatestSetDateChanged; // 0x30

	// Properties
	public DateTime DateOfBirth { get; set; }
	public DateTime LatestSetDate { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DateTime get_DateOfBirth() { }

	// RVA: 0x820DC0 Offset: 0x81FFC0 VA: 0x180820DC0
	public void set_DateOfBirth(DateTime value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DateTime get_LatestSetDate() { }

	// RVA: 0x820E40 Offset: 0x820040 VA: 0x180820E40
	public void set_LatestSetDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x820B40 Offset: 0x81FD40 VA: 0x180820B40
	public void add_OnDateOfBirthChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820C80 Offset: 0x81FE80 VA: 0x180820C80
	public void remove_OnDateOfBirthChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820BE0 Offset: 0x81FDE0 VA: 0x180820BE0
	public void add_OnLatestSetDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x820D20 Offset: 0x81FF20 VA: 0x180820D20
	public void remove_OnLatestSetDateChanged(Action value) { }

	// RVA: 0x820AC0 Offset: 0x81FCC0 VA: 0x180820AC0
	public void .ctor() { }

	// RVA: 0x820A30 Offset: 0x81FC30 VA: 0x180820A30
	private static void .cctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerBanData : AbstractSaveDataGroup // TypeDefIndex: 2622
{
	// Fields
	private const int POINTS_UNTIL_BAN_STARTS = 2;
	private const int MINUTES_PER_BAN_POINT = 5;
	[JsonProperty("banPoints")]
	private float banPoints; // 0x18
	[JsonProperty("previousGameStartDate")]
	private long previousGameStartDate; // 0x20
	[CompilerGenerated]
	private Action OnBanPointsChanged; // 0x28
	[CompilerGenerated]
	private Action OnPreviousGameStartedDateChanged; // 0x30

	// Properties
	public float BanPoints { get; set; }
	public DateTime PreviousGameStartDate { get; set; }
	public bool IsBanned { get; }
	public float BanMinutes { get; }
	public int BanMinutesLeft { get; }

	// Methods

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_BanPoints() { }

	// RVA: 0x821B10 Offset: 0x820D10 VA: 0x180821B10
	public void set_BanPoints(float value) { }

	// RVA: 0x8219A0 Offset: 0x820BA0 VA: 0x1808219A0
	public DateTime get_PreviousGameStartDate() { }

	// RVA: 0x821BF0 Offset: 0x820DF0 VA: 0x180821BF0
	public void set_PreviousGameStartDate(DateTime value) { }

	// RVA: 0x821980 Offset: 0x820B80 VA: 0x180821980
	public bool get_IsBanned() { }

	// RVA: 0x821960 Offset: 0x820B60 VA: 0x180821960
	public float get_BanMinutes() { }

	// RVA: 0x821730 Offset: 0x820930 VA: 0x180821730
	public int get_BanMinutesLeft() { }

	[CompilerGenerated]
	// RVA: 0x8215F0 Offset: 0x8207F0 VA: 0x1808215F0
	public void add_OnBanPointsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8219D0 Offset: 0x820BD0 VA: 0x1808219D0
	public void remove_OnBanPointsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821690 Offset: 0x820890 VA: 0x180821690
	public void add_OnPreviousGameStartedDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821A70 Offset: 0x820C70 VA: 0x180821A70
	public void remove_OnPreviousGameStartedDateChanged(Action value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerCustomizationData : AbstractSaveDataGroup // TypeDefIndex: 2623
{
	// Fields
	public const string DEFAULT_NAME = "";
	public const byte DEFAULT_COLOR_ID = 0;
	public const string DEFAULT_PET = "";
	public const string DEFAULT_HAT = "";
	public const string DEFAULT_SKIN = "";
	public const string DEFAULT_VISOR = "";
	public const string DEFAULT_NAME_PLATE = "";
	[JsonProperty("name")]
	private string name; // 0x18
	[JsonProperty("colorID")]
	private byte colorID; // 0x20
	[JsonProperty("pet")]
	private string pet; // 0x28
	[JsonProperty("hat")]
	private string hat; // 0x30
	[JsonProperty("skin")]
	private string skin; // 0x38
	[JsonProperty("visor")]
	private string visor; // 0x40
	[JsonProperty("namePlate")]
	private string namePlate; // 0x48
	[CompilerGenerated]
	private Action OnNameChanged; // 0x50
	[CompilerGenerated]
	private Action OnColorChanged; // 0x58
	[CompilerGenerated]
	private Action OnPetChanged; // 0x60
	[CompilerGenerated]
	private Action OnHatChanged; // 0x68
	[CompilerGenerated]
	private Action OnSkinChanged; // 0x70
	[CompilerGenerated]
	private Action OnVisorChanged; // 0x78
	[CompilerGenerated]
	private Action OnNamePlateChanged; // 0x80

	// Properties
	public string Name { get; set; }
	public byte Color { get; set; }
	public string Pet { get; set; }
	public string Hat { get; set; }
	public string Skin { get; set; }
	public string Visor { get; set; }
	public string NamePlate { get; set; }

	// Methods

	// RVA: 0x822190 Offset: 0x821390 VA: 0x180822190
	public string get_Name() { }

	// RVA: 0x822810 Offset: 0x821A10 VA: 0x180822810
	public void set_Name(string value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public byte get_Color() { }

	// RVA: 0x822690 Offset: 0x821890 VA: 0x180822690
	public void set_Color(byte value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Pet() { }

	// RVA: 0x822890 Offset: 0x821A90 VA: 0x180822890
	public void set_Pet(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Hat() { }

	// RVA: 0x822710 Offset: 0x821910 VA: 0x180822710
	public void set_Hat(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Skin() { }

	// RVA: 0x822910 Offset: 0x821B10 VA: 0x180822910
	public void set_Skin(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_Visor() { }

	// RVA: 0x822990 Offset: 0x821B90 VA: 0x180822990
	public void set_Visor(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_NamePlate() { }

	// RVA: 0x822790 Offset: 0x821990 VA: 0x180822790
	public void set_NamePlate(string value) { }

	[CompilerGenerated]
	// RVA: 0x821E60 Offset: 0x821060 VA: 0x180821E60
	public void add_OnNameChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x822360 Offset: 0x821560 VA: 0x180822360
	public void remove_OnNameChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821D20 Offset: 0x820F20 VA: 0x180821D20
	public void add_OnColorChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x822220 Offset: 0x821420 VA: 0x180822220
	public void remove_OnColorChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821FB0 Offset: 0x8211B0 VA: 0x180821FB0
	public void add_OnPetChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8224B0 Offset: 0x8216B0 VA: 0x1808224B0
	public void remove_OnPetChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821DC0 Offset: 0x820FC0 VA: 0x180821DC0
	public void add_OnHatChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8222C0 Offset: 0x8214C0 VA: 0x1808222C0
	public void remove_OnHatChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x822050 Offset: 0x821250 VA: 0x180822050
	public void add_OnSkinChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x822550 Offset: 0x821750 VA: 0x180822550
	public void remove_OnSkinChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8220F0 Offset: 0x8212F0 VA: 0x1808220F0
	public void add_OnVisorChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8225F0 Offset: 0x8217F0 VA: 0x1808225F0
	public void remove_OnVisorChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x821F00 Offset: 0x821100 VA: 0x180821F00
	public void add_OnNamePlateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x822400 Offset: 0x821600 VA: 0x180822400
	public void remove_OnNamePlateChanged(Action value) { }

	// RVA: 0x821CA0 Offset: 0x820EA0 VA: 0x180821CA0
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerData : AbstractUserSaveData // TypeDefIndex: 2624
{
	// Fields
	private static readonly byte[] DEFAULT_ENCRYPTED; // 0x0
	[JsonProperty("account")]
	private PlayerAccountData account; // 0x38
	[JsonProperty("customization")]
	private PlayerCustomizationData customization; // 0x40
	[JsonProperty("onboarding")]
	private PlayerOnboardingData onboarding; // 0x48
	[JsonProperty("age")]
	private byte[] encryptedAge; // 0x50
	private PlayerAgeData age; // 0x58
	[JsonProperty("store")]
	private byte[] encryptedStore; // 0x60
	private PlayerStoreData store; // 0x68
	[JsonProperty("ads")]
	private byte[] encryptedAds; // 0x70
	private PlayerAdsData ads; // 0x78
	[JsonProperty("ban")]
	private byte[] encryptedBan; // 0x80
	private PlayerBanData ban; // 0x88
	[JsonProperty("announcements")]
	private PlayerAnnouncementData announcements; // 0x90
	[JsonProperty("friends")]
	private PlayerFriendData friends; // 0x98
	private PlayerPurchasesData purchases; // 0xA0
	private PlayerStatsData stats; // 0xA8

	// Properties
	protected override int CurrentVersion { get; }
	public PlayerAccountData Account { get; }
	public PlayerCustomizationData Customization { get; }
	public PlayerStatsData Stats { get; }
	public PlayerOnboardingData Onboarding { get; }
	public PlayerAgeData Age { get; }
	public PlayerStoreData Store { get; }
	public PlayerAdsData Ads { get; }
	public PlayerBanData Ban { get; }
	public PlayerPurchasesData Purchases { get; }
	public PlayerAnnouncementData Announcements { get; }
	public PlayerFriendData Friends { get; }
	protected override string FileName { get; }
	protected override AbstractSaveDataGroup[] Groups { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 19
	protected override int get_CurrentVersion() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PlayerAccountData get_Account() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public PlayerCustomizationData get_Customization() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public PlayerStatsData get_Stats() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public PlayerOnboardingData get_Onboarding() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public PlayerAgeData get_Age() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public PlayerStoreData get_Store() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public PlayerAdsData get_Ads() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public PlayerBanData get_Ban() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public PlayerPurchasesData get_Purchases() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public PlayerAnnouncementData get_Announcements() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public PlayerFriendData get_Friends() { }

	// RVA: 0x8247E0 Offset: 0x8239E0 VA: 0x1808247E0 Slot: 21
	protected override string get_FileName() { }

	// RVA: 0x824810 Offset: 0x823A10 VA: 0x180824810 Slot: 14
	protected override AbstractSaveDataGroup[] get_Groups() { }

	// RVA: 0x823F20 Offset: 0x823120 VA: 0x180823F20 Slot: 10
	protected override void OnSaveStart() { }

	// RVA: 0x823E00 Offset: 0x823000 VA: 0x180823E00 Slot: 13
	protected override void OnLoadComplete() { }

	// RVA: 0x822A10 Offset: 0x821C10 VA: 0x180822A10 Slot: 20
	protected override void HandleVersionMigration(int version) { }

	// RVA: 0x824210 Offset: 0x823410 VA: 0x180824210
	public void .ctor() { }

	// RVA: 0x8241C0 Offset: 0x8233C0 VA: 0x1808241C0
	private static void .cctor() { }
}

// Namespace: 
[JsonObject(1)]
public class PlayerFriendData.CachedName // TypeDefIndex: 2625
{
	// Fields
	[JsonProperty("id")]
	private string puid; // 0x10
	[JsonProperty("name")]
	private string name; // 0x18

	// Properties
	public string PUID { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_PUID() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string puid, string name) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void ChangeName(string newName) { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerFriendData : AbstractSaveDataGroup // TypeDefIndex: 2626
{
	// Fields
	[JsonProperty("names")]
	private List<PlayerFriendData.CachedName> cachedNames; // 0x18

	// Methods

	// RVA: 0x824AC0 Offset: 0x823CC0 VA: 0x180824AC0
	public string GetCachedName(string puid) { }

	// RVA: 0x824C10 Offset: 0x823E10 VA: 0x180824C10
	public void UpdateCachedName(string puid, string name) { }

	// RVA: 0x825070 Offset: 0x824270 VA: 0x180825070
	public void .ctor() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerOnboardingData : AbstractSaveDataGroup // TypeDefIndex: 2627
{
	// Fields
	public const int DEFAULT_PRIVACY_POLICY_VERSION = 0;
	public const bool DEFAULT_VIEWED_ONLINE_HELP_MESSAGE = False;
	public const bool DEFAULT_VIEWED_MIN_PLAYER_WARNING = False;
	public const bool DEFAULT_ALWAYS_SHOW_MIN_PLAYER_WARNING = True;
	public const bool DEFAULT_VIEWED_HIDEANDSEEK_HOWTOPLAY = False;
	[JsonProperty("privacyPolicyVersion")]
	private int privacyPolicyVersion; // 0x18
	[JsonProperty("viewedOnlineHelpMessage")]
	private bool viewedOnlineHelpMessage; // 0x1C
	[JsonProperty("viewedMinPlayerWarning")]
	private bool viewedMinPlayerWarning; // 0x1D
	[JsonProperty("alwaysShowMinPlayerWarning")]
	private bool alwaysShowMinPlayerWarning; // 0x1E
	[JsonProperty("viewedHideAndSeekHowToPlay")]
	private bool viewedHideAndSeekHowToPlay; // 0x1F
	[CompilerGenerated]
	private Action OnLastAcceptedPrivacyPolicyVersionChanged; // 0x20
	[CompilerGenerated]
	private Action OnViewedOnlineHelpMessageChanged; // 0x28
	[CompilerGenerated]
	private Action OnViewedMinPlayerWarningChanged; // 0x30
	[CompilerGenerated]
	private Action OnAlwaysShowMinPlayerWarningChanged; // 0x38
	[CompilerGenerated]
	private Action OnViewedHideAndSeekHowToPlay; // 0x40

	// Properties
	public int LastAcceptedPrivacyPolicyVersion { get; set; }
	public bool ViewedOnlineHelpMessage { get; set; }
	public bool ViewedMinPlayerWarning { get; set; }
	public bool AlwaysShowMinPlayerWarning { get; set; }
	public bool ViewedHideAndSeekHowToPlay { get; set; }

	// Methods

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_LastAcceptedPrivacyPolicyVersion() { }

	// RVA: 0x8257D0 Offset: 0x8249D0 VA: 0x1808257D0
	public void set_LastAcceptedPrivacyPolicyVersion(int value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_ViewedOnlineHelpMessage() { }

	// RVA: 0x825950 Offset: 0x824B50 VA: 0x180825950
	public void set_ViewedOnlineHelpMessage(bool value) { }

	// RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0
	public bool get_ViewedMinPlayerWarning() { }

	// RVA: 0x8258D0 Offset: 0x824AD0 VA: 0x1808258D0
	public void set_ViewedMinPlayerWarning(bool value) { }

	// RVA: 0x825410 Offset: 0x824610 VA: 0x180825410
	public bool get_AlwaysShowMinPlayerWarning() { }

	// RVA: 0x825750 Offset: 0x824950 VA: 0x180825750
	public void set_AlwaysShowMinPlayerWarning(bool value) { }

	// RVA: 0x825420 Offset: 0x824620 VA: 0x180825420
	public bool get_ViewedHideAndSeekHowToPlay() { }

	// RVA: 0x825850 Offset: 0x824A50 VA: 0x180825850
	public void set_ViewedHideAndSeekHowToPlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x825190 Offset: 0x824390 VA: 0x180825190
	public void add_OnLastAcceptedPrivacyPolicyVersionChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8254D0 Offset: 0x8246D0 VA: 0x1808254D0
	public void remove_OnLastAcceptedPrivacyPolicyVersionChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x825370 Offset: 0x824570 VA: 0x180825370
	public void add_OnViewedOnlineHelpMessageChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8256B0 Offset: 0x8248B0 VA: 0x1808256B0
	public void remove_OnViewedOnlineHelpMessageChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8252D0 Offset: 0x8244D0 VA: 0x1808252D0
	public void add_OnViewedMinPlayerWarningChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x825610 Offset: 0x824810 VA: 0x180825610
	public void remove_OnViewedMinPlayerWarningChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8250F0 Offset: 0x8242F0 VA: 0x1808250F0
	public void add_OnAlwaysShowMinPlayerWarningChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x825430 Offset: 0x824630 VA: 0x180825430
	public void remove_OnAlwaysShowMinPlayerWarningChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x825230 Offset: 0x824430 VA: 0x180825230
	public void add_OnViewedHideAndSeekHowToPlay(Action value) { }

	[CompilerGenerated]
	// RVA: 0x825570 Offset: 0x824770 VA: 0x180825570
	public void remove_OnViewedHideAndSeekHowToPlay(Action value) { }

	// RVA: 0x8250E0 Offset: 0x8242E0 VA: 0x1808250E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerStatsData.<>c__DisplayClass35_0 // TypeDefIndex: 2628
{
	// Fields
	public PlayerStatsData <>4__this; // 0x10
	public Dictionary<StatID, uint> statsBeingIngested; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82CC20 Offset: 0x82BE20 VA: 0x18082CC20
	internal void <SaveStats>b__0(ref IngestStatCompleteCallbackInfo data) { }

	// RVA: 0x82CF50 Offset: 0x82C150 VA: 0x18082CF50
	internal void <SaveStats>b__1() { }
}

// Namespace: AmongUs.Data.Player
public class PlayerStatsData // TypeDefIndex: 2629
{
	// Fields
	public static readonly Logger Logger; // 0x0
	private uint level; // 0x10
	private uint xp; // 0x14
	private uint xpForNextLevel; // 0x18
	private Dictionary<StatID, uint> statsCache; // 0x20
	private Dictionary<StatID, uint> statsToIngest; // 0x28
	private bool isTrackingStats; // 0x30

	// Properties
	public bool IsTrackingStats { get; }
	public uint Level { get; set; }
	public uint Xp { get; set; }
	public uint XpForNextLevel { get; set; }

	// Methods

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_IsTrackingStats() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Level() { }

	// RVA: 0x8278B0 Offset: 0x826AB0 VA: 0x1808278B0
	public void set_Level(uint value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public uint get_Xp() { }

	// RVA: 0x827A50 Offset: 0x826C50 VA: 0x180827A50
	public void set_Xp(uint value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_XpForNextLevel() { }

	// RVA: 0x827980 Offset: 0x826B80 VA: 0x180827980
	public void set_XpForNextLevel(uint value) { }

	// RVA: 0x8263C0 Offset: 0x8255C0 VA: 0x1808263C0
	public void InitializeStats() { }

	// RVA: 0x8272A0 Offset: 0x8264A0 VA: 0x1808272A0
	public void SetStatTrackingEnabled(bool enabled) { }

	// RVA: 0x827550 Offset: 0x826750 VA: 0x180827550
	private bool ValidateStat(StatID stat) { }

	// RVA: 0x8261C0 Offset: 0x8253C0 VA: 0x1808261C0
	public void IncrementStat(StatID stat) { }

	// RVA: 0x8264C0 Offset: 0x8256C0 VA: 0x1808264C0
	public void ResetStat(StatID stat) { }

	// RVA: 0x826040 Offset: 0x825240 VA: 0x180826040
	public uint GetStat(StatID stat) { }

	// RVA: 0x826F80 Offset: 0x826180 VA: 0x180826F80
	public void SetStatAsMinTime(StatID stat, float timeInSeconds) { }

	// RVA: 0x826010 Offset: 0x825210 VA: 0x180826010
	public float GetStatAsMinTime(StatID stat) { }

	// RVA: 0x825F40 Offset: 0x825140 VA: 0x180825F40
	public string GetStatAsMinTimeString(StatID stat) { }

	// RVA: 0x825E80 Offset: 0x825080 VA: 0x180825E80
	public uint GetMapStat(MapNames map, MapStat stat) { }

	// RVA: 0x826100 Offset: 0x825300 VA: 0x180826100
	public void IncrementMapStat(MapNames map, MapStat stat) { }

	// RVA: 0x827530 Offset: 0x826730 VA: 0x180827530
	private static RoleTypes ValidateRole(RoleTypes role) { }

	// RVA: 0x825EB0 Offset: 0x8250B0 VA: 0x180825EB0
	public uint GetRoleStat(RoleTypes role, RoleStat stat) { }

	// RVA: 0x826130 Offset: 0x825330 VA: 0x180826130
	public void IncrementRoleStat(RoleTypes role, RoleStat stat) { }

	// RVA: 0x825E50 Offset: 0x825050 VA: 0x180825E50
	public uint GetGameResultStat(GameOverReason reason, GameResultStat stat) { }

	// RVA: 0x8260D0 Offset: 0x8252D0 VA: 0x1808260D0
	public void IncrementGameResultStat(GameOverReason reason, GameResultStat stat) { }

	// RVA: 0x826300 Offset: 0x825500 VA: 0x180826300
	public void IncrementWinStats(GameOverReason reason, MapNames map, RoleTypes role) { }

	// RVA: 0x826610 Offset: 0x825810 VA: 0x180826610
	public void SaveStats() { }

	// RVA: 0x8259D0 Offset: 0x824BD0 VA: 0x1808259D0
	private void CacheStats(StatID[] stats) { }

	// RVA: 0x827810 Offset: 0x826A10 VA: 0x180827810
	public void .ctor() { }

	// RVA: 0x827750 Offset: 0x826950 VA: 0x180827750
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x827380 Offset: 0x826580 VA: 0x180827380
	private void <InitializeStats>b__18_0() { }
}

// Namespace: AmongUs.Data.Player
[JsonObject(1)]
public class PlayerStoreData : AbstractSaveDataGroup // TypeDefIndex: 2630
{
	// Fields
	public const string DEFAULT_ACTIVE_COSMICUBE = "";
	public static readonly DateTime DEFAULT_LAST_VIEW_DATE; // 0x0
	[JsonProperty("activeCosmicube")]
	private string activeCosmicube; // 0x18
	[JsonProperty("bundlesViewDate")]
	private DateTime bundlesViewDate; // 0x20
	[JsonProperty("hatsViewDate")]
	private DateTime hatsViewDate; // 0x28
	[JsonProperty("outfitsViewDate")]
	private DateTime outfitsViewDate; // 0x30
	[JsonProperty("visorsViewDate")]
	private DateTime visorsViewDate; // 0x38
	[JsonProperty("petsViewDate")]
	private DateTime petsViewDate; // 0x40
	[JsonProperty("nameplatesViewDate")]
	private DateTime nameplatesViewDate; // 0x48
	[JsonProperty("cosmicubeViewDate")]
	private DateTime cosmicubeViewDate; // 0x50
	[JsonProperty("legacyPurchases")]
	private List<string> legacyPurchases; // 0x58
	[CompilerGenerated]
	private Action OnActiveCosmicubeChanged; // 0x60
	[CompilerGenerated]
	private Action OnBundlesViewDateChanged; // 0x68
	[CompilerGenerated]
	private Action OnHatsViewDateChanged; // 0x70
	[CompilerGenerated]
	private Action OnOutfitsViewDateChanged; // 0x78
	[CompilerGenerated]
	private Action OnVisorsViewDateChanged; // 0x80
	[CompilerGenerated]
	private Action OnPetsViewDateChanged; // 0x88
	[CompilerGenerated]
	private Action OnNameplatesViewDateChanged; // 0x90
	[CompilerGenerated]
	private Action OnCosmicubeViewDateChanged; // 0x98
	[CompilerGenerated]
	private Action OnHasGeoffHatDropChanged; // 0xA0
	[CompilerGenerated]
	private Action OnHasTestPetDropChanged; // 0xA8
	[CompilerGenerated]
	private Action OnHasTrafficPurpleHatDropChanged; // 0xB0
	[CompilerGenerated]
	private Action OnCachedPurchasedBundlesChanged; // 0xB8
	public const string LEGACY_PURCHASE_GEOFF_HAT = "hat_geoff";
	public const string LEGACY_PURCHASE_TEST_PET = "pet_test";
	public const string LEGACY_PURCHASE_PURPLE_TRAFFIC_HAT = "hat_traffic_purple";
	public const string LEGACY_PURCHASE_NEW_YEARS_2018_HAT = "hats_newyears2018";
	public const string LEGACY_PURCHASE_HOLIDAY_2018_HAT = "hat_holiday2018";
	public const string LEGACY_PURCHASE_HALLOWEEN_HAT_2019 = "hats_halloween2019";
	public static readonly string[] LEGACY_PURCHASE_KEYS; // 0x8

	// Properties
	public string ActiveCosmicube { get; set; }
	public DateTime LastBundlesViewDate { get; set; }
	public DateTime LastHatsViewDate { get; set; }
	public DateTime LastOutfitsViewDate { get; set; }
	public DateTime LastVisorsViewDate { get; set; }
	public DateTime LastPetsViewDate { get; set; }
	public DateTime LastNameplatesViewDate { get; set; }
	public DateTime LastCosmicubeViewDate { get; set; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ActiveCosmicube() { }

	// RVA: 0x829900 Offset: 0x828B00 VA: 0x180829900
	public void set_ActiveCosmicube(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DateTime get_LastBundlesViewDate() { }

	// RVA: 0x829980 Offset: 0x828B80 VA: 0x180829980
	public void set_LastBundlesViewDate(DateTime value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public DateTime get_LastHatsViewDate() { }

	// RVA: 0x829A80 Offset: 0x828C80 VA: 0x180829A80
	public void set_LastHatsViewDate(DateTime value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public DateTime get_LastOutfitsViewDate() { }

	// RVA: 0x829B80 Offset: 0x828D80 VA: 0x180829B80
	public void set_LastOutfitsViewDate(DateTime value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public DateTime get_LastVisorsViewDate() { }

	// RVA: 0x829C80 Offset: 0x828E80 VA: 0x180829C80
	public void set_LastVisorsViewDate(DateTime value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public DateTime get_LastPetsViewDate() { }

	// RVA: 0x829C00 Offset: 0x828E00 VA: 0x180829C00
	public void set_LastPetsViewDate(DateTime value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public DateTime get_LastNameplatesViewDate() { }

	// RVA: 0x829B00 Offset: 0x828D00 VA: 0x180829B00
	public void set_LastNameplatesViewDate(DateTime value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public DateTime get_LastCosmicubeViewDate() { }

	// RVA: 0x829A00 Offset: 0x828C00 VA: 0x180829A00
	public void set_LastCosmicubeViewDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x828900 Offset: 0x827B00 VA: 0x180828900
	public void add_OnActiveCosmicubeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829100 Offset: 0x828300 VA: 0x180829100
	public void remove_OnActiveCosmicubeChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8289A0 Offset: 0x827BA0 VA: 0x1808289A0
	public void add_OnBundlesViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8291A0 Offset: 0x8283A0 VA: 0x1808291A0
	public void remove_OnBundlesViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828DB0 Offset: 0x827FB0 VA: 0x180828DB0
	public void add_OnHatsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8295B0 Offset: 0x8287B0 VA: 0x1808295B0
	public void remove_OnHatsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828F00 Offset: 0x828100 VA: 0x180828F00
	public void add_OnOutfitsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829700 Offset: 0x828900 VA: 0x180829700
	public void remove_OnOutfitsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829050 Offset: 0x828250 VA: 0x180829050
	public void add_OnVisorsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829850 Offset: 0x828A50 VA: 0x180829850
	public void remove_OnVisorsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828FA0 Offset: 0x8281A0 VA: 0x180828FA0
	public void add_OnPetsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8297A0 Offset: 0x8289A0 VA: 0x1808297A0
	public void remove_OnPetsViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828E50 Offset: 0x828050 VA: 0x180828E50
	public void add_OnNameplatesViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829650 Offset: 0x828850 VA: 0x180829650
	public void remove_OnNameplatesViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828AF0 Offset: 0x827CF0 VA: 0x180828AF0
	public void add_OnCosmicubeViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8292F0 Offset: 0x8284F0 VA: 0x1808292F0
	public void remove_OnCosmicubeViewDateChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828BA0 Offset: 0x827DA0 VA: 0x180828BA0
	public void add_OnHasGeoffHatDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8293A0 Offset: 0x8285A0 VA: 0x1808293A0
	public void remove_OnHasGeoffHatDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828C50 Offset: 0x827E50 VA: 0x180828C50
	public void add_OnHasTestPetDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829450 Offset: 0x828650 VA: 0x180829450
	public void remove_OnHasTestPetDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828D00 Offset: 0x827F00 VA: 0x180828D00
	public void add_OnHasTrafficPurpleHatDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829500 Offset: 0x828700 VA: 0x180829500
	public void remove_OnHasTrafficPurpleHatDropChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x828A40 Offset: 0x827C40 VA: 0x180828A40
	public void add_OnCachedPurchasedBundlesChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x829240 Offset: 0x828440 VA: 0x180829240
	public void remove_OnCachedPurchasedBundlesChanged(Action value) { }

	// RVA: 0x827C50 Offset: 0x826E50 VA: 0x180827C50
	public DateTime GetStoreTabViewDate(StoreTab tab) { }

	// RVA: 0x828100 Offset: 0x827300 VA: 0x180828100
	public void SetStoreTabViewDate(StoreTab tab, DateTime val) { }

	// RVA: 0x827E40 Offset: 0x827040 VA: 0x180827E40
	public void MigrateLegacyPurchases() { }

	// RVA: 0x828430 Offset: 0x827630 VA: 0x180828430
	private void TryMigrateLegacyUnlock(string key) { }

	// RVA: 0x827DE0 Offset: 0x826FE0 VA: 0x180827DE0
	public bool HasLegacyPurchase(string key) { }

	// RVA: 0x827C00 Offset: 0x826E00 VA: 0x180827C00
	public string[] GetLegacyPurchases() { }

	// RVA: 0x827B20 Offset: 0x826D20 VA: 0x180827B20
	public void AddLegacyPurchases(string[] keys) { }

	// RVA: 0x8287C0 Offset: 0x8279C0 VA: 0x1808287C0
	public void .ctor() { }

	// RVA: 0x828660 Offset: 0x827860 VA: 0x180828660
	private static void .cctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public abstract class AbstractAnimationTestScenePage : MonoBehaviour // TypeDefIndex: 2631
{
	// Fields
	[SerializeField]
	private Selectable defaultSelection; // 0x20
	private AnimationTestScene testScene; // 0x28

	// Properties
	protected AnimationTestScene Parent { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected AnimationTestScene get_Parent() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void Initialize(AnimationTestScene testScene) { }

	// RVA: 0x811D10 Offset: 0x810F10 VA: 0x180811D10
	public void SetActive(bool active) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected virtual void OnShow() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void OnHide() { }

	// RVA: 0x811CB0 Offset: 0x810EB0 VA: 0x180811CB0
	protected void Select(GameObject gameObject) { }

	// RVA: 0x811C20 Offset: 0x810E20 VA: 0x180811C20
	protected bool GetButtonDown(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x811C80 Offset: 0x810E80 VA: 0x180811C80
	protected bool GetButton(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x811C50 Offset: 0x810E50 VA: 0x180811C50
	protected bool GetButtonUp(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestScene : MonoBehaviour // TypeDefIndex: 2632
{
	// Fields
	[SerializeField]
	private Canvas canvas; // 0x20
	[Header("Audio")]
	[SerializeField]
	private AudioSource onTabChangeSfx; // 0x28
	[Header("Rewired")]
	[SerializeField]
	private RewiredEventSystem rewiredEventSystem; // 0x30
	[SerializeField]
	private RewiredStandaloneInputModule rewiredStandaloneInputModule; // 0x38
	[SerializeField]
	[Header("Prefabs")]
	private InputManager rewiredInputManagerPrefab; // 0x40
	private AnimationTestSceneCosmeticData cosmeticData; // 0x48
	private AnimationTestSceneTab[] tabs; // 0x50
	private AbstractAnimationTestScenePage[] pages; // 0x58
	private AnimationTestSceneTab currentTab; // 0x60
	private InputManager rewiredInputManager; // 0x68
	private Player inputPlayer; // 0x70

	// Properties
	public AnimationTestSceneCosmeticData CosmeticData { get; }

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public AnimationTestSceneCosmeticData get_CosmeticData() { }

	// RVA: 0x817070 Offset: 0x816270 VA: 0x180817070 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x8179E0 Offset: 0x816BE0 VA: 0x1808179E0
	protected void Update() { }

	// RVA: 0x8179E0 Offset: 0x816BE0 VA: 0x1808179E0
	private void ProcessPageInput() { }

	// RVA: 0x817960 Offset: 0x816B60 VA: 0x180817960
	private void OnTabClicked(AnimationTestSceneTab tab) { }

	// RVA: 0x8175C0 Offset: 0x8167C0 VA: 0x1808175C0
	private void ChangePage(int direction) { }

	// RVA: 0x817960 Offset: 0x816B60 VA: 0x180817960
	private void ChangePage(AnimationTestSceneTab tab) { }

	// RVA: 0x8176B0 Offset: 0x8168B0 VA: 0x1808176B0
	private void ChangePage(AbstractAnimationTestScenePage newPage) { }

	// RVA: 0x817980 Offset: 0x816B80 VA: 0x180817980
	public bool GetButtonDown(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x8179C0 Offset: 0x816BC0 VA: 0x1808179C0
	public bool GetButton(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x8179A0 Offset: 0x816BA0 VA: 0x1808179A0
	public bool GetButtonUp(RewiredConstsEnum.DebugAction action) { }

	// RVA: 0x817A60 Offset: 0x816C60 VA: 0x180817A60
	public void ReturnToStartPage() { }

	// RVA: 0x817AA0 Offset: 0x816CA0 VA: 0x180817AA0
	public void ToggleCanvas(bool visible) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void AddDebugCommand() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RemoveDebugCommand() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void OpenDebugConsole() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneButton : MonoBehaviour // TypeDefIndex: 2633
{
	// Fields
	[SerializeField]
	private Button button; // 0x20
	[SerializeField]
	private GameObject toggleIcon; // 0x28
	[SerializeField]
	private TextMeshProUGUI text; // 0x30
	private bool toggled; // 0x38
	[CompilerGenerated]
	private Action<AnimationTestSceneButton> OnPressEvent; // 0x40

	// Properties
	public bool Toggled { get; }
	public TextMeshProUGUI Text { get; }

	// Methods

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_Toggled() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public TextMeshProUGUI get_Text() { }

	[CompilerGenerated]
	// RVA: 0x812140 Offset: 0x811340 VA: 0x180812140
	public void add_OnPressEvent(Action<AnimationTestSceneButton> value) { }

	[CompilerGenerated]
	// RVA: 0x8121F0 Offset: 0x8113F0 VA: 0x1808121F0
	public void remove_OnPressEvent(Action<AnimationTestSceneButton> value) { }

	// RVA: 0x811FF0 Offset: 0x8111F0 VA: 0x180811FF0
	private void Awake() { }

	// RVA: 0x812090 Offset: 0x811290 VA: 0x180812090
	private void OnClick() { }

	// RVA: 0x8120B0 Offset: 0x8112B0 VA: 0x1808120B0
	public void SetToggle(bool toggled) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneCosmeticData // TypeDefIndex: 2634
{
	// Fields
	private const string DEFAULT_NAME = "amogus";
	private string name; // 0x10
	private CrewmateColor color; // 0x18
	private HatData hat; // 0x20
	private VisorData visor; // 0x28
	private SkinData skin; // 0x30
	private PetData pet; // 0x38
	private NamePlateData nameplate; // 0x40

	// Properties
	public string Name { get; }
	public CrewmateColor Color { get; }
	public HatData Hat { get; }
	public VisorData Visor { get; }
	public SkinData Skin { get; }
	public PetData Pet { get; }
	public NamePlateData NamePlate { get; }
	public byte ColorID { get; }
	public string HatID { get; }
	public string VisorID { get; }
	public string SkinID { get; }
	public string PetID { get; }
	public string NamePlateID { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public CrewmateColor get_Color() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public HatData get_Hat() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public VisorData get_Visor() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public SkinData get_Skin() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PetData get_Pet() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public NamePlateData get_NamePlate() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public byte get_ColorID() { }

	// RVA: 0x812B00 Offset: 0x811D00 VA: 0x180812B00
	public string get_HatID() { }

	// RVA: 0x812D40 Offset: 0x811F40 VA: 0x180812D40
	public string get_VisorID() { }

	// RVA: 0x812CB0 Offset: 0x811EB0 VA: 0x180812CB0
	public string get_SkinID() { }

	// RVA: 0x812C20 Offset: 0x811E20 VA: 0x180812C20
	public string get_PetID() { }

	// RVA: 0x812B90 Offset: 0x811D90 VA: 0x180812B90
	public string get_NamePlateID() { }

	// RVA: 0x812900 Offset: 0x811B00 VA: 0x180812900
	public void .ctor() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void SetColor(byte id) { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void SetColor(CrewmateColor newColor) { }

	// RVA: 0x8126D0 Offset: 0x8118D0 VA: 0x1808126D0
	public void SetHat(string id) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void SetHat(HatData data) { }

	// RVA: 0x8127F0 Offset: 0x8119F0 VA: 0x1808127F0
	public void SetVisor(string id) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void SetVisor(VisorData data) { }

	// RVA: 0x812790 Offset: 0x811990 VA: 0x180812790
	public void SetSkin(string id) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void SetSkin(SkinData data) { }

	// RVA: 0x812730 Offset: 0x811930 VA: 0x180812730
	public void SetPet(string id) { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void SetPet(PetData data) { }

	// RVA: 0x812850 Offset: 0x811A50 VA: 0x180812850
	public NetworkedPlayerInfo.PlayerOutfit ToOutfit() { }
}

// Namespace: AmongUs.AnimationTestScene
[ExecuteInEditMode]
public class AnimationTestScenePanelEditorVisibilityHelper : MonoBehaviour // TypeDefIndex: 2635
{
	// Fields
	[SerializeField]
	private GameObject root; // 0x20

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneTab : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 2636
{
	// Fields
	private static readonly Color32 COLOR_NORMAL; // 0x0
	private static readonly Color32 COLOR_OVER; // 0x4
	private static readonly Color32 COLOR_DOWN; // 0x8
	private static readonly Color32 COLOR_ACTIVE; // 0xC
	private static readonly Color32 TEXT_COLOR_NORMAL; // 0x10
	private static readonly Color32 TEXT_COLOR_OVER; // 0x14
	private static readonly Color32 TEXT_COLOR_DOWN; // 0x18
	private static readonly Color32 TEXT_COLOR_ACTIVE; // 0x1C
	[SerializeField]
	private Graphic graphic; // 0x20
	[SerializeField]
	private TextMeshProUGUI text; // 0x28
	[Space(10)]
	[SerializeField]
	private AbstractAnimationTestScenePage page; // 0x30
	private bool isActive; // 0x38
	private PointerEventData overPointer; // 0x40
	private PointerEventData downPointer; // 0x48
	[CompilerGenerated]
	private Action<AnimationTestSceneTab> OnClick; // 0x50

	// Properties
	public AbstractAnimationTestScenePage Page { get; }
	public bool IsActive { get; }

	// Methods

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public AbstractAnimationTestScenePage get_Page() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x816F10 Offset: 0x816110 VA: 0x180816F10
	public void add_OnClick(Action<AnimationTestSceneTab> value) { }

	[CompilerGenerated]
	// RVA: 0x816FC0 Offset: 0x8161C0 VA: 0x180816FC0
	public void remove_OnClick(Action<AnimationTestSceneTab> value) { }

	// RVA: 0x816BD0 Offset: 0x815DD0 VA: 0x180816BD0 Slot: 9
	protected virtual void Update() { }

	// RVA: 0x816B80 Offset: 0x815D80 VA: 0x180816B80
	protected void OnPointerClick() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void SetActive(bool active) { }

	// RVA: 0x816B80 Offset: 0x815D80 VA: 0x180816B80 Slot: 4
	private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x816BB0 Offset: 0x815DB0 VA: 0x180816BB0 Slot: 5
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x816BC0 Offset: 0x815DC0 VA: 0x180816BC0 Slot: 6
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x816BA0 Offset: 0x815DA0 VA: 0x180816BA0 Slot: 7
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x6A8640 Offset: 0x6A7840 VA: 0x1806A8640 Slot: 8
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x816E00 Offset: 0x816000 VA: 0x180816E00
	private static void .cctor() { }
}

// Namespace: 
public enum AnimationTestSceneColorsPage.State // TypeDefIndex: 2637
{
	// Fields
	public int value__; // 0x0
	public const AnimationTestSceneColorsPage.State Builder = 0;
	public const AnimationTestSceneColorsPage.State Render = 1;
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneColorsPage : AbstractAnimationTestScenePage // TypeDefIndex: 2638
{
	// Fields
	public static readonly RuntimePlatform[] SupportedPlatforms; // 0x0
	[SerializeField]
	private AnimationTestSceneColorsPageBuilder builder; // 0x30
	[SerializeField]
	private AnimationTestSceneColorsPageRenderer renderer; // 0x38
	private AnimationTestSceneColorsPage.State state; // 0x40

	// Methods

	// RVA: 0x8122A0 Offset: 0x8114A0 VA: 0x1808122A0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x8124A0 Offset: 0x8116A0 VA: 0x1808124A0 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x8124B0 Offset: 0x8116B0 VA: 0x1808124B0
	private void SetState(AnimationTestSceneColorsPage.State state) { }

	// RVA: 0x812380 Offset: 0x811580 VA: 0x180812380
	private void OnRender() { }

	// RVA: 0x812460 Offset: 0x811660 VA: 0x180812460
	private void OnRendererClose() { }

	// RVA: 0x61BAF0 Offset: 0x61ACF0 VA: 0x18061BAF0
	public void .ctor() { }

	// RVA: 0x812650 Offset: 0x811850 VA: 0x180812650
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class AnimationTestSceneEjectPage.ExileCutsceneData // TypeDefIndex: 2639
{
	// Fields
	[SerializeField]
	private string name; // 0x10
	[SerializeField]
	private ExileController cutscene; // 0x18

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x818130 Offset: 0x817330 VA: 0x180818130
	public ExileController Play(NetworkedPlayerInfo.PlayerOutfit outfit, bool voteTie, bool voteSkipped, bool isImpostor, bool confirmImpostor) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneEjectPage.<>c__DisplayClass19_0 // TypeDefIndex: 2640
{
	// Fields
	public AnimationTestSceneEjectPage.ExileCutsceneData cutscene; // 0x10
	public AnimationTestSceneEjectPage <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82CBF0 Offset: 0x82BDF0 VA: 0x18082CBF0
	internal void <InitializeButtons>b__0(AnimationTestSceneButton x) { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneEjectPage : AbstractAnimationTestScenePage // TypeDefIndex: 2641
{
	// Fields
	[Header("Eject Page")]
	[SerializeField]
	private AnimationTestSceneButton buttonTemplate; // 0x30
	[SerializeField]
	private AnimationTestSceneEjectPage.ExileCutsceneData[] cutscenes; // 0x38
	[Header("Inspector")]
	[SerializeField]
	private AnimationTestSceneButton isImpostorButton; // 0x40
	[SerializeField]
	private AnimationTestSceneButton confirmImpostorButton; // 0x48
	[SerializeField]
	private AnimationTestSceneButton voteSuccessButton; // 0x50
	[SerializeField]
	private AnimationTestSceneButton voteTiedButton; // 0x58
	[SerializeField]
	private AnimationTestSceneButton voteSkippedButton; // 0x60
	private bool isImpostor; // 0x68
	private bool confirmImpostor; // 0x69
	private bool voteTie; // 0x6A
	private bool voteSkipped; // 0x6B
	private bool showingCutscene; // 0x6C
	private ExileController currentCutscene; // 0x70
	private List<AnimationTestSceneButton> buttons; // 0x78

	// Methods

	// RVA: 0x812DD0 Offset: 0x811FD0 VA: 0x180812DD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x813890 Offset: 0x812A90 VA: 0x180813890 Slot: 6
	protected override void Update() { }

	// RVA: 0x813560 Offset: 0x812760 VA: 0x180813560 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x813530 Offset: 0x812730 VA: 0x180813530 Slot: 8
	protected override void OnHide() { }

	// RVA: 0x813010 Offset: 0x812210 VA: 0x180813010
	private void ClearButtons() { }

	// RVA: 0x8131A0 Offset: 0x8123A0 VA: 0x1808131A0
	private void InitializeButtons() { }

	// RVA: 0x813520 Offset: 0x812720 VA: 0x180813520
	private void OnCutsceneButtonClicked(AnimationTestSceneEjectPage.ExileCutsceneData cutscene) { }

	// RVA: 0x813640 Offset: 0x812840 VA: 0x180813640
	private void StartCutscene(AnimationTestSceneEjectPage.ExileCutsceneData cutscene) { }

	// RVA: 0x813170 Offset: 0x812370 VA: 0x180813170
	private void EndCutscene() { }

	// RVA: 0x813540 Offset: 0x812740 VA: 0x180813540
	private void OnIsImpostorToggled() { }

	// RVA: 0x813500 Offset: 0x812700 VA: 0x180813500
	private void OnConfirmImpostorToggled() { }

	// RVA: 0x813590 Offset: 0x812790 VA: 0x180813590
	private void OnVoteSuccessToggled() { }

	// RVA: 0x813620 Offset: 0x812820 VA: 0x180813620
	private void OnVoteTiedToggled() { }

	// RVA: 0x813570 Offset: 0x812770 VA: 0x180813570
	private void OnVoteSkippedToggled() { }

	// RVA: 0x813800 Offset: 0x812A00 VA: 0x180813800
	private void UpdateInspectorButtons() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x813540 Offset: 0x812740 VA: 0x180813540
	private void <Awake>b__14_0(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x813500 Offset: 0x812700 VA: 0x180813500
	private void <Awake>b__14_1(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x813590 Offset: 0x812790 VA: 0x180813590
	private void <Awake>b__14_2(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x813620 Offset: 0x812820 VA: 0x180813620
	private void <Awake>b__14_3(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x813570 Offset: 0x812770 VA: 0x180813570
	private void <Awake>b__14_4(AnimationTestSceneButton x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneExitPage.<CoExit>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2642
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnimationTestSceneExitPage <>4__this; // 0x20

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

	// RVA: 0x82AF50 Offset: 0x82A150 VA: 0x18082AF50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B110 Offset: 0x82A310 VA: 0x18082B110 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneExitPage : AbstractAnimationTestScenePage // TypeDefIndex: 2643
{
	// Fields
	[SerializeField]
	[Header("Exit Page")]
	private Button cancelButton; // 0x30
	[SerializeField]
	private Button exitButton; // 0x38
	[SerializeField]
	private CanvasGroup fader; // 0x40
	private bool exiting; // 0x48

	// Methods

	// RVA: 0x813920 Offset: 0x812B20 VA: 0x180813920 Slot: 4
	protected override void Awake() { }

	// RVA: 0x813A20 Offset: 0x812C20 VA: 0x180813A20
	private void Cancel() { }

	// RVA: 0x813AD0 Offset: 0x812CD0 VA: 0x180813AD0
	private void Exit() { }

	[IteratorStateMachine(typeof(AnimationTestSceneExitPage.<CoExit>d__7))]
	// RVA: 0x813A70 Offset: 0x812C70 VA: 0x180813A70
	private IEnumerator CoExit() { }

	// RVA: 0x813B40 Offset: 0x812D40 VA: 0x180813B40
	private void SetFaderAlpha(float value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneInfoPage : AbstractAnimationTestScenePage // TypeDefIndex: 2644
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AnimationTestSceneKillPage.AnimData // TypeDefIndex: 2645
{
	// Fields
	[SerializeField]
	private string name; // 0x10
	[SerializeField]
	private OverlayKillAnimation prefab; // 0x18

	// Properties
	public string Name { get; }
	public OverlayKillAnimation Prefab { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public OverlayKillAnimation get_Prefab() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneKillPage.<>c__DisplayClass11_0 // TypeDefIndex: 2646
{
	// Fields
	public AnimationTestSceneKillPage <>4__this; // 0x10
	public AnimationTestSceneKillPage.AnimData anim; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82CA60 Offset: 0x82BC60 VA: 0x18082CA60
	internal void <CreateButton>b__0(AnimationTestSceneButton x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneKillPage.<CoShowAnimation>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2647
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnimationTestSceneKillPage <>4__this; // 0x20
	public OverlayKillAnimation animPrefab; // 0x28
	public KillOverlayInitData initData; // 0x30
	private OverlayKillAnimation <anim>5__2; // 0x38

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

	// RVA: 0x82BE70 Offset: 0x82B070 VA: 0x18082BE70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82C050 Offset: 0x82B250 VA: 0x18082C050 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneKillPage : AbstractAnimationTestScenePage // TypeDefIndex: 2648
{
	// Fields
	[SerializeField]
	[Header("Kill Page")]
	private Transform genericButtonContainer; // 0x30
	[SerializeField]
	private Transform cosmeticButtonContainer; // 0x38
	[SerializeField]
	private KillOverlay killOverlay; // 0x40
	[SerializeField]
	private AnimationTestSceneButton buttonTemplate; // 0x48
	[SerializeField]
	[FormerlySerializedAs("killAnimations")]
	private AnimationTestSceneKillPage.AnimData[] genericKillAnimations; // 0x50
	[SerializeField]
	private AnimationTestSceneKillPage.AnimData[] cosmeticKillAnimations; // 0x58
	private List<AnimationTestSceneButton> buttons; // 0x60

	// Methods

	// RVA: 0x814220 Offset: 0x813420 VA: 0x180814220 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x814210 Offset: 0x813410 VA: 0x180814210 Slot: 8
	protected override void OnHide() { }

	// RVA: 0x813B60 Offset: 0x812D60 VA: 0x180813B60
	private void ClearButtons() { }

	// RVA: 0x813F40 Offset: 0x813140 VA: 0x180813F40
	private void InitializeButtons() { }

	// RVA: 0x813D40 Offset: 0x812F40 VA: 0x180813D40
	private void CreateButton(AnimationTestSceneKillPage.AnimData anim, Transform parent) { }

	// RVA: 0x8140E0 Offset: 0x8132E0 VA: 0x1808140E0
	private void OnAnimButtonClicked(OverlayKillAnimation animPrefab) { }

	// RVA: 0x8140E0 Offset: 0x8132E0 VA: 0x1808140E0
	private void PlayKillAnim(OverlayKillAnimation animPrefab) { }

	[IteratorStateMachine(typeof(AnimationTestSceneKillPage.<CoShowAnimation>d__14))]
	// RVA: 0x813CC0 Offset: 0x812EC0 VA: 0x180813CC0
	private IEnumerator CoShowAnimation(OverlayKillAnimation animPrefab, KillOverlayInitData initData) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AnimationTestSceneMeetingPage.AnimData // TypeDefIndex: 2649
{
	// Fields
	[SerializeField]
	private string name; // 0x10
	[SerializeField]
	private MeetingCalledAnimation prefab; // 0x18

	// Properties
	public string Name { get; }
	public MeetingCalledAnimation Prefab { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MeetingCalledAnimation get_Prefab() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneMeetingPage.<>c__DisplayClass7_0 // TypeDefIndex: 2650
{
	// Fields
	public AnimationTestSceneMeetingPage.AnimData killAnimation; // 0x10
	public AnimationTestSceneMeetingPage <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82CFF0 Offset: 0x82C1F0 VA: 0x18082CFF0
	internal void <InitializeButtons>b__0(AnimationTestSceneButton x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestSceneMeetingPage.<CoShowAnimation>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2651
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnimationTestSceneMeetingPage <>4__this; // 0x20
	public MeetingCalledAnimation animPrefab; // 0x28
	private MeetingCalledAnimation <anim>5__2; // 0x30

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

	// RVA: 0x82BC50 Offset: 0x82AE50 VA: 0x18082BC50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82BE30 Offset: 0x82B030 VA: 0x18082BE30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneMeetingPage : AbstractAnimationTestScenePage // TypeDefIndex: 2652
{
	// Fields
	[Header("Meeting Page")]
	[SerializeField]
	private KillOverlay killOverlay; // 0x30
	[SerializeField]
	private AnimationTestSceneButton buttonTemplate; // 0x38
	[SerializeField]
	private AnimationTestSceneMeetingPage.AnimData[] meetingAnimations; // 0x40
	private List<AnimationTestSceneButton> buttons; // 0x48

	// Methods

	// RVA: 0x8147F0 Offset: 0x8139F0 VA: 0x1808147F0 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x8147E0 Offset: 0x8139E0 VA: 0x1808147E0 Slot: 8
	protected override void OnHide() { }

	// RVA: 0x814230 Offset: 0x813430 VA: 0x180814230
	private void ClearButtons() { }

	// RVA: 0x814400 Offset: 0x813600 VA: 0x180814400
	private void InitializeButtons() { }

	// RVA: 0x814760 Offset: 0x813960 VA: 0x180814760
	private void OnAnimButtonClicked(MeetingCalledAnimation animPrefab) { }

	// RVA: 0x814760 Offset: 0x813960 VA: 0x180814760
	private void PlayMeetingAnimation(MeetingCalledAnimation animPrefab) { }

	[IteratorStateMachine(typeof(AnimationTestSceneMeetingPage.<CoShowAnimation>d__10))]
	// RVA: 0x814390 Offset: 0x813590 VA: 0x180814390
	private IEnumerator CoShowAnimation(MeetingCalledAnimation animPrefab) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestScenePetsPage : AbstractAnimationTestScenePage // TypeDefIndex: 2653
{
	// Fields
	private const float SCALE_NORMAL = 75;
	private const float SCALE_ZOOMED = 150;
	[Header("Pet Page")]
	[SerializeField]
	private GameObject emptyPage; // 0x30
	[Space(10)]
	[SerializeField]
	private GameObject visiblePage; // 0x38
	[SerializeField]
	private RectTransform zoomedContainer; // 0x40
	[SerializeField]
	private RectTransform idleContainer; // 0x48
	[SerializeField]
	private RectTransform walkingContainer; // 0x50
	[SerializeField]
	private RectTransform scaredContainer; // 0x58
	[SerializeField]
	private RectTransform mourningContainer; // 0x60
	[SerializeField]
	private RectTransform pettingContainer; // 0x68
	private PetData petData; // 0x70
	private byte color; // 0x78
	private PetBehaviour[] petViews; // 0x80
	private PetBehaviour zoomed; // 0x88
	private PetBehaviour idle; // 0x90
	private PetBehaviour walking; // 0x98
	private PetBehaviour scared; // 0xA0
	private PetBehaviour mourning; // 0xA8
	private PetBehaviour petting; // 0xB0

	// Methods

	// RVA: 0x815180 Offset: 0x814380 VA: 0x180815180 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected override void OnHide() { }

	// RVA: 0x815190 Offset: 0x814390 VA: 0x180815190
	private void TryLoadPet() { }

	// RVA: 0x814800 Offset: 0x813A00 VA: 0x180814800
	private void ClearPet() { }

	// RVA: 0x814AB0 Offset: 0x813CB0 VA: 0x180814AB0
	private void LoadPet(PetData newPet, byte newColor) { }

	// RVA: 0x814CD0 Offset: 0x813ED0 VA: 0x180814CD0
	private void OnLoadSuccess(PetBehaviour prefab) { }

	// RVA: 0x814C70 Offset: 0x813E70 VA: 0x180814C70
	private void OnLoadError() { }

	// RVA: 0x814910 Offset: 0x813B10 VA: 0x180814910
	public PetBehaviour InstantiatePet(PetBehaviour prefab, RectTransform container, float scale) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<>c__DisplayClass18_0 // TypeDefIndex: 2654
{
	// Fields
	public AnimationTestScenePlayerPageBodyToggle bodyButton; // 0x10
	public AnimationTestScenePlayerPage <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x82CBB0 Offset: 0x82BDB0 VA: 0x18082CBB0
	internal void <Awake>b__0(AnimationTestSceneButton x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoIdle>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2655
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B150 Offset: 0x82A350 VA: 0x18082B150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B1F0 Offset: 0x82A3F0 VA: 0x18082B1F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoLoopClimbDown>d__40 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2656
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B230 Offset: 0x82A430 VA: 0x18082B230 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B3B0 Offset: 0x82A5B0 VA: 0x18082B3B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoLoopClimbUp>d__38 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2657
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B3F0 Offset: 0x82A5F0 VA: 0x18082B3F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B570 Offset: 0x82A770 VA: 0x18082B570 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoLoopEnterVent>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2658
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B5B0 Offset: 0x82A7B0 VA: 0x18082B5B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B790 Offset: 0x82A990 VA: 0x18082B790 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoLoopExitVent>d__36 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2659
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B7D0 Offset: 0x82A9D0 VA: 0x18082B7D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82B9B0 Offset: 0x82ABB0 VA: 0x18082B9B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<CoLoopSpawn>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2660
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerControl view; // 0x20

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

	// RVA: 0x82B9F0 Offset: 0x82ABF0 VA: 0x18082B9F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82BC10 Offset: 0x82AE10 VA: 0x18082BC10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AnimationTestScenePlayerPage.<DelayAnimations>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2661
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AnimationTestScenePlayerPage <>4__this; // 0x20
	public List<PlayerControl> allIdle; // 0x28
	public List<PlayerControl> allWalking; // 0x30
	public List<PlayerControl> allSpawn; // 0x38
	public PlayerControl ventEnter; // 0x40
	public PlayerControl ventExit; // 0x48
	public PlayerControl climbDown; // 0x50
	public PlayerControl climbUp; // 0x58
	public List<PlayerControl> allMirrored; // 0x60

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

	// RVA: 0x82C090 Offset: 0x82B290 VA: 0x18082C090 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x82C6E0 Offset: 0x82B8E0 VA: 0x18082C6E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestScenePlayerPage : AbstractAnimationTestScenePage // TypeDefIndex: 2662
{
	// Fields
	private static readonly Vector3 PLAYER_CONTROL_SCALE; // 0x0
	[SerializeField]
	[Header("Player Animations Page")]
	private AnimationTestSceneButton isDeadButton; // 0x30
	[Header("Anim Containers")]
	[SerializeField]
	private RectTransform idleContainer; // 0x38
	[SerializeField]
	private RectTransform idleMirroredContainer; // 0x40
	[SerializeField]
	private RectTransform walkContainer; // 0x48
	[SerializeField]
	private RectTransform walkMirroredContainer; // 0x50
	[SerializeField]
	private RectTransform spawnContainer; // 0x58
	[SerializeField]
	private RectTransform spawnMirroredContainer; // 0x60
	[SerializeField]
	private RectTransform ventEnterContainer; // 0x68
	[SerializeField]
	private RectTransform ventExitContainer; // 0x70
	[SerializeField]
	private RectTransform jumpContainer; // 0x78
	[SerializeField]
	private RectTransform climbUpContainer; // 0x80
	[SerializeField]
	private RectTransform climbDownContainer; // 0x88
	[SerializeField]
	[Header("Prefabs")]
	private PlayerControl playerControlPrefab; // 0x90
	private bool isDead; // 0x98
	private PlayerBodyTypes bodyType; // 0x9C
	private List<PlayerControl> all; // 0xA0
	private AnimationTestScenePlayerPageBodyToggle[] bodyButtons; // 0xA8

	// Methods

	// RVA: 0x815870 Offset: 0x814A70 VA: 0x180815870 Slot: 4
	protected override void Awake() { }

	// RVA: 0x8169C0 Offset: 0x815BC0 VA: 0x1808169C0 Slot: 7
	protected override void OnShow() { }

	// RVA: 0x816970 Offset: 0x815B70 VA: 0x180816970 Slot: 8
	protected override void OnHide() { }

	// RVA: 0x815A30 Offset: 0x814C30 VA: 0x180815A30
	private void ClearViews() { }

	// RVA: 0x815E90 Offset: 0x815090 VA: 0x180815E90
	private void InitializeViews() { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<DelayAnimations>d__23))]
	// RVA: 0x815DD0 Offset: 0x814FD0 VA: 0x180815DD0
	private IEnumerator DelayAnimations(List<PlayerControl> allIdle, List<PlayerControl> allWalking, List<PlayerControl> allSpawn, PlayerControl ventEnter, PlayerControl ventExit, PlayerControl climbDown, PlayerControl climbUp, List<PlayerControl> allMirrored) { }

	// RVA: 0x816400 Offset: 0x815600 VA: 0x180816400
	private PlayerControl InstantiatePlayerControl(RectTransform container) { }

	// RVA: 0x8167A0 Offset: 0x8159A0 VA: 0x1808167A0
	private PlayerControl InstantiateView(RectTransform container, List<PlayerControl>[] extraLists) { }

	// RVA: 0x816980 Offset: 0x815B80 VA: 0x180816980
	private void OnIsDeadButtonPressed(AnimationTestSceneButton button) { }

	// RVA: 0x816AF0 Offset: 0x815CF0 VA: 0x180816AF0
	private void UpdateIsDeadButton() { }

	// RVA: 0x816940 Offset: 0x815B40 VA: 0x180816940
	private void OnBodyButtonPressed(PlayerBodyTypes bodyType) { }

	// RVA: 0x8169D0 Offset: 0x815BD0 VA: 0x1808169D0
	private void UpdateBodyButtons() { }

	// RVA: 0x815740 Offset: 0x814940 VA: 0x180815740
	private void AnimatePlayerIdle(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoIdle>d__31))]
	// RVA: 0x815B90 Offset: 0x814D90 VA: 0x180815B90
	private IEnumerator CoIdle(PlayerControl view) { }

	// RVA: 0x815820 Offset: 0x814A20 VA: 0x180815820
	private void AnimatePlayerWalk(PlayerControl view) { }

	// RVA: 0x815660 Offset: 0x814860 VA: 0x180815660
	private void AnimatePlayerEnterVent(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoLoopEnterVent>d__34))]
	// RVA: 0x815CB0 Offset: 0x814EB0 VA: 0x180815CB0
	private IEnumerator CoLoopEnterVent(PlayerControl view) { }

	// RVA: 0x8156D0 Offset: 0x8148D0 VA: 0x1808156D0
	private void AnimatePlayerExitVent(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoLoopExitVent>d__36))]
	// RVA: 0x815D10 Offset: 0x814F10 VA: 0x180815D10
	private IEnumerator CoLoopExitVent(PlayerControl view) { }

	// RVA: 0x8155F0 Offset: 0x8147F0 VA: 0x1808155F0
	private void AnimatePlayerClimbUpLadder(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoLoopClimbUp>d__38))]
	// RVA: 0x815C50 Offset: 0x814E50 VA: 0x180815C50
	private IEnumerator CoLoopClimbUp(PlayerControl view) { }

	// RVA: 0x815580 Offset: 0x814780 VA: 0x180815580
	private void AnimatePlayerClimbDownLadder(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoLoopClimbDown>d__40))]
	// RVA: 0x815BF0 Offset: 0x814DF0 VA: 0x180815BF0
	private IEnumerator CoLoopClimbDown(PlayerControl view) { }

	// RVA: 0x8157B0 Offset: 0x8149B0 VA: 0x1808157B0
	private void AnimatePlayerSpawn(PlayerControl view) { }

	[IteratorStateMachine(typeof(AnimationTestScenePlayerPage.<CoLoopSpawn>d__42))]
	// RVA: 0x815D70 Offset: 0x814F70 VA: 0x180815D70
	private IEnumerator CoLoopSpawn(PlayerControl view) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x816B20 Offset: 0x815D20 VA: 0x180816B20
	private static void .cctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneColorsPageBuilder : MonoBehaviour // TypeDefIndex: 2663
{
	// Fields
	private const float DEFAULT_SCALE = 0,5;
	private static readonly string[] VALID_FILE_TYPES; // 0x0
	[Header("File Import")]
	[SerializeField]
	private TMP_InputField importInputField; // 0x20
	[SerializeField]
	private AnimationTestSceneButton findFileButton; // 0x28
	[SerializeField]
	private AnimationTestSceneButton importButton; // 0x30
	[Header("Inspector")]
	[SerializeField]
	private GameObject inspectorEmptyPanel; // 0x38
	[SerializeField]
	private GameObject inspectorSelectionPanel; // 0x40
	[SerializeField]
	private TextMeshProUGUI inspectorNameText; // 0x48
	[SerializeField]
	private TextMeshProUGUI inspectorScaleText; // 0x50
	[SerializeField]
	private AnimationTestSceneButton inspectorScaleDownButton; // 0x58
	[SerializeField]
	private AnimationTestSceneButton inspectorScaleUpButton; // 0x60
	[SerializeField]
	private AnimationTestSceneButton inspectorOrderTopButton; // 0x68
	[SerializeField]
	private AnimationTestSceneButton inspectorOrderUpButton; // 0x70
	[SerializeField]
	private AnimationTestSceneButton inspectorOrderDownButton; // 0x78
	[SerializeField]
	private AnimationTestSceneButton inspectorOrderBottomButton; // 0x80
	[SerializeField]
	private AnimationTestSceneButton inspectorDeleteButton; // 0x88
	[SerializeField]
	[Header("Composition")]
	private RectTransform canvas; // 0x90
	[SerializeField]
	private AnimationTestSceneButton renderButton; // 0x98
	[SerializeField]
	[Header("Prefabs")]
	private AnimationTestSceneColorsPageBuilderSprite builderSpritePrefab; // 0xA0
	private List<AnimationTestSceneColorsPageBuilderSprite> builderSprites; // 0xA8
	private AnimationTestSceneColorsPageBuilderPresetButton[] presetButtons; // 0xB0
	private AnimationTestSceneColorsPageBuilderSprite selection; // 0xB8
	[CompilerGenerated]
	private Action OnRenderEvent; // 0xC0

	// Methods

	[CompilerGenerated]
	// RVA: 0x831390 Offset: 0x830590 VA: 0x180831390
	public void add_OnRenderEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x831440 Offset: 0x830640 VA: 0x180831440
	public void remove_OnRenderEvent(Action value) { }

	// RVA: 0x8302B0 Offset: 0x82F4B0 VA: 0x1808302B0
	private void Awake() { }

	// RVA: 0x830C10 Offset: 0x82FE10 VA: 0x180830C10
	public AnimationTestSceneColorsPageBuilderSprite[] GetComposition() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnFindFileButtonPressed(AnimationTestSceneButton button) { }

	// RVA: 0x830C60 Offset: 0x82FE60 VA: 0x180830C60
	private void OnImportPressed(AnimationTestSceneButton button) { }

	// RVA: 0x830F20 Offset: 0x830120 VA: 0x180830F20
	private void OnPresetPressed(AnimationTestSceneColorsPageBuilderPresetButton preset) { }

	// RVA: 0x82FEF0 Offset: 0x82F0F0 VA: 0x18082FEF0
	public AnimationTestSceneColorsPageBuilderSprite AddBuilderSprite(Sprite sprite, string name) { }

	// RVA: 0x830A20 Offset: 0x82FC20 VA: 0x180830A20
	private void OnBuilderSpritePressed(AnimationTestSceneColorsPageBuilderSprite builderSprite) { }

	// RVA: 0x830A20 Offset: 0x82FC20 VA: 0x180830A20
	private void ChangeSelection(AnimationTestSceneColorsPageBuilderSprite builderSprite) { }

	// RVA: 0x830940 Offset: 0x82FB40 VA: 0x180830940
	private void ChangeSelectionScale(float amount) { }

	// RVA: 0x830860 Offset: 0x82FA60 VA: 0x180830860
	private void ChangeSelectionOrder(int amount) { }

	// RVA: 0x8311A0 Offset: 0x8303A0 VA: 0x1808311A0
	private void UpdateLayerOrders() { }

	// RVA: 0x830AC0 Offset: 0x82FCC0 VA: 0x180830AC0
	private void DeleteSelection() { }

	// RVA: 0x831000 Offset: 0x830200 VA: 0x180831000
	private void UpdateInspector() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x8312D0 Offset: 0x8304D0 VA: 0x1808312D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x830F80 Offset: 0x830180 VA: 0x180830F80
	private void <Awake>b__25_0(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830F90 Offset: 0x830190 VA: 0x180830F90
	private void <Awake>b__25_1(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830FA0 Offset: 0x8301A0 VA: 0x180830FA0
	private void <Awake>b__25_2(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830FB0 Offset: 0x8301B0 VA: 0x180830FB0
	private void <Awake>b__25_3(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830FC0 Offset: 0x8301C0 VA: 0x180830FC0
	private void <Awake>b__25_4(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830FD0 Offset: 0x8301D0 VA: 0x180830FD0
	private void <Awake>b__25_5(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830AC0 Offset: 0x82FCC0 VA: 0x180830AC0
	private void <Awake>b__25_6(AnimationTestSceneButton x) { }

	[CompilerGenerated]
	// RVA: 0x830FE0 Offset: 0x8301E0 VA: 0x180830FE0
	private void <Awake>b__25_7(AnimationTestSceneButton x) { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneColorsPageBuilderPresetButton : MonoBehaviour // TypeDefIndex: 2664
{
	// Fields
	[SerializeField]
	private AnimationTestSceneButton button; // 0x20
	[SerializeField]
	private Image image; // 0x28
	[CompilerGenerated]
	private Action<AnimationTestSceneColorsPageBuilderPresetButton> OnPressEvent; // 0x30

	// Properties
	public Sprite Sprite { get; }

	// Methods

	// RVA: 0x82F3E0 Offset: 0x82E5E0 VA: 0x18082F3E0
	public Sprite get_Sprite() { }

	[CompilerGenerated]
	// RVA: 0x82F330 Offset: 0x82E530 VA: 0x18082F330
	public void add_OnPressEvent(Action<AnimationTestSceneColorsPageBuilderPresetButton> value) { }

	[CompilerGenerated]
	// RVA: 0x82F400 Offset: 0x82E600 VA: 0x18082F400
	public void remove_OnPressEvent(Action<AnimationTestSceneColorsPageBuilderPresetButton> value) { }

	// RVA: 0x82F280 Offset: 0x82E480 VA: 0x18082F280
	private void Awake() { }

	// RVA: 0x82F310 Offset: 0x82E510 VA: 0x18082F310
	private void OnPress(AnimationTestSceneButton button) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneColorsPageBuilderSprite : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 2665
{
	// Fields
	private static readonly Color32 COLOR_NORMAL; // 0x0
	private static readonly Color32 COLOR_OVER; // 0x4
	private static readonly Color32 COLOR_SELECTED; // 0x8
	[SerializeField]
	private Image image; // 0x20
	[SerializeField]
	private int order; // 0x28
	private bool isSelected; // 0x2C
	private Vector3 dragOffset; // 0x30
	private Material cachedMaterial; // 0x40
	private PointerEventData overPointer; // 0x48
	private PointerEventData downPointer; // 0x50
	private PointerEventData dragPointer; // 0x58
	[CompilerGenerated]
	private string <BuilderName>k__BackingField; // 0x60
	[CompilerGenerated]
	private Action<AnimationTestSceneColorsPageBuilderSprite> OnClick; // 0x68

	// Properties
	public RectTransform RectTransform { get; }
	public int Order { get; }
	public float Scale { get; }
	public string BuilderName { get; set; }
	private Material Material { get; }
	public bool IsActive { get; }

	// Methods

	// RVA: 0x82FDB0 Offset: 0x82EFB0 VA: 0x18082FDB0
	public RectTransform get_RectTransform() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_Order() { }

	// RVA: 0x82FE10 Offset: 0x82F010 VA: 0x18082FE10
	public float get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_BuilderName() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	private void set_BuilderName(string value) { }

	// RVA: 0x82FD40 Offset: 0x82EF40 VA: 0x18082FD40
	private Material get_Material() { }

	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x82FC90 Offset: 0x82EE90 VA: 0x18082FC90
	public void add_OnClick(Action<AnimationTestSceneColorsPageBuilderSprite> value) { }

	[CompilerGenerated]
	// RVA: 0x82FE40 Offset: 0x82F040 VA: 0x18082FE40
	public void remove_OnClick(Action<AnimationTestSceneColorsPageBuilderSprite> value) { }

	// RVA: 0x82FAF0 Offset: 0x82ECF0 VA: 0x18082FAF0
	private void Update() { }

	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void SetSelected(bool selected) { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void SetOrder(int newOrder) { }

	// RVA: 0x82F580 Offset: 0x82E780 VA: 0x18082F580
	public void SetName(string name) { }

	// RVA: 0x82F7E0 Offset: 0x82E9E0 VA: 0x18082F7E0
	public void SetSprite(Sprite sprite) { }

	// RVA: 0x82F740 Offset: 0x82E940 VA: 0x18082F740
	public void SetScale(float scale) { }

	// RVA: 0x82F600 Offset: 0x82E800 VA: 0x18082F600
	public void SetOutlineColor(Color color) { }

	// RVA: 0x82F4B0 Offset: 0x82E6B0 VA: 0x18082F4B0
	public void InstantiateAndCacheMaterial() { }

	// RVA: 0x82F560 Offset: 0x82E760 VA: 0x18082F560
	protected void OnPointerClick() { }

	// RVA: 0x82F560 Offset: 0x82E760 VA: 0x18082F560 Slot: 4
	private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x816BA0 Offset: 0x815DA0 VA: 0x180816BA0 Slot: 5
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x82FAD0 Offset: 0x82ECD0 VA: 0x18082FAD0 Slot: 6
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x82FAC0 Offset: 0x82ECC0 VA: 0x18082FAC0 Slot: 7
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x82FAE0 Offset: 0x82ECE0 VA: 0x18082FAE0 Slot: 8
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x82F860 Offset: 0x82EA60 VA: 0x18082F860 Slot: 10
	private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x82F980 Offset: 0x82EB80 VA: 0x18082F980 Slot: 9
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x82FAB0 Offset: 0x82ECB0 VA: 0x18082FAB0 Slot: 11
	private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x82FC10 Offset: 0x82EE10 VA: 0x18082FC10
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AnimationTestSceneColorsPageRenderer.<>c // TypeDefIndex: 2666
{
	// Fields
	public static readonly AnimationTestSceneColorsPageRenderer.<>c <>9; // 0x0
	public static Func<AnimationTestSceneColorsPageBuilderSprite, int> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x841150 Offset: 0x840350 VA: 0x180841150
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int <CreateComposition>b__9_0(AnimationTestSceneColorsPageBuilderSprite x) { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestSceneColorsPageRenderer : MonoBehaviour // TypeDefIndex: 2667
{
	// Fields
	[SerializeField]
	private AnimationTestSceneButton returnButton; // 0x20
	[SerializeField]
	private RectTransform container; // 0x28
	[CompilerGenerated]
	private Action OnReturnEvent; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x8327F0 Offset: 0x8319F0 VA: 0x1808327F0
	public void add_OnReturnEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x832890 Offset: 0x831A90 VA: 0x180832890
	public void remove_OnReturnEvent(Action value) { }

	// RVA: 0x8314F0 Offset: 0x8306F0 VA: 0x1808314F0
	private void Awake() { }

	// RVA: 0x831A80 Offset: 0x830C80 VA: 0x180831A80
	public void Clear() { }

	// RVA: 0x832480 Offset: 0x831680 VA: 0x180832480
	public void Render(AnimationTestSceneColorsPageBuilderSprite[] layers) { }

	// RVA: 0x831CF0 Offset: 0x830EF0 VA: 0x180831CF0
	private GameObject CreateColorCopy(GameObject composition, CrewmateColor color) { }

	// RVA: 0x831F40 Offset: 0x831140 VA: 0x180831F40
	private GameObject CreateComposition(AnimationTestSceneColorsPageBuilderSprite[] layers) { }

	// RVA: 0x831580 Offset: 0x830780 VA: 0x180831580
	private static void CenterChildren(Transform parent) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8327D0 Offset: 0x8319D0 VA: 0x1808327D0
	private void <Awake>b__5_0(AnimationTestSceneButton x) { }
}

// Namespace: AmongUs.AnimationTestScene
public class AnimationTestScenePlayerPageBodyToggle : MonoBehaviour // TypeDefIndex: 2668
{
	// Fields
	[SerializeField]
	private PlayerBodyTypes bodyType; // 0x20
	private AnimationTestSceneButton button; // 0x28

	// Properties
	public PlayerBodyTypes BodyType { get; }
	public AnimationTestSceneButton Button { get; }

	// Methods

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public PlayerBodyTypes get_BodyType() { }

	// RVA: 0x832930 Offset: 0x831B30 VA: 0x180832930
	public AnimationTestSceneButton get_Button() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Innersloth.IO
public static class FileIO // TypeDefIndex: 2669
{
	// Fields
	private static IPlatformFileIO platform; // 0x0

	// Methods

	// RVA: 0x83F6E0 Offset: 0x83E8E0 VA: 0x18083F6E0
	private static void .cctor() { }

	// RVA: 0x83F220 Offset: 0x83E420 VA: 0x18083F220
	public static string GetUserName() { }

	// RVA: 0x83F120 Offset: 0x83E320 VA: 0x18083F120
	public static string GetPlatformName() { }

	// RVA: 0x83F1A0 Offset: 0x83E3A0 VA: 0x18083F1A0
	public static string GetRootDataPath() { }

	// RVA: 0x83ED80 Offset: 0x83DF80 VA: 0x18083ED80
	public static bool Exists(string path) { }

	// RVA: 0x83F3F0 Offset: 0x83E5F0 VA: 0x18083F3F0
	public static string ReadAllText(string path) { }

	// RVA: 0x83F5E0 Offset: 0x83E7E0 VA: 0x18083F5E0
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x83F300 Offset: 0x83E500 VA: 0x18083F300
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x83F4E0 Offset: 0x83E6E0 VA: 0x18083F4E0
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x83EC90 Offset: 0x83DE90 VA: 0x18083EC90
	public static void Delete(string path) { }

	// RVA: 0x83EFD0 Offset: 0x83E1D0 VA: 0x18083EFD0
	public static string GetDataPathTo(string[] directories) { }

	// RVA: 0x83EE70 Offset: 0x83E070 VA: 0x18083EE70
	public static string FilterText(string input, string inputCompo = "") { }

	// RVA: 0x83F2A0 Offset: 0x83E4A0 VA: 0x18083F2A0
	public static bool IsCharAllowed(char i) { }
}

// Namespace: Innersloth.IO
public class DefaultFileIO : IPlatformFileIO // TypeDefIndex: 2670
{
	// Fields
	private string userName; // 0x10
	private string platformName; // 0x18

	// Methods

	// RVA: 0x83E850 Offset: 0x83DA50 VA: 0x18083E850 Slot: 13
	public virtual string GetUserName() { }

	// RVA: 0x83E720 Offset: 0x83D920 VA: 0x18083E720 Slot: 14
	public virtual string GetPlatformName() { }

	// RVA: 0x83E840 Offset: 0x83DA40 VA: 0x18083E840 Slot: 6
	public string GetRootDataPath() { }

	// RVA: 0x83E710 Offset: 0x83D910 VA: 0x18083E710 Slot: 15
	public virtual bool Exists(string path) { }

	// RVA: 0x83E8B0 Offset: 0x83DAB0 VA: 0x18083E8B0 Slot: 16
	public virtual string ReadAllText(string path) { }

	// RVA: 0x83E930 Offset: 0x83DB30 VA: 0x18083E930 Slot: 17
	public virtual void WriteAllText(string path, string contents) { }

	// RVA: 0x83E8A0 Offset: 0x83DAA0 VA: 0x18083E8A0 Slot: 18
	public virtual byte[] ReadAllBytes(string path) { }

	// RVA: 0x83E8C0 Offset: 0x83DAC0 VA: 0x18083E8C0 Slot: 19
	public virtual void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x74F040 Offset: 0x74E240 VA: 0x18074F040 Slot: 20
	public virtual void Delete(string path) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCircleBuffer.<GetEnumerator>d__6<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 2671
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public DebugCircleBuffer<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>.System.IDisposable.Dispose
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB24130 Offset: 0xB23330 VA: 0x180B24130
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>.MoveNext
	|
	|-RVA: 0xB23E70 Offset: 0xB23070 VA: 0x180B23E70
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xB23C90 Offset: 0xB22E90 VA: 0x180B23C90
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>.System.Collections.IEnumerator.Reset
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB241C0 Offset: 0xB233C0 VA: 0x180B241C0
	|-DebugCircleBuffer.<GetEnumerator>d__6<DebugLogMessage>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23D80 Offset: 0xB22F80 VA: 0x180B23D80
	|-DebugCircleBuffer.<GetEnumerator>d__6<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2672
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public DebugCircleBuffer<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0

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
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>..ctor
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>.System.IDisposable.Dispose
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4EF80 Offset: 0xF4E180 VA: 0x180F4EF80
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>.MoveNext
	|
	|-RVA: 0xF4F030 Offset: 0xF4E230 VA: 0x180F4F030
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>.System.Collections.IEnumerator.Reset
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<DebugLogMessage>.System.Collections.IEnumerator.get_Current
	|-DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Innersloth.DebugTool
public class DebugCircleBuffer<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 2673
{
	// Fields
	private readonly T[] data; // 0x0
	private int idx; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF760 Offset: 0xFBE960 VA: 0x180FBF760
	|-DebugCircleBuffer<DebugLogMessage>..ctor
	|-DebugCircleBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF1C0 Offset: 0xFBE3C0 VA: 0x180FBF1C0
	|-DebugCircleBuffer<DebugLogMessage>.Add
	|
	|-RVA: 0xFBF230 Offset: 0xFBE430 VA: 0x180FBF230
	|-DebugCircleBuffer<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF360 Offset: 0xFBE560 VA: 0x180FBF360
	|-DebugCircleBuffer<DebugLogMessage>.Clear
	|
	|-RVA: 0xFBF3E0 Offset: 0xFBE5E0 VA: 0x180FBF3E0
	|-DebugCircleBuffer<__Il2CppFullySharedGenericType>.Clear
	*/

	[IteratorStateMachine(typeof(DebugCircleBuffer.<GetEnumerator>d__6<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF5E0 Offset: 0xFBE7E0 VA: 0x180FBF5E0
	|-DebugCircleBuffer<DebugLogMessage>.GetEnumerator
	|
	|-RVA: 0xFBF530 Offset: 0xFBE730 VA: 0x180FBF530
	|-DebugCircleBuffer<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(DebugCircleBuffer.<System-Collections-IEnumerable-GetEnumerator>d__7<T>))]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBF6E0 Offset: 0xFBE8E0 VA: 0x180FBF6E0
	|-DebugCircleBuffer<DebugLogMessage>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xFBF660 Offset: 0xFBE860 VA: 0x180FBF660
	|-DebugCircleBuffer<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Innersloth.DebugTool
[Extension]
public static class DebugColorExtensions // TypeDefIndex: 2674
{
	// Methods

	[Extension]
	// RVA: 0x833390 Offset: 0x832590 VA: 0x180833390
	public static Color SetAlpha(Color c, float alpha) { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommand // TypeDefIndex: 2675
{
	// Fields
	public readonly string CommandPath; // 0x10
	public readonly MethodInfo ActionInfo; // 0x18
	public readonly object Target; // 0x20
	public string Description; // 0x28
	public bool CloseBeforeExecute; // 0x30
	private readonly Dictionary<int, string> argumentPlaceholders; // 0x38

	// Properties
	public string Directory { get; }
	public string CommandName { get; }

	// Methods

	// RVA: 0x837C90 Offset: 0x836E90 VA: 0x180837C90
	public void .ctor(string commandPath, object target, MethodInfo methodInfo) { }

	// RVA: 0x837D90 Offset: 0x836F90 VA: 0x180837D90
	public string get_Directory() { }

	// RVA: 0x837D40 Offset: 0x836F40 VA: 0x180837D40
	public string get_CommandName() { }

	// RVA: 0x837B10 Offset: 0x836D10 VA: 0x180837B10
	public string GetArgumentPlaceholder(int i) { }

	// RVA: 0x837C20 Offset: 0x836E20 VA: 0x180837C20
	public void SetArgumentPlaceholder(int i, string placeholder) { }
}

// Namespace: Innersloth.DebugTool
[Usage(64)]
public class DebugCommandAttribute : Attribute // TypeDefIndex: 2676
{
	// Fields
	public string Path; // 0x10
	public string Description; // 0x18
	public bool CloseBeforeExecute; // 0x20

	// Methods

	// RVA: 0x833F00 Offset: 0x833100 VA: 0x180833F00
	public void .ctor(string path, string description = "", bool closeBeforeExecute = False) { }
}

// Namespace: Innersloth.DebugTool
public enum DebugCommandMessageType // TypeDefIndex: 2677
{
	// Fields
	public int value__; // 0x0
	public const DebugCommandMessageType Info = 0;
	public const DebugCommandMessageType Success = 1;
	public const DebugCommandMessageType Warning = 2;
	public const DebugCommandMessageType Error = 3;
}

// Namespace: Innersloth.DebugTool
[IsReadOnly]
public struct DebugLogMessage // TypeDefIndex: 2678
{
	// Fields
	public readonly string LogString; // 0x0
	public readonly string Stacktrace; // 0x8
	public readonly LogType LogType; // 0x10

	// Methods

	// RVA: 0x838430 Offset: 0x837630 VA: 0x180838430
	public void .ctor(string logString, string stacktrace, LogType logType) { }
}

// Namespace: Innersloth.DebugTool
[Usage(2048)]
public class DebugParameterAttribute : Attribute // TypeDefIndex: 2679
{
	// Fields
	public string Placeholder; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string placeholder) { }
}

// Namespace: 
public sealed class DebugTool.LogHandler : MulticastDelegate // TypeDefIndex: 2680
{
	// Methods

	// RVA: 0x83FC90 Offset: 0x83EE90 VA: 0x18083FC90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(string message, DebugCommandMessageType type) { }

	// RVA: 0x83FC00 Offset: 0x83EE00 VA: 0x18083FC00 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, DebugCommandMessageType type, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugTool.<>c__DisplayClass25_0<T> // TypeDefIndex: 2681
{
	// Fields
	public Func<string, T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-DebugTool.<>c__DisplayClass25_0<Int32Enum>..ctor
	|-DebugTool.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <AddCustomParser>b__0(string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0C460 Offset: 0xB0B660 VA: 0x180B0C460
	|-DebugTool.<>c__DisplayClass25_0<Int32Enum>.<AddCustomParser>b__0
	|
	|-RVA: 0xB0C4B0 Offset: 0xB0B6B0 VA: 0x180B0C4B0
	|-DebugTool.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>.<AddCustomParser>b__0
	*/
}

// Namespace: Innersloth.DebugTool
public static class DebugTool // TypeDefIndex: 2682
{
	// Fields
	private static readonly List<DebugCommand> AllCommands; // 0x0
	private static readonly DebugCircleBuffer<DebugLogMessage> AllLogMessages; // 0x8
	private static readonly Dictionary<Type, Func<string, object>> CustomParsers; // 0x10
	private static readonly Dictionary<Type, Func<string[]>> CustomDropdownCollectors; // 0x18
	[CompilerGenerated]
	private static bool <ListeningToLogs>k__BackingField; // 0x20
	[CompilerGenerated]
	private static DebugTool.LogHandler OnLogMessageReceived; // 0x28
	private static Dictionary<Type, string> simpleTypeNames; // 0x30

	// Properties
	public static IReadOnlyList<DebugCommand> Commands { get; }
	public static IEnumerator<DebugLogMessage> Logs { get; }
	public static bool ListeningToLogs { get; set; }

	// Methods

	// RVA: 0x83E490 Offset: 0x83D690 VA: 0x18083E490
	public static IReadOnlyList<DebugCommand> get_Commands() { }

	// RVA: 0x83E530 Offset: 0x83D730 VA: 0x18083E530
	public static IEnumerator<DebugLogMessage> get_Logs() { }

	[CompilerGenerated]
	// RVA: 0x83E4E0 Offset: 0x83D6E0 VA: 0x18083E4E0
	public static bool get_ListeningToLogs() { }

	[CompilerGenerated]
	// RVA: 0x83E6B0 Offset: 0x83D8B0 VA: 0x18083E6B0
	private static void set_ListeningToLogs(bool value) { }

	[CompilerGenerated]
	// RVA: 0x83E390 Offset: 0x83D590 VA: 0x18083E390
	public static void add_OnLogMessageReceived(DebugTool.LogHandler value) { }

	[CompilerGenerated]
	// RVA: 0x83E5B0 Offset: 0x83D7B0 VA: 0x18083E5B0
	public static void remove_OnLogMessageReceived(DebugTool.LogHandler value) { }

	// RVA: 0x83DE30 Offset: 0x83D030 VA: 0x18083DE30
	public static void RegisterCommandHandler(object obj) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RegisterCommandHandler(Type t, object target) { }

	// RVA: 0x83DFA0 Offset: 0x83D1A0 VA: 0x18083DFA0
	public static void UnregisterCommandHandler(Type t) { }

	// RVA: 0x83DE90 Offset: 0x83D090 VA: 0x18083DE90
	public static void UnregisterCommandHandler(object obj) { }

	// RVA: 0x83D1C0 Offset: 0x83C3C0 VA: 0x18083D1C0
	public static DebugCommand AddCommand(string commandPath, Action commandAction, bool closeBeforeExecute = False) { }

	// RVA: -1 Offset: -1
	public static DebugCommand AddCommand<T>(string commandPath, Action<T> commandAction, bool closeBeforeExecute = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9561A0 Offset: 0x9553A0 VA: 0x1809561A0
	|-DebugTool.AddCommand<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static DebugCommand AddCommand<T1, T2>(string commandPath, Action<T1, T2> commandAction, bool closeBeforeExecute = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9560C0 Offset: 0x9552C0 VA: 0x1809560C0
	|-DebugTool.AddCommand<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void AddCommand(DebugCommand command) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RemoveCommand(string commandPath) { }

	// RVA: -1 Offset: -1
	public static void AddCustomParser<T>(Func<string, T> parser) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9565F0 Offset: 0x9557F0 VA: 0x1809565F0
	|-DebugTool.AddCustomParser<Int32Enum>
	|
	|-RVA: 0x9563F0 Offset: 0x9555F0 VA: 0x1809563F0
	|-DebugTool.AddCustomParser<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x83D950 Offset: 0x83CB50 VA: 0x18083D950
	public static object ParseInputToType(string rawValue, string fieldName, Type type) { }

	// RVA: -1 Offset: -1
	public static void AddCustomDropdownValueCollector<T>(Func<string[]> collector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x956280 Offset: 0x955480 VA: 0x180956280
	|-DebugTool.AddCustomDropdownValueCollector<Int32Enum>
	|-DebugTool.AddCustomDropdownValueCollector<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x83D5B0 Offset: 0x83C7B0 VA: 0x18083D5B0
	public static bool HasDropdownValueCollector(Type type) { }

	// RVA: 0x83D350 Offset: 0x83C550 VA: 0x18083D350
	public static string[] GetDropdownValues(Type type) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void ListenToLogs() { }

	// RVA: 0x83D770 Offset: 0x83C970 VA: 0x18083D770
	private static void LogMessageReceived(string log, string stacktrace, LogType type) { }

	// RVA: 0x83D2D0 Offset: 0x83C4D0 VA: 0x18083D2D0
	public static void ClearLogs() { }

	// RVA: 0x83D680 Offset: 0x83C880 VA: 0x18083D680
	public static void LogCommandInfo(string log) { }

	// RVA: 0x83D6D0 Offset: 0x83C8D0 VA: 0x18083D6D0
	public static void LogCommandSuccess(string log) { }

	// RVA: 0x83D720 Offset: 0x83C920 VA: 0x18083D720
	public static void LogCommandWarning(string log) { }

	// RVA: 0x83D630 Offset: 0x83C830 VA: 0x18083D630
	public static void LogCommandError(string log) { }

	// RVA: 0x83D840 Offset: 0x83CA40 VA: 0x18083D840
	private static void Log(string message, DebugCommandMessageType type) { }

	// RVA: 0x83D4C0 Offset: 0x83C6C0 VA: 0x18083D4C0
	public static string GetTypeName(Type type) { }

	// RVA: 0x83E070 Offset: 0x83D270 VA: 0x18083E070
	private static void .cctor() { }
}

// Namespace: Innersloth.DebugTool
public class DebugToolNullKeyboardInputProvider : IDebugToolKeyboardInputProvider // TypeDefIndex: 2683
{
	// Methods

	// RVA: 0x83C200 Offset: 0x83B400 VA: 0x18083C200 Slot: 4
	public void GetText(string originalText, int characterLimit, Action<string> onComplete) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Innersloth.DebugTool
public interface IDebugToolInputProvider // TypeDefIndex: 2684
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator CoInitialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool GetToggle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool GetNavUp();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool GetNavDown();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool GetNavLeft();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool GetNavRight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool GetConfirm();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetCancel();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetPagePrevious();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetPageNext();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool GetSubPagePrevious();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool GetSubPageNext();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool GetCopy();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool GetClear();
}

// Namespace: Innersloth.DebugTool
public interface IDebugToolKeyboardInputProvider // TypeDefIndex: 2685
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetText(string originalText, int characterLimit, Action<string> onComplete);
}

// Namespace: Innersloth.DebugTool
public abstract class AbstractDebugCommandArgumentRow : MonoBehaviour // TypeDefIndex: 2686
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI nameText; // 0x20
	[SerializeField]
	private TextMeshProUGUI typeText; // 0x28
	private DebugCommandArgumentRowFieldContainer[] fieldContainers; // 0x30
	[CompilerGenerated]
	private Action<DebugCommandArgumentRowFieldContainer> OnFieldContainerSelected; // 0x38

	// Properties
	public abstract DebugCommandArgumentRowFieldContainer TopField { get; }
	public abstract DebugCommandArgumentRowFieldContainer BottomField { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DebugCommandArgumentRowFieldContainer get_TopField();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DebugCommandArgumentRowFieldContainer get_BottomField();

	[CompilerGenerated]
	// RVA: 0x82D610 Offset: 0x82C810 VA: 0x18082D610
	public void add_OnFieldContainerSelected(Action<DebugCommandArgumentRowFieldContainer> value) { }

	[CompilerGenerated]
	// RVA: 0x82D6C0 Offset: 0x82C8C0 VA: 0x18082D6C0
	public void remove_OnFieldContainerSelected(Action<DebugCommandArgumentRowFieldContainer> value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetNavigation(Selectable above, Selectable below);

	// RVA: 0x82D2A0 Offset: 0x82C4A0 VA: 0x18082D2A0 Slot: 8
	public virtual void Awake() { }

	// RVA: 0x82D450 Offset: 0x82C650 VA: 0x18082D450
	public void SetInfo(string name, string type) { }

	// RVA: 0x82D370 Offset: 0x82C570 VA: 0x18082D370
	private void OnChildFieldContainerSelected(DebugCommandArgumentRowFieldContainer selection) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x82D500 Offset: 0x82C700 VA: 0x18082D500
	private void <Awake>b__12_0(DebugCommandArgumentRowFieldContainer x) { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommandArgumentRowFieldContainer : Selectable // TypeDefIndex: 2687
{
	// Fields
	[Header("Selectable Field")]
	[SerializeField]
	private Selectable field; // 0x100
	private bool isFieldSelected; // 0x108
	[CompilerGenerated]
	private Action<DebugCommandArgumentRowFieldContainer> OnSelected; // 0x110

	// Properties
	public Selectable Selectable { get; }
	public bool IsSelected { get; }
	public bool IsFieldSelected { get; }

	// Methods

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	public Selectable get_Selectable() { }

	// RVA: 0x833650 Offset: 0x832850 VA: 0x180833650
	public bool get_IsSelected() { }

	// RVA: 0x833640 Offset: 0x832840 VA: 0x180833640
	public bool get_IsFieldSelected() { }

	[CompilerGenerated]
	// RVA: 0x833580 Offset: 0x832780 VA: 0x180833580
	public void add_OnSelected(Action<DebugCommandArgumentRowFieldContainer> value) { }

	[CompilerGenerated]
	// RVA: 0x8336F0 Offset: 0x8328F0 VA: 0x1808336F0
	public void remove_OnSelected(Action<DebugCommandArgumentRowFieldContainer> value) { }

	// RVA: 0x833440 Offset: 0x832640 VA: 0x180833440 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x833430 Offset: 0x832630 VA: 0x180833430
	public void Deselect() { }

	// RVA: 0x833480 Offset: 0x832680 VA: 0x180833480
	public void SetNavigationAbove(Selectable selectable) { }

	// RVA: 0x8334D0 Offset: 0x8326D0 VA: 0x1808334D0
	public void SetNavigationBelow(Selectable selectable) { }

	// RVA: 0x8333E0 Offset: 0x8325E0 VA: 0x1808333E0
	public void Confirm() { }

	// RVA: 0x8333B0 Offset: 0x8325B0 VA: 0x1808333B0
	public void Cancel() { }

	// RVA: 0x833530 Offset: 0x832730 VA: 0x180833530
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCommandArgumentRow_Dropdown.<>c__DisplayClass13_0 // TypeDefIndex: 2688
{
	// Fields
	public string filter; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x840EA0 Offset: 0x8400A0 VA: 0x180840EA0
	internal bool <OnFilterChanged>b__0(TMP_Dropdown.OptionData option) { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommandArgumentRow_Dropdown : AbstractDebugCommandArgumentRow // TypeDefIndex: 2689
{
	// Fields
	[SerializeField]
	[Header("Dropdown Input")]
	private DebugCommandArgumentRowFieldContainer dropdownFieldContainer; // 0x40
	[SerializeField]
	private TMP_Dropdown dropdown; // 0x48
	[Header("Filter Input")]
	[SerializeField]
	private DebugCommandArgumentRowFieldContainer filterFieldContainer; // 0x50
	[SerializeField]
	private TMP_InputField filterField; // 0x58
	private List<string> initialDropdownOptions; // 0x60

	// Properties
	public override DebugCommandArgumentRowFieldContainer TopField { get; }
	public override DebugCommandArgumentRowFieldContainer BottomField { get; }

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 4
	public override DebugCommandArgumentRowFieldContainer get_TopField() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 5
	public override DebugCommandArgumentRowFieldContainer get_BottomField() { }

	// RVA: 0x833910 Offset: 0x832B10 VA: 0x180833910 Slot: 6
	public override string GetValue() { }

	// RVA: 0x8337B0 Offset: 0x8329B0 VA: 0x1808337B0 Slot: 8
	public override void Awake() { }

	// RVA: 0x833C90 Offset: 0x832E90 VA: 0x180833C90 Slot: 7
	public override void SetNavigation(Selectable above, Selectable below) { }

	// RVA: 0x833C00 Offset: 0x832E00 VA: 0x180833C00
	public void SetDropdownOptions(IEnumerable<string> options) { }

	// RVA: 0x833950 Offset: 0x832B50 VA: 0x180833950
	public void OnFilterChanged(string filter) { }

	// RVA: 0x833BC0 Offset: 0x832DC0 VA: 0x180833BC0
	private void ResetFilter() { }

	// RVA: 0x833D60 Offset: 0x832F60 VA: 0x180833D60
	public void .ctor() { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommandArgumentRow_TextField : AbstractDebugCommandArgumentRow // TypeDefIndex: 2690
{
	// Fields
	[SerializeField]
	[Header("Text Input")]
	private DebugCommandArgumentRowFieldContainer fieldContainer; // 0x40
	[SerializeField]
	private TMP_InputField inputField; // 0x48
	[SerializeField]
	private TextMeshProUGUI placeholderText; // 0x50

	// Properties
	public override DebugCommandArgumentRowFieldContainer TopField { get; }
	public override DebugCommandArgumentRowFieldContainer BottomField { get; }

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 4
	public override DebugCommandArgumentRowFieldContainer get_TopField() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 5
	public override DebugCommandArgumentRowFieldContainer get_BottomField() { }

	// RVA: 0x833DD0 Offset: 0x832FD0 VA: 0x180833DD0 Slot: 6
	public override string GetValue() { }

	// RVA: 0x833E00 Offset: 0x833000 VA: 0x180833E00 Slot: 7
	public override void SetNavigation(Selectable above, Selectable below) { }

	// RVA: 0x833ED0 Offset: 0x8330D0 VA: 0x180833ED0
	public void SetPlaceholder(string placeholder) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCommandButton.<>c__DisplayClass25_0 // TypeDefIndex: 2691
{
	// Fields
	public Action action; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <Initialize>b__0() { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommandButton : MonoBehaviour // TypeDefIndex: 2692
{
	// Fields
	private const int INDENT_SIZE = 50;
	[SerializeField]
	private TextMeshProUGUI buttonLabel; // 0x20
	[SerializeField]
	private HorizontalLayoutGroup layoutGroup; // 0x28
	[SerializeField]
	private Button button; // 0x30
	[SerializeField]
	private Image background; // 0x38
	[SerializeField]
	private Image expandCollapseImage; // 0x40
	[SerializeField]
	private Sprite expandedIcon; // 0x48
	[SerializeField]
	private Sprite collapsedIcon; // 0x50
	[SerializeField]
	private Color evenColor; // 0x58
	[SerializeField]
	private Color oddColor; // 0x68
	[SerializeField]
	private Color highlightColor; // 0x78
	private int index; // 0x88
	private int initialLeftPadding; // 0x8C
	[CompilerGenerated]
	private bool <IsDirectory>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <Path>k__BackingField; // 0x98

	// Properties
	public bool IsDirectory { get; set; }
	public string Path { get; set; }
	public bool Expanded { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	public bool get_IsDirectory() { }

	[CompilerGenerated]
	// RVA: 0x834530 Offset: 0x833730 VA: 0x180834530
	private void set_IsDirectory(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_Path() { }

	[CompilerGenerated]
	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	private void set_Path(string value) { }

	// RVA: 0x833F50 Offset: 0x833150 VA: 0x180833F50
	private void Awake() { }

	// RVA: 0x834470 Offset: 0x833670 VA: 0x180834470
	public bool get_Expanded() { }

	// RVA: 0x834500 Offset: 0x833700 VA: 0x180834500
	public void set_Expanded(bool value) { }

	// RVA: 0x833F90 Offset: 0x833190 VA: 0x180833F90
	public void Initialize(string label, string path, ParameterInfo[] parameters, Action action, int index) { }

	// RVA: 0x8343C0 Offset: 0x8335C0 VA: 0x1808343C0
	public void ToggleDirectory(bool directory) { }

	// RVA: 0x834360 Offset: 0x833560 VA: 0x180834360
	public void SetIndentLevel(int indentLevel) { }

	// RVA: 0x8343F0 Offset: 0x8335F0 VA: 0x1808343F0
	public void ToggleHighlight(bool highlighted) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugCommandOverlayPage.<>c // TypeDefIndex: 2693
{
	// Fields
	public static readonly DebugCommandOverlayPage.<>c <>9; // 0x0
	public static Comparison<DebugCommand> <>9__36_0; // 0x8
	public static Func<Exception, string> <>9__44_0; // 0x10

	// Methods

	// RVA: 0x8410F0 Offset: 0x8402F0 VA: 0x1808410F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x840E60 Offset: 0x840060 VA: 0x180840E60
	internal int <Show>b__36_0(DebugCommand c1, DebugCommand c2) { }

	// RVA: 0x55FA70 Offset: 0x55EC70 VA: 0x18055FA70
	internal string <ExecuteCommandWithParameters>b__44_0(Exception e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCommandOverlayPage.<>c__DisplayClass36_0 // TypeDefIndex: 2694
{
	// Fields
	public int btnIndex; // 0x10
	public DebugCommandButton button; // 0x18
	public DebugCommandOverlayPage <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x840FE0 Offset: 0x8401E0 VA: 0x180840FE0
	internal void <Show>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCommandOverlayPage.<>c__DisplayClass38_0 // TypeDefIndex: 2695
{
	// Fields
	public DebugCommandOverlayPage <>4__this; // 0x10
	public int index; // 0x18
	public DebugCommandButton directoryButton; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x841050 Offset: 0x840250 VA: 0x180841050
	internal void <CreateDirectory>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugCommandOverlayPage.<>c__DisplayClass40_0 // TypeDefIndex: 2696
{
	// Fields
	public DebugCommandOverlayPage <>4__this; // 0x10
	public DebugCommand command; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x8410C0 Offset: 0x8402C0 VA: 0x1808410C0
	internal void <OnCommandClicked>b__0() { }
}

// Namespace: Innersloth.DebugTool
public class DebugCommandOverlayPage : DebugToolOverlayPage // TypeDefIndex: 2697
{
	// Fields
	[Header("List")]
	[SerializeField]
	private DebugCommandButton commandButtonPrefab; // 0x30
	[SerializeField]
	private Transform commandButtonParent; // 0x38
	[SerializeField]
	private ScrollRect commandScrollList; // 0x40
	[Header("Details")]
	[SerializeField]
	private GameObject detailsParent; // 0x48
	[SerializeField]
	private TextMeshProUGUI basePath; // 0x50
	[SerializeField]
	private TextMeshProUGUI commandName; // 0x58
	[SerializeField]
	private TextMeshProUGUI commandDescription; // 0x60
	[SerializeField]
	private Transform argumentsParent; // 0x68
	[SerializeField]
	private Button executeButton; // 0x70
	[Header("Argument Field Types")]
	[SerializeField]
	private DebugCommandArgumentRow_TextField argumentTextFieldPrefab; // 0x78
	[SerializeField]
	private DebugCommandArgumentRow_Dropdown argumentDropdownPrefab; // 0x80
	[SerializeField]
	[Header("Debug")]
	private GameObject debugContainer; // 0x88
	[SerializeField]
	private Image debugIcon; // 0x90
	[SerializeField]
	private TextMeshProUGUI debugText; // 0x98
	[Space(10)]
	[SerializeField]
	private Color debugInfoColor; // 0xA0
	[SerializeField]
	private Color debugSuccessColor; // 0xB0
	[SerializeField]
	private Color debugWarningColor; // 0xC0
	[SerializeField]
	private Color debugErrorColor; // 0xD0
	[Space(10)]
	[SerializeField]
	private Sprite debugInfoIcon; // 0xE0
	[SerializeField]
	private Sprite debugSuccessIcon; // 0xE8
	[SerializeField]
	private Sprite debugWarningIcon; // 0xF0
	[SerializeField]
	private Sprite debugErrorIcon; // 0xF8
	private List<DebugCommandButton> allCommandButtons; // 0x100
	private Dictionary<string, List<DebugCommandButton>> directoryContents; // 0x108
	private Dictionary<string, DebugCommand> commands; // 0x110
	private int selectedCommandIndex; // 0x118
	private List<AbstractDebugCommandArgumentRow> commandInputs; // 0x120
	private DebugCommandArgumentRowFieldContainer selectedFieldContainer; // 0x128

	// Properties
	public override string Name { get; }
	public override bool ConsumingNavActions { get; }

	// Methods

	// RVA: 0x837AE0 Offset: 0x836CE0 VA: 0x180837AE0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x837AC0 Offset: 0x836CC0 VA: 0x180837AC0 Slot: 5
	public override bool get_ConsumingNavActions() { }

	// RVA: 0x834550 Offset: 0x833750 VA: 0x180834550
	private void Awake() { }

	// RVA: 0x835FD0 Offset: 0x8351D0 VA: 0x180835FD0
	private void OnDestroy() { }

	// RVA: 0x8376D0 Offset: 0x8368D0 VA: 0x1808376D0
	private void Update() { }

	// RVA: 0x837370 Offset: 0x836570 VA: 0x180837370
	private void UpdateSelectedCommandIfScrolling(IDebugToolInputProvider inputProvider) { }

	// RVA: 0x836A70 Offset: 0x835C70 VA: 0x180836A70 Slot: 6
	public override void Show() { }

	// RVA: 0x835570 Offset: 0x834770 VA: 0x180835570 Slot: 7
	public override void OnBackButtonPressed() { }

	// RVA: 0x834790 Offset: 0x833990 VA: 0x180834790
	private DebugCommandButton CreateDirectory(string directoryName, string parentDirectoryPath, string directoryPath, int index) { }

	// RVA: 0x835580 Offset: 0x834780 VA: 0x180835580
	private void OnButtonClick(DebugCommandButton btn) { }

	// RVA: 0x8355B0 Offset: 0x8347B0 VA: 0x1808355B0
	private void OnCommandClicked(DebugCommandButton btn) { }

	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	private void OnFieldRowContainerSelected(DebugCommandArgumentRowFieldContainer container) { }

	// RVA: 0x8350E0 Offset: 0x8342E0 VA: 0x1808350E0
	private AbstractDebugCommandArgumentRow InstantiateInputFieldRow(DebugCommand command, int argIndex, ParameterInfo paramInfo) { }

	// RVA: 0x8361A0 Offset: 0x8353A0 VA: 0x1808361A0
	private void OnDirectoryClicked(DebugCommandButton btn) { }

	// RVA: 0x8348E0 Offset: 0x833AE0 VA: 0x1808348E0
	private void ExecuteCommandWithParameters(DebugCommand command) { }

	// RVA: 0x8364A0 Offset: 0x8356A0 VA: 0x1808364A0
	private void ResetAndHideDetails() { }

	// RVA: 0x834FE0 Offset: 0x8341E0 VA: 0x180834FE0
	private void HighlightButton(int highlightedIndex) { }

	// RVA: 0x834720 Offset: 0x833920 VA: 0x180834720
	private void ClearCommandLog() { }

	// RVA: 0x836660 Offset: 0x835860 VA: 0x180836660
	private void SetCommandLog(string message, DebugCommandMessageType type) { }

	// RVA: 0x837A50 Offset: 0x836C50 VA: 0x180837A50
	public void .ctor() { }
}

// Namespace: Innersloth.DebugTool
public class DebugTabButton : MonoBehaviour // TypeDefIndex: 2698
{
	// Fields
	private static readonly Color COLOR_NORMAL; // 0x0
	private static readonly Color COLOR_SELECTED; // 0x10
	[SerializeField]
	private string pageName; // 0x20
	[SerializeField]
	private TextMeshProUGUI buttonLabel; // 0x28
	[SerializeField]
	private Button button; // 0x30

	// Properties
	public string PageName { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_PageName() { }

	// RVA: 0x83BC10 Offset: 0x83AE10 VA: 0x18083BC10
	private void Awake() { }

	// RVA: 0x83BCD0 Offset: 0x83AED0 VA: 0x18083BCD0
	public void ToggleSelect(bool selected) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x83BE00 Offset: 0x83B000 VA: 0x18083BE00
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x83BDA0 Offset: 0x83AFA0 VA: 0x18083BDA0
	private void <Awake>b__7_0() { }
}

// Namespace: Innersloth.DebugTool
public class DebugTapToOpenButton : MonoBehaviour // TypeDefIndex: 2699
{
	// Fields
	[SerializeField]
	private float maxSecondsBetweenTaps; // 0x20
	[SerializeField]
	private DebugToolOverlay debugOverlay; // 0x28
	[SerializeField]
	private Button tapButton; // 0x30
	private float lastTapTime; // 0x38
	private int numTapsSoFar; // 0x3C

	// Methods

	// RVA: 0x83BF30 Offset: 0x83B130 VA: 0x18083BF30
	private void Awake() { }

	// RVA: 0x83C0C0 Offset: 0x83B2C0 VA: 0x18083C0C0
	public void SetRaycastTarget(bool raycast) { }

	// RVA: 0x83C140 Offset: 0x83B340 VA: 0x18083C140
	private void Tap() { }

	// RVA: 0x83C1F0 Offset: 0x83B3F0 VA: 0x18083C1F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x83C1B0 Offset: 0x83B3B0 VA: 0x18083C1B0
	private void <Awake>b__5_0(bool visible) { }
}

// Namespace: Innersloth.DebugTool
public class DebugToolOverlay : MonoBehaviour // TypeDefIndex: 2700
{
	// Fields
	[SerializeField]
	private GameObject rootUI; // 0x20
	[SerializeField]
	private Button closeButton; // 0x28
	[SerializeField]
	private Button backButton; // 0x30
	[SerializeField]
	[Header("Tabs")]
	private DebugTabButton[] tabButtons; // 0x38
	[SerializeField]
	private DebugToolOverlayPage[] pages; // 0x40
	private readonly List<IDebugToolInputProvider> inputProviders; // 0x48
	private int activeTabIndex; // 0x50
	private int totalTabs; // 0x54
	[CompilerGenerated]
	private Action<bool> OnToggle; // 0x58

	// Properties
	private bool UIVisible { get; }
	private bool SubpageShowingDetails { get; }
	private DebugToolOverlayPage ActivePage { get; }
	private bool SubpageConsumingNavActions { get; }

	// Methods

	// RVA: 0x83D0F0 Offset: 0x83C2F0 VA: 0x18083D0F0
	private bool get_UIVisible() { }

	// RVA: 0x83D0C0 Offset: 0x83C2C0 VA: 0x18083D0C0
	private bool get_SubpageShowingDetails() { }

	// RVA: 0x83CF70 Offset: 0x83C170 VA: 0x18083CF70
	private DebugToolOverlayPage get_ActivePage() { }

	// RVA: 0x83D000 Offset: 0x83C200 VA: 0x18083D000
	private bool get_SubpageConsumingNavActions() { }

	[CompilerGenerated]
	// RVA: 0x83C2D0 Offset: 0x83B4D0 VA: 0x18083C2D0
	private void add_OnToggle(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x83D110 Offset: 0x83C310 VA: 0x18083D110
	private void remove_OnToggle(Action<bool> value) { }

	// RVA: 0x537E20 Offset: 0x537020 VA: 0x180537E20
	private void Awake() { }

	// RVA: 0x83C720 Offset: 0x83B920 VA: 0x18083C720
	private void ShowPage(string pageName) { }

	// RVA: 0x83CBC0 Offset: 0x83BDC0 VA: 0x18083CBC0
	private void Update() { }

	// RVA: 0x83C540 Offset: 0x83B740 VA: 0x18083C540
	public void RegisterInputProvider(IDebugToolInputProvider provider) { }

	// RVA: 0x83C6C0 Offset: 0x83B8C0 VA: 0x18083C6C0
	public void RegisterKeyboardInputProvider(IDebugToolKeyboardInputProvider provider) { }

	// RVA: 0x83C2D0 Offset: 0x83B4D0 VA: 0x18083C2D0
	public void AddToggleActiveCallback(Action<bool> action) { }

	// RVA: 0x83C380 Offset: 0x83B580 VA: 0x18083C380
	public void Initialize() { }

	// RVA: 0x83CA90 Offset: 0x83BC90 VA: 0x18083CA90
	public void ToggleUIVisible(bool visible) { }

	// RVA: 0x83CA20 Offset: 0x83BC20 VA: 0x18083CA20
	private void ToggleBackButtonActive(bool active) { }

	// RVA: 0x83CF00 Offset: 0x83C100 VA: 0x18083CF00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x83CB50 Offset: 0x83BD50 VA: 0x18083CB50
	private bool <get_ActivePage>b__13_0(DebugToolOverlayPage page) { }
}

// Namespace: Innersloth.DebugTool
public abstract class DebugToolOverlayPage : MonoBehaviour // TypeDefIndex: 2701
{
	// Fields
	protected readonly List<IDebugToolInputProvider> InputProviders; // 0x20
	protected IDebugToolKeyboardInputProvider KeyboardInputProvider; // 0x28

	// Properties
	public abstract string Name { get; }
	public abstract bool ConsumingNavActions { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_ConsumingNavActions();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Show();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnBackButtonPressed();

	// RVA: 0x83C230 Offset: 0x83B430 VA: 0x18083C230
	public void AddInputProvider(IDebugToolInputProvider provider) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void SetKeyboardInputProvider(IDebugToolKeyboardInputProvider provider) { }

	// RVA: 0x837A50 Offset: 0x836C50 VA: 0x180837A50
	protected void .ctor() { }
}

// Namespace: Innersloth.DebugTool
public static class DebugUIEvents // TypeDefIndex: 2702
{
	// Fields
	public static Action<DebugCommand> OnBeforeCommandExecuted; // 0x0
	public static Action<bool> OnDetailsToggledVisible; // 0x8
	public static Action<string> OnTabClicked; // 0x10
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugLogFilterButton.<>c__DisplayClass8_0 // TypeDefIndex: 2703
{
	// Fields
	public Action onClick; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0
	internal void <Initialize>b__0() { }
}

// Namespace: Innersloth.DebugTool
public class DebugLogFilterButton : MonoBehaviour // TypeDefIndex: 2704
{
	// Fields
	[SerializeField]
	private Image logIcon; // 0x20
	[SerializeField]
	private Color enabledColor; // 0x28
	[SerializeField]
	private TextMeshProUGUI logCountText; // 0x38
	[SerializeField]
	private Button button; // 0x40
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x48

	// Properties
	public bool Enabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	private void set_Enabled(bool value) { }

	// RVA: 0x837E30 Offset: 0x837030 VA: 0x180837E30
	public void Initialize(Action onClick) { }

	// RVA: 0x837F50 Offset: 0x837150 VA: 0x180837F50
	public void SetCount(int count) { }

	// RVA: 0x837FA0 Offset: 0x8371A0 VA: 0x180837FA0
	public void ToggleEnabled(bool enabled) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugLogMessageLine.<>c__DisplayClass15_0 // TypeDefIndex: 2705
{
	// Fields
	public Action<int, DebugLogMessage> onClick; // 0x10
	public int index; // 0x18
	public DebugLogMessage debugLog; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x840F10 Offset: 0x840110 VA: 0x180840F10
	internal void <Initialize>b__0() { }
}

// Namespace: Innersloth.DebugTool
public class DebugLogMessageLine : MonoBehaviour, ICell // TypeDefIndex: 2706
{
	// Fields
	[SerializeField]
	private Button expandButton; // 0x20
	[SerializeField]
	private Image fader; // 0x28
	[SerializeField]
	private TextMeshProUGUI logLine; // 0x30
	[SerializeField]
	private Image background; // 0x38
	[SerializeField]
	private Image warningLogIcon; // 0x40
	[SerializeField]
	private Image regularLogIcon; // 0x48
	[SerializeField]
	private Image errorLogIcon; // 0x50
	[SerializeField]
	private Color fadeColor; // 0x58
	[SerializeField]
	private Color evenColor; // 0x68
	[SerializeField]
	private Color oddColor; // 0x78
	[SerializeField]
	private Color highlightColor; // 0x88
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x98

	// Properties
	public int Index { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x838420 Offset: 0x837620 VA: 0x180838420
	private void set_Index(int value) { }

	// RVA: 0x837FF0 Offset: 0x8371F0 VA: 0x180837FF0
	public void Initialize(DebugLogMessage debugLog, Action<int, DebugLogMessage> onClick, int index) { }

	// RVA: 0x838330 Offset: 0x837530 VA: 0x180838330
	public void ToggleFade(bool faded) { }

	// RVA: 0x838380 Offset: 0x837580 VA: 0x180838380
	public void ToggleHighlight(bool highlighted) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugLogOverlayPage.<>c__DisplayClass29_0 // TypeDefIndex: 2707
{
	// Fields
	public DebugLogOverlayPage <>4__this; // 0x10
	public int index; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x840F60 Offset: 0x840160 VA: 0x180840F60
	internal void <SetCell>b__0(int idx, DebugLogMessage log) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugLogOverlayPage.<CoScrollToBottom>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2708
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DebugLogOverlayPage <>4__this; // 0x20

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

	// RVA: 0x840C00 Offset: 0x83FE00 VA: 0x180840C00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x840D20 Offset: 0x83FF20 VA: 0x180840D20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Innersloth.DebugTool
public class DebugLogOverlayPage : DebugToolOverlayPage, IRecyclableScrollRectDataSource // TypeDefIndex: 2709
{
	// Fields
	private readonly Dictionary<LogType, DebugLogFilterButton> logButtons; // 0x30
	[SerializeField]
	private RecyclableScrollRect logScrollList; // 0x38
	[SerializeField]
	private RectTransform idealLogPosition; // 0x40
	[SerializeField]
	private DebugLogOverlayPageListSelector listSelector; // 0x48
	[Header("Bottom Section")]
	[SerializeField]
	private Button clearButton; // 0x50
	[SerializeField]
	private Button copyButton; // 0x58
	[SerializeField]
	private DebugLogFilterButton logsButton; // 0x60
	[SerializeField]
	private DebugLogFilterButton warningsButton; // 0x68
	[SerializeField]
	private DebugLogFilterButton errorsButton; // 0x70
	[SerializeField]
	[Header("Log Details")]
	private GameObject detailParent; // 0x78
	[SerializeField]
	private TextMeshProUGUI detailsText; // 0x80
	[SerializeField]
	private GameObject notListeningWarning; // 0x88
	private string detailsToCopy; // 0x90
	private readonly List<DebugLogMessage> logMessageList; // 0x98
	private bool initialized; // 0xA0
	private int selectedLogIndex; // 0xA4

	// Properties
	public override string Name { get; }
	public override bool ConsumingNavActions { get; }

	// Methods

	// RVA: 0x83B1B0 Offset: 0x83A3B0 VA: 0x18083B1B0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public override bool get_ConsumingNavActions() { }

	// RVA: 0x8389A0 Offset: 0x837BA0 VA: 0x1808389A0
	private void Awake() { }

	// RVA: 0x83A3D0 Offset: 0x8395D0 VA: 0x18083A3D0
	private void Start() { }

	// RVA: 0x83AC30 Offset: 0x839E30 VA: 0x18083AC30
	private void Update() { }

	// RVA: 0x83A6C0 Offset: 0x8398C0 VA: 0x18083A6C0
	private void UpdateScrollRectPosition(int originalSelectedIndex, int newlySelectedIndex) { }

	// RVA: 0x839790 Offset: 0x838990 VA: 0x180839790
	private void OnListSelected() { }

	// RVA: 0x8396C0 Offset: 0x8388C0 VA: 0x1808396C0
	private void OnListDeselected() { }

	// RVA: 0x83A0B0 Offset: 0x8392B0 VA: 0x18083A0B0 Slot: 6
	public override void Show() { }

	// RVA: 0x8396B0 Offset: 0x8388B0 VA: 0x1808396B0 Slot: 7
	public override void OnBackButtonPressed() { }

	// RVA: 0x839390 Offset: 0x838590 VA: 0x180839390 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x839C70 Offset: 0x838E70 VA: 0x180839C70 Slot: 9
	public void SetCell(ICell cell, int index) { }

	// RVA: 0x8393D0 Offset: 0x8385D0 VA: 0x1808393D0
	private void HideDetails() { }

	[IteratorStateMachine(typeof(DebugLogOverlayPage.<CoScrollToBottom>d__31))]
	// RVA: 0x838CF0 Offset: 0x837EF0 VA: 0x180838CF0
	private IEnumerator CoScrollToBottom() { }

	// RVA: 0x8397A0 Offset: 0x8389A0 VA: 0x1808397A0
	private void RefreshLogList() { }

	// RVA: 0x839E00 Offset: 0x839000 VA: 0x180839E00
	private void SetFilterButtonCounts(Dictionary<LogType, int> logTypeCounts) { }

	// RVA: 0x8391D0 Offset: 0x8383D0 VA: 0x1808391D0
	private void Filter(LogType logType) { }

	// RVA: 0x838D50 Offset: 0x837F50 VA: 0x180838D50
	private void CopyLogOrLogs() { }

	// RVA: 0x838C20 Offset: 0x837E20 VA: 0x180838C20
	private void ClearLogs() { }

	// RVA: 0x839FF0 Offset: 0x8391F0 VA: 0x180839FF0
	private void ShowLogDetails(DebugLogMessage debugLogMsg) { }

	// RVA: 0x8396C0 Offset: 0x8388C0 VA: 0x1808396C0
	private void UnhighlightLog() { }

	// RVA: 0x839450 Offset: 0x838650 VA: 0x180839450
	private void HighlightLog(int i) { }

	// RVA: 0x838FC0 Offset: 0x8381C0 VA: 0x180838FC0
	private void FadeOtherLogs(int index) { }

	// RVA: 0x839290 Offset: 0x838490 VA: 0x180839290
	private DebugLogMessageLine FindLogObject(int index) { }

	// RVA: 0x83A480 Offset: 0x839680 VA: 0x18083A480
	private void UnfadeLogs() { }

	// RVA: 0x83B0B0 Offset: 0x83A2B0 VA: 0x18083B0B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x83A450 Offset: 0x839650 VA: 0x18083A450
	private void <Show>b__26_0() { }

	[CompilerGenerated]
	// RVA: 0x83A460 Offset: 0x839660 VA: 0x18083A460
	private void <Show>b__26_1() { }

	[CompilerGenerated]
	// RVA: 0x83A470 Offset: 0x839670 VA: 0x18083A470
	private void <Show>b__26_2() { }
}

// Namespace: Innersloth.DebugTool
public class DebugLogOverlayPageListSelector : Selectable // TypeDefIndex: 2710
{
	// Fields
	[CompilerGenerated]
	private Action OnSelected; // 0x100
	[CompilerGenerated]
	private Action OnDeselected; // 0x108

	// Properties
	public bool IsSelected { get; }

	// Methods

	// RVA: 0x8387A0 Offset: 0x8379A0 VA: 0x1808387A0
	public bool get_IsSelected() { }

	[CompilerGenerated]
	// RVA: 0x8386F0 Offset: 0x8378F0 VA: 0x1808386F0
	public void add_OnSelected(Action value) { }

	[CompilerGenerated]
	// RVA: 0x8388F0 Offset: 0x837AF0 VA: 0x1808388F0
	public void remove_OnSelected(Action value) { }

	[CompilerGenerated]
	// RVA: 0x838640 Offset: 0x837840 VA: 0x180838640
	public void add_OnDeselected(Action value) { }

	[CompilerGenerated]
	// RVA: 0x838840 Offset: 0x837A40 VA: 0x180838840
	public void remove_OnDeselected(Action value) { }

	// RVA: 0x8385B0 Offset: 0x8377B0 VA: 0x1808385B0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x838570 Offset: 0x837770 VA: 0x180838570 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x838440 Offset: 0x837640 VA: 0x180838440
	public bool IsChildSelected() { }

	// RVA: 0x8385F0 Offset: 0x8377F0 VA: 0x1808385F0
	public void .ctor() { }
}

// Namespace: Innersloth.DebugTool
public class DebugMemoryPage : DebugToolOverlayPage // TypeDefIndex: 2711
{
	// Fields
	[Header("Memory Details")]
	[SerializeField]
	private TextMeshProUGUI gcMemoryText; // 0x30
	[SerializeField]
	private TextMeshProUGUI systemMemoryText; // 0x38
	[SerializeField]
	private TextMeshProUGUI textureMemoryText; // 0x40
	[SerializeField]
	private Button toggleMemoryRecordingButton; // 0x48
	[SerializeField]
	private TextMeshProUGUI toggleMemoryRecordingText; // 0x50
	[SerializeField]
	private Toggle toggleMemoryOverlayButton; // 0x58
	private DebugToolMemoryStatsView memoryStatsView; // 0x60
	private bool isVisible; // 0x68
	private bool isRecording; // 0x69
	private bool isOverlayEnabled; // 0x6A

	// Properties
	public override string Name { get; }
	public override bool ConsumingNavActions { get; }

	// Methods

	// RVA: 0x83BBE0 Offset: 0x83ADE0 VA: 0x18083BBE0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 5
	public override bool get_ConsumingNavActions() { }

	// RVA: 0x83B1E0 Offset: 0x83A3E0 VA: 0x18083B1E0
	private void Awake() { }

	// RVA: 0x83B610 Offset: 0x83A810 VA: 0x18083B610
	private void Start() { }

	// RVA: 0x83B7D0 Offset: 0x83A9D0 VA: 0x18083B7D0
	private void ToggleMemoryOverlay(bool enable) { }

	// RVA: 0x83B4D0 Offset: 0x83A6D0 VA: 0x18083B4D0
	private void StartRecording() { }

	// RVA: 0x83B690 Offset: 0x83A890 VA: 0x18083B690
	private void StopRecording() { }

	// RVA: 0x83B890 Offset: 0x83AA90 VA: 0x18083B890
	private void Update() { }

	// RVA: 0x83B450 Offset: 0x83A650 VA: 0x18083B450 Slot: 6
	public override void Show() { }

	// RVA: 0x83B440 Offset: 0x83A640 VA: 0x18083B440 Slot: 7
	public override void OnBackButtonPressed() { }

	// RVA: 0x83B380 Offset: 0x83A580 VA: 0x18083B380
	private void HideDetails() { }

	// RVA: 0x837A50 Offset: 0x836C50 VA: 0x180837A50
	public void .ctor() { }
}

// Namespace: 
public enum AddressableAsset.AssetLoadState // TypeDefIndex: 2712
{
	// Fields
	public int value__; // 0x0
	public const AddressableAsset.AssetLoadState Null = 0;
	public const AddressableAsset.AssetLoadState Unloaded = 1;
	public const AddressableAsset.AssetLoadState Loading = 2;
	public const AddressableAsset.AssetLoadState Success = 3;
	public const AddressableAsset.AssetLoadState Error = 4;
}

// Namespace: Innersloth.Assets
public abstract class AddressableAsset : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 2713
{
	// Fields
	protected static readonly Logger logger; // 0x0

	// Methods

	// RVA: 0x7C41D0 Offset: 0x7C33D0 VA: 0x1807C41D0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x82EEC0 Offset: 0x82E0C0 VA: 0x18082EEC0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0 Slot: 6
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x82EE90 Offset: 0x82E090 VA: 0x18082EE90
	public bool IsLoading() { }

	// RVA: 0x82EE10 Offset: 0x82E010 VA: 0x18082EE10
	public bool IsCompleted() { }

	// RVA: 0x82EE60 Offset: 0x82E060 VA: 0x18082EE60
	public bool IsLoaded() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	protected virtual void OnSerialize() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void OnDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AddressableAsset.AssetLoadState GetState();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void LoadAsync(Action onSuccessCb, Action onErrorcb, Action onFinishedcb);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IEnumerator CoLoadAsync(Action onFinished);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Unload();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Destroy();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool ReferenceEquals(AddressableAsset asset);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool ReferenceEquals(AssetReference asset);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x82EEE0 Offset: 0x82E0E0 VA: 0x18082EEE0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAsset.<CoLoadAsync>d__11<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2714
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public AddressableAsset<T> <>4__this; // 0x0
	public Action onFinished; // 0x0

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
	|-AddressableAsset.<CoLoadAsync>d__11<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAsset.<CoLoadAsync>d__11<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04EA0 Offset: 0xB040A0 VA: 0x180B04EA0
	|-AddressableAsset.<CoLoadAsync>d__11<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAsset.<CoLoadAsync>d__11<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAsset.<CoLoadAsync>d__11<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAsset.<CoLoadAsync>d__11<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAsset.<CoWaitUntilFinished>d__13<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2715
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public AddressableAsset<T> <>4__this; // 0x0

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
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04F80 Offset: 0xB04180 VA: 0x180B04F80
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAsset.<CoWaitUntilFinished>d__13<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Innersloth.Assets
[Serializable]
public class AddressableAsset<T> : AddressableAsset // TypeDefIndex: 2716
{
	// Fields
	[SerializeField]
	protected AssetReference assetRef; // 0x0
	private CallbackResultGroup onLoadedCallbackGroup; // 0x0
	private AsyncOperationHandle handle; // 0x0

	// Properties
	public CallbackResultGroup OnLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1
	public CallbackResultGroup get_OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAsset<object>.get_OnLoaded
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD780 Offset: 0x11BC980 VA: 0x1811BD780
	|-AddressableAsset<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(AssetReference assetRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD820 Offset: 0x11BCA20 VA: 0x1811BD820
	|-AddressableAsset<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCB10 Offset: 0x11BBD10 VA: 0x1811BCB10
	|-AddressableAsset<object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void OnDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD4E0 Offset: 0x11BC6E0 VA: 0x1811BD4E0
	|-AddressableAsset<object>.OnDeserialize
	*/

	// RVA: -1 Offset: -1
	public AddressableAsset<T> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC820 Offset: 0x11BBA20 VA: 0x1811BC820
	|-AddressableAsset<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual T GetAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCBA0 Offset: 0x11BBDA0 VA: 0x1811BCBA0
	|-AddressableAsset<object>.GetAsset
	*/

	[IteratorStateMachine(typeof(AddressableAsset.<CoLoadAsync>d__11<T>))]
	// RVA: -1 Offset: -1 Slot: 11
	public override IEnumerator CoLoadAsync(Action onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC970 Offset: 0x11BBB70 VA: 0x1811BC970
	|-AddressableAsset<object>.CoLoadAsync
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void LoadAsync(Action onSuccessCb, Action onErrorcb, Action onFinishedcb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD1B0 Offset: 0x11BC3B0 VA: 0x1811BD1B0
	|-AddressableAsset<object>.LoadAsync
	*/

	[IteratorStateMachine(typeof(AddressableAsset.<CoWaitUntilFinished>d__13<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator CoWaitUntilFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCA00 Offset: 0x11BBC00 VA: 0x1811BCA00
	|-AddressableAsset<object>.CoWaitUntilFinished
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD6E0 Offset: 0x11BC8E0 VA: 0x1811BD6E0
	|-AddressableAsset<object>.Unload
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCA80 Offset: 0x11BBC80 VA: 0x1811BCA80
	|-AddressableAsset<object>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override bool ReferenceEquals(AddressableAsset asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD5E0 Offset: 0x11BC7E0 VA: 0x1811BD5E0
	|-AddressableAsset<object>.ReferenceEquals
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override bool ReferenceEquals(AssetReference asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD550 Offset: 0x11BC750 VA: 0x1811BD550
	|-AddressableAsset<object>.ReferenceEquals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override AddressableAsset.AssetLoadState GetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCD70 Offset: 0x11BBF70 VA: 0x1811BCD70
	|-AddressableAsset<object>.GetState
	*/

	// RVA: -1 Offset: -1
	private void AttachOnCompleteCallback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC6A0 Offset: 0x11BB8A0 VA: 0x1811BC6A0
	|-AddressableAsset<object>.AttachOnCompleteCallback
	*/

	// RVA: -1 Offset: -1
	private void HandleOnCompleted(AsyncOperationHandle obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BCDF0 Offset: 0x11BBFF0 VA: 0x1811BCDF0
	|-AddressableAsset<object>.HandleOnCompleted
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<>c__DisplayClass11_0<T> // TypeDefIndex: 2717
{
	// Fields
	public Action<T> onSuccess; // 0x0
	public AddressableAsset<T> asset; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressableAssetExtensions.<>c__DisplayClass11_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <LoadAssetAsync>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09E90 Offset: 0xB09090 VA: 0x180B09E90
	|-AddressableAssetExtensions.<>c__DisplayClass11_0<object>.<LoadAssetAsync>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<>c__DisplayClass13_0<T> // TypeDefIndex: 2718
{
	// Fields
	public Action<T> onSuccess; // 0x0
	public AddressableAsset<T> asset; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressableAssetExtensions.<>c__DisplayClass13_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <LoadAssetAsync>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09E90 Offset: 0xB09090 VA: 0x180B09E90
	|-AddressableAssetExtensions.<>c__DisplayClass13_0<object>.<LoadAssetAsync>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<>c__DisplayClass3_0<T> // TypeDefIndex: 2719
{
	// Fields
	public Action<T> onFinished; // 0x0
	public AddressableAsset<T> asset; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressableAssetExtensions.<>c__DisplayClass3_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CoLoadAssetAsync>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09E90 Offset: 0xB09090 VA: 0x180B09E90
	|-AddressableAssetExtensions.<>c__DisplayClass3_0<object>.<CoLoadAssetAsync>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<>c__DisplayClass5_0<T> // TypeDefIndex: 2720
{
	// Fields
	public Action<T> onFinished; // 0x0
	public AddressableAsset<T> asset; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AddressableAssetExtensions.<>c__DisplayClass5_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CoLoadAssetAsync>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09E90 Offset: 0xB09090 VA: 0x180B09E90
	|-AddressableAssetExtensions.<>c__DisplayClass5_0<object>.<CoLoadAssetAsync>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2721
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MonoBehaviour behavior; // 0x20
	public AddressableAsset asset; // 0x28
	public Action onFinished; // 0x30

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

	// RVA: 0x8408E0 Offset: 0x83FAE0 VA: 0x1808408E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8409C0 Offset: 0x83FBC0 VA: 0x1808409C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2722
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GameObject gameObject; // 0x20
	public AddressableAsset asset; // 0x28
	public Action onFinished; // 0x30

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

	// RVA: 0x840A00 Offset: 0x83FC00 VA: 0x180840A00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x840A90 Offset: 0x83FC90 VA: 0x180840A90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2723
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public MonoBehaviour behavior; // 0x0
	public AssetReference reference; // 0x0
	public Action<T> onFinished; // 0x0

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
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04A10 Offset: 0xB03C10 VA: 0x180B04A10
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__2<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__3<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2724
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public Action<T> onFinished; // 0x0
	public GameObject gameObject; // 0x0
	public AssetReference reference; // 0x0

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
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04AA0 Offset: 0xB03CA0 VA: 0x180B04AA0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__3<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__4<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2725
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public MonoBehaviour behavior; // 0x0
	public IAddressableAssetProvider<T> provider; // 0x0
	public Action<T> onFinished; // 0x0

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
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04C10 Offset: 0xB03E10 VA: 0x180B04C10
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__4<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetExtensions.<CoLoadAssetAsync>d__5<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2726
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public Action<T> onFinished; // 0x0
	public GameObject gameObject; // 0x0
	public IAddressableAssetProvider<T> provider; // 0x0

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
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB04CA0 Offset: 0xB03EA0 VA: 0x180B04CA0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-AddressableAssetExtensions.<CoLoadAssetAsync>d__5<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Innersloth.Assets
[Extension]
public static class AddressableAssetExtensions // TypeDefIndex: 2727
{
	// Methods

	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__0))]
	[Extension]
	// RVA: 0x82D770 Offset: 0x82C970 VA: 0x18082D770
	public static IEnumerator CoLoadAssetAsync(MonoBehaviour behavior, AddressableAsset asset, Action onFinished) { }

	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__1))]
	[Extension]
	// RVA: 0x82D7F0 Offset: 0x82C9F0 VA: 0x18082D7F0
	public static IEnumerator CoLoadAssetAsync(GameObject gameObject, AddressableAsset asset, Action onFinished) { }

	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__2<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerator CoLoadAssetAsync<T>(MonoBehaviour behavior, AssetReference reference, Action<T> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5DC0 Offset: 0x8E4FC0 VA: 0x1808E5DC0
	|-AddressableAssetExtensions.CoLoadAssetAsync<object>
	*/

	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__3<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerator CoLoadAssetAsync<T>(GameObject gameObject, AssetReference reference, Action<T> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5E60 Offset: 0x8E5060 VA: 0x1808E5E60
	|-AddressableAssetExtensions.CoLoadAssetAsync<object>
	*/

	[Extension]
	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__4<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerator CoLoadAssetAsync<T>(MonoBehaviour behavior, IAddressableAssetProvider<T> provider, Action<T> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5DC0 Offset: 0x8E4FC0 VA: 0x1808E5DC0
	|-AddressableAssetExtensions.CoLoadAssetAsync<object>
	*/

	[IteratorStateMachine(typeof(AddressableAssetExtensions.<CoLoadAssetAsync>d__5<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerator CoLoadAssetAsync<T>(GameObject gameObject, IAddressableAssetProvider<T> provider, Action<T> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5E60 Offset: 0x8E5060 VA: 0x1808E5E60
	|-AddressableAssetExtensions.CoLoadAssetAsync<object>
	*/

	[Extension]
	// RVA: 0x82DC20 Offset: 0x82CE20 VA: 0x18082DC20
	public static void UnloadAddressableAsset(MonoBehaviour behavior, AddressableAsset asset) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void UnloadAddressableAsset<T>(MonoBehaviour behavior, IAddressableAssetProvider<T> provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E63A0 Offset: 0x8E55A0 VA: 0x1808E63A0
	|-AddressableAssetExtensions.UnloadAddressableAsset<object>
	*/

	[Extension]
	// RVA: 0x82DAC0 Offset: 0x82CCC0 VA: 0x18082DAC0
	public static void LoadAssetAsync(MonoBehaviour behavior, AddressableAsset asset, Action onSuccess, Action onError) { }

	[Extension]
	// RVA: 0x82D970 Offset: 0x82CB70 VA: 0x18082D970
	public static void LoadAssetAsync(GameObject gameObject, AddressableAsset asset, Action onSuccess, Action onError) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void LoadAssetAsync<T>(MonoBehaviour behavior, AssetReference reference, Action<T> onSuccess, Action onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E6140 Offset: 0x8E5340 VA: 0x1808E6140
	|-AddressableAssetExtensions.LoadAssetAsync<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LoadAssetAsync<T>(GameObject gameObject, AssetReference reference, Action<T> onSuccess, Action onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5F90 Offset: 0x8E5190 VA: 0x1808E5F90
	|-AddressableAssetExtensions.LoadAssetAsync<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LoadAssetAsync<T>(MonoBehaviour behavior, IAddressableAssetProvider<T> provider, Action<T> onSuccess, Action onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5F00 Offset: 0x8E5100 VA: 0x1808E5F00
	|-AddressableAssetExtensions.LoadAssetAsync<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LoadAssetAsync<T>(GameObject gameObject, IAddressableAssetProvider<T> provider, Action<T> onSuccess, Action onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E61D0 Offset: 0x8E53D0 VA: 0x1808E61D0
	|-AddressableAssetExtensions.LoadAssetAsync<object>
	*/

	[Extension]
	// RVA: 0x82D870 Offset: 0x82CA70 VA: 0x18082D870
	public static AddressableAssetGroup GetAssetGroup(MonoBehaviour behaviour) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetGroup.<CoLoadAsync>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2728
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AddressableAssetGroup <>4__this; // 0x20
	public Action onFinished; // 0x28

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

	// RVA: 0x840AD0 Offset: 0x83FCD0 VA: 0x180840AD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x840BC0 Offset: 0x83FDC0 VA: 0x180840BC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AddressableAssetGroup.<CoWaitUntilFinished>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2729
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AddressableAssetGroup <>4__this; // 0x20

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

	// RVA: 0x840D60 Offset: 0x83FF60 VA: 0x180840D60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x840DC0 Offset: 0x83FFC0 VA: 0x180840DC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Innersloth.Assets
public class AddressableAssetGroup : AddressableAsset // TypeDefIndex: 2730
{
	// Fields
	public readonly CallbackResultGroup OnLoaded; // 0x10
	private List<AddressableAsset> Assets; // 0x18

	// Methods

	// RVA: 0x82E990 Offset: 0x82DB90 VA: 0x18082E990
	public void .ctor() { }

	// RVA: 0x82EA50 Offset: 0x82DC50 VA: 0x18082EA50
	public void .ctor(IEnumerable<AddressableAsset> assetList) { }

	// RVA: 0x82E2F0 Offset: 0x82D4F0 VA: 0x18082E2F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x82DD80 Offset: 0x82CF80 VA: 0x18082DD80
	public void Add(AddressableAsset asset) { }

	// RVA: 0x82DE50 Offset: 0x82D050 VA: 0x18082DE50
	public void Add(IEnumerable<AddressableAsset> list) { }

	// RVA: -1 Offset: -1
	public AddressableAsset<T> AddReference<T>(AssetReference assetRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E64E0 Offset: 0x8E56E0 VA: 0x1808E64E0
	|-AddressableAssetGroup.AddReference<object>
	*/

	// RVA: -1 Offset: -1
	public AddressableAsset<T> GetFromReference<T>(AssetReference assetRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E67D0 Offset: 0x8E59D0 VA: 0x1808E67D0
	|-AddressableAssetGroup.GetFromReference<object>
	*/

	// RVA: -1 Offset: -1
	public AddressableAsset<T> GetFromReferenceRecur<T>(AssetReference assetRef) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E65A0 Offset: 0x8E57A0 VA: 0x1808E65A0
	|-AddressableAssetGroup.GetFromReferenceRecur<object>
	*/

	// RVA: 0x82E810 Offset: 0x82DA10 VA: 0x18082E810
	public bool Remove(AddressableAsset asset) { }

	// RVA: 0x82E000 Offset: 0x82D200 VA: 0x18082E000
	public void Clear() { }

	// RVA: 0x82E360 Offset: 0x82D560 VA: 0x18082E360 Slot: 9
	public override AddressableAsset.AssetLoadState GetState() { }

	// RVA: 0x82E3A0 Offset: 0x82D5A0 VA: 0x18082E3A0 Slot: 10
	public override void LoadAsync(Action onSuccessCb, Action onErrorcb, Action onFinishedcb) { }

	// RVA: 0x82E6C0 Offset: 0x82D8C0 VA: 0x18082E6C0
	private void OnAssetLoadedInternal() { }

	[IteratorStateMachine(typeof(AddressableAssetGroup.<CoLoadAsync>d__15))]
	// RVA: 0x82E060 Offset: 0x82D260 VA: 0x18082E060 Slot: 11
	public override IEnumerator CoLoadAsync(Action onFinished) { }

	[IteratorStateMachine(typeof(AddressableAssetGroup.<CoWaitUntilFinished>d__16))]
	// RVA: 0x82E0D0 Offset: 0x82D2D0 VA: 0x18082E0D0
	public IEnumerator CoWaitUntilFinished() { }

	// RVA: 0x82DFE0 Offset: 0x82D1E0 VA: 0x18082DFE0
	public bool AnyAssetsLoading() { }

	// RVA: 0x82E590 Offset: 0x82D790 VA: 0x18082E590
	public int NumAssetsLoading() { }

	// RVA: 0x82DEB0 Offset: 0x82D0B0 VA: 0x18082DEB0
	public bool AllAssetsLoaded() { }

	// RVA: 0x82E880 Offset: 0x82DA80 VA: 0x18082E880 Slot: 12
	public override void Unload() { }

	// RVA: 0x82E130 Offset: 0x82D330 VA: 0x18082E130 Slot: 13
	public override void Destroy() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<AddressableAsset> GetAssets() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	public override bool ReferenceEquals(AddressableAsset asset) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 15
	public override bool ReferenceEquals(AssetReference asset) { }
}

// Namespace: Innersloth.Assets
public class AddressableAssetHandler : MonoBehaviour // TypeDefIndex: 2731
{
	// Fields
	private AddressableAssetGroup assetGroup; // 0x20

	// Methods

	// RVA: 0x82EB40 Offset: 0x82DD40 VA: 0x18082EB40
	public static ValueTuple<AddressableAssetHandler, AddressableAssetGroup> AddToGameObject(GameObject obj, AddressableAsset asset) { }

	// RVA: 0x82EBF0 Offset: 0x82DDF0 VA: 0x18082EBF0
	public static ValueTuple<AddressableAssetHandler, AddressableAssetGroup> GetOrCreate(GameObject obj) { }

	// RVA: 0x82ECD0 Offset: 0x82DED0 VA: 0x18082ECD0
	private void OnDestroy() { }

	// RVA: 0x82ED10 Offset: 0x82DF10 VA: 0x18082ED10
	public void .ctor() { }
}

// Namespace: Innersloth.Assets
public class AddressableSpriteBehavior : MonoBehaviour // TypeDefIndex: 2732
{
	// Fields
	public bool unloadOnDisable; // 0x20
	private AddressableAsset<Sprite> asset; // 0x28
	private SpriteRenderer spriteRenderer; // 0x30

	// Methods

	// RVA: 0x82F1B0 Offset: 0x82E3B0 VA: 0x18082F1B0
	public void ReplaceAsset(AddressableAsset<Sprite> newAsset) { }

	// RVA: 0x82EF50 Offset: 0x82E150 VA: 0x18082EF50
	public static AddressableSpriteBehavior AddToSpriteRenderer(SpriteRenderer pSpriteRenderer, AddressableAsset<Sprite> asset) { }

	// RVA: 0x82EFC0 Offset: 0x82E1C0 VA: 0x18082EFC0
	private void Start() { }

	// RVA: 0x82EFC0 Offset: 0x82E1C0 VA: 0x18082EFC0
	private void Awake() { }

	// RVA: 0x82F160 Offset: 0x82E360 VA: 0x18082F160
	private void OnDisable() { }

	// RVA: 0x82EFC0 Offset: 0x82E1C0 VA: 0x18082EFC0
	private void OnEnable() { }

	// RVA: 0x82F110 Offset: 0x82E310 VA: 0x18082F110
	private void OnDestroy() { }

	// RVA: 0x82EFD0 Offset: 0x82E1D0 VA: 0x18082EFD0
	private void Load() { }

	// RVA: 0x82F230 Offset: 0x82E430 VA: 0x18082F230
	private void Unload() { }

	// RVA: 0x82F070 Offset: 0x82E270 VA: 0x18082F070
	private void OnAssetLoaded() { }

	// RVA: 0x6812E0 Offset: 0x6804E0 VA: 0x1806812E0
	public void .ctor() { }
}

// Namespace: Innersloth.Assets
public class CallbackResultGroup // TypeDefIndex: 2733
{
	// Fields
	private CallbackGroup onError; // 0x10
	private CallbackGroup onSuccess; // 0x18
	private CallbackGroup onFinished; // 0x20

	// Methods

	// RVA: 0x832D10 Offset: 0x831F10 VA: 0x180832D10
	public void AddOnSuccess(Action callback) { }

	// RVA: 0x832CD0 Offset: 0x831ED0 VA: 0x180832CD0
	public void AddOnError(Action callback) { }

	// RVA: 0x832CF0 Offset: 0x831EF0 VA: 0x180832CF0
	public void AddOnFinished(Action callback) { }

	// RVA: 0x832F90 Offset: 0x832190 VA: 0x180832F90
	public void CallSuccessAndClear() { }

	// RVA: 0x832D30 Offset: 0x831F30 VA: 0x180832D30
	public void CallErrorAndClear() { }

	// RVA: 0x832E60 Offset: 0x832060 VA: 0x180832E60
	public void CallFinishedAndClear() { }

	// RVA: 0x8330C0 Offset: 0x8322C0 VA: 0x1808330C0
	public void Clear() { }

	// RVA: 0x8331D0 Offset: 0x8323D0 VA: 0x1808331D0
	public void Destroy() { }

	// RVA: 0x833210 Offset: 0x832410 VA: 0x180833210
	public void .ctor() { }
}

// Namespace: Innersloth.Assets
public class CallbackGroup // TypeDefIndex: 2734
{
	// Fields
	private List<Action> callbacks; // 0x10

	// Methods

	// RVA: 0x8329C0 Offset: 0x831BC0 VA: 0x1808329C0
	public void AddCallback(Action callback) { }

	// RVA: 0x832AE0 Offset: 0x831CE0 VA: 0x180832AE0
	public void Call() { }

	// RVA: 0x832BF0 Offset: 0x831DF0 VA: 0x180832BF0
	public void Clear() { }

	// RVA: 0x832A70 Offset: 0x831C70 VA: 0x180832A70
	public void CallAndClear() { }

	// RVA: 0x832C50 Offset: 0x831E50 VA: 0x180832C50
	public void Destroy() { }

	// RVA: 0x832C60 Offset: 0x831E60 VA: 0x180832C60
	public void .ctor() { }
}

// Namespace: Innersloth.Assets
public interface IAddressableAssetProvider<T> // TypeDefIndex: 2735
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AddressableAsset<T> CreateAddressableAsset();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAddressableAssetProvider<object>.CreateAddressableAsset
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AssetReference GetAssetReference();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAddressableAssetProvider<object>.GetAssetReference
	*/
}

// Namespace: Assets.CoreScripts
public class UnityTelemetry : DestroyableSingleton<UnityTelemetry> // TypeDefIndex: 2736
{
	// Fields
	private static readonly string[] ColorNames; // 0x0
	private bool amHost; // 0x28
	private bool gameStarted; // 0x29
	private DateTime timeStarted; // 0x30

	// Methods

	// RVA: 0x841460 Offset: 0x840660 VA: 0x180841460
	public void Init() { }

	// RVA: 0x8417C0 Offset: 0x8409C0 VA: 0x1808417C0
	public void StartGame(bool isHost, int playerCount, int impostorCount, NetworkModes gameMode, uint timesImpostor, uint gamesPlayed, uint crewStreak) { }

	// RVA: 0x8414C0 Offset: 0x8406C0 VA: 0x1808414C0
	public void StartGameCosmetics(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId) { }

	// RVA: 0x842090 Offset: 0x841290 VA: 0x180842090
	public void WriteMeetingStarted(bool isEmergency) { }

	// RVA: 0x841FA0 Offset: 0x8411A0 VA: 0x180841FA0
	public void WriteMeetingEnded(float duration) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void WritePosition(byte playerNum, Vector2 worldPos) { }

	// RVA: 0x842180 Offset: 0x841380 VA: 0x180842180
	public void WriteMurder() { }

	// RVA: 0x8421D0 Offset: 0x8413D0 VA: 0x1808421D0
	public void WriteSabotageUsed(SystemTypes systemType) { }

	// RVA: 0x8411B0 Offset: 0x8403B0 VA: 0x1808411B0
	public void CardSwipeComplete(int attempts) { }

	// RVA: 0x8422C0 Offset: 0x8414C0 VA: 0x1808422C0
	public void WriteUse(byte playerNum, TaskTypes taskType, Vector3 worldPos) { }

	// RVA: 0x841DC0 Offset: 0x840FC0 VA: 0x180841DC0
	public void WriteCompleteTask(TaskTypes taskType) { }

	// RVA: 0x841EB0 Offset: 0x8410B0 VA: 0x180841EB0
	internal void WriteDisconnect(DisconnectReasons reason) { }

	// RVA: 0x8412A0 Offset: 0x8404A0 VA: 0x1808412A0
	public void EndGame(GameOverReason endReason) { }

	// RVA: 0x841470 Offset: 0x840670 VA: 0x180841470
	public void SendWho() { }

	// RVA: 0x841AB0 Offset: 0x840CB0 VA: 0x180841AB0
	public void WonGame(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId) { }

	// RVA: 0x842730 Offset: 0x841930 VA: 0x180842730
	public void .ctor() { }

	// RVA: 0x8423B0 Offset: 0x8415B0 VA: 0x1808423B0
	private static void .cctor() { }
}

// Namespace: Assets.InnerNet
public static class EmailUtils // TypeDefIndex: 2737
{
	// Methods

	// RVA: 0x83EB90 Offset: 0x83DD90 VA: 0x18083EB90
	public static string CensorEmail(string rawEmail) { }
}

// Namespace: Assets.InnerNet
public class PinRequestResponse // TypeDefIndex: 2738
{
	// Fields
	public string Pin; // 0x10
	public string Url; // 0x18
	public PinRequestError[] Errors; // 0x20

	// Methods

	// RVA: 0x83FED0 Offset: 0x83F0D0 VA: 0x18083FED0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class PinRequestError // TypeDefIndex: 2739
{
	// Fields
	public int Code; // 0x10
	public string Title; // 0x18
	public string Detail; // 0x20

	// Methods

	// RVA: 0x83FE50 Offset: 0x83F050 VA: 0x18083FE50 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class PinRequest // TypeDefIndex: 2740
{
	// Fields
	[JsonProperty("continuation_token")]
	public string ContinuanceToken; // 0x10
	[JsonProperty("language")]
	public string Language; // 0x18

	// Methods

	// RVA: 0x83FF20 Offset: 0x83F120 VA: 0x18083FF20
	public static PinRequest RequestPin(string continuanceToken) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum LinkStatusResponse.LinkStatus // TypeDefIndex: 2741
{
	// Fields
	public int value__; // 0x0
	public const LinkStatusResponse.LinkStatus Pending = 0;
	public const LinkStatusResponse.LinkStatus Success = 1;
	public const LinkStatusResponse.LinkStatus Error = 2;
}

// Namespace: Assets.InnerNet
public class LinkStatusResponse // TypeDefIndex: 2742
{
	// Fields
	public LinkStatusResponse.LinkStatus Status; // 0x10
	public PinRequestError[] Errors; // 0x18

	// Methods

	// RVA: 0x83FBB0 Offset: 0x83EDB0 VA: 0x18083FBB0
	public void .ctor() { }
}

// Namespace: 
public class Response.ResponseData<T> // TypeDefIndex: 2743
{
	// Fields
	public string Type; // 0x0
	public T Attributes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Response.ResponseData<object>..ctor
	|-Response.ResponseData<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Assets.InnerNet
public class Response<T> // TypeDefIndex: 2744
{
	// Fields
	public Response.ResponseData<T> Data; // 0x0
	public ResponseError[] Errors; // 0x0
	public ResponseError[] Warnings; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Response<object>..ctor
	|-Response<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class ResponseWithTimestamp.ResponseData<T> // TypeDefIndex: 2745
{
	// Fields
	public string Type; // 0x0
	public T Attributes; // 0x0
	public string Timestamp; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ResponseWithTimestamp.ResponseData<AnnouncementList>..ctor
	|-ResponseWithTimestamp.ResponseData<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Assets.InnerNet
public class ResponseWithTimestamp<T> // TypeDefIndex: 2746
{
	// Fields
	public ResponseWithTimestamp.ResponseData<T> Data; // 0x0
	public ResponseError[] Errors; // 0x0
	public ResponseError[] Warnings; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ResponseWithTimestamp<AnnouncementList>..ctor
	|-ResponseWithTimestamp<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Assets.InnerNet
public class NestedResponseData<T> // TypeDefIndex: 2747
{
	// Fields
	public string Type; // 0x0
	public T Attributes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-NestedResponseData<object>..ctor
	|-NestedResponseData<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class Request.RequestData<T> // TypeDefIndex: 2748
{
	// Fields
	[JsonProperty("attributes")]
	public T Attributes; // 0x0
	[JsonProperty("type")]
	public string Type; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Request.RequestData<object>..ctor
	|-Request.RequestData<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Assets.InnerNet
public class Request<T> // TypeDefIndex: 2749
{
	// Fields
	[JsonProperty("data")]
	public Request.RequestData<T> Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Request<object>..ctor
	|-Request<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Assets.InnerNet
public enum CurrencyTypes // TypeDefIndex: 2750
{
	// Fields
	public int value__; // 0x0
	public const CurrencyTypes Stars = 0;
	public const CurrencyTypes Beans = 1;
	public const CurrencyTypes Pods = 2;
}

// Namespace: Assets.InnerNet
public enum ResponseState // TypeDefIndex: 2751
{
	// Fields
	public int value__; // 0x0
	public const ResponseState Failed = 0;
	public const ResponseState Success = 1;
}

// Namespace: Assets.InnerNet
public class ResponsePurchase // TypeDefIndex: 2752
{
	// Fields
	[JsonProperty("item_id")]
	public string ItemId; // 0x10
	[JsonProperty("currency_type")]
	public string CurrencyType; // 0x18
	[JsonProperty("platform")]
	public string Platform; // 0x20
	[JsonProperty("item_cost")]
	public int ItemCost; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseError // TypeDefIndex: 2753
{
	// Fields
	public int Code; // 0x10
	public string Title; // 0x18
	public string Keyword; // 0x20
	public int Detail; // 0x28

	// Methods

	// RVA: 0x840550 Offset: 0x83F750 VA: 0x180840550 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public struct AnnouncementList // TypeDefIndex: 2754
{
	// Fields
	[JsonProperty("announcements")]
	public Announcement[] Announcements; // 0x0
	[JsonProperty("page")]
	public uint Page; // 0x8
	[JsonProperty("pages")]
	public uint Pages; // 0xC
}

// Namespace: Assets.InnerNet
public struct Announcement // TypeDefIndex: 2755
{
	// Fields
	public string Id; // 0x0
	public uint Language; // 0x8
	public int Number; // 0xC
	public string Title; // 0x10
	public string SubTitle; // 0x18
	public string ShortTitle; // 0x20
	public bool PinState; // 0x28
	public string Text; // 0x30
	public string Date; // 0x38
}

// Namespace: Assets.InnerNet
public class GameInviteRequest // TypeDefIndex: 2756
{
	// Fields
	[JsonProperty("recipient_puid")]
	public string RecipientId; // 0x10
	[JsonProperty("room_code")]
	public string RoomCode; // 0x18

	// Methods

	// RVA: 0x83FA40 Offset: 0x83EC40 VA: 0x18083FA40
	public static Request<GameInviteRequest> SendGameInvite(string recipientId, string roomCode) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class FriendsListRequest // TypeDefIndex: 2757
{
	// Fields
	[JsonProperty("username")]
	public string Username; // 0x10
	[JsonProperty("recipient_puid")]
	public string RecipientId; // 0x18
	[JsonProperty("recipient_friendcode")]
	public string RecipientUsername; // 0x20

	// Methods

	// RVA: 0x83F740 Offset: 0x83E940 VA: 0x18083F740
	public static Request<FriendsListRequest> ChangeUsername(string username) { }

	// RVA: 0x83F940 Offset: 0x83EB40 VA: 0x18083F940
	public static Request<FriendsListRequest> SendRequest(string recipientId, string type) { }

	// RVA: 0x83F840 Offset: 0x83EA40 VA: 0x18083F840
	public static Request<FriendsListRequest> SendRequestByUsername(string recipientName) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseFriendsListRequest // TypeDefIndex: 2758
{
	// Fields
	[JsonProperty("recipient_puid")]
	public string RecipientId; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseReceivedFriendRequestWrapper // TypeDefIndex: 2759
{
	// Fields
	[JsonProperty("senders")]
	public NestedResponseData<ResponseReceivedFriendRequest>[] Senders; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseReceivedFriendRequest // TypeDefIndex: 2760
{
	// Fields
	[JsonProperty("sender_puid")]
	public string SenderId; // 0x10
	[JsonProperty("sender_friendcode")]
	public string SenderFriendCode; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseGameInvites // TypeDefIndex: 2761
{
	// Fields
	[JsonProperty("next_poll_seconds")]
	public float NextPollSeconds; // 0x10
	[JsonProperty("invites")]
	public NestedResponseData<LobbyInvite>[] Invites; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class LobbyInvite // TypeDefIndex: 2762
{
	// Fields
	[JsonProperty("sender_puid")]
	public string SenderId; // 0x10
	[JsonProperty("recipient_puid")]
	public string RecipientId; // 0x18
	[JsonProperty("room_code")]
	public string RoomCode; // 0x20
	[JsonProperty("sender_friendcode")]
	public string SenderFriendCode; // 0x28
	[JsonProperty("recipient_friendcode")]
	public string RecipientFriendCode; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseFriendWrapper // TypeDefIndex: 2763
{
	// Fields
	[JsonProperty("friends")]
	public NestedResponseData<ResponseFriends>[] Friends; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseFriends // TypeDefIndex: 2764
{
	// Fields
	[JsonProperty("friend_friendcode")]
	public string FriendCode; // 0x10
	[JsonProperty("friend_puid")]
	public string FriendPuid; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseBlockedWrapper // TypeDefIndex: 2765
{
	// Fields
	[JsonProperty("blocked_by")]
	public NestedResponseData<ResponseBlockedBy>[] BlockedBy; // 0x10
	[JsonProperty("blocking")]
	public NestedResponseData<ResponseBlockedPlayer>[] Blocking; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseBlockedPlayer // TypeDefIndex: 2766
{
	// Fields
	[JsonProperty("recipient_friendcode")]
	public string FriendCode; // 0x10
	[JsonProperty("recipient_puid")]
	public string FriendPuid; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseBlockedBy // TypeDefIndex: 2767
{
	// Fields
	[JsonProperty("sender_friendcode")]
	public string FriendCode; // 0x10
	[JsonProperty("sender_puid")]
	public string SenderId; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseFriendCode : ResponseFriendsListRequest // TypeDefIndex: 2768
{
	// Fields
	[JsonProperty("username")]
	public string Username; // 0x18
	[JsonProperty("discriminator")]
	public string Discriminator; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class MergeGuestAccount // TypeDefIndex: 2769
{
	// Fields
	[JsonProperty("merge_to_id_token")]
	public string MergeToToken; // 0x10
	[JsonProperty("merge_from_id_token")]
	public string MergeFromToken; // 0x18

	// Methods

	// RVA: 0x83FD40 Offset: 0x83EF40 VA: 0x18083FD40
	public static Request<MergeGuestAccount> ToMergeGuestAccount(string mergeToToken, string mergeFromToken) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class RedeemCurrency // TypeDefIndex: 2770
{
	// Fields
	[JsonProperty("item_id")]
	public string ItemId; // 0x10
	[JsonProperty("currency_type")]
	public string CurrencyType; // 0x18
	[JsonProperty("platform")]
	public string Platform; // 0x20

	// Methods

	// RVA: 0x840180 Offset: 0x83F380 VA: 0x180840180
	public static Request<RedeemCurrency> ForNonCubePurchase(string productId, CurrencyTypes currencyType) { }

	// RVA: 0x83FFA0 Offset: 0x83F1A0 VA: 0x18083FFA0
	public static Request<RedeemCurrency> ForCubePurchase(string productId, string cubeName) { }

	// RVA: 0x8403C0 Offset: 0x83F5C0 VA: 0x1808403C0
	public static string ProductIdToItemId(string productId) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class InnerslothReceipt // TypeDefIndex: 2771
{
	// Fields
	[JsonProperty("items")]
	public string[] Items; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string[] items) { }

	// RVA: 0x83FB50 Offset: 0x83ED50 VA: 0x18083FB50
	public void .ctor(List<string> items) { }
}

// Namespace: Assets.InnerNet
public class ValidateReceipt // TypeDefIndex: 2772
{
	// Fields
	public const string IapEntitlementType = "in-app-purchase";
	public const string DlcEntitlementType = "dlc";
	public const string InnerslothEntitlementType = "innersloth-receipt";
	[JsonProperty("entitlement_type")]
	public string EntitlementType; // 0x10
	[JsonProperty("receipt")]
	public string Receipt; // 0x18

	// Methods

	// RVA: 0x842B00 Offset: 0x841D00 VA: 0x180842B00
	public static Request<ValidateReceipt> Create(string entitlementType, string receipt) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ValidateReceiptBatch // TypeDefIndex: 2773
{
	// Fields
	[JsonProperty("receipts")]
	public List<Request.RequestData<ValidateReceipt>> receipts; // 0x10

	// Methods

	// RVA: 0x842770 Offset: 0x841970 VA: 0x180842770
	public static Request<ValidateReceiptBatch> Create(string entitlementType, List<string> receiptStrings) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public struct iOSReceipt // TypeDefIndex: 2774
{
	// Fields
	public string receiptJSON; // 0x0
	public string productID; // 0x8
}

// Namespace: Assets.InnerNet
public struct win10Receipt // TypeDefIndex: 2775
{
	// Fields
	[JsonProperty("item_id")]
	public string itemId; // 0x0
	[JsonProperty("token")]
	public string xstsToken; // 0x8
}

// Namespace: Assets.InnerNet
public struct EgsReceipt // TypeDefIndex: 2776
{
	// Fields
	[JsonProperty("catalog_item_id")]
	public string catalogItemId; // 0x0
	[JsonProperty("entitlement_id")]
	public string entitlementId; // 0x8
}

// Namespace: Assets.InnerNet
public class SteamTxnInit // TypeDefIndex: 2777
{
	// Fields
	[JsonProperty("steam_id")]
	public string steamId; // 0x10
	[JsonProperty("currency_code")]
	public string currencyCode; // 0x18
	[JsonProperty("language_code")]
	public uint languageCode; // 0x20
	[JsonProperty("item_id")]
	public int itemId; // 0x24

	// Methods

	// RVA: 0x840810 Offset: 0x83FA10 VA: 0x180840810
	public static Request<SteamTxnInit> Create(SteamTxnInit payloadData) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class SteamTxnFin // TypeDefIndex: 2778
{
	// Fields
	[JsonProperty("order_id")]
	public string orderId; // 0x10

	// Methods

	// RVA: 0x840710 Offset: 0x83F910 VA: 0x180840710
	public static Request<SteamTxnFin> Create(string orderId) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class ResponseSteamTxnInit // TypeDefIndex: 2779
{
	// Fields
	[JsonProperty("order_id")]
	public string orderID; // 0x10
	[JsonProperty("steam_id")]
	public string steamID; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Assets.InnerNet
public class iOSTransactionReceipt // TypeDefIndex: 2780
{
	// Fields
	[JsonProperty("Store")]
	public string Store; // 0x10
	[JsonProperty("TransactionID")]
	public string TransactionID; // 0x18
	[JsonProperty("Payload")]
	public string Payload; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 2781
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 2782
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 2783
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 2784
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 2785
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 2786
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 2787
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 2788
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 2789
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 // TypeDefIndex: 2790
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52094 // TypeDefIndex: 2791
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=71409 // TypeDefIndex: 2792
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2793
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52094 01331D40C29023070AE4DFA24C4ACD78C61619527F782ABE01BAD8864C0CBE75 /*Metadata offset 0x869E58*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 073847F49D91209374086319B95569DBB19BCC61615D295B94FD15A477F41762 /*Metadata offset 0x8769D8*/; // 0xCB7E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 07B2D39C6D5FC7AC955826705E2801786C9DE1024EBF555164E3B1A6EF4DDDF8 /*Metadata offset 0x876A20*/; // 0xCBBE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 16DECDBE9A468CD072B0F95AFBA603A21291779C9E9C45D3613F0FD4792EA798 /*Metadata offset 0x876A48*/; // 0xCBDE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 174B72F755E021D8325E6DDF407907D4D840EB30AD4E82577048C29CEE9EA4CE /*Metadata offset 0x876A78*/; // 0xCC06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 19C5F80D4434EEB123D0EFC9E22A53D4C67BE073A5854DB5A3AE11ABDB9868CD /*Metadata offset 0x876A98*/; // 0xCC1E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 3AF27B8D58C0E87F87B323FD911CF273DC794FE3BB4E091CC479881A3D14FE2E /*Metadata offset 0x876AC0*/; // 0xCC42
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 3CFAEC23A762AEBEED5D88A72B70FCB989A1F1208B340838E9DE510A00435008 /*Metadata offset 0x876AD8*/; // 0xCC56
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 4C80C608ECB8265D17259D2606F969B6192DEA5C611C4D378D4C655B2AE751C1 /*Metadata offset 0x876AF8*/; // 0xCC6E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 57F3F71A00731254E099EA07DF809A60B755443DAD8E3A21BFEFB2E49644D486 /*Metadata offset 0x876B18*/; // 0xCC86
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=71409 68BCCFEC6DED94AAC85EC4461AE561194DD4A386AEFCFC158EBE4204384818B7 /*Metadata offset 0x876B28*/; // 0xCC92
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25 /*Metadata offset 0x888220*/; // 0x1E383
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 6D08BE7C27836DA3DE1A3303A40D7BD35DBF2B4A7B0196E78BF562BFDEC491C4 /*Metadata offset 0x888238*/; // 0x1E393
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 770E3EEC1AD6A9614E07CDD3B916A2D583833FA6E0FC86433EA9540949680017 /*Metadata offset 0x888258*/; // 0x1E3AB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 82C53C7AD190D4A1AF04DDEEBBDDAE054BCE4B5104FF532E0500E3235646C5B6 /*Metadata offset 0x888268*/; // 0x1E3B7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 85136C27F5B053C276875737809FC1341FB1A18F5478DEA5EE04B7F0AE8BF1A3 /*Metadata offset 0x888280*/; // 0x1E3C7
	internal static readonly long 86189386DC64A5B367B98372CB2F73A7695B06E787920A710B3AE977E394B977 = 794900749020300301; // 0x1E3D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8C601D43A62F395E2C879A9C46DA8FD2C2F7D1119C87D017CBF9D88D1DE5C121 /*Metadata offset 0x8882A8*/; // 0x1E3E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 8DFCB48E3E55E0F4CA42190E635777ECAD6AC5E26659114E046268C732CE5F55 /*Metadata offset 0x8882C0*/; // 0x1E3F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 9334C3DFE146D6C69E48F30F867D260973B3AA928B8F1A945E5345E92D3BAA8C /*Metadata offset 0x8882D0*/; // 0x1E3FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 93437A32B343DDF076E6C002F2995CAB28E3B262D97A41A5D7D87B763BFC7BDD /*Metadata offset 0x888320*/; // 0x1E444
	internal static readonly long 9424D90BF05FC3A0D3FFA788396E769D787490A8AC93BBD73F3DFBC82F6B0F93 = 1125921381810179; // 0x1E460
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 9C8059975F026A65534B2C106E347191685DB1EC4550B224133C18102FAEFB2C /*Metadata offset 0x888350*/; // 0x1E468
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AB314608244B7F2CBF3F6A49537C4C14571E0EFE6DC24C7B2E6284551C8C5017 /*Metadata offset 0x8883A0*/; // 0x1E4B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B58C4CA33975FD36A94760321CA9C092852724982B983B6C918D6BE7FB821FB4 /*Metadata offset 0x8883B8*/; // 0x1E4C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 D5654CE688D3D2DEB7B7824D69ACDD962115E1F58358F8B434F13B2F0AE57093 /*Metadata offset 0x888400*/; // 0x1E500
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 DD334CD5ACCBEA204271AF26DC2B0D1428D332F485995C862DE63A8B705A3150 /*Metadata offset 0x888448*/; // 0x1E540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA73B51C7BC8BFAA144119D881C23B631329543292B783929F9B42AD940D0583 /*Metadata offset 0x888450*/; // 0x1E546

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 2794
{}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Interop.Kernel32.WIN32_FIND_DATA.<_cFileName>e__FixedBuffer // TypeDefIndex: 2795
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct Interop.Kernel32.WIN32_FIND_DATA.<_cAlternateFileName>e__FixedBuffer // TypeDefIndex: 2796
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
internal struct Interop.Kernel32.WIN32_FIND_DATA // TypeDefIndex: 2797
{
	// Fields
	internal uint dwFileAttributes; // 0x0
	internal Interop.Kernel32.FILE_TIME ftCreationTime; // 0x4
	internal Interop.Kernel32.FILE_TIME ftLastAccessTime; // 0xC
	internal Interop.Kernel32.FILE_TIME ftLastWriteTime; // 0x14
	internal uint nFileSizeHigh; // 0x1C
	internal uint nFileSizeLow; // 0x20
	internal uint dwReserved0; // 0x24
	internal uint dwReserved1; // 0x28
	[FixedBuffer(typeof(char), 260)]
	private Interop.Kernel32.WIN32_FIND_DATA.<_cFileName>e__FixedBuffer _cFileName; // 0x2C
	[FixedBuffer(typeof(char), 14)]
	private Interop.Kernel32.WIN32_FIND_DATA.<_cAlternateFileName>e__FixedBuffer _cAlternateFileName; // 0x234

	// Properties
	internal ReadOnlySpan<char> cFileName { get; }

	// Methods

	// RVA: 0x1581F60 Offset: 0x1581160 VA: 0x181581F60
	internal ReadOnlySpan<char> get_cFileName() { }

	// RVA: 0x1581EA0 Offset: 0x15810A0 VA: 0x181581EA0
	internal void SetFileName(string fileName) { }
}

// Namespace: 
internal struct Interop.Kernel32.REG_TZI_FORMAT // TypeDefIndex: 2798
{
	// Fields
	internal int Bias; // 0x0
	internal int StandardBias; // 0x4
	internal int DaylightBias; // 0x8
	internal Interop.Kernel32.SYSTEMTIME StandardDate; // 0xC
	internal Interop.Kernel32.SYSTEMTIME DaylightDate; // 0x1C

	// Methods

	// RVA: 0x1575940 Offset: 0x1574B40 VA: 0x181575940
	internal void .ctor(in Interop.Kernel32.TIME_ZONE_INFORMATION tzi) { }
}

// Namespace: 
internal struct Interop.Kernel32.SYSTEMTIME // TypeDefIndex: 2799
{
	// Fields
	internal ushort Year; // 0x0
	internal ushort Month; // 0x2
	internal ushort DayOfWeek; // 0x4
	internal ushort Day; // 0x6
	internal ushort Hour; // 0x8
	internal ushort Minute; // 0xA
	internal ushort Second; // 0xC
	internal ushort Milliseconds; // 0xE

	// Methods

	// RVA: 0x1576570 Offset: 0x1575770 VA: 0x181576570
	internal bool Equals(in Interop.Kernel32.SYSTEMTIME other) { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<StandardName>e__FixedBuffer // TypeDefIndex: 2800
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<DaylightName>e__FixedBuffer // TypeDefIndex: 2801
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<TimeZoneKeyName>e__FixedBuffer // TypeDefIndex: 2802
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
internal struct Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION // TypeDefIndex: 2803
{
	// Fields
	internal int Bias; // 0x0
	[FixedBuffer(typeof(char), 32)]
	internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName; // 0x4
	internal Interop.Kernel32.SYSTEMTIME StandardDate; // 0x44
	internal int StandardBias; // 0x54
	[FixedBuffer(typeof(char), 32)]
	internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName; // 0x58
	internal Interop.Kernel32.SYSTEMTIME DaylightDate; // 0x98
	internal int DaylightBias; // 0xA8
	[FixedBuffer(typeof(char), 128)]
	internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; // 0xAC
	internal byte DynamicDaylightTimeDisabled; // 0x1AC

	// Methods

	// RVA: 0x1581B30 Offset: 0x1580D30 VA: 0x181581B30
	internal string GetTimeZoneKeyName() { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Interop.Kernel32.TIME_ZONE_INFORMATION.<StandardName>e__FixedBuffer // TypeDefIndex: 2804
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Interop.Kernel32.TIME_ZONE_INFORMATION.<DaylightName>e__FixedBuffer // TypeDefIndex: 2805
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: 
internal struct Interop.Kernel32.TIME_ZONE_INFORMATION // TypeDefIndex: 2806
{
	// Fields
	internal int Bias; // 0x0
	[FixedBuffer(typeof(char), 32)]
	internal Interop.Kernel32.TIME_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName; // 0x4
	internal Interop.Kernel32.SYSTEMTIME StandardDate; // 0x44
	internal int StandardBias; // 0x54
	[FixedBuffer(typeof(char), 32)]
	internal Interop.Kernel32.TIME_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName; // 0x58
	internal Interop.Kernel32.SYSTEMTIME DaylightDate; // 0x98
	internal int DaylightBias; // 0xA8

	// Methods

	// RVA: 0x1581B70 Offset: 0x1580D70 VA: 0x181581B70
	internal void .ctor(in Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION dtzi) { }

	// RVA: 0x1581B60 Offset: 0x1580D60 VA: 0x181581B60
	internal string GetStandardName() { }

	// RVA: 0x1581B50 Offset: 0x1580D50 VA: 0x181581B50
	internal string GetDaylightName() { }
}

// Namespace: 
internal struct Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS // TypeDefIndex: 2807
{
	// Fields
	internal uint dwSize; // 0x0
	internal uint dwCopyFlags; // 0x4
	internal IntPtr pfCancel; // 0x8
	internal IntPtr pProgressRoutine; // 0x10
	internal IntPtr pvCallbackContext; // 0x18
}

// Namespace: 
internal enum Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS // TypeDefIndex: 2808
{
	// Fields
	public uint value__; // 0x0
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileBasicInfo = 0;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileStandardInfo = 1;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileNameInfo = 2;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileRenameInfo = 3;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileDispositionInfo = 4;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileAllocationInfo = 5;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileEndOfFileInfo = 6;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileStreamInfo = 7;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileCompressionInfo = 8;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileAttributeTagInfo = 9;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileIdBothDirectoryInfo = 10;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileIdBothDirectoryRestartInfo = 11;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileIoPriorityHintInfo = 12;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileRemoteProtocolInfo = 13;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileFullDirectoryInfo = 14;
	public const Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileFullDirectoryRestartInfo = 15;
}

// Namespace: 
internal struct Interop.Kernel32.FILE_TIME // TypeDefIndex: 2809
{
	// Fields
	internal uint dwLowDateTime; // 0x0
	internal uint dwHighDateTime; // 0x4

	// Methods

	// RVA: 0x15701D0 Offset: 0x156F3D0 VA: 0x1815701D0
	internal long ToTicks() { }

	// RVA: 0x1570150 Offset: 0x156F350 VA: 0x181570150
	internal DateTimeOffset ToDateTimeOffset() { }
}

// Namespace: 
internal enum Interop.Kernel32.FINDEX_INFO_LEVELS // TypeDefIndex: 2810
{
	// Fields
	public uint value__; // 0x0
	public const Interop.Kernel32.FINDEX_INFO_LEVELS FindExInfoStandard = 0;
	public const Interop.Kernel32.FINDEX_INFO_LEVELS FindExInfoBasic = 1;
	public const Interop.Kernel32.FINDEX_INFO_LEVELS FindExInfoMaxInfoLevel = 2;
}

// Namespace: 
internal enum Interop.Kernel32.FINDEX_SEARCH_OPS // TypeDefIndex: 2811
{
	// Fields
	public uint value__; // 0x0
	public const Interop.Kernel32.FINDEX_SEARCH_OPS FindExSearchNameMatch = 0;
	public const Interop.Kernel32.FINDEX_SEARCH_OPS FindExSearchLimitToDirectories = 1;
	public const Interop.Kernel32.FINDEX_SEARCH_OPS FindExSearchLimitToDevices = 2;
	public const Interop.Kernel32.FINDEX_SEARCH_OPS FindExSearchMaxSearchOp = 3;
}

// Namespace: 
internal enum Interop.Kernel32.GET_FILEEX_INFO_LEVELS // TypeDefIndex: 2812
{
	// Fields
	public uint value__; // 0x0
	public const Interop.Kernel32.GET_FILEEX_INFO_LEVELS GetFileExInfoStandard = 0;
	public const Interop.Kernel32.GET_FILEEX_INFO_LEVELS GetFileExMaxInfoLevel = 1;
}

// Namespace: 
internal struct Interop.Kernel32.SECURITY_ATTRIBUTES // TypeDefIndex: 2813
{
	// Fields
	internal uint nLength; // 0x0
	internal IntPtr lpSecurityDescriptor; // 0x8
	internal Interop.BOOL bInheritHandle; // 0x10
}

// Namespace: 
internal struct Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA // TypeDefIndex: 2814
{
	// Fields
	internal int dwFileAttributes; // 0x0
	internal Interop.Kernel32.FILE_TIME ftCreationTime; // 0x4
	internal Interop.Kernel32.FILE_TIME ftLastAccessTime; // 0xC
	internal Interop.Kernel32.FILE_TIME ftLastWriteTime; // 0x14
	internal uint nFileSizeHigh; // 0x1C
	internal uint nFileSizeLow; // 0x20

	// Methods

	// RVA: 0x1581E70 Offset: 0x1581070 VA: 0x181581E70
	internal void PopulateFrom(ref Interop.Kernel32.WIN32_FIND_DATA findData) { }
}

// Namespace: 
internal static class Interop.Kernel32 // TypeDefIndex: 2815
{
	// Fields
	private static bool useUWPFallback; // 0x0

	// Methods

	// RVA: 0x1570660 Offset: 0x156F860 VA: 0x181570660
	internal static int CopyFileUWP(string src, string dst, bool failIfExists) { }

	// RVA: 0x1570790 Offset: 0x156F990 VA: 0x181570790
	internal static int CopyFile(string src, string dst, bool failIfExists) { }

	// RVA: 0x1571010 Offset: 0x1570210 VA: 0x181571010
	internal static extern bool DeleteVolumeMountPointPrivate(string mountPoint) { }

	// RVA: 0x15710B0 Offset: 0x15702B0 VA: 0x1815710B0
	internal static bool DeleteVolumeMountPoint(string mountPoint) { }

	// RVA: 0x15715E0 Offset: 0x15707E0 VA: 0x1815715E0
	internal static extern bool FreeLibrary(IntPtr hModule) { }

	// RVA: 0x1571C90 Offset: 0x1570E90 VA: 0x181571C90
	internal static extern SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags) { }

	// RVA: 0x1571950 Offset: 0x1570B50 VA: 0x181571950
	internal static extern bool GetFileMUIPath(uint flags, string filePath, [Out] StringBuilder language, ref int languageLength, [Out] StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator) { }

	// RVA: 0x1571670 Offset: 0x1570870 VA: 0x181571670
	internal static extern uint GetDynamicTimeZoneInformation(out Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1571C00 Offset: 0x1570E00 VA: 0x181571C00
	internal static extern uint GetTimeZoneInformation(out Interop.Kernel32.TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x15702F0 Offset: 0x156F4F0 VA: 0x1815702F0
	internal static extern bool CloseHandle(IntPtr handle) { }

	// RVA: 0x1570380 Offset: 0x156F580 VA: 0x181570380
	internal static extern int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters) { }

	// RVA: 0x1570430 Offset: 0x156F630 VA: 0x181570430
	private static extern bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

	// RVA: 0x1570520 Offset: 0x156F720 VA: 0x181570520
	internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags) { }

	// RVA: 0x1570970 Offset: 0x156FB70 VA: 0x181570970
	private static extern bool CreateDirectoryPrivate(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes) { }

	// RVA: 0x1570A10 Offset: 0x156FC10 VA: 0x181570A10
	internal static bool CreateDirectory(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes) { }

	// RVA: 0x1570B00 Offset: 0x156FD00 VA: 0x181570B00
	private static extern IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	// RVA: 0x1570D00 Offset: 0x156FF00 VA: 0x181570D00
	internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	// RVA: 0x1570BE0 Offset: 0x156FDE0 VA: 0x181570BE0
	internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	// RVA: 0x1570E90 Offset: 0x1570090 VA: 0x181570E90
	private static extern bool DeleteFilePrivate(string path) { }

	// RVA: 0x1570F30 Offset: 0x1570130 VA: 0x181570F30
	internal static bool DeleteFile(string path) { }

	// RVA: 0x15711C0 Offset: 0x15703C0 VA: 0x1815711C0
	private static extern SafeFindHandle FindFirstFileExPrivate(string lpFileName, Interop.Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData, Interop.Kernel32.FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags) { }

	// RVA: 0x15712E0 Offset: 0x15704E0 VA: 0x1815712E0
	internal static SafeFindHandle FindFirstFile(string fileName, ref Interop.Kernel32.WIN32_FIND_DATA data) { }

	// RVA: 0x1571410 Offset: 0x1570610 VA: 0x181571410
	internal static extern bool FindNextFile(SafeFindHandle hndFindFile, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData) { }

	// RVA: 0x15714F0 Offset: 0x15706F0 VA: 0x1815714F0
	private static extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, IntPtr[] arguments) { }

	// RVA: 0x1571BF0 Offset: 0x1570DF0 VA: 0x181571BF0
	internal static string GetMessage(int errorCode) { }

	// RVA: 0x1571A90 Offset: 0x1570C90 VA: 0x181571A90
	internal static string GetMessage(IntPtr moduleHandle, int errorCode) { }

	// RVA: 0x1572160 Offset: 0x1571360 VA: 0x181572160
	private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<char> buffer, out string errorMsg) { }

	// RVA: 0x1571700 Offset: 0x1570900 VA: 0x181571700
	private static extern bool GetFileAttributesExPrivate(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

	// RVA: 0x15717B0 Offset: 0x15709B0 VA: 0x1815717B0
	internal static bool GetFileAttributesEx(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

	// RVA: 0x15718A0 Offset: 0x1570AA0 VA: 0x1815718A0
	public static extern bool GetFileInformationByHandleEx(IntPtr hFile, Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize) { }

	// RVA: 0x1571D80 Offset: 0x1570F80 VA: 0x181571D80
	private static extern bool MoveFileExPrivate(string src, string dst, uint flags) { }

	// RVA: 0x1571E40 Offset: 0x1571040 VA: 0x181571E40
	internal static bool MoveFile(string src, string dst) { }

	// RVA: 0x1571F40 Offset: 0x1571140 VA: 0x181571F40
	private static extern bool RemoveDirectoryPrivate(string path) { }

	// RVA: 0x1571FE0 Offset: 0x15711E0 VA: 0x181571FE0
	internal static bool RemoveDirectory(string path) { }

	// RVA: 0x15720C0 Offset: 0x15712C0 VA: 0x1815720C0
	internal static extern bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode) { }
}

// Namespace: 
internal enum Interop.BCrypt.NTSTATUS // TypeDefIndex: 2816
{
	// Fields
	public uint value__; // 0x0
	public const Interop.BCrypt.NTSTATUS STATUS_SUCCESS = 0;
	public const Interop.BCrypt.NTSTATUS STATUS_NOT_FOUND = 3221226021;
	public const Interop.BCrypt.NTSTATUS STATUS_INVALID_PARAMETER = 3221225485;
	public const Interop.BCrypt.NTSTATUS STATUS_NO_MEMORY = 3221225495;
}

// Namespace: 
internal class Interop.BCrypt // TypeDefIndex: 2817
{
	// Methods

	// RVA: 0x156C2B0 Offset: 0x156B4B0 VA: 0x18156C2B0
	internal static extern Interop.BCrypt.NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags) { }
}

// Namespace: 
internal class Interop.User32 // TypeDefIndex: 2818
{
	// Methods

	// RVA: 0x1581D40 Offset: 0x1580F40 VA: 0x181581D40
	internal static extern int LoadString(SafeLibraryHandle handle, int id, [Out] StringBuilder buffer, int bufferLength) { }
}

// Namespace: 
internal enum Interop.BOOL // TypeDefIndex: 2819
{
	// Fields
	public int value__; // 0x0
	public const Interop.BOOL FALSE = 0;
	public const Interop.BOOL TRUE = 1;
}

// Namespace: 
internal enum Interop.BOOLEAN // TypeDefIndex: 2820
{
	// Fields
	public byte value__; // 0x0
	public const Interop.BOOLEAN FALSE = 0;
	public const Interop.BOOLEAN TRUE = 1;
}

// Namespace: 
internal struct Interop.LongFileTime // TypeDefIndex: 2821
{
	// Fields
	internal long TicksSince1601; // 0x0
}

// Namespace: 
internal struct Interop.UNICODE_STRING // TypeDefIndex: 2822
{
	// Fields
	internal ushort Length; // 0x0
	internal ushort MaximumLength; // 0x2
	internal IntPtr Buffer; // 0x8
}

// Namespace: 
public struct Interop.NtDll.FILE_FULL_DIR_INFORMATION // TypeDefIndex: 2823
{
	// Fields
	public uint NextEntryOffset; // 0x0
	public uint FileIndex; // 0x4
	public Interop.LongFileTime CreationTime; // 0x8
	public Interop.LongFileTime LastAccessTime; // 0x10
	public Interop.LongFileTime LastWriteTime; // 0x18
	public Interop.LongFileTime ChangeTime; // 0x20
	public long EndOfFile; // 0x28
	public long AllocationSize; // 0x30
	public FileAttributes FileAttributes; // 0x38
	public uint FileNameLength; // 0x3C
	public uint EaSize; // 0x40
	private char _fileName; // 0x44

	// Properties
	public ReadOnlySpan<char> FileName { get; }

	// Methods

	// RVA: 0x15700E0 Offset: 0x156F2E0 VA: 0x1815700E0
	public ReadOnlySpan<char> get_FileName() { }

	// RVA: 0x15700C0 Offset: 0x156F2C0 VA: 0x1815700C0
	public static Interop.NtDll.FILE_FULL_DIR_INFORMATION* GetNextInfo(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info) { }
}

// Namespace: 
public enum Interop.NtDll.FILE_INFORMATION_CLASS // TypeDefIndex: 2824
{
	// Fields
	public uint value__; // 0x0
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileDirectoryInformation = 1;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileFullDirectoryInformation = 2;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileBothDirectoryInformation = 3;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileBasicInformation = 4;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileStandardInformation = 5;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileInternalInformation = 6;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileEaInformation = 7;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAccessInformation = 8;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNameInformation = 9;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileRenameInformation = 10;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileLinkInformation = 11;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNamesInformation = 12;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileDispositionInformation = 13;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FilePositionInformation = 14;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileFullEaInformation = 15;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileModeInformation = 16;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAlignmentInformation = 17;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAllInformation = 18;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAllocationInformation = 19;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileEndOfFileInformation = 20;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAlternateNameInformation = 21;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileStreamInformation = 22;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FilePipeInformation = 23;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FilePipeLocalInformation = 24;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FilePipeRemoteInformation = 25;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileMailslotQueryInformation = 26;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileMailslotSetInformation = 27;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileCompressionInformation = 28;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileObjectIdInformation = 29;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileCompletionInformation = 30;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileMoveClusterInformation = 31;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileQuotaInformation = 32;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileReparsePointInformation = 33;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNetworkOpenInformation = 34;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileAttributeTagInformation = 35;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileTrackingInformation = 36;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdBothDirectoryInformation = 37;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdFullDirectoryInformation = 38;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileValidDataLengthInformation = 39;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileShortNameInformation = 40;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIoCompletionNotificationInformation = 41;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIoStatusBlockRangeInformation = 42;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIoPriorityHintInformation = 43;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileSfioReserveInformation = 44;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileSfioVolumeInformation = 45;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileHardLinkInformation = 46;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileProcessIdsUsingFileInformation = 47;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNormalizedNameInformation = 48;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNetworkPhysicalNameInformation = 49;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdGlobalTxDirectoryInformation = 50;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIsRemoteDeviceInformation = 51;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileUnusedInformation = 52;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileNumaNodeInformation = 53;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileStandardLinkInformation = 54;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileRemoteProtocolInformation = 55;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileRenameInformationBypassAccessCheck = 56;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileLinkInformationBypassAccessCheck = 57;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileVolumeNameInformation = 58;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdInformation = 59;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdExtdDirectoryInformation = 60;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileReplaceCompletionInformation = 61;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileHardLinkFullIdInformation = 62;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileIdExtdBothDirectoryInformation = 63;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileDispositionInformationEx = 64;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileRenameInformationEx = 65;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileRenameInformationExBypassAccessCheck = 66;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileDesiredStorageClassInformation = 67;
	public const Interop.NtDll.FILE_INFORMATION_CLASS FileStatInformation = 68;
}

// Namespace: 
public struct Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS // TypeDefIndex: 2825
{
	// Fields
	public uint Status; // 0x0
	public IntPtr Pointer; // 0x0
}

// Namespace: 
public struct Interop.NtDll.IO_STATUS_BLOCK // TypeDefIndex: 2826
{
	// Fields
	public Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS Status; // 0x0
	public IntPtr Information; // 0x8
}

// Namespace: 
public struct Interop.NtDll.OBJECT_ATTRIBUTES // TypeDefIndex: 2827
{
	// Fields
	public uint Length; // 0x0
	public IntPtr RootDirectory; // 0x8
	public Interop.UNICODE_STRING* ObjectName; // 0x10
	public Interop.NtDll.ObjectAttributes Attributes; // 0x18
	public void* SecurityDescriptor; // 0x20
	public void* SecurityQualityOfService; // 0x28

	// Methods

	// RVA: 0x15756B0 Offset: 0x15748B0 VA: 0x1815756B0
	public void .ctor(Interop.UNICODE_STRING* objectName, Interop.NtDll.ObjectAttributes attributes, IntPtr rootDirectory) { }
}

// Namespace: 
[Flags]
public enum Interop.NtDll.ObjectAttributes // TypeDefIndex: 2828
{
	// Fields
	public uint value__; // 0x0
	public const Interop.NtDll.ObjectAttributes OBJ_INHERIT = 2;
	public const Interop.NtDll.ObjectAttributes OBJ_PERMANENT = 16;
	public const Interop.NtDll.ObjectAttributes OBJ_EXCLUSIVE = 32;
	public const Interop.NtDll.ObjectAttributes OBJ_CASE_INSENSITIVE = 64;
	public const Interop.NtDll.ObjectAttributes OBJ_OPENIF = 128;
	public const Interop.NtDll.ObjectAttributes OBJ_OPENLINK = 256;
}

// Namespace: 
public enum Interop.NtDll.CreateDisposition // TypeDefIndex: 2829
{
	// Fields
	public uint value__; // 0x0
	public const Interop.NtDll.CreateDisposition FILE_SUPERSEDE = 0;
	public const Interop.NtDll.CreateDisposition FILE_OPEN = 1;
	public const Interop.NtDll.CreateDisposition FILE_CREATE = 2;
	public const Interop.NtDll.CreateDisposition FILE_OPEN_IF = 3;
	public const Interop.NtDll.CreateDisposition FILE_OVERWRITE = 4;
	public const Interop.NtDll.CreateDisposition FILE_OVERWRITE_IF = 5;
}

// Namespace: 
public enum Interop.NtDll.CreateOptions // TypeDefIndex: 2830
{
	// Fields
	public uint value__; // 0x0
	public const Interop.NtDll.CreateOptions FILE_DIRECTORY_FILE = 1;
	public const Interop.NtDll.CreateOptions FILE_WRITE_THROUGH = 2;
	public const Interop.NtDll.CreateOptions FILE_SEQUENTIAL_ONLY = 4;
	public const Interop.NtDll.CreateOptions FILE_NO_INTERMEDIATE_BUFFERING = 8;
	public const Interop.NtDll.CreateOptions FILE_SYNCHRONOUS_IO_ALERT = 16;
	public const Interop.NtDll.CreateOptions FILE_SYNCHRONOUS_IO_NONALERT = 32;
	public const Interop.NtDll.CreateOptions FILE_NON_DIRECTORY_FILE = 64;
	public const Interop.NtDll.CreateOptions FILE_CREATE_TREE_CONNECTION = 128;
	public const Interop.NtDll.CreateOptions FILE_COMPLETE_IF_OPLOCKED = 256;
	public const Interop.NtDll.CreateOptions FILE_NO_EA_KNOWLEDGE = 512;
	public const Interop.NtDll.CreateOptions FILE_RANDOM_ACCESS = 2048;
	public const Interop.NtDll.CreateOptions FILE_DELETE_ON_CLOSE = 4096;
	public const Interop.NtDll.CreateOptions FILE_OPEN_BY_FILE_ID = 8192;
	public const Interop.NtDll.CreateOptions FILE_OPEN_FOR_BACKUP_INTENT = 16384;
	public const Interop.NtDll.CreateOptions FILE_NO_COMPRESSION = 32768;
	public const Interop.NtDll.CreateOptions FILE_OPEN_REQUIRING_OPLOCK = 65536;
	public const Interop.NtDll.CreateOptions FILE_DISALLOW_EXCLUSIVE = 131072;
	public const Interop.NtDll.CreateOptions FILE_SESSION_AWARE = 262144;
	public const Interop.NtDll.CreateOptions FILE_RESERVE_OPFILTER = 1048576;
	public const Interop.NtDll.CreateOptions FILE_OPEN_REPARSE_POINT = 2097152;
	public const Interop.NtDll.CreateOptions FILE_OPEN_NO_RECALL = 4194304;
}

// Namespace: 
[Flags]
public enum Interop.NtDll.DesiredAccess // TypeDefIndex: 2831
{
	// Fields
	public uint value__; // 0x0
	public const Interop.NtDll.DesiredAccess FILE_READ_DATA = 1;
	public const Interop.NtDll.DesiredAccess FILE_LIST_DIRECTORY = 1;
	public const Interop.NtDll.DesiredAccess FILE_WRITE_DATA = 2;
	public const Interop.NtDll.DesiredAccess FILE_ADD_FILE = 2;
	public const Interop.NtDll.DesiredAccess FILE_APPEND_DATA = 4;
	public const Interop.NtDll.DesiredAccess FILE_ADD_SUBDIRECTORY = 4;
	public const Interop.NtDll.DesiredAccess FILE_CREATE_PIPE_INSTANCE = 4;
	public const Interop.NtDll.DesiredAccess FILE_READ_EA = 8;
	public const Interop.NtDll.DesiredAccess FILE_WRITE_EA = 16;
	public const Interop.NtDll.DesiredAccess FILE_EXECUTE = 32;
	public const Interop.NtDll.DesiredAccess FILE_TRAVERSE = 32;
	public const Interop.NtDll.DesiredAccess FILE_DELETE_CHILD = 64;
	public const Interop.NtDll.DesiredAccess FILE_READ_ATTRIBUTES = 128;
	public const Interop.NtDll.DesiredAccess FILE_WRITE_ATTRIBUTES = 256;
	public const Interop.NtDll.DesiredAccess FILE_ALL_ACCESS = 983551;
	public const Interop.NtDll.DesiredAccess DELETE = 65536;
	public const Interop.NtDll.DesiredAccess READ_CONTROL = 131072;
	public const Interop.NtDll.DesiredAccess WRITE_DAC = 262144;
	public const Interop.NtDll.DesiredAccess WRITE_OWNER = 524288;
	public const Interop.NtDll.DesiredAccess SYNCHRONIZE = 1048576;
	public const Interop.NtDll.DesiredAccess STANDARD_RIGHTS_READ = 131072;
	public const Interop.NtDll.DesiredAccess STANDARD_RIGHTS_WRITE = 131072;
	public const Interop.NtDll.DesiredAccess STANDARD_RIGHTS_EXECUTE = 131072;
	public const Interop.NtDll.DesiredAccess FILE_GENERIC_READ = 2147483648;
	public const Interop.NtDll.DesiredAccess FILE_GENERIC_WRITE = 1073741824;
	public const Interop.NtDll.DesiredAccess FILE_GENERIC_EXECUTE = 536870912;
}

// Namespace: 
internal class Interop.NtDll // TypeDefIndex: 2832
{
	// Methods

	// RVA: 0x1575430 Offset: 0x1574630 VA: 0x181575430
	private static extern int NtCreateFile(out IntPtr FileHandle, Interop.NtDll.DesiredAccess DesiredAccess, ref Interop.NtDll.OBJECT_ATTRIBUTES ObjectAttributes, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, Interop.NtDll.CreateDisposition CreateDisposition, Interop.NtDll.CreateOptions CreateOptions, void* EaBuffer, uint EaLength) { }

	// RVA: 0x15751A0 Offset: 0x15743A0 VA: 0x1815751A0
	internal static ValueTuple<int, IntPtr> CreateFile(ReadOnlySpan<char> path, IntPtr rootDirectory, Interop.NtDll.CreateDisposition createDisposition, Interop.NtDll.DesiredAccess desiredAccess = 2148532224, FileShare shareAccess = 7, FileAttributes fileAttributes = 0, Interop.NtDll.CreateOptions createOptions = 32, Interop.NtDll.ObjectAttributes objectAttributes = 64) { }

	// RVA: 0x1575530 Offset: 0x1574730 VA: 0x181575530
	public static extern int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, Interop.NtDll.FILE_INFORMATION_CLASS FileInformationClass, Interop.BOOLEAN ReturnSingleEntry, Interop.UNICODE_STRING* FileName, Interop.BOOLEAN RestartScan) { }

	// RVA: 0x1575630 Offset: 0x1574830 VA: 0x181575630
	public static extern uint RtlNtStatusToDosError(int Status) { }
}

// Namespace: 
internal class Interop.Advapi32 // TypeDefIndex: 2833
{
	// Methods

	// RVA: 0x156AA50 Offset: 0x1569C50 VA: 0x18156AA50
	internal static extern int RegCloseKey(IntPtr hKey) { }

	// RVA: 0x156AAD0 Offset: 0x1569CD0 VA: 0x18156AAD0
	internal static extern int RegCreateKeyEx(SafeRegistryHandle hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesired, ref Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs, out SafeRegistryHandle hkResult, out int lpdwDisposition) { }

	// RVA: 0x156AC80 Offset: 0x1569E80 VA: 0x18156AC80
	internal static extern int RegDeleteKeyEx(SafeRegistryHandle hKey, string lpSubKey, int samDesired, int Reserved) { }

	// RVA: 0x156AD80 Offset: 0x1569F80 VA: 0x18156AD80
	internal static extern int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, char[] lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x156AF10 Offset: 0x156A110 VA: 0x18156AF10
	internal static extern int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult) { }

	// RVA: 0x156B070 Offset: 0x156A270 VA: 0x18156B070
	internal static extern int RegQueryInfoKey(SafeRegistryHandle hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x156B4F0 Offset: 0x156A6F0 VA: 0x18156B4F0
	internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [Out] byte[] lpData, ref int lpcbData) { }

	// RVA: 0x156B290 Offset: 0x156A490 VA: 0x18156B290
	internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData) { }

	// RVA: 0x156B3C0 Offset: 0x156A5C0 VA: 0x18156B3C0
	internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData) { }

	// RVA: 0x156B690 Offset: 0x156A890 VA: 0x18156B690
	internal static extern int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [Out] char[] lpData, ref int lpcbData) { }

	// RVA: 0x156BCE0 Offset: 0x156AEE0 VA: 0x18156BCE0
	internal static extern int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, byte[] lpData, int cbData) { }

	// RVA: 0x156B840 Offset: 0x156AA40 VA: 0x18156B840
	internal static extern int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, char[] lpData, int cbData) { }

	// RVA: 0x156B970 Offset: 0x156AB70 VA: 0x18156B970
	internal static extern int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, ref int lpData, int cbData) { }

	// RVA: 0x156BBC0 Offset: 0x156ADC0 VA: 0x18156BBC0
	internal static extern int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, ref long lpData, int cbData) { }

	// RVA: 0x156BA90 Offset: 0x156AC90 VA: 0x18156BA90
	internal static extern int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, string lpData, int cbData) { }
}

// Namespace: 
internal static class Interop // TypeDefIndex: 2834
{
	// Methods

	// RVA: 0x15701E0 Offset: 0x156F3E0 VA: 0x1815701E0
	internal static void GetRandomBytes(byte* buffer, int length) { }
}

// Namespace: 
internal sealed class Locale // TypeDefIndex: 2835
{
	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static string GetText(string msg) { }

	// RVA: 0x153E840 Offset: 0x153DA40 VA: 0x18153E840
	public static string GetText(string fmt, object[] args) { }
}

// Namespace: 
internal static class SR // TypeDefIndex: 2836
{
	// Methods

	// RVA: 0x15764F0 Offset: 0x15756F0 VA: 0x1815764F0
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x1576560 Offset: 0x1575760 VA: 0x181576560
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string GetString(string name) { }

	// RVA: 0x1576400 Offset: 0x1575600 VA: 0x181576400
	internal static string Format(string resourceFormat, object[] args) { }

	// RVA: 0x1576480 Offset: 0x1575680 VA: 0x181576480
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1576380 Offset: 0x1575580 VA: 0x181576380
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x15762F0 Offset: 0x15754F0 VA: 0x1815762F0
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string GetResourceString(string str) { }
}

// Namespace: Mono
[Flags]
internal enum CertificateImportFlags // TypeDefIndex: 2837
{
	// Fields
	public int value__; // 0x0
	public const CertificateImportFlags None = 0;
	public const CertificateImportFlags DisableNativeBackend = 1;
	public const CertificateImportFlags DisableAutomaticFallback = 2;
}

// Namespace: 
private class DataConverter.PackContext // TypeDefIndex: 2838
{
	// Fields
	public byte[] buffer; // 0x10
	private int next; // 0x18
	public string description; // 0x20
	public int i; // 0x28
	public DataConverter conv; // 0x30
	public int repeat; // 0x38
	public int align; // 0x3C

	// Methods

	// RVA: 0x15756D0 Offset: 0x15748D0 VA: 0x1815756D0
	public void Add(byte[] group) { }

	// RVA: 0x15758A0 Offset: 0x1574AA0 VA: 0x1815758A0
	public byte[] Get() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class DataConverter.CopyConverter : DataConverter // TypeDefIndex: 2839
{
	// Methods

	// RVA: 0x156C770 Offset: 0x156B970 VA: 0x18156C770 Slot: 4
	public override double GetDouble(byte[] data, int index) { }

	// RVA: 0x156D050 Offset: 0x156C250 VA: 0x18156D050 Slot: 11
	public override ulong GetUInt64(byte[] data, int index) { }

	// RVA: 0x156CC90 Offset: 0x156BE90 VA: 0x18156CC90 Slot: 6
	public override long GetInt64(byte[] data, int index) { }

	// RVA: 0x156C8C0 Offset: 0x156BAC0 VA: 0x18156C8C0 Slot: 5
	public override float GetFloat(byte[] data, int index) { }

	// RVA: 0x156CB50 Offset: 0x156BD50 VA: 0x18156CB50 Slot: 7
	public override int GetInt32(byte[] data, int index) { }

	// RVA: 0x156CF10 Offset: 0x156C110 VA: 0x18156CF10 Slot: 9
	public override uint GetUInt32(byte[] data, int index) { }

	// RVA: 0x156CA10 Offset: 0x156BC10 VA: 0x18156CA10 Slot: 8
	public override short GetInt16(byte[] data, int index) { }

	// RVA: 0x156CDD0 Offset: 0x156BFD0 VA: 0x18156CDD0 Slot: 10
	public override ushort GetUInt16(byte[] data, int index) { }

	// RVA: 0x156D260 Offset: 0x156C460 VA: 0x18156D260 Slot: 12
	public override void PutBytes(byte[] dest, int destIdx, double value) { }

	// RVA: 0x156D330 Offset: 0x156C530 VA: 0x18156D330 Slot: 13
	public override void PutBytes(byte[] dest, int destIdx, float value) { }

	// RVA: 0x156D190 Offset: 0x156C390 VA: 0x18156D190 Slot: 14
	public override void PutBytes(byte[] dest, int destIdx, int value) { }

	// RVA: 0x156D190 Offset: 0x156C390 VA: 0x18156D190 Slot: 18
	public override void PutBytes(byte[] dest, int destIdx, uint value) { }

	// RVA: 0x156D4D0 Offset: 0x156C6D0 VA: 0x18156D4D0 Slot: 15
	public override void PutBytes(byte[] dest, int destIdx, long value) { }

	// RVA: 0x156D4D0 Offset: 0x156C6D0 VA: 0x18156D4D0 Slot: 19
	public override void PutBytes(byte[] dest, int destIdx, ulong value) { }

	// RVA: 0x156D400 Offset: 0x156C600 VA: 0x18156D400 Slot: 16
	public override void PutBytes(byte[] dest, int destIdx, short value) { }

	// RVA: 0x156D400 Offset: 0x156C600 VA: 0x18156D400 Slot: 17
	public override void PutBytes(byte[] dest, int destIdx, ushort value) { }

	// RVA: 0x156D5A0 Offset: 0x156C7A0 VA: 0x18156D5A0
	public void .ctor() { }
}

// Namespace: 
private class DataConverter.SwapConverter : DataConverter // TypeDefIndex: 2840
{
	// Methods

	// RVA: 0x1580B40 Offset: 0x157FD40 VA: 0x181580B40 Slot: 4
	public override double GetDouble(byte[] data, int index) { }

	// RVA: 0x1581470 Offset: 0x1580670 VA: 0x181581470 Slot: 11
	public override ulong GetUInt64(byte[] data, int index) { }

	// RVA: 0x1581080 Offset: 0x1580280 VA: 0x181581080 Slot: 6
	public override long GetInt64(byte[] data, int index) { }

	// RVA: 0x1580C90 Offset: 0x157FE90 VA: 0x181580C90 Slot: 5
	public override float GetFloat(byte[] data, int index) { }

	// RVA: 0x1580F30 Offset: 0x1580130 VA: 0x181580F30 Slot: 7
	public override int GetInt32(byte[] data, int index) { }

	// RVA: 0x1581320 Offset: 0x1580520 VA: 0x181581320 Slot: 9
	public override uint GetUInt32(byte[] data, int index) { }

	// RVA: 0x1580DE0 Offset: 0x157FFE0 VA: 0x181580DE0 Slot: 8
	public override short GetInt16(byte[] data, int index) { }

	// RVA: 0x15811D0 Offset: 0x15803D0 VA: 0x1815811D0 Slot: 10
	public override ushort GetUInt16(byte[] data, int index) { }

	// RVA: 0x15819C0 Offset: 0x1580BC0 VA: 0x1815819C0 Slot: 12
	public override void PutBytes(byte[] dest, int destIdx, double value) { }

	// RVA: 0x15818C0 Offset: 0x1580AC0 VA: 0x1815818C0 Slot: 13
	public override void PutBytes(byte[] dest, int destIdx, float value) { }

	// RVA: 0x15816A0 Offset: 0x15808A0 VA: 0x1815816A0 Slot: 14
	public override void PutBytes(byte[] dest, int destIdx, int value) { }

	// RVA: 0x15816A0 Offset: 0x15808A0 VA: 0x1815816A0 Slot: 18
	public override void PutBytes(byte[] dest, int destIdx, uint value) { }

	// RVA: 0x15817A0 Offset: 0x15809A0 VA: 0x1815817A0 Slot: 15
	public override void PutBytes(byte[] dest, int destIdx, long value) { }

	// RVA: 0x15817A0 Offset: 0x15809A0 VA: 0x1815817A0 Slot: 19
	public override void PutBytes(byte[] dest, int destIdx, ulong value) { }

	// RVA: 0x15815C0 Offset: 0x15807C0 VA: 0x1815815C0 Slot: 16
	public override void PutBytes(byte[] dest, int destIdx, short value) { }

	// RVA: 0x15815C0 Offset: 0x15807C0 VA: 0x1815815C0 Slot: 17
	public override void PutBytes(byte[] dest, int destIdx, ushort value) { }

	// RVA: 0x1581AE0 Offset: 0x1580CE0 VA: 0x181581AE0
	public void .ctor() { }
}

// Namespace: Mono
internal abstract class DataConverter // TypeDefIndex: 2841
{
	// Fields
	private static readonly DataConverter SwapConv; // 0x0
	private static readonly DataConverter CopyConv; // 0x8
	public static readonly bool IsLittleEndian; // 0x10

	// Properties
	public static DataConverter LittleEndian { get; }
	public static DataConverter BigEndian { get; }
	public static DataConverter Native { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract double GetDouble(byte[] data, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float GetFloat(byte[] data, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract long GetInt64(byte[] data, int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetInt32(byte[] data, int index);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract short GetInt16(byte[] data, int index);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract uint GetUInt32(byte[] data, int index);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract ushort GetUInt16(byte[] data, int index);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract ulong GetUInt64(byte[] data, int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void PutBytes(byte[] dest, int destIdx, double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void PutBytes(byte[] dest, int destIdx, float value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void PutBytes(byte[] dest, int destIdx, int value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void PutBytes(byte[] dest, int destIdx, long value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void PutBytes(byte[] dest, int destIdx, short value);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void PutBytes(byte[] dest, int destIdx, ushort value);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void PutBytes(byte[] dest, int destIdx, uint value);

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1 Slot: 19
	public abstract void PutBytes(byte[] dest, int destIdx, ulong value);

	// RVA: 0x156D850 Offset: 0x156CA50 VA: 0x18156D850
	public byte[] GetBytes(double value) { }

	// RVA: 0x156D7D0 Offset: 0x156C9D0 VA: 0x18156D7D0
	public byte[] GetBytes(float value) { }

	// RVA: 0x156D8D0 Offset: 0x156CAD0 VA: 0x18156D8D0
	public byte[] GetBytes(int value) { }

	// RVA: 0x156D9D0 Offset: 0x156CBD0 VA: 0x18156D9D0
	public byte[] GetBytes(long value) { }

	// RVA: 0x156D750 Offset: 0x156C950 VA: 0x18156D750
	public byte[] GetBytes(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x156DA50 Offset: 0x156CC50 VA: 0x18156DA50
	public byte[] GetBytes(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x156D6D0 Offset: 0x156C8D0 VA: 0x18156D6D0
	public byte[] GetBytes(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x156D950 Offset: 0x156CB50 VA: 0x18156D950
	public byte[] GetBytes(ulong value) { }

	// RVA: 0x156F9C0 Offset: 0x156EBC0 VA: 0x18156F9C0
	public static DataConverter get_LittleEndian() { }

	// RVA: 0x156F970 Offset: 0x156EB70 VA: 0x18156F970
	public static DataConverter get_BigEndian() { }

	// RVA: 0x156FA10 Offset: 0x156EC10 VA: 0x18156FA10
	public static DataConverter get_Native() { }

	// RVA: 0x156D5F0 Offset: 0x156C7F0 VA: 0x18156D5F0
	private static int Align(int current, int align) { }

	// RVA: 0x156E5E0 Offset: 0x156D7E0 VA: 0x18156E5E0
	public static byte[] Pack(string description, object[] args) { }

	// RVA: 0x156DAD0 Offset: 0x156CCD0 VA: 0x18156DAD0
	private static bool PackOne(DataConverter.PackContext b, object oarg) { }

	// RVA: 0x156E7B0 Offset: 0x156D9B0 VA: 0x18156E7B0
	private static bool Prepare(byte[] buffer, ref int idx, int size, ref bool align) { }

	// RVA: 0x156E870 Offset: 0x156DA70 VA: 0x18156E870
	public static IList Unpack(string description, byte[] buffer, int startIndex) { }

	// RVA: 0x156D610 Offset: 0x156C810 VA: 0x18156D610
	internal void Check(byte[] dest, int destIdx, int size) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x156F860 Offset: 0x156EA60 VA: 0x18156F860
	private static void .cctor() { }
}

// Namespace: Mono
internal static class DependencyInjector // TypeDefIndex: 2842
{
	// Fields
	private static object locker; // 0x0
	private static ISystemDependencyProvider systemDependency; // 0x8

	// Properties
	internal static ISystemDependencyProvider SystemProvider { get; }

	// Methods

	// RVA: 0x156FD70 Offset: 0x156EF70 VA: 0x18156FD70
	internal static ISystemDependencyProvider get_SystemProvider() { }

	// RVA: 0x156FBA0 Offset: 0x156EDA0 VA: 0x18156FBA0
	internal static void Register(ISystemDependencyProvider provider) { }

	// RVA: 0x156FA60 Offset: 0x156EC60 VA: 0x18156FA60
	private static ISystemDependencyProvider ReflectionLoad() { }

	// RVA: 0x156FD10 Offset: 0x156EF10 VA: 0x18156FD10
	private static void .cctor() { }
}

// Namespace: Mono
internal interface ISystemCertificateProvider // TypeDefIndex: 2843
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0);
}

// Namespace: Mono
internal interface ISystemDependencyProvider // TypeDefIndex: 2844
{
	// Properties
	public abstract ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISystemCertificateProvider get_CertificateProvider();
}

// Namespace: Mono
public static class Runtime // TypeDefIndex: 2845
{
	// Fields
	private static object dump; // 0x0

	// Methods

	// RVA: 0x1576280 Offset: 0x1575480 VA: 0x181576280
	public static string GetDisplayName() { }

	// RVA: 0x1576290 Offset: 0x1575490 VA: 0x181576290
	private static void .cctor() { }
}

// Namespace: Mono
internal struct RuntimeClassHandle // TypeDefIndex: 2846
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1575AC0 Offset: 0x1574CC0 VA: 0x181575AC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1575970 Offset: 0x1574B70 VA: 0x181575970 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1575A70 Offset: 0x1574C70 VA: 0x181575A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1575AA0 Offset: 0x1574CA0 VA: 0x181575AA0
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1575AB0 Offset: 0x1574CB0 VA: 0x181575AB0
	internal RuntimeTypeHandle GetTypeHandle() { }
}

// Namespace: Mono
internal struct RuntimeRemoteClassHandle // TypeDefIndex: 2847
{
	// Fields
	private RuntimeStructs.RemoteClass* value; // 0x0

	// Properties
	internal RuntimeClassHandle ProxyClass { get; }

	// Methods

	// RVA: 0x1576260 Offset: 0x1575460 VA: 0x181576260
	internal RuntimeClassHandle get_ProxyClass() { }
}

// Namespace: Mono
internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 2848
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1575AC0 Offset: 0x1574CC0 VA: 0x181575AC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1575E50 Offset: 0x1575050 VA: 0x181575E50
	internal Type[] get_Constraints() { }

	// RVA: 0x1575E30 Offset: 0x1575030 VA: 0x181575E30
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1575D00 Offset: 0x1574F00 VA: 0x181575D00
	private Type[] GetConstraints() { }

	// RVA: 0x1575CD0 Offset: 0x1574ED0 VA: 0x181575CD0
	private int GetConstraintsCount() { }
}

// Namespace: Mono
internal struct RuntimeEventHandle // TypeDefIndex: 2849
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr v) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Value() { }

	// RVA: 0x1575AE0 Offset: 0x1574CE0 VA: 0x181575AE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1575BE0 Offset: 0x1574DE0 VA: 0x181575BE0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
internal struct RuntimePropertyHandle // TypeDefIndex: 2850
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr v) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Value() { }

	// RVA: 0x1576160 Offset: 0x1575360 VA: 0x181576160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1575BE0 Offset: 0x1574DE0 VA: 0x181575BE0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 2851
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1575AC0 Offset: 0x1574CC0 VA: 0x181575AC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1575CB0 Offset: 0x1574EB0 VA: 0x181575CB0
	internal int get_Length() { }

	// RVA: 0x1575CA0 Offset: 0x1574EA0 VA: 0x181575CA0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1575C20 Offset: 0x1574E20 VA: 0x181575C20
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1575C10 Offset: 0x1574E10 VA: 0x181575C10
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x1575BF0 Offset: 0x1574DF0 VA: 0x181575BF0
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}

// Namespace: Mono
internal static class RuntimeMarshal // TypeDefIndex: 2852
{
	// Methods

	// RVA: 0x1576030 Offset: 0x1575230 VA: 0x181576030
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x1576020 Offset: 0x1575220 VA: 0x181576020
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x1575F90 Offset: 0x1575190 VA: 0x181575F90
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x1575E90 Offset: 0x1575090 VA: 0x181575E90
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x1575E60 Offset: 0x1575060 VA: 0x181575E60
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x1576010 Offset: 0x1575210 VA: 0x181576010
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

// Namespace: 
internal struct RuntimeStructs.RemoteClass // TypeDefIndex: 2853
{
	// Fields
	internal IntPtr default_vtable; // 0x0
	internal IntPtr xdomain_vtable; // 0x8
	internal RuntimeStructs.MonoClass* proxy_class; // 0x10
	internal IntPtr proxy_class_name; // 0x18
	internal uint interface_count; // 0x20
}

// Namespace: 
internal struct RuntimeStructs.MonoClass // TypeDefIndex: 2854
{}

// Namespace: 
internal struct RuntimeStructs.GenericParamInfo // TypeDefIndex: 2855
{
	// Fields
	internal RuntimeStructs.MonoClass* pklass; // 0x0
	internal IntPtr name; // 0x8
	internal ushort flags; // 0x10
	internal uint token; // 0x14
	internal RuntimeStructs.MonoClass** constraints; // 0x18
}

// Namespace: 
internal struct RuntimeStructs.GPtrArray // TypeDefIndex: 2856
{
	// Fields
	internal IntPtr* data; // 0x0
	internal int len; // 0x8
}

// Namespace: Mono
internal static class RuntimeStructs // TypeDefIndex: 2857
{}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 2858
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: Mono
internal struct MonoAssemblyName // TypeDefIndex: 2859
{
	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBuffer(typeof(byte), 17)]
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48
}

// Namespace: Mono
internal struct ValueTuple // TypeDefIndex: 2860
{}

// Namespace: Mono
internal struct ValueTuple<T1> // TypeDefIndex: 2861
{
	// Fields
	public T1 Item1; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2> // TypeDefIndex: 2862
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3> // TypeDefIndex: 2863
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4> // TypeDefIndex: 2864
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4, T5> // TypeDefIndex: 2865
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 2866
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1575AC0 Offset: 0x1574CC0 VA: 0x181575AC0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1575BF0 Offset: 0x1574DF0 VA: 0x181575BF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1575CB0 Offset: 0x1574EB0 VA: 0x181575CB0
	internal int get_Length() { }

	// RVA: 0x1575CA0 Offset: 0x1574EA0 VA: 0x181575CA0
	internal IntPtr get_Item(int i) { }
}

// Namespace: Mono
internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 2867
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1576610 Offset: 0x1575810 VA: 0x181576610
	private static IntPtr StringToUtf8_icall(ref string str) { }

	// RVA: 0x1576620 Offset: 0x1575820 VA: 0x181576620
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1538170 Offset: 0x1537370 VA: 0x181538170
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1576640 Offset: 0x1575840 VA: 0x181576640
	public void .ctor(string str) { }

	// RVA: 0x1576650 Offset: 0x1575850 VA: 0x181576650
	public IntPtr get_Value() { }

	// RVA: 0x15765D0 Offset: 0x15757D0 VA: 0x1815765D0 Slot: 4
	public void Dispose() { }
}

// Namespace: Mono.Xml
internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 2868
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x1576B70 Offset: 0x1575D70 VA: 0x181576B70
	public void .ctor() { }

	// RVA: 0x15766A0 Offset: 0x15758A0 VA: 0x1815766A0
	public void LoadXml(string xml) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public SecurityElement ToXml() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1576860 Offset: 0x1575A60 VA: 0x181576860 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x15767C0 Offset: 0x15759C0 VA: 0x1815767C0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1576740 Offset: 0x1575940 VA: 0x181576740 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: 
public interface SmallXmlParser.IContentHandler // TypeDefIndex: 2869
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text);
}

// Namespace: 
public interface SmallXmlParser.IAttrList // TypeDefIndex: 2870
{
	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values();
}

// Namespace: 
private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 2871
{
	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x156C1D0 Offset: 0x156B3D0 VA: 0x18156C1D0 Slot: 4
	public int get_Length() { }

	// RVA: 0x156BFB0 Offset: 0x156B1B0 VA: 0x18156BFB0 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x156C010 Offset: 0x156B210 VA: 0x18156C010 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x156C070 Offset: 0x156B270 VA: 0x18156C070 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x156C210 Offset: 0x156B410 VA: 0x18156C210 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x156C260 Offset: 0x156B460 VA: 0x18156C260 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x156BF20 Offset: 0x156B120 VA: 0x18156BF20
	internal void Clear() { }

	// RVA: 0x156BE10 Offset: 0x156B010 VA: 0x18156BE10
	internal void Add(string name, string value) { }

	// RVA: 0x156C140 Offset: 0x156B340 VA: 0x18156C140
	public void .ctor() { }
}

// Namespace: Mono.Xml
internal class SmallXmlParser // TypeDefIndex: 2872
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x157FA80 Offset: 0x157EC80 VA: 0x18157FA80
	public void .ctor() { }

	// RVA: 0x157D4B0 Offset: 0x157C6B0 VA: 0x18157D4B0
	private Exception Error(string msg) { }

	// RVA: 0x157F9A0 Offset: 0x157EBA0 VA: 0x18157F9A0
	private Exception UnexpectedEndError() { }

	// RVA: 0x157D8B0 Offset: 0x157CAB0 VA: 0x18157D8B0
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x157D9C0 Offset: 0x157CBC0 VA: 0x18157D9C0
	private bool IsWhitespace(int c) { }

	// RVA: 0x157F8B0 Offset: 0x157EAB0 VA: 0x18157F8B0
	public void SkipWhitespaces() { }

	// RVA: 0x157D7A0 Offset: 0x157C9A0 VA: 0x18157D7A0
	private void HandleWhitespaces() { }

	// RVA: 0x157F8C0 Offset: 0x157EAC0 VA: 0x18157F8C0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x157DBC0 Offset: 0x157CDC0 VA: 0x18157DBC0
	private int Peek() { }

	// RVA: 0x157F850 Offset: 0x157EA50 VA: 0x18157F850
	private int Read() { }

	// RVA: 0x157D5A0 Offset: 0x157C7A0 VA: 0x18157D5A0
	public void Expect(int c) { }

	// RVA: 0x157F710 Offset: 0x157E910 VA: 0x18157F710
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x157F270 Offset: 0x157E470 VA: 0x18157F270
	public string ReadName() { }

	// RVA: 0x157D9E0 Offset: 0x157CBE0 VA: 0x18157D9E0
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x157D410 Offset: 0x157C610 VA: 0x18157D410
	private void Cleanup() { }

	// RVA: 0x157E3E0 Offset: 0x157D5E0 VA: 0x18157E3E0
	public void ReadContent() { }

	// RVA: 0x157D6D0 Offset: 0x157C8D0 VA: 0x18157D6D0
	private void HandleBufferedContent() { }

	// RVA: 0x157E170 Offset: 0x157D370 VA: 0x18157E170
	private void ReadCharacters() { }

	// RVA: 0x157F4A0 Offset: 0x157E6A0 VA: 0x18157F4A0
	private void ReadReference() { }

	// RVA: 0x157DF80 Offset: 0x157D180 VA: 0x18157DF80
	private int ReadCharacterReference() { }

	// RVA: 0x157DBF0 Offset: 0x157CDF0 VA: 0x18157DBF0
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x157DE30 Offset: 0x157D030 VA: 0x18157DE30
	private void ReadCDATASection() { }

	// RVA: 0x157E290 Offset: 0x157D490 VA: 0x18157E290
	private void ReadComment() { }
}

// Namespace: Mono.Xml
internal class SmallXmlParserException : SystemException // TypeDefIndex: 2873
{
	// Fields
	private int line; // 0x90
	private int column; // 0x94

	// Methods

	// RVA: 0x157D350 Offset: 0x157C550 VA: 0x18157D350
	public void .ctor(string msg, int line, int column) { }
}

// Namespace: Mono.Interop
[Usage(64)]
internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2874
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor(Type t) { }
}

// Namespace: 
[Serializable]
internal struct CodePointIndexer.TableRange // TypeDefIndex: 2875
{
	// Fields
	public readonly int Start; // 0x0
	public readonly int End; // 0x4
	public readonly int Count; // 0x8
	public readonly int IndexStart; // 0xC
	public readonly int IndexEnd; // 0x10

	// Methods

	// RVA: 0x1581C90 Offset: 0x1580E90 VA: 0x181581C90
	public void .ctor(int start, int end, int indexStart) { }
}

// Namespace: Mono.Globalization.Unicode
internal class CodePointIndexer // TypeDefIndex: 2876
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x156C3E0 Offset: 0x156B5E0 VA: 0x18156C3E0
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x156C360 Offset: 0x156B560 VA: 0x18156C360
	public int ToIndex(int cp) { }
}

// Namespace: Mono.Globalization.Unicode
internal class TailoringInfo // TypeDefIndex: 2877
{
	// Fields
	public readonly int LCID; // 0x10
	public readonly int TailoringIndex; // 0x14
	public readonly int TailoringCount; // 0x18
	public readonly bool FrenchSort; // 0x1C

	// Methods

	// RVA: 0xCCD700 Offset: 0xCCC900 VA: 0x180CCD700
	public void .ctor(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }
}

// Namespace: Mono.Globalization.Unicode
internal class Contraction // TypeDefIndex: 2878
{
	// Fields
	public int Index; // 0x10
	public readonly char[] Source; // 0x18
	public readonly string Replacement; // 0x20
	public readonly byte[] SortKey; // 0x28

	// Methods

	// RVA: 0x156C720 Offset: 0x156B920 VA: 0x18156C720
	public void .ctor(int index, char[] source, string replacement, byte[] sortkey) { }
}

// Namespace: Mono.Globalization.Unicode
internal class ContractionComparer : IComparer<Contraction> // TypeDefIndex: 2879
{
	// Fields
	public static readonly ContractionComparer Instance; // 0x0

	// Methods

	// RVA: 0x156C5C0 Offset: 0x156B7C0 VA: 0x18156C5C0 Slot: 4
	public int Compare(Contraction c1, Contraction c2) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x156C6C0 Offset: 0x156B8C0 VA: 0x18156C6C0
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class Level2Map // TypeDefIndex: 2880
{
	// Fields
	public byte Source; // 0x10
	public byte Replace; // 0x11

	// Methods

	// RVA: 0x8035A0 Offset: 0x8027A0 VA: 0x1808035A0
	public void .ctor(byte source, byte replace) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 2881
{
	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1581CE0 Offset: 0x1580EE0 VA: 0x181581CE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1581CB0 Offset: 0x1580EB0 VA: 0x181581CB0
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTable // TypeDefIndex: 2882
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x15738B0 Offset: 0x1572AB0 VA: 0x1815738B0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x1572940 Offset: 0x1571B40 VA: 0x181572940
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x1574290 Offset: 0x1573490 VA: 0x181574290
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1572FE0 Offset: 0x15721E0 VA: 0x181572FE0
	public static byte Category(int cp) { }

	// RVA: 0x1574080 Offset: 0x1573280 VA: 0x181574080
	public static byte Level1(int cp) { }

	// RVA: 0x1574130 Offset: 0x1573330 VA: 0x181574130
	public static byte Level2(int cp) { }

	// RVA: 0x15741E0 Offset: 0x15733E0 VA: 0x1815741E0
	public static byte Level3(int cp) { }

	// RVA: 0x1573DC0 Offset: 0x1572FC0 VA: 0x181573DC0
	public static bool IsSortable(string s) { }

	// RVA: 0x1573F80 Offset: 0x1573180 VA: 0x181573F80
	public static bool IsSortable(int cp) { }

	// RVA: 0x1573C00 Offset: 0x1572E00 VA: 0x181573C00
	public static bool IsIgnorable(int cp) { }

	// RVA: 0x1573AD0 Offset: 0x1572CD0 VA: 0x181573AD0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x1573A80 Offset: 0x1572C80 VA: 0x181573A80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x1574550 Offset: 0x1573750 VA: 0x181574550
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1574570 Offset: 0x1573770 VA: 0x181574570
	public static int ToWidthCompat(int i) { }

	// RVA: 0x15739D0 Offset: 0x1572BD0 VA: 0x1815739D0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x1573A40 Offset: 0x1572C40 VA: 0x181573A40
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x1573A60 Offset: 0x1572C60 VA: 0x181573A60
	public static bool IsHiragana(char c) { }

	// RVA: 0x1573C50 Offset: 0x1572E50 VA: 0x181573C50
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1574CC0 Offset: 0x1573EC0 VA: 0x181574CC0
	public static bool get_IsReady() { }

	// RVA: 0x1573790 Offset: 0x1572990 VA: 0x181573790
	private static IntPtr GetResource(string name) { }

	// RVA: 0x15746F0 Offset: 0x15738F0 VA: 0x1815746F0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x1574730 Offset: 0x1573930 VA: 0x181574730
	private static void .cctor() { }

	// RVA: 0x1573620 Offset: 0x1572820 VA: 0x181573620
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1573090 Offset: 0x1572290 VA: 0x181573090
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTableUtil // TypeDefIndex: 2883
{
	// Fields
	public static readonly CodePointIndexer Ignorable; // 0x0
	public static readonly CodePointIndexer Category; // 0x8
	public static readonly CodePointIndexer Level1; // 0x10
	public static readonly CodePointIndexer Level2; // 0x18
	public static readonly CodePointIndexer Level3; // 0x20
	public static readonly CodePointIndexer CjkCHS; // 0x28
	public static readonly CodePointIndexer Cjk; // 0x30

	// Methods

	// RVA: 0x15723F0 Offset: 0x15715F0 VA: 0x1815723F0
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class NormalizationTableUtil // TypeDefIndex: 2884
{
	// Fields
	public static readonly CodePointIndexer Prop; // 0x0
	public static readonly CodePointIndexer Map; // 0x8
	public static readonly CodePointIndexer Combining; // 0x10
	public static readonly CodePointIndexer Composite; // 0x18
	public static readonly CodePointIndexer Helper; // 0x20

	// Methods

	// RVA: 0x1574E00 Offset: 0x1574000 VA: 0x181574E00
	private static void .cctor() { }

	// RVA: 0x1574D90 Offset: 0x1573F90 VA: 0x181574D90
	public static int PropIdx(int cp) { }

	// RVA: 0x1574D20 Offset: 0x1573F20 VA: 0x181574D20
	public static int MapIdx(int cp) { }
}

// Namespace: 
internal struct SimpleCollator.Context // TypeDefIndex: 2885
{
	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x156C590 Offset: 0x156B790 VA: 0x18156C590
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }
}

// Namespace: 
private struct SimpleCollator.PreviousInfo // TypeDefIndex: 2886
{
	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1575930 Offset: 0x1574B30 VA: 0x181575930
	public void .ctor(bool dummy) { }
}

// Namespace: 
private struct SimpleCollator.Escape // TypeDefIndex: 2887
{
	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14
}

// Namespace: 
private enum SimpleCollator.ExtenderType // TypeDefIndex: 2888
{
	// Fields
	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;
}

// Namespace: Mono.Globalization.Unicode
internal class SimpleCollator : ISimpleCollator // TypeDefIndex: 2889
{
	// Fields
	private static SimpleCollator invariant; // 0x0
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C

	// Methods

	// RVA: 0x157CEC0 Offset: 0x157C0C0 VA: 0x18157CEC0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x157CCA0 Offset: 0x157BEA0 VA: 0x18157CCA0
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1579140 Offset: 0x1578340 VA: 0x181579140
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x1576D20 Offset: 0x1575F20 VA: 0x181576D20
	private byte Category(int cp) { }

	// RVA: 0x157BA10 Offset: 0x157AC10 VA: 0x18157BA10
	private byte Level1(int cp) { }

	// RVA: 0x157BAB0 Offset: 0x157ACB0 VA: 0x18157BAB0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x157A7F0 Offset: 0x15799F0 VA: 0x18157A7F0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x1578FA0 Offset: 0x15781A0 VA: 0x181578FA0
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x1578CA0 Offset: 0x1577EA0 VA: 0x181578CA0
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x15799B0 Offset: 0x1578BB0 VA: 0x1815799B0
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x15797A0 Offset: 0x15789A0 VA: 0x1815797A0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1578DE0 Offset: 0x1577FE0 VA: 0x181578DE0
	private Contraction GetContraction(char c) { }

	// RVA: 0x1578F30 Offset: 0x1578130 VA: 0x181578F30
	private Contraction GetContraction(char c, Contraction[] clist) { }

	// RVA: 0x1578A00 Offset: 0x1577C00 VA: 0x181578A00
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x1579080 Offset: 0x1578280 VA: 0x181579080
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x157CE10 Offset: 0x157C010 VA: 0x18157CE10
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x15787F0 Offset: 0x15779F0 VA: 0x1815787F0
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x157A870 Offset: 0x1579A70 VA: 0x18157A870
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x157AAC0 Offset: 0x1579CC0 VA: 0x18157AAC0
	private bool IsSafe(int i) { }

	// RVA: 0x1579770 Offset: 0x1578970 VA: 0x181579770 Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x15791E0 Offset: 0x15783E0 VA: 0x1815791E0
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x1579410 Offset: 0x1578610 VA: 0x181579410
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x15781D0 Offset: 0x15773D0 VA: 0x1815781D0
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1578720 Offset: 0x1577920 VA: 0x181578720
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x1578180 Offset: 0x1577380 VA: 0x181578180 Slot: 5
	public int Compare(string s1, string s2) { }

	// RVA: 0x157CE00 Offset: 0x157C000 VA: 0x18157CE00 Slot: 6
	private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1578080 Offset: 0x1577280 VA: 0x181578080
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1576DC0 Offset: 0x1575FC0 VA: 0x181576DC0
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x1576E00 Offset: 0x1576000 VA: 0x181576E00
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1576DE0 Offset: 0x1575FE0 VA: 0x181576DE0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x157A980 Offset: 0x1579B80 VA: 0x18157A980 Slot: 7
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x157A9C0 Offset: 0x1579BC0 VA: 0x18157A9C0
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x157A900 Offset: 0x1579B00 VA: 0x18157A900
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157ABF0 Offset: 0x1579DF0 VA: 0x18157ABF0 Slot: 8
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x157AB30 Offset: 0x1579D30 VA: 0x18157AB30
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x157CB60 Offset: 0x157BD60 VA: 0x18157CB60
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x157A520 Offset: 0x1579720 VA: 0x18157A520 Slot: 9
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1579A90 Offset: 0x1578C90 VA: 0x181579A90
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x157A1A0 Offset: 0x15793A0 VA: 0x18157A1A0 Slot: 10
	public int IndexOf(string s, char target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1579B50 Offset: 0x1578D50 VA: 0x181579B50
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x1579BD0 Offset: 0x1578DD0 VA: 0x181579BD0
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1579C90 Offset: 0x1578E90 VA: 0x181579C90
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157B9D0 Offset: 0x157ABD0 VA: 0x18157B9D0 Slot: 11
	public int LastIndexOf(string s, string target, CompareOptions opt) { }

	// RVA: 0x157B820 Offset: 0x157AA20 VA: 0x18157B820 Slot: 12
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x157ACB0 Offset: 0x1579EB0 VA: 0x18157ACB0
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x157AED0 Offset: 0x157A0D0 VA: 0x18157AED0 Slot: 13
	public int LastIndexOf(string s, char target, CompareOptions opt) { }

	// RVA: 0x157B4E0 Offset: 0x157A6E0 VA: 0x18157B4E0 Slot: 14
	public int LastIndexOf(string s, char target, int start, int length, CompareOptions opt) { }

	// RVA: 0x157AE00 Offset: 0x157A000 VA: 0x18157AE00
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157AF10 Offset: 0x157A110 VA: 0x18157AF10
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157C7B0 Offset: 0x157B9B0 VA: 0x18157C7B0
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157C3E0 Offset: 0x157B5E0 VA: 0x18157C3E0
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157C990 Offset: 0x157BB90 VA: 0x18157C990
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x157C200 Offset: 0x157B400 VA: 0x18157C200
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157BC40 Offset: 0x157AE40 VA: 0x18157BC40
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x157CE30 Offset: 0x157C030 VA: 0x18157CE30
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class SortKeyBuffer // TypeDefIndex: 2890
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor(int lcid) { }

	// RVA: 0x1580B20 Offset: 0x157FD20 VA: 0x181580B20
	public void Reset() { }

	// RVA: 0x1580990 Offset: 0x157FB90 VA: 0x181580990
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x157FCA0 Offset: 0x157EEA0 VA: 0x18157FCA0
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x157FD70 Offset: 0x157EF70 VA: 0x18157FD70
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x1580100 Offset: 0x157F300 VA: 0x181580100
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x157FE40 Offset: 0x157F040 VA: 0x18157FE40
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x157FBF0 Offset: 0x157EDF0 VA: 0x18157FBF0
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x15802C0 Offset: 0x157F4C0 VA: 0x1815802C0
	public SortKey GetResultAndReset() { }

	// RVA: 0x1580270 Offset: 0x157F470 VA: 0x181580270
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x15802F0 Offset: 0x157F4F0 VA: 0x1815802F0
	public SortKey GetResult() { }
}

// Namespace: Mono.Security
[DefaultMember("Item")]
internal class ASN1 // TypeDefIndex: 2891
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x153AA30 Offset: 0x1539C30 VA: 0x18153AA30
	public void .ctor(byte tag) { }

	// RVA: 0x153AA60 Offset: 0x1539C60 VA: 0x18153AA60
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1582DD0 Offset: 0x1581FD0 VA: 0x181582DD0
	public void .ctor(byte[] data) { }

	// RVA: 0x153AAA0 Offset: 0x1539CA0 VA: 0x18153AAA0
	public int get_Count() { }

	// RVA: 0x1582F50 Offset: 0x1582150 VA: 0x181582F50
	public byte[] get_Value() { }

	// RVA: 0x1582010 Offset: 0x1581210 VA: 0x181582010
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x15823C0 Offset: 0x15815C0 VA: 0x1815823C0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x15821C0 Offset: 0x15813C0 VA: 0x1815821C0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x15820B0 Offset: 0x15812B0 VA: 0x1815820B0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1582AB0 Offset: 0x1581CB0 VA: 0x181582AB0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 2892
{
	// Methods

	// RVA: 0x1585530 Offset: 0x1584730 VA: 0x181585530
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x15855B0 Offset: 0x15847B0 VA: 0x1815855B0
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x15853D0 Offset: 0x15845D0 VA: 0x1815853D0
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x1585460 Offset: 0x1584660 VA: 0x181585460
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x153BF80 Offset: 0x153B180 VA: 0x18153BF80
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1585750 Offset: 0x1584950 VA: 0x181585750
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x15856D0 Offset: 0x15848D0 VA: 0x1815856D0
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x1585670 Offset: 0x1584870 VA: 0x181585670
	internal static double ToDouble(byte[] value, int startIndex) { }
}

// Namespace: Mono.Security.Cryptography
internal sealed class KeyBuilder // TypeDefIndex: 2893
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x15894D0 Offset: 0x15886D0 VA: 0x1815894D0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1589410 Offset: 0x1588610 VA: 0x181589410
	public static byte[] Key(int size) { }

	// RVA: 0x1589350 Offset: 0x1588550 VA: 0x181589350
	public static byte[] IV(int size) { }
}

// Namespace: Mono.Security.Cryptography
internal class KeyPairPersistence // TypeDefIndex: 2894
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x158A370 Offset: 0x1589570 VA: 0x18158A370
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x158A250 Offset: 0x1589450 VA: 0x18158A250
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x158A5C0 Offset: 0x15897C0 VA: 0x18158A5C0
	public string get_Filename() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_KeyValue() { }

	// RVA: 0x158B1D0 Offset: 0x158A3D0 VA: 0x18158B1D0
	public void set_KeyValue(string value) { }

	// RVA: 0x15899B0 Offset: 0x1588BB0 VA: 0x1815899B0
	public bool Load() { }

	// RVA: 0x1589E00 Offset: 0x1589000 VA: 0x181589E00
	public void Save() { }

	// RVA: 0x1589DE0 Offset: 0x1588FE0 VA: 0x181589DE0
	public void Remove() { }

	// RVA: 0x158ACC0 Offset: 0x1589EC0 VA: 0x18158ACC0
	private static string get_UserPath() { }

	// RVA: 0x158A770 Offset: 0x1589970 VA: 0x18158A770
	private static string get_MachinePath() { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool _CanSecure(char* root) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool _ProtectUser(char* path) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool _ProtectMachine(char* path) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool _IsUserProtected(char* path) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool _IsMachineProtected(char* path) { }

	// RVA: 0x1589540 Offset: 0x1588740 VA: 0x181589540
	private static bool CanSecure(string path) { }

	// RVA: 0x1589CE0 Offset: 0x1588EE0 VA: 0x181589CE0
	private static bool ProtectUser(string path) { }

	// RVA: 0x1589BE0 Offset: 0x1588DE0 VA: 0x181589BE0
	private static bool ProtectMachine(string path) { }

	// RVA: 0x15898B0 Offset: 0x1588AB0 VA: 0x1815898B0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x15897B0 Offset: 0x15889B0 VA: 0x1815897B0
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x10EC0D0 Offset: 0x10EB2D0 VA: 0x1810EC0D0
	private bool get_CanChange() { }

	// RVA: 0x158AC80 Offset: 0x1589E80 VA: 0x18158AC80
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x158ACA0 Offset: 0x1589EA0 VA: 0x18158ACA0
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x158A480 Offset: 0x1589680 VA: 0x18158A480
	private string get_ContainerName() { }

	// RVA: 0x15895D0 Offset: 0x15887D0 VA: 0x1815895D0
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1589680 Offset: 0x1588880 VA: 0x181589680
	private void FromXml(string xml) { }

	// RVA: 0x1589FD0 Offset: 0x15891D0 VA: 0x181589FD0
	private string ToXml() { }

	// RVA: 0x158A1F0 Offset: 0x15893F0 VA: 0x18158A1F0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD2 : HashAlgorithm // TypeDefIndex: 2895
{
	// Methods

	// RVA: 0x155FD00 Offset: 0x155EF00 VA: 0x18155FD00
	protected void .ctor() { }

	// RVA: 0x158B8C0 Offset: 0x158AAC0 VA: 0x18158B8C0
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD2Managed : MD2 // TypeDefIndex: 2896
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x158B710 Offset: 0x158A910 VA: 0x18158B710
	private byte[] Padding(int nLength) { }

	// RVA: 0x158B810 Offset: 0x158AA10 VA: 0x18158B810
	public void .ctor() { }

	// RVA: 0x155F730 Offset: 0x155E930 VA: 0x18155F730 Slot: 18
	public override void Initialize() { }

	// RVA: 0x158B1E0 Offset: 0x158A3E0 VA: 0x18158B1E0 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x158B2E0 Offset: 0x158A4E0 VA: 0x18158B2E0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x158B440 Offset: 0x158A640 VA: 0x18158B440
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x158B790 Offset: 0x158A990 VA: 0x18158B790
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD4 : HashAlgorithm // TypeDefIndex: 2897
{
	// Methods

	// RVA: 0x155FD00 Offset: 0x155EF00 VA: 0x18155FD00
	protected void .ctor() { }

	// RVA: 0x158BD90 Offset: 0x158AF90 VA: 0x18158BD90
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD4Managed : MD4 // TypeDefIndex: 2898
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x158BCC0 Offset: 0x158AEC0 VA: 0x18158BCC0
	public void .ctor() { }

	// RVA: 0x15603C0 Offset: 0x155F5C0 VA: 0x1815603C0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x155FF80 Offset: 0x155F180 VA: 0x18155FF80 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x158B9A0 Offset: 0x158ABA0 VA: 0x18158B9A0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x158BC60 Offset: 0x158AE60 VA: 0x18158BC60
	private byte[] Padding(int nLength) { }

	// RVA: 0x155FEC0 Offset: 0x155F0C0 VA: 0x18155FEC0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x155FF20 Offset: 0x155F120 VA: 0x18155FF20
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x155FF70 Offset: 0x155F170 VA: 0x18155FF70
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1560FA0 Offset: 0x15601A0 VA: 0x181560FA0
	private uint ROL(uint x, byte n) { }

	// RVA: 0x155FE80 Offset: 0x155F080 VA: 0x18155FE80
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FED0 Offset: 0x155F0D0 VA: 0x18155FED0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FF30 Offset: 0x155F130 VA: 0x18155FF30
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x155FDD0 Offset: 0x155EFD0 VA: 0x18155FDD0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x155FD20 Offset: 0x155EF20 VA: 0x18155FD20
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x1560490 Offset: 0x155F690 VA: 0x181560490
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
internal sealed class PKCS1 // TypeDefIndex: 2899
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x1562A60 Offset: 0x1561C60 VA: 0x181562A60
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x158D4E0 Offset: 0x158C6E0 VA: 0x18158D4E0
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x158D560 Offset: 0x158C760 VA: 0x18158D560
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x1563770 Offset: 0x1562970 VA: 0x181563770
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x158DAB0 Offset: 0x158CCB0 VA: 0x18158DAB0
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	// RVA: 0x158D990 Offset: 0x158CB90 VA: 0x18158D990
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x158D630 Offset: 0x158C830 VA: 0x18158D630
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x158D030 Offset: 0x158C230 VA: 0x18158D030
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x158CB40 Offset: 0x158BD40 VA: 0x18158CB40
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x158DB40 Offset: 0x158CD40 VA: 0x18158DB40
	private static void .cctor() { }
}

// Namespace: 
public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 2900
{
	// Methods

	// RVA: 0x11BAD50 Offset: 0x11B9F50 VA: 0x1811BAD50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
internal class RSAManaged : RSA // TypeDefIndex: 2901
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1590200 Offset: 0x158F400 VA: 0x181590200
	public void .ctor(int keySize) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x158EF70 Offset: 0x158E170 VA: 0x18158EF70
	private void GenerateKeyPair() { }

	// RVA: 0x1590380 Offset: 0x158F580 VA: 0x181590380 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1590430 Offset: 0x158F630 VA: 0x181590430
	public bool get_PublicOnly() { }

	// RVA: 0x158EA20 Offset: 0x158DC20 VA: 0x18158EA20 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x158EBC0 Offset: 0x158DDC0 VA: 0x18158EBC0 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x158F500 Offset: 0x158E700 VA: 0x18158F500 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x158E660 Offset: 0x158D860 VA: 0x18158E660 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x15902E0 Offset: 0x158F4E0 VA: 0x1815902E0
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x15904D0 Offset: 0x158F6D0 VA: 0x1815904D0
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x158FC20 Offset: 0x158EE20 VA: 0x18158FC20 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x158F450 Offset: 0x158E650 VA: 0x18158F450
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 2902
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x1596900 Offset: 0x1595B00 VA: 0x181596900
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x1595E50 Offset: 0x1595050 VA: 0x181595E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15961D0 Offset: 0x15953D0 VA: 0x1815961D0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1595780 Offset: 0x1594980 VA: 0x181595780 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1596780 Offset: 0x1595980 VA: 0x181596780 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x1595250 Offset: 0x1594450 VA: 0x181595250 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x15953A0 Offset: 0x15945A0 VA: 0x1815953A0 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x15960B0 Offset: 0x15952B0 VA: 0x1815960B0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x1595590 Offset: 0x1594790 VA: 0x181595590 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x15955E0 Offset: 0x15947E0 VA: 0x1815955E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1596390 Offset: 0x1595590 VA: 0x181596390 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1596C80 Offset: 0x1595E80 VA: 0x181596C80
	private bool get_KeepLastBlock() { }

	// RVA: 0x1595EC0 Offset: 0x15950C0 VA: 0x181595EC0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1596100 Offset: 0x1595300 VA: 0x181596100
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1596240 Offset: 0x1595440 VA: 0x181596240
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1595B10 Offset: 0x1594D10 VA: 0x181595B10 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x15957E0 Offset: 0x15949E0 VA: 0x1815957E0 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x15966B0 Offset: 0x15958B0 VA: 0x1815966B0 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

// Namespace: 
public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 2903
{
	// Methods

	// RVA: 0x11BAD50 Offset: 0x11B9F50 VA: 0x1811BAD50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
internal class DSAManaged : DSA // TypeDefIndex: 2904
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGenerated]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1587440 Offset: 0x1586640 VA: 0x181587440
	public void .ctor(int dwKeySize) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15869C0 Offset: 0x1585BC0 VA: 0x1815869C0
	private void Generate() { }

	// RVA: 0x1585E50 Offset: 0x1585050 VA: 0x181585E50
	private void GenerateKeyPair() { }

	// RVA: 0x15875A0 Offset: 0x15867A0 VA: 0x1815875A0
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x1586090 Offset: 0x1585290 VA: 0x181586090
	private void GenerateParams(int keyLength) { }

	// RVA: 0x15876D0 Offset: 0x15868D0 VA: 0x1815876D0
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1587640 Offset: 0x1586840 VA: 0x181587640 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1587670 Offset: 0x1586870 VA: 0x181587670
	public bool get_PublicOnly() { }

	// RVA: 0x1586DD0 Offset: 0x1585FD0 VA: 0x181586DD0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1585B00 Offset: 0x1584D00 VA: 0x181585B00 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1586A10 Offset: 0x1585C10 VA: 0x181586A10 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1586E80 Offset: 0x1586080 VA: 0x181586E80 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1585890 Offset: 0x1584A90 VA: 0x181585890 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x1587500 Offset: 0x1586700 VA: 0x181587500
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1587700 Offset: 0x1586900 VA: 0x181587700
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}

// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 2905
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
internal sealed class BigInteger.ModulusRing // TypeDefIndex: 2906
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x158CA20 Offset: 0x158BC20 VA: 0x18158CA20
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x158BE90 Offset: 0x158B090 VA: 0x18158BE90
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x158C510 Offset: 0x158B710 VA: 0x18158C510
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x158C300 Offset: 0x158B500 VA: 0x18158C300
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x158C7D0 Offset: 0x158B9D0 VA: 0x18158C7D0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x158C9A0 Offset: 0x158BBA0 VA: 0x18158C9A0
	public BigInteger Pow(uint b, BigInteger exp) { }
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 2907
{
	// Methods

	// RVA: 0x1588010 Offset: 0x1587210 VA: 0x181588010
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x155D860 Offset: 0x155CA60 VA: 0x18155D860
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x155DBE0 Offset: 0x155CDE0 VA: 0x18155DBE0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x155D220 Offset: 0x155C420 VA: 0x18155D220
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x155DFC0 Offset: 0x155D1C0 VA: 0x18155DFC0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1559180 Offset: 0x1558380 VA: 0x181559180
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x15877A0 Offset: 0x15869A0 VA: 0x1815877A0
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1588BE0 Offset: 0x1587DE0 VA: 0x181588BE0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x15879D0 Offset: 0x1586BD0 VA: 0x1815879D0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1587DF0 Offset: 0x1586FF0 VA: 0x181587DF0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x1587C90 Offset: 0x1586E90 VA: 0x181587C90
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x155DAC0 Offset: 0x155CCC0 VA: 0x18155DAC0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x155D980 Offset: 0x155CB80 VA: 0x18155D980
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1588AC0 Offset: 0x1587CC0 VA: 0x181588AC0
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1588200 Offset: 0x1587400 VA: 0x181588200
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

// Namespace: Mono.Math
internal class BigInteger // TypeDefIndex: 2908
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x15843E0 Offset: 0x15835E0 VA: 0x1815843E0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1584440 Offset: 0x1583640 VA: 0x181584440
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1584320 Offset: 0x1583520 VA: 0x181584320
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1584520 Offset: 0x1583720 VA: 0x181584520
	public void .ctor(byte[] inData) { }

	// RVA: 0x15842A0 Offset: 0x15834A0 VA: 0x1815842A0
	public void .ctor(uint ui) { }

	// RVA: 0x1584A00 Offset: 0x1583C00 VA: 0x181584A00
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1584960 Offset: 0x1583B60 VA: 0x181584960
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x15850F0 Offset: 0x15842F0 VA: 0x1815850F0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559180 Offset: 0x1558380 VA: 0x181559180
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1584B30 Offset: 0x1583D30 VA: 0x181584B30
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1584870 Offset: 0x1583A70 VA: 0x181584870
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1584DE0 Offset: 0x1583FE0 VA: 0x181584DE0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1584B60 Offset: 0x1583D60 VA: 0x181584B60
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x1584B20 Offset: 0x1583D20 VA: 0x181584B20
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x15850E0 Offset: 0x15842E0 VA: 0x1815850E0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x15847A0 Offset: 0x15839A0 VA: 0x1815847A0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1583240 Offset: 0x1582440 VA: 0x181583240
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x15831E0 Offset: 0x15823E0 VA: 0x1815831E0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1583A60 Offset: 0x1582C60 VA: 0x181583A60
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x1583C80 Offset: 0x1582E80 VA: 0x181583C80
	public void Randomize() { }

	// RVA: 0x1557680 Offset: 0x1556880 VA: 0x181557680
	public int BitCount() { }

	// RVA: 0x1583CE0 Offset: 0x1582EE0 VA: 0x181583CE0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x1583D20 Offset: 0x1582F20 VA: 0x181583D20
	public bool TestBit(int bitNum) { }

	// RVA: 0x1558110 Offset: 0x1557310 VA: 0x181558110
	public void SetBit(uint bitNum) { }

	// RVA: 0x1558160 Offset: 0x1557360 VA: 0x181558160
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x15838D0 Offset: 0x1582AD0 VA: 0x1815838D0
	public int LowestSetBit() { }

	// RVA: 0x1583420 Offset: 0x1582620 VA: 0x181583420
	public byte[] GetBytes() { }

	// RVA: 0x1558D40 Offset: 0x1557F40 VA: 0x181558D40
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x1559080 Offset: 0x1558280 VA: 0x181559080
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x15848A0 Offset: 0x1583AA0 VA: 0x1815848A0
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1584A60 Offset: 0x1583C60 VA: 0x181584A60
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558EA0 Offset: 0x15580A0 VA: 0x181558EA0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559130 Offset: 0x1558330 VA: 0x181559130
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1558E80 Offset: 0x1558080 VA: 0x181558E80
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1559110 Offset: 0x1558310 VA: 0x181559110
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1583DC0 Offset: 0x1582FC0 VA: 0x181583DC0
	public string ToString(uint radix) { }

	// RVA: 0x1583E60 Offset: 0x1583060 VA: 0x181583E60
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x15580C0 Offset: 0x15572C0 VA: 0x1815580C0
	private void Normalize() { }

	// RVA: 0x1557730 Offset: 0x1556930 VA: 0x181557730
	public void Clear() { }

	// RVA: 0x1557E20 Offset: 0x1557020 VA: 0x181557E20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1583E10 Offset: 0x1583010 VA: 0x181583E10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1582FF0 Offset: 0x15821F0 VA: 0x181582FF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x15839C0 Offset: 0x1582BC0 VA: 0x1815839C0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x15839D0 Offset: 0x1582BD0 VA: 0x1815839D0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x15835F0 Offset: 0x15827F0 VA: 0x1815835F0
	public bool IsProbablePrime() { }

	// RVA: 0x1583170 Offset: 0x1582370 VA: 0x181583170
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1557E70 Offset: 0x1557070 VA: 0x181557E70
	public void Incr2() { }

	// RVA: 0x1584220 Offset: 0x1583420 VA: 0x181584220
	private static void .cctor() { }
}

// Namespace: Mono.Math.Prime
internal enum ConfidenceFactor // TypeDefIndex: 2909
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 2910
{
	// Methods

	// RVA: 0x12068A0 Offset: 0x1205AA0 VA: 0x1812068A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTests // TypeDefIndex: 2911
{
	// Methods

	// RVA: 0x158DC90 Offset: 0x158CE90 VA: 0x18158DC90
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x158E4E0 Offset: 0x158D6E0 VA: 0x18158E4E0
	public static bool Test(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x158DE50 Offset: 0x158D050 VA: 0x18158DE50
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x158E210 Offset: 0x158D410 VA: 0x18158E210
	public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime.Generator
internal abstract class PrimeGeneratorBase // TypeDefIndex: 2912
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x158E530 Offset: 0x158D730 VA: 0x18158E530 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x156A6B0 Offset: 0x15698B0 VA: 0x18156A6B0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 2913
{
	// Methods

	// RVA: 0x15951A0 Offset: 0x15943A0 VA: 0x1815951A0 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1594DC0 Offset: 0x1593FC0 VA: 0x181594DC0 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Microsoft.Win32
public static class Registry // TypeDefIndex: 2914
{
	// Fields
	public static readonly RegistryKey CurrentUser; // 0x0
	public static readonly RegistryKey LocalMachine; // 0x8
	public static readonly RegistryKey ClassesRoot; // 0x10
	public static readonly RegistryKey Users; // 0x18
	public static readonly RegistryKey PerformanceData; // 0x20
	public static readonly RegistryKey CurrentConfig; // 0x28
	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData; // 0x30

	// Methods

	// RVA: 0x15946D0 Offset: 0x15938D0 VA: 0x1815946D0
	private static void .cctor() { }
}

// Namespace: Microsoft.Win32
public enum RegistryHive // TypeDefIndex: 2915
{
	// Fields
	public int value__; // 0x0
	public const RegistryHive ClassesRoot = -2147483648;
	public const RegistryHive CurrentUser = -2147483647;
	public const RegistryHive LocalMachine = -2147483646;
	public const RegistryHive Users = -2147483645;
	public const RegistryHive PerformanceData = -2147483644;
	public const RegistryHive CurrentConfig = -2147483643;
	public const RegistryHive DynData = -2147483642;
}

// Namespace: 
[Flags]
private enum RegistryKey.StateFlags // TypeDefIndex: 2916
{
	// Fields
	public int value__; // 0x0
	public const RegistryKey.StateFlags Dirty = 1;
	public const RegistryKey.StateFlags SystemKey = 2;
	public const RegistryKey.StateFlags WriteAccess = 4;
	public const RegistryKey.StateFlags PerfData = 8;
}

// Namespace: Microsoft.Win32
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 2917
{
	// Fields
	internal static readonly IntPtr HKEY_CLASSES_ROOT; // 0x0
	internal static readonly IntPtr HKEY_CURRENT_USER; // 0x8
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; // 0x10
	internal static readonly IntPtr HKEY_USERS; // 0x18
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; // 0x20
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; // 0x28
