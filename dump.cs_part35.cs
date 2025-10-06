	// RVA: 0x1EB3150 Offset: 0x1EB2350 VA: 0x181EB3150
	protected void .ctor() { }

	// RVA: 0x1EB3060 Offset: 0x1EB2260 VA: 0x181EB3060
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x1EAFA00 Offset: 0x1EAEC00 VA: 0x181EAFA00
	public void Add(string name, string value) { }

	// RVA: 0x1EAF960 Offset: 0x1EAEB60 VA: 0x181EAF960
	public void Add(string name, IEnumerable<string> values) { }

	// RVA: 0x1EAF500 Offset: 0x1EAE700 VA: 0x181EAF500
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x1EB0680 Offset: 0x1EAF880 VA: 0x181EB0680
	public bool TryAddWithoutValidation(string name, string value) { }

	// RVA: 0x1EB0700 Offset: 0x1EAF900 VA: 0x181EB0700
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x1EAFAB0 Offset: 0x1EAECB0 VA: 0x181EAFAB0
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x1EB08A0 Offset: 0x1EAFAA0 VA: 0x181EB08A0
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	// RVA: 0x1EAFC30 Offset: 0x1EAEE30 VA: 0x181EAFC30
	public bool Contains(string name) { }

	[IteratorStateMachine(typeof(HttpHeaders.<GetEnumerator>d__19))]
	// RVA: 0x1EAFE60 Offset: 0x1EAF060 VA: 0x181EAFE60 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x1EAFE60 Offset: 0x1EAF060 VA: 0x181EAFE60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1EB0320 Offset: 0x1EAF520 VA: 0x181EB0320
	public bool Remove(string name) { }

	// RVA: 0x1EB09E0 Offset: 0x1EAFBE0 VA: 0x181EB09E0
	public bool TryGetValues(string name, out IEnumerable<string> values) { }

	// RVA: 0x1EAFFC0 Offset: 0x1EAF1C0 VA: 0x181EAFFC0
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x1EB0390 Offset: 0x1EAF590 VA: 0x181EB0390 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA21480 Offset: 0xA20680 VA: 0x180A21480
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x1EAFCA0 Offset: 0x1EAEEA0 VA: 0x181EAFCA0
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x1EAFEC0 Offset: 0x1EAF0C0 VA: 0x181EAFEC0
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA21860 Offset: 0xA20A60 VA: 0x180A21860
	|-HttpHeaders.GetValue<Nullable<long>>
	|
	|-RVA: 0xA21B70 Offset: 0xA20D70 VA: 0x180A21B70
	|-HttpHeaders.GetValue<object>
	|
	|-RVA: 0xA21560 Offset: 0xA20760 VA: 0x180A21560
	|-HttpHeaders.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA21E40 Offset: 0xA21040 VA: 0x180A21E40
	|-HttpHeaders.GetValues<object>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22330 Offset: 0xA21530 VA: 0x180A22330
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xA22410 Offset: 0xA21610 VA: 0x180A22410
	|-HttpHeaders.SetValue<object>
	|
	|-RVA: 0xA22210 Offset: 0xA21410 VA: 0x180A22210
	|-HttpHeaders.SetValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpRequestHeaders.<>c // TypeDefIndex: 17034
{
	// Fields
	public static readonly HttpRequestHeaders.<>c <>9; // 0x0
	public static Predicate<string> <>9__19_0; // 0x8
	public static Predicate<TransferCodingHeaderValue> <>9__29_0; // 0x10
	public static Predicate<TransferCodingHeaderValue> <>9__71_0; // 0x18

	// Methods

	// RVA: 0x1EC3920 Offset: 0x1EC2B20 VA: 0x181EC3920
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC37C0 Offset: 0x1EC29C0 VA: 0x181EC37C0
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x1EC3810 Offset: 0x1EC2A10 VA: 0x181EC3810
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x1EC3860 Offset: 0x1EC2A60 VA: 0x181EC3860
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }
}

// Namespace: System.Net.Http.Headers
public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 17035
{
	// Fields
	private Nullable<bool> expectContinue; // 0x20

	// Properties
	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }

	// Methods

	// RVA: 0x1EB3CC0 Offset: 0x1EB2EC0 VA: 0x181EB3CC0
	internal void .ctor() { }

	// RVA: 0x1EB3EE0 Offset: 0x1EB30E0 VA: 0x181EB3EE0
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x1EB3D10 Offset: 0x1EB2F10 VA: 0x181EB3D10
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x1EB3F30 Offset: 0x1EB3130 VA: 0x181EB3F30
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x1EB40E0 Offset: 0x1EB32E0 VA: 0x181EB40E0
	public string get_Host() { }

	// RVA: 0x1EB42E0 Offset: 0x1EB34E0 VA: 0x181EB42E0
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x1EB4130 Offset: 0x1EB3330 VA: 0x181EB4130
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x1EB3AB0 Offset: 0x1EB2CB0 VA: 0x181EB3AB0
	internal void AddHeaders(HttpRequestHeaders headers) { }
}

// Namespace: System.Net.Http.Headers
public sealed class HttpResponseHeaders : HttpHeaders // TypeDefIndex: 17036
{
	// Properties
	public RetryConditionHeaderValue RetryAfter { get; }

	// Methods

	// RVA: 0x1EB4DC0 Offset: 0x1EB3FC0 VA: 0x181EB4DC0
	internal void .ctor() { }

	// RVA: 0x1EB4E10 Offset: 0x1EB4010 VA: 0x181EB4E10
	public RetryConditionHeaderValue get_RetryAfter() { }
}

// Namespace: 
public enum Token.Type // TypeDefIndex: 17037
{
	// Fields
	public int value__; // 0x0
	public const Token.Type Error = 0;
	public const Token.Type End = 1;
	public const Token.Type Token = 2;
	public const Token.Type QuotedString = 3;
	public const Token.Type SeparatorEqual = 4;
	public const Token.Type SeparatorSemicolon = 5;
	public const Token.Type SeparatorSlash = 6;
	public const Token.Type SeparatorDash = 7;
	public const Token.Type SeparatorComma = 8;
	public const Token.Type OpenParens = 9;
}

// Namespace: System.Net.Http.Headers
internal struct Token // TypeDefIndex: 17038
{
	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGenerated]
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGenerated]
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x1EBEEA0 Offset: 0x1EBE0A0 VA: 0x181EBEEA0
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_StartPosition() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	private void set_StartPosition(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_EndPosition() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	private void set_EndPosition(int value) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Token.Type get_Kind() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x1EBED50 Offset: 0x1EBDF50 VA: 0x181EBED50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EBEE10 Offset: 0x1EBE010 VA: 0x181EBEE10
	private static void .cctor() { }
}

// Namespace: System.Net.Http.Headers
internal class Lexer // TypeDefIndex: 17039
{
	// Fields
	private static readonly bool[] token_chars; // 0x0
	private static readonly int last_token_char; // 0x8
	private static readonly string[] dt_formats; // 0x10
	private readonly string s; // 0x10
	private int pos; // 0x18

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string stream) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Position() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Position(int value) { }

	// RVA: 0x1EB5660 Offset: 0x1EB4860 VA: 0x181EB5660
	public string GetStringValue(Token token) { }

	// RVA: 0x1EB55E0 Offset: 0x1EB47E0 VA: 0x181EB55E0
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x1EB5530 Offset: 0x1EB4730 VA: 0x181EB5530
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x1EB55B0 Offset: 0x1EB47B0 VA: 0x181EB55B0
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x1EB56D0 Offset: 0x1EB48D0 VA: 0x181EB56D0
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x1EB6170 Offset: 0x1EB5370 VA: 0x181EB6170
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x1EB6260 Offset: 0x1EB5460 VA: 0x181EB6260
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x1EB6350 Offset: 0x1EB5550 VA: 0x181EB6350
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x1EB5E50 Offset: 0x1EB5050 VA: 0x181EB5E50
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x1EB5F90 Offset: 0x1EB5190 VA: 0x181EB5F90
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x1EB6080 Offset: 0x1EB5280 VA: 0x181EB6080
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x1EB5810 Offset: 0x1EB4A10 VA: 0x181EB5810
	public static bool IsValidToken(string input) { }

	// RVA: 0x1EB5770 Offset: 0x1EB4970 VA: 0x181EB5770
	public static bool IsValidCharacter(char input) { }

	// RVA: 0xB92F10 Offset: 0xB92110 VA: 0x180B92F10
	public void EatChar() { }

	// RVA: 0x1EB5940 Offset: 0x1EB4B40 VA: 0x181EB5940
	public int PeekChar() { }

	// RVA: 0x1EB5980 Offset: 0x1EB4B80 VA: 0x181EB5980
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x1EB5AD0 Offset: 0x1EB4CD0 VA: 0x181EB5AD0
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x1EB64D0 Offset: 0x1EB56D0 VA: 0x181EB64D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MediaTypeHeaderValue.<>c // TypeDefIndex: 17040
{
	// Fields
	public static readonly MediaTypeHeaderValue.<>c <>9; // 0x0
	public static Predicate<NameValueHeaderValue> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x1EC39E0 Offset: 0x1EC2BE0 VA: 0x181EC39E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC3770 Offset: 0x1EC2970 VA: 0x181EC3770
	internal bool <get_CharSet>b__6_0(NameValueHeaderValue l) { }
}

// Namespace: System.Net.Http.Headers
public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 17041
{
	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1EB70E0 Offset: 0x1EB62E0 VA: 0x181EB70E0
	public void .ctor(string mediaType) { }

	// RVA: 0x1EB6E30 Offset: 0x1EB6030 VA: 0x181EB6E30
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1EB7270 Offset: 0x1EB6470 VA: 0x181EB7270
	public string get_CharSet() { }

	// RVA: 0x1EB7400 Offset: 0x1EB6600 VA: 0x181EB7400
	public void set_CharSet(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_MediaType() { }

	// RVA: 0x1EB75D0 Offset: 0x1EB67D0 VA: 0x181EB75D0
	public void set_MediaType(string value) { }

	// RVA: 0x1EB7390 Offset: 0x1EB6590 VA: 0x181EB7390
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1EB6940 Offset: 0x1EB5B40 VA: 0x181EB6940 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EB67F0 Offset: 0x1EB59F0 VA: 0x181EB67F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EB68C0 Offset: 0x1EB5AC0 VA: 0x181EB68C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EB69A0 Offset: 0x1EB5BA0 VA: 0x181EB69A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EB6CA0 Offset: 0x1EB5EA0 VA: 0x181EB6CA0
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x1EB6A10 Offset: 0x1EB5C10 VA: 0x181EB6A10
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }
}

// Namespace: System.Net.Http.Headers
public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue // TypeDefIndex: 17042
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1EB7760 Offset: 0x1EB6960 VA: 0x181EB7760
	private static bool TryParseElement(Lexer lexer, out MediaTypeWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EB78E0 Offset: 0x1EB6AE0 VA: 0x181EB78E0
	internal static bool TryParse(string input, int minimalCount, out List<MediaTypeWithQualityHeaderValue> result) { }
}

// Namespace: System.Net.Http.Headers
public class NameValueHeaderValue : ICloneable // TypeDefIndex: 17043
{
	// Fields
	internal string value; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1EB9E60 Offset: 0x1EB9060 VA: 0x181EB9E60
	public void .ctor(string name, string value) { }

	// RVA: 0x1EB9E20 Offset: 0x1EB9020 VA: 0x181EB9E20
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_Name(string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }

	// RVA: 0x1EB9EB0 Offset: 0x1EB90B0 VA: 0x181EB9EB0
	public void set_Value(string value) { }

	// RVA: 0x1EB94E0 Offset: 0x1EB86E0 VA: 0x181EB94E0
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x1EB9640 Offset: 0x1EB8840 VA: 0x181EB9640 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EA8520 Offset: 0x1EA7720 VA: 0x181EA8520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EB9550 Offset: 0x1EB8750 VA: 0x181EB9550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EB9D70 Offset: 0x1EB8F70 VA: 0x181EB9D70
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x1EB99A0 Offset: 0x1EB8BA0 VA: 0x181EB99A0
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x1EB96B0 Offset: 0x1EB88B0 VA: 0x181EB96B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EB9710 Offset: 0x1EB8910 VA: 0x181EB9710
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 17044
{
	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x1EBA7A0 Offset: 0x1EB99A0 VA: 0x181EBA7A0
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1EBA9E0 Offset: 0x1EB9BE0 VA: 0x181EBA9E0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1EBA290 Offset: 0x1EB9490 VA: 0x181EBA290 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBA060 Offset: 0x1EB9260 VA: 0x181EBA060 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBA1D0 Offset: 0x1EB93D0 VA: 0x181EBA1D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBA2F0 Offset: 0x1EB94F0 VA: 0x181EBA2F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EBA6F0 Offset: 0x1EB98F0 VA: 0x181EBA6F0
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x1EBA400 Offset: 0x1EB9600 VA: 0x181EBA400
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }
}

// Namespace: 
public static class Parser.Token // TypeDefIndex: 17045
{
	// Methods

	// RVA: 0x1EBEC30 Offset: 0x1EBDE30 VA: 0x181EBEC30
	public static void Check(string s) { }

	// RVA: 0x1EBEDB0 Offset: 0x1EBDFB0 VA: 0x181EBEDB0
	public static bool TryCheck(string s) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Parser.DateTime.<>c // TypeDefIndex: 17046
{
	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1EC3AA0 Offset: 0x1EC2CA0 VA: 0x181EC3AA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC3610 Offset: 0x1EC2810 VA: 0x181EC3610
	internal string <.cctor>b__2_0(object l) { }
}

// Namespace: 
public static class Parser.DateTime // TypeDefIndex: 17047
{
	// Fields
	public static readonly Func<object, string> ToString; // 0x0

	// Methods

	// RVA: 0x1EABEC0 Offset: 0x1EAB0C0 VA: 0x181EABEC0
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x1EABF20 Offset: 0x1EAB120 VA: 0x181EABF20
	private static void .cctor() { }
}

// Namespace: 
public static class Parser.EmailAddress // TypeDefIndex: 17048
{
	// Methods

	// RVA: 0x1EAC180 Offset: 0x1EAB380 VA: 0x181EAC180
	public static bool TryParse(string input, out string result) { }
}

// Namespace: 
public static class Parser.Host // TypeDefIndex: 17049
{
	// Methods

	// RVA: 0x1EACBF0 Offset: 0x1EABDF0 VA: 0x181EACBF0
	public static bool TryParse(string input, out string result) { }
}

// Namespace: 
public static class Parser.Int // TypeDefIndex: 17050
{
	// Methods

	// RVA: 0x1EB54C0 Offset: 0x1EB46C0 VA: 0x181EB54C0
	public static bool TryParse(string input, out int result) { }
}

// Namespace: 
public static class Parser.Long // TypeDefIndex: 17051
{
	// Methods

	// RVA: 0x1EB6650 Offset: 0x1EB5850 VA: 0x181EB6650
	public static bool TryParse(string input, out long result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Parser.MD5.<>c // TypeDefIndex: 17052
{
	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1EC3980 Offset: 0x1EC2B80 VA: 0x181EC3980
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EC36E0 Offset: 0x1EC28E0 VA: 0x181EC36E0
	internal string <.cctor>b__2_0(object l) { }
}

// Namespace: 
public static class Parser.MD5 // TypeDefIndex: 17053
{
	// Fields
	public static readonly Func<object, string> ToString; // 0x0

	// Methods

	// RVA: 0x1EB66C0 Offset: 0x1EB58C0 VA: 0x181EB66C0
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x1EB6730 Offset: 0x1EB5930 VA: 0x181EB6730
	private static void .cctor() { }
}

// Namespace: 
public static class Parser.TimeSpanSeconds // TypeDefIndex: 17054
{
	// Methods

	// RVA: 0x1EBEB30 Offset: 0x1EBDD30 VA: 0x181EBEB30
	public static bool TryParse(string input, out TimeSpan result) { }
}

// Namespace: 
public static class Parser.Uri // TypeDefIndex: 17055
{
	// Methods

	// RVA: 0x1EC3B00 Offset: 0x1EC2D00 VA: 0x181EC3B00
	public static bool TryParse(string input, out Uri result) { }
}

// Namespace: System.Net.Http.Headers
internal static class Parser // TypeDefIndex: 17056
{}

// Namespace: System.Net.Http.Headers
public class ProductHeaderValue : ICloneable // TypeDefIndex: 17057
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_Version(string value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBACD0 Offset: 0x1EB9ED0 VA: 0x181EBACD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBADA0 Offset: 0x1EB9FA0 VA: 0x181EBADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBB0F0 Offset: 0x1EBA2F0 VA: 0x181EBB0F0
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x1EBAE80 Offset: 0x1EBA080 VA: 0x181EBAE80
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EBAE20 Offset: 0x1EBA020 VA: 0x181EBAE20 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 17058
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	// Properties
	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }

	// Methods

	// RVA: 0x1EBB740 Offset: 0x1EBA940 VA: 0x181EBB740
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductHeaderValue get_Product() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBB1A0 Offset: 0x1EBA3A0 VA: 0x181EBB1A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBB270 Offset: 0x1EBA470 VA: 0x181EBB270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBB580 Offset: 0x1EBA780 VA: 0x181EBB580
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x1EBB2E0 Offset: 0x1EBA4E0 VA: 0x181EBB2E0
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x1EBB2B0 Offset: 0x1EBA4B0 VA: 0x181EBB2B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 17059
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x1EBBE40 Offset: 0x1EBB040 VA: 0x181EBBE40
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1EBBED0 Offset: 0x1EBB0D0 VA: 0x181EBBED0
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGenerated]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBB7B0 Offset: 0x1EBA9B0 VA: 0x181EBB7B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBB920 Offset: 0x1EBAB20 VA: 0x181EBB920 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBBAC0 Offset: 0x1EBACC0 VA: 0x181EBBAC0
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x1EBB9B0 Offset: 0x1EBABB0 VA: 0x181EBB9B0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeHeaderValue : ICloneable // TypeDefIndex: 17060
{
	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1EBCE10 Offset: 0x1EBC010 VA: 0x181EBCE10
	public void .ctor() { }

	// RVA: 0x1EBCBC0 Offset: 0x1EBBDC0 VA: 0x181EBCBC0
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x1EBCE50 Offset: 0x1EBC050 VA: 0x181EBCE50
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Unit() { }

	// RVA: 0x1EBC0A0 Offset: 0x1EBB2A0 VA: 0x181EBC0A0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBBF50 Offset: 0x1EBB150 VA: 0x181EBBF50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBC020 Offset: 0x1EBB220 VA: 0x181EBC020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBC300 Offset: 0x1EBB500 VA: 0x181EBC300
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x1EBC100 Offset: 0x1EBB300 VA: 0x181EBC100 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RangeItemHeaderValue : ICloneable // TypeDefIndex: 17061
{
	// Fields
	[CompilerGenerated]
	private Nullable<long> <From>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<long> <To>k__BackingField; // 0x20

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> To { get; set; }

	// Methods

	// RVA: 0x1EBD150 Offset: 0x1EBC350 VA: 0x181EBD150
	public void .ctor(Nullable<long> from, Nullable<long> to) { }

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Nullable<long> get_From() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	private void set_From(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public Nullable<long> get_To() { }

	[CompilerGenerated]
	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	private void set_To(Nullable<long> value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBCEC0 Offset: 0x1EBC0C0 VA: 0x181EBCEC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBCFB0 Offset: 0x1EBC1B0 VA: 0x181EBCFB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBD020 Offset: 0x1EBC220 VA: 0x181EBD020 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 17062
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<TimeSpan> <Delta>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }

	// Methods

	// RVA: 0x1EBDB00 Offset: 0x1EBCD00 VA: 0x181EBDB00
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1EBDA20 Offset: 0x1EBCC20 VA: 0x181EBDA20
	public void .ctor(TimeSpan delta) { }

	[CompilerGenerated]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGenerated]
	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBD330 Offset: 0x1EBC530 VA: 0x181EBD330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBD4E0 Offset: 0x1EBC6E0 VA: 0x181EBD4E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBD710 Offset: 0x1EBC910 VA: 0x181EBD710
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x1EBD570 Offset: 0x1EBC770 VA: 0x181EBD570 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 17063
{
	// Fields
	[CompilerGenerated]
	private Nullable<double> <Quality>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x20

	// Properties
	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Nullable<double> get_Quality() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	private void set_Quality(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_Value(string value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBE3E0 Offset: 0x1EBD5E0 VA: 0x181EBE3E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBE4F0 Offset: 0x1EBD6F0 VA: 0x181EBE4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBEA80 Offset: 0x1EBDC80 VA: 0x181EBEA80
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x1EBE670 Offset: 0x1EBD870 VA: 0x181EBE670
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EBE580 Offset: 0x1EBD780 VA: 0x181EBE580 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 17064
{
	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1EBF3C0 Offset: 0x1EBE5C0 VA: 0x181EBF3C0
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1EBF630 Offset: 0x1EBE830 VA: 0x181EBF630
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }

	// RVA: 0x1EBF080 Offset: 0x1EBE280 VA: 0x181EBF080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EBEF20 Offset: 0x1EBE120 VA: 0x181EBEF20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EBEFF0 Offset: 0x1EBE1F0 VA: 0x181EBEFF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EBF0E0 Offset: 0x1EBE2E0 VA: 0x181EBF0E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EBF310 Offset: 0x1EBE510 VA: 0x181EBF310
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x1EBF140 Offset: 0x1EBE340 VA: 0x181EBF140
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue // TypeDefIndex: 17065
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1EBF870 Offset: 0x1EBEA70 VA: 0x181EBF870
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingWithQualityHeaderValue> result) { }

	// RVA: 0x1EBF6A0 Offset: 0x1EBE8A0 VA: 0x181EBF6A0
	private static bool TryParseElement(Lexer lexer, out TransferCodingWithQualityHeaderValue parsedValue, out Token t) { }
}

// Namespace: System.Net.Http.Headers
public class ViaHeaderValue : ICloneable // TypeDefIndex: 17066
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProtocolName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ProtocolVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ReceivedBy>k__BackingField; // 0x28

	// Properties
	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ProtocolName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_ProtocolName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ProtocolVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_ReceivedBy() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_ReceivedBy(string value) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EC3B60 Offset: 0x1EC2D60 VA: 0x181EC3B60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EC3C60 Offset: 0x1EC2E60 VA: 0x181EC3C60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EC42A0 Offset: 0x1EC34A0 VA: 0x181EC42A0
	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	// RVA: 0x1EC3E80 Offset: 0x1EC3080 VA: 0x181EC3E80
	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EC3D70 Offset: 0x1EC2F70 VA: 0x181EC3D70 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net.Http.Headers
public class WarningHeaderValue : ICloneable // TypeDefIndex: 17067
{
	// Fields
	[CompilerGenerated]
	private string <Agent>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Code>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x38

	// Properties
	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Agent() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Agent(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_Code(int value) { }

	[CompilerGenerated]
	// RVA: 0x415790 Offset: 0x414990 VA: 0x180415790
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x4157E0 Offset: 0x4149E0 VA: 0x1804157E0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_Text(string value) { }

	// RVA: 0x1EC45C0 Offset: 0x1EC37C0 VA: 0x181EC45C0
	private static bool IsCodeValid(int code) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1EC4350 Offset: 0x1EC3550 VA: 0x181EC4350 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EC44D0 Offset: 0x1EC36D0 VA: 0x181EC44D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EC4D30 Offset: 0x1EC3F30 VA: 0x181EC4D30
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x1EC4800 Offset: 0x1EC3A00 VA: 0x181EC4800
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1EC45E0 Offset: 0x1EC37E0 VA: 0x181EC45E0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 // TypeDefIndex: 17068
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 17069
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 1D59178A3E2B293760F6FE72820F96FEC4071964A5B9E4BB13F7EA51510A4729 /*Metadata offset 0x8FCA70*/; // 0x0

	// Methods

	// RVA: 0x840E00 Offset: 0x840000 VA: 0x180840E00
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17070
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 17071
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 17072
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsByRefLikeAttribute : Attribute // TypeDefIndex: 17073
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: FxResources.System.Memory
internal static class SR // TypeDefIndex: 17074
{}

// Namespace: System
[IsReadOnly]
internal struct SequencePosition : IEquatable<SequencePosition> // TypeDefIndex: 17075
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _integer; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(object object, int integer) { }

	[EditorBrowsable(1)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public object GetObject() { }

	[EditorBrowsable(1)]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int GetInteger() { }

	// RVA: 0x1BB3E50 Offset: 0x1BB3050 VA: 0x181BB3E50 Slot: 4
	public bool Equals(SequencePosition other) { }

	[EditorBrowsable(1)]
	// RVA: 0x1BB3DC0 Offset: 0x1BB2FC0 VA: 0x181BB3DC0 Slot: 0
	public override bool Equals(object obj) { }

	[EditorBrowsable(1)]
	// RVA: 0x1BB3E70 Offset: 0x1BB3070 VA: 0x181BB3E70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 17076
{
	// Methods

	// RVA: 0x1BB6E60 Offset: 0x1BB6060 VA: 0x181BB6E60
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1BB67E0 Offset: 0x1BB59E0 VA: 0x181BB67E0
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1BB6F80 Offset: 0x1BB6180 VA: 0x181BB6F80
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x1BB6BA0 Offset: 0x1BB5DA0 VA: 0x181BB6BA0
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x1BB6E30 Offset: 0x1BB6030 VA: 0x181BB6E30
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x1BB6700 Offset: 0x1BB5900 VA: 0x181BB6700
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x1BB6E00 Offset: 0x1BB6000 VA: 0x181BB6E00
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x1BB6630 Offset: 0x1BB5830 VA: 0x181BB6630
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x1BB6FE0 Offset: 0x1BB61E0 VA: 0x181BB6FE0
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x1BB6CC0 Offset: 0x1BB5EC0 VA: 0x181BB6CC0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x1BB6F20 Offset: 0x1BB6120 VA: 0x181BB6F20
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x1BB6B50 Offset: 0x1BB5D50 VA: 0x181BB6B50
	private static Exception CreateArgumentOutOfRangeException() { }

	// RVA: 0x1BB6F50 Offset: 0x1BB6150 VA: 0x181BB6F50
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1BB6AC0 Offset: 0x1BB5CC0 VA: 0x181BB6AC0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1BB6EC0 Offset: 0x1BB60C0 VA: 0x181BB6EC0
	internal static void ThrowArgumentOutOfRangeException_PrecisionTooLarge() { }

	// RVA: 0x1BB68D0 Offset: 0x1BB5AD0 VA: 0x181BB68D0
	private static Exception CreateArgumentOutOfRangeException_PrecisionTooLarge() { }

	// RVA: 0x1BB6EF0 Offset: 0x1BB60F0 VA: 0x181BB6EF0
	internal static void ThrowArgumentOutOfRangeException_SymbolDoesNotFit() { }

	// RVA: 0x1BB69E0 Offset: 0x1BB5BE0 VA: 0x181BB69E0
	private static Exception CreateArgumentOutOfRangeException_SymbolDoesNotFit() { }

	// RVA: 0x1BB7010 Offset: 0x1BB6210 VA: 0x181BB7010
	internal static void ThrowInvalidOperationException_EndPositionNotReached() { }

	// RVA: 0x1BB6D10 Offset: 0x1BB5F10 VA: 0x181BB6D10
	private static Exception CreateInvalidOperationException_EndPositionNotReached() { }

	// RVA: 0x1BB6E90 Offset: 0x1BB6090 VA: 0x181BB6E90
	internal static void ThrowArgumentOutOfRangeException_PositionOutOfRange() { }

	// RVA: 0x1BB6870 Offset: 0x1BB5A70 VA: 0x181BB6870
	private static Exception CreateArgumentOutOfRangeException_PositionOutOfRange() { }

	// RVA: 0x1BB6FB0 Offset: 0x1BB61B0 VA: 0x181BB6FB0
	internal static void ThrowFormatException_BadFormatSpecifier() { }

	// RVA: 0x1BB6BF0 Offset: 0x1BB5DF0 VA: 0x181BB6BF0
	private static Exception CreateFormatException_BadFormatSpecifier() { }

	// RVA: 0x1BB7070 Offset: 0x1BB6270 VA: 0x181BB7070
	public static bool TryFormatThrowFormatException(out int bytesWritten) { }

	// RVA: -1 Offset: -1
	public static bool TryParseThrowFormatException<T>(out T value, out int bytesConsumed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA87AB0 Offset: 0xA86CB0 VA: 0x180A87AB0
	|-ThrowHelper.TryParseThrowFormatException<bool>
	|-ThrowHelper.TryParseThrowFormatException<byte>
	|-ThrowHelper.TryParseThrowFormatException<sbyte>
	|
	|-RVA: 0xA87AD0 Offset: 0xA86CD0 VA: 0x180A87AD0
	|-ThrowHelper.TryParseThrowFormatException<Decimal>
	|-ThrowHelper.TryParseThrowFormatException<Guid>
	|
	|-RVA: 0xA87AF0 Offset: 0xA86CF0 VA: 0x180A87AF0
	|-ThrowHelper.TryParseThrowFormatException<double>
	|-ThrowHelper.TryParseThrowFormatException<long>
	|-ThrowHelper.TryParseThrowFormatException<ulong>
	|
	|-RVA: 0xA87B70 Offset: 0xA86D70 VA: 0x180A87B70
	|-ThrowHelper.TryParseThrowFormatException<short>
	|-ThrowHelper.TryParseThrowFormatException<ushort>
	|
	|-RVA: 0xA87B90 Offset: 0xA86D90 VA: 0x180A87B90
	|-ThrowHelper.TryParseThrowFormatException<int>
	|-ThrowHelper.TryParseThrowFormatException<uint>
	|
	|-RVA: 0xA87B10 Offset: 0xA86D10 VA: 0x180A87B10
	|-ThrowHelper.TryParseThrowFormatException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1BB7040 Offset: 0x1BB6240 VA: 0x181BB7040
	public static void ThrowStartOrEndArgumentValidationException(long start) { }

	// RVA: 0x1BB6DE0 Offset: 0x1BB5FE0 VA: 0x181BB6DE0
	private static Exception CreateStartOrEndArgumentValidationException(long start) { }
}

// Namespace: System
internal enum ExceptionArgument // TypeDefIndex: 17077
{
	// Fields
	public int value__; // 0x0
	public const ExceptionArgument length = 0;
	public const ExceptionArgument start = 1;
	public const ExceptionArgument minimumBufferSize = 2;
	public const ExceptionArgument elementIndex = 3;
	public const ExceptionArgument comparable = 4;
	public const ExceptionArgument comparer = 5;
	public const ExceptionArgument destination = 6;
	public const ExceptionArgument offset = 7;
	public const ExceptionArgument startSegment = 8;
	public const ExceptionArgument endSegment = 9;
	public const ExceptionArgument startIndex = 10;
	public const ExceptionArgument endIndex = 11;
	public const ExceptionArgument array = 12;
	public const ExceptionArgument culture = 13;
	public const ExceptionArgument manager = 14;
}

// Namespace: System
internal static class DecimalDecCalc // TypeDefIndex: 17078
{
	// Methods

	// RVA: 0x1BB05A0 Offset: 0x1BAF7A0 VA: 0x181BB05A0
	private static uint D32DivMod1E9(uint hi32, ref uint lo32) { }

	// RVA: 0x1BB0690 Offset: 0x1BAF890 VA: 0x181BB0690
	internal static uint DecDivMod1E9(ref MutableDecimal value) { }

	// RVA: 0x1BB0600 Offset: 0x1BAF800 VA: 0x181BB0600
	internal static void DecAddInt32(ref MutableDecimal value, uint i) { }

	// RVA: 0x1BB0580 Offset: 0x1BAF780 VA: 0x181BB0580
	private static bool D32AddCarry(ref uint value, uint i) { }

	// RVA: 0x1BB0770 Offset: 0x1BAF970 VA: 0x181BB0770
	internal static void DecMul10(ref MutableDecimal value) { }

	// RVA: 0x1BB0850 Offset: 0x1BAFA50 VA: 0x181BB0850
	private static void DecShiftLeft(ref MutableDecimal value) { }

	// RVA: 0x1BB0630 Offset: 0x1BAF830 VA: 0x181BB0630
	private static void DecAdd(ref MutableDecimal value, MutableDecimal d) { }
}

// Namespace: 
private static class Number.DoubleHelper // TypeDefIndex: 17079
{
	// Methods

	// RVA: 0x1BB0880 Offset: 0x1BAFA80 VA: 0x181BB0880
	public static uint Exponent(double d) { }

	// RVA: 0x1BB08A0 Offset: 0x1BAFAA0 VA: 0x181BB08A0
	public static ulong Mantissa(double d) { }
}

// Namespace: System
internal static class Number // TypeDefIndex: 17080
{
	// Fields
	private static readonly ulong[] s_rgval64Power10; // 0x0
	private static readonly sbyte[] s_rgexp64Power10; // 0x8
	private static readonly ulong[] s_rgval64Power10By16; // 0x10
	private static readonly short[] s_rgexp64Power10By16; // 0x18

	// Methods

	// RVA: 0x1BB3190 Offset: 0x1BB2390 VA: 0x181BB3190
	public static void RoundNumber(ref NumberBuffer number, int pos) { }

	// RVA: 0x1BB2980 Offset: 0x1BB1B80 VA: 0x181BB2980
	internal static bool NumberBufferToDouble(ref NumberBuffer number, out double value) { }

	// RVA: 0x1BB26B0 Offset: 0x1BB18B0 VA: 0x181BB26B0
	public static bool NumberBufferToDecimal(ref NumberBuffer number, ref Decimal value) { }

	// RVA: 0x1BB21B0 Offset: 0x1BB13B0 VA: 0x181BB21B0
	public static void DecimalToNumber(Decimal value, ref NumberBuffer number) { }

	// RVA: 0x1BB2500 Offset: 0x1BB1700 VA: 0x181BB2500
	private static uint DigitsToInt(ReadOnlySpan<byte> digits, int count) { }

	// RVA: 0x17A59E0 Offset: 0x17A4BE0 VA: 0x1817A59E0
	private static ulong Mul32x32To64(uint a, uint b) { }

	// RVA: 0x1BB2620 Offset: 0x1BB1820 VA: 0x181BB2620
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	// RVA: 0x17AFA20 Offset: 0x17AEC20 VA: 0x1817AFA20
	private static int abs(int value) { }

	// RVA: 0x1BB2A30 Offset: 0x1BB1C30 VA: 0x181BB2A30
	private static double NumberToDouble(ref NumberBuffer number) { }

	// RVA: 0x1BB3370 Offset: 0x1BB2570 VA: 0x181BB3370
	private static void .cctor() { }
}

// Namespace: System
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct NumberBuffer // TypeDefIndex: 17081
{
	// Fields
	public int Scale; // 0x0
	public bool IsNegative; // 0x4
	private byte _b0; // 0x5
	private byte _b1; // 0x6
	private byte _b2; // 0x7
	private byte _b3; // 0x8
	private byte _b4; // 0x9
	private byte _b5; // 0xA
	private byte _b6; // 0xB
	private byte _b7; // 0xC
	private byte _b8; // 0xD
	private byte _b9; // 0xE
	private byte _b10; // 0xF
	private byte _b11; // 0x10
	private byte _b12; // 0x11
	private byte _b13; // 0x12
	private byte _b14; // 0x13
	private byte _b15; // 0x14
	private byte _b16; // 0x15
	private byte _b17; // 0x16
	private byte _b18; // 0x17
	private byte _b19; // 0x18
	private byte _b20; // 0x19
	private byte _b21; // 0x1A
	private byte _b22; // 0x1B
	private byte _b23; // 0x1C
	private byte _b24; // 0x1D
	private byte _b25; // 0x1E
	private byte _b26; // 0x1F
	private byte _b27; // 0x20
	private byte _b28; // 0x21
	private byte _b29; // 0x22
	private byte _b30; // 0x23
	private byte _b31; // 0x24
	private byte _b32; // 0x25
	private byte _b33; // 0x26
	private byte _b34; // 0x27
	private byte _b35; // 0x28
	private byte _b36; // 0x29
	private byte _b37; // 0x2A
	private byte _b38; // 0x2B
	private byte _b39; // 0x2C
	private byte _b40; // 0x2D
	private byte _b41; // 0x2E
	private byte _b42; // 0x2F
	private byte _b43; // 0x30
	private byte _b44; // 0x31
	private byte _b45; // 0x32
	private byte _b46; // 0x33
	private byte _b47; // 0x34
	private byte _b48; // 0x35
	private byte _b49; // 0x36
	private byte _b50; // 0x37

	// Properties
	public Span<byte> Digits { get; }
	public byte* UnsafeDigits { get; }
	public int NumDigits { get; }

	// Methods

	// RVA: 0x1BB1E40 Offset: 0x1BB1040 VA: 0x181BB1E40
	public Span<byte> get_Digits() { }

	// RVA: 0x1BB21A0 Offset: 0x1BB13A0 VA: 0x181BB21A0
	public byte* get_UnsafeDigits() { }

	// RVA: 0x1BB1F90 Offset: 0x1BB1190 VA: 0x181BB1F90
	public int get_NumDigits() { }

	// RVA: 0x1BB1C30 Offset: 0x1BB0E30 VA: 0x181BB1C30 Slot: 3
	public override string ToString() { }
}

// Namespace: System
[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
[IsReadOnly]
[DebuggerDisplay("{ToString(),raw}")]
internal struct Memory<T> // TypeDefIndex: 17082
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1464F10 Offset: 0x1464110 VA: 0x181464F10
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x1464B70 Offset: 0x1463D70 VA: 0x181464B70
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29E0 Offset: 0xBD1BE0 VA: 0x180BD29E0
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x1464D30 Offset: 0x1463F30 VA: 0x181464D30
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1464790 Offset: 0x1463990 VA: 0x181464790
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
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
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
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
	|-RVA: 0x1464100 Offset: 0x1463300 VA: 0x181464100
	|-Memory<byte>.ToString
	|
	|-RVA: 0x1464560 Offset: 0x1463760 VA: 0x181464560
	|-Memory<char>.ToString
	|
	|-RVA: 0x1463C50 Offset: 0x1462E50 VA: 0x181463C50
	|-Memory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463590 Offset: 0x1462790 VA: 0x181463590
	|-Memory<byte>.Slice
	|-Memory<char>.Slice
	|-Memory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1464F80 Offset: 0x1464180 VA: 0x181464F80
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x1465470 Offset: 0x1464670 VA: 0x181465470
	|-Memory<char>.get_Span
	|
	|-RVA: 0x14665E0 Offset: 0x14657E0 VA: 0x1814665E0
	|-Memory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463830 Offset: 0x1462A30 VA: 0x181463830
	|-Memory<byte>.ToArray
	|
	|-RVA: 0x14637A0 Offset: 0x14629A0 VA: 0x1814637A0
	|-Memory<char>.ToArray
	|
	|-RVA: 0x1463630 Offset: 0x1462830 VA: 0x181463630
	|-Memory<__Il2CppFullySharedGenericType>.ToArray
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1462160 Offset: 0x1461360 VA: 0x181462160
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|
	|-RVA: 0x1462380 Offset: 0x1461580 VA: 0x181462380
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD08B0 Offset: 0xBCFAB0 VA: 0x180BD08B0
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD12B0 Offset: 0xBD04B0 VA: 0x180BD12B0
	|-Memory<byte>.GetHashCode
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0xBD11D0 Offset: 0xBD03D0 VA: 0x180BD11D0
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
	|-RVA: 0xBD0750 Offset: 0xBCF950 VA: 0x180BD0750
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/
}

// Namespace: System
internal sealed class MemoryDebugView<T> // TypeDefIndex: 17083
{}

// Namespace: System
[Extension]
internal static class MemoryExtensions // TypeDefIndex: 17084
{
	// Fields
	internal static readonly IntPtr StringAdjustment; // 0x0

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(Span<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA497F0 Offset: 0xA489F0 VA: 0x180A497F0
	|-MemoryExtensions.IndexOf<byte>
	|
	|-RVA: 0xA49B70 Offset: 0xA48D70 VA: 0x180A49B70
	|-MemoryExtensions.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(Span<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4A2D0 Offset: 0xA494D0 VA: 0x180A4A2D0
	|-MemoryExtensions.SequenceEqual<byte>
	|
	|-RVA: 0xA4A5E0 Offset: 0xA497E0 VA: 0x180A4A5E0
	|-MemoryExtensions.SequenceEqual<char>
	|
	|-RVA: 0xA4AD50 Offset: 0xA49F50 VA: 0x180A4AD50
	|-MemoryExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ReadOnlySpan<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA497F0 Offset: 0xA489F0 VA: 0x180A497F0
	|-MemoryExtensions.IndexOf<byte>
	|
	|-RVA: 0xA49B70 Offset: 0xA48D70 VA: 0x180A49B70
	|-MemoryExtensions.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ReadOnlySpan<T> span, T value0, T value1, T value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA49040 Offset: 0xA48240 VA: 0x180A49040
	|-MemoryExtensions.IndexOfAny<byte>
	|
	|-RVA: 0xA494B0 Offset: 0xA486B0 VA: 0x180A494B0
	|-MemoryExtensions.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4A0D0 Offset: 0xA492D0 VA: 0x180A4A0D0
	|-MemoryExtensions.SequenceEqual<byte>
	|
	|-RVA: 0xA4A8D0 Offset: 0xA49AD0 VA: 0x180A4A8D0
	|-MemoryExtensions.SequenceEqual<char>
	|
	|-RVA: 0xA4AAD0 Offset: 0xA49CD0 VA: 0x180A4AAD0
	|-MemoryExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool StartsWith<T>(Span<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4B3D0 Offset: 0xA4A5D0 VA: 0x180A4B3D0
	|-MemoryExtensions.StartsWith<char>
	|
	|-RVA: 0xA4B8D0 Offset: 0xA4AAD0 VA: 0x180A4B8D0
	|-MemoryExtensions.StartsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool StartsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4B1D0 Offset: 0xA4A3D0 VA: 0x180A4B1D0
	|-MemoryExtensions.StartsWith<byte>
	|
	|-RVA: 0xA4B6D0 Offset: 0xA4A8D0 VA: 0x180A4B6D0
	|-MemoryExtensions.StartsWith<char>
	|
	|-RVA: 0xA4BD50 Offset: 0xA4AF50 VA: 0x180A4BD50
	|-MemoryExtensions.StartsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EndsWith<T>(Span<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA486C0 Offset: 0xA478C0 VA: 0x180A486C0
	|-MemoryExtensions.EndsWith<char>
	|
	|-RVA: 0xA488B0 Offset: 0xA47AB0 VA: 0x180A488B0
	|-MemoryExtensions.EndsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EndsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA484C0 Offset: 0xA476C0 VA: 0x180A484C0
	|-MemoryExtensions.EndsWith<char>
	|
	|-RVA: 0xA48D90 Offset: 0xA47F90 VA: 0x180A48D90
	|-MemoryExtensions.EndsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47670 Offset: 0xA46870 VA: 0x180A47670
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xA47AB0 Offset: 0xA46CB0 VA: 0x180A47AB0
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47810 Offset: 0xA46A10 VA: 0x180A47810
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xA47B40 Offset: 0xA46D40 VA: 0x180A47B40
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47350 Offset: 0xA46550 VA: 0x180A47350
	|-MemoryExtensions.AsMemory<byte>
	|
	|-RVA: 0xA47600 Offset: 0xA46800 VA: 0x180A47600
	|-MemoryExtensions.AsMemory<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA472C0 Offset: 0xA464C0 VA: 0x180A472C0
	|-MemoryExtensions.AsMemory<byte>
	|
	|-RVA: 0xA474A0 Offset: 0xA466A0 VA: 0x180A474A0
	|-MemoryExtensions.AsMemory<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA473E0 Offset: 0xA465E0 VA: 0x180A473E0
	|-MemoryExtensions.AsMemory<byte>
	|
	|-RVA: 0xA47520 Offset: 0xA46720 VA: 0x180A47520
	|-MemoryExtensions.AsMemory<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA48090 Offset: 0xA47290 VA: 0x180A48090
	|-MemoryExtensions.CopyTo<byte>
	|
	|-RVA: 0xA48260 Offset: 0xA47460 VA: 0x180A48260
	|-MemoryExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool IsTypeComparableAsBytes<T>(out NUInt size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24D80 Offset: 0xA23F80 VA: 0x180A24D80
	|-MemoryExtensions.IsTypeComparableAsBytes<byte>
	|-MemoryExtensions.IsTypeComparableAsBytes<char>
	|-MemoryExtensions.IsTypeComparableAsBytes<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA478A0 Offset: 0xA46AA0 VA: 0x180A478A0
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xA47A30 Offset: 0xA46C30 VA: 0x180A47A30
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1BB16C0 Offset: 0x1BB08C0 VA: 0x181BB16C0
	private static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<char> span, ReadOnlySpan<char> other) { }

	// RVA: 0x1BB1160 Offset: 0x1BB0360 VA: 0x181BB1160
	private static int CompareToOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	[Extension]
	// RVA: 0x1BB1370 Offset: 0x1BB0570 VA: 0x181BB1370
	public static bool EndsWith(ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) { }

	[Extension]
	// RVA: 0x1BB17C0 Offset: 0x1BB09C0 VA: 0x181BB17C0
	public static bool StartsWith(ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) { }

	[Extension]
	// RVA: 0x1BB1090 Offset: 0x1BB0290 VA: 0x181BB1090
	public static ReadOnlySpan<char> AsSpan(string text) { }

	[Extension]
	// RVA: 0x1BB0F80 Offset: 0x1BB0180 VA: 0x181BB0F80
	public static ReadOnlyMemory<char> AsMemory(string text) { }

	[Extension]
	// RVA: 0x1BB0FF0 Offset: 0x1BB01F0 VA: 0x181BB0FF0
	public static ReadOnlyMemory<char> AsMemory(string text, int start, int length) { }

	// RVA: 0x1BB1770 Offset: 0x1BB0970 VA: 0x181BB1770
	private static IntPtr MeasureStringAdjustment() { }

	// RVA: 0x1BB1B70 Offset: 0x1BB0D70 VA: 0x181BB1B70
	private static void .cctor() { }
}

// Namespace: System
[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
[IsReadOnly]
internal struct ReadOnlyMemory<T> // TypeDefIndex: 17085
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public static ReadOnlyMemory<T> Empty { get; }
	public int Length { get; }
	public bool IsEmpty { get; }
	public ReadOnlySpan<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29C0 Offset: 0xBD1BC0 VA: 0x180BD29C0
	|-ReadOnlyMemory<byte>..ctor
	|-ReadOnlyMemory<char>..ctor
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29E0 Offset: 0xBD1BE0 VA: 0x180BD29E0
	|-ReadOnlyMemory<byte>..ctor
	|-ReadOnlyMemory<char>..ctor
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29B0 Offset: 0xBD1BB0 VA: 0x180BD29B0
	|-ReadOnlyMemory<byte>..ctor
	|-ReadOnlyMemory<char>..ctor
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4800 Offset: 0xBD3A00 VA: 0x180BD4800
	|-ReadOnlyMemory<byte>.op_Implicit
	|-ReadOnlyMemory<char>.op_Implicit
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E8FF0 Offset: 0x9E81F0 VA: 0x1809E8FF0
	|-ReadOnlyMemory<byte>.get_Empty
	|-ReadOnlyMemory<char>.get_Empty
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2A60 Offset: 0xBD1C60 VA: 0x180BD2A60
	|-ReadOnlyMemory<byte>.get_Length
	|-ReadOnlyMemory<char>.get_Length
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2A50 Offset: 0xBD1C50 VA: 0x180BD2A50
	|-ReadOnlyMemory<byte>.get_IsEmpty
	|-ReadOnlyMemory<char>.get_IsEmpty
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD24B0 Offset: 0xBD16B0 VA: 0x180BD24B0
	|-ReadOnlyMemory<byte>.ToString
	|
	|-RVA: 0xBD1930 Offset: 0xBD0B30 VA: 0x180BD1930
	|-ReadOnlyMemory<char>.ToString
	|
	|-RVA: 0xBD26E0 Offset: 0xBD18E0 VA: 0x180BD26E0
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD15F0 Offset: 0xBD07F0 VA: 0x180BD15F0
	|-ReadOnlyMemory<byte>.Slice
	|-ReadOnlyMemory<char>.Slice
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1680 Offset: 0xBD0880 VA: 0x180BD1680
	|-ReadOnlyMemory<byte>.Slice
	|-ReadOnlyMemory<char>.Slice
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2A70 Offset: 0xBD1C70 VA: 0x180BD2A70
	|-ReadOnlyMemory<byte>.get_Span
	|
	|-RVA: 0xBD3E60 Offset: 0xBD3060 VA: 0x180BD3E60
	|-ReadOnlyMemory<char>.get_Span
	|
	|-RVA: 0xBD3420 Offset: 0xBD2620 VA: 0x180BD3420
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1720 Offset: 0xBD0920 VA: 0x180BD1720
	|-ReadOnlyMemory<byte>.ToArray
	|
	|-RVA: 0xBD17B0 Offset: 0xBD09B0 VA: 0x180BD17B0
	|-ReadOnlyMemory<char>.ToArray
	|
	|-RVA: 0xBD1840 Offset: 0xBD0A40 VA: 0x180BD1840
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.ToArray
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0D70 Offset: 0xBCFF70 VA: 0x180BD0D70
	|-ReadOnlyMemory<byte>.Equals
	|-ReadOnlyMemory<char>.Equals
	|
	|-RVA: 0xBD08D0 Offset: 0xBCFAD0 VA: 0x180BD08D0
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ReadOnlyMemory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD08B0 Offset: 0xBCFAB0 VA: 0x180BD08B0
	|-ReadOnlyMemory<byte>.Equals
	|-ReadOnlyMemory<char>.Equals
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.Equals
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD12B0 Offset: 0xBD04B0 VA: 0x180BD12B0
	|-ReadOnlyMemory<byte>.GetHashCode
	|-ReadOnlyMemory<char>.GetHashCode
	|
	|-RVA: 0xBD11D0 Offset: 0xBD03D0 VA: 0x180BD11D0
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0650 Offset: 0xBCF850 VA: 0x180BD0650
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|-ReadOnlyMemory<char>.CombineHashCodes
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0840 Offset: 0xBCFA40 VA: 0x180BD0840
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|-ReadOnlyMemory<char>.CombineHashCodes
	|
	|-RVA: 0xBD0750 Offset: 0xBCF950 VA: 0x180BD0750
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	internal object GetObjectStartLength(out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD1550 Offset: 0xBD0750 VA: 0x180BD1550
	|-ReadOnlyMemory<byte>.GetObjectStartLength
	|-ReadOnlyMemory<char>.GetObjectStartLength
	|-ReadOnlyMemory<__Il2CppFullySharedGenericType>.GetObjectStartLength
	*/
}

// Namespace: System
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsReadOnly]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
internal struct ReadOnlySpan<T> // TypeDefIndex: 17086
{
	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public static ReadOnlySpan<T> Empty { get; }
	[IsReadOnly]
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ReadOnlySpan<byte>.get_Length
	|-ReadOnlySpan<char>.get_Length
	|-ReadOnlySpan<DebugDirectoryEntry>.get_Length
	|-ReadOnlySpan<int>.get_Length
	|-ReadOnlySpan<SectionHeader>.get_Length
	|-ReadOnlySpan<uint>.get_Length
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1CC0 Offset: 0xBE0EC0 VA: 0x180BE1CC0
	|-ReadOnlySpan<byte>.get_IsEmpty
	|-ReadOnlySpan<char>.get_IsEmpty
	|-ReadOnlySpan<DebugDirectoryEntry>.get_IsEmpty
	|-ReadOnlySpan<int>.get_IsEmpty
	|-ReadOnlySpan<SectionHeader>.get_IsEmpty
	|-ReadOnlySpan<uint>.get_IsEmpty
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC100 Offset: 0xBDB300 VA: 0x180BDC100
	|-ReadOnlySpan<byte>.Equals
	|-ReadOnlySpan<char>.Equals
	|-ReadOnlySpan<DebugDirectoryEntry>.Equals
	|-ReadOnlySpan<int>.Equals
	|-ReadOnlySpan<SectionHeader>.Equals
	|-ReadOnlySpan<uint>.Equals
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Equals
	*/

	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC210 Offset: 0xBDB410 VA: 0x180BDC210
	|-ReadOnlySpan<byte>.GetHashCode
	|-ReadOnlySpan<char>.GetHashCode
	|-ReadOnlySpan<DebugDirectoryEntry>.GetHashCode
	|-ReadOnlySpan<int>.GetHashCode
	|-ReadOnlySpan<SectionHeader>.GetHashCode
	|-ReadOnlySpan<uint>.GetHashCode
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1FC0 Offset: 0xBE11C0 VA: 0x180BE1FC0
	|-ReadOnlySpan<byte>.op_Implicit
	|-ReadOnlySpan<char>.op_Implicit
	|-ReadOnlySpan<DebugDirectoryEntry>.op_Implicit
	|-ReadOnlySpan<int>.op_Implicit
	|-ReadOnlySpan<SectionHeader>.op_Implicit
	|-ReadOnlySpan<uint>.op_Implicit
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9000 Offset: 0x9E8200 VA: 0x1809E9000
	|-ReadOnlySpan<byte>.get_Empty
	|-ReadOnlySpan<char>.get_Empty
	|-ReadOnlySpan<DebugDirectoryEntry>.get_Empty
	|-ReadOnlySpan<int>.get_Empty
	|-ReadOnlySpan<SectionHeader>.get_Empty
	|-ReadOnlySpan<uint>.get_Empty
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0E40 Offset: 0xBE0040 VA: 0x180BE0E40
	|-ReadOnlySpan<byte>..ctor
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<DebugDirectoryEntry>..ctor
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<SectionHeader>..ctor
	|-ReadOnlySpan<uint>..ctor
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0B50 Offset: 0xBDFD50 VA: 0x180BE0B50
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0xBE1AA0 Offset: 0xBE0CA0 VA: 0x180BE1AA0
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0xBE1160 Offset: 0xBE0360 VA: 0x180BE1160
	|-ReadOnlySpan<DebugDirectoryEntry>..ctor
	|
	|-RVA: 0xBE0D10 Offset: 0xBDFF10 VA: 0x180BE0D10
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0xBE0F30 Offset: 0xBE0130 VA: 0x180BE0F30
	|-ReadOnlySpan<SectionHeader>..ctor
	|
	|-RVA: 0xBCA990 Offset: 0xBC9B90 VA: 0x180BCA990
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE15A0 Offset: 0xBE07A0 VA: 0x180BE15A0
	|-ReadOnlySpan<byte>..ctor
	|
	|-RVA: 0xBE1BD0 Offset: 0xBE0DD0 VA: 0x180BE1BD0
	|-ReadOnlySpan<char>..ctor
	|
	|-RVA: 0xBE19B0 Offset: 0xBE0BB0 VA: 0x180BE19B0
	|-ReadOnlySpan<DebugDirectoryEntry>..ctor
	|
	|-RVA: 0xBE1070 Offset: 0xBE0270 VA: 0x180BE1070
	|-ReadOnlySpan<int>..ctor
	|
	|-RVA: 0xBE18C0 Offset: 0xBE0AC0 VA: 0x180BE18C0
	|-ReadOnlySpan<SectionHeader>..ctor
	|
	|-RVA: 0xBE1320 Offset: 0xBE0520 VA: 0x180BE1320
	|-ReadOnlySpan<uint>..ctor
	|
	|-RVA: 0xBE1490 Offset: 0xBE0690 VA: 0x180BE1490
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0C80 Offset: 0xBDFE80 VA: 0x180BE0C80
	|-ReadOnlySpan<byte>..ctor
	|-ReadOnlySpan<char>..ctor
	|-ReadOnlySpan<DebugDirectoryEntry>..ctor
	|-ReadOnlySpan<int>..ctor
	|-ReadOnlySpan<SectionHeader>..ctor
	|-ReadOnlySpan<uint>..ctor
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1F80 Offset: 0xBE1180 VA: 0x180BE1F80
	|-ReadOnlySpan<byte>.get_Item
	|
	|-RVA: 0xBE1DA0 Offset: 0xBE0FA0 VA: 0x180BE1DA0
	|-ReadOnlySpan<char>.get_Item
	|
	|-RVA: 0xBE1E50 Offset: 0xBE1050 VA: 0x180BE1E50
	|-ReadOnlySpan<DebugDirectoryEntry>.get_Item
	|
	|-RVA: 0xBE1CE0 Offset: 0xBE0EE0 VA: 0x180BE1CE0
	|-ReadOnlySpan<int>.get_Item
	|-ReadOnlySpan<uint>.get_Item
	|
	|-RVA: 0xBE1DF0 Offset: 0xBE0FF0 VA: 0x180BE1DF0
	|-ReadOnlySpan<SectionHeader>.get_Item
	|
	|-RVA: 0xBCAAF0 Offset: 0xBC9CF0 VA: 0x180BCAAF0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Item
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC280 Offset: 0xBDB480 VA: 0x180BDC280
	|-ReadOnlySpan<byte>.GetPinnableReference
	|-ReadOnlySpan<char>.GetPinnableReference
	|-ReadOnlySpan<DebugDirectoryEntry>.GetPinnableReference
	|-ReadOnlySpan<int>.GetPinnableReference
	|-ReadOnlySpan<SectionHeader>.GetPinnableReference
	|-ReadOnlySpan<uint>.GetPinnableReference
	|
	|-RVA: 0xBDC2C0 Offset: 0xBDB4C0 VA: 0x180BDC2C0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBA80 Offset: 0xBDAC80 VA: 0x180BDBA80
	|-ReadOnlySpan<byte>.CopyTo
	|
	|-RVA: 0xBDBCD0 Offset: 0xBDAED0 VA: 0x180BDBCD0
	|-ReadOnlySpan<char>.CopyTo
	|
	|-RVA: 0xBDBBD0 Offset: 0xBDADD0 VA: 0x180BDBBD0
	|-ReadOnlySpan<DebugDirectoryEntry>.CopyTo
	|
	|-RVA: 0xBDBAE0 Offset: 0xBDACE0 VA: 0x180BDBAE0
	|-ReadOnlySpan<int>.CopyTo
	|-ReadOnlySpan<uint>.CopyTo
	|
	|-RVA: 0xBDBA20 Offset: 0xBDAC20 VA: 0x180BDBA20
	|-ReadOnlySpan<SectionHeader>.CopyTo
	|
	|-RVA: 0xBDBC30 Offset: 0xBDAE30 VA: 0x180BDBC30
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE06B0 Offset: 0xBDF8B0 VA: 0x180BE06B0
	|-ReadOnlySpan<byte>.TryCopyTo
	|
	|-RVA: 0xBE0370 Offset: 0xBDF570 VA: 0x180BE0370
	|-ReadOnlySpan<char>.TryCopyTo
	|
	|-RVA: 0xBE09F0 Offset: 0xBDFBF0 VA: 0x180BE09F0
	|-ReadOnlySpan<DebugDirectoryEntry>.TryCopyTo
	|
	|-RVA: 0xBE05A0 Offset: 0xBDF7A0 VA: 0x180BE05A0
	|-ReadOnlySpan<int>.TryCopyTo
	|-ReadOnlySpan<uint>.TryCopyTo
	|
	|-RVA: 0xBE08E0 Offset: 0xBDFAE0 VA: 0x180BE08E0
	|-ReadOnlySpan<SectionHeader>.TryCopyTo
	|
	|-RVA: 0xBE0130 Offset: 0xBDF330 VA: 0x180BE0130
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDF790 Offset: 0xBDE990 VA: 0x180BDF790
	|-ReadOnlySpan<byte>.ToString
	|
	|-RVA: 0xBDE890 Offset: 0xBDDA90 VA: 0x180BDE890
	|-ReadOnlySpan<char>.ToString
	|
	|-RVA: 0xBDEE80 Offset: 0xBDE080 VA: 0x180BDEE80
	|-ReadOnlySpan<DebugDirectoryEntry>.ToString
	|
	|-RVA: 0xBDFB50 Offset: 0xBDED50 VA: 0x180BDFB50
	|-ReadOnlySpan<int>.ToString
	|
	|-RVA: 0xBDEC50 Offset: 0xBDDE50 VA: 0x180BDEC50
	|-ReadOnlySpan<SectionHeader>.ToString
	|
	|-RVA: 0xBDF3D0 Offset: 0xBDE5D0 VA: 0x180BDF3D0
	|-ReadOnlySpan<uint>.ToString
	|
	|-RVA: 0xBDE630 Offset: 0xBDD830 VA: 0x180BDE630
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC590 Offset: 0xBDB790 VA: 0x180BDC590
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0xBDC460 Offset: 0xBDB660 VA: 0x180BDC460
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0xBDC3A0 Offset: 0xBDB5A0 VA: 0x180BDC3A0
	|-ReadOnlySpan<DebugDirectoryEntry>.Slice
	|
	|-RVA: 0xBDC940 Offset: 0xBDBB40 VA: 0x180BDC940
	|-ReadOnlySpan<int>.Slice
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0xBDCD00 Offset: 0xBDBF00 VA: 0x180BDCD00
	|-ReadOnlySpan<SectionHeader>.Slice
	|
	|-RVA: 0xBDCC20 Offset: 0xBDBE20 VA: 0x180BDCC20
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDD140 Offset: 0xBDC340 VA: 0x180BDD140
	|-ReadOnlySpan<byte>.Slice
	|
	|-RVA: 0xBDD000 Offset: 0xBDC200 VA: 0x180BDD000
	|-ReadOnlySpan<char>.Slice
	|
	|-RVA: 0xBDCDC0 Offset: 0xBDBFC0 VA: 0x180BDCDC0
	|-ReadOnlySpan<DebugDirectoryEntry>.Slice
	|
	|-RVA: 0xBDC9F0 Offset: 0xBDBBF0 VA: 0x180BDC9F0
	|-ReadOnlySpan<int>.Slice
	|-ReadOnlySpan<uint>.Slice
	|
	|-RVA: 0xBDD200 Offset: 0xBDC400 VA: 0x180BDD200
	|-ReadOnlySpan<SectionHeader>.Slice
	|
	|-RVA: 0xBDCB30 Offset: 0xBDBD30 VA: 0x180BDCB30
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDD5B0 Offset: 0xBDC7B0 VA: 0x180BDD5B0
	|-ReadOnlySpan<byte>.ToArray
	|
	|-RVA: 0xBDE1B0 Offset: 0xBDD3B0 VA: 0x180BDE1B0
	|-ReadOnlySpan<char>.ToArray
	|
	|-RVA: 0xBDD410 Offset: 0xBDC610 VA: 0x180BDD410
	|-ReadOnlySpan<DebugDirectoryEntry>.ToArray
	|
	|-RVA: 0xBDDC20 Offset: 0xBDCE20 VA: 0x180BDDC20
	|-ReadOnlySpan<int>.ToArray
	|-ReadOnlySpan<uint>.ToArray
	|
	|-RVA: 0xBDDA80 Offset: 0xBDCC80 VA: 0x180BDDA80
	|-ReadOnlySpan<SectionHeader>.ToArray
	|
	|-RVA: 0xBDD8A0 Offset: 0xBDCAA0 VA: 0x180BDD8A0
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.ToArray
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC000 Offset: 0xBDB200 VA: 0x180BDC000
	|-ReadOnlySpan<byte>.DangerousGetPinnableReference
	|-ReadOnlySpan<char>.DangerousGetPinnableReference
	|-ReadOnlySpan<DebugDirectoryEntry>.DangerousGetPinnableReference
	|-ReadOnlySpan<int>.DangerousGetPinnableReference
	|-ReadOnlySpan<SectionHeader>.DangerousGetPinnableReference
	|-ReadOnlySpan<uint>.DangerousGetPinnableReference
	|
	|-RVA: 0xBDC020 Offset: 0xBDB220 VA: 0x180BDC020
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-ReadOnlySpan<byte>.get_Pinnable
	|-ReadOnlySpan<char>.get_Pinnable
	|-ReadOnlySpan<DebugDirectoryEntry>.get_Pinnable
	|-ReadOnlySpan<int>.get_Pinnable
	|-ReadOnlySpan<SectionHeader>.get_Pinnable
	|-ReadOnlySpan<uint>.get_Pinnable
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	|-ReadOnlySpan<byte>.get_ByteOffset
	|-ReadOnlySpan<char>.get_ByteOffset
	|-ReadOnlySpan<DebugDirectoryEntry>.get_ByteOffset
	|-ReadOnlySpan<int>.get_ByteOffset
	|-ReadOnlySpan<SectionHeader>.get_ByteOffset
	|-ReadOnlySpan<uint>.get_ByteOffset
	|-ReadOnlySpan<__Il2CppFullySharedGenericType>.get_ByteOffset
	*/
}

// Namespace: System
[IsReadOnly]
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView<T>))]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DebuggerDisplay("{ToString(),raw}")]
[IsByRefLike]
[DefaultMember("Item")]
internal struct Span<T> // TypeDefIndex: 17087
{
	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-Span<byte>.get_Length
	|-Span<char>.get_Length
	|-Span<DebugDirectoryEntry>.get_Length
	|-Span<int>.get_Length
	|-Span<SectionHeader>.get_Length
	|-Span<uint>.get_Length
	|-Span<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1CC0 Offset: 0xBE0EC0 VA: 0x180BE1CC0
	|-Span<byte>.get_IsEmpty
	|-Span<char>.get_IsEmpty
	|-Span<DebugDirectoryEntry>.get_IsEmpty
	|-Span<int>.get_IsEmpty
	|-Span<SectionHeader>.get_IsEmpty
	|-Span<uint>.get_IsEmpty
	|-Span<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC100 Offset: 0xBDB300 VA: 0x180BDC100
	|-Span<byte>.Equals
	|-Span<char>.Equals
	|-Span<DebugDirectoryEntry>.Equals
	|-Span<int>.Equals
	|-Span<SectionHeader>.Equals
	|-Span<uint>.Equals
	|-Span<__Il2CppFullySharedGenericType>.Equals
	*/

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC210 Offset: 0xBDB410 VA: 0x180BDC210
	|-Span<byte>.GetHashCode
	|-Span<char>.GetHashCode
	|-Span<DebugDirectoryEntry>.GetHashCode
	|-Span<int>.GetHashCode
	|-Span<SectionHeader>.GetHashCode
	|-Span<uint>.GetHashCode
	|-Span<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC35480 Offset: 0xC34680 VA: 0x180C35480
	|-Span<byte>.op_Implicit
	|-Span<char>.op_Implicit
	|-Span<DebugDirectoryEntry>.op_Implicit
	|-Span<int>.op_Implicit
	|-Span<SectionHeader>.op_Implicit
	|-Span<uint>.op_Implicit
	|
	|-RVA: 0xC3BB70 Offset: 0xC3AD70 VA: 0x180C3BB70
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC34C30 Offset: 0xC33E30 VA: 0x180C34C30
	|-Span<byte>..ctor
	|-Span<char>..ctor
	|-Span<DebugDirectoryEntry>..ctor
	|-Span<int>..ctor
	|-Span<SectionHeader>..ctor
	|-Span<uint>..ctor
	|
	|-RVA: 0xC3B7C0 Offset: 0xC3A9C0 VA: 0x180C3B7C0
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Span<T> Create(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA25890 Offset: 0xA24A90 VA: 0x180A25890
	|-Span<byte>.Create
	|
	|-RVA: 0xC31DF0 Offset: 0xC30FF0 VA: 0x180C31DF0
	|-Span<char>.Create
	|
	|-RVA: 0xC31AE0 Offset: 0xC30CE0 VA: 0x180C31AE0
	|-Span<DebugDirectoryEntry>.Create
	|
	|-RVA: 0xC31C70 Offset: 0xC30E70 VA: 0x180C31C70
	|-Span<int>.Create
	|-Span<uint>.Create
	|
	|-RVA: 0xC36780 Offset: 0xC35980 VA: 0x180C36780
	|-Span<SectionHeader>.Create
	|
	|-RVA: 0xC364A0 Offset: 0xC356A0 VA: 0x180C364A0
	|-Span<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC35300 Offset: 0xC34500 VA: 0x180C35300
	|-Span<byte>..ctor
	|
	|-RVA: 0xC35120 Offset: 0xC34320 VA: 0x180C35120
	|-Span<char>..ctor
	|
	|-RVA: 0xC34910 Offset: 0xC33B10 VA: 0x180C34910
	|-Span<DebugDirectoryEntry>..ctor
	|
	|-RVA: 0xC34F00 Offset: 0xC34100 VA: 0x180C34F00
	|-Span<int>..ctor
	|-Span<uint>..ctor
	|
	|-RVA: 0xC3AD30 Offset: 0xC39F30 VA: 0x180C3AD30
	|-Span<SectionHeader>..ctor
	|
	|-RVA: 0xC3B510 Offset: 0xC3A710 VA: 0x180C3B510
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC34820 Offset: 0xC33A20 VA: 0x180C34820
	|-Span<byte>..ctor
	|
	|-RVA: 0xC34B40 Offset: 0xC33D40 VA: 0x180C34B40
	|-Span<char>..ctor
	|
	|-RVA: 0xC35030 Offset: 0xC34230 VA: 0x180C35030
	|-Span<DebugDirectoryEntry>..ctor
	|
	|-RVA: 0xC34A50 Offset: 0xC33C50 VA: 0x180C34A50
	|-Span<int>..ctor
	|
	|-RVA: 0xC3B280 Offset: 0xC3A480 VA: 0x180C3B280
	|-Span<SectionHeader>..ctor
	|
	|-RVA: 0xC3B9F0 Offset: 0xC3ABF0 VA: 0x180C3B9F0
	|-Span<uint>..ctor
	|
	|-RVA: 0xC3AE70 Offset: 0xC3A070 VA: 0x180C3AE70
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0C80 Offset: 0xBDFE80 VA: 0x180BE0C80
	|-Span<byte>..ctor
	|-Span<char>..ctor
	|-Span<DebugDirectoryEntry>..ctor
	|-Span<int>..ctor
	|-Span<SectionHeader>..ctor
	|-Span<uint>..ctor
	|-Span<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1F80 Offset: 0xBE1180 VA: 0x180BE1F80
	|-Span<byte>.get_Item
	|
	|-RVA: 0xBE1DA0 Offset: 0xBE0FA0 VA: 0x180BE1DA0
	|-Span<char>.get_Item
	|
	|-RVA: 0xBE1E50 Offset: 0xBE1050 VA: 0x180BE1E50
	|-Span<DebugDirectoryEntry>.get_Item
	|
	|-RVA: 0xBE1CE0 Offset: 0xBE0EE0 VA: 0x180BE1CE0
	|-Span<int>.get_Item
	|-Span<uint>.get_Item
	|
	|-RVA: 0xBE1DF0 Offset: 0xBE0FF0 VA: 0x180BE1DF0
	|-Span<SectionHeader>.get_Item
	|
	|-RVA: 0xC35A30 Offset: 0xC34C30 VA: 0x180C35A30
	|-Span<__Il2CppFullySharedGenericType>.get_Item
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC280 Offset: 0xBDB480 VA: 0x180BDC280
	|-Span<byte>.GetPinnableReference
	|-Span<char>.GetPinnableReference
	|-Span<DebugDirectoryEntry>.GetPinnableReference
	|-Span<int>.GetPinnableReference
	|-Span<SectionHeader>.GetPinnableReference
	|-Span<uint>.GetPinnableReference
	|
	|-RVA: 0xC38B80 Offset: 0xC37D80 VA: 0x180C38B80
	|-Span<__Il2CppFullySharedGenericType>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC31550 Offset: 0xC30750 VA: 0x180C31550
	|-Span<byte>.Clear
	|
	|-RVA: 0xC315A0 Offset: 0xC307A0 VA: 0x180C315A0
	|-Span<char>.Clear
	|
	|-RVA: 0xC31430 Offset: 0xC30630 VA: 0x180C31430
	|-Span<DebugDirectoryEntry>.Clear
	|
	|-RVA: 0xC31620 Offset: 0xC30820 VA: 0x180C31620
	|-Span<int>.Clear
	|-Span<uint>.Clear
	|
	|-RVA: 0xC35FE0 Offset: 0xC351E0 VA: 0x180C35FE0
	|-Span<SectionHeader>.Clear
	|
	|-RVA: 0xC35B60 Offset: 0xC34D60 VA: 0x180C35B60
	|-Span<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Fill(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC32340 Offset: 0xC31540 VA: 0x180C32340
	|-Span<byte>.Fill
	|
	|-RVA: 0xC32470 Offset: 0xC31670 VA: 0x180C32470
	|-Span<char>.Fill
	|
	|-RVA: 0xC32180 Offset: 0xC31380 VA: 0x180C32180
	|-Span<DebugDirectoryEntry>.Fill
	|
	|-RVA: 0xC32380 Offset: 0xC31580 VA: 0x180C32380
	|-Span<int>.Fill
	|
	|-RVA: 0xC37890 Offset: 0xC36A90 VA: 0x180C37890
	|-Span<SectionHeader>.Fill
	|
	|-RVA: 0xC377A0 Offset: 0xC369A0 VA: 0x180C377A0
	|-Span<uint>.Fill
	|
	|-RVA: 0xC369F0 Offset: 0xC35BF0 VA: 0x180C369F0
	|-Span<__Il2CppFullySharedGenericType>.Fill
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC31750 Offset: 0xC30950 VA: 0x180C31750
	|-Span<byte>.CopyTo
	|
	|-RVA: 0xC31970 Offset: 0xC30B70 VA: 0x180C31970
	|-Span<char>.CopyTo
	|
	|-RVA: 0xC316E0 Offset: 0xC308E0 VA: 0x180C316E0
	|-Span<DebugDirectoryEntry>.CopyTo
	|
	|-RVA: 0xC319E0 Offset: 0xC30BE0 VA: 0x180C319E0
	|-Span<int>.CopyTo
	|-Span<uint>.CopyTo
	|
	|-RVA: 0xC36220 Offset: 0xC35420 VA: 0x180C36220
	|-Span<SectionHeader>.CopyTo
	|
	|-RVA: 0xC36170 Offset: 0xC35370 VA: 0x180C36170
	|-Span<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC34430 Offset: 0xC33630 VA: 0x180C34430
	|-Span<byte>.TryCopyTo
	|
	|-RVA: 0xC34520 Offset: 0xC33720 VA: 0x180C34520
	|-Span<char>.TryCopyTo
	|
	|-RVA: 0xC346A0 Offset: 0xC338A0 VA: 0x180C346A0
	|-Span<DebugDirectoryEntry>.TryCopyTo
	|
	|-RVA: 0xC34340 Offset: 0xC33540 VA: 0x180C34340
	|-Span<int>.TryCopyTo
	|-Span<uint>.TryCopyTo
	|
	|-RVA: 0xC3A830 Offset: 0xC39A30 VA: 0x180C3A830
	|-Span<SectionHeader>.TryCopyTo
	|
	|-RVA: 0xC3AB30 Offset: 0xC39D30 VA: 0x180C3AB30
	|-Span<__Il2CppFullySharedGenericType>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC354E0 Offset: 0xC346E0 VA: 0x180C354E0
	|-Span<byte>.op_Implicit
	|-Span<char>.op_Implicit
	|-Span<DebugDirectoryEntry>.op_Implicit
	|-Span<int>.op_Implicit
	|-Span<SectionHeader>.op_Implicit
	|-Span<uint>.op_Implicit
	|-Span<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC34070 Offset: 0xC33270 VA: 0x180C34070
	|-Span<byte>.ToString
	|
	|-RVA: 0xC33EC0 Offset: 0xC330C0 VA: 0x180C33EC0
	|-Span<char>.ToString
	|
	|-RVA: 0xC336B0 Offset: 0xC328B0 VA: 0x180C336B0
	|-Span<DebugDirectoryEntry>.ToString
	|
	|-RVA: 0xC33D10 Offset: 0xC32F10 VA: 0x180C33D10
	|-Span<int>.ToString
	|
	|-RVA: 0xC39CD0 Offset: 0xC38ED0 VA: 0x180C39CD0
	|-Span<SectionHeader>.ToString
	|
	|-RVA: 0xC39990 Offset: 0xC38B90 VA: 0x180C39990
	|-Span<uint>.ToString
	|
	|-RVA: 0xC3A4C0 Offset: 0xC396C0 VA: 0x180C3A4C0
	|-Span<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC590 Offset: 0xBDB790 VA: 0x180BDC590
	|-Span<byte>.Slice
	|
	|-RVA: 0xBDC460 Offset: 0xBDB660 VA: 0x180BDC460
	|-Span<char>.Slice
	|
	|-RVA: 0xBDC3A0 Offset: 0xBDB5A0 VA: 0x180BDC3A0
	|-Span<DebugDirectoryEntry>.Slice
	|
	|-RVA: 0xBDC940 Offset: 0xBDBB40 VA: 0x180BDC940
	|-Span<int>.Slice
	|-Span<uint>.Slice
	|
	|-RVA: 0xBDCD00 Offset: 0xBDBF00 VA: 0x180BDCD00
	|-Span<SectionHeader>.Slice
	|
	|-RVA: 0xC38E20 Offset: 0xC38020 VA: 0x180C38E20
	|-Span<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDD140 Offset: 0xBDC340 VA: 0x180BDD140
	|-Span<byte>.Slice
	|
	|-RVA: 0xBDD000 Offset: 0xBDC200 VA: 0x180BDD000
	|-Span<char>.Slice
	|
	|-RVA: 0xBDCDC0 Offset: 0xBDBFC0 VA: 0x180BDCDC0
	|-Span<DebugDirectoryEntry>.Slice
	|
	|-RVA: 0xBDC9F0 Offset: 0xBDBBF0 VA: 0x180BDC9F0
	|-Span<int>.Slice
	|-Span<uint>.Slice
	|
	|-RVA: 0xBDD200 Offset: 0xBDC400 VA: 0x180BDD200
	|-Span<SectionHeader>.Slice
	|
	|-RVA: 0xC38C60 Offset: 0xC37E60 VA: 0x180C38C60
	|-Span<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC32950 Offset: 0xC31B50 VA: 0x180C32950
	|-Span<byte>.ToArray
	|
	|-RVA: 0xC32E90 Offset: 0xC32090 VA: 0x180C32E90
	|-Span<char>.ToArray
	|
	|-RVA: 0xC326B0 Offset: 0xC318B0 VA: 0x180C326B0
	|-Span<DebugDirectoryEntry>.ToArray
	|
	|-RVA: 0xC33130 Offset: 0xC32330 VA: 0x180C33130
	|-Span<int>.ToArray
	|-Span<uint>.ToArray
	|
	|-RVA: 0xC391B0 Offset: 0xC383B0 VA: 0x180C391B0
	|-Span<SectionHeader>.ToArray
	|
	|-RVA: 0xC38FD0 Offset: 0xC381D0 VA: 0x180C38FD0
	|-Span<__Il2CppFullySharedGenericType>.ToArray
	*/

	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDC000 Offset: 0xBDB200 VA: 0x180BDC000
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<char>.DangerousGetPinnableReference
	|-Span<DebugDirectoryEntry>.DangerousGetPinnableReference
	|-Span<int>.DangerousGetPinnableReference
	|-Span<SectionHeader>.DangerousGetPinnableReference
	|-Span<uint>.DangerousGetPinnableReference
	|
	|-RVA: 0xC36910 Offset: 0xC35B10 VA: 0x180C36910
	|-Span<__Il2CppFullySharedGenericType>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-Span<byte>.get_Pinnable
	|-Span<char>.get_Pinnable
	|-Span<DebugDirectoryEntry>.get_Pinnable
	|-Span<int>.get_Pinnable
	|-Span<SectionHeader>.get_Pinnable
	|-Span<uint>.get_Pinnable
	|-Span<__Il2CppFullySharedGenericType>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	|-Span<byte>.get_ByteOffset
	|-Span<char>.get_ByteOffset
	|-Span<DebugDirectoryEntry>.get_ByteOffset
	|-Span<int>.get_ByteOffset
	|-Span<SectionHeader>.get_ByteOffset
	|-Span<uint>.get_ByteOffset
	|-Span<__Il2CppFullySharedGenericType>.get_ByteOffset
	*/
}

// Namespace: System
internal sealed class SpanDebugView<T> // TypeDefIndex: 17088
{}

// Namespace: 
private struct SpanHelpers.Reg64 // TypeDefIndex: 17089
{}

// Namespace: 
private struct SpanHelpers.Reg32 // TypeDefIndex: 17090
{}

// Namespace: 
private struct SpanHelpers.Reg16 // TypeDefIndex: 17091
{}

// Namespace: 
public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 17092
{
	// Fields
	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7E9B0 Offset: 0xB7DBB0 VA: 0x180B7E9B0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<DebugDirectoryEntry>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<int>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<SectionHeader>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<uint>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<JsonDocument.DbRow>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<JsonDocument.StackRow>.MeasureArrayAdjustment
	|
	|-RVA: 0xB7EA20 Offset: 0xB7DC20 VA: 0x180B7EA20
	|-SpanHelpers.PerTypeValues<__Il2CppFullySharedGenericType>.MeasureArrayAdjustment
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7ED50 Offset: 0xB7DF50 VA: 0x180B7ED50
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0xB7FC10 Offset: 0xB7EE10 VA: 0x180B7FC10
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-RVA: 0xB7F3B0 Offset: 0xB7E5B0 VA: 0x180B7F3B0
	|-SpanHelpers.PerTypeValues<DebugDirectoryEntry>..cctor
	|
	|-RVA: 0xB7F7F0 Offset: 0xB7E9F0 VA: 0x180B7F7F0
	|-SpanHelpers.PerTypeValues<int>..cctor
	|
	|-RVA: 0xB7EB30 Offset: 0xB7DD30 VA: 0x180B7EB30
	|-SpanHelpers.PerTypeValues<SectionHeader>..cctor
	|
	|-RVA: 0xB7F190 Offset: 0xB7E390 VA: 0x180B7F190
	|-SpanHelpers.PerTypeValues<uint>..cctor
	|
	|-RVA: 0xB7FA10 Offset: 0xB7EC10 VA: 0x180B7FA10
	|-SpanHelpers.PerTypeValues<__Il2CppFullySharedGenericType>..cctor
	|
	|-RVA: 0xB7F5D0 Offset: 0xB7E7D0 VA: 0x180B7F5D0
	|-SpanHelpers.PerTypeValues<JsonDocument.DbRow>..cctor
	|
	|-RVA: 0xB7EF70 Offset: 0xB7E170 VA: 0x180B7EF70
	|-SpanHelpers.PerTypeValues<JsonDocument.StackRow>..cctor
	*/
}

// Namespace: System
[Extension]
internal static class SpanHelpers // TypeDefIndex: 17093
{
	// Methods

	// RVA: 0x1BB4ED0 Offset: 0x1BB40D0 VA: 0x181BB4ED0
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	// RVA: 0x1BB44D0 Offset: 0x1BB36D0 VA: 0x181BB44D0
	public static int IndexOfAny(ref byte searchSpace, byte value0, byte value1, byte value2, int length) { }

	// RVA: 0x1BB5F40 Offset: 0x1BB5140 VA: 0x181BB5F40
	public static bool SequenceEqual(ref byte first, ref byte second, NUInt length) { }

	// RVA: 0x1BB5C80 Offset: 0x1BB4E80 VA: 0x181BB5C80
	private static int LocateFirstFoundByte(Vector<byte> match) { }

	// RVA: 0x1BB5DD0 Offset: 0x1BB4FD0 VA: 0x181BB5DD0
	private static int LocateFirstFoundByte(ulong match) { }

	// RVA: 0x1BB43F0 Offset: 0x1BB35F0 VA: 0x181BB43F0
	private static Vector<byte> GetVector(byte vectorByte) { }

	// RVA: 0x1BB54C0 Offset: 0x1BB46C0 VA: 0x181BB54C0
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x1BB5DF0 Offset: 0x1BB4FF0 VA: 0x181BB5DF0
	private static int LocateFirstFoundChar(Vector<ushort> match) { }

	// RVA: 0x17BF6D0 Offset: 0x17BE8D0 VA: 0x1817BF6D0
	private static int LocateFirstFoundChar(ulong match) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ref T searchSpace, T value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA73210 Offset: 0xA72410 VA: 0x180A73210
	|-SpanHelpers.IndexOf<byte>
	|
	|-RVA: 0xA73550 Offset: 0xA72750 VA: 0x180A73550
	|-SpanHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ref T searchSpace, T value0, T value1, T value2, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA72C70 Offset: 0xA71E70 VA: 0x180A72C70
	|-SpanHelpers.IndexOfAny<byte>
	|
	|-RVA: 0xA74490 Offset: 0xA73690 VA: 0x180A74490
	|-SpanHelpers.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ref T first, ref T second, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA77060 Offset: 0xA76260 VA: 0x180A77060
	|-SpanHelpers.SequenceEqual<byte>
	|
	|-RVA: 0xA77430 Offset: 0xA76630 VA: 0x180A77430
	|-SpanHelpers.SequenceEqual<char>
	|
	|-RVA: 0xA77960 Offset: 0xA76B60 VA: 0x180A77960
	|-SpanHelpers.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA70B80 Offset: 0xA6FD80 VA: 0x180A70B80
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xA70EC0 Offset: 0xA700C0 VA: 0x180A70EC0
	|-SpanHelpers.CopyTo<char>
	|
	|-RVA: 0xA712F0 Offset: 0xA704F0 VA: 0x180A712F0
	|-SpanHelpers.CopyTo<DebugDirectoryEntry>
	|
	|-RVA: 0xA72250 Offset: 0xA71450 VA: 0x180A72250
	|-SpanHelpers.CopyTo<int>
	|-SpanHelpers.CopyTo<uint>
	|
	|-RVA: 0xA72690 Offset: 0xA71890 VA: 0x180A72690
	|-SpanHelpers.CopyTo<SectionHeader>
	|
	|-RVA: 0xA71870 Offset: 0xA70A70 VA: 0x180A71870
	|-SpanHelpers.CopyTo<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA70A50 Offset: 0xA6FC50 VA: 0x180A70A50
	|-SpanHelpers.Add<byte>
	|
	|-RVA: 0xA70A70 Offset: 0xA6FC70 VA: 0x180A70A70
	|-SpanHelpers.Add<char>
	|
	|-RVA: 0xA70A90 Offset: 0xA6FC90 VA: 0x180A70A90
	|-SpanHelpers.Add<DebugDirectoryEntry>
	|
	|-RVA: 0xA70B30 Offset: 0xA6FD30 VA: 0x180A70B30
	|-SpanHelpers.Add<int>
	|-SpanHelpers.Add<uint>
	|
	|-RVA: 0xA70B50 Offset: 0xA6FD50 VA: 0x180A70B50
	|-SpanHelpers.Add<SectionHeader>
	|
	|-RVA: 0xA70AC0 Offset: 0xA6FCC0 VA: 0x180A70AC0
	|-SpanHelpers.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA76FE0 Offset: 0xA761E0 VA: 0x180A76FE0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|-SpanHelpers.IsReferenceOrContainsReferences<DebugDirectoryEntry>
	|-SpanHelpers.IsReferenceOrContainsReferences<int>
	|-SpanHelpers.IsReferenceOrContainsReferences<SectionHeader>
	|-SpanHelpers.IsReferenceOrContainsReferences<uint>
	|-SpanHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|-SpanHelpers.IsReferenceOrContainsReferences<JsonDocument.DbRow>
	|-SpanHelpers.IsReferenceOrContainsReferences<JsonDocument.StackRow>
	*/

	// RVA: 0x1BB58A0 Offset: 0x1BB4AA0 VA: 0x181BB58A0
	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

	// RVA: 0x1BB3EF0 Offset: 0x1BB30F0 VA: 0x181BB3EF0
	public static void ClearLessThanPointerSized(byte* ptr, UIntPtr byteLength) { }

	// RVA: 0x1BB3F80 Offset: 0x1BB3180 VA: 0x181BB3F80
	public static void ClearLessThanPointerSized(ref byte b, UIntPtr byteLength) { }

	// RVA: 0x1BB4270 Offset: 0x1BB3470 VA: 0x181BB4270
	public static void ClearPointerSizedWithoutReferences(ref byte b, UIntPtr byteLength) { }

	// RVA: 0x1BB4020 Offset: 0x1BB3220 VA: 0x181BB4020
	public static void ClearPointerSizedWithReferences(ref IntPtr ip, UIntPtr pointerSizeLength) { }

	[Extension]
	// RVA: 0x1BB5C40 Offset: 0x1BB4E40 VA: 0x181BB5C40
	private static bool LessThanEqual(IntPtr index, UIntPtr length) { }
}

// Namespace: System
internal struct NUInt // TypeDefIndex: 17094
{
	// Fields
	private readonly void* _value; // 0x0

	// Methods

	// RVA: 0x181E750 Offset: 0x181D950 VA: 0x18181E750
	private void .ctor(uint value) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	private void .ctor(ulong value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static NUInt op_Explicit(int value) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static void* op_Explicit(NUInt value) { }

	// RVA: 0x1BB1C20 Offset: 0x1BB0E20 VA: 0x181BB1C20
	public static NUInt op_Multiply(NUInt left, NUInt right) { }
}

// Namespace: System
internal sealed class Pinnable<T> // TypeDefIndex: 17095
{
	// Fields
	public T Data; // 0x0
}

// Namespace: System
internal struct MutableDecimal // TypeDefIndex: 17096
{
	// Fields
	public uint Flags; // 0x0
	public uint High; // 0x4
	public uint Low; // 0x8
	public uint Mid; // 0xC

	// Properties
	public bool IsNegative { get; set; }
	public int Scale { get; set; }

	// Methods

	// RVA: 0x1BB1BE0 Offset: 0x1BB0DE0 VA: 0x181BB1BE0
	public bool get_IsNegative() { }

	// RVA: 0x1BB1BF0 Offset: 0x1BB0DF0 VA: 0x181BB1BF0
	public void set_IsNegative(bool value) { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public int get_Scale() { }

	// RVA: 0x1BB1C10 Offset: 0x1BB0E10 VA: 0x181BB1C10
	public void set_Scale(int value) { }
}

// Namespace: System
internal static class SR // TypeDefIndex: 17097
{
	// Fields
	private static ResourceManager s_resourceManager; // 0x0
	[CompilerGenerated]
	private static readonly Type <ResourceType>k__BackingField; // 0x8

	// Properties
	private static ResourceManager ResourceManager { get; }
	internal static Type ResourceType { get; }
	internal static string NotSupported_CannotCallEqualsOnSpan { get; }
	internal static string NotSupported_CannotCallGetHashCodeOnSpan { get; }
	internal static string Argument_InvalidTypeWithPointersNotSupported { get; }
	internal static string Argument_DestinationTooShort { get; }
	internal static string Argument_BadFormatSpecifier { get; }
	internal static string Argument_GWithPrecisionNotSupported { get; }
	internal static string Argument_PrecisionTooLarge { get; }
	internal static string EndPositionNotReached { get; }

	// Methods

	// RVA: 0x1BB3BE0 Offset: 0x1BB2DE0 VA: 0x181BB3BE0
	private static ResourceManager get_ResourceManager() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool UsingResourceKeys() { }

	// RVA: 0x1BB3690 Offset: 0x1BB2890 VA: 0x181BB3690
	internal static string GetResourceString(string resourceKey, string defaultString) { }

	// RVA: 0x1BB3560 Offset: 0x1BB2760 VA: 0x181BB3560
	internal static string Format(string resourceFormat, object p1) { }

	[CompilerGenerated]
	// RVA: 0x1BB3CE0 Offset: 0x1BB2EE0 VA: 0x181BB3CE0
	internal static Type get_ResourceType() { }

	// RVA: 0x1BB3B20 Offset: 0x1BB2D20 VA: 0x181BB3B20
	internal static string get_NotSupported_CannotCallEqualsOnSpan() { }

	// RVA: 0x1BB3B80 Offset: 0x1BB2D80 VA: 0x181BB3B80
	internal static string get_NotSupported_CannotCallGetHashCodeOnSpan() { }

	// RVA: 0x1BB3A00 Offset: 0x1BB2C00 VA: 0x181BB3A00
	internal static string get_Argument_InvalidTypeWithPointersNotSupported() { }

	// RVA: 0x1BB3940 Offset: 0x1BB2B40 VA: 0x181BB3940
	internal static string get_Argument_DestinationTooShort() { }

	// RVA: 0x1BB38E0 Offset: 0x1BB2AE0 VA: 0x181BB38E0
	internal static string get_Argument_BadFormatSpecifier() { }

	// RVA: 0x1BB39A0 Offset: 0x1BB2BA0 VA: 0x181BB39A0
	internal static string get_Argument_GWithPrecisionNotSupported() { }

	// RVA: 0x1BB3A60 Offset: 0x1BB2C60 VA: 0x181BB3A60
	internal static string get_Argument_PrecisionTooLarge() { }

	// RVA: 0x1BB3AC0 Offset: 0x1BB2CC0 VA: 0x181BB3AC0
	internal static string get_EndPositionNotReached() { }

	// RVA: 0x1BB3860 Offset: 0x1BB2A60 VA: 0x181BB3860
	private static void .cctor() { }
}

// Namespace: System.Numerics.Hashing
internal static class HashHelpers // TypeDefIndex: 17098
{
	// Fields
	public static readonly int RandomSeed; // 0x0

	// Methods

	// RVA: 0x16DB5B0 Offset: 0x16DA7B0 VA: 0x1816DB5B0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x1BB0F20 Offset: 0x1BB0120 VA: 0x181BB0F20
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
internal static class SequenceMarshal // TypeDefIndex: 17099
{
	// Methods

	// RVA: 0x1BB3D30 Offset: 0x1BB2F30 VA: 0x181BB3D30
	internal static bool TryGetString(ReadOnlySequence<char> sequence, out string text, out int start, out int length) { }
}

// Namespace: System.Runtime.InteropServices
internal static class MemoryMarshal // TypeDefIndex: 17100
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D300 Offset: 0xA4C500 VA: 0x180A4D300
	|-MemoryMarshal.TryGetArray<byte>
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0xA4D890 Offset: 0xA4CA90 VA: 0x180A4D890
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Read<T>(ReadOnlySpan<byte> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D160 Offset: 0xA4C360 VA: 0x180A4D160
	|-MemoryMarshal.Read<int>
	|-MemoryMarshal.Read<uint>
	|
	|-RVA: 0xA4CFF0 Offset: 0xA4C1F0 VA: 0x180A4CFF0
	|-MemoryMarshal.Read<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xA4CF00 Offset: 0xA4C100 VA: 0x180A4CF00
	|-MemoryMarshal.Read<JsonDocument.DbRow>
	|
	|-RVA: 0xA4D230 Offset: 0xA4C430 VA: 0x180A4D230
	|-MemoryMarshal.Read<JsonDocument.StackRow>
	*/

	// RVA: -1 Offset: -1
	public static void Write<T>(Span<byte> destination, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4E320 Offset: 0xA4D520 VA: 0x180A4E320
	|-MemoryMarshal.Write<int>
	|-MemoryMarshal.Write<uint>
	|
	|-RVA: 0xA4E1B0 Offset: 0xA4D3B0 VA: 0x180A4E1B0
	|-MemoryMarshal.Write<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xA4E0C0 Offset: 0xA4D2C0 VA: 0x180A4E0C0
	|-MemoryMarshal.Write<JsonDocument.DbRow>
	|
	|-RVA: 0xA4E400 Offset: 0xA4D600 VA: 0x180A4E400
	|-MemoryMarshal.Write<JsonDocument.StackRow>
	*/

	// RVA: -1 Offset: -1
	public static bool TryWrite<T>(Span<byte> destination, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4DFD0 Offset: 0xA4D1D0 VA: 0x180A4DFD0
	|-MemoryMarshal.TryWrite<uint>
	|
	|-RVA: 0xA4DE60 Offset: 0xA4D060 VA: 0x180A4DE60
	|-MemoryMarshal.TryWrite<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4BFD0 Offset: 0xA4B1D0 VA: 0x180A4BFD0
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0xA4C120 Offset: 0xA4B320 VA: 0x180A4C120
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C630 Offset: 0xA4B830 VA: 0x180A4C630
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0xA4CE20 Offset: 0xA4C020 VA: 0x180A4CE20
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C630 Offset: 0xA4B830 VA: 0x180A4C630
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0xA4CE20 Offset: 0xA4C020 VA: 0x180A4CE20
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C270 Offset: 0xA4B470 VA: 0x180A4C270
	|-MemoryMarshal.Cast<byte, int>
	|
	|-RVA: 0xA4C420 Offset: 0xA4B620 VA: 0x180A4C420
	|-MemoryMarshal.Cast<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C270 Offset: 0xA4B470 VA: 0x180A4C270
	|-MemoryMarshal.Cast<byte, uint>
	|
	|-RVA: 0xA4C420 Offset: 0xA4B620 VA: 0x180A4C420
	|-MemoryMarshal.Cast<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Buffers
[Extension]
internal static class BuffersExtensions // TypeDefIndex: 17101
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(in ReadOnlySequence<T> source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x944C50 Offset: 0x943E50 VA: 0x180944C50
	|-BuffersExtensions.CopyTo<byte>
	|
	|-RVA: 0x944DE0 Offset: 0x943FE0 VA: 0x180944DE0
	|-BuffersExtensions.CopyTo<char>
	|
	|-RVA: 0x944F70 Offset: 0x944170 VA: 0x180944F70
	|-BuffersExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void CopyToMultiSegment<T>(in ReadOnlySequence<T> sequence, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x944670 Offset: 0x943870 VA: 0x180944670
	|-BuffersExtensions.CopyToMultiSegment<byte>
	|
	|-RVA: 0x944880 Offset: 0x943A80 VA: 0x180944880
	|-BuffersExtensions.CopyToMultiSegment<char>
	|
	|-RVA: 0x944A90 Offset: 0x943C90 VA: 0x180944A90
	|-BuffersExtensions.CopyToMultiSegment<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(in ReadOnlySequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x945140 Offset: 0x944340 VA: 0x180945140
	|-BuffersExtensions.ToArray<byte>
	|
	|-RVA: 0x945370 Offset: 0x944570 VA: 0x180945370
	|-BuffersExtensions.ToArray<char>
	|
	|-RVA: 0x9455A0 Offset: 0x9447A0 VA: 0x1809455A0
	|-BuffersExtensions.ToArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Buffers
internal interface IBufferWriter<T> // TypeDefIndex: 17102
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Advance(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<__Il2CppFullySharedGenericType>.Advance
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Memory<T> GetMemory(int sizeHint = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<__Il2CppFullySharedGenericType>.GetMemory
	*/
}

// Namespace: System.Buffers
internal enum OperationStatus // TypeDefIndex: 17103
{
	// Fields
	public int value__; // 0x0
	public const OperationStatus Done = 0;
	public const OperationStatus DestinationTooSmall = 1;
	public const OperationStatus NeedMoreData = 2;
	public const OperationStatus InvalidData = 3;
}

// Namespace: 
private enum ReadOnlySequence.SequenceType<T> // TypeDefIndex: 17104
{
	// Fields
	public int value__; // 0x0
	public const ReadOnlySequence.SequenceType<T> MultiSegment = 0;
	public const ReadOnlySequence.SequenceType<T> Array = 1;
	public const ReadOnlySequence.SequenceType<T> MemoryManager = 2;
	public const ReadOnlySequence.SequenceType<T> String = 3;
	public const ReadOnlySequence.SequenceType<T> Empty = 4;
}

// Namespace: System.Buffers
[IsReadOnly]
[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(ReadOnlySequenceDebugView<T>))]
internal struct ReadOnlySequence<T> // TypeDefIndex: 17105
{
	// Fields
	private readonly SequencePosition _sequenceStart; // 0x0
	private readonly SequencePosition _sequenceEnd; // 0x0
	public static readonly ReadOnlySequence<T> Empty; // 0x0

	// Properties
	public long Length { get; }
	public bool IsEmpty { get; }
	public bool IsSingleSegment { get; }
	public ReadOnlyMemory<T> First { get; }
	public SequencePosition Start { get; }

	// Methods

	// RVA: -1 Offset: -1
	public long get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB8E0 Offset: 0xBDAAE0 VA: 0x180BDB8E0
	|-ReadOnlySequence<byte>.get_Length
	|-ReadOnlySequence<char>.get_Length
	|
	|-RVA: 0xBDB970 Offset: 0xBDAB70 VA: 0x180BDB970
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB780 Offset: 0xBDA980 VA: 0x180BDB780
	|-ReadOnlySequence<byte>.get_IsEmpty
	|-ReadOnlySequence<char>.get_IsEmpty
	|
	|-RVA: 0xBDB810 Offset: 0xBDAA10 VA: 0x180BDB810
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSingleSegment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB8D0 Offset: 0xBDAAD0 VA: 0x180BDB8D0
	|-ReadOnlySequence<byte>.get_IsSingleSegment
	|-ReadOnlySequence<char>.get_IsSingleSegment
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_IsSingleSegment
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB600 Offset: 0xBDA800 VA: 0x180BDB600
	|-ReadOnlySequence<byte>.get_First
	|
	|-RVA: 0xBDB550 Offset: 0xBDA750 VA: 0x180BDB550
	|-ReadOnlySequence<char>.get_First
	|
	|-RVA: 0xBDB6B0 Offset: 0xBDA8B0 VA: 0x180BDB6B0
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_First
	*/

	// RVA: -1 Offset: -1
	public SequencePosition get_Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-ReadOnlySequence<byte>.get_Start
	|-ReadOnlySequence<char>.get_Start
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_Start
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object startSegment, int startIndexAndFlags, object endSegment, int endIndexAndFlags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB4F0 Offset: 0xBDA6F0 VA: 0x180BDB4F0
	|-ReadOnlySequence<byte>..ctor
	|-ReadOnlySequence<char>..ctor
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB460 Offset: 0xBDA660 VA: 0x180BDB460
	|-ReadOnlySequence<byte>..ctor
	|-ReadOnlySequence<char>..ctor
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(long start, long length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7B30 Offset: 0xBD6D30 VA: 0x180BD7B30
	|-ReadOnlySequence<byte>.Slice
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0xBD80E0 Offset: 0xBD72E0 VA: 0x180BD80E0
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence<T> Slice(SequencePosition start, SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC9100 Offset: 0xBC8300 VA: 0x180BC9100
	|-ReadOnlySequence<byte>.Slice
	|-ReadOnlySequence<char>.Slice
	|
	|-RVA: 0xBC8F00 Offset: 0xBC8100 VA: 0x180BC8F00
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD8860 Offset: 0xBD7A60 VA: 0x180BD8860
	|-ReadOnlySequence<byte>.ToString
	|
	|-RVA: 0xBD8EC0 Offset: 0xBD80C0 VA: 0x180BD8EC0
	|-ReadOnlySequence<char>.ToString
	|
	|-RVA: 0xBD8B70 Offset: 0xBD7D70 VA: 0x180BD8B70
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(ref SequencePosition position, out ReadOnlyMemory<T> memory, bool advance = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB1F0 Offset: 0xBDA3F0 VA: 0x180BDB1F0
	|-ReadOnlySequence<byte>.TryGet
	|
	|-RVA: 0xBDB010 Offset: 0xBDA210 VA: 0x180BDB010
	|-ReadOnlySequence<char>.TryGet
	|
	|-RVA: 0xBDB0F0 Offset: 0xBDA2F0 VA: 0x180BDB0F0
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGet
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetBuffer(in SequencePosition position, out ReadOnlyMemory<T> memory, out SequencePosition next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD9930 Offset: 0xBD8B30 VA: 0x180BD9930
	|-ReadOnlySequence<byte>.TryGetBuffer
	|
	|-RVA: 0xBD91D0 Offset: 0xBD83D0 VA: 0x180BD91D0
	|-ReadOnlySequence<char>.TryGetBuffer
	|
	|-RVA: 0xBDA090 Offset: 0xBD9290 VA: 0x180BDA090
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGetBuffer
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyMemory<T> GetFirstBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7000 Offset: 0xBD6200 VA: 0x180BD7000
	|-ReadOnlySequence<byte>.GetFirstBuffer
	|
	|-RVA: 0xBD6920 Offset: 0xBD5B20 VA: 0x180BD6920
	|-ReadOnlySequence<char>.GetFirstBuffer
	|
	|-RVA: 0xBD6200 Offset: 0xBD5400 VA: 0x180BD6200
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetFirstBuffer
	*/

	// RVA: -1 Offset: -1
	private static SequencePosition SeekMultiSegment(ReadOnlySequenceSegment<T> currentSegment, object endObject, int endIndex, long offset, ExceptionArgument argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD7710 Offset: 0xBD6910 VA: 0x180BD7710
	|-ReadOnlySequence<byte>.SeekMultiSegment
	|-ReadOnlySequence<char>.SeekMultiSegment
	|
	|-RVA: 0xBD7820 Offset: 0xBD6A20 VA: 0x180BD7820
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.SeekMultiSegment
	*/

	// RVA: -1 Offset: -1
	private void BoundsCheck(uint sliceStartIndex, object sliceStartObject, uint sliceEndIndex, object sliceEndObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5890 Offset: 0xBD4A90 VA: 0x180BD5890
	|-ReadOnlySequence<byte>.BoundsCheck
	|-ReadOnlySequence<char>.BoundsCheck
	|
	|-RVA: 0xBD51B0 Offset: 0xBD43B0 VA: 0x180BD51B0
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.BoundsCheck
	*/

	// RVA: -1 Offset: -1
	private static SequencePosition GetEndPosition(ReadOnlySequenceSegment<T> startSegment, object startObject, int startIndex, object endObject, int endIndex, long length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5E00 Offset: 0xBD5000 VA: 0x180BD5E00
	|-ReadOnlySequence<byte>.GetEndPosition
	|-ReadOnlySequence<char>.GetEndPosition
	|
	|-RVA: 0xBD5FA0 Offset: 0xBD51A0 VA: 0x180BD5FA0
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetEndPosition
	*/

	// RVA: -1 Offset: -1
	private ReadOnlySequence.SequenceType<T> GetSequenceType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD76F0 Offset: 0xBD68F0 VA: 0x180BD76F0
	|-ReadOnlySequence<byte>.GetSequenceType
	|-ReadOnlySequence<char>.GetSequenceType
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetSequenceType
	*/

	// RVA: -1 Offset: -1
	private static int GetIndex(in SequencePosition position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD76E0 Offset: 0xBD68E0 VA: 0x180BD76E0
	|-ReadOnlySequence<byte>.GetIndex
	|-ReadOnlySequence<char>.GetIndex
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetIndex
	*/

	// RVA: -1 Offset: -1
	private ReadOnlySequence<T> SliceImpl(in SequencePosition start, in SequencePosition end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD79E0 Offset: 0xBD6BE0 VA: 0x180BD79E0
	|-ReadOnlySequence<byte>.SliceImpl
	|-ReadOnlySequence<char>.SliceImpl
	|
	|-RVA: 0xBC8D40 Offset: 0xBC7F40 VA: 0x180BC8D40
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.SliceImpl
	*/

	// RVA: -1 Offset: -1
	private long GetLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC8810 Offset: 0xBC7A10 VA: 0x180BC8810
	|-ReadOnlySequence<byte>.GetLength
	|-ReadOnlySequence<char>.GetLength
	|
	|-RVA: 0xBC8A40 Offset: 0xBC7C40 VA: 0x180BC8A40
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetLength
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetString(out string text, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDABB0 Offset: 0xBD9DB0 VA: 0x180BDABB0
	|-ReadOnlySequence<byte>.TryGetString
	|
	|-RVA: 0xBDADE0 Offset: 0xBD9FE0 VA: 0x180BDADE0
	|-ReadOnlySequence<char>.TryGetString
	|
	|-RVA: 0xBDA900 Offset: 0xBD9B00 VA: 0x180BDA900
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGetString
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB2D0 Offset: 0xBDA4D0 VA: 0x180BDB2D0
	|-ReadOnlySequence<byte>..cctor
	|-ReadOnlySequence<char>..cctor
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Buffers
internal static class ReadOnlySequence // TypeDefIndex: 17106
{
	// Methods

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static int ArrayToSequenceStart(int startIndex) { }

	// RVA: 0x1BB3550 Offset: 0x1BB2750 VA: 0x181BB3550
	public static int ArrayToSequenceEnd(int endIndex) { }
}

// Namespace: System.Buffers
internal sealed class ReadOnlySequenceDebugView<T> // TypeDefIndex: 17107
{}

// Namespace: System.Buffers
internal abstract class ReadOnlySequenceSegment<T> // TypeDefIndex: 17108
{
	// Fields
	[CompilerGenerated]
	private ReadOnlyMemory<T> <Memory>k__BackingField; // 0x0
	[CompilerGenerated]
	private ReadOnlySequenceSegment<T> <Next>k__BackingField; // 0x0
	[CompilerGenerated]
	private long <RunningIndex>k__BackingField; // 0x0

	// Properties
	public ReadOnlyMemory<T> Memory { get; }
	public ReadOnlySequenceSegment<T> Next { get; }
	public long RunningIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-ReadOnlySequenceSegment<byte>.get_Memory
	|-ReadOnlySequenceSegment<char>.get_Memory
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_Memory
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ReadOnlySequenceSegment<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-ReadOnlySequenceSegment<byte>.get_Next
	|-ReadOnlySequenceSegment<char>.get_Next
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_Next
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public long get_RunningIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-ReadOnlySequenceSegment<byte>.get_RunningIndex
	|-ReadOnlySequenceSegment<char>.get_RunningIndex
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_RunningIndex
	*/
}

// Namespace: System.Buffers
[IsReadOnly]
internal struct StandardFormat : IEquatable<StandardFormat> // TypeDefIndex: 17109
{
	// Fields
	private readonly byte _format; // 0x0
	private readonly byte _precision; // 0x1

	// Properties
	public char Symbol { get; }
	public byte Precision { get; }
	public bool HasPrecision { get; }
	public bool IsDefault { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public char get_Symbol() { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public byte get_Precision() { }

	// RVA: 0x1BB65E0 Offset: 0x1BB57E0 VA: 0x181BB65E0
	public bool get_HasPrecision() { }

	// RVA: 0x1BB65F0 Offset: 0x1BB57F0 VA: 0x181BB65F0
	public bool get_IsDefault() { }

	// RVA: 0x1BB65B0 Offset: 0x1BB57B0 VA: 0x181BB65B0
	public void .ctor(char symbol, byte precision = 255) { }

	// RVA: 0x1BB6600 Offset: 0x1BB5800 VA: 0x181BB6600
	public static StandardFormat op_Implicit(char symbol) { }

	// RVA: 0x1BB63C0 Offset: 0x1BB55C0 VA: 0x181BB63C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BB6450 Offset: 0x1BB5650 VA: 0x181BB6450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BB63A0 Offset: 0x1BB55A0 VA: 0x181BB63A0 Slot: 4
	public bool Equals(StandardFormat other) { }

	// RVA: 0x1BB64A0 Offset: 0x1BB56A0 VA: 0x181BB64A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Buffers
internal abstract class MemoryManager<T> // TypeDefIndex: 17110
{
	// Properties
	public virtual Memory<T> Memory { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual Memory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1461A50 Offset: 0x1460C50 VA: 0x181461A50
	|-MemoryManager<byte>.get_Memory
	|-MemoryManager<char>.get_Memory
	|
	|-RVA: 0x14619A0 Offset: 0x1460BA0 VA: 0x1814619A0
	|-MemoryManager<__Il2CppFullySharedGenericType>.get_Memory
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Span<T> GetSpan();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1461990 Offset: 0x1460B90 VA: 0x181461990
	|-MemoryManager<byte>.TryGetArray
	|-MemoryManager<char>.TryGetArray
	|-MemoryManager<__Il2CppFullySharedGenericType>.TryGetArray
	*/
}

// Namespace: System.Buffers.Text
internal static class Base64 // TypeDefIndex: 17111
{
	// Fields
	private static readonly sbyte[] s_decodingMap; // 0x0
	private static readonly byte[] s_encodingMap; // 0x8

	// Methods

	// RVA: 0x1BAF970 Offset: 0x1BAEB70 VA: 0x181BAF970
	public static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> utf8, Span<byte> bytes, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = True) { }

	// RVA: 0x1BB0270 Offset: 0x1BAF470 VA: 0x181BB0270
	public static int GetMaxDecodedFromUtf8Length(int length) { }

	// RVA: 0x1BAF6C0 Offset: 0x1BAE8C0 VA: 0x181BAF6C0
	public static OperationStatus DecodeFromUtf8InPlace(Span<byte> buffer, out int bytesWritten) { }

	// RVA: 0x1BAFDA0 Offset: 0x1BAEFA0 VA: 0x181BAFDA0
	private static int Decode(ref byte encodedBytes, ref sbyte decodingMap) { }

	// RVA: 0x1778E60 Offset: 0x1778060 VA: 0x181778E60
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

	// RVA: 0x1BAFE60 Offset: 0x1BAF060 VA: 0x181BAFE60
	public static OperationStatus EncodeToUtf8(ReadOnlySpan<byte> bytes, Span<byte> utf8, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = True) { }

	// RVA: 0x1BB0290 Offset: 0x1BAF490 VA: 0x181BB0290
	public static int GetMaxEncodedToUtf8Length(int length) { }

	// RVA: 0x1BB0210 Offset: 0x1BAF410 VA: 0x181BB0210
	private static int Encode(ref byte threeBytes, ref byte encodingMap) { }

	// RVA: 0x1BAFDE0 Offset: 0x1BAEFE0 VA: 0x181BAFDE0
	private static int EncodeAndPadOne(ref byte twoBytes, ref byte encodingMap) { }

	// RVA: 0x1BAFE30 Offset: 0x1BAF030 VA: 0x181BAFE30
	private static int EncodeAndPadTwo(ref byte oneByte, ref byte encodingMap) { }

	// RVA: 0x1BB02C0 Offset: 0x1BAF4C0 VA: 0x181BB02C0
	private static void .cctor() { }
}

// Namespace: System.Buffers.Text
internal static class Utf8Constants // TypeDefIndex: 17112
{
	// Fields
	public static readonly TimeSpan s_nullUtcOffset; // 0x0

	// Methods

	// RVA: 0x1BB7090 Offset: 0x1BB6290 VA: 0x181BB7090
	private static void .cctor() { }
}

// Namespace: 
public enum FormattingHelpers.HexCasing // TypeDefIndex: 17113
{
	// Fields
	public uint value__; // 0x0
	public const FormattingHelpers.HexCasing Uppercase = 0;
	public const FormattingHelpers.HexCasing Lowercase = 8224;
}

// Namespace: System.Buffers.Text
internal static class FormattingHelpers // TypeDefIndex: 17114
{
	// Methods

	// RVA: 0x1BB0940 Offset: 0x1BAFB40 VA: 0x181BB0940
	public static char GetSymbolOrDefault(in StandardFormat format, char defaultSymbol) { }

	// RVA: 0x1BB08C0 Offset: 0x1BAFAC0 VA: 0x181BB08C0
	public static void FillWithAsciiZeros(Span<byte> buffer) { }

	// RVA: 0x1BB0D80 Offset: 0x1BAFF80 VA: 0x181BB0D80
	public static void WriteHexByte(byte value, Span<byte> buffer, int startingIndex = 0, FormattingHelpers.HexCasing casing = 0) { }

	// RVA: 0x1BB0B40 Offset: 0x1BAFD40 VA: 0x181BB0B40
	public static void WriteDigits(ulong value, Span<byte> buffer) { }

	// RVA: 0x1BB0950 Offset: 0x1BAFB50 VA: 0x181BB0950
	public static void WriteDigitsWithGroupSeparator(ulong value, Span<byte> buffer) { }

	// RVA: 0x1BB0A60 Offset: 0x1BAFC60 VA: 0x181BB0A60
	public static void WriteDigits(uint value, Span<byte> buffer) { }

	// RVA: 0x1BB0C30 Offset: 0x1BAFE30 VA: 0x181BB0C30
	public static void WriteFourDecimalDigits(uint value, Span<byte> buffer, int startingIndex = 0) { }

	// RVA: 0x1BB0E60 Offset: 0x1BB0060 VA: 0x181BB0E60
	public static void WriteTwoDecimalDigits(uint value, Span<byte> buffer, int startingIndex = 0) { }

	// RVA: 0x1732CF0 Offset: 0x1731EF0 VA: 0x181732CF0
	public static int CountDigits(ulong value) { }

	// RVA: 0x1732D90 Offset: 0x1731F90 VA: 0x181732D90
	public static int CountDigits(uint value) { }

	// RVA: 0x1732DF0 Offset: 0x1731FF0 VA: 0x181732DF0
	public static int CountHexDigits(ulong value) { }
}

// Namespace: 
private struct Utf8Formatter.DecomposedGuid // TypeDefIndex: 17115
{
	// Fields
	public Guid Guid; // 0x0
	public byte Byte00; // 0x0
	public byte Byte01; // 0x1
	public byte Byte02; // 0x2
	public byte Byte03; // 0x3
	public byte Byte04; // 0x4
	public byte Byte05; // 0x5
	public byte Byte06; // 0x6
	public byte Byte07; // 0x7
	public byte Byte08; // 0x8
	public byte Byte09; // 0x9
	public byte Byte10; // 0xA
	public byte Byte11; // 0xB
	public byte Byte12; // 0xC
	public byte Byte13; // 0xD
	public byte Byte14; // 0xE
	public byte Byte15; // 0xF
}

// Namespace: System.Buffers.Text
internal static class Utf8Formatter // TypeDefIndex: 17116
{
	// Fields
	private static readonly uint[] DayAbbreviations; // 0x0
	private static readonly uint[] DayAbbreviationsLowercase; // 0x8
	private static readonly uint[] MonthAbbreviations; // 0x10
	private static readonly uint[] MonthAbbreviationsLowercase; // 0x18

	// Methods

	// RVA: 0x1BBB6B0 Offset: 0x1BBA8B0 VA: 0x181BBB6B0
	public static bool TryFormat(bool value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BBC650 Offset: 0x1BBB850 VA: 0x181BBC650
	public static bool TryFormat(DateTimeOffset value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BBBC80 Offset: 0x1BBAE80 VA: 0x181BBBC80
	public static bool TryFormat(DateTime value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BB7100 Offset: 0x1BB6300 VA: 0x181BB7100
	private static bool TryFormatDateTimeG(DateTime value, TimeSpan offset, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB7A80 Offset: 0x1BB6C80 VA: 0x181BB7A80
	private static bool TryFormatDateTimeO(DateTime value, TimeSpan offset, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB8010 Offset: 0x1BB7210 VA: 0x181BB8010
	private static bool TryFormatDateTimeR(DateTime value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB75B0 Offset: 0x1BB67B0 VA: 0x181BB75B0
	private static bool TryFormatDateTimeL(DateTime value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBB8C0 Offset: 0x1BBAAC0 VA: 0x181BBB8C0
	public static bool TryFormat(Decimal value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BB84E0 Offset: 0x1BB76E0 VA: 0x181BB84E0
	private static bool TryFormatDecimalE(ref NumberBuffer number, Span<byte> destination, out int bytesWritten, byte precision, byte exponentSymbol) { }

	// RVA: 0x1BB88E0 Offset: 0x1BB7AE0 VA: 0x181BB88E0
	private static bool TryFormatDecimalF(ref NumberBuffer number, Span<byte> destination, out int bytesWritten, byte precision) { }

	// RVA: 0x1BB8C50 Offset: 0x1BB7E50 VA: 0x181BB8C50
	private static bool TryFormatDecimalG(ref NumberBuffer number, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBBF30 Offset: 0x1BBB130 VA: 0x181BBBF30
	public static bool TryFormat(Guid value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BBC8F0 Offset: 0x1BBBAF0 VA: 0x181BBC8F0
	public static bool TryFormat(byte value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBBE90 Offset: 0x1BBB090 VA: 0x181BBBE90
	public static bool TryFormat(ulong value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BBC5B0 Offset: 0x1BBB7B0 VA: 0x181BBC5B0
	public static bool TryFormat(long value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BB9E10 Offset: 0x1BB9010 VA: 0x181BB9E10
	private static bool TryFormatInt64(long value, ulong mask, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BB9150 Offset: 0x1BB8350 VA: 0x181BB9150
	private static bool TryFormatInt64D(long value, byte precision, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB9210 Offset: 0x1BB8410 VA: 0x181BB9210
	private static bool TryFormatInt64Default(long value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB8FA0 Offset: 0x1BB81A0 VA: 0x181BB8FA0
	private static bool TryFormatInt32MultipleDigits(int value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB9BF0 Offset: 0x1BB8DF0 VA: 0x181BB9BF0
	private static bool TryFormatInt64MultipleDigits(long value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB9900 Offset: 0x1BB8B00 VA: 0x181BB9900
	private static bool TryFormatInt64MoreThanNegativeBillionMaxUInt(long value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB9500 Offset: 0x1BB8700 VA: 0x181BB9500
	private static bool TryFormatInt64LessThanNegativeBillionMaxUInt(long value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BB9D50 Offset: 0x1BB8F50 VA: 0x181BB9D50
	private static bool TryFormatInt64N(long value, byte precision, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBB3D0 Offset: 0x1BBA5D0 VA: 0x181BBB3D0
	private static bool TryFormatUInt64(ulong value, Span<byte> destination, out int bytesWritten, StandardFormat format) { }

	// RVA: 0x1BBA360 Offset: 0x1BB9560 VA: 0x181BBA360
	private static bool TryFormatUInt64D(ulong value, byte precision, Span<byte> destination, bool insertNegationSign, out int bytesWritten) { }

	// RVA: 0x1BBA570 Offset: 0x1BB9770 VA: 0x181BBA570
	private static bool TryFormatUInt64Default(ulong value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBA2C0 Offset: 0x1BB94C0 VA: 0x181BBA2C0
	private static bool TryFormatUInt32SingleDigit(uint value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBA100 Offset: 0x1BB9300 VA: 0x181BBA100
	private static bool TryFormatUInt32MultipleDigits(uint value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBAE20 Offset: 0x1BBA020 VA: 0x181BBAE20
	private static bool TryFormatUInt64MultipleDigits(ulong value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBA7A0 Offset: 0x1BB99A0 VA: 0x181BBA7A0
	private static bool TryFormatUInt64LessThanBillionMaxUInt(ulong value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBAA60 Offset: 0x1BB9C60 VA: 0x181BBAA60
	private static bool TryFormatUInt64MoreThanBillionMaxUInt(ulong value, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBAEF0 Offset: 0x1BBA0F0 VA: 0x181BBAEF0
	private static bool TryFormatUInt64N(ulong value, byte precision, Span<byte> destination, bool insertNegationSign, out int bytesWritten) { }

	// RVA: 0x1BBB240 Offset: 0x1BBA440 VA: 0x181BBB240
	private static bool TryFormatUInt64X(ulong value, byte precision, bool useLower, Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1BBC990 Offset: 0x1BBBB90 VA: 0x181BBC990
	private static void .cctor() { }
}

// Namespace: System.Buffers.Text
internal static class ParserHelpers // TypeDefIndex: 17117
{
	// Fields
	public static readonly byte[] s_hexLookup; // 0x0

	// Methods

	// RVA: 0x17A5920 Offset: 0x17A4B20 VA: 0x1817A5920
	public static bool IsDigit(int i) { }

	// RVA: 0x1BB34D0 Offset: 0x1BB26D0 VA: 0x181BB34D0
	private static void .cctor() { }
}

// Namespace: 
[Flags]
private enum Utf8Parser.ParseNumberOptions // TypeDefIndex: 17118
{
	// Fields
	public int value__; // 0x0
	public const Utf8Parser.ParseNumberOptions AllowExponent = 1;
}

// Namespace: System.Buffers.Text
internal static class Utf8Parser // TypeDefIndex: 17119
{
	// Fields
	private static readonly int[] s_daysToMonth365; // 0x0
	private static readonly int[] s_daysToMonth366; // 0x8

	// Methods

	// RVA: 0x1BC1740 Offset: 0x1BC0940 VA: 0x181BC1740
	public static bool TryParse(ReadOnlySpan<byte> source, out bool value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC1520 Offset: 0x1BC0720 VA: 0x181BC1520
	public static bool TryParse(ReadOnlySpan<byte> source, out Decimal value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC1140 Offset: 0x1BC0340 VA: 0x181BC1140
	public static bool TryParse(ReadOnlySpan<byte> source, out float value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC1410 Offset: 0x1BC0610 VA: 0x181BC1410
	public static bool TryParse(ReadOnlySpan<byte> source, out double value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BBECD0 Offset: 0x1BBDED0 VA: 0x181BBECD0
	private static bool TryParseNormalAsFloatingPoint(ReadOnlySpan<byte> source, out double value, out int bytesConsumed, char standardFormat) { }

	// RVA: -1 Offset: -1
	private static bool TryParseAsSpecialFloatingPoint<T>(ReadOnlySpan<byte> source, T positiveInfinity, T negativeInfinity, T nan, out T value, out int bytesConsumed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0D90 Offset: 0xA9FF90 VA: 0x180AA0D90
	|-Utf8Parser.TryParseAsSpecialFloatingPoint<double>
	|
	|-RVA: 0xAA15B0 Offset: 0xAA07B0 VA: 0x180AA15B0
	|-Utf8Parser.TryParseAsSpecialFloatingPoint<float>
	|
	|-RVA: 0xAA1120 Offset: 0xAA0320 VA: 0x180AA1120
	|-Utf8Parser.TryParseAsSpecialFloatingPoint<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1BC1BC0 Offset: 0x1BC0DC0 VA: 0x181BC1BC0
	public static bool TryParse(ReadOnlySpan<byte> source, out Guid value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BBD610 Offset: 0x1BBC810 VA: 0x181BBD610
	private static bool TryParseGuidN(ReadOnlySpan<byte> text, out Guid value, out int bytesConsumed) { }

	// RVA: 0x1BBD160 Offset: 0x1BBC360 VA: 0x181BBD160
	private static bool TryParseGuidCore(ReadOnlySpan<byte> source, bool ends, char begin, char end, out Guid value, out int bytesConsumed) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC1EF0 Offset: 0x1BC10F0 VA: 0x181BC1EF0
	public static bool TryParse(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC1A40 Offset: 0x1BC0C40 VA: 0x181BC1A40
	public static bool TryParse(ReadOnlySpan<byte> source, out short value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC2200 Offset: 0x1BC1400 VA: 0x181BC2200
	public static bool TryParse(ReadOnlySpan<byte> source, out int value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BC2070 Offset: 0x1BC1270 VA: 0x181BC2070
	public static bool TryParse(ReadOnlySpan<byte> source, out long value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BBF550 Offset: 0x1BBE750 VA: 0x181BBF550
	private static bool TryParseSByteD(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed) { }

	// RVA: 0x1BBD9D0 Offset: 0x1BBCBD0 VA: 0x181BBD9D0
	private static bool TryParseInt16D(ReadOnlySpan<byte> source, out short value, out int bytesConsumed) { }

	// RVA: 0x1BBDFB0 Offset: 0x1BBD1B0 VA: 0x181BBDFB0
	private static bool TryParseInt32D(ReadOnlySpan<byte> source, out int value, out int bytesConsumed) { }

	// RVA: 0x1BBE720 Offset: 0x1BBD920 VA: 0x181BBE720
	private static bool TryParseInt64D(ReadOnlySpan<byte> source, out long value, out int bytesConsumed) { }

	// RVA: 0x1BBF800 Offset: 0x1BBEA00 VA: 0x181BBF800
	private static bool TryParseSByteN(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed) { }

	// RVA: 0x1BBDD20 Offset: 0x1BBCF20 VA: 0x181BBDD20
	private static bool TryParseInt16N(ReadOnlySpan<byte> source, out short value, out int bytesConsumed) { }

	// RVA: 0x1BBE480 Offset: 0x1BBD680 VA: 0x181BBE480
	private static bool TryParseInt32N(ReadOnlySpan<byte> source, out int value, out int bytesConsumed) { }

	// RVA: 0x1BBEA00 Offset: 0x1BBDC00 VA: 0x181BBEA00
	private static bool TryParseInt64N(ReadOnlySpan<byte> source, out long value, out int bytesConsumed) { }

	// RVA: 0x1BC1D70 Offset: 0x1BC0F70 VA: 0x181BC1D70
	public static bool TryParse(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed, char standardFormat = '\x0') { }

	[CLSCompliant(False)]
	// RVA: 0x1BC1290 Offset: 0x1BC0490 VA: 0x181BC1290
	public static bool TryParse(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed, char standardFormat = '\x0') { }

	[CLSCompliant(False)]
	// RVA: 0x1BC2500 Offset: 0x1BC1700 VA: 0x181BC2500
	public static bool TryParse(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed, char standardFormat = '\x0') { }

	[CLSCompliant(False)]
	// RVA: 0x1BC2380 Offset: 0x1BC1580 VA: 0x181BC2380
	public static bool TryParse(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed, char standardFormat = '\x0') { }

	// RVA: 0x1BBCAE0 Offset: 0x1BBBCE0 VA: 0x181BBCAE0
	private static bool TryParseByteD(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed) { }

	// RVA: 0x1BBFA90 Offset: 0x1BBEC90 VA: 0x181BBFA90
	private static bool TryParseUInt16D(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed) { }

	// RVA: 0x1BC01D0 Offset: 0x1BBF3D0 VA: 0x181BC01D0
	private static bool TryParseUInt32D(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed) { }

	// RVA: 0x1BC0AA0 Offset: 0x1BBFCA0 VA: 0x181BC0AA0
	private static bool TryParseUInt64D(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed) { }

	// RVA: 0x1BBCD00 Offset: 0x1BBBF00 VA: 0x181BBCD00
	private static bool TryParseByteN(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed) { }

	// RVA: 0x1BBFD60 Offset: 0x1BBEF60 VA: 0x181BBFD60
	private static bool TryParseUInt16N(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed) { }

	// RVA: 0x1BC0610 Offset: 0x1BBF810 VA: 0x181BC0610
	private static bool TryParseUInt32N(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed) { }

	// RVA: 0x1BC0C80 Offset: 0x1BBFE80 VA: 0x181BC0C80
	private static bool TryParseUInt64N(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed) { }

	// RVA: 0x1BBCF40 Offset: 0x1BBC140 VA: 0x181BBCF40
	private static bool TryParseByteX(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed) { }

	// RVA: 0x1BBFFA0 Offset: 0x1BBF1A0 VA: 0x181BBFFA0
	private static bool TryParseUInt16X(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed) { }

	// RVA: 0x1BC0870 Offset: 0x1BBFA70 VA: 0x181BC0870
	private static bool TryParseUInt32X(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed) { }

	// RVA: 0x1BC0F00 Offset: 0x1BC0100 VA: 0x181BC0F00
	private static bool TryParseUInt64X(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed) { }

	// RVA: 0x1BBEF60 Offset: 0x1BBE160 VA: 0x181BBEF60
	private static bool TryParseNumber(ReadOnlySpan<byte> source, ref NumberBuffer number, out int bytesConsumed, Utf8Parser.ParseNumberOptions options, out bool textUsedExponentNotation) { }

	// RVA: 0x1BC2680 Offset: 0x1BC1880 VA: 0x181BC2680
	private static void .cctor() { }
}

// Namespace: System.Buffers.Binary
internal static class BinaryPrimitives // TypeDefIndex: 17120
{
	// Methods

	[CLSCompliant(False)]
	// RVA: 0x172DF90 Offset: 0x172D190 VA: 0x18172DF90
	public static uint ReverseEndianness(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BB0390 Offset: 0x1BAF590 VA: 0x181BB0390
	public static uint ReadUInt32LittleEndian(ReadOnlySpan<byte> source) { }

	[CLSCompliant(False)]
	// RVA: 0x1BB0510 Offset: 0x1BAF710 VA: 0x181BB0510
	public static void WriteUInt32BigEndian(Span<byte> destination, uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BB04A0 Offset: 0x1BAF6A0 VA: 0x181BB04A0
	public static bool TryWriteUInt32BigEndian(Span<byte> destination, uint value) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15 // TypeDefIndex: 17121
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 17122
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 // TypeDefIndex: 17123
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 17124
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 17125
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 17126
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 // TypeDefIndex: 17127
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 17128
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=336 // TypeDefIndex: 17129
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 17130
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 0953DF544832295E4A5B19928F95C351F25DA86A /*Metadata offset 0x8FCB30*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 1588174EA926BCCEB6275C029A42C7E3DBA4D523 /*Metadata offset 0x8FCB78*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=336 2B2055E39CBB1C111FB5C1C05492B3E5AAC607ED /*Metadata offset 0x8FCC80*/; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 3CDA7449B0586AB873C75C04BB11D4864F5D7392 /*Metadata offset 0x8FCDD8*/; // 0x290
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 608454F961E288A48E34666C94032BEDEFD399E1 /*Metadata offset 0x8FCEE0*/; // 0x390
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 B8B960BE929E7BAB90AE2CAEF2468C56CD5414C1 /*Metadata offset 0x8FCFD8*/; // 0x480
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 BD20BFA840DDF83194ECD4397DA071ECD4C1C72F /*Metadata offset 0x8FD010*/; // 0x4B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15 C3FB1115E83603E7E71244A6F2D43E22B790B5D1 /*Metadata offset 0x8FD030*/; // 0x4CC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 C4C38BC485A320D4B7D737DB85E705077FA38BEF /*Metadata offset 0x8FD040*/; // 0x4DB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 DB5930245CE35BDE5EDC35035275D8DD55E139CF /*Metadata offset 0x8FD078*/; // 0x50B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x8FD0A8*/; // 0x535
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x8FD0E0*/; // 0x569
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 EE0B1C00D481FCA3559F2937C3DD3127C35B2FE3 /*Metadata offset 0x8FD118*/; // 0x59D
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17131
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 17132
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ArrayUtility.<>c__23<T> // TypeDefIndex: 17133
{
	// Fields
	public static readonly ArrayUtility.<>c__23<T> <>9; // 0x0
	public static Func<T, string> <>9__23_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ArrayUtility.<>c__23<int>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ArrayUtility.<>c__23<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ArrayUtility.<>c__23<int>..ctor
	|-ArrayUtility.<>c__23<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal string <ToString>b__23_0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB088E0 Offset: 0xB07AE0 VA: 0x180B088E0
	|-ArrayUtility.<>c__23<int>.<ToString>b__23_0
	|
	|-RVA: 0xB087F0 Offset: 0xB079F0 VA: 0x180B087F0
	|-ArrayUtility.<>c__23<__Il2CppFullySharedGenericType>.<ToString>b__23_0
	*/
}

// Namespace: UnityEngine.ProBuilder
[Extension]
internal static class ArrayUtility // TypeDefIndex: 17134
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] arr, T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x939860 Offset: 0x938A60 VA: 0x180939860
	|-ArrayUtility.Add<int>
	|
	|-RVA: 0x939910 Offset: 0x938B10 VA: 0x180939910
	|-ArrayUtility.Add<object>
	|
	|-RVA: 0x939710 Offset: 0x938910 VA: 0x180939710
	|-ArrayUtility.Add<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x939D00 Offset: 0x938F00 VA: 0x180939D00
	|-ArrayUtility.RemoveAt<int>
	|
	|-RVA: 0x939BA0 Offset: 0x938DA0 VA: 0x180939BA0
	|-ArrayUtility.RemoveAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] Fill<T>(T val, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9399D0 Offset: 0x938BD0 VA: 0x1809399D0
	|-ArrayUtility.Fill<Color>
	|
	|-RVA: 0x939A60 Offset: 0x938C60 VA: 0x180939A60
	|-ArrayUtility.Fill<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static string ToString<T>(IEnumerable<T> arr, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0x939F70 Offset: 0x939170 VA: 0x180939F70
	|-ArrayUtility.ToString<int>
	|
	|-RVA: 0x939DC0 Offset: 0x938FC0 VA: 0x180939DC0
	|-ArrayUtility.ToString<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public enum AutoUnwrapSettings.Anchor // TypeDefIndex: 17135
{
	// Fields
	public int value__; // 0x0
	public const AutoUnwrapSettings.Anchor UpperLeft = 0;
	public const AutoUnwrapSettings.Anchor UpperCenter = 1;
	public const AutoUnwrapSettings.Anchor UpperRight = 2;
	public const AutoUnwrapSettings.Anchor MiddleLeft = 3;
	public const AutoUnwrapSettings.Anchor MiddleCenter = 4;
	public const AutoUnwrapSettings.Anchor MiddleRight = 5;
	public const AutoUnwrapSettings.Anchor LowerLeft = 6;
	public const AutoUnwrapSettings.Anchor LowerCenter = 7;
	public const AutoUnwrapSettings.Anchor LowerRight = 8;
	public const AutoUnwrapSettings.Anchor None = 9;
}

// Namespace: 
public enum AutoUnwrapSettings.Fill // TypeDefIndex: 17136
{
	// Fields
	public int value__; // 0x0
	public const AutoUnwrapSettings.Fill Fit = 0;
	public const AutoUnwrapSettings.Fill Tile = 1;
	public const AutoUnwrapSettings.Fill Stretch = 2;
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct AutoUnwrapSettings // TypeDefIndex: 17137
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("useWorldSpace")]
	private bool m_UseWorldSpace; // 0x0
	[SerializeField]
	[FormerlySerializedAs("flipU")]
	private bool m_FlipU; // 0x1
	[SerializeField]
	[FormerlySerializedAs("flipV")]
	private bool m_FlipV; // 0x2
	[FormerlySerializedAs("swapUV")]
	[SerializeField]
	private bool m_SwapUV; // 0x3
	[SerializeField]
	[FormerlySerializedAs("fill")]
	private AutoUnwrapSettings.Fill m_Fill; // 0x4
	[SerializeField]
	[FormerlySerializedAs("scale")]
	private Vector2 m_Scale; // 0x8
	[SerializeField]
	[FormerlySerializedAs("offset")]
	private Vector2 m_Offset; // 0x10
	[SerializeField]
	[FormerlySerializedAs("rotation")]
	private float m_Rotation; // 0x18
	[SerializeField]
	[FormerlySerializedAs("anchor")]
	private AutoUnwrapSettings.Anchor m_Anchor; // 0x1C

	// Properties
	public bool useWorldSpace { get; }
	public bool flipU { get; }
	public bool flipV { get; }
	public bool swapUV { get; }
	public AutoUnwrapSettings.Fill fill { get; }
	public Vector2 scale { get; }
	public Vector2 offset { get; set; }
	public float rotation { get; }
	public AutoUnwrapSettings.Anchor anchor { get; }
	public static AutoUnwrapSettings tile { get; }

	// Methods

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_useWorldSpace() { }

	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public bool get_flipU() { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	public bool get_flipV() { }

	// RVA: 0x19836E0 Offset: 0x19828E0 VA: 0x1819836E0
	public bool get_swapUV() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public AutoUnwrapSettings.Fill get_fill() { }

	// RVA: 0x18CA6B0 Offset: 0x18C98B0 VA: 0x1818CA6B0
	public Vector2 get_scale() { }

	// RVA: 0x11116F0 Offset: 0x11108F0 VA: 0x1811116F0
	public Vector2 get_offset() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_offset(Vector2 value) { }

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_rotation() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public AutoUnwrapSettings.Anchor get_anchor() { }

	// RVA: 0x2365440 Offset: 0x2364640 VA: 0x182365440
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x2365480 Offset: 0x2364680 VA: 0x182365480
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x23650A0 Offset: 0x23642A0 VA: 0x1823650A0
	public void Reset() { }

	// RVA: 0x23650D0 Offset: 0x23642D0 VA: 0x1823650D0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal sealed class Bounds2D // TypeDefIndex: 17138
{
	// Fields
	public Vector2 center; // 0x10
	[SerializeField]
	private Vector2 m_Size; // 0x18
	[SerializeField]
	private Vector2 m_Extents; // 0x20

	// Properties
	public Vector2 size { get; }

	// Methods

	// RVA: 0x12B30A0 Offset: 0x12B22A0 VA: 0x1812B30A0
	public Vector2 get_size() { }

	// RVA: 0x2366490 Offset: 0x2365690 VA: 0x182366490
	public void .ctor(IList<Vector2> points) { }

	// RVA: 0x2366390 Offset: 0x2365590 VA: 0x182366390
	public void .ctor(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x2365AF0 Offset: 0x2364CF0 VA: 0x182365AF0
	public void SetWithPoints(IList<Vector2> points) { }

	// RVA: 0x2365DC0 Offset: 0x2364FC0 VA: 0x182365DC0
	public void SetWithPoints(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x23654B0 Offset: 0x23646B0 VA: 0x1823654B0
	public static Vector2 Center(IList<Vector2> points) { }

	// RVA: 0x2365730 Offset: 0x2364930 VA: 0x182365730
	public static Vector2 Center(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x2366270 Offset: 0x2365470 VA: 0x182366270 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct Edge : IEquatable<Edge> // TypeDefIndex: 17139
{
	// Fields
	public int a; // 0x0
	public int b; // 0x4
	public static readonly Edge Empty; // 0x0

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int a, int b) { }

	// RVA: 0x2366760 Offset: 0x2365960 VA: 0x182366760 Slot: 3
	public override string ToString() { }

	// RVA: 0x2366630 Offset: 0x2365830 VA: 0x182366630 Slot: 4
	public bool Equals(Edge other) { }

	// RVA: 0x2366660 Offset: 0x2365860 VA: 0x182366660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2366730 Offset: 0x2365930 VA: 0x182366730 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2366850 Offset: 0x2365A50 VA: 0x182366850
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
internal static class EdgeUtility // TypeDefIndex: 17140
{
	// Methods

	[Extension]
	// RVA: 0x2366580 Offset: 0x2365780 VA: 0x182366580
	internal static int[] AllTriangles(Edge[] edges) { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
[Serializable]
public sealed class Face // TypeDefIndex: 17141
{
	// Fields
	[FormerlySerializedAs("_indices")]
	[SerializeField]
	private int[] m_Indexes; // 0x10
	[SerializeField]
	[FormerlySerializedAs("_smoothingGroup")]
	private int m_SmoothingGroup; // 0x18
	[SerializeField]
	[FormerlySerializedAs("_uv")]
	private AutoUnwrapSettings m_Uv; // 0x1C
	[SerializeField]
	[FormerlySerializedAs("_mat")]
	private Material m_Material; // 0x40
	[SerializeField]
	private int m_SubmeshIndex; // 0x48
	[SerializeField]
	[FormerlySerializedAs("manualUV")]
	private bool m_ManualUV; // 0x4C
	[SerializeField]
	internal int elementGroup; // 0x50
	[SerializeField]
	private int m_TextureGroup; // 0x54
	private int[] m_DistinctIndexes; // 0x58
	private Edge[] m_Edges; // 0x60

	// Properties
	public bool manualUV { get; set; }
	public int textureGroup { get; set; }
	internal int[] indexesInternal { get; }
	internal int[] distinctIndexesInternal { get; }
	public ReadOnlyCollection<int> distinctIndexes { get; }
	internal Edge[] edgesInternal { get; }
	public ReadOnlyCollection<Edge> edges { get; }
	public int smoothingGroup { get; }
	[Obsolete("Face.material is deprecated. Please use submeshIndex instead.")]
	public Material material { get; set; }
	public int submeshIndex { get; set; }
	public AutoUnwrapSettings uv { get; set; }

	// Methods

	// RVA: 0x4EDA10 Offset: 0x4ECC10 VA: 0x1804EDA10
	public bool get_manualUV() { }

	// RVA: 0x4EDDB0 Offset: 0x4ECFB0 VA: 0x1804EDDB0
	public void set_manualUV(bool value) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_textureGroup() { }

	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_textureGroup(int value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal int[] get_indexesInternal() { }

	// RVA: 0x2366E50 Offset: 0x2366050 VA: 0x182366E50
	public void SetIndexes(IEnumerable<int> indices) { }

	// RVA: 0x2367960 Offset: 0x2366B60 VA: 0x182367960
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x23679F0 Offset: 0x2366BF0 VA: 0x1823679F0
	public ReadOnlyCollection<int> get_distinctIndexes() { }

	// RVA: 0x2367A70 Offset: 0x2366C70 VA: 0x182367A70
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x2367A90 Offset: 0x2366C90 VA: 0x182367A90
	public ReadOnlyCollection<Edge> get_edges() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_smoothingGroup() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Material get_material() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_material(Material value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public int get_submeshIndex() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_submeshIndex(int value) { }

	// RVA: 0x2367B10 Offset: 0x2366D10 VA: 0x182367B10
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x2367B30 Offset: 0x2366D30 VA: 0x182367B30
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x2367540 Offset: 0x2366740 VA: 0x182367540
	public void .ctor() { }

	// RVA: 0x2367560 Offset: 0x2366760 VA: 0x182367560
	internal void .ctor(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x2367790 Offset: 0x2366990 VA: 0x182367790
	public void .ctor(Face other) { }

	// RVA: 0x2366C10 Offset: 0x2365E10 VA: 0x182366C10
	public void CopyFrom(Face other) { }

	// RVA: 0x2366DE0 Offset: 0x2365FE0 VA: 0x182366DE0
	internal void InvalidateCache() { }

	// RVA: 0x2366920 Offset: 0x2365B20 VA: 0x182366920
	private Edge[] CacheEdges() { }

	// RVA: 0x23668A0 Offset: 0x2365AA0 VA: 0x1823668A0
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x2366DF0 Offset: 0x2365FF0 VA: 0x182366DF0
	public bool IsQuad() { }

	// RVA: 0x2366F70 Offset: 0x2366170 VA: 0x182366F70
	public int[] ToQuad() { }

	// RVA: 0x2367370 Offset: 0x2366570 VA: 0x182367370 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3 : IEquatable<IntVec3> // TypeDefIndex: 17142
{
	// Fields
	public Vector3 value; // 0x0

	// Properties
	public float x { get; }
	public float y { get; }
	public float z { get; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_x() { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_y() { }

	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_z() { }

	// RVA: 0xAA0CC0 Offset: 0xA9FEC0 VA: 0x180AA0CC0
	public void .ctor(Vector3 vector) { }

	// RVA: 0x2367EA0 Offset: 0x23670A0 VA: 0x182367EA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2367C70 Offset: 0x2366E70 VA: 0x182367C70 Slot: 4
	public bool Equals(IntVec3 p) { }

	// RVA: 0x2367C70 Offset: 0x2366E70 VA: 0x182367C70
	public bool Equals(Vector3 p) { }

	// RVA: 0x2367B40 Offset: 0x2366D40 VA: 0x182367B40 Slot: 0
	public override bool Equals(object b) { }

	// RVA: 0x2367E70 Offset: 0x2367070 VA: 0x182367E70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2367F60 Offset: 0x2367160 VA: 0x182367F60
	private static int round(float v) { }

	// RVA: 0xAA0C00 Offset: 0xA9FE00 VA: 0x180AA0C00
	public static IntVec3 op_Implicit(Vector3 p) { }
}

// Namespace: UnityEngine.ProBuilder
[Flags]
internal enum LogLevel // TypeDefIndex: 17143
{
	// Fields
	public int value__; // 0x0
	public const LogLevel None = 0;
	public const LogLevel Error = 1;
	public const LogLevel Warning = 2;
	public const LogLevel Info = 4;
	public const LogLevel Default = 3;
	public const LogLevel All = 255;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
internal enum LogOutput // TypeDefIndex: 17144
{
	// Fields
	public int value__; // 0x0
	public const LogOutput None = 0;
	public const LogOutput Console = 1;
	public const LogOutput File = 2;
}

// Namespace: UnityEngine.ProBuilder
internal static class Log // TypeDefIndex: 17145
{
	// Fields
	private static Stack<LogLevel> s_logStack; // 0x0
	private static LogLevel s_LogLevel; // 0x8
	private static LogOutput s_Output; // 0xC
	private static string s_LogFilePath; // 0x10

	// Methods

	// RVA: 0x2368410 Offset: 0x2367610 VA: 0x182368410
	public static void Warning(string message) { }

	// RVA: 0x2367FC0 Offset: 0x23671C0 VA: 0x182367FC0
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x2368160 Offset: 0x2367360 VA: 0x182368160
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x23680A0 Offset: 0x23672A0 VA: 0x1823680A0
	private static void PrintToConsole(string message, LogType type = 3) { }

	// RVA: 0x2368580 Offset: 0x2367780 VA: 0x182368580
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility // TypeDefIndex: 17146
{
	// Fields
	internal static List<Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x2368640 Offset: 0x2367840 VA: 0x182368640
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x2368720 Offset: 0x2367920 VA: 0x182368720
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class Math // TypeDefIndex: 17147
{
	// Methods

	[Extension]
	// RVA: 0x2368F90 Offset: 0x2368190 VA: 0x182368F90
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	[Extension]
	// RVA: 0x2369040 Offset: 0x2368240 VA: 0x182369040
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x2368DE0 Offset: 0x2367FE0 VA: 0x182368DE0
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x2368B90 Offset: 0x2367D90 VA: 0x182368B90
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	[Extension]
	// RVA: 0x849FB0 Offset: 0x8491B0 VA: 0x180849FB0
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	// RVA: 0x2369090 Offset: 0x2368290 VA: 0x182369090
	internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes) { }

	// RVA: 0x2368990 Offset: 0x2367B90 VA: 0x182368990
	internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes) { }

	[Extension]
	// RVA: 0x2368790 Offset: 0x2367990 VA: 0x182368790
	internal static bool Approx2(Vector2 a, Vector2 b, float delta = 0,0001) { }

	[Extension]
	// RVA: 0x23687E0 Offset: 0x23679E0 VA: 0x1823687E0
	internal static bool Approx3(Vector3 a, Vector3 b, float delta = 0,0001) { }

	[Extension]
	// RVA: 0x2368830 Offset: 0x2367A30 VA: 0x182368830
	internal static bool Approx4(Vector4 a, Vector4 b, float delta = 0,0001) { }

	[Extension]
	// RVA: 0x2368830 Offset: 0x2367A30 VA: 0x182368830
	internal static bool ApproxC(Color a, Color b, float delta = 0,0001) { }

	[Extension]
	// RVA: 0x2368890 Offset: 0x2367A90 VA: 0x182368890
	internal static bool Approx(float a, float b, float delta = 0,0001) { }

	// RVA: 0x23688B0 Offset: 0x2367AB0 VA: 0x1823688B0
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x23688D0 Offset: 0x2367AD0 VA: 0x1823688D0
	internal static Vector3 EnsureUnitVector(Vector3 value) { }
}

// Namespace: UnityEngine.ProBuilder
[Extension]
public static class MeshUtility // TypeDefIndex: 17148
{
	// Methods

	// RVA: 0x2369290 Offset: 0x2368490 VA: 0x182369290
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x2369380 Offset: 0x2368580 VA: 0x182369380
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }
}

// Namespace: UnityEngine.ProBuilder
public static class Normals // TypeDefIndex: 17149
{
	// Fields
	private static Vector3[] s_SmoothAvg; // 0x0
	private static float[] s_SmoothAvgCount; // 0x8
	private static int[] s_CachedIntArray; // 0x10

	// Methods

	// RVA: 0x236AC70 Offset: 0x2369E70 VA: 0x18236AC70
	private static void ClearIntArray(int count) { }

	// RVA: 0x236A340 Offset: 0x2369540 VA: 0x18236A340
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x2369480 Offset: 0x2368680 VA: 0x182369480
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x2369B30 Offset: 0x2368D30 VA: 0x182369B30
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x236ADA0 Offset: 0x2369FA0 VA: 0x18236ADA0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
public enum ProjectionAxis // TypeDefIndex: 17150
{
	// Fields
	public int value__; // 0x0
	public const ProjectionAxis X = 0;
	public const ProjectionAxis Y = 1;
	public const ProjectionAxis Z = 2;
	public const ProjectionAxis XNegative = 3;
	public const ProjectionAxis YNegative = 4;
	public const ProjectionAxis ZNegative = 5;
}

// Namespace: UnityEngine.ProBuilder
public enum MeshSyncState // TypeDefIndex: 17151
{
	// Fields
	public int value__; // 0x0
	public const MeshSyncState Null = 0;
	[Obsolete("InstanceIDMismatch is no longer used. Mesh references are not tracked by Instance ID.")]
	public const MeshSyncState InstanceIDMismatch = 1;
	public const MeshSyncState Lightmap = 2;
	public const MeshSyncState InSync = 3;
	public const MeshSyncState NeedsRebuild = 4;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum MeshArrays // TypeDefIndex: 17152
{
	// Fields
	public int value__; // 0x0
	public const MeshArrays Position = 1;
	public const MeshArrays Texture0 = 2;
	public const MeshArrays Texture1 = 4;
	public const MeshArrays Lightmap = 4;
	public const MeshArrays Texture2 = 8;
	public const MeshArrays Texture3 = 16;
	public const MeshArrays Color = 32;
	public const MeshArrays Normal = 64;
	public const MeshArrays Tangent = 128;
	public const MeshArrays All = 255;
}

// Namespace: UnityEngine.ProBuilder
[Flags]
public enum RefreshMask // TypeDefIndex: 17153
{
	// Fields
	public int value__; // 0x0
	public const RefreshMask UV = 1;
	public const RefreshMask Colors = 2;
	public const RefreshMask Normals = 4;
	public const RefreshMask Tangents = 8;
	public const RefreshMask Collisions = 16;
	public const RefreshMask Bounds = 22;
	public const RefreshMask All = 31;
}

// Namespace: 
[Flags]
private enum ProBuilderMesh.CacheValidState // TypeDefIndex: 17154
{
	// Fields
	public byte value__; // 0x0
	public const ProBuilderMesh.CacheValidState SharedVertex = 1;
	public const ProBuilderMesh.CacheValidState SharedTexture = 2;
}

// Namespace: 
internal struct ProBuilderMesh.NonVersionedEditScope : IDisposable // TypeDefIndex: 17155
{
	// Fields
	private readonly ProBuilderMesh m_Mesh; // 0x0
	private readonly ushort m_VersionIndex; // 0x8
	private readonly ushort m_InstanceVersionIndex; // 0xA

	// Methods

	// RVA: 0x2369450 Offset: 0x2368650 VA: 0x182369450
	public void .ctor(ProBuilderMesh mesh) { }

	// RVA: 0x2369410 Offset: 0x2368610 VA: 0x182369410 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProBuilderMesh.<>c // TypeDefIndex: 17156
{
	// Fields
	public static readonly ProBuilderMesh.<>c <>9; // 0x0
	public static Func<Vector4, Vector2> <>9__118_0; // 0x8
	public static Func<Vector4, Vector2> <>9__118_1; // 0x10
	public static Func<Face, int> <>9__126_0; // 0x18
	public static Func<Face, int> <>9__128_0; // 0x20
	public static Func<Face, Face> <>9__171_0; // 0x28

	// Methods

	// RVA: 0x2379010 Offset: 0x2378210 VA: 0x182379010
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2378F90 Offset: 0x2378190 VA: 0x182378F90
	internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

	// RVA: 0x2378F90 Offset: 0x2378190 VA: 0x182378F90
	internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	// RVA: 0x2378FB0 Offset: 0x23781B0 VA: 0x182378FB0
	internal int <get_indexCount>b__126_0(Face x) { }

	// RVA: 0x2378FB0 Offset: 0x23781B0 VA: 0x182378FB0
	internal int <get_triangleCount>b__128_0(Face x) { }

	// RVA: 0x2378D90 Offset: 0x2377F90 VA: 0x182378D90
	internal Face <CopyFrom>b__171_0(Face x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProBuilderMesh.<>c__DisplayClass174_0 // TypeDefIndex: 17157
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2378FD0 Offset: 0x23781D0 VA: 0x182378FD0
	internal bool <GetUnusedTextureGroup>b__0(Face element) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProBuilderMesh.<>c__DisplayClass176_0 // TypeDefIndex: 17158
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2378FF0 Offset: 0x23781F0 VA: 0x182378FF0
	internal bool <UnusedElementGroup>b__0(Face element) { }
}

// Namespace: UnityEngine.ProBuilder
[AddComponentMenu("//ProBuilder MeshFilter")]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public sealed class ProBuilderMesh : MonoBehaviour // TypeDefIndex: 17159
{
	// Fields
	internal const HideFlags k_MeshFilterHideFlags = 10;
	private const int k_UVChannelCount = 4;
	internal const int k_MeshFormatVersion = 2;
	internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;
	internal const int k_MeshFormatVersionAutoUVScaleOffset = 2;
	public const uint maxVertexCount = 65535;
	[SerializeField]
	private int m_MeshFormatVersion; // 0x20
	[FormerlySerializedAs("_quads")]
	[SerializeField]
	private Face[] m_Faces; // 0x28
	[SerializeField]
	[FormerlySerializedAs("_sharedIndices")]
	[FormerlySerializedAs("m_SharedVertexes")]
	private SharedVertex[] m_SharedVertices; // 0x30
	private ProBuilderMesh.CacheValidState m_CacheValid; // 0x38
	private Dictionary<int, int> m_SharedVertexLookup; // 0x40
	[FormerlySerializedAs("_sharedIndicesUV")]
	[SerializeField]
	private SharedVertex[] m_SharedTextures; // 0x48
	private Dictionary<int, int> m_SharedTextureLookup; // 0x50
	[SerializeField]
	[FormerlySerializedAs("_vertices")]
	private Vector3[] m_Positions; // 0x58
	[SerializeField]
	[FormerlySerializedAs("_uv")]
	private Vector2[] m_Textures0; // 0x60
	[FormerlySerializedAs("_uv3")]
	[SerializeField]
	private List<Vector4> m_Textures2; // 0x68
	[SerializeField]
	[FormerlySerializedAs("_uv4")]
	private List<Vector4> m_Textures3; // 0x70
	[FormerlySerializedAs("_tangents")]
	[SerializeField]
	private Vector4[] m_Tangents; // 0x78
	private Vector3[] m_Normals; // 0x80
	[FormerlySerializedAs("_colors")]
	[SerializeField]
	private Color[] m_Colors; // 0x88
	[CompilerGenerated]
	private bool <userCollisions>k__BackingField; // 0x90
	[FormerlySerializedAs("unwrapParameters")]
	[SerializeField]
	private UnwrapParameters m_UnwrapParameters; // 0x98
	[SerializeField]
	[FormerlySerializedAs("dontDestroyMeshOnDelete")]
	private bool m_PreserveMeshAssetOnDestroy; // 0xA0
	[SerializeField]
	internal string assetGuid; // 0xA8
	[SerializeField]
	private Mesh m_Mesh; // 0xB0
	private MeshRenderer m_MeshRenderer; // 0xB8
	private MeshFilter m_MeshFilter; // 0xC0
	internal const ushort k_UnitializedVersionIndex = 0;
	[SerializeField]
	private ushort m_VersionIndex; // 0xC8
	private ushort m_InstanceVersionIndex; // 0xCA
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWillBeDestroyed; // 0x0
	[CompilerGenerated]
	private static Action<ProBuilderMesh> meshWasInitialized; // 0x8
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentWillBeDestroyed; // 0x10
	[CompilerGenerated]
	private static Action<ProBuilderMesh> componentHasBeenReset; // 0x18
	[CompilerGenerated]
	private static Action<ProBuilderMesh> elementSelectionChanged; // 0x20
	private static HashSet<int> s_CachedHashSet; // 0x28
	[SerializeField]
	private bool m_IsSelectable; // 0xCC
	[SerializeField]
	private int[] m_SelectedFaces; // 0xD0
	[SerializeField]
	private Edge[] m_SelectedEdges; // 0xD8
	[SerializeField]
	private int[] m_SelectedVertices; // 0xE0
	private bool m_SelectedCacheDirty; // 0xE8
	private int m_SelectedSharedVerticesCount; // 0xEC
	private int m_SelectedCoincidentVertexCount; // 0xF0
	private HashSet<int> m_SelectedSharedVertices; // 0xF8
	private List<int> m_SelectedCoincidentVertices; // 0x100

	// Properties
	public bool userCollisions { get; set; }
	public UnwrapParameters unwrapParameters { get; set; }
	internal MeshRenderer renderer { get; }
	internal MeshFilter filter { get; }
	internal ushort versionIndex { get; }
	internal ushort nonSerializedVersionIndex { get; }
	public bool preserveMeshAssetOnDestroy { get; set; }
	internal Face[] facesInternal { get; set; }
	public IList<Face> faces { get; set; }
	internal SharedVertex[] sharedVerticesInternal { get; set; }
	public IList<SharedVertex> sharedVertices { get; set; }
	internal Dictionary<int, int> sharedVertexLookup { get; }
	internal SharedVertex[] sharedTextures { get; set; }
	internal Dictionary<int, int> sharedTextureLookup { get; }
	internal Vector3[] positionsInternal { get; set; }
	public IList<Vector3> positions { get; set; }
	public IList<Vector3> normals { get; }
	internal Vector3[] normalsInternal { get; set; }
	internal Color[] colorsInternal { get; set; }
	public IList<Color> colors { get; set; }
	public IList<Vector4> tangents { get; set; }
	internal Vector4[] tangentsInternal { get; set; }
	internal Vector2[] texturesInternal { get; set; }
	internal List<Vector4> textures2Internal { get; set; }
	internal List<Vector4> textures3Internal { get; set; }
	public IList<Vector2> textures { get; set; }
	public int faceCount { get; }
	public int vertexCount { get; }
	public int edgeCount { get; }
	public int indexCount { get; }
	public int triangleCount { get; }
	internal Mesh mesh { get; set; }
	[Obsolete("InstanceID is not used to track mesh references as of 2023/04/12")]
	internal int id { get; }
	public MeshSyncState meshSyncState { get; }
	internal int meshFormatVersion { get; }
	public bool selectable { get; set; }
	public int selectedFaceCount { get; }
	public int selectedVertexCount { get; }
	public int selectedEdgeCount { get; }
	internal int selectedSharedVerticesCount { get; }
	internal int selectedCoincidentVertexCount { get; }
	internal IEnumerable<int> selectedSharedVertices { get; }
	internal IEnumerable<int> selectedCoincidentVertices { get; }
	public ReadOnlyCollection<int> selectedFaceIndexes { get; }
	public ReadOnlyCollection<int> selectedVertices { get; }
	public ReadOnlyCollection<Edge> selectedEdges { get; }
	internal Face[] selectedFacesInternal { get; set; }
	internal int[] selectedFaceIndicesInternal { get; set; }
	internal Edge[] selectedEdgesInternal { get; set; }
	internal int[] selectedIndexesInternal { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	public bool get_userCollisions() { }

	[CompilerGenerated]
	// RVA: 0x834530 Offset: 0x833730 VA: 0x180834530
	public void set_userCollisions(bool value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x2374320 Offset: 0x2373520 VA: 0x182374320
	internal MeshRenderer get_renderer() { }

	// RVA: 0x2373E90 Offset: 0x2373090 VA: 0x182373E90
	internal MeshFilter get_filter() { }

	// RVA: 0x23749A0 Offset: 0x2373BA0 VA: 0x1823749A0
	internal ushort get_versionIndex() { }

	// RVA: 0x2374220 Offset: 0x2373420 VA: 0x182374220
	internal ushort get_nonSerializedVersionIndex() { }

	// RVA: 0x1200DC0 Offset: 0x11FFFC0 VA: 0x181200DC0
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x1200DD0 Offset: 0x11FFFD0 VA: 0x181200DD0
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x236F9D0 Offset: 0x236EBD0 VA: 0x18236F9D0
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal Face[] get_facesInternal() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x2373E20 Offset: 0x2373020 VA: 0x182373E20
	public IList<Face> get_faces() { }

	// RVA: 0x2375030 Offset: 0x2374230 VA: 0x182375030
	public void set_faces(IList<Face> value) { }

	// RVA: 0x236FEA0 Offset: 0x236F0A0 VA: 0x18236FEA0
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x236FE00 Offset: 0x236F000 VA: 0x18236FE00
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x236FC10 Offset: 0x236EE10 VA: 0x18236FC10
	internal void InvalidateFaces() { }

	// RVA: 0x236FBD0 Offset: 0x236EDD0 VA: 0x18236FBD0
	internal void InvalidateCaches() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x23752E0 Offset: 0x23744E0 VA: 0x1823752E0
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x23746F0 Offset: 0x23738F0 VA: 0x1823746F0
	public IList<SharedVertex> get_sharedVertices() { }

	// RVA: 0x2375380 Offset: 0x2374580 VA: 0x182375380
	public void set_sharedVertices(IList<SharedVertex> value) { }

	// RVA: 0x2374660 Offset: 0x2373860 VA: 0x182374660
	internal Dictionary<int, int> get_sharedVertexLookup() { }

	// RVA: 0x2371FD0 Offset: 0x23711D0 VA: 0x182371FD0
	internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x2375240 Offset: 0x2374440 VA: 0x182375240
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x23745D0 Offset: 0x23737D0 VA: 0x1823745D0
	internal Dictionary<int, int> get_sharedTextureLookup() { }

	// RVA: 0x2371ED0 Offset: 0x23710D0 VA: 0x182371ED0
	internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x23742B0 Offset: 0x23734B0 VA: 0x1823742B0
	public IList<Vector3> get_positions() { }

	// RVA: 0x23750D0 Offset: 0x23742D0 VA: 0x1823750D0
	public void set_positions(IList<Vector3> value) { }

	// RVA: 0x236F2B0 Offset: 0x236E4B0 VA: 0x18236F2B0
	public Vertex[] GetVertices(IList<int> indexes) { }

	// RVA: 0x236EAC0 Offset: 0x236DCC0 VA: 0x18236EAC0
	internal void GetVerticesInList(IList<Vertex> vertices) { }

	// RVA: 0x2372570 Offset: 0x2371770 VA: 0x182372570
	public void SetVertices(IList<Vertex> vertices, bool applyMesh = False) { }

	// RVA: 0x2374230 Offset: 0x2373430 VA: 0x182374230
	public IList<Vector3> get_normals() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x236DE10 Offset: 0x236D010 VA: 0x18236DE10
	public Vector3[] GetNormals() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	internal Color[] get_colorsInternal() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x2373CD0 Offset: 0x2372ED0 VA: 0x182373CD0
	public IList<Color> get_colors() { }

	// RVA: 0x2374F20 Offset: 0x2374120 VA: 0x182374F20
	public void set_colors(IList<Color> value) { }

	// RVA: 0x236DD30 Offset: 0x236CF30 VA: 0x18236DD30
	public Color[] GetColors() { }

	// RVA: 0x2374760 Offset: 0x2373960 VA: 0x182374760
	public IList<Vector4> get_tangents() { }

	// RVA: 0x23756A0 Offset: 0x23748A0 VA: 0x1823756A0
	public void set_tangents(IList<Vector4> value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x236E400 Offset: 0x236D600 VA: 0x18236E400
	public Vector4[] GetTangents() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal List<Vector4> get_textures2Internal() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	internal void set_textures2Internal(List<Vector4> value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal List<Vector4> get_textures3Internal() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_textures3Internal(List<Vector4> value) { }

	// RVA: 0x2374800 Offset: 0x2373A00 VA: 0x182374800
	public IList<Vector2> get_textures() { }

	// RVA: 0x2375790 Offset: 0x2374990 VA: 0x182375790
	public void set_textures(IList<Vector2> value) { }

	// RVA: 0x236E5F0 Offset: 0x236D7F0 VA: 0x18236E5F0
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x236E4D0 Offset: 0x236D6D0 VA: 0x18236E4D0
	internal ReadOnlyCollection<Vector2> GetUVs(int channel) { }

	// RVA: 0x2372120 Offset: 0x2371320 VA: 0x182372120
	public void SetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x2373E00 Offset: 0x2373000 VA: 0x182373E00
	public int get_faceCount() { }

	// RVA: 0x23749B0 Offset: 0x2373BB0 VA: 0x1823749B0
	public int get_vertexCount() { }

	// RVA: 0x2373D50 Offset: 0x2372F50 VA: 0x182373D50
	public int get_edgeCount() { }

	// RVA: 0x2373F70 Offset: 0x2373170 VA: 0x182373F70
	public int get_indexCount() { }

	// RVA: 0x2374880 Offset: 0x2373A80 VA: 0x182374880
	public int get_triangleCount() { }

	[CompilerGenerated]
	// RVA: 0x2373BC0 Offset: 0x2372DC0 VA: 0x182373BC0
	public static void add_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2374E10 Offset: 0x2374010 VA: 0x182374E10
	public static void remove_meshWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2373AB0 Offset: 0x2372CB0 VA: 0x182373AB0
	internal static void add_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2374D00 Offset: 0x2373F00 VA: 0x182374D00
	internal static void remove_meshWasInitialized(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2373890 Offset: 0x2372A90 VA: 0x182373890
	internal static void add_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2374AE0 Offset: 0x2373CE0 VA: 0x182374AE0
	internal static void remove_componentWillBeDestroyed(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2373780 Offset: 0x2372980 VA: 0x182373780
	internal static void add_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x23749D0 Offset: 0x2373BD0 VA: 0x1823749D0
	internal static void remove_componentHasBeenReset(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x23739A0 Offset: 0x2372BA0 VA: 0x1823739A0
	public static void add_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	[CompilerGenerated]
	// RVA: 0x2374BF0 Offset: 0x2373DF0 VA: 0x182374BF0
	public static void remove_elementSelectionChanged(Action<ProBuilderMesh> value) { }

	// RVA: 0x2374150 Offset: 0x2373350 VA: 0x182374150
	internal Mesh get_mesh() { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00
	internal void set_mesh(Mesh value) { }

	// RVA: 0x2373F40 Offset: 0x2373140 VA: 0x182373F40
	internal int get_id() { }

	// RVA: 0x2374080 Offset: 0x2373280 VA: 0x182374080
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_meshFormatVersion() { }

	// RVA: 0x236B140 Offset: 0x236A340 VA: 0x18236B140
	private void Awake() { }

	// RVA: 0x2370EC0 Offset: 0x23700C0 VA: 0x182370EC0
	private void Reset() { }

	// RVA: 0x23700F0 Offset: 0x236F2F0 VA: 0x1823700F0
	private void OnDestroy() { }

	// RVA: 0x236C550 Offset: 0x236B750 VA: 0x18236C550
	internal void DestroyUnityMesh() { }

	// RVA: 0x236FBA0 Offset: 0x236EDA0 VA: 0x18236FBA0
	private void IncrementVersionIndex() { }

	// RVA: 0x236B590 Offset: 0x236A790 VA: 0x18236B590
	public void Clear() { }

	// RVA: 0x236C760 Offset: 0x236B960 VA: 0x18236C760
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x236BDA0 Offset: 0x236AFA0 VA: 0x18236BDA0
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x236C020 Offset: 0x236B220 VA: 0x18236C020
	public static ProBuilderMesh Create() { }

	// RVA: 0x236C0B0 Offset: 0x236B2B0 VA: 0x18236C0B0
	public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces) { }

	// RVA: 0x236C2D0 Offset: 0x236B4D0 VA: 0x18236C2D0
	public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, IList<Material> materials) { }

	// RVA: 0x236C9A0 Offset: 0x236BBA0 VA: 0x18236C9A0
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x2370370 Offset: 0x236F570 VA: 0x182370370
	public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces) { }

	// RVA: 0x2370500 Offset: 0x236F700 VA: 0x182370500
	internal void Rebuild() { }

	// RVA: 0x2372850 Offset: 0x2371A50 VA: 0x182372850
	public void ToMesh(MeshTopology preferredTopology = 0) { }

	// RVA: 0x236C8E0 Offset: 0x236BAE0 VA: 0x18236C8E0
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x236FF40 Offset: 0x236F140 VA: 0x18236FF40
	public void MakeUnique() { }

	// RVA: 0x236B720 Offset: 0x236A920 VA: 0x18236B720
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x2370C80 Offset: 0x236FE80 VA: 0x182370C80
	public void Refresh(RefreshMask mask = 31) { }

	// RVA: 0x236C660 Offset: 0x236B860 VA: 0x18236C660
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x236E9A0 Offset: 0x236DBA0 VA: 0x18236E9A0
	internal int GetUnusedTextureGroup(int i = 1) { }

	// RVA: 0x7B9D20 Offset: 0x7B8F20 VA: 0x1807B9D20
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x23734E0 Offset: 0x23726E0 VA: 0x1823734E0
	internal int UnusedElementGroup(int i = 1) { }

	// RVA: 0x2370660 Offset: 0x236F860 VA: 0x182370660
	public void RefreshUV(IEnumerable<Face> facesToRefresh) { }

	// RVA: 0x23712C0 Offset: 0x23704C0 VA: 0x1823712C0
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x2370530 Offset: 0x236F730 VA: 0x182370530
	private void RefreshColors() { }

	// RVA: 0x2370F90 Offset: 0x2370190 VA: 0x182370F90
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x2371370 Offset: 0x2370570 VA: 0x182371370
	public void SetMaterial(IEnumerable<Face> faces, Material material) { }

	// RVA: 0x2370580 Offset: 0x236F780 VA: 0x182370580
	private void RefreshNormals() { }

	// RVA: 0x23705F0 Offset: 0x236F7F0 VA: 0x1823705F0
	private void RefreshTangents() { }

	// RVA: 0x236E020 Offset: 0x236D220 VA: 0x18236E020
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x236E1A0 Offset: 0x236D3A0 VA: 0x18236E1A0
	internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices) { }

	// RVA: 0x236D320 Offset: 0x236C520 VA: 0x18236D320
	public List<int> GetCoincidentVertices(IEnumerable<int> vertices) { }

	// RVA: 0x236D940 Offset: 0x236CB40 VA: 0x18236D940
	public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident) { }

	// RVA: 0x236D3F0 Offset: 0x236C5F0 VA: 0x18236D3F0
	public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident) { }

	// RVA: 0x236CF90 Offset: 0x236C190 VA: 0x18236CF90
	public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident) { }

	// RVA: 0x236CD90 Offset: 0x236BF90 VA: 0x18236CD90
	public void GetCoincidentVertices(int vertex, List<int> coincident) { }

	// RVA: 0x23723F0 Offset: 0x23715F0 VA: 0x1823723F0
	public void SetVerticesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x23720D0 Offset: 0x23712D0 VA: 0x1823720D0
	internal void SetTexturesCoincident(IEnumerable<int> vertices) { }

	// RVA: 0x236AFE0 Offset: 0x236A1E0 VA: 0x18236AFE0
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x236AE60 Offset: 0x236A060 VA: 0x18236AE60
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x2374390 Offset: 0x2373590 VA: 0x182374390
	public bool get_selectable() { }

	// RVA: 0x2375170 Offset: 0x2374370 VA: 0x182375170
	public void set_selectable(bool value) { }

	// RVA: 0x2374470 Offset: 0x2373670 VA: 0x182374470
	public int get_selectedFaceCount() { }

	// RVA: 0x2374540 Offset: 0x2373740 VA: 0x182374540
	public int get_selectedVertexCount() { }

	// RVA: 0x23743E0 Offset: 0x23735E0 VA: 0x1823743E0
	public int get_selectedEdgeCount() { }

	// RVA: 0x2374500 Offset: 0x2373700 VA: 0x182374500
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x23743A0 Offset: 0x23735A0 VA: 0x1823743A0
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x2374520 Offset: 0x2373720 VA: 0x182374520
	internal IEnumerable<int> get_selectedSharedVertices() { }

	// RVA: 0x23743C0 Offset: 0x23735C0 VA: 0x1823743C0
	internal IEnumerable<int> get_selectedCoincidentVertices() { }

	// RVA: 0x236B310 Offset: 0x236A510 VA: 0x18236B310
	private void CacheSelection() { }

	// RVA: 0x236DF40 Offset: 0x236D140 VA: 0x18236DF40
	public Face[] GetSelectedFaces() { }

	// RVA: 0x2374490 Offset: 0x2373690 VA: 0x182374490
	public ReadOnlyCollection<int> get_selectedFaceIndexes() { }

	// RVA: 0x2374560 Offset: 0x2373760 VA: 0x182374560
	public ReadOnlyCollection<int> get_selectedVertices() { }

	// RVA: 0x2374400 Offset: 0x2373600 VA: 0x182374400
	public ReadOnlyCollection<Edge> get_selectedEdges() { }

	// RVA: 0x236DF40 Offset: 0x236D140 VA: 0x18236DF40
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x2375180 Offset: 0x2374380 VA: 0x182375180
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x236CCE0 Offset: 0x236BEE0 VA: 0x18236CCE0
	internal Face GetActiveFace() { }

	// RVA: 0x236CC50 Offset: 0x236BE50 VA: 0x18236CC50
	internal Edge GetActiveEdge() { }

	// RVA: 0x236CD40 Offset: 0x236BF40 VA: 0x18236CD40
	internal int GetActiveVertex() { }

	// RVA: 0x236AF80 Offset: 0x236A180 VA: 0x18236AF80
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x2371AE0 Offset: 0x2370CE0 VA: 0x182371AE0
	public void SetSelectedFaces(IEnumerable<Face> selected) { }

	// RVA: 0x2371BA0 Offset: 0x2370DA0 VA: 0x182371BA0
	internal void SetSelectedFaces(IEnumerable<int> selected) { }

	// RVA: 0x2371930 Offset: 0x2370B30 VA: 0x182371930
	public void SetSelectedEdges(IEnumerable<Edge> edges) { }

	// RVA: 0x2371D90 Offset: 0x2370F90 VA: 0x182371D90
	public void SetSelectedVertices(IEnumerable<int> vertices) { }

	// RVA: 0x2370E60 Offset: 0x2370060 VA: 0x182370E60
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x236B510 Offset: 0x236A710 VA: 0x18236B510
	public void ClearSelection() { }

	// RVA: 0x2373670 Offset: 0x2372870 VA: 0x182373670
	public void .ctor() { }

	// RVA: 0x2373600 Offset: 0x2372800 VA: 0x182373600
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2373490 Offset: 0x2372690 VA: 0x182373490
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	[CompilerGenerated]
	// RVA: 0x2373350 Offset: 0x2372550 VA: 0x182373350
	private int <SetSelectedFaces>b__245_0(Face x) { }

	[CompilerGenerated]
	// RVA: 0x23733A0 Offset: 0x23725A0 VA: 0x1823733A0
	private IEnumerable<int> <SetSelectedFaces>b__246_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x23733E0 Offset: 0x23725E0 VA: 0x1823733E0
	private IEnumerable<Edge> <SetSelectedFaces>b__246_1(int x) { }
}

// Namespace: UnityEngine.ProBuilder
public static class Projection // TypeDefIndex: 17160
{
	// Methods

	// RVA: 0x2375F00 Offset: 0x2375100 VA: 0x182375F00
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x2376460 Offset: 0x2375660 VA: 0x182376460
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x2375E40 Offset: 0x2375040 VA: 0x182375E40
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x2376940 Offset: 0x2375B40 VA: 0x182376940
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x2375870 Offset: 0x2374A70 VA: 0x182375870
	public static Plane FindBestPlane(IList<Vector3> points, IList<int> indexes) { }
}

// Namespace: UnityEngine.ProBuilder
[DefaultMember("Item")]
[Serializable]
public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable // TypeDefIndex: 17161
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("array")]
	[FormerlySerializedAs("m_Vertexes")]
	private int[] m_Vertices; // 0x10

	// Properties
	public int Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x2377D60 Offset: 0x2376F60 VA: 0x182377D60
	public void .ctor(IEnumerable<int> indexes) { }

	// RVA: 0x2377E10 Offset: 0x2377010 VA: 0x182377E10
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x18C5FA0 Offset: 0x18C51A0 VA: 0x1818C5FA0
	public int get_Item(int i) { }

	// RVA: 0x2376B20 Offset: 0x2375D20 VA: 0x182376B20 Slot: 11
	public IEnumerator<int> GetEnumerator() { }

	// RVA: 0x2377D10 Offset: 0x2376F10 VA: 0x182377D10 Slot: 3
	public override string ToString() { }

	// RVA: 0x2376B20 Offset: 0x2375D20 VA: 0x182376B20 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2376A40 Offset: 0x2375C40 VA: 0x182376A40 Slot: 6
	public void Add(int item) { }

	// RVA: 0x2376A90 Offset: 0x2375C90 VA: 0x182376A90 Slot: 7
	public void Clear() { }

	// RVA: 0x2376AD0 Offset: 0x2375CD0 VA: 0x182376AD0 Slot: 8
	public bool Contains(int item) { }

	// RVA: 0x1460D20 Offset: 0x145FF20 VA: 0x181460D20 Slot: 9
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x2377300 Offset: 0x2376500 VA: 0x182377300 Slot: 10
	public bool Remove(int item) { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20 Slot: 4
	public int get_Count() { }

	// RVA: 0x2377EE0 Offset: 0x23770E0 VA: 0x182377EE0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x2376B70 Offset: 0x2375D70 VA: 0x182376B70
	public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup) { }

	// RVA: 0x2377580 Offset: 0x2376780 VA: 0x182377580
	internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup) { }

	// RVA: 0x2377B40 Offset: 0x2376D40 VA: 0x182377B40
	private static SharedVertex[] ToSharedVertices(List<List<int>> list) { }

	// RVA: 0x2376DD0 Offset: 0x2375FD0 VA: 0x182376DD0
	public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions) { }

	// RVA: 0x2377380 Offset: 0x2376580 VA: 0x182377380
	internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices) { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Submesh // TypeDefIndex: 17162
{
	// Fields
	[SerializeField]
	internal int[] m_Indexes; // 0x10
	[SerializeField]
	internal MeshTopology m_Topology; // 0x18
	[SerializeField]
	internal int m_SubmeshIndex; // 0x1C

	// Properties
	public int submeshIndex { get; set; }

	// Methods

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_submeshIndex() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_submeshIndex(int value) { }

	// RVA: 0x2378CC0 Offset: 0x2377EC0 VA: 0x182378CC0
	public void .ctor(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes) { }

	// RVA: 0x2378BC0 Offset: 0x2377DC0 VA: 0x182378BC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2377F00 Offset: 0x2377100 VA: 0x182377F00
	public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = 0) { }

	// RVA: 0x2378A00 Offset: 0x2377C00 VA: 0x182378A00
	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class UnwrapParameters // TypeDefIndex: 17163
{
	// Fields
	internal const float k_HardAngle = 88;
	internal const float k_PackMargin = 20;
	internal const float k_AngleError = 8;
	internal const float k_AreaError = 15;
	[Range(1, 180)]
	[Tooltip("Angle between neighbor triangles that will generate seam.")]
	[FormerlySerializedAs("hardAngle")]
	[SerializeField]
	private float m_HardAngle; // 0x10
	[SerializeField]
	[Range(1, 64)]
	[FormerlySerializedAs("packMargin")]
	[Tooltip("Measured in pixels, assuming mesh will cover an entire 1024x1024 lightmap.")]
	private float m_PackMargin; // 0x14
	[Tooltip("Measured in percents. Angle error measures deviation of UV angles from geometry angles. Area error measures deviation of UV triangles area from geometry triangles if they were uniformly scaled.")]
	[Range(1, 75)]
	[SerializeField]
	[FormerlySerializedAs("angleError")]
	private float m_AngleError; // 0x18
	[Range(1, 75)]
	[SerializeField]
	[FormerlySerializedAs("areaError")]
	private float m_AreaError; // 0x1C

	// Properties
	public float hardAngle { get; set; }
	public float packMargin { get; set; }
	public float angleError { get; set; }
	public float areaError { get; set; }

	// Methods

	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_hardAngle() { }

	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_hardAngle(float value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_packMargin() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_packMargin(float value) { }

	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_angleError() { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_angleError(float value) { }

	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_areaError() { }

	// RVA: 0x498F80 Offset: 0x498180 VA: 0x180498F80
	public void set_areaError(float value) { }

	// RVA: 0x2379420 Offset: 0x2378620 VA: 0x182379420
	public void .ctor() { }

	// RVA: 0x2379370 Offset: 0x2378570 VA: 0x182379370
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x2379160 Offset: 0x2378360 VA: 0x182379160
	public void Reset() { }

	// RVA: 0x2379180 Offset: 0x2378380 VA: 0x182379180 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal struct UvUnwrapping.UVTransform // TypeDefIndex: 17164
{
	// Fields
	public Vector2 translation; // 0x0
	public float rotation; // 0x8
	public Vector2 scale; // 0xC

	// Methods

	// RVA: 0x2379070 Offset: 0x2378270 VA: 0x182379070 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class UvUnwrapping // TypeDefIndex: 17165
{
	// Fields
	private static List<Vector2> s_UVTransformProjectionBuffer; // 0x0
	private static Vector2 s_TempVector2; // 0x8
	private static readonly List<int> s_IndexBuffer; // 0x10

	// Methods

	// RVA: 0x237A920 Offset: 0x2379B20 VA: 0x18237A920
	private static int GetIndex(IList<int> collection, int index) { }

	// RVA: 0x237A350 Offset: 0x2379550 VA: 0x18237A350
	internal static UvUnwrapping.UVTransform CalculateDelta(IList<Vector2> src, IList<int> srcIndices, IList<Vector2> dst, IList<int> dstIndices) { }

	// RVA: 0x237A980 Offset: 0x2379B80 VA: 0x18237A980
	private static Vector2 GetRotatedSize(IList<Vector2> points, IList<int> indices, Vector2 center, float rotation) { }

	// RVA: 0x237B2B0 Offset: 0x237A4B0 VA: 0x18237B2B0
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x237ADA0 Offset: 0x2379FA0 VA: 0x18237ADA0
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x23798A0 Offset: 0x2378AA0 VA: 0x1823798A0
	private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x237AF90 Offset: 0x237A190 VA: 0x18237AF90
	private static void ScaleUVs(Vector2[] uvs, IList<int> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x2379470 Offset: 0x2378670 VA: 0x182379470
	private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor) { }

	// RVA: 0x237B450 Offset: 0x237A650 VA: 0x18237B450
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x237B660 Offset: 0x237A860 VA: 0x18237B660
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash // TypeDefIndex: 17166
{
	// Methods

	// RVA: 0x237B980 Offset: 0x237AB80 VA: 0x18237B980
	private static int HashFloat(float f) { }

	// RVA: 0x237B8A0 Offset: 0x237AAA0 VA: 0x18237B8A0
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x237B770 Offset: 0x237A970 VA: 0x18237B770
	public static int GetHashCode(Vector3 v) { }
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Vertex : IEquatable<Vertex> // TypeDefIndex: 17167
{
	// Fields
	[SerializeField]
	private Vector3 m_Position; // 0x10
	[SerializeField]
	private Color m_Color; // 0x1C
	[SerializeField]
	private Vector3 m_Normal; // 0x2C
	[SerializeField]
	private Vector4 m_Tangent; // 0x38
	[SerializeField]
	private Vector2 m_UV0; // 0x48
	[SerializeField]
	private Vector2 m_UV2; // 0x50
	[SerializeField]
	private Vector4 m_UV3; // 0x58
	[SerializeField]
	private Vector4 m_UV4; // 0x68
	[SerializeField]
	private MeshArrays m_Attributes; // 0x78

	// Properties
	public Vector3 position { get; set; }
	public Color color { set; }
	public Vector3 normal { get; set; }
	public Vector4 tangent { set; }
	public Vector2 uv0 { get; set; }
	public Vector2 uv2 { set; }
	public Vector4 uv3 { set; }
	public Vector4 uv4 { set; }
	private bool hasPosition { get; set; }
	private bool hasColor { get; set; }
	private bool hasNormal { get; set; }
	private bool hasTangent { get; set; }
	private bool hasUV0 { get; set; }
	private bool hasUV2 { get; set; }
	private bool hasUV3 { get; set; }
	private bool hasUV4 { get; set; }

	// Methods

	// RVA: 0x10EBEF0 Offset: 0x10EB0F0 VA: 0x1810EBEF0
	public Vector3 get_position() { }

	// RVA: 0x237C970 Offset: 0x237BB70 VA: 0x18237C970
	public void set_position(Vector3 value) { }

	// RVA: 0x237C7A0 Offset: 0x237B9A0 VA: 0x18237C7A0
	public void set_color(Color value) { }

	// RVA: 0x237C740 Offset: 0x237B940 VA: 0x18237C740
	public Vector3 get_normal() { }

	// RVA: 0x237C940 Offset: 0x237BB40 VA: 0x18237C940
	public void set_normal(Vector3 value) { }

	// RVA: 0x237C9A0 Offset: 0x237BBA0 VA: 0x18237C9A0
	public void set_tangent(Vector4 value) { }

	// RVA: 0x237C760 Offset: 0x237B960 VA: 0x18237C760
	public Vector2 get_uv0() { }

	// RVA: 0x237C9D0 Offset: 0x237BBD0 VA: 0x18237C9D0
	public void set_uv0(Vector2 value) { }

	// RVA: 0x237C9F0 Offset: 0x237BBF0 VA: 0x18237C9F0
	public void set_uv2(Vector2 value) { }

	// RVA: 0x237CA10 Offset: 0x237BC10 VA: 0x18237CA10
	public void set_uv3(Vector4 value) { }

	// RVA: 0x237CA30 Offset: 0x237BC30 VA: 0x18237CA30
	public void set_uv4(Vector4 value) { }

	// RVA: 0x237C6B0 Offset: 0x237B8B0 VA: 0x18237C6B0
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x237C6E0 Offset: 0x237B8E0 VA: 0x18237C6E0
	private bool get_hasPosition() { }

	// RVA: 0x237C820 Offset: 0x237BA20 VA: 0x18237C820
	private void set_hasPosition(bool value) { }

	// RVA: 0x237C6C0 Offset: 0x237B8C0 VA: 0x18237C6C0
	private bool get_hasColor() { }

	// RVA: 0x237C7C0 Offset: 0x237B9C0 VA: 0x18237C7C0
	private void set_hasColor(bool value) { }

	// RVA: 0x237C6D0 Offset: 0x237B8D0 VA: 0x18237C6D0
	private bool get_hasNormal() { }

	// RVA: 0x237C7F0 Offset: 0x237B9F0 VA: 0x18237C7F0
	private void set_hasNormal(bool value) { }

	// RVA: 0x237C6F0 Offset: 0x237B8F0 VA: 0x18237C6F0
	private bool get_hasTangent() { }

	// RVA: 0x237C850 Offset: 0x237BA50 VA: 0x18237C850
	private void set_hasTangent(bool value) { }

	// RVA: 0x237C700 Offset: 0x237B900 VA: 0x18237C700
	private bool get_hasUV0() { }

	// RVA: 0x237C880 Offset: 0x237BA80 VA: 0x18237C880
	private void set_hasUV0(bool value) { }

	// RVA: 0x237C710 Offset: 0x237B910 VA: 0x18237C710
	private bool get_hasUV2() { }

	// RVA: 0x237C8B0 Offset: 0x237BAB0 VA: 0x18237C8B0
	private void set_hasUV2(bool value) { }

	// RVA: 0x237C720 Offset: 0x237B920 VA: 0x18237C720
	private bool get_hasUV3() { }

	// RVA: 0x237C8E0 Offset: 0x237BAE0 VA: 0x18237C8E0
	private void set_hasUV3(bool value) { }

	// RVA: 0x237C730 Offset: 0x237B930 VA: 0x18237C730
	private bool get_hasUV4() { }

	// RVA: 0x237C910 Offset: 0x237BB10 VA: 0x18237C910
	private void set_hasUV4(bool value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x237B9F0 Offset: 0x237ABF0 VA: 0x18237B9F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x237BA80 Offset: 0x237AC80 VA: 0x18237BA80 Slot: 4
	public bool Equals(Vertex other) { }

	// RVA: 0x237C560 Offset: 0x237B760 VA: 0x18237C560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x237C780 Offset: 0x237B980 VA: 0x18237C780
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x237C500 Offset: 0x237B700 VA: 0x18237C500
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4) { }

	// RVA: 0x237BD90 Offset: 0x237AF90 VA: 0x18237BD90
	public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17168
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 17169
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 17170
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 17171
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1BAD270 Offset: 0x1BAC470 VA: 0x181BAD270
	public void .ctor(byte ) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 17172
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(2, AllowMultiple = False, Inherited = False)]
internal sealed class NullablePublicOnlyAttribute : Attribute // TypeDefIndex: 17173
{
	// Fields
	public readonly bool IncludesInternals; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool ) { }
}

// Namespace: FxResources.System.Collections.Immutable
internal static class SR // TypeDefIndex: 17174
{}

// Namespace: System
internal static class SR // TypeDefIndex: 17175
{
	// Fields
	private static readonly bool s_usingResourceKeys; // 0x0
	private static ResourceManager s_resourceManager; // 0x8

	// Properties
	internal static ResourceManager ResourceManager { get; }
	internal static string Arg_KeyNotFoundWithKey { get; }
	internal static string ArrayInitializedStateNotEqual { get; }
	internal static string ArrayLengthsNotEqual { get; }
	internal static string CapacityMustEqualCountOnMove { get; }
	internal static string CollectionModifiedDuringEnumeration { get; }
	internal static string InvalidOperationOnDefaultArray { get; }

	// Methods

	// RVA: 0x1BAD810 Offset: 0x1BACA10 VA: 0x181BAD810
	private static bool UsingResourceKeys() { }

	[NullableContext(1)]
	// RVA: 0x1BAD5D0 Offset: 0x1BAC7D0 VA: 0x181BAD5D0
	internal static string GetResourceString(string resourceKey, string defaultString) { }

	[NullableContext(1)]
	// RVA: 0x1BAD460 Offset: 0x1BAC660 VA: 0x181BAD460
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1BADB30 Offset: 0x1BACD30 VA: 0x181BADB30
	internal static ResourceManager get_ResourceManager() { }

	// RVA: 0x1BAD8F0 Offset: 0x1BACAF0 VA: 0x181BAD8F0
	internal static string get_Arg_KeyNotFoundWithKey() { }

	// RVA: 0x1BAD950 Offset: 0x1BACB50 VA: 0x181BAD950
	internal static string get_ArrayInitializedStateNotEqual() { }

	// RVA: 0x1BAD9B0 Offset: 0x1BACBB0 VA: 0x181BAD9B0
	internal static string get_ArrayLengthsNotEqual() { }

	// RVA: 0x1BADA10 Offset: 0x1BACC10 VA: 0x181BADA10
	internal static string get_CapacityMustEqualCountOnMove() { }

	// RVA: 0x1BADA70 Offset: 0x1BACC70 VA: 0x181BADA70
	internal static string get_CollectionModifiedDuringEnumeration() { }

	// RVA: 0x1BADAD0 Offset: 0x1BACCD0 VA: 0x181BADAD0
	internal static string get_InvalidOperationOnDefaultArray() { }

	// RVA: 0x1BAD860 Offset: 0x1BACA60 VA: 0x181BAD860
	private static void .cctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
internal sealed class MaybeNullWhenAttribute : Attribute // TypeDefIndex: 17176
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 17177
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
internal static class AllocFreeConcurrentStack<T> // TypeDefIndex: 17178
{
	// Fields
	private static readonly Type s_typeOfT; // 0x0

	// Properties
	[Nullable(new[] { 1, 0, 1 })]
	private static Stack<RefAsValueType<T>> ThreadLocalStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static void TryAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BDC40 Offset: 0x11BCE40 VA: 0x1811BDC40
	|-AllocFreeConcurrentStack<object>.TryAdd
	|
	|-RVA: 0x11BD8B0 Offset: 0x11BCAB0 VA: 0x1811BD8B0
	|-AllocFreeConcurrentStack<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public static bool TryTake(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BDD30 Offset: 0x11BCF30 VA: 0x1811BDD30
	|-AllocFreeConcurrentStack<object>.TryTake
	|
	|-RVA: 0x11BDE20 Offset: 0x11BD020 VA: 0x1811BDE20
	|-AllocFreeConcurrentStack<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	private static Stack<RefAsValueType<T>> get_ThreadLocalStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE590 Offset: 0x11BD790 VA: 0x1811BE590
	|-AllocFreeConcurrentStack<object>.get_ThreadLocalStack
	|
	|-RVA: 0x11BE280 Offset: 0x11BD480 VA: 0x1811BE280
	|-AllocFreeConcurrentStack<__Il2CppFullySharedGenericType>.get_ThreadLocalStack
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE1A0 Offset: 0x11BD3A0 VA: 0x1811BE1A0
	|-AllocFreeConcurrentStack<object>..cctor
	|
	|-RVA: 0x11BE0C0 Offset: 0x11BD2C0 VA: 0x1811BE0C0
	|-AllocFreeConcurrentStack<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
internal static class AllocFreeConcurrentStack // TypeDefIndex: 17179
{
	// Fields
	[Nullable(new[] { 2, 1, 1 })]
	[ThreadStatic]
	internal static Dictionary<Type, object> t_stacks; // 0x80000000
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
internal sealed class DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 17180
{
	// Fields
	private readonly IEnumerator<KeyValuePair<TKey, TValue>> _inner; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	[Nullable(2)]
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerator<KeyValuePair<TKey, TValue>> inner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC89E0 Offset: 0xFC7BE0 VA: 0x180FC89E0
	|-DictionaryEnumerator<object, object>..ctor
	|
	|-RVA: 0xFC8AA0 Offset: 0xFC7CA0 VA: 0x180FC8AA0
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8F70 Offset: 0xFC8170 VA: 0x180FC8F70
	|-DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0xFC91F0 Offset: 0xFC83F0 VA: 0x180FC91F0
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9450 Offset: 0xFC8650 VA: 0x180FC9450
	|-DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0xFC9580 Offset: 0xFC8780 VA: 0x180FC9580
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC98C0 Offset: 0xFC8AC0 VA: 0x180FC98C0
	|-DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0xFC9760 Offset: 0xFC8960 VA: 0x180FC9760
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8B80 Offset: 0xFC7D80 VA: 0x180FC8B80
	|-DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0xFC8B10 Offset: 0xFC7D10 VA: 0x180FC8B10
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8800 Offset: 0xFC7A00 VA: 0x180FC8800
	|-DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0xFC88A0 Offset: 0xFC7AA0 VA: 0x180FC88A0
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8940 Offset: 0xFC7B40 VA: 0x180FC8940
	|-DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0xFC88F0 Offset: 0xFC7AF0 VA: 0x180FC88F0
	|-DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(2)]
internal interface IImmutableArray // TypeDefIndex: 17181
{
	// Properties
	public abstract Array Array { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Array get_Array();
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
internal interface IImmutableDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 17182
{}

// Namespace: System.Collections.Immutable
[NullableContext(2)]
internal interface IImmutableDictionaryInternal<TKey, TValue> // TypeDefIndex: 17183
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ContainsValue(TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableDictionaryInternal<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
internal interface IImmutableList<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> // TypeDefIndex: 17184
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int IndexOf(T item, int index, int count, IEqualityComparer<T> equalityComparer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableList<__Il2CppFullySharedGenericType>.IndexOf
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class ImmutableArray // TypeDefIndex: 17185
{
	// Fields
	internal static readonly byte[] TwoElementArray; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static ImmutableArray.Builder<T> CreateBuilder<T>(int initialCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23CF0 Offset: 0xA22EF0 VA: 0x180A23CF0
	|-ImmutableArray.CreateBuilder<DebugDirectoryEntry>
	|
	|-RVA: 0xA23DD0 Offset: 0xA22FD0 VA: 0x180A23DD0
	|-ImmutableArray.CreateBuilder<SectionHeader>
	|
	|-RVA: 0xA23D60 Offset: 0xA22F60 VA: 0x180A23D60
	|-ImmutableArray.CreateBuilder<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1BAD210 Offset: 0x1BAC410 VA: 0x181BAD210
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableArray.Builder.<GetEnumerator>d__50<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 17186
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ImmutableArray.Builder<T> <>4__this; // 0x0
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
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>..ctor
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>..ctor
	|
	|-RVA: 0xB1E9D0 Offset: 0xB1DBD0 VA: 0x180B1E9D0
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>.System.IDisposable.Dispose
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>.System.IDisposable.Dispose
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB23920 Offset: 0xB22B20 VA: 0x180B23920
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>.MoveNext
	|
	|-RVA: 0xB23890 Offset: 0xB22A90 VA: 0x180B23890
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>.MoveNext
	|
	|-RVA: 0xB239B0 Offset: 0xB22BB0 VA: 0x180B239B0
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB22080 Offset: 0xB21280 VA: 0x180B22080
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xB23C90 Offset: 0xB22E90 VA: 0x180B23C90
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>.System.Collections.IEnumerator.Reset
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>.System.Collections.IEnumerator.Reset
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB23D40 Offset: 0xB22F40 VA: 0x180B23D40
	|-ImmutableArray.Builder.<GetEnumerator>d__50<DebugDirectoryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23E30 Offset: 0xB23030 VA: 0x180B23E30
	|-ImmutableArray.Builder.<GetEnumerator>d__50<SectionHeader>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB23D80 Offset: 0xB22F80 VA: 0x180B23D80
	|-ImmutableArray.Builder.<GetEnumerator>d__50<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[Nullable(0)]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ImmutableArrayBuilderDebuggerProxy<T>))]
public sealed class ImmutableArray.Builder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 17187
{
	// Fields
	private T[] _elements; // 0x0
	private int _count; // 0x0

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7410 Offset: 0xEF6610 VA: 0x180EF7410
	|-ImmutableArray.Builder<DebugDirectoryEntry>..ctor
	|
	|-RVA: 0xEF7550 Offset: 0xEF6750 VA: 0x180EF7550
	|-ImmutableArray.Builder<SectionHeader>..ctor
	|
	|-RVA: 0xEF74B0 Offset: 0xEF66B0 VA: 0x180EF74B0
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-ImmutableArray.Builder<DebugDirectoryEntry>.get_Capacity
	|-ImmutableArray.Builder<SectionHeader>.get_Capacity
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-ImmutableArray.Builder<DebugDirectoryEntry>.get_Count
	|-ImmutableArray.Builder<SectionHeader>.get_Count
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7B10 Offset: 0xEF6D10 VA: 0x180EF7B10
	|-ImmutableArray.Builder<DebugDirectoryEntry>.set_Count
	|
	|-RVA: 0xEF77E0 Offset: 0xEF69E0 VA: 0x180EF77E0
	|-ImmutableArray.Builder<SectionHeader>.set_Count
	|
	|-RVA: 0xEF7900 Offset: 0xEF6B00 VA: 0x180EF7900
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	private static void ThrowIndexOutOfRangeException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF73D0 Offset: 0xEF65D0 VA: 0x180EF73D0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.ThrowIndexOutOfRangeException
	|-ImmutableArray.Builder<SectionHeader>.ThrowIndexOutOfRangeException
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.ThrowIndexOutOfRangeException
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF76F0 Offset: 0xEF68F0 VA: 0x180EF76F0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.get_Item
	|
	|-RVA: 0xEF7760 Offset: 0xEF6960 VA: 0x180EF7760
	|-ImmutableArray.Builder<SectionHeader>.get_Item
	|
	|-RVA: 0xEF75F0 Offset: 0xEF67F0 VA: 0x180EF75F0
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7CA0 Offset: 0xEF6EA0 VA: 0x180EF7CA0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.set_Item
	|
	|-RVA: 0xEF7C30 Offset: 0xEF6E30 VA: 0x180EF7C30
	|-ImmutableArray.Builder<SectionHeader>.set_Item
	|
	|-RVA: 0xEF7D10 Offset: 0xEF6F10 VA: 0x180EF7D10
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ImmutableArray.Builder<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableArray.Builder<SectionHeader>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public ImmutableArray<T> MoveToImmutable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6B10 Offset: 0xEF5D10 VA: 0x180EF6B10
	|-ImmutableArray.Builder<DebugDirectoryEntry>.MoveToImmutable
	|-ImmutableArray.Builder<SectionHeader>.MoveToImmutable
	|
	|-RVA: 0xEF6C10 Offset: 0xEF5E10 VA: 0x180EF6C10
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.MoveToImmutable
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5260 Offset: 0xEF4460 VA: 0x180EF5260
	|-ImmutableArray.Builder<DebugDirectoryEntry>.Clear
	|
	|-RVA: 0xEF5220 Offset: 0xEF4420 VA: 0x180EF5220
	|-ImmutableArray.Builder<SectionHeader>.Clear
	|
	|-RVA: 0xEF5240 Offset: 0xEF4440 VA: 0x180EF5240
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6830 Offset: 0xEF5A30 VA: 0x180EF6830
	|-ImmutableArray.Builder<DebugDirectoryEntry>.Insert
	|
	|-RVA: 0xEF6730 Offset: 0xEF5930 VA: 0x180EF6730
	|-ImmutableArray.Builder<SectionHeader>.Insert
	|
	|-RVA: 0xEF6920 Offset: 0xEF5B20 VA: 0x180EF6920
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF4FE0 Offset: 0xEF41E0 VA: 0x180EF4FE0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.Add
	|
	|-RVA: 0xEF5190 Offset: 0xEF4390 VA: 0x180EF5190
	|-ImmutableArray.Builder<SectionHeader>.Add
	|
	|-RVA: 0xEF5060 Offset: 0xEF4260 VA: 0x180EF5060
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6FC0 Offset: 0xEF61C0 VA: 0x180EF6FC0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.Remove
	|
	|-RVA: 0xEF7220 Offset: 0xEF6420 VA: 0x180EF7220
	|-ImmutableArray.Builder<SectionHeader>.Remove
	|
	|-RVA: 0xEF7110 Offset: 0xEF6310 VA: 0x180EF7110
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6F10 Offset: 0xEF6110 VA: 0x180EF6F10
	|-ImmutableArray.Builder<DebugDirectoryEntry>.RemoveAt
	|
	|-RVA: 0xEF6E60 Offset: 0xEF6060 VA: 0x180EF6E60
	|-ImmutableArray.Builder<SectionHeader>.RemoveAt
	|
	|-RVA: 0xEF6D30 Offset: 0xEF5F30 VA: 0x180EF6D30
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5280 Offset: 0xEF4480 VA: 0x180EF5280
	|-ImmutableArray.Builder<DebugDirectoryEntry>.Contains
	|
	|-RVA: 0xEF5400 Offset: 0xEF4600 VA: 0x180EF5400
	|-ImmutableArray.Builder<SectionHeader>.Contains
	|
	|-RVA: 0xEF5320 Offset: 0xEF4520 VA: 0x180EF5320
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5690 Offset: 0xEF4890 VA: 0x180EF5690
	|-ImmutableArray.Builder<DebugDirectoryEntry>.CopyTo
	|
	|-RVA: 0xEF55C0 Offset: 0xEF47C0 VA: 0x180EF55C0
	|-ImmutableArray.Builder<SectionHeader>.CopyTo
	|
	|-RVA: 0xEF54B0 Offset: 0xEF46B0 VA: 0x180EF54B0
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5760 Offset: 0xEF4960 VA: 0x180EF5760
	|-ImmutableArray.Builder<DebugDirectoryEntry>.EnsureCapacity
	|
	|-RVA: 0xEF5810 Offset: 0xEF4A10 VA: 0x180EF5810
	|-ImmutableArray.Builder<SectionHeader>.EnsureCapacity
	|
	|-RVA: 0xEF58C0 Offset: 0xEF4AC0 VA: 0x180EF58C0
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF62B0 Offset: 0xEF54B0 VA: 0x180EF62B0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.IndexOf
	|
	|-RVA: 0xEF5E50 Offset: 0xEF5050 VA: 0x180EF5E50
	|-ImmutableArray.Builder<SectionHeader>.IndexOf
	|
	|-RVA: 0xEF6600 Offset: 0xEF5800 VA: 0x180EF6600
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int startIndex, int count, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6340 Offset: 0xEF5540 VA: 0x180EF6340
	|-ImmutableArray.Builder<DebugDirectoryEntry>.IndexOf
	|
	|-RVA: 0xEF5B50 Offset: 0xEF4D50 VA: 0x180EF5B50
	|-ImmutableArray.Builder<SectionHeader>.IndexOf
	|
	|-RVA: 0xEF5EF0 Offset: 0xEF50F0 VA: 0x180EF5EF0
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	[IteratorStateMachine(typeof(ImmutableArray.Builder.<GetEnumerator>d__50<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5AC0 Offset: 0xEF4CC0 VA: 0x180EF5AC0
	|-ImmutableArray.Builder<DebugDirectoryEntry>.GetEnumerator
	|
	|-RVA: 0xEF5A30 Offset: 0xEF4C30 VA: 0x180EF5A30
	|-ImmutableArray.Builder<SectionHeader>.GetEnumerator
	|
	|-RVA: 0xEF5970 Offset: 0xEF4B70 VA: 0x180EF5970
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7390 Offset: 0xEF6590 VA: 0x180EF7390
	|-ImmutableArray.Builder<DebugDirectoryEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xEF73B0 Offset: 0xEF65B0 VA: 0x180EF73B0
	|-ImmutableArray.Builder<SectionHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xEF7370 Offset: 0xEF6570 VA: 0x180EF7370
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7390 Offset: 0xEF6590 VA: 0x180EF7390
	|-ImmutableArray.Builder<DebugDirectoryEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xEF73B0 Offset: 0xEF65B0 VA: 0x180EF73B0
	|-ImmutableArray.Builder<SectionHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xEF7370 Offset: 0xEF6570 VA: 0x180EF7370
	|-ImmutableArray.Builder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[Nullable(0)]
public struct ImmutableArray.Enumerator<T> // TypeDefIndex: 17188
{
	// Fields
	private readonly T[] _array; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBA10 Offset: 0x10EAC10 VA: 0x1810EBA10
	|-ImmutableArray.Enumerator<byte>..ctor
	|-ImmutableArray.Enumerator<DebugDirectoryEntry>..ctor
	|-ImmutableArray.Enumerator<SectionHeader>..ctor
	|-ImmutableArray.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC070 Offset: 0x10EB270 VA: 0x1810EC070
	|-ImmutableArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x10F0CE0 Offset: 0x10EFEE0 VA: 0x1810F0CE0
	|-ImmutableArray.Enumerator<DebugDirectoryEntry>.get_Current
	|
	|-RVA: 0x11117F0 Offset: 0x11109F0 VA: 0x1811117F0
	|-ImmutableArray.Enumerator<SectionHeader>.get_Current
	|
	|-RVA: 0x1112160 Offset: 0x1111360 VA: 0x181112160
	|-ImmutableArray.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E67A0 Offset: 0x10E59A0 VA: 0x1810E67A0
	|-ImmutableArray.Enumerator<byte>.MoveNext
	|-ImmutableArray.Enumerator<DebugDirectoryEntry>.MoveNext
	|-ImmutableArray.Enumerator<SectionHeader>.MoveNext
	|-ImmutableArray.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/
}

// Namespace: 
private class ImmutableArray.EnumeratorObject<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 17189
{
	// Fields
	private static readonly IEnumerator<T> s_EmptyEnumerator; // 0x0
	private readonly T[] _array; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112E490 Offset: 0x112D690 VA: 0x18112E490
	|-ImmutableArray.EnumeratorObject<byte>..ctor
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>..ctor
	|-ImmutableArray.EnumeratorObject<SectionHeader>..ctor
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112E4C0 Offset: 0x112D6C0 VA: 0x18112E4C0
	|-ImmutableArray.EnumeratorObject<byte>.get_Current
	|
	|-RVA: 0x112E540 Offset: 0x112D740 VA: 0x18112E540
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.get_Current
	|
	|-RVA: 0x112E5E0 Offset: 0x112D7E0 VA: 0x18112E5E0
	|-ImmutableArray.EnumeratorObject<SectionHeader>.get_Current
	|
	|-RVA: 0x112E690 Offset: 0x112D890 VA: 0x18112E690
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112E010 Offset: 0x112D210 VA: 0x18112E010
	|-ImmutableArray.EnumeratorObject<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112E0C0 Offset: 0x112D2C0 VA: 0x18112E0C0
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112DF50 Offset: 0x112D150 VA: 0x18112DF50
	|-ImmutableArray.EnumeratorObject<SectionHeader>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x112DEA0 Offset: 0x112D0A0 VA: 0x18112DEA0
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112DE50 Offset: 0x112D050 VA: 0x18112DE50
	|-ImmutableArray.EnumeratorObject<byte>.MoveNext
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.MoveNext
	|-ImmutableArray.EnumeratorObject<SectionHeader>.MoveNext
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90
	|-ImmutableArray.EnumeratorObject<byte>.System.Collections.IEnumerator.Reset
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.System.Collections.IEnumerator.Reset
	|-ImmutableArray.EnumeratorObject<SectionHeader>.System.Collections.IEnumerator.Reset
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ImmutableArray.EnumeratorObject<byte>.Dispose
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.Dispose
	|-ImmutableArray.EnumeratorObject<SectionHeader>.Dispose
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	internal static IEnumerator<T> Create(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112DBC0 Offset: 0x112CDC0 VA: 0x18112DBC0
	|-ImmutableArray.EnumeratorObject<byte>.Create
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>.Create
	|-ImmutableArray.EnumeratorObject<SectionHeader>.Create
	|
	|-RVA: 0x112DCF0 Offset: 0x112CEF0 VA: 0x18112DCF0
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112E180 Offset: 0x112D380 VA: 0x18112E180
	|-ImmutableArray.EnumeratorObject<byte>..cctor
	|-ImmutableArray.EnumeratorObject<DebugDirectoryEntry>..cctor
	|-ImmutableArray.EnumeratorObject<SectionHeader>..cctor
	|
	|-RVA: 0x112E2F0 Offset: 0x112D4F0 VA: 0x18112E2F0
	|-ImmutableArray.EnumeratorObject<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[NonVersionable]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
internal struct ImmutableArray<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IList<T>, ICollection<T>, IEquatable<ImmutableArray<T>>, IList, ICollection, IImmutableArray, IStructuralComparable, IStructuralEquatable, IImmutableList<T> // TypeDefIndex: 17190
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly ImmutableArray<T> Empty; // 0x0
	[DebuggerBrowsable(3)]
	[Nullable(new[] { 2, 1 })]
	internal T[] array; // 0x0

	// Properties
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	[DebuggerBrowsable(0)]
	private int System.Collections.Generic.ICollection<T>.Count { get; }
	[DebuggerBrowsable(0)]
	private int System.Collections.Generic.IReadOnlyCollection<T>.Count { get; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.IList.IsFixedSize { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.IList.IsReadOnly { get; }
	[DebuggerBrowsable(0)]
	private int System.Collections.ICollection.Count { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DebuggerBrowsable(0)]
	private object System.Collections.ICollection.SyncRoot { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	public T Item { get; }
	[DebuggerBrowsable(0)]
	public int Length { get; }
	[DebuggerBrowsable(0)]
	public bool IsDefault { get; }
	[DebuggerBrowsable(0)]
	[Nullable(2)]
	private Array System.Collections.Immutable.IImmutableArray.Array { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D930 Offset: 0x126CB30 VA: 0x18126D930
	|-ImmutableArray<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x126DB90 Offset: 0x126CD90 VA: 0x18126DB90
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x126DC80 Offset: 0x126CE80 VA: 0x18126DC80
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x126DA00 Offset: 0x126CC00 VA: 0x18126DA00
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableArray<byte>.System.Collections.Generic.IList<T>.set_Item
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IList<T>.set_Item
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableArray<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private int System.Collections.Generic.ICollection<T>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D530 Offset: 0x126C730 VA: 0x18126D530
	|-ImmutableArray<byte>.System.Collections.Generic.ICollection<T>.get_Count
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.get_Count
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.ICollection<T>.get_Count
	|
	|-RVA: 0x126D5E0 Offset: 0x126C7E0 VA: 0x18126D5E0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.Generic.IReadOnlyCollection<T>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D530 Offset: 0x126C730 VA: 0x18126D530
	|-ImmutableArray<byte>.System.Collections.Generic.IReadOnlyCollection<T>.get_Count
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IReadOnlyCollection<T>.get_Count
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IReadOnlyCollection<T>.get_Count
	|
	|-RVA: 0x126D5E0 Offset: 0x126C7E0 VA: 0x18126D5E0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyCollection<T>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D930 Offset: 0x126CB30 VA: 0x18126D930
	|-ImmutableArray<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x126DB90 Offset: 0x126CD90 VA: 0x18126DB90
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x126DC80 Offset: 0x126CE80 VA: 0x18126DC80
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x126DA00 Offset: 0x126CC00 VA: 0x18126DA00
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> AsSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126B360 Offset: 0x126A560 VA: 0x18126B360
	|-ImmutableArray<byte>.AsSpan
	|-ImmutableArray<DebugDirectoryEntry>.AsSpan
	|-ImmutableArray<SectionHeader>.AsSpan
	|-ImmutableArray<__Il2CppFullySharedGenericType>.AsSpan
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126C010 Offset: 0x126B210 VA: 0x18126C010
	|-ImmutableArray<byte>.IndexOf
	|
	|-RVA: 0x126D410 Offset: 0x126C610 VA: 0x18126D410
	|-ImmutableArray<DebugDirectoryEntry>.IndexOf
	|
	|-RVA: 0x126D2E0 Offset: 0x126C4E0 VA: 0x18126D2E0
	|-ImmutableArray<SectionHeader>.IndexOf
	|
	|-RVA: 0x126BDD0 Offset: 0x126AFD0 VA: 0x18126BDD0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int IndexOf(T item, int startIndex, int count, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126C720 Offset: 0x126B920 VA: 0x18126C720
	|-ImmutableArray<byte>.IndexOf
	|
	|-RVA: 0x126CAA0 Offset: 0x126BCA0 VA: 0x18126CAA0
	|-ImmutableArray<DebugDirectoryEntry>.IndexOf
	|
	|-RVA: 0x126CE90 Offset: 0x126C090 VA: 0x18126CE90
	|-ImmutableArray<SectionHeader>.IndexOf
	|
	|-RVA: 0x126C120 Offset: 0x126B320 VA: 0x18126C120
	|-ImmutableArray<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126B600 Offset: 0x126A800 VA: 0x18126B600
	|-ImmutableArray<byte>.Contains
	|
	|-RVA: 0x126B6A0 Offset: 0x126A8A0 VA: 0x18126B6A0
	|-ImmutableArray<DebugDirectoryEntry>.Contains
	|
	|-RVA: 0x126B760 Offset: 0x126A960 VA: 0x18126B760
	|-ImmutableArray<SectionHeader>.Contains
	|
	|-RVA: 0x126B470 Offset: 0x126A670 VA: 0x18126B470
	|-ImmutableArray<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableArray<byte>.System.Collections.Generic.IList<T>.Insert
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IList<T>.Insert
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IList<T>.Insert
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IList<T>.RemoveAt
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.ICollection<T>.Add
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableArray<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.ICollection<T>.Clear
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.ICollection<T>.Remove
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.IList.Add
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.Add
	|-ImmutableArray<SectionHeader>.System.Collections.IList.Add
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableArray<byte>.System.Collections.IList.Clear
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.Clear
	|-ImmutableArray<SectionHeader>.System.Collections.IList.Clear
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126E350 Offset: 0x126D550 VA: 0x18126E350
	|-ImmutableArray<byte>.System.Collections.IList.Contains
	|
	|-RVA: 0x126E190 Offset: 0x126D390 VA: 0x18126E190
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x126DFA0 Offset: 0x126D1A0 VA: 0x18126DFA0
	|-ImmutableArray<SectionHeader>.System.Collections.IList.Contains
	|
	|-RVA: 0x126E4F0 Offset: 0x126D6F0 VA: 0x18126E4F0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126E8B0 Offset: 0x126DAB0 VA: 0x18126E8B0
	|-ImmutableArray<byte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x126EB30 Offset: 0x126DD30 VA: 0x18126EB30
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x126E9E0 Offset: 0x126DBE0 VA: 0x18126E9E0
	|-ImmutableArray<SectionHeader>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x126E6D0 Offset: 0x126D8D0 VA: 0x18126E6D0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableArray<byte>.System.Collections.IList.Insert
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.Insert
	|-ImmutableArray<SectionHeader>.System.Collections.IList.Insert
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableArray<byte>.System.Collections.IList.get_IsFixedSize
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.get_IsFixedSize
	|-ImmutableArray<SectionHeader>.System.Collections.IList.get_IsFixedSize
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableArray<byte>.System.Collections.IList.get_IsReadOnly
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.get_IsReadOnly
	|-ImmutableArray<SectionHeader>.System.Collections.IList.get_IsReadOnly
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private int System.Collections.ICollection.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D530 Offset: 0x126C730 VA: 0x18126D530
	|-ImmutableArray<byte>.System.Collections.ICollection.get_Count
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.ICollection.get_Count
	|-ImmutableArray<SectionHeader>.System.Collections.ICollection.get_Count
	|
	|-RVA: 0x126D5E0 Offset: 0x126C7E0 VA: 0x18126D5E0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableArray<byte>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableArray<SectionHeader>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableArray<byte>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableArray<SectionHeader>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.IList.Remove
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.Remove
	|-ImmutableArray<SectionHeader>.System.Collections.IList.Remove
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableArray<byte>.System.Collections.IList.RemoveAt
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.RemoveAt
	|-ImmutableArray<SectionHeader>.System.Collections.IList.RemoveAt
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126EC70 Offset: 0x126DE70 VA: 0x18126EC70
	|-ImmutableArray<byte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x126ED70 Offset: 0x126DF70 VA: 0x18126ED70
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x126F020 Offset: 0x126E220 VA: 0x18126F020
	|-ImmutableArray<SectionHeader>.System.Collections.IList.get_Item
	|
	|-RVA: 0x126EE80 Offset: 0x126E080 VA: 0x18126EE80
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableArray<byte>.System.Collections.IList.set_Item
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IList.set_Item
	|-ImmutableArray<SectionHeader>.System.Collections.IList.set_Item
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126DD80 Offset: 0x126CF80 VA: 0x18126DD80
	|-ImmutableArray<byte>.System.Collections.ICollection.CopyTo
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.ICollection.CopyTo
	|-ImmutableArray<SectionHeader>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x126DE70 Offset: 0x126D070 VA: 0x18126DE70
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126FA70 Offset: 0x126EC70 VA: 0x18126FA70
	|-ImmutableArray<byte>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x126FDA0 Offset: 0x126EFA0 VA: 0x18126FDA0
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x126FB80 Offset: 0x126ED80 VA: 0x18126FB80
	|-ImmutableArray<SectionHeader>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x126FC90 Offset: 0x126EE90 VA: 0x18126FC90
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126FF60 Offset: 0x126F160 VA: 0x18126FF60
	|-ImmutableArray<byte>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x12700D0 Offset: 0x126F2D0 VA: 0x1812700D0
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x126FEB0 Offset: 0x126F0B0 VA: 0x18126FEB0
	|-ImmutableArray<SectionHeader>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1270010 Offset: 0x126F210 VA: 0x181270010
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126F5D0 Offset: 0x126E7D0 VA: 0x18126F5D0
	|-ImmutableArray<byte>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x126F820 Offset: 0x126EA20 VA: 0x18126F820
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x126F380 Offset: 0x126E580 VA: 0x18126F380
	|-ImmutableArray<SectionHeader>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x126F130 Offset: 0x126E330 VA: 0x18126F130
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-ImmutableArray<byte>..ctor
	|-ImmutableArray<DebugDirectoryEntry>..ctor
	|-ImmutableArray<SectionHeader>..ctor
	|-ImmutableArray<__Il2CppFullySharedGenericType>..ctor
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270530 Offset: 0x126F730 VA: 0x181270530
	|-ImmutableArray<byte>.get_Item
	|
	|-RVA: 0x12705C0 Offset: 0x126F7C0 VA: 0x1812705C0
	|-ImmutableArray<DebugDirectoryEntry>.get_Item
	|
	|-RVA: 0x1270560 Offset: 0x126F760 VA: 0x181270560
	|-ImmutableArray<SectionHeader>.get_Item
	|
	|-RVA: 0x1270460 Offset: 0x126F660 VA: 0x181270460
	|-ImmutableArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BF2B0 Offset: 0x11BE4B0 VA: 0x1811BF2B0
	|-ImmutableArray<byte>.get_Length
	|-ImmutableArray<DebugDirectoryEntry>.get_Length
	|-ImmutableArray<SectionHeader>.get_Length
	|-ImmutableArray<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	|-ImmutableArray<byte>.get_IsDefault
	|-ImmutableArray<DebugDirectoryEntry>.get_IsDefault
	|-ImmutableArray<SectionHeader>.get_IsDefault
	|-ImmutableArray<__Il2CppFullySharedGenericType>.get_IsDefault
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private Array System.Collections.Immutable.IImmutableArray.get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-ImmutableArray<byte>.System.Collections.Immutable.IImmutableArray.get_Array
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Immutable.IImmutableArray.get_Array
	|-ImmutableArray<SectionHeader>.System.Collections.Immutable.IImmutableArray.get_Array
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Immutable.IImmutableArray.get_Array
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void CopyTo(T[] destination, int destinationIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126B950 Offset: 0x126AB50 VA: 0x18126B950
	|-ImmutableArray<byte>.CopyTo
	|-ImmutableArray<DebugDirectoryEntry>.CopyTo
	|-ImmutableArray<SectionHeader>.CopyTo
	|
	|-RVA: 0x126B820 Offset: 0x126AA20 VA: 0x18126B820
	|-ImmutableArray<__Il2CppFullySharedGenericType>.CopyTo
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public ImmutableArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BBF0 Offset: 0x126ADF0 VA: 0x18126BBF0
	|-ImmutableArray<byte>.GetEnumerator
	|-ImmutableArray<DebugDirectoryEntry>.GetEnumerator
	|-ImmutableArray<SectionHeader>.GetEnumerator
	|
	|-RVA: 0x126BCB0 Offset: 0x126AEB0 VA: 0x18126BCB0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BDB0 Offset: 0x126AFB0 VA: 0x18126BDB0
	|-ImmutableArray<byte>.GetHashCode
	|-ImmutableArray<DebugDirectoryEntry>.GetHashCode
	|-ImmutableArray<SectionHeader>.GetHashCode
	|-ImmutableArray<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BB80 Offset: 0x126AD80 VA: 0x18126BB80
	|-ImmutableArray<byte>.Equals
	|
	|-RVA: 0x126BAA0 Offset: 0x126ACA0 VA: 0x18126BAA0
	|-ImmutableArray<DebugDirectoryEntry>.Equals
	|
	|-RVA: 0x126BB10 Offset: 0x126AD10 VA: 0x18126BB10
	|-ImmutableArray<SectionHeader>.Equals
	|
	|-RVA: 0x126BA30 Offset: 0x126AC30 VA: 0x18126BA30
	|-ImmutableArray<__Il2CppFullySharedGenericType>.Equals
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1 Slot: 20
	public bool Equals(ImmutableArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BA20 Offset: 0x126AC20 VA: 0x18126BA20
	|-ImmutableArray<byte>.Equals
	|-ImmutableArray<DebugDirectoryEntry>.Equals
	|-ImmutableArray<SectionHeader>.Equals
	|-ImmutableArray<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D830 Offset: 0x126CA30 VA: 0x18126D830
	|-ImmutableArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-ImmutableArray<SectionHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x126D6E0 Offset: 0x126C8E0 VA: 0x18126D6E0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D830 Offset: 0x126CA30 VA: 0x18126D830
	|-ImmutableArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|-ImmutableArray<DebugDirectoryEntry>.System.Collections.IEnumerable.GetEnumerator
	|-ImmutableArray<SectionHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x126D6E0 Offset: 0x126C8E0 VA: 0x18126D6E0
	|-ImmutableArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal void ThrowNullRefIfNotInitialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270360 Offset: 0x126F560 VA: 0x181270360
	|-ImmutableArray<byte>.ThrowNullRefIfNotInitialized
	|-ImmutableArray<DebugDirectoryEntry>.ThrowNullRefIfNotInitialized
	|-ImmutableArray<SectionHeader>.ThrowNullRefIfNotInitialized
	|-ImmutableArray<__Il2CppFullySharedGenericType>.ThrowNullRefIfNotInitialized
	*/

	// RVA: -1 Offset: -1
	private void ThrowInvalidOperationIfNotInitialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270180 Offset: 0x126F380 VA: 0x181270180
	|-ImmutableArray<byte>.ThrowInvalidOperationIfNotInitialized
	|-ImmutableArray<DebugDirectoryEntry>.ThrowInvalidOperationIfNotInitialized
	|-ImmutableArray<SectionHeader>.ThrowInvalidOperationIfNotInitialized
	|
	|-RVA: 0x1270250 Offset: 0x126F450 VA: 0x181270250
	|-ImmutableArray<__Il2CppFullySharedGenericType>.ThrowInvalidOperationIfNotInitialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270380 Offset: 0x126F580 VA: 0x181270380
	|-ImmutableArray<byte>..cctor
	|-ImmutableArray<DebugDirectoryEntry>..cctor
	|-ImmutableArray<SectionHeader>..cctor
	|-ImmutableArray<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
internal sealed class ImmutableArrayBuilderDebuggerProxy<T> // TypeDefIndex: 17191
{}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ImmutableDictionaryBuilderDebuggerProxy<TKey, TValue>))]
[Nullable(0)]
[DefaultMember("Item")]
public sealed class ImmutableDictionary.Builder<TKey, TValue> // TypeDefIndex: 17192
{
	// Fields
	private int _version; // 0x0

	// Properties
	internal int Version { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ImmutableDictionary.Builder<object, object>.get_Version
	|-ImmutableDictionary.Builder<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Version
	*/
}

// Namespace: 
[Nullable(0)]
internal sealed class ImmutableDictionary.Comparers<TKey, TValue> : IEqualityComparer<ImmutableDictionary.HashBucket<TKey, TValue>>, IEqualityComparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 17193
{
	// Fields
	[Nullable(new[] { 1, 0, 0 })]
	internal static readonly ImmutableDictionary.Comparers<TKey, TValue> Default; // 0x0
	private readonly IEqualityComparer<TKey> _keyComparer; // 0x0
	private readonly IEqualityComparer<TValue> _valueComparer; // 0x0

	// Properties
	internal IEqualityComparer<TKey> KeyComparer { get; }
	[Nullable(new[] { 1, 0, 1, 1 })]
	internal IEqualityComparer<KeyValuePair<TKey, TValue>> KeyOnlyComparer { get; }
	internal IEqualityComparer<TValue> ValueComparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF796D0 Offset: 0xF788D0 VA: 0x180F796D0
	|-ImmutableDictionary.Comparers<object, object>..ctor
	|
	|-RVA: 0xF79780 Offset: 0xF78980 VA: 0x180F79780
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEqualityComparer<TKey> get_KeyComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-ImmutableDictionary.Comparers<object, object>.get_KeyComparer
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyComparer
	*/

	// RVA: -1 Offset: -1
	internal IEqualityComparer<KeyValuePair<TKey, TValue>> get_KeyOnlyComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-ImmutableDictionary.Comparers<object, object>.get_KeyOnlyComparer
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyOnlyComparer
	*/

	// RVA: -1 Offset: -1
	internal IEqualityComparer<TValue> get_ValueComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ImmutableDictionary.Comparers<object, object>.get_ValueComparer
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueComparer
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ImmutableDictionary.HashBucket<TKey, TValue> x, ImmutableDictionary.HashBucket<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF785E0 Offset: 0xF777E0 VA: 0x180F785E0
	|-ImmutableDictionary.Comparers<object, object>.Equals
	|
	|-RVA: 0xF78120 Offset: 0xF77320 VA: 0x180F78120
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(ImmutableDictionary.HashBucket<TKey, TValue> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF78740 Offset: 0xF77940 VA: 0x180F78740
	|-ImmutableDictionary.Comparers<object, object>.GetHashCode
	|
	|-RVA: 0xF787C0 Offset: 0xF779C0 VA: 0x180F787C0
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79070 Offset: 0xF78270 VA: 0x180F79070
	|-ImmutableDictionary.Comparers<object, object>.System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals
	|
	|-RVA: 0xF790E0 Offset: 0xF782E0 VA: 0x180F790E0
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(KeyValuePair<TKey, TValue> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79240 Offset: 0xF78440 VA: 0x180F79240
	|-ImmutableDictionary.Comparers<object, object>.System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode
	|
	|-RVA: 0xF792A0 Offset: 0xF784A0 VA: 0x180F792A0
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	internal static ImmutableDictionary.Comparers<TKey, TValue> Get(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF78970 Offset: 0xF77B70 VA: 0x180F78970
	|-ImmutableDictionary.Comparers<object, object>.Get
	|
	|-RVA: 0xF78C80 Offset: 0xF77E80 VA: 0x180F78C80
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79390 Offset: 0xF78590 VA: 0x180F79390
	|-ImmutableDictionary.Comparers<object, object>..cctor
	|
	|-RVA: 0xF794F0 Offset: 0xF786F0 VA: 0x180F794F0
	|-ImmutableDictionary.Comparers<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[NullableContext(0)]
public struct ImmutableDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 17194
{
	// Fields
	private readonly ImmutableDictionary.Builder<TKey, TValue> _builder; // 0x0
	private SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<TKey, TValue>> _mapEnumerator; // 0x0
	private ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> _bucketEnumerator; // 0x0
	private int _enumeratingBuilderVersion; // 0x0

	// Properties
	[Nullable(new[] { 0, 1, 1 })]
	public KeyValuePair<TKey, TValue> Current { get; }
	[Nullable(1)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedInt32KeyNode<ImmutableDictionary.HashBucket<TKey, TValue>> root, ImmutableDictionary.Builder<TKey, TValue> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CDE0 Offset: 0x112BFE0 VA: 0x18112CDE0
	|-ImmutableDictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x113D110 Offset: 0x113C310 VA: 0x18113D110
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D540 Offset: 0x112C740 VA: 0x18112D540
	|-ImmutableDictionary.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x113EA90 Offset: 0x113DC90 VA: 0x18113EA90
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A400 Offset: 0x1129600 VA: 0x18112A400
	|-ImmutableDictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113CB30 Offset: 0x113BD30 VA: 0x18113CB30
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1128900 Offset: 0x1127B00 VA: 0x181128900
	|-ImmutableDictionary.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x1130850 Offset: 0x112FA50 VA: 0x181130850
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1128DA0 Offset: 0x1127FA0 VA: 0x181128DA0
	|-ImmutableDictionary.Enumerator<object, object>.Reset
	|
	|-RVA: 0x11341F0 Offset: 0x11333F0 VA: 0x1811341F0
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126C30 Offset: 0x1125E30 VA: 0x181126C30
	|-ImmutableDictionary.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x112E790 Offset: 0x112D990 VA: 0x18112E790
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CA50 Offset: 0x112BC50 VA: 0x18112CA50
	|-ImmutableDictionary.Enumerator<object, object>.ThrowIfChanged
	|
	|-RVA: 0x113CC30 Offset: 0x113BE30 VA: 0x18113CC30
	|-ImmutableDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowIfChanged
	*/
}

// Namespace: 
private enum ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> // TypeDefIndex: 17195
{
	// Fields
	public int value__; // 0x0
	public const ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> BeforeFirst = 0;
	public const ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> First = 1;
	public const ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> Additional = 2;
	public const ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> End = 3;
}

// Namespace: 
internal struct ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 17196
{
	// Fields
	private readonly ImmutableDictionary.HashBucket<TKey, TValue> _bucket; // 0x0
	private ImmutableDictionary.HashBucket.Enumerator.Position<TKey, TValue> _currentPosition; // 0x0
	private ImmutableList.Enumerator<KeyValuePair<TKey, TValue>> _additionalEnumerator; // 0x0

	// Properties
	[Nullable(1)]
	private object System.Collections.IEnumerator.Current { get; }
	[Nullable(new[] { 0, 1, 1 })]
	public KeyValuePair<TKey, TValue> Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ImmutableDictionary.HashBucket<TKey, TValue> bucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CF30 Offset: 0x112C130 VA: 0x18112CF30
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>..ctor
	|
	|-RVA: 0x113E540 Offset: 0x113D740 VA: 0x18113E540
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A2B0 Offset: 0x11294B0 VA: 0x18112A2B0
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113AB30 Offset: 0x1139D30 VA: 0x18113AB30
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D610 Offset: 0x112C810 VA: 0x18112D610
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x113F310 Offset: 0x113E510 VA: 0x18113F310
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127980 Offset: 0x1126B80 VA: 0x181127980
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x112FFC0 Offset: 0x112F1C0 VA: 0x18112FFC0
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129050 Offset: 0x1128250 VA: 0x181129050
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>.Reset
	|
	|-RVA: 0x1134820 Offset: 0x1133A20 VA: 0x181134820
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126CF0 Offset: 0x1125EF0 VA: 0x181126CF0
	|-ImmutableDictionary.HashBucket.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x112ED70 Offset: 0x112DF70 VA: 0x18112ED70
	|-ImmutableDictionary.HashBucket.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
[NullableContext(0)]
[IsReadOnly]
internal struct ImmutableDictionary.HashBucket<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 17197
{
	// Fields
	private readonly KeyValuePair<TKey, TValue> _firstValue; // 0x0
	private readonly ImmutableList.Node<KeyValuePair<TKey, TValue>> _additionalElements; // 0x0

	// Properties
	internal bool IsEmpty { get; }
	[Nullable(new[] { 0, 1, 1 })]
	internal KeyValuePair<TKey, TValue> FirstValue { get; }
	[Nullable(new[] { 1, 0, 1, 1 })]
	internal ImmutableList.Node<KeyValuePair<TKey, TValue>> AdditionalElements { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805870 Offset: 0x804A70 VA: 0x180805870
	|-ImmutableDictionary.HashBucket<object, object>.get_IsEmpty
	|
	|-RVA: 0x121A150 Offset: 0x1219350 VA: 0x18121A150
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal KeyValuePair<TKey, TValue> get_FirstValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121A0D0 Offset: 0x12192D0 VA: 0x18121A0D0
	|-ImmutableDictionary.HashBucket<object, object>.get_FirstValue
	|
	|-RVA: 0x1219F80 Offset: 0x1219180 VA: 0x181219F80
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_FirstValue
	*/

	// RVA: -1 Offset: -1
	internal ImmutableList.Node<KeyValuePair<TKey, TValue>> get_AdditionalElements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-ImmutableDictionary.HashBucket<object, object>.get_AdditionalElements
	|
	|-RVA: 0x1219F30 Offset: 0x1219130 VA: 0x181219F30
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_AdditionalElements
	*/

	// RVA: -1 Offset: -1
	public ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218EF0 Offset: 0x12180F0 VA: 0x181218EF0
	|-ImmutableDictionary.HashBucket<object, object>.GetEnumerator
	|
	|-RVA: 0x1218F80 Offset: 0x1218180 VA: 0x181218F80
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12190E0 Offset: 0x12182E0 VA: 0x1812190E0
	|-ImmutableDictionary.HashBucket<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1219230 Offset: 0x1218430 VA: 0x181219230
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12190E0 Offset: 0x12182E0 VA: 0x1812190E0
	|-ImmutableDictionary.HashBucket<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1219230 Offset: 0x1218430 VA: 0x181219230
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableDictionary.HashBucket<object, object>.Equals
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableDictionary.HashBucket<object, object>.GetHashCode
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, ImmutableDictionary.Comparers<TKey, TValue> comparers, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1219330 Offset: 0x1218530 VA: 0x181219330
	|-ImmutableDictionary.HashBucket<object, object>.TryGetValue
	|
	|-RVA: 0x12195D0 Offset: 0x12187D0 VA: 0x1812195D0
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Freeze() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218DA0 Offset: 0x1217FA0 VA: 0x181218DA0
	|-ImmutableDictionary.HashBucket<object, object>.Freeze
	|
	|-RVA: 0x1218E00 Offset: 0x1218000 VA: 0x181218E00
	|-ImmutableDictionary.HashBucket<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Freeze
	*/
}

// Namespace: 
[IsReadOnly]
private struct ImmutableDictionary.MutationInput<TKey, TValue> // TypeDefIndex: 17198
{
	// Fields
	private readonly SortedInt32KeyNode<ImmutableDictionary.HashBucket<TKey, TValue>> _root; // 0x0
	private readonly ImmutableDictionary.Comparers<TKey, TValue> _comparers; // 0x0

	// Properties
	internal SortedInt32KeyNode<ImmutableDictionary.HashBucket<TKey, TValue>> Root { get; }
	internal ImmutableDictionary.Comparers<TKey, TValue> Comparers { get; }
	internal IEqualityComparer<TKey> KeyComparer { get; }
	internal IEqualityComparer<TValue> ValueComparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ImmutableDictionary<TKey, TValue> map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146B0A0 Offset: 0x146A2A0 VA: 0x18146B0A0
	|-ImmutableDictionary.MutationInput<object, object>..ctor
	|-ImmutableDictionary.MutationInput<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SortedInt32KeyNode<ImmutableDictionary.HashBucket<TKey, TValue>> get_Root() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-ImmutableDictionary.MutationInput<object, object>.get_Root
	|-ImmutableDictionary.MutationInput<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Root
	*/

	// RVA: -1 Offset: -1
	internal ImmutableDictionary.Comparers<TKey, TValue> get_Comparers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	|-ImmutableDictionary.MutationInput<object, object>.get_Comparers
	|-ImmutableDictionary.MutationInput<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparers
	*/

	// RVA: -1 Offset: -1
	internal IEqualityComparer<TKey> get_KeyComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146B0D0 Offset: 0x146A2D0 VA: 0x18146B0D0
	|-ImmutableDictionary.MutationInput<object, object>.get_KeyComparer
	|
	|-RVA: 0x146B110 Offset: 0x146A310 VA: 0x18146B110
	|-ImmutableDictionary.MutationInput<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyComparer
	*/

	// RVA: -1 Offset: -1
	internal IEqualityComparer<TValue> get_ValueComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146B210 Offset: 0x146A410 VA: 0x18146B210
	|-ImmutableDictionary.MutationInput<object, object>.get_ValueComparer
	|
	|-RVA: 0x146B190 Offset: 0x146A390 VA: 0x18146B190
	|-ImmutableDictionary.MutationInput<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueComparer
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableDictionary.<get_Keys>d__25<TKey, TValue> : IEnumerable<TKey>, IEnumerable, IEnumerator<TKey>, IEnumerator, IDisposable // TypeDefIndex: 17199
{
	// Fields
	private int <>1__state; // 0x0
	private TKey <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public ImmutableDictionary<TKey, TValue> <>4__this; // 0x0
	private SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<TKey, TValue>> <>7__wrap1; // 0x0
	private ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> <>7__wrap2; // 0x0

	// Properties
	private TKey System.Collections.Generic.IEnumerator<TKey>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-ImmutableDictionary.<get_Keys>d__25<object, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58CA0 Offset: 0xF57EA0 VA: 0x180F58CA0
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB303F0 Offset: 0xB2F5F0 VA: 0x180B303F0
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58480 Offset: 0xF57680 VA: 0x180F58480
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.MoveNext
	|
	|-RVA: 0xF57BC0 Offset: 0xF56DC0 VA: 0x180F57BC0
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58D90 Offset: 0xF57F90 VA: 0x180F58D90
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.<>m__Finally1
	|
	|-RVA: 0xF58E00 Offset: 0xF58000 VA: 0x180F58E00
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58FF0 Offset: 0xF581F0 VA: 0x180F58FF0
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.<>m__Finally2
	|
	|-RVA: 0xF58EC0 Offset: 0xF580C0 VA: 0x180F58EC0
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TKey System.Collections.Generic.IEnumerator<TKey>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.Collections.Generic.IEnumerator<TKey>.get_Current
	|
	|-RVA: 0xF58A50 Offset: 0xF57C50 VA: 0x180F58A50
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TKey>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.Collections.IEnumerator.Reset
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF58BE0 Offset: 0xF57DE0 VA: 0x180F58BE0
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF589A0 Offset: 0xF57BA0 VA: 0x180F589A0
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xF58830 Offset: 0xF57A30 VA: 0x180F58830
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58B20 Offset: 0xF57D20 VA: 0x180F58B20
	|-ImmutableDictionary.<get_Keys>d__25<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF58B00 Offset: 0xF57D00 VA: 0x180F58B00
	|-ImmutableDictionary.<get_Keys>d__25<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableDictionary.<get_Values>d__27<TKey, TValue> : IEnumerable<TValue>, IEnumerable, IEnumerator<TValue>, IEnumerator, IDisposable // TypeDefIndex: 17200
{
	// Fields
	private int <>1__state; // 0x0
	private TValue <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public ImmutableDictionary<TKey, TValue> <>4__this; // 0x0
	private SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<TKey, TValue>> <>7__wrap1; // 0x0
	private ImmutableDictionary.HashBucket.Enumerator<TKey, TValue> <>7__wrap2; // 0x0

	// Properties
	private TValue System.Collections.Generic.IEnumerator<TValue>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	|-ImmutableDictionary.<get_Values>d__27<object, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58CA0 Offset: 0xF57EA0 VA: 0x180F58CA0
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB303F0 Offset: 0xB2F5F0 VA: 0x180B303F0
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF59020 Offset: 0xF58220 VA: 0x180F59020
	|-ImmutableDictionary.<get_Values>d__27<object, object>.MoveNext
	|
	|-RVA: 0xF57BC0 Offset: 0xF56DC0 VA: 0x180F57BC0
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58D90 Offset: 0xF57F90 VA: 0x180F58D90
	|-ImmutableDictionary.<get_Values>d__27<object, object>.<>m__Finally1
	|
	|-RVA: 0xF58E00 Offset: 0xF58000 VA: 0x180F58E00
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58FF0 Offset: 0xF581F0 VA: 0x180F58FF0
	|-ImmutableDictionary.<get_Values>d__27<object, object>.<>m__Finally2
	|
	|-RVA: 0xF58EC0 Offset: 0xF580C0 VA: 0x180F58EC0
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TValue System.Collections.Generic.IEnumerator<TValue>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.Collections.Generic.IEnumerator<TValue>.get_Current
	|
	|-RVA: 0xF58A50 Offset: 0xF57C50 VA: 0x180F58A50
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TValue>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.Collections.IEnumerator.Reset
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xF58BE0 Offset: 0xF57DE0 VA: 0x180F58BE0
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF589A0 Offset: 0xF57BA0 VA: 0x180F589A0
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xF58830 Offset: 0xF57A30 VA: 0x180F58830
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF58B20 Offset: 0xF57D20 VA: 0x180F58B20
	|-ImmutableDictionary.<get_Values>d__27<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xF58B00 Offset: 0xF57D00 VA: 0x180F58B00
	|-ImmutableDictionary.<get_Values>d__27<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ImmutableDictionary.<>c<TKey, TValue> // TypeDefIndex: 17201
{
	// Fields
	public static readonly ImmutableDictionary.<>c<TKey, TValue> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ImmutableDictionary.<>c<object, object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ImmutableDictionary.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ImmutableDictionary.<>c<object, object>..ctor
	|-ImmutableDictionary.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__107_0(KeyValuePair<int, ImmutableDictionary.HashBucket<TKey, TValue>> kv) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06E10 Offset: 0xB06010 VA: 0x180B06E10
	|-ImmutableDictionary.<>c<object, object>.<.cctor>b__107_0
	|
	|-RVA: 0xB06E50 Offset: 0xB06050 VA: 0x180B06E50
	|-ImmutableDictionary.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__107_0
	*/
}

// Namespace: System.Collections.Immutable
[DefaultMember("Item")]
[NullableContext(1)]
[DebuggerDisplay("Count = {Count}")]
[Nullable(0)]
[DebuggerTypeProxy(typeof(ImmutableDictionaryDebuggerProxy<TKey, TValue>))]
internal sealed class ImmutableDictionary<TKey, TValue> : IImmutableDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IImmutableDictionaryInternal<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection // TypeDefIndex: 17202
{
	// Fields
	public static readonly ImmutableDictionary<TKey, TValue> Empty; // 0x0
	private static readonly Action<KeyValuePair<int, ImmutableDictionary.HashBucket<TKey, TValue>>> s_FreezeBucketAction; // 0x0
	private readonly int _count; // 0x0
	private readonly SortedInt32KeyNode<ImmutableDictionary.HashBucket<TKey, TValue>> _root; // 0x0
	private readonly ImmutableDictionary.Comparers<TKey, TValue> _comparers; // 0x0

	// Properties
	public int Count { get; }
	public bool IsEmpty { get; }
	public IEqualityComparer<TValue> ValueComparer { get; }
	public IEnumerable<TKey> Keys { get; }
	public IEnumerable<TValue> Values { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	[Nullable(0)]
	private ImmutableDictionary.MutationInput<TKey, TValue> Origin { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	[DebuggerBrowsable(0)]
	private object System.Collections.ICollection.SyncRoot { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(ImmutableDictionary.Comparers<TKey, TValue> comparers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1275A70 Offset: 0x1274C70 VA: 0x181275A70
	|-ImmutableDictionary<object, object>..ctor
	|
	|-RVA: 0x1275930 Offset: 0x1274B30 VA: 0x181275930
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ImmutableDictionary<object, object>.get_Count
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1CC0 Offset: 0xBE0EC0 VA: 0x180BE1CC0
	|-ImmutableDictionary<object, object>.get_IsEmpty
	|
	|-RVA: 0x1275BA0 Offset: 0x1274DA0 VA: 0x181275BA0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TValue> get_ValueComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99F0 Offset: 0x3D8BF0 VA: 0x1803D99F0
	|-ImmutableDictionary<object, object>.get_ValueComparer
	|
	|-RVA: 0x12762B0 Offset: 0x12754B0 VA: 0x1812762B0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueComparer
	*/

	[IteratorStateMachine(typeof(ImmutableDictionary.<get_Keys>d__25<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerable<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12761F0 Offset: 0x12753F0 VA: 0x1812761F0
	|-ImmutableDictionary<object, object>.get_Keys
	|
	|-RVA: 0x1276130 Offset: 0x1275330 VA: 0x181276130
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	[IteratorStateMachine(typeof(ImmutableDictionary.<get_Values>d__27<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 8
	public IEnumerable<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12763A0 Offset: 0x12755A0 VA: 0x1812763A0
	|-ImmutableDictionary<object, object>.get_Values
	|
	|-RVA: 0x12762E0 Offset: 0x12754E0 VA: 0x1812762E0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273480 Offset: 0x1272680 VA: 0x181273480
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x1273500 Offset: 0x1272700 VA: 0x181273500
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273580 Offset: 0x1272780 VA: 0x181273580
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1273600 Offset: 0x1272800 VA: 0x181273600
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	private ImmutableDictionary.MutationInput<TKey, TValue> get_Origin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276280 Offset: 0x1275480 VA: 0x181276280
	|-ImmutableDictionary<object, object>.get_Origin
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Origin
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1275BD0 Offset: 0x1274DD0 VA: 0x181275BD0
	|-ImmutableDictionary<object, object>.get_Item
	|
	|-RVA: 0x1275DC0 Offset: 0x1274FC0 VA: 0x181275DC0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273460 Offset: 0x1272660 VA: 0x181273460
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x1273320 Offset: 0x1272520 VA: 0x181273320
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12710D0 Offset: 0x12702D0 VA: 0x1812710D0
	|-ImmutableDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x12717B0 Offset: 0x12709B0 VA: 0x1812717B0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool Contains(KeyValuePair<TKey, TValue> pair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1272720 Offset: 0x1271920 VA: 0x181272720
	|-ImmutableDictionary<object, object>.Contains
	|
	|-RVA: 0x12727E0 Offset: 0x12719E0 VA: 0x1812727E0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12751B0 Offset: 0x12743B0 VA: 0x1812751B0
	|-ImmutableDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x12749B0 Offset: 0x1273BB0 VA: 0x1812749B0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12719D0 Offset: 0x1270BD0 VA: 0x1812719D0
	|-ImmutableDictionary<object, object>.ContainsValue
	|
	|-RVA: 0x1271C70 Offset: 0x1270E70 VA: 0x181271C70
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public ImmutableDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1272B40 Offset: 0x1271D40 VA: 0x181272B40
	|-ImmutableDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x1272BA0 Offset: 0x1271DA0 VA: 0x181272BA0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273050 Offset: 0x1272250 VA: 0x181273050
	|-ImmutableDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1272C60 Offset: 0x1271E60 VA: 0x181272C60
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273480 Offset: 0x1272680 VA: 0x181273480
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x1273500 Offset: 0x1272700 VA: 0x181273500
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273580 Offset: 0x1272780 VA: 0x181273580
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x1273600 Offset: 0x1272800 VA: 0x181273600
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.Add
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1274240 Offset: 0x1273440 VA: 0x181274240
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1274140 Offset: 0x1273340 VA: 0x181274140
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12744C0 Offset: 0x12736C0 VA: 0x1812744C0
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x12743B0 Offset: 0x12735B0 VA: 0x1812743B0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.Remove
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1274770 Offset: 0x1273970 VA: 0x181274770
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1274620 Offset: 0x1273820 VA: 0x181274620
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.set_Item
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableDictionary<object, object>.System.Collections.IDictionary.Clear
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273940 Offset: 0x1272B40 VA: 0x181273940
	|-ImmutableDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1273C60 Offset: 0x1272E60 VA: 0x181273C60
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 41
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-ImmutableDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 42
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273680 Offset: 0x1272880 VA: 0x181273680
	|-ImmutableDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x12737F0 Offset: 0x12729F0 VA: 0x1812737F0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12748B0 Offset: 0x1273AB0 VA: 0x1812748B0
	|-ImmutableDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1274800 Offset: 0x1273A00 VA: 0x181274800
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool ContainsKey(TKey key, ImmutableDictionary.MutationInput<TKey, TValue> origin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12711D0 Offset: 0x12703D0 VA: 0x1812711D0
	|-ImmutableDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x1271350 Offset: 0x1270550 VA: 0x181271350
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	private static bool Contains(KeyValuePair<TKey, TValue> keyValuePair, ImmutableDictionary.MutationInput<TKey, TValue> origin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1272900 Offset: 0x1271B00 VA: 0x181272900
	|-ImmutableDictionary<object, object>.Contains
	|
	|-RVA: 0x1272090 Offset: 0x1271290 VA: 0x181272090
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool TryGetValue(TKey key, ImmutableDictionary.MutationInput<TKey, TValue> origin, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1274BF0 Offset: 0x1273DF0 VA: 0x181274BF0
	|-ImmutableDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x1274D70 Offset: 0x1273F70 VA: 0x181274D70
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12755A0 Offset: 0x12747A0 VA: 0x1812755A0
	|-ImmutableDictionary<object, object>..cctor
	|
	|-RVA: 0x12752C0 Offset: 0x12744C0 VA: 0x1812752C0
	|-ImmutableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[NullableContext(1)]
internal class ImmutableDictionaryBuilderDebuggerProxy<TKey, TValue> // TypeDefIndex: 17203
{}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(new[] { 0, 0, 1, 1 })]
internal class ImmutableDictionaryDebuggerProxy<TKey, TValue> : ImmutableEnumerableDebuggerProxy<KeyValuePair<TKey, TValue>> // TypeDefIndex: 17204
{}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[NullableContext(1)]
internal class ImmutableEnumerableDebuggerProxy<T> // TypeDefIndex: 17205
{}

// Namespace: System.Collections.Immutable
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class ImmutableExtensions // TypeDefIndex: 17206
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static void ClearFastWhenEmpty<T>(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23EA0 Offset: 0xA230A0 VA: 0x180A23EA0
	|-ImmutableExtensions.ClearFastWhenEmpty<RefAsValueType<object>>
	|
	|-RVA: 0xA23E40 Offset: 0xA23040 VA: 0x180A23E40
	|-ImmutableExtensions.ClearFastWhenEmpty<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[Extension]
[NullableContext(1)]
internal static class ImmutableList // TypeDefIndex: 17207
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IImmutableList<T> list, T item, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA240B0 Offset: 0xA232B0 VA: 0x180A240B0
	|-ImmutableList.IndexOf<object>
	|
	|-RVA: 0xA23EF0 Offset: 0xA230F0 VA: 0x180A23EF0
	|-ImmutableList.IndexOf<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(ImmutableListBuilderDebuggerProxy<T>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Nullable(0)]
public sealed class ImmutableList.Builder<T> // TypeDefIndex: 17208
{
	// Fields
	private int _version; // 0x0

	// Properties
	internal int Version { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ImmutableList.Builder<KeyValuePair<object, object>>.get_Version
	|-ImmutableList.Builder<object>.get_Version
	|-ImmutableList.Builder<__Il2CppFullySharedGenericType>.get_Version
	*/
}

// Namespace: 
[EditorBrowsable(2)]
[NullableContext(0)]
public struct ImmutableList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, ISecurePooledObjectUser // TypeDefIndex: 17209
{
	// Fields
	private static readonly SecureObjectPool<Stack<RefAsValueType<ImmutableList.Node<T>>>, ImmutableList.Enumerator<T>> s_EnumeratingStacks; // 0x0
	private readonly ImmutableList.Builder<T> _builder; // 0x0
	private readonly int _poolUserId; // 0x0
	private readonly int _startIndex; // 0x0
	private readonly int _count; // 0x0
	private int _remainingCount; // 0x0
	private readonly bool _reversed; // 0x0
	private ImmutableList.Node<T> _root; // 0x0
	private SecurePooledObject<Stack<RefAsValueType<ImmutableList.Node<T>>>> _stack; // 0x0
	private ImmutableList.Node<T> _current; // 0x0
	private int _enumeratingBuilderVersion; // 0x0

	// Properties
	private int System.Collections.Immutable.ISecurePooledObjectUser.PoolUserId { get; }
	[Nullable(1)]
	public T Current { get; }
	[Nullable(2)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ImmutableList.Node<T> root, ImmutableList.Builder<T> builder, int startIndex = -1, int count = -1, bool reversed = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB110 Offset: 0x10EA310 VA: 0x1810EB110
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x10F0670 Offset: 0x10EF870 VA: 0x1810F0670
	|-ImmutableList.Enumerator<object>..ctor
	|
	|-RVA: 0x110F880 Offset: 0x110EA80 VA: 0x18110F880
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	|-ImmutableList.Enumerator<object>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBF60 Offset: 0x10EB160 VA: 0x1810EBF60
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x10F0E80 Offset: 0x10F0080 VA: 0x1810F0E80
	|-ImmutableList.Enumerator<object>.get_Current
	|
	|-RVA: 0x1111520 Offset: 0x1110720 VA: 0x181111520
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9960 Offset: 0x10E8B60 VA: 0x1810E9960
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EFD30 Offset: 0x10EEF30 VA: 0x1810EFD30
	|-ImmutableList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110DCE0 Offset: 0x110CEE0 VA: 0x18110DCE0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E5840 Offset: 0x10E4A40 VA: 0x1810E5840
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.Dispose
	|-ImmutableList.Enumerator<object>.Dispose
	|
	|-RVA: 0x1106C70 Offset: 0x1105E70 VA: 0x181106C70
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7750 Offset: 0x10E6950 VA: 0x1810E7750
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x10ED710 Offset: 0x10EC910 VA: 0x1810ED710
	|-ImmutableList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x11078A0 Offset: 0x1106AA0 VA: 0x1811078A0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8400 Offset: 0x10E7600 VA: 0x1810E8400
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.Reset
	|
	|-RVA: 0x10EE2E0 Offset: 0x10ED4E0 VA: 0x1810EE2E0
	|-ImmutableList.Enumerator<object>.Reset
	|
	|-RVA: 0x110BC60 Offset: 0x110AE60 VA: 0x18110BC60
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	private void ResetStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7F00 Offset: 0x10E7100 VA: 0x1810E7F00
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.ResetStack
	|
	|-RVA: 0x10EDDD0 Offset: 0x10ECFD0 VA: 0x1810EDDD0
	|-ImmutableList.Enumerator<object>.ResetStack
	|
	|-RVA: 0x110B4C0 Offset: 0x110A6C0 VA: 0x18110B4C0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.ResetStack
	*/

	// RVA: -1 Offset: -1
	private ImmutableList.Node<T> NextBranch(ImmutableList.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7AD0 Offset: 0x10E6CD0 VA: 0x1810E7AD0
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.NextBranch
	|
	|-RVA: 0x10EDB10 Offset: 0x10ECD10 VA: 0x1810EDB10
	|-ImmutableList.Enumerator<object>.NextBranch
	|
	|-RVA: 0x110ACE0 Offset: 0x1109EE0 VA: 0x18110ACE0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.NextBranch
	*/

	// RVA: -1 Offset: -1
	private ImmutableList.Node<T> PreviousBranch(ImmutableList.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7B20 Offset: 0x10E6D20 VA: 0x1810E7B20
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.PreviousBranch
	|
	|-RVA: 0x10EDB60 Offset: 0x10ECD60 VA: 0x1810EDB60
	|-ImmutableList.Enumerator<object>.PreviousBranch
	|
	|-RVA: 0x110ADC0 Offset: 0x1109FC0 VA: 0x18110ADC0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.PreviousBranch
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA3D0 Offset: 0x10E95D0 VA: 0x1810EA3D0
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.ThrowIfDisposed
	|-ImmutableList.Enumerator<object>.ThrowIfDisposed
	|
	|-RVA: 0x110F0F0 Offset: 0x110E2F0 VA: 0x18110F0F0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA330 Offset: 0x10E9530 VA: 0x1810EA330
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.ThrowIfChanged
	|-ImmutableList.Enumerator<object>.ThrowIfChanged
	|
	|-RVA: 0x110EEC0 Offset: 0x110E0C0 VA: 0x18110EEC0
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.ThrowIfChanged
	*/

	// RVA: -1 Offset: -1
	private void PushNext(ImmutableList.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7CE0 Offset: 0x10E6EE0 VA: 0x1810E7CE0
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>.PushNext
	|
	|-RVA: 0x10EDBB0 Offset: 0x10ECDB0 VA: 0x1810EDBB0
	|-ImmutableList.Enumerator<object>.PushNext
	|
	|-RVA: 0x110B160 Offset: 0x110A360 VA: 0x18110B160
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>.PushNext
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA700 Offset: 0x10E9900 VA: 0x1810EA700
	|-ImmutableList.Enumerator<KeyValuePair<object, object>>..cctor
	|-ImmutableList.Enumerator<object>..cctor
	|
	|-RVA: 0x110F270 Offset: 0x110E470 VA: 0x18110F270
	|-ImmutableList.Enumerator<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[DebuggerDisplay("{_key}")]
[DefaultMember("Item")]
[Nullable(0)]
internal sealed class ImmutableList.Node<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 17210
{
	// Fields
	[Nullable(new[] { 1, 0 })]
	internal static readonly ImmutableList.Node<T> EmptyNode; // 0x0
	private T _key; // 0x0
	private bool _frozen; // 0x0
	private byte _height; // 0x0
	private int _count; // 0x0
	private ImmutableList.Node<T> _left; // 0x0
	private ImmutableList.Node<T> _right; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Height { get; }
	[Nullable(new[] { 2, 0 })]
	public ImmutableList.Node<T> Left { get; }
	[Nullable(new[] { 2, 0 })]
	public ImmutableList.Node<T> Right { get; }
	public T Value { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489990 Offset: 0x1488B90 VA: 0x181489990
	|-ImmutableList.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1489850 Offset: 0x1488A50 VA: 0x181489850
	|-ImmutableList.Node<object>..ctor
	|
	|-RVA: 0x1489930 Offset: 0x1488B30 VA: 0x181489930
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489FC0 Offset: 0x14891C0 VA: 0x181489FC0
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_IsEmpty
	|
	|-RVA: 0x1489FD0 Offset: 0x14891D0 VA: 0x181489FD0
	|-ImmutableList.Node<object>.get_IsEmpty
	|
	|-RVA: 0xBFD9E0 Offset: 0xBFCBE0 VA: 0x180BFD9E0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int get_Height() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_Height
	|
	|-RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	|-ImmutableList.Node<object>.get_Height
	|
	|-RVA: 0xCF56D0 Offset: 0xCF48D0 VA: 0x180CF56D0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_Height
	*/

	// RVA: -1 Offset: -1
	public ImmutableList.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_Left
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-ImmutableList.Node<object>.get_Left
	|
	|-RVA: 0xBFDA20 Offset: 0xBFCC20 VA: 0x180BFDA20
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_Left
	*/

	// RVA: -1 Offset: -1
	public ImmutableList.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-ImmutableList.Node<object>.get_Right
	|
	|-RVA: 0xBFDA50 Offset: 0xBFCC50 VA: 0x180BFDA50
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_Right
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_Value
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-ImmutableList.Node<object>.get_Value
	|
	|-RVA: 0x148A310 Offset: 0x1489510 VA: 0x18148A310
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	|-ImmutableList.Node<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	|-ImmutableList.Node<object>.get_Count
	|
	|-RVA: 0x1489C90 Offset: 0x1488E90 VA: 0x181489C90
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	internal ref T ItemRef(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488320 Offset: 0x1487520 VA: 0x181488320
	|-ImmutableList.Node<KeyValuePair<object, object>>.ItemRef
	|
	|-RVA: 0x1488250 Offset: 0x1487450 VA: 0x181488250
	|-ImmutableList.Node<object>.ItemRef
	|
	|-RVA: 0x1488060 Offset: 0x1487260 VA: 0x181488060
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.ItemRef
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public ImmutableList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486DA0 Offset: 0x1485FA0 VA: 0x181486DA0
	|-ImmutableList.Node<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x1486D40 Offset: 0x1485F40 VA: 0x181486D40
	|-ImmutableList.Node<object>.GetEnumerator
	|
	|-RVA: 0x1486CE0 Offset: 0x1485EE0 VA: 0x181486CE0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489250 Offset: 0x1488450 VA: 0x181489250
	|-ImmutableList.Node<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1489100 Offset: 0x1488300 VA: 0x181489100
	|-ImmutableList.Node<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x14891D0 Offset: 0x14883D0 VA: 0x1814891D0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489250 Offset: 0x1488450 VA: 0x181489250
	|-ImmutableList.Node<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1489100 Offset: 0x1488300 VA: 0x181489100
	|-ImmutableList.Node<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14891D0 Offset: 0x14883D0 VA: 0x1814891D0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int IndexOf(T item, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1487810 Offset: 0x1486A10 VA: 0x181487810
	|-ImmutableList.Node<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x1487970 Offset: 0x1486B70 VA: 0x181487970
	|-ImmutableList.Node<object>.IndexOf
	|
	|-RVA: 0x1487850 Offset: 0x1486A50 VA: 0x181487850
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	internal bool Contains(T item, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1484760 Offset: 0x1483960 VA: 0x181484760
	|-ImmutableList.Node<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x14842B0 Offset: 0x14834B0 VA: 0x1814842B0
	|-ImmutableList.Node<object>.Contains
	|
	|-RVA: 0x14847F0 Offset: 0x14839F0 VA: 0x1814847F0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	internal int IndexOf(T item, int index, int count, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486FA0 Offset: 0x14861A0 VA: 0x181486FA0
	|-ImmutableList.Node<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x1487420 Offset: 0x1486620 VA: 0x181487420
	|-ImmutableList.Node<object>.IndexOf
	|
	|-RVA: 0x14879A0 Offset: 0x1486BA0 VA: 0x1814879A0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	internal void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1485170 Offset: 0x1484370 VA: 0x181485170
	|-ImmutableList.Node<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x1486070 Offset: 0x1485270 VA: 0x181486070
	|-ImmutableList.Node<object>.CopyTo
	|
	|-RVA: 0x14859E0 Offset: 0x1484BE0 VA: 0x1814859E0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal void CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1485440 Offset: 0x1484640 VA: 0x181485440
	|-ImmutableList.Node<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x1485730 Offset: 0x1484930 VA: 0x181485730
	|-ImmutableList.Node<object>.CopyTo
	|
	|-RVA: 0x1484E00 Offset: 0x1484000 VA: 0x181484E00
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal void Freeze() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486B20 Offset: 0x1485D20 VA: 0x181486B20
	|-ImmutableList.Node<KeyValuePair<object, object>>.Freeze
	|
	|-RVA: 0x1486AB0 Offset: 0x1485CB0 VA: 0x181486AB0
	|-ImmutableList.Node<object>.Freeze
	|
	|-RVA: 0x1486B90 Offset: 0x1485D90 VA: 0x181486B90
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.Freeze
	*/

	// RVA: -1 Offset: -1
	private static bool Contains(ImmutableList.Node<T> node, T value, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1484500 Offset: 0x1483700 VA: 0x181484500
	|-ImmutableList.Node<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x1484340 Offset: 0x1483540 VA: 0x181484340
	|-ImmutableList.Node<object>.Contains
	|
	|-RVA: 0x1484910 Offset: 0x1483B10 VA: 0x181484910
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489420 Offset: 0x1488620 VA: 0x181489420
	|-ImmutableList.Node<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x14895F0 Offset: 0x14887F0 VA: 0x1814895F0
	|-ImmutableList.Node<object>..cctor
	|
	|-RVA: 0x14896D0 Offset: 0x14888D0 VA: 0x1814896D0
	|-ImmutableList.Node<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ImmutableEnumerableDebuggerProxy<T>))]
[DebuggerDisplay("Count = {Count}")]
internal sealed class ImmutableList<T> : IImmutableList<T>, IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IList<T>, ICollection<T>, IList, ICollection // TypeDefIndex: 17211
{
	// Fields
	public static readonly ImmutableList<T> Empty; // 0x0
	private readonly ImmutableList.Node<T> _root; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public bool IsEmpty { get; }
	public int Count { get; }
	[DebuggerBrowsable(0)]
	private object System.Collections.ICollection.SyncRoot { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public T Item { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277E70 Offset: 0x1277070 VA: 0x181277E70
	|-ImmutableList<object>..ctor
	|-ImmutableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277F50 Offset: 0x1277150 VA: 0x181277F50
	|-ImmutableList<object>.get_IsEmpty
	|
	|-RVA: 0x1277F20 Offset: 0x1277120 VA: 0x181277F20
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277F00 Offset: 0x1277100 VA: 0x181277F00
	|-ImmutableList<object>.get_Count
	|
	|-RVA: 0xC47230 Offset: 0xC46430 VA: 0x180C47230
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-ImmutableList<object>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableList<object>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277F80 Offset: 0x1277180 VA: 0x181277F80
	|-ImmutableList<object>.get_Item
	|
	|-RVA: 0x1277FB0 Offset: 0x12771B0 VA: 0x181277FB0
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276BF0 Offset: 0x1275DF0 VA: 0x181276BF0
	|-ImmutableList<object>.CopyTo
	|
	|-RVA: 0x1276C20 Offset: 0x1275E20 VA: 0x181276C20
	|-ImmutableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int IndexOf(T item, int index, int count, IEqualityComparer<T> equalityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276E20 Offset: 0x1276020 VA: 0x181276E20
	|-ImmutableList<object>.IndexOf
	|
	|-RVA: 0x1276E60 Offset: 0x1276060 VA: 0x181276E60
	|-ImmutableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276A70 Offset: 0x1275C70 VA: 0x181276A70
	|-ImmutableList<object>.Contains
	|
	|-RVA: 0x1276AE0 Offset: 0x1275CE0 VA: 0x181276AE0
	|-ImmutableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276F90 Offset: 0x1276190 VA: 0x181276F90
	|-ImmutableList<object>.IndexOf
	|
	|-RVA: 0x1276D10 Offset: 0x1275F10 VA: 0x181276D10
	|-ImmutableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276FF0 Offset: 0x12761F0 VA: 0x181276FF0
	|-ImmutableList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12771C0 Offset: 0x12763C0 VA: 0x1812771C0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12774C0 Offset: 0x12766C0 VA: 0x1812774C0
	|-ImmutableList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1277440 Offset: 0x1276640 VA: 0x181277440
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableList<object>.System.Collections.Generic.IList<T>.Insert
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.Generic.IList<T>.RemoveAt
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277390 Offset: 0x1276590 VA: 0x181277390
	|-ImmutableList<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x12772D0 Offset: 0x12764D0 VA: 0x1812772D0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableList<object>.System.Collections.Generic.IList<T>.set_Item
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.Generic.ICollection<T>.Add
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableList<object>.System.Collections.Generic.ICollection<T>.Clear
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.Generic.ICollection<T>.Remove
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12773E0 Offset: 0x12765E0 VA: 0x1812773E0
	|-ImmutableList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1277410 Offset: 0x1276610 VA: 0x181277410
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.IList.Add
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.IList.RemoveAt
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableList<object>.System.Collections.IList.Clear
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12776E0 Offset: 0x12768E0 VA: 0x1812776E0
	|-ImmutableList<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x1277590 Offset: 0x1276790 VA: 0x181277590
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277850 Offset: 0x1276A50 VA: 0x181277850
	|-ImmutableList<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x12779C0 Offset: 0x1276BC0 VA: 0x1812779C0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableList<object>.System.Collections.IList.Insert
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableList<object>.System.Collections.IList.get_IsFixedSize
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableList<object>.System.Collections.IList.get_IsReadOnly
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableList<object>.System.Collections.IList.Remove
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277390 Offset: 0x1276590 VA: 0x181277390
	|-ImmutableList<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1277B20 Offset: 0x1276D20 VA: 0x181277B20
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableList<object>.System.Collections.IList.set_Item
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1 Slot: 36
	public ImmutableList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1276CB0 Offset: 0x1275EB0 VA: 0x181276CB0
	|-ImmutableList<object>.GetEnumerator
	|
	|-RVA: 0x1276C50 Offset: 0x1275E50 VA: 0x181276C50
	|-ImmutableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A9D0 Offset: 0xF09BD0 VA: 0x180F0A9D0
	|-ImmutableList<object>.IsCompatibleObject
	|
	|-RVA: 0xF0A890 Offset: 0xF09A90 VA: 0x180F0A890
	|-ImmutableList<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277D10 Offset: 0x1276F10 VA: 0x181277D10
	|-ImmutableList<object>..cctor
	|
	|-RVA: 0x1277BF0 Offset: 0x1276DF0 VA: 0x181277BF0
	|-ImmutableList<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
internal class ImmutableListBuilderDebuggerProxy<T> // TypeDefIndex: 17212
{}

// Namespace: 
[Nullable(0)]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ImmutableSortedDictionaryBuilderDebuggerProxy<TKey, TValue>))]
public sealed class ImmutableSortedDictionary.Builder<TKey, TValue> // TypeDefIndex: 17213
{
	// Fields
	private int _version; // 0x0

	// Properties
	internal int Version { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ImmutableSortedDictionary.Builder<object, object>.get_Version
	|-ImmutableSortedDictionary.Builder<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Version
	*/
}

// Namespace: 
[NullableContext(0)]
[EditorBrowsable(2)]
public struct ImmutableSortedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, ISecurePooledObjectUser // TypeDefIndex: 17214
{
	// Fields
	private static readonly SecureObjectPool<Stack<RefAsValueType<ImmutableSortedDictionary.Node<TKey, TValue>>>, ImmutableSortedDictionary.Enumerator<TKey, TValue>> s_enumeratingStacks; // 0x0
	private readonly ImmutableSortedDictionary.Builder<TKey, TValue> _builder; // 0x0
	private readonly int _poolUserId; // 0x0
	private ImmutableSortedDictionary.Node<TKey, TValue> _root; // 0x0
	private SecurePooledObject<Stack<RefAsValueType<ImmutableSortedDictionary.Node<TKey, TValue>>>> _stack; // 0x0
	private ImmutableSortedDictionary.Node<TKey, TValue> _current; // 0x0
	private int _enumeratingBuilderVersion; // 0x0

	// Properties
	[Nullable(new[] { 0, 1, 1 })]
	public KeyValuePair<TKey, TValue> Current { get; }
	private int System.Collections.Immutable.ISecurePooledObjectUser.PoolUserId { get; }
	[Nullable(1)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ImmutableSortedDictionary.Node<TKey, TValue> root, ImmutableSortedDictionary.Builder<TKey, TValue> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CF60 Offset: 0x112C160 VA: 0x18112CF60
	|-ImmutableSortedDictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x113DC80 Offset: 0x113CE80 VA: 0x18113DC80
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D710 Offset: 0x112C910 VA: 0x18112D710
	|-ImmutableSortedDictionary.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x113F140 Offset: 0x113E340 VA: 0x18113F140
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-ImmutableSortedDictionary.Enumerator<object, object>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A330 Offset: 0x1129530 VA: 0x18112A330
	|-ImmutableSortedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110DCE0 Offset: 0x110CEE0 VA: 0x18110DCE0
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126D80 Offset: 0x1125F80 VA: 0x181126D80
	|-ImmutableSortedDictionary.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x112EA60 Offset: 0x112DC60 VA: 0x18112EA60
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11285E0 Offset: 0x11277E0 VA: 0x1811285E0
	|-ImmutableSortedDictionary.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x1130500 Offset: 0x112F700 VA: 0x181130500
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1128EB0 Offset: 0x11280B0 VA: 0x181128EB0
	|-ImmutableSortedDictionary.Enumerator<object, object>.Reset
	|
	|-RVA: 0x11344F0 Offset: 0x11336F0 VA: 0x1811344F0
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	internal void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CB90 Offset: 0x112BD90 VA: 0x18112CB90
	|-ImmutableSortedDictionary.Enumerator<object, object>.ThrowIfDisposed
	|
	|-RVA: 0x113CE90 Offset: 0x113C090 VA: 0x18113CE90
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CAF0 Offset: 0x112BCF0 VA: 0x18112CAF0
	|-ImmutableSortedDictionary.Enumerator<object, object>.ThrowIfChanged
	|
	|-RVA: 0x113CDB0 Offset: 0x113BFB0 VA: 0x18113CDB0
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowIfChanged
	*/

	// RVA: -1 Offset: -1
	private void PushLeft(ImmutableSortedDictionary.Node<TKey, TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1128C30 Offset: 0x1127E30 VA: 0x181128C30
	|-ImmutableSortedDictionary.Enumerator<object, object>.PushLeft
	|
	|-RVA: 0x1133F30 Offset: 0x1133130 VA: 0x181133F30
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.PushLeft
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CCB0 Offset: 0x112BEB0 VA: 0x18112CCB0
	|-ImmutableSortedDictionary.Enumerator<object, object>..cctor
	|
	|-RVA: 0x113CFF0 Offset: 0x113C1F0 VA: 0x18113CFF0
	|-ImmutableSortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ImmutableSortedDictionary.Node.<>c<TKey, TValue> // TypeDefIndex: 17215
{
	// Fields
	public static readonly ImmutableSortedDictionary.Node.<>c<TKey, TValue> <>9; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, TKey> <>9__30_0; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, TValue> <>9__32_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ImmutableSortedDictionary.Node.<>c<object, object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ImmutableSortedDictionary.Node.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ImmutableSortedDictionary.Node.<>c<object, object>..ctor
	|-ImmutableSortedDictionary.Node.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TKey <get_Keys>b__30_0(KeyValuePair<TKey, TValue> p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08210 Offset: 0xB07410 VA: 0x180B08210
	|-ImmutableSortedDictionary.Node.<>c<object, object>.<get_Keys>b__30_0
	|
	|-RVA: 0xB069E0 Offset: 0xB05BE0 VA: 0x180B069E0
	|-ImmutableSortedDictionary.Node.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<get_Keys>b__30_0
	*/

	// RVA: -1 Offset: -1
	internal TValue <get_Values>b__32_0(KeyValuePair<TKey, TValue> p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08300 Offset: 0xB07500 VA: 0x180B08300
	|-ImmutableSortedDictionary.Node.<>c<object, object>.<get_Values>b__32_0
	|
	|-RVA: 0xB08260 Offset: 0xB07460 VA: 0x180B08260
	|-ImmutableSortedDictionary.Node.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<get_Values>b__32_0
	*/
}

// Namespace: 
[Nullable(0)]
[DebuggerDisplay("{_key} = {_value}")]
internal sealed class ImmutableSortedDictionary.Node<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 17216
{
	// Fields
	[Nullable(new[] { 1, 0, 0 })]
	internal static readonly ImmutableSortedDictionary.Node<TKey, TValue> EmptyNode; // 0x0
	private readonly TKey _key; // 0x0
	private readonly TValue _value; // 0x0
	private bool _frozen; // 0x0
	private byte _height; // 0x0
	private ImmutableSortedDictionary.Node<TKey, TValue> _left; // 0x0
	private ImmutableSortedDictionary.Node<TKey, TValue> _right; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Height { get; }
	[Nullable(new[] { 2, 0, 0 })]
	public ImmutableSortedDictionary.Node<TKey, TValue> Left { get; }
	[Nullable(new[] { 2, 0, 0 })]
	public ImmutableSortedDictionary.Node<TKey, TValue> Right { get; }
	[Nullable(new[] { 0, 1, 1 })]
	public KeyValuePair<TKey, TValue> Value { get; }
	internal IEnumerable<TKey> Keys { get; }
	internal IEnumerable<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489990 Offset: 0x1488B90 VA: 0x181489990
	|-ImmutableSortedDictionary.Node<object, object>..ctor
	|
	|-RVA: 0xBFD950 Offset: 0xBFCB50 VA: 0x180BFD950
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489FC0 Offset: 0x14891C0 VA: 0x181489FC0
	|-ImmutableSortedDictionary.Node<object, object>.get_IsEmpty
	|
	|-RVA: 0xBFD9E0 Offset: 0xBFCBE0 VA: 0x180BFD9E0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int get_Height() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	|-ImmutableSortedDictionary.Node<object, object>.get_Height
	|
	|-RVA: 0xBE4DF0 Offset: 0xBE3FF0 VA: 0x180BE4DF0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Height
	*/

	// RVA: -1 Offset: -1
	public ImmutableSortedDictionary.Node<TKey, TValue> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-ImmutableSortedDictionary.Node<object, object>.get_Left
	|
	|-RVA: 0xBFDA20 Offset: 0xBFCC20 VA: 0x180BFDA20
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Left
	*/

	// RVA: -1 Offset: -1
	public ImmutableSortedDictionary.Node<TKey, TValue> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	|-ImmutableSortedDictionary.Node<object, object>.get_Right
	|
	|-RVA: 0xBFDA50 Offset: 0xBFCC50 VA: 0x180BFDA50
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Right
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public KeyValuePair<TKey, TValue> get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148A2D0 Offset: 0x14894D0 VA: 0x18148A2D0
	|-ImmutableSortedDictionary.Node<object, object>.get_Value
	|
	|-RVA: 0x148C0C0 Offset: 0x148B2C0 VA: 0x18148C0C0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	internal IEnumerable<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148A0D0 Offset: 0x14892D0 VA: 0x18148A0D0
	|-ImmutableSortedDictionary.Node<object, object>.get_Keys
	|
	|-RVA: 0x148BF20 Offset: 0x148B120 VA: 0x18148BF20
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	internal IEnumerable<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148A3C0 Offset: 0x14895C0 VA: 0x18148A3C0
	|-ImmutableSortedDictionary.Node<object, object>.get_Values
	|
	|-RVA: 0x148C2E0 Offset: 0x148B4E0 VA: 0x18148C2E0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486CA0 Offset: 0x1485EA0 VA: 0x181486CA0
	|-ImmutableSortedDictionary.Node<object, object>.GetEnumerator
	|
	|-RVA: 0x148B590 Offset: 0x148A790 VA: 0x18148B590
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489060 Offset: 0x1488260 VA: 0x181489060
	|-ImmutableSortedDictionary.Node<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x148B8A0 Offset: 0x148AAA0 VA: 0x18148B8A0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489060 Offset: 0x1488260 VA: 0x181489060
	|-ImmutableSortedDictionary.Node<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x148B8A0 Offset: 0x148AAA0 VA: 0x18148B8A0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal void CopyTo(Array array, int arrayIndex, int dictionarySize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1485D90 Offset: 0x1484F90 VA: 0x181485D90
	|-ImmutableSortedDictionary.Node<object, object>.CopyTo
	|
	|-RVA: 0x148B130 Offset: 0x148A330 VA: 0x18148B130
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, IComparer<TKey> keyComparer, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489320 Offset: 0x1488520 VA: 0x181489320
	|-ImmutableSortedDictionary.Node<object, object>.TryGetValue
	|
	|-RVA: 0x148B910 Offset: 0x148AB10 VA: 0x18148B910
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal bool ContainsKey(TKey key, IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483DF0 Offset: 0x1482FF0 VA: 0x181483DF0
	|-ImmutableSortedDictionary.Node<object, object>.ContainsKey
	|
	|-RVA: 0x148A7A0 Offset: 0x14899A0 VA: 0x18148A7A0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	internal bool ContainsValue(TValue value, IEqualityComparer<TValue> valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483ED0 Offset: 0x14830D0 VA: 0x181483ED0
	|-ImmutableSortedDictionary.Node<object, object>.ContainsValue
	|
	|-RVA: 0x148A9B0 Offset: 0x1489BB0 VA: 0x18148A9B0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	internal bool Contains(KeyValuePair<TKey, TValue> pair, IComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1484150 Offset: 0x1483350 VA: 0x181484150
	|-ImmutableSortedDictionary.Node<object, object>.Contains
	|
	|-RVA: 0x148ADB0 Offset: 0x1489FB0 VA: 0x18148ADB0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	private ImmutableSortedDictionary.Node<TKey, TValue> Search(TKey key, IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488C70 Offset: 0x1487E70 VA: 0x181488C70
	|-ImmutableSortedDictionary.Node<object, object>.Search
	|
	|-RVA: 0x148B5D0 Offset: 0x148A7D0 VA: 0x18148B5D0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Search
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489500 Offset: 0x1488700 VA: 0x181489500
	|-ImmutableSortedDictionary.Node<object, object>..cctor
	|
	|-RVA: 0x148BBD0 Offset: 0x148ADD0 VA: 0x18148BBD0
	|-ImmutableSortedDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[DebuggerTypeProxy(typeof(ImmutableDictionaryDebuggerProxy<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Nullable(0)]
[DefaultMember("Item")]
[NullableContext(1)]
internal sealed class ImmutableSortedDictionary<TKey, TValue> : IImmutableDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection // TypeDefIndex: 17217
{
	// Fields
	public static readonly ImmutableSortedDictionary<TKey, TValue> Empty; // 0x0
	private readonly ImmutableSortedDictionary.Node<TKey, TValue> _root; // 0x0
	private readonly int _count; // 0x0
	private readonly IComparer<TKey> _keyComparer; // 0x0
	private readonly IEqualityComparer<TValue> _valueComparer; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Count { get; }
	public IEnumerable<TKey> Keys { get; }
	public IEnumerable<TValue> Values { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	[DebuggerBrowsable(0)]
	private object System.Collections.ICollection.SyncRoot { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279EC0 Offset: 0x12790C0 VA: 0x181279EC0
	|-ImmutableSortedDictionary<object, object>..ctor
	|
	|-RVA: 0x1279FB0 Offset: 0x12791B0 VA: 0x181279FB0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A0D0 Offset: 0x12792D0 VA: 0x18127A0D0
	|-ImmutableSortedDictionary<object, object>.get_IsEmpty
	|
	|-RVA: 0x127A0A0 Offset: 0x12792A0 VA: 0x18127A0A0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-ImmutableSortedDictionary<object, object>.get_Count
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerable<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A5F0 Offset: 0x12797F0 VA: 0x18127A5F0
	|-ImmutableSortedDictionary<object, object>.get_Keys
	|
	|-RVA: 0xB77EF0 Offset: 0xB770F0 VA: 0x180B77EF0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public IEnumerable<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A620 Offset: 0x1279820 VA: 0x18127A620
	|-ImmutableSortedDictionary<object, object>.get_Values
	|
	|-RVA: 0x127A650 Offset: 0x1279850 VA: 0x18127A650
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278E10 Offset: 0x1278010 VA: 0x181278E10
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x1278D90 Offset: 0x1277F90 VA: 0x181278D90
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278E90 Offset: 0x1278090 VA: 0x181278E90
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1278F10 Offset: 0x1278110 VA: 0x181278F10
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A100 Offset: 0x1279300 VA: 0x18127A100
	|-ImmutableSortedDictionary<object, object>.get_Item
	|
	|-RVA: 0x127A280 Offset: 0x1279480 VA: 0x18127A280
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278C30 Offset: 0x1277E30 VA: 0x181278C30
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x1278C50 Offset: 0x1277E50 VA: 0x181278C50
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12783E0 Offset: 0x12775E0 VA: 0x1812783E0
	|-ImmutableSortedDictionary<object, object>.ContainsValue
	|
	|-RVA: 0x12782D0 Offset: 0x12774D0 VA: 0x1812782D0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278230 Offset: 0x1277430 VA: 0x181278230
	|-ImmutableSortedDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x1278060 Offset: 0x1277260 VA: 0x181278060
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool Contains(KeyValuePair<TKey, TValue> pair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278420 Offset: 0x1277620 VA: 0x181278420
	|-ImmutableSortedDictionary<object, object>.Contains
	|
	|-RVA: 0x1278470 Offset: 0x1277670 VA: 0x181278470
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279B50 Offset: 0x1278D50 VA: 0x181279B50
	|-ImmutableSortedDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x1279970 Offset: 0x1278B70 VA: 0x181279970
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12789B0 Offset: 0x1277BB0 VA: 0x1812789B0
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1278610 Offset: 0x1277810 VA: 0x181278610
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278E10 Offset: 0x1278010 VA: 0x181278E10
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x1278D90 Offset: 0x1277F90 VA: 0x181278D90
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1278E90 Offset: 0x1278090 VA: 0x181278E90
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x1278F10 Offset: 0x1278110 VA: 0x181278F10
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.Add
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12793B0 Offset: 0x12785B0 VA: 0x1812793B0
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x12792B0 Offset: 0x12784B0 VA: 0x1812792B0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279590 Offset: 0x1278790 VA: 0x181279590
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x12794B0 Offset: 0x12786B0 VA: 0x1812794B0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.Remove
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12797E0 Offset: 0x12789E0 VA: 0x1812797E0
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1279690 Offset: 0x1278890 VA: 0x181279690
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.set_Item
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-ImmutableSortedDictionary<object, object>.System.Collections.IDictionary.Clear
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279270 Offset: 0x1278470 VA: 0x181279270
	|-ImmutableSortedDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12791E0 Offset: 0x12783E0 VA: 0x1812791E0
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-ImmutableSortedDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 41
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ImmutableSortedDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12790A0 Offset: 0x12782A0 VA: 0x1812790A0
	|-ImmutableSortedDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1278F90 Offset: 0x1278190 VA: 0x181278F90
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279870 Offset: 0x1278A70 VA: 0x181279870
	|-ImmutableSortedDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1279900 Offset: 0x1278B00 VA: 0x181279900
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public ImmutableSortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12785B0 Offset: 0x12777B0 VA: 0x1812785B0
	|-ImmutableSortedDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x1278550 Offset: 0x1277750 VA: 0x181278550
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279D20 Offset: 0x1278F20 VA: 0x181279D20
	|-ImmutableSortedDictionary<object, object>..cctor
	|
	|-RVA: 0x1279C00 Offset: 0x1278E00 VA: 0x181279C00
	|-ImmutableSortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[NullableContext(1)]
internal class ImmutableSortedDictionaryBuilderDebuggerProxy<TKey, TValue> // TypeDefIndex: 17218
{}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
internal abstract class KeysOrValuesCollectionAccessor<TKey, TValue, T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection // TypeDefIndex: 17219
{
	// Fields
	private readonly IImmutableDictionary<TKey, TValue> _dictionary; // 0x0
	private readonly IEnumerable<T> _keysOrValues; // 0x0

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	protected IImmutableDictionary<TKey, TValue> Dictionary { get; }
	[DebuggerBrowsable(0)]
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DebuggerBrowsable(0)]
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(IImmutableDictionary<TKey, TValue> dictionary, IEnumerable<T> keysOrValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B330 Offset: 0x131A530 VA: 0x18131B330
	|-KeysOrValuesCollectionAccessor<object, object, object>..ctor
	|
	|-RVA: 0x131B280 Offset: 0x131A480 VA: 0x18131B280
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-KeysOrValuesCollectionAccessor<object, object, object>.get_IsReadOnly
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B3E0 Offset: 0x131A5E0 VA: 0x18131B3E0
	|-KeysOrValuesCollectionAccessor<object, object, object>.get_Count
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IImmutableDictionary<TKey, TValue> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-KeysOrValuesCollectionAccessor<object, object, object>.get_Dictionary
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-KeysOrValuesCollectionAccessor<object, object, object>.Add
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-KeysOrValuesCollectionAccessor<object, object, object>.Clear
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool Contains(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131A560 Offset: 0x1319760 VA: 0x18131A560
	|-KeysOrValuesCollectionAccessor<object, object, object>.CopyTo
	|
	|-RVA: 0x131A820 Offset: 0x1319A20 VA: 0x18131A820
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-KeysOrValuesCollectionAccessor<object, object, object>.Remove
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131ABB0 Offset: 0x1319DB0 VA: 0x18131ABB0
	|-KeysOrValuesCollectionAccessor<object, object, object>.GetEnumerator
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B220 Offset: 0x131A420 VA: 0x18131B220
	|-KeysOrValuesCollectionAccessor<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131AF50 Offset: 0x131A150 VA: 0x18131AF50
	|-KeysOrValuesCollectionAccessor<object, object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x131AC00 Offset: 0x1319E00 VA: 0x18131AC00
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-KeysOrValuesCollectionAccessor<object, object, object>.System.Collections.ICollection.get_IsSynchronized
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-KeysOrValuesCollectionAccessor<object, object, object>.System.Collections.ICollection.get_SyncRoot
	|-KeysOrValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: System.Collections.Immutable
[Nullable(new[] { 0, 1, 1, 1 })]
[NullableContext(1)]
internal sealed class KeysCollectionAccessor<TKey, TValue> : KeysOrValuesCollectionAccessor<TKey, TValue, TKey> // TypeDefIndex: 17220
{
	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IImmutableDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131A460 Offset: 0x1319660 VA: 0x18131A460
	|-KeysCollectionAccessor<object, object>..ctor
	|
	|-RVA: 0x131A3E0 Offset: 0x13195E0 VA: 0x18131A3E0
	|-KeysCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override bool Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131A200 Offset: 0x1319400 VA: 0x18131A200
	|-KeysCollectionAccessor<object, object>.Contains
	|
	|-RVA: 0x131A2C0 Offset: 0x13194C0 VA: 0x18131A2C0
	|-KeysCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(new[] { 0, 1, 1, 1 })]
internal sealed class ValuesCollectionAccessor<TKey, TValue> : KeysOrValuesCollectionAccessor<TKey, TValue, TValue> // TypeDefIndex: 17221
{
	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IImmutableDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD702E0 Offset: 0xD6F4E0 VA: 0x180D702E0
	|-ValuesCollectionAccessor<object, object>..ctor
	|
	|-RVA: 0xD70360 Offset: 0xD6F560 VA: 0x180D70360
	|-ValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override bool Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD6FE90 Offset: 0xD6F090 VA: 0x180D6FE90
	|-ValuesCollectionAccessor<object, object>.Contains
	|
	|-RVA: 0xD70030 Offset: 0xD6F230 VA: 0x180D70030
	|-ValuesCollectionAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
[DebuggerDisplay("{Value,nq}")]
internal struct RefAsValueType<T> // TypeDefIndex: 17222
{
	// Fields
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-RefAsValueType<object>..ctor
	|
	|-RVA: 0xBE21C0 Offset: 0xBE13C0 VA: 0x180BE21C0
	|-RefAsValueType<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Collections.Immutable
internal class SecureObjectPool // TypeDefIndex: 17223
{
	// Fields
	private static int s_poolUserIdCounter; // 0x0

	// Methods

	// RVA: 0x1BADC30 Offset: 0x1BACE30 VA: 0x181BADC30
	internal static int NewId() { }
}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[NullableContext(1)]
internal class SecureObjectPool<T, TCaller> // TypeDefIndex: 17224
{
	// Methods

	// RVA: -1 Offset: -1
	public void TryAdd(TCaller caller, SecurePooledObject<T> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEEE0 Offset: 0xBEE0E0 VA: 0x180BEEEE0
	|-SecureObjectPool<object, SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>.TryAdd
	|
	|-RVA: 0xBEEF90 Offset: 0xBEE190 VA: 0x180BEEF90
	|-SecureObjectPool<object, ImmutableList.Enumerator<KeyValuePair<object, object>>>.TryAdd
	|-SecureObjectPool<object, ImmutableList.Enumerator<object>>.TryAdd
	|-SecureObjectPool<object, ImmutableSortedDictionary.Enumerator<object, object>>.TryAdd
	|
	|-RVA: 0xBEED50 Offset: 0xBEDF50 VA: 0x180BEED50
	|-SecureObjectPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryTake(TCaller caller, out SecurePooledObject<T> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF140 Offset: 0xBEE340 VA: 0x180BEF140
	|-SecureObjectPool<object, SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>.TryTake
	|
	|-RVA: 0xBEF040 Offset: 0xBEE240 VA: 0x180BEF040
	|-SecureObjectPool<object, ImmutableList.Enumerator<KeyValuePair<object, object>>>.TryTake
	|-SecureObjectPool<object, ImmutableList.Enumerator<object>>.TryTake
	|-SecureObjectPool<object, ImmutableSortedDictionary.Enumerator<object, object>>.TryTake
	|
	|-RVA: 0xBEF240 Offset: 0xBEE440 VA: 0x180BEF240
	|-SecureObjectPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	public SecurePooledObject<T> PrepNew(TCaller caller, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEEA80 Offset: 0xBEDC80 VA: 0x180BEEA80
	|-SecureObjectPool<object, SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>.PrepNew
	|
	|-RVA: 0xBEEB70 Offset: 0xBEDD70 VA: 0x180BEEB70
	|-SecureObjectPool<object, ImmutableList.Enumerator<KeyValuePair<object, object>>>.PrepNew
	|
	|-RVA: 0xBEEC60 Offset: 0xBEDE60 VA: 0x180BEEC60
	|-SecureObjectPool<object, ImmutableList.Enumerator<object>>.PrepNew
	|
	|-RVA: 0xBEE700 Offset: 0xBED900 VA: 0x180BEE700
	|-SecureObjectPool<object, ImmutableSortedDictionary.Enumerator<object, object>>.PrepNew
	|
	|-RVA: 0xBEE7F0 Offset: 0xBED9F0 VA: 0x180BEE7F0
	|-SecureObjectPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.PrepNew
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SecureObjectPool<object, SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>..ctor
	|-SecureObjectPool<object, ImmutableList.Enumerator<KeyValuePair<object, object>>>..ctor
	|-SecureObjectPool<object, ImmutableList.Enumerator<object>>..ctor
	|-SecureObjectPool<object, ImmutableSortedDictionary.Enumerator<object, object>>..ctor
	|-SecureObjectPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Collections.Immutable
internal interface ISecurePooledObjectUser // TypeDefIndex: 17225
{
	// Properties
	public abstract int PoolUserId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_PoolUserId();
}

// Namespace: System.Collections.Immutable
internal class SecurePooledObject<T> // TypeDefIndex: 17226
{
	// Fields
	private readonly T _value; // 0x0
	private int _owner; // 0x0

	// Properties
	internal int Owner { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	internal void .ctor(T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF5F0 Offset: 0xBEE7F0 VA: 0x180BEF5F0
	|-SecurePooledObject<object>..ctor
	|
	|-RVA: 0xBEF470 Offset: 0xBEE670 VA: 0x180BEF470
	|-SecurePooledObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Owner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-SecurePooledObject<object>.get_Owner
	|
	|-RVA: 0xBEF660 Offset: 0xBEE860 VA: 0x180BEF660
	|-SecurePooledObject<__Il2CppFullySharedGenericType>.get_Owner
	*/

	// RVA: -1 Offset: -1
	internal void set_Owner(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	|-SecurePooledObject<object>.set_Owner
	|
	|-RVA: 0xBEF690 Offset: 0xBEE890 VA: 0x180BEF690
	|-SecurePooledObject<__Il2CppFullySharedGenericType>.set_Owner
	*/

	// RVA: -1 Offset: -1
	internal T Use<TCaller>(ref TCaller caller) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F08E0 Offset: 0x8EFAE0 VA: 0x1808F08E0
	|-SecurePooledObject<object>.Use<SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>
	|
	|-RVA: 0x8F0770 Offset: 0x8EF970 VA: 0x1808F0770
	|-SecurePooledObject<object>.Use<ImmutableList.Enumerator<KeyValuePair<object, object>>>
	|-SecurePooledObject<object>.Use<ImmutableList.Enumerator<object>>
	|
	|-RVA: 0x8F0830 Offset: 0x8EFA30 VA: 0x1808F0830
	|-SecurePooledObject<object>.Use<ImmutableSortedDictionary.Enumerator<object, object>>
	|
	|-RVA: 0x8F0990 Offset: 0x8EFB90 VA: 0x1808F0990
	|-SecurePooledObject<__Il2CppFullySharedGenericType>.Use<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal bool TryUse<TCaller>(ref TCaller caller, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F05C0 Offset: 0x8EF7C0 VA: 0x1808F05C0
	|-SecurePooledObject<object>.TryUse<SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>
	|
	|-RVA: 0x8F0520 Offset: 0x8EF720 VA: 0x1808F0520
	|-SecurePooledObject<object>.TryUse<ImmutableList.Enumerator<KeyValuePair<object, object>>>
	|-SecurePooledObject<object>.TryUse<ImmutableList.Enumerator<object>>
	|-SecurePooledObject<object>.TryUse<ImmutableSortedDictionary.Enumerator<object, object>>
	|
	|-RVA: 0x8F0660 Offset: 0x8EF860 VA: 0x1808F0660
	|-SecurePooledObject<__Il2CppFullySharedGenericType>.TryUse<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal bool IsOwned<TCaller>(ref TCaller caller) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F03C0 Offset: 0x8EF5C0 VA: 0x1808F03C0
	|-SecurePooledObject<object>.IsOwned<SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>
	|
	|-RVA: 0x8F0360 Offset: 0x8EF560 VA: 0x1808F0360
	|-SecurePooledObject<object>.IsOwned<ImmutableList.Enumerator<KeyValuePair<object, object>>>
	|-SecurePooledObject<object>.IsOwned<ImmutableList.Enumerator<object>>
	|-SecurePooledObject<object>.IsOwned<ImmutableSortedDictionary.Enumerator<object, object>>
	|
	|-RVA: 0x8F0420 Offset: 0x8EF620 VA: 0x1808F0420
	|-SecurePooledObject<__Il2CppFullySharedGenericType>.IsOwned<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
[EditorBrowsable(2)]
[NullableContext(0)]
public struct SortedInt32KeyNode.Enumerator<TValue> : IEnumerator<KeyValuePair<int, TValue>>, IEnumerator, IDisposable, ISecurePooledObjectUser // TypeDefIndex: 17227
{
	// Fields
	private static readonly SecureObjectPool<Stack<RefAsValueType<SortedInt32KeyNode<TValue>>>, SortedInt32KeyNode.Enumerator<TValue>> s_enumeratingStacks; // 0x0
	private readonly int _poolUserId; // 0x0
	private SortedInt32KeyNode<TValue> _root; // 0x0
	private SecurePooledObject<Stack<RefAsValueType<SortedInt32KeyNode<TValue>>>> _stack; // 0x0
	private SortedInt32KeyNode<TValue> _current; // 0x0

	// Properties
	[Nullable(new[] { 0, 1 })]
	public KeyValuePair<int, TValue> Current { get; }
	private int System.Collections.Immutable.ISecurePooledObjectUser.PoolUserId { get; }
	[Nullable(1)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	internal void .ctor(SortedInt32KeyNode<TValue> root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EABE0 Offset: 0x10E9DE0 VA: 0x1810EABE0
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>..ctor
	|
	|-RVA: 0x1110DB0 Offset: 0x110FFB0 VA: 0x181110DB0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<int, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBB20 Offset: 0x10EAD20 VA: 0x1810EBB20
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.get_Current
	|
	|-RVA: 0x1112420 Offset: 0x1111620 VA: 0x181112420
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9B80 Offset: 0x10E8D80 VA: 0x1810E9B80
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E4D0 Offset: 0x110D6D0 VA: 0x18110E4D0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E5A30 Offset: 0x10E4C30 VA: 0x1810E5A30
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.Dispose
	|
	|-RVA: 0x11069B0 Offset: 0x1105BB0 VA: 0x1811069B0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E64D0 Offset: 0x10E56D0 VA: 0x1810E64D0
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.MoveNext
	|
	|-RVA: 0x1108BD0 Offset: 0x1107DD0 VA: 0x181108BD0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8680 Offset: 0x10E7880 VA: 0x1810E8680
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.Reset
	|
	|-RVA: 0x110BF30 Offset: 0x110B130 VA: 0x18110BF30
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	internal void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA500 Offset: 0x10E9700 VA: 0x1810EA500
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.ThrowIfDisposed
	|
	|-RVA: 0x110EFA0 Offset: 0x110E1A0 VA: 0x18110EFA0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1
	private void PushLeft(SortedInt32KeyNode<TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E7B70 Offset: 0x10E6D70 VA: 0x1810E7B70
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>.PushLeft
	|
	|-RVA: 0x110AEA0 Offset: 0x110A0A0 VA: 0x18110AEA0
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>.PushLeft
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA7F0 Offset: 0x10E99F0 VA: 0x1810EA7F0
	|-SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>..cctor
	|
	|-RVA: 0x110F590 Offset: 0x110E790 VA: 0x18110F590
	|-SortedInt32KeyNode.Enumerator<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[NullableContext(1)]
[Nullable(0)]
[DebuggerDisplay("{_key} = {_value}")]
internal sealed class SortedInt32KeyNode<TValue> // TypeDefIndex: 17228
{
	// Fields
	internal static readonly SortedInt32KeyNode<TValue> EmptyNode; // 0x0
	private readonly int _key; // 0x0
	private readonly TValue _value; // 0x0
	private bool _frozen; // 0x0
	private byte _height; // 0x0
	private SortedInt32KeyNode<TValue> _left; // 0x0
	private SortedInt32KeyNode<TValue> _right; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Height { get; }
	[Nullable(new[] { 2, 1 })]
	public SortedInt32KeyNode<TValue> Left { get; }
	[Nullable(new[] { 2, 1 })]
	public SortedInt32KeyNode<TValue> Right { get; }
	[Nullable(new[] { 0, 1 })]
	public KeyValuePair<int, TValue> Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFD9B0 Offset: 0xBFCBB0 VA: 0x180BFD9B0
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>..ctor
	|
	|-RVA: 0xBFD950 Offset: 0xBFCB50 VA: 0x180BFD950
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFD9D0 Offset: 0xBFCBD0 VA: 0x180BFD9D0
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.get_IsEmpty
	|
	|-RVA: 0xBFD9E0 Offset: 0xBFCBE0 VA: 0x180BFD9E0
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Height() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.get_Height
	|
	|-RVA: 0xBE4DF0 Offset: 0xBE3FF0 VA: 0x180BE4DF0
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.get_Height
	*/

	// RVA: -1 Offset: -1
	public SortedInt32KeyNode<TValue> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.get_Left
	|
	|-RVA: 0xBFDA20 Offset: 0xBFCC20 VA: 0x180BFDA20
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.get_Left
	*/

	// RVA: -1 Offset: -1
	public SortedInt32KeyNode<TValue> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.get_Right
	|
	|-RVA: 0xBFDA50 Offset: 0xBFCC50 VA: 0x180BFDA50
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.get_Right
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<int, TValue> get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFDA80 Offset: 0xBFCC80 VA: 0x180BFDA80
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.get_Value
	|
	|-RVA: 0xBFDAD0 Offset: 0xBFCCD0 VA: 0x180BFDAD0
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.get_Value
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public SortedInt32KeyNode.Enumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFD500 Offset: 0xBFC700 VA: 0x180BFD500
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.GetEnumerator
	|
	|-RVA: 0xBFD530 Offset: 0xBFC730 VA: 0x180BFD530
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(int key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFD560 Offset: 0xBFC760 VA: 0x180BFD560
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>.TryGetValue
	|
	|-RVA: 0xBFD5D0 Offset: 0xBFC7D0 VA: 0x180BFD5D0
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFD760 Offset: 0xBFC960 VA: 0x180BFD760
	|-SortedInt32KeyNode<ImmutableDictionary.HashBucket<object, object>>..cctor
	|
	|-RVA: 0xBFD840 Offset: 0xBFCA40 VA: 0x180BFD840
	|-SortedInt32KeyNode<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Immutable
[Nullable(0)]
[NullableContext(2)]
internal static class Requires // TypeDefIndex: 17229
{
	// Methods

	[NullableContext(1)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static void NotNull<T>(T value, string parameterName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64520 Offset: 0xA63720 VA: 0x180A64520
	|-Requires.NotNull<object>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static void NotNullAllowStructs<T>(T value, string parameterName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA64520 Offset: 0xA63720 VA: 0x180A64520
	|-Requires.NotNullAllowStructs<object>
	|
	|-RVA: 0xA64470 Offset: 0xA63670 VA: 0x180A64470
	|-Requires.NotNullAllowStructs<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: 0x1BAD340 Offset: 0x1BAC540 VA: 0x181BAD340
	private static void FailArgumentNullException(string parameterName) { }

	[DebuggerStepThrough]
	// RVA: 0x1BAD430 Offset: 0x1BAC630 VA: 0x181BAD430
	public static void Range(bool condition, string parameterName, string message) { }

	[DebuggerStepThrough]
	// RVA: 0x1BAD390 Offset: 0x1BAC590 VA: 0x181BAD390
	public static void FailRange(string parameterName, string message) { }

	[DebuggerStepThrough]
	// RVA: 0x1BAD2F0 Offset: 0x1BAC4F0 VA: 0x181BAD2F0
	public static void Argument(bool condition) { }

	[DebuggerStepThrough]
	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static void FailObjectDisposed<TDisposed>(TDisposed disposed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA642E0 Offset: 0xA634E0 VA: 0x180A642E0
	|-Requires.FailObjectDisposed<SortedInt32KeyNode.Enumerator<ImmutableDictionary.HashBucket<object, object>>>
	|
	|-RVA: 0xA641C0 Offset: 0xA633C0 VA: 0x180A641C0
	|-Requires.FailObjectDisposed<ImmutableList.Enumerator<KeyValuePair<object, object>>>
	|-Requires.FailObjectDisposed<ImmutableList.Enumerator<object>>
	|
	|-RVA: 0xA64250 Offset: 0xA63450 VA: 0x180A64250
	|-Requires.FailObjectDisposed<ImmutableSortedDictionary.Enumerator<object, object>>
	|
	|-RVA: 0xA64370 Offset: 0xA63570 VA: 0x180A64370
	|-Requires.FailObjectDisposed<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Collections.Immutable
[Usage(2048, AllowMultiple = False, Inherited = False)]
internal sealed class ValidatedNotNullAttribute : Attribute // TypeDefIndex: 17230
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17231
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 17232
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception // TypeDefIndex: 17233
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x24360B0 Offset: 0x24352B0 VA: 0x1824360B0
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2436120 Offset: 0x2435320 VA: 0x182436120 Slot: 10
	public override string get_StackTrace() { }
}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef // TypeDefIndex: 17234
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x24390B0 Offset: 0x24382B0 VA: 0x1824390B0
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x2439000 Offset: 0x2438200 VA: 0x182439000 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x408300 Offset: 0x407500 VA: 0x180408300
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x2438F90 Offset: 0x2438190 VA: 0x182438F90
	public void Dispose() { }
}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 17235
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x2438030 Offset: 0x2437230 VA: 0x182438030
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x2438100 Offset: 0x2437300 VA: 0x182438100
	public void run() { }

	// RVA: 0x2437F70 Offset: 0x2437170 VA: 0x182437F70 Slot: 6
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }
}

// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 17236
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2437D20 Offset: 0x2436F20 VA: 0x182437D20
	public void .ctor(string javaInterface) { }

	// RVA: 0x2437DA0 Offset: 0x2436FA0 VA: 0x182437DA0
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2436BD0 Offset: 0x2435DD0 VA: 0x182436BD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2436D70 Offset: 0x2435F70 VA: 0x182436D70 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x24376B0 Offset: 0x24368B0 VA: 0x1824376B0 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2437860 Offset: 0x2436A60 VA: 0x182437860 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x2437DD0 Offset: 0x2436FD0 VA: 0x182437DD0 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x2437E30 Offset: 0x2437030 VA: 0x182437E30 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x2437F10 Offset: 0x2437110 VA: 0x182437F10 Slot: 9
	public virtual string toString() { }

	// RVA: 0x2436C60 Offset: 0x2435E60 VA: 0x182436C60
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2436C80 Offset: 0x2435E80 VA: 0x182436C80
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2437C20 Offset: 0x2436E20 VA: 0x182437C20
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 17237
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2436B90 Offset: 0x2435D90 VA: 0x182436B90
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2436A50 Offset: 0x2435C50 VA: 0x182436A50
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x2436380 Offset: 0x2435580 VA: 0x182436380 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x97EF40 Offset: 0x97E140 VA: 0x18097EF40
	|-AndroidJavaObject.GetStatic<int>
	|
	|-RVA: 0x97EE30 Offset: 0x97E030 VA: 0x18097EE30
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24364E0 Offset: 0x24356E0 VA: 0x1824364E0
	public IntPtr GetRawObject() { }

	// RVA: 0x886090 Offset: 0x885290 VA: 0x180886090
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EC010 Offset: 0x8EB210 VA: 0x1808EC010
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x8EC070 Offset: 0x8EB270 VA: 0x1808EC070
	|-AndroidJavaObject.Call<char>
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x8EC0D0 Offset: 0x8EB2D0 VA: 0x1808EC0D0
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x8EC130 Offset: 0x8EB330 VA: 0x1808EC130
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x8EC190 Offset: 0x8EB390 VA: 0x1808EC190
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x8EC1F0 Offset: 0x8EB3F0 VA: 0x1808EC1F0
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x8EC250 Offset: 0x8EB450 VA: 0x1808EC250
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x8EC2B0 Offset: 0x8EB4B0 VA: 0x1808EC2B0
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0x8EBE40 Offset: 0x8EB040 VA: 0x1808EBE40
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EBF50 Offset: 0x8EB150 VA: 0x1808EBF50
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x8EBFB0 Offset: 0x8EB1B0 VA: 0x1808EBFB0
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x8EBE40 Offset: 0x8EB040 VA: 0x1808EBE40
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2436310 Offset: 0x2435510 VA: 0x182436310
	protected void DebugPrint(string msg) { }

	// RVA: 0x2436500 Offset: 0x2435700 VA: 0x182436500
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2436770 Offset: 0x2435970 VA: 0x182436770
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1552F60 Offset: 0x1552160 VA: 0x181552F60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x24363F0 Offset: 0x24355F0 VA: 0x1824363F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x982410 Offset: 0x981610 VA: 0x180982410
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x983510 Offset: 0x982710 VA: 0x180983510
	|-AndroidJavaObject._Call<char>
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x9856D0 Offset: 0x9848D0 VA: 0x1809856D0
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x987A70 Offset: 0x986C70 VA: 0x180987A70
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x988B80 Offset: 0x987D80 VA: 0x180988B80
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x988C10 Offset: 0x987E10 VA: 0x180988C10
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x98AD30 Offset: 0x989F30 VA: 0x18098AD30
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x98ADC0 Offset: 0x989FC0 VA: 0x18098ADC0
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x9868D0 Offset: 0x985AD0 VA: 0x1809868D0
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9824A0 Offset: 0x9816A0 VA: 0x1809824A0
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x9835A0 Offset: 0x9827A0 VA: 0x1809835A0
	|-AndroidJavaObject._Call<char>
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x984620 Offset: 0x983820 VA: 0x180984620
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x986A10 Offset: 0x985C10 VA: 0x180986A10
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x987B00 Offset: 0x986D00 VA: 0x180987B00
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x988CA0 Offset: 0x987EA0 VA: 0x180988CA0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x989CC0 Offset: 0x988EC0 VA: 0x180989CC0
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x98AE50 Offset: 0x98A050 VA: 0x18098AE50
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x985760 Offset: 0x984960 VA: 0x180985760
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9812D0 Offset: 0x9804D0 VA: 0x1809812D0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x981360 Offset: 0x980560 VA: 0x180981360
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x980130 Offset: 0x97F330 VA: 0x180980130
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x980270 Offset: 0x97F470 VA: 0x180980270
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x9813F0 Offset: 0x9805F0 VA: 0x1809813F0
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x97EFC0 Offset: 0x97E1C0 VA: 0x18097EFC0
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98CBD0 Offset: 0x98BDD0 VA: 0x18098CBD0
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x98CAA0 Offset: 0x98BCA0 VA: 0x18098CAA0
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98CC40 Offset: 0x98BE40 VA: 0x18098CC40
	|-AndroidJavaObject._GetStatic<int>
	|
	|-RVA: 0x98BF00 Offset: 0x98B100 VA: 0x18098BF00
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2436230 Offset: 0x2435430 VA: 0x182436230
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2436150 Offset: 0x2435350 VA: 0x182436150
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EC310 Offset: 0x8EB510 VA: 0x1808EC310
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<bool>
	|
	|-RVA: 0x8EC430 Offset: 0x8EB630 VA: 0x1808EC430
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<char>
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<short>
	|
	|-RVA: 0x8EC550 Offset: 0x8EB750 VA: 0x1808EC550
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<double>
	|
	|-RVA: 0x97E910 Offset: 0x97DB10 VA: 0x18097E910
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<int>
	|
	|-RVA: 0x97EA10 Offset: 0x97DC10 VA: 0x18097EA10
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<long>
	|
	|-RVA: 0x97EB10 Offset: 0x97DD10 VA: 0x18097EB10
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<object>
	|
	|-RVA: 0x97EC00 Offset: 0x97DE00 VA: 0x18097EC00
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<sbyte>
	|
	|-RVA: 0x97ED10 Offset: 0x97DF10 VA: 0x18097ED10
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<float>
	|
	|-RVA: 0x97E6D0 Offset: 0x97D8D0 VA: 0x18097E6D0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24364E0 Offset: 0x24356E0 VA: 0x1824364E0
	protected IntPtr _GetRawObject() { }

	// RVA: 0x886090 Offset: 0x885290 VA: 0x180886090
	protected IntPtr _GetRawClass() { }
}

// Namespace: UnityEngine
public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 17238
{
	// Methods

	// RVA: 0x2435F50 Offset: 0x2435150 VA: 0x182435F50
	public void .ctor(string className) { }

	// RVA: 0x2435D30 Offset: 0x2434F30 VA: 0x182435D30
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2435E80 Offset: 0x2435080 VA: 0x182435E80
	internal void .ctor(IntPtr jclass) { }
}

// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 17239
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x19D4D40 Offset: 0x19D3F40 VA: 0x1819D4D40
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2438B90 Offset: 0x2437D90 VA: 0x182438B90
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2438AD0 Offset: 0x2437CD0 VA: 0x182438AD0
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x24387F0 Offset: 0x24379F0 VA: 0x1824387F0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2438270 Offset: 0x2437470 VA: 0x182438270
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x24388B0 Offset: 0x2437AB0 VA: 0x1824388B0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x24384C0 Offset: 0x24376C0 VA: 0x1824384C0
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x2438420 Offset: 0x2437620 VA: 0x182438420
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x24386E0 Offset: 0x24378E0 VA: 0x1824386E0
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x2438BC0 Offset: 0x2437DC0 VA: 0x182438BC0
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x2438130 Offset: 0x2437330 VA: 0x182438130
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x2438D00 Offset: 0x2437F00 VA: 0x182438D00
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper // TypeDefIndex: 17240
{
	// Methods

	// RVA: 0x243B590 Offset: 0x243A790 VA: 0x18243B590
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x2430940 Offset: 0x242FB40 VA: 0x182430940
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x243CEC0 Offset: 0x243C0C0 VA: 0x18243CEC0
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x243AD10 Offset: 0x2439F10 VA: 0x18243AD10
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x243CF70 Offset: 0x243C170 VA: 0x18243CF70
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x243D630 Offset: 0x243C830 VA: 0x18243D630
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x2439130 Offset: 0x2438330 VA: 0x182439130
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x243B740 Offset: 0x243A940 VA: 0x18243B740
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x243A050 Offset: 0x2439250 VA: 0x18243A050
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA9170 Offset: 0xAA8370 VA: 0x180AA9170
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0xAA9B00 Offset: 0xAA8D00 VA: 0x180AA9B00
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0xAAA490 Offset: 0xAA9690 VA: 0x180AAA490
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0xAAAE20 Offset: 0xAAA020 VA: 0x180AAAE20
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0xAAB7B0 Offset: 0xAAA9B0 VA: 0x180AAB7B0
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0xAAC140 Offset: 0xAAB340 VA: 0x180AAC140
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0xAACB40 Offset: 0xAABD40 VA: 0x180AACB40
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0xAD6580 Offset: 0xAD5780 VA: 0x180AD6580
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2430BF0 Offset: 0x242FDF0 VA: 0x182430BF0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD6E40 Offset: 0xAD6040 VA: 0x180AD6E40
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0xAD6EC0 Offset: 0xAD60C0 VA: 0x180AD6EC0
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD6D90 Offset: 0xAD5F90 VA: 0x180AD6D90
	|-_AndroidJNIHelper.GetFieldID<int>
	|-_AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x243B8D0 Offset: 0x243AAD0 VA: 0x18243B8D0
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x243BE40 Offset: 0x243B040 VA: 0x18243BE40
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x243BE10 Offset: 0x243B010 VA: 0x18243BE10
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x243BA40 Offset: 0x243AC40 VA: 0x18243BA40
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x243C0E0 Offset: 0x243B2E0 VA: 0x18243C0E0
	public static string GetSignature(object obj) { }

	// RVA: 0x243BFC0 Offset: 0x243B1C0 VA: 0x18243BFC0
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD6F50 Offset: 0xAD6150 VA: 0x180AD6F50
	|-_AndroidJNIHelper.GetSignature<bool>
	|-_AndroidJNIHelper.GetSignature<char>
	|-_AndroidJNIHelper.GetSignature<double>
	|-_AndroidJNIHelper.GetSignature<short>
	|-_AndroidJNIHelper.GetSignature<int>
	|-_AndroidJNIHelper.GetSignature<long>
	|-_AndroidJNIHelper.GetSignature<object>
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|-_AndroidJNIHelper.GetSignature<float>
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJvalue")]
public struct jvalue // TypeDefIndex: 17241
{
	// Fields
	public bool z; // 0x0
	public sbyte b; // 0x0
	public char c; // 0x0
	public short s; // 0x0
	public int i; // 0x0
	public long j; // 0x0
	public float f; // 0x0
	public double d; // 0x0
	public IntPtr l; // 0x0
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeConditional("PLATFORM_ANDROID")]
public static class AndroidJNIHelper // TypeDefIndex: 17242
{
	// Methods

	// RVA: 0x2430D20 Offset: 0x242FF20 VA: 0x182430D20
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2430D40 Offset: 0x242FF40 VA: 0x182430D40
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2430D30 Offset: 0x242FF30 VA: 0x182430D30
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x2430940 Offset: 0x242FB40 VA: 0x182430940
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x2430720 Offset: 0x242F920 VA: 0x182430720
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x24305F0 Offset: 0x242F7F0 VA: 0x1824305F0
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x2430A40 Offset: 0x242FC40 VA: 0x182430A40
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x2430BF0 Offset: 0x242FDF0 VA: 0x182430BF0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EB9B0 Offset: 0x8EABB0 VA: 0x1808EB9B0
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x8EB9F0 Offset: 0x8EABF0 VA: 0x1808EB9F0
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x8EBA30 Offset: 0x8EAC30 VA: 0x1808EBA30
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x8EBB80 Offset: 0x8EAD80 VA: 0x1808EBB80
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x8EBBC0 Offset: 0x8EADC0 VA: 0x1808EBBC0
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x8EBC00 Offset: 0x8EAE00 VA: 0x1808EBC00
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x8EBC40 Offset: 0x8EAE40 VA: 0x1808EBC40
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x8EBA70 Offset: 0x8EAC70 VA: 0x1808EBA70
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EBD40 Offset: 0x8EAF40 VA: 0x1808EBD40
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x8EBDC0 Offset: 0x8EAFC0 VA: 0x1808EBDC0
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EBCE0 Offset: 0x8EAEE0 VA: 0x1808EBCE0
	|-AndroidJNIHelper.GetFieldID<int>
	|
	|-RVA: 0x8EBC80 Offset: 0x8EAE80 VA: 0x1808EBC80
	|-AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24304C0 Offset: 0x242F6C0 VA: 0x1824304C0
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x2430400 Offset: 0x242F600 VA: 0x182430400
	public static IntPtr Box(int value) { }

	// RVA: 0x2430460 Offset: 0x242F660 VA: 0x182430460
	public static IntPtr Box(bool value) { }
}

// Namespace: UnityEngine
[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
public static class AndroidJNI // TypeDefIndex: 17243
{
	// Methods

	[ThreadSafe]
	// RVA: 0x2434B20 Offset: 0x2433D20 VA: 0x182434B20
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x2434D20 Offset: 0x2433F20 VA: 0x182434D20
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x2434AF0 Offset: 0x2433CF0 VA: 0x182434AF0
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x2434AC0 Offset: 0x2433CC0 VA: 0x182434AC0
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x2435640 Offset: 0x2434840 VA: 0x182435640
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	// RVA: 0x2435600 Offset: 0x2434800 VA: 0x182435600
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	// RVA: 0x24353D0 Offset: 0x24345D0 VA: 0x1824353D0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2435680 Offset: 0x2434880 VA: 0x182435680
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x24355C0 Offset: 0x24347C0 VA: 0x1824355C0
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2434A80 Offset: 0x2433C80 VA: 0x182434A80
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2435410 Offset: 0x2434610 VA: 0x182435410
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2434A40 Offset: 0x2433C40 VA: 0x182434A40
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2435380 Offset: 0x2434580 VA: 0x182435380
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x2435500 Offset: 0x2434700 VA: 0x182435500
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2435450 Offset: 0x2434650 VA: 0x182435450
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x2434F20 Offset: 0x2434120 VA: 0x182434F20
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2434E80 Offset: 0x2434080 VA: 0x182434E80
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x2434E20 Offset: 0x2434020 VA: 0x182434E20
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x24351A0 Offset: 0x24343A0 VA: 0x1824351A0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x2435050 Offset: 0x2434250 VA: 0x182435050
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2435580 Offset: 0x2434780 VA: 0x182435580
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x2435580 Offset: 0x2434780 VA: 0x182435580
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	// RVA: 0x2435340 Offset: 0x2434540 VA: 0x182435340
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x2434970 Offset: 0x2433B70 VA: 0x182434970
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x24348F0 Offset: 0x2433AF0 VA: 0x1824348F0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434890 Offset: 0x2433A90 VA: 0x182434890
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433CC0 Offset: 0x2432EC0 VA: 0x182433CC0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433C60 Offset: 0x2432E60 VA: 0x182433C60
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433B00 Offset: 0x2432D00 VA: 0x182433B00
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433AA0 Offset: 0x2432CA0 VA: 0x182433AA0
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433780 Offset: 0x2432980 VA: 0x182433780
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433720 Offset: 0x2432920 VA: 0x182433720
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433E80 Offset: 0x2433080 VA: 0x182433E80
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433E20 Offset: 0x2433020 VA: 0x182433E20
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433DA0 Offset: 0x2432FA0 VA: 0x182433DA0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433D40 Offset: 0x2432F40 VA: 0x182433D40
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433860 Offset: 0x2432A60 VA: 0x182433860
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433800 Offset: 0x2432A00 VA: 0x182433800
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433A20 Offset: 0x2432C20 VA: 0x182433A20
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x24339C0 Offset: 0x2432BC0 VA: 0x1824339C0
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433940 Offset: 0x2432B40 VA: 0x182433940
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x24338E0 Offset: 0x2432AE0 VA: 0x1824338E0
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433BE0 Offset: 0x2432DE0 VA: 0x182433BE0
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433B80 Offset: 0x2432D80 VA: 0x182433B80
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x24347C0 Offset: 0x24339C0 VA: 0x1824347C0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2434740 Offset: 0x2433940 VA: 0x182434740
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x24346E0 Offset: 0x24338E0 VA: 0x1824346E0
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x24344A0 Offset: 0x24336A0 VA: 0x1824344A0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434440 Offset: 0x2433640 VA: 0x182434440
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x24342E0 Offset: 0x24334E0 VA: 0x1824342E0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434280 Offset: 0x2433480 VA: 0x182434280
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2433F60 Offset: 0x2433160 VA: 0x182433F60
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433F00 Offset: 0x2433100 VA: 0x182433F00
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2434660 Offset: 0x2433860 VA: 0x182434660
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434600 Offset: 0x2433800 VA: 0x182434600
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2434580 Offset: 0x2433780 VA: 0x182434580
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434520 Offset: 0x2433720 VA: 0x182434520
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2434040 Offset: 0x2433240 VA: 0x182434040
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2433FE0 Offset: 0x24331E0 VA: 0x182433FE0
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2434200 Offset: 0x2433400 VA: 0x182434200
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x24341A0 Offset: 0x24333A0 VA: 0x1824341A0
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2434120 Offset: 0x2433320 VA: 0x182434120
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x24340C0 Offset: 0x24332C0 VA: 0x1824340C0
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x24343C0 Offset: 0x24335C0 VA: 0x1824343C0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2434360 Offset: 0x2433560 VA: 0x182434360
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x24352F0 Offset: 0x24344F0 VA: 0x1824352F0
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435200 Offset: 0x2434400 VA: 0x182435200
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2434F60 Offset: 0x2434160 VA: 0x182434F60
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435250 Offset: 0x2434450 VA: 0x182435250
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2434FB0 Offset: 0x24341B0 VA: 0x182434FB0
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x24352A0 Offset: 0x24344A0 VA: 0x1824352A0
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435100 Offset: 0x2434300 VA: 0x182435100
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435150 Offset: 0x2434350 VA: 0x182435150
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x24350B0 Offset: 0x24342B0 VA: 0x1824350B0
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435000 Offset: 0x2434200 VA: 0x182435000
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x2435710 Offset: 0x2434910 VA: 0x182435710
	public static IntPtr ToBooleanArray(bool[] array) { }

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	// RVA: 0x2435750 Offset: 0x2434950 VA: 0x182435750
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2435BD0 Offset: 0x2434DD0 VA: 0x182435BD0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x2435C40 Offset: 0x2434E40 VA: 0x182435C40
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x24357D0 Offset: 0x24349D0 VA: 0x1824357D0
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x2435790 Offset: 0x2434990 VA: 0x182435790
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x2435CC0 Offset: 0x2434EC0 VA: 0x182435CC0
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x2435C80 Offset: 0x2434E80 VA: 0x182435C80
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x24359E0 Offset: 0x2434BE0 VA: 0x1824359E0
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x24359A0 Offset: 0x2434BA0 VA: 0x1824359A0
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x2435A50 Offset: 0x2434C50 VA: 0x182435A50
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x2435AC0 Offset: 0x2434CC0 VA: 0x182435AC0
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x24358F0 Offset: 0x2434AF0 VA: 0x1824358F0
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x2435960 Offset: 0x2434B60 VA: 0x182435960
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x2435840 Offset: 0x2434A40 VA: 0x182435840
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x24358B0 Offset: 0x2434AB0 VA: 0x1824358B0
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x2435B80 Offset: 0x2434D80 VA: 0x182435B80
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x2435B00 Offset: 0x2434D00 VA: 0x182435B00
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	// RVA: 0x2434B60 Offset: 0x2433D60 VA: 0x182434B60
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ThreadSafe]
	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	// RVA: 0x2434BA0 Offset: 0x2433DA0 VA: 0x182434BA0
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434D60 Offset: 0x2433F60 VA: 0x182434D60
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434BE0 Offset: 0x2433DE0 VA: 0x182434BE0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434DA0 Offset: 0x2433FA0 VA: 0x182434DA0
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434CA0 Offset: 0x2433EA0 VA: 0x182434CA0
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434CE0 Offset: 0x2433EE0 VA: 0x182434CE0
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434C60 Offset: 0x2433E60 VA: 0x182434C60
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434C20 Offset: 0x2433E20 VA: 0x182434C20
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2434DE0 Offset: 0x2433FE0 VA: 0x182434DE0
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x24354B0 Offset: 0x24346B0 VA: 0x1824354B0
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2434EE0 Offset: 0x24340E0 VA: 0x182434EE0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x24356C0 Offset: 0x24348C0 VA: 0x1824356C0
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }
}

// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 17244
{
	// Methods

	// RVA: 0x2431F60 Offset: 0x2431160 VA: 0x182431F60
	public static void CheckException() { }

	// RVA: 0x2433160 Offset: 0x2432360 VA: 0x182433160
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x24321D0 Offset: 0x24313D0 VA: 0x1824321D0
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2432180 Offset: 0x2431380 VA: 0x182432180
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x24330F0 Offset: 0x24322F0 VA: 0x1824330F0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2432FB0 Offset: 0x24321B0 VA: 0x182432FB0
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x2432900 Offset: 0x2431B00 VA: 0x182432900
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x2432D20 Offset: 0x2431F20 VA: 0x182432D20
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x24327F0 Offset: 0x24319F0 VA: 0x1824327F0
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2432760 Offset: 0x2431960 VA: 0x182432760
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2432B00 Offset: 0x2431D00 VA: 0x182432B00
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x24325A0 Offset: 0x24317A0 VA: 0x1824325A0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2432220 Offset: 0x2431420 VA: 0x182432220
	public static IntPtr FindClass(string name) { }

	// RVA: 0x2433020 Offset: 0x2432220 VA: 0x182433020
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2432DB0 Offset: 0x2431FB0 VA: 0x182432DB0
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432F30 Offset: 0x2432130 VA: 0x182432F30
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x24329F0 Offset: 0x2431BF0 VA: 0x1824329F0
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432A70 Offset: 0x2431C70 VA: 0x182432A70
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432B90 Offset: 0x2431D90 VA: 0x182432B90
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432CA0 Offset: 0x2431EA0 VA: 0x182432CA0
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432EB0 Offset: 0x24320B0 VA: 0x182432EB0
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432E30 Offset: 0x2432030 VA: 0x182432E30
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432970 Offset: 0x2431B70 VA: 0x182432970
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2432C20 Offset: 0x2431E20 VA: 0x182432C20
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x2431B00 Offset: 0x2430D00 VA: 0x182431B00
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2431A30 Offset: 0x2430C30 VA: 0x182431A30
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431E00 Offset: 0x2431000 VA: 0x182431E00
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2431D30 Offset: 0x2430F30 VA: 0x182431D30
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431610 Offset: 0x2430810 VA: 0x182431610
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x24316E0 Offset: 0x24308E0 VA: 0x1824316E0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x24317C0 Offset: 0x24309C0 VA: 0x1824317C0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431960 Offset: 0x2430B60 VA: 0x182431960
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431C60 Offset: 0x2430E60 VA: 0x182431C60
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431B90 Offset: 0x2430D90 VA: 0x182431B90
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431540 Offset: 0x2430740 VA: 0x182431540
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x24318A0 Offset: 0x2430AA0 VA: 0x1824318A0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431310 Offset: 0x2430510 VA: 0x182431310
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2431240 Offset: 0x2430440 VA: 0x182431240
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431E90 Offset: 0x2431090 VA: 0x182431E90
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2430E20 Offset: 0x2430020 VA: 0x182430E20
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2430EF0 Offset: 0x24300F0 VA: 0x182430EF0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2430FD0 Offset: 0x24301D0 VA: 0x182430FD0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431170 Offset: 0x2430370 VA: 0x182431170
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2431470 Offset: 0x2430670 VA: 0x182431470
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x24313A0 Offset: 0x24305A0 VA: 0x1824313A0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2430D50 Offset: 0x242FF50 VA: 0x182430D50
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x24310B0 Offset: 0x24302B0 VA: 0x1824310B0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2432370 Offset: 0x2431570 VA: 0x182432370
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x24323E0 Offset: 0x24315E0 VA: 0x1824323E0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2432450 Offset: 0x2431650 VA: 0x182432450
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x2432530 Offset: 0x2431730 VA: 0x182432530
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x2432680 Offset: 0x2431880 VA: 0x182432680
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2432300 Offset: 0x2431500 VA: 0x182432300
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2432610 Offset: 0x2431810 VA: 0x182432610
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x2432290 Offset: 0x2431490 VA: 0x182432290
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x24324C0 Offset: 0x24316C0 VA: 0x1824324C0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2433560 Offset: 0x2432760 VA: 0x182433560
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x2433290 Offset: 0x2432490 VA: 0x182433290
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x2433320 Offset: 0x2432520 VA: 0x182433320
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x24333B0 Offset: 0x24325B0 VA: 0x1824333B0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x24334D0 Offset: 0x24326D0 VA: 0x1824334D0
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x2433690 Offset: 0x2432890 VA: 0x182433690
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2433220 Offset: 0x2432420 VA: 0x182433220
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2433600 Offset: 0x2432800 VA: 0x182433600
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x24331B0 Offset: 0x24323B0 VA: 0x1824331B0
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x2433440 Offset: 0x2432640 VA: 0x182433440
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x2432880 Offset: 0x2431A80 VA: 0x182432880
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x24326F0 Offset: 0x24318F0 VA: 0x1824326F0
	public static int GetArrayLength(IntPtr array) { }
}

// Namespace: UnityEngine.Android
[StaticAccessor("AndroidApp", 2)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidApp.bindings.h")]
[NativeConditional("PLATFORM_ANDROID")]
internal static class AndroidApp // TypeDefIndex: 17245
{
	// Properties
	public static IntPtr UnityPlayerRaw { get; }

	// Methods

	[ThreadSafe]
	// RVA: 0x2430330 Offset: 0x242F530 VA: 0x182430330
	public static IntPtr get_UnityPlayerRaw() { }
}

// Namespace: UnityEngine.Android
public enum AndroidAssetPackStatus // TypeDefIndex: 17246
{
	// Fields
	public int value__; // 0x0
	public const AndroidAssetPackStatus Unknown = 0;
	public const AndroidAssetPackStatus Pending = 1;
	public const AndroidAssetPackStatus Downloading = 2;
	public const AndroidAssetPackStatus Transferring = 3;
	public const AndroidAssetPackStatus Completed = 4;
	public const AndroidAssetPackStatus Failed = 5;
	public const AndroidAssetPackStatus Canceled = 6;
	public const AndroidAssetPackStatus WaitingForWifi = 7;
	public const AndroidAssetPackStatus NotInstalled = 8;
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackInfo // TypeDefIndex: 17247
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18

	// Properties
	public string name { get; }
	public AndroidAssetPackStatus status { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public AndroidAssetPackStatus get_status() { }
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackUseMobileDataRequestResult // TypeDefIndex: 17248
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <allowed>k__BackingField; // 0x10

	// Properties
	public bool allowed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_allowed() { }
}

// Namespace: UnityEngine.Android
[StaticAccessor("AndroidAssetPacksBindingsHelpers", 2)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
public static class AndroidAssetPacks // TypeDefIndex: 17249
{
	// Properties
	public static bool coreUnityAssetPacksDownloaded { get; }

	// Methods

	// RVA: 0x2430360 Offset: 0x242F560 VA: 0x182430360
	public static bool get_coreUnityAssetPacksDownloaded() { }

	[NativeConditional("PLATFORM_ANDROID")]
	// RVA: 0x2430360 Offset: 0x242F560 VA: 0x182430360
	private static bool CoreUnityAssetPacksDownloaded() { }

	// RVA: 0x24303C0 Offset: 0x242F5C0 VA: 0x1824303C0
	public static string[] GetCoreUnityAssetPackNames() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void DownloadAssetPackAsync(string[] assetPackNames, Action<AndroidAssetPackInfo> callback) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void RequestToUseMobileDataAsync(Action<AndroidAssetPackUseMobileDataRequestResult> callback) { }

	// RVA: 0x2430390 Offset: 0x242F590 VA: 0x182430390
	public static string GetAssetPackPath(string assetPackName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17250
{}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = False)]
[RequiredByNativeCode]
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 17251
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 17252
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal enum AnimationEventSource // TypeDefIndex: 17253
{
	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference // TypeDefIndex: 17254
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public sealed class AnimationEvent // TypeDefIndex: 17255
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Methods

	// RVA: 0x243E8F0 Offset: 0x243DAF0 VA: 0x18243E8F0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion // TypeDefIndex: 17256
{
	// Properties
	[NativeProperty("Length", False, 0)]
	public float length { get; }
	[NativeProperty("StartTime", False, 0)]
	internal float startTime { get; }
	[NativeProperty("StopTime", False, 0)]
	internal float stopTime { get; }
	[NativeProperty("SampleRate", False, 0)]
	public float frameRate { get; set; }
	[NativeProperty("WrapMode", False, 0)]
	public WrapMode wrapMode { get; set; }
	[NativeProperty("Bounds", False, 0)]
	public Bounds localBounds { get; set; }
	public bool legacy { get; set; }
	public bool humanMotion { get; }
	public bool empty { get; }
	public bool hasGenericRootTransform { get; }
	public bool hasMotionFloatCurves { get; }
	public bool hasMotionCurves { get; }
	public bool hasRootCurves { get; }
	internal bool hasRootMotion { get; }
	public AnimationEvent[] events { get; set; }

	// Methods

	// RVA: 0x243E280 Offset: 0x243D480 VA: 0x18243E280
	public void .ctor() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	// RVA: 0x243E080 Offset: 0x243D280 VA: 0x18243E080
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x243E130 Offset: 0x243D330 VA: 0x18243E130
	public void SampleAnimation(GameObject go, float time) { }

	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	[FreeFunction]
	// RVA: 0x243E0C0 Offset: 0x243D2C0 VA: 0x18243E0C0
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x243E5C0 Offset: 0x243D7C0 VA: 0x18243E5C0
	public float get_length() { }

	// RVA: 0x243E6B0 Offset: 0x243D8B0 VA: 0x18243E6B0
	internal float get_startTime() { }

	// RVA: 0x243E6F0 Offset: 0x243D8F0 VA: 0x18243E6F0
	internal float get_stopTime() { }

	// RVA: 0x243E3C0 Offset: 0x243D5C0 VA: 0x18243E3C0
	public float get_frameRate() { }

	// RVA: 0x243E770 Offset: 0x243D970 VA: 0x18243E770
	public void set_frameRate(float value) { }

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	// RVA: 0x243E1C0 Offset: 0x243D3C0 VA: 0x18243E1C0
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	// RVA: 0x243E000 Offset: 0x243D200 VA: 0x18243E000
	public void EnsureQuaternionContinuity() { }

	// RVA: 0x243DFC0 Offset: 0x243D1C0 VA: 0x18243DFC0
	public void ClearCurves() { }

	// RVA: 0x243E730 Offset: 0x243D930 VA: 0x18243E730
	public WrapMode get_wrapMode() { }

	// RVA: 0x243E8B0 Offset: 0x243DAB0 VA: 0x18243E8B0
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x243E650 Offset: 0x243D850 VA: 0x18243E650
	public Bounds get_localBounds() { }

	// RVA: 0x243E860 Offset: 0x243DA60 VA: 0x18243E860
	public void set_localBounds(Bounds value) { }

	[NativeMethod("IsLegacy")]
	// RVA: 0x243E580 Offset: 0x243D780 VA: 0x18243E580
	public bool get_legacy() { }

	[NativeMethod("SetLegacy")]
	// RVA: 0x243E7C0 Offset: 0x243D9C0 VA: 0x18243E7C0
	public void set_legacy(bool value) { }

	[NativeMethod("IsHumanMotion")]
	// RVA: 0x243E540 Offset: 0x243D740 VA: 0x18243E540
	public bool get_humanMotion() { }

	[NativeMethod("IsEmpty")]
	// RVA: 0x243E2F0 Offset: 0x243D4F0 VA: 0x18243E2F0
	public bool get_empty() { }

	[NativeMethod("HasGenericRootTransform")]
	// RVA: 0x243E400 Offset: 0x243D600 VA: 0x18243E400
	public bool get_hasGenericRootTransform() { }

	[NativeMethod("HasMotionFloatCurves")]
	// RVA: 0x243E480 Offset: 0x243D680 VA: 0x18243E480
	public bool get_hasMotionFloatCurves() { }

	[NativeMethod("HasMotionCurves")]
	// RVA: 0x243E440 Offset: 0x243D640 VA: 0x18243E440
	public bool get_hasMotionCurves() { }

	[NativeMethod("HasRootCurves")]
	// RVA: 0x243E4C0 Offset: 0x243D6C0 VA: 0x18243E4C0
	public bool get_hasRootCurves() { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	// RVA: 0x243E500 Offset: 0x243D700 VA: 0x18243E500
	internal bool get_hasRootMotion() { }

	// RVA: 0x243DF30 Offset: 0x243D130 VA: 0x18243DF30
	public void AddEvent(AnimationEvent evt) { }

	[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = True)]
	// RVA: 0x243DEE0 Offset: 0x243D0E0 VA: 0x18243DEE0
	private void AddEventInternal(object evt) { }

	// RVA: 0x243E330 Offset: 0x243D530 VA: 0x18243E330
	public AnimationEvent[] get_events() { }

	// RVA: 0x243E230 Offset: 0x243D430 VA: 0x18243E230
	public void set_events(AnimationEvent[] value) { }

	[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x243E230 Offset: 0x243D430 VA: 0x18243E230
	private void SetEventsInternal(Array value) { }

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	// RVA: 0x243E040 Offset: 0x243D240 VA: 0x18243E040
	private Array GetEventsInternal() { }

	// RVA: 0x243E600 Offset: 0x243D800 VA: 0x18243E600
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x243E810 Offset: 0x243DA10 VA: 0x18243E810
	private void set_localBounds_Injected(ref Bounds value) { }
}

// Namespace: UnityEngine
public enum AvatarTarget // TypeDefIndex: 17257
{
	// Fields
	public int value__; // 0x0
	public const AvatarTarget Root = 0;
	public const AvatarTarget Body = 1;
	public const AvatarTarget LeftFoot = 2;
	public const AvatarTarget RightFoot = 3;
	public const AvatarTarget LeftHand = 4;
	public const AvatarTarget RightHand = 5;
}

// Namespace: UnityEngine
public enum AvatarIKGoal // TypeDefIndex: 17258
{
	// Fields
	public int value__; // 0x0
	public const AvatarIKGoal LeftFoot = 0;
	public const AvatarIKGoal RightFoot = 1;
	public const AvatarIKGoal LeftHand = 2;
	public const AvatarIKGoal RightHand = 3;
}

// Namespace: UnityEngine
public enum AvatarIKHint // TypeDefIndex: 17259
{
	// Fields
	public int value__; // 0x0
	public const AvatarIKHint LeftKnee = 0;
	public const AvatarIKHint RightKnee = 1;
	public const AvatarIKHint LeftElbow = 2;
	public const AvatarIKHint RightElbow = 3;
}

// Namespace: UnityEngine
public enum AnimatorControllerParameterType // TypeDefIndex: 17260
{
	// Fields
	public int value__; // 0x0
	public const AnimatorControllerParameterType Float = 1;
	public const AnimatorControllerParameterType Int = 3;
	public const AnimatorControllerParameterType Bool = 4;
	public const AnimatorControllerParameterType Trigger = 9;
}

// Namespace: UnityEngine
internal enum StateInfoIndex // TypeDefIndex: 17261
{
	// Fields
	public int value__; // 0x0
	public const StateInfoIndex CurrentState = 0;
	public const StateInfoIndex NextState = 1;
	public const StateInfoIndex ExitState = 2;
	public const StateInfoIndex InterruptedState = 3;
}

// Namespace: UnityEngine
public enum AnimatorRecorderMode // TypeDefIndex: 17262
{
	// Fields
	public int value__; // 0x0
	public const AnimatorRecorderMode Offline = 0;
	public const AnimatorRecorderMode Playback = 1;
	public const AnimatorRecorderMode Record = 2;
}

// Namespace: UnityEngine
public enum AnimatorCullingMode // TypeDefIndex: 17263
{
	// Fields
	public int value__; // 0x0
	public const AnimatorCullingMode AlwaysAnimate = 0;
	public const AnimatorCullingMode CullUpdateTransforms = 1;
	public const AnimatorCullingMode CullCompletely = 2;
}

// Namespace: UnityEngine
public enum AnimatorUpdateMode // TypeDefIndex: 17264
{
	// Fields
	public int value__; // 0x0
	public const AnimatorUpdateMode Normal = 0;
	public const AnimatorUpdateMode AnimatePhysics = 1;
	public const AnimatorUpdateMode UnscaledTime = 2;
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorClipInfo // TypeDefIndex: 17265
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorStateInfo // TypeDefIndex: 17266
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public float normalizedTime { get; }

	// Methods

	// RVA: 0x2440940 Offset: 0x243FB40 VA: 0x182440940
	public bool IsName(string name) { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_normalizedTime() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorTransitionInfo // TypeDefIndex: 17267
{
	// Fields
	[NativeName("fullPathHash")]
	private int m_FullPath; // 0x0
	[NativeName("userNameHash")]
	private int m_UserName; // 0x4
	[NativeName("nameHash")]
	private int m_Name; // 0x8
	[NativeName("hasFixedDuration")]
	private bool m_HasFixedDuration; // 0xC
	[NativeName("duration")]
	private float m_Duration; // 0x10
	[NativeName("normalizedTime")]
	private float m_NormalizedTime; // 0x14
	[NativeName("anyState")]
	private bool m_AnyState; // 0x18
	[NativeName("transitionType")]
	private int m_TransitionType; // 0x1C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Animator.h")]
public struct MatchTargetWeightMask // TypeDefIndex: 17268
{
	// Fields
	private Vector3 m_PositionXYZWeight; // 0x0
	private float m_RotationWeight; // 0xC
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/Animator.h")]
public class Animator : Behaviour // TypeDefIndex: 17269
{
	// Properties
	public bool isOptimizable { get; }
	public bool isHuman { get; }
	public bool hasRootMotion { get; }
	internal bool isRootPositionOrRotationControlledByCurves { get; }
	public float humanScale { get; }
	public bool isInitialized { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public Vector3 velocity { get; }
	public Vector3 angularVelocity { get; }
	public Vector3 rootPosition { get; set; }
	public Quaternion rootRotation { get; set; }
	public bool applyRootMotion { get; set; }
	[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
	public bool linearVelocityBlending { get; set; }
	[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
	public bool animatePhysics { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public bool hasTransformHierarchy { get; }
	internal bool allowConstantClipSamplingOptimization { get; set; }
	public float gravityWeight { get; }
	public Vector3 bodyPosition { get; set; }
	internal Vector3 bodyPositionInternal { get; set; }
	public Quaternion bodyRotation { get; set; }
	internal Quaternion bodyRotationInternal { get; set; }
	public bool stabilizeFeet { get; set; }
	public int layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public int parameterCount { get; }
	public float feetPivotActive { get; set; }
	public float pivotWeight { get; }
	public Vector3 pivotPosition { get; }
	public bool isMatchingTarget { get; }
	public float speed { get; set; }
	public Vector3 targetPosition { get; }
	public Quaternion targetRotation { get; }
	public Transform avatarRoot { get; }
	public AnimatorCullingMode cullingMode { get; set; }
	public float playbackTime { get; set; }
	public float recorderStartTime { get; set; }
	public float recorderStopTime { get; set; }
	public AnimatorRecorderMode recorderMode { get; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool layersAffectMassCenter { get; set; }
	public float leftFeetBottomHeight { get; }
	public float rightFeetBottomHeight { get; }
	[NativeConditional("UNITY_EDITOR")]
	internal bool supportsOnAnimatorMove { get; }
	public bool logWarnings { get; set; }
	public bool fireEvents { get; set; }
	[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
	public bool keepAnimatorControllerStateOnDisable { get; set; }
	public bool keepAnimatorStateOnDisable { get; set; }
	public bool writeDefaultValuesOnDisable { get; set; }

	// Methods

	[NativeMethod("IsOptimizable")]
	// RVA: 0x2444E30 Offset: 0x2444030 VA: 0x182444E30
	public bool get_isOptimizable() { }

	[NativeMethod("IsHuman")]
	// RVA: 0x2444D70 Offset: 0x2443F70 VA: 0x182444D70
	public bool get_isHuman() { }

	[NativeMethod("HasRootMotion")]
	// RVA: 0x2444CB0 Offset: 0x2443EB0 VA: 0x182444CB0
	public bool get_hasRootMotion() { }

	[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
	// RVA: 0x2444E70 Offset: 0x2444070 VA: 0x182444E70
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x2444D30 Offset: 0x2443F30 VA: 0x182444D30
	public float get_humanScale() { }

	[NativeMethod("IsInitialized")]
	// RVA: 0x2444DB0 Offset: 0x2443FB0 VA: 0x182444DB0
	public bool get_isInitialized() { }

	// RVA: 0x2441E00 Offset: 0x2441000 VA: 0x182441E00
	public float GetFloat(string name) { }

	// RVA: 0x2441DC0 Offset: 0x2440FC0 VA: 0x182441DC0
	public float GetFloat(int id) { }

	// RVA: 0x24438B0 Offset: 0x2442AB0 VA: 0x1824438B0
	public void SetFloat(string name, float value) { }

	// RVA: 0x2443840 Offset: 0x2442A40 VA: 0x182443840
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x24437F0 Offset: 0x24429F0 VA: 0x1824437F0
	public void SetFloat(int id, float value) { }

	// RVA: 0x2443790 Offset: 0x2442990 VA: 0x182443790
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x2441AF0 Offset: 0x2440CF0 VA: 0x182441AF0
	public bool GetBool(string name) { }

	// RVA: 0x2441AB0 Offset: 0x2440CB0 VA: 0x182441AB0
	public bool GetBool(int id) { }

	// RVA: 0x2443730 Offset: 0x2442930 VA: 0x182443730
	public void SetBool(string name, bool value) { }

	// RVA: 0x24436D0 Offset: 0x24428D0 VA: 0x1824436D0
	public void SetBool(int id, bool value) { }

	// RVA: 0x24423F0 Offset: 0x24415F0 VA: 0x1824423F0
	public int GetInteger(string name) { }

	// RVA: 0x24423B0 Offset: 0x24415B0 VA: 0x1824423B0
	public int GetInteger(int id) { }

	// RVA: 0x2443EA0 Offset: 0x24430A0 VA: 0x182443EA0
	public void SetInteger(string name, int value) { }

	// RVA: 0x2443E50 Offset: 0x2443050 VA: 0x182443E50
	public void SetInteger(int id, int value) { }

	// RVA: 0x24443C0 Offset: 0x24435C0 VA: 0x1824443C0
	public void SetTrigger(string name) { }

	// RVA: 0x2444380 Offset: 0x2443580 VA: 0x182444380
	public void SetTrigger(int id) { }

	// RVA: 0x2443510 Offset: 0x2442710 VA: 0x182443510
	public void ResetTrigger(string name) { }

	// RVA: 0x24434D0 Offset: 0x24426D0 VA: 0x1824434D0
	public void ResetTrigger(int id) { }

	// RVA: 0x2442C60 Offset: 0x2441E60 VA: 0x182442C60
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x2442C20 Offset: 0x2441E20 VA: 0x182442C20
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x2444AC0 Offset: 0x2443CC0 VA: 0x182444AC0
	public Vector3 get_deltaPosition() { }

	// RVA: 0x2444B60 Offset: 0x2443D60 VA: 0x182444B60
	public Quaternion get_deltaRotation() { }

	// RVA: 0x24456C0 Offset: 0x24448C0 VA: 0x1824456C0
	public Vector3 get_velocity() { }

	// RVA: 0x24446B0 Offset: 0x24438B0 VA: 0x1824446B0
	public Vector3 get_angularVelocity() { }

	[NativeMethod("GetAvatarPosition")]
	// RVA: 0x2445300 Offset: 0x2444500 VA: 0x182445300
	public Vector3 get_rootPosition() { }

	[NativeMethod("SetAvatarPosition")]
	// RVA: 0x2445D50 Offset: 0x2444F50 VA: 0x182445D50
	public void set_rootPosition(Vector3 value) { }

	[NativeMethod("GetAvatarRotation")]
	// RVA: 0x24453A0 Offset: 0x24445A0 VA: 0x1824453A0
	public Quaternion get_rootRotation() { }

	[NativeMethod("SetAvatarRotation")]
	// RVA: 0x2445DF0 Offset: 0x2444FF0 VA: 0x182445DF0
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x2444740 Offset: 0x2443940 VA: 0x182444740
	public bool get_applyRootMotion() { }

	// RVA: 0x24457F0 Offset: 0x24449F0 VA: 0x1824457F0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x2444FB0 Offset: 0x24441B0 VA: 0x182444FB0
	public bool get_linearVelocityBlending() { }

	// RVA: 0x2445C10 Offset: 0x2444E10 VA: 0x182445C10
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x2444700 Offset: 0x2443900 VA: 0x182444700
	public bool get_animatePhysics() { }

	// RVA: 0x24457A0 Offset: 0x24449A0 VA: 0x1824457A0
	public void set_animatePhysics(bool value) { }

	// RVA: 0x2445630 Offset: 0x2444830 VA: 0x182445630
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x2445F30 Offset: 0x2445130 VA: 0x182445F30
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x2444CF0 Offset: 0x2443EF0 VA: 0x182444CF0
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x2444620 Offset: 0x2443820 VA: 0x182444620
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x2445750 Offset: 0x2444950 VA: 0x182445750
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x2444C30 Offset: 0x2443E30 VA: 0x182444C30
	public float get_gravityWeight() { }

	// RVA: 0x24448A0 Offset: 0x2443AA0 VA: 0x1824448A0
	public Vector3 get_bodyPosition() { }

	// RVA: 0x2445930 Offset: 0x2444B30 VA: 0x182445930
	public void set_bodyPosition(Vector3 value) { }

	[NativeMethod("GetBodyPosition")]
	// RVA: 0x2444850 Offset: 0x2443A50 VA: 0x182444850
	internal Vector3 get_bodyPositionInternal() { }

	[NativeMethod("SetBodyPosition")]
	// RVA: 0x24458E0 Offset: 0x2444AE0 VA: 0x1824458E0
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x24449C0 Offset: 0x2443BC0 VA: 0x1824449C0
	public Quaternion get_bodyRotation() { }

	// RVA: 0x2445A30 Offset: 0x2444C30 VA: 0x182445A30
	public void set_bodyRotation(Quaternion value) { }

	[NativeMethod("GetBodyRotation")]
	// RVA: 0x2444970 Offset: 0x2443B70 VA: 0x182444970
	internal Quaternion get_bodyRotationInternal() { }

	[NativeMethod("SetBodyRotation")]
	// RVA: 0x24459E0 Offset: 0x2444BE0 VA: 0x1824459E0
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x2442250 Offset: 0x2441450 VA: 0x182442250
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x2441EA0 Offset: 0x24410A0 VA: 0x182441EA0
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x2443D10 Offset: 0x2442F10 VA: 0x182443D10
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x2443960 Offset: 0x2442B60 VA: 0x182443960
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x2442330 Offset: 0x2441530 VA: 0x182442330
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x2441F50 Offset: 0x2441150 VA: 0x182441F50
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x2443DE0 Offset: 0x2442FE0 VA: 0x182443DE0
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x2443A00 Offset: 0x2442C00 VA: 0x182443A00
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x2442200 Offset: 0x2441400 VA: 0x182442200
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x2441FB0 Offset: 0x24411B0 VA: 0x182441FB0
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x2443CB0 Offset: 0x2442EB0 VA: 0x182443CB0
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x2443A50 Offset: 0x2442C50 VA: 0x182443A50
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x24422E0 Offset: 0x24414E0 VA: 0x1824422E0
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x2441FF0 Offset: 0x24411F0 VA: 0x182441FF0
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x2443D80 Offset: 0x2442F80 VA: 0x182443D80
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x2443AA0 Offset: 0x2442CA0 VA: 0x182443AA0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x2442170 Offset: 0x2441370 VA: 0x182442170
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x2442080 Offset: 0x2441280 VA: 0x182442080
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x2443C40 Offset: 0x2442E40 VA: 0x182443C40
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x2443B40 Offset: 0x2442D40 VA: 0x182443B40
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x2442120 Offset: 0x2441320 VA: 0x182442120
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x24420E0 Offset: 0x24412E0 VA: 0x1824420E0
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x2443BE0 Offset: 0x2442DE0 VA: 0x182443BE0
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x2443B90 Offset: 0x2442D90 VA: 0x182443B90
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x2443FF0 Offset: 0x24431F0 VA: 0x182443FF0
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod("SetLookAtPosition")]
	// RVA: 0x2443FA0 Offset: 0x24431A0 VA: 0x182443FA0
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x24442C0 Offset: 0x24434C0 VA: 0x1824442C0
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x24440C0 Offset: 0x24432C0 VA: 0x1824440C0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2444230 Offset: 0x2443430 VA: 0x182444230
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2444140 Offset: 0x2443340 VA: 0x182444140
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x24441C0 Offset: 0x24433C0 VA: 0x1824441C0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethod("SetLookAtWeight")]
	// RVA: 0x2444050 Offset: 0x2443250 VA: 0x182444050
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2443640 Offset: 0x2442840 VA: 0x182443640
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethod("SetBoneLocalRotation")]
	// RVA: 0x24435F0 Offset: 0x24427F0 VA: 0x1824435F0
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x2441630 Offset: 0x2440830 VA: 0x182441630
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: -1 Offset: -1
	public T GetBehaviour<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98DA10 Offset: 0x98CC10 VA: 0x18098DA10
	|-Animator.GetBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	private static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98D8E0 Offset: 0x98CAE0 VA: 0x18098D8E0
	|-Animator.ConvertStateMachineBehaviour<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetBehaviours<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x98DB00 Offset: 0x98CD00 VA: 0x18098DB00
	|-Animator.GetBehaviours<object>
	*/

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	// RVA: 0x2442A70 Offset: 0x2441C70 VA: 0x182442A70
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x2441680 Offset: 0x2440880 VA: 0x182441680
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = True)]
	// RVA: 0x2442A10 Offset: 0x2441C10 VA: 0x182442A10
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x2445470 Offset: 0x2444670 VA: 0x182445470
	public bool get_stabilizeFeet() { }

	// RVA: 0x2445EE0 Offset: 0x24450E0 VA: 0x182445EE0
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x2444EF0 Offset: 0x24440F0 VA: 0x182444EF0
	public int get_layerCount() { }

	// RVA: 0x2442490 Offset: 0x2441690 VA: 0x182442490
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x2442440 Offset: 0x2441640 VA: 0x182442440
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x24424D0 Offset: 0x24416D0 VA: 0x1824424D0
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x2443F00 Offset: 0x2443100 VA: 0x182443F00
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x24414A0 Offset: 0x24406A0 VA: 0x1824414A0
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x2441C80 Offset: 0x2440E80 VA: 0x182441C80
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x2442650 Offset: 0x2441850 VA: 0x182442650
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x2441560 Offset: 0x2440760 VA: 0x182441560
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x24415B0 Offset: 0x24407B0 VA: 0x1824415B0
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x24413D0 Offset: 0x24405D0 VA: 0x1824413D0
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x2441B40 Offset: 0x2440D40 VA: 0x182441B40
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x2442510 Offset: 0x2441710 VA: 0x182442510
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
	// RVA: 0x2441C40 Offset: 0x2440E40 VA: 0x182441C40
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
	// RVA: 0x2442610 Offset: 0x2441810 VA: 0x182442610
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x2441B90 Offset: 0x2440D90 VA: 0x182441B90
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	// RVA: 0x2441430 Offset: 0x2440630 VA: 0x182441430
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x2442560 Offset: 0x2441760 VA: 0x182442560
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	// RVA: 0x2442BE0 Offset: 0x2441DE0 VA: 0x182442BE0
	public bool IsInTransition(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	// RVA: 0x2445070 Offset: 0x2444270 VA: 0x182445070
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x2445030 Offset: 0x2444230 VA: 0x182445030
	public int get_parameterCount() { }

	[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = True)]
	// RVA: 0x2442740 Offset: 0x2441940 VA: 0x182442740
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x2442780 Offset: 0x2441980 VA: 0x182442780
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x2444BB0 Offset: 0x2443DB0 VA: 0x182444BB0
	public float get_feetPivotActive() { }

	// RVA: 0x2445AD0 Offset: 0x2444CD0 VA: 0x182445AD0
	public void set_feetPivotActive(float value) { }

	// RVA: 0x2445150 Offset: 0x2444350 VA: 0x182445150
	public float get_pivotWeight() { }

	// RVA: 0x2445100 Offset: 0x2444300 VA: 0x182445100
	public Vector3 get_pivotPosition() { }

	// RVA: 0x2442E90 Offset: 0x2442090 VA: 0x182442E90
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x2442DE0 Offset: 0x2441FE0 VA: 0x182442DE0
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x2442D30 Offset: 0x2441F30 VA: 0x182442D30
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x2442F30 Offset: 0x2442130 VA: 0x182442F30
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x2442B10 Offset: 0x2441D10 VA: 0x182442B10
	public void InterruptMatchTarget() { }

	// RVA: 0x2442AC0 Offset: 0x2441CC0 VA: 0x182442AC0
	public void InterruptMatchTarget(bool completeMatch) { }

	[NativeMethod("IsMatchingTarget")]
	// RVA: 0x2444DF0 Offset: 0x2443FF0 VA: 0x182444DF0
	public bool get_isMatchingTarget() { }

	// RVA: 0x2445430 Offset: 0x2444630 VA: 0x182445430
	public float get_speed() { }

	// RVA: 0x2445E90 Offset: 0x2445090 VA: 0x182445E90
	public void set_speed(float value) { }

	[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
	// RVA: 0x2441380 Offset: 0x2440580 VA: 0x182441380
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x2440E40 Offset: 0x2440040 VA: 0x182440E40
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x2440BB0 Offset: 0x243FDB0 VA: 0x182440BB0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x2440CB0 Offset: 0x243FEB0 VA: 0x182440CB0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x2440DB0 Offset: 0x243FFB0 VA: 0x182440DB0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x2440D40 Offset: 0x243FF40 VA: 0x182440D40
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x2440AD0 Offset: 0x243FCD0 VA: 0x182440AD0
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x2440B40 Offset: 0x243FD40 VA: 0x182440B40
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	// RVA: 0x2440C50 Offset: 0x243FE50 VA: 0x182440C50
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
	// RVA: 0x24445E0 Offset: 0x24437E0 VA: 0x1824445E0
	public void WriteDefaultValues() { }

	// RVA: 0x2440FF0 Offset: 0x24401F0 VA: 0x182440FF0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x2440F50 Offset: 0x2440150 VA: 0x182440F50
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x2441150 Offset: 0x2440350 VA: 0x182441150
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x24411F0 Offset: 0x24403F0 VA: 0x1824411F0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	// RVA: 0x2441080 Offset: 0x2440280 VA: 0x182441080
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x2441280 Offset: 0x2440480 VA: 0x182441280
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x2440ED0 Offset: 0x24400D0 VA: 0x182440ED0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x24410E0 Offset: 0x24402E0 VA: 0x1824410E0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x2443180 Offset: 0x2442380 VA: 0x182443180
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x24430C0 Offset: 0x24422C0 VA: 0x1824430C0
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x24430F0 Offset: 0x24422F0 VA: 0x1824430F0
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	// RVA: 0x24431A0 Offset: 0x24423A0 VA: 0x1824431A0
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x2443060 Offset: 0x2442260 VA: 0x182443060
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x2443200 Offset: 0x2442400 VA: 0x182443200
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x2443370 Offset: 0x2442570 VA: 0x182443370
	public void Play(string stateName, int layer) { }

	// RVA: 0x2443250 Offset: 0x2442450 VA: 0x182443250
	public void Play(string stateName) { }

	// RVA: 0x24432E0 Offset: 0x24424E0 VA: 0x1824432E0
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	// RVA: 0x2443280 Offset: 0x2442480 VA: 0x182443280
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x2443390 Offset: 0x2442590 VA: 0x182443390
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x24433F0 Offset: 0x24425F0 VA: 0x1824433F0
	public void Play(int stateNameHash) { }

	// RVA: 0x2444330 Offset: 0x2443530 VA: 0x182444330
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x2445540 Offset: 0x2444740 VA: 0x182445540
	public Vector3 get_targetPosition() { }

	// RVA: 0x24455E0 Offset: 0x24447E0 VA: 0x1824455E0
	public Quaternion get_targetRotation() { }

	[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
	[EditorBrowsable(1)]
	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0
	public bool IsControlled(Transform transform) { }

	// RVA: 0x2442B50 Offset: 0x2441D50 VA: 0x182442B50
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x2444780 Offset: 0x2443980 VA: 0x182444780
	public Transform get_avatarRoot() { }

	// RVA: 0x2441790 Offset: 0x2440990 VA: 0x182441790
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	// RVA: 0x2441750 Offset: 0x2440950 VA: 0x182441750
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x2444A30 Offset: 0x2443C30 VA: 0x182444A30
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x2445A90 Offset: 0x2444C90 VA: 0x182445A90
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x2444410 Offset: 0x2443610 VA: 0x182444410
	public void StartPlayback() { }

	// RVA: 0x2444490 Offset: 0x2443690 VA: 0x182444490
	public void StopPlayback() { }

	// RVA: 0x24451F0 Offset: 0x24443F0 VA: 0x1824451F0
	public float get_playbackTime() { }

	// RVA: 0x2445CB0 Offset: 0x2444EB0 VA: 0x182445CB0
	public void set_playbackTime(float value) { }

	// RVA: 0x2444450 Offset: 0x2443650 VA: 0x182444450
	public void StartRecording(int frameCount) { }

	// RVA: 0x24444D0 Offset: 0x24436D0 VA: 0x1824444D0
	public void StopRecording() { }

	// RVA: 0x24428A0 Offset: 0x2441AA0 VA: 0x1824428A0
	public float get_recorderStartTime() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_recorderStartTime(float value) { }

	// RVA: 0x24428A0 Offset: 0x2441AA0 VA: 0x1824428A0
	private float GetRecorderStartTime() { }

	// RVA: 0x24428E0 Offset: 0x2441AE0 VA: 0x1824428E0
	public float get_recorderStopTime() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_recorderStopTime(float value) { }

	// RVA: 0x24428E0 Offset: 0x2441AE0 VA: 0x1824428E0
	private float GetRecorderStopTime() { }

	// RVA: 0x2445230 Offset: 0x2444430 VA: 0x182445230
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x24453F0 Offset: 0x24445F0 VA: 0x1824453F0
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x2445E40 Offset: 0x2445040 VA: 0x182445E40
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethod("HasBoundPlayables")]
	// RVA: 0x2444C70 Offset: 0x2443E70 VA: 0x182444C70
	public bool get_hasBoundPlayables() { }

	// RVA: 0x2440A90 Offset: 0x243FC90 VA: 0x182440A90
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x24429C0 Offset: 0x2441BC0 VA: 0x1824429C0
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	// RVA: 0x2444510 Offset: 0x2443710 VA: 0x182444510
	public static int StringToHash(string name) { }

	// RVA: 0x24447C0 Offset: 0x24439C0 VA: 0x1824447C0
	public Avatar get_avatar() { }

	// RVA: 0x2445840 Offset: 0x2444A40 VA: 0x182445840
	public void set_avatar(Avatar value) { }

	// RVA: 0x2442920 Offset: 0x2441B20 VA: 0x182442920
	internal string GetStats() { }

	// RVA: 0x2445190 Offset: 0x2444390 VA: 0x182445190
	public PlayableGraph get_playableGraph() { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = True)]
	// RVA: 0x2441D20 Offset: 0x2440F20 VA: 0x182441D20
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0x24409E0 Offset: 0x243FBE0 VA: 0x1824409E0
	private void CheckIfInIKPass() { }

	// RVA: 0x2442BA0 Offset: 0x2441DA0 VA: 0x182442BA0
	private bool IsInIKPass() { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	// RVA: 0x24438B0 Offset: 0x2442AB0 VA: 0x1824438B0
	private void SetFloatString(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	// RVA: 0x24437F0 Offset: 0x24429F0 VA: 0x1824437F0
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	// RVA: 0x2441E00 Offset: 0x2441000 VA: 0x182441E00
	private float GetFloatString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	// RVA: 0x2441DC0 Offset: 0x2440FC0 VA: 0x182441DC0
	private float GetFloatID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	// RVA: 0x2443730 Offset: 0x2442930 VA: 0x182443730
	private void SetBoolString(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	// RVA: 0x24436D0 Offset: 0x24428D0 VA: 0x1824436D0
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	// RVA: 0x2441AF0 Offset: 0x2440CF0 VA: 0x182441AF0
	private bool GetBoolString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	// RVA: 0x2441AB0 Offset: 0x2440CB0 VA: 0x182441AB0
	private bool GetBoolID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	// RVA: 0x2443EA0 Offset: 0x24430A0 VA: 0x182443EA0
	private void SetIntegerString(string name, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	// RVA: 0x2443E50 Offset: 0x2443050 VA: 0x182443E50
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	// RVA: 0x24423F0 Offset: 0x24415F0 VA: 0x1824423F0
	private int GetIntegerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	// RVA: 0x24423B0 Offset: 0x24415B0 VA: 0x1824423B0
	private int GetIntegerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	// RVA: 0x24443C0 Offset: 0x24435C0 VA: 0x1824443C0
	private void SetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	// RVA: 0x2444380 Offset: 0x2443580 VA: 0x182444380
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	// RVA: 0x2443510 Offset: 0x2442710 VA: 0x182443510
	private void ResetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	// RVA: 0x24434D0 Offset: 0x24426D0 VA: 0x1824434D0
	private void ResetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	// RVA: 0x2442C60 Offset: 0x2441E60 VA: 0x182442C60
	private bool IsParameterControlledByCurveString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	// RVA: 0x2442C20 Offset: 0x2441E20 VA: 0x182442C20
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = True)]
	// RVA: 0x2443840 Offset: 0x2442A40 VA: 0x182443840
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	// RVA: 0x2443790 Offset: 0x2442990 VA: 0x182443790
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x2444F30 Offset: 0x2444130 VA: 0x182444F30
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x2445BC0 Offset: 0x2444DC0 VA: 0x182445BC0
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x2444F70 Offset: 0x2444170 VA: 0x182444F70
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x2445270 Offset: 0x2444470 VA: 0x182445270
	public float get_rightFeetBottomHeight() { }

	[NativeMethod("SupportsOnAnimatorMove")]
	// RVA: 0x24454B0 Offset: 0x24446B0 VA: 0x1824454B0
	internal bool get_supportsOnAnimatorMove() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2443020 Offset: 0x2442220 VA: 0x182443020
	internal void OnUpdateModeChanged() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2442FE0 Offset: 0x24421E0 VA: 0x182442FE0
	internal void OnCullingModeChanged() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24445A0 Offset: 0x24437A0 VA: 0x1824445A0
	internal void WriteDefaultPose() { }

	[NativeMethod("UpdateWithDelta")]
	// RVA: 0x2444550 Offset: 0x2443750 VA: 0x182444550
	public void Update(float deltaTime) { }

	// RVA: 0x2443440 Offset: 0x2442640 VA: 0x182443440
	public void Rebind() { }

	// RVA: 0x2443480 Offset: 0x2442680 VA: 0x182443480
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x24409A0 Offset: 0x243FBA0 VA: 0x1824409A0
	public void ApplyBuiltinRootMotion() { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2441340 Offset: 0x2440540 VA: 0x182441340
	internal void EvaluateController() { }

	// RVA: 0x24412F0 Offset: 0x24404F0 VA: 0x1824412F0
	private void EvaluateController(float deltaTime) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2441D70 Offset: 0x2440F70 VA: 0x182441D70
	internal string GetCurrentStateName(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x24426F0 Offset: 0x24418F0 VA: 0x1824426F0
	internal string GetNextStateName(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2441500 Offset: 0x2440700 VA: 0x182441500
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x2443560 Offset: 0x2442760 VA: 0x182443560
	internal string ResolveHash(int hash) { }

	// RVA: 0x2444FF0 Offset: 0x24441F0 VA: 0x182444FF0
	public bool get_logWarnings() { }

	// RVA: 0x2445C60 Offset: 0x2444E60 VA: 0x182445C60
	public void set_logWarnings(bool value) { }

	// RVA: 0x2444BF0 Offset: 0x2443DF0 VA: 0x182444BF0
	public bool get_fireEvents() { }

	// RVA: 0x2445B20 Offset: 0x2444D20 VA: 0x182445B20
	public void set_fireEvents(bool value) { }

	// RVA: 0x2444EB0 Offset: 0x24440B0 VA: 0x182444EB0
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x2445B70 Offset: 0x2444D70 VA: 0x182445B70
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x2444EB0 Offset: 0x24440B0 VA: 0x182444EB0
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x2445B70 Offset: 0x2444D70 VA: 0x182445B70
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x2445710 Offset: 0x2444910 VA: 0x182445710
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x2445F70 Offset: 0x2445170 VA: 0x182445F70
	public void set_writeDefaultValuesOnDisable(bool value) { }

	[Obsolete("GetVector is deprecated.")]
	// RVA: 0x2442960 Offset: 0x2441B60 VA: 0x182442960
	public Vector3 GetVector(string name) { }

	[Obsolete("GetVector is deprecated.")]
	// RVA: 0x2442960 Offset: 0x2441B60 VA: 0x182442960
	public Vector3 GetVector(int id) { }

	[Obsolete("SetVector is deprecated.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetVector(string name, Vector3 value) { }

	[Obsolete("SetVector is deprecated.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetVector(int id, Vector3 value) { }

	[Obsolete("GetQuaternion is deprecated.")]
	// RVA: 0x2442850 Offset: 0x2441A50 VA: 0x182442850
	public Quaternion GetQuaternion(string name) { }

	[Obsolete("GetQuaternion is deprecated.")]
	// RVA: 0x2442850 Offset: 0x2441A50 VA: 0x182442850
	public Quaternion GetQuaternion(int id) { }

	[Obsolete("SetQuaternion is deprecated.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetQuaternion(string name, Quaternion value) { }

	[Obsolete("SetQuaternion is deprecated.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x2444A70 Offset: 0x2443C70 VA: 0x182444A70
	private void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2444B10 Offset: 0x2443D10 VA: 0x182444B10
	private void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2445670 Offset: 0x2444870 VA: 0x182445670
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2444660 Offset: 0x2443860 VA: 0x182444660
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x24452B0 Offset: 0x24444B0 VA: 0x1824452B0
	private void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2445D00 Offset: 0x2444F00 VA: 0x182445D00
	private void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0x2445350 Offset: 0x2444550 VA: 0x182445350
	private void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2445DA0 Offset: 0x2444FA0 VA: 0x182445DA0
	private void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0x2444800 Offset: 0x2443A00 VA: 0x182444800
	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0x2445890 Offset: 0x2444A90 VA: 0x182445890
	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0x2444920 Offset: 0x2443B20 VA: 0x182444920
	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0x2445990 Offset: 0x2444B90 VA: 0x182445990
	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0x2441E50 Offset: 0x2441050 VA: 0x182441E50
	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0x2443910 Offset: 0x2442B10 VA: 0x182443910
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x2441F00 Offset: 0x2441100 VA: 0x182441F00
	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0x24439B0 Offset: 0x2442BB0 VA: 0x1824439B0
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x2442030 Offset: 0x2441230 VA: 0x182442030
	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0x2443AF0 Offset: 0x2442CF0 VA: 0x182443AF0
	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0x2443F50 Offset: 0x2443150 VA: 0x182443F50
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x24435A0 Offset: 0x24427A0 VA: 0x1824435A0
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	// RVA: 0x24450B0 Offset: 0x24442B0 VA: 0x1824450B0
	private void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2442CB0 Offset: 0x2441EB0 VA: 0x182442CB0
	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x24454F0 Offset: 0x24446F0 VA: 0x1824454F0
	private void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2445590 Offset: 0x2444790 VA: 0x182445590
	private void get_targetRotation_Injected(out Quaternion ret) { }
}

// Namespace: UnityEngine
[NativeType(1, "MonoAnimatorControllerParameter")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeAsStruct]
public class AnimatorControllerParameter // TypeDefIndex: 17270
{
	// Fields
	internal string m_Name; // 0x10
	internal AnimatorControllerParameterType m_Type; // 0x18
	internal float m_DefaultFloat; // 0x1C
	internal int m_DefaultInt; // 0x20
	internal bool m_DefaultBool; // 0x24

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public string get_name() { }

	// RVA: 0x243FC90 Offset: 0x243EE90 VA: 0x18243FC90 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x243FD70 Offset: 0x243EF70 VA: 0x18243FD70
	public void .ctor() { }
}

// Namespace: 
internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 17271
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[DefaultMember("Item")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 17272
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public RuntimeAnimatorController runtimeAnimatorController { set; }
	public int overridesCount { get; }

	// Methods

	// RVA: 0x2440830 Offset: 0x243FA30 VA: 0x182440830
	public void .ctor() { }

	[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
	// RVA: 0x24406F0 Offset: 0x243F8F0 VA: 0x1824406F0
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	[NativeMethod("SetAnimatorController")]
	// RVA: 0x24408F0 Offset: 0x243FAF0 VA: 0x1824408F0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x24407C0 Offset: 0x243F9C0 VA: 0x1824407C0
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x2440780 Offset: 0x243F980 VA: 0x182440780
	private void SendNotification() { }

	// RVA: 0x2440420 Offset: 0x243F620 VA: 0x182440420
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x2440460 Offset: 0x243F660 VA: 0x182440460
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	[NativeMethod("GetOriginalClipsCount")]
	// RVA: 0x24408B0 Offset: 0x243FAB0 VA: 0x1824408B0
	public int get_overridesCount() { }

	// RVA: 0x24404B0 Offset: 0x243F6B0 VA: 0x1824404B0
	public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	// RVA: 0x2440140 Offset: 0x243F340 VA: 0x182440140
	public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	// RVA: 0x2440740 Offset: 0x243F940 VA: 0x182440740
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

// Namespace: UnityEngine
public enum HumanBodyBones // TypeDefIndex: 17273
{
	// Fields
	public int value__; // 0x0
	public const HumanBodyBones Hips = 0;
	public const HumanBodyBones LeftUpperLeg = 1;
	public const HumanBodyBones RightUpperLeg = 2;
	public const HumanBodyBones LeftLowerLeg = 3;
	public const HumanBodyBones RightLowerLeg = 4;
	public const HumanBodyBones LeftFoot = 5;
	public const HumanBodyBones RightFoot = 6;
	public const HumanBodyBones Spine = 7;
	public const HumanBodyBones Chest = 8;
	public const HumanBodyBones UpperChest = 54;
	public const HumanBodyBones Neck = 9;
	public const HumanBodyBones Head = 10;
	public const HumanBodyBones LeftShoulder = 11;
	public const HumanBodyBones RightShoulder = 12;
	public const HumanBodyBones LeftUpperArm = 13;
	public const HumanBodyBones RightUpperArm = 14;
	public const HumanBodyBones LeftLowerArm = 15;
	public const HumanBodyBones RightLowerArm = 16;
	public const HumanBodyBones LeftHand = 17;
	public const HumanBodyBones RightHand = 18;
	public const HumanBodyBones LeftToes = 19;
	public const HumanBodyBones RightToes = 20;
	public const HumanBodyBones LeftEye = 21;
	public const HumanBodyBones RightEye = 22;
	public const HumanBodyBones Jaw = 23;
	public const HumanBodyBones LeftThumbProximal = 24;
	public const HumanBodyBones LeftThumbIntermediate = 25;
	public const HumanBodyBones LeftThumbDistal = 26;
	public const HumanBodyBones LeftIndexProximal = 27;
	public const HumanBodyBones LeftIndexIntermediate = 28;
	public const HumanBodyBones LeftIndexDistal = 29;
	public const HumanBodyBones LeftMiddleProximal = 30;
	public const HumanBodyBones LeftMiddleIntermediate = 31;
	public const HumanBodyBones LeftMiddleDistal = 32;
	public const HumanBodyBones LeftRingProximal = 33;
	public const HumanBodyBones LeftRingIntermediate = 34;
	public const HumanBodyBones LeftRingDistal = 35;
	public const HumanBodyBones LeftLittleProximal = 36;
	public const HumanBodyBones LeftLittleIntermediate = 37;
	public const HumanBodyBones LeftLittleDistal = 38;
	public const HumanBodyBones RightThumbProximal = 39;
	public const HumanBodyBones RightThumbIntermediate = 40;
	public const HumanBodyBones RightThumbDistal = 41;
	public const HumanBodyBones RightIndexProximal = 42;
	public const HumanBodyBones RightIndexIntermediate = 43;
	public const HumanBodyBones RightIndexDistal = 44;
	public const HumanBodyBones RightMiddleProximal = 45;
	public const HumanBodyBones RightMiddleIntermediate = 46;
	public const HumanBodyBones RightMiddleDistal = 47;
	public const HumanBodyBones RightRingProximal = 48;
	public const HumanBodyBones RightRingIntermediate = 49;
	public const HumanBodyBones RightRingDistal = 50;
	public const HumanBodyBones RightLittleProximal = 51;
	public const HumanBodyBones RightLittleIntermediate = 52;
	public const HumanBodyBones RightLittleDistal = 53;
	public const HumanBodyBones LastBone = 55;
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Avatar.h")]
[UsedByNativeCode]
public class Avatar : Object // TypeDefIndex: 17274
{
	// Properties
	public bool isValid { get; }
	public bool isHuman { get; }

	// Methods

	// RVA: 0x2445FC0 Offset: 0x24451C0 VA: 0x182445FC0
	private void .ctor() { }

	[NativeMethod("IsValid")]
	// RVA: 0x2446050 Offset: 0x2445250 VA: 0x182446050
	public bool get_isValid() { }

	[NativeMethod("IsHuman")]
	// RVA: 0x2446010 Offset: 0x2445210 VA: 0x182446010
	public bool get_isHuman() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanDescription.h")]
[RequiredByNativeCode]
[NativeType(1, "MonoSkeletonBone")]
public struct SkeletonBone // TypeDefIndex: 17275
{
	// Fields
	[NativeName("m_Name")]
	public string name; // 0x0
	[NativeName("m_ParentName")]
	internal string parentName; // 0x8
	[NativeName("m_Position")]
	public Vector3 position; // 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; // 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; // 0x2C
}

// Namespace: UnityEngine
[NativeType(1, "MonoHumanLimit")]
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanLimit // TypeDefIndex: 17276
{
	// Fields
	private Vector3 m_Min; // 0x0
	private Vector3 m_Max; // 0xC
	private Vector3 m_Center; // 0x18
	private float m_AxisLength; // 0x24
	private int m_UseDefaultValues; // 0x28
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeType(1, "MonoHumanBone")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
public struct HumanBone // TypeDefIndex: 17277
{
	// Fields
	private string m_BoneName; // 0x0
	private string m_HumanName; // 0x8
	[NativeName("m_Limit")]
	public HumanLimit limit; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanTrait.h")]
public class HumanTrait // TypeDefIndex: 17278
{
	// Methods

	// RVA: 0x2446090 Offset: 0x2445290 VA: 0x182446090
	internal static int GetBoneIndexFromMono(int humanId) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : Object // TypeDefIndex: 17279
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Properties
	public bool isLooping { get; }

	// Methods

	// RVA: 0x24460D0 Offset: 0x24452D0 VA: 0x1824460D0
	protected void .ctor() { }

	[NativeMethod("IsLooping")]
	// RVA: 0x2446120 Offset: 0x2445320 VA: 0x182446120
	public bool get_isLooping() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[ExcludeFromObjectFactory]
[UsedByNativeCode]
public class RuntimeAnimatorController : Object // TypeDefIndex: 17280
{
	// Properties
	public AnimationClip[] animationClips { get; }

	// Methods

	// RVA: 0x2446160 Offset: 0x2445360 VA: 0x182446160
	protected void .ctor() { }

	// RVA: 0x24461B0 Offset: 0x24453B0 VA: 0x1824461B0
	public AnimationClip[] get_animationClips() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(256)]
public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 17281
{}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(260)]
public class NotKeyableAttribute : Attribute // TypeDefIndex: 17282
{}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 17283
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243DE50 Offset: 0x243D050 VA: 0x18243DE50 Slot: 4
	public bool Equals(AnimationClipPlayable other) { }
}

// Namespace: UnityEngine.Animations
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
public struct AnimationHumanStream // TypeDefIndex: 17284
{
	// Fields
	private IntPtr stream; // 0x0
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationLayerMixerPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 17285
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243EAD0 Offset: 0x243DCD0 VA: 0x18243EAD0
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243E950 Offset: 0x243DB50 VA: 0x18243E950 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x243E9F0 Offset: 0x243DBF0 VA: 0x18243E9F0
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x243EA40 Offset: 0x243DC40 VA: 0x18243EA40
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationMixerPlayableBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 17286
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243EDF0 Offset: 0x243DFF0 VA: 0x18243EDF0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243EC10 Offset: 0x243DE10 VA: 0x18243EC10 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x243ECB0 Offset: 0x243DEB0 VA: 0x18243ECB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", 2)]
[RequiredByNativeCode]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 17287
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243F0B0 Offset: 0x243E2B0 VA: 0x18243F0B0
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243EED0 Offset: 0x243E0D0 VA: 0x18243EED0 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x243EF70 Offset: 0x243E170 VA: 0x18243EF70
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", 2)]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 17288
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243F370 Offset: 0x243E570 VA: 0x18243F370
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243F190 Offset: 0x243E390 VA: 0x18243F190 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x243F230 Offset: 0x243E430 VA: 0x18243F230
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Animator.h")]
[StaticAccessor("AnimationPlayableOutputBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
public struct AnimationPlayableOutput // TypeDefIndex: 17289
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationPosePlayableBindings", 2)]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 17290
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243F630 Offset: 0x243E830 VA: 0x18243F630
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243F450 Offset: 0x243E650 VA: 0x18243F450 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x243F4F0 Offset: 0x243E6F0 VA: 0x18243F4F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[StaticAccessor("AnimationRemoveScalePlayableBindings", 2)]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 17291
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243F8F0 Offset: 0x243EAF0 VA: 0x18243F8F0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243F710 Offset: 0x243E910 VA: 0x18243F710 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x243F7B0 Offset: 0x243E9B0 VA: 0x18243F7B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 17292
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x243FBB0 Offset: 0x243EDB0 VA: 0x18243FBB0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243F9D0 Offset: 0x243EBD0 VA: 0x18243F9D0 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x243FA70 Offset: 0x243EC70 VA: 0x18243FA70
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
public struct AnimationStream // TypeDefIndex: 17293
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[StaticAccessor("AnimatorControllerPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 17294
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x24400A0 Offset: 0x243F2A0 VA: 0x1824400A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x243DED0 Offset: 0x243D0D0 VA: 0x18243DED0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x243FE50 Offset: 0x243F050 VA: 0x18243FE50
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x243FDB0 Offset: 0x243EFB0 VA: 0x18243FDB0 Slot: 4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x243FFA0 Offset: 0x243F1A0 VA: 0x18243FFA0
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17295
{}

// Namespace: 
public struct ParticleSystem.MainModule // TypeDefIndex: 17296
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public float duration { get; }
	public bool loop { get; set; }
	public float startDelayMultiplier { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public float startSpeedMultiplier { get; set; }
	[NativeName("StartSizeXMultiplier")]
	public float startSizeMultiplier { get; set; }
	[NativeName("StartRotationZMultiplier")]
	public float startRotationMultiplier { get; set; }
	public float startRotationXMultiplier { get; set; }
	public float startRotationYMultiplier { get; set; }
	public float startRotationZMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public float simulationSpeed { get; set; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public bool playOnAwake { get; set; }
	public int maxParticles { get; set; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x24E3360 Offset: 0x24E2560 VA: 0x1824E3360
	public float get_duration() { }

	// RVA: 0x24E33E0 Offset: 0x24E25E0 VA: 0x1824E33E0
	public bool get_loop() { }

	[NativeThrows]
	// RVA: 0x24E3860 Offset: 0x24E2A60 VA: 0x1824E3860
	public void set_loop(bool value) { }

	// RVA: 0x24E3610 Offset: 0x24E2810 VA: 0x1824E3610
	public float get_startDelayMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3AB0 Offset: 0x24E2CB0 VA: 0x1824E3AB0
	public void set_startDelayMultiplier(float value) { }

	// RVA: 0x24E3650 Offset: 0x24E2850 VA: 0x1824E3650
	public float get_startLifetimeMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3B00 Offset: 0x24E2D00 VA: 0x1824E3B00
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x24E37D0 Offset: 0x24E29D0 VA: 0x1824E37D0
	public float get_startSpeedMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3CE0 Offset: 0x24E2EE0 VA: 0x1824E3CE0
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x24E3790 Offset: 0x24E2990 VA: 0x1824E3790
	public float get_startSizeMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3C90 Offset: 0x24E2E90 VA: 0x1824E3C90
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x24E3690 Offset: 0x24E2890 VA: 0x1824E3690
	public float get_startRotationMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3B50 Offset: 0x24E2D50 VA: 0x1824E3B50
	public void set_startRotationMultiplier(float value) { }

	// RVA: 0x24E36D0 Offset: 0x24E28D0 VA: 0x1824E36D0
	public float get_startRotationXMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3BA0 Offset: 0x24E2DA0 VA: 0x1824E3BA0
	public void set_startRotationXMultiplier(float value) { }

	// RVA: 0x24E3710 Offset: 0x24E2910 VA: 0x1824E3710
	public float get_startRotationYMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3BF0 Offset: 0x24E2DF0 VA: 0x1824E3BF0
	public void set_startRotationYMultiplier(float value) { }

	// RVA: 0x24E3750 Offset: 0x24E2950 VA: 0x1824E3750
	public float get_startRotationZMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3C40 Offset: 0x24E2E40 VA: 0x1824E3C40
	public void set_startRotationZMultiplier(float value) { }

	// RVA: 0x24E35B0 Offset: 0x24E27B0 VA: 0x1824E35B0
	public ParticleSystem.MinMaxGradient get_startColor() { }

	[NativeThrows]
	// RVA: 0x24E3A60 Offset: 0x24E2C60 VA: 0x1824E3A60
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x24E33A0 Offset: 0x24E25A0 VA: 0x1824E33A0
	public float get_gravityModifierMultiplier() { }

	[NativeThrows]
	// RVA: 0x24E3810 Offset: 0x24E2A10 VA: 0x1824E3810
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x24E34E0 Offset: 0x24E26E0 VA: 0x1824E34E0
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	[NativeThrows]
	// RVA: 0x24E3980 Offset: 0x24E2B80 VA: 0x1824E3980
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x24E3520 Offset: 0x24E2720 VA: 0x1824E3520
	public float get_simulationSpeed() { }

	[NativeThrows]
	// RVA: 0x24E39C0 Offset: 0x24E2BC0 VA: 0x1824E39C0
	public void set_simulationSpeed(float value) { }

	// RVA: 0x24E34A0 Offset: 0x24E26A0 VA: 0x1824E34A0
	public ParticleSystemScalingMode get_scalingMode() { }

	[NativeThrows]
	// RVA: 0x24E3940 Offset: 0x24E2B40 VA: 0x1824E3940
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x24E3460 Offset: 0x24E2660 VA: 0x1824E3460
	public bool get_playOnAwake() { }

	[NativeThrows]
	// RVA: 0x24E38F0 Offset: 0x24E2AF0 VA: 0x1824E38F0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x24E3420 Offset: 0x24E2620 VA: 0x1824E3420
	public int get_maxParticles() { }

	[NativeThrows]
	// RVA: 0x24E38B0 Offset: 0x24E2AB0 VA: 0x1824E38B0
	public void set_maxParticles(int value) { }

	// RVA: 0x24E3360 Offset: 0x24E2560 VA: 0x1824E3360
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E33E0 Offset: 0x24E25E0 VA: 0x1824E33E0
	private static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3860 Offset: 0x24E2A60 VA: 0x1824E3860
	private static void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x24E3610 Offset: 0x24E2810 VA: 0x1824E3610
	private static float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3AB0 Offset: 0x24E2CB0 VA: 0x1824E3AB0
	private static void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3650 Offset: 0x24E2850 VA: 0x1824E3650
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3B00 Offset: 0x24E2D00 VA: 0x1824E3B00
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E37D0 Offset: 0x24E29D0 VA: 0x1824E37D0
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3CE0 Offset: 0x24E2EE0 VA: 0x1824E3CE0
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3790 Offset: 0x24E2990 VA: 0x1824E3790
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3C90 Offset: 0x24E2E90 VA: 0x1824E3C90
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3690 Offset: 0x24E2890 VA: 0x1824E3690
	private static float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3B50 Offset: 0x24E2D50 VA: 0x1824E3B50
	private static void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E36D0 Offset: 0x24E28D0 VA: 0x1824E36D0
	private static float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3BA0 Offset: 0x24E2DA0 VA: 0x1824E3BA0
	private static void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3710 Offset: 0x24E2910 VA: 0x1824E3710
	private static float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3BF0 Offset: 0x24E2DF0 VA: 0x1824E3BF0
	private static void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3750 Offset: 0x24E2950 VA: 0x1824E3750
	private static float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3C40 Offset: 0x24E2E40 VA: 0x1824E3C40
	private static void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E3560 Offset: 0x24E2760 VA: 0x1824E3560
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x24E3A10 Offset: 0x24E2C10 VA: 0x1824E3A10
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x24E33A0 Offset: 0x24E25A0 VA: 0x1824E33A0
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3810 Offset: 0x24E2A10 VA: 0x1824E3810
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E34E0 Offset: 0x24E26E0 VA: 0x1824E34E0
	private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3980 Offset: 0x24E2B80 VA: 0x1824E3980
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x24E3520 Offset: 0x24E2720 VA: 0x1824E3520
	private static float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E39C0 Offset: 0x24E2BC0 VA: 0x1824E39C0
	private static void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x24E34A0 Offset: 0x24E26A0 VA: 0x1824E34A0
	private static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E3940 Offset: 0x24E2B40 VA: 0x1824E3940
	private static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value) { }

	// RVA: 0x24E3460 Offset: 0x24E2660 VA: 0x1824E3460
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E38F0 Offset: 0x24E2AF0 VA: 0x1824E38F0
	private static void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x24E3420 Offset: 0x24E2620 VA: 0x1824E3420
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x24E38B0 Offset: 0x24E2AB0 VA: 0x1824E38B0
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }
}

// Namespace: 
public struct ParticleSystem.EmissionModule // TypeDefIndex: 17297
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { set; }
	public float rateOverTimeMultiplier { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x24E31F0 Offset: 0x24E23F0 VA: 0x1824E31F0
	public bool get_enabled() { }

	[NativeThrows]
	// RVA: 0x24E3270 Offset: 0x24E2470 VA: 0x1824E3270
	public void set_enabled(bool value) { }

	[NativeThrows]
	// RVA: 0x24E3310 Offset: 0x24E2510 VA: 0x1824E3310
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x24E3230 Offset: 0x24E2430 VA: 0x1824E3230
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x24E31F0 Offset: 0x24E23F0 VA: 0x1824E31F0
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x24E3270 Offset: 0x24E2470 VA: 0x1824E3270
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x24E32C0 Offset: 0x24E24C0 VA: 0x1824E32C0
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x24E3230 Offset: 0x24E2430 VA: 0x1824E3230
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }
}

// Namespace: 
public struct ParticleSystem.ShapeModule // TypeDefIndex: 17298
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public MeshRenderer meshRenderer { get; set; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x24E8EF0 Offset: 0x24E80F0 VA: 0x1824E8EF0
	public MeshRenderer get_meshRenderer() { }

	[NativeThrows]
	// RVA: 0x24E8F30 Offset: 0x24E8130 VA: 0x1824E8F30
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x24E8EF0 Offset: 0x24E80F0 VA: 0x1824E8EF0
	private static MeshRenderer get_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x24E8F30 Offset: 0x24E8130 VA: 0x1824E8F30
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }
}

// Namespace: 
public struct ParticleSystem.CollisionModule // TypeDefIndex: 17299
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TriggerModule // TypeDefIndex: 17300
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SubEmittersModule // TypeDefIndex: 17301
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TextureSheetAnimationModule // TypeDefIndex: 17302
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
[RequiredByNativeCode("particleSystemParticle", Optional = True)]
public struct ParticleSystem.Particle // TypeDefIndex: 17303
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x24E8E70 Offset: 0x24E8070 VA: 0x1824E8E70
	public void set_lifetime(float value) { }

	// RVA: 0xAA0CC0 Offset: 0xA9FEC0 VA: 0x180AA0CC0
	public void set_position(Vector3 value) { }

	// RVA: 0x244D3F0 Offset: 0x244C5F0 VA: 0x18244D3F0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x24E8E70 Offset: 0x24E8070 VA: 0x1824E8E70
	public void set_remainingLifetime(float value) { }

	// RVA: 0x24E8EC0 Offset: 0x24E80C0 VA: 0x1824E8EC0
	public void set_startLifetime(float value) { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_startColor(Color32 value) { }

	// RVA: 0x677720 Offset: 0x676920 VA: 0x180677720
	public void set_randomSeed(uint value) { }

	// RVA: 0x24E8ED0 Offset: 0x24E80D0 VA: 0x1824E8ED0
	public void set_startSize(float value) { }

	// RVA: 0x24E8E80 Offset: 0x24E8080 VA: 0x1824E8E80
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x24E8E30 Offset: 0x24E8030 VA: 0x1824E8E30
	public void set_angularVelocity3D(Vector3 value) { }
}

// Namespace: 
[NativeType(1, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 17304
{
	// Fields
	[SerializeField]
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField]
	private float m_CurveMultiplier; // 0x4
	[SerializeField]
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField]
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField]
	private float m_ConstantMin; // 0x18
	[SerializeField]
	private float m_ConstantMax; // 0x1C

	// Methods

	// RVA: 0x24E3D30 Offset: 0x24E2F30 VA: 0x1824E3D30
	public void .ctor(float constant) { }

	// RVA: 0x24E3D50 Offset: 0x24E2F50 VA: 0x1824E3D50
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }
}

// Namespace: 
[NativeType(1, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 17305
{
	// Fields
	[SerializeField]
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField]
	private Gradient m_GradientMin; // 0x8
	[SerializeField]
	private Gradient m_GradientMax; // 0x10
	[SerializeField]
	private Color m_ColorMin; // 0x18
	[SerializeField]
	private Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x24E3DA0 Offset: 0x24E2FA0 VA: 0x1824E3DA0
	public void .ctor(Color color) { }

	// RVA: 0x24E3DC0 Offset: 0x24E2FC0 VA: 0x1824E3DC0
	public Color get_color() { }

	// RVA: 0x24E3DD0 Offset: 0x24E2FD0 VA: 0x1824E3DD0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }
}

// Namespace: 
public struct ParticleSystem.EmitParams // TypeDefIndex: 17306
{
	// Fields
	[NativeName("particle")]
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeName("positionSet")]
	private bool m_PositionSet; // 0x84
	[NativeName("velocitySet")]
	private bool m_VelocitySet; // 0x85
	[NativeName("axisOfRotationSet")]
	private bool m_AxisOfRotationSet; // 0x86
	[NativeName("rotationSet")]
	private bool m_RotationSet; // 0x87
	[NativeName("rotationalSpeedSet")]
	private bool m_AngularVelocitySet; // 0x88
	[NativeName("startSizeSet")]
	private bool m_StartSizeSet; // 0x89
	[NativeName("startColorSet")]
	private bool m_StartColorSet; // 0x8A
	[NativeName("randomSeedSet")]
	private bool m_RandomSeedSet; // 0x8B
	[NativeName("startLifetimeSet")]
	private bool m_StartLifetimeSet; // 0x8C
	[NativeName("meshIndexSet")]
	private bool m_MeshIndexSet; // 0x8D
	[NativeName("applyShapeToPosition")]
	private bool m_ApplyShapeToPosition; // 0x8E
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed // TypeDefIndex: 17307
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed4 // TypeDefIndex: 17308
{
	// Fields
	public ParticleSystem.PlaybackState.Seed x; // 0x0
	public ParticleSystem.PlaybackState.Seed y; // 0x10
	public ParticleSystem.PlaybackState.Seed z; // 0x20
	public ParticleSystem.PlaybackState.Seed w; // 0x30
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Emission // TypeDefIndex: 17309
{
	// Fields
	public float m_ParticleSpacing; // 0x0
	public float m_ToEmitAccumulator; // 0x4
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x8
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Initial // TypeDefIndex: 17310
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Shape // TypeDefIndex: 17311
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
	public float m_RadiusTimer; // 0x40
	public float m_RadiusTimerPrev; // 0x44
	public float m_ArcTimer; // 0x48
	public float m_ArcTimerPrev; // 0x4C
	public float m_MeshSpawnTimer; // 0x50
	public float m_MeshSpawnTimerPrev; // 0x54
	public int m_OrderedMeshVertexIndex; // 0x58
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Force // TypeDefIndex: 17312
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Collision // TypeDefIndex: 17313
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Noise // TypeDefIndex: 17314
{
	// Fields
	public float m_ScrollOffset; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Lights // TypeDefIndex: 17315
{
	// Fields
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x0
	public float m_ParticleEmissionCounter; // 0x10
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Trail // TypeDefIndex: 17316
{
	// Fields
	public float m_Timer; // 0x0
}

// Namespace: 
public struct ParticleSystem.PlaybackState // TypeDefIndex: 17317
{
	// Fields
	internal float m_AccumulatedDt; // 0x0
	internal float m_StartDelay; // 0x4
	internal float m_PlaybackTime; // 0x8
	internal int m_RingBufferIndex; // 0xC
	internal ParticleSystem.PlaybackState.Emission m_Emission; // 0x10
	internal ParticleSystem.PlaybackState.Initial m_Initial; // 0x28
	internal ParticleSystem.PlaybackState.Shape m_Shape; // 0x68
	internal ParticleSystem.PlaybackState.Force m_Force; // 0xC4
	internal ParticleSystem.PlaybackState.Collision m_Collision; // 0x104
	internal ParticleSystem.PlaybackState.Noise m_Noise; // 0x144
	internal ParticleSystem.PlaybackState.Lights m_Lights; // 0x148
	internal ParticleSystem.PlaybackState.Trail m_Trail; // 0x15C
}

// Namespace: 
[NativeType(1, "MonoParticleTrails")]
public struct ParticleSystem.Trails // TypeDefIndex: 17318
{
	// Fields
	internal List<Vector4> positions; // 0x0
	internal List<int> frontPositions; // 0x8
	internal List<int> backPositions; // 0x10
	internal List<int> positionCounts; // 0x18
	internal List<float> textureOffsets; // 0x20
	internal int maxTrailCount; // 0x28
	internal int maxPositionsPerTrailCount; // 0x2C

	// Methods

	// RVA: 0x24E8F80 Offset: 0x24E8180 VA: 0x1824E8F80
	internal void Allocate() { }
}

// Namespace: 
public struct ParticleSystem.VelocityOverLifetimeModule // TypeDefIndex: 17319
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LimitVelocityOverLifetimeModule // TypeDefIndex: 17320
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.InheritVelocityModule // TypeDefIndex: 17321
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LifetimeByEmitterSpeedModule // TypeDefIndex: 17322
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ForceOverLifetimeModule // TypeDefIndex: 17323
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 17324
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorBySpeedModule // TypeDefIndex: 17325
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeOverLifetimeModule // TypeDefIndex: 17326
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeBySpeedModule // TypeDefIndex: 17327
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationOverLifetimeModule // TypeDefIndex: 17328
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationBySpeedModule // TypeDefIndex: 17329
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ExternalForcesModule // TypeDefIndex: 17330
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.NoiseModule // TypeDefIndex: 17331
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LightsModule // TypeDefIndex: 17332
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TrailModule // TypeDefIndex: 17333
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.CustomDataModule // TypeDefIndex: 17334
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[UsedByNativeCode]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("ParticleSystemScriptingClasses.h")]
public sealed class ParticleSystem : Component // TypeDefIndex: 17335
{
	// Properties
	[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
	public float startDelay { get; set; }
	[Obsolete("loop property is deprecated. Use main.loop instead.", False)]
	public bool loop { get; set; }
	[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
	public bool playOnAwake { get; set; }
	[Obsolete("duration property is deprecated. Use main.duration instead.", False)]
	public float duration { get; }
	[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
	public float playbackSpeed { get; set; }
	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	public bool enableEmission { get; set; }
	[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
	public float emissionRate { get; set; }
	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	public float startSpeed { get; set; }
	[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
	public float startSize { get; set; }
	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor { get; set; }
	[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
	public float startRotation { get; set; }
	[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
	public Vector3 startRotation3D { get; set; }
	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	public float startLifetime { get; set; }
	[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
	public float gravityModifier { get; set; }
	[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
	public int maxParticles { get; set; }
	[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
	public ParticleSystemScalingMode scalingMode { get; set; }
	[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
	public bool automaticCullingEnabled { get; }
	public bool isPlaying { get; }
	public bool isEmitting { get; }
	public bool isStopped { get; }
	public bool isPaused { get; }
	public int particleCount { get; }
	public float time { get; set; }
	public float totalTime { get; }
	public uint randomSeed { get; set; }
	public bool useAutoRandomSeed { get; set; }
	public bool proceduralSimulationSupported { get; }
	public bool has3DParticleRotations { get; }
	public bool hasNonUniformParticleSizes { get; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
	public ParticleSystem.InheritVelocityModule inheritVelocity { get; }
	public ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; }
	public ParticleSystem.ForceOverLifetimeModule forceOverLifetime { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.ColorBySpeedModule colorBySpeed { get; }
	public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime { get; }
	public ParticleSystem.SizeBySpeedModule sizeBySpeed { get; }
	public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime { get; }
	public ParticleSystem.RotationBySpeedModule rotationBySpeed { get; }
	public ParticleSystem.ExternalForcesModule externalForces { get; }
	public ParticleSystem.NoiseModule noise { get; }
	public ParticleSystem.CollisionModule collision { get; }
	public ParticleSystem.TriggerModule trigger { get; }
	public ParticleSystem.SubEmittersModule subEmitters { get; }
	public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
	public ParticleSystem.LightsModule lights { get; }
	public ParticleSystem.TrailModule trails { get; }
	public ParticleSystem.CustomDataModule customData { get; }

	// Methods

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x24E6740 Offset: 0x24E5940 VA: 0x1824E6740
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x24E68F0 Offset: 0x24E5AF0 VA: 0x1824E68F0
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x24E8510 Offset: 0x24E7710 VA: 0x1824E8510
	public float get_startDelay() { }

	// RVA: 0x24E8B60 Offset: 0x24E7D60 VA: 0x1824E8B60
	public void set_startDelay(float value) { }

	// RVA: 0x24E82A0 Offset: 0x24E74A0 VA: 0x1824E82A0
	public bool get_loop() { }

	// RVA: 0x24E88F0 Offset: 0x24E7AF0 VA: 0x1824E88F0
	public void set_loop(bool value) { }

	// RVA: 0x24E8360 Offset: 0x24E7560 VA: 0x1824E8360
	public bool get_playOnAwake() { }

	// RVA: 0x24E8970 Offset: 0x24E7B70 VA: 0x1824E8970
	public void set_playOnAwake(bool value) { }

	// RVA: 0x24E8020 Offset: 0x24E7220 VA: 0x1824E8020
	public float get_duration() { }

	// RVA: 0x24E83A0 Offset: 0x24E75A0 VA: 0x1824E83A0
	public float get_playbackSpeed() { }

	// RVA: 0x24E89B0 Offset: 0x24E7BB0 VA: 0x1824E89B0
	public void set_playbackSpeed(float value) { }

	// RVA: 0x24E80A0 Offset: 0x24E72A0 VA: 0x1824E80A0
	public bool get_enableEmission() { }

	// RVA: 0x24E8860 Offset: 0x24E7A60 VA: 0x1824E8860
	public void set_enableEmission(bool value) { }

	// RVA: 0x24E8060 Offset: 0x24E7260 VA: 0x1824E8060
	public float get_emissionRate() { }

	// RVA: 0x24E87E0 Offset: 0x24E79E0 VA: 0x1824E87E0
	public void set_emissionRate(float value) { }

	// RVA: 0x24E86E0 Offset: 0x24E78E0 VA: 0x1824E86E0
	public float get_startSpeed() { }

	// RVA: 0x24E8D40 Offset: 0x24E7F40 VA: 0x1824E8D40
	public void set_startSpeed(float value) { }

	// RVA: 0x24E86A0 Offset: 0x24E78A0 VA: 0x1824E86A0
	public float get_startSize() { }

	// RVA: 0x24E8CF0 Offset: 0x24E7EF0 VA: 0x1824E8CF0
	public void set_startSize(float value) { }

	// RVA: 0x24E84A0 Offset: 0x24E76A0 VA: 0x1824E84A0
	public Color get_startColor() { }

	// RVA: 0x24E8AC0 Offset: 0x24E7CC0 VA: 0x1824E8AC0
	public void set_startColor(Color value) { }

	// RVA: 0x24E8660 Offset: 0x24E7860 VA: 0x1824E8660
	public float get_startRotation() { }

	// RVA: 0x24E8CA0 Offset: 0x24E7EA0 VA: 0x1824E8CA0
	public void set_startRotation(float value) { }

	// RVA: 0x24E8590 Offset: 0x24E7790 VA: 0x1824E8590
	public Vector3 get_startRotation3D() { }

	// RVA: 0x24E8C00 Offset: 0x24E7E00 VA: 0x1824E8C00
	public void set_startRotation3D(Vector3 value) { }

	// RVA: 0x24E8550 Offset: 0x24E7750 VA: 0x1824E8550
	public float get_startLifetime() { }

	// RVA: 0x24E8BB0 Offset: 0x24E7DB0 VA: 0x1824E8BB0
	public void set_startLifetime(float value) { }

	// RVA: 0x24E80E0 Offset: 0x24E72E0 VA: 0x1824E80E0
	public float get_gravityModifier() { }

	// RVA: 0x24E88A0 Offset: 0x24E7AA0 VA: 0x1824E88A0
	public void set_gravityModifier(float value) { }

	// RVA: 0x24E82E0 Offset: 0x24E74E0 VA: 0x1824E82E0
	public int get_maxParticles() { }

	// RVA: 0x24E8930 Offset: 0x24E7B30 VA: 0x1824E8930
	public void set_maxParticles(int value) { }

	// RVA: 0x24E8460 Offset: 0x24E7660 VA: 0x1824E8460
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x24E8A80 Offset: 0x24E7C80 VA: 0x1824E8A80
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x24E8420 Offset: 0x24E7620 VA: 0x1824E8420
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x24E8A40 Offset: 0x24E7C40 VA: 0x1824E8A40
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x24E7FE0 Offset: 0x24E71E0 VA: 0x1824E7FE0
	public bool get_automaticCullingEnabled() { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	// RVA: 0x24E8220 Offset: 0x24E7420 VA: 0x1824E8220
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->IsEmitting")]
	// RVA: 0x24E81A0 Offset: 0x24E73A0 VA: 0x1824E81A0
	public bool get_isEmitting() { }

	[NativeName("SyncJobs(false)->IsStopped")]
	// RVA: 0x24E8260 Offset: 0x24E7460 VA: 0x1824E8260
	public bool get_isStopped() { }

	[NativeName("SyncJobs(false)->IsPaused")]
	// RVA: 0x24E81E0 Offset: 0x24E73E0 VA: 0x1824E81E0
	public bool get_isPaused() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	// RVA: 0x24E8320 Offset: 0x24E7520 VA: 0x1824E8320
	public int get_particleCount() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	// RVA: 0x24E8720 Offset: 0x24E7920 VA: 0x1824E8720
	public float get_time() { }

	[NativeName("SyncJobs(false)->SetSecPosition")]
	// RVA: 0x24E8D90 Offset: 0x24E7F90 VA: 0x1824E8D90
	public void set_time(float value) { }

	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	// RVA: 0x24E8760 Offset: 0x24E7960 VA: 0x1824E8760
	public float get_totalTime() { }

	[NativeName("GetRandomSeed")]
	// RVA: 0x24E83E0 Offset: 0x24E75E0 VA: 0x1824E83E0
	public uint get_randomSeed() { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	// RVA: 0x24E8A00 Offset: 0x24E7C00 VA: 0x1824E8A00
	public void set_randomSeed(uint value) { }

	[NativeName("GetAutoRandomSeed")]
	// RVA: 0x24E87A0 Offset: 0x24E79A0 VA: 0x1824E87A0
	public bool get_useAutoRandomSeed() { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	// RVA: 0x24E8DE0 Offset: 0x24E7FE0 VA: 0x1824E8DE0
	public void set_useAutoRandomSeed(bool value) { }

	// RVA: 0x24E7FE0 Offset: 0x24E71E0 VA: 0x1824E7FE0
	public bool get_proceduralSimulationSupported() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	// RVA: 0x24E6C60 Offset: 0x24E5E60 VA: 0x1824E6C60
	internal float GetParticleCurrentSize(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = True)]
	// RVA: 0x24E6C00 Offset: 0x24E5E00 VA: 0x1824E6C00
	internal Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	// RVA: 0x24E6B40 Offset: 0x24E5D40 VA: 0x1824E6B40
	internal Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = True)]
	// RVA: 0x24E6CB0 Offset: 0x24E5EB0 VA: 0x1824E6CB0
	internal int GetParticleMeshIndex(ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E7900 Offset: 0x24E6B00 VA: 0x1824E7900
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x24E78A0 Offset: 0x24E6AA0 VA: 0x1824E78A0
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x24E7700 Offset: 0x24E6900 VA: 0x1824E7700
	public void SetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E7690 Offset: 0x24E6890 VA: 0x1824E7690
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x24E7970 Offset: 0x24E6B70 VA: 0x1824E7970
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x24E77F0 Offset: 0x24E69F0 VA: 0x1824E77F0
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x24E7750 Offset: 0x24E6950 VA: 0x1824E7750
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E6FD0 Offset: 0x24E61D0 VA: 0x1824E6FD0
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x24E7040 Offset: 0x24E6240 VA: 0x1824E7040
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x24E6D70 Offset: 0x24E5F70 VA: 0x1824E6D70
	public int GetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E6D00 Offset: 0x24E5F00 VA: 0x1824E6D00
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x24E6F10 Offset: 0x24E6110 VA: 0x1824E6F10
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x24E6E60 Offset: 0x24E6060 VA: 0x1824E6E60
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x24E6DC0 Offset: 0x24E5FC0 VA: 0x1824E6DC0
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E7550 Offset: 0x24E6750 VA: 0x1824E7550
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24E69A0 Offset: 0x24E5BA0 VA: 0x1824E69A0
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x24E70F0 Offset: 0x24E62F0 VA: 0x1824E70F0
	public ParticleSystem.PlaybackState GetPlaybackState() { }

	// RVA: 0x24E7A80 Offset: 0x24E6C80 VA: 0x1824E7A80
	public void SetPlaybackState(ParticleSystem.PlaybackState playbackState) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = True)]
	// RVA: 0x24E7150 Offset: 0x24E6350 VA: 0x1824E7150
	private void GetTrailDataInternal(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x24E71A0 Offset: 0x24E63A0 VA: 0x1824E71A0
	public ParticleSystem.Trails GetTrails() { }

	// RVA: 0x24E7230 Offset: 0x24E6430 VA: 0x1824E7230
	public int GetTrails(ref ParticleSystem.Trails trailData) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
	// RVA: 0x24E7B20 Offset: 0x24E6D20 VA: 0x1824E7B20
	public void SetTrails(ParticleSystem.Trails trailData) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	// RVA: 0x24E7B70 Offset: 0x24E6D70 VA: 0x1824E7B70
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x24E7C90 Offset: 0x24E6E90 VA: 0x1824E7C90
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x24E7C30 Offset: 0x24E6E30 VA: 0x1824E7C30
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x24E7BE0 Offset: 0x24E6DE0 VA: 0x1824E7BE0
	public void Simulate(float t) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	// RVA: 0x24E73D0 Offset: 0x24E65D0 VA: 0x1824E73D0
	public void Play(bool withChildren) { }

	// RVA: 0x24E7420 Offset: 0x24E6620 VA: 0x1824E7420
	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	// RVA: 0x24E7380 Offset: 0x24E6580 VA: 0x1824E7380
	public void Pause(bool withChildren) { }

	// RVA: 0x24E7340 Offset: 0x24E6540 VA: 0x1824E7340
	public void Pause() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	// RVA: 0x24E7D90 Offset: 0x24E6F90 VA: 0x1824E7D90
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x24E7D40 Offset: 0x24E6F40 VA: 0x1824E7D40
	public void Stop(bool withChildren) { }

	// RVA: 0x24E7D00 Offset: 0x24E6F00 VA: 0x1824E7D00
	public void Stop() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	// RVA: 0x24E6570 Offset: 0x24E5770 VA: 0x1824E6570
	public void Clear(bool withChildren) { }

	// RVA: 0x24E65C0 Offset: 0x24E57C0 VA: 0x1824E65C0
	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	// RVA: 0x24E72B0 Offset: 0x24E64B0 VA: 0x1824E72B0
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x24E7300 Offset: 0x24E6500 VA: 0x1824E7300
	public bool IsAlive() { }

	[RequiredByNativeCode]
	// RVA: 0x24E6700 Offset: 0x24E5900 VA: 0x1824E6700
	public void Emit(int count) { }

	[NativeName("SyncJobs()->Emit")]
	// RVA: 0x24E6700 Offset: 0x24E5900 VA: 0x1824E6700
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	// RVA: 0x24E6940 Offset: 0x24E5B40 VA: 0x1824E6940
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	// RVA: 0x24E6650 Offset: 0x24E5850 VA: 0x1824E6650
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x24E7E90 Offset: 0x24E7090 VA: 0x1824E7E90
	public void TriggerSubEmitter(int subEmitterIndex) { }

	// RVA: 0x24E7F30 Offset: 0x24E7130 VA: 0x1824E7F30
	public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = True)]
	// RVA: 0x24E7E40 Offset: 0x24E7040 VA: 0x1824E7E40
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = True)]
	// RVA: 0x24E7EE0 Offset: 0x24E70E0 VA: 0x1824E7EE0
	public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
	// RVA: 0x24E7460 Offset: 0x24E6660 VA: 0x1824E7460
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
	// RVA: 0x24E7650 Offset: 0x24E6850 VA: 0x1824E7650
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	[NativeName("SetUsesAxisOfRotation")]
	// RVA: 0x24E64B0 Offset: 0x24E56B0 VA: 0x1824E64B0
	public void AllocateAxisOfRotationAttribute() { }

	[NativeName("SetUsesMeshIndex")]
	// RVA: 0x24E6530 Offset: 0x24E5730 VA: 0x1824E6530
	public void AllocateMeshIndexAttribute() { }

	[NativeName("SetUsesCustomData")]
	// RVA: 0x24E64F0 Offset: 0x24E56F0 VA: 0x1824E64F0
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	[NativeName("Has3DParticleRotations")]
	// RVA: 0x24E8120 Offset: 0x24E7320 VA: 0x1824E8120
	public bool get_has3DParticleRotations() { }

	[NativeName("HasNonUniformParticleSizes")]
	// RVA: 0x24E8160 Offset: 0x24E7360 VA: 0x1824E8160
	public bool get_hasNonUniformParticleSizes() { }

	// RVA: 0x24E6A00 Offset: 0x24E5C00 VA: 0x1824E6A00
	internal void* GetManagedJobData() { }

	// RVA: 0x24E6A90 Offset: 0x24E5C90 VA: 0x1824E6A90
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x24E7600 Offset: 0x24E6800 VA: 0x1824E7600
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunction("ScheduleManagedJob", ThrowsException = True)]
	// RVA: 0x24E74F0 Offset: 0x24E66F0 VA: 0x1824E74F0
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafe]
	// RVA: 0x24E6600 Offset: 0x24E5800 VA: 0x1824E6600
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.ExternalForcesModule get_externalForces() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.NoiseModule get_noise() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.TriggerModule get_trigger() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.SubEmittersModule get_subEmitters() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.LightsModule get_lights() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ParticleSystem.CustomDataModule get_customData() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24E6BA0 Offset: 0x24E5DA0 VA: 0x1824E6BA0
	private void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret) { }

	// RVA: 0x24E6AE0 Offset: 0x24E5CE0 VA: 0x1824E6AE0
	private void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret) { }

	// RVA: 0x24E70A0 Offset: 0x24E62A0 VA: 0x1824E70A0
	private void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret) { }

	// RVA: 0x24E7A30 Offset: 0x24E6C30 VA: 0x1824E7A30
	private void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState) { }

	// RVA: 0x24E7AD0 Offset: 0x24E6CD0 VA: 0x1824E7AD0
	private void SetTrails_Injected(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x24E66A0 Offset: 0x24E58A0 VA: 0x1824E66A0
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x24E7DF0 Offset: 0x24E6FF0 VA: 0x1824E7DF0
	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	// RVA: 0x24E6A40 Offset: 0x24E5C40 VA: 0x1824E6A40
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x24E75B0 Offset: 0x24E67B0 VA: 0x1824E75B0
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x24E7490 Offset: 0x24E6690 VA: 0x1824E7490
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }
}

// Namespace: UnityEngine
public enum ParticleSystemRenderMode // TypeDefIndex: 17336
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRenderMode Billboard = 0;
	public const ParticleSystemRenderMode Stretch = 1;
	public const ParticleSystemRenderMode HorizontalBillboard = 2;
	public const ParticleSystemRenderMode VerticalBillboard = 3;
	public const ParticleSystemRenderMode Mesh = 4;
	public const ParticleSystemRenderMode None = 5;
}

// Namespace: UnityEngine
public enum ParticleSystemMeshDistribution // TypeDefIndex: 17337
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemMeshDistribution UniformRandom = 0;
	public const ParticleSystemMeshDistribution NonUniformRandom = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemSortMode // TypeDefIndex: 17338
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSortMode None = 0;
	public const ParticleSystemSortMode Distance = 1;
	public const ParticleSystemSortMode OldestInFront = 2;
	public const ParticleSystemSortMode YoungestInFront = 3;
	public const ParticleSystemSortMode Depth = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemRenderSpace // TypeDefIndex: 17339
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemRenderSpace View = 0;
	public const ParticleSystemRenderSpace World = 1;
	public const ParticleSystemRenderSpace Local = 2;
	public const ParticleSystemRenderSpace Facing = 3;
	public const ParticleSystemRenderSpace Velocity = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode // TypeDefIndex: 17340
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode // TypeDefIndex: 17341
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace // TypeDefIndex: 17342
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior // TypeDefIndex: 17343
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode // TypeDefIndex: 17344
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public enum ParticleSystemVertexStream // TypeDefIndex: 17345
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemVertexStream Position = 0;
	public const ParticleSystemVertexStream Normal = 1;
	public const ParticleSystemVertexStream Tangent = 2;
	public const ParticleSystemVertexStream Color = 3;
	public const ParticleSystemVertexStream UV = 4;
	public const ParticleSystemVertexStream UV2 = 5;
	public const ParticleSystemVertexStream UV3 = 6;
	public const ParticleSystemVertexStream UV4 = 7;
	public const ParticleSystemVertexStream AnimBlend = 8;
	public const ParticleSystemVertexStream AnimFrame = 9;
	public const ParticleSystemVertexStream Center = 10;
	public const ParticleSystemVertexStream VertexID = 11;
	public const ParticleSystemVertexStream SizeX = 12;
	public const ParticleSystemVertexStream SizeXY = 13;
	public const ParticleSystemVertexStream SizeXYZ = 14;
	public const ParticleSystemVertexStream Rotation = 15;
	public const ParticleSystemVertexStream Rotation3D = 16;
	public const ParticleSystemVertexStream RotationSpeed = 17;
	public const ParticleSystemVertexStream RotationSpeed3D = 18;
	public const ParticleSystemVertexStream Velocity = 19;
	public const ParticleSystemVertexStream Speed = 20;
	public const ParticleSystemVertexStream AgePercent = 21;
	public const ParticleSystemVertexStream InvStartLifetime = 22;
	public const ParticleSystemVertexStream StableRandomX = 23;
	public const ParticleSystemVertexStream StableRandomXY = 24;
	public const ParticleSystemVertexStream StableRandomXYZ = 25;
	public const ParticleSystemVertexStream StableRandomXYZW = 26;
	public const ParticleSystemVertexStream VaryingRandomX = 27;
	public const ParticleSystemVertexStream VaryingRandomXY = 28;
	public const ParticleSystemVertexStream VaryingRandomXYZ = 29;
	public const ParticleSystemVertexStream VaryingRandomXYZW = 30;
	public const ParticleSystemVertexStream Custom1X = 31;
	public const ParticleSystemVertexStream Custom1XY = 32;
	public const ParticleSystemVertexStream Custom1XYZ = 33;
	public const ParticleSystemVertexStream Custom1XYZW = 34;
	public const ParticleSystemVertexStream Custom2X = 35;
	public const ParticleSystemVertexStream Custom2XY = 36;
	public const ParticleSystemVertexStream Custom2XYZ = 37;
	public const ParticleSystemVertexStream Custom2XYZW = 38;
	public const ParticleSystemVertexStream NoiseSumX = 39;
	public const ParticleSystemVertexStream NoiseSumXY = 40;
	public const ParticleSystemVertexStream NoiseSumXYZ = 41;
	public const ParticleSystemVertexStream NoiseImpulseX = 42;
	public const ParticleSystemVertexStream NoiseImpulseXY = 43;
	public const ParticleSystemVertexStream NoiseImpulseXYZ = 44;
	public const ParticleSystemVertexStream MeshIndex = 45;
	public const ParticleSystemVertexStream ParticleIndex = 46;
	public const ParticleSystemVertexStream ColorPackedAsTwoFloats = 47;
	public const ParticleSystemVertexStream MeshAxisOfRotation = 48;
	public const ParticleSystemVertexStream NextTrailCenter = 49;
	public const ParticleSystemVertexStream PreviousTrailCenter = 50;
	public const ParticleSystemVertexStream PercentageAlongTrail = 51;
	public const ParticleSystemVertexStream TrailWidth = 52;
}

// Namespace: UnityEngine
public enum ParticleSystemCustomData // TypeDefIndex: 17346
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemCustomData Custom1 = 0;
	public const ParticleSystemCustomData Custom2 = 1;
}

// Namespace: UnityEngine
[Flags]
public enum ParticleSystemBakeMeshOptions // TypeDefIndex: 17347
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemBakeMeshOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeMeshOptions BakePosition = 2;
	public const ParticleSystemBakeMeshOptions Default = 0;
}

// Namespace: UnityEngine
[Flags]
public enum ParticleSystemBakeTextureOptions // TypeDefIndex: 17348
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemBakeTextureOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeTextureOptions BakePosition = 2;
	public const ParticleSystemBakeTextureOptions PerVertex = 4;
	public const ParticleSystemBakeTextureOptions PerParticle = 8;
	public const ParticleSystemBakeTextureOptions IncludeParticleIndices = 16;
	public const ParticleSystemBakeTextureOptions Default = 4;
}

// Namespace: UnityEngine
[Flags]
[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.", False)]
public enum ParticleSystemVertexStreams // TypeDefIndex: 17349
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemVertexStreams Position = 1;
	public const ParticleSystemVertexStreams Normal = 2;
	public const ParticleSystemVertexStreams Tangent = 4;
	public const ParticleSystemVertexStreams Color = 8;
	public const ParticleSystemVertexStreams UV = 16;
	public const ParticleSystemVertexStreams UV2BlendAndFrame = 32;
	public const ParticleSystemVertexStreams CenterAndVertexID = 64;
	public const ParticleSystemVertexStreams Size = 128;
	public const ParticleSystemVertexStreams Rotation = 256;
	public const ParticleSystemVertexStreams Velocity = 512;
	public const ParticleSystemVertexStreams Lifetime = 1024;
	public const ParticleSystemVertexStreams Custom1 = 2048;
	public const ParticleSystemVertexStreams Custom2 = 4096;
	public const ParticleSystemVertexStreams Random = 8192;
	public const ParticleSystemVertexStreams None = 0;
	public const ParticleSystemVertexStreams All = 2147483647;
}

// Namespace: 
internal struct ParticleSystemRenderer.BakeTextureOutput // TypeDefIndex: 17350
{
	// Fields
	[NativeName("first")]
	internal Texture2D vertices; // 0x0
	[NativeName("second")]
	internal Texture2D indices; // 0x8
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 17351
{
	// Properties
	[NativeName("RenderAlignment")]
	public ParticleSystemRenderSpace alignment { get; set; }
	public ParticleSystemRenderMode renderMode { get; set; }
	public ParticleSystemMeshDistribution meshDistribution { get; set; }
	public ParticleSystemSortMode sortMode { get; set; }
	public float lengthScale { get; set; }
	public float velocityScale { get; set; }
	public float cameraVelocityScale { get; set; }
	public float normalDirection { get; set; }
	public float shadowBias { get; set; }
	public float sortingFudge { get; set; }
	public float minParticleSize { get; set; }
	public float maxParticleSize { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 flip { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Material trailMaterial { get; set; }
	internal Material oldTrailMaterial { set; }
	public bool enableGPUInstancing { get; set; }
	public bool allowRoll { get; set; }
	public bool freeformStretching { get; set; }
	public bool rotateWithStretchDirection { get; set; }
	public Mesh mesh { get; set; }
	public int meshCount { get; }
	public int activeVertexStreamsCount { get; }
	public int activeTrailVertexStreamsCount { get; }

	// Methods

	[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x24E4970 Offset: 0x24E3B70 VA: 0x1824E4970
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x24E4960 Offset: 0x24E3B60 VA: 0x1824E4960
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x24E3E30 Offset: 0x24E3030 VA: 0x1824E3E30
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x24E4A20 Offset: 0x24E3C20 VA: 0x1824E4A20
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	// RVA: 0x24E4D60 Offset: 0x24E3F60 VA: 0x1824E4D60
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	// RVA: 0x24E4AD0 Offset: 0x24E3CD0 VA: 0x1824E4AD0
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x24E3FA0 Offset: 0x24E31A0 VA: 0x1824E3FA0
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x24E3F30 Offset: 0x24E3130 VA: 0x1824E3F30
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x24E45F0 Offset: 0x24E37F0 VA: 0x1824E45F0
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = False) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	// RVA: 0x24E4670 Offset: 0x24E3870 VA: 0x1824E4670
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x24E5740 Offset: 0x24E4940 VA: 0x1824E5740
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0x24E5D80 Offset: 0x24E4F80 VA: 0x1824E5D80
	public void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0x24E5BC0 Offset: 0x24E4DC0 VA: 0x1824E5BC0
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x24E62A0 Offset: 0x24E54A0 VA: 0x1824E62A0
	public void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0x24E5A20 Offset: 0x24E4C20 VA: 0x1824E5A20
	public ParticleSystemMeshDistribution get_meshDistribution() { }

	// RVA: 0x24E6080 Offset: 0x24E5280 VA: 0x1824E6080
	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	// RVA: 0x24E5C80 Offset: 0x24E4E80 VA: 0x1824E5C80
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0x24E6380 Offset: 0x24E5580 VA: 0x1824E6380
	public void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0x24E5920 Offset: 0x24E4B20 VA: 0x1824E5920
	public float get_lengthScale() { }

	// RVA: 0x24E5FA0 Offset: 0x24E51A0 VA: 0x1824E5FA0
	public void set_lengthScale(float value) { }

	// RVA: 0x24E5D40 Offset: 0x24E4F40 VA: 0x1824E5D40
	public float get_velocityScale() { }

	// RVA: 0x24E6460 Offset: 0x24E5660 VA: 0x1824E6460
	public void set_velocityScale(float value) { }

	// RVA: 0x24E57C0 Offset: 0x24E49C0 VA: 0x1824E57C0
	public float get_cameraVelocityScale() { }

	// RVA: 0x24E5E10 Offset: 0x24E5010 VA: 0x1824E5E10
	public void set_cameraVelocityScale(float value) { }

	// RVA: 0x24E5AE0 Offset: 0x24E4CE0 VA: 0x1824E5AE0
	public float get_normalDirection() { }

	// RVA: 0x24E6160 Offset: 0x24E5360 VA: 0x1824E6160
	public void set_normalDirection(float value) { }

	// RVA: 0x24E5C40 Offset: 0x24E4E40 VA: 0x1824E5C40
	public float get_shadowBias() { }

	// RVA: 0x24E6330 Offset: 0x24E5530 VA: 0x1824E6330
	public void set_shadowBias(float value) { }

	// RVA: 0x24E5CC0 Offset: 0x24E4EC0 VA: 0x1824E5CC0
	public float get_sortingFudge() { }

	// RVA: 0x24E63C0 Offset: 0x24E55C0 VA: 0x1824E63C0
	public void set_sortingFudge(float value) { }

	// RVA: 0x24E5AA0 Offset: 0x24E4CA0 VA: 0x1824E5AA0
	public float get_minParticleSize() { }

	// RVA: 0x24E6110 Offset: 0x24E5310 VA: 0x1824E6110
	public void set_minParticleSize(float value) { }

	// RVA: 0x24E59A0 Offset: 0x24E4BA0 VA: 0x1824E59A0
	public float get_maxParticleSize() { }

	// RVA: 0x24E6030 Offset: 0x24E5230 VA: 0x1824E6030
	public void set_maxParticleSize(float value) { }

	// RVA: 0x24E5B70 Offset: 0x24E4D70 VA: 0x1824E5B70
	public Vector3 get_pivot() { }

	// RVA: 0x24E6250 Offset: 0x24E5450 VA: 0x1824E6250
	public void set_pivot(Vector3 value) { }

	// RVA: 0x24E5890 Offset: 0x24E4A90 VA: 0x1824E5890
	public Vector3 get_flip() { }

	// RVA: 0x24E5F00 Offset: 0x24E5100 VA: 0x1824E5F00
	public void set_flip(Vector3 value) { }

	// RVA: 0x24E5960 Offset: 0x24E4B60 VA: 0x1824E5960
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x24E5FF0 Offset: 0x24E51F0 VA: 0x1824E5FF0
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x24E5D00 Offset: 0x24E4F00 VA: 0x1824E5D00
	public Material get_trailMaterial() { }

	// RVA: 0x24E6410 Offset: 0x24E5610 VA: 0x1824E6410
	public void set_trailMaterial(Material value) { }

	// RVA: 0x24E61B0 Offset: 0x24E53B0 VA: 0x1824E61B0
	internal void set_oldTrailMaterial(Material value) { }

	// RVA: 0x24E5800 Offset: 0x24E4A00 VA: 0x1824E5800
	public bool get_enableGPUInstancing() { }

	// RVA: 0x24E5E60 Offset: 0x24E5060 VA: 0x1824E5E60
	public void set_enableGPUInstancing(bool value) { }

	// RVA: 0x24E5780 Offset: 0x24E4980 VA: 0x1824E5780
	public bool get_allowRoll() { }

	// RVA: 0x24E5DC0 Offset: 0x24E4FC0 VA: 0x1824E5DC0
	public void set_allowRoll(bool value) { }

	// RVA: 0x24E58E0 Offset: 0x24E4AE0 VA: 0x1824E58E0
	public bool get_freeformStretching() { }

	// RVA: 0x24E5F50 Offset: 0x24E5150 VA: 0x1824E5F50
	public void set_freeformStretching(bool value) { }

	// RVA: 0x24E5C00 Offset: 0x24E4E00 VA: 0x1824E5C00
	public bool get_rotateWithStretchDirection() { }

	// RVA: 0x24E62E0 Offset: 0x24E54E0 VA: 0x1824E62E0
	public void set_rotateWithStretchDirection(bool value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	// RVA: 0x24E5A60 Offset: 0x24E4C60 VA: 0x1824E5A60
	public Mesh get_mesh() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
	// RVA: 0x24E60C0 Offset: 0x24E52C0 VA: 0x1824E60C0
	public void set_mesh(Mesh value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	// RVA: 0x24E4A80 Offset: 0x24E3C80 VA: 0x1824E4A80
	public int GetMeshes([Out] Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
	// RVA: 0x24E5600 Offset: 0x24E4800 VA: 0x1824E5600
	public void SetMeshes(Mesh[] meshes, int size) { }

	// RVA: 0x24E5660 Offset: 0x24E4860 VA: 0x1824E5660
	public void SetMeshes(Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
	// RVA: 0x24E4A30 Offset: 0x24E3C30 VA: 0x1824E4A30
	public int GetMeshWeightings([Out] float[] weightings) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
	// RVA: 0x24E5540 Offset: 0x24E4740 VA: 0x1824E5540
	public void SetMeshWeightings(float[] weightings, int size) { }

	// RVA: 0x24E55A0 Offset: 0x24E47A0 VA: 0x1824E55A0
	public void SetMeshWeightings(float[] weightings) { }

	// RVA: 0x24E59E0 Offset: 0x24E4BE0 VA: 0x1824E59E0
	public int get_meshCount() { }

	// RVA: 0x24E3E50 Offset: 0x24E3050 VA: 0x1824E3E50
	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x24E3EC0 Offset: 0x24E30C0 VA: 0x1824E3EC0
	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x24E4510 Offset: 0x24E3710 VA: 0x1824E4510
	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x24E4580 Offset: 0x24E3780 VA: 0x1824E4580
	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x24E4350 Offset: 0x24E3550 VA: 0x1824E4350
	public int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x24E4250 Offset: 0x24E3450 VA: 0x1824E4250
	public int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTextureNoIndices", HasExplicitThis = True)]
	// RVA: 0x24E4120 Offset: 0x24E3320 VA: 0x1824E4120
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x24E4450 Offset: 0x24E3650 VA: 0x1824E4450
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x24E4190 Offset: 0x24E3390 VA: 0x1824E4190
	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTexture", HasExplicitThis = True)]
	// RVA: 0x24E4090 Offset: 0x24E3290 VA: 0x1824E4090
	private ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x24E47E0 Offset: 0x24E39E0 VA: 0x1824E47E0
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x24E48A0 Offset: 0x24E3AA0 VA: 0x1824E48A0
	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTrailsTexture", HasExplicitThis = True)]
	// RVA: 0x24E4750 Offset: 0x24E3950 VA: 0x1824E4750
	private ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	// RVA: 0x24E5700 Offset: 0x24E4900 VA: 0x1824E5700
	public int get_activeVertexStreamsCount() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
	// RVA: 0x24E54F0 Offset: 0x24E46F0 VA: 0x1824E54F0
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
	// RVA: 0x24E49D0 Offset: 0x24E3BD0 VA: 0x1824E49D0
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x24E56C0 Offset: 0x24E48C0 VA: 0x1824E56C0
	public int get_activeTrailVertexStreamsCount() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveTrailVertexStreams", HasExplicitThis = True)]
	// RVA: 0x24E54A0 Offset: 0x24E46A0 VA: 0x1824E54A0
	public void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveTrailVertexStreams", HasExplicitThis = True)]
	// RVA: 0x24E4980 Offset: 0x24E3B80 VA: 0x1824E4980
	public void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x5340E0 Offset: 0x5332E0 VA: 0x1805340E0
	public void .ctor() { }

	// RVA: 0x24E5B20 Offset: 0x24E4D20 VA: 0x1824E5B20
	private void get_pivot_Injected(out Vector3 ret) { }

	// RVA: 0x24E6200 Offset: 0x24E5400 VA: 0x1824E6200
	private void set_pivot_Injected(ref Vector3 value) { }

	// RVA: 0x24E5840 Offset: 0x24E4A40 VA: 0x1824E5840
	private void get_flip_Injected(out Vector3 ret) { }

	// RVA: 0x24E5EB0 Offset: 0x24E50B0 VA: 0x1824E5EB0
	private void set_flip_Injected(ref Vector3 value) { }

	// RVA: 0x24E4020 Offset: 0x24E3220 VA: 0x1824E4020
	private void BakeTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret) { }

	// RVA: 0x24E46E0 Offset: 0x24E38E0 VA: 0x1824E46E0
	private void BakeTrailsTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out ParticleSystemRenderer.BakeTextureOutput ret) { }
}

// Namespace: 
internal struct NativeParticleData.Array3 // TypeDefIndex: 17352
{
	// Fields
	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10
}

// Namespace: 
internal struct NativeParticleData.Array4 // TypeDefIndex: 17353
{
	// Fields
	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10
	internal float* w; // 0x18
}

// Namespace: UnityEngine.ParticleSystemJobs
internal struct NativeParticleData // TypeDefIndex: 17354
{
	// Fields
	internal int count; // 0x0
	internal NativeParticleData.Array3 positions; // 0x8
	internal NativeParticleData.Array3 velocities; // 0x20
	internal NativeParticleData.Array3 axisOfRotations; // 0x38
	internal NativeParticleData.Array3 rotations; // 0x50
	internal NativeParticleData.Array3 rotationalSpeeds; // 0x68
	internal NativeParticleData.Array3 sizes; // 0x80
	internal void* startColors; // 0x98
	internal void* aliveTimePercent; // 0xA0
	internal void* inverseStartLifetimes; // 0xA8
	internal void* randomSeeds; // 0xB0
	internal NativeParticleData.Array4 customData1; // 0xB8
	internal NativeParticleData.Array4 customData2; // 0xD8
	internal void* meshIndices; // 0xF8
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17355
{}

// Namespace: System.Numerics.Hashing
internal static class HashHelpers // TypeDefIndex: 17356
{
	// Fields
	public static readonly int RandomSeed; // 0x0

	// Methods

	// RVA: 0x16DB5B0 Offset: 0x16DA7B0 VA: 0x1816DB5B0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x1EA4AC0 Offset: 0x1EA3CC0 VA: 0x181EA4AC0
	private static void .cctor() { }
}

// Namespace: System.Drawing
public enum KnownColor // TypeDefIndex: 17357
{
	// Fields
	public int value__; // 0x0
	public const KnownColor ActiveBorder = 1;
	public const KnownColor ActiveCaption = 2;
	public const KnownColor ActiveCaptionText = 3;
	public const KnownColor AppWorkspace = 4;
	public const KnownColor Control = 5;
	public const KnownColor ControlDark = 6;
	public const KnownColor ControlDarkDark = 7;
	public const KnownColor ControlLight = 8;
	public const KnownColor ControlLightLight = 9;
	public const KnownColor ControlText = 10;
	public const KnownColor Desktop = 11;
	public const KnownColor GrayText = 12;
	public const KnownColor Highlight = 13;
	public const KnownColor HighlightText = 14;
	public const KnownColor HotTrack = 15;
	public const KnownColor InactiveBorder = 16;
	public const KnownColor InactiveCaption = 17;
	public const KnownColor InactiveCaptionText = 18;
	public const KnownColor Info = 19;
	public const KnownColor InfoText = 20;
	public const KnownColor Menu = 21;
	public const KnownColor MenuText = 22;
	public const KnownColor ScrollBar = 23;
	public const KnownColor Window = 24;
	public const KnownColor WindowFrame = 25;
	public const KnownColor WindowText = 26;
	public const KnownColor Transparent = 27;
	public const KnownColor AliceBlue = 28;
	public const KnownColor AntiqueWhite = 29;
	public const KnownColor Aqua = 30;
	public const KnownColor Aquamarine = 31;
	public const KnownColor Azure = 32;
	public const KnownColor Beige = 33;
	public const KnownColor Bisque = 34;
	public const KnownColor Black = 35;
	public const KnownColor BlanchedAlmond = 36;
	public const KnownColor Blue = 37;
	public const KnownColor BlueViolet = 38;
	public const KnownColor Brown = 39;
	public const KnownColor BurlyWood = 40;
	public const KnownColor CadetBlue = 41;
	public const KnownColor Chartreuse = 42;
	public const KnownColor Chocolate = 43;
	public const KnownColor Coral = 44;
	public const KnownColor CornflowerBlue = 45;
	public const KnownColor Cornsilk = 46;
	public const KnownColor Crimson = 47;
	public const KnownColor Cyan = 48;
	public const KnownColor DarkBlue = 49;
	public const KnownColor DarkCyan = 50;
	public const KnownColor DarkGoldenrod = 51;
	public const KnownColor DarkGray = 52;
	public const KnownColor DarkGreen = 53;
	public const KnownColor DarkKhaki = 54;
	public const KnownColor DarkMagenta = 55;
	public const KnownColor DarkOliveGreen = 56;
	public const KnownColor DarkOrange = 57;
	public const KnownColor DarkOrchid = 58;
	public const KnownColor DarkRed = 59;
	public const KnownColor DarkSalmon = 60;
	public const KnownColor DarkSeaGreen = 61;
	public const KnownColor DarkSlateBlue = 62;
	public const KnownColor DarkSlateGray = 63;
	public const KnownColor DarkTurquoise = 64;
	public const KnownColor DarkViolet = 65;
	public const KnownColor DeepPink = 66;
	public const KnownColor DeepSkyBlue = 67;
	public const KnownColor DimGray = 68;
	public const KnownColor DodgerBlue = 69;
	public const KnownColor Firebrick = 70;
	public const KnownColor FloralWhite = 71;
	public const KnownColor ForestGreen = 72;
	public const KnownColor Fuchsia = 73;
	public const KnownColor Gainsboro = 74;
	public const KnownColor GhostWhite = 75;
	public const KnownColor Gold = 76;
	public const KnownColor Goldenrod = 77;
	public const KnownColor Gray = 78;
	public const KnownColor Green = 79;
	public const KnownColor GreenYellow = 80;
	public const KnownColor Honeydew = 81;
	public const KnownColor HotPink = 82;
	public const KnownColor IndianRed = 83;
	public const KnownColor Indigo = 84;
	public const KnownColor Ivory = 85;
	public const KnownColor Khaki = 86;
	public const KnownColor Lavender = 87;
	public const KnownColor LavenderBlush = 88;
	public const KnownColor LawnGreen = 89;
	public const KnownColor LemonChiffon = 90;
	public const KnownColor LightBlue = 91;
	public const KnownColor LightCoral = 92;
	public const KnownColor LightCyan = 93;
	public const KnownColor LightGoldenrodYellow = 94;
	public const KnownColor LightGray = 95;
	public const KnownColor LightGreen = 96;
	public const KnownColor LightPink = 97;
	public const KnownColor LightSalmon = 98;
	public const KnownColor LightSeaGreen = 99;
	public const KnownColor LightSkyBlue = 100;
	public const KnownColor LightSlateGray = 101;
	public const KnownColor LightSteelBlue = 102;
	public const KnownColor LightYellow = 103;
	public const KnownColor Lime = 104;
	public const KnownColor LimeGreen = 105;
	public const KnownColor Linen = 106;
	public const KnownColor Magenta = 107;
	public const KnownColor Maroon = 108;
	public const KnownColor MediumAquamarine = 109;
	public const KnownColor MediumBlue = 110;
	public const KnownColor MediumOrchid = 111;
	public const KnownColor MediumPurple = 112;
	public const KnownColor MediumSeaGreen = 113;
	public const KnownColor MediumSlateBlue = 114;
	public const KnownColor MediumSpringGreen = 115;
	public const KnownColor MediumTurquoise = 116;
	public const KnownColor MediumVioletRed = 117;
	public const KnownColor MidnightBlue = 118;
	public const KnownColor MintCream = 119;
	public const KnownColor MistyRose = 120;
	public const KnownColor Moccasin = 121;
	public const KnownColor NavajoWhite = 122;
	public const KnownColor Navy = 123;
	public const KnownColor OldLace = 124;
	public const KnownColor Olive = 125;
	public const KnownColor OliveDrab = 126;
	public const KnownColor Orange = 127;
	public const KnownColor OrangeRed = 128;
	public const KnownColor Orchid = 129;
	public const KnownColor PaleGoldenrod = 130;
	public const KnownColor PaleGreen = 131;
	public const KnownColor PaleTurquoise = 132;
	public const KnownColor PaleVioletRed = 133;
	public const KnownColor PapayaWhip = 134;
	public const KnownColor PeachPuff = 135;
	public const KnownColor Peru = 136;
	public const KnownColor Pink = 137;
	public const KnownColor Plum = 138;
	public const KnownColor PowderBlue = 139;
	public const KnownColor Purple = 140;
	public const KnownColor Red = 141;
	public const KnownColor RosyBrown = 142;
	public const KnownColor RoyalBlue = 143;
	public const KnownColor SaddleBrown = 144;
	public const KnownColor Salmon = 145;
	public const KnownColor SandyBrown = 146;
	public const KnownColor SeaGreen = 147;
	public const KnownColor SeaShell = 148;
	public const KnownColor Sienna = 149;
	public const KnownColor Silver = 150;
	public const KnownColor SkyBlue = 151;
	public const KnownColor SlateBlue = 152;
	public const KnownColor SlateGray = 153;
	public const KnownColor Snow = 154;
	public const KnownColor SpringGreen = 155;
	public const KnownColor SteelBlue = 156;
	public const KnownColor Tan = 157;
	public const KnownColor Teal = 158;
	public const KnownColor Thistle = 159;
	public const KnownColor Tomato = 160;
	public const KnownColor Turquoise = 161;
	public const KnownColor Violet = 162;
	public const KnownColor Wheat = 163;
	public const KnownColor White = 164;
	public const KnownColor WhiteSmoke = 165;
	public const KnownColor Yellow = 166;
	public const KnownColor YellowGreen = 167;
	public const KnownColor ButtonFace = 168;
	public const KnownColor ButtonHighlight = 169;
	public const KnownColor ButtonShadow = 170;
	public const KnownColor GradientActiveCaption = 171;
	public const KnownColor GradientInactiveCaption = 172;
	public const KnownColor MenuBar = 173;
	public const KnownColor MenuHighlight = 174;
}

// Namespace: System.Drawing
internal static class KnownColorTable // TypeDefIndex: 17358
{
	// Fields
	private static int[] s_colorTable; // 0x0
	private static string[] s_colorNameTable; // 0x8

	// Methods

	// RVA: 0x1EA4B70 Offset: 0x1EA3D70 VA: 0x181EA4B70
	private static void EnsureColorTable() { }

	// RVA: 0x1EA6510 Offset: 0x1EA5710 VA: 0x181EA6510
	private static void InitColorTable() { }

	// RVA: 0x1EA4B20 Offset: 0x1EA3D20 VA: 0x181EA4B20
	private static void EnsureColorNameTable() { }

	// RVA: 0x1EA4BC0 Offset: 0x1EA3DC0 VA: 0x181EA4BC0
	private static void InitColorNameTable() { }

	// RVA: 0x1EA70F0 Offset: 0x1EA62F0 VA: 0x181EA70F0
	public static int KnownColorToArgb(KnownColor color) { }

	// RVA: 0x1EA7180 Offset: 0x1EA6380 VA: 0x181EA7180
	public static string KnownColorToName(KnownColor color) { }

	// RVA: 0x1EA7210 Offset: 0x1EA6410 VA: 0x181EA7210
	private static void UpdateSystemColors(int[] colorTable) { }
}

// Namespace: System.Drawing
[IsReadOnly]
[DebuggerDisplay("{NameAndARGBValue}")]
[Serializable]
public struct Color : IEquatable<Color> // TypeDefIndex: 17359
{
	// Fields
	private readonly string name; // 0x0
	private readonly long value; // 0x8
	private readonly short knownColor; // 0x10
	private readonly short state; // 0x12

	// Properties
	public byte R { get; }
	public byte G { get; }
	public byte B { get; }
	public byte A { get; }
	public bool IsKnownColor { get; }
	public string Name { get; }
	private long Value { get; }

	// Methods

	// RVA: 0x1EA4960 Offset: 0x1EA3B60 VA: 0x181EA4960
	public byte get_R() { }

	// RVA: 0x1EA4830 Offset: 0x1EA3A30 VA: 0x181EA4830
	public byte get_G() { }

	// RVA: 0x1EA4820 Offset: 0x1EA3A20 VA: 0x181EA4820
	public byte get_B() { }

	// RVA: 0x1EA4800 Offset: 0x1EA3A00 VA: 0x181EA4800
	public byte get_A() { }

	// RVA: 0x1EA4850 Offset: 0x1EA3A50 VA: 0x181EA4850
	public bool get_IsKnownColor() { }

	// RVA: 0x1EA4860 Offset: 0x1EA3A60 VA: 0x181EA4860
	public string get_Name() { }

	// RVA: 0x1EA4980 Offset: 0x1EA3B80 VA: 0x181EA4980
	private long get_Value() { }

	// RVA: 0x1EA45F0 Offset: 0x1EA37F0 VA: 0x181EA45F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EA4A40 Offset: 0x1EA3C40 VA: 0x181EA4A40
	public static bool op_Equality(Color left, Color right) { }

	// RVA: 0x1EA4370 Offset: 0x1EA3570 VA: 0x181EA4370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA4470 Offset: 0x1EA3670 VA: 0x181EA4470 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x1EA4510 Offset: 0x1EA3710 VA: 0x181EA4510 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Drawing
[Serializable]
public struct Point : IEquatable<Point> // TypeDefIndex: 17360
{
	// Fields
	private int x; // 0x0
	private int y; // 0x4

	// Properties
	public int X { get; }
	public int Y { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_X() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Y() { }

	// RVA: 0x1EA7920 Offset: 0x1EA6B20 VA: 0x181EA7920
	public static bool op_Equality(Point left, Point right) { }

	// RVA: 0x1EA7730 Offset: 0x1EA6930 VA: 0x181EA7730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7710 Offset: 0x1EA6910 VA: 0x181EA7710 Slot: 4
	public bool Equals(Point other) { }

	// RVA: 0x1EA77C0 Offset: 0x1EA69C0 VA: 0x181EA77C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA7820 Offset: 0x1EA6A20 VA: 0x181EA7820 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Drawing
[Serializable]
public struct PointF : IEquatable<PointF> // TypeDefIndex: 17361
{
	// Fields
	private float x; // 0x0
	private float y; // 0x4

	// Properties
	public float X { get; }
	public float Y { get; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_X() { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_Y() { }

	// RVA: 0x1EA76D0 Offset: 0x1EA68D0 VA: 0x181EA76D0
	public static bool op_Equality(PointF left, PointF right) { }

	// RVA: 0x1EA74B0 Offset: 0x1EA66B0 VA: 0x181EA74B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7480 Offset: 0x1EA6680 VA: 0x181EA7480 Slot: 4
	public bool Equals(PointF other) { }

	// RVA: 0x1EA7550 Offset: 0x1EA6750 VA: 0x181EA7550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA75E0 Offset: 0x1EA67E0 VA: 0x181EA75E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Drawing
[Serializable]
public struct Rectangle : IEquatable<Rectangle> // TypeDefIndex: 17362
{
	// Fields
	private int x; // 0x0
	private int y; // 0x4
	private int width; // 0x8
	private int height; // 0xC

	// Properties
	public int X { get; }
	public int Y { get; }
	public int Width { get; }
	public int Height { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_X() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Y() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Width() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_Height() { }

	// RVA: 0x1EA7CE0 Offset: 0x1EA6EE0 VA: 0x181EA7CE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7DA0 Offset: 0x1EA6FA0 VA: 0x181EA7DA0 Slot: 4
	public bool Equals(Rectangle other) { }

	// RVA: 0x1799990 Offset: 0x1798B90 VA: 0x181799990
	public static bool op_Equality(Rectangle left, Rectangle right) { }

	// RVA: 0x1EA7DF0 Offset: 0x1EA6FF0 VA: 0x181EA7DF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA7E80 Offset: 0x1EA7080 VA: 0x181EA7E80 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Drawing
[Serializable]
public struct RectangleF : IEquatable<RectangleF> // TypeDefIndex: 17363
{
	// Fields
	private float x; // 0x0
	private float y; // 0x4
	private float width; // 0x8
	private float height; // 0xC

	// Properties
	public float X { get; }
	public float Y { get; }
	public float Width { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_X() { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_Y() { }

	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_Width() { }

	// RVA: 0x52C5A0 Offset: 0x52B7A0 VA: 0x18052C5A0
	public float get_Height() { }

	// RVA: 0x1EA7940 Offset: 0x1EA6B40 VA: 0x181EA7940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7A10 Offset: 0x1EA6C10 VA: 0x181EA7A10 Slot: 4
	public bool Equals(RectangleF other) { }

	// RVA: 0x1996670 Offset: 0x1995870 VA: 0x181996670
	public static bool op_Equality(RectangleF left, RectangleF right) { }

	// RVA: 0x1EA7A60 Offset: 0x1EA6C60 VA: 0x181EA7A60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA7B50 Offset: 0x1EA6D50 VA: 0x181EA7B50 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Drawing
[Serializable]
public struct Size : IEquatable<Size> // TypeDefIndex: 17364
{
	// Fields
	private int width; // 0x0
	private int height; // 0x4

	// Properties
	public int Width { get; }
	public int Height { get; }

	// Methods

	// RVA: 0x1EA7920 Offset: 0x1EA6B20 VA: 0x181EA7920
	public static bool op_Equality(Size sz1, Size sz2) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Width() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Height() { }

	// RVA: 0x1EA8220 Offset: 0x1EA7420 VA: 0x181EA8220 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7710 Offset: 0x1EA6910 VA: 0x181EA7710 Slot: 4
	public bool Equals(Size other) { }

	// RVA: 0x1EA82B0 Offset: 0x1EA74B0 VA: 0x181EA82B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA8310 Offset: 0x1EA7510 VA: 0x181EA8310 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Drawing
[Serializable]
public struct SizeF : IEquatable<SizeF> // TypeDefIndex: 17365
{
	// Fields
	private float width; // 0x0
	private float height; // 0x4

	// Properties
	public float Width { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x1EA76D0 Offset: 0x1EA68D0 VA: 0x181EA76D0
	public static bool op_Equality(SizeF sz1, SizeF sz2) { }

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_Width() { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_Height() { }

	// RVA: 0x1EA8000 Offset: 0x1EA7200 VA: 0x181EA8000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA7480 Offset: 0x1EA6680 VA: 0x181EA7480 Slot: 4
	public bool Equals(SizeF other) { }

	// RVA: 0x1EA80A0 Offset: 0x1EA72A0 VA: 0x181EA80A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA8130 Offset: 0x1EA7330 VA: 0x181EA8130 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17366
{}

// Namespace: Unity.Properties
[Usage(384)]
public class CreatePropertyAttribute : Attribute // TypeDefIndex: 17367
{}

// Namespace: Unity.Properties
[Usage(256)]
public class DontCreatePropertyAttribute : Attribute // TypeDefIndex: 17368
{}

// Namespace: Unity.Properties
public sealed class PropertyGetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17369
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89620 Offset: 0xB88820 VA: 0x180B89620
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public sealed class PropertySetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17370
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB896D0 Offset: 0xB888D0 VA: 0x180B896D0
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 17371
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC5AA0 Offset: 0xFC4CA0 VA: 0x180FC5AA0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IProperty // TypeDefIndex: 17372
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type DeclaredValueType();
}

// Namespace: Unity.Properties
public interface IProperty<TContainer> : IProperty // TypeDefIndex: 17373
{}

// Namespace: Unity.Properties
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes // TypeDefIndex: 17374
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8A0E0 Offset: 0xB892E0 VA: 0x180B8A0E0
	|-Property<Bounds, Vector3>.DeclaredValueType
	|
	|-RVA: 0xB8A260 Offset: 0xB89460 VA: 0x180B8A260
	|-Property<BoundsInt, Vector3Int>.DeclaredValueType
	|
	|-RVA: 0xB8A440 Offset: 0xB89640 VA: 0x180B8A440
	|-Property<Color, float>.DeclaredValueType
	|
	|-RVA: 0xB8A1A0 Offset: 0xB893A0 VA: 0x180B8A1A0
	|-Property<object, int>.DeclaredValueType
	|
	|-RVA: 0xB8A2C0 Offset: 0xB894C0 VA: 0x180B8A2C0
	|-Property<Rect, float>.DeclaredValueType
	|
	|-RVA: 0xB8A320 Offset: 0xB89520 VA: 0x180B8A320
	|-Property<RectInt, int>.DeclaredValueType
	|
	|-RVA: 0xB8A4A0 Offset: 0xB896A0 VA: 0x180B8A4A0
	|-Property<Vector2, float>.DeclaredValueType
	|
	|-RVA: 0xB8A140 Offset: 0xB89340 VA: 0x180B8A140
	|-Property<Vector2Int, int>.DeclaredValueType
	|
	|-RVA: 0xB8A080 Offset: 0xB89280 VA: 0x180B8A080
	|-Property<Vector3, float>.DeclaredValueType
	|
	|-RVA: 0xB8A3E0 Offset: 0xB895E0 VA: 0x180B8A3E0
	|-Property<Vector3Int, int>.DeclaredValueType
	|
	|-RVA: 0xB8A380 Offset: 0xB89580 VA: 0x180B8A380
	|-Property<Vector4, float>.DeclaredValueType
	|
	|-RVA: 0xB8A200 Offset: 0xB89400 VA: 0x180B8A200
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1
	protected void AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89780 Offset: 0xB88980 VA: 0x180B89780
	|-Property<Bounds, Vector3>.AddAttribute
	|
	|-RVA: 0xB89A80 Offset: 0xB88C80 VA: 0x180B89A80
	|-Property<BoundsInt, Vector3Int>.AddAttribute
	|
	|-RVA: 0xB897E0 Offset: 0xB889E0 VA: 0x180B897E0
	|-Property<Color, float>.AddAttribute
	|
	|-RVA: 0xB89A20 Offset: 0xB88C20 VA: 0x180B89A20
	|-Property<object, int>.AddAttribute
	|
	|-RVA: 0xB89840 Offset: 0xB88A40 VA: 0x180B89840
	|-Property<Rect, float>.AddAttribute
	|
	|-RVA: 0xB89900 Offset: 0xB88B00 VA: 0x180B89900
	|-Property<RectInt, int>.AddAttribute
	|
	|-RVA: 0xB89960 Offset: 0xB88B60 VA: 0x180B89960
	|-Property<Vector2, float>.AddAttribute
	|
	|-RVA: 0xB89BA0 Offset: 0xB88DA0 VA: 0x180B89BA0
	|-Property<Vector2Int, int>.AddAttribute
	|
	|-RVA: 0xB898A0 Offset: 0xB88AA0 VA: 0x180B898A0
	|-Property<Vector3, float>.AddAttribute
	|
	|-RVA: 0xB89B40 Offset: 0xB88D40 VA: 0x180B89B40
	|-Property<Vector3Int, int>.AddAttribute
	|
	|-RVA: 0xB89AE0 Offset: 0xB88CE0 VA: 0x180B89AE0
	|-Property<Vector4, float>.AddAttribute
	|
	|-RVA: 0xB899C0 Offset: 0xB88BC0 VA: 0x180B899C0
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttribute
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89D20 Offset: 0xB88F20 VA: 0x180B89D20
	|-Property<Bounds, Vector3>.AddAttributes
	|
	|-RVA: 0xB8A020 Offset: 0xB89220 VA: 0x180B8A020
	|-Property<BoundsInt, Vector3Int>.AddAttributes
	|
	|-RVA: 0xB89EA0 Offset: 0xB890A0 VA: 0x180B89EA0
	|-Property<Color, float>.AddAttributes
	|
	|-RVA: 0xB89CC0 Offset: 0xB88EC0 VA: 0x180B89CC0
	|-Property<object, int>.AddAttributes
	|
	|-RVA: 0xB89DE0 Offset: 0xB88FE0 VA: 0x180B89DE0
	|-Property<Rect, float>.AddAttributes
	|
	|-RVA: 0xB89F60 Offset: 0xB89160 VA: 0x180B89F60
	|-Property<RectInt, int>.AddAttributes
	|
	|-RVA: 0xB89FC0 Offset: 0xB891C0 VA: 0x180B89FC0
	|-Property<Vector2, float>.AddAttributes
	|
	|-RVA: 0xB89D80 Offset: 0xB88F80 VA: 0x180B89D80
	|-Property<Vector2Int, int>.AddAttributes
	|
	|-RVA: 0xB89F00 Offset: 0xB89100 VA: 0x180B89F00
	|-Property<Vector3, float>.AddAttributes
	|
	|-RVA: 0xB89C00 Offset: 0xB88E00 VA: 0x180B89C00
	|-Property<Vector3Int, int>.AddAttributes
	|
	|-RVA: 0xB89E40 Offset: 0xB89040 VA: 0x180B89E40
	|-Property<Vector4, float>.AddAttributes
	|
	|-RVA: 0xB89C60 Offset: 0xB88E60 VA: 0x180B89C60
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8A660 Offset: 0xB89860 VA: 0x180B8A660
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8A500 Offset: 0xB89700 VA: 0x180B8A500
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8AD40 Offset: 0xB89F40 VA: 0x180B8AD40
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8A7C0 Offset: 0xB899C0 VA: 0x180B8A7C0
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8B420 Offset: 0xB8A620 VA: 0x180B8B420
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8ABE0 Offset: 0xB89DE0 VA: 0x180B8ABE0
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8AA80 Offset: 0xB89C80 VA: 0x180B8AA80
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8B2C0 Offset: 0xB8A4C0 VA: 0x180B8B2C0
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8B000 Offset: 0xB8A200 VA: 0x180B8B000
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8AEA0 Offset: 0xB8A0A0 VA: 0x180B8AEA0
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8A920 Offset: 0xB89B20 VA: 0x180B8A920
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0xB8B160 Offset: 0xB8A360 VA: 0x180B8B160
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttribute
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8C000 Offset: 0xB8B200 VA: 0x180B8C000
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8BAC0 Offset: 0xB8ACC0 VA: 0x180B8BAC0
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8B580 Offset: 0xB8A780 VA: 0x180B8B580
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8B820 Offset: 0xB8AA20 VA: 0x180B8B820
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8BD60 Offset: 0xB8AF60 VA: 0x180B8BD60
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8D260 Offset: 0xB8C460 VA: 0x180B8D260
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8CFC0 Offset: 0xB8C1C0 VA: 0x180B8CFC0
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8C540 Offset: 0xB8B740 VA: 0x180B8C540
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8CA80 Offset: 0xB8BC80 VA: 0x180B8CA80
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8CD20 Offset: 0xB8BF20 VA: 0x180B8CD20
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8C2A0 Offset: 0xB8B4A0 VA: 0x180B8C2A0
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0xB8C7E0 Offset: 0xB8B9E0 VA: 0x180B8C7E0
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EED10 Offset: 0x8EDF10 VA: 0x1808EED10
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-Property<Bounds, Vector3>..ctor
	|-Property<BoundsInt, Vector3Int>..ctor
	|-Property<Color, float>..ctor
	|-Property<object, int>..ctor
	|-Property<Rect, float>..ctor
	|-Property<RectInt, int>..ctor
	|-Property<Vector2, float>..ctor
	|-Property<Vector2Int, int>..ctor
	|-Property<Vector3, float>..ctor
	|-Property<Vector3Int, int>..ctor
	|-Property<Vector4, float>..ctor
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
internal interface IMemberInfo // TypeDefIndex: 17375
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Attribute> GetCustomAttributes();
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct FieldMember : IMemberInfo // TypeDefIndex: 17376
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x24F7C70 Offset: 0x24F6E70 VA: 0x1824F7C70
	public void .ctor(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public string get_Name() { }

	// RVA: 0x24F7CA0 Offset: 0x24F6EA0 VA: 0x1824F7CA0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x24F7CC0 Offset: 0x24F6EC0 VA: 0x1824F7CC0 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x24F7C60 Offset: 0x24F6E60 VA: 0x1824F7C60 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct PropertyMember : IMemberInfo // TypeDefIndex: 17377
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public string get_Name() { }

	// RVA: 0x24F8600 Offset: 0x24F7800 VA: 0x1824F8600 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x24F8630 Offset: 0x24F7830 VA: 0x1824F8630 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x24F7C70 Offset: 0x24F6E70 VA: 0x1824F7C70
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x24F7C60 Offset: 0x24F6E60 VA: 0x1824F7C60 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17378
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89620 Offset: 0xB88820 VA: 0x180B89620
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17379
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB896D0 Offset: 0xB888D0 VA: 0x180B896D0
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17380
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211CC0 Offset: 0x1210EC0 VA: 0x181211CC0
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 17381
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF24F0 Offset: 0xBF16F0 VA: 0x180BF24F0
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 17382
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3C60 Offset: 0xBE2E60 VA: 0x180BE3C60
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement> // TypeDefIndex: 17383
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TElement[] InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9BB0 Offset: 0x12A8DB0 VA: 0x1812A9BB0
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TElement[] Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9BF0 Offset: 0x12A8DF0 VA: 0x1812A9BF0
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2600 Offset: 0xBF1800 VA: 0x180BF2600
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer> // TypeDefIndex: 17384
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB8540 Offset: 0xFB7740 VA: 0x180FB8540
	|-ContainerPropertyBag<Bounds>..cctor
	|
	|-RVA: 0xFB88A0 Offset: 0xFB7AA0 VA: 0x180FB88A0
	|-ContainerPropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0xFB8420 Offset: 0xFB7620 VA: 0x180FB8420
	|-ContainerPropertyBag<Color>..cctor
	|
	|-RVA: 0xFB8660 Offset: 0xFB7860 VA: 0x180FB8660
	|-ContainerPropertyBag<object>..cctor
	|
	|-RVA: 0xFB8300 Offset: 0xFB7500 VA: 0x180FB8300
	|-ContainerPropertyBag<Rect>..cctor
	|
	|-RVA: 0xFB8AE0 Offset: 0xFB7CE0 VA: 0x180FB8AE0
	|-ContainerPropertyBag<RectInt>..cctor
	|
	|-RVA: 0xFB89C0 Offset: 0xFB7BC0 VA: 0x180FB89C0
	|-ContainerPropertyBag<Vector2>..cctor
	|
	|-RVA: 0xFB8F60 Offset: 0xFB8160 VA: 0x180FB8F60
	|-ContainerPropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0xFB8C00 Offset: 0xFB7E00 VA: 0x180FB8C00
	|-ContainerPropertyBag<Vector3>..cctor
	|
	|-RVA: 0xFB8D20 Offset: 0xFB7F20 VA: 0x180FB8D20
	|-ContainerPropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0xFB8E40 Offset: 0xFB8040 VA: 0x180FB8E40
	|-ContainerPropertyBag<Vector4>..cctor
	|
	|-RVA: 0xFB8780 Offset: 0xFB7980 VA: 0x180FB8780
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E13E0 Offset: 0x8E05E0 VA: 0x1808E13E0
	|-ContainerPropertyBag<Bounds>.AddProperty<Vector3>
	|-ContainerPropertyBag<BoundsInt>.AddProperty<Vector3Int>
	|-ContainerPropertyBag<Color>.AddProperty<float>
	|-ContainerPropertyBag<object>.AddProperty<int>
	|-ContainerPropertyBag<Rect>.AddProperty<float>
	|-ContainerPropertyBag<RectInt>.AddProperty<int>
	|-ContainerPropertyBag<Vector2>.AddProperty<float>
	|-ContainerPropertyBag<Vector2Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector3>.AddProperty<float>
	|-ContainerPropertyBag<Vector3Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector4>.AddProperty<float>
	|
	|-RVA: 0x8E1320 Offset: 0x8E0520 VA: 0x1808E1320
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB8260 Offset: 0xFB7460 VA: 0x180FB8260
	|-ContainerPropertyBag<Bounds>.TryGetProperty
	|-ContainerPropertyBag<BoundsInt>.TryGetProperty
	|-ContainerPropertyBag<Color>.TryGetProperty
	|-ContainerPropertyBag<object>.TryGetProperty
	|-ContainerPropertyBag<Rect>.TryGetProperty
	|-ContainerPropertyBag<RectInt>.TryGetProperty
	|-ContainerPropertyBag<Vector2>.TryGetProperty
	|-ContainerPropertyBag<Vector2Int>.TryGetProperty
	|-ContainerPropertyBag<Vector3>.TryGetProperty
	|-ContainerPropertyBag<Vector3Int>.TryGetProperty
	|-ContainerPropertyBag<Vector4>.TryGetProperty
	|
	|-RVA: 0xFB82A0 Offset: 0xFB74A0 VA: 0x180FB82A0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB9080 Offset: 0xFB8280 VA: 0x180FB9080
	|-ContainerPropertyBag<Bounds>..ctor
	|-ContainerPropertyBag<BoundsInt>..ctor
	|-ContainerPropertyBag<Color>..ctor
	|-ContainerPropertyBag<object>..ctor
	|-ContainerPropertyBag<Rect>..ctor
	|-ContainerPropertyBag<RectInt>..ctor
	|-ContainerPropertyBag<Vector2>..ctor
	|-ContainerPropertyBag<Vector2Int>..ctor
	|-ContainerPropertyBag<Vector3>..ctor
	|-ContainerPropertyBag<Vector3Int>..ctor
	|-ContainerPropertyBag<Vector4>..ctor
	|
	|-RVA: 0xFB9180 Offset: 0xFB8380 VA: 0x180FB9180
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 17385
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override Dictionary<TKey, TValue> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCDC50 Offset: 0xFCCE50 VA: 0x180FCDC50
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB609F0 Offset: 0xB5FBF0 VA: 0x180B609F0
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement> // TypeDefIndex: 17386
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override HashSet<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCDC50 Offset: 0xFCCE50 VA: 0x180FCDC50
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB609F0 Offset: 0xB5FBF0 VA: 0x180B609F0
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> : Property<TList, TElement> // TypeDefIndex: 17387
{
	// Fields
	internal int m_Index; // 0x0

	// Properties
	public int Index { get; }
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Index
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C6A0 Offset: 0x132B8A0 VA: 0x18132C6A0
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB609F0 Offset: 0xB5FBF0 VA: 0x180B609F0
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IPropertyBag<TList>, IPropertyBag, IConstructorWithCount<TList>, IConstructor // TypeDefIndex: 17388
{
	// Fields
	private readonly IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A790 Offset: 0x1279990 VA: 0x18127A790
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual TList InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A680 Offset: 0x1279880 VA: 0x18127A680
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A890 Offset: 0x1279A90 VA: 0x18127A890
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IPropertyBag // TypeDefIndex: 17389
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ITypeVisitor visitor);
}

// Namespace: Unity.Properties
public interface IPropertyBag<TContainer> : IPropertyBag // TypeDefIndex: 17390
{}

// Namespace: 
private class KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> : Property<TDictionary, KeyValuePair<TKey, TValue>> // TypeDefIndex: 17391
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TKey <Key>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }
	public TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1312030 Offset: 0x1311230 VA: 0x181312030
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311F80 Offset: 0x1311180 VA: 0x181311F80
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1209080 Offset: 0x1208280 VA: 0x181209080
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IPropertyBag<TDictionary>, IPropertyBag // TypeDefIndex: 17392
{
	// Fields
	private readonly KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2710 Offset: 0xBF1910 VA: 0x180BF2710
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class KeyValuePairPropertyBag.<>c<TKey, TValue> // TypeDefIndex: 17393
{
	// Fields
	public static readonly KeyValuePairPropertyBag.<>c<TKey, TValue> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07E90 Offset: 0xB07090 VA: 0x180B07E90
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_0
	*/

	// RVA: -1 Offset: -1
	internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07F30 Offset: 0xB07130 VA: 0x180B07F30
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_1
	*/
}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>> // TypeDefIndex: 17394
{
	// Fields
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty; // 0x0
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07E10 Offset: 0xF07010 VA: 0x180F07E10
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311B00 Offset: 0x1310D00 VA: 0x181311B00
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement> // TypeDefIndex: 17395
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override List<TElement> InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C9B0 Offset: 0x132BBB0 VA: 0x18132C9B0
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override List<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CA20 Offset: 0x132BC20 VA: 0x18132CA20
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2600 Offset: 0xBF1800 VA: 0x180BF2600
	|-ListPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public static class PropertyBag // TypeDefIndex: 17396
{
	// Methods

	// RVA: -1 Offset: -1
	public static void Register<TContainer>(PropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5CC90 Offset: 0xA5BE90 VA: 0x180A5CC90
	|-PropertyBag.Register<Bounds>
	|-PropertyBag.Register<BoundsInt>
	|-PropertyBag.Register<Color>
	|-PropertyBag.Register<object>
	|-PropertyBag.Register<Rect>
	|-PropertyBag.Register<RectInt>
	|-PropertyBag.Register<Vector2>
	|-PropertyBag.Register<Vector2Int>
	|-PropertyBag.Register<Vector3>
	|-PropertyBag.Register<Vector3Int>
	|-PropertyBag.Register<Vector4>
	|
	|-RVA: 0xA5CD00 Offset: 0xA5BF00 VA: 0x180A5CD00
	|-PropertyBag.Register<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor // TypeDefIndex: 17397
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties
	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89070 Offset: 0xB88270 VA: 0x180B89070
	|-PropertyBag<Bounds>..cctor
	|
	|-RVA: 0xB88E30 Offset: 0xB88030 VA: 0x180B88E30
	|-PropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0xB88BF0 Offset: 0xB87DF0 VA: 0x180B88BF0
	|-PropertyBag<Color>..cctor
	|
	|-RVA: 0xB892B0 Offset: 0xB884B0 VA: 0x180B892B0
	|-PropertyBag<object>..cctor
	|
	|-RVA: 0xB88890 Offset: 0xB87A90 VA: 0x180B88890
	|-PropertyBag<Rect>..cctor
	|
	|-RVA: 0xB894F0 Offset: 0xB886F0 VA: 0x180B894F0
	|-PropertyBag<RectInt>..cctor
	|
	|-RVA: 0xB893D0 Offset: 0xB885D0 VA: 0x180B893D0
	|-PropertyBag<Vector2>..cctor
	|
	|-RVA: 0xB88F50 Offset: 0xB88150 VA: 0x180B88F50
	|-PropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0xB88AD0 Offset: 0xB87CD0 VA: 0x180B88AD0
	|-PropertyBag<Vector3>..cctor
	|
	|-RVA: 0xB889B0 Offset: 0xB87BB0 VA: 0x180B889B0
	|-PropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0xB89190 Offset: 0xB88390 VA: 0x180B89190
	|-PropertyBag<Vector4>..cctor
	|
	|-RVA: 0xB88D10 Offset: 0xB87F10 VA: 0x180B88D10
	|-PropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB884A0 Offset: 0xB876A0 VA: 0x180B884A0
	|-PropertyBag<Bounds>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB883C0 Offset: 0xB875C0 VA: 0x180B883C0
	|-PropertyBag<BoundsInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88580 Offset: 0xB87780 VA: 0x180B88580
	|-PropertyBag<Color>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88740 Offset: 0xB87940 VA: 0x180B88740
	|-PropertyBag<object>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB886D0 Offset: 0xB878D0 VA: 0x180B886D0
	|-PropertyBag<Rect>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88350 Offset: 0xB87550 VA: 0x180B88350
	|-PropertyBag<RectInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB885F0 Offset: 0xB877F0 VA: 0x180B885F0
	|-PropertyBag<Vector2>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88660 Offset: 0xB87860 VA: 0x180B88660
	|-PropertyBag<Vector2Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB887B0 Offset: 0xB879B0 VA: 0x180B887B0
	|-PropertyBag<Vector3>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88820 Offset: 0xB87A20 VA: 0x180B88820
	|-PropertyBag<Vector3Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88430 Offset: 0xB87630 VA: 0x180B88430
	|-PropertyBag<Vector4>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0xB88510 Offset: 0xB87710 VA: 0x180B88510
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.Internal.IPropertyBagRegister.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Accept(ITypeVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB87F80 Offset: 0xB87180 VA: 0x180B87F80
	|-PropertyBag<Bounds>.Accept
	|-PropertyBag<BoundsInt>.Accept
	|-PropertyBag<Color>.Accept
	|-PropertyBag<object>.Accept
	|-PropertyBag<Rect>.Accept
	|-PropertyBag<RectInt>.Accept
	|-PropertyBag<Vector2>.Accept
	|-PropertyBag<Vector2Int>.Accept
	|-PropertyBag<Vector3>.Accept
	|-PropertyBag<Vector3Int>.Accept
	|-PropertyBag<Vector4>.Accept
	|-PropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Color>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<object>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Rect>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB88210 Offset: 0xB87410 VA: 0x180B88210
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0xB88170 Offset: 0xB87370 VA: 0x180B88170
	|-PropertyBag<Color>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Rect>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00
	|-PropertyBag<object>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0xB881B0 Offset: 0xB873B0 VA: 0x180B881B0
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0xB881D0 Offset: 0xB873D0 VA: 0x180B881D0
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0xB88260 Offset: 0xB87460 VA: 0x180B88260
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor<TContainer>.Instantiate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	protected virtual InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-PropertyBag<Bounds>.get_InstantiationKind
	|-PropertyBag<BoundsInt>.get_InstantiationKind
	|-PropertyBag<Color>.get_InstantiationKind
	|-PropertyBag<object>.get_InstantiationKind
	|-PropertyBag<Rect>.get_InstantiationKind
	|-PropertyBag<RectInt>.get_InstantiationKind
	|-PropertyBag<Vector2>.get_InstantiationKind
	|-PropertyBag<Vector2Int>.get_InstantiationKind
	|-PropertyBag<Vector3>.get_InstantiationKind
	|-PropertyBag<Vector3Int>.get_InstantiationKind
	|-PropertyBag<Vector4>.get_InstantiationKind
	|-PropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual TContainer Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB88030 Offset: 0xB87230 VA: 0x180B88030
	|-PropertyBag<Bounds>.Instantiate
	|-PropertyBag<BoundsInt>.Instantiate
	|
	|-RVA: 0xB88010 Offset: 0xB87210 VA: 0x180B88010
	|-PropertyBag<Color>.Instantiate
	|-PropertyBag<Rect>.Instantiate
	|-PropertyBag<RectInt>.Instantiate
	|-PropertyBag<Vector4>.Instantiate
	|
	|-RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020
	|-PropertyBag<object>.Instantiate
	|-PropertyBag<Vector2Int>.Instantiate
	|
	|-RVA: 0x775860 Offset: 0x774A60 VA: 0x180775860
	|-PropertyBag<Vector2>.Instantiate
	|
	|-RVA: 0xB87FF0 Offset: 0xB871F0 VA: 0x180B87FF0
	|-PropertyBag<Vector3>.Instantiate
	|-PropertyBag<Vector3Int>.Instantiate
	|
	|-RVA: 0xB88060 Offset: 0xB87260 VA: 0x180B88060
	|-PropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB89610 Offset: 0xB88810 VA: 0x180B89610
	|-PropertyBag<Bounds>..ctor
	|-PropertyBag<BoundsInt>..ctor
	|-PropertyBag<Color>..ctor
	|-PropertyBag<object>..ctor
	|-PropertyBag<Rect>..ctor
	|-PropertyBag<RectInt>..ctor
	|-PropertyBag<Vector2>..ctor
	|-PropertyBag<Vector2Int>..ctor
	|-PropertyBag<Vector3>..ctor
	|-PropertyBag<Vector3Int>..ctor
	|-PropertyBag<Vector4>..ctor
	|-PropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class SetPropertyBagBase.SetElementProperty<TSet, TElement> : Property<TSet, TElement> // TypeDefIndex: 17398
{
	// Fields
	internal TElement m_Value; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2620 Offset: 0xBF1820 VA: 0x180BF2620
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2600 Offset: 0xBF1800 VA: 0x180BF2600
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag // TypeDefIndex: 17399
{
	// Fields
	private readonly SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2710 Offset: 0xBF1910 VA: 0x180BF2710
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface ITypeVisitor // TypeDefIndex: 17400
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public static class TypeTraits // TypeDefIndex: 17401
{
	// Methods

	// RVA: 0x24F97D0 Offset: 0x24F89D0 VA: 0x1824F97D0
	public static bool IsContainer(Type type) { }
}

// Namespace: Unity.Properties
public static class TypeTraits<T> // TypeDefIndex: 17402
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsValueType>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsArray>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsObject>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsString>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Properties
	public static bool IsValueType { get; }
	public static bool IsPrimitive { get; }
	public static bool IsInterface { get; }
	public static bool IsAbstract { get; }
	public static bool IsArray { get; }
	public static bool IsEnum { get; }
	public static bool IsNullable { get; }
	public static bool IsObject { get; }
	public static bool IsString { get; }
	public static bool IsContainer { get; }
	public static bool CanBeNull { get; }
	public static bool IsAbstractOrInterface { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE9C0 Offset: 0xCDDBC0 VA: 0x180CDE9C0
	|-TypeTraits<Bounds>.get_IsValueType
	|-TypeTraits<BoundsInt>.get_IsValueType
	|-TypeTraits<Color>.get_IsValueType
	|-TypeTraits<object>.get_IsValueType
	|-TypeTraits<Rect>.get_IsValueType
	|-TypeTraits<RectInt>.get_IsValueType
	|-TypeTraits<Vector2>.get_IsValueType
	|-TypeTraits<Vector2Int>.get_IsValueType
	|-TypeTraits<Vector3>.get_IsValueType
	|-TypeTraits<Vector3Int>.get_IsValueType
	|-TypeTraits<Vector4>.get_IsValueType
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsValueType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsPrimitive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE880 Offset: 0xCDDA80 VA: 0x180CDE880
	|-TypeTraits<Bounds>.get_IsPrimitive
	|-TypeTraits<BoundsInt>.get_IsPrimitive
	|-TypeTraits<Color>.get_IsPrimitive
	|-TypeTraits<object>.get_IsPrimitive
	|-TypeTraits<Rect>.get_IsPrimitive
	|-TypeTraits<RectInt>.get_IsPrimitive
	|-TypeTraits<Vector2>.get_IsPrimitive
	|-TypeTraits<Vector2Int>.get_IsPrimitive
	|-TypeTraits<Vector3>.get_IsPrimitive
	|-TypeTraits<Vector3Int>.get_IsPrimitive
	|-TypeTraits<Vector4>.get_IsPrimitive
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsPrimitive
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE6A0 Offset: 0xCDD8A0 VA: 0x180CDE6A0
	|-TypeTraits<Bounds>.get_IsInterface
	|-TypeTraits<BoundsInt>.get_IsInterface
	|-TypeTraits<Color>.get_IsInterface
	|-TypeTraits<object>.get_IsInterface
	|-TypeTraits<Rect>.get_IsInterface
	|-TypeTraits<RectInt>.get_IsInterface
	|-TypeTraits<Vector2>.get_IsInterface
	|-TypeTraits<Vector2Int>.get_IsInterface
	|-TypeTraits<Vector3>.get_IsInterface
	|-TypeTraits<Vector3Int>.get_IsInterface
	|-TypeTraits<Vector4>.get_IsInterface
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsInterface
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstract() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE420 Offset: 0xCDD620 VA: 0x180CDE420
	|-TypeTraits<Bounds>.get_IsAbstract
	|-TypeTraits<BoundsInt>.get_IsAbstract
	|-TypeTraits<Color>.get_IsAbstract
	|-TypeTraits<object>.get_IsAbstract
	|-TypeTraits<Rect>.get_IsAbstract
	|-TypeTraits<RectInt>.get_IsAbstract
	|-TypeTraits<Vector2>.get_IsAbstract
	|-TypeTraits<Vector2Int>.get_IsAbstract
	|-TypeTraits<Vector3>.get_IsAbstract
	|-TypeTraits<Vector3Int>.get_IsAbstract
	|-TypeTraits<Vector4>.get_IsAbstract
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstract
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE4C0 Offset: 0xCDD6C0 VA: 0x180CDE4C0
	|-TypeTraits<Bounds>.get_IsArray
	|-TypeTraits<BoundsInt>.get_IsArray
	|-TypeTraits<Color>.get_IsArray
	|-TypeTraits<object>.get_IsArray
	|-TypeTraits<Rect>.get_IsArray
	|-TypeTraits<RectInt>.get_IsArray
	|-TypeTraits<Vector2>.get_IsArray
	|-TypeTraits<Vector2Int>.get_IsArray
	|-TypeTraits<Vector3>.get_IsArray
	|-TypeTraits<Vector3Int>.get_IsArray
	|-TypeTraits<Vector4>.get_IsArray
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsArray
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsEnum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE600 Offset: 0xCDD800 VA: 0x180CDE600
	|-TypeTraits<Bounds>.get_IsEnum
	|-TypeTraits<BoundsInt>.get_IsEnum
	|-TypeTraits<Color>.get_IsEnum
	|-TypeTraits<object>.get_IsEnum
	|-TypeTraits<Rect>.get_IsEnum
	|-TypeTraits<RectInt>.get_IsEnum
	|-TypeTraits<Vector2>.get_IsEnum
	|-TypeTraits<Vector2Int>.get_IsEnum
	|-TypeTraits<Vector3>.get_IsEnum
	|-TypeTraits<Vector3Int>.get_IsEnum
	|-TypeTraits<Vector4>.get_IsEnum
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsEnum
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsNullable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE740 Offset: 0xCDD940 VA: 0x180CDE740
	|-TypeTraits<Bounds>.get_IsNullable
	|-TypeTraits<BoundsInt>.get_IsNullable
	|-TypeTraits<Color>.get_IsNullable
	|-TypeTraits<object>.get_IsNullable
	|-TypeTraits<Rect>.get_IsNullable
	|-TypeTraits<RectInt>.get_IsNullable
	|-TypeTraits<Vector2>.get_IsNullable
	|-TypeTraits<Vector2Int>.get_IsNullable
	|-TypeTraits<Vector3>.get_IsNullable
	|-TypeTraits<Vector3Int>.get_IsNullable
	|-TypeTraits<Vector4>.get_IsNullable
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsNullable
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE7E0 Offset: 0xCDD9E0 VA: 0x180CDE7E0
	|-TypeTraits<Bounds>.get_IsObject
	|-TypeTraits<BoundsInt>.get_IsObject
	|-TypeTraits<Color>.get_IsObject
	|-TypeTraits<object>.get_IsObject
	|-TypeTraits<Rect>.get_IsObject
	|-TypeTraits<RectInt>.get_IsObject
	|-TypeTraits<Vector2>.get_IsObject
	|-TypeTraits<Vector2Int>.get_IsObject
	|-TypeTraits<Vector3>.get_IsObject
	|-TypeTraits<Vector3Int>.get_IsObject
	|-TypeTraits<Vector4>.get_IsObject
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsObject
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE920 Offset: 0xCDDB20 VA: 0x180CDE920
	|-TypeTraits<Bounds>.get_IsString
	|-TypeTraits<BoundsInt>.get_IsString
	|-TypeTraits<Color>.get_IsString
	|-TypeTraits<object>.get_IsString
	|-TypeTraits<Rect>.get_IsString
	|-TypeTraits<RectInt>.get_IsString
	|-TypeTraits<Vector2>.get_IsString
	|-TypeTraits<Vector2Int>.get_IsString
	|-TypeTraits<Vector3>.get_IsString
	|-TypeTraits<Vector3Int>.get_IsString
	|-TypeTraits<Vector4>.get_IsString
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsString
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsContainer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE560 Offset: 0xCDD760 VA: 0x180CDE560
	|-TypeTraits<Bounds>.get_IsContainer
	|-TypeTraits<BoundsInt>.get_IsContainer
	|-TypeTraits<Color>.get_IsContainer
	|-TypeTraits<object>.get_IsContainer
	|-TypeTraits<Rect>.get_IsContainer
	|-TypeTraits<RectInt>.get_IsContainer
	|-TypeTraits<Vector2>.get_IsContainer
	|-TypeTraits<Vector2Int>.get_IsContainer
	|-TypeTraits<Vector3>.get_IsContainer
	|-TypeTraits<Vector3Int>.get_IsContainer
	|-TypeTraits<Vector4>.get_IsContainer
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_CanBeNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE2E0 Offset: 0xCDD4E0 VA: 0x180CDE2E0
	|-TypeTraits<Bounds>.get_CanBeNull
	|-TypeTraits<BoundsInt>.get_CanBeNull
	|-TypeTraits<Color>.get_CanBeNull
	|-TypeTraits<object>.get_CanBeNull
	|-TypeTraits<Rect>.get_CanBeNull
	|-TypeTraits<RectInt>.get_CanBeNull
	|-TypeTraits<Vector2>.get_CanBeNull
	|-TypeTraits<Vector2Int>.get_CanBeNull
	|-TypeTraits<Vector3>.get_CanBeNull
	|-TypeTraits<Vector3Int>.get_CanBeNull
	|-TypeTraits<Vector4>.get_CanBeNull
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_CanBeNull
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstractOrInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDE380 Offset: 0xCDD580 VA: 0x180CDE380
	|-TypeTraits<Bounds>.get_IsAbstractOrInterface
	|-TypeTraits<BoundsInt>.get_IsAbstractOrInterface
	|-TypeTraits<Color>.get_IsAbstractOrInterface
	|-TypeTraits<object>.get_IsAbstractOrInterface
	|-TypeTraits<Rect>.get_IsAbstractOrInterface
	|-TypeTraits<RectInt>.get_IsAbstractOrInterface
	|-TypeTraits<Vector2>.get_IsAbstractOrInterface
	|-TypeTraits<Vector2Int>.get_IsAbstractOrInterface
	|-TypeTraits<Vector3>.get_IsAbstractOrInterface
	|-TypeTraits<Vector3Int>.get_IsAbstractOrInterface
	|-TypeTraits<Vector4>.get_IsAbstractOrInterface
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstractOrInterface
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDC8C0 Offset: 0xCDBAC0 VA: 0x180CDC8C0
	|-TypeTraits<Bounds>..cctor
	|
	|-RVA: 0xCD4930 Offset: 0xCD3B30 VA: 0x180CD4930
	|-TypeTraits<BoundsInt>..cctor
	|
	|-RVA: 0xCD8A80 Offset: 0xCD7C80 VA: 0x180CD8A80
	|-TypeTraits<Color>..cctor
	|
	|-RVA: 0xCDBBB0 Offset: 0xCDADB0 VA: 0x180CDBBB0
	|-TypeTraits<object>..cctor
	|
	|-RVA: 0xCD6350 Offset: 0xCD5550 VA: 0x180CD6350
	|-TypeTraits<Rect>..cctor
	|
	|-RVA: 0xCDD5D0 Offset: 0xCDC7D0 VA: 0x180CDD5D0
	|-TypeTraits<RectInt>..cctor
	|
	|-RVA: 0xCD7D70 Offset: 0xCD6F70 VA: 0x180CD7D70
	|-TypeTraits<Vector2>..cctor
	|
	|-RVA: 0xCD7060 Offset: 0xCD6260 VA: 0x180CD7060
	|-TypeTraits<Vector2Int>..cctor
	|
	|-RVA: 0xCD5640 Offset: 0xCD4840 VA: 0x180CD5640
	|-TypeTraits<Vector3>..cctor
	|
	|-RVA: 0xCD9790 Offset: 0xCD8990 VA: 0x180CD9790
	|-TypeTraits<Vector3Int>..cctor
	|
	|-RVA: 0xCDAEA0 Offset: 0xCDA0A0 VA: 0x180CDAEA0
	|-TypeTraits<Vector4>..cctor
	|
	|-RVA: 0xCDA4A0 Offset: 0xCD96A0 VA: 0x180CDA4A0
	|-TypeTraits<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public enum InstantiationKind // TypeDefIndex: 17403
{
	// Fields
	public int value__; // 0x0
	public const InstantiationKind Activator = 0;
	public const InstantiationKind PropertyBagOverride = 1;
	public const InstantiationKind NotInstantiatable = 2;
}

// Namespace: Unity.Properties
internal interface IConstructor // TypeDefIndex: 17404
{
	// Properties
	public abstract InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InstantiationKind get_InstantiationKind();
}

// Namespace: Unity.Properties
internal interface IConstructor<T> : IConstructor // TypeDefIndex: 17405
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/
}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T> : IConstructor // TypeDefIndex: 17406
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T InstantiateWithCount(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructorWithCount<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/
}

// Namespace: 
private interface TypeUtility.ITypeConstructor // TypeDefIndex: 17407
{
	// Properties
	public abstract bool CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_CanBeInstantiated();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Instantiate();
}

// Namespace: 
private interface TypeUtility.ITypeConstructor<T> : TypeUtility.ITypeConstructor // TypeDefIndex: 17408
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetExplicitConstructor(Func<T> constructor);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/
}

// Namespace: 
private class TypeUtility.TypeConstructor<T> : TypeUtility.ITypeConstructor<T>, TypeUtility.ITypeConstructor // TypeDefIndex: 17409
{
	// Fields
	private Func<T> m_ExplicitConstructor; // 0x0
	private Func<T> m_ImplicitConstructor; // 0x0
	private IConstructor<T> m_OverrideConstructor; // 0x0

	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD1630 Offset: 0xCD0830 VA: 0x180CD1630
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD1510 Offset: 0xCD0710 VA: 0x180CD1510
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD13F0 Offset: 0xCD05F0 VA: 0x180CD13F0
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD16C0 Offset: 0xCD08C0 VA: 0x180CD16C0
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD1480 Offset: 0xCD0680 VA: 0x180CD1480
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD1750 Offset: 0xCD0950 VA: 0x180CD1750
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD15A0 Offset: 0xCD07A0 VA: 0x180CD15A0
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD43F0 Offset: 0xCD35F0 VA: 0x180CD43F0
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD4360 Offset: 0xCD3560 VA: 0x180CD4360
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD4240 Offset: 0xCD3440 VA: 0x180CD4240
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD42D0 Offset: 0xCD34D0 VA: 0x180CD42D0
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0xCD41B0 Offset: 0xCD33B0 VA: 0x180CD41B0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD1BA0 Offset: 0xCD0DA0 VA: 0x180CD1BA0
	|-TypeUtility.TypeConstructor<Bounds>..ctor
	|
	|-RVA: 0xCD1C90 Offset: 0xCD0E90 VA: 0x180CD1C90
	|-TypeUtility.TypeConstructor<BoundsInt>..ctor
	|
	|-RVA: 0xCD19C0 Offset: 0xCD0BC0 VA: 0x180CD19C0
	|-TypeUtility.TypeConstructor<Color>..ctor
	|
	|-RVA: 0xCD17E0 Offset: 0xCD09E0 VA: 0x180CD17E0
	|-TypeUtility.TypeConstructor<object>..ctor
	|
	|-RVA: 0xCD1D80 Offset: 0xCD0F80 VA: 0x180CD1D80
	|-TypeUtility.TypeConstructor<Rect>..ctor
	|
	|-RVA: 0xCD18D0 Offset: 0xCD0AD0 VA: 0x180CD18D0
	|-TypeUtility.TypeConstructor<RectInt>..ctor
	|
	|-RVA: 0xCD1AB0 Offset: 0xCD0CB0 VA: 0x180CD1AB0
	|-TypeUtility.TypeConstructor<Vector2>..ctor
	|
	|-RVA: 0xCD4660 Offset: 0xCD3860 VA: 0x180CD4660
	|-TypeUtility.TypeConstructor<Vector2Int>..ctor
	|
	|-RVA: 0xCD4840 Offset: 0xCD3A40 VA: 0x180CD4840
	|-TypeUtility.TypeConstructor<Vector3>..ctor
	|
	|-RVA: 0xCD4570 Offset: 0xCD3770 VA: 0x180CD4570
	|-TypeUtility.TypeConstructor<Vector3Int>..ctor
	|
	|-RVA: 0xCD4750 Offset: 0xCD3950 VA: 0x180CD4750
	|-TypeUtility.TypeConstructor<Vector4>..ctor
	|
	|-RVA: 0xCD4480 Offset: 0xCD3680 VA: 0x180CD4480
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SetImplicitConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCF320 Offset: 0xCCE520 VA: 0x180CCF320
	|-TypeUtility.TypeConstructor<Bounds>.SetImplicitConstructor
	|
	|-RVA: 0xCCF550 Offset: 0xCCE750 VA: 0x180CCF550
	|-TypeUtility.TypeConstructor<BoundsInt>.SetImplicitConstructor
	|
	|-RVA: 0xCCFBE0 Offset: 0xCCEDE0 VA: 0x180CCFBE0
	|-TypeUtility.TypeConstructor<Color>.SetImplicitConstructor
	|
	|-RVA: 0xCCF9B0 Offset: 0xCCEBB0 VA: 0x180CCF9B0
	|-TypeUtility.TypeConstructor<object>.SetImplicitConstructor
	|
	|-RVA: 0xCCFE10 Offset: 0xCCF010 VA: 0x180CCFE10
	|-TypeUtility.TypeConstructor<Rect>.SetImplicitConstructor
	|
	|-RVA: 0xCCF780 Offset: 0xCCE980 VA: 0x180CCF780
	|-TypeUtility.TypeConstructor<RectInt>.SetImplicitConstructor
	|
	|-RVA: 0xCCF0F0 Offset: 0xCCE2F0 VA: 0x180CCF0F0
	|-TypeUtility.TypeConstructor<Vector2>.SetImplicitConstructor
	|
	|-RVA: 0xCD30C0 Offset: 0xCD22C0 VA: 0x180CD30C0
	|-TypeUtility.TypeConstructor<Vector2Int>.SetImplicitConstructor
	|
	|-RVA: 0xCD2E90 Offset: 0xCD2090 VA: 0x180CD2E90
	|-TypeUtility.TypeConstructor<Vector3>.SetImplicitConstructor
	|
	|-RVA: 0xCD2C60 Offset: 0xCD1E60 VA: 0x180CD2C60
	|-TypeUtility.TypeConstructor<Vector3Int>.SetImplicitConstructor
	|
	|-RVA: 0xCD27F0 Offset: 0xCD19F0 VA: 0x180CD27F0
	|-TypeUtility.TypeConstructor<Vector4>.SetImplicitConstructor
	|
	|-RVA: 0xCD2A20 Offset: 0xCD1C20 VA: 0x180CD2A20
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetImplicitConstructor
	*/

	// RVA: -1 Offset: -1
	private static T CreateValueTypeInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB88030 Offset: 0xB87230 VA: 0x180B88030
	|-TypeUtility.TypeConstructor<Bounds>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateValueTypeInstance
	|
	|-RVA: 0xB88010 Offset: 0xB87210 VA: 0x180B88010
	|-TypeUtility.TypeConstructor<Color>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<Rect>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<RectInt>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<Vector4>.CreateValueTypeInstance
	|
	|-RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020
	|-TypeUtility.TypeConstructor<object>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateValueTypeInstance
	|
	|-RVA: 0xCCF0E0 Offset: 0xCCE2E0 VA: 0x180CCF0E0
	|-TypeUtility.TypeConstructor<Vector2>.CreateValueTypeInstance
	|
	|-RVA: 0xB87FF0 Offset: 0xB871F0 VA: 0x180B87FF0
	|-TypeUtility.TypeConstructor<Vector3>.CreateValueTypeInstance
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateValueTypeInstance
	|
	|-RVA: 0xCD26D0 Offset: 0xCD18D0 VA: 0x180CD26D0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateValueTypeInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateScriptableObjectInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCEEE0 Offset: 0xCCE0E0 VA: 0x180CCEEE0
	|-TypeUtility.TypeConstructor<Bounds>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCEDD0 Offset: 0xCCDFD0 VA: 0x180CCEDD0
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCEBD0 Offset: 0xCCDDD0 VA: 0x180CCEBD0
	|-TypeUtility.TypeConstructor<Color>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCEFF0 Offset: 0xCCE1F0 VA: 0x180CCEFF0
	|-TypeUtility.TypeConstructor<object>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCECD0 Offset: 0xCCDED0 VA: 0x180CCECD0
	|-TypeUtility.TypeConstructor<Rect>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCEAD0 Offset: 0xCCDCD0 VA: 0x180CCEAD0
	|-TypeUtility.TypeConstructor<RectInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCCE9E0 Offset: 0xCCDBE0 VA: 0x180CCE9E0
	|-TypeUtility.TypeConstructor<Vector2>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCD2260 Offset: 0xCD1460 VA: 0x180CD2260
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCD2440 Offset: 0xCD1640 VA: 0x180CD2440
	|-TypeUtility.TypeConstructor<Vector3>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCD2340 Offset: 0xCD1540 VA: 0x180CD2340
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCD2160 Offset: 0xCD1360 VA: 0x180CD2160
	|-TypeUtility.TypeConstructor<Vector4>.CreateScriptableObjectInstance
	|
	|-RVA: 0xCD2540 Offset: 0xCD1740 VA: 0x180CD2540
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateScriptableObjectInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateClassInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCCE950 Offset: 0xCCDB50 VA: 0x180CCE950
	|-TypeUtility.TypeConstructor<Bounds>.CreateClassInstance
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateClassInstance
	|
	|-RVA: 0xCCE900 Offset: 0xCCDB00 VA: 0x180CCE900
	|-TypeUtility.TypeConstructor<Color>.CreateClassInstance
	|-TypeUtility.TypeConstructor<Rect>.CreateClassInstance
	|-TypeUtility.TypeConstructor<RectInt>.CreateClassInstance
	|-TypeUtility.TypeConstructor<Vector4>.CreateClassInstance
	|
	|-RVA: 0xCCE8D0 Offset: 0xCCDAD0 VA: 0x180CCE8D0
	|-TypeUtility.TypeConstructor<object>.CreateClassInstance
	|
	|-RVA: 0xCCE9B0 Offset: 0xCCDBB0 VA: 0x180CCE9B0
	|-TypeUtility.TypeConstructor<Vector2>.CreateClassInstance
	|
	|-RVA: 0xCD2130 Offset: 0xCD1330 VA: 0x180CD2130
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateClassInstance
	|
	|-RVA: 0xCD1F90 Offset: 0xCD1190 VA: 0x180CD1F90
	|-TypeUtility.TypeConstructor<Vector3>.CreateClassInstance
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateClassInstance
	|
	|-RVA: 0xCD1FF0 Offset: 0xCD11F0 VA: 0x180CD1FF0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateClassInstance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetExplicitConstructor(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	|-TypeUtility.TypeConstructor<Bounds>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<BoundsInt>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Color>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<object>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Rect>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<RectInt>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Vector2>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Vector2Int>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Vector3>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Vector3Int>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<Vector4>.SetExplicitConstructor
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD02D0 Offset: 0xCCF4D0 VA: 0x180CD02D0
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD0040 Offset: 0xCCF240 VA: 0x180CD0040
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD0CB0 Offset: 0xCCFEB0 VA: 0x180CD0CB0
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD0560 Offset: 0xCCF760 VA: 0x180CD0560
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD07D0 Offset: 0xCCF9D0 VA: 0x180CD07D0
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD0F30 Offset: 0xCD0130 VA: 0x180CD0F30
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD0A50 Offset: 0xCCFC50 VA: 0x180CD0A50
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD3D90 Offset: 0xCD2F90 VA: 0x180CD3D90
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD3570 Offset: 0xCD2770 VA: 0x180CD3570
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD3B10 Offset: 0xCD2D10 VA: 0x180CD3B10
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD32F0 Offset: 0xCD24F0 VA: 0x180CD32F0
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0xCD37F0 Offset: 0xCD29F0 VA: 0x180CD37F0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD1230 Offset: 0xCD0430 VA: 0x180CD1230
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0xCD12C0 Offset: 0xCD04C0 VA: 0x180CD12C0
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0xCD13A0 Offset: 0xCD05A0 VA: 0x180CD13A0
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0xCD11B0 Offset: 0xCD03B0 VA: 0x180CD11B0
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0xCD4000 Offset: 0xCD3200 VA: 0x180CD4000
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0xCD40F0 Offset: 0xCD32F0 VA: 0x180CD40F0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	*/
}

// Namespace: 
private class TypeUtility.NonConstructable : TypeUtility.ITypeConstructor // TypeDefIndex: 17410
{
	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x24F7FC0 Offset: 0x24F71C0 VA: 0x1824F7FC0 Slot: 5
	public object Instantiate() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct TypeUtility.Cache<T> // TypeDefIndex: 17411
{
	// Fields
	public static TypeUtility.ITypeConstructor<T> TypeConstructor; // 0x0
}

// Namespace: 
private class TypeUtility.TypeConstructorVisitor : ITypeVisitor // TypeDefIndex: 17412
{
	// Fields
	public TypeUtility.ITypeConstructor TypeConstructor; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Visit<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD5600 Offset: 0xAD4800 VA: 0x180AD5600
	|-TypeUtility.TypeConstructorVisitor.Visit<Bounds>
	|
	|-RVA: 0xAD5590 Offset: 0xAD4790 VA: 0x180AD5590
	|-TypeUtility.TypeConstructorVisitor.Visit<BoundsInt>
	|
	|-RVA: 0xAD5670 Offset: 0xAD4870 VA: 0x180AD5670
	|-TypeUtility.TypeConstructorVisitor.Visit<Color>
	|
	|-RVA: 0xAD5830 Offset: 0xAD4A30 VA: 0x180AD5830
	|-TypeUtility.TypeConstructorVisitor.Visit<object>
	|
	|-RVA: 0xAD57C0 Offset: 0xAD49C0 VA: 0x180AD57C0
	|-TypeUtility.TypeConstructorVisitor.Visit<Rect>
	|
	|-RVA: 0xAD5750 Offset: 0xAD4950 VA: 0x180AD5750
	|-TypeUtility.TypeConstructorVisitor.Visit<RectInt>
	|
	|-RVA: 0xAD5910 Offset: 0xAD4B10 VA: 0x180AD5910
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector2>
	|
	|-RVA: 0xAD58A0 Offset: 0xAD4AA0 VA: 0x180AD58A0
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector2Int>
	|
	|-RVA: 0xAD59F0 Offset: 0xAD4BF0 VA: 0x180AD59F0
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector3>
	|
	|-RVA: 0xAD5980 Offset: 0xAD4B80 VA: 0x180AD5980
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector3Int>
	|
	|-RVA: 0xAD5A60 Offset: 0xAD4C60 VA: 0x180AD5A60
	|-TypeUtility.TypeConstructorVisitor.Visit<Vector4>
	|
	|-RVA: 0xAD56E0 Offset: 0xAD48E0 VA: 0x180AD56E0
	|-TypeUtility.TypeConstructorVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeUtility.<>c // TypeDefIndex: 17413
{
	// Fields
	public static readonly TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x24FBAA0 Offset: 0x24FACA0 VA: 0x1824FBAA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24FB960 Offset: 0x24FAB60 VA: 0x1824FB960
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x24FB9B0 Offset: 0x24FABB0 VA: 0x1824FB9B0
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x24FB9D0 Offset: 0x24FABD0 VA: 0x1824FB9D0
	internal string <.cctor>b__11_2() { }
}

// Namespace: Unity.Properties
[Extension]
public static class TypeUtility // TypeDefIndex: 17414
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x24FABD0 Offset: 0x24F9DD0 VA: 0x1824FABD0
	private static void .cctor() { }

	// RVA: 0x24FA130 Offset: 0x24F9330 VA: 0x1824FA130
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x24FA250 Offset: 0x24F9450 VA: 0x1824FA250
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x24F9F50 Offset: 0x24F9150 VA: 0x1824F9F50
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x24F9C80 Offset: 0x24F8E80 VA: 0x1824F9C80
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA88720 Offset: 0xA87920 VA: 0x180A88720
	|-TypeUtility.CreateTypeConstructor<Bounds>
	|
	|-RVA: 0xA885E0 Offset: 0xA877E0 VA: 0x180A885E0
	|-TypeUtility.CreateTypeConstructor<BoundsInt>
	|
	|-RVA: 0xA88860 Offset: 0xA87A60 VA: 0x180A88860
	|-TypeUtility.CreateTypeConstructor<Color>
	|
	|-RVA: 0xA88D60 Offset: 0xA87F60 VA: 0x180A88D60
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0xA88C20 Offset: 0xA87E20 VA: 0x180A88C20
	|-TypeUtility.CreateTypeConstructor<Rect>
	|
	|-RVA: 0xA88AE0 Offset: 0xA87CE0 VA: 0x180A88AE0
	|-TypeUtility.CreateTypeConstructor<RectInt>
	|
	|-RVA: 0xA88FE0 Offset: 0xA881E0 VA: 0x180A88FE0
	|-TypeUtility.CreateTypeConstructor<Vector2>
	|
	|-RVA: 0xA88EA0 Offset: 0xA880A0 VA: 0x180A88EA0
	|-TypeUtility.CreateTypeConstructor<Vector2Int>
	|
	|-RVA: 0xA89260 Offset: 0xA88460 VA: 0x180A89260
	|-TypeUtility.CreateTypeConstructor<Vector3>
	|
	|-RVA: 0xA89120 Offset: 0xA88320 VA: 0x180A89120
	|-TypeUtility.CreateTypeConstructor<Vector3Int>
	|
	|-RVA: 0xA893A0 Offset: 0xA885A0 VA: 0x180A893A0
	|-TypeUtility.CreateTypeConstructor<Vector4>
	|
	|-RVA: 0xA889A0 Offset: 0xA87BA0 VA: 0x180A889A0
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24FA070 Offset: 0x24F9270 VA: 0x1824FA070
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA89590 Offset: 0xA88790 VA: 0x180A89590
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0xA894E0 Offset: 0xA886E0 VA: 0x180A894E0
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24F9910 Offset: 0x24F8B10 VA: 0x1824F9910
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA88440 Offset: 0xA87640 VA: 0x180A88440
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A420 Offset: 0xA89620 VA: 0x180A8A420
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0xA8A310 Offset: 0xA89510 VA: 0x180A8A310
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA89FF0 Offset: 0xA891F0 VA: 0x180A89FF0
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A980 Offset: 0xA89B80 VA: 0x180A8A980
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A150 Offset: 0xA89350 VA: 0x180A8A150
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A7B0 Offset: 0xA899B0 VA: 0x180A8A7B0
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA89BB0 Offset: 0xA88DB0 VA: 0x180A89BB0
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A530 Offset: 0xA89730 VA: 0x180A8A530
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA89770 Offset: 0xA88970 VA: 0x180A89770
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24F9B00 Offset: 0x24F8D00 VA: 0x1824F9B00
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA884C0 Offset: 0xA876C0 VA: 0x180A884C0
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24F9A20 Offset: 0x24F8C20 VA: 0x1824F9A20
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}

// Namespace: Unity.Properties.Internal
internal interface IAttributes // TypeDefIndex: 17415
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddAttribute(Attribute attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddAttributes(IEnumerable<Attribute> attributes);
}

// Namespace: Unity.Properties.Internal
internal static class DefaultPropertyBagInitializer // TypeDefIndex: 17416
{
	// Methods

	// RVA: 0x24F6BA0 Offset: 0x24F5DA0 VA: 0x1824F6BA0
	internal static void Initialize() { }
}

// Namespace: 
private class ColorPropertyBag.RProperty : Property<Color, float> // TypeDefIndex: 17417
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F86A0 Offset: 0x24F78A0 VA: 0x1824F86A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F8660 Offset: 0x24F7860 VA: 0x1824F8660
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.GProperty : Property<Color, float> // TypeDefIndex: 17418
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7D30 Offset: 0x24F6F30 VA: 0x1824F7D30 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F7CF0 Offset: 0x24F6EF0 VA: 0x1824F7CF0
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.BProperty : Property<Color, float> // TypeDefIndex: 17419
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F6630 Offset: 0x24F5830 VA: 0x1824F6630 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F65F0 Offset: 0x24F57F0 VA: 0x1824F65F0
	public void .ctor() { }
}

// Namespace: 
private class ColorPropertyBag.AProperty : Property<Color, float> // TypeDefIndex: 17420
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F65C0 Offset: 0x24F57C0 VA: 0x1824F65C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F6580 Offset: 0x24F5780 VA: 0x1824F6580
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag : ContainerPropertyBag<Color> // TypeDefIndex: 17421
{
	// Methods

	// RVA: 0x24F69D0 Offset: 0x24F5BD0 VA: 0x1824F69D0
	public void .ctor() { }
}

// Namespace: 
private class Vector2PropertyBag.XProperty : Property<Vector2, float> // TypeDefIndex: 17422
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC580 Offset: 0x24FB780 VA: 0x1824FC580 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC3C0 Offset: 0x24FB5C0 VA: 0x1824FC3C0
	public void .ctor() { }
}

// Namespace: 
private class Vector2PropertyBag.YProperty : Property<Vector2, float> // TypeDefIndex: 17423
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC980 Offset: 0x24FBB80 VA: 0x1824FC980 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC810 Offset: 0x24FBA10 VA: 0x1824FC810
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2> // TypeDefIndex: 17424
{
	// Methods

	// RVA: 0x24FBC80 Offset: 0x24FAE80 VA: 0x1824FBC80
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.XProperty : Property<Vector3, float> // TypeDefIndex: 17425
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC640 Offset: 0x24FB840 VA: 0x1824FC640 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC400 Offset: 0x24FB600 VA: 0x1824FC400
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.YProperty : Property<Vector3, float> // TypeDefIndex: 17426
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC9B0 Offset: 0x24FBBB0 VA: 0x1824FC9B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC790 Offset: 0x24FB990 VA: 0x1824FC790
	public void .ctor() { }
}

// Namespace: 
private class Vector3PropertyBag.ZProperty : Property<Vector3, float> // TypeDefIndex: 17427
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FCAD0 Offset: 0x24FBCD0 VA: 0x1824FCAD0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FCA60 Offset: 0x24FBC60 VA: 0x1824FCA60
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag : ContainerPropertyBag<Vector3> // TypeDefIndex: 17428
{
	// Methods

	// RVA: 0x24FBF20 Offset: 0x24FB120 VA: 0x1824FBF20
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.XProperty : Property<Vector4, float> // TypeDefIndex: 17429
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC5B0 Offset: 0x24FB7B0 VA: 0x1824FC5B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC500 Offset: 0x24FB700 VA: 0x1824FC500
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.YProperty : Property<Vector4, float> // TypeDefIndex: 17430
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC890 Offset: 0x24FBA90 VA: 0x1824FC890 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC750 Offset: 0x24FB950 VA: 0x1824FC750
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.ZProperty : Property<Vector4, float> // TypeDefIndex: 17431
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FCB00 Offset: 0x24FBD00 VA: 0x1824FCB00 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC9E0 Offset: 0x24FBBE0 VA: 0x1824FC9E0
	public void .ctor() { }
}

// Namespace: 
private class Vector4PropertyBag.WProperty : Property<Vector4, float> // TypeDefIndex: 17432
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC2B0 Offset: 0x24FB4B0 VA: 0x1824FC2B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC270 Offset: 0x24FB470 VA: 0x1824FC270
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag : ContainerPropertyBag<Vector4> // TypeDefIndex: 17433
{
	// Methods

	// RVA: 0x24FC0A0 Offset: 0x24FB2A0 VA: 0x1824FC0A0
	public void .ctor() { }
}

// Namespace: 
private class Vector2IntPropertyBag.XProperty : Property<Vector2Int, int> // TypeDefIndex: 17434
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC670 Offset: 0x24FB870 VA: 0x1824FC670 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC440 Offset: 0x24FB640 VA: 0x1824FC440
	public void .ctor() { }
}

// Namespace: 
private class Vector2IntPropertyBag.YProperty : Property<Vector2Int, int> // TypeDefIndex: 17435
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC8C0 Offset: 0x24FBAC0 VA: 0x1824FC8C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC850 Offset: 0x24FBA50 VA: 0x1824FC850
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int> // TypeDefIndex: 17436
{
	// Methods

	// RVA: 0x24FBB60 Offset: 0x24FAD60 VA: 0x1824FBB60
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.XProperty : Property<Vector3Int, int> // TypeDefIndex: 17437
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC5E0 Offset: 0x24FB7E0 VA: 0x1824FC5E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC480 Offset: 0x24FB680 VA: 0x1824FC480
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.YProperty : Property<Vector3Int, int> // TypeDefIndex: 17438
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC920 Offset: 0x24FBB20 VA: 0x1824FC920 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC710 Offset: 0x24FB910 VA: 0x1824FC710
	public void .ctor() { }
}

// Namespace: 
private class Vector3IntPropertyBag.ZProperty : Property<Vector3Int, int> // TypeDefIndex: 17439
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FCAA0 Offset: 0x24FBCA0 VA: 0x1824FCAA0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FCA20 Offset: 0x24FBC20 VA: 0x1824FCA20
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int> // TypeDefIndex: 17440
{
	// Methods

	// RVA: 0x24FBDA0 Offset: 0x24FAFA0 VA: 0x1824FBDA0
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.XProperty : Property<Rect, float> // TypeDefIndex: 17441
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC610 Offset: 0x24FB810 VA: 0x1824FC610 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC4C0 Offset: 0x24FB6C0 VA: 0x1824FC4C0
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.YProperty : Property<Rect, float> // TypeDefIndex: 17442
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC950 Offset: 0x24FBB50 VA: 0x1824FC950 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC6D0 Offset: 0x24FB8D0 VA: 0x1824FC6D0
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.WidthProperty : Property<Rect, float> // TypeDefIndex: 17443
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC360 Offset: 0x24FB560 VA: 0x1824FC360 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC320 Offset: 0x24FB520 VA: 0x1824FC320
	public void .ctor() { }
}

// Namespace: 
private class RectPropertyBag.HeightProperty : Property<Rect, float> // TypeDefIndex: 17444
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7E10 Offset: 0x24F7010 VA: 0x1824F7E10 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F7D60 Offset: 0x24F6F60 VA: 0x1824F7D60
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag : ContainerPropertyBag<Rect> // TypeDefIndex: 17445
{
	// Methods

	// RVA: 0x24F88A0 Offset: 0x24F7AA0 VA: 0x1824F88A0
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.XProperty : Property<RectInt, int> // TypeDefIndex: 17446
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC6A0 Offset: 0x24FB8A0 VA: 0x1824FC6A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC540 Offset: 0x24FB740 VA: 0x1824FC540
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.YProperty : Property<RectInt, int> // TypeDefIndex: 17447
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC8F0 Offset: 0x24FBAF0 VA: 0x1824FC8F0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC7D0 Offset: 0x24FB9D0 VA: 0x1824FC7D0
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.WidthProperty : Property<RectInt, int> // TypeDefIndex: 17448
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24FC390 Offset: 0x24FB590 VA: 0x1824FC390 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FC2E0 Offset: 0x24FB4E0 VA: 0x1824FC2E0
	public void .ctor() { }
}

// Namespace: 
private class RectIntPropertyBag.HeightProperty : Property<RectInt, int> // TypeDefIndex: 17449
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7DE0 Offset: 0x24F6FE0 VA: 0x1824F7DE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F7DA0 Offset: 0x24F6FA0 VA: 0x1824F7DA0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag : ContainerPropertyBag<RectInt> // TypeDefIndex: 17450
{
	// Methods

	// RVA: 0x24F86D0 Offset: 0x24F78D0 VA: 0x1824F86D0
	public void .ctor() { }
}

// Namespace: 
private class BoundsPropertyBag.CenterProperty : Property<Bounds, Vector3> // TypeDefIndex: 17451
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F69A0 Offset: 0x24F5BA0 VA: 0x1824F69A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F6960 Offset: 0x24F5B60 VA: 0x1824F6960
	public void .ctor() { }
}

// Namespace: 
private class BoundsPropertyBag.ExtentsProperty : Property<Bounds, Vector3> // TypeDefIndex: 17452
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7C30 Offset: 0x24F6E30 VA: 0x1824F7C30 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F7BF0 Offset: 0x24F6DF0 VA: 0x1824F7BF0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds> // TypeDefIndex: 17453
{
	// Methods

	// RVA: 0x24F6780 Offset: 0x24F5980 VA: 0x1824F6780
	public void .ctor() { }
}

// Namespace: 
private class BoundsIntPropertyBag.PositionProperty : Property<BoundsInt, Vector3Int> // TypeDefIndex: 17454
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F8050 Offset: 0x24F7250 VA: 0x1824F8050 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F8010 Offset: 0x24F7210 VA: 0x1824F8010
	public void .ctor() { }
}

// Namespace: 
private class BoundsIntPropertyBag.SizeProperty : Property<BoundsInt, Vector3Int> // TypeDefIndex: 17455
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F94A0 Offset: 0x24F86A0 VA: 0x1824F94A0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24F9460 Offset: 0x24F8660 VA: 0x1824F9460
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt> // TypeDefIndex: 17456
{
	// Methods

	// RVA: 0x24F6660 Offset: 0x24F5860 VA: 0x1824F6660
	public void .ctor() { }
}

// Namespace: 
private class SystemVersionPropertyBag.MajorProperty : Property<Version, int> // TypeDefIndex: 17457
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7E40 Offset: 0x24F7040 VA: 0x1824F7E40
	public void .ctor() { }

	// RVA: 0x24F7ED0 Offset: 0x24F70D0 VA: 0x1824F7ED0 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.MinorProperty : Property<Version, int> // TypeDefIndex: 17458
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F7F00 Offset: 0x24F7100 VA: 0x1824F7F00
	public void .ctor() { }

	// RVA: 0x24F7F90 Offset: 0x24F7190 VA: 0x1824F7F90 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.BuildProperty : Property<Version, int> // TypeDefIndex: 17459
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F68A0 Offset: 0x24F5AA0 VA: 0x1824F68A0
	public void .ctor() { }

	// RVA: 0x24F6930 Offset: 0x24F5B30 VA: 0x1824F6930 Slot: 7
	public override string get_Name() { }
}

// Namespace: 
private class SystemVersionPropertyBag.RevisionProperty : Property<Version, int> // TypeDefIndex: 17460
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x24F93A0 Offset: 0x24F85A0 VA: 0x1824F93A0
	public void .ctor() { }

	// RVA: 0x24F9430 Offset: 0x24F8630 VA: 0x1824F9430 Slot: 7
	public override string get_Name() { }
}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version> // TypeDefIndex: 17461
{
	// Methods

	// RVA: 0x24F94D0 Offset: 0x24F86D0 VA: 0x1824F94D0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister // TypeDefIndex: 17462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register();
}

// Namespace: 
internal struct PropertyBagStore.TypedStore<TContainer> // TypeDefIndex: 17463
{
	// Fields
	public static IPropertyBag<TContainer> PropertyBag; // 0x0
}

// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore // TypeDefIndex: 17464
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Type, IPropertyBag> NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Methods

	// RVA: 0x24F84F0 Offset: 0x24F76F0 VA: 0x1824F84F0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BF20 Offset: 0xA5B120 VA: 0x180A5BF20
	|-PropertyBagStore.AddPropertyBag<Bounds>
	|-PropertyBagStore.AddPropertyBag<BoundsInt>
	|-PropertyBagStore.AddPropertyBag<Color>
	|-PropertyBagStore.AddPropertyBag<object>
	|-PropertyBagStore.AddPropertyBag<Rect>
	|-PropertyBagStore.AddPropertyBag<RectInt>
	|-PropertyBagStore.AddPropertyBag<Vector2>
	|-PropertyBagStore.AddPropertyBag<Vector2Int>
	|-PropertyBagStore.AddPropertyBag<Vector3>
	|-PropertyBagStore.AddPropertyBag<Vector3Int>
	|-PropertyBagStore.AddPropertyBag<Vector4>
	|
	|-RVA: 0xA5C5A0 Offset: 0xA5B7A0 VA: 0x180A5C5A0
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5CB30 Offset: 0xA5BD30 VA: 0x180A5CB30
	|-PropertyBagStore.GetPropertyBag<Bounds>
	|-PropertyBagStore.GetPropertyBag<BoundsInt>
	|-PropertyBagStore.GetPropertyBag<Color>
	|-PropertyBagStore.GetPropertyBag<object>
	|-PropertyBagStore.GetPropertyBag<Rect>
	|-PropertyBagStore.GetPropertyBag<RectInt>
	|-PropertyBagStore.GetPropertyBag<Vector2>
	|-PropertyBagStore.GetPropertyBag<Vector2Int>
	|-PropertyBagStore.GetPropertyBag<Vector3>
	|-PropertyBagStore.GetPropertyBag<Vector3Int>
	|-PropertyBagStore.GetPropertyBag<Vector4>
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x24F8080 Offset: 0x24F7280 VA: 0x1824F8080
	internal static IPropertyBag GetPropertyBag(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute : Attribute // TypeDefIndex: 17465
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
[ReflectedPropertyBag]
internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer> // TypeDefIndex: 17466
{
	// Methods

	// RVA: -1 Offset: -1
	internal void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFFE0 Offset: 0x8EF1E0 VA: 0x1808EFFE0
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4270 Offset: 0xBE3470 VA: 0x180BE4270
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectedPropertyBagProvider.<>c // TypeDefIndex: 17467
{
	// Fields
	public static readonly ReflectedPropertyBagProvider.<>c <>9; // 0x0
	public static Func<MethodInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, int> <>9__22_0; // 0x10

	// Methods

	// RVA: 0x24FBB00 Offset: 0x24FAD00 VA: 0x1824FBB00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x24FBA10 Offset: 0x24FAC10 VA: 0x1824FBA10
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x24A89A0 Offset: 0x24A7BA0 VA: 0x1824A89A0
	internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectedPropertyBagProvider.<GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable // TypeDefIndex: 17468
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private IOrderedEnumerable<MemberInfo> <members>5__1; // 0x38
	private IEnumerator<MemberInfo> <>s__2; // 0x40
	private MemberInfo <member>5__3; // 0x48
	private bool <hasDontCreatePropertyAttribute>5__4; // 0x50
	private bool <hasCreatePropertyAttribute>5__5; // 0x51
	private bool <hasNonSerializedAttribute>5__6; // 0x52
	private bool <hasSerializedFieldAttribute>5__7; // 0x53
	private FieldInfo <field>5__8; // 0x58

	// Properties
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x24FB880 Offset: 0x24FAA80 VA: 0x1824FB880 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x24FAFE0 Offset: 0x24FA1E0 VA: 0x1824FAFE0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x24FB910 Offset: 0x24FAB10 VA: 0x1824FB910
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x24FB840 Offset: 0x24FAA40 VA: 0x1824FB840 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x24FB7A0 Offset: 0x24FA9A0 VA: 0x1824FB7A0 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x24FB7A0 Offset: 0x24FA9A0 VA: 0x1824FB7A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider // TypeDefIndex: 17469
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x24F8EC0 Offset: 0x24F80C0 VA: 0x1824F8EC0
	public void .ctor() { }

	// RVA: 0x24F8A70 Offset: 0x24F7C70 VA: 0x1824F8A70
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ED10 Offset: 0xA5DF10 VA: 0x180A5ED10
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA60770 Offset: 0xA5F970 VA: 0x180A60770
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5ECB0 Offset: 0xA5DEB0 VA: 0x180A5ECB0
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x24F8BC0 Offset: 0x24F7DC0 VA: 0x1824F8BC0
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x24F8C30 Offset: 0x24F7E30 VA: 0x1824F8C30
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x24F8DD0 Offset: 0x24F7FD0 VA: 0x1824F8DD0
	private static bool IsValidPropertyType(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities // TypeDefIndex: 17470
{
	// Methods

	// RVA: 0x24F9290 Offset: 0x24F8490 VA: 0x1824F9290
	public static string SanitizeMemberName(MemberInfo info) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17471
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <>f__AnonymousType0<<version>j__TPar, <capacity>j__TPar> // TypeDefIndex: 17472
{
	// Fields
	[DebuggerBrowsable(0)]
	private readonly <version>j__TPar <version>i__Field; // 0x0
	[DebuggerBrowsable(0)]
	private readonly <capacity>j__TPar <capacity>i__Field; // 0x0

	// Properties
	public <version>j__TPar version { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <version>j__TPar get_version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-<>f__AnonymousType0<int, int>.get_version
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_version
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(<version>j__TPar version, <capacity>j__TPar capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	|-<>f__AnonymousType0<int, int>..ctor
	|
	|-RVA: 0xB16CE0 Offset: 0xB15EE0 VA: 0x180B16CE0
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB14550 Offset: 0xB13750 VA: 0x180B14550
	|-<>f__AnonymousType0<int, int>.Equals
	|
	|-RVA: 0xB14640 Offset: 0xB13840 VA: 0x180B14640
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB14E80 Offset: 0xB14080 VA: 0x180B14E80
	|-<>f__AnonymousType0<int, int>.GetHashCode
	|
	|-RVA: 0xB151D0 Offset: 0xB143D0 VA: 0x180B151D0
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB15BB0 Offset: 0xB14DB0 VA: 0x180B15BB0
	|-<>f__AnonymousType0<int, int>.ToString
	|
	|-RVA: 0xB16280 Offset: 0xB15480 VA: 0x180B16280
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: 
[CompilerGenerated]
internal sealed class <>f__AnonymousType1<<Index>j__TPar, <Value>j__TPar> // TypeDefIndex: 17473
{
	// Fields
	[DebuggerBrowsable(0)]
	private readonly <Index>j__TPar <Index>i__Field; // 0x0
	[DebuggerBrowsable(0)]
	private readonly <Value>j__TPar <Value>i__Field; // 0x0

	// Properties
	public <Index>j__TPar Index { get; }
	public <Value>j__TPar Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <Index>j__TPar get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-<>f__AnonymousType1<int, char>.get_Index
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Index
	*/

	// RVA: -1 Offset: -1
	public <Value>j__TPar get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03E10 Offset: 0xB03010 VA: 0x180B03E10
	|-<>f__AnonymousType1<int, char>.get_Value
	|
	|-RVA: 0xB03E40 Offset: 0xB03040 VA: 0x180B03E40
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(<Index>j__TPar Index, <Value>j__TPar Value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB19130 Offset: 0xB18330 VA: 0x180B19130
	|-<>f__AnonymousType1<int, char>..ctor
	|
	|-RVA: 0xB16CE0 Offset: 0xB15EE0 VA: 0x180B16CE0
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB184F0 Offset: 0xB176F0 VA: 0x180B184F0
	|-<>f__AnonymousType1<int, char>.Equals
	|
	|-RVA: 0xB14640 Offset: 0xB13840 VA: 0x180B14640
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB185E0 Offset: 0xB177E0 VA: 0x180B185E0
	|-<>f__AnonymousType1<int, char>.GetHashCode
	|
	|-RVA: 0xB18690 Offset: 0xB17890 VA: 0x180B18690
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB18FC0 Offset: 0xB181C0 VA: 0x180B18FC0
	|-<>f__AnonymousType1<int, char>.ToString
	|
	|-RVA: 0xB18880 Offset: 0xB17A80 VA: 0x180B18880
	|-<>f__AnonymousType1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: QRCoder
public abstract class AbstractQRCode // TypeDefIndex: 17474
{
	// Fields
	[CompilerGenerated]
	private QRCodeData <QrCodeData>k__BackingField; // 0x10

	// Properties
	protected QRCodeData QrCodeData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected QRCodeData get_QrCodeData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void set_QrCodeData(QRCodeData value) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	protected void .ctor(QRCodeData data) { }

	// RVA: 0x18AF140 Offset: 0x18AE340 VA: 0x1818AF140 Slot: 4
	public void Dispose() { }
}

// Namespace: QRCoder
public class QRCodeData : IDisposable // TypeDefIndex: 17475
{
	// Fields
	[CompilerGenerated]
	private List<BitArray> <ModuleMatrix>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Version>k__BackingField; // 0x18

	// Properties
	public List<BitArray> ModuleMatrix { get; set; }
	private int Version { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<BitArray> get_ModuleMatrix() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ModuleMatrix(List<BitArray> value) { }

	// RVA: 0x18B36D0 Offset: 0x18B28D0 VA: 0x1818B36D0
	public void .ctor(int version) { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_Version(int value) { }

	// RVA: 0x18B36C0 Offset: 0x18B28C0 VA: 0x1818B36C0
	private static int ModulesPerSideFromVersion(int version) { }

	// RVA: 0x18B36B0 Offset: 0x18B28B0 VA: 0x1818B36B0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public enum QRCodeGenerator.EciMode // TypeDefIndex: 17476
{
	// Fields
	public int value__; // 0x0
	public const QRCodeGenerator.EciMode Default = 0;
	public const QRCodeGenerator.EciMode Iso8859_1 = 3;
	public const QRCodeGenerator.EciMode Iso8859_2 = 4;
	public const QRCodeGenerator.EciMode Utf8 = 26;
}

// Namespace: 
private static class QRCodeGenerator.ModulePlacer.MaskPattern // TypeDefIndex: 17477
{
	// Fields
	public static readonly Func<int, int, bool>[] Patterns; // 0x0

	// Methods

	// RVA: 0x18AF290 Offset: 0x18AE490 VA: 0x1818AF290
	public static bool Pattern1(int x, int y) { }

	// RVA: 0x18AF2A0 Offset: 0x18AE4A0 VA: 0x1818AF2A0
	public static bool Pattern2(int x, int y) { }

	// RVA: 0x18AF2B0 Offset: 0x18AE4B0 VA: 0x1818AF2B0
	public static bool Pattern3(int x, int y) { }

	// RVA: 0x18AF2D0 Offset: 0x18AE4D0 VA: 0x1818AF2D0
	public static bool Pattern4(int x, int y) { }

	// RVA: 0x18AF2F0 Offset: 0x18AE4F0 VA: 0x1818AF2F0
	public static bool Pattern5(int x, int y) { }

	// RVA: 0x18AF380 Offset: 0x18AE580 VA: 0x1818AF380
	public static bool Pattern6(int x, int y) { }

	// RVA: 0x18AF3C0 Offset: 0x18AE5C0 VA: 0x1818AF3C0
	public static bool Pattern7(int x, int y) { }

	// RVA: 0x18AF400 Offset: 0x18AE600 VA: 0x1818AF400
	public static bool Pattern8(int x, int y) { }

	// RVA: 0x18AF440 Offset: 0x18AE640 VA: 0x1818AF440
	public static int Score(ref QRCodeData qrCode) { }

	// RVA: 0x18B0850 Offset: 0x18AFA50 VA: 0x1818B0850
	private static void .cctor() { }
}

// Namespace: 
private static class QRCodeGenerator.ModulePlacer // TypeDefIndex: 17478
{
	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18AFCC0 VA: 0x1818B0AC0
	public static void AddQuietZone(ref QRCodeData qrCode) { }

	// RVA: 0x18B3170 Offset: 0x18B2370 VA: 0x1818B3170
	private static string ReverseString(string inp) { }

	// RVA: 0x18B2870 Offset: 0x18B1A70 VA: 0x1818B2870
	public static void PlaceVersion(ref QRCodeData qrCode, string versionStr) { }

	// RVA: 0x18B2120 Offset: 0x18B1320 VA: 0x1818B2120
	public static void PlaceFormat(ref QRCodeData qrCode, string formatStr) { }

	// RVA: 0x18B0FF0 Offset: 0x18B01F0 VA: 0x1818B0FF0
	public static int MaskCode(ref QRCodeData qrCode, int version, ref List<QRCodeGenerator.Rectangle> blockedModules, QRCodeGenerator.ECCLevel eccLevel) { }

	// RVA: 0x18B1AD0 Offset: 0x18B0CD0 VA: 0x1818B1AD0
	public static void PlaceDataWords(ref QRCodeData qrCode, string data, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B29F0 Offset: 0x18B1BF0 VA: 0x1818B29F0
	public static void ReserveSeperatorAreas(int size, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B2D20 Offset: 0x18B1F20 VA: 0x1818B2D20
	public static void ReserveVersionAreas(int size, int version, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B1980 Offset: 0x18B0B80 VA: 0x1818B1980
	public static void PlaceDarkModule(ref QRCodeData qrCode, int version, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B1EE0 Offset: 0x18B10E0 VA: 0x1818B1EE0
	public static void PlaceFinderPatterns(ref QRCodeData qrCode, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B1570 Offset: 0x18B0770 VA: 0x1818B1570
	public static void PlaceAlignmentPatterns(ref QRCodeData qrCode, List<QRCodeGenerator.Point> alignmentPatternLocations, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B2600 Offset: 0x18B1800 VA: 0x1818B2600
	public static void PlaceTimingPatterns(ref QRCodeData qrCode, ref List<QRCodeGenerator.Rectangle> blockedModules) { }

	// RVA: 0x18B0E30 Offset: 0x18B0030 VA: 0x1818B0E30
	private static bool Intersects(QRCodeGenerator.Rectangle r1, QRCodeGenerator.Rectangle r2) { }

	// RVA: 0x18B0E80 Offset: 0x18B0080 VA: 0x1818B0E80
	private static bool IsBlocked(QRCodeGenerator.Rectangle r1, List<QRCodeGenerator.Rectangle> blockedModules) { }
}

// Namespace: 
public enum QRCodeGenerator.ECCLevel // TypeDefIndex: 17479
{
	// Fields
	public int value__; // 0x0
	public const QRCodeGenerator.ECCLevel L = 0;
	public const QRCodeGenerator.ECCLevel M = 1;
	public const QRCodeGenerator.ECCLevel Q = 2;
	public const QRCodeGenerator.ECCLevel H = 3;
}

// Namespace: 
private enum QRCodeGenerator.EncodingMode // TypeDefIndex: 17480
{
	// Fields
	public int value__; // 0x0
	public const QRCodeGenerator.EncodingMode Numeric = 1;
	public const QRCodeGenerator.EncodingMode Alphanumeric = 2;
	public const QRCodeGenerator.EncodingMode Byte = 4;
	public const QRCodeGenerator.EncodingMode Kanji = 8;
	public const QRCodeGenerator.EncodingMode ECI = 7;
}

// Namespace: 
private struct QRCodeGenerator.AlignmentPattern // TypeDefIndex: 17481
{
	// Fields
	public int Version; // 0x0
	public List<QRCodeGenerator.Point> PatternPositions; // 0x8
}

// Namespace: 
private struct QRCodeGenerator.CodewordBlock // TypeDefIndex: 17482
{
	// Fields
	[CompilerGenerated]
	private readonly int <GroupNumber>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <BlockNumber>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly string <BitString>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly List<string> <CodeWords>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly List<int> <CodeWordsInt>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly List<string> <ECCWords>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly List<int> <ECCWordsInt>k__BackingField; // 0x28

	// Properties
	public List<string> CodeWords { get; }
	public List<string> ECCWords { get; }

	// Methods

	// RVA: 0x18AF160 Offset: 0x18AE360 VA: 0x1818AF160
	public void .ctor(int groupNumber, int blockNumber, string bitString, List<string> codeWords, List<string> eccWords, List<int> codeWordsInt, List<int> eccWordsInt) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<string> get_CodeWords() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<string> get_ECCWords() { }
}

// Namespace: 
private struct QRCodeGenerator.ECCInfo // TypeDefIndex: 17483
{
	// Fields
	[CompilerGenerated]
	private readonly int <Version>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly QRCodeGenerator.ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly int <TotalDataCodewords>k__BackingField; // 0x8
	[CompilerGenerated]
	private readonly int <ECCPerBlock>k__BackingField; // 0xC
	[CompilerGenerated]
	private readonly int <BlocksInGroup1>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <CodewordsInGroup1>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <BlocksInGroup2>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <CodewordsInGroup2>k__BackingField; // 0x1C

	// Properties
	public int Version { get; }
	public QRCodeGenerator.ECCLevel ErrorCorrectionLevel { get; }
	public int TotalDataCodewords { get; }
	public int ECCPerBlock { get; }
	public int BlocksInGroup1 { get; }
	public int CodewordsInGroup1 { get; }
	public int BlocksInGroup2 { get; }
	public int CodewordsInGroup2 { get; }

	// Methods

	// RVA: 0x18AF260 Offset: 0x18AE460 VA: 0x1818AF260
	public void .ctor(int version, QRCodeGenerator.ECCLevel errorCorrectionLevel, int totalDataCodewords, int eccPerBlock, int blocksInGroup1, int codewordsInGroup1, int blocksInGroup2, int codewordsInGroup2) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public QRCodeGenerator.ECCLevel get_ErrorCorrectionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_TotalDataCodewords() { }

	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_ECCPerBlock() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_BlocksInGroup1() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_CodewordsInGroup1() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_BlocksInGroup2() { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_CodewordsInGroup2() { }
}

// Namespace: 
private struct QRCodeGenerator.VersionInfo // TypeDefIndex: 17484
{
	// Fields
	[CompilerGenerated]
	private readonly int <Version>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly List<QRCodeGenerator.VersionInfoDetails> <Details>k__BackingField; // 0x8

	// Properties
	public int Version { get; }
	public List<QRCodeGenerator.VersionInfoDetails> Details { get; }

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(int version, List<QRCodeGenerator.VersionInfoDetails> versionInfoDetails) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public List<QRCodeGenerator.VersionInfoDetails> get_Details() { }
}

// Namespace: 
private struct QRCodeGenerator.VersionInfoDetails // TypeDefIndex: 17485
{
	// Fields
	[CompilerGenerated]
	private readonly QRCodeGenerator.ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<QRCodeGenerator.EncodingMode, int> <CapacityDict>k__BackingField; // 0x8

	// Properties
	public QRCodeGenerator.ECCLevel ErrorCorrectionLevel { get; }
	public Dictionary<QRCodeGenerator.EncodingMode, int> CapacityDict { get; }

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(QRCodeGenerator.ECCLevel errorCorrectionLevel, Dictionary<QRCodeGenerator.EncodingMode, int> capacityDict) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public QRCodeGenerator.ECCLevel get_ErrorCorrectionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Dictionary<QRCodeGenerator.EncodingMode, int> get_CapacityDict() { }
}

// Namespace: 
private struct QRCodeGenerator.Antilog // TypeDefIndex: 17486
{
	// Fields
	[CompilerGenerated]
	private readonly int <ExponentAlpha>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <IntegerValue>k__BackingField; // 0x4

	// Properties
	public int ExponentAlpha { get; }
	public int IntegerValue { get; }

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int exponentAlpha, int integerValue) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_ExponentAlpha() { }

	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_IntegerValue() { }
}

// Namespace: 
private struct QRCodeGenerator.PolynomItem // TypeDefIndex: 17487
{
	// Fields
	[CompilerGenerated]
	private readonly int <Coefficient>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <Exponent>k__BackingField; // 0x4

	// Properties
	public int Coefficient { get; }
	public int Exponent { get; }

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int coefficient, int exponent) { }

	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Coefficient() { }

	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Exponent() { }
}

// Namespace: 
private class QRCodeGenerator.Polynom // TypeDefIndex: 17488
{
	// Fields
	[CompilerGenerated]
	private List<QRCodeGenerator.PolynomItem> <PolyItems>k__BackingField; // 0x10

	// Properties
	public List<QRCodeGenerator.PolynomItem> PolyItems { get; set; }

	// Methods

	// RVA: 0x18B3640 Offset: 0x18B2840 VA: 0x1818B3640
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<QRCodeGenerator.PolynomItem> get_PolyItems() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PolyItems(List<QRCodeGenerator.PolynomItem> value) { }

	// RVA: 0x18B3250 Offset: 0x18B2450 VA: 0x1818B3250 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private class QRCodeGenerator.Point // TypeDefIndex: 17489
{
	// Fields
	[CompilerGenerated]
	private readonly int <X>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Y>k__BackingField; // 0x14

	// Properties
	public int X { get; }
	public int Y { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_X() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Y() { }

	// RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	public void .ctor(int x, int y) { }
}

// Namespace: 
private class QRCodeGenerator.Rectangle // TypeDefIndex: 17490
{
	// Fields
	[CompilerGenerated]
	private int <X>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Y>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <Width>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <Height>k__BackingField; // 0x1C

	// Properties
	public int X { get; set; }
	public int Y { get; set; }
	public int Width { get; }
	public int Height { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_X() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_X(int value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Y() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Y(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Width() { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_Height() { }

	// RVA: 0x18BA040 Offset: 0x18B9240 VA: 0x1818BA040
	public void .ctor(int x, int y, int w, int h) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass17_0 // TypeDefIndex: 17491
{
	// Fields
	public int version; // 0x10
	public QRCodeGenerator.ECCLevel eccLevel; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BA510 Offset: 0x18B9710 VA: 0x1818BA510
	internal bool <GenerateQrCode>b__0(QRCodeGenerator.ECCInfo x) { }

	// RVA: 0x18BA5A0 Offset: 0x18B97A0 VA: 0x1818BA5A0
	internal bool <GenerateQrCode>b__1(QRCodeGenerator.AlignmentPattern x) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QRCodeGenerator.<>c // TypeDefIndex: 17492
{
	// Fields
	public static readonly QRCodeGenerator.<>c <>9; // 0x0
	public static Func<QRCodeGenerator.AlignmentPattern, List<QRCodeGenerator.Point>> <>9__17_2; // 0x8
	public static Func<QRCodeGenerator.PolynomItem, string> <>9__21_0; // 0x10
	public static Func<<>f__AnonymousType0<int, int>, int> <>9__24_2; // 0x18
	public static Func<char, int, <>f__AnonymousType1<int, char>> <>9__28_0; // 0x20
	public static Func<<>f__AnonymousType1<int, char>, int> <>9__28_1; // 0x28
	public static Func<<>f__AnonymousType1<int, char>, string> <>9__28_3; // 0x30
	public static Func<IGrouping<int, <>f__AnonymousType1<int, char>>, string> <>9__28_2; // 0x38
	public static Func<string, int> <>9__29_0; // 0x40
	public static Func<QRCodeGenerator.PolynomItem, int> <>9__45_0; // 0x48
	public static Func<IGrouping<int, QRCodeGenerator.PolynomItem>, bool> <>9__45_1; // 0x50
	public static Func<IGrouping<int, QRCodeGenerator.PolynomItem>, int> <>9__45_2; // 0x58
	public static Func<int, QRCodeGenerator.PolynomItem, int> <>9__45_6; // 0x60
	public static Func<QRCodeGenerator.PolynomItem, int> <>9__45_4; // 0x68
	public static Func<QRCodeGenerator.Antilog, int> <>9__46_1; // 0x70
	public static Func<QRCodeGenerator.Antilog, int> <>9__47_1; // 0x78

	// Methods

	// RVA: 0x18BAA60 Offset: 0x18B9C60 VA: 0x1818BAA60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0xB08300 Offset: 0xB07500 VA: 0x180B08300
	internal List<QRCodeGenerator.Point> <GenerateQrCode>b__17_2(QRCodeGenerator.AlignmentPattern x) { }

	// RVA: 0x18BA390 Offset: 0x18B9590 VA: 0x1818BA390
	internal string <CalculateECCWords>b__21_0(QRCodeGenerator.PolynomItem x) { }

	// RVA: 0x18BA3F0 Offset: 0x18B95F0 VA: 0x1818BA3F0
	internal int <GetVersion>b__24_2(<>f__AnonymousType0<int, int> x) { }

	// RVA: 0x18BA110 Offset: 0x18B9310 VA: 0x1818BA110
	internal <>f__AnonymousType1<int, char> <BinaryStringToBitBlockList>b__28_0(char x, int i) { }

	// RVA: 0x18BA190 Offset: 0x18B9390 VA: 0x1818BA190
	internal int <BinaryStringToBitBlockList>b__28_1(<>f__AnonymousType1<int, char> x) { }

	// RVA: 0x18BA1E0 Offset: 0x18B93E0 VA: 0x1818BA1E0
	internal string <BinaryStringToBitBlockList>b__28_2(IGrouping<int, <>f__AnonymousType1<int, char>> x) { }

	// RVA: 0x18BA320 Offset: 0x18B9520 VA: 0x1818BA320
	internal string <BinaryStringToBitBlockList>b__28_3(<>f__AnonymousType1<int, char> v) { }

	// RVA: 0x18BA090 Offset: 0x18B9290 VA: 0x1818BA090
	internal int <BinaryStringListToDecList>b__29_0(string binaryString) { }

	// RVA: 0x18BA3E0 Offset: 0x18B95E0 VA: 0x1818BA3E0
	internal int <MultiplyAlphaPolynoms>b__45_0(QRCodeGenerator.PolynomItem x) { }

	// RVA: 0x18BA430 Offset: 0x18B9630 VA: 0x1818BA430
	internal bool <MultiplyAlphaPolynoms>b__45_1(IGrouping<int, QRCodeGenerator.PolynomItem> x) { }

	// RVA: 0x18BA470 Offset: 0x18B9670 VA: 0x1818BA470
	internal int <MultiplyAlphaPolynoms>b__45_2(IGrouping<int, QRCodeGenerator.PolynomItem> x) { }

	// RVA: 0x18BA4B0 Offset: 0x18B96B0 VA: 0x1818BA4B0
	internal int <MultiplyAlphaPolynoms>b__45_6(int current, QRCodeGenerator.PolynomItem polynomOld) { }

	// RVA: 0x18BA3E0 Offset: 0x18B95E0 VA: 0x1818BA3E0
	internal int <MultiplyAlphaPolynoms>b__45_4(QRCodeGenerator.PolynomItem x) { }

	// RVA: 0x18BA3E0 Offset: 0x18B95E0 VA: 0x1818BA3E0
	internal int <GetIntValFromAlphaExp>b__46_1(QRCodeGenerator.Antilog alog) { }

	// RVA: 0x1529D90 Offset: 0x1528F90 VA: 0x181529D90
	internal int <GetAlphaExpFromIntVal>b__47_1(QRCodeGenerator.Antilog alog) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass24_0 // TypeDefIndex: 17493
{
	// Fields
	public QRCodeGenerator.ECCLevel eccLevel; // 0x10
	public QRCodeGenerator.EncodingMode encMode; // 0x14
	public int length; // 0x18
	public Func<QRCodeGenerator.VersionInfoDetails, bool> <>9__5; // 0x20
	public Func<QRCodeGenerator.VersionInfoDetails, bool> <>9__6; // 0x28
	public Func<QRCodeGenerator.VersionInfoDetails, bool> <>9__7; // 0x30
	public Func<QRCodeGenerator.VersionInfoDetails, bool> <>9__8; // 0x38

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BA5B0 Offset: 0x18B97B0 VA: 0x1818BA5B0
	internal bool <GetVersion>b__0(QRCodeGenerator.VersionInfo x) { }

	// RVA: 0x18BA8F0 Offset: 0x18B9AF0 VA: 0x1818BA8F0
	internal bool <GetVersion>b__5(QRCodeGenerator.VersionInfoDetails y) { }

	// RVA: 0x18BA660 Offset: 0x18B9860 VA: 0x1818BA660
	internal <>f__AnonymousType0<int, int> <GetVersion>b__1(QRCodeGenerator.VersionInfo x) { }

	// RVA: 0x18BA5A0 Offset: 0x18B97A0 VA: 0x1818BA5A0
	internal bool <GetVersion>b__6(QRCodeGenerator.VersionInfoDetails y) { }

	// RVA: 0x18BA780 Offset: 0x18B9980 VA: 0x1818BA780
	internal bool <GetVersion>b__3(QRCodeGenerator.VersionInfo x) { }

	// RVA: 0x18BA5A0 Offset: 0x18B97A0 VA: 0x1818BA5A0
	internal bool <GetVersion>b__7(QRCodeGenerator.VersionInfoDetails y) { }

	// RVA: 0x18BA820 Offset: 0x18B9A20 VA: 0x1818BA820
	internal int <GetVersion>b__4(QRCodeGenerator.VersionInfo x) { }

	// RVA: 0x18BA5A0 Offset: 0x18B97A0 VA: 0x1818BA5A0
	internal bool <GetVersion>b__8(QRCodeGenerator.VersionInfoDetails y) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass45_0 // TypeDefIndex: 17494
{
	// Fields
	public IList<int> toGlue; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BA990 Offset: 0x18B9B90 VA: 0x1818BA990
	internal bool <MultiplyAlphaPolynoms>b__3(QRCodeGenerator.PolynomItem x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass45_1 // TypeDefIndex: 17495
{
	// Fields
	public int exponent; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BAA50 Offset: 0x18B9C50 VA: 0x1818BAA50
	internal bool <MultiplyAlphaPolynoms>b__5(QRCodeGenerator.PolynomItem x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass46_0 // TypeDefIndex: 17496
{
	// Fields
	public int exp; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x651FA0 Offset: 0x6511A0 VA: 0x180651FA0
	internal bool <GetIntValFromAlphaExp>b__0(QRCodeGenerator.Antilog alog) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QRCodeGenerator.<>c__DisplayClass47_0 // TypeDefIndex: 17497
{
	// Fields
	public int intVal; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18BAA50 Offset: 0x18B9C50 VA: 0x1818BAA50
	internal bool <GetAlphaExpFromIntVal>b__0(QRCodeGenerator.Antilog alog) { }
}

// Namespace: QRCoder
public class QRCodeGenerator : IDisposable // TypeDefIndex: 17498
{
	// Fields
	private static readonly char[] numTable; // 0x0
	private static readonly char[] alphanumEncTable; // 0x8
	private static readonly int[] capacityBaseValues; // 0x10
	private static readonly int[] capacityECCBaseValues; // 0x18
	private static readonly int[] alignmentPatternBaseValues; // 0x20
	private static readonly int[] remainderBits; // 0x28
	private static readonly List<QRCodeGenerator.AlignmentPattern> alignmentPatternTable; // 0x30
	private static readonly List<QRCodeGenerator.ECCInfo> capacityECCTable; // 0x38
	private static readonly List<QRCodeGenerator.VersionInfo> capacityTable; // 0x40
	private static readonly List<QRCodeGenerator.Antilog> galoisField; // 0x48
	private static readonly Dictionary<char, int> alphanumEncDict; // 0x50

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x18B5C60 Offset: 0x18B4E60 VA: 0x1818B5C60
	public QRCodeData CreateQrCode(string plainText, QRCodeGenerator.ECCLevel eccLevel, bool forceUtf8 = False, bool utf8BOM = False, QRCodeGenerator.EciMode eciMode = 0, int requestedVersion = -1) { }

	// RVA: 0x18B5DF0 Offset: 0x18B4FF0 VA: 0x1818B5DF0
	public static QRCodeData GenerateQrCode(string plainText, QRCodeGenerator.ECCLevel eccLevel, bool forceUtf8 = False, bool utf8BOM = False, QRCodeGenerator.EciMode eciMode = 0, int requestedVersion = -1) { }

	// RVA: 0x18B6210 Offset: 0x18B5410 VA: 0x1818B6210
	private static QRCodeData GenerateQrCode(string bitString, QRCodeGenerator.ECCLevel eccLevel, int version) { }

	// RVA: 0x18B7700 Offset: 0x18B6900 VA: 0x1818B7700
	private static string GetFormatString(QRCodeGenerator.ECCLevel level, int maskVersion) { }

	// RVA: 0x18B7CD0 Offset: 0x18B6ED0 VA: 0x1818B7CD0
	private static string GetVersionString(int version) { }

	// RVA: 0x18B3C60 Offset: 0x18B2E60 VA: 0x1818B3C60
	private static List<string> CalculateECCWords(string bitString, QRCodeGenerator.ECCInfo eccInfo) { }

	// RVA: 0x18B44E0 Offset: 0x18B36E0 VA: 0x1818B44E0
	private static QRCodeGenerator.Polynom ConvertToAlphaNotation(QRCodeGenerator.Polynom poly) { }

	// RVA: 0x18B4690 Offset: 0x18B3890 VA: 0x1818B4690
	private static QRCodeGenerator.Polynom ConvertToDecNotation(QRCodeGenerator.Polynom poly) { }

	// RVA: 0x18B7F60 Offset: 0x18B7160 VA: 0x1818B7F60
	private static int GetVersion(int length, QRCodeGenerator.EncodingMode encMode, QRCodeGenerator.ECCLevel eccLevel) { }

	// RVA: 0x18B75D0 Offset: 0x18B67D0 VA: 0x1818B75D0
	private static QRCodeGenerator.EncodingMode GetEncodingFromPlaintext(string plainText, bool forceUtf8) { }

	// RVA: 0x18B42F0 Offset: 0x18B34F0 VA: 0x1818B42F0
	private static QRCodeGenerator.Polynom CalculateMessagePolynom(string bitString) { }

	// RVA: 0x18B4090 Offset: 0x18B3290 VA: 0x1818B4090
	private static QRCodeGenerator.Polynom CalculateGeneratorPolynom(int numEccWords) { }

	// RVA: 0x18B3970 Offset: 0x18B2B70 VA: 0x1818B3970
	private static List<string> BinaryStringToBitBlockList(string bitString) { }

	// RVA: 0x18B3860 Offset: 0x18B2A60 VA: 0x1818B3860
	private static List<int> BinaryStringListToDecList(List<string> binaryStringList) { }

	// RVA: 0x18B3810 Offset: 0x18B2A10 VA: 0x1818B3810
	private static int BinToDec(string binStr) { }

	// RVA: 0x18B5DA0 Offset: 0x18B4FA0 VA: 0x1818B5DA0
	private static string DecToBin(int decNum) { }

	// RVA: 0x18B5CF0 Offset: 0x18B4EF0 VA: 0x1818B5CF0
	private static string DecToBin(int decNum, int padLeftUpTo) { }

	// RVA: 0x18B7270 Offset: 0x18B6470 VA: 0x1818B7270
	private static int GetCountIndicatorLength(int version, QRCodeGenerator.EncodingMode encMode) { }

	// RVA: 0x18B7500 Offset: 0x18B6700 VA: 0x1818B7500
	private static int GetDataLength(QRCodeGenerator.EncodingMode encoding, string plainText, string codedText, bool forceUtf8) { }

	// RVA: 0x18B8350 Offset: 0x18B7550 VA: 0x1818B8350
	private static bool IsUtf8(QRCodeGenerator.EncodingMode encoding, string plainText) { }

	// RVA: 0x18B83C0 Offset: 0x18B75C0 VA: 0x1818B83C0
	private static bool IsValidISO(string input) { }

	// RVA: 0x18B9870 Offset: 0x18B8A70 VA: 0x1818B9870
	private static string PlainTextToBinary(string plainText, QRCodeGenerator.EncodingMode encMode, QRCodeGenerator.EciMode eciMode, bool utf8BOM, bool forceUtf8) { }

	// RVA: 0x18B96B0 Offset: 0x18B88B0 VA: 0x1818B96B0
	private static string PlainTextToBinaryNumeric(string plainText) { }

	// RVA: 0x18B91D0 Offset: 0x18B83D0 VA: 0x1818B91D0
	private static string PlainTextToBinaryAlphanumeric(string plainText) { }

	// RVA: 0x18B4860 Offset: 0x18B3A60 VA: 0x1818B4860
	private static string ConvertToIso8859(string value, string Iso = "ISO-8859-2") { }

	// RVA: 0x18B93E0 Offset: 0x18B85E0 VA: 0x1818B93E0
	private static string PlainTextToBinaryByte(string plainText, QRCodeGenerator.EciMode eciMode, bool utf8BOM, bool forceUtf8) { }

	// RVA: 0x18B9A10 Offset: 0x18B8C10 VA: 0x1818B9A10
	private static QRCodeGenerator.Polynom XORPolynoms(QRCodeGenerator.Polynom messagePolynom, QRCodeGenerator.Polynom resPolynom) { }

	// RVA: 0x18B8F50 Offset: 0x18B8150 VA: 0x1818B8F50
	private static QRCodeGenerator.Polynom MultiplyGeneratorPolynomByLeadterm(QRCodeGenerator.Polynom genPolynom, QRCodeGenerator.PolynomItem leadTerm, int lowerExponentBy) { }

	// RVA: 0x18B8480 Offset: 0x18B7680 VA: 0x1818B8480
	private static QRCodeGenerator.Polynom MultiplyAlphaPolynoms(QRCodeGenerator.Polynom polynomBase, QRCodeGenerator.Polynom polynomMultiplier) { }

	// RVA: 0x18B7AF0 Offset: 0x18B6CF0 VA: 0x1818B7AF0
	private static int GetIntValFromAlphaExp(int exp) { }

	// RVA: 0x18B7090 Offset: 0x18B6290 VA: 0x1818B7090
	private static int GetAlphaExpFromIntVal(int intVal) { }

	// RVA: 0x18B99A0 Offset: 0x18B8BA0 VA: 0x1818B99A0
	private static int ShrinkAlphaExp(int alphaExp) { }

	// RVA: 0x18B4C70 Offset: 0x18B3E70 VA: 0x1818B4C70
	private static Dictionary<char, int> CreateAlphanumEncDict() { }

	// RVA: 0x18B48F0 Offset: 0x18B3AF0 VA: 0x1818B48F0
	private static List<QRCodeGenerator.AlignmentPattern> CreateAlignmentPatternTable() { }

	// RVA: 0x18B4EA0 Offset: 0x18B40A0 VA: 0x1818B4EA0
	private static List<QRCodeGenerator.ECCInfo> CreateCapacityECCTable() { }

	// RVA: 0x18B53C0 Offset: 0x18B45C0 VA: 0x1818B53C0
	private static List<QRCodeGenerator.VersionInfo> CreateCapacityTable() { }

	// RVA: 0x18B4D90 Offset: 0x18B3F90 VA: 0x1818B4D90
	private static List<QRCodeGenerator.Antilog> CreateAntilogTable() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void Dispose() { }

	// RVA: 0x18B9C00 Offset: 0x18B8E00 VA: 0x1818B9C00
	private static void .cctor() { }
}

// Namespace: QRCoder.Unity
public class UnityQRCode : AbstractQRCode // TypeDefIndex: 17499
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(QRCodeData data) { }

	// RVA: 0x18BADF0 Offset: 0x18B9FF0 VA: 0x1818BADF0
	public Texture2D GetGraphic(int pixelsPerModule) { }

	// RVA: 0x18BABF0 Offset: 0x18B9DF0 VA: 0x1818BABF0
	public Texture2D GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor) { }

	// RVA: 0x18BAAC0 Offset: 0x18B9CC0 VA: 0x1818BAAC0
	internal Color[] GetBrush(int sizeX, int sizeY, Color defaultColor) { }
}

// Namespace: QRCoder.Exceptions
public class DataTooLongException : Exception // TypeDefIndex: 17500
{
	// Methods

	// RVA: 0x18AF190 Offset: 0x18AE390 VA: 0x1818AF190
	public void .ctor(string eccLevel, string encodingMode, int maxSizeByte) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 17501
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=90 // TypeDefIndex: 17502
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 // TypeDefIndex: 17503
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 // TypeDefIndex: 17504
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1120 // TypeDefIndex: 17505
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2560 // TypeDefIndex: 17506
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3840 // TypeDefIndex: 17507
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 17508
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=90 1BAE60DC28D365B5EF5493498787078BF53D20EF /*Metadata offset 0x8FD3D8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 47E3B8265F3A9BD162A6677F3CD46F65C75C6AAF /*Metadata offset 0x8FD438*/; // 0x5A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3840 62B792D603A9032470F66068EBDD4C2C27BC3584 /*Metadata offset 0x8FD530*/; // 0x14A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1120 9AE2A86B62BFF132AFB9751C7A86FEA25C488207 /*Metadata offset 0x8FE438*/; // 0x104A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CAD8623838274740D6497489F547CE972C42A942 /*Metadata offset 0x8FE8A0*/; // 0x14AA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 E84CF750337BB70114A76A64A62D163B2A79CE3C /*Metadata offset 0x8FE8B8*/; // 0x14BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2560 EF2F325AA96D022E1C3C16A071416F33B884A0E6 /*Metadata offset 0x8FE960*/; // 0x155E
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17509
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 17510
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x24EDA20 Offset: 0x24ECC20 VA: 0x1824EDA20 Slot: 3
	public override string ToString() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24ECD20 Offset: 0x24EBF20 VA: 0x1824ECD20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x24ED800 Offset: 0x24ECA00 VA: 0x1824ED800
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x24ED940 Offset: 0x24ECB40 VA: 0x1824ED940
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24ED640 Offset: 0x24EC840 VA: 0x1824ED640
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x24ED6C0 Offset: 0x24EC8C0 VA: 0x1824ED6C0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethod("RaycastArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24ED460 Offset: 0x24EC660 VA: 0x1824ED460
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24ED760 Offset: 0x24EC960 VA: 0x1824ED760
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x24ED550 Offset: 0x24EC750 VA: 0x1824ED550
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x24ECE80 Offset: 0x24EC080 VA: 0x1824ECE80
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethod("GetRayIntersectionArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24ECE10 Offset: 0x24EC010 VA: 0x1824ECE10
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x24ED380 Offset: 0x24EC580 VA: 0x1824ED380
	public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapPointArray_Binding")]
	// RVA: 0x24ED320 Offset: 0x24EC520 VA: 0x1824ED320
	private static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24ED0D0 Offset: 0x24EC2D0 VA: 0x1824ED0D0
	public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results) { }

	[NativeMethod("OverlapCircleArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24ECF80 Offset: 0x24EC180 VA: 0x1824ECF80
	private static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24ED160 Offset: 0x24EC360 VA: 0x1824ED160
	public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results) { }

	[NativeMethod("OverlapCircleList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24ED060 Offset: 0x24EC260 VA: 0x1824ED060
	private static int OverlapCircleList_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x24E9AF0 Offset: 0x24E8CF0 VA: 0x1824E9AF0
	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapColliderArray_Binding")]
	// RVA: 0x24ED250 Offset: 0x24EC450 VA: 0x1824ED250
	private static int OverlapColliderArray_Internal(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24ED5D0 Offset: 0x24EC7D0 VA: 0x1824ED5D0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x24ED3F0 Offset: 0x24EC5F0 VA: 0x1824ED3F0
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24ED4E0 Offset: 0x24EC6E0 VA: 0x1824ED4E0
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x24ECDA0 Offset: 0x24EBFA0 VA: 0x1824ECDA0
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x24ED2B0 Offset: 0x24EC4B0 VA: 0x1824ED2B0
	private static int OverlapPointArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24ECF10 Offset: 0x24EC110 VA: 0x1824ECF10
	private static int OverlapCircleArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24ECFF0 Offset: 0x24EC1F0 VA: 0x1824ECFF0
	private static int OverlapCircleList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x24ED1F0 Offset: 0x24EC3F0 VA: 0x1824ED1F0
	private static int OverlapColliderArray_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Collider2D[] results) { }
}

// Namespace: UnityEngine
[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
[StaticAccessor("GetPhysicsManager2D()", 1)]
public class Physics2D // TypeDefIndex: 17511
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x24ECA90 Offset: 0x24EBC90 VA: 0x1824ECA90
	public static bool get_queriesHitTriggers() { }

	// RVA: 0x24EAAB0 Offset: 0x24E9CB0 VA: 0x1824EAAB0
	public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody) { }

	[NativeMethod("ClosestPoint")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24EAA30 Offset: 0x24E9C30 VA: 0x1824EAA30
	private static Vector2 ClosestPoint_Rigidbody(Vector2 position, Rigidbody2D rigidbody) { }

	[ExcludeFromDocs]
	// RVA: 0x24EC8C0 Offset: 0x24EBAC0 VA: 0x1824EC8C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x24EC540 Offset: 0x24EB740 VA: 0x1824EC540
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x24EC2B0 Offset: 0x24EB4B0 VA: 0x1824EC2B0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24EC720 Offset: 0x24EB920 VA: 0x1824EC720
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x24EC010 Offset: 0x24EB210 VA: 0x1824EC010
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x24EC1B0 Offset: 0x24EB3B0 VA: 0x1824EC1B0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24EC440 Offset: 0x24EB640 VA: 0x1824EC440
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x24EC620 Offset: 0x24EB820 VA: 0x1824EC620
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x24EBED0 Offset: 0x24EB0D0 VA: 0x1824EBED0
	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24EA860 Offset: 0x24E9A60 VA: 0x1824EA860
	public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction) { }

	[NativeMethod("CircleCastAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24EA7B0 Offset: 0x24E99B0 VA: 0x1824EA7B0
	private static RaycastHit2D[] CircleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x24EB220 Offset: 0x24EA420 VA: 0x1824EB220
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x24EB130 Offset: 0x24EA330 VA: 0x1824EB130
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x24EB040 Offset: 0x24EA240 VA: 0x1824EB040
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24EAFA0 Offset: 0x24EA1A0 VA: 0x1824EAFA0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24EB4E0 Offset: 0x24EA6E0 VA: 0x1824EB4E0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x24EB300 Offset: 0x24EA500 VA: 0x1824EB300
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x24EB3F0 Offset: 0x24EA5F0 VA: 0x1824EB3F0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x24EBDC0 Offset: 0x24EAFC0 VA: 0x1824EBDC0
	public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask) { }

	// RVA: 0x24EBCE0 Offset: 0x24EAEE0 VA: 0x1824EBCE0
	public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x24EBA80 Offset: 0x24EAC80 VA: 0x1824EBA80
	public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapCircleAll_Binding")]
	// RVA: 0x24EB9F0 Offset: 0x24EABF0 VA: 0x1824EB9F0
	private static Collider2D[] OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x24EBBC0 Offset: 0x24EADC0 VA: 0x1824EBBC0
	public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask) { }

	// RVA: 0x24EAE60 Offset: 0x24EA060 VA: 0x1824EAE60
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x24EAD90 Offset: 0x24E9F90 VA: 0x1824EAD90
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRigidbodyContactsArray_Binding")]
	// RVA: 0x24EB620 Offset: 0x24EA820 VA: 0x1824EB620
	private static int GetRigidbodyContactsArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	[NativeMethod("GetRigidbodyContactsCollidersOnlyArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24EB710 Offset: 0x24EA910 VA: 0x1824EB710
	private static int GetRigidbodyContactsCollidersOnlyArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24EABF0 Offset: 0x24E9DF0 VA: 0x1824EABF0
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x24EACC0 Offset: 0x24E9EC0 VA: 0x1824EACC0
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRigidbodyContactsList_Binding")]
	// RVA: 0x24EB8F0 Offset: 0x24EAAF0 VA: 0x1824EB8F0
	private static int GetRigidbodyContactsList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	[NativeMethod("GetRigidbodyContactsCollidersOnlyList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x24EB800 Offset: 0x24EAA00 VA: 0x1824EB800
	private static int GetRigidbodyContactsCollidersOnlyList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x24ECA20 Offset: 0x24EBC20 VA: 0x1824ECA20
	private static void .cctor() { }

	// RVA: 0x24EA9D0 Offset: 0x24E9BD0 VA: 0x1824EA9D0
	private static void ClosestPoint_Rigidbody_Injected(ref Vector2 position, Rigidbody2D rigidbody, out Vector2 ret) { }

	// RVA: 0x24EA740 Offset: 0x24E9940 VA: 0x1824EA740
	private static RaycastHit2D[] CircleCastAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter) { }

	// RVA: 0x24EAF30 Offset: 0x24EA130 VA: 0x1824EAF30
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

	// RVA: 0x24EB980 Offset: 0x24EAB80 VA: 0x1824EB980
	private static Collider2D[] OverlapCircleAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 point, float radius, ref ContactFilter2D contactFilter) { }

	// RVA: 0x24EB5C0 Offset: 0x24EA7C0 VA: 0x1824EB5C0
	private static int GetRigidbodyContactsArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	// RVA: 0x24EB6B0 Offset: 0x24EA8B0 VA: 0x1824EB6B0
	private static int GetRigidbodyContactsCollidersOnlyArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24EB890 Offset: 0x24EAA90 VA: 0x1824EB890
	private static int GetRigidbodyContactsList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	// RVA: 0x24EB7A0 Offset: 0x24EA9A0 VA: 0x1824EB7A0
	private static int GetRigidbodyContactsCollidersOnlyList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<Collider2D> results) { }
}

// Namespace: UnityEngine
public enum CapsuleDirection2D // TypeDefIndex: 17512
{
	// Fields
	public int value__; // 0x0
	public const CapsuleDirection2D Vertical = 0;
	public const CapsuleDirection2D Horizontal = 1;
}

// Namespace: UnityEngine
[Flags]
public enum RigidbodyConstraints2D // TypeDefIndex: 17513
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyConstraints2D None = 0;
	public const RigidbodyConstraints2D FreezePositionX = 1;
	public const RigidbodyConstraints2D FreezePositionY = 2;
	public const RigidbodyConstraints2D FreezeRotation = 4;
	public const RigidbodyConstraints2D FreezePosition = 3;
	public const RigidbodyConstraints2D FreezeAll = 7;
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation2D // TypeDefIndex: 17514
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyInterpolation2D None = 0;
	public const RigidbodyInterpolation2D Interpolate = 1;
	public const RigidbodyInterpolation2D Extrapolate = 2;
}

// Namespace: UnityEngine
public enum RigidbodySleepMode2D // TypeDefIndex: 17515
{
	// Fields
	public int value__; // 0x0
	public const RigidbodySleepMode2D NeverSleep = 0;
	public const RigidbodySleepMode2D StartAwake = 1;
	public const RigidbodySleepMode2D StartAsleep = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode2D // TypeDefIndex: 17516
{
	// Fields
	public int value__; // 0x0
	[EditorBrowsable(1)]
	[Obsolete("Enum member CollisionDetectionMode2D.None has been deprecated. Use CollisionDetectionMode2D.Discrete instead (UnityUpgradable) -> Discrete", True)]
	public const CollisionDetectionMode2D None = 0;
	public const CollisionDetectionMode2D Discrete = 0;
	public const CollisionDetectionMode2D Continuous = 1;
}

// Namespace: UnityEngine
public enum RigidbodyType2D // TypeDefIndex: 17517
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyType2D Dynamic = 0;
	public const RigidbodyType2D Kinematic = 1;
	public const RigidbodyType2D Static = 2;
}

// Namespace: UnityEngine
public enum ForceMode2D // TypeDefIndex: 17518
{
	// Fields
	public int value__; // 0x0
	public const ForceMode2D Force = 0;
	public const ForceMode2D Impulse = 1;
}

// Namespace: UnityEngine
public enum EffectorSelection2D // TypeDefIndex: 17519
{
	// Fields
	public int value__; // 0x0
	public const EffectorSelection2D Rigidbody = 0;
	public const EffectorSelection2D Collider = 1;
}

// Namespace: UnityEngine
public enum PhysicsShapeType2D // TypeDefIndex: 17520
{
	// Fields
	public int value__; // 0x0
	public const PhysicsShapeType2D Circle = 0;
	public const PhysicsShapeType2D Capsule = 1;
	public const PhysicsShapeType2D Polygon = 2;
	public const PhysicsShapeType2D Edges = 3;
}

// Namespace: UnityEngine
[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
[UsedByNativeCode]
public struct PhysicsShape2D // TypeDefIndex: 17521
{
	// Fields
	private PhysicsShapeType2D m_ShapeType; // 0x0
	private float m_Radius; // 0x4
	private int m_VertexStartIndex; // 0x8
	private int m_VertexCount; // 0xC
	private int m_UseAdjacentStart; // 0x10
	private int m_UseAdjacentEnd; // 0x14
	private Vector2 m_AdjacentStart; // 0x18
	private Vector2 m_AdjacentEnd; // 0x20
}

// Namespace: 
[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
internal struct PhysicsShapeGroup2D.GroupState // TypeDefIndex: 17522
{
	// Fields
	[NativeName("shapesList")]
	public List<PhysicsShape2D> m_Shapes; // 0x0
	[NativeName("verticesList")]
	public List<Vector2> m_Vertices; // 0x8
	[NativeName("localToWorld")]
	public Matrix4x4 m_LocalToWorld; // 0x10
}

// Namespace: UnityEngine
public class PhysicsShapeGroup2D // TypeDefIndex: 17523
{
	// Fields
	internal PhysicsShapeGroup2D.GroupState m_GroupState; // 0x10
}

// Namespace: UnityEngine
public struct ColliderDistance2D // TypeDefIndex: 17524
{
	// Fields
	private Vector2 m_PointA; // 0x0
	private Vector2 m_PointB; // 0x8
	private Vector2 m_Normal; // 0x10
	private float m_Distance; // 0x18
	private int m_IsValid; // 0x1C
}

// Namespace: UnityEngine
[NativeClass("ContactFilter", "struct ContactFilter;")]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 17525
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18
	public const float NormalAngleUpperLimit = 359,9999;

	// Methods

	// RVA: 0x24EA060 Offset: 0x24E9260 VA: 0x1824EA060
	public ContactFilter2D NoFilter() { }

	// RVA: 0x24E9F10 Offset: 0x24E9110 VA: 0x1824E9F10
	private void CheckConsistency() { }

	// RVA: 0x24EA130 Offset: 0x24E9330 VA: 0x1824EA130
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x24EA0E0 Offset: 0x24E92E0 VA: 0x1824EA0E0
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x24E9F50 Offset: 0x24E9150 VA: 0x1824E9F50
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x24E9F10 Offset: 0x24E9110 VA: 0x1824E9F10
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class Collision2D // TypeDefIndex: 17526
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties
	public ContactPoint2D[] contacts { get; }
	public int contactCount { get; }

	// Methods

	// RVA: 0x24E9EB0 Offset: 0x24E90B0 VA: 0x1824E9EB0
	public ContactPoint2D[] get_contacts() { }

	// RVA: 0x24E9EA0 Offset: 0x24E90A0 VA: 0x1824E9EA0
	public int get_contactCount() { }
}

// Namespace: UnityEngine
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
public struct ContactPoint2D // TypeDefIndex: 17527
{
	// Fields
	[NativeName("point")]
	private Vector2 m_Point; // 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeName("separation")]
	private float m_Separation; // 0x18
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; // 0x1C
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; // 0x20
	[NativeName("collider")]
	private int m_Collider; // 0x24
	[NativeName("otherCollider")]
	private int m_OtherCollider; // 0x28
	[NativeName("rigidbody")]
	private int m_Rigidbody; // 0x2C
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; // 0x30
	[NativeName("enabled")]
	private int m_Enabled; // 0x34

	// Properties
	public Vector2 normal { get; }

	// Methods

	// RVA: 0x246ED10 Offset: 0x246DF10 VA: 0x18246ED10
	public Vector2 get_normal() { }
}

// Namespace: UnityEngine
[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct RaycastHit2D // TypeDefIndex: 17528
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public float fraction { get; }
	public Collider2D collider { get; }
	public Rigidbody2D rigidbody { get; }
	public Transform transform { get; }

	// Methods

	// RVA: 0x246ED10 Offset: 0x246DF10 VA: 0x18246ED10
	public Vector2 get_point() { }

	// RVA: 0x24EE720 Offset: 0x24ED920 VA: 0x1824EE720
	public Vector2 get_normal() { }

	// RVA: 0x24EE710 Offset: 0x24ED910 VA: 0x1824EE710
	public float get_distance() { }

	// RVA: 0x24E28C0 Offset: 0x24E1AC0 VA: 0x1824E28C0
	public float get_fraction() { }

	// RVA: 0x24EE670 Offset: 0x24ED870 VA: 0x1824EE670
	public Collider2D get_collider() { }

	// RVA: 0x24EE740 Offset: 0x24ED940 VA: 0x1824EE740
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x24EE7F0 Offset: 0x24ED9F0 VA: 0x1824EE7F0
	public Transform get_transform() { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
public sealed class Rigidbody2D : Component // TypeDefIndex: 17529
{
	// Properties
	public Vector2 position { get; set; }
	public float rotation { get; set; }
	public Vector2 velocity { get; set; }
	public float angularVelocity { get; set; }
	public bool useAutoMass { get; set; }
	public float mass { get; set; }
	[NativeMethod("Material")]
	public PhysicsMaterial2D sharedMaterial { get; set; }
	public Vector2 centerOfMass { get; set; }
	public Vector2 worldCenterOfMass { get; }
	public float inertia { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float gravityScale { get; set; }
	public RigidbodyType2D bodyType { get; set; }
	public bool useFullKinematicContacts { get; set; }
	public bool isKinematic { get; set; }
	[NativeMethod("FreezeRotation")]
	[Obsolete("'fixedAngle' is no longer supported. Use constraints instead.", False)]
	public bool fixedAngle { get; set; }
	public bool freezeRotation { get; set; }
	public RigidbodyConstraints2D constraints { get; set; }
	public bool simulated { get; set; }
	public RigidbodyInterpolation2D interpolation { get; set; }
	public RigidbodySleepMode2D sleepMode { get; set; }
	public CollisionDetectionMode2D collisionDetectionMode { get; set; }
	public int attachedColliderCount { get; }
	public Vector2 totalForce { get; set; }
	public float totalTorque { get; set; }
	public LayerMask excludeLayers { get; set; }
	public LayerMask includeLayers { get; set; }

	// Methods

	// RVA: 0x24F1100 Offset: 0x24F0300 VA: 0x1824F1100
	public Vector2 get_position() { }

	// RVA: 0x24F1AC0 Offset: 0x24F0CC0 VA: 0x1824F1AC0
	public void set_position(Vector2 value) { }

	// RVA: 0x24F1150 Offset: 0x24F0350 VA: 0x1824F1150
	public float get_rotation() { }

	// RVA: 0x24F1B00 Offset: 0x24F0D00 VA: 0x1824F1B00
	public void set_rotation(float value) { }

	// RVA: 0x24F09A0 Offset: 0x24EFBA0 VA: 0x1824F09A0
	public void SetRotation(float angle) { }

	[NativeMethod("SetRotation")]
	// RVA: 0x24F09A0 Offset: 0x24EFBA0 VA: 0x1824F09A0
	private void SetRotation_Angle(float angle) { }

	// RVA: 0x24F0A90 Offset: 0x24EFC90 VA: 0x1824F0A90
	public void SetRotation(Quaternion rotation) { }

	[NativeMethod("SetRotation")]
	// RVA: 0x24F0A40 Offset: 0x24EFC40 VA: 0x1824F0A40
	private void SetRotation_Quaternion(Quaternion rotation) { }

	// RVA: 0x24F04F0 Offset: 0x24EF6F0 VA: 0x1824F04F0
	public void MovePosition(Vector2 position) { }

	// RVA: 0x24F0530 Offset: 0x24EF730 VA: 0x1824F0530
	public void MoveRotation(float angle) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x24F0530 Offset: 0x24EF730 VA: 0x1824F0530
	private void MoveRotation_Angle(float angle) { }

	// RVA: 0x24F0620 Offset: 0x24EF820 VA: 0x1824F0620
	public void MoveRotation(Quaternion rotation) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x24F05D0 Offset: 0x24EF7D0 VA: 0x1824F05D0
	private void MoveRotation_Quaternion(Quaternion rotation) { }

	// RVA: 0x24F1400 Offset: 0x24F0600 VA: 0x1824F1400
	public Vector2 get_velocity() { }

	// RVA: 0x24F1E00 Offset: 0x24F1000 VA: 0x1824F1E00
	public void set_velocity(Vector2 value) { }

	// RVA: 0x24F0B90 Offset: 0x24EFD90 VA: 0x1824F0B90
	public float get_angularVelocity() { }

	// RVA: 0x24F1540 Offset: 0x24F0740 VA: 0x1824F1540
	public void set_angularVelocity(float value) { }

	// RVA: 0x24F1330 Offset: 0x24F0530 VA: 0x1824F1330
	public bool get_useAutoMass() { }

	// RVA: 0x24F1D10 Offset: 0x24F0F10 VA: 0x1824F1D10
	public void set_useAutoMass(bool value) { }

	// RVA: 0x24F1070 Offset: 0x24F0270 VA: 0x1824F1070
	public float get_mass() { }

	// RVA: 0x24F1A20 Offset: 0x24F0C20 VA: 0x1824F1A20
	public void set_mass(float value) { }

	// RVA: 0x24F1190 Offset: 0x24F0390 VA: 0x1824F1190
	public PhysicsMaterial2D get_sharedMaterial() { }

	// RVA: 0x24F1B50 Offset: 0x24F0D50 VA: 0x1824F1B50
	public void set_sharedMaterial(PhysicsMaterial2D value) { }

	// RVA: 0x24F0CA0 Offset: 0x24EFEA0 VA: 0x1824F0CA0
	public Vector2 get_centerOfMass() { }

	// RVA: 0x24F1620 Offset: 0x24F0820 VA: 0x1824F1620
	public void set_centerOfMass(Vector2 value) { }

	// RVA: 0x24F14A0 Offset: 0x24F06A0 VA: 0x1824F14A0
	public Vector2 get_worldCenterOfMass() { }

	// RVA: 0x24F0FB0 Offset: 0x24F01B0 VA: 0x1824F0FB0
	public float get_inertia() { }

	// RVA: 0x24F1940 Offset: 0x24F0B40 VA: 0x1824F1940
	public void set_inertia(float value) { }

	// RVA: 0x24F0D70 Offset: 0x24EFF70 VA: 0x1824F0D70
	public float get_drag() { }

	// RVA: 0x24F16E0 Offset: 0x24F08E0 VA: 0x1824F16E0
	public void set_drag(float value) { }

	// RVA: 0x24F0B50 Offset: 0x24EFD50 VA: 0x1824F0B50
	public float get_angularDrag() { }

	// RVA: 0x24F14F0 Offset: 0x24F06F0 VA: 0x1824F14F0
	public void set_angularDrag(float value) { }

	// RVA: 0x24F0ED0 Offset: 0x24F00D0 VA: 0x1824F0ED0
	public float get_gravityScale() { }

	// RVA: 0x24F1860 Offset: 0x24F0A60 VA: 0x1824F1860
	public void set_gravityScale(float value) { }

	// RVA: 0x24F0C10 Offset: 0x24EFE10 VA: 0x1824F0C10
	public RigidbodyType2D get_bodyType() { }

	[NativeMethod("SetBodyType_Binding")]
	// RVA: 0x24F1590 Offset: 0x24F0790 VA: 0x1824F1590
	public void set_bodyType(RigidbodyType2D value) { }

	// RVA: 0x24F0950 Offset: 0x24EFB50 VA: 0x1824F0950
	internal void SetDragBehaviour(bool dragged) { }

	// RVA: 0x24F1370 Offset: 0x24F0570 VA: 0x1824F1370
	public bool get_useFullKinematicContacts() { }

	// RVA: 0x24F1D60 Offset: 0x24F0F60 VA: 0x1824F1D60
	public void set_useFullKinematicContacts(bool value) { }

	// RVA: 0x24F1030 Offset: 0x24F0230 VA: 0x1824F1030
	public bool get_isKinematic() { }

	// RVA: 0x24F19D0 Offset: 0x24F0BD0 VA: 0x1824F19D0
	public void set_isKinematic(bool value) { }

	// RVA: 0x24F0E50 Offset: 0x24F0050 VA: 0x1824F0E50
	public bool get_fixedAngle() { }

	// RVA: 0x24F17C0 Offset: 0x24F09C0 VA: 0x1824F17C0
	public void set_fixedAngle(bool value) { }

	// RVA: 0x24F0E90 Offset: 0x24F0090 VA: 0x1824F0E90
	public bool get_freezeRotation() { }

	// RVA: 0x24F1810 Offset: 0x24F0A10 VA: 0x1824F1810
	public void set_freezeRotation(bool value) { }

	// RVA: 0x24F0D30 Offset: 0x24EFF30 VA: 0x1824F0D30
	public RigidbodyConstraints2D get_constraints() { }

	// RVA: 0x24F16A0 Offset: 0x24F08A0 VA: 0x1824F16A0
	public void set_constraints(RigidbodyConstraints2D value) { }

	// RVA: 0x24F0160 Offset: 0x24EF360 VA: 0x1824F0160
	public bool IsSleeping() { }

	// RVA: 0x24F0120 Offset: 0x24EF320 VA: 0x1824F0120
	public bool IsAwake() { }

	// RVA: 0x24F0AD0 Offset: 0x24EFCD0 VA: 0x1824F0AD0
	public void Sleep() { }

	[NativeMethod("Wake")]
	// RVA: 0x24F0B10 Offset: 0x24EFD10 VA: 0x1824F0B10
	public void WakeUp() { }

	// RVA: 0x24F11D0 Offset: 0x24F03D0 VA: 0x1824F11D0
	public bool get_simulated() { }

	[NativeMethod("SetSimulated_Binding")]
	// RVA: 0x24F1BA0 Offset: 0x24F0DA0 VA: 0x1824F1BA0
	public void set_simulated(bool value) { }

	// RVA: 0x24F0FF0 Offset: 0x24F01F0 VA: 0x1824F0FF0
	public RigidbodyInterpolation2D get_interpolation() { }

	// RVA: 0x24F1990 Offset: 0x24F0B90 VA: 0x1824F1990
	public void set_interpolation(RigidbodyInterpolation2D value) { }

	// RVA: 0x24F1210 Offset: 0x24F0410 VA: 0x1824F1210
	public RigidbodySleepMode2D get_sleepMode() { }

	// RVA: 0x24F1BF0 Offset: 0x24F0DF0 VA: 0x1824F1BF0
	public void set_sleepMode(RigidbodySleepMode2D value) { }

	// RVA: 0x24F0CF0 Offset: 0x24EFEF0 VA: 0x1824F0CF0
	public CollisionDetectionMode2D get_collisionDetectionMode() { }

	// RVA: 0x24F1660 Offset: 0x24F0860 VA: 0x1824F1660
	public void set_collisionDetectionMode(CollisionDetectionMode2D value) { }

	// RVA: 0x24F0BD0 Offset: 0x24EFDD0 VA: 0x1824F0BD0
	public int get_attachedColliderCount() { }

	// RVA: 0x24F12A0 Offset: 0x24F04A0 VA: 0x1824F12A0
	public Vector2 get_totalForce() { }

	// RVA: 0x24F1C80 Offset: 0x24F0E80 VA: 0x1824F1C80
	public void set_totalForce(Vector2 value) { }

	// RVA: 0x24F12F0 Offset: 0x24F04F0 VA: 0x1824F12F0
	public float get_totalTorque() { }

	// RVA: 0x24F1CC0 Offset: 0x24F0EC0 VA: 0x1824F1CC0
	public void set_totalTorque(float value) { }

	// RVA: 0x24F0E00 Offset: 0x24F0000 VA: 0x1824F0E00
	public LayerMask get_excludeLayers() { }

	// RVA: 0x24F1780 Offset: 0x24F0980 VA: 0x1824F1780
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x24F0F60 Offset: 0x24F0160 VA: 0x1824F0F60
	public LayerMask get_includeLayers() { }

	// RVA: 0x24F1900 Offset: 0x24F0B00 VA: 0x1824F1900
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x24F0450 Offset: 0x24EF650 VA: 0x1824F0450
	public bool IsTouching(Collider2D collider) { }

	// RVA: 0x24F03E0 Offset: 0x24EF5E0 VA: 0x1824F03E0
	public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x24F0320 Offset: 0x24EF520 VA: 0x1824F0320
	private bool IsTouching_OtherColliderWithFilter_Internal(Collider2D collider, ContactFilter2D contactFilter) { }

	// RVA: 0x24F0380 Offset: 0x24EF580 VA: 0x1824F0380
	public bool IsTouching(ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x24F0270 Offset: 0x24EF470 VA: 0x1824F0270
	private bool IsTouching_AnyColliderWithFilter_Internal(ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x24F01E0 Offset: 0x24EF3E0 VA: 0x1824F01E0
	public bool IsTouchingLayers() { }

	// RVA: 0x24F01A0 Offset: 0x24EF3A0 VA: 0x1824F01A0
	public bool IsTouchingLayers(int layerMask) { }

	// RVA: 0x24F0910 Offset: 0x24EFB10 VA: 0x1824F0910
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x24EF4B0 Offset: 0x24EE6B0 VA: 0x1824EF4B0
	public ColliderDistance2D Distance(Collider2D collider) { }

	[NativeMethod("Distance")]
	// RVA: 0x24EF450 Offset: 0x24EE650 VA: 0x1824EF450
	private ColliderDistance2D Distance_Internal(Collider2D collider) { }

	// RVA: 0x24EF280 Offset: 0x24EE480 VA: 0x1824EF280
	public Vector2 ClosestPoint(Vector2 position) { }

	[ExcludeFromDocs]
	// RVA: 0x24EEA50 Offset: 0x24EDC50 VA: 0x1824EEA50
	public void AddForce(Vector2 force) { }

	// RVA: 0x24EEA90 Offset: 0x24EDC90 VA: 0x1824EEA90
	public void AddForce(Vector2 force, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x24EEB40 Offset: 0x24EDD40 VA: 0x1824EEB40
	public void AddRelativeForce(Vector2 relativeForce) { }

	// RVA: 0x24EEB80 Offset: 0x24EDD80 VA: 0x1824EEB80
	public void AddRelativeForce(Vector2 relativeForce, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x24EE940 Offset: 0x24EDB40 VA: 0x1824EE940
	public void AddForceAtPosition(Vector2 force, Vector2 position) { }

	// RVA: 0x24EE990 Offset: 0x24EDB90 VA: 0x1824EE990
	public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x24EEC30 Offset: 0x24EDE30 VA: 0x1824EEC30
	public void AddTorque(float torque) { }

	// RVA: 0x24EEBD0 Offset: 0x24EDDD0 VA: 0x1824EEBD0
	public void AddTorque(float torque, ForceMode2D mode) { }

	// RVA: 0x24EFD70 Offset: 0x24EEF70 VA: 0x1824EFD70
	public Vector2 GetPoint(Vector2 point) { }

	// RVA: 0x24EFED0 Offset: 0x24EF0D0 VA: 0x1824EFED0
	public Vector2 GetRelativePoint(Vector2 relativePoint) { }

	// RVA: 0x24F00D0 Offset: 0x24EF2D0 VA: 0x1824F00D0
	public Vector2 GetVector(Vector2 vector) { }

	// RVA: 0x24EFF80 Offset: 0x24EF180 VA: 0x1824EFF80
	public Vector2 GetRelativeVector(Vector2 relativeVector) { }

	// RVA: 0x24EFCC0 Offset: 0x24EEEC0 VA: 0x1824EFCC0
	public Vector2 GetPointVelocity(Vector2 point) { }

	// RVA: 0x24EFE20 Offset: 0x24EF020 VA: 0x1824EFE20
	public Vector2 GetRelativePointVelocity(Vector2 relativePoint) { }

	// RVA: 0x24F0850 Offset: 0x24EFA50 VA: 0x1824F0850
	public int OverlapCollider(ContactFilter2D contactFilter, [Out] Collider2D[] results) { }

	[NativeMethod("OverlapColliderArray_Binding")]
	// RVA: 0x24F06C0 Offset: 0x24EF8C0 VA: 0x1824F06C0
	private int OverlapColliderArray_Internal(ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24F07E0 Offset: 0x24EF9E0 VA: 0x1824F07E0
	public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results) { }

	[NativeMethod("OverlapColliderList_Binding")]
	// RVA: 0x24F0780 Offset: 0x24EF980 VA: 0x1824F0780
	private int OverlapColliderList_Internal(ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x24EF870 Offset: 0x24EEA70 VA: 0x1824EF870
	public int GetContacts(ContactPoint2D[] contacts) { }

	// RVA: 0x24EFAE0 Offset: 0x24EECE0 VA: 0x1824EFAE0
	public int GetContacts(List<ContactPoint2D> contacts) { }

	// RVA: 0x24EFA50 Offset: 0x24EEC50 VA: 0x1824EFA50
	public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x24EF720 Offset: 0x24EE920 VA: 0x1824EF720
	public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x24EFBA0 Offset: 0x24EEDA0 VA: 0x1824EFBA0
	public int GetContacts(Collider2D[] colliders) { }

	// RVA: 0x24EF7B0 Offset: 0x24EE9B0 VA: 0x1824EF7B0
	public int GetContacts(List<Collider2D> colliders) { }

	// RVA: 0x24EF930 Offset: 0x24EEB30 VA: 0x1824EF930
	public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders) { }

	// RVA: 0x24EF9C0 Offset: 0x24EEBC0 VA: 0x1824EF9C0
	public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	// RVA: 0x24EF680 Offset: 0x24EE880 VA: 0x1824EF680
	public int GetAttachedColliders([Out] Collider2D[] results) { }

	[NativeMethod("GetAttachedCollidersArray_Binding")]
	// RVA: 0x24EF680 Offset: 0x24EE880 VA: 0x1824EF680
	private int GetAttachedCollidersArray_Internal(Collider2D[] results) { }

	// RVA: 0x24EF6D0 Offset: 0x24EE8D0 VA: 0x1824EF6D0
	public int GetAttachedColliders(List<Collider2D> results) { }

	[NativeMethod("GetAttachedCollidersList_Binding")]
	// RVA: 0x24EF6D0 Offset: 0x24EE8D0 VA: 0x1824EF6D0
	private int GetAttachedCollidersList_Internal(List<Collider2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x24EF220 Offset: 0x24EE420 VA: 0x1824EF220
	public int Cast(Vector2 direction, RaycastHit2D[] results) { }

	// RVA: 0x24EEFE0 Offset: 0x24EE1E0 VA: 0x1824EEFE0
	public int Cast(Vector2 direction, RaycastHit2D[] results, float distance) { }

	[NativeMethod("CastArray_Binding")]
	// RVA: 0x24EECF0 Offset: 0x24EDEF0 VA: 0x1824EECF0
	private int CastArray_Internal(Vector2 direction, float distance, RaycastHit2D[] results) { }

	// RVA: 0x24EF140 Offset: 0x24EE340 VA: 0x1824EF140
	public int Cast(Vector2 direction, List<RaycastHit2D> results, float distance = ∞) { }

	[NativeMethod("CastList_Binding")]
	// RVA: 0x24EEF80 Offset: 0x24EE180 VA: 0x1824EEF80
	private int CastList_Internal(Vector2 direction, float distance, List<RaycastHit2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x24EF0C0 Offset: 0x24EE2C0 VA: 0x1824EF0C0
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24EF040 Offset: 0x24EE240 VA: 0x1824EF040
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[NativeMethod("CastFilteredArray_Binding")]
	// RVA: 0x24EEDC0 Offset: 0x24EDFC0 VA: 0x1824EEDC0
	private int CastFilteredArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24EF1A0 Offset: 0x24EE3A0 VA: 0x1824EF1A0
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance) { }

	[NativeMethod("CastFilteredList_Binding")]
	// RVA: 0x24EEEA0 Offset: 0x24EE0A0 VA: 0x1824EEEA0
	private int CastFilteredList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x24F0020 Offset: 0x24EF220 VA: 0x1824F0020
	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup) { }

	[NativeMethod("GetShapes_Binding")]
	// RVA: 0x24EFFD0 Offset: 0x24EF1D0 VA: 0x1824EFFD0
	private int GetShapes_Internal(ref PhysicsShapeGroup2D.GroupState physicsShapeGroupState) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24F10B0 Offset: 0x24F02B0 VA: 0x1824F10B0
	private void get_position_Injected(out Vector2 ret) { }

	// RVA: 0x24F1A70 Offset: 0x24F0C70 VA: 0x1824F1A70
	private void set_position_Injected(ref Vector2 value) { }

	// RVA: 0x24F09F0 Offset: 0x24EFBF0 VA: 0x1824F09F0
	private void SetRotation_Quaternion_Injected(ref Quaternion rotation) { }

	// RVA: 0x24F04A0 Offset: 0x24EF6A0 VA: 0x1824F04A0
	private void MovePosition_Injected(ref Vector2 position) { }

	// RVA: 0x24F0580 Offset: 0x24EF780 VA: 0x1824F0580
	private void MoveRotation_Quaternion_Injected(ref Quaternion rotation) { }

	// RVA: 0x24F13B0 Offset: 0x24F05B0 VA: 0x1824F13B0
	private void get_velocity_Injected(out Vector2 ret) { }

	// RVA: 0x24F1DB0 Offset: 0x24F0FB0 VA: 0x1824F1DB0
	private void set_velocity_Injected(ref Vector2 value) { }

	// RVA: 0x24F0C50 Offset: 0x24EFE50 VA: 0x1824F0C50
	private void get_centerOfMass_Injected(out Vector2 ret) { }

	// RVA: 0x24F15D0 Offset: 0x24F07D0 VA: 0x1824F15D0
	private void set_centerOfMass_Injected(ref Vector2 value) { }

	// RVA: 0x24F1450 Offset: 0x24F0650 VA: 0x1824F1450
	private void get_worldCenterOfMass_Injected(out Vector2 ret) { }

	// RVA: 0x24F1250 Offset: 0x24F0450 VA: 0x1824F1250
	private void get_totalForce_Injected(out Vector2 ret) { }

	// RVA: 0x24F1C30 Offset: 0x24F0E30 VA: 0x1824F1C30
	private void set_totalForce_Injected(ref Vector2 value) { }

	// RVA: 0x24F0DB0 Offset: 0x24EFFB0 VA: 0x1824F0DB0
	private void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x24F1730 Offset: 0x24F0930 VA: 0x1824F1730
	private void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x24F0F10 Offset: 0x24F0110 VA: 0x1824F0F10
	private void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x24F18B0 Offset: 0x24F0AB0 VA: 0x1824F18B0
	private void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x24F02C0 Offset: 0x24EF4C0 VA: 0x1824F02C0
	private bool IsTouching_OtherColliderWithFilter_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter) { }

	// RVA: 0x24F0220 Offset: 0x24EF420 VA: 0x1824F0220
	private bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref ContactFilter2D contactFilter) { }

	// RVA: 0x24F08C0 Offset: 0x24EFAC0 VA: 0x1824F08C0
	private bool OverlapPoint_Injected(ref Vector2 point) { }

	// RVA: 0x24EF3F0 Offset: 0x24EE5F0 VA: 0x1824EF3F0
	private void Distance_Internal_Injected(Collider2D collider, out ColliderDistance2D ret) { }

	// RVA: 0x24EE9F0 Offset: 0x24EDBF0 VA: 0x1824EE9F0
	private void AddForce_Injected(ref Vector2 force, ForceMode2D mode) { }

	// RVA: 0x24EEAE0 Offset: 0x24EDCE0 VA: 0x1824EEAE0
	private void AddRelativeForce_Injected(ref Vector2 relativeForce, ForceMode2D mode) { }

	// RVA: 0x24EE8D0 Offset: 0x24EDAD0 VA: 0x1824EE8D0
	private void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, ForceMode2D mode) { }

	// RVA: 0x24EFD10 Offset: 0x24EEF10 VA: 0x1824EFD10
	private void GetPoint_Injected(ref Vector2 point, out Vector2 ret) { }

	// RVA: 0x24EFE70 Offset: 0x24EF070 VA: 0x1824EFE70
	private void GetRelativePoint_Injected(ref Vector2 relativePoint, out Vector2 ret) { }

	// RVA: 0x24F0070 Offset: 0x24EF270 VA: 0x1824F0070
	private void GetVector_Injected(ref Vector2 vector, out Vector2 ret) { }

	// RVA: 0x24EFF20 Offset: 0x24EF120 VA: 0x1824EFF20
	private void GetRelativeVector_Injected(ref Vector2 relativeVector, out Vector2 ret) { }

	// RVA: 0x24EFC60 Offset: 0x24EEE60 VA: 0x1824EFC60
	private void GetPointVelocity_Injected(ref Vector2 point, out Vector2 ret) { }

	// RVA: 0x24EFDC0 Offset: 0x24EEFC0 VA: 0x1824EFDC0
	private void GetRelativePointVelocity_Injected(ref Vector2 relativePoint, out Vector2 ret) { }

	// RVA: 0x24F0660 Offset: 0x24EF860 VA: 0x1824F0660
	private int OverlapColliderArray_Internal_Injected(ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x24F0720 Offset: 0x24EF920 VA: 0x1824F0720
	private int OverlapColliderList_Internal_Injected(ref ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x24EEC80 Offset: 0x24EDE80 VA: 0x1824EEC80
	private int CastArray_Internal_Injected(ref Vector2 direction, float distance, RaycastHit2D[] results) { }

	// RVA: 0x24EEF10 Offset: 0x24EE110 VA: 0x1824EEF10
	private int CastList_Internal_Injected(ref Vector2 direction, float distance, List<RaycastHit2D> results) { }

	// RVA: 0x24EED50 Offset: 0x24EDF50 VA: 0x1824EED50
	private int CastFilteredArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24EEE30 Offset: 0x24EE030 VA: 0x1824EEE30
	private int CastFilteredList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True)]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
public class Collider2D : Behaviour // TypeDefIndex: 17530
{
	// Properties
	public bool isTrigger { get; set; }
	public Vector2 offset { get; set; }
	public Rigidbody2D attachedRigidbody { get; }
	public Bounds bounds { get; }

	// Methods

	// RVA: 0x24E9CE0 Offset: 0x24E8EE0 VA: 0x1824E9CE0
	public bool get_isTrigger() { }

	// RVA: 0x24E9DC0 Offset: 0x24E8FC0 VA: 0x1824E9DC0
	public void set_isTrigger(bool value) { }

	// RVA: 0x24E9D70 Offset: 0x24E8F70 VA: 0x1824E9D70
	public Vector2 get_offset() { }

	// RVA: 0x24E9E60 Offset: 0x24E9060 VA: 0x1824E9E60
	public void set_offset(Vector2 value) { }

	[NativeMethod("GetAttachedRigidbody_Binding")]
	// RVA: 0x24E9BF0 Offset: 0x24E8DF0 VA: 0x1824E9BF0
	public Rigidbody2D get_attachedRigidbody() { }

	// RVA: 0x24E9C80 Offset: 0x24E8E80 VA: 0x1824E9C80
	public Bounds get_bounds() { }

	// RVA: 0x24E9AA0 Offset: 0x24E8CA0 VA: 0x1824E9AA0
	public bool IsTouching(Collider2D collider) { }

	// RVA: 0x24E9BB0 Offset: 0x24E8DB0 VA: 0x1824E9BB0
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x24E9AF0 Offset: 0x24E8CF0 VA: 0x1824E9AF0
	public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x24E9A20 Offset: 0x24E8C20 VA: 0x1824E9A20
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[NativeMethod("CastArray_Binding")]
	// RVA: 0x24E99A0 Offset: 0x24E8BA0 VA: 0x1824E99A0
	private int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, RaycastHit2D[] results) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24E9D20 Offset: 0x24E8F20 VA: 0x1824E9D20
	private void get_offset_Injected(out Vector2 ret) { }

	// RVA: 0x24E9E10 Offset: 0x24E9010 VA: 0x1824E9E10
	private void set_offset_Injected(ref Vector2 value) { }

	// RVA: 0x24E9C30 Offset: 0x24E8E30 VA: 0x1824E9C30
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x24E9B60 Offset: 0x24E8D60 VA: 0x1824E9B60
	private bool OverlapPoint_Injected(ref Vector2 point) { }

	// RVA: 0x24E9930 Offset: 0x24E8B30 VA: 0x1824E9930
	private int CastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, RaycastHit2D[] results) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
public sealed class CircleCollider2D : Collider2D // TypeDefIndex: 17531
{
	// Properties
	public float radius { get; set; }
	[Obsolete("CircleCollider2D.center has been deprecated. Use CircleCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	[EditorBrowsable(1)]
	public Vector2 center { get; set; }

	// Methods

	// RVA: 0x24E98A0 Offset: 0x24E8AA0 VA: 0x1824E98A0
	public float get_radius() { }

	// RVA: 0x24E98E0 Offset: 0x24E8AE0 VA: 0x1824E98E0
	public void set_radius(float value) { }

	// RVA: 0x54D140 Offset: 0x54C340 VA: 0x18054D140
	public Vector2 get_center() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_center(Vector2 value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/CapsuleCollider2D.h")]
public sealed class CapsuleCollider2D : Collider2D // TypeDefIndex: 17532
{
	// Properties
	public Vector2 size { get; set; }
	public CapsuleDirection2D direction { get; set; }

	// Methods

	// RVA: 0x24E9780 Offset: 0x24E8980 VA: 0x1824E9780
	public Vector2 get_size() { }

	// RVA: 0x24E9860 Offset: 0x24E8A60 VA: 0x1824E9860
	public void set_size(Vector2 value) { }

	// RVA: 0x24E96F0 Offset: 0x24E88F0 VA: 0x1824E96F0
	public CapsuleDirection2D get_direction() { }

	// RVA: 0x24E97D0 Offset: 0x24E89D0 VA: 0x1824E97D0
	public void set_direction(CapsuleDirection2D value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24E9730 Offset: 0x24E8930 VA: 0x1824E9730
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x24E9810 Offset: 0x24E8A10 VA: 0x1824E9810
	private void set_size_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
public sealed class EdgeCollider2D : Collider2D // TypeDefIndex: 17533
{
	// Properties
	public float edgeRadius { get; set; }
	public int edgeCount { get; }
	public int pointCount { get; }
	public Vector2[] points { get; set; }
	public bool useAdjacentStartPoint { get; set; }
	public bool useAdjacentEndPoint { get; set; }
	public Vector2 adjacentStartPoint { get; set; }
	public Vector2 adjacentEndPoint { get; set; }

	// Methods

	// RVA: 0x24EA190 Offset: 0x24E9390 VA: 0x1824EA190
	public void Reset() { }

	// RVA: 0x24EA3A0 Offset: 0x24E95A0 VA: 0x1824EA3A0
	public float get_edgeRadius() { }

	// RVA: 0x24EA600 Offset: 0x24E9800 VA: 0x1824EA600
	public void set_edgeRadius(float value) { }

	// RVA: 0x24EA360 Offset: 0x24E9560 VA: 0x1824EA360
	public int get_edgeCount() { }

	// RVA: 0x24EA3E0 Offset: 0x24E95E0 VA: 0x1824EA3E0
	public int get_pointCount() { }

	// RVA: 0x24EA420 Offset: 0x24E9620 VA: 0x1824EA420
	public Vector2[] get_points() { }

	// RVA: 0x24EA650 Offset: 0x24E9850 VA: 0x1824EA650
	public void set_points(Vector2[] value) { }

	[NativeMethod("GetPoints_Binding")]
	// RVA: 0x24EA140 Offset: 0x24E9340 VA: 0x1824EA140
	public int GetPoints(List<Vector2> points) { }

	[NativeMethod("SetPoints_Binding")]
	// RVA: 0x24EA1D0 Offset: 0x24E93D0 VA: 0x1824EA1D0
	public bool SetPoints(List<Vector2> points) { }

	// RVA: 0x24EA4A0 Offset: 0x24E96A0 VA: 0x1824EA4A0
	public bool get_useAdjacentStartPoint() { }

	// RVA: 0x24EA6F0 Offset: 0x24E98F0 VA: 0x1824EA6F0
	public void set_useAdjacentStartPoint(bool value) { }

	// RVA: 0x24EA460 Offset: 0x24E9660 VA: 0x1824EA460
	public bool get_useAdjacentEndPoint() { }

	// RVA: 0x24EA6A0 Offset: 0x24E98A0 VA: 0x1824EA6A0
	public void set_useAdjacentEndPoint(bool value) { }

	// RVA: 0x24EA310 Offset: 0x24E9510 VA: 0x1824EA310
	public Vector2 get_adjacentStartPoint() { }

	// RVA: 0x24EA5C0 Offset: 0x24E97C0 VA: 0x1824EA5C0
	public void set_adjacentStartPoint(Vector2 value) { }

	// RVA: 0x24EA270 Offset: 0x24E9470 VA: 0x1824EA270
	public Vector2 get_adjacentEndPoint() { }

	// RVA: 0x24EA530 Offset: 0x24E9730 VA: 0x1824EA530
	public void set_adjacentEndPoint(Vector2 value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24EA2C0 Offset: 0x24E94C0 VA: 0x1824EA2C0
	private void get_adjacentStartPoint_Injected(out Vector2 ret) { }

	// RVA: 0x24EA570 Offset: 0x24E9770 VA: 0x1824EA570
	private void set_adjacentStartPoint_Injected(ref Vector2 value) { }

	// RVA: 0x24EA220 Offset: 0x24E9420 VA: 0x1824EA220
	private void get_adjacentEndPoint_Injected(out Vector2 ret) { }

	// RVA: 0x24EA4E0 Offset: 0x24E96E0 VA: 0x1824EA4E0
	private void set_adjacentEndPoint_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D // TypeDefIndex: 17534
{
	// Properties
	public Vector2 size { get; set; }
	public float edgeRadius { get; set; }
	public bool autoTiling { get; set; }
	[Obsolete("BoxCollider2D.center has been deprecated. Use BoxCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	[EditorBrowsable(1)]
	public Vector2 center { get; set; }

	// Methods

	// RVA: 0x24E9570 Offset: 0x24E8770 VA: 0x1824E9570
	public Vector2 get_size() { }

	// RVA: 0x24E96B0 Offset: 0x24E88B0 VA: 0x1824E96B0
	public void set_size(Vector2 value) { }

	// RVA: 0x24E94E0 Offset: 0x24E86E0 VA: 0x1824E94E0
	public float get_edgeRadius() { }

	// RVA: 0x24E9610 Offset: 0x24E8810 VA: 0x1824E9610
	public void set_edgeRadius(float value) { }

	// RVA: 0x24E94A0 Offset: 0x24E86A0 VA: 0x1824E94A0
	public bool get_autoTiling() { }

	// RVA: 0x24E95C0 Offset: 0x24E87C0 VA: 0x1824E95C0
	public void set_autoTiling(bool value) { }

	// RVA: 0x54D140 Offset: 0x54C340 VA: 0x18054D140
	public Vector2 get_center() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_center(Vector2 value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24E9520 Offset: 0x24E8720 VA: 0x1824E9520
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x24E9660 Offset: 0x24E8860 VA: 0x1824E9660
	private void set_size_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 17535
{
	// Properties
	public bool useDelaunayMesh { get; set; }
	public bool autoTiling { get; set; }
	public Vector2[] points { get; set; }
	public int pathCount { get; set; }

	// Methods

	// RVA: 0x24EE500 Offset: 0x24ED700 VA: 0x1824EE500
	public bool get_useDelaunayMesh() { }

	// RVA: 0x24EE620 Offset: 0x24ED820 VA: 0x1824EE620
	public void set_useDelaunayMesh(bool value) { }

	// RVA: 0x24EE440 Offset: 0x24ED640 VA: 0x1824EE440
	public bool get_autoTiling() { }

	// RVA: 0x24EE540 Offset: 0x24ED740 VA: 0x1824EE540
	public void set_autoTiling(bool value) { }

	[NativeMethod("GetPointCount")]
	// RVA: 0x24EE1C0 Offset: 0x24ED3C0 VA: 0x1824EE1C0
	public int GetTotalPointCount() { }

	[NativeMethod("GetPoints_Binding")]
	// RVA: 0x24EE4C0 Offset: 0x24ED6C0 VA: 0x1824EE4C0
	public Vector2[] get_points() { }

	[NativeMethod("SetPoints_Binding")]
	// RVA: 0x24EE5D0 Offset: 0x24ED7D0 VA: 0x1824EE5D0
	public void set_points(Vector2[] value) { }

	// RVA: 0x24EE480 Offset: 0x24ED680 VA: 0x1824EE480
	public int get_pathCount() { }

	// RVA: 0x24EE590 Offset: 0x24ED790 VA: 0x1824EE590
	public void set_pathCount(int value) { }

	// RVA: 0x24EE050 Offset: 0x24ED250 VA: 0x1824EE050
	public Vector2[] GetPath(int index) { }

	[NativeMethod("GetPath_Binding")]
	// RVA: 0x24EDE80 Offset: 0x24ED080 VA: 0x1824EDE80
	private Vector2[] GetPath_Internal(int index) { }

	// RVA: 0x24EE2A0 Offset: 0x24ED4A0 VA: 0x1824EE2A0
	public void SetPath(int index, Vector2[] points) { }

	[NativeMethod("SetPath_Binding")]
	// RVA: 0x24EE250 Offset: 0x24ED450 VA: 0x1824EE250
	private void SetPath_Internal(int index, Vector2[] points) { }

	// RVA: 0x24EDEC0 Offset: 0x24ED0C0 VA: 0x1824EDEC0
	public int GetPath(int index, List<Vector2> points) { }

	[NativeMethod("GetPathList_Binding")]
	// RVA: 0x24EDE30 Offset: 0x24ED030 VA: 0x1824EDE30
	private int GetPathList_Internal(int index, List<Vector2> points) { }

	// RVA: 0x24EE370 Offset: 0x24ED570 VA: 0x1824EE370
	public void SetPath(int index, List<Vector2> points) { }

	[NativeMethod("SetPathList_Binding")]
	// RVA: 0x24EE200 Offset: 0x24ED400 VA: 0x1824EE200
	private void SetPathList_Internal(int index, List<Vector2> points) { }

	[ExcludeFromDocs]
	// RVA: 0x24EDBC0 Offset: 0x24ECDC0 VA: 0x1824EDBC0
	public void CreatePrimitive(int sides) { }

	[ExcludeFromDocs]
	// RVA: 0x24EDDB0 Offset: 0x24ECFB0 VA: 0x1824EDDB0
	public void CreatePrimitive(int sides, Vector2 scale) { }

	// RVA: 0x24EDC80 Offset: 0x24ECE80 VA: 0x1824EDC80
	public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset) { }

	[NativeMethod("CreatePrimitive")]
	// RVA: 0x24EDB60 Offset: 0x24ECD60 VA: 0x1824EDB60
	private void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24EDAF0 Offset: 0x24ECCF0 VA: 0x1824EDAF0
	private void CreatePrimitive_Internal_Injected(int sides, ref Vector2 scale, ref Vector2 offset, bool autoRefresh) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Effector2D.h")]
public class Effector2D : Behaviour // TypeDefIndex: 17536
{
	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/AreaEffector2D.h")]
public class AreaEffector2D : Effector2D // TypeDefIndex: 17537
{
	// Properties
	public float forceAngle { get; set; }
	public bool useGlobalAngle { get; set; }
	public float forceMagnitude { get; set; }
	public float forceVariation { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public EffectorSelection2D forceTarget { get; set; }
	[Obsolete("AreaEffector2D.forceDirection has been deprecated. Use AreaEffector2D.forceAngle instead (UnityUpgradable) -> forceAngle", True)]
	[EditorBrowsable(1)]
	public float forceDirection { get; set; }

	// Methods

	// RVA: 0x24E9140 Offset: 0x24E8340 VA: 0x1824E9140
	public float get_forceAngle() { }

	// RVA: 0x24E9320 Offset: 0x24E8520 VA: 0x1824E9320
	public void set_forceAngle(float value) { }

	// RVA: 0x24E9240 Offset: 0x24E8440 VA: 0x1824E9240
	public bool get_useGlobalAngle() { }

	// RVA: 0x24E9450 Offset: 0x24E8650 VA: 0x1824E9450
	public void set_useGlobalAngle(bool value) { }

	// RVA: 0x24E9180 Offset: 0x24E8380 VA: 0x1824E9180
	public float get_forceMagnitude() { }

	// RVA: 0x24E9370 Offset: 0x24E8570 VA: 0x1824E9370
	public void set_forceMagnitude(float value) { }

	// RVA: 0x24E9200 Offset: 0x24E8400 VA: 0x1824E9200
	public float get_forceVariation() { }

	// RVA: 0x24E9400 Offset: 0x24E8600 VA: 0x1824E9400
	public void set_forceVariation(float value) { }

	// RVA: 0x24E9100 Offset: 0x24E8300 VA: 0x1824E9100
	public float get_drag() { }

	// RVA: 0x24E92D0 Offset: 0x24E84D0 VA: 0x1824E92D0
	public void set_drag(float value) { }

	// RVA: 0x24E90C0 Offset: 0x24E82C0 VA: 0x1824E90C0
	public float get_angularDrag() { }

	// RVA: 0x24E9280 Offset: 0x24E8480 VA: 0x1824E9280
	public void set_angularDrag(float value) { }

	// RVA: 0x24E91C0 Offset: 0x24E83C0 VA: 0x1824E91C0
	public EffectorSelection2D get_forceTarget() { }

	// RVA: 0x24E93C0 Offset: 0x24E85C0 VA: 0x1824E93C0
	public void set_forceTarget(EffectorSelection2D value) { }

	// RVA: 0x24E9140 Offset: 0x24E8340 VA: 0x1824E9140
	public float get_forceDirection() { }

	// RVA: 0x24E9320 Offset: 0x24E8520 VA: 0x1824E9320
	public void set_forceDirection(float value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
public sealed class PhysicsMaterial2D : Object // TypeDefIndex: 17538
{
	// Properties
	public float bounciness { get; set; }
	public float friction { get; set; }

	// Methods

	// RVA: 0x24ECB90 Offset: 0x24EBD90 VA: 0x1824ECB90
	public void .ctor() { }

	// RVA: 0x24ECB10 Offset: 0x24EBD10 VA: 0x1824ECB10
	public void .ctor(string name) { }

	[NativeMethod("Create_Binding")]
	// RVA: 0x24ECAC0 Offset: 0x24EBCC0 VA: 0x1824ECAC0
	private static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name) { }

	// RVA: 0x24ECC00 Offset: 0x24EBE00 VA: 0x1824ECC00
	public float get_bounciness() { }

	// RVA: 0x24ECC80 Offset: 0x24EBE80 VA: 0x1824ECC80
	public void set_bounciness(float value) { }

	// RVA: 0x24ECC40 Offset: 0x24EBE40 VA: 0x1824ECC40
	public float get_friction() { }

	// RVA: 0x24ECCD0 Offset: 0x24EBED0 VA: 0x1824ECCD0
	public void set_friction(float value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17539
{}

// Namespace: 
[CompilerGenerated]
private struct Ua2CoreInitializeCallback.<Initialize>d__2 : IAsyncStateMachine // TypeDefIndex: 17540
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CoreRegistry registry; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x239D740 Offset: 0x239C940 VA: 0x18239D740 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x239E460 Offset: 0x239D660 VA: 0x18239E460 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
internal class Ua2CoreInitializeCallback : IInitializablePackage // TypeDefIndex: 17541
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x239E5D0 Offset: 0x239D7D0 VA: 0x18239E5D0
	private static void Register() { }

	[AsyncStateMachine(typeof(Ua2CoreInitializeCallback.<Initialize>d__2))]
	// RVA: 0x239E510 Offset: 0x239D710 VA: 0x18239E510 Slot: 4
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics
public static class AnalyticsService // TypeDefIndex: 17542
{
	// Fields
	internal static AnalyticsServiceInstance internalInstance; // 0x0

	// Properties
	public static IAnalyticsService Instance { get; }

	// Methods

	// RVA: 0x2397090 Offset: 0x2396290 VA: 0x182397090
	public static IAnalyticsService get_Instance() { }
}

// Namespace: 
internal enum AnalyticsServiceInstance.ConsentFlow // TypeDefIndex: 17543
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsServiceInstance.ConsentFlow Neither = 0;
	public const AnalyticsServiceInstance.ConsentFlow Old = 1;
	public const AnalyticsServiceInstance.ConsentFlow New = 2;
}

// Namespace: Unity.Services.Analytics
internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IBufferIds // TypeDefIndex: 17544
{
	// Fields
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.OptOut";
	private const string m_StartUpCallingId = "com.unity.services.analytics.Events.Startup";
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; // 0x10
	private readonly StdCommonParams m_CommonParams; // 0x18
	private readonly IPlayerId m_PlayerId; // 0x20
	private readonly IInstallationId m_InstallId; // 0x28
	private readonly IDataGenerator m_DataGenerator; // 0x30
	private readonly ICoreStatsHelper m_CoreStatsHelper; // 0x38
	private readonly IConsentTracker m_ConsentTracker; // 0x40
	private readonly IDispatcher m_DataDispatcher; // 0x48
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; // 0x50
	private readonly IExternalUserId m_CustomUserId; // 0x58
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; // 0x60
	private readonly IAnalyticsContainer m_Container; // 0x68
	internal IBuffer m_DataBuffer; // 0x70
	[CompilerGenerated]
	private string <SessionID>k__BackingField; // 0x78
	private int m_BufferLengthAtLastGameRunning; // 0x80
	private DateTime m_ApplicationPauseTime; // 0x88
	private bool m_IsActive; // 0x90
	private AnalyticsServiceInstance.ConsentFlow m_ConsentFlow; // 0x94
	private bool m_StartUpEventsRecorded; // 0x98
	private readonly TransactionCurrencyConverter converter; // 0xA0

	// Properties
	internal string CustomAnalyticsId { get; }
	public string SessionID { get; set; }
	public string UserId { get; }
	public string InstallId { get; }
	public string PlayerId { get; }
	public string SessionId { get; }
	internal int AutoflushPeriodMultiplier { get; }

	// Methods

	// RVA: 0x2395A50 Offset: 0x2394C50 VA: 0x182395A50
	internal void OldForgetMeEventUploaded() { }

	// RVA: 0x2396F60 Offset: 0x2396160 VA: 0x182396F60
	internal string get_CustomAnalyticsId() { }

	[CompilerGenerated]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 10
	public string get_SessionID() { }

	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	private void set_SessionID(string value) { }

	// RVA: 0x2395990 Offset: 0x2394B90 VA: 0x182395990 Slot: 6
	public string get_UserId() { }

	// RVA: 0x2396FB0 Offset: 0x23961B0 VA: 0x182396FB0 Slot: 7
	public string get_InstallId() { }

	// RVA: 0x2397000 Offset: 0x2396200 VA: 0x182397000 Slot: 8
	public string get_PlayerId() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 9
	public string get_SessionId() { }

	// RVA: 0x2396B50 Offset: 0x2395D50 VA: 0x182396B50
	internal void .ctor(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IConsentTracker consentTracker, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IInstallationId installId, IPlayerId playerId, string environment, IExternalUserId customAnalyticsId, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container) { }

	// RVA: 0x2395D90 Offset: 0x2394F90 VA: 0x182395D90
	internal void ResumeDataDeletionIfNecessary() { }

	// RVA: 0x23952D0 Offset: 0x23944D0 VA: 0x1823952D0
	internal void DeactivateWithDataDeletionRequest() { }

	// RVA: 0x2395270 Offset: 0x2394470 VA: 0x182395270
	private void DataDeletionCompleted() { }

	// RVA: 0x23955D0 Offset: 0x23947D0 VA: 0x1823955D0
	private void Deactivate() { }

	// RVA: 0x2395990 Offset: 0x2394B90 VA: 0x182395990 Slot: 11
	public string GetAnalyticsUserID() { }

	// RVA: 0x2394AA0 Offset: 0x2393CA0 VA: 0x182394AA0
	internal void ApplicationPaused(bool paused) { }

	// RVA: 0x2395D50 Offset: 0x2394F50 VA: 0x182395D50
	internal void RefreshSessionID() { }

	// RVA: 0x2396EF0 Offset: 0x23960F0 VA: 0x182396EF0
	internal int get_AutoflushPeriodMultiplier() { }

	// RVA: 0x23956C0 Offset: 0x23948C0 VA: 0x1823956C0 Slot: 12
	public void Flush() { }

	// RVA: 0x2394BB0 Offset: 0x2393DB0 VA: 0x182394BB0
	internal void ApplicationQuit() { }

	// RVA: 0x2395AD0 Offset: 0x2394CD0 VA: 0x182395AD0
	internal void RecordGameRunningIfNecessary() { }

	// RVA: 0x2396A70 Offset: 0x2395C70 VA: 0x182396A70
	private void SetVariableCommonParams() { }

	// RVA: 0x2394ED0 Offset: 0x23940D0 VA: 0x182394ED0 Slot: 5
	public void CustomData(string eventName, IDictionary<string, object> eventParams, Nullable<int> eventVersion, bool includeCommonParams, bool includePlayerIds, string callingMethodIdentifier) { }

	// RVA: 0x2395DF0 Offset: 0x2394FF0 VA: 0x182395DF0
	private void SerializeObject(string eventName, string key, object value) { }

	// RVA: 0x2394D30 Offset: 0x2393F30 VA: 0x182394D30 Slot: 4
	public long ConvertCurrencyToMinorUnits(string currencyCode, double value) { }
}

// Namespace: Unity.Services.Analytics
internal interface IAnalyticsServiceSystemCalls // TypeDefIndex: 17545
{
	// Properties
	public abstract DateTime UtcNow { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTime get_UtcNow();
}

// Namespace: Unity.Services.Analytics
internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls // TypeDefIndex: 17546
{
	// Properties
	public DateTime UtcNow { get; }

	// Methods

	// RVA: 0x2397050 Offset: 0x2396250 VA: 0x182397050 Slot: 4
	public DateTime get_UtcNow() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics
internal interface IUnstructuredEventRecorder // TypeDefIndex: 17547
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CustomData(string eventName, IDictionary<string, object> eventParams, Nullable<int> eventVersion, bool includeCommonParams, bool includePlayerIds, string callingMethodIdentifier);
}

// Namespace: Unity.Services.Analytics
internal class TransactionCurrencyConverter // TypeDefIndex: 17548
{
	// Fields
	private readonly Dictionary<string, int> m_Iso4217CurrencyMinorUnits; // 0x10

	// Methods

	// RVA: 0x239BAD0 Offset: 0x239ACD0 VA: 0x18239BAD0
	public long Convert(string currencyCode, double value) { }

	// RVA: 0x239BC60 Offset: 0x239AE60 VA: 0x18239BC60
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics
public enum TransactionServer // TypeDefIndex: 17549
{
	// Fields
	public int value__; // 0x0
	public const TransactionServer APPLE = 0;
	public const TransactionServer AMAZON = 1;
	public const TransactionServer GOOGLE = 2;
}

// Namespace: Unity.Services.Analytics
public enum TransactionType // TypeDefIndex: 17550
{
	// Fields
	public int value__; // 0x0
	public const TransactionType INVALID = 0;
	public const TransactionType SALE = 1;
	public const TransactionType PURCHASE = 2;
	public const TransactionType TRADE = 3;
}

// Namespace: Unity.Services.Analytics
public interface IAnalyticsService // TypeDefIndex: 17551
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long ConvertCurrencyToMinorUnits(string currencyCode, double value);
}

// Namespace: Unity.Services.Analytics
internal interface IAnalyticsContainer // TypeDefIndex: 17552
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Enable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Disable();
}

// Namespace: Unity.Services.Analytics
internal class AnalyticsContainer : MonoBehaviour, IAnalyticsContainer // TypeDefIndex: 17553
{
	// Fields
	private const float k_AutoFlushPeriod = 60;
	private const float k_GameRunningPeriod = 60;
	private static bool s_Created; // 0x0
	private static GameObject s_Container; // 0x8
	private float m_AutoFlushTime; // 0x20
	private float m_GameRunningTime; // 0x24
	private AnalyticsServiceInstance m_Service; // 0x28
	[CompilerGenerated]
	private static AnalyticsContainer <Instance>k__BackingField; // 0x10

	// Properties
	private float AutoFlushPeriod { get; }
	internal static AnalyticsContainer Instance { get; set; }
	internal float TimeUntilHeartbeat { get; }

	// Methods

	// RVA: 0x2394260 Offset: 0x2393460 VA: 0x182394260
	private float get_AutoFlushPeriod() { }

	[CompilerGenerated]
	// RVA: 0x23942E0 Offset: 0x23934E0 VA: 0x1823942E0
	internal static AnalyticsContainer get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2394340 Offset: 0x2393540 VA: 0x182394340
	private static void set_Instance(AnalyticsContainer value) { }

	// RVA: 0x2394320 Offset: 0x2393520 VA: 0x182394320
	internal float get_TimeUntilHeartbeat() { }

	// RVA: 0x2393CB0 Offset: 0x2392EB0 VA: 0x182393CB0
	internal static AnalyticsContainer CreateContainer() { }

	// RVA: 0x2393EC0 Offset: 0x23930C0 VA: 0x182393EC0 Slot: 6
	public void Initialize(AnalyticsServiceInstance service) { }

	// RVA: 0x2393EB0 Offset: 0x23930B0 VA: 0x182393EB0 Slot: 4
	public void Enable() { }

	// RVA: 0x2393E90 Offset: 0x2393090 VA: 0x182393E90 Slot: 5
	public void Disable() { }

	// RVA: 0x23941C0 Offset: 0x23933C0 VA: 0x1823941C0
	private void Update() { }

	// RVA: 0x2393ED0 Offset: 0x23930D0 VA: 0x182393ED0
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x2393FE0 Offset: 0x23931E0 VA: 0x182393FE0
	private void OnDestroy() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics
[Preserve]
public enum ConsentCheckExceptionReason // TypeDefIndex: 17554
{
	// Fields
	public int value__; // 0x0
	public const ConsentCheckExceptionReason Unknown = 0;
	public const ConsentCheckExceptionReason DeserializationIssue = 1;
	public const ConsentCheckExceptionReason NoInternetConnection = 2;
	public const ConsentCheckExceptionReason InvalidConsentFlow = 3;
	public const ConsentCheckExceptionReason ConsentFlowNotKnown = 4;
}

// Namespace: Unity.Services.Analytics
public class ConsentCheckException : RequestFailedException // TypeDefIndex: 17555
{
	// Fields
	[CompilerGenerated]
	private ConsentCheckExceptionReason <Reason>k__BackingField; // 0x98

	// Properties
	[Preserve]
	public ConsentCheckExceptionReason Reason { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public ConsentCheckExceptionReason get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x838420 Offset: 0x837620 VA: 0x180838420
	private void set_Reason(ConsentCheckExceptionReason value) { }

	// RVA: 0x2399B00 Offset: 0x2398D00 VA: 0x182399B00
	public void .ctor(ConsentCheckExceptionReason reason, int errorCode, string message, Exception innerException) { }
}

// Namespace: Unity.Services.Analytics
internal interface ICoreStatsHelper // TypeDefIndex: 17556
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetCoreStatsConsent(bool userProvidedConsent);
}

// Namespace: Unity.Services.Analytics
internal class CoreStatsHelper : ICoreStatsHelper // TypeDefIndex: 17557
{
	// Methods

	// RVA: 0x239A160 Offset: 0x2399360 VA: 0x18239A160 Slot: 4
	public void SetCoreStatsConsent(bool userProvidedConsent) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics
public static class SdkVersion // TypeDefIndex: 17558
{
	// Fields
	public static readonly string SDK_VERSION; // 0x0

	// Methods

	// RVA: 0x239B470 Offset: 0x239A670 VA: 0x18239B470
	private static void .cctor() { }
}

// Namespace: Unity.Services.Analytics.Platform
internal static class DeviceVolumeProvider // TypeDefIndex: 17559
{
	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static Nullable<float> GetDeviceVolume() { }
}

// Namespace: Unity.Services.Analytics.Platform
internal enum UA2PlatformCode // TypeDefIndex: 17560
{
	// Fields
	public int value__; // 0x0
	public const UA2PlatformCode UNKNOWN = 0;
	public const UA2PlatformCode IOS = 1;
	public const UA2PlatformCode IOS_MOBILE = 2;
	public const UA2PlatformCode IOS_TABLET = 3;
	public const UA2PlatformCode IOS_TV = 4;
	public const UA2PlatformCode ANDROID = 5;
	public const UA2PlatformCode ANDROID_MOBILE = 6;
	public const UA2PlatformCode ANDROID_CONSOLE = 7;
	public const UA2PlatformCode WINDOWS_MOBILE = 8;
	public const UA2PlatformCode WINDOWS_TABLET = 9;
	public const UA2PlatformCode BLACKBERRY_MOBILE = 10;
	public const UA2PlatformCode BLACKBERRY_TABLET = 11;
	public const UA2PlatformCode FACEBOOK = 12;
	public const UA2PlatformCode AMAZON = 13;
	public const UA2PlatformCode WEB = 14;
	public const UA2PlatformCode PC_CLIENT = 15;
	public const UA2PlatformCode MAC_CLIENT = 16;
	public const UA2PlatformCode PS3 = 17;
	public const UA2PlatformCode PS4 = 18;
	public const UA2PlatformCode PSVITA = 19;
	public const UA2PlatformCode XBOX360 = 20;
	public const UA2PlatformCode XBOXONE = 21;
	public const UA2PlatformCode WIIU = 22;
	public const UA2PlatformCode SWITCH = 23;
}

// Namespace: Unity.Services.Analytics.Platform
public static class Runtime // TypeDefIndex: 17561
{
	// Methods

	// RVA: 0x239B300 Offset: 0x239A500 VA: 0x18239B300
	public static string Name() { }

	// RVA: 0x239B1B0 Offset: 0x239A3B0 VA: 0x18239B1B0
	private static UA2PlatformCode GetPlatform() { }
}

// Namespace: Unity.Services.Analytics.Data
internal class StdCommonParams // TypeDefIndex: 17562
{
	// Fields
	[CompilerGenerated]
	private string <GameStoreID>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <GameBundleID>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Platform>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UasUserID>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Idfv>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<double> <DeviceVolume>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<double> <BatteryLoad>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <BuildGuuid>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <ClientVersion>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <UserCountry>k__BackingField; // 0x68
	[CompilerGenerated]
	private string <ProjectID>k__BackingField; // 0x70

	// Properties
	internal string GameStoreID { get; }
	internal string GameBundleID { get; set; }
	internal string Platform { get; set; }
	internal string UasUserID { get; set; }
	internal string Idfv { get; set; }
	internal Nullable<double> DeviceVolume { get; set; }
	internal Nullable<double> BatteryLoad { get; set; }
	internal string BuildGuuid { get; set; }
	internal string ClientVersion { get; set; }
	internal string UserCountry { get; }
	internal string ProjectID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_GameStoreID() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_GameBundleID() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_GameBundleID(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Platform(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_UasUserID() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_UasUserID(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal string get_Idfv() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_Idfv(string value) { }

	[CompilerGenerated]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	internal Nullable<double> get_DeviceVolume() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	internal void set_DeviceVolume(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0
	internal Nullable<double> get_BatteryLoad() { }

	[CompilerGenerated]
	// RVA: 0x528FF0 Offset: 0x5281F0 VA: 0x180528FF0
	internal void set_BatteryLoad(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal string get_BuildGuuid() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_BuildGuuid(string value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal string get_ClientVersion() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_ClientVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	internal string get_UserCountry() { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	internal string get_ProjectID() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void set_ProjectID(string value) { }

	// RVA: 0x239B6E0 Offset: 0x239A8E0 VA: 0x18239B6E0
	internal void SerializeCommonEventParams(ref IBuffer buf, string callingMethodIdentifier) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Data
internal interface IDataGenerator // TypeDefIndex: 17563
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetBuffer(IBuffer buffer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, DataGenerator.SessionEndState quitState);
}

// Namespace: 
internal enum DataGenerator.SessionEndState // TypeDefIndex: 17564
{
	// Fields
	public int value__; // 0x0
	public const DataGenerator.SessionEndState PAUSED = 0;
	public const DataGenerator.SessionEndState KILLEDINBACKGROUND = 1;
	public const DataGenerator.SessionEndState KILLEDINFOREGROUND = 2;
	public const DataGenerator.SessionEndState QUIT = 3;
}

// Namespace: Unity.Services.Analytics.Data
internal class DataGenerator : IDataGenerator // TypeDefIndex: 17565
{
	// Fields
	private IBuffer m_Buffer; // 0x10

	// Methods

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 4
	public void SetBuffer(IBuffer buffer) { }

	// RVA: 0x239A380 Offset: 0x2399580 VA: 0x18239A380 Slot: 5
	public void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier) { }

	// RVA: 0x239A170 Offset: 0x2399370 VA: 0x18239A170 Slot: 6
	public void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, DataGenerator.SessionEndState quitState) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent // TypeDefIndex: 17566
{
	// Fields
	private readonly IAnalyticsService m_AnalyticsService; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IAnalyticsService analyticsService) { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IAnalyticsForgetter // TypeDefIndex: 17567
{
	// Properties
	public abstract bool DeletionInProgress { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DeletionInProgress();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback);
}

// Namespace: 
private enum AnalyticsForgetter.DataDeletionStatus // TypeDefIndex: 17568
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsForgetter.DataDeletionStatus DataAllowed = 0;
	public const AnalyticsForgetter.DataDeletionStatus DeletionInProgress = 1;
	public const AnalyticsForgetter.DataDeletionStatus SuccessfullyDeleted = 2;
}

// Namespace: Unity.Services.Analytics.Internal
internal class AnalyticsForgetter : IAnalyticsForgetter // TypeDefIndex: 17569
{
	// Fields
	private readonly string m_CollectUrl; // 0x10
	private readonly IPersistence m_Persistence; // 0x18
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x20
	private byte[] m_Event; // 0x28
	private Action m_Callback; // 0x30
	private AnalyticsForgetter.DataDeletionStatus m_DeletionStatus; // 0x38
	private IWebRequest m_Request; // 0x40

	// Properties
	public bool DeletionInProgress { get; }

	// Methods

	// RVA: 0x2394A90 Offset: 0x2393C90 VA: 0x182394A90 Slot: 4
	public bool get_DeletionInProgress() { }

	// RVA: 0x2394980 Offset: 0x2393B80 VA: 0x182394980
	internal void .ctor(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper) { }

	// RVA: 0x23947D0 Offset: 0x23939D0 VA: 0x1823947D0
	private void SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus state) { }

	// RVA: 0x2394380 Offset: 0x2393580 VA: 0x182394380 Slot: 5
	public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	// RVA: 0x23948B0 Offset: 0x2393AB0 VA: 0x1823948B0
	private void UploadComplete(long code) { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IBuffer // TypeDefIndex: 17570
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] Serialize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PushStartEvent(string name, DateTime datetime, Nullable<long> eventVersion, bool addPlayerIdsToEventBody = False);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PushEndEvent();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PushObjectStart(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PushObjectEnd();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PushArrayStart(string name);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PushArrayEnd();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PushDouble(double val, string name);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void PushFloat(float val, string name);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void PushString(string val, string name);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void PushInt64(long val, string name);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void PushInt(int val, string name);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void PushBool(bool val, string name);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void PushTimestamp(DateTime val, string name);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void FlushToDisk();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ClearDiskCache();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ClearBuffer();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void ClearBuffer(long upTo);
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IBufferSystemCalls // TypeDefIndex: 17571
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GenerateGuid();
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IBufferIds // TypeDefIndex: 17572
{
	// Properties
	public abstract string UserId { get; }
	public abstract string InstallId { get; }
	public abstract string PlayerId { get; }
	public abstract string SessionId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InstallId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_PlayerId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_SessionId();
}

// Namespace: Unity.Services.Analytics.Internal
internal class BufferSystemCalls : IBufferSystemCalls // TypeDefIndex: 17573
{
	// Methods

	// RVA: 0x2397170 Offset: 0x2396370 VA: 0x182397170 Slot: 4
	public string GenerateGuid() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class BufferX : IBuffer // TypeDefIndex: 17574
{
	// Fields
	private readonly byte[] k_WorkingBuffer; // 0x10
	private readonly char[] k_WorkingCharacterBuffer; // 0x18
	private readonly byte[] k_BufferHeader; // 0x20
	private readonly byte[] k_HeaderEventName; // 0x28
	private readonly byte[] k_HeaderUserName; // 0x30
	private readonly byte[] k_HeaderSessionID; // 0x38
	private readonly byte[] k_HeaderEventUUID; // 0x40
	private readonly byte[] k_HeaderTimestamp; // 0x48
	private readonly byte[] k_HeaderEventVersion; // 0x50
	private readonly byte[] k_HeaderInstallationID; // 0x58
	private readonly byte[] k_HeaderPlayerID; // 0x60
	private readonly byte[] k_HeaderOpenEventParams; // 0x68
	private readonly byte[] k_CloseEvent; // 0x70
	private readonly byte k_Quote; // 0x78
	private readonly byte[] k_QuoteColon; // 0x80
	private readonly byte[] k_QuoteComma; // 0x88
	private readonly byte[] k_Comma; // 0x90
	private readonly byte[] k_OpenBrace; // 0x98
	private readonly byte[] k_CloseBraceComma; // 0xA0
	private readonly byte[] k_OpenBracket; // 0xA8
	private readonly byte[] k_CloseBracketComma; // 0xB0
	private readonly byte[] k_True; // 0xB8
	private readonly byte[] k_False; // 0xC0
	private readonly IBufferSystemCalls m_SystemCalls; // 0xC8
	private readonly IDiskCache m_DiskCache; // 0xD0
	private IBufferIds m_Ids; // 0xD8
	private readonly List<int> m_EventEnds; // 0xE0
	private MemoryStream m_SpareBuffer; // 0xE8
	private MemoryStream m_Buffer; // 0xF0

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x2399AD0 Offset: 0x2398CD0 VA: 0x182399AD0 Slot: 4
	public int get_Length() { }

	// RVA: 0x2399380 Offset: 0x2398580 VA: 0x182399380
	public void .ctor(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache) { }

	// RVA: 0x599C70 Offset: 0x598E70 VA: 0x180599C70
	public void InjectIds(IBufferIds ids) { }

	// RVA: 0x23992C0 Offset: 0x23984C0 VA: 0x1823992C0
	private void WriteString(in string value) { }

	// RVA: 0x2399190 Offset: 0x2398390 VA: 0x182399190
	private void WriteByte(in byte value) { }

	// RVA: 0x23991D0 Offset: 0x23983D0 VA: 0x1823991D0
	private void WriteBytes(in byte[] bytes) { }

	// RVA: 0x2399220 Offset: 0x2398420 VA: 0x182399220
	private void WriteName(string name) { }

	// RVA: 0x23981B0 Offset: 0x23973B0 VA: 0x1823981B0 Slot: 6
	public void PushStartEvent(string name, DateTime datetime, Nullable<long> eventVersion, bool addPlayerIdsToEventBody) { }

	// RVA: 0x23990B0 Offset: 0x23982B0 VA: 0x1823990B0
	private void StripTrailingCommaIfNecessary() { }

	// RVA: 0x2397A90 Offset: 0x2396C90 VA: 0x182397A90 Slot: 7
	public void PushEndEvent() { }

	// RVA: 0x23980D0 Offset: 0x23972D0 VA: 0x1823980D0 Slot: 8
	public void PushObjectStart(string name) { }

	// RVA: 0x2398070 Offset: 0x2397270 VA: 0x182398070 Slot: 9
	public void PushObjectEnd() { }

	// RVA: 0x2397710 Offset: 0x2396910 VA: 0x182397710 Slot: 10
	public void PushArrayStart(string name) { }

	// RVA: 0x23976B0 Offset: 0x23968B0 VA: 0x1823976B0 Slot: 11
	public void PushArrayEnd() { }

	// RVA: 0x2397940 Offset: 0x2396B40 VA: 0x182397940 Slot: 12
	public void PushDouble(double val, string name) { }

	// RVA: 0x2397D00 Offset: 0x2396F00 VA: 0x182397D00 Slot: 13
	public void PushFloat(float val, string name) { }

	// RVA: 0x2398720 Offset: 0x2397920 VA: 0x182398720 Slot: 14
	public void PushString(string value, string name) { }

	// RVA: 0x2397E50 Offset: 0x2397050 VA: 0x182397E50 Slot: 15
	public void PushInt64(long val, string name) { }

	// RVA: 0x2397F60 Offset: 0x2397160 VA: 0x182397F60 Slot: 16
	public void PushInt(int val, string name) { }

	// RVA: 0x23977F0 Offset: 0x23969F0 VA: 0x1823977F0 Slot: 17
	public void PushBool(bool val, string name) { }

	// RVA: 0x2398CA0 Offset: 0x2397EA0 VA: 0x182398CA0 Slot: 18
	public void PushTimestamp(DateTime val, string name) { }

	// RVA: 0x2398E60 Offset: 0x2398060 VA: 0x182398E60 Slot: 5
	public byte[] Serialize() { }

	// RVA: 0x23974B0 Offset: 0x23966B0 VA: 0x1823974B0 Slot: 21
	public void ClearBuffer() { }

	// RVA: 0x23971B0 Offset: 0x23963B0 VA: 0x1823971B0 Slot: 22
	public void ClearBuffer(long upTo) { }

	// RVA: 0x23975D0 Offset: 0x23967D0 VA: 0x1823975D0 Slot: 19
	public void FlushToDisk() { }

	// RVA: 0x2397580 Offset: 0x2396780 VA: 0x182397580 Slot: 20
	public void ClearDiskCache() { }

	// RVA: 0x2398DD0 Offset: 0x2397FD0 VA: 0x182398DD0
	internal static string SerializeDateTime(DateTime dateTime) { }
}

// Namespace: Unity.Services.Analytics.Internal
internal enum ConsentStatus // TypeDefIndex: 17575
{
	// Fields
	public int value__; // 0x0
	public const ConsentStatus Unknown = 0;
	public const ConsentStatus Forgetting = 1;
	public const ConsentStatus OptedOut = 2;
	public const ConsentStatus NotRequired = 3;
	public const ConsentStatus RequiredButUnchecked = 4;
	public const ConsentStatus ConsentGiven = 5;
	public const ConsentStatus ConsentDenied = 6;
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IConsentTracker // TypeDefIndex: 17576
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FinishOptOutProcess();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsGeoIpChecked();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsConsentGiven();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsOptingOutInProgress();
}

// Namespace: Unity.Services.Analytics.Internal
internal static class Consent // TypeDefIndex: 17577
{
	// Properties
	public static string Pipl { get; }

	// Methods

	// RVA: 0x239A130 Offset: 0x2399330 VA: 0x18239A130
	public static string get_Pipl() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class ConsentTracker : IConsentTracker // TypeDefIndex: 17578
{
	// Fields
	private readonly IGeoAPI m_GeoAPI; // 0x10
	private readonly ICoreStatsHelper m_CoreStatsHelper; // 0x18
	[CompilerGenerated]
	private ConsentStatus <optInPiplConsentStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private ConsentStatus <optOutConsentStatus>k__BackingField; // 0x24
	internal GeoIPResponse response; // 0x28

	// Properties
	internal ConsentStatus optInPiplConsentStatus { get; set; }
	internal ConsentStatus optOutConsentStatus { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal ConsentStatus get_optInPiplConsentStatus() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	internal void set_optInPiplConsentStatus(ConsentStatus value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	internal ConsentStatus get_optOutConsentStatus() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	internal void set_optOutConsentStatus(ConsentStatus value) { }

	// RVA: 0x2399E60 Offset: 0x2399060 VA: 0x182399E60
	public void .ctor(ICoreStatsHelper coreStatsHelper) { }

	// RVA: 0x2399FD0 Offset: 0x23991D0 VA: 0x182399FD0
	internal void .ctor(IGeoAPI geoApi, ICoreStatsHelper coreStatsHelper) { }

	// RVA: 0x6B5280 Offset: 0x6B4480 VA: 0x1806B5280 Slot: 5
	public bool IsGeoIpChecked() { }

	// RVA: 0x2399C40 Offset: 0x2398E40 VA: 0x182399C40 Slot: 6
	public bool IsConsentGiven() { }

	// RVA: 0x2399BD0 Offset: 0x2398DD0 VA: 0x182399BD0 Slot: 8
	public bool IsConsentGiven(string identifier) { }

	// RVA: 0x2399CC0 Offset: 0x2398EC0 VA: 0x182399CC0 Slot: 7
	public bool IsOptingOutInProgress() { }

	// RVA: 0x2399B40 Offset: 0x2398D40 VA: 0x182399B40 Slot: 4
	public void FinishOptOutProcess() { }

	// RVA: 0x2399D40 Offset: 0x2398F40 VA: 0x182399D40
	internal void ReadOptInPiplConsentStatus() { }

	// RVA: 0x2399D90 Offset: 0x2398F90 VA: 0x182399D90
	internal void ReadOptOutConsentStatus() { }

	// RVA: 0x2399DE0 Offset: 0x2398FE0 VA: 0x182399DE0
	private void ValidateConsentWasChecked() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IGeoAPI // TypeDefIndex: 17579
{}

// Namespace: Unity.Services.Analytics.Internal
internal class GeoAPI : IGeoAPI // TypeDefIndex: 17580
{
	// Fields
	private readonly string m_PrivacyEndpoint; // 0x10

	// Methods

	// RVA: 0x239B120 Offset: 0x239A320 VA: 0x18239B120
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
[Serializable]
internal class GeoIPResponse // TypeDefIndex: 17581
{
	// Fields
	public string identifier; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IDiskCache // TypeDefIndex: 17582
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Write(List<int> eventEndIndices, Stream payload);
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IFileSystemCalls // TypeDefIndex: 17583
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanAccessFileSystem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FileExists(string path);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DeleteFile(string path);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Stream OpenFileForWriting(string path);
}

// Namespace: Unity.Services.Analytics.Internal
internal class FileSystemCalls : IFileSystemCalls // TypeDefIndex: 17584
{
	// Methods

	// RVA: 0x239AFB0 Offset: 0x239A1B0 VA: 0x18239AFB0 Slot: 4
	public bool CanAccessFileSystem() { }

	// RVA: 0x83E710 Offset: 0x83D910 VA: 0x18083E710 Slot: 5
	public bool FileExists(string path) { }

	// RVA: 0x74F040 Offset: 0x74E240 VA: 0x18074F040 Slot: 6
	public void DeleteFile(string path) { }

	// RVA: 0x239B0C0 Offset: 0x239A2C0 VA: 0x18239B0C0 Slot: 7
	public Stream OpenFileForWriting(string path) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class DiskCache : IDiskCache // TypeDefIndex: 17585
{
	// Fields
	private readonly string k_CacheFilePath; // 0x10
	private readonly IFileSystemCalls k_SystemCalls; // 0x18
	private readonly long k_CacheFileMaximumSize; // 0x20

	// Methods

	// RVA: 0x239AA40 Offset: 0x2399C40 VA: 0x18239AA40
	internal void .ctor(IFileSystemCalls systemCalls) { }

	// RVA: 0x239A620 Offset: 0x2399820 VA: 0x18239A620 Slot: 5
	public void Write(List<int> eventEndIndices, Stream payload) { }

	// RVA: 0x239A510 Offset: 0x2399710 VA: 0x18239A510 Slot: 4
	public void Clear() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IDispatcher // TypeDefIndex: 17586
{
	// Properties
	public abstract int ConsecutiveFailedUploadCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ConsecutiveFailedUploadCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetBuffer(IBuffer buffer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Flush();
}

// Namespace: Unity.Services.Analytics.Internal
internal class Dispatcher : IDispatcher // TypeDefIndex: 17587
{
	// Fields
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x10
	private readonly string m_CollectUrl; // 0x18
	private IBuffer m_DataBuffer; // 0x20
	private IWebRequest m_FlushRequest; // 0x28
	[CompilerGenerated]
	private int <ConsecutiveFailedUploadCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <FlushInProgress>k__BackingField; // 0x34
	private int m_FlushBufferIndex; // 0x38

	// Properties
	public int ConsecutiveFailedUploadCount { get; set; }
	internal bool FlushInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 4
	public int get_ConsecutiveFailedUploadCount() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void set_ConsecutiveFailedUploadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	internal bool get_FlushInProgress() { }

	[CompilerGenerated]
	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	private void set_FlushInProgress(bool value) { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IWebRequestHelper webRequestHelper, string collectUrl) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 5
	public void SetBuffer(IBuffer buffer) { }

	// RVA: 0x239AD70 Offset: 0x2399F70 VA: 0x18239AD70 Slot: 6
	public void Flush() { }

	// RVA: 0x239AB00 Offset: 0x2399D00 VA: 0x18239AB00
	private void FlushBufferToService() { }

	// RVA: 0x239ADE0 Offset: 0x2399FE0 VA: 0x18239ADE0
	private void UploadCompleted(long responseCode) { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IPersistence // TypeDefIndex: 17588
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SaveValue(string key, int value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int LoadValue(string key);
}

// Namespace: Unity.Services.Analytics.Internal
internal class PlayerPrefsPersistence : IPersistence // TypeDefIndex: 17589
{
	// Methods

	// RVA: 0x239B190 Offset: 0x239A390 VA: 0x18239B190 Slot: 4
	public void SaveValue(string key, int value) { }

	// RVA: 0x239B160 Offset: 0x239A360 VA: 0x18239B160 Slot: 5
	public int LoadValue(string key) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IWebRequest // TypeDefIndex: 17590
{
	// Properties
	public abstract bool IsNetworkError { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UnityWebRequestAsyncOperation SendWebRequest();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetRequestHeader(string key, string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNetworkError();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Dispose();
}

// Namespace: Unity.Services.Analytics.Internal
internal interface IWebRequestHelper // TypeDefIndex: 17591
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendWebRequest(IWebRequest request, Action<long> onCompleted);
}

// Namespace: Unity.Services.Analytics.Internal
internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest // TypeDefIndex: 17592
{
	// Properties
	public bool IsNetworkError { get; }

	// Methods

	// RVA: 0x2397140 Offset: 0x2396340 VA: 0x182397140
	internal void .ctor(string url, string method) { }

	// RVA: 0x2397150 Offset: 0x2396350 VA: 0x182397150 Slot: 7
	public bool get_IsNetworkError() { }

	// RVA: 0x2397120 Offset: 0x2396320 VA: 0x182397120 Slot: 5
	private UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest() { }

	// RVA: 0x2397130 Offset: 0x2396330 VA: 0x182397130 Slot: 6
	private void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebRequestHelper.<>c__DisplayClass2_0 // TypeDefIndex: 17593
{
	// Fields
	public Action<long> onCompleted; // 0x10
	public UnityWebRequestAsyncOperation requestOp; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x239E4C0 Offset: 0x239D6C0 VA: 0x18239E4C0
	internal void <SendWebRequest>b__0(AsyncOperation <p0>) { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class WebRequestHelper : IWebRequestHelper // TypeDefIndex: 17594
{
	// Fields
	private readonly string k_ClientIdHeaderValue; // 0x10

	// Methods

	// RVA: 0x239E7B0 Offset: 0x239D9B0 VA: 0x18239E7B0 Slot: 4
	public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes) { }

	// RVA: 0x239E8C0 Offset: 0x239DAC0 VA: 0x18239E8C0 Slot: 5
	public void SendWebRequest(IWebRequest request, Action<long> onCompleted) { }

	// RVA: 0x239EA00 Offset: 0x239DC00 VA: 0x18239EA00
	public void .ctor() { }
}

// Namespace: Unity.Services.Analytics.Internal
internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent // TypeDefIndex: 17595
{
	// Fields
	private readonly IProjectConfiguration m_Configuration; // 0x10
	private readonly IUnstructuredEventRecorder m_AnalyticsService; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService) { }

	// RVA: 0x239B4C0 Offset: 0x239A6C0 VA: 0x18239B4C0 Slot: 4
	public void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17596
{}

// Namespace: 
internal static class SR // TypeDefIndex: 17597
{
	// Methods

	// RVA: 0x1ED2D50 Offset: 0x1ED1F50 VA: 0x181ED2D50
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: 
private enum BigInteger.GetBytesMode // TypeDefIndex: 17598
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;
}

// Namespace: System.Numerics
[IsReadOnly]
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 17599
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x1ECA050 Offset: 0x1EC9250 VA: 0x181ECA050
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1EC9940 Offset: 0x1EC8B40 VA: 0x181EC9940
	public void .ctor(uint value) { }

	// RVA: 0x1EC97D0 Offset: 0x1EC89D0 VA: 0x181EC97D0
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1EC9120 Offset: 0x1EC8320 VA: 0x181EC9120
	public void .ctor(ulong value) { }

	// RVA: 0x1EC9770 Offset: 0x1EC8970 VA: 0x181EC9770
	public void .ctor(float value) { }

	// RVA: 0x1EC9200 Offset: 0x1EC8400 VA: 0x181EC9200
	public void .ctor(double value) { }

	// RVA: 0x1EC9560 Offset: 0x1EC8760 VA: 0x181EC9560
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1EC9030 Offset: 0x1EC8230 VA: 0x181EC9030
	public void .ctor(byte[] value) { }

	// RVA: 0x1EC99D0 Offset: 0x1EC8BD0 VA: 0x181EC99D0
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x1EC8E70 Offset: 0x1EC8070 VA: 0x181EC8E70
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x1ECA130 Offset: 0x1EC9330 VA: 0x181ECA130
	public static BigInteger get_Zero() { }

	// RVA: 0x1ECA0D0 Offset: 0x1EC92D0 VA: 0x181ECA0D0
	public static BigInteger get_MinusOne() { }

	// RVA: 0x1BC5D40 Offset: 0x1BC4F40 VA: 0x181BC5D40
	public bool get_IsZero() { }

	// RVA: 0x1EC7CD0 Offset: 0x1EC6ED0 VA: 0x181EC7CD0
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1EC7F10 Offset: 0x1EC7110 VA: 0x181EC7F10
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1EC72E0 Offset: 0x1EC64E0 VA: 0x181EC72E0
	public static BigInteger DivRem(BigInteger dividend, BigInteger divisor, out BigInteger remainder) { }

	// RVA: 0x1EC7BB0 Offset: 0x1EC6DB0 VA: 0x181EC7BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EC7A90 Offset: 0x1EC6C90 VA: 0x181EC7A90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EC7A00 Offset: 0x1EC6C00 VA: 0x181EC7A00
	public bool Equals(long other) { }

	// RVA: 0x1EC78E0 Offset: 0x1EC6AE0 VA: 0x181EC78E0 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x1EC7130 Offset: 0x1EC6330 VA: 0x181EC7130
	public int CompareTo(long other) { }

	// RVA: 0x1EC6F70 Offset: 0x1EC6170 VA: 0x181EC6F70 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x1EC71D0 Offset: 0x1EC63D0 VA: 0x181EC71D0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x1EC8B10 Offset: 0x1EC7D10 VA: 0x181EC8B10
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x1EC8BD0 Offset: 0x1EC7DD0 VA: 0x181EC8BD0
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x1EC85C0 Offset: 0x1EC77C0 VA: 0x181EC85C0
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x1EC8330 Offset: 0x1EC7530 VA: 0x181EC8330 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EC83F0 Offset: 0x1EC75F0 VA: 0x181EC83F0
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1EC84C0 Offset: 0x1EC76C0 VA: 0x181EC84C0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1EC6DB0 Offset: 0x1EC5FB0 VA: 0x181EC6DB0
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x1ECC0B0 Offset: 0x1ECB2B0 VA: 0x181ECC0B0
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x1EC8110 Offset: 0x1EC7310 VA: 0x181EC8110
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x1ECB210 Offset: 0x1ECA410 VA: 0x181ECB210
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECB170 Offset: 0x1ECA370 VA: 0x181ECB170
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x1ECB1E0 Offset: 0x1ECA3E0 VA: 0x181ECB1E0
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECB260 Offset: 0x1ECA460 VA: 0x181ECB260
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x1ECB150 Offset: 0x1ECA350 VA: 0x181ECB150
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECB1C0 Offset: 0x1ECA3C0 VA: 0x181ECB1C0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1ECB240 Offset: 0x1ECA440 VA: 0x181ECB240
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECB1A0 Offset: 0x1ECA3A0 VA: 0x181ECB1A0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x1ECAFA0 Offset: 0x1ECA1A0 VA: 0x181ECAFA0
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECAAD0 Offset: 0x1EC9CD0 VA: 0x181ECAAD0
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x1ECA7E0 Offset: 0x1EC99E0 VA: 0x181ECA7E0
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECAF20 Offset: 0x1ECA120 VA: 0x181ECAF20
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x1ECA9A0 Offset: 0x1EC9BA0 VA: 0x181ECA9A0
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECAC90 Offset: 0x1EC9E90 VA: 0x181ECAC90
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x1ECB020 Offset: 0x1ECA220 VA: 0x181ECB020
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ECAE60 Offset: 0x1ECA060 VA: 0x181ECAE60
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x1ECAB50 Offset: 0x1EC9D50 VA: 0x181ECAB50
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x1ECAD40 Offset: 0x1EC9F40 VA: 0x181ECAD40
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x1ECA860 Offset: 0x1EC9A60 VA: 0x181ECA860
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x1ECB360 Offset: 0x1ECA560 VA: 0x181ECB360
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x1ECBBB0 Offset: 0x1ECADB0 VA: 0x181ECBBB0
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x1ECC2C0 Offset: 0x1ECB4C0 VA: 0x181ECC2C0
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x1ECA190 Offset: 0x1EC9390 VA: 0x181ECA190
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x1ECB890 Offset: 0x1ECAA90 VA: 0x181ECB890
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x1ECA3A0 Offset: 0x1EC95A0 VA: 0x181ECA3A0
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x1ECB6A0 Offset: 0x1ECA8A0 VA: 0x181ECB6A0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x1ECB2F0 Offset: 0x1ECA4F0 VA: 0x181ECB2F0
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x1ECB830 Offset: 0x1ECAA30 VA: 0x181ECB830
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x1ECB710 Offset: 0x1ECA910 VA: 0x181ECB710
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x1ECA780 Offset: 0x1EC9980 VA: 0x181ECA780
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x1ECB290 Offset: 0x1ECA490 VA: 0x181ECB290
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x1ECB7D0 Offset: 0x1ECA9D0 VA: 0x181ECB7D0
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x1ECB770 Offset: 0x1ECA970 VA: 0x181ECB770
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x1EC7C10 Offset: 0x1EC6E10 VA: 0x181EC7C10
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x1EC7B40 Offset: 0x1EC6D40 VA: 0x181EC7B40
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1EC8C80 Offset: 0x1EC7E80 VA: 0x181EC8C80
	private static void .cctor() { }
}

// Namespace: System.Numerics
internal static class BigIntegerCalculator // TypeDefIndex: 17600
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x1EC50F0 Offset: 0x1EC42F0 VA: 0x181EC50F0
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x1EC51C0 Offset: 0x1EC43C0 VA: 0x181EC51C0
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x1EC5040 Offset: 0x1EC4240 VA: 0x181EC5040
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1EC4FD0 Offset: 0x1EC41D0 VA: 0x181EC4FD0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x1EC6C70 Offset: 0x1EC5E70 VA: 0x181EC6C70
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x1EC6A30 Offset: 0x1EC5C30 VA: 0x181EC6A30
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x1EC6BC0 Offset: 0x1EC5DC0 VA: 0x181EC6BC0
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1EC52D0 Offset: 0x1EC44D0 VA: 0x181EC52D0
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x1EC57D0 Offset: 0x1EC49D0 VA: 0x181EC57D0
	public static uint[] Divide(uint[] left, uint right, out uint remainder) { }

	// RVA: 0x1EC58C0 Offset: 0x1EC4AC0 VA: 0x181EC58C0
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x1EC59A0 Offset: 0x1EC4BA0 VA: 0x181EC59A0
	public static uint[] Divide(uint[] left, uint[] right, out uint[] remainder) { }

	// RVA: 0x1EC5AF0 Offset: 0x1EC4CF0 VA: 0x181EC5AF0
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x1EC5410 Offset: 0x1EC4610 VA: 0x181EC5410
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1EC4FA0 Offset: 0x1EC41A0 VA: 0x181EC4FA0
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x1EC69E0 Offset: 0x1EC5BE0 VA: 0x181EC69E0
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x1EC53D0 Offset: 0x1EC45D0 VA: 0x181EC53D0
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x1EC5350 Offset: 0x1EC4550 VA: 0x181EC5350
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x1EC5C30 Offset: 0x1EC4E30 VA: 0x181EC5C30
	private static int LeadingZeros(uint value) { }

	// RVA: 0x1EC67F0 Offset: 0x1EC59F0 VA: 0x181EC67F0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x1EC63D0 Offset: 0x1EC55D0 VA: 0x181EC63D0
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x1EC6300 Offset: 0x1EC5500 VA: 0x181EC6300
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x1EC5CA0 Offset: 0x1EC4EA0 VA: 0x181EC5CA0
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x1EC5DC0 Offset: 0x1EC4FC0 VA: 0x181EC5DC0
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1EC68D0 Offset: 0x1EC5AD0 VA: 0x181EC68D0
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x1EC6D30 Offset: 0x1EC5F30 VA: 0x181EC6D30
	private static void .cctor() { }
}

// Namespace: 
private struct BigNumber.BigNumberBuffer // TypeDefIndex: 17601
{
	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x1ECC2E0 Offset: 0x1ECB4E0 VA: 0x181ECC2E0
	public static BigNumber.BigNumberBuffer Create() { }
}

// Namespace: System.Numerics
internal static class BigNumber // TypeDefIndex: 17602
{
	// Methods

	// RVA: 0x1ECE540 Offset: 0x1ECD740 VA: 0x181ECE540
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x1ECE200 Offset: 0x1ECD400 VA: 0x181ECE200
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x1ECDD60 Offset: 0x1ECCF60 VA: 0x181ECDD60
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1ECDF60 Offset: 0x1ECD160 VA: 0x181ECDF60
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1ECD870 Offset: 0x1ECCA70 VA: 0x181ECD870
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x1ECDAF0 Offset: 0x1ECCCF0 VA: 0x181ECDAF0
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x1ECE0C0 Offset: 0x1ECD2C0 VA: 0x181ECE0C0
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x1ECC340 Offset: 0x1ECB540 VA: 0x181ECC340
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x1ECCA80 Offset: 0x1ECBC80 VA: 0x181ECCA80
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x1ECCB70 Offset: 0x1ECBD70 VA: 0x181ECCB70
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}

// Namespace: System.Numerics
internal struct DoubleUlong // TypeDefIndex: 17603
{
	// Fields
	public double dbl; // 0x0
	public ulong uu; // 0x0
}

// Namespace: System.Numerics
internal static class NumericsHelpers // TypeDefIndex: 17604
{
	// Methods

	// RVA: 0x1ED2CB0 Offset: 0x1ED1EB0 VA: 0x181ED2CB0
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	// RVA: 0x1ED2B60 Offset: 0x1ED1D60 VA: 0x181ED2B60
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	// RVA: 0x1ED2AC0 Offset: 0x1ED1CC0 VA: 0x181ED2AC0
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x1ED2D40 Offset: 0x1ED1F40 VA: 0x181ED2D40
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x1ED2A00 Offset: 0x1ED1C00 VA: 0x181ED2A00
	public static uint Abs(int a) { }

	// RVA: 0x1ED2AB0 Offset: 0x1ED1CB0 VA: 0x181ED2AB0
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x1ED2AB0 Offset: 0x1ED1CB0 VA: 0x181ED2AB0
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x1EC5C30 Offset: 0x1EC4E30 VA: 0x181EC5C30
	public static int CbitHighZero(uint u) { }

	// RVA: 0x1ED2A10 Offset: 0x1ED1C10 VA: 0x181ED2A10
	public static int CbitHighZero(ulong uu) { }
}

// Namespace: 
internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 17605
{
	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	public bool sign; // 0x8
	public char* overrideDigits; // 0x10

	// Properties
	public char* digits { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public char* get_digits() { }
}

// Namespace: 
private class FormatProvider.Number // TypeDefIndex: 17606
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x1ECFD50 Offset: 0x1ECEF50 VA: 0x181ECFD50
	private static bool IsWhite(char ch) { }

	// RVA: 0x1ECFDC0 Offset: 0x1ECEFC0 VA: 0x181ECFDC0
	private static char* MatchChars(char* p, char* pEnd, string str) { }

	// RVA: 0x1ECFD70 Offset: 0x1ECEF70 VA: 0x181ECFD70
	private static char* MatchChars(char* p, char* pEnd, char* str) { }

	// RVA: 0x1ED1510 Offset: 0x1ED0710 VA: 0x181ED1510
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x1ED2120 Offset: 0x1ED1320 VA: 0x181ED2120
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x1ED21A0 Offset: 0x1ED13A0 VA: 0x181ED21A0
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x1ECFCE0 Offset: 0x1ECEEE0 VA: 0x181ECFCE0
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x1ED1370 Offset: 0x1ED0570 VA: 0x181ED1370
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x1ED0C60 Offset: 0x1ECFE60 VA: 0x181ED0C60
	internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x1ECEB60 Offset: 0x1ECDD60 VA: 0x181ECEB60
	private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1ED29E0 Offset: 0x1ED1BE0 VA: 0x181ED29E0
	private static int wcslen(char* s) { }

	// RVA: 0x1ECEF60 Offset: 0x1ECE160 VA: 0x181ECEF60
	private static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x1ECF750 Offset: 0x1ECE950 VA: 0x181ECF750
	private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1ECFB60 Offset: 0x1ECED60 VA: 0x181ECFB60
	private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x1ECED80 Offset: 0x1ECDF80 VA: 0x181ECED80
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x1ECF430 Offset: 0x1ECE630 VA: 0x181ECF430
	private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x1ECF930 Offset: 0x1ECEB30 VA: 0x181ECF930
	private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1ED2040 Offset: 0x1ED1240 VA: 0x181ED2040
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x1ECEA40 Offset: 0x1ECDC40 VA: 0x181ECEA40
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0x1ECFE80 Offset: 0x1ECF080 VA: 0x181ECFE80
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x1ED2330 Offset: 0x1ED1530 VA: 0x181ED2330
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 17607
{
	// Methods

	// RVA: 0x1ECE690 Offset: 0x1ECD890 VA: 0x181ECE690
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x1ECE800 Offset: 0x1ECDA00 VA: 0x181ECE800
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}

// Namespace: System.Text
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 17608
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x15E07D0 Offset: 0x15DF9D0 VA: 0x1815E07D0
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Length() { }

	// RVA: 0x1ED3740 Offset: 0x1ED2940 VA: 0x181ED3740 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ED3820 Offset: 0x1ED2A20 VA: 0x181ED3820
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x1ED3560 Offset: 0x1ED2760 VA: 0x181ED3560
	public void Insert(int index, char value, int count) { }

	// RVA: 0x1ED3260 Offset: 0x1ED2460 VA: 0x181ED3260
	public void Append(char c) { }

	// RVA: 0x1ED30D0 Offset: 0x1ED22D0 VA: 0x181ED30D0
	public void Append(string s) { }

	// RVA: 0x1ED2DC0 Offset: 0x1ED1FC0 VA: 0x181ED2DC0
	private void AppendSlow(string s) { }

	// RVA: 0x1ED2FF0 Offset: 0x1ED21F0 VA: 0x181ED2FF0
	public void Append(char c, int count) { }

	// RVA: 0x1ED3180 Offset: 0x1ED2380 VA: 0x181ED3180
	public void Append(char* value, int length) { }

	// RVA: 0x1ED2F10 Offset: 0x1ED2110 VA: 0x181ED2F10
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x1ED3370 Offset: 0x1ED2570 VA: 0x181ED3370
	private void GrowAndAppend(char c) { }

	// RVA: 0x1ED33B0 Offset: 0x1ED25B0 VA: 0x181ED33B0
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x1ED32D0 Offset: 0x1ED24D0 VA: 0x181ED32D0
	public void Dispose() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 17609
{}

// Namespace: 
internal static class SR // TypeDefIndex: 17610
{
	// Methods

	// RVA: 0x1EEBB80 Offset: 0x1EEAD80 VA: 0x181EEBB80
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1EEBB00 Offset: 0x1EEAD00 VA: 0x181EEBB00
	internal static string Format(string resourceFormat, object p1, object p2) { }
}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation // TypeDefIndex: 17611
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string baseUri) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation // TypeDefIndex: 17612
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 17613
{
	// Methods

	// RVA: 0x78E690 Offset: 0x78D890 VA: 0x18078E690
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
public class XAttribute : XObject // TypeDefIndex: 17614
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1EECB70 Offset: 0x1EEBD70 VA: 0x181EECB70
	public void .ctor(XName name, object value) { }

	// RVA: 0x1EECC60 Offset: 0x1EEBE60 VA: 0x181EECC60
	public void .ctor(XAttribute other) { }

	// RVA: 0x1EECCE0 Offset: 0x1EEBEE0 VA: 0x181EECCE0
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XName get_Name() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Value() { }

	// RVA: 0x1EEC3D0 Offset: 0x1EEB5D0 VA: 0x181EEC3D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EEC230 Offset: 0x1EEB430 VA: 0x181EEC230
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1EEC7C0 Offset: 0x1EEB9C0 VA: 0x181EEC7C0
	private static void ValidateAttribute(XName name, string value) { }
}

// Namespace: System.Xml.Linq
public class XCData : XText // TypeDefIndex: 17615
{
	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1EECEA0 Offset: 0x1EEC0A0 VA: 0x181EECEA0
	public void .ctor(string value) { }

	// RVA: 0x1EECF20 Offset: 0x1EEC120 VA: 0x181EECF20
	public void .ctor(XCData other) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1EECE20 Offset: 0x1EEC020 VA: 0x181EECE20 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1EECD70 Offset: 0x1EEBF70 VA: 0x181EECD70 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
public class XComment : XNode // TypeDefIndex: 17616
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1EED150 Offset: 0x1EEC350 VA: 0x181EED150
	public void .ctor(string value) { }

	// RVA: 0x1EED0D0 Offset: 0x1EEC2D0 VA: 0x181EED0D0
	public void .ctor(XComment other) { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Value() { }

	// RVA: 0x1EED050 Offset: 0x1EEC250 VA: 0x181EED050 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1EECFA0 Offset: 0x1EEC1A0 VA: 0x181EECFA0 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
private sealed class XContainer.ContentReader // TypeDefIndex: 17617
{
	// Fields
	private readonly NamespaceCache _eCache; // 0x10
	private readonly NamespaceCache _aCache; // 0x20
	private readonly IXmlLineInfo _lineInfo; // 0x30
	private XContainer _currentContainer; // 0x38
	private string _baseUri; // 0x40

	// Methods

	// RVA: 0x1EEAAB0 Offset: 0x1EE9CB0 VA: 0x181EEAAB0
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x1EEAAE0 Offset: 0x1EE9CE0 VA: 0x181EEAAE0
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x1EEA0A0 Offset: 0x1EE92A0 VA: 0x181EEA0A0
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x1EE9230 Offset: 0x1EE8430 VA: 0x181EE9230
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 17618
{
	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__2; // 0x30

	// Properties
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EEBF70 Offset: 0x1EEB170 VA: 0x181EEBF70 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EEC1F0 Offset: 0x1EEB3F0 VA: 0x181EEC1F0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EEC150 Offset: 0x1EEB350 VA: 0x181EEC150 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1EEC150 Offset: 0x1EEB350 VA: 0x181EEC150 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
public abstract class XContainer : XNode // TypeDefIndex: 17619
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1EEEFD0 Offset: 0x1EEE1D0 VA: 0x181EEEFD0
	internal void .ctor(XContainer other) { }

	// RVA: 0x1EEF150 Offset: 0x1EEE350 VA: 0x181EEF150
	public XNode get_LastNode() { }

	// RVA: 0x1EEDBE0 Offset: 0x1EECDE0 VA: 0x181EEDBE0
	public void Add(object content) { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x1EEE870 Offset: 0x1EEDA70 VA: 0x181EEE870
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1EED1D0 Offset: 0x1EEC3D0 VA: 0x181EED1D0
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x1EED5E0 Offset: 0x1EEC7E0 VA: 0x181EED5E0
	internal void AddNode(XNode n) { }

	// RVA: 0x1EED540 Offset: 0x1EEC740 VA: 0x181EED540
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1EED830 Offset: 0x1EECA30 VA: 0x181EED830
	internal void AddString(string s) { }

	// RVA: 0x1EED680 Offset: 0x1EEC880 VA: 0x181EED680
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x1EEE0A0 Offset: 0x1EED2A0 VA: 0x181EEE0A0
	internal void AppendNode(XNode n) { }

	// RVA: 0x1EEDFB0 Offset: 0x1EED1B0 VA: 0x181EEDFB0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1EEE1D0 Offset: 0x1EED3D0 VA: 0x181EEE1D0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1EEE2F0 Offset: 0x1EED4F0 VA: 0x181EEE2F0
	internal void ConvertTextToNode() { }

	// RVA: 0x1EEE3E0 Offset: 0x1EED5E0 VA: 0x181EEE3E0
	internal static string GetStringValue(object value) { }

	// RVA: 0x1EEE8E0 Offset: 0x1EEDAE0 VA: 0x181EEE8E0
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x1EEE9E0 Offset: 0x1EEDBE0 VA: 0x181EEE9E0
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1EEEC50 Offset: 0x1EEDE50 VA: 0x181EEEC50
	internal void RemoveNode(XNode n) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x1EEEE30 Offset: 0x1EEE030 VA: 0x181EEEE30
	internal void WriteContentTo(XmlWriter writer) { }
}

// Namespace: System.Xml.Linq
public class XDeclaration // TypeDefIndex: 17620
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x1EEF480 Offset: 0x1EEE680 VA: 0x181EEF480
	public void .ctor(XDeclaration other) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Encoding() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Standalone() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Version() { }

	// RVA: 0x1EEF2C0 Offset: 0x1EEE4C0 VA: 0x181EEF2C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Linq
public class XDocument : XContainer // TypeDefIndex: 17621
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1EEFF60 Offset: 0x1EEF160 VA: 0x181EEFF60
	public void .ctor(XDocument other) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public XDeclaration get_Declaration() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1EF0000 Offset: 0x1EEF200 VA: 0x181EF0000
	public XElement get_Root() { }

	// RVA: 0x1EEFE10 Offset: 0x1EEF010 VA: 0x181EEFE10 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

