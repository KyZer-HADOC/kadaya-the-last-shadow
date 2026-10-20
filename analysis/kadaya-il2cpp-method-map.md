# Kadaya IL2CPP method map

Generated in GitHub Actions cloud from extracted Android game binaries.
This report does not edit the APK or any map/level files.
Dumper exit code: 134

## Dumper log (last 60 lines)
Initializing metadata...
Metadata Version: 31
Initializing il2cpp file...
Applying relocations...
WARNING: find JNI_OnLoad
ERROR: This file may be protected.
Il2Cpp Version: 31
Searching...
CodeRegistration : 2e7ed50
MetadataRegistration : 2f71000
Dumping...
Done!
Generate struct...
Done!
Generate dummy dll...
Done!
Press any key to exit...
Unhandled exception. System.InvalidOperationException: Cannot read keys when either application does not have a console or when console input has been redirected. Try Console.Read.
   at System.ConsolePal.ReadKey(Boolean intercept)
   at Il2CppDumper.Program.Main(String[] args) in C:\projects\il2cppdumper\Il2CppDumper\Program.cs:line 109

## Output files
- DummyDll/Assembly-CSharp-firstpass.dll — 156,160 bytes
- DummyDll/Assembly-CSharp.dll — 1,671,168 bytes
- DummyDll/DOTween.dll — 237,568 bytes
- DummyDll/DOTweenPro.dll — 16,896 bytes
- DummyDll/Il2CppDummyDll.dll — 4,096 bytes
- DummyDll/IngameDebugConsole.Runtime.dll — 73,216 bytes
- DummyDll/Mono.Security.dll — 124,928 bytes
- DummyDll/Newtonsoft.Json.dll — 463,872 bytes
- DummyDll/System.Configuration.dll — 5,632 bytes
- DummyDll/System.Core.dll — 597,504 bytes
- DummyDll/System.Data.dll — 577,024 bytes
- DummyDll/System.Drawing.dll — 24,064 bytes
- DummyDll/System.Numerics.dll — 28,160 bytes
- DummyDll/System.Runtime.Serialization.dll — 4,096 bytes
- DummyDll/System.Xml.Linq.dll — 41,472 bytes
- DummyDll/System.Xml.dll — 1,328,640 bytes
- DummyDll/System.dll — 963,072 bytes
- DummyDll/Unity.LevelPlay.dll — 100,352 bytes
- DummyDll/Unity.Purchasing.AppleMacosStub.dll — 3,584 bytes
- DummyDll/Unity.Purchasing.AppleStub.dll — 3,584 bytes
- DummyDll/Unity.Purchasing.Security.dll — 28,672 bytes
- DummyDll/Unity.Purchasing.SecurityCore.dll — 8,704 bytes
- DummyDll/Unity.Purchasing.Stores.dll — 135,168 bytes
- DummyDll/Unity.Purchasing.Utilities.dll — 18,944 bytes
- DummyDll/Unity.Purchasing.dll — 190,976 bytes
- DummyDll/Unity.Services.Analytics.dll — 54,784 bytes
- DummyDll/Unity.Services.Core.Configuration.dll — 8,704 bytes
- DummyDll/Unity.Services.Core.Device.dll — 5,632 bytes
- DummyDll/Unity.Services.Core.Environments.Internal.dll — 2,560 bytes
- DummyDll/Unity.Services.Core.Internal.dll — 36,864 bytes
- DummyDll/Unity.Services.Core.Registration.dll — 13,824 bytes
- DummyDll/Unity.Services.Core.Scheduler.dll — 7,168 bytes
- DummyDll/Unity.Services.Core.Telemetry.dll — 4,096 bytes
- DummyDll/Unity.Services.Core.Threading.dll — 2,048 bytes
- DummyDll/Unity.Services.Core.dll — 7,680 bytes
- DummyDll/Unity.TextMeshPro.dll — 410,624 bytes
- DummyDll/UnityEngine.AIModule.dll — 8,192 bytes
- DummyDll/UnityEngine.AndroidJNIModule.dll — 102,912 bytes
- DummyDll/UnityEngine.AnimationModule.dll — 30,720 bytes
- DummyDll/UnityEngine.AudioModule.dll — 17,408 bytes
- DummyDll/UnityEngine.CoreModule.dll — 782,848 bytes
- DummyDll/UnityEngine.GridModule.dll — 2,560 bytes
- DummyDll/UnityEngine.HierarchyCoreModule.dll — 57,856 bytes
- DummyDll/UnityEngine.IMGUIModule.dll — 151,040 bytes
- DummyDll/UnityEngine.InputForUIModule.dll — 54,272 bytes
- DummyDll/UnityEngine.InputLegacyModule.dll — 20,480 bytes
- DummyDll/UnityEngine.JSONSerializeModule.dll — 3,584 bytes
- DummyDll/UnityEngine.ParticleSystemModule.dll — 22,016 bytes
- DummyDll/UnityEngine.Physics2DModule.dll — 32,768 bytes
- DummyDll/UnityEngine.PhysicsModule.dll — 43,520 bytes
- DummyDll/UnityEngine.PropertiesModule.dll — 156,672 bytes
- DummyDll/UnityEngine.SharedInternalsModule.dll — 15,872 bytes
- DummyDll/UnityEngine.SpriteShapeModule.dll — 2,560 bytes
- DummyDll/UnityEngine.TextCoreFontEngineModule.dll — 50,688 bytes
- DummyDll/UnityEngine.TextCoreTextEngineModule.dll — 214,528 bytes
- DummyDll/UnityEngine.TextRenderingModule.dll — 19,456 bytes
- DummyDll/UnityEngine.TilemapModule.dll — 3,072 bytes
- DummyDll/UnityEngine.UI.dll — 379,392 bytes
- DummyDll/UnityEngine.UIElementsModule.dll — 2,348,544 bytes
- DummyDll/UnityEngine.UIModule.dll — 31,232 bytes
- DummyDll/UnityEngine.UnityAnalyticsCommonModule.dll — 18,432 bytes
- DummyDll/UnityEngine.UnityAnalyticsModule.dll — 6,656 bytes
- DummyDll/UnityEngine.UnityConsentModule.dll — 4,096 bytes
- DummyDll/UnityEngine.UnityWebRequestModule.dll — 28,160 bytes
- DummyDll/UnityEngine.WindModule.dll — 2,560 bytes
- DummyDll/UnityEngine.dll — 2,048 bytes
- DummyDll/__Generated — 2,560 bytes
- DummyDll/mscorlib.dll — 2,437,632 bytes
- dump.cs — 20,292,231 bytes
- il2cpp.h — 54,088,049 bytes
- script.json — 55,407,071 bytes
- stringliteral.json — 1,095,289 bytes

## Matching class and method declarations

### dump.cs, line 467
	public abstract X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0);
}

// Namespace: Mono
internal interface ISystemDependencyProvider // TypeDefIndex: 16
{
	// Properties
	public abstract ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISystemCertificateProvider get_CertificateProvider();
}


### dump.cs, line 1464
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x2409824 Offset: 0x2405824 VA: 0x2409824
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x240984C Offset: 0x240584C VA: 0x240984C
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x2409A5C Offset: 0x2405A5C VA: 0x2409A5C
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x2409AD8 Offset: 0x2405AD8 VA: 0x2409AD8
	private bool IsSafe(int i) { }

	// RVA: 0x2409B34 Offset: 0x2405B34 VA: 0x2409B34 Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x2409B50 Offset: 0x2405B50 VA: 0x2409B50
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x2409D98 Offset: 0x2405D98 VA: 0x2409D98

### dump.cs, line 2627
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 88
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x241C834 Offset: 0x2418834 VA: 0x241C834
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x241C88C Offset: 0x241888C VA: 0x241C88C
	private void FreeHandle() { }

	// RVA: 0x241C8E8 Offset: 0x24188E8 VA: 0x241C8E8
	public void .ctor(string password) { }

	// RVA: 0x241C924 Offset: 0x2418924 VA: 0x241C924 Slot: 7
	protected override bool ReleaseHandle() { }

### dump.cs, line 2635
	// Methods

	// RVA: 0x241C834 Offset: 0x2418834 VA: 0x241C834
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x241C88C Offset: 0x241888C VA: 0x241C88C
	private void FreeHandle() { }

	// RVA: 0x241C8E8 Offset: 0x24188E8 VA: 0x241C8E8
	public void .ctor(string password) { }

	// RVA: 0x241C924 Offset: 0x2418924 VA: 0x241C924 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x241C95C Offset: 0x241895C VA: 0x241C95C Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x241C9CC Offset: 0x24189CC VA: 0x241C9CC Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x241C9F0 Offset: 0x24189F0 VA: 0x241C9F0

