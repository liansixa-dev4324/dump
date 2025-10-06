internal interface IControllerTemplateElementIdentifier_Editor : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier // TypeDefIndex: 7170
{
	// Properties
	public abstract string scriptingName { get; }
	public abstract string alternateScriptingName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_scriptingName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_alternateScriptingName();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IControllerVibrator // TypeDefIndex: 7171
{
	// Properties
	public abstract int vibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_vibrationMotorCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetVibration(int motorIndex, float motorLevel);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetVibration(int motorIndex, float motorLevel, float duration);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float GetVibration(int motorIndex);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StopVibration();
}

// Namespace: Rewired.Interfaces
public interface IUserDataStore // TypeDefIndex: 7172
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Save();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SaveControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SavePlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SaveInputBehavior(int playerId, int behaviorId);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LoadControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LoadPlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void LoadInputBehavior(int playerId, int behaviorId);
}

// Namespace: Rewired.Interfaces
public interface IControllerMapStore // TypeDefIndex: 7173
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SaveControllerMap(int playerId, ControllerMap controllerMap);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId);
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal interface ISteamControllerInternal // TypeDefIndex: 7174
{
	// Properties
	public abstract int MaxActionSourceCount { get; }
	public abstract bool IsConnected { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_MaxActionSourceCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsConnected();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetActionSetName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetDigitalActionName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetAnalogActionName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ulong GetActionSetHandle(ref string actionSetName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ulong GetDigitalActionHandle(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract ulong GetAnalogActionHandle(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetDigitalActionValue(ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetDigitalActionValue(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector2 GetAnalogActionValue(ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Vector2 GetAnalogActionValue(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool SetActiveActionSet(ulong actionSetHandle);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool SetActiveActionSet(ref string actionSetName);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ulong GetActiveActionSetHandle();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string GetActiveActionSetName();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ShowBindingPanel();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IControllerAssigner // TypeDefIndex: 7175
{
	// Properties
	public abstract bool enabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanHandleAssignment(ControllerType controllerType, Controller controller);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AssignController(ControllerType controllerType, Controller controller);
}

// Namespace: Rewired.Interfaces
public interface IPoolableObject : IDisposable // TypeDefIndex: 7176
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Return();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IAndroidFallbackDS4Helper // TypeDefIndex: 7177
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsDS4KeyMapped(int unityJoystickArrayIndex);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsDS4(string name);
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal interface IAndroidFallbackPlatformHelper // TypeDefIndex: 7178
{
	// Properties
	public abstract IAndroidFallbackDS4Helper ds4Helper { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_DeviceChangedEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_DeviceChangedEvent(Action value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IAndroidFallbackDS4Helper get_ds4Helper();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IAxisCalibrationIndexMap // TypeDefIndex: 7179
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetMappedAxisIndex(int axisIndex);
}

// Namespace: Rewired.Interfaces
public interface ILocalizedStringProvider // TypeDefIndex: 7180
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetLocalizedString(string key, out string result);
}

// Namespace: Rewired.Interfaces
public interface IGlyphProvider // TypeDefIndex: 7181
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetGlyph(string key, out object result);
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum Platform // TypeDefIndex: 7182
{
	// Fields
	public int value__; // 0x0
	public const Platform Unknown = 0;
	public const Platform Windows = 1;
	public const Platform WindowsAppStore = 2;
	public const Platform WindowsPhone8 = 3;
	public const Platform OSX = 4;
	public const Platform iOS = 5;
	public const Platform Linux = 6;
	public const Platform Android = 7;
	public const Platform Blackberry = 8;
	public const Platform Webplayer = 9;
	public const Platform Xbox360 = 10;
	public const Platform XboxOne = 11;
	public const Platform PS3 = 12;
	public const Platform PS4 = 13;
	public const Platform PSVita = 14;
	public const Platform PSMobile = 15;
	public const Platform Wii = 16;
	public const Platform Flash = 17;
	public const Platform WiiU = 18;
	public const Platform WebGL = 19;
	public const Platform Tizen = 20;
	public const Platform Xenon = 21;
	public const Platform STV = 22;
	public const Platform NACL = 23;
	public const Platform NACL_Webplayer = 24;
	public const Platform NACL_Chrome = 25;
	public const Platform SamsungTV = 26;
	public const Platform Pepper = 27;
	public const Platform tvOS = 28;
	public const Platform WindowsUWP = 29;
	public const Platform Windows81Store = 30;
	public const Platform N3DS = 31;
	public const Platform Switch = 32;
	public const Platform Ouya = 100;
	public const Platform AmazonFireTV = 101;
	public const Platform RazerForgeTV = 102;
	public const Platform GameCoreXboxOne = 104;
	public const Platform GameCoreScarlett = 105;
	public const Platform PS5 = 106;
	public const Platform Custom = 10000;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum EditorPlatform // TypeDefIndex: 7183
{
	// Fields
	public int value__; // 0x0
	public const EditorPlatform None = 0;
	public const EditorPlatform OSX = 1;
	public const EditorPlatform Windows = 2;
	public const EditorPlatform Linux = 3;
	public const EditorPlatform Unknown = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WebplayerPlatform // TypeDefIndex: 7184
{
	// Fields
	public int value__; // 0x0
	public const WebplayerPlatform None = 0;
	public const WebplayerPlatform Windows = 1;
	public const WebplayerPlatform OSX = 2;
	public const WebplayerPlatform Unknown = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum ScriptingBackend // TypeDefIndex: 7185
{
	// Fields
	public int value__; // 0x0
	public const ScriptingBackend Mono = 0;
	public const ScriptingBackend DotNet = 1;
	public const ScriptingBackend IL2CPP = 2;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum ScriptingAPILevel // TypeDefIndex: 7186
{
	// Fields
	public int value__; // 0x0
	public const ScriptingAPILevel Net20 = 0;
	public const ScriptingAPILevel Net20Subset = 1;
	public const ScriptingAPILevel Net46 = 2;
	public const ScriptingAPILevel NetStandard20 = 3;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WindowsStandalonePrimaryInputSource // TypeDefIndex: 7187
{
	// Fields
	public int value__; // 0x0
	public const WindowsStandalonePrimaryInputSource RawInput = 0;
	public const WindowsStandalonePrimaryInputSource DirectInput = 1;
	public const WindowsStandalonePrimaryInputSource XInput = 2;
	public const WindowsStandalonePrimaryInputSource WindowsGamingInput = 3;
	public const WindowsStandalonePrimaryInputSource SDL2 = 10;
	public const WindowsStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum OSXStandalonePrimaryInputSource // TypeDefIndex: 7188
{
	// Fields
	public int value__; // 0x0
	public const OSXStandalonePrimaryInputSource Native = 0;
	public const OSXStandalonePrimaryInputSource GameController = 1;
	public const OSXStandalonePrimaryInputSource SDL2 = 10;
	public const OSXStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum LinuxStandalonePrimaryInputSource // TypeDefIndex: 7189
{
	// Fields
	public int value__; // 0x0
	public const LinuxStandalonePrimaryInputSource Native = 0;
	public const LinuxStandalonePrimaryInputSource SDL2 = 10;
	public const LinuxStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WindowsUWPPrimaryInputSource // TypeDefIndex: 7190
{
	// Fields
	public int value__; // 0x0
	public const WindowsUWPPrimaryInputSource Native = 0;
	public const WindowsUWPPrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XboxOnePrimaryInputSource // TypeDefIndex: 7191
{
	// Fields
	public int value__; // 0x0
	public const XboxOnePrimaryInputSource Native = 0;
	public const XboxOnePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum GameCoreXboxOnePrimaryInputSource // TypeDefIndex: 7192
{
	// Fields
	public int value__; // 0x0
	public const GameCoreXboxOnePrimaryInputSource Native = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum GameCoreScarlettPrimaryInputSource // TypeDefIndex: 7193
{
	// Fields
	public int value__; // 0x0
	public const GameCoreScarlettPrimaryInputSource Native = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum PS4PrimaryInputSource // TypeDefIndex: 7194
{
	// Fields
	public int value__; // 0x0
	public const PS4PrimaryInputSource PS4Input = 0;
	public const PS4PrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum PS5PrimaryInputSource // TypeDefIndex: 7195
{
	// Fields
	public int value__; // 0x0
	public const PS5PrimaryInputSource PS5Input = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WebGLPrimaryInputSource // TypeDefIndex: 7196
{
	// Fields
	public int value__; // 0x0
	public const WebGLPrimaryInputSource Native = 0;
	public const WebGLPrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum DirectInputAxis // TypeDefIndex: 7197
{
	// Fields
	public int value__; // 0x0
	public const DirectInputAxis None = 0;
	public const DirectInputAxis X = 1;
	public const DirectInputAxis Y = 2;
	public const DirectInputAxis Z = 3;
	public const DirectInputAxis RotationX = 4;
	public const DirectInputAxis RotationY = 5;
	public const DirectInputAxis RotationZ = 6;
	public const DirectInputAxis Slider0 = 7;
	public const DirectInputAxis Slider1 = 8;
	public const DirectInputAxis VelocityX = 9;
	public const DirectInputAxis VelocityY = 10;
	public const DirectInputAxis VelocityZ = 11;
	public const DirectInputAxis AngularVelocityX = 12;
	public const DirectInputAxis AngularVelocityY = 13;
	public const DirectInputAxis AngularVelocityZ = 14;
	public const DirectInputAxis VelocitySlider0 = 15;
	public const DirectInputAxis VelocitySlider1 = 16;
	public const DirectInputAxis AccelerationX = 17;
	public const DirectInputAxis AccelerationY = 18;
	public const DirectInputAxis AccelerationZ = 19;
	public const DirectInputAxis AngularAccelerationX = 20;
	public const DirectInputAxis AngularAccelerationY = 21;
	public const DirectInputAxis AngularAccelerationZ = 22;
	public const DirectInputAxis AccelerationSlider0 = 23;
	public const DirectInputAxis AccelerationSlider1 = 24;
	public const DirectInputAxis ForceX = 25;
	public const DirectInputAxis ForceY = 26;
	public const DirectInputAxis ForceZ = 27;
	public const DirectInputAxis TorqueX = 28;
	public const DirectInputAxis TorqueY = 29;
	public const DirectInputAxis TorqueZ = 30;
	public const DirectInputAxis ForceSlider0 = 31;
	public const DirectInputAxis ForceSlider1 = 32;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum RawInputAxis // TypeDefIndex: 7198
{
	// Fields
	public int value__; // 0x0
	public const RawInputAxis None = 0;
	public const RawInputAxis X = 1;
	public const RawInputAxis Y = 2;
	public const RawInputAxis Z = 3;
	public const RawInputAxis RotationX = 4;
	public const RawInputAxis RotationY = 5;
	public const RawInputAxis RotationZ = 6;
	public const RawInputAxis Slider0 = 7;
	public const RawInputAxis Slider1 = 8;
	public const RawInputAxis VelocityX = 9;
	public const RawInputAxis VelocityY = 10;
	public const RawInputAxis VelocityZ = 11;
	public const RawInputAxis Other = 1000;
}

// Namespace: Rewired.Platforms
public enum XInputDeviceSubType // TypeDefIndex: 7199
{
	// Fields
	public int value__; // 0x0
	public const XInputDeviceSubType Gamepad = 1;
	public const XInputDeviceSubType Wheel = 2;
	public const XInputDeviceSubType ArcadeStick = 3;
	public const XInputDeviceSubType FlightStick = 4;
	public const XInputDeviceSubType DancePad = 5;
	public const XInputDeviceSubType Guitar = 6;
	public const XInputDeviceSubType GuitarAlternate = 7;
	public const XInputDeviceSubType DrumKit = 8;
	public const XInputDeviceSubType GuitarBass = 11;
	public const XInputDeviceSubType ArcadePad = 19;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XInputAxis // TypeDefIndex: 7200
{
	// Fields
	public int value__; // 0x0
	public const XInputAxis None = 0;
	public const XInputAxis LeftThumbX = 1;
	public const XInputAxis LeftThumbY = 2;
	public const XInputAxis RightThumbX = 3;
	public const XInputAxis RightThumbY = 4;
	public const XInputAxis LeftTrigger = 5;
	public const XInputAxis RightTrigger = 6;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XInputButton // TypeDefIndex: 7201
{
	// Fields
	public int value__; // 0x0
	public const XInputButton None = 0;
	public const XInputButton A = 1;
	public const XInputButton B = 2;
	public const XInputButton X = 3;
	public const XInputButton Y = 4;
	public const XInputButton LeftShoulder = 5;
	public const XInputButton RightShoulder = 6;
	public const XInputButton LeftThumb = 7;
	public const XInputButton RightThumb = 8;
	public const XInputButton Start = 9;
	public const XInputButton Back = 10;
	public const XInputButton DPadUp = 11;
	public const XInputButton DPadRight = 12;
	public const XInputButton DPadDown = 13;
	public const XInputButton DPadLeft = 14;
	public const XInputButton Guide = 15;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum OSXAxis // TypeDefIndex: 7202
{
	// Fields
	public int value__; // 0x0
	public const OSXAxis None = 0;
	public const OSXAxis X = 1;
	public const OSXAxis Y = 2;
	public const OSXAxis Other = 3;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum UnityAxis // TypeDefIndex: 7203
{
	// Fields
	public int value__; // 0x0
	public const UnityAxis None = 0;
	public const UnityAxis Axis0 = 1;
	public const UnityAxis Axis1 = 2;
	public const UnityAxis Axis2 = 3;
	public const UnityAxis Axis3 = 4;
	public const UnityAxis Axis4 = 5;
	public const UnityAxis Axis5 = 6;
	public const UnityAxis Axis6 = 7;
	public const UnityAxis Axis7 = 8;
	public const UnityAxis Axis8 = 9;
	public const UnityAxis Axis9 = 10;
	public const UnityAxis Axis10 = 11;
	public const UnityAxis Axis11 = 12;
	public const UnityAxis Axis12 = 13;
	public const UnityAxis Axis13 = 14;
	public const UnityAxis Axis14 = 15;
	public const UnityAxis Axis15 = 16;
	public const UnityAxis Axis16 = 17;
	public const UnityAxis Axis17 = 18;
	public const UnityAxis Axis18 = 19;
	public const UnityAxis Axis19 = 20;
	public const UnityAxis Axis20 = 21;
	public const UnityAxis Axis21 = 22;
	public const UnityAxis Axis22 = 23;
	public const UnityAxis Axis23 = 24;
	public const UnityAxis Axis24 = 25;
	public const UnityAxis Axis25 = 26;
	public const UnityAxis Axis26 = 27;
	public const UnityAxis Axis27 = 28;
	public const UnityAxis Axis28 = 29;
	public const UnityAxis Axis29 = 30;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum UnityButton // TypeDefIndex: 7204
{
	// Fields
	public int value__; // 0x0
	public const UnityButton None = 0;
	public const UnityButton Button0 = 1;
	public const UnityButton Button1 = 2;
	public const UnityButton Button2 = 3;
	public const UnityButton Button3 = 4;
	public const UnityButton Button4 = 5;
	public const UnityButton Button5 = 6;
	public const UnityButton Button6 = 7;
	public const UnityButton Button7 = 8;
	public const UnityButton Button8 = 9;
	public const UnityButton Button9 = 10;
	public const UnityButton Button10 = 11;
	public const UnityButton Button11 = 12;
	public const UnityButton Button12 = 13;
	public const UnityButton Button13 = 14;
	public const UnityButton Button14 = 15;
	public const UnityButton Button15 = 16;
	public const UnityButton Button16 = 17;
	public const UnityButton Button17 = 18;
	public const UnityButton Button18 = 19;
	public const UnityButton Button19 = 20;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLGamepadMappingType // TypeDefIndex: 7205
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLGamepadMappingType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLGamepadMappingType Standard = 1;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLWebBrowserType // TypeDefIndex: 7206
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Unknown = -1;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Chrome = 1;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Firefox = 2;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Opera = 3;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Safari = 4;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType InternetExplorer = 5;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Edge = 6;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLOSType // TypeDefIndex: 7207
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Unknown = -1;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Windows = 1;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType OSX = 2;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Linux = 3;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Android = 4;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType iOS = 5;
}

// Namespace: 
internal static class GuQDWyJVFUwSretYAAiwBIiESiYC // TypeDefIndex: 7208
{
	// Methods

	[Conditional("XBOXONE_DEBUG")]
	// RVA: 0x1917EB0 Offset: 0x19170B0 VA: 0x181917EB0
	public static void RHmorfJFuCLSGtQNywyVxdRuXhtA(object ) { }

	[Conditional("XBOXONE_DEBUG")]
	// RVA: 0x1917FF0 Offset: 0x19171F0 VA: 0x181917FF0
	public static void dYrlIdCMUnfnkjGtEqBbjRiNrJcV(object ) { }

	[Conditional("XBOXONE_DEBUG")]
	// RVA: 0x1917F50 Offset: 0x1917150 VA: 0x181917F50
	public static void UOqvVsAwFKLSpYVgAVyyzsxOwNwC(object ) { }
}

// Namespace: Rewired.Platforms.XboxOne
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IXboxOneInputSource // TypeDefIndex: 7209
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SetXboxOneVibration(ulong xboxOneJoystickId, ewzGavXKYUGTUWhQnByEcYmbLLwy vibration);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration);
}

// Namespace: 
private class XboxOneGamepadExtension.FCMvAIvATxvEIlEjqcIHawZZHsLmA : IControllerExtensionSource // TypeDefIndex: 7210
{
	// Fields
	public const int qqEgpTFOInFloJudXerUXKCMaSgR = 4;
	public ewzGavXKYUGTUWhQnByEcYmbLLwy YaduixsbYKRHpoLPDLjnpsxbTnoF; // 0x10
	public readonly IXboxOneInputSource qWcPLZlyFDuqKXKNNjDViEGkjvdyA; // 0x28
	public readonly bool rZEjpvqfMcAThrRSferCjtmjEQRab; // 0x30

	// Methods

	// RVA: 0x1917B90 Offset: 0x1916D90 VA: 0x181917B90
	public void .ctor(bool , IXboxOneInputSource , ewzGavXKYUGTUWhQnByEcYmbLLwy ) { }
}

// Namespace: Rewired.Platforms.XboxOne
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 7211
{
	// Fields
	private XboxOneGamepadExtension.FCMvAIvATxvEIlEjqcIHawZZHsLmA PKfQXIKSJfbcbHmkplZndVmtesxB; // 0x28
	private TimerAbs[] oWTvXzDCnjFljCitMACUyXVzuIZsA; // 0x30

	// Properties
	private Joystick joystick { get; }
	public int xboxOneUserId { get; }
	public ulong xboxOneJoystickId { get; }
	public int vibrationMotorCount { get; }

	// Methods

	// RVA: 0x191E2B0 Offset: 0x191D4B0 VA: 0x18191E2B0
	private Joystick xdBAgHgwaulsIOCzhOfdJrAQSDYtA() { }

	// RVA: 0x191E150 Offset: 0x191D350 VA: 0x18191E150
	public int get_xboxOneUserId() { }

	// RVA: 0x191E010 Offset: 0x191D210 VA: 0x18191E010
	public ulong get_xboxOneJoystickId() { }

	// RVA: 0x191DDC0 Offset: 0x191CFC0 VA: 0x18191DDC0
	internal void .ctor(bool , IXboxOneInputSource ) { }

	// RVA: 0x191DEF0 Offset: 0x191D0F0 VA: 0x18191DEF0
	private void .ctor(XboxOneGamepadExtension ) { }

	// RVA: 0x191DF80 Offset: 0x191D180 VA: 0x18191DF80 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x191D6C0 Offset: 0x191C8C0 VA: 0x18191D6C0 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x191D6A0 Offset: 0x191C8A0 VA: 0x18191D6A0 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x191D430 Offset: 0x191C630 VA: 0x18191D430 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x191DA70 Offset: 0x191CC70 VA: 0x18191DA70 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x191CDA0 Offset: 0x191BFA0 VA: 0x18191CDA0 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x191CEA0 Offset: 0x191C0A0 VA: 0x18191CEA0
	public float GetVibration(XboxOneGamepadMotorType motor) { }

	// RVA: 0x191DC20 Offset: 0x191CE20 VA: 0x18191DC20 Slot: 14
	public void StopVibration() { }

	// RVA: 0x191D6E0 Offset: 0x191C8E0 VA: 0x18191D6E0
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel) { }

	// RVA: 0x191D410 Offset: 0x191C610 VA: 0x18191D410
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration) { }

	// RVA: 0x191D470 Offset: 0x191C670 VA: 0x18191D470
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x191D490 Offset: 0x191C690 VA: 0x18191D490
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x191D450 Offset: 0x191C650 VA: 0x18191D450
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x191D700 Offset: 0x191C900 VA: 0x18191D700
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors) { }

	// RVA: 0x191D8C0 Offset: 0x191CAC0 VA: 0x18191D8C0
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel) { }

	// RVA: 0x191D240 Offset: 0x191C440 VA: 0x18191D240
	public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	// RVA: 0x191DD20 Offset: 0x191CF20 VA: 0x18191DD20 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x191DBA0 Offset: 0x191CDA0 VA: 0x18191DBA0 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x191CCE0 Offset: 0x191BEE0 VA: 0x18191CCE0 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x191DD20 Offset: 0x191CF20 VA: 0x18191DD20
	private void lAzNUmhqtxicPobytuVUvKsKECDL() { }

	// RVA: 0x191D140 Offset: 0x191C340 VA: 0x18191D140
	private void OgTMbPuSJaMezjTMkAjHIuHjcQSu(XboxOneGamepadMotorType , float , float ) { }

	// RVA: 0x191D000 Offset: 0x191C200 VA: 0x18191D000
	private void KvaVurKPqANBMFIaAEuPWcGcpZBv() { }
}

// Namespace: Rewired.Platforms.XboxOne
public enum XboxOneGamepadMotorType // TypeDefIndex: 7212
{
	// Fields
	public int value__; // 0x0
	public const XboxOneGamepadMotorType LeftMotor = 0;
	public const XboxOneGamepadMotorType RightMotor = 1;
	public const XboxOneGamepadMotorType LeftTriggerMotor = 2;
	public const XboxOneGamepadMotorType RightTriggerMotor = 3;
}

// Namespace: 
internal struct ewzGavXKYUGTUWhQnByEcYmbLLwy // TypeDefIndex: 7213
{
	// Fields
	public ulong mhtmnGuJCAuBmcSbcEVmJfTKFqRF; // 0x0
	public float APjFjOEcbYtZUEsbMMScpBipvCDMA; // 0x8
	public float GSpsCndzZletNiGkHJzLDmVQRLRt; // 0xC
	public float WEEVoHJUugKEQOHwfBhdtfETDXfI; // 0x10
	public float RiVfVVZdPrQdFEZRCQqGVfBOHHPkA; // 0x14

	// Methods

	// RVA: 0x1921500 Offset: 0x1920700 VA: 0x181921500
	public void yqbXiJusUElieawlEDmXpJVQvGFT() { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
private enum XboxOneInputSource.BadConnectionReason // TypeDefIndex: 7214
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const XboxOneInputSource.BadConnectionReason None = 0;
	[CustomObfuscation(rename = False)]
	public const XboxOneInputSource.BadConnectionReason GamepadNotActive = 1;
	[CustomObfuscation(rename = False)]
	public const XboxOneInputSource.BadConnectionReason InvalidName = 2;
}

// Namespace: 
private struct XboxOneInputSource.aTKmDsEGifKjlXcaJEDpFPOnOkdn // TypeDefIndex: 7215
{
	// Fields
	public uint hdJFwABBRBLULsfpPTUNRFcmXPLB; // 0x0
	public uint YWcofFDnTIUByjpqRelNLixOIQRj; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(uint , uint ) { }
}

// Namespace: 
private class XboxOneInputSource.SXNWeQifUemBeppSjlCzZaWcDZzZ : CustomInputSource.Joystick, IInputManagerHardwareJoystickMapHandler, ITryGetLocalizedName // TypeDefIndex: 7216
{
	// Fields
	private const int CMDQdGFzJRlLrErfZHLLJHBJirR = 6;
	private const int obpSlkOZGAMliMndpbbCzYkVINIv = 14;
	private const string vCaVGQcROXiUzmStxSXUlkwemwCn = "Xbox One Controller";
	private const string rdxAPOfApfnpqDGPKZHPhAybmLUaA = "Controller";
	private const int WgebrCdRzAKoiEguFslgCcIsXUrfA = 0;
	private const int dAXBMuitBmWtcXusxPZLWEAbNpWk = 1;
	private const int GJVktOGCFdtOVJWcnVzXkdPWwFcb = 2;
	private const int rjpJOGsVYmomEUpmqQIMdVlTFXNm = 3;
	private const int qcvfMMzvvzShLvfWoOPdQEwFRCjv = 4;
	private const int NnFNwyVZPBSIeYrqToFsNMoIRjQW = 5;
	private const int rtafiZVeaNUytIalbdEUGsykloue = 6;
	private const int WwzsaLzyEfJNccaCTdKycKUScxvsA = 7;
	private const int qBZWRzcHVpwoouBoDdOpObVKEQhp = 8;
	private const int UDoqRqPNzsJksjDgfIKlbbxemqByA = 9;
	private const int fRVBpKcEvblrtEUVzrWSFQdsrqTZ = 12;
	private const int kuRdcbAkHDoBifClCRBvVbcJoqaHc = 13;
	private const int YbUfWVglHilXOUTWNEjeUVIPkcak = 14;
	private const int OLnHvxBSufUysflEInVxhIJQdYrt = 15;
	private const int EJLUVxftXkndoUCycrvJTtoYRaVP = 0;
	private const int jTeUmVBmlYZCykityQinECCSvtBx = 1;
	private const int aDVIaKTSXCxGyHnjBNToBhZIkzSg = 3;
	private const int fLSbqyfbALOvAupnGTBcNsUOiCEh = 4;
	private const int USmpCpYDfaWriMPSbLXmcOlNAoNL = 8;
	private const int jvwraHEyJMOKcRzxVfJgCFaGuDMB = 9;
	private readonly IXboxOneInputSource NOproBQQdmCZareWqeKxfvgAUJcsA; // 0x90
	private int GZGzEABUCwbhEdIsxbFwFWxpZXwi; // 0x98
	private ulong BUygBcSsxrNkeDfLyiUFKtAaUGIJ; // 0xA0
	private string[] mtqAQFWUCvaOuWfzGBEPvoVnwqIX; // 0xA8
	private HardwareJoystickMap_InputManager bkpeQnrzthWzHwSMngJePMGPEpdc; // 0xB0
	private readonly LocalizedString jboOUzMaWlYmsUjlZgbTGwOzdzuCA; // 0xB8

	// Properties
	public ulong UxYhPRhnHicJeJgKTGLneyIirTrN { get; }

	// Methods

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0
	public ulong BgIGHxqcSGNqlOJYfTtatNooSPoF() { }

	// RVA: 0x191C2D0 Offset: 0x191B4D0 VA: 0x18191C2D0
	public void .ctor(IXboxOneInputSource , ulong , int , bool ) { }

	// RVA: 0x191B890 Offset: 0x191AA90 VA: 0x18191B890 Slot: 4
	public override void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x191C060 Offset: 0x191B260 VA: 0x18191C060
	public void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(ulong ) { }

	// RVA: 0x191C760 Offset: 0x191B960 VA: 0x18191C760
	private void mfRbiycvyOYRxwDEPVdRTHWIHeRlA() { }

	// RVA: 0x191C740 Offset: 0x191B940 VA: 0x18191C740
	private bool aSOUYCoXSrSoBcoARHonTSxYelNA(int ) { }

	// RVA: 0x191B730 Offset: 0x191A930 VA: 0x18191B730
	private void HjtqXxkZXOaqBpuUsPTJdyMjFEuU() { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00 Slot: 12
	private void NDkyIAhOojWQQDujlgSlnlQMdgBc(HardwareJoystickMap_InputManager ) { }

	// RVA: 0x191BF30 Offset: 0x191B130 VA: 0x18191BF30 Slot: 13
	private bool XaocBHbPcSQOhcKkpQOjWpLROKQnA(out string ) { }
}

// Namespace: Rewired.Platforms.XboxOne
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource // TypeDefIndex: 7217
{
	// Fields
	private const int JlMQDYVkODHcSRoMVtChTATGapac = 8;
	private readonly bool DzRdwaCjMKOeYXXRtYawwePnAsSb; // 0x58
	private bool sAbTIezJsSqwqBAMwLASVwMlXDqf; // 0x59
	private Queue<XboxOneInputSource.aTKmDsEGifKjlXcaJEDpFPOnOkdn> JGfTPEBjPYkSKanJfmzdKowDFKYL; // 0x60
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x68

	// Properties
	public override bool isReady { get; }

	// Methods

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 12
	public override bool get_isReady() { }

	// RVA: 0x191EEF0 Offset: 0x191E0F0 VA: 0x18191EEF0
	public void .ctor() { }

	// RVA: 0x191EC20 Offset: 0x191DE20 VA: 0x18191EC20 Slot: 13
	public override void Update() { }

	// RVA: 0x191EA80 Offset: 0x191DC80 VA: 0x18191EA80
	private void TnGEXZBHkvBKZaGnGkrjVXjfTBafB(uint , bool ) { }

	// RVA: 0x191F350 Offset: 0x191E550 VA: 0x18191F350
	private void lLGDSUoYjUyhtFAwwhSCEeXVvwJq(uint , bool ) { }

	// RVA: 0x191E610 Offset: 0x191D810 VA: 0x18191E610
	private void KlpkELaNguVxpghlUYeAVVJUybiJ() { }

	// RVA: 0x191F110 Offset: 0x191E310 VA: 0x18191F110
	private bool fsFVmXMDIGDBOejffFxrajQdxXvwb(uint , bool , out XboxOneInputSource.BadConnectionReason ) { }

	// RVA: 0x191F4D0 Offset: 0x191E6D0 VA: 0x18191F4D0
	private void zBSaCcJVJyJZGTFPGFnwVIfOfNMy() { }

	// RVA: 0x191E500 Offset: 0x191D700 VA: 0x18191E500 Slot: 14
	public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId) { }

	// RVA: 0x191E780 Offset: 0x191D980 VA: 0x18191E780 Slot: 16
	public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	// RVA: 0x191E910 Offset: 0x191DB10 VA: 0x18191E910 Slot: 15
	public bool SetXboxOneVibration(ulong xboxOneJoystickId, ewzGavXKYUGTUWhQnByEcYmbLLwy vibration) { }

	// RVA: 0x191E2F0 Offset: 0x191D4F0 VA: 0x18191E2F0 Slot: 10
	public override void Dispose() { }

	// RVA: 0x191E490 Offset: 0x191D690 VA: 0x18191E490 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x191E3B0 Offset: 0x191D5B0 VA: 0x18191E3B0 Slot: 11
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
public abstract class CustomInputSource.Controller // TypeDefIndex: 7218
{
	// Fields
	protected bool _isConnected; // 0x10
	protected string _deviceName; // 0x18
	protected string _customName; // 0x20
	protected object _customIdentifier; // 0x28
	protected Guid _persistentGuid; // 0x30
	private Action<bool> bTBOqRrZKGUoWqeqrOhFSUgCyPfc; // 0x40

	// Properties
	public string customName { get; }
	public bool isConnected { get; set; }
	public string deviceName { get; }
	public object customIdentifier { get; set; }
	public Guid deviceInstanceGuid { get; set; }

	// Methods

	// RVA: 0x1912D90 Offset: 0x1911F90 VA: 0x181912D90
	public void add_ConnectedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x1912E40 Offset: 0x1912040 VA: 0x181912E40
	public void remove_ConnectedStateChangedEvent(Action<bool> value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_customName() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_isConnected() { }

	// RVA: 0x1912EF0 Offset: 0x19120F0 VA: 0x181912EF0
	public void set_isConnected(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_deviceName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public object get_customIdentifier() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_customIdentifier(object value) { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x160E020 Offset: 0x160D220 VA: 0x18160E020
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	protected void .ctor(string ) { }

	// RVA: 0x1912D70 Offset: 0x1911F70 VA: 0x181912D70
	public void Disconnect() { }

	// RVA: 0x1912D50 Offset: 0x1911F50 VA: 0x181912D50
	public void Connect() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update();
}

// Namespace: 
public abstract class CustomInputSource.Joystick : CustomInputSource.Controller // TypeDefIndex: 7219
{
	// Fields
	private Nullable<long> UGKEOwoLdQNDqVeGGpBYNDCCdCUM; // 0x48
	private int ROUaKuFxYbGXzctUkcpThwDvBnzEb; // 0x58
	private readonly CustomInputSource.Axis[] GpfcrdjIEBMflsTvZtwFtrSGTOKrA; // 0x60
	private readonly CustomInputSource.Button[] qCcRvKGVZggEJuRPOApCjfkkjLFN; // 0x68
	private readonly ReadOnlyCollection<CustomInputSource.Axis> CMMFvHSNZxTZuxfCKWOPgGJPfURu; // 0x70
	private readonly ReadOnlyCollection<CustomInputSource.Button> JMaJHTQMXSupUDqsRolXfXMLWXne; // 0x78
	private bool sdzISjHiUOikyuyAgPwgWzGuiBDi; // 0x80
	private Controller.Extension UkNVbtIvrLthdNEqtaxlGsUzkdJNA; // 0x88

	// Properties
	public Nullable<long> systemId { get; set; }
	public int unityId { get; set; }
	public IList<CustomInputSource.Axis> Axes { get; }
	public IList<CustomInputSource.Button> Buttons { get; }
	public bool supportsVibration { get; set; }
	public Controller.Extension extension { get; set; }
	public int buttonCount { get; }
	public int axisCount { get; }

	// Methods

	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0
	public Nullable<long> get_systemId() { }

	// RVA: 0x528FF0 Offset: 0x5281F0 VA: 0x180528FF0
	protected void set_systemId(Nullable<long> value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public int get_unityId() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	protected void set_unityId(int value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public IList<CustomInputSource.Axis> get_Axes() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public IList<CustomInputSource.Button> get_Buttons() { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_supportsVibration() { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	public void set_supportsVibration(bool value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public Controller.Extension get_extension() { }

	// RVA: 0x1918F30 Offset: 0x1918130 VA: 0x181918F30
	public void set_extension(Controller.Extension value) { }

	// RVA: 0x1918F10 Offset: 0x1918110 VA: 0x181918F10
	public int get_buttonCount() { }

	// RVA: 0x1918EF0 Offset: 0x19180F0 VA: 0x181918EF0
	public int get_axisCount() { }

	// RVA: 0x1918D20 Offset: 0x1917F20 VA: 0x181918D20
	protected void .ctor(string , long , int , int ) { }

	// RVA: 0x1918B00 Offset: 0x1917D00 VA: 0x181918B00
	public void .ctor(string , Nullable<long> , int , int , int ) { }

	// RVA: 0x1918930 Offset: 0x1917B30 VA: 0x181918930 Slot: 5
	public virtual float GetAxisValue(int index) { }

	// RVA: 0x19189D0 Offset: 0x1917BD0 VA: 0x1819189D0 Slot: 6
	public virtual bool GetButtonValue(int index) { }

	// RVA: 0x1918980 Offset: 0x1917B80 VA: 0x181918980 Slot: 7
	public virtual float GetButtonFloatValue(int index) { }

	// RVA: 0x1918A20 Offset: 0x1917C20 VA: 0x181918A20 Slot: 8
	public virtual void SetAxisValue(int index, float value) { }

	// RVA: 0x1918AA0 Offset: 0x1917CA0 VA: 0x181918AA0 Slot: 9
	public virtual void SetButtonValue(int index, bool value) { }

	// RVA: 0x1918A60 Offset: 0x1917C60 VA: 0x181918A60 Slot: 10
	public virtual void SetButtonFloatValue(int index, float value) { }

	// RVA: 0x19188B0 Offset: 0x1917AB0 VA: 0x1819188B0
	internal void DElqjWfruhkVcWIZvIYiVnaKhmNQ(int , out bool , out float ) { }

	// RVA: 0x1918E80 Offset: 0x1918080 VA: 0x181918E80 Slot: 11
	internal virtual void fyxSqLTUAfQlyVzrorhlTCMtUsOM() { }
}

// Namespace: 
public abstract class CustomInputSource.Element // TypeDefIndex: 7220
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
public sealed class CustomInputSource.Axis : CustomInputSource.Element // TypeDefIndex: 7221
{
	// Fields
	public float value; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public sealed class CustomInputSource.Button : CustomInputSource.Element // TypeDefIndex: 7222
{
	// Fields
	[Obsolete("Deprecated. Use boolValue instead.", False)]
	public bool value; // 0x10
	private float ktqCXYzxklTtsQvLEClJNQrGieoo; // 0x14
	private bool DQqKwrBXfIprFFVcHNGPfRtmARMD; // 0x18

	// Properties
	public bool boolValue { get; set; }
	public float floatValue { get; set; }
	internal bool uxgxClsPVVjpKeSqbNZzEmAcORK { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_boolValue() { }

	// RVA: 0x190A4F0 Offset: 0x19096F0 VA: 0x18190A4F0
	public void set_boolValue(bool value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_floatValue() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_floatValue(float value) { }

	// RVA: 0x190A4E0 Offset: 0x19096E0 VA: 0x18190A4E0
	internal bool LHodUPtmczeXuxaWnkhwItpXLlju() { }

	// RVA: 0x6C3D60 Offset: 0x6C2F60 VA: 0x1806C3D60
	internal void IIOVacyykoNDVJqhaeULdXVASvfaA() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomInputSource : IDisposable // TypeDefIndex: 7223
{
	// Fields
	private readonly InputSource KmEQsrUgqWPtoOSszGPFpLvKhrOC; // 0x10
	private readonly List<CustomInputSource.Joystick> LpmxDlfvfpIhUgmLdpCPcCMASIzy; // 0x18
	private readonly ReadOnlyCollection<CustomInputSource.Joystick> meXfNlDZcbpTYJwYUruQcpWJhDAG; // 0x20
	private bool uqeZkmDIVIFuiwhXHZxcWRWatlIN; // 0x28
	private IUnifiedKeyboardSource PxnmiCulSCddfaNLwzXVfqlmJbudb; // 0x30
	private IUnifiedMouseSource rCpvHZHkJWdeAtyCGfiaHbnzvtyM; // 0x38
	[CompilerGenerated]
	private Action PlEMhgJzDBteqfNyUaRNPatwGKOm; // 0x40
	[CompilerGenerated]
	private Action gLWWWWONKFjItehHZlDSgCnBSqqA; // 0x48
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x50

	// Properties
	public bool useApproximateMatching { get; set; }
	internal InputSource NOproBQQdmCZareWqeKxfvgAUJcsA { get; }
	public abstract bool isReady { get; }

	// Methods

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_useApproximateMatching() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	protected void set_useApproximateMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19152A0 Offset: 0x19144A0 VA: 0x1819152A0
	private void QcTaLQlakiGJPDrTFuFsNhhxsrDOA(Action ) { }

	[CompilerGenerated]
	// RVA: 0x1915670 Offset: 0x1914870 VA: 0x181915670
	private void UMLwrhwnGShqiBdSrLrpntthHurUA(Action ) { }

	[CompilerGenerated]
	// RVA: 0x1915420 Offset: 0x1914620 VA: 0x181915420
	private void jtsEUslpYwMcDyBNjkdABqTxXJQl(Action ) { }

	[CompilerGenerated]
	// RVA: 0x1915380 Offset: 0x1914580 VA: 0x181915380
	private void OoQBqQOdYAffoSpIjKKsdfDGSxPv(Action ) { }

	// RVA: 0x19152A0 Offset: 0x19144A0 VA: 0x1819152A0
	internal void GilndSJiURXFZhgmSHVgGkhnBfHbA(Action ) { }

	// RVA: 0x1915670 Offset: 0x1914870 VA: 0x181915670
	internal void hVaFdXgjMgHdPWkgwnDrlkJxTKXq(Action ) { }

	// RVA: 0x1915420 Offset: 0x1914620 VA: 0x181915420
	internal void QAEhvXuVjSLoSgmpccgzcskCoTOO(Action ) { }

	// RVA: 0x1915380 Offset: 0x1914580 VA: 0x181915380
	internal void wbkwbnTfkvyhzIvcLkiuQiqVBlzj(Action ) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal InputSource xQCEtkOJAuvQEFNXbUICemThjoBo() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal IUnifiedKeyboardSource enKKSpGTYDIJWLgRxbWFOnMggGph() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal IUnifiedMouseSource GhMbdiTrkJqDEqgZTuSaLlUdYGow() { }

	// RVA: 0x1915750 Offset: 0x1914950 VA: 0x181915750
	public void .ctor(int ) { }

	// RVA: 0x1915710 Offset: 0x1914910 VA: 0x181915710
	internal void .ctor(int , IUnifiedKeyboardSource , IUnifiedMouseSource ) { }

	// RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600 Slot: 5
	internal virtual void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void OnInitialize() { }

	// RVA: 0x1914EE0 Offset: 0x19140E0 VA: 0x181914EE0
	public void AddJoystick(CustomInputSource.Joystick joystick) { }

	// RVA: 0x19154C0 Offset: 0x19146C0 VA: 0x1819154C0
	public void RemoveJoystick(CustomInputSource.Joystick joystick) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IList<CustomInputSource.Joystick> GetJoysticks() { }

	// RVA: 0x1915340 Offset: 0x1914540 VA: 0x181915340 Slot: 7
	protected virtual void OnJoystickConnected() { }

	// RVA: 0x1915360 Offset: 0x1914560 VA: 0x181915360 Slot: 8
	protected virtual void OnJoystickDisconnected() { }

	// RVA: 0x1915900 Offset: 0x1914B00 VA: 0x181915900
	private void jWtjumNPKocIjgHDMXAlflamuZsAA(bool ) { }

	// RVA: 0x1915930 Offset: 0x1914B30 VA: 0x181915930
	internal CustomInputSource.Joystick[] jeXUscHPcLoUMsXPborKQwcbLDUE() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	internal virtual void qGlLtDwEmupMNDqnBPyHiEbSNmzx() { }

	// RVA: 0x19151C0 Offset: 0x19143C0 VA: 0x1819151C0 Slot: 10
	public virtual void Dispose() { }

	// RVA: 0x1915230 Offset: 0x1914430 VA: 0x181915230 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1915090 Offset: 0x1914290 VA: 0x181915090 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_isReady();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Update();
}

// Namespace: Rewired.Platforms.Custom
public sealed class CustomPlatformInitOptions // TypeDefIndex: 7224
{
	// Fields
	internal const int eXijAtNfmeCOviMADFfyFSenjsJZ = -1;
	public int platformId; // 0x10
	public string platformIdentifierString; // 0x18
	public CustomInputSource inputSource; // 0x20
	public IHardwareJoystickMapCustomPlatformMapProvider hardwareJoystickMapCustomPlatformMapProvider; // 0x28
	public CustomPlatformConfigVars configVars; // 0x30

	// Methods

	// RVA: 0x1915A70 Offset: 0x1914C70 VA: 0x181915A70
	public void .ctor() { }

	// RVA: 0x1915AE0 Offset: 0x1914CE0 VA: 0x181915AE0
	public void .ctor(CustomPlatformInitOptions ) { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class CustomPlatformConfigVars : ConfigVars.PlatformVars // TypeDefIndex: 7225
{
	// Fields
	public bool useNativeKeyboard; // 0x18
	public bool useNativeMouse; // 0x19

	// Methods

	// RVA: 0x1915A50 Offset: 0x1914C50 VA: 0x181915A50
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
public interface ICustomPlatformInitializer // TypeDefIndex: 7226
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CustomPlatformInitOptions GetCustomPlatformInitOptions();
}

// Namespace: 
public abstract class CustomPlatformInputSource.Joystick : CustomInputSource.Joystick // TypeDefIndex: 7227
{
	// Methods

	// RVA: 0x1918DD0 Offset: 0x1917FD0 VA: 0x181918DD0
	protected void .ctor(string , long , int , int ) { }
}

// Namespace: 
public sealed class CustomPlatformInputSource.InitOptions // TypeDefIndex: 7228
{
	// Fields
	public CustomPlatformUnifiedKeyboardSource unifiedKeyboardSource; // 0x10
	public CustomPlatformUnifiedMouseSource unifiedMouseSource; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformInputSource : CustomInputSource // TypeDefIndex: 7229
{
	// Fields
	private readonly CustomPlatformConfigVars oLjrLLpdkfKHAYReLCJwneJPnMGG; // 0x58
	private readonly bool zlzSKXzrbgWsHIegVBZWiWrdImrlA; // 0x60
	private readonly bool nprydCJhctwDTcJAHrGzApDgzhBb; // 0x61
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x62

	// Methods

	// RVA: 0x1915E10 Offset: 0x1915010 VA: 0x181915E10
	protected void .ctor(CustomPlatformConfigVars , CustomPlatformInputSource.InitOptions ) { }

	// RVA: 0x1915C00 Offset: 0x1914E00 VA: 0x181915C00 Slot: 5
	internal override void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x1915FC0 Offset: 0x19151C0 VA: 0x181915FC0 Slot: 9
	internal override void qGlLtDwEmupMNDqnBPyHiEbSNmzx() { }

	// RVA: 0x1915BE0 Offset: 0x1914DE0 VA: 0x181915BE0 Slot: 11
	protected override void Dispose(bool disposing) { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedControllerSource : IDisposable // TypeDefIndex: 7230
{
	// Fields
	private readonly int CMDQdGFzJRlLrErfZHLLJHBJirR; // 0x10
	private readonly int obpSlkOZGAMliMndpbbCzYkVINIv; // 0x14
	private readonly bool[] AcHLuYOzXQNKrrMisukEDhcSTvbg; // 0x18
	private readonly bool[] bfXaQtcdyIORtGMIcXcIzjaVBslTA; // 0x20
	private readonly float[] kZCMRiuKzVOSvFpCWdFjhTBkEUqfb; // 0x28
	private bool ZSNoMsrnLVXHmBmVdWRQrBaWselT; // 0x30

	// Properties
	public int axisCount { get; }
	public int buttonCount { get; }
	public virtual Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x19167F0 Offset: 0x19159F0 VA: 0x1819167F0
	public void .ctor(int , int ) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void Update();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal virtual void qGlLtDwEmupMNDqnBPyHiEbSNmzx() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_axisCount() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_buttonCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual Controller.Extension get_controllerExtension() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void OnInitialize() { }

	// RVA: 0x1916190 Offset: 0x1915390 VA: 0x181916190 Slot: 9
	protected virtual void Clear() { }

	// RVA: 0x19161F0 Offset: 0x19153F0 VA: 0x1819161F0
	protected float GetAxisValue(int index) { }

	// RVA: 0x1916230 Offset: 0x1915430 VA: 0x181916230
	protected bool GetButtonValue(int index) { }

	// RVA: 0x19162A0 Offset: 0x19154A0 VA: 0x1819162A0
	protected void SetAxisValue(int index, float value) { }

	// RVA: 0x19162E0 Offset: 0x19154E0 VA: 0x1819162E0
	protected void SetAxisValues(IList<float> values) { }

	// RVA: 0x19164B0 Offset: 0x19156B0 VA: 0x1819164B0
	protected void SetButtonValue(int index, bool value) { }

	// RVA: 0x1916520 Offset: 0x1915720 VA: 0x181916520
	protected void SetButtonValues(IList<bool> values) { }

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	internal void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00
	internal void AELHjEDvGWhnRRRiWlhHzYmTkHpI() { }

	// RVA: 0x19168A0 Offset: 0x1915AA0 VA: 0x1819168A0
	internal void iNqIxAlfAFnMLTYmylpkVxGMWGAD(ControllerDataUpdater ) { }

	// RVA: 0x1916270 Offset: 0x1915470 VA: 0x181916270
	private void IIOVacyykoNDVJqhaeULdXVASvfaA() { }

	// RVA: 0x19161E0 Offset: 0x19153E0 VA: 0x1819161E0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1916780 Offset: 0x1915980 VA: 0x181916780 Slot: 4
	private void System.IDisposable.Dispose() { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedMouseSource : CustomPlatformUnifiedControllerSource // TypeDefIndex: 7231
{
	// Properties
	public abstract Vector2 mousePosition { get; }

	// Methods

	// RVA: 0x1916EC0 Offset: 0x19160C0 VA: 0x181916EC0
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Vector2 get_mousePosition();
}

// Namespace: 
public struct CustomPlatformUnifiedKeyboardSource.KeyPropertyMap.Key // TypeDefIndex: 7232
{
	// Fields
	public KeyboardKeyCode keyCode; // 0x0
	public string label; // 0x8
}

// Namespace: 
public sealed class CustomPlatformUnifiedKeyboardSource.KeyPropertyMap // TypeDefIndex: 7233
{
	// Fields
	private IndexedDictionary<int, string> AWAvkdcjHHLYGAklEIGyDfmCbCrCA; // 0x10
	private bool byACAcjZUTiczlWAotxruWAJgWWxA; // 0x18

	// Properties
	internal bool dCXyZtDTwYHOzCHueGuyTkNRBaJf { get; set; }

	// Methods

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	internal bool OngKNVZmfYYujzwWRPGolFQCHDFE() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void GRrIQazIjzADFqXPqqePAltMLyfS(bool ) { }

	// RVA: 0x1919510 Offset: 0x1918710 VA: 0x181919510
	public void .ctor() { }

	// RVA: 0x1919430 Offset: 0x1918630 VA: 0x181919430
	public void .ctor(CustomPlatformUnifiedKeyboardSource.KeyPropertyMap ) { }

	// RVA: 0x1918F90 Offset: 0x1918190 VA: 0x181918F90
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap.Key Get(KeyboardKeyCode keyCode) { }

	// RVA: 0x1919190 Offset: 0x1918390 VA: 0x181919190
	public void Set(CustomPlatformUnifiedKeyboardSource.KeyPropertyMap.Key key) { }

	// RVA: 0x1919040 Offset: 0x1918240 VA: 0x181919040
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap.Key[] Get() { }

	// RVA: 0x19191F0 Offset: 0x19183F0 VA: 0x1819191F0
	public void Set(ICollection<CustomPlatformUnifiedKeyboardSource.KeyPropertyMap.Key> keys) { }
}

// Namespace: Rewired.Platforms.Custom
public abstract class CustomPlatformUnifiedKeyboardSource : CustomPlatformUnifiedControllerSource // TypeDefIndex: 7234
{
	// Fields
	private CustomPlatformUnifiedKeyboardSource.KeyPropertyMap gImGFNwWziaxaQDjVXPejRxtFeAAA; // 0x38

	// Properties
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap keyPropertyMap { get; set; }

	// Methods

	// RVA: 0x1916AE0 Offset: 0x1915CE0 VA: 0x181916AE0
	public void .ctor() { }

	// RVA: 0x1916BE0 Offset: 0x1915DE0 VA: 0x181916BE0
	public CustomPlatformUnifiedKeyboardSource.KeyPropertyMap get_keyPropertyMap() { }

	// RVA: 0x1916E50 Offset: 0x1916050 VA: 0x181916E50
	public void set_keyPropertyMap(CustomPlatformUnifiedKeyboardSource.KeyPropertyMap value) { }

	// RVA: 0x1916A00 Offset: 0x1915C00 VA: 0x181916A00
	protected void SetKeyValue(KeyboardKeyCode keyCode, bool value) { }

	// RVA: 0x1916E30 Offset: 0x1916030 VA: 0x181916E30 Slot: 6
	internal override void qGlLtDwEmupMNDqnBPyHiEbSNmzx() { }

	// RVA: 0x1916C50 Offset: 0x1915E50 VA: 0x181916C50
	private void jQbRvAIWDMcTnhukjLFgpMWhFgMBA() { }
}

// Namespace: Rewired.Platforms.Custom
public interface IHardwareJoystickMapCustomPlatformMapProvider // TypeDefIndex: 7235
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract HardwareJoystickMap.Platform GetPlatformMap(int customPlatformId, Guid hardwareTypeGuid);
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMap.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7236
{
	// Fields
	[Tooltip("The list of axes in this controller.")]
	public HardwareJoystickMapCustomPlatformMap.Axis[] axes; // 0x10
	[Tooltip("The list of buttons in this controller.")]
	public HardwareJoystickMapCustomPlatformMap.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x19171E0 Offset: 0x19163E0 VA: 0x1819171E0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1917170 Offset: 0x1916370 VA: 0x181917170 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x19170C0 Offset: 0x19162C0 VA: 0x1819170C0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMap.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7237
{
	// Methods

	// RVA: 0x190A470 Offset: 0x1909670 VA: 0x18190A470 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x190A420 Offset: 0x1909620 VA: 0x18190A420 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMap.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7238
{
	// Methods

	// RVA: 0x190A3B0 Offset: 0x19095B0 VA: 0x18190A3B0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x190A360 Offset: 0x1909560 VA: 0x18190A360 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMap.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7239
{
	// Fields
	[Tooltip("If enabled, name strings can contain regular expressions for matching.")]
	public bool nameUseRegex; // 0x30
	[Tooltip("A list of string names to match on. If defined, any matching name will result in a match.")]
	public string[] name; // 0x38

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	public virtual bool Matches(object customIdentifier) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x1919C10 Offset: 0x1918E10 VA: 0x181919C10 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x1919A90 Offset: 0x1918C90 VA: 0x181919A90 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract object CreateInstance();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	protected virtual void DeepClone(object destination) { }

	// RVA: 0x1919870 Offset: 0x1918A70 VA: 0x181919870 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x1919760 Offset: 0x1918960 VA: 0x181919760 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	protected void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMap : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7240
{
	// Fields
	[Tooltip("The list of controller elements.")]
	public HardwareJoystickMapCustomPlatformMap.Elements elements; // 0x18
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x20
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x28

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMapCustomPlatformMap.Axis[] Axes_orig { get; }
	internal HardwareJoystickMapCustomPlatformMap.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x1918800 Offset: 0x1917A00 VA: 0x181918800 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x19187D0 Offset: 0x19179D0 VA: 0x1819187D0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x19188A0 Offset: 0x1917AA0 VA: 0x1819188A0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1918570 Offset: 0x1917770 VA: 0x181918570 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x19186A0 Offset: 0x19178A0 VA: 0x1819186A0 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x1918680 Offset: 0x1917880 VA: 0x181918680
	internal HardwareJoystickMapCustomPlatformMap.Axis[] get_Axes_orig() { }

	// RVA: 0x19187B0 Offset: 0x19179B0 VA: 0x1819187B0
	internal HardwareJoystickMapCustomPlatformMap.Button[] get_Buttons_orig() { }

	// RVA: 0x1918830 Offset: 0x1917A30 VA: 0x181918830 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x1918880 Offset: 0x1917A80 VA: 0x181918880 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract object CreateInstance();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	protected virtual void DeepClone(object destination) { }

	// RVA: 0x1918350 Offset: 0x1917550 VA: 0x181918350 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1918270 Offset: 0x1917470 VA: 0x181918270 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7241
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	public HardwareJoystickMapCustomPlatformMap<> nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x0

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E890 Offset: 0xE6DA90 VA: 0x180E6E890
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB12B0 Offset: 0xBB04B0 VA: 0x180BB12B0
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E940 Offset: 0xE6DB40 VA: 0x180E6E940
	|-HardwareJoystickMapCustomPlatformMap.jHLSHIbSnbSTXSlJGSaNxeKcGpcK<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7242
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	public HardwareJoystickMapCustomPlatformMap<> nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x0

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1213350 Offset: 0x1212550 VA: 0x181213350
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB12B0 Offset: 0xBB04B0 VA: 0x180BB12B0
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E940 Offset: 0xE6DB40 VA: 0x180E6E940
	|-HardwareJoystickMapCustomPlatformMap.GrlzFGIrdubEklNdClZRfkYTnBcS<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMap<TMatchingCriteria> : HardwareJoystickMapCustomPlatformMap // TypeDefIndex: 7243
{
	// Fields
	[Tooltip("User-defined matching criteria. Determines whether this platform map matches to a particular controller.")]
	public TMatchingCriteria matchingCriteria; // 0x0

	// Properties
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	internal override bool get_hasData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218CF0 Offset: 0x1217EF0 VA: 0x181218CF0
	|-HardwareJoystickMapCustomPlatformMap<object>.get_hasData
	*/

	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_disabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218CD0 Offset: 0x1217ED0 VA: 0x181218CD0
	|-HardwareJoystickMapCustomPlatformMap<object>.get_disabled
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override bool get_isAllowed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218D50 Offset: 0x1217F50 VA: 0x181218D50
	|-HardwareJoystickMapCustomPlatformMap<object>.get_isAllowed
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218B40 Offset: 0x1217D40 VA: 0x181218B40
	|-HardwareJoystickMapCustomPlatformMap<object>.Matches
	*/

	// RVA: -1 Offset: -1 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218A40 Offset: 0x1217C40 VA: 0x181218A40
	|-HardwareJoystickMapCustomPlatformMap<object>.IterateAxes
	*/

	// RVA: -1 Offset: -1 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218AC0 Offset: 0x1217CC0 VA: 0x181218AC0
	|-HardwareJoystickMapCustomPlatformMap<object>.IterateButtons
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12186E0 Offset: 0x12178E0 VA: 0x1812186E0
	|-HardwareJoystickMapCustomPlatformMap<object>.IsElementIdentifierMapped
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12181D0 Offset: 0x12173D0 VA: 0x1812181D0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetGameElementIdentifierIdMappings
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12179F0 Offset: 0x1216BF0 VA: 0x1812179F0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetAxisCalibrationData
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1217CD0 Offset: 0x1216ED0 VA: 0x181217CD0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetAxisData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1217FF0 Offset: 0x12171F0 VA: 0x181217FF0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetButtonData
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12181A0 Offset: 0x12173A0 VA: 0x1812181A0
	|-HardwareJoystickMapCustomPlatformMap<object>.GetEffectiveElementIdentifierType
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218170 Offset: 0x1217370 VA: 0x181218170
	|-HardwareJoystickMapCustomPlatformMap<object>.GetEffectiveAxisRange
	*/

	// RVA: -1 Offset: -1 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12178F0 Offset: 0x1216AF0 VA: 0x1812178F0
	|-HardwareJoystickMapCustomPlatformMap<object>.CopyVars
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7ABC00 Offset: 0x7AAE00 VA: 0x1807ABC00
	|-HardwareJoystickMapCustomPlatformMap<object>..ctor
	*/
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMapSimpleBase.MatchingCriteria : HardwareJoystickMapCustomPlatformMap.MatchingCriteria // TypeDefIndex: 7244
{
	// Methods

	// RVA: 0x1919820 Offset: 0x1918A20 VA: 0x181919820 Slot: 14
	protected override object CreateInstance() { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class HardwareJoystickMapCustomPlatformMapSimpleBase : HardwareJoystickMapCustomPlatformMap<HardwareJoystickMapCustomPlatformMapSimpleBase.MatchingCriteria> // TypeDefIndex: 7245
{
	// Methods

	// RVA: 0x1918150 Offset: 0x1917350 VA: 0x181918150 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x19181C0 Offset: 0x19173C0 VA: 0x1819181C0
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMapCustomPlatformMapSimple : HardwareJoystickMapCustomPlatformMapSimpleBase // TypeDefIndex: 7246
{
	// Fields
	public HardwareJoystickMapCustomPlatformMapSimpleBase[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1918200 Offset: 0x1917400 VA: 0x181918200 Slot: 28
	protected override object CreateInstance() { }

	// RVA: 0x19181C0 Offset: 0x19173C0 VA: 0x1819181C0
	public void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public abstract class HardwareJoystickMapCustomPlatformMapSO : ScriptableObject // TypeDefIndex: 7247
{
	// Fields
	[Tooltip("The joystick to which this platform map belongs. This must be assigned a HardwareJoystickMap (controller definition).")]
	public HardwareJoystickMap hardwareJoystickMap; // 0x18

	// Methods

	// RVA: 0x1918090 Offset: 0x1917290 VA: 0x181918090 Slot: 4
	public virtual bool Matches(Guid hardwareTypeGuid) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract HardwareJoystickMap.Platform GetPlatformMap();

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: Rewired.Platforms.Custom
[Serializable]
public class HardwareJoystickMapCustomPlatformMapSimpleSO : HardwareJoystickMapCustomPlatformMapSO // TypeDefIndex: 7248
{
	// Fields
	public HardwareJoystickMapCustomPlatformMapSimple platformMap; // 0x20

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public override HardwareJoystickMap.Platform GetPlatformMap() { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
internal static class bSvFSJCtKYzExUTydFjuDrUrirSYA // TypeDefIndex: 7249
{
	// Fields
	private static CustomPlatformInitOptions BJcanMEoOfLuDMVmBAUUiVxWkCUEb; // 0x0

	// Properties
	public static int KclEznIUocfgsBWLzfepnZXIFiTu { get; }
	public static bool GXvHLIeGnYrXPqKwCOmxqppvfQQFA { get; }

	// Methods

	// RVA: 0x191F520 Offset: 0x191E720 VA: 0x18191F520
	public static int BxnfnqqOdbjUmGcpxblMwRoSLSGZA() { }

	// RVA: 0x191FBD0 Offset: 0x191EDD0 VA: 0x18191FBD0
	public static bool sVQMVJhYQrAtzHdAYgrzHkEEdkmMA() { }

	// RVA: 0x191F6F0 Offset: 0x191E8F0 VA: 0x18191F6F0
	public static void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(CustomPlatformInitOptions ) { }

	// RVA: 0x191FB30 Offset: 0x191ED30 VA: 0x18191FB30
	public static void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x191F970 Offset: 0x191EB70 VA: 0x18191F970
	internal static int acwdzgCVOesIweLyGwlJqfMzgIUk() { }

	// RVA: 0x191F570 Offset: 0x191E770 VA: 0x18191F570
	internal static string GQsbrxIvApfvQSUTLCAgedFThwvY() { }

	// RVA: 0x191FC30 Offset: 0x191EE30 VA: 0x18191FC30
	internal static IHardwareJoystickMapCustomPlatformMapProvider yxJcYIFxyQuFidmFofMWybrYpPOXA() { }

	// RVA: 0x191F6A0 Offset: 0x191E8A0 VA: 0x18191F6A0
	internal static CustomInputSource WSqIUQaCWKqROiiakuegaPrRZMkj() { }

	// RVA: 0x191FB80 Offset: 0x191ED80 VA: 0x18191FB80
	internal static CustomPlatformConfigVars oGAsZlimXqkMyhpQWtVRFNMPthTJ() { }

	// RVA: 0x191F5C0 Offset: 0x191E7C0 VA: 0x18191F5C0
	private static void UtwSKcdjmaGsPUSxulbXoclXlQtq() { }

	// RVA: 0x191F9C0 Offset: 0x191EBC0 VA: 0x18191F9C0
	private static void cDddqvmtwpEDTyIOHnngJnRDCEIHA(CustomPlatformInitOptions ) { }
}

// Namespace: 
internal abstract class FYfEjYvcUVMWuGJOAdqGGlzOhSES : IDisposable // TypeDefIndex: 7250
{
	// Fields
	protected readonly CustomPlatformUnifiedControllerSource aGdmGXiGhrYsfydTWTVhHYKVxvGl; // 0x10
	private readonly HardwareControllerMap_Game bkpeQnrzthWzHwSMngJePMGPEpdc; // 0x18
	private bool EmpFZBHlVxLxNCSZaSynARkwSkCPc; // 0x20
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x21

	// Properties
	public InputSource NOproBQQdmCZareWqeKxfvgAUJcsA { get; }
	public HardwareControllerMap_Game GvrRKEvhRFQLAyweejKeBxXVLmWt { get; }
	public int KLiLeFOmHnIKewzsCXwtlSRRgkOA { get; }
	public int ZwxoEwSrePraFcQWlwoanfflAcnb { get; }
	public Controller.Extension VFfIkkfbzbZoDrcXOwPnpXFqJbde { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(CustomPlatformUnifiedControllerSource , HardwareControllerMap_Game ) { }

	// RVA: 0xAA0150 Offset: 0xA9F350 VA: 0x180AA0150 Slot: 5
	public InputSource get_inputSource() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	public HardwareControllerMap_Game get_hardwareMap() { }

	// RVA: 0x7751D0 Offset: 0x7743D0 VA: 0x1807751D0 Slot: 7
	public int get_axisCount() { }

	// RVA: 0x1917E60 Offset: 0x1917060 VA: 0x181917E60 Slot: 8
	public int get_buttonCount() { }

	// RVA: 0x1917E80 Offset: 0x1917080 VA: 0x181917E80 Slot: 9
	public Controller.Extension get_controllerExtension() { }

	// RVA: 0x16570C0 Offset: 0x16562C0 VA: 0x1816570C0 Slot: 10
	public void Clear() { }

	// RVA: 0x1917CC0 Offset: 0x1916EC0 VA: 0x181917CC0 Slot: 11
	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1917E30 Offset: 0x1917030 VA: 0x181917E30
	public void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x1917BF0 Offset: 0x1916DF0 VA: 0x181917BF0 Slot: 12
	protected virtual void QKEYycJGvyEZCdnUfkbohEkzVpV(bool ) { }

	// RVA: 0x1917C50 Offset: 0x1916E50 VA: 0x181917C50 Slot: 4
	private void System.IDisposable.Dispose() { }
}

// Namespace: 
internal class TMVdJRTNWOibielyPbUOLEkJMbrl : FYfEjYvcUVMWuGJOAdqGGlzOhSES, IUnifiedMouseSource // TypeDefIndex: 7251
{
	// Properties
	private Vector2 Rewired.Interfaces.IUnifiedMouseSource.mousePosition { get; }

	// Methods

	// RVA: 0x191C940 Offset: 0x191BB40 VA: 0x18191C940
	public void .ctor(CustomPlatformUnifiedMouseSource ) { }

	// RVA: 0x191C860 Offset: 0x191BA60 VA: 0x18191C860 Slot: 17
	private Vector2 Rewired.Interfaces.IUnifiedMouseSource.get_mousePosition() { }
}

// Namespace: 
internal class kykppCRwfhTiKYdIiXrtsbfoHPMl : FYfEjYvcUVMWuGJOAdqGGlzOhSES, IUnifiedKeyboardSource // TypeDefIndex: 7252
{
	// Methods

	// RVA: 0x1921510 Offset: 0x1920710 VA: 0x181921510
	public void .ctor(CustomPlatformUnifiedKeyboardSource ) { }
}

// Namespace: 
private static class ConfigVars.wynbTAhewiarlFQuKFNgRmQabEROB // TypeDefIndex: 7253
{
	// Fields
	public const string pdMpguIIJSXJuwgCZpDStKcWwtYN = "updateLoop";
	public const string emtAsmeAgLJYBKyykuHyUyYdTFjDA = "alwaysUseUnityInput";
	public const string BMqqldnAkmuVUuvKNHsvmxYibORF = "windowsStandalonePrimaryInputSource";
	public const string UguhJWjdoNTUCSxCRTSMmyuRfkLc = "osx_primaryInputSource";
	public const string NOzpSxUQjErMNQkEEHOdVMUGEORu = "linux_primaryInputSource";
	public const string gGghiFPXyKMOoeFRpCFXMAZQaiOIA = "windowsUWP_primaryInputSource";
	public const string bOxeNzPCnpzqHlHhIhCmvaEeBFjcA = "xboxOne_primaryInputSource";
	public const string EGPRqxkGkyJEIIlHPcrySaUwmoFW = "gameCoreXboxOne_primaryInputSource";
	public const string eailKgrJJRfpWhfcoOVkphsJSguQ = "gameCoreScarlett_primaryInputSource";
	public const string VoQMYreYqbmQhAOMnAggfdocFIJN = "ps4_primaryInputSource";
	public const string JrUrrlyTLoAaaGHWvFSEgmlWHzmo = "ps5_primaryInputSource";
	public const string WUvwkHLJPfCIqJuAbYKlJZuQMMLm = "webGL_primaryInputSource";
	public const string wLJavXxhaIkSjFxBUPpUScBUBrwd = "useXInput";
	public const string DJnAXBYSqsqPbiEiDOupvibUlSXu = "windowsStandalone_useSteamRawInputControllerWorkaround";
	public const string cOriPSXzbTSuaDohMgxDeuUCBnWvA = "osxStandalone_useEnhancedDeviceSupport";
	public const string EXibNRAYwACWJlaCGelJkQpqyeLG = "android_supportUnknownGamepads";
	public const string ydEzsLyfADzLDOCecyBMxJTdmuii = "ps4_assignJoysticksByPS4JoyId";
	public const string AauvfpasPfUWHpvLQqgzzXDmaiRi = "useSteamControllerSupport";
	public const string gvNUfZWzFjQJXrezjBqzeAbhyEUz = "logToScreen";
	public const string XPwNaxRaDcnvrNTykNhSFPqGSiUt = "runInEditMode";
	public const string KCytbjbNsSlLptvFXRkGYLSPWCeL = "allowInputInEditorSceneView";
	public const string lIyQwpMCuSaJSKZbYqtkqnHRilLyA = "maxJoysticksPerPlayer";
	public const string pDdUSbbWpESehhMrdKKvsgChrLIO = "autoAssignJoysticks";
	public const string lwfaeMjuHhUaHrMUgZPGNdFBqPRb = "assignJoysticksToPlayingPlayersOnly";
	public const string GRKtuTeLbrGYxsmSUNClnLTpBTRp = "distributeJoysticksEvenly";
	public const string XUmrQWqfLPxULiZKEghUxwbKmKCk = "reassignJoystickToPreviousOwnerOnReconnect";
	public const string zVDbntWQxCEXgQopRxLHLlkpKciJ = "defaultJoystickAxis2DDeadZoneType";
	public const string gBkJSEscEHWVeKbshpTXDuwBTCws = "defaultJoystickAxis2DSensitivityType";
	public const string YQEnvJyCqvbnUlfDVaCwnFDYDBBM = "defaultAxisSensitivityType";
	public const string zvFUiRGRsbbGQBUJUyszobUQywhJ = "force4WayHats";
	public const string xPkzqFnEiUNJfFbRxkkwYvpmVDcD = "throttleCalibrationMode";
	public const string bONCebJkucQsApPAbJltAhXEwyel = "activateActionButtonsOnNegativeValue";
	public const string bjIDxcFENsGFyfoBhGBsnuvyllmsb = "deferControllerConnectedEventsOnStart";
	public const string JJpKaHGVfZLOgXqnJIBQIeohvAcnA = "logLevel";
	public const string AZEQuqCziKjDeCjinrOsFMXOgtLY = "disableKeyboard";
	public const string GOwPJPEMHcgBOFeUJOdBuRHmLVql = "disableMouse";
	public const string GYfhVELxolkLaoKdiJZXJpzUgBPk = "ignoreInputWhenAppNotInFocus";
	public const string VBIhRkCMnjmgBaEInxwjFujijrDUA = "useEnhancedDeviceSupport";
	public const string DfLdidNPfOQIYZgvRVjwZfUjRnrl = "useNativeMouse";
	public const string gzpNTxrxTJzhJbCjKkQotlwkNJKf = "useNativeKeyboard";
	public const string gXTGxaIcyBAcYAQfjoVgCKGoMbTJ = "joystickRefreshRate";
	public const string EWbKKHCrgxBEPMBoITiRnDzUvFkd = "assignJoysticksBySystemId";
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars // TypeDefIndex: 7254
{
	// Fields
	public bool disableKeyboard; // 0x10
	public bool disableMouse; // 0x11
	public bool ignoreInputWhenAppNotInFocus; // 0x12

	// Methods

	// RVA: 0x191A710 Offset: 0x1919910 VA: 0x18191A710
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_WindowsStandalone : ConfigVars.PlatformVars // TypeDefIndex: 7255
{
	// Fields
	public bool useNativeKeyboard; // 0x18
	public int joystickRefreshRate; // 0x1C
	public bool useWindowsGamingInput; // 0x20
	public List<EnhancedDeviceSupportDeviceType> enhancedDeviceSupportExcludedDeviceTypes; // 0x28

	// Methods

	// RVA: 0x191A730 Offset: 0x1919930 VA: 0x18191A730
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_OSXStandalone : ConfigVars.PlatformVars // TypeDefIndex: 7256
{
	// Fields
	public bool useAppleGameController; // 0x18
	public bool assignJoysticksByUserId; // 0x19
	public List<EnhancedDeviceSupportDeviceType> enhancedDeviceSupportExcludedDeviceTypes; // 0x20

	// Methods

	// RVA: 0x191A710 Offset: 0x1919910 VA: 0x18191A710
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_LinuxStandalone : ConfigVars.PlatformVars // TypeDefIndex: 7257
{
	// Fields
	public bool useEnhancedDeviceSupport; // 0x18
	public List<EnhancedDeviceSupportDeviceType> enhancedDeviceSupportExcludedDeviceTypes; // 0x20

	// Methods

	// RVA: 0x191A720 Offset: 0x1919920 VA: 0x18191A720
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_WindowsUWP : ConfigVars.PlatformVars // TypeDefIndex: 7258
{
	// Fields
	public bool useGamepadAPI; // 0x18
	public bool useHIDAPI; // 0x19

	// Methods

	// RVA: 0x1915A50 Offset: 0x1914C50 VA: 0x181915A50
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_GameCoreXboxOne : ConfigVars.PlatformVars // TypeDefIndex: 7259
{
	// Fields
	public bool assignJoysticksByUserId; // 0x18

	// Methods

	// RVA: 0x191A710 Offset: 0x1919910 VA: 0x18191A710
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_GameCoreScarlett : ConfigVars.PlatformVars // TypeDefIndex: 7260
{
	// Fields
	public bool assignJoysticksByUserId; // 0x18

	// Methods

	// RVA: 0x191A710 Offset: 0x1919910 VA: 0x18191A710
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ConfigVars.PlatformVars_PS5 : ConfigVars.PlatformVars // TypeDefIndex: 7261
{
	// Fields
	public bool assignJoysticksByPS5JoyId; // 0x18

	// Methods

	// RVA: 0x191A720 Offset: 0x1919920 VA: 0x18191A720
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class ConfigVars.EditorVars // TypeDefIndex: 7262
{
	// Fields
	public bool exportConsts_useParentClass; // 0x10
	public string exportConsts_parentClassName; // 0x18
	public bool exportConsts_useNamespace; // 0x20
	public string exportConsts_namespace; // 0x28
	public bool exportConsts_actions; // 0x30
	public string exportConsts_actionsClassName; // 0x38
	public bool exportConsts_actionsIncludeActionCategory; // 0x40
	public bool exportConsts_actionsCreateClassesForActionCategories; // 0x41
	public bool exportConsts_mapCategories; // 0x42
	public string exportConsts_mapCategoriesClassName; // 0x48
	public bool exportConsts_layouts; // 0x50
	public string exportConsts_layoutsClassName; // 0x58
	public bool exportConsts_players; // 0x60
	public string exportConsts_playersClassName; // 0x68
	public bool exportConsts_inputBehaviors; // 0x70
	public string exportConsts_inputBehaviorsClassName; // 0x78
	public bool exportConsts_customControllers; // 0x80
	public string exportConsts_customControllersClassName; // 0x88
	public string exportConsts_customControllersAxesClassName; // 0x90
	public string exportConsts_customControllersButtonsClassName; // 0x98
	public bool exportConsts_layoutManagerRuleSets; // 0xA0
	public string exportConsts_layoutManagerRuleSetsClassName; // 0xA8
	public bool exportConsts_mapEnablerRuleSets; // 0xB0
	public string exportConsts_mapEnablerRuleSetsClassName; // 0xB8
	public bool exportConsts_allCapsConstantNames; // 0xC0

	// Methods

	// RVA: 0x1916F50 Offset: 0x1916150 VA: 0x181916F50
	public void .ctor() { }
}

// Namespace: 
private class ConfigVars.szutnbEqbQfkMQxiNRvnJINDBkhu // TypeDefIndex: 7263
{
	// Fields
	public Func<ConfigVars.PlatformVars> qFQEjeDAgrGXLXTjTClTPtPiMzWW; // 0x10
	public string EQOevHQAlTDSNabkyEUkNarBedVZA; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(Func<ConfigVars.PlatformVars> , string ) { }
}

// Namespace: 
private class ConfigVars.tSbSFXPZFyiYIeAYFCZYThHGdhSs // TypeDefIndex: 7264
{
	// Fields
	public Func<Platform, object> qFQEjeDAgrGXLXTjTClTPtPiMzWW; // 0x10
	public Action<Platform, object> uqjjYoydmpDnmdltYIxEmGlczVMr; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(Func<Platform, object> , Action<Platform, object> ) { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
internal enum ConfigVars.AllPlatformVar // TypeDefIndex: 7265
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const ConfigVars.AllPlatformVar DisableKeyboard = 0;
	[CustomObfuscation(rename = False)]
	public const ConfigVars.AllPlatformVar IgnoreInputWhenAppNotInFocus = 1;
	[CustomObfuscation(rename = False)]
	public const ConfigVars.AllPlatformVar DisableMouse = 2;
}

// Namespace: Rewired.Data
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ConfigVars : IConfigVars_Internal // TypeDefIndex: 7266
{
	// Fields
	public UpdateMode updateMode; // 0x10
	public UpdateLoopSetting updateLoop; // 0x14
	public bool alwaysUseUnityInput; // 0x18
	public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource; // 0x1C
	public OSXStandalonePrimaryInputSource osx_primaryInputSource; // 0x20
	public LinuxStandalonePrimaryInputSource linux_primaryInputSource; // 0x24
	public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource; // 0x28
	public XboxOnePrimaryInputSource xboxOne_primaryInputSource; // 0x2C
	public GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource; // 0x30
	public GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource; // 0x34
	public PS4PrimaryInputSource ps4_primaryInputSource; // 0x38
	public PS5PrimaryInputSource ps5_primaryInputSource; // 0x3C
	public WebGLPrimaryInputSource webGL_primaryInputSource; // 0x40
	public bool useXInput; // 0x44
	public bool useNativeMouse; // 0x45
	public bool useEnhancedDeviceSupport; // 0x46
	public bool osxStandalone_useEnhancedDeviceSupport; // 0x47
	public bool android_supportUnknownGamepads; // 0x48
	public bool ps4_assignJoysticksByPS4JoyId; // 0x49
	public bool useSteamControllerSupport; // 0x4A
	public bool logToScreen; // 0x4B
	public bool runInEditMode; // 0x4C
	public bool allowInputInEditorSceneView; // 0x4D
	public bool unityUsePhysicalKeys; // 0x4E
	public KeyCombinationOverrideMode keyCombinationOverrideMode; // 0x50
	public bool generateKeyEventsOnKeyCombinationOverride; // 0x54
	public ConfigVars.PlatformVars_WindowsStandalone platformVars_windowsStandalone; // 0x58
	public ConfigVars.PlatformVars_LinuxStandalone platformVars_linuxStandalone; // 0x60
	public ConfigVars.PlatformVars_OSXStandalone platformVars_osxStandalone; // 0x68
	public ConfigVars.PlatformVars_WindowsUWP platformVars_windowsUWP; // 0x70
	public ConfigVars.PlatformVars platformVars_iOS; // 0x78
	public ConfigVars.PlatformVars platformVars_tvOS; // 0x80
	public ConfigVars.PlatformVars platformVars_android; // 0x88
	public ConfigVars.PlatformVars platformVars_ps4; // 0x90
	public ConfigVars.PlatformVars_PS5 platformVars_ps5; // 0x98
	public ConfigVars.PlatformVars platformVars_psVita; // 0xA0
	public ConfigVars.PlatformVars platformVars_xboxOne; // 0xA8
	public ConfigVars.PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne; // 0xB0
	public ConfigVars.PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett; // 0xB8
	public ConfigVars.PlatformVars platformVars_switch; // 0xC0
	public ConfigVars.PlatformVars platformVars_webGL; // 0xC8
	private ConfigVars.PlatformVars platformVars_unknown; // 0xD0
	public int maxJoysticksPerPlayer; // 0xD8
	public bool autoAssignJoysticks; // 0xDC
	public bool assignJoysticksToPlayingPlayersOnly; // 0xDD
	public bool distributeJoysticksEvenly; // 0xDE
	public bool reassignJoystickToPreviousOwnerOnReconnect; // 0xDF
	public DeadZone2DType defaultJoystickAxis2DDeadZoneType; // 0xE0
	public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType; // 0xE4
	public AxisSensitivityType defaultAxisSensitivityType; // 0xE8
	public bool force4WayHats; // 0xEC
	public ThrottleCalibrationMode throttleCalibrationMode; // 0xF0
	public bool activateActionButtonsOnNegativeValue; // 0xF4
	public bool deferControllerConnectedEventsOnStart; // 0xF5
	public LogLevelFlags logLevel; // 0xF8
	public ConfigVars.EditorVars editorSettings; // 0x100
	private Dictionary<int, ConfigVars.szutnbEqbQfkMQxiNRvnJINDBkhu> __platformVarsDict; // 0x108
	private Dictionary<int, ConfigVars.tSbSFXPZFyiYIeAYFCZYThHGdhSs> __getSetPlatformVariableDict; // 0x110
	private KeyedGetSetValueStore<string> __configVarsValues; // 0x118
	private Dictionary<string, object> __valueDelegates; // 0x120

	// Properties
	private Dictionary<int, ConfigVars.szutnbEqbQfkMQxiNRvnJINDBkhu> platformVarsDict { get; }
	private Dictionary<int, ConfigVars.tSbSFXPZFyiYIeAYFCZYThHGdhSs> getSetPlatformVariableDict { get; }
	private KeyedGetSetValueStore<string> Rewired.Data.IConfigVars_Internal.values { get; }
	private Dictionary<string, object> valueDelegates { get; }

	// Methods

	// RVA: 0x190E770 Offset: 0x190D970 VA: 0x18190E770
	private Dictionary<int, ConfigVars.szutnbEqbQfkMQxiNRvnJINDBkhu> get_platformVarsDict() { }

	// RVA: 0x190E4D0 Offset: 0x190D6D0 VA: 0x18190E4D0
	private Dictionary<int, ConfigVars.tSbSFXPZFyiYIeAYFCZYThHGdhSs> get_getSetPlatformVariableDict() { }

	[Preserve]
	// RVA: 0x190E470 Offset: 0x190D670 VA: 0x18190E470
	public void .ctor() { }

	// RVA: 0x190A6C0 Offset: 0x19098C0 VA: 0x18190A6C0
	internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) { }

	// RVA: 0x190AC60 Offset: 0x1909E60 VA: 0x18190AC60
	internal string GetDebugConfigSettings() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x190C080 Offset: 0x190B280 VA: 0x18190C080
	internal string GetPlatformVarsRelPath(Platform platform) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x190C150 Offset: 0x190B350 VA: 0x18190C150
	internal ConfigVars.PlatformVars GetPlatformVars(Platform platform) { }

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	internal T Editor_GetAllSerializedPlatformVar<T>(ConfigVars.AllPlatformVar var) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E810 Offset: 0x94DA10 VA: 0x18094E810
	|-ConfigVars.Editor_GetAllSerializedPlatformVar<__Il2CppFullySharedGenericType>
	*/

	[CustomObfuscation(rename = False)]
	// RVA: 0x190A740 Offset: 0x1909940 VA: 0x18190A740
	internal void Editor_SetAllSerializedPlatformVar(ConfigVars.AllPlatformVar var, object value) { }

	// RVA: 0x190B4B0 Offset: 0x190A6B0 VA: 0x18190B4B0
	internal bool GetPlatformVar_disableKeyboard() { }

	// RVA: 0x190C840 Offset: 0x190BA40 VA: 0x18190C840
	internal bool SetPlatformVar_disableKeyboard(bool value) { }

	// RVA: 0x190B4D0 Offset: 0x190A6D0 VA: 0x18190B4D0
	internal bool GetPlatformVar_disableMouse() { }

	// RVA: 0x190C870 Offset: 0x190BA70 VA: 0x18190C870
	internal bool SetPlatformVar_disableMouse(bool value) { }

	// RVA: 0x190B770 Offset: 0x190A970 VA: 0x18190B770
	internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus() { }

	// RVA: 0x190BA10 Offset: 0x190AC10 VA: 0x18190BA10
	internal bool GetPlatformVar_useEnhancedDeviceSupport() { }

	// RVA: 0x190BDD0 Offset: 0x190AFD0 VA: 0x18190BDD0
	internal bool GetPlatformVar_useNativeMouse() { }

	// RVA: 0x190BB80 Offset: 0x190AD80 VA: 0x18190BB80
	internal bool GetPlatformVar_useNativeKeyboard() { }

	// RVA: 0x190B790 Offset: 0x190A990 VA: 0x18190B790
	internal int GetPlatformVar_joystickRefreshRate() { }

	// RVA: 0x190B0D0 Offset: 0x190A2D0 VA: 0x18190B0D0
	internal bool GetPlatformVar_assignJoysticksBySystemId() { }

	// RVA: 0x190B8D0 Offset: 0x190AAD0 VA: 0x18190B8D0
	internal bool GetPlatformVar_useAppleGameController() { }

	// RVA: 0x190BF40 Offset: 0x190B140 VA: 0x18190BF40
	internal bool GetPlatformVar_useWindowsGamingInput() { }

	// RVA: 0x190B4F0 Offset: 0x190A6F0 VA: 0x18190B4F0
	internal IList<EnhancedDeviceSupportDeviceType> GetPlatformVar_enhancedDeviceSupportExcludedDeviceTypes() { }

	// RVA: 0x190CC30 Offset: 0x190BE30 VA: 0x18190CC30
	internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value) { }

	// RVA: 0x190CF40 Offset: 0x190C140 VA: 0x18190CF40
	internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value) { }

	// RVA: 0x190D270 Offset: 0x190C470 VA: 0x18190D270
	internal bool SetPlatformVar_useNativeMouse(bool value) { }

	// RVA: 0x190D0E0 Offset: 0x190C2E0 VA: 0x18190D0E0
	internal bool SetPlatformVar_useNativeKeyboard(bool value) { }

	// RVA: 0x190CC90 Offset: 0x190BE90 VA: 0x18190CC90
	internal bool SetPlatformVar_joystickRefreshRate(int value) { }

	// RVA: 0x190C510 Offset: 0x190B710 VA: 0x18190C510
	internal bool SetPlatformVar_assignJoysticksBySystemId(bool value) { }

	// RVA: 0x190CDE0 Offset: 0x190BFE0 VA: 0x18190CDE0
	internal bool SetPlatformVar_useAppleGameController(bool value) { }

	// RVA: 0x190D320 Offset: 0x190C520 VA: 0x18190D320
	internal bool SetPlatformVar_useWindowsGamingInput(bool value) { }

	// RVA: 0x190C8A0 Offset: 0x190BAA0 VA: 0x18190C8A0
	internal bool SetPlatformVar_enhancedDeviceSupportExcludedDeviceTypes(IList<EnhancedDeviceSupportDeviceType> value) { }

	// RVA: 0x190C2E0 Offset: 0x190B4E0 VA: 0x18190C2E0
	private ConfigVars.PlatformVars GetPlatformVars() { }

	// RVA: -1 Offset: -1
	private T GetOrCreatePlatformVars<T>(ref T var) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E990 Offset: 0x94DB90 VA: 0x18094E990
	|-ConfigVars.GetOrCreatePlatformVars<object>
	*/

	// RVA: 0x190A920 Offset: 0x1909B20 VA: 0x18190A920
	private MultiBoolValue GetAllSerializedPlatformVar_multiBool(ConfigVars.AllPlatformVar var) { }

	// RVA: 0x190C370 Offset: 0x190B570 VA: 0x18190C370
	internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform) { }

	// RVA: 0x190C450 Offset: 0x190B650 VA: 0x18190C450
	private static bool IsNativeKeyboardAllowed(Platform platform, bool unityUsePhysicalKeys) { }

	// RVA: 0x190C470 Offset: 0x190B670 VA: 0x18190C470 Slot: 4
	private KeyedGetSetValueStore<string> Rewired.Data.IConfigVars_Internal.get_values() { }

	// RVA: 0x190EFF0 Offset: 0x190E1F0 VA: 0x18190EFF0
	private Dictionary<string, object> get_valueDelegates() { }

	[CompilerGenerated]
	// RVA: 0x190D770 Offset: 0x190C970 VA: 0x18190D770
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_0() { }

	[CompilerGenerated]
	// RVA: 0x190D930 Offset: 0x190CB30 VA: 0x18190D930
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_1() { }

	[CompilerGenerated]
	// RVA: 0x190D970 Offset: 0x190CB70 VA: 0x18190D970
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_2() { }

	[CompilerGenerated]
	// RVA: 0x190D9B0 Offset: 0x190CBB0 VA: 0x18190D9B0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_3() { }

	[CompilerGenerated]
	// RVA: 0x190D9F0 Offset: 0x190CBF0 VA: 0x18190D9F0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_4() { }

	[CompilerGenerated]
	// RVA: 0x190DA30 Offset: 0x190CC30 VA: 0x18190DA30
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_5() { }

	[CompilerGenerated]
	// RVA: 0x190DA70 Offset: 0x190CC70 VA: 0x18190DA70
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_6() { }

	[CompilerGenerated]
	// RVA: 0x190DAB0 Offset: 0x190CCB0 VA: 0x18190DAB0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_7() { }

	[CompilerGenerated]
	// RVA: 0x190DAF0 Offset: 0x190CCF0 VA: 0x18190DAF0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_8() { }

	[CompilerGenerated]
	// RVA: 0x190DB30 Offset: 0x190CD30 VA: 0x18190DB30
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_9() { }

	[CompilerGenerated]
	// RVA: 0x190D7B0 Offset: 0x190C9B0 VA: 0x18190D7B0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_10() { }

	[CompilerGenerated]
	// RVA: 0x190D7F0 Offset: 0x190C9F0 VA: 0x18190D7F0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_11() { }

	[CompilerGenerated]
	// RVA: 0x190D830 Offset: 0x190CA30 VA: 0x18190D830
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_12() { }

	[CompilerGenerated]
	// RVA: 0x190D870 Offset: 0x190CA70 VA: 0x18190D870
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_13() { }

	[CompilerGenerated]
	// RVA: 0x190D8B0 Offset: 0x190CAB0 VA: 0x18190D8B0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_14() { }

	[CompilerGenerated]
	// RVA: 0x190D8F0 Offset: 0x190CAF0 VA: 0x18190D8F0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__58_15() { }

	[CompilerGenerated]
	// RVA: 0x190D470 Offset: 0x190C670 VA: 0x18190D470
	private object <get_getSetPlatformVariableDict>b__61_0(Platform p) { }

	[CompilerGenerated]
	// RVA: 0x190D4E0 Offset: 0x190C6E0 VA: 0x18190D4E0
	private void <get_getSetPlatformVariableDict>b__61_1(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x190D570 Offset: 0x190C770 VA: 0x18190D570
	private object <get_getSetPlatformVariableDict>b__61_2(Platform p) { }

	[CompilerGenerated]
	// RVA: 0x190D5E0 Offset: 0x190C7E0 VA: 0x18190D5E0
	private void <get_getSetPlatformVariableDict>b__61_3(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x190D670 Offset: 0x190C870 VA: 0x18190D670
	private object <get_getSetPlatformVariableDict>b__61_4(Platform platform) { }

	[CompilerGenerated]
	// RVA: 0x190D6E0 Offset: 0x190C8E0 VA: 0x18190D6E0
	private void <get_getSetPlatformVariableDict>b__61_5(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	private UpdateLoopSetting <get_valueDelegates>b__101_0() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	private void <get_valueDelegates>b__101_1(UpdateLoopSetting x) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	private bool <get_valueDelegates>b__101_2() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void <get_valueDelegates>b__101_3(bool x) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	private WindowsStandalonePrimaryInputSource <get_valueDelegates>b__101_4() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	private void <get_valueDelegates>b__101_5(WindowsStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	private OSXStandalonePrimaryInputSource <get_valueDelegates>b__101_6() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void <get_valueDelegates>b__101_7(OSXStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	private LinuxStandalonePrimaryInputSource <get_valueDelegates>b__101_8() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	private void <get_valueDelegates>b__101_9(LinuxStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	private WindowsUWPPrimaryInputSource <get_valueDelegates>b__101_10() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	private void <get_valueDelegates>b__101_11(WindowsUWPPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	private XboxOnePrimaryInputSource <get_valueDelegates>b__101_12() { }

	[CompilerGenerated]
	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	private void <get_valueDelegates>b__101_13(XboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	private GameCoreXboxOnePrimaryInputSource <get_valueDelegates>b__101_14() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void <get_valueDelegates>b__101_15(GameCoreXboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	private GameCoreScarlettPrimaryInputSource <get_valueDelegates>b__101_16() { }

	[CompilerGenerated]
	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	private void <get_valueDelegates>b__101_17(GameCoreScarlettPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	private PS4PrimaryInputSource <get_valueDelegates>b__101_18() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	private void <get_valueDelegates>b__101_19(PS4PrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	private PS5PrimaryInputSource <get_valueDelegates>b__101_20() { }

	[CompilerGenerated]
	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	private void <get_valueDelegates>b__101_21(PS5PrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	private WebGLPrimaryInputSource <get_valueDelegates>b__101_22() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void <get_valueDelegates>b__101_23(WebGLPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x190DB80 Offset: 0x190CD80 VA: 0x18190DB80
	private bool <get_valueDelegates>b__101_24() { }

	[CompilerGenerated]
	// RVA: 0x190DB90 Offset: 0x190CD90 VA: 0x18190DB90
	private void <get_valueDelegates>b__101_25(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DBA0 Offset: 0x190CDA0 VA: 0x18190DBA0
	private bool <get_valueDelegates>b__101_26() { }

	[CompilerGenerated]
	// RVA: 0x190DBB0 Offset: 0x190CDB0 VA: 0x18190DBB0
	private void <get_valueDelegates>b__101_27(bool x) { }

	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	private bool <get_valueDelegates>b__101_28() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	private void <get_valueDelegates>b__101_29(bool x) { }

	[CompilerGenerated]
	// RVA: 0x563E30 Offset: 0x563030 VA: 0x180563E30
	private bool <get_valueDelegates>b__101_30() { }

	[CompilerGenerated]
	// RVA: 0x563E50 Offset: 0x563050 VA: 0x180563E50
	private void <get_valueDelegates>b__101_31(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DBC0 Offset: 0x190CDC0 VA: 0x18190DBC0
	private bool <get_valueDelegates>b__101_32() { }

	[CompilerGenerated]
	// RVA: 0x190DBD0 Offset: 0x190CDD0 VA: 0x18190DBD0
	private void <get_valueDelegates>b__101_33(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DBE0 Offset: 0x190CDE0 VA: 0x18190DBE0
	private bool <get_valueDelegates>b__101_34() { }

	[CompilerGenerated]
	// RVA: 0x190DBF0 Offset: 0x190CDF0 VA: 0x18190DBF0
	private void <get_valueDelegates>b__101_35(bool x) { }

	[CompilerGenerated]
	// RVA: 0x4EDA10 Offset: 0x4ECC10 VA: 0x1804EDA10
	private bool <get_valueDelegates>b__101_36() { }

	[CompilerGenerated]
	// RVA: 0x4EDDB0 Offset: 0x4ECFB0 VA: 0x1804EDDB0
	private void <get_valueDelegates>b__101_37(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DC00 Offset: 0x190CE00 VA: 0x18190DC00
	private bool <get_valueDelegates>b__101_38() { }

	[CompilerGenerated]
	// RVA: 0x190DC10 Offset: 0x190CE10 VA: 0x18190DC10
	private void <get_valueDelegates>b__101_39(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DC20 Offset: 0x190CE20 VA: 0x18190DC20
	private int <get_valueDelegates>b__101_40() { }

	[CompilerGenerated]
	// RVA: 0x190DC30 Offset: 0x190CE30 VA: 0x18190DC30
	private void <get_valueDelegates>b__101_41(int x) { }

	[CompilerGenerated]
	// RVA: 0x190DC40 Offset: 0x190CE40 VA: 0x18190DC40
	private bool <get_valueDelegates>b__101_42() { }

	[CompilerGenerated]
	// RVA: 0x190DC50 Offset: 0x190CE50 VA: 0x18190DC50
	private void <get_valueDelegates>b__101_43(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DC60 Offset: 0x190CE60 VA: 0x18190DC60
	private bool <get_valueDelegates>b__101_44() { }

	[CompilerGenerated]
	// RVA: 0x190DC70 Offset: 0x190CE70 VA: 0x18190DC70
	private void <get_valueDelegates>b__101_45(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DC80 Offset: 0x190CE80 VA: 0x18190DC80
	private bool <get_valueDelegates>b__101_46() { }

	[CompilerGenerated]
	// RVA: 0x190DC90 Offset: 0x190CE90 VA: 0x18190DC90
	private void <get_valueDelegates>b__101_47(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DCA0 Offset: 0x190CEA0 VA: 0x18190DCA0
	private bool <get_valueDelegates>b__101_48() { }

	[CompilerGenerated]
	// RVA: 0x190DCB0 Offset: 0x190CEB0 VA: 0x18190DCB0
	private void <get_valueDelegates>b__101_49(bool x) { }

	[CompilerGenerated]
	// RVA: 0x5B2110 Offset: 0x5B1310 VA: 0x1805B2110
	private DeadZone2DType <get_valueDelegates>b__101_50() { }

	[CompilerGenerated]
	// RVA: 0x190DCC0 Offset: 0x190CEC0 VA: 0x18190DCC0
	private void <get_valueDelegates>b__101_51(DeadZone2DType x) { }

	[CompilerGenerated]
	// RVA: 0xB82F30 Offset: 0xB82130 VA: 0x180B82F30
	private AxisSensitivity2DType <get_valueDelegates>b__101_52() { }

	[CompilerGenerated]
	// RVA: 0xB83250 Offset: 0xB82450 VA: 0x180B83250
	private void <get_valueDelegates>b__101_53(AxisSensitivity2DType x) { }

	[CompilerGenerated]
	// RVA: 0x190DCD0 Offset: 0x190CED0 VA: 0x18190DCD0
	private AxisSensitivityType <get_valueDelegates>b__101_54() { }

	[CompilerGenerated]
	// RVA: 0x190DCE0 Offset: 0x190CEE0 VA: 0x18190DCE0
	private void <get_valueDelegates>b__101_55(AxisSensitivityType x) { }

	[CompilerGenerated]
	// RVA: 0x7381D0 Offset: 0x7373D0 VA: 0x1807381D0
	private bool <get_valueDelegates>b__101_56() { }

	[CompilerGenerated]
	// RVA: 0x738B50 Offset: 0x737D50 VA: 0x180738B50
	private void <get_valueDelegates>b__101_57(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DCF0 Offset: 0x190CEF0 VA: 0x18190DCF0
	private ThrottleCalibrationMode <get_valueDelegates>b__101_58() { }

	[CompilerGenerated]
	// RVA: 0x190DD00 Offset: 0x190CF00 VA: 0x18190DD00
	private void <get_valueDelegates>b__101_59(ThrottleCalibrationMode x) { }

	[CompilerGenerated]
	// RVA: 0x7724D0 Offset: 0x7716D0 VA: 0x1807724D0
	private bool <get_valueDelegates>b__101_60() { }

	[CompilerGenerated]
	// RVA: 0x190DD10 Offset: 0x190CF10 VA: 0x18190DD10
	private void <get_valueDelegates>b__101_61(bool x) { }

	[CompilerGenerated]
	// RVA: 0x772490 Offset: 0x771690 VA: 0x180772490
	private bool <get_valueDelegates>b__101_62() { }

	[CompilerGenerated]
	// RVA: 0x190DD20 Offset: 0x190CF20 VA: 0x18190DD20
	private void <get_valueDelegates>b__101_63(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DD30 Offset: 0x190CF30 VA: 0x18190DD30
	private LogLevelFlags <get_valueDelegates>b__101_64() { }

	[CompilerGenerated]
	// RVA: 0x190DD40 Offset: 0x190CF40 VA: 0x18190DD40
	private void <get_valueDelegates>b__101_65(LogLevelFlags x) { }

	[CompilerGenerated]
	// RVA: 0x190B4B0 Offset: 0x190A6B0 VA: 0x18190B4B0
	private bool <get_valueDelegates>b__101_66() { }

	[CompilerGenerated]
	// RVA: 0x190DD50 Offset: 0x190CF50 VA: 0x18190DD50
	private void <get_valueDelegates>b__101_67(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190B4D0 Offset: 0x190A6D0 VA: 0x18190B4D0
	private bool <get_valueDelegates>b__101_68() { }

	[CompilerGenerated]
	// RVA: 0x190DD80 Offset: 0x190CF80 VA: 0x18190DD80
	private void <get_valueDelegates>b__101_69(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190B770 Offset: 0x190A970 VA: 0x18190B770
	private bool <get_valueDelegates>b__101_70() { }

	[CompilerGenerated]
	// RVA: 0x190DDB0 Offset: 0x190CFB0 VA: 0x18190DDB0
	private void <get_valueDelegates>b__101_71(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DE00 Offset: 0x190D000 VA: 0x18190DE00
	private bool <get_valueDelegates>b__101_72() { }

	[CompilerGenerated]
	// RVA: 0x190DE10 Offset: 0x190D010 VA: 0x18190DE10
	private void <get_valueDelegates>b__101_73(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190DF90 Offset: 0x190D190 VA: 0x18190DF90
	private bool <get_valueDelegates>b__101_74() { }

	[CompilerGenerated]
	// RVA: 0x190DFA0 Offset: 0x190D1A0 VA: 0x18190DFA0
	private void <get_valueDelegates>b__101_75(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190E040 Offset: 0x190D240 VA: 0x18190E040
	private bool <get_valueDelegates>b__101_76() { }

	[CompilerGenerated]
	// RVA: 0x190E050 Offset: 0x190D250 VA: 0x18190E050
	private void <get_valueDelegates>b__101_77(bool x) { }

	[CompilerGenerated]
	// RVA: 0x190E1D0 Offset: 0x190D3D0 VA: 0x18190E1D0
	private int <get_valueDelegates>b__101_78() { }

	[CompilerGenerated]
	// RVA: 0x190E310 Offset: 0x190D510 VA: 0x18190E310
	private void <get_valueDelegates>b__101_79(int x) { }

	[CompilerGenerated]
	// RVA: 0x190E450 Offset: 0x190D650 VA: 0x18190E450
	private bool <get_valueDelegates>b__101_80() { }

	[CompilerGenerated]
	// RVA: 0x190E460 Offset: 0x190D660 VA: 0x18190E460
	private void <get_valueDelegates>b__101_81(bool x) { }
}

// Namespace: Rewired.Data
public sealed class ControllerDataFiles : ScriptableObject // TypeDefIndex: 7267
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap defaultHardwareJoystickMap; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap[] hardwareJoystickMaps; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickTemplateMap[] joystickTemplates; // 0x28
	private bool CBKsTLKuaVfLuvWojKvFazgRGfhD; // 0x30
	private readonly ADictionary<Guid, WkgkbmGyRrghNJkGCDFpCiLnjOhK> CqDsneHSvpKQwdIJrzsLJPoxtTLO; // 0x38

	// Properties
	public Guid defaultHardwareJoystickMapGuid { get; }
	public HardwareJoystickTemplateMap[] JoystickTemplates { get; set; }
	public HardwareJoystickMap[] HardwareJoystickMaps { get; set; }
	public HardwareJoystickMap DefaultHardwareJoystickMap { get; set; }

	// Methods

	// RVA: 0x1912860 Offset: 0x1911A60 VA: 0x181912860
	public Guid get_defaultHardwareJoystickMapGuid() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public HardwareJoystickTemplateMap[] get_JoystickTemplates() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_JoystickTemplates(HardwareJoystickTemplateMap[] value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public HardwareJoystickMap[] get_HardwareJoystickMaps() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_HardwareJoystickMaps(HardwareJoystickMap[] value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public HardwareJoystickMap get_DefaultHardwareJoystickMap() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DefaultHardwareJoystickMap(HardwareJoystickMap value) { }

	// RVA: 0x1912070 Offset: 0x1911270 VA: 0x181912070
	public void .ctor() { }

	// RVA: 0x19117A0 Offset: 0x19109A0 VA: 0x1819117A0
	public string[] GetJoystickNames() { }

	// RVA: 0x1911100 Offset: 0x1910300 VA: 0x181911100
	public string[] GetEditorJoystickNames() { }

	// RVA: 0x1911570 Offset: 0x1910770 VA: 0x181911570
	public Guid[] GetJoystickGuids() { }

	// RVA: 0x1911B60 Offset: 0x1910D60 VA: 0x181911B60
	public string[] GetJoystickTemplateNames() { }

	// RVA: 0x1911960 Offset: 0x1910B60 VA: 0x181911960
	public Guid[] GetJoystickTemplateGuids() { }

	// RVA: 0x1911320 Offset: 0x1910520 VA: 0x181911320
	public HardwareJoystickMap GetHardwareJoystickMap(Guid guid) { }

	// RVA: 0x1911CE0 Offset: 0x1910EE0 VA: 0x181911CE0
	public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid) { }

	// RVA: 0x19110E0 Offset: 0x19102E0 VA: 0x1819110E0
	public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid) { }

	// RVA: 0x19114C0 Offset: 0x19106C0 VA: 0x1819114C0
	public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid) { }

	// RVA: 0x1912910 Offset: 0x1911B10 VA: 0x181912910
	internal ControllerTemplateElementIdentifier iFfIlXopdroLZjbuKFGTbfiFqzzI(Guid , int , out HardwareJoystickMap ) { }

	// RVA: 0x1912300 Offset: 0x1911500 VA: 0x181912300
	internal int cSJeKxTPfoFwleWrsdkCorObfuGe(Guid , Guid , int , List<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb> ) { }

	// RVA: 0x1911EA0 Offset: 0x19110A0 VA: 0x181911EA0
	internal HardwareJoystickMap_InputManager OTcypMTcLnHbOYbBwirIIMdeyBbnA(Guid , InputSource ) { }

	// RVA: 0x1912470 Offset: 0x1911670 VA: 0x181912470
	internal HardwareJoystickMap_InputManager gDlDabEDwpdeqkIUeEQZghLgmGGgb(BridgedControllerHWInfo ) { }

	// RVA: 0x1910F20 Offset: 0x1910120 VA: 0x181910F20
	private HardwareJoystickMap_InputManager ALnHLALZYoetVHpFUJLHpeEGAUfD(HardwareJoystickMap , BridgedControllerHWInfo , bool , out InputPlatform , out int , out HardwareJoystickMap.Platform ) { }

	// RVA: 0x1912110 Offset: 0x1911310 VA: 0x181912110
	private HardwareJoystickMap_InputManager baVDBsKuNmtCsmqupMHysiJFFUEWA(BridgedControllerHWInfo , string ) { }

	// RVA: 0x1911E40 Offset: 0x1911040 VA: 0x181911E40
	private HardwareJoystickMap_InputManager JwaozCjQGpVOsmNIkswGmVqHMJxE(BridgedControllerHWInfo ) { }

	// RVA: 0x1912C20 Offset: 0x1911E20 VA: 0x181912C20
	internal WkgkbmGyRrghNJkGCDFpCiLnjOhK zvHMmvRhYCPSHoAUQxoDuKpVEWxH(Guid ) { }

	// RVA: 0x1912C00 Offset: 0x1911E00 VA: 0x181912C00
	internal IHardwareControllerTemplateMap lJpGuoSIfygSRXvQQgEygTlRjBir(Guid ) { }

	// RVA: 0x1911040 Offset: 0x1910240 VA: 0x181911040
	private void FxYWYbxQZXFQCQdttKVLeGpqhKYw() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public abstract class CustomController_Editor.Element // TypeDefIndex: 7268
{
	// Fields
	public int elementIdentifierId; // 0x10
	public string name; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1925090 Offset: 0x1924290 VA: 0x181925090
	public void .ctor(string , int ) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract CustomController_Editor.Element Clone();
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
[Serializable]
public sealed class CustomController_Editor.Button : CustomController_Editor.Element // TypeDefIndex: 7269
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1925010 Offset: 0x1924210 VA: 0x181925010
	public void .ctor(string ) { }

	// RVA: 0x1925090 Offset: 0x1924290 VA: 0x181925090
	public void .ctor(string , int ) { }

	// RVA: 0x1925040 Offset: 0x1924240 VA: 0x181925040
	public void .ctor(CustomController_Editor.Button ) { }

	// RVA: 0x1924F90 Offset: 0x1924190 VA: 0x181924F90 Slot: 4
	public override CustomController_Editor.Element Clone() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
[Serializable]
public sealed class CustomController_Editor.Axis : CustomController_Editor.Element // TypeDefIndex: 7270
{
	// Fields
	public AxisRange range; // 0x20
	public bool invert; // 0x24
	public float deadZone; // 0x28
	public float zero; // 0x2C
	public float min; // 0x30
	public float max; // 0x34
	public bool doNotCalibrateRange; // 0x38
	public AxisSensitivityType sensitivityType; // 0x3C
	public float sensitivity; // 0x40
	public AnimationCurve sensitivityCurve; // 0x48
	public HardwareAxisInfo axisInfo; // 0x50

	// Methods

	// RVA: 0x1924D40 Offset: 0x1923F40 VA: 0x181924D40
	public void .ctor() { }

	// RVA: 0x1924EA0 Offset: 0x19240A0 VA: 0x181924EA0
	public void .ctor(string ) { }

	[Obsolete("This constructor should not longer be used.", False)]
	// RVA: 0x1924D70 Offset: 0x1923F70 VA: 0x181924D70
	public void .ctor(string , string , string , int , AxisRange , bool , float , float , float , float , bool , HardwareAxisInfo ) { }

	// RVA: 0x1924C00 Offset: 0x1923E00 VA: 0x181924C00
	public void .ctor(CustomController_Editor.Axis ) { }

	// RVA: 0x1924AA0 Offset: 0x1923CA0 VA: 0x181924AA0 Slot: 4
	public override CustomController_Editor.Element Clone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CustomController_Editor.vdsUTzKLNaVEhsafSkYSSXRAQxeq : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 7271
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerElementIdentifier lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public CustomController_Editor nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1941530 Offset: 0x1940730 VA: 0x181941530 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19416A0 Offset: 0x19408A0 VA: 0x1819416A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19415E0 Offset: 0x19407E0 VA: 0x1819415E0 Slot: 9
	private IEnumerator<ControllerElementIdentifier> System.Collections.Generic.IEnumerable<Rewired.ControllerElementIdentifier>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19415E0 Offset: 0x19407E0 VA: 0x1819415E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data
[EditorBrowsable(1)]
[Browsable(False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public sealed class CustomController_Editor // TypeDefIndex: 7272
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _name; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _descriptiveName; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _id; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _typeGuidString; // 0x28
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _key; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerElementIdentifier> _elementIdentifiers; // 0x38
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<CustomController_Editor.Axis> _axes; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<CustomController_Editor.Button> _buttons; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _elementIdentifierIdCounter; // 0x50

	// Properties
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public int id { get; set; }
	public Guid typeGuid { get; set; }
	internal string typeGuidString { get; set; }
	public string key { get; set; }
	public List<ControllerElementIdentifier> elementIdentifiers { get; set; }
	public List<CustomController_Editor.Axis> axes { get; }
	public List<CustomController_Editor.Button> buttons { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_name(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_descriptiveName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_descriptiveName(string value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_id() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void set_id(int value) { }

	// RVA: 0x19292B0 Offset: 0x19284B0 VA: 0x1819292B0
	public Guid get_typeGuid() { }

	// RVA: 0x1929320 Offset: 0x1928520 VA: 0x181929320
	internal void set_typeGuid(Guid value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_typeGuidString() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_typeGuidString(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_key() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_key(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public List<ControllerElementIdentifier> get_elementIdentifiers() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_elementIdentifiers(List<ControllerElementIdentifier> value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public List<CustomController_Editor.Axis> get_axes() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public List<CustomController_Editor.Button> get_buttons() { }

	// RVA: 0x1929260 Offset: 0x1928460 VA: 0x181929260
	public int get_buttonCount() { }

	// RVA: 0x1929210 Offset: 0x1928410 VA: 0x181929210
	public int get_axisCount() { }

	// RVA: 0x1929190 Offset: 0x1928390 VA: 0x181929190
	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x19290B0 Offset: 0x19282B0 VA: 0x1819290B0
	public void .ctor() { }

	// RVA: 0x1928C30 Offset: 0x1927E30 VA: 0x181928C30
	public void .ctor(CustomController_Editor ) { }

	// RVA: 0x19260E0 Offset: 0x19252E0 VA: 0x1819260E0
	public CustomController_Editor Clone() { }

	// RVA: 0x1927B00 Offset: 0x1926D00 VA: 0x181927B00
	public string[] GetElementIdentifierNames() { }

	// RVA: 0x19277B0 Offset: 0x19269B0 VA: 0x1819277B0
	public int[] GetElementIdentifierIds() { }

	// RVA: 0x1927890 Offset: 0x1926A90 VA: 0x181927890
	public string[] GetElementIdentifierNamesTypeSorted() { }

	// RVA: 0x1927520 Offset: 0x1926720 VA: 0x181927520
	public int[] GetElementIdentifierIdsTypeSorted() { }

	// RVA: 0x1927C60 Offset: 0x1926E60 VA: 0x181927C60
	public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted() { }

	// RVA: 0x1926140 Offset: 0x1925340 VA: 0x181926140
	public bool ContainsElementIdentifier(int id) { }

	// RVA: 0x1928080 Offset: 0x1927280 VA: 0x181928080
	public int IndexOfElementIdentifier(int id) { }

	// RVA: 0x1927BF0 Offset: 0x1926DF0 VA: 0x181927BF0
	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	// RVA: 0x19271D0 Offset: 0x19263D0 VA: 0x1819271D0
	internal ControllerElementType GetEffectiveElementIdentifierType(int elementIdentifierId) { }

	// RVA: 0x19270A0 Offset: 0x19262A0 VA: 0x1819270A0
	internal bool GetEffectiveAxisRange(int elementIdentifierId, out AxisRange axisRange) { }

	// RVA: 0x1926FB0 Offset: 0x19261B0 VA: 0x181926FB0
	public string[] GetButtonNames() { }

	// RVA: 0x1926ED0 Offset: 0x19260D0 VA: 0x181926ED0
	public int[] GetButtonElementIdentifierIds() { }

	// RVA: 0x1926DE0 Offset: 0x1925FE0 VA: 0x181926DE0
	public string[] GetAxisNames() { }

	// RVA: 0x1926D00 Offset: 0x1925F00 VA: 0x181926D00
	public int[] GetAxisElementIdentifierIds() { }

	// RVA: -1 Offset: -1
	public string[] GetElementNames<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951A50 Offset: 0x950C50 VA: 0x180951A50
	|-CustomController_Editor.GetElementNames<object>
	*/

	// RVA: 0x1927EC0 Offset: 0x19270C0 VA: 0x181927EC0
	public string[] GetElementNames(ControllerElementType type) { }

	// RVA: 0x1927330 Offset: 0x1926530 VA: 0x181927330
	public int[] GetElementElementIdentifierIds(ControllerElementType type) { }

	// RVA: -1 Offset: -1
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951B80 Offset: 0x950D80 VA: 0x180951B80
	|-CustomController_Editor.GetElement<object>
	*/

	// RVA: 0x1925F50 Offset: 0x1925150 VA: 0x181925F50
	public void AddElement(ControllerElementType type) { }

	// RVA: 0x1925D90 Offset: 0x1924F90 VA: 0x181925D90
	public void AddAxis() { }

	// RVA: 0x1925E70 Offset: 0x1925070 VA: 0x181925E70
	public void AddButton() { }

	// RVA: 0x1928350 Offset: 0x1927550 VA: 0x181928350
	public void InsertElement(ControllerElementType type, int index) { }

	// RVA: 0x1928130 Offset: 0x1927330 VA: 0x181928130
	public void InsertAxis(int index) { }

	// RVA: 0x1928240 Offset: 0x1927440 VA: 0x181928240
	public void InsertButton(int index) { }

	// RVA: 0x1926B90 Offset: 0x1925D90 VA: 0x181926B90
	public void DeleteElement(ControllerElementType type, int index) { }

	// RVA: -1 Offset: -1
	public void DeleteElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9516F0 Offset: 0x9508F0 VA: 0x1809516F0
	|-CustomController_Editor.DeleteElement<object>
	*/

	// RVA: 0x1928B20 Offset: 0x1927D20 VA: 0x181928B20
	public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1926C40 Offset: 0x1925E40 VA: 0x181926C40
	public void DuplicateElement(ControllerElementType type, int index) { }

	// RVA: -1 Offset: -1
	private void TQLnmcxGDDbsmJBOkkdFfplbENbC<>(int , List<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951E00 Offset: 0x951000 VA: 0x180951E00
	|-CustomController_Editor.TQLnmcxGDDbsmJBOkkdFfplbENbC<object>
	*/

	// RVA: 0x1928540 Offset: 0x1927740 VA: 0x181928540
	private ControllerElementIdentifier KmbSyzMaqwClYPgeNQeUWHXyqAeb(int , string ) { }

	// RVA: 0x1928830 Offset: 0x1927A30 VA: 0x181928830
	private CustomController_Editor.Element KzUdsEYmUNNyycxNJIggTrUKqVnd(ControllerElementType ) { }

	// RVA: 0x1927F30 Offset: 0x1927130 VA: 0x181927F30
	private ControllerElementIdentifier HwWYTnyEjfvqbRthgxBnvxqVOvjS(ControllerElementType , string , string , string , string , string , string ) { }

	// RVA: 0x19261F0 Offset: 0x19253F0 VA: 0x1819261F0
	internal HardwareControllerMap_Game CreateGameHardwareMap() { }
}

// Namespace: Rewired.Data
public class EditorSettings : ScriptableObject // TypeDefIndex: 7273
{
	// Fields
	[CustomObfuscation(rename = False)]
	public int programVersion1; // 0x18
	[CustomObfuscation(rename = False)]
	public int programVersion2; // 0x1C
	[CustomObfuscation(rename = False)]
	public int programVersion3; // 0x20
	[CustomObfuscation(rename = False)]
	public int programVersion4; // 0x24
	[CustomObfuscation(rename = False)]
	public int dataVersion; // 0x28

	// Methods

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: Rewired.Data
public class RuntimeData : ScriptableObject // TypeDefIndex: 7274
{
	// Fields
	[CustomObfuscation(rename = False)]
	public Platform platform; // 0x18
	[CustomObfuscation(rename = False)]
	public WebplayerPlatform webplayerPlatform; // 0x1C
	[CustomObfuscation(rename = False)]
	public EditorPlatform editorPlatform; // 0x20
	[CustomObfuscation(rename = False)]
	public List<TextAsset> libraries; // 0x28

	// Methods

	// RVA: 0x192A920 Offset: 0x1929B20 VA: 0x18192A920
	public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class EditorPlatformData.Platform // TypeDefIndex: 7275
{
	// Fields
	public TextAsset[] libraries; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Data
public class EditorPlatformData : ScriptableObject // TypeDefIndex: 7276
{
	// Fields
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform windowsStandalone; // 0x18
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform windowsStore; // 0x20
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform osxStandalone; // 0x28
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform linuxStandalone; // 0x30
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform webplayer; // 0x38
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform fallback; // 0x40

	// Methods

	// RVA: 0x1929340 Offset: 0x1928540 VA: 0x181929340
	public TextAsset[] GetLibraries(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

	// RVA: 0x19293C0 Offset: 0x19285C0 VA: 0x1819293C0
	public EditorPlatformData.Platform GetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public sealed class Player_Editor.Mapping // TypeDefIndex: 7277
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _enabled; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _categoryId; // 0x14
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _layoutId; // 0x18

	// Properties
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_categoryId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void agwrqjwkphLyJewepWkOzIeySpDg(int ) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_layoutId() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void JtcdVSQbvatVgRVnyQjilPdaoaFV(int ) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void pVwBlQCdIvbswBOmigolqtlFSvtxc(bool ) { }

	// RVA: 0x1929580 Offset: 0x1928780 VA: 0x181929580
	public void .ctor() { }

	// RVA: 0x1929530 Offset: 0x1928730 VA: 0x181929530
	public void .ctor(bool , int , int ) { }

	// RVA: 0x1929420 Offset: 0x1928620 VA: 0x181929420
	public void Clear() { }

	// RVA: 0x1929430 Offset: 0x1928630 VA: 0x181929430
	public Player_Editor.Mapping Clone() { }

	// RVA: 0x19294B0 Offset: 0x19286B0 VA: 0x1819294B0
	internal EOUWaxCVQTNDomlxVsogCIpJuUVB NUCasnGAGLOcoXspowPPqufhegDG() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public sealed class Player_Editor.ControllerMapLayoutManagerSettings : IDeepCloneable // TypeDefIndex: 7278
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _enabled; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _loadFromUserDataStore; // 0x11
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.RuleSetMapping> _ruleSets; // 0x18

	// Properties
	public bool enabled { get; set; }
	public bool loadFromUserDataStore { get; set; }
	public List<Player_Editor.RuleSetMapping> ruleSets { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_enabled(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_loadFromUserDataStore() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_loadFromUserDataStore(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<Player_Editor.RuleSetMapping> get_ruleSets() { }

	// RVA: 0x1925CD0 Offset: 0x1924ED0 VA: 0x181925CD0
	public void set_ruleSets(List<Player_Editor.RuleSetMapping> value) { }

	// RVA: 0x1925B30 Offset: 0x1924D30 VA: 0x181925B30
	public void .ctor() { }

	// RVA: 0x1925BB0 Offset: 0x1924DB0 VA: 0x181925BB0
	public void .ctor(Player_Editor.ControllerMapLayoutManagerSettings ) { }

	// RVA: 0x1925700 Offset: 0x1924900 VA: 0x181925700
	internal ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj EErQGzNAcKJttbOwWKeqQiowhPOA() { }

	// RVA: 0x19259F0 Offset: 0x1924BF0 VA: 0x1819259F0
	private NAbWnuemoUtDRnJvbekVDdUYjrWbb[] ZkLreXHBNViqOXwTjXrXSebsjKtD() { }

	// RVA: 0x19258A0 Offset: 0x1924AA0 VA: 0x1819258A0 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public sealed class Player_Editor.ControllerMapEnablerSettings : IDeepCloneable // TypeDefIndex: 7279
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _enabled; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.RuleSetMapping> _ruleSets; // 0x18

	// Properties
	public bool enabled { get; set; }
	public List<Player_Editor.RuleSetMapping> ruleSets { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_enabled(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<Player_Editor.RuleSetMapping> get_ruleSets() { }

	// RVA: 0x1925680 Offset: 0x1924880 VA: 0x181925680
	public void set_ruleSets(List<Player_Editor.RuleSetMapping> value) { }

	// RVA: 0x19254F0 Offset: 0x19246F0 VA: 0x1819254F0
	public void .ctor() { }

	// RVA: 0x1925570 Offset: 0x1924770 VA: 0x181925570
	public void .ctor(Player_Editor.ControllerMapEnablerSettings ) { }

	// RVA: 0x19250D0 Offset: 0x19242D0 VA: 0x1819250D0
	internal ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC EErQGzNAcKJttbOwWKeqQiowhPOA() { }

	// RVA: 0x19253B0 Offset: 0x19245B0 VA: 0x1819253B0
	private NAbWnuemoUtDRnJvbekVDdUYjrWbb[] ZkLreXHBNViqOXwTjXrXSebsjKtD() { }

	// RVA: 0x1925270 Offset: 0x1924470 VA: 0x181925270 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
[Serializable]
public sealed class Player_Editor.RuleSetMapping : IDeepCloneable // TypeDefIndex: 7280
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _enabled; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _id; // 0x14

	// Properties
	public int id { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_id() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void pVwBlQCdIvbswBOmigolqtlFSvtxc(bool ) { }

	// RVA: 0x192A880 Offset: 0x1929A80 VA: 0x18192A880
	public void .ctor() { }

	// RVA: 0x192A7B0 Offset: 0x19299B0 VA: 0x18192A7B0
	public void .ctor(Player_Editor.RuleSetMapping ) { }

	// RVA: 0x192A840 Offset: 0x1929A40 VA: 0x18192A840
	public void .ctor(bool , int ) { }

	// RVA: 0x192A670 Offset: 0x1929870 VA: 0x18192A670
	public void Clear() { }

	// RVA: 0x192A680 Offset: 0x1929880 VA: 0x18192A680
	public Player_Editor.RuleSetMapping Clone() { }

	// RVA: 0x192A8B0 Offset: 0x1929AB0 VA: 0x18192A8B0
	internal NAbWnuemoUtDRnJvbekVDdUYjrWbb waGKeokIQRPOtyUcDGwSTydsEtaV() { }

	// RVA: 0x192A6F0 Offset: 0x19298F0 VA: 0x18192A6F0 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
[Serializable]
public sealed class Player_Editor.CreateControllerInfo // TypeDefIndex: 7281
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _sourceId; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _tag; // 0x18

	// Properties
	public int sourceId { get; set; }
	public string tag { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_sourceId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void lCDBfzOwwNKJdBGLQaxlvjJenLsI(int ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_tag() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void OsUxSQImoBjJZBOdMrvXsgaXznomA(string ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x7B8500 Offset: 0x7B7700 VA: 0x1807B8500
	public void .ctor(int , string ) { }

	// RVA: 0x1925D50 Offset: 0x1924F50 VA: 0x181925D50
	public void .ctor(Player_Editor.CreateControllerInfo ) { }
}

// Namespace: Rewired.Data
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public sealed class Player_Editor // TypeDefIndex: 7282
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
	private string _descriptiveName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _startPlaying; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.Mapping> _defaultJoystickMaps; // 0x38
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.Mapping> _defaultMouseMaps; // 0x40
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.Mapping> _defaultKeyboardMaps; // 0x48
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<Player_Editor.Mapping> _defaultCustomControllerMaps; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.CreateControllerInfo> _startingCustomControllers; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _assignMouseOnStart; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _assignKeyboardOnStart; // 0x61
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _excludeFromControllerAutoAssignment; // 0x62
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private Player_Editor.ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; // 0x68
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private Player_Editor.ControllerMapEnablerSettings _controllerMapEnablerSettings; // 0x70

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public string key { get; set; }
	public bool startPlaying { get; set; }
	public List<Player_Editor.Mapping> defaultJoystickMaps { get; set; }
	public List<Player_Editor.Mapping> defaultMouseMaps { get; set; }
	public List<Player_Editor.Mapping> defaultKeyboardMaps { get; set; }
	public List<Player_Editor.Mapping> defaultCustomControllerMaps { get; set; }
	public List<Player_Editor.CreateControllerInfo> startingCustomControllers { get; set; }
	public bool assignMouseOnStart { get; set; }
	public bool assignKeyboardOnStart { get; set; }
	public bool excludeFromControllerAutoAssignment { get; set; }
	public Player_Editor.ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings { get; set; }
	public Player_Editor.ControllerMapEnablerSettings controllerMapEnablerSettings { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_descriptiveName() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void OjMQUSgFKAEHGVWwqkldsuOHOtEt(string ) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_key() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void IQWWRHlTEbfsugQDrnuadMGeayzfA(string ) { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_startPlaying() { }

	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	internal void UFkhQWqMljMLDWegBRLdBbFVpFor(bool ) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public List<Player_Editor.Mapping> get_defaultJoystickMaps() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void gwOGiUduufkZeAznSoeMhQcphwVDb(List<Player_Editor.Mapping> ) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public List<Player_Editor.Mapping> get_defaultMouseMaps() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void NHedNubwQCCzGGtPASRIDwnFgQDcE(List<Player_Editor.Mapping> ) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public List<Player_Editor.Mapping> get_defaultKeyboardMaps() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	internal void pyGDVzErELYPpePvdjKmVlPgwaQWA(List<Player_Editor.Mapping> ) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public List<Player_Editor.Mapping> get_defaultCustomControllerMaps() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void OqlMTTfDyVNVpMlqNCiokaqSFldpA(List<Player_Editor.Mapping> ) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public List<Player_Editor.CreateControllerInfo> get_startingCustomControllers() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void RdcevvmSzdvtMwxfDaWgAhUersKK(List<Player_Editor.CreateControllerInfo> ) { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_assignMouseOnStart() { }

	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	internal void RzzdCkFvhViwvIXRaAQtKuMTdJFW(bool ) { }

	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220
	public bool get_assignKeyboardOnStart() { }

	// RVA: 0xE5B990 Offset: 0xE5AB90 VA: 0x180E5B990
	internal void TpzgSyyfWXdYIubYVDiBKwDkhIgV(bool ) { }

	// RVA: 0x15CB1A0 Offset: 0x15CA3A0 VA: 0x1815CB1A0
	public bool get_excludeFromControllerAutoAssignment() { }

	// RVA: 0x192A660 Offset: 0x1929860 VA: 0x18192A660
	internal void fmmjxmRtpWATbPAXmNsikMYTZClv(bool ) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public Player_Editor.ControllerMapLayoutManagerSettings get_controllerMapLayoutManagerSettings() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_controllerMapLayoutManagerSettings(Player_Editor.ControllerMapLayoutManagerSettings value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public Player_Editor.ControllerMapEnablerSettings get_controllerMapEnablerSettings() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_controllerMapEnablerSettings(Player_Editor.ControllerMapEnablerSettings value) { }

	// RVA: 0x192A440 Offset: 0x1929640 VA: 0x18192A440
	public void .ctor() { }

	// RVA: 0x1929BA0 Offset: 0x1928DA0 VA: 0x181929BA0
	public void .ctor(Player_Editor ) { }

	// RVA: 0x19295A0 Offset: 0x19287A0 VA: 0x1819295A0
	public Player_Editor Clone() { }

	// RVA: 0x1929600 Offset: 0x1928800 VA: 0x181929600
	internal EzquJbHEydffWdoNsmXAduNipKns VZGgGYERMKmjlDtLpYNxrXOjfIKr() { }
}

// Namespace: 
public enum UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb // TypeDefIndex: 7283
{
	// Fields
	public int value__; // 0x0
	public const UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb origId = 0;
	public const UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb otherId = 1;
	public const UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb finalId = 2;
}

// Namespace: 
[DefaultMember("Item")]
private class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd // TypeDefIndex: 7284
{
	// Fields
	public int MUPnWpCLCOVrZoGwrsuqhvUbhwnF; // 0x10
	public int CaoNNhDEgyODKifInYoxZlUJqHRr; // 0x14
	public int xOhEcbOVLWFVFCgbifQvSDGqHzyh; // 0x18

	// Properties
	public int VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; set; }

	// Methods

	// RVA: 0x1953630 Offset: 0x1952830 VA: 0x181953630
	public int DqTTDBNrLYGAlGMLwfxhSdzmqObD(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb ) { }

	// RVA: 0x19536A0 Offset: 0x19528A0 VA: 0x1819536A0
	public void jWXOgjssRvRquBiRELbAnueIghhs(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb , int ) { }

	// RVA: 0x15E5C40 Offset: 0x15E4E40 VA: 0x1815E5C40
	public void .ctor(int , int , int ) { }

	// RVA: 0x1953710 Offset: 0x1952910 VA: 0x181953710 Slot: 3
	public override string xTIJrrrEppGrYfkImIMaadWCcTnPc() { }
}

// Namespace: 
private class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<> // TypeDefIndex: 7285
{
	// Fields
	public  mArvdiYVfJQRrqVzqomSSmUScKPR; // 0x0
	public  rFkXTyYCdzUSMkFbipkyDxdAUnhP; // 0x0
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb qaLFQQHmjiNqhmfZpbLbjVIoUwWb; // 0x0
	public IList<> XvfZYBhFmfiKsJeKMbmRAGRVoUUv; // 0x0
	public bool OWUZDAoSsBMsodYlHBUeSahkhaFhA; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor( ,  , UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd.GnAhsgQbgwaQPUxHdAkfFrkaBvFeb , IList<> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7A2A0 Offset: 0xE794A0 VA: 0x180E7A2A0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<object>..ctor
	|
	|-RVA: 0xE7A0B0 Offset: 0xE792B0 VA: 0x180E7A0B0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.WCnaIigUpwlfDpZHVOELWSoqgHybA // TypeDefIndex: 7286
{
	// Fields
	public static readonly UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.WCnaIigUpwlfDpZHVOELWSoqgHybA <>9; // 0x0
	public static Func<InputActionCategory, int> <>9__0_0; // 0x8
	public static Func<InputActionCategory, string> <>9__0_1; // 0x10
	public static Func<InputActionCategory, IList<InputActionCategory>, int> <>9__0_2; // 0x18
	public static Func<InputBehavior, int> <>9__0_4; // 0x20
	public static Func<InputBehavior, string> <>9__0_5; // 0x28
	public static Func<InputBehavior, IList<InputBehavior>, int> <>9__0_6; // 0x30
	public static Func<InputAction, int> <>9__0_8; // 0x38
	public static Func<InputAction, string> <>9__0_9; // 0x40
	public static Func<InputAction, IList<InputAction>, int> <>9__0_10; // 0x48
	public static Func<InputMapCategory, int> <>9__0_47; // 0x50
	public static Func<InputMapCategory, string> <>9__0_48; // 0x58
	public static Func<InputMapCategory, IList<InputMapCategory>, int> <>9__0_49; // 0x60
	public static Func<InputLayout, int> <>9__0_12; // 0x68
	public static Func<InputLayout, string> <>9__0_13; // 0x70
	public static Func<InputLayout, IList<InputLayout>, int> <>9__0_14; // 0x78
	public static Func<InputLayout, int> <>9__0_16; // 0x80
	public static Func<InputLayout, string> <>9__0_17; // 0x88
	public static Func<InputLayout, IList<InputLayout>, int> <>9__0_18; // 0x90
	public static Func<InputLayout, int> <>9__0_20; // 0x98
	public static Func<InputLayout, string> <>9__0_21; // 0xA0
	public static Func<InputLayout, IList<InputLayout>, int> <>9__0_22; // 0xA8
	public static Func<InputLayout, int> <>9__0_24; // 0xB0
	public static Func<InputLayout, string> <>9__0_25; // 0xB8
	public static Func<InputLayout, IList<InputLayout>, int> <>9__0_26; // 0xC0
	public static Func<CustomController_Editor, int> <>9__0_29; // 0xC8
	public static Func<CustomController_Editor, string> <>9__0_30; // 0xD0
	public static Func<CustomController_Editor, IList<CustomController_Editor>, int> <>9__0_31; // 0xD8
	public static Func<ControllerMapLayoutManager_RuleSet_Editor, int> <>9__0_33; // 0xE0
	public static Func<ControllerMapLayoutManager_RuleSet_Editor, string> <>9__0_34; // 0xE8
	public static Func<ControllerMapLayoutManager_RuleSet_Editor, IList<ControllerMapLayoutManager_RuleSet_Editor>, int> <>9__0_35; // 0xF0
	public static Func<ControllerMapEnabler_RuleSet_Editor, int> <>9__0_37; // 0xF8
	public static Func<ControllerMapEnabler_RuleSet_Editor, string> <>9__0_38; // 0x100
	public static Func<ControllerMapEnabler_RuleSet_Editor, IList<ControllerMapEnabler_RuleSet_Editor>, int> <>9__0_39; // 0x108
	public static Func<Player_Editor, int> <>9__0_41; // 0x110
	public static Func<Player_Editor, string> <>9__0_42; // 0x118
	public static Func<Player_Editor, IList<Player_Editor>, int> <>9__0_43; // 0x120
	public static Func<Player_Editor.Mapping, IList<Player_Editor.Mapping>, int> <>9__0_64; // 0x128
	public static Func<Player_Editor.CreateControllerInfo, IList<Player_Editor.CreateControllerInfo>, int> <>9__0_65; // 0x130
	public static Func<ControllerMap_Editor, int> <>9__0_66; // 0x138
	public static Func<ControllerMap_Editor, string> <>9__0_67; // 0x140
	public static Func<ActionElementMap, IList<ActionElementMap>, int> <>9__0_75; // 0x148
	public static Func<ControllerMap_Editor, int> <>9__0_76; // 0x150
	public static Func<ControllerMap_Editor, string> <>9__0_77; // 0x158
	public static Func<ActionElementMap, IList<ActionElementMap>, int> <>9__0_85; // 0x160
	public static Func<ControllerMap_Editor, int> <>9__0_86; // 0x168
	public static Func<ControllerMap_Editor, string> <>9__0_87; // 0x170
	public static Func<ActionElementMap, IList<ActionElementMap>, int> <>9__0_95; // 0x178
	public static Func<ControllerMap_Editor, int> <>9__0_96; // 0x180
	public static Func<ControllerMap_Editor, string> <>9__0_97; // 0x188
	public static Func<ActionElementMap, IList<ActionElementMap>, int> <>9__0_107; // 0x190

	// Methods

	// RVA: 0x1951220 Offset: 0x1950420 VA: 0x181951220
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1950B90 Offset: 0x194FD90 VA: 0x181950B90
	internal int EcamybLOMNhcFKSDvywuYtTLRPyH(InputActionCategory ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string RpPexhHljEZUCXVVlWFxrfMBnrSs(InputActionCategory ) { }

	// RVA: 0x1951750 Offset: 0x1950950 VA: 0x181951750
	internal int oLsCccBdkRCINWYOkSmCgcggYBifA(InputActionCategory , IList<InputActionCategory> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int UHGvujIIcALjTwHRdtFPTkuFLAIo(InputBehavior ) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string oiVnskEcnmfjGnAbqLPaWdBHoUy(InputBehavior ) { }

	// RVA: 0x1951680 Offset: 0x1950880 VA: 0x181951680
	internal int oGyxwSiBqddfDCCyUDbawAcPdtslA(InputBehavior , IList<InputBehavior> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int amoIOnzfnSfRKfVXGhTWphkJvkRX(InputAction ) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string BNoGfQMWhzMWhOOBOFSLEizrIthr(InputAction ) { }

	// RVA: 0x1951820 Offset: 0x1950A20 VA: 0x181951820
	internal int oblTIamjUPkessTNVrarQqVjETUd(InputAction , IList<InputAction> ) { }

	// RVA: 0x1950B90 Offset: 0x194FD90 VA: 0x181950B90
	internal int jqjQBIXGZNckMmiFeIqzJDCMmRXEA(InputMapCategory ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string NFzXHuqRKfwawUqlJeNsFOKejpVl(InputMapCategory ) { }

	// RVA: 0x1951B10 Offset: 0x1950D10 VA: 0x181951B10
	internal int zEtXVkfAkROjCCjSuzVZNHjrNuuG(InputMapCategory , IList<InputMapCategory> ) { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int DwPBLtlbuTTddWelwYTnjqAvGTaHA(InputLayout ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string rEQyxsKLxrCnEpHpiwzgpKiRkxBT(InputLayout ) { }

	// RVA: 0x1950E80 Offset: 0x1950080 VA: 0x181950E80
	internal int TdeBjjHQPrjZrgVPhdRctQOoBBwlB(InputLayout , IList<InputLayout> ) { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int kTLKWbzDABXpYhHZrECZBwusOLjl(InputLayout ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string xnNCGCirkzBVdGlQirbuNPwRALgYb(InputLayout ) { }

	// RVA: 0x1950BB0 Offset: 0x194FDB0 VA: 0x181950BB0
	internal int HWfyuuZEmNhdphgKFvNxRXIZPAFs(InputLayout , IList<InputLayout> ) { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int fvlzGgTBFJjdJYGmchdVeLbhZIDSA(InputLayout ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string HWOGKnwiknXrFLopdffhkXTXifTk(InputLayout ) { }

	// RVA: 0x1951150 Offset: 0x1950350 VA: 0x181951150
	internal int ZirUvrtjvbIdePzUReKjlGaGdlWt(InputLayout , IList<InputLayout> ) { }

	// RVA: 0x5CEAC0 Offset: 0x5CDCC0 VA: 0x1805CEAC0
	internal int UpBdGpGJotfwuhGZFzfxlbfGbnPcb(InputLayout ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string fUznVCqkBnhFVbKyqnVPaQLEAZcMB(InputLayout ) { }

	// RVA: 0x19514E0 Offset: 0x19506E0 VA: 0x1819514E0
	internal int edMZqqRJerapIfijfYcCteYhGEVIA(InputLayout , IList<InputLayout> ) { }

	// RVA: 0x19518F0 Offset: 0x1950AF0 VA: 0x1819518F0
	internal int qHgCisSmCpYzIZgHOAkhtZZbuoHe(CustomController_Editor ) { }

	// RVA: 0x404420 Offset: 0x403620 VA: 0x180404420
	internal string jhjGEyujfXtHvknhevAyKArLuqPJ(CustomController_Editor ) { }

	// RVA: 0x1951080 Offset: 0x1950280 VA: 0x181951080
	internal int YDPAhPfzpAHfuljnJeHHKVuZhtxNA(CustomController_Editor , IList<CustomController_Editor> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int BqWfxjmfeoByChRoupffwWAPurpl(ControllerMapLayoutManager_RuleSet_Editor ) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string PAQbNIBMKDuGXkatxuMznnTihwWMA(ControllerMapLayoutManager_RuleSet_Editor ) { }

	// RVA: 0x1950DB0 Offset: 0x194FFB0 VA: 0x181950DB0
	internal int QzupMMVeWLlOVKxcqnaifYlSQPzL(ControllerMapLayoutManager_RuleSet_Editor , IList<ControllerMapLayoutManager_RuleSet_Editor> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int gVIBUGaCYumKSYRKYtfrVJGHFfpDA(ControllerMapEnabler_RuleSet_Editor ) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string TozTMIzDnGQujwswvwIQmaApasaI(ControllerMapEnabler_RuleSet_Editor ) { }

	// RVA: 0x1951A40 Offset: 0x1950C40 VA: 0x181951A40
	internal int yfpWYEBYEaHyBXVMHYkRHHGdVBm(ControllerMapEnabler_RuleSet_Editor , IList<ControllerMapEnabler_RuleSet_Editor> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int tECSDEfylIaubHIBskjHBzgqHhIs(Player_Editor ) { }

	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal string ySCcmdglMpRgSfMMWdDLJUUBrtIiA(Player_Editor ) { }

	// RVA: 0x19515B0 Offset: 0x19507B0 VA: 0x1819515B0
	internal int mfmUTdTvMhnVOoBIjOstRoizamTCA(Player_Editor , IList<Player_Editor> ) { }

	// RVA: 0x1951400 Offset: 0x1950600 VA: 0x181951400
	internal int ccyueoDAqyTzGEMdHnRrktQdjopx(Player_Editor.Mapping , IList<Player_Editor.Mapping> ) { }

	// RVA: 0x1950F50 Offset: 0x1950150 VA: 0x181950F50
	internal int WxykJtdOJXkEwBCVEBuzAqqhbzaKA(Player_Editor.CreateControllerInfo , IList<Player_Editor.CreateControllerInfo> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int VodhuWCgllnafEOxyXXTbSMFXoPgB(ControllerMap_Editor ) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string mouZeCMXFFYruFzILtBBujHOQXXB(ControllerMap_Editor ) { }

	// RVA: 0x1951280 Offset: 0x1950480 VA: 0x181951280
	internal int apPumRKKfTEWMfZkfVvtnfSxJEFp(ActionElementMap , IList<ActionElementMap> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int QysRwFOplGPkAkmpNOnhygeHXfPt(ControllerMap_Editor ) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string BOhjsRmvfzOwhiLXRzbJZCquQvwj(ControllerMap_Editor ) { }

	// RVA: 0x1950A60 Offset: 0x194FC60 VA: 0x181950A60
	internal int DVteXEgKKZtnYdvtiCfPUyxrqVyG(ActionElementMap , IList<ActionElementMap> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int UTsxWjhJdFCTjItHfblJmscQGbhL(ControllerMap_Editor ) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string MRAoNTXkmQIIKDLjDiGwVNhrBffd(ControllerMap_Editor ) { }

	// RVA: 0x1951910 Offset: 0x1950B10 VA: 0x181951910
	internal int qKNDeOjsCMfNBUDtgArkSnwCEuaWA(ActionElementMap , IList<ActionElementMap> ) { }

	// RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	internal int BYTcMVWIbyfjnCEcPYOmIBywSKGd(ControllerMap_Editor ) { }

	// RVA: 0x5A04C0 Offset: 0x59F6C0 VA: 0x1805A04C0
	internal string sgqSbYYLQkfESEQMZHejaVnhYiqNB(ControllerMap_Editor ) { }

	// RVA: 0x1950C80 Offset: 0x194FE80 VA: 0x181950C80
	internal int NPiAXEENnSOfPnqewTISEabfVNGlA(ActionElementMap , IList<ActionElementMap> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN // TypeDefIndex: 7287
{
	// Fields
	public UserData rykTrxjRYBjLHkdlpMuVkKSgJjXF; // 0x10
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> sMDbfmhVpamGVzIgKcXVMlgsDlpGA; // 0x18
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> sgyXpkcmmLynNkzNJOWqTPMZxZXd; // 0x20
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> fDjCEJnYmaiITEZhwVRpDdqdTgqs; // 0x28
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> xMBMfwYfcPkDWclSMJZhlItLaQz; // 0x30
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> LgtrtQvGUqdLXKKblWFomoDABGwT; // 0x38
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> CqwdZLasHmSYXDOatrFqqHLNbJuEA; // 0x40
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> FZPfbDwHZJXIEzqtXzlsMgSNXJyt; // 0x48
	public Func<ControllerType, List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd>> UtWLUjxpIwSFvSUeRjXtLACtAZoy; // 0x50
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> iphvHsDGArALLEkPPCllhoQILkejB; // 0x58
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> dfHCWgElYvBFajihDgogqRFBgqmTc; // 0x60
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> gqrCYxlqKJiiJfsKeBjntOlqOoqY; // 0x68
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> uVPFXsamhjRCsQwhYKpMiIeTElBX; // 0x70

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1956680 Offset: 0x1955880 VA: 0x181956680
	internal InputActionCategory xVuCNAJTRjgGnHzZcFRUDeMyhAOd(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputActionCategory> ) { }

	// RVA: 0x1956460 Offset: 0x1955660 VA: 0x181956460
	internal InputBehavior qgOvPFGkQFLveVkCxcpTCeWQRhPH(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputBehavior> ) { }

	// RVA: 0x1955E60 Offset: 0x1955060 VA: 0x181955E60
	internal InputAction lUEQGUgPrlTFsxyuZsQfppDXiMmV(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputAction> ) { }

	// RVA: 0x1956330 Offset: 0x1955530 VA: 0x181956330
	internal InputLayout nnUgeamuaUhmZCZepLkkazfHHoTdA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputLayout> ) { }

	// RVA: 0x19559B0 Offset: 0x1954BB0 VA: 0x1819559B0
	internal InputLayout SfMfEjZlOBygrfQCOICCfdsghGfZA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputLayout> ) { }

	// RVA: 0x1955D30 Offset: 0x1954F30 VA: 0x181955D30
	internal InputLayout eAWBUSPywoCYdfDbwtZUSDXaShho(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputLayout> ) { }

	// RVA: 0x1956200 Offset: 0x1955400 VA: 0x181956200
	internal InputLayout lZmFEdPkqHagLbwdWzxqKykeXIwf(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputLayout> ) { }

	// RVA: 0x1954590 Offset: 0x1953790 VA: 0x181954590
	internal List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> FSkKJsZOgeDTqPCgQMIUBCpDzINy(ControllerType ) { }

	// RVA: 0x1955AE0 Offset: 0x1954CE0 VA: 0x181955AE0
	internal CustomController_Editor dJHtIcOBQPZfIyeHIZMJeLyfIJYT(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<CustomController_Editor> ) { }

	// RVA: 0x1954620 Offset: 0x1953820 VA: 0x181954620
	internal ControllerMapLayoutManager_RuleSet_Editor LBjCtKFQtmOcZsXzHOAohzjCGCuHA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMapLayoutManager_RuleSet_Editor> ) { }

	// RVA: 0x19568A0 Offset: 0x1955AA0 VA: 0x1819568A0
	internal ControllerMapEnabler_RuleSet_Editor zesCOxHqFXvVsSyerAhUhRMfFsfqA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMapEnabler_RuleSet_Editor> ) { }

	// RVA: 0x1954E70 Offset: 0x1954070 VA: 0x181954E70
	internal Player_Editor NyEujdHvyErrQAWGqtQPtTQgaqAg(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<Player_Editor> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.DQPOgZTczeihInFfhPuQHKDWqows // TypeDefIndex: 7288
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputAction> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19450D0 Offset: 0x19442D0 VA: 0x1819450D0
	internal bool ommWVVPTqikQwledKRovvadKwREA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945170 Offset: 0x1944370 VA: 0x181945170
	internal bool xBTaVSUGlOaigYisyCATovnAarJq(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.jYBEAFgocfeOnPYLWBQSPBAzKEsd // TypeDefIndex: 7289
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.vppDISydKNURITZBICZOlnrGAQpm WuijnWQPYhYOaCBeowxUqWVbPuuM; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool nOjpBtSPhTToVMzBlJZHdhnqkCDl(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.qXkbZmEmhLSunqpBSWHWRknmfcWhb // TypeDefIndex: 7290
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.vppDISydKNURITZBICZOlnrGAQpm HKQnpLIUQSfzecTJzKguNhNpTzqV; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool BrKvhRUFjCIcqhZQsdDLeneCDmHpb(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.AeHXNdtNJNzExKZYUpoBCMdpGJYt // TypeDefIndex: 7291
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<Player_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN SbGuYxdwvjAwNnbYOQntKyVGFshk; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19428C0 Offset: 0x1941AC0 VA: 0x1819428C0
	internal void bOtpQXTncGZaaHBNOLYJXAKsYFcM(List<Player_Editor.Mapping> , List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.JmBagWIsJYoRkMDYemzPeLFekDME // TypeDefIndex: 7292
{
	// Fields
	public Player_Editor.Mapping juiocoOstmMxgFzLGqvSoOWENJhX; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.AeHXNdtNJNzExKZYUpoBCMdpGJYt ylJQEbFqYLVOkwKNRcaTcpizOSqMA; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945030 Offset: 0x1944230 VA: 0x181945030
	internal bool OlCKxdDsuFEqBNFJIZHTsNPKncyQ(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x194E210 Offset: 0x194D410 VA: 0x18194E210
	internal bool flAqebtVkxWhhhoTnturANqnxbqv(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.locNSSTDZRexynbMOSVBOKEftYtQ // TypeDefIndex: 7293
{
	// Fields
	public Player_Editor.CreateControllerInfo RvQriCbLWrMhpOFZPeSLErHymywu; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.AeHXNdtNJNzExKZYUpoBCMdpGJYt ywzqZgZHXtLGcooFIxwMIaBLwZbJ; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19542A0 Offset: 0x19534A0 VA: 0x1819542A0
	internal bool IFndhzeVKIDjkaXMUwVCgOsAKOrP(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.RsiJaoYtoishVMyzLQwnIjlySRoB // TypeDefIndex: 7294
{
	// Fields
	public int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.AeHXNdtNJNzExKZYUpoBCMdpGJYt VLkbbDnLwpHKqoawEsIADjJKEpYr; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool OLhDvaUNeMEfIeVPbonAVmaIMQAtA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.qXYMzwNHaUvdYkVUJBqGgRAUPWFi // TypeDefIndex: 7295
{
	// Fields
	public int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.AeHXNdtNJNzExKZYUpoBCMdpGJYt itYFVlThAEGsBumsSXnPhKdEwWum; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool kVfkDRqWEjbuMscDnrASrdJzzVtj(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.XwEgKoppMvTaeAOEoRakdqmSxwMB // TypeDefIndex: 7296
{
	// Fields
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> PZfbOKPCkzkhhKnxRCJIYHkoqJqo; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN eKbaQoGtKLtGcUbQQSYIPUMcHuRsA; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19521B0 Offset: 0x19513B0 VA: 0x1819521B0
	internal int VqfDLcTDEqOSEmSVuRpWeaqpBqZb(ControllerMap_Editor , IList<ControllerMap_Editor> ) { }

	// RVA: 0x1951BE0 Offset: 0x1950DE0 VA: 0x181951BE0
	internal ControllerMap_Editor FOiBTGePzPMPSyMaCCVRlAHwGQrPA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.qSXBJUExvaJTitOAxHqyYjeyTrnG // TypeDefIndex: 7297
{
	// Fields
	public ControllerMap_Editor RvQriCbLWrMhpOFZPeSLErHymywu; // 0x10
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> egyAjLEsPOGVCkGTzlnKCVZqmFXR; // 0x18
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> mnhOuJmADeBxCNkKZhGIGSJnXcLFA; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1950510 Offset: 0x194F710 VA: 0x181950510
	internal bool VWQBSUHCZUysxgUGStKdMtBpIwKhA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x19504E0 Offset: 0x194F6E0 VA: 0x1819504E0
	internal bool yVadJuoyvxmORoETXdkwCiICkftp(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.FJJAwppVvnDAqJUtlavTzqjLEKGdA // TypeDefIndex: 7298
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10
	public ControllerMap_Editor eHNJYtzMcJrmFwWwmKMKZsoXkKbG; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945ED0 Offset: 0x19450D0 VA: 0x181945ED0
	internal bool mkiuhSjFktaBLDoYzljeLIVeSUxy(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945E40 Offset: 0x1945040 VA: 0x181945E40
	internal bool QVUfjeHVZMOkCaDOizdRqZyywkRi(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.VRxcHHarnaFqkHXfItKDOpDjaxoC // TypeDefIndex: 7299
{
	// Fields
	public List<int> WwXGxsNxkbzKUsFrBqrbxSrZtMfy; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN GJBDdnulfPndeQUskRnDUjOIIXWO; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19507D0 Offset: 0x194F9D0 VA: 0x1819507D0
	internal InputMapCategory jsFasNfqNMLkKoMpBLkNQFdkkIAe(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<InputMapCategory> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.sfMViemTPKFvdKywzWmHWopvNxJh // TypeDefIndex: 7300
{
	// Fields
	public ActionElementMap juiocoOstmMxgFzLGqvSoOWENJhX; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.FJJAwppVvnDAqJUtlavTzqjLEKGdA FFChNjJaNYHrGOgELGzVDwAcacAsb; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945030 Offset: 0x1944230 VA: 0x181945030
	internal bool SxVyVTHfyPtCssATqhfAWAISyrUB(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.kCEEEtsuAQAwtFEDxAGEZWRshZShA // TypeDefIndex: 7301
{
	// Fields
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> PZfbOKPCkzkhhKnxRCJIYHkoqJqo; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN LohnmnKerwaeqbTHzUKQEGVdcuIHA; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1954070 Offset: 0x1953270 VA: 0x181954070
	internal int yYRJnNItPPvIqHKxMWCBGgvJVvDP(ControllerMap_Editor , IList<ControllerMap_Editor> ) { }

	// RVA: 0x1953AA0 Offset: 0x1952CA0 VA: 0x181953AA0
	internal ControllerMap_Editor uQQDCkHFgJHvLcxrzlaqeAXbmtECc(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.lGxwimuKERVDBaZbfIUGNkxRtjvp // TypeDefIndex: 7302
{
	// Fields
	public ControllerMap_Editor RvQriCbLWrMhpOFZPeSLErHymywu; // 0x10
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> jgCNceJAVdFSkdJvSeOzhMuCUkowA; // 0x18
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> FAvJpGQnWRQLJddnlSZrSTePzCYI; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1950510 Offset: 0x194F710 VA: 0x181950510
	internal bool WWGbaWvpLjNeoxsVVGBCqDOjHSaY(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x19504E0 Offset: 0x194F6E0 VA: 0x1819504E0
	internal bool moxGfAXZlahwaGXPBmSqRqqmyOdF(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.cZeRRRSHlEDAprcFvWDnfjwAgtud // TypeDefIndex: 7303
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10
	public ControllerMap_Editor eHNJYtzMcJrmFwWwmKMKZsoXkKbG; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945ED0 Offset: 0x19450D0 VA: 0x181945ED0
	internal bool AOjErMVYarzHgnKoUnhmKBzhchzB(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945E40 Offset: 0x1945040 VA: 0x181945E40
	internal bool GKIJtmYDlKrUAzIuXFgtnstZfudD(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.DIIwutSLBYrnQsBjWSEmuDreICJQ // TypeDefIndex: 7304
{
	// Fields
	public ActionElementMap juiocoOstmMxgFzLGqvSoOWENJhX; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.cZeRRRSHlEDAprcFvWDnfjwAgtud llyPlSPAwXatZCpstBCzcDXPbPCe; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945030 Offset: 0x1944230 VA: 0x181945030
	internal bool TsnVbGbahJEymPSbMnAikNnicjhx(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.LTQJhdycoVPDTuAerGaZEROfMjycA // TypeDefIndex: 7305
{
	// Fields
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> PZfbOKPCkzkhhKnxRCJIYHkoqJqo; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN sBgjFkGAgGfPVlidturIKOJhWlFx; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194E2B0 Offset: 0x194D4B0 VA: 0x18194E2B0
	internal int QeRGCAswVagJEhYxlKXtJICcSyVFA(ControllerMap_Editor , IList<ControllerMap_Editor> ) { }

	// RVA: 0x194E550 Offset: 0x194D750 VA: 0x18194E550
	internal ControllerMap_Editor owLRumSompgGXUnuaXDjYrpZGPZw(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.SxRSpfuuifHOqAnUhvGFTrfuFJyC // TypeDefIndex: 7306
{
	// Fields
	public ControllerMap_Editor RvQriCbLWrMhpOFZPeSLErHymywu; // 0x10
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> hXGgvkXTdzlPtkgNVHstbrfDWjPhA; // 0x18
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> IIKQbNJHtyrHuXFAfjuDSykwBrnS; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1950510 Offset: 0x194F710 VA: 0x181950510
	internal bool jyuDUsnuICGvvdmuqhQavnydKgqn(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x19504E0 Offset: 0x194F6E0 VA: 0x1819504E0
	internal bool LOgpAESFbmVrZxGtGiezWPDcdCOW(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.bQBzjtfnQxalbXEUpDflcqcRMNScA // TypeDefIndex: 7307
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10
	public ControllerMap_Editor eHNJYtzMcJrmFwWwmKMKZsoXkKbG; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945ED0 Offset: 0x19450D0 VA: 0x181945ED0
	internal bool VDJSApVPiwSjFNDAukNsEoSaageKA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945E40 Offset: 0x1945040 VA: 0x181945E40
	internal bool GCJbIRitszCfnGgEFINIgHRXTKvWb(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.IfDfHOdgOpNgpsZqRsyGpHQTCWYab // TypeDefIndex: 7308
{
	// Fields
	public ActionElementMap juiocoOstmMxgFzLGqvSoOWENJhX; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.bQBzjtfnQxalbXEUpDflcqcRMNScA YqgQJgJpRjdXcDLWiLvUtZMspKhoA; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945030 Offset: 0x1944230 VA: 0x181945030
	internal bool gGyJIWdXtsDTgMIZLQmjDFLkCPzgA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.OLmWiOnRayToQXyOoSDNLYAHQlMr // TypeDefIndex: 7309
{
	// Fields
	public List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> PZfbOKPCkzkhhKnxRCJIYHkoqJqo; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.rzIMUyclMLDAnuzWxOFRLyfkOZJN urgQDocPCHVLhbwXNHVXoUjwHjHK; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194F360 Offset: 0x194E560 VA: 0x18194F360
	internal int ZeiHcngtJfFFKaGuYLEdjejLIpfhA(ControllerMap_Editor , IList<ControllerMap_Editor> ) { }

	// RVA: 0x194F610 Offset: 0x194E810 VA: 0x18194F610
	internal ControllerMap_Editor sovKqwNGOVDQnGVxEStRprQJVywn(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.klTpdRbzfjxyJxuYyvfrUzdJbahE // TypeDefIndex: 7310
{
	// Fields
	public int CaoNNhDEgyODKifInYoxZlUJqHRr; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1954280 Offset: 0x1953480 VA: 0x181954280
	internal bool YnvhOxxfWYJFtRvhpsgkEjerCMv(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.ermlfblwhkWOlTchIWkLciUrTEKq // TypeDefIndex: 7311
{
	// Fields
	public ControllerMap_Editor RvQriCbLWrMhpOFZPeSLErHymywu; // 0x10
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> hBzaqokZyohobmEbfgvMMKuOdYAd; // 0x18
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> LTBtAYrVFNJFUeFrzbEOKLabkzfj; // 0x20
	public Predicate<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> DuisrIDGwJRcsrOKNLWOxbmSXgvb; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1953600 Offset: 0x1952800 VA: 0x181953600
	internal bool IZpCKmjZELgyAsUOySZSuflpdpFgb(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1950510 Offset: 0x194F710 VA: 0x181950510
	internal bool KLmaMWyzNghfCiJbxBoPAnMnXqnc(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x19504E0 Offset: 0x194F6E0 VA: 0x1819504E0
	internal bool fsiKTBkYTUaxADZcDnNSXKnAjyEC(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.JCcSuxlxbQpzfLlNgRrfikSyUKOo // TypeDefIndex: 7312
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMap_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10
	public ControllerMap_Editor eHNJYtzMcJrmFwWwmKMKZsoXkKbG; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194ADE0 Offset: 0x1949FE0 VA: 0x18194ADE0
	internal bool cFRbmFJHbdJptJMqlWYfMDjJJJPb(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945ED0 Offset: 0x19450D0 VA: 0x181945ED0
	internal bool AIsDZqvNpeVsoVlRXwJNtCBnZbut(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }

	// RVA: 0x1945E40 Offset: 0x1945040 VA: 0x181945E40
	internal bool opRuGIHmNfgqqgekYwyJcNcZTBzM(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.OMHbUZcVNIcvgSzWAnuwOdtXBZlOA // TypeDefIndex: 7313
{
	// Fields
	public ActionElementMap juiocoOstmMxgFzLGqvSoOWENJhX; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.JCcSuxlxbQpzfLlNgRrfikSyUKOo GxBvPfphoJiyWzdYpuDOXHrCBOnV; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1945030 Offset: 0x1944230 VA: 0x181945030
	internal bool CYmvFfdrrPHrfiMvJNNkzOlIuhJq(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.soLGXAeIzMkntvOvngAlzaEjAyQhA // TypeDefIndex: 7314
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMapLayoutManager_RuleSet_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.XEaDWBoBOcRiGVfbmGrJDNfefkrF // TypeDefIndex: 7315
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.soLGXAeIzMkntvOvngAlzaEjAyQhA PMNUMzwKPPHpLvEIAMewmpmjmtyp; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool cFkvrZZBbqDWbJqWLBNfuntyngnE(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.twwTwrHoPRwfIddfnruqLkqBUJuQ // TypeDefIndex: 7316
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.soLGXAeIzMkntvOvngAlzaEjAyQhA BMpnUYkyltFEQhEeumtOtypjtHpi; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool fxTFXEnsjGwUAfssJDtQrgXqkkcy(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.cCzzKrTmYtqxAeLRSHhGFpAKIfPJ // TypeDefIndex: 7317
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.soLGXAeIzMkntvOvngAlzaEjAyQhA cKSmqUByOSvtQvEqfvBgqLLoqIrI; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool OngPJFKPZKFYHtspUuXSLGrgiWxl(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.vppDISydKNURITZBICZOlnrGAQpm // TypeDefIndex: 7318
{
	// Fields
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<ControllerMapEnabler_RuleSet_Editor> hhEsRGEakdqXPzOwTLauJKIWMNGv; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.LqoSrynbprfCbWIRgKTYfKaRERafA // TypeDefIndex: 7319
{
	// Fields
	public int VutKwddmyMDcKLHtFSjXDLSMqamH; // 0x10
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.vppDISydKNURITZBICZOlnrGAQpm cHKZNLlsLZDdegrcNIsWjArtlwnm; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x194EB60 Offset: 0x194DD60 VA: 0x18194EB60
	internal bool aLkAHUTeUEAxisKwhSHzvMzkwcGO(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.QVfLCylxWKMrYpCkJNyRtylWCuuN<> // TypeDefIndex: 7320
{
	// Fields
	public Func<, int> HfVxzLJGtPEvakNpwASnRdXSHkfQ; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.QVfLCylxWKMrYpCkJNyRtylWCuuN<object>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.glVwczTsCWGfBWVOklDfmSfTLQor<> // TypeDefIndex: 7321
{
	// Fields
	public  eHNJYtzMcJrmFwWwmKMKZsoXkKbG; // 0x0
	public UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.QVfLCylxWKMrYpCkJNyRtylWCuuN<> GJBDdnulfPndeQUskRnDUjOIIXWO; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.glVwczTsCWGfBWVOklDfmSfTLQor<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool hxFYBOelXsAwDsrhGjkQEfXUotXVA(UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6D4F0 Offset: 0xE6C6F0 VA: 0x180E6D4F0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.glVwczTsCWGfBWVOklDfmSfTLQor<object>.hxFYBOelXsAwDsrhGjkQEfXUotXVA
	*/
}

// Namespace: 
private static class UserData.JJdpnDVUcMwSilVcyFPqECLakqDI // TypeDefIndex: 7322
{
	// Methods

	// RVA: 0x194AE70 Offset: 0x194A070 VA: 0x18194AE70
	public static UserData OHHKRTZeYyrfezGsSkGnOKYMDupr(UserData , UserData , bool ) { }

	[Conditional("DEBUG_IMPORT")]
	// RVA: 0x194E190 Offset: 0x194D390 VA: 0x18194E190
	private static void PsjOXadhNbdyWgISKfMPtfATJsjl(object ) { }

	// RVA: -1 Offset: -1
	private static void aDYNSnqqNQblfOGecMjsTdezLuwp<>(IList<> , IList<> , IList<> , Func<, IList<>, int> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACDE80 Offset: 0xACD080 VA: 0x180ACDE80
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.aDYNSnqqNQblfOGecMjsTdezLuwp<object>
	|
	|-RVA: 0xACD930 Offset: 0xACCB30 VA: 0x180ACD930
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.aDYNSnqqNQblfOGecMjsTdezLuwp<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void XDXeyElSobhIAXTlikocVYIrgrHu<>(string , IList<> , IList<> , IList<> , bool , List<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.gjjnZhHdDVIWFdPfvBCZOWjBbCjd> , Func<, int> , Func<, string> , Func<, IList<>, int> , Func<UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.wqaeiQvaiugvlxavaEQosfDFIwTw<>, > ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACCFD0 Offset: 0xACC1D0 VA: 0x180ACCFD0
	|-UserData.JJdpnDVUcMwSilVcyFPqECLakqDI.XDXeyElSobhIAXTlikocVYIrgrHu<object>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UserData.FxPeQSAMzdJqWvsxlEBfGKBknmceB // TypeDefIndex: 7323
{
	// Fields
	public static readonly UserData.FxPeQSAMzdJqWvsxlEBfGKBknmceB <>9; // 0x0
	public static Action<List<Player_Editor.Mapping>, int> <>9__199_0; // 0x8
	public static Action<List<Player_Editor.Mapping>, int> <>9__217_0; // 0x10
	public static Action<List<Player_Editor.Mapping>, int> <>9__233_0; // 0x18
	public static Action<List<Player_Editor.Mapping>, int> <>9__249_0; // 0x20
	public static Action<List<Player_Editor.Mapping>, int> <>9__265_0; // 0x28

	// Methods

	// RVA: 0x1946410 Offset: 0x1945610 VA: 0x181946410
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1946470 Offset: 0x1945670 VA: 0x181946470
	internal void gJuqXtAKiUHbJHJHFgAfJciGOLVS(List<Player_Editor.Mapping> , int ) { }

	// RVA: 0x1946530 Offset: 0x1945730 VA: 0x181946530
	internal void hcKsJzQdzYTyEWlZaMEqDZXOqcle(List<Player_Editor.Mapping> , int ) { }

	// RVA: 0x1946350 Offset: 0x1945550 VA: 0x181946350
	internal void WZIahKGiHiDhDtEwillITpfDkRVl(List<Player_Editor.Mapping> , int ) { }

	// RVA: 0x1946290 Offset: 0x1945490 VA: 0x181946290
	internal void NmdkEGzgUVNdFsjHmYpjsffhQhGH(List<Player_Editor.Mapping> , int ) { }

	// RVA: 0x19465F0 Offset: 0x19457F0 VA: 0x1819465F0
	internal void spFmCnYTlRsoCVxmGxgOFsRqTKdM(List<Player_Editor.Mapping> , int ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.uDKpNLStqVvlltMEFaAFDEeBKgVvA // TypeDefIndex: 7324
{
	// Fields
	public List<InputLayout> coEdOVDcwXqUkAOQCCtPlzKgGRCSb; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1957650 Offset: 0x1956850 VA: 0x181957650
	internal int DbsWgKxOoZyXUkULdfkYrlaqjsPkA(ControllerMap_Editor , ControllerMap_Editor ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.uycXFivOAOIHWflRyBqzozaWCTQEb // TypeDefIndex: 7325
{
	// Fields
	public ControllerMap_Editor ujBkUKHlhFzCkdNBYubxtnNkexKN; // 0x10
	public ControllerMap_Editor GwAjKPvsFrHLvOVddXHffYpOEEqb; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19577D0 Offset: 0x19569D0 VA: 0x1819577D0
	internal bool xGNAZkAFsSljRICfbYRAFquSTEHbA(InputLayout ) { }

	// RVA: 0x19577A0 Offset: 0x19569A0 VA: 0x1819577A0
	internal bool QdqcRozsVwxLdUeDeWUQeHFdYrGn(InputLayout ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.mVbxUbRTGWJusgArfqJMFgOiWSAc : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 7326
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x28
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x30
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x38
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x40

	// Properties
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1954340 Offset: 0x1953540 VA: 0x181954340 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1954550 Offset: 0x1953750 VA: 0x181954550 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1954490 Offset: 0x1953690 VA: 0x181954490 Slot: 9
	private IEnumerator<InputCategory> System.Collections.Generic.IEnumerable<Rewired.InputCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1954490 Offset: 0x1953690 VA: 0x181954490 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.FOfdTpBsOTfbVqdiFSLOUBoFNEJwA : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7327
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x30
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x38
	private int hhOGlWZWXmLndWOONDviWTKgCDkl; // 0x40
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x44
	private InputCategory uQSshXEVSUjwXiIkUbPEKLlCPQqA; // 0x48
	private int trDFvyqCUqsYTNmOvIHIEWeCXLYb; // 0x50

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1945F60 Offset: 0x1945160 VA: 0x181945F60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1946250 Offset: 0x1945450 VA: 0x181946250 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1946190 Offset: 0x1945390 VA: 0x181946190 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1946190 Offset: 0x1945390 VA: 0x181946190 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.dwMLDmMopZkIrrjcJupJGhvsaaIJ : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7328
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private bool fxjOhjrBWHsINEopknufrGmOtuSD; // 0x30
	public bool xsRPSddSdeMkIExWbeCEMJgLGnkFA; // 0x31
	private int IoTBIhvbwXnRqsbSrEmXHPAIBASUA; // 0x34
	public int okDbtDRiheUdgDxuvLcEvpCIrgkJ; // 0x38
	private IEnumerator<int> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x40
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x48

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1953100 Offset: 0x1952300 VA: 0x181953100 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1952CC0 Offset: 0x1951EC0 VA: 0x181952CC0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1953190 Offset: 0x1952390 VA: 0x181953190
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19530C0 Offset: 0x19522C0 VA: 0x1819530C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1953000 Offset: 0x1952200 VA: 0x181953000 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1953000 Offset: 0x1952200 VA: 0x181953000 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.GBasRjTShRvCFXTiObqwGiLOeBIx : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7329
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private string vjJakokuWtlDQhLCFZUjfnksAaew; // 0x30
	public string sghBBzbQTOzQEvvhPTTsFmhudbrgA; // 0x38
	private bool fxjOhjrBWHsINEopknufrGmOtuSD; // 0x40
	public bool xsRPSddSdeMkIExWbeCEMJgLGnkFA; // 0x41
	private InputCategory xZkIgGgBaMkIAXbGPaieAwboqhptA; // 0x48
	private IEnumerator<int> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x50
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x58

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1946BB0 Offset: 0x1945DB0 VA: 0x181946BB0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19466B0 Offset: 0x19458B0 VA: 0x1819466B0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1946C40 Offset: 0x1945E40 VA: 0x181946C40
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1946B70 Offset: 0x1945D70 VA: 0x181946B70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1946AA0 Offset: 0x1945CA0 VA: 0x181946AA0 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1946AA0 Offset: 0x1945CA0 VA: 0x181946AA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.jnYCUCswJhTqhnkQzBYklJoCgOS : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 7330
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputMapCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x28
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x30
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x38
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x40

	// Properties
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1953850 Offset: 0x1952A50 VA: 0x181953850 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1953A60 Offset: 0x1952C60 VA: 0x181953A60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19539A0 Offset: 0x1952BA0 VA: 0x1819539A0 Slot: 9
	private IEnumerator<InputMapCategory> System.Collections.Generic.IEnumerable<Rewired.InputMapCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19539A0 Offset: 0x1952BA0 VA: 0x1819539A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.YCkbfZeptmZTNayKhsFbWNnXxMeKA : IDisposable, IEnumerable, IEnumerator, IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 7331
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private string lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x30
	public int KXJihkDZBXIPMHfHdAlJEhnUfKHq; // 0x34
	private IEnumerator<int> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x38

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x19526E0 Offset: 0x19518E0 VA: 0x1819526E0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19523C0 Offset: 0x19515C0 VA: 0x1819523C0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1952770 Offset: 0x1951970 VA: 0x181952770
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19526A0 Offset: 0x19518A0 VA: 0x1819526A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19525E0 Offset: 0x19517E0 VA: 0x1819525E0 Slot: 9
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19525E0 Offset: 0x19517E0 VA: 0x1819525E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.QbuOXrgpyLFoBSgJGGiErpCcvMuT : IDisposable, IEnumerable, IEnumerator, IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 7332
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private int lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x18
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20
	private int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x28
	public int KXJihkDZBXIPMHfHdAlJEhnUfKHq; // 0x2C
	private IEnumerator<int> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x30

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1950090 Offset: 0x194F290 VA: 0x181950090
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x194FFB0 Offset: 0x194F1B0 VA: 0x18194FFB0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x194FC70 Offset: 0x194EE70 VA: 0x18194FC70 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1950040 Offset: 0x194F240 VA: 0x181950040
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194FF20 Offset: 0x194F120 VA: 0x18194FF20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x194FF60 Offset: 0x194F160 VA: 0x18194FF60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194FE60 Offset: 0x194F060 VA: 0x18194FE60 Slot: 9
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x194FE60 Offset: 0x194F060 VA: 0x18194FE60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.QpjfHvofiacrsjlvewAjdNZtpiVF : IDisposable, IEnumerable, IEnumerator, IEnumerable<string>, IEnumerator<string> // TypeDefIndex: 7333
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private string lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x30
	public int KXJihkDZBXIPMHfHdAlJEhnUfKHq; // 0x34
	private IEnumerator<int> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x38

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1950400 Offset: 0x194F600 VA: 0x181950400 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19500E0 Offset: 0x194F2E0 VA: 0x1819500E0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1950490 Offset: 0x194F690 VA: 0x181950490
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19503C0 Offset: 0x194F5C0 VA: 0x1819503C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1950300 Offset: 0x194F500 VA: 0x181950300 Slot: 9
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1950300 Offset: 0x194F500 VA: 0x181950300 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.akWTQbchgNuYlSCnlaXKPssXKjUj : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 7334
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x28
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x30
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x38
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x40

	// Properties
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19527C0 Offset: 0x19519C0 VA: 0x1819527C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1952A00 Offset: 0x1951C00 VA: 0x181952A00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1952940 Offset: 0x1951B40 VA: 0x181952940 Slot: 9
	private IEnumerator<InputCategory> System.Collections.Generic.IEnumerable<Rewired.InputCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1952940 Offset: 0x1951B40 VA: 0x181952940 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.NopfSBhTfbMaeDRDhEvVlYcLTZNHc : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7335
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int IoTBIhvbwXnRqsbSrEmXHPAIBASUA; // 0x30
	public int okDbtDRiheUdgDxuvLcEvpCIrgkJ; // 0x34
	private bool fxjOhjrBWHsINEopknufrGmOtuSD; // 0x38
	public bool xsRPSddSdeMkIExWbeCEMJgLGnkFA; // 0x39
	private InputCategory xZkIgGgBaMkIAXbGPaieAwboqhptA; // 0x40
	private IEnumerator<int> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x48
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x50

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x194F280 Offset: 0x194E480 VA: 0x18194F280 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x194EE00 Offset: 0x194E000 VA: 0x18194EE00 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x194F310 Offset: 0x194E510 VA: 0x18194F310
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194F240 Offset: 0x194E440 VA: 0x18194F240 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194F180 Offset: 0x194E380 VA: 0x18194F180 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x194F180 Offset: 0x194E380 VA: 0x18194F180 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.EBvrmyWhclvScIauNfPVkKAeJIoM : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7336
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private string VlGdwnikauLIZCytXOfnAAnNXuaNA; // 0x30
	public string fwXQkurqGseNZCWOelJRMNheCgis; // 0x38
	private bool fxjOhjrBWHsINEopknufrGmOtuSD; // 0x40
	public bool xsRPSddSdeMkIExWbeCEMJgLGnkFA; // 0x41
	private InputCategory xZkIgGgBaMkIAXbGPaieAwboqhptA; // 0x48
	private IEnumerator<int> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x50
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x58

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x19456A0 Offset: 0x19448A0 VA: 0x1819456A0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1945210 Offset: 0x1944410 VA: 0x181945210 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1945730 Offset: 0x1944930 VA: 0x181945730
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1945660 Offset: 0x1944860 VA: 0x181945660 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1945590 Offset: 0x1944790 VA: 0x181945590 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1945590 Offset: 0x1944790 VA: 0x181945590 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.cECDhiEHBuoBacrVfYKhOwXPLtIJc : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 7337
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputMapCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x28
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x30
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x38
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x40

	// Properties
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1952A40 Offset: 0x1951C40 VA: 0x181952A40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1952C80 Offset: 0x1951E80 VA: 0x181952C80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1952BC0 Offset: 0x1951DC0 VA: 0x181952BC0 Slot: 9
	private IEnumerator<InputMapCategory> System.Collections.Generic.IEnumerable<Rewired.InputMapCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1952BC0 Offset: 0x1951DC0 VA: 0x181952BC0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.NjtmtSQFnQXCRUvkqKtXURCostRN : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputCategory>, IEnumerator<InputCategory> // TypeDefIndex: 7338
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x194EC10 Offset: 0x194DE10 VA: 0x18194EC10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputCategory System.Collections.Generic.IEnumerator<Rewired.InputCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194EDC0 Offset: 0x194DFC0 VA: 0x18194EDC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x194ED00 Offset: 0x194DF00 VA: 0x18194ED00 Slot: 9
	private IEnumerator<InputCategory> System.Collections.Generic.IEnumerable<Rewired.InputCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x194ED00 Offset: 0x194DF00 VA: 0x18194ED00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.eSzRYVoRYPNMflbHqGLTHBvqvSxi : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputAction>, IEnumerator<InputAction> // TypeDefIndex: 7339
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputAction lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19533D0 Offset: 0x19525D0 VA: 0x1819533D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputAction System.Collections.Generic.IEnumerator<Rewired.InputAction>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19535C0 Offset: 0x19527C0 VA: 0x1819535C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1953500 Offset: 0x1952700 VA: 0x181953500 Slot: 9
	private IEnumerator<InputAction> System.Collections.Generic.IEnumerable<Rewired.InputAction>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1953500 Offset: 0x1952700 VA: 0x181953500 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UserData.eMyGBtUrMfjrqOfTCsGtfmpTEWqq : IDisposable, IEnumerable, IEnumerator, IEnumerable<InputMapCategory>, IEnumerator<InputMapCategory> // TypeDefIndex: 7340
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private InputMapCategory lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public UserData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19531E0 Offset: 0x19523E0 VA: 0x1819531E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private InputMapCategory System.Collections.Generic.IEnumerator<Rewired.InputMapCategory>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1953390 Offset: 0x1952590 VA: 0x181953390 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19532D0 Offset: 0x19524D0 VA: 0x1819532D0 Slot: 9
	private IEnumerator<InputMapCategory> System.Collections.Generic.IEnumerable<Rewired.InputMapCategory>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19532D0 Offset: 0x19524D0 VA: 0x1819532D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data
[Serializable]
public sealed class UserData // TypeDefIndex: 7341
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private ConfigVars configVars; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor> players; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputAction> actions; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputActionCategory> actionCategories; // 0x28
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private ActionCategoryMap actionCategoryMap; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<InputBehavior> inputBehaviors; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputMapCategory> mapCategories; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> joystickLayouts; // 0x48
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<InputLayout> keyboardLayouts; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> mouseLayouts; // 0x58
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<InputLayout> customControllerLayouts; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> joystickMaps; // 0x68
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> keyboardMaps; // 0x70
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> mouseMaps; // 0x78
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> customControllerMaps; // 0x80
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<CustomController_Editor> customControllers; // 0x88
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets; // 0x90
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets; // 0x98
	private List<InputAction> ldPniCAFiGtzHpAIefhUlxelcyKK; // 0xA0
	private bool CVvPhEMARrlXtXcxDoSTLGQSUnaR; // 0xA8
	[CompilerGenerated]
	private IList<Player_Editor> <Players_readOnly>k__BackingField; // 0xB0
	[CompilerGenerated]
	private IList<InputAction> <Actions_readOnly>k__BackingField; // 0xB8
	[CompilerGenerated]
	private IList<InputCategory> <ActionCategories_readOnly>k__BackingField; // 0xC0
	[CompilerGenerated]
	private IList<InputBehavior> <InputBehaviors_readOnly>k__BackingField; // 0xC8
	[CompilerGenerated]
	private IList<InputMapCategory> <MapCategories_readOnly>k__BackingField; // 0xD0
	[CompilerGenerated]
	private IList<InputLayout> <JoystickLayouts_readOnly>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IList<InputLayout> <KeyboardLayouts_readOnly>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IList<InputLayout> <MouseLayouts_readOnly>k__BackingField; // 0xE8
	[CompilerGenerated]
	private IList<InputLayout> <CustomControllerLayouts_readOnly>k__BackingField; // 0xF0
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <JoystickMaps_readOnly>k__BackingField; // 0xF8
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <KeyboardMaps_readOnly>k__BackingField; // 0x100
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <MouseMaps_readOnly>k__BackingField; // 0x108
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <CustomControllerMaps_readOnly>k__BackingField; // 0x110
	[CompilerGenerated]
	private IList<ControllerMapLayoutManager_RuleSet_Editor> <ControllerMapLayoutManagerRuleSets_readOnly>k__BackingField; // 0x118
	[CompilerGenerated]
	private IList<ControllerMapEnabler_RuleSet_Editor> <ControllerMapEnablerRuleSets_readOnly>k__BackingField; // 0x120
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int playerIdCounter; // 0x128
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int actionIdCounter; // 0x12C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int actionCategoryIdCounter; // 0x130
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int inputBehaviorIdCounter; // 0x134
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int mapCategoryIdCounter; // 0x138
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickLayoutIdCounter; // 0x13C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int keyboardLayoutIdCounter; // 0x140
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int mouseLayoutIdCounter; // 0x144
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int customControllerLayoutIdCounter; // 0x148
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickMapIdCounter; // 0x14C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int keyboardMapIdCounter; // 0x150
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int mouseMapIdCounter; // 0x154
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int customControllerMapIdCounter; // 0x158
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int customControllerIdCounter; // 0x15C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int controllerMapLayoutManagerSetIdCounter; // 0x160
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int controllerMapEnablerSetIdCounter; // 0x164
	private Func<int, bool> containsActionDelegate; // 0x168

	// Properties
	internal IList<Player_Editor> wTVHtzebiDctmHLmDpRnMarRQnscA { get; set; }
	internal IList<InputAction> lPaQJayBsgvxyVKhHALtVZEOiMdq { get; set; }
	internal IList<InputCategory> ixLSMBDgcraOJKkGQiQQosBhYNQGA { get; set; }
	internal IList<InputBehavior> hdMyUxeRxSSQtySmiZjbsTSJamDB { get; set; }
	internal IList<InputMapCategory> tfFDsHuygdjfrcTCAQTiiswfCvmk { get; set; }
	internal IList<InputLayout> HMarGVpmyKMbapfEIxjdZdAkdLUJA { get; set; }
	internal IList<InputLayout> aAWaRCPFdtuFAnxQUbEKGFwVMTvl { get; set; }
	internal IList<InputLayout> hPrdlkTODxhrTeEeOJTuXQRnkFKM { get; set; }
	internal IList<InputLayout> NOkWLcwMjiFUNKvWEtJtPDZNsrUA { get; set; }
	internal IList<ControllerMap_Editor> CTPGgYBspsPDWjpPiPvhuYlHjsoNB { get; set; }
	internal IList<ControllerMap_Editor> kqWzDvquFaUHgeTrrVpwllXEqXSk { get; set; }
	internal IList<ControllerMap_Editor> qSLlpQRNItVqUbpIypCbBrtXcGFn { get; set; }
	internal IList<ControllerMap_Editor> dpkmxacXyUiLAYnWfqproTwpossy { get; set; }
	internal IList<ControllerMapLayoutManager_RuleSet_Editor> tYPAiZbMrjbAoLzmUTEnEoaNAYeJA { get; set; }
	internal IList<ControllerMapEnabler_RuleSet_Editor> xxrUSULgrkiAqavxqnpSKkgQsgNV { get; set; }
	public ConfigVars ConfigVars { get; }
	internal IEnumerable<InputMapCategory> JoOZccYDfBfqaKuvCmgCLdnPdkcWA { get; }
	internal IEnumerable<InputCategory> MjaZqkqMiUpOfWXNnAefbfaHhHFo { get; }
	internal IEnumerable<InputAction> YkesfpfQSkVMITZGvLtLsZUBCbtH { get; }
	public int playerCount { get; }
	private List<InputAction> wRYXFBZgNRgWLHkzPUPiRzShgdDcA { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	internal IList<Player_Editor> RAGKxKcAzHbXJFcMvUqAcxyZoyJFA() { }

	[CompilerGenerated]
	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	private void XHDlXgXCJqdESCvtdbBSdBJBJOXsB(IList<Player_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080
	internal IList<InputAction> tjsjygqHEDCeQpeHtbtCfbEikRgAA() { }

	[CompilerGenerated]
	// RVA: 0x146AE20 Offset: 0x146A020 VA: 0x18146AE20
	private void HkbDmdHEpCmlSjpWEyCMlqabxtGY(IList<InputAction> ) { }

	[CompilerGenerated]
	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	internal IList<InputCategory> JsgpBDKVqzKIDilaabreIdUlcBwGb() { }

	[CompilerGenerated]
	// RVA: 0x718950 Offset: 0x717B50 VA: 0x180718950
	private void EYsaEQzQDbIbKhDbDbLKiiFySGTH(IList<InputCategory> ) { }

	[CompilerGenerated]
	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	internal IList<InputBehavior> aKSAsmZnlddrElolaRtexyXHqWgQ() { }

	[CompilerGenerated]
	// RVA: 0x1532B30 Offset: 0x1531D30 VA: 0x181532B30
	private void mKjGrFkqEoSUJylbezpwXFfgjxRc(IList<InputBehavior> ) { }

	[CompilerGenerated]
	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	internal IList<InputMapCategory> ykxAhgiRyCyOEiPhBFIjWmDKBYPX() { }

	[CompilerGenerated]
	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	private void khhsAQPtWyoqsxtjULECOxMIVHYl(IList<InputMapCategory> ) { }

	[CompilerGenerated]
	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	internal IList<InputLayout> oxzRQGulBEGsbmTFotMNvEJkduOEA() { }

	[CompilerGenerated]
	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	private void fNkYKWmVdeTLcYZzpMqyvSjAwjIy(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal IList<InputLayout> viKdZKjLbEUinXdRQIIAtPTgMYql() { }

	[CompilerGenerated]
	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	private void RQXfCKBuRpsiBPAgiOgmuYuMIaXP(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	internal IList<InputLayout> yQDxMLzRfUMzZxDLhUeqInJHyufv() { }

	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	private void swSsPZssdfXrWSioEFrUxoYtnEah(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x794CF0 Offset: 0x793EF0 VA: 0x180794CF0
	internal IList<InputLayout> ULSQUlnbuDdVmDzEUvLEqNgwYLVbA() { }

	[CompilerGenerated]
	// RVA: 0x7960C0 Offset: 0x7952C0 VA: 0x1807960C0
	private void WDVNWoUvkxlhFukPJCmwhqbRLECD(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0
	internal IList<ControllerMap_Editor> qzkOPJEILVAgyGGUxUHBfZOfBGcaA() { }

	[CompilerGenerated]
	// RVA: 0x7960D0 Offset: 0x7952D0 VA: 0x1807960D0
	private void QiXaDaRCxYAGBhMqWOpCAyPGMIUcA(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0
	internal IList<ControllerMap_Editor> bQiGdAapOpdoyQCLDSUPSqHpoMTjb() { }

	[CompilerGenerated]
	// RVA: 0x7960F0 Offset: 0x7952F0 VA: 0x1807960F0
	private void lxEUNeHXwUqQhlbzBEpJWPLJHrXB(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	internal IList<ControllerMap_Editor> laLAlKKkSTkwOOvHXriFkbHmjDWuA() { }

	[CompilerGenerated]
	// RVA: 0x789950 Offset: 0x788B50 VA: 0x180789950
	private void pIhwyyHIWDrVyYYPyfdJPZBydWJV(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	internal IList<ControllerMap_Editor> SmCuWWscaJyTvwCcRUqdkyIrQRgs() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void xelJmkvDNQjxIiXHSQcpOjJAjgukA(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	internal IList<ControllerMapLayoutManager_RuleSet_Editor> RQReexghQuovgTKmuCLSzKWvJrkiA() { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void qvXShbsSCrJgaECHTqRxlasLXWGw(IList<ControllerMapLayoutManager_RuleSet_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	internal IList<ControllerMapEnabler_RuleSet_Editor> mXhIXXlMnzbliRNZYNjfxWJJrum() { }

	[CompilerGenerated]
	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0
	private void oOiXVtzzYuIjSEDmCeqXSiZdMKbA(IList<ControllerMapEnabler_RuleSet_Editor> ) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ConfigVars get_ConfigVars() { }

	// RVA: 0x193CCA0 Offset: 0x193BEA0 VA: 0x18193CCA0
	internal IEnumerable<InputMapCategory> NkCFvrOOEsYRrgxmFdzARxAXQSGK(string ) { }

	// RVA: 0x19408B0 Offset: 0x193FAB0 VA: 0x1819408B0
	internal IEnumerable<InputMapCategory> sOZugKldLjEVRAunTgIVEWtavOHZb() { }

	// RVA: 0x193EC40 Offset: 0x193DE40 VA: 0x18193EC40
	internal IEnumerable<InputMapCategory> dYGcloajqxgsypJdiSWMdBXuTJOE(string ) { }

	// RVA: 0x193E950 Offset: 0x193DB50 VA: 0x18193E950
	internal IEnumerable<InputCategory> bvhBBQXcaqFLeCORPDngEqnASTfWA(string ) { }

	// RVA: 0x1940770 Offset: 0x193F970 VA: 0x181940770
	internal IEnumerable<InputCategory> qfniPlwaqhpHDOkZmIyCTJqLQCxx() { }

	// RVA: 0x193D7E0 Offset: 0x193C9E0 VA: 0x18193D7E0
	internal IEnumerable<InputCategory> VcEqibMPVYpfEVCVnXifJFqQsiCt(string ) { }

	// RVA: 0x1940280 Offset: 0x193F480 VA: 0x181940280
	internal IEnumerable<InputAction> kkgJciDFaMKUDmOfhJbMSwxfPWOO() { }

	// RVA: 0x1940530 Offset: 0x193F730 VA: 0x181940530
	internal IEnumerable<InputAction> qUOwjYdbBDzChqnGNfcqGHeYifGY(int , bool ) { }

	// RVA: 0x19404A0 Offset: 0x193F6A0 VA: 0x1819404A0
	internal IEnumerable<InputAction> qUOwjYdbBDzChqnGNfcqGHeYifGY(string , bool ) { }

	// RVA: 0x19402F0 Offset: 0x193F4F0 VA: 0x1819402F0
	internal IEnumerable<InputAction> nvhGPSipgvCYGOWDSqnMTWRVPdlU(string ) { }

	// RVA: 0x193D280 Offset: 0x193C480 VA: 0x18193D280
	internal IEnumerable<InputAction> RpsHvWdnkwHNBldFHhymrMaHfEOI(int , bool ) { }

	// RVA: 0x193D310 Offset: 0x193C510 VA: 0x18193D310
	internal IEnumerable<InputAction> RpsHvWdnkwHNBldFHhymrMaHfEOI(string , bool ) { }

	// RVA: 0x193E8C0 Offset: 0x193DAC0 VA: 0x18193E8C0
	public void .ctor() { }

	// RVA: 0x193DFC0 Offset: 0x193D1C0 VA: 0x18193DFC0
	private void .ctor(bool ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x193D3A0 Offset: 0x193C5A0 VA: 0x18193D3A0
	internal void SetDefaultValuesOnCreation() { }

	// RVA: 0x1932010 Offset: 0x1931210 VA: 0x181932010
	public List<InputAction> GetActions_Copy() { }

	// RVA: 0x1935060 Offset: 0x1934260 VA: 0x181935060
	public List<InputBehavior> GetInputBehaviors_Copy() { }

	// RVA: 0x19367E0 Offset: 0x19359E0 VA: 0x1819367E0
	public List<KeyboardMap> GetKeyboardMaps_Copy() { }

	// RVA: 0x19381E0 Offset: 0x19373E0 VA: 0x1819381E0
	public List<MouseMap> GetMouseMaps_Copy() { }

	// RVA: 0x193F3D0 Offset: 0x193E5D0 VA: 0x18193F3D0
	public int get_playerCount() { }

	// RVA: 0x192B290 Offset: 0x192A490 VA: 0x18192B290
	public void AddPlayer() { }

	// RVA: 0x193C330 Offset: 0x193B530 VA: 0x18193C330
	public void InsertPlayer(int index) { }

	// RVA: 0x192E1F0 Offset: 0x192D3F0 VA: 0x18192E1F0
	public void DeletePlayer(int index) { }

	// RVA: 0x193D210 Offset: 0x193C410 VA: 0x18193D210
	public bool ReorderPlayer(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1930760 Offset: 0x192F960 VA: 0x181930760
	public void DuplicatePlayer(int index) { }

	// RVA: 0x1938720 Offset: 0x1937920 VA: 0x181938720
	public string[] GetPlayerNames() { }

	// RVA: 0x1938820 Offset: 0x1937A20 VA: 0x181938820
	public int GetPlayerNames(IList<string> results) { }

	// RVA: 0x1938520 Offset: 0x1937720 VA: 0x181938520
	public int[] GetPlayerIds() { }

	// RVA: 0x1938A00 Offset: 0x1937C00 VA: 0x181938A00
	public int[] GetPlayerRuntimeIds() { }

	// RVA: 0x1938AC0 Offset: 0x1937CC0 VA: 0x181938AC0
	public int GetPlayerRuntimeIds(IList<int> results) { }

	// RVA: 0x1938610 Offset: 0x1937810 VA: 0x181938610
	public string GetPlayerNameById(int id) { }

	// RVA: 0x1938BE0 Offset: 0x1937DE0 VA: 0x181938BE0
	public Player_Editor GetPlayer(int index) { }

	// RVA: 0x1938430 Offset: 0x1937630 VA: 0x181938430
	public int GetPlayerId(string name) { }

	// RVA: 0x193C4B0 Offset: 0x193B6B0 VA: 0x18193C4B0
	public bool IsMouseAssigned() { }

	// RVA: 0x192BAD0 Offset: 0x192ACD0 VA: 0x18192BAD0
	public void ClearMouseAssignments() { }

	// RVA: 0x193C400 Offset: 0x193B600 VA: 0x18193C400
	public bool IsKeyboardAssigned() { }

	// RVA: 0x192BA40 Offset: 0x192AC40 VA: 0x18192BA40
	public void ClearKeyboardAssignments() { }

	// RVA: 0x193EF30 Offset: 0x193E130 VA: 0x18193EF30
	private List<InputAction> ezoefBWdcSGoTgahMrsySbNaQTieb() { }

	// RVA: 0x192AA00 Offset: 0x1929C00 VA: 0x18192AA00
	public void AddAction(int categoryId) { }

	// RVA: 0x193B910 Offset: 0x193AB10 VA: 0x18193B910
	public void InsertAction(int categoryId, int actionId) { }

	// RVA: 0x192C280 Offset: 0x192B480 VA: 0x18192C280
	public void DeleteAction(int categoryId, int actionId) { }

	// RVA: 0x193CDC0 Offset: 0x193BFC0 VA: 0x18193CDC0
	public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192E9E0 Offset: 0x192DBE0 VA: 0x18192E9E0
	public int DuplicateAction_FromButton(int categoryId, int actionId) { }

	// RVA: 0x193FD70 Offset: 0x193EF70 VA: 0x18193FD70
	private int kPCQdnqxSipVcGcCVwqNAQFzWyX(int , InputAction ) { }

	// RVA: 0x1931AA0 Offset: 0x1930CA0 VA: 0x181931AA0
	public string[] GetActionNames() { }

	// RVA: 0x1931C60 Offset: 0x1930E60 VA: 0x181931C60
	public int GetActionNames(IList<string> results) { }

	// RVA: 0x19317A0 Offset: 0x19309A0 VA: 0x1819317A0
	public int[] GetActionIds() { }

	// RVA: 0x1931520 Offset: 0x1930720 VA: 0x181931520
	public int GetActionIds(IList<int> results) { }

	// RVA: 0x1931960 Offset: 0x1930B60 VA: 0x181931960
	public string GetActionNameById(int id) { }

	// RVA: 0x1931F70 Offset: 0x1931170 VA: 0x181931F70
	public InputAction GetAction(int index) { }

	// RVA: 0x1931EE0 Offset: 0x19310E0 VA: 0x181931EE0
	public InputAction GetAction(string name) { }

	// RVA: 0x1930C00 Offset: 0x192FE00 VA: 0x181930C00
	public InputAction GetActionById(int id) { }

	// RVA: 0x1931480 Offset: 0x1930680 VA: 0x181931480
	public int GetActionId(string name) { }

	// RVA: 0x19391B0 Offset: 0x19383B0 VA: 0x1819391B0
	public string[] GetSortedActionNamesInCategory(int id) { }

	// RVA: 0x193D590 Offset: 0x193C790 VA: 0x18193D590
	public IEnumerable<string> SortedActionNamesInCategory(int id) { }

	// RVA: 0x1938C60 Offset: 0x1937E60 VA: 0x181938C60
	public string[] GetSortedActionDescriptiveNamesInCategory(int id) { }

	// RVA: 0x193D490 Offset: 0x193C690 VA: 0x18193D490
	public IEnumerable<string> SortedActionDescriptiveNamesInCategory(int id) { }

	// RVA: 0x1938EF0 Offset: 0x19380F0 VA: 0x181938EF0
	public int[] GetSortedActionIdsInCategory(int id) { }

	// RVA: 0x193D510 Offset: 0x193C710 VA: 0x18193D510
	public IEnumerable<int> SortedActionIdsInCategory(int id) { }

	// RVA: 0x192BB70 Offset: 0x192AD70 VA: 0x18192BB70
	public bool ContainsAction(int id) { }

	// RVA: 0x193A4D0 Offset: 0x19396D0 VA: 0x18193A4D0
	public int IndexOfAction(int id) { }

	// RVA: 0x193A5A0 Offset: 0x19397A0 VA: 0x18193A5A0
	public int IndexOfAction(string name) { }

	// RVA: 0x192A940 Offset: 0x1929B40 VA: 0x18192A940
	public void AddActionCategory() { }

	// RVA: 0x193B810 Offset: 0x193AA10 VA: 0x18193B810
	public void InsertActionCategory(int index) { }

	// RVA: 0x192C0B0 Offset: 0x192B2B0 VA: 0x18192C0B0
	public void DeleteActionCategory(int index) { }

	// RVA: 0x193CD20 Offset: 0x193BF20 VA: 0x18193CD20
	public bool ReorderActionCategory(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192E2A0 Offset: 0x192D4A0 VA: 0x18192E2A0
	public void DuplicateActionCategory(int index, bool duplicateActions) { }

	// RVA: 0x192B970 Offset: 0x192AB70 VA: 0x18192B970
	public void ChangeActionCategory(int actionId, int newCategoryId) { }

	// RVA: 0x1930D60 Offset: 0x192FF60 VA: 0x181930D60
	public int GetActionCategoryCount(int id) { }

	// RVA: 0x19310B0 Offset: 0x19302B0 VA: 0x1819310B0
	public int GetActionCategoryIndex(int id) { }

	// RVA: 0x1931280 Offset: 0x1930480 VA: 0x181931280
	public string[] GetActionCategoryNames() { }

	// RVA: 0x1930FC0 Offset: 0x19301C0 VA: 0x181930FC0
	public int[] GetActionCategoryIds() { }

	// RVA: 0x1931380 Offset: 0x1930580 VA: 0x181931380
	public InputCategory GetActionCategory(int index) { }

	// RVA: 0x1931400 Offset: 0x1930600 VA: 0x181931400
	public InputCategory GetActionCategory(string name) { }

	// RVA: 0x1930CF0 Offset: 0x192FEF0 VA: 0x181930CF0
	public InputCategory GetActionCategoryById(int id) { }

	// RVA: 0x1930F30 Offset: 0x1930130 VA: 0x181930F30
	public int GetActionCategoryId(string name) { }

	// RVA: 0x1931170 Offset: 0x1930370 VA: 0x181931170
	public string GetActionCategoryNameById(int id) { }

	// RVA: 0x193A410 Offset: 0x1939610 VA: 0x18193A410
	public int IndexOfActionCategory(int id) { }

	// RVA: 0x193A310 Offset: 0x1939510 VA: 0x18193A310
	public int IndexOfActionCategory(string name) { }

	// RVA: 0x1930EE0 Offset: 0x19300E0 VA: 0x181930EE0
	public int GetActionCategoryCount() { }

	// RVA: 0x192AF20 Offset: 0x192A120 VA: 0x18192AF20
	public void AddInputBehavior() { }

	// RVA: 0x193BF20 Offset: 0x193B120 VA: 0x18193BF20
	public void InsertInputBehavior(int index) { }

	// RVA: 0x192D010 Offset: 0x192C210 VA: 0x18192D010
	public void DeleteInputBehavior(int index) { }

	// RVA: 0x193CFE0 Offset: 0x193C1E0 VA: 0x18193CFE0
	public bool ReorderInputBehavior(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192F710 Offset: 0x192E910 VA: 0x18192F710
	public void DuplicateInputBehavior(int index) { }

	// RVA: 0x1934E60 Offset: 0x1934060 VA: 0x181934E60
	public string[] GetInputBehaviorNames() { }

	// RVA: 0x1934D70 Offset: 0x1933F70 VA: 0x181934D70
	public int[] GetInputBehaviorIds() { }

	// RVA: 0x1934FE0 Offset: 0x19341E0 VA: 0x181934FE0
	public InputBehavior GetInputBehavior(int index) { }

	// RVA: 0x1934F60 Offset: 0x1934160 VA: 0x181934F60
	public InputBehavior GetInputBehavior(string name) { }

	// RVA: 0x1934C20 Offset: 0x1933E20 VA: 0x181934C20
	public InputBehavior GetInputBehaviorById(int id) { }

	// RVA: 0x1934CE0 Offset: 0x1933EE0 VA: 0x181934CE0
	public int GetInputBehaviorId(string name) { }

	// RVA: 0x193B050 Offset: 0x193A250 VA: 0x18193B050
	public int IndexOfInputBehavior(int id) { }

	// RVA: 0x193AF40 Offset: 0x193A140 VA: 0x18193AF40
	public int IndexOfInputBehavior(string name) { }

	// RVA: 0x192B130 Offset: 0x192A330 VA: 0x18192B130
	public void AddMapCategory() { }

	// RVA: 0x193C190 Offset: 0x193B390 VA: 0x18193C190
	public void InsertMapCategory(int index) { }

	// RVA: 0x192D910 Offset: 0x192CB10 VA: 0x18192D910
	public void DeleteMapCategory(int index) { }

	// RVA: 0x193D130 Offset: 0x193C330 VA: 0x18193D130
	public bool ReorderMapCategory(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192FFD0 Offset: 0x192F1D0 VA: 0x18192FFD0
	public void DuplicateMapCategory(int index, bool duplicateMaps) { }

	// RVA: 0x1937350 Offset: 0x1936550 VA: 0x181937350
	public int GetMapCategoryMapCount(int id) { }

	// RVA: 0x1937290 Offset: 0x1936490 VA: 0x181937290
	public int GetMapCategoryIndex(int id) { }

	// RVA: 0x1937650 Offset: 0x1936850 VA: 0x181937650
	public string[] GetMapCategoryNames() { }

	// RVA: 0x19371A0 Offset: 0x19363A0 VA: 0x1819371A0
	public int[] GetMapCategoryIds() { }

	// RVA: 0x1937750 Offset: 0x1936950 VA: 0x181937750
	public InputMapCategory GetMapCategory(int index) { }

	// RVA: 0x19377D0 Offset: 0x19369D0 VA: 0x1819377D0
	public InputMapCategory GetMapCategory(string name) { }

	// RVA: 0x1937050 Offset: 0x1936250 VA: 0x181937050
	public InputMapCategory GetMapCategoryById(int id) { }

	// RVA: 0x1937110 Offset: 0x1936310 VA: 0x181937110
	public int GetMapCategoryId(string name) { }

	// RVA: 0x1937540 Offset: 0x1936740 VA: 0x181937540
	public string GetMapCategoryNameById(int id) { }

	// RVA: 0x193B490 Offset: 0x193A690 VA: 0x18193B490
	public int IndexOfMapCategory(int id) { }

	// RVA: 0x193B550 Offset: 0x193A750 VA: 0x18193B550
	public int IndexOfMapCategory(string name) { }

	// RVA: 0x1936FC0 Offset: 0x19361C0 VA: 0x181936FC0
	public string[] GetLayoutNames(ControllerType controllerType) { }

	// RVA: 0x1936930 Offset: 0x1935B30 VA: 0x181936930
	public int[] GetLayoutIds(ControllerType controllerType) { }

	// RVA: 0x192AFD0 Offset: 0x192A1D0 VA: 0x18192AFD0
	public void AddJoystickLayout() { }

	// RVA: 0x193BFF0 Offset: 0x193B1F0 VA: 0x18193BFF0
	public void InsertJoystickLayout(int index) { }

	// RVA: 0x192D1F0 Offset: 0x192C3F0 VA: 0x18192D1F0
	public void DeleteJoystickLayout(int index) { }

	// RVA: 0x193D050 Offset: 0x193C250 VA: 0x18193D050
	public bool ReorderJoystickLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192F8D0 Offset: 0x192EAD0 VA: 0x18192F8D0
	public void DuplicateJoystickLayout(int index, bool duplicateMaps) { }

	// RVA: 0x19354E0 Offset: 0x19346E0 VA: 0x1819354E0
	public int GetJoystickLayoutMapCount(int id) { }

	// RVA: 0x1935420 Offset: 0x1934620 VA: 0x181935420
	public int GetJoystickLayoutIndex(int id) { }

	// RVA: 0x1935690 Offset: 0x1934890 VA: 0x181935690
	public string[] GetJoystickLayoutNames() { }

	// RVA: 0x1935330 Offset: 0x1934530 VA: 0x181935330
	public int[] GetJoystickLayoutIds() { }

	// RVA: 0x1935810 Offset: 0x1934A10 VA: 0x181935810
	public InputLayout GetJoystickLayout(int index) { }

	// RVA: 0x1935790 Offset: 0x1934990 VA: 0x181935790
	public InputLayout GetJoystickLayout(string name) { }

	// RVA: 0x19351B0 Offset: 0x19343B0 VA: 0x1819351B0
	public InputLayout GetJoystickLayoutById(int id) { }

	// RVA: 0x19352A0 Offset: 0x19344A0 VA: 0x1819352A0
	public int GetJoystickLayoutId(string name) { }

	// RVA: 0x193B110 Offset: 0x193A310 VA: 0x18193B110
	public int IndexOfJoystickLayout(int id) { }

	// RVA: 0x193B1D0 Offset: 0x193A3D0 VA: 0x18193B1D0
	public int IndexOfJoystickLayout(string name) { }

	// RVA: 0x19355B0 Offset: 0x19347B0 VA: 0x1819355B0
	public string GetJoystickLayoutNameById(int id) { }

	// RVA: 0x192B080 Offset: 0x192A280 VA: 0x18192B080
	public void AddKeyboardLayout() { }

	// RVA: 0x193C0C0 Offset: 0x193B2C0 VA: 0x18193C0C0
	public void InsertKeyboardLayout(int index) { }

	// RVA: 0x192D580 Offset: 0x192C780 VA: 0x18192D580
	public void DeleteKeyboardLayout(int index) { }

	// RVA: 0x193D0C0 Offset: 0x193C2C0 VA: 0x18193D0C0
	public bool ReorderKeyboardLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192FC50 Offset: 0x192EE50 VA: 0x18192FC50
	public void DuplicateKeyboardLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1936180 Offset: 0x1935380 VA: 0x181936180
	public int GetKeyboardLayoutMapCount(int id) { }

	// RVA: 0x19360C0 Offset: 0x19352C0 VA: 0x1819360C0
	public int GetKeyboardLayoutIndex(int id) { }

	// RVA: 0x1936330 Offset: 0x1935530 VA: 0x181936330
	public string[] GetKeyboardLayoutNames() { }

	// RVA: 0x1935FD0 Offset: 0x19351D0 VA: 0x181935FD0
	public int[] GetKeyboardLayoutIds() { }

	// RVA: 0x19364B0 Offset: 0x19356B0 VA: 0x1819364B0
	public InputLayout GetKeyboardLayout(int index) { }

	// RVA: 0x1936430 Offset: 0x1935630 VA: 0x181936430
	public InputLayout GetKeyboardLayout(string name) { }

	// RVA: 0x1935E50 Offset: 0x1935050 VA: 0x181935E50
	public InputLayout GetKeyboardLayoutById(int id) { }

	// RVA: 0x1935F40 Offset: 0x1935140 VA: 0x181935F40
	public int GetKeyboardLayoutId(string name) { }

	// RVA: 0x193B2D0 Offset: 0x193A4D0 VA: 0x18193B2D0
	public int IndexOfKeyboardLayout(int id) { }

	// RVA: 0x193B390 Offset: 0x193A590 VA: 0x18193B390
	public int IndexOfKeyboardLayout(string name) { }

	// RVA: 0x1936250 Offset: 0x1935450 VA: 0x181936250
	public string GetKeyboardLayoutNameById(int id) { }

	// RVA: 0x192B1E0 Offset: 0x192A3E0 VA: 0x18192B1E0
	public void AddMouseLayout() { }

	// RVA: 0x193C260 Offset: 0x193B460 VA: 0x18193C260
	public void InsertMouseLayout(int index) { }

	// RVA: 0x192DE60 Offset: 0x192D060 VA: 0x18192DE60
	public void DeleteMouseLayout(int index) { }

	// RVA: 0x193D1A0 Offset: 0x193C3A0 VA: 0x18193D1A0
	public bool ReorderMouseLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x19303E0 Offset: 0x192F5E0 VA: 0x1819303E0
	public void DuplicateMouseLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1937B80 Offset: 0x1936D80 VA: 0x181937B80
	public int GetMouseLayoutMapCount(int id) { }

	// RVA: 0x1937AC0 Offset: 0x1936CC0 VA: 0x181937AC0
	public int GetMouseLayoutIndex(int id) { }

	// RVA: 0x1937D30 Offset: 0x1936F30 VA: 0x181937D30
	public string[] GetMouseLayoutNames() { }

	// RVA: 0x19379D0 Offset: 0x1936BD0 VA: 0x1819379D0
	public int[] GetMouseLayoutIds() { }

	// RVA: 0x1937E30 Offset: 0x1937030 VA: 0x181937E30
	public InputLayout GetMouseLayout(int index) { }

	// RVA: 0x1937EB0 Offset: 0x19370B0 VA: 0x181937EB0
	public InputLayout GetMouseLayout(string name) { }

	// RVA: 0x1937850 Offset: 0x1936A50 VA: 0x181937850
	public InputLayout GetMouseLayoutById(int id) { }

	// RVA: 0x1937940 Offset: 0x1936B40 VA: 0x181937940
	public int GetMouseLayoutId(string name) { }

	// RVA: 0x193B750 Offset: 0x193A950 VA: 0x18193B750
	public int IndexOfMouseLayout(int id) { }

	// RVA: 0x193B650 Offset: 0x193A850 VA: 0x18193B650
	public int IndexOfMouseLayout(string name) { }

	// RVA: 0x1937C50 Offset: 0x1936E50 VA: 0x181937C50
	public string GetMouseLayoutNameById(int id) { }

	// RVA: 0x192AC40 Offset: 0x1929E40 VA: 0x18192AC40
	public void AddCustomControllerLayout() { }

	// RVA: 0x193BBD0 Offset: 0x193ADD0 VA: 0x18193BBD0
	public void InsertCustomControllerLayout(int index) { }

	// RVA: 0x192CAC0 Offset: 0x192BCC0 VA: 0x18192CAC0
	public void DeleteCustomControllerLayout(int index) { }

	// RVA: 0x193CEF0 Offset: 0x193C0F0 VA: 0x18193CEF0
	public bool ReorderCustomControllerLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192F020 Offset: 0x192E220 VA: 0x18192F020
	public void DuplicateCustomControllerLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1934000 Offset: 0x1933200 VA: 0x181934000
	public int GetCustomControllerLayoutMapCount(int id) { }

	// RVA: 0x1933F40 Offset: 0x1933140 VA: 0x181933F40
	public int GetCustomControllerLayoutIndex(int id) { }

	// RVA: 0x19341B0 Offset: 0x19333B0 VA: 0x1819341B0
	public string[] GetCustomControllerLayoutNames() { }

	// RVA: 0x1933E50 Offset: 0x1933050 VA: 0x181933E50
	public int[] GetCustomControllerLayoutIds() { }

	// RVA: 0x1934330 Offset: 0x1933530 VA: 0x181934330
	public InputLayout GetCustomControllerLayout(int index) { }

	// RVA: 0x19342B0 Offset: 0x19334B0 VA: 0x1819342B0
	public InputLayout GetCustomControllerLayout(string name) { }

	// RVA: 0x1933CD0 Offset: 0x1932ED0 VA: 0x181933CD0
	public InputLayout GetCustomControllerLayoutById(int id) { }

	// RVA: 0x1933DC0 Offset: 0x1932FC0 VA: 0x181933DC0
	public int GetCustomControllerLayoutId(string name) { }

	// RVA: 0x193AB70 Offset: 0x1939D70 VA: 0x18193AB70
	public int IndexOfCustomControllerLayout(int id) { }

	// RVA: 0x193AA70 Offset: 0x1939C70 VA: 0x18193AA70
	public int IndexOfCustomControllerLayout(string name) { }

	// RVA: 0x19340D0 Offset: 0x19332D0 VA: 0x1819340D0
	public string GetCustomControllerLayoutNameById(int id) { }

	// RVA: 0x1936CD0 Offset: 0x1935ED0 VA: 0x181936CD0
	public string GetLayoutNameById(ControllerType controllerType, int id) { }

	// RVA: 0x193D860 Offset: 0x193CA60 VA: 0x18193D860
	internal ControllerMap XJLfeMIaFBXEHXncNThAJrgCmPWx(Controller , int , int ) { }

	// RVA: 0x1935B00 Offset: 0x1934D00 VA: 0x181935B00
	public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x1935890 Offset: 0x1934A90 VA: 0x181935890
	public ControllerMap_Editor GetJoystickMapById(int id, out int joystickMapIndex) { }

	// RVA: 0x1935CA0 Offset: 0x1934EA0 VA: 0x181935CA0
	public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid) { }

	// RVA: 0x1935960 Offset: 0x1934B60 VA: 0x181935960
	public int GetJoystickMapId(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x1939AB0 Offset: 0x1938CB0 VA: 0x181939AB0
	public bool HasJoystickMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x19399A0 Offset: 0x1938BA0 VA: 0x1819399A0
	public bool HasJoystickMap(Guid hardwareGuid) { }

	// RVA: 0x1939850 Offset: 0x1938A50 VA: 0x181939850
	public bool HasJoystickMapInCategory(Guid hardwareGuid, int categoryId) { }

	// RVA: 0x192BD00 Offset: 0x192AF00 VA: 0x18192BD00
	public bool CreateJoystickMap(int categoryId, Guid joystickOrTemplateGuid, int layoutId) { }

	// RVA: 0x192D4C0 Offset: 0x192C6C0 VA: 0x18192D4C0
	public void DeleteJoystickMap(int id) { }

	// RVA: 0x192FB40 Offset: 0x192ED40 VA: 0x18192FB40
	public int DuplicateJoystickMap(int index) { }

	// RVA: 0x193CBE0 Offset: 0x193BDE0 VA: 0x18193CBE0
	internal JoystickMap LjwCLEIwsKGJfESHUcdoetbDnTzaA(HardwareControllerMapIdentifier , int , int ) { }

	// RVA: 0x193FB60 Offset: 0x193ED60 VA: 0x18193FB60
	internal JoystickMap iqGbQTHQvGJuutNFpxlgWfRsruSC(Joystick , int , int ) { }

	// RVA: 0x193F4F0 Offset: 0x193E6F0 VA: 0x18193F4F0
	private JoystickMap iqGbQTHQvGJuutNFpxlgWfRsruSC(HardwareControllerMapIdentifier , int , int ) { }

	// RVA: 0x193E8D0 Offset: 0x193DAD0 VA: 0x18193E8D0
	private ControllerMap_Editor aGmcXCbeHzZUCozFpEwqDdtzeILL(int , Guid , int , bool ) { }

	// RVA: 0x193F140 Offset: 0x193E340 VA: 0x18193F140
	private ControllerMap_Editor fzSDtQRmfQQwFUynLqUkImPsORZJ(int , Guid , int ) { }

	// RVA: 0x193FFD0 Offset: 0x193F1D0 VA: 0x18193FFD0
	private JoystickMap kaobPDaUDfKAjFKmKVIMoFMfRgcH(HardwareControllerMapIdentifier , ControllerMap_Editor , HardwareJoystickTemplateMap , HardwareJoystickMap , int , int ) { }

	// RVA: 0x192B340 Offset: 0x192A540 VA: 0x18192B340
	private JoystickMap BYNDDJJmBpltBhJVRFBBLExfulST(JoystickMap , HardwareControllerMapIdentifier ) { }

	// RVA: 0x1936700 Offset: 0x1935900 VA: 0x181936700
	public ControllerMap_Editor GetKeyboardMap(int categoryId, int layoutId) { }

	// RVA: 0x1936600 Offset: 0x1935800 VA: 0x181936600
	public int GetKeyboardMapId(int categoryId, int layoutId) { }

	// RVA: 0x1939DB0 Offset: 0x1938FB0 VA: 0x181939DB0
	public bool HasKeyboardMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x192BE50 Offset: 0x192B050 VA: 0x18192BE50
	public bool CreateKeyboardMap(int categoryId, int layoutId) { }

	// RVA: 0x192D850 Offset: 0x192CA50 VA: 0x18192D850
	public void DeleteKeyboardMap(int id) { }

	// RVA: 0x192FEC0 Offset: 0x192F0C0 VA: 0x18192FEC0
	public int DuplicateKeyboardMap(int index) { }

	// RVA: 0x1936530 Offset: 0x1935730 VA: 0x181936530
	public ControllerMap_Editor GetKeyboardMapById(int id, out int keyboardMapIndex) { }

	// RVA: 0x1930940 Offset: 0x192FB40 VA: 0x181930940
	public KeyboardMap FindKeyboardMap_Game(Keyboard keyboard, int categoryId, int layoutId) { }

	// RVA: 0x1939C30 Offset: 0x1938E30 VA: 0x181939C30
	public bool HasKeyboardMapInCategory(int categoryId) { }

	// RVA: 0x1939CE0 Offset: 0x1938EE0 VA: 0x181939CE0
	public bool HasKeyboardMapInLayout(int categoryId, int layoutId) { }

	// RVA: 0x1938100 Offset: 0x1937300 VA: 0x181938100
	public ControllerMap_Editor GetMouseMap(int categoryId, int layoutId) { }

	// RVA: 0x1938000 Offset: 0x1937200 VA: 0x181938000
	public int GetMouseMapId(int categoryId, int layoutId) { }

	// RVA: 0x193A0B0 Offset: 0x19392B0 VA: 0x18193A0B0
	public bool HasMouseMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x192BF80 Offset: 0x192B180 VA: 0x18192BF80
	public bool CreateMouseMap(int categoryId, int layoutId) { }

	// RVA: 0x192E130 Offset: 0x192D330 VA: 0x18192E130
	public void DeleteMouseMap(int id) { }

	// RVA: 0x1930650 Offset: 0x192F850 VA: 0x181930650
	public int DuplicateMouseMap(int index) { }

	// RVA: 0x1937F30 Offset: 0x1937130 VA: 0x181937F30
	public ControllerMap_Editor GetMouseMapById(int id, out int mouseMapIndex) { }

	// RVA: 0x1930AA0 Offset: 0x192FCA0 VA: 0x181930AA0
	public MouseMap FindMouseMap_Game(Mouse mouse, int categoryId, int layoutId) { }

	// RVA: 0x1939F30 Offset: 0x1939130 VA: 0x181939F30
	public bool HasMouseMapInCategory(int categoryId) { }

	// RVA: 0x1939FE0 Offset: 0x19391E0 VA: 0x181939FE0
	public bool HasMouseMapInLayout(int categoryId, int layoutId) { }

	// RVA: 0x19346B0 Offset: 0x19338B0 VA: 0x1819346B0
	public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x19343B0 Offset: 0x19335B0 VA: 0x1819343B0
	public ControllerMap_Editor GetCustomControllerMapById(int mapId, out int customControllerMapIndex) { }

	// RVA: 0x19347F0 Offset: 0x19339F0 VA: 0x1819347F0
	public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid) { }

	// RVA: 0x1934560 Offset: 0x1933760 VA: 0x181934560
	public int GetCustomControllerMapId(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x1939720 Offset: 0x1938920 VA: 0x181939720
	public bool HasCustomControllerMap(int mapId, int categoryId, int layoutId) { }

	// RVA: 0x1939660 Offset: 0x1938860 VA: 0x181939660
	public bool HasCustomControllerMap(int mapId) { }

	// RVA: 0x1939580 Offset: 0x1938780 VA: 0x181939580
	public bool HasCustomControllerMapInCategory(int controllerUid, int categoryId) { }

	// RVA: 0x192BB90 Offset: 0x192AD90 VA: 0x18192BB90
	public bool CreateCustomControllerMap(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x192CDB0 Offset: 0x192BFB0 VA: 0x18192CDB0
	public void DeleteCustomControllerMap(int mapId) { }

	// RVA: 0x192F2A0 Offset: 0x192E4A0 VA: 0x18192F2A0
	public int DuplicateCustomControllerMap(int index) { }

	// RVA: 0x193CA30 Offset: 0x193BC30 VA: 0x18193CA30
	internal CustomControllerMap JxLlyRlBBLnGYpEUOBxEmzRQxPXl(Guid , int , int ) { }

	// RVA: 0x193C630 Offset: 0x193B830 VA: 0x18193C630
	internal CustomControllerMap JxLlyRlBBLnGYpEUOBxEmzRQxPXl(int , int , int ) { }

	// RVA: 0x193C760 Offset: 0x193B960 VA: 0x18193C760
	private CustomControllerMap JxLlyRlBBLnGYpEUOBxEmzRQxPXl(CustomController_Editor , int , int ) { }

	// RVA: 0x193EFD0 Offset: 0x193E1D0 VA: 0x18193EFD0
	private ControllerMap_Editor fHGwbQTtcRkzPwwzheTfOmcmaPWZ(int , int , int , bool ) { }

	// RVA: 0x193DD90 Offset: 0x193CF90 VA: 0x18193DD90
	private ControllerMap_Editor ZwpaOUkytkbbpXoZxiVzaYxNveBN(int , int , int ) { }

	// RVA: 0x192C790 Offset: 0x192B990 VA: 0x18192C790
	public void DeleteControllerMap(ControllerType controllerType, int id) { }

	// RVA: 0x1932550 Offset: 0x1931750 VA: 0x181932550
	public ControllerMap_Editor GetControllerMapByIndex(ControllerType controllerType, int index) { }

	// RVA: 0x1932250 Offset: 0x1931450 VA: 0x181932250
	public ControllerMap_Editor GetControllerMapById(ControllerType controllerType, int id, out int controllerMapIndex) { }

	// RVA: 0x192EF80 Offset: 0x192E180 VA: 0x18192EF80
	public int DuplicateControllerMap(ControllerType controllerType, int index) { }

	// RVA: 0x1940920 Offset: 0x193FB20 VA: 0x181940920
	internal ControllerTemplateMap tNbEXoXfGwNxoyHocTdEJvUqLLyN(Guid , int , int ) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x192ACF0 Offset: 0x1929EF0 VA: 0x18192ACF0
	public void AddCustomController() { }

	// RVA: 0x192AE10 Offset: 0x192A010 VA: 0x18192AE10
	public void AddCustomController(Guid typeGuid) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x193BDE0 Offset: 0x193AFE0 VA: 0x18193BDE0
	public void InsertCustomController(int index) { }

	// RVA: 0x193BCA0 Offset: 0x193AEA0 VA: 0x18193BCA0
	public void InsertCustomController(int index, Guid typeGuid) { }

	// RVA: 0x192CE70 Offset: 0x192C070 VA: 0x18192CE70
	public void DeleteCustomController(int index) { }

	// RVA: 0x193CF60 Offset: 0x193C160 VA: 0x18193CF60
	public bool ReorderCustomController(int index, bool offsetDown, bool offsetNow) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x192F3D0 Offset: 0x192E5D0 VA: 0x18192F3D0
	public void DuplicateCustomController(int index, bool duplicateMaps) { }

	// RVA: 0x192F430 Offset: 0x192E630 VA: 0x18192F430
	public void DuplicateCustomController(int index, bool duplicateMaps, Guid typeGuid) { }

	// RVA: 0x1934490 Offset: 0x1933690 VA: 0x181934490
	public int GetCustomControllerMapCount(int controllerUid) { }

	// RVA: 0x1933C00 Offset: 0x1932E00 VA: 0x181933C00
	public int GetCustomControllerIndex(int id) { }

	// RVA: 0x1934A20 Offset: 0x1933C20 VA: 0x181934A20
	public string[] GetCustomControllerNames() { }

	// RVA: 0x1933B00 Offset: 0x1932D00 VA: 0x181933B00
	public int[] GetCustomControllerIds() { }

	// RVA: 0x1933900 Offset: 0x1932B00 VA: 0x181933900
	public Guid[] GetCustomControllerGuids() { }

	// RVA: 0x1934B20 Offset: 0x1933D20 VA: 0x181934B20
	public CustomController_Editor GetCustomController(int index) { }

	// RVA: 0x1934BA0 Offset: 0x1933DA0 VA: 0x181934BA0
	public CustomController_Editor GetCustomController(string name) { }

	// RVA: 0x1933800 Offset: 0x1932A00 VA: 0x181933800
	public CustomController_Editor GetCustomControllerById(int id) { }

	// RVA: 0x1933680 Offset: 0x1932880 VA: 0x181933680
	public CustomController_Editor GetCustomControllerByHardwareTypeGuid(Guid hardwareTypeGuid) { }

	// RVA: 0x1933A70 Offset: 0x1932C70 VA: 0x181933A70
	public int GetCustomControllerId(string name) { }

	// RVA: 0x193AD70 Offset: 0x1939F70 VA: 0x18193AD70
	public int IndexOfCustomController(int id) { }

	// RVA: 0x193AE30 Offset: 0x193A030 VA: 0x18193AE30
	public int IndexOfCustomController(string name) { }

	// RVA: 0x193AC30 Offset: 0x1939E30 VA: 0x18193AC30
	public int IndexOfCustomController(Guid hardwareTypeGuid) { }

	// RVA: 0x1934930 Offset: 0x1933B30 VA: 0x181934930
	public string GetCustomControllerNameById(int id) { }

	// RVA: 0x192AB90 Offset: 0x1929D90 VA: 0x18192AB90
	public void AddControllerMapLayoutManagerRuleSet() { }

	// RVA: 0x193BB00 Offset: 0x193AD00 VA: 0x18193BB00
	public void InsertControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x192C560 Offset: 0x192B760 VA: 0x18192C560
	public void DeleteControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x193CE70 Offset: 0x193C070 VA: 0x18193CE70
	public bool ReorderControllerMapLayoutManagerRuleSet(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192EDC0 Offset: 0x192DFC0 VA: 0x18192EDC0
	public void DuplicateControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x1933430 Offset: 0x1932630 VA: 0x181933430
	public int GetControllerMapLayoutManagerRuleSetUsedCount(int id) { }

	// RVA: 0x1933170 Offset: 0x1932370 VA: 0x181933170
	public int GetControllerMapLayoutManagerRuleSetIndex(int id) { }

	// RVA: 0x1933330 Offset: 0x1932530 VA: 0x181933330
	public string[] GetControllerMapLayoutManagerRuleSetNames() { }

	// RVA: 0x1933070 Offset: 0x1932270 VA: 0x181933070
	public int[] GetControllerMapLayoutManagerRuleSetIds() { }

	// RVA: 0x1933580 Offset: 0x1932780 VA: 0x181933580
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x1933600 Offset: 0x1932800 VA: 0x181933600
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(string name) { }

	// RVA: 0x1932E90 Offset: 0x1932090 VA: 0x181932E90
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id) { }

	// RVA: 0x1932FE0 Offset: 0x19321E0 VA: 0x181932FE0
	public int GetControllerMapLayoutManagerRuleSetId(string name) { }

	// RVA: 0x193A9B0 Offset: 0x1939BB0 VA: 0x18193A9B0
	public int IndexOfControllerMapLayoutManagerRuleSet(int id) { }

	// RVA: 0x193A8A0 Offset: 0x1939AA0 VA: 0x18193A8A0
	public int IndexOfControllerMapLayoutManagerRuleSet(string name) { }

	// RVA: 0x1933240 Offset: 0x1932440 VA: 0x181933240
	public string GetControllerMapLayoutManagerRuleSetNameById(int id) { }

	// RVA: 0x1932F90 Offset: 0x1932190 VA: 0x181932F90
	public int GetControllerMapLayoutManagerRuleSetCount() { }

	// RVA: 0x192AAE0 Offset: 0x1929CE0 VA: 0x18192AAE0
	public void AddControllerMapEnablerRuleSet() { }

	// RVA: 0x193BA30 Offset: 0x193AC30 VA: 0x18193BA30
	public void InsertControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x192C330 Offset: 0x192B530 VA: 0x18192C330
	public void DeleteControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x193CDF0 Offset: 0x193BFF0 VA: 0x18193CDF0
	public bool ReorderControllerMapEnablerRuleSet(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x192EC00 Offset: 0x192DE00 VA: 0x18192EC00
	public void DuplicateControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x1932C40 Offset: 0x1931E40 VA: 0x181932C40
	public int GetControllerMapEnablerRuleSetUsedCount(int id) { }

	// RVA: 0x1932980 Offset: 0x1931B80 VA: 0x181932980
	public int GetControllerMapEnablerRuleSetIndex(int id) { }

	// RVA: 0x1932B40 Offset: 0x1931D40 VA: 0x181932B40
	public string[] GetControllerMapEnablerRuleSetNames() { }

	// RVA: 0x1932880 Offset: 0x1931A80 VA: 0x181932880
	public int[] GetControllerMapEnablerRuleSetIds() { }

	// RVA: 0x1932E10 Offset: 0x1932010 VA: 0x181932E10
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x1932D90 Offset: 0x1931F90 VA: 0x181932D90
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(string name) { }

	// RVA: 0x19326A0 Offset: 0x19318A0 VA: 0x1819326A0
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id) { }

	// RVA: 0x19327F0 Offset: 0x19319F0 VA: 0x1819327F0
	public int GetControllerMapEnablerRuleSetId(string name) { }

	// RVA: 0x193A7E0 Offset: 0x19399E0 VA: 0x18193A7E0
	public int IndexOfControllerMapEnablerRuleSet(int id) { }

	// RVA: 0x193A6D0 Offset: 0x19398D0 VA: 0x18193A6D0
	public int IndexOfControllerMapEnablerRuleSet(string name) { }

	// RVA: 0x1932A50 Offset: 0x1931C50 VA: 0x181932A50
	public string GetControllerMapEnablerRuleSetNameById(int id) { }

	// RVA: 0x19327A0 Offset: 0x19319A0 VA: 0x1819327A0
	public int GetControllerMapEnablerRuleSetCount() { }

	// RVA: 0x1938420 Offset: 0x1937620 VA: 0x181938420
	public int GetNewPlayerId() { }

	// RVA: 0x1938340 Offset: 0x1937540 VA: 0x181938340
	public int GetNewActionId() { }

	// RVA: 0x1938330 Offset: 0x1937530 VA: 0x181938330
	public int GetNewActionCategoryId() { }

	// RVA: 0x19383A0 Offset: 0x19375A0 VA: 0x1819383A0
	public int GetNewInputBehaviorId() { }

	// RVA: 0x19383F0 Offset: 0x19375F0 VA: 0x1819383F0
	public int GetNewMapCategoryId() { }

	// RVA: 0x19383B0 Offset: 0x19375B0 VA: 0x1819383B0
	public int GetNewJoystickLayoutId() { }

	// RVA: 0x19383D0 Offset: 0x19375D0 VA: 0x1819383D0
	public int GetNewKeyboardLayoutId() { }

	// RVA: 0x1938400 Offset: 0x1937600 VA: 0x181938400
	public int GetNewMouseLayoutId() { }

	// RVA: 0x1938380 Offset: 0x1937580 VA: 0x181938380
	public int GetNewCustomControllerLayoutId() { }

	// RVA: 0x19383C0 Offset: 0x19375C0 VA: 0x1819383C0
	public int GetNewJoystickMapId() { }

	// RVA: 0x19383E0 Offset: 0x19375E0 VA: 0x1819383E0
	public int GetNewKeyboardMapId() { }

	// RVA: 0x1938410 Offset: 0x1937610 VA: 0x181938410
	public int GetNewMouseMapId() { }

	// RVA: 0x1938390 Offset: 0x1937590 VA: 0x181938390
	public int GetNewCustomControllerMapId() { }

	// RVA: 0x1938370 Offset: 0x1937570 VA: 0x181938370
	public int GetNewCustomControllerId() { }

	// RVA: 0x1938360 Offset: 0x1937560 VA: 0x181938360
	public int GetNewControllerMapLayoutManagerRuleSetId() { }

	// RVA: 0x1938350 Offset: 0x1937550 VA: 0x181938350
	public int GetNewControllerMapEnablerRuleSetId() { }

	// RVA: 0x1939430 Offset: 0x1938630 VA: 0x181939430
	private Player_Editor HWfVBQFlrJpNvuBRpCcaHKYlFWwMA() { }

	// RVA: 0x193E9D0 Offset: 0x193DBD0 VA: 0x18193E9D0
	private InputAction dJKHiBwIOkYGxTHgwUeKMNjSuKxS() { }

	// RVA: 0x193A230 Offset: 0x1939430 VA: 0x18193A230
	private InputActionCategory IHvsVRWPQcaZqFYlJilmBsIQNDhgb() { }

	// RVA: 0x193ECC0 Offset: 0x193DEC0 VA: 0x18193ECC0
	private InputBehavior dYPvailNJyBxPYAMcPODRATcDMvkA() { }

	// RVA: 0x1941450 Offset: 0x1940650 VA: 0x181941450
	private InputMapCategory znwZHvFBLFlWncSyUOadGfFAiDPBA() { }

	// RVA: 0x193EE60 Offset: 0x193E060 VA: 0x18193EE60
	private InputLayout esCPOEpigtMaqwAZZAqsKBEbcRFF() { }

	// RVA: 0x193C560 Offset: 0x193B760 VA: 0x18193C560
	private InputLayout JXzDhiJPogOiSEalETHgHxbstObbA() { }

	// RVA: 0x19407E0 Offset: 0x193F9E0 VA: 0x1819407E0
	private InputLayout rkaJwRWJgccEeTDcREdlTRuXVuZy() { }

	// RVA: 0x193FF00 Offset: 0x193F100 VA: 0x18193FF00
	private InputLayout kQubsihMzIrntWtIFLIkHzhByJCyb() { }

	// RVA: 0x19405C0 Offset: 0x193F7C0 VA: 0x1819405C0
	private CustomController_Editor qdvqDxKfbwaTmoHxOzUOasgeKFTQ(Guid ) { }

	// RVA: 0x193FCB0 Offset: 0x193EEB0 VA: 0x18193FCB0
	private ControllerMapLayoutManager_RuleSet_Editor kFypEElAFEEorCotpiWPtKfsmXx() { }

	// RVA: 0x1940960 Offset: 0x193FB60 VA: 0x181940960
	private ControllerMapEnabler_RuleSet_Editor tRTFtPDpJirdDEsiArduojSHclRV() { }

	// RVA: 0x193FBF0 Offset: 0x193EDF0 VA: 0x18193FBF0
	private ControllerMap_Editor jBVVljkcWFmOEWDLoftvoCFQwPFS(List<ControllerMap_Editor> , int , int ) { }

	// RVA: 0x193D610 Offset: 0x193C810 VA: 0x18193D610
	private ControllerMap_Editor TVNVloSylaECvcFSxNsKPjwfVxIv(List<ControllerMap_Editor> , List<InputLayout> , int , int , bool ) { }

	// RVA: 0x1940370 Offset: 0x193F570 VA: 0x181940370
	private ControllerMap_Editor oHkeYKZaTYcuEhNbRMdoEythUqKtA(List<ControllerMap_Editor> , List<InputLayout> , int , int ) { }

	// RVA: 0x193F420 Offset: 0x193E620 VA: 0x18193F420
	private void hOcJVGWadMuPBNaABNWeLyVGQYPo(List<ControllerMap_Editor> , List<InputLayout> ) { }

	// RVA: 0x1940A20 Offset: 0x193FC20 VA: 0x181940A20
	internal void vbNCioiKNoHaUUsNYMgqKmFiLDEBA() { }

	// RVA: 0x193EAD0 Offset: 0x193DCD0 VA: 0x18193EAD0
	internal void dWGyvklLZZlCYqbwAlKIxmkaqRPF() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x193CC90 Offset: 0x193BE90 VA: 0x18193CC90
	internal static UserData Merge(UserData orig, UserData other, bool preserveOrigIds) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x192BB60 Offset: 0x192AD60 VA: 0x18192BB60
	internal static UserData Compact(UserData orig) { }
}

// Namespace: Rewired.Data
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[RequireComponent(typeof(InputManager_Base))]
public abstract class UserDataStore : MonoBehaviour, IUserDataStore, IControllerMapStore // TypeDefIndex: 7342
{
	// Methods

	// RVA: 0x1950670 Offset: 0x194F870 VA: 0x181950670
	private void OnDestroy() { }

	// RVA: 0x1950540 Offset: 0x194F740 VA: 0x181950540
	internal void Initialize() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void LoadControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void LoadPlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void LoadInputBehavior(int playerId, int behaviorId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Save();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SaveControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void SavePlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void SaveInputBehavior(int playerId, int behaviorId);

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 26
	public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 27
	public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void OnInitialize();

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);

	[Obsolete("This method is deprecated and will be removed in a future version. Use OnControllerPreDisconnect instead.", False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 31
	protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x1950650 Offset: 0x194F850 VA: 0x181950650 Slot: 32
	protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	protected void .ctor() { }
}

// Namespace: Rewired.Data
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IConfigVars_Internal // TypeDefIndex: 7343
{
	// Properties
	public abstract KeyedGetSetValueStore<string> values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract KeyedGetSetValueStore<string> get_values();
}

// Namespace: Rewired.Data
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
[Serializable]
internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor // TypeDefIndex: 7344
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _scriptingName; // 0x88
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _alternateScriptingName; // 0x90
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _excludeFromExport; // 0x98
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _useEditorElementTypeOverride; // 0x99
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private ControllerElementType _editorElementTypeOverride; // 0x9C

	// Properties
	internal string scriptingName { get; set; }
	internal string alternateScriptingName { get; set; }
	internal bool excludeFromExport { get; }
	internal override bool useEditorElementTypeOverride { get; }
	internal override ControllerElementType editorElementTypeOverride { get; }
	internal ControllerTemplateElementType effectiveElementType { get; }
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.scriptingName { get; }
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.alternateScriptingName { get; }

	// Methods

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal string get_scriptingName() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	internal void set_scriptingName(string value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	internal string get_alternateScriptingName() { }

	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	internal void set_alternateScriptingName(string value) { }

	// RVA: 0x738170 Offset: 0x737370 VA: 0x180738170
	internal bool get_excludeFromExport() { }

	// RVA: 0x1944170 Offset: 0x1943370 VA: 0x181944170 Slot: 54
	internal override bool get_useEditorElementTypeOverride() { }

	// RVA: 0x1944140 Offset: 0x1943340 VA: 0x181944140 Slot: 55
	internal override ControllerElementType get_editorElementTypeOverride() { }

	// RVA: 0x1944150 Offset: 0x1943350 VA: 0x181944150
	internal ControllerTemplateElementType get_effectiveElementType() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x19440D0 Offset: 0x19432D0 VA: 0x1819440D0
	public void .ctor(ControllerTemplateElementIdentifier_Editor ) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 57
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_scriptingName() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 58
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_alternateScriptingName() { }

	// RVA: 0x1944020 Offset: 0x1943220 VA: 0x181944020 Slot: 56
	public override ControllerTemplateElementIdentifier Clone() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapEnabler_RuleSet_Editor // TypeDefIndex: 7345
{
	// Fields
	[SerializeField]
	[Serialize]
	private int _id; // 0x10
	[Serialize]
	[SerializeField]
	private string _name; // 0x18
	[Serialize]
	[SerializeField]
	private string _tag; // 0x20
	[Serialize]
	[SerializeField]
	private List<ControllerMapEnabler_Rule_Editor> _rules; // 0x28

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public List<ControllerMapEnabler_Rule_Editor> rules { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_id(int value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_name(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_tag() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_tag(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<ControllerMapEnabler_Rule_Editor> get_rules() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_rules(List<ControllerMapEnabler_Rule_Editor> value) { }

	// RVA: 0x1942DF0 Offset: 0x1941FF0 VA: 0x181942DF0
	public void .ctor() { }

	// RVA: 0x1942D10 Offset: 0x1941F10 VA: 0x181942D10
	public void .ctor(ControllerMapEnabler_RuleSet_Editor ) { }

	// RVA: 0x1942AA0 Offset: 0x1941CA0 VA: 0x181942AA0
	internal ControllerMapEnabler_RuleSet_Editor Clone() { }

	// RVA: 0x1942BB0 Offset: 0x1941DB0 VA: 0x181942BB0
	internal ControllerMapEnabler.RuleSet ToRuntime() { }
}

// Namespace: Rewired.Data
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Preserve]
[Serializable]
public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable // TypeDefIndex: 7346
{
	// Fields
	[Serialize]
	[SerializeField]
	private string _tag; // 0x10
	[SerializeField]
	[Serialize]
	private bool _enable; // 0x18
	[SerializeField]
	[Serialize]
	private List<int> _categoryIds; // 0x20
	[Serialize]
	[SerializeField]
	private List<int> _layoutIds; // 0x28
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; // 0x30

	// Properties
	public string tag { get; set; }
	public bool enable { get; set; }
	public List<int> categoryIds { get; set; }
	public List<int> layoutIds { get; set; }
	public ControllerSetSelector_Editor controllerSetSelector { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_tag() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_tag(string value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_enable() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_enable(bool value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<int> get_categoryIds() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_categoryIds(List<int> value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<int> get_layoutIds() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_layoutIds(List<int> value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	// RVA: 0x19431D0 Offset: 0x19423D0 VA: 0x1819431D0
	public void .ctor() { }

	// RVA: 0x19430C0 Offset: 0x19422C0 VA: 0x1819430C0
	public void .ctor(ControllerMapEnabler_Rule_Editor ) { }

	// RVA: 0x1942FA0 Offset: 0x19421A0 VA: 0x181942FA0
	internal ControllerMapEnabler.Rule ToRuntime() { }

	// RVA: 0x1942E60 Offset: 0x1942060 VA: 0x181942E60 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapLayoutManager_RuleSet_Editor // TypeDefIndex: 7347
{
	// Fields
	[Serialize]
	[SerializeField]
	private int _id; // 0x10
	[SerializeField]
	[Serialize]
	private string _name; // 0x18
	[Serialize]
	[SerializeField]
	private string _tag; // 0x20
	[Serialize]
	[SerializeField]
	private List<ControllerMapLayoutManager_Rule_Editor> _rules; // 0x28

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public List<ControllerMapLayoutManager_Rule_Editor> rules { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_id(int value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_name(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_tag() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_tag(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public List<ControllerMapLayoutManager_Rule_Editor> get_rules() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_rules(List<ControllerMapLayoutManager_Rule_Editor> value) { }

	// RVA: 0x1943510 Offset: 0x1942710 VA: 0x181943510
	public void .ctor() { }

	// RVA: 0x1943580 Offset: 0x1942780 VA: 0x181943580
	public void .ctor(ControllerMapLayoutManager_RuleSet_Editor ) { }

	// RVA: 0x19432A0 Offset: 0x19424A0 VA: 0x1819432A0
	internal ControllerMapLayoutManager_RuleSet_Editor Clone() { }

	// RVA: 0x19433B0 Offset: 0x19425B0 VA: 0x1819433B0
	internal ControllerMapLayoutManager.RuleSet ToRuntime() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable // TypeDefIndex: 7348
{
	// Fields
	[Serialize]
	[SerializeField]
	private string _tag; // 0x10
	[Serialize]
	[SerializeField]
	private List<int> _categoryIds; // 0x18
	[Serialize]
	[SerializeField]
	private int _layoutId; // 0x20
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; // 0x28

	// Properties
	public string tag { get; set; }
	public List<int> categoryIds { get; set; }
	public int layoutId { get; set; }
	public ControllerSetSelector_Editor controllerSetSelector { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_tag() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_tag(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<int> get_categoryIds() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_categoryIds(List<int> value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_layoutId() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_layoutId(int value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	// RVA: 0x1943970 Offset: 0x1942B70 VA: 0x181943970
	public void .ctor() { }

	// RVA: 0x1943870 Offset: 0x1942A70 VA: 0x181943870
	public void .ctor(ControllerMapLayoutManager_Rule_Editor ) { }

	// RVA: 0x1943780 Offset: 0x1942980 VA: 0x181943780
	internal ControllerMapLayoutManager.Rule ToRuntime() { }

	// RVA: 0x1943660 Offset: 0x1942860 VA: 0x181943660 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data
[Preserve]
[Serializable]
public sealed class ControllerSetSelector_Editor : IDeepCloneable // TypeDefIndex: 7349
{
	// Fields
	[SerializeField]
	[Serialize]
	private ControllerSetSelector.Type _type; // 0x10
	[Serialize]
	[SerializeField]
	private ControllerType _controllerType; // 0x14
	[Serialize]
	[SerializeField]
	private string _hardwareTypeGuidString; // 0x18
	[Serialize]
	[SerializeField]
	private string _hardwareIdentifier; // 0x20
	[Serialize]
	[SerializeField]
	private string _controllerTemplateTypeGuidString; // 0x28
	[Serialize]
	[SerializeField]
	private string _deviceInstanceGuidString; // 0x30
	[SerializeField]
	[Serialize]
	private int _customControllerSourceId; // 0x38
	[Serialize]
	[SerializeField]
	private int _controllerId; // 0x3C

	// Properties
	public ControllerSetSelector.Type type { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareTypeGuidString { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid controllerTemplateTypeGuid { get; set; }
	public string controllerTemplateTypeGuidString { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public string deviceInstanceGuidString { get; set; }
	public int controllerId { get; set; }
	public int customControllerSourceId { get; set; }

	// Methods

	// RVA: 0x1943B00 Offset: 0x1942D00 VA: 0x181943B00
	internal void .ctor(ControllerSetSelector.Type ) { }

	// RVA: 0x1943C30 Offset: 0x1942E30 VA: 0x181943C30
	public void .ctor() { }

	// RVA: 0x1943B80 Offset: 0x1942D80 VA: 0x181943B80
	public void .ctor(ControllerSetSelector_Editor ) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ControllerSetSelector.Type get_type() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_type(ControllerSetSelector.Type value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ControllerType get_controllerType() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x1943D80 Offset: 0x1942F80 VA: 0x181943D80
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x1943E10 Offset: 0x1943010 VA: 0x181943E10
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_hardwareTypeGuidString() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_hardwareTypeGuidString(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_hardwareIdentifier() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x1943CA0 Offset: 0x1942EA0 VA: 0x181943CA0
	public Guid get_controllerTemplateTypeGuid() { }

	// RVA: 0x1929320 Offset: 0x1928520 VA: 0x181929320
	public void set_controllerTemplateTypeGuid(Guid value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_controllerTemplateTypeGuidString() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_controllerTemplateTypeGuidString(string value) { }

	// RVA: 0x1943D10 Offset: 0x1942F10 VA: 0x181943D10
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x1943DF0 Offset: 0x1942FF0 VA: 0x181943DF0
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_deviceInstanceGuidString() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_deviceInstanceGuidString(string value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public int get_controllerId() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_controllerId(int value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public int get_customControllerSourceId() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_customControllerSourceId(int value) { }

	// RVA: 0x1943E30 Offset: 0x1943030 VA: 0x181943E30
	internal ControllerSetSelector yinCICkwIrAeiaGYbbQmJIeewYd() { }

	// RVA: 0x1943A20 Offset: 0x1942C20 VA: 0x181943A20 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[Preserve]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal abstract class ControllerTemplateSpecialElementMapping // TypeDefIndex: 7350
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[Preserve]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateThumbStickMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7351
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisY; // 0x14
	public int eid_button; // 0x18

	// Methods

	// RVA: 0x19441D0 Offset: 0x19433D0 VA: 0x1819441D0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7352
{
	// Fields
	public int eid_up; // 0x10
	public int eid_right; // 0x14
	public int eid_down; // 0x18
	public int eid_left; // 0x1C
	public int eid_press; // 0x20

	// Methods

	// RVA: 0x1944000 Offset: 0x1943200 VA: 0x181944000
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Preserve]
[Serializable]
internal class ControllerTemplateStickMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7353
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisY; // 0x14
	public int eid_axisZ; // 0x18

	// Methods

	// RVA: 0x19441D0 Offset: 0x19433D0 VA: 0x1819441D0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Preserve]
[CustomObfuscation(rename = False)]
[Serializable]
internal class ControllerTemplateThrottleMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7354
{
	// Fields
	public int eid_axis; // 0x10
	public int eid_minDetent; // 0x14

	// Methods

	// RVA: 0x19441F0 Offset: 0x19433F0 VA: 0x1819441F0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal class ControllerTemplateHatMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7355
{
	// Fields
	public int eid_up; // 0x10
	public int eid_upRight; // 0x14
	public int eid_right; // 0x18
	public int eid_downRight; // 0x1C
	public int eid_down; // 0x20
	public int eid_downLeft; // 0x24
	public int eid_left; // 0x28
	public int eid_upLeft; // 0x2C

	// Methods

	// RVA: 0x1944180 Offset: 0x1943380 VA: 0x181944180
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal class ControllerTemplateYokeMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7356
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisZ; // 0x14

	// Methods

	// RVA: 0x19441F0 Offset: 0x19433F0 VA: 0x1819441F0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateStick6DMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 7357
{
	// Fields
	public int eid_positionX; // 0x10
	public int eid_positionY; // 0x14
	public int eid_positionZ; // 0x18
	public int eid_rotationX; // 0x1C
	public int eid_rotationY; // 0x20
	public int eid_rotationZ; // 0x24

	// Methods

	// RVA: 0x19441B0 Offset: 0x19433B0 VA: 0x1819441B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ActionCategoryMap.Entry.yQvmZzNkCQNcmdDbnGqTjvPZwuCRA : IDisposable, IEnumerable, IEnumerator, IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 7358
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private int lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x18
	public ActionCategoryMap.Entry nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x28

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1950090 Offset: 0x194F290 VA: 0x181950090
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1957800 Offset: 0x1956A00 VA: 0x181957800 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1957970 Offset: 0x1956B70 VA: 0x181957970 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19579B0 Offset: 0x1956BB0 VA: 0x1819579B0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19578B0 Offset: 0x1956AB0 VA: 0x1819578B0 Slot: 9
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19578B0 Offset: 0x1956AB0 VA: 0x1819578B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
public class ActionCategoryMap.Entry // TypeDefIndex: 7359
{
	// Fields
	public int categoryId; // 0x10
	public List<int> actionIds; // 0x18

	// Properties
	public IEnumerable<int> ActionIds { get; }

	// Methods

	// RVA: 0x1945DC0 Offset: 0x1944FC0 VA: 0x181945DC0
	public IEnumerable<int> get_ActionIds() { }

	// RVA: 0x1945D50 Offset: 0x1944F50 VA: 0x181945D50
	public void .ctor() { }

	// RVA: 0x1945CD0 Offset: 0x1944ED0 VA: 0x181945CD0
	public void .ctor(int ) { }

	// RVA: 0x1945C70 Offset: 0x1944E70 VA: 0x181945C70
	public void .ctor(ActionCategoryMap.Entry ) { }

	// RVA: 0x1945780 Offset: 0x1944980 VA: 0x181945780
	public void AddAction(int actionId) { }

	// RVA: 0x19459B0 Offset: 0x1944BB0 VA: 0x1819459B0
	public bool InsertAction(int actionId, int index) { }

	// RVA: 0x1945B10 Offset: 0x1944D10 VA: 0x181945B10
	public bool ReorderAction(int actionId, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1945AA0 Offset: 0x1944CA0 VA: 0x181945AA0
	public void RemoveAction(int actionId) { }

	// RVA: 0x1945900 Offset: 0x1944B00 VA: 0x181945900
	public int IndexOfAction(int id) { }

	// RVA: 0x19458E0 Offset: 0x1944AE0 VA: 0x1819458E0
	public bool ContainsAction(int id) { }

	// RVA: 0x1945850 Offset: 0x1944A50 VA: 0x181945850
	public ActionCategoryMap.Entry Clone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ActionCategoryMap.szaLFTVwvOFmhfyTULKEaMtqtlIn : IDisposable, IEnumerable, IEnumerator, IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 7360
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private int lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x18
	public ActionCategoryMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x28
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x2C
	private IEnumerator<int> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x30

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1950090 Offset: 0x194F290 VA: 0x181950090
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1957570 Offset: 0x1956770 VA: 0x181957570 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1957180 Offset: 0x1956380 VA: 0x181957180 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1957600 Offset: 0x1956800 VA: 0x181957600
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19574E0 Offset: 0x19566E0 VA: 0x1819574E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1957520 Offset: 0x1956720 VA: 0x181957520 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1957420 Offset: 0x1956620 VA: 0x181957420 Slot: 9
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1957420 Offset: 0x1956620 VA: 0x181957420 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class ActionCategoryMap // TypeDefIndex: 7361
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ActionCategoryMap.Entry> list; // 0x10

	// Methods

	// RVA: 0x1941B40 Offset: 0x1940D40 VA: 0x181941B40
	public IEnumerable<int> ActionIdsInCategory(int categoryId) { }

	// RVA: 0x1942850 Offset: 0x1941A50 VA: 0x181942850
	public void .ctor() { }

	// RVA: 0x19426B0 Offset: 0x19418B0 VA: 0x1819426B0
	public void .ctor(ActionCategoryMap ) { }

	// RVA: 0x1941C70 Offset: 0x1940E70 VA: 0x181941C70
	public void AddCategory(int id) { }

	// RVA: 0x1942430 Offset: 0x1941630 VA: 0x181942430
	public void RemoveCategory(int id) { }

	// RVA: 0x1942550 Offset: 0x1941750 VA: 0x181942550
	public bool ReorderCategory(int id, bool offsetDown) { }

	// RVA: 0x1941D90 Offset: 0x1940F90 VA: 0x181941D90
	public bool ChangeCategory(int actionId, int newCategoryId) { }

	// RVA: 0x1942180 Offset: 0x1941380 VA: 0x181942180
	public int IndexOfCategory(int id) { }

	// RVA: 0x1941BD0 Offset: 0x1940DD0 VA: 0x181941BD0
	public bool AddAction(int categoryId, int actionId) { }

	// RVA: 0x1942240 Offset: 0x1941440 VA: 0x181942240
	public bool InsertAction(int categoryId, int actionId, int index) { }

	// RVA: 0x19424A0 Offset: 0x19416A0 VA: 0x1819424A0
	public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1942370 Offset: 0x1941570 VA: 0x181942370
	public void RemoveAction(int categoryId, int actionId) { }

	// RVA: 0x19420E0 Offset: 0x19412E0 VA: 0x1819420E0
	public int IndexOfAction(int categoryId, int actionId) { }

	// RVA: 0x1941F10 Offset: 0x1941110 VA: 0x181941F10
	public ActionCategoryMap Clone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public abstract class CustomCalculation : SerializedMethod // TypeDefIndex: 7362
{
	// Methods

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	protected void .ctor() { }
}

// Namespace: 
public enum CustomCalculation_Accelerometer.CalculationType // TypeDefIndex: 7363
{
	// Fields
	public int value__; // 0x0
	public const CustomCalculation_Accelerometer.CalculationType Pitch = 0;
	public const CustomCalculation_Accelerometer.CalculationType Roll = 1;
}

// Namespace: 
public enum CustomCalculation_Accelerometer.OutputType // TypeDefIndex: 7364
{
	// Fields
	public int value__; // 0x0
	public const CustomCalculation_Accelerometer.OutputType Axis = 0;
	public const CustomCalculation_Accelerometer.OutputType Angle = 1;
}

// Namespace: 
public enum CustomCalculation_Accelerometer.InputType // TypeDefIndex: 7365
{
	// Fields
	public int value__; // 0x0
	public const CustomCalculation_Accelerometer.InputType Acceleration = 0;
	public const CustomCalculation_Accelerometer.InputType UserAcceleration = 1;
	public const CustomCalculation_Accelerometer.InputType Gravity = 2;
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_Accelerometer : CustomCalculation // TypeDefIndex: 7366
{
	// Fields
	public CustomCalculation_Accelerometer.CalculationType _calculationType; // 0x50
	public CustomCalculation_Accelerometer.InputType _inputType; // 0x54
	public CustomCalculation_Accelerometer.OutputType _outputType; // 0x58

	// Properties
	internal override TypeWrapper.DataType OSRjTjGKVieupepwyvNIsbpAFpfv { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 4
	internal override TypeWrapper.DataType gEQQSWtHZPfQJcfYdxxgWuUYEPKN() { }

	// RVA: 0x1944430 Offset: 0x1943630 VA: 0x181944430 Slot: 5
	internal override bool bcXkIhZftxujosmCrCRuNdSYVwst() { }

	// RVA: 0x1944250 Offset: 0x1943450 VA: 0x181944250
	private float QOgRSLfFdNJGQUsISlpoJVdKrpcL() { }

	// RVA: 0x19444C0 Offset: 0x19436C0 VA: 0x1819444C0
	private float yOsBWjPfEEafuljCMloMZmqIEFal() { }

	// RVA: 0x1944200 Offset: 0x1943400 VA: 0x181944200
	private float ASPwEiZVtCIGDLAeHqEKTlPvgTQR(float ) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
public enum CustomCalculation_CompareElementValues.ComparisonType // TypeDefIndex: 7367
{
	// Fields
	public int value__; // 0x0
	public const CustomCalculation_CompareElementValues.ComparisonType Min = 0;
	public const CustomCalculation_CompareElementValues.ComparisonType Max = 1;
	public const CustomCalculation_CompareElementValues.ComparisonType MinAbs = 2;
	public const CustomCalculation_CompareElementValues.ComparisonType MaxAbs = 3;
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_CompareElementValues : CustomCalculation // TypeDefIndex: 7368
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;
	[SerializeField]
	private CustomCalculation_CompareElementValues.ComparisonType _comparisonType; // 0x50

	// Properties
	internal override TypeWrapper.DataType OSRjTjGKVieupepwyvNIsbpAFpfv { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 4
	internal override TypeWrapper.DataType gEQQSWtHZPfQJcfYdxxgWuUYEPKN() { }

	// RVA: 0x19448F0 Offset: 0x1943AF0 VA: 0x1819448F0 Slot: 5
	internal override bool bcXkIhZftxujosmCrCRuNdSYVwst() { }

	// RVA: 0x19446B0 Offset: 0x19438B0 VA: 0x1819446B0
	private float ZGsZctzBQrYkFvqhaipnedtQlFib() { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_FirstNonZero : CustomCalculation // TypeDefIndex: 7369
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;

	// Properties
	internal override TypeWrapper.DataType OSRjTjGKVieupepwyvNIsbpAFpfv { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 4
	internal override TypeWrapper.DataType gEQQSWtHZPfQJcfYdxxgWuUYEPKN() { }

	// RVA: 0x1944AB0 Offset: 0x1943CB0 VA: 0x181944AB0 Slot: 5
	internal override bool bcXkIhZftxujosmCrCRuNdSYVwst() { }

	// RVA: 0x1944960 Offset: 0x1943B60 VA: 0x181944960
	private float ZGsZctzBQrYkFvqhaipnedtQlFib() { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
public enum CustomCalculation_LogitechGRacingWheelPedals.Mode // TypeDefIndex: 7370
{
	// Fields
	public int value__; // 0x0
	public const CustomCalculation_LogitechGRacingWheelPedals.Mode SharedAxis = 0;
	public const CustomCalculation_LogitechGRacingWheelPedals.Mode SeparateAxes = 1;
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_LogitechGRacingWheelPedals : CustomCalculation // TypeDefIndex: 7371
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;
	private const float dead = 0,01;
	private CustomCalculation_LogitechGRacingWheelPedals.Mode KGUPpVuYmfgkhlWwyGLDQLmmAHPk; // 0x50

	// Properties
	internal override TypeWrapper.DataType OSRjTjGKVieupepwyvNIsbpAFpfv { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 4
	internal override TypeWrapper.DataType gEQQSWtHZPfQJcfYdxxgWuUYEPKN() { }

	// RVA: 0x1944FC0 Offset: 0x19441C0 VA: 0x181944FC0 Slot: 5
	internal override bool bcXkIhZftxujosmCrCRuNdSYVwst() { }

	// RVA: 0x1944CE0 Offset: 0x1943EE0 VA: 0x181944CE0
	private float ZGsZctzBQrYkFvqhaipnedtQlFib() { }

	// RVA: 0x1944C40 Offset: 0x1943E40 VA: 0x181944C40
	private void MdnYYzWZGsFOwRgQHkTHPluUPkaK(float , float ) { }

	// RVA: 0x6132E0 Offset: 0x6124E0 VA: 0x1806132E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform.EKpBpwEinsSGZIGLWHvBhdfKyaAdB : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform>, IEnumerator<HardwareJoystickMap.Platform> // TypeDefIndex: 7372
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private IList<HardwareJoystickMap.Platform> gzEIZbRBhYaYGeewNTKuOUbfDFKr; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x38

	// Properties
	private HardwareJoystickMap.Platform System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959820 Offset: 0x1958A20 VA: 0x181959820 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19599F0 Offset: 0x1958BF0 VA: 0x1819599F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1959930 Offset: 0x1958B30 VA: 0x181959930 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1959930 Offset: 0x1958B30 VA: 0x181959930 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform : IDeepCloneable // TypeDefIndex: 7373
{
	// Fields
	[Tooltip("A description of this platform map. For reference only.")]
	public string description; // 0x10

	// Properties
	internal abstract InputPlatform platform { get; }
	public abstract int assignedButtonCount { get; }
	public abstract int assignedAxisCount { get; }
	public virtual string controllerNameOverride { get; }
	internal abstract HardwareJoystickMap.Elements_Base elements_base { get; }
	internal virtual bool isAllowed { get; }
	internal abstract bool hasData { get; }
	internal abstract bool disabled { get; }
	internal IEnumerable<HardwareJoystickMap.Platform> Variants { get; }
	internal bool hasVariants { get; }
	[CustomObfuscation(rename = False)]
	internal int variantCount { get; }
	internal bool selfOrVariantHasData { get; }
	internal bool selfOrVariantIsValid { get; }
	internal bool selfOrVariantIsAllowed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract InputPlatform get_platform();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_assignedButtonCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_assignedAxisCount();

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual string get_controllerNameOverride() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract HardwareJoystickMap.Elements_Base get_elements_base();

	// RVA: 0x19680D0 Offset: 0x19672D0 VA: 0x1819680D0 Slot: 10
	internal virtual bool get_isAllowed() { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool IsElementIdentifierMapped(int elementIdentifierId);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool get_hasData();

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract bool get_disabled();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract IList<HardwareJoystickMap.Platform> GetVariants();

	// RVA: 0x1968030 Offset: 0x1967230 VA: 0x181968030
	internal IEnumerable<HardwareJoystickMap.Platform> get_Variants() { }

	// RVA: 0x19680B0 Offset: 0x19672B0 VA: 0x1819680B0
	internal bool get_hasVariants() { }

	// RVA: 0x1968670 Offset: 0x1967870 VA: 0x181968670
	internal int get_variantCount() { }

	// RVA: 0x1968140 Offset: 0x1967340 VA: 0x181968140
	internal bool get_selfOrVariantHasData() { }

	// RVA: 0x1968480 Offset: 0x1967680 VA: 0x181968480
	internal bool get_selfOrVariantIsValid() { }

	// RVA: 0x19682E0 Offset: 0x19674E0 VA: 0x1819682E0
	internal bool get_selfOrVariantIsAllowed() { }

	// RVA: 0x19600E0 Offset: 0x195F2E0 VA: 0x1819600E0
	internal HardwareJoystickMap.Platform GetFirstValidPlatformMap(out int variantIndex) { }

	// RVA: 0x19602F0 Offset: 0x195F4F0 VA: 0x1819602F0
	internal int IndexOfElementIdentifier(ControllerElementIdentifier[] elementIdentifiers, int id) { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract AxisCalibrationData[] GetAxisCalibrationData();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);

	// RVA: 0x1960230 Offset: 0x195F430 VA: 0x181960230
	internal HardwareJoystickMap.Platform GetPlatformMap(int variantIndex) { }

	// RVA: 0x1963EE0 Offset: 0x19630E0 VA: 0x181963EE0
	internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract object DeepClone();

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract void CopyVars(HardwareJoystickMap.Platform destination);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Elements_Base : IDeepCloneable // TypeDefIndex: 7374
{
	// Properties
	public abstract int buttonCount { get; }
	public abstract int axisCount { get; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	internal virtual void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_axisCount();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object DeepClone();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base : IDeepCloneable // TypeDefIndex: 7375
{
	// Fields
	public int axisCount; // 0x10
	public int buttonCount; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1959A60 Offset: 0x1958C60 VA: 0x181959A60 Slot: 5
	public virtual object DeepClone() { }

	// RVA: 0x1959AD0 Offset: 0x1958CD0 VA: 0x181959AD0 Slot: 6
	internal virtual void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x1959A30 Offset: 0x1958C30 VA: 0x181959A30 Slot: 7
	internal virtual bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.MatchingCriteria_Base : IDeepCloneable // TypeDefIndex: 7376
{
	// Fields
	[Tooltip("The number of axes reported by the controller. If the value reported by the controller differs from this value, the controller is not a match. [-1 to match to any number of axes]")]
	public int axisCount; // 0x10
	[Tooltip("The number of buttons reported by the controller. If the value reported by the controller differs from this value, the controller is not a match. [-1 to match to any number of buttons]")]
	public int buttonCount; // 0x14
	[Tooltip("If checked, this entire platform map will be skipped and will not match to any controller.")]
	public bool disabled; // 0x18
	[Tooltip("User-defined string. May have functionality on some input sources but not on others.")]
	public string tag; // 0x20

	// Properties
	internal abstract bool hasData { get; }
	internal virtual bool isAllowed { get; }
	internal abstract int alternateElementCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool get_hasData();

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal virtual bool get_isAllowed() { }

	// RVA: 0x195BF80 Offset: 0x195B180 VA: 0x18195BF80 Slot: 7
	internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract int get_alternateElementCount();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index);

	// RVA: 0x195BE90 Offset: 0x195B090 VA: 0x18195BE90 Slot: 10
	internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195BE60 Offset: 0x195B060 VA: 0x18195BE60 Slot: 11
	internal virtual void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x195C030 Offset: 0x195B230 VA: 0x18195C030
	internal static bool StringMatches(string searchIn, string searchFor, bool useRegex) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object DeepClone();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.CompoundElement : IDeepCloneable // TypeDefIndex: 7377
{
	// Fields
	public CompoundControllerElementType type; // 0x10
	public int elementIdentifier; // 0x14
	public int[] componentElementIdentifiers; // 0x18

	// Properties
	public int elementCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450
	public int get_elementCount() { }

	// RVA: 0x19594E0 Offset: 0x19586E0 VA: 0x1819594E0
	public void .ctor() { }

	// RVA: 0x1959550 Offset: 0x1958750 VA: 0x181959550
	public void .ctor(HardwareJoystickMap.CompoundElement ) { }

	// RVA: 0x1959260 Offset: 0x1958460 VA: 0x181959260
	public int GetComponentElementIdentifierId(int index) { }

	// RVA: 0x19591C0 Offset: 0x19583C0 VA: 0x1819591C0 Slot: 5
	public virtual object DeepClone() { }

	// RVA: 0x19592C0 Offset: 0x19584C0 VA: 0x1819592C0 Slot: 6
	protected virtual void ImportVars(HardwareJoystickMap.CompoundElement source) { }

	// RVA: 0x1959330 Offset: 0x1958530 VA: 0x181959330
	internal static void SortHatElementsClockwise(HardwareJoystickMap.CompoundElement element) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.VidPid // TypeDefIndex: 7378
{
	// Fields
	public int vendorId; // 0x10
	public int productId; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.AxisCalibrationInfoEntry : IDeepCloneable // TypeDefIndex: 7379
{
	// Fields
	[SerializeField]
	internal AlternateAxisCalibrationType key; // 0x10
	[SerializeField]
	internal AxisCalibrationInfo calibration; // 0x18

	// Methods

	// RVA: 0x1957D80 Offset: 0x1956F80 VA: 0x181957D80
	public void .ctor(HardwareJoystickMap.AxisCalibrationInfoEntry ) { }

	// RVA: 0x1957A00 Offset: 0x1956C00 VA: 0x181957A00 Slot: 5
	public virtual object DeepClone() { }

	// RVA: 0x1957A70 Offset: 0x1956C70 VA: 0x181957A70 Slot: 6
	protected virtual void ImportVars(HardwareJoystickMap.AxisCalibrationInfoEntry source) { }

	// RVA: 0x1957AF0 Offset: 0x1956CF0 VA: 0x181957AF0
	public static Dictionary<int, AxisCalibrationInfo> ToDictionary(HardwareJoystickMap.AxisCalibrationInfoEntry[] calibrations, bool deepClone) { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawOrDirectInput.MatchingCriteria.ElementCount : HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 7380
{
	// Fields
	public int hatCount; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1959BA0 Offset: 0x1958DA0 VA: 0x181959BA0 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1959DD0 Offset: 0x1958FD0 VA: 0x181959DD0 Slot: 6
	internal override void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x1959AF0 Offset: 0x1958CF0 VA: 0x181959AF0 Slot: 7
	internal override bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawOrDirectInput.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7381
{
	// Fields
	public int hatCount; // 0x28
	public HardwareJoystickMap.Platform_RawOrDirectInput.MatchingCriteria.ElementCount[] alternateElementCounts; // 0x30
	public bool productName_useRegex; // 0x38
	public string[] productName; // 0x40
	public string[] productGUID; // 0x48
	public int[] productId; // 0x50
	public HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType deviceType; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x195D5A0 Offset: 0x195C7A0 VA: 0x18195D5A0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x195C950 Offset: 0x195BB50 VA: 0x18195C950 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x195D4A0 Offset: 0x195C6A0 VA: 0x18195D4A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x195C880 Offset: 0x195BA80 VA: 0x18195C880 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C7F0 Offset: 0x195B9F0 VA: 0x18195C7F0 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195D330 Offset: 0x195C530 VA: 0x18195D330
	private bool ProductNameMatches(BridgedControllerHWInfo controller) { }

	// RVA: 0x195D200 Offset: 0x195C400 VA: 0x18195D200
	private bool ProductNameMatches(string name) { }

	// RVA: 0x195C6A0 Offset: 0x195B8A0 VA: 0x18195C6A0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x195C140 Offset: 0x195B340 VA: 0x18195C140 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_RawOrDirectInput.Elements_Platform_Base : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7382
{
	// Properties
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> Axes { get; }
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> Buttons { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> get_Axes();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> get_Buttons();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 7383
{
	// Fields
	public int sourceType; // 0x10
	public int sourceAxis; // 0x14
	public int sourceButton; // 0x18
	public int sourceOtherAxis; // 0x1C
	public AxisRange sourceAxisRange; // 0x20
	public float axisDeadZone; // 0x24
	public bool invert; // 0x28
	public AxisCalibrationType axisCalibrationType; // 0x2C
	public float axisZero; // 0x30
	public float axisMin; // 0x34
	public float axisMax; // 0x38

	// Methods

	// RVA: 0x19595D0 Offset: 0x19587D0 VA: 0x1819595D0 Slot: 4
	public object DeepClone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_RawOrDirectInput.Element : IDeepCloneable // TypeDefIndex: 7384
{
	// Fields
	public CustomCalculation customCalculation; // 0x10
	public HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData[] customCalculationSourceData; // 0x18

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x1959EF0 Offset: 0x19590F0 VA: 0x181959EF0
	protected void ImportVars(HardwareJoystickMap.Platform_RawOrDirectInput.Element source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base : HardwareJoystickMap.Platform_RawOrDirectInput.Element // TypeDefIndex: 7385
{
	// Fields
	public int elementIdentifier; // 0x20
	public HardwareElementSourceTypeWithHat sourceType; // 0x24
	public int sourceButton; // 0x28
	public int sourceAxis; // 0x2C
	public Pole sourceAxisPole; // 0x30
	public float axisDeadZone; // 0x34
	public int sourceHat; // 0x38
	public HatType sourceHatType; // 0x3C
	public HatDirection sourceHatDirection; // 0x40
	public bool requireMultipleButtons; // 0x44
	public int[] requiredButtons; // 0x48
	public bool ignoreIfButtonsActive; // 0x50
	public int[] ignoreIfButtonsActiveButtons; // 0x58
	public HardwareButtonInfo buttonInfo; // 0x60

	// Methods

	// RVA: 0x1958880 Offset: 0x1957A80 VA: 0x181958880
	public void .ctor() { }

	// RVA: 0x1958750 Offset: 0x1957950 VA: 0x181958750
	protected void ImportVars(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base : HardwareJoystickMap.Platform_RawOrDirectInput.Element // TypeDefIndex: 7386
{
	// Fields
	public int elementIdentifier; // 0x20
	public HardwareElementSourceTypeWithHat sourceType; // 0x24
	public int sourceAxis; // 0x28
	public AxisRange sourceAxisRange; // 0x2C
	public bool invert; // 0x30
	public float axisDeadZone; // 0x34
	public bool calibrateAxis; // 0x38
	public float axisZero; // 0x3C
	public float axisMin; // 0x40
	public float axisMax; // 0x44
	public HardwareAxisInfo axisInfo; // 0x48
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x50
	public int sourceButton; // 0x58
	public Pole buttonAxisContribution; // 0x5C
	public int sourceHat; // 0x60
	public AxisDirection sourceHatDirection; // 0x64
	public AxisRange sourceHatRange; // 0x68

	// Methods

	// RVA: 0x1957F00 Offset: 0x1957100 VA: 0x181957F00
	public void .ctor() { }

	// RVA: 0x1957DC0 Offset: 0x1956FC0 VA: 0x181957DC0
	protected void ImportVars(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base source) { }
}

// Namespace: 
public enum HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType // TypeDefIndex: 7387
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Any = 0;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Device = 17;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Mouse = 18;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Keyboard = 19;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Joystick = 20;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Gamepad = 21;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Driving = 22;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Flight = 23;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType FirstPerson = 24;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType ControlDevice = 25;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType ScreenPointer = 26;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Remote = 27;
	public const HardwareJoystickMap.Platform_RawOrDirectInput.DeviceType Supplemental = 28;
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_RawOrDirectInput : HardwareJoystickMap.Platform // TypeDefIndex: 7388
{
	// Fields
	public HardwareJoystickMap.Platform_RawOrDirectInput.MatchingCriteria matchingCriteria; // 0x18

	// Properties
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> IterateAxes();

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> IterateButtons();

	// RVA: 0x1963E10 Offset: 0x1963010 VA: 0x181963E10 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_DirectInput_Base.Elements.tdEUQrRICidxidZcGjyFgDuuPoOE : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 7389
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_DirectInput_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B710 Offset: 0x195A910 VA: 0x18195B710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969230 Offset: 0x1968430 VA: 0x181969230 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969170 Offset: 0x1968370 VA: 0x181969170 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969170 Offset: 0x1968370 VA: 0x181969170 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_DirectInput_Base.Elements.yscCWEFVvMJnVHkLSaeFNZXCwrrGA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 7390
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_DirectInput_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968D50 Offset: 0x1967F50 VA: 0x181968D50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969630 Offset: 0x1968830 VA: 0x181969630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969570 Offset: 0x1968770 VA: 0x181969570 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969570 Offset: 0x1968770 VA: 0x181969570 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_DirectInput_Base.Elements : HardwareJoystickMap.Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 7391
{
	// Fields
	public HardwareJoystickMap.Platform_DirectInput_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_DirectInput_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> Axes { get; }
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> Buttons { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A5B0 Offset: 0x19597B0 VA: 0x18195A5B0 Slot: 11
	internal override HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex) { }

	// RVA: 0x195B410 Offset: 0x195A610 VA: 0x18195B410 Slot: 12
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> get_Axes() { }

	// RVA: 0x195B610 Offset: 0x195A810 VA: 0x18195B610 Slot: 13
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> get_Buttons() { }

	// RVA: 0x195B0E0 Offset: 0x195A2E0 VA: 0x18195B0E0 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195AF10 Offset: 0x195A110 VA: 0x18195AF10 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195A540 Offset: 0x1959740 VA: 0x18195A540 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x1959F50 Offset: 0x1959150 VA: 0x181959F50 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_DirectInput_Base.Button : HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 7392
{
	// Methods

	// RVA: 0x1958880 Offset: 0x1957A80 VA: 0x181958880
	public void .ctor() { }

	// RVA: 0x1958B10 Offset: 0x1957D10 VA: 0x181958B10 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958D00 Offset: 0x1957F00 VA: 0x181958D00
	private void ImportVars(HardwareJoystickMap.Platform_DirectInput_Base.Button source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_DirectInput_Base.Axis : HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 7393
{
	// Methods

	// RVA: 0x1957F00 Offset: 0x1957100 VA: 0x181957F00
	public void .ctor() { }

	// RVA: 0x19581C0 Offset: 0x19573C0 VA: 0x1819581C0 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958550 Offset: 0x1957750 VA: 0x181958550
	private void ImportVars(HardwareJoystickMap.Platform_DirectInput_Base.Axis source) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_DirectInput_Base.TJJPvrRPwEftqDLGrphYsagqngXdb : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 7394
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_DirectInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CtZZtGqgZOqtPpZDjusuDmHoiIUR; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959010 Offset: 0x1958210 VA: 0x181959010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968B60 Offset: 0x1967D60 VA: 0x181968B60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968AA0 Offset: 0x1967CA0 VA: 0x181968AA0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1968AA0 Offset: 0x1967CA0 VA: 0x181968AA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_DirectInput_Base.ytucMFzOFZultkXVQBKIUOKiRrW : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 7395
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_DirectInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RbmHGTJWxUYimQVDPCdnGrxmMtRfb; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959670 Offset: 0x1958870 VA: 0x181959670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969730 Offset: 0x1968930 VA: 0x181969730 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969670 Offset: 0x1968870 VA: 0x181969670 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969670 Offset: 0x1968870 VA: 0x181969670 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_DirectInput_Base : HardwareJoystickMap.Platform_RawOrDirectInput // TypeDefIndex: 7396
{
	// Fields
	public HardwareJoystickMap.Platform_DirectInput_Base.Elements elements; // 0x20

	// Properties
	internal override InputPlatform platform { get; }
	internal HardwareJoystickMap.Platform_DirectInput_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_DirectInput_Base.Button[] Buttons_orig { get; }
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_DirectInput_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_DirectInput_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195E5D0 Offset: 0x195D7D0 VA: 0x18195E5D0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x195E0C0 Offset: 0x195D2C0 VA: 0x18195E0C0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x195D920 Offset: 0x195CB20 VA: 0x18195D920 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x195DC10 Offset: 0x195CE10 VA: 0x18195DC10 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x195DF00 Offset: 0x195D100 VA: 0x18195DF00 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195E930 Offset: 0x195DB30 VA: 0x18195E930 Slot: 24
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> IterateAxes() { }

	// RVA: 0x195E9B0 Offset: 0x195DBB0 VA: 0x18195E9B0 Slot: 25
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> IterateButtons() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x195D8B0 Offset: 0x195CAB0 VA: 0x18195D8B0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x195D7D0 Offset: 0x195C9D0 VA: 0x18195D7D0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_DirectInput : HardwareJoystickMap.Platform_DirectInput_Base // TypeDefIndex: 7397
{
	// Fields
	public HardwareJoystickMap.Platform_DirectInput_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195ECA0 Offset: 0x195DEA0 VA: 0x18195ECA0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x195EB30 Offset: 0x195DD30 VA: 0x18195EB30 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_RawInput_Base.Elements.QjLGbBfTFUcvDOykvDhQgbebpEveA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 7398
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_RawInput_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B710 Offset: 0x195A910 VA: 0x18195B710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19688B0 Offset: 0x1967AB0 VA: 0x1819688B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19687F0 Offset: 0x19679F0 VA: 0x1819687F0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19687F0 Offset: 0x19679F0 VA: 0x1819687F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_RawInput_Base.Elements.pmhEoaiXVNYyfJVUnnxUeINWkekW : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 7399
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_RawInput_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968D50 Offset: 0x1967F50 VA: 0x181968D50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969130 Offset: 0x1968330 VA: 0x181969130 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969070 Offset: 0x1968270 VA: 0x181969070 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969070 Offset: 0x1968270 VA: 0x181969070 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawInput_Base.Elements : HardwareJoystickMap.Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 7400
{
	// Fields
	public HardwareJoystickMap.Platform_RawInput_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_RawInput_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> Axes { get; }
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> Buttons { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A5B0 Offset: 0x19597B0 VA: 0x18195A5B0 Slot: 11
	internal override HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base GetAxis(int axisIndex) { }

	// RVA: 0x195B310 Offset: 0x195A510 VA: 0x18195B310 Slot: 12
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> get_Axes() { }

	// RVA: 0x195B590 Offset: 0x195A790 VA: 0x18195B590 Slot: 13
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> get_Buttons() { }

	// RVA: 0x195B0E0 Offset: 0x195A2E0 VA: 0x18195B0E0 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195A5F0 Offset: 0x19597F0 VA: 0x18195A5F0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195A3F0 Offset: 0x19595F0 VA: 0x18195A3F0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x195A130 Offset: 0x1959330 VA: 0x18195A130 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawInput_Base.Button : HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 7401
{
	// Fields
	public int sourceOtherAxis; // 0x68

	// Methods

	// RVA: 0x1958880 Offset: 0x1957A80 VA: 0x181958880
	public void .ctor() { }

	// RVA: 0x1958A90 Offset: 0x1957C90 VA: 0x181958A90 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958D10 Offset: 0x1957F10 VA: 0x181958D10
	private void ImportVars(HardwareJoystickMap.Platform_RawInput_Base.Button source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawInput_Base.Axis : HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 7402
{
	// Fields
	public int sourceOtherAxis; // 0x70

	// Methods

	// RVA: 0x1957F00 Offset: 0x1957100 VA: 0x181957F00
	public void .ctor() { }

	// RVA: 0x1958040 Offset: 0x1957240 VA: 0x181958040 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958560 Offset: 0x1957760 VA: 0x181958560
	private void ImportVars(HardwareJoystickMap.Platform_RawInput_Base.Axis source) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_RawInput_Base.CHULwOAcReouNDVRdLwQSzkVlpNU : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> // TypeDefIndex: 7403
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_RawInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CtZZtGqgZOqtPpZDjusuDmHoiIUR; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959010 Offset: 0x1958210 VA: 0x181959010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1959180 Offset: 0x1958380 VA: 0x181959180 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19590C0 Offset: 0x19582C0 VA: 0x1819590C0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19590C0 Offset: 0x19582C0 VA: 0x1819590C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_RawInput_Base.MgOBoLjEwGhYfIlSEqeANHczpvxd : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>, IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> // TypeDefIndex: 7404
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_RawInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RbmHGTJWxUYimQVDPCdnGrxmMtRfb; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959670 Offset: 0x1958870 VA: 0x181959670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195D690 Offset: 0x195C890 VA: 0x18195D690 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195D5D0 Offset: 0x195C7D0 VA: 0x18195D5D0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195D5D0 Offset: 0x195C7D0 VA: 0x18195D5D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_RawInput_Base : HardwareJoystickMap.Platform_RawOrDirectInput // TypeDefIndex: 7405
{
	// Fields
	public HardwareJoystickMap.Platform_RawInput_Base.Elements elements; // 0x20

	// Properties
	internal override InputPlatform platform { get; }
	internal HardwareJoystickMap.Platform_RawInput_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_RawInput_Base.Button[] Buttons_orig { get; }
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_RawInput_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_RawInput_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x19637D0 Offset: 0x19629D0 VA: 0x1819637D0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x19632C0 Offset: 0x19624C0 VA: 0x1819632C0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1962B80 Offset: 0x1961D80 VA: 0x181962B80 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1962E70 Offset: 0x1962070 VA: 0x181962E70 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1963160 Offset: 0x1962360 VA: 0x181963160 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1963B30 Offset: 0x1962D30 VA: 0x181963B30 Slot: 24
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base> IterateAxes() { }

	// RVA: 0x1963BB0 Offset: 0x1962DB0 VA: 0x181963BB0 Slot: 25
	internal override IEnumerable<HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base> IterateButtons() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x1962B10 Offset: 0x1961D10 VA: 0x181962B10 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1962A30 Offset: 0x1961C30 VA: 0x181962A30 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_RawInput : HardwareJoystickMap.Platform_RawInput_Base // TypeDefIndex: 7406
{
	// Fields
	public HardwareJoystickMap.Platform_RawInput_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1963DA0 Offset: 0x1962FA0 VA: 0x181963DA0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1963C30 Offset: 0x1962E30 VA: 0x181963C30 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XInput_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7407
{
	// Fields
	public XInputDeviceSubType[] subType; // 0x28

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x195D510 Offset: 0x195C710 VA: 0x18195D510 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x195CB10 Offset: 0x195BD10 VA: 0x18195CB10 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C870 Offset: 0x195BA70 VA: 0x18195C870 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195C630 Offset: 0x195B830 VA: 0x18195C630 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x195C330 Offset: 0x195B530 VA: 0x18195C330 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XInput_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7408
{
	// Fields
	public HardwareJoystickMap.Platform_XInput_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_XInput_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A310 Offset: 0x1959510 VA: 0x18195A310 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x195A090 Offset: 0x1959290 VA: 0x18195A090 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195AD70 Offset: 0x1959F70 VA: 0x18195AD70 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_XInput_Base.Element : IDeepCloneable // TypeDefIndex: 7409
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceType sourceType; // 0x14
	public XInputButton sourceButton; // 0x18
	public XInputAxis sourceAxis; // 0x1C
	public float axisDeadZone; // 0x20

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x1959EB0 Offset: 0x19590B0 VA: 0x181959EB0 Slot: 6
	internal virtual void CopyVars(HardwareJoystickMap.Platform_XInput_Base.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XInput_Base.Button : HardwareJoystickMap.Platform_XInput_Base.Element // TypeDefIndex: 7410
{
	// Fields
	public Pole sourceAxisPole; // 0x28
	public HardwareButtonInfo buttonInfo; // 0x30

	// Methods

	// RVA: 0x1958FF0 Offset: 0x19581F0 VA: 0x181958FF0
	public void .ctor() { }

	// RVA: 0x1958B80 Offset: 0x1957D80 VA: 0x181958B80 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x19588A0 Offset: 0x1957AA0 VA: 0x1819588A0 Slot: 6
	internal override void CopyVars(HardwareJoystickMap.Platform_XInput_Base.Element destination) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XInput_Base.Axis : HardwareJoystickMap.Platform_XInput_Base.Element // TypeDefIndex: 7411
{
	// Fields
	public bool invert; // 0x28
	public Pole buttonAxisContribution; // 0x2C
	public AxisRange sourceAxisRange; // 0x30
	public bool calibrateAxis; // 0x34
	public float axisZero; // 0x38
	public float axisMin; // 0x3C
	public float axisMax; // 0x40
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x48
	public HardwareAxisInfo axisInfo; // 0x50

	// Methods

	// RVA: 0x19586F0 Offset: 0x19578F0 VA: 0x1819586F0
	public void .ctor() { }

	// RVA: 0x1958140 Offset: 0x1957340 VA: 0x181958140 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1957F20 Offset: 0x1957120 VA: 0x181957F20 Slot: 6
	internal override void CopyVars(HardwareJoystickMap.Platform_XInput_Base.Element destination) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_XInput_Base.bbFcdjchthzXoUeuMoiSrxXtYDBi : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_XInput_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_XInput_Base.Axis> // TypeDefIndex: 7412
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_XInput_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_XInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_XInput_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_XInput_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968D10 Offset: 0x1967F10 VA: 0x181968D10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968C50 Offset: 0x1967E50 VA: 0x181968C50 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_XInput_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1968C50 Offset: 0x1967E50 VA: 0x181968C50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_XInput_Base.RHoHKfShhnaWotHPDexvKDLhbvcJ : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_XInput_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_XInput_Base.Button> // TypeDefIndex: 7413
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_XInput_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_XInput_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_XInput_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_XInput_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968A60 Offset: 0x1967C60 VA: 0x181968A60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19689A0 Offset: 0x1967BA0 VA: 0x1819689A0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_XInput_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_XInput_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19689A0 Offset: 0x1967BA0 VA: 0x1819689A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_XInput_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7414
{
	// Fields
	public HardwareJoystickMap.Platform_XInput_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_XInput_Base.Elements elements; // 0x20

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal HardwareJoystickMap.Platform_XInput_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_XInput_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_XInput_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_XInput_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1967D40 Offset: 0x1966F40 VA: 0x181967D40
	internal IEnumerable<HardwareJoystickMap.Platform_XInput_Base.Axis> IterateAxes() { }

	// RVA: 0x1967DC0 Offset: 0x1966FC0 VA: 0x181967DC0
	internal IEnumerable<HardwareJoystickMap.Platform_XInput_Base.Button> IterateButtons() { }

	// RVA: 0x1967A90 Offset: 0x1966C90 VA: 0x181967A90 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1967570 Offset: 0x1966770 VA: 0x181967570 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1966E40 Offset: 0x1966040 VA: 0x181966E40 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1967130 Offset: 0x1966330 VA: 0x181967130 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1967410 Offset: 0x1966610 VA: 0x181967410 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1966DD0 Offset: 0x1965FD0 VA: 0x181966DD0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1966CE0 Offset: 0x1965EE0 VA: 0x181966CE0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XInput : HardwareJoystickMap.Platform_XInput_Base // TypeDefIndex: 7415
{
	// Fields
	public HardwareJoystickMap.Platform_XInput_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1967FC0 Offset: 0x19671C0 VA: 0x181967FC0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1967E40 Offset: 0x1967040 VA: 0x181967E40 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX_Base.MatchingCriteria.ElementCount : HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 7416
{
	// Fields
	public int hatCount; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1959B30 Offset: 0x1958D30 VA: 0x181959B30 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1959D60 Offset: 0x1958F60 VA: 0x181959D60 Slot: 6
	internal override void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x1959AF0 Offset: 0x1958CF0 VA: 0x181959AF0 Slot: 7
	internal override bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7417
{
	// Fields
	public int hatCount; // 0x28
	public HardwareJoystickMap.Platform_OSX_Base.MatchingCriteria.ElementCount[] alternateElementCounts; // 0x30
	public bool productName_useRegex; // 0x38
	public string[] productName; // 0x40
	public string[] manufacturer; // 0x48
	public int[] productId; // 0x50
	public int[] vendorId; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x195D4C0 Offset: 0x195C6C0 VA: 0x18195D4C0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x195CF40 Offset: 0x195C140 VA: 0x18195CF40 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x195D4A0 Offset: 0x195C6A0 VA: 0x18195D4A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x195C880 Offset: 0x195BA80 VA: 0x18195C880 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C7F0 Offset: 0x195B9F0 VA: 0x18195C7F0 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195D3C0 Offset: 0x195C5C0 VA: 0x18195D3C0
	private bool ProductNameMatches(string name) { }

	// RVA: 0x195C710 Offset: 0x195B910 VA: 0x18195C710 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x195C3D0 Offset: 0x195B5D0 VA: 0x18195C3D0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_OSX_Base.Elements.IMzIhtUTsSYJSOAMcioDwgYiDoWW : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Axis> // TypeDefIndex: 7418
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_OSX_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_OSX_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private HardwareJoystickMap.Platform_OSX_Base.Axis[] BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x30
	private int FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x38

	// Properties
	private HardwareJoystickMap.Platform_OSX_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B9A0 Offset: 0x195ABA0 VA: 0x18195B9A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_OSX_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195BAF0 Offset: 0x195ACF0 VA: 0x18195BAF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195BA30 Offset: 0x195AC30 VA: 0x18195BA30 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195BA30 Offset: 0x195AC30 VA: 0x18195BA30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_OSX_Base.Elements.ltlABNHNAhjVjUDznVoNVkKZOrEWA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Button> // TypeDefIndex: 7419
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_OSX_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_OSX_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private HardwareJoystickMap.Platform_OSX_Base.Button[] BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x30
	private int FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x38

	// Properties
	private HardwareJoystickMap.Platform_OSX_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968EE0 Offset: 0x19680E0 VA: 0x181968EE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_OSX_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969030 Offset: 0x1968230 VA: 0x181969030 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968F70 Offset: 0x1968170 VA: 0x181968F70 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1968F70 Offset: 0x1968170 VA: 0x181968F70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7420
{
	// Fields
	public HardwareJoystickMap.Platform_OSX_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_OSX_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195B210 Offset: 0x195A410 VA: 0x18195B210
	public IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Axis> IterateAxes() { }

	// RVA: 0x195B290 Offset: 0x195A490 VA: 0x18195B290
	public IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Button> IterateButtons() { }

	// RVA: 0x195A460 Offset: 0x1959660 VA: 0x18195A460 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x195A270 Offset: 0x1959470 VA: 0x18195A270 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195A9B0 Offset: 0x1959BB0 VA: 0x18195A9B0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_OSX_Base.Element : IDeepCloneable // TypeDefIndex: 7421
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX_Base.Button : HardwareJoystickMap.Platform_OSX_Base.Element // TypeDefIndex: 7422
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceButton; // 0x18
	public int sourceStick; // 0x1C
	public OSXAxis sourceAxis; // 0x20
	public int sourceOtherAxis; // 0x24
	public Pole sourceAxisPole; // 0x28
	public float axisDeadZone; // 0x2C
	public int sourceHat; // 0x30
	public HatType sourceHatType; // 0x34
	public HatDirection sourceHatDirection; // 0x38
	public bool requireMultipleButtons; // 0x3C
	public int[] requiredButtons; // 0x40
	public bool ignoreIfButtonsActive; // 0x48
	public int[] ignoreIfButtonsActiveButtons; // 0x50
	public HardwareButtonInfo buttonInfo; // 0x58

	// Methods

	// RVA: 0x1958FF0 Offset: 0x19581F0 VA: 0x181958FF0
	public void .ctor() { }

	// RVA: 0x1958970 Offset: 0x1957B70 VA: 0x181958970 Slot: 5
	public override object DeepClone() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX_Base.Axis : HardwareJoystickMap.Platform_OSX_Base.Element // TypeDefIndex: 7423
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceStick; // 0x18
	public OSXAxis sourceAxis; // 0x1C
	public int sourceOtherAxis; // 0x20
	public AxisRange sourceAxisRange; // 0x24
	public bool invert; // 0x28
	public float axisDeadZone; // 0x2C
	public bool calibrateAxis; // 0x30
	public float axisZero; // 0x34
	public float axisMin; // 0x38
	public float axisMax; // 0x3C
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x40
	public HardwareAxisInfo axisInfo; // 0x48
	public int sourceButton; // 0x50
	public Pole buttonAxisContribution; // 0x54
	public int sourceHat; // 0x58
	public AxisDirection sourceHatDirection; // 0x5C
	public AxisRange sourceHatRange; // 0x60

	// Methods

	// RVA: 0x1958710 Offset: 0x1957910 VA: 0x181958710
	public void .ctor() { }

	// RVA: 0x1958230 Offset: 0x1957430 VA: 0x181958230 Slot: 5
	public override object DeepClone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_OSX_Base.wJxkbbqeuElyrhmWuGsbsthhkjqV : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Axis> // TypeDefIndex: 7424
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_OSX_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_OSX_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_OSX_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_OSX_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969430 Offset: 0x1968630 VA: 0x181969430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969370 Offset: 0x1968570 VA: 0x181969370 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969370 Offset: 0x1968570 VA: 0x181969370 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_OSX_Base.ujcdFihtAhnasrbOVjqxbQZaFIsk : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Button> // TypeDefIndex: 7425
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_OSX_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_OSX_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_OSX_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_OSX_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969330 Offset: 0x1968530 VA: 0x181969330 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969270 Offset: 0x1968470 VA: 0x181969270 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_OSX_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_OSX_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969270 Offset: 0x1968470 VA: 0x181969270 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_OSX_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7426
{
	// Fields
	public HardwareJoystickMap.Platform_OSX_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_OSX_Base.Elements elements; // 0x20

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal HardwareJoystickMap.Platform_OSX_Base.Button[] Buttons_orig { get; }
	internal HardwareJoystickMap.Platform_OSX_Base.Axis[] Axes_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_OSX_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_OSX_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1962740 Offset: 0x1961940 VA: 0x181962740
	internal IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Axis> IterateAxes() { }

	// RVA: 0x19627C0 Offset: 0x19619C0 VA: 0x1819627C0
	internal IEnumerable<HardwareJoystickMap.Platform_OSX_Base.Button> IterateButtons() { }

	// RVA: 0x1962490 Offset: 0x1961690 VA: 0x181962490 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1961F70 Offset: 0x1961170 VA: 0x181961F70 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1961830 Offset: 0x1960A30 VA: 0x181961830 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1961B20 Offset: 0x1960D20 VA: 0x181961B20 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1961E10 Offset: 0x1961010 VA: 0x181961E10 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x19617C0 Offset: 0x19609C0 VA: 0x1819617C0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19616D0 Offset: 0x19608D0 VA: 0x1819616D0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_OSX : HardwareJoystickMap.Platform_OSX_Base // TypeDefIndex: 7427
{
	// Fields
	public HardwareJoystickMap.Platform_OSX_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x19629C0 Offset: 0x1961BC0 VA: 0x1819629C0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1962840 Offset: 0x1961A40 VA: 0x181962840 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_Linux_Base.MatchingCriteria.ElementCount : HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 7428
{
	// Fields
	public int hatCount; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1959C80 Offset: 0x1958E80 VA: 0x181959C80 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1959CF0 Offset: 0x1958EF0 VA: 0x181959CF0 Slot: 6
	internal override void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x1959AF0 Offset: 0x1958CF0 VA: 0x181959AF0 Slot: 7
	internal override bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Linux_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7429
{
	// Fields
	public int hatCount; // 0x28
	public HardwareJoystickMap.Platform_Linux_Base.MatchingCriteria.ElementCount[] alternateElementCounts; // 0x30
	public bool manufacturer_useRegex; // 0x38
	public bool productName_useRegex; // 0x39
	public bool systemName_useRegex; // 0x3A
	public string[] manufacturer; // 0x40
	public string[] productName; // 0x48
	public string[] systemName; // 0x50
	public string[] productGUID; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x195D540 Offset: 0x195C740 VA: 0x18195D540 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x195CDE0 Offset: 0x195BFE0 VA: 0x18195CDE0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x195D4A0 Offset: 0x195C6A0 VA: 0x18195D4A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x195C880 Offset: 0x195BA80 VA: 0x18195C880 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C7F0 Offset: 0x195B9F0 VA: 0x18195C7F0 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195BD00 Offset: 0x195AF00 VA: 0x18195BD00
	private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

	// RVA: 0x195D140 Offset: 0x195C340 VA: 0x18195D140
	private bool NameMatches(string name, string[] names, bool useRegex) { }

	// RVA: 0x195C780 Offset: 0x195B980 VA: 0x18195C780 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x195C230 Offset: 0x195B430 VA: 0x18195C230 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Linux_Base.Elements.EqXFnSWSntiVFGLbzLddDxfTiKlAA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Axis> // TypeDefIndex: 7430
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Linux_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Linux_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Linux_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B710 Offset: 0x195A910 VA: 0x18195B710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Linux_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195B860 Offset: 0x195AA60 VA: 0x18195B860 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195B7A0 Offset: 0x195A9A0 VA: 0x18195B7A0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195B7A0 Offset: 0x195A9A0 VA: 0x18195B7A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Linux_Base.Elements.dJsGBUIIeuUEEBEhAcaFhaJWeUOPA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Button> // TypeDefIndex: 7431
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Linux_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Linux_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Linux_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968D50 Offset: 0x1967F50 VA: 0x181968D50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Linux_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968EA0 Offset: 0x19680A0 VA: 0x181968EA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1968DE0 Offset: 0x1967FE0 VA: 0x181968DE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1968DE0 Offset: 0x1967FE0 VA: 0x181968DE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Linux_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7432
{
	// Fields
	public HardwareJoystickMap.Platform_Linux_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_Linux_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Axis> Axes { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Button> Buttons { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A5B0 Offset: 0x19597B0 VA: 0x18195A5B0
	internal HardwareJoystickMap.Platform_Linux_Base.Axis GetAxis(int axisIndex) { }

	// RVA: 0x195B490 Offset: 0x195A690 VA: 0x18195B490
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Axis> get_Axes() { }

	// RVA: 0x195B690 Offset: 0x195A890 VA: 0x18195B690
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Button> get_Buttons() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195AB90 Offset: 0x1959D90 VA: 0x18195AB90 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195A4D0 Offset: 0x19596D0 VA: 0x18195A4D0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x1959FF0 Offset: 0x19591F0 VA: 0x181959FF0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Linux_Base.Element : IDeepCloneable // TypeDefIndex: 7433
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void ImportVars(HardwareJoystickMap.Platform_Linux_Base.Element source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Linux_Base.Button : HardwareJoystickMap.Platform_Linux_Base.Element // TypeDefIndex: 7434
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceButton; // 0x18
	public int sourceAxis; // 0x1C
	public Pole sourceAxisPole; // 0x20
	public float axisDeadZone; // 0x24
	public int sourceHat; // 0x28
	public HatType sourceHatType; // 0x2C
	public HatDirection sourceHatDirection; // 0x30
	public bool requireMultipleButtons; // 0x34
	public int[] requiredButtons; // 0x38
	public bool ignoreIfButtonsActive; // 0x40
	public int[] ignoreIfButtonsActiveButtons; // 0x48
	public HardwareButtonInfo buttonInfo; // 0x50

	// Methods

	// RVA: 0x1958FF0 Offset: 0x19581F0 VA: 0x181958FF0
	public void .ctor() { }

	// RVA: 0x1958C80 Offset: 0x1957E80 VA: 0x181958C80 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958EA0 Offset: 0x19580A0 VA: 0x181958EA0 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_Linux_Base.Element source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Linux_Base.Axis : HardwareJoystickMap.Platform_Linux_Base.Element // TypeDefIndex: 7435
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceAxis; // 0x18
	public AxisRange sourceAxisRange; // 0x1C
	public bool invert; // 0x20
	public float axisDeadZone; // 0x24
	public bool calibrateAxis; // 0x28
	public float axisZero; // 0x2C
	public float axisMin; // 0x30
	public float axisMax; // 0x34
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
	public HardwareAxisInfo axisInfo; // 0x40
	public int sourceButton; // 0x48
	public Pole buttonAxisContribution; // 0x4C
	public int sourceHat; // 0x50
	public AxisDirection sourceHatDirection; // 0x54
	public AxisRange sourceHatRange; // 0x58

	// Methods

	// RVA: 0x19586F0 Offset: 0x19578F0 VA: 0x1819586F0
	public void .ctor() { }

	// RVA: 0x1958380 Offset: 0x1957580 VA: 0x181958380 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x19585A0 Offset: 0x19577A0 VA: 0x1819585A0 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_Linux_Base.Element source) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Linux_Base.PJzsmBorxfblVZVtOFGJfagSidDcb : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Axis> // TypeDefIndex: 7436
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Linux_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Linux_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CtZZtGqgZOqtPpZDjusuDmHoiIUR; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_Linux_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959010 Offset: 0x1958210 VA: 0x181959010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Linux_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195D790 Offset: 0x195C990 VA: 0x18195D790 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195D6D0 Offset: 0x195C8D0 VA: 0x18195D6D0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195D6D0 Offset: 0x195C8D0 VA: 0x18195D6D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Linux_Base.DdiCfRkZInvxuhaOWZWNOTkAirOaA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Button> // TypeDefIndex: 7437
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Linux_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Linux_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RbmHGTJWxUYimQVDPCdnGrxmMtRfb; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_Linux_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959670 Offset: 0x1958870 VA: 0x181959670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Linux_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19597E0 Offset: 0x19589E0 VA: 0x1819597E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1959720 Offset: 0x1958920 VA: 0x181959720 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Linux_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Linux_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1959720 Offset: 0x1958920 VA: 0x181959720 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Linux_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7438
{
	// Fields
	public HardwareJoystickMap.Platform_Linux_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_Linux_Base.Elements elements; // 0x20

	// Properties
	internal override InputPlatform platform { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal HardwareJoystickMap.Platform_Linux_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_Linux_Base.Button[] Buttons_orig { get; }
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x56EDC0 Offset: 0x56DFC0 VA: 0x18056EDC0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_Linux_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_Linux_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x19610E0 Offset: 0x19602E0 VA: 0x1819610E0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1960BC0 Offset: 0x195FDC0 VA: 0x181960BC0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1960480 Offset: 0x195F680 VA: 0x181960480 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1960770 Offset: 0x195F970 VA: 0x181960770 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1960A60 Offset: 0x195FC60 VA: 0x181960A60 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1961390 Offset: 0x1960590 VA: 0x181961390
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Axis> IterateAxes() { }

	// RVA: 0x1961410 Offset: 0x1960610 VA: 0x181961410
	internal IEnumerable<HardwareJoystickMap.Platform_Linux_Base.Button> IterateButtons() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x1960410 Offset: 0x195F610 VA: 0x181960410 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1960340 Offset: 0x195F540 VA: 0x181960340 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Linux : HardwareJoystickMap.Platform_Linux_Base // TypeDefIndex: 7439
{
	// Fields
	public HardwareJoystickMap.Platform_Linux_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1961660 Offset: 0x1960860 VA: 0x181961660 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1961500 Offset: 0x1960700 VA: 0x181961500 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.MatchingCriteria.ElementCount : HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 7440
{
	// Fields
	public int hatCount; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1959C10 Offset: 0x1958E10 VA: 0x181959C10 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1959E40 Offset: 0x1959040 VA: 0x181959E40 Slot: 6
	internal override void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x1959AF0 Offset: 0x1958CF0 VA: 0x181959AF0 Slot: 7
	internal override bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7441
{
	// Fields
	public int hatCount; // 0x28
	public HardwareJoystickMap.Platform_WindowsUWP_Base.MatchingCriteria.ElementCount[] alternateElementCounts; // 0x30
	public bool manufacturer_useRegex; // 0x38
	public bool productName_useRegex; // 0x39
	public string[] manufacturer; // 0x40
	public string[] productName; // 0x48
	public string[] productGUID; // 0x50
	public HardwareJoystickMap.Platform_WindowsUWP_Base.DeviceType deviceType; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x195D570 Offset: 0x195C770 VA: 0x18195D570 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x195C130 Offset: 0x195B330 VA: 0x18195C130 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x195CBF0 Offset: 0x195BDF0 VA: 0x18195CBF0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x195D4A0 Offset: 0x195C6A0 VA: 0x18195D4A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x195C880 Offset: 0x195BA80 VA: 0x18195C880 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C7F0 Offset: 0x195B9F0 VA: 0x18195C7F0 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x195BC30 Offset: 0x195AE30 VA: 0x18195BC30
	private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

	// RVA: 0x195D140 Offset: 0x195C340 VA: 0x18195D140
	private bool NameMatches(string name, string[] names, bool useRegex) { }

	// RVA: 0x195C8C0 Offset: 0x195BAC0 VA: 0x18195C8C0
	private bool HasProductName() { }

	// RVA: 0x195C5C0 Offset: 0x195B7C0 VA: 0x18195C5C0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x195C4D0 Offset: 0x195B6D0 VA: 0x18195C4D0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.Elements.PswzhXEUsVNxRFQYxjNFjsHywdeD : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> // TypeDefIndex: 7442
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsUWP_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B710 Offset: 0x195A910 VA: 0x18195B710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19687B0 Offset: 0x19679B0 VA: 0x1819687B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19686F0 Offset: 0x19678F0 VA: 0x1819686F0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19686F0 Offset: 0x19678F0 VA: 0x1819686F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.Elements.yUlKUOgPUvWKzgGYlVwTKHYWYaIF : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> // TypeDefIndex: 7443
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsUWP_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968D50 Offset: 0x1967F50 VA: 0x181968D50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969530 Offset: 0x1968730 VA: 0x181969530 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1969470 Offset: 0x1968670 VA: 0x181969470 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1969470 Offset: 0x1968670 VA: 0x181969470 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7444
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsUWP_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_WindowsUWP_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> Axes { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> Buttons { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A5B0 Offset: 0x19597B0 VA: 0x18195A5B0
	internal HardwareJoystickMap.Platform_WindowsUWP_Base.Axis GetAxis(int axisIndex) { }

	// RVA: 0x195B390 Offset: 0x195A590 VA: 0x18195B390
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> get_Axes() { }

	// RVA: 0x195B510 Offset: 0x195A710 VA: 0x18195B510
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> get_Buttons() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195A7D0 Offset: 0x19599D0 VA: 0x18195A7D0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195A380 Offset: 0x1959580 VA: 0x18195A380 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x195A1D0 Offset: 0x19593D0 VA: 0x18195A1D0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_WindowsUWP_Base.Element : IDeepCloneable // TypeDefIndex: 7445
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void ImportVars(HardwareJoystickMap.Platform_WindowsUWP_Base.Element source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_WindowsUWP_Base.Button : HardwareJoystickMap.Platform_WindowsUWP_Base.Element // TypeDefIndex: 7446
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceButton; // 0x18
	public int sourceAxis; // 0x1C
	public Pole sourceAxisPole; // 0x20
	public float axisDeadZone; // 0x24
	public int sourceHat; // 0x28
	public HatType sourceHatType; // 0x2C
	public HatDirection sourceHatDirection; // 0x30
	public bool requireMultipleButtons; // 0x34
	public int[] requiredButtons; // 0x38
	public bool ignoreIfButtonsActive; // 0x40
	public int[] ignoreIfButtonsActiveButtons; // 0x48
	public HardwareButtonInfo buttonInfo; // 0x50

	// Methods

	// RVA: 0x1958FF0 Offset: 0x19581F0 VA: 0x181958FF0
	public void .ctor() { }

	// RVA: 0x1958C00 Offset: 0x1957E00 VA: 0x181958C00 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958D50 Offset: 0x1957F50 VA: 0x181958D50 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_WindowsUWP_Base.Element source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_WindowsUWP_Base.Axis : HardwareJoystickMap.Platform_WindowsUWP_Base.Element // TypeDefIndex: 7447
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceAxis; // 0x18
	public AxisRange sourceAxisRange; // 0x1C
	public bool invert; // 0x20
	public float axisDeadZone; // 0x24
	public bool calibrateAxis; // 0x28
	public float axisZero; // 0x2C
	public float axisMin; // 0x30
	public float axisMax; // 0x34
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
	public HardwareAxisInfo axisInfo; // 0x40
	public int sourceButton; // 0x48
	public Pole buttonAxisContribution; // 0x4C
	public int sourceHat; // 0x50
	public AxisDirection sourceHatDirection; // 0x54
	public AxisRange sourceHatRange; // 0x58

	// Methods

	// RVA: 0x19586F0 Offset: 0x19578F0 VA: 0x1819586F0
	public void .ctor() { }

	// RVA: 0x19580C0 Offset: 0x19572C0 VA: 0x1819580C0 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1958400 Offset: 0x1957600 VA: 0x181958400 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_WindowsUWP_Base.Element source) { }
}

// Namespace: 
public enum HardwareJoystickMap.Platform_WindowsUWP_Base.DeviceType // TypeDefIndex: 7448
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_WindowsUWP_Base.DeviceType HIDJoystick = 0;
	public const HardwareJoystickMap.Platform_WindowsUWP_Base.DeviceType WGIGamepad = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.FiIiVRlntJpfjfORBPTlZmDgPDvI : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> // TypeDefIndex: 7449
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsUWP_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CtZZtGqgZOqtPpZDjusuDmHoiIUR; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959010 Offset: 0x1958210 VA: 0x181959010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195B960 Offset: 0x195AB60 VA: 0x18195B960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195B8A0 Offset: 0x195AAA0 VA: 0x18195B8A0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195B8A0 Offset: 0x195AAA0 VA: 0x18195B8A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsUWP_Base.LrvTHdHPGfsAgbGcPxeMjsgaBpcq : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> // TypeDefIndex: 7450
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsUWP_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RbmHGTJWxUYimQVDPCdnGrxmMtRfb; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959670 Offset: 0x1958870 VA: 0x181959670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_WindowsUWP_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195BBF0 Offset: 0x195ADF0 VA: 0x18195BBF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x195BB30 Offset: 0x195AD30 VA: 0x18195BB30 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_WindowsUWP_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x195BB30 Offset: 0x195AD30 VA: 0x18195BB30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_WindowsUWP_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7451
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsUWP_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_WindowsUWP_Base.Elements elements; // 0x20

	// Properties
	internal override InputPlatform platform { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal HardwareJoystickMap.Platform_WindowsUWP_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_WindowsUWP_Base.Button[] Buttons_orig { get; }
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_WindowsUWP_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_WindowsUWP_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1966760 Offset: 0x1965960 VA: 0x181966760 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1966240 Offset: 0x1965440 VA: 0x181966240 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1965B00 Offset: 0x1964D00 VA: 0x181965B00 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1965DF0 Offset: 0x1964FF0 VA: 0x181965DF0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x19660E0 Offset: 0x19652E0 VA: 0x1819660E0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1966A10 Offset: 0x1965C10 VA: 0x181966A10
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Axis> IterateAxes() { }

	// RVA: 0x1966A90 Offset: 0x1965C90 VA: 0x181966A90
	internal IEnumerable<HardwareJoystickMap.Platform_WindowsUWP_Base.Button> IterateButtons() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x1965A90 Offset: 0x1964C90 VA: 0x181965A90 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19659C0 Offset: 0x1964BC0 VA: 0x1819659C0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsUWP : HardwareJoystickMap.Platform_WindowsUWP_Base // TypeDefIndex: 7452
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsUWP_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195ED10 Offset: 0x195DF10 VA: 0x18195ED10 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1966C70 Offset: 0x1965E70 VA: 0x181966C70 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1966B10 Offset: 0x1965D10 VA: 0x181966B10 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Fallback_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7453
{
	// Fields
	public bool alwaysMatch; // 0x28
	public bool productName_useRegex; // 0x29
	public string[] productName; // 0x30
	public bool matchUnityVersion; // 0x38
	public string matchUnityVersion_min; // 0x40
	public string matchUnityVersion_max; // 0x48
	public bool matchSysVersion; // 0x50
	public string matchSysVersion_min; // 0x58
	public string matchSysVersion_max; // 0x60

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x196FC80 Offset: 0x196EE80 VA: 0x18196FC80 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FD00 Offset: 0x196EF00 VA: 0x18196FD00 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E9F0 Offset: 0x196DBF0 VA: 0x18196E9F0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C870 Offset: 0x195BA70 VA: 0x18195C870 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196E4A0 Offset: 0x196D6A0 VA: 0x18196E4A0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DFE0 Offset: 0x196D1E0 VA: 0x18196DFE0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Fallback_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7454
{
	// Fields
	public HardwareJoystickMap.Platform_Fallback_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_Fallback_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C770 Offset: 0x196B970 VA: 0x18196C770 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196BC00 Offset: 0x196AE00 VA: 0x18196BC00 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B3D0 Offset: 0x196A5D0 VA: 0x18196B3D0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 7455
{
	// Fields
	public int sourceType; // 0x10
	public int sourceElement; // 0x14
	public AxisRange sourceAxisRange; // 0x18
	public float deadzone; // 0x1C
	public bool invert; // 0x20

	// Methods

	// RVA: 0x196ABC0 Offset: 0x1969DC0 VA: 0x18196ABC0 Slot: 4
	public object DeepClone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Fallback_Base.Element : IDeepCloneable // TypeDefIndex: 7456
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public UnityAxis sourceAxis; // 0x18
	public float axisDeadZone; // 0x1C
	public UnityButton sourceButton; // 0x20
	public KeyCode sourceKeyCode; // 0x24
	public CustomCalculation customCalculation; // 0x28
	public HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData[] customCalculationSourceData; // 0x30

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x196B2A0 Offset: 0x196A4A0 VA: 0x18196B2A0 Slot: 6
	internal virtual void CopyVars(HardwareJoystickMap.Platform_Fallback_Base.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Fallback_Base.Button : HardwareJoystickMap.Platform_Fallback_Base.Element // TypeDefIndex: 7457
{
	// Fields
	public Pole sourceAxisPole; // 0x38
	public UnityAxis unityHat_sourceAxis1; // 0x3C
	public UnityAxis unityHat_sourceAxis2; // 0x40
	public Vector2 unityHat_isActiveAxisValues1; // 0x44
	public Vector2 unityHat_isActiveAxisValues2; // 0x4C
	public Vector2 unityHat_isActiveAxisValues3; // 0x54
	public Vector2 unityHat_zeroValues; // 0x5C
	public bool unityHat_checkNeverPressed; // 0x64
	public Vector2 unityHat_neverPressedZeroValues; // 0x68
	public bool requireMultipleButtons; // 0x70
	public UnityButton[] requiredButtons; // 0x78
	public bool ignoreIfButtonsActive; // 0x80
	public UnityButton[] ignoreIfButtonsActiveButtons; // 0x88
	public HardwareButtonInfo buttonInfo; // 0x90

	// Methods

	// RVA: 0x196A750 Offset: 0x1969950 VA: 0x18196A750 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x196A4D0 Offset: 0x19696D0 VA: 0x18196A4D0 Slot: 6
	internal override void CopyVars(HardwareJoystickMap.Platform_Fallback_Base.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Fallback_Base.Axis : HardwareJoystickMap.Platform_Fallback_Base.Element // TypeDefIndex: 7458
{
	// Fields
	public bool invert; // 0x38
	public AxisRange sourceAxisRange; // 0x3C
	public Pole buttonAxisContribution; // 0x40
	public bool calibrateAxis; // 0x44
	public float axisZero; // 0x48
	public float axisMin; // 0x4C
	public float axisMax; // 0x50
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
	public HardwareAxisInfo axisInfo; // 0x60

	// Methods

	// RVA: 0x1969C80 Offset: 0x1968E80 VA: 0x181969C80 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x1969770 Offset: 0x1968970 VA: 0x181969770 Slot: 6
	internal override void CopyVars(HardwareJoystickMap.Platform_Fallback_Base.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Fallback_Base.ELuRUbNlfhFqoQzSdsdIRxrmQIJL : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Fallback_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_Fallback_Base.Axis> // TypeDefIndex: 7459
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Fallback_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Fallback_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Fallback_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Fallback_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196B0A0 Offset: 0x196A2A0 VA: 0x18196B0A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196AFE0 Offset: 0x196A1E0 VA: 0x18196AFE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Fallback_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196AFE0 Offset: 0x196A1E0 VA: 0x18196AFE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_Fallback_Base.yEcIMVteWlqmztJNMTRQOTNIakSd : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Fallback_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_Fallback_Base.Button> // TypeDefIndex: 7460
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Fallback_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_Fallback_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Fallback_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Fallback_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C3A0 Offset: 0x197B5A0 VA: 0x18197C3A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C2E0 Offset: 0x197B4E0 VA: 0x18197C2E0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Fallback_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Fallback_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197C2E0 Offset: 0x197B4E0 VA: 0x18197C2E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Fallback_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7461
{
	// Fields
	public HardwareJoystickMap.Platform_Fallback_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_Fallback_Base.Elements elements; // 0x20

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal HardwareJoystickMap.Platform_Fallback_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_Fallback_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x19600D0 Offset: 0x195F2D0 VA: 0x1819600D0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_Fallback_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_Fallback_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1960050 Offset: 0x195F250 VA: 0x181960050 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195FEE0 Offset: 0x195F0E0 VA: 0x18195FEE0
	internal IEnumerable<HardwareJoystickMap.Platform_Fallback_Base.Axis> IterateAxes() { }

	// RVA: 0x195FF50 Offset: 0x195F150 VA: 0x18195FF50
	internal IEnumerable<HardwareJoystickMap.Platform_Fallback_Base.Button> IterateButtons() { }

	// RVA: 0x195FBD0 Offset: 0x195EDD0 VA: 0x18195FBD0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x195F6E0 Offset: 0x195E8E0 VA: 0x18195F6E0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x195EFA0 Offset: 0x195E1A0 VA: 0x18195EFA0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x195F290 Offset: 0x195E490 VA: 0x18195F290 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x195F580 Offset: 0x195E780 VA: 0x18195F580 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x195EF30 Offset: 0x195E130 VA: 0x18195EF30 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x195EE40 Offset: 0x195E040 VA: 0x18195EE40 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Fallback : HardwareJoystickMap.Platform_Fallback_Base // TypeDefIndex: 7462
{
	// Fields
	public HardwareJoystickMap.Platform_Fallback_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x19700D0 Offset: 0x196F2D0 VA: 0x1819700D0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1970060 Offset: 0x196F260 VA: 0x181970060 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x196FFB0 Offset: 0x196F1B0 VA: 0x18196FFB0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7463
{
	// Fields
	[Tooltip("If enabled, this will match to every controller regardless of other matching criteria.")]
	public bool alwaysMatch; // 0x28

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x196FB10 Offset: 0x196ED10 VA: 0x18196FB10 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCB0 Offset: 0x196EEB0 VA: 0x18196FCB0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E680 Offset: 0x196D880 VA: 0x18196E680 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C870 Offset: 0x195BA70 VA: 0x18195C870 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196DE40 Offset: 0x196D040 VA: 0x18196DE40 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7464
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Custom.CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 7465
{
	// Fields
	public int sourceType; // 0x10
	public int sourceAxis; // 0x14
	public int sourceButton; // 0x18
	public int sourceOtherAxis; // 0x1C
	public AxisRange sourceAxisRange; // 0x20
	public float axisDeadZone; // 0x24
	public bool invert; // 0x28
	public AxisCalibrationType axisCalibrationType; // 0x2C
	public float axisZero; // 0x30
	public float axisMin; // 0x34
	public float axisMax; // 0x38

	// Methods

	// RVA: 0x196AC40 Offset: 0x1969E40 VA: 0x18196AC40 Slot: 5
	public virtual object DeepClone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom.Element : IDeepCloneable // TypeDefIndex: 7466
{
	// Fields
	public int elementIdentifier; // 0x10
	public int sourceType; // 0x14
	public int sourceAxis; // 0x18
	public float axisDeadZone; // 0x1C
	public int sourceButton; // 0x20
	public CustomCalculation customCalculation; // 0x28
	public HardwareJoystickMap.Platform_Custom.CustomCalculationSourceData[] customCalculationSourceData; // 0x30

	// Methods

	// RVA: 0x196B220 Offset: 0x196A420 VA: 0x18196B220 Slot: 5
	internal virtual void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object DeepClone();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom.Button : HardwareJoystickMap.Platform_Custom.Element // TypeDefIndex: 7467
{
	// Fields
	public Pole sourceAxisPole; // 0x38
	public bool requireMultipleButtons; // 0x3C
	public int[] requiredButtons; // 0x40
	public bool ignoreIfButtonsActive; // 0x48
	public int[] ignoreIfButtonsActiveButtons; // 0x50
	public HardwareButtonInfo buttonInfo; // 0x58

	// Methods

	// RVA: 0x196A350 Offset: 0x1969550 VA: 0x18196A350 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom.Axis : HardwareJoystickMap.Platform_Custom.Element // TypeDefIndex: 7468
{
	// Fields
	public bool invert; // 0x38
	public AxisRange sourceAxisRange; // 0x3C
	public Pole buttonAxisContribution; // 0x40
	public bool calibrateAxis; // 0x44
	public float axisZero; // 0x48
	public float axisMin; // 0x4C
	public float axisMax; // 0x50
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
	public HardwareAxisInfo axisInfo; // 0x60

	// Methods

	// RVA: 0x1969A60 Offset: 0x1968C60 VA: 0x181969A60 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_Custom : HardwareJoystickMap.Platform // TypeDefIndex: 7469
{
	// Properties
	internal abstract HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal abstract HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract HardwareJoystickMap.Platform_Custom.Axis[] get_Axes();

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract HardwareJoystickMap.Platform_Custom.Button[] get_Buttons();

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XboxOne_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7470
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FBA0 Offset: 0x196EDA0 VA: 0x18196FBA0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196F8E0 Offset: 0x196EAE0 VA: 0x18196F8E0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E120 Offset: 0x196D320 VA: 0x18196E120 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DB50 Offset: 0x196CD50 VA: 0x18196DB50 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XboxOne_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7471
{
	// Fields
	public HardwareJoystickMap.Platform_XboxOne_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_XboxOne_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196BE80 Offset: 0x196B080 VA: 0x18196BE80 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196B8F0 Offset: 0x196AAF0 VA: 0x18196B8F0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B320 Offset: 0x196A520 VA: 0x18196B320 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XboxOne_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7472
{
	// Methods

	// RVA: 0x196A8A0 Offset: 0x1969AA0 VA: 0x18196A8A0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A690 Offset: 0x1969890 VA: 0x18196A690 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XboxOne_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7473
{
	// Methods

	// RVA: 0x1969E40 Offset: 0x1969040 VA: 0x181969E40 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x1969A10 Offset: 0x1968C10 VA: 0x181969A10 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_XboxOne_Base.TNCksJEKBJsBDtoVWSqrNVDqcfCF : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7474
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_XboxOne_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BBA0 Offset: 0x197ADA0 VA: 0x18197BBA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BAE0 Offset: 0x197ACE0 VA: 0x18197BAE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BAE0 Offset: 0x197ACE0 VA: 0x18197BAE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_XboxOne_Base.fjidPcBHpaeWezgpOAXASkBdnhm : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7475
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_XboxOne_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BEA0 Offset: 0x197B0A0 VA: 0x18197BEA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BDE0 Offset: 0x197AFE0 VA: 0x18197BDE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BDE0 Offset: 0x197AFE0 VA: 0x18197BDE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_XboxOne_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7476
{
	// Fields
	public HardwareJoystickMap.Platform_XboxOne_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_XboxOne_Base.Elements elements; // 0x20
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x28
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x30

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_XboxOne_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_XboxOne_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x197B8E0 Offset: 0x197AAE0 VA: 0x18197B8E0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x197B6C0 Offset: 0x197A8C0 VA: 0x18197B6C0 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x197B7D0 Offset: 0x197A9D0 VA: 0x18197B7D0 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_XboxOne_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_XboxOne_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x197B5C0 Offset: 0x197A7C0 VA: 0x18197B5C0 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x197B640 Offset: 0x197A840 VA: 0x18197B640 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x197B260 Offset: 0x197A460 VA: 0x18197B260 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x197AD50 Offset: 0x1979F50 VA: 0x18197AD50 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x197A620 Offset: 0x1979820 VA: 0x18197A620 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x197A910 Offset: 0x1979B10 VA: 0x18197A910 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x197ABF0 Offset: 0x1979DF0 VA: 0x18197ABF0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x197A5B0 Offset: 0x19797B0 VA: 0x18197A5B0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x197A4C0 Offset: 0x19796C0 VA: 0x18197A4C0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_XboxOne : HardwareJoystickMap.Platform_XboxOne_Base // TypeDefIndex: 7477
{
	// Fields
	public HardwareJoystickMap.Platform_XboxOne_Base[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1973410 Offset: 0x1972610 VA: 0x181973410 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x197BA70 Offset: 0x197AC70 VA: 0x18197BA70 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x197B8F0 Offset: 0x197AAF0 VA: 0x18197B8F0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS4_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7478
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FBA0 Offset: 0x196EDA0 VA: 0x18196FBA0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E700 Offset: 0x196D900 VA: 0x18196E700 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E430 Offset: 0x196D630 VA: 0x18196E430 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196D640 Offset: 0x196C840 VA: 0x18196D640 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS4_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7479
{
	// Fields
	public HardwareJoystickMap.Platform_PS4_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_PS4_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196BCE0 Offset: 0x196AEE0 VA: 0x18196BCE0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196B960 Offset: 0x196AB60 VA: 0x18196B960 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B5E0 Offset: 0x196A7E0 VA: 0x18196B5E0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS4_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7480
{
	// Methods

	// RVA: 0x196A830 Offset: 0x1969A30 VA: 0x18196A830 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A300 Offset: 0x1969500 VA: 0x18196A300 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS4_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7481
{
	// Methods

	// RVA: 0x1969FA0 Offset: 0x19691A0 VA: 0x181969FA0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x1969940 Offset: 0x1968B40 VA: 0x181969940 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_PS4_Base.HYpzEoJfBpAuDsBCXsCtZNOSmfNQ : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7482
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_PS4_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CE70 Offset: 0x196C070 VA: 0x18196CE70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CDB0 Offset: 0x196BFB0 VA: 0x18196CDB0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196CDB0 Offset: 0x196BFB0 VA: 0x18196CDB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_PS4_Base.gEfPDyidlgOljCKlnHkyfcpcLJgJA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7483
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_PS4_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BFA0 Offset: 0x197B1A0 VA: 0x18197BFA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BEE0 Offset: 0x197B0E0 VA: 0x18197BEE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BEE0 Offset: 0x197B0E0 VA: 0x18197BEE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_PS4_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7484
{
	// Fields
	public HardwareJoystickMap.Platform_PS4_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_PS4_Base.Elements elements; // 0x20
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x28
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x30

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_PS4_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_PS4_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1975F80 Offset: 0x1975180 VA: 0x181975F80 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1975D60 Offset: 0x1974F60 VA: 0x181975D60 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x1975E70 Offset: 0x1975070 VA: 0x181975E70 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_PS4_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_PS4_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1975C60 Offset: 0x1974E60 VA: 0x181975C60 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x1975CE0 Offset: 0x1974EE0 VA: 0x181975CE0 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x1975900 Offset: 0x1974B00 VA: 0x181975900 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x19753F0 Offset: 0x19745F0 VA: 0x1819753F0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1974CC0 Offset: 0x1973EC0 VA: 0x181974CC0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1974FB0 Offset: 0x19741B0 VA: 0x181974FB0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1975290 Offset: 0x1974490 VA: 0x181975290 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1974C50 Offset: 0x1973E50 VA: 0x181974C50 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1974B60 Offset: 0x1973D60 VA: 0x181974B60 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS4 : HardwareJoystickMap.Platform_PS4_Base // TypeDefIndex: 7485
{
	// Fields
	public HardwareJoystickMap.Platform_PS4_Base[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1973410 Offset: 0x1972610 VA: 0x181973410 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1976110 Offset: 0x1975310 VA: 0x181976110 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1975F90 Offset: 0x1975190 VA: 0x181975F90 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7486
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FBA0 Offset: 0x196EDA0 VA: 0x18196FBA0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196F010 Offset: 0x196E210 VA: 0x18196F010 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E200 Offset: 0x196D400 VA: 0x18196E200 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DEE0 Offset: 0x196D0E0 VA: 0x18196DEE0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7487
{
	// Fields
	public HardwareJoystickMap.Platform_NintendoSwitch_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_NintendoSwitch_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C910 Offset: 0x196BB10 VA: 0x18196C910 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196BB20 Offset: 0x196AD20 VA: 0x18196BB20 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B740 Offset: 0x196A940 VA: 0x18196B740 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7488
{
	// Methods

	// RVA: 0x196A6E0 Offset: 0x19698E0 VA: 0x18196A6E0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A1B0 Offset: 0x19693B0 VA: 0x18196A1B0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7489
{
	// Methods

	// RVA: 0x1969DD0 Offset: 0x1968FD0 VA: 0x181969DD0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x1969C30 Offset: 0x1968E30 VA: 0x181969C30 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.DCMloaOQyQUuuXMPGAwzvGXXokxR : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7490
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_NintendoSwitch_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196ADA0 Offset: 0x1969FA0 VA: 0x18196ADA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196ACE0 Offset: 0x1969EE0 VA: 0x18196ACE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196ACE0 Offset: 0x1969EE0 VA: 0x18196ACE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_NintendoSwitch_Base.MkUSqZsVtgtYNGuFbdWwXFgZuxrV : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7491
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_NintendoSwitch_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196FE70 Offset: 0x196F070 VA: 0x18196FE70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196FDB0 Offset: 0x196EFB0 VA: 0x18196FDB0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196FDB0 Offset: 0x196EFB0 VA: 0x18196FDB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_NintendoSwitch_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7492
{
	// Fields
	public HardwareJoystickMap.Platform_NintendoSwitch_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_NintendoSwitch_Base.Elements elements; // 0x20
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x28
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x30

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_NintendoSwitch_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_NintendoSwitch_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1974960 Offset: 0x1973B60 VA: 0x181974960 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1974740 Offset: 0x1973940 VA: 0x181974740 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x1974850 Offset: 0x1973A50 VA: 0x181974850 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_NintendoSwitch_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_NintendoSwitch_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1974640 Offset: 0x1973840 VA: 0x181974640 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x19746C0 Offset: 0x19738C0 VA: 0x1819746C0 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x19742E0 Offset: 0x19734E0 VA: 0x1819742E0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1973DD0 Offset: 0x1972FD0 VA: 0x181973DD0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x19736A0 Offset: 0x19728A0 VA: 0x1819736A0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1973990 Offset: 0x1972B90 VA: 0x181973990 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1973C70 Offset: 0x1972E70 VA: 0x181973C70 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1973630 Offset: 0x1972830 VA: 0x181973630 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1973540 Offset: 0x1972740 VA: 0x181973540 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_NintendoSwitch : HardwareJoystickMap.Platform_NintendoSwitch_Base // TypeDefIndex: 7493
{
	// Fields
	public HardwareJoystickMap.Platform_NintendoSwitch_Base[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1973410 Offset: 0x1972610 VA: 0x181973410 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1974AF0 Offset: 0x1973CF0 VA: 0x181974AF0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1974970 Offset: 0x1973B70 VA: 0x181974970 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_GameCore_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7494
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38
	public HardwareJoystickMap.VidPid[] vidPid; // 0x40
	public HardwareJoystickMap.Platform_GameCore_Base.DeviceType deviceType; // 0x48
	public HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType gamepadSubType; // 0x4C
	public int hatCount; // 0x50

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FC40 Offset: 0x196EE40 VA: 0x18196FC40 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E590 Offset: 0x196D790 VA: 0x18196E590 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196F1A0 Offset: 0x196E3A0 VA: 0x18196F1A0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E190 Offset: 0x196D390 VA: 0x18196E190 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DA20 Offset: 0x196CC20 VA: 0x18196DA20 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x196E5F0 Offset: 0x196D7F0 VA: 0x18196E5F0
	private bool HasProductName() { }

	// RVA: 0x196FA70 Offset: 0x196EC70 VA: 0x18196FA70
	private bool ProductNameMatches(string name) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_GameCore_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7495
{
	// Fields
	public HardwareJoystickMap.Platform_GameCore_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_GameCore_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C1D0 Offset: 0x196B3D0 VA: 0x18196C1D0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196BB90 Offset: 0x196AD90 VA: 0x18196BB90 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B480 Offset: 0x196A680 VA: 0x18196B480 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_GameCore_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7496
{
	// Fields
	public int sourceHat; // 0x60
	public HatDirection sourceHatDirection; // 0x64
	public HatType sourceHatType; // 0x68

	// Methods

	// RVA: 0x196A990 Offset: 0x1969B90 VA: 0x18196A990 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A280 Offset: 0x1969480 VA: 0x18196A280 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_GameCore_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7497
{
	// Fields
	public int sourceHat; // 0x68
	public AxisDirection sourceHatDirection; // 0x6C
	public HatType sourceHatType; // 0x70
	public AxisRange sourceHatRange; // 0x74

	// Methods

	// RVA: 0x1969EB0 Offset: 0x19690B0 VA: 0x181969EB0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x1969990 Offset: 0x1968B90 VA: 0x181969990 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public enum HardwareJoystickMap.Platform_GameCore_Base.DeviceType // TypeDefIndex: 7498
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType None = 0;
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType Gamepad = 1;
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType ArcadeStick = 2;
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType FlightStick = 3;
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType RacingWheel = 4;
	public const HardwareJoystickMap.Platform_GameCore_Base.DeviceType Raw = 6;
}

// Namespace: 
public enum HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType // TypeDefIndex: 7499
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType None = 0;
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType Xbox360 = 1;
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType XboxOne = 2;
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType DualShock = 3;
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType NintendoProController = 4;
	public const HardwareJoystickMap.Platform_GameCore_Base.GamepadSubType Unknown = 1000;
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_GameCore_Base.paPyGpUgIPqFxXMGFZpLsentYzUf : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7500
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_GameCore_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C1A0 Offset: 0x197B3A0 VA: 0x18197C1A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C0E0 Offset: 0x197B2E0 VA: 0x18197C0E0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197C0E0 Offset: 0x197B2E0 VA: 0x18197C0E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_GameCore_Base.GgpycckjMrBHjULDAXVMTJQDDwEf : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7501
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_GameCore_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CC70 Offset: 0x196BE70 VA: 0x18196CC70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CBB0 Offset: 0x196BDB0 VA: 0x18196CBB0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196CBB0 Offset: 0x196BDB0 VA: 0x18196CBB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_GameCore_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7502
{
	// Fields
	public HardwareJoystickMap.Platform_GameCore_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_GameCore_Base.Elements elements; // 0x20
	public string controllerName; // 0x28
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x30
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x38

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	public override string controllerNameOverride { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_GameCore_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_GameCore_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public override string get_controllerNameOverride() { }

	// RVA: 0x1971670 Offset: 0x1970870 VA: 0x181971670 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1971410 Offset: 0x1970610 VA: 0x181971410 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x1971520 Offset: 0x1970720 VA: 0x181971520 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_GameCore_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_GameCore_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1971310 Offset: 0x1970510 VA: 0x181971310 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x1971390 Offset: 0x1970590 VA: 0x181971390 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x1970FB0 Offset: 0x19701B0 VA: 0x181970FB0 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1970AA0 Offset: 0x196FCA0 VA: 0x181970AA0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1970360 Offset: 0x196F560 VA: 0x181970360 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1970650 Offset: 0x196F850 VA: 0x181970650 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1970940 Offset: 0x196FB40 VA: 0x181970940 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x19702F0 Offset: 0x196F4F0 VA: 0x1819702F0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19701F0 Offset: 0x196F3F0 VA: 0x1819701F0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_GameCore : HardwareJoystickMap.Platform_GameCore_Base // TypeDefIndex: 7503
{
	// Fields
	public HardwareJoystickMap.Platform_GameCore_Base[] variants; // 0x40

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1971CB0 Offset: 0x1970EB0 VA: 0x181971CB0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1971C40 Offset: 0x1970E40 VA: 0x181971C40 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1971680 Offset: 0x1970880 VA: 0x181971680 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x1971800 Offset: 0x1970A00 VA: 0x181971800
	internal static HardwareJoystickMap.Platform_GameCore CreateDefaultMap(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS5_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7504
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FBA0 Offset: 0x196EDA0 VA: 0x18196FBA0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196F4C0 Offset: 0x196E6C0 VA: 0x18196F4C0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E0B0 Offset: 0x196D2B0 VA: 0x18196E0B0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DD40 Offset: 0x196CF40 VA: 0x18196DD40 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS5_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7505
{
	// Fields
	public HardwareJoystickMap.Platform_PS5_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_PS5_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C020 Offset: 0x196B220 VA: 0x18196C020 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196BC70 Offset: 0x196AE70 VA: 0x18196BC70 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B530 Offset: 0x196A730 VA: 0x18196B530 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS5_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7506
{
	// Methods

	// RVA: 0x196AA00 Offset: 0x1969C00 VA: 0x18196AA00 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A160 Offset: 0x1969360 VA: 0x18196A160 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS5_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7507
{
	// Methods

	// RVA: 0x1969CF0 Offset: 0x1968EF0 VA: 0x181969CF0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x1969BE0 Offset: 0x1968DE0 VA: 0x181969BE0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_PS5_Base.kEksTOLLsVmfrxAwMCgJIymdkrxp : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7508
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_PS5_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C0A0 Offset: 0x197B2A0 VA: 0x18197C0A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BFE0 Offset: 0x197B1E0 VA: 0x18197BFE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BFE0 Offset: 0x197B1E0 VA: 0x18197BFE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_PS5_Base.ViBYfcRmvLbGWNFngjFubCnQmVwVA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7509
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_PS5_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BDA0 Offset: 0x197AFA0 VA: 0x18197BDA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BCE0 Offset: 0x197AEE0 VA: 0x18197BCE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BCE0 Offset: 0x197AEE0 VA: 0x18197BCE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_PS5_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7510
{
	// Fields
	public HardwareJoystickMap.Platform_PS5_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_PS5_Base.Elements elements; // 0x20
	public string controllerName; // 0x28
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x30
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x38

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	public override string controllerNameOverride { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_PS5_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_PS5_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public override string get_controllerNameOverride() { }

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1977390 Offset: 0x1976590 VA: 0x181977390 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x19774A0 Offset: 0x19766A0 VA: 0x1819774A0 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_PS5_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_PS5_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1977290 Offset: 0x1976490 VA: 0x181977290 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x1977310 Offset: 0x1976510 VA: 0x181977310 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x1976F30 Offset: 0x1976130 VA: 0x181976F30 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1976A20 Offset: 0x1975C20 VA: 0x181976A20 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x19762F0 Offset: 0x19754F0 VA: 0x1819762F0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x19765E0 Offset: 0x19757E0 VA: 0x1819765E0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x19768C0 Offset: 0x1975AC0 VA: 0x1819768C0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1976280 Offset: 0x1975480 VA: 0x181976280 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1976180 Offset: 0x1975380 VA: 0x181976180 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_PS5 : HardwareJoystickMap.Platform_PS5_Base // TypeDefIndex: 7511
{
	// Fields
	public HardwareJoystickMap.Platform_PS5_Base[] variants; // 0x40

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1971CB0 Offset: 0x1970EB0 VA: 0x181971CB0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1977730 Offset: 0x1976930 VA: 0x181977730 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19775B0 Offset: 0x19767B0 VA: 0x1819775B0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_InternalDriver_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7512
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38
	public HardwareJoystickMap.VidPid[] vidPid; // 0x40
	public int hatCount; // 0x48

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FB30 Offset: 0x196ED30 VA: 0x18196FB30 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196F650 Offset: 0x196E850 VA: 0x18196F650 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196E510 Offset: 0x196D710 VA: 0x18196E510 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196E350 Offset: 0x196D550 VA: 0x18196E350 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196D740 Offset: 0x196C940 VA: 0x18196D740 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x196FA70 Offset: 0x196EC70 VA: 0x18196FA70
	private bool ProductNameMatches(string name) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_InternalDriver_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7513
{
	// Fields
	public HardwareJoystickMap.Platform_InternalDriver_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_InternalDriver_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C3B0 Offset: 0x196B5B0 VA: 0x18196C3B0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196BA40 Offset: 0x196AC40 VA: 0x18196BA40 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B690 Offset: 0x196A890 VA: 0x18196B690 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_InternalDriver_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7514
{
	// Fields
	public int sourceHat; // 0x60
	public HatDirection sourceHatDirection; // 0x64
	public HatType sourceHatType; // 0x68

	// Methods

	// RVA: 0x196A7C0 Offset: 0x19699C0 VA: 0x18196A7C0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x196A200 Offset: 0x1969400 VA: 0x18196A200 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_InternalDriver_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7515
{
	// Fields
	public int sourceHat; // 0x68
	public AxisDirection sourceHatDirection; // 0x6C
	public HatType sourceHatType; // 0x70
	public AxisRange sourceHatRange; // 0x74

	// Methods

	// RVA: 0x1969D60 Offset: 0x1968F60 VA: 0x181969D60 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x19698C0 Offset: 0x1968AC0 VA: 0x1819698C0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_InternalDriver_Base.UiPRXbnQMvpRTuPHvHeEEocTOucJA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7516
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_InternalDriver_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BCA0 Offset: 0x197AEA0 VA: 0x18197BCA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197BBE0 Offset: 0x197ADE0 VA: 0x18197BBE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197BBE0 Offset: 0x197ADE0 VA: 0x18197BBE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_InternalDriver_Base.OwejUjFpEfaWxjXwZZcZDUWnidKU : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7517
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_InternalDriver_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196FF70 Offset: 0x196F170 VA: 0x18196FF70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196FEB0 Offset: 0x196F0B0 VA: 0x18196FEB0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196FEB0 Offset: 0x196F0B0 VA: 0x18196FEB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_InternalDriver_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7518
{
	// Fields
	public HardwareJoystickMap.Platform_InternalDriver_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_InternalDriver_Base.Elements elements; // 0x20
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x28
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x30

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_InternalDriver_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_InternalDriver_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1973210 Offset: 0x1972410 VA: 0x181973210 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1972FF0 Offset: 0x19721F0 VA: 0x181972FF0 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x1973100 Offset: 0x1972300 VA: 0x181973100 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_InternalDriver_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_InternalDriver_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1972EF0 Offset: 0x19720F0 VA: 0x181972EF0 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x1972F70 Offset: 0x1972170 VA: 0x181972F70 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x1972B90 Offset: 0x1971D90 VA: 0x181972B90 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1972680 Offset: 0x1971880 VA: 0x181972680 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1971F40 Offset: 0x1971140 VA: 0x181971F40 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1972230 Offset: 0x1971430 VA: 0x181972230 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1972520 Offset: 0x1971720 VA: 0x181972520 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1971ED0 Offset: 0x19710D0 VA: 0x181971ED0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1971DE0 Offset: 0x1970FE0 VA: 0x181971DE0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_InternalDriver : HardwareJoystickMap.Platform_InternalDriver_Base // TypeDefIndex: 7519
{
	// Fields
	public HardwareJoystickMap.Platform_InternalDriver_Base[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1973410 Offset: 0x1972610 VA: 0x181973410 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x19733A0 Offset: 0x19725A0 VA: 0x1819733A0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1973220 Offset: 0x1972420 VA: 0x181973220 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_SDL2_Base.MatchingCriteria.ElementCount : HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 7520
{
	// Fields
	public int hatCount; // 0x18

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x196B140 Offset: 0x196A340 VA: 0x18196B140 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x196B1B0 Offset: 0x196A3B0 VA: 0x18196B1B0 Slot: 6
	internal override void yuxuEJbIVLWtkwthHqGVzOMVetZcA(HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base ) { }

	// RVA: 0x196B0E0 Offset: 0x196A2E0 VA: 0x18196B0E0 Slot: 7
	internal override bool BxThmMJFHsklBXkYNDKZEyouGtEiA(BridgedControllerHWInfo ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_SDL2_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7521
{
	// Fields
	public int hatCount; // 0x28
	public bool manufacturer_useRegex; // 0x2C
	public bool productName_useRegex; // 0x2D
	public bool systemName_useRegex; // 0x2E
	public string[] manufacturer; // 0x30
	public string[] productName; // 0x38
	public string[] systemName; // 0x40
	public string[] productGUID; // 0x48

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x196FB70 Offset: 0x196ED70 VA: 0x18196FB70 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCB0 Offset: 0x196EEB0 VA: 0x18196FCB0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E890 Offset: 0x196DA90 VA: 0x18196E890 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C7F0 Offset: 0x195B9F0 VA: 0x18195C7F0 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196CEB0 Offset: 0x196C0B0 VA: 0x18196CEB0
	private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) { }

	// RVA: 0x195D140 Offset: 0x195C340 VA: 0x18195D140
	private bool NameMatches(string name, string[] names, bool useRegex) { }

	// RVA: 0x196E3C0 Offset: 0x196D5C0 VA: 0x18196E3C0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196DC50 Offset: 0x196CE50 VA: 0x18196DC50 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_SDL2_Base.Elements.DdEjTzxRbadyVaUbEryQBBliOlfZb : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Axis> // TypeDefIndex: 7522
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_SDL2_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_SDL2_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_SDL2_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x195B710 Offset: 0x195A910 VA: 0x18195B710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_SDL2_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196AFA0 Offset: 0x196A1A0 VA: 0x18196AFA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196AEE0 Offset: 0x196A0E0 VA: 0x18196AEE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196AEE0 Offset: 0x196A0E0 VA: 0x18196AEE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_SDL2_Base.Elements.DOMjJVOkeJqkZpeggESqfSjLJWmfA : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Button> // TypeDefIndex: 7523
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_SDL2_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_SDL2_Base.Elements nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_SDL2_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968D50 Offset: 0x1967F50 VA: 0x181968D50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_SDL2_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196AEA0 Offset: 0x196A0A0 VA: 0x18196AEA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196ADE0 Offset: 0x1969FE0 VA: 0x18196ADE0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196ADE0 Offset: 0x1969FE0 VA: 0x18196ADE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_SDL2_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7524
{
	// Fields
	public HardwareJoystickMap.Platform_SDL2_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_SDL2_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Axis> Axes { get; }
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Button> Buttons { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x195A5B0 Offset: 0x19597B0 VA: 0x18195A5B0
	internal HardwareJoystickMap.Platform_SDL2_Base.Axis GetAxis(int axisIndex) { }

	// RVA: 0x196CAB0 Offset: 0x196BCB0 VA: 0x18196CAB0
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Axis> get_Axes() { }

	// RVA: 0x196CB30 Offset: 0x196BD30 VA: 0x18196CB30
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Button> get_Buttons() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C590 Offset: 0x196B790 VA: 0x18196C590 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x196B9D0 Offset: 0x196ABD0 VA: 0x18196B9D0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B840 Offset: 0x196AA40 VA: 0x18196B840 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public abstract class HardwareJoystickMap.Platform_SDL2_Base.Element : IDeepCloneable // TypeDefIndex: 7525
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object DeepClone();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void ImportVars(HardwareJoystickMap.Platform_SDL2_Base.Element source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_SDL2_Base.Button : HardwareJoystickMap.Platform_SDL2_Base.Element // TypeDefIndex: 7526
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceButton; // 0x18
	public int sourceAxis; // 0x1C
	public Pole sourceAxisPole; // 0x20
	public float axisDeadZone; // 0x24
	public int sourceHat; // 0x28
	public HatType sourceHatType; // 0x2C
	public HatDirection sourceHatDirection; // 0x30
	public bool requireMultipleButtons; // 0x34
	public int[] requiredButtons; // 0x38
	public bool ignoreIfButtonsActive; // 0x40
	public int[] ignoreIfButtonsActiveButtons; // 0x48
	public HardwareButtonInfo buttonInfo; // 0x50

	// Methods

	// RVA: 0x1958FF0 Offset: 0x19581F0 VA: 0x181958FF0
	public void .ctor() { }

	// RVA: 0x196A910 Offset: 0x1969B10 VA: 0x18196A910 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x196AA70 Offset: 0x1969C70 VA: 0x18196AA70 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_SDL2_Base.Element source) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_SDL2_Base.Axis : HardwareJoystickMap.Platform_SDL2_Base.Element // TypeDefIndex: 7527
{
	// Fields
	public int elementIdentifier; // 0x10
	public HardwareElementSourceTypeWithHat sourceType; // 0x14
	public int sourceAxis; // 0x18
	public AxisRange sourceAxisRange; // 0x1C
	public bool invert; // 0x20
	public float axisDeadZone; // 0x24
	public bool calibrateAxis; // 0x28
	public float axisZero; // 0x2C
	public float axisMin; // 0x30
	public float axisMax; // 0x34
	public HardwareJoystickMap.AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
	public HardwareAxisInfo axisInfo; // 0x40
	public int sourceButton; // 0x48
	public Pole buttonAxisContribution; // 0x4C
	public int sourceHat; // 0x50
	public AxisDirection sourceHatDirection; // 0x54
	public AxisRange sourceHatRange; // 0x58

	// Methods

	// RVA: 0x19586F0 Offset: 0x19578F0 VA: 0x1819586F0
	public void .ctor() { }

	// RVA: 0x1969F20 Offset: 0x1969120 VA: 0x181969F20 Slot: 5
	public override object DeepClone() { }

	// RVA: 0x196A010 Offset: 0x1969210 VA: 0x18196A010 Slot: 6
	protected override void ImportVars(HardwareJoystickMap.Platform_SDL2_Base.Element source) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_SDL2_Base.HPIMtyCGIftfxmhpYrKbLeiLUTKc : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Axis>, IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Axis> // TypeDefIndex: 7528
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_SDL2_Base.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_SDL2_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CtZZtGqgZOqtPpZDjusuDmHoiIUR; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_SDL2_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959010 Offset: 0x1958210 VA: 0x181959010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_SDL2_Base.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CD70 Offset: 0x196BF70 VA: 0x18196CD70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x196CCB0 Offset: 0x196BEB0 VA: 0x18196CCB0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x196CCB0 Offset: 0x196BEB0 VA: 0x18196CCB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_SDL2_Base.uVwexoiRNJlWFjEmkajUPNZSKTCZ : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Button>, IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Button> // TypeDefIndex: 7529
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_SDL2_Base.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_SDL2_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RbmHGTJWxUYimQVDPCdnGrxmMtRfb; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34

	// Properties
	private HardwareJoystickMap.Platform_SDL2_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1959670 Offset: 0x1958870 VA: 0x181959670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_SDL2_Base.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C2A0 Offset: 0x197B4A0 VA: 0x18197C2A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C1E0 Offset: 0x197B3E0 VA: 0x18197C1E0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_SDL2_Base.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_SDL2_Base.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x197C1E0 Offset: 0x197B3E0 VA: 0x18197C1E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_SDL2_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7530
{
	// Fields
	public HardwareJoystickMap.Platform_SDL2_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_SDL2_Base.Elements elements; // 0x20

	// Properties
	internal override InputPlatform platform { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal HardwareJoystickMap.Platform_SDL2_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_SDL2_Base.Button[] Buttons_orig { get; }
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x19788F0 Offset: 0x1977AF0 VA: 0x1819788F0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_SDL2_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_SDL2_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1978540 Offset: 0x1977740 VA: 0x181978540 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1978020 Offset: 0x1977220 VA: 0x181978020 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x19778E0 Offset: 0x1976AE0 VA: 0x1819778E0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1977BD0 Offset: 0x1976DD0 VA: 0x181977BD0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1977EC0 Offset: 0x19770C0 VA: 0x181977EC0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x19787F0 Offset: 0x19779F0 VA: 0x1819787F0
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Axis> IterateAxes() { }

	// RVA: 0x1978870 Offset: 0x1977A70 VA: 0x181978870
	internal IEnumerable<HardwareJoystickMap.Platform_SDL2_Base.Button> IterateButtons() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x1977870 Offset: 0x1976A70 VA: 0x181977870 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19777A0 Offset: 0x19769A0 VA: 0x1819777A0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_SDL2 : HardwareJoystickMap.Platform_SDL2_Base // TypeDefIndex: 7531
{
	// Fields
	public HardwareJoystickMap.Platform_SDL2_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1978AD0 Offset: 0x1977CD0 VA: 0x181978AD0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1978A60 Offset: 0x1977C60 VA: 0x181978A60 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1978900 Offset: 0x1977B00 VA: 0x181978900 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Steam_Base.MatchingCriteria : HardwareJoystickMap.MatchingCriteria_Base // TypeDefIndex: 7532
{
	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }
	internal override int alternateElementCount { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCB0 Offset: 0x196EEB0 VA: 0x18196FCB0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196E680 Offset: 0x196D880 VA: 0x18196E680 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	internal override int get_alternateElementCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	internal override HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base GetAlternateElementCount(int index) { }

	// RVA: 0x195C870 Offset: 0x195BA70 VA: 0x18195C870 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x196E2E0 Offset: 0x196D4E0 VA: 0x18196E2E0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196D9D0 Offset: 0x196CBD0 VA: 0x18196D9D0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Steam_Base.Elements : HardwareJoystickMap.Elements_Base // TypeDefIndex: 7533
{
	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x196BAB0 Offset: 0x196ACB0 VA: 0x18196BAB0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x196B7F0 Offset: 0x196A9F0 VA: 0x18196B7F0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0x86C6A0 Offset: 0x86B8A0 VA: 0x18086C6A0 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x196C1C0 Offset: 0x196B3C0 VA: 0x18196C1C0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_Steam_Base : HardwareJoystickMap.Platform // TypeDefIndex: 7534
{
	// Fields
	public HardwareJoystickMap.Platform_Steam_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_Steam_Base.Elements elements; // 0x20

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x1978EB0 Offset: 0x19780B0 VA: 0x181978EB0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x1961490 Offset: 0x1960690 VA: 0x181961490 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1978E50 Offset: 0x1978050 VA: 0x181978E50 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1978D60 Offset: 0x1977F60 VA: 0x181978D60 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1978DA0 Offset: 0x1977FA0 VA: 0x181978DA0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x1978E10 Offset: 0x1978010 VA: 0x181978E10 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1978CF0 Offset: 0x1977EF0 VA: 0x181978CF0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1978C00 Offset: 0x1977E00 VA: 0x181978C00 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_Steam : HardwareJoystickMap.Platform_Steam_Base // TypeDefIndex: 7535
{
	// Fields
	public HardwareJoystickMap.Platform_Steam_Base[] variants; // 0x28

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1978AD0 Offset: 0x1977CD0 VA: 0x181978AD0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1979040 Offset: 0x1978240 VA: 0x181979040 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x1978EC0 Offset: 0x19780C0 VA: 0x181978EC0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL_Base.MatchingCriteria.ClientInfo : IDeepCloneable // TypeDefIndex: 7536
{
	// Fields
	public int browser; // 0x10
	public string browserVersionMin; // 0x18
	public string browserVersionMax; // 0x20
	public int os; // 0x28
	public string osVersionMin; // 0x30
	public string osVersionMax; // 0x38

	// Methods

	// RVA: 0x197CDD0 Offset: 0x197BFD0 VA: 0x18197CDD0 Slot: 4
	public object DeepClone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7537
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38
	public string[] productGUID; // 0x40
	public int[] mapping; // 0x48
	public HardwareJoystickMap.MatchingCriteria_Base.ElementCount_Base[] elementCount; // 0x50
	public HardwareJoystickMap.Platform_WebGL_Base.MatchingCriteria.ClientInfo[] clientInfo; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x196FBD0 Offset: 0x196EDD0 VA: 0x18196FBD0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x196FCD0 Offset: 0x196EED0 VA: 0x18196FCD0 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x196EB60 Offset: 0x196DD60 VA: 0x18196EB60 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x196D010 Offset: 0x196C210 VA: 0x18196D010
	private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, string[] currentVersion) { }

	// RVA: 0x196D330 Offset: 0x196C530 VA: 0x18196D330
	private static bool CheckOSVersion(string versionMin, string versionMax, string[] currentVersion) { }

	// RVA: 0x196E270 Offset: 0x196D470 VA: 0x18196E270 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x196D860 Offset: 0x196CA60 VA: 0x18196D860 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7538
{
	// Fields
	public HardwareJoystickMap.Platform_WebGL_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_WebGL_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x19880D0 Offset: 0x19872D0 VA: 0x1819880D0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1987CE0 Offset: 0x1986EE0 VA: 0x181987CE0 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x1987B50 Offset: 0x1986D50 VA: 0x181987B50 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7539
{
	// Methods

	// RVA: 0x197CD60 Offset: 0x197BF60 VA: 0x18197CD60 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197CC30 Offset: 0x197BE30 VA: 0x18197CC30 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7540
{
	// Methods

	// RVA: 0x197C9F0 Offset: 0x197BBF0 VA: 0x18197C9F0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197C8B0 Offset: 0x197BAB0 VA: 0x18197C8B0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WebGL_Base.UdwBUOEnzxCjMoUmFSROjZOedtBCb : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7541
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WebGL_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198FAC0 Offset: 0x198ECC0 VA: 0x18198FAC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198FA00 Offset: 0x198EC00 VA: 0x18198FA00 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198FA00 Offset: 0x198EC00 VA: 0x18198FA00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WebGL_Base.nYzPyYmLFDHcEgwGeQwhjHoTwNux : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7542
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WebGL_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990EB0 Offset: 0x19900B0 VA: 0x181990EB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990DF0 Offset: 0x198FFF0 VA: 0x181990DF0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1990DF0 Offset: 0x198FFF0 VA: 0x181990DF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_WebGL_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7543
{
	// Fields
	public HardwareJoystickMap.Platform_WebGL_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_WebGL_Base.Elements elements; // 0x20
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x28
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x30

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_WebGL_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_WebGL_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x197A4B0 Offset: 0x19796B0 VA: 0x18197A4B0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x197A290 Offset: 0x1979490 VA: 0x18197A290 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x197A3A0 Offset: 0x19795A0 VA: 0x18197A3A0 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_WebGL_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_WebGL_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x197A1B0 Offset: 0x19793B0 VA: 0x18197A1B0 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x197A220 Offset: 0x1979420 VA: 0x18197A220 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x1979E50 Offset: 0x1979050 VA: 0x181979E50 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x1979940 Offset: 0x1978B40 VA: 0x181979940 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x1979210 Offset: 0x1978410 VA: 0x181979210 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x1979500 Offset: 0x1978700 VA: 0x181979500 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x19797E0 Offset: 0x19789E0 VA: 0x1819797E0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x19791A0 Offset: 0x19783A0 VA: 0x1819791A0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x19790B0 Offset: 0x19782B0 VA: 0x1819790B0 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WebGL : HardwareJoystickMap.Platform_WebGL_Base // TypeDefIndex: 7544
{
	// Fields
	public HardwareJoystickMap.Platform_WebGL_Base[] variants; // 0x38

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x198DB20 Offset: 0x198CD20 VA: 0x18198DB20 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x198DAB0 Offset: 0x198CCB0 VA: 0x18198DAB0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x198DA00 Offset: 0x198CC00 VA: 0x18198DA00 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7545
{
	// Fields
	public bool productCategory_useRegex; // 0x30
	public string[] productCategory; // 0x38
	public bool productName_useRegex; // 0x40
	public string[] productName; // 0x48
	public HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags primaryProfileType; // 0x50
	public HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType[] profileSubTypes; // 0x58

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x198BC90 Offset: 0x198AE90 VA: 0x18198BC90 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x1919C10 Offset: 0x1918E10 VA: 0x181919C10 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x198B5A0 Offset: 0x198A7A0 VA: 0x18198B5A0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x198B4D0 Offset: 0x198A6D0 VA: 0x18198B4D0 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x198B380 Offset: 0x198A580 VA: 0x18198B380 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x196E5F0 Offset: 0x196D7F0 VA: 0x18196E5F0
	private bool HasProductCategory() { }

	// RVA: 0x196FA70 Offset: 0x196EC70 VA: 0x18196FA70
	private bool ProductCategoryMatches(string name) { }

	// RVA: 0x195C8C0 Offset: 0x195BAC0 VA: 0x18195C8C0
	private bool HasProductName() { }

	// RVA: 0x198BBF0 Offset: 0x198ADF0 VA: 0x18198BBF0
	private bool ProductNameMatches(string name) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7546
{
	// Fields
	public HardwareJoystickMap.Platform_AppleGCController_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_AppleGCController_Base.Button[] buttons; // 0x18
	public HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] compoundElements; // 0x20

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }
	public int compoundElementCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1988270 Offset: 0x1987470 VA: 0x181988270
	public int get_compoundElementCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x1987D50 Offset: 0x1986F50 VA: 0x181987D50 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1987C00 Offset: 0x1986E00 VA: 0x181987C00 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x1987A80 Offset: 0x1986C80 VA: 0x181987A80 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7547
{
	// Fields
	public HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier sourceElementId; // 0x60

	// Methods

	// RVA: 0x197CCF0 Offset: 0x197BEF0 VA: 0x18197CCF0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197CBC0 Offset: 0x197BDC0 VA: 0x18197CBC0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7548
{
	// Fields
	public HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier sourceElementId; // 0x68

	// Methods

	// RVA: 0x197CA60 Offset: 0x197BC60 VA: 0x18197CA60 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197C900 Offset: 0x197BB00 VA: 0x18197C900 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement : IDeepCloneable // TypeDefIndex: 7549
{
	// Fields
	public int elementIdentifier; // 0x10
	public int sourceElementIndex; // 0x14
	public HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements sourceElementId; // 0x18

	// Methods

	// RVA: 0x197CE60 Offset: 0x197C060 VA: 0x18197CE60
	internal void CopyVars(HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement destination) { }

	// RVA: 0x197CE90 Offset: 0x197C090 VA: 0x18197CE90 Slot: 4
	public object DeepClone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[EditorBrowsable(1)]
public enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags // TypeDefIndex: 7550
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags None = 0;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags Generic = 1;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags ExtendedGamepad = 2;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags MicroGamepad = 4;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileTypeFlags Unknown = -2147483648;
}

// Namespace: 
[EditorBrowsable(1)]
public enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType // TypeDefIndex: 7551
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType None = 0;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType Xbox = 1;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType DualShock = 2;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType DualSense = 3;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerProfileSubType Unknown = -1;
}

// Namespace: 
[EditorBrowsable(1)]
public enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier // TypeDefIndex: 7552
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier None = 0;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier A = 1;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier B = 2;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier X = 3;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Y = 4;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier LeftShoulder = 5;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier RightShoulder = 6;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Menu = 7;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Options = 8;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Home = 9;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier LeftStickButton = 10;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier RightStickButton = 11;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadUp = 12;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadRight = 13;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadDown = 14;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadLeft = 15;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier LeftStickX = 16;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier LeftStickY = 17;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier RightStickX = 18;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier RightStickY = 19;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier LeftTrigger = 20;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier RightTrigger = 21;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadVertical = 22;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier DPadHorizontal = 23;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier TouchpadButton = 24;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Paddle1 = 25;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Paddle2 = 26;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Paddle3 = 27;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier Paddle4 = 28;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier IndexedButton = 29;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifier IndexedAxis = 30;
}

// Namespace: 
[EditorBrowsable(1)]
public enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements // TypeDefIndex: 7553
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements None = 0;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements IndexedStick = 31;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements IndexedDPad = 32;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements LeftStick = 33;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements RightStick = 34;
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierCompoundElements DPad = 35;
}

// Namespace: 
[EditorBrowsable(1)]
[CustomObfuscation(rename = False)]
internal enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes // TypeDefIndex: 7554
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes None = 0;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes LeftStickX = 16;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes LeftStickY = 17;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes RightStickX = 18;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes RightStickY = 19;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes DPadVertical = 22;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes DPadHorizontal = 23;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierAxes IndexedAxis = 30;
}

// Namespace: 
[CustomObfuscation(rename = False)]
[EditorBrowsable(1)]
internal enum HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons // TypeDefIndex: 7555
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons None = 0;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons A = 1;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons B = 2;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons X = 3;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Y = 4;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons LeftShoulder = 5;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons RightShoulder = 6;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Menu = 7;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Options = 8;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Home = 9;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons LeftStickButton = 10;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons RightStickButton = 11;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons DPadUp = 12;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons DPadRight = 13;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons DPadDown = 14;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons DPadLeft = 15;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons LeftTrigger = 20;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons RightTrigger = 21;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons TouchpadButton = 24;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Paddle1 = 25;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Paddle2 = 26;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Paddle3 = 27;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons Paddle4 = 28;
	[CustomObfuscation(rename = False)]
	public const HardwareJoystickMap.Platform_AppleGCController_Base.AppleGCControllerElementIdentifierButtons IndexedButton = 29;
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_AppleGCController_Base.QPFSmZMrScqdfDAiPyoOrzxjcGyj : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7556
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_AppleGCController_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198F7D0 Offset: 0x198E9D0 VA: 0x18198F7D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198F710 Offset: 0x198E910 VA: 0x18198F710 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198F710 Offset: 0x198E910 VA: 0x18198F710 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_AppleGCController_Base.FlRUoIKxYdxTfHUvKjztiNRSmgQ : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7557
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_AppleGCController_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1988AD0 Offset: 0x1987CD0 VA: 0x181988AD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1988A10 Offset: 0x1987C10 VA: 0x181988A10 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1988A10 Offset: 0x1987C10 VA: 0x181988A10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_AppleGCController_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7558
{
	// Fields
	public HardwareJoystickMap.Platform_AppleGCController_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_AppleGCController_Base.Elements elements; // 0x20
	public string controllerName; // 0x28
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x30
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x38
	private HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] _compoundElementsOrigGame; // 0x40

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	public override string controllerNameOverride { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] CompoundElements { get; }
	internal HardwareJoystickMap.Platform_AppleGCController_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_AppleGCController_Base.Button[] Buttons_orig { get; }
	internal HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] CompoundElements_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public override string get_controllerNameOverride() { }

	// RVA: 0x198D360 Offset: 0x198C560 VA: 0x18198D360 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x198D060 Offset: 0x198C260 VA: 0x18198D060 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x198D170 Offset: 0x198C370 VA: 0x18198D170 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x198D280 Offset: 0x198C480 VA: 0x18198D280
	internal HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] get_CompoundElements() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_AppleGCController_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_AppleGCController_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x198D340 Offset: 0x198C540 VA: 0x18198D340
	internal HardwareJoystickMap.Platform_AppleGCController_Base.CompoundElement[] get_CompoundElements_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x198CF60 Offset: 0x198C160 VA: 0x18198CF60 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x198CFE0 Offset: 0x198C1E0 VA: 0x18198CFE0 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x198CC00 Offset: 0x198BE00 VA: 0x18198CC00 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x198C6F0 Offset: 0x198B8F0 VA: 0x18198C6F0 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x198BFC0 Offset: 0x198B1C0 VA: 0x18198BFC0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x198C2B0 Offset: 0x198B4B0 VA: 0x18198C2B0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x198C590 Offset: 0x198B790 VA: 0x18198C590 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x198BF50 Offset: 0x198B150 VA: 0x18198BF50 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x198BE40 Offset: 0x198B040 VA: 0x18198BE40 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_AppleGCController : HardwareJoystickMap.Platform_AppleGCController_Base // TypeDefIndex: 7559
{
	// Fields
	public HardwareJoystickMap.Platform_AppleGCController_Base[] variants; // 0x48

	// Methods

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x198D8D0 Offset: 0x198CAD0 VA: 0x18198D8D0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x198D860 Offset: 0x198CA60 VA: 0x18198D860 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x198D370 Offset: 0x198C570 VA: 0x18198D370 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x198D500 Offset: 0x198C700 VA: 0x18198D500
	internal static HardwareJoystickMap.Platform_AppleGCController CreateDefaultMap(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.MatchingCriteria : HardwareJoystickMap.Platform_Custom.MatchingCriteria // TypeDefIndex: 7560
{
	// Fields
	public bool productName_useRegex; // 0x30
	public string[] productName; // 0x38
	public HardwareJoystickMap.VidPid[] vidPid; // 0x40
	public HardwareJoystickMap.Platform_WindowsWGI_Base.DeviceType deviceType; // 0x48
	public int hatCount; // 0x4C

	// Properties
	internal override bool hasData { get; }
	internal override bool isAllowed { get; }

	// Methods

	// RVA: 0x198BCF0 Offset: 0x198AEF0 VA: 0x18198BCF0 Slot: 5
	internal override bool get_hasData() { }

	// RVA: 0x1919C10 Offset: 0x1918E10 VA: 0x181919C10 Slot: 6
	internal override bool get_isAllowed() { }

	// RVA: 0x198B540 Offset: 0x198A740 VA: 0x18198B540 Slot: 10
	internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) { }

	// RVA: 0x198B8E0 Offset: 0x198AAE0 VA: 0x18198B8E0 Slot: 7
	internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) { }

	// RVA: 0x198B460 Offset: 0x198A660 VA: 0x18198B460 Slot: 12
	public override object DeepClone() { }

	// RVA: 0x198B2C0 Offset: 0x198A4C0 VA: 0x18198B2C0 Slot: 11
	internal override void CopyVars(HardwareJoystickMap.MatchingCriteria_Base destination) { }

	// RVA: 0x196E5F0 Offset: 0x196D7F0 VA: 0x18196E5F0
	private bool HasProductName() { }

	// RVA: 0x196FA70 Offset: 0x196EC70 VA: 0x18196FA70
	private bool ProductNameMatches(string name) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.Elements : HardwareJoystickMap.Platform_Custom.Elements // TypeDefIndex: 7561
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsWGI_Base.Axis[] axes; // 0x10
	public HardwareJoystickMap.Platform_WindowsWGI_Base.Button[] buttons; // 0x18

	// Properties
	public override int buttonCount { get; }
	public override int axisCount { get; }

	// Methods

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450 Slot: 6
	public override int get_buttonCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230 Slot: 7
	public override int get_axisCount() { }

	// RVA: 0x1917380 Offset: 0x1916580 VA: 0x181917380 Slot: 8
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x1987EF0 Offset: 0x19870F0 VA: 0x181987EF0 Slot: 9
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x1987C70 Offset: 0x1986E70 VA: 0x181987C70 Slot: 10
	public override object DeepClone() { }

	// RVA: 0x19879D0 Offset: 0x1986BD0 VA: 0x1819879D0 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Elements_Base destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.Button : HardwareJoystickMap.Platform_Custom.Button // TypeDefIndex: 7562
{
	// Fields
	public int sourceHat; // 0x60
	public HatDirection sourceHatDirection; // 0x64
	public HatType sourceHatType; // 0x68

	// Methods

	// RVA: 0x197CC80 Offset: 0x197BE80 VA: 0x18197CC80 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197CB40 Offset: 0x197BD40 VA: 0x18197CB40 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.Axis : HardwareJoystickMap.Platform_Custom.Axis // TypeDefIndex: 7563
{
	// Fields
	public int sourceHat; // 0x68
	public AxisDirection sourceHatDirection; // 0x6C
	public HatType sourceHatType; // 0x70
	public AxisRange sourceHatRange; // 0x74

	// Methods

	// RVA: 0x197CAD0 Offset: 0x197BCD0 VA: 0x18197CAD0 Slot: 6
	public override object DeepClone() { }

	// RVA: 0x197C970 Offset: 0x197BB70 VA: 0x18197C970 Slot: 5
	internal override void CopyVars(HardwareJoystickMap.Platform_Custom.Element destination) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
public enum HardwareJoystickMap.Platform_WindowsWGI_Base.DeviceType // TypeDefIndex: 7564
{
	// Fields
	public int value__; // 0x0
	public const HardwareJoystickMap.Platform_WindowsWGI_Base.DeviceType None = 0;
	public const HardwareJoystickMap.Platform_WindowsWGI_Base.DeviceType Gamepad = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.KenbVpXmiYDQqJYRcYWErNEQDHoO : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Axis>, IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> // TypeDefIndex: 7565
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Axis lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsWGI_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1968BA0 Offset: 0x1967DA0 VA: 0x181968BA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Axis System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198B280 Offset: 0x198A480 VA: 0x18198B280 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198B1C0 Offset: 0x198A3C0 VA: 0x18198B1C0 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Axis> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Axis>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198B1C0 Offset: 0x198A3C0 VA: 0x18198B1C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.Platform_WindowsWGI_Base.OczNWeYcmupVuNUFdrfAownNrKdn : IDisposable, IEnumerable, IEnumerator, IEnumerable<HardwareJoystickMap.Platform_Custom.Button>, IEnumerator<HardwareJoystickMap.Platform_Custom.Button> // TypeDefIndex: 7566
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private HardwareJoystickMap.Platform_Custom.Button lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap.Platform_WindowsWGI_Base nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19688F0 Offset: 0x1967AF0 VA: 0x1819688F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private HardwareJoystickMap.Platform_Custom.Button System.Collections.Generic.IEnumerator<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198BE00 Offset: 0x198B000 VA: 0x18198BE00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198BD40 Offset: 0x198AF40 VA: 0x18198BD40 Slot: 9
	private IEnumerator<HardwareJoystickMap.Platform_Custom.Button> System.Collections.Generic.IEnumerable<Rewired.Data.Mapping.HardwareJoystickMap.Platform_Custom.Button>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198BD40 Offset: 0x198AF40 VA: 0x18198BD40 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public class HardwareJoystickMap.Platform_WindowsWGI_Base : HardwareJoystickMap.Platform_Custom // TypeDefIndex: 7567
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsWGI_Base.MatchingCriteria matchingCriteria; // 0x18
	public HardwareJoystickMap.Platform_WindowsWGI_Base.Elements elements; // 0x20
	public string controllerName; // 0x28
	private HardwareJoystickMap.Platform_Custom.Axis[] _axesOrigGame; // 0x30
	private HardwareJoystickMap.Platform_Custom.Button[] _buttonsOrigGame; // 0x38

	// Properties
	public override int assignedButtonCount { get; }
	public override int assignedAxisCount { get; }
	public override string controllerNameOverride { get; }
	internal override InputPlatform platform { get; }
	internal override HardwareJoystickMap.Platform_Custom.Axis[] Axes { get; }
	internal override HardwareJoystickMap.Platform_Custom.Button[] Buttons { get; }
	internal HardwareJoystickMap.Platform_WindowsWGI_Base.Axis[] Axes_orig { get; }
	internal HardwareJoystickMap.Platform_WindowsWGI_Base.Button[] Buttons_orig { get; }
	internal override bool hasData { get; }
	internal override bool disabled { get; }
	internal override bool isAllowed { get; }
	internal override HardwareJoystickMap.Elements_Base elements_base { get; }

	// Methods

	// RVA: 0x195EB00 Offset: 0x195DD00 VA: 0x18195EB00 Slot: 6
	public override int get_assignedButtonCount() { }

	// RVA: 0x195EAD0 Offset: 0x195DCD0 VA: 0x18195EAD0 Slot: 7
	public override int get_assignedAxisCount() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public override string get_controllerNameOverride() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 5
	internal override InputPlatform get_platform() { }

	// RVA: 0x198EE70 Offset: 0x198E070 VA: 0x18198EE70 Slot: 24
	internal override HardwareJoystickMap.Platform_Custom.Axis[] get_Axes() { }

	// RVA: 0x198EF80 Offset: 0x198E180 VA: 0x18198EF80 Slot: 25
	internal override HardwareJoystickMap.Platform_Custom.Button[] get_Buttons() { }

	// RVA: 0x195EA90 Offset: 0x195DC90 VA: 0x18195EA90
	internal HardwareJoystickMap.Platform_WindowsWGI_Base.Axis[] get_Axes_orig() { }

	// RVA: 0x195EAB0 Offset: 0x195DCB0 VA: 0x18195EAB0
	internal HardwareJoystickMap.Platform_WindowsWGI_Base.Button[] get_Buttons_orig() { }

	// RVA: 0x195FFE0 Offset: 0x195F1E0 VA: 0x18195FFE0 Slot: 14
	internal override bool get_hasData() { }

	// RVA: 0x195FFC0 Offset: 0x195F1C0 VA: 0x18195FFC0 Slot: 15
	internal override bool get_disabled() { }

	// RVA: 0x1971630 Offset: 0x1970830 VA: 0x181971630 Slot: 10
	internal override bool get_isAllowed() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	internal override HardwareJoystickMap.Elements_Base get_elements_base() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x195EA30 Offset: 0x195DC30 VA: 0x18195EA30 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x198ED70 Offset: 0x198DF70 VA: 0x18198ED70 Slot: 26
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Axis> IterateAxes() { }

	// RVA: 0x198EDF0 Offset: 0x198DFF0 VA: 0x18198EDF0 Slot: 27
	internal override IEnumerable<HardwareJoystickMap.Platform_Custom.Button> IterateButtons() { }

	// RVA: 0x198EA10 Offset: 0x198DC10 VA: 0x18198EA10 Slot: 13
	internal override bool IsElementIdentifierMapped(int elementIdentifierId) { }

	// RVA: 0x198E500 Offset: 0x198D700 VA: 0x18198E500 Slot: 12
	internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) { }

	// RVA: 0x198DDC0 Offset: 0x198CFC0 VA: 0x18198DDC0 Slot: 17
	internal override AxisCalibrationData[] GetAxisCalibrationData() { }

	// RVA: 0x198E0B0 Offset: 0x198D2B0 VA: 0x18198E0B0 Slot: 18
	internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) { }

	// RVA: 0x198E3A0 Offset: 0x198D5A0 VA: 0x18198E3A0 Slot: 19
	internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) { }

	// RVA: 0x195E090 Offset: 0x195D290 VA: 0x18195E090 Slot: 20
	internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) { }

	// RVA: 0x195E060 Offset: 0x195D260 VA: 0x18195E060 Slot: 21
	internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) { }

	// RVA: 0x198DD50 Offset: 0x198CF50 VA: 0x18198DD50 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x198DC40 Offset: 0x198CE40 VA: 0x18198DC40 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class HardwareJoystickMap.Platform_WindowsWGI : HardwareJoystickMap.Platform_WindowsWGI_Base // TypeDefIndex: 7568
{
	// Fields
	public HardwareJoystickMap.Platform_WindowsWGI_Base[] variants; // 0x40

	// Methods

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 16
	public override IList<HardwareJoystickMap.Platform> GetVariants() { }

	// RVA: 0x1971CB0 Offset: 0x1970EB0 VA: 0x181971CB0 Slot: 11
	internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x198F6A0 Offset: 0x198E8A0 VA: 0x18198F6A0 Slot: 22
	public override object DeepClone() { }

	// RVA: 0x198F090 Offset: 0x198E290 VA: 0x18198F090 Slot: 23
	internal override void CopyVars(HardwareJoystickMap.Platform destination) { }

	// RVA: 0x198F220 Offset: 0x198E420 VA: 0x18198F220
	internal static HardwareJoystickMap.Platform_WindowsWGI CreateDefaultMap(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.iVkgZVUKKoboWyYPKESlCYADsKnf : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 7569
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private IControllerElementIdentifierCommon_Internal lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1990A60 Offset: 0x198FC60 VA: 0x181990A60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990CB0 Offset: 0x198FEB0 VA: 0x181990CB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990BF0 Offset: 0x198FDF0 VA: 0x181990BF0 Slot: 9
	private IEnumerator<IControllerElementIdentifierCommon_Internal> System.Collections.Generic.IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1990BF0 Offset: 0x198FDF0 VA: 0x181990BF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.fbHLCWzMRCTpVMemEjJosXLmAhMaA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier> // TypeDefIndex: 7570
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerElementIdentifier lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1990A60 Offset: 0x198FC60 VA: 0x181990A60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerElementIdentifier>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990BB0 Offset: 0x198FDB0 VA: 0x181990BB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990AF0 Offset: 0x198FCF0 VA: 0x181990AF0 Slot: 9
	private IEnumerator<ControllerElementIdentifier> System.Collections.Generic.IEnumerable<Rewired.ControllerElementIdentifier>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1990AF0 Offset: 0x198FCF0 VA: 0x181990AF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.FQmouyxnfDqYceufpGPXUmWtnRuh : IDisposable, IEnumerable, IEnumerator, IEnumerable<JoystickType>, IEnumerator<JoystickType> // TypeDefIndex: 7571
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private JoystickType lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x18
	public HardwareJoystickMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x28

	// Properties
	private JoystickType System.Collections.Generic.IEnumerator<Rewired.JoystickType>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1950090 Offset: 0x194F290 VA: 0x181950090
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1988830 Offset: 0x1987A30 VA: 0x181988830 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	private JoystickType System.Collections.Generic.IEnumerator<Rewired.JoystickType>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1988980 Offset: 0x1987B80 VA: 0x181988980 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19889C0 Offset: 0x1987BC0 VA: 0x1819889C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19888C0 Offset: 0x1987AC0 VA: 0x1819888C0 Slot: 9
	private IEnumerator<JoystickType> System.Collections.Generic.IEnumerable<Rewired.JoystickType>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19888C0 Offset: 0x1987AC0 VA: 0x1819888C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickMap.ERKUlGpOnZBLeSTvVfSFhPpdFokfA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Guid>, IEnumerator<Guid> // TypeDefIndex: 7572
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private Guid lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x24
	public HardwareJoystickMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private Guid[] pSwkkWtrAIPCdtsUpTgkUSZaSQGF; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x38

	// Properties
	private Guid System.Collections.Generic.IEnumerator<System.Guid>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1987930 Offset: 0x1986B30 VA: 0x181987930
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1987600 Offset: 0x1986800 VA: 0x181987600 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x10EBEA0 Offset: 0x10EB0A0 VA: 0x1810EBEA0 Slot: 10
	private Guid System.Collections.Generic.IEnumerator<System.Guid>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19878A0 Offset: 0x1986AA0 VA: 0x1819878A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19878E0 Offset: 0x1986AE0 VA: 0x1819878E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19877E0 Offset: 0x19869E0 VA: 0x1819877E0 Slot: 9
	private IEnumerator<Guid> System.Collections.Generic.IEnumerable<System.Guid>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19877E0 Offset: 0x19869E0 VA: 0x1819877E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 7573
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerName; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string editorControllerName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string description; // 0x28
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string controllerGuid; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string controllerKey; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string[] templateGuids; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool hideInLists; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private JoystickType[] joystickTypes; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerElementIdentifier[] elementIdentifiers; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.CompoundElement[] compoundElements; // 0x60
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_DirectInput directInput; // 0x68
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_RawInput rawInput; // 0x70
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_XInput xInput; // 0x78
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_WindowsWGI windowsWGI; // 0x80
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_OSX osx; // 0x88
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_Linux linux; // 0x90
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_WindowsUWP windowsUWP; // 0x98
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Windows; // 0xA0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_WindowsUWP; // 0xA8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_OSX; // 0xB0
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_Fallback fallback_Linux; // 0xB8
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_Fallback fallback_Linux_PreConfigured; // 0xC0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Android; // 0xC8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_iOS; // 0xD0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_XBoxOne; // 0xD8
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_Fallback fallback_PS4; // 0xE0
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_PS5 ps5; // 0xE8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_PSM; // 0xF0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_PSVita; // 0xF8
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_Fallback fallback_AmazonFireTV; // 0x100
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_WebGL webGL; // 0x108
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_XboxOne xboxOne; // 0x110
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_GameCore gameCore; // 0x118
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_PS4 ps4; // 0x120
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_NintendoSwitch nintendoSwitch; // 0x128
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private HardwareJoystickMap.Platform_InternalDriver internalDriver; // 0x130
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_Linux; // 0x138
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_Windows; // 0x140
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_OSX; // 0x148
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_AppleGCController appleGCController; // 0x150
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int elementIdentifierIdCounter; // 0x158
	private Nullable<Guid> __runtimeControllerGuidCache; // 0x15C
	private Guid[] __runtimeTemplateGuidCache; // 0x170

	// Properties
	private Guid runtimeControllerGuid { get; }
	private Guid[] runtimeTemplateGuids { get; }
	public string ControllerName { get; }
	public string EditorControllerName { get; }
	public Guid Guid { get; }
	public string Key { get; }
	public IEnumerable<Guid> TemplateGuids { get; }
	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; }
	public int elementIdentifierCount { get; }
	public bool HideInLists { get; }
	internal IEnumerable<JoystickType> JoystickTypes { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeKey { get; }
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.controllerType { get; }
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers { get; }

	// Methods

	// RVA: 0x194ABA0 Offset: 0x1949DA0 VA: 0x18194ABA0
	private Guid get_runtimeControllerGuid() { }

	// RVA: 0x194ACA0 Offset: 0x1949EA0 VA: 0x18194ACA0
	private Guid[] get_runtimeTemplateGuids() { }

	// RVA: 0x194A260 Offset: 0x1949460 VA: 0x18194A260
	public void .ctor() { }

	// RVA: 0x1949780 Offset: 0x1948980 VA: 0x181949780
	public void .ctor(HardwareJoystickMap ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ControllerName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_EditorControllerName() { }

	// RVA: 0x194A8E0 Offset: 0x1949AE0 VA: 0x18194A8E0
	public Guid get_Guid() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Key() { }

	// RVA: 0x194AB10 Offset: 0x1949D10 VA: 0x18194AB10
	public IEnumerable<Guid> get_TemplateGuids() { }

	// RVA: 0x194A870 Offset: 0x1949A70 VA: 0x18194A870
	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x194AB80 Offset: 0x1949D80 VA: 0x18194AB80
	public int get_elementIdentifierCount() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_HideInLists() { }

	// RVA: 0x194AAA0 Offset: 0x1949CA0 VA: 0x18194AAA0
	internal IEnumerable<JoystickType> get_JoystickTypes() { }

	// RVA: 0x1949750 Offset: 0x1948950 VA: 0x181949750 Slot: 9
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeGuid() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 10
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeKey() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 11
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_controllerType() { }

	// RVA: 0x1948CF0 Offset: 0x1947EF0 VA: 0x181948CF0
	public int GetTemplateGuids(IList<Guid> results) { }

	// RVA: 0x1946D50 Offset: 0x1945F50 VA: 0x181946D50
	public bool ContainsTemplateGuid(Guid guid) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19482E0 Offset: 0x19474E0 VA: 0x1819482E0 Slot: 4
	public string[] GetElementIdentifierNames() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1947FB0 Offset: 0x19471B0 VA: 0x181947FB0 Slot: 5
	public int[] GetElementIdentifierIds() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19483C0 Offset: 0x19475C0 VA: 0x1819483C0
	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1947F70 Offset: 0x1947170 VA: 0x181947F70
	public ControllerElementIdentifier GetElementIdentifierAtIndex(int index) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1946CF0 Offset: 0x1945EF0 VA: 0x181946CF0 Slot: 6
	public bool ContainsElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1948090 Offset: 0x1947290 VA: 0x181948090
	public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19484E0 Offset: 0x19476E0 VA: 0x1819484E0 Slot: 7
	public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x1946C90 Offset: 0x1945E90 VA: 0x181946C90
	internal HardwareJoystickMap Clone() { }

	// RVA: 0x1949000 Offset: 0x1948200 VA: 0x181949000
	internal int IndexOfElementIdentifier(int id) { }

	// RVA: 0x1947ED0 Offset: 0x19470D0 VA: 0x181947ED0
	internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap) { }

	// RVA: 0x1947E20 Offset: 0x1947020 VA: 0x181947E20
	internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange) { }

	// RVA: 0x1948440 Offset: 0x1947640 VA: 0x181948440
	internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes) { }

	// RVA: 0x1949690 Offset: 0x1948890 VA: 0x181949690
	internal static bool Matches(HardwareJoystickMap.Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1949060 Offset: 0x1948260 VA: 0x181949060
	internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1947930 Offset: 0x1946B30 VA: 0x181947930
	internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal string[] GetTemplateGuidsOrig() { }

	// RVA: 0x19496E0 Offset: 0x19488E0 VA: 0x1819496E0 Slot: 12
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	// RVA: 0x19496D0 Offset: 0x19488D0 VA: 0x1819496D0 Slot: 13
	private IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	// RVA: 0x1947290 Offset: 0x1946490 VA: 0x181947290
	private HardwareJoystickMap.Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x1946F30 Offset: 0x1946130 VA: 0x181946F30
	private HardwareJoystickMap.Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x19477E0 Offset: 0x19469E0 VA: 0x1819477E0
	private HardwareJoystickMap.Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x19476B0 Offset: 0x19468B0 VA: 0x1819476B0
	private HardwareJoystickMap.Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: -1 Offset: -1
	private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AFFF0 Offset: 0x9AF1F0 VA: 0x1809AFFF0
	|-HardwareJoystickMap.TryGetFirstValidMap<object>
	*/

	// RVA: -1 Offset: -1
	private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AFDB0 Offset: 0x9AEFB0 VA: 0x1809AFDB0
	|-HardwareJoystickMap.TryGetFirstMatchingMap<object>
	*/

	// RVA: -1 Offset: -1
	private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AFB80 Offset: 0x9AED80 VA: 0x1809AFB80
	|-HardwareJoystickMap.GetUniversalDefaultMap<object>
	*/

	// RVA: -1 Offset: -1
	private T GetUniversalDefaultMapRoot<T>(Type type, out InputPlatform actualInputPlatform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9AF980 Offset: 0x9AEB80 VA: 0x1809AF980
	|-HardwareJoystickMap.GetUniversalDefaultMapRoot<object>
	*/

	// RVA: 0x1948740 Offset: 0x1947940 VA: 0x181948740
	private HardwareJoystickMap.Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier) { }

	// RVA: 0x1948790 Offset: 0x1947990 VA: 0x181948790
	private HardwareJoystickMap.Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform) { }

	// RVA: 0x858C00 Offset: 0x857E00 VA: 0x180858C00 Slot: 8
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_name() { }
}

// Namespace: 
internal struct HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb // TypeDefIndex: 7574
{
	// Fields
	public int EBgjkgizYfTJcBzacsoGIXfCWXFJA; // 0x0
	public int eSoTuxxcHvRbRqEOxWLeTHAOfCkM; // 0x4
	public int eeZxyLwnlqjdIzxGRAQfxHzzrvxC; // 0x8
	public bool qRawSSUvNDAVVtDwhuwmtUqJPsN; // 0xC
}

// Namespace: Rewired.Data.Mapping
public abstract class HardwareControllerTemplateMap : ScriptableObject // TypeDefIndex: 7575
{
	// Properties
	public abstract Guid Guid { get; }
	public abstract string Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_Guid();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Key();

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract ControllerTemplateElementIdentifier GetElementIdentifier(int id);

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ContainsElementIdentifier(int id);

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickTemplateMap.Entry // TypeDefIndex: 7576
{
	// Fields
	public int id; // 0x10
	public string name; // 0x18
	public string joystickGuid; // 0x20
	public string fileGuid; // 0x28
	public List<HardwareJoystickTemplateMap.ElementIdentifierMap> elementIdentifierMappings; // 0x30

	// Properties
	public Guid JoystickGuid { get; }

	// Methods

	[Preserve]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19885C0 Offset: 0x19877C0 VA: 0x1819885C0
	internal void .ctor(HardwareJoystickTemplateMap.Entry ) { }

	// RVA: 0x1988780 Offset: 0x1987980 VA: 0x181988780
	public Guid get_JoystickGuid() { }

	// RVA: 0x1988440 Offset: 0x1987640 VA: 0x181988440
	public int GetJoystickElementId(int templateElementId) { }

	// RVA: 0x1988500 Offset: 0x1987700 VA: 0x181988500
	public int GetTemplateElementId(int joystickElementId) { }

	// RVA: 0x1988290 Offset: 0x1987490 VA: 0x181988290
	public HardwareJoystickTemplateMap.ElementIdentifierMap GetElementIdentifierMap(int templateId) { }

	// RVA: 0x1988350 Offset: 0x1987550 VA: 0x181988350
	public void GetElementIdentifierMaps(int templateId, List<HardwareJoystickTemplateMap.ElementIdentifierMap> results) { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickTemplateMap.ElementIdentifierMap // TypeDefIndex: 7577
{
	// Fields
	public int templateId; // 0x10
	public int joystickId; // 0x14
	public int joystickId2; // 0x18
	public bool splitAxis; // 0x1C

	// Methods

	[Preserve]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1987980 Offset: 0x1986B80 VA: 0x181987980
	internal void .ctor(HardwareJoystickTemplateMap.ElementIdentifierMap ) { }
}

// Namespace: 
[Serializable]
public sealed class HardwareJoystickTemplateMap.SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 7578
{
	// Fields
	public int elementIdentifierId; // 0x10
	public string data; // 0x18

	// Methods

	[Preserve]
	// RVA: 0x198F9A0 Offset: 0x198EBA0 VA: 0x18198F9A0
	public void .ctor() { }

	// RVA: 0x198F9B0 Offset: 0x198EBB0 VA: 0x18198F9B0
	internal void .ctor(HardwareJoystickTemplateMap.SpecialElementEntry ) { }

	// RVA: -1 Offset: -1 Slot: 4
	private T Rewired.Data.Mapping.IControllerTemplateMapSpecialElement_Internal.GetMapping<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5510 Offset: 0xAD4710 VA: 0x180AD5510
	|-HardwareJoystickTemplateMap.SpecialElementEntry.Rewired.Data.Mapping.IControllerTemplateMapSpecialElement_Internal.GetMapping<object>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickTemplateMap.mKmTyUzcIUHEzPWvzhixqbJzpnJW : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal> // TypeDefIndex: 7579
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private IControllerElementIdentifierCommon_Internal lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickTemplateMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x198F810 Offset: 0x198EA10 VA: 0x18198F810 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private IControllerElementIdentifierCommon_Internal System.Collections.Generic.IEnumerator<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990DB0 Offset: 0x198FFB0 VA: 0x181990DB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1990CF0 Offset: 0x198FEF0 VA: 0x181990CF0 Slot: 9
	private IEnumerator<IControllerElementIdentifierCommon_Internal> System.Collections.Generic.IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1990CF0 Offset: 0x198FEF0 VA: 0x181990CF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HardwareJoystickTemplateMap.QaoBTWUnzfNupNNDeDNkmVROhNOm : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerTemplateElementIdentifier>, IEnumerator<ControllerTemplateElementIdentifier> // TypeDefIndex: 7580
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerTemplateElementIdentifier lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public HardwareJoystickTemplateMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

	// Properties
	private ControllerTemplateElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerTemplateElementIdentifier>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x198F810 Offset: 0x198EA10 VA: 0x18198F810 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerTemplateElementIdentifier System.Collections.Generic.IEnumerator<Rewired.ControllerTemplateElementIdentifier>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198F960 Offset: 0x198EB60 VA: 0x18198F960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198F8A0 Offset: 0x198EAA0 VA: 0x18198F8A0 Slot: 9
	private IEnumerator<ControllerTemplateElementIdentifier> System.Collections.Generic.IEnumerable<Rewired.ControllerTemplateElementIdentifier>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198F8A0 Offset: 0x198EAA0 VA: 0x18198F8A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data.Mapping
public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerTemplateMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap_Internal // TypeDefIndex: 7581
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string description; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string templateGuid; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string templateKey; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string className; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; // 0x40
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<HardwareJoystickTemplateMap.Entry> joysticks; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickTemplateMap.SpecialElementEntry[] specialElements; // 0x50
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int elementIdentifierIdCounter; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickIdCounter; // 0x5C
	private Func<Guid, HardwareJoystickTemplateMap.Entry> UnbCgDKGkKKmWZOFFENxjlcFhRFjA; // 0x60

	// Properties
	public override Guid Guid { get; }
	public override string Key { get; }
	public string ControllerName { get; }
	public string ClassName { get; }
	public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers { get; }
	public int elementIdentifierCount { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeKey { get; }
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.controllerType { get; }
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.name { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeKey { get; }
	private Func<Guid, HardwareJoystickTemplateMap.Entry> gusZfFQqtxCIfhZPNalLFWCDWkUEA { get; }

	// Methods

	// RVA: 0x198ADA0 Offset: 0x1989FA0 VA: 0x18198ADA0 Slot: 4
	public override Guid get_Guid() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 5
	public override string get_Key() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ControllerName() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_ClassName() { }

	// RVA: 0x198AD20 Offset: 0x1989F20 VA: 0x18198AD20
	public IEnumerable<ControllerTemplateElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x198A050 Offset: 0x1989250 VA: 0x18198A050
	public int get_elementIdentifierCount() { }

	// RVA: 0x1989F80 Offset: 0x1989180 VA: 0x181989F80 Slot: 13
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeGuid() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 14
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeKey() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 15
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_controllerType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19890E0 Offset: 0x19882E0 VA: 0x1819890E0 Slot: 6
	public override ControllerTemplateElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988E10 Offset: 0x1988010 VA: 0x181988E10
	public ControllerTemplateElementIdentifier GetElementIdentifierAtIndex(int index) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988DB0 Offset: 0x1987FB0 VA: 0x181988DB0 Slot: 7
	public override bool ContainsElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988F10 Offset: 0x1988110 VA: 0x181988F10 Slot: 8
	public string[] GetElementIdentifierNames() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988E50 Offset: 0x1988050 VA: 0x181988E50 Slot: 9
	public int[] GetElementIdentifierIds() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988FF0 Offset: 0x19881F0 VA: 0x181988FF0
	internal string[] GetElementIdentifierScriptingNames(bool useAlternate) { }

	// RVA: 0x19896B0 Offset: 0x19888B0 VA: 0x1819896B0 Slot: 11
	public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x1989940 Offset: 0x1988B40 VA: 0x181989940
	public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x19895C0 Offset: 0x19887C0 VA: 0x1819895C0
	public string[] GetJoystickNames() { }

	// RVA: 0x19894E0 Offset: 0x19886E0 VA: 0x1819894E0
	public int[] GetJoystickIds() { }

	// RVA: 0x1989260 Offset: 0x1988460 VA: 0x181989260
	public Guid GetJoystickGuid(int joystickId) { }

	// RVA: 0x19893B0 Offset: 0x19885B0 VA: 0x1819893B0
	public int GetJoystickId(Guid guid) { }

	// RVA: 0x1989150 Offset: 0x1988350 VA: 0x181989150
	public string GetJoystickFileGuidString(int joystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal HardwareJoystickTemplateMap.SpecialElementEntry[] GetSpecialElementsOrig() { }

	// RVA: 0x198A430 Offset: 0x1989630 VA: 0x18198A430
	internal bool beEAkfNYlVsplXtNWFQoMKwNrhWA(ControllerMap_Editor , HardwareJoystickMap , Guid , out string ) { }

	// RVA: 0x198AF10 Offset: 0x198A110 VA: 0x18198AF10
	internal WkgkbmGyRrghNJkGCDFpCiLnjOhK oyBmiBiLuGAJbHGBDglqltwcFLTO() { }

	// RVA: 0x198AE10 Offset: 0x198A010 VA: 0x18198AE10
	private HardwareJoystickTemplateMap.Entry nnnVPpmogfVByYORMDyiIOVkfttO(Guid ) { }

	// RVA: 0x1989F00 Offset: 0x1989100 VA: 0x181989F00 Slot: 16
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	// RVA: 0x17F3DA0 Offset: 0x17F2FA0 VA: 0x1817F3DA0 Slot: 17
	private IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 18
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_name() { }

	// RVA: 0x1989F80 Offset: 0x1989180 VA: 0x181989F80 Slot: 19
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeGuid() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 20
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeKey() { }

	// RVA: 0x198A050 Offset: 0x1989250 VA: 0x18198A050 Slot: 21
	private int Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount() { }

	// RVA: 0x198A0E0 Offset: 0x19892E0 VA: 0x18198A0E0 Slot: 22
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int index) { }

	// RVA: 0x17F3DA0 Offset: 0x17F2FA0 VA: 0x1817F3DA0 Slot: 23
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int elementIdentifierId) { }

	// RVA: 0x198A070 Offset: 0x1989270 VA: 0x18198A070 Slot: 24
	private IControllerTemplateMapSpecialElement_Internal Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int id) { }

	// RVA: 0x1989FB0 Offset: 0x19891B0 VA: 0x181989FB0 Slot: 25
	private jDCySwCSAVHKuUnPmaQCBczTSqylA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x198A000 Offset: 0x1989200 VA: 0x18198A000 Slot: 26
	private jDCySwCSAVHKuUnPmaQCBczTSqylA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x1988D30 Offset: 0x1987F30 VA: 0x181988D30
	private Func<Guid, HardwareJoystickTemplateMap.Entry> BiruseCeobVZwvRgIOVuwxafuTWC() { }

	// RVA: 0x198A110 Offset: 0x1989310 VA: 0x18198A110
	internal static jDCySwCSAVHKuUnPmaQCBczTSqylA YYrEYwumWyLUOhEAaxiDaqrqqplH(IHardwareControllerTemplateMap_Internal , Controller , int , Func<Guid, HardwareJoystickTemplateMap.Entry> ) { }

	// RVA: 0x1989BD0 Offset: 0x1988DD0 VA: 0x181989BD0
	internal static jDCySwCSAVHKuUnPmaQCBczTSqylA HUJeruqlfvryZQynqEUmpSLhEnli(IHardwareControllerTemplateMap_Internal , Controller , int , Func<Guid, HardwareJoystickTemplateMap.Entry> ) { }

	// RVA: 0x1989DD0 Offset: 0x1988FD0 VA: 0x181989DD0
	internal static ControllerTemplateElementIdentifier OqcOfAuflDhTtFjoqWhPCthjTrWsA(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x1989EA0 Offset: 0x19890A0 VA: 0x181989EA0
	internal static int QFHGkykuRAhPuEFQrQRyGCZhGtiWb(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x1989E40 Offset: 0x1989040 VA: 0x181989E40
	internal static bool PrbCShfjHYuBBYqAmiPUNMLzzJip(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x198A3E0 Offset: 0x19895E0 VA: 0x18198A3E0
	public void .ctor() { }

	// RVA: 0x858C00 Offset: 0x857E00 VA: 0x180858C00 Slot: 12
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_name() { }
}

// Namespace: 
private struct WkgkbmGyRrghNJkGCDFpCiLnjOhK.VFOGEPRaKtHAVlySOQtvsJgTyRVr : IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 7582
{
	// Fields
	private IControllerTemplateMapSpecialElement_Internal OXSeMYpfjwPTxItmKoSBErjZyall; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(IControllerTemplateMapSpecialElement_Internal ) { }

	// RVA: -1 Offset: -1 Slot: 4
	public T GetMapping<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5DD0 Offset: 0xAD4FD0 VA: 0x180AD5DD0
	|-WkgkbmGyRrghNJkGCDFpCiLnjOhK.VFOGEPRaKtHAVlySOQtvsJgTyRVr.GetMapping<object>
	*/
}

// Namespace: 
internal sealed class WkgkbmGyRrghNJkGCDFpCiLnjOhK : IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal // TypeDefIndex: 7583
{
	// Fields
	private HardwareJoystickTemplateMap TmTyoBDcgyUuqCgpeWVKenQuuiim; // 0x10
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x18
	private string jyykZTokxWYBtcNCEzymKazeItOc; // 0x20
	private string sKEfXRhGnVSsmWsCqaKxYnjRjSNb; // 0x28
	private readonly Guid qfQmfIuwLAMynnVkqTSIRYBazLmm; // 0x30
	private readonly List<HardwareJoystickTemplateMap.Entry> LpmxDlfvfpIhUgmLdpCPcCMASIzy; // 0x40
	private readonly ControllerTemplateElementIdentifier[] VNDhSzzEEIBiDbcaViAPECKmrcGP; // 0x48
	private readonly DeviceLocalizationInfo ebTMLxoLwWDnKILCIJrzNFzktllj; // 0x50
	private Func<Guid, HardwareJoystickTemplateMap.Entry> UnbCgDKGkKKmWZOFFENxjlcFhRFjA; // 0x58

	// Properties
	public string name { get; }
	public string gyPjSnhVGOvVSKKwArvfZCAtPtdj { get; }
	public string OBqnLJQoPJGIQnqhihiXTClNELYH { get; }
	public Guid wXqOHhZftWAnZcDnBiFrLlIbaIKLA { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.name { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeKey { get; }
	private Func<Guid, HardwareJoystickTemplateMap.Entry> gusZfFQqtxCIfhZPNalLFWCDWkUEA { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string TOvXPpwDhETSAbdtesCwcZxiHQRL() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string drsVLKNsGZvRlpOFRpNJQUExHJls() { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010
	public Guid EsIECCXHQxMdRYXegsgQVQqRGEWI() { }

	// RVA: 0x1990310 Offset: 0x198F510 VA: 0x181990310
	public void .ctor(HardwareJoystickTemplateMap , List<HardwareJoystickTemplateMap.Entry> , ControllerTemplateElementIdentifier[] ) { }

	// RVA: 0x19906D0 Offset: 0x198F8D0 VA: 0x1819906D0
	public ControllerTemplateElementIdentifier flWGZreMnLzBbLJajcmDfKVefOwSB(Guid , int ) { }

	// RVA: 0x198FD30 Offset: 0x198EF30 VA: 0x18198FD30
	public int GwTjvsHomtLqdqNsnDgfajGBCUJMA(Guid , int , List<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb> ) { }

	// RVA: 0x1990960 Offset: 0x198FB60 VA: 0x181990960
	private HardwareJoystickTemplateMap.Entry nnnVPpmogfVByYORMDyiIOVkfttO(Guid ) { }

	// RVA: 0x1990900 Offset: 0x198FB00 VA: 0x181990900
	private static ControllerTemplateElementIdentifier gpGQzYUbeWDElDbvrGqdhVXcdOsZA(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_name() { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010 Slot: 5
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeGuid() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeKey() { }

	// RVA: 0x19901D0 Offset: 0x198F3D0 VA: 0x1819901D0 Slot: 7
	private int Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount() { }

	// RVA: 0x19902E0 Offset: 0x198F4E0 VA: 0x1819902E0 Slot: 8
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int index) { }

	// RVA: 0x1990270 Offset: 0x198F470 VA: 0x181990270 Slot: 9
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int elementIdentifierId) { }

	// RVA: 0x19901F0 Offset: 0x198F3F0 VA: 0x1819901F0 Slot: 10
	private IControllerTemplateMapSpecialElement_Internal Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int id) { }

	// RVA: 0x1990130 Offset: 0x198F330 VA: 0x181990130 Slot: 11
	private jDCySwCSAVHKuUnPmaQCBczTSqylA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x1990180 Offset: 0x198F380 VA: 0x181990180 Slot: 12
	private jDCySwCSAVHKuUnPmaQCBczTSqylA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x198FCB0 Offset: 0x198EEB0 VA: 0x18198FCB0
	private Func<Guid, HardwareJoystickTemplateMap.Entry> BiruseCeobVZwvRgIOVuwxafuTWC() { }
}

// Namespace: Rewired.Data.Mapping
public enum HardwareElementSourceType // TypeDefIndex: 7584
{
	// Fields
	public int value__; // 0x0
	public const HardwareElementSourceType Button = 0;
	public const HardwareElementSourceType Axis = 1;
	public const HardwareElementSourceType Key = 3;
	public const HardwareElementSourceType Custom = 100;
}

// Namespace: Rewired.Data.Mapping
public enum HardwareElementSourceTypeWithHat // TypeDefIndex: 7585
{
	// Fields
	public int value__; // 0x0
	public const HardwareElementSourceTypeWithHat Button = 0;
	public const HardwareElementSourceTypeWithHat Axis = 1;
	public const HardwareElementSourceTypeWithHat Hat = 2;
	public const HardwareElementSourceTypeWithHat Key = 3;
	public const HardwareElementSourceTypeWithHat Custom = 100;
}

// Namespace: Rewired.Data.Mapping
public enum HatDirection // TypeDefIndex: 7586
{
	// Fields
	public int value__; // 0x0
	public const HatDirection Up = 0;
	public const HatDirection Right = 1;
	public const HatDirection Down = 2;
	public const HatDirection Left = 3;
	public const HatDirection UpRight = 4;
	public const HatDirection DownRight = 5;
	public const HatDirection DownLeft = 6;
	public const HatDirection UpLeft = 7;
}

// Namespace: Rewired.Data.Mapping
public enum HatType // TypeDefIndex: 7587
{
	// Fields
	public int value__; // 0x0
	public const HatType FourWay = 0;
	public const HatType EightWay = 1;
}

// Namespace: Rewired.Data.Mapping
public enum AxisDirection // TypeDefIndex: 7588
{
	// Fields
	public int value__; // 0x0
	public const AxisDirection Vertical = 0;
	public const AxisDirection Horizontal = 1;
}

// Namespace: Rewired.Data.Mapping
public enum HardwareAxisType // TypeDefIndex: 7589
{
	// Fields
	public int value__; // 0x0
	public const HardwareAxisType Axis = 0;
	public const HardwareAxisType Axis2D = 1;
}

// Namespace: Rewired.Data.Mapping
public enum AxisCalibrationType // TypeDefIndex: 7590
{
	// Fields
	public int value__; // 0x0
	public const AxisCalibrationType Default = 0;
	public const AxisCalibrationType Uncalibrated = 1;
	public const AxisCalibrationType Custom = 2;
}

// Namespace: Rewired.Data.Mapping
public enum SpecialAxisType // TypeDefIndex: 7591
{
	// Fields
	public int value__; // 0x0
	public const SpecialAxisType None = 0;
	public const SpecialAxisType Throttle = 1;
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
internal enum AlternateAxisCalibrationType // TypeDefIndex: 7592
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const AlternateAxisCalibrationType Default = 0;
	[CustomObfuscation(rename = False)]
	public const AlternateAxisCalibrationType ThrottleZeroCenter = 1;
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class HardwareAxisInfo : IDeepCloneable // TypeDefIndex: 7593
{
	// Fields
	[SerializeField]
	internal AxisCoordinateMode _dataFormat; // 0x10
	[SerializeField]
	internal bool _excludeFromPolling; // 0x14
	[SerializeField]
	internal SpecialAxisType _specialAxisType; // 0x18
	[SerializeField]
	internal float _pollingDeadZone; // 0x1C

	// Properties
	public AxisCoordinateMode dataFormat { get; }
	public bool excludeFromPolling { get; }
	public SpecialAxisType specialAxisType { get; }
	public float pollingDeadZone { get; }
	[CustomObfuscation(rename = False)]
	internal static HardwareAxisInfo Default { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AxisCoordinateMode get_dataFormat() { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_excludeFromPolling() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public SpecialAxisType get_specialAxisType() { }

	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_pollingDeadZone() { }

	// RVA: 0x1988BB0 Offset: 0x1987DB0 VA: 0x181988BB0
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1988BE0 Offset: 0x1987DE0 VA: 0x181988BE0
	internal void .ctor(AxisCoordinateMode , bool , float , SpecialAxisType ) { }

	// RVA: 0x1988C40 Offset: 0x1987E40 VA: 0x181988C40
	internal static HardwareAxisInfo get_Default() { }

	// RVA: 0x1988B10 Offset: 0x1987D10 VA: 0x181988B10 Slot: 4
	public object DeepClone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class HardwareButtonInfo : IDeepCloneable // TypeDefIndex: 7594
{
	// Fields
	[SerializeField]
	internal bool _excludeFromPolling; // 0x10
	[SerializeField]
	internal bool _isPressureSensitive; // 0x11

	// Properties
	public bool excludeFromPolling { get; }
	public bool isPressureSensitive { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_excludeFromPolling() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_isPressureSensitive() { }

	// RVA: 0x1988D10 Offset: 0x1987F10 VA: 0x181988D10
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x8035A0 Offset: 0x8027A0 VA: 0x1808035A0
	internal void .ctor(bool , bool ) { }

	// RVA: 0x1988CA0 Offset: 0x1987EA0 VA: 0x181988CA0 Slot: 4
	public object DeepClone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class AxisCalibrationInfo : IDeepCloneable // TypeDefIndex: 7595
{
	// Fields
	[SerializeField]
	private bool _applyRangeCalibration; // 0x10
	[SerializeField]
	private bool _invert; // 0x11
	[SerializeField]
	private float _deadZone; // 0x14
	[SerializeField]
	private float _zero; // 0x18
	[SerializeField]
	private float _min; // 0x1C
	[SerializeField]
	private float _max; // 0x20
	[SerializeField]
	private AxisSensitivityType _sensitivityType; // 0x24
	[SerializeField]
	private float _sensitivity; // 0x28
	[SerializeField]
	private AnimationCurve _sensitivityCurve; // 0x30

	// Properties
	public bool applyRangeCalibration { get; set; }
	public bool invert { get; set; }
	public float deadZone { get; set; }
	public float zero { get; set; }
	public float min { get; set; }
	public float max { get; set; }
	public AxisSensitivityType sensitivityType { get; set; }
	public float sensitivity { get; set; }
	public AnimationCurve sensitivityCurve { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_applyRangeCalibration() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_applyRangeCalibration(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_invert() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_invert(bool value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_deadZone() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_deadZone(float value) { }

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_zero() { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_zero(float value) { }

	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_min() { }

	// RVA: 0x498F80 Offset: 0x498180 VA: 0x180498F80
	public void set_min(float value) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_max() { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_max(float value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public AxisSensitivityType get_sensitivityType() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_sensitivityType(AxisSensitivityType value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_sensitivity() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_sensitivity(float value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public AnimationCurve get_sensitivityCurve() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_sensitivityCurve(AnimationCurve value) { }

	// RVA: 0x197C8A0 Offset: 0x197BAA0 VA: 0x18197C8A0
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x197C800 Offset: 0x197BA00 VA: 0x18197C800
	internal void .ctor(float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x197C3E0 Offset: 0x197B5E0 VA: 0x18197C3E0 Slot: 4
	public object DeepClone() { }

	// RVA: 0x197C510 Offset: 0x197B710 VA: 0x18197C510
	internal static AxisCalibrationData IrLPUhPlhklEElfoVBRvkBRLqKCE(AxisCalibrationInfo ) { }

	// RVA: 0x197C6B0 Offset: 0x197B8B0 VA: 0x18197C6B0
	internal static AxisCalibrationInfo UQaRWSvRlEDJZwOchjECKxDxTXOx(AxisCalibrationData ) { }
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IHardwareControllerMap // TypeDefIndex: 7596
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string[] GetElementIdentifierNames();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int[] GetElementIdentifierIds();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ContainsElementIdentifier(int id);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetMappableElementIdentifierInfo(out string[] names, out int[] ids);
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IHardwareControllerTemplateMap // TypeDefIndex: 7597
{}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IHardwareControllerMap_Internal // TypeDefIndex: 7598
{
	// Properties
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract string typeKey { get; }
	public abstract ControllerType controllerType { get; }
	public abstract IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_typeKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerType get_controllerType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<IControllerElementIdentifierCommon_Internal> get_ElementIdentifiers();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IHardwareControllerTemplateMap_Internal // TypeDefIndex: 7599
{
	// Properties
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract string typeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_typeKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetElementIdentifierCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract jDCySwCSAVHKuUnPmaQCBczTSqylA GetAxisTarget(Controller controller, int elementIdentifierId);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract jDCySwCSAVHKuUnPmaQCBczTSqylA GetButtonTarget(Controller controller, int elementIdentifierId);
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IControllerTemplateMapMapping_Internal // TypeDefIndex: 7600
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerElementTarget[] GetTargets();
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 7601
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T GetMapping<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IControllerTemplateMapSpecialElement_Internal.GetMapping<object>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap_Editor.WWSlGitPWtxjpaDxiSaFPnTxfrlfA : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7602
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMap_Editor nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x30

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

	// RVA: 0x198FB00 Offset: 0x198ED00 VA: 0x18198FB00 Slot: 7
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198FC70 Offset: 0x198EE70 VA: 0x18198FC70 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x198FBB0 Offset: 0x198EDB0 VA: 0x18198FBB0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x198FBB0 Offset: 0x198EDB0 VA: 0x18198FBB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class ControllerMap_Editor // TypeDefIndex: 7603
{
	// Fields
	public int id; // 0x10
	public int categoryId; // 0x14
	public int layoutId; // 0x18
	public string name; // 0x20
	public string hardwareGuidString; // 0x28
	public int customControllerUid; // 0x30
	public List<ActionElementMap> actionElementMaps; // 0x38

	// Properties
	public IEnumerable<ActionElementMap> ActionElementMaps { get; }
	public Guid hardwareGuid { get; }

	// Methods

	// RVA: 0x197EA50 Offset: 0x197DC50 VA: 0x18197EA50
	public IEnumerable<ActionElementMap> get_ActionElementMaps() { }

	// RVA: 0x197EAD0 Offset: 0x197DCD0 VA: 0x18197EAD0
	public Guid get_hardwareGuid() { }

	// RVA: 0x197E980 Offset: 0x197DB80 VA: 0x18197E980
	public void .ctor() { }

	// RVA: 0x197CFE0 Offset: 0x197C1E0 VA: 0x18197CFE0
	public ControllerMap_Editor Clone() { }

	// RVA: 0x197DD80 Offset: 0x197CF80 VA: 0x18197DD80
	public ActionElementMap GetActionElementMap(int index) { }

	// RVA: 0x197DA00 Offset: 0x197CC00 VA: 0x18197DA00
	internal JoystickMap CysKmNPKGhGnrXJexgaNOmJBEISV(Func<int, bool> , HardwareControllerMapIdentifier , HardwareJoystickMap , bool ) { }

	// RVA: 0x197DCD0 Offset: 0x197CED0 VA: 0x18197DCD0
	internal KeyboardMap FSWQaWFaHdIdIOUtKdtrydLLAOPgA(Func<int, bool> ) { }

	// RVA: 0x197DF10 Offset: 0x197D110 VA: 0x18197DF10
	internal MouseMap OUWojYCPNrFiJiJmOnpedoHGcnNK(Func<int, bool> ) { }

	// RVA: 0x197EB40 Offset: 0x197DD40 VA: 0x18197EB40
	internal CustomControllerMap ifVgkSrqvjAiYAFZTFAQVqPNWLQNA(Func<int, bool> , CustomController_Editor ) { }

	// RVA: 0x197E770 Offset: 0x197D970 VA: 0x18197E770
	internal ControllerTemplateMap UgAgRPCNvrqyxHXQdcduVLiSQLHS() { }

	// RVA: 0x197DFC0 Offset: 0x197D1C0 VA: 0x18197DFC0
	private void OjoGdbcqiAzVHKfDaqiNsiVJqnBnA(Func<int, bool> , ControllerMap , HardwareControllerMapIdentifier , HardwareJoystickMap , bool ) { }

	// RVA: 0x197E440 Offset: 0x197D640 VA: 0x18197E440
	private void TzHcsARgukuRMKXjvVYTqeTtKBeL(Func<int, bool> , InputSource , CustomControllerMap , CustomController_Editor ) { }

	// RVA: 0x197D200 Offset: 0x197C400 VA: 0x18197D200
	public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap) { }

	// RVA: 0x197D570 Offset: 0x197C770 VA: 0x18197D570
	public void CreateElementsFromHardwareMap(CustomController_Editor customController) { }

	// RVA: 0x197CF00 Offset: 0x197C100 VA: 0x18197CF00
	public void AddActionElementMap() { }

	// RVA: 0x197DE00 Offset: 0x197D000 VA: 0x18197DE00
	public void InsertActionElementMap(int index) { }

	// RVA: 0x197DAC0 Offset: 0x197CCC0 VA: 0x18197DAC0
	public void DeleteActionElementMap(int index) { }

	// RVA: 0x197E3D0 Offset: 0x197D5D0 VA: 0x18197E3D0
	public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x197DB70 Offset: 0x197CD70 VA: 0x18197DB70
	public void DuplicateActionElementMap(int index) { }

	// RVA: 0x197E9F0 Offset: 0x197DBF0 VA: 0x18197E9F0
	private ActionElementMap dZXDHVBufieozirdaqWMUuDdLjgrb() { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class CustomControllerExtension : Controller.Extension // TypeDefIndex: 7604
{
	// Fields
	private bool gkkdXHNDAbAOpJYvSKofpsqHhreCb; // 0x28

	// Methods

	// RVA: 0x197EC40 Offset: 0x197DE40 VA: 0x18197EC40
	public void .ctor(IControllerExtensionSource ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	protected void .ctor(CustomControllerExtension ) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	protected virtual void OnUpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected virtual void OnSourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	protected IControllerExtensionSource GetSource() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Controller.Extension ShallowCopy();

	// RVA: 0x577700 Offset: 0x576900 VA: 0x180577700 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x197EBF0 Offset: 0x197DDF0 VA: 0x18197EBF0 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x197EBD0 Offset: 0x197DDD0 VA: 0x18197EBD0 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualSenseExtension : IControllerVibrator, IDualShock4Extension // TypeDefIndex: 7605
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DualSenseTriggerEffectStates GetTriggerEffectStates();
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerType // TypeDefIndex: 7606
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerType Left = 0;
	public const DualSenseTriggerType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseMicrophoneLightMode // TypeDefIndex: 7607
{
	// Fields
	public byte value__; // 0x0
	public const DualSenseMicrophoneLightMode Off = 0;
	public const DualSenseMicrophoneLightMode On = 1;
	public const DualSenseMicrophoneLightMode Flash = 2;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseOtherLightBrightness // TypeDefIndex: 7608
{
	// Fields
	public byte value__; // 0x0
	public const DualSenseOtherLightBrightness Low = 0;
	public const DualSenseOtherLightBrightness Medium = 1;
	public const DualSenseOtherLightBrightness High = 2;
}

// Namespace: Rewired.ControllerExtensions
[Flags]
public enum DualSensePlayerLightFlags // TypeDefIndex: 7609
{
	// Fields
	public byte value__; // 0x0
	public const DualSensePlayerLightFlags None = 0;
	public const DualSensePlayerLightFlags One = 1;
	public const DualSensePlayerLightFlags Two = 2;
	public const DualSensePlayerLightFlags Three = 4;
	public const DualSensePlayerLightFlags Four = 8;
	public const DualSensePlayerLightFlags Five = 16;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseVibrationMode // TypeDefIndex: 7610
{
	// Fields
	public int value__; // 0x0
	public const DualSenseVibrationMode Advanced = 1;
	public const DualSenseVibrationMode Compatible = 2;
	public const DualSenseVibrationMode Compatible2 = 3;
}

// Namespace: 
private class DualSenseExtension.JrROwzMKBFrSIgxgYjMcppEtfpMS : IControllerExtensionSource // TypeDefIndex: 7611
{
	// Fields
	public readonly IDriver_DualSense osfbYErNpHKKbATBJwKOJgodywTn; // 0x10
	public readonly bool rZEjpvqfMcAThrRSferCjtmjEQRab; // 0x18
	public readonly int qqEgpTFOInFloJudXerUXKCMaSgR; // 0x1C

	// Methods

	// RVA: 0x198B170 Offset: 0x198A370 VA: 0x18198B170
	public void .ctor(IDriver_DualSense , bool , int ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class DualSenseExtension : Controller.Extension, IControllerVibrator, IDualSenseExtension, IDualShock4Extension, IHIDControllerExtension // TypeDefIndex: 7612
{
	// Fields
	private DualSenseExtension.JrROwzMKBFrSIgxgYjMcppEtfpMS SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x28
	private bool gkkdXHNDAbAOpJYvSKofpsqHhreCb; // 0x30
	private TimerAbs[] oWTvXzDCnjFljCitMACUyXVzuIZsA; // 0x38

	// Properties
	private Joystick joystick { get; }
	public int vibrationMotorCount { get; }
	public float lightColorRed { get; set; }
	public float lightColorGreen { get; set; }
	public float lightColorBlue { get; set; }
	public DualSenseMicrophoneLightMode microphoneLightMode { get; set; }
	public DualSenseOtherLightBrightness otherLightBrightness { get; set; }
	public DualSensePlayerLightFlags playerLights { get; set; }
	public int maxTouches { get; }
	public int touchCount { get; }
	public float batteryLevel { get; }
	public bool batteryCharging { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1982E70 Offset: 0x1982070 VA: 0x181982E70
	private Joystick xdBAgHgwaulsIOCzhOfdJrAQSDYtA() { }

	// RVA: 0x1982010 Offset: 0x1981210 VA: 0x181982010
	internal void .ctor(IDriver_DualSense ) { }

	// RVA: 0x1981EC0 Offset: 0x19810C0 VA: 0x181981EC0
	private void .ctor(DualSenseExtension ) { }

	// RVA: 0x1982920 Offset: 0x1981B20 VA: 0x181982920 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1981BE0 Offset: 0x1980DE0 VA: 0x181981BE0 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x1981820 Offset: 0x1980A20 VA: 0x181981820 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x19815C0 Offset: 0x19807C0 VA: 0x1819815C0 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1981A60 Offset: 0x1980C60 VA: 0x181981A60 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1980270 Offset: 0x197F470 VA: 0x181980270 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x1981CA0 Offset: 0x1980EA0 VA: 0x181981CA0 Slot: 14
	public void StopVibration() { }

	// RVA: 0x1980040 Offset: 0x197F240 VA: 0x181980040
	public DualSenseVibrationMode GetVibrationMode() { }

	// RVA: 0x1981480 Offset: 0x1980680 VA: 0x181981480
	public void SetVibrationMode(DualSenseVibrationMode mode) { }

	// RVA: 0x1980100 Offset: 0x197F300 VA: 0x181980100
	public float GetVibration(DualShock4MotorType motor) { }

	// RVA: 0x1981840 Offset: 0x1980A40 VA: 0x181981840
	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	// RVA: 0x1981BA0 Offset: 0x1980DA0 VA: 0x181981BA0
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	// RVA: 0x1981BC0 Offset: 0x1980DC0 VA: 0x181981BC0
	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x19815E0 Offset: 0x19807E0 VA: 0x1819815E0
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1981860 Offset: 0x1980A60 VA: 0x181981860 Slot: 33
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x1981880 Offset: 0x1980A80 VA: 0x181981880 Slot: 34
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x1982460 Offset: 0x1981660 VA: 0x181982460
	public float get_lightColorRed() { }

	// RVA: 0x1982B60 Offset: 0x1981D60 VA: 0x181982B60
	public void set_lightColorRed(float value) { }

	// RVA: 0x1982390 Offset: 0x1981590 VA: 0x181982390
	public float get_lightColorGreen() { }

	// RVA: 0x1982AF0 Offset: 0x1981CF0 VA: 0x181982AF0
	public void set_lightColorGreen(float value) { }

	// RVA: 0x19822C0 Offset: 0x19814C0 VA: 0x1819822C0
	public float get_lightColorBlue() { }

	// RVA: 0x1982A80 Offset: 0x1981C80 VA: 0x181982A80
	public void set_lightColorBlue(float value) { }

	// RVA: 0x197F440 Offset: 0x197E640 VA: 0x18197F440
	public Color GetLightColor() { }

	// RVA: 0x1981020 Offset: 0x1980220 VA: 0x181981020 Slot: 23
	public void SetLightColor(Color color) { }

	// RVA: 0x1981180 Offset: 0x1980380 VA: 0x181981180 Slot: 24
	public void SetLightColor(float red, float green, float blue) { }

	// RVA: 0x1980EA0 Offset: 0x19800A0 VA: 0x181980EA0 Slot: 25
	public void SetLightColor(float red, float green, float blue, float intensity) { }

	// RVA: 0x19825F0 Offset: 0x19817F0 VA: 0x1819825F0
	public DualSenseMicrophoneLightMode get_microphoneLightMode() { }

	// RVA: 0x1982BD0 Offset: 0x1981DD0 VA: 0x181982BD0
	public void set_microphoneLightMode(DualSenseMicrophoneLightMode value) { }

	// RVA: 0x19826C0 Offset: 0x19818C0 VA: 0x1819826C0
	public DualSenseOtherLightBrightness get_otherLightBrightness() { }

	// RVA: 0x1982CB0 Offset: 0x1981EB0 VA: 0x181982CB0
	public void set_otherLightBrightness(DualSenseOtherLightBrightness value) { }

	// RVA: 0x1982790 Offset: 0x1981990 VA: 0x181982790
	public DualSensePlayerLightFlags get_playerLights() { }

	// RVA: 0x1982D90 Offset: 0x1981F90 VA: 0x181982D90
	public void set_playerLights(DualSensePlayerLightFlags value) { }

	// RVA: 0x197ECC0 Offset: 0x197DEC0 VA: 0x18197ECC0 Slot: 18
	public Vector3 GetAccelerometerValueRaw() { }

	// RVA: 0x197EE00 Offset: 0x197E000 VA: 0x18197EE00 Slot: 17
	public Vector3 GetAccelerometerValue() { }

	// RVA: 0x197F1C0 Offset: 0x197E3C0 VA: 0x18197F1C0
	public Vector3 GetLastGyroscopeValueRaw() { }

	// RVA: 0x197F300 Offset: 0x197E500 VA: 0x18197F300
	public Vector3 GetLastGyroscopeValue() { }

	// RVA: 0x197EF40 Offset: 0x197E140 VA: 0x18197EF40
	public Vector3 GetGyroscopeValueRaw() { }

	// RVA: 0x197F080 Offset: 0x197E280 VA: 0x18197F080
	public Vector3 GetGyroscopeValue() { }

	// RVA: 0x197F5C0 Offset: 0x197E7C0 VA: 0x18197F5C0 Slot: 21
	public Quaternion GetOrientation() { }

	// RVA: 0x19806A0 Offset: 0x197F8A0 VA: 0x1819806A0 Slot: 22
	public void ResetOrientation() { }

	// RVA: 0x1982530 Offset: 0x1981730 VA: 0x181982530 Slot: 26
	public int get_maxTouches() { }

	// RVA: 0x1982860 Offset: 0x1981A60 VA: 0x181982860 Slot: 27
	public int get_touchCount() { }

	// RVA: 0x197F720 Offset: 0x197E920 VA: 0x18197F720 Slot: 28
	public int GetTouchId(int index) { }

	// RVA: 0x197FDA0 Offset: 0x197EFA0 VA: 0x18197FDA0 Slot: 29
	public bool GetTouchPosition(int index, out Vector2 position) { }

	// RVA: 0x197FC30 Offset: 0x197EE30 VA: 0x18197FC30 Slot: 30
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x197FA30 Offset: 0x197EC30 VA: 0x18197FA30
	public bool GetTouchPositionAbsolute(int index, out Vector2 position) { }

	// RVA: 0x197F830 Offset: 0x197EA30 VA: 0x18197F830
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x19804B0 Offset: 0x197F6B0 VA: 0x1819804B0 Slot: 31
	public bool IsTouching(int index) { }

	// RVA: 0x19803A0 Offset: 0x197F5A0 VA: 0x1819803A0 Slot: 32
	public bool IsTouchingByTouchId(int touchId) { }

	// RVA: 0x1982200 Offset: 0x1981400 VA: 0x181982200
	public float get_batteryLevel() { }

	// RVA: 0x1982140 Offset: 0x1981340 VA: 0x181982140
	public bool get_batteryCharging() { }

	// RVA: 0x1981330 Offset: 0x1980530 VA: 0x181981330 Slot: 15
	public bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect) { }

	// RVA: 0x197FF10 Offset: 0x197F110 VA: 0x18197FF10 Slot: 16
	public DualSenseTriggerEffectStates GetTriggerEffectStates() { }

	// RVA: 0x19808B0 Offset: 0x197FAB0 VA: 0x1819808B0 Slot: 20
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValue() { }

	// RVA: 0x1980760 Offset: 0x197F960 VA: 0x181980760 Slot: 19
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValueRaw() { }

	// RVA: 0x1980DE0 Offset: 0x197FFE0 VA: 0x181980DE0 Slot: 35
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1980AD0 Offset: 0x197FCD0 VA: 0x181980AD0 Slot: 36
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x1980B90 Offset: 0x197FD90 VA: 0x181980B90 Slot: 37
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1980A00 Offset: 0x197FC00 VA: 0x181980A00 Slot: 38
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1980C60 Offset: 0x197FE60 VA: 0x181980C60 Slot: 39
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1980D20 Offset: 0x197FF20 VA: 0x181980D20 Slot: 40
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x1981DE0 Offset: 0x1980FE0 VA: 0x181981DE0 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1981C00 Offset: 0x1980E00 VA: 0x181981C00 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x197EC60 Offset: 0x197DE60 VA: 0x18197EC60 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x19829C0 Offset: 0x1981BC0 VA: 0x1819829C0
	private void lAzNUmhqtxicPobytuVUvKsKECDL() { }

	// RVA: 0x19805C0 Offset: 0x197F7C0 VA: 0x1819805C0
	private void OgTMbPuSJaMezjTMkAjHIuHjcQSu(DualShock4MotorType , float , float ) { }
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerEffectType // TypeDefIndex: 7613
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerEffectType Off = 0;
	public const DualSenseTriggerEffectType Feedback = 1;
	public const DualSenseTriggerEffectType Weapon = 2;
	public const DualSenseTriggerEffectType Vibration = 3;
	public const DualSenseTriggerEffectType MultiplePositionFeedback = 4;
	public const DualSenseTriggerEffectType SlopeFeedback = 5;
	public const DualSenseTriggerEffectType MultiplePositionVibration = 6;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerEffectState // TypeDefIndex: 7614
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerEffectState Unknown = -1;
	public const DualSenseTriggerEffectState Off = 0;
	public const DualSenseTriggerEffectState FeedbackIdle = 1;
	public const DualSenseTriggerEffectState FeedbackApplyingForce = 2;
	public const DualSenseTriggerEffectState WeaponIdle = 3;
	public const DualSenseTriggerEffectState WeaponFiring = 4;
	public const DualSenseTriggerEffectState WeaponFired = 5;
	public const DualSenseTriggerEffectState VibrationIdle = 6;
	public const DualSenseTriggerEffectState VibrationVibrating = 7;
}

// Namespace: Rewired.ControllerExtensions
public struct DualSenseTriggerEffectStates // TypeDefIndex: 7615
{
	// Fields
	public DualSenseTriggerEffectState leftTrigger; // 0x0
	public DualSenseTriggerEffectState rightTrigger; // 0x4
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class DualSenseTriggerEffect // TypeDefIndex: 7616
{
	// Fields
	public const byte strengthMin = 0;
	public const byte strengthMax = 8;
	public const byte amplitudeMin = 0;
	public const byte amplitudeMax = 8;
	public const byte frequencyMin = 0;
	public const byte frequencyMax = 255;
	public const byte positionCount = 10;
	public const byte positionMin = 0;
	public const byte positionMax = 9;

	// Methods

	// RVA: 0x1983920 Offset: 0x1982B20 VA: 0x181983920
	internal static bool IsInRange(byte value, byte min, byte max) { }

	// RVA: 0x19838C0 Offset: 0x1982AC0 VA: 0x1819838C0
	internal static byte Clamp(byte value, byte min, byte max) { }

	// RVA: 0x19839C0 Offset: 0x1982BC0 VA: 0x1819839C0
	internal static float NormalizeStrength(byte value) { }

	// RVA: 0x1983A00 Offset: 0x1982C00 VA: 0x181983A00
	internal static float NormalizePosition(byte value) { }

	// RVA: 0x19839C0 Offset: 0x1982BC0 VA: 0x1819839C0
	internal static float NormalizeAmplitude(byte value) { }

	// RVA: 0x19839E0 Offset: 0x1982BE0 VA: 0x1819839E0
	internal static float NormalizeFrequency(byte value) { }

	// RVA: 0x1983A20 Offset: 0x1982C20 VA: 0x181983A20
	internal static void ThrowArgumentOutOfRange(string name, byte min, byte max) { }

	// RVA: 0x1983930 Offset: 0x1982B30 VA: 0x181983930
	internal static void LogValueClamped(byte origValue, byte clampedValue) { }
}

// Namespace: Rewired.ControllerExtensions
[DefaultMember("Item")]
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectPositionValueSet // TypeDefIndex: 7617
{
	// Fields
	public const int Count = 10;
	[SerializeField]
	private byte _position0; // 0x0
	[SerializeField]
	private byte _position1; // 0x1
	[SerializeField]
	private byte _position2; // 0x2
	[SerializeField]
	private byte _position3; // 0x3
	[SerializeField]
	private byte _position4; // 0x4
	[SerializeField]
	private byte _position5; // 0x5
	[SerializeField]
	private byte _position6; // 0x6
	[SerializeField]
	private byte _position7; // 0x7
	[SerializeField]
	private byte _position8; // 0x8
	[SerializeField]
	private byte _position9; // 0x9

	// Properties
	public byte Item { get; set; }

	// Methods

	// RVA: 0x19831F0 Offset: 0x19823F0 VA: 0x1819831F0
	public void .ctor(IList<byte> ) { }

	// RVA: 0x19834E0 Offset: 0x19826E0 VA: 0x1819834E0
	public byte get_Item(int index) { }

	// RVA: 0x19835E0 Offset: 0x19827E0 VA: 0x1819835E0
	public void set_Item(int index, byte value) { }

	// RVA: 0x1983190 Offset: 0x1982390 VA: 0x181983190
	public byte[] ToArray() { }

	// RVA: 0x1982FF0 Offset: 0x19821F0 VA: 0x181982FF0
	public void CopyTo(byte[] destination) { }

	// RVA: 0x1983410 Offset: 0x1982610 VA: 0x181983410
	internal void gMECBfSsqUEQYAQwhocXGvjlOauHb(byte , byte ) { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualSenseTriggerEffect // TypeDefIndex: 7618
{
	// Properties
	public abstract DualSenseTriggerEffectType triggerEffectType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DualSenseTriggerEffectType get_triggerEffectType();
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectOff : IDualSenseTriggerEffect // TypeDefIndex: 7619
{
	// Properties
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectFeedback : IDualSenseTriggerEffect // TypeDefIndex: 7620
{
	// Fields
	[SerializeField]
	private byte _position; // 0x0
	[SerializeField]
	private byte _strength; // 0x1

	// Properties
	public byte position { get; set; }
	public byte strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public byte get_position() { }

	// RVA: 0x1982EB0 Offset: 0x19820B0 VA: 0x181982EB0
	public void set_position(byte value) { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public byte get_strength() { }

	// RVA: 0x1982EE0 Offset: 0x19820E0 VA: 0x181982EE0
	public void set_strength(byte value) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectWeapon : IDualSenseTriggerEffect // TypeDefIndex: 7621
{
	// Fields
	[SerializeField]
	private byte _startPosition; // 0x0
	[SerializeField]
	private byte _endPosition; // 0x1
	[SerializeField]
	private byte _strength; // 0x2

	// Properties
	public byte startPosition { get; set; }
	public byte endPosition { get; set; }
	public byte strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public byte get_startPosition() { }

	// RVA: 0x1983830 Offset: 0x1982A30 VA: 0x181983830
	public void set_startPosition(byte value) { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public byte get_endPosition() { }

	// RVA: 0x19837E0 Offset: 0x19829E0 VA: 0x1819837E0
	public void set_endPosition(byte value) { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public byte get_strength() { }

	// RVA: 0x1983880 Offset: 0x1982A80 VA: 0x181983880
	public void set_strength(byte value) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectVibration : IDualSenseTriggerEffect // TypeDefIndex: 7622
{
	// Fields
	[SerializeField]
	private byte _position; // 0x0
	[SerializeField]
	private byte _amplitude; // 0x1
	[SerializeField]
	private byte _frequency; // 0x2

	// Properties
	public byte position { get; set; }
	public byte amplitude { get; set; }
	public byte frequency { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public byte get_position() { }

	// RVA: 0x1982EB0 Offset: 0x19820B0 VA: 0x181982EB0
	public void set_position(byte value) { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public byte get_amplitude() { }

	// RVA: 0x1982EE0 Offset: 0x19820E0 VA: 0x181982EE0
	public void set_amplitude(byte value) { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public byte get_frequency() { }

	// RVA: 0x19837D0 Offset: 0x19829D0 VA: 0x1819837D0
	public void set_frequency(byte value) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectMultiplePositionFeedback : IDualSenseTriggerEffect // TypeDefIndex: 7623
{
	// Fields
	[SerializeField]
	private DualSenseTriggerEffectPositionValueSet _strength; // 0x0

	// Properties
	public DualSenseTriggerEffectPositionValueSet strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x1982F20 Offset: 0x1982120 VA: 0x181982F20
	public DualSenseTriggerEffectPositionValueSet get_strength() { }

	// RVA: 0x1982F40 Offset: 0x1982140 VA: 0x181982F40
	public void set_strength(DualSenseTriggerEffectPositionValueSet value) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectSlopeFeedback : IDualSenseTriggerEffect // TypeDefIndex: 7624
{
	// Fields
	[SerializeField]
	private byte _startPosition; // 0x0
	[SerializeField]
	private byte _endPosition; // 0x1
	[SerializeField]
	private byte _startStrength; // 0x2
	[SerializeField]
	private byte _endStrength; // 0x3

	// Properties
	public byte startPosition { get; set; }
	public byte endPosition { get; set; }
	public byte startStrength { get; set; }
	public byte endStrength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public byte get_startPosition() { }

	// RVA: 0x1982EB0 Offset: 0x19820B0 VA: 0x181982EB0
	public void set_startPosition(byte value) { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public byte get_endPosition() { }

	// RVA: 0x19836F0 Offset: 0x19828F0 VA: 0x1819836F0
	public void set_endPosition(byte value) { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public byte get_startStrength() { }

	// RVA: 0x1983780 Offset: 0x1982980 VA: 0x181983780
	public void set_startStrength(byte value) { }

	// RVA: 0x19836E0 Offset: 0x19828E0 VA: 0x1819836E0
	public byte get_endStrength() { }

	// RVA: 0x1983730 Offset: 0x1982930 VA: 0x181983730
	public void set_endStrength(byte value) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectMultiplePositionVibration : IDualSenseTriggerEffect // TypeDefIndex: 7625
{
	// Fields
	[SerializeField]
	private byte _frequency; // 0x0
	[SerializeField]
	private DualSenseTriggerEffectPositionValueSet _amplitude; // 0x1

	// Properties
	public byte frequency { get; set; }
	public DualSenseTriggerEffectPositionValueSet amplitude { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public byte get_frequency() { }

	// RVA: 0x1982FE0 Offset: 0x19821E0 VA: 0x181982FE0
	public void set_frequency(byte value) { }

	// RVA: 0x1982F80 Offset: 0x1982180 VA: 0x181982F80
	public DualSenseTriggerEffectPositionValueSet get_amplitude() { }

	// RVA: 0x1982FA0 Offset: 0x19821A0 VA: 0x181982FA0
	public void set_amplitude(DualSenseTriggerEffectPositionValueSet value) { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualShock4Extension : IControllerVibrator // TypeDefIndex: 7626
{
	// Properties
	public abstract int maxTouches { get; }
	public abstract int touchCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 GetAccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 GetAccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 GetGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 GetGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Quaternion GetOrientation();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetLightColor(Color color);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetLightColor(float red, float green, float blue);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetLightColor(float red, float green, float blue, float intensity);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_maxTouches();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_touchCount();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetTouchId(int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool GetTouchPosition(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool IsTouching(int index);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool IsTouchingByTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetVibration(float leftMotorLevel, float rightMotorLevel);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration);
}

// Namespace: 
private class DualShock4Extension.XgteWEmiAEEJqITkbVpMLHRmttho : IControllerExtensionSource // TypeDefIndex: 7627
{
	// Fields
	public readonly IDriver_DualShock4 osfbYErNpHKKbATBJwKOJgodywTn; // 0x10
	public readonly bool rZEjpvqfMcAThrRSferCjtmjEQRab; // 0x18
	public readonly int qqEgpTFOInFloJudXerUXKCMaSgR; // 0x1C

	// Methods

	// RVA: 0x198B170 Offset: 0x198A370 VA: 0x18198B170
	public void .ctor(IDriver_DualShock4 , bool , int ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class DualShock4Extension : Controller.Extension, IControllerVibrator, IDualShock4Extension, IHIDControllerExtension // TypeDefIndex: 7628
{
	// Fields
	private DualShock4Extension.XgteWEmiAEEJqITkbVpMLHRmttho SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x28
	private bool gkkdXHNDAbAOpJYvSKofpsqHhreCb; // 0x30
	private TimerAbs[] oWTvXzDCnjFljCitMACUyXVzuIZsA; // 0x38

	// Properties
	private Joystick joystick { get; }
	public int vibrationMotorCount { get; }
	public float lightColorRed { get; set; }
	public float lightColorGreen { get; set; }
	public float lightColorBlue { get; set; }
	public int maxTouches { get; }
	public int touchCount { get; }
	public float batteryLevel { get; }
	public bool batteryCharging { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x19875C0 Offset: 0x19867C0 VA: 0x1819875C0
	private Joystick xdBAgHgwaulsIOCzhOfdJrAQSDYtA() { }

	// RVA: 0x1986B20 Offset: 0x1985D20 VA: 0x181986B20
	internal void .ctor(IDriver_DualShock4 ) { }

	// RVA: 0x1986C50 Offset: 0x1985E50 VA: 0x181986C50
	private void .ctor(DualShock4Extension ) { }

	// RVA: 0x1987310 Offset: 0x1986510 VA: 0x181987310 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1986570 Offset: 0x1985770 VA: 0x181986570 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x19861B0 Offset: 0x19853B0 VA: 0x1819861B0 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x1986170 Offset: 0x1985370 VA: 0x181986170 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1986430 Offset: 0x1985630 VA: 0x181986430 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1984E00 Offset: 0x1984000 VA: 0x181984E00 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x1986900 Offset: 0x1985B00 VA: 0x181986900 Slot: 14
	public void StopVibration() { }

	// RVA: 0x1984F30 Offset: 0x1984130 VA: 0x181984F30
	public float GetVibration(DualShock4MotorType motor) { }

	// RVA: 0x1986590 Offset: 0x1985790 VA: 0x181986590
	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	// RVA: 0x1986150 Offset: 0x1985350 VA: 0x181986150
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	// RVA: 0x1986410 Offset: 0x1985610 VA: 0x181986410
	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x19861D0 Offset: 0x19853D0 VA: 0x1819861D0
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1986190 Offset: 0x1985390 VA: 0x181986190 Slot: 31
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x19865B0 Offset: 0x19857B0 VA: 0x1819865B0 Slot: 32
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x19870C0 Offset: 0x19862C0 VA: 0x1819870C0
	public float get_lightColorRed() { }

	// RVA: 0x1987550 Offset: 0x1986750 VA: 0x181987550
	public void set_lightColorRed(float value) { }

	// RVA: 0x1986FF0 Offset: 0x19861F0 VA: 0x181986FF0
	public float get_lightColorGreen() { }

	// RVA: 0x19874E0 Offset: 0x19866E0 VA: 0x1819874E0
	public void set_lightColorGreen(float value) { }

	// RVA: 0x1986F20 Offset: 0x1986120 VA: 0x181986F20
	public float get_lightColorBlue() { }

	// RVA: 0x1987470 Offset: 0x1986670 VA: 0x181987470
	public void set_lightColorBlue(float value) { }

	// RVA: 0x1984330 Offset: 0x1983530 VA: 0x181984330
	public Color GetLightColor() { }

	// RVA: 0x1985D50 Offset: 0x1984F50 VA: 0x181985D50 Slot: 21
	public void SetLightColor(Color color) { }

	// RVA: 0x1985BA0 Offset: 0x1984DA0 VA: 0x181985BA0 Slot: 22
	public void SetLightColor(float red, float green, float blue) { }

	// RVA: 0x1985EB0 Offset: 0x19850B0 VA: 0x181985EB0 Slot: 23
	public void SetLightColor(float red, float green, float blue, float intensity) { }

	// RVA: 0x1986030 Offset: 0x1985230 VA: 0x181986030
	public void SetLightFlash(float onDuration, float offDuration) { }

	// RVA: 0x1986830 Offset: 0x1985A30 VA: 0x181986830
	public void StopLightFlash() { }

	// RVA: 0x1983BB0 Offset: 0x1982DB0 VA: 0x181983BB0 Slot: 16
	public Vector3 GetAccelerometerValueRaw() { }

	// RVA: 0x1983CF0 Offset: 0x1982EF0 VA: 0x181983CF0 Slot: 15
	public Vector3 GetAccelerometerValue() { }

	// RVA: 0x19840B0 Offset: 0x19832B0 VA: 0x1819840B0
	public Vector3 GetLastGyroscopeValueRaw() { }

	// RVA: 0x19841F0 Offset: 0x19833F0 VA: 0x1819841F0
	public Vector3 GetLastGyroscopeValue() { }

	// RVA: 0x1983E30 Offset: 0x1983030 VA: 0x181983E30
	public Vector3 GetGyroscopeValueRaw() { }

	// RVA: 0x1983F70 Offset: 0x1983170 VA: 0x181983F70
	public Vector3 GetGyroscopeValue() { }

	// RVA: 0x19844B0 Offset: 0x19836B0 VA: 0x1819844B0 Slot: 19
	public Quaternion GetOrientation() { }

	// RVA: 0x19853A0 Offset: 0x19845A0 VA: 0x1819853A0 Slot: 20
	public void ResetOrientation() { }

	// RVA: 0x1987190 Offset: 0x1986390 VA: 0x181987190 Slot: 24
	public int get_maxTouches() { }

	// RVA: 0x1987250 Offset: 0x1986450 VA: 0x181987250 Slot: 25
	public int get_touchCount() { }

	// RVA: 0x1984610 Offset: 0x1983810 VA: 0x181984610 Slot: 26
	public int GetTouchId(int index) { }

	// RVA: 0x1984C90 Offset: 0x1983E90 VA: 0x181984C90 Slot: 27
	public bool GetTouchPosition(int index, out Vector2 position) { }

	// RVA: 0x1984B20 Offset: 0x1983D20 VA: 0x181984B20 Slot: 28
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x1984920 Offset: 0x1983B20 VA: 0x181984920
	public bool GetTouchPositionAbsolute(int index, out Vector2 position) { }

	// RVA: 0x1984720 Offset: 0x1983920 VA: 0x181984720
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x19851B0 Offset: 0x19843B0 VA: 0x1819851B0 Slot: 29
	public bool IsTouching(int index) { }

	// RVA: 0x19850A0 Offset: 0x19842A0 VA: 0x1819850A0 Slot: 30
	public bool IsTouchingByTouchId(int touchId) { }

	// RVA: 0x1986E60 Offset: 0x1986060 VA: 0x181986E60
	public float get_batteryLevel() { }

	// RVA: 0x1986DA0 Offset: 0x1985FA0 VA: 0x181986DA0
	public bool get_batteryCharging() { }

	// RVA: 0x19855B0 Offset: 0x19847B0 VA: 0x1819855B0 Slot: 18
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValue() { }

	// RVA: 0x1985460 Offset: 0x1984660 VA: 0x181985460 Slot: 17
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValueRaw() { }

	// RVA: 0x1985AE0 Offset: 0x1984CE0 VA: 0x181985AE0 Slot: 33
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x19857D0 Offset: 0x19849D0 VA: 0x1819857D0 Slot: 34
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x1985890 Offset: 0x1984A90 VA: 0x181985890 Slot: 35
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1985700 Offset: 0x1984900 VA: 0x181985700 Slot: 36
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1985960 Offset: 0x1984B60 VA: 0x181985960 Slot: 37
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1985A20 Offset: 0x1984C20 VA: 0x181985A20 Slot: 38
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x1986A40 Offset: 0x1985C40 VA: 0x181986A40 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1986790 Offset: 0x1985990 VA: 0x181986790 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1983B50 Offset: 0x1982D50 VA: 0x181983B50 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x19873B0 Offset: 0x19865B0 VA: 0x1819873B0
	private void lAzNUmhqtxicPobytuVUvKsKECDL() { }

	// RVA: 0x19852C0 Offset: 0x19844C0 VA: 0x1819852C0
	private void OgTMbPuSJaMezjTMkAjHIuHjcQSu(DualShock4MotorType , float , float ) { }
}

// Namespace: Rewired.ControllerExtensions
public enum DualShock4MotorType // TypeDefIndex: 7629
{
	// Fields
	public int value__; // 0x0
	public const DualShock4MotorType LeftMotor = 0;
	public const DualShock4MotorType StrongMotor = 0;
	public const DualShock4MotorType RightMotor = 1;
	public const DualShock4MotorType WeakMotor = 1;
}

// Namespace: Rewired.ControllerExtensions
public interface IHIDControllerExtension // TypeDefIndex: 7630
{
	// Properties
	public abstract ushort vendorId { get; }
	public abstract ushort productId { get; }
	public abstract string productName { get; }
	public abstract string manufacturer { get; }
	public abstract ushort usagePage { get; }
	public abstract ushort usage { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ushort get_vendorId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ushort get_productId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_productName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_manufacturer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ushort get_usagePage();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ushort get_usage();
}

// Namespace: Rewired.ControllerExtensions
[Serializable]
public struct NintendoSwitchGamepadVibration : IEquatable<NintendoSwitchGamepadVibration> // TypeDefIndex: 7631
{
	// Fields
	internal const int frequencyLowDefault = 160;
	internal const int frequencyHighDefault = 320;
	public const float frequencyLowMin = 40,875885;
	public const float frequencyLowMax = 626,28613;
	public const float frequencyHighMin = 81,75177;
	public const float frequencyHighMax = 1252,5723;
	[FieldRange(0, 1)]
	public float amplitudeLow; // 0x0
	[FieldRange(40,875885, 626,28613)]
	public float frequencyLow; // 0x4
	[FieldRange(0, 1)]
	public float amplitudeHigh; // 0x8
	[FieldRange(81,75177, 1252,5723)]
	public float frequencyHigh; // 0xC

	// Properties
	internal static NintendoSwitchGamepadVibration iyriSQKXsaYSOxjAUPgxvfCwhUjj { get; }

	// Methods

	// RVA: 0x19969B0 Offset: 0x1995BB0 VA: 0x1819969B0
	internal void .ctor(float , float , float , float ) { }

	// RVA: 0x1996670 Offset: 0x1995870 VA: 0x181996670 Slot: 4
	public bool Equals(NintendoSwitchGamepadVibration other) { }

	// RVA: 0x19966B0 Offset: 0x19958B0 VA: 0x1819966B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1996770 Offset: 0x1995970 VA: 0x181996770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1996670 Offset: 0x1995870 VA: 0x181996670
	public static bool op_Equality(NintendoSwitchGamepadVibration a, NintendoSwitchGamepadVibration b) { }

	// RVA: 0x1996A10 Offset: 0x1995C10 VA: 0x181996A10
	public static bool op_Inequality(NintendoSwitchGamepadVibration a, NintendoSwitchGamepadVibration b) { }

	// RVA: 0x19967E0 Offset: 0x19959E0 VA: 0x1819967E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x9E8FF0 Offset: 0x9E81F0 VA: 0x1809E8FF0
	internal static NintendoSwitchGamepadVibration RzfaonqpyavkTwjXnLkJwCuNmRjN() { }

	// RVA: 0x1996650 Offset: 0x1995850 VA: 0x181996650
	public static NintendoSwitchGamepadVibration Create() { }

	// RVA: 0x1996590 Offset: 0x1995790 VA: 0x181996590
	public static NintendoSwitchGamepadVibration Create(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x1996600 Offset: 0x1995800 VA: 0x181996600
	public static NintendoSwitchGamepadVibration Create(float amplitudeLow, float amplitudeHigh) { }
}

// Namespace: Rewired.ControllerExtensions
public enum NintendoSwitchJoyConType // TypeDefIndex: 7632
{
	// Fields
	public int value__; // 0x0
	public const NintendoSwitchJoyConType Left = 0;
	public const NintendoSwitchJoyConType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
public enum NintendoSwitchJoyConGripStyle // TypeDefIndex: 7633
{
	// Fields
	public int value__; // 0x0
	public const NintendoSwitchJoyConGripStyle Vertical = 0;
	public const NintendoSwitchJoyConGripStyle Horizontal = 1;
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal class NintendoSwitchGamepadExtension.ExtSource_Base : IControllerExtensionSource // TypeDefIndex: 7634
{
	// Fields
	private readonly IDriver_NintendoSwitchController _driver; // 0x10

	// Properties
	public IDriver_NintendoSwitchController driver { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IDriver_NintendoSwitchController get_driver() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IDriver_NintendoSwitchController ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class NintendoSwitchGamepadExtension : Controller.Extension, IControllerVibrator, IHIDControllerExtension // TypeDefIndex: 7635
{
	// Fields
	private NintendoSwitchGamepadExtension.ExtSource_Base SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x28
	private bool gkkdXHNDAbAOpJYvSKofpsqHhreCb; // 0x30

	// Properties
	protected bool isValid { get; }
	protected Joystick joystick { get; }
	protected object source { get; }
	public int vibrationMotorCount { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	protected bool get_isValid() { }

	// RVA: 0x1996490 Offset: 0x1995690 VA: 0x181996490
	protected Joystick get_joystick() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	protected object get_source() { }

	// RVA: 0x197EC40 Offset: 0x197DE40 VA: 0x18197EC40
	internal void .ctor(NintendoSwitchGamepadExtension.ExtSource_Base ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	protected void .ctor(NintendoSwitchGamepadExtension ) { }

	// RVA: 0x19964D0 Offset: 0x19956D0 VA: 0x1819964D0 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1995130 Offset: 0x1994330 VA: 0x181995130
	public NintendoSwitchGamepadVibration GetVibration(int motorIndex) { }

	// RVA: 0x1996140 Offset: 0x1995340 VA: 0x181996140
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x19958A0 Offset: 0x1994AA0 VA: 0x1819958A0
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors) { }

	// RVA: 0x1995ED0 Offset: 0x19950D0 VA: 0x181995ED0
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration) { }

	// RVA: 0x1995B10 Offset: 0x1994D10 VA: 0x181995B10
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors) { }

	// RVA: 0x19959E0 Offset: 0x1994BE0 VA: 0x1819959E0
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration) { }

	// RVA: 0x1996010 Offset: 0x1995210 VA: 0x181996010
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, float duration) { }

	// RVA: 0x1995D90 Offset: 0x1994F90 VA: 0x181995D90
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, float duration, bool stopOtherMotors) { }

	// RVA: 0x1995C60 Offset: 0x1994E60 VA: 0x181995C60
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, bool stopOtherMotors) { }

	// RVA: 0x19963C0 Offset: 0x19955C0 VA: 0x1819963C0
	public void StopVibration(int motorIndex) { }

	// RVA: 0x1996300 Offset: 0x1995500 VA: 0x181996300 Slot: 14
	public void StopVibration() { }

	// RVA: 0x1995820 Offset: 0x1994A20 VA: 0x181995820 Slot: 9
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x1995860 Offset: 0x1994A60 VA: 0x181995860 Slot: 10
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x1995820 Offset: 0x1994A20 VA: 0x181995820 Slot: 11
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1995860 Offset: 0x1994A60 VA: 0x181995860 Slot: 12
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x19957F0 Offset: 0x19949F0 VA: 0x1819957F0 Slot: 13
	private float Rewired.Interfaces.IControllerVibrator.GetVibration(int motorIndex) { }

	// RVA: 0x1995730 Offset: 0x1994930 VA: 0x181995730 Slot: 15
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1995420 Offset: 0x1994620 VA: 0x181995420 Slot: 16
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x19954E0 Offset: 0x19946E0 VA: 0x1819954E0 Slot: 17
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1995350 Offset: 0x1994550 VA: 0x181995350 Slot: 18
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x19955B0 Offset: 0x19947B0 VA: 0x1819955B0 Slot: 19
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1995670 Offset: 0x1994870 VA: 0x181995670 Slot: 20
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1996260 Offset: 0x1995460 VA: 0x181996260 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }
}

// Namespace: 
private class NintendoSwitchProControllerExtension.FZBMpVzUxcjuvAWnjJOKFpUmocbL : NintendoSwitchGamepadExtension.ExtSource_Base // TypeDefIndex: 7636
{
	// Properties
	public IDriver_NintendoSwitchProController osfbYErNpHKKbATBJwKOJgodywTn { get; }

	// Methods

	// RVA: 0x19950A0 Offset: 0x19942A0 VA: 0x1819950A0
	public IDriver_NintendoSwitchProController hyVISYwhJFGWvaYqcLMLpvyrolaXA() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IDriver_NintendoSwitchProController ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class NintendoSwitchProControllerExtension : NintendoSwitchGamepadExtension, IControllerVibrator, IHIDControllerExtension // TypeDefIndex: 7637
{
	// Fields
	public int motorIndexLeft; // 0x38
	public int motorIndexRight; // 0x3C

	// Properties
	private NintendoSwitchProControllerExtension.FZBMpVzUxcjuvAWnjJOKFpUmocbL source { get; }

	// Methods

	// RVA: 0x1997130 Offset: 0x1996330 VA: 0x181997130
	private NintendoSwitchProControllerExtension.FZBMpVzUxcjuvAWnjJOKFpUmocbL iTufQtFnOhgvwAiYastJRXQEsdJEb() { }

	// RVA: 0x19970B0 Offset: 0x19962B0 VA: 0x1819970B0
	internal void .ctor(IDriver_NintendoSwitchProController ) { }

	// RVA: 0x19970A0 Offset: 0x19962A0 VA: 0x1819970A0
	private void .ctor(NintendoSwitchProControllerExtension ) { }

	// RVA: 0x1997040 Offset: 0x1996240 VA: 0x181997040 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: 
private class NintendoSwitchJoyConExtension.oWKMkopPvBsVlxfRhIQwcHjXmZSN : NintendoSwitchGamepadExtension.ExtSource_Base // TypeDefIndex: 7638
{
	// Properties
	public IDriver_NintendoSwitchJoyCon osfbYErNpHKKbATBJwKOJgodywTn { get; }

	// Methods

	// RVA: 0x19B05F0 Offset: 0x19AF7F0 VA: 0x1819B05F0
	public IDriver_NintendoSwitchJoyCon hyVISYwhJFGWvaYqcLMLpvyrolaXA() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IDriver_NintendoSwitchJoyCon ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class NintendoSwitchJoyConExtension : NintendoSwitchGamepadExtension, IControllerVibrator, IAxisCalibrationIndexMap, IHIDControllerExtension // TypeDefIndex: 7639
{
	// Properties
	private NintendoSwitchJoyConExtension.oWKMkopPvBsVlxfRhIQwcHjXmZSN source { get; }
	public NintendoSwitchJoyConType joyConType { get; }
	public NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; }

	// Methods

	// RVA: 0x1996EB0 Offset: 0x19960B0 VA: 0x181996EB0
	private NintendoSwitchJoyConExtension.oWKMkopPvBsVlxfRhIQwcHjXmZSN iTufQtFnOhgvwAiYastJRXQEsdJEb() { }

	// RVA: 0x1996C40 Offset: 0x1995E40 VA: 0x181996C40
	internal void .ctor(IDriver_NintendoSwitchJoyCon ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	private void .ctor(NintendoSwitchJoyConExtension ) { }

	// RVA: 0x1996DB0 Offset: 0x1995FB0 VA: 0x181996DB0
	public NintendoSwitchJoyConType get_joyConType() { }

	// RVA: 0x1996CB0 Offset: 0x1995EB0 VA: 0x181996CB0
	public NintendoSwitchJoyConGripStyle get_joyConGripStyle() { }

	// RVA: 0x1996F30 Offset: 0x1996130 VA: 0x181996F30
	public void set_joyConGripStyle(NintendoSwitchJoyConGripStyle value) { }

	// RVA: 0x1996AC0 Offset: 0x1995CC0 VA: 0x181996AC0 Slot: 21
	private int INrhxTvzEURUKjiaYtInbZQexIHU(int ) { }

	// RVA: 0x1996A60 Offset: 0x1995C60 VA: 0x181996A60 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: 
private class RailDriverExtension.JLhPXesiQehvMwMpZhLfDUMGASkXA : IControllerExtensionSource // TypeDefIndex: 7640
{
	// Fields
	public readonly IDriver_RailDriver osfbYErNpHKKbATBJwKOJgodywTn; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IDriver_RailDriver ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class RailDriverExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 7641
{
	// Fields
	private RailDriverExtension.JLhPXesiQehvMwMpZhLfDUMGASkXA SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x28

	// Properties
	private Joystick joystick { get; }
	public bool speakerEnabled { get; set; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x199D230 Offset: 0x199C430 VA: 0x18199D230
	private Joystick xdBAgHgwaulsIOCzhOfdJrAQSDYtA() { }

	// RVA: 0x199CFC0 Offset: 0x199C1C0 VA: 0x18199CFC0
	internal void .ctor(IDriver_RailDriver ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	private void .ctor(RailDriverExtension ) { }

	// RVA: 0x199D030 Offset: 0x199C230 VA: 0x18199D030
	public bool get_speakerEnabled() { }

	// RVA: 0x199D0F0 Offset: 0x199C2F0 VA: 0x18199D0F0
	public void set_speakerEnabled(bool value) { }

	// RVA: 0x199CC40 Offset: 0x199BE40 VA: 0x18199CC40
	public void SetLEDDisplay(int digitIndex, byte digitBitValues) { }

	// RVA: 0x199CDC0 Offset: 0x199BFC0 VA: 0x18199CDC0
	public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues) { }

	// RVA: 0x199CB80 Offset: 0x199BD80 VA: 0x18199CB80 Slot: 8
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x199C870 Offset: 0x199BA70 VA: 0x18199C870 Slot: 9
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x199C930 Offset: 0x199BB30 VA: 0x18199C930 Slot: 10
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x199C7A0 Offset: 0x199B9A0 VA: 0x18199C7A0 Slot: 11
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x199CA00 Offset: 0x199BC00 VA: 0x18199CA00 Slot: 12
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x199CAC0 Offset: 0x199BCC0 VA: 0x18199CAC0 Slot: 13
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x199CF40 Offset: 0x199C140 VA: 0x18199CF40 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x199C740 Offset: 0x199B940 VA: 0x18199C740 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
internal enum SteamControllerPadType // TypeDefIndex: 7642
{
	// Fields
	public uint value__; // 0x0
	public const SteamControllerPadType Left = 0;
	public const SteamControllerPadType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
internal enum SteamControllerActionOrigin // TypeDefIndex: 7643
{
	// Fields
	public int value__; // 0x0
	public const SteamControllerActionOrigin None = 0;
	public const SteamControllerActionOrigin A = 1;
	public const SteamControllerActionOrigin B = 2;
	public const SteamControllerActionOrigin X = 3;
	public const SteamControllerActionOrigin Y = 4;
	public const SteamControllerActionOrigin LeftBumper = 5;
	public const SteamControllerActionOrigin RightBumper = 6;
	public const SteamControllerActionOrigin LeftGrip = 7;
	public const SteamControllerActionOrigin RightGrip = 8;
	public const SteamControllerActionOrigin Start = 9;
	public const SteamControllerActionOrigin Back = 10;
	public const SteamControllerActionOrigin LeftPad_Touch = 11;
	public const SteamControllerActionOrigin LeftPad_Swipe = 12;
	public const SteamControllerActionOrigin LeftPad_Click = 13;
	public const SteamControllerActionOrigin LeftPad_DPadNorth = 14;
	public const SteamControllerActionOrigin LeftPad_DPadSouth = 15;
	public const SteamControllerActionOrigin LeftPad_DPadWest = 16;
	public const SteamControllerActionOrigin LeftPad_DPadEast = 17;
	public const SteamControllerActionOrigin RightPad_Touch = 18;
	public const SteamControllerActionOrigin RightPad_Swipe = 19;
	public const SteamControllerActionOrigin RightPad_Click = 20;
	public const SteamControllerActionOrigin RightPad_DPadNorth = 21;
	public const SteamControllerActionOrigin RightPad_DPadSouth = 22;
	public const SteamControllerActionOrigin RightPad_DPadWest = 23;
	public const SteamControllerActionOrigin RightPad_DPadEast = 24;
	public const SteamControllerActionOrigin LeftTrigger_Pull = 25;
	public const SteamControllerActionOrigin LeftTrigger_Click = 26;
	public const SteamControllerActionOrigin RightTrigger_Pull = 27;
	public const SteamControllerActionOrigin RightTrigger_Click = 28;
	public const SteamControllerActionOrigin LeftStick_Move = 29;
	public const SteamControllerActionOrigin LeftStick_Click = 30;
	public const SteamControllerActionOrigin LeftStick_DPadNorth = 31;
	public const SteamControllerActionOrigin LeftStick_DPadSouth = 32;
	public const SteamControllerActionOrigin LeftStick_DPadWest = 33;
	public const SteamControllerActionOrigin LeftStick_DPadEast = 34;
	public const SteamControllerActionOrigin Gyro_Move = 35;
	public const SteamControllerActionOrigin Gyro_Pitch = 36;
	public const SteamControllerActionOrigin Gyro_Yaw = 37;
	public const SteamControllerActionOrigin Gyro_Roll = 38;
	public const SteamControllerActionOrigin PS4_X = 39;
	public const SteamControllerActionOrigin PS4_Circle = 40;
	public const SteamControllerActionOrigin PS4_Triangle = 41;
	public const SteamControllerActionOrigin PS4_Square = 42;
	public const SteamControllerActionOrigin PS4_LeftBumper = 43;
	public const SteamControllerActionOrigin PS4_RightBumper = 44;
	public const SteamControllerActionOrigin PS4_Options = 45;
	public const SteamControllerActionOrigin PS4_Share = 46;
	public const SteamControllerActionOrigin PS4_LeftPad_Touch = 47;
	public const SteamControllerActionOrigin PS4_LeftPad_Swipe = 48;
	public const SteamControllerActionOrigin PS4_LeftPad_Click = 49;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadNorth = 50;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadSouth = 51;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadWest = 52;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadEast = 53;
	public const SteamControllerActionOrigin PS4_RightPad_Touch = 54;
	public const SteamControllerActionOrigin PS4_RightPad_Swipe = 55;
	public const SteamControllerActionOrigin PS4_RightPad_Click = 56;
	public const SteamControllerActionOrigin PS4_RightPad_DPadNorth = 57;
	public const SteamControllerActionOrigin PS4_RightPad_DPadSouth = 58;
	public const SteamControllerActionOrigin PS4_RightPad_DPadWest = 59;
	public const SteamControllerActionOrigin PS4_RightPad_DPadEast = 60;
	public const SteamControllerActionOrigin PS4_CenterPad_Touch = 61;
	public const SteamControllerActionOrigin PS4_CenterPad_Swipe = 62;
	public const SteamControllerActionOrigin PS4_CenterPad_Click = 63;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadNorth = 64;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadSouth = 65;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadWest = 66;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadEast = 67;
	public const SteamControllerActionOrigin PS4_LeftTrigger_Pull = 68;
	public const SteamControllerActionOrigin PS4_LeftTrigger_Click = 69;
	public const SteamControllerActionOrigin PS4_RightTrigger_Pull = 70;
	public const SteamControllerActionOrigin PS4_RightTrigger_Click = 71;
	public const SteamControllerActionOrigin PS4_LeftStick_Move = 72;
	public const SteamControllerActionOrigin PS4_LeftStick_Click = 73;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadNorth = 74;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadSouth = 75;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadWest = 76;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadEast = 77;
	public const SteamControllerActionOrigin PS4_RightStick_Move = 78;
	public const SteamControllerActionOrigin PS4_RightStick_Click = 79;
	public const SteamControllerActionOrigin PS4_RightStick_DPadNorth = 80;
	public const SteamControllerActionOrigin PS4_RightStick_DPadSouth = 81;
	public const SteamControllerActionOrigin PS4_RightStick_DPadWest = 82;
	public const SteamControllerActionOrigin PS4_RightStick_DPadEast = 83;
	public const SteamControllerActionOrigin PS4_DPad_North = 84;
	public const SteamControllerActionOrigin PS4_DPad_South = 85;
	public const SteamControllerActionOrigin PS4_DPad_West = 86;
	public const SteamControllerActionOrigin PS4_DPad_East = 87;
	public const SteamControllerActionOrigin PS4_Gyro_Move = 88;
	public const SteamControllerActionOrigin PS4_Gyro_Pitch = 89;
	public const SteamControllerActionOrigin PS4_Gyro_Yaw = 90;
	public const SteamControllerActionOrigin PS4_Gyro_Roll = 91;
	public const SteamControllerActionOrigin XBoxOne_A = 92;
	public const SteamControllerActionOrigin XBoxOne_B = 93;
	public const SteamControllerActionOrigin XBoxOne_X = 94;
	public const SteamControllerActionOrigin XBoxOne_Y = 95;
	public const SteamControllerActionOrigin XBoxOne_LeftBumper = 96;
	public const SteamControllerActionOrigin XBoxOne_RightBumper = 97;
	public const SteamControllerActionOrigin XBoxOne_Menu = 98;
	public const SteamControllerActionOrigin XBoxOne_View = 99;
	public const SteamControllerActionOrigin XBoxOne_LeftTrigger_Pull = 100;
	public const SteamControllerActionOrigin XBoxOne_LeftTrigger_Click = 101;
	public const SteamControllerActionOrigin XBoxOne_RightTrigger_Pull = 102;
	public const SteamControllerActionOrigin XBoxOne_RightTrigger_Click = 103;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_Move = 104;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_Click = 105;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadNorth = 106;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadSouth = 107;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadWest = 108;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadEast = 109;
	public const SteamControllerActionOrigin XBoxOne_RightStick_Move = 110;
	public const SteamControllerActionOrigin XBoxOne_RightStick_Click = 111;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadNorth = 112;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadSouth = 113;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadWest = 114;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadEast = 115;
	public const SteamControllerActionOrigin XBoxOne_DPad_North = 116;
	public const SteamControllerActionOrigin XBoxOne_DPad_South = 117;
	public const SteamControllerActionOrigin XBoxOne_DPad_West = 118;
	public const SteamControllerActionOrigin XBoxOne_DPad_East = 119;
	public const SteamControllerActionOrigin XBox360_A = 120;
	public const SteamControllerActionOrigin XBox360_B = 121;
	public const SteamControllerActionOrigin XBox360_X = 122;
	public const SteamControllerActionOrigin XBox360_Y = 123;
	public const SteamControllerActionOrigin XBox360_LeftBumper = 124;
	public const SteamControllerActionOrigin XBox360_RightBumper = 125;
	public const SteamControllerActionOrigin XBox360_Start = 126;
	public const SteamControllerActionOrigin XBox360_Back = 127;
	public const SteamControllerActionOrigin XBox360_LeftTrigger_Pull = 128;
	public const SteamControllerActionOrigin XBox360_LeftTrigger_Click = 129;
	public const SteamControllerActionOrigin XBox360_RightTrigger_Pull = 130;
	public const SteamControllerActionOrigin XBox360_RightTrigger_Click = 131;
	public const SteamControllerActionOrigin XBox360_LeftStick_Move = 132;
	public const SteamControllerActionOrigin XBox360_LeftStick_Click = 133;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadNorth = 134;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadSouth = 135;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadWest = 136;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadEast = 137;
	public const SteamControllerActionOrigin XBox360_RightStick_Move = 138;
	public const SteamControllerActionOrigin XBox360_RightStick_Click = 139;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadNorth = 140;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadSouth = 141;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadWest = 142;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadEast = 143;
	public const SteamControllerActionOrigin XBox360_DPad_North = 144;
	public const SteamControllerActionOrigin XBox360_DPad_South = 145;
	public const SteamControllerActionOrigin XBox360_DPad_West = 146;
	public const SteamControllerActionOrigin XBox360_DPad_East = 147;
	public const SteamControllerActionOrigin SteamV2_A = 148;
	public const SteamControllerActionOrigin SteamV2_B = 149;
	public const SteamControllerActionOrigin SteamV2_X = 150;
	public const SteamControllerActionOrigin SteamV2_Y = 151;
	public const SteamControllerActionOrigin SteamV2_LeftBumper = 152;
	public const SteamControllerActionOrigin SteamV2_RightBumper = 153;
	public const SteamControllerActionOrigin SteamV2_LeftGrip = 154;
	public const SteamControllerActionOrigin SteamV2_RightGrip = 155;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Upper = 156;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Upper = 157;
	public const SteamControllerActionOrigin SteamV2_LeftBumper_Pressure = 158;
	public const SteamControllerActionOrigin SteamV2_RightBumper_Pressure = 159;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Pressure = 160;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Pressure = 161;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Upper_Pressure = 162;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Upper_Pressure = 163;
	public const SteamControllerActionOrigin SteamV2_Start = 164;
	public const SteamControllerActionOrigin SteamV2_Back = 165;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Touch = 166;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Swipe = 167;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Click = 168;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Pressure = 169;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadNorth = 170;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadSouth = 171;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadWest = 172;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadEast = 173;
	public const SteamControllerActionOrigin SteamV2_RightPad_Touch = 174;
	public const SteamControllerActionOrigin SteamV2_RightPad_Swipe = 175;
	public const SteamControllerActionOrigin SteamV2_RightPad_Click = 176;
	public const SteamControllerActionOrigin SteamV2_RightPad_Pressure = 177;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadNorth = 178;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadSouth = 179;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadWest = 180;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadEast = 181;
	public const SteamControllerActionOrigin SteamV2_LeftTrigger_Pull = 182;
	public const SteamControllerActionOrigin SteamV2_LeftTrigger_Click = 183;
	public const SteamControllerActionOrigin SteamV2_RightTrigger_Pull = 184;
	public const SteamControllerActionOrigin SteamV2_RightTrigger_Click = 185;
	public const SteamControllerActionOrigin SteamV2_LeftStick_Move = 186;
	public const SteamControllerActionOrigin SteamV2_LeftStick_Click = 187;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadNorth = 188;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadSouth = 189;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadWest = 190;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadEast = 191;
	public const SteamControllerActionOrigin SteamV2_Gyro_Move = 192;
	public const SteamControllerActionOrigin SteamV2_Gyro_Pitch = 193;
	public const SteamControllerActionOrigin SteamV2_Gyro_Yaw = 194;
	public const SteamControllerActionOrigin SteamV2_Gyro_Roll = 195;
	public const SteamControllerActionOrigin Count = 196;
}

// Namespace: 
private class SteamControllerExtension.RVCCULCuVYVHeGkVxKDgxvcqrxIq : IControllerExtensionSource // TypeDefIndex: 7644
{
	// Fields
	public readonly ISteamControllerInternal WTNpFDELdQfwigDSEjDhNFHsptJG; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ISteamControllerInternal ) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamControllerExtension : Controller.Extension // TypeDefIndex: 7645
{
	// Fields
	private SteamControllerExtension.RVCCULCuVYVHeGkVxKDgxvcqrxIq PKfQXIKSJfbcbHmkplZndVmtesxB; // 0x28

	// Properties
	private Joystick joystick { get; }
	internal ISteamControllerInternal internalController { get; }

	// Methods

	// RVA: 0x199EB90 Offset: 0x199DD90 VA: 0x18199EB90
	private Joystick xdBAgHgwaulsIOCzhOfdJrAQSDYtA() { }

	// RVA: 0x199EB70 Offset: 0x199DD70 VA: 0x18199EB70
	internal ISteamControllerInternal get_internalController() { }

	// RVA: 0x199EB00 Offset: 0x199DD00 VA: 0x18199EB00
	internal void .ctor(ISteamControllerInternal ) { }

	// RVA: 0x197EC50 Offset: 0x197DE50 VA: 0x18197EC50
	private void .ctor(SteamControllerExtension ) { }

	// RVA: 0x199D310 Offset: 0x199C510 VA: 0x18199D310
	public ulong GetActionSetHandle(string actionSetName) { }

	// RVA: 0x199D730 Offset: 0x199C930 VA: 0x18199D730
	public ulong GetAnalogActionHandle(string actionName) { }

	// RVA: 0x199DEA0 Offset: 0x199D0A0 VA: 0x18199DEA0
	public ulong GetDigitalActionHandle(string actionName) { }

	// RVA: 0x199D440 Offset: 0x199C640 VA: 0x18199D440
	public string GetActionSetName(ulong actionSetHandle) { }

	// RVA: 0x199D860 Offset: 0x199CA60 VA: 0x18199D860
	public string GetAnalogActionName(ulong actionHandle) { }

	// RVA: 0x199DFD0 Offset: 0x199D1D0 VA: 0x18199DFD0
	public string GetDigitalActionName(ulong actionHandle) { }

	// RVA: 0x199DBB0 Offset: 0x199CDB0 VA: 0x18199DBB0
	public Vector2 GetAnalogActionValue(string actionName) { }

	// RVA: 0x199DD20 Offset: 0x199CF20 VA: 0x18199DD20
	public Vector2 GetAnalogActionValue(ulong actionHandle) { }

	// RVA: 0x199E3F0 Offset: 0x199D5F0 VA: 0x18199E3F0
	public bool GetDigitalActionValue(string actionName) { }

	// RVA: 0x199E320 Offset: 0x199D520 VA: 0x18199E320
	public bool GetDigitalActionValue(ulong actionHandle) { }

	// RVA: 0x199E650 Offset: 0x199D850 VA: 0x18199E650
	public bool SetActiveActionSet(ulong actionSetHandle) { }

	// RVA: 0x199E520 Offset: 0x199D720 VA: 0x18199E520
	public bool SetActiveActionSet(string actionSetName) { }

	// RVA: 0x199D530 Offset: 0x199C730 VA: 0x18199D530
	public ulong GetActiveActionSetHandle() { }

	// RVA: 0x199D660 Offset: 0x199C860 VA: 0x18199D660
	public string GetActiveActionSetName() { }

	// RVA: 0x199E9C0 Offset: 0x199DBC0 VA: 0x18199E9C0
	public void ShowBindingPanel() { }

	// RVA: 0x199E720 Offset: 0x199D920 VA: 0x18199E720
	public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds) { }

	// RVA: 0x199E870 Offset: 0x199DA70 VA: 0x18199E870
	public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds) { }

	// RVA: 0x199E0C0 Offset: 0x199D2C0 VA: 0x18199E0C0
	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName) { }

	// RVA: 0x199E220 Offset: 0x199D420 VA: 0x18199E220
	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	// RVA: 0x199D950 Offset: 0x199CB50 VA: 0x18199D950
	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName) { }

	// RVA: 0x199DAB0 Offset: 0x199CCB0 VA: 0x18199DAB0
	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x199EA80 Offset: 0x199DC80 VA: 0x18199EA80 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x199D2B0 Offset: 0x199C4B0 VA: 0x18199D2B0 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }
}

// Namespace: Rewired.Config
[Flags]
public enum UpdateLoopSetting // TypeDefIndex: 7646
{
	// Fields
	public int value__; // 0x0
	public const UpdateLoopSetting None = 0;
	public const UpdateLoopSetting Update = 1;
	public const UpdateLoopSetting FixedUpdate = 2;
	public const UpdateLoopSetting OnGUI = 4;
}

// Namespace: Rewired.Config
public enum UpdateMode // TypeDefIndex: 7647
{
	// Fields
	public int value__; // 0x0
	public const UpdateMode Automatic = 0;
	public const UpdateMode Manual = 1;
}

// Namespace: Rewired.Config
public enum ThrottleCalibrationMode // TypeDefIndex: 7648
{
	// Fields
	public int value__; // 0x0
	public const ThrottleCalibrationMode ZeroToOne = 0;
	public const ThrottleCalibrationMode NegativeOneToOne = 1;
}

// Namespace: Rewired.Config
public enum KeyCombinationOverrideMode // TypeDefIndex: 7649
{
	// Fields
	public int value__; // 0x0
	public const KeyCombinationOverrideMode None = 0;
	public const KeyCombinationOverrideMode Pause = 1;
	public const KeyCombinationOverrideMode Cancel = 2;
	public const KeyCombinationOverrideMode Overlap = 3;
}

// Namespace: Rewired.Config
public enum EnhancedDeviceSupportDeviceType // TypeDefIndex: 7650
{
	// Fields
	public int value__; // 0x0
	public const EnhancedDeviceSupportDeviceType SonyDualShock4 = 1;
	public const EnhancedDeviceSupportDeviceType SonyDualSense = 2;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchProController = 100;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchJoyConLeft = 101;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchJoyConRight = 102;
	public const EnhancedDeviceSupportDeviceType PIEngineeringRailDriver = 1000;
}

// Namespace: Rewired.Config
[Flags]
public enum LogLevelFlags // TypeDefIndex: 7651
{
	// Fields
	public int value__; // 0x0
	public const LogLevelFlags Off = 0;
	public const LogLevelFlags Info = 1;
	public const LogLevelFlags Warning = 2;
	public const LogLevelFlags Error = 4;
	public const LogLevelFlags Debug = 8;
}

// Namespace: Rewired.Config
[CustomObfuscation(rename = False)]
internal enum LogLevel // TypeDefIndex: 7652
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const LogLevel Info = 0;
	[CustomObfuscation(rename = False)]
	public const LogLevel Warning = 1;
	[CustomObfuscation(rename = False)]
	public const LogLevel Error = 2;
	[CustomObfuscation(rename = False)]
	public const LogLevel Debug = 3;
}

// Namespace: Rewired.Components
[AddComponentMenu("")]
[Serializable]
public abstract class ComponentWrapper<T> : MonoBehaviour // TypeDefIndex: 7653
{
	// Fields
	private T SDwzWAaQayKsUsCLxvZirfQfmcnS; // 0x0
	private bool MAvCDWNDMJjDwBKVWzYzOlRqXElo; // 0x0

	// Properties
	protected T source { get; }
	protected bool initialized { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected T get_source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-ComponentWrapper<object>.get_source
	*/

	// RVA: -1 Offset: -1
	protected bool get_initialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	|-ComponentWrapper<object>.get_initialized
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D570 Offset: 0xF7C770 VA: 0x180F7D570
	|-ComponentWrapper<object>.Awake
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E6600 Offset: 0x6E5800 VA: 0x1806E6600
	|-ComponentWrapper<object>.Start
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x82EEC0 Offset: 0x82E0C0 VA: 0x18082EEC0
	|-ComponentWrapper<object>.OnEnable
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	|-ComponentWrapper<object>.OnDisable
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00
	|-ComponentWrapper<object>.OnDestroy
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x577700 Offset: 0x576900 VA: 0x180577700
	|-ComponentWrapper<object>.Reset
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnValidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7F6700 Offset: 0x7F5900 VA: 0x1807F6700
	|-ComponentWrapper<object>.OnValidate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnAwake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D630 Offset: 0xF7C830 VA: 0x180F7D630
	|-ComponentWrapper<object>.OnAwake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnAwakeFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnAwakeFinished
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnStart
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void OnDisabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnDisabled
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnDestroyed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D6E0 Offset: 0xF7C8E0 VA: 0x180F7D6E0
	|-ComponentWrapper<object>.OnDestroyed
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnReset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void OnValidated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ComponentWrapper<object>.OnValidated
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D5E0 Offset: 0xF7C7E0 VA: 0x180F7D5E0
	|-ComponentWrapper<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool TryInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D840 Offset: 0xF7CA40 VA: 0x180F7D840
	|-ComponentWrapper<object>.TryInitialize
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract T CreateSource(object args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ComponentWrapper<object>.CreateSource
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract object GetCreateSourceArgs();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ComponentWrapper<object>.GetCreateSourceArgs
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void PostInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0
	|-ComponentWrapper<object>.PostInitialize
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual void Deinitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D5B0 Offset: 0xF7C7B0 VA: 0x180F7D5B0
	|-ComponentWrapper<object>.Deinitialize
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void Subscribe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D790 Offset: 0xF7C990 VA: 0x180F7D790
	|-ComponentWrapper<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void Unsubscribe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D8D0 Offset: 0xF7CAD0 VA: 0x180F7D8D0
	|-ComponentWrapper<object>.Unsubscribe
	*/

	// RVA: -1 Offset: -1
	private void OrTuNCIfHGGWuHSsxIlpozkDrEIf() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760
	|-ComponentWrapper<object>.OrTuNCIfHGGWuHSsxIlpozkDrEIf
	*/

	// RVA: -1 Offset: -1
	private void KsnBDnjMQshBIIsvKKzCfsHCnqzaA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0
	|-ComponentWrapper<object>.KsnBDnjMQshBIIsvKKzCfsHCnqzaA
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	|-ComponentWrapper<object>..ctor
	*/
}

// Namespace: 
[Serializable]
public class PlayerController.ButtonStateChangedHandler : UnityEvent<int, bool> // TypeDefIndex: 7654
{
	// Methods

	// RVA: 0x1990F80 Offset: 0x1990180 VA: 0x181990F80
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerController.AxisValueChangedHandler : UnityEvent<int, float> // TypeDefIndex: 7655
{
	// Methods

	// RVA: 0x1990F30 Offset: 0x1990130 VA: 0x181990F30
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerController.EnabledStateChangedHandler : UnityEvent<bool> // TypeDefIndex: 7656
{
	// Methods

	// RVA: 0x1995060 Offset: 0x1994260 VA: 0x181995060
	public void .ctor() { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal sealed class PlayerController.ElementWithSourceInfo // TypeDefIndex: 7657
{
	// Fields
	[Tooltip("The name of the element.")]
	[SerializeField]
	private string _name; // 0x10
	[Tooltip("The element type.")]
	[SerializeField]
	private PlayerController.Element.TypeWithSource _elementType; // 0x18
	[Tooltip("Is this element enabled? Disabled elements return no value.")]
	[SerializeField]
	private bool _enabled; // 0x1C
	[SerializeField]
	[Tooltip("The Action id of the Action which will be used as the input source for the Element.")]
	private int _actionId; // 0x20
	[Tooltip("The output coordinate mode of the axis. An Absolute axis will only return value for input received from Absolute sources. A Relative axis will return value for input received from both Relative and Absolute sources. When converting from an Absolute input source to a Relative output, absoluteToRelativeSensitivity will be multiplied by the Absolute value to yield a simulated Relative value.")]
	[SerializeField]
	private AxisCoordinateMode _coordinateMode; // 0x24
	[FieldRange(0, 3,4028235E+38)]
	[SerializeField]
	[Tooltip("The absolute to relative sensitivity multiplier. This is only applied when the axis coordinate mode is set to Relative and the axis receives Absolute coordinate mode input (joystick axes, keyboard keys, etc.).")]
	private float _absoluteToRelativeSensitivity; // 0x28
	[FieldRange(0, 3,4028235E+38)]
	[SerializeField]
	[Tooltip("The number of times per second the wheel ticks when the value source is an absolute axis value.")]
	private float _repeatRate; // 0x2C

	// Properties
	public string name { get; set; }
	public PlayerController.Element.TypeWithSource elementType { get; set; }
	public bool enabled { get; set; }
	public int actionId { get; set; }
	public AxisCoordinateMode coordinateMode { get; set; }
	public float absoluteSourceSensitivity { get; set; }
	public float repeatRate { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_name(string value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public PlayerController.Element.TypeWithSource get_elementType() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_elementType(PlayerController.Element.TypeWithSource value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_enabled() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_enabled(bool value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_actionId() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_actionId(int value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public AxisCoordinateMode get_coordinateMode() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_coordinateMode(AxisCoordinateMode value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_absoluteSourceSensitivity() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_absoluteSourceSensitivity(float value) { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float get_repeatRate() { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_repeatRate(float value) { }

	// RVA: 0x1994D90 Offset: 0x1993F90 VA: 0x181994D90
	public PlayerController.Element.Definition ToDefinition() { }

	// RVA: 0x1995040 Offset: 0x1994240 VA: 0x181995040
	public void .ctor() { }
}

// Namespace: 
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal sealed class PlayerController.ElementInfo // TypeDefIndex: 7658
{
	// Fields
	[Tooltip("The name of the element.")]
	[SerializeField]
	private string _name; // 0x10
	[Tooltip("The element type.")]
	[SerializeField]
	private PlayerController.Element.Type _elementType; // 0x18
	[Tooltip("Is this element enabled? Disabled elements return no value.")]
	[SerializeField]
	private bool _enabled; // 0x1C
	[SerializeField]
	private PlayerController.ElementWithSourceInfo[] _elements; // 0x20

	// Properties
	public string name { get; set; }
	public PlayerController.Element.Type elementType { get; set; }
	public bool enabled { get; set; }
	public PlayerController.ElementWithSourceInfo[] elements { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_name(string value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public PlayerController.Element.Type get_elementType() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_elementType(PlayerController.Element.Type value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_enabled() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_enabled(bool value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PlayerController.ElementWithSourceInfo[] get_elements() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_elements(PlayerController.ElementWithSourceInfo[] value) { }

	// RVA: 0x1994620 Offset: 0x1993820 VA: 0x181994620
	public PlayerController.Element.Definition ToDefinition() { }

	// RVA: 0x1994D40 Offset: 0x1993F40 VA: 0x181994D40
	public void .ctor() { }
}

// Namespace: Rewired.Components
[AddComponentMenu("Rewired/Player Controllers/Player Controller")]
[Serializable]
public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController // TypeDefIndex: 7659
{
	// Fields
	[CustomObfuscation(rename = False)]
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Action ids, Player ids, etc.")]
	[SerializeField]
	private InputManager_Base _rewiredInputManager; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Player id of the Player used for the source of input.")]
	private int _playerId; // 0x38
	[CustomObfuscation(rename = False)]
	[Tooltip("The elements that will be created in the controller.")]
	[SerializeField]
	private List<PlayerController.ElementInfo> _elements; // 0x40
	[CustomObfuscation(rename = False)]
	[Tooltip("Triggered the first frame the button is pressed or released.")]
	[SerializeField]
	private PlayerController.ButtonStateChangedHandler _onButtonStateChanged; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Triggered when the axis value changes.")]
	private PlayerController.AxisValueChangedHandler _onAxisValueChanged; // 0x50
	[SerializeField]
	[Tooltip("Triggered when the controller is enabled or disabled.")]
	[CustomObfuscation(rename = False)]
	private PlayerController.EnabledStateChangedHandler _onEnabledStateChanged; // 0x58

	// Properties
	public int playerId { get; set; }
	public IList<PlayerController.Button> buttons { get; }
	public IList<PlayerController.Axis> axes { get; }
	public IList<PlayerController.Element> elements { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int elementCount { get; }

	// Methods

	// RVA: 0x1998720 Offset: 0x1997920 VA: 0x181998720 Slot: 22
	public int get_playerId() { }

	// RVA: 0x19989A0 Offset: 0x1997BA0 VA: 0x1819989A0 Slot: 23
	public void set_playerId(int value) { }

	// RVA: 0x19985E0 Offset: 0x19977E0 VA: 0x1819985E0 Slot: 24
	public IList<PlayerController.Button> get_buttons() { }

	// RVA: 0x19984B0 Offset: 0x19976B0 VA: 0x1819984B0 Slot: 25
	public IList<PlayerController.Axis> get_axes() { }

	// RVA: 0x19986B0 Offset: 0x19978B0 VA: 0x1819986B0 Slot: 26
	public IList<PlayerController.Element> get_elements() { }

	// RVA: 0x1998580 Offset: 0x1997780 VA: 0x181998580 Slot: 27
	public int get_buttonCount() { }

	// RVA: 0x1998520 Offset: 0x1997720 VA: 0x181998520 Slot: 28
	public int get_axisCount() { }

	// RVA: 0x1998650 Offset: 0x1997850 VA: 0x181998650 Slot: 29
	public int get_elementCount() { }

	// RVA: 0x19983D0 Offset: 0x19975D0 VA: 0x1819983D0 Slot: 30
	public void add_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x19988C0 Offset: 0x1997AC0 VA: 0x1819988C0 Slot: 31
	public void remove_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x1998360 Offset: 0x1997560 VA: 0x181998360 Slot: 32
	public void add_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x1998850 Offset: 0x1997A50 VA: 0x181998850 Slot: 33
	public void remove_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x1998440 Offset: 0x1997640 VA: 0x181998440 Slot: 34
	public void add_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x1998930 Offset: 0x1997B30 VA: 0x181998930 Slot: 35
	public void remove_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x19976D0 Offset: 0x19968D0 VA: 0x1819976D0 Slot: 36
	public bool GetButton(int index) { }

	// RVA: 0x19975F0 Offset: 0x19967F0 VA: 0x1819975F0 Slot: 37
	public bool GetButtonDown(int index) { }

	// RVA: 0x1997660 Offset: 0x1996860 VA: 0x181997660 Slot: 38
	public bool GetButtonUp(int index) { }

	// RVA: 0x1997580 Offset: 0x1996780 VA: 0x181997580 Slot: 39
	public float GetAxis(int index) { }

	// RVA: 0x1997510 Offset: 0x1996710 VA: 0x181997510 Slot: 40
	public float GetAxisRaw(int index) { }

	// RVA: 0x1997740 Offset: 0x1996940 VA: 0x181997740 Slot: 41
	public PlayerController.Element GetElement(int index) { }

	// RVA: -1 Offset: -1 Slot: 42
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59D70 Offset: 0xA58F70 VA: 0x180A59D70
	|-PlayerController.GetElement<object>
	*/

	// RVA: 0x1997940 Offset: 0x1996B40 VA: 0x181997940 Slot: 4
	protected override void OnAwake() { }

	// RVA: 0x19978E0 Offset: 0x1996AE0 VA: 0x1819978E0 Slot: 5
	protected override void OnAwakeFinished() { }

	// RVA: 0x1997AA0 Offset: 0x1996CA0 VA: 0x181997AA0 Slot: 7
	protected override void OnEnabled() { }

	// RVA: 0x19979C0 Offset: 0x1996BC0 VA: 0x1819979C0 Slot: 8
	protected override void OnDisabled() { }

	// RVA: 0x1997D40 Offset: 0x1996F40 VA: 0x181997D40 Slot: 11
	protected override void OnValidated() { }

	// RVA: 0x1997B80 Offset: 0x1996D80 VA: 0x181997B80 Slot: 10
	protected override void OnReset() { }

	// RVA: 0x1997F30 Offset: 0x1997130 VA: 0x181997F30 Slot: 18
	protected override void Subscribe() { }

	// RVA: 0x1998090 Offset: 0x1997290 VA: 0x181998090 Slot: 19
	protected override void Unsubscribe() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 15
	protected override object GetCreateSourceArgs() { }

	// RVA: 0x19971B0 Offset: 0x19963B0 VA: 0x1819971B0 Slot: 14
	protected override PlayerController CreateSource(object args) { }

	// RVA: 0x1998BA0 Offset: 0x1997DA0 VA: 0x181998BA0 Slot: 43
	internal virtual List<PlayerController.ElementInfo> xsLHusSoYGUZVpdlhuDWjWiIEXFc() { }

	// RVA: 0x1998780 Offset: 0x1997980 VA: 0x181998780
	private void pzKZoqVlqVAvocPbRQmdyRAEzvXHA(int , bool ) { }

	// RVA: 0x1997810 Offset: 0x1996A10 VA: 0x181997810
	private void OgkvOQvGJkmLynBGZKSSLhARBUjaA(int , float ) { }

	// RVA: 0x1998AF0 Offset: 0x1997CF0 VA: 0x181998AF0
	private void vXcgNvFxSWZSFUimNihqcnqDaBmgb(bool ) { }

	// RVA: 0x19977B0 Offset: 0x19969B0 VA: 0x1819977B0
	private void HQCrTJFGnLcfmBKvizENhilKGuyRA() { }

	// RVA: 0x19981F0 Offset: 0x19973F0 VA: 0x1819981F0
	public void .ctor() { }

	// RVA: 0x1997F10 Offset: 0x1997110 VA: 0x181997F10 Slot: 20
	private bool Rewired.IPlayerController.get_enabled() { }

	// RVA: 0x1997F20 Offset: 0x1997120 VA: 0x181997F20 Slot: 21
	private void Rewired.IPlayerController.set_enabled(bool value) { }
}

// Namespace: 
[Serializable]
public class PlayerMouse.ScreenPositionChangedHandler : UnityEvent<Vector2> // TypeDefIndex: 7660
{
	// Methods

	// RVA: 0x199D270 Offset: 0x199C470 VA: 0x18199D270
	public void .ctor() { }
}

// Namespace: Rewired.Components
[AddComponentMenu("Rewired/Player Controllers/Player Mouse")]
[Serializable]
public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 7661
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If enabled, the screen position will default to the center of the allowed movement area. Otherwise, it will default to the lower-left corner of the allowed movement area.")]
	private bool _defaultToCenter; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The pointer speed. This does not affect the speed of input from the mouse x/y axes if useHardwarePointerPosition is enabled. It only affects the speed from input sources other than mouse x/y or if mouse x/y are mapped to Actions assigned to Axes. ")]
	private float _pointerSpeed; // 0x64
	[CustomObfuscation(rename = False)]
	[Tooltip("If enabled, the hardware pointer position will be used for mouse input. Otherwise, the position of the pointer will be calculated only from the Axis Action values. The Player that owns this Player Mouse must have the physical mouse assigned to it in order for the hardware position to be used, ex: player.controllers.hasMouse == true.")]
	[SerializeField]
	private bool _useHardwarePointerPosition; // 0x68
	[SerializeField]
	[Tooltip("If enabled, movement will be clamped to the Movement Area.")]
	[CustomObfuscation(rename = False)]
	private bool _clampToMovementArea; // 0x69
	[Tooltip("The allowed movement area for the mouse pointer. Set Movement Area Unit to determine the data format of this value. This rect is a screen-space rect with 0, 0 at the lower-left corner.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Rect _movementArea; // 0x6C
	[Tooltip("The unit format of the movement area. This is used to determine the data format of Movement Area.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private PlayerMouse.MovementAreaUnit _movementAreaUnit; // 0x7C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Triggered when the screen position changes. Link this to your pointer to drive its position.")]
	private PlayerMouse.ScreenPositionChangedHandler _onScreenPositionChanged; // 0x80

	// Properties
	private PlayerMouse PKfQXIKSJfbcbHmkplZndVmtesxB { get; }
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

	// RVA: 0x199B5F0 Offset: 0x199A7F0 VA: 0x18199B5F0
	private PlayerMouse iTufQtFnOhgvwAiYastJRXQEsdJEb() { }

	// RVA: 0x199AD00 Offset: 0x1999F00 VA: 0x18199AD00 Slot: 44
	public bool get_defaultToCenter() { }

	// RVA: 0x199B820 Offset: 0x199AA20 VA: 0x18199B820
	public void set_defaultToCenter(bool value) { }

	// RVA: 0x199AC70 Offset: 0x1999E70 VA: 0x18199AC70
	public bool get_clampToMovementArea() { }

	// RVA: 0x199B6E0 Offset: 0x199A8E0 VA: 0x18199B6E0
	public void set_clampToMovementArea(bool value) { }

	// RVA: 0x199AF40 Offset: 0x199A140 VA: 0x18199AF40 Slot: 45
	public ScreenRect get_movementArea() { }

	// RVA: 0x199BAA0 Offset: 0x199ACA0 VA: 0x18199BAA0 Slot: 46
	public void set_movementArea(ScreenRect value) { }

	// RVA: 0x199AEB0 Offset: 0x199A0B0 VA: 0x18199AEB0 Slot: 47
	public PlayerMouse.MovementAreaUnit get_movementAreaUnit() { }

	// RVA: 0x199B960 Offset: 0x199AB60 VA: 0x18199B960 Slot: 48
	public void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value) { }

	// RVA: 0x199B2E0 Offset: 0x199A4E0 VA: 0x18199B2E0 Slot: 49
	public Vector2 get_screenPosition() { }

	// RVA: 0x199BE80 Offset: 0x199B080 VA: 0x18199BE80
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x199B210 Offset: 0x199A410 VA: 0x18199B210 Slot: 50
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x199B140 Offset: 0x199A340 VA: 0x18199B140 Slot: 51
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x199B4D0 Offset: 0x199A6D0 VA: 0x18199B4D0 Slot: 52
	public PlayerController.MouseAxis get_xAxis() { }

	// RVA: 0x199B560 Offset: 0x199A760 VA: 0x18199B560 Slot: 53
	public PlayerController.MouseAxis get_yAxis() { }

	// RVA: 0x199B440 Offset: 0x199A640 VA: 0x18199B440 Slot: 54
	public PlayerController.MouseWheel get_wheel() { }

	// RVA: 0x199AD90 Offset: 0x1999F90 VA: 0x18199AD90 Slot: 55
	public PlayerController.Button get_leftButton() { }

	// RVA: 0x199B0B0 Offset: 0x199A2B0 VA: 0x18199B0B0 Slot: 56
	public PlayerController.Button get_rightButton() { }

	// RVA: 0x199AE20 Offset: 0x199A020 VA: 0x18199AE20 Slot: 57
	public PlayerController.Button get_middleButton() { }

	// RVA: 0x199B020 Offset: 0x199A220 VA: 0x18199B020 Slot: 58
	public float get_pointerSpeed() { }

	// RVA: 0x199BD60 Offset: 0x199AF60 VA: 0x18199BD60
	public void set_pointerSpeed(float value) { }

	// RVA: 0x199B3B0 Offset: 0x199A5B0 VA: 0x18199B3B0 Slot: 59
	public bool get_useHardwarePointerPosition() { }

	// RVA: 0x199BF50 Offset: 0x199B150 VA: 0x18199BF50
	public void set_useHardwarePointerPosition(bool value) { }

	// RVA: 0x199AAE0 Offset: 0x1999CE0 VA: 0x18199AAE0 Slot: 60
	public void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x199B640 Offset: 0x199A840 VA: 0x18199B640 Slot: 61
	public void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x1999910 Offset: 0x1998B10 VA: 0x181999910 Slot: 11
	protected override void OnValidated() { }

	// RVA: 0x19996D0 Offset: 0x19988D0 VA: 0x1819996D0 Slot: 10
	protected override void OnReset() { }

	// RVA: 0x1999260 Offset: 0x1998460 VA: 0x181999260 Slot: 14
	protected override PlayerController CreateSource(object args) { }

	// RVA: 0x1999690 Offset: 0x1998890 VA: 0x181999690 Slot: 17
	protected override void Deinitialize() { }

	// RVA: 0x199A460 Offset: 0x1999660 VA: 0x18199A460 Slot: 18
	protected override void Subscribe() { }

	// RVA: 0x199A6B0 Offset: 0x19998B0 VA: 0x18199A6B0 Slot: 19
	protected override void Unsubscribe() { }

	// RVA: 0x199BFF0 Offset: 0x199B1F0 VA: 0x18199BFF0 Slot: 43
	internal override List<PlayerController.ElementInfo> xsLHusSoYGUZVpdlhuDWjWiIEXFc() { }

	// RVA: 0x199AB80 Offset: 0x1999D80 VA: 0x18199AB80
	private void gboCrJgIyOyuaTOVxYRzcNeVAAJlA(Vector2 ) { }

	// RVA: 0x199A060 Offset: 0x1999260 VA: 0x18199A060 Slot: 63
	private bool Rewired.UI.IMouseInputSource.get_enabled() { }

	// RVA: 0x1999E20 Offset: 0x1999020 VA: 0x181999E20 Slot: 66
	private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	// RVA: 0x1999EE0 Offset: 0x19990E0 VA: 0x181999EE0 Slot: 67
	private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	// RVA: 0x1999FA0 Offset: 0x19991A0 VA: 0x181999FA0 Slot: 68
	private bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	// RVA: 0x199A2A0 Offset: 0x19994A0 VA: 0x18199A2A0 Slot: 69
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	// RVA: 0x199A1C0 Offset: 0x19993C0 VA: 0x18199A1C0 Slot: 70
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	// RVA: 0x199A380 Offset: 0x1999580 VA: 0x18199A380 Slot: 71
	private Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	// RVA: 0x199A110 Offset: 0x1999310 VA: 0x18199A110 Slot: 64
	private bool Rewired.UI.IMouseInputSource.get_locked() { }

	// RVA: 0x199A900 Offset: 0x1999B00 VA: 0x18199A900
	public void .ctor() { }

	// RVA: 0x1997F10 Offset: 0x1997110 VA: 0x181997F10 Slot: 20
	private bool Rewired.IPlayerController.get_enabled() { }

	// RVA: 0x1997F20 Offset: 0x1997120 VA: 0x181997F20 Slot: 21
	private void Rewired.IPlayerController.set_enabled(bool value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ComponentControl.lDGoZfWTjuEXZibKjRDuuKOZdUVu : IDisposable, IEnumerator, IEnumerator<object> // TypeDefIndex: 7662
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private object lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	public ComponentControl nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19B0260 Offset: 0x19AF460 VA: 0x1819B0260 Slot: 5
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19B0300 Offset: 0x19AF500 VA: 0x1819B0300 Slot: 7
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class ComponentControl : MonoBehaviour, IComponentControl // TypeDefIndex: 7663
{
	// Fields
	private IComponentController _controller; // 0x20
	private bool MAvCDWNDMJjDwBKVWzYzOlRqXElo; // 0x28
	private bool xFXiMMAbAuldJlCmiuSmFpwOpBrv; // 0x29
	private int _lastUpdateFrame; // 0x2C

	// Properties
	internal abstract bool SwQbzDXeDznizSNPahbkHtgLQlDK { get; }
	internal bool DzRdwaCjMKOeYXXRtYawwePnAsSb { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool ToAHsOILAjRmHnrFpebmtqzeeiCM();

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool KOOpAAkkVoVziizIEyDjenhNJeKj() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19916A0 Offset: 0x19908A0 VA: 0x1819916A0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearValue();

	// RVA: 0x19915C0 Offset: 0x19907C0 VA: 0x1819915C0 Slot: 4
	private void Rewired.ComponentControls.IComponentControl.Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x841460 Offset: 0x840660 VA: 0x180841460 Slot: 8
	internal virtual void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	internal virtual void Start() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991340 Offset: 0x1990540 VA: 0x181991340 Slot: 10
	internal virtual void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19912D0 Offset: 0x19904D0 VA: 0x1819912D0 Slot: 11
	internal virtual void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	internal virtual void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991400 Offset: 0x1990600 VA: 0x181991400 Slot: 13
	internal virtual void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19912B0 Offset: 0x19904B0 VA: 0x1819912B0 Slot: 14
	internal virtual void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19912B0 Offset: 0x19904B0 VA: 0x1819912B0 Slot: 15
	internal virtual void OnTransformParentChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	internal virtual void OnDidApplyAnimationProperties() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	internal virtual void Reset() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	internal virtual void rXMSMoptVBXwmLIisXpGDWxMCQSj() { }

	// RVA: 0x19911E0 Offset: 0x19903E0 VA: 0x1819911E0 Slot: 19
	internal virtual bool HOADMXDSIKPbaWvQBkjbeSSAZQOA() { }

	// RVA: 0x1991150 Offset: 0x1990350 VA: 0x181991150 Slot: 20
	internal virtual void FWzIgmRqWffQefMLOsDIALhdhKBi() { }

	// RVA: 0x1991600 Offset: 0x1990800 VA: 0x181991600 Slot: 21
	internal virtual void STULutWxOEHoHzqYQUohfeNuZecI() { }

	// RVA: 0x1991750 Offset: 0x1990950 VA: 0x181991750 Slot: 22
	internal virtual void xYbPtIzhXYnWgYnUNhqxAQzmdtbBA() { }

	// RVA: 0x1991400 Offset: 0x1990600 VA: 0x181991400 Slot: 23
	internal virtual void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	internal virtual void BRIyzNalTCnxRlabbdpIqYFymIkt() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	internal virtual void eWUqONFuRLLhbwOudhpupUfOdxox() { }

	// RVA: 0x19916B0 Offset: 0x19908B0 VA: 0x1819916B0
	internal bool guyOsmenYiCiKiYvcpXYWCjnMBbX() { }

	// RVA: 0x1991700 Offset: 0x1990900 VA: 0x181991700
	internal bool hBUhfwdnrGYVEGentXphTMVUDMhh() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IComponentController UsdYqXJJnOSjqFIiixxKwhVdDFOn() { }

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 26
	internal abstract IComponentController FindController();

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 27
	internal abstract Type GetRequiredControllerType();

	// RVA: 0x1991640 Offset: 0x1990840 VA: 0x181991640
	private IEnumerator TwxIFLwnsJgOvYlCQRMeqhHGvFAK() { }

	// RVA: 0x1991250 Offset: 0x1990450 VA: 0x181991250
	private void IesMdeSxLxTMMieIuttmAIlSfLUb() { }

	// RVA: 0x1991420 Offset: 0x1990620 VA: 0x181991420
	private bool PvPavqXeimTHRSMqOarRnlRqXjKt(bool , bool ) { }

	// RVA: 0x1991140 Offset: 0x1990340 VA: 0x181991140
	private void ETaWHvEdTdbkgezzvzTnawlHVBHz() { }

	// RVA: 0x1991090 Offset: 0x1990290 VA: 0x181991090
	private void AoqrJgxcAdGiYfYBSXpdMXqupPEv() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ComponentController.vLmBOMHwTjiefIkvjDBJgAvRXWeXA : IDisposable, IEnumerator, IEnumerator<object> // TypeDefIndex: 7664
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private object lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	public ComponentController nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19B0630 Offset: 0x19AF830 VA: 0x1819B0630 Slot: 5
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19B06C0 Offset: 0x19AF8C0 VA: 0x1819B06C0 Slot: 7
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class ComponentController : MonoBehaviour, IRegistrar<IComponentControl>, IComponentController // TypeDefIndex: 7665
{
	// Fields
	private bool MAvCDWNDMJjDwBKVWzYzOlRqXElo; // 0x20
	private bool xFXiMMAbAuldJlCmiuSmFpwOpBrv; // 0x21
	private List<IComponentControl> _controls; // 0x28

	// Properties
	internal bool DzRdwaCjMKOeYXXRtYawwePnAsSb { get; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	internal bool KOOpAAkkVoVziizIEyDjenhNJeKj() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991C00 Offset: 0x1990E00 VA: 0x181991C00
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991760 Offset: 0x1990960 VA: 0x181991760 Slot: 7
	internal virtual void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991B10 Offset: 0x1990D10 VA: 0x181991B10 Slot: 8
	internal virtual void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991930 Offset: 0x1990B30 VA: 0x181991930 Slot: 9
	internal virtual void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991910 Offset: 0x1990B10 VA: 0x181991910 Slot: 10
	internal virtual void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080 Slot: 11
	internal virtual void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19918B0 Offset: 0x1990AB0 VA: 0x1819918B0 Slot: 12
	internal virtual void OnDestroy() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 13
	internal virtual bool HOADMXDSIKPbaWvQBkjbeSSAZQOA() { }

	// RVA: 0x727AE0 Offset: 0x726CE0 VA: 0x180727AE0 Slot: 14
	internal virtual void STULutWxOEHoHzqYQUohfeNuZecI() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	internal virtual void xYbPtIzhXYnWgYnUNhqxAQzmdtbBA() { }

	// RVA: 0x1991AB0 Offset: 0x1990CB0 VA: 0x181991AB0 Slot: 4
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.IComponentControl>.Register(IComponentControl control) { }

	// RVA: 0x1991A40 Offset: 0x1990C40 VA: 0x181991A40 Slot: 5
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.IComponentControl>.Deregister(IComponentControl control) { }

	// RVA: 0x1991770 Offset: 0x1990970 VA: 0x181991770 Slot: 16
	public virtual void ClearControlValues() { }

	// RVA: 0x1991860 Offset: 0x1990A60 VA: 0x181991860
	private void IesMdeSxLxTMMieIuttmAIlSfLUb() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	// RVA: 0x19919E0 Offset: 0x1990BE0 VA: 0x1819919E0
	private IEnumerator RDcIWBiZoVzPdgToqXruTTxGNzgXA() { }
}

// Namespace: 
[Serializable]
public class CustomController.CreateCustomControllerSettings // TypeDefIndex: 7666
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If true, a new Custom Controller will be created. Otherwise, an existing Custom Controller will be found using the selector properties.")]
	private bool _createCustomController; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("The source id of the Custom Controller to create. Get this from the Rewired Input Manager.")]
	private int _customControllerSourceId; // 0x14
	[SerializeField]
	[Tooltip("The Player that will be assigned this Custom Controller when it is created.")]
	[CustomObfuscation(rename = False)]
	private int _assignToPlayerId; // 0x18
	[CustomObfuscation(rename = False)]
	[Tooltip("If true, the Custom Controller created by this component will be destroyed when this component is destroyed.")]
	[SerializeField]
	private bool _destroyCustomController; // 0x1C

	// Properties
	public bool createCustomController { get; set; }
	public int customControllerSourceId { get; set; }
	public int assignToPlayerId { get; set; }
	public bool destroyCustomController { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_createCustomController() { }

	// RVA: 0x1991C90 Offset: 0x1990E90 VA: 0x181991C90
	public void set_createCustomController(bool value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_customControllerSourceId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_customControllerSourceId(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_assignToPlayerId() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_assignToPlayerId(int value) { }

	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_destroyCustomController() { }

	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_destroyCustomController(bool value) { }

	// RVA: 0x1991C70 Offset: 0x1990E70 VA: 0x181991C70
	public void .ctor() { }
}

// Namespace: 
private struct CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM // TypeDefIndex: 7667
{
	// Fields
	public CustomControllerElementSelector.ElementType sKjCmMOLFxixaCQzRKUpvBFTerKeA; // 0x0
	public int TKZalybUaRqgoSjFAeepWEAqPOKSA; // 0x4
	public float CdEckvrVAeswSaQCfMLbUlJjpTfR; // 0x8

	// Methods

	// RVA: 0x1991040 Offset: 0x1990240 VA: 0x181991040
	public void .ctor(CustomControllerElementSelector.ElementType , int , float ) { }

	// RVA: 0x1991050 Offset: 0x1990250 VA: 0x181991050
	public void .ctor(CustomControllerElementSelector.ElementType , int , bool ) { }

	// RVA: 0x1991080 Offset: 0x1990280 VA: 0x181991080
	public bool mDJHwzffnXFYdhBPQgKgzvxiMAhC(CustomControllerElementSelector.ElementType , int ) { }

	// RVA: 0x1991000 Offset: 0x1990200 VA: 0x181991000
	public void OHHKRTZeYyrfezGsSkGnOKYMDupr(float ) { }

	// RVA: 0x1991030 Offset: 0x1990230 VA: 0x181991030
	public void OHHKRTZeYyrfezGsSkGnOKYMDupr(bool ) { }
}

// Namespace: Rewired.ComponentControls
[AddComponentMenu("Rewired/Component Controls/Custom Controller")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[DisallowMultipleComponent]
[Serializable]
public class CustomController : ComponentController // TypeDefIndex: 7668
{
	// Fields
	[CustomObfuscation(rename = False)]
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Custom Controller elements, etc.")]
	[SerializeField]
	private InputManager_Base _rewiredInputManager; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Contains search parameters to find a particular Custom Controller.")]
	private CustomControllerSelector _customControllerSelector; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings for creating a Custom Controller on start.")]
	private CustomController.CreateCustomControllerSettings _createCustomControllerSettings; // 0x40
	private List<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM> SghJpfdYFbrinmDdUCKJHlHTRuclA; // 0x48
	private int heZcpUHJqWhliirxGfNBhfXXrqmT; // 0x50
	private Action hWMNBVBtAFIQztUMZdGIvwzcejSX; // 0x58

	// Properties
	public InputManager_Base rewiredInputManager { get; set; }
	public CustomControllerSelector customControllerSelector { get; }
	public CustomController.CreateCustomControllerSettings createCustomControllerSettings { get; }

	// Methods

	// RVA: 0x19940C0 Offset: 0x19932C0 VA: 0x1819940C0
	internal void add_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x1994480 Offset: 0x1993680 VA: 0x181994480
	internal void remove_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public InputManager_Base get_rewiredInputManager() { }

	// RVA: 0x1994520 Offset: 0x1993720 VA: 0x181994520
	public void set_rewiredInputManager(InputManager_Base value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public CustomControllerSelector get_customControllerSelector() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public CustomController.CreateCustomControllerSettings get_createCustomControllerSettings() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1993F90 Offset: 0x1993190 VA: 0x181993F90
	internal void .ctor() { }

	// RVA: 0x1992DC0 Offset: 0x1991FC0 VA: 0x181992DC0
	public CustomController GetCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991930 Offset: 0x1990B30 VA: 0x181991930 Slot: 9
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1993090 Offset: 0x1992290 VA: 0x181993090 Slot: 10
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19933C0 Offset: 0x19925C0 VA: 0x1819933C0 Slot: 11
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1992F80 Offset: 0x1992180 VA: 0x181992F80 Slot: 12
	internal override void OnDestroy() { }

	// RVA: 0x1993100 Offset: 0x1992300 VA: 0x181993100 Slot: 13
	internal override bool OnInitialize() { }

	// RVA: 0x1993210 Offset: 0x1992410 VA: 0x181993210 Slot: 14
	internal override void OnSubscribeEvents() { }

	// RVA: 0x1993330 Offset: 0x1992530 VA: 0x181993330 Slot: 15
	internal override void OnUnsubscribeEvents() { }

	// RVA: 0x19926F0 Offset: 0x19918F0 VA: 0x1819926F0 Slot: 16
	public override void ClearControlValues() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	internal virtual bool GetUseCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	internal virtual void SetUseCustomController(bool value) { }

	// RVA: 0x1993660 Offset: 0x1992860 VA: 0x181993660
	internal void SetAxisValue(CustomControllerElementSelector element, float value) { }

	// RVA: 0x1993840 Offset: 0x1992A40 VA: 0x181993840
	internal void SetButtonValue(CustomControllerElementSelector element, bool value) { }

	// RVA: 0x1992820 Offset: 0x1991A20 VA: 0x181992820
	internal void ClearElementValue(CustomControllerElementTargetSet targetSet) { }

	// RVA: 0x1992A50 Offset: 0x1991C50 VA: 0x181992A50
	internal void ClearElementValue(CustomControllerElementTarget target) { }

	// RVA: 0x19928B0 Offset: 0x1991AB0 VA: 0x1819928B0
	internal void ClearElementValue(CustomControllerElementSelector element) { }

	// RVA: 0x1992A70 Offset: 0x1991C70 VA: 0x181992A70
	internal int ElementExists_Editor(CustomControllerElementSelector element) { }

	// RVA: 0x1992CA0 Offset: 0x1991EA0 VA: 0x181992CA0
	internal bool ElementExists(CustomControllerElementSelector element) { }

	// RVA: 0x1993D70 Offset: 0x1992F70 VA: 0x181993D70
	internal bool ValidateElements(CustomControllerElementTargetSet targetSet) { }

	// RVA: 0x1993A20 Offset: 0x1992C20 VA: 0x181993A20
	internal bool ValidateElement(CustomControllerElementTarget target) { }

	// RVA: 0x1993BD0 Offset: 0x1992DD0 VA: 0x181993BD0
	internal bool ValidateElement(CustomControllerElementSelector element) { }

	// RVA: 0x19945D0 Offset: 0x19937D0 VA: 0x1819945D0
	private void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	// RVA: 0x1992CF0 Offset: 0x1991EF0 VA: 0x181992CF0
	private bool EmtLIEDumaucPbcKuRCQnTgOOsfS() { }

	// RVA: 0x19934D0 Offset: 0x19926D0 VA: 0x1819934D0
	private void QdeeDBFQInJlflBFXDtixBmejBfSA() { }

	// RVA: 0x1994160 Offset: 0x1993360 VA: 0x181994160
	private CustomController oTXHdbxlmGrPUeaGIQdnLRaRhAul(bool ) { }

	// RVA: 0x1993E20 Offset: 0x1993020 VA: 0x181993E20
	private void ZqLTanWPDFulydFGtxITyzcNIQh(CustomController ) { }

	// RVA: 0x1993410 Offset: 0x1992610 VA: 0x181993410
	private void QKbKkOTaQwkFImGCICIhjbMVThcdA() { }

	// RVA: 0x1992DD0 Offset: 0x1991FD0 VA: 0x181992DD0
	private void MOgemXBYXBEFdsnaSgLIapiASYgtB() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[Serializable]
public abstract class CustomControllerControl : ComponentControl // TypeDefIndex: 7669
{
	// Properties
	internal CustomController oucSTTgcWofhafDPqHrFgmhNLXuaA { get; }
	internal override bool SwQbzDXeDznizSNPahbkHtgLQlDK { get; }

	// Methods

	// RVA: 0x1992670 Offset: 0x1991870 VA: 0x181992670
	internal CustomController yxEyCIpUtBgiGHlVBoscpSEAZOOk() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19916A0 Offset: 0x19908A0 VA: 0x1819916A0
	internal void .ctor() { }

	// RVA: 0x1991F80 Offset: 0x1991180 VA: 0x181991F80 Slot: 6
	internal override bool ToAHsOILAjRmHnrFpebmtqzeeiCM() { }

	// RVA: 0x1991E20 Offset: 0x1991020 VA: 0x181991E20 Slot: 21
	internal override void STULutWxOEHoHzqYQUohfeNuZecI() { }

	// RVA: 0x1992540 Offset: 0x1991740 VA: 0x181992540 Slot: 22
	internal override void xYbPtIzhXYnWgYnUNhqxAQzmdtbBA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991CA0 Offset: 0x1990EA0 VA: 0x181991CA0 Slot: 26
	internal override IComponentController FindController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1991D10 Offset: 0x1990F10 VA: 0x181991D10 Slot: 27
	internal override Type GetRequiredControllerType() { }

	// RVA: 0x1992270 Offset: 0x1991470 VA: 0x181992270
	internal void oHZPjESBnpAZzhJHpgbPmrJyHJETA(CustomControllerElementTargetSet , float , float ) { }

	// RVA: 0x1992130 Offset: 0x1991330 VA: 0x181992130
	internal void oHZPjESBnpAZzhJHpgbPmrJyHJETA(CustomControllerElementTargetSet , bool ) { }

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract void HeHSYRTmzCIiZhqcJZIhuGoQDhSj();

	// RVA: 0x19923D0 Offset: 0x19915D0 VA: 0x1819923D0
	private void oHZPjESBnpAZzhJHpgbPmrJyHJETA(CustomControllerElementTarget , float , float ) { }

	// RVA: 0x1992020 Offset: 0x1991220 VA: 0x181992020
	private void oHZPjESBnpAZzhJHpgbPmrJyHJETA(CustomControllerElementTarget , bool ) { }

	// RVA: 0x1991D70 Offset: 0x1990F70 VA: 0x181991D70
	private void MOgemXBYXBEFdsnaSgLIapiASYgtB() { }
}

// Namespace: Rewired.ComponentControls
public interface IComponentControl // TypeDefIndex: 7670
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ClearValue();
}

// Namespace: Rewired.ComponentControls
public interface IComponentController : IRegistrar<IComponentControl> // TypeDefIndex: 7671
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ClearControlValues();
}

// Namespace: 
public enum TiltControl.TiltDirection // TypeDefIndex: 7672
{
	// Fields
	public int value__; // 0x0
	public const TiltControl.TiltDirection Both = 0;
	public const TiltControl.TiltDirection Horizontal = 1;
	public const TiltControl.TiltDirection Forward = 2;
}

// Namespace: Rewired.ComponentControls
[AddComponentMenu("Rewired/Component Controls/Tilt Control")]
[DisallowMultipleComponent]
[Serializable]
public sealed class TiltControl : CustomControllerControl // TypeDefIndex: 7673
{
	// Fields
	private const float maxFullTiltAngle = 180;
	private const float maxAngleOffset = 90;
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The tilt directions in which movement is allowed. You can restrict movement to one or both directions.")]
	private TiltControl.TiltDirection _allowedTiltDirections; // 0x30
	[Tooltip("The Custom Controller element that will receive input values from the X axis.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; // 0x38
	[CustomObfuscation(rename = False)]
	[Range(0, 180)]
	[SerializeField]
	[Tooltip("The maximum horizontal tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
	private float _horizontalTiltLimit; // 0x40
	[Range(-90, 90)]
	[SerializeField]
	[Tooltip("The offset angle from horizontal which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt.")]
	[CustomObfuscation(rename = False)]
	private float _horizontalRestAngle; // 0x44
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Custom Controller element that will receive input values from the Y axis.")]
	private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; // 0x48
	[Tooltip("The maximum forward tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
	[Range(0, 180)]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _forwardTiltLimit; // 0x50
	[Range(-90, 90)]
	[SerializeField]
	[Tooltip("The offset angle from vertical which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt. A typical value would be around 40 degrees.")]
	[CustomObfuscation(rename = False)]
	private float _forwardRestAngle; // 0x54
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The underlying 2D axis.")]
	private StandaloneAxis2D _axis2D; // 0x58
	private bool _useHAxis; // 0x60
	private bool _useFAxis; // 0x61
	private Func<Vector3> _getAccelerationValue; // 0x68

	// Properties
	public TiltControl.TiltDirection axesToUse { get; set; }
	public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement { get; }
	public float horizontalTiltLimit { get; set; }
	public float horizontalRestAngle { get; set; }
	public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement { get; }
	public float forwardTiltLimit { get; set; }
	public float forwardRestAngle { get; set; }
	public AxisCalibration horizontalAxisCalibration { get; }
	public AxisCalibration verticalAxisCalibration { get; }
	[Obsolete("Use axis2DCalibration instead.", False)]
	public Axis2DCalibration deadZoneType { get; }
	public Axis2DCalibration axis2DCalibration { get; }
	internal StandaloneAxis2D qJPTnOxGtIfzUwfesgYdPjioFarg { get; }
	private Vector3 GhEsSNRTVnBhDTEHoUTycEaDlVyb { get; }

	// Methods

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public TiltControl.TiltDirection get_axesToUse() { }

	// RVA: 0x199F700 Offset: 0x199E900 VA: 0x18199F700
	public void set_axesToUse(TiltControl.TiltDirection value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public CustomControllerElementTargetSetForFloat get_horizontalTiltCustomControllerElement() { }

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float get_horizontalTiltLimit() { }

	// RVA: 0x199F860 Offset: 0x199EA60 VA: 0x18199F860
	public void set_horizontalTiltLimit(float value) { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float get_horizontalRestAngle() { }

	// RVA: 0x199F800 Offset: 0x199EA00 VA: 0x18199F800
	public void set_horizontalRestAngle(float value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public CustomControllerElementTargetSetForFloat get_forwardTiltCustomControllerElement() { }

	// RVA: 0x646040 Offset: 0x645240 VA: 0x180646040
	public float get_forwardTiltLimit() { }

	// RVA: 0x199F7A0 Offset: 0x199E9A0 VA: 0x18199F7A0
	public void set_forwardTiltLimit(float value) { }

	// RVA: 0x6D7290 Offset: 0x6D6490 VA: 0x1806D7290
	public float get_forwardRestAngle() { }

	// RVA: 0x199F740 Offset: 0x199E940 VA: 0x18199F740
	public void set_forwardRestAngle(float value) { }

	// RVA: 0x199F1F0 Offset: 0x199E3F0 VA: 0x18199F1F0
	public AxisCalibration get_horizontalAxisCalibration() { }

	// RVA: 0x199F220 Offset: 0x199E420 VA: 0x18199F220
	public AxisCalibration get_verticalAxisCalibration() { }

	// RVA: 0x1885690 Offset: 0x1884890 VA: 0x181885690
	public Axis2DCalibration get_deadZoneType() { }

	// RVA: 0x1885690 Offset: 0x1884890 VA: 0x181885690
	public Axis2DCalibration get_axis2DCalibration() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal StandaloneAxis2D KZWKHZlwZgsjSBcTOPbfZYywOFpF() { }

	// RVA: 0x199EEE0 Offset: 0x199E0E0 VA: 0x18199EEE0
	private Vector3 OQPGqiKUWseeZfLbdZeQcRncexnL() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x199F130 Offset: 0x199E330 VA: 0x18199F130
	internal void .ctor() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void SetAccelerationSourceCallback(Func<Vector3> callback) { }

	// RVA: 0x199EF70 Offset: 0x199E170 VA: 0x18199EF70
	public void SetRestOrientation() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x199EF30 Offset: 0x199E130 VA: 0x18199EF30 Slot: 13
	internal override void OnValidate() { }

	// RVA: 0x199ED60 Offset: 0x199DF60 VA: 0x18199ED60 Slot: 19
	internal override bool HOADMXDSIKPbaWvQBkjbeSSAZQOA() { }

	// RVA: 0x199F6F0 Offset: 0x199E8F0 VA: 0x18199F6F0 Slot: 18
	internal override void rXMSMoptVBXwmLIisXpGDWxMCQSj() { }

	// RVA: 0x199EDE0 Offset: 0x199DFE0 VA: 0x18199EDE0 Slot: 28
	internal override void HeHSYRTmzCIiZhqcJZIhuGoQDhSj() { }

	// RVA: 0x199EBD0 Offset: 0x199DDD0 VA: 0x18199EBD0 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x199F330 Offset: 0x199E530 VA: 0x18199F330
	private void nxNPCXvWspQJKrSDvXwopYMHZYF() { }

	// RVA: 0x199F0A0 Offset: 0x199E2A0 VA: 0x18199F0A0
	private void ZjrVMhYnSYGBvBECJqglUXtZxfDwA() { }

	// RVA: 0x199F250 Offset: 0x199E450 VA: 0x18199F250
	private void kEZUskAdOCECmlXAXuXKZFSWLacy(TiltControl.TiltDirection ) { }
}

// Namespace: 
public enum TouchButton.ButtonType // TypeDefIndex: 7674
{
	// Fields
	public int value__; // 0x0
	public const TouchButton.ButtonType Standard = 0;
	public const TouchButton.ButtonType ToggleSwitch = 1;
}

// Namespace: 
private enum TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA // TypeDefIndex: 7675
{
	// Fields
	public int value__; // 0x0
	public const TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA None = 0;
	public const TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA TowardTouch = 1;
	public const TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA TowardHome = 2;
}

// Namespace: 
private enum TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM // TypeDefIndex: 7676
{
	// Fields
	public int value__; // 0x0
	public const TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM Local = 0;
	public const TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM TouchRegion = 1;
}

// Namespace: 
[Serializable]
public class TouchButton.AxisValueChangedEventHandler : UnityEvent<float> // TypeDefIndex: 7677
{
	// Methods

	// RVA: 0x1990EF0 Offset: 0x19900F0 VA: 0x181990EF0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchButton.ButtonValueChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 7678
{
	// Methods

	// RVA: 0x1990FC0 Offset: 0x19901C0 VA: 0x181990FC0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchButton.ButtonDownEventHandler : UnityEvent // TypeDefIndex: 7679
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchButton.ButtonUpEventHandler : UnityEvent // TypeDefIndex: 7680
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TouchButton.mAwQicrkQYfttWvsmwitlkgNfuKS : IDisposable, IEnumerator, IEnumerator<object> // TypeDefIndex: 7681
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private object lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	public float cZcXfaUQLSdMNuidSVChlgzDfnAE; // 0x20
	public TouchButton nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	public PositionType hLfllIxvLGOWIZQndcDlgQJUkIrx; // 0x30
	public Vector2 jSWaRiCCRwgdGDjHddfdiuAcbJzN; // 0x34
	public TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA EvsVLcIsjNETCbeSPuRlIASCqdUjb; // 0x3C
	private RectTransform ZsIUjiyMobckrfLfTldCSpbqwPOlA; // 0x40
	private Vector2 iMOPMHxLfwiMSsWitjFiivdSclIF; // 0x48
	private float mxCSqadedlIsKVcoertqSoZuYckr; // 0x50
	private float KTYHOMPpSJTbFoAKKyUngqWLWxXV; // 0x54

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19B0340 Offset: 0x19AF540 VA: 0x1819B0340 Slot: 5
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19B05B0 Offset: 0x19AF7B0 VA: 0x1819B05B0 Slot: 7
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.ComponentControls
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Button")]
[Serializable]
public sealed class TouchButton : TouchInteractable // TypeDefIndex: 7682
{
	// Fields
	private const float ymQdzidJPnHJCbobXwnwgnSUpiLU = 20;
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Custom Controller element that will receive input values from this control.")]
	private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; // 0x130
	[CustomObfuscation(rename = False)]
	[Tooltip("The type of button.
Standard: A momentary switch. Returns True while the button is pressed down.
Toggle Switch: Alternately turns on and off with each press.")]
	[SerializeField]
	private TouchButton.ButtonType _buttonType; // 0x138
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If true, the button can be turned on by a touch swipe that began in an area outside the button region. If false, the button can only be turned on by a direct press.")]
	private bool _activateOnSwipeIn; // 0x13C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If true, the button will stay on even if the touch that activated it moves outside the button region. If false, the button will turn off once the touch that activated it moves outside the button region.")]
	private bool _stayActiveOnSwipeOut; // 0x13D
	[Tooltip("Makes the axis value gradually change over time based on gravity and sensitivity as the button is pressed.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useDigitalAxisSimulation; // 0x13E
	[Tooltip("Speed (units/sec) that the axis value falls toward 0 when not pressed. A value of 1.0 means an axis value of 1 will drain to 0 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
	[FieldRange(0, ∞)]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _digitalAxisGravity; // 0x140
	[CustomObfuscation(rename = False)]
	[FieldRange(0, ∞)]
	[SerializeField]
	[Tooltip("Speed to move toward an axis value of 1.0 in units/sec when pressed. A value of 1.0 means an axis value of 0 will reach 1 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
	private float _digitalAxisSensitivity; // 0x144
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The internal axis of the button. The axis is used for all value calculations.")]
	private StandaloneAxis _axis; // 0x148
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the button's RectTransform. This can be useful if you want a larger area of the screen to act as a button.")]
	private TouchRegion _touchRegion; // 0x150
	[Tooltip("If True, hovers/clicks/touches on the local button will be ignored and only Touch Region touches will be used. Otherwise, both touches on the button and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useTouchRegionOnly; // 0x158
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If True, the button will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a button and have the button graphics follow the users touches. This only has an effect if a Touch Region is set.")]
	private bool _moveToTouchPosition; // 0x159
	[Tooltip("If Move To Touch Position is enabled, this will make the button return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _returnOnRelease; // 0x15A
	[SerializeField]
	[Tooltip("If True, the button will follow the touch around until released. This setting overrides Move To Touch Position.")]
	[CustomObfuscation(rename = False)]
	private bool _followTouchPosition; // 0x15B
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Should the button animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	private bool _animateOnMoveToTouch; // 0x15C
	[Tooltip("The speed at which the button will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[Range(0, 20)]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _moveToTouchSpeed; // 0x160
	[Tooltip("Should the button animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _animateOnReturn; // 0x164
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	[Tooltip("The speed at which the button will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
	private float _returnSpeed; // 0x168
	[CustomObfuscation(rename = False)]
	[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
	[SerializeField]
	private bool _manageRaycasting; // 0x16C
	private float opiYzkPBfbgRZzirnmvslqRAmGuS; // 0x170
	private float pOGuOaqEyGJweyIpkeWrZVGAhsdk; // 0x174
	private TouchRegion bIONhtcTzUGDWzSEmtoyEQlHDIYDA; // 0x178
	private Vector2 TeiOLawaBxnhZzqVLOBxGGeYIxVz; // 0x180
	private bool FKKOSGvStAICUBIKZaWJNhuqZhLp; // 0x188
	private bool IreWhhAQpVSzMHbtOOGPAsoJoIef; // 0x189
	private TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA YMoFlKHxDlckIWAkkNZpZqBdsEko; // 0x18C
	private int URKCjxklQYfRmqzvWaorEvVRRAXF; // 0x190
	private int bsOYSBePPMEpvDfBuaKVqkEhajUr; // 0x194
	private bool eZThheVBDPbmBrDNEpgunwPUMELi; // 0x198
	private bool DYRrDmWzJNeoXkaUDrhKmWzPmQdE; // 0x199
	private IEnumerator tZqSIRBmaennOmhaOCvZLYaEkjhq; // 0x1A0
	private GyARYZsrnhudYCZNzjVwfKSYjxyf bcgiyRekHnpbMdoovACFGlGdFGwyB; // 0x1A8
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> RjAkGzbouKphKNlxDfacnmnaPmzf; // 0x1B0
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> gJLYoyyyHHhOztHrlbCNBIaZpqAD; // 0x1B8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when the axis value changes.")]
	private TouchButton.AxisValueChangedEventHandler _onAxisValueChanged; // 0x1C0
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when the button value changes.")]
	[SerializeField]
	private TouchButton.ButtonValueChangedEventHandler _onButtonValueChanged; // 0x1C8
	[Tooltip("Event sent when the button is pressed.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonDownEventHandler _onButtonDown; // 0x1D0
	[Tooltip("Event sent when the button is released.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchButton.ButtonUpEventHandler _onButtonUp; // 0x1D8
	private Dictionary<int, PointerEventData> oUBgDdCtztLMZHnykGfefLUoUjsx; // 0x1E0

	// Properties
	public CustomControllerElementTargetSetForFloat targetCustomControllerElement { get; }
	public TouchButton.ButtonType buttonType { get; set; }
	public bool activateOnSwipeIn { get; set; }
	public bool stayActiveOnSwipeOut { get; set; }
	public bool useDigitalAxisSimulation { get; set; }
	public float digitalAxisGravity { get; set; }
	public float digitalAxisSensitivity { get; set; }
	public TouchRegion touchRegion { get; set; }
	public bool useTouchRegionOnly { get; set; }
	public bool moveToTouchPosition { get; set; }
	public bool returnOnRelease { get; set; }
	public bool followTouchPosition { get; set; }
	public bool animateOnMoveToTouch { get; set; }
	public float moveToTouchSpeed { get; set; }
	public bool animateOnReturn { get; set; }
	public float returnSpeed { get; set; }
	public bool manageRaycasting { get; set; }
	public int pointerId { get; set; }
	public bool hasPointer { get; }
	internal StandaloneAxis axis { get; }
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> moveStartedDelegate { get; }
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> moveEndedDelegate { get; }
	private float axisValue { get; }
	private float axisValuePrev { get; }
	private bool buttonValue { get; }
	private bool buttonValuePrev { get; }
	private int effectivePointerId { get; }

	// Methods

	// RVA: 0x19A27F0 Offset: 0x19A19F0 VA: 0x1819A27F0
	public void add_AxisValueChangedEvent(UnityAction<float> value) { }

	// RVA: 0x19A3A80 Offset: 0x19A2C80 VA: 0x1819A3A80
	public void remove_AxisValueChangedEvent(UnityAction<float> value) { }

	// RVA: 0x19A28B0 Offset: 0x19A1AB0 VA: 0x1819A28B0
	public void add_ButtonValueChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x19A3B40 Offset: 0x19A2D40 VA: 0x1819A3B40
	public void remove_ButtonValueChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x19A2850 Offset: 0x19A1A50 VA: 0x1819A2850
	public void add_ButtonDownEvent(UnityAction value) { }

	// RVA: 0x19A3AE0 Offset: 0x19A2CE0 VA: 0x1819A3AE0
	public void remove_ButtonDownEvent(UnityAction value) { }

	// RVA: 0x19A2880 Offset: 0x19A1A80 VA: 0x1819A2880
	public void add_ButtonUpEvent(UnityAction value) { }

	// RVA: 0x19A3B10 Offset: 0x19A2D10 VA: 0x1819A3B10
	public void remove_ButtonUpEvent(UnityAction value) { }

	// RVA: 0x19A2F10 Offset: 0x19A2110 VA: 0x1819A2F10
	public CustomControllerElementTargetSetForFloat get_targetCustomControllerElement() { }

	// RVA: 0x19A2DD0 Offset: 0x19A1FD0 VA: 0x1819A2DD0
	public TouchButton.ButtonType get_buttonType() { }

	// RVA: 0x19A3C30 Offset: 0x19A2E30 VA: 0x1819A3C30
	public void set_buttonType(TouchButton.ButtonType value) { }

	// RVA: 0x19A2DA0 Offset: 0x19A1FA0 VA: 0x1819A2DA0
	public bool get_activateOnSwipeIn() { }

	// RVA: 0x19A3BA0 Offset: 0x19A2DA0 VA: 0x1819A3BA0
	public void set_activateOnSwipeIn(bool value) { }

	// RVA: 0x19A2E80 Offset: 0x19A2080 VA: 0x1819A2E80
	public bool get_stayActiveOnSwipeOut() { }

	// RVA: 0x19A3E80 Offset: 0x19A3080 VA: 0x1819A3E80
	public void set_stayActiveOnSwipeOut(bool value) { }

	// RVA: 0x19A2F20 Offset: 0x19A2120 VA: 0x1819A2F20
	public bool get_useDigitalAxisSimulation() { }

	// RVA: 0x19A3F40 Offset: 0x19A3140 VA: 0x1819A3F40
	public void set_useDigitalAxisSimulation(bool value) { }

	// RVA: 0x19A2DE0 Offset: 0x19A1FE0 VA: 0x1819A2DE0
	public float get_digitalAxisGravity() { }

	// RVA: 0x19A3C60 Offset: 0x19A2E60 VA: 0x1819A3C60
	public void set_digitalAxisGravity(float value) { }

	// RVA: 0x19A2DF0 Offset: 0x19A1FF0 VA: 0x1819A2DF0
	public float get_digitalAxisSensitivity() { }

	// RVA: 0x19A3C90 Offset: 0x19A2E90 VA: 0x1819A3C90
	public void set_digitalAxisSensitivity(float value) { }

	// RVA: 0x794D40 Offset: 0x793F40 VA: 0x180794D40
	public TouchRegion get_touchRegion() { }

	// RVA: 0x19A3EB0 Offset: 0x19A30B0 VA: 0x1819A3EB0
	public void set_touchRegion(TouchRegion value) { }

	// RVA: 0x19A2F30 Offset: 0x19A2130 VA: 0x1819A2F30
	public bool get_useTouchRegionOnly() { }

	// RVA: 0x19A3F70 Offset: 0x19A3170 VA: 0x1819A3F70
	public void set_useTouchRegionOnly(bool value) { }

	// RVA: 0x19A2E30 Offset: 0x19A2030 VA: 0x1819A2E30
	public bool get_moveToTouchPosition() { }

	// RVA: 0x19A3D50 Offset: 0x19A2F50 VA: 0x1819A3D50
	public void set_moveToTouchPosition(bool value) { }

	// RVA: 0x19A2E60 Offset: 0x19A2060 VA: 0x1819A2E60
	public bool get_returnOnRelease() { }

	// RVA: 0x19A3DF0 Offset: 0x19A2FF0 VA: 0x1819A3DF0
	public void set_returnOnRelease(bool value) { }

	// RVA: 0x19A2E00 Offset: 0x19A2000 VA: 0x1819A2E00
	public bool get_followTouchPosition() { }

	// RVA: 0x19A3CC0 Offset: 0x19A2EC0 VA: 0x1819A3CC0
	public void set_followTouchPosition(bool value) { }

	// RVA: 0x19A2DB0 Offset: 0x19A1FB0 VA: 0x1819A2DB0
	public bool get_animateOnMoveToTouch() { }

	// RVA: 0x19A3BD0 Offset: 0x19A2DD0 VA: 0x1819A3BD0
	public void set_animateOnMoveToTouch(bool value) { }

	// RVA: 0x19A2E40 Offset: 0x19A2040 VA: 0x1819A2E40
	public float get_moveToTouchSpeed() { }

	// RVA: 0x19A3D80 Offset: 0x19A2F80 VA: 0x1819A3D80
	public void set_moveToTouchSpeed(float value) { }

	// RVA: 0x19A2DC0 Offset: 0x19A1FC0 VA: 0x1819A2DC0
	public bool get_animateOnReturn() { }

	// RVA: 0x19A3C00 Offset: 0x19A2E00 VA: 0x1819A3C00
	public void set_animateOnReturn(bool value) { }

	// RVA: 0x19A2E70 Offset: 0x19A2070 VA: 0x1819A2E70
	public float get_returnSpeed() { }

	// RVA: 0x19A3E20 Offset: 0x19A3020 VA: 0x1819A3E20
	public void set_returnSpeed(float value) { }

	// RVA: 0x19A2E20 Offset: 0x19A2020 VA: 0x1819A2E20
	public bool get_manageRaycasting() { }

	// RVA: 0x19A3CF0 Offset: 0x19A2EF0 VA: 0x1819A3CF0
	public void set_manageRaycasting(bool value) { }

	// RVA: 0x19A2E50 Offset: 0x19A2050 VA: 0x1819A2E50
	public int get_pointerId() { }

	// RVA: 0x19A3DE0 Offset: 0x19A2FE0 VA: 0x1819A3DE0
	public void set_pointerId(int value) { }

	// RVA: 0x19A2E10 Offset: 0x19A2010 VA: 0x1819A2E10
	public bool get_hasPointer() { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	internal StandaloneAxis get_axis() { }

	// RVA: 0x19A24B0 Offset: 0x19A16B0 VA: 0x1819A24B0
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> YYxENRwhMeeQsBvSPiLQMLEFJtBA() { }

	// RVA: 0x19A39F0 Offset: 0x19A2BF0 VA: 0x1819A39F0
	private Action<TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA> qyoMuHfMAFMgmtRdabCvADNSAEyt() { }

	// RVA: 0x19A0680 Offset: 0x199F880 VA: 0x1819A0680
	private float MWrcwyvfLWpxfNJDbmzcJEQgeasf() { }

	// RVA: 0x19A30D0 Offset: 0x19A22D0 VA: 0x1819A30D0
	private float jKDmwPFDqSIGZOkqBXGJllMMuvne() { }

	// RVA: 0x19A23F0 Offset: 0x19A15F0 VA: 0x1819A23F0
	private bool WqiADySwvrpomCYJhXVMfWMiZlA() { }

	// RVA: 0x19A19F0 Offset: 0x19A0BF0 VA: 0x1819A19F0
	private bool SXAatWwZIEopMdytPUqUMXWmlDwK() { }

	// RVA: 0x19A2A10 Offset: 0x19A1C10 VA: 0x1819A2A10
	private int cpjurjFZnCPLRBbqXODeKfZPDhMH() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A2540 Offset: 0x19A1740 VA: 0x1819A2540
	private void .ctor() { }

	// RVA: 0x19A1AB0 Offset: 0x19A0CB0 VA: 0x1819A1AB0
	public void SetRawValue(float value) { }

	// RVA: 0x19A1A20 Offset: 0x19A0C20 VA: 0x1819A1A20
	public void SetDefaultPosition() { }

	// RVA: 0x19A4070 Offset: 0x19A3270 VA: 0x1819A4070
	private void uZcfXdpjkcTpEPMGVHTavVAQIGaW(Vector2 ) { }

	// RVA: 0x19A1700 Offset: 0x19A0900 VA: 0x1819A1700
	public void ReturnToDefaultPosition(bool instant) { }

	// RVA: 0x19A1770 Offset: 0x19A0970 VA: 0x1819A1770
	public void ReturnToDefaultPosition() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x199F8C0 Offset: 0x199EAC0 VA: 0x18199F8C0 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A0A50 Offset: 0x199FC50 VA: 0x1819A0A50 Slot: 10
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A0A10 Offset: 0x199FC10 VA: 0x1819A0A10 Slot: 11
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A12A0 Offset: 0x19A04A0 VA: 0x1819A12A0 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A1670 Offset: 0x19A0870 VA: 0x1819A1670 Slot: 17
	internal override void Reset() { }

	// RVA: 0x19A1220 Offset: 0x19A0420 VA: 0x1819A1220 Slot: 18
	internal override void OnUpdate() { }

	// RVA: 0x19A0A80 Offset: 0x199FC80 VA: 0x1819A0A80 Slot: 19
	internal override bool OnInitialize() { }

	// RVA: 0x19A0970 Offset: 0x199FB70 VA: 0x1819A0970 Slot: 28
	internal override void OnCustomControllerUpdate() { }

	// RVA: 0x19A0EC0 Offset: 0x19A00C0 VA: 0x1819A0EC0 Slot: 21
	internal override void OnSubscribeEvents() { }

	// RVA: 0x19A1070 Offset: 0x19A0270 VA: 0x1819A1070 Slot: 22
	internal override void OnUnsubscribeEvents() { }

	// RVA: 0x19A0E60 Offset: 0x19A0060 VA: 0x1819A0E60 Slot: 23
	internal override void OnSetProperty() { }

	// RVA: 0x19A0880 Offset: 0x199FA80 VA: 0x1819A0880 Slot: 24
	internal override void OnClear() { }

	// RVA: 0x199FD00 Offset: 0x199EF00 VA: 0x18199FD00 Slot: 7
	public override void ClearValue() { }

	// RVA: 0x19A02F0 Offset: 0x199F4F0 VA: 0x1819A02F0 Slot: 36
	internal override bool IsPressed() { }

	// RVA: 0x19A0390 Offset: 0x199F590 VA: 0x1819A0390 Slot: 37
	internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject) { }

	// RVA: 0x19A12D0 Offset: 0x19A04D0 VA: 0x1819A12D0
	private void QDlJJHMLrBWzUmYdjGedeOeokvCk() { }

	// RVA: 0x19A2BE0 Offset: 0x19A1DE0 VA: 0x1819A2BE0
	private void gTmzdVarQIRSBYHZlDszGKXrlAOIb() { }

	// RVA: 0x19A07B0 Offset: 0x199F9B0 VA: 0x1819A07B0
	private void OjgRqOLQeMruscGXEZKEwCDyIYsm() { }

	// RVA: 0x19A2A40 Offset: 0x19A1C40 VA: 0x1819A2A40
	private void evSHgyYYKzWRKTuFEWizFUiKdPOF(float , bool ) { }

	// RVA: 0x19A2420 Offset: 0x19A1620 VA: 0x1819A2420
	private void XtbCbszzZiDNzhUQKSVZZvfjmAuw() { }

	// RVA: 0x199FD80 Offset: 0x199EF80 VA: 0x18199FD80
	private void DHecHkgySCzhaTCuvzIEyvRCtMzF() { }

	// RVA: 0x199FF70 Offset: 0x199F170 VA: 0x18199FF70
	private void ETaWHvEdTdbkgezzvzTnawlHVBHz() { }

	// RVA: 0x19A14C0 Offset: 0x19A06C0 VA: 0x1819A14C0
	private void QpkbUJNoXSDhTFhZylEzEJRXkHehb() { }

	// RVA: 0x19A3260 Offset: 0x19A2460 VA: 0x1819A3260
	private bool klynbdOQcjiOGNUqxduxLGBlYloE() { }

	// RVA: 0x19A04F0 Offset: 0x199F6F0 VA: 0x1819A04F0
	private void JDgQJtOVGIkBkXHLwlsOBotrORgN(TouchRegion ) { }

	// RVA: 0x19A1DB0 Offset: 0x19A0FB0 VA: 0x1819A1DB0
	private void VLdfERUjUWSRGTKsrQPyYPnrjYYy(TouchRegion ) { }

	// RVA: 0x19A4430 Offset: 0x19A3630 VA: 0x1819A4430
	private void yuWOzVPPqBbPvVFtmCsZXvYitgWK() { }

	// RVA: 0x19A17D0 Offset: 0x19A09D0 VA: 0x1819A17D0
	private void RkCHczQEPWlATWmNNbfBBjMBKmJv(Vector2 , bool , float , TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA ) { }

	// RVA: 0x19A1F30 Offset: 0x19A1130 VA: 0x1819A1F30
	private void VfeewMWwnRXEywPQQRXBiSlcfKwt(Vector2 , PositionType , bool , float , TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA ) { }

	// RVA: 0x19A0230 Offset: 0x199F430 VA: 0x1819A0230
	private IEnumerator FtpUKZzUjuHXaqpqeUaPGGmzrcln(Vector2 , PositionType , float , TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA ) { }

	// RVA: 0x19A2F40 Offset: 0x19A2140 VA: 0x1819A2F40
	private void higFWbgueicUalIqtbHAAThGfhyo(TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA , Vector2 , PositionType ) { }

	// RVA: 0x19A2AF0 Offset: 0x19A1CF0 VA: 0x1819A2AF0
	private void fxUvnBuNQDXAfFDNUDPLZeKAFXGn(TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA ) { }

	// RVA: 0x19A2910 Offset: 0x19A1B10 VA: 0x1819A2910
	private void cPnZVzScrCzhFQrbQXCwxpvhiAFN(TouchButton.aLkgKuBQpXeWUlxevIqySdJcgtyVA ) { }

	// RVA: 0x19A31B0 Offset: 0x19A23B0 VA: 0x1819A31B0
	private void kaeTZUPcSPPZNjUMXgDQmxVUeGHl(int ) { }

	// RVA: 0x199FDD0 Offset: 0x199EFD0 VA: 0x18199FDD0
	private void DkEbocBzUEyMkgEmuIIGNchHSTxM() { }

	// RVA: 0x19A1AE0 Offset: 0x19A0CE0 VA: 0x1819A1AE0
	private void TQTymCfNazBTwlSGzHgniMmyMQTWA() { }

	// RVA: 0x19A3670 Offset: 0x19A2870 VA: 0x1819A3670
	private bool lthEEVtqLDDKZhttBMwjoGsxiUCEA() { }

	// RVA: 0x19A02D0 Offset: 0x199F4D0 VA: 0x1819A02D0
	private void HuuhHCqkTABsOmPaCOqQrXWEIkfK() { }

	// RVA: 0x19A3110 Offset: 0x19A2310 VA: 0x1819A3110
	private bool kMtjUmzABFJrCmRCKlyLgiqbjbAP(int ) { }

	// RVA: 0x199F990 Offset: 0x199EB90 VA: 0x18199F990
	private PointerEventData CIngIqAZbLyZumKkOmSudMlDaftTb(int , GameObject ) { }

	// RVA: 0x19A1530 Offset: 0x19A0730 VA: 0x1819A1530
	private PointerEventData RbfYHoEusauHELPLhfYEwVXQFME(int ) { }

	// RVA: 0x19A37D0 Offset: 0x19A29D0 VA: 0x1819A37D0
	private void pZXmDPxOYtnCdOviVRriJfLgYtOA(PointerEventData ) { }

	// RVA: 0x19A4220 Offset: 0x19A3420 VA: 0x1819A4220
	private PointerEventData xnSHVNyqXAlgJJjRVNVijpwPiGRK(int ) { }

	// RVA: 0x19A0000 Offset: 0x199F200 VA: 0x1819A0000
	private void EWfeVKiueUBvRkrKpYlDOiCOYxMR(PointerEventData , TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM ) { }

	// RVA: 0x19A3FA0 Offset: 0x19A31A0 VA: 0x1819A3FA0
	private void tfrpPYxIHIHjkiWBFEkgHKdefOzUA(PointerEventData , TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM ) { }

	// RVA: 0x19A32E0 Offset: 0x19A24E0 VA: 0x1819A32E0
	private void lrEdeTLiVJZZQQuelEZeodNeRWiV(PointerEventData , TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM ) { }

	// RVA: 0x199FE10 Offset: 0x199F010 VA: 0x18199FE10
	private void DsmjzykbgNRWiyVTpByLEIMtiOUL(PointerEventData , TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM ) { }

	// RVA: 0x19A4130 Offset: 0x19A3330 VA: 0x1819A4130
	private void xZHvnytrvlfjVfLgQEbkjlqNgRyEA(int , Vector2 , TouchButton.gBkExiHzyWDuMmqaqgLPtZadGDiM ) { }

	// RVA: 0x19A36F0 Offset: 0x19A28F0 VA: 0x1819A36F0
	private void ougVuQhnQzfKHMytGtjOsyDpVhlo() { }

	// RVA: 0x19A0AA0 Offset: 0x199FCA0 VA: 0x1819A0AA0 Slot: 38
	internal override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x19A0D70 Offset: 0x199FF70 VA: 0x1819A0D70 Slot: 39
	internal override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x19A0B90 Offset: 0x199FD90 VA: 0x1819A0B90 Slot: 40
	internal override void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x19A0C80 Offset: 0x199FE80 VA: 0x1819A0C80 Slot: 41
	internal override void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x19A2340 Offset: 0x19A1540 VA: 0x1819A2340
	private void VhILgLQWsaiRgnQPJGpziPbKdzgQ(PointerEventData ) { }

	// RVA: 0x19A4080 Offset: 0x19A3280 VA: 0x1819A4080
	private void wQCAAAJbcxhqrQcFREdljHfpIogh(PointerEventData ) { }

	// RVA: 0x19A2CF0 Offset: 0x19A1EF0 VA: 0x1819A2CF0
	private void gbCAZsYtYFCZDwIjJGFQKMdNADQR(PointerEventData ) { }

	// RVA: 0x19A3940 Offset: 0x19A2B40 VA: 0x1819A3940
	private void pyVMjZLVeYMaEqBAIMPBeklQWRer(PointerEventData ) { }

	// RVA: 0x19A0730 Offset: 0x199F930 VA: 0x1819A0730
	private void OgkvOQvGJkmLynBGZKSSLhARBUjaA(float ) { }

	// RVA: 0x19A06C0 Offset: 0x199F8C0 VA: 0x1819A06C0
	private void OSEQWIldqxDdcHAyIBpdzWTtRzCg(bool ) { }

	// RVA: 0x19A1D70 Offset: 0x19A0F70 VA: 0x1819A1D70
	private void TigLoFxeSYdUgiuKYRZUmDlTYYy() { }

	// RVA: 0x19A3090 Offset: 0x19A2290 VA: 0x1819A3090
	private void ipJmjZDxcdfRXMuEAoSpKwVAEhqX() { }
}

// Namespace: Rewired.ComponentControls
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[Serializable]
public abstract class TouchControl : CustomControllerControl // TypeDefIndex: 7683
{
	// Fields
	private Canvas _canvas; // 0x30
	private RectTransform __rectTransform; // 0x38

	// Properties
	internal TouchController YrmEnScfMkhIhmSVIAsGifwTfypDb { get; }
	internal Canvas BYxffwBjEvMheKtuwAYkyJheDocib { get; }
	internal RectTransform ARhQhcSsWNCEjodaiKNjZcYBnXei { get; }
	internal RectTransform VsZTfGZdTOfzINQdGEuABFjxGrSBA { get; }
	internal override bool SwQbzDXeDznizSNPahbkHtgLQlDK { get; }

	// Methods

	// RVA: 0x19A4630 Offset: 0x19A3830 VA: 0x1819A4630
	internal TouchController EOnmgLMkMCBDiTnikBVYdDyiltFn() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal Canvas AgAgbfEZVqCGZbpMLhetchrywNqZA() { }

	// RVA: 0x19A49F0 Offset: 0x19A3BF0 VA: 0x1819A49F0
	internal RectTransform efXuGCFIkLhfGFeViwwJZCCdtREq() { }

	// RVA: 0x19A4A90 Offset: 0x19A3C90 VA: 0x1819A4A90
	internal RectTransform kuCCNslKxwsYdkiVRMXUUkYPddiC() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19916A0 Offset: 0x19908A0 VA: 0x1819916A0
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A4820 Offset: 0x19A3A20 VA: 0x1819A4820 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A47E0 Offset: 0x19A39E0 VA: 0x1819A47E0 Slot: 14
	internal override void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A47E0 Offset: 0x19A39E0 VA: 0x1819A47E0 Slot: 15
	internal override void OnTransformParentChanged() { }

	// RVA: 0x19A4980 Offset: 0x19A3B80 VA: 0x1819A4980 Slot: 6
	internal override bool ToAHsOILAjRmHnrFpebmtqzeeiCM() { }

	// RVA: 0x19A4750 Offset: 0x19A3950 VA: 0x1819A4750 Slot: 19
	internal override bool HOADMXDSIKPbaWvQBkjbeSSAZQOA() { }

	// RVA: 0x19A4AE0 Offset: 0x19A3CE0 VA: 0x1819A4AE0 Slot: 23
	internal override void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A4680 Offset: 0x19A3880 VA: 0x1819A4680 Slot: 26
	internal override IComponentController FindController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A46F0 Offset: 0x19A38F0 VA: 0x1819A46F0 Slot: 27
	internal override Type GetRequiredControllerType() { }

	// RVA: 0x19A4860 Offset: 0x19A3A60 VA: 0x1819A4860
	private bool PvPavqXeimTHRSMqOarRnlRqXjKt(bool , bool ) { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Controller")]
[RequireComponent(typeof(RectTransform))]
[Serializable]
public sealed class TouchController : CustomController // TypeDefIndex: 7684
{
	// Fields
	[Tooltip("If true, disables mouse input when the Touch Controller script is enabled or GameObject is activated and re-enables mouse input when the script is disabled or GameObject is deactivated. This is useful for disabling Mouse Look controls when using touch controls in an FPS for example.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _disableMouseInputWhenEnabled; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If true, a Custom Controller will be populated with the data from this controller.")]
	private bool _useCustomController; // 0x61
	private bool zJFjkoeefmObhggpepGaPvdBlKuS; // 0x62

	// Properties
	public bool disableMouseInputWhenEnabled { get; set; }
	public bool useCustomController { get; set; }

	// Methods

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_disableMouseInputWhenEnabled() { }

	// RVA: 0x19A5180 Offset: 0x19A4380 VA: 0x1819A5180
	public void set_disableMouseInputWhenEnabled(bool value) { }

	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220
	public bool get_useCustomController() { }

	// RVA: 0x19A5190 Offset: 0x19A4390 VA: 0x1819A5190
	public void set_useCustomController(bool value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A5050 Offset: 0x19A4250 VA: 0x1819A5050
	private void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A4E20 Offset: 0x19A4020 VA: 0x1819A4E20 Slot: 10
	internal override void OnDisable() { }

	// RVA: 0x19A4BF0 Offset: 0x19A3DF0 VA: 0x1819A4BF0 Slot: 13
	internal override bool HOADMXDSIKPbaWvQBkjbeSSAZQOA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220 Slot: 20
	internal override bool GetUseCustomController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0xE5B990 Offset: 0xE5AB90 VA: 0x180E5B990 Slot: 21
	internal override void SetUseCustomController(bool value) { }

	// RVA: 0x19A4F80 Offset: 0x19A4180 VA: 0x1819A4F80
	private void UAaAeAxHELiBCecijiSaiVijxhhiA(bool ) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	// RVA: 0x19A4B20 Offset: 0x19A3D20 VA: 0x1819A4B20
	private bool EmtLIEDumaucPbcKuRCQnTgOOsfS() { }
}

// Namespace: 
public enum TouchInteractable.InteractionState // TypeDefIndex: 7685
{
	// Fields
	public int value__; // 0x0
	public const TouchInteractable.InteractionState Normal = 0;
	public const TouchInteractable.InteractionState Highlighted = 1;
	public const TouchInteractable.InteractionState Pressed = 2;
	public const TouchInteractable.InteractionState Disabled = 3;
}

// Namespace: 
[Flags]
public enum TouchInteractable.TransitionTypeFlags // TypeDefIndex: 7686
{
	// Fields
	public int value__; // 0x0
	public const TouchInteractable.TransitionTypeFlags None = 0;
	public const TouchInteractable.TransitionTypeFlags ColorTint = 1;
	public const TouchInteractable.TransitionTypeFlags SpriteSwap = 2;
	public const TouchInteractable.TransitionTypeFlags Animation = 4;
}

// Namespace: 
[Flags]
public enum TouchInteractable.MouseButtonFlags // TypeDefIndex: 7687
{
	// Fields
	public int value__; // 0x0
	public const TouchInteractable.MouseButtonFlags None = 0;
	public const TouchInteractable.MouseButtonFlags LeftButton = 1;
	public const TouchInteractable.MouseButtonFlags RightButton = 2;
	public const TouchInteractable.MouseButtonFlags MiddleButton = 4;
	public const TouchInteractable.MouseButtonFlags AnyButton = -1;
}

// Namespace: 
[Serializable]
public class TouchInteractable.InteractionStateTransitionEventHandler : UnityEvent<TouchInteractable.InteractionStateTransitionArgs> // TypeDefIndex: 7688
{
	// Methods

	// RVA: 0x19950F0 Offset: 0x19942F0 VA: 0x1819950F0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchInteractable.VisibilityChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 7689
{
	// Methods

	// RVA: 0x19B0220 Offset: 0x19AF420 VA: 0x1819B0220
	public void .ctor() { }
}

// Namespace: 
public class TouchInteractable.InteractionStateTransitionArgs // TypeDefIndex: 7690
{
	// Fields
	private TouchInteractable AjVbLTnkMsSscGTqyayzzJoEKJGf; // 0x10
	private TouchInteractable.InteractionState yvVggLPVEKDXAjKXDHgXyFMgifIgA; // 0x18
	private float NuPnLiPkiJZxQWhoEcfdndwhFmhIA; // 0x1C

	// Properties
	public TouchInteractable sender { get; }
	public TouchInteractable.InteractionState state { get; }
	public float duration { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public TouchInteractable get_sender() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public TouchInteractable.InteractionState get_state() { }

	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_duration() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x19950E0 Offset: 0x19942E0 VA: 0x1819950E0
	internal void aLEuiSRTQwaSBsXbGGQLCoTwTDkl(TouchInteractable , TouchInteractable.InteractionState , float ) { }
}

// Namespace: 
public interface TouchInteractable.IInteractionStateTransitionHandler // TypeDefIndex: 7691
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs data);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TouchInteractable.UlMjttUiKBqPYhdulGUPgxJeAuSr // TypeDefIndex: 7692
{
	// Fields
	public static readonly TouchInteractable.UlMjttUiKBqPYhdulGUPgxJeAuSr <>9; // 0x0
	public static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> <>9__152_0; // 0x8

	// Methods

	// RVA: 0x19B01C0 Offset: 0x19AF3C0 VA: 0x1819B01C0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19B0110 Offset: 0x19AF310 VA: 0x1819B0110
	internal void EpulZepJeqGzzDJguJMMWNTpakaf(TouchInteractable.IInteractionStateTransitionHandler , TouchInteractable.InteractionStateTransitionArgs ) { }
}

// Namespace: Rewired.ComponentControls
[ExecuteInEditMode]
[DisallowMultipleComponent]
[Serializable]
public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 7693
{
	// Fields
	public const int POINTER_ID_NULL = -2147483648;
	public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1;
	public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2;
	public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3;
	internal const int MAX_MOUSE_BUTTONS = 3;
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Toggles whether the control can be interacted with by the user.")]
	private bool _interactable; // 0x40
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
	private bool _visible; // 0x41
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Sets visibility to False when the control is idle. When the control is no longer idle, visibility will be set to True again.")]
	private bool _hideWhenIdle; // 0x42
	[Tooltip("The mouse buttons that are allowed to interact with this control.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Bitmask(typeof(TouchInteractable.MouseButtonFlags))]
	private TouchInteractable.MouseButtonFlags _allowedMouseButtons; // 0x44
	[SerializeField]
	[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
	[Bitmask(typeof(TouchInteractable.TransitionTypeFlags))]
	[CustomObfuscation(rename = False)]
	private TouchInteractable.TransitionTypeFlags _transitionType; // 0x48
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings using for Color Tint transitions.")]
	[SerializeField]
	private ColorBlock _transitionColorTint; // 0x4C
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings using for Sprite State transitions.")]
	[SerializeField]
	private SpriteState _transitionSpriteState; // 0xA8
	[Tooltip("Settings using for Animation Trigger transitions.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private AnimationTriggers _transitionAnimationTriggers; // 0xC8
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
	private Graphic _targetGraphic; // 0xD0
	[Tooltip("Event sent when the Interaction State changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchInteractable.InteractionStateTransitionEventHandler _onInteractionStateTransition; // 0xD8
	[Tooltip("Event sent when visibility changes.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private TouchInteractable.VisibilityChangedEventHandler _onVisibilityChanged; // 0xE0
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Normal.")]
	[SerializeField]
	private UnityEvent _onInteractionStateChangedToNormal; // 0xE8
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Event sent when interaction state changes to Highlighted.")]
	private UnityEvent _onInteractionStateChangedToHighlighted; // 0xF0
	[Tooltip("Event sent when interaction state changes to Pressed.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private UnityEvent _onInteractionStateChangedToPressed; // 0xF8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when interaction state changes to Disabled.")]
	private UnityEvent _onInteractionStateChangedToDisabled; // 0x100
	private readonly List<CanvasGroup> _canvasGroupCache; // 0x108
	private bool _groupsAllowInteraction; // 0x110
	private TouchInteractable.InteractionState _interactionState; // 0x114
	private bool DYRrDmWzJNeoXkaUDrhKmWzPmQdE; // 0x118
	private bool eZThheVBDPbmBrDNEpgunwPUMELi; // 0x119
	private bool _varWatch_visible; // 0x11A
	private bool _varWatch_interactable; // 0x11B
	private bool _allowSendingEvents; // 0x11C
	private static TouchInteractable.InteractionStateTransitionArgs _transitionArgs; // 0x0
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers; // 0x120
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers; // 0x128
	private static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate; // 0x8

	// Properties
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<IVisibilityChangedHandler, bool> EzAFJsQjvHcZVrblLbaoJAXnCVCs { get; }
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> BjbbcikARedQKPiUodfQyvrScJgjA { get; }
	public bool interactable { get; set; }
	public bool visible { get; set; }
	public bool hideWhenIdle { get; set; }
	public TouchInteractable.MouseButtonFlags allowedMouseButtons { get; set; }
	public TouchInteractable.TransitionTypeFlags transitionType { get; set; }
	public ColorBlock transitionColorTint { get; set; }
	public SpriteState transitionSpriteState { get; set; }
	public AnimationTriggers transitionAnimationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	public TouchInteractable.InteractionState interactionState { get; }
	internal static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> INwmlohoMbIjTeGglaoMINAGjgiVA { get; }

	// Methods

	// RVA: 0x19A74D0 Offset: 0x19A66D0 VA: 0x1819A74D0
	public void add_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value) { }

	// RVA: 0x19A8380 Offset: 0x19A7580 VA: 0x1819A8380
	public void remove_InteractionStateSetEvent(UnityAction<TouchInteractable.InteractionStateTransitionArgs> value) { }

	// RVA: 0x19A7530 Offset: 0x19A6730 VA: 0x1819A7530
	public void add_VisibilityChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x19A83E0 Offset: 0x19A75E0 VA: 0x1819A83E0
	public void remove_VisibilityChangedEvent(UnityAction<bool> value) { }

	// RVA: 0x19A7470 Offset: 0x19A6670 VA: 0x1819A7470
	public void add_InteractionStateChangedToNormal(UnityAction value) { }

	// RVA: 0x19A8320 Offset: 0x19A7520 VA: 0x1819A8320
	public void remove_InteractionStateChangedToNormal(UnityAction value) { }

	// RVA: 0x19A7440 Offset: 0x19A6640 VA: 0x1819A7440
	public void add_InteractionStateChangedToHighlighted(UnityAction value) { }

	// RVA: 0x19A82F0 Offset: 0x19A74F0 VA: 0x1819A82F0
	public void remove_InteractionStateChangedToHighlighted(UnityAction value) { }

	// RVA: 0x19A74A0 Offset: 0x19A66A0 VA: 0x1819A74A0
	public void add_InteractionStateChangedToPressed(UnityAction value) { }

	// RVA: 0x19A8350 Offset: 0x19A7550 VA: 0x1819A8350
	public void remove_InteractionStateChangedToPressed(UnityAction value) { }

	// RVA: 0x19A7410 Offset: 0x19A6610 VA: 0x1819A7410
	public void add_InteractionStateChangedToDisabled(UnityAction value) { }

	// RVA: 0x19A82C0 Offset: 0x19A74C0 VA: 0x1819A82C0
	public void remove_InteractionStateChangedToDisabled(UnityAction value) { }

	// RVA: 0x19A69A0 Offset: 0x19A5BA0 VA: 0x1819A69A0
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<IVisibilityChangedHandler, bool> RVmRDmWrqMrEGQKAcjPnANFFsESYA() { }

	// RVA: 0x19A80A0 Offset: 0x19A72A0 VA: 0x1819A80A0
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> pRCjdiinVqIzhydJqAJSZfPaxcEd() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_interactable() { }

	// RVA: 0x19A8510 Offset: 0x19A7710 VA: 0x1819A8510
	public void set_interactable(bool value) { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_visible() { }

	// RVA: 0x19A86D0 Offset: 0x19A78D0 VA: 0x1819A86D0
	public void set_visible(bool value) { }

	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0
	public bool get_hideWhenIdle() { }

	// RVA: 0x19A8460 Offset: 0x19A7660 VA: 0x1819A8460
	public void set_hideWhenIdle(bool value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public TouchInteractable.MouseButtonFlags get_allowedMouseButtons() { }

	// RVA: 0x19A8440 Offset: 0x19A7640 VA: 0x1819A8440
	public void set_allowedMouseButtons(TouchInteractable.MouseButtonFlags value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public TouchInteractable.TransitionTypeFlags get_transitionType() { }

	// RVA: 0x19A86B0 Offset: 0x19A78B0 VA: 0x1819A86B0
	public void set_transitionType(TouchInteractable.TransitionTypeFlags value) { }

	// RVA: 0x19A7AA0 Offset: 0x19A6CA0 VA: 0x1819A7AA0
	public ColorBlock get_transitionColorTint() { }

	// RVA: 0x19A85F0 Offset: 0x19A77F0 VA: 0x1819A85F0
	public void set_transitionColorTint(ColorBlock value) { }

	// RVA: 0x19A7AE0 Offset: 0x19A6CE0 VA: 0x1819A7AE0
	public SpriteState get_transitionSpriteState() { }

	// RVA: 0x19A8640 Offset: 0x19A7840 VA: 0x1819A8640
	public void set_transitionSpriteState(SpriteState value) { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340
	public AnimationTriggers get_transitionAnimationTriggers() { }

	// RVA: 0x19A85C0 Offset: 0x19A77C0 VA: 0x1819A85C0
	public void set_transitionAnimationTriggers(AnimationTriggers value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public Graphic get_targetGraphic() { }

	// RVA: 0x19A8530 Offset: 0x19A7730 VA: 0x1819A8530
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x19A7A10 Offset: 0x19A6C10 VA: 0x1819A7A10
	public Image get_image() { }

	// RVA: 0x19A8480 Offset: 0x19A7680 VA: 0x1819A8480
	public void set_image(Image value) { }

	// RVA: 0x19A79C0 Offset: 0x19A6BC0 VA: 0x1819A79C0
	public Animator get_animator() { }

	// RVA: 0x19A7A90 Offset: 0x19A6C90 VA: 0x1819A7A90
	public TouchInteractable.InteractionState get_interactionState() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A71B0 Offset: 0x19A63B0 VA: 0x1819A71B0
	internal void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A52E0 Offset: 0x19A44E0 VA: 0x1819A52E0 Slot: 8
	internal override void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A5EE0 Offset: 0x19A50E0 VA: 0x1819A5EE0 Slot: 14
	internal override void OnCanvasGroupChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A60B0 Offset: 0x19A52B0 VA: 0x1819A60B0 Slot: 16
	internal override void OnDidApplyAnimationProperties() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A62B0 Offset: 0x19A54B0 VA: 0x1819A62B0 Slot: 10
	internal override void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A60C0 Offset: 0x19A52C0 VA: 0x1819A60C0 Slot: 11
	internal override void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A66D0 Offset: 0x19A58D0 VA: 0x1819A66D0 Slot: 13
	internal override void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19A6AE0 Offset: 0x19A5CE0 VA: 0x1819A6AE0 Slot: 17
	internal override void Reset() { }

	// RVA: 0x19A8A80 Offset: 0x19A7C80 VA: 0x1819A8A80 Slot: 23
	internal override void xMCiOaEaqiLkGANzbxCqXanHJDBR() { }

	// RVA: 0x19A7790 Offset: 0x19A6990 VA: 0x1819A7790 Slot: 25
	internal override void eWUqONFuRLLhbwOudhpupUfOdxox() { }

	// RVA: 0x19A8C40 Offset: 0x19A7E40 VA: 0x1819A8C40
	private void yAmxqCSRONRqTjDYVHxeJsjGCGLJ() { }

	// RVA: 0x19A5880 Offset: 0x19A4A80 VA: 0x1819A5880
	private void JUhWzabzTARRLtbrsAxXiszVURFU(TouchInteractable.InteractionState , bool ) { }

	// RVA: 0x19A6FA0 Offset: 0x19A61A0 VA: 0x1819A6FA0
	private void VYslRaEGSmxGQXXhoEVKhwXtLkis(Color , bool ) { }

	// RVA: 0x19A70A0 Offset: 0x19A62A0 VA: 0x1819A70A0
	private void WPDLPjunOwRbDbcrWBkdGvdSHoLGA(Sprite ) { }

	// RVA: 0x19A5620 Offset: 0x19A4820 VA: 0x1819A5620
	private void JJfYXYBdlnKYWShdhrJlKUaRLGNy(string ) { }

	// RVA: 0x19A7B90 Offset: 0x19A6D90 VA: 0x1819A7B90
	private void kCnVlrNPJsUqwWAvLdRdegdiqHvWA(bool ) { }

	// RVA: 0x19A5600 Offset: 0x19A4800 VA: 0x1819A5600
	public bool IsInteractable() { }

	// RVA: 0x19A6A70 Offset: 0x19A5C70 VA: 0x1819A6A70 Slot: 36
	internal virtual bool RaGGKgONOhNIPUtpWcahANdjrITw() { }

	// RVA: 0x19A7900 Offset: 0x19A6B00 VA: 0x1819A7900
	internal void gAVreCyoACbJVDQJpXkUcykHfdWV(BaseEventData ) { }

	// RVA: 0x19A5DF0 Offset: 0x19A4FF0 VA: 0x1819A5DF0 Slot: 37
	internal virtual bool ONsJrvUbYMSEqFKtrdfgGlALXsQb(GameObject ) { }

	// RVA: 0x19A6B40 Offset: 0x19A5D40 VA: 0x1819A6B40
	private bool SedxWFEArtOgrHeKLBahgKpXzxsA(BaseEventData ) { }

	// RVA: 0x19A6D90 Offset: 0x19A5F90 VA: 0x1819A6D90
	private bool SedxWFEArtOgrHeKLBahgKpXzxsA(bool , GameObject ) { }

	// RVA: 0x19A8A20 Offset: 0x19A7C20 VA: 0x1819A8A20
	private TouchInteractable.InteractionState xHCBDmfsspyoPqNByqwozGxAZRFH(BaseEventData ) { }

	// RVA: 0x19A5D60 Offset: 0x19A4F60 VA: 0x1819A5D60
	private bool LzOXCNMIelPzMPrqovxVebGZWIcI(TouchInteractable.InteractionState ) { }

	// RVA: 0x19A5270 Offset: 0x19A4470 VA: 0x1819A5270
	private void ANxIbZVWMweHsPFOhWRVltGnSvdy() { }

	// RVA: 0x19A5270 Offset: 0x19A4470 VA: 0x1819A5270
	private void GdNioWahcIJiSDGfBfUXYGYQsACjc() { }

	// RVA: 0x19A53C0 Offset: 0x19A45C0 VA: 0x1819A53C0
	private void BzNddoEzJKmZTwvGXKDPSUFyHgId(bool , bool ) { }

	// RVA: 0x19A8710 Offset: 0x19A7910 VA: 0x1819A8710
	private void txBKcBUMVUnFknQGqRLSpbjbsrvN() { }

	// RVA: 0x19A77A0 Offset: 0x19A69A0 VA: 0x1819A77A0
	private void fGOHvAWwrsSEAwAWoGfSeABGwUREA() { }

	// RVA: 0x19A5480 Offset: 0x19A4680 VA: 0x1819A5480
	private void ETaWHvEdTdbkgezzvzTnawlHVBHz() { }

	// RVA: 0x19A7850 Offset: 0x19A6A50 VA: 0x1819A7850
	private void fhCOgWbqBPgDvBoNbafdfKIWzODVA() { }

	// RVA: 0x19A6450 Offset: 0x19A5650 VA: 0x1819A6450 Slot: 38
	internal virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x19A6630 Offset: 0x19A5830 VA: 0x1819A6630 Slot: 39
	internal virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x19A64F0 Offset: 0x19A56F0 VA: 0x1819A64F0 Slot: 40
	internal virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x19A6590 Offset: 0x19A5790 VA: 0x1819A6590 Slot: 41
	internal virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x19A5E60 Offset: 0x19A5060 VA: 0x1819A5E60 Slot: 42
	internal virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x19A6230 Offset: 0x19A5430 VA: 0x1819A6230 Slot: 43
	internal virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x19A63D0 Offset: 0x19A55D0 VA: 0x1819A63D0 Slot: 44
	internal virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x19A6F30 Offset: 0x19A6130 VA: 0x1819A6F30 Slot: 29
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xBD4BE0 Offset: 0xBD3DE0 VA: 0x180BD4BE0 Slot: 30
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xBD4C00 Offset: 0xBD3E00 VA: 0x180BD4C00 Slot: 31
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x19A6F50 Offset: 0x19A6150 VA: 0x1819A6F50 Slot: 32
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xBD4C20 Offset: 0xBD3E20 VA: 0x180BD4C20 Slot: 33
	private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xBD4C40 Offset: 0xBD3E40 VA: 0x180BD4C40 Slot: 34
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x19A6F10 Offset: 0x19A6110 VA: 0x1819A6F10 Slot: 35
	private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x19A7C20 Offset: 0x19A6E20 VA: 0x1819A7C20
	internal static bool ksKRjsOKuFAehilcsRJNKihcHME(int ) { }

	// RVA: 0x19A8AD0 Offset: 0x19A7CD0 VA: 0x1819A8AD0
	internal static Vector3 xuCEtPKfQhMYVeCFxLZCFnOURMrFb(int ) { }

	// RVA: 0x7BA810 Offset: 0x7B9A10 VA: 0x1807BA810
	internal static bool HdeHgcemSzmcRdLiFofWNyvcGybX(int ) { }

	// RVA: 0x19A55E0 Offset: 0x19A47E0 VA: 0x1819A55E0
	internal static bool IoNBsqHcXjqGQZToqQAqtnONvfXk(int ) { }

	// RVA: 0x19A8920 Offset: 0x19A7B20 VA: 0x1819A8920
	private static int wvMyucMKfoieJAnDrKCwjCzuMfEbb(int ) { }

	// RVA: 0x19A7E00 Offset: 0x19A7000 VA: 0x1819A7E00
	internal static bool meyhoZpSBonARwdaaQpMDlVVykjs(TouchInteractable.MouseButtonFlags , int ) { }

	// RVA: 0x19A6F70 Offset: 0x19A6170 VA: 0x1819A6F70
	private static bool UxzDDRkacWtcGvpFtPqeiCAQRbuD(TouchInteractable.MouseButtonFlags , int ) { }

	// RVA: 0x19A7B00 Offset: 0x19A6D00 VA: 0x1819A7B00
	private static int hlWifIvQojlISWONSaZUlxRTJAzd(int ) { }

	// RVA: 0x19A8030 Offset: 0x19A7230 VA: 0x1819A8030
	internal static bool pKQIhpMPaUbUzxtwmsaHcXJdKEtV(TouchInteractable.MouseButtonFlags , out int ) { }

	// RVA: 0x19A7EE0 Offset: 0x19A70E0 VA: 0x1819A7EE0
	internal static bool meyhoZpSBonARwdaaQpMDlVVykjs(int , TouchInteractable.MouseButtonFlags , EventTriggerType ) { }

	// RVA: 0x19A7590 Offset: 0x19A6790 VA: 0x1819A7590
	internal static bool bhMcaHjggbWehFqLJwbijLwPWhTN(TouchInteractable.MouseButtonFlags ) { }

	// RVA: 0x19A7610 Offset: 0x19A6810 VA: 0x1819A7610
	internal static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchInteractable.IInteractionStateTransitionHandler, TouchInteractable.InteractionStateTransitionArgs> dfjCfmKLVdjZnIRXxnupxAfsnjfAA() { }

	// RVA: 0x19A7150 Offset: 0x19A6350 VA: 0x1819A7150
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x19A7140 Offset: 0x19A6340 VA: 0x1819A7140
	private void XkgKyDbkQNnSPKQwsDNOKopxwlks(bool ) { }
}

// Namespace: 
public enum TouchJoystick.AxisDirection // TypeDefIndex: 7694
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.AxisDirection Both = 0;
	public const TouchJoystick.AxisDirection Horizontal = 1;
	public const TouchJoystick.AxisDirection Vertical = 2;
}

// Namespace: 
public enum TouchJoystick.JoystickMode // TypeDefIndex: 7695
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.JoystickMode Analog = 0;
	public const TouchJoystick.JoystickMode Digital = 1;
}

// Namespace: 
public enum TouchJoystick.SnapDirections // TypeDefIndex: 7696
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.SnapDirections None = 0;
	public const TouchJoystick.SnapDirections Four = 4;
	public const TouchJoystick.SnapDirections Eight = 8;
	public const TouchJoystick.SnapDirections Sixteen = 16;
	public const TouchJoystick.SnapDirections ThirtyTwo = 32;
	public const TouchJoystick.SnapDirections SixtyFour = 64;
}

// Namespace: 
private enum TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr // TypeDefIndex: 7697
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr None = 0;
	public const TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr TowardTouch = 1;
	public const TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr TowardHome = 2;
}

// Namespace: 
private enum TouchJoystick.uWERcVPoBHxxZBFMkRCVzAZCcqIn // TypeDefIndex: 7698
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.uWERcVPoBHxxZBFMkRCVzAZCcqIn Local = 0;
	public const TouchJoystick.uWERcVPoBHxxZBFMkRCVzAZCcqIn TouchRegion = 1;
}

// Namespace: 
public enum TouchJoystick.StickBounds // TypeDefIndex: 7699
{
	// Fields
	public int value__; // 0x0
	public const TouchJoystick.StickBounds Circle = 0;
	public const TouchJoystick.StickBounds Square = 1;
}

// Namespace: 
[Serializable]
public class TouchJoystick.ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 7700
{
	// Methods

	// RVA: 0x19C1030 Offset: 0x19C0230 VA: 0x1819C1030
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchJoystick.StickPositionChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 7701
{
	// Methods

	// RVA: 0x19B7E80 Offset: 0x19B7080 VA: 0x1819B7E80
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchJoystick.TapEventHandler : UnityEvent // TypeDefIndex: 7702
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchJoystick.TouchStartedEventHandler : UnityEvent // TypeDefIndex: 7703
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TouchJoystick.TouchEndedEventHandler : UnityEvent // TypeDefIndex: 7704
{
	// Methods

	// RVA: 0x1990F70 Offset: 0x1990170 VA: 0x181990F70
	public void .ctor() { }
}

// Namespace: 
public interface TouchJoystick.IValueChangedHandler // TypeDefIndex: 7705
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(Vector2 value);
}

// Namespace: 
public interface TouchJoystick.IStickPositionChangedHandler // TypeDefIndex: 7706
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStickPositionChanged(Vector2 value);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TouchJoystick.VrxpIjaHbpewMgIKkFkTWpcHEcvIb // TypeDefIndex: 7707
{
	// Fields
	public static readonly TouchJoystick.VrxpIjaHbpewMgIKkFkTWpcHEcvIb <>9; // 0x0
	public static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> <>9__277_0; // 0x8
	public static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> <>9__280_0; // 0x10

	// Methods

	// RVA: 0x19C1110 Offset: 0x19C0310 VA: 0x1819C1110
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x19C10B0 Offset: 0x19C02B0 VA: 0x1819C10B0
	internal void OaUeLvGSuAkQPKqDoRzYgwNxPQPfb(TouchJoystick.IValueChangedHandler , Vector2 ) { }

	// RVA: 0x19C1170 Offset: 0x19C0370 VA: 0x1819C1170
	internal void dTDljPEqqJxXBGfzUpmrMYSppSQH(TouchJoystick.IStickPositionChangedHandler , Vector2 ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TouchJoystick.zuPxQLLEiqMJmtIJOOoBaCRHUGXr : IDisposable, IEnumerator, IEnumerator<object> // TypeDefIndex: 7708
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private object lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	public float cZcXfaUQLSdMNuidSVChlgzDfnAE; // 0x20
	public TouchJoystick nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	public PositionType hLfllIxvLGOWIZQndcDlgQJUkIrx; // 0x30
	public Vector2 jSWaRiCCRwgdGDjHddfdiuAcbJzN; // 0x34
	public TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr EvsVLcIsjNETCbeSPuRlIASCqdUjb; // 0x3C
	private RectTransform ZsIUjiyMobckrfLfTldCSpbqwPOlA; // 0x40
	private Vector2 iMOPMHxLfwiMSsWitjFiivdSclIF; // 0x48
	private float mxCSqadedlIsKVcoertqSoZuYckr; // 0x50
	private float KTYHOMPpSJTbFoAKKyUngqWLWxXV; // 0x54

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19C5FD0 Offset: 0x19C51D0 VA: 0x1819C5FD0 Slot: 5
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19C6210 Offset: 0x19C5410 VA: 0x1819C6210 Slot: 7
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Rewired.ComponentControls
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Touch Joystick")]
[Serializable]
public sealed class TouchJoystick : TouchInteractable // TypeDefIndex: 7709
{
	// Fields
	private const float MAX_MOVE_SPEED = 20;
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's X axis.")]
	private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x130
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Custom Controller element(s) that will receive input values from the joystick's Y axis.")]
	private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x138
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("The Custom Controller element that will receive input values from taps.")]
	private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x140
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The Rect Transform of the stick disc. This is moved around by the user when manipulating the joystick.")]
	private RectTransform _stickTransform; // 0x148
	[Tooltip("The joystick's mode of operation. Set this to Digital to simulate a D-Pad which has only On/Off states. If you want mimic a real D-Pad, you should also set Snap Directions to 8.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.JoystickMode _joystickMode; // 0x150
	[Tooltip("A dead zone which is applied when Stick Mode is set to Digital. This is used to filter out tiny stick movements near 0, 0.")]
	[SerializeField]
	[Range(0, 1)]
	[CustomObfuscation(rename = False)]
	private float _digitalModeDeadZone; // 0x154
	[Tooltip("The range of movement of the stick in Canvas pixels. The larger the number, the further the stick must be moved from center to register movement.")]
	[CustomObfuscation(rename = False)]
	[Range(0,01, 1000)]
	[SerializeField]
	private float _stickRange; // 0x158
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If enabled, the stick range will scale with parent controls. Otherwise, the stick range will remain constant.")]
	private bool _scaleStickRange; // 0x15C
	[SerializeField]
	[Tooltip("The shape of the range of movement of the joystick.")]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.StickBounds _stickBounds; // 0x160
	[CustomObfuscation(rename = False)]
	[Tooltip("The axis directions in which movement is allowed. You can restrict movement to one or both axes.")]
	[SerializeField]
	private TouchJoystick.AxisDirection _axesToUse; // 0x164
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Snaps joystick movement to a fixed number of directions. This can be used to create a D-Pad, for example, setting it to 4 or 8 directions. If you want a true D-Pad, Stick Mode should be set to digital.")]
	private TouchJoystick.SnapDirections _snapDirections; // 0x168
	[Tooltip("If true, the stick disc will snap immediately to the touch position when initially touched. This results in the stick disc being centered to the touch position. This will cause the stick to generate input immediately when touched if not touched perfectly centered.If false, the stick disc will remain in its current position on touch, and when dragged will retain the same offset. The stick's center point will be set to the position of the touch. The initial touch will not cause the stick to pop in any direction.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _snapStickToTouch; // 0x16C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If true, the stick will return to the center after it is released. Otherwise, the stick will remain in the last position and continue to return input.")]
	private bool _centerStickOnRelease; // 0x16D
	[Tooltip("The underlying Axis 2D.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private StandaloneAxis2D _axis2D; // 0x170
	[Tooltip("If true, the joystick can be activated by a touch swipe that began in an area outside the joystick region. If false, the joystick can only be activated by a direct touch.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _activateOnSwipeIn; // 0x178
	[Tooltip("If true, the joystick will stay engaged even if the touch that activated it moves outside the joystick region. If false, the joystick will be released once the touch that activated it moves outside the joystick region.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _stayActiveOnSwipeOut; // 0x179
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Should taps on the touch pad be processed?")]
	private bool _allowTap; // 0x17A
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The maximum touch duration allowed for the touch to be considered a tap. A touch that lasts longer than this value will not trigger a tap when released.")]
	[FieldRange(0, 3,4028235E+38)]
	private float _tapTimeout; // 0x17C
	[Tooltip("The maximum movement distance allowed in pixels since the touch began for the touch to be considered a tap. [-1 = no limit]")]
	[CustomObfuscation(rename = False)]
	[FieldRange(-1, 2147483647)]
	[SerializeField]
	private int _tapDistanceLimit; // 0x180
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the joystick's RectTransform. This can be useful if you want a larger area of the screen to act as a joystick.")]
	private TouchRegion _touchRegion; // 0x188
	[Tooltip("If True, hovers/clicks/touches on the local joystick will be ignored and only Touch Region touches will be used. Otherwise, both touches on the joystick and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useTouchRegionOnly; // 0x190
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If True, the joystick will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a joystick and have the joystick graphics follow the users touches. This only has an effect if a Touch Region is set.")]
	private bool _moveToTouchPosition; // 0x191
	[Tooltip("If Move To Touch Position is enabled, this will make the joystick return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _returnOnRelease; // 0x192
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("If True, the joystick will follow the touch around until released. This setting overrides Move To Touch Position.")]
	private bool _followTouchPosition; // 0x193
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Should the joystick animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	private bool _animateOnMoveToTouch; // 0x194
	[CustomObfuscation(rename = False)]
	[Range(0, 20)]
	[Tooltip("The speed at which the joystick will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
	[SerializeField]
	private float _moveToTouchSpeed; // 0x198
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Should the joystick animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
	private bool _animateOnReturn; // 0x19C
	[Range(0, 20)]
	[Tooltip("The speed at which the joystick will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _returnSpeed; // 0x1A0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
	private bool _manageRaycasting; // 0x1A4
	private bool _useXAxis; // 0x1A5
	private bool _useYAxis; // 0x1A6
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<TouchJoystick.IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers; // 0x1A8
	private NnYCCzVlyuIQPbVMmKTauUbsbKOT.HierarchyEventHelper<TouchJoystick.IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers; // 0x1B0
	private TouchRegion _workingTouchRegion; // 0x1B8
	private Vector2 _origAnchoredPosition; // 0x1C0
	private Vector2 _origStickAnchoredPosition; // 0x1C8
	private Vector2 _lastPressAnchoredPosition; // 0x1D0
	private bool _isMoving; // 0x1D8
	private bool _isMovedFromDefaultPosition; // 0x1D9
	private TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr _moveDirection; // 0x1DC
	private int _pointerId; // 0x1E0
	private int _realMousePointerId; // 0x1E4
	private bool eZThheVBDPbmBrDNEpgunwPUMELi; // 0x1E8
	private bool DYRrDmWzJNeoXkaUDrhKmWzPmQdE; // 0x1E9
	private bool _pointerDownIsFake; // 0x1EA
	private Vector2 _lastPressStartingValue; // 0x1EC
	private TouchJoystick.uWERcVPoBHxxZBFMkRCVzAZCcqIn _lastClaimSource; // 0x1F4
	private float _touchStartTime; // 0x1F8
	private Vector2 _touchStartPosition; // 0x1FC
	private IEnumerator _coroutineMove; // 0x208
	private GyARYZsrnhudYCZNzjVwfKSYjxyf _imageRaycastHelper; // 0x210
	private int _calculatedStickRange_lastUpdatedFrame; // 0x218
	private int _lastTapFrame; // 0x21C
	private bool _isEligibleForTap; // 0x220
	private float __calculatedStickRange_cachedValue; // 0x224
	private Action<TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr> __moveStartedDelegate; // 0x228
	private Action<TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr> __moveEndedDelegate; // 0x230
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when the joystick value changes.")]
	[SerializeField]
	private TouchJoystick.ValueChangedEventHandler _onValueChanged; // 0x238
	[SerializeField]
	[Tooltip("Event sent when the joystick's stick position changes.")]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.ValueChangedEventHandler _onStickPositionChanged; // 0x240
	[Tooltip("Event sent when the joystick is touched.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.TouchStartedEventHandler _onTouchStarted; // 0x248
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private TouchJoystick.TouchEndedEventHandler _onTouchEnded; // 0x250
	[CustomObfuscation(rename = False)]
	[Tooltip("Event sent when the touch pad is tapped. This event will only be sent if allowTap is True.")]
	[SerializeField]
	private TouchJoystick.TapEventHandler _onTap; // 0x258
	private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x260
	private static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; // 0x0
	private static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; // 0x8

	// Properties
	public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get; }
	public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get; }
	public RectTransform stickTransform { get; set; }
	public TouchJoystick.JoystickMode joystickMode { get; set; }
	public float digitalModeDeadZone { get; set; }
	public float stickRange { get; set; }
	public bool scaleStickRange { get; set; }
	private TouchJoystick.StickBounds GWVQFhQhtlfnhydNEjOLhZoxaZUp { get; set; }
	public TouchJoystick.AxisDirection axesToUse { get; set; }
	public TouchJoystick.SnapDirections snapDirections { get; set; }
	public bool snapStickToTouch { get; set; }
	public bool centerStickOnRelease { get; set; }
	public bool activateOnSwipeIn { get; set; }
	public bool stayActiveOnSwipeOut { get; set; }
	public bool allowTap { get; set; }
	public float tapTimeout { get; set; }
	public int tapDistanceLimit { get; set; }
	public TouchRegion touchRegion { get; set; }
	public bool useTouchRegionOnly { get; set; }
	public bool moveToTouchPosition { get; set; }
	public bool returnOnRelease { get; set; }
	public bool followTouchPosition { get; set; }
	public bool animateOnMoveToTouch { get; set; }
	public float moveToTouchSpeed { get; set; }
	public bool animateOnReturn { get; set; }
	public float returnSpeed { get; set; }
	public bool manageRaycasting { get; set; }
	public AxisCalibration horizontalAxisCalibration { get; }
	public AxisCalibration verticalAxisCalibration { get; }
	[Obsolete("Use axis2DCalibration instead.", False)]
	public Axis2DCalibration deadZoneType { get; }
	public Axis2DCalibration axis2DCalibration { get; }
	public int pointerId { get; set; }
	public bool hasPointer { get; }
	private bool IowafjyHUVoxiQikSXXCALLyEpEj { get; }
	internal StandaloneAxis2D qJPTnOxGtIfzUwfesgYdPjioFarg { get; }
	private Action<TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr> YqKdtPIbCfzZSEsVDjeeGhxEfnxfA { get; }
	private Action<TouchJoystick.rbuzxWLFMxwXclvlXVOrpqFksuhr> DMVzYWlsTWDlSMJVbLSLPoVMByFCA { get; }
	private int xGMGAxPRsDCIxDLgDgQzHUpXHDGFA { get; }
	private RectTransform oiyMeofkzQtEyCTlDxLokoolZCnD { get; }
	private float kmetpDlZwnrxQqcCylkMIoeKIcpt { get; }
	internal static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IValueChangedHandler, Vector2> WTgngURCwWdZKnzMqZRelVffGpVG { get; }
	internal static NnYCCzVlyuIQPbVMmKTauUbsbKOT.EventFunction<TouchJoystick.IStickPositionChangedHandler, Vector2> mMorOUGbqXfJPQEIXedasyJwxmTE { get; }

	// Methods

	// RVA: 0x19A2F10 Offset: 0x19A2110 VA: 0x1819A2F10
	public CustomControllerElementTargetSetForFloat get_horizontalAxisCustomControllerElement() { }

	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	public CustomControllerElementTargetSetForFloat get_verticalAxisCustomControllerElement() { }

	// RVA: 0x78BCB0 Offset: 0x78AEB0 VA: 0x18078BCB0
	public CustomControllerElementTargetSetForBoolean get_tapCustomControllerElement() { }

	// RVA: 0x794D90 Offset: 0x793F90 VA: 0x180794D90
	public RectTransform get_stickTransform() { }

	// RVA: 0x19AF640 Offset: 0x19AE840 VA: 0x1819AF640
	public void set_stickTransform(RectTransform value) { }

	// RVA: 0x7CBED0 Offset: 0x7CB0D0 VA: 0x1807CBED0
	public TouchJoystick.JoystickMode get_joystickMode() { }

	// RVA: 0x19AF390 Offset: 0x19AE590 VA: 0x1819AF390
	public void set_joystickMode(TouchJoystick.JoystickMode value) { }

	// RVA: 0x19AD0C0 Offset: 0x19AC2C0 VA: 0x1819AD0C0
	public float get_digitalModeDeadZone() { }

	// RVA: 0x19AF310 Offset: 0x19AE510 VA: 0x1819AF310
	public void set_digitalModeDeadZone(float value) { }

	// RVA: 0x19AD220 Offset: 0x19AC420 VA: 0x1819AD220
	public float get_stickRange() { }

	// RVA: 0x19AF5E0 Offset: 0x19AE7E0 VA: 0x1819AF5E0
	public void set_stickRange(float value) { }

	// RVA: 0x19A2DB0 Offset: 0x19A1FB0 VA: 0x1819A2DB0
	public bool get_scaleStickRange() { }

	// RVA: 0x19A3BD0 Offset: 0x19A2DD0 VA: 0x1819A3BD0
	public void set_scaleStickRange(bool value) { }

	// RVA: 0x19AF910 Offset: 0x19AEB10 VA: 0x1819AF910
	private TouchJoystick.StickBounds uwpgrbJowhNlRUYNPCgEASzlDsWAb() { }

	// RVA: 0x19AA180 Offset: 0x19A9380 VA: 0x1819AA180
	private void KmliRrIeJgezIiYylWnNNNWyNsyT(TouchJoystick.StickBounds ) { }

	// RVA: 0x19AD080 Offset: 0x19AC280 VA: 0x1819AD080
	public TouchJoystick.AxisDirection get_axesToUse() { }

	// RVA: 0x19AF2A0 Offset: 0x19AE4A0 VA: 0x1819AF2A0
	public void set_axesToUse(TouchJoystick.AxisDirection value) { }

	// RVA: 0x19AD180 Offset: 0x19AC380 VA: 0x1819AD180
	public TouchJoystick.SnapDirections get_snapDirections() { }

	// RVA: 0x19AF550 Offset: 0x19AE750 VA: 0x1819AF550
	public void set_snapDirections(TouchJoystick.SnapDirections value) { }

	// RVA: 0x19A2E20 Offset: 0x19A2020 VA: 0x1819A2E20
	public bool get_snapStickToTouch() { }

	// RVA: 0x19AF580 Offset: 0x19AE780 VA: 0x1819AF580
	public void set_snapStickToTouch(bool value) { }

	// RVA: 0x19AD0B0 Offset: 0x19AC2B0 VA: 0x1819AD0B0
	public bool get_centerStickOnRelease() { }

	// RVA: 0x19AF2E0 Offset: 0x19AE4E0 VA: 0x1819AF2E0
	public void set_centerStickOnRelease(bool value) { }

	// RVA: 0x19AD040 Offset: 0x19AC240 VA: 0x1819AD040
	public bool get_activateOnSwipeIn() { }

	// RVA: 0x19AF1E0 Offset: 0x19AE3E0 VA: 0x1819AF1E0
	public void set_activateOnSwipeIn(bool value) { }

	// RVA: 0x19AD190 Offset: 0x19AC390 VA: 0x1819AD190
	public bool get_stayActiveOnSwipeOut() { }

	// RVA: 0x19AF5B0 Offset: 0x19AE7B0 VA: 0x1819AF5B0
	public void set_stayActiveOnSwipeOut(bool value) { }

	// RVA: 0x19AD050 Offset: 0x19AC250 VA: 0x1819AD050
	public bool get_allowTap() { }

	// RVA: 0x19AF210 Offset: 0x19AE410 VA: 0x1819AF210
	public void set_allowTap(bool value) { }

	// RVA: 0x19AD230 Offset: 0x19AC430 VA: 0x1819AD230
	public float get_tapTimeout() { }

	// RVA: 0x19AF720 Offset: 0x19AE920 VA: 0x1819AF720
	public void set_tapTimeout(float value) { }

	// RVA: 0x72F740 Offset: 0x72E940 VA: 0x18072F740
	public int get_tapDistanceLimit() { }

	// RVA: 0x19AF6D0 Offset: 0x19AE8D0 VA: 0x1819AF6D0
	public void set_tapDistanceLimit(int value) { }

	// RVA: 0x72F730 Offset: 0x72E930 VA: 0x18072F730
	public TouchRegion get_touchRegion() { }

	// RVA: 0x19AF770 Offset: 0x19AE970 VA: 0x1819AF770
	public void set_touchRegion(TouchRegion value) { }

	// RVA: 0x19AD240 Offset: 0x19AC440 VA: 0x1819AD240
	public bool get_useTouchRegionOnly() { }

	// RVA: 0x19AF800 Offset: 0x19AEA00 VA: 0x1819AF800
	public void set_useTouchRegionOnly(bool value) { }

	// RVA: 0x19AD130 Offset: 0x19AC330 VA: 0x1819AD130
	public bool get_moveToTouchPosition() { }

	// RVA: 0x19AF420 Offset: 0x19AE620 VA: 0x1819AF420
	public void set_moveToTouchPosition(bool value) { }

	// RVA: 0x19AD160 Offset: 0x19AC360 VA: 0x1819AD160
	public bool get_returnOnRelease() { }

	// RVA: 0x19AF4C0 Offset: 0x19AE6C0 VA: 0x1819AF4C0
	public void set_returnOnRelease(bool value) { }

	// RVA: 0x19AD0D0 Offset: 0x19AC2D0 VA: 0x1819AD0D0
	public bool get_followTouchPosition() { }

	// RVA: 0x19AF360 Offset: 0x19AE560 VA: 0x1819AF360
	public void set_followTouchPosition(bool value) { }

	// RVA: 0x19AD060 Offset: 0x19AC260 VA: 0x1819AD060
	public bool get_animateOnMoveToTouch() { }

	// RVA: 0x19AF240 Offset: 0x19AE440 VA: 0x1819AF240
	public void set_animateOnMoveToTouch(bool value) { }

	// RVA: 0x19AD140 Offset: 0x19AC340 VA: 0x1819AD140
	public float get_moveToTouchSpeed() { }

	// RVA: 0x19AF450 Offset: 0x19AE650 VA: 0x1819AF450
	public void set_moveToTouchSpeed(float value) { }

	// RVA: 0x19AD070 Offset: 0x19AC270 VA: 0x1819AD070
	public bool get_animateOnReturn() { }

	// RVA: 0x19AF270 Offset: 0x19AE470 VA: 0x1819AF270
	public void set_animateOnReturn(bool value) { }

	// RVA: 0x19AD170 Offset: 0x19AC370 VA: 0x1819AD170
	public float get_returnSpeed() { }

	// RVA: 0x19AF4F0 Offset: 0x19AE6F0 VA: 0x1819AF4F0
	public void set_returnSpeed(float value) { }

	// RVA: 0x19AD120 Offset: 0x19AC320 VA: 0x1819AD120