### dump.cs, line 2641
	private void FreeHandle() { }

	// RVA: 0x241C8E8 Offset: 0x24188E8 VA: 0x241C8E8
	public void .ctor(string password) { }

	// RVA: 0x241C924 Offset: 0x2418924 VA: 0x241C924 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x241C95C Offset: 0x241895C VA: 0x241C95C Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x241C9CC Offset: 0x24189CC VA: 0x241C9CC Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x241C9F0 Offset: 0x24189F0 VA: 0x241C9F0
	internal string Mono_DangerousGetString() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 89
{

### dump.cs, line 12224
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
private enum Guid.GuidParseThrowStyle // TypeDefIndex: 195
{
	// Fields

### dump.cs, line 12228
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
private enum Guid.GuidParseThrowStyle // TypeDefIndex: 195
{
	// Fields
	public int value__; // 0x0
	public const Guid.GuidParseThrowStyle None = 0;
	public const Guid.GuidParseThrowStyle All = 1;
	public const Guid.GuidParseThrowStyle AllButOverflow = 2;

### dump.cs, line 12358
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x25696F0 Offset: 0x25656F0 VA: 0x25696F0
	private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x256A588 Offset: 0x2566588 VA: 0x256A588
	private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x256A90C Offset: 0x256690C VA: 0x256A90C
	private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x256A55C Offset: 0x256655C VA: 0x256A55C
	private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x256A71C Offset: 0x256671C VA: 0x256A71C
	private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x256A5CC Offset: 0x25665CC VA: 0x256A5CC
	private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x256A244 Offset: 0x2566244 VA: 0x256A244

### dump.cs, line 87040
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x2462D00 Offset: 0x245ED00 VA: 0x2462D00
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}

// Namespace: System.Security.Principal
public interface IIdentity // TypeDefIndex: 781
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

### dump.cs, line 108990
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
internal static class GlobalizationMode // TypeDefIndex: 1326
{
	// Fields
	[CompilerGenerated]

### dump.cs, line 219194
	public void .ctor(string label) { }

	// RVA: 0x2DA0488 Offset: 0x2D9C488 VA: 0x2DA0488
	public void .ctor(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) { }

	// RVA: 0x2DA074C Offset: 0x2D9C74C VA: 0x2DA074C Slot: 141
	public override string get_value() { }

	// RVA: 0x2DA0794 Offset: 0x2D9C794 VA: 0x2DA0794 Slot: 142
	public override void set_value(string value) { }

	// RVA: 0x2DA08B8 Offset: 0x2D9C8B8 VA: 0x2DA08B8 Slot: 152
	public override void SetValueWithoutNotify(string newValue) { }

	// RVA: 0x2DA0A34 Offset: 0x2D9CA34 VA: 0x2DA0A34 Slot: 157
	internal override void UpdateTextFromValue() { }

	[EventInterest(new[] { typeof(FocusOutEvent) })]
	// RVA: 0x2DA0A94 Offset: 0x2D9CA94 VA: 0x2DA0A94 Slot: 8
	protected override void HandleEventBubbleUp(EventBase evt) { }


### dump.cs, line 219231
{
	// Fields
	private UxmlIntAttributeDescription m_MaxLength; // 0x0
	private UxmlBoolAttributeDescription m_Password; // 0x0
	private UxmlStringAttributeDescription m_MaskCharacter; // 0x0
	private UxmlStringAttributeDescription m_PlaceholderText; // 0x0
	private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; // 0x0
	private UxmlBoolAttributeDescription m_IsReadOnly; // 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; // 0x0
	private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; // 0x0
	private UxmlBoolAttributeDescription m_SelectAllOnMouseUp; // 0x0
	private UxmlBoolAttributeDescription m_SelectAllOnFocus; // 0x0
	private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; // 0x0
	private UxmlBoolAttributeDescription m_SelectLineByTripleClick; // 0x0
	private UxmlBoolAttributeDescription m_EmojiFallbackSupport; // 0x0
	private UxmlBoolAttributeDescription m_HideMobileInput; // 0x0
	private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType; // 0x0
	private UxmlBoolAttributeDescription m_AutoCorrection; // 0x0

	// Methods


### dump.cs, line 220281
	internal static readonly BindingId hidePlaceholderOnFocusProperty; // 0x0
	internal static readonly BindingId keyboardTypeProperty; // 0x0
	internal static readonly BindingId isReadOnlyProperty; // 0x0
	internal static readonly BindingId isPasswordFieldProperty; // 0x0
	internal static readonly BindingId textSelectionProperty; // 0x0
	internal static readonly BindingId textEditionProperty; // 0x0
	internal static readonly BindingId placeholderTextProperty; // 0x0
	internal static readonly BindingId cursorIndexProperty; // 0x0
	internal static readonly BindingId cursorPositionProperty; // 0x0
	internal static readonly BindingId selectIndexProperty; // 0x0
	internal static readonly BindingId selectAllOnFocusProperty; // 0x0
	internal static readonly BindingId selectAllOnMouseUpProperty; // 0x0
	internal static readonly BindingId maxLengthProperty; // 0x0
	internal static readonly BindingId doubleClickSelectsWordProperty; // 0x0
	internal static readonly BindingId tripleClickSelectsLineProperty; // 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; // 0x0
	internal static readonly BindingId isDelayedProperty; // 0x0
	internal static readonly BindingId maskCharProperty; // 0x0
	internal static readonly BindingId verticalScrollerVisibilityProperty; // 0x0
	private static CustomStyleProperty<Color> s_SelectionColorProperty; // 0x0
	private static CustomStyleProperty<Color> s_CursorColorProperty; // 0x0

### dump.cs, line 220291
	internal static readonly BindingId selectAllOnFocusProperty; // 0x0
	internal static readonly BindingId selectAllOnMouseUpProperty; // 0x0
	internal static readonly BindingId maxLengthProperty; // 0x0
	internal static readonly BindingId doubleClickSelectsWordProperty; // 0x0
	internal static readonly BindingId tripleClickSelectsLineProperty; // 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; // 0x0
	internal static readonly BindingId isDelayedProperty; // 0x0
	internal static readonly BindingId maskCharProperty; // 0x0
	internal static readonly BindingId verticalScrollerVisibilityProperty; // 0x0
	private static CustomStyleProperty<Color> s_SelectionColorProperty; // 0x0
	private static CustomStyleProperty<Color> s_CursorColorProperty; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	internal static readonly string multilineContainerClassName; // 0x0
	public static readonly string singleLineInputUssClassName; // 0x0
	public static readonly string multilineInputUssClassName; // 0x0
	public static readonly string placeholderUssClassName; // 0x0
	internal static readonly string multilineInputWithScrollViewUssClassName; // 0x0
	public static readonly string textInputUssName; // 0x0
	private TextInputBaseField.TextInputBase<TValueType> m_TextInputBase; // 0x0

### dump.cs, line 220312
	internal bool m_UpdateTextFromValue; // 0x0

	// Properties
	internal bool password { set; }
	internal bool readOnly { set; }
	[CreateProperty]
	internal string placeholderText { get; set; }
	[CreateProperty]
	internal bool hidePlaceholderOnFocus { get; set; }
	protected internal TextInputBaseField.TextInputBase<TValueType> textInputBase { get; }
	[CreateProperty(ReadOnly = True)]
	public ITextSelection textSelection { get; }
	[CreateProperty(ReadOnly = True)]
	public ITextEdition textEdition { get; }
	protected Action<bool> onIsReadOnlyChanged { get; set; }
	[CreateProperty]
	public bool isReadOnly { get; set; }
	[CreateProperty]
	public bool isPasswordField { get; set; }
	[CreateProperty]
	public bool autoCorrection { get; set; }

### dump.cs, line 220327
	[CreateProperty]
	public bool isReadOnly { get; set; }
	[CreateProperty]
	public bool isPasswordField { get; set; }
	[CreateProperty]
	public bool autoCorrection { get; set; }
	[CreateProperty]
	public bool hideMobileInput { get; set; }
	[CreateProperty]
	public TouchScreenKeyboardType keyboardType { get; set; }
	[CreateProperty]
	public int maxLength { get; set; }
	[CreateProperty]
	public bool isDelayed { get; set; }
	[CreateProperty]
	public char maskChar { get; set; }
	[CreateProperty]
	public int cursorIndex { get; set; }
	[CreateProperty(ReadOnly = True)]
	public Vector2 cursorPosition { get; }
	[CreateProperty]

### dump.cs, line 220351
	[CreateProperty]
	public bool selectAllOnMouseUp { get; set; }
	[CreateProperty]
	public bool doubleClickSelectsWord { get; set; }
	[CreateProperty]
	public bool tripleClickSelectsLine { get; set; }
	public string text { get; set; }
	[CreateProperty]
	public bool emojiFallbackSupport { get; set; }
	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility { get; set; }
	internal override bool canSwitchToMixedValue { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void set_password(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8C40 Offset: 0x21C4C40 VA: 0x21C8C40
	|-TextInputBaseField<double>.set_password

### dump.cs, line 220364
	// Methods

	// RVA: -1 Offset: -1
	internal void set_password(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8C40 Offset: 0x21C4C40 VA: 0x21C8C40
	|-TextInputBaseField<double>.set_password
	|
	|-RVA: 0x21CD810 Offset: 0x21C9810 VA: 0x21CD810
	|-TextInputBaseField<Hash128>.set_password
	|
	|-RVA: 0x21D2400 Offset: 0x21CE400 VA: 0x21D2400
	|-TextInputBaseField<int>.set_password
	|
	|-RVA: 0x21D6FD8 Offset: 0x21D2FD8 VA: 0x21D6FD8
	|-TextInputBaseField<long>.set_password
	|
	|-RVA: 0x21DBBB0 Offset: 0x21D7BB0 VA: 0x21DBBB0
	|-TextInputBaseField<object>.set_password
	|

### dump.cs, line 220380
	|-TextInputBaseField<long>.set_password
	|
	|-RVA: 0x21DBBB0 Offset: 0x21D7BB0 VA: 0x21DBBB0
	|-TextInputBaseField<object>.set_password
	|
	|-RVA: 0x21E0788 Offset: 0x21DC788 VA: 0x21E0788
	|-TextInputBaseField<float>.set_password
	|
	|-RVA: 0x21E5358 Offset: 0x21E1358 VA: 0x21E5358
	|-TextInputBaseField<uint>.set_password
	|
	|-RVA: 0x21E9F30 Offset: 0x21E5F30 VA: 0x21E9F30
	|-TextInputBaseField<ulong>.set_password
	|
	|-RVA: 0x21EEB08 Offset: 0x21EAB08 VA: 0x21EEB08
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_password
	*/

	// RVA: -1 Offset: -1
	internal void set_readOnly(bool value) { }
	/* GenericInstMethod :

### dump.cs, line 220383
	|-TextInputBaseField<object>.set_password
	|
	|-RVA: 0x21E0788 Offset: 0x21DC788 VA: 0x21E0788
	|-TextInputBaseField<float>.set_password
	|
	|-RVA: 0x21E5358 Offset: 0x21E1358 VA: 0x21E5358
	|-TextInputBaseField<uint>.set_password
	|
	|-RVA: 0x21E9F30 Offset: 0x21E5F30 VA: 0x21E9F30
	|-TextInputBaseField<ulong>.set_password
	|
	|-RVA: 0x21EEB08 Offset: 0x21EAB08 VA: 0x21EEB08
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_password
	*/

	// RVA: -1 Offset: -1
	internal void set_readOnly(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8CF4 Offset: 0x21C4CF4 VA: 0x21C8CF4
	|-TextInputBaseField<double>.set_readOnly

### dump.cs, line 220386
	|-TextInputBaseField<float>.set_password
	|
	|-RVA: 0x21E5358 Offset: 0x21E1358 VA: 0x21E5358
	|-TextInputBaseField<uint>.set_password
	|
	|-RVA: 0x21E9F30 Offset: 0x21E5F30 VA: 0x21E9F30
	|-TextInputBaseField<ulong>.set_password
	|
	|-RVA: 0x21EEB08 Offset: 0x21EAB08 VA: 0x21EEB08
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_password
	*/

	// RVA: -1 Offset: -1
	internal void set_readOnly(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8CF4 Offset: 0x21C4CF4 VA: 0x21C8CF4
	|-TextInputBaseField<double>.set_readOnly
	|
	|-RVA: 0x21CD8C4 Offset: 0x21C98C4 VA: 0x21CD8C4
	|-TextInputBaseField<Hash128>.set_readOnly

### dump.cs, line 220389
	|-TextInputBaseField<uint>.set_password
	|
	|-RVA: 0x21E9F30 Offset: 0x21E5F30 VA: 0x21E9F30
	|-TextInputBaseField<ulong>.set_password
	|
	|-RVA: 0x21EEB08 Offset: 0x21EAB08 VA: 0x21EEB08
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_password
	*/

	// RVA: -1 Offset: -1
	internal void set_readOnly(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8CF4 Offset: 0x21C4CF4 VA: 0x21C8CF4
	|-TextInputBaseField<double>.set_readOnly
	|
	|-RVA: 0x21CD8C4 Offset: 0x21C98C4 VA: 0x21CD8C4
	|-TextInputBaseField<Hash128>.set_readOnly
	|
	|-RVA: 0x21D24B4 Offset: 0x21CE4B4 VA: 0x21D24B4
	|-TextInputBaseField<int>.set_readOnly

### dump.cs, line 220392
	|-TextInputBaseField<ulong>.set_password
	|
	|-RVA: 0x21EEB08 Offset: 0x21EAB08 VA: 0x21EEB08
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_password
	*/

	// RVA: -1 Offset: -1
	internal void set_readOnly(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C8CF4 Offset: 0x21C4CF4 VA: 0x21C8CF4
	|-TextInputBaseField<double>.set_readOnly
	|
	|-RVA: 0x21CD8C4 Offset: 0x21C98C4 VA: 0x21CD8C4
	|-TextInputBaseField<Hash128>.set_readOnly
	|
	|-RVA: 0x21D24B4 Offset: 0x21CE4B4 VA: 0x21D24B4
	|-TextInputBaseField<int>.set_readOnly
	|
	|-RVA: 0x21D708C Offset: 0x21D308C VA: 0x21D708C
	|-TextInputBaseField<long>.set_readOnly

### dump.cs, line 220813
	*/

	// RVA: -1 Offset: -1
	public bool get_isPasswordField() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9898 Offset: 0x21C5898 VA: 0x21C9898
	|-TextInputBaseField<double>.get_isPasswordField
	|
	|-RVA: 0x21CE468 Offset: 0x21CA468 VA: 0x21CE468
	|-TextInputBaseField<Hash128>.get_isPasswordField
	|
	|-RVA: 0x21D3058 Offset: 0x21CF058 VA: 0x21D3058
	|-TextInputBaseField<int>.get_isPasswordField
	|
	|-RVA: 0x21D7C30 Offset: 0x21D3C30 VA: 0x21D7C30
	|-TextInputBaseField<long>.get_isPasswordField
	|
	|-RVA: 0x21DC808 Offset: 0x21D8808 VA: 0x21DC808
	|-TextInputBaseField<object>.get_isPasswordField
	|

### dump.cs, line 220829
	|-TextInputBaseField<long>.get_isPasswordField
	|
	|-RVA: 0x21DC808 Offset: 0x21D8808 VA: 0x21DC808
	|-TextInputBaseField<object>.get_isPasswordField
	|
	|-RVA: 0x21E13E0 Offset: 0x21DD3E0 VA: 0x21E13E0
	|-TextInputBaseField<float>.get_isPasswordField
	|
	|-RVA: 0x21E5FB0 Offset: 0x21E1FB0 VA: 0x21E5FB0
	|-TextInputBaseField<uint>.get_isPasswordField
	|
	|-RVA: 0x21EAB88 Offset: 0x21E6B88 VA: 0x21EAB88
	|-TextInputBaseField<ulong>.get_isPasswordField
	|
	|-RVA: 0x21EF9E4 Offset: 0x21EB9E4 VA: 0x21EF9E4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :

### dump.cs, line 220832
	|-TextInputBaseField<object>.get_isPasswordField
	|
	|-RVA: 0x21E13E0 Offset: 0x21DD3E0 VA: 0x21E13E0
	|-TextInputBaseField<float>.get_isPasswordField
	|
	|-RVA: 0x21E5FB0 Offset: 0x21E1FB0 VA: 0x21E5FB0
	|-TextInputBaseField<uint>.get_isPasswordField
	|
	|-RVA: 0x21EAB88 Offset: 0x21E6B88 VA: 0x21EAB88
	|-TextInputBaseField<ulong>.get_isPasswordField
	|
	|-RVA: 0x21EF9E4 Offset: 0x21EB9E4 VA: 0x21EF9E4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9944 Offset: 0x21C5944 VA: 0x21C9944
	|-TextInputBaseField<double>.set_isPasswordField

### dump.cs, line 220835
	|-TextInputBaseField<float>.get_isPasswordField
	|
	|-RVA: 0x21E5FB0 Offset: 0x21E1FB0 VA: 0x21E5FB0
	|-TextInputBaseField<uint>.get_isPasswordField
	|
	|-RVA: 0x21EAB88 Offset: 0x21E6B88 VA: 0x21EAB88
	|-TextInputBaseField<ulong>.get_isPasswordField
	|
	|-RVA: 0x21EF9E4 Offset: 0x21EB9E4 VA: 0x21EF9E4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9944 Offset: 0x21C5944 VA: 0x21C9944
	|-TextInputBaseField<double>.set_isPasswordField
	|
	|-RVA: 0x21CE514 Offset: 0x21CA514 VA: 0x21CE514
	|-TextInputBaseField<Hash128>.set_isPasswordField

### dump.cs, line 220838
	|-TextInputBaseField<uint>.get_isPasswordField
	|
	|-RVA: 0x21EAB88 Offset: 0x21E6B88 VA: 0x21EAB88
	|-TextInputBaseField<ulong>.get_isPasswordField
	|
	|-RVA: 0x21EF9E4 Offset: 0x21EB9E4 VA: 0x21EF9E4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9944 Offset: 0x21C5944 VA: 0x21C9944
	|-TextInputBaseField<double>.set_isPasswordField
	|
	|-RVA: 0x21CE514 Offset: 0x21CA514 VA: 0x21CE514
	|-TextInputBaseField<Hash128>.set_isPasswordField
	|
	|-RVA: 0x21D3104 Offset: 0x21CF104 VA: 0x21D3104
	|-TextInputBaseField<int>.set_isPasswordField

### dump.cs, line 220841
	|-TextInputBaseField<ulong>.get_isPasswordField
	|
	|-RVA: 0x21EF9E4 Offset: 0x21EB9E4 VA: 0x21EF9E4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9944 Offset: 0x21C5944 VA: 0x21C9944
	|-TextInputBaseField<double>.set_isPasswordField
	|
	|-RVA: 0x21CE514 Offset: 0x21CA514 VA: 0x21CE514
	|-TextInputBaseField<Hash128>.set_isPasswordField
	|
	|-RVA: 0x21D3104 Offset: 0x21CF104 VA: 0x21D3104
	|-TextInputBaseField<int>.set_isPasswordField
	|
	|-RVA: 0x21D7CDC Offset: 0x21D3CDC VA: 0x21D7CDC
	|-TextInputBaseField<long>.set_isPasswordField

### dump.cs, line 220845
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9944 Offset: 0x21C5944 VA: 0x21C9944
	|-TextInputBaseField<double>.set_isPasswordField
	|
	|-RVA: 0x21CE514 Offset: 0x21CA514 VA: 0x21CE514
	|-TextInputBaseField<Hash128>.set_isPasswordField
	|
	|-RVA: 0x21D3104 Offset: 0x21CF104 VA: 0x21D3104
	|-TextInputBaseField<int>.set_isPasswordField
	|
	|-RVA: 0x21D7CDC Offset: 0x21D3CDC VA: 0x21D7CDC
	|-TextInputBaseField<long>.set_isPasswordField
	|
	|-RVA: 0x21DC8B4 Offset: 0x21D88B4 VA: 0x21DC8B4
	|-TextInputBaseField<object>.set_isPasswordField
	|

### dump.cs, line 220861
	|-TextInputBaseField<long>.set_isPasswordField
	|
	|-RVA: 0x21DC8B4 Offset: 0x21D88B4 VA: 0x21DC8B4
	|-TextInputBaseField<object>.set_isPasswordField
	|
	|-RVA: 0x21E148C Offset: 0x21DD48C VA: 0x21E148C
	|-TextInputBaseField<float>.set_isPasswordField
	|
	|-RVA: 0x21E605C Offset: 0x21E205C VA: 0x21E605C
	|-TextInputBaseField<uint>.set_isPasswordField
	|
	|-RVA: 0x21EAC34 Offset: 0x21E6C34 VA: 0x21EAC34
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x21EFAA4 Offset: 0x21EBAA4 VA: 0x21EFAA4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public bool get_autoCorrection() { }
	/* GenericInstMethod :

### dump.cs, line 220864
	|-TextInputBaseField<object>.set_isPasswordField
	|
	|-RVA: 0x21E148C Offset: 0x21DD48C VA: 0x21E148C
	|-TextInputBaseField<float>.set_isPasswordField
	|
	|-RVA: 0x21E605C Offset: 0x21E205C VA: 0x21E605C
	|-TextInputBaseField<uint>.set_isPasswordField
	|
	|-RVA: 0x21EAC34 Offset: 0x21E6C34 VA: 0x21EAC34
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x21EFAA4 Offset: 0x21EBAA4 VA: 0x21EFAA4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public bool get_autoCorrection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9AFC Offset: 0x21C5AFC VA: 0x21C9AFC
	|-TextInputBaseField<double>.get_autoCorrection

### dump.cs, line 220867
	|-TextInputBaseField<float>.set_isPasswordField
	|
	|-RVA: 0x21E605C Offset: 0x21E205C VA: 0x21E605C
	|-TextInputBaseField<uint>.set_isPasswordField
	|
	|-RVA: 0x21EAC34 Offset: 0x21E6C34 VA: 0x21EAC34
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x21EFAA4 Offset: 0x21EBAA4 VA: 0x21EFAA4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public bool get_autoCorrection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9AFC Offset: 0x21C5AFC VA: 0x21C9AFC
	|-TextInputBaseField<double>.get_autoCorrection
	|
	|-RVA: 0x21CE6CC Offset: 0x21CA6CC VA: 0x21CE6CC
	|-TextInputBaseField<Hash128>.get_autoCorrection

### dump.cs, line 220870
	|-TextInputBaseField<uint>.set_isPasswordField
	|
	|-RVA: 0x21EAC34 Offset: 0x21E6C34 VA: 0x21EAC34
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x21EFAA4 Offset: 0x21EBAA4 VA: 0x21EFAA4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public bool get_autoCorrection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9AFC Offset: 0x21C5AFC VA: 0x21C9AFC
	|-TextInputBaseField<double>.get_autoCorrection
	|
	|-RVA: 0x21CE6CC Offset: 0x21CA6CC VA: 0x21CE6CC
	|-TextInputBaseField<Hash128>.get_autoCorrection
	|
	|-RVA: 0x21D32BC Offset: 0x21CF2BC VA: 0x21D32BC
	|-TextInputBaseField<int>.get_autoCorrection

### dump.cs, line 220873
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x21EFAA4 Offset: 0x21EBAA4 VA: 0x21EFAA4
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public bool get_autoCorrection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21C9AFC Offset: 0x21C5AFC VA: 0x21C9AFC
	|-TextInputBaseField<double>.get_autoCorrection
	|
	|-RVA: 0x21CE6CC Offset: 0x21CA6CC VA: 0x21CE6CC
	|-TextInputBaseField<Hash128>.get_autoCorrection
	|
	|-RVA: 0x21D32BC Offset: 0x21CF2BC VA: 0x21D32BC
	|-TextInputBaseField<int>.get_autoCorrection
	|
	|-RVA: 0x21D7E94 Offset: 0x21D3E94 VA: 0x21D7E94
	|-TextInputBaseField<long>.get_autoCorrection

### dump.cs, line 221549
	*/

	// RVA: -1 Offset: -1
	public bool get_doubleClickSelectsWord() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB364 Offset: 0x21C7364 VA: 0x21CB364
	|-TextInputBaseField<double>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21CFF44 Offset: 0x21CBF44 VA: 0x21CFF44
	|-TextInputBaseField<Hash128>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21D4B28 Offset: 0x21D0B28 VA: 0x21D4B28
	|-TextInputBaseField<int>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21D9700 Offset: 0x21D5700 VA: 0x21D9700
	|-TextInputBaseField<long>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21DE2D8 Offset: 0x21DA2D8 VA: 0x21DE2D8
	|-TextInputBaseField<object>.get_doubleClickSelectsWord
	|

### dump.cs, line 221565
	|-TextInputBaseField<long>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21DE2D8 Offset: 0x21DA2D8 VA: 0x21DE2D8
	|-TextInputBaseField<object>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21E2EAC Offset: 0x21DEEAC VA: 0x21E2EAC
	|-TextInputBaseField<float>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21E7A80 Offset: 0x21E3A80 VA: 0x21E7A80
	|-TextInputBaseField<uint>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21EC658 Offset: 0x21E8658 VA: 0x21EC658
	|-TextInputBaseField<ulong>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21F17BC Offset: 0x21ED7BC VA: 0x21F17BC
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :

### dump.cs, line 221568
	|-TextInputBaseField<object>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21E2EAC Offset: 0x21DEEAC VA: 0x21E2EAC
	|-TextInputBaseField<float>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21E7A80 Offset: 0x21E3A80 VA: 0x21E7A80
	|-TextInputBaseField<uint>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21EC658 Offset: 0x21E8658 VA: 0x21EC658
	|-TextInputBaseField<ulong>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21F17BC Offset: 0x21ED7BC VA: 0x21F17BC
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB410 Offset: 0x21C7410 VA: 0x21CB410
	|-TextInputBaseField<double>.set_doubleClickSelectsWord

### dump.cs, line 221571
	|-TextInputBaseField<float>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21E7A80 Offset: 0x21E3A80 VA: 0x21E7A80
	|-TextInputBaseField<uint>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21EC658 Offset: 0x21E8658 VA: 0x21EC658
	|-TextInputBaseField<ulong>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21F17BC Offset: 0x21ED7BC VA: 0x21F17BC
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB410 Offset: 0x21C7410 VA: 0x21CB410
	|-TextInputBaseField<double>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21CFFF0 Offset: 0x21CBFF0 VA: 0x21CFFF0
	|-TextInputBaseField<Hash128>.set_doubleClickSelectsWord

### dump.cs, line 221574
	|-TextInputBaseField<uint>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21EC658 Offset: 0x21E8658 VA: 0x21EC658
	|-TextInputBaseField<ulong>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21F17BC Offset: 0x21ED7BC VA: 0x21F17BC
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB410 Offset: 0x21C7410 VA: 0x21CB410
	|-TextInputBaseField<double>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21CFFF0 Offset: 0x21CBFF0 VA: 0x21CFFF0
	|-TextInputBaseField<Hash128>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21D4BD4 Offset: 0x21D0BD4 VA: 0x21D4BD4
	|-TextInputBaseField<int>.set_doubleClickSelectsWord

### dump.cs, line 221577
	|-TextInputBaseField<ulong>.get_doubleClickSelectsWord
	|
	|-RVA: 0x21F17BC Offset: 0x21ED7BC VA: 0x21F17BC
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB410 Offset: 0x21C7410 VA: 0x21CB410
	|-TextInputBaseField<double>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21CFFF0 Offset: 0x21CBFF0 VA: 0x21CFFF0
	|-TextInputBaseField<Hash128>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21D4BD4 Offset: 0x21D0BD4 VA: 0x21D4BD4
	|-TextInputBaseField<int>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21D97AC Offset: 0x21D57AC VA: 0x21D97AC
	|-TextInputBaseField<long>.set_doubleClickSelectsWord

### dump.cs, line 221581
	*/

	// RVA: -1 Offset: -1
	public void set_doubleClickSelectsWord(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB410 Offset: 0x21C7410 VA: 0x21CB410
	|-TextInputBaseField<double>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21CFFF0 Offset: 0x21CBFF0 VA: 0x21CFFF0
	|-TextInputBaseField<Hash128>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21D4BD4 Offset: 0x21D0BD4 VA: 0x21D4BD4
	|-TextInputBaseField<int>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21D97AC Offset: 0x21D57AC VA: 0x21D97AC
	|-TextInputBaseField<long>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21DE384 Offset: 0x21DA384 VA: 0x21DE384
	|-TextInputBaseField<object>.set_doubleClickSelectsWord
	|

### dump.cs, line 221597
	|-TextInputBaseField<long>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21DE384 Offset: 0x21DA384 VA: 0x21DE384
	|-TextInputBaseField<object>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21E2F58 Offset: 0x21DEF58 VA: 0x21E2F58
	|-TextInputBaseField<float>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21E7B2C Offset: 0x21E3B2C VA: 0x21E7B2C
	|-TextInputBaseField<uint>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21EC704 Offset: 0x21E8704 VA: 0x21EC704
	|-TextInputBaseField<ulong>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21F187C Offset: 0x21ED87C VA: 0x21F187C
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public bool get_tripleClickSelectsLine() { }
	/* GenericInstMethod :

### dump.cs, line 221600
	|-TextInputBaseField<object>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21E2F58 Offset: 0x21DEF58 VA: 0x21E2F58
	|-TextInputBaseField<float>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21E7B2C Offset: 0x21E3B2C VA: 0x21E7B2C
	|-TextInputBaseField<uint>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21EC704 Offset: 0x21E8704 VA: 0x21EC704
	|-TextInputBaseField<ulong>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21F187C Offset: 0x21ED87C VA: 0x21F187C
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public bool get_tripleClickSelectsLine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB5B8 Offset: 0x21C75B8 VA: 0x21CB5B8
	|-TextInputBaseField<double>.get_tripleClickSelectsLine

### dump.cs, line 221603
	|-TextInputBaseField<float>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21E7B2C Offset: 0x21E3B2C VA: 0x21E7B2C
	|-TextInputBaseField<uint>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21EC704 Offset: 0x21E8704 VA: 0x21EC704
	|-TextInputBaseField<ulong>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21F187C Offset: 0x21ED87C VA: 0x21F187C
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public bool get_tripleClickSelectsLine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB5B8 Offset: 0x21C75B8 VA: 0x21CB5B8
	|-TextInputBaseField<double>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D0198 Offset: 0x21CC198 VA: 0x21D0198
	|-TextInputBaseField<Hash128>.get_tripleClickSelectsLine

### dump.cs, line 221606
	|-TextInputBaseField<uint>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21EC704 Offset: 0x21E8704 VA: 0x21EC704
	|-TextInputBaseField<ulong>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21F187C Offset: 0x21ED87C VA: 0x21F187C
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public bool get_tripleClickSelectsLine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB5B8 Offset: 0x21C75B8 VA: 0x21CB5B8
	|-TextInputBaseField<double>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D0198 Offset: 0x21CC198 VA: 0x21D0198
	|-TextInputBaseField<Hash128>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D4D7C Offset: 0x21D0D7C VA: 0x21D4D7C
	|-TextInputBaseField<int>.get_tripleClickSelectsLine

### dump.cs, line 221609
	|-TextInputBaseField<ulong>.set_doubleClickSelectsWord
	|
	|-RVA: 0x21F187C Offset: 0x21ED87C VA: 0x21F187C
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_doubleClickSelectsWord
	*/

	// RVA: -1 Offset: -1
	public bool get_tripleClickSelectsLine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB5B8 Offset: 0x21C75B8 VA: 0x21CB5B8
	|-TextInputBaseField<double>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D0198 Offset: 0x21CC198 VA: 0x21D0198
	|-TextInputBaseField<Hash128>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D4D7C Offset: 0x21D0D7C VA: 0x21D4D7C
	|-TextInputBaseField<int>.get_tripleClickSelectsLine
	|
	|-RVA: 0x21D9954 Offset: 0x21D5954 VA: 0x21D9954
	|-TextInputBaseField<long>.get_tripleClickSelectsLine

### dump.cs, line 264538
	public static string GetEnumExportString(Enum value) { }

	// RVA: 0x2CEFB6C Offset: 0x2CEBB6C VA: 0x2CEFB6C
	public static string ConvertCamelToDash(string camel) { }

	// RVA: 0x2CEFC8C Offset: 0x2CEBC8C VA: 0x2CEFC8C
	public static string ConvertDashToHungarian(string dash) { }

	// RVA: 0x2CEFCE8 Offset: 0x2CEBCE8 VA: 0x2CEFCE8
	public static string ConvertDashToUpperNoSpace(string dash, bool firstCase, bool addSpace) { }

	// RVA: 0x2CF0018 Offset: 0x2CEC018 VA: 0x2CF0018
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[VisibleToOtherModules(new[] { "UnityEditor.UIBuilderModule" })]
internal enum StyleValueFunction // TypeDefIndex: 2798
{
	// Fields
	public int value__; // 0x0

### dump.cs, line 264541
	public static string ConvertCamelToDash(string camel) { }

	// RVA: 0x2CEFC8C Offset: 0x2CEBC8C VA: 0x2CEFC8C
	public static string ConvertDashToHungarian(string dash) { }

	// RVA: 0x2CEFCE8 Offset: 0x2CEBCE8 VA: 0x2CEFCE8
	public static string ConvertDashToUpperNoSpace(string dash, bool firstCase, bool addSpace) { }

	// RVA: 0x2CF0018 Offset: 0x2CEC018 VA: 0x2CF0018
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[VisibleToOtherModules(new[] { "UnityEditor.UIBuilderModule" })]
internal enum StyleValueFunction // TypeDefIndex: 2798
{
	// Fields
	public int value__; // 0x0
	public const StyleValueFunction Unknown = 0;
	public const StyleValueFunction Var = 1;
	public const StyleValueFunction Env = 2;

### dump.cs, line 264544
	public static string ConvertDashToHungarian(string dash) { }

	// RVA: 0x2CEFCE8 Offset: 0x2CEBCE8 VA: 0x2CEFCE8
	public static string ConvertDashToUpperNoSpace(string dash, bool firstCase, bool addSpace) { }

	// RVA: 0x2CF0018 Offset: 0x2CEC018 VA: 0x2CF0018
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[VisibleToOtherModules(new[] { "UnityEditor.UIBuilderModule" })]
internal enum StyleValueFunction // TypeDefIndex: 2798
{
	// Fields
	public int value__; // 0x0
	public const StyleValueFunction Unknown = 0;
	public const StyleValueFunction Var = 1;
	public const StyleValueFunction Env = 2;
	public const StyleValueFunction LinearGradient = 3;
	public const StyleValueFunction NoneFilter = 4;
	public const StyleValueFunction CustomFilter = 5;

### dump.cs, line 265491
	internal static readonly BindingId hideMobileInputProperty; // 0x4D8
	internal static readonly BindingId keyboardTypeProperty; // 0x570
	internal static readonly BindingId isReadOnlyProperty; // 0x608
	internal static readonly BindingId isPasswordProperty; // 0x6A0
	internal static readonly BindingId maxLengthProperty; // 0x738
	internal static readonly BindingId maskCharProperty; // 0x7D0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TextEditingManipulator <editingManipulator>k__BackingField; // 0x310
	internal bool isInputField; // 0x318
	private bool m_Multiline; // 0x319
	internal TouchScreenKeyboard m_TouchScreenKeyboard; // 0x320
	internal Action<bool> onIsReadOnlyChanged; // 0x328
	internal TouchScreenKeyboardType m_KeyboardType; // 0x330
	private bool m_HideMobileInput; // 0x334
	private bool m_IsReadOnly; // 0x335
	private int m_MaxLength; // 0x338
	private string m_PlaceholderText; // 0x340
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; // 0x348

### dump.cs, line 265534
	private string m_RenderedText; // 0x388
	private string m_OriginalText; // 0x390
	private char m_MaskChar; // 0x398
	private bool m_IsPassword; // 0x39A
	private bool m_HidePlaceholderTextOnFocus; // 0x39B
	private bool m_AutoCorrection; // 0x39C
	internal static readonly BindingId isSelectableProperty; // 0x868
	internal static readonly BindingId cursorIndexProperty; // 0x900
	internal static readonly BindingId selectIndexProperty; // 0x998
	internal static readonly BindingId doubleClickSelectsWordProperty; // 0xA30
	internal static readonly BindingId tripleClickSelectsLineProperty; // 0xAC8
	internal static readonly BindingId cursorPositionProperty; // 0xB60
	internal static readonly BindingId selectAllOnFocusProperty; // 0xBF8
	internal static readonly BindingId selectAllOnMouseUpProperty; // 0xC90
	internal static readonly BindingId selectionProperty; // 0xD28
	private TextSelectingManipulator m_SelectingManipulator; // 0x3A0
	private bool m_IsSelectable; // 0x3A8
	private bool m_DoubleClickSelectsWord; // 0x3A9
	private bool m_TripleClickSelectsLine; // 0x3AA
	private bool m_SelectAllOnFocus; // 0x3AB
	private bool m_SelectAllOnMouseUp; // 0x3AC

### dump.cs, line 265540
	internal static readonly BindingId isSelectableProperty; // 0x868
	internal static readonly BindingId cursorIndexProperty; // 0x900
	internal static readonly BindingId selectIndexProperty; // 0x998
	internal static readonly BindingId doubleClickSelectsWordProperty; // 0xA30
	internal static readonly BindingId tripleClickSelectsLineProperty; // 0xAC8
	internal static readonly BindingId cursorPositionProperty; // 0xB60
	internal static readonly BindingId selectAllOnFocusProperty; // 0xBF8
	internal static readonly BindingId selectAllOnMouseUpProperty; // 0xC90
	internal static readonly BindingId selectionProperty; // 0xD28
	private TextSelectingManipulator m_SelectingManipulator; // 0x3A0
	private bool m_IsSelectable; // 0x3A8
	private bool m_DoubleClickSelectsWord; // 0x3A9
	private bool m_TripleClickSelectsLine; // 0x3AA
	private bool m_SelectAllOnFocus; // 0x3AB
	private bool m_SelectAllOnMouseUp; // 0x3AC
	private Color m_SelectionColor; // 0x3B0
	private Color m_CursorColor; // 0x3C0
	private float m_CursorWidth; // 0x3D0

	// Properties
	public Action<TextElement.GlyphsEnumerable> PostProcessTextVertices { get; }

### dump.cs, line 265548
	internal static readonly BindingId selectionProperty; // 0xD28
	private TextSelectingManipulator m_SelectingManipulator; // 0x3A0
	private bool m_IsSelectable; // 0x3A8
	private bool m_DoubleClickSelectsWord; // 0x3A9
	private bool m_TripleClickSelectsLine; // 0x3AA
	private bool m_SelectAllOnFocus; // 0x3AB
	private bool m_SelectAllOnMouseUp; // 0x3AC
	private Color m_SelectionColor; // 0x3B0
	private Color m_CursorColor; // 0x3C0
	private float m_CursorWidth; // 0x3D0

	// Properties
	public Action<TextElement.GlyphsEnumerable> PostProcessTextVertices { get; }
	internal UITKTextHandle uitkTextHandle { get; set; }
	[CreateProperty]
	public virtual string text { get; set; }
	[CreateProperty]
	public bool enableRichText { get; set; }
	[CreateProperty]
	public bool emojiFallbackSupport { get; set; }
	[CreateProperty]

### dump.cs, line 265604
	[CreateProperty]
	private char maskChar { get; set; }
	private char effectiveMaskChar { get; }
	private bool UnityEngine.UIElements.ITextEdition.isPassword { get; set; }
	[CreateProperty]
	private bool isPassword { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus { get; set; }
	internal bool showPlaceholderText { get; }
	private bool UnityEngine.UIElements.ITextEdition.autoCorrection { get; set; }
	[CreateProperty]
	private bool autoCorrection { get; set; }
	internal RenderedText renderedText { get; }
	internal string originalText { get; }
	[CreateProperty(ReadOnly = True)]
	public ITextSelection selection { get; }
	private bool UnityEngine.UIElements.ITextSelection.isSelectable { get; set; }
	[CreateProperty]
	internal bool isSelectable { get; set; }
	private int UnityEngine.UIElements.ITextSelection.cursorIndex { get; set; }
	[CreateProperty]
	private int cursorIndex { get; set; }

### dump.cs, line 265606
	private char effectiveMaskChar { get; }
	private bool UnityEngine.UIElements.ITextEdition.isPassword { get; set; }
	[CreateProperty]
	private bool isPassword { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus { get; set; }
	internal bool showPlaceholderText { get; }
	private bool UnityEngine.UIElements.ITextEdition.autoCorrection { get; set; }
	[CreateProperty]
	private bool autoCorrection { get; set; }
	internal RenderedText renderedText { get; }
	internal string originalText { get; }
	[CreateProperty(ReadOnly = True)]
	public ITextSelection selection { get; }
	private bool UnityEngine.UIElements.ITextSelection.isSelectable { get; set; }
	[CreateProperty]
	internal bool isSelectable { get; set; }
	private int UnityEngine.UIElements.ITextSelection.cursorIndex { get; set; }
	[CreateProperty]
	private int cursorIndex { get; set; }
	private int UnityEngine.UIElements.ITextSelection.selectIndex { get; set; }
	[CreateProperty]

### dump.cs, line 265625
	private int UnityEngine.UIElements.ITextSelection.selectIndex { get; set; }
	[CreateProperty]
	private int selectIndex { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord { get; set; }
	[CreateProperty]
	internal bool doubleClickSelectsWord { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine { get; set; }
	[CreateProperty]
	internal bool tripleClickSelectsLine { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus { get; set; }
	[CreateProperty]
	private bool selectAllOnFocus { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp { get; set; }
	[CreateProperty]
	private bool selectAllOnMouseUp { get; set; }
	private Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition { get; }
	[CreateProperty(ReadOnly = True)]
	private Vector2 cursorPosition { get; }
	private float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition { get; }
	internal Color selectionColor { get; set; }
	internal Color cursorColor { get; set; }

### dump.cs, line 265627
	private int selectIndex { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord { get; set; }
	[CreateProperty]
	internal bool doubleClickSelectsWord { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine { get; set; }
	[CreateProperty]
	internal bool tripleClickSelectsLine { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus { get; set; }
	[CreateProperty]
	private bool selectAllOnFocus { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp { get; set; }
	[CreateProperty]
	private bool selectAllOnMouseUp { get; set; }
	private Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition { get; }
	[CreateProperty(ReadOnly = True)]
	private Vector2 cursorPosition { get; }
	private float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition { get; }
	internal Color selectionColor { get; set; }
	internal Color cursorColor { get; set; }
	private float UnityEngine.UIElements.ITextSelection.cursorWidth { get; }
	internal TextSelectingManipulator selectingManipulator { get; }

### dump.cs, line 265952
	private char get_effectiveMaskChar() { }

	// RVA: 0x2CFD01C Offset: 0x2CF901C VA: 0x2CFD01C Slot: 167
	private bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x2CFD024 Offset: 0x2CF9024 VA: 0x2CFD024 Slot: 168
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x2CFD0B8 Offset: 0x2CF90B8 VA: 0x2CFD0B8
	private bool get_isPassword() { }

	// RVA: 0x2CFD158 Offset: 0x2CF9158 VA: 0x2CFD158
	private void set_isPassword(bool value) { }

	// RVA: 0x2CFD200 Offset: 0x2CF9200 VA: 0x2CFD200 Slot: 169
	private bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	// RVA: 0x2CFD208 Offset: 0x2CF9208 VA: 0x2CFD208 Slot: 170
	private void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	// RVA: 0x2CF5DD8 Offset: 0x2CF1DD8 VA: 0x2CF5DD8

### dump.cs, line 265955
	private bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x2CFD024 Offset: 0x2CF9024 VA: 0x2CFD024 Slot: 168
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x2CFD0B8 Offset: 0x2CF90B8 VA: 0x2CFD0B8
	private bool get_isPassword() { }

	// RVA: 0x2CFD158 Offset: 0x2CF9158 VA: 0x2CFD158
	private void set_isPassword(bool value) { }

	// RVA: 0x2CFD200 Offset: 0x2CF9200 VA: 0x2CFD200 Slot: 169
	private bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	// RVA: 0x2CFD208 Offset: 0x2CF9208 VA: 0x2CFD208 Slot: 170
	private void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	// RVA: 0x2CF5DD8 Offset: 0x2CF1DD8 VA: 0x2CF5DD8
	internal bool get_showPlaceholderText() { }

	// RVA: 0x2CFD210 Offset: 0x2CF9210 VA: 0x2CFD210 Slot: 171

### dump.cs, line 265958
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x2CFD0B8 Offset: 0x2CF90B8 VA: 0x2CFD0B8
	private bool get_isPassword() { }

	// RVA: 0x2CFD158 Offset: 0x2CF9158 VA: 0x2CFD158
	private void set_isPassword(bool value) { }

	// RVA: 0x2CFD200 Offset: 0x2CF9200 VA: 0x2CFD200 Slot: 169
	private bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	// RVA: 0x2CFD208 Offset: 0x2CF9208 VA: 0x2CFD208 Slot: 170
	private void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	// RVA: 0x2CF5DD8 Offset: 0x2CF1DD8 VA: 0x2CF5DD8
	internal bool get_showPlaceholderText() { }

	// RVA: 0x2CFD210 Offset: 0x2CF9210 VA: 0x2CFD210 Slot: 171
	private bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x2CFD218 Offset: 0x2CF9218 VA: 0x2CFD218 Slot: 172

### dump.cs, line 265961
	private bool get_isPassword() { }

	// RVA: 0x2CFD158 Offset: 0x2CF9158 VA: 0x2CFD158
	private void set_isPassword(bool value) { }

	// RVA: 0x2CFD200 Offset: 0x2CF9200 VA: 0x2CFD200 Slot: 169
	private bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	// RVA: 0x2CFD208 Offset: 0x2CF9208 VA: 0x2CFD208 Slot: 170
	private void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	// RVA: 0x2CF5DD8 Offset: 0x2CF1DD8 VA: 0x2CF5DD8
	internal bool get_showPlaceholderText() { }

	// RVA: 0x2CFD210 Offset: 0x2CF9210 VA: 0x2CFD210 Slot: 171
	private bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x2CFD218 Offset: 0x2CF9218 VA: 0x2CFD218 Slot: 172
	private void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	// RVA: 0x2CFD29C Offset: 0x2CF929C VA: 0x2CFD29C

### dump.cs, line 266042
	private bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	// RVA: 0x2CFE02C Offset: 0x2CFA02C VA: 0x2CFE02C Slot: 182
	private bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE034 Offset: 0x2CFA034 VA: 0x2CFE034 Slot: 183
	private void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE0B8 Offset: 0x2CFA0B8 VA: 0x2CFE0B8
	internal bool get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE158 Offset: 0x2CFA158 VA: 0x2CFE158
	internal void set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE200 Offset: 0x2CFA200 VA: 0x2CFE200 Slot: 186
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE208 Offset: 0x2CFA208 VA: 0x2CFE208 Slot: 187
	private void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE28C Offset: 0x2CFA28C VA: 0x2CFE28C

### dump.cs, line 266045
	private bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE034 Offset: 0x2CFA034 VA: 0x2CFE034 Slot: 183
	private void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE0B8 Offset: 0x2CFA0B8 VA: 0x2CFE0B8
	internal bool get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE158 Offset: 0x2CFA158 VA: 0x2CFE158
	internal void set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE200 Offset: 0x2CFA200 VA: 0x2CFE200 Slot: 186
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE208 Offset: 0x2CFA208 VA: 0x2CFE208 Slot: 187
	private void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE28C Offset: 0x2CFA28C VA: 0x2CFE28C
	internal bool get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE32C Offset: 0x2CFA32C VA: 0x2CFE32C

### dump.cs, line 266048
	private void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE0B8 Offset: 0x2CFA0B8 VA: 0x2CFE0B8
	internal bool get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE158 Offset: 0x2CFA158 VA: 0x2CFE158
	internal void set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE200 Offset: 0x2CFA200 VA: 0x2CFE200 Slot: 186
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE208 Offset: 0x2CFA208 VA: 0x2CFE208 Slot: 187
	private void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE28C Offset: 0x2CFA28C VA: 0x2CFE28C
	internal bool get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE32C Offset: 0x2CFA32C VA: 0x2CFE32C
	internal void set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE3D4 Offset: 0x2CFA3D4 VA: 0x2CFE3D4 Slot: 191

### dump.cs, line 266051
	internal bool get_doubleClickSelectsWord() { }

	// RVA: 0x2CFE158 Offset: 0x2CFA158 VA: 0x2CFE158
	internal void set_doubleClickSelectsWord(bool value) { }

	// RVA: 0x2CFE200 Offset: 0x2CFA200 VA: 0x2CFE200 Slot: 186
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE208 Offset: 0x2CFA208 VA: 0x2CFE208 Slot: 187
	private void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE28C Offset: 0x2CFA28C VA: 0x2CFE28C
	internal bool get_tripleClickSelectsLine() { }

	// RVA: 0x2CFE32C Offset: 0x2CFA32C VA: 0x2CFE32C
	internal void set_tripleClickSelectsLine(bool value) { }

	// RVA: 0x2CFE3D4 Offset: 0x2CFA3D4 VA: 0x2CFE3D4 Slot: 191
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	// RVA: 0x2CFE3DC Offset: 0x2CFA3DC VA: 0x2CFE3DC Slot: 192

### dump.cs, line 266707
	internal abstract Action MoveFocusToCompositeRoot { get; set; }
	internal abstract Func<string> GetDefaultValueType { get; set; }
	public abstract char maskChar { get; set; }
	public abstract bool isPassword { get; set; }
	public abstract bool hidePlaceholderOnFocus { get; set; }
	public virtual bool autoCorrection { get; set; }
	public virtual bool hideMobileInput { get; set; }
	public virtual TouchScreenKeyboard touchScreenKeyboard { get; }
	public virtual TouchScreenKeyboardType keyboardType { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract bool get_multiline();

	// RVA: -1 Offset: -1 Slot: 1
	internal abstract void set_multiline(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isReadOnly();


### dump.cs, line 266802
	public abstract void set_maskChar(char value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool get_isPassword();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void set_isPassword(bool value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool get_hidePlaceholderOnFocus();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void set_hidePlaceholderOnFocus(bool value);

	// RVA: 0x2D0635C Offset: 0x2D0235C VA: 0x2D0635C Slot: 32
	public virtual bool get_autoCorrection() { }

	// RVA: 0x2D06424 Offset: 0x2D02424 VA: 0x2D06424 Slot: 33
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x2D064E4 Offset: 0x2D024E4 VA: 0x2D064E4 Slot: 34

### dump.cs, line 266805
	public abstract bool get_isPassword();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void set_isPassword(bool value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool get_hidePlaceholderOnFocus();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void set_hidePlaceholderOnFocus(bool value);

	// RVA: 0x2D0635C Offset: 0x2D0235C VA: 0x2D0635C Slot: 32
	public virtual bool get_autoCorrection() { }

	// RVA: 0x2D06424 Offset: 0x2D02424 VA: 0x2D06424 Slot: 33
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x2D064E4 Offset: 0x2D024E4 VA: 0x2D064E4 Slot: 34
	public virtual bool get_hideMobileInput() { }

	// RVA: 0x2D065AC Offset: 0x2D025AC VA: 0x2D065AC Slot: 35

### dump.cs, line 266841
	// Properties
	public abstract bool isSelectable { get; set; }
	public abstract int cursorIndex { get; set; }
	public abstract bool doubleClickSelectsWord { get; set; }
	public abstract int selectIndex { get; set; }
	public abstract bool tripleClickSelectsLine { get; set; }
	public abstract bool selectAllOnFocus { get; set; }
	public abstract bool selectAllOnMouseUp { get; set; }
	public abstract Vector2 cursorPosition { get; }
	internal abstract float lineHeightAtCursorPosition { get; }
	internal abstract float cursorWidth { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isSelectable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isSelectable(bool value);

	// RVA: -1 Offset: -1 Slot: 2

### dump.cs, line 266865
	public abstract void set_cursorIndex(int value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_doubleClickSelectsWord();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_doubleClickSelectsWord(bool value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_selectIndex();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_selectIndex(int value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_tripleClickSelectsLine();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_tripleClickSelectsLine(bool value);

	// RVA: -1 Offset: -1 Slot: 10

### dump.cs, line 266868
	public abstract bool get_doubleClickSelectsWord();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_doubleClickSelectsWord(bool value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_selectIndex();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_selectIndex(int value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_tripleClickSelectsLine();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_tripleClickSelectsLine(bool value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool HasSelection();

	// RVA: -1 Offset: -1 Slot: 11

### dump.cs, line 280913
	private static bool IsNextCharacter(string s, int index, char c) { }

	// RVA: 0x2D748C8 Offset: 0x2D708C8 VA: 0x2D748C8
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x2D74868 Offset: 0x2D70868 VA: 0x2D74868
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x2D747E8 Offset: 0x2D707E8 VA: 0x2D747E8
	private static int GlobCharacter(string s, int index, char c) { }

	// RVA: 0x2D721D0 Offset: 0x2D6E1D0 VA: 0x2D721D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public static class Easing // TypeDefIndex: 3237
{
	// Methods

	// RVA: 0x2D74964 Offset: 0x2D70964 VA: 0x2D74964

### dump.cs, line 284702
	public float range; // 0x4C
	public float stop; // 0x50
	private Transform target; // 0x58
	private Transform enemyTransform; // 0x60
	public GameObject legToCollided; // 0x68
	public GameObject trunkToCollided; // 0x70
	public GameObject leftarmToCollided; // 0x78
	public GameObject rightarmToCollided; // 0x80
	public GameObject HelmetToCollided; // 0x88
	public GameObject PoliToCollided; // 0x90
	public GameObject BodyToCollided; // 0x98
	public GameObject ObjectToCollided; // 0xA0
	public GameObject ObjectToCollided2; // 0xA8
	private int counter; // 0xB0
	private int counterblood; // 0xB4

	// Methods

	// RVA: 0x14C5C48 Offset: 0x14C1C48 VA: 0x14C5C48
	private void Start() { }


### dump.cs, line 296621
	private void Update() { }

	// RVA: 0x1501F04 Offset: 0x14FDF04 VA: 0x1501F04
	private void NextWeapon() { }

	// RVA: 0x1501ED8 Offset: 0x14FDED8 VA: 0x1501ED8
	private void PrevWeapon() { }

	// RVA: 0x1502090 Offset: 0x14FE090 VA: 0x1502090
	private void AdvanceSocket() { }

	// RVA: 0x15020A8 Offset: 0x14FE0A8 VA: 0x15020A8
	public void Fire() { }

	// RVA: 0x1502024 Offset: 0x14FE024 VA: 0x1502024
	public void Stop() { }

	// RVA: 0x15025B4 Offset: 0x14FE5B4 VA: 0x15025B4
	private void Vulcan() { }

	// RVA: 0x15047A0 Offset: 0x15007A0 VA: 0x15047A0

### dump.cs, line 296624
	private void NextWeapon() { }

	// RVA: 0x1501ED8 Offset: 0x14FDED8 VA: 0x1501ED8
	private void PrevWeapon() { }

	// RVA: 0x1502090 Offset: 0x14FE090 VA: 0x1502090
	private void AdvanceSocket() { }

	// RVA: 0x15020A8 Offset: 0x14FE0A8 VA: 0x15020A8
	public void Fire() { }

	// RVA: 0x1502024 Offset: 0x14FE024 VA: 0x1502024
	public void Stop() { }

	// RVA: 0x15025B4 Offset: 0x14FE5B4 VA: 0x15025B4
	private void Vulcan() { }

	// RVA: 0x15047A0 Offset: 0x15007A0 VA: 0x15047A0
	public void VulcanImpact(Vector3 pos) { }

	// RVA: 0x1502904 Offset: 0x14FE904 VA: 0x1502904

### dump.cs, line 296775
	private void Start() { }

	// RVA: 0x1505E48 Offset: 0x1501E48 VA: 0x1505E48
	private void ScaleShurikenSystems(float scaleFactor) { }

	// RVA: 0x1505E4C Offset: 0x1501E4C VA: 0x1505E4C
	private void ScaleTrailRenderers(float scaleFactor) { }

	// RVA: 0x1505F28 Offset: 0x1501F28 VA: 0x1505F28
	private void Update() { }

	// RVA: 0x1505F2C Offset: 0x1501F2C VA: 0x1505F2C
	public void .ctor() { }
}

// Namespace: 
public class F3DPool : MonoBehaviour // TypeDefIndex: 3479
{
	// Fields
	public static F3DPool instance; // 0x0
	[Header("VFX Pool")]

### dump.cs, line 297804
}

// Namespace: 
public class FireballButtonShuriken : MonoBehaviour // TypeDefIndex: 3513
{
	// Fields
	public ParticleSystem fireball; // 0x20
	public float speed; // 0x28

	// Methods

	// RVA: 0x1510950 Offset: 0x150C950 VA: 0x1510950
	public void OnMouseDown() { }

	// RVA: 0x15109CC Offset: 0x150C9CC VA: 0x15109CC
	public void .ctor() { }
}

// Namespace: 
public class RFX4_FPS : MonoBehaviour // TypeDefIndex: 3514
{

### dump.cs, line 300445
}

// Namespace: 
public class AudioEnemy : MonoBehaviour // TypeDefIndex: 3600
{
	// Fields
	public AudioSource[] enemyAudioSource; // 0x20
	public AudioSource[] enemyThanKinhAudioSource; // 0x28
	public AudioSource LinhOmBomAudiosource; // 0x30
	public AudioSource MonsterAudioSource; // 0x38
	public AudioSource SamuraiAudioSource; // 0x40
	public AudioSource XuongAudioSource; // 0x48
	public AudioClip[] ClipKeu1Tieng; // 0x50
	public AudioClip[] ClipKeu1TiengThanKinh; // 0x58
	public AudioClip[] ClipKeu1TiengMonster; // 0x60
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90

### dump.cs, line 300448
public class AudioEnemy : MonoBehaviour // TypeDefIndex: 3600
{
	// Fields
	public AudioSource[] enemyAudioSource; // 0x20
	public AudioSource[] enemyThanKinhAudioSource; // 0x28
	public AudioSource LinhOmBomAudiosource; // 0x30
	public AudioSource MonsterAudioSource; // 0x38
	public AudioSource SamuraiAudioSource; // 0x40
	public AudioSource XuongAudioSource; // 0x48
	public AudioClip[] ClipKeu1Tieng; // 0x50
	public AudioClip[] ClipKeu1TiengThanKinh; // 0x58
	public AudioClip[] ClipKeu1TiengMonster; // 0x60
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8

### dump.cs, line 300449
{
	// Fields
	public AudioSource[] enemyAudioSource; // 0x20
	public AudioSource[] enemyThanKinhAudioSource; // 0x28
	public AudioSource LinhOmBomAudiosource; // 0x30
	public AudioSource MonsterAudioSource; // 0x38
	public AudioSource SamuraiAudioSource; // 0x40
	public AudioSource XuongAudioSource; // 0x48
	public AudioClip[] ClipKeu1Tieng; // 0x50
	public AudioClip[] ClipKeu1TiengThanKinh; // 0x58
	public AudioClip[] ClipKeu1TiengMonster; // 0x60
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0

### dump.cs, line 300458
	public AudioClip[] ClipKeu1TiengThanKinh; // 0x58
	public AudioClip[] ClipKeu1TiengMonster; // 0x60
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8

### dump.cs, line 300459
	public AudioClip[] ClipKeu1TiengMonster; // 0x60
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100

### dump.cs, line 300460
	public AudioClip[] ClipKeu1TiengSamurai; // 0x68
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108

### dump.cs, line 300461
	public AudioClip[] ClipAttackThanKinh; // 0x70
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110

### dump.cs, line 300462
	public AudioClip[] ClipAttackStrong; // 0x78
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118

### dump.cs, line 300463
	public AudioClip[] ClipAttackNormal; // 0x80
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120

### dump.cs, line 300464
	public AudioClip[] ClipAttackRanger; // 0x88
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128

### dump.cs, line 300465
	public AudioClip[] ClipAttackLienTuc; // 0x90
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128
	private float timetodie; // 0x12C

### dump.cs, line 300466
	public AudioClip[] ClipAttackQuayTay; // 0x98
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128
	private float timetodie; // 0x12C
	private int randTg1; // 0x130

### dump.cs, line 300467
	public AudioClip[] ClipAttackMonster; // 0xA0
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128
	private float timetodie; // 0x12C
	private int randTg1; // 0x130
	private int randTg2; // 0x134

### dump.cs, line 300468
	public AudioClip[] ClipAttackNemBom; // 0xA8
	public AudioClip[] ClipAttackSamuraiChem; // 0xB0
	public AudioClip[] ClipAttackSamuraiDa; // 0xB8
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128
	private float timetodie; // 0x12C
	private int randTg1; // 0x130
	private int randTg2; // 0x134
	private int randJTg1; // 0x138

### dump.cs, line 300471
	public AudioClip[] ClipAttackSamuraiLenKhien; // 0xC0
	public AudioClip[] ClipChet; // 0xC8
	public AudioClip[] ClipChetThanKinh; // 0xD0
	public AudioClip[] ClipChetDash; // 0xD8
	public AudioClip[] ClipChetMonster; // 0xE0
	public AudioClip[] ClipChetSamurai; // 0xE8
	public AudioClip[] ClipChetXuongNo; // 0xF0
	public AudioClip[] ClipChetNemBom; // 0xF8
	public AudioClip[] ClipNoBom; // 0x100
	public AudioClip[] ClipNoBomMonster; // 0x108
	public AudioClip[] ClipNoBomSumurai; // 0x110
	public AudioClip[] ClipOmBomChay; // 0x118
	public AudioClip[] ClipSamuraiXuatHien; // 0x120
	private float timetotalk; // 0x128
	private float timetodie; // 0x12C
	private int randTg1; // 0x130
	private int randTg2; // 0x134
	private int randJTg1; // 0x138
	private int randJTg2; // 0x13C
	private int ranab1; // 0x140
	private int ranab2; // 0x144

### dump.cs, line 300494
	private int randBom; // 0x150
	private int randNormal; // 0x154
	private int tthuong; // 0x158
	private int tdash; // 0x15C
	private int tthankinh; // 0x160
	private int ranthuong; // 0x164
	private int randash; // 0x168
	private int ranthankinh; // 0x16C
	private static AudioEnemy main; // 0x0
	private int i; // 0x170
	private int j; // 0x174
	private int abt; // 0x178
	private int atk; // 0x17C

	// Properties
	public static AudioEnemy Instance { get; }

	// Methods

	// RVA: 0x1523B4C Offset: 0x151FB4C VA: 0x1523B4C
	public static AudioEnemy get_Instance() { }

### dump.cs, line 300497
	private int tdash; // 0x15C
	private int tthankinh; // 0x160
	private int ranthuong; // 0x164
	private int randash; // 0x168
	private int ranthankinh; // 0x16C
	private static AudioEnemy main; // 0x0
	private int i; // 0x170
	private int j; // 0x174
	private int abt; // 0x178
	private int atk; // 0x17C

	// Properties
	public static AudioEnemy Instance { get; }

	// Methods

	// RVA: 0x1523B4C Offset: 0x151FB4C VA: 0x1523B4C
	public static AudioEnemy get_Instance() { }

	// RVA: 0x1523C10 Offset: 0x151FC10 VA: 0x1523C10
	private void Start() { }

### dump.cs, line 300499
	private int ranthuong; // 0x164
	private int randash; // 0x168
	private int ranthankinh; // 0x16C
	private static AudioEnemy main; // 0x0
	private int i; // 0x170
	private int j; // 0x174
	private int abt; // 0x178
	private int atk; // 0x17C

	// Properties
	public static AudioEnemy Instance { get; }

	// Methods

	// RVA: 0x1523B4C Offset: 0x151FB4C VA: 0x1523B4C
	public static AudioEnemy get_Instance() { }

	// RVA: 0x1523C10 Offset: 0x151FC10 VA: 0x1523C10
	private void Start() { }

	// RVA: 0x1523E00 Offset: 0x151FE00 VA: 0x1523E00

### dump.cs, line 300506
	private int atk; // 0x17C

	// Properties
	public static AudioEnemy Instance { get; }

	// Methods

	// RVA: 0x1523B4C Offset: 0x151FB4C VA: 0x1523B4C
	public static AudioEnemy get_Instance() { }

	// RVA: 0x1523C10 Offset: 0x151FC10 VA: 0x1523C10
	private void Start() { }

	// RVA: 0x1523E00 Offset: 0x151FE00 VA: 0x1523E00
	public void OmBomChay() { }

	// RVA: 0x1523E6C Offset: 0x151FE6C VA: 0x1523E6C
	public void OmBomChet() { }

	// RVA: 0x1523E70 Offset: 0x151FE70 VA: 0x1523E70
	public AudioSource GetAudioSource(bool tk) { }

### dump.cs, line 300511
	// Methods

	// RVA: 0x1523B4C Offset: 0x151FB4C VA: 0x1523B4C
	public static AudioEnemy get_Instance() { }

	// RVA: 0x1523C10 Offset: 0x151FC10 VA: 0x1523C10
	private void Start() { }

	// RVA: 0x1523E00 Offset: 0x151FE00 VA: 0x1523E00
	public void OmBomChay() { }

	// RVA: 0x1523E6C Offset: 0x151FE6C VA: 0x1523E6C
	public void OmBomChet() { }

	// RVA: 0x1523E70 Offset: 0x151FE70 VA: 0x1523E70
	public AudioSource GetAudioSource(bool tk) { }

	// RVA: 0x1523F30 Offset: 0x151FF30 VA: 0x1523F30
	public AudioSource GetAudioSourceMonster(bool tk) { }

	// RVA: 0x1523F38 Offset: 0x151FF38 VA: 0x1523F38

### dump.cs, line 300574
	public void KeuAttSamuraiLenKhien(AudioSource au, bool tk) { }

	// RVA: 0x15245B4 Offset: 0x15205B4 VA: 0x15245B4
	public void KeuGiayChet(AudioSource au, bool tk, bool chetdash) { }

	// RVA: 0x152474C Offset: 0x152074C VA: 0x152474C
	public void KeuGiayChetNemBom(AudioSource au, bool tk) { }

	// RVA: 0x15247B0 Offset: 0x15207B0 VA: 0x15247B0
	public void KeuNoBom(AudioSource au, bool tk) { }

	// RVA: 0x1524814 Offset: 0x1520814 VA: 0x1524814
	public void KeuGiayChetMonster(AudioSource au, bool tk) { }

	// RVA: 0x1524878 Offset: 0x1520878 VA: 0x1524878
	public void KeuNoBomMonster(AudioSource au, bool tk) { }

	// RVA: 0x15248DC Offset: 0x15208DC VA: 0x15248DC
	public void KeuGiayChetSamurai(AudioSource au, bool tk) { }

	// RVA: 0x1524940 Offset: 0x1520940 VA: 0x1524940

### dump.cs, line 300611
	public AudioSource AudioSource_Jump; // 0x20
	public AudioSource AudioSource_Voice_Jump; // 0x28
	public AudioClip[] AudioClip_Voice_Jump; // 0x30
	public AudioSource AudioSource_Dash; // 0x38
	public AudioSource AudioSource_Eff_Chem; // 0x40
	public AudioSource AudioSource_FootStep; // 0x48
	public AudioClip[] AudioClip_FootStep; // 0x50
	public AudioSource AudioSource_DashOk; // 0x58
	public AudioClip[] AudioClip_DashOk; // 0x60
	public AudioSource AudioSource_baygau2; // 0x68
	public AudioClip[] AudioClip_DinhBayGau; // 0x70
	public AudioSource AudioSource_Checkpoint; // 0x78
	public AudioClip[] AudioClip_CheckpointVoice; // 0x80
	public AudioSource AudioSource_Death; // 0x88
	public AudioClip[] AudioClip_Death; // 0x90
	public AudioClip[] AudioClip_DeathDoc; // 0x98
	public AudioClip[] AudioClip_DeathChay; // 0xA0
	public AudioClip[] AudioClip_DeathKillZone; // 0xA8
	public AudioClip AudioClip_NgaNgua; // 0xB0
	public AudioSource AudioSource_NhayXuongNuoc; // 0xB8
	public AudioClip AudioClip_NhayXuongNuoc; // 0xC0

### dump.cs, line 300615
	public AudioSource AudioSource_Eff_Chem; // 0x40
	public AudioSource AudioSource_FootStep; // 0x48
	public AudioClip[] AudioClip_FootStep; // 0x50
	public AudioSource AudioSource_DashOk; // 0x58
	public AudioClip[] AudioClip_DashOk; // 0x60
	public AudioSource AudioSource_baygau2; // 0x68
	public AudioClip[] AudioClip_DinhBayGau; // 0x70
	public AudioSource AudioSource_Checkpoint; // 0x78
	public AudioClip[] AudioClip_CheckpointVoice; // 0x80
	public AudioSource AudioSource_Death; // 0x88
	public AudioClip[] AudioClip_Death; // 0x90
	public AudioClip[] AudioClip_DeathDoc; // 0x98
	public AudioClip[] AudioClip_DeathChay; // 0xA0
	public AudioClip[] AudioClip_DeathKillZone; // 0xA8
	public AudioClip AudioClip_NgaNgua; // 0xB0
	public AudioSource AudioSource_NhayXuongNuoc; // 0xB8
	public AudioClip AudioClip_NhayXuongNuoc; // 0xC0
	public AudioClip AudioClip_NhayLenNuoc; // 0xC8
	public AudioSource AudioSource_PhiMoc; // 0xD0
	public AudioClip AudioClip_PhiMoc; // 0xD8
	public AudioClip AudioClip_MocDinh; // 0xE0

### dump.cs, line 300616
	public AudioSource AudioSource_FootStep; // 0x48
	public AudioClip[] AudioClip_FootStep; // 0x50
	public AudioSource AudioSource_DashOk; // 0x58
	public AudioClip[] AudioClip_DashOk; // 0x60
	public AudioSource AudioSource_baygau2; // 0x68
	public AudioClip[] AudioClip_DinhBayGau; // 0x70
	public AudioSource AudioSource_Checkpoint; // 0x78
	public AudioClip[] AudioClip_CheckpointVoice; // 0x80
	public AudioSource AudioSource_Death; // 0x88
	public AudioClip[] AudioClip_Death; // 0x90
	public AudioClip[] AudioClip_DeathDoc; // 0x98
	public AudioClip[] AudioClip_DeathChay; // 0xA0
	public AudioClip[] AudioClip_DeathKillZone; // 0xA8
	public AudioClip AudioClip_NgaNgua; // 0xB0
	public AudioSource AudioSource_NhayXuongNuoc; // 0xB8
	public AudioClip AudioClip_NhayXuongNuoc; // 0xC0
	public AudioClip AudioClip_NhayLenNuoc; // 0xC8
	public AudioSource AudioSource_PhiMoc; // 0xD0
	public AudioClip AudioClip_PhiMoc; // 0xD8
	public AudioClip AudioClip_MocDinh; // 0xE0
	public AudioClip AudioClip_Voice_Du; // 0xE8

### dump.cs, line 300666
	public void JumpPlay() { }

	// RVA: 0x1524C34 Offset: 0x1520C34 VA: 0x1524C34
	public void DashPlay() { }

	// RVA: 0x1524C4C Offset: 0x1520C4C VA: 0x1524C4C
	public void NgaNguaAudioPlay() { }

	// RVA: 0x1524C80 Offset: 0x1520C80 VA: 0x1524C80
	public void ChemPlay() { }

	// RVA: 0x1524D60 Offset: 0x1520D60 VA: 0x1524D60
	public void playerDashOk(int enemynumber) { }

	// RVA: 0x1524F00 Offset: 0x1520F00 VA: 0x1524F00
	public void PlayerDie(string s) { }

	// RVA: 0x1525080 Offset: 0x1521080 VA: 0x1525080
	public void Step() { }

	// RVA: 0x15250EC Offset: 0x15210EC VA: 0x15250EC

### dump.cs, line 300675
	public void ChemPlay() { }

	// RVA: 0x1524D60 Offset: 0x1520D60 VA: 0x1524D60
	public void playerDashOk(int enemynumber) { }

	// RVA: 0x1524F00 Offset: 0x1520F00 VA: 0x1524F00
	public void PlayerDie(string s) { }

	// RVA: 0x1525080 Offset: 0x1521080 VA: 0x1525080
	public void Step() { }

	// RVA: 0x15250EC Offset: 0x15210EC VA: 0x15250EC
	public void ComebackCP() { }

	// RVA: 0x15251BC Offset: 0x15211BC VA: 0x15251BC
	public void playerDinhBayGau() { }

	// RVA: 0x1525238 Offset: 0x1521238 VA: 0x1525238
	public void playerNhayXuongNuoc() { }

	// RVA: 0x152526C Offset: 0x152126C VA: 0x152526C

### dump.cs, line 300886
	private void Hit2() { }

	// RVA: 0x1526760 Offset: 0x1522760 VA: 0x1526760
	private void DashOver() { }

	// RVA: 0x1526A34 Offset: 0x1522A34 VA: 0x1526A34
	private void Exp() { }

	// RVA: 0x15261B0 Offset: 0x15221B0 VA: 0x15261B0
	private void BungLua() { }

	// RVA: 0x1526AFC Offset: 0x1522AFC VA: 0x1526AFC
	public void .ctor() { }
}

// Namespace: 
public class CameraFollowTarget : MonoBehaviour // TypeDefIndex: 3608
{
	// Fields
	public GameObject FollowTargetOBJ; // 0x20
	public float FollowSpeed; // 0x28

### dump.cs, line 300965
}

// Namespace: 
public class CheckPointBoss : MonoBehaviour // TypeDefIndex: 3612
{
	// Fields
	public Transform bossPlatform; // 0x20
	public Transform mauBoss; // 0x28
	private bool action; // 0x30

	// Methods

	// RVA: 0x1527250 Offset: 0x1523250 VA: 0x1527250
	private void Start() { }

	// RVA: 0x1527258 Offset: 0x1523258 VA: 0x1527258
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1527318 Offset: 0x1523318 VA: 0x1527318
	public void .ctor() { }
}

### dump.cs, line 300968
public class CheckPointBoss : MonoBehaviour // TypeDefIndex: 3612
{
	// Fields
	public Transform bossPlatform; // 0x20
	public Transform mauBoss; // 0x28
	private bool action; // 0x30

	// Methods

	// RVA: 0x1527250 Offset: 0x1523250 VA: 0x1527250
	private void Start() { }

	// RVA: 0x1527258 Offset: 0x1523258 VA: 0x1527258
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1527318 Offset: 0x1523318 VA: 0x1527318
	public void .ctor() { }
}

// Namespace: 
public enum CongChao.kieucong // TypeDefIndex: 3613

### dump.cs, line 300969
{
	// Fields
	public Transform bossPlatform; // 0x20
	public Transform mauBoss; // 0x28
	private bool action; // 0x30

	// Methods

	// RVA: 0x1527250 Offset: 0x1523250 VA: 0x1527250
	private void Start() { }

	// RVA: 0x1527258 Offset: 0x1523258 VA: 0x1527258
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1527318 Offset: 0x1523318 VA: 0x1527318
	public void .ctor() { }
}

// Namespace: 
public enum CongChao.kieucong // TypeDefIndex: 3613
{

### dump.cs, line 301114
}

// Namespace: 
public class CotTruyenLeader : MonoBehaviour // TypeDefIndex: 3619
{
	// Fields
	public AudioSource AudioSource_Music_Main; // 0x20
	public AudioSource AudioSource_Music_Phu; // 0x28
	public AudioSource yah; // 0x30
	private bool Tanging; // 0x38
	private bool Giaming; // 0x39
	public float ChangeDuration; // 0x3C
	private bool MainPlaying; // 0x40
	public float maxVol; // 0x44
	private float vol1; // 0x48
	private float vol2; // 0x4C
	private float timeFill; // 0x50

	// Methods

	// RVA: 0x1527B9C Offset: 0x1523B9C VA: 0x1527B9C

### dump.cs, line 301627

// Namespace: 
[CompilerGenerated]
private sealed class Boss1.<AttackCoolDown>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3628
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E048 Offset: 0x152A048 VA: 0x152E048
	public void .ctor(int <>1__state) { }


### dump.cs, line 301632
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E048 Offset: 0x152A048 VA: 0x152E048
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x152FC48 Offset: 0x152BC48 VA: 0x152FC48 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x152FC4C Offset: 0x152BC4C VA: 0x152FC4C Slot: 6

### dump.cs, line 301667

// Namespace: 
[CompilerGenerated]
private sealed class Boss1.<BTh>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3629
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E404 Offset: 0x152A404 VA: 0x152E404
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 301672
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E404 Offset: 0x152A404 VA: 0x152E404
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x152FD78 Offset: 0x152BD78 VA: 0x152FD78 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x152FD7C Offset: 0x152BD7C VA: 0x152FD7C Slot: 6
	private bool MoveNext() { }

### dump.cs, line 301706

// Namespace: 
[CompilerGenerated]
private sealed class Boss1.<Explor>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3630
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E7E0 Offset: 0x152A7E0 VA: 0x152E7E0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 301711
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E7E0 Offset: 0x152A7E0 VA: 0x152E7E0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x152FE98 Offset: 0x152BE98 VA: 0x152FE98 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x152FE9C Offset: 0x152BE9C VA: 0x152FE9C Slot: 6
	private bool MoveNext() { }

### dump.cs, line 301745

// Namespace: 
[CompilerGenerated]
private sealed class Boss1.<VangRa>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3631
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E37C Offset: 0x152A37C VA: 0x152E37C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 301750
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss1 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x152E37C Offset: 0x152A37C VA: 0x152E37C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153011C Offset: 0x152C11C VA: 0x153011C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1530120 Offset: 0x152C120 VA: 0x1530120 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 301783
}

// Namespace: 
public class Boss1 : MonoBehaviour // TypeDefIndex: 3632
{
	// Fields
	public Transform boderInL; // 0x20
	public Transform boderInR; // 0x28
	public Transform boderOutL; // 0x30
	public Transform boderOutR; // 0x38
	public float speed; // 0x40
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public bool lostTarget; // 0x4C
	public float watchDistance; // 0x50
	public float[] attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72

### dump.cs, line 301795
	public int hp; // 0x48
	public bool lostTarget; // 0x4C
	public float watchDistance; // 0x50
	public float[] attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8

### dump.cs, line 301798
	public float[] attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0

### dump.cs, line 301802
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0
	private float timeWork; // 0xE4

### dump.cs, line 301815
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0
	private float timeWork; // 0xE4
	private float timeMaster; // 0xE8
	private bool working; // 0xEC
	private float stunningTime; // 0xF0
	private bool matting; // 0xF4
	private float mattingTime; // 0xF8
	public float BatForce; // 0xFC
	private bool BVed; // 0x100
	public float LucDa; // 0x104
	public Transform BvParticle; // 0x108
	private int attackStyle; // 0x110
	public float kickCooldown; // 0x114
	public int kickFameOrigin; // 0x118
	private int kickFame; // 0x11C

### dump.cs, line 301829
	private bool BVed; // 0x100
	public float LucDa; // 0x104
	public Transform BvParticle; // 0x108
	private int attackStyle; // 0x110
	public float kickCooldown; // 0x114
	public int kickFameOrigin; // 0x118
	private int kickFame; // 0x11C
	private float kickCoolDownTime; // 0x120
	public Transform meleePos; // 0x128
	private float timeToKickPlayer; // 0x130
	private bool kicking; // 0x134
	private float maxHp; // 0x138
	public Transform KickPos; // 0x140
	public float KickSpeed; // 0x148
	public ParticleSystem ChemFx1; // 0x150
	public ParticleSystem ChemFx2; // 0x158
	public Transform ChemFxObj; // 0x160
	public ParticleSystem BVPaticle; // 0x168
	public bool BossActive; // 0x170
	public Transform HpTransform; // 0x178
	private float khoangCach; // 0x180

### dump.cs, line 301844
	public ParticleSystem ChemFx2; // 0x158
	public Transform ChemFxObj; // 0x160
	public ParticleSystem BVPaticle; // 0x168
	public bool BossActive; // 0x170
	public Transform HpTransform; // 0x178
	private float khoangCach; // 0x180
	private float kc; // 0x184
	private float att1Cooldown; // 0x188
	public float bienDo; // 0x18C
	private bool ChetNo; // 0x190
	public float ExplorRadius; // 0x194
	private bool daLenKhien; // 0x198
	public Transform BieuCam; // 0x1A0
	public Image hpBar; // 0x1A8
	public Transform head; // 0x1B0
	public Transform neck; // 0x1B8
	private float timeBiChem; // 0x1C0
	public Transform Body; // 0x1C8
	private ParticleSystem bvPar; // 0x1D0
	private GameObject parTG; // 0x1D8
	private float timeDuocBV; // 0x1E0

### dump.cs, line 301888
	// RVA: 0x152D3C8 Offset: 0x15293C8 VA: 0x152D3C8
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss1.<AttackCoolDown>d__67))]
	// RVA: 0x152DFD8 Offset: 0x1529FD8 VA: 0x152DFD8
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x152E070 Offset: 0x152A070 VA: 0x152E070
	public void ChemFx() { }

	// RVA: 0x152E124 Offset: 0x152A124 VA: 0x152E124
	public void Chem() { }

	// RVA: 0x152E30C Offset: 0x152A30C VA: 0x152E30C
	public void Kick() { }

	// RVA: 0x152C5F4 Offset: 0x15285F4 VA: 0x152C5F4
	private void DiTuan() { }

	// RVA: 0x152E318 Offset: 0x152A318 VA: 0x152E318
	public void BatRa() { }

### dump.cs, line 301890

	[IteratorStateMachine(typeof(Boss1.<AttackCoolDown>d__67))]
	// RVA: 0x152DFD8 Offset: 0x1529FD8 VA: 0x152DFD8
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x152E070 Offset: 0x152A070 VA: 0x152E070
	public void ChemFx() { }

	// RVA: 0x152E124 Offset: 0x152A124 VA: 0x152E124
	public void Chem() { }

	// RVA: 0x152E30C Offset: 0x152A30C VA: 0x152E30C
	public void Kick() { }

	// RVA: 0x152C5F4 Offset: 0x15285F4 VA: 0x152C5F4
	private void DiTuan() { }

	// RVA: 0x152E318 Offset: 0x152A318 VA: 0x152E318
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss1.<VangRa>d__74))]

### dump.cs, line 301907
	// RVA: 0x152E318 Offset: 0x152A318 VA: 0x152E318
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss1.<VangRa>d__74))]
	// RVA: 0x152E31C Offset: 0x152A31C VA: 0x152E31C
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(Boss1.<BTh>d__75))]
	// RVA: 0x152E3A4 Offset: 0x152A3A4 VA: 0x152E3A4
	private IEnumerator BTh() { }

	// RVA: 0x152E42C Offset: 0x152A42C VA: 0x152E42C
	private void iDied() { }

	// RVA: 0x152E690 Offset: 0x152A690 VA: 0x152E690
	private void bossDieHetBai() { }

	// RVA: 0x152E754 Offset: 0x152A754 VA: 0x152E754
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss1.<Explor>d__81))]

### dump.cs, line 301911
	// RVA: 0x152E31C Offset: 0x152A31C VA: 0x152E31C
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(Boss1.<BTh>d__75))]
	// RVA: 0x152E3A4 Offset: 0x152A3A4 VA: 0x152E3A4
	private IEnumerator BTh() { }

	// RVA: 0x152E42C Offset: 0x152A42C VA: 0x152E42C
	private void iDied() { }

	// RVA: 0x152E690 Offset: 0x152A690 VA: 0x152E690
	private void bossDieHetBai() { }

	// RVA: 0x152E754 Offset: 0x152A754 VA: 0x152E754
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss1.<Explor>d__81))]
	// RVA: 0x152E780 Offset: 0x152A780 VA: 0x152E780
	private IEnumerator Explor() { }

	// RVA: 0x152E808 Offset: 0x152A808 VA: 0x152E808

### dump.cs, line 301919
	private void iDied() { }

	// RVA: 0x152E690 Offset: 0x152A690 VA: 0x152E690
	private void bossDieHetBai() { }

	// RVA: 0x152E754 Offset: 0x152A754 VA: 0x152E754
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss1.<Explor>d__81))]
	// RVA: 0x152E780 Offset: 0x152A780 VA: 0x152E780
	private IEnumerator Explor() { }

	// RVA: 0x152E808 Offset: 0x152A808 VA: 0x152E808
	private void Hit(Vector2 p) { }

	// RVA: 0x152EC68 Offset: 0x152AC68 VA: 0x152EC68
	private void HitStun(float t) { }

	// RVA: 0x152ED24 Offset: 0x152AD24 VA: 0x152ED24
	public void ActiveBossNow() { }


### dump.cs, line 301924
	// RVA: 0x152E754 Offset: 0x152A754 VA: 0x152E754
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss1.<Explor>d__81))]
	// RVA: 0x152E780 Offset: 0x152A780 VA: 0x152E780
	private IEnumerator Explor() { }

	// RVA: 0x152E808 Offset: 0x152A808 VA: 0x152E808
	private void Hit(Vector2 p) { }

	// RVA: 0x152EC68 Offset: 0x152AC68 VA: 0x152EC68
	private void HitStun(float t) { }

	// RVA: 0x152ED24 Offset: 0x152AD24 VA: 0x152ED24
	public void ActiveBossNow() { }

	// RVA: 0x152ED30 Offset: 0x152AD30 VA: 0x152ED30
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x152EC30 Offset: 0x152AC30 VA: 0x152EC30
	private void UpdateHP() { }

### dump.cs, line 301935
	private void HitStun(float t) { }

	// RVA: 0x152ED24 Offset: 0x152AD24 VA: 0x152ED24
	public void ActiveBossNow() { }

	// RVA: 0x152ED30 Offset: 0x152AD30 VA: 0x152ED30
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x152EC30 Offset: 0x152AC30 VA: 0x152EC30
	private void UpdateHP() { }

	// RVA: 0x152ED34 Offset: 0x152AD34 VA: 0x152ED34
	private void DashOver() { }

	// RVA: 0x152EF10 Offset: 0x152AF10 VA: 0x152EF10
	private void Exp() { }

	// RVA: 0x152E980 Offset: 0x152A980 VA: 0x152E980
	private void HitBack() { }

	// RVA: 0x152F098 Offset: 0x152B098 VA: 0x152F098

### dump.cs, line 301944
	private void UpdateHP() { }

	// RVA: 0x152ED34 Offset: 0x152AD34 VA: 0x152ED34
	private void DashOver() { }

	// RVA: 0x152EF10 Offset: 0x152AF10 VA: 0x152EF10
	private void Exp() { }

	// RVA: 0x152E980 Offset: 0x152A980 VA: 0x152E980
	private void HitBack() { }

	// RVA: 0x152F098 Offset: 0x152B098 VA: 0x152F098
	private void HitIdle() { }

	// RVA: 0x152F33C Offset: 0x152B33C VA: 0x152F33C
	private void BaoVeAnh() { }

	// RVA: 0x152F510 Offset: 0x152B510 VA: 0x152F510
	public void LenKhienLuonVaNgay() { }

	// RVA: 0x152DF74 Offset: 0x1529F74 VA: 0x152DF74

### dump.cs, line 301977
	public void HitFiDao(Transform t) { }

	// RVA: 0x152F96C Offset: 0x152B96C VA: 0x152F96C
	private void KeuAttack() { }

	// RVA: 0x152E720 Offset: 0x152A720 VA: 0x152E720
	private void KeuChet() { }

	// RVA: 0x152FA28 Offset: 0x152BA28 VA: 0x152FA28
	public void KeuXuatHien() { }

	// RVA: 0x152FAC0 Offset: 0x152BAC0 VA: 0x152FAC0
	public void KiemCamDat() { }

	// RVA: 0x152FB8C Offset: 0x152BB8C VA: 0x152FB8C
	public void KiemXoay() { }

	// RVA: 0x152FC24 Offset: 0x152BC24 VA: 0x152FC24
	public void .ctor() { }
}


### dump.cs, line 301996
}

// Namespace: 
public class Boss1Animation : MonoBehaviour // TypeDefIndex: 3633
{
	// Fields
	public Boss1 mainScript; // 0x20

	// Methods

	// RVA: 0x15303BC Offset: 0x152C3BC VA: 0x15303BC
	public void kiemcam() { }

	// RVA: 0x15303D0 Offset: 0x152C3D0 VA: 0x15303D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<AttackCoolDown>d__72 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3634
{

### dump.cs, line 301999
public class Boss1Animation : MonoBehaviour // TypeDefIndex: 3633
{
	// Fields
	public Boss1 mainScript; // 0x20

	// Methods

	// RVA: 0x15303BC Offset: 0x152C3BC VA: 0x15303BC
	public void kiemcam() { }

	// RVA: 0x15303D0 Offset: 0x152C3D0 VA: 0x15303D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<AttackCoolDown>d__72 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3634
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

### dump.cs, line 302012

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<AttackCoolDown>d__72 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3634
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float t; // 0x20
	public Boss2 <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153498C Offset: 0x153098C VA: 0x153498C
	public void .ctor(int <>1__state) { }


### dump.cs, line 302018
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float t; // 0x20
	public Boss2 <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153498C Offset: 0x153098C VA: 0x153498C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x15349B4 Offset: 0x15309B4 VA: 0x15349B4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x15349B8 Offset: 0x15309B8 VA: 0x15349B8 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302052

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<BTh>d__94 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3635
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1534E68 Offset: 0x1530E68 VA: 0x1534E68
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302057
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1534E68 Offset: 0x1530E68 VA: 0x1534E68
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1534E90 Offset: 0x1530E90 VA: 0x1534E90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1534E94 Offset: 0x1530E94 VA: 0x1534E94 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302091

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<Explor>d__100 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3636
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1534FB0 Offset: 0x1530FB0 VA: 0x1534FB0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302096
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1534FB0 Offset: 0x1530FB0 VA: 0x1534FB0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1534FD8 Offset: 0x1530FD8 VA: 0x1534FD8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1534FDC Offset: 0x1530FDC VA: 0x1534FDC Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302130

// Namespace: 
[CompilerGenerated]
private sealed class Boss2.<RoiXuong>d__82 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3637
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1535260 Offset: 0x1531260 VA: 0x1535260
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302135
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1535260 Offset: 0x1531260 VA: 0x1535260
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1535288 Offset: 0x1531288 VA: 0x1535288 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153528C Offset: 0x153128C VA: 0x153528C Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302168
}

// Namespace: 
public class Boss2 : MonoBehaviour // TypeDefIndex: 3638
{
	// Fields
	public Transform boderInL; // 0x20
	public Transform boderInR; // 0x28
	public Transform boderOutL; // 0x30
	public Transform boderOutR; // 0x38
	public float speed; // 0x40
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B

### dump.cs, line 302179
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0

### dump.cs, line 302182
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8

### dump.cs, line 302186
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0

### dump.cs, line 302200
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0
	private float timeMaster; // 0xE4
	private bool working; // 0xE8
	private float stunningTime; // 0xEC
	private bool matting; // 0xF0
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120

### dump.cs, line 302211
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	private float maxHp; // 0x124
	public bool BossActive; // 0x128
	public float NhayXaCooldown; // 0x12C
	public float NhayXaSpeed; // 0x130
	public int NhayXaFameOrigin; // 0x134
	private int NhayXaFame; // 0x138
	private float NhayXaCoolDownTime; // 0x13C
	private bool NhayXaing; // 0x140
	public float banLenCooldown; // 0x144
	public float nemBomCooldown; // 0x148
	private int crit; // 0x14C

### dump.cs, line 302219
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	private float maxHp; // 0x124
	public bool BossActive; // 0x128
	public float NhayXaCooldown; // 0x12C
	public float NhayXaSpeed; // 0x130
	public int NhayXaFameOrigin; // 0x134
	private int NhayXaFame; // 0x138
	private float NhayXaCoolDownTime; // 0x13C
	private bool NhayXaing; // 0x140
	public float banLenCooldown; // 0x144
	public float nemBomCooldown; // 0x148
	private int crit; // 0x14C
	public Transform KickPos; // 0x150
	public Transform meleePos; // 0x158
	public Transform HpTransform; // 0x160
	public ParticleSystem BVPaticle; // 0x168
	private float khoangCach; // 0x170
	private int lanNhay; // 0x174
	private float banLenCooldownTime; // 0x178
	private float nemBomCooldownTime; // 0x17C

### dump.cs, line 302284
	private void FixedUpdate() { }

	// RVA: 0x1531FA8 Offset: 0x152DFA8 VA: 0x1531FA8
	public void ActiveBossNow() { }

	// RVA: 0x1531B8C Offset: 0x152DB8C VA: 0x1531B8C
	private void SetupTarget(Transform target) { }

	// RVA: 0x1530614 Offset: 0x152C614 VA: 0x1530614
	private void DiTuan() { }

	// RVA: 0x15313F4 Offset: 0x152D3F4 VA: 0x15313F4
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss2.<AttackCoolDown>d__72))]
	// RVA: 0x1531FB4 Offset: 0x152DFB4 VA: 0x1531FB4
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153202C Offset: 0x152E02C VA: 0x153202C
	private void PickNormalAtt() { }


### dump.cs, line 302295
	// RVA: 0x15313F4 Offset: 0x152D3F4 VA: 0x15313F4
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss2.<AttackCoolDown>d__72))]
	// RVA: 0x1531FB4 Offset: 0x152DFB4 VA: 0x1531FB4
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153202C Offset: 0x152E02C VA: 0x153202C
	private void PickNormalAtt() { }

	// RVA: 0x15320A8 Offset: 0x152E0A8 VA: 0x15320A8
	public void BanLen() { }

	[IteratorStateMachine(typeof(Boss2.<RoiXuong>d__82))]
	// RVA: 0x153234C Offset: 0x152E34C VA: 0x153234C
	private IEnumerator RoiXuong() { }

	// RVA: 0x15323B4 Offset: 0x152E3B4 VA: 0x15323B4
	public void NemNo() { }

	// RVA: 0x1532638 Offset: 0x152E638 VA: 0x1532638

### dump.cs, line 302297

	[IteratorStateMachine(typeof(Boss2.<AttackCoolDown>d__72))]
	// RVA: 0x1531FB4 Offset: 0x152DFB4 VA: 0x1531FB4
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153202C Offset: 0x152E02C VA: 0x153202C
	private void PickNormalAtt() { }

	// RVA: 0x15320A8 Offset: 0x152E0A8 VA: 0x15320A8
	public void BanLen() { }

	[IteratorStateMachine(typeof(Boss2.<RoiXuong>d__82))]
	// RVA: 0x153234C Offset: 0x152E34C VA: 0x153234C
	private IEnumerator RoiXuong() { }

	// RVA: 0x15323B4 Offset: 0x152E3B4 VA: 0x15323B4
	public void NemNo() { }

	// RVA: 0x1532638 Offset: 0x152E638 VA: 0x1532638
	public void KickGan() { }


### dump.cs, line 302305
	// RVA: 0x15320A8 Offset: 0x152E0A8 VA: 0x15320A8
	public void BanLen() { }

	[IteratorStateMachine(typeof(Boss2.<RoiXuong>d__82))]
	// RVA: 0x153234C Offset: 0x152E34C VA: 0x153234C
	private IEnumerator RoiXuong() { }

	// RVA: 0x15323B4 Offset: 0x152E3B4 VA: 0x15323B4
	public void NemNo() { }

	// RVA: 0x1532638 Offset: 0x152E638 VA: 0x1532638
	public void KickGan() { }

	// RVA: 0x1532830 Offset: 0x152E830 VA: 0x1532830
	public void KickXa() { }

	// RVA: 0x1532BB4 Offset: 0x152EBB4 VA: 0x1532BB4
	public void Chem() { }

	// RVA: 0x1532D9C Offset: 0x152ED9C VA: 0x1532D9C
	public void BatRa() { }

### dump.cs, line 302324
	// RVA: 0x1532D9C Offset: 0x152ED9C VA: 0x1532D9C
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss2.<BTh>d__94))]
	// RVA: 0x1532DA0 Offset: 0x152EDA0 VA: 0x1532DA0
	private IEnumerator BTh() { }

	// RVA: 0x1532E08 Offset: 0x152EE08 VA: 0x1532E08
	private void iDied() { }

	// RVA: 0x153306C Offset: 0x152F06C VA: 0x153306C
	private void bossDieHetBai() { }

	// RVA: 0x1533130 Offset: 0x152F130 VA: 0x1533130
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss2.<Explor>d__100))]
	// RVA: 0x153315C Offset: 0x152F15C VA: 0x153315C
	private IEnumerator Explor() { }

	// RVA: 0x15331C4 Offset: 0x152F1C4 VA: 0x15331C4

### dump.cs, line 302332
	private void iDied() { }

	// RVA: 0x153306C Offset: 0x152F06C VA: 0x153306C
	private void bossDieHetBai() { }

	// RVA: 0x1533130 Offset: 0x152F130 VA: 0x1533130
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss2.<Explor>d__100))]
	// RVA: 0x153315C Offset: 0x152F15C VA: 0x153315C
	private IEnumerator Explor() { }

	// RVA: 0x15331C4 Offset: 0x152F1C4 VA: 0x15331C4
	private void UpdateHP() { }

	// RVA: 0x15331FC Offset: 0x152F1FC VA: 0x15331FC
	private void Hit(Vector2 p) { }

	// RVA: 0x153361C Offset: 0x152F61C VA: 0x153361C
	private void HitStun(float t) { }


### dump.cs, line 302337
	// RVA: 0x1533130 Offset: 0x152F130 VA: 0x1533130
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss2.<Explor>d__100))]
	// RVA: 0x153315C Offset: 0x152F15C VA: 0x153315C
	private IEnumerator Explor() { }

	// RVA: 0x15331C4 Offset: 0x152F1C4 VA: 0x15331C4
	private void UpdateHP() { }

	// RVA: 0x15331FC Offset: 0x152F1FC VA: 0x15331FC
	private void Hit(Vector2 p) { }

	// RVA: 0x153361C Offset: 0x152F61C VA: 0x153361C
	private void HitStun(float t) { }

	// RVA: 0x15336D8 Offset: 0x152F6D8 VA: 0x15336D8
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x15336DC Offset: 0x152F6DC VA: 0x15336DC
	private void DashOver() { }

### dump.cs, line 302354
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x15336DC Offset: 0x152F6DC VA: 0x15336DC
	private void DashOver() { }

	// RVA: 0x1533374 Offset: 0x152F374 VA: 0x1533374
	private void HitBack() { }

	// RVA: 0x15338B8 Offset: 0x152F8B8 VA: 0x15338B8
	private void HitIdle() { }

	// RVA: 0x1533B5C Offset: 0x152FB5C VA: 0x1533B5C
	private void BaoVeAnh() { }

	// RVA: 0x1533D30 Offset: 0x152FD30 VA: 0x1533D30
	public void LenKhienLuonVaNgay() { }

	// RVA: 0x1531F44 Offset: 0x152DF44 VA: 0x1531F44
	private void ThoiBaoVe() { }

	// RVA: 0x1533F18 Offset: 0x152FF18 VA: 0x1533F18

### dump.cs, line 302390
	public void HitFiDao(Transform t) { }

	// RVA: 0x1532290 Offset: 0x152E290 VA: 0x1532290
	private void KeuAttack() { }

	// RVA: 0x15330FC Offset: 0x152F0FC VA: 0x15330FC
	private void KeuChet() { }

	// RVA: 0x1534720 Offset: 0x1530720 VA: 0x1534720
	public void KeuXuatHien() { }

	// RVA: 0x15347B8 Offset: 0x15307B8 VA: 0x15347B8
	public void .ctor() { }
}

// Namespace: 
public class Boss2Animation : MonoBehaviour // TypeDefIndex: 3639
{
	// Fields
	public Boss2 mainScript; // 0x20


### dump.cs, line 302403
}

// Namespace: 
public class Boss2Animation : MonoBehaviour // TypeDefIndex: 3639
{
	// Fields
	public Boss2 mainScript; // 0x20

	// Methods

	// RVA: 0x1535718 Offset: 0x1531718 VA: 0x1535718
	private void Start() { }

	// RVA: 0x153571C Offset: 0x153171C VA: 0x153571C
	public void BanThuong() { }

	// RVA: 0x1535734 Offset: 0x1531734 VA: 0x1535734
	public void NhayGan() { }

	// RVA: 0x153574C Offset: 0x153174C VA: 0x153574C
	public void NhayXa() { }

### dump.cs, line 302406
public class Boss2Animation : MonoBehaviour // TypeDefIndex: 3639
{
	// Fields
	public Boss2 mainScript; // 0x20

	// Methods

	// RVA: 0x1535718 Offset: 0x1531718 VA: 0x1535718
	private void Start() { }

	// RVA: 0x153571C Offset: 0x153171C VA: 0x153571C
	public void BanThuong() { }

	// RVA: 0x1535734 Offset: 0x1531734 VA: 0x1535734
	public void NhayGan() { }

	// RVA: 0x153574C Offset: 0x153174C VA: 0x153574C
	public void NhayXa() { }

	// RVA: 0x1535764 Offset: 0x1531764 VA: 0x1535764
	public void NemBom() { }

### dump.cs, line 302436
}

// Namespace: 
public class Boss2BomXanh : MonoBehaviour // TypeDefIndex: 3640
{
	// Fields
	public float ExplorRadius; // 0x20
	public float timeExplor; // 0x24

	// Methods

	// RVA: 0x15357B4 Offset: 0x15317B4 VA: 0x15357B4
	private void Start() { }

	// RVA: 0x153583C Offset: 0x153183C VA: 0x153583C
	public void Explor() { }

	// RVA: 0x1535A20 Offset: 0x1531A20 VA: 0x1535A20
	public void .ctor() { }
}


### dump.cs, line 302456

// Namespace: 
[CompilerGenerated]
private sealed class Boss2MuiTenUp.<Dinh>d__8 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3641
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2MuiTenUp <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1535EAC Offset: 0x1531EAC VA: 0x1535EAC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302461
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss2MuiTenUp <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1535EAC Offset: 0x1531EAC VA: 0x1535EAC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1535EE4 Offset: 0x1531EE4 VA: 0x1535EE4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1535EE8 Offset: 0x1531EE8 VA: 0x1535EE8 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302494
}

// Namespace: 
public class Boss2MuiTenUp : MonoBehaviour // TypeDefIndex: 3642
{
	// Fields
	public float speed; // 0x20
	private float step; // 0x24
	public Transform CenterPos; // 0x28
	public LayerMask layer; // 0x30
	private bool active; // 0x34
	private bool toe; // 0x35

	// Methods

	// RVA: 0x1535A28 Offset: 0x1531A28 VA: 0x1535A28
	private void Start() { }

	// RVA: 0x1535A98 Offset: 0x1531A98 VA: 0x1535A98
	private void FixedUpdate() { }


### dump.cs, line 302512
	// RVA: 0x1535A98 Offset: 0x1531A98 VA: 0x1535A98
	private void FixedUpdate() { }

	[IteratorStateMachine(typeof(Boss2MuiTenUp.<Dinh>d__8))]
	// RVA: 0x1535E4C Offset: 0x1531E4C VA: 0x1535E4C
	private IEnumerator Dinh() { }

	// RVA: 0x1535DDC Offset: 0x1531DDC VA: 0x1535DDC
	private void BienMat() { }

	// RVA: 0x1535ED4 Offset: 0x1531ED4 VA: 0x1535ED4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Boss3.<AttackCoolDown>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3643
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

### dump.cs, line 302525

// Namespace: 
[CompilerGenerated]
private sealed class Boss3.<AttackCoolDown>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3643
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538420 Offset: 0x1534420 VA: 0x1538420
	public void .ctor(int <>1__state) { }


### dump.cs, line 302530
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538420 Offset: 0x1534420 VA: 0x1538420
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153A14C Offset: 0x153614C VA: 0x153A14C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153A150 Offset: 0x1536150 VA: 0x153A150 Slot: 6

### dump.cs, line 302565

// Namespace: 
[CompilerGenerated]
private sealed class Boss3.<BTh>d__88 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3644
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538788 Offset: 0x1534788 VA: 0x1538788
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302570
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538788 Offset: 0x1534788 VA: 0x1538788
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153A408 Offset: 0x1536408 VA: 0x153A408 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153A40C Offset: 0x153640C VA: 0x153A40C Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302604

// Namespace: 
[CompilerGenerated]
private sealed class Boss3.<Explor>d__102 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3645
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538C34 Offset: 0x1534C34 VA: 0x1538C34
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302609
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss3 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1538C34 Offset: 0x1534C34 VA: 0x1538C34
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153A528 Offset: 0x1536528 VA: 0x153A528 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153A52C Offset: 0x153652C VA: 0x153A52C Slot: 6
	private bool MoveNext() { }

### dump.cs, line 302642
}

// Namespace: 
public class Boss3 : MonoBehaviour // TypeDefIndex: 3646
{
	// Fields
	public Transform boderInL; // 0x20
	public Transform boderInR; // 0x28
	public Transform boderOutL; // 0x30
	public Transform boderOutR; // 0x38
	public float speed; // 0x40
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B

### dump.cs, line 302653
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0

### dump.cs, line 302656
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8

### dump.cs, line 302660
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0

### dump.cs, line 302674
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0
	private float timeMaster; // 0xE4
	private bool working; // 0xE8
	private float stunningTime; // 0xEC
	private bool matting; // 0xF0
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120

### dump.cs, line 302685
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	public bool BossActive; // 0x121
	public float NhayXaCooldown; // 0x124
	public float NhayXaSpeed; // 0x128
	public int NhayXaFameOrigin; // 0x12C
	private int NhayXaFame; // 0x130
	private float NhayXaCoolDownTime; // 0x134
	private bool NhayXaing; // 0x138
	private int crit; // 0x13C
	public Transform KickPos; // 0x140
	public Transform meleePos; // 0x148
	public ParticleSystem ChemFx1; // 0x150

### dump.cs, line 302692
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	public bool BossActive; // 0x121
	public float NhayXaCooldown; // 0x124
	public float NhayXaSpeed; // 0x128
	public int NhayXaFameOrigin; // 0x12C
	private int NhayXaFame; // 0x130
	private float NhayXaCoolDownTime; // 0x134
	private bool NhayXaing; // 0x138
	private int crit; // 0x13C
	public Transform KickPos; // 0x140
	public Transform meleePos; // 0x148
	public ParticleSystem ChemFx1; // 0x150
	public ParticleSystem ChemFx2; // 0x158
	public Transform ChemFxObj; // 0x160
	public ParticleSystem BVPaticle; // 0x168
	public Transform BieuCam; // 0x170
	private float khoangCach; // 0x178
	private float maxHP; // 0x17C
	public Transform HpTransform; // 0x180

### dump.cs, line 302762
	private void FixedUpdate() { }

	// RVA: 0x15382F0 Offset: 0x15342F0 VA: 0x15382F0
	public void ActiveBossNow() { }

	// RVA: 0x1537ED4 Offset: 0x1533ED4 VA: 0x1537ED4
	private void SetupTarget(Transform target) { }

	// RVA: 0x15363C8 Offset: 0x15323C8 VA: 0x15363C8
	private void DiTuan() { }

	// RVA: 0x15372F4 Offset: 0x15332F4 VA: 0x15372F4
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss3.<AttackCoolDown>d__81))]
	// RVA: 0x15382FC Offset: 0x15342FC VA: 0x15382FC
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153836C Offset: 0x153436C VA: 0x153836C
	private void PickNormalAtt() { }


### dump.cs, line 302773
	// RVA: 0x15372F4 Offset: 0x15332F4 VA: 0x15372F4
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss3.<AttackCoolDown>d__81))]
	// RVA: 0x15382FC Offset: 0x15342FC VA: 0x15382FC
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153836C Offset: 0x153436C VA: 0x153836C
	private void PickNormalAtt() { }

	// RVA: 0x1538448 Offset: 0x1534448 VA: 0x1538448
	private void UpdateHP() { }

	// RVA: 0x1538480 Offset: 0x1534480 VA: 0x1538480
	public void ChemFx() { }

	// RVA: 0x1538534 Offset: 0x1534534 VA: 0x1538534
	public void Chem() { }

	// RVA: 0x1538724 Offset: 0x1534724 VA: 0x1538724
	public void BatRa() { }

### dump.cs, line 302775

	[IteratorStateMachine(typeof(Boss3.<AttackCoolDown>d__81))]
	// RVA: 0x15382FC Offset: 0x15342FC VA: 0x15382FC
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153836C Offset: 0x153436C VA: 0x153836C
	private void PickNormalAtt() { }

	// RVA: 0x1538448 Offset: 0x1534448 VA: 0x1538448
	private void UpdateHP() { }

	// RVA: 0x1538480 Offset: 0x1534480 VA: 0x1538480
	public void ChemFx() { }

	// RVA: 0x1538534 Offset: 0x1534534 VA: 0x1538534
	public void Chem() { }

	// RVA: 0x1538724 Offset: 0x1534724 VA: 0x1538724
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss3.<BTh>d__88))]

### dump.cs, line 302792
	// RVA: 0x1538724 Offset: 0x1534724 VA: 0x1538724
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss3.<BTh>d__88))]
	// RVA: 0x1538728 Offset: 0x1534728 VA: 0x1538728
	private IEnumerator BTh() { }

	// RVA: 0x15387B0 Offset: 0x15347B0 VA: 0x15387B0
	private void iDied() { }

	// RVA: 0x1538964 Offset: 0x1534964 VA: 0x1538964
	private void bossDieHetBai() { }

	// RVA: 0x1538A48 Offset: 0x1534A48 VA: 0x1538A48
	private void NoiXaoLon() { }

	// RVA: 0x1538B08 Offset: 0x1534B08 VA: 0x1538B08
	private void OkXongViec() { }

	// RVA: 0x1538B5C Offset: 0x1534B5C VA: 0x1538B5C
	private void CuoiDeu() { }

### dump.cs, line 302800
	private void iDied() { }

	// RVA: 0x1538964 Offset: 0x1534964 VA: 0x1538964
	private void bossDieHetBai() { }

	// RVA: 0x1538A48 Offset: 0x1534A48 VA: 0x1538A48
	private void NoiXaoLon() { }

	// RVA: 0x1538B08 Offset: 0x1534B08 VA: 0x1538B08
	private void OkXongViec() { }

	// RVA: 0x1538B5C Offset: 0x1534B5C VA: 0x1538B5C
	private void CuoiDeu() { }

	// RVA: 0x1538B90 Offset: 0x1534B90 VA: 0x1538B90
	private void chaymenobody() { }

	// RVA: 0x1538BA8 Offset: 0x1534BA8 VA: 0x1538BA8
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss3.<Explor>d__102))]

### dump.cs, line 302817
	// RVA: 0x1538BA8 Offset: 0x1534BA8 VA: 0x1538BA8
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss3.<Explor>d__102))]
	// RVA: 0x1538BD4 Offset: 0x1534BD4 VA: 0x1538BD4
	private IEnumerator Explor() { }

	// RVA: 0x1538C5C Offset: 0x1534C5C VA: 0x1538C5C
	private void Hit(Vector2 p) { }

	// RVA: 0x1539084 Offset: 0x1535084 VA: 0x1539084
	private void HitStun(float t) { }

	// RVA: 0x1539140 Offset: 0x1535140 VA: 0x1539140
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x1539144 Offset: 0x1535144 VA: 0x1539144
	private void DashOver() { }

	// RVA: 0x1538DD4 Offset: 0x1534DD4 VA: 0x1538DD4
	private void HitBack() { }

### dump.cs, line 302831
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x1539144 Offset: 0x1535144 VA: 0x1539144
	private void DashOver() { }

	// RVA: 0x1538DD4 Offset: 0x1534DD4 VA: 0x1538DD4
	private void HitBack() { }

	// RVA: 0x153932C Offset: 0x153532C VA: 0x153932C
	private void HitIdle() { }

	// RVA: 0x15395D0 Offset: 0x15355D0 VA: 0x15395D0
	private void BaoVeAnh() { }

	// RVA: 0x15397A4 Offset: 0x15357A4 VA: 0x15397A4
	public void LenKhienLuonVaNgay() { }

	// RVA: 0x153828C Offset: 0x153428C VA: 0x153828C
	private void ThoiBaoVe() { }

	// RVA: 0x153998C Offset: 0x153598C VA: 0x153998C

### dump.cs, line 302873
	public void HitFiDao(Transform t) { }

	// RVA: 0x1539FBC Offset: 0x1535FBC VA: 0x1539FBC
	private void KeuAttack() { }

	// RVA: 0x1538A14 Offset: 0x1534A14 VA: 0x1538A14
	private void KeuChet() { }

	// RVA: 0x153A078 Offset: 0x1536078 VA: 0x153A078
	public void KeuXuatHien() { }

	// RVA: 0x153A110 Offset: 0x1536110 VA: 0x153A110
	public void .ctor() { }
}

// Namespace: 
public class Boss3Animation : MonoBehaviour // TypeDefIndex: 3647
{
	// Fields
	public Boss3 mainScript; // 0x20
	public ParticleSystem datda; // 0x28

### dump.cs, line 302886
}

// Namespace: 
public class Boss3Animation : MonoBehaviour // TypeDefIndex: 3647
{
	// Fields
	public Boss3 mainScript; // 0x20
	public ParticleSystem datda; // 0x28
	public AudioSource audiodatda1; // 0x30
	public AudioSource audiodatda2; // 0x38
	public AudioSource audioPhunlua; // 0x40
	public AudioClip[] phunluaclip; // 0x48

	// Methods

	// RVA: 0x153A7B0 Offset: 0x15367B0 VA: 0x153A7B0
	private void Start() { }

	// RVA: 0x153A7B4 Offset: 0x15367B4 VA: 0x153A7B4
	public void Ban() { }


### dump.cs, line 302889
public class Boss3Animation : MonoBehaviour // TypeDefIndex: 3647
{
	// Fields
	public Boss3 mainScript; // 0x20
	public ParticleSystem datda; // 0x28
	public AudioSource audiodatda1; // 0x30
	public AudioSource audiodatda2; // 0x38
	public AudioSource audioPhunlua; // 0x40
	public AudioClip[] phunluaclip; // 0x48

	// Methods

	// RVA: 0x153A7B0 Offset: 0x15367B0 VA: 0x153A7B0
	private void Start() { }

	// RVA: 0x153A7B4 Offset: 0x15367B4 VA: 0x153A7B4
	public void Ban() { }

	// RVA: 0x153A898 Offset: 0x1536898 VA: 0x153A898
	public void Phun() { }


### dump.cs, line 302927
}

// Namespace: 
public class Boss3Bom : MonoBehaviour // TypeDefIndex: 3648
{
	// Fields
	public float ExplorRadius; // 0x20
	public float timeExplor; // 0x24

	// Methods

	// RVA: 0x153AAE4 Offset: 0x1536AE4 VA: 0x153AAE4
	private void Start() { }

	// RVA: 0x153AB34 Offset: 0x1536B34 VA: 0x153AB34
	public void Explor() { }

	// RVA: 0x153AD18 Offset: 0x1536D18 VA: 0x153AD18
	public void .ctor() { }
}


### dump.cs, line 302947

// Namespace: 
[CompilerGenerated]
private sealed class Boss4.<AttackCoolDown>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3649
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153CFB4 Offset: 0x1538FB4 VA: 0x153CFB4
	public void .ctor(int <>1__state) { }


### dump.cs, line 302952
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20
	public float t; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153CFB4 Offset: 0x1538FB4 VA: 0x153CFB4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153ECE0 Offset: 0x153ACE0 VA: 0x153ECE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153ECE4 Offset: 0x153ACE4 VA: 0x153ECE4 Slot: 6

### dump.cs, line 302987

// Namespace: 
[CompilerGenerated]
private sealed class Boss4.<BTh>d__88 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3650
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153D31C Offset: 0x153931C VA: 0x153D31C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 302992
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153D31C Offset: 0x153931C VA: 0x153D31C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153EF9C Offset: 0x153AF9C VA: 0x153EF9C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153EFA0 Offset: 0x153AFA0 VA: 0x153EFA0 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 303026

// Namespace: 
[CompilerGenerated]
private sealed class Boss4.<Explor>d__102 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3651
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153D7C8 Offset: 0x15397C8 VA: 0x153D7C8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 303031
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Boss4 <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x153D7C8 Offset: 0x15397C8 VA: 0x153D7C8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x153F0BC Offset: 0x153B0BC VA: 0x153F0BC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x153F0C0 Offset: 0x153B0C0 VA: 0x153F0C0 Slot: 6
	private bool MoveNext() { }

### dump.cs, line 303064
}

// Namespace: 
public class Boss4 : MonoBehaviour // TypeDefIndex: 3652
{
	// Fields
	public Transform boderInL; // 0x20
	public Transform boderInR; // 0x28
	public Transform boderOutL; // 0x30
	public Transform boderOutR; // 0x38
	public float speed; // 0x40
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B

### dump.cs, line 303075
	public float speedFollow; // 0x44
	public int hp; // 0x48
	public float watchDistance; // 0x4C
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0

### dump.cs, line 303078
	public float[] attackDistance; // 0x50
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8

### dump.cs, line 303082
	private bool stunning; // 0x69
	private bool vanging; // 0x6A
	private bool canSeePlayer; // 0x6B
	private bool attacking; // 0x6C
	public Transform startPoint; // 0x70
	public Transform Ghost; // 0x78
	public Animator anim; // 0x80
	public float maxTimeIlde; // 0x88
	public float minTimeIdle; // 0x8C
	public float maxTimeWork; // 0x90
	public float minTimeWork; // 0x94
	public GameObject MySpriteOBJ; // 0x98
	private Vector3 MySpriteOriginalScale; // 0xA0
	private Transform player; // 0xB0
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0

### dump.cs, line 303096
	private Transform target; // 0xB8
	private Vector2 dir; // 0xC0
	public LayerMask layer; // 0xC8
	public float[] attackingTime; // 0xD0
	private bool active; // 0xD8
	private float timeIdle; // 0xDC
	private float timeWork; // 0xE0
	private float timeMaster; // 0xE4
	private bool working; // 0xE8
	private float stunningTime; // 0xEC
	private bool matting; // 0xF0
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120

### dump.cs, line 303107
	private float mattingTime; // 0xF4
	private bool BVed; // 0xF8
	public Transform BvParticle; // 0x100
	private int attackStyle; // 0x108
	public float NhayGanCooldown; // 0x10C
	public float NhayGanSpeed; // 0x110
	public int NhayGanFameOrigin; // 0x114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	public bool BossActive; // 0x121
	public float NhayXaCooldown; // 0x124
	public float NhayXaSpeed; // 0x128
	public int NhayXaFameOrigin; // 0x12C
	private int NhayXaFame; // 0x130
	private float NhayXaCoolDownTime; // 0x134
	private bool NhayXaing; // 0x138
	private int crit; // 0x13C
	public Transform KickPos; // 0x140
	public Transform meleePos; // 0x148
	public ParticleSystem ChemFx1; // 0x150

### dump.cs, line 303114
	private int NhayGanFame; // 0x118
	private float NhayGanCoolDownTime; // 0x11C
	private bool NhayGaning; // 0x120
	public bool BossActive; // 0x121
	public float NhayXaCooldown; // 0x124
	public float NhayXaSpeed; // 0x128
	public int NhayXaFameOrigin; // 0x12C
	private int NhayXaFame; // 0x130
	private float NhayXaCoolDownTime; // 0x134
	private bool NhayXaing; // 0x138
	private int crit; // 0x13C
	public Transform KickPos; // 0x140
	public Transform meleePos; // 0x148
	public ParticleSystem ChemFx1; // 0x150
	public ParticleSystem ChemFx2; // 0x158
	public Transform ChemFxObj; // 0x160
	public ParticleSystem BVPaticle; // 0x168
	public Transform BieuCam; // 0x170
	private float khoangCach; // 0x178
	private float maxHP; // 0x17C
	public Transform HpTransform; // 0x180

### dump.cs, line 303184
	private void FixedUpdate() { }

	// RVA: 0x153CE84 Offset: 0x1538E84 VA: 0x153CE84
	public void ActiveBossNow() { }

	// RVA: 0x153CA68 Offset: 0x1538A68 VA: 0x153CA68
	private void SetupTarget(Transform target) { }

	// RVA: 0x153AF5C Offset: 0x1536F5C VA: 0x153AF5C
	private void DiTuan() { }

	// RVA: 0x153BE88 Offset: 0x1537E88 VA: 0x153BE88
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss4.<AttackCoolDown>d__81))]
	// RVA: 0x153CE90 Offset: 0x1538E90 VA: 0x153CE90
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153CF00 Offset: 0x1538F00 VA: 0x153CF00
	private void PickNormalAtt() { }


### dump.cs, line 303195
	// RVA: 0x153BE88 Offset: 0x1537E88 VA: 0x153BE88
	private void DiXien() { }

	[IteratorStateMachine(typeof(Boss4.<AttackCoolDown>d__81))]
	// RVA: 0x153CE90 Offset: 0x1538E90 VA: 0x153CE90
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153CF00 Offset: 0x1538F00 VA: 0x153CF00
	private void PickNormalAtt() { }

	// RVA: 0x153CFDC Offset: 0x1538FDC VA: 0x153CFDC
	private void UpdateHP() { }

	// RVA: 0x153D014 Offset: 0x1539014 VA: 0x153D014
	public void ChemFx() { }

	// RVA: 0x153D0C8 Offset: 0x15390C8 VA: 0x153D0C8
	public void Chem() { }

	// RVA: 0x153D2B8 Offset: 0x15392B8 VA: 0x153D2B8
	public void BatRa() { }

### dump.cs, line 303197

	[IteratorStateMachine(typeof(Boss4.<AttackCoolDown>d__81))]
	// RVA: 0x153CE90 Offset: 0x1538E90 VA: 0x153CE90
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x153CF00 Offset: 0x1538F00 VA: 0x153CF00
	private void PickNormalAtt() { }

	// RVA: 0x153CFDC Offset: 0x1538FDC VA: 0x153CFDC
	private void UpdateHP() { }

	// RVA: 0x153D014 Offset: 0x1539014 VA: 0x153D014
	public void ChemFx() { }

	// RVA: 0x153D0C8 Offset: 0x15390C8 VA: 0x153D0C8
	public void Chem() { }

	// RVA: 0x153D2B8 Offset: 0x15392B8 VA: 0x153D2B8
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss4.<BTh>d__88))]

### dump.cs, line 303214
	// RVA: 0x153D2B8 Offset: 0x15392B8 VA: 0x153D2B8
	public void BatRa() { }

	[IteratorStateMachine(typeof(Boss4.<BTh>d__88))]
	// RVA: 0x153D2BC Offset: 0x15392BC VA: 0x153D2BC
	private IEnumerator BTh() { }

	// RVA: 0x153D344 Offset: 0x1539344 VA: 0x153D344
	private void iDied() { }

	// RVA: 0x153D4F8 Offset: 0x15394F8 VA: 0x153D4F8
	private void bossDieHetBai() { }

	// RVA: 0x153D5DC Offset: 0x15395DC VA: 0x153D5DC
	private void NoiXaoLon() { }

	// RVA: 0x153D69C Offset: 0x153969C VA: 0x153D69C
	private void OkXongViec() { }

	// RVA: 0x153D6F0 Offset: 0x15396F0 VA: 0x153D6F0
	private void CuoiDeu() { }

### dump.cs, line 303222
	private void iDied() { }

	// RVA: 0x153D4F8 Offset: 0x15394F8 VA: 0x153D4F8
	private void bossDieHetBai() { }

	// RVA: 0x153D5DC Offset: 0x15395DC VA: 0x153D5DC
	private void NoiXaoLon() { }

	// RVA: 0x153D69C Offset: 0x153969C VA: 0x153D69C
	private void OkXongViec() { }

	// RVA: 0x153D6F0 Offset: 0x15396F0 VA: 0x153D6F0
	private void CuoiDeu() { }

	// RVA: 0x153D724 Offset: 0x1539724 VA: 0x153D724
	private void chaymenobody() { }

	// RVA: 0x153D73C Offset: 0x153973C VA: 0x153D73C
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss4.<Explor>d__102))]

### dump.cs, line 303239
	// RVA: 0x153D73C Offset: 0x153973C VA: 0x153D73C
	private void anthanhmau() { }

	[IteratorStateMachine(typeof(Boss4.<Explor>d__102))]
	// RVA: 0x153D768 Offset: 0x1539768 VA: 0x153D768
	private IEnumerator Explor() { }

	// RVA: 0x153D7F0 Offset: 0x15397F0 VA: 0x153D7F0
	private void Hit(Vector2 p) { }

	// RVA: 0x153DC18 Offset: 0x1539C18 VA: 0x153DC18
	private void HitStun(float t) { }

	// RVA: 0x153DCD4 Offset: 0x1539CD4 VA: 0x153DCD4
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x153DCD8 Offset: 0x1539CD8 VA: 0x153DCD8
	private void DashOver() { }

	// RVA: 0x153D968 Offset: 0x1539968 VA: 0x153D968
	private void HitBack() { }

### dump.cs, line 303253
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x153DCD8 Offset: 0x1539CD8 VA: 0x153DCD8
	private void DashOver() { }

	// RVA: 0x153D968 Offset: 0x1539968 VA: 0x153D968
	private void HitBack() { }

	// RVA: 0x153DEC0 Offset: 0x1539EC0 VA: 0x153DEC0
	private void HitIdle() { }

	// RVA: 0x153E164 Offset: 0x153A164 VA: 0x153E164
	private void BaoVeAnh() { }

	// RVA: 0x153E338 Offset: 0x153A338 VA: 0x153E338
	public void LenKhienLuonVaNgay() { }

	// RVA: 0x153CE20 Offset: 0x1538E20 VA: 0x153CE20
	private void ThoiBaoVe() { }

	// RVA: 0x153E520 Offset: 0x153A520 VA: 0x153E520

### dump.cs, line 303295
	public void HitFiDao(Transform t) { }

	// RVA: 0x153EB50 Offset: 0x153AB50 VA: 0x153EB50
	private void KeuAttack() { }

	// RVA: 0x153D5A8 Offset: 0x15395A8 VA: 0x153D5A8
	private void KeuChet() { }

	// RVA: 0x153EC0C Offset: 0x153AC0C VA: 0x153EC0C
	public void KeuXuatHien() { }

	// RVA: 0x153ECA4 Offset: 0x153ACA4 VA: 0x153ECA4
	public void .ctor() { }
}

// Namespace: 
public class BossDragon : MonoBehaviour // TypeDefIndex: 3653
{
	// Methods

	// RVA: 0x153F344 Offset: 0x153B344 VA: 0x153F344

### dump.cs, line 303308
}

// Namespace: 
public class BossDragon : MonoBehaviour // TypeDefIndex: 3653
{
	// Methods

	// RVA: 0x153F344 Offset: 0x153B344 VA: 0x153F344
	private void Start() { }

	// RVA: 0x153F348 Offset: 0x153B348 VA: 0x153F348
	private void Update() { }

	// RVA: 0x153F34C Offset: 0x153B34C VA: 0x153F34C
	public void .ctor() { }
}

// Namespace: 
public class CayDuoiDat : MonoBehaviour // TypeDefIndex: 3654
{
	// Fields

### dump.cs, line 303410
	private NinjaMovementScript PlayerScript; // 0x78
	private MainEventsLog mainEvent; // 0x80
	private int crit; // 0x88
	private bool EnemyDead; // 0x8C
	private bool closing; // 0x8D
	private float timeFire; // 0x90
	private float timeStun; // 0x94
	public float firstDelay; // 0x98
	private int hpChuan; // 0x9C

	// Methods

	// RVA: 0x153FA0C Offset: 0x153BA0C VA: 0x153FA0C
	private void Start() { }

	// RVA: 0x153FB88 Offset: 0x153BB88 VA: 0x153FB88
	private void Update() { }

	// RVA: 0x153FEE8 Offset: 0x153BEE8 VA: 0x153FEE8
	public void NhaHat() { }


### dump.cs, line 303441
	private void Hit2(Vector2 p) { }

	// RVA: 0x1540578 Offset: 0x153C578 VA: 0x1540578
	private void DashOver() { }

	// RVA: 0x15405F4 Offset: 0x153C5F4 VA: 0x15405F4
	private void Exp() { }

	// RVA: 0x1540670 Offset: 0x153C670 VA: 0x1540670
	public void .ctor() { }
}

// Namespace: 
public class CayTrenTuongAnim : MonoBehaviour // TypeDefIndex: 3657
{
	// Fields
	public CayTrenTuong cayScript; // 0x20

	// Methods

	// RVA: 0x1540684 Offset: 0x153C684 VA: 0x1540684

### dump.cs, line 303484
}

// Namespace: 
public class CongBoss : MonoBehaviour // TypeDefIndex: 3659
{
	// Fields
	private bool open; // 0x20
	private Animator anim; // 0x28
	public float TimeToClose; // 0x30
	private bool active; // 0x34

	// Methods

	// RVA: 0x154070C Offset: 0x153C70C VA: 0x154070C
	private void Start() { }

	// RVA: 0x1540764 Offset: 0x153C764 VA: 0x1540764
	private void OnTriggerEnter2D(Collider2D coll) { }

	// RVA: 0x1540868 Offset: 0x153C868 VA: 0x1540868
	private void Close() { }

### dump.cs, line 304218
}

// Namespace: 
public class EnemyOnGround : MonoBehaviour // TypeDefIndex: 3686
{
	// Fields
	public float speed; // 0x20
	public Transform MovePosition; // 0x28
	private Vector3 StartPosition; // 0x30
	private Vector3 EndPosition; // 0x3C
	private bool OnTheMove; // 0x48

	// Methods

	// RVA: 0x1544874 Offset: 0x1540874 VA: 0x1544874
	private void Start() { }

	// RVA: 0x15448BC Offset: 0x15408BC VA: 0x15448BC
	private void FixedUpdate() { }

	// RVA: 0x1544C08 Offset: 0x1540C08 VA: 0x1544C08

### dump.cs, line 304240
}

// Namespace: 
public class Enemy_FlyA : MonoBehaviour // TypeDefIndex: 3687
{
	// Fields
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	private GameObject player; // 0x60
	public ParticleSystem ParticleTrail; // 0x68
	public AudioSource EnemyDiesAudio; // 0x70

	// Methods


### dump.cs, line 304246
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	private GameObject player; // 0x60
	public ParticleSystem ParticleTrail; // 0x68
	public AudioSource EnemyDiesAudio; // 0x70

	// Methods

	// RVA: 0x1544C10 Offset: 0x1540C10 VA: 0x1544C10
	private void Start() { }

	// RVA: 0x1544D98 Offset: 0x1540D98 VA: 0x1544D98
	private void FixedUpdate() { }


### dump.cs, line 304247
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	private GameObject player; // 0x60
	public ParticleSystem ParticleTrail; // 0x68
	public AudioSource EnemyDiesAudio; // 0x70

	// Methods

	// RVA: 0x1544C10 Offset: 0x1540C10 VA: 0x1544C10
	private void Start() { }

	// RVA: 0x1544D98 Offset: 0x1540D98 VA: 0x1544D98
	private void FixedUpdate() { }

	// RVA: 0x154516C Offset: 0x154116C VA: 0x154516C

### dump.cs, line 304254
	private Vector3 MySpriteOriginalScale; // 0x50
	private GameObject player; // 0x60
	public ParticleSystem ParticleTrail; // 0x68
	public AudioSource EnemyDiesAudio; // 0x70

	// Methods

	// RVA: 0x1544C10 Offset: 0x1540C10 VA: 0x1544C10
	private void Start() { }

	// RVA: 0x1544D98 Offset: 0x1540D98 VA: 0x1544D98
	private void FixedUpdate() { }

	// RVA: 0x154516C Offset: 0x154116C VA: 0x154516C
	private void OnCollisionEnter2D(Collision2D coll) { }

	// RVA: 0x1545390 Offset: 0x1541390 VA: 0x1545390
	private void iDied() { }

	// RVA: 0x154542C Offset: 0x154142C VA: 0x154542C
	private void Hit() { }

### dump.cs, line 304281
}

// Namespace: 
public class Enemy_FlyBoss : MonoBehaviour // TypeDefIndex: 3688
{
	// Fields
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	public GameObject EnemyChildrent; // 0x40
	private float AwakeDistance; // 0x48
	public Animator AnimatorController; // 0x50
	public GameObject MySpriteOBJ; // 0x58
	private Vector3 MySpriteOriginalScale; // 0x60
	private GameObject player; // 0x70
	public ParticleSystem ParticleTrail; // 0x78
	public AudioSource EnemyDiesAudio; // 0x80

	// Methods

### dump.cs, line 304287
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	public GameObject EnemyChildrent; // 0x40
	private float AwakeDistance; // 0x48
	public Animator AnimatorController; // 0x50
	public GameObject MySpriteOBJ; // 0x58
	private Vector3 MySpriteOriginalScale; // 0x60
	private GameObject player; // 0x70
	public ParticleSystem ParticleTrail; // 0x78
	public AudioSource EnemyDiesAudio; // 0x80

	// Methods

	// RVA: 0x15456BC Offset: 0x15416BC VA: 0x15456BC
	private void Start() { }

	// RVA: 0x1545844 Offset: 0x1541844 VA: 0x1545844
	private void FixedUpdate() { }

### dump.cs, line 304288
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	public GameObject EnemyChildrent; // 0x40
	private float AwakeDistance; // 0x48
	public Animator AnimatorController; // 0x50
	public GameObject MySpriteOBJ; // 0x58
	private Vector3 MySpriteOriginalScale; // 0x60
	private GameObject player; // 0x70
	public ParticleSystem ParticleTrail; // 0x78
	public AudioSource EnemyDiesAudio; // 0x80

	// Methods

	// RVA: 0x15456BC Offset: 0x15416BC VA: 0x15456BC
	private void Start() { }

	// RVA: 0x1545844 Offset: 0x1541844 VA: 0x1545844
	private void FixedUpdate() { }


### dump.cs, line 304289
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	public GameObject EnemyChildrent; // 0x40
	private float AwakeDistance; // 0x48
	public Animator AnimatorController; // 0x50
	public GameObject MySpriteOBJ; // 0x58
	private Vector3 MySpriteOriginalScale; // 0x60
	private GameObject player; // 0x70
	public ParticleSystem ParticleTrail; // 0x78
	public AudioSource EnemyDiesAudio; // 0x80

	// Methods

	// RVA: 0x15456BC Offset: 0x15416BC VA: 0x15456BC
	private void Start() { }

	// RVA: 0x1545844 Offset: 0x1541844 VA: 0x1545844
	private void FixedUpdate() { }

	// RVA: 0x1545C18 Offset: 0x1541C18 VA: 0x1545C18

### dump.cs, line 304296
	private Vector3 MySpriteOriginalScale; // 0x60
	private GameObject player; // 0x70
	public ParticleSystem ParticleTrail; // 0x78
	public AudioSource EnemyDiesAudio; // 0x80

	// Methods

	// RVA: 0x15456BC Offset: 0x15416BC VA: 0x15456BC
	private void Start() { }

	// RVA: 0x1545844 Offset: 0x1541844 VA: 0x1545844
	private void FixedUpdate() { }

	// RVA: 0x1545C18 Offset: 0x1541C18 VA: 0x1545C18
	private void OnCollisionEnter2D(Collision2D coll) { }

	// RVA: 0x1545E80 Offset: 0x1541E80 VA: 0x1545E80
	private void iDied() { }

	// RVA: 0x1546164 Offset: 0x1542164 VA: 0x1546164
	private void CheckPlayerDistance() { }

### dump.cs, line 304320
}

// Namespace: 
public class Enemy_FlyingA : MonoBehaviour // TypeDefIndex: 3689
{
	// Fields
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	public ParticleSystem ParticleTrail; // 0x60
	public AudioSource EnemyDiesAudio; // 0x68

	// Methods

	// RVA: 0x1546358 Offset: 0x1542358 VA: 0x1546358

### dump.cs, line 304326
	public float speed; // 0x20
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	public ParticleSystem ParticleTrail; // 0x60
	public AudioSource EnemyDiesAudio; // 0x68

	// Methods

	// RVA: 0x1546358 Offset: 0x1542358 VA: 0x1546358
	private void Start() { }

	// RVA: 0x15464CC Offset: 0x15424CC VA: 0x15464CC
	private void FixedUpdate() { }

	// RVA: 0x15468A0 Offset: 0x15428A0 VA: 0x15468A0

### dump.cs, line 304327
	private NinjaMovementScript PlayerScript; // 0x28
	private MainEventsLog mainEvent; // 0x30
	private bool EnemyAwake; // 0x38
	private bool EnemyDead; // 0x39
	private float AwakeDistance; // 0x3C
	public Animator AnimatorController; // 0x40
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	public ParticleSystem ParticleTrail; // 0x60
	public AudioSource EnemyDiesAudio; // 0x68

	// Methods

	// RVA: 0x1546358 Offset: 0x1542358 VA: 0x1546358
	private void Start() { }

	// RVA: 0x15464CC Offset: 0x15424CC VA: 0x15464CC
	private void FixedUpdate() { }

	// RVA: 0x15468A0 Offset: 0x15428A0 VA: 0x15468A0
	private void OnCollisionEnter2D(Collision2D coll) { }

### dump.cs, line 304333
	public GameObject MySpriteOBJ; // 0x48
	private Vector3 MySpriteOriginalScale; // 0x50
	public ParticleSystem ParticleTrail; // 0x60
	public AudioSource EnemyDiesAudio; // 0x68

	// Methods

	// RVA: 0x1546358 Offset: 0x1542358 VA: 0x1546358
	private void Start() { }

	// RVA: 0x15464CC Offset: 0x15424CC VA: 0x15464CC
	private void FixedUpdate() { }

	// RVA: 0x15468A0 Offset: 0x15428A0 VA: 0x15468A0
	private void OnCollisionEnter2D(Collision2D coll) { }

	// RVA: 0x1546B08 Offset: 0x1542B08 VA: 0x1546B08
	private void iDied() { }

	// RVA: 0x1546BA4 Offset: 0x1542BA4 VA: 0x1546BA4
	private void CheckPlayerDistance() { }

### dump.cs, line 304418
	private void Hit2(Vector2 v2) { }

	// RVA: 0x15475D8 Offset: 0x15435D8 VA: 0x15475D8
	private void DashOver() { }

	// RVA: 0x1547734 Offset: 0x1543734 VA: 0x1547734
	public void .ctor() { }
}

// Namespace: 
public class Key : MonoBehaviour // TypeDefIndex: 3693
{
	// Fields
	private MainEventsLog mainEvent; // 0x20
	private bool active; // 0x28

	// Methods

	// RVA: 0x154773C Offset: 0x154373C VA: 0x154773C
	private void Start() { }


### dump.cs, line 304458
	private void Hit(Vector2 p) { }

	// RVA: 0x1547918 Offset: 0x1543918 VA: 0x1547918
	private void DashOver() { }

	// RVA: 0x154791C Offset: 0x154391C VA: 0x154791C
	public void .ctor() { }
}

// Namespace: 
public enum LinhCam2Kiem.Linh // TypeDefIndex: 3695
{
	// Fields
	public int value__; // 0x0
	public const LinhCam2Kiem.Linh KhongKhien = 0;
	public const LinhCam2Kiem.Linh CoKhien = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class LinhCam2Kiem.<AttackCoolDown>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3696

### dump.cs, line 304475

// Namespace: 
[CompilerGenerated]
private sealed class LinhCam2Kiem.<AttackCoolDown>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3696
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LinhCam2Kiem <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x15495C0 Offset: 0x15455C0 VA: 0x15495C0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 304643
	public LinhCam2Kiem.Linh loaiLinh; // 0x4C
	public bool lostTarget; // 0x50
	public float watchDistance; // 0x54
	public float attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8

### dump.cs, line 304646
	public float attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0

### dump.cs, line 304650
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0
	public float attackingTime; // 0xD4
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0

### dump.cs, line 304664
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0
	public float attackingTime; // 0xD4
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0
	private float timeWork; // 0xE4
	private float timeMaster; // 0xE8
	private bool working; // 0xEC
	private float stunningTime; // 0xF0
	private bool matting; // 0xF4
	private float mattingTime; // 0xF8
	public float BatForce; // 0xFC
	private bool BVed; // 0x100
	private float vangingTime; // 0x104
	public Transform BvParticle; // 0x108
	public bool matThan; // 0x110
	public bool noBom; // 0x111
	public bool TestRag; // 0x112
	private GameObject matCheo; // 0x118

### dump.cs, line 304690
	public Transform BieuCam; // 0x138
	public Transform head; // 0x140
	public Transform neck; // 0x148
	private bool chetdash; // 0x150
	public Transform Body; // 0x158
	private ParticleSystem bvPar; // 0x160
	private GameObject parTG; // 0x168
	private bool getAu; // 0x170
	private AudioSource audioS; // 0x178
	private float keuTime; // 0x180
	private bool thankinh; // 0x184

	// Methods

	// RVA: 0x1547924 Offset: 0x1543924 VA: 0x1547924
	private void Start() { }

	// RVA: 0x1547C14 Offset: 0x1543C14 VA: 0x1547C14
	private void FixedUpdate() { }

	// RVA: 0x1548F74 Offset: 0x1544F74 VA: 0x1548F74

### dump.cs, line 304716
	// RVA: 0x15493F0 Offset: 0x15453F0 VA: 0x15493F0
	public void Chem() { }

	[IteratorStateMachine(typeof(LinhCam2Kiem.<AttackCoolDown>d__57))]
	// RVA: 0x1549390 Offset: 0x1545390 VA: 0x1549390
	private IEnumerator AttackCoolDown() { }

	// RVA: 0x1548468 Offset: 0x1544468 VA: 0x1548468
	private void DiTuan() { }

	// RVA: 0x15495E8 Offset: 0x15455E8 VA: 0x15495E8
	public void BatRa() { }

	[IteratorStateMachine(typeof(LinhCam2Kiem.<VangRa>d__61))]
	// RVA: 0x154972C Offset: 0x154572C VA: 0x154972C
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(LinhCam2Kiem.<BTh>d__62))]
	// RVA: 0x15497B4 Offset: 0x15457B4 VA: 0x15497B4
	private IEnumerator BTh() { }


### dump.cs, line 304718

	[IteratorStateMachine(typeof(LinhCam2Kiem.<AttackCoolDown>d__57))]
	// RVA: 0x1549390 Offset: 0x1545390 VA: 0x1549390
	private IEnumerator AttackCoolDown() { }

	// RVA: 0x1548468 Offset: 0x1544468 VA: 0x1548468
	private void DiTuan() { }

	// RVA: 0x15495E8 Offset: 0x15455E8 VA: 0x15495E8
	public void BatRa() { }

	[IteratorStateMachine(typeof(LinhCam2Kiem.<VangRa>d__61))]
	// RVA: 0x154972C Offset: 0x154572C VA: 0x154972C
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(LinhCam2Kiem.<BTh>d__62))]
	// RVA: 0x15497B4 Offset: 0x15457B4 VA: 0x15497B4
	private IEnumerator BTh() { }

	// RVA: 0x154983C Offset: 0x154583C VA: 0x154983C
	private void iDied() { }

### dump.cs, line 304751
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x154A468 Offset: 0x1546468 VA: 0x154A468
	private void DashOver() { }

	// RVA: 0x154A600 Offset: 0x1546600 VA: 0x154A600
	private void Exp() { }

	// RVA: 0x1549DC0 Offset: 0x1545DC0 VA: 0x1549DC0
	private void HitBack() { }

	// RVA: 0x154A7CC Offset: 0x15467CC VA: 0x154A7CC
	private void HitIdle() { }

	// RVA: 0x154AA70 Offset: 0x1546A70 VA: 0x154AA70
	private void BaoVeAnh() { }

	// RVA: 0x154AC44 Offset: 0x1546C44 VA: 0x154AC44
	private void ThoiBaoVe() { }

	// RVA: 0x154ACEC Offset: 0x1546CEC VA: 0x154ACEC

### dump.cs, line 304816

// Namespace: 
[CompilerGenerated]
private sealed class LinhCamKiem.<AttackCoolDown>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3702
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LinhCamKiem <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x154D160 Offset: 0x1549160 VA: 0x154D160
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 304866
	public int hp; // 0x48
	public bool lostTarget; // 0x4C
	public float watchDistance; // 0x50
	public float attackDistance; // 0x54
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool canSeePlayer; // 0x69
	private bool attacking; // 0x6A
	public Transform startPoint; // 0x70
	public Animator anim; // 0x78
	public GameObject MySpriteOBJ; // 0x80
	private Vector3 MySpriteOriginalScale; // 0x88
	private Transform player; // 0x98
	public AudioSource EnemyDiesAudio; // 0xA0
	private Transform target; // 0xA8
	private Vector2 dir; // 0xB0
	public LayerMask layer; // 0xB8
	public float attackingTime; // 0xBC
	private int crit; // 0xC0
	private bool active; // 0xC4

### dump.cs, line 304869
	public float attackDistance; // 0x54
	private NinjaMovementScript PlayerScript; // 0x58
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool canSeePlayer; // 0x69
	private bool attacking; // 0x6A
	public Transform startPoint; // 0x70
	public Animator anim; // 0x78
	public GameObject MySpriteOBJ; // 0x80
	private Vector3 MySpriteOriginalScale; // 0x88
	private Transform player; // 0x98
	public AudioSource EnemyDiesAudio; // 0xA0
	private Transform target; // 0xA8
	private Vector2 dir; // 0xB0
	public LayerMask layer; // 0xB8
	public float attackingTime; // 0xBC
	private int crit; // 0xC0
	private bool active; // 0xC4

	// Methods


### dump.cs, line 304871
	private MainEventsLog mainEvent; // 0x60
	private bool EnemyDead; // 0x68
	private bool canSeePlayer; // 0x69
	private bool attacking; // 0x6A
	public Transform startPoint; // 0x70
	public Animator anim; // 0x78
	public GameObject MySpriteOBJ; // 0x80
	private Vector3 MySpriteOriginalScale; // 0x88
	private Transform player; // 0x98
	public AudioSource EnemyDiesAudio; // 0xA0
	private Transform target; // 0xA8
	private Vector2 dir; // 0xB0
	public LayerMask layer; // 0xB8
	public float attackingTime; // 0xBC
	private int crit; // 0xC0
	private bool active; // 0xC4

	// Methods

	// RVA: 0x154BE08 Offset: 0x1547E08 VA: 0x154BE08
	private void Start() { }

### dump.cs, line 304877
	public GameObject MySpriteOBJ; // 0x80
	private Vector3 MySpriteOriginalScale; // 0x88
	private Transform player; // 0x98
	public AudioSource EnemyDiesAudio; // 0xA0
	private Transform target; // 0xA8
	private Vector2 dir; // 0xB0
	public LayerMask layer; // 0xB8
	public float attackingTime; // 0xBC
	private int crit; // 0xC0
	private bool active; // 0xC4

	// Methods

	// RVA: 0x154BE08 Offset: 0x1547E08 VA: 0x154BE08
	private void Start() { }

	// RVA: 0x154BF64 Offset: 0x1547F64 VA: 0x154BF64
	private void FixedUpdate() { }

	// RVA: 0x154CA60 Offset: 0x1548A60 VA: 0x154CA60
	private void DiXien() { }

### dump.cs, line 304881
	private Transform target; // 0xA8
	private Vector2 dir; // 0xB0
	public LayerMask layer; // 0xB8
	public float attackingTime; // 0xBC
	private int crit; // 0xC0
	private bool active; // 0xC4

	// Methods

	// RVA: 0x154BE08 Offset: 0x1547E08 VA: 0x154BE08
	private void Start() { }

	// RVA: 0x154BF64 Offset: 0x1547F64 VA: 0x154BF64
	private void FixedUpdate() { }

	// RVA: 0x154CA60 Offset: 0x1548A60 VA: 0x154CA60
	private void DiXien() { }

	// RVA: 0x154CF94 Offset: 0x1548F94 VA: 0x154CF94
	public void Chem() { }


### dump.cs, line 304899
	// RVA: 0x154CF94 Offset: 0x1548F94 VA: 0x154CF94
	public void Chem() { }

	[IteratorStateMachine(typeof(LinhCamKiem.<AttackCoolDown>d__31))]
	// RVA: 0x154CF34 Offset: 0x1548F34 VA: 0x154CF34
	private IEnumerator AttackCoolDown() { }

	// RVA: 0x154C54C Offset: 0x154854C VA: 0x154C54C
	private void DiTuan() { }

	// RVA: 0x154D188 Offset: 0x1549188 VA: 0x154D188
	private void iDied() { }

	// RVA: 0x154D2F4 Offset: 0x15492F4 VA: 0x154D2F4
	private void Hit(Vector2 p) { }

	// RVA: 0x154D448 Offset: 0x1549448 VA: 0x154D448
	private void Hit2(Vector2 p) { }

	// RVA: 0x154D460 Offset: 0x1549460 VA: 0x154D460
	private void DashOver() { }

### dump.cs, line 304901

	[IteratorStateMachine(typeof(LinhCamKiem.<AttackCoolDown>d__31))]
	// RVA: 0x154CF34 Offset: 0x1548F34 VA: 0x154CF34
	private IEnumerator AttackCoolDown() { }

	// RVA: 0x154C54C Offset: 0x154854C VA: 0x154C54C
	private void DiTuan() { }

	// RVA: 0x154D188 Offset: 0x1549188 VA: 0x154D188
	private void iDied() { }

	// RVA: 0x154D2F4 Offset: 0x15492F4 VA: 0x154D2F4
	private void Hit(Vector2 p) { }

	// RVA: 0x154D448 Offset: 0x1549448 VA: 0x154D448
	private void Hit2(Vector2 p) { }

	// RVA: 0x154D460 Offset: 0x1549460 VA: 0x154D460
	private void DashOver() { }

	// RVA: 0x154D5A0 Offset: 0x15495A0 VA: 0x154D5A0

### dump.cs, line 304916
	private void Hit2(Vector2 p) { }

	// RVA: 0x154D460 Offset: 0x1549460 VA: 0x154D460
	private void DashOver() { }

	// RVA: 0x154D5A0 Offset: 0x15495A0 VA: 0x154D5A0
	private void Exp() { }

	// RVA: 0x154D61C Offset: 0x154961C VA: 0x154D61C
	public void .ctor() { }
}

// Namespace: 
public class LinhCamKiemAnimation : MonoBehaviour // TypeDefIndex: 3704
{
	// Fields
	public LinhCamKiem mainScript; // 0x20

	// Methods

	// RVA: 0x154D730 Offset: 0x1549730 VA: 0x154D730

### dump.cs, line 304951

// Namespace: 
[CompilerGenerated]
private sealed class LinhChemLienTuc.<AttackCoolDown>d__66 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3706
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float t; // 0x20
	public LinhChemLienTuc <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1551828 Offset: 0x154D828 VA: 0x1551828
	public void .ctor(int <>1__state) { }


### dump.cs, line 305160
	public LinhChemLienTuc.Linh loaiLinh; // 0x4C
	public bool lostTarget; // 0x50
	public float watchDistance; // 0x54
	public float attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8

### dump.cs, line 305163
	public float attackDistance; // 0x58
	private NinjaMovementScript PlayerScript; // 0x60
	private MainEventsLog mainEvent; // 0x68
	private bool EnemyDead; // 0x70
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0

### dump.cs, line 305167
	private bool stunning; // 0x71
	private bool vanging; // 0x72
	private bool canSeePlayer; // 0x73
	private bool attacking; // 0x74
	public Transform startPoint; // 0x78
	public Collider2D KhienColl; // 0x80
	public Animator anim; // 0x88
	public float maxTimeIlde; // 0x90
	public float minTimeIdle; // 0x94
	public float maxTimeWork; // 0x98
	public float minTimeWork; // 0x9C
	public GameObject MySpriteOBJ; // 0xA0
	private Vector3 MySpriteOriginalScale; // 0xA8
	private Transform player; // 0xB8
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0
	public float attackingTime; // 0xD4
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0

### dump.cs, line 305181
	private Transform target; // 0xC0
	private Vector2 dir; // 0xC8
	public LayerMask layer; // 0xD0
	public float attackingTime; // 0xD4
	private int crit; // 0xD8
	private bool active; // 0xDC
	private float timeIdle; // 0xE0
	private float timeWork; // 0xE4
	private float timeMaster; // 0xE8
	private bool working; // 0xEC
	private float stunningTime; // 0xF0
	private bool matting; // 0xF4
	private float mattingTime; // 0xF8
	public float BatForce; // 0xFC
	private bool BVed; // 0x100
	public int kickFameOrigin; // 0x104
	private int kickFame; // 0x108
	public Transform KickPos; // 0x110
	public float KickSpeed; // 0x118
	public Transform BvParticle; // 0x120
	public bool matThan; // 0x128

### dump.cs, line 305210
	public float lonGetCol; // 0x14C
	public float bienDo; // 0x150
	private bool ChetNo; // 0x154
	public Transform Weapon; // 0x158
	public float ExplorRadius; // 0x160
	public Transform BieuCam; // 0x168
	public Transform head; // 0x170
	public Transform neck; // 0x178
	public Transform Body; // 0x180
	private ParticleSystem bvPar; // 0x188
	private GameObject parTG; // 0x190
	private bool getAu; // 0x198
	private AudioSource audioS; // 0x1A0
	private float keuTime; // 0x1A8
	private bool thankinh; // 0x1AC

	// Methods

	// RVA: 0x154D74C Offset: 0x154974C VA: 0x154D74C
	private void Start() { }


### dump.cs, line 305247
	// RVA: 0x154F39C Offset: 0x154B39C VA: 0x154F39C
	private IEnumerator GetColl(float t) { }

	[IteratorStateMachine(typeof(LinhChemLienTuc.<AttackCoolDown>d__66))]
	// RVA: 0x154F190 Offset: 0x154B190 VA: 0x154F190
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x154F5F8 Offset: 0x154B5F8 VA: 0x154F5F8
	public void Chem() { }

	// RVA: 0x154E2CC Offset: 0x154A2CC VA: 0x154E2CC
	private void DiTuan() { }

	// RVA: 0x154F7C8 Offset: 0x154B7C8 VA: 0x154F7C8
	public void BatRa() { }

	[IteratorStateMachine(typeof(LinhChemLienTuc.<VangRa>d__71))]
	// RVA: 0x154F900 Offset: 0x154B900 VA: 0x154F900
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(LinhChemLienTuc.<BTh>d__72))]

### dump.cs, line 305249

	[IteratorStateMachine(typeof(LinhChemLienTuc.<AttackCoolDown>d__66))]
	// RVA: 0x154F190 Offset: 0x154B190 VA: 0x154F190
	private IEnumerator AttackCoolDown(float t) { }

	// RVA: 0x154F5F8 Offset: 0x154B5F8 VA: 0x154F5F8
	public void Chem() { }

	// RVA: 0x154E2CC Offset: 0x154A2CC VA: 0x154E2CC
	private void DiTuan() { }

	// RVA: 0x154F7C8 Offset: 0x154B7C8 VA: 0x154F7C8
	public void BatRa() { }

	[IteratorStateMachine(typeof(LinhChemLienTuc.<VangRa>d__71))]
	// RVA: 0x154F900 Offset: 0x154B900 VA: 0x154F900
	private IEnumerator VangRa() { }

	[IteratorStateMachine(typeof(LinhChemLienTuc.<BTh>d__72))]
	// RVA: 0x154F968 Offset: 0x154B968 VA: 0x154F968
	private IEnumerator BTh() { }

### dump.cs, line 305285
	private void MatHut(Vector2 bdPos) { }

	// RVA: 0x1550604 Offset: 0x154C604 VA: 0x1550604
	private void DashOver() { }

	// RVA: 0x155079C Offset: 0x154C79C VA: 0x155079C
	private void Exp() { }

	// RVA: 0x154FF54 Offset: 0x154BF54 VA: 0x154FF54
	private void HitBack() { }

	// RVA: 0x1550968 Offset: 0x154C968 VA: 0x1550968
	private void HitIdle() { }

	// RVA: 0x1550C0C Offset: 0x154CC0C VA: 0x1550C0C
	private void BaoVeAnh() { }

	// RVA: 0x1550DE0 Offset: 0x154CDE0 VA: 0x1550DE0
	private void ThoiBaoVe() { }

	// RVA: 0x1550E88 Offset: 0x154CE88 VA: 0x1550E88

### dump.cs, line 305365

// Namespace: 
[CompilerGenerated]
private sealed class LinhDash.<AttackCoolDown>d__30 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3713
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LinhDash <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x155361C Offset: 0x154F61C VA: 0x155361C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]

### dump.cs, line 305370
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LinhDash <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x155361C Offset: 0x154F61C VA: 0x155361C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x15539C4 Offset: 0x154F9C4 VA: 0x15539C4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x15539C8 Offset: 0x154F9C8 VA: 0x15539C8 Slot: 6
	private bool MoveNext() { }

## Names from script.json
- File: script.json; matches: 2053
- $.ScriptMethod[188].Name: Mono.Globalization.Unicode.SimpleCollator$$ToDashTypeValue
- $.ScriptMethod[188].Signature: uint8_t Mono_Globalization_Unicode_SimpleCollator__ToDashTypeValue (int32_t ext, int32_t opt, const MethodInfo* method);
- $.ScriptMethod[460].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$CreateHandle
- $.ScriptMethod[460].Signature: intptr_t Microsoft_Win32_SafeHandles_SafePasswordHandle__CreateHandle (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, System_String_o* password, const MethodInfo* method);
- $.ScriptMethod[461].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$FreeHandle
- $.ScriptMethod[461].Signature: void Microsoft_Win32_SafeHandles_SafePasswordHandle__FreeHandle (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, const MethodInfo* method);
- $.ScriptMethod[462].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$.ctor
- $.ScriptMethod[462].Signature: void Microsoft_Win32_SafeHandles_SafePasswordHandle___ctor (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, System_String_o* password, const MethodInfo* method);
- $.ScriptMethod[463].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$ReleaseHandle
- $.ScriptMethod[463].Signature: bool Microsoft_Win32_SafeHandles_SafePasswordHandle__ReleaseHandle (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, const MethodInfo* method);
- $.ScriptMethod[464].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$Dispose
- $.ScriptMethod[464].Signature: void Microsoft_Win32_SafeHandles_SafePasswordHandle__Dispose (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, bool disposing, const MethodInfo* method);
- $.ScriptMethod[465].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$get_IsInvalid
- $.ScriptMethod[465].Signature: bool Microsoft_Win32_SafeHandles_SafePasswordHandle__get_IsInvalid (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, const MethodInfo* method);
- $.ScriptMethod[466].Name: Microsoft.Win32.SafeHandles.SafePasswordHandle$$Mono_DangerousGetString
- $.ScriptMethod[466].Signature: System_String_o* Microsoft_Win32_SafeHandles_SafePasswordHandle__Mono_DangerousGetString (Microsoft_Win32_SafeHandles_SafePasswordHandle_o* __this, const MethodInfo* method);
- $.ScriptMethod[3056].Name: System.Guid$$TryParseGuidWithDashes
- $.ScriptMethod[3056].Signature: bool System_Guid__TryParseGuidWithDashes (System_ReadOnlySpan_char__o guidString, System_Guid_GuidResult_o* result, const MethodInfo* method);
- $.ScriptMethod[24188].Signature: System_Security_Cryptography_X509Certificates_X509CertificateImpl_o* System_Security_Cryptography_X509Certificates_X509Helper__Import (System_Byte_array* rawData, Microsoft_Win32_SafeHandles_SafePassw
- $.ScriptMethod[60461].Signature: void UnityEngine_UIElements_TextField___ctor (UnityEngine_UIElements_TextField_o* __this, System_String_o* label, int32_t maxLength, bool multiline, bool isPasswordField, uint16_t maskChar, const Meth
- $.ScriptMethod[60745].Name: UnityEngine.UIElements.TextInputBaseField<double>$$set_password
- $.ScriptMethod[60745].Signature: void UnityEngine_UIElements_TextInputBaseField_double___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21C8C40* method);
- $.ScriptMethod[60746].Name: UnityEngine.UIElements.TextInputBaseField<Hash128>$$set_password
- $.ScriptMethod[60746].Signature: void UnityEngine_UIElements_TextInputBaseField_Hash128___set_password (UnityEngine_UIElements_TextInputBaseField_Hash128__o* __this, bool value, const MethodInfo_21CD810* method);
- $.ScriptMethod[60747].Name: UnityEngine.UIElements.TextInputBaseField<int>$$set_password
- $.ScriptMethod[60747].Signature: void UnityEngine_UIElements_TextInputBaseField_int___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D2400* method);
- $.ScriptMethod[60748].Name: UnityEngine.UIElements.TextInputBaseField<long>$$set_password
- $.ScriptMethod[60748].Signature: void UnityEngine_UIElements_TextInputBaseField_long___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D6FD8* method);
- $.ScriptMethod[60749].Name: UnityEngine.UIElements.TextInputBaseField<object>$$set_password
- $.ScriptMethod[60749].Signature: void UnityEngine_UIElements_TextInputBaseField_object___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21DBBB0* method);
- $.ScriptMethod[60750].Name: UnityEngine.UIElements.TextInputBaseField<float>$$set_password
- $.ScriptMethod[60750].Signature: void UnityEngine_UIElements_TextInputBaseField_float___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E0788* method);
- $.ScriptMethod[60751].Name: UnityEngine.UIElements.TextInputBaseField<uint>$$set_password
- $.ScriptMethod[60751].Signature: void UnityEngine_UIElements_TextInputBaseField_uint___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E5358* method);
- $.ScriptMethod[60752].Name: UnityEngine.UIElements.TextInputBaseField<ulong>$$set_password
- $.ScriptMethod[60752].Signature: void UnityEngine_UIElements_TextInputBaseField_ulong___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E9F30* method);
- $.ScriptMethod[60753].Name: UnityEngine.UIElements.TextInputBaseField<__Il2CppFullySharedGenericType>$$set_password
- $.ScriptMethod[60753].Signature: void UnityEngine_UIElements_TextInputBaseField___Il2CppFullySharedGenericType___set_password (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21EEB08* met
- $.ScriptMethod[60871].Name: UnityEngine.UIElements.TextInputBaseField<double>$$get_isPasswordField
- $.ScriptMethod[60871].Signature: bool UnityEngine_UIElements_TextInputBaseField_double___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21C9898* method);
- $.ScriptMethod[60872].Name: UnityEngine.UIElements.TextInputBaseField<Hash128>$$get_isPasswordField
- $.ScriptMethod[60872].Signature: bool UnityEngine_UIElements_TextInputBaseField_Hash128___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_Hash128__o* __this, const MethodInfo_21CE468* method);
- $.ScriptMethod[60873].Name: UnityEngine.UIElements.TextInputBaseField<int>$$get_isPasswordField
- $.ScriptMethod[60873].Signature: bool UnityEngine_UIElements_TextInputBaseField_int___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21D3058* method);
- $.ScriptMethod[60874].Name: UnityEngine.UIElements.TextInputBaseField<long>$$get_isPasswordField
- $.ScriptMethod[60874].Signature: bool UnityEngine_UIElements_TextInputBaseField_long___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21D7C30* method);
- $.ScriptMethod[60875].Name: UnityEngine.UIElements.TextInputBaseField<object>$$get_isPasswordField
- $.ScriptMethod[60875].Signature: bool UnityEngine_UIElements_TextInputBaseField_object___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21DC808* method);
- $.ScriptMethod[60876].Name: UnityEngine.UIElements.TextInputBaseField<float>$$get_isPasswordField
- $.ScriptMethod[60876].Signature: bool UnityEngine_UIElements_TextInputBaseField_float___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21E13E0* method);
- $.ScriptMethod[60877].Name: UnityEngine.UIElements.TextInputBaseField<uint>$$get_isPasswordField
- $.ScriptMethod[60877].Signature: bool UnityEngine_UIElements_TextInputBaseField_uint___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21E5FB0* method);
- $.ScriptMethod[60878].Name: UnityEngine.UIElements.TextInputBaseField<ulong>$$get_isPasswordField
- $.ScriptMethod[60878].Signature: bool UnityEngine_UIElements_TextInputBaseField_ulong___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21EAB88* method);
- $.ScriptMethod[60879].Name: UnityEngine.UIElements.TextInputBaseField<__Il2CppFullySharedGenericType>$$get_isPasswordField
- $.ScriptMethod[60879].Signature: bool UnityEngine_UIElements_TextInputBaseField___Il2CppFullySharedGenericType___get_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21EF9E4* method);
- $.ScriptMethod[60880].Name: UnityEngine.UIElements.TextInputBaseField<double>$$set_isPasswordField
- $.ScriptMethod[60880].Signature: void UnityEngine_UIElements_TextInputBaseField_double___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21C9944* method);
- $.ScriptMethod[60881].Name: UnityEngine.UIElements.TextInputBaseField<Hash128>$$set_isPasswordField
- $.ScriptMethod[60881].Signature: void UnityEngine_UIElements_TextInputBaseField_Hash128___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_Hash128__o* __this, bool value, const MethodInfo_21CE514* method);
- $.ScriptMethod[60882].Name: UnityEngine.UIElements.TextInputBaseField<int>$$set_isPasswordField
- $.ScriptMethod[60882].Signature: void UnityEngine_UIElements_TextInputBaseField_int___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D3104* method);
- $.ScriptMethod[60883].Name: UnityEngine.UIElements.TextInputBaseField<long>$$set_isPasswordField
- $.ScriptMethod[60883].Signature: void UnityEngine_UIElements_TextInputBaseField_long___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D7CDC* method);
- $.ScriptMethod[60884].Name: UnityEngine.UIElements.TextInputBaseField<object>$$set_isPasswordField
- $.ScriptMethod[60884].Signature: void UnityEngine_UIElements_TextInputBaseField_object___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21DC8B4* method);
- $.ScriptMethod[60885].Name: UnityEngine.UIElements.TextInputBaseField<float>$$set_isPasswordField
- $.ScriptMethod[60885].Signature: void UnityEngine_UIElements_TextInputBaseField_float___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E148C* method);
- $.ScriptMethod[60886].Name: UnityEngine.UIElements.TextInputBaseField<uint>$$set_isPasswordField
- $.ScriptMethod[60886].Signature: void UnityEngine_UIElements_TextInputBaseField_uint___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E605C* method);
- $.ScriptMethod[60887].Name: UnityEngine.UIElements.TextInputBaseField<ulong>$$set_isPasswordField
- $.ScriptMethod[60887].Signature: void UnityEngine_UIElements_TextInputBaseField_ulong___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21EAC34* method);
- $.ScriptMethod[60888].Name: UnityEngine.UIElements.TextInputBaseField<__Il2CppFullySharedGenericType>$$set_isPasswordField
- $.ScriptMethod[60888].Signature: void UnityEngine_UIElements_TextInputBaseField___Il2CppFullySharedGenericType___set_isPasswordField (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21EFA
- $.ScriptMethod[61078].Name: UnityEngine.UIElements.TextInputBaseField<double>$$get_doubleClickSelectsWord
- $.ScriptMethod[61078].Signature: bool UnityEngine_UIElements_TextInputBaseField_double___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21CB364* method);
- $.ScriptMethod[61079].Name: UnityEngine.UIElements.TextInputBaseField<Hash128>$$get_doubleClickSelectsWord
- $.ScriptMethod[61079].Signature: bool UnityEngine_UIElements_TextInputBaseField_Hash128___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_Hash128__o* __this, const MethodInfo_21CFF44* method);
- $.ScriptMethod[61080].Name: UnityEngine.UIElements.TextInputBaseField<int>$$get_doubleClickSelectsWord
- $.ScriptMethod[61080].Signature: bool UnityEngine_UIElements_TextInputBaseField_int___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21D4B28* method);
- $.ScriptMethod[61081].Name: UnityEngine.UIElements.TextInputBaseField<long>$$get_doubleClickSelectsWord
- $.ScriptMethod[61081].Signature: bool UnityEngine_UIElements_TextInputBaseField_long___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21D9700* method);
- $.ScriptMethod[61082].Name: UnityEngine.UIElements.TextInputBaseField<object>$$get_doubleClickSelectsWord
- $.ScriptMethod[61082].Signature: bool UnityEngine_UIElements_TextInputBaseField_object___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21DE2D8* method);
- $.ScriptMethod[61083].Name: UnityEngine.UIElements.TextInputBaseField<float>$$get_doubleClickSelectsWord
- $.ScriptMethod[61083].Signature: bool UnityEngine_UIElements_TextInputBaseField_float___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21E2EAC* method);
- $.ScriptMethod[61084].Name: UnityEngine.UIElements.TextInputBaseField<uint>$$get_doubleClickSelectsWord
- $.ScriptMethod[61084].Signature: bool UnityEngine_UIElements_TextInputBaseField_uint___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21E7A80* method);
- $.ScriptMethod[61085].Name: UnityEngine.UIElements.TextInputBaseField<ulong>$$get_doubleClickSelectsWord
- $.ScriptMethod[61085].Signature: bool UnityEngine_UIElements_TextInputBaseField_ulong___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21EC658* method);
- $.ScriptMethod[61086].Name: UnityEngine.UIElements.TextInputBaseField<__Il2CppFullySharedGenericType>$$get_doubleClickSelectsWord
- $.ScriptMethod[61086].Signature: bool UnityEngine_UIElements_TextInputBaseField___Il2CppFullySharedGenericType___get_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, const MethodInfo_21F17BC* m
- $.ScriptMethod[61087].Name: UnityEngine.UIElements.TextInputBaseField<double>$$set_doubleClickSelectsWord
- $.ScriptMethod[61087].Signature: void UnityEngine_UIElements_TextInputBaseField_double___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21CB410* method);
- $.ScriptMethod[61088].Name: UnityEngine.UIElements.TextInputBaseField<Hash128>$$set_doubleClickSelectsWord
- $.ScriptMethod[61088].Signature: void UnityEngine_UIElements_TextInputBaseField_Hash128___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_Hash128__o* __this, bool value, const MethodInfo_21CFFF0* method);
- $.ScriptMethod[61089].Name: UnityEngine.UIElements.TextInputBaseField<int>$$set_doubleClickSelectsWord
- $.ScriptMethod[61089].Signature: void UnityEngine_UIElements_TextInputBaseField_int___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D4BD4* method);
- $.ScriptMethod[61090].Name: UnityEngine.UIElements.TextInputBaseField<long>$$set_doubleClickSelectsWord
- $.ScriptMethod[61090].Signature: void UnityEngine_UIElements_TextInputBaseField_long___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21D97AC* method);
- $.ScriptMethod[61091].Name: UnityEngine.UIElements.TextInputBaseField<object>$$set_doubleClickSelectsWord
- $.ScriptMethod[61091].Signature: void UnityEngine_UIElements_TextInputBaseField_object___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21DE384* method);
- $.ScriptMethod[61092].Name: UnityEngine.UIElements.TextInputBaseField<float>$$set_doubleClickSelectsWord
- $.ScriptMethod[61092].Signature: void UnityEngine_UIElements_TextInputBaseField_float___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E2F58* method);
- $.ScriptMethod[61093].Name: UnityEngine.UIElements.TextInputBaseField<uint>$$set_doubleClickSelectsWord
- $.ScriptMethod[61093].Signature: void UnityEngine_UIElements_TextInputBaseField_uint___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21E7B2C* method);
- $.ScriptMethod[61094].Name: UnityEngine.UIElements.TextInputBaseField<ulong>$$set_doubleClickSelectsWord
- $.ScriptMethod[61094].Signature: void UnityEngine_UIElements_TextInputBaseField_ulong___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInfo_21EC704* method);
- $.ScriptMethod[61095].Name: UnityEngine.UIElements.TextInputBaseField<__Il2CppFullySharedGenericType>$$set_doubleClickSelectsWord
- $.ScriptMethod[61095].Signature: void UnityEngine_UIElements_TextInputBaseField___Il2CppFullySharedGenericType___set_doubleClickSelectsWord (UnityEngine_UIElements_TextInputBaseField_TValueType__o* __this, bool value, const MethodInf
- $.ScriptMethod[69540].Name: UnityEngine.UIElements.StyleSheetUtility$$ConvertCamelToDash
- $.ScriptMethod[69540].Signature: System_String_o* UnityEngine_UIElements_StyleSheetUtility__ConvertCamelToDash (System_String_o* camel, const MethodInfo* method);
- $.ScriptMethod[69541].Name: UnityEngine.UIElements.StyleSheetUtility$$ConvertDashToHungarian
- $.ScriptMethod[69541].Signature: System_String_o* UnityEngine_UIElements_StyleSheetUtility__ConvertDashToHungarian (System_String_o* dash, const MethodInfo* method);
- $.ScriptMethod[69542].Name: UnityEngine.UIElements.StyleSheetUtility$$ConvertDashToUpperNoSpace
- $.ScriptMethod[69542].Signature: System_String_o* UnityEngine_UIElements_StyleSheetUtility__ConvertDashToUpperNoSpace (System_String_o* dash, bool firstCase, bool addSpace, const MethodInfo* method);
- $.ScriptMethod[69794].Name: UnityEngine.UIElements.TextElement$$UnityEngine.UIElements.ITextEdition.get_isPassword
- $.ScriptMethod[69794].Signature: bool UnityEngine_UIElements_TextElement__UnityEngine_UIElements_ITextEdition_get_isPassword (UnityEngine_UIElements_TextElement_o* __this, const MethodInfo* method);
- $.ScriptMethod[69795].Name: UnityEngine.UIElements.TextElement$$UnityEngine.UIElements.ITextEdition.set_isPassword
- $.ScriptMethod[69795].Signature: void UnityEngine_UIElements_TextElement__UnityEngine_UIElements_ITextEdition_set_isPassword (UnityEngine_UIElements_TextElement_o* __this, bool value, const MethodInfo* method);
- $.ScriptMethod[69796].Name: UnityEngine.UIElements.TextElement$$get_isPassword
- $.ScriptMethod[69796].Signature: bool UnityEngine_UIElements_TextElement__get_isPassword (UnityEngine_UIElements_TextElement_o* __this, const MethodInfo* method);
- $.ScriptMethod[69797].Name: UnityEngine.UIElements.TextElement$$set_isPassword
- $.ScriptMethod[69797].Signature: void UnityEngine_UIElements_TextElement__set_isPassword (UnityEngine_UIElements_TextElement_o* __this, bool value, const MethodInfo* method);
- $.ScriptMethod[69824].Name: UnityEngine.UIElements.TextElement$$UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord
- $.ScriptMethod[69824].Signature: bool UnityEngine_UIElements_TextElement__UnityEngine_UIElements_ITextSelection_get_doubleClickSelectsWord (UnityEngine_UIElements_TextElement_o* __this, const MethodInfo* method);
- $.ScriptMethod[69825].Name: UnityEngine.UIElements.TextElement$$UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord
- $.ScriptMethod[69825].Signature: void UnityEngine_UIElements_TextElement__UnityEngine_UIElements_ITextSelection_set_doubleClickSelectsWord (UnityEngine_UIElements_TextElement_o* __this, bool value, const MethodInfo* method);
- $.ScriptMethod[69826].Name: UnityEngine.UIElements.TextElement$$get_doubleClickSelectsWord
- $.ScriptMethod[69826].Signature: bool UnityEngine_UIElements_TextElement__get_doubleClickSelectsWord (UnityEngine_UIElements_TextElement_o* __this, const MethodInfo* method);
- $.ScriptMethod[69827].Name: UnityEngine.UIElements.TextElement$$set_doubleClickSelectsWord
- $.ScriptMethod[69827].Signature: void UnityEngine_UIElements_TextElement__set_doubleClickSelectsWord (UnityEngine_UIElements_TextElement_o* __this, bool value, const MethodInfo* method);
- $.ScriptMethod[72189].Name: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer$$IsNextLetterOrDash
- $.ScriptMethod[72189].Signature: bool UnityEngine_UIElements_StyleSheets_Syntax_StyleSyntaxTokenizer__IsNextLetterOrDash (System_String_o* s, int32_t index, const MethodInfo* method);
- $.ScriptMethod[74705].Name: F3DFXController$$NextWeapon
- $.ScriptMethod[74705].Signature: void F3DFXController__NextWeapon (F3DFXController_o* __this, const MethodInfo* method);
- $.ScriptMethod[74706].Name: F3DFXController$$PrevWeapon
- $.ScriptMethod[74706].Signature: void F3DFXController__PrevWeapon (F3DFXController_o* __this, const MethodInfo* method);
- $.ScriptMethod[74742].Name: F3DParticleScale$$ScaleShurikenSystems
- $.ScriptMethod[74742].Signature: void F3DParticleScale__ScaleShurikenSystems (F3DParticleScale_o* __this, float scaleFactor, const MethodInfo* method);
- $.ScriptMethod[74910].Name: FireballButtonShuriken$$OnMouseDown
- $.ScriptMethod[74910].Signature: void FireballButtonShuriken__OnMouseDown (FireballButtonShuriken_o* __this, const MethodInfo* method);
- $.ScriptMethod[74911].Name: FireballButtonShuriken$$.ctor
- $.ScriptMethod[74911].Signature: void FireballButtonShuriken___ctor (FireballButtonShuriken_o* __this, const MethodInfo* method);
- $.ScriptMethod[75316].Name: AudioEnemy$$get_Instance
- $.ScriptMethod[75316].Signature: AudioEnemy_o* AudioEnemy__get_Instance (const MethodInfo* method);
- $.ScriptMethod[75317].Name: AudioEnemy$$Start
- $.ScriptMethod[75317].Signature: void AudioEnemy__Start (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75318].Name: AudioEnemy$$OmBomChay
- $.ScriptMethod[75318].Signature: void AudioEnemy__OmBomChay (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75319].Name: AudioEnemy$$OmBomChet
- $.ScriptMethod[75319].Signature: void AudioEnemy__OmBomChet (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75320].Name: AudioEnemy$$GetAudioSource
- $.ScriptMethod[75320].Signature: UnityEngine_AudioSource_o* AudioEnemy__GetAudioSource (AudioEnemy_o* __this, bool tk, const MethodInfo* method);
- $.ScriptMethod[75321].Name: AudioEnemy$$GetAudioSourceMonster
- $.ScriptMethod[75321].Signature: UnityEngine_AudioSource_o* AudioEnemy__GetAudioSourceMonster (AudioEnemy_o* __this, bool tk, const MethodInfo* method);
- $.ScriptMethod[75322].Name: AudioEnemy$$GetAudioSourceSamurai
- $.ScriptMethod[75322].Signature: UnityEngine_AudioSource_o* AudioEnemy__GetAudioSourceSamurai (AudioEnemy_o* __this, bool tk, const MethodInfo* method);
- $.ScriptMethod[75323].Name: AudioEnemy$$GetAudioSourceXuong
- $.ScriptMethod[75323].Signature: UnityEngine_AudioSource_o* AudioEnemy__GetAudioSourceXuong (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75324].Name: AudioEnemy$$Keu1Tieng
- $.ScriptMethod[75324].Signature: void AudioEnemy__Keu1Tieng (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75325].Name: AudioEnemy$$Keu1TiengMonster
- $.ScriptMethod[75325].Signature: void AudioEnemy__Keu1TiengMonster (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75326].Name: AudioEnemy$$Keu1TiengSamurai
- $.ScriptMethod[75326].Signature: void AudioEnemy__Keu1TiengSamurai (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75327].Name: AudioEnemy$$KeuAttStrong
- $.ScriptMethod[75327].Signature: void AudioEnemy__KeuAttStrong (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75328].Name: AudioEnemy$$KeuAttNormal
- $.ScriptMethod[75328].Signature: void AudioEnemy__KeuAttNormal (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75329].Name: AudioEnemy$$KeuAttRanger
- $.ScriptMethod[75329].Signature: void AudioEnemy__KeuAttRanger (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75330].Name: AudioEnemy$$KeuAttLienTuc
- $.ScriptMethod[75330].Signature: void AudioEnemy__KeuAttLienTuc (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75331].Name: AudioEnemy$$KeuAttQuayTay
- $.ScriptMethod[75331].Signature: void AudioEnemy__KeuAttQuayTay (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75332].Name: AudioEnemy$$KeuAttMonster
- $.ScriptMethod[75332].Signature: void AudioEnemy__KeuAttMonster (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75333].Name: AudioEnemy$$KeuAttNemBom
- $.ScriptMethod[75333].Signature: void AudioEnemy__KeuAttNemBom (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75334].Name: AudioEnemy$$KeuAttSamuraiChem
- $.ScriptMethod[75334].Signature: void AudioEnemy__KeuAttSamuraiChem (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75335].Name: AudioEnemy$$KeuAttSamuraiDa
- $.ScriptMethod[75335].Signature: void AudioEnemy__KeuAttSamuraiDa (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75336].Name: AudioEnemy$$KeuAttSamuraiLenKhien
- $.ScriptMethod[75336].Signature: void AudioEnemy__KeuAttSamuraiLenKhien (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75337].Name: AudioEnemy$$KeuGiayChet
- $.ScriptMethod[75337].Signature: void AudioEnemy__KeuGiayChet (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, bool chetdash, const MethodInfo* method);
- $.ScriptMethod[75338].Name: AudioEnemy$$KeuGiayChetNemBom
- $.ScriptMethod[75338].Signature: void AudioEnemy__KeuGiayChetNemBom (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75339].Name: AudioEnemy$$KeuNoBom
- $.ScriptMethod[75339].Signature: void AudioEnemy__KeuNoBom (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75340].Name: AudioEnemy$$KeuGiayChetMonster
- $.ScriptMethod[75340].Signature: void AudioEnemy__KeuGiayChetMonster (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75341].Name: AudioEnemy$$KeuNoBomMonster
- $.ScriptMethod[75341].Signature: void AudioEnemy__KeuNoBomMonster (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75342].Name: AudioEnemy$$KeuGiayChetSamurai
- $.ScriptMethod[75342].Signature: void AudioEnemy__KeuGiayChetSamurai (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75343].Name: AudioEnemy$$KeuNoBomSamurai
- $.ScriptMethod[75343].Signature: void AudioEnemy__KeuNoBomSamurai (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, bool tk, const MethodInfo* method);
- $.ScriptMethod[75344].Name: AudioEnemy$$KeuGiayChetXuong
- $.ScriptMethod[75344].Signature: void AudioEnemy__KeuGiayChetXuong (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75345].Name: AudioEnemy$$SamuraiXuatHien
- $.ScriptMethod[75345].Signature: void AudioEnemy__SamuraiXuatHien (AudioEnemy_o* __this, UnityEngine_AudioSource_o* au, const MethodInfo* method);
- $.ScriptMethod[75346].Name: AudioEnemy$$.ctor
- $.ScriptMethod[75346].Signature: void AudioEnemy___ctor (AudioEnemy_o* __this, const MethodInfo* method);
- $.ScriptMethod[75349].Name: AudioPlayer$$DashPlay
- $.ScriptMethod[75349].Signature: void AudioPlayer__DashPlay (AudioPlayer_o* __this, const MethodInfo* method);
- $.ScriptMethod[75352].Name: AudioPlayer$$playerDashOk
- $.ScriptMethod[75352].Signature: void AudioPlayer__playerDashOk (AudioPlayer_o* __this, int32_t enemynumber, const MethodInfo* method);
- $.ScriptMethod[75395].Name: CaiLo$$DashOver
- $.ScriptMethod[75395].Signature: void CaiLo__DashOver (CaiLo_o* __this, const MethodInfo* method);
- $.ScriptMethod[75408].Name: CheckPointBoss$$Start
- $.ScriptMethod[75408].Signature: void CheckPointBoss__Start (CheckPointBoss_o* __this, const MethodInfo* method);
- $.ScriptMethod[75409].Name: CheckPointBoss$$OnTriggerEnter2D
- $.ScriptMethod[75409].Signature: void CheckPointBoss__OnTriggerEnter2D (CheckPointBoss_o* __this, UnityEngine_Collider2D_o* other, const MethodInfo* method);
- $.ScriptMethod[75410].Name: CheckPointBoss$$.ctor
- $.ScriptMethod[75410].Signature: void CheckPointBoss___ctor (CheckPointBoss_o* __this, const MethodInfo* method);
- $.ScriptMethod[75431].Name: CotTruyenLeader$$Start
- $.ScriptMethod[75431].Signature: void CotTruyenLeader__Start (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75432].Name: CotTruyenLeader$$Update
- $.ScriptMethod[75432].Signature: void CotTruyenLeader__Update (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75433].Name: CotTruyenLeader$$TangAm
- $.ScriptMethod[75433].Signature: void CotTruyenLeader__TangAm (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75434].Name: CotTruyenLeader$$GiamAm
- $.ScriptMethod[75434].Signature: void CotTruyenLeader__GiamAm (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75435].Name: CotTruyenLeader$$ChuyenNhac
- $.ScriptMethod[75435].Signature: void CotTruyenLeader__ChuyenNhac (CotTruyenLeader_o* __this, UnityEngine_AudioClip_o* clip, const MethodInfo* method);
- $.ScriptMethod[75436].Name: CotTruyenLeader$$yehh
- $.ScriptMethod[75436].Signature: void CotTruyenLeader__yehh (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75437].Name: CotTruyenLeader$$VaoChoi
- $.ScriptMethod[75437].Signature: void CotTruyenLeader__VaoChoi (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75438].Name: CotTruyenLeader$$.ctor
- $.ScriptMethod[75438].Signature: void CotTruyenLeader___ctor (CotTruyenLeader_o* __this, const MethodInfo* method);
- $.ScriptMethod[75527].Name: Boss1.<AttackCoolDown>d__67$$.ctor
- $.ScriptMethod[75527].Signature: void Boss1__AttackCoolDown_d__67___ctor (Boss1__AttackCoolDown_d__67_o* __this, int32_t __1__state, const MethodInfo* method);
- $.ScriptMethod[75528].Name: Boss1.<AttackCoolDown>d__67$$System.IDisposable.Dispose
- $.ScriptMethod[75528].Signature: void Boss1__AttackCoolDown_d__67__System_IDisposable_Dispose (Boss1__AttackCoolDown_d__67_o* __this, const MethodInfo* method);
- $.ScriptMethod[75529].Name: Boss1.<AttackCoolDown>d__67$$MoveNext
- $.ScriptMethod[75529].Signature: bool Boss1__AttackCoolDown_d__67__MoveNext (Boss1__AttackCoolDown_d__67_o* __this, const MethodInfo* method);
- $.ScriptMethod[75530].Name: Boss1.<AttackCoolDown>d__67$$System.Collections.Generic.IEnumerator<System.Object>.get_Current
- $.ScriptMethod[75530].Signature: Il2CppObject* Boss1__AttackCoolDown_d__67__System_Collections_Generic_IEnumerator_System_Object__get_Current (Boss1__AttackCoolDown_d__67_o* __this, const MethodInfo* method);
- $.ScriptMethod[75531].Name: Boss1.<AttackCoolDown>d__67$$System.Collections.IEnumerator.Reset
- $.ScriptMethod[75531].Signature: void Boss1__AttackCoolDown_d__67__System_Collections_IEnumerator_Reset (Boss1__AttackCoolDown_d__67_o* __this, const MethodInfo* method);
- $.ScriptMethod[75532].Name: Boss1.<AttackCoolDown>d__67$$System.Collections.IEnumerator.get_Current
- $.ScriptMethod[75532].Signature: Il2CppObject* Boss1__AttackCoolDown_d__67__System_Collections_IEnumerator_get_Current (Boss1__AttackCoolDown_d__67_o* __this, const MethodInfo* method);
- $.ScriptMethod[75533].Name: Boss1.<BTh>d__75$$.ctor
- $.ScriptMethod[75533].Signature: void Boss1__BTh_d__75___ctor (Boss1__BTh_d__75_o* __this, int32_t __1__state, const MethodInfo* method);
- $.ScriptMethod[75534].Name: Boss1.<BTh>d__75$$System.IDisposable.Dispose
- $.ScriptMethod[75534].Signature: void Boss1__BTh_d__75__System_IDisposable_Dispose (Boss1__BTh_d__75_o* __this, const MethodInfo* method);

## What this can support
- This method map may recover class names, fields, method names and native offsets from the IL2CPP binary.
- It does not recreate original C# method bodies by itself. Native ARM64 method logic requires additional disassembly/reverse analysis or a carefully validated binary patch.
- Existing playable scene/level layouts remain unchanged.
